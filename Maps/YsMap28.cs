using System.Collections.Generic;
using XPT.Legacy;
using XPT.Legacy.Entities;

namespace XPT.Legacy.Maps {
    class YserMap28 : AMapScripted {
        protected override int MapIndex => 28;
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

        private const int ItemAutumnSeeds = 0xE4;
        private const int ItemWinterWaters = 0xE5;
        private const int ItemHarvestHorn = 0xE6;
        private const int ItemSpringRenewal = 0xE7;
        private const int ItemSummerRadiance = 0xE8;
        private const int ItemNaturesRobe = 0xE9;

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
        private void FnALDBORA_01(ServerPlayer player, bool isForwardMove) {
            switch (GetFlag(player, FlagTypeMap, 0x01)) {
                case 0:
                    ShowMessage(player, "The Aldbora Tree proudly displays its summer foliage.");
                    if (HasItem(player, ItemHarvestHorn) == 1) {
                        ShowMessage(player, "A whisper in the room: 'The procession of seasons may begin.'");
                    }
                    return;
                case 1:
                    ShowMessage(player, "In the Winter, the Aldbora Tree shows its age.");
                    return;
                case 2:
                    ShowMessage(player, "Golden Autumn leaves fall from the Aldbora Tree.");
                    return;
                case 3:
                    ShowMessage(player, "Spring flowers and new leaves appear on the magical Aldbora Tree.");
                    return;
                case 4:
                    if (HasUsedItem(player, ItemSummerRadiance, ItemSummerRadiance) == 0) {
                        ShowMessage(player, "The fruits of Knowledge are now ripe, and wait for the Radiance of Summer.");
                        return;
                    }
                    else {
                        if (HasItem(player, ItemNaturesRobe) == 0) {
                            ShowMessage(player, "The fruits of Knowledge are useless without the vestments of Nature.");
                            return;
                        }
                        ShowMessage(player, "The AldBora Tree bears fruit...");
                        RemoveItem(player, ItemSummerRadiance);
                        RemoveItem(player, ItemNaturesRobe);
                        // barb:
                        if (GetSkillLevel(player, 0x00) == 0) {
                            SetSkillLevel(player, 0x00, 0x02);
                            ShowMessage(player, "the knowledge of Athletics!");
                        }
                        if (GetSkillLevel(player, 0x01) == 0) {
                            SetSkillLevel(player, 0x01, 0x02);
                            ShowMessage(player, "the knowledge of Clubs and Axes!");
                        }
                        if (GetSkillLevel(player, 0x02) == 0) {
                            SetSkillLevel(player, 0x02, 0x02);
                            ShowMessage(player, "the knowledge of Berserker!");
                        }
                        if (GetSkillLevel(player, 0x03) == 0) {
                            SetSkillLevel(player, 0x03, 0x02);
                            ShowMessage(player, "the knowledge of Pursuit!");
                        }
                        // knight:
                        if (GetSkillLevel(player, 0x04) == 0) {
                            SetSkillLevel(player, 0x04, 0x02);
                            ShowMessage(player, "the knowledge of Leadership!");
                        }
                        if (GetSkillLevel(player, 0x05) == 0) {
                            SetSkillLevel(player, 0x05, 0x02);
                            ShowMessage(player, "the knowledge of Fencing!");
                        }
                        if (GetSkillLevel(player, 0x06) == 0) {
                            SetSkillLevel(player, 0x06, 0x02);
                            ShowMessage(player, "the knowledge of Binding!");
                        }
                        if (GetSkillLevel(player, 0x07) == 0) {
                            SetSkillLevel(player, 0x07, 0x02);
                            ShowMessage(player, "the knowledge of Intimidation!");
                        }
                        // ranger:
                        if (GetSkillLevel(player, 0x08) == 0) {
                            SetSkillLevel(player, 0x08, 0x02);
                            ShowMessage(player, "the knowledge of Archery!");
                        }
                        if (GetSkillLevel(player, 0x09) == 0) {
                            SetSkillLevel(player, 0x09, 0x02);
                            ShowMessage(player, "the knowledge of Stamina!");
                        }
                        if (GetSkillLevel(player, 0x0A) == 0) {
                            SetSkillLevel(player, 0x0A, 0x02);
                            ShowMessage(player, "the knowledge of Furtiveness!");
                        }
                        if (GetSkillLevel(player, 0x0B) == 0) {
                            SetSkillLevel(player, 0x0B, 0x02);
                            ShowMessage(player, "the knowledge of Reading Tracks!");
                        }
                        // cleric:
                        if (GetSkillLevel(player, 0x10) == 0) {
                            SetSkillLevel(player, 0x10, 0x02);
                            ShowMessage(player, "the knowledge of Martial Arts!");
                        }
                        if (GetSkillLevel(player, 0x11) == 0) {
                            SetSkillLevel(player, 0x11, 0x02);
                            ShowMessage(player, "the knowledge of Deflect Magic!");
                        }
                        if (GetSkillLevel(player, 0x12) == 0) {
                            SetSkillLevel(player, 0x12, 0x02);
                            ShowMessage(player, "the knowledge of Medic!");
                        }
                        if (GetSkillLevel(player, 0x13) == 0) {
                            SetSkillLevel(player, 0x13, 0x02);
                            ShowMessage(player, "the knowledge of Reverie!");
                        }
                        // wizard:
                        if (GetSkillLevel(player, 0x14) == 0) {
                            SetSkillLevel(player, 0x14, 0x02);
                            ShowMessage(player, "the knowledge of Rune Reading!");
                        }
                        if (GetSkillLevel(player, 0x15) == 0) {
                            SetSkillLevel(player, 0x15, 0x02);
                            ShowMessage(player, "the knowledge of Staff!");
                        }
                        if (GetSkillLevel(player, 0x16) == 0) {
                            SetSkillLevel(player, 0x16, 0x02);
                            ShowMessage(player, "the knowledge of Channeling!");
                        }
                        if (GetSkillLevel(player, 0x17) == 0) {
                            SetSkillLevel(player, 0x17, 0x02);
                            ShowMessage(player, "the knowledge of Deep Trance!");
                        }
                        ShowMessage(player, "The leaves whisper, 'Defeat my enemies the four winds, South, North, East and West, and you will find a precious gem as green as my foliage.'");
                    }
                    return;
            }
        }

        private void FnENCA_02(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, "Dwarven Knights attempt an ambush.");
            AddEncounter(player, 0x01, 0x20);
            AddEncounter(player, 0x02, 0x20);
            AddEncounter(player, 0x05, 0x22);
            AddEncounter(player, 0x06, 0x22);
        }

        private void FnENCB_03(ServerPlayer player, bool isForwardMove) {
            AddEncounter(player, 0x01, 0x1F);
            AddEncounter(player, 0x02, 0x1E);
            AddEncounter(player, 0x03, 0x1D);
            AddEncounter(player, 0x04, 0x1B);
            AddEncounter(player, 0x05, 0x23);
            AddEncounter(player, 0x06, 0x23);
        }

        private void FnENCC_04(ServerPlayer player, bool isForwardMove) {
            AddEncounter(player, 0x01, 0x1F);
            AddEncounter(player, 0x02, 0x1F);
            AddEncounter(player, 0x03, 0x24);
            AddEncounter(player, 0x04, 0x19);
        }

        private void FnENCD_05(ServerPlayer player, bool isForwardMove) {
            AddEncounter(player, 0x01, 0x18);
            AddEncounter(player, 0x02, 0x1A);
            AddEncounter(player, 0x03, 0x26);
            AddEncounter(player, 0x04, 0x26);
            AddEncounter(player, 0x05, 0x22);
            AddEncounter(player, 0x06, 0x22);
        }

        private void FnENCE_06(ServerPlayer player, bool isForwardMove) {
            AddEncounter(player, 0x01, 0x14);
            AddEncounter(player, 0x02, 0x16);
            AddEncounter(player, 0x03, 0x26);
            AddEncounter(player, 0x04, 0x27);
        }

        private void FnENCF_07(ServerPlayer player, bool isForwardMove) {
            if (HasItem(player, 0xFA) == 1) {
                AddTreasure(player, 0x012C, 0x00, 0x00, 0x00, 0x00, 0xCE);
            }
            else {
                AddTreasure(player, 0x012C, 0x00, 0x00, 0x00, 0xD0, 0xFA);
            }
            ShowMessage(player, "You see scattered bones and a bag under a Dragon.");
            AddEncounter(player, 0x01, 0x1B);
            AddEncounter(player, 0x02, 0x1B);
            AddEncounter(player, 0x03, 0x19);
            AddEncounter(player, 0x04, 0x19);
        }

        private void FnENCG_08(ServerPlayer player, bool isForwardMove) {
            AddEncounter(player, 0x01, 0x1A);
            AddEncounter(player, 0x02, 0x1A);
            AddEncounter(player, 0x03, 0x1B);
            AddEncounter(player, 0x04, 0x1B);
        }

        private void FnENCH_09(ServerPlayer player, bool isForwardMove) {
            AddEncounter(player, 0x01, 0x21);
            AddEncounter(player, 0x02, 0x22);
            AddEncounter(player, 0x05, 0x26);
            AddEncounter(player, 0x06, 0x28);
        }

        private void FnENCI_0A(ServerPlayer player, bool isForwardMove) {
            AddEncounter(player, 0x01, 0x1C);
            AddEncounter(player, 0x02, 0x1C);
            AddEncounter(player, 0x03, 0x22);
            AddEncounter(player, 0x04, 0x22);
            if (HasItem(player, 0xF5) == 1) {
                AddTreasure(player, 0x03E8, 0x00, 0x00, 0x00, 0xCF, 0xC6);
            }
            else {
                ShowMessage(player, "A glowing yellow gem lights the area.");
                AddTreasure(player, 0x2710, 0x00, 0x00, 0xD0, 0xD0, 0xF5);
            }
        }

        private void FnCGATE_0B(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, "A path leads up to CASTLEGATE.");
            TeleportParty(player, 0x36, 0x01, 0x74, 0x01, isForwardMove);
        }

        private void FnDWARF_0C(ServerPlayer player, bool isForwardMove) {
            if (CheckLevel(player, 0x001E) == 1) {
                ShowMessage(player, "A narrow tunnel appears, leading down to the DWARF KINGDOM.");
                TeleportParty(player, 0x38, 0x01, 0x7A, 0x02, isForwardMove);
            }
            else {
                ShowMessage(player, "Runes are carved into the rockface:");
                ShowRunes(player, "At level thirty, the entrance to the land of dwarfs will be open to you.");
            }
        }

        private void FnNOJOIN_0D(ServerPlayer player, bool isForwardMove) {
            SetNoJoinArea(player);
        }

        private void FnBEECHWD_0E(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, "Upon a wood sign is written 'Wilderness of BeechWood.'");
        }

        private void FnOAKLEAF_0F(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, " A wreath of leaves encircles the words 'Wilderness of OakLeaf.'");
        }

        private void FnMAPLEBRS_10(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, "A sign of ancient wood reads 'Wilderness of MapleBrush.'");
        }

        private void FnPINECONE_11(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, "In the dust of pine needles is written 'Wilderness of PineCone.'");
        }

        // === Event 12: The Wise Ones of Beechwood. At Stage 2, Autumn accepts Spring's Renewal here. ===============
        // ===========================================================================================================

        private void FnBWACTOR_12(ServerPlayer player, bool isForwardMove) {
            ShowPortrait(player, 0x0027);
            if (GetFlag(player, FlagTypeMap, 0x01) >= 4) {
                ShowMessage(player, "The Wise Ones of Beechwood discuss the change in seasons.");
            }
            else if (HasUsedItem(player, 0x00, 0xff) == 0) {
                FnBWACTOR_12_Introduction(player);
            }
            else {
                FnBWACTOR_12_UseItem(player);
            }
        }

        private void FnBWACTOR_12_Introduction(ServerPlayer player) {
            ShowMessage(player, "We are the Wise Ones of Beechwood who serve the Seasons.");
            switch (GetFlag(player, FlagTypeMap, 0x01)) {
                case 0: // spring here
                    ShowMessage(player, "I am Lobard, and the Season I serve is gentle Spring.");
                    ShowMessage(player, "The soft breezes of Spring warned me of your coming.");
                    ShowMessage(player, "Wise are they who know how to please my master.");
                    break;
                case 1: // summer here
                    ShowMessage(player, "My name is Shushian, servant to vibrant Summer.");
                    ShowMessage(player, "The Summer gently warms those who serve it and parches those who anger it.");
                    ShowMessage(player, "Why have you come to me in these sultry days of Summer?");
                    break;
                case 2: // autumn here, active event.
                    ShowMessage(player, "Distly Bombak, the vassal of Autumn, greets you.");
                    ShowMessage(player, "Lovely Autumn in its varicolored foliage urges you to gather in your harvest before harsh Winter comes.");
                    ShowMessage(player, "Autumn begins to fade, and so asks why you have come.");
                    break;
                case 3: // winter here
                    ShowMessage(player, "You may call me Karakiar, since that is my name. My liege is Winter.");
                    ShowMessage(player, "The bracing sting of Winter's winds refresh those who love its white wonderland.");
                    ShowMessage(player, "Winter would know why you are here.");
                    break;
            }
        }

        private void FnBWACTOR_12_UseItem(ServerPlayer player) {
            if (GetFlag(player, FlagTypeMap, 0x01) == 2 && HasUsedItem(player, ItemSpringRenewal, ItemSpringRenewal) == 1) {
                RemoveItem(player, ItemSpringRenewal);
                if (HasItem(player, ItemWinterWaters) == 0) {
                    GiveItem(player, ItemWinterWaters);
                }
                SetFlag(player, FlagTypeMap, 0x01, 0x03);
                ShowMessage(player, "Autumn gladly accepts the Spring Renewal.");
                ShowMessage(player, "Lo! Golden Autumn pales to white Winter and now sleeps under snowy blankets.");
                ShowMessage(player, "These icy Winter Waters are a present to you.");
            }
            else {
                ShowMessage(player, "A Wise One scoffs. 'You dishonour the Seasons with this false gift.'");
            }
        }

        // === Event 13: Clerics of Oakleaf. At Stage 0, Summer accepts the Harvest Horn here. =======================
        // ===========================================================================================================

        private void FnOLACTOR_13(ServerPlayer player, bool isForwardMove) {
            ShowPortrait(player, 0x0027);
            if (GetFlag(player, FlagTypeMap, 0x01) >= 4) {
                ShowMessage(player, "The Clerics softly sooth the seasons.");
            }
            else if (HasUsedItem(player, 0x00, 0xff) == 0) {
                FnOLACTOR_13_Introduction(player);
            }
            else {
                FnOLACTOR_13_UseItem(player);
            }
        }

        private void FnOLACTOR_13_Introduction(ServerPlayer player) {
            ShowMessage(player, "We are the Clerics of Oakleaf who comfort the Seasons.");
            switch (GetFlag(player, FlagTypeMap, 0x01)) {
                case 0: // summer here, active event
                    ShowMessage(player, "I am Shashamia, friend to the temperate Summer.");
                    ShowMessage(player, "Sullen summer is nervous around mortals.");
                    ShowMessage(player, "Do you have some business with Summer?");
                    break;
                case 1: // spring here
                    ShowMessage(player, "Call me Donbard. I ease the distress of gentle Spring.");
                    ShowMessage(player, "Spring quakes in fear at your coming.");
                    ShowMessage(player, "Why have you come to Spring's home?");
                    break;
                case 2: // winter here
                    ShowMessage(player, "I am called Kalakial, and I help poor Winter.");
                    ShowMessage(player, "Wistful Winter is too shy to speak to you directly.");
                    ShowMessage(player, "Winter wishes you to leave, so do quickly what you came to do.");
                    break;
                case 3: // autumn here
                    ShowMessage(player, "Dindly Bindiak is my name. Autumn is my friend.");
                    ShowMessage(player, "Russet-clad Autumn welcomes you if you are true friends of the Seasons.");
                    ShowMessage(player, "Autumn will fade away unless you tell me why you have come.");
                    break;
            }
        }

        private void FnOLACTOR_13_UseItem(ServerPlayer player) {
            if (GetFlag(player, FlagTypeMap, 0x01) == 0 && HasUsedItem(player, ItemHarvestHorn, ItemHarvestHorn) == 1) {
                RemoveItem(player, ItemHarvestHorn);
                if (HasItem(player, ItemAutumnSeeds) == 0) {
                    GiveItem(player, ItemAutumnSeeds);
                }
                SetFlag(player, FlagTypeMap, 0x01, 0x01);
                ShowMessage(player, "Summer accepts the Harvest Horn.");
                ShowMessage(player, "Summer mellows by the sweet music and is now Autumn!");
                ShowMessage(player, "Autumn Seeds are now yours to enjoy.");
            }
            else {
                ShowMessage(player, "A Cleric chides you. 'The Seasons shy away from your pitiful gift.'");
            }
        }

        // === Event 14: Wardens of Maplebrush. At Stage 3, Spring accepts the Winter Waters here. ===================
        // ===========================================================================================================

        private void FnMBACTOR_14(ServerPlayer player, bool isForwardMove) {
            ShowPortrait(player, 0x0027);
            if (GetFlag(player, FlagTypeMap, 0x01) >= 4) {
                ShowMessage(player, "The Wardens speak untold secrets.");
            }
            else if (HasUsedItem(player, 0x00, 0xff) == 0) {
                FnMBACTOR_14_Introduction(player);
            }
            else {
                FnMBACTOR_14_UseItem(player);
            }
        }

        private void FnMBACTOR_14_Introduction(ServerPlayer player) {
            ShowMessage(player, "We are the Wardens of Maplebrush and hold the Seasons.");
            switch (GetFlag(player, FlagTypeMap, 0x01)) {
                case 0: // winter here
                    ShowMessage(player, "Not even I know my true name.");
                    ShowMessage(player, "It is Winter. I may say no more.");
                    break;
                case 1: // autumn here
                    ShowMessage(player, "Never mind what my name is.");
                    ShowMessage(player, "It is Autumn. That is enough for now.");
                    break;
                case 2: // summer here
                    ShowMessage(player, "My name is my secret.");
                    ShowMessage(player, "It is Summer. That is all I will say.");
                    break;
                case 3: // spring here, active event
                    ShowMessage(player, "You may not know my name.");
                    ShowMessage(player, "It is Spring. That is all you need know.");
                    break;
            }
        }

        private void FnMBACTOR_14_UseItem(ServerPlayer player) {
            if (GetFlag(player, FlagTypeMap, 0x01) == 3 && HasUsedItem(player, ItemWinterWaters, ItemWinterWaters) == 1) {
                RemoveItem(player, ItemWinterWaters);
                if (HasItem(player, ItemSummerRadiance) == 0) {
                    GiveItem(player, ItemSummerRadiance);
                }
                SetFlag(player, FlagTypeMap, 0x01, 0x04);
                ShowMessage(player, "From Winter Waters comes the change of Spring to Summer.");
                ShowMessage(player, "You have been rewarded.");
            }
            else {
                ShowMessage(player, "The Warden grows angry. 'Wrong, wrong, wrong, mortal!'");
            }
        }

        // === Event 15: Seasons incarnate. At Stage 1, Winter accepts the Autumn Springs here. ======================
        // ===========================================================================================================

        private void FnPCACTOR_15(ServerPlayer player, bool isForwardMove) {
            ShowPortrait(player, 0x0027);
            if (GetFlag(player, FlagTypeMap, 0x01) >= 4) {
                ShowMessage(player, "The Seasons have no further use for you.");
            }
            else if (HasUsedItem(player, 0x00, 0xff) == 0) {
                FnPCACTOR_15_Introduction(player);
            }
            else {
                FnPCACTOR_15_UseItem(player);
            }

        }
        private void FnPCACTOR_15_Introduction(ServerPlayer player) {
            ShowMessage(player, "We are the Seasons incarnate in mortal form.");
            switch (GetFlag(player, FlagTypeMap, 0x01)) {
                case 0: // autumn here
                    ShowMessage(player, "I am Autumn.");
                    break;
                case 1: // winter here, active event
                    ShowMessage(player, "I am Winter.");
                    break;
                case 2: // spring here
                    ShowMessage(player, "I am Spring.");
                    break;
                case 3: // summer here
                    ShowMessage(player, "I am Summer.");
                    break;
            }
        }

        private void FnPCACTOR_15_UseItem(ServerPlayer player) {
            if (GetFlag(player, FlagTypeMap, 0x01) == 1 && HasUsedItem(player, ItemAutumnSeeds, ItemAutumnSeeds) == 1) {
                RemoveItem(player, ItemAutumnSeeds);
                if (HasItem(player, ItemSpringRenewal) == 0) {
                    GiveItem(player, ItemSpringRenewal);
                }
                SetFlag(player, FlagTypeMap, 0x01, 0x02);
                ShowMessage(player, "The Autumn Seeds awaken me from my long hibernation.");
                ShowMessage(player, "I am Spring again!");
                ShowMessage(player, "Take the Renewal of Spring and rejoice with me!");
            }
            else {
                ShowMessage(player, "The Season incarnate looks puzzled. 'I cannot accept this gift.'");
            }
        }

        // === Remaining events - clues ==============================================================================
        // ===========================================================================================================

        private void FnINFO_16(ServerPlayer player, bool isForwardMove) {
            ShowPortrait(player, 0x001F);
            ShowMessage(player, "'Welcome, Adventurer.  I am Varstad, counselor to the Elf King.");
            ShowMessage(player, "The magic Aldbora requires Summer Radiance to shed its knowledge fruit.'");
        }

        private void FnINFO_17(ServerPlayer player, bool isForwardMove) {
            ShowPortrait(player, 0x0027);
            ShowMessage(player, "The storyteller Sorshian honors your arrival.");
            ShowMessage(player, "'Only when the Seasons have processed will the Aldora shed the fruits of Wisdom.'");
        }

        private void FnCAVEDOOR_18(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, "A wooden sign says, 'To the cave of NeedleWood.'");
            if (HasUsedItem(player, 0xD8, 0xD8) == 1) {
                ShowMessage(player, "The door unlocks.");
                SetWallPassable(player, GetCurrentTile(player), 0x03, 0x01);
                SetWallItem(player, 0x01, GetCurrentTile(player), 0x03);
            }
        }

        private void FnELFHOME_19(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, "Young elves scurry and hide when you enter this elf home.");
        }

        private void FnELFHOME_1A(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, "Carvings of elfin rangers crossing glacial landscapes proudly mount the walls of a typical elfin dwelling.");
        }

        private void FnINFO_1B(ServerPlayer player, bool isForwardMove) {
            ShowPortrait(player, 0x001F);
            ShowMessage(player, "'I am Fernank, Hunter to the Elf King.");
            ShowMessage(player, "It is known in the trees that Nature's Robe must be used for the harvest.'");
        }
    }
}
