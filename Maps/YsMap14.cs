#pragma warning disable
using XPT.WorldData;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap14 : AMapScripted {
        protected override int MapIndex => 14;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 2;

        public YserMap14() {
            MapEvent01 = FnTORUNERM_01;
            MapEvent02 = FnTOMAUS_02;
            MapEvent03 = FnSPECDOOR_03;
            MapEvent04 = FnQUESTDOR_04;
            MapEvent05 = FnSTRSTELE_05;
            MapEvent06 = FnQSTCHARA_06;
            MapEvent07 = FnQSTCHARB_07;
            MapEvent08 = FnQSTCHARC_08;
            MapEvent09 = FnTELEPORT_09;
            MapEvent0A = FnTELEPORT_0A;
            MapEvent0B = FnHUTHDOOR_0B;
            MapEvent0C = FnORCLDOOR_0C;
            MapEvent0D = FnELBADOOR_0D;
            MapEvent0E = FnTRRADOOR_0E;
            MapEvent0F = FnDWKNDOOR_0F;
            MapEvent10 = FnGNWIDOOR_10;
            MapEvent11 = FnHAITDOOR_11;
            MapEvent12 = FnGRITDOOR_12;
            MapEvent13 = FnOTGGDOOR_13;
            MapEvent14 = FnHEDHDOOR_14;
            MapEvent15 = FnCHAOSDOR_15;
            MapEvent16 = FnHARMDOOR_16;
            MapEvent17 = FnPAYAENC_17;
            MapEvent18 = FnPAYBENC_18;
            MapEvent19 = FnBLESSMES_19;
            MapEvent1A = FnBLESSMES_1A;
            MapEvent1B = FnBLESSMES_1B;
            MapEvent1C = FnBLESSMES_1C;
            MapEvent1D = FnBLESSMES_1D;
            MapEvent1E = FnBLESSMES_1E;
            MapEvent1F = FnBLESSMES_1F;
            MapEvent20 = FnBLESSMES_20;
            MapEvent21 = FnENDQSTDR_21;
            MapEvent22 = FnQUESTBEN_22;
            MapEvent23 = FnGOLDAENC_23;
            MapEvent24 = FnWEAPAENC_24;
            MapEvent25 = FnMAGICENC_25;
            MapEvent26 = FnQUESTAEN_26;
            MapEvent27 = FnITEMAENC_27;
            MapEvent28 = FnGOLDBENC_28;
            MapEvent29 = FnDRKEYENC_29;
            MapEvent2A = FnSPKEYDOO_2A;
            MapEvent2C = FnITEMBENC_2C;
            MapEvent2D = FnGOLDPILE_2D;
            MapEvent2E = FnSTRMNSTR_2E;
            MapEvent2F = FnTUFMNSTR_2F;
            MapEvent3A = FnGATEMESA_3A;
            MapEvent3B = FnGATEMESB_3B;
            MapEvent3C = FnSTRSMESS_3C;
            MapEvent3D = FnTELEMESA_3D;
            MapEvent3E = FnTELEMESB_3E;
        }
        
        // === Strings ================================================
        private const string String03FC = "The door opens.";
        private const string String040C = "This door is locked.";
        private const string String0421 = "The door magically opens!";
        private const string String043B = "This door will not open.";
        private const string String0454 = "That is indeed the King's Pass. You may continue. If you ever return, I'll need to see another pass.";
        private const string String04B9 = "None may pass. I am pledged to guard King Cleowyn's Apartments for eternity. Of course, if you had the King's Pass, I could let you through.";
        private const string String0546 = "Seek the Pass where Ranger and Troll are blessed.";
        private const string String0578 = "You have passed the Trial of Harmony. A great reward is yours, if you but look for it.";
        private const string String05CF = "You have mastered our Challenge. Congratulations! Behold the door of Harmony. Only those pledged to Harmony should enter.";
        private const string String0649 = "You have passed the Trial of Chaos. A great reward is yours, if you but look for it.";
        private const string String069E = "You have mastered our Challenge. Congratulations! Behold the door of Chaos. Only those pledged to Chaos should enter.";
        private const string String0714 = "The door is opened";
        private const string String0727 = "The door can be opened only by a Human or Thief.";
        private const string String0758 = "The lock of the door opens as you step forward.";
        private const string String0788 = "The door can be opened only by an Orc or Cleric.";
        private const string String07B9 = "The lock opens as you approach.";
        private const string String07D9 = "The door can be opened only by an Elf or Barbarian.";
        private const string String080D = "The door unlocks when you test it.";
        private const string String0830 = "The door can be opened only by a Troll or Ranger.";
        private const string String0862 = "The door opens as you advance.";
        private const string String0881 = "The door can be opened only by a Dwarf or Knight.";
        private const string String08B3 = "The door is opened.";
        private const string String08C7 = "The door can be opened only by a Gnome or Wizard.";
        private const string String08F9 = "The door clicks open.";
        private const string String090F = "The door can be opened only by a Halfling or by Cleowyn's Key.";
        private const string String094E = "The lock opens for you.";
        private const string String0966 = "The door can be opened only by a Gremlin or by Cleowyn's Lockpick.";
        private const string String09A9 = "A warning is on the door -";
        private const string String09C4 = "'Those honoring Harmony may safely enter.'";
        private const string String09EF = "'Woe to you who serve Chaos, if you dare cross the threshold.'";
        private const string String0A2E = "A warning is on the door -";
        private const string String0A49 = "'Those honoring Chaos may safely enter.'";
        private const string String0A72 = "'Woe to you who serve Harmony, if you dare cross the threshold.'";
        private const string String0AB3 = "A sign is on the door -";
        private const string String0ACB = "The way is clear for members of Chaos.";
        private const string String0AF2 = "Those not sworn to Chaos have been duly chastised.";
        private const string String0B25 = "A sign is on the door -";
        private const string String0B3D = "The way is clear for members of Harmony.";
        private const string String0B66 = "Those not sworn to Harmony have been duly chastised.";
        private const string String0B9B = "Rogues bar the way to Chaos.";
        private const string String0BB8 = "Rogues bar the way to Harmony.";
        private const string String0BD7 = "Blessed Human or Thief, you may continue the quest.";
        private const string String0C0B = "The tapestry shows nothing of interest.";
        private const string String0C33 = "Blessed Orc or Cleric, you may continue the quest.";
        private const string String0C66 = "The tapestry shows a jumble of runes.";
        private const string String0C8C = "Blessed Elf or Barbarian, you may continue the quest.";
        private const string String0CC2 = "The tapestry is blank.";
        private const string String0CD9 = "Blessed Troll or Ranger, you may continue the quest.";
        private const string String0D0E = "The tapestry is blank.";
        private const string String0D25 = "Blessed Dwarf or Knight, you may continue the quest.";
        private const string String0D5A = "It is too dark to read the inscription.";
        private const string String0D82 = "Blessed Gnome or Wizard, you may continue the quest.";
        private const string String0DB7 = "An inscription on the tapestry fades away as you draw near.";
        private const string String0DF3 = "Blessed Halfling! Blessed Key of Cleowyn! With either, the quest may continue.";
        private const string String0E42 = "The tapestry is empty.";
        private const string String0E59 = "Blessed Gremlin! Blessed Pick of Cleowyn! With either, the quest may continue.";
        private const string String0EA8 = "The tapestry once held a woven message.";
        private const string String0ED0 = "You found a secret door!";
        private const string String0EE9 = "Reptilian bodies rise from the shadows.";
        private const string String0F11 = "On the floor is a Chess Piece inscribed with the words - 'Property of Arnakkian Slowfoot.'";
        private const string String0F6C = "You are challenged to combat.";
        private const string String0F8A = "Ferocious enemies stop you.";
        private const string String0FA6 = "Elf Rangers await you.";
        private const string String0FBD = "An Elf Ranger holds the King's Pass.";
        private const string String0FE2 = "Proud knights dispute your progress.";
        private const string String1007 = "Strong enemies bar your way.";
        private const string String1024 = "There is nothing of interest here.";
        private const string String1047 = "You see a lockpick on the floor.";
        private const string String1068 = "Gallants challenge you.";
        private const string String1080 = "The key opens the door.";
        private const string String1098 = "The door is locked and requires a special key.";
        private const string String10C7 = "Fierce opponents bar your way.";
        private const string String10E6 = "This area has been looted.";
        private const string String1101 = "You find 12000 Gold Pieces on the floor.";
        private const string String112A = "Your way is blocked.";
        private const string String113F = "The gateway leads to THE RUNE ROOM.";
        private const string String1163 = "The gateway leads to THE MAUSOLEUM.";
        private const string String1187 = "Stairs past the south gateway lead down.";
        private const string String11B0 = "There is a teleport in the east wall.";
        private const string String11D6 = "There is a teleport in the west wall.";
        
        // === Functions ================================================
        private void FnTORUNERM_01(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x03, 0x01, 0x1F, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnTOMAUS_02(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x03, 0x04, 0xF8, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnSPECDOOR_03(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(party, 0xD2, 0xD2);
            L0016: if (JumpNotEqual) goto L0028;
            L0018: ax = HasItem(party, 0xF8);
            L0026: if (JumpEqual) goto L0073;
            L0028: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L0046: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L0064: ShowMessage(party, String03FC); // The door opens.
            L0071: goto L009D;
            L0073: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x00);
            L0090: ShowMessage(party, String040C); // This door is locked.
            L009D: return; // RETURN;
        }

        private void FnQUESTDOR_04(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x02, 0x2E), 0x0001);
            L0017: if (JumpNotEqual) goto L0078;
            L0019: SetState(party, 0x02, 0x2E, 0x00);
            L002D: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L004B: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L0069: ShowMessage(party, String0421); // The door magically opens!
            L0076: goto L00A2;
            L0078: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x00);
            L0095: ShowMessage(party, String043B); // This door will not open.
            L00A2: return; // RETURN;
        }

        private void FnSTRSTELE_05(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x04, 0x01, 0x1F, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnQSTCHARA_06(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0xF9);
            L0011: if (JumpEqual) goto L008C;
            L0013: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L0031: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L004F: SetState(party, 0x02, 0x2E, 0x01);
            L0064: ShowPortrait(party, 0x001C);
            L0071: RemoveItem(party, 0xF9);
            L007D: ShowMessage(party, String0454); // That is indeed the King's Pass. You may continue. If you ever return, I'll need to see another pass.
            L008A: goto L00D0;
            L008C: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x00);
            L00A9: ShowPortrait(party, 0x001C);
            L00B6: ShowMessage(party, String04B9); // None may pass. I am pledged to guard King Cleowyn's Apartments for eternity. Of course, if you had the King's Pass, I could let you through.
            L00C3: ShowMessage(party, String0546); // Seek the Pass where Ranger and Troll are blessed.
            L00D0: return; // RETURN;
        }

        private void FnQSTCHARB_07(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x02, 0x22), 0x0001);
            L0017: if (JumpNotEqual) goto L0035;
            L0019: ShowPortrait(party, 0x002C);
            L0026: ShowMessage(party, String0578); // You have passed the Trial of Harmony. A great reward is yours, if you but look for it.
            L0033: goto L004F;
            L0035: ShowPortrait(party, 0x002C);
            L0042: ShowMessage(party, String05CF); // You have mastered our Challenge. Congratulations! Behold the door of Harmony. Only those pledged to Harmony should enter.
            L004F: return; // RETURN;
        }

        private void FnQSTCHARC_08(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x02, 0x23), 0x0001);
            L0017: if (JumpNotEqual) goto L0035;
            L0019: ShowPortrait(party, 0x002D);
            L0026: ShowMessage(party, String0649); // You have passed the Trial of Chaos. A great reward is yours, if you but look for it.
            L0033: goto L004F;
            L0035: ShowPortrait(party, 0x002D);
            L0042: ShowMessage(party, String069E); // You have mastered our Challenge. Congratulations! Behold the door of Chaos. Only those pledged to Chaos should enter.
            L004F: return; // RETURN;
        }

        private void FnTELEPORT_09(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x02, 0x01, 0xF0, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELEPORT_0A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x04, 0x01, 0x87, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnHUTHDOOR_0B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetRace(party));
            L000C: if (JumpEqual) goto L001A;
            L000E: Compare(GetGuild(party), 0x0003);
            L0018: if (JumpNotEqual) goto L0065;
            L001A: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L0038: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L0056: ShowMessage(party, String0714); // The door is opened
            L0063: goto L008F;
            L0065: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x00);
            L0082: ShowMessage(party, String0727); // The door can be opened only by a Human or Thief.
            L008F: return; // RETURN;
        }

        private void FnORCLDOOR_0C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(party), 0x0001);
            L000D: if (JumpEqual) goto L001B;
            L000F: Compare(GetGuild(party), 0x0004);
            L0019: if (JumpNotEqual) goto L0066;
            L001B: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L0039: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L0057: ShowMessage(party, String0758); // The lock of the door opens as you step forward.
            L0064: goto L0090;
            L0066: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x00);
            L0083: ShowMessage(party, String0788); // The door can be opened only by an Orc or Cleric.
            L0090: return; // RETURN;
        }

        private void FnELBADOOR_0D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(party), 0x0002);
            L000D: if (JumpEqual) goto L001A;
            L000F: RefreshCompareFlags(GetGuild(party));
            L0018: if (JumpNotEqual) goto L0065;
            L001A: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L0038: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L0056: ShowMessage(party, String07B9); // The lock opens as you approach.
            L0063: goto L008F;
            L0065: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x00);
            L0082: ShowMessage(party, String07D9); // The door can be opened only by an Elf or Barbarian.
            L008F: return; // RETURN;
        }

        private void FnTRRADOOR_0E(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(party), 0x0003);
            L000D: if (JumpEqual) goto L001B;
            L000F: Compare(GetGuild(party), 0x0002);
            L0019: if (JumpNotEqual) goto L0066;
            L001B: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L0039: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L0057: ShowMessage(party, String080D); // The door unlocks when you test it.
            L0064: goto L0090;
            L0066: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x00);
            L0083: ShowMessage(party, String0830); // The door can be opened only by a Troll or Ranger.
            L0090: return; // RETURN;
        }

        private void FnDWKNDOOR_0F(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(party), 0x0004);
            L000D: if (JumpEqual) goto L001B;
            L000F: Compare(GetGuild(party), 0x0001);
            L0019: if (JumpNotEqual) goto L0066;
            L001B: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L0039: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L0057: ShowMessage(party, String0862); // The door opens as you advance.
            L0064: goto L0090;
            L0066: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x00);
            L0083: ShowMessage(party, String0881); // The door can be opened only by a Dwarf or Knight.
            L0090: return; // RETURN;
        }

        private void FnGNWIDOOR_10(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(party), 0x0005);
            L000D: if (JumpEqual) goto L001B;
            L000F: Compare(GetGuild(party), 0x0005);
            L0019: if (JumpNotEqual) goto L0066;
            L001B: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L0039: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L0057: ShowMessage(party, String08B3); // The door is opened.
            L0064: goto L0090;
            L0066: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x00);
            L0083: ShowMessage(party, String08C7); // The door can be opened only by a Gnome or Wizard.
            L0090: return; // RETURN;
        }

        private void FnHAITDOOR_11(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(party), 0x0006);
            L000D: if (JumpEqual) goto L001F;
            L000F: ax = HasItem(party, 0xD3);
            L001D: if (JumpEqual) goto L006A;
            L001F: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L003D: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L005B: ShowMessage(party, String08F9); // The door clicks open.
            L0068: goto L0094;
            L006A: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x00);
            L0087: ShowMessage(party, String090F); // The door can be opened only by a Halfling or by Cleowyn's Key.
            L0094: return; // RETURN;
        }

        private void FnGRITDOOR_12(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(party), 0x0007);
            L000D: if (JumpEqual) goto L001F;
            L000F: ax = HasItem(party, 0xD2);
            L001D: if (JumpEqual) goto L006A;
            L001F: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L003D: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L005B: ShowMessage(party, String094E); // The lock opens for you.
            L0068: goto L0094;
            L006A: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x00);
            L0087: ShowMessage(party, String0966); // The door can be opened only by a Gremlin or by Cleowyn's Lockpick.
            L0094: return; // RETURN;
        }

        private void FnOTGGDOOR_13(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String09A9); // A warning is on the door -
            L0010: RefreshCompareFlags(GetAlignment(party));
            L001A: if (JumpNotEqual) goto L002B;
            L001C: ShowMessage(party, String09C4); // 'Those honoring Harmony may safely enter.'
            L0029: goto L0038;
            L002B: ShowMessage(party, String09EF); // 'Woe to you who serve Chaos, if you dare cross the threshold.'
            L0038: return; // RETURN;
        }

        private void FnHEDHDOOR_14(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0A2E); // A warning is on the door -
            L0010: Compare(GetAlignment(party), 0x0001);
            L001B: if (JumpNotEqual) goto L002C;
            L001D: ShowMessage(party, String0A49); // 'Those honoring Chaos may safely enter.'
            L002A: goto L0039;
            L002C: ShowMessage(party, String0A72); // 'Woe to you who serve Harmony, if you dare cross the threshold.'
            L0039: return; // RETURN;
        }

        private void FnCHAOSDOR_15(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0AB3); // A sign is on the door -
            L0010: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L002E: Compare(GetAlignment(party), 0x0001);
            L0039: if (JumpNotEqual) goto L0068;
            L003B: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L0059: ShowMessage(party, String0ACB); // The way is clear for members of Chaos.
            L0066: goto L00C8;
            L0068: ModifyGold(party, 0xFFFF78BA);
            L007A: ModifyAttribute(party, 0x00, 0xFFFE);
            L008B: ModifyAttribute(party, 0x01, 0xFFFE);
            L009D: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L00BB: ShowMessage(party, String0AF2); // Those not sworn to Chaos have been duly chastised.
            L00C8: return; // RETURN;
        }

        private void FnHARMDOOR_16(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0B25); // A sign is on the door -
            L0010: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L002E: RefreshCompareFlags(GetAlignment(party));
            L0038: if (JumpNotEqual) goto L0067;
            L003A: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L0058: ShowMessage(party, String0B3D); // The way is clear for members of Harmony.
            L0065: goto L00C7;
            L0067: ModifyGold(party, 0xFFFF78BA);
            L0079: ModifyAttribute(party, 0x00, 0xFFFE);
            L008A: ModifyAttribute(party, 0x01, 0xFFFE);
            L009C: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L00BA: ShowMessage(party, String0B66); // Those not sworn to Harmony have been duly chastised.
            L00C7: return; // RETURN;
        }

        private void FnPAYAENC_17(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x02, 0x23), 0x0001);
            L0017: if (JumpEqual) goto L0025;
            L0019: RefreshCompareFlags(GetAlignment(party));
            L0023: if (JumpNotEqual) goto L0048;
            L0025: AddTreasure(party, 0x0064, 0x00, 0x00, 0x00, 0xCE, 0xB7);
            L0045: goto L00E1;
            L0048: SetState(party, 0x02, 0x23, 0x01);
            L005D: Compare(GetGuild(party), 0x0005);
            L0067: if (JumpEqual) goto L0075;
            L0069: Compare(GetGuild(party), 0x0004);
            L0073: if (JumpNotEqual) goto L0096;
            L0075: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x0E);
            L0094: goto L00E1;
            L0096: RefreshCompareFlags(GetGuild(party));
            L009F: if (JumpNotEqual) goto L00C2;
            L00A1: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x2A);
            L00C0: goto L00E1;
            L00C2: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x4B);
            L00E1: ShowMessage(party, String0B9B); // Rogues bar the way to Chaos.
            L00EE: Compare(PartyCount(party), 0x0001);
            L00F9: if (JumpNotEqual) goto L0134;
            L00FB: AddEncounter(party, 0x01, 0x26);
            L010D: AddEncounter(party, 0x02, 0x1C);
            L011F: AddEncounter(party, 0x06, 0x1D);
            L0131: goto L0209;
            L0134: Compare(PartyCount(party), 0x0002);
            L013F: if (JumpNotEqual) goto L019D;
            L0141: AddEncounter(party, 0x01, 0x26);
            L0153: AddEncounter(party, 0x02, 0x24);
            L0165: AddEncounter(party, 0x03, 0x1F);
            L0177: AddEncounter(party, 0x04, 0x1C);
            L0189: AddEncounter(party, 0x05, 0x1D);
            L019B: goto L0209;
            L019D: AddEncounter(party, 0x01, 0x26);
            L01AF: AddEncounter(party, 0x02, 0x26);
            L01C1: AddEncounter(party, 0x03, 0x24);
            L01D3: AddEncounter(party, 0x04, 0x24);
            L01E5: AddEncounter(party, 0x05, 0x21);
            L01F7: AddEncounter(party, 0x06, 0x1D);
            L0209: return; // RETURN;
        }

        private void FnPAYBENC_18(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x02, 0x22), 0x0001);
            L0017: if (JumpEqual) goto L0026;
            L0019: Compare(GetAlignment(party), 0x0001);
            L0024: if (JumpNotEqual) goto L0049;
            L0026: AddTreasure(party, 0x0064, 0x00, 0x00, 0x00, 0xCE, 0xB7);
            L0046: goto L011C;
            L0049: SetState(party, 0x02, 0x22, 0x01);
            L005E: RefreshCompareFlags(GetGuild(party));
            L0067: if (JumpEqual) goto L0075;
            L0069: Compare(GetGuild(party), 0x0004);
            L0073: if (JumpNotEqual) goto L0097;
            L0075: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x22);
            L0094: goto L011C;
            L0097: Compare(GetGuild(party), 0x0001);
            L00A1: if (JumpNotEqual) goto L00C4;
            L00A3: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x10);
            L00C2: goto L011C;
            L00C4: Compare(GetGuild(party), 0x0002);
            L00CE: if (JumpEqual) goto L00DC;
            L00D0: Compare(GetGuild(party), 0x0003);
            L00DA: if (JumpNotEqual) goto L00FD;
            L00DC: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x45);
            L00FB: goto L011C;
            L00FD: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x06);
            L011C: ShowMessage(party, String0BB8); // Rogues bar the way to Harmony.
            L0129: Compare(PartyCount(party), 0x0001);
            L0134: if (JumpNotEqual) goto L016F;
            L0136: AddEncounter(party, 0x01, 0x26);
            L0148: AddEncounter(party, 0x02, 0x1C);
            L015A: AddEncounter(party, 0x06, 0x1D);
            L016C: goto L0244;
            L016F: Compare(PartyCount(party), 0x0002);
            L017A: if (JumpNotEqual) goto L01D8;
            L017C: AddEncounter(party, 0x01, 0x26);
            L018E: AddEncounter(party, 0x02, 0x24);
            L01A0: AddEncounter(party, 0x03, 0x1F);
            L01B2: AddEncounter(party, 0x04, 0x1C);
            L01C4: AddEncounter(party, 0x05, 0x1D);
            L01D6: goto L0244;
            L01D8: AddEncounter(party, 0x01, 0x26);
            L01EA: AddEncounter(party, 0x02, 0x26);
            L01FC: AddEncounter(party, 0x03, 0x24);
            L020E: AddEncounter(party, 0x04, 0x24);
            L0220: AddEncounter(party, 0x05, 0x21);
            L0232: AddEncounter(party, 0x06, 0x1D);
            L0244: return; // RETURN;
        }

        private void FnBLESSMES_19(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsStateUnset(party, 0x02, 0x2F);
            L0016: if (JumpEqual) goto L0076;
            L0018: RefreshCompareFlags(GetRace(party));
            L0021: if (JumpEqual) goto L002F;
            L0023: Compare(GetGuild(party), 0x0003);
            L002D: if (JumpNotEqual) goto L0076;
            L002F: SetState(party, 0x02, 0x2F, 0x01);
            L0044: ModifyAttribute(party, 0x00, 0x0001);
            L0055: ModifyAttribute(party, 0x01, 0x0001);
            L0067: ShowMessage(party, String0BD7); // Blessed Human or Thief, you may continue the quest.
            L0074: goto L0098;
            L0076: SetState(party, 0x02, 0x2F, 0x01);
            L008B: ShowMessage(party, String0C0B); // The tapestry shows nothing of interest.
            L0098: return; // RETURN;
        }

        private void FnBLESSMES_1A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsStateUnset(party, 0x02, 0x30);
            L0016: if (JumpEqual) goto L0077;
            L0018: Compare(GetRace(party), 0x0001);
            L0022: if (JumpEqual) goto L0030;
            L0024: Compare(GetGuild(party), 0x0004);
            L002E: if (JumpNotEqual) goto L0077;
            L0030: SetState(party, 0x02, 0x30, 0x01);
            L0045: ModifyAttribute(party, 0x00, 0x0001);
            L0056: ModifyAttribute(party, 0x01, 0x0001);
            L0068: ShowMessage(party, String0C33); // Blessed Orc or Cleric, you may continue the quest.
            L0075: goto L0099;
            L0077: SetState(party, 0x02, 0x30, 0x01);
            L008C: ShowMessage(party, String0C66); // The tapestry shows a jumble of runes.
            L0099: return; // RETURN;
        }

        private void FnBLESSMES_1B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsStateUnset(party, 0x02, 0x31);
            L0016: if (JumpEqual) goto L0076;
            L0018: Compare(GetRace(party), 0x0002);
            L0022: if (JumpEqual) goto L002F;
            L0024: RefreshCompareFlags(GetGuild(party));
            L002D: if (JumpNotEqual) goto L0076;
            L002F: SetState(party, 0x02, 0x31, 0x01);
            L0044: ModifyAttribute(party, 0x00, 0x0001);
            L0055: ModifyAttribute(party, 0x01, 0x0001);
            L0067: ShowMessage(party, String0C8C); // Blessed Elf or Barbarian, you may continue the quest.
            L0074: goto L0098;
            L0076: SetState(party, 0x02, 0x31, 0x01);
            L008B: ShowMessage(party, String0CC2); // The tapestry is blank.
            L0098: return; // RETURN;
        }

        private void FnBLESSMES_1C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsStateUnset(party, 0x02, 0x32);
            L0016: if (JumpEqual) goto L0077;
            L0018: Compare(GetRace(party), 0x0003);
            L0022: if (JumpEqual) goto L0030;
            L0024: Compare(GetGuild(party), 0x0002);
            L002E: if (JumpNotEqual) goto L0077;
            L0030: SetState(party, 0x02, 0x32, 0x01);
            L0045: ModifyAttribute(party, 0x00, 0x0001);
            L0056: ModifyAttribute(party, 0x01, 0x0001);
            L0068: ShowMessage(party, String0CD9); // Blessed Troll or Ranger, you may continue the quest.
            L0075: goto L0099;
            L0077: SetState(party, 0x02, 0x32, 0x01);
            L008C: ShowMessage(party, String0D0E); // The tapestry is blank.
            L0099: return; // RETURN;
        }

        private void FnBLESSMES_1D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsStateUnset(party, 0x02, 0x33);
            L0016: if (JumpEqual) goto L0077;
            L0018: Compare(GetRace(party), 0x0004);
            L0022: if (JumpEqual) goto L0030;
            L0024: Compare(GetGuild(party), 0x0001);
            L002E: if (JumpNotEqual) goto L0077;
            L0030: SetState(party, 0x02, 0x33, 0x01);
            L0045: ModifyAttribute(party, 0x00, 0x0001);
            L0056: ModifyAttribute(party, 0x01, 0x0001);
            L0068: ShowMessage(party, String0D25); // Blessed Dwarf or Knight, you may continue the quest.
            L0075: goto L0099;
            L0077: SetState(party, 0x02, 0x33, 0x01);
            L008C: ShowMessage(party, String0D5A); // It is too dark to read the inscription.
            L0099: return; // RETURN;
        }

        private void FnBLESSMES_1E(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsStateUnset(party, 0x02, 0x34);
            L0016: if (JumpEqual) goto L0077;
            L0018: Compare(GetRace(party), 0x0005);
            L0022: if (JumpEqual) goto L0030;
            L0024: Compare(GetGuild(party), 0x0005);
            L002E: if (JumpNotEqual) goto L0077;
            L0030: SetState(party, 0x02, 0x34, 0x01);
            L0045: ModifyAttribute(party, 0x00, 0x0001);
            L0056: ModifyAttribute(party, 0x01, 0x0001);
            L0068: ShowMessage(party, String0D82); // Blessed Gnome or Wizard, you may continue the quest.
            L0075: goto L0099;
            L0077: SetState(party, 0x02, 0x34, 0x01);
            L008C: ShowMessage(party, String0DB7); // An inscription on the tapestry fades away as you draw near.
            L0099: return; // RETURN;
        }

        private void FnBLESSMES_1F(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsStateUnset(party, 0x02, 0x35);
            L0016: if (JumpEqual) goto L0087;
            L0018: Compare(GetRace(party), 0x0006);
            L0022: if (JumpEqual) goto L0034;
            L0024: ax = HasItem(party, 0xD3);
            L0032: if (JumpEqual) goto L0087;
            L0034: SetState(party, 0x02, 0x35, 0x01);
            L0049: ShowMessage(party, String0DF3); // Blessed Halfling! Blessed Key of Cleowyn! With either, the quest may continue.
            L0056: Compare(GetRace(party), 0x0006);
            L0060: if (JumpNotEqual) goto L0085;
            L0062: ModifyAttribute(party, 0x00, 0x0001);
            L0073: ModifyAttribute(party, 0x01, 0x0001);
            L0085: goto L00A9;
            L0087: SetState(party, 0x02, 0x35, 0x01);
            L009C: ShowMessage(party, String0E42); // The tapestry is empty.
            L00A9: return; // RETURN;
        }

        private void FnBLESSMES_20(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsStateUnset(party, 0x02, 0x36);
            L0016: if (JumpEqual) goto L0087;
            L0018: Compare(GetRace(party), 0x0007);
            L0022: if (JumpEqual) goto L0034;
            L0024: ax = HasItem(party, 0xD2);
            L0032: if (JumpEqual) goto L0087;
            L0034: SetState(party, 0x02, 0x36, 0x01);
            L0049: ShowMessage(party, String0E59); // Blessed Gremlin! Blessed Pick of Cleowyn! With either, the quest may continue.
            L0056: Compare(GetRace(party), 0x0007);
            L0060: if (JumpNotEqual) goto L0085;
            L0062: ModifyAttribute(party, 0x00, 0x0001);
            L0073: ModifyAttribute(party, 0x01, 0x0001);
            L0085: goto L00A9;
            L0087: SetState(party, 0x02, 0x36, 0x01);
            L009C: ShowMessage(party, String0EA8); // The tapestry once held a woven message.
            L00A9: return; // RETURN;
        }

        private void FnENDQSTDR_21(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x02, 0x22), 0x0001);
            L0017: if (JumpEqual) goto L002F;
            L0019: Compare(GetState(party, 0x02, 0x23), 0x0001);
            L002D: if (JumpNotEqual) goto L0078;
            L002F: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L004D: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L006B: ShowMessage(party, String0ED0); // You found a secret door!
            L0078: return; // RETURN;
        }

        private void FnQUESTBEN_22(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0EE9); // Reptilian bodies rise from the shadows.
            L0010: ax = HasItem(party, 0xEE);
            L001E: if (JumpEqual) goto L0041;
            L0020: AddTreasure(party, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L003F: goto L006D;
            L0041: ShowMessage(party, String0F11); // On the floor is a Chess Piece inscribed with the words - 'Property of Arnakkian Slowfoot.'
            L004E: AddTreasure(party, 0x0BB8, 0x00, 0x00, 0x00, 0x00, 0xEE);
            L006D: Compare(PartyCount(party), 0x0001);
            L0078: if (JumpNotEqual) goto L00A1;
            L007A: AddEncounter(party, 0x01, 0x28);
            L008C: AddEncounter(party, 0x02, 0x27);
            L009E: goto L0171;
            L00A1: Compare(PartyCount(party), 0x0002);
            L00AC: if (JumpEqual) goto L00BB;
            L00AE: Compare(PartyCount(party), 0x0003);
            L00B9: if (JumpNotEqual) goto L0105;
            L00BB: AddEncounter(party, 0x01, 0x27);
            L00CD: AddEncounter(party, 0x02, 0x27);
            L00DF: AddEncounter(party, 0x05, 0x28);
            L00F1: AddEncounter(party, 0x06, 0x28);
            L0103: goto L0171;
            L0105: AddEncounter(party, 0x01, 0x27);
            L0117: AddEncounter(party, 0x02, 0x27);
            L0129: AddEncounter(party, 0x03, 0x27);
            L013B: AddEncounter(party, 0x04, 0x27);
            L014D: AddEncounter(party, 0x05, 0x28);
            L015F: AddEncounter(party, 0x06, 0x28);
            L0171: return; // RETURN;
        }

        private void FnGOLDAENC_23(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsStateSet(party, 0x02, 0x24);
            L0016: if (JumpEqual) goto L0039;
            L0018: AddTreasure(party, 0x0064, 0x00, 0x00, 0x00, 0x00, 0xD1);
            L0037: goto L006E;
            L0039: AddTreasure(party, 0x0BB8, 0x00, 0x00, 0x00, 0xB7, 0xCF);
            L0059: SetState(party, 0x02, 0x24, 0x01);
            L006E: Compare(PartyCount(party), 0x0001);
            L0079: if (JumpNotEqual) goto L0090;
            L007B: AddEncounter(party, 0x01, 0x1C);
            L008D: goto L0172;
            L0090: Compare(PartyCount(party), 0x0002);
            L009B: if (JumpEqual) goto L00AA;
            L009D: Compare(PartyCount(party), 0x0003);
            L00A8: if (JumpNotEqual) goto L0106;
            L00AA: AddEncounter(party, 0x01, 0x1C);
            L00BC: AddEncounter(party, 0x02, 0x1C);
            L00CE: AddEncounter(party, 0x03, 0x1C);
            L00E0: AddEncounter(party, 0x04, 0x1C);
            L00F2: AddEncounter(party, 0x05, 0x1C);
            L0104: goto L0172;
            L0106: AddEncounter(party, 0x01, 0x1C);
            L0118: AddEncounter(party, 0x02, 0x1C);
            L012A: AddEncounter(party, 0x03, 0x1C);
            L013C: AddEncounter(party, 0x04, 0x1C);
            L014E: AddEncounter(party, 0x05, 0x1C);
            L0160: AddEncounter(party, 0x06, 0x1C);
            L0172: return; // RETURN;
        }

        private void FnWEAPAENC_24(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsStateSet(party, 0x02, 0x25);
            L0016: if (JumpEqual) goto L003A;
            L0018: AddTreasure(party, 0x0064, 0x00, 0x00, 0x00, 0xCC, 0xCE);
            L0038: goto L006F;
            L003A: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0xCC, 0x0D);
            L005A: SetState(party, 0x02, 0x25, 0x01);
            L006F: ShowMessage(party, String0F6C); // You are challenged to combat.
            L007C: Compare(PartyCount(party), 0x0001);
            L0087: if (JumpNotEqual) goto L00B0;
            L0089: AddEncounter(party, 0x01, 0x1D);
            L009B: AddEncounter(party, 0x02, 0x1D);
            L00AD: goto L016E;
            L00B0: Compare(PartyCount(party), 0x0002);
            L00BB: if (JumpEqual) goto L00CA;
            L00BD: Compare(PartyCount(party), 0x0003);
            L00C8: if (JumpNotEqual) goto L0114;
            L00CA: AddEncounter(party, 0x01, 0x1D);
            L00DC: AddEncounter(party, 0x02, 0x1D);
            L00EE: AddEncounter(party, 0x03, 0x1D);
            L0100: AddEncounter(party, 0x04, 0x1D);
            L0112: goto L016E;
            L0114: AddEncounter(party, 0x01, 0x1D);
            L0126: AddEncounter(party, 0x02, 0x1D);
            L0138: AddEncounter(party, 0x03, 0x1D);
            L014A: AddEncounter(party, 0x04, 0x1D);
            L015C: AddEncounter(party, 0x05, 0x1D);
            L016E: return; // RETURN;
        }

        private void FnMAGICENC_25(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x02, 0x26), 0x0001);
            L0017: if (JumpNotEqual) goto L003A;
            L0019: AddTreasure(party, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L0038: goto L006E;
            L003A: AddTreasure(party, 0x0384, 0x00, 0x00, 0x00, 0x00, 0xB3);
            L0059: SetState(party, 0x02, 0x26, 0x01);
            L006E: ShowMessage(party, String0F8A); // Ferocious enemies stop you.
            L007B: Compare(PartyCount(party), 0x0001);
            L0086: if (JumpEqual) goto L0095;
            L0088: Compare(PartyCount(party), 0x0002);
            L0093: if (JumpNotEqual) goto L00CE;
            L0095: AddEncounter(party, 0x01, 0x1E);
            L00A7: AddEncounter(party, 0x02, 0x1E);
            L00B9: AddEncounter(party, 0x03, 0x1E);
            L00CB: goto L01A3;
            L00CE: Compare(PartyCount(party), 0x0003);
            L00D9: if (JumpNotEqual) goto L0137;
            L00DB: AddEncounter(party, 0x01, 0x1E);
            L00ED: AddEncounter(party, 0x02, 0x1E);
            L00FF: AddEncounter(party, 0x03, 0x1E);
            L0111: AddEncounter(party, 0x04, 0x1E);
            L0123: AddEncounter(party, 0x05, 0x1E);
            L0135: goto L01A3;
            L0137: AddEncounter(party, 0x01, 0x1E);
            L0149: AddEncounter(party, 0x02, 0x1E);
            L015B: AddEncounter(party, 0x03, 0x1E);
            L016D: AddEncounter(party, 0x04, 0x1E);
            L017F: AddEncounter(party, 0x05, 0x1E);
            L0191: AddEncounter(party, 0x06, 0x1E);
            L01A3: return; // RETURN;
        }

        private void FnQUESTAEN_26(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0xF9);
            L0011: if (JumpEqual) goto L0041;
            L0013: AddTreasure(party, 0x0384, 0x00, 0x00, 0x00, 0x00, 0xB0);
            L0032: ShowMessage(party, String0FA6); // Elf Rangers await you.
            L003F: goto L007E;
            L0041: AddTreasure(party, 0x0FA0, 0x00, 0x00, 0x00, 0x00, 0xF9);
            L0060: AddExperience(party, 0x000001F4);
            L0071: ShowMessage(party, String0FBD); // An Elf Ranger holds the King's Pass.
            L007E: Compare(PartyCount(party), 0x0001);
            L0089: if (JumpNotEqual) goto L00B2;
            L008B: AddEncounter(party, 0x01, 0x1F);
            L009D: AddEncounter(party, 0x02, 0x1F);
            L00AF: goto L0187;
            L00B2: Compare(PartyCount(party), 0x0002);
            L00BD: if (JumpNotEqual) goto L011B;
            L00BF: AddEncounter(party, 0x01, 0x1F);
            L00D1: AddEncounter(party, 0x02, 0x1F);
            L00E3: AddEncounter(party, 0x03, 0x1F);
            L00F5: AddEncounter(party, 0x04, 0x1F);
            L0107: AddEncounter(party, 0x05, 0x1F);
            L0119: goto L0187;
            L011B: AddEncounter(party, 0x01, 0x1F);
            L012D: AddEncounter(party, 0x02, 0x1F);
            L013F: AddEncounter(party, 0x03, 0x1F);
            L0151: AddEncounter(party, 0x04, 0x1F);
            L0163: AddEncounter(party, 0x05, 0x1F);
            L0175: AddEncounter(party, 0x06, 0x1F);
            L0187: return; // RETURN;
        }

        private void FnITEMAENC_27(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x02, 0x28), 0x0001);
            L0017: if (JumpNotEqual) goto L003A;
            L0019: AddTreasure(party, 0x012C, 0x00, 0x00, 0x00, 0x00, 0xB6);
            L0038: goto L006F;
            L003A: AddTreasure(party, 0x04B0, 0x00, 0x00, 0x00, 0xCF, 0xAA);
            L005A: SetState(party, 0x02, 0x28, 0x01);
            L006F: ShowMessage(party, String0FE2); // Proud knights dispute your progress.
            L007C: Compare(PartyCount(party), 0x0001);
            L0087: if (JumpEqual) goto L0096;
            L0089: Compare(PartyCount(party), 0x0002);
            L0094: if (JumpNotEqual) goto L00CE;
            L0096: AddEncounter(party, 0x01, 0x20);
            L00A8: AddEncounter(party, 0x02, 0x20);
            L00BA: AddEncounter(party, 0x03, 0x20);
            L00CC: goto L013A;
            L00CE: AddEncounter(party, 0x01, 0x20);
            L00E0: AddEncounter(party, 0x02, 0x20);
            L00F2: AddEncounter(party, 0x03, 0x20);
            L0104: AddEncounter(party, 0x04, 0x20);
            L0116: AddEncounter(party, 0x05, 0x20);
            L0128: AddEncounter(party, 0x06, 0x20);
            L013A: return; // RETURN;
        }

        private void FnGOLDBENC_28(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x02, 0x29), 0x0001);
            L0017: if (JumpNotEqual) goto L003A;
            L0019: AddTreasure(party, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xCB);
            L0038: goto L006F;
            L003A: AddTreasure(party, 0x2710, 0x00, 0x00, 0x00, 0xB0, 0xCD);
            L005A: SetState(party, 0x02, 0x29, 0x01);
            L006F: ShowMessage(party, String1007); // Strong enemies bar your way.
            L007C: Compare(PartyCount(party), 0x0001);
            L0087: if (JumpEqual) goto L0096;
            L0089: Compare(PartyCount(party), 0x0002);
            L0094: if (JumpNotEqual) goto L00E0;
            L0096: AddEncounter(party, 0x01, 0x21);
            L00A8: AddEncounter(party, 0x02, 0x21);
            L00BA: AddEncounter(party, 0x03, 0x21);
            L00CC: AddEncounter(party, 0x04, 0x21);
            L00DE: goto L014C;
            L00E0: AddEncounter(party, 0x01, 0x22);
            L00F2: AddEncounter(party, 0x02, 0x22);
            L0104: AddEncounter(party, 0x03, 0x22);
            L0116: AddEncounter(party, 0x04, 0x22);
            L0128: AddEncounter(party, 0x05, 0x21);
            L013A: AddEncounter(party, 0x06, 0x21);
            L014C: return; // RETURN;
        }

        private void FnDRKEYENC_29(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0xC3);
            L0011: if (JumpEqual) goto L0041;
            L0013: AddTreasure(party, 0x0320, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L0032: ShowMessage(party, String1024); // There is nothing of interest here.
            L003F: goto L006E;
            L0041: AddTreasure(party, 0x0000, 0x00, 0x00, 0x50, 0x50, 0xC3);
            L0061: ShowMessage(party, String1047); // You see a lockpick on the floor.
            L006E: ShowMessage(party, String1068); // Gallants challenge you.
            L007B: Compare(PartyCount(party), 0x0001);
            L0086: if (JumpNotEqual) goto L00AF;
            L0088: AddEncounter(party, 0x01, 0x1A);
            L009A: AddEncounter(party, 0x02, 0x1B);
            L00AC: goto L01A3;
            L00AF: Compare(PartyCount(party), 0x0002);
            L00BA: if (JumpEqual) goto L00C9;
            L00BC: Compare(PartyCount(party), 0x0003);
            L00C7: if (JumpNotEqual) goto L0137;
            L00C9: AddEncounter(party, 0x01, 0x1B);
            L00DB: AddEncounter(party, 0x02, 0x1B);
            L00ED: AddEncounter(party, 0x03, 0x1B);
            L00FF: AddEncounter(party, 0x04, 0x1B);
            L0111: AddEncounter(party, 0x05, 0x1A);
            L0123: AddEncounter(party, 0x06, 0x1A);
            L0135: goto L01A3;
            L0137: AddEncounter(party, 0x01, 0x1C);
            L0149: AddEncounter(party, 0x02, 0x1C);
            L015B: AddEncounter(party, 0x03, 0x1A);
            L016D: AddEncounter(party, 0x04, 0x1A);
            L017F: AddEncounter(party, 0x05, 0x1C);
            L0191: AddEncounter(party, 0x06, 0x1C);
            L01A3: return; // RETURN;
        }

        private void FnSPKEYDOO_2A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(party, 0xE1, 0xE1);
            L0016: if (JumpNotEqual) goto L002D;
            L0018: ax = HasUsedItem(party, 0xE2, 0xE2);
            L002B: if (JumpEqual) goto L0078;
            L002D: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L004B: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L0069: ShowMessage(party, String1080); // The key opens the door.
            L0076: goto L00A2;
            L0078: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x00);
            L0095: ShowMessage(party, String1098); // The door is locked and requires a special key.
            L00A2: return; // RETURN;
        }

        private void FnITEMBENC_2C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x02, 0x2A), 0x0001);
            L0017: if (JumpNotEqual) goto L003A;
            L0019: AddTreasure(party, 0x001E, 0x00, 0x00, 0x00, 0x00, 0xB1);
            L0038: goto L006F;
            L003A: AddTreasure(party, 0x01F4, 0x00, 0x00, 0x00, 0xB1, 0x55);
            L005A: SetState(party, 0x02, 0x2A, 0x01);
            L006F: ShowMessage(party, String10C7); // Fierce opponents bar your way.
            L007C: Compare(PartyCount(party), 0x0001);
            L0087: if (JumpNotEqual) goto L00C2;
            L0089: AddEncounter(party, 0x01, 0x25);
            L009B: AddEncounter(party, 0x02, 0x26);
            L00AD: AddEncounter(party, 0x04, 0x25);
            L00BF: goto L01B6;
            L00C2: Compare(PartyCount(party), 0x0002);
            L00CD: if (JumpEqual) goto L00DC;
            L00CF: Compare(PartyCount(party), 0x0003);
            L00DA: if (JumpNotEqual) goto L014A;
            L00DC: AddEncounter(party, 0x01, 0x26);
            L00EE: AddEncounter(party, 0x02, 0x26);
            L0100: AddEncounter(party, 0x03, 0x25);
            L0112: AddEncounter(party, 0x04, 0x25);
            L0124: AddEncounter(party, 0x05, 0x26);
            L0136: AddEncounter(party, 0x06, 0x26);
            L0148: goto L01B6;
            L014A: AddEncounter(party, 0x01, 0x26);
            L015C: AddEncounter(party, 0x02, 0x26);
            L016E: AddEncounter(party, 0x03, 0x26);
            L0180: AddEncounter(party, 0x04, 0x26);
            L0192: AddEncounter(party, 0x05, 0x25);
            L01A4: AddEncounter(party, 0x06, 0x25);
            L01B6: return; // RETURN;
        }

        private void FnGOLDPILE_2D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x02, 0x2B), 0x0001);
            L0017: if (JumpNotEqual) goto L0028;
            L0019: ShowMessage(party, String10E6); // This area has been looted.
            L0026: goto L005B;
            L0028: ModifyGold(party, 0x2EE0);
            L0039: SetState(party, 0x02, 0x2B, 0x01);
            L004E: ShowMessage(party, String1101); // You find 12000 Gold Pieces on the floor.
            L005B: return; // RETURN;
        }

        private void FnSTRMNSTR_2E(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(party), 0x0001);
            L000E: if (JumpNotEqual) goto L0037;
            L0010: AddEncounter(party, 0x01, 0x27);
            L0022: AddEncounter(party, 0x02, 0x06);
            L0034: goto L0119;
            L0037: Compare(PartyCount(party), 0x0002);
            L0042: if (JumpEqual) goto L0051;
            L0044: Compare(PartyCount(party), 0x0003);
            L004F: if (JumpNotEqual) goto L00AD;
            L0051: AddEncounter(party, 0x01, 0x27);
            L0063: AddEncounter(party, 0x02, 0x1B);
            L0075: AddEncounter(party, 0x03, 0x27);
            L0087: AddEncounter(party, 0x04, 0x1B);
            L0099: AddEncounter(party, 0x05, 0x06);
            L00AB: goto L0119;
            L00AD: AddEncounter(party, 0x01, 0x27);
            L00BF: AddEncounter(party, 0x02, 0x27);
            L00D1: AddEncounter(party, 0x03, 0x1B);
            L00E3: AddEncounter(party, 0x04, 0x1B);
            L00F5: AddEncounter(party, 0x05, 0x06);
            L0107: AddEncounter(party, 0x06, 0x06);
            L0119: return; // RETURN;
        }

        private void FnTUFMNSTR_2F(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String112A); // Your way is blocked.
            L0010: Compare(PartyCount(party), 0x0001);
            L001B: if (JumpEqual) goto L002A;
            L001D: Compare(PartyCount(party), 0x0002);
            L0028: if (JumpNotEqual) goto L0074;
            L002A: AddEncounter(party, 0x01, 0x18);
            L003C: AddEncounter(party, 0x02, 0x17);
            L004E: AddEncounter(party, 0x03, 0x17);
            L0060: AddEncounter(party, 0x04, 0x18);
            L0072: goto L00E0;
            L0074: AddEncounter(party, 0x01, 0x18);
            L0086: AddEncounter(party, 0x02, 0x18);
            L0098: AddEncounter(party, 0x03, 0x17);
            L00AA: AddEncounter(party, 0x04, 0x17);
            L00BC: AddEncounter(party, 0x05, 0x18);
            L00CE: AddEncounter(party, 0x06, 0x18);
            L00E0: return; // RETURN;
        }

        private void FnGATEMESA_3A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String113F); // The gateway leads to THE RUNE ROOM.
            L0010: return; // RETURN;
        }

        private void FnGATEMESB_3B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1163); // The gateway leads to THE MAUSOLEUM.
            L0010: return; // RETURN;
        }

        private void FnSTRSMESS_3C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1187); // Stairs past the south gateway lead down.
            L0010: return; // RETURN;
        }

        private void FnTELEMESA_3D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String11B0); // There is a teleport in the east wall.
            L0010: return; // RETURN;
        }

        private void FnTELEMESB_3E(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String11D6); // There is a teleport in the west wall.
            L0010: return; // RETURN;
        }

    }
}
