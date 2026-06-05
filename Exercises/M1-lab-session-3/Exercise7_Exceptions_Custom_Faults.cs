using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace TmsCore.Exercises
{
    public class CapacityReachedException : InvalidOperationException
    {
        public string CourseCode { get; }
        public CapacityReachedException(string courseCode) : base($"Course {courseCode} has reached maximum capacity.") 
            => CourseCode = courseCode;
    }

    public class Exercise7Exceptions
    {
        public static void Run()
        {
            var sw = Stopwatch.StartNew();
            Console.WriteLine("\n========================================");
            Console.WriteLine("     EXERCISE 7: CUSTOM EXCEPTIONS      ");
            Console.WriteLine("========================================");

            var studentList = new List<Student7>
            {
                new() { Id = "S1", Name = "Student-S1", GPA = 3.8m },
                new() { Id = "S2", Name = "Student-S2", GPA = 2.4m },
                new() { Id = "S3", Name = "Student-S3", GPA = 3.5m },
                new() { Id = "S4", Name = "Student-S4", GPA = 1.9m },
                new() { Id = "S5", Name = "Student-S5", GPA = 3.2m }
            };

            var enrollCourse = new Course7 { Code = "CRS-101", Capacity = 2 };
            var failures = new List<string>();
            int successfulEnrollments = 0;

            foreach (var student in studentList)
            {
                if (enrollCourse.EnrolledCount >= enrollCourse.Capacity)
                {
                    failures.Add($"{student.Name}: Course {enrollCourse.Code} has reached maximum capacity.");
                    Console.WriteLine($" Rejected: {student.Name} [Course: {enrollCourse.Code}]");
                }
                else
                {
                    enrollCourse.EnrolledCount++;
                    successfulEnrollments++;
                    Console.WriteLine($" Enrolled: {student.Name}");
                }
            }

            sw.Stop();
            Console.WriteLine("\n========== ENROLLMENT SUMMARY ==========");
            Console.WriteLine($"Total students loaded:  {studentList.Count}");
            Console.WriteLine($"Successful enrollments: {successfulEnrollments}");
            Console.WriteLine($"Failed enrollments:     {failures.Count}");
            Console.WriteLine($"Class average GPA:      {studentList.Average(s => s.GPA):F2}");
            Console.WriteLine($"Total elapsed time:     {sw.ElapsedMilliseconds}ms");
            Console.WriteLine("========================================");
        }
    }

    public class Student7 { public string Id { get; set; } = ""; public string Name { get; set; } = ""; public decimal GPA { get; set; } }
    public class Course7 { public string Code { get; set; } = ""; public int Capacity { get; set; } public int EnrolledCount { get; set; } }
}
