#pragma warning disable
using XPT.WorldData;

namespace XPT.Scripts.Maps {
    class YserMap29 : AMapScript {
        // === Strings ================================================
        private const string String03FC = "The River of Eternity taps your life energy.";
        private const string String0429 = "You have died.";
        private const string String0438 = "Only the bravest adventurers explore the life-devouring River of Eternity for hidden passages.";
        private const string String0497 = "A great dwarven door appears in the wall.";
        private const string String04C1 = "Your step into lava is fatal.";
        private const string String04DF = "You locate a hidden door!";
        private const string String04F9 = "A ledge can be seen across the lava pit.";
        private const string String0522 = "A platform appears beneath your feet..";
        private const string String0549 = "You step into a lava pit and die!";
        private const string String056B = "A platform appears beneath your feet..";
        private const string String0592 = "You step into a lava pit and die!";
        private const string String05B4 = "A platform appears beneath your feet..";
        private const string String05DB = "You step into a lava pit and die!";
        private const string String05FD = "A platform appears beneath your feet..";
        private const string String0624 = "You step into a lava pit and die!";
        private const string String0646 = "The wall bursts with color!";
        private const string String0662 = "In the distance you hear a platform moving.";
        private const string String068E = "The wall bursts with color!";
        private const string String06AA = "In the distance you hear a platform moving.";
        private const string String06D6 = "The wall bursts with color!";
        private const string String06F2 = "In the distance you hear a platform moving.";
        private const string String071E = "The wall bursts with color!";
        private const string String073A = "In the distance you hear a platform moving.";
        private const string String0766 = "Perhaps there is a way for you to join your party.";
        private const string String0799 = "You enter a magnificently ornamented room, bedecked with jewels and the finely crafted metalworks of dwarf craftsmen.";
        private const string String080F = "In a small chair in the center of this royal treasure sits the Dwarf King.";
        private const string String085A = "The Dwarf King nods.";
        private const string String086F = "'Welcome strangers! ";
        private const string String0884 = "I have a quest for you, if you are brave enough!";
        private const string String08B5 = "Beyond the keyhole lava lies a gem of great value, stolen by a fiercesome Dragon.";
        private const string String0907 = "Keep the gem if you like, as our token of friendship. We ask only that you destroy this vile creature who blackmails us in return for peace.'";
        private const string String0995 = "The dwarf takes the Flex Metal and smiles broadly. 'No greater pleasure can a dwarf blacksmith have than to test the powers of a new metal.'";
        private const string String0A22 = "After a few hours working the metal, she holds up a brilliant blue sword.";
        private const string String0A6C = "'There!  My finest weapon, made from your Flex Metal.  I dub it The Wind Sword!  May it destroy your enemies at first blow!'";
        private const string String0AE9 = "The dwarf blacksmith cuts down the furnace, then turns to greet you. ";
        private const string String0B2F = "'I am a wizard swordmaker, ready to make the finest weapons from your valuable metals.  What may I build for you?'";
        private const string String0BA2 = "The dwarf blacksmith pauses briefly from her work.";
        private const string String0BD5 = "'I see you have returned!'  An expression of worry crosses her face.  'Oh, I hope The Wind Sword has given you no trouble.'";
        private const string String0C51 = "She then notices the great blue sword.  'Ah, it's in fine shape!";
        private const string String0C92 = "If you find other types of metals, I will gladly make you another weapon!'";
        private const string String0CDD = "The room you enter contains furnaces, hammers and anvils.";
        private const string String0D17 = "In a corner is a dwarf blacksmith, hard at work on her latest golden creation.";
        private const string String0D66 = "A mean, twisted smile appears across the face of the dwarf blacksmith.";
        private const string String0DAD = "'You have killed the cyclop!  My gold caves are won!";
        private const string String0DE2 = "Hmmph.  It is my debt to repay you.  And I shall!'";
        private const string String0E15 = "A few hours pass as the blacksmith weaves a magnificent treasure from golden threads.  Then she appears again.";
        private const string String0E84 = "'Here.  My proudest work!  A golden boat that can ride the rainbows.  May you find treasure wherever you go.'";
        private const string String0EF2 = "Then she scoots away.";
        private const string String0F08 = "The old dwarf blacksmith at first does not hear you approach. Then she senses your presence and wheels on you. ";
        private const string String0F78 = "'A mean trick you play on a wise one!  No matter.  No doubt you're looking for another golden trinket of mine.";
        private const string String0FE7 = "Well, I will not give you any of my creations.  Never!";
        private const string String101E = "Unless, hmmm, Unless you are able to rid my gold caves of a horrible Cyclop! He fancies himself King of the Cyclops.'";
        private const string String1094 = "The dwarf miner greets you with youthful enthusiasm.";
        private const string String10C9 = "You show signs of entering my caves!  I thank-you for clearing my mines and repay you with treasure.";
        private const string String112E = "The dwarf miner smiles as you approach.";
        private const string String1156 = "'Have you found my cave yet?  It is by the water's edge.'";
        private const string String1190 = "An apprentice dwarf miner notices your arrival.";
        private const string String11C0 = "'Adventurers!  At last!  I've heard tales from the elders about your deeds.  I, too, have a cave, well hidden beyond the edges of the waters.";
        private const string String124E = "Monsters have forced me from my home. I am not strong enough to fight them.";
        private const string String129A = "Perhaps, if I give you the key to my small cave, you will do me a favor. Then I may repay you well some day.'";
        private const string String1308 = "All the east side platforms appear to be up.";
        private const string String1335 = "A glowing red gem casts a beam from under the dragon's lair.";
        private const string String1372 = "A collection of runes reveals a clue -- ";
        private const string String139B = "The Keyhole Lava lies at the center of the Kingdom.";
        private const string String13CF = "Activate the switches to the west one at a time to move a party from south to north.";
        private const string String1424 = "A faint message written in dust -- ";
        private const string String1448 = "The Keyhole Lava lies at the center of the Kingdom.";
        private const string String147C = "Repeat the sequence that moved a party south to north to move  a party north to south.";
        private const string String14D3 = "A note is found behind a rock -- ";
        private const string String14F5 = "The one who switches a party across the Keyhole Lava may join the party at the south end of a second crossing.";
        private const string String1564 = "Distant bellows from gruesome monsters echo through the cavern.";
        private const string String15A4 = "The room has been emptied.";
        private const string String15BF = "You find a key to the Cyclop's Mine on the floor.";
        private const string String15F1 = "You found a hidden door!";
        private const string String160A = "You found a hidden door!";
        private const string String1623 = "You drink from the Fountain of Attributes and feel your powers greatly increase.";
        private const string String1674 = "The waters of the Fountain of Attributes quench your thirst but do not otherwise affect you.";
        private const string String16D1 = "A passageway leads up to the elfin lands.";
        
        // === Functions ================================================
        protected override MapEventHandler MapEvent01 => FnRIVER_01;
        private void FnRIVER_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String03FC); // The River of Eternity taps your life energy.
            L0010: UnknownFunctionC4(party);
            L0018: ax = GetMaxHits74(party);
            L001F: bx = 0x0004;
            L0022: dx = ax % bx; ax = ax / bx; // (signed, dx = quotient)
            L0025: DoDamage90(party, ax);
            L002F: ax = GetCurrentHits70(party);
            L0036: RefreshCompareFlags(ax);
            L0038: if (CompareResultUnsignedGreaterThan) goto L0047;
            L003A: ShowMessage(party, String0429); // You have died.
            L0047: return; // RETURN;
        }

        protected override MapEventHandler MapEvent02 => FnRIVRBANK_02;
        private void FnRIVRBANK_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0438); // Only the bravest adventurers explore the life-devouring River of Eternity for hidden passages.
            L0010: return; // RETURN;
        }

        protected override MapEventHandler MapEvent03 => FnSECDOORA_03;
        private void FnSECDOORA_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xD4, 0xD4);
            L0016: if (!CompareResultEqual) goto L002D;
            L0018: ax = CheckState04(party, 0x02, 0x6C);
            L0029: RefreshCompareFlags(ax);
            L002B: if (CompareResultEqual) goto L0093;
            L002D: RemoveItem4C(party, 0xD4);
            L0039: SetState00(party, 0x02, 0x6C, 0x01);
            L004E: PushStack(0x01);
            L0052: ax = GetFacing24(party);
            L0059: PushStack(ax);
            L005A: ax = GetNextTile20(party);
            L0061: PushStack(ax);
            L0062: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L006C: PushStack(0x01);
            L0070: ax = GetNextTile20(party);
            L0077: PushStack(ax);
            L0078: PushStack(0x01);
            L007C: SetUnblocked30(party);
            L0086: ShowMessage(party, String0497); // A great dwarven door appears in the wall.
            L0093: return; // RETURN;
        }

        protected override MapEventHandler MapEvent04 => FnLAVA_04;
        private void FnLAVA_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String04C1); // Your step into lava is fatal.
            L0010: ax = GetMaxHits74(party);
            L0017: DoDamage90(party, ax);
            L0021: return; // RETURN;
        }

        protected override MapEventHandler MapEvent05 => FnSECDOORB_05;
        private void FnSECDOORB_05(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L000F: Compare(ax, 0x000B);
            L0012: if (CompareResultAbove || CompareResultEqual) goto L004E;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (!CompareResultEqual) goto L004E;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (!CompareResultEqual) goto L004E;
            L0039: ax = UsedItem54(party, 0xBE, 0xBE);
            L004C: if (CompareResultEqual) goto L0099;
            L004E: PushStack(0x01);
            L0052: ax = GetFacing24(party);
            L0059: PushStack(ax);
            L005A: ax = GetNextTile20(party);
            L0061: PushStack(ax);
            L0062: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L006C: ax = GetFacing24(party);
            L0073: PushStack(ax);
            L0074: ax = GetNextTile20(party);
            L007B: PushStack(ax);
            L007C: PushStack(0x01);
            L0080: SetUnblocked30(party);
            L008A: ShowMessage(party, String04DF); // You locate a hidden door!
            L0097: goto L00B6;
            L0099: PushStack(0x00);
            L009C: ax = GetFacing24(party);
            L00A3: PushStack(ax);
            L00A4: ax = GetNextTile20(party);
            L00AB: PushStack(ax);
            L00AC: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L00B6: return; // RETURN;
        }

        protected override MapEventHandler MapEvent06 => FnLAVALEDG_06;
        private void FnLAVALEDG_06(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String04F9); // A ledge can be seen across the lava pit.
            L0010: return; // RETURN;
        }

        protected override MapEventHandler MapEvent07 => FnLAVAPA_07;
        private void FnLAVAPA_07(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x03);
            L0014: Compare(ax, 0x0001);
            L0017: if (CompareResultEqual) goto L002F;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0005);
            L002D: if (!CompareResultEqual) goto L0080;
            L002F: ShowMessage(party, String0522); // A platform appears beneath your feet..
            L003C: SetMove38(party, 0x00, 0xA8);
            L004C: SetMove34(party, 0xA8, 0x01);
            L005D: SetMove38(party, 0x00, 0x79);
            L006D: SetMove34(party, 0x79, 0x01);
            L007E: goto L009E;
            L0080: ShowMessage(party, String0549); // You step into a lava pit and die!
            L008D: ax = GetMaxHits74(party);
            L0094: DoDamage90(party, ax);
            L009E: return; // RETURN;
        }

        protected override MapEventHandler MapEvent08 => FnLAVAPB_08;
        private void FnLAVAPB_08(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x03);
            L0014: Compare(ax, 0x0002);
            L0017: if (CompareResultEqual) goto L002F;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0005);
            L002D: if (!CompareResultEqual) goto L0080;
            L002F: ShowMessage(party, String056B); // A platform appears beneath your feet..
            L003C: SetMove38(party, 0x00, 0x98);
            L004C: SetMove34(party, 0x98, 0x01);
            L005D: SetMove38(party, 0x00, 0x89);
            L006D: SetMove34(party, 0x89, 0x01);
            L007E: goto L009E;
            L0080: ShowMessage(party, String0592); // You step into a lava pit and die!
            L008D: ax = GetMaxHits74(party);
            L0094: DoDamage90(party, ax);
            L009E: return; // RETURN;
        }

        protected override MapEventHandler MapEvent09 => FnLAVAPC_09;
        private void FnLAVAPC_09(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x03);
            L0014: Compare(ax, 0x0003);
            L0017: if (CompareResultEqual) goto L002F;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0005);
            L002D: if (!CompareResultEqual) goto L0080;
            L002F: ShowMessage(party, String05B4); // A platform appears beneath your feet..
            L003C: SetMove38(party, 0x00, 0x88);
            L004C: SetMove34(party, 0x88, 0x01);
            L005D: SetMove38(party, 0x00, 0x99);
            L006D: SetMove34(party, 0x99, 0x01);
            L007E: goto L009E;
            L0080: ShowMessage(party, String05DB); // You step into a lava pit and die!
            L008D: ax = GetMaxHits74(party);
            L0094: DoDamage90(party, ax);
            L009E: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0A => FnLAVAPD_0A;
        private void FnLAVAPD_0A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x03);
            L0014: Compare(ax, 0x0004);
            L0017: if (CompareResultEqual) goto L002F;
            L0019: ax = CheckState04(party, 0x01, 0x03);
            L002A: Compare(ax, 0x0005);
            L002D: if (!CompareResultEqual) goto L0080;
            L002F: ShowMessage(party, String05FD); // A platform appears beneath your feet..
            L003C: SetMove38(party, 0x00, 0x78);
            L004C: SetMove34(party, 0x78, 0x01);
            L005D: SetMove38(party, 0x00, 0xA9);
            L006D: SetMove34(party, 0xA9, 0x01);
            L007E: goto L009E;
            L0080: ShowMessage(party, String0624); // You step into a lava pit and die!
            L008D: ax = GetMaxHits74(party);
            L0094: DoDamage90(party, ax);
            L009E: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0B => FnLAVASWA_0B;
        private void FnLAVASWA_0B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0646); // The wall bursts with color!
            L0010: ShowMessage(party, String0662); // In the distance you hear a platform moving.
            L001D: SetState00(party, 0x01, 0x03, 0x01);
            L0032: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0C => FnLAVASWB_0C;
        private void FnLAVASWB_0C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String068E); // The wall bursts with color!
            L0010: ShowMessage(party, String06AA); // In the distance you hear a platform moving.
            L001D: SetState00(party, 0x01, 0x03, 0x02);
            L0032: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0D => FnLAVASWC_0D;
        private void FnLAVASWC_0D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06D6); // The wall bursts with color!
            L0010: ShowMessage(party, String06F2); // In the distance you hear a platform moving.
            L001D: SetState00(party, 0x01, 0x03, 0x03);
            L0032: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0E => FnLAVASWD_0E;
        private void FnLAVASWD_0E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String071E); // The wall bursts with color!
            L0010: ShowMessage(party, String073A); // In the distance you hear a platform moving.
            L001D: ShowMessage(party, String0766); // Perhaps there is a way for you to join your party.
            L002A: SetState00(party, 0x01, 0x03, 0x04);
            L003F: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0F => FnKINGROOM_0F;
        private void FnKINGROOM_0F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0799); // You enter a magnificently ornamented room, bedecked with jewels and the finely crafted metalworks of dwarf craftsmen.
            L0010: ShowMessage(party, String080F); // In a small chair in the center of this royal treasure sits the Dwarf King.
            L001D: return; // RETURN;
        }

        protected override MapEventHandler MapEvent10 => FnDWARKING_10;
        private void FnDWARKING_10(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xF4);
            L0011: if (!CompareResultEqual) goto L0061;
            L0013: ShowPortrait(party, 0x001C);
            L0020: ShowMessage(party, String085A); // The Dwarf King nods.
            L002D: ShowMessage(party, String086F); // 'Welcome strangers! 
            L003A: ShowMessage(party, String0884); // I have a quest for you, if you are brave enough!
            L0047: ShowMessage(party, String08B5); // Beyond the keyhole lava lies a gem of great value, stolen by a fiercesome Dragon.
            L0054: ShowMessage(party, String0907); // Keep the gem if you like, as our token of friendship. We ask only that you destroy this vile creature who blackmails us in return for peace.'
            L0061: return; // RETURN;
        }

        protected override MapEventHandler MapEvent11 => FnFLEXSWOR_11;
        private void FnFLEXSWOR_11(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x002C);
            L0010: ax = HasItem50(party, 0x09);
            L001E: if (!CompareResultEqual) goto L008D;
            L0020: ax = HasItem50(party, 0xF0);
            L002E: if (CompareResultEqual) goto L0071;
            L0030: ShowMessage(party, String0995); // The dwarf takes the Flex Metal and smiles broadly. 'No greater pleasure can a dwarf blacksmith have than to test the powers of a new metal.'
            L003D: ShowMessage(party, String0A22); // After a few hours working the metal, she holds up a brilliant blue sword.
            L004A: ShowMessage(party, String0A6C); // 'There!  My finest weapon, made from your Flex Metal.  I dub it The Wind Sword!  May it destroy your enemies at first blow!'
            L0057: RemoveItem4C(party, 0xF0);
            L0063: GiveItem48(party, 0x09);
            L006F: goto L008B;
            L0071: ShowMessage(party, String0AE9); // The dwarf blacksmith cuts down the furnace, then turns to greet you. 
            L007E: ShowMessage(party, String0B2F); // 'I am a wizard swordmaker, ready to make the finest weapons from your valuable metals.  What may I build for you?'
            L008B: goto L00C1;
            L008D: ShowMessage(party, String0BA2); // The dwarf blacksmith pauses briefly from her work.
            L009A: ShowMessage(party, String0BD5); // 'I see you have returned!'  An expression of worry crosses her face.  'Oh, I hope The Wind Sword has given you no trouble.'
            L00A7: ShowMessage(party, String0C51); // She then notices the great blue sword.  'Ah, it's in fine shape!
            L00B4: ShowMessage(party, String0C92); // If you find other types of metals, I will gladly make you another weapon!'
            L00C1: return; // RETURN;
        }

        protected override MapEventHandler MapEvent12 => FnBLAKSMTH_12;
        private void FnBLAKSMTH_12(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0CDD); // The room you enter contains furnaces, hammers and anvils.
            L0010: ShowMessage(party, String0D17); // In a corner is a dwarf blacksmith, hard at work on her latest golden creation.
            L001D: return; // RETURN;
        }

        protected override MapEventHandler MapEvent13 => FnCYCLQUST_13;
        private void FnCYCLQUST_13(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x002C);
            L0010: ax = HasItem50(party, 0xF3);
            L001E: if (CompareResultEqual) goto L0023;
            L0020: goto L00DD;
            L0023: ax = HasItem50(party, 0xF1);
            L0031: if (CompareResultEqual) goto L0099;
            L0033: ShowMessage(party, String0D66); // A mean, twisted smile appears across the face of the dwarf blacksmith.
            L0040: ShowMessage(party, String0DAD); // 'You have killed the cyclop!  My gold caves are won!
            L004D: ShowMessage(party, String0DE2); // Hmmph.  It is my debt to repay you.  And I shall!'
            L005A: ShowMessage(party, String0E15); // A few hours pass as the blacksmith weaves a magnificent treasure from golden threads.  Then she appears again.
            L0067: ShowMessage(party, String0E84); // 'Here.  My proudest work!  A golden boat that can ride the rainbows.  May you find treasure wherever you go.'
            L0074: ShowMessage(party, String0EF2); // Then she scoots away.
            L0081: RemoveItem4C(party, 0xF1);
            L008D: GiveItem48(party, 0xF3);
            L0099: ax = HasItem50(party, 0xF1);
            L00A7: if (!CompareResultEqual) goto L00DD;
            L00A9: ShowMessage(party, String0F08); // The old dwarf blacksmith at first does not hear you approach. Then she senses your presence and wheels on you. 
            L00B6: ShowMessage(party, String0F78); // 'A mean trick you play on a wise one!  No matter.  No doubt you're looking for another golden trinket of mine.
            L00C3: ShowMessage(party, String0FE7); // Well, I will not give you any of my creations.  Never!
            L00D0: ShowMessage(party, String101E); // Unless, hmmm, Unless you are able to rid my gold caves of a horrible Cyclop! He fancies himself King of the Cyclops.'
            L00DD: return; // RETURN;
        }

        protected override MapEventHandler MapEvent14 => FnMNRPLATC_14;
        private void FnMNRPLATC_14(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0023);
            L0010: ax = CheckState04(party, 0x02, 0x6F);
            L0021: RefreshCompareFlags(ax);
            L0023: if (CompareResultEqual) goto L008F;
            L0025: ShowMessage(party, String1094); // The dwarf miner greets you with youthful enthusiasm.
            L0032: ax = CheckState04(party, 0x02, 0x6B);
            L0043: RefreshCompareFlags(ax);
            L0045: if (!CompareResultEqual) goto L008D;
            L0047: SetState00(party, 0x02, 0x6B, 0x01);
            L005C: ShowMessage(party, String10C9); // You show signs of entering my caves!  I thank-you for clearing my mines and repay you with treasure.
            L0069: GiveItem48(party, 0xBA);
            L0075: GiveItem48(party, 0xBA);
            L0081: GiveItem48(party, 0xBA);
            L008D: goto L00FB;
            L008F: ax = HasItem50(party, 0xD7);
            L009D: if (CompareResultEqual) goto L00BB;
            L009F: ShowMessage(party, String112E); // The dwarf miner smiles as you approach.
            L00AC: ShowMessage(party, String1156); // 'Have you found my cave yet?  It is by the water's edge.'
            L00B9: goto L00FB;
            L00BB: ShowMessage(party, String1190); // An apprentice dwarf miner notices your arrival.
            L00C8: ShowMessage(party, String11C0); // 'Adventurers!  At last!  I've heard tales from the elders about your deeds.  I, too, have a cave, well hidden beyond the edges of the waters.
            L00D5: ShowMessage(party, String124E); // Monsters have forced me from my home. I am not strong enough to fight them.
            L00E2: ShowMessage(party, String129A); // Perhaps, if I give you the key to my small cave, you will do me a favor. Then I may repay you well some day.'
            L00EF: GiveItem48(party, 0xD7);
            L00FB: return; // RETURN;
        }

        protected override MapEventHandler MapEvent15 => FnNSTYOGRE_15;
        private void FnNSTYOGRE_15(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x14);
            L0015: AddEncounter(party, 0x02, 0x14);
            L0027: AddEncounter(party, 0x03, 0x14);
            L0039: AddEncounter(party, 0x04, 0x14);
            L004B: AddEncounter(party, 0x05, 0x14);
            L005D: AddEncounter(party, 0x06, 0x14);
            L006F: return; // RETURN;
        }

        protected override MapEventHandler MapEvent16 => FnOPENER_16;
        private void FnOPENER_16(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetState00(party, 0x01, 0x03, 0x05);
            L0018: ShowMessage(party, String1308); // All the east side platforms appear to be up.
            L0025: SetMove38(party, 0x00, 0xA9);
            L0035: SetMove34(party, 0xA9, 0x01);
            L0046: SetMove38(party, 0x00, 0x99);
            L0056: SetMove34(party, 0x99, 0x01);
            L0067: SetMove38(party, 0x00, 0x89);
            L0077: SetMove34(party, 0x89, 0x01);
            L0088: SetMove38(party, 0x00, 0x79);
            L0098: SetMove34(party, 0x79, 0x01);
            L00A9: return; // RETURN;
        }

        protected override MapEventHandler MapEvent17 => FnOPENEE_17;
        private void FnOPENEE_17(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x01, 0x03);
            L0014: Compare(ax, 0x0005);
            L0017: if (!CompareResultEqual) goto L004D;
            L0019: PushStack(0x03);
            L001D: ax = GetNextTile20(party);
            L0024: PushStack(ax);
            L0025: PushStack(0x01);
            L0029: SetUnblocked30(party);
            L0033: PushStack(0x01);
            L0037: PushStack(0x03);
            L003B: ax = GetNextTile20(party);
            L0042: PushStack(ax);
            L0043: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L004D: return; // RETURN;
        }

        protected override MapEventHandler MapEvent18 => FnMANTICOR_18;
        private void FnMANTICOR_18(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x23);
            L0015: AddEncounter(party, 0x02, 0x24);
            L0027: AddEncounter(party, 0x03, 0x24);
            L0039: AddEncounter(party, 0x04, 0x23);
            L004B: AddEncounter(party, 0x05, 0x19);
            L005D: AddEncounter(party, 0x06, 0x19);
            L006F: return; // RETURN;
        }

        protected override MapEventHandler MapEvent19 => FnBASILISK_19;
        private void FnBASILISK_19(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x11);
            L0015: AddEncounter(party, 0x02, 0x11);
            L0027: AddEncounter(party, 0x03, 0x12);
            L0039: AddEncounter(party, 0x04, 0x12);
            L004B: AddEncounter(party, 0x05, 0x13);
            L005D: AddEncounter(party, 0x06, 0x13);
            L006F: return; // RETURN;
        }

        protected override MapEventHandler MapEvent1A => FnKINGGOBL_1A;
        private void FnKINGGOBL_1A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x04);
            L0015: AddEncounter(party, 0x02, 0x04);
            L0027: AddEncounter(party, 0x03, 0x04);
            L0039: AddEncounter(party, 0x04, 0x04);
            L004B: AddEncounter(party, 0x05, 0x06);
            L005D: AddEncounter(party, 0x06, 0x06);
            L006F: return; // RETURN;
        }

        protected override MapEventHandler MapEvent1B => FnDRAGON_1B;
        private void FnDRAGON_1B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x06);
            L0015: AddEncounter(party, 0x02, 0x06);
            L0027: AddEncounter(party, 0x03, 0x19);
            L0039: AddEncounter(party, 0x04, 0x19);
            L004B: AddEncounter(party, 0x05, 0x1B);
            L005D: AddEncounter(party, 0x06, 0x13);
            L006F: ax = HasItem50(party, 0xF4);
            L007D: if (CompareResultEqual) goto L00A1;
            L007F: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0xC6, 0xB7);
            L009F: goto L00D0;
            L00A1: ShowMessage(party, String1335); // A glowing red gem casts a beam from under the dragon's lair.
            L00AE: AddTreasure(party, 0x2328, 0x00, 0x14, 0xD0, 0xD0, 0xF4);
            L00D0: return; // RETURN;
        }

        protected override MapEventHandler MapEvent1C => FnKEYCLUEA_1C;
        private void FnKEYCLUEA_1C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1372); // A collection of runes reveals a clue -- 
            L0010: ShowRunes(party, String139B); // The Keyhole Lava lies at the center of the Kingdom.
            L001D: ShowRunes(party, String13CF); // Activate the switches to the west one at a time to move a party from south to north.
            L002A: return; // RETURN;
        }

        protected override MapEventHandler MapEvent1D => FnKEYCLUEB_1D;
        private void FnKEYCLUEB_1D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1424); // A faint message written in dust -- 
            L0010: ShowRunes(party, String1448); // The Keyhole Lava lies at the center of the Kingdom.
            L001D: ShowRunes(party, String147C); // Repeat the sequence that moved a party south to north to move  a party north to south.
            L002A: return; // RETURN;
        }

        protected override MapEventHandler MapEvent1E => FnKEYCLUEC_1E;
        private void FnKEYCLUEC_1E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String14D3); // A note is found behind a rock -- 
            L0010: ShowRunes(party, String14F5); // The one who switches a party across the Keyhole Lava may join the party at the south end of a second crossing.
            L001D: return; // RETURN;
        }

        protected override MapEventHandler MapEvent1F => FnGATEA_1F;
        private void FnGATEA_1F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1564); // Distant bellows from gruesome monsters echo through the cavern.
            L0010: SetMoveMap(party, 0x38, 0x02, 0x30, 0x02);
            L002B: return; // RETURN;
        }

        protected override MapEventHandler MapEvent20 => FnCYCLKEY_20;
        private void FnCYCLKEY_20(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xD6);
            L0011: if (CompareResultEqual) goto L0022;
            L0013: ShowMessage(party, String15A4); // The room has been emptied.
            L0020: goto L003B;
            L0022: GiveItem48(party, 0xD6);
            L002E: ShowMessage(party, String15BF); // You find a key to the Cyclop's Mine on the floor.
            L003B: return; // RETURN;
        }

        protected override MapEventHandler MapEvent21 => FnSECDOORC_21;
        private void FnSECDOORC_21(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetRace78(party);
            L000A: Compare(ax, 0x0004);
            L000D: if (CompareResultEqual) goto L0012;
            L000F: goto L00C8;
            L0012: ax = UsedSkill58(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L001E: Compare(ax, 0x0008);
            L0021: if (CompareResultAbove || CompareResultEqual) goto L005D;
            L0023: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L002F: RefreshCompareFlags(ax);
            L0031: if (!CompareResultEqual) goto L005D;
            L0033: ax = UsedItem54(party, 0xA2, 0xA2);
            L0046: if (!CompareResultEqual) goto L005D;
            L0048: ax = UsedItem54(party, 0xBE, 0xBE);
            L005B: if (CompareResultEqual) goto L00A8;
            L005D: PushStack(0x01);
            L0061: ax = GetFacing24(party);
            L0068: PushStack(ax);
            L0069: ax = GetNextTile20(party);
            L0070: PushStack(ax);
            L0071: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L007B: ax = GetFacing24(party);
            L0082: PushStack(ax);
            L0083: ax = GetNextTile20(party);
            L008A: PushStack(ax);
            L008B: PushStack(0x01);
            L008F: SetUnblocked30(party);
            L0099: ShowMessage(party, String15F1); // You found a hidden door!
            L00A6: goto L00C5;
            L00A8: PushStack(0x00);
            L00AB: ax = GetFacing24(party);
            L00B2: PushStack(ax);
            L00B3: ax = GetNextTile20(party);
            L00BA: PushStack(ax);
            L00BB: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L00C5: goto L017B;
            L00C8: ax = UsedSkill58(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L00D4: Compare(ax, 0x000B);
            L00D7: if (CompareResultAbove || CompareResultEqual) goto L0113;
            L00D9: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L00E5: RefreshCompareFlags(ax);
            L00E7: if (!CompareResultEqual) goto L0113;
            L00E9: ax = UsedItem54(party, 0xA2, 0xA2);
            L00FC: if (!CompareResultEqual) goto L0113;
            L00FE: ax = UsedItem54(party, 0xBE, 0xBE);
            L0111: if (CompareResultEqual) goto L015E;
            L0113: PushStack(0x01);
            L0117: ax = GetFacing24(party);
            L011E: PushStack(ax);
            L011F: ax = GetNextTile20(party);
            L0126: PushStack(ax);
            L0127: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0131: ax = GetFacing24(party);
            L0138: PushStack(ax);
            L0139: ax = GetNextTile20(party);
            L0140: PushStack(ax);
            L0141: PushStack(0x01);
            L0145: SetUnblocked30(party);
            L014F: ShowMessage(party, String160A); // You found a hidden door!
            L015C: goto L017B;
            L015E: PushStack(0x00);
            L0161: ax = GetFacing24(party);
            L0168: PushStack(ax);
            L0169: ax = GetNextTile20(party);
            L0170: PushStack(ax);
            L0171: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L017B: return; // RETURN;
        }

        protected override MapEventHandler MapEvent25 => FnFNTNATTR_25;
        private void FnFNTNATTR_25(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x56);
            L0014: RefreshCompareFlags(ax);
            L0016: if (!CompareResultEqual) goto L006C;
            L0018: SetState00(party, 0x02, 0x56, 0x01);
            L002D: ShowPortrait(party, 0x0042);
            L003A: ModifyAttributeA8(party, 0x00, 0x0002);
            L004B: ModifyAttributeA8(party, 0x01, 0x0001);
            L005D: ShowMessage(party, String1623); // You drink from the Fountain of Attributes and feel your powers greatly increase.
            L006A: goto L0086;
            L006C: ShowPortrait(party, 0x0042);
            L0079: ShowMessage(party, String1674); // The waters of the Fountain of Attributes quench your thirst but do not otherwise affect you.
            L0086: return; // RETURN;
        }

        protected override MapEventHandler MapEvent26 => FnNSTYGIAN_26;
        private void FnNSTYGIAN_26(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x1E);
            L0015: AddEncounter(party, 0x02, 0x1E);
            L0027: AddEncounter(party, 0x03, 0x1E);
            L0039: AddEncounter(party, 0x04, 0x1E);
            L004B: AddEncounter(party, 0x05, 0x1E);
            L005D: AddEncounter(party, 0x06, 0x1E);
            L006F: return; // RETURN;
        }

        protected override MapEventHandler MapEvent27 => FnMAINGIAN_27;
        private void FnMAINGIAN_27(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x1F);
            L0015: AddEncounter(party, 0x02, 0x1F);
            L0027: AddEncounter(party, 0x03, 0x1E);
            L0039: AddEncounter(party, 0x04, 0x1E);
            L004B: AddEncounter(party, 0x05, 0x20);
            L005D: AddEncounter(party, 0x06, 0x1F);
            L006F: return; // RETURN;
        }

        protected override MapEventHandler MapEvent2C => FnTOELVES_2C;
        private void FnTOELVES_2C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String16D1); // A passageway leads up to the elfin lands.
            L0010: SetMoveMap(party, 0x37, 0x01, 0x7F, 0x01);
            L002B: return; // RETURN;
        }

    }
}
