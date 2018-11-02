using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rocket.API;
using Rocket.Unturned.Player;

namespace US.PhysicsMaster
{
    public class CommandSetSpeed : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "setspeed";

        public string Help => "";

        public string Syntax => "";

        public List<string> Aliases => new List<String>();

        public List<string> Permissions => new List<String>();

        public void Execute(IRocketPlayer caller, string[] command)
        {
            ((UnturnedPlayer) caller).Player.movement.sendPluginSpeedMultiplier(float.Parse(command[0]));
        }
    }
}
