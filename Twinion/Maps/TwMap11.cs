using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    class TwMap11 : TwMap {
        public override int MapIndex => 11;
        public override int MapID => 0x0501;
        protected override int RandomEncounterChance => 5;
        protected override int RandomEncounterExtraCount => 1;

        private const int LAKE = 1;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableHealing(player, type, doMsgs);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, LAKE) == 0)) {
                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 4);
                ShowText(player, type, doMsgs, "The waters drain your life energy.");
                SetFlag(player, type, doMsgs, FlagTypeTile, LAKE, 1);
            }
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, LIFEJACKET)) {
                ShowText(player, type, doMsgs, "The Life Jacket keeps you from drowning.");
            }
            else {
                ShowText(player, type, doMsgs, "The platform buckles under your weight.");
                ShowText(player, type, doMsgs, "Your foot is snared by the sinking platform and you are dragged to the bottom of the lake.");
                DamXit(player, type, doMsgs);
            }
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "What appeared to be a platform is actually the back of a giant underwater creature.");
            if (HasItem(player, type, doMsgs, LIFEJACKET)) {
                ShowText(player, type, doMsgs, "He is awakened by your weight on his back and plunges deep into the lake, taking you to the bottom with him.");
                ShowText(player, type, doMsgs, "You have drowned!");
                DamXit(player, type, doMsgs);
            }
            else {
                ShowText(player, type, doMsgs, "However, he remains asleep and offers you a stable stepping stone.");
            }
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Beyond the door are stairs leading down to the Cellar.");
            TeleportParty(player, type, doMsgs, 6, 1, 8, Direction.South);
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You step into a stream of lava.");
            DamXit(player, type, doMsgs);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 6, 1, 89, Direction.South);
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HERBAL) == 1) {
                HealFtn(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The medicinal waters of Herbal Fountain heal you and renew your spell casting powers.");
            }
            else {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HERBAL, 1);
                HealFtn(player, type, doMsgs);
                if (GetGuild(player, type, doMsgs) == RANGER) {
                    GiveSpell(player, type, doMsgs, LIGHTNING_SPELL, 1);
                    ShowText(player, type, doMsgs, "The medicinal waters of Herbal Fountain heal you, renew your spell casting powers and endow you with the Lightning spell.");
                }
                else {
                    GiveSpell(player, type, doMsgs, CURE_SPELL, 1);
                    ShowText(player, type, doMsgs, "The medicinal waters of Herbal Fountain heal you, renew your spell casting powers and endow you with the Cure spell.");
                }
            }
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PARCHMENT_MAP) == 1) {
                if (HasItem(player, type, doMsgs, PARCHMENTMAP)) {
                    ShowText(player, type, doMsgs, "The heat from the lava is almost unbearable.");
                }
                else {
                    GiveItem(player, type, doMsgs, PARCHMENTMAP);
                    ShowText(player, type, doMsgs, "You detect signs of a struggle on the ground near a torn parchment.");
                    ShowText(player, type, doMsgs, "It is one of the four maps the Queen asked you to find.");
                }
            }
            else {
                GiveItem(player, type, doMsgs, PARCHMENTMAP);
                ModifyExperience(player, type, doMsgs, 200000);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PARCHMENT_MAP, 1);
                ShowText(player, type, doMsgs, "You approach two men fighting over a piece of parchment.");
                ShowText(player, type, doMsgs, "Before you can intervene, they topple into the lava. The parchment flutters gracefully to the ground.");
                ShowText(player, type, doMsgs, "A glance at the Parchment Map proves it is one of the four maps Queen Aeowyn asked you to find.");
            }
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The teleport will lead you to the Carriage House.");
            TeleportParty(player, type, doMsgs, 6, 1, 68, Direction.North);
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableAutomaps(player, type, doMsgs);
            ShowText(player, type, doMsgs, "You fall into a pit.");
            DamXit(player, type, doMsgs);
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.JACKET) == 1) {
                RemoveItem(player, type, doMsgs, LIFEJACKET);
                if (HasItem(player, type, doMsgs, FELLOWSHIPKEY)) {
                    ShowText(player, type, doMsgs, "The room is empty.");
                }
                else {
                    GiveItem(player, type, doMsgs, FELLOWSHIPKEY);
                    ShowText(player, type, doMsgs, "While stooping down to pick up a key, your Life Jacket falls into the water and floats away.");
                    ShowText(player, type, doMsgs, "The grasp of the key is engraved with two arms clasped in fellowship.");
                }
            }
            else {
                if (HasItem(player, type, doMsgs, LIFEJACKET)) {
                    GiveItem(player, type, doMsgs, FELLOWSHIPKEY);
                    GiveItem(player, type, doMsgs, STORMSBOW);
                    GiveItem(player, type, doMsgs, FREEDOMRING);
                    ModifyExperience(player, type, doMsgs, 50000);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.JACKET, 1);
                    ShowText(player, type, doMsgs, "While stooping down to pick up some items, your Life Jacket falls into the water and floats away.");
                    ShowText(player, type, doMsgs, "The grasp of the key is engraved with two arms clasped in fellowship.");
                    RemoveItem(player, type, doMsgs, LIFEJACKET);
                }
                else {
                    ShowText(player, type, doMsgs, "You stoop down to pick up a key but accidentally knock it into the water.");
                    ShowText(player, type, doMsgs, "Unfortunately, you lack what you need to retrieve it.");
                }
            }
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableAutomaps(player, type, doMsgs);
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Posted on the door you see: 'DANGER! Unstable ground.'");
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You overhear passers-by discussing the fact that not all pits lead to death; some have been transformed into passages.");
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A jump into the pit lands you in the Library.");
            TeleportParty(player, type, doMsgs, 6, 1, 90, Direction.North);
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, GNOMEWIZARD);
            ShowText(player, type, doMsgs, "A half-crazed Gnome Wizard looks in the direction of the Cartography Shop.");
            ShowText(player, type, doMsgs, "'Riddles, riddles,' he says mysteriously and wanders off.");
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 5, 1, 64, Direction.South);
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Through this teleport you will find the Stables.");
            TeleportParty(player, type, doMsgs, 6, 1, 164, Direction.South);
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You fall into the Carriage House.");
            TeleportParty(player, type, doMsgs, 6, 1, 118, Direction.East);
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, DIAMONDLOCKPICK)) {
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.VAULT) == 1) {
                    ShowText(player, type, doMsgs, "You see an empty safe.");
                }
                else {
                    ModifyGold(player, type, doMsgs, 100000);
                    GiveItem(player, type, doMsgs, NEROSLYRE);
                    GiveItem(player, type, doMsgs, CRESCENTMOON);
                    GiveItem(player, type, doMsgs, STAFFOFJUSTICE);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.VAULT, 1);
                    ShowText(player, type, doMsgs, "The safe opens easily with the Diamond Lockpick.");
                    ShowText(player, type, doMsgs, "Inside are 100,000 gold pieces, which somehow find their way into your pocket, and a few items which were tucked away for safekeeping.");
                }
            }
            else {
                ShowText(player, type, doMsgs, "Deep within the Vault you find a safe; unfortunately, it is secured shut with a diamond shaped lock.");
            }
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableAutomaps(player, type, doMsgs);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, LAKE) == 0)) {
                SetFacing(player, type, doMsgs, Direction.West);
                SetFlag(player, type, doMsgs, FlagTypeTile, LAKE, 1);
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableAutomaps(player, type, doMsgs);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, LAKE) == 0)) {
                SetFacing(player, type, doMsgs, Direction.South);
                SetFlag(player, type, doMsgs, FlagTypeTile, LAKE, 1);
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You discover a short cut to the Stables.");
            TeleportParty(player, type, doMsgs, 6, 1, 134, Direction.South);
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You can barely read the water-stained sign. It says, 'To Clueless.'");
            TeleportParty(player, type, doMsgs, 4, 1, 69, Direction.South);
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "This way leads to Tipekans' Bridge.");
            TeleportParty(player, type, doMsgs, 7, 1, 161, Direction.East);
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableAutomaps(player, type, doMsgs);
            ShowPortrait(player, type, doMsgs, HALFLINGTHIEF);
            ShowText(player, type, doMsgs, "Smug grins at the sight of your Ruby Lockpick.");
            ShowText(player, type, doMsgs, "He crooks a thumb towards the door to the west.");
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The ground gives way beneath you.");
            DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (UsedItem(player, type, ref doMsgs, RUBYLOCKPICK, RUBYLOCKPICK)) {
                ShowText(player, type, doMsgs, "As you try to open the door, you spring a trap set by Smug.");
                DamXit(player, type, doMsgs);
            }
            else {
                ShowText(player, type, doMsgs, "This is the back door to Smug's Jewelry Shop.");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A message is scrawled on the wall -");
            ShowText(player, type, doMsgs, "'Inventory items have been known to change hazardous steps into safe steps.'");
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, ROPE)) {
                ShowText(player, type, doMsgs, "The ground gives way and you slide down a tunnel.");
                ShowText(player, type, doMsgs, "You quickly throw your rope over a rock and lower yourself into the Library.");
                TeleportParty(player, type, doMsgs, 6, 1, 73, Direction.East);
            }
            else {
                ShowText(player, type, doMsgs, "The ground gives way and you slide down a forked tunnel.");
                ShowText(player, type, doMsgs, "This time, you tumble down the left tube.");
                TeleportParty(player, type, doMsgs, 6, 1, 70, Direction.West);
            }
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == THIEF) {
                ShowText(player, type, doMsgs, "A sign on the door - 'THIEVES ONLY.'");
                DoorHere(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (UsedItem(player, type, ref doMsgs, RUBYLOCKPICK, RUBYLOCKPICK)) {
                WallClear(player, type, doMsgs);
                DoorHere(player, type, doMsgs);
                ShowText(player, type, doMsgs, "You successfully unlock the door.");
            }
            else {
                WallBlock(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The entrance to Smug's Jewelry Shop is locked.");
            }
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The Rich Waters of Sterling Fountain heal and restore you.");
            FntnPic(player, type, doMsgs);
            HealFtn(player, type, doMsgs);
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A ghostly voice cackles in glee, 'Cursed you are, cursed to go where I wish! Muhahahaha!'");
            if (HasItem(player, type, doMsgs, SKELETONKEY)) {
                TeleportParty(player, type, doMsgs, 5, 3, 15, Direction.South);
            }
            else if (HasItem(player, type, doMsgs, SCROLLOFTHESUN)) {
                TeleportParty(player, type, doMsgs, 5, 1, 61, Direction.West);
            }
            else if (HasItem(player, type, doMsgs, BLESSPOTION)) {
                TeleportParty(player, type, doMsgs, 5, 1, 182, Direction.South);
            }
            else if (HasItem(player, type, doMsgs, HALOSCROLL)) {
                TeleportParty(player, type, doMsgs, 4, 3, 64, Direction.South);
            }
            else {
                TeleportParty(player, type, doMsgs, 4, 1, 241, Direction.East);
            }
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "It looks like you're not the only one to discover the thieves' hiding place.");
            if (HasItem(player, type, doMsgs, STAFFOFGIANTS)) {
                SetTreasure(player, type, doMsgs, CURSEDSCROLL, SCROLLOFPROTECTION, 0, 0, 0, 1000);
            }
            else {
                SetTreasure(player, type, doMsgs, STAFFOFGIANTS, MANAELIXIR, SCROLLOFTHESUN, 0, 0, 3000);
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 6);
                AddEncounter(player, type, doMsgs, 02, 7);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 4);
                AddEncounter(player, type, doMsgs, 02, 5);
                AddEncounter(player, type, doMsgs, 03, 13);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 27);
                AddEncounter(player, type, doMsgs, 02, 28);
                AddEncounter(player, type, doMsgs, 03, 28);
                AddEncounter(player, type, doMsgs, 05, 35);
                AddEncounter(player, type, doMsgs, 06, 36);
            }
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableAutomaps(player, type, doMsgs);
            if (GetGuild(player, type, doMsgs) == THIEF) {
                if (HasItem(player, type, doMsgs, SKELETONKEY)) {
                    ShowText(player, type, doMsgs, "The room is empty.");
                }
                else if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARMORY_ITEM) == 1) {
                    GiveItem(player, type, doMsgs, SKELETONKEY);
                    ShowText(player, type, doMsgs, "You find a key which may open seemingly impassable doors in your race to finish Queen Aeowyn's Map Quest.");
                    ShowText(player, type, doMsgs, "The key is made of bone and features a skull and crossed arm bones.");
                }
                else {
                    GiveItem(player, type, doMsgs, SKELETONKEY);
                    ShowText(player, type, doMsgs, "Your Guildmaster left you a special key that will give you access to magical armor.");
                    ShowText(player, type, doMsgs, "The key is made of bone. The grasp is shaped like a skull and the shaft like two crossed, bony arms.");
                }
            }
            else {
                ShowText(player, type, doMsgs, "The room is bare.");
            }
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Beyond the door lies a twisted maze. To find your way through would be aMAZEing.");
            TeleportParty(player, type, doMsgs, 4, 2, 240, Direction.North);
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "`Pluthros`");
            ShowText(player, type, doMsgs, "Ashakkar is where all who oppose Chaos shall find this Fate.");
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            SetTileBlock(player, type, doMsgs, 191);
            ShowText(player, type, doMsgs, "Carved in the base you see the name `Lord Zzuf`");
            ShowText(player, type, doMsgs, "This work of art, however is unfinished; perhaps later you can come back and see it completed.");
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ROPE_FLAG) == 1) {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ClearTileBlock(player, type, doMsgs, 191);
                SetWallItem(player, type, doMsgs, GATEWAY, 191, Direction.East);
                ShowText(player, type, doMsgs, "Your quest bag shifts and hits the statue of Lord Zzuf, causing the great explorer's icon to move slightly.");
                ShowText(player, type, doMsgs, "You push the statue's base and find enough room for a person to squeeze through.");
            }
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "`Juvalad`");
            ShowText(player, type, doMsgs, "Enakkar is where all who oppose Harmony shall find this Fate.");
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "`Malos`");
            ShowText(player, type, doMsgs, "En-Li-Kil's master, and guardian to the Elementals.");
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "`Crysillus Draco and Sayvut d'Oi Vey`");
            ShowText(player, type, doMsgs, "These were the great engineers who built the shrines to the Fates those many moons ago.");
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "'Enter at your own risk!'");
        }
        protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
             {
                if (HasItem(player, type, doMsgs, EMERALDLOCKPICK)) {
                    SetTreasure(player, type, doMsgs, CURATIVEELIXIR, 0, 0, 0, 0, 1000);
                }
                else {
                    SetTreasure(player, type, doMsgs, EMERALDLOCKPICK, CURATIVEELIXIR, ELIXIROFHEALTH, 0, 0, 3000);
                    ShowText(player, type, doMsgs, "You see something green on the ground - and something nasty charging at you.");
                }
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 22);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 20);
                AddEncounter(player, type, doMsgs, 02, 20);
                AddEncounter(player, type, doMsgs, 05, 23);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 20);
                AddEncounter(player, type, doMsgs, 02, 20);
                AddEncounter(player, type, doMsgs, 03, 22);
                AddEncounter(player, type, doMsgs, 05, 23);
                AddEncounter(player, type, doMsgs, 06, 34);
            }
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == CLERIC) {
                ShowText(player, type, doMsgs, "A sign on the door - 'CLERICS ONLY.'");
                DoorHere(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == CLERIC) {
                if (HasItem(player, type, doMsgs, SKELETONKEY)) {
                    ShowText(player, type, doMsgs, "The room is empty.");
                }
                else if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARMORY_ITEM) == 1) {
                    GiveItem(player, type, doMsgs, SKELETONKEY);
                    ShowText(player, type, doMsgs, "You find a key which may open seemingly impassable doors in your race to finish Queen Aeowyn's Map Quest.");
                    ShowText(player, type, doMsgs, "The key is made of bone and features a skull and crossed arm bones.");
                }
                else {
                    GiveItem(player, type, doMsgs, SKELETONKEY);
                    ShowText(player, type, doMsgs, "Your Guildmaster left you a special key that will give you access to magical armor.");
                    ShowText(player, type, doMsgs, "The key is made of bone. The grasp is shaped like a skull and the shaft like two crossed, bony arms.");
                }
            }
            else {
                ShowText(player, type, doMsgs, "The room is bare.");
            }
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "`Astelligus`");
            ShowText(player, type, doMsgs, "The blackest pitch cannot compare to this Fate's home.");
        }
        protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARMORY_ITEM) == 0)) {
                ShowPortrait(player, type, doMsgs, ORCKNIGHT);
                ShowText(player, type, doMsgs, "An Orc Knight is frantically searching the ground.");
                ShowText(player, type, doMsgs, "'All I need to get into the secret armory rooms is that blasted Skeleton Key I dropped somewhere back here!");
                ShowText(player, type, doMsgs, "Of course, one needs more than that, as you well know!'");
                ShowText(player, type, doMsgs, "The Knight dashes off before you can say anything.");
            }
        }
        protected override void FnEvent3B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Be sure of your footing when you scale the heights of Cliffhanger.");
            TeleportParty(player, type, doMsgs, 4, 1, 34, Direction.East);
        }
        protected override void FnEvent3C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableAutomaps(player, type, doMsgs);
            ShowText(player, type, doMsgs, "Magical forces swirl about you, where you might end up you have no clue.");
            if (HasItem(player, type, doMsgs, SLATEMAP)) {
                TeleportParty(player, type, doMsgs, 6, 1, 0, Direction.South);
            }
            else if (HasItem(player, type, doMsgs, FRONTDOORKEY)) {
                TeleportParty(player, type, doMsgs, 4, 2, 228, Direction.South);
            }
            else if (HasItem(player, type, doMsgs, CRYSTALSCROLL)) {
                TeleportParty(player, type, doMsgs, 4, 1, 58, Direction.South);
            }
            else if (HasItem(player, type, doMsgs, IRONCROWN)) {
                TeleportParty(player, type, doMsgs, 5, 1, 203, Direction.South);
            }
            else {
                TeleportParty(player, type, doMsgs, 5, 1, 0, Direction.East);
            }
        }
        protected override void FnEvent3D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                SetWallItem(player, type, doMsgs, GATEWAY, GetTile(player, type, doMsgs), Direction.East);
                ShowText(player, type, doMsgs, "You have discovered the secret portal to the Ballroom.");
            }
            else {
                TeleportParty(player, type, doMsgs, 5, 1, 207, Direction.West);
                ShowText(player, type, doMsgs, "The space is too narrow for more than one person to squeeze through.");
            }
        }
        protected override void FnEvent3E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "`Corpeus`");
            ShowText(player, type, doMsgs, "This Fate welcomes all to sample his wisdom; or die from his wrath.");
        }
        protected override void FnEvent3F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 02, 3);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 02, 3);
                AddEncounter(player, type, doMsgs, 05, 25);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 3);
                AddEncounter(player, type, doMsgs, 02, 3);
                AddEncounter(player, type, doMsgs, 03, 1);
                AddEncounter(player, type, doMsgs, 05, 26);
                AddEncounter(player, type, doMsgs, 06, 26);
            }
        }
        protected override void FnEvent40(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 6);
                AddEncounter(player, type, doMsgs, 02, 5);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 28);
                AddEncounter(player, type, doMsgs, 02, 29);
                AddEncounter(player, type, doMsgs, 06, 9);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 10);
                AddEncounter(player, type, doMsgs, 02, 10);
                AddEncounter(player, type, doMsgs, 03, 11);
                AddEncounter(player, type, doMsgs, 05, 28);
                AddEncounter(player, type, doMsgs, 06, 29);
            }
        }
        protected override void FnEvent41(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 17);
                AddEncounter(player, type, doMsgs, 02, 38);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 17);
                AddEncounter(player, type, doMsgs, 02, 17);
                AddEncounter(player, type, doMsgs, 03, 18);
                AddEncounter(player, type, doMsgs, 04, 39);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 17);
                AddEncounter(player, type, doMsgs, 02, 17);
                AddEncounter(player, type, doMsgs, 03, 19);
                AddEncounter(player, type, doMsgs, 04, 19);
                AddEncounter(player, type, doMsgs, 06, 39);
            }
        }
        protected override void FnEvent42(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 39);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 17);
                AddEncounter(player, type, doMsgs, 02, 18);
                AddEncounter(player, type, doMsgs, 05, 35);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 37);
                AddEncounter(player, type, doMsgs, 02, 37);
                AddEncounter(player, type, doMsgs, 03, 39);
                AddEncounter(player, type, doMsgs, 04, 39);
                AddEncounter(player, type, doMsgs, 06, 38);
            }
        }
        protected override void FnEvent43(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 14);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 13);
                AddEncounter(player, type, doMsgs, 02, 15);
                AddEncounter(player, type, doMsgs, 06, 17);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 33);
                AddEncounter(player, type, doMsgs, 02, 33);
                AddEncounter(player, type, doMsgs, 04, 35);
                AddEncounter(player, type, doMsgs, 05, 36);
                AddEncounter(player, type, doMsgs, 06, 40);
            }
        }
        protected override void FnEvent44(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 10);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 9);
                AddEncounter(player, type, doMsgs, 02, 10);
                AddEncounter(player, type, doMsgs, 04, 31);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 10);
                AddEncounter(player, type, doMsgs, 02, 10);
                AddEncounter(player, type, doMsgs, 04, 11);
                AddEncounter(player, type, doMsgs, 05, 30);
                AddEncounter(player, type, doMsgs, 06, 32);
            }
        }
        protected override void FnEvent45(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 5);
                AddEncounter(player, type, doMsgs, 05, 6);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 6);
                AddEncounter(player, type, doMsgs, 02, 6);
                AddEncounter(player, type, doMsgs, 05, 19);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 6);
                AddEncounter(player, type, doMsgs, 02, 6);
                AddEncounter(player, type, doMsgs, 03, 8);
                AddEncounter(player, type, doMsgs, 05, 19);
                AddEncounter(player, type, doMsgs, 06, 19);
            }
        }
        protected override void FnEvent46(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallItem(player, type, doMsgs, GATEWAY, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            TeleportParty(player, type, doMsgs, 4, 1, 185, Direction.South);
        }
        private void DamXit(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
        }
        private void HealFtn(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ModifyHealth(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
            ModifyMana(player, type, doMsgs, 10000);
        }
        private void WallClear(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void DoorHere(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void FntnPic(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
        }
        protected override void FnEvent47(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, EMERALDLOCKPICK)) {
                ShowPortrait(player, type, doMsgs, GNOMETHIEF);
                ShowText(player, type, doMsgs, "'Lockpicks for sale!! Lockpicks for sale!!");
                ShowText(player, type, doMsgs, "Can I sell you a lockpick, brave champion? I see you have one, beautiful too. Care to sell it?");
                ShowText(player, type, doMsgs, "You must know that the brothers seek red, only red! No? Drat! Then be off with you and let me sell my wares!'");
            }
            else {
                ShowPortrait(player, type, doMsgs, GNOMETHIEF);
                ShowText(player, type, doMsgs, "'Brave Warrior! Are you in search of the Emerald Lockpick, too? I must find it and get to Tipekans!'");
            }
        }
    }
}
