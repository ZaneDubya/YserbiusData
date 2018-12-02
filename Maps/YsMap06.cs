#pragma warning disable
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap06 : AMapScripted {
        protected override int MapIndex => 6;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap06() {
            MapEvent01 = FnSTRSTELE_01;
            MapEvent02 = FnSTAIRSUP_02;
            MapEvent03 = FnTELPORTE_03;
            MapEvent04 = FnTELPORTW_04;
            MapEvent05 = FnHIDNDOOR_05;
            MapEvent06 = FnGOLDAENC_06;
            MapEvent07 = FnFOUNTAIN_07;
            MapEvent08 = FnLKPKDOOR_08;
            MapEvent09 = FnSTRMNSTR_09;
            MapEvent0A = FnVTFMNSTR_0A;
            MapEvent0B = FnSTRMNSTR_0B;
            MapEvent0C = FnBADMNSTR_0C;
            MapEvent0D = FnGOLDBENC_0D;
            MapEvent0E = FnWEAPENC_0E;
            MapEvent0F = FnARMORENC_0F;
            MapEvent10 = FnMAGICENC_10;
            MapEvent11 = FnITEMBENC_11;
            MapEvent12 = FnITEMCENC_12;
            MapEvent13 = FnTELEPORT_13;
            MapEvent14 = FnSTRSMESS_14;
            MapEvent15 = FnSTRSMESS_15;
            MapEvent16 = FnSTRSMESS_16;
            MapEvent17 = FnSTRSMESS_17;
            MapEvent18 = FnTELEMESS_18;
            MapEvent19 = FnTELEMESS_19;
            MapEvent1A = FnTELEPORT_1A;
            MapEvent1B = FnTELEMESS_1B;
            MapEvent1C = FnNPCCHATA_1C;
            MapEvent1D = FnNPCCHATB_1D;
            MapEvent1E = FnNPCCHATC_1E;
            MapEvent1F = FnNPCCHATD_1F;
            MapEvent20 = FnNPCCHATE_20;
        }
        
        // === Strings ================================================
        private const string String03FC = "You found a hidden door in the east wall.";
        private const string String0426 = "Rogues are splitting up some gold they stole.";
        private const string String0454 = "You take a sip from the fountain, but nothing happens.";
        private const string String048B = "You take a sip from the Healing Fountain and feel your Health improve quite a bit.";
        private const string String04DE = "You skillfully pick the door lock.";
        private const string String0501 = "The door is locked.";
        private const string String0515 = "Minotaurs charge you.";
        private const string String052B = "A Minotaur teases you by holding a bag of gold just out of reach.";
        private const string String056D = "Huge beings lumber into sight.";
        private const string String058C = "You have entered a Rogue encampment.";
        private const string String05B1 = "You encounter marauding Hobgoblins.";
        private const string String05D5 = "The sound of hooves on stone alerts you to danger.";
        private const string String0608 = "Gruff laughter surrounds you.";
        private const string String0626 = "The stairs through the south gateway lead upwards.";
        private const string String0659 = "Through the west gateway are stairs leading upwards.";
        private const string String068E = "The stairs through the north gateway lead upwards.";
        private const string String06C1 = "The stairs past the north gateway lead up a level.";
        private const string String06F4 = "There is a teleport in the east wall.";
        private const string String071A = "There is a teleport in the west wall.";
        private const string String0740 = "There is a teleport in the west wall.";
        private const string String0766 = "You encounter a Gnome Thief.";
        private const string String0783 = "There is more to this basement than first meets the eye. Someday I will learn the secret of what lies behind the thick, silent walls that line this corridor.";
        private const string String0821 = "The Gnome Thief smiles enigmatically and ducks into the shadows.";
        private const string String0862 = "You encounter a Human Barbarian.";
        private const string String0883 = "As much as I despise orcs, I sometimes find it useful to have them in my party. Indeed, you will frequently have to work with races and Guilds you would otherwise ignore, if you wish to solve the many mysteries of this dungeon.";
        private const string String0967 = "The Human Barbarian raps you with his club and trudges away.";
        private const string String09A4 = "You encounter an Orc Knight.";
        private const string String09C1 = "A colleague told me he encountered a strange elfin race far down in the dungeon. He would not say much else, other than that he knew why cold-loving creatures were to be found inside a volcano.";
        private const string String0A83 = "The Orc Knight bows graciously and walks away.";
        private const string String0AB2 = "You encounter an Elf Cleric.";
        private const string String0ACF = "I stumbled over a marble block not long ago. On it were the words - Arnakkian Slowfoot, Wizard to the King.";
        private const string String0B3B = "The Elf Cleric sighs mournfully and massages a stubbed toe.";
        private const string String0B77 = "You encounter a Human Thief.";
        private const string String0B94 = "To the east of the Rune Room on level three can be found the Wizards' Challenge. It is quite a challenge, too.";
        private const string String0C03 = "I have found several short cuts in the Wizards' Challenge.";
        private const string String0C3E = "The Human Thief points at something behind you. While your back is turned, she sneaks away.";
        
        // === Functions ================================================
        private void FnSTRSTELE_01(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x01, 0x04, 0x01, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnSTAIRSUP_02(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x01, 0x06, 0x2E, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELPORTE_03(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x02, 0x01, 0x07, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELPORTW_04(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x02, 0x01, 0x04, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnHIDNDOOR_05(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(party, 0x0D), 0x0006);
            L0012: if (JumpNotBelow) goto L0063;
            L0014: RefreshCompareFlags(HasUsedSpell(party, 0x17));
            L0022: if (JumpNotEqual) goto L0063;
            L0024: ax = HasUsedItem(party, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L0063;
            L0039: ax = HasUsedItem(party, 0xBD, 0xBD);
            L004C: if (JumpNotEqual) goto L0063;
            L004E: ax = HasUsedItem(party, 0xBE, 0xBE);
            L0061: if (JumpEqual) goto L00A0;
            L0063: SetWallPassable(party, 0x02, 0x02, 0x01);
            L0079: SetWallObject(party, 0x01, GetCurrentTile(party), 0x02);
            L0093: ShowMessage(party, String03FC); // You found a hidden door in the east wall.
            L00A0: return; // RETURN;
        }

        private void FnGOLDAENC_06(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(party, 0x02, 0x16));
            L0016: if (JumpNotEqual) goto L0039;
            L0018: AddTreasure(party, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L0037: goto L007A;
            L0039: AddTreasure(party, 0x0FA0, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L0058: SetFlag(party, 0x02, 0x16, 0x01);
            L006D: ShowMessage(party, String0426); // Rogues are splitting up some gold they stole.
            L007A: Compare(PartyCount(party), 0x0001);
            L0085: if (JumpNotEqual) goto L00AE;
            L0087: AddEncounter(party, 0x01, 0x1D);
            L0099: AddEncounter(party, 0x02, 0x0A);
            L00AB: goto L01C9;
            L00AE: Compare(PartyCount(party), 0x0002);
            L00B9: if (JumpNotEqual) goto L00F4;
            L00BB: AddEncounter(party, 0x01, 0x1E);
            L00CD: AddEncounter(party, 0x02, 0x05);
            L00DF: AddEncounter(party, 0x03, 0x0D);
            L00F1: goto L01C9;
            L00F4: Compare(PartyCount(party), 0x0003);
            L00FF: if (JumpNotEqual) goto L015D;
            L0101: AddEncounter(party, 0x01, 0x1F);
            L0113: AddEncounter(party, 0x02, 0x0B);
            L0125: AddEncounter(party, 0x03, 0x04);
            L0137: AddEncounter(party, 0x04, 0x07);
            L0149: AddEncounter(party, 0x05, 0x0D);
            L015B: goto L01C9;
            L015D: AddEncounter(party, 0x01, 0x20);
            L016F: AddEncounter(party, 0x02, 0x0B);
            L0181: AddEncounter(party, 0x03, 0x06);
            L0193: AddEncounter(party, 0x04, 0x08);
            L01A5: AddEncounter(party, 0x05, 0x0A);
            L01B7: AddEncounter(party, 0x06, 0x0D);
            L01C9: return; // RETURN;
        }

        private void FnFOUNTAIN_07(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(party, 0x02, 0x1E), 0x0001);
            L0017: if (JumpNotEqual) goto L0035;
            L0019: ShowPortrait(party, 0x0042);
            L0026: ShowMessage(party, String0454); // You take a sip from the fountain, but nothing happens.
            L0033: goto L0075;
            L0035: HealPlayer(party, GetMaxHits(party));
            L0046: SetFlag(party, 0x02, 0x1E, 0x01);
            L005B: ShowPortrait(party, 0x0042);
            L0068: ShowMessage(party, String048B); // You take a sip from the Healing Fountain and feel your Health improve quite a bit.
            L0075: return; // RETURN;
        }

        private void FnLKPKDOOR_08(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(party, 0xBF, 0xC4);
            L0016: if (JumpNotEqual) goto L0029;
            L0018: Compare(HasUsedSkill(party, 0x0E), 0x0006);
            L0027: if (JumpBelow) goto L0074;
            L0029: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L0047: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L0065: ShowMessage(party, String04DE); // You skillfully pick the door lock.
            L0072: goto L009E;
            L0074: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x00);
            L0091: ShowMessage(party, String0501); // The door is locked.
            L009E: return; // RETURN;
        }

        private void FnSTRMNSTR_09(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(party), 0x0001);
            L000E: if (JumpNotEqual) goto L0025;
            L0010: AddEncounter(party, 0x01, 0x19);
            L0022: goto L0140;
            L0025: Compare(PartyCount(party), 0x0002);
            L0030: if (JumpNotEqual) goto L006B;
            L0032: AddEncounter(party, 0x01, 0x19);
            L0044: AddEncounter(party, 0x02, 0x1A);
            L0056: AddEncounter(party, 0x03, 0x19);
            L0068: goto L0140;
            L006B: Compare(PartyCount(party), 0x0003);
            L0076: if (JumpNotEqual) goto L00D4;
            L0078: AddEncounter(party, 0x01, 0x1A);
            L008A: AddEncounter(party, 0x02, 0x1A);
            L009C: AddEncounter(party, 0x03, 0x1B);
            L00AE: AddEncounter(party, 0x04, 0x1B);
            L00C0: AddEncounter(party, 0x05, 0x19);
            L00D2: goto L0140;
            L00D4: AddEncounter(party, 0x01, 0x1C);
            L00E6: AddEncounter(party, 0x02, 0x1C);
            L00F8: AddEncounter(party, 0x03, 0x1C);
            L010A: AddEncounter(party, 0x04, 0x1C);
            L011C: AddEncounter(party, 0x05, 0x19);
            L012E: AddEncounter(party, 0x06, 0x19);
            L0140: return; // RETURN;
        }

        private void FnVTFMNSTR_0A(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(party), 0x0001);
            L000E: if (JumpNotEqual) goto L0037;
            L0010: AddEncounter(party, 0x01, 0x1E);
            L0022: AddEncounter(party, 0x02, 0x1E);
            L0034: goto L0140;
            L0037: Compare(PartyCount(party), 0x0002);
            L0042: if (JumpNotEqual) goto L007D;
            L0044: AddEncounter(party, 0x01, 0x1D);
            L0056: AddEncounter(party, 0x02, 0x1E);
            L0068: AddEncounter(party, 0x03, 0x20);
            L007A: goto L0140;
            L007D: Compare(PartyCount(party), 0x0003);
            L0088: if (JumpNotEqual) goto L00D4;
            L008A: AddEncounter(party, 0x01, 0x20);
            L009C: AddEncounter(party, 0x02, 0x20);
            L00AE: AddEncounter(party, 0x03, 0x1D);
            L00C0: AddEncounter(party, 0x04, 0x1D);
            L00D2: goto L0140;
            L00D4: AddEncounter(party, 0x01, 0x1D);
            L00E6: AddEncounter(party, 0x02, 0x1D);
            L00F8: AddEncounter(party, 0x03, 0x1E);
            L010A: AddEncounter(party, 0x04, 0x1F);
            L011C: AddEncounter(party, 0x05, 0x20);
            L012E: AddEncounter(party, 0x06, 0x20);
            L0140: return; // RETURN;
        }

        private void FnSTRMNSTR_0B(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(party), 0x0001);
            L000E: if (JumpNotEqual) goto L0025;
            L0010: AddEncounter(party, 0x01, 0x21);
            L0022: goto L011C;
            L0025: Compare(PartyCount(party), 0x0002);
            L0030: if (JumpNotEqual) goto L0059;
            L0032: AddEncounter(party, 0x01, 0x21);
            L0044: AddEncounter(party, 0x02, 0x21);
            L0056: goto L011C;
            L0059: Compare(PartyCount(party), 0x0003);
            L0064: if (JumpNotEqual) goto L00B0;
            L0066: AddEncounter(party, 0x01, 0x24);
            L0078: AddEncounter(party, 0x02, 0x24);
            L008A: AddEncounter(party, 0x03, 0x21);
            L009C: AddEncounter(party, 0x04, 0x23);
            L00AE: goto L011C;
            L00B0: AddEncounter(party, 0x01, 0x23);
            L00C2: AddEncounter(party, 0x02, 0x23);
            L00D4: AddEncounter(party, 0x03, 0x24);
            L00E6: AddEncounter(party, 0x04, 0x24);
            L00F8: AddEncounter(party, 0x05, 0x22);
            L010A: AddEncounter(party, 0x06, 0x22);
            L011C: return; // RETURN;
        }

        private void FnBADMNSTR_0C(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(party), 0x0001);
            L000E: if (JumpNotEqual) goto L0025;
            L0010: AddEncounter(party, 0x01, 0x25);
            L0022: goto L0140;
            L0025: Compare(PartyCount(party), 0x0002);
            L0030: if (JumpNotEqual) goto L006B;
            L0032: AddEncounter(party, 0x01, 0x26);
            L0044: AddEncounter(party, 0x02, 0x26);
            L0056: AddEncounter(party, 0x05, 0x28);
            L0068: goto L0140;
            L006B: Compare(PartyCount(party), 0x0003);
            L0076: if (JumpNotEqual) goto L00D4;
            L0078: AddEncounter(party, 0x01, 0x25);
            L008A: AddEncounter(party, 0x02, 0x25);
            L009C: AddEncounter(party, 0x03, 0x27);
            L00AE: AddEncounter(party, 0x04, 0x27);
            L00C0: AddEncounter(party, 0x05, 0x28);
            L00D2: goto L0140;
            L00D4: AddEncounter(party, 0x01, 0x27);
            L00E6: AddEncounter(party, 0x02, 0x27);
            L00F8: AddEncounter(party, 0x03, 0x25);
            L010A: AddEncounter(party, 0x04, 0x25);
            L011C: AddEncounter(party, 0x05, 0x28);
            L012E: AddEncounter(party, 0x06, 0x28);
            L0140: return; // RETURN;
        }

        private void FnGOLDBENC_0D(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(party, 0x02, 0x17), 0x0001);
            L0017: if (JumpNotEqual) goto L0047;
            L0019: ShowMessage(party, String0515); // Minotaurs charge you.
            L0026: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0xCE);
            L0045: goto L0088;
            L0047: AddTreasure(party, 0x1388, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L0066: SetFlag(party, 0x02, 0x17, 0x01);
            L007B: ShowMessage(party, String052B); // A Minotaur teases you by holding a bag of gold just out of reach.
            L0088: Compare(PartyCount(party), 0x0001);
            L0093: if (JumpNotEqual) goto L00AA;
            L0095: AddEncounter(party, 0x01, 0x22);
            L00A7: goto L016B;
            L00AA: Compare(PartyCount(party), 0x0002);
            L00B5: if (JumpNotEqual) goto L00DE;
            L00B7: AddEncounter(party, 0x01, 0x21);
            L00C9: AddEncounter(party, 0x02, 0x22);
            L00DB: goto L016B;
            L00DE: Compare(PartyCount(party), 0x0003);
            L00E9: if (JumpNotEqual) goto L0123;
            L00EB: AddEncounter(party, 0x01, 0x21);
            L00FD: AddEncounter(party, 0x02, 0x22);
            L010F: AddEncounter(party, 0x03, 0x23);
            L0121: goto L016B;
            L0123: AddEncounter(party, 0x01, 0x23);
            L0135: AddEncounter(party, 0x02, 0x24);
            L0147: AddEncounter(party, 0x03, 0x25);
            L0159: AddEncounter(party, 0x04, 0x21);
            L016B: return; // RETURN;
        }

        private void FnWEAPENC_0E(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0x18);
            L0011: if (JumpEqual) goto L0065;
            L0013: ax = HasItem(party, 0x30);
            L0021: if (JumpEqual) goto L0044;
            L0023: AddTreasure(party, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L0042: goto L0063;
            L0044: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0x30);
            L0063: goto L00B6;
            L0065: ax = HasItem(party, 0x30);
            L0073: if (JumpEqual) goto L0096;
            L0075: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0x18);
            L0094: goto L00B6;
            L0096: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x30, 0x18);
            L00B6: ShowMessage(party, String056D); // Huge beings lumber into sight.
            L00C3: Compare(PartyCount(party), 0x0001);
            L00CE: if (JumpNotEqual) goto L00F7;
            L00D0: AddEncounter(party, 0x01, 0x1A);
            L00E2: AddEncounter(party, 0x02, 0x19);
            L00F4: goto L0236;
            L00F7: Compare(PartyCount(party), 0x0002);
            L0102: if (JumpNotEqual) goto L014F;
            L0104: AddEncounter(party, 0x01, 0x1A);
            L0116: AddEncounter(party, 0x02, 0x1A);
            L0128: AddEncounter(party, 0x03, 0x19);
            L013A: AddEncounter(party, 0x04, 0x19);
            L014C: goto L0236;
            L014F: Compare(PartyCount(party), 0x0003);
            L015A: if (JumpNotEqual) goto L01CA;
            L015C: AddEncounter(party, 0x01, 0x19);
            L016E: AddEncounter(party, 0x02, 0x19);
            L0180: AddEncounter(party, 0x03, 0x1B);
            L0192: AddEncounter(party, 0x04, 0x1B);
            L01A4: AddEncounter(party, 0x05, 0x1A);
            L01B6: AddEncounter(party, 0x06, 0x1A);
            L01C8: goto L0236;
            L01CA: AddEncounter(party, 0x01, 0x1B);
            L01DC: AddEncounter(party, 0x02, 0x1B);
            L01EE: AddEncounter(party, 0x03, 0x1B);
            L0200: AddEncounter(party, 0x04, 0x1B);
            L0212: AddEncounter(party, 0x05, 0x1C);
            L0224: AddEncounter(party, 0x06, 0x1C);
            L0236: return; // RETURN;
        }

        private void FnARMORENC_0F(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0x7F);
            L0011: if (JumpEqual) goto L0034;
            L0013: AddTreasure(party, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xD1);
            L0032: goto L0053;
            L0034: AddTreasure(party, 0x0064, 0x00, 0x00, 0x00, 0x00, 0x7F);
            L0053: ShowMessage(party, String058C); // You have entered a Rogue encampment.
            L0060: Compare(PartyCount(party), 0x0001);
            L006B: if (JumpNotEqual) goto L0082;
            L006D: AddEncounter(party, 0x01, 0x03);
            L007F: goto L0143;
            L0082: Compare(PartyCount(party), 0x0002);
            L008D: if (JumpNotEqual) goto L00B6;
            L008F: AddEncounter(party, 0x01, 0x03);
            L00A1: AddEncounter(party, 0x02, 0x0D);
            L00B3: goto L0143;
            L00B6: Compare(PartyCount(party), 0x0003);
            L00C1: if (JumpNotEqual) goto L00FB;
            L00C3: AddEncounter(party, 0x01, 0x1E);
            L00D5: AddEncounter(party, 0x02, 0x11);
            L00E7: AddEncounter(party, 0x03, 0x04);
            L00F9: goto L0143;
            L00FB: AddEncounter(party, 0x01, 0x20);
            L010D: AddEncounter(party, 0x02, 0x05);
            L011F: AddEncounter(party, 0x03, 0x0F);
            L0131: AddEncounter(party, 0x06, 0x0D);
            L0143: return; // RETURN;
        }

        private void FnMAGICENC_10(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0x8B);
            L0011: if (JumpEqual) goto L0065;
            L0013: ax = HasItem(party, 0x91);
            L0021: if (JumpEqual) goto L0044;
            L0023: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x01);
            L0042: goto L0063;
            L0044: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x91);
            L0063: goto L00B6;
            L0065: ax = HasItem(party, 0x91);
            L0073: if (JumpEqual) goto L0096;
            L0075: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x8B);
            L0094: goto L00B6;
            L0096: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x91, 0x8B);
            L00B6: ShowMessage(party, String05B1); // You encounter marauding Hobgoblins.
            L00C3: Compare(PartyCount(party), 0x0001);
            L00CE: if (JumpNotEqual) goto L00F7;
            L00D0: AddEncounter(party, 0x01, 0x25);
            L00E2: AddEncounter(party, 0x02, 0x28);
            L00F4: goto L0212;
            L00F7: Compare(PartyCount(party), 0x0002);
            L0102: if (JumpNotEqual) goto L013D;
            L0104: AddEncounter(party, 0x01, 0x25);
            L0116: AddEncounter(party, 0x02, 0x26);
            L0128: AddEncounter(party, 0x03, 0x28);
            L013A: goto L0212;
            L013D: Compare(PartyCount(party), 0x0003);
            L0148: if (JumpNotEqual) goto L01A6;
            L014A: AddEncounter(party, 0x01, 0x26);
            L015C: AddEncounter(party, 0x02, 0x26);
            L016E: AddEncounter(party, 0x03, 0x27);
            L0180: AddEncounter(party, 0x04, 0x27);
            L0192: AddEncounter(party, 0x05, 0x28);
            L01A4: goto L0212;
            L01A6: AddEncounter(party, 0x01, 0x27);
            L01B8: AddEncounter(party, 0x02, 0x27);
            L01CA: AddEncounter(party, 0x03, 0x25);
            L01DC: AddEncounter(party, 0x04, 0x25);
            L01EE: AddEncounter(party, 0x05, 0x28);
            L0200: AddEncounter(party, 0x06, 0x28);
            L0212: return; // RETURN;
        }

        private void FnITEMBENC_11(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0x52);
            L0011: if (JumpEqual) goto L0034;
            L0013: AddTreasure(party, 0x0320, 0x00, 0x00, 0x00, 0x00, 0x13);
            L0032: goto L0053;
            L0034: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0x52);
            L0053: ShowMessage(party, String05D5); // The sound of hooves on stone alerts you to danger.
            L0060: Compare(PartyCount(party), 0x0001);
            L006B: if (JumpNotEqual) goto L0082;
            L006D: AddEncounter(party, 0x01, 0x22);
            L007F: goto L0143;
            L0082: Compare(PartyCount(party), 0x0002);
            L008D: if (JumpNotEqual) goto L00B6;
            L008F: AddEncounter(party, 0x01, 0x22);
            L00A1: AddEncounter(party, 0x02, 0x22);
            L00B3: goto L0143;
            L00B6: Compare(PartyCount(party), 0x0003);
            L00C1: if (JumpNotEqual) goto L00FB;
            L00C3: AddEncounter(party, 0x01, 0x23);
            L00D5: AddEncounter(party, 0x02, 0x23);
            L00E7: AddEncounter(party, 0x03, 0x23);
            L00F9: goto L0143;
            L00FB: AddEncounter(party, 0x01, 0x24);
            L010D: AddEncounter(party, 0x02, 0x24);
            L011F: AddEncounter(party, 0x03, 0x24);
            L0131: AddEncounter(party, 0x04, 0x24);
            L0143: return; // RETURN;
        }

        private void FnITEMCENC_12(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0x20);
            L0011: if (JumpEqual) goto L0065;
            L0013: ax = HasItem(party, 0x95);
            L0021: if (JumpEqual) goto L0044;
            L0023: AddTreasure(party, 0x05DC, 0x00, 0x00, 0x00, 0x00, 0x3F);
            L0042: goto L0063;
            L0044: AddTreasure(party, 0x05DC, 0x00, 0x00, 0x00, 0x00, 0x95);
            L0063: goto L00B6;
            L0065: ax = HasItem(party, 0x95);
            L0073: if (JumpEqual) goto L0096;
            L0075: AddTreasure(party, 0x05DC, 0x00, 0x00, 0x00, 0x00, 0x20);
            L0094: goto L00B6;
            L0096: AddTreasure(party, 0x05DC, 0x00, 0x00, 0x00, 0x95, 0x20);
            L00B6: ShowMessage(party, String0608); // Gruff laughter surrounds you.
            L00C3: Compare(PartyCount(party), 0x0001);
            L00CE: if (JumpNotEqual) goto L00F7;
            L00D0: AddEncounter(party, 0x01, 0x20);
            L00E2: AddEncounter(party, 0x02, 0x17);
            L00F4: goto L01EE;
            L00F7: Compare(PartyCount(party), 0x0002);
            L0102: if (JumpNotEqual) goto L013D;
            L0104: AddEncounter(party, 0x01, 0x11);
            L0116: AddEncounter(party, 0x02, 0x0C);
            L0128: AddEncounter(party, 0x03, 0x0E);
            L013A: goto L01EE;
            L013D: Compare(PartyCount(party), 0x0003);
            L0148: if (JumpNotEqual) goto L0194;
            L014A: AddEncounter(party, 0x01, 0x1F);
            L015C: AddEncounter(party, 0x02, 0x0D);
            L016E: AddEncounter(party, 0x03, 0x0B);
            L0180: AddEncounter(party, 0x04, 0x04);
            L0192: goto L01EE;
            L0194: AddEncounter(party, 0x01, 0x1E);
            L01A6: AddEncounter(party, 0x02, 0x20);
            L01B8: AddEncounter(party, 0x03, 0x0B);
            L01CA: AddEncounter(party, 0x04, 0x0E);
            L01DC: AddEncounter(party, 0x05, 0x01);
            L01EE: return; // RETURN;
        }

        private void FnTELEPORT_13(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x01, 0x04, 0x54, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnSTRSMESS_14(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0626); // The stairs through the south gateway lead upwards.
            L0010: return; // RETURN;
        }

        private void FnSTRSMESS_15(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0659); // Through the west gateway are stairs leading upwards.
            L0010: return; // RETURN;
        }

        private void FnSTRSMESS_16(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String068E); // The stairs through the north gateway lead upwards.
            L0010: return; // RETURN;
        }

        private void FnSTRSMESS_17(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06C1); // The stairs past the north gateway lead up a level.
            L0010: return; // RETURN;
        }

        private void FnTELEMESS_18(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06F4); // There is a teleport in the east wall.
            L0010: return; // RETURN;
        }

        private void FnTELEMESS_19(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String071A); // There is a teleport in the west wall.
            L0010: return; // RETURN;
        }

        private void FnTELEPORT_1A(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x03, 0x03, 0xDD, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnTELEMESS_1B(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0740); // There is a teleport in the west wall.
            L0010: return; // RETURN;
        }

        private void FnNPCCHATA_1C(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0766); // You encounter a Gnome Thief.
            L0010: ShowPortrait(party, 0x0024);
            L001D: Compare(GetRandom(0x000F), 0x0001);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String0783); // There is more to this basement than first meets the eye. Someday I will learn the secret of what lies behind the thick, silent walls that line this corridor.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0821); // The Gnome Thief smiles enigmatically and ducks into the shadows.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATB_1D(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0862); // You encounter a Human Barbarian.
            L0010: ShowPortrait(party, 0x0016);
            L001D: Compare(GetRandom(0x000F), 0x000C);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String0883); // As much as I despise orcs, I sometimes find it useful to have them in my party. Indeed, you will frequently have to work with races and Guilds you would otherwise ignore, if you wish to solve the many mysteries of this dungeon.
            L003C: goto L0058;
            L003E: DamagePlayer(party, 0x000A);
            L004B: ShowMessage(party, String0967); // The Human Barbarian raps you with his club and trudges away.
            L0058: return; // RETURN;
        }

        private void FnNPCCHATC_1E(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String09A4); // You encounter an Orc Knight.
            L0010: ShowPortrait(party, 0x001A);
            L001D: Compare(GetRandom(0x000F), 0x0006);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String09C1); // A colleague told me he encountered a strange elfin race far down in the dungeon. He would not say much else, other than that he knew why cold-loving creatures were to be found inside a volcano.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0A83); // The Orc Knight bows graciously and walks away.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATD_1F(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0AB2); // You encounter an Elf Cleric.
            L0010: ShowPortrait(party, 0x0027);
            L001D: Compare(GetRandom(0x000F), 0x0007);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String0ACF); // I stumbled over a marble block not long ago. On it were the words - Arnakkian Slowfoot, Wizard to the King.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0B3B); // The Elf Cleric sighs mournfully and massages a stubbed toe.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATE_20(ServerPlayer party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0B77); // You encounter a Human Thief.
            L0010: ShowPortrait(party, 0x0022);
            L001D: Compare(GetRandom(0x000F), 0x0008);
            L002D: if (JumpAbove) goto L004B;
            L002F: ShowMessage(party, String0B94); // To the east of the Rune Room on level three can be found the Wizards' Challenge. It is quite a challenge, too.
            L003C: ShowMessage(party, String0C03); // I have found several short cuts in the Wizards' Challenge.
            L0049: goto L0058;
            L004B: ShowMessage(party, String0C3E); // The Human Thief points at something behind you. While your back is turned, she sneaks away.
            L0058: return; // RETURN;
        }

    }
}
