#pragma warning disable
using System.Collections.Generic;
using XPT.Games.Generic.Entities;
using XPT.Games.Generic.Maps;
using XPT.Games.Yserbius;
using XPT.Games.Yserbius.Entities;

namespace XPT.Games.Yserbius.Maps {
    class YserMap17 : YsMap {
        public override int MapIndex => 17;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 1;

        public YserMap17() {
            MapEvent01 = FnSTARSADN_01;
            MapEvent02 = FnSTRSMESA_02;
            MapEvent03 = FnTELPRTUP_03;
            MapEvent04 = FnTELEMESS_04;
            MapEvent05 = FnTELETAVR_05;
            MapEvent06 = FnTELPRTMS_06;
            MapEvent07 = FnSTAIRMSS_07;
            MapEvent08 = FnTAVERN_08;
            MapEvent09 = FnSPECIALD_09;
            MapEvent0A = FnMONENCA_0A;
            MapEvent0B = FnMONENCB_0B;
            MapEvent0C = FnMONENCC_0C;
            MapEvent0E = FnMONENCE_0E;
            MapEvent0F = FnMONENCF_0F;
            MapEvent10 = FnFLSPECA_10;
            MapEvent11 = FnFLSPECB_11;
            MapEvent12 = FnFLSPECC_12;
            MapEvent13 = FnFLSPECD_13;
            MapEvent14 = FnFLSPECE_14;
            MapEvent15 = FnFLSPECF_15;
            MapEvent16 = FnFLSPECG_16;
            MapEvent17 = FnFLSPECH_17;
            MapEvent18 = FnFLSPECI_18;
            MapEvent19 = FnFLSPECJ_19;
            MapEvent1A = FnFLSPECK_1A;
            MapEvent1B = FnFLSPECL_1B;
            MapEvent1D = FnFLSPECN_1D;
            MapEvent1E = FnHIDEDOOR_1E;
            MapEvent24 = FnHIDDORG_24;
            MapEvent25 = FnHIDDORH_25;
            MapEvent26 = FnHIDDORI_26;
            MapEvent27 = FnHIDDORJ_27;
            MapEvent28 = FnHIDDORK_28;
            MapEvent29 = FnHIDDORL_29;
            MapEvent2A = FnHIDDORM_2A;
            MapEvent2B = FnHIDDORN_2B;
            MapEvent2E = FnHIDDORQ_2E;
            MapEvent31 = FnHIDDORT_31;
            MapEvent32 = FnHIDDORU_32;
            MapEvent33 = FnHIDDORV_33;
            MapEvent35 = FnHIDDORX_35;
            MapEvent36 = FnHIDDORY_36;
            MapEvent37 = FnHIDDORZ_37;
            MapEvent38 = FnHIDDORAA_38;
            MapEvent39 = FnHIDDORBB_39;
            MapEvent3A = FnHIDDORCC_3A;
            MapEvent3D = FnHIDDORFF_3D;
            MapEvent40 = FnHIDDORII_40;
            MapEvent41 = FnEXITMSG_41;
            MapEvent42 = FnSTRTMSG_42;
            MapEvent43 = FnGOODYA_43;
        }
        
        // === Strings ================================================
        private const string String03FC = "Heroes of level 20 or more may go on.";
        private const string String0422 = "The gate to the North leads down a level.";
        private const string String044C = "The gate to the North leads upward.";
        private const string String0470 = "Heroes of level 20 or more may enter.";
        private const string String0496 = "The gate to the south leads downward.";
        private const string String04BC = "The stairs to the south lead to the Tavern";
        private const string String04E7 = "You have used up the supplies in the Infirmary.";
        private const string String0517 = "You have discovered the Thieves' Infirmary.  All your wounds have been cured!";
        private const string String0565 = "You surprise creatures eating lunch!";
        private const string String058A = "You stumble upon some rather nasty monsters.";
        private const string String05B7 = "A group of restless undead surprise you!";
        private const string String05E0 = "You are attacked by Mages of the Thieves' Guild out walking their pets!";
        private const string String0628 = "You stumble upon mean animals out foraging!";
        private const string String0654 = "You stumble upon foraging animals! They found something shiny!";
        private const string String0693 = "The storage room has been emptied by other adventurers.";
        private const string String06CB = "You found a storage room.  Most items are worthless, but in the refuse are a few treasures.";
        private const string String0727 = "Thieves have emptied this room.";
        private const string String0747 = "In a cabinet are some scrolls and potions, and 15,000 Gold Pieces in a sack.";
        private const string String0794 = "You find 1 gold piece in an empty safe.";
        private const string String07BC = "The safe contains several treasures and 25,000 gold pieces!";
        private const string String07F8 = "The room has been ransacked!";
        private const string String0815 = "Your familiarity with thieving helps you avoid a vicious trap!";
        private const string String0854 = "You find some items and 5000 pieces of gold.";
        private const string String0881 = "You find several items and 5000 pieces of gold.";
        private const string String08B1 = "Unfortunately, you overlook the cleverly hidden trap that protects the treasure.";
        private const string String0902 = "You found a sleeping thief who cannot be roused from deep slumber.";
        private const string String0945 = "A wise old thief bends your ear with stories of his exploits.  His story is very helpful.";
        private const string String099F = "The Club and Axe Training Center.  All who lack this skill gain enlightenment and training.";
        private const string String09FB = "Thieves provide you with training in Clubs and Axes!";
        private const string String0A30 = "You have already trained in this skill. The thieves cannot help you any further.";
        private const string String0A81 = "A wise old thief will teach you the Bard Skill!";
        private const string String0AB1 = "You are already pretty good at Barding, and he cannot help you further.";
        private const string String0AF9 = "The wise old thief has already taught you all he knows.";
        private const string String0B31 = "The Fencing Training Center.  All who lack this skill gain enlightenment and training.";
        private const string String0B88 = "Thieves provide you with training in the use of Swords!";
        private const string String0BC0 = "You have already trained in this skill. The thieves cannot help you any further.";
        private const string String0C11 = "A wise young thief will teach you the Detect Skill!";
        private const string String0C45 = "You are already pretty good at detection, and she cannot help you further.";
        private const string String0C90 = "The young thief has already taught you all she knows.";
        private const string String0CC6 = "The Staff Training Center.  All who lack this skill gain enlightenment and training.";
        private const string String0D1B = "Thieves provide you with training in the use of Staves!";
        private const string String0D53 = "You have already trained in this skill. The thieves cannot help you any further.";
        private const string String0DA4 = "A wise old thief will teach you the Lockpick Skill!";
        private const string String0DD8 = "You are already pretty good at picking locks, and he cannot help you further.";
        private const string String0E26 = "The old thief has already taught you all he knows.";
        private const string String0E59 = "The waters from Sinestra's Fountain are invigorating, but have no further effect.";
        private const string String0EAB = "You have discovered Sinestra's Fountain.  You feel healthier and more experienced after drinking the waters!";
        private const string String0F18 = "The Archery Training Center.  All who lack this skill gain enlightenment and training.";
        private const string String0F6F = "Thieves provide you with training in Archery!";
        private const string String0F9D = "You have already trained in this skill. The thieves cannot help you any further.";
        private const string String0FEE = "The Thieves' Key unlocks the door!";
        private const string String1011 = "The door is locked.  You need a special key.";
        private const string String103E = "The wall springs open.  A musky odor fills the room.";
        private const string String1073 = "Cracks in the wall reveal what could be a doorway. If only you could open it...";
        private const string String10C3 = "You skillfully open the entrance to a passage!";
        private const string String10F2 = "You found a very well-hidden entrance to what might be a passage.  Unfortunately, it seems to be locked.";
        private const string String115B = "You release the stonework, revealing a secret passage!";
        private const string String1192 = "A piece of stonework looks like it could be moved, if you can pick the mechanism.";
        private const string String11E4 = "The wall slides open.";
        private const string String11FA = "You located a sliding door which must be picked to be opened. Curious sounds can be heard through the stonework.";
        private const string String126B = "You successfully opened the locked door.";
        private const string String1294 = "You found a secret door, but it's locked.";
        private const string String12BE = "You successfully opened the locked door.";
        private const string String12E7 = "You found a secret door.";
        private const string String1300 = "You successfully opened the locked door.";
        private const string String1329 = "You spot a well hidden secret door. It's locked.";
        private const string String135A = "You skillfully pick the door lock.";
        private const string String137D = "The door is locked.";
        private const string String1391 = "You found a hidden door!";
        private const string String13AA = "You successfully opened the locked door.";
        private const string String13D3 = "You found a secret door, but it's locked.";
        private const string String13FD = "You successfully opened the locked door.";
        private const string String1426 = "You found a locked door. You hear strange noises on the other side of the door.";
        private const string String1476 = "You found a hidden door!";
        private const string String148F = "You successfully opened the locked door. You also feel a cool breeze.";
        private const string String14D5 = "You found a secret door, but it's locked.";
        private const string String14FF = "You opened the locked chamber door.";
        private const string String1523 = "You found a hidden chamber door, but it's locked.";
        private const string String1555 = "With great effort, you unlock the door.";
        private const string String157D = "This door has a nasty looking lock on it.";
        private const string String15A7 = "The door is opened with a lot of effort.";
        private const string String15D0 = "You found another secret door, but it is locked.";
        private const string String1601 = "Can't take any more?  The door is marked 'Exit!'";
        private const string String1632 = "A message on the wall:  'Welcome to the Den of Thieves!'";
        private const string String166B = "You find an empty chest.";
        private const string String1684 = "You find a Purple Lockpick and 1250 gold inside a small chest.";
        
        // === Functions ================================================
        private void FnSTARSADN_01(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckLevel(player, 0x0014);
            L0011: if (JumpEqual) goto L002F;
            L0013: TeleportParty(player, 0x33, 0x01, 0x4D, 0x00, type);
            L002D: goto L0059;
            L002F: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L004C: ShowMessage(player, doMsgs, String03FC); // Heroes of level 20 or more may go on.
            L0059: return; // RETURN;
        }

        private void FnSTRSMESA_02(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(player);
            L000B: ShowMessage(player, doMsgs, String0422); // The gate to the North leads down a level.
            L0018: return; // RETURN;
        }

        private void FnTELPRTUP_03(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x04, 0x01, 0xD8, 0x02, type);
            L001E: return; // RETURN;
        }

        private void FnTELEMESS_04(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String044C); // The gate to the North leads upward.
            L0010: return; // RETURN;
        }

        private void FnTELETAVR_05(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckLevel(player, 0x0014);
            L0011: if (JumpEqual) goto L0030;
            L0013: TeleportParty(player, 0x33, 0x01, 0x4D, 0x02, type);
            L002E: goto L005A;
            L0030: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L004D: ShowMessage(player, doMsgs, String0470); // Heroes of level 20 or more may enter.
            L005A: return; // RETURN;
        }

        private void FnTELPRTMS_06(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(player);
            L000B: ShowMessage(player, doMsgs, String0496); // The gate to the south leads downward.
            L0018: return; // RETURN;
        }

        private void FnSTAIRMSS_07(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String04BC); // The stairs to the south lead to the Tavern
            L0010: return; // RETURN;
        }

        private void FnTAVERN_08(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ExitDungeon(player, true, type);
            L000B: return; // RETURN;
        }

        private void FnSPECIALD_09(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, FlagTypeDungeon, YsIndexes.FlagThievesDenTreasure3), 0x0005);
            L0017: if (JumpNotEqual) goto L0028;
            L0019: ShowMessage(player, doMsgs, String04E7); // You have used up the supplies in the Infirmary.
            L0026: goto L0066;
            L0028: SetFlag(player, FlagTypeDungeon, YsIndexes.FlagThievesDenTreasure3, 0x43);
            L003D: dx = GetMaxHits(player) - GetCurrentHits(player);
            L004F: HealPlayer(player, (ushort)dx);
            L0059: ShowMessage(player, doMsgs, String0517); // You have discovered the Thieves' Infirmary.  All your wounds have been cured!
            L0066: return; // RETURN;
        }

        private void FnMONENCA_0A(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0565); // You surprise creatures eating lunch!
            L0010: AddEncounter(player, 0x01, 0x19);
            L0022: AddEncounter(player, 0x02, 0x1A);
            L0034: AddEncounter(player, 0x03, 0x1D);
            L0046: return; // RETURN;
        }

        private void FnMONENCB_0B(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String058A); // You stumble upon some rather nasty monsters.
            L0010: AddTreasure(player, 0x1194, 0x00, 0x00, 0x00, 0xB2, 0xCD);
            L0030: AddEncounter(player, 0x01, 0x1E);
            L0042: AddEncounter(player, 0x02, 0x22);
            L0054: AddEncounter(player, 0x03, 0x1B);
            L0066: AddEncounter(player, 0x04, 0x25);
            L0078: return; // RETURN;
        }

        private void FnMONENCC_0C(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String05B7); // A group of restless undead surprise you!
            L0010: Compare(PartyCount(player), 0x0001);
            L001B: if (JumpEqual) goto L002A;
            L001D: Compare(PartyCount(player), 0x0002);
            L0028: if (JumpNotEqual) goto L0062;
            L002A: AddEncounter(player, 0x01, 0x1C);
            L003C: AddEncounter(player, 0x02, 0x1F);
            L004E: AddEncounter(player, 0x03, 0x1D);
            L0060: goto L00BC;
            L0062: AddEncounter(player, 0x01, 0x1C);
            L0074: AddEncounter(player, 0x02, 0x1C);
            L0086: AddEncounter(player, 0x03, 0x1D);
            L0098: AddEncounter(player, 0x04, 0x1D);
            L00AA: AddEncounter(player, 0x05, 0x1F);
            L00BC: return; // RETURN;
        }

        private void FnMONENCE_0E(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xBE);
            L0011: if (JumpEqual) goto L0035;
            L0013: AddTreasure(player, 0x06D6, 0x00, 0x00, 0x00, 0xBB, 0xC6);
            L0033: goto L0055;
            L0035: AddTreasure(player, 0x0BB8, 0x00, 0x00, 0x00, 0xBB, 0xBE);
            L0055: ShowMessage(player, doMsgs, String05E0); // You are attacked by Mages of the Thieves' Guild out walking their pets!
            L0062: AddEncounter(player, 0x01, 0x25);
            L0074: AddEncounter(player, 0x05, 0x26);
            L0086: AddEncounter(player, 0x06, 0x27);
            L0098: return; // RETURN;
        }

        private void FnMONENCF_0F(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x68);
            L0011: if (JumpEqual) goto L0041;
            L0013: AddTreasure(player, 0x01F4, 0x00, 0x00, 0x00, 0x00, 0xB6);
            L0032: ShowMessage(player, doMsgs, String0628); // You stumble upon mean animals out foraging!
            L003F: goto L006D;
            L0041: AddTreasure(player, 0x2EE0, 0x00, 0x00, 0x00, 0x00, 0x68);
            L0060: ShowMessage(player, doMsgs, String0654); // You stumble upon foraging animals! They found something shiny!
            L006D: AddEncounter(player, 0x01, 0x19);
            L007F: AddEncounter(player, 0x02, 0x20);
            L0091: AddEncounter(player, 0x05, 0x21);
            L00A3: return; // RETURN;
        }

        private void FnFLSPECA_10(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, FlagTypeDungeon, YsIndexes.FlagThievesDenTreasure2), 0x0001);
            L0017: if (JumpNotEqual) goto L0028;
            L0019: ShowMessage(player, doMsgs, String0693); // The storage room has been emptied by other adventurers.
            L0026: goto L007F;
            L0028: GiveItem(player, 0x59);
            L0034: GiveItem(player, 0x48);
            L0040: GiveItem(player, 0xBD);
            L004C: ModifyGold(player, 0x2710);
            L005D: SetFlag(player, FlagTypeDungeon, YsIndexes.FlagThievesDenTreasure2, 0x01);
            L0072: ShowMessage(player, doMsgs, String06CB); // You found a storage room.  Most items are worthless, but in the refuse are a few treasures.
            L007F: return; // RETURN;
        }

        private void FnFLSPECB_11(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, FlagTypeDungeon, YsIndexes.FlagThievesDenTreasure), 0x0001);
            L0017: if (JumpNotEqual) goto L0028;
            L0019: ShowMessage(player, doMsgs, String0727); // Thieves have emptied this room.
            L0026: goto L0097;
            L0028: GiveItem(player, 0xB0);
            L0034: GiveItem(player, 0xB0);
            L0040: GiveItem(player, 0xB4);
            L004C: GiveItem(player, 0xCD);
            L0058: GiveItem(player, 0xD0);
            L0064: ModifyGold(player, 0x3A98);
            L0075: SetFlag(player, FlagTypeDungeon, YsIndexes.FlagThievesDenTreasure, 0x01);
            L008A: ShowMessage(player, doMsgs, String0747); // In a cabinet are some scrolls and potions, and 15,000 Gold Pieces in a sack.
            L0097: return; // RETURN;
        }

        private void FnFLSPECC_12(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, FlagTypeDungeon, YsIndexes.FlagThievesDenTreasure4), 0x0001);
            L0017: if (JumpNotEqual) goto L0039;
            L0019: ModifyGold(player, 0x0001);
            L002A: ShowMessage(player, doMsgs, String0794); // You find 1 gold piece in an empty safe.
            L0037: goto L0090;
            L0039: GiveItem(player, 0x7F);
            L0045: GiveItem(player, 0xB1);
            L0051: GiveItem(player, 0x6B);
            L005D: ModifyGold(player, 0x61A8);
            L006E: SetFlag(player, FlagTypeDungeon, YsIndexes.FlagThievesDenTreasure4, 0x01);
            L0083: ShowMessage(player, doMsgs, String07BC); // The safe contains several treasures and 25,000 gold pieces!
            L0090: return; // RETURN;
        }

        private void FnFLSPECD_13(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, YsIndexes.ItemThievesKey);
            L0011: if (JumpEqual) goto L0023;
            L0013: ShowMessage(player, doMsgs, String07F8); // The room has been ransacked!
            L0020: goto L0150;
            L0023: Compare(GetClass(player), 0x0003);
            L002D: if (JumpEqual) goto L0032;
            L002F: goto L00B1;
            L0032: SetFlag(player, FlagTypeDungeon, YsIndexes.FlagThievesDenTreasure1, 0x01);
            L0047: ShowMessage(player, doMsgs, String0815); // Your familiarity with thieving helps you avoid a vicious trap!
            L0054: ShowMessage(player, doMsgs, String0854); // You find some items and 5000 pieces of gold.
            L0061: GiveItem(player, YsIndexes.ItemThievesKey);
            L006D: GiveItem(player, 0x33);
            L0079: GiveItem(player, 0x4C);
            L0085: GiveItem(player, 0xC9);
            L0091: GiveItem(player, 0xB7);
            L009D: ModifyGold(player, 0x1388);
            L00AE: goto L0150;
            L00B1: ShowMessage(player, doMsgs, String0881); // You find several items and 5000 pieces of gold.
            L00BE: ShowMessage(player, doMsgs, String08B1); // Unfortunately, you overlook the cleverly hidden trap that protects the treasure.
            L00CB: GiveItem(player, YsIndexes.ItemThievesKey);
            L00D7: GiveItem(player, 0x33);
            L00E3: GiveItem(player, 0x4C);
            L00EF: GiveItem(player, 0xC9);
            L00FB: GiveItem(player, 0xB7);
            L0107: ModifyGold(player, 0x1388);
            L0118: SetTileState(player, 01);
            L0124: ax = GetCurrentHits(player);
            L012B: bx = 0x0002;
            L012E: dx = ax % bx; ax = ax / bx;
            L0131: DamagePlayer(player, ax);
            L013B: SetFlag(player, FlagTypeDungeon, YsIndexes.FlagThievesDenTreasure1, 0x01);
            L0150: return; // RETURN;
        }

        private void FnFLSPECE_14(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, FlagTypeDungeon, YsIndexes.FlagThievesDenExperience), 0x0001);
            L0017: if (JumpNotEqual) goto L0028;
            L0019: ShowMessage(player, doMsgs, String0902); // You found a sleeping thief who cannot be roused from deep slumber.
            L0026: goto L005B;
            L0028: AddExperience(player, 0x00003A98);
            L0039: SetFlag(player, FlagTypeDungeon, YsIndexes.FlagThievesDenExperience, 0x01);
            L004E: ShowMessage(player, doMsgs, String0945); // A wise old thief bends your ear with stories of his exploits.  His story is very helpful.
            L005B: return; // RETURN;
        }

        private void FnFLSPECF_15(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0022);
            L0010: ShowMessage(player, doMsgs, String099F); // The Club and Axe Training Center.  All who lack this skill gain enlightenment and training.
            L001D: RefreshCompareFlags(GetSkillLevel(player, 0x01));
            L002B: if (JumpNotEqual) goto L004D;
            L002D: SetSkillLevel(player, 0x01, 0x02);
            L003E: ShowMessage(player, doMsgs, String09FB); // Thieves provide you with training in Clubs and Axes!
            L004B: goto L005A;
            L004D: ShowMessage(player, doMsgs, String0A30); // You have already trained in this skill. The thieves cannot help you any further.
            L005A: return; // RETURN;
        }

        private void FnFLSPECG_16(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOff(player, FlagTypeDungeon, YsIndexes.FlagThievesDenTeachBarding);
            L0016: if (JumpEqual) goto L007A;
            L0018: ShowPortrait(player, 0x0023);
            L0025: ShowMessage(player, doMsgs, String0A81); // A wise old thief will teach you the Bard Skill!
            L0032: SetFlag(player, FlagTypeDungeon, YsIndexes.FlagThievesDenTeachBarding, 0x01);
            L0047: Compare(GetSkillLevel(player, 0x0C), 0x000C);
            L0056: if (JumpAbove) goto L006B;
            L0058: SetSkillLevel(player, 0x0C, 0x02);
            L0069: goto L0078;
            L006B: ShowMessage(player, doMsgs, String0AB1); // You are already pretty good at Barding, and he cannot help you further.
            L0078: goto L0094;
            L007A: ShowPortrait(player, 0x0023);
            L0087: ShowMessage(player, doMsgs, String0AF9); // The wise old thief has already taught you all he knows.
            L0094: return; // RETURN;
        }

        private void FnFLSPECH_17(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0026);
            L0010: ShowMessage(player, doMsgs, String0B31); // The Fencing Training Center.  All who lack this skill gain enlightenment and training.
            L001D: RefreshCompareFlags(GetSkillLevel(player, 0x05));
            L002B: if (JumpNotEqual) goto L004D;
            L002D: SetSkillLevel(player, 0x05, 0x02);
            L003E: ShowMessage(player, doMsgs, String0B88); // Thieves provide you with training in the use of Swords!
            L004B: goto L005A;
            L004D: ShowMessage(player, doMsgs, String0BC0); // You have already trained in this skill. The thieves cannot help you any further.
            L005A: return; // RETURN;
        }

        private void FnFLSPECI_18(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOff(player, FlagTypeDungeon, YsIndexes.FlagThievesDenTeachDetect);
            L0016: if (JumpEqual) goto L007A;
            L0018: ShowPortrait(player, 0x0024);
            L0025: ShowMessage(player, doMsgs, String0C11); // A wise young thief will teach you the Detect Skill!
            L0032: SetFlag(player, FlagTypeDungeon, YsIndexes.FlagThievesDenTeachDetect, 0x01);
            L0047: Compare(GetSkillLevel(player, 0x0D), 0x000C);
            L0056: if (JumpAbove) goto L006B;
            L0058: SetSkillLevel(player, 0x0D, 0x02);
            L0069: goto L0078;
            L006B: ShowMessage(player, doMsgs, String0C45); // You are already pretty good at detection, and she cannot help you further.
            L0078: goto L0094;
            L007A: ShowPortrait(player, 0x0024);
            L0087: ShowMessage(player, doMsgs, String0C90); // The young thief has already taught you all she knows.
            L0094: return; // RETURN;
        }

        private void FnFLSPECJ_19(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0CC6); // The Staff Training Center.  All who lack this skill gain enlightenment and training.
            L0010: RefreshCompareFlags(GetSkillLevel(player, 0x15));
            L001E: if (JumpNotEqual) goto L004D;
            L0020: SetSkillLevel(player, 0x15, 0x02);
            L0031: ShowPortrait(player, 0x0023);
            L003E: ShowMessage(player, doMsgs, String0D1B); // Thieves provide you with training in the use of Staves!
            L004B: goto L0067;
            L004D: ShowPortrait(player, 0x0023);
            L005A: ShowMessage(player, doMsgs, String0D53); // You have already trained in this skill. The thieves cannot help you any further.
            L0067: return; // RETURN;
        }

        private void FnFLSPECK_1A(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOff(player, FlagTypeDungeon, YsIndexes.FlagThievesDenTeachLockpick);
            L0016: if (JumpEqual) goto L007A;
            L0018: ShowPortrait(player, 0x0025);
            L0025: ShowMessage(player, doMsgs, String0DA4); // A wise old thief will teach you the Lockpick Skill!
            L0032: SetFlag(player, FlagTypeDungeon, YsIndexes.FlagThievesDenTeachLockpick, 0x01);
            L0047: Compare(GetSkillLevel(player, 0x0E), 0x000C);
            L0056: if (JumpAbove) goto L006B;
            L0058: SetSkillLevel(player, 0x0E, 0x02);
            L0069: goto L0078;
            L006B: ShowMessage(player, doMsgs, String0DD8); // You are already pretty good at picking locks, and he cannot help you further.
            L0078: goto L0094;
            L007A: ShowPortrait(player, 0x0025);
            L0087: ShowMessage(player, doMsgs, String0E26); // The old thief has already taught you all he knows.
            L0094: return; // RETURN;
        }

        private void FnFLSPECL_1B(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOn(player, FlagTypeDungeon, YsIndexes.FlagThievesDenSinestraFountain);
            L0016: if (JumpEqual) goto L0034;
            L0018: ShowPortrait(player, 0x0042);
            L0025: ShowMessage(player, doMsgs, String0E59); // The waters from Sinestra's Fountain are invigorating, but have no further effect.
            L0032: goto L0090;
            L0034: SetFlag(player, FlagTypeDungeon, YsIndexes.FlagThievesDenSinestraFountain, 0x01);
            L0049: ShowPortrait(player, 0x0042);
            L0056: dx = GetMaxHits(player) - GetCurrentHits(player);
            L0068: HealPlayer(player, (ushort)dx);
            L0072: AddExperience(player, 0x00003A98);
            L0083: ShowMessage(player, doMsgs, String0EAB); // You have discovered Sinestra's Fountain.  You feel healthier and more experienced after drinking the waters!
            L0090: return; // RETURN;
        }

        private void FnFLSPECN_1D(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0026);
            L0010: ShowMessage(player, doMsgs, String0F18); // The Archery Training Center.  All who lack this skill gain enlightenment and training.
            L001D: RefreshCompareFlags(GetSkillLevel(player, 0x08));
            L002B: if (JumpNotEqual) goto L004D;
            L002D: SetSkillLevel(player, 0x08, 0x02);
            L003E: ShowMessage(player, doMsgs, String0F6F); // Thieves provide you with training in Archery!
            L004B: goto L005A;
            L004D: ShowMessage(player, doMsgs, String0F9D); // You have already trained in this skill. The thieves cannot help you any further.
            L005A: return; // RETURN;
        }

        private void FnHIDEDOOR_1E(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0021: return; // RETURN;
        }

        private void FnHIDDORG_24(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, type, ref doMsgs, YsIndexes.ItemThievesKey, YsIndexes.ItemThievesKey);
            L0016: if (JumpEqual) goto L0063;
            L0018: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0036: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0054: ShowMessage(player, doMsgs, String0FEE); // The Thieves' Key unlocks the door!
            L0061: goto L008D;
            L0063: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0080: ShowMessage(player, doMsgs, String1011); // The door is locked.  You need a special key.
            L008D: return; // RETURN;
        }

        private void FnHIDDORH_25(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, type, ref doMsgs, 0xC2, 0xC4);
            L0016: if (JumpNotEqual) goto L0029;
            L0018: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0E), 0x000A);
            L0027: if (JumpBelow) goto L0074;
            L0029: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0047: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0065: ShowMessage(player, doMsgs, String103E); // The wall springs open.  A musky odor fills the room.
            L0072: goto L009E;
            L0074: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0091: ShowMessage(player, doMsgs, String1073); // Cracks in the wall reveal what could be a doorway. If only you could open it...
            L009E: return; // RETURN;
        }

        private void FnHIDDORI_26(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x000C);
            L0012: if (JumpNotBelow) goto L007A;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L007A;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L007A;
            L0039: ax = HasUsedItem(player, type, ref doMsgs, 0xBD, 0xBD);
            L004C: if (JumpNotEqual) goto L007A;
            L004E: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L0061: if (JumpNotEqual) goto L007A;
            L0063: ax = IsFlagOn(player, FlagTypeTile, 0x01);
            L0075: if (JumpNotEqual) goto L007A;
            L0077: goto L0149;
            L007A: SetFlag(player, FlagTypeTile, 0x01, 0x01);
            L008E: ax = HasUsedItem(player, type, ref doMsgs, 0xC3, 0xC4);
            L00A1: if (JumpNotEqual) goto L00B4;
            L00A3: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0E), 0x000C);
            L00B2: if (JumpBelow) goto L00FF;
            L00B4: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00D2: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00F0: ShowMessage(player, doMsgs, String10C3); // You skillfully open the entrance to a passage!
            L00FD: goto L0147;
            L00FF: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L011C: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L013A: ShowMessage(player, doMsgs, String10F2); // You found a very well-hidden entrance to what might be a passage.  Unfortunately, it seems to be locked.
            L0147: goto L0166;
            L0149: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0166: return; // RETURN;
        }

        private void FnHIDDORJ_27(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L007A;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L007A;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L007A;
            L0039: ax = HasUsedItem(player, type, ref doMsgs, 0xBD, 0xBD);
            L004C: if (JumpNotEqual) goto L007A;
            L004E: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L0061: if (JumpNotEqual) goto L007A;
            L0063: ax = IsFlagOn(player, FlagTypeTile, 0x01);
            L0075: if (JumpNotEqual) goto L007A;
            L0077: goto L0149;
            L007A: SetFlag(player, FlagTypeTile, 0x01, 0x01);
            L008E: ax = HasUsedItem(player, type, ref doMsgs, 0xC3, 0xC4);
            L00A1: if (JumpNotEqual) goto L00B4;
            L00A3: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0E), 0x000A);
            L00B2: if (JumpBelow) goto L00FF;
            L00B4: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00D2: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00F0: ShowMessage(player, doMsgs, String115B); // You release the stonework, revealing a secret passage!
            L00FD: goto L0147;
            L00FF: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L011C: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L013A: ShowMessage(player, doMsgs, String1192); // A piece of stonework looks like it could be moved, if you can pick the mechanism.
            L0147: goto L0166;
            L0149: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0166: return; // RETURN;
        }

        private void FnHIDDORK_28(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x0009);
            L0012: if (JumpNotBelow) goto L007A;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L007A;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L007A;
            L0039: ax = HasUsedItem(player, type, ref doMsgs, 0xBD, 0xBD);
            L004C: if (JumpNotEqual) goto L007A;
            L004E: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L0061: if (JumpNotEqual) goto L007A;
            L0063: ax = IsFlagOn(player, FlagTypeTile, 0x01);
            L0075: if (JumpNotEqual) goto L007A;
            L0077: goto L0149;
            L007A: SetFlag(player, FlagTypeTile, 0x01, 0x01);
            L008E: ax = HasUsedItem(player, type, ref doMsgs, 0xC3, 0xC4);
            L00A1: if (JumpNotEqual) goto L00B4;
            L00A3: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0E), 0x0009);
            L00B2: if (JumpBelow) goto L00FF;
            L00B4: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00D2: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00F0: ShowMessage(player, doMsgs, String11E4); // The wall slides open.
            L00FD: goto L0147;
            L00FF: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L011C: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L013A: ShowMessage(player, doMsgs, String11FA); // You located a sliding door which must be picked to be opened. Curious sounds can be heard through the stonework.
            L0147: goto L0166;
            L0149: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0166: return; // RETURN;
        }

        private void FnHIDDORL_29(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x0008);
            L0012: if (JumpNotBelow) goto L007A;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L007A;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L007A;
            L0039: ax = HasUsedItem(player, type, ref doMsgs, 0xBD, 0xBD);
            L004C: if (JumpNotEqual) goto L007A;
            L004E: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L0061: if (JumpNotEqual) goto L007A;
            L0063: ax = IsFlagOn(player, FlagTypeTile, 0x01);
            L0075: if (JumpNotEqual) goto L007A;
            L0077: goto L0149;
            L007A: SetFlag(player, FlagTypeTile, 0x01, 0x01);
            L008E: ax = HasUsedItem(player, type, ref doMsgs, 0xC2, 0xC4);
            L00A1: if (JumpNotEqual) goto L00B4;
            L00A3: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0E), 0x0008);
            L00B2: if (JumpBelow) goto L00FF;
            L00B4: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00D2: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00F0: ShowMessage(player, doMsgs, String126B); // You successfully opened the locked door.
            L00FD: goto L0147;
            L00FF: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L011C: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L013A: ShowMessage(player, doMsgs, String1294); // You found a secret door, but it's locked.
            L0147: goto L0166;
            L0149: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0166: return; // RETURN;
        }

        private void FnHIDDORM_2A(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x000C);
            L0012: if (JumpNotBelow) goto L007A;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L007A;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L007A;
            L0039: ax = HasUsedItem(player, type, ref doMsgs, 0xBD, 0xBD);
            L004C: if (JumpNotEqual) goto L007A;
            L004E: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L0061: if (JumpNotEqual) goto L007A;
            L0063: ax = IsFlagOn(player, FlagTypeTile, 0x01);
            L0075: if (JumpNotEqual) goto L007A;
            L0077: goto L0149;
            L007A: SetFlag(player, FlagTypeTile, 0x01, 0x01);
            L008E: ax = HasUsedItem(player, type, ref doMsgs, 0xC4, 0xC4);
            L00A1: if (JumpNotEqual) goto L00B4;
            L00A3: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0E), 0x000C);
            L00B2: if (JumpBelow) goto L00FF;
            L00B4: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00D2: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00F0: ShowMessage(player, doMsgs, String12BE); // You successfully opened the locked door.
            L00FD: goto L0147;
            L00FF: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L011C: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L013A: ShowMessage(player, doMsgs, String12E7); // You found a secret door.
            L0147: goto L0166;
            L0149: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0166: return; // RETURN;
        }

        private void FnHIDDORN_2B(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x000C);
            L0012: if (JumpNotBelow) goto L007A;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L007A;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L007A;
            L0039: ax = HasUsedItem(player, type, ref doMsgs, 0xBD, 0xBD);
            L004C: if (JumpNotEqual) goto L007A;
            L004E: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L0061: if (JumpNotEqual) goto L007A;
            L0063: ax = IsFlagOn(player, FlagTypeTile, 0x01);
            L0075: if (JumpNotEqual) goto L007A;
            L0077: goto L0149;
            L007A: SetFlag(player, FlagTypeTile, 0x01, 0x01);
            L008E: ax = HasUsedItem(player, type, ref doMsgs, 0xC4, 0xC4);
            L00A1: if (JumpNotEqual) goto L00B4;
            L00A3: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0E), 0x000C);
            L00B2: if (JumpBelow) goto L00FF;
            L00B4: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00D2: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00F0: ShowMessage(player, doMsgs, String1300); // You successfully opened the locked door.
            L00FD: goto L0147;
            L00FF: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L011C: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L013A: ShowMessage(player, doMsgs, String1329); // You spot a well hidden secret door. It's locked.
            L0147: goto L0166;
            L0149: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0166: return; // RETURN;
        }

        private void FnHIDDORQ_2E(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, type, ref doMsgs, 0xC2, 0xC4);
            L0016: if (JumpNotEqual) goto L0029;
            L0018: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0E), 0x0008);
            L0027: if (JumpBelow) goto L0074;
            L0029: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0047: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0065: ShowMessage(player, doMsgs, String135A); // You skillfully pick the door lock.
            L0072: goto L009E;
            L0074: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0091: ShowMessage(player, doMsgs, String137D); // The door is locked.
            L009E: return; // RETURN;
        }

        private void FnHIDDORT_31(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x0006);
            L0012: if (JumpNotBelow) goto L0024;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpEqual) goto L0051;
            L0024: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0042: ShowMessage(player, doMsgs, String1391); // You found a hidden door!
            L004F: goto L006E;
            L0051: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L006E: return; // RETURN;
        }

        private void FnHIDDORU_32(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x0008);
            L0012: if (JumpNotBelow) goto L007A;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L007A;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L007A;
            L0039: ax = HasUsedItem(player, type, ref doMsgs, 0xBD, 0xBD);
            L004C: if (JumpNotEqual) goto L007A;
            L004E: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L0061: if (JumpNotEqual) goto L007A;
            L0063: ax = IsFlagOn(player, FlagTypeTile, 0x01);
            L0075: if (JumpNotEqual) goto L007A;
            L0077: goto L0149;
            L007A: SetFlag(player, FlagTypeTile, 0x01, 0x01);
            L008E: ax = HasUsedItem(player, type, ref doMsgs, 0xC2, 0xC4);
            L00A1: if (JumpNotEqual) goto L00B4;
            L00A3: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0E), 0x0008);
            L00B2: if (JumpBelow) goto L00FF;
            L00B4: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00D2: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00F0: ShowMessage(player, doMsgs, String13AA); // You successfully opened the locked door.
            L00FD: goto L0147;
            L00FF: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L011C: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L013A: ShowMessage(player, doMsgs, String13D3); // You found a secret door, but it's locked.
            L0147: goto L0166;
            L0149: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0166: return; // RETURN;
        }

        private void FnHIDDORV_33(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0021: return; // RETURN;
        }

        private void FnHIDDORX_35(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0021: return; // RETURN;
        }

        private void FnHIDDORY_36(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L007A;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L007A;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L007A;
            L0039: ax = HasUsedItem(player, type, ref doMsgs, 0xBD, 0xBD);
            L004C: if (JumpNotEqual) goto L007A;
            L004E: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L0061: if (JumpNotEqual) goto L007A;
            L0063: ax = IsFlagOn(player, FlagTypeTile, 0x01);
            L0075: if (JumpNotEqual) goto L007A;
            L0077: goto L0149;
            L007A: SetFlag(player, FlagTypeTile, 0x01, 0x01);
            L008E: ax = HasUsedItem(player, type, ref doMsgs, 0xC3, 0xC4);
            L00A1: if (JumpNotEqual) goto L00B4;
            L00A3: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0E), 0x000A);
            L00B2: if (JumpBelow) goto L00FF;
            L00B4: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00D2: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00F0: ShowMessage(player, doMsgs, String13FD); // You successfully opened the locked door.
            L00FD: goto L0147;
            L00FF: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L011C: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L013A: ShowMessage(player, doMsgs, String1426); // You found a locked door. You hear strange noises on the other side of the door.
            L0147: goto L0166;
            L0149: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0166: return; // RETURN;
        }

        private void FnHIDDORZ_37(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x0008);
            L0012: if (JumpNotBelow) goto L0063;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L0063;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L0063;
            L0039: ax = HasUsedItem(player, type, ref doMsgs, 0xBD, 0xBD);
            L004C: if (JumpNotEqual) goto L0063;
            L004E: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L0061: if (JumpEqual) goto L008E;
            L0063: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0081: ShowMessage(player, doMsgs, String1476); // You found a hidden door!
            L008E: return; // RETURN;
        }

        private void FnHIDDORAA_38(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0021: return; // RETURN;
        }

        private void FnHIDDORBB_39(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x0009);
            L0012: if (JumpNotBelow) goto L007A;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L007A;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L007A;
            L0039: ax = HasUsedItem(player, type, ref doMsgs, 0xBD, 0xBD);
            L004C: if (JumpNotEqual) goto L007A;
            L004E: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L0061: if (JumpNotEqual) goto L007A;
            L0063: ax = IsFlagOn(player, FlagTypeTile, 0x01);
            L0075: if (JumpNotEqual) goto L007A;
            L0077: goto L0149;
            L007A: SetFlag(player, FlagTypeTile, 0x01, 0x01);
            L008E: ax = HasUsedItem(player, type, ref doMsgs, 0xC3, 0xC4);
            L00A1: if (JumpNotEqual) goto L00B4;
            L00A3: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0E), 0x0009);
            L00B2: if (JumpBelow) goto L00FF;
            L00B4: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00D2: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00F0: ShowMessage(player, doMsgs, String148F); // You successfully opened the locked door. You also feel a cool breeze.
            L00FD: goto L0147;
            L00FF: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L011C: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L013A: ShowMessage(player, doMsgs, String14D5); // You found a secret door, but it's locked.
            L0147: goto L0166;
            L0149: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0166: return; // RETURN;
        }

        private void FnHIDDORCC_3A(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x0008);
            L0012: if (JumpNotBelow) goto L007A;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L007A;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L007A;
            L0039: ax = HasUsedItem(player, type, ref doMsgs, 0xBD, 0xBD);
            L004C: if (JumpNotEqual) goto L007A;
            L004E: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L0061: if (JumpNotEqual) goto L007A;
            L0063: ax = IsFlagOn(player, FlagTypeTile, 0x01);
            L0075: if (JumpNotEqual) goto L007A;
            L0077: goto L0149;
            L007A: SetFlag(player, FlagTypeTile, 0x01, 0x01);
            L008E: ax = HasUsedItem(player, type, ref doMsgs, 0xC2, 0xC4);
            L00A1: if (JumpNotEqual) goto L00B4;
            L00A3: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0E), 0x0009);
            L00B2: if (JumpBelow) goto L00FF;
            L00B4: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00D2: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00F0: ShowMessage(player, doMsgs, String14FF); // You opened the locked chamber door.
            L00FD: goto L0147;
            L00FF: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L011C: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L013A: ShowMessage(player, doMsgs, String1523); // You found a hidden chamber door, but it's locked.
            L0147: goto L0166;
            L0149: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0166: return; // RETURN;
        }

        private void FnHIDDORFF_3D(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, type, ref doMsgs, 0xC4, 0xC4);
            L0016: if (JumpNotEqual) goto L0029;
            L0018: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0E), 0x000C);
            L0027: if (JumpBelow) goto L0074;
            L0029: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0047: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0065: ShowMessage(player, doMsgs, String1555); // With great effort, you unlock the door.
            L0072: goto L009E;
            L0074: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0091: ShowMessage(player, doMsgs, String157D); // This door has a nasty looking lock on it.
            L009E: return; // RETURN;
        }

        private void FnHIDDORII_40(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x0006);
            L0012: if (JumpNotBelow) goto L007A;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L007A;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L007A;
            L0039: ax = HasUsedItem(player, type, ref doMsgs, 0xBD, 0xBD);
            L004C: if (JumpNotEqual) goto L007A;
            L004E: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L0061: if (JumpNotEqual) goto L007A;
            L0063: ax = IsFlagOn(player, FlagTypeTile, 0x01);
            L0075: if (JumpNotEqual) goto L007A;
            L0077: goto L0149;
            L007A: SetFlag(player, FlagTypeTile, 0x01, 0x01);
            L008E: ax = HasUsedItem(player, type, ref doMsgs, 0xC3, 0xC4);
            L00A1: if (JumpNotEqual) goto L00B4;
            L00A3: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0E), 0x0009);
            L00B2: if (JumpBelow) goto L00FF;
            L00B4: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00D2: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00F0: ShowMessage(player, doMsgs, String15A7); // The door is opened with a lot of effort.
            L00FD: goto L0147;
            L00FF: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L011C: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L013A: ShowMessage(player, doMsgs, String15D0); // You found another secret door, but it is locked.
            L0147: goto L0166;
            L0149: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0166: return; // RETURN;
        }

        private void FnEXITMSG_41(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String1601); // Can't take any more?  The door is marked 'Exit!'
            L0010: return; // RETURN;
        }

        private void FnSTRTMSG_42(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String1632); // A message on the wall:  'Welcome to the Den of Thieves!'
            L0010: return; // RETURN;
        }

        private void FnGOODYA_43(YsPlayerServer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xC3);
            L0011: if (JumpEqual) goto L0022;
            L0013: ShowMessage(player, doMsgs, String166B); // You find an empty chest.
            L0020: goto L004C;
            L0022: GiveItem(player, 0xC3);
            L002E: ModifyGold(player, 0x04E2);
            L003F: ShowMessage(player, doMsgs, String1684); // You find a Purple Lockpick and 1250 gold inside a small chest.
            L004C: return; // RETURN;
        }

    }
}
