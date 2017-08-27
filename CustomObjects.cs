using Microsoft.Xna.Framework;
using StardewValley;
using System.Collections.Generic;

namespace StardewCustoms
{
    public static class CustomObjectHandler
    {
        public static int BaseItemId
        {
            get { return 921; }
        }

        private static Dictionary<string, CustomObject> CustomObjects = new Dictionary<string, CustomObject>();

        internal static void Setup()
        {
            //first, create our base object data
            Game1.objectInformation.Add(BaseItemId, "CustomItem / 375 / -300 / Basic - 26 / CustomItem / A custom item that isn't loaded properly.");
        }

        //this is a public API method
        public static void RegisterCustomObject(CustomObject customObject)
        {
            if(customObject != null) {
                if (string.IsNullOrWhiteSpace(customObject.ObjectId)) customObject.ObjectId = "?";
                if (string.IsNullOrWhiteSpace(customObject.ModId)) customObject.ModId = "?";
                CustomObjects[customObject.GlobalId] = customObject;
            }
        }
    }

    //this is a class designed to be implemented by other mods
    //nearly everything here should be virtual/overrideable
    //our base class, handed to the game, will forward most calls to this instance
    //(to avoid having people mess with a class that does internal stuff for us)
    public class CustomObject
    {
        public string ObjectId;
        public string ModId;
        public string GlobalId
        {
            get { return ModId + ":" + ObjectId; }
        }

        public CustomObject(string modId, string objectId)
        {
            ModId = modId;
            ObjectId = objectId; //can be anything really, long as its unique. CamelCase recommended.
        }
    }

    public class CustomObjectInstance : Object
    {
        private CustomObject CustomObjectData;

        //deserialization constructor
        public CustomObjectInstance()
        {

        }

        //item creation constructor
        public CustomObjectInstance(Vector2 location) : base(location, CustomObjectHandler.BaseItemId)
        {

        }
    }
}
