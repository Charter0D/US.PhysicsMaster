using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rocket.API;
using Rocket.Unturned.Player;

namespace US.PhysicsMaster
{
    public class CommandSetGravity : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "setgravity";

        public string Help => "";

        public string Syntax => "";

        public List<string> Aliases => new List<String>();

        public List<string> Permissions => new List<String>();

        public void Execute(IRocketPlayer caller, string[] command)
        {
            ((UnturnedPlayer)caller).Player.movement.sendPluginGravityMultiplier(float.Parse(command[0]));
        }
    }
}
