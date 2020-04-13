using XPT.Games.Yserbius.Entities;
using XPT.Games.Generic.Maps;

namespace XPT.Games.Yserbius.Maps {
    class YserMap28 : YsMap {
        public override int MapIndex => 28;
        protected override int RandomEncounterChance => 11;
        protected override int RandomEncounterExtraCount => 1;

        public YserMap28() {
            MapEvent01 = FnALDBORA_01;
            MapEvent02 = FnENCA_02;
            MapEvent03 = FnENCB_03;
            MapEvent04 = FnENCC_04;
            MapEvent05 = FnENCD_05;
            MapEvent06 = FnENCE_06;
            MapEvent07 = FnENCF_07;
            MapEvent08 = FnENCG_08;
            MapEvent09 = FnENCH_09;
            MapEvent0A = FnENCI_0A;
            MapEvent0B = FnCGATE_0B;
            MapEvent0C = FnDWARF_0C;
            MapEvent0D = FnNOJOIN_0D;
            MapEvent0E = FnBEECHWD_0E;
            MapEvent0F = FnOAKLEAF_0F;
            MapEvent10 = FnMAPLEBRS_10;
            MapEvent11 = FnPINECONE_11;
            MapEvent12 = FnBWACTOR_12;
            MapEvent13 = FnOLACTOR_13;
            MapEvent14 = FnMBACTOR_14;
            MapEvent15 = FnPCACTOR_15;
            MapEvent16 = FnINFO_16;
            MapEvent17 = FnINFO_17;
            MapEvent18 = FnCAVEDOOR_18;
            MapEvent19 = FnELFHOME_19;
            MapEvent1A = FnELFHOME_1A;
            MapEvent1B = FnINFO_1B;
        }


        // Map 28 - The Season's Quest
        // The player enters the map with the Harvest Horn
        // The player then travels to the four corners of the map, visiting the druids of each season, giving them an item and gaining one in return.
        // After the fourth season, the player takes the final season item back to the AldBora tree, which bears the fruits of Wisdom.
        // MapFlag 0x01 tracks the progress of the player. When the player enters the room MapFlag is set to 0x00.
        // MF   Season  Event   Room    Item    Reward              e12     e13     e14     e15
        // 00   Summer  13      LL      HH      Seeds               Spr     Sum     Win     Aut
        // 01   Winter  15      UR      Seeds   Spring Renewal      Sum     Spr     Aut     Win
        // 02   Autumn  12      UL      Renewal Winter Waters       Aut     Win     Sum     Spr
        // 03   Spring  14      LR      Waters  Summer Radiance     Win     Aut     Spr     Sum
        // 04   Tree    01      Center  SR      Skills

        // === Functions ================================================
        private void FnALDBORA_01(YsPlayerServer player, MapEventType type, bool doMsgs) {
            switch (GetFlag(player, FlagTypeMap, 0x01)) {
                case 0:
                    ShowMessage(player, doMsgs, "The Aldbora Tree proudly displays its summer foliage.");
                    if (HasItem(player, YsIndexes.ItemHarvestHorn) == 1) {
                        ShowMessage(player, doMsgs, "A whisper in the room: 'The procession of seasons may begin.'");
                    }
                    return;
                case 1:
                    ShowMessage(player, doMsgs, "In the Winter, the Aldbora Tree shows its age.");
                    return;
                case 2:
                    ShowMessage(player, doMsgs, "Golden Autumn leaves fall from the Aldbora Tree.");
                    return;
                case 3:
                    ShowMessage(player, doMsgs, "Spring flowers and new leaves appear on the magical Aldbora Tree.");
                    return;
                case 4:
                    if (HasUsedItem(player, type, ref doMsgs, YsIndexes.ItemSummerRadiance, YsIndexes.ItemSummerRadiance) == 0) {
                        ShowMessage(player, doMsgs, "The fruits of Knowledge are now ripe, and wait for the Radiance of Summer.");
                        return;
                    }
                    else {
                        if (HasItem(player, YsIndexes.ItemNaturesRobe) == 0) {
                            ShowMessage(player, doMsgs, "The fruits of Knowledge are useless without the vestments of Nature.");
                            return;
                        }
                        ShowMessage(player, doMsgs, "The AldBora Tree bears fruit...");
                        SetFlag(player, FlagTypeDungeon, YsIndexes.FlagTreeSkills, 0x01);
                        RemoveItem(player, YsIndexes.ItemSummerRadiance);
                        RemoveItem(player, YsIndexes.ItemNaturesRobe);
                        // barb:
                        if (GetSkillLevel(player, 0x00) == 0) {
                            SetSkillLevel(player, 0x00, 0x02);
                            ShowMessage(player, doMsgs, "the knowledge of Athletics!");
                        }
                        if (GetSkillLevel(player, 0x01) == 0) {
                            SetSkillLevel(player, 0x01, 0x02);
                            ShowMessage(player, doMsgs, "the knowledge of Clubs and Axes!");
                        }
                        if (GetSkillLevel(player, 0x02) == 0) {
                            SetSkillLevel(player, 0x02, 0x02);
                            ShowMessage(player, doMsgs, "the knowledge of Berserker!");
                        }
                        if (GetSkillLevel(player, 0x03) == 0) {
                            SetSkillLevel(player, 0x03, 0x02);
                            ShowMessage(player, doMsgs, "the knowledge of Pursuit!");
                        }
                        // knight:
                        if (GetSkillLevel(player, 0x04) == 0) {
                            SetSkillLevel(player, 0x04, 0x02);
                            ShowMessage(player, doMsgs, "the knowledge of Leadership!");
                        }
                        if (GetSkillLevel(player, 0x05) == 0) {
                            SetSkillLevel(player, 0x05, 0x02);
                            ShowMessage(player, doMsgs, "the knowledge of Fencing!");
                        }
                        if (GetSkillLevel(player, 0x06) == 0) {
                            SetSkillLevel(player, 0x06, 0x02);
                            ShowMessage(player, doMsgs, "the knowledge of Binding!");
                        }
                        if (GetSkillLevel(player, 0x07) == 0) {
                            SetSkillLevel(player, 0x07, 0x02);
                            ShowMessage(player, doMsgs, "the knowledge of Intimidation!");
                        }
                        // ranger:
                        if (GetSkillLevel(player, 0x08) == 0) {
                            SetSkillLevel(player, 0x08, 0x02);
                            ShowMessage(player, doMsgs, "the knowledge of Archery!");
                        }
                        if (GetSkillLevel(player, 0x09) == 0) {
                            SetSkillLevel(player, 0x09, 0x02);
                            ShowMessage(player, doMsgs, "the knowledge of Stamina!");
                        }
                        if (GetSkillLevel(player, 0x0A) == 0) {
                            SetSkillLevel(player, 0x0A, 0x02);
                            ShowMessage(player, doMsgs, "the knowledge of Furtiveness!");
                        }
                        if (GetSkillLevel(player, 0x0B) == 0) {
                            SetSkillLevel(player, 0x0B, 0x02);
                            ShowMessage(player, doMsgs, "the knowledge of Reading Tracks!");
                        }
                        // cleric:
                        if (GetSkillLevel(player, 0x10) == 0) {
                            SetSkillLevel(player, 0x10, 0x02);
                            ShowMessage(player, doMsgs, "the knowledge of Martial Arts!");
                        }
                        if (GetSkillLevel(player, 0x11) == 0) {
                            SetSkillLevel(player, 0x11, 0x02);
                            ShowMessage(player, doMsgs, "the knowledge of Deflect Magic!");
                        }
                        if (GetSkillLevel(player, 0x12) == 0) {
                            SetSkillLevel(player, 0x12, 0x02);
                            ShowMessage(player, doMsgs, "the knowledge of Medic!");
                        }
                        if (GetSkillLevel(player, 0x13) == 0) {
                            SetSkillLevel(player, 0x13, 0x02);
                            ShowMessage(player, doMsgs, "the knowledge of Reverie!");
                        }
                        // wizard:
                        if (GetSkillLevel(player, 0x14) == 0) {
                            SetSkillLevel(player, 0x14, 0x02);
                            ShowMessage(player, doMsgs, "the knowledge of Rune Reading!");
                        }
                        if (GetSkillLevel(player, 0x15) == 0) {
                            SetSkillLevel(player, 0x15, 0x02);
                            ShowMessage(player, doMsgs, "the knowledge of Staff!");
                        }
                        if (GetSkillLevel(player, 0x16) == 0) {
                            SetSkillLevel(player, 0x16, 0x02);
                            ShowMessage(player, doMsgs, "the knowledge of Channeling!");
                        }
                        if (GetSkillLevel(player, 0x17) == 0) {
                            SetSkillLevel(player, 0x17, 0x02);
                            ShowMessage(player, doMsgs, "the knowledge of Deep Trance!");
                        }
                        ShowMessage(player, doMsgs, "The leaves whisper, 'Defeat my enemies the four winds, South, North, East and West, and you will find a precious gem as green as my foliage.'");
                    }
                    return;
            }
        }

        private void FnENCA_02(YsPlayerServer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, "Dwarven Knights attempt an ambush.");
            AddEncounter(player, 0x01, 0x20);
            AddEncounter(player, 0x02, 0x20);
            AddEncounter(player, 0x05, 0x22);
            AddEncounter(player, 0x06, 0x22);
        }

        private void FnENCB_03(YsPlayerServer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, 0x01, 0x1F);
            AddEncounter(player, 0x02, 0x1E);
            AddEncounter(player, 0x03, 0x1D);
            AddEncounter(player, 0x04, 0x1B);
            AddEncounter(player, 0x05, 0x23);
            AddEncounter(player, 0x06, 0x23);
        }

        private void FnENCC_04(YsPlayerServer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, 0x01, 0x1F);
            AddEncounter(player, 0x02, 0x1F);
            AddEncounter(player, 0x03, 0x24);
            AddEncounter(player, 0x04, 0x19);
        }

        private void FnENCD_05(YsPlayerServer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, 0x01, 0x18);
            AddEncounter(player, 0x02, 0x1A);
            AddEncounter(player, 0x03, 0x26);
            AddEncounter(player, 0x04, 0x26);
            AddEncounter(player, 0x05, 0x22);
            AddEncounter(player, 0x06, 0x22);
        }

        private void FnENCE_06(YsPlayerServer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, 0x01, 0x14);
            AddEncounter(player, 0x02, 0x16);
            AddEncounter(player, 0x03, 0x26);
            AddEncounter(player, 0x04, 0x27);
        }

        private void FnENCF_07(YsPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, YsIndexes.ItemCleowynsBones) == 1) {
                AddTreasure(player, 0x012C, 0x00, 0x00, 0x00, 0x00, 0xCE);
            }
            else {
                AddTreasure(player, 0x012C, 0x00, 0x00, 0x00, 0xD0, YsIndexes.ItemCleowynsBones);
            }
            ShowMessage(player, doMsgs, "You see scattered bones and a bag under a Dragon.");
            AddEncounter(player, 0x01, 0x1B);
            AddEncounter(player, 0x02, 0x1B);
            AddEncounter(player, 0x03, 0x19);
            AddEncounter(player, 0x04, 0x19);
        }

        private void FnENCG_08(YsPlayerServer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, 0x01, 0x1A);
            AddEncounter(player, 0x02, 0x1A);
            AddEncounter(player, 0x03, 0x1B);
            AddEncounter(player, 0x04, 0x1B);
        }

        private void FnENCH_09(YsPlayerServer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, 0x01, 0x21);
            AddEncounter(player, 0x02, 0x22);
            AddEncounter(player, 0x05, 0x26);
            AddEncounter(player, 0x06, 0x28);
        }

        private void FnENCI_0A(YsPlayerServer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, 0x01, 0x1C);
            AddEncounter(player, 0x02, 0x1C);
            AddEncounter(player, 0x03, 0x22);
            AddEncounter(player, 0x04, 0x22);
            if (HasItem(player, YsIndexes.ItemRanbowGemYellow) == 1) {
                AddTreasure(player, 0x03E8, 0x00, 0x00, 0x00, 0xCF, 0xC6);
            }
            else {
                ShowMessage(player, doMsgs, "A glowing yellow gem lights the area.");
                AddTreasure(player, 0x2710, 0x00, 0x00, 0xD0, 0xD0, YsIndexes.ItemRanbowGemYellow);
                SetFlag(player, FlagTypeDungeon, YsIndexes.FlagMedievaLandsSeenYellowGem, 1);
            }
        }

        private void FnCGATE_0B(YsPlayerServer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, "A path leads up to CASTLEGATE.");
            TeleportParty(player, 0x36, 0x01, 0x74, 0x01, type);
        }

        private void FnDWARF_0C(YsPlayerServer player, MapEventType type, bool doMsgs) {
            if (CheckLevel(player, 0x001E) == 1) {
                ShowMessage(player, doMsgs, "A narrow tunnel appears, leading down to the DWARF KINGDOM.");
                SetWallItem(player, 0x00, GetCurrentTile(player), 0x03);
                TeleportParty(player, 0x38, 0x01, 0x7A, 0x02, type);
            }
            else {
                ShowMessage(player, doMsgs, "Runes are carved into the rockface:");
                ShowRunes(player, doMsgs, "At level thirty, the entrance to the land of dwarfs will be open to you.");
            }
        }

        private void FnNOJOIN_0D(YsPlayerServer player, MapEventType type, bool doMsgs) {
            SetNoJoinArea(player);
        }

        private void FnBEECHWD_0E(YsPlayerServer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, "Upon a wood sign is written 'Wilderness of BeechWood.'");
        }

        private void FnOAKLEAF_0F(YsPlayerServer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, " A wreath of leaves encircles the words 'Wilderness of OakLeaf.'");
        }

        private void FnMAPLEBRS_10(YsPlayerServer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, "A sign of ancient wood reads 'Wilderness of MapleBrush.'");
        }

        private void FnPINECONE_11(YsPlayerServer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, "In the dust of pine needles is written 'Wilderness of PineCone.'");
        }

        // === Event 12: The Wise Ones of Beechwood. At Stage 2, Autumn accepts Spring's Renewal here. ===============
        // ===========================================================================================================

        private void FnBWACTOR_12(YsPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, 0x0027);
            if (GetFlag(player, FlagTypeMap, 0x01) >= 4) {
                ShowMessage(player, doMsgs, "The Wise Ones of Beechwood discuss the change in seasons.");
            }
            else if (HasUsedItem(player, type, ref doMsgs, 0x00, 0xff) == 0) {
                FnBWACTOR_12_Introduction(player);
            }
            else {
                FnBWACTOR_12_UseItem(player, type, doMsgs);
            }
        }

        private void FnBWACTOR_12_Introduction(YsPlayerServer player) {
            ShowMessage(player, true, "We are the Wise Ones of Beechwood who serve the Seasons.");
            switch (GetFlag(player, FlagTypeMap, 0x01)) {
                case 0: // spring here
                    ShowMessage(player, true, "I am Lobard, and the Season I serve is gentle Spring.");
                    ShowMessage(player, true, "The soft breezes of Spring warned me of your coming.");
                    ShowMessage(player, true, "Wise are they who know how to please my master.");
                    break;
                case 1: // summer here
                    ShowMessage(player, true, "My name is Shushian, servant to vibrant Summer.");
                    ShowMessage(player, true, "The Summer gently warms those who serve it and parches those who anger it.");
                    ShowMessage(player, true, "Why have you come to me in these sultry days of Summer?");
                    break;
                case 2: // autumn here, active event.
                    ShowMessage(player, true, "Distly Bombak, the vassal of Autumn, greets you.");
                    ShowMessage(player, true, "Lovely Autumn in its varicolored foliage urges you to gather in your harvest before harsh Winter comes.");
                    ShowMessage(player, true, "Autumn begins to fade, and so asks why you have come.");
                    break;
                case 3: // winter here
                    ShowMessage(player, true, "You may call me Karakiar, since that is my name. My liege is Winter.");
                    ShowMessage(player, true, "The bracing sting of Winter's winds refresh those who love its white wonderland.");
                    ShowMessage(player, true, "Winter would know why you are here.");
                    break;
            }
        }

        private void FnBWACTOR_12_UseItem(YsPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, FlagTypeMap, 0x01) == 2 && HasUsedItem(player, type, ref doMsgs, YsIndexes.ItemSpringRenewal, YsIndexes.ItemSpringRenewal) == 1) {
                RemoveItem(player, YsIndexes.ItemSpringRenewal);
                if (HasItem(player, YsIndexes.ItemWinterWaters) == 0) {
                    GiveItem(player, YsIndexes.ItemWinterWaters);
                }
                SetFlag(player, FlagTypeMap, 0x01, 0x03);
                ShowMessage(player, true, "Autumn gladly accepts the Spring Renewal.");
                ShowMessage(player, true, "Lo! Golden Autumn pales to white Winter and now sleeps under snowy blankets.");
                ShowMessage(player, true, "These icy Winter Waters are a present to you.");
            }
            else {
                ShowMessage(player, true, "A Wise One scoffs. 'You dishonour the Seasons with this false gift.'");
            }
        }

        // === Event 13: Clerics of Oakleaf. At Stage 0, Summer accepts the Harvest Horn here. =======================
        // ===========================================================================================================

        private void FnOLACTOR_13(YsPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, 0x0027);
            if (GetFlag(player, FlagTypeMap, 0x01) >= 4) {
                ShowMessage(player, doMsgs, "The Clerics softly sooth the seasons.");
            }
            else if (HasUsedItem(player, type, ref doMsgs, 0x00, 0xff) == 0) {
                FnOLACTOR_13_Introduction(player);
            }
            else {
                FnOLACTOR_13_UseItem(player, type, doMsgs);
            }
        }

        private void FnOLACTOR_13_Introduction(YsPlayerServer player) {
            ShowMessage(player, true, "We are the Clerics of Oakleaf who comfort the Seasons.");
            switch (GetFlag(player, FlagTypeMap, 0x01)) {
                case 0: // summer here, active event
                    ShowMessage(player, true, "I am Shashamia, friend to the temperate Summer.");
                    ShowMessage(player, true, "Sullen summer is nervous around mortals.");
                    ShowMessage(player, true, "Do you have some business with Summer?");
                    break;
                case 1: // spring here
                    ShowMessage(player, true, "Call me Donbard. I ease the distress of gentle Spring.");
                    ShowMessage(player, true, "Spring quakes in fear at your coming.");
                    ShowMessage(player, true, "Why have you come to Spring's home?");
                    break;
                case 2: // winter here
                    ShowMessage(player, true, "I am called Kalakial, and I help poor Winter.");
                    ShowMessage(player, true, "Wistful Winter is too shy to speak to you directly.");
                    ShowMessage(player, true, "Winter wishes you to leave, so do quickly what you came to do.");
                    break;
                case 3: // autumn here
                    ShowMessage(player, true, "Dindly Bindiak is my name. Autumn is my friend.");
                    ShowMessage(player, true, "Russet-clad Autumn welcomes you if you are true friends of the Seasons.");
                    ShowMessage(player, true, "Autumn will fade away unless you tell me why you have come.");
                    break;
            }
        }

        private void FnOLACTOR_13_UseItem(YsPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, FlagTypeMap, 0x01) == 0 && HasUsedItem(player, type, ref doMsgs, YsIndexes.ItemHarvestHorn, YsIndexes.ItemHarvestHorn) == 1) {
                RemoveItem(player, YsIndexes.ItemHarvestHorn);
                if (HasItem(player, YsIndexes.ItemAutumnSeeds) == 0) {
                    GiveItem(player, YsIndexes.ItemAutumnSeeds);
                }
                SetFlag(player, FlagTypeMap, 0x01, 0x01);
                ShowMessage(player, true, "Summer accepts the Harvest Horn.");
                ShowMessage(player, true, "Summer mellows by the sweet music and is now Autumn!");
                ShowMessage(player, true, "Autumn Seeds are now yours to enjoy.");
            }
            else {
                ShowMessage(player, true, "A Cleric chides you. 'The Seasons shy away from your pitiful gift.'");
            }
        }

        // === Event 14: Wardens of Maplebrush. At Stage 3, Spring accepts the Winter Waters here. ===================
        // ===========================================================================================================

        private void FnMBACTOR_14(YsPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, 0x0027);
            if (GetFlag(player, FlagTypeMap, 0x01) >= 4) {
                ShowMessage(player, doMsgs, "The Wardens speak untold secrets.");
            }
            else if (HasUsedItem(player, type, ref doMsgs, 0x00, 0xff) == 0) {
                FnMBACTOR_14_Introduction(player);
            }
            else {
                FnMBACTOR_14_UseItem(player, type, doMsgs);
            }
        }

        private void FnMBACTOR_14_Introduction(YsPlayerServer player) {
            ShowMessage(player, true, "We are the Wardens of Maplebrush and hold the Seasons.");
            switch (GetFlag(player, FlagTypeMap, 0x01)) {
                case 0: // winter here
                    ShowMessage(player, true, "Not even I know my true name.");
                    ShowMessage(player, true, "It is Winter. I may say no more.");
                    break;
                case 1: // autumn here
                    ShowMessage(player, true, "Never mind what my name is.");
                    ShowMessage(player, true, "It is Autumn. That is enough for now.");
                    break;
                case 2: // summer here
                    ShowMessage(player, true, "My name is my secret.");
                    ShowMessage(player, true, "It is Summer. That is all I will say.");
                    break;
                case 3: // spring here, active event
                    ShowMessage(player, true, "You may not know my name.");
                    ShowMessage(player, true, "It is Spring. That is all you need know.");
                    break;
            }
        }

        private void FnMBACTOR_14_UseItem(YsPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, FlagTypeMap, 0x01) == 3 && HasUsedItem(player, type, ref doMsgs, YsIndexes.ItemWinterWaters, YsIndexes.ItemWinterWaters) == 1) {
                RemoveItem(player, YsIndexes.ItemWinterWaters);
                if (HasItem(player, YsIndexes.ItemSummerRadiance) == 0) {
                    GiveItem(player, YsIndexes.ItemSummerRadiance);
                }
                SetFlag(player, FlagTypeMap, 0x01, 0x04);
                ShowMessage(player, true, "From Winter Waters comes the change of Spring to Summer.");
                ShowMessage(player, true, "You have been rewarded.");
            }
            else {
                ShowMessage(player, true, "The Warden grows angry. 'Wrong, wrong, wrong, mortal!'");
            }
        }

        // === Event 15: Seasons incarnate. At Stage 1, Winter accepts the Autumn Springs here. ======================
        // ===========================================================================================================

        private void FnPCACTOR_15(YsPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, 0x0027);
            if (GetFlag(player, FlagTypeMap, 0x01) >= 4) {
                ShowMessage(player, doMsgs, "The Seasons have no further use for you.");
            }
            else if (HasUsedItem(player, type, ref doMsgs, 0x00, 0xff) == 0) {
                FnPCACTOR_15_Introduction(player);
            }
            else {
                FnPCACTOR_15_UseItem(player, type, doMsgs);
            }

        }
        private void FnPCACTOR_15_Introduction(YsPlayerServer player) {
            ShowMessage(player, true, "We are the Seasons incarnate in mortal form.");
            switch (GetFlag(player, FlagTypeMap, 0x01)) {
                case 0: // autumn here
                    ShowMessage(player, true, "I am Autumn.");
                    break;
                case 1: // winter here, active event
                    ShowMessage(player, true, "I am Winter.");
                    break;
                case 2: // spring here
                    ShowMessage(player, true, "I am Spring.");
                    break;
                case 3: // summer here
                    ShowMessage(player, true, "I am Summer.");
                    break;
            }
        }

        private void FnPCACTOR_15_UseItem(YsPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, FlagTypeMap, 0x01) == 1 && HasUsedItem(player, type, ref doMsgs, YsIndexes.ItemAutumnSeeds, YsIndexes.ItemAutumnSeeds) == 1) {
                RemoveItem(player, YsIndexes.ItemAutumnSeeds);
                if (HasItem(player, YsIndexes.ItemSpringRenewal) == 0) {
                    GiveItem(player, YsIndexes.ItemSpringRenewal);
                }
                SetFlag(player, FlagTypeMap, 0x01, 0x02);
                ShowMessage(player, true, "The Autumn Seeds awaken me from my long hibernation.");
                ShowMessage(player, true, "I am Spring again!");
                ShowMessage(player, true, "Take the Renewal of Spring and rejoice with me!");
            }
            else {
                ShowMessage(player, true, "The Season incarnate looks puzzled. 'I cannot accept this gift.'");
            }
        }

        // === Remaining events - clues ==============================================================================
        // ===========================================================================================================

        private void FnINFO_16(YsPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, 0x001F);
            ShowMessage(player, doMsgs, "'Welcome, Adventurer.  I am Varstad, counselor to the Elf King.");
            ShowMessage(player, doMsgs, "The magic Aldbora requires Summer Radiance to shed its knowledge fruit.'");
        }

        private void FnINFO_17(YsPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, 0x0027);
            ShowMessage(player, doMsgs, "The storyteller Sorshian honors your arrival.");
            ShowMessage(player, doMsgs, "'Only when the Seasons have processed will the Aldora shed the fruits of Wisdom.'");
        }

        private void FnCAVEDOOR_18(YsPlayerServer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, "A wooden sign says, 'To the cave of NeedleWood.'");
            if (HasUsedItem(player, type, ref doMsgs, YsIndexes.ItemElfinCaveKey, YsIndexes.ItemElfinCaveKey) == 1) {
                ShowMessage(player, doMsgs, "The door unlocks.");
                SetWallPassable(player, GetCurrentTile(player), 0x03, 0x01);
                SetWallItem(player, 0x01, GetCurrentTile(player), 0x03);
            }
        }

        private void FnELFHOME_19(YsPlayerServer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, "Young elves scurry and hide when you enter this elf home.");
        }

        private void FnELFHOME_1A(YsPlayerServer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, "Carvings of elfin rangers crossing glacial landscapes proudly mount the walls of a typical elfin dwelling.");
        }

        private void FnINFO_1B(YsPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, 0x001F);
            ShowMessage(player, doMsgs, "'I am Fernank, Hunter to the Elf King.");
            ShowMessage(player, doMsgs, "It is known in the trees that Nature's Robe must be used for the harvest.'");
        }
    }
}
