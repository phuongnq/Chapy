using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapy
{
    public class MakeSchedule
    {
        String[] classes;
        int[] classIds;
        int[][] classTeacher;
        int[] classTeacherNums;
        //int[] teacherIds;
        String[] teacherName;

        //
        TimeZone[] timezones;

        int[] weekTimeZone;

        int[][] schedules;   //All schedule
        int chromosomeLength, classNumber;   // a schedule length
        float[] marks; // Mark for each shcedule
        int[] classStartInd;

        //Constant
        const int populationNum = 30;

        static Random _r = new Random();

        public MakeSchedule()
        {
            initData();
            initPopulation();
            //DebugLogger.Write("Mark: " + calculateMark(schedules[0]) + "\n");
            evaluate();
            //
            crossoverOperation();
            Console.Write("Mark: " + marks[arranged[0]]);
        }

        public void initData()
        {
            classNumber = 4;
            classIds = new int[] { 1, 2, 3, 4 };
            //teacherIds = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11, 12 };

            classTeacherNums = new int[4] { 5, 5, 6, 5 };
            classTeacher = new int[4][];
            classTeacher[0] = new int[]{ 1, 6, 4, 10, 11};
            classTeacher[1] = new int[]{ 13, 2, 3, 9, 15};
            classTeacher[2] = new int[]{ 6, 1, 3, 14, 17, 16};
            classTeacher[3] = new int[]{ 8, 11, 12, 1, 18};

            timezones = new TimeZone[3];
            timezones[0] = new TimeZone(1, 1, new int[7] { 1, 1, 1, 1, 1, 0, 0 }, 7.0f, 12.0f);
            timezones[1] = new TimeZone(2, 2, new int[7] { 1, 1, 1, 1, 1, 1, 1 }, 10.0f, 18.0f);
            timezones[2] = new TimeZone(3, 2, new int[7] { 0, 0, 0, 1, 0, 1, 1 }, 18.0f, 20.0f);

            TimeZone.calculateWdayTzNum(timezones);

            weekTimeZone = new int[7];
            for (int i = 0; i < 7; i++)
            {
                weekTimeZone[i] = 0;
                for (int j = 0; j < timezones.Length; j++)
                {
                    weekTimeZone[i] += timezones[j].weekDay[i];
                }
            }

            marks = new float[populationNum];

            //Class start index in a choromosome
            classStartInd = new int[classNumber];
            int startInd = 0;
            for (int i = 0; i < classNumber; i++)
            {
                classStartInd[i] = startInd;
                startInd += classTeacherNums[i] * dayNumber;
            }
        }

        int dayNumber = 30; //30 days in a month

        //Create first generation randomly
        public void initPopulation()
        {
            // caculate a chromosome length
            chromosomeLength = 0;
            for (int i = 0; i < classNumber; i++)
            {
                chromosomeLength += classTeacherNums[i] * dayNumber;
            }

            //init schedules array
            schedules = new int[populationNum][];//, chromosomeLength];

            
            int classCount, teacherCount, dayCount;
            for (int i = 0; i < populationNum; i++)
            {
                schedules[i] = new int[chromosomeLength];
                int count = 0;
                for (classCount = 0; classCount < classNumber; classCount++)
                {
                    //DebugLogger.Write("Class: " + classCount + "\n");
                    for (dayCount = 0; dayCount < dayNumber; dayCount++)
                    {
                        //calculate timzoneNumber - teacher number required in each timzone
                        int[] timzoneNumber = new int[timezones.Length + 1];    //plus 1 for no working

                        int numberRequired = 0; // can not bigger than all teacher number this class has

                        for (int tzind = 0; tzind < timezones.Length; tzind++)
                        {
                            timzoneNumber[tzind + 1] = timezones[tzind].teacherNumber * timezones[tzind].weekDay[dayCount % 7];
                            numberRequired += timzoneNumber[tzind + 1];
                            if (numberRequired > classTeacherNums[classCount])
                            {   // not enough teacher
                                timzoneNumber[tzind + 1] = classTeacherNums[classCount] - (numberRequired - timezones[tzind].teacherNumber);
                                break;
                            }
                        }
                        if (numberRequired <= classTeacherNums[classCount])
                            timzoneNumber[0] = classTeacherNums[classCount] - numberRequired; // not working number

                        int[] rs = new int[classTeacherNums[classCount]];

                        autoArrangeDayClass(rs, timzoneNumber);

                        //apply rs to current schedule
                        for (teacherCount = 0; teacherCount < classTeacherNums[classCount]; teacherCount++)
                        {
                            schedules[i][count] = rs[teacherCount];
                            //DebugLogger.Write(schedules[i][count] + " ");
                            count++;
                        }
                    }
                    //DebugLogger.Write("\n");
                }
                //DebugLogger.Write("\n");
                //DebugLogger.Write("\n");
                
            }
            //DebugLogger.LogArray(schedules);
        }

        //Generate Day schedule for a class randomly (guarantee teacher quantity in a timezone)
        public void autoArrangeDayClass(int[] rs, int[] timezoneNum )
        {
            int slotLeft = timezoneNum.Sum();
            for (int i = 0; slotLeft > 0; slotLeft--, i++) 
            {
                int slot = _r.Next(slotLeft) + 1;
                int d = timezoneNum[0];
                int tzind = 0;
                while (d < slot)
                {
                    tzind ++;
                    d += timezoneNum[tzind];
                }

                rs[i] = tzind;
                timezoneNum[tzind]--;
            }
        }

        int[] arranged;
        public void evaluate()
        {
            for (int i = 0; i < populationNum; i++)
            {
                marks[i] = calculateMark(schedules[i]);
                Console.Write("Chromosome " + i + ": " + marks[i] + "\n");
            }

            // Arrange choromosomes
            arranged = new int[populationNum];
            for (int i = 0; i < populationNum; i++) arranged[i] = i;
            for (int i = 0; i < populationNum -1; i++)
                for (int j = i + 1; j < populationNum; j++)
                {
                    if (marks[arranged[i]] > marks[arranged[j]])
                    {
                        int tg = arranged[i];
                        arranged[i] = arranged[j];
                        arranged[j] = tg;
                    }
                }
        }

        /*
         * Criteria
         * 1. no more than 1 shift assigned to 1 teacher a day
         */
        public float calculateMark(int[] chromosome)
        {
            //criteria 1
            int mark = 500;
            int teacherIdmax = 20; // biggest teacher id
            int[] teacherShift = new int[teacherIdmax + 1]; //determine a teacher already assigned or not
            for (int daycnt = 0; daycnt < dayNumber; daycnt++)
            {
                //initialize teacherShift array to 0
                for (int i = 0; i <= teacherIdmax; i++)
                {
                    teacherShift[i] = 0;
                }

                for (int classcnt = 0; classcnt < classNumber; classcnt++)
                {
                    int startInd = classStartInd[classcnt] + daycnt*classTeacherNums[classcnt]; //start index in chromosome
                    for (int i = 0; i < classTeacherNums[classcnt]; i++)
                    {
                        int teacherId = classTeacher[classcnt][i];
                        if (chromosome[startInd + i] != 0){
                            if (teacherShift[teacherId] == 0)
                            {
                                teacherShift[teacherId] = chromosome[startInd + i];
                            }
                            else
                            {//decrease mark if this teacher already assigned today
                                mark--;
                            }
                        }
                    }
                }
            }

            //criteria 2

            return mark;
        }

        public void test()
        {
            for (; ; )
            {
                int[] rs = new int[6];
                int[] timezoneNum = new int[] { 0, 2, 2 };
                autoArrangeDayClass(rs, timezoneNum);
                Console.WriteLine(rs.ToString());//.LogArray(rs);
                Console.ReadLine();
            }
        }

        int maxOperationNum = 10000;
        //int upperInd, lowerInd;
        public void crossoverOperation()
        {

            for (int cnt = 0; cnt < maxOperationNum; cnt++)
            {
                if (marks[arranged[0]] == 500) break;

                int p1 = _r.Next(populationNum);
                int p2 = _r.Next(populationNum);
                int[] child = createChild(schedules[p1], schedules[p2]);
                mutation(child);
                float mark = calculateMark(child);

                int replaceP = _r.Next(populationNum - 10) + 10;//ensure the top 10 not be replaced
                int replaceInd = arranged[replaceP];

                /*int i = populationNum - 1;
                while (marks[arranged[i]] < mark)
                {
                    if (i > 0) arranged[i] = arranged[i - 1];
                    i--;
                }
                arranged[i + 1] = replaceInd;*/

                schedules[replaceInd] = child;
                marks[replaceInd] = mark;

                //insert the new child to top 10
                if (mark > marks[arranged[9]])
                {
                    arranged[replaceP] = arranged[9];
                    int i = 8;
                    while (i >= 0 && mark > marks[arranged[i]])
                    {
                        arranged[i + 1] = arranged[i];
                        i--;
                    }
                    arranged[i + 1] = replaceInd;
                }
                //DebugLogger.Write(mark + " ");
            }
            Console.Write("\n");
        }

        int[] createChild(int[] p1, int[] p2)
        {
            int crossoverP = _r.Next(classNumber * dayNumber);// slice every day unit - never cut a day
            
            int crossoverInd = 0;
            int d = crossoverP;
            int classCnt = 0;
            while (d >= dayNumber)
            {
                crossoverInd += classTeacherNums[classCnt] * dayNumber;
                classCnt++;
                d -= dayNumber;
            }
            crossoverInd += classTeacherNums[classCnt] * d;

            // create child
            int[] child = new int[chromosomeLength];
            int i = 0;
            for (; i < crossoverInd; i++)
            {
                child[i] = p1[i];
            }

            for (; i < chromosomeLength; i++)
            {
                child[i] = p2[i];
            }

            return child;
        }
        void mutation(int[] child)
        {
            int mutationP = _r.Next(classNumber * dayNumber);//choose the day that mutation occur

            int mutationInd = 0;
            int d = mutationP;
            int classCnt = 0;
            while (d >= dayNumber)
            {
                mutationInd += classTeacherNums[classCnt] * dayNumber;
                classCnt++;
                d -= dayNumber;
            }
            mutationInd += classTeacherNums[classCnt] * d;

            // 2 swap point
            int i1 = _r.Next(classTeacherNums[classCnt]) + mutationInd;
            int i2 = _r.Next(classTeacherNums[classCnt]) + mutationInd;

            //swap
            int tg = child[i1];
            child[i1] = child[i2];
            child[i2] = tg;
        }

    }

    class TimeZone
    {
        public int id;
        public int teacherNumber;
        public int[] weekDay;
        float startTime, endTime, startBreak1, endBreak1, startBreak2, endBreak2;

        public TimeZone(int id, int teacherNumber, int[] weekDay, float startTime, float endTime)
        {
            this.id = id;
            this.teacherNumber = teacherNumber;
            this.weekDay = weekDay;
            this.startTime = startTime;
            this.endTime = endTime;
        }

        //Number of teacher needed in each day timezone
        public static int[,] wdayTimezoneNum;
        public static void calculateWdayTzNum(TimeZone[] timzones){
            int weekDayNum = 7;
            int timezoneNum = timzones.Length;
            wdayTimezoneNum = new int[7, timezoneNum];
            for (int i = 0; i < weekDayNum; i++)
            {
                for (int j = 0; j < timezoneNum; j++)
                {
                    wdayTimezoneNum[i, j] = timzones[j].weekDay[i] * timzones[j].teacherNumber;
                }
            }
        }
    }

    //class Class
}
