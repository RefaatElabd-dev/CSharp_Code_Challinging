using System;
using NullOperators;

Console.WriteLine($"When s = Refaat ====> Output = {CodeHelper.UseCNullCoalescingAssignment("Refaat")}");
Console.WriteLine($"\nWhen s = 'NULL' ====> Output = {CodeHelper.UseCNullCoalescingAssignment()}");

Console.ReadLine();