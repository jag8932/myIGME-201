using System;
using System.Collections.Generic;

namespace CourseLib
{

    // Name: Jacob Goodwillie
    // Date: 9/23/2020
    // Description: Set up a class library using the schUML in the homework.
    public class Schedule
    {
        // Start time and end time fields declared. Public list of days of the week created.
        public DateTime startTime;
        public DateTime endTime;
        public List< DayOfWeek> daysOfWeek = new List<DayOfWeek>();

        
    }


    // Class that defines a course.
    public class Course
    {
        // Variables that define a course and give it details.
        public string courseCode;
        public string description;
        public string teacherEmail;
        public Schedule schedule;


        // Constructor which takes the course code and description as parameters.
        public Course(string courseCode, string description)
        {
            this.courseCode = courseCode;
            this.description = description;
        }
    }

    // Creates a list of courses.
     class Courses
    {
        public SortedList<string, Course> SortedList = new SortedList<string, Course>();

        public Courses()
        {
            Course thisCourse;
            Schedule thisSchedule;

            Random rand = new Random();

            // generate courses IGME-200 through IGME-299
            for (int i = 200; i < 300; ++i)
            {
                // use constructor to create new course object with code and description
                thisCourse = new Course(($"IGME-{i}"), ($"Description for IGME-{i}"));

                // create a new Schedule object
                thisSchedule = new Schedule();
                for (int dow = 0; dow < 7; ++dow)
                {
                    // 50% chance of the class being on this day of week
                    if (rand.Next(0, 2) == 1)
                    {
                        // add to the daysOfWeek list
                        thisSchedule.daysOfWeek.Add((DayOfWeek)dow);

                        // select random hour of day
                        int nHour = rand.Next(0, 24);

                        // set start and end times of minute duration
                        // select fixed date to allow time calculations
                        thisSchedule.startTime = new DateTime(1, 1, 1, nHour, 0, 0);
                        thisSchedule.endTime = new DateTime(1, 1, 1, nHour, 50, 0);
                    }
                }

                // set the schedule for this course
                thisCourse.schedule = thisSchedule;

                // add this course to the SortedList
                this[thisCourse.courseCode] = thisCourse;
            }
        }

    }

}

