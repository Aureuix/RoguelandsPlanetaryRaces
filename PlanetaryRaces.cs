using UnityEngine;
using GadgetCore.API;

namespace PlanetaryRaces
{
    [Gadget("Planetary Races", true)]
    public class PlanetaryRaces : Gadget<PlanetaryRaces>
    {
        public const string MOD_VERSION = "1.0"; // Set this to the version of your mod.
        public const string CONFIG_VERSION = "1.0"; // Increment this whenever you change your mod's config file.
		
		protected override void LoadConfig()
		{
			Config.Load();
			
			string fileVersion = Config.ReadString("ConfigVersion", CONFIG_VERSION, comments: "The Config Version (not to be confused with mod version)");

            if (fileVersion != CONFIG_VERSION)
            {
                Config.Reset();
                Config.WriteString("ConfigVersion", CONFIG_VERSION, comments: "The Config Version (not to be confused with mod version)");
            }
			
			// Do stuff with `Config`
			
			Config.Save();
		}
		
        public override string GetModDescription()
        {
            return "Adds Races themed after the Planets. Collect cards to unlock them!"; // TODO: Change this
        }

        protected override void Initialize()
        {
            Logger.Log("PlanetaryRaces v" + Info.Mod.Version);
            Races.Race();
            Items.CardPacks();
            Recipes.UniversalCrafter();
            //Items.Shhhh();
            //Recipes.SecretCrafting();
            // TODO: Do stuff like registering items


        }
    }
} 
