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
        chapyEntities db = new chapyEntities(VariableGlobal.connectionString);
        FrmMakeShift frmMakeShift;
        Hashtable staffAvaiDate;    // get from AllTeacherSetting
        static Random _r = new Random();
        Hashtable Weekday;
        int status = 0; // 0: chua lam, 1: ok, -1: failed
        String errMess = "";

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

        public int getStatus(){
            return status;
        }
        public String getErrMessage()
        {
            return errMess;
        }
        

        public int[][] getResult(int n)
        {
            int[][] results = new int[n][];
            for (int num = 0; num < n; num++)
            {
                int[] norSche = new int[normalScheduleLength];

                int cnt = 0;
                for (int i = 0; i < chroLen; i++)
                {
                    int[] a = allArranges[i].convertArrange(schedules[num][i]);
                    for (int j = 0; j < a.Length; j++)
                    {
                        norSche[cnt] = a[j];
                        cnt++;
                    }
                }

                results[num] = norSche;
            }

            return results;
        }
        public int[][] getClassTeacher()
        {
            return classStaffIDs;
        }
        public int[] getClassIDs()
        {
            return classIDs;
        }
        

        int[] classIDs, waIDs;
        public static int[][] classStaffIDs;
        ClassDayArrangement[] allArranges;

        int[][] schedules;
        int chroLen, normalScheduleLength;
        private int initData()
        {
            if (this.frmMakeShift == null) return -1;

            waIDs = this.frmMakeShift.getSelectedTzId();  //bring global
            Hashtable classInfo = new Hashtable();   // key: classID, global ?, lop nay vao timezone thu i, can ? nguoi
            String[] waWeekDay = new String[waIDs.Length];    //global ?

            String[] classCodes = new String[100];//no need?
            int classCnt = 0;

            for (int i = 0; i < waIDs.Length; i++)
            {
                var tzID = waIDs[i];
                var timezone = (from p in db.CpTimeZones where p.Id == tzID select p).SingleOrDefault();

                //Week Days
                waWeekDay[i] = timezone.DayOfWeeks;//use tzID ?

                //Apply Classes
                String[] applyClasses = timezone.ApplyClassed.Split(',');
                foreach (String applyCl in applyClasses) if (applyCl != "")
                {
                    String[] a = applyCl.Split(':');
                    String classID = a[0];
                    int num = Convert.ToInt16(a[1]);
                    if (!classInfo.ContainsKey(classID))
                    {
                        classCodes[classCnt] = classID;
                        classCnt++;
                        classInfo[classID] = new int[waIDs.Length]; //99 max timezoneid
                        for (int j = 0; j < waIDs.Length; j++) ((int[])classInfo[classID])[j] = 0;
                    }
                    ((int[])classInfo[classID])[i] = num;//use i/tzID ?
                }
            }

            int school_id = VariableGlobal.school_id;

            //classIDs
            classIDs = new int[classCnt];
            for (int i = 0; i < classCnt; i ++ )
            {
                classIDs[i] = Convert.ToInt32(classCodes[i]);
            }



            //classStaffIDs
            Boolean[] hasTeacher = new Boolean[200];    // 200 max teacherID, danh dau xem da chon nhung teacher nao
            for (int i = 0; i < 200; i++) hasTeacher[i] = false;

            int[] selectedStaffID = this.frmMakeShift.getSelectedStaffId();
            for (int i = 0; i < selectedStaffID.Length; i++)
            {
                hasTeacher[selectedStaffID[i]] = true;
            }

            // doc tu db ra cac giao vien day lop trong hoc ky da chon
            int termID = frmMakeShift.getTermID(); // hoc ky da chon o mh truoc
            classStaffIDs = new int[classCnt][];
            for (int i = 0; i < classCnt; i++)
            {
                int classId = classIDs[i];
                var classStaff = (from p in db.CpClassStaffs where p.ClassId == classId && p.TermId == termID select p).FirstOrDefault();
                
                // neu chua dk giao vien
                if (classStaff == null)
                {
                    this.status = -1;
                    this.errMess = "Dk giao vien cho lop co id " + classId;
                    continue;
                }

                int[] teachers = new int[20];
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

                // gan vao mang cac giao vien cua cac lop
                classStaffIDs[i] = new int[teacherCnt];
                for (int j = 0; j < teacherCnt; j++)
                {
                    classStaffIDs[i][j] = teachers[j];
                }
            }

            // tinh do dai cho 1 cach xep lich
            DateTime fromDate = this.frmMakeShift.getFromDate(),
                toDate = this.frmMakeShift.getToDate();
            int dayNumber = (int)toDate.Subtract(fromDate).TotalDays + 1;
            chroLen = classIDs.Length * dayNumber;

            //normal length
            normalScheduleLength = 0;
            for (int i = 0; i < classIDs.Length; i++)
            {
                normalScheduleLength += classStaffIDs[i].Length * dayNumber;
            }

            /*start new here*/
            CalculateClassDayArrangement(waWeekDay, classInfo);

            
            
            //Console.Write(classDayTimezone.ToString());
            return 0;
        }

        // Sinh ra tap dau tien
        int populationNum = 30;
        private void initPopulation()
        {

            schedules = new int[populationNum][];

            for (int i = 0; i < populationNum; i++)
            {
                int[] schedule = new int[chroLen];

                for (int j = 0; j < chroLen; j++)
                {
                    schedule[j] = _r.Next(allArranges[j].getArranges().Count);
                }

                schedules[i] = schedule;
            }
        }

        //ham tinh diem
        private int calculatePoint(int[] chromosome)
        {

            return 0;
        }

        //Giao phoi chon giong, dot bien de sinh ra the he moi
        private void crossOver(int[][] chromosomes)
        {
            // thuc hien lap n lan

                // chon ngau nhien 1 cap bo me

                // thuc hien giao cheo bo me sinh ra con

                // danh gia diem con

                // chon ngau nhien 1 ca the (ko fai 1 trong 10 ca the tot nhat) thay the bang ca the moi

                // dua ca the moi vao top 10 neu can

                // lap lai
        }


        void CalculateClassDayArrangement(String[] waWeekday, Hashtable classInfo)
        {
            int classNumber = classIDs.Length;
            ClassDayArrangement[] WeekArrangement = new ClassDayArrangement[7 * classNumber];

            int cnt = 0;
            for (int i = 0; i < classNumber; i++)
            {
                int classID = classIDs[i];
                for (int j = 0; j < 7; j++)
                {
                    int[] waNumber = (int[]) ((int[])classInfo["" + classID]).Clone();

                    for (int c = 0; c < waNumber.Length; c++) if (waNumber[c] > 0 && waWeekday[c][j] == '0')
                    {
                        waNumber[c] = 0;
                    }
                    ClassDayArrangement cda = new ClassDayArrangement(i, waNumber);
                    cda.generateAllArrangement();
                    WeekArrangement[cnt] = cda;
                    cnt++;
                }
            }

            // set bien dem, duyet tung lop tung ngay
            DateTime fromDate = this.frmMakeShift.getFromDate(),
                toDate = this.frmMakeShift.getToDate();
            int startDay = (int)Weekday["" + fromDate.DayOfWeek],
                dayNumber = (int)toDate.Subtract(fromDate).TotalDays + 1,
                endDay = startDay + dayNumber;

            cnt = 0;
            allArranges = new ClassDayArrangement[chroLen];
            for (int i = 0; i < classNumber; i++)
            {
                for (int daycnt = startDay; daycnt < endDay; daycnt++)
                {
                    // copy from WeekDayArrange
                    ClassDayArrangement wda = WeekArrangement[i * 7 + daycnt % 7];
                    int[] waNumber = (int[]) wda.getWaNumber().Clone();
                    allArranges[cnt] = new ClassDayArrangement(i, waNumber);
                    allArranges[cnt].setArranges(wda.getArranges());

                    cnt++;
                }
            }
        }
    }


    class ClassDayArrangement : ICloneable
    {
        // intput
        int[] waNumber; // do dai co dinh, tuong voi cac WA dc chon
        int classIndex;
        bool[] rest;    //danh dau nhung gv nghi
        int[] staffIDs;

        // output
        List<int[]> arranges;
        int[] point;

        public ClassDayArrangement(int classInd, int[] waNum)
        {
            this.classIndex = classInd;
            this.waNumber = waNum;

            this.staffIDs = null;
            if (CreateSchedule.classStaffIDs != null && CreateSchedule.classStaffIDs.Length > classIndex)
            {
                this.staffIDs = CreateSchedule.classStaffIDs[classIndex];
            }
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public List<int[]> getArranges()
        {
            return arranges;
        }

        public int[] getWaNumber()
        {
            return this.waNumber;
        }

        public void setArranges(List<int[]> arrs)
        {
            this.arranges = new List<int[]>();
            foreach (int[] arr in arrs)
            {
                this.arranges.Add( (int[])arr.Clone() );
            }
        }

        // convert dang arrange hien tai thanh dang hien thi dc schedule
        public int[] convertArrange(int ind)
        {
            int[] arr = this.getArranges()[ind];
            int[] a = new int[this.staffIDs.Length];
            for (int i = 0; i < a.Length; i++) a[i] = -1;   // default nghi

            if (this.staffIDs == null) return a;

            int c = 0;
            for (int i = 0; i < waNumber.Length; i++)
            {
                for (int j = 0; j < waNumber[i]; j++)
                {
                    if (arr[c] >= 0) a[arr[c]] = i;
                    c++;
                }
            }
            return a;
        }


        public void generateAllArrangement()
        {
            int staffNum = (this.staffIDs == null) ? 
                0 : CreateSchedule.classStaffIDs[classIndex].Length;
            int number = waNumber.Sum();
            int total = (staffNum > number) ? staffNum : number;

            // khoi tao rest
            rest = new bool[total];
            for (int i = 0; i < total; i++)
            {
                if (i < staffNum) rest[i] = false;
                else rest[i] = true;
            }

            bool[] free = new bool[total], waStart = new bool[number];
            for (int i = 0; i < total; i++)
            {
                free[i] = true;
            }

            // cach dau tien
            int[] arrange = new int[number];
            
            for (int i = 0; i < number; i++)
            {
                arrange[i] = i;
                free[i] = false;
                waStart[i] = false;
            }

            // danh dau diem bat dau cua tung wa
            int startInd = 0;
            for (int i = 0; i < waNumber.Length; i++) if (waNumber[i] > 0)
            {
                waStart[startInd] = true;
                startInd += waNumber[i];
            }

            // gan cach dau tien vao kq
            arranges = new List<int[]>();
            int resultNumber = 1;
            //arranges[0] = (int[])arrange.Clone();
            arranges.Add( (int[])arrange.Clone() );

            //sinh ra cach tiep theo
            while (true)
            {
                // duyet bat dau tu thang cuoi cung
                int i;
                for (i = number - 1; i >= 0; i--)
                {
                    //tim thang free tiep theo
                    int nextf = nextFree(arrange[i], free);
                    
                    // neu co
                    if (nextf > -1)
                    {
                        // free thang hien tai va nhung thang o sau cung wa
                        free[arrange[i]] = true;
                        int j;
                        for (j = i + 1; j < number && !waStart[j]; j++)
                        {
                            free[arrange[j]] = true;
                        }

                        // bat dau tu thang hien tai gan next free cho nhung thang tiep theo cung wa
                        j = i;
                        while (true)
                        {
                            arrange[j] = nextf;
                            free[nextf] = false;
                            nextf = nextFree(nextf, free);
                            j++;

                            if ( j == number || waStart[j] ) break;//sang wa khac
                        }
                        // nhung wa sau gan next free tu dau tro di
                        nextf = nextFree(-1, free); //tim thang free dau tien
                        while (j < number)
                        {
                            arrange[j] = nextf;
                            free[nextf] = false;
                            nextf = nextFree(nextf, free);
                            j++;
                        }

                        break;  //dung sau khi da sinh dc kq tiep theo
                    }
                    // duyet tiep thang trc, neu chuan bi sang wa khac free nhung thang thuoc wa nay
                    if (waStart[i])
                    {
                        free[arrange[i]] = true;
                        for (int j = i + 1; j < number && !waStart[j]; j++)
                        {
                            free[arrange[j]] = true;
                        }
                    }
                }

                if (i < 0) break;   // da sinh den thang cuoi cung

                // sinh dc thang moi, gan vao kq
                arranges.Add((int[])arrange.Clone());
                resultNumber++;
            }

            updateArrangesWithRest();

            //Print kq
            foreach (int[] arr in arranges)
            {
                for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");
                Console.WriteLine();
            }
            Console.WriteLine(resultNumber);
        }

        private int nextFree(int i, bool[] free)
        {
            int number = free.Length;
            for (i = i + 1; i < number; i++)
            {
                if (free[i]) return i;
            }

            return -1;
        }

        private int evalArrange(int[] arrange){
            int point = 100;

            // co du so nguoi ko
            for (int i = 0; i < arrange.Length; i++)
            {
                if (arrange[i] < 0) point -= 30;
            }

            // co cap voi thang nao ko dc ko

            // trong 1 wa co it nhat 1 thang kinh nghiem

            return point;
        }

        public void evalAll()
        {
            //Print kq
            int i = 0;
            foreach (int[] arr in arranges)
            {
                point[i] = evalArrange(arr);
                i++;
            }
        }

        // set nhung staff nghi, update arranges
        public void setRestStaff(int[] restIds)
        {
            if (this.staffIDs == null) return;

            // update rest
            foreach (int restid in restIds)
            {
                for (int i = 0; i < staffIDs.Length; i++)
                {
                    if (staffIDs[i] == restid)
                    {
                        rest[i] = true;
                        break;
                    }
                }
            }

            updateArrangesWithRest();
        }

        public void updateArrangesWithRest()
        {
            foreach (int[] arr in arranges)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if ( arr[i] > -1 && rest[arr[i]]) arr[i] = -1;
                }
            }
        }
    }

}



