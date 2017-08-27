using StardewModdingAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDCExampleMod
{
    public class SDCExampleMod : Mod
    {
        public override void Entry(IModHelper helper)
        {
            StardewCustoms.CustomObject myObject = new StardewCustoms.CustomObject("exampleMod", "myObject");
            StardewCustoms.CustomObjectHandler.RegisterCustomObject(myObject);
        }
    }
}
