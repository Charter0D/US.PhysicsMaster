using Rocket.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace US.PhysicsMaster
{
    public class Config : IRocketPluginConfiguration
    {
        public List<PhysEdit> PhysEdits;
        public void LoadDefaults()
        {
            PhysEdits = new List<PhysEdit>()
            {
                new PhysEdit()
                {
                    Permission = "us.pm.vip",
                    Gravity = 1,
                    Speed = 3
                }
            };
        }
    }

    public class PhysEdit
    {
        public string Permission;
        public float Speed;
        public float Gravity;
    }
}
