using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Collections;

namespace Chapy
{
    class CreateSchedule
    {
        chapyEntities db = new chapyEntities();
        FrmMakeShift frmMakeShift;
        static Random _r = new Random();
        Hashtable Weekday;

        public CreateSchedule(FrmMakeShift frm)
        {
            Weekday = new Hashtable();
            Weekday["Sunday"] = 6;
            Weekday["Monday"] = 0;
            Weekday["Tuesday"] = 1;
            Weekday["Wednesday"] = 2;
            Weekday["Thursday"] = 3;
            Weekday["Friday"] = 4;
            Weekday["Saturday"] = 5;

            this.frmMakeShift = frm;
            this.staffAvaiDate = frm.getStaffAvaiDate();
            initData();
            initPopulation();
            //initPopulation();
            //DebugLogger.Write("Mark: " + calculateMark(schedules[0]) + "\n");
            //evaluate();
            //
            //crossoverOperation();
            //Console.Write("Mark: " + marks[arranged[0]]);
        }

        public int[][] getResult()
        {
            return schedules;
        }
        public int[][] getClassTeacher()
        {
            return classTeacher;
        }
        public int[] getClassIDs()
        {
            return classIDs;
        }

        
        Hashtable classINF;//no need
        String[] timezoneWeekDays;// no need
        Hashtable staffAvaiDate;    // get from AllTeacherSetting

        int[] classIDs, timezoneIDs;
        int[][] classTeacher;
        int[][][] classDayTimezone;

        int[][] schedules;
        int chroLen;
        private int initData()
        {
            if (this.frmMakeShift == null) return -1;

            timezoneIDs = this.frmMakeShift.getSelectedTzId();  //bring global
            classINF = new Hashtable();   // key: classCode, global
            timezoneWeekDays = new String[100];    //global

            String[] classCodes = new String[100];//no need?
            int classCnt = 0;

            for (int i = 0; i < timezoneIDs.Length; i++)
            {
                var tzID = timezoneIDs[i];
                var timezone = (from p in db.CpTimeZones where p.Id == tzID select p).SingleOrDefault();

                //Week Days
                timezoneWeekDays[i] = timezone.DayOfWeeks;//use tzID ?

                //Apply Classes
                String[] applyClasses = timezone.ApplyClassed.Split(',');
                foreach (String applyCl in applyClasses) if (applyCl != "")
                {
                    String[] a = applyCl.Split(':');
                    String classCode = a[0];
                    int num = Convert.ToInt16(a[1]);
                    if (!classINF.ContainsKey(classCode))
                    {
                        classCodes[classCnt] = classCode;
                        classCnt++;
                        classINF[classCode] = new int[100]; //99 max timezoneid
                        for (int j = 0; j < 100; j++) ((int[])classINF[classCode])[j] = 0;
                    }
                    ((int[])classINF[classCode])[i] = num;//use tzID ?
                }
            }

            //classIDs
            classIDs = new int[classCnt];
            for (int i = 0; i < classCnt; i ++ )
            {
                var classCode = classCodes[i];
                var classinf = (from p in db.CpClasses where p.Code == classCode select p).FirstOrDefault();
                classIDs[i] = classinf.Id;
            }

            //classTeacher
            Boolean[] hasTeacher = new Boolean[200];    // 200 max teacherID
            for (int i = 0; i < 200; i++) hasTeacher[i] = false;

            int[] selectedStaffID = this.frmMakeShift.getSelectedStaffId();
            for (int i = 0; i < selectedStaffID.Length; i++)
            {
                hasTeacher[selectedStaffID[i]] = true;
            }

            classTeacher = new int[classCnt][];
            for (int i = 0; i < classCnt; i++)
            {
                int classId = classIDs[i];
                var classStaff = (from p in db.CpClassStaffs where p.ClassId == classId select p).FirstOrDefault();
                
                int[] teachers = new int[10];
                int teacherCnt = 0;
                if (classStaff.StaffId1 != null && hasTeacher[classStaff.StaffId1])
                {
                    teachers[teacherCnt] = classStaff.StaffId1;
                    teacherCnt++;
                }
                if (classStaff.StaffId2 != null && hasTeacher[(int)classStaff.StaffId2])
                {
                    teachers[teacherCnt] = (int)classStaff.StaffId2;
                    teacherCnt++;
                }
                if (classStaff.StaffId3 != null && hasTeacher[(int)classStaff.StaffId3])
                {
                    teachers[teacherCnt] = (int)classStaff.StaffId3;
                    teacherCnt++;
                }
                if (classStaff.StaffId4 != null && hasTeacher[(int)classStaff.StaffId4])
                {
                    teachers[teacherCnt] = (int)classStaff.StaffId4;
                    teacherCnt++;
                }
                if (classStaff.StaffId5 != null && hasTeacher[(int)classStaff.StaffId5])
                {
                    teachers[teacherCnt] = (int)classStaff.StaffId5;
                    teacherCnt++;
                }
                if (classStaff.StaffId6 != null && hasTeacher[(int)classStaff.StaffId6])
                {
                    teachers[teacherCnt] = (int)classStaff.StaffId6;
                    teacherCnt++;
                }

                classTeacher[i] = new int[teacherCnt];
                for (int j = 0; j < teacherCnt; j++)
                {
                    classTeacher[i][j] = teachers[j];
                }
            }

            // classDayTimezone
            classDayTimezone = new int[classCnt][][];
            for (int i = 0; i < classCnt; i++)
            {
                classDayTimezone[i] = new int[7][];
                for (int j = 0; j < 7; j++)
                {
                    classDayTimezone[i][j] = new int[timezoneIDs.Length];
                    for (int k = 0; k < timezoneIDs.Length; k++)
                    {
                        if (timezoneWeekDays[k][j] == '1' && ((int[])classINF[classCodes[i]])[k] > 0)
                        {
                            classDayTimezone[i][j][k] = ((int[])classINF[classCodes[i]])[k];
                        }
                    }
                }
            }
            //Console.Write(classDayTimezone.ToString());
            return 0;
        }

        int populationNum = 30;
        private void initPopulation()
        {
            DateTime fromDate = this.frmMakeShift.getFromDate(),
                toDate = this.frmMakeShift.getToDate();
            int startDay = (int)Weekday["" + fromDate.DayOfWeek],
                dayNumber = (int)toDate.Subtract(fromDate).TotalDays + 1,
                endDay = startDay + dayNumber ;
            chroLen = 0;
            for (int i = 0; i < classIDs.Length; i++)
            {
                chroLen += classTeacher[i].Length * dayNumber;
            }

            schedules = new int[populationNum][];

            for (int i = 0; i < populationNum; i++)
            {
                schedules[i] = new int[chroLen];
                int cnt = 0;
                for (int classcnt = 0; classcnt < classIDs.Length; classcnt++)
                {
                    for (int daycnt = startDay; daycnt < endDay; daycnt++)
                    {
                        // rest staff
                        int[] rest = new int[classTeacher[classcnt].Length];
                        for (int k = 0; k < rest.Length; k++)
                        {
                            rest[k] = 0;
                        }
                        int restNum = 0;
                        if (this.staffAvaiDate != null)
                        {
                            for (int k = 0; k < rest.Length; k++)
                            {
                                int staffId = classTeacher[classcnt][k];
                                if (this.staffAvaiDate.ContainsKey(staffId) && ((String)this.staffAvaiDate[staffId])[daycnt - startDay] == 'X')
                                {
                                    restNum++;
                                    rest[k] = 1;
                                }
                            }
                        }

                        int[] rs = new int[classTeacher[classcnt].Length - restNum];
                        autoArrangeDayClass(rs, (int[])classDayTimezone[classcnt][daycnt % 7].Clone());
                        
                        for (int j = 0, k = 0; k < rest.Length; j++, k++)
                        {
                            while ( k < rest.Length && rest[k] == 1)
                            {
                                schedules[i][cnt] = 0;
                                k++;
                                cnt++;
                            }
                            if (k < rest.Length)
                            {
                                schedules[i][cnt] = rs[j] == -1 ? 0 : timezoneIDs[rs[j]];
                                cnt++;
                            }
                        }
                    }
                }
            }
        }

        //Generate Day schedule for a class randomly (guarantee teacher quantity in a timezone)
        private void autoArrangeDayClass(int[] rs, int[] timezoneNum)
        {
            //init result
            for (int i = 0; i < rs.Length; i++) rs[i] = -1;

            int slotLeft = Math.Min(timezoneNum.Sum(), rs.Length);
            int teacherLeft = rs.Length;
            for (; slotLeft > 0; slotLeft--, teacherLeft--)
            {
                int slot = _r.Next(slotLeft) + 1;
                int d = timezoneNum[0];
                int tzind = 0;
                while (d < slot)
                {
                    tzind++;
                    d += timezoneNum[tzind];
                }

                int pos = _r.Next(teacherLeft);

                int i = 0;
                while (pos > 0)
                {
                    if (rs[i] == -1) pos--;
                    i++;
                }
                while (rs[i] != -1) i++;
                rs[i] = tzind;
                timezoneNum[tzind]--;
            }
        }

    }
}
