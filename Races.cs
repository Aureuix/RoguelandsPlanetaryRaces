using GadgetCore.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using UnityEngine;

namespace PlanetaryRaces
{
    internal class Races
    {
        public static CharacterRaceInfo Schmoo;
        public static CharacterRaceInfo Worm;
        public static CharacterRaceInfo Chamcham;
        public static CharacterRaceInfo Slugmaster;
        public static CharacterRaceInfo Shroomkin;
        public static CharacterRaceInfo Drider;
        public static CharacterRaceInfo Dune;
        public static CharacterRaceInfo Relic;
        public static CharacterRaceInfo Slime;
        public static CharacterRaceInfo Kobold;
        public static CharacterRaceInfo Mammoth;
        public static CharacterRaceInfo Wisp;
        public static CharacterRaceInfo Plagued;
        public static CharacterRaceInfo Treant;
        public static CharacterRaceInfo Mutant;
        public static CharacterRaceInfo Pirate;
        public static CharacterRaceInfo Glitterbug;
        public static CharacterRaceInfo Shaper;
        public static CharacterRaceInfo Star;
        public static CharacterRaceInfo Void;
        public static CharacterRaceInfo Pasta;

        public static CharacterRaceInfo Secret;
        internal static void Race() {
            string unlockDesc = "Unlock this race by crafting card packs!";
            Schmoo = new CharacterRaceInfo("Shmoo", "", unlockDesc, new EquipStats(2, 2, 0, 2, 0, 0), GadgetCoreAPI.LoadTexture2D("preview/preview_shmoo"), GadgetCoreAPI.LoadTexture2D("races/shmoo_v0"), GadgetCoreAPI.LoadTexture2D("races/shmoo_v1"), GadgetCoreAPI.LoadTexture2D("races/shmoo_v2")).Register("SchmooRace"); // schmoo eyestalk schmoo
             Worm = new CharacterRaceInfo("Worm", "", unlockDesc, new EquipStats(1, 0, 2, 1, 2, 0), GadgetCoreAPI.LoadTexture2D("preview/preview_worm"), GadgetCoreAPI.LoadTexture2D("races/Worm_v0"), GadgetCoreAPI.LoadTexture2D("races/Worm_v1"), GadgetCoreAPI.LoadTexture2D("races/Worm_v2")).Register("WormRace"); // worm dunebug wasp
            Chamcham = new CharacterRaceInfo("Chamcham", "", unlockDesc, new EquipStats(0, 0, 0, 1, 3, 3), GadgetCoreAPI.LoadTexture2D("preview/preview_chamcham"), GadgetCoreAPI.LoadTexture2D("races/chamcham_v0"), GadgetCoreAPI.LoadTexture2D("races/chamcham_v1"), GadgetCoreAPI.LoadTexture2D("races/chamcham_v2")).Register("ChamchamRace"); //chamcham chamcham chamcham
             Slugmaster = new CharacterRaceInfo("Slugmaster", "", unlockDesc, new EquipStats(2, 0, 2, 2, 0, 0), GadgetCoreAPI.LoadTexture2D("preview/preview_slugmaster"), GadgetCoreAPI.LoadTexture2D("races/slugmaster_v0"), GadgetCoreAPI.LoadTexture2D("races/slugmaster_v1"), GadgetCoreAPI.LoadTexture2D("races/slugmaster_v2")).Register("SlugRace"); // sluglord slugmother sluglord
             Shroomkin = new CharacterRaceInfo("Shroomkin", "", unlockDesc, new EquipStats(2, 0, 0, 1, 2, 1), GadgetCoreAPI.LoadTexture2D("preview/preview_shroomkin"), GadgetCoreAPI.LoadTexture2D("races/shroomkin_v0"), GadgetCoreAPI.LoadTexture2D("races/shroomkin_v1"), GadgetCoreAPI.LoadTexture2D("races/shroomkin_v2")).Register("ShroomRace"); //shroom blue shroom shroom
             Drider = new CharacterRaceInfo("Drider", "", unlockDesc, new EquipStats(1, 2, 2, 0, 2, 0), GadgetCoreAPI.LoadTexture2D("preview/preview_drider"), GadgetCoreAPI.LoadTexture2D("races/drider_v0"), GadgetCoreAPI.LoadTexture2D("races/drider_v1"), GadgetCoreAPI.LoadTexture2D("races/drider_v2")).Register("DriderRace"); //rock spider sploopy rock spider
             Dune = new CharacterRaceInfo("Dunewalker", "", unlockDesc, new EquipStats(0, 0, 0, 3, 0, 3), GadgetCoreAPI.LoadTexture2D("preview/preview_dune"), GadgetCoreAPI.LoadTexture2D("races/dune_v0"), GadgetCoreAPI.LoadTexture2D("races/dune_v1"), GadgetCoreAPI.LoadTexture2D("races/dune_v2")).Register("FishRace"); //roach relicfish roach
             Relic = new CharacterRaceInfo("Ancient Scavenger", "", unlockDesc, new EquipStats(4, 0, 4, 0, 0, 0), GadgetCoreAPI.LoadTexture2D("preview/preview_relic"), GadgetCoreAPI.LoadTexture2D("Races/relic_v0"), GadgetCoreAPI.LoadTexture2D("Races/relic_v1"), GadgetCoreAPI.LoadTexture2D("Races/relic_v2")).Register("RelicRace"); //ancient beast ancient guardian ancient beast
             Slime = new CharacterRaceInfo("Slime", "", unlockDesc, new EquipStats(1, 0, 1, 2, 1, 2), GadgetCoreAPI.LoadTexture2D("preview/preview_slime"), GadgetCoreAPI.LoadTexture2D("races/slime_v0"), GadgetCoreAPI.LoadTexture2D("races/slime_v1"), GadgetCoreAPI.LoadTexture2D("races/slime_v2")).Register("SlimeRace"); //slime lava blob fire slime
             Kobold = new CharacterRaceInfo("Kobold", "", unlockDesc, new EquipStats(3, 2, 0, 0, 2, 0), GadgetCoreAPI.LoadTexture2D("preview/preview_kobold"), GadgetCoreAPI.LoadTexture2D("races/kobold_v0"), GadgetCoreAPI.LoadTexture2D("races/kobold_v1"), GadgetCoreAPI.LoadTexture2D("races/kobold_v2")).Register("KoboldRace"); //wyvern wyvern wyvern
             Mammoth = new CharacterRaceInfo("Mammoth", "", unlockDesc, new EquipStats(3, 2, 0, 1, 0, 1), GadgetCoreAPI.LoadTexture2D("preview/preview_mammoth"), GadgetCoreAPI.LoadTexture2D("races/mammoth_v0"), GadgetCoreAPI.LoadTexture2D("races/mammoth_v1"), GadgetCoreAPI.LoadTexture2D("races/mammoth_v2")).Register("MammothRace"); //mammoth yeti mammoth
             Wisp = new CharacterRaceInfo("Wisp", "", unlockDesc, new EquipStats(0, 0, 0, 0, 4, 4), GadgetCoreAPI.LoadTexture2D("preview/preview_wisp"), GadgetCoreAPI.LoadTexture2D("races/wisp_v0"), GadgetCoreAPI.LoadTexture2D("races/wisp_v1"), GadgetCoreAPI.LoadTexture2D("races/wisp_v2")).Register("WispRace"); //wisp wicked wisp
             Plagued = new CharacterRaceInfo("Plagued", "", unlockDesc, new EquipStats(2, 0, 2, 2, 2, 0), GadgetCoreAPI.LoadTexture2D("preview/preview_plagued"), GadgetCoreAPI.LoadTexture2D("races/plagued_v0"), GadgetCoreAPI.LoadTexture2D("races/plagued_v1"), GadgetCoreAPI.LoadTexture2D("races/plagued_v2")).Register("PlaguedRace"); //squirm plague caster squirm
             Treant = new CharacterRaceInfo("Trent", "", unlockDesc, new EquipStats(0, 0, 0, 4, 4, 0), GadgetCoreAPI.LoadTexture2D("preview/preview_trent"), GadgetCoreAPI.LoadTexture2D("races/treant_v0"), GadgetCoreAPI.LoadTexture2D("races/treant_v1"), GadgetCoreAPI.LoadTexture2D("races/treant_v2")).Register("TreantRace"); //treant willowart treant
             Mutant = new CharacterRaceInfo("Mutant", "", unlockDesc, new EquipStats(1, 2, 2, 1, 2, 1), GadgetCoreAPI.LoadTexture2D("preview/preview_mutant"), GadgetCoreAPI.LoadTexture2D("races/mutant_v0"), GadgetCoreAPI.LoadTexture2D("races/mutant_v1"), GadgetCoreAPI.LoadTexture2D("races/mutant_v2")).Register("MutantRace"); //tyrannog gruu beelzeblob

             Pirate = new CharacterRaceInfo("Space Pirate", "Once human, the many modifications that space pirates have undertaken has left them \nindistinguishable from robots.", unlockDesc, new EquipStats(3, 0, 3, 3, 0, 0), GadgetCoreAPI.LoadTexture2D("preview/preview_space_pirate"), GadgetCoreAPI.LoadTexture2D("races/pirate_v0"), GadgetCoreAPI.LoadTexture2D("races/pirate_v1"), GadgetCoreAPI.LoadTexture2D("races/pirate_v2")).Register("PirateRace"); //pirate pirate pirate
             Glitterbug = new CharacterRaceInfo("Glitterbug", "", unlockDesc, new EquipStats(0, 2, 2, 0, 2, 2), GadgetCoreAPI.LoadTexture2D("preview/preview_glitterbug"), GadgetCoreAPI.LoadTexture2D("races/glitterbug_v0"), GadgetCoreAPI.LoadTexture2D("races/glitterbug_v1"), GadgetCoreAPI.LoadTexture2D("races/glitterbug_v2")).Register("GlitterRace"); //glitterbug glitterbug glitterbug

             Secret = new CharacterRaceInfo("Slug Man", "Shhhh..... You didnt see this...", "Do Something Special...", new EquipStats(1, 1, 1, 1, 1, 1), GadgetCoreAPI.LoadTexture2D("items/TemplateCard"), GadgetCoreAPI.LoadTexture2D("items/TemplateCard"), GadgetCoreAPI.LoadTexture2D("items/TemplateCard"), GadgetCoreAPI.LoadTexture2D("items/TemplateCard")).Register("SecretRace");

            Shaper = new CharacterRaceInfo("World Shaper", "In the beginning of the universe, the world shapers created the planets and stars with their bare hands.", "Shape a world.", new EquipStats(1, 7, 1, 1, 1, 1), GadgetCoreAPI.LoadTexture2D("preview/preview_za_hando"), GadgetCoreAPI.LoadTexture2D("races/hand_race_v0"), GadgetCoreAPI.LoadTexture2D("races/hand_race_v1"), GadgetCoreAPI.LoadTexture2D("races/hand_race_v2")).Register("HandRace");
            Pasta = new CharacterRaceInfo("Spaghettificated", "Back before widespread space colonisation, ships would often fall into unseen black holes.\nThose who fell in were presumed dead, but in reality, their fate was much worse", "Sacrifice everything.", new EquipStats(1, 1, 7, 1, 1, 1), GadgetCoreAPI.LoadTexture2D("preview/preview_pasta"), GadgetCoreAPI.LoadTexture2D("races/pasta_race_v0"), GadgetCoreAPI.LoadTexture2D("races/pasta_race_v1"), GadgetCoreAPI.LoadTexture2D("races/pasta_race_v2")).Register("PastaRace");
            Pasta.SetUnlockChecker(() =>
            {
                if (InstanceTracker.GameScript.GetPlayerLevel() >= 200 && Menuu.curProfession == 1 && IsLegendary()) {
                    return true;
                    
                }
                return false;
            });
            Star = new CharacterRaceInfo("Starborn", "Formed when a star dies, the Starborn have made a name for themselves across the galaxy with their powerful magics.", StarDesc(), new EquipStats(1, 1, 1, 1, 7, 1), GadgetCoreAPI.LoadTexture2D("preview/preview_stardust_crusader"), GadgetCoreAPI.LoadTexture2D("races/star_dust_race_v0"), GadgetCoreAPI.LoadTexture2D("races/star_dust_race_v1"), GadgetCoreAPI.LoadTexture2D("races/star_dust_race_v2")).Register("STarRace");
            Star.SetUnlockChecker(() =>
            {
                if (InstanceTracker.GameScript.GetFinalStat(0) == 518 && InstanceTracker.GameScript.GetFinalStat(1) == 141 && InstanceTracker.GameScript.GetFinalStat(2) == 104 && InstanceTracker.GameScript.GetFinalStat(3) == 151 && InstanceTracker.GameScript.GetFinalStat(4) == 444 && InstanceTracker.GameScript.GetFinalStat(5) == 255){
                    return true;
                }return false;
            });
            Void = new CharacterRaceInfo("Void Drinker", "On a distant world, a sea of void spans an almost infinite distance.\nThose who bathe in it are said to move to a higher existence.", "Seek the void.", new EquipStats(1, 1, 1, 1, 1, 7), GadgetCoreAPI.LoadTexture2D("preview/preview_fluid"), GadgetCoreAPI.LoadTexture2D("races/void_fluid_race_v0"), GadgetCoreAPI.LoadTexture2D("races/void_fluid_race_v1"), GadgetCoreAPI.LoadTexture2D("races/void_fluid_race_v2")).Register("VoidRace");

        }
        private static FieldInfo inventory = typeof(GameScript).GetField("inventory", BindingFlags.Instance | BindingFlags.NonPublic);
        public static bool IsLegendary() {
            Item[] array = (Item[])inventory.GetValue(InstanceTracker.GameScript);
            if (array[36].tier == 3 && array[37].tier == 3 && array[38].tier == 3 && array[39].tier == 3 && array[40].tier == 3 && array[41].tier == 3) {
                return true;
            }
            return false;
        }
        public static string StarDesc() {
            
            DateTime dt = DateTime.Now;
            switch ((int)dt.DayOfWeek) 
            {
                case 0:
                    return ("Immerse yourself in multitudes.");
                case 1:
                    return ("Meow loudly.");
                case 2:
                    return ("WYVRN 77 WHITEMAG 09 PRISM 88");
                case 3:
                    return ("Become a Legend of the Cobalt Citadel.");
                case 4:
                    return ("kawaii wo naru");
                case 5:
                    return ("Hold the sun in the palm of your hand.");
                case 6:
                    return ("Wield Sean's mistake as a powerful Ironclad.");
                       


            }
            return ("If you see this something must have gone majorly wrong! oops!");
        }
    }
}
