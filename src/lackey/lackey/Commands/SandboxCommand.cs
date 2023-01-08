using lackey.CommandHandlers;
using System.CommandLine;

namespace lackey.Commands
{
    public class SandboxCommand : Command
    {
        public SandboxCommand() : base("sandbox", "Sandbox command to play with things")
        {
            ConfigureCommand();

        }

        private void ConfigureCommand()
        {
            this.SetHandler(() =>
            {
                SandboxCommandHandler.Handle();
            });
        }
    }
}
