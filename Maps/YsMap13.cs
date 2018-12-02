#pragma warning disable
using XPT.WorldData;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap13 : AMapScripted {
        protected override int MapIndex => 13;
        protected override int RandomEncounterChance => 0;
        protected override int RandomEncounterExtraCount => 2;

        public YserMap13() {
            MapEvent01 = FnTELEPORT_01;
            MapEvent02 = FnPIT_02;
            MapEvent03 = FnNPCCHATA_03;
            MapEvent04 = FnNPCCHATB_04;
            MapEvent05 = FnNPCCHATC_05;
            MapEvent06 = FnNPCCHATD_06;
            MapEvent07 = FnNPCCHATE_07;
            MapEvent08 = FnTELEMESG_08;
            MapEvent09 = FnITEMAENC_09;
            MapEvent0A = FnITEMBENC_0A;
            MapEvent0B = FnITEMCENC_0B;
            MapEvent0C = FnITEMDENC_0C;
            MapEvent0D = FnSTRMNSTR_0D;
            MapEvent0E = FnAVEMNSTR_0E;
            MapEvent0F = FnLKPKDORA_0F;
            MapEvent10 = FnLKPKDORB_10;
            MapEvent11 = FnLKPKDORC_11;
            MapEvent12 = FnLKPKDORD_12;
            MapEvent13 = FnSTRNDORA_13;
            MapEvent14 = FnSTRDOORB_14;
            MapEvent15 = FnSTRDOORC_15;
            MapEvent16 = FnSTRDOORD_16;
        }
        
        // === Strings ================================================
        private const string String03FC = "You encounter a Troll Cleric.";
        private const string String041A = "I have almost despaired of finding a way out of this prison. Yet there must be an exit of some kind - stairs or teleport. The guards must have had some way of leaving this area.";
        private const string String04CC = "To the east are the guard's living quarters and the interrogation rooms. The 36 prison cells are empty now, except for the resident spirits of those who perished here.";
        private const string String0574 = "The Troll Cleric bounces her head on the floor in frustration. She must be insane.";
        private const string String05C7 = "You encounter an Orc Ranger.";
        private const string String05E4 = "I have heard rumors that some few brave souls have escaped the dungeon. If you can find the Rainbow Bridge, you are near the exit.";
        private const string String0667 = "The Orc Ranger glares at you and refuses to speak.";
        private const string String069A = "You encounter a Halfling Thief.";
        private const string String06BA = "A special challenge awaits the brave. If you dare continue after finding what the guard Deldwinn desires, great rewards await you.";
        private const string String073D = "Chaos should walk with Chaos and Harmony with Harmony to find the rewards.";
        private const string String0788 = "The Halfling Thief thumbs his nose at you and dashes off.";
        private const string String07C2 = "You encounter a Gnome Barbarian.";
        private const string String07E3 = "Two wizards have crafted a Challenge for the brave. The Wizards' Challenge is on this level, but you cannot reach it from this prison area.";
        private const string String086F = "Know that race and Guild must walk together if the Challenge is to be overcome.";
        private const string String08BF = "The Gnome Barbarian becomes distracted as he tries to twiddle his thumbs and instead gets them entangled.";
        private const string String0929 = "You encounter a Dwarf Wizard.";
        private const string String0947 = "King Cleowyn built his palace inside this volcano because he hoped to unearth the secrets of the wizard Arnakkian. Many of the stones that form Cleowyn's palace were taken from the wizard's castle. No wonder this dungeon is cursed.";
        private const string String0A2F = "The Dwarf Wizard smiles kindly, but she refuses to speak.";
        private const string String0A69 = "There is a teleport in the west wall.";
        private const string String0A8F = "Incubi haunt the empty prison cell.";
        private const string String0AB3 = "As you reach for a jacket lying on the floor, you see Incubi appear in the cell.";
        private const string String0B04 = "Leeches and Black Widows live in the cell.";
        private const string String0B2F = "Just out of reach behind a mass of Leeches and Black Widows is a lockpick.";
        private const string String0B7A = "Hell Wolves appear in the cell.";
        private const string String0B9A = "A circle of Hell Wolves surrounds you and a mace lying on the floor.";
        private const string String0BDF = "Phantasms creep into the empty cell.";
        private const string String0C04 = "Spirits of the dead guard their precious treasure.";
        private const string String0C37 = "Your skill at picking locks soon has the door open.";
        private const string String0C6B = "The door is locked.";
        private const string String0C7F = "The lock of the door clicks open.";
        private const string String0CA1 = "The door is locked.";
        private const string String0CB5 = "You successfully pick the lock of the door.";
        private const string String0CE1 = "The door is locked.";
        private const string String0CF5 = "The lock of the door is quickly opened by your skillfulness.";
        private const string String0D32 = "The door is locked.";
        private const string String0D46 = "You manage to force the door open.";
        private const string String0D69 = "The door is stuck shut.";
        private const string String0D81 = "The door flies open as you smash against it.";
        private const string String0DAE = "The door is stuck and will not open.";
        private const string String0DD3 = "You push hard on the door and it creaks open.";
        private const string String0E01 = "The door refuses to open. It is stuck.";
        private const string String0E28 = "You manage to open the door by brute strength.";
        private const string String0E57 = "You are not strong enough to force the door open.";
        
        // === Functions ================================================
        private void FnTELEPORT_01(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x01, 0x06, 0xDC, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnPIT_02(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFloorObject(party, 0x01, GetCurrentTile(party));
            L0018: TeleportParty(party, 0x04, 0x01, 0xE0, 0x02, isForwardMove);
            L0033: return; // RETURN;
        }

        private void FnNPCCHATA_03(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String03FC); // You encounter a Troll Cleric.
            L0010: ShowPortrait(party, 0x0028);
            L001D: Compare(GetRandom(party, 0x000F), 0x000C);
            L002D: if (JumpAbove) goto L004B;
            L002F: ShowMessage(party, String041A); // I have almost despaired of finding a way out of this prison. Yet there must be an exit of some kind - stairs or teleport. The guards must have had some way of leaving this area.
            L003C: ShowMessage(party, String04CC); // To the east are the guard's living quarters and the interrogation rooms. The 36 prison cells are empty now, except for the resident spirits of those who perished here.
            L0049: goto L0058;
            L004B: ShowMessage(party, String0574); // The Troll Cleric bounces her head on the floor in frustration. She must be insane.
            L0058: return; // RETURN;
        }

        private void FnNPCCHATB_04(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String05C7); // You encounter an Orc Ranger.
            L0010: ShowPortrait(party, 0x001E);
            L001D: Compare(GetRandom(party, 0x000F), 0x0006);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String05E4); // I have heard rumors that some few brave souls have escaped the dungeon. If you can find the Rainbow Bridge, you are near the exit.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0667); // The Orc Ranger glares at you and refuses to speak.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATC_05(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String069A); // You encounter a Halfling Thief.
            L0010: ShowPortrait(party, 0x0025);
            L001D: Compare(GetRandom(party, 0x000F), 0x000A);
            L002D: if (JumpAbove) goto L004B;
            L002F: ShowMessage(party, String06BA); // A special challenge awaits the brave. If you dare continue after finding what the guard Deldwinn desires, great rewards await you.
            L003C: ShowMessage(party, String073D); // Chaos should walk with Chaos and Harmony with Harmony to find the rewards.
            L0049: goto L0058;
            L004B: ShowMessage(party, String0788); // The Halfling Thief thumbs his nose at you and dashes off.
            L0058: return; // RETURN;
        }

        private void FnNPCCHATD_06(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String07C2); // You encounter a Gnome Barbarian.
            L0010: ShowPortrait(party, 0x0019);
            L001D: Compare(GetRandom(party, 0x000F), 0x000B);
            L002D: if (JumpAbove) goto L004B;
            L002F: ShowMessage(party, String07E3); // Two wizards have crafted a Challenge for the brave. The Wizards' Challenge is on this level, but you cannot reach it from this prison area.
            L003C: ShowMessage(party, String086F); // Know that race and Guild must walk together if the Challenge is to be overcome.
            L0049: goto L0058;
            L004B: ShowMessage(party, String08BF); // The Gnome Barbarian becomes distracted as he tries to twiddle his thumbs and instead gets them entangled.
            L0058: return; // RETURN;
        }

        private void FnNPCCHATE_07(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0929); // You encounter a Dwarf Wizard.
            L0010: ShowPortrait(party, 0x002C);
            L001D: Compare(GetRandom(party, 0x000F), 0x000C);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String0947); // King Cleowyn built his palace inside this volcano because he hoped to unearth the secrets of the wizard Arnakkian. Many of the stones that form Cleowyn's palace were taken from the wizard's castle. No wonder this dungeon is cursed.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0A2F); // The Dwarf Wizard smiles kindly, but she refuses to speak.
            L004B: return; // RETURN;
        }

        private void FnTELEMESG_08(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0A69); // There is a teleport in the west wall.
            L0010: return; // RETURN;
        }

        private void FnITEMAENC_09(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0x77);
            L0011: if (JumpEqual) goto L0041;
            L0013: AddTreasure(party, 0x01F4, 0x00, 0x00, 0x00, 0x00, 0xCE);
            L0032: ShowMessage(party, String0A8F); // Incubi haunt the empty prison cell.
            L003F: goto L006D;
            L0041: AddTreasure(party, 0x05DC, 0x00, 0x00, 0x00, 0x00, 0x77);
            L0060: ShowMessage(party, String0AB3); // As you reach for a jacket lying on the floor, you see Incubi appear in the cell.
            L006D: Compare(PartyCount(party), 0x0001);
            L0078: if (JumpNotEqual) goto L00A1;
            L007A: AddEncounter(party, 0x01, 0x25);
            L008C: AddEncounter(party, 0x02, 0x25);
            L009E: goto L0152;
            L00A1: Compare(PartyCount(party), 0x0002);
            L00AC: if (JumpNotEqual) goto L00E6;
            L00AE: AddEncounter(party, 0x01, 0x25);
            L00C0: AddEncounter(party, 0x02, 0x25);
            L00D2: AddEncounter(party, 0x03, 0x26);
            L00E4: goto L0152;
            L00E6: AddEncounter(party, 0x01, 0x21);
            L00F8: AddEncounter(party, 0x02, 0x21);
            L010A: AddEncounter(party, 0x03, 0x26);
            L011C: AddEncounter(party, 0x04, 0x26);
            L012E: AddEncounter(party, 0x05, 0x25);
            L0140: AddEncounter(party, 0x06, 0x25);
            L0152: return; // RETURN;
        }

        private void FnITEMBENC_0A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0xC1);
            L0011: if (JumpEqual) goto L0041;
            L0013: AddTreasure(party, 0x00FA, 0x00, 0x00, 0x00, 0x00, 0xB6);
            L0032: ShowMessage(party, String0B04); // Leeches and Black Widows live in the cell.
            L003F: goto L006D;
            L0041: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0xC1);
            L0060: ShowMessage(party, String0B2F); // Just out of reach behind a mass of Leeches and Black Widows is a lockpick.
            L006D: Compare(PartyCount(party), 0x0001);
            L0078: if (JumpNotEqual) goto L00A1;
            L007A: AddEncounter(party, 0x01, 0x19);
            L008C: AddEncounter(party, 0x02, 0x1B);
            L009E: goto L0171;
            L00A1: Compare(PartyCount(party), 0x0002);
            L00AC: if (JumpEqual) goto L00BB;
            L00AE: Compare(PartyCount(party), 0x0003);
            L00B9: if (JumpNotEqual) goto L0105;
            L00BB: AddEncounter(party, 0x01, 0x19);
            L00CD: AddEncounter(party, 0x02, 0x1B);
            L00DF: AddEncounter(party, 0x03, 0x1B);
            L00F1: AddEncounter(party, 0x04, 0x19);
            L0103: goto L0171;
            L0105: AddEncounter(party, 0x01, 0x1B);
            L0117: AddEncounter(party, 0x02, 0x1B);
            L0129: AddEncounter(party, 0x03, 0x1C);
            L013B: AddEncounter(party, 0x04, 0x1C);
            L014D: AddEncounter(party, 0x05, 0x1B);
            L015F: AddEncounter(party, 0x06, 0x1B);
            L0171: return; // RETURN;
        }

        private void FnITEMCENC_0B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0x20);
            L0011: if (JumpEqual) goto L0041;
            L0013: AddTreasure(party, 0x012C, 0x00, 0x00, 0x00, 0x00, 0xCC);
            L0032: ShowMessage(party, String0B7A); // Hell Wolves appear in the cell.
            L003F: goto L006E;
            L0041: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0xCF, 0x20);
            L0061: ShowMessage(party, String0B9A); // A circle of Hell Wolves surrounds you and a mace lying on the floor.
            L006E: Compare(PartyCount(party), 0x0001);
            L0079: if (JumpNotEqual) goto L00A2;
            L007B: AddEncounter(party, 0x01, 0x21);
            L008D: AddEncounter(party, 0x02, 0x21);
            L009F: goto L0171;
            L00A2: Compare(PartyCount(party), 0x0002);
            L00AD: if (JumpEqual) goto L00BB;
            L00AF: RefreshCompareFlags(PartyCount(party));
            L00B9: if (JumpEqual) goto L0105;
            L00BB: AddEncounter(party, 0x01, 0x21);
            L00CD: AddEncounter(party, 0x02, 0x22);
            L00DF: AddEncounter(party, 0x03, 0x22);
            L00F1: AddEncounter(party, 0x04, 0x21);
            L0103: goto L0171;
            L0105: AddEncounter(party, 0x01, 0x22);
            L0117: AddEncounter(party, 0x02, 0x22);
            L0129: AddEncounter(party, 0x03, 0x22);
            L013B: AddEncounter(party, 0x04, 0x22);
            L014D: AddEncounter(party, 0x05, 0x22);
            L015F: AddEncounter(party, 0x06, 0x22);
            L0171: return; // RETURN;
        }

        private void FnITEMDENC_0C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0x54);
            L0011: if (JumpEqual) goto L0041;
            L0013: AddTreasure(party, 0x012C, 0x00, 0x00, 0x00, 0x00, 0xB6);
            L0032: ShowMessage(party, String0BDF); // Phantasms creep into the empty cell.
            L003F: goto L006D;
            L0041: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0x54);
            L0060: ShowMessage(party, String0C04); // Spirits of the dead guard their precious treasure.
            L006D: Compare(PartyCount(party), 0x0001);
            L0078: if (JumpEqual) goto L0087;
            L007A: Compare(PartyCount(party), 0x0002);
            L0085: if (JumpNotEqual) goto L00AE;
            L0087: AddEncounter(party, 0x01, 0x27);
            L0099: AddEncounter(party, 0x02, 0x28);
            L00AB: goto L0171;
            L00AE: Compare(PartyCount(party), 0x0003);
            L00B9: if (JumpNotEqual) goto L0105;
            L00BB: AddEncounter(party, 0x01, 0x27);
            L00CD: AddEncounter(party, 0x02, 0x28);
            L00DF: AddEncounter(party, 0x03, 0x27);
            L00F1: AddEncounter(party, 0x04, 0x28);
            L0103: goto L0171;
            L0105: AddEncounter(party, 0x01, 0x27);
            L0117: AddEncounter(party, 0x02, 0x27);
            L0129: AddEncounter(party, 0x03, 0x27);
            L013B: AddEncounter(party, 0x04, 0x27);
            L014D: AddEncounter(party, 0x05, 0x28);
            L015F: AddEncounter(party, 0x06, 0x28);
            L0171: return; // RETURN;
        }

        private void FnSTRMNSTR_0D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(party), 0x0001);
            L000E: if (JumpEqual) goto L001D;
            L0010: Compare(PartyCount(party), 0x0002);
            L001B: if (JumpNotEqual) goto L0056;
            L001D: AddEncounter(party, 0x01, 0x1F);
            L002F: AddEncounter(party, 0x02, 0x1F);
            L0041: AddEncounter(party, 0x03, 0x1D);
            L0053: goto L012B;
            L0056: Compare(PartyCount(party), 0x0003);
            L0061: if (JumpNotEqual) goto L00BF;
            L0063: AddEncounter(party, 0x01, 0x1E);
            L0075: AddEncounter(party, 0x02, 0x1D);
            L0087: AddEncounter(party, 0x03, 0x1D);
            L0099: AddEncounter(party, 0x04, 0x1E);
            L00AB: AddEncounter(party, 0x05, 0x20);
            L00BD: goto L012B;
            L00BF: AddEncounter(party, 0x01, 0x1F);
            L00D1: AddEncounter(party, 0x02, 0x1F);
            L00E3: AddEncounter(party, 0x03, 0x20);
            L00F5: AddEncounter(party, 0x04, 0x20);
            L0107: AddEncounter(party, 0x05, 0x1E);
            L0119: AddEncounter(party, 0x06, 0x1E);
            L012B: return; // RETURN;
        }

        private void FnAVEMNSTR_0E(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(party), 0x0001);
            L000E: if (JumpNotEqual) goto L0037;
            L0010: AddEncounter(party, 0x01, 0x1A);
            L0022: AddEncounter(party, 0x02, 0x1B);
            L0034: goto L0176;
            L0037: Compare(PartyCount(party), 0x0002);
            L0042: if (JumpNotEqual) goto L008F;
            L0044: AddEncounter(party, 0x01, 0x1B);
            L0056: AddEncounter(party, 0x02, 0x1B);
            L0068: AddEncounter(party, 0x03, 0x19);
            L007A: AddEncounter(party, 0x04, 0x19);
            L008C: goto L0176;
            L008F: Compare(PartyCount(party), 0x0003);
            L009A: if (JumpNotEqual) goto L010A;
            L009C: AddEncounter(party, 0x01, 0x1B);
            L00AE: AddEncounter(party, 0x02, 0x1B);
            L00C0: AddEncounter(party, 0x03, 0x1B);
            L00D2: AddEncounter(party, 0x04, 0x1B);
            L00E4: AddEncounter(party, 0x05, 0x1A);
            L00F6: AddEncounter(party, 0x06, 0x1A);
            L0108: goto L0176;
            L010A: AddEncounter(party, 0x01, 0x1C);
            L011C: AddEncounter(party, 0x02, 0x1C);
            L012E: AddEncounter(party, 0x03, 0x1A);
            L0140: AddEncounter(party, 0x04, 0x1A);
            L0152: AddEncounter(party, 0x05, 0x1C);
            L0164: AddEncounter(party, 0x06, 0x1C);
            L0176: return; // RETURN;
        }

        private void FnLKPKDORA_0F(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(party, 0xBF, 0xC4);
            L0016: if (JumpNotEqual) goto L0029;
            L0018: Compare(HasUsedSkill(party, 0x0E), 0x0002);
            L0027: if (JumpBelow) goto L0074;
            L0029: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L0047: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L0065: ShowMessage(party, String0C37); // Your skill at picking locks soon has the door open.
            L0072: goto L009E;
            L0074: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x00);
            L0091: ShowMessage(party, String0C6B); // The door is locked.
            L009E: return; // RETURN;
        }

        private void FnLKPKDORB_10(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(party, 0xC0, 0xC4);
            L0016: if (JumpNotEqual) goto L0029;
            L0018: Compare(HasUsedSkill(party, 0x0E), 0x0004);
            L0027: if (JumpBelow) goto L0074;
            L0029: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L0047: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L0065: ShowMessage(party, String0C7F); // The lock of the door clicks open.
            L0072: goto L009E;
            L0074: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x00);
            L0091: ShowMessage(party, String0CA1); // The door is locked.
            L009E: return; // RETURN;
        }

        private void FnLKPKDORC_11(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(party, 0xC2, 0xC4);
            L0016: if (JumpNotEqual) goto L0029;
            L0018: Compare(HasUsedSkill(party, 0x0E), 0x0007);
            L0027: if (JumpBelow) goto L0074;
            L0029: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L0047: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L0065: ShowMessage(party, String0CB5); // You successfully pick the lock of the door.
            L0072: goto L009E;
            L0074: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x00);
            L0091: ShowMessage(party, String0CE1); // The door is locked.
            L009E: return; // RETURN;
        }

        private void FnLKPKDORD_12(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(party, 0xC3, 0xC4);
            L0016: if (JumpNotEqual) goto L0029;
            L0018: Compare(HasUsedSkill(party, 0x0E), 0x0009);
            L0027: if (JumpBelow) goto L0074;
            L0029: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L0047: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L0065: ShowMessage(party, String0CF5); // The lock of the door is quickly opened by your skillfulness.
            L0072: goto L009E;
            L0074: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x00);
            L0091: ShowMessage(party, String0D32); // The door is locked.
            L009E: return; // RETURN;
        }

        private void FnSTRNDORA_13(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(CheckStrength(party), 0x000C);
            L0012: if (JumpBelow) goto L005F;
            L0014: ShowMessage(party, String0D46); // You manage to force the door open.
            L0021: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L003F: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L005D: goto L0089;
            L005F: ShowMessage(party, String0D69); // The door is stuck shut.
            L006C: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x00);
            L0089: return; // RETURN;
        }

        private void FnSTRDOORB_14(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(CheckStrength(party), 0x000F);
            L0012: if (JumpBelow) goto L005F;
            L0014: ShowMessage(party, String0D81); // The door flies open as you smash against it.
            L0021: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L003F: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L005D: goto L0089;
            L005F: ShowMessage(party, String0DAE); // The door is stuck and will not open.
            L006C: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x00);
            L0089: return; // RETURN;
        }

        private void FnSTRDOORC_15(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(CheckStrength(party), 0x0011);
            L0012: if (JumpBelow) goto L005F;
            L0014: ShowMessage(party, String0DD3); // You push hard on the door and it creaks open.
            L0021: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L003F: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L005D: goto L0089;
            L005F: ShowMessage(party, String0E01); // The door refuses to open. It is stuck.
            L006C: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x00);
            L0089: return; // RETURN;
        }

        private void FnSTRDOORD_16(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(CheckStrength(party), 0x0014);
            L0012: if (JumpBelow) goto L005F;
            L0014: ShowMessage(party, String0E28); // You manage to open the door by brute strength.
            L0021: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L003F: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L005D: goto L0089;
            L005F: ShowMessage(party, String0E57); // You are not strong enough to force the door open.
            L006C: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x00);
            L0089: return; // RETURN;
        }

    }
}
