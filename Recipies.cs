using GadgetCore.API;
using GadgetCore.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlanetaryRaces
{
    internal class Recipes
    {
        internal static void UniversalCrafter() {
            ((CraftMenuInfo)MenuRegistry.Singleton["Gadget Core:Crafter Menu"]).AddCraftPerformer(CraftMenuInfo.CreateSimpleCraftPerformer(Tuple.Create(new int[] { 2501, 2502, 2501 }, new Item(ItemRegistry.Singleton["Planetary Races:SchmooPack"].GetID(), 1, 0, 0, 0, new int[3], new int[3]), 0)));
            ((CraftMenuInfo)MenuRegistry.Singleton["Gadget Core:Crafter Menu"]).AddCraftPerformer(CraftMenuInfo.CreateSimpleCraftPerformer(Tuple.Create(new int[] { 2504, 2503, 2505 }, new Item(ItemRegistry.Singleton["Planetary Races:WormPack"].GetID(), 1, 0, 0, 0, new int[3], new int[3]), 0)));
            ((CraftMenuInfo)MenuRegistry.Singleton["Gadget Core:Crafter Menu"]).AddCraftPerformer(CraftMenuInfo.CreateSimpleCraftPerformer(Tuple.Create(new int[] { 2509, 2509, 2509 }, new Item(ItemRegistry.Singleton["Planetary Races:ChamchamPack"].GetID(), 1, 0, 0, 0, new int[3], new int[3]), 0)));
            ((CraftMenuInfo)MenuRegistry.Singleton["Gadget Core:Crafter Menu"]).AddCraftPerformer(CraftMenuInfo.CreateSimpleCraftPerformer(Tuple.Create(new int[] { 2507, 2508, 2507 }, new Item(ItemRegistry.Singleton["Planetary Races:SlugPack"].GetID(), 1, 0, 0, 0, new int[3], new int[3]), 0)));
            ((CraftMenuInfo)MenuRegistry.Singleton["Gadget Core:Crafter Menu"]).AddCraftPerformer(CraftMenuInfo.CreateSimpleCraftPerformer(Tuple.Create(new int[] { 2517, 2518, 2517 }, new Item(ItemRegistry.Singleton["Planetary Races:ShroomPack"].GetID(), 1, 0, 0, 0, new int[3], new int[3]), 0)));
            ((CraftMenuInfo)MenuRegistry.Singleton["Gadget Core:Crafter Menu"]).AddCraftPerformer(CraftMenuInfo.CreateSimpleCraftPerformer(Tuple.Create(new int[] { 2514, 2514, 2514 }, new Item(ItemRegistry.Singleton["Planetary Races:SpiderPack"].GetID(), 1, 0, 0, 0, new int[3], new int[3]), 0)));
            ((CraftMenuInfo)MenuRegistry.Singleton["Gadget Core:Crafter Menu"]).AddCraftPerformer(CraftMenuInfo.CreateSimpleCraftPerformer(Tuple.Create(new int[] { 2523, 2520, 2523 }, new Item(ItemRegistry.Singleton["Planetary Races:FishPack"].GetID(), 1, 0, 0, 0, new int[3], new int[3]), 0)));
            ((CraftMenuInfo)MenuRegistry.Singleton["Gadget Core:Crafter Menu"]).AddCraftPerformer(CraftMenuInfo.CreateSimpleCraftPerformer(Tuple.Create(new int[] { 2522, 2521, 2522 }, new Item(ItemRegistry.Singleton["Planetary Races:AncientPack"].GetID(), 1, 0, 0, 0, new int[3], new int[3]), 0)));
            ((CraftMenuInfo)MenuRegistry.Singleton["Gadget Core:Crafter Menu"]).AddCraftPerformer(CraftMenuInfo.CreateSimpleCraftPerformer(Tuple.Create(new int[] { 2513, 2535, 2536 }, new Item(ItemRegistry.Singleton["Planetary Races:SlimePack"].GetID(), 1, 0, 0, 0, new int[3], new int[3]), 0)));
            ((CraftMenuInfo)MenuRegistry.Singleton["Gadget Core:Crafter Menu"]).AddCraftPerformer(CraftMenuInfo.CreateSimpleCraftPerformer(Tuple.Create(new int[] { 2534, 2534, 2534 }, new Item(ItemRegistry.Singleton["Planetary Races:MoltenPack"].GetID(), 1, 0, 0, 0, new int[3], new int[3]), 0)));
            ((CraftMenuInfo)MenuRegistry.Singleton["Gadget Core:Crafter Menu"]).AddCraftPerformer(CraftMenuInfo.CreateSimpleCraftPerformer(Tuple.Create(new int[] { 2533, 2532, 2533 }, new Item(ItemRegistry.Singleton["Planetary Races:MammothPack"].GetID(), 1, 0, 0, 0, new int[3], new int[3]), 0)));
            ((CraftMenuInfo)MenuRegistry.Singleton["Gadget Core:Crafter Menu"]).AddCraftPerformer(CraftMenuInfo.CreateSimpleCraftPerformer(Tuple.Create(new int[] { 2531, 2530, 2531 }, new Item(ItemRegistry.Singleton["Planetary Races:WispPack"].GetID(), 1, 0, 0, 0, new int[3], new int[3]), 0)));
            ((CraftMenuInfo)MenuRegistry.Singleton["Gadget Core:Crafter Menu"]).AddCraftPerformer(CraftMenuInfo.CreateSimpleCraftPerformer(Tuple.Create(new int[] { 2525, 2526, 2525 }, new Item(ItemRegistry.Singleton["Planetary Races:PlaguePack"].GetID(), 1, 0, 0, 0, new int[3], new int[3]), 0)));
            ((CraftMenuInfo)MenuRegistry.Singleton["Gadget Core:Crafter Menu"]).AddCraftPerformer(CraftMenuInfo.CreateSimpleCraftPerformer(Tuple.Create(new int[] { 2541, 2542, 2541 }, new Item(ItemRegistry.Singleton["Planetary Races:WhisperPack"].GetID(), 1, 0, 0, 0, new int[3], new int[3]), 0)));

            ((CraftMenuInfo)MenuRegistry.Singleton["Gadget Core:Crafter Menu"]).AddCraftPerformer(CraftMenuInfo.CreateSimpleCraftPerformer(Tuple.Create(new int[] { 2538, 2540, 2539 }, new Item(ItemRegistry.Singleton["Planetary Races:MutantPack"].GetID(), 1, 0, 0, 0, new int[3], new int[3]), 0)));

            ((CraftMenuInfo)MenuRegistry.Singleton["Gadget Core:Crafter Menu"]).AddCraftPerformer(CraftMenuInfo.CreateSimpleCraftPerformer(Tuple.Create(new int[] { 2529, 2529, 2529 }, new Item(ItemRegistry.Singleton["Planetary Races:PiratePack"].GetID(), 1, 0, 0, 0, new int[3], new int[3]), 0)));
            ((CraftMenuInfo)MenuRegistry.Singleton["Gadget Core:Crafter Menu"]).AddCraftPerformer(CraftMenuInfo.CreateSimpleCraftPerformer(Tuple.Create(new int[] { 2527, 2527, 2527 }, new Item(ItemRegistry.Singleton["Planetary Races:GlitterPack"].GetID(), 1, 0, 0, 0, new int[3], new int[3]), 0)));

        }
        internal static void SecretCrafting() {
            ItemInfo Warning2 = new ItemInfo(ItemType.GENERIC, "Warning2", "If you see this, please dont ruin the surprise!", GadgetCoreAPI.LoadTexture2D("items/TemplateCard")).Register("WarningSlug2");
            
            GadgetCoreAPI.AddEmblemRecipe(106, ItemRegistry.Singleton["Planetary Races:Pasta"].GetID(), 10);
            GadgetCoreAPI.AddEmblemRecipe(116, ItemRegistry.Singleton["Planetary Races:PrimordialForce"].GetID(), 10);
            GadgetCoreAPI.AddEmblemRecipe(126, ItemRegistry.Singleton["Planetary Races:VoidFluid"].GetID(), 10);
            GadgetCoreAPI.AddEmblemRecipe(136, ItemRegistry.Singleton["Planetary Races:Stardust"].GetID(), 10);


            GadgetCoreAPI.AddCreationMachineRecipe(ItemRegistry.Singleton["Planetary Races:Pasta"].GetID(), new Item(ItemRegistry.Singleton["Planetary Races:ExistSlug"].GetID(), 1, 0, 3, 0, new int[3], new int[3]));
            GadgetCoreAPI.AddCreationMachineRecipe(ItemRegistry.Singleton["Planetary Races:PrimordialForce"].GetID(), new Item(ItemRegistry.Singleton["Planetary Races:ChaosSlug"].GetID(), 1, 0, 3, 0, new int[3], new int[3]));
            GadgetCoreAPI.AddCreationMachineRecipe(ItemRegistry.Singleton["Planetary Races:VoidFluid"].GetID(), new Item(ItemRegistry.Singleton["Planetary Races:EchoedSlug"].GetID(), 1, 0, 3, 0, new int[3], new int[3]));
            GadgetCoreAPI.AddCreationMachineRecipe(ItemRegistry.Singleton["Planetary Races:Stardust"].GetID(), new Item(ItemRegistry.Singleton["Planetary Races:PlasmicSlug"].GetID(), 1, 0, 3, 0, new int[3], new int[3]));


            //GadgetCoreAPI.AddUltimateForgeRecipe(new Tuple<int, int>(ItemRegistry.Singleton["Planetary Races:BasicSlug"].GetID(), 89), ItemRegistry.Singleton["Planetary Races:AetherSlug"].GetID());
            //GadgetCoreAPI.AddUltimateForgeRecipe(new Tuple<int, int>(ItemRegistry.Singleton["Planetary Races:BasicSlug"].GetID(), 90), ItemRegistry.Singleton["Planetary Races:DarkenedSlug"].GetID());
            //GadgetCoreAPI.AddUltimateForgeRecipe(new Tuple<int,int>(ItemRegistry.Singleton["Planetary Races:BasicSlug"].GetID(), 91), ItemRegistry.Singleton["Planetary Races:OmegaSlug"].GetID());
            ((CraftMenuInfo)MenuRegistry.Singleton["Gadget Core:Crafter Menu"]).AddCraftPerformer(CraftMenuInfo.CreateSimpleCraftPerformer(Tuple.Create(new int[] { 89, ItemRegistry.Singleton["Planetary Races:BasicSlug"].GetID(), 89 }, new Item(ItemRegistry.Singleton["Planetary Races:AetherSlug"].GetID(), 1, 0, 0, 0, new int[3], new int[3]), 0)));
            ((CraftMenuInfo)MenuRegistry.Singleton["Gadget Core:Crafter Menu"]).AddCraftPerformer(CraftMenuInfo.CreateSimpleCraftPerformer(Tuple.Create(new int[] { 90, ItemRegistry.Singleton["Planetary Races:BasicSlug"].GetID(), 90 }, new Item(ItemRegistry.Singleton["Planetary Races:DarkenedSlug"].GetID(), 1, 0, 0, 0, new int[3], new int[3]), 0)));
            ((CraftMenuInfo)MenuRegistry.Singleton["Gadget Core:Crafter Menu"]).AddCraftPerformer(CraftMenuInfo.CreateSimpleCraftPerformer(Tuple.Create(new int[] { 91, ItemRegistry.Singleton["Planetary Races:BasicSlug"].GetID(), 91 }, new Item(ItemRegistry.Singleton["Planetary Races:OmegaSlug"].GetID(), 1, 0, 0, 0, new int[3], new int[3]), 0)));


            ((CraftMenuInfo)MenuRegistry.Singleton["Gadget Core:Crafter Menu"]).AddCraftPerformer(CraftMenuInfo.CreateSimpleCraftPerformer(Tuple.Create(new int[] { ItemRegistry.Singleton["Planetary Races:ExistSlug"].GetID(), ItemRegistry.Singleton["Planetary Races:BasicSlug"].GetID(), ItemRegistry.Singleton["Planetary Races:ExistSlug"].GetID() }, new Item(ItemRegistry.Singleton["Planetary Races:ExistedSlug"].GetID(), 1, 0, 0, 0, new int[3], new int[3]), 0)));
            ((CraftMenuInfo)MenuRegistry.Singleton["Gadget Core:Crafter Menu"]).AddCraftPerformer(CraftMenuInfo.CreateSimpleCraftPerformer(Tuple.Create(new int[] { ItemRegistry.Singleton["Planetary Races:StableSlug"].GetID(), ItemRegistry.Singleton["Planetary Races:ExistedSlug"].GetID(), ItemRegistry.Singleton["Planetary Races:StableSlug"].GetID() }, new Item(ItemRegistry.Singleton["Planetary Races:StableSlug"].GetID(), 1, 0, 0, 0, new int[3], new int[3]), 0)));
            ((CraftMenuInfo)MenuRegistry.Singleton["Gadget Core:Crafter Menu"]).AddCraftPerformer(CraftMenuInfo.CreateSimpleCraftPerformer(Tuple.Create(new int[] { ItemRegistry.Singleton["Planetary Races:EchoedSlug"].GetID(), ItemRegistry.Singleton["Planetary Races:StableSlug"].GetID(), ItemRegistry.Singleton["Planetary Races:EchoedSlug"].GetID() }, new Item(ItemRegistry.Singleton["Planetary Races:AscendedSlug"].GetID(), 1, 0, 0, 0, new int[3], new int[3]), 0)));
            ((CraftMenuInfo)MenuRegistry.Singleton["Gadget Core:Crafter Menu"]).AddCraftPerformer(CraftMenuInfo.CreateSimpleCraftPerformer(Tuple.Create(new int[] { ItemRegistry.Singleton["Planetary Races:PlasmicSlug"].GetID(), ItemRegistry.Singleton["Planetary Races:AscendedSlug"].GetID(), ItemRegistry.Singleton["Planetary Races:PlasmicSlug"].GetID() }, new Item(ItemRegistry.Singleton["Planetary Races:PurifiedSlug"].GetID(), 1, 0, 0, 0, new int[3], new int[3]), 0)));


            ((CraftMenuInfo)MenuRegistry.Singleton["Gadget Core:Crafter Menu"]).AddCraftPerformer(CraftMenuInfo.CreateSimpleCraftPerformer(Tuple.Create(new int[] { ItemRegistry.Singleton["Planetary Races:AetherSlug"].GetID(), ItemRegistry.Singleton["Planetary Races:DarkenedSlug"].GetID(), ItemRegistry.Singleton["Planetary Races:OmegaSlug"].GetID() }, new Item(ItemRegistry.Singleton["Planetary Races:CrystalSlug"].GetID(), 1, 0, 0, 0, new int[3], new int[3]), 0)));


            ((CraftMenuInfo)MenuRegistry.Singleton["Gadget Core:Crafter Menu"]).AddCraftPerformer(CraftMenuInfo.CreateSimpleCraftPerformer(Tuple.Create(new int[] { 52, 57, 51 }, new Item(ItemRegistry.Singleton["Planetary Races:Fury"].GetID(), 1, 0,0,0,new int[3], new int[3]), 0)));


            ((CraftMenuInfo)MenuRegistry.Singleton["Gadget Core:Crafter Menu"]).AddCraftPerformer(CraftMenuInfo.CreateSimpleCraftPerformer(Tuple.Create(new int[] {59, ItemRegistry.Singleton["Planetary Races:Fury"].GetID(), 59}, new Item(ItemRegistry.Singleton["Planetary Races:Auric"].GetID(), 1, 0, 0, 0, new int[3], new int[3]), 0)));
            ((CraftMenuInfo)MenuRegistry.Singleton["Gadget Core:Crafter Menu"]).AddCraftPerformer(CraftMenuInfo.CreateSimpleCraftPerformer(Tuple.Create(new int[] { ItemRegistry.Singleton["Planetary Races:Auric"].GetID(), ItemRegistry.Singleton["Planetary Races:Auric"].GetID(), ItemRegistry.Singleton["Planetary Races:Auric"].GetID() }, new Item(ItemRegistry.Singleton["Planetary Races:EnigmaSlug"].GetID(), 1, 0, 0, 0, new int[3], new int[3]), 0)));


            ((CraftMenuInfo)MenuRegistry.Singleton["Gadget Core:Crafter Menu"]).AddCraftPerformer(CraftMenuInfo.CreateSimpleCraftPerformer(Tuple.Create(new int[] { ItemRegistry.Singleton["Planetary Races:CrystalSlug"].GetID(), ItemRegistry.Singleton["Planetary Races:PurifiedSlug"].GetID(), ItemRegistry.Singleton["Planetary Races:EnigmaSlug"].GetID() }, new Item(ItemRegistry.Singleton["Planetary Races:OblivSlug"].GetID(), 1, 0, 0, 0, new int[3], new int[3]), 0)));

            //badge breakign




            //convert badge dust into secret packs




        }
    }
}
