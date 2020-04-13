using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    /// <summary>
    /// L2: The Reservoir
    /// </summary>
    class TwMap05 : TwMap {
        public override int MapIndex => 5;
        public override int MapID => 0x0203;
        protected override int RandomEncounterChance => 5;
        protected override int RandomEncounterExtraCount => 0;

        private const int PARTYTEXT = 1;
        private const int MADKNIGHT = 2;
        private const int SPRUNGTRAP = 1;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableHealing(player, type, doMsgs);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILLEDAQUEUS) == 0)) {
                    ShowText(player, type, doMsgs, "The strong currents twist and pound your body.");
                    DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 8 + 1);
                    if (GetHealthCurrent(player, type, doMsgs) <= 0) {
                        ShowText(player, type, doMsgs, "You have been drowned by the force.");
                    }
                }
                else {
                    ShowText(player, type, doMsgs, "You've defeated Aqueus! You may travel safely through these waters.");
                }
                SetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP, 1);
            }
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The central Aqueduct lies through the east door.");
            TeleportParty(player, type, doMsgs, 2, 1, 160, Direction.East);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You have moved the column enough to squeeze by...but now you're not sure that was so wise.");
            ClearTileBlock(player, type, doMsgs, GetTile(player, type, doMsgs));
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Churning magic pulls water from below and dumps it here. The thundering noise is painful.");
            ShowText(player, type, doMsgs, "You feel you have acted unwisely...and you are proven correct as the force slams you against a very hard southern wall...");
            DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 2);
            if (GetHealthCurrent(player, type, doMsgs) <= 0) {
                // SHOW_TEXT(player, type, doMsgs, "And kills you.");
                // EXIT_DUNGEON(player, type, doMsgs);
            }
            else {
                ShowText(player, type, doMsgs, "And wounds you severely.");
                TeleportParty(player, type, doMsgs, 2, 3, 201, Direction.South);
            }
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                if (GetPartyCount(player, type, doMsgs) == 1) {
                    if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDCHANT) == 1) {
                        ShowText(player, type, doMsgs, "Reciting the chant the old giant taught you causes the waters to part and allows you to proceed.");
                        ClearTileBlock(player, type, doMsgs, GetTile(player, type, doMsgs));
                        SetFloorItem(player, type, doMsgs, 0, GetTile(player, type, doMsgs));
                    }
                    else {
                        ShowText(player, type, doMsgs, "The powerful currents here dash you repeatedly against the rocky shore...");
                        ShowText(player, type, doMsgs, "...and kill you.");
                        DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
                        // EXIT_DUNGEON(player, type, doMsgs);
                    }
                }
                else {
                    ShowText(player, type, doMsgs, "The narrows here must be passed by only one of you at a time.");
                    TeleportParty(player, type, doMsgs, 2, 3, 73, Direction.North);
                }
                SetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP, 1);
            }
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The violent currents of a whirlpool drag you under the water, carrying you helplessly eastward.");
            TeleportParty(player, type, doMsgs, 2, 3, 143, Direction.East);
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowRunes(player, type, ref doMsgs, "To one of three.");
            TeleportParty(player, type, doMsgs, 2, 3, 226, Direction.North);
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowRunes(player, type, ref doMsgs, "To two of three.");
            TeleportParty(player, type, doMsgs, 2, 3, 130, Direction.South);
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowRunes(player, type, ref doMsgs, "To three of three.");
            TeleportParty(player, type, doMsgs, 2, 3, 34, Direction.South);
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Gateway back to this level's entrance.");
            TeleportParty(player, type, doMsgs, 2, 3, 175, Direction.East);
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((HasUsedSkill(player, type, ref doMsgs, DETECT_SKILL) >= 6) || (HasUsedSpell(player, type, ref doMsgs, TRUE_SEEING_SPELL) >= 1) || UsedItem(player, type, ref doMsgs, HELMOFWISDOM, HELMOFWISDOM) || UsedItem(player, type, ref doMsgs, VALKYRIESHELM, VALKYRIESHELM) || UsedItem(player, type, ref doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || UsedItem(player, type, ref doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                ShowText(player, type, doMsgs, "Aha! A secret door!");
                PlaceDoor(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                ShowText(player, type, doMsgs, "There are scratches in the stones here.");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "'WARNING: Area under construction. Caution must be observed when exploring the reservoir.'");
            ShowText(player, type, doMsgs, " - Aeowyn, Queen of Twinion.");
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Three teleports, three choices.");
            ShowRunes(player, type, ref doMsgs, "I'm not telling you which ONE to choose.");
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "'Will you never listen?'");
            ShowText(player, type, doMsgs, "'Perhaps an old friend can help you cross the perilous waters to the northeast.'");
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILAM) == 1) {
                ShowText(player, type, doMsgs, "This is a very stubborn door. You rap your fists on it, but to no avail.");
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILAM, 2);
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILAM) == 2) {
                ShowText(player, type, doMsgs, "You again knock on the door in the hopes that something will open it.");
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILAM, 3);
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILAM) == 3) {
                ShowText(player, type, doMsgs, "As you knock a third time, the door opens just as Kilam said it would!");
                PlaceDoor(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
                PlaceDoor(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The door seems to be locked, but there's no lock to pick.");
            }
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDRHYME) == 1) {
                ShowText(player, type, doMsgs, "The magic that bars the gate dissipates, allowing you access.");
                WallClear(player, type, doMsgs);
            }
            else {
                ShowText(player, type, doMsgs, "The Giant's chant doesn't work here. Perhaps you must learn a new chant from him.");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A high-vaulted ceiling stretches into darkness while the deafening roar of the water fills this chasm of a reservoir.");
            ShowText(player, type, doMsgs, "To the northeast a spot of land is barely visible. To the northwest stretch the many pools of this eternal reservoir.");
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A magical force pumps the river into the reservoir. The noise is overpowering.");
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You can barely make out four large columns in the center of the reservoir; they surround what seems to be the origin of the deafening noise.");
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetFloorItem(player, type, doMsgs, WATER, 75);
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, PARTYTEXT) == 0)) {
                ShowText(player, type, doMsgs, "You've reached the other side of the reservoir.");
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SAVEDPARTY) == 0)) {
                    ShowText(player, type, doMsgs, "Peering back towards the distant shore, you see a small party struggling near the pump in the center.");
                    ShowText(player, type, doMsgs, "Perhaps you could go help them.");
                    SetFlag(player, type, doMsgs, FlagTypeParty, PARTYTEXT, 1);
                }
            }
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ENDGAMETELE) == 1) {
                if (GetPartyCount(player, type, doMsgs) == 1) {
                    ShowText(player, type, doMsgs, "Enter now. Your destiny awaits.");
                    TeleportParty(player, type, doMsgs, 2, 3, 210, Direction.North);
                }
                else {
                    ShowText(player, type, doMsgs, "You must be alone.");
                    if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                        SetFacing(player, type, doMsgs, Direction.East);
                        SprungTrap(player, type, doMsgs);
                    }
                }
            }
            else {
                FnEvent18(player, type, doMsgs);
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                ShowText(player, type, doMsgs, "Now, through the north gateway! Be quick!");
            }
            else {
                ShowText(player, type, doMsgs, "I warned you to come alone!");
                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 3);
                TeleportParty(player, type, doMsgs, 2, 3, 44, Direction.East);
            }
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ENDGAMETELE) == 1) {
                ShowText(player, type, doMsgs, "To the next nexus point.");
                TeleportParty(player, type, doMsgs, 3, 2, 0, Direction.South);
            }
            else {
                ShowText(player, type, doMsgs, "Treacherous fool...die in vain!");
                WallBlock(player, type, doMsgs);
                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
                // EXIT_DUNGEON(player, type, doMsgs);
            }
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You see another dazzling carving, similar to the one in some maze above.");
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int itemA = 0;
            int itemB = 0;
            int itemC = 0;
            int i = 0;
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILLEDAQUEUS) == 0)) {
                ShowText(player, type, doMsgs, "A gold throne sits to the north; to reach it you need only defeat he who guards it!");
                ShowText(player, type, doMsgs, "Lord Aqueus, an enormous giant, rises from his throne bellowing, 'You are no match for me, the Aqueduct's guardian.");
                ShowText(player, type, doMsgs, "Come, let me teach you the price of ignorance!'");
                switch (GetGuild(player, type, doMsgs)) {
                    case BARBARIAN:
                        itemA = BATTLEAXE;
                        itemB = SILVERBAR;
                        itemC = BREASTPLATE;
                        break;
                    case KNIGHT:
                        itemA = MORNINGSTAR;
                        itemB = ICESHIELD;
                        itemC = SILVERBAR;
                        break;
                    case RANGER:
                        itemA = SILVERBOW;
                        itemB = BERSERKERTALISMAN;
                        itemC = BLOODSHIELD;
                        break;
                    case THIEF:
                        itemA = VORANTISGAUNTLETS;
                        itemB = MEDITATIONCAP;
                        itemC = SACKCLOTHJACKET;
                        break;
                    case CLERIC:
                        itemA = NUNCHUKAS;
                        itemB = BLOODSHIELD;
                        itemC = SILVERBAR;
                        break;
                    case WIZARD:
                        itemA = HANDSOFTHEMAGI;
                        itemB = SACKCLOTHJACKET;
                        itemC = JADEDRING;
                        break;
                }
                SetTreasure(player, type, doMsgs, itemA, itemB, itemC, 0, 0, 2500);
            }
            else {
                ShowText(player, type, doMsgs, "Aqueus' successor rises to the challenge!");
                SetTreasure(player, type, doMsgs, HEALPOTION, HAWKSEYE, 0, 0, 0, 300);
            }
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    AddEncounter(player, type, doMsgs, 01, 40);
                    break;
                case 2:
                    ShowText(player, type, doMsgs, "Servants rush to his aide!");
                    AddEncounter(player, type, doMsgs, 01, 29);
                    AddEncounter(player, type, doMsgs, 02, 28);
                    AddEncounter(player, type, doMsgs, 06, 40);
                    break;
                default:
                    ShowText(player, type, doMsgs, "Servants rush to his aide!");
                    for (i = 1; i <= 4; i++) {
                        AddEncounter(player, type, doMsgs, i, 29);
                    }
                    AddEncounter(player, type, doMsgs, 5, 40);
                    break;
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HILLGIANT);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDCHANT) == 1) {
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.METJUBILAH) == 1) {
                    ShowText(player, type, doMsgs, "Sartiq speaks again, 'Now you must learn the Rhyme. With it you may enter his throne room.'");
                    ShowText(player, type, doMsgs, "Again the giant probes your mind, depositing a ritual chant to be used later.");
                    ShowText(player, type, doMsgs, "'FACE HIM! DEFEAT HIM! AVENGE ME!!'");
                    ShowText(player, type, doMsgs, "With that outburst, the last bit of life seeps from Sartiq's body.");
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDRHYME, 1);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.METJUBILAH, 2);
                }
                else {
                    ShowText(player, type, doMsgs, "'Leave me for now. Search for Malik south of here!'");
                }
            }
            else {
                ShowText(player, type, doMsgs, "An ancient, dying giant motions you to move closer.");
                ShowText(player, type, doMsgs, "'Hear me, whoever you are.  Aqueus is across the reservoir, to the northeast.");
                ShowText(player, type, doMsgs, "Listen to my chant, it will be useful!'");
                ShowText(player, type, doMsgs, "Sartiq uses his magic to burn the chant into your mind.");
                ShowText(player, type, doMsgs, "'The waters which guard his throne room will part with this ritual chant! All you need do is approach them!'");
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDCHANT, 1);
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int where = 0;
            if (GetPartyCount(player, type, doMsgs) == 1) {
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SAVEDPARTY) == 0)) {
                    ShowPortrait(player, type, doMsgs, DWARFKNIGHT);
                    ShowText(player, type, doMsgs, "A weary party fights the torrential waters nearby.");
                    ShowText(player, type, doMsgs, "'You! Yes, you! Come, help us. Help!!!'");
                    ShowText(player, type, doMsgs, "There must be something you can use to help them.");
                    if (UsedItem(player, type, ref doMsgs, ROPE, ROPE)) {
                        ShowText(player, type, doMsgs, "By repeatedly tossing one end of the rope to the party, you manage to pull them one by one to safety.");
                        ShowText(player, type, doMsgs, "When the last one is rescued, you fall back, exhausted.");
                        ShowText(player, type, doMsgs, "The leader approaches: 'Hail, friend! We would surely have drowned in these torrents had it not been for your timely arrival.");
                        ShowText(player, type, doMsgs, "Sorry you lost your rope in the waters.");
                        ShowText(player, type, doMsgs, "Take these gifts as our gratitude. Hail`'");
                        ShowText(player, type, doMsgs, "You feel wiser and wealthier.");
                        GiveItem(player, type, doMsgs, LONGSWORD);
                        GiveItem(player, type, doMsgs, SILVERBAR);
                        RemoveItem(player, type, doMsgs, ROPE);
                        ModifyGold(player, type, doMsgs, 2000);
                        ModifyExperience(player, type, doMsgs, 2000);
                        SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SAVEDPARTY, 1);
                    }
                    else if (UsedItem(player, type, ref doMsgs, SHORTSWORD, KEYOFC) || UsedItem(player, type, ref doMsgs, LIFEJACKET, UNITYRING)) {
                        ShowText(player, type, doMsgs, "Your efforts are valiant but futile!");
                        ShowText(player, type, doMsgs, "The party is swept away by the flood and vanishes into the murky depths.");
                        SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SAVEDPARTY, 2);
                    }
                }
                else {
                    ShowText(player, type, doMsgs, "The party is no longer here.");
                }
            }
            else {
                ShowText(player, type, doMsgs, "These torrential waters must be entered alone.");
                where = GetTile(player, type, doMsgs) - 1;
                TeleportParty(player, type, doMsgs, 2, 3, where, Direction.West);
            }
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int mn = 0;
            int mn2 = 0;
            int mn3 = 0;
            int g2 = 0;
            int g3 = 0;
            ShowText(player, type, doMsgs, "Young giants rush at you.");
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    mn = 32;
                    mn2 = 32;
                    g2 = 2;
                    break;
                default:
                    mn = 32;
                    mn2 = 32;
                    mn3 = 31;
                    g2 = 2;
                    g3 = 6;
                    break;
            }
            AddEncounter(player, type, doMsgs, 01, mn);
            if (g2 != 0) {
                AddEncounter(player, type, doMsgs, g2, mn2);
                if (g3 != 0) {
                    AddEncounter(player, type, doMsgs, g3, mn3);
                }
            }
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int mn = 0;
            int mn2 = 0;
            int mn3 = 0;
            int mn4 = 0;
            int g2 = 0;
            int g3 = 0;
            int g4 = 0;
            ShowText(player, type, doMsgs, "Frustrated adventurers, unable to find a secret passage here, turn to attack you!");
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    mn = 25;
                    mn2 = 26;
                    g2 = 5;
                    break;
                case 2:
                    mn = 25;
                    mn2 = 25;
                    mn3 = 30;
                    g2 = 2;
                    g3 = 4;
                    break;
                default:
                    mn = 30;
                    mn2 = 25;
                    mn3 = 27;
                    mn4 = 33;
                    g2 = 2;
                    g3 = 3;
                    g4 = 4;
                    break;
            }
            AddEncounter(player, type, doMsgs, 01, mn);
            if (g2 != 0) {
                AddEncounter(player, type, doMsgs, g2, mn2);
                if (g3 != 0) {
                    AddEncounter(player, type, doMsgs, g3, mn3);
                    if (g4 != 0) {
                        AddEncounter(player, type, doMsgs, g4, mn4);
                    }
                }
            }
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 32);
                    }
                    break;
                case 2:
                    for (i = 1; i <= 4; i++) {
                        AddEncounter(player, type, doMsgs, i, 32);
                    }
                    break;
                default:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 32);
                    }
                    for (i = 3; i <= 6; i++) {
                        AddEncounter(player, type, doMsgs, i, 30);
                    }
                    break;
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, GNOMEWIZARD);
            ShowText(player, type, doMsgs, "'These cursed walls keep sealing me in!");
            ShowText(player, type, doMsgs, "Oh, I do wish there was a faster way through this maze of horrors and giants!'");
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            ShowText(player, type, doMsgs, "Agents of Lord Aqueus charge you!");
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 28);
                    }
                    break;
                default:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 28);
                    }
                    for (i = 3; i <= 5; i++) {
                        AddEncounter(player, type, doMsgs, i, 29);
                    }
                    break;
            }
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            int giveem = 2;
            SetFloorItem(player, type, doMsgs, WATER, 127);
            if (GetPartyLevel(player, type, doMsgs, 12)) {
                giveem = 1;
            }
            switch (giveem) {
                case 1:
                    SetTreasure(player, type, doMsgs, ELIXIROFHEALTH, 0, 0, 0, 0, 500);
                    for (i = 1; i <= 6; i++) {
                        AddEncounter(player, type, doMsgs, i, 35);
                    }
                    break;
                default:
                    for (i = 1; i <= 3; i++) {
                        AddEncounter(player, type, doMsgs, i, 37);
                    }
                    break;
            }
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeParty, MADKNIGHT) == 0)) {
                ShowText(player, type, doMsgs, "A mad adventurer attacks you in a berserker's rage.");
                AddEncounter(player, type, doMsgs, 01, 39);
                SetFlag(player, type, doMsgs, FlagTypeParty, MADKNIGHT, 1);
            }
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HALFLINGTHIEF);
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.METJUBILAH) == 0) && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LEARNEDCHANT) == 1) {
                ShowText(player, type, doMsgs, "You find the thief Malik and recite the chant, hoping he will understand.");
                ShowText(player, type, doMsgs, "'Ah, you've found Sartiq! You must return, for your chant is not complete. He will teach you the rest when you return.'");
                ShowText(player, type, doMsgs, "'Forgive me.' So saying, Malik draws his stiletto and quickly carves a curious mark in your arm.");
                ShowText(player, type, doMsgs, "'Sartiq will trust you with the rest of the chant now. This mark will prove to him that you are an ally.'");
                ShowText(player, type, doMsgs, "'The agents of Aqueus would have attacked rather than bear such a scar. Farewell!'");
                DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 5);
                ShowText(player, type, doMsgs, "'Go, seek Sartiq again.'");
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.METJUBILAH, 1);
            }
            else {
                ShowText(player, type, doMsgs, "A strong thief stands here, as if waiting for a message.");
                ShowText(player, type, doMsgs, "'Come again to me once you've found my friend.'");
                ShowText(player, type, doMsgs, "'Away! Seek Sartiq to the north. Then, perchance, I will speak to you.'");
            }
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, TROLLKNIGHT);
            ShowText(player, type, doMsgs, "'There are many slippery traps and hidden doors here. If only I had a thief or a thief's toys.'");
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILLEDAQUEUS) == 0)) {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILLEDAQUEUS, 1);
            }
            ShowText(player, type, doMsgs, "The throne room is decorated with marvelous carvings of precious jewels. No doubt the late Aqueus stole them from the river.");
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILAM) == 0)) {
                ShowPortrait(player, type, doMsgs, ELFRANGER);
                ShowText(player, type, doMsgs, "'Good journeys to you. I wish you luck with these awful puzzles. What I know I shall share with you, for...say...these gold pieces?");
                ShowText(player, type, doMsgs, "Excellent! In the northwest corner, a door there is very stubborn. Merely approach and knock three times, and it will open!");
                ShowText(player, type, doMsgs, "Be on the lookout for a stern thief and an ancient giant. Together they will help you across the waters.'");
                ModifyGold(player, type, doMsgs,  - 1000);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILAM, 1);
            }
            else {
                ShowText(player, type, doMsgs, "Kilam has left this area.");
            }
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A magical pillar stands guard against curious intruders.");
            if (GetAttribute(player, type, doMsgs, STRENGTH) >= 16) {
                ShowText(player, type, doMsgs, "You manage to nudge the column enough to move forward.");
                WallClear(player, type, doMsgs);
                ClearTileBlock(player, type, doMsgs, 120);
                ClearTileBlock(player, type, doMsgs, 137);
                ClearTileBlock(player, type, doMsgs, 152);
                ClearTileBlock(player, type, doMsgs, 135);
            }
            else {
                ShowText(player, type, doMsgs, "You are unable to move the pillar's massive bulk.");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Violent swirls of water crash against the northeastern shore.");
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SAVEDPARTY) == 2) {
                ShowPortrait(player, type, doMsgs, DWARFKNIGHT);
                ShowText(player, type, doMsgs, "The party you thought you saw drown is here.");
                ShowText(player, type, doMsgs, "They are badly hurt and huddled over one of their friends who appears to be dead.");
                ShowText(player, type, doMsgs, "'YOU!! YOU!! You are responsible for Shalana's death because you didn't rescue us! I should slice you in half!'");
                ShowText(player, type, doMsgs, "'You must try to do something to bring her back.'");
                if (UsedItem(player, type, ref doMsgs, RESUSCITATOR, RESUSCITATOR) || UsedItem(player, type, ref doMsgs, LIFEGIVER, LIFEGIVER) || UsedItem(player, type, ref doMsgs, HEARTFLAIL, HEARTFLAIL) || (HasUsedSpell(player, type, ref doMsgs, RESUSCITATE_SPELL) >= 1)) {
                    ShowText(player, type, doMsgs, "Your skills and knowledge revive the half-drowned Shalana.");
                    ShowText(player, type, doMsgs, "The leader clasps your hand in thanks.");
                    ShowText(player, type, doMsgs, "'Ah, friend, forgive my angry words.'");
                    ShowText(player, type, doMsgs, "'Thank you for returning Shalana to me.'");
                    ShowText(player, type, doMsgs, "'Take these gifts with my gratitude. Hail`'");
                    ShowText(player, type, doMsgs, "You feel wiser and wealthier.");
                    GiveItem(player, type, doMsgs, CROSSBOW);
                    GiveItem(player, type, doMsgs, SILVERBAR);
                    RemoveItem(player, type, doMsgs, ROPE);
                    ModifyGold(player, type, doMsgs, 2000);
                    ModifyExperience(player, type, doMsgs, 2000);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SAVEDPARTY, 2);
                }
                else if (UsedItem(player, type, ref doMsgs, SHORTSWORD, MORNINGSTAR) || UsedItem(player, type, ref doMsgs, NUNCHUKAS, SCROLLOFDEATH) || UsedItem(player, type, ref doMsgs, AURASCROLL, BLESSPOTION) || UsedItem(player, type, ref doMsgs, HOPESFURY, UNITYRING)) {
                    ShowText(player, type, doMsgs, "Your efforts are valiant but futile!");
                    ShowText(player, type, doMsgs, "You fail to save the life of the girl.");
                    ShowText(player, type, doMsgs, "The party leader wheels on you!");
                    ShowText(player, type, doMsgs, "'NO! Damn you to Hades! Die now, you ignorant toad!!'");
                    ShowText(player, type, doMsgs, "Though exhausted from their ordeal, the weary party has the strength to pummel you ferociously.");
                    ShowText(player, type, doMsgs, "Abandoning you to the ghosts, they march off with their dead.");
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SAVEDPARTY, 3);
                    DamageBy2(player, type, doMsgs);
                }
            }
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            switch (GetGuild(player, type, doMsgs)) {
                case CLERIC:
                case WIZARD:
                    if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.STORM) == 0)) {
                        GiveSpell(player, type, doMsgs, STORM_WIND_SPELL, 1);
                        SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.STORM, 1);
                        CoolWater(player, type, doMsgs);
                    }
                    else {
                        Refresh(player, type, doMsgs);
                    }
                    break;
                default:
                    Refresh(player, type, doMsgs);
                    break;
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            switch (GetGuild(player, type, doMsgs)) {
                case CLERIC:
                case WIZARD:
                    if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.CURSED) == 0)) {
                        GiveSpell(player, type, doMsgs, CURSE_SPELL, 1);
                        SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.CURSED, 1);
                        CoolWater(player, type, doMsgs);
                    }
                    else {
                        Refresh(player, type, doMsgs);
                    }
                    break;
                default:
                    Refresh(player, type, doMsgs);
                    break;
            }
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            switch (GetGuild(player, type, doMsgs)) {
                case KNIGHT:
                case WIZARD:
                    if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.EFIELD) == 0)) {
                        GiveSpell(player, type, doMsgs, ENERGY_FIELD_SPELL, 1);
                        SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.EFIELD, 1);
                        CoolWater(player, type, doMsgs);
                    }
                    else {
                        Refresh(player, type, doMsgs);
                    }
                    break;
                default:
                    Refresh(player, type, doMsgs);
                    break;
            }
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            switch (GetGuild(player, type, doMsgs)) {
                case KNIGHT:
                    if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SEETHEKNIGHT) == 0)) {
                        GiveSpell(player, type, doMsgs, TRUE_SEEING_SPELL, 1);
                        SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SEETHEKNIGHT, 1);
                        ShowText(player, type, doMsgs, "The warm waters satisfy your thirst for knowledge with a new spell!");
                    }
                    else {
                        Refresh(player, type, doMsgs);
                    }
                    break;
                case CLERIC:
                    if ((GetSkill(player, type, doMsgs, CHANNEL_SKILL) == 0)) {
                        SetSkill(player, type, doMsgs, CHANNEL_SKILL, 1);
                        ShowText(player, type, doMsgs, "The warm waters satisfy your thirst for knowledge with a new skill!");
                    }
                    else {
                        Refresh(player, type, doMsgs);
                    }
                    break;
                default:
                    Refresh(player, type, doMsgs);
                    break;
            }
            FntnPic(player, type, doMsgs);
            switch (GetGuild(player, type, doMsgs)) {
                case KNIGHT:
                case CLERIC:
                    if ((GetSkill(player, type, doMsgs, CHANNEL_SKILL) == 0)) {
                        SetSkill(player, type, doMsgs, CHANNEL_SKILL, 1);
                        ShowText(player, type, doMsgs, "The warm waters satisfy your thirst for knowledge with a new skill!");
                    }
                    else {
                        Refresh(player, type, doMsgs);
                    }
                    break;
                default:
                    Refresh(player, type, doMsgs);
                    break;
            }
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            WallBlock(player, type, doMsgs);
            ShowText(player, type, doMsgs, "The fierce torrents bar your way. You must find an alternate way across.");
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (UsedItem(player, type, ref doMsgs, GREENLOCKPICK, BLUELOCKPICK) || (HasUsedSkill(player, type, ref doMsgs, LOCKPICK_SKILL) >= 1) || UsedItem(player, type, ref doMsgs, HELMOFGUILE, HELMOFGUILE)) {
                ShowText(player, type, doMsgs, "You've managed to unlock the gate.");
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
                ShowText(player, type, doMsgs, "One well skilled with lockpicks may be able to open this magnificent gate.");
            }
        }
        private void FntnPic(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
        }
        private void SprungTrap(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP, 1);
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void DamageBy2(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 4);
        }
        private void CoolWater(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The cool waters enlighten you with a new spell!");
        }
        private void Refresh(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ModifyHealth(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
            ModifyMana(player, type, doMsgs, 2000);
            ShowText(player, type, doMsgs, "The waters are refreshing!");
        }
        private void WallClear(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void PlaceDoor(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetFloorItem(player, type, doMsgs, WATER, 75);
            SetFloorItem(player, type, doMsgs, WATER, 91);
            SetFloorItem(player, type, doMsgs, WATER, 107);
            SetFloorItem(player, type, doMsgs, WATER, 124);
            SetFloorItem(player, type, doMsgs, WATER, 140);
            SetFloorItem(player, type, doMsgs, WATER, 141);
            SetFloorItem(player, type, doMsgs, WATER, 126);
            SetFloorItem(player, type, doMsgs, WATER, 127);
        }
    }
}
