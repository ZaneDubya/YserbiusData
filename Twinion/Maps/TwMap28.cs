using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    /// <summary>
    /// Map 28: Celestial Boundary
    /// </summary>
    class TwMap28 : TwMap {
        public override int MapIndex => 28;
        public override int MapID => 0x0B03;
        protected override int RandomEncounterChance => 5;
        protected override int RandomEncounterExtraCount => 2;

        private const int CASETRAP = 1;
        private const int CASETRAP2 = 2;
        private const int FIGHT_ME = 3;
        private const int METWRAITH = 4;
        private const int METNIGHTELF = 5;
        private const int LAVA_A = 6;
        private const int DEATHW = 7;
        private const int WATERW = 8;
        private const int LIFEW = 9;
        private const int SANDSW = 10;
        private const int TOW = 11;
        private const int FOLLOWSW = 12;
        private const int TIMEW = 13;
        private const int MAGICW = 14;
        private const int LAVAW = 15;
        private const int FROMW = 16;
        private const int OFW = 17;
        private const int LEADSW = 18;
        private const int TORCH1 = 19;
        private const int TORCH2 = 20;
        private const int TORCH3 = 21;
        private const int TORCH4 = 22;
        private const int TORCH5 = 23;
        private const int TORCH6 = 24;
        private const int INHALLWAY = 25;
        private const int WHICHONE = 26;
        private const int WHEREWEREYOU = 27;
        private const int SPRUNGTRAP = 1;

        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Astral material permeates this place");
        }

        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }

        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "This teleport is riddled with archaic markings.");
            TeleportParty(player, type, doMsgs, 11, 4, 60, Direction.North);
        }

        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int itemA = 0;
            int itemB = 0;
            int manapts = 0;
            int pool = 0;
            pool = GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.POOLNUMBER);
            DamageBy6(player, type, doMsgs);
            if (GetHealthCurrent(player, type, doMsgs) > 0) {
                NoSpellZone(player, type, doMsgs);
                switch (GetTile(player, type, doMsgs)) {
                    case 2:
                        pool = 1;
                        itemA = GOLDBAR;
                        itemB = SPIKEDSHIELD;
                        break;
                    case 3:
                        pool = 2;
                        itemA = SLIVERBAR;
                        itemB = TWOHANDEDSWORD;
                        manapts = 1000;
                        break;
                    case 6:
                        pool = 3;
                        itemA = NIGHTELFHELM;
                        itemB = MANAAMPHORA;
                        manapts = 3000;
                        break;
                    case 22:
                        pool = 4;
                        itemA = IRONCUTLASS;
                        itemB = BUCKLER;
                        manapts = -350;
                        break;
                }
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.POOLNUMBER) == pool) {
                    ShowText(player, type, doMsgs, "The clear waters let you see treasure in the pool's bottom.");
                    GiveItem(player, type, doMsgs, itemA);
                    GiveItem(player, type, doMsgs, itemB);
                    ModifyMana(player, type, doMsgs, manapts);
                    pool++;
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.POOLNUMBER, pool);
                }
                else {
                    ShowText(player, type, doMsgs, "The pool's waters are cloudy, perhaps they will be clear later.");
                }
            }
        }

        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NoSpellZone(player, type, doMsgs);
            DisableHealing(player, type, doMsgs);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 8);
                ShowText(player, type, doMsgs, "The seething lava scorches you.");
                SprungTrap(player, type, doMsgs);
            }
        }

        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }

        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "To Astelligus!");
            TeleportParty(player, type, doMsgs, 11, 4, 114, Direction.East);
        }

        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DIDASTRAL) == 0)) {
                if (HasItem(player, type, doMsgs, NIMBUSOFTHEFATES)) {
                    Nothing(player, type, doMsgs);
                }
                else {
                    ShowText(player, type, doMsgs, "The Nimbus of the Fates is in a glass case on the southern wall. You need only defeat those who guard it.");
                }
            }
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                case 2:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 40);
                    }
                    break;
                default:
                    for (i = 1; i <= 5; i++) {
                        AddEncounter(player, type, doMsgs, i, 40);
                    }
                    break;
            }
        }

        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DIDASTRAL) == 0)) {
                if (HasItem(player, type, doMsgs, NIMBUSOFTHEFATES)) {
                    Nothing(player, type, doMsgs);
                }
                else if (!HasItem(player, type, doMsgs, NIMBUSOFTHEFATES)) {
                    ShowText(player, type, doMsgs, "You take the Nimbus of the Fates.");
                    ShowText(player, type, doMsgs, "With it, you may face Astelligus.");
                    GiveItem(player, type, doMsgs, NIMBUSOFTHEFATES);
                    if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GOTASTRALITEM) == 0) || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GOTASTRALITEM) == 1) {
                        ShowText(player, type, doMsgs, "Gain in experience from your accomplishment!");
                        ModifyExperience(player, type, doMsgs, 650000);
                        SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GOTASTRALITEM, 2);
                    }
                }
            }
            else {
                Nothing(player, type, doMsgs);
            }
        }

        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int port1 = 0;
            int port2 = 0;
            Direction facing1 = 0;
            Direction facing2 = 0;
            Compass(player, type, doMsgs);
            if (IsPartyLeader(player, type, doMsgs)) {
                switch (GetFacing(player, type, doMsgs)) {
                    case Direction.North:
                        port1 = 153;
                        port2 = 157;
                        facing1 = Direction.East;
                        facing2 = Direction.North;
                        break;
                    case Direction.South:
                        port1 = 217;
                        if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GOTASTRALITEM) == 2) || (HasItem(player, type, doMsgs, NIMBUSOFTHEFATES))) {
                            if (GetFlag(player, type, doMsgs, FlagTypeParty, WHEREWEREYOU) == GetTile(player, type, doMsgs)) {
                                port2 = 157;
                            }
                            else {
                                port2 = 222;
                            }
                        }
                        facing1 = Direction.West;
                        facing2 = Direction.South;
                        break;
                    case Direction.East:
                        port1 = 217;
                        port2 = 157;
                        facing1 = Direction.East;
                        facing2 = Direction.North;
                        break;
                    case Direction.West:
                        if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GOTASTRALITEM) <= 1) || (!HasItem(player, type, doMsgs, NIMBUSOFTHEFATES))) {
                            if (GetFlag(player, type, doMsgs, FlagTypeParty, WHEREWEREYOU) == GetTile(player, type, doMsgs)) {
                                port1 = 232;
                            }
                            else {
                                port1 = 217;
                            }
                        }
                        port2 = 153;
                        facing1 = Direction.North;
                        facing2 = Direction.West;
                        break;
                }
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GOTASTRALITEM) <= 1 || (!HasItem(player, type, doMsgs, NIMBUSOFTHEFATES))) {
                    TeleportParty(player, type, doMsgs, 11, 3, port1, facing1);
                }
                else if (HasItem(player, type, doMsgs, NIMBUSOFTHEFATES)) {
                    TeleportParty(player, type, doMsgs, 11, 3, port2, facing2);
                }
            }
        }

        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int port1 = 0;
            int port2 = 0;
            Direction facing1 = 0;
            Direction facing2 = 0;
            Compass(player, type, doMsgs);
            switch (GetFacing(player, type, doMsgs)) {
                case Direction.West:
                    port1 = 153;
                    port2 = 157;
                    facing1 = Direction.East;
                    facing2 = Direction.North;
                    break;
                case Direction.East:
                    port2 = 153;
                    if (GetFlag(player, type, doMsgs, FlagTypeParty, WHEREWEREYOU) == 255) {
                        port1 = 157;
                    }
                    else {
                        port1 = 217;
                    }
                    facing1 = Direction.West;
                    facing2 = Direction.South;
                    break;
                case Direction.South:
                    port1 = 237;
                    port2 = 157;
                    facing1 = Direction.East;
                    facing2 = Direction.North;
                    break;
                case Direction.North:
                    if (GetFlag(player, type, doMsgs, FlagTypeParty, WHEREWEREYOU) == 255) {
                        port2 = 172;
                    }
                    else {
                        port2 = 207;
                    }
                    port1 = 153;
                    facing1 = Direction.North;
                    facing2 = Direction.West;
                    break;
            }
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GOTASTRALITEM) <= 1 || !HasItem(player, type, doMsgs, NIMBUSOFTHEFATES)) {
                TeleportParty(player, type, doMsgs, 11, 3, port1, facing1);
            }
            else {
                TeleportParty(player, type, doMsgs, 11, 3, port2, facing2);
            }
        }

        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int port1 = 0;
            int port2 = 0;
            Direction facing1 = 0;
            Direction facing2 = 0;
            Compass(player, type, doMsgs);
            switch (GetFacing(player, type, doMsgs)) {
                case Direction.South:
                    port1 = 232;
                    port2 = 157;
                    facing1 = Direction.East;
                    facing2 = Direction.North;
                    break;
                case Direction.North:
                    port2 = 217;
                    if (GetFlag(player, type, doMsgs, FlagTypeParty, WHEREWEREYOU) == 255) {
                        port1 = 168;
                    }
                    else {
                        port1 = 153;
                    }
                    facing1 = Direction.West;
                    facing2 = Direction.South;
                    break;
                case Direction.East:
                    port1 = 217;
                    port2 = 157;
                    facing1 = Direction.East;
                    facing2 = Direction.North;
                    break;
                case Direction.West:
                    port1 = 222;
                    port2 = 153;
                    facing1 = Direction.North;
                    facing2 = Direction.West;
                    break;
            }
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GOTASTRALITEM) <= 1 || !HasItem(player, type, doMsgs, NIMBUSOFTHEFATES)) {
                TeleportParty(player, type, doMsgs, 11, 3, port1, facing1);
            }
            else {
                TeleportParty(player, type, doMsgs, 11, 3, port2, facing2);
            }
        }

        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int port1 = 0;
            int port2 = 0;
            Direction facing1 = 0;
            Direction facing2 = 0;
            Compass(player, type, doMsgs);
            switch (GetFacing(player, type, doMsgs)) {
                case Direction.North:
                    port1 = 232;
                    port2 = 157;
                    facing1 = Direction.East;
                    facing2 = Direction.North;
                    break;
                case Direction.South:
                    port2 = 157;
                    if (GetFlag(player, type, doMsgs, FlagTypeParty, WHEREWEREYOU) == 255) {
                        port1 = 198;
                    }
                    else {
                        port1 = 158;
                    }
                    facing1 = Direction.West;
                    facing2 = Direction.South;
                    break;
                case Direction.East:
                    port1 = 157;
                    if (GetFlag(player, type, doMsgs, FlagTypeParty, WHEREWEREYOU) == 255) {
                        port2 = 175;
                    }
                    else {
                        port2 = 232;
                    }
                    facing1 = Direction.West;
                    facing2 = Direction.South;
                    break;
                case Direction.West:
                    port1 = 187;
                    port2 = 228;
                    facing1 = Direction.North;
                    facing2 = Direction.West;
                    break;
            }
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GOTASTRALITEM) <= 1 || (!HasItem(player, type, doMsgs, NIMBUSOFTHEFATES))) {
                TeleportParty(player, type, doMsgs, 11, 3, port1, facing1);
            }
            else {
                TeleportParty(player, type, doMsgs, 11, 3, port2, facing2);
            }
        }

        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int port1 = 0;
            int port2 = 0;
            Direction facing1 = 0;
            Direction facing2 = 0;
            Compass(player, type, doMsgs);
            switch (GetFacing(player, type, doMsgs)) {
                case Direction.North:
                    port1 = 172;
                    port2 = 183;
                    facing1 = Direction.East;
                    facing2 = Direction.North;
                    break;
                case Direction.South:
                    port2 = 198;
                    port1 = 213;
                    facing1 = Direction.West;
                    facing2 = Direction.South;
                    break;
                case Direction.East:
                    port1 = 157;
                    if (GetFlag(player, type, doMsgs, FlagTypeParty, WHEREWEREYOU) == 255) {
                        port2 = 175;
                    }
                    else {
                        port2 = 153;
                    }
                    facing1 = Direction.West;
                    facing2 = Direction.South;
                    break;
                case Direction.West:
                    port1 = 187;
                    port2 = 237;
                    facing1 = Direction.North;
                    facing2 = Direction.West;
                    break;
            }
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GOTASTRALITEM) <= 1 || (!HasItem(player, type, doMsgs, NIMBUSOFTHEFATES))) {
                TeleportParty(player, type, doMsgs, 11, 3, port1, facing1);
            }
            else {
                TeleportParty(player, type, doMsgs, 11, 3, port2, facing2);
            }
        }

        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetFlag(player, type, doMsgs, FlagTypeParty, WHEREWEREYOU, GetTile(player, type, doMsgs));
            TeleportParty(player, type, doMsgs, 11, 3, 228, Direction.North);
        }

        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GUARDIAN) == 0)) {
                SetTreasure(player, type, doMsgs, PHOSPHORESCENTBLADE, HEALAMPHORA, HEALAMPHORA, MANAAMPHORA, 0, 15000);
            }
            ShowText(player, type, doMsgs, "'You shall not pass!'");
            AddEncounter(player, type, doMsgs, 01, 39);
        }

        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            for (i = 1; i <= 2; i++) {
                AddEncounter(player, type, doMsgs, i, 38);
            }
        }

        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            if (GetTile(player, type, doMsgs) == 190) {
                if ((!HasItem(player, type, doMsgs, EYEOFCIRCINUS))) {
                    SetTreasure(player, type, doMsgs, EYEOFCIRCINUS, MANAAMPHORA, SPIRITUALARMOR, 0, 0, 3000);
                    ShowText(player, type, doMsgs, "Guardians of the Winds defend the Eye; the compass that will guide you towards the Nimbus.");
                }
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GOTASTRALITEM) == 0)) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GOTASTRALITEM, 1);
                }
            }
            if (GetPartyCount(player, type, doMsgs) < 3) {
                for (i = 1; i <= 3; i++) {
                    AddEncounter(player, type, doMsgs, i, 36);
                }
            }
            else {
                for (i = 1; i <= 6; i++) {
                    AddEncounter(player, type, doMsgs, i, 36);
                }
            }
        }

        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            ShowText(player, type, doMsgs, "Restless entities battle eternally here.");
            if (GetPartyCount(player, type, doMsgs) < 3) {
                for (i = 1; i <= 3; i++) {
                    AddEncounter(player, type, doMsgs, i, 35);
                }
            }
            else {
                for (i = 1; i <= 5; i++) {
                    AddEncounter(player, type, doMsgs, i, 35);
                }
            }
        }

        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                ShowText(player, type, doMsgs, "An astral wind rips through you.");
                DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 8);
                SprungTrap(player, type, doMsgs);
            }
        }

        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeParty, METWRAITH) == 0)) {
                ShowPortrait(player, type, doMsgs, WRAITH);
                ShowText(player, type, doMsgs, "'The Wind Knights hath no fury in this domain! The four winds here are reversed!'");
                SetFlag(player, type, doMsgs, FlagTypeParty, METWRAITH, 1);
            }
        }

        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeParty, METNIGHTELF) == 0)) {
                ShowPortrait(player, type, doMsgs, NIGHTELFWARRIOR);
                ShowText(player, type, doMsgs, "'Feuding entities battle the winds. Direction is the key to the portals here.");
                ShowText(player, type, doMsgs, "I offer you this, the first letter of each direction is visible when you see in the past!");
                ShowText(player, type, doMsgs, "Do not think that you must move in a different direction each move the second time through...see in the past!'");
                SetFlag(player, type, doMsgs, FlagTypeParty, METNIGHTELF, 1);
            }
        }

        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                case 2:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 33);
                    }
                    break;
                default:
                    for (i = 1; i <= 5; i++) {
                        AddEncounter(player, type, doMsgs, i, 34);
                    }
                    break;
            }
        }

        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
            ShowText(player, type, doMsgs, "The Fountain of Faith speaks: ");
            ShowText(player, type, doMsgs, "'See in the past...past tense of SEE!'");
            ModifyHealth(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
        }

        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                ShowPortrait(player, type, doMsgs, FOUNTAIN);
                ShowText(player, type, doMsgs, "The Fountain of Lies ");
                ShowText(player, type, doMsgs, "whispers: 'See in the past? Ha! Look towards the future!'");
                DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 8);
                SetDebuff(player, type, doMsgs, POISON, 10, 250);
                SprungTrap(player, type, doMsgs);
            }
        }

        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                ShowText(player, type, doMsgs, "Noxious gas fills the room");
                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 6);
                SetDebuff(player, type, doMsgs, POISON, 5, 250);
                SprungTrap(player, type, doMsgs);
            }
        }

        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int mn = 0;
            int mn2 = 0;
            int pfv = 0;
            int itemA = 0;
            int itemB = 0;
            int itemC = 0;
            int gps = 0;
            int g2 = 0;
            pfv = GetFlag(player, type, doMsgs, FlagTypeParty, FIGHT_ME);
            if (pfv < 1) {
                pfv = 1;
            }
            switch (pfv) {
                case 1:
                    mn = 32;
                    mn2 = 31;
                    g2 = 2;
                    pfv = 2;
                    if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.AMPHORAENCS) == 0)) {
                        itemA = HEALAMPHORA;
                        itemB = MANAAMPHORA;
                        itemC = MIDNIGHTAEGIS;
                        SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.AMPHORAENCS, 1);
                    }
                    gps = 5000;
                    break;
                case 2:
                    mn = 2;
                    mn2 = 1;
                    g2 = 2;
                    pfv = 3;
                    itemA = BLACKBLADE;
                    gps = 2500;
                    break;
                case 3:
                    g2 = 2;
                    pfv = 4;
                    if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.AMPHORAENCS) == 1) {
                        ShowText(player, type, doMsgs, "Powerful beasts battle here for amphoras!!");
                        mn = 31;
                        mn2 = 30;
                        itemA = HEALAMPHORA;
                        itemB = HEALAMPHORA;
                        itemC = HEALAMPHORA;
                        SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.AMPHORAENCS, 2);
                    }
                    else {
                        mn = 32;
                        mn2 = 32;
                        itemA = HEALALLPOTION;
                        itemB = TWOHANDEDSWORD;
                    }
                    break;
                case 4:
                    mn = 5;
                    mn2 = 5;
                    pfv = 5;
                    itemA = MANAAMPHORA;
                    itemB = MANARESTORE;
                    gps = 2500;
                    break;
                case 5:
                    mn = 3;
                    mn2 = 3;
                    g2 = 2;
                    pfv = 2;
                    break;
            }
            SetTreasure(player, type, doMsgs, itemA, itemB, itemC, 0, 0, gps);
            AddEncounter(player, type, doMsgs, 01, mn);
            if (g2 != 0) {
                AddEncounter(player, type, doMsgs, g2, mn2);
            }
            SetFlag(player, type, doMsgs, FlagTypeParty, FIGHT_ME, pfv);
        }

        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Screams of some ghostly spirit echo within these walls.");
        }

        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Hail all who seek Corpeus of the Physical plane.");
            ShowText(player, type, doMsgs, "This pathway will lead to his Hall.");
        }

        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You can taste the stale air that fills this area. The floor here is covered with stagnant pools of strange liquids.");
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.POOLNUMBER) == 0)) {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.POOLNUMBER, 1);
            }
        }

        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                ShowText(player, type, doMsgs, "The heat overwhelms you here.");
                DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 8);
                SprungTrap(player, type, doMsgs);
            }
        }

        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            if (GetFlag(player, type, doMsgs, FlagTypeParty, LAVA_A) == 1 || HasItem(player, type, doMsgs, GAUNTLETSOFMERCY) || HasItem(player, type, doMsgs, SKULLAEGIS)) {
                SetTreasure(player, type, doMsgs, SAMURAISWORD, 0, 0, 0, 0, 2000);
            }
            else {
                SetTreasure(player, type, doMsgs, GAUNTLETSOFMERCY, SKULLAEGIS, TRACKERSMASK, 0, 0, 1000);
            }
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                case 2:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 25);
                    }
                    break;
                default:
                    for (i = 1; i <= 5; i++) {
                        AddEncounter(player, type, doMsgs, i, 25);
                    }
                    break;
            }
        }

        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                case 2:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 22);
                    }
                    break;
                default:
                    for (i = 1; i <= 5; i++) {
                        AddEncounter(player, type, doMsgs, i, 22);
                    }
                    break;
            }
        }

        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 23);
                    }
                    break;
                default:
                    for (i = 1; i <= 3; i++) {
                        AddEncounter(player, type, doMsgs, i, 23);
                    }
                    break;
            }
        }

        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                case 2:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 24);
                    }
                    break;
                default:
                    for (i = 1; i <= 5; i++) {
                        AddEncounter(player, type, doMsgs, i, 24);
                    }
                    break;
            }
        }

        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GOTPHYSITEM) == 0)) {
                SetTreasure(player, type, doMsgs, REALITYSRAMPART, 0, 0, 0, 0, 15000);
            }
            else if ((!HasItem(player, type, doMsgs, REALITYSRAMPART))) {
                SetTreasure(player, type, doMsgs, REALITYSRAMPART, 0, 0, 0, 0, 3500);
            }
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 30);
                    }
                    AddEncounter(player, type, doMsgs, 6, 26);
                    break;
                case 2:
                    for (i = 1; i <= 3; i++) {
                        AddEncounter(player, type, doMsgs, i, 30);
                    }
                    AddEncounter(player, type, doMsgs, 6, 26);
                    break;
                default:
                    NoSpellZone(player, type, doMsgs);
                    for (i = 1; i <= 4; i++) {
                        AddEncounter(player, type, doMsgs, i, 30);
                    }
                    AddEncounter(player, type, doMsgs, 6, 26);
                    break;
            }
        }

        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            switch (GetTileState(player, type, doMsgs)) {
                case 1:
                    ShowText(player, type, doMsgs, "The flickering torches cast eerie shadows.");
                    break;
                default:
                    ShowText(player, type, doMsgs, "Jeweled torch-lamps are affixed to the walls here as switches. Each has three settings. You must know the pattern to set the correct sequence.");
                    IncTileState(player, type, doMsgs);
                    break;
            }
        }

        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 30);
                    }
                    break;
                case 2:
                    for (i = 1; i <= 4; i++) {
                        AddEncounter(player, type, doMsgs, i, 30);
                    }
                    break;
                default:
                    for (i = 1; i <= 6; i++) {
                        AddEncounter(player, type, doMsgs, i, 30);
                    }
                    break;
            }
        }

        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 28);
                    }
                    break;
                case 2:
                    for (i = 1; i <= 4; i++) {
                        AddEncounter(player, type, doMsgs, i, 28);
                    }
                    break;
                default:
                    for (i = 1; i <= 6; i++) {
                        AddEncounter(player, type, doMsgs, i, 28);
                    }
                    break;
            }
        }

        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 29);
                    }
                    break;
                case 2:
                    for (i = 1; i <= 3; i++) {
                        AddEncounter(player, type, doMsgs, i, 29);
                    }
                    break;
                default:
                    for (i = 1; i <= 5; i++) {
                        AddEncounter(player, type, doMsgs, i, 29);
                    }
                    break;
            }
        }

        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "To Corpeus.");
        }

        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "TO TORCH ROOM");
            TeleportParty(player, type, doMsgs, 11, 3, 24, Direction.East);
        }

        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int portnumber = 0;
            Direction compass = 0;
            Direction wall = 0;
            int coord = 0;
            portnumber = GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SWITCHESSET);
            DisablePartyJoining(player, type, doMsgs);
            switch (GetTile(player, type, doMsgs)) {
                case 161:
                    portnumber = 1;
                    wall = Direction.West;
                    compass = Direction.East;
                    coord = 50;
                    break;
                case 145:
                    portnumber = 2;
                    wall = Direction.East;
                    compass = Direction.West;
                    coord = 74;
                    break;
                case 129:
                    portnumber = 3;
                    wall = Direction.West;
                    compass = Direction.East;
                    coord = 123;
                    break;
                case 113:
                    portnumber = 4;
                    wall = Direction.East;
                    compass = Direction.East;
                    coord = 115;
                    break;
            }
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SWITCHESSET) >= portnumber) {
                ShowText(player, type, doMsgs, "A magical portal appears in the wall!");
                SetWallItem(player, type, doMsgs, GATEWAY, GetTile(player, type, doMsgs), wall);
                if (GetPartyCount(player, type, doMsgs) == 1) {
                    TeleportParty(player, type, doMsgs, 11, 3, coord, compass);
                }
                else {
                    ShowText(player, type, doMsgs, "You must enter alone!");
                }
            }
            else {
                ClearWallItem(player, type, doMsgs, GetTile(player, type, doMsgs), wall);
                Nothing(player, type, doMsgs);
            }
        }

        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PHYSFNT) == 0)) {
                ShowText(player, type, doMsgs, "The Fountain of Corpeus raises your physical prowess and enhances your agility!");
                ModAttribute(player, type, doMsgs, STRENGTH, 1);
                ModAttribute(player, type, doMsgs, AGILITY, 2);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PHYSFNT, 1);
            }
            else {
                ShowText(player, type, doMsgs, "The waters heal you.");
                ModifyHealth(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
            }
        }

        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int trap = 0;
            trap = GetFlag(player, type, doMsgs, FlagTypeParty, CASETRAP2);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                if (GetGuild(player, type, doMsgs) == THIEF || GetGuild(player, type, doMsgs) == RANGER) {
                    ShowText(player, type, doMsgs, "Your keen senses allow you to avoid a devastating trap.");
                }
                else {
                    switch (trap) {
                        case 1:
                            DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 6);
                            NoMapsZone(player, type, doMsgs);
                            NoSpellZone(player, type, doMsgs);
                            ShowText(player, type, doMsgs, "The torch here explodes with fire!");
                            trap++;
                            break;
                        case 2:
                            DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) - 2000);
                            SetDebuff(player, type, doMsgs, POISON, 15, 100);
                            PoisTxt(player, type, doMsgs);
                            trap++;
                            break;
                        case 3:
                            DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 2);
                            FlameTxt(player, type, doMsgs);
                            trap++;
                            break;
                        case 4:
                            SetDebuff(player, type, doMsgs, PARALYSIS, 10, 0);
                            ModifyMana(player, type, doMsgs, -2000);
                            while (HasItem(player, type, doMsgs, ZEUSSCROLL))
                                RemoveItem(player, type, doMsgs, ZEUSSCROLL);
                            ShowText(player, type, doMsgs, "You clumsily set off a gas trap.");
                            trap++;
                            break;
                        case 5:
                            ShowText(player, type, doMsgs, "A refreshing shower of magical waters is a nice change to these fiendish traps!");
                            ModifyMana(player, type, doMsgs, 200);
                            ModifyHealth(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 4);
                            ClearDebuff(player, type, doMsgs, POISON);
                            ClearDebuff(player, type, doMsgs, PARALYSIS);
                            ClearDebuff(player, type, doMsgs, PETRIFY);
                            trap++;
                            break;
                        default:
                            DamageBy6(player, type, doMsgs);
                            DisableHealing(player, type, doMsgs);
                            trap = 1;
                            NoSpellZone(player, type, doMsgs);
                            ShowText(player, type, doMsgs, "A mental blast of power is thrust upon you!");
                            break;
                    }
                }
                SetFlag(player, type, doMsgs, FlagTypeParty, CASETRAP2, trap);
                SprungTrap(player, type, doMsgs);
            }
        }

        protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, GNOMEWIZARD);
            int flag = 0;
            int switches = 0;
            switches = GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SPOKEWITHGRATOK);
            switch (GetTile(player, type, doMsgs)) {
                case 98:
                    flag = 1;
                    if (switches < flag) {
                        ShowText(player, type, doMsgs, "'Ahh, welcome to the Physical path. I am Gratok, allow me to guide you.");
                        ShowText(player, type, doMsgs, "Go now to the west then to the south. Search the walls for the portals. I will see you there.'");
                    }
                    break;
                case 177:
                    flag = 2;
                    if (switches < flag) {
                        ShowText(player, type, doMsgs, "'We meet again. Now, northward, portals here will open when you have completed certain actions.");
                        ShowText(player, type, doMsgs, "Remember to search the walls!'");
                        if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SWITCHESSET) == 0)) {
                            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SWITCHESSET, 1);
                        }
                    }
                    break;
                case 55:
                    flag = 3;
                    if (switches < flag) {
                        ShowText(player, type, doMsgs, "'Servitude is my destiny now. For I had created this pathway in honor of Corpeus. Now I am doomed to help those who would seek him.'");
                    }
                    break;
                case 87:
                    flag = 4;
                    if (switches <= flag) {
                        ShowText(player, type, doMsgs, "'Well done. You must find the room where torches are switches. Set them as I say, then return to the starting hallway.");
                        ShowText(player, type, doMsgs, "Time follows death from life'");
                    }
                    break;
                case 118:
                    flag = 5;
                    if (switches <= flag) {
                        ShowText(player, type, doMsgs, "'Time wastes. Past the Guardians to the east of stagnation lies the torch room. You must know the combination to proceed there.'");
                    }
                    break;
                case 11:
                    if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GOTPHYSITEM) == 1) || (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GOTPHYSITEM) == 2)) {
                        ShowText(player, type, doMsgs, "'WELL DONE! Off you go to the next phase. Water leads to magic sands.'");
                        SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GOTPHYSITEM, 2);
                    }
                    break;
                case 26:
                    flag = switches;
                    if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GOTPHYSITEM) == 0)) {
                        ShowText(player, type, doMsgs, "'You must try again. This portal will take you to the start of this level.'");
                    }
                    else {
                        ShowText(player, type, doMsgs, "Now you may enter the torch room again.");
                    }
                    break;
                case 224:
                    flag = 8;
                    if (switches <= flag) {
                        ShowText(player, type, doMsgs, "'Onward! You've earned the next series by conquering the Hall.");
                        ShowText(player, type, doMsgs, "Magic lava leads to death.'");
                    }
                    break;
            }
            if (switches < flag) {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SPOKEWITHGRATOK, flag);
                Default(player, type, doMsgs);
            }
            else {
                Default(player, type, doMsgs);
            }
        }

        private void Default(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "'Do as I say. My familiars will guide you.'");
        }

        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DamageBy6(player, type, doMsgs);
            NoSpellZone(player, type, doMsgs);
            ShowText(player, type, doMsgs, "The magical fluids drain you.");
        }

        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            ShowText(player, type, doMsgs, "Medusas guard this gateway!");
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 27);
                    }
                    break;
                case 2:
                    for (i = 1; i <= 3; i++) {
                        AddEncounter(player, type, doMsgs, i, 27);
                    }
                    break;
                default:
                    for (i = 1; i <= 5; i++) {
                        AddEncounter(player, type, doMsgs, i, 27);
                    }
                    break;
            }
        }

        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                case 2:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 19);
                    }
                    break;
                default:
                    for (i = 1; i <= 5; i++) {
                        AddEncounter(player, type, doMsgs, i, 19);
                    }
                    break;
            }
        }

        protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "This hallway is laden with traps. You are powerless and confused.");
            NoMapsZone(player, type, doMsgs);
            NoSpellZone(player, type, doMsgs);
            int trap = 0;
            trap = GetFlag(player, type, doMsgs, FlagTypeParty, CASETRAP);
            Compass(player, type, doMsgs);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                if (GetGuild(player, type, doMsgs) == THIEF) {
                    ShowText(player, type, doMsgs, "You manage to avoid the trap!");
                }
                else {
                    switch (trap) {
                        case 1:
                            DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 6);
                            SetDebuff(player, type, doMsgs, POISON, 5, 100);
                            PoisTxt(player, type, doMsgs);
                            trap++;
                            break;
                        case 2:
                            DoDamage(player, type, doMsgs, 350);
                            FlameTxt(player, type, doMsgs);
                            trap++;
                            break;
                        default:
                            DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 8);
                            ModifyMana(player, type, doMsgs, -150);
                            trap = 1;
                            ShowText(player, type, doMsgs, "A whirlwind of magic rushes through the hallway draining and dragging you!");
                            TeleportParty(player, type, doMsgs, 11, 3, GetTile(player, type, doMsgs), Direction.East);
                            break;
                    }
                }
                SetFlag(player, type, doMsgs, FlagTypeParty, CASETRAP, trap);
                SprungTrap(player, type, doMsgs);
            }
        }

        protected override void FnEvent3B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            Compass(player, type, doMsgs);
            NoMapsZone(player, type, doMsgs);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                switch (GetFacing(player, type, doMsgs)) {
                    case Direction.North:
                        SetFacing(player, type, doMsgs, Direction.East);
                        break;
                    case Direction.South:
                        SetFacing(player, type, doMsgs, Direction.East);
                        SetFacing(player, type, doMsgs, Direction.South);
                        SetFacing(player, type, doMsgs, Direction.North);
                        TeleportParty(player, type, doMsgs, 11, 3, GetTile(player, type, doMsgs), Direction.North);
                        break;
                    case Direction.West:
                        SetFacing(player, type, doMsgs, Direction.North);
                        SetFacing(player, type, doMsgs, Direction.South);
                        SetFacing(player, type, doMsgs, Direction.East);
                        break;
                    case Direction.East:
                        TeleportParty(player, type, doMsgs, 11, 3, GetTile(player, type, doMsgs), Direction.North);
                        break;
                }
                SprungTrap(player, type, doMsgs);
                if (GetTile(player, type, doMsgs) == 179) {
                    if ((GetFlag(player, type, doMsgs, FlagTypeParty, INHALLWAY) == 0)) {
                        RemainText(player, type, doMsgs);
                        ShowText(player, type, doMsgs, "Back to the beginning! You must try again.");
                        TeleportParty(player, type, doMsgs, 11, 3, 123, Direction.East);
                    }
                }
            }
        }

        protected override void FnEvent3C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NoMapsZone(player, type, doMsgs);
            ShowText(player, type, doMsgs, "This hallway is of lethal cunning. Only the most ingenious and powerful heroes will survive.");
            if ((GetFlag(player, type, doMsgs, FlagTypeParty, INHALLWAY) == 0)) {
                SetFlag(player, type, doMsgs, FlagTypeParty, INHALLWAY, 1);
                ShowPortrait(player, type, doMsgs, GNOMEWIZARD);
                ShowText(player, type, doMsgs, "'I can not help you here. I offer you this warning:'");
                RemainText(player, type, doMsgs);
                ShowText(player, type, doMsgs, "'Farewell!'");
            }
        }

        protected override void FnEvent3D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            ShowText(player, type, doMsgs, "An unseen force holds you back!");
        }

        protected override void FnEvent3E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int flag = 0;
            int ai = 0;
            int wwy = 0;
            wwy = GetFlag(player, type, doMsgs, FlagTypeParty, WHEREWEREYOU);
            ai = GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GOTASTRALITEM);
            NoMapsZone(player, type, doMsgs);
            if (IsPartyLeader(player, type, doMsgs)) {
                if ((ai <= 1) || ((!HasItem(player, type, doMsgs, NIMBUSOFTHEFATES)))) {
                    switch (GetTile(player, type, doMsgs)) {
                        case 228:
                            flag = 236;
                            break;
                        case 232:
                            flag = 228;
                            break;
                        case 217:
                            flag = 232;
                            break;
                        case 153:
                            flag = 217;
                            break;
                        case 157:
                            flag = 153;
                            break;
                    }
                }
                else if (ai >= 2) {
                    switch (GetTile(player, type, doMsgs)) {
                        case 228:
                            flag = 236;
                            break;
                        case 232:
                            flag = 153;
                            break;
                        case 217:
                            flag = 0;
                            break;
                        case 153:
                            flag = 157;
                            break;
                        case 157:
                            flag = 228;
                            break;
                    }
                }
                if (wwy == 255 || wwy != flag) {
                    SetFlag(player, type, doMsgs, FlagTypeParty, WHEREWEREYOU, 255);
                }
                else if (GetFlag(player, type, doMsgs, FlagTypeParty, WHEREWEREYOU) == flag) {
                    SetFlag(player, type, doMsgs, FlagTypeParty, WHEREWEREYOU, GetTile(player, type, doMsgs));
                }
            }
        }

        private void FlameTxt(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A dragon's face carved on the wall here animates and spews forth dragon's breath!");
        }

        private void PoisTxt(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Deadly poisons drip onto you from above.");
        }

        private void Compass(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == RANGER || HasItem(player, type, doMsgs, EYEOFCIRCINUS)) {
                switch (GetFacing(player, type, doMsgs)) {
                    case Direction.North:
                        ShowText(player, type, doMsgs, "North");
                        break;
                    case Direction.West:
                        ShowText(player, type, doMsgs, "West");
                        break;
                    case Direction.East:
                        ShowText(player, type, doMsgs, "East");
                        break;
                    case Direction.South:
                        ShowText(player, type, doMsgs, "South");
                        break;
                }
            }
        }

        private void RemainText(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "'You must remain in this hallway until your task has been completed!'");
        }

        private void Center(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "-Center-");
        }

        private void SprungTrap(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP, 1);
        }

        private void DamageBy6(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 6);
        }

        private void Nothing(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "There is nothing here.");
        }

        private void NoSpellZone(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableSpells(player, type, doMsgs);
            DisableSkills(player, type, doMsgs);
        }

        private void NoMapsZone(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableAutomaps(player, type, doMsgs);
        }

        protected override void FnEvent3F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GUARDIAN, 1);
        }

        protected override void FnEvent40(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int switchA = 0;
            int valueA = 0;
            int valueB = 0;
            switchA = GetFlag(player, type, doMsgs, FlagTypeParty, TORCH1);
            switch (switchA) {
                case 1:
                    ShowText(player, type, doMsgs, "DEATH");
                    valueA = 3;
                    valueB = 0;
                    switchA = 2;
                    break;
                case 2:
                    ShowText(player, type, doMsgs, "WATER");
                    valueA = 0;
                    valueB = 6;
                    switchA = 3;
                    break;
                default:
                    Center(player, type, doMsgs);
                    valueA = 0;
                    valueB = 0;
                    switchA = 1;
                    break;
            }
            SetFlag(player, type, doMsgs, FlagTypeParty, DEATHW, valueA);
            SetFlag(player, type, doMsgs, FlagTypeParty, WATERW, valueB);
            SetFlag(player, type, doMsgs, FlagTypeParty, TORCH1, switchA);
        }

        protected override void FnEvent41(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int switchA = 0;
            int valueA = 0;
            int valueB = 0;
            switchA = GetFlag(player, type, doMsgs, FlagTypeParty, TORCH2);
            switch (switchA) {
                case 1:
                    ShowText(player, type, doMsgs, "LIFE");
                    valueA = 5;
                    valueB = 0;
                    switchA = 2;
                    break;
                case 2:
                    ShowText(player, type, doMsgs, "SANDS");
                    valueA = 0;
                    valueB = 10;
                    switchA = 3;
                    break;
                default:
                    Center(player, type, doMsgs);
                    valueA = 0;
                    valueB = 0;
                    switchA = 1;
                    break;
            }
            SetFlag(player, type, doMsgs, FlagTypeParty, LIFEW, valueA);
            SetFlag(player, type, doMsgs, FlagTypeParty, SANDSW, valueB);
            SetFlag(player, type, doMsgs, FlagTypeParty, TORCH2, switchA);
        }

        protected override void FnEvent42(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int switchA = 0;
            int valueA = 0;
            int valueB = 0;
            switchA = GetFlag(player, type, doMsgs, FlagTypeParty, TORCH3);
            switch (switchA) {
                case 1:
                    ShowText(player, type, doMsgs, "TO");
                    valueA = 8;
                    valueB = 0;
                    switchA = 2;
                    break;
                case 2:
                    ShowText(player, type, doMsgs, "FOLLOWS");
                    valueA = 0;
                    valueB = 2;
                    switchA = 3;
                    break;
                default:
                    Center(player, type, doMsgs);
                    valueA = 0;
                    valueB = 0;
                    switchA = 1;
                    break;
            }
            SetFlag(player, type, doMsgs, FlagTypeParty, TOW, valueA);
            SetFlag(player, type, doMsgs, FlagTypeParty, FOLLOWSW, valueB);
            SetFlag(player, type, doMsgs, FlagTypeParty, TORCH3, switchA);
        }

        protected override void FnEvent43(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int switchA = 0;
            int valueA = 0;
            int valueB = 0;
            switchA = GetFlag(player, type, doMsgs, FlagTypeParty, TORCH4);
            switch (switchA) {
                case 1:
                    ShowText(player, type, doMsgs, "TIME");
                    valueA = 1;
                    valueB = 0;
                    switchA = 2;
                    break;
                case 2:
                    ShowText(player, type, doMsgs, "MAGIC");
                    valueA = 0;
                    valueB = 9;
                    switchA = 3;
                    break;
                default:
                    Center(player, type, doMsgs);
                    valueA = 0;
                    valueB = 0;
                    switchA = 1;
                    break;
            }
            SetFlag(player, type, doMsgs, FlagTypeParty, TIMEW, valueA);
            SetFlag(player, type, doMsgs, FlagTypeParty, MAGICW, valueB);
            SetFlag(player, type, doMsgs, FlagTypeParty, TORCH4, switchA);
        }

        protected override void FnEvent44(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int switchA = 0;
            int valueA = 0;
            int valueB = 0;
            switchA = GetFlag(player, type, doMsgs, FlagTypeParty, TORCH5);
            switch (switchA) {
                case 1:
                    ShowText(player, type, doMsgs, "LAVA");
                    valueA = 11;
                    valueB = 0;
                    switchA = 2;
                    break;
                case 2:
                    ShowText(player, type, doMsgs, "FROM");
                    valueA = 0;
                    valueB = 4;
                    switchA = 3;
                    break;
                default:
                    Center(player, type, doMsgs);
                    valueA = 0;
                    valueB = 0;
                    switchA = 1;
                    break;
            }
            SetFlag(player, type, doMsgs, FlagTypeParty, LAVAW, valueA);
            SetFlag(player, type, doMsgs, FlagTypeParty, FROMW, valueB);
            SetFlag(player, type, doMsgs, FlagTypeParty, TORCH5, switchA);
        }

        protected override void FnEvent45(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int switchA = 0;
            int valueA = 0;
            int valueB = 0;
            switchA = GetFlag(player, type, doMsgs, FlagTypeParty, TORCH6);
            switch (switchA) {
                case 1:
                    ShowText(player, type, doMsgs, "OF");
                    valueA = 12;
                    valueB = 0;
                    switchA = 2;
                    break;
                case 2:
                    ShowText(player, type, doMsgs, "LEADS");
                    valueA = 0;
                    valueB = 7;
                    switchA = 3;
                    break;
                default:
                    Center(player, type, doMsgs);
                    valueA = 0;
                    valueB = 0;
                    switchA = 1;
                    break;
            }
            SetFlag(player, type, doMsgs, FlagTypeParty, OFW, valueA);
            SetFlag(player, type, doMsgs, FlagTypeParty, LEADSW, valueB);
            SetFlag(player, type, doMsgs, FlagTypeParty, TORCH6, switchA);
        }

        protected override void FnEvent46(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int setupport = 0;
            int flag = 0;
            flag = 0;
            setupport = GetFlag(player, type, doMsgs, FlagTypeParty, DEATHW) + GetFlag(player, type, doMsgs, FlagTypeParty, WATERW) + GetFlag(player, type, doMsgs, FlagTypeParty, LIFEW) + GetFlag(player, type, doMsgs, FlagTypeParty, SANDSW) + GetFlag(player, type, doMsgs, FlagTypeParty, TOW) + GetFlag(player, type, doMsgs, FlagTypeParty, FOLLOWSW) + GetFlag(player, type, doMsgs, FlagTypeParty, TIMEW) + GetFlag(player, type, doMsgs, FlagTypeParty, MAGICW) + GetFlag(player, type, doMsgs, FlagTypeParty, LAVAW) + GetFlag(player, type, doMsgs, FlagTypeParty, FROMW) + GetFlag(player, type, doMsgs, FlagTypeParty, OFW) + GetFlag(player, type, doMsgs, FlagTypeParty, LEADSW);
            switch (setupport) {
                case 15:
                    flag = 2;
                    break;
                case 40:
                    flag = 3;
                    break;
                case 38:
                    flag = 4;
                    break;
                default:
                    flag = 1;
                    break;
            }
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SWITCHESSET) < flag) {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SWITCHESSET, flag);
            }
            ShowText(player, type, doMsgs, "This portal is the only way back to the start of this level. Use it only if you have set the switches.");
            TeleportParty(player, type, doMsgs, 11, 3, 1, Direction.South);
        }

        protected override void FnEvent47(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GOTPHYSITEM) == 0)) {
                ModifyExperience(player, type, doMsgs, 650000);
                ShowText(player, type, doMsgs, "Gain experience for your accomplishment!");
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GOTPHYSITEM, 1);
            }
        }

        protected override void FnEvent48(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GOTPHYSITEM) == 0)) {
                TeleportParty(player, type, doMsgs, 11, 3, 1, Direction.South);
            }
            else {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                SetWallInvisible(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
        }

        protected override void FnEvent4B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SPOKEWITHGRATOK) >= 4) {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                SetWallItem(player, type, doMsgs, PORTAL, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ShowText(player, type, doMsgs, "Magical words emblazoned on the door glow as you approach: 'Torch Room'.");
            }
            else {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ShowText(player, type, doMsgs, "The door is sealed...you will be told when to return to the Torch Room.");
            }
        }
    }
}
