#pragma warning disable
using XPT.WorldData;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap18 : AMapScripted {
        protected override int MapIndex => 18;
        protected override int RandomEncounterChance => 0;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap18() {
            MapEvent01 = FnTELEPORT_01;
            MapEvent02 = FnTELEPORT_02;
            MapEvent03 = FnTELEPORT_03;
            MapEvent04 = FnTELEPORT_04;
            MapEvent05 = FnLAVA_05;
            MapEvent13 = FnSPKEYDOR_13;
            MapEvent14 = FnKEYENC_14;
            MapEvent15 = FnFOUNHLTH_15;
            MapEvent16 = FnLKPKDOOR_16;
            MapEvent17 = FnGOLDAENC_17;
            MapEvent18 = FnGOLDBENC_18;
            MapEvent19 = FnITEMAENC_19;
            MapEvent1A = FnITEMBENC_1A;
            MapEvent1B = FnITEMCENC_1B;
            MapEvent1C = FnARMRAENC_1C;
            MapEvent1D = FnMAGICENC_1D;
            MapEvent1E = FnWEAPAENC_1E;
            MapEvent1F = FnSTRMNSTR_1F;
            MapEvent25 = FnTELMESSA_25;
            MapEvent26 = FnTELMESSB_26;
            MapEvent27 = FnTELMESSC_27;
            MapEvent28 = FnTELMESSD_28;
            MapEvent29 = FnLAVAMESS_29;
            MapEvent2A = FnNPCCHATA_2A;
            MapEvent2B = FnNPCCHATB_2B;
            MapEvent2C = FnNPCCHATC_2C;
            MapEvent2D = FnNPCCHATD_2D;
        }
        
        // === Strings ================================================
        private const string String03FC = "You step into molten lava and your flesh burns.";
        private const string String042C = "The Lava Key opens the door.";
        private const string String0449 = "The door is locked. It requires a special key.";
        private const string String0478 = "Half-starved Rogues eye you hungrily.";
        private const string String049E = "A smirking Barbarian dangles a glowing red key in your face.";
        private const string String04DB = "You sip from the Fountain of Hot Ice, but nothing happens.";
        private const string String0516 = "You sip from the Fountain of Hot Ice and feel your Health restored.";
        private const string String055A = "The door lock opens easily.";
        private const string String0576 = "The door is locked.";
        private const string String058A = "Angry Sabertooth Lions roar at you.";
        private const string String05AE = "The lion lair you enter is littered with gold.";
        private const string String05DD = "You step into a Wyvern den.";
        private const string String05F9 = "Gold coins are stuck to a Wyvern's scales.";
        private const string String0624 = "You discover a Knights' sanctuary.";
        private const string String0647 = "A Knight drops a lockpick on the floor.";
        private const string String066F = "This room is a Cleric stronghold.";
        private const string String0691 = "A Cleric shows off a wand to his associates.";
        private const string String06BE = "You step into a nest of Pincer Cobras.";
        private const string String06E5 = "In a snake nest is a shining prism.";
        private const string String0709 = "You interrupt a Wizards' coven.";
        private const string String0729 = "The chief Wizard of the coven wears a round breastplate.";
        private const string String0762 = "Rogue Rangers use this place as a safehold.";
        private const string String078E = "A sly Ranger hides something inside his jacket.";
        private const string String07BE = "Rogue Barbarians have a wrestling center here.";
        private const string String07ED = "A Barbarian throws a heavy mace aside to swing at you.";
        private const string String0824 = "There is a teleport in the north wall.";
        private const string String084B = "There is a teleport in the south wall.";
        private const string String0872 = "There is a teleport in the east wall.";
        private const string String0898 = "There is a teleport in the south wall.";
        private const string String08BF = "The heat of the adjacent lava weakens you.";
        private const string String08EA = "You encounter a Troll Knight.";
        private const string String0908 = "The only way to get out of this basement area is to go through the lava field. Touching the lava is deadly, as you might expect. However, even if you pass safely through the lava field, the great heat of the lava will sap your strength.";
        private const string String09F5 = "The Troll Knight scowls angrily, causing you to leave her alone.";
        private const string String0A36 = "You encounter a Dwarf Thief.";
        private const string String0A53 = "I know there is a short cut through the lava field. If you can find the correct key, you will be able to use the short cut. The key also will lead you to riches.";
        private const string String0AF5 = "The Dwarf Thief runs away.";
        private const string String0B10 = "You encounter a Halfling Ranger.";
        private const string String0B31 = "The dwarves who built Cleowyn's Palace transported precious metals and building blocks up to the top level by means of a teleport. I believe the teleport is somewhere in this area.";
        private const string String0BE6 = "The Halfling Ranger faints from heat stroke.";
        private const string String0C13 = "You encounter a Gremlin Cleric.";
        private const string String0C33 = "Deep in the dungeon are the Pillow Labyrinths. They were formed from pillow lava that spilled into the sea. The labyrinth is formed from the hollow interior of the lava.";
        private const string String0CDD = "The Gremlin Cleric is deep in meditation and does not answer you.";
        
        // === Functions ================================================
        private void FnTELEPORT_01(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x05, 0x03, 0x40, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELEPORT_02(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x04, 0x01, 0x78, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELEPORT_03(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x05, 0x02, 0xF1, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELEPORT_04(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x05, 0x02, 0x96, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnLAVA_05(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFloorObject(party, 0x02, GetCurrentTile(party));
            L0018: ShowMessage(party, String03FC); // You step into molten lava and your flesh burns.
            L0025: DamagePlayer(party, GetMaxHits(party));
            L0036: return; // RETURN;
        }

        private void FnSPKEYDOR_13(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(party, 0xE2, 0xE2);
            L0016: if (JumpEqual) goto L0063;
            L0018: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L0036: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L0054: ShowMessage(party, String042C); // The Lava Key opens the door.
            L0061: goto L00AB;
            L0063: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L0081: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x00);
            L009E: ShowMessage(party, String0449); // The door is locked. It requires a special key.
            L00AB: return; // RETURN;
        }

        private void FnKEYENC_14(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0xE2);
            L0011: if (JumpEqual) goto L0041;
            L0013: ShowMessage(party, String0478); // Half-starved Rogues eye you hungrily.
            L0020: AddTreasure(party, 0x1388, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L003F: goto L006D;
            L0041: AddTreasure(party, 0x1F40, 0x00, 0x00, 0x00, 0x00, 0xE2);
            L0060: ShowMessage(party, String049E); // A smirking Barbarian dangles a glowing red key in your face.
            L006D: Compare(PartyCount(party), 0x0001);
            L0078: if (JumpNotEqual) goto L00A1;
            L007A: AddEncounter(party, 0x01, 0x27);
            L008C: AddEncounter(party, 0x05, 0x28);
            L009E: goto L01BC;
            L00A1: Compare(PartyCount(party), 0x0002);
            L00AC: if (JumpNotEqual) goto L00E7;
            L00AE: AddEncounter(party, 0x01, 0x26);
            L00C0: AddEncounter(party, 0x02, 0x27);
            L00D2: AddEncounter(party, 0x05, 0x28);
            L00E4: goto L01BC;
            L00E7: Compare(PartyCount(party), 0x0003);
            L00F2: if (JumpNotEqual) goto L0150;
            L00F4: AddEncounter(party, 0x01, 0x26);
            L0106: AddEncounter(party, 0x02, 0x27);
            L0118: AddEncounter(party, 0x03, 0x27);
            L012A: AddEncounter(party, 0x05, 0x28);
            L013C: AddEncounter(party, 0x06, 0x28);
            L014E: goto L01BC;
            L0150: AddEncounter(party, 0x01, 0x26);
            L0162: AddEncounter(party, 0x02, 0x27);
            L0174: AddEncounter(party, 0x03, 0x28);
            L0186: AddEncounter(party, 0x04, 0x28);
            L0198: AddEncounter(party, 0x05, 0x28);
            L01AA: AddEncounter(party, 0x06, 0x28);
            L01BC: return; // RETURN;
        }

        private void FnFOUNHLTH_15(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x01), 0x0001);
            L0017: if (JumpNotEqual) goto L0035;
            L0019: ShowPortrait(party, 0x0042);
            L0026: ShowMessage(party, String04DB); // You sip from the Fountain of Hot Ice, but nothing happens.
            L0033: goto L0071;
            L0035: HealPlayer(party, 0x07D0);
            L0042: SetState(party, 0x01, 0x01, 0x01);
            L0057: ShowPortrait(party, 0x0042);
            L0064: ShowMessage(party, String0516); // You sip from the Fountain of Hot Ice and feel your Health restored.
            L0071: return; // RETURN;
        }

        private void FnLKPKDOOR_16(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(party, 0xC2, 0xC4);
            L0016: if (JumpNotEqual) goto L0029;
            L0018: Compare(HasUsedSkill(party, 0x0E), 0x0008);
            L0027: if (JumpBelow) goto L0074;
            L0029: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L0047: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L0065: ShowMessage(party, String055A); // The door lock opens easily.
            L0072: goto L009E;
            L0074: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x00);
            L0091: ShowMessage(party, String0576); // The door is locked.
            L009E: return; // RETURN;
        }

        private void FnGOLDAENC_17(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x02, 0x3B), 0x0001);
            L0017: if (JumpNotEqual) goto L0047;
            L0019: ShowMessage(party, String058A); // Angry Sabertooth Lions roar at you.
            L0026: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L0045: goto L008A;
            L0047: AddTreasure(party, 0x2710, 0x00, 0x00, 0xB9, 0xD0, 0xD0);
            L0068: SetState(party, 0x02, 0x3B, 0x01);
            L007D: ShowMessage(party, String05AE); // The lion lair you enter is littered with gold.
            L008A: Compare(PartyCount(party), 0x0001);
            L0095: if (JumpNotEqual) goto L00AC;
            L0097: AddEncounter(party, 0x01, 0x1B);
            L00A9: goto L016D;
            L00AC: Compare(PartyCount(party), 0x0002);
            L00B7: if (JumpNotEqual) goto L00E0;
            L00B9: AddEncounter(party, 0x01, 0x1B);
            L00CB: AddEncounter(party, 0x02, 0x1B);
            L00DD: goto L016D;
            L00E0: Compare(PartyCount(party), 0x0003);
            L00EB: if (JumpNotEqual) goto L0125;
            L00ED: AddEncounter(party, 0x01, 0x1B);
            L00FF: AddEncounter(party, 0x02, 0x1B);
            L0111: AddEncounter(party, 0x03, 0x1B);
            L0123: goto L016D;
            L0125: AddEncounter(party, 0x01, 0x1B);
            L0137: AddEncounter(party, 0x02, 0x1B);
            L0149: AddEncounter(party, 0x03, 0x1B);
            L015B: AddEncounter(party, 0x04, 0x1B);
            L016D: return; // RETURN;
        }

        private void FnGOLDBENC_18(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x02, 0x3C), 0x0001);
            L0017: if (JumpNotEqual) goto L0047;
            L0019: ShowMessage(party, String05DD); // You step into a Wyvern den.
            L0026: AddTreasure(party, 0x1B58, 0x00, 0x00, 0x00, 0x00, 0xD0);
            L0045: goto L0089;
            L0047: AddTreasure(party, 0x2EE0, 0x00, 0x00, 0x00, 0xB9, 0xB4);
            L0067: SetState(party, 0x02, 0x3C, 0x01);
            L007C: ShowMessage(party, String05F9); // Gold coins are stuck to a Wyvern's scales.
            L0089: Compare(PartyCount(party), 0x0001);
            L0094: if (JumpNotEqual) goto L00AB;
            L0096: AddEncounter(party, 0x01, 0x1F);
            L00A8: goto L016C;
            L00AB: Compare(PartyCount(party), 0x0002);
            L00B6: if (JumpNotEqual) goto L00DF;
            L00B8: AddEncounter(party, 0x01, 0x1F);
            L00CA: AddEncounter(party, 0x02, 0x1F);
            L00DC: goto L016C;
            L00DF: Compare(PartyCount(party), 0x0003);
            L00EA: if (JumpNotEqual) goto L0124;
            L00EC: AddEncounter(party, 0x01, 0x1F);
            L00FE: AddEncounter(party, 0x02, 0x1F);
            L0110: AddEncounter(party, 0x05, 0x1F);
            L0122: goto L016C;
            L0124: AddEncounter(party, 0x01, 0x1F);
            L0136: AddEncounter(party, 0x02, 0x1F);
            L0148: AddEncounter(party, 0x04, 0x1F);
            L015A: AddEncounter(party, 0x06, 0x1F);
            L016C: return; // RETURN;
        }

        private void FnITEMAENC_19(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0xC4);
            L0011: if (JumpEqual) goto L0041;
            L0013: ShowMessage(party, String0624); // You discover a Knights' sanctuary.
            L0020: AddTreasure(party, 0x0BB8, 0x00, 0x00, 0x00, 0x00, 0xB7);
            L003F: goto L006E;
            L0041: AddTreasure(party, 0x2328, 0x00, 0x00, 0x00, 0xD0, 0xC4);
            L0061: ShowMessage(party, String0647); // A Knight drops a lockpick on the floor.
            L006E: Compare(PartyCount(party), 0x0001);
            L0079: if (JumpNotEqual) goto L0090;
            L007B: AddEncounter(party, 0x01, 0x23);
            L008D: goto L0187;
            L0090: Compare(PartyCount(party), 0x0002);
            L009B: if (JumpNotEqual) goto L00C4;
            L009D: AddEncounter(party, 0x01, 0x23);
            L00AF: AddEncounter(party, 0x02, 0x24);
            L00C1: goto L0187;
            L00C4: Compare(PartyCount(party), 0x0003);
            L00CF: if (JumpNotEqual) goto L011B;
            L00D1: AddEncounter(party, 0x01, 0x23);
            L00E3: AddEncounter(party, 0x02, 0x23);
            L00F5: AddEncounter(party, 0x03, 0x24);
            L0107: AddEncounter(party, 0x04, 0x24);
            L0119: goto L0187;
            L011B: AddEncounter(party, 0x01, 0x23);
            L012D: AddEncounter(party, 0x02, 0x24);
            L013F: AddEncounter(party, 0x03, 0x24);
            L0151: AddEncounter(party, 0x04, 0x23);
            L0163: AddEncounter(party, 0x05, 0x23);
            L0175: AddEncounter(party, 0x06, 0x24);
            L0187: return; // RETURN;
        }

        private void FnITEMBENC_1A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0xC9);
            L0011: if (JumpEqual) goto L0042;
            L0013: ShowMessage(party, String066F); // This room is a Cleric stronghold.
            L0020: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0xCB, 0xB2);
            L0040: goto L006F;
            L0042: AddTreasure(party, 0x2710, 0x00, 0x00, 0x00, 0xCD, 0xC9);
            L0062: ShowMessage(party, String0691); // A Cleric shows off a wand to his associates.
            L006F: Compare(PartyCount(party), 0x0001);
            L007A: if (JumpNotEqual) goto L0091;
            L007C: AddEncounter(party, 0x01, 0x25);
            L008E: goto L0188;
            L0091: Compare(PartyCount(party), 0x0002);
            L009C: if (JumpNotEqual) goto L00C5;
            L009E: AddEncounter(party, 0x01, 0x25);
            L00B0: AddEncounter(party, 0x02, 0x25);
            L00C2: goto L0188;
            L00C5: Compare(PartyCount(party), 0x0003);
            L00D0: if (JumpNotEqual) goto L011C;
            L00D2: AddEncounter(party, 0x01, 0x25);
            L00E4: AddEncounter(party, 0x02, 0x25);
            L00F6: AddEncounter(party, 0x05, 0x25);
            L0108: AddEncounter(party, 0x05, 0x25);
            L011A: goto L0188;
            L011C: AddEncounter(party, 0x01, 0x25);
            L012E: AddEncounter(party, 0x02, 0x25);
            L0140: AddEncounter(party, 0x03, 0x25);
            L0152: AddEncounter(party, 0x04, 0x25);
            L0164: AddEncounter(party, 0x05, 0x25);
            L0176: AddEncounter(party, 0x06, 0x25);
            L0188: return; // RETURN;
        }

        private void FnITEMCENC_1B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0xBE);
            L0011: if (JumpEqual) goto L0041;
            L0013: ShowMessage(party, String06BE); // You step into a nest of Pincer Cobras.
            L0020: AddTreasure(party, 0x1388, 0x00, 0x00, 0x00, 0x00, 0xB7);
            L003F: goto L006E;
            L0041: AddTreasure(party, 0x2710, 0x00, 0x00, 0x00, 0xD0, 0xBE);
            L0061: ShowMessage(party, String06E5); // In a snake nest is a shining prism.
            L006E: Compare(PartyCount(party), 0x0001);
            L0079: if (JumpNotEqual) goto L00A2;
            L007B: AddEncounter(party, 0x01, 0x1D);
            L008D: AddEncounter(party, 0x05, 0x1E);
            L009F: goto L0165;
            L00A2: Compare(PartyCount(party), 0x0002);
            L00AD: if (JumpNotEqual) goto L00F9;
            L00AF: AddEncounter(party, 0x01, 0x1E);
            L00C1: AddEncounter(party, 0x02, 0x1D);
            L00D3: AddEncounter(party, 0x03, 0x1D);
            L00E5: AddEncounter(party, 0x04, 0x1E);
            L00F7: goto L0165;
            L00F9: AddEncounter(party, 0x01, 0x1D);
            L010B: AddEncounter(party, 0x02, 0x1D);
            L011D: AddEncounter(party, 0x03, 0x1D);
            L012F: AddEncounter(party, 0x04, 0x1D);
            L0141: AddEncounter(party, 0x05, 0x1E);
            L0153: AddEncounter(party, 0x06, 0x1E);
            L0165: return; // RETURN;
        }

        private void FnARMRAENC_1C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0x82);
            L0011: if (JumpEqual) goto L0042;
            L0013: ShowMessage(party, String0709); // You interrupt a Wizards' coven.
            L0020: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0xAA, 0xB9);
            L0040: goto L006F;
            L0042: AddTreasure(party, 0x1770, 0x00, 0x00, 0x00, 0xB9, 0x82);
            L0062: ShowMessage(party, String0729); // The chief Wizard of the coven wears a round breastplate.
            L006F: Compare(PartyCount(party), 0x0001);
            L007A: if (JumpNotEqual) goto L00A3;
            L007C: AddEncounter(party, 0x01, 0x28);
            L008E: AddEncounter(party, 0x02, 0x28);
            L00A0: goto L0166;
            L00A3: Compare(PartyCount(party), 0x0002);
            L00AE: if (JumpNotEqual) goto L00FA;
            L00B0: AddEncounter(party, 0x01, 0x28);
            L00C2: AddEncounter(party, 0x02, 0x28);
            L00D4: AddEncounter(party, 0x05, 0x28);
            L00E6: AddEncounter(party, 0x06, 0x28);
            L00F8: goto L0166;
            L00FA: AddEncounter(party, 0x01, 0x28);
            L010C: AddEncounter(party, 0x02, 0x28);
            L011E: AddEncounter(party, 0x03, 0x28);
            L0130: AddEncounter(party, 0x04, 0x28);
            L0142: AddEncounter(party, 0x05, 0x28);
            L0154: AddEncounter(party, 0x06, 0x28);
            L0166: return; // RETURN;
        }

        private void FnMAGICENC_1D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0x9E);
            L0011: if (JumpEqual) goto L0042;
            L0013: ShowMessage(party, String0762); // Rogue Rangers use this place as a safehold.
            L0020: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0xB6, 0xB8);
            L0040: goto L006F;
            L0042: AddTreasure(party, 0x1770, 0x00, 0x00, 0x00, 0xD0, 0x9E);
            L0062: ShowMessage(party, String078E); // A sly Ranger hides something inside his jacket.
            L006F: Compare(PartyCount(party), 0x0001);
            L007A: if (JumpNotEqual) goto L00A3;
            L007C: AddEncounter(party, 0x01, 0x20);
            L008E: AddEncounter(party, 0x05, 0x21);
            L00A0: goto L0166;
            L00A3: Compare(PartyCount(party), 0x0002);
            L00AE: if (JumpNotEqual) goto L00FA;
            L00B0: AddEncounter(party, 0x01, 0x20);
            L00C2: AddEncounter(party, 0x02, 0x21);
            L00D4: AddEncounter(party, 0x03, 0x21);
            L00E6: AddEncounter(party, 0x04, 0x20);
            L00F8: goto L0166;
            L00FA: AddEncounter(party, 0x01, 0x20);
            L010C: AddEncounter(party, 0x02, 0x20);
            L011E: AddEncounter(party, 0x03, 0x21);
            L0130: AddEncounter(party, 0x04, 0x21);
            L0142: AddEncounter(party, 0x05, 0x21);
            L0154: AddEncounter(party, 0x06, 0x20);
            L0166: return; // RETURN;
        }

        private void FnWEAPAENC_1E(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0x29);
            L0011: if (JumpEqual) goto L0041;
            L0013: ShowMessage(party, String07BE); // Rogue Barbarians have a wrestling center here.
            L0020: AddTreasure(party, 0x1B58, 0x00, 0x00, 0x00, 0x00, 0xAD);
            L003F: goto L006E;
            L0041: AddTreasure(party, 0x2328, 0x00, 0x00, 0x00, 0xB7, 0x29);
            L0061: ShowMessage(party, String07ED); // A Barbarian throws a heavy mace aside to swing at you.
            L006E: Compare(PartyCount(party), 0x0001);
            L0079: if (JumpNotEqual) goto L00A2;
            L007B: AddEncounter(party, 0x01, 0x26);
            L008D: AddEncounter(party, 0x05, 0x27);
            L009F: goto L0165;
            L00A2: Compare(PartyCount(party), 0x0002);
            L00AD: if (JumpNotEqual) goto L00F9;
            L00AF: AddEncounter(party, 0x01, 0x27);
            L00C1: AddEncounter(party, 0x02, 0x26);
            L00D3: AddEncounter(party, 0x03, 0x26);
            L00E5: AddEncounter(party, 0x06, 0x27);
            L00F7: goto L0165;
            L00F9: AddEncounter(party, 0x01, 0x26);
            L010B: AddEncounter(party, 0x02, 0x26);
            L011D: AddEncounter(party, 0x03, 0x27);
            L012F: AddEncounter(party, 0x04, 0x27);
            L0141: AddEncounter(party, 0x05, 0x26);
            L0153: AddEncounter(party, 0x06, 0x26);
            L0165: return; // RETURN;
        }

        private void FnSTRMNSTR_1F(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(party), 0x0001);
            L000E: if (JumpNotEqual) goto L0049;
            L0010: AddEncounter(party, 0x01, 0x19);
            L0022: AddEncounter(party, 0x02, 0x19);
            L0034: AddEncounter(party, 0x03, 0x1A);
            L0046: goto L0188;
            L0049: Compare(PartyCount(party), 0x0002);
            L0054: if (JumpNotEqual) goto L00A1;
            L0056: AddEncounter(party, 0x01, 0x1A);
            L0068: AddEncounter(party, 0x02, 0x1A);
            L007A: AddEncounter(party, 0x03, 0x19);
            L008C: AddEncounter(party, 0x04, 0x19);
            L009E: goto L0188;
            L00A1: Compare(PartyCount(party), 0x0003);
            L00AC: if (JumpNotEqual) goto L011C;
            L00AE: AddEncounter(party, 0x01, 0x19);
            L00C0: AddEncounter(party, 0x02, 0x1A);
            L00D2: AddEncounter(party, 0x03, 0x19);
            L00E4: AddEncounter(party, 0x04, 0x1A);
            L00F6: AddEncounter(party, 0x05, 0x19);
            L0108: AddEncounter(party, 0x05, 0x1A);
            L011A: goto L0188;
            L011C: AddEncounter(party, 0x01, 0x19);
            L012E: AddEncounter(party, 0x02, 0x19);
            L0140: AddEncounter(party, 0x03, 0x1A);
            L0152: AddEncounter(party, 0x04, 0x1A);
            L0164: AddEncounter(party, 0x05, 0x1A);
            L0176: AddEncounter(party, 0x06, 0x1A);
            L0188: return; // RETURN;
        }

        private void FnTELMESSA_25(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0824); // There is a teleport in the north wall.
            L0010: return; // RETURN;
        }

        private void FnTELMESSB_26(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String084B); // There is a teleport in the south wall.
            L0010: return; // RETURN;
        }

        private void FnTELMESSC_27(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0872); // There is a teleport in the east wall.
            L0010: return; // RETURN;
        }

        private void FnTELMESSD_28(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0898); // There is a teleport in the south wall.
            L0010: return; // RETURN;
        }

        private void FnLAVAMESS_29(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String08BF); // The heat of the adjacent lava weakens you.
            L0010: DamagePlayer(party, 0x0005);
            L001D: return; // RETURN;
        }

        private void FnNPCCHATA_2A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String08EA); // You encounter a Troll Knight.
            L0010: ShowPortrait(party, 0x001B);
            L001D: Compare(GetRandom(party, 0x000F), 0x000C);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String0908); // The only way to get out of this basement area is to go through the lava field. Touching the lava is deadly, as you might expect. However, even if you pass safely through the lava field, the great heat of the lava will sap your strength.
            L003C: goto L004B;
            L003E: ShowMessage(party, String09F5); // The Troll Knight scowls angrily, causing you to leave her alone.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATB_2B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0A36); // You encounter a Dwarf Thief.
            L0010: ShowPortrait(party, 0x0023);
            L001D: Compare(GetRandom(party, 0x000F), 0x0009);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String0A53); // I know there is a short cut through the lava field. If you can find the correct key, you will be able to use the short cut. The key also will lead you to riches.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0AF5); // The Dwarf Thief runs away.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATC_2C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0B10); // You encounter a Halfling Ranger.
            L0010: ShowPortrait(party, 0x0021);
            L001D: Compare(GetRandom(party, 0x000F), 0x0007);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String0B31); // The dwarves who built Cleowyn's Palace transported precious metals and building blocks up to the top level by means of a teleport. I believe the teleport is somewhere in this area.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0BE6); // The Halfling Ranger faints from heat stroke.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATD_2D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0C13); // You encounter a Gremlin Cleric.
            L0010: ShowPortrait(party, 0x002A);
            L001D: Compare(GetRandom(party, 0x000F), 0x000C);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String0C33); // Deep in the dungeon are the Pillow Labyrinths. They were formed from pillow lava that spilled into the sea. The labyrinth is formed from the hollow interior of the lava.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0CDD); // The Gremlin Cleric is deep in meditation and does not answer you.
            L004B: return; // RETURN;
        }

    }
}
