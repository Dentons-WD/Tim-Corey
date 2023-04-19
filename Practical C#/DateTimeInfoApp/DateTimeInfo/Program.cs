
using System.Globalization;

DateTime sample1 = DateTime.Now;
DateTime sample2 = DateTime.UtcNow;

//Console.WriteLine(sample1.ToUniversalTime());
//Console.WriteLine(sample2.ToLocalTime());

//Console.WriteLine(sample1);
//Console.WriteLine(sample1.AddHours(30));
//Console.WriteLine(sample1.AddHours(-30));

TimeSpan ts = TimeSpan.Parse("-5:4:15:13.12345");

//Console.WriteLine(ts);

//Console.WriteLine(sample1.Add(ts));

DateTime sample3 = sample1.Add(ts);
//Console.WriteLine(sample3);

//Console.WriteLine(sample3.Subtract(ts));

//Console.WriteLine($"Halfway point: { sample1.Add(ts.Divide(2)) }");
//Console.WriteLine($"Triple point: { sample1.Add(ts.Multiply(3)) }");

//Console.WriteLine(ts.Duration());

//Console.WriteLine($"Comparing sample1 to sample3: { DateTime.Compare(sample1, sample3) }");
//Console.WriteLine($"Comparing sample3 to sample1: { DateTime.Compare(sample3, sample1) }");
//Console.WriteLine($"Comparing sample1 to sample1: { DateTime.Compare(sample1, sample1) }");

//Console.WriteLine($"Short Date: { sample1.ToString("d") }");
//Console.WriteLine($"Long Date: { sample1.ToString("D") }");
//Console.WriteLine($"Short Time: { sample1.ToString("t") }");
//Console.WriteLine($"Long Time: { sample1.ToString("T") }");

//Console.WriteLine($"Round Trip DateTime: { sample1.ToString("O") }");

//Console.WriteLine($"Full Short DateTime: { sample1.ToString("f") }");
//Console.WriteLine($"Full Long DateTime: { sample1.ToString("F") }");
//Console.WriteLine($"General Short DateTime: { sample1.ToString("g") }");
//Console.WriteLine($"General Long DateTime: { sample1.ToString("G") }");

//Console.WriteLine($"Sortable DateTime: { sample1.ToString("s") }");
//Console.WriteLine($"Universal DateTime: { sample1.ToString("U") }");

//Console.WriteLine($"Custom: { sample1.ToString("MMM dd, yyyy hh:mm tt zzz") }");
//Console.WriteLine($"Custom: { sample1.ToString("dd/MM/yy HH:mm zzz") }");

//DateTime sample4 = DateTime.Parse("3/11/2021");
//DateTime sample5 = DateTime.ParseExact("3/11/2021", "d/MM/yyyy", CultureInfo.InvariantCulture);

//Console.WriteLine(sample4);
//Console.WriteLine(sample5);

DateOnly date1 = DateOnly.FromDateTime(DateTime.Now);
TimeOnly time1 = TimeOnly.FromDateTime(DateTime.Now);

Console.WriteLine(date1);
Console.WriteLine(time1);