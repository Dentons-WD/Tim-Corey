using CliWrap;
using CliWrap.Buffered;

//var dockerResults = await Cli.Wrap("docker")
//    .WithArguments(new[] { "--version" })
//    .ExecuteBufferedAsync();

//Console.WriteLine(dockerResults.StandardOutput);

//var gitResults = await Cli.Wrap("git")
//    .WithArguments(new[] { "--version" })
//    .ExecuteBufferedAsync();

//Console.WriteLine(gitResults.StandardOutput);

//var cmdResults = await Cli.Wrap(@"../../../../demo.bat")
//    .ExecuteBufferedAsync();

//Console.WriteLine(cmdResults.StandardOutput);

var powershellResults = await Cli.Wrap(@"powershell")
    .WithArguments(new [] { @"../../../../demo.ps1" })
    .ExecuteBufferedAsync();

Console.WriteLine(powershellResults.StandardOutput);

Console.ReadLine();