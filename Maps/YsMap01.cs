#pragma warning disable
using System.Collections.Generic;
using XPT.Legacy;
using XPT.Legacy.Entities;

namespace XPT.Legacy.Maps {
    class YserMap01 : AMapScripted {
        protected override int MapIndex => 1;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap01() {
            MapEvent01 = FnTOEXIT_01;
            MapEvent02 = FnTELEPORT_02;
            MapEvent03 = FnLOWMNSTR_03;
            MapEvent04 = FnSMALGOLD_04;
            MapEvent05 = FnGOLDENC_05;
            MapEvent06 = FnLKPKDOOR_06;
            MapEvent07 = FnLOWROGUE_07;
            MapEvent08 = FnTUFMNSTR_08;
            MapEvent09 = FnLCPKENC_09;
            MapEvent0A = FnKEYDOOR_0A;
            MapEvent0B = FnKEYENC_0B;
            MapEvent0C = FnSTRDOOR_0C;
            MapEvent0D = FnTOVEST_0D;
            MapEvent0E = FnMODMNSTR_0E;
            MapEvent0F = FnHRDMONST_0F;
            MapEvent10 = FnWEAPENC_10;
            MapEvent11 = FnPITA_11;
            MapEvent12 = FnSECDOOR_12;
            MapEvent13 = Fn_13;
            MapEvent14 = Fn_14;
            MapEvent15 = FnPITB_15;
            MapEvent16 = FnPITC_16;
            MapEvent17 = FnPITD_17;
            MapEvent18 = FnTELEMESA_18;
            MapEvent19 = FnNPCCHATA_19;
            MapEvent1A = FnNPCCHATB_1A;
            MapEvent1B = FnNPCCHATC_1B;
            MapEvent1C = FnNPCCHATD_1C;
            MapEvent1D = FnNPCCHATE_1D;
            MapEvent1E = FnNPCCHATF_1E;
        }
        
        // === Strings ================================================
        private const string String03FC = "You may enter.";
        private const string String040B = "Only heroes of the twentieth level or higher may venture beyond this door.";
        private const string String0456 = "The room is bare.";
        private const string String0468 = "You find 100 Gold Pieces lying on the floor.";
        private const string String0495 = "The room is empty, except for a few rogues.";
        private const string String04C1 = "You encounter Rogues counting their gold.";
        private const string String04EB = "You successfully picked the locked door.";
        private const string String0514 = "The door is locked.";
        private const string String0528 = "You encounter Rogues.";
        private const string String053E = "To reach the next level of the dungeon, you need a special key. The key is rumored to be somewhere on this level.";
        private const string String05B0 = "The Rogues refuse to talk.";
        private const string String05CB = "They attack you!";
        private const string String05DC = "Cro-Lizards snarl at you.";
        private const string String05F6 = "You see an interesting lockpick on the floor. On the shaft are the words - Property of King Cleowyn. The Cro-Lizards you see are also interested in the lockpick.";
        private const string String0698 = "King Cleowyn's Key unlocks the door.";
        private const string String06BD = "The door is locked.  A special key opens this door.";
        private const string String06F1 = "Some rather nasty monsters hang out here.";
        private const string String071B = "On the floor is a key. The grasp bears the Galabryan insignia and the initials KC. It must have belonged to King Cleowyn.  ";
        private const string String0797 = "Between you and the key are monsters.";
        private const string String07BD = "You manage to open the door by brute strength.";
        private const string String07EC = "You are not strong enough to force the door open.";
        private const string String081E = "You encounter Rogues.";
        private const string String0834 = "The imps that haunt the dungeon frequently return gold and lost items to their original places.";
        private const string String0894 = "The Rogues refuse to talk.";
        private const string String08AF = "They charge you!";
        private const string String08C0 = "You find nothing interesting in the room except a vial and some monsters.";
        private const string String090A = "You notice an axe and a vial on the floor. You also notice some Bronze Ogres.";
        private const string String0958 = "You fall into a pit.";
        private const string String096D = "You take heavy damage from the long, long fall.";
        private const string String099D = "Since you are the first to land, your body provides a soft mattress for the rest of your party.";
        private const string String09FD = "A kindly spirit rescues you from falling to your death.";
        private const string String0A35 = "It warns you to stay away from danger until you are stronger.";
        private const string String0A73 = "You detect a secret door in the wall.";
        private const string String0A99 = "You see a blank wall.";
        private const string String0AAF = "The gateway leads to THE DUNGEON ENTRANCE.";
        private const string String0ADA = "The gateway leads to THE VESTIBULE.";
        private const string String0AFE = "You fall into a pit.";
        private const string String0B13 = "You take heavy damage from the long, long fall.";
        private const string String0B43 = "Since you are the first to land, your body provides a soft mattress for the rest of your party.";
        private const string String0BA3 = "A kindly spirit rescues you from falling to your death.";
        private const string String0BDB = "It warns you to stay away from danger until you are stronger.";
        private const string String0C19 = "You fall into a pit.";
        private const string String0C2E = "You take heavy damage from the long, long fall.";
        private const string String0C5E = "Since you are the first to land, your body provides a soft mattress for the rest of your party.";
        private const string String0CBE = "A kindly spirit rescues you from falling to your death.";
        private const string String0CF6 = "It warns you to stay away from danger until you are stronger.";
        private const string String0D34 = "You fall into a pit.";
        private const string String0D49 = "You take heavy damage from the long, long fall.";
        private const string String0D79 = "Since you are the first to land, your body provides a soft mattress for the rest of your party.";
        private const string String0DD9 = "A kindly spirit rescues you from falling to your death.";
        private const string String0E11 = "It warns you to stay away from danger until you are stronger.";
        private const string String0E4F = "There is a teleport in the west wall.";
        private const string String0E75 = "You encounter an Orc Ranger.";
        private const string String0E92 = "King Cleowyn had a special lockpick which opened a set of doors in the Vestibule, leading to his Palace. He was the king of thieves, or so my father told me.";
        private const string String0F30 = "The Orc Ranger ignores you and wanders off.";
        private const string String0F5C = "You encounter a Human Wizard.";
        private const string String0F7A = "The lone adventurer is often at a disadvantage in this cursed dungeon. Those deeper levels...oh, they are very dangerous, indeed.";
        private const string String0FFC = "The Human Wizard turns his back on you.";
        private const string String1024 = "You encounter a Dwarf Knight.";
        private const string String1042 = "There are rumors of a fantastic treasury which King Cleowyn visited each night to count his ill-gotten tax revenues.";
        private const string String10B7 = "The Dwarf Knight seems uninterested in you and turns away.";
        private const string String10F2 = "You encounter a Troll Cleric.";
        private const string String1110 = "Being able to detect hidden traps and doors is important for any party of adventurers wandering this dungeon.";
        private const string String117E = "Also, keep an eye open for better lockpicks. They will open doors to new wonders.";
        private const string String11D0 = "The Troll Cleric is annoyed that you disturbed her reverie. She raps you on the head with her staff and marches off.";
        private const string String1245 = "You encounter a Human Thief.";
        private const string String1262 = "The upper levels of this dungeon make up the Palace of King Cleowyn. He was a cruel ruler and was hated by all.";
        private const string String12D2 = "Beware of the many traps and pitfalls in and around the Palace. Not even the most clever thief can escape Cleowyn's traps.";
        private const string String134D = "The Human Thief slithers away without saying a word.";
        private const string String1382 = "You encounter an Elf Barbarian.";
        private const string String13A2 = "Beware the pit to be found at the heart of the mine. Only the very strongest can survive the fall into the deep abyss.";
        private const string String1419 = "The Elf Barbarian trudges off to kill some monsters.";
        
        // === Functions ================================================
        private void FnTOEXIT_01(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x01, 0x01, 0x04, 0x01, type);
            L001E: return; // RETURN;
        }

        private void FnTELEPORT_02(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckLevel(player, 0x0014);
            L0011: if (JumpEqual) goto L003D;
            L0013: ShowMessage(player, doMsgs, String03FC); // You may enter.
            L0020: TeleportParty(player, 0x05, 0x01, 0x8D, 0x01, type);
            L003B: goto L0068;
            L003D: ShowMessage(player, doMsgs, String040B); // Only heroes of the twentieth level or higher may venture beyond this door.
            L004A: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0068: return; // RETURN;
        }

        private void FnLOWMNSTR_03(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpEqual) goto L001D;
            L0010: Compare(PartyCount(player), 0x0002);
            L001B: if (JumpNotEqual) goto L0043;
            L001D: AddEncounter(player, 0x01, 0x1A);
            L002F: AddEncounter(player, 0x02, 0x1A);
            L0041: goto L008B;
            L0043: AddEncounter(player, 0x01, 0x1A);
            L0055: AddEncounter(player, 0x02, 0x1A);
            L0067: AddEncounter(player, 0x03, 0x19);
            L0079: AddEncounter(player, 0x04, 0x19);
            L008B: return; // RETURN;
        }

        private void FnSMALGOLD_04(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, FlagTypeDungeon, FlagMinesFound100Gold), 0x0001);
            L0017: if (JumpNotEqual) goto L0028;
            L0019: ShowMessage(player, doMsgs, String0456); // The room is bare.
            L0026: goto L005B;
            L0028: ModifyGold(player, 0x0064);
            L0039: ShowMessage(player, doMsgs, String0468); // You find 100 Gold Pieces lying on the floor.
            L0046: SetFlag(player, FlagTypeDungeon, FlagMinesFound100Gold, 0x01);
            L005B: return; // RETURN;
        }

        private void FnGOLDENC_05(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, FlagTypeDungeon, FlagMinesFoundRoguesGold), 0x0001);
            L0017: if (JumpNotEqual) goto L0047;
            L0019: ShowMessage(player, doMsgs, String0495); // The room is empty, except for a few rogues.
            L0026: AddTreasure(player, 0x0064, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L0045: goto L0089;
            L0047: AddTreasure(player, 0x03E8, 0x00, 0x00, 0x00, 0xCB, 0xCE);
            L0067: SetFlag(player, FlagTypeDungeon, FlagMinesFoundRoguesGold, 0x01);
            L007C: ShowMessage(player, doMsgs, String04C1); // You encounter Rogues counting their gold.
            L0089: Compare(PartyCount(player), 0x0001);
            L0094: if (JumpEqual) goto L00A3;
            L0096: Compare(PartyCount(player), 0x0002);
            L00A1: if (JumpNotEqual) goto L00C9;
            L00A3: AddEncounter(player, 0x01, 0x13);
            L00B5: AddEncounter(player, 0x02, 0x13);
            L00C7: goto L0111;
            L00C9: AddEncounter(player, 0x01, 0x13);
            L00DB: AddEncounter(player, 0x02, 0x13);
            L00ED: AddEncounter(player, 0x03, 0x14);
            L00FF: AddEncounter(player, 0x06, 0x18);
            L0111: return; // RETURN;
        }

        private void FnLKPKDOOR_06(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, type, ref doMsgs, 0xC2, 0xC4);
            L0016: if (JumpNotEqual) goto L0029;
            L0018: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0E), 0x0005);
            L0027: if (JumpBelow) goto L006C;
            L0029: SetWallPassable(player, GetCurrentTile(player), 0x01, 0x01);
            L0043: SetWallItem(player, 0x01, GetCurrentTile(player), 0x01);
            L005D: ShowMessage(player, doMsgs, String04EB); // You successfully picked the locked door.
            L006A: goto L0092;
            L006C: SetWallPassable(player, GetCurrentTile(player), 0x01, 0x00);
            L0085: ShowMessage(player, doMsgs, String0514); // The door is locked.
            L0092: return; // RETURN;
        }

        private void FnLOWROGUE_07(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0528); // You encounter Rogues.
            L0010: Compare(GetRandom(0x000F), 0x0005);
            L0020: if (JumpAbove) goto L0031;
            L0022: ShowMessage(player, doMsgs, String053E); // To reach the next level of the dungeon, you need a special key. The key is rumored to be somewhere on this level.
            L002F: goto L004B;
            L0031: ShowMessage(player, doMsgs, String05B0); // The Rogues refuse to talk.
            L003E: ShowMessage(player, doMsgs, String05CB); // They attack you!
            L004B: Compare(PartyCount(player), 0x0001);
            L0056: if (JumpEqual) goto L0065;
            L0058: Compare(PartyCount(player), 0x0002);
            L0063: if (JumpNotEqual) goto L008B;
            L0065: AddEncounter(player, 0x01, 0x1C);
            L0077: AddEncounter(player, 0x02, 0x1D);
            L0089: goto L00E5;
            L008B: AddEncounter(player, 0x01, 0x1D);
            L009D: AddEncounter(player, 0x02, 0x1D);
            L00AF: AddEncounter(player, 0x03, 0x1B);
            L00C1: AddEncounter(player, 0x04, 0x1B);
            L00D3: AddEncounter(player, 0x05, 0x1C);
            L00E5: return; // RETURN;
        }

        private void FnTUFMNSTR_08(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0037;
            L0010: AddEncounter(player, 0x01, 0x1F);
            L0022: AddEncounter(player, 0x02, 0x20);
            L0034: goto L00E3;
            L0037: Compare(PartyCount(player), 0x0002);
            L0042: if (JumpEqual) goto L0051;
            L0044: Compare(PartyCount(player), 0x0003);
            L004F: if (JumpNotEqual) goto L009B;
            L0051: AddEncounter(player, 0x01, 0x1E);
            L0063: AddEncounter(player, 0x02, 0x1F);
            L0075: AddEncounter(player, 0x03, 0x1E);
            L0087: AddEncounter(player, 0x04, 0x1F);
            L0099: goto L00E3;
            L009B: AddEncounter(player, 0x01, 0x1E);
            L00AD: AddEncounter(player, 0x02, 0x20);
            L00BF: AddEncounter(player, 0x03, 0x20);
            L00D1: AddEncounter(player, 0x04, 0x1F);
            L00E3: return; // RETURN;
        }

        private void FnLCPKENC_09(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, ItemKingCleowynsLockpick);
            L0011: if (JumpEqual) goto L0041;
            L0013: ShowMessage(player, doMsgs, String05DC); // Cro-Lizards snarl at you.
            L0020: AddTreasure(player, 0x012C, 0x00, 0x00, 0x00, 0x00, 0xCE);
            L003F: goto L006D;
            L0041: AddTreasure(player, 0x012C, 0x00, 0x00, 0x00, 0x00, ItemKingCleowynsLockpick);
            L0060: ShowMessage(player, doMsgs, String05F6); // You see an interesting lockpick on the floor. On the shaft are the words - Property of King Cleowyn. The Cro-Lizards you see are also interested in the lockpick.
            L006D: Compare(PartyCount(player), 0x0001);
            L0078: if (JumpNotEqual) goto L008F;
            L007A: AddEncounter(player, 0x01, 0x1E);
            L008C: goto L0186;
            L008F: Compare(PartyCount(player), 0x0002);
            L009A: if (JumpNotEqual) goto L00D5;
            L009C: AddEncounter(player, 0x01, 0x1E);
            L00AE: AddEncounter(player, 0x02, 0x1E);
            L00C0: AddEncounter(player, 0x04, 0x1E);
            L00D2: goto L0186;
            L00D5: Compare(PartyCount(player), 0x0003);
            L00E0: if (JumpNotEqual) goto L012C;
            L00E2: AddEncounter(player, 0x01, 0x1E);
            L00F4: AddEncounter(player, 0x02, 0x1E);
            L0106: AddEncounter(player, 0x03, 0x1E);
            L0118: AddEncounter(player, 0x04, 0x1E);
            L012A: goto L0186;
            L012C: AddEncounter(player, 0x01, 0x1E);
            L013E: AddEncounter(player, 0x02, 0x1E);
            L0150: AddEncounter(player, 0x03, 0x1E);
            L0162: AddEncounter(player, 0x04, 0x1E);
            L0174: AddEncounter(player, 0x05, 0x1E);
            L0186: return; // RETURN;
        }

        private void FnKEYDOOR_0A(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, type, ref doMsgs, ItemKingCleowynsKey, ItemKingCleowynsKey);
            L0016: if (JumpEqual) goto L0055;
            L0018: SetWallPassable(player, 0x04, 0x00, 0x01);
            L002D: SetWallItem(player, 0x01, GetCurrentTile(player), 0x00);
            L0046: ShowMessage(player, doMsgs, String0698); // King Cleowyn's Key unlocks the door.
            L0053: goto L0076;
            L0055: ShowMessage(player, doMsgs, String06BD); // The door is locked.  A special key opens this door.
            L0062: SetWallPassable(player, 0x04, 0x00, 0x00);
            L0076: return; // RETURN;
        }

        private void FnKEYENC_0B(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, ItemKingCleowynsKey);
            L0011: if (JumpEqual) goto L0041;
            L0013: AddTreasure(player, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L0032: ShowMessage(player, doMsgs, String06F1); // Some rather nasty monsters hang out here.
            L003F: goto L007A;
            L0041: AddTreasure(player, 0x00C8, 0x00, 0x00, 0x00, 0x00, ItemKingCleowynsKey);
            L0060: ShowMessage(player, doMsgs, String071B); // On the floor is a key. The grasp bears the Galabryan insignia and the initials KC. It must have belonged to King Cleowyn.  
            L006D: ShowMessage(player, doMsgs, String0797); // Between you and the key are monsters.
            L007A: Compare(PartyCount(player), 0x0001);
            L0085: if (JumpNotEqual) goto L009C;
            L0087: AddEncounter(player, 0x01, 0x1F);
            L0099: goto L0181;
            L009C: Compare(PartyCount(player), 0x0002);
            L00A7: if (JumpNotEqual) goto L00D0;
            L00A9: AddEncounter(player, 0x01, 0x1F);
            L00BB: AddEncounter(player, 0x02, 0x20);
            L00CD: goto L0181;
            L00D0: Compare(PartyCount(player), 0x0003);
            L00DB: if (JumpNotEqual) goto L0127;
            L00DD: AddEncounter(player, 0x01, 0x1F);
            L00EF: AddEncounter(player, 0x02, 0x1F);
            L0101: AddEncounter(player, 0x03, 0x20);
            L0113: AddEncounter(player, 0x04, 0x20);
            L0125: goto L0181;
            L0127: AddEncounter(player, 0x01, 0x20);
            L0139: AddEncounter(player, 0x02, 0x20);
            L014B: AddEncounter(player, 0x03, 0x1F);
            L015D: AddEncounter(player, 0x04, 0x1F);
            L016F: AddEncounter(player, 0x06, 0x1F);
            L0181: return; // RETURN;
        }

        private void FnSTRDOOR_0C(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(CheckStrength(player), 0x000A);
            L0012: if (JumpBelow) goto L005F;
            L0014: ShowMessage(player, doMsgs, String07BD); // You manage to open the door by brute strength.
            L0021: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L003F: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L005D: goto L0089;
            L005F: ShowMessage(player, doMsgs, String07EC); // You are not strong enough to force the door open.
            L006C: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0089: return; // RETURN;
        }

        private void FnTOVEST_0D(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x01, 0x03, 0x70, 0x02, type);
            L001E: return; // RETURN;
        }

        private void FnMODMNSTR_0E(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String081E); // You encounter Rogues.
            L0010: Compare(GetRandom(0x000F), 0x0007);
            L0020: if (JumpAbove) goto L0050;
            L0022: ShowMessage(player, doMsgs, String0834); // The imps that haunt the dungeon frequently return gold and lost items to their original places.
            L002F: AddTreasure(player, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L004E: goto L0089;
            L0050: ShowMessage(player, doMsgs, String0894); // The Rogues refuse to talk.
            L005D: ShowMessage(player, doMsgs, String08AF); // They charge you!
            L006A: AddTreasure(player, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0x02);
            L0089: Compare(PartyCount(player), 0x0001);
            L0094: if (JumpEqual) goto L00A3;
            L0096: Compare(PartyCount(player), 0x0002);
            L00A1: if (JumpNotEqual) goto L00C9;
            L00A3: AddEncounter(player, 0x01, 0x23);
            L00B5: AddEncounter(player, 0x02, 0x22);
            L00C7: goto L012B;
            L00C9: Compare(PartyCount(player), 0x0003);
            L00D4: if (JumpEqual) goto L00E3;
            L00D6: Compare(PartyCount(player), 0x0004);
            L00E1: if (JumpNotEqual) goto L012B;
            L00E3: AddEncounter(player, 0x01, 0x22);
            L00F5: AddEncounter(player, 0x02, 0x23);
            L0107: AddEncounter(player, 0x03, 0x23);
            L0119: AddEncounter(player, 0x05, 0x21);
            L012B: return; // RETURN;
        }

        private void FnHRDMONST_0F(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = 0x0001;
            L0007: goto L0019;
            L0009: AddEncounter(player, si, 0x13);
            L0018: si = si + 1;
            L0019: Compare(PartyCount(player), si);
            L0023: if (JumpNotBelow) goto L0009;
            L0025: return; // RETURN (restoring si);
        }

        private void FnWEAPENC_10(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, FlagTypeDungeon, FlagMinesFoundAxe), 0x0001);
            L0017: if (JumpNotEqual) goto L0047;
            L0019: ShowMessage(player, doMsgs, String08C0); // You find nothing interesting in the room except a vial and some monsters.
            L0026: AddTreasure(player, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L0045: goto L0074;
            L0047: AddTreasure(player, 0x00C8, 0x00, 0x00, 0x00, 0xB7, 0x18);
            L0067: ShowMessage(player, doMsgs, String090A); // You notice an axe and a vial on the floor. You also notice some Bronze Ogres.
            L0074: Compare(PartyCount(player), 0x0001);
            L007F: if (JumpNotEqual) goto L0096;
            L0081: AddEncounter(player, 0x01, 0x26);
            L0093: goto L0157;
            L0096: Compare(PartyCount(player), 0x0002);
            L00A1: if (JumpNotEqual) goto L00CA;
            L00A3: AddEncounter(player, 0x01, 0x26);
            L00B5: AddEncounter(player, 0x02, 0x26);
            L00C7: goto L0157;
            L00CA: Compare(PartyCount(player), 0x0003);
            L00D5: if (JumpNotEqual) goto L010F;
            L00D7: AddEncounter(player, 0x01, 0x26);
            L00E9: AddEncounter(player, 0x02, 0x26);
            L00FB: AddEncounter(player, 0x03, 0x26);
            L010D: goto L0157;
            L010F: AddEncounter(player, 0x01, 0x26);
            L0121: AddEncounter(player, 0x02, 0x26);
            L0133: AddEncounter(player, 0x03, 0x26);
            L0145: AddEncounter(player, 0x04, 0x26);
            L0157: return; // RETURN;
        }

        private void FnPITA_11(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckLevel(player, 0x000F);
            L0011: if (JumpNotEqual) goto L0016;
            L0013: goto L00B3;
            L0016: SetFloorItem(player, 0x01, GetCurrentTile(player));
            L002B: ShowMessage(player, doMsgs, String0958); // You fall into a pit.
            L0038: ShowMessage(player, doMsgs, String096D); // You take heavy damage from the long, long fall.
            L0045: Compare(PartyCount(player), 0x0001);
            L0050: if (JumpNotEqual) goto L007C;
            L0052: DamagePlayer(player, 0x012C);
            L005F: TeleportParty(player, 0x05, 0x03, 0x11, 0x03, type);
            L007A: goto L00B1;
            L007C: ShowMessage(player, doMsgs, String099D); // Since you are the first to land, your body provides a soft mattress for the rest of your party.
            L0089: DamagePlayer(player, 0x01C2);
            L0096: TeleportParty(player, 0x05, 0x03, 0x11, 0x03, type);
            L00B1: goto L00E8;
            L00B3: ShowMessage(player, doMsgs, String09FD); // A kindly spirit rescues you from falling to your death.
            L00C0: ShowMessage(player, doMsgs, String0A35); // It warns you to stay away from danger until you are stronger.
            L00CD: TeleportParty(player, 0x01, 0x02, 0x67, 0x01, type);
            L00E8: return; // RETURN;
        }

        private void FnSECDOOR_12(ServerPlayer player, MapEventType type, bool doMsgs) {
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
            L0061: if (JumpEqual) goto L009E;
            L0063: ShowMessage(player, doMsgs, String0A73); // You detect a secret door in the wall.
            L0070: SetWallItem(player, 0x01, 0xED, 0x02);
            L0086: SetWallPassable(player, 0xED, 0x02, 0x01);
            L009C: goto L00C0;
            L009E: ShowMessage(player, doMsgs, String0A99); // You see a blank wall.
            L00AB: SetWallPassable(player, 0xED, 0x02, 0x00);
            L00C0: return; // RETURN;
        }

        private void Fn_13(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0AAF); // The gateway leads to THE DUNGEON ENTRANCE.
            L0010: return; // RETURN;
        }

        private void Fn_14(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0ADA); // The gateway leads to THE VESTIBULE.
            L0010: return; // RETURN;
        }

        private void FnPITB_15(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckLevel(player, 0x000F);
            L0011: if (JumpNotEqual) goto L0016;
            L0013: goto L00B3;
            L0016: SetFloorItem(player, 0x01, GetCurrentTile(player));
            L002B: ShowMessage(player, doMsgs, String0AFE); // You fall into a pit.
            L0038: ShowMessage(player, doMsgs, String0B13); // You take heavy damage from the long, long fall.
            L0045: Compare(PartyCount(player), 0x0001);
            L0050: if (JumpNotEqual) goto L007C;
            L0052: DamagePlayer(player, 0x012C);
            L005F: TeleportParty(player, 0x05, 0x03, 0x12, 0x03, type);
            L007A: goto L00B1;
            L007C: ShowMessage(player, doMsgs, String0B43); // Since you are the first to land, your body provides a soft mattress for the rest of your party.
            L0089: DamagePlayer(player, 0x01C2);
            L0096: TeleportParty(player, 0x05, 0x03, 0x12, 0x03, type);
            L00B1: goto L00E7;
            L00B3: ShowMessage(player, doMsgs, String0BA3); // A kindly spirit rescues you from falling to your death.
            L00C0: ShowMessage(player, doMsgs, String0BDB); // It warns you to stay away from danger until you are stronger.
            L00CD: TeleportParty(player, 0x01, 0x02, 0x69, 0x00, type);
            L00E7: return; // RETURN;
        }

        private void FnPITC_16(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckLevel(player, 0x000F);
            L0011: if (JumpNotEqual) goto L0016;
            L0013: goto L00B3;
            L0016: SetFloorItem(player, 0x01, GetCurrentTile(player));
            L002B: ShowMessage(player, doMsgs, String0C19); // You fall into a pit.
            L0038: ShowMessage(player, doMsgs, String0C2E); // You take heavy damage from the long, long fall.
            L0045: Compare(PartyCount(player), 0x0001);
            L0050: if (JumpNotEqual) goto L007C;
            L0052: DamagePlayer(player, 0x012C);
            L005F: TeleportParty(player, 0x05, 0x03, 0x21, 0x01, type);
            L007A: goto L00B1;
            L007C: ShowMessage(player, doMsgs, String0C5E); // Since you are the first to land, your body provides a soft mattress for the rest of your party.
            L0089: DamagePlayer(player, 0x01C2);
            L0096: TeleportParty(player, 0x05, 0x03, 0x21, 0x01, type);
            L00B1: goto L00E8;
            L00B3: ShowMessage(player, doMsgs, String0CBE); // A kindly spirit rescues you from falling to your death.
            L00C0: ShowMessage(player, doMsgs, String0CF6); // It warns you to stay away from danger until you are stronger.
            L00CD: TeleportParty(player, 0x01, 0x02, 0x76, 0x02, type);
            L00E8: return; // RETURN;
        }

        private void FnPITD_17(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckLevel(player, 0x000F);
            L0011: if (JumpNotEqual) goto L0016;
            L0013: goto L00B1;
            L0016: SetFloorItem(player, 0x01, GetCurrentTile(player));
            L002B: ShowMessage(player, doMsgs, String0D34); // You fall into a pit.
            L0038: ShowMessage(player, doMsgs, String0D49); // You take heavy damage from the long, long fall.
            L0045: Compare(PartyCount(player), 0x0001);
            L0050: if (JumpNotEqual) goto L007B;
            L0052: DamagePlayer(player, 0x012C);
            L005F: TeleportParty(player, 0x05, 0x03, 0x22, 0x00, type);
            L0079: goto L00AF;
            L007B: ShowMessage(player, doMsgs, String0D79); // Since you are the first to land, your body provides a soft mattress for the rest of your party.
            L0088: DamagePlayer(player, 0x01C2);
            L0095: TeleportParty(player, 0x05, 0x03, 0x22, 0x00, type);
            L00AF: goto L00E5;
            L00B1: ShowMessage(player, doMsgs, String0DD9); // A kindly spirit rescues you from falling to your death.
            L00BE: ShowMessage(player, doMsgs, String0E11); // It warns you to stay away from danger until you are stronger.
            L00CB: TeleportParty(player, 0x01, 0x02, 0x79, 0x00, type);
            L00E5: return; // RETURN;
        }

        private void FnTELEMESA_18(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(player);
            L000B: ShowMessage(player, doMsgs, String0E4F); // There is a teleport in the west wall.
            L0018: return; // RETURN;
        }

        private void FnNPCCHATA_19(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0E75); // You encounter an Orc Ranger.
            L0010: ShowPortrait(player, 0x001E);
            L001D: Compare(GetRandom(0x000F), 0x0009);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, doMsgs, String0E92); // King Cleowyn had a special lockpick which opened a set of doors in the Vestibule, leading to his Palace. He was the king of thieves, or so my father told me.
            L003C: goto L004B;
            L003E: ShowMessage(player, doMsgs, String0F30); // The Orc Ranger ignores you and wanders off.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATB_1A(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0F5C); // You encounter a Human Wizard.
            L0010: ShowPortrait(player, 0x002B);
            L001D: Compare(GetRandom(0x000F), 0x0004);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, doMsgs, String0F7A); // The lone adventurer is often at a disadvantage in this cursed dungeon. Those deeper levels...oh, they are very dangerous, indeed.
            L003C: goto L004B;
            L003E: ShowMessage(player, doMsgs, String0FFC); // The Human Wizard turns his back on you.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATC_1B(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String1024); // You encounter a Dwarf Knight.
            L0010: ShowPortrait(player, 0x001C);
            L001D: Compare(GetRandom(0x000F), 0x000A);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, doMsgs, String1042); // There are rumors of a fantastic treasury which King Cleowyn visited each night to count his ill-gotten tax revenues.
            L003C: goto L004B;
            L003E: ShowMessage(player, doMsgs, String10B7); // The Dwarf Knight seems uninterested in you and turns away.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATD_1C(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String10F2); // You encounter a Troll Cleric.
            L0010: ShowPortrait(player, 0x0028);
            L001D: Compare(GetRandom(0x000F), 0x000C);
            L002D: if (JumpAbove) goto L004B;
            L002F: ShowMessage(player, doMsgs, String1110); // Being able to detect hidden traps and doors is important for any party of adventurers wandering this dungeon.
            L003C: ShowMessage(player, doMsgs, String117E); // Also, keep an eye open for better lockpicks. They will open doors to new wonders.
            L0049: goto L0065;
            L004B: ShowMessage(player, doMsgs, String11D0); // The Troll Cleric is annoyed that you disturbed her reverie. She raps you on the head with her staff and marches off.
            L0058: DamagePlayer(player, 0x0003);
            L0065: return; // RETURN;
        }

        private void FnNPCCHATE_1D(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String1245); // You encounter a Human Thief.
            L0010: ShowPortrait(player, 0x0022);
            L001D: Compare(GetRandom(0x000F), 0x000B);
            L002D: if (JumpAbove) goto L004B;
            L002F: ShowMessage(player, doMsgs, String1262); // The upper levels of this dungeon make up the Palace of King Cleowyn. He was a cruel ruler and was hated by all.
            L003C: ShowMessage(player, doMsgs, String12D2); // Beware of the many traps and pitfalls in and around the Palace. Not even the most clever thief can escape Cleowyn's traps.
            L0049: goto L0058;
            L004B: ShowMessage(player, doMsgs, String134D); // The Human Thief slithers away without saying a word.
            L0058: return; // RETURN;
        }

        private void FnNPCCHATF_1E(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String1382); // You encounter an Elf Barbarian.
            L0010: ShowPortrait(player, 0x0018);
            L001D: Compare(GetRandom(0x000F), 0x000C);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(player, doMsgs, String13A2); // Beware the pit to be found at the heart of the mine. Only the very strongest can survive the fall into the deep abyss.
            L003C: goto L004B;
            L003E: ShowMessage(player, doMsgs, String1419); // The Elf Barbarian trudges off to kill some monsters.
            L004B: return; // RETURN;
        }

    }
}
