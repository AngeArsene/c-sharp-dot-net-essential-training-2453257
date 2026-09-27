string? name = "";
OperatingSystem operatingSystem = Environment.OSVersion;

Console.Write("Please what's your name? : ");

name = Console.ReadLine();

Console.WriteLine($"Nice to meet you : {name}.\n");

Console.WriteLine($"The environment we are working on is      : {operatingSystem.Platform}.");
Console.WriteLine($"And the OS version of this environment is : {operatingSystem.VersionString}.");