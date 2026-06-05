using System;
using System.Threading.Tasks;
using TmsCore.Exercises; // <-- This tells the compiler where to look!

Console.WriteLine("=============================================");
Console.WriteLine("   TMS Core Learning Management Dashboard   ");
Console.WriteLine("=============================================");

// 1. Keep your existing Exercise 6 call intact:
await Exercise6Async.Run();

// 2. Run Exercise 7 right below it cleanly:
Exercise7Exceptions.Run();