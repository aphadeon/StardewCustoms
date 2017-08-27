using StardewModdingAPI;

namespace StardewCustoms
{
    public class StardewCustomsMod : Mod
    {
        internal static StardewCustomsMod instance;

        public override void Entry(IModHelper helper)
        {
            Log("StardewCustoms is operational.");

            //store a static instance handle to the mod
            instance = this;

            //setup custom object support
            CustomObjectHandler.Setup();

            //to create a custom item:
            //create a new instance of CustomObject, make sure to at least provide all the constructor variables
            //then call CustomObjectHandler.RegisterCustomObject({custom instance})

            
        }

        public static void Log(string message)
        {
            instance.Monitor.Log(message);
        }
    }
}
