#pragma warning disable
using System.Collections.Generic;
using XPT.Legacy;
using XPT.Legacy.Entities;
using XPT.Legacy.Yserbius;

namespace XPT.Legacy.Maps {
    class YserMap02 : AMapScripted {
        protected override int MapIndex => 2;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap02() {
            MapEvent01 = FnTOMINES_01;
            MapEvent02 = FnTOTREAS_02;
            MapEvent03 = FnKEYDOOR_03;
            MapEvent04 = FnKEYMESSG_04;
            MapEvent05 = FnLKPKDOOR_05;
            MapEvent06 = FnLKPKMESG_06;
            MapEvent07 = FnSTRDOOR_07;
            MapEvent08 = FnSTRMESSG_08;
            MapEvent09 = FnGOLDENC_09;
            MapEvent0A = FnSTAIRS_0A;
            MapEvent0B = FnPALKEYEN_0B;
            MapEvent0C = FnTELEPORT_0C;
            MapEvent0D = FnLOWMNSTR_0D;
            MapEvent0E = FnMODMNSTR_0E;
            MapEvent0F = FnSTRMNST_0F;
            MapEvent10 = FnBADMNSTR_10;
            MapEvent11 = FnMESSAGEA_11;
            MapEvent12 = FnMESSAGEB_12;
            MapEvent13 = FnTELEMESS_13;
            MapEvent14 = FnSTRSMESS_14;
            MapEvent15 = FnSTRSTLPT_15;
            MapEvent16 = FnREGDOOR_16;
            MapEvent17 = FnNPCCHATA_17;
            MapEvent18 = FnNPCCHATB_18;
            MapEvent19 = FnNPCCHATC_19;
            MapEvent1A = FnNPCCHATD_1A;
            MapEvent1B = FnNPCCHATE_1B;
            MapEvent1C = FnKEYDRA_1C;
            MapEvent1D = FnLKPKDRA_1D;
            MapEvent1E = FnSTRNGDRA_1E;
            MapEvent1F = FnREGDORA_1F;
        }
        
        // === Strings ================================================
        private const string String03FC = "Cleowyn's Key has unlocked the door.";
        private const string String0421 = "The door is locked.  Something special is needed to open this door.";
        private const string String0465 = "The tapestry shows a message in runes...";
        private const string String048E = "A certain Key unlocks my series of doors.";
        private const string String04B8 = "Cleowyn's Lockpick has unlocked the door.";
        private const string String04E2 = "The door is locked.";
        private const string String04F6 = "There are runes on the tapestry...";
        private const string String0519 = "A certain Lockpick opens my series of doors.";
        private const string String0546 = "The door has been forced open.";
        private const string String0565 = "The door is currently impassable.";
        private const string String0587 = "The tapestry has runes...";
        private const string String05A1 = "A hero of strength may open my series of doors.";
        private const string String05D1 = "Aside from angry Rogues, the room is empty.";
        private const string String05FD = "A Rogue drops gold coins on the floor as the villains draw their weapons.";
        private const string String0647 = "The room is empty. Almost.";
        private const string String0662 = "A Key in the shape of a Palace lies in a corner, if you can get to it.";
        private const string String06A9 = "You encounter Rogues.";
        private const string String06BF = "If you are skilled enough, you may find teleports that speed your way to various levels of this dungeon.";
        private const string String0728 = "The Rogues snarl at you.";
        private const string String0741 = "They attack!";
        private const string String074E = "This gateway leads to THE MINES.";
        private const string String076F = "This gateway leads to THE HALL OF DOORS.";
        private const string String0798 = "There is a teleport to the north.";
        private const string String07BA = "There are stairs to the west through the gateway.";
        private const string String07EC = "As you open the door, you hear locks click throughout the dungeon.";
        private const string String082F = "The door is currently impassable.";
        private const string String0851 = "You encounter an Elf Ranger.";
        private const string String086E = "You must solve the mystery of the linked Vestibule doors to continue farther down into the dungeon.";
        private const string String08D2 = "The Elf Ranger decides you are not worthy of his time and leaves.";
        private const string String0914 = "You encounter a Human Wizard.";
        private const string String0932 = "Centuries ago, Twinion was a thriving port town, ruled by the Galabryan dynasty. The kings welcomed all races and Guilds to the island. When the volcano Yserbius erupted, it almost buried Twinion under lava. If only we could find some way off this island!";
        private const string String0A32 = "The Human Wizard falls into a deep trance and refuses to talk.";
        private const string String0A71 = "You encounter a Gremlin Thief.";
        private const string String0A90 = "King Cleowyn created a clever maze of squares to discourage thieves and invaders. Mind you, no invaders ever thought Twinion rich enough to be worth their effort.";
        private const string String0B33 = "The Gremlin Thief slips into a shadow and disappears.";
        private const string String0B69 = "You encounter an Orc Knight.";
        private const string String0B86 = "The richness of fine armor and weapons in this dungeon baffles me. I've heard rumors that skilled dwarfs once crafted such armory, but the rogue dwarfs you encounter nowadays have no talent for such expert metallurgy.";
        private const string String0C60 = "The Orc Knight smiles politely and shoos you away.";
        private const string String0C93 = "You encounter an Elf Cleric.";
        private const string String0CB0 = "I have visited King Cleowyn's throne room, and what a disappointment it was. Not much treasure there and too many dead things. Perhaps I missed something.";
        private const string String0D4B = "The Elf Cleric is too engrossed in his prayers to talk with you.";
        private const string String0D8C = "Cleowyn's Key unlocks the door.";
        private const string String0DAC = "The door is locked.";
        private const string String0DC0 = "Cleowyn's Lockpick has unlocked the door.";
        private const string String0DEA = "The door is locked.  It looks like something special is needed to open this door.";
        private const string String0E3C = "You manage to force open the door.";
        private const string String0E5F = "The door is currently impassable.";
        private const string String0E81 = "As you open the door, you hear locks click throughout the dungeon.";
        private const string String0EC4 = "The door is currently impassable.";
        
        // === Functions ================================================
        private void FnTOMINES_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x01, 0x02, 0x7F, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnTOTREAS_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x01, 0x04, 0x05, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnKEYDOOR_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, FlagTypeDungeon, FlagVestibuleUnlockType), 0x0001);
            L0016: if (JumpNotEqual) goto L0063;
            L0018: ShowMessage(player, String03FC); // Cleowyn's Key has unlocked the door.
            L0025: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0043: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0061: goto L008D;
            L0063: ShowMessage(player, String0421); // The door is locked.  Something special is needed to open this door.
            L0070: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L008D: return; // RETURN;
        }

        private void FnKEYMESSG_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0465); // The tapestry shows a message in runes...
            L0010: ShowRunes(player, String048E); // A certain Key unlocks my series of doors.
            L001D: return; // RETURN;
        }

        private void FnLKPKDOOR_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, FlagTypeDungeon, FlagVestibuleUnlockType), 0x0002);
            L0016: if (JumpNotEqual) goto L0063;
            L0018: ShowMessage(player, String04B8); // Cleowyn's Lockpick has unlocked the door.
            L0025: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0043: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0061: goto L008D;
            L0063: ShowMessage(player, String04E2); // The door is locked.
            L0070: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L008D: return; // RETURN;
        }

        private void FnLKPKMESG_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String04F6); // There are runes on the tapestry...
            L0010: ShowRunes(player, String0519); // A certain Lockpick opens my series of doors.
            L001D: return; // RETURN;
        }

        private void FnSTRDOOR_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, FlagTypeDungeon, FlagVestibuleUnlockType), 0x0003);
            L0016: if (JumpNotEqual) goto L0063;
            L0018: ShowMessage(player, String0546); // The door has been forced open.
            L0025: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0043: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0061: goto L008D;
            L0063: ShowMessage(player, String0565); // The door is currently impassable.
            L0070: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L008D: return; // RETURN;
        }

        private void FnSTRMESSG_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0587); // The tapestry has runes...
            L0010: ShowRunes(player, String05A1); // A hero of strength may open my series of doors.
            L001D: return; // RETURN;
        }

        private void FnGOLDENC_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, FlagTypeDungeon, FlagVestibuleFoundCoins), 0x0001);
            L0017: if (JumpNotEqual) goto L0047;
            L0019: ShowMessage(player, String05D1); // Aside from angry Rogues, the room is empty.
            L0026: AddTreasure(player, 0x0014, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L0045: goto L0088;
            L0047: AddTreasure(player, 0x01F4, 0x00, 0x00, 0x00, 0x00, 0xCE);
            L0066: SetFlag(player, FlagTypeDungeon, FlagVestibuleFoundCoins, 0x01);
            L007B: ShowMessage(player, String05FD); // A Rogue drops gold coins on the floor as the villains draw their weapons.
            L0088: Compare(PartyCount(player), 0x0001);
            L0093: if (JumpEqual) goto L00A2;
            L0095: Compare(PartyCount(player), 0x0002);
            L00A0: if (JumpNotEqual) goto L00B6;
            L00A2: AddEncounter(player, 0x01, 0x1A);
            L00B4: goto L00FE;
            L00B6: AddEncounter(player, 0x01, 0x1C);
            L00C8: AddEncounter(player, 0x02, 0x1A);
            L00DA: AddEncounter(player, 0x03, 0x19);
            L00EC: AddEncounter(player, 0x04, 0x1B);
            L00FE: return; // RETURN;
        }

        private void FnSTAIRS_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x02, 0x02, 0x01, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnPALKEYEN_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xD9);
            L0011: if (JumpEqual) goto L0042;
            L0013: AddTreasure(player, 0x01F4, 0x00, 0x00, 0x00, 0xBC, 0xCE);
            L0033: ShowMessage(player, String0647); // The room is empty. Almost.
            L0040: goto L006E;
            L0042: AddTreasure(player, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0xD9);
            L0061: ShowMessage(player, String0662); // A Key in the shape of a Palace lies in a corner, if you can get to it.
            L006E: Compare(PartyCount(player), 0x0001);
            L0079: if (JumpNotEqual) goto L0090;
            L007B: AddEncounter(player, 0x01, 0x21);
            L008D: goto L0151;
            L0090: Compare(PartyCount(player), 0x0002);
            L009B: if (JumpNotEqual) goto L00C4;
            L009D: AddEncounter(player, 0x01, 0x25);
            L00AF: AddEncounter(player, 0x02, 0x21);
            L00C1: goto L0151;
            L00C4: Compare(PartyCount(player), 0x0003);
            L00CF: if (JumpNotEqual) goto L0109;
            L00D1: AddEncounter(player, 0x01, 0x21);
            L00E3: AddEncounter(player, 0x02, 0x21);
            L00F5: AddEncounter(player, 0x04, 0x25);
            L0107: goto L0151;
            L0109: AddEncounter(player, 0x01, 0x25);
            L011B: AddEncounter(player, 0x02, 0x25);
            L012D: AddEncounter(player, 0x03, 0x21);
            L013F: AddEncounter(player, 0x04, 0x21);
            L0151: return; // RETURN;
        }

        private void FnTELEPORT_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x04, 0x01, 0xF0, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnLOWMNSTR_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String06A9); // You encounter Rogues.
            L0010: Compare(GetRandom(0x000F), 0x0006);
            L0020: if (JumpAbove) goto L0050;
            L0022: AddTreasure(player, 0x01F4, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L0041: ShowMessage(player, String06BF); // If you are skilled enough, you may find teleports that speed your way to various levels of this dungeon.
            L004E: goto L008A;
            L0050: ShowMessage(player, String0728); // The Rogues snarl at you.
            L005D: ShowMessage(player, String0741); // They attack!
            L006A: AddTreasure(player, 0x03E8, 0x00, 0x00, 0x00, 0xBD, 0x03);
            L008A: Compare(PartyCount(player), 0x0001);
            L0095: if (JumpEqual) goto L00A4;
            L0097: Compare(PartyCount(player), 0x0002);
            L00A2: if (JumpNotEqual) goto L00CA;
            L00A4: AddEncounter(player, 0x01, 0x1B);
            L00B6: AddEncounter(player, 0x02, 0x1A);
            L00C8: goto L0112;
            L00CA: AddEncounter(player, 0x01, 0x1C);
            L00DC: AddEncounter(player, 0x02, 0x1A);
            L00EE: AddEncounter(player, 0x03, 0x19);
            L0100: AddEncounter(player, 0x04, 0x1B);
            L0112: return; // RETURN;
        }

        private void FnMODMNSTR_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0024;
            L0010: AddEncounter(player, 0x01, 0x1D);
            L0022: goto L009F;
            L0024: Compare(PartyCount(player), 0x0002);
            L002F: if (JumpNotEqual) goto L0057;
            L0031: AddEncounter(player, 0x01, 0x1D);
            L0043: AddEncounter(player, 0x02, 0x1E);
            L0055: goto L009F;
            L0057: AddEncounter(player, 0x01, 0x20);
            L0069: AddEncounter(player, 0x02, 0x1F);
            L007B: AddEncounter(player, 0x03, 0x1C);
            L008D: AddEncounter(player, 0x04, 0x1D);
            L009F: return; // RETURN;
        }

        private void FnSTRMNST_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0025;
            L0010: AddEncounter(player, 0x01, 0x21);
            L0022: goto L010A;
            L0025: Compare(PartyCount(player), 0x0002);
            L0030: if (JumpNotEqual) goto L0059;
            L0032: AddEncounter(player, 0x01, 0x21);
            L0044: AddEncounter(player, 0x02, 0x22);
            L0056: goto L010A;
            L0059: Compare(PartyCount(player), 0x0003);
            L0064: if (JumpNotEqual) goto L00B0;
            L0066: AddEncounter(player, 0x01, 0x21);
            L0078: AddEncounter(player, 0x02, 0x21);
            L008A: AddEncounter(player, 0x03, 0x23);
            L009C: AddEncounter(player, 0x04, 0x23);
            L00AE: goto L010A;
            L00B0: AddEncounter(player, 0x01, 0x24);
            L00C2: AddEncounter(player, 0x02, 0x24);
            L00D4: AddEncounter(player, 0x03, 0x23);
            L00E6: AddEncounter(player, 0x04, 0x23);
            L00F8: AddEncounter(player, 0x05, 0x22);
            L010A: return; // RETURN;
        }

        private void FnBADMNSTR_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0037;
            L0010: AddEncounter(player, 0x01, 0x26);
            L0022: AddEncounter(player, 0x02, 0x26);
            L0034: goto L0164;
            L0037: Compare(PartyCount(player), 0x0002);
            L0042: if (JumpNotEqual) goto L008F;
            L0044: AddEncounter(player, 0x01, 0x25);
            L0056: AddEncounter(player, 0x02, 0x25);
            L0068: AddEncounter(player, 0x03, 0x27);
            L007A: AddEncounter(player, 0x04, 0x27);
            L008C: goto L0164;
            L008F: Compare(PartyCount(player), 0x0003);
            L009A: if (JumpNotEqual) goto L00F8;
            L009C: AddEncounter(player, 0x01, 0x26);
            L00AE: AddEncounter(player, 0x02, 0x26);
            L00C0: AddEncounter(player, 0x03, 0x27);
            L00D2: AddEncounter(player, 0x04, 0x27);
            L00E4: AddEncounter(player, 0x05, 0x28);
            L00F6: goto L0164;
            L00F8: AddEncounter(player, 0x01, 0x28);
            L010A: AddEncounter(player, 0x02, 0x28);
            L011C: AddEncounter(player, 0x03, 0x27);
            L012E: AddEncounter(player, 0x04, 0x27);
            L0140: AddEncounter(player, 0x05, 0x26);
            L0152: AddEncounter(player, 0x06, 0x25);
            L0164: return; // RETURN;
        }

        private void FnMESSAGEA_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, FlagTypeDungeon, FlagVestibuleUnlockType, 0x00);
            L0016: ShowMessage(player, String074E); // This gateway leads to THE MINES.
            L0023: return; // RETURN;
        }

        private void FnMESSAGEB_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, FlagTypeDungeon, FlagVestibuleUnlockType, 0x00);
            L0016: ShowMessage(player, String076F); // This gateway leads to THE HALL OF DOORS.
            L0023: return; // RETURN;
        }

        private void FnTELEMESS_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, FlagTypeDungeon, FlagVestibuleUnlockType, 0x03);
            L0017: ShowMessage(player, String0798); // There is a teleport to the north.
            L0024: return; // RETURN;
        }

        private void FnSTRSMESS_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, FlagTypeDungeon, FlagVestibuleUnlockType, 0x01);
            L0017: ShowMessage(player, String07BA); // There are stairs to the west through the gateway.
            L0024: return; // RETURN;
        }

        private void FnSTRSTLPT_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x02, 0x02, 0x01, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnREGDOOR_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, FlagTypeDungeon, FlagVestibuleUnlockType), 0x0004);
            L0016: if (JumpNotEqual) goto L0063;
            L0018: ShowMessage(player, String07EC); // As you open the door, you hear locks click throughout the dungeon.
            L0025: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0043: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0061: goto L008D;
            L0063: ShowMessage(player, String082F); // The door is currently impassable.
            L0070: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L008D: return; // RETURN;
        }

        private void FnNPCCHATA_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0851); // You encounter an Elf Ranger.
            L0010: ShowPortrait(player, 0x001F);
            L001D: Compare(GetRandom(0x000F), 0x000B);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, String086E); // You must solve the mystery of the linked Vestibule doors to continue farther down into the dungeon.
            L003C: goto L004B;
            L003E: ShowMessage(player, String08D2); // The Elf Ranger decides you are not worthy of his time and leaves.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATB_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0914); // You encounter a Human Wizard.
            L0010: ShowPortrait(player, 0x002B);
            L001D: Compare(GetRandom(0x000F), 0x0009);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, String0932); // Centuries ago, Twinion was a thriving port town, ruled by the Galabryan dynasty. The kings welcomed all races and Guilds to the island. When the volcano Yserbius erupted, it almost buried Twinion under lava. If only we could find some way off this island!
            L003C: goto L004B;
            L003E: ShowMessage(player, String0A32); // The Human Wizard falls into a deep trance and refuses to talk.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATC_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0A71); // You encounter a Gremlin Thief.
            L0010: ShowPortrait(player, 0x0026);
            L001D: Compare(GetRandom(0x000F), 0x000A);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, String0A90); // King Cleowyn created a clever maze of squares to discourage thieves and invaders. Mind you, no invaders ever thought Twinion rich enough to be worth their effort.
            L003C: goto L004B;
            L003E: ShowMessage(player, String0B33); // The Gremlin Thief slips into a shadow and disappears.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATD_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0B69); // You encounter an Orc Knight.
            L0010: ShowPortrait(player, 0x001A);
            L001D: Compare(GetRandom(0x000F), 0x0008);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, String0B86); // The richness of fine armor and weapons in this dungeon baffles me. I've heard rumors that skilled dwarfs once crafted such armory, but the rogue dwarfs you encounter nowadays have no talent for such expert metallurgy.
            L003C: goto L004B;
            L003E: ShowMessage(player, String0C60); // The Orc Knight smiles politely and shoos you away.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATE_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0C93); // You encounter an Elf Cleric.
            L0010: ShowPortrait(player, 0x0027);
            L001D: Compare(GetRandom(0x000F), 0x0008);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, String0CB0); // I have visited King Cleowyn's throne room, and what a disappointment it was. Not much treasure there and too many dead things. Perhaps I missed something.
            L003C: goto L004B;
            L003E: ShowMessage(player, String0D4B); // The Elf Cleric is too engrossed in his prayers to talk with you.
            L004B: return; // RETURN;
        }

        private void FnKEYDRA_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xD3);
            L0011: if (JumpEqual) goto L0072;
            L0013: SetFlag(player, FlagTypeDungeon, FlagVestibuleUnlockType, 0x01);
            L0027: ShowMessage(player, String0D8C); // Cleowyn's Key unlocks the door.
            L0034: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0052: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0070: goto L009C;
            L0072: ShowMessage(player, String0DAC); // The door is locked.
            L007F: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L009C: return; // RETURN;
        }

        private void FnLKPKDRA_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xD2);
            L0011: if (JumpEqual) goto L0072;
            L0013: SetFlag(player, FlagTypeDungeon, FlagVestibuleUnlockType, 0x02);
            L0027: ShowMessage(player, String0DC0); // Cleowyn's Lockpick has unlocked the door.
            L0034: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0052: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0070: goto L009C;
            L0072: ShowMessage(player, String0DEA); // The door is locked.  It looks like something special is needed to open this door.
            L007F: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L009C: return; // RETURN;
        }

        private void FnSTRNGDRA_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(CheckStrength(player), 0x0012);
            L0012: if (JumpBelow) goto L0073;
            L0014: SetFlag(player, FlagTypeDungeon, FlagVestibuleUnlockType, 0x03);
            L0028: ShowMessage(player, String0E3C); // You manage to force open the door.
            L0035: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0053: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0071: goto L009D;
            L0073: ShowMessage(player, String0E5F); // The door is currently impassable.
            L0080: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L009D: return; // RETURN;
        }

        private void FnREGDORA_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagVestibuleUnlockType));
            L0015: if (JumpEqual) goto L002C;
            L0017: Compare(GetFlag(player, FlagTypeDungeon, FlagVestibuleUnlockType), 0x0004);
            L002A: if (JumpNotEqual) goto L008B;
            L002C: SetFlag(player, FlagTypeDungeon, FlagVestibuleUnlockType, 0x04);
            L0040: ShowMessage(player, String0E81); // As you open the door, you hear locks click throughout the dungeon.
            L004D: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L006B: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0089: goto L00B5;
            L008B: ShowMessage(player, String0EC4); // The door is currently impassable.
            L0098: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00B5: return; // RETURN;
        }

    }
}
