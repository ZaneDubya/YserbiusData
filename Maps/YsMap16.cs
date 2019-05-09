#pragma warning disable
using System.Collections.Generic;
using XPT.Legacy;
using XPT.Legacy.Entities;

namespace XPT.Legacy.Maps {
    class YserMap16 : AMapScripted {
        protected override int MapIndex => 16;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 1;

        public YserMap16() {
            MapEvent01 = FnSTRSTELE_01;
            MapEvent02 = FnSTRSTELE_02;
            MapEvent03 = FnPLATFMUP_03;
            MapEvent04 = FnTELPORTA_04;
            MapEvent05 = FnTELEPORT_05;
            MapEvent06 = FnTELPORTC_06;
            MapEvent07 = FnTRAPDORA_07;
            MapEvent08 = FnTRAPDORB_08;
            MapEvent09 = FnTRAPDORC_09;
            MapEvent0A = FnTRAPDORD_0A;
            MapEvent0B = FnTRAPDORE_0B;
            MapEvent0C = FnTRAPDORF_0C;
            MapEvent0D = FnTRAPDORG_0D;
            MapEvent0E = FnTRAPDORH_0E;
            MapEvent0F = FnTRAPDORI_0F;
            MapEvent10 = FnTRAPDORJ_10;
            MapEvent11 = FnTRAPDORK_11;
            MapEvent12 = FnTRAPDORL_12;
            MapEvent13 = FnTRAPDORM_13;
            MapEvent14 = FnLKPKDORA_14;
            MapEvent15 = FnLKPKDORB_15;
            MapEvent16 = FnLKPKDORC_16;
            MapEvent17 = FnKEYDOORA_17;
            MapEvent18 = FnKEYDOORB_18;
            MapEvent19 = FnKEYDOORC_19;
            MapEvent1A = FnSTRDOORA_1A;
            MapEvent1B = FnSTRDOORB_1B;
            MapEvent1C = FnITMDOORA_1C;
            MapEvent1D = FnDETCTDOR_1D;
            MapEvent1E = FnLFTROTA_1E;
            MapEvent1F = FnLFTROTB_1F;
            MapEvent20 = FnBACKROTL_20;
            MapEvent21 = FnRTROTA_21;
            MapEvent22 = FnRTROTB_22;
            MapEvent25 = FnBADMNSTR_25;
            MapEvent28 = FnITEMAENC_28;
            MapEvent29 = FnSPECITMB_29;
            MapEvent2A = FnITEMCENC_2A;
            MapEvent2B = FnITEMDECN_2B;
            MapEvent2C = FnWEAPAENC_2C;
            MapEvent2D = FnWEAPBENC_2D;
            MapEvent2E = FnARMRAENC_2E;
            MapEvent2F = FnARMRBENC_2F;
            MapEvent30 = FnKEYENC_30;
            MapEvent31 = FnTELMESGA_31;
            MapEvent32 = FnTELMESGB_32;
            MapEvent33 = FnTELMESSC_33;
            MapEvent34 = FnGOLDAENC_34;
            MapEvent35 = FnGOLDBENC_35;
            MapEvent36 = FnBACKROTR_36;
            MapEvent37 = FnSTRSMESA_37;
            MapEvent38 = FnSTRSMESB_38;
            MapEvent39 = FnPLATFMMS_39;
            MapEvent3A = FnSTRSMESS_3A;
            MapEvent3B = FnNPCCHATA_3B;
            MapEvent3C = FnNPCCHATB_3C;
            MapEvent3D = FnNPCCHATC_3D;
            MapEvent3E = FnSTRSTELE_3E;
        }
        
        // === Strings ================================================
        private const string String03FC = "You found a trapdoor.";
        private const string String0412 = "You fall through a trapdoor.";
        private const string String042F = "You spot a trapdoor.";
        private const string String0444 = "You fall through a trapdoor.";
        private const string String0461 = "You detect a trapdoor.";
        private const string String0478 = "You fall through a trapdoor.";
        private const string String0495 = "You escape a trapdoor.";
        private const string String04AC = "You fall through a trapdoor.";
        private const string String04C9 = "You notice a trapdoor.";
        private const string String04E0 = "You fall through a trapdoor.";
        private const string String04FD = "There is a trapdoor in the floor.";
        private const string String051F = "You fall through a trapdoor.";
        private const string String053C = "You discover a trapdoor.";
        private const string String0555 = "You fall through a trapdoor.";
        private const string String0572 = "You detect a trapdoor.";
        private const string String0589 = "You fall through a trapdoor.";
        private const string String05A6 = "You spot a trapdoor.";
        private const string String05BB = "You fall through a trapdoor.";
        private const string String05D8 = "You detect a trapdoor.";
        private const string String05EF = "You fall through a trapdoor.";
        private const string String060C = "A trapdoor is in this room.";
        private const string String0628 = "You fall through a trapdoor.";
        private const string String0645 = "You sidestep a trapdoor.";
        private const string String065E = "You fall through a trapdoor.";
        private const string String067B = "You avoid a trapdoor.";
        private const string String0691 = "You fall through a trapdoor.";
        private const string String06AE = "You soon have the door unlocked.";
        private const string String06CF = "The door is locked.";
        private const string String06E3 = "Your aptitude at opening locks pays off.";
        private const string String070C = "The door is locked.";
        private const string String0720 = "You succeed at picking the door lock.";
        private const string String0746 = "The door is locked.";
        private const string String075A = "The door lock is no match for your skills.";
        private const string String0785 = "The door is locked.";
        private const string String0799 = "You deftly trip the door lock.";
        private const string String07B8 = "The door is locked.";
        private const string String07CC = "You quickly have the door open.";
        private const string String07EC = "The door is locked.";
        private const string String0800 = "You push on the door and open it.";
        private const string String0822 = "The door is stuck shut.";
        private const string String083A = "You force the door open by muscle power.";
        private const string String0863 = "The door is stuck shut.";
        private const string String087B = "The Domicile Key opens the door!";
        private const string String089C = "The door is locked.";
        private const string String08B0 = "You have spotted a secret door!";
        private const string String08D0 = "Clerics use this room as a sanctuary.";
        private const string String08F6 = "A scroll fall from a Cleric's robe.";
        private const string String091A = "Rogues use this room as a hideout.";
        private const string String093D = "A Barbarian drops some potions when she sees you.";
        private const string String096F = "You sense evil in the room.";
        private const string String098B = "You see a wand on the floor.";
        private const string String09A8 = "The stench of reptiles assails you.";
        private const string String09CC = "You hear hissing.";
        private const string String09DE = "Rogues surprise you.";
        private const string String09F3 = "A Knight drops a poleaxe as you approach.";
        private const string String0A1D = "Nightmares loom up before you.";
        private const string String0A3C = "A Nightmare throws a bow aside to attack.";
        private const string String0A66 = "You stumble on some Dwarf Knights.";
        private const string String0A89 = "The brilliant chainmail worn by a Knight blinds you.";
        private const string String0ABE = "You enter a den of thieves.";
        private const string String0ADA = "A Halfling Thief tries to wield a large shield.";
        private const string String0B0A = "The room is jammed with Rogues.";
        private const string String0B2A = "A Ranger wears the King's Domicile Key around his neck.";
        private const string String0B62 = "There is a teleport in the south wall.";
        private const string String0B89 = "There is a teleport to the south.";
        private const string String0BAB = "There is a teleport to the north.";
        private const string String0BCD = "Banshees haunt this room.";
        private const string String0BE7 = "Deinons protect a chest.";
        private const string String0C00 = "Stairs through the east gateway lead upstairs.";
        private const string String0C2F = "There are stairs to the north beyond the gateway.";
        private const string String0C61 = "There is an elevator platform to the north.";
        private const string String0C8D = "Stairs through the west gateway lead down a level.";
        private const string String0CC0 = "You encounter a Human Wizard.";
        private const string String0CDE = "This is the lowest level of Cleowyn's Palace, yet you are merely at the beginning of the dungeon proper.";
        private const string String0D47 = "The Human Wizard chortles softly.";
        private const string String0D69 = "You encounter a Gnome Thief.";
        private const string String0D86 = "In the king's quarters is an elevator that will lift you up to the King's Palace. Cleowyn used this elevator to  by-pass the traps around his throne.";
        private const string String0E1C = "The Gnome Thief tiptoes away as you draw near.";
        private const string String0E4B = "You encounter a Gnome Barbarian.";
        private const string String0E6C = "The name of the Elemental bound by the wizard Arnakkian is En-li-kil. This Elemental commands Time itself.";
        private const string String0ED7 = "The Gnome Barbarian warns you to stay away.";
        
        // === Functions ================================================
        private void FnSTRSTELE_01(ServerPlayer player, bool isForwardMove) {
            TeleportParty(player, 0x03, 0x03, 0xE0, 0x03, isForwardMove);
        }

        private void FnSTRSTELE_02(ServerPlayer player, bool isForwardMove) {
            TeleportParty(player, 0x05, 0x01, 0x8D, 0x02, isForwardMove);
        }

        private void FnPLATFMUP_03(ServerPlayer player, bool isForwardMove) {
            TeleportParty(player, 0x02, 0x06, 0xB4, 0x03, isForwardMove);
        }

        private void FnTELPORTA_04(ServerPlayer player, bool isForwardMove) {
            TeleportParty(player, 0x01, 0x03, 0x68, 0x01, isForwardMove);
        }

        private void FnTELEPORT_05(ServerPlayer player, bool isForwardMove) {
            TeleportParty(player, 0x03, 0x03, 0x24, 0x02, isForwardMove);
        }

        private void FnTELPORTC_06(ServerPlayer player, bool isForwardMove) {
            TeleportParty(player, 0x05, 0x02, 0xAF, 0x03, isForwardMove);
        }

        private void FnTRAPDORA_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L0062;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L0062;
            L0024: ax = HasUsedItem(player, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L0062;
            L0039: ax = HasUsedItem(player, 0xBE, 0xBE);
            L004C: if (JumpNotEqual) goto L0062;
            L004E: ax = IsFlagOn(player, FlagTypeTile, 0x01);
            L0060: if (JumpEqual) goto L0085;
            L0062: ShowMessage(player, isForwardMove, String03FC); // You found a trapdoor.
            L006F: SetFlag(player, FlagTypeTile, 0x01, 0x01);
            L0083: goto L00AC;
            L0085: TeleportParty(player, 0x05, 0x02, 0x89, 0x00, isForwardMove);
            L009F: ShowMessage(player, isForwardMove, String0412); // You fall through a trapdoor.
            L00AC: return; // RETURN;
        }

        private void FnTRAPDORB_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L0062;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L0062;
            L0024: ax = HasUsedItem(player, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L0062;
            L0039: ax = HasUsedItem(player, 0xBE, 0xBE);
            L004C: if (JumpNotEqual) goto L0062;
            L004E: ax = IsFlagOn(player, FlagTypeTile, 0x01);
            L0060: if (JumpEqual) goto L0085;
            L0062: ShowMessage(player, isForwardMove, String042F); // You spot a trapdoor.
            L006F: SetFlag(player, FlagTypeTile, 0x01, 0x01);
            L0083: goto L00AD;
            L0085: TeleportParty(player, 0x05, 0x02, 0x8C, 0x01, isForwardMove);
            L00A0: ShowMessage(player, isForwardMove, String0444); // You fall through a trapdoor.
            L00AD: return; // RETURN;
        }

        private void FnTRAPDORC_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L0062;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L0062;
            L0024: ax = HasUsedItem(player, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L0062;
            L0039: ax = HasUsedItem(player, 0xBE, 0xBE);
            L004C: if (JumpNotEqual) goto L0062;
            L004E: ax = IsFlagOn(player, FlagTypeTile, 0x01);
            L0060: if (JumpEqual) goto L0085;
            L0062: ShowMessage(player, isForwardMove, String0461); // You detect a trapdoor.
            L006F: SetFlag(player, FlagTypeTile, 0x01, 0x01);
            L0083: goto L00AD;
            L0085: TeleportParty(player, 0x05, 0x02, 0x91, 0x03, isForwardMove);
            L00A0: ShowMessage(player, isForwardMove, String0478); // You fall through a trapdoor.
            L00AD: return; // RETURN;
        }

        private void FnTRAPDORD_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L0062;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L0062;
            L0024: ax = HasUsedItem(player, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L0062;
            L0039: ax = HasUsedItem(player, 0xBE, 0xBE);
            L004C: if (JumpNotEqual) goto L0062;
            L004E: ax = IsFlagOn(player, FlagTypeTile, 0x01);
            L0060: if (JumpEqual) goto L0085;
            L0062: ShowMessage(player, isForwardMove, String0495); // You escape a trapdoor.
            L006F: SetFlag(player, FlagTypeTile, 0x01, 0x01);
            L0083: goto L00AD;
            L0085: TeleportParty(player, 0x05, 0x02, 0x9D, 0x03, isForwardMove);
            L00A0: ShowMessage(player, isForwardMove, String04AC); // You fall through a trapdoor.
            L00AD: return; // RETURN;
        }

        private void FnTRAPDORE_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L0062;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L0062;
            L0024: ax = HasUsedItem(player, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L0062;
            L0039: ax = HasUsedItem(player, 0xBE, 0xBE);
            L004C: if (JumpNotEqual) goto L0062;
            L004E: ax = IsFlagOn(player, FlagTypeTile, 0x01);
            L0060: if (JumpEqual) goto L0085;
            L0062: ShowMessage(player, isForwardMove, String04C9); // You notice a trapdoor.
            L006F: SetFlag(player, FlagTypeTile, 0x01, 0x01);
            L0083: goto L00AD;
            L0085: TeleportParty(player, 0x05, 0x02, 0xAB, 0x03, isForwardMove);
            L00A0: ShowMessage(player, isForwardMove, String04E0); // You fall through a trapdoor.
            L00AD: return; // RETURN;
        }

        private void FnTRAPDORF_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L0062;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L0062;
            L0024: ax = HasUsedItem(player, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L0062;
            L0039: ax = HasUsedItem(player, 0xBE, 0xBE);
            L004C: if (JumpNotEqual) goto L0062;
            L004E: ax = IsFlagOn(player, FlagTypeTile, 0x01);
            L0060: if (JumpEqual) goto L0085;
            L0062: ShowMessage(player, isForwardMove, String04FD); // There is a trapdoor in the floor.
            L006F: SetFlag(player, FlagTypeTile, 0x01, 0x01);
            L0083: goto L00AD;
            L0085: TeleportParty(player, 0x05, 0x02, 0xBA, 0x02, isForwardMove);
            L00A0: ShowMessage(player, isForwardMove, String051F); // You fall through a trapdoor.
            L00AD: return; // RETURN;
        }

        private void FnTRAPDORG_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L0062;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L0062;
            L0024: ax = HasUsedItem(player, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L0062;
            L0039: ax = HasUsedItem(player, 0xBE, 0xBE);
            L004C: if (JumpNotEqual) goto L0062;
            L004E: ax = IsFlagOn(player, FlagTypeTile, 0x01);
            L0060: if (JumpEqual) goto L0085;
            L0062: ShowMessage(player, isForwardMove, String053C); // You discover a trapdoor.
            L006F: SetFlag(player, FlagTypeTile, 0x01, 0x01);
            L0083: goto L00AD;
            L0085: TeleportParty(player, 0x05, 0x02, 0xBF, 0x01, isForwardMove);
            L00A0: ShowMessage(player, isForwardMove, String0555); // You fall through a trapdoor.
            L00AD: return; // RETURN;
        }

        private void FnTRAPDORH_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L0062;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L0062;
            L0024: ax = HasUsedItem(player, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L0062;
            L0039: ax = HasUsedItem(player, 0xBE, 0xBE);
            L004C: if (JumpNotEqual) goto L0062;
            L004E: ax = IsFlagOn(player, FlagTypeTile, 0x01);
            L0060: if (JumpEqual) goto L0085;
            L0062: ShowMessage(player, isForwardMove, String0572); // You detect a trapdoor.
            L006F: SetFlag(player, FlagTypeTile, 0x01, 0x01);
            L0083: goto L00AD;
            L0085: TeleportParty(player, 0x05, 0x02, 0xCA, 0x02, isForwardMove);
            L00A0: ShowMessage(player, isForwardMove, String0589); // You fall through a trapdoor.
            L00AD: return; // RETURN;
        }

        private void FnTRAPDORI_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L0062;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L0062;
            L0024: ax = HasUsedItem(player, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L0062;
            L0039: ax = HasUsedItem(player, 0xBE, 0xBE);
            L004C: if (JumpNotEqual) goto L0062;
            L004E: ax = IsFlagOn(player, FlagTypeTile, 0x01);
            L0060: if (JumpEqual) goto L0085;
            L0062: ShowMessage(player, isForwardMove, String05A6); // You spot a trapdoor.
            L006F: SetFlag(player, FlagTypeTile, 0x01, 0x01);
            L0083: goto L00AD;
            L0085: TeleportParty(player, 0x05, 0x02, 0xD6, 0x01, isForwardMove);
            L00A0: ShowMessage(player, isForwardMove, String05BB); // You fall through a trapdoor.
            L00AD: return; // RETURN;
        }

        private void FnTRAPDORJ_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L0062;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L0062;
            L0024: ax = HasUsedItem(player, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L0062;
            L0039: ax = HasUsedItem(player, 0xBE, 0xBE);
            L004C: if (JumpNotEqual) goto L0062;
            L004E: ax = IsFlagOn(player, FlagTypeTile, 0x01);
            L0060: if (JumpEqual) goto L0085;
            L0062: ShowMessage(player, isForwardMove, String05D8); // You detect a trapdoor.
            L006F: SetFlag(player, FlagTypeTile, 0x01, 0x01);
            L0083: goto L00AD;
            L0085: TeleportParty(player, 0x05, 0x02, 0xD9, 0x03, isForwardMove);
            L00A0: ShowMessage(player, isForwardMove, String05EF); // You fall through a trapdoor.
            L00AD: return; // RETURN;
        }

        private void FnTRAPDORK_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L0062;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L0062;
            L0024: ax = HasUsedItem(player, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L0062;
            L0039: ax = HasUsedItem(player, 0xBE, 0xBE);
            L004C: if (JumpNotEqual) goto L0062;
            L004E: ax = IsFlagOn(player, FlagTypeTile, 0x01);
            L0060: if (JumpEqual) goto L0085;
            L0062: ShowMessage(player, isForwardMove, String060C); // A trapdoor is in this room.
            L006F: SetFlag(player, FlagTypeTile, 0x01, 0x01);
            L0083: goto L00AD;
            L0085: TeleportParty(player, 0x05, 0x02, 0xEC, 0x01, isForwardMove);
            L00A0: ShowMessage(player, isForwardMove, String0628); // You fall through a trapdoor.
            L00AD: return; // RETURN;
        }

        private void FnTRAPDORL_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L0062;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L0062;
            L0024: ax = HasUsedItem(player, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L0062;
            L0039: ax = HasUsedItem(player, 0xBE, 0xBE);
            L004C: if (JumpNotEqual) goto L0062;
            L004E: ax = IsFlagOn(player, FlagTypeTile, 0x01);
            L0060: if (JumpEqual) goto L0085;
            L0062: ShowMessage(player, isForwardMove, String0645); // You sidestep a trapdoor.
            L006F: SetFlag(player, FlagTypeTile, 0x01, 0x01);
            L0083: goto L00AC;
            L0085: TeleportParty(player, 0x05, 0x02, 0xF4, 0x00, isForwardMove);
            L009F: ShowMessage(player, isForwardMove, String065E); // You fall through a trapdoor.
            L00AC: return; // RETURN;
        }

        private void FnTRAPDORM_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L0062;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L0062;
            L0024: ax = HasUsedItem(player, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L0062;
            L0039: ax = HasUsedItem(player, 0xBE, 0xBE);
            L004C: if (JumpNotEqual) goto L0062;
            L004E: ax = IsFlagOn(player, FlagTypeTile, 0x01);
            L0060: if (JumpEqual) goto L0085;
            L0062: ShowMessage(player, isForwardMove, String067B); // You avoid a trapdoor.
            L006F: SetFlag(player, FlagTypeTile, 0x01, 0x01);
            L0083: goto L00AD;
            L0085: TeleportParty(player, 0x05, 0x02, 0xFD, 0x02, isForwardMove);
            L00A0: ShowMessage(player, isForwardMove, String0691); // You fall through a trapdoor.
            L00AD: return; // RETURN;
        }

        private void FnLKPKDORA_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, 0xC1, 0xC4);
            L0016: if (JumpNotEqual) goto L0029;
            L0018: Compare(HasUsedSkill(player, 0x0E), 0x0006);
            L0027: if (JumpBelow) goto L0074;
            L0029: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0047: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0065: ShowMessage(player, isForwardMove, String06AE); // You soon have the door unlocked.
            L0072: goto L009E;
            L0074: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0091: ShowMessage(player, isForwardMove, String06CF); // The door is locked.
            L009E: return; // RETURN;
        }

        private void FnLKPKDORB_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, 0xC2, 0xC4);
            L0016: if (JumpNotEqual) goto L0029;
            L0018: Compare(HasUsedSkill(player, 0x0E), 0x0007);
            L0027: if (JumpBelow) goto L0074;
            L0029: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0047: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0065: ShowMessage(player, isForwardMove, String06E3); // Your aptitude at opening locks pays off.
            L0072: goto L009E;
            L0074: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0091: ShowMessage(player, isForwardMove, String070C); // The door is locked.
            L009E: return; // RETURN;
        }

        private void FnLKPKDORC_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, 0xC3, 0xC4);
            L0016: if (JumpNotEqual) goto L0029;
            L0018: Compare(HasUsedSkill(player, 0x0E), 0x0009);
            L0027: if (JumpBelow) goto L0074;
            L0029: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0047: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0065: ShowMessage(player, isForwardMove, String0720); // You succeed at picking the door lock.
            L0072: goto L009E;
            L0074: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0091: ShowMessage(player, isForwardMove, String0746); // The door is locked.
            L009E: return; // RETURN;
        }

        private void FnKEYDOORA_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, 0xC3, 0xC4);
            L0016: if (JumpNotEqual) goto L003E;
            L0018: ax = HasUsedItem(player, 0xE1, 0xE1);
            L002B: if (JumpNotEqual) goto L003E;
            L002D: Compare(HasUsedSkill(player, 0x0E), 0x000A);
            L003C: if (JumpBelow) goto L0089;
            L003E: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L005C: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L007A: ShowMessage(player, isForwardMove, String075A); // The door lock is no match for your skills.
            L0087: goto L00B3;
            L0089: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00A6: ShowMessage(player, isForwardMove, String0785); // The door is locked.
            L00B3: return; // RETURN;
        }

        private void FnKEYDOORB_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, 0xC3, 0xC4);
            L0016: if (JumpNotEqual) goto L003E;
            L0018: ax = HasUsedItem(player, 0xE1, 0xE1);
            L002B: if (JumpNotEqual) goto L003E;
            L002D: Compare(HasUsedSkill(player, 0x0E), 0x000B);
            L003C: if (JumpBelow) goto L0089;
            L003E: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L005C: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L007A: ShowMessage(player, isForwardMove, String0799); // You deftly trip the door lock.
            L0087: goto L00B3;
            L0089: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00A6: ShowMessage(player, isForwardMove, String07B8); // The door is locked.
            L00B3: return; // RETURN;
        }

        private void FnKEYDOORC_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, 0xC4, 0xC4);
            L0016: if (JumpNotEqual) goto L003E;
            L0018: ax = HasUsedItem(player, 0xE1, 0xE1);
            L002B: if (JumpNotEqual) goto L003E;
            L002D: Compare(HasUsedSkill(player, 0x0E), 0x000C);
            L003C: if (JumpBelow) goto L0089;
            L003E: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L005C: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L007A: ShowMessage(player, isForwardMove, String07CC); // You quickly have the door open.
            L0087: goto L00B3;
            L0089: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00A6: ShowMessage(player, isForwardMove, String07EC); // The door is locked.
            L00B3: return; // RETURN;
        }

        private void FnSTRDOORA_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(CheckStrength(player), 0x000E);
            L0012: if (JumpBelow) goto L005F;
            L0014: ShowMessage(player, isForwardMove, String0800); // You push on the door and open it.
            L0021: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L003F: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L005D: goto L0089;
            L005F: ShowMessage(player, isForwardMove, String0822); // The door is stuck shut.
            L006C: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0089: return; // RETURN;
        }

        private void FnSTRDOORB_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(CheckStrength(player), 0x0010);
            L0012: if (JumpBelow) goto L005F;
            L0014: ShowMessage(player, isForwardMove, String083A); // You force the door open by muscle power.
            L0021: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L003F: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L005D: goto L0089;
            L005F: ShowMessage(player, isForwardMove, String0863); // The door is stuck shut.
            L006C: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0089: return; // RETURN;
        }

        private void FnITMDOORA_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, 0xE1, 0xE1);
            L0016: if (JumpEqual) goto L0063;
            L0018: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0036: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0054: ShowMessage(player, isForwardMove, String087B); // The Domicile Key opens the door!
            L0061: goto L008D;
            L0063: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0080: ShowMessage(player, isForwardMove, String089C); // The door is locked.
            L008D: return; // RETURN;
        }

        private void FnDETCTDOR_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L004E;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L004E;
            L0024: ax = HasUsedItem(player, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L004E;
            L0039: ax = HasUsedItem(player, 0xBE, 0xBE);
            L004C: if (JumpEqual) goto L0099;
            L004E: ShowMessage(player, isForwardMove, String08B0); // You have spotted a secret door!
            L005B: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0079: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0097: goto L00B6;
            L0099: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00B6: return; // RETURN;
        }

        private void FnLFTROTA_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOff(player, FlagTypeTile, 0x02);
            L0015: if (JumpNotEqual) goto L001A;
            L0017: goto L00C9;
            L001A: SetFlag(player, FlagTypeTile, 0x02, 0x01);
            L002E: bx = GetFacing(player);
            L0037: Compare(bx, 0x03);
            L003A: if (JumpBelowOrEqual) goto L003F;
            L003C: goto L00C9;
            L003F: switch (bx) {
                case 0:
                    goto L00A8;
                case 1:
                    goto L0066;
                case 2:
                    goto L0087;
                case 3:
                    goto L0046;
            }
            L0046: TeleportParty(player, 0x04, 0x01, GetCurrentTile(player), 0x00, isForwardMove);
            L0064: goto L00C9;
            L0066: TeleportParty(player, 0x04, 0x01, GetCurrentTile(player), 0x02, isForwardMove);
            L0085: goto L00C9;
            L0087: TeleportParty(player, 0x04, 0x01, GetCurrentTile(player), 0x03, isForwardMove);
            L00A6: goto L00C9;
            L00A8: TeleportParty(player, 0x04, 0x01, GetCurrentTile(player), 0x01, isForwardMove);
            L00C7: goto L00C9;
            L00C9: return; // RETURN;
        }

        private void FnLFTROTB_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOff(player, FlagTypeTile, 0x02);
            L0015: if (JumpNotEqual) goto L001A;
            L0017: goto L00EF;
            L001A: SetFlag(player, FlagTypeTile, 0x02, 0x01);
            L002E: bx = GetFacing(player);
            L0037: Compare(bx, 0x03);
            L003A: if (JumpBelowOrEqual) goto L003F;
            L003C: goto L00CA;
            L003F: switch (bx) {
                case 0:
                    goto L00A9;
                case 1:
                    goto L0068;
                case 2:
                    goto L0088;
                case 3:
                    goto L0046;
            }
            L0046: TeleportParty(player, 0x04, 0x01, GetCurrentTile(player), 0x02, isForwardMove);
            L0065: goto L00EF;
            L0068: TeleportParty(player, 0x04, 0x01, GetCurrentTile(player), 0x00, isForwardMove);
            L0086: goto L00EF;
            L0088: TeleportParty(player, 0x04, 0x01, GetCurrentTile(player), 0x01, isForwardMove);
            L00A7: goto L00EF;
            L00A9: TeleportParty(player, 0x04, 0x01, GetCurrentTile(player), 0x03, isForwardMove);
            L00C8: goto L00EF;
            L00CA: TeleportParty(player, 0x04, 0x01, GetCurrentTile(player), GetFacing(player), isForwardMove);
            L00ED: goto L00EF;
            L00EF: return; // RETURN;
        }

        private void FnBACKROTL_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOff(player, FlagTypeTile, 0x02);
            L0015: if (JumpNotEqual) goto L001A;
            L0017: goto L00EF;
            L001A: SetFlag(player, FlagTypeTile, 0x02, 0x01);
            L002E: bx = GetFacing(player);
            L0037: Compare(bx, 0x03);
            L003A: if (JumpBelowOrEqual) goto L003F;
            L003C: goto L00CA;
            L003F: switch (bx) {
                case 0:
                    goto L00A9;
                case 1:
                    goto L0068;
                case 2:
                    goto L0089;
                case 3:
                    goto L0046;
            }
            L0046: TeleportParty(player, 0x04, 0x01, GetCurrentTile(player), 0x01, isForwardMove);
            L0065: goto L00EF;
            L0068: TeleportParty(player, 0x04, 0x01, GetCurrentTile(player), 0x03, isForwardMove);
            L0087: goto L00EF;
            L0089: TeleportParty(player, 0x04, 0x01, GetCurrentTile(player), 0x00, isForwardMove);
            L00A7: goto L00EF;
            L00A9: TeleportParty(player, 0x04, 0x01, GetCurrentTile(player), 0x02, isForwardMove);
            L00C8: goto L00EF;
            L00CA: TeleportParty(player, 0x04, 0x01, GetCurrentTile(player), GetFacing(player), isForwardMove);
            L00ED: goto L00EF;
            L00EF: return; // RETURN;
        }

        private void FnRTROTA_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOff(player, FlagTypeTile, 0x02);
            L0015: if (JumpNotEqual) goto L001A;
            L0017: goto L00EF;
            L001A: SetFlag(player, FlagTypeTile, 0x02, 0x01);
            L002E: bx = GetFacing(player);
            L0037: Compare(bx, 0x03);
            L003A: if (JumpBelowOrEqual) goto L003F;
            L003C: goto L00CA;
            L003F: switch (bx) {
                case 0:
                    goto L00A9;
                case 1:
                    goto L0068;
                case 2:
                    goto L0088;
                case 3:
                    goto L0046;
            }
            L0046: TeleportParty(player, 0x04, 0x01, GetCurrentTile(player), 0x02, isForwardMove);
            L0065: goto L00EF;
            L0068: TeleportParty(player, 0x04, 0x01, GetCurrentTile(player), 0x00, isForwardMove);
            L0086: goto L00EF;
            L0088: TeleportParty(player, 0x04, 0x01, GetCurrentTile(player), 0x01, isForwardMove);
            L00A7: goto L00EF;
            L00A9: TeleportParty(player, 0x04, 0x01, GetCurrentTile(player), 0x03, isForwardMove);
            L00C8: goto L00EF;
            L00CA: TeleportParty(player, 0x04, 0x01, GetCurrentTile(player), GetFacing(player), isForwardMove);
            L00ED: goto L00EF;
            L00EF: return; // RETURN;
        }

        private void FnRTROTB_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOff(player, FlagTypeTile, 0x02);
            L0015: if (JumpNotEqual) goto L001A;
            L0017: goto L00EF;
            L001A: SetFlag(player, FlagTypeTile, 0x02, 0x01);
            L002E: bx = GetFacing(player);
            L0037: Compare(bx, 0x03);
            L003A: if (JumpBelowOrEqual) goto L003F;
            L003C: goto L00CA;
            L003F: switch (bx) {
                case 0:
                    goto L00A9;
                case 1:
                    goto L0067;
                case 2:
                    goto L0088;
                case 3:
                    goto L0046;
            }
            L0046: TeleportParty(player, 0x04, 0x01, GetCurrentTile(player), 0x00, isForwardMove);
            L0064: goto L00EF;
            L0067: TeleportParty(player, 0x04, 0x01, GetCurrentTile(player), 0x02, isForwardMove);
            L0086: goto L00EF;
            L0088: TeleportParty(player, 0x04, 0x01, GetCurrentTile(player), 0x03, isForwardMove);
            L00A7: goto L00EF;
            L00A9: TeleportParty(player, 0x04, 0x01, GetCurrentTile(player), 0x01, isForwardMove);
            L00C8: goto L00EF;
            L00CA: TeleportParty(player, 0x04, 0x01, GetCurrentTile(player), GetFacing(player), isForwardMove);
            L00ED: goto L00EF;
            L00EF: return; // RETURN;
        }

        private void FnBADMNSTR_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0037;
            L0010: AddEncounter(player, 0x01, 0x1F);
            L0022: AddEncounter(player, 0x02, 0x20);
            L0034: goto L0152;
            L0037: Compare(PartyCount(player), 0x0002);
            L0042: if (JumpNotEqual) goto L007D;
            L0044: AddEncounter(player, 0x01, 0x20);
            L0056: AddEncounter(player, 0x02, 0x20);
            L0068: AddEncounter(player, 0x03, 0x20);
            L007A: goto L0152;
            L007D: Compare(PartyCount(player), 0x0003);
            L0088: if (JumpNotEqual) goto L00E6;
            L008A: AddEncounter(player, 0x01, 0x1F);
            L009C: AddEncounter(player, 0x02, 0x20);
            L00AE: AddEncounter(player, 0x03, 0x21);
            L00C0: AddEncounter(player, 0x05, 0x1F);
            L00D2: AddEncounter(player, 0x06, 0x21);
            L00E4: goto L0152;
            L00E6: AddEncounter(player, 0x01, 0x21);
            L00F8: AddEncounter(player, 0x02, 0x21);
            L010A: AddEncounter(player, 0x03, 0x21);
            L011C: AddEncounter(player, 0x04, 0x21);
            L012E: AddEncounter(player, 0x05, 0x21);
            L0140: AddEncounter(player, 0x06, 0x21);
            L0152: return; // RETURN;
        }

        private void FnITEMAENC_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xB1);
            L0011: if (JumpEqual) goto L0041;
            L0013: AddTreasure(player, 0x01F4, 0x00, 0x00, 0x00, 0x00, 0xCE);
            L0032: ShowMessage(player, isForwardMove, String08D0); // Clerics use this room as a sanctuary.
            L003F: goto L006E;
            L0041: AddTreasure(player, 0x0BB8, 0x00, 0x00, 0x00, 0xCF, 0xB1);
            L0061: ShowMessage(player, isForwardMove, String08F6); // A scroll fall from a Cleric's robe.
            L006E: Compare(PartyCount(player), 0x0001);
            L0079: if (JumpNotEqual) goto L0090;
            L007B: AddEncounter(player, 0x01, 0x25);
            L008D: goto L0151;
            L0090: Compare(PartyCount(player), 0x0002);
            L009B: if (JumpNotEqual) goto L00C4;
            L009D: AddEncounter(player, 0x01, 0x25);
            L00AF: AddEncounter(player, 0x02, 0x25);
            L00C1: goto L0151;
            L00C4: Compare(PartyCount(player), 0x0003);
            L00CF: if (JumpNotEqual) goto L0109;
            L00D1: AddEncounter(player, 0x01, 0x25);
            L00E3: AddEncounter(player, 0x02, 0x25);
            L00F5: AddEncounter(player, 0x05, 0x25);
            L0107: goto L0151;
            L0109: AddEncounter(player, 0x01, 0x25);
            L011B: AddEncounter(player, 0x02, 0x25);
            L012D: AddEncounter(player, 0x05, 0x25);
            L013F: AddEncounter(player, 0x06, 0x25);
            L0151: return; // RETURN;
        }

        private void FnSPECITMB_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xCD);
            L0011: if (JumpEqual) goto L0041;
            L0013: AddTreasure(player, 0x004B, 0x00, 0x00, 0x00, 0x00, 0xCB);
            L0032: ShowMessage(player, isForwardMove, String091A); // Rogues use this room as a hideout.
            L003F: goto L006E;
            L0041: AddTreasure(player, 0x0DAC, 0x00, 0x00, 0x00, 0xD0, 0xCD);
            L0061: ShowMessage(player, isForwardMove, String093D); // A Barbarian drops some potions when she sees you.
            L006E: Compare(PartyCount(player), 0x0001);
            L0079: if (JumpNotEqual) goto L00A2;
            L007B: AddEncounter(player, 0x01, 0x23);
            L008D: AddEncounter(player, 0x02, 0x23);
            L009F: goto L0153;
            L00A2: Compare(PartyCount(player), 0x0002);
            L00AD: if (JumpNotEqual) goto L00F9;
            L00AF: AddEncounter(player, 0x01, 0x23);
            L00C1: AddEncounter(player, 0x02, 0x23);
            L00D3: AddEncounter(player, 0x05, 0x04);
            L00E5: AddEncounter(player, 0x06, 0x04);
            L00F7: goto L0153;
            L00F9: AddEncounter(player, 0x01, 0x23);
            L010B: AddEncounter(player, 0x02, 0x23);
            L011D: AddEncounter(player, 0x03, 0x23);
            L012F: AddEncounter(player, 0x05, 0x22);
            L0141: AddEncounter(player, 0x06, 0x22);
            L0153: return; // RETURN;
        }

        private void FnITEMCENC_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xCA);
            L0011: if (JumpEqual) goto L0041;
            L0013: AddTreasure(player, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xB6);
            L0032: ShowMessage(player, isForwardMove, String096F); // You sense evil in the room.
            L003F: goto L006D;
            L0041: AddTreasure(player, 0x1388, 0x00, 0x00, 0x00, 0x00, 0xCA);
            L0060: ShowMessage(player, isForwardMove, String098B); // You see a wand on the floor.
            L006D: Compare(PartyCount(player), 0x0001);
            L0078: if (JumpNotEqual) goto L00A1;
            L007A: AddEncounter(player, 0x02, 0x19);
            L008C: AddEncounter(player, 0x06, 0x1B);
            L009E: goto L0164;
            L00A1: Compare(PartyCount(player), 0x0002);
            L00AC: if (JumpNotEqual) goto L00F8;
            L00AE: AddEncounter(player, 0x01, 0x19);
            L00C0: AddEncounter(player, 0x02, 0x19);
            L00D2: AddEncounter(player, 0x05, 0x1B);
            L00E4: AddEncounter(player, 0x06, 0x1B);
            L00F6: goto L0164;
            L00F8: AddEncounter(player, 0x01, 0x1A);
            L010A: AddEncounter(player, 0x02, 0x1A);
            L011C: AddEncounter(player, 0x03, 0x19);
            L012E: AddEncounter(player, 0x04, 0x19);
            L0140: AddEncounter(player, 0x05, 0x1B);
            L0152: AddEncounter(player, 0x06, 0x1B);
            L0164: return; // RETURN;
        }

        private void FnITEMDECN_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x92);
            L0011: if (JumpEqual) goto L0041;
            L0013: AddTreasure(player, 0x02EE, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L0032: ShowMessage(player, isForwardMove, String09A8); // The stench of reptiles assails you.
            L003F: goto L006E;
            L0041: AddTreasure(player, 0x09C4, 0x00, 0x00, 0x00, 0xB7, 0x92);
            L0061: ShowMessage(player, isForwardMove, String09CC); // You hear hissing.
            L006E: Compare(PartyCount(player), 0x0001);
            L0079: if (JumpNotEqual) goto L00A2;
            L007B: AddEncounter(player, 0x01, 0x1C);
            L008D: AddEncounter(player, 0x02, 0x1E);
            L009F: goto L0165;
            L00A2: Compare(PartyCount(player), 0x0002);
            L00AD: if (JumpNotEqual) goto L00F9;
            L00AF: AddEncounter(player, 0x01, 0x1C);
            L00C1: AddEncounter(player, 0x02, 0x1E);
            L00D3: AddEncounter(player, 0x03, 0x1C);
            L00E5: AddEncounter(player, 0x04, 0x1E);
            L00F7: goto L0165;
            L00F9: AddEncounter(player, 0x01, 0x1D);
            L010B: AddEncounter(player, 0x02, 0x1D);
            L011D: AddEncounter(player, 0x03, 0x1E);
            L012F: AddEncounter(player, 0x04, 0x1E);
            L0141: AddEncounter(player, 0x05, 0x1C);
            L0153: AddEncounter(player, 0x06, 0x1C);
            L0165: return; // RETURN;
        }

        private void FnWEAPAENC_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x3A);
            L0011: if (JumpEqual) goto L0042;
            L0013: AddTreasure(player, 0x023F, 0x00, 0x00, 0x00, 0xCC, 0xCF);
            L0033: ShowMessage(player, isForwardMove, String09DE); // Rogues surprise you.
            L0040: goto L006E;
            L0042: AddTreasure(player, 0x04B0, 0x00, 0x00, 0x00, 0x00, 0x3A);
            L0061: ShowMessage(player, isForwardMove, String09F3); // A Knight drops a poleaxe as you approach.
            L006E: Compare(PartyCount(player), 0x0001);
            L0079: if (JumpNotEqual) goto L00A2;
            L007B: AddEncounter(player, 0x01, 0x26);
            L008D: AddEncounter(player, 0x02, 0x27);
            L009F: goto L01BD;
            L00A2: Compare(PartyCount(player), 0x0002);
            L00AD: if (JumpNotEqual) goto L00E8;
            L00AF: AddEncounter(player, 0x01, 0x26);
            L00C1: AddEncounter(player, 0x02, 0x27);
            L00D3: AddEncounter(player, 0x05, 0x25);
            L00E5: goto L01BD;
            L00E8: Compare(PartyCount(player), 0x0003);
            L00F3: if (JumpNotEqual) goto L0151;
            L00F5: AddEncounter(player, 0x01, 0x26);
            L0107: AddEncounter(player, 0x02, 0x25);
            L0119: AddEncounter(player, 0x03, 0x27);
            L012B: AddEncounter(player, 0x05, 0x25);
            L013D: AddEncounter(player, 0x06, 0x27);
            L014F: goto L01BD;
            L0151: AddEncounter(player, 0x01, 0x26);
            L0163: AddEncounter(player, 0x02, 0x26);
            L0175: AddEncounter(player, 0x03, 0x24);
            L0187: AddEncounter(player, 0x04, 0x23);
            L0199: AddEncounter(player, 0x05, 0x27);
            L01AB: AddEncounter(player, 0x06, 0x25);
            L01BD: return; // RETURN;
        }

        private void FnWEAPBENC_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x49);
            L0011: if (JumpEqual) goto L0041;
            L0013: AddTreasure(player, 0x0384, 0x00, 0x00, 0x00, 0x00, 0xC9);
            L0032: ShowMessage(player, isForwardMove, String0A1D); // Nightmares loom up before you.
            L003F: goto L006E;
            L0041: AddTreasure(player, 0x1388, 0x00, 0x00, 0x00, 0xCB, 0x49);
            L0061: ShowMessage(player, isForwardMove, String0A3C); // A Nightmare throws a bow aside to attack.
            L006E: Compare(PartyCount(player), 0x0001);
            L0079: if (JumpNotEqual) goto L0090;
            L007B: AddEncounter(player, 0x01, 0x13);
            L008D: goto L0151;
            L0090: Compare(PartyCount(player), 0x0002);
            L009B: if (JumpNotEqual) goto L00C4;
            L009D: AddEncounter(player, 0x01, 0x13);
            L00AF: AddEncounter(player, 0x02, 0x14);
            L00C1: goto L0151;
            L00C4: Compare(PartyCount(player), 0x0003);
            L00CF: if (JumpNotEqual) goto L0109;
            L00D1: AddEncounter(player, 0x01, 0x14);
            L00E3: AddEncounter(player, 0x02, 0x13);
            L00F5: AddEncounter(player, 0x03, 0x14);
            L0107: goto L0151;
            L0109: AddEncounter(player, 0x01, 0x13);
            L011B: AddEncounter(player, 0x02, 0x13);
            L012D: AddEncounter(player, 0x03, 0x14);
            L013F: AddEncounter(player, 0x04, 0x14);
            L0151: return; // RETURN;
        }

        private void FnARMRAENC_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x7F);
            L0011: if (JumpEqual) goto L0042;
            L0013: AddTreasure(player, 0x00C8, 0x00, 0x00, 0x00, 0x4F, 0x02);
            L0033: ShowMessage(player, isForwardMove, String0A66); // You stumble on some Dwarf Knights.
            L0040: goto L006F;
            L0042: AddTreasure(player, 0x1770, 0x00, 0x00, 0x00, 0xCF, 0x7F);
            L0062: ShowMessage(player, isForwardMove, String0A89); // The brilliant chainmail worn by a Knight blinds you.
            L006F: Compare(PartyCount(player), 0x0001);
            L007A: if (JumpNotEqual) goto L0091;
            L007C: AddEncounter(player, 0x01, 0x28);
            L008E: goto L0152;
            L0091: Compare(PartyCount(player), 0x0002);
            L009C: if (JumpNotEqual) goto L00C5;
            L009E: AddEncounter(player, 0x01, 0x28);
            L00B0: AddEncounter(player, 0x02, 0x28);
            L00C2: goto L0152;
            L00C5: Compare(PartyCount(player), 0x0003);
            L00D0: if (JumpNotEqual) goto L010A;
            L00D2: AddEncounter(player, 0x01, 0x28);
            L00E4: AddEncounter(player, 0x02, 0x28);
            L00F6: AddEncounter(player, 0x04, 0x28);
            L0108: goto L0152;
            L010A: AddEncounter(player, 0x01, 0x28);
            L011C: AddEncounter(player, 0x02, 0x28);
            L012E: AddEncounter(player, 0x03, 0x28);
            L0140: AddEncounter(player, 0x06, 0x28);
            L0152: return; // RETURN;
        }

        private void FnARMRBENC_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x5A);
            L0011: if (JumpEqual) goto L0040;
            L0013: AddTreasure(player, 0x0000, 0x00, 0x00, 0x00, 0x00, 0xCE);
            L0031: ShowMessage(player, isForwardMove, String0ABE); // You enter a den of thieves.
            L003E: goto L006B;
            L0040: AddTreasure(player, 0x0000, 0x00, 0x00, 0x00, 0x00, 0x5A);
            L005E: ShowMessage(player, isForwardMove, String0ADA); // A Halfling Thief tries to wield a large shield.
            L006B: Compare(PartyCount(player), 0x0001);
            L0076: if (JumpNotEqual) goto L00B0;
            L0078: AddEncounter(player, 0x01, 0x24);
            L008A: AddEncounter(player, 0x02, 0x24);
            L009C: AddEncounter(player, 0x05, 0x24);
            L00AE: goto L011C;
            L00B0: AddEncounter(player, 0x01, 0x24);
            L00C2: AddEncounter(player, 0x02, 0x24);
            L00D4: AddEncounter(player, 0x03, 0x24);
            L00E6: AddEncounter(player, 0x04, 0x24);
            L00F8: AddEncounter(player, 0x05, 0x24);
            L010A: AddEncounter(player, 0x06, 0x24);
            L011C: return; // RETURN;
        }

        private void FnKEYENC_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xE1);
            L0011: if (JumpEqual) goto L0042;
            L0013: AddTreasure(player, 0x03E8, 0x00, 0x00, 0x00, 0xB7, 0xCE);
            L0033: ShowMessage(player, isForwardMove, String0B0A); // The room is jammed with Rogues.
            L0040: goto L006D;
            L0042: AddTreasure(player, 0x0000, 0x00, 0x00, 0x00, 0x00, 0xE1);
            L0060: ShowMessage(player, isForwardMove, String0B2A); // A Ranger wears the King's Domicile Key around his neck.
            L006D: Compare(PartyCount(player), 0x0001);
            L0078: if (JumpNotEqual) goto L00A1;
            L007A: AddEncounter(player, 0x01, 0x27);
            L008C: AddEncounter(player, 0x05, 0x25);
            L009E: goto L0176;
            L00A1: Compare(PartyCount(player), 0x0002);
            L00AC: if (JumpNotEqual) goto L010A;
            L00AE: AddEncounter(player, 0x01, 0x27);
            L00C0: AddEncounter(player, 0x02, 0x26);
            L00D2: AddEncounter(player, 0x03, 0x28);
            L00E4: AddEncounter(player, 0x05, 0x25);
            L00F6: AddEncounter(player, 0x06, 0x25);
            L0108: goto L0176;
            L010A: AddEncounter(player, 0x01, 0x27);
            L011C: AddEncounter(player, 0x02, 0x28);
            L012E: AddEncounter(player, 0x03, 0x26);
            L0140: AddEncounter(player, 0x04, 0x28);
            L0152: AddEncounter(player, 0x05, 0x27);
            L0164: AddEncounter(player, 0x06, 0x25);
            L0176: return; // RETURN;
        }

        private void FnTELMESGA_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, isForwardMove, String0B62); // There is a teleport in the south wall.
            L0010: return; // RETURN;
        }

        private void FnTELMESGB_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, isForwardMove, String0B89); // There is a teleport to the south.
            L0010: return; // RETURN;
        }

        private void FnTELMESSC_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, isForwardMove, String0BAB); // There is a teleport to the north.
            L0010: return; // RETURN;
        }

        private void FnGOLDAENC_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, FlagTypeDungeon, FlagKingsDomicileGold), 0x0001);
            L0017: if (JumpNotEqual) goto L003A;
            L0019: AddTreasure(player, 0x01F4, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L0038: goto L006F;
            L003A: AddTreasure(player, 0x1388, 0x00, 0x00, 0x00, 0xAB, 0xA8);
            L005A: SetFlag(player, FlagTypeDungeon, FlagKingsDomicileGold, 0x01);
            L006F: ShowMessage(player, isForwardMove, String0BCD); // Banshees haunt this room.
            L007C: Compare(PartyCount(player), 0x0001);
            L0087: if (JumpNotEqual) goto L009E;
            L0089: AddEncounter(player, 0x01, 0x0E);
            L009B: goto L013D;
            L009E: Compare(PartyCount(player), 0x0002);
            L00A9: if (JumpNotEqual) goto L00E3;
            L00AB: AddEncounter(player, 0x01, 0x0E);
            L00BD: AddEncounter(player, 0x02, 0x0E);
            L00CF: AddEncounter(player, 0x03, 0x0E);
            L00E1: goto L013D;
            L00E3: AddEncounter(player, 0x01, 0x0F);
            L00F5: AddEncounter(player, 0x02, 0x10);
            L0107: AddEncounter(player, 0x03, 0x0F);
            L0119: AddEncounter(player, 0x05, 0x11);
            L012B: AddEncounter(player, 0x06, 0x10);
            L013D: return; // RETURN;
        }

        private void FnGOLDBENC_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, isForwardMove, String0BE7); // Deinons protect a chest.
            L0010: Compare(GetFlag(player, FlagTypeDungeon, FlagKingsDomicileGold1), 0x0001);
            L0024: if (JumpNotEqual) goto L0047;
            L0026: AddTreasure(player, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0x04);
            L0045: goto L007C;
            L0047: AddTreasure(player, 0x1770, 0x00, 0x00, 0x00, 0xB6, 0xCE);
            L0067: SetFlag(player, FlagTypeDungeon, FlagKingsDomicileGold1, 0x01);
            L007C: Compare(PartyCount(player), 0x0001);
            L0087: if (JumpNotEqual) goto L009E;
            L0089: AddEncounter(player, 0x01, 0x1E);
            L009B: goto L015F;
            L009E: Compare(PartyCount(player), 0x0002);
            L00A9: if (JumpNotEqual) goto L00D2;
            L00AB: AddEncounter(player, 0x01, 0x1E);
            L00BD: AddEncounter(player, 0x02, 0x1E);
            L00CF: goto L015F;
            L00D2: Compare(PartyCount(player), 0x0003);
            L00DD: if (JumpNotEqual) goto L0117;
            L00DF: AddEncounter(player, 0x01, 0x1E);
            L00F1: AddEncounter(player, 0x02, 0x1E);
            L0103: AddEncounter(player, 0x04, 0x1E);
            L0115: goto L015F;
            L0117: AddEncounter(player, 0x01, 0x1E);
            L0129: AddEncounter(player, 0x02, 0x1E);
            L013B: AddEncounter(player, 0x03, 0x1E);
            L014D: AddEncounter(player, 0x04, 0x1E);
            L015F: return; // RETURN;
        }

        private void FnBACKROTR_36(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOff(player, FlagTypeTile, 0x02);
            L0015: if (JumpNotEqual) goto L001A;
            L0017: goto L00EF;
            L001A: SetFlag(player, FlagTypeTile, 0x02, 0x01);
            L002E: bx = GetFacing(player);
            L0037: Compare(bx, 0x03);
            L003A: if (JumpBelowOrEqual) goto L003F;
            L003C: goto L00CA;
            L003F: switch (bx) {
                case 0:
                    goto L00A9;
                case 1:
                    goto L0068;
                case 2:
                    goto L0089;
                case 3:
                    goto L0046;
            }
            L0046: TeleportParty(player, 0x04, 0x01, GetCurrentTile(player), 0x01, isForwardMove);
            L0065: goto L00EF;
            L0068: TeleportParty(player, 0x04, 0x01, GetCurrentTile(player), 0x03, isForwardMove);
            L0087: goto L00EF;
            L0089: TeleportParty(player, 0x04, 0x01, GetCurrentTile(player), 0x00, isForwardMove);
            L00A7: goto L00EF;
            L00A9: TeleportParty(player, 0x04, 0x01, GetCurrentTile(player), 0x02, isForwardMove);
            L00C8: goto L00EF;
            L00CA: TeleportParty(player, 0x04, 0x01, GetCurrentTile(player), GetFacing(player), isForwardMove);
            L00ED: goto L00EF;
            L00EF: return; // RETURN;
        }

        private void FnSTRSMESA_37(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, isForwardMove, String0C00); // Stairs through the east gateway lead upstairs.
            L0010: return; // RETURN;
        }

        private void FnSTRSMESB_38(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, isForwardMove, String0C2F); // There are stairs to the north beyond the gateway.
            L0010: return; // RETURN;
        }

        private void FnPLATFMMS_39(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, isForwardMove, String0C61); // There is an elevator platform to the north.
            L0010: return; // RETURN;
        }

        private void FnSTRSMESS_3A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, isForwardMove, String0C8D); // Stairs through the west gateway lead down a level.
            L0010: return; // RETURN;
        }

        private void FnNPCCHATA_3B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, isForwardMove, String0CC0); // You encounter a Human Wizard.
            L0010: ShowPortrait(player, 0x002B);
            L001D: Compare(GetRandom(0x000F), 0x000A);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, isForwardMove, String0CDE); // This is the lowest level of Cleowyn's Palace, yet you are merely at the beginning of the dungeon proper.
            L003C: goto L004B;
            L003E: ShowMessage(player, isForwardMove, String0D47); // The Human Wizard chortles softly.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATB_3C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, isForwardMove, String0D69); // You encounter a Gnome Thief.
            L0010: ShowPortrait(player, 0x0024);
            L001D: Compare(GetRandom(0x000F), 0x0009);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, isForwardMove, String0D86); // In the king's quarters is an elevator that will lift you up to the King's Palace. Cleowyn used this elevator to  by-pass the traps around his throne.
            L003C: goto L004B;
            L003E: ShowMessage(player, isForwardMove, String0E1C); // The Gnome Thief tiptoes away as you draw near.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATC_3D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, isForwardMove, String0E4B); // You encounter a Gnome Barbarian.
            L0010: ShowPortrait(player, 0x0019);
            L001D: Compare(GetRandom(0x000F), 0x0005);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, isForwardMove, String0E6C); // The name of the Elemental bound by the wizard Arnakkian is En-li-kil. This Elemental commands Time itself.
            L003C: goto L0058;
            L003E: DamagePlayer(player, 0x004B);
            L004B: ShowMessage(player, isForwardMove, String0ED7); // The Gnome Barbarian warns you to stay away.
            L0058: return; // RETURN;
        }

        private void FnSTRSTELE_3E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x03, 0x03, 0xE0, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

    }
}
