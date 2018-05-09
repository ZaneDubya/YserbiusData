namespace ZCF.Scripts.Maps {
    class YserMap03 : ACanoMapScript {
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
        private override MapEventHandler MapEvent01 => FnTOEXIT_01;
        private void FnTOEXIT_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x01, 0x01, 0x3A, 0x00);
            L001D: // RETURN;
        }

        private override MapEventHandler MapEvent02 => FnTOVEST_02;
        private void FnTOVEST_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x01, 0x03, 0xF5, 0x03);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent03 => FnGATEMSGA_03;
        private void FnGATEMSGA_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String03FC); // The gateway leads to THE VESTIBULE.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent04 => FnTELEPORT_04;
        private void FnTELEPORT_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x03, 0x04, 0xF7, 0x00);
            L001D: // RETURN;
        }

        private override MapEventHandler MapEvent05 => FnTELPORTW_05;
        private void FnTELPORTW_05(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x01, 0x04, 0x57, 0x02);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent06 => FnTELPORTE_06;
        private void FnTELPORTE_06(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x01, 0x04, 0x4F, 0x03);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent07 => FnTELPORTS_07;
        private void FnTELPORTS_07(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x01, 0x05, 0x8F, 0x01);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent08 => FnSTAIRMSG_08;
        private void FnSTAIRMSG_08(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0420); // Through the gateway to the west you see stairs leading down to the next level.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent09 => FnSTAIRSDN_09;
        private void FnSTAIRSDN_09(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x02, 0x01, 0x05, 0x01);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent0A => FnLKPKDOOR_0A;
        private void FnLKPKDOOR_0A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xC0, 0xC4);
            L0016: if (result.notequal) goto L0029;
            L0018: ax = UsedSkill58(party, 0x0E) // returns 0 if did not use, compares to 2nd op if did use;
            L0024: compare(ax, 0x0004);
            L0027: if (result.below) goto L0068;
            L0029: SetMove2C(party, 0x6F, 0x03, 0x01);
            L003F: PushStack(03);
            L0043: ax = GetNextTile20(party);
            L004A: PushStack(ax);
            L004B: PushStack(01);
            L004F: SetUnblocked30(party);
            L0059: ShowMessage(party, String046F); // You successfully picked the locked door.
            L0066: goto L008A;
            L0068: PushStack(0x00);
            L006B: PushStack(03);
            L006F: PushStack(6F);
            L0073: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L007D: ShowMessage(party, String0498); // The door is locked.
            L008A: // RETURN;
        }

        private override MapEventHandler MapEvent0B => FnTELEPORT_0B;
        private void FnTELEPORT_0B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x02, 0x01, 0x0E, 0x02);
            L001E: // RETURN;
        }

        private override MapEventHandler MapEvent0C => FnLKPKDOOR_0C;
        private void FnLKPKDOOR_0C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xC2, 0xC4);
            L0016: if (result.notequal) goto L0029;
            L0018: ax = UsedSkill58(party, 0x0E) // returns 0 if did not use, compares to 2nd op if did use;
            L0024: compare(ax, 0x0008);
            L0027: if (result.below) goto L0068;
            L0029: SetMove2C(party, 0x40, 0x03, 0x01);
            L003F: PushStack(03);
            L0043: ax = GetNextTile20(party);
            L004A: PushStack(ax);
            L004B: PushStack(01);
            L004F: SetUnblocked30(party);
            L0059: ShowMessage(party, String04AC); // You successfully picked the locked door.
            L0066: goto L008A;
            L0068: PushStack(0x00);
            L006B: PushStack(03);
            L006F: PushStack(40);
            L0073: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L007D: ShowMessage(party, String04D5); // The door is locked.
            L008A: // RETURN;
        }

        private override MapEventHandler MapEvent0D => FnGATEMSGB_0D;
        private void FnGATEMSGB_0D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String04E9); // The gateway leads to THE MAIN DUNGEON ENTRANCE.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent0E => FnTELMESSA_0E;
        private void FnTELMESSA_0E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0519); // There is a teleport in the west wall.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent0F => FnTELMESSB_0F;
        private void FnTELMESSB_0F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String053F); // There is a teleport in the south wall.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent10 => FnTELMESSC_10;
        private void FnTELMESSC_10(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0566); // There is a teleport in the west wall.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent11 => FnTELMESSD_11;
        private void FnTELMESSD_11(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String058C); // There is a teleport in the north wall.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent12 => FnNPCCHATA_12;
        private void FnNPCCHATA_12(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String05B3); // You encounter a Gnome Barbarian.
            L0010: ShowPortrait(party, 0x0019);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x0008);
            L002D: if (result.unsigned_greater_than) goto L004B;
            L002F: ShowMessage(party, String05D4); // My father told me an ancient story. A Galabryan king once brought a powerful wizard to Twinion. This wizard did something very bad and caused the volcano to erupt.
            L003C: ShowMessage(party, String0678); // Supposedly the wizard's castle is buried deep in the bowels of this mountain. It is his anguished spirit that keeps the volcano active.
            L0049: goto L0058;
            L004B: ShowMessage(party, String0700); // The Gnome Barbarian ignores you as he tries to remember his own name.
            L0058: // RETURN;
        }

        private override MapEventHandler MapEvent13 => FnNPCCHATB_13;
        private void FnNPCCHATB_13(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0746); // You encounter a Dwarf Wizard.
            L0010: ShowPortrait(party, 0x002C);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x000C);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String0764); // Powerful magic once existed here. I've found scrolls and amulets and other magic charms that contain powerful spells. The Mana in these items is soon exhausted.
            L003C: goto L005C;
            L003E: SetSpellLevel68(party, 0x12, 0x01);
            L004F: ShowMessage(party, String0805); // The Dwarf Wizard offers to teach you the Bless spell since you didn't hurt her.
            L005C: // RETURN;
        }

        private override MapEventHandler MapEvent14 => FnNPCCHATC_14;
        private void FnNPCCHATC_14(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0855); // You encounter a Halfling Ranger.
            L0010: ShowPortrait(party, 0x0021);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x000D);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String0876); // This place is called the Hall of Doors. Most doors lead nowhere. Others lead to wonders.
            L003C: goto L004B;
            L003E: ShowMessage(party, String08CF); // The Halfling Ranger wanders off in pursuit of friends.
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent15 => FnNPCCHATD_15;
        private void FnNPCCHATD_15(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0906); // You encounter a Troll Cleric.
            L0010: ShowPortrait(party, 0x0028);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x0006);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String0924); // Someone left a rune message on the floor. It said that to reach the King's Apartments, you must take a turn for the worse. I wonder if it means that you must be sick to find his quarters.
            L003C: goto L004B;
            L003E: ShowMessage(party, String09E0); // The Troll Cleric is too busy counting her blessings to speak to you.
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent16 => FnNPCCHATE_16;
        private void FnNPCCHATE_16(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0A25); // You encounter a Troll Knight.
            L0010: ShowPortrait(party, 0x001B);
            L001D: ax = UnknownFunctionEC(party, 0x000F);
            L002A: compare(ax, 0x000B);
            L002D: if (result.unsigned_greater_than) goto L003E;
            L002F: ShowMessage(party, String0A43); // A wise leader knows how to organize a party. Keep your fighters in front and your magicians safely in the rear. And as much as thieves are despised in general, they can serve you well, for their skills are impressive.
            L003C: goto L005C;
            L003E: ModifyGold(party, 0x000A);
            L004F: ShowMessage(party, String0B1D); // The Troll Knight gives you 10 Gold Pieces and departs in peace.
            L005C: // RETURN;
        }

        private override MapEventHandler MapEvent17 => FnLOWMNSTR_17;
        private void FnLOWMNSTR_17(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: compare(ax, 0x0001);
            L000E: if (result.equal) goto L001D;
            L0010: ax = PartyCount(party);
            L0018: compare(ax, 0x0002);
            L001B: if (result.notequal) goto L0043;
            L001D: AddEncounter(party, 0x01, 0x1A);
            L002F: AddEncounter(party, 0x02, 0x1A);
            L0041: goto L008B;
            L0043: AddEncounter(party, 0x01, 0x1A);
            L0055: AddEncounter(party, 0x02, 0x1A);
            L0067: AddEncounter(party, 0x03, 0x1B);
            L0079: AddEncounter(party, 0x04, 0x1B);
            L008B: // RETURN;
        }

        private override MapEventHandler MapEvent18 => FnLWRMNSTR_18;
        private void FnLWRMNSTR_18(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0B5D); // You encounter Goblins.
            L0010: ax = UnknownFunctionEC(party, 0x000F);
            L001D: compare(ax, 0x0004);
            L0020: if (result.unsigned_greater_than) goto L0031;
            L0022: ShowMessage(party, String0B74); // You should be gracious to us Goblins, or we will tell our masters the Goblin Kings that you are cruel and deserve to die most horribly.
            L002F: goto L004B;
            L0031: ShowMessage(party, String0BFC); // The Goblins refuse to talk.
            L003E: ShowMessage(party, String0C18); // They draw their weapons and attack!
            L004B: ax = PartyCount(party);
            L0053: compare(ax, 0x0001);
            L0056: if (result.notequal) goto L007F;
            L0058: AddEncounter(party, 0x01, 0x1C);
            L006A: AddEncounter(party, 0x02, 0x1C);
            L007C: goto L011E;
            L007F: ax = PartyCount(party);
            L0087: compare(ax, 0x0002);
            L008A: if (result.notequal) goto L00C4;
            L008C: AddEncounter(party, 0x01, 0x1D);
            L009E: AddEncounter(party, 0x02, 0x1C);
            L00B0: AddEncounter(party, 0x03, 0x1C);
            L00C2: goto L011E;
            L00C4: AddEncounter(party, 0x01, 0x1E);
            L00D6: AddEncounter(party, 0x02, 0x1E);
            L00E8: AddEncounter(party, 0x03, 0x1D);
            L00FA: AddEncounter(party, 0x04, 0x1D);
            L010C: AddEncounter(party, 0x05, 0x1E);
            L011E: // RETURN;
        }

        private override MapEventHandler MapEvent19 => FnOGREENC_19;
        private void FnOGREENC_19(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: compare(ax, 0x0001);
            L000E: if (result.equal) goto L001D;
            L0010: ax = PartyCount(party);
            L0018: compare(ax, 0x0002);
            L001B: if (result.notequal) goto L0055;
            L001D: AddEncounter(party, 0x01, 0x21);
            L002F: AddEncounter(party, 0x02, 0x28);
            L0041: AddEncounter(party, 0x03, 0x23);
            L0053: goto L00C1;
            L0055: AddEncounter(party, 0x01, 0x1F);
            L0067: AddEncounter(party, 0x02, 0x20);
            L0079: AddEncounter(party, 0x03, 0x21);
            L008B: AddEncounter(party, 0x04, 0x21);
            L009D: AddEncounter(party, 0x05, 0x23);
            L00AF: AddEncounter(party, 0x06, 0x28);
            L00C1: // RETURN;
        }

        private override MapEventHandler MapEvent1A => FnTUFMNSTR_1A;
        private void FnTUFMNSTR_1A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0C3C); // You encounter Rogues.
            L0010: ax = UnknownFunctionEC(party, 0x000F);
            L001D: compare(ax, 0x0003);
            L0020: if (result.unsigned_greater_than) goto L0031;
            L0022: ShowMessage(party, String0C52); // Bizarre creatures haunt this dungeon. Many know magic. A great evil must exist somewhere in the dungeon to spawn such a neverending host of monsters.
            L002F: goto L004B;
            L0031: ShowMessage(party, String0CE8); // The Rogues refuse to talk.
            L003E: ShowMessage(party, String0D03); // They charge at you!
            L004B: ax = PartyCount(party);
            L0053: compare(ax, 0x0001);
            L0056: if (result.notequal) goto L006C;
            L0058: AddEncounter(party, 0x01, 0x22);
            L006A: goto L00E7;
            L006C: ax = PartyCount(party);
            L0074: compare(ax, 0x0002);
            L0077: if (result.notequal) goto L009F;
            L0079: AddEncounter(party, 0x01, 0x23);
            L008B: AddEncounter(party, 0x02, 0x23);
            L009D: goto L00E7;
            L009F: AddEncounter(party, 0x01, 0x24);
            L00B1: AddEncounter(party, 0x02, 0x24);
            L00C3: AddEncounter(party, 0x03, 0x23);
            L00D5: AddEncounter(party, 0x04, 0x23);
            L00E7: // RETURN;
        }

        private override MapEventHandler MapEvent1B => FnSTRMNSTR_1B;
        private void FnSTRMNSTR_1B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0D17); // You encounter Rogues!
            L0010: ShowMessage(party, String0D2D); // The Rogues scowl at you and attack!
            L001D: ax = PartyCount(party);
            L0025: compare(ax, 0x0001);
            L0028: if (result.notequal) goto L003E;
            L002A: AddEncounter(party, 0x01, 0x28);
            L003C: goto L00B9;
            L003E: ax = PartyCount(party);
            L0046: compare(ax, 0x0002);
            L0049: if (result.notequal) goto L0071;
            L004B: AddEncounter(party, 0x01, 0x25);
            L005D: AddEncounter(party, 0x02, 0x27);
            L006F: goto L00B9;
            L0071: AddEncounter(party, 0x01, 0x27);
            L0083: AddEncounter(party, 0x02, 0x25);
            L0095: AddEncounter(party, 0x03, 0x28);
            L00A7: AddEncounter(party, 0x05, 0x26);
            L00B9: // RETURN;
        }

        private override MapEventHandler MapEvent1C => FnWEAPENC_1C;
        private void FnWEAPENC_1C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x06);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L0047;
            L0019: AddTreasure(party, 0x0190, 0x00, 0x00, 0x00, 0x00, 0xCE);
            L0038: ShowMessage(party, String0D51); // It looks like the Rogues you encounter have already looted the room.
            L0045: goto L0089;
            L0047: AddTreasure(party, 0x05DC, 0x00, 0x00, 0x00, 0x0C, 0x05);
            L0067: SetState00(party, 0x02, 0x06, 0x01);
            L007C: ShowMessage(party, String0D96); // Rogues covet the Sword of the Flames and Sword of Decision you see lying on the floor.
            L0089: ax = PartyCount(party);
            L0091: compare(ax, 0x0001);
            L0094: if (result.notequal) goto L00AB;
            L0096: AddEncounter(party, 0x01, 0x26);
            L00A8: goto L017E;
            L00AB: ax = PartyCount(party);
            L00B3: compare(ax, 0x0002);
            L00B6: if (result.notequal) goto L00DF;
            L00B8: AddEncounter(party, 0x01, 0x25);
            L00CA: AddEncounter(party, 0x02, 0x26);
            L00DC: goto L017E;
            L00DF: ax = PartyCount(party);
            L00E7: compare(ax, 0x0003);
            L00EA: if (result.notequal) goto L0124;
            L00EC: AddEncounter(party, 0x01, 0x28);
            L00FE: AddEncounter(party, 0x02, 0x24);
            L0110: AddEncounter(party, 0x03, 0x25);
            L0122: goto L017E;
            L0124: AddEncounter(party, 0x01, 0x25);
            L0136: AddEncounter(party, 0x02, 0x27);
            L0148: AddEncounter(party, 0x03, 0x26);
            L015A: AddEncounter(party, 0x04, 0x27);
            L016C: AddEncounter(party, 0x05, 0x23);
            L017E: // RETURN;
        }

        private override MapEventHandler MapEvent1D => FnGOLDENC_1D;
        private void FnGOLDENC_1D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x07);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L0047;
            L0019: AddTreasure(party, 0x0064, 0x00, 0x00, 0x00, 0x00, 0xCB);
            L0038: ShowMessage(party, String0DED); // Goblins grab their weapons as you enter the room.
            L0045: goto L0089;
            L0047: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0xCB, 0xB5);
            L0067: SetState00(party, 0x02, 0x07, 0x01);
            L007C: ShowMessage(party, String0E1F); // Goblins are pitching Gold Pieces against the wall.
            L0089: ax = PartyCount(party);
            L0091: compare(ax, 0x0001);
            L0094: if (result.equal) goto L00A3;
            L0096: ax = PartyCount(party);
            L009E: compare(ax, 0x0002);
            L00A1: if (result.notequal) goto L00C9;
            L00A3: AddEncounter(party, 0x01, 0x1D);
            L00B5: AddEncounter(party, 0x02, 0x1C);
            L00C7: goto L0111;
            L00C9: AddEncounter(party, 0x01, 0x1C);
            L00DB: AddEncounter(party, 0x02, 0x1C);
            L00ED: AddEncounter(party, 0x03, 0x1D);
            L00FF: AddEncounter(party, 0x04, 0x1D);
            L0111: // RETURN;
        }

        private override MapEventHandler MapEvent1E => FnMAGICENC_1E;
        private void FnMAGICENC_1E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x08);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L0048;
            L0019: AddTreasure(party, 0x0078, 0x00, 0x00, 0x00, 0xCB, 0xB5);
            L0039: ShowMessage(party, String0E52); // Ogres grimace in pleasure as you walk into their ambush.
            L0046: goto L008B;
            L0048: AddTreasure(party, 0x1388, 0x00, 0x00, 0xC5, 0x8A, 0x8E);
            L0069: SetState00(party, 0x02, 0x08, 0x01);
            L007E: ShowMessage(party, String0E8B); // Ogres are playing with items you identify as the Ring of Vigor, a Cudgel Insignia, and the Wand of Radiance.
            L008B: ax = PartyCount(party);
            L0093: compare(ax, 0x0001);
            L0096: if (result.notequal) goto L00AD;
            L0098: AddEncounter(party, 0x01, 0x1F);
            L00AA: goto L0180;
            L00AD: ax = PartyCount(party);
            L00B5: compare(ax, 0x0002);
            L00B8: if (result.notequal) goto L00E1;
            L00BA: AddEncounter(party, 0x01, 0x21);
            L00CC: AddEncounter(party, 0x02, 0x20);
            L00DE: goto L0180;
            L00E1: ax = PartyCount(party);
            L00E9: compare(ax, 0x0003);
            L00EC: if (result.notequal) goto L0126;
            L00EE: AddEncounter(party, 0x01, 0x1F);
            L0100: AddEncounter(party, 0x02, 0x20);
            L0112: AddEncounter(party, 0x03, 0x21);
            L0124: goto L0180;
            L0126: AddEncounter(party, 0x01, 0x1F);
            L0138: AddEncounter(party, 0x02, 0x1F);
            L014A: AddEncounter(party, 0x03, 0x20);
            L015C: AddEncounter(party, 0x04, 0x20);
            L016E: AddEncounter(party, 0x05, 0x21);
            L0180: // RETURN;
        }

    }
}
