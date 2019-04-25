#pragma warning disable
using System.Collections.Generic;
using XPT.Legacy;
using XPT.Legacy.Entities;
using XPT.Legacy.Yserbius;

namespace XPT.Legacy.Maps {
    class YserMap30 : AMapScripted {
        protected override int MapIndex => 30;
        protected override int RandomEncounterChance => 27;
        protected override int RandomEncounterExtraCount => 2;

        public YserMap30() {
            MapEvent01 = FnRIVER_01;
            MapEvent02 = FnRIVRBANK_02;
            MapEvent03 = FnSTEPCYCL_03;
            MapEvent04 = FnSTEPMINE_04;
            MapEvent05 = FnSTEPHIDE_05;
            MapEvent06 = FnASENDB_06;
            MapEvent09 = FnDSENDC_09;
            MapEvent0A = FnESENDF_0A;
            MapEvent0C = FnSECDOORA_0C;
            MapEvent0D = FnSECDOORB_0D;
            MapEvent0E = FnSECDOORC_0E;
            MapEvent0F = FnGSENDH_0F;
            MapEvent11 = FnISENDJ_11;
            MapEvent14 = FnSUNBEAM_14;
            MapEvent15 = FnLAVA_15;
            MapEvent16 = FnGATEA_16;
            MapEvent17 = FnGATEB_17;
            MapEvent18 = Fn_18;
            MapEvent19 = FnENCB_19;
            MapEvent1A = FnENCC_1A;
            MapEvent1B = FnENCD_1B;
            MapEvent1C = FnENCE_1C;
            MapEvent1D = FnENCF_1D;
            MapEvent1E = FnENCG_1E;
            MapEvent1F = FnENCH_1F;
            MapEvent20 = FnENCI_20;
            MapEvent21 = FnENCJ_21;
            MapEvent22 = FnENCK_22;
            MapEvent23 = FnENCL_23;
            MapEvent24 = FnENCM_24;
            MapEvent25 = FnENCN_25;
            MapEvent26 = FnENCO_26;
            MapEvent27 = FnHEALFA_27;
            MapEvent28 = FnHEALFB_28;
            MapEvent29 = FnHEALFC_29;
            MapEvent2A = FnMANAFA_2A;
            MapEvent2B = FnMANAFB_2B;
            MapEvent2C = FnMANAFC_2C;
            MapEvent2D = FnCLUEA_2D;
            MapEvent2E = FnCLUEB_2E;
            MapEvent2F = FnCLUEC_2F;
            MapEvent30 = FnCLUED_30;
        }
        
        // === Strings ================================================
        private const string String03FC = "The River of Eternity taps your life energy.";
        private const string String0429 = "You have died.";
        private const string String0438 = "Only the bravest adventurers explore the River for hidden passages.";
        private const string String047C = "Your Cyclops' Mine Key makes the tapestry translucent, revealing new passages to the southwest.";
        private const string String04DC = "The tapestry glows with the image of a Cyclops.";
        private const string String050C = "Your Dwarf Mine Key activated this platform.";
        private const string String0539 = "Your Hidden Mine Key makes the wall become transparent.";
        private const string String0571 = "There is something strange about this wall.";
        private const string String059D = "You locate a hidden door in the wall.";
        private const string String05C3 = "You locate a hidden door in the wall.";
        private const string String05E9 = "You locate a hidden door in the wall.";
        private const string String060F = "A band of dwarves moves out of the shadows.";
        private const string String063B = "The leader steps forward, his eyes fixed on the blue metal.";
        private const string String0677 = "'This magnificent blue treasure you hold can certainly do YOU no good.  Perhaps we may offer you a TRADE to remove this rock from your hands.'";
        private const string String0706 = "A key appears from beneath his pack.";
        private const string String072B = "'We offer you this key to our kingdom in return.'";
        private const string String075D = "A beam of bluish sunshine filters down from the surface above and reflects on a ceremonial dwarven rock.";
        private const string String07C6 = "You fall into a lava pit and die.";
        private const string String07E8 = "This gate leads to DWARF KINGDOM.";
        private const string String080A = "This gate leads to RIVERS END.";
        private const string String0829 = "Hobgoblins appear from the surrounding walls.";
        private const string String0857 = "The air is heavy with the scent of burnt flesh.";
        private const string String0887 = "You wander into a renegade adventurer camp.";
        private const string String08B3 = "A den of manticores is disturbed.";
        private const string String08D5 = "Stone fragments litter the floor.";
        private const string String08F7 = "A huge Cyclops appears from behind large boulders.";
        private const string String092A = "You encounter adventurers slaying a dragon.  They do not welcome your intrusion.";
        private const string String097B = "Creatures fight over a stone key.";
        private const string String099D = "Creatures fight over a green tree-shaped key";
        private const string String09CA = "Your full health is restored by the ancient waters of RoundBrook Fountain.";
        private const string String0A15 = "You feel all your health restored after sipping from JasperStone Fountain.";
        private const string String0A60 = "The waters of RockyFlat Fountain restores your health.";
        private const string String0A97 = "Your mana is recharged by drinking the magical waters of Omar Fountain.";
        private const string String0ADF = "Your magical powers are recharged by the heated steams of Venivor Geyser.";
        private const string String0B29 = "Your mana is increased in a whirlpool at the edge of the river.";
        private const string String0B69 = "A message is inscribed on the wall -- ";
        private const string String0B90 = "The Tapestry of the Moons requires a spectrum of color to open.";
        private const string String0BD0 = "A gust of wind from caverns above catches your attention.";
        private const string String0C0A = "'I am Zephyr.  ";
        private const string String0C1A = "'Only the FlexSword can bend against the Wind Elemental's gail.'";
        private const string String0C5B = "A collection of runes reveals a message -- ";
        private const string String0C87 = "It is said that the Dwarves can build magnificent creations and vessels out of golden threads.";
        private const string String0CE6 = "Written in blood on the wall is the message -- ";
        private const string String0D16 = "Acquire the Sunbeam Key at the Dwarf Ceremonial Rock to access the Dwarf Kingdom.";
        
        // === Functions ================================================
        private void FnRIVER_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String03FC); // The River of Eternity taps your life energy.
            L0010: SetNoHealZone(player);
            L0018: ax = GetMaxHits(player);
            L001F: bx = 0x0004;
            L0022: dx = ax % bx; ax = ax / bx;
            L0025: DamagePlayer(player, ax);
            L002F: RefreshCompareFlags(GetCurrentHits(player));
            L0038: if (JumpAbove) goto L0047;
            L003A: ShowMessage(player, String0429); // You have died.
            L0047: ax = HasItem(player, 0xD5);
            L0055: if (JumpNotEqual) goto L006C;
            L0057: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagUsedDwarfMineKey));
            L006A: if (JumpEqual) goto L007E;
            L006C: SetFloorItem(player, 0x9C, 0x00);
            L007C: goto L008F;
            L007E: SetFloorItem(player, 0x9C, 0x03);
            L008F: return; // RETURN;
        }

        private void FnRIVRBANK_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0438); // Only the bravest adventurers explore the River for hidden passages.
            L0010: return; // RETURN;
        }

        private void FnSTEPCYCL_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xD6);
            L0011: if (JumpNotEqual) goto L0028;
            L0013: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagUsedCyclopsMineKey));
            L0026: if (JumpEqual) goto L0071;
            L0028: SetWallPassable(player, GetCurrentTile(player), 0x00, 0x01);
            L0041: RemoveItem(player, 0xD6);
            L004D: SetFlag(player, FlagTypeDungeon, FlagUsedCyclopsMineKey, 0x01);
            L0062: ShowMessage(player, String047C); // Your Cyclops' Mine Key makes the tapestry translucent, revealing new passages to the southwest.
            L006F: goto L007E;
            L0071: ShowMessage(player, String04DC); // The tapestry glows with the image of a Cyclops.
            L007E: return; // RETURN;
        }

        private void FnSTEPMINE_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xD5);
            L0011: if (JumpNotEqual) goto L0028;
            L0013: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagUsedDwarfMineKey));
            L0026: if (JumpEqual) goto L0068;
            L0028: RemoveItem(player, 0xD5);
            L0034: SetFlag(player, FlagTypeDungeon, FlagUsedDwarfMineKey, 0x01);
            L0049: SetFloorItem(player, 0x9C, 0x00);
            L0059: ShowMessage(player, String050C); // Your Dwarf Mine Key activated this platform.
            L0066: goto L0079;
            L0068: SetFloorItem(player, 0x9C, 0x03);
            L0079: return; // RETURN;
        }

        private void FnSTEPHIDE_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xD7);
            L0011: if (JumpNotEqual) goto L0028;
            L0013: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagUsedHiddenMineKey));
            L0026: if (JumpEqual) goto L0076;
            L0028: RemoveItem(player, 0xD7);
            L0034: SetFlag(player, FlagTypeDungeon, FlagUsedHiddenMineKey, 0x01);
            L0049: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0067: ShowMessage(player, String0539); // Your Hidden Mine Key makes the wall become transparent.
            L0074: goto L0083;
            L0076: ShowMessage(player, String0571); // There is something strange about this wall.
            L0083: return; // RETURN;
        }

        private void FnASENDB_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x38, 0x02, 0xCC, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnDSENDC_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x38, 0x02, 0xE1, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnESENDF_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x38, 0x02, 0xFD, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnSECDOORA_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000B);
            L0012: if (JumpNotBelow) goto L0029;
            L0014: ax = HasUsedItem(player, 0xBE, 0xBE);
            L0027: if (JumpEqual) goto L0072;
            L0029: ShowMessage(player, String059D); // You locate a hidden door in the wall.
            L0036: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0054: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0072: return; // RETURN;
        }

        private void FnSECDOORB_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000B);
            L0012: if (JumpNotBelow) goto L0029;
            L0014: ax = HasUsedItem(player, 0xBE, 0xBE);
            L0027: if (JumpEqual) goto L0072;
            L0029: ShowMessage(player, String05C3); // You locate a hidden door in the wall.
            L0036: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0054: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0072: return; // RETURN;
        }

        private void FnSECDOORC_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000B);
            L0012: if (JumpNotBelow) goto L0029;
            L0014: ax = HasUsedItem(player, 0xBE, 0xBE);
            L0027: if (JumpEqual) goto L0074;
            L0029: ShowMessage(player, String05E9); // You locate a hidden door in the wall.
            L0036: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0054: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0072: goto L0091;
            L0074: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0091: return; // RETURN;
        }

        private void FnGSENDH_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x38, 0x02, 0x02, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnISENDJ_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x38, 0x02, 0x60, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnSUNBEAM_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xEF);
            L0011: if (JumpEqual) goto L007B;
            L0013: ShowPortrait(player, 0x001C);
            L0020: ShowMessage(player, String060F); // A band of dwarves moves out of the shadows.
            L002D: ShowMessage(player, String063B); // The leader steps forward, his eyes fixed on the blue metal.
            L003A: ShowMessage(player, String0677); // 'This magnificent blue treasure you hold can certainly do YOU no good.  Perhaps we may offer you a TRADE to remove this rock from your hands.'
            L0047: ShowMessage(player, String0706); // A key appears from beneath his pack.
            L0054: ShowMessage(player, String072B); // 'We offer you this key to our kingdom in return.'
            L0061: RemoveItem(player, 0xEF);
            L006D: GiveItem(player, 0xD4);
            L0079: goto L0088;
            L007B: ShowMessage(player, String075D); // A beam of bluish sunshine filters down from the surface above and reflects on a ceremonial dwarven rock.
            L0088: return; // RETURN;
        }

        private void FnLAVA_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String07C6); // You fall into a lava pit and die.
            L0010: DamagePlayer(player, GetMaxHits(player));
            L0021: return; // RETURN;
        }

        private void FnGATEA_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String07E8); // This gate leads to DWARF KINGDOM.
            L0010: TeleportParty(player, 0x38, 0x01, 0x3F, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void FnGATEB_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String080A); // This gate leads to RIVERS END.
            L0010: TeleportParty(player, 0x38, 0x03, 0x0B, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void Fn_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0829); // Hobgoblins appear from the surrounding walls.
            L0010: AddEncounter(player, 0x01, 0x24);
            L0022: AddEncounter(player, 0x02, 0x24);
            L0034: AddEncounter(player, 0x03, 0x0E);
            L0046: AddEncounter(player, 0x04, 0x0E);
            L0058: AddEncounter(player, 0x05, 0x25);
            L006A: AddEncounter(player, 0x06, 0x25);
            L007C: return; // RETURN;
        }

        private void FnENCB_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0857); // The air is heavy with the scent of burnt flesh.
            L0010: AddEncounter(player, 0x01, 0x12);
            L0022: AddEncounter(player, 0x02, 0x12);
            L0034: AddEncounter(player, 0x03, 0x28);
            L0046: AddEncounter(player, 0x04, 0x28);
            L0058: AddEncounter(player, 0x05, 0x15);
            L006A: AddEncounter(player, 0x06, 0x15);
            L007C: return; // RETURN;
        }

        private void FnENCC_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0887); // You wander into a renegade adventurer camp.
            L0010: AddEncounter(player, 0x01, 0x1E);
            L0022: AddEncounter(player, 0x02, 0x19);
            L0034: AddEncounter(player, 0x03, 0x1C);
            L0046: AddEncounter(player, 0x04, 0x05);
            L0058: AddEncounter(player, 0x05, 0x03);
            L006A: AddEncounter(player, 0x06, 0x03);
            L007C: return; // RETURN;
        }

        private void FnENCD_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String08B3); // A den of manticores is disturbed.
            L0010: AddEncounter(player, 0x01, 0x18);
            L0022: AddEncounter(player, 0x02, 0x18);
            L0034: AddEncounter(player, 0x03, 0x19);
            L0046: AddEncounter(player, 0x04, 0x19);
            L0058: AddEncounter(player, 0x05, 0x1A);
            L006A: AddEncounter(player, 0x06, 0x04);
            L007C: return; // RETURN;
        }

        private void FnENCE_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String08D5); // Stone fragments litter the floor.
            L0010: AddEncounter(player, 0x01, 0x11);
            L0022: AddEncounter(player, 0x02, 0x11);
            L0034: AddEncounter(player, 0x03, 0x10);
            L0046: AddEncounter(player, 0x04, 0x10);
            L0058: AddEncounter(player, 0x05, 0x16);
            L006A: AddEncounter(player, 0x06, 0x22);
            L007C: return; // RETURN;
        }

        private void FnENCF_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x0B);
            L0015: AddEncounter(player, 0x02, 0x0B);
            L0027: AddEncounter(player, 0x03, 0x0C);
            L0039: AddEncounter(player, 0x04, 0x0C);
            L004B: AddEncounter(player, 0x05, 0x1F);
            L005D: AddEncounter(player, 0x05, 0x1F);
            L006F: return; // RETURN;
        }

        private void FnENCG_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x0F);
            L0015: AddEncounter(player, 0x02, 0x10);
            L0027: AddEncounter(player, 0x03, 0x26);
            L0039: AddEncounter(player, 0x04, 0x18);
            L004B: AddEncounter(player, 0x05, 0x27);
            L005D: AddEncounter(player, 0x06, 0x28);
            L006F: return; // RETURN;
        }

        private void FnENCH_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String08F7); // A huge Cyclops appears from behind large boulders.
            L0010: AddEncounter(player, 0x01, 0x0E);
            L0022: AddEncounter(player, 0x02, 0x0E);
            L0034: AddEncounter(player, 0x03, 0x21);
            L0046: ax = HasItem(player, 0xF1);
            L0054: if (JumpEqual) goto L0078;
            L0056: AddTreasure(player, 0x09C4, 0x00, 0x00, 0x00, 0xD0, 0xC6);
            L0076: goto L0097;
            L0078: AddTreasure(player, 0x2710, 0x00, 0x00, 0x00, 0x00, 0xF1);
            L0097: return; // RETURN;
        }

        private void FnENCI_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x17);
            L0015: AddEncounter(player, 0x02, 0x17);
            L0027: AddEncounter(player, 0x05, 0x14);
            L0039: AddEncounter(player, 0x06, 0x14);
            L004B: return; // RETURN;
        }

        private void FnENCJ_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x23);
            L0015: AddEncounter(player, 0x02, 0x23);
            L0027: AddEncounter(player, 0x03, 0x1F);
            L0039: AddEncounter(player, 0x04, 0x1F);
            L004B: AddEncounter(player, 0x05, 0x14);
            L005D: AddEncounter(player, 0x06, 0x14);
            L006F: return; // RETURN;
        }

        private void FnENCK_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x18);
            L0015: AddEncounter(player, 0x02, 0x18);
            L0027: AddEncounter(player, 0x03, 0x22);
            L0039: AddEncounter(player, 0x04, 0x26);
            L004B: return; // RETURN;
        }

        private void FnENCL_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x1F);
            L0015: AddEncounter(player, 0x02, 0x1F);
            L0027: AddEncounter(player, 0x03, 0x0A);
            L0039: AddEncounter(player, 0x04, 0x0A);
            L004B: AddEncounter(player, 0x05, 0x16);
            L005D: AddEncounter(player, 0x05, 0x16);
            L006F: return; // RETURN;
        }

        private void FnENCM_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String092A); // You encounter adventurers slaying a dragon.  They do not welcome your intrusion.
            L0010: AddEncounter(player, 0x01, 0x19);
            L0022: AddEncounter(player, 0x02, 0x1B);
            L0034: AddEncounter(player, 0x03, 0x1D);
            L0046: AddEncounter(player, 0x04, 0x03);
            L0058: AddEncounter(player, 0x05, 0x05);
            L006A: AddEncounter(player, 0x05, 0x16);
            L007C: return; // RETURN;
        }

        private void FnENCN_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x23);
            L0015: AddEncounter(player, 0x02, 0x23);
            L0027: AddEncounter(player, 0x03, 0x12);
            L0039: AddEncounter(player, 0x04, 0x12);
            L004B: AddEncounter(player, 0x05, 0x22);
            L005D: ax = HasItem(player, 0xD5);
            L006B: if (JumpEqual) goto L008F;
            L006D: AddTreasure(player, 0x07D0, 0x00, 0x00, 0x00, 0xB7, 0x98);
            L008D: goto L00BB;
            L008F: ShowMessage(player, String097B); // Creatures fight over a stone key.
            L009C: AddTreasure(player, 0x2710, 0x00, 0x00, 0x00, 0x00, 0xD5);
            L00BB: return; // RETURN;
        }

        private void FnENCO_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x23);
            L0015: AddEncounter(player, 0x02, 0x23);
            L0027: AddEncounter(player, 0x03, 0x12);
            L0039: AddEncounter(player, 0x04, 0x12);
            L004B: AddEncounter(player, 0x05, 0x22);
            L005D: ax = HasItem(player, 0xD8);
            L006B: if (JumpEqual) goto L008E;
            L006D: AddTreasure(player, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0xD0);
            L008C: goto L00BA;
            L008E: ShowMessage(player, String099D); // Creatures fight over a green tree-shaped key
            L009B: AddTreasure(player, 0x2328, 0x00, 0x00, 0x00, 0x00, 0xD8);
            L00BA: return; // RETURN;
        }

        private void FnHEALFA_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: HealPlayer(player, (ushort)GetMaxHits(player));
            L0021: ShowMessage(player, String09CA); // Your full health is restored by the ancient waters of RoundBrook Fountain.
            L002E: return; // RETURN;
        }

        private void FnHEALFB_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: HealPlayer(player, (ushort)GetMaxHits(player));
            L0021: ShowMessage(player, String0A15); // You feel all your health restored after sipping from JasperStone Fountain.
            L002E: return; // RETURN;
        }

        private void FnHEALFC_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: HealPlayer(player, (ushort)GetMaxHits(player));
            L0021: ShowMessage(player, String0A60); // The waters of RockyFlat Fountain restores your health.
            L002E: return; // RETURN;
        }

        private void FnMANAFA_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: AddMana(player, 0x07D0);
            L001D: ShowMessage(player, String0A97); // Your mana is recharged by drinking the magical waters of Omar Fountain.
            L002A: return; // RETURN;
        }

        private void FnMANAFB_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddMana(player, 0x07D0);
            L0010: ShowMessage(player, String0ADF); // Your magical powers are recharged by the heated steams of Venivor Geyser.
            L001D: return; // RETURN;
        }

        private void FnMANAFC_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddMana(player, 0x07D0);
            L0010: ShowMessage(player, String0B29); // Your mana is increased in a whirlpool at the edge of the river.
            L001D: return; // RETURN;
        }

        private void FnCLUEA_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0B69); // A message is inscribed on the wall -- 
            L0010: ShowRunes(player, String0B90); // The Tapestry of the Moons requires a spectrum of color to open.
            L001D: return; // RETURN;
        }

        private void FnCLUEB_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0BD0); // A gust of wind from caverns above catches your attention.
            L0010: ShowMessage(player, String0C0A); // 'I am Zephyr.  
            L001D: ShowMessage(player, String0C1A); // 'Only the FlexSword can bend against the Wind Elemental's gail.'
            L002A: return; // RETURN;
        }

        private void FnCLUEC_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0C5B); // A collection of runes reveals a message -- 
            L0010: ShowRunes(player, String0C87); // It is said that the Dwarves can build magnificent creations and vessels out of golden threads.
            L001D: return; // RETURN;
        }

        private void FnCLUED_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0CE6); // Written in blood on the wall is the message -- 
            L0010: ShowRunes(player, String0D16); // Acquire the Sunbeam Key at the Dwarf Ceremonial Rock to access the Dwarf Kingdom.
            L001D: return; // RETURN;
        }

    }
}
