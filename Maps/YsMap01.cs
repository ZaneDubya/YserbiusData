#pragma warning disable
using XPT.WorldData;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap01 : AMapScripted {
        protected override int MapIndex => 1;
        
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
        private void FnTOEXIT_01(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x01, 0x01, 0x04, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELEPORT_02(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckLevel(party, 0x0014);
            L0011: if (JumpEqual) goto L003D;
            L0013: ShowMessage(party, String03FC); // You may enter.
            L0020: TeleportParty(party, 0x05, 0x01, 0x8D, 0x01, isForwardMove);
            L003B: goto L0068;
            L003D: ShowMessage(party, String040B); // Only heroes of the twentieth level or higher may venture beyond this door.
            L004A: PushStack(party, 0x01);
            L004E: ax = GetFacing(party);
            L0055: PushStack(party, ax);
            L0056: ax = GetCurrentTile(party);
            L005D: PushStack(party, ax);
            L005E: SetWallPassable(party, PopStack(party), PopStack(party), PopStack(party));
            L0068: return; // RETURN;
        }

        private void FnLOWMNSTR_03(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: Compare(ax, 0x0001);
            L000E: if (JumpEqual) goto L001D;
            L0010: ax = PartyCount(party);
            L0018: Compare(ax, 0x0002);
            L001B: if (JumpNotEqual) goto L0043;
            L001D: AddEncounter(party, 0x01, 0x1A);
            L002F: AddEncounter(party, 0x02, 0x1A);
            L0041: goto L008B;
            L0043: AddEncounter(party, 0x01, 0x1A);
            L0055: AddEncounter(party, 0x02, 0x1A);
            L0067: AddEncounter(party, 0x03, 0x19);
            L0079: AddEncounter(party, 0x04, 0x19);
            L008B: return; // RETURN;
        }

        private void FnSMALGOLD_04(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetState(party, 0x02, 0x02);
            L0014: Compare(ax, 0x0001);
            L0017: if (JumpNotEqual) goto L0028;
            L0019: ShowMessage(party, String0456); // The room is bare.
            L0026: goto L005B;
            L0028: ModifyGold(party, 0x0064);
            L0039: ShowMessage(party, String0468); // You find 100 Gold Pieces lying on the floor.
            L0046: SetState(party, 0x02, 0x02, 0x01);
            L005B: return; // RETURN;
        }

        private void FnGOLDENC_05(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetState(party, 0x02, 0x03);
            L0014: Compare(ax, 0x0001);
            L0017: if (JumpNotEqual) goto L0047;
            L0019: ShowMessage(party, String0495); // The room is empty, except for a few rogues.
            L0026: AddTreasure(party, 0x0064, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L0045: goto L0089;
            L0047: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0xCB, 0xCE);
            L0067: SetState(party, 0x02, 0x03, 0x01);
            L007C: ShowMessage(party, String04C1); // You encounter Rogues counting their gold.
            L0089: ax = PartyCount(party);
            L0091: Compare(ax, 0x0001);
            L0094: if (JumpEqual) goto L00A3;
            L0096: ax = PartyCount(party);
            L009E: Compare(ax, 0x0002);
            L00A1: if (JumpNotEqual) goto L00C9;
            L00A3: AddEncounter(party, 0x01, 0x13);
            L00B5: AddEncounter(party, 0x02, 0x13);
            L00C7: goto L0111;
            L00C9: AddEncounter(party, 0x01, 0x13);
            L00DB: AddEncounter(party, 0x02, 0x13);
            L00ED: AddEncounter(party, 0x03, 0x14);
            L00FF: AddEncounter(party, 0x06, 0x18);
            L0111: return; // RETURN;
        }

        private void FnLKPKDOOR_06(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(party, 0xC2, 0xC4);
            L0016: if (JumpNotEqual) goto L0029;
            L0018: ax = HasUsedSkill(party, 0x0E); // returns 0 if did not use, compares to 2nd op if did use;
            L0024: Compare(ax, 0x0005);
            L0027: if (JumpBelow) goto L006C;
            L0029: PushStack(party, 0x01);
            L002D: PushStack(party, 0x01);
            L0031: ax = GetCurrentTile(party);
            L0038: PushStack(party, ax);
            L0039: SetWallPassable(party, PopStack(party), PopStack(party), PopStack(party));
            L0043: PushStack(party, 0x01);
            L0047: ax = GetCurrentTile(party);
            L004E: PushStack(party, ax);
            L004F: PushStack(party, 0x01);
            L0053: SetWallObject(party, PopStack(party), PopStack(party), PopStack(party));
            L005D: ShowMessage(party, String04EB); // You successfully picked the locked door.
            L006A: goto L0092;
            L006C: PushStack(party, 0x00);
            L006F: PushStack(party, 0x01);
            L0073: ax = GetCurrentTile(party);
            L007A: PushStack(party, ax);
            L007B: SetWallPassable(party, PopStack(party), PopStack(party), PopStack(party));
            L0085: ShowMessage(party, String0514); // The door is locked.
            L0092: return; // RETURN;
        }

        private void FnLOWROGUE_07(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0528); // You encounter Rogues.
            L0010: ax = GetRandom(party, 0x000F);
            L001D: Compare(ax, 0x0005);
            L0020: if (JumpAbove) goto L0031;
            L0022: ShowMessage(party, String053E); // To reach the next level of the dungeon, you need a special key. The key is rumored to be somewhere on this level.
            L002F: goto L004B;
            L0031: ShowMessage(party, String05B0); // The Rogues refuse to talk.
            L003E: ShowMessage(party, String05CB); // They attack you!
            L004B: ax = PartyCount(party);
            L0053: Compare(ax, 0x0001);
            L0056: if (JumpEqual) goto L0065;
            L0058: ax = PartyCount(party);
            L0060: Compare(ax, 0x0002);
            L0063: if (JumpNotEqual) goto L008B;
            L0065: AddEncounter(party, 0x01, 0x1C);
            L0077: AddEncounter(party, 0x02, 0x1D);
            L0089: goto L00E5;
            L008B: AddEncounter(party, 0x01, 0x1D);
            L009D: AddEncounter(party, 0x02, 0x1D);
            L00AF: AddEncounter(party, 0x03, 0x1B);
            L00C1: AddEncounter(party, 0x04, 0x1B);
            L00D3: AddEncounter(party, 0x05, 0x1C);
            L00E5: return; // RETURN;
        }

        private void FnTUFMNSTR_08(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = PartyCount(party);
            L000B: Compare(ax, 0x0001);
            L000E: if (JumpNotEqual) goto L0037;
            L0010: AddEncounter(party, 0x01, 0x1F);
            L0022: AddEncounter(party, 0x02, 0x20);
            L0034: goto L00E3;
            L0037: ax = PartyCount(party);
            L003F: Compare(ax, 0x0002);
            L0042: if (JumpEqual) goto L0051;
            L0044: ax = PartyCount(party);
            L004C: Compare(ax, 0x0003);
            L004F: if (JumpNotEqual) goto L009B;
            L0051: AddEncounter(party, 0x01, 0x1E);
            L0063: AddEncounter(party, 0x02, 0x1F);
            L0075: AddEncounter(party, 0x03, 0x1E);
            L0087: AddEncounter(party, 0x04, 0x1F);
            L0099: goto L00E3;
            L009B: AddEncounter(party, 0x01, 0x1E);
            L00AD: AddEncounter(party, 0x02, 0x20);
            L00BF: AddEncounter(party, 0x03, 0x20);
            L00D1: AddEncounter(party, 0x04, 0x1F);
            L00E3: return; // RETURN;
        }

        private void FnLCPKENC_09(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0xD2);
            L0011: if (JumpEqual) goto L0041;
            L0013: ShowMessage(party, String05DC); // Cro-Lizards snarl at you.
            L0020: AddTreasure(party, 0x012C, 0x00, 0x00, 0x00, 0x00, 0xCE);
            L003F: goto L006D;
            L0041: AddTreasure(party, 0x012C, 0x00, 0x00, 0x00, 0x00, 0xD2);
            L0060: ShowMessage(party, String05F6); // You see an interesting lockpick on the floor. On the shaft are the words - Property of King Cleowyn. The Cro-Lizards you see are also interested in the lockpick.
            L006D: ax = PartyCount(party);
            L0075: Compare(ax, 0x0001);
            L0078: if (JumpNotEqual) goto L008F;
            L007A: AddEncounter(party, 0x01, 0x1E);
            L008C: goto L0186;
            L008F: ax = PartyCount(party);
            L0097: Compare(ax, 0x0002);
            L009A: if (JumpNotEqual) goto L00D5;
            L009C: AddEncounter(party, 0x01, 0x1E);
            L00AE: AddEncounter(party, 0x02, 0x1E);
            L00C0: AddEncounter(party, 0x04, 0x1E);
            L00D2: goto L0186;
            L00D5: ax = PartyCount(party);
            L00DD: Compare(ax, 0x0003);
            L00E0: if (JumpNotEqual) goto L012C;
            L00E2: AddEncounter(party, 0x01, 0x1E);
            L00F4: AddEncounter(party, 0x02, 0x1E);
            L0106: AddEncounter(party, 0x03, 0x1E);
            L0118: AddEncounter(party, 0x04, 0x1E);
            L012A: goto L0186;
            L012C: AddEncounter(party, 0x01, 0x1E);
            L013E: AddEncounter(party, 0x02, 0x1E);
            L0150: AddEncounter(party, 0x03, 0x1E);
            L0162: AddEncounter(party, 0x04, 0x1E);
            L0174: AddEncounter(party, 0x05, 0x1E);
            L0186: return; // RETURN;
        }

        private void FnKEYDOOR_0A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(party, 0xD3, 0xD3);
            L0016: if (JumpEqual) goto L0055;
            L0018: SetWallPassable(party, 0x04, 0x00, 0x01);
            L002D: PushStack(party, 0x00);
            L0030: ax = GetCurrentTile(party);
            L0037: PushStack(party, ax);
            L0038: PushStack(party, 0x01);
            L003C: SetWallObject(party, PopStack(party), PopStack(party), PopStack(party));
            L0046: ShowMessage(party, String0698); // King Cleowyn's Key unlocks the door.
            L0053: goto L0076;
            L0055: ShowMessage(party, String06BD); // The door is locked.  A special key opens this door.
            L0062: PushStack(party, 0x00);
            L0065: PushStack(party, 0x00);
            L0068: PushStack(party, 0x04);
            L006C: SetWallPassable(party, PopStack(party), PopStack(party), PopStack(party));
            L0076: return; // RETURN;
        }

        private void FnKEYENC_0B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0xD3);
            L0011: if (JumpEqual) goto L0041;
            L0013: AddTreasure(party, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L0032: ShowMessage(party, String06F1); // Some rather nasty monsters hang out here.
            L003F: goto L007A;
            L0041: AddTreasure(party, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xD3);
            L0060: ShowMessage(party, String071B); // On the floor is a key. The grasp bears the Galabryan insignia and the initials KC. It must have belonged to King Cleowyn.  
            L006D: ShowMessage(party, String0797); // Between you and the key are monsters.
            L007A: ax = PartyCount(party);
            L0082: Compare(ax, 0x0001);
            L0085: if (JumpNotEqual) goto L009C;
            L0087: AddEncounter(party, 0x01, 0x1F);
            L0099: goto L0181;
            L009C: ax = PartyCount(party);
            L00A4: Compare(ax, 0x0002);
            L00A7: if (JumpNotEqual) goto L00D0;
            L00A9: AddEncounter(party, 0x01, 0x1F);
            L00BB: AddEncounter(party, 0x02, 0x20);
            L00CD: goto L0181;
            L00D0: ax = PartyCount(party);
            L00D8: Compare(ax, 0x0003);
            L00DB: if (JumpNotEqual) goto L0127;
            L00DD: AddEncounter(party, 0x01, 0x1F);
            L00EF: AddEncounter(party, 0x02, 0x1F);
            L0101: AddEncounter(party, 0x03, 0x20);
            L0113: AddEncounter(party, 0x04, 0x20);
            L0125: goto L0181;
            L0127: AddEncounter(party, 0x01, 0x20);
            L0139: AddEncounter(party, 0x02, 0x20);
            L014B: AddEncounter(party, 0x03, 0x1F);
            L015D: AddEncounter(party, 0x04, 0x1F);
            L016F: AddEncounter(party, 0x06, 0x1F);
            L0181: return; // RETURN;
        }

        private void FnSTRDOOR_0C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckStrength(party);
            L000F: Compare(ax, 0x000A);
            L0012: if (JumpBelow) goto L005F;
            L0014: ShowMessage(party, String07BD); // You manage to open the door by brute strength.
            L0021: ax = GetFacing(party);
            L0028: PushStack(party, ax);
            L0029: ax = GetCurrentTile(party);
            L0030: PushStack(party, ax);
            L0031: PushStack(party, 0x01);
            L0035: SetWallObject(party, PopStack(party), PopStack(party), PopStack(party));
            L003F: PushStack(party, 0x01);
            L0043: ax = GetFacing(party);
            L004A: PushStack(party, ax);
            L004B: ax = GetCurrentTile(party);
            L0052: PushStack(party, ax);
            L0053: SetWallPassable(party, PopStack(party), PopStack(party), PopStack(party));
            L005D: goto L0089;
            L005F: ShowMessage(party, String07EC); // You are not strong enough to force the door open.
            L006C: PushStack(party, 0x00);
            L006F: ax = GetFacing(party);
            L0076: PushStack(party, ax);
            L0077: ax = GetCurrentTile(party);
            L007E: PushStack(party, ax);
            L007F: SetWallPassable(party, PopStack(party), PopStack(party), PopStack(party));
            L0089: return; // RETURN;
        }

        private void FnTOVEST_0D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x01, 0x03, 0x70, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnMODMNSTR_0E(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String081E); // You encounter Rogues.
            L0010: ax = GetRandom(party, 0x000F);
            L001D: Compare(ax, 0x0007);
            L0020: if (JumpAbove) goto L0050;
            L0022: ShowMessage(party, String0834); // The imps that haunt the dungeon frequently return gold and lost items to their original places.
            L002F: AddTreasure(party, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L004E: goto L0089;
            L0050: ShowMessage(party, String0894); // The Rogues refuse to talk.
            L005D: ShowMessage(party, String08AF); // They charge you!
            L006A: AddTreasure(party, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0x02);
            L0089: ax = PartyCount(party);
            L0091: Compare(ax, 0x0001);
            L0094: if (JumpEqual) goto L00A3;
            L0096: ax = PartyCount(party);
            L009E: Compare(ax, 0x0002);
            L00A1: if (JumpNotEqual) goto L00C9;
            L00A3: AddEncounter(party, 0x01, 0x23);
            L00B5: AddEncounter(party, 0x02, 0x22);
            L00C7: goto L012B;
            L00C9: ax = PartyCount(party);
            L00D1: Compare(ax, 0x0003);
            L00D4: if (JumpEqual) goto L00E3;
            L00D6: ax = PartyCount(party);
            L00DE: Compare(ax, 0x0004);
            L00E1: if (JumpNotEqual) goto L012B;
            L00E3: AddEncounter(party, 0x01, 0x22);
            L00F5: AddEncounter(party, 0x02, 0x23);
            L0107: AddEncounter(party, 0x03, 0x23);
            L0119: AddEncounter(party, 0x05, 0x21);
            L012B: return; // RETURN;
        }

        private void FnHRDMONST_0F(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = 0x0001;
            L0007: goto L0019;
            L0009: AddEncounter(party, si, 0x13);
            L0018: si = si + 1;
            L0019: ax = PartyCount(party);
            L0021: Compare(ax, si);
            L0023: if (JumpNotBelow) goto L0009;
            L0025: return; // RETURN (restoring si);
        }

        private void FnWEAPENC_10(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetState(party, 0x02, 0x04);
            L0014: Compare(ax, 0x0001);
            L0017: if (JumpNotEqual) goto L0047;
            L0019: ShowMessage(party, String08C0); // You find nothing interesting in the room except a vial and some monsters.
            L0026: AddTreasure(party, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L0045: goto L0074;
            L0047: AddTreasure(party, 0x00C8, 0x00, 0x00, 0x00, 0xB7, 0x18);
            L0067: ShowMessage(party, String090A); // You notice an axe and a vial on the floor. You also notice some Bronze Ogres.
            L0074: ax = PartyCount(party);
            L007C: Compare(ax, 0x0001);
            L007F: if (JumpNotEqual) goto L0096;
            L0081: AddEncounter(party, 0x01, 0x26);
            L0093: goto L0157;
            L0096: ax = PartyCount(party);
            L009E: Compare(ax, 0x0002);
            L00A1: if (JumpNotEqual) goto L00CA;
            L00A3: AddEncounter(party, 0x01, 0x26);
            L00B5: AddEncounter(party, 0x02, 0x26);
            L00C7: goto L0157;
            L00CA: ax = PartyCount(party);
            L00D2: Compare(ax, 0x0003);
            L00D5: if (JumpNotEqual) goto L010F;
            L00D7: AddEncounter(party, 0x01, 0x26);
            L00E9: AddEncounter(party, 0x02, 0x26);
            L00FB: AddEncounter(party, 0x03, 0x26);
            L010D: goto L0157;
            L010F: AddEncounter(party, 0x01, 0x26);
            L0121: AddEncounter(party, 0x02, 0x26);
            L0133: AddEncounter(party, 0x03, 0x26);
            L0145: AddEncounter(party, 0x04, 0x26);
            L0157: return; // RETURN;
        }

        private void FnPITA_11(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckLevel(party, 0x000F);
            L0011: if (JumpNotEqual) goto L0016;
            L0013: goto L00B3;
            L0016: ax = GetCurrentTile(party);
            L001D: SetFloorObject(party, 0x01, ax);
            L002B: ShowMessage(party, String0958); // You fall into a pit.
            L0038: ShowMessage(party, String096D); // You take heavy damage from the long, long fall.
            L0045: ax = PartyCount(party);
            L004D: Compare(ax, 0x0001);
            L0050: if (JumpNotEqual) goto L007C;
            L0052: DamagePlayer(party, 0x012C);
            L005F: TeleportParty(party, 0x05, 0x03, 0x11, 0x03, isForwardMove);
            L007A: goto L00B1;
            L007C: ShowMessage(party, String099D); // Since you are the first to land, your body provides a soft mattress for the rest of your party.
            L0089: DamagePlayer(party, 0x01C2);
            L0096: TeleportParty(party, 0x05, 0x03, 0x11, 0x03, isForwardMove);
            L00B1: goto L00E8;
            L00B3: ShowMessage(party, String09FD); // A kindly spirit rescues you from falling to your death.
            L00C0: ShowMessage(party, String0A35); // It warns you to stay away from danger until you are stronger.
            L00CD: TeleportParty(party, 0x01, 0x02, 0x67, 0x01, isForwardMove);
            L00E8: return; // RETURN;
        }

        private void FnSECDOOR_12(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedSkill(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L000F: Compare(ax, 0x0008);
            L0012: if (JumpNotBelow) goto L0063;
            L0014: ax = HasUsedSpell(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (JumpNotEqual) goto L0063;
            L0024: ax = HasUsedItem(party, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L0063;
            L0039: ax = HasUsedItem(party, 0xBD, 0xBD);
            L004C: if (JumpNotEqual) goto L0063;
            L004E: ax = HasUsedItem(party, 0xBE, 0xBE);
            L0061: if (JumpEqual) goto L009E;
            L0063: ShowMessage(party, String0A73); // You detect a secret door in the wall.
            L0070: PushStack(party, 0x02);
            L0074: PushStack(party, 0xED);
            L0078: PushStack(party, 0x01);
            L007C: SetWallObject(party, PopStack(party), PopStack(party), PopStack(party));
            L0086: SetWallPassable(party, 0xED, 0x02, 0x01);
            L009C: goto L00C0;
            L009E: ShowMessage(party, String0A99); // You see a blank wall.
            L00AB: PushStack(party, 0x00);
            L00AE: PushStack(party, 0x02);
            L00B2: PushStack(party, 0xED);
            L00B6: SetWallPassable(party, PopStack(party), PopStack(party), PopStack(party));
            L00C0: return; // RETURN;
        }

        private void Fn_13(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0AAF); // The gateway leads to THE DUNGEON ENTRANCE.
            L0010: return; // RETURN;
        }

        private void Fn_14(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0ADA); // The gateway leads to THE VESTIBULE.
            L0010: return; // RETURN;
        }

        private void FnPITB_15(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckLevel(party, 0x000F);
            L0011: if (JumpNotEqual) goto L0016;
            L0013: goto L00B3;
            L0016: ax = GetCurrentTile(party);
            L001D: SetFloorObject(party, 0x01, ax);
            L002B: ShowMessage(party, String0AFE); // You fall into a pit.
            L0038: ShowMessage(party, String0B13); // You take heavy damage from the long, long fall.
            L0045: ax = PartyCount(party);
            L004D: Compare(ax, 0x0001);
            L0050: if (JumpNotEqual) goto L007C;
            L0052: DamagePlayer(party, 0x012C);
            L005F: TeleportParty(party, 0x05, 0x03, 0x12, 0x03, isForwardMove);
            L007A: goto L00B1;
            L007C: ShowMessage(party, String0B43); // Since you are the first to land, your body provides a soft mattress for the rest of your party.
            L0089: DamagePlayer(party, 0x01C2);
            L0096: TeleportParty(party, 0x05, 0x03, 0x12, 0x03, isForwardMove);
            L00B1: goto L00E7;
            L00B3: ShowMessage(party, String0BA3); // A kindly spirit rescues you from falling to your death.
            L00C0: ShowMessage(party, String0BDB); // It warns you to stay away from danger until you are stronger.
            L00CD: TeleportParty(party, 0x01, 0x02, 0x69, 0x00, isForwardMove);
            L00E7: return; // RETURN;
        }

        private void FnPITC_16(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckLevel(party, 0x000F);
            L0011: if (JumpNotEqual) goto L0016;
            L0013: goto L00B3;
            L0016: ax = GetCurrentTile(party);
            L001D: SetFloorObject(party, 0x01, ax);
            L002B: ShowMessage(party, String0C19); // You fall into a pit.
            L0038: ShowMessage(party, String0C2E); // You take heavy damage from the long, long fall.
            L0045: ax = PartyCount(party);
            L004D: Compare(ax, 0x0001);
            L0050: if (JumpNotEqual) goto L007C;
            L0052: DamagePlayer(party, 0x012C);
            L005F: TeleportParty(party, 0x05, 0x03, 0x21, 0x01, isForwardMove);
            L007A: goto L00B1;
            L007C: ShowMessage(party, String0C5E); // Since you are the first to land, your body provides a soft mattress for the rest of your party.
            L0089: DamagePlayer(party, 0x01C2);
            L0096: TeleportParty(party, 0x05, 0x03, 0x21, 0x01, isForwardMove);
            L00B1: goto L00E8;
            L00B3: ShowMessage(party, String0CBE); // A kindly spirit rescues you from falling to your death.
            L00C0: ShowMessage(party, String0CF6); // It warns you to stay away from danger until you are stronger.
            L00CD: TeleportParty(party, 0x01, 0x02, 0x76, 0x02, isForwardMove);
            L00E8: return; // RETURN;
        }

        private void FnPITD_17(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckLevel(party, 0x000F);
            L0011: if (JumpNotEqual) goto L0016;
            L0013: goto L00B1;
            L0016: ax = GetCurrentTile(party);
            L001D: SetFloorObject(party, 0x01, ax);
            L002B: ShowMessage(party, String0D34); // You fall into a pit.
            L0038: ShowMessage(party, String0D49); // You take heavy damage from the long, long fall.
            L0045: ax = PartyCount(party);
            L004D: Compare(ax, 0x0001);
            L0050: if (JumpNotEqual) goto L007B;
            L0052: DamagePlayer(party, 0x012C);
            L005F: TeleportParty(party, 0x05, 0x03, 0x22, 0x00, isForwardMove);
            L0079: goto L00AF;
            L007B: ShowMessage(party, String0D79); // Since you are the first to land, your body provides a soft mattress for the rest of your party.
            L0088: DamagePlayer(party, 0x01C2);
            L0095: TeleportParty(party, 0x05, 0x03, 0x22, 0x00, isForwardMove);
            L00AF: goto L00E5;
            L00B1: ShowMessage(party, String0DD9); // A kindly spirit rescues you from falling to your death.
            L00BE: ShowMessage(party, String0E11); // It warns you to stay away from danger until you are stronger.
            L00CB: TeleportParty(party, 0x01, 0x02, 0x79, 0x00, isForwardMove);
            L00E5: return; // RETURN;
        }

        private void FnTELEMESA_18(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(party);
            L000B: ShowMessage(party, String0E4F); // There is a teleport in the west wall.
            L0018: return; // RETURN;
        }

        private void FnNPCCHATA_19(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0E75); // You encounter an Orc Ranger.
            L0010: ShowPortrait(party, 0x001E);
            L001D: ax = GetRandom(party, 0x000F);
            L002A: Compare(ax, 0x0009);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String0E92); // King Cleowyn had a special lockpick which opened a set of doors in the Vestibule, leading to his Palace. He was the king of thieves, or so my father told me.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0F30); // The Orc Ranger ignores you and wanders off.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATB_1A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0F5C); // You encounter a Human Wizard.
            L0010: ShowPortrait(party, 0x002B);
            L001D: ax = GetRandom(party, 0x000F);
            L002A: Compare(ax, 0x0004);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String0F7A); // The lone adventurer is often at a disadvantage in this cursed dungeon. Those deeper levels...oh, they are very dangerous, indeed.
            L003C: goto L004B;
            L003E: ShowMessage(party, String0FFC); // The Human Wizard turns his back on you.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATC_1B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1024); // You encounter a Dwarf Knight.
            L0010: ShowPortrait(party, 0x001C);
            L001D: ax = GetRandom(party, 0x000F);
            L002A: Compare(ax, 0x000A);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String1042); // There are rumors of a fantastic treasury which King Cleowyn visited each night to count his ill-gotten tax revenues.
            L003C: goto L004B;
            L003E: ShowMessage(party, String10B7); // The Dwarf Knight seems uninterested in you and turns away.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATD_1C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String10F2); // You encounter a Troll Cleric.
            L0010: ShowPortrait(party, 0x0028);
            L001D: ax = GetRandom(party, 0x000F);
            L002A: Compare(ax, 0x000C);
            L002D: if (JumpAbove) goto L004B;
            L002F: ShowMessage(party, String1110); // Being able to detect hidden traps and doors is important for any party of adventurers wandering this dungeon.
            L003C: ShowMessage(party, String117E); // Also, keep an eye open for better lockpicks. They will open doors to new wonders.
            L0049: goto L0065;
            L004B: ShowMessage(party, String11D0); // The Troll Cleric is annoyed that you disturbed her reverie. She raps you on the head with her staff and marches off.
            L0058: DamagePlayer(party, 0x0003);
            L0065: return; // RETURN;
        }

        private void FnNPCCHATE_1D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1245); // You encounter a Human Thief.
            L0010: ShowPortrait(party, 0x0022);
            L001D: ax = GetRandom(party, 0x000F);
            L002A: Compare(ax, 0x000B);
            L002D: if (JumpAbove) goto L004B;
            L002F: ShowMessage(party, String1262); // The upper levels of this dungeon make up the Palace of King Cleowyn. He was a cruel ruler and was hated by all.
            L003C: ShowMessage(party, String12D2); // Beware of the many traps and pitfalls in and around the Palace. Not even the most clever thief can escape Cleowyn's traps.
            L0049: goto L0058;
            L004B: ShowMessage(party, String134D); // The Human Thief slithers away without saying a word.
            L0058: return; // RETURN;
        }

        private void FnNPCCHATF_1E(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1382); // You encounter an Elf Barbarian.
            L0010: ShowPortrait(party, 0x0018);
            L001D: ax = GetRandom(party, 0x000F);
            L002A: Compare(ax, 0x000C);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String13A2); // Beware the pit to be found at the heart of the mine. Only the very strongest can survive the fall into the deep abyss.
            L003C: goto L004B;
            L003E: ShowMessage(party, String1419); // The Elf Barbarian trudges off to kill some monsters.
            L004B: return; // RETURN;
        }

    }
}
