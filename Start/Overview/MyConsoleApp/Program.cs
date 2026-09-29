Console.Write("Please what's your name? : ");

string? name = Console.ReadLine();

Console.WriteLine($"Nice to meet you : {name}.\n");

OperatingSystem OS = Environment.OSVersion;

Console.WriteLine($"The environment we are working on is      : {OS.Platform}.");
Console.WriteLine($"And the OS version of this environment is : {OS.VersionString}.");