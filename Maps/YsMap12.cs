#pragma warning disable
using XPT.WorldData;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap12 : AMapScripted {
        protected override int MapIndex => 12;
        protected override int RandomEncounterChance => 15;
        protected override int RandomEncounterExtraCount => 1;

        public YserMap12() {
            MapEvent01 = FnSTRSTELE_01;
            MapEvent02 = FnTOCORDOR_02;
            MapEvent03 = FnSTRSTELE_03;
            MapEvent04 = FnSTRSTELE_04;
            MapEvent05 = FnSTRSTELE_05;
            MapEvent06 = FnNDORSWCH_06;
            MapEvent07 = FnEDORSWCH_07;
            MapEvent08 = FnEDORSWCH_08;
            MapEvent09 = FnWDORSWCH_09;
            MapEvent0A = FnNSWCHDOR_0A;
            MapEvent0B = FnESWCHDOR_0B;
            MapEvent0C = FnSSWCHDOR_0C;
            MapEvent0D = FnWSWCHDOR_0D;
            MapEvent0E = FnALLSWDOR_0E;
            MapEvent0F = FnWKEYENC_0F;
            MapEvent10 = FnCKEYENC_10;
            MapEvent11 = FnEKEYENC_11;
            MapEvent12 = FnRUNECLUE_12;
            MapEvent13 = FnCLUEB_13;
            MapEvent14 = FnTUFMNSTR_14;
            MapEvent17 = FnGOLDAENC_17;
            MapEvent18 = FnGOLDBENC_18;
            MapEvent19 = FnGOLDCENC_19;
            MapEvent1A = FnITEMCENC_1A;
            MapEvent1B = FnITEMBENC_1B;
            MapEvent1C = FnITEMCENC_1C;
            MapEvent1D = FnWEAPAENC_1D;
            MapEvent1E = FnWEAPBENC_1E;
            MapEvent1F = FnARMRAENC_1F;
            MapEvent20 = FnARMRBENC_20;
            MapEvent21 = FnSHLDAENC_21;
            MapEvent22 = FnSLDBENC_22;
            MapEvent23 = FnKINGDOOR_23;
            MapEvent24 = FnSTRGATEM_24;
            MapEvent25 = FnSTRSMESS_25;
            MapEvent26 = FnSTRSMESS_26;
            MapEvent27 = FnSTRSMESS_27;
            MapEvent29 = FnNPCCHATA_29;
            MapEvent2A = FnNPCCHATB_2A;
            MapEvent2B = FnNPCCHATC_2B;
            MapEvent2C = FnNPCCHATD_2C;
        }
        
        // === Strings ================================================
        private const string String03FC = "You see a switch on the wall and throw it. You hear the sound of locks opening.";
        private const string String044C = "You see a switch on the wall and throw it. You hear the sound of locks opening.";
        private const string String049C = "You see a switch on the wall and throw it. You hear the sound of locks opening.";
        private const string String04EC = "You see a switch on the wall and throw it. You hear the sound of locks opening.";
        private const string String053C = "The door is unlocked.";
        private const string String0552 = "The door is sealed shut. There is no lock on the outside.";
        private const string String058C = "The door is unlocked.";
        private const string String05A2 = "The door is sealed shut. There is no lock on the outside.";
        private const string String05DC = "The door is unlocked.";
        private const string String05F2 = "The door is sealed shut. There is no lock on the outside.";
        private const string String062C = "The door is unlocked.";
        private const string String0642 = "The door is sealed shut. There is no lock on the outside.";
        private const string String067C = "A door appears in the south wall.";
        private const string String069E = "Monsters attack you.";
        private const string String06B3 = "A key dangles from a spider's mandible.";
        private const string String06DB = "Silver Ogres spring a trap.";
        private const string String06F7 = "A Silver Ogre plays with an unusual key.";
        private const string String0720 = "Lizardites have made this room their home.";
        private const string String074B = "A Lizardite holds a key shaped like the rune sign for I.";
        private const string String0784 = "The tapestry contains runes...";
        private const string String07A3 = "Take the Crown, Robe and Scepter to the Mausoleum of Cleowyn. Use them in the correct niches to open the true path to the king's tomb.";
        private const string String082A = "There are runes on this tapestry...";
        private const string String084E = "Go west, but not farthest west, and give the Crown when you can go no more. Go east, but not farthest east, and give the Robe when you can go no more. When Crown and Robe are given, continue to the door of the tomb. Give the Scepter there to be rewarded.";
        private const string String094D = "You encounter Bugbears.";
        private const string String0965 = "Bugbears stand near some gold.";
        private const string String0984 = "Dire Wolves scratch the floor impatiently.";
        private const string String09AF = "A Dire Wolf plays with a coin purse.";
        private const string String09D4 = "You suddenly feel nervous.";
        private const string String09EF = "Hungry lions prowl the area.";
        private const string String0A0C = "The floor crawls with Leeches.";
        private const string String0A2B = "Leeches swarm over a magic wand.";
        private const string String0A4C = "Giants interrupt your search.";
        private const string String0A6A = "A Giant wears a medallion around his neck.";
        private const string String0A95 = "You disturb a nest of Cockatrices.";
        private const string String0AB8 = "You see a vial in a Cockatrice nest.";
        private const string String0ADD = "Silver Ogres suddenly appear around you.";
        private const string String0B06 = "The lead Silver Ogre wields a powerful morningstar.";
        private const string String0B3A = "You disturb some sleeping Giants.";
        private const string String0B5C = "A gleaming sword lies on the floor between you and a group of Giants.";
        private const string String0BA2 = "Dark shadows coalesce into Bugbears.";
        private const string String0BC7 = "A Bugbear guards some chainmail.";
        private const string String0BE8 = "You enter a roosting area for Cockatrices.";
        private const string String0C13 = "In a Cockatrice nest you see luminous chainmail.";
        private const string String0C44 = "Dire Wolves encircle you.";
        private const string String0C5E = "Dire Wolves seem fascinated by a shiny shield.";
        private const string String0C8D = "Loud hisses alert you to danger.";
        private const string String0CAE = "Lizardites move between you and a piece of armor on the floor.";
        private const string String0CED = "The door is unlocked.";
        private const string String0D03 = "The door is sealed shut. You see what appears to be the bas relief of a royal ring ";
        private const string String0D57 = "The stairs through the north gateway lead up. The gateway to the east leads to THE GREAT CORRIDOR.";
        private const string String0DBA = "The stairs past the south gateway lead up a level.";
        private const string String0DED = "There are stairs through the the north gateway.";
        private const string String0E1D = "There are stairs beyond the west gateway.";
        private const string String0E47 = "You encounter a Human Barbarian.";
        private const string String0E68 = "The opening and closing of secret doors in this area give me a headache. I simply cannot puzzle out the correct sequence of opening the doors. I wish my map of this area were more complete.";
        private const string String0F26 = "By the way, if you don't have the king's ring, you won't get anywhere in this crazy place.";
        private const string String0F81 = "The Human Barbarian pays you no attention as he puzzles over a map.";
        private const string String0FC5 = "You encounter a Gnome Wizard.";
        private const string String0FE3 = "Once you find a key in this area, seek the hidden door and follow your destiny. The door appears only when you have the right key. Where it leads I do not know.";
        private const string String1084 = "The Gnome Wizard is too intent on drawing runes in the dust to talk to you.";
        private const string String10D0 = "You encounter an Orc Knight.";
        private const string String10ED = "There are many ways into King Cleowyn's Mausoleum, but few are rewarding. The most direct ways are the most challenging. Do not continue unless you have what the king demands.";
        private const string String119D = "The Orc Knight dismisses you as low-level buffoons.";
        private const string String11D1 = "You encounter a Halfling Thief.";
        private const string String11F1 = "Beneath the king's living quarters is an area known as the Thieves' Maze. Only an experienced thief - or a hero who has a thief's skills - will pick his way through this intricate maze.";
        private const string String12AB = "The Halfling Thief steals some gold and runs away.";
        
        // === Functions ================================================
        private void FnSTRSTELE_01(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x02, 0x02, 0x1F, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTOCORDOR_02(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x03, 0x03, 0x10, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnSTRSTELE_03(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x02, 0x03, 0xD3, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnSTRSTELE_04(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x02, 0x04, 0xC6, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnSTRSTELE_05(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(party, 0x02, 0x05, 0xDC, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnNDORSWCH_06(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String03FC); // You see a switch on the wall and throw it. You hear the sound of locks opening.
            L0010: SetState(party, 0x01, 0x01, 0x01);
            L0025: SetState(party, 0x01, 0x02, 0x00);
            L0039: SetState(party, 0x01, 0x03, 0x00);
            L004D: SetState(party, 0x01, 0x04, 0x00);
            L0061: SetWallPassable(party, 0x77, 0x01, 0x01);
            L0077: SetWallVisibile(party, 0x77, 0x01, 0x01);
            L008D: return; // RETURN;
        }

        private void FnEDORSWCH_07(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String044C); // You see a switch on the wall and throw it. You hear the sound of locks opening.
            L0010: SetState(party, 0x01, 0x01, 0x00);
            L0024: SetState(party, 0x01, 0x02, 0x00);
            L0038: SetState(party, 0x01, 0x03, 0x01);
            L004D: SetState(party, 0x01, 0x04, 0x00);
            L0061: SetWallPassable(party, 0x77, 0x00, 0x01);
            L0076: SetWallVisibile(party, 0x77, 0x00, 0x01);
            L008B: return; // RETURN;
        }

        private void FnEDORSWCH_08(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String049C); // You see a switch on the wall and throw it. You hear the sound of locks opening.
            L0010: SetState(party, 0x01, 0x01, 0x00);
            L0024: SetState(party, 0x01, 0x02, 0x01);
            L0039: SetState(party, 0x01, 0x03, 0x00);
            L004D: SetState(party, 0x01, 0x04, 0x00);
            L0061: SetWallPassable(party, 0x77, 0x03, 0x01);
            L0077: SetWallVisibile(party, 0x77, 0x03, 0x01);
            L008D: return; // RETURN;
        }

        private void FnWDORSWCH_09(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String04EC); // You see a switch on the wall and throw it. You hear the sound of locks opening.
            L0010: SetState(party, 0x01, 0x01, 0x00);
            L0024: SetState(party, 0x01, 0x02, 0x00);
            L0038: SetState(party, 0x01, 0x03, 0x00);
            L004C: SetState(party, 0x01, 0x04, 0x01);
            L0061: SetWallPassable(party, 0x77, 0x02, 0x01);
            L0077: SetWallVisibile(party, 0x77, 0x02, 0x01);
            L008D: return; // RETURN;
        }

        private void FnNSWCHDOR_0A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x01), 0x0001);
            L0017: if (JumpNotEqual) goto L005C;
            L0019: ShowMessage(party, String053C); // The door is unlocked.
            L0026: SetWallObject(party, 0x01, GetCurrentTile(party), 0x03);
            L0040: SetWallPassable(party, GetCurrentTile(party), 0x03, 0x01);
            L005A: goto L0082;
            L005C: ShowMessage(party, String0552); // The door is sealed shut. There is no lock on the outside.
            L0069: SetWallPassable(party, GetCurrentTile(party), 0x03, 0x00);
            L0082: return; // RETURN;
        }

        private void FnESWCHDOR_0B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x03), 0x0001);
            L0017: if (JumpNotEqual) goto L005C;
            L0019: ShowMessage(party, String058C); // The door is unlocked.
            L0026: SetWallObject(party, 0x01, GetCurrentTile(party), 0x02);
            L0040: SetWallPassable(party, GetCurrentTile(party), 0x02, 0x01);
            L005A: goto L0082;
            L005C: ShowMessage(party, String05A2); // The door is sealed shut. There is no lock on the outside.
            L0069: SetWallPassable(party, GetCurrentTile(party), 0x02, 0x00);
            L0082: return; // RETURN;
        }

        private void FnSSWCHDOR_0C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x02), 0x0001);
            L0017: if (JumpNotEqual) goto L005C;
            L0019: ShowMessage(party, String05DC); // The door is unlocked.
            L0026: SetWallObject(party, 0x01, GetCurrentTile(party), 0x01);
            L0040: SetWallPassable(party, GetCurrentTile(party), 0x01, 0x01);
            L005A: goto L0082;
            L005C: ShowMessage(party, String05F2); // The door is sealed shut. There is no lock on the outside.
            L0069: SetWallPassable(party, GetCurrentTile(party), 0x01, 0x00);
            L0082: return; // RETURN;
        }

        private void FnWSWCHDOR_0D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x01, 0x04), 0x0001);
            L0017: if (JumpNotEqual) goto L005A;
            L0019: ShowMessage(party, String062C); // The door is unlocked.
            L0026: SetWallObject(party, 0x01, GetCurrentTile(party), 0x00);
            L003F: SetWallPassable(party, GetCurrentTile(party), 0x00, 0x01);
            L0058: goto L007F;
            L005A: ShowMessage(party, String0642); // The door is sealed shut. There is no lock on the outside.
            L0067: SetWallPassable(party, GetCurrentTile(party), 0x00, 0x00);
            L007F: return; // RETURN;
        }

        private void FnALLSWDOR_0E(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0xDA);
            L0011: if (JumpNotEqual) goto L0033;
            L0013: ax = HasItem(party, 0xDB);
            L0021: if (JumpNotEqual) goto L0033;
            L0023: ax = HasItem(party, 0xDC);
            L0031: if (JumpEqual) goto L0076;
            L0033: ShowMessage(party, String067C); // A door appears in the south wall.
            L0040: SetWallObject(party, 0x01, GetCurrentTile(party), 0x01);
            L005A: SetWallPassable(party, GetCurrentTile(party), 0x01, 0x01);
            L0074: goto L008F;
            L0076: SetWallPassable(party, GetCurrentTile(party), 0x01, 0x00);
            L008F: return; // RETURN;
        }

        private void FnWKEYENC_0F(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0xDA);
            L0011: if (JumpEqual) goto L0041;
            L0013: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0xBE);
            L0032: ShowMessage(party, String069E); // Monsters attack you.
            L003F: goto L006E;
            L0041: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0xCF, 0xDA);
            L0061: ShowMessage(party, String06B3); // A key dangles from a spider's mandible.
            L006E: Compare(PartyCount(party), 0x0001);
            L0079: if (JumpEqual) goto L0088;
            L007B: Compare(PartyCount(party), 0x0002);
            L0086: if (JumpNotEqual) goto L00D2;
            L0088: AddEncounter(party, 0x01, 0x1C);
            L009A: AddEncounter(party, 0x02, 0x1C);
            L00AC: AddEncounter(party, 0x03, 0x19);
            L00BE: AddEncounter(party, 0x04, 0x19);
            L00D0: goto L013E;
            L00D2: AddEncounter(party, 0x01, 0x1A);
            L00E4: AddEncounter(party, 0x02, 0x1A);
            L00F6: AddEncounter(party, 0x03, 0x1C);
            L0108: AddEncounter(party, 0x04, 0x1C);
            L011A: AddEncounter(party, 0x05, 0x1A);
            L012C: AddEncounter(party, 0x06, 0x1A);
            L013E: return; // RETURN;
        }

        private void FnCKEYENC_10(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0xDB);
            L0011: if (JumpEqual) goto L0041;
            L0013: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0xB6);
            L0032: ShowMessage(party, String06DB); // Silver Ogres spring a trap.
            L003F: goto L006F;
            L0041: AddTreasure(party, 0x05DC, 0x00, 0x00, 0xCC, 0xD1, 0xDB);
            L0062: ShowMessage(party, String06F7); // A Silver Ogre plays with an unusual key.
            L006F: Compare(PartyCount(party), 0x0001);
            L007A: if (JumpEqual) goto L0089;
            L007C: Compare(PartyCount(party), 0x0002);
            L0087: if (JumpNotEqual) goto L00AF;
            L0089: AddEncounter(party, 0x01, 0x21);
            L009B: AddEncounter(party, 0x02, 0x21);
            L00AD: goto L011B;
            L00AF: AddEncounter(party, 0x01, 0x23);
            L00C1: AddEncounter(party, 0x02, 0x23);
            L00D3: AddEncounter(party, 0x03, 0x24);
            L00E5: AddEncounter(party, 0x04, 0x24);
            L00F7: AddEncounter(party, 0x05, 0x22);
            L0109: AddEncounter(party, 0x06, 0x22);
            L011B: return; // RETURN;
        }

        private void FnEKEYENC_11(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0xDC);
            L0011: if (JumpEqual) goto L0041;
            L0013: AddTreasure(party, 0x0320, 0x00, 0x00, 0x00, 0x00, 0xB6);
            L0032: ShowMessage(party, String0720); // Lizardites have made this room their home.
            L003F: goto L006E;
            L0041: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0xB6, 0xDC);
            L0061: ShowMessage(party, String074B); // A Lizardite holds a key shaped like the rune sign for I.
            L006E: Compare(PartyCount(party), 0x0001);
            L0079: if (JumpEqual) goto L0088;
            L007B: Compare(PartyCount(party), 0x0002);
            L0086: if (JumpNotEqual) goto L00D2;
            L0088: AddEncounter(party, 0x01, 0x27);
            L009A: AddEncounter(party, 0x02, 0x27);
            L00AC: AddEncounter(party, 0x03, 0x28);
            L00BE: AddEncounter(party, 0x04, 0x28);
            L00D0: goto L013E;
            L00D2: AddEncounter(party, 0x01, 0x28);
            L00E4: AddEncounter(party, 0x02, 0x28);
            L00F6: AddEncounter(party, 0x03, 0x27);
            L0108: AddEncounter(party, 0x04, 0x27);
            L011A: AddEncounter(party, 0x05, 0x28);
            L012C: AddEncounter(party, 0x06, 0x28);
            L013E: return; // RETURN;
        }

        private void FnRUNECLUE_12(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0784); // The tapestry contains runes...
            L0010: ShowRunes(party, String07A3); // Take the Crown, Robe and Scepter to the Mausoleum of Cleowyn. Use them in the correct niches to open the true path to the king's tomb.
            L001D: return; // RETURN;
        }

        private void FnCLUEB_13(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String082A); // There are runes on this tapestry...
            L0010: ShowRunes(party, String084E); // Go west, but not farthest west, and give the Crown when you can go no more. Go east, but not farthest east, and give the Robe when you can go no more. When Crown and Robe are given, continue to the door of the tomb. Give the Scepter there to be rewarded.
            L001D: return; // RETURN;
        }

        private void FnTUFMNSTR_14(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(party), 0x0001);
            L000E: if (JumpNotEqual) goto L0037;
            L0010: AddEncounter(party, 0x01, 0x1D);
            L0022: AddEncounter(party, 0x02, 0x1F);
            L0034: goto L0176;
            L0037: Compare(PartyCount(party), 0x0002);
            L0042: if (JumpNotEqual) goto L00A1;
            L0044: AddEncounter(party, 0x01, 0x1E);
            L0056: AddEncounter(party, 0x02, 0x1E);
            L0068: AddEncounter(party, 0x03, 0x1F);
            L007A: AddEncounter(party, 0x04, 0x1F);
            L008C: AddEncounter(party, 0x05, 0x20);
            L009E: goto L0176;
            L00A1: Compare(PartyCount(party), 0x0003);
            L00AC: if (JumpNotEqual) goto L010A;
            L00AE: AddEncounter(party, 0x01, 0x1F);
            L00C0: AddEncounter(party, 0x02, 0x20);
            L00D2: AddEncounter(party, 0x03, 0x1F);
            L00E4: AddEncounter(party, 0x04, 0x20);
            L00F6: AddEncounter(party, 0x05, 0x1E);
            L0108: goto L0176;
            L010A: AddEncounter(party, 0x01, 0x20);
            L011C: AddEncounter(party, 0x02, 0x20);
            L012E: AddEncounter(party, 0x03, 0x1F);
            L0140: AddEncounter(party, 0x04, 0x1F);
            L0152: AddEncounter(party, 0x05, 0x1F);
            L0164: AddEncounter(party, 0x06, 0x1F);
            L0176: return; // RETURN;
        }

        private void FnGOLDAENC_17(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x02, 0x1F), 0x0001);
            L0017: if (JumpNotEqual) goto L0048;
            L0019: AddTreasure(party, 0x0384, 0x00, 0x00, 0x00, 0xB6, 0xD0);
            L0039: ShowMessage(party, String094D); // You encounter Bugbears.
            L0046: goto L0089;
            L0048: AddTreasure(party, 0x0E10, 0x00, 0x00, 0x00, 0x00, 0xB7);
            L0067: SetState(party, 0x02, 0x1F, 0x01);
            L007C: ShowMessage(party, String0965); // Bugbears stand near some gold.
            L0089: Compare(PartyCount(party), 0x0001);
            L0094: if (JumpNotEqual) goto L00AB;
            L0096: AddEncounter(party, 0x01, 0x01);
            L00A8: goto L016C;
            L00AB: Compare(PartyCount(party), 0x0002);
            L00B6: if (JumpNotEqual) goto L00DF;
            L00B8: AddEncounter(party, 0x01, 0x01);
            L00CA: AddEncounter(party, 0x02, 0x02);
            L00DC: goto L016C;
            L00DF: Compare(PartyCount(party), 0x0003);
            L00EA: if (JumpNotEqual) goto L0124;
            L00EC: AddEncounter(party, 0x01, 0x01);
            L00FE: AddEncounter(party, 0x02, 0x02);
            L0110: AddEncounter(party, 0x03, 0x03);
            L0122: goto L016C;
            L0124: AddEncounter(party, 0x01, 0x02);
            L0136: AddEncounter(party, 0x02, 0x03);
            L0148: AddEncounter(party, 0x03, 0x03);
            L015A: AddEncounter(party, 0x04, 0x02);
            L016C: return; // RETURN;
        }

        private void FnGOLDBENC_18(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x02, 0x20), 0x0001);
            L0017: if (JumpNotEqual) goto L0047;
            L0019: AddTreasure(party, 0x0320, 0x00, 0x00, 0x00, 0x00, 0xB7);
            L0038: ShowMessage(party, String0984); // Dire Wolves scratch the floor impatiently.
            L0045: goto L0088;
            L0047: AddTreasure(party, 0x0FA0, 0x00, 0x00, 0x00, 0x00, 0x8E);
            L0066: SetState(party, 0x02, 0x20, 0x01);
            L007B: ShowMessage(party, String09AF); // A Dire Wolf plays with a coin purse.
            L0088: Compare(PartyCount(party), 0x0001);
            L0093: if (JumpEqual) goto L00A2;
            L0095: Compare(PartyCount(party), 0x0002);
            L00A0: if (JumpNotEqual) goto L00C8;
            L00A2: AddEncounter(party, 0x01, 0x0E);
            L00B4: AddEncounter(party, 0x02, 0x0E);
            L00C6: goto L0110;
            L00C8: AddEncounter(party, 0x01, 0x10);
            L00DA: AddEncounter(party, 0x02, 0x10);
            L00EC: AddEncounter(party, 0x03, 0x0E);
            L00FE: AddEncounter(party, 0x04, 0x0F);
            L0110: return; // RETURN;
        }

        private void FnGOLDCENC_19(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetState(party, 0x02, 0x21), 0x0001);
            L0017: if (JumpNotEqual) goto L0047;
            L0019: AddTreasure(party, 0x02EE, 0x00, 0x00, 0x00, 0x00, 0xD1);
            L0038: ShowMessage(party, String09D4); // You suddenly feel nervous.
            L0045: goto L0088;
            L0047: AddTreasure(party, 0x157C, 0x00, 0x00, 0x00, 0x00, 0xCC);
            L0066: SetState(party, 0x02, 0x21, 0x01);
            L007B: ShowMessage(party, String09EF); // Hungry lions prowl the area.
            L0088: Compare(PartyCount(party), 0x0001);
            L0093: if (JumpEqual) goto L00A2;
            L0095: Compare(PartyCount(party), 0x0002);
            L00A0: if (JumpNotEqual) goto L00C9;
            L00A2: AddEncounter(party, 0x01, 0x13);
            L00B4: AddEncounter(party, 0x02, 0x14);
            L00C6: goto L0156;
            L00C9: Compare(PartyCount(party), 0x0003);
            L00D4: if (JumpNotEqual) goto L010E;
            L00D6: AddEncounter(party, 0x01, 0x14);
            L00E8: AddEncounter(party, 0x02, 0x14);
            L00FA: AddEncounter(party, 0x03, 0x15);
            L010C: goto L0156;
            L010E: AddEncounter(party, 0x01, 0x15);
            L0120: AddEncounter(party, 0x02, 0x15);
            L0132: AddEncounter(party, 0x03, 0x16);
            L0144: AddEncounter(party, 0x04, 0x16);
            L0156: return; // RETURN;
        }

        private void FnITEMCENC_1A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0xC6);
            L0011: if (JumpEqual) goto L0041;
            L0013: AddTreasure(party, 0x00FA, 0x00, 0x00, 0x00, 0x00, 0xCD);
            L0032: ShowMessage(party, String0A0C); // The floor crawls with Leeches.
            L003F: goto L006D;
            L0041: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0xC6);
            L0060: ShowMessage(party, String0A2B); // Leeches swarm over a magic wand.
            L006D: Compare(PartyCount(party), 0x0001);
            L0078: if (JumpNotEqual) goto L00A1;
            L007A: AddEncounter(party, 0x01, 0x1B);
            L008C: AddEncounter(party, 0x02, 0x1B);
            L009E: goto L0164;
            L00A1: Compare(PartyCount(party), 0x0002);
            L00AC: if (JumpNotEqual) goto L00F8;
            L00AE: AddEncounter(party, 0x01, 0x1C);
            L00C0: AddEncounter(party, 0x02, 0x1C);
            L00D2: AddEncounter(party, 0x03, 0x1B);
            L00E4: AddEncounter(party, 0x04, 0x1B);
            L00F6: goto L0164;
            L00F8: AddEncounter(party, 0x01, 0x16);
            L010A: AddEncounter(party, 0x02, 0x16);
            L011C: AddEncounter(party, 0x03, 0x1C);
            L012E: AddEncounter(party, 0x04, 0x1C);
            L0140: AddEncounter(party, 0x05, 0x1B);
            L0152: AddEncounter(party, 0x06, 0x1B);
            L0164: return; // RETURN;
        }

        private void FnITEMBENC_1B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0x96);
            L0011: if (JumpEqual) goto L0040;
            L0013: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L0031: ShowMessage(party, String0A4C); // Giants interrupt your search.
            L003E: goto L006B;
            L0040: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0x00, 0x96);
            L005E: ShowMessage(party, String0A6A); // A Giant wears a medallion around his neck.
            L006B: Compare(PartyCount(party), 0x0001);
            L0076: if (JumpNotEqual) goto L008D;
            L0078: AddEncounter(party, 0x01, 0x25);
            L008A: goto L013E;
            L008D: Compare(PartyCount(party), 0x0002);
            L0098: if (JumpNotEqual) goto L00D2;
            L009A: AddEncounter(party, 0x01, 0x25);
            L00AC: AddEncounter(party, 0x02, 0x26);
            L00BE: AddEncounter(party, 0x03, 0x25);
            L00D0: goto L013E;
            L00D2: AddEncounter(party, 0x01, 0x25);
            L00E4: AddEncounter(party, 0x02, 0x25);
            L00F6: AddEncounter(party, 0x03, 0x26);
            L0108: AddEncounter(party, 0x04, 0x26);
            L011A: AddEncounter(party, 0x05, 0x25);
            L012C: AddEncounter(party, 0x06, 0x26);
            L013E: return; // RETURN;
        }

        private void FnITEMCENC_1C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0xD1);
            L0011: if (JumpEqual) goto L0041;
            L0013: AddTreasure(party, 0x012C, 0x00, 0x00, 0x00, 0x00, 0xB5);
            L0032: ShowMessage(party, String0A95); // You disturb a nest of Cockatrices.
            L003F: goto L006D;
            L0041: AddTreasure(party, 0x05DC, 0x00, 0x00, 0x00, 0x00, 0xD1);
            L0060: ShowMessage(party, String0AB8); // You see a vial in a Cockatrice nest.
            L006D: Compare(PartyCount(party), 0x0001);
            L0078: if (JumpEqual) goto L0087;
            L007A: Compare(PartyCount(party), 0x0002);
            L0085: if (JumpNotEqual) goto L00AD;
            L0087: AddEncounter(party, 0x01, 0x08);
            L0099: AddEncounter(party, 0x02, 0x07);
            L00AB: goto L00F5;
            L00AD: AddEncounter(party, 0x01, 0x09);
            L00BF: AddEncounter(party, 0x02, 0x09);
            L00D1: AddEncounter(party, 0x05, 0x0C);
            L00E3: AddEncounter(party, 0x06, 0x0A);
            L00F5: return; // RETURN;
        }

        private void FnWEAPAENC_1D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0x2A);
            L0011: if (JumpEqual) goto L0041;
            L0013: AddTreasure(party, 0x012C, 0x00, 0x00, 0x00, 0x00, 0xBD);
            L0032: ShowMessage(party, String0ADD); // Silver Ogres suddenly appear around you.
            L003F: goto L006D;
            L0041: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0x2A);
            L0060: ShowMessage(party, String0B06); // The lead Silver Ogre wields a powerful morningstar.
            L006D: Compare(PartyCount(party), 0x0001);
            L0078: if (JumpEqual) goto L0087;
            L007A: Compare(PartyCount(party), 0x0002);
            L0085: if (JumpNotEqual) goto L00AE;
            L0087: AddEncounter(party, 0x01, 0x21);
            L0099: AddEncounter(party, 0x02, 0x22);
            L00AB: goto L013B;
            L00AE: Compare(PartyCount(party), 0x0003);
            L00B9: if (JumpNotEqual) goto L00F3;
            L00BB: AddEncounter(party, 0x01, 0x21);
            L00CD: AddEncounter(party, 0x02, 0x22);
            L00DF: AddEncounter(party, 0x03, 0x23);
            L00F1: goto L013B;
            L00F3: AddEncounter(party, 0x01, 0x21);
            L0105: AddEncounter(party, 0x02, 0x22);
            L0117: AddEncounter(party, 0x03, 0x23);
            L0129: AddEncounter(party, 0x04, 0x24);
            L013B: return; // RETURN;
        }

        private void FnWEAPBENC_1E(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0x10);
            L0011: if (JumpEqual) goto L0041;
            L0013: AddTreasure(party, 0x012C, 0x00, 0x00, 0x00, 0x00, 0xCE);
            L0032: ShowMessage(party, String0B3A); // You disturb some sleeping Giants.
            L003F: goto L006D;
            L0041: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x10);
            L0060: ShowMessage(party, String0B5C); // A gleaming sword lies on the floor between you and a group of Giants.
            L006D: Compare(PartyCount(party), 0x0001);
            L0078: if (JumpNotEqual) goto L008F;
            L007A: AddEncounter(party, 0x01, 0x25);
            L008C: goto L012E;
            L008F: Compare(PartyCount(party), 0x0002);
            L009A: if (JumpNotEqual) goto L00D4;
            L009C: AddEncounter(party, 0x01, 0x25);
            L00AE: AddEncounter(party, 0x02, 0x26);
            L00C0: AddEncounter(party, 0x04, 0x21);
            L00D2: goto L012E;
            L00D4: AddEncounter(party, 0x01, 0x25);
            L00E6: AddEncounter(party, 0x02, 0x25);
            L00F8: AddEncounter(party, 0x03, 0x26);
            L010A: AddEncounter(party, 0x04, 0x26);
            L011C: AddEncounter(party, 0x05, 0x25);
            L012E: return; // RETURN;
        }

        private void FnARMRAENC_1F(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0x67);
            L0011: if (JumpEqual) goto L0041;
            L0013: AddTreasure(party, 0x01F4, 0x00, 0x00, 0x00, 0x00, 0xD0);
            L0032: ShowMessage(party, String0BA2); // Dark shadows coalesce into Bugbears.
            L003F: goto L006D;
            L0041: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0x67);
            L0060: ShowMessage(party, String0BC7); // A Bugbear guards some chainmail.
            L006D: Compare(PartyCount(party), 0x0001);
            L0078: if (JumpNotEqual) goto L00A1;
            L007A: AddEncounter(party, 0x01, 0x01);
            L008C: AddEncounter(party, 0x02, 0x01);
            L009E: goto L0164;
            L00A1: Compare(PartyCount(party), 0x0002);
            L00AC: if (JumpNotEqual) goto L00F8;
            L00AE: AddEncounter(party, 0x01, 0x02);
            L00C0: AddEncounter(party, 0x02, 0x02);
            L00D2: AddEncounter(party, 0x03, 0x03);
            L00E4: AddEncounter(party, 0x04, 0x03);
            L00F6: goto L0164;
            L00F8: AddEncounter(party, 0x01, 0x02);
            L010A: AddEncounter(party, 0x02, 0x03);
            L011C: AddEncounter(party, 0x03, 0x03);
            L012E: AddEncounter(party, 0x04, 0x02);
            L0140: AddEncounter(party, 0x05, 0x04);
            L0152: AddEncounter(party, 0x06, 0x05);
            L0164: return; // RETURN;
        }

        private void FnARMRBENC_20(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0x7E);
            L0011: if (JumpEqual) goto L0042;
            L0013: AddTreasure(party, 0x0320, 0x00, 0x00, 0x00, 0xCF, 0xCD);
            L0033: ShowMessage(party, String0BE8); // You enter a roosting area for Cockatrices.
            L0040: goto L006E;
            L0042: AddTreasure(party, 0x0BB8, 0x00, 0x00, 0x00, 0x00, 0x7E);
            L0061: ShowMessage(party, String0C13); // In a Cockatrice nest you see luminous chainmail.
            L006E: Compare(PartyCount(party), 0x0001);
            L0079: if (JumpEqual) goto L0088;
            L007B: Compare(PartyCount(party), 0x0002);
            L0086: if (JumpNotEqual) goto L00AF;
            L0088: AddEncounter(party, 0x01, 0x08);
            L009A: AddEncounter(party, 0x02, 0x07);
            L00AC: goto L013C;
            L00AF: Compare(PartyCount(party), 0x0003);
            L00BA: if (JumpNotEqual) goto L00F4;
            L00BC: AddEncounter(party, 0x01, 0x07);
            L00CE: AddEncounter(party, 0x02, 0x08);
            L00E0: AddEncounter(party, 0x05, 0x09);
            L00F2: goto L013C;
            L00F4: AddEncounter(party, 0x01, 0x08);
            L0106: AddEncounter(party, 0x02, 0x09);
            L0118: AddEncounter(party, 0x05, 0x0A);
            L012A: AddEncounter(party, 0x06, 0x0A);
            L013C: return; // RETURN;
        }

        private void FnSHLDAENC_21(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0x59);
            L0011: if (JumpEqual) goto L0041;
            L0013: AddTreasure(party, 0x0064, 0x00, 0x00, 0x00, 0x00, 0xC0);
            L0032: ShowMessage(party, String0C44); // Dire Wolves encircle you.
            L003F: goto L006D;
            L0041: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x59);
            L0060: ShowMessage(party, String0C5E); // Dire Wolves seem fascinated by a shiny shield.
            L006D: Compare(PartyCount(party), 0x0001);
            L0078: if (JumpEqual) goto L0087;
            L007A: Compare(PartyCount(party), 0x0002);
            L0085: if (JumpNotEqual) goto L00BF;
            L0087: AddEncounter(party, 0x01, 0x0E);
            L0099: AddEncounter(party, 0x02, 0x0D);
            L00AB: AddEncounter(party, 0x03, 0x0F);
            L00BD: goto L0119;
            L00BF: AddEncounter(party, 0x01, 0x0F);
            L00D1: AddEncounter(party, 0x02, 0x10);
            L00E3: AddEncounter(party, 0x03, 0x10);
            L00F5: AddEncounter(party, 0x04, 0x0F);
            L0107: AddEncounter(party, 0x05, 0x11);
            L0119: return; // RETURN;
        }

        private void FnSLDBENC_22(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0x81);
            L0011: if (JumpEqual) goto L0041;
            L0013: AddTreasure(party, 0x00C8, 0x00, 0x00, 0x00, 0x00, 0xC5);
            L0032: ShowMessage(party, String0C8D); // Loud hisses alert you to danger.
            L003F: goto L006D;
            L0041: AddTreasure(party, 0x0384, 0x00, 0x00, 0x00, 0x00, 0x81);
            L0060: ShowMessage(party, String0CAE); // Lizardites move between you and a piece of armor on the floor.
            L006D: Compare(PartyCount(party), 0x0001);
            L0078: if (JumpEqual) goto L0087;
            L007A: Compare(PartyCount(party), 0x0002);
            L0085: if (JumpNotEqual) goto L00AD;
            L0087: AddEncounter(party, 0x01, 0x27);
            L0099: AddEncounter(party, 0x02, 0x28);
            L00AB: goto L00F5;
            L00AD: AddEncounter(party, 0x01, 0x27);
            L00BF: AddEncounter(party, 0x02, 0x27);
            L00D1: AddEncounter(party, 0x03, 0x28);
            L00E3: AddEncounter(party, 0x04, 0x28);
            L00F5: return; // RETURN;
        }

        private void FnKINGDOOR_23(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0xF8);
            L0011: if (JumpEqual) goto L005E;
            L0013: ShowMessage(party, String0CED); // The door is unlocked.
            L0020: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L003E: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L005C: goto L0088;
            L005E: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x00);
            L007B: ShowMessage(party, String0D03); // The door is sealed shut. You see what appears to be the bas relief of a royal ring 
            L0088: return; // RETURN;
        }

        private void FnSTRGATEM_24(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0D57); // The stairs through the north gateway lead up. The gateway to the east leads to THE GREAT CORRIDOR.
            L0010: return; // RETURN;
        }

        private void FnSTRSMESS_25(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0DBA); // The stairs past the south gateway lead up a level.
            L0010: return; // RETURN;
        }

        private void FnSTRSMESS_26(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0DED); // There are stairs through the the north gateway.
            L0010: return; // RETURN;
        }

        private void FnSTRSMESS_27(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0E1D); // There are stairs beyond the west gateway.
            L0010: return; // RETURN;
        }

        private void FnNPCCHATA_29(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0E47); // You encounter a Human Barbarian.
            L0010: ShowPortrait(party, 0x0016);
            L001D: Compare(GetRandom(party, 0x000F), 0x000C);
            L002D: if (JumpAbove) goto L004B;
            L002F: ShowMessage(party, String0E68); // The opening and closing of secret doors in this area give me a headache. I simply cannot puzzle out the correct sequence of opening the doors. I wish my map of this area were more complete.
            L003C: ShowMessage(party, String0F26); // By the way, if you don't have the king's ring, you won't get anywhere in this crazy place.
            L0049: goto L0058;
            L004B: ShowMessage(party, String0F81); // The Human Barbarian pays you no attention as he puzzles over a map.
            L0058: return; // RETURN;
        }

        private void FnNPCCHATB_2A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0FC5); // You encounter a Gnome Wizard.
            L0010: ShowPortrait(party, 0x002D);
            L001D: Compare(GetRandom(party, 0x000F), 0x000A);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String0FE3); // Once you find a key in this area, seek the hidden door and follow your destiny. The door appears only when you have the right key. Where it leads I do not know.
            L003C: goto L004B;
            L003E: ShowMessage(party, String1084); // The Gnome Wizard is too intent on drawing runes in the dust to talk to you.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATC_2B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String10D0); // You encounter an Orc Knight.
            L0010: ShowPortrait(party, 0x001A);
            L001D: Compare(GetRandom(party, 0x000F), 0x0009);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String10ED); // There are many ways into King Cleowyn's Mausoleum, but few are rewarding. The most direct ways are the most challenging. Do not continue unless you have what the king demands.
            L003C: goto L004B;
            L003E: ShowMessage(party, String119D); // The Orc Knight dismisses you as low-level buffoons.
            L004B: return; // RETURN;
        }

        private void FnNPCCHATD_2C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String11D1); // You encounter a Halfling Thief.
            L0010: ShowPortrait(party, 0x0025);
            L001D: Compare(GetRandom(party, 0x000F), 0x0008);
            L002D: if (JumpAbove) goto L003E;
            L002F: ShowMessage(party, String11F1); // Beneath the king's living quarters is an area known as the Thieves' Maze. Only an experienced thief - or a hero who has a thief's skills - will pick his way through this intricate maze.
            L003C: goto L005D;
            L003E: ShowMessage(party, String12AB); // The Halfling Thief steals some gold and runs away.
            L004B: ModifyGold(party, 0xFFFFCEBA);
            L005D: return; // RETURN;
        }

    }
}
