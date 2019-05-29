#pragma warning disable
using System.Collections.Generic;
using XPT.Legacy;
using XPT.Legacy.Entities;

namespace XPT.Legacy.Maps {
    class YserMap03 : AMapScripted {
        protected override int MapIndex => 3;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap03() {
            MapEvent01 = FnTOEXIT_01;
            MapEvent02 = FnTOVEST_02;
            MapEvent03 = FnGATEMSGA_03;
            MapEvent04 = FnTELEPORT_04;
            MapEvent05 = FnTELPORTW_05;
            MapEvent06 = FnTELPORTE_06;
            MapEvent07 = FnTELPORTS_07;
            MapEvent08 = FnSTAIRMSG_08;
            MapEvent09 = FnSTAIRSDN_09;
            MapEvent0A = FnLKPKDOOR_0A;
            MapEvent0B = FnTELEPORT_0B;
            MapEvent0C = FnLKPKDOOR_0C;
            MapEvent0D = FnGATEMSGB_0D;
            MapEvent0E = FnTELMESSA_0E;
            MapEvent0F = FnTELMESSB_0F;
            MapEvent10 = FnTELMESSC_10;
            MapEvent11 = FnTELMESSD_11;
            MapEvent12 = FnNPCCHATA_12;
            MapEvent13 = FnNPCCHATB_13;
            MapEvent14 = FnNPCCHATC_14;
            MapEvent15 = FnNPCCHATD_15;
            MapEvent16 = FnNPCCHATE_16;
            MapEvent17 = FnLOWMNSTR_17;
            MapEvent18 = FnLWRMNSTR_18;
            MapEvent19 = FnOGREENC_19;
            MapEvent1A = FnTUFMNSTR_1A;
            MapEvent1B = FnSTRMNSTR_1B;
            MapEvent1C = FnWEAPENC_1C;
            MapEvent1D = FnGOLDENC_1D;
            MapEvent1E = FnMAGICENC_1E;
        }
        
        // === Strings ================================================
        private const string String03FC = "The gateway leads to THE VESTIBULE.";
        private const string String0420 = "Through the gateway to the west you see stairs leading down to the next level.";
        private const string String046F = "You successfully picked the locked door.";
        private const string String0498 = "The door is locked.";
        private const string String04AC = "You successfully picked the locked door.";
        private const string String04D5 = "The door is locked.";
        private const string String04E9 = "The gateway leads to THE MAIN DUNGEON ENTRANCE.";
        private const string String0519 = "There is a teleport in the west wall.";
        private const string String053F = "There is a teleport in the south wall.";
        private const string String0566 = "There is a teleport in the west wall.";
        private const string String058C = "There is a teleport in the north wall.";
        private const string String05B3 = "You encounter a Gnome Barbarian.";
        private const string String05D4 = "My father told me an ancient story. A Galabryan king once brought a powerful wizard to Twinion. This wizard did something very bad and caused the volcano to erupt.";
        private const string String0678 = "Supposedly the wizard's castle is buried deep in the bowels of this mountain. It is his anguished spirit that keeps the volcano active.";
        private const string String0700 = "The Gnome Barbarian ignores you as he tries to remember his own name.";
        private const string String0746 = "You encounter a Dwarf Wizard.";
        private const string String0764 = "Powerful magic once existed here. I've found scrolls and amulets and other magic charms that contain powerful spells. The Mana in these items is soon exhausted.";
        private const string String0805 = "The Dwarf Wizard offers to teach you the Bless spell since you didn't hurt her.";
        private const string String0855 = "You encounter a Halfling Ranger.";
        private const string String0876 = "This place is called the Hall of Doors. Most doors lead nowhere. Others lead to wonders.";
        private const string String08CF = "The Halfling Ranger wanders off in pursuit of friends.";
        private const string String0906 = "You encounter a Troll Cleric.";
        private const string String0924 = "Someone left a rune message on the floor. It said that to reach the King's Apartments, you must take a turn for the worse. I wonder if it means that you must be sick to find his quarters.";
        private const string String09E0 = "The Troll Cleric is too busy counting her blessings to speak to you.";
        private const string String0A25 = "You encounter a Troll Knight.";
        private const string String0A43 = "A wise leader knows how to organize a party. Keep your fighters in front and your magicians safely in the rear. And as much as thieves are despised in general, they can serve you well, for their skills are impressive.";
        private const string String0B1D = "The Troll Knight gives you 10 Gold Pieces and departs in peace.";
        private const string String0B5D = "You encounter Goblins.";
        private const string String0B74 = "You should be gracious to us Goblins, or we will tell our masters the Goblin Kings that you are cruel and deserve to die most horribly.";
        private const string String0BFC = "The Goblins refuse to talk.";
        private const string String0C18 = "They draw their weapons and attack!";
        private const string String0C3C = "You encounter Rogues.";
        private const string String0C52 = "Bizarre creatures haunt this dungeon. Many know magic. A great evil must exist somewhere in the dungeon to spawn such a neverending host of monsters.";
        private const string String0CE8 = "The Rogues refuse to talk.";
        private const string String0D03 = "They charge at you!";
        private const string String0D17 = "You encounter Rogues!";
        private const string String0D2D = "The Rogues scowl at you and attack!";
        private const string String0D51 = "It looks like the Rogues you encounter have already looted the room.";
        private const string String0D96 = "Rogues covet the Sword of the Flames and Sword of Decision you see lying on the floor.";
        private const string String0DED = "Goblins grab their weapons as you enter the room.";
        private const string String0E1F = "Goblins are pitching Gold Pieces against the wall.";
        private const string String0E52 = "Ogres grimace in pleasure as you walk into their ambush.";
        private const string String0E8B = "Ogres are playing with items you identify as the Ring of Vigor, a Cudgel Insignia, and the Wand of Radiance.";
        
        // === Functions ================================================
        private void FnTOEXIT_01(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x01, 0x01, 0x3A, 0x00, type);
            L001D: return; // RETURN;
        }

        private void FnTOVEST_02(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x01, 0x03, ItemRanbowGemYellow, 0x03, type);
            L001E: return; // RETURN;
        }

        private void FnGATEMSGA_03(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String03FC); // The gateway leads to THE VESTIBULE.
            L0010: return; // RETURN;
        }

        private void FnTELEPORT_04(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x03, 0x04, 0xF7, 0x00, type);
            L001D: return; // RETURN;
        }

        private void FnTELPORTW_05(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x01, 0x04, 0x57, 0x02, type);
            L001E: return; // RETURN;
        }

        private void FnTELPORTE_06(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x01, 0x04, 0x4F, 0x03, type);
            L001E: return; // RETURN;
        }

        private void FnTELPORTS_07(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x01, 0x05, 0x8F, 0x01, type);
            L001E: return; // RETURN;
        }

        private void FnSTAIRMSG_08(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0420); // Through the gateway to the west you see stairs leading down to the next level.
            L0010: return; // RETURN;
        }

        private void FnSTAIRSDN_09(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x02, 0x01, 0x05, 0x01, type);
            L001E: return; // RETURN;
        }

        private void FnLKPKDOOR_0A(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, type, ref doMsgs, 0xC0, 0xC4);
            L0016: if (JumpNotEqual) goto L0029;
            L0018: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0E), 0x0004);
            L0027: if (JumpBelow) goto L0068;
            L0029: SetWallPassable(player, 0x6F, 0x03, 0x01);
            L003F: SetWallItem(player, 0x01, GetCurrentTile(player), 0x03);
            L0059: ShowMessage(player, doMsgs, String046F); // You successfully picked the locked door.
            L0066: goto L008A;
            L0068: SetWallPassable(player, 0x6F, 0x03, 0x00);
            L007D: ShowMessage(player, doMsgs, String0498); // The door is locked.
            L008A: return; // RETURN;
        }

        private void FnTELEPORT_0B(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x02, 0x01, 0x0E, 0x02, type);
            L001E: return; // RETURN;
        }

        private void FnLKPKDOOR_0C(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, type, ref doMsgs, 0xC2, 0xC4);
            L0016: if (JumpNotEqual) goto L0029;
            L0018: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0E), 0x0008);
            L0027: if (JumpBelow) goto L0068;
            L0029: SetWallPassable(player, 0x40, 0x03, 0x01);
            L003F: SetWallItem(player, 0x01, GetCurrentTile(player), 0x03);
            L0059: ShowMessage(player, doMsgs, String04AC); // You successfully picked the locked door.
            L0066: goto L008A;
            L0068: SetWallPassable(player, 0x40, 0x03, 0x00);
            L007D: ShowMessage(player, doMsgs, String04D5); // The door is locked.
            L008A: return; // RETURN;
        }

        private void FnGATEMSGB_0D(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String04E9); // The gateway leads to THE MAIN DUNGEON ENTRANCE.
            L0010: return; // RETURN;
        }

        private void FnTELMESSA_0E(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0519); // There is a teleport in the west wall.
            L0010: return; // RETURN;
        }

        private void FnTELMESSB_0F(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String053F); // There is a teleport in the south wall.
            L0010: return; // RETURN;
        }

        private void FnTELMESSC_10(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0566); // There is a teleport in the west wall.
            L0010: return; // RETURN;
        }

        private void FnTELMESSD_11(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String058C); // There is a teleport in the north wall.
            L0010: return; // RETURN;
        }

        private void FnNPCCHATA_12(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String05B3); // You encounter a Gnome Barbarian.
            L0010: ShowPortrait(player, 0x0019);
            L001D: Compare(GetRandom(0x000F), 0x0008);
            L002D: if (JumpAbove) goto L004B;
            L002F: ShowMessage(player, doMsgs, String05D4); // My father told me an ancient story. A Galabryan king once brought a powerful wizard to Twinion. This wizard did something very bad and caused the volcano to erupt.
            L003C: ShowMessage(player, doMsgs, String0678); // Supposedly the wizard's castle is buried deep in the bowels of this mountain. It is his anguished spirit that keeps the volcano active.
            L0049: goto L0058;
            L004B: ShowMessage(player, doMsgs, String0700); // The Gnome Barbarian ignores you as he tries to remember his own name.
            L0058: return; // RETURN;
        }

        private void FnNPCCHATB_13(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0746); // You encounter a Dwarf Wizard.
            L0010: ShowPortrait(player, 0x002C);
            L001D: Compare(GetRandom(0x000F), 0x000C);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, doMsgs, String0764); // Powerful magic once existed here. I've found scrolls and amulets and other magic charms that contain powerful spells. The Mana in these items is soon exhausted.
            L003C: goto L005C;
            L003E: SetSpellLevel(player, 0x12, 0x01);
            L004F: ShowMessage(player, doMsgs, String0805); // The Dwarf Wizard offers to teach you the Bless spell since you didn't hurt her.
            L005C: return; // RETURN;
        }

        private void FnNPCCHATC_14(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0855); // You encounter a Halfling Ranger.
            L0010: ShowPortrait(player, 0x0021);
            L001D: Compare(GetRandom(0x000F), 0x000D);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, doMsgs, String0876); // This place is called the Hall of Doors. Most doors lead nowhere. Others lead to wonders.
            L003C: goto L004B;
            L003E: ShowMessage(player, doMsgs, String08CF); // The Halfling Ranger wanders off in pursuit of friends.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATD_15(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0906); // You encounter a Troll Cleric.
            L0010: ShowPortrait(player, 0x0028);
            L001D: Compare(GetRandom(0x000F), 0x0006);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, doMsgs, String0924); // Someone left a rune message on the floor. It said that to reach the King's Apartments, you must take a turn for the worse. I wonder if it means that you must be sick to find his quarters.
            L003C: goto L004B;
            L003E: ShowMessage(player, doMsgs, String09E0); // The Troll Cleric is too busy counting her blessings to speak to you.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATE_16(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0A25); // You encounter a Troll Knight.
            L0010: ShowPortrait(player, 0x001B);
            L001D: Compare(GetRandom(0x000F), 0x000B);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, doMsgs, String0A43); // A wise leader knows how to organize a party. Keep your fighters in front and your magicians safely in the rear. And as much as thieves are despised in general, they can serve you well, for their skills are impressive.
            L003C: goto L005C;
            L003E: ModifyGold(player, 0x000A);
            L004F: ShowMessage(player, doMsgs, String0B1D); // The Troll Knight gives you 10 Gold Pieces and departs in peace.
            L005C: return; // RETURN;
        }

        private void FnLOWMNSTR_17(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpEqual) goto L001D;
            L0010: Compare(PartyCount(player), 0x0002);
            L001B: if (JumpNotEqual) goto L0043;
            L001D: AddEncounter(player, 0x01, 0x1A);
            L002F: AddEncounter(player, 0x02, 0x1A);
            L0041: goto L008B;
            L0043: AddEncounter(player, 0x01, 0x1A);
            L0055: AddEncounter(player, 0x02, 0x1A);
            L0067: AddEncounter(player, 0x03, 0x1B);
            L0079: AddEncounter(player, 0x04, 0x1B);
            L008B: return; // RETURN;
        }

        private void FnLWRMNSTR_18(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0B5D); // You encounter Goblins.
            L0010: Compare(GetRandom(0x000F), 0x0004);
            L0020: if (JumpAbove) goto L0031;
            L0022: ShowMessage(player, doMsgs, String0B74); // You should be gracious to us Goblins, or we will tell our masters the Goblin Kings that you are cruel and deserve to die most horribly.
            L002F: goto L004B;
            L0031: ShowMessage(player, doMsgs, String0BFC); // The Goblins refuse to talk.
            L003E: ShowMessage(player, doMsgs, String0C18); // They draw their weapons and attack!
            L004B: Compare(PartyCount(player), 0x0001);
            L0056: if (JumpNotEqual) goto L007F;
            L0058: AddEncounter(player, 0x01, 0x1C);
            L006A: AddEncounter(player, 0x02, 0x1C);
            L007C: goto L011E;
            L007F: Compare(PartyCount(player), 0x0002);
            L008A: if (JumpNotEqual) goto L00C4;
            L008C: AddEncounter(player, 0x01, 0x1D);
            L009E: AddEncounter(player, 0x02, 0x1C);
            L00B0: AddEncounter(player, 0x03, 0x1C);
            L00C2: goto L011E;
            L00C4: AddEncounter(player, 0x01, 0x1E);
            L00D6: AddEncounter(player, 0x02, 0x1E);
            L00E8: AddEncounter(player, 0x03, 0x1D);
            L00FA: AddEncounter(player, 0x04, 0x1D);
            L010C: AddEncounter(player, 0x05, 0x1E);
            L011E: return; // RETURN;
        }

        private void FnOGREENC_19(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpEqual) goto L001D;
            L0010: Compare(PartyCount(player), 0x0002);
            L001B: if (JumpNotEqual) goto L0055;
            L001D: AddEncounter(player, 0x01, 0x21);
            L002F: AddEncounter(player, 0x02, 0x28);
            L0041: AddEncounter(player, 0x03, 0x23);
            L0053: goto L00C1;
            L0055: AddEncounter(player, 0x01, 0x1F);
            L0067: AddEncounter(player, 0x02, 0x20);
            L0079: AddEncounter(player, 0x03, 0x21);
            L008B: AddEncounter(player, 0x04, 0x21);
            L009D: AddEncounter(player, 0x05, 0x23);
            L00AF: AddEncounter(player, 0x06, 0x28);
            L00C1: return; // RETURN;
        }

        private void FnTUFMNSTR_1A(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0C3C); // You encounter Rogues.
            L0010: Compare(GetRandom(0x000F), 0x0003);
            L0020: if (JumpAbove) goto L0031;
            L0022: ShowMessage(player, doMsgs, String0C52); // Bizarre creatures haunt this dungeon. Many know magic. A great evil must exist somewhere in the dungeon to spawn such a neverending host of monsters.
            L002F: goto L004B;
            L0031: ShowMessage(player, doMsgs, String0CE8); // The Rogues refuse to talk.
            L003E: ShowMessage(player, doMsgs, String0D03); // They charge at you!
            L004B: Compare(PartyCount(player), 0x0001);
            L0056: if (JumpNotEqual) goto L006C;
            L0058: AddEncounter(player, 0x01, 0x22);
            L006A: goto L00E7;
            L006C: Compare(PartyCount(player), 0x0002);
            L0077: if (JumpNotEqual) goto L009F;
            L0079: AddEncounter(player, 0x01, 0x23);
            L008B: AddEncounter(player, 0x02, 0x23);
            L009D: goto L00E7;
            L009F: AddEncounter(player, 0x01, 0x24);
            L00B1: AddEncounter(player, 0x02, 0x24);
            L00C3: AddEncounter(player, 0x03, 0x23);
            L00D5: AddEncounter(player, 0x04, 0x23);
            L00E7: return; // RETURN;
        }

        private void FnSTRMNSTR_1B(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0D17); // You encounter Rogues!
            L0010: ShowMessage(player, doMsgs, String0D2D); // The Rogues scowl at you and attack!
            L001D: Compare(PartyCount(player), 0x0001);
            L0028: if (JumpNotEqual) goto L003E;
            L002A: AddEncounter(player, 0x01, 0x28);
            L003C: goto L00B9;
            L003E: Compare(PartyCount(player), 0x0002);
            L0049: if (JumpNotEqual) goto L0071;
            L004B: AddEncounter(player, 0x01, 0x25);
            L005D: AddEncounter(player, 0x02, 0x27);
            L006F: goto L00B9;
            L0071: AddEncounter(player, 0x01, 0x27);
            L0083: AddEncounter(player, 0x02, 0x25);
            L0095: AddEncounter(player, 0x03, 0x28);
            L00A7: AddEncounter(player, 0x05, 0x26);
            L00B9: return; // RETURN;
        }

        private void FnWEAPENC_1C(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, FlagTypeDungeon, FlagHallOfDoorsFoundSwords), 0x0001);
            L0017: if (JumpNotEqual) goto L0047;
            L0019: AddTreasure(player, 0x0190, 0x00, 0x00, 0x00, 0x00, 0xCE);
            L0038: ShowMessage(player, doMsgs, String0D51); // It looks like the Rogues you encounter have already looted the room.
            L0045: goto L0089;
            L0047: AddTreasure(player, 0x05DC, 0x00, 0x00, 0x00, 0x0C, 0x05);
            L0067: SetFlag(player, FlagTypeDungeon, FlagHallOfDoorsFoundSwords, 0x01);
            L007C: ShowMessage(player, doMsgs, String0D96); // Rogues covet the Sword of the Flames and Sword of Decision you see lying on the floor.
            L0089: Compare(PartyCount(player), 0x0001);
            L0094: if (JumpNotEqual) goto L00AB;
            L0096: AddEncounter(player, 0x01, 0x26);
            L00A8: goto L017E;
            L00AB: Compare(PartyCount(player), 0x0002);
            L00B6: if (JumpNotEqual) goto L00DF;
            L00B8: AddEncounter(player, 0x01, 0x25);
            L00CA: AddEncounter(player, 0x02, 0x26);
            L00DC: goto L017E;
            L00DF: Compare(PartyCount(player), 0x0003);
            L00EA: if (JumpNotEqual) goto L0124;
            L00EC: AddEncounter(player, 0x01, 0x28);
            L00FE: AddEncounter(player, 0x02, 0x24);
            L0110: AddEncounter(player, 0x03, 0x25);
            L0122: goto L017E;
            L0124: AddEncounter(player, 0x01, 0x25);
            L0136: AddEncounter(player, 0x02, 0x27);
            L0148: AddEncounter(player, 0x03, 0x26);
            L015A: AddEncounter(player, 0x04, 0x27);
            L016C: AddEncounter(player, 0x05, 0x23);
            L017E: return; // RETURN;
        }

        private void FnGOLDENC_1D(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, FlagTypeDungeon, FlagHallOfDoorsFoundGold), 0x0001);
            L0017: if (JumpNotEqual) goto L0047;
            L0019: AddTreasure(player, 0x0064, 0x00, 0x00, 0x00, 0x00, 0xCB);
            L0038: ShowMessage(player, doMsgs, String0DED); // Goblins grab their weapons as you enter the room.
            L0045: goto L0089;
            L0047: AddTreasure(player, 0x03E8, 0x00, 0x00, 0x00, 0xCB, 0xB5);
            L0067: SetFlag(player, FlagTypeDungeon, FlagHallOfDoorsFoundGold, 0x01);
            L007C: ShowMessage(player, doMsgs, String0E1F); // Goblins are pitching Gold Pieces against the wall.
            L0089: Compare(PartyCount(player), 0x0001);
            L0094: if (JumpEqual) goto L00A3;
            L0096: Compare(PartyCount(player), 0x0002);
            L00A1: if (JumpNotEqual) goto L00C9;
            L00A3: AddEncounter(player, 0x01, 0x1D);
            L00B5: AddEncounter(player, 0x02, 0x1C);
            L00C7: goto L0111;
            L00C9: AddEncounter(player, 0x01, 0x1C);
            L00DB: AddEncounter(player, 0x02, 0x1C);
            L00ED: AddEncounter(player, 0x03, 0x1D);
            L00FF: AddEncounter(player, 0x04, 0x1D);
            L0111: return; // RETURN;
        }

        private void FnMAGICENC_1E(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, FlagTypeDungeon, FlagHallOfDoorsFoundOgreItems), 0x0001);
            L0017: if (JumpNotEqual) goto L0048;
            L0019: AddTreasure(player, 0x0078, 0x00, 0x00, 0x00, 0xCB, 0xB5);
            L0039: ShowMessage(player, doMsgs, String0E52); // Ogres grimace in pleasure as you walk into their ambush.
            L0046: goto L008B;
            L0048: AddTreasure(player, 0x1388, 0x00, 0x00, 0xC5, 0x8A, 0x8E);
            L0069: SetFlag(player, FlagTypeDungeon, FlagHallOfDoorsFoundOgreItems, 0x01);
            L007E: ShowMessage(player, doMsgs, String0E8B); // Ogres are playing with items you identify as the Ring of Vigor, a Cudgel Insignia, and the Wand of Radiance.
            L008B: Compare(PartyCount(player), 0x0001);
            L0096: if (JumpNotEqual) goto L00AD;
            L0098: AddEncounter(player, 0x01, 0x1F);
            L00AA: goto L0180;
            L00AD: Compare(PartyCount(player), 0x0002);
            L00B8: if (JumpNotEqual) goto L00E1;
            L00BA: AddEncounter(player, 0x01, 0x21);
            L00CC: AddEncounter(player, 0x02, 0x20);
            L00DE: goto L0180;
            L00E1: Compare(PartyCount(player), 0x0003);
            L00EC: if (JumpNotEqual) goto L0126;
            L00EE: AddEncounter(player, 0x01, 0x1F);
            L0100: AddEncounter(player, 0x02, 0x20);
            L0112: AddEncounter(player, 0x03, 0x21);
            L0124: goto L0180;
            L0126: AddEncounter(player, 0x01, 0x1F);
            L0138: AddEncounter(player, 0x02, 0x1F);
            L014A: AddEncounter(player, 0x03, 0x20);
            L015C: AddEncounter(player, 0x04, 0x20);
            L016E: AddEncounter(player, 0x05, 0x21);
            L0180: return; // RETURN;
        }

    }
}
