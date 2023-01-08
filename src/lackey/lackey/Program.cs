using lackey.Commands;
using System.CommandLine;

// The root command represents the executable name i.e. lackey
var commandRoot = new RootCommand();

// Wire up the commands you want to expose to the CLI
commandRoot.AddCommand(new SandboxCommand());

// Let the magic of System.CommandLine determine how to parse and execute commands
await commandRoot.InvokeAsync(args);