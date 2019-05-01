#pragma warning disable
using System.Collections.Generic;
using XPT.Legacy;
using XPT.Legacy.Entities;

namespace XPT.Legacy.Maps {
    class YserMap26 : AMapScripted {
        protected override int MapIndex => 26;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap26() {
            MapEvent01 = FnLAVA_01;
            MapEvent02 = FnTEMPEST_02;
            MapEvent03 = FnDUNGEON_03;
            MapEvent04 = FnHEAVENS_04;
            MapEvent05 = FnTXTTEMPS_05;
            MapEvent06 = FnTXTHEAVN_06;
            MapEvent07 = FnTXTCSTLG_07;
            MapEvent09 = FnTXTLOOKO_09;
            MapEvent0C = FnBDOORCGC_0C;
            MapEvent10 = FnRAPID_10;
            MapEvent11 = FnRIVER_11;
            MapEvent12 = FnTXTPHNX_12;
            MapEvent13 = FnDBENCPHO_13;
            MapEvent14 = FnDBENCA_14;
            MapEvent15 = FnDBENCB_15;
            MapEvent16 = FnDBENCC_16;
            MapEvent17 = FnDBENCD_17;
            MapEvent18 = FnBAZZENCA_18;
            MapEvent19 = FnBAZZENCB_19;
            MapEvent1A = FnBAZZENCC_1A;
            MapEvent1B = FnTOELVES_1B;
            MapEvent1C = FnPHOEGURD_1C;
            MapEvent1D = FnTXTBAZZA_1D;
            MapEvent1E = FnTXTBAZZB_1E;
            MapEvent1F = FnTXTBAZZC_1F;
            MapEvent20 = FnTXTBAZZD_20;
            MapEvent21 = FnPHOEREW_21;
            MapEvent24 = FnMYSTICS_24;
            MapEvent25 = FnFNTNBAZZ_25;
            MapEvent26 = FnLOOKENCA_26;
            MapEvent2A = FnTXTLOOKB_2A;
            MapEvent2B = FnFNTNLOOK_2B;
            MapEvent2C = FnCSTLENCA_2C;
            MapEvent2D = FnCSTLENCB_2D;
            MapEvent2E = FnCSTLENCC_2E;
            MapEvent2F = FnCSTLENCD_2F;
            MapEvent30 = FnCSTLENCE_30;
            MapEvent35 = FnTXTCSTLA_35;
            MapEvent36 = FnTXTCSTLB_36;
            MapEvent37 = FnFNTNHEAL_37;
            MapEvent38 = FnFNTNMANA_38;
            MapEvent3B = FnTXTCSTLC_3B;
        }
        
        // === Strings ================================================
        private const string String03FC = "You stumble into the lava river and die.";
        private const string String0425 = "This gate leads to the entrance of Arnakkian's Arena.";
        private const string String045B = "Of all the winds, the TEMPEST is the most violent and dangerous.";
        private const string String049C = "Enter HEAVEN'S FURY if you must.  It is here Voranti cursed the winds.";
        private const string String04E3 = "A doorway leads to the town of Castlegate, a village just outside Arnakkian's Castle.";
        private const string String0539 = "It is rumored that a band of dwarves once lived behind the doors of LookOut.";
        private const string String0586 = "With a massive effort, you manage to force the door open.";
        private const string String05C0 = "The door is stuck and will not open.";
        private const string String05E5 = "A plaque reads..";
        private const string String05F6 = "'Thanks to the gracious generosity of the Mage Council, the survivors of the Arnakkian disaster hereby proclaim a new teleport to the top.'";
        private const string String0682 = "Fighting the raging River of Eternity taps your life energy.";
        private const string String06BF = "You have died.";
        private const string String06CE = "The Phoenix is being reborn and may not be disturbed.";
        private const string String0704 = "Ahead, bound by the River of Eternity, is the shadow of the Phoenix Firebird. ";
        private const string String0753 = "The raging waters of the river look daunting.";
        private const string String0781 = "You hear the sound of rushing water behind the wall.";
        private const string String07B6 = "You also hear muffled roars.";
        private const string String07D3 = "Loose rocks tumble away, revealing a narrow passageway down.";
        private const string String0810 = "A Gnome Wizard greets you.";
        private const string String082B = "'Thank you for helping my master the Phoenix be reborn.";
        private const string String0863 = "The Phoenix may no longer be disturbed.'";
        private const string String088C = "'I am the Guardian of the Phoenix.  That you have passed my Dragon Guards is proof of your courage.";
        private const string String08F0 = "The way is now clear for you to meet the Phoenix.";
        private const string String0922 = "It is time for the Phoenix to die and so be reborn from its own ashes.";
        private const string String0969 = "Go!  Let the glorious Phoenix die and be renewed!'";
        private const string String099C = "A frightened Halfling Cleric hides in the shadows.";
        private const string String09CF = "'You must do something about these trolls.  They're everywhere.'";
        private const string String0A10 = "An exhausted Dwarf Knight hides in a large barrel.";
        private const string String0A43 = "'Hail!  I welcome your help.  These trolls have been giving me fits.'";
        private const string String0A89 = "A Gnome Wizard suddenly appears.";
        private const string String0AAA = "'Past the CastleGates and past the Elves, you will find a place where the blue light of the sky meets the underworld below.'";
        private const string String0B27 = "An Elf Ranger is delighted at your presense.";
        private const string String0B54 = "'I got clobbered by Andreas, the Earth Elemental!  I wish you luck in your adventurers.'";
        private const string String0BAD = "You feel a sudden increase in your Dexterity.";
        private const string String0BDB = "Nothing happens.";
        private const string String0BEC = "A small band of gypsies has formed camp in an old bazaar stall.";
        private const string String0C2C = "A young gypsy stares at you, gestures you closer, and whispers..";
        private const string String0C6D = "'It is written on the Lava Walls that a Hero will someday reach the end of the rainbow and confront time.'";
        private const string String0CD8 = "He pauses, then says, 'Go now, before more Trolls come!  Go!' ";
        private const string String0D17 = "You sip the cool purple waters of the ElfFoot Fountain";
        private const string String0D4E = "You gain the skill of Rune Reading!";
        private const string String0D72 = "You gain the Channel skill!";
        private const string String0D8E = "You gain the Staff skill!";
        private const string String0DA8 = "You gain the Deep Trance skill!";
        private const string String0DC8 = "Nothing happens.";
        private const string String0DD9 = "The purple waters of the ElfFoot Fountain slip through your fingers before you can wet your lips.";
        private const string String0E3B = "An inscription on the wall reads...";
        private const string String0E5F = "'We, the Dwarves of NottiRock, seek brightly colored metals to forge magnificent treasures.'";
        private const string String0EBC = "Ranger banners decorate the woodwork of Lookout Fountain.";
        private const string String0EF6 = "You gain the skill of Stamina!";
        private const string String0F15 = "You gain the skill of Furtiveness!";
        private const string String0F38 = "You gain the skill of Reading Tracks!";
        private const string String0F5E = "You gain the skill of Archery!";
        private const string String0F7D = "The waters are refreshing, but not enlightening!";
        private const string String0FAE = "A message is etched on wall...";
        private const string String0FCD = "'The runes seem to spell names.  That is the way to Arnakkian.'";
        private const string String100D = "A Human Barbarian belches, then looks up at you.";
        private const string String103E = "'Andreas built a great pit. Two.'";
        private const string String1060 = "Holding up three fingers, he repeats...";
        private const string String1088 = "'Two.  Must need two to cross.'";
        private const string String10A8 = "DayFrost Fountain restores your Health.";
        private const string String10D0 = "NightFrost Fountain renews your Mana.";
        private const string String10F6 = "A Phantasm appears...";
        private const string String110C = "'Dare time?  Yes?  Ah, adventurers should not challenge En-Li-Kil!'";
        private const string String1150 = "The Phantasm drains your life energies.";
        private const string String1178 = "You have died.";
        
        // === Functions ================================================
        private void FnLAVA_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String03FC); // You stumble into the lava river and die.
            L0010: DamagePlayer(player, GetMaxHits(player));
            L0021: return; // RETURN;
        }

        private void FnTEMPEST_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x35, 0x01, 0x4F, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnDUNGEON_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0425); // This gate leads to the entrance of Arnakkian's Arena.
            L0010: TeleportParty(player, 0x36, 0x02, 0x40, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnHEAVENS_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x35, 0x01, 0xF6, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTXTTEMPS_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String045B); // Of all the winds, the TEMPEST is the most violent and dangerous.
            L0010: return; // RETURN;
        }

        private void FnTXTHEAVN_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String049C); // Enter HEAVEN'S FURY if you must.  It is here Voranti cursed the winds.
            L0010: return; // RETURN;
        }

        private void FnTXTCSTLG_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String04E3); // A doorway leads to the town of Castlegate, a village just outside Arnakkian's Castle.
            L0010: return; // RETURN;
        }

        private void FnTXTLOOKO_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0539); // It is rumored that a band of dwarves once lived behind the doors of LookOut.
            L0010: return; // RETURN;
        }

        private void FnBDOORCGC_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(CheckStrength(player), 0x0014);
            L0012: if (JumpBelow) goto L0041;
            L0014: ShowMessage(player, String0586); // With a massive effort, you manage to force the door open.
            L0021: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L003F: goto L004E;
            L0041: ShowMessage(player, String05C0); // The door is stuck and will not open.
            L004E: return; // RETURN;
        }

        private void FnRAPID_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, FlagTypeDungeon, FlagLabyrinthICastleGateTeleport, 0x01);
            L0018: ShowMessage(player, String05E5); // A plaque reads..
            L0025: ShowMessage(player, String05F6); // 'Thanks to the gracious generosity of the Mage Council, the survivors of the Arnakkian disaster hereby proclaim a new teleport to the top.'
            L0032: TeleportParty(player, 0x33, 0x01, GetCurrentTile(player), 0x02, isForwardMove);
            L0051: return; // RETURN;
        }

        private void FnRIVER_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0682); // Fighting the raging River of Eternity taps your life energy.
            L0010: ax = GetMaxHits(player);
            L0017: bx = 0x0004;
            L001A: dx = ax % bx; ax = ax / bx;
            L001D: DamagePlayer(player, ax);
            L003F: return; // RETURN;
        }

        private void FnTXTPHNX_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOn(player, FlagTypeDungeon, FlagLabryinthIVPhoenixReborn1);
            L0016: if (JumpEqual) goto L0028;
            L0018: ShowMessage(player, String06CE); // The Phoenix is being reborn and may not be disturbed.
            L0025: goto L00A7;
            L0028: ax = IsFlagOn(player, FlagTypeDungeon, FlagLabryinthIVPhoenixReborn);
            L003B: if (JumpEqual) goto L008D;
            L003D: ShowMessage(player, String0704); // Ahead, bound by the River of Eternity, is the shadow of the Phoenix Firebird. 
            L004A: ShowMessage(player, String0753); // The raging waters of the river look daunting.
            L0057: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x01);
            L0071: SetWallItem(player, 0x01, GetCurrentTile(player), 0x02);
            L008B: goto L00A7;
            L008D: ShowMessage(player, String0781); // You hear the sound of rushing water behind the wall.
            L009A: ShowMessage(player, String07B6); // You also hear muffled roars.
            L00A7: return; // RETURN;
        }

        private void FnDBENCPHO_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x0E);
            L0015: AddEncounter(player, 0x02, 0x0E);
            L0027: AddEncounter(player, 0x03, 0x25);
            L0039: AddEncounter(player, 0x04, 0x25);
            L004B: AddEncounter(player, 0x06, 0x26);
            L005D: return; // RETURN;
        }

        private void FnDBENCA_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x19);
            L0015: AddEncounter(player, 0x02, 0x19);
            L0027: AddEncounter(player, 0x03, 0x19);
            L0039: AddEncounter(player, 0x04, 0x19);
            L004B: return; // RETURN;
        }

        private void FnDBENCB_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x19);
            L0015: AddEncounter(player, 0x02, 0x19);
            L0027: AddEncounter(player, 0x03, 0x1A);
            L0039: AddEncounter(player, 0x04, 0x1A);
            L004B: AddTreasure(player, 0x1388, 0x00, 0x00, 0x00, 0x00, 0x71);
            L006A: return; // RETURN;
        }

        private void FnDBENCC_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x19);
            L0015: AddEncounter(player, 0x02, 0x19);
            L0027: AddEncounter(player, 0x03, 0x18);
            L0039: AddEncounter(player, 0x04, 0x18);
            L004B: AddEncounter(player, 0x05, 0x1A);
            L005D: AddEncounter(player, 0x06, 0x1A);
            L006F: return; // RETURN;
        }

        private void FnDBENCD_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x24);
            L0015: AddEncounter(player, 0x02, 0x24);
            L0027: return; // RETURN;
        }

        private void FnBAZZENCA_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x1B);
            L0015: AddEncounter(player, 0x02, 0x1B);
            L0027: AddEncounter(player, 0x03, 0x1C);
            L0039: AddEncounter(player, 0x04, 0x1C);
            L004B: return; // RETURN;
        }

        private void FnBAZZENCB_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x1C);
            L0015: AddEncounter(player, 0x02, 0x1C);
            L0027: AddEncounter(player, 0x03, 0x1C);
            L0039: AddEncounter(player, 0x04, 0x1C);
            L004B: AddTreasure(player, 0x1388, 0x00, 0x00, 0x00, 0x00, 0x76);
            L006A: return; // RETURN;
        }

        private void FnBAZZENCC_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x0F);
            L0015: AddEncounter(player, 0x02, 0x10);
            L0027: AddEncounter(player, 0x03, 0x11);
            L0039: AddEncounter(player, 0x04, 0x1C);
            L004B: ax = HasItem(player, 0xEF);
            L0059: if (JumpEqual) goto L007C;
            L005B: AddTreasure(player, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0xD0);
            L007A: goto L009B;
            L007C: AddTreasure(player, 0x1388, 0x00, 0x00, 0x00, 0x00, 0xEF);
            L009B: return; // RETURN;
        }

        private void FnTOELVES_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String07D3); // Loose rocks tumble away, revealing a narrow passageway down.
            L0010: TeleportParty(player, 0x37, 0x01, 0x1A, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnPHOEGURD_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002D);
            L0010: ShowMessage(player, String0810); // A Gnome Wizard greets you.
            L001D: ax = IsFlagOn(player, FlagTypeDungeon, FlagLabryinthIVPhoenixReborn1);
            L0030: if (JumpEqual) goto L004E;
            L0032: ShowMessage(player, String082B); // 'Thank you for helping my master the Phoenix be reborn.
            L003F: ShowMessage(player, String0863); // The Phoenix may no longer be disturbed.'
            L004C: goto L0097;
            L004E: ShowMessage(player, String088C); // 'I am the Guardian of the Phoenix.  That you have passed my Dragon Guards is proof of your courage.
            L005B: ShowMessage(player, String08F0); // The way is now clear for you to meet the Phoenix.
            L0068: ShowMessage(player, String0922); // It is time for the Phoenix to die and so be reborn from its own ashes.
            L0075: ShowMessage(player, String0969); // Go!  Let the glorious Phoenix die and be renewed!'
            L0082: SetFlag(player, FlagTypeDungeon, FlagLabryinthIVPhoenixReborn, 0x01);
            L0097: return; // RETURN;
        }

        private void FnTXTBAZZA_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0029);
            L0010: ShowMessage(player, String099C); // A frightened Halfling Cleric hides in the shadows.
            L001D: ShowMessage(player, String09CF); // 'You must do something about these trolls.  They're everywhere.'
            L002A: return; // RETURN;
        }

        private void FnTXTBAZZB_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001C);
            L0010: ShowMessage(player, String0A10); // An exhausted Dwarf Knight hides in a large barrel.
            L001D: ShowMessage(player, String0A43); // 'Hail!  I welcome your help.  These trolls have been giving me fits.'
            L002A: return; // RETURN;
        }

        private void FnTXTBAZZC_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002D);
            L0010: ShowMessage(player, String0A89); // A Gnome Wizard suddenly appears.
            L001D: ShowMessage(player, String0AAA); // 'Past the CastleGates and past the Elves, you will find a place where the blue light of the sky meets the underworld below.'
            L002A: return; // RETURN;
        }

        private void FnTXTBAZZD_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001F);
            L0010: ShowMessage(player, String0B27); // An Elf Ranger is delighted at your presense.
            L001D: ShowMessage(player, String0B54); // 'I got clobbered by Andreas, the Earth Elemental!  I wish you luck in your adventurers.'
            L002A: return; // RETURN;
        }

        private void FnPHOEREW_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagModAttr_Map26Dex));
            L0016: if (JumpNotEqual) goto L0063;
            L0018: SetFlag(player, FlagTypeDungeon, FlagModAttr_Map26Dex, 0x01);
            L002D: SetFlag(player, FlagTypeDungeon, FlagLabryinthIVPhoenixReborn1, 0x01);
            L0042: ModifyAttribute(player, 0x04, 0x00C8);
            L0054: ShowMessage(player, String0BAD); // You feel a sudden increase in your Dexterity.
            L0061: goto L0070;
            L0063: ShowMessage(player, String0BDB); // Nothing happens.
            L0070: return; // RETURN;
        }

        private void FnMYSTICS_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0016);
            L0010: ShowMessage(player, String0BEC); // A small band of gypsies has formed camp in an old bazaar stall.
            L001D: ShowMessage(player, String0C2C); // A young gypsy stares at you, gestures you closer, and whispers..
            L002A: ShowMessage(player, String0C6D); // 'It is written on the Lava Walls that a Hero will someday reach the end of the rainbow and confront time.'
            L0037: ShowMessage(player, String0CD8); // He pauses, then says, 'Go now, before more Trolls come!  Go!' 
            L0044: return; // RETURN;
        }

        private void FnFNTNBAZZ_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagLabryinthIVTeachSkill));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L011A;
            L001B: SetFlag(player, FlagTypeDungeon, FlagLabryinthIVTeachSkill, 0x01);
            L0030: ShowPortrait(player, 0x0042);
            L003D: ShowMessage(player, String0D17); // You sip the cool purple waters of the ElfFoot Fountain
            L004A: RefreshCompareFlags(GetSkillLevel(player, 0x14));
            L0058: if (JumpNotEqual) goto L007B;
            L005A: SetSkillLevel(player, 0x14, 0x01);
            L006B: ShowMessage(player, String0D4E); // You gain the skill of Rune Reading!
            L0078: goto L0118;
            L007B: RefreshCompareFlags(GetSkillLevel(player, 0x16));
            L0089: if (JumpNotEqual) goto L00AB;
            L008B: SetSkillLevel(player, 0x16, 0x01);
            L009C: ShowMessage(player, String0D72); // You gain the Channel skill!
            L00A9: goto L0118;
            L00AB: RefreshCompareFlags(GetSkillLevel(player, 0x15));
            L00B9: if (JumpNotEqual) goto L00DB;
            L00BB: SetSkillLevel(player, 0x15, 0x01);
            L00CC: ShowMessage(player, String0D8E); // You gain the Staff skill!
            L00D9: goto L0118;
            L00DB: RefreshCompareFlags(GetSkillLevel(player, 0x17));
            L00E9: if (JumpNotEqual) goto L010B;
            L00EB: SetSkillLevel(player, 0x17, 0x01);
            L00FC: ShowMessage(player, String0DA8); // You gain the Deep Trance skill!
            L0109: goto L0118;
            L010B: ShowMessage(player, String0DC8); // Nothing happens.
            L0118: goto L0127;
            L011A: ShowMessage(player, String0DD9); // The purple waters of the ElfFoot Fountain slip through your fingers before you can wet your lips.
            L0127: return; // RETURN;
        }

        private void FnLOOKENCA_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x1E);
            L0015: AddEncounter(player, 0x02, 0x1E);
            L0027: AddEncounter(player, 0x03, 0x25);
            L0039: AddEncounter(player, 0x04, 0x25);
            L004B: AddEncounter(player, 0x05, 0x1F);
            L005D: AddEncounter(player, 0x06, 0x1F);
            L006F: return; // RETURN;
        }

        private void FnTXTLOOKB_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0E3B); // An inscription on the wall reads...
            L0010: ShowRunes(player, String0E5F); // 'We, the Dwarves of NottiRock, seek brightly colored metals to forge magnificent treasures.'
            L001D: return; // RETURN;
        }

        private void FnFNTNLOOK_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: ShowMessage(player, String0EBC); // Ranger banners decorate the woodwork of Lookout Fountain.
            L001D: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagLabryinthIVTeachSkill1));
            L0030: if (JumpEqual) goto L0035;
            L0032: goto L0118;
            L0035: SetFlag(player, FlagTypeDungeon, FlagLabryinthIVTeachSkill1, 0x01);
            L004A: RefreshCompareFlags(GetSkillLevel(player, 0x09));
            L0058: if (JumpNotEqual) goto L007B;
            L005A: SetSkillLevel(player, 0x09, 0x02);
            L006B: ShowMessage(player, String0EF6); // You gain the skill of Stamina!
            L0078: goto L0118;
            L007B: RefreshCompareFlags(GetSkillLevel(player, 0x0A));
            L0089: if (JumpNotEqual) goto L00AB;
            L008B: SetSkillLevel(player, 0x0A, 0x02);
            L009C: ShowMessage(player, String0F15); // You gain the skill of Furtiveness!
            L00A9: goto L0118;
            L00AB: RefreshCompareFlags(GetSkillLevel(player, 0x0B));
            L00B9: if (JumpNotEqual) goto L00DB;
            L00BB: SetSkillLevel(player, 0x0B, 0x02);
            L00CC: ShowMessage(player, String0F38); // You gain the skill of Reading Tracks!
            L00D9: goto L0118;
            L00DB: RefreshCompareFlags(GetSkillLevel(player, 0x08));
            L00E9: if (JumpNotEqual) goto L010B;
            L00EB: SetSkillLevel(player, 0x08, 0x02);
            L00FC: ShowMessage(player, String0F5E); // You gain the skill of Archery!
            L0109: goto L0118;
            L010B: ShowMessage(player, String0F7D); // The waters are refreshing, but not enlightening!
            L0118: return; // RETURN;
        }

        private void FnCSTLENCA_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x17);
            L0015: AddEncounter(player, 0x02, 0x17);
            L0027: AddEncounter(player, 0x04, 0x20);
            L0039: AddEncounter(player, 0x05, 0x17);
            L004B: AddEncounter(player, 0x06, 0x17);
            L005D: return; // RETURN;
        }

        private void FnCSTLENCB_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x1D);
            L0015: AddEncounter(player, 0x02, 0x1D);
            L0027: AddEncounter(player, 0x04, 0x1D);
            L0039: AddEncounter(player, 0x06, 0x1D);
            L004B: return; // RETURN;
        }

        private void FnCSTLENCC_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x18);
            L0015: AddEncounter(player, 0x02, 0x18);
            L0027: AddEncounter(player, 0x03, 0x22);
            L0039: AddEncounter(player, 0x04, 0x22);
            L004B: return; // RETURN;
        }

        private void FnCSTLENCD_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x1D);
            L0015: AddEncounter(player, 0x02, 0x1D);
            L0027: AddEncounter(player, 0x04, 0x1D);
            L0039: AddEncounter(player, 0x05, 0x18);
            L004B: AddEncounter(player, 0x06, 0x18);
            L005D: return; // RETURN;
        }

        private void FnCSTLENCE_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x21);
            L0015: AddEncounter(player, 0x02, 0x21);
            L0027: AddEncounter(player, 0x04, 0x21);
            L0039: AddEncounter(player, 0x05, 0x0A);
            L004B: AddEncounter(player, 0x06, 0x21);
            L005D: return; // RETURN;
        }

        private void FnTXTCSTLA_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0FAE); // A message is etched on wall...
            L0010: ShowMessage(player, String0FCD); // 'The runes seem to spell names.  That is the way to Arnakkian.'
            L001D: return; // RETURN;
        }

        private void FnTXTCSTLB_36(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0016);
            L0010: ShowMessage(player, String100D); // A Human Barbarian belches, then looks up at you.
            L001D: ShowMessage(player, String103E); // 'Andreas built a great pit. Two.'
            L002A: ShowMessage(player, String1060); // Holding up three fingers, he repeats...
            L0037: ShowMessage(player, String1088); // 'Two.  Must need two to cross.'
            L0044: return; // RETURN;
        }

        private void FnFNTNHEAL_37(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: HealPlayer(player, (ushort)GetMaxHits(player));
            L0014: ShowPortrait(player, 0x0042);
            L0021: ShowMessage(player, String10A8); // DayFrost Fountain restores your Health.
            L002E: return; // RETURN;
        }

        private void FnFNTNMANA_38(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddMana(player, 0x2710);
            L0010: ShowPortrait(player, 0x0042);
            L001D: ShowMessage(player, String10D0); // NightFrost Fountain renews your Mana.
            L002A: return; // RETURN;
        }

        private void FnTXTCSTLC_3B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0011);
            L0010: ShowMessage(player, String10F6); // A Phantasm appears...
            L001D: ShowMessage(player, String110C); // 'Dare time?  Yes?  Ah, adventurers should not challenge En-Li-Kil!'
            L002A: ShowMessage(player, String1150); // The Phantasm drains your life energies.
            L0037: ax = GetCurrentHits(player);
            L003E: bx = 0x0002;
            L0041: dx = ax % bx; ax = ax / bx;
            L0044: DamagePlayer(player, ax);
            L0066: return; // RETURN;
        }

    }
}
