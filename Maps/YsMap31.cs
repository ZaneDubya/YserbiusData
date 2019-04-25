#pragma warning disable
using System.Collections.Generic;
using XPT.Legacy;
using XPT.Legacy.Entities;
using XPT.Legacy.Yserbius;

namespace XPT.Legacy.Maps {
    class YserMap31 : AMapScripted {
        protected override int MapIndex => 31;
        protected override int RandomEncounterChance => 30;
        protected override int RandomEncounterExtraCount => 2;

        public YserMap31() {
            MapEvent01 = FnRIVER_01;
            MapEvent02 = FnRIVRBANK_02;
            MapEvent03 = FnVOID_03;
            MapEvent04 = FnPLATA_04;
            MapEvent05 = FnPLATB_05;
            MapEvent06 = FnPLATCTOA_06;
            MapEvent07 = FnPLATDTOB_07;
            MapEvent0C = FnTAPMOONS_0C;
            MapEvent12 = FnTHEFCLUE_12;
            MapEvent13 = FnTHIEVES_13;
            MapEvent14 = FnRAINBOW_14;
            MapEvent15 = FnRAINRED_15;
            MapEvent16 = FnRAINYEL_16;
            MapEvent17 = FnRAINGRN_17;
            MapEvent18 = FnRAINBLU_18;
            MapEvent19 = FnGATEA_19;
            MapEvent1A = FnENCA_1A;
            MapEvent1B = FnENCB_1B;
            MapEvent1C = FnENCC_1C;
            MapEvent1D = FnENCD_1D;
            MapEvent1E = FnTAPECLUE_1E;
            MapEvent1F = FnBOAT_1F;
            MapEvent20 = FnDOORWARN_20;
            MapEvent24 = FnNOLIGHT_24;
            MapEvent25 = FnPLATFORM_25;
        }
        
        // === Strings ================================================
        private const string String03FC = "The River of Eternity taps your life energy.";
        private const string String0429 = "You have died.";
        private const string String0438 = "Only the bravest adventurers explore the River for hidden passages.";
        private const string String047C = "The Ageless Void swallows you whole.";
        private const string String04A1 = "SageCross Fountain revives your Health and Mana";
        private const string String04D1 = "DragonBreath Fountain empowers you with improved attributes.";
        private const string String050E = "Minotaur Fountain revives your Health and Mana";
        private const string String053D = "As you reach the platform, a magical field envelops you and teleports you to a moon tapestry.";
        private const string String059B = "A magical door appears where the tapestry used to be.";
        private const string String05D1 = "A brilliant tapestry depicting moons decorates this room.";
        private const string String060B = "A Gnome Thief steps out of the shadows -";
        private const string String0634 = "'You are very near the final battle with the Elemental En-Li-Kil.";
        private const string String0676 = "The four Rainbow Gems will light your way to the infinite beyond when they are all placed.";
        private const string String06D1 = "Red, yellow, green and blue are the rainbow colors.";
        private const string String0705 = "Have your boat when the gems are set and sail the rainbow to your destiny.'";
        private const string String0751 = "A doorway is marked -- 'Voranti's Treasure'";
        private const string String077D = "Various golden objects appear to be standing to the west, just at the edge of the Ageless Void.";
        private const string String07DD = "A beam of red arcs over the Ageless Void.";
        private const string String0807 = "A vibrant rainbow of color forms.";
        private const string String0829 = "A golden statue appears to be capable of holding a gem.";
        private const string String0861 = "Your miniature Golden Boat floats out of your pack on a swirl of magic dust.";
        private const string String08AE = "It intersects the Rainbow and bursts into blinding light.";
        private const string String08E8 = "Once your eyes adjust, you see an enormous Golden Boat bedecked with the rarest jewels and finest carvings.";
        private const string String0954 = "A rainbow voyage across the Ageless Void awaits you to the West.";
        private const string String0995 = "A beam of yellow arcs over the Ageless Void.";
        private const string String09C2 = "A vibrant rainbow of color forms.";
        private const string String09E4 = "Your miniature Golden Boat floats out of your pack on a swirl of magic dust.";
        private const string String0A31 = "It intersects the Rainbow and bursts into blinding light.";
        private const string String0A6B = "Once your eyes adjust, you see an enormous Golden Boat bedecked with the rarest jewels and finest carvings.";
        private const string String0AD7 = "A rainbow voyage across the Ageless Void awaits you to the West.";
        private const string String0B18 = "A beam of green arcs over the Ageless Void.";
        private const string String0B44 = "A vibrant rainbow of color forms.";
        private const string String0B66 = "Your miniature Golden Boat floats out of your pack on a swirl of magic dust.";
        private const string String0BB3 = "It intersects the Rainbow and bursts into blinding light.";
        private const string String0BED = "Once your eyes adjust, you see an enormous Golden Boat bedecked with the rarest jewels and finest carvings.";
        private const string String0C59 = "A rainbow voyage across the Ageless Void awaits you to the West.";
        private const string String0C9A = "A beam of blue arcs over the Ageless Void.";
        private const string String0CC5 = "A vibrant rainbow of color forms.";
        private const string String0CE7 = "Your miniature Golden Boat floats out of your pack on a swirl of magic dust.";
        private const string String0D34 = "It intersects the Rainbow and bursts into blinding light.";
        private const string String0D6E = "Once your eyes adjust, you see an enormous Golden Boat bedecked with the rarest jewels and finest carvings.";
        private const string String0DDA = "A rainbow voyage across the Ageless Void awaits you to the West.";
        private const string String0E1B = "This gate leads to the GIANTS' LAND";
        private const string String0E3F = "A burst of moon light floods the room.";
        private const string String0E66 = "Dragons defend their lair.";
        private const string String0E81 = "Rune symbols decorate the tapestry -- ";
        private const string String0EA8 = "Past the Platforms a Tapestry you will find.";
        private const string String0ED5 = "Illuminate the Moons with the Spectrum of the Moon Prism.";
        private const string String0F0F = "Then... ACK, UGH, THUMP  (the rest of the tapestry is smeared with blood)";
        private const string String0F59 = "You step across the platform and into the Golden Boat.";
        private const string String0F90 = "The Zephyr Wind blows the lightest of breezes from the east and the Golden Boat sets sail west across the Rainbow.";
        private const string String1003 = "In the moments that follow the Zephyr tells you only the FlexSword can remain in your hands when you encounter the Wind Elemental.";
        private const string String1086 = "Destroy him and the way to En-li-kil's Domain will be clear.";
        private const string String10C3 = "You arrive at an island in the center of the Ageless Void.";
        private const string String10FE = "The Ageless Void swallows you whole.";
        private const string String1123 = "This door leads the way back to the Land of Giants.";
        private const string String1157 = "This side of the tapestry appears dark.";
        private const string String117F = "You stand upon a platform in the center of the River of Eternity.";
        
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
            L0047: return; // RETURN;
        }

        private void FnRIVRBANK_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0438); // Only the bravest adventurers explore the River for hidden passages.
            L0010: return; // RETURN;
        }

        private void FnVOID_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String047C); // The Ageless Void swallows you whole.
            L0010: DamagePlayer(player, GetMaxHits(player));
            L0021: return; // RETURN;
        }

        private void FnPLATA_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: ShowMessage(player, String04A1); // SageCross Fountain revives your Health and Mana
            L001D: HealPlayer(player, (ushort)GetMaxHits(player));
            L002E: AddMana(player, 0x2EE0);
            L003B: return; // RETURN;
        }

        private void FnPLATB_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagModAttr_DragonBreathFountain));
            L0016: if (JumpNotEqual) goto L008E;
            L0018: SetFlag(player, FlagTypeDungeon, FlagModAttr_DragonBreathFountain, 0x01);
            L002D: ShowPortrait(player, 0x0042);
            L003A: ShowMessage(player, String04D1); // DragonBreath Fountain empowers you with improved attributes.
            L0047: ModifyAttribute(player, 0x00, 0x0001);
            L0058: ModifyAttribute(player, 0x01, 0x0001);
            L006A: ModifyAttribute(player, 0x02, 0x0001);
            L007C: ModifyAttribute(player, 0x03, 0x0001);
            L008E: return; // RETURN;
        }

        private void FnPLATCTOA_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: ShowMessage(player, String050E); // Minotaur Fountain revives your Health and Mana
            L001D: HealPlayer(player, (ushort)GetMaxHits(player));
            L002E: AddMana(player, 0x2EE0);
            L003B: return; // RETURN;
        }

        private void FnPLATDTOB_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String053D); // As you reach the platform, a magical field envelops you and teleports you to a moon tapestry.
            L0010: TeleportParty(player, 0x38, 0x03, 0xEE, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnTAPMOONS_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, 0xF2, 0xF2);
            L0016: if (JumpEqual) goto L005F;
            L0018: SetWallItem(player, 0x01, GetCurrentTile(player), 0x02);
            L0032: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0050: ShowMessage(player, String059B); // A magical door appears where the tapestry used to be.
            L005D: goto L006C;
            L005F: ShowMessage(player, String05D1); // A brilliant tapestry depicting moons decorates this room.
            L006C: return; // RETURN;
        }

        private void FnTHEFCLUE_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0024);
            L0010: ShowMessage(player, String060B); // A Gnome Thief steps out of the shadows -
            L001D: ShowMessage(player, String0634); // 'You are very near the final battle with the Elemental En-Li-Kil.
            L002A: ShowMessage(player, String0676); // The four Rainbow Gems will light your way to the infinite beyond when they are all placed.
            L0037: ShowMessage(player, String06D1); // Red, yellow, green and blue are the rainbow colors.
            L0044: ShowMessage(player, String0705); // Have your boat when the gems are set and sail the rainbow to your destiny.'
            L0051: return; // RETURN;
        }

        private void FnTHIEVES_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0751); // A doorway is marked -- 'Voranti's Treasure'
            L0010: return; // RETURN;
        }

        private void FnRAINBOW_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String077D); // Various golden objects appear to be standing to the west, just at the edge of the Ageless Void.
            L0010: return; // RETURN;
        }

        private void FnRAINRED_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, 0xF4, 0xF4);
            L0016: if (JumpNotEqual) goto L001B;
            L0018: goto L00B5;
            L001B: ShowMessage(player, String07DD); // A beam of red arcs over the Ageless Void.
            L0028: SetFlag(player, FlagTypeDungeon, FlagRiversEndRainbowRed, 0x01);
            L003D: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagRiversEndRainbowRed));
            L0050: if (JumpEqual) goto L00B3;
            L0052: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagRiversEndRainbowYellow));
            L0065: if (JumpEqual) goto L00B3;
            L0067: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagRiversEndRainbowGreen));
            L007A: if (JumpEqual) goto L00B3;
            L007C: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagRiversEndRainbowBlue));
            L008F: if (JumpEqual) goto L00B3;
            L0091: SetFlag(player, FlagTypeMap, 0x01, 0x01);
            L00A6: ShowMessage(player, String0807); // A vibrant rainbow of color forms.
            L00B3: goto L00C2;
            L00B5: ShowMessage(player, String0829); // A golden statue appears to be capable of holding a gem.
            L00C2: ax = HasUsedItem(player, 0xF3, 0xF3);
            L00D5: if (JumpNotEqual) goto L00DA;
            L00D7: goto L015A;
            L00DA: RefreshCompareFlags(GetFlag(player, FlagTypeMap, 0x01));
            L00ED: if (JumpEqual) goto L015A;
            L00EF: SetFlag(player, FlagTypeMap, 0x01, 0x01);
            L0104: SetFloorItem(player, 0x42, 0x75);
            L0115: SetFloorItem(player, 0x42, 0x85);
            L0126: ShowMessage(player, String0861); // Your miniature Golden Boat floats out of your pack on a swirl of magic dust.
            L0133: ShowMessage(player, String08AE); // It intersects the Rainbow and bursts into blinding light.
            L0140: ShowMessage(player, String08E8); // Once your eyes adjust, you see an enormous Golden Boat bedecked with the rarest jewels and finest carvings.
            L014D: ShowMessage(player, String0954); // A rainbow voyage across the Ageless Void awaits you to the West.
            L015A: return; // RETURN;
        }

        private void FnRAINYEL_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, 0xF5, 0xF5);
            L0016: if (JumpNotEqual) goto L001B;
            L0018: goto L00B3;
            L001B: ShowMessage(player, String0995); // A beam of yellow arcs over the Ageless Void.
            L0028: SetFlag(player, FlagTypeDungeon, FlagRiversEndRainbowYellow, 0x01);
            L003D: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagRiversEndRainbowRed));
            L0050: if (JumpEqual) goto L00B3;
            L0052: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagRiversEndRainbowYellow));
            L0065: if (JumpEqual) goto L00B3;
            L0067: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagRiversEndRainbowGreen));
            L007A: if (JumpEqual) goto L00B3;
            L007C: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagRiversEndRainbowBlue));
            L008F: if (JumpEqual) goto L00B3;
            L0091: SetFlag(player, FlagTypeMap, 0x01, 0x01);
            L00A6: ShowMessage(player, String09C2); // A vibrant rainbow of color forms.
            L00B3: ax = HasUsedItem(player, 0xF3, 0xF3);
            L00C6: if (JumpNotEqual) goto L00CB;
            L00C8: goto L014B;
            L00CB: RefreshCompareFlags(GetFlag(player, FlagTypeMap, 0x01));
            L00DE: if (JumpEqual) goto L014B;
            L00E0: SetFlag(player, FlagTypeMap, 0x01, 0x01);
            L00F5: SetFloorItem(player, 0x42, 0x75);
            L0106: SetFloorItem(player, 0x42, 0x85);
            L0117: ShowMessage(player, String09E4); // Your miniature Golden Boat floats out of your pack on a swirl of magic dust.
            L0124: ShowMessage(player, String0A31); // It intersects the Rainbow and bursts into blinding light.
            L0131: ShowMessage(player, String0A6B); // Once your eyes adjust, you see an enormous Golden Boat bedecked with the rarest jewels and finest carvings.
            L013E: ShowMessage(player, String0AD7); // A rainbow voyage across the Ageless Void awaits you to the West.
            L014B: return; // RETURN;
        }

        private void FnRAINGRN_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, 0xF6, 0xF6);
            L0016: if (JumpNotEqual) goto L001B;
            L0018: goto L00B3;
            L001B: ShowMessage(player, String0B18); // A beam of green arcs over the Ageless Void.
            L0028: SetFlag(player, FlagTypeDungeon, FlagRiversEndRainbowGreen, 0x01);
            L003D: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagRiversEndRainbowRed));
            L0050: if (JumpEqual) goto L00B3;
            L0052: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagRiversEndRainbowYellow));
            L0065: if (JumpEqual) goto L00B3;
            L0067: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagRiversEndRainbowGreen));
            L007A: if (JumpEqual) goto L00B3;
            L007C: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagRiversEndRainbowBlue));
            L008F: if (JumpEqual) goto L00B3;
            L0091: SetFlag(player, FlagTypeMap, 0x01, 0x01);
            L00A6: ShowMessage(player, String0B44); // A vibrant rainbow of color forms.
            L00B3: ax = HasUsedItem(player, 0xF3, 0xF3);
            L00C6: if (JumpNotEqual) goto L00CB;
            L00C8: goto L014B;
            L00CB: RefreshCompareFlags(GetFlag(player, FlagTypeMap, 0x01));
            L00DE: if (JumpEqual) goto L014B;
            L00E0: SetFlag(player, FlagTypeMap, 0x01, 0x01);
            L00F5: SetFloorItem(player, 0x42, 0x75);
            L0106: SetFloorItem(player, 0x42, 0x85);
            L0117: ShowMessage(player, String0B66); // Your miniature Golden Boat floats out of your pack on a swirl of magic dust.
            L0124: ShowMessage(player, String0BB3); // It intersects the Rainbow and bursts into blinding light.
            L0131: ShowMessage(player, String0BED); // Once your eyes adjust, you see an enormous Golden Boat bedecked with the rarest jewels and finest carvings.
            L013E: ShowMessage(player, String0C59); // A rainbow voyage across the Ageless Void awaits you to the West.
            L014B: return; // RETURN;
        }

        private void FnRAINBLU_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, 0xF7, 0xF7);
            L0016: if (JumpNotEqual) goto L001B;
            L0018: goto L00B3;
            L001B: ShowMessage(player, String0C9A); // A beam of blue arcs over the Ageless Void.
            L0028: SetFlag(player, FlagTypeDungeon, FlagRiversEndRainbowBlue, 0x01);
            L003D: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagRiversEndRainbowRed));
            L0050: if (JumpEqual) goto L00B3;
            L0052: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagRiversEndRainbowYellow));
            L0065: if (JumpEqual) goto L00B3;
            L0067: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagRiversEndRainbowGreen));
            L007A: if (JumpEqual) goto L00B3;
            L007C: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagRiversEndRainbowBlue));
            L008F: if (JumpEqual) goto L00B3;
            L0091: SetFlag(player, FlagTypeMap, 0x01, 0x01);
            L00A6: ShowMessage(player, String0CC5); // A vibrant rainbow of color forms.
            L00B3: ax = HasUsedItem(player, 0xF3, 0xF3);
            L00C6: if (JumpNotEqual) goto L00CB;
            L00C8: goto L014B;
            L00CB: RefreshCompareFlags(GetFlag(player, FlagTypeMap, 0x01));
            L00DE: if (JumpEqual) goto L014B;
            L00E0: SetFlag(player, FlagTypeMap, 0x01, 0x01);
            L00F5: SetFloorItem(player, 0x42, 0x75);
            L0106: SetFloorItem(player, 0x42, 0x85);
            L0117: ShowMessage(player, String0CE7); // Your miniature Golden Boat floats out of your pack on a swirl of magic dust.
            L0124: ShowMessage(player, String0D34); // It intersects the Rainbow and bursts into blinding light.
            L0131: ShowMessage(player, String0D6E); // Once your eyes adjust, you see an enormous Golden Boat bedecked with the rarest jewels and finest carvings.
            L013E: ShowMessage(player, String0DDA); // A rainbow voyage across the Ageless Void awaits you to the West.
            L014B: return; // RETURN;
        }

        private void FnGATEA_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0E1B); // This gate leads to the GIANTS' LAND
            L0010: TeleportParty(player, 0x38, 0x02, 0xFB, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnENCA_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0E3F); // A burst of moon light floods the room.
            L0010: AddEncounter(player, 0x01, 0x24);
            L0022: AddEncounter(player, 0x02, 0x24);
            L0034: AddEncounter(player, 0x03, 0x25);
            L0046: AddEncounter(player, 0x04, 0x25);
            L0058: AddEncounter(player, 0x05, 0x22);
            L006A: AddEncounter(player, 0x06, 0x22);
            L007C: return; // RETURN;
        }

        private void FnENCB_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x26);
            L0015: AddEncounter(player, 0x02, 0x27);
            L0027: AddEncounter(player, 0x03, 0x1A);
            L0039: AddEncounter(player, 0x04, 0x1C);
            L004B: AddEncounter(player, 0x05, 0x1E);
            L005D: return; // RETURN;
        }

        private void FnENCC_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0E66); // Dragons defend their lair.
            L0010: AddEncounter(player, 0x01, 0x26);
            L0022: AddEncounter(player, 0x02, 0x28);
            L0034: AddEncounter(player, 0x05, 0x17);
            L0046: AddEncounter(player, 0x06, 0x17);
            L0058: return; // RETURN;
        }

        private void FnENCD_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x19);
            L0015: AddEncounter(player, 0x02, 0x19);
            L0027: AddEncounter(player, 0x03, 0x1B);
            L0039: AddEncounter(player, 0x04, 0x1B);
            L004B: AddEncounter(player, 0x05, 0x22);
            L005D: AddEncounter(player, 0x06, 0x23);
            L006F: return; // RETURN;
        }

        private void FnTAPECLUE_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0E81); // Rune symbols decorate the tapestry -- 
            L0010: ShowRunes(player, String0EA8); // Past the Platforms a Tapestry you will find.
            L001D: ShowRunes(player, String0ED5); // Illuminate the Moons with the Spectrum of the Moon Prism.
            L002A: ShowRunes(player, String0F0F); // Then... ACK, UGH, THUMP  (the rest of the tapestry is smeared with blood)
            L0037: return; // RETURN;
        }

        private void FnBOAT_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, FlagTypeMap, 0x01));
            L0016: if (JumpEqual) goto L0075;
            L0018: ShowMessage(player, String0F59); // You step across the platform and into the Golden Boat.
            L0025: ShowMessage(player, String0F90); // The Zephyr Wind blows the lightest of breezes from the east and the Golden Boat sets sail west across the Rainbow.
            L0032: ShowMessage(player, String1003); // In the moments that follow the Zephyr tells you only the FlexSword can remain in your hands when you encounter the Wind Elemental.
            L003F: ShowMessage(player, String1086); // Destroy him and the way to En-li-kil's Domain will be clear.
            L004C: ShowMessage(player, String10C3); // You arrive at an island in the center of the Ageless Void.
            L0059: TeleportParty(player, 0x38, 0x04, 0x4B, 0x00, isForwardMove);
            L0073: goto L0093;
            L0075: ShowMessage(player, String10FE); // The Ageless Void swallows you whole.
            L0082: DamagePlayer(player, GetMaxHits(player));
            L0093: return; // RETURN;
        }

        private void FnDOORWARN_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1123); // This door leads the way back to the Land of Giants.
            L0010: return; // RETURN;
        }

        private void FnNOLIGHT_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1157); // This side of the tapestry appears dark.
            L0010: return; // RETURN;
        }

        private void FnPLATFORM_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String117F); // You stand upon a platform in the center of the River of Eternity.
            L0010: return; // RETURN;
        }

    }
}
