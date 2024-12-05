using GadgetCore.API;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace PlanetaryRaces
{
    internal class Items
    {
        ItemInfo CardPackBase = new ItemInfo(ItemType.CONSUMABLE, "Card Pack Base", "Use this item to unlock a new race!", GadgetCoreAPI.LoadTexture2D("items/TemplateCard")).Register("CardPackBase");
        internal static void CardPacks()
        {
            string mrow = ("Use this item to unlock \na new race!");
            ItemInfo SchmooPack = new ItemInfo(ItemType.CONSUMABLE, "Shmoo Card Pack", mrow, GadgetCoreAPI.LoadTexture2D("items/card_pack_mob_shmoo")).Register("SchmooPack");
            SchmooPack.OnUse += (slot) => {
                
                InstanceTracker.GameScript.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/questbot"), Menuu.soundLevel / 10f);
                Races.Schmoo.SetFeatureUnlocked(Races.Schmoo.GetFeatureUnlockLevel() + 1);
                return true;
            };
            ItemInfo WormPack = new ItemInfo(ItemType.CONSUMABLE, "Canyon Card Pack", mrow, GadgetCoreAPI.LoadTexture2D("items/card_pack_planet_des_canyon")).Register("WormPack");
            WormPack.OnUse += (slot) => {
                InstanceTracker.GameScript.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/questbot"), Menuu.soundLevel / 10f);
                Races.Worm.SetFeatureUnlocked(Races.Worm.GetFeatureUnlockLevel() + 1);
                return true;
            };
            ItemInfo ChamchamPack = new ItemInfo(ItemType.CONSUMABLE, "Chamcham Card Pack", mrow, GadgetCoreAPI.LoadTexture2D("items/card_pack_mob_chamcham")).Register("ChamchamPack");
            ChamchamPack.OnUse += (slot) => {
                InstanceTracker.GameScript.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/questbot"), Menuu.soundLevel / 10f);
                Races.Chamcham.SetFeatureUnlocked(Races.Chamcham.GetFeatureUnlockLevel() + 1);
                return true;
            };
            ItemInfo SlugPack = new ItemInfo(ItemType.CONSUMABLE, "Jungle Card Pack", mrow, GadgetCoreAPI.LoadTexture2D("items/card_pack_planet_deep_jungle")).Register("SlugPack");
            SlugPack.OnUse += (slot) => {
                InstanceTracker.GameScript.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/questbot"), Menuu.soundLevel / 10f);
                Races.Slugmaster.SetFeatureUnlocked(Races.Slugmaster.GetFeatureUnlockLevel() + 1);
                return true;
            };
            ItemInfo ShroomPack = new ItemInfo(ItemType.CONSUMABLE, "Shroomtown Card Pack", mrow, GadgetCoreAPI.LoadTexture2D("items/card_pack_planet_shroomtown")).Register("ShroomPack");
            ShroomPack.OnUse += (slot) => {
                InstanceTracker.GameScript.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/questbot"), Menuu.soundLevel / 10f);
                Races.Shroomkin.SetFeatureUnlocked(Races.Shroomkin.GetFeatureUnlockLevel() + 1);
                return true;
            };
            ItemInfo SpiderPack = new ItemInfo(ItemType.CONSUMABLE, "Caverns Card Pack", mrow, GadgetCoreAPI.LoadTexture2D("items/card_pack_planet_hol_caverns")).Register("SpiderPack");
            SpiderPack.OnUse += (slot) => {
                InstanceTracker.GameScript.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/questbot"), Menuu.soundLevel / 10f);
                Races.Drider.SetFeatureUnlocked(Races.Drider.GetFeatureUnlockLevel() + 1);
                return true;
            };
            ItemInfo FishPack = new ItemInfo(ItemType.CONSUMABLE, "Relicfish Card Pack", mrow, GadgetCoreAPI.LoadTexture2D("items/card_pack_mob_relicfish")).Register("FishPack");
            FishPack.OnUse += (slot) => {
                InstanceTracker.GameScript.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/questbot"), Menuu.soundLevel / 10f);
                Races.Relic.SetFeatureUnlocked(Races.Relic.GetFeatureUnlockLevel() + 1);
                return true;
            };
            ItemInfo RelicPack = new ItemInfo(ItemType.CONSUMABLE, "Ancient Card Pack", mrow, GadgetCoreAPI.LoadTexture2D("items/card_pack_planet_anc_ruins")).Register("AncientPack");
            RelicPack.OnUse += (slot) => {
                InstanceTracker.GameScript.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/questbot"), Menuu.soundLevel / 10f);
                Races.Dune.SetFeatureUnlocked(Races.Dune.GetFeatureUnlockLevel() + 1);
                return true;
            };
            ItemInfo SlimePack = new ItemInfo(ItemType.CONSUMABLE, "Slime Card Pack", mrow, GadgetCoreAPI.LoadTexture2D("items/card_pack_mob_slime")).Register("SlimePack");
            SlimePack.OnUse += (slot) => {
                InstanceTracker.GameScript.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/questbot"), Menuu.soundLevel / 10f);
                Races.Slime.SetFeatureUnlocked(Races.Slime.GetFeatureUnlockLevel() + 1);
                return true;
            };
            ItemInfo MoltenPack = new ItemInfo(ItemType.CONSUMABLE, "Molten Card Pack", mrow, GadgetCoreAPI.LoadTexture2D("items/card_pack_planet_molten_crag")).Register("MoltenPack");
            MoltenPack.OnUse += (slot) => {
                InstanceTracker.GameScript.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/questbot"), Menuu.soundLevel / 10f);
                Races.Kobold.SetFeatureUnlocked(Races.Kobold.GetFeatureUnlockLevel() + 1);
                return true;
            };
            ItemInfo MammothPack = new ItemInfo(ItemType.CONSUMABLE, "Mammoth Card Pack", mrow, GadgetCoreAPI.LoadTexture2D("items/card_pack_mob_mammoth")).Register("MammothPack");
            MammothPack.OnUse += (slot) => {
                InstanceTracker.GameScript.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/questbot"), Menuu.soundLevel / 10f);
                Races.Mammoth.SetFeatureUnlocked(Races.Mammoth.GetFeatureUnlockLevel() + 1);
                return true;
            };
            ItemInfo WispPack = new ItemInfo(ItemType.CONSUMABLE, "Byfrost Card Pack", mrow, GadgetCoreAPI.LoadTexture2D("items/card_pack_planet_byfrost")).Register("WispPack");
            WispPack.OnUse += (slot) => {
                InstanceTracker.GameScript.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/questbot"), Menuu.soundLevel / 10f);
                Races.Wisp.SetFeatureUnlocked(Races.Wisp.GetFeatureUnlockLevel() + 1);
                return true;
            };
            ItemInfo PlaguePack = new ItemInfo(ItemType.CONSUMABLE, "Plaguelands Card Pack", mrow, GadgetCoreAPI.LoadTexture2D("items/card_pack_planet_plaguelands")).Register("PlaguePack");
            PlaguePack.OnUse += (slot) => {
                InstanceTracker.GameScript.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/questbot"), Menuu.soundLevel / 10f);
                Races.Plagued.SetFeatureUnlocked(Races.Plagued.GetFeatureUnlockLevel() + 1);
                return true;
            };
            ItemInfo WisperPack = new ItemInfo(ItemType.CONSUMABLE, "Whisperwoods Card Pack", mrow, GadgetCoreAPI.LoadTexture2D("items/card_pack_planet_whisperwoods")).Register("WhisperPack");
            WisperPack.OnUse += (slot) => {
                InstanceTracker.GameScript.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/questbot"), Menuu.soundLevel / 10f);
                Races.Treant.SetFeatureUnlocked(Races.Treant.GetFeatureUnlockLevel() + 1);
                return true;
            };
            ItemInfo MutantPack = new ItemInfo(ItemType.CONSUMABLE, "Miniboss Card Pack", mrow, GadgetCoreAPI.LoadTexture2D("items/card_pack_miniboss")).Register("MutantPack");
            MutantPack.OnUse += (slot) => {
                InstanceTracker.GameScript.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/questbot"), Menuu.soundLevel / 10f);
                Races.Mutant.SetFeatureUnlocked(Races.Mutant.GetFeatureUnlockLevel() + 1);
                return true;
            };
            ItemInfo PiratePack = new ItemInfo(ItemType.CONSUMABLE, "Space Pirate Card Pack", mrow, GadgetCoreAPI.LoadTexture2D("items/card_pack_mob_space_pirate")).Register("PiratePack");
            PiratePack.OnUse += (slot) => {
                InstanceTracker.GameScript.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/questbot"), Menuu.soundLevel / 10f);
                Races.Pirate.SetFeatureUnlocked(Races.Pirate.GetFeatureUnlockLevel() + 1);
                return true;
            };
            ItemInfo GlitterPack = new ItemInfo(ItemType.CONSUMABLE, "Glitterbug Card Pack", mrow, GadgetCoreAPI.LoadTexture2D("items/card_pack_mob_glitterbug")).Register("GlitterPack");
            GlitterPack.OnUse += (slot) => {
                InstanceTracker.GameScript.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/questbot"), Menuu.soundLevel / 10f);
                Races.Glitterbug.SetFeatureUnlocked(Races.Glitterbug.GetFeatureUnlockLevel() + 1);
                return true;
            };
        }
        internal static void Shhhh() {
            ItemInfo Warning = new ItemInfo(ItemType.GENERIC, "Warning", "If you see this, please dont ruin the surprise!", GadgetCoreAPI.LoadTexture2D("items/TemplateCard")).Register("WarningSlug");
            
            ItemInfo OmegaSlug = new ItemInfo(ItemType.GENERIC, "Omega Slug", "A Slug\n...Omegafied", GadgetCoreAPI.LoadTexture2D("secrets/omega")).Register("OmegaSlug");
            ItemInfo DarkenedSlug = new ItemInfo(ItemType.GENERIC, "Darkened Slug", "Through a Slug, \nDarkly", GadgetCoreAPI.LoadTexture2D("secrets/dark")).Register("DarkenedSlug");
            ItemInfo AetherSlug = new ItemInfo(ItemType.GENERIC, "Aether Slug", "But can it\nFast Travel?", GadgetCoreAPI.LoadTexture2D("secrets/aether")).Register("AetherSlug");
            ItemInfo CrystalSlug = new ItemInfo(ItemType.GENERIC, "Crystalized Slug", "A slug\nHardened by\nMany Crystals", GadgetCoreAPI.LoadTexture2D("secrets/crystal")).Register("CrystalSlug");

            ItemInfo BasicSlug = new ItemInfo(ItemType.GENERIC, "Pitiful Slug", "Does... Something...", GadgetCoreAPI.LoadTexture2D("secrets/basic")).Register("BasicSlug");
            ItemRegistry.Singleton["Planetary Races:BasicSlug"].AddToLootTable("entity:all", 0.001f, 1);

            ItemInfo ExistingSlug = new ItemInfo(ItemType.GENERIC, "Existing Slug", "But does it truly?", GadgetCoreAPI.LoadTexture2D("secrets/existence")).Register("ExistSlug");
            ItemInfo ExistedSlug = new ItemInfo(ItemType.GENERIC, "Existed Slug", "As above\nSo Below", GadgetCoreAPI.LoadTexture2D("secrets/exist")).Register("ExistedSlug");
            ItemInfo NuclearPasta = new ItemInfo(ItemType.GENERIC, "Nuclear Pasta", "Its heavy...\nToo heavy...", GadgetCoreAPI.LoadTexture2D("secrets/material_nuclear_pasta")).Register("Pasta");

            ItemInfo ChaosSlug = new ItemInfo(ItemType.GENERIC, "Chaos Slug", "Chaos Chaos!", GadgetCoreAPI.LoadTexture2D("secrets/chaos")).Register("ChaosSlug");
            ItemInfo StableSlug = new ItemInfo(ItemType.GENERIC, "Stable Slug", "It moves no longer.", GadgetCoreAPI.LoadTexture2D("secrets/stable")).Register("StableSlug");
            ItemInfo Primordial = new ItemInfo(ItemType.GENERIC, "Primordial Force", "ItemInfo Primordial\n= new iteminfo(\nItemType.GENERIC", GadgetCoreAPI.LoadTexture2D("secrets/material_primordial_force")).Register("PrimordialForce");

            ItemInfo EchoSlug = new ItemInfo(ItemType.GENERIC, "Echoed Slug", "One Slug Many Cards", GadgetCoreAPI.LoadTexture2D("secrets/echo")).Register("EchoedSlug");
            ItemInfo AscendedSlug = new ItemInfo(ItemType.GENERIC, "Ascended Slug", "We put our\nFaith in\nRandom Gods...", GadgetCoreAPI.LoadTexture2D("secrets/ascend")).Register("AscendedSlug");
            ItemInfo VoidFluid = new ItemInfo(ItemType.GENERIC, "Void Fluid", "Pouring this on\nyourself would result\nin annihilation", GadgetCoreAPI.LoadTexture2D("secrets/material_void_fluid")).Register("VoidFluid");

            ItemInfo PlasmaSlug = new ItemInfo(ItemType.GENERIC, "Plasmic Slug", "Tiers+ Update when?", GadgetCoreAPI.LoadTexture2D("secrets/plasma")).Register("PlasmicSlug");
            ItemInfo PurifiedSlug = new ItemInfo(ItemType.GENERIC, "Purified Slug", "Part of a larger\nWhole", GadgetCoreAPI.LoadTexture2D("secrets/pure")).Register("PurifiedSlug");
            ItemInfo Stardust = new ItemInfo(ItemType.GENERIC, "Stardust", "Dust... \nFrom a star...", GadgetCoreAPI.LoadTexture2D("secrets/material_stardust")).Register("Stardust");

            ItemInfo FuryCoc = new ItemInfo(ItemType.GENERIC, "Furious Concoction", "EW...", Resources.Load<Material>("i/i45")).Register("Fury");
            ItemInfo BrilliantAlloy = new ItemInfo(ItemType.GENERIC, "Brilliant Alloy", "Blessed by an unknown force\nIts so bright...", Resources.Load<Material>("i/i17")).Register("Auric");

            ItemInfo EnigmaSlug = new ItemInfo(ItemType.GENERIC, "Enigma Slug", "Looking at it\nhurts your eyes", GadgetCoreAPI.LoadTexture2D("secrets/enigma")).Register("EnigmaSlug");

            ItemInfo OblivionSlug = new ItemInfo(ItemType.GENERIC, "Oblivion Slug", "Your journey is \nFinally over...", GadgetCoreAPI.LoadTexture2D("secrets/obliv")).Register("OblivSlug");
            OblivionSlug.OnUse += (slot) => {
                InstanceTracker.GameScript.Die();
                InstanceTracker.GameScript.GetComponent<AudioSource>().PlayOneShot((AudioClip)Resources.Load("Au/slugburst"), Menuu.soundLevel / 10f);
                Races.Secret.SetFeatureUnlocked(Races.Secret.GetFeatureUnlockLevel() + 1);
                return true;
            };

        }
    }
}
