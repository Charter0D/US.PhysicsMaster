using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rocket.API;
using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Player;

namespace US.PhysicsMaster
{
    public class Plugin : RocketPlugin<Config>
    {
        protected override void Load()
        {
            U.Events.OnPlayerConnected += Events_OnPlayerConnected;
        }

        private void Events_OnPlayerConnected(UnturnedPlayer player)
        {
            foreach (var v in Configuration.Instance.PhysEdits)
            {
                if (player.HasPermission(v.Permission))
                {
                    player.Player.movement.sendPluginSpeedMultiplier(v.Speed);
                    player.Player.movement.sendPluginGravityMultiplier(v.Gravity);
                    return;
                }
            }
        }

        protected override void Unload()
        {
            U.Events.OnPlayerConnected -= Events_OnPlayerConnected;
        }
    }
}
