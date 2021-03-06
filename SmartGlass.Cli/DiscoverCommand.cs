using System;
using System.Threading;
using System.Threading.Tasks;
using NClap.Metadata;

namespace SmartGlass.Cli
{
    internal class DiscoverCommand : Command
    {
        public override async Task<CommandResult> ExecuteAsync(CancellationToken cancel)
        {
            var devices = await Device.DiscoverAsync();

            foreach (var device in devices)
            {
                Console.WriteLine($"{device.Name} ({device.HardwareId}) {device.Address} {device.LiveId}");
            }

            return CommandResult.Success;
        }
    }
}