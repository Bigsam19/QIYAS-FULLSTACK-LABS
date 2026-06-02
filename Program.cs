using System;
using System.Collections.Generic;
using TmsCore.Exercises.M1_Lab_Section_1;

// 1. Create a collection containing completely different types bound by the same interface contract
IGradable[] cohortAssessments = [
    new Quiz { Title = "C# Basics", CorrectAnswers = 18, TotalQuestions = 20 },
    new LabAssignment { Title = "Registration API", FunctionalityScore = 90m, CodeQualityScore = 85m }
];

// 2. Call the report method
PrintGradeReport(cohortAssessments);


// 3. The Polymorphic Report Method
void PrintGradeReport(IEnumerable<IGradable> assessments)
{
    Console.WriteLine("--- Grade Report ---");
    foreach (var item in assessments)
    {
        // The loop treats every item strictly as an 'IGradable'
        Console.WriteLine($"{item.Title}: {item.CalculateGrade():F2}%");
    }
}