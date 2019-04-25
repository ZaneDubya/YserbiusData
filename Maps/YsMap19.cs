#pragma warning disable
using System.Collections.Generic;
using XPT.Legacy;
using XPT.Legacy.Entities;
using XPT.Legacy.Yserbius;

namespace XPT.Legacy.Maps {
    class YserMap19 : AMapScripted {
        protected override int MapIndex => 19;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 1;

        public YserMap19() {
            MapEvent01 = FnTELEPORT_01;
            MapEvent02 = FnTELEMESS_02;
            MapEvent03 = FnFOUNBLES_03;
            MapEvent04 = FnQUESTENC_04;
            MapEvent05 = FnLKPKDORZ_05;
            MapEvent06 = FnSTRDOOR_06;
            MapEvent0B = FnAVEMNSTR_0B;
            MapEvent0C = FnSTRMNSTR_0C;
            MapEvent0E = FnNPCCHATA_0E;
            MapEvent0F = FnNPCCHATB_0F;
        }
        
        // === Strings ================================================
        private const string String03FC = "There is a teleport in the west wall.";
        private const string String0422 = "You sip from the Fountain of Restoration, but nothing happens.";
        private const string String0461 = "You find the Fountain of Restoration and sip from it. You feel your Health greatly improve.";
        private const string String04BD = "Monsters attack you.";
        private const string String04D2 = "Among a horde of Nightmares and Cockatrices you spot armor and other items on the floor.";
        private const string String052B = "The door opens easily when you use the Lava Key.";
        private const string String055C = "This door cannot be unlocked without the Lava Key.";
        private const string String058F = "You manage to force the door open.";
        private const string String05B2 = "The door is stuck.";
        private const string String05C5 = "You encounter a Human Thief.";
        private const string String05E2 = "Find the Fountain of Tranquility if you are battle weary. Find it - if you can.";
        private const string String0632 = "The Human Thief cringes in terror and wraps herself up in a tight ball.";
        private const string String067A = "You encounter an Elf Barbarian.";
        private const string String069A = "A halfling thief told me of a wondrous world of four seasons deep in the heart of the dungeon. Of course, I did not believe him. Thieves are such liars.";
        private const string String0733 = "The Elf Barbarian dismisses you as useless baggage and heads off to find true heroes.";
        
        // === Functions ================================================
        private void FnTELEPORT_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x05, 0x02, 0x00, 0x33, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnTELEMESS_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String03FC); // There is a teleport in the west wall.
            L0010: return; // RETURN;
        }

        private void FnFOUNBLES_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, FlagTypeDungeon, FlagPitBottomFountainRestoration), 0x0001);
            L0017: if (JumpNotEqual) goto L0035;
            L0019: ShowPortrait(player, 0x0042);
            L0026: ShowMessage(player, String0422); // You sip from the Fountain of Restoration, but nothing happens.
            L0033: goto L0080;
            L0035: SetFlag(player, FlagTypeDungeon, FlagPitBottomFountainRestoration, 0x01);
            L004A: ShowPortrait(player, 0x0042);
            L0057: dx = GetMaxHits(player) - GetCurrentHits(player);
            L0069: HealPlayer(player, (ushort)dx);
            L0073: ShowMessage(player, String0461); // You find the Fountain of Restoration and sip from it. You feel your Health greatly improve.
            L0080: return; // RETURN;
        }

        private void FnQUESTENC_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x81);
            L0011: if (JumpEqual) goto L0043;
            L0013: AddTreasure(player, 0x01F4, 0x00, 0x00, 0xBD, 0xA5, 0xCD);
            L0034: ShowMessage(player, String04BD); // Monsters attack you.
            L0041: goto L0071;
            L0043: AddTreasure(player, 0x03E8, 0x00, 0x00, 0xA2, 0xD0, 0x81);
            L0064: ShowMessage(player, String04D2); // Among a horde of Nightmares and Cockatrices you spot armor and other items on the floor.
            L0071: Compare(PartyCount(player), 0x0001);
            L007C: if (JumpNotEqual) goto L00B7;
            L007E: AddEncounter(player, 0x01, 0x26);
            L0090: AddEncounter(player, 0x02, 0x26);
            L00A2: AddEncounter(player, 0x06, 0x23);
            L00B4: goto L01E4;
            L00B7: Compare(PartyCount(player), 0x0002);
            L00C2: if (JumpNotEqual) goto L010F;
            L00C4: AddEncounter(player, 0x01, 0x27);
            L00D6: AddEncounter(player, 0x02, 0x27);
            L00E8: AddEncounter(player, 0x05, 0x24);
            L00FA: AddEncounter(player, 0x06, 0x24);
            L010C: goto L01E4;
            L010F: Compare(PartyCount(player), 0x0003);
            L011A: if (JumpNotEqual) goto L0178;
            L011C: AddEncounter(player, 0x01, 0x26);
            L012E: AddEncounter(player, 0x02, 0x27);
            L0140: AddEncounter(player, 0x03, 0x28);
            L0152: AddEncounter(player, 0x04, 0x23);
            L0164: AddEncounter(player, 0x05, 0x24);
            L0176: goto L01E4;
            L0178: AddEncounter(player, 0x01, 0x23);
            L018A: AddEncounter(player, 0x02, 0x26);
            L019C: AddEncounter(player, 0x03, 0x24);
            L01AE: AddEncounter(player, 0x04, 0x27);
            L01C0: AddEncounter(player, 0x05, 0x25);
            L01D2: AddEncounter(player, 0x06, 0x28);
            L01E4: return; // RETURN;
        }

        private void FnLKPKDORZ_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, 0xE2, 0xE2);
            L0016: if (JumpEqual) goto L0063;
            L0018: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0036: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0054: ShowMessage(player, String052B); // The door opens easily when you use the Lava Key.
            L0061: goto L008D;
            L0063: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0080: ShowMessage(player, String055C); // This door cannot be unlocked without the Lava Key.
            L008D: return; // RETURN;
        }

        private void FnSTRDOOR_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(CheckStrength(player), 0x000E);
            L0012: if (JumpBelow) goto L005F;
            L0014: ShowMessage(player, String058F); // You manage to force the door open.
            L0021: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L003F: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L005D: goto L0089;
            L005F: ShowMessage(player, String05B2); // The door is stuck.
            L006C: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0089: return; // RETURN;
        }

        private void FnAVEMNSTR_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0025;
            L0010: AddEncounter(player, 0x02, 0x1B);
            L0022: goto L012E;
            L0025: Compare(PartyCount(player), 0x0002);
            L0030: if (JumpNotEqual) goto L006B;
            L0032: AddEncounter(player, 0x01, 0x1C);
            L0044: AddEncounter(player, 0x02, 0x19);
            L0056: AddEncounter(player, 0x03, 0x18);
            L0068: goto L012E;
            L006B: Compare(PartyCount(player), 0x0003);
            L0076: if (JumpNotEqual) goto L00C2;
            L0078: AddEncounter(player, 0x01, 0x1B);
            L008A: AddEncounter(player, 0x02, 0x1C);
            L009C: AddEncounter(player, 0x03, 0x1A);
            L00AE: AddEncounter(player, 0x04, 0x19);
            L00C0: goto L012E;
            L00C2: AddEncounter(player, 0x01, 0x1A);
            L00D4: AddEncounter(player, 0x02, 0x1C);
            L00E6: AddEncounter(player, 0x03, 0x19);
            L00F8: AddEncounter(player, 0x04, 0x1B);
            L010A: AddEncounter(player, 0x05, 0x1D);
            L011C: AddEncounter(player, 0x06, 0x1A);
            L012E: return; // RETURN;
        }

        private void FnSTRMNSTR_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0037;
            L0010: AddEncounter(player, 0x01, 0x1E);
            L0022: AddEncounter(player, 0x02, 0x20);
            L0034: goto L0152;
            L0037: Compare(PartyCount(player), 0x0002);
            L0042: if (JumpNotEqual) goto L007D;
            L0044: AddEncounter(player, 0x01, 0x1E);
            L0056: AddEncounter(player, 0x02, 0x20);
            L0068: AddEncounter(player, 0x03, 0x20);
            L007A: goto L0152;
            L007D: Compare(PartyCount(player), 0x0003);
            L0088: if (JumpNotEqual) goto L00E6;
            L008A: AddEncounter(player, 0x01, 0x1E);
            L009C: AddEncounter(player, 0x02, 0x1E);
            L00AE: AddEncounter(player, 0x03, 0x20);
            L00C0: AddEncounter(player, 0x04, 0x20);
            L00D2: AddEncounter(player, 0x05, 0x1F);
            L00E4: goto L0152;
            L00E6: AddEncounter(player, 0x01, 0x1E);
            L00F8: AddEncounter(player, 0x02, 0x1E);
            L010A: AddEncounter(player, 0x03, 0x1F);
            L011C: AddEncounter(player, 0x04, 0x1F);
            L012E: AddEncounter(player, 0x05, 0x20);
            L0140: AddEncounter(player, 0x06, 0x20);
            L0152: return; // RETURN;
        }

        private void FnNPCCHATA_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String05C5); // You encounter a Human Thief.
            L0010: ShowPortrait(player, 0x0022);
            L001D: Compare(GetRandom(0x000F), 0x000C);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, String05E2); // Find the Fountain of Tranquility if you are battle weary. Find it - if you can.
            L003C: goto L004B;
            L003E: ShowMessage(player, String0632); // The Human Thief cringes in terror and wraps herself up in a tight ball.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATB_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String067A); // You encounter an Elf Barbarian.
            L0010: ShowPortrait(player, 0x0018);
            L001D: Compare(GetRandom(0x000F), 0x0004);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, String069A); // A halfling thief told me of a wondrous world of four seasons deep in the heart of the dungeon. Of course, I did not believe him. Thieves are such liars.
            L003C: goto L004B;
            L003E: ShowMessage(player, String0733); // The Elf Barbarian dismisses you as useless baggage and heads off to find true heroes.
            L004B: return; // RETURN;
        }

    }
}
