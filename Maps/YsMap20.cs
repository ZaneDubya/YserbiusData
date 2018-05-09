#pragma warning disable
using XPT.WorldData;

namespace XPT.Scripts.Maps {
    class YserMap20 : AMapScript {
        protected override int MapIndex => 20;
        // === Strings ================================================
        private const string String03FC = "You step into nothingness...";
        private const string String0419 = "                                         ...and die!";
        private const string String044E = "Cast in shadowy blue light, the tunnels of MOON HOLLOW are a nexus to more dangerous locations.";
        private const string String04AE = "Well worn trails greet those who dare travel the corridors of the ZEPHYR.";
        private const string String04F8 = "Dry desert winds parch your throat as you peer down the winding passages leading to ZZYZX.";
        private const string String0553 = "A brave step..";
        private const string String0562 = "Death does not greet you now, but it will perhaps when you meet the DRAGONS OF THE LEAP.";
        private const string String05BB = "You drop into TORBRIAR'S TREASURE.";
        private const string String05DE = "An inscription on the wall reads...";
        private const string String0602 = "'We, the Knights of Torbriar, build this shrine to celebrate WarMaster Torbriar's stunning victory over the armies of Ogres and Trolls.'";
        private const string String068B = "You land squarely in the center of MOON HOLLOW!";
        private const string String06BB = "The howling of winds screams harsh against the blue light of a fool moon.";
        private const string String0705 = "You drop into MAGES OVERLOOK.";
        private const string String0723 = "Mages found this plateau useful for looking out over the labyrinth denizens following the great cataclysm.";
        private const string String078E = "The North Wind blows a wintry chill.";
        private const string String07B3 = "Warriors of the East Wind challenge you.";
        private const string String07DC = "Monsters materialize from the South Wind.";
        private const string String0806 = "The fury of the West Wind is upon you.";
        private const string String082D = "The North Wind is the first to be defeated.";
        private const string String0859 = "The North Wind has been quieted.";
        private const string String087A = "The East Wind is the first to be defeated.";
        private const string String08A5 = "The East Wind has been quieted.";
        private const string String08C5 = "The South Wind is the first to be defeated.";
        private const string String08F1 = "The South Wind has been quieted.";
        private const string String0912 = "The West Wind is the first to be defeated.";
        private const string String093D = "The West Wind has been quieted.";
        private const string String095D = "This wall is the teleport to CASTLEGATE.";
        private const string String0986 = "There is something strange about this wall.";
        private const string String09B2 = "You enter the Labyrinths of the Winds.";
        private const string String09D9 = "A network of tunnels seems to wind its way past pits and lava.";
        private const string String0A18 = "Wyn's Fountain is old and cracked.";
        private const string String0A3B = "A small puddle of magic water sits at the bottom.";
        private const string String0A6D = "It seems to instantly evaporate into a large steam cloud.";
        private const string String0AA7 = "You feel you may be quicker in a fight.";
        private const string String0ACF = "The basin is dust dry.";
        private const string String0AE6 = "A twisting passage to the east offers a quick way to the entrance.";
        private const string String0B29 = "You discover the back entrance to the THIEVES' DEN.";
        private const string String0B5D = "You stumble into the lava pools and die.";
        private const string String0B86 = "Well worn trails greet those who dare travel the windswept corridors of the ZEPHYR.";
        private const string String0BDA = "Skeletal voices echo...";
        private const string String0BF2 = "'The four winds have been defeated!!!!";
        private const string String0C19 = "ARGGG!  We cannot hold you back.  You are indeed a powerful force!!";
        private const string String0C5D = "Enter the WIND KNIGHTS' TOMB if you dare, but if you have any honor, do not disturb our bones.'";
        private const string String0CBD = "'Only Forces more powerful than all four winds can open this door!'";
        private const string String0D01 = "Welcome to LABYRINTH ATTIC!";
        private const string String0D1D = "Refresh yourself in the fountains nearby.  But do not take long!";
        private const string String0D5E = "Bands of travelers rest here before exploring the Wind Labyrinths.";
        private const string String0DA1 = "The door is unlocked.";
        private const string String0DB7 = "The soft breezes seem to whisper - 'Beware, those who seek the treasure of WIND KNIGHTS' TOMB.'";
        private const string String0E17 = "Winds pound furiously at the door.";
        private const string String0E3A = "The feeble survivors of Arnakkian's Experiment harbored hatred toward those who found home in the WYN SANCTUARY.";
        private const string String0EAB = "A Gremlin Cleric Appears";
        private const string String0EC4 = "'Take my advice - Jump only into the pits with floors beneath them.";
        private const string String0F08 = "That is the way of the Labyrinth.'";
        private const string String0F2B = "A message is etched in stone -- ";
        private const string String0F4C = "'The last of Arnakkian's Knights have been buried.  ";
        private const string String0F81 = "At last I can tell my secret!  I watched as Arnakkian challenged the Time Elemental En-Li-Kil and lost.";
        private const string String0FE9 = "His greed for immortality cursed us all.' -- Morgard, ArchCleric";
        private const string String102A = "The Four Winds gather strength once again as they throw skeletal bones against the wall.";
        private const string String1083 = "Monsters form out of the dust and winds.";
        private const string String10AC = "In the midst of sleeping Hobgoblins, a small tempest swirls.  It whispers that one's treasure comes from the directions of the winds.";
        private const string String1132 = "Then the tempest roars into a nightmare and wakens the hobgoblins.";
        private const string String1175 = "Sleeping adventurers are disturbed.";
        private const string String1199 = "A dark corner hides an unlikely mix of beasts.";
        private const string String11C8 = "Sirocco's powers no longer hold the Sirocco Door.";
        private const string String11FA = "Sirocco's powers no longer hold this door.  It is open.";
        private const string String1232 = "Sirocco's Door does not open.  In the distance, a wizard laughs aloud.";
        private const string String1279 = "'It is I, Sirocco, who bars your way!'";
        private const string String12A0 = "Sirocco, the wind labyrinth doorkeeper, materializes in the room.";
        private const string String12E2 = "'You dare challenge the winds??!";
        private const string String1303 = "You force the massive door open by sheer muscle power.";
        private const string String133A = "The door is stuck. You are not strong enough to force it open.";
        private const string String1379 = "A nest of dragons sneers at you. 'The Sanctuary belongs to us!'";
        private const string String13B9 = "A band of sanctuary guards are alerted.";
        private const string String13E1 = "Your path is blocked.";
        private const string String13F7 = "Adventurers are disturbed.  'We are cursed to kill those who have seen our fate.'";
        private const string String1449 = "Stuffed behind a rock, you find a magical note that reads... ";
        private const string String1487 = "'Red, Yellow, Green and Blue.  That is the order of the gems.'";
        private const string String14C6 = "-- signed last Wyn Survivor, Kanasgwyn.";
        private const string String14EE = "Commanders of the Wyn Ogres have set up camp here.";
        private const string String1521 = "You found a secret door!";
        private const string String153A = "A message is inscribed on stone -- ";
        private const string String155E = "'Labyrinth and lower levels first explored by Arkarch of the Snow Elves.'";
        private const string String15A8 = "Apprentice thieves jump you!  'We must earn our dues!'";
        private const string String15DF = "Your many wounds and lingering diseases are removed by the sweet waters of WindyBless Fountain.";
        private const string String163F = "The mystic waters of the NightWillow Fountain restore your Mana level.";
        private const string String1686 = "You stumble into a den of angry monsters.";
        private const string String16B0 = "You found a secret door!";
        private const string String16C9 = "You discover a secret door!";
        private const string String16E5 = "A secret door suddenly appears!";
        private const string String1705 = "You bash the massive door open.";
        private const string String1725 = "A note -- 'The Runes suggest a path to Arnakkian's Treasure Room.'";
        private const string String1768 = "Upon the wall you see a message -- ";
        private const string String178C = "'Beneath each pit is a floor or another pit.  Fall to the floors to find more passages.'";
        private const string String17E5 = "Hobgoblins smile, then attack.";
        private const string String1804 = "A special thieves' shrine magically glows.";
        private const string String182F = "You gain the skill of Detection!";
        private const string String1850 = "You gain the skill of Lockpicking!";
        private const string String1873 = "You gain the Bard skill!";
        private const string String188C = "You gain the Pickpocketing skill!";
        private const string String18AE = "Nothing happens.";
        private const string String18BF = "The shrines does nothing.";
        private const string String18D9 = "Thieves make a desperate stand.";
        private const string String18F9 = "Master Thieves Attack!";
        private const string String1910 = "Master Thieves ready themselves.";
        private const string String1931 = "Light sparks off a key tied to the neck of the leader.";
        private const string String1968 = "A voice echoes through the winds...";
        private const string String198C = "'You have traveled well, fair adventurers!";
        private const string String19B7 = "I laughed when you troubled King Cleowyn's ghost!";
        private const string String19E9 = "But now you enter my tunnels!  Go back whence you came!";
        private const string String1A21 = "The Winds will keep these places clean.'";
        
        // === Functions ================================================
        protected override MapEventHandler MapEvent01 => FnVOID_01;
        private void FnVOID_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String03FC); // You step into nothingness...
            L0010: ShowMessage(party, String0419); //                                          ...and die!
            L001D: ax = GetMaxHits74(party);
            L0024: DoDamage90(party, ax);
            L002E: return; // RETURN;
        }

        protected override MapEventHandler MapEvent02 => FnMOONHOLO_02;
        private void FnMOONHOLO_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String044E); // Cast in shadowy blue light, the tunnels of MOON HOLLOW are a nexus to more dangerous locations.
            L0010: SetMoveMap(party, 0x34, 0x01, 0x03, 0x01);
            L002B: return; // RETURN;
        }

        protected override MapEventHandler MapEvent03 => FnZEPHYR_03;
        private void FnZEPHYR_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String04AE); // Well worn trails greet those who dare travel the corridors of the ZEPHYR.
            L0010: SetMoveMap(party, 0x34, 0x01, 0xC3, 0x03);
            L002B: return; // RETURN;
        }

        protected override MapEventHandler MapEvent04 => FnZZYZX_04;
        private void FnZZYZX_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String04F8); // Dry desert winds parch your throat as you peer down the winding passages leading to ZZYZX.
            L0010: SetMoveMap(party, 0x34, 0x01, 0x6D, 0x00);
            L002A: return; // RETURN;
        }

        protected override MapEventHandler MapEvent05 => FnDRGNLEAP_05;
        private void FnDRGNLEAP_05(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0553); // A brave step..
            L0010: ShowMessage(party, String0562); // Death does not greet you now, but it will perhaps when you meet the DRAGONS OF THE LEAP.
            L001D: SetMoveMap(party, 0x34, 0x01, 0xCB, 0x01);
            L0038: return; // RETURN;
        }

        protected override MapEventHandler MapEvent06 => FnTORBRIAR_06;
        private void FnTORBRIAR_06(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String05BB); // You drop into TORBRIAR'S TREASURE.
            L0010: ShowMessage(party, String05DE); // An inscription on the wall reads...
            L001D: ShowMessage(party, String0602); // 'We, the Knights of Torbriar, build this shrine to celebrate WarMaster Torbriar's stunning victory over the armies of Ogres and Trolls.'
            L002A: SetMoveMap(party, 0x34, 0x01, 0x35, 0x02);
            L0045: return; // RETURN;
        }

        protected override MapEventHandler MapEvent07 => FnMOONHOLO_07;
        private void FnMOONHOLO_07(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String068B); // You land squarely in the center of MOON HOLLOW!
            L0010: ShowMessage(party, String06BB); // The howling of winds screams harsh against the blue light of a fool moon.
            L001D: SetMoveMap(party, 0x34, 0x01, 0x73, 0x02);
            L0038: return; // RETURN;
        }

        protected override MapEventHandler MapEvent08 => FnMAGEOVRL_08;
        private void FnMAGEOVRL_08(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0705); // You drop into MAGES OVERLOOK.
            L0010: ShowMessage(party, String0723); // Mages found this plateau useful for looking out over the labyrinth denizens following the great cataclysm.
            L001D: SetMoveMap(party, 0x34, 0x01, 0x7A, 0x03);
            L0038: return; // RETURN;
        }

        protected override MapEventHandler MapEvent09 => FnENCWINDN_09;
        private void FnENCWINDN_09(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String078E); // The North Wind blows a wintry chill.
            L0010: AddEncounter(party, 0x01, 0x1B);
            L0022: AddEncounter(party, 0x02, 0x1B);
            L0034: AddEncounter(party, 0x03, 0x1B);
            L0046: AddEncounter(party, 0x05, 0x19);
            L0058: AddEncounter(party, 0x06, 0x1A);
            L006A: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0A => FnENCWINDE_0A;
        private void FnENCWINDE_0A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String07B3); // Warriors of the East Wind challenge you.
            L0010: AddEncounter(party, 0x01, 0x11);
            L0022: AddEncounter(party, 0x02, 0x11);
            L0034: AddEncounter(party, 0x04, 0x11);
            L0046: AddEncounter(party, 0x05, 0x19);
            L0058: AddEncounter(party, 0x06, 0x1A);
            L006A: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0B => FnENCWINDS_0B;
        private void FnENCWINDS_0B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String07DC); // Monsters materialize from the South Wind.
            L0010: AddEncounter(party, 0x01, 0x1C);
            L0022: AddEncounter(party, 0x02, 0x1C);
            L0034: AddEncounter(party, 0x03, 0x1C);
            L0046: AddEncounter(party, 0x05, 0x19);
            L0058: AddEncounter(party, 0x06, 0x1A);
            L006A: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0C => FnENCWINDW_0C;
        private void FnENCWINDW_0C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0806); // The fury of the West Wind is upon you.
            L0010: AddEncounter(party, 0x01, 0x1D);
            L0022: AddEncounter(party, 0x02, 0x1D);
            L0034: AddEncounter(party, 0x04, 0x1D);
            L0046: AddEncounter(party, 0x05, 0x1A);
            L0058: AddEncounter(party, 0x06, 0x19);
            L006A: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0D => FnFLGWINDN_0D;
        private void FnFLGWINDN_0D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = 0x0001;
            L0007: ax = CheckState04(party, 0x01, 0x01);
            L0018: RefreshCompareFlags(ax);
            L001A: if (!CompareResultEqual) goto L0070;
            L001C: ax = CheckState04(party, 0x01, 0x02);
            L002D: RefreshCompareFlags(ax);
            L002F: if (CompareResultEqual) goto L0032;
            L0031: si = si + 1;
            L0032: ax = CheckState04(party, 0x01, 0x03);
            L0043: RefreshCompareFlags(ax);
            L0045: if (CompareResultEqual) goto L0048;
            L0047: si = si + 1;
            L0048: ax = CheckState04(party, 0x01, 0x04);
            L0059: RefreshCompareFlags(ax);
            L005B: if (CompareResultEqual) goto L005E;
            L005D: si = si + 1;
            L005E: SetState00(party, 0xC4, 0xB8, si);
            L0070: ax = CheckState04(party, 0x01, 0x01);
            L0081: Compare(ax, 0x0001);
            L0084: if (CompareResultEqual) goto L0088;
            L0086: goto L0095;
            L0088: ShowMessage(party, String082D); // The North Wind is the first to be defeated.
            L0095: ShowMessage(party, String0859); // The North Wind has been quieted.
            L00A2: return; // RETURN (restoring si);
        }

        protected override MapEventHandler MapEvent0E => FnFLGWINDE_0E;
        private void FnFLGWINDE_0E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = 0x0001;
            L0007: ax = CheckState04(party, 0x01, 0x02);
            L0018: RefreshCompareFlags(ax);
            L001A: if (!CompareResultEqual) goto L0070;
            L001C: ax = CheckState04(party, 0x01, 0x01);
            L002D: RefreshCompareFlags(ax);
            L002F: if (CompareResultEqual) goto L0032;
            L0031: si = si + 1;
            L0032: ax = CheckState04(party, 0x01, 0x03);
            L0043: RefreshCompareFlags(ax);
            L0045: if (CompareResultEqual) goto L0048;
            L0047: si = si + 1;
            L0048: ax = CheckState04(party, 0x01, 0x04);
            L0059: RefreshCompareFlags(ax);
            L005B: if (CompareResultEqual) goto L005E;
            L005D: si = si + 1;
            L005E: SetState00(party, 0xC4, 0xB8, si);
            L0070: ax = CheckState04(party, 0x01, 0x02);
            L0081: Compare(ax, 0x0001);
            L0084: if (CompareResultEqual) goto L0088;
            L0086: goto L0095;
            L0088: ShowMessage(party, String087A); // The East Wind is the first to be defeated.
            L0095: ShowMessage(party, String08A5); // The East Wind has been quieted.
            L00A2: return; // RETURN (restoring si);
        }

        protected override MapEventHandler MapEvent0F => FnFLGWINDS_0F;
        private void FnFLGWINDS_0F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = 0x0001;
            L0007: ax = CheckState04(party, 0x01, 0x03);
            L0018: RefreshCompareFlags(ax);
            L001A: if (!CompareResultEqual) goto L0070;
            L001C: ax = CheckState04(party, 0x01, 0x01);
            L002D: RefreshCompareFlags(ax);
            L002F: if (CompareResultEqual) goto L0032;
            L0031: si = si + 1;
            L0032: ax = CheckState04(party, 0x01, 0x02);
            L0043: RefreshCompareFlags(ax);
            L0045: if (CompareResultEqual) goto L0048;
            L0047: si = si + 1;
            L0048: ax = CheckState04(party, 0x01, 0x04);
            L0059: RefreshCompareFlags(ax);
            L005B: if (CompareResultEqual) goto L005E;
            L005D: si = si + 1;
            L005E: SetState00(party, 0xC4, 0xB8, si);
            L0070: ax = CheckState04(party, 0x01, 0x03);
            L0081: Compare(ax, 0x0001);
            L0084: if (CompareResultEqual) goto L0088;
            L0086: goto L0095;
            L0088: ShowMessage(party, String08C5); // The South Wind is the first to be defeated.
            L0095: ShowMessage(party, String08F1); // The South Wind has been quieted.
            L00A2: return; // RETURN (restoring si);
        }

        protected override MapEventHandler MapEvent10 => FnFLGWINDW_10;
        private void FnFLGWINDW_10(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = 0x0001;
            L0007: ax = CheckState04(party, 0x01, 0x04);
            L0018: RefreshCompareFlags(ax);
            L001A: if (!CompareResultEqual) goto L0070;
            L001C: ax = CheckState04(party, 0x01, 0x01);
            L002D: RefreshCompareFlags(ax);
            L002F: if (CompareResultEqual) goto L0032;
            L0031: si = si + 1;
            L0032: ax = CheckState04(party, 0x01, 0x02);
            L0043: RefreshCompareFlags(ax);
            L0045: if (CompareResultEqual) goto L0048;
            L0047: si = si + 1;
            L0048: ax = CheckState04(party, 0x01, 0x03);
            L0059: RefreshCompareFlags(ax);
            L005B: if (CompareResultEqual) goto L005E;
            L005D: si = si + 1;
            L005E: SetState00(party, 0xC4, 0xB8, si);
            L0070: ax = CheckState04(party, 0x01, 0x04);
            L0081: Compare(ax, 0x0001);
            L0084: if (CompareResultEqual) goto L0088;
            L0086: goto L0095;
            L0088: ShowMessage(party, String0912); // The West Wind is the first to be defeated.
            L0095: ShowMessage(party, String093D); // The West Wind has been quieted.
            L00A2: return; // RETURN (restoring si);
        }

        protected override MapEventHandler MapEvent11 => FnEXPRESS_11;
        private void FnEXPRESS_11(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x57);
            L0014: RefreshCompareFlags(ax);
            L0016: if (CompareResultEqual) goto L0046;
            L0018: ShowMessage(party, String095D); // This wall is the teleport to CASTLEGATE.
            L0025: PushStack(0x03);
            L0029: ax = GetNextTile20(party);
            L0030: SetMoveMap(party, 0x36, 0x01, ax, PopStack());
            L0044: goto L0053;
            L0046: ShowMessage(party, String0986); // There is something strange about this wall.
            L0053: return; // RETURN;
        }

        protected override MapEventHandler MapEvent12 => FnTXTLABY_12;
        private void FnTXTLABY_12(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String09B2); // You enter the Labyrinths of the Winds.
            L0010: ShowMessage(party, String09D9); // A network of tunnels seems to wind its way past pits and lava.
            L001D: return; // RETURN;
        }

        protected override MapEventHandler MapEvent13 => FnWSTRES_13;
        private void FnWSTRES_13(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0A18); // Wyn's Fountain is old and cracked.
            L0010: ax = CheckState04(party, 0x02, 0x58);
            L0021: RefreshCompareFlags(ax);
            L0023: if (!CompareResultEqual) goto L0082;
            L0025: SetState00(party, 0x02, 0x58, 0x01);
            L003A: ShowPortrait(party, 0x0042);
            L0047: ModifyAttributeA8(party, 0x03, 0x0003);
            L0059: ShowMessage(party, String0A3B); // A small puddle of magic water sits at the bottom.
            L0066: ShowMessage(party, String0A6D); // It seems to instantly evaporate into a large steam cloud.
            L0073: ShowMessage(party, String0AA7); // You feel you may be quicker in a fight.
            L0080: goto L008F;
            L0082: ShowMessage(party, String0ACF); // The basin is dust dry.
            L008F: return; // RETURN;
        }

        protected override MapEventHandler MapEvent14 => FnMOUNTAIN_14;
        private void FnMOUNTAIN_14(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x01, 0x01, 0x00, 0x33);
            L001D: return; // RETURN;
        }

        protected override MapEventHandler MapEvent15 => FnTXTMNTN_15;
        private void FnTXTMNTN_15(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0AE6); // A twisting passage to the east offers a quick way to the entrance.
            L0010: return; // RETURN;
        }

        protected override MapEventHandler MapEvent16 => FnTHIEVMAZ_16;
        private void FnTHIEVMAZ_16(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0B29); // You discover the back entrance to the THIEVES' DEN.
            L0010: SetMoveMap(party, 0x05, 0x01, 0xBE, 0x01);
            L002B: return; // RETURN;
        }

        protected override MapEventHandler MapEvent17 => FnLAVA_17;
        private void FnLAVA_17(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0B5D); // You stumble into the lava pools and die.
            L0010: ax = GetMaxHits74(party);
            L0017: DoDamage90(party, ax);
            L0021: return; // RETURN;
        }

        protected override MapEventHandler MapEvent18 => FnZEPHYRB_18;
        private void FnZEPHYRB_18(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0B86); // Well worn trails greet those who dare travel the windswept corridors of the ZEPHYR.
            L0010: SetMoveMap(party, 0x34, 0x01, 0x6E, 0x01);
            L002B: return; // RETURN;
        }

        protected override MapEventHandler MapEvent19 => FnSDOORWKT_19;
        private void FnSDOORWKT_19(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0BDA); // Skeletal voices echo...
            L0010: ax = CheckState04(party, 0x01, 0x01);
            L0021: RefreshCompareFlags(ax);
            L0023: if (!CompareResultEqual) goto L0028;
            L0025: goto L00D7;
            L0028: ax = CheckState04(party, 0x01, 0x02);
            L0039: RefreshCompareFlags(ax);
            L003B: if (!CompareResultEqual) goto L0040;
            L003D: goto L00D7;
            L0040: ax = CheckState04(party, 0x01, 0x03);
            L0051: RefreshCompareFlags(ax);
            L0053: if (!CompareResultEqual) goto L0058;
            L0055: goto L00D7;
            L0058: ax = CheckState04(party, 0x01, 0x04);
            L0069: RefreshCompareFlags(ax);
            L006B: if (CompareResultEqual) goto L00D7;
            L006D: ShowPortrait(party, 0x000A);
            L007A: ShowMessage(party, String0BF2); // 'The four winds have been defeated!!!!
            L0087: ShowMessage(party, String0C19); // ARGGG!  We cannot hold you back.  You are indeed a powerful force!!
            L0094: ShowMessage(party, String0C5D); // Enter the WIND KNIGHTS' TOMB if you dare, but if you have any honor, do not disturb our bones.'
            L00A1: PushStack(0x01);
            L00A5: PushStack(0x03);
            L00A9: ax = GetNextTile20(party);
            L00B0: PushStack(ax);
            L00B1: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L00BB: PushStack(0x03);
            L00BF: ax = GetNextTile20(party);
            L00C6: PushStack(ax);
            L00C7: PushStack(0x01);
            L00CB: SetUnblocked30(party);
            L00D5: goto L00E4;
            L00D7: ShowMessage(party, String0CBD); // 'Only Forces more powerful than all four winds can open this door!'
            L00E4: return; // RETURN;
        }

        protected override MapEventHandler MapEvent1A => FnTXTCAMP_1A;
        private void FnTXTCAMP_1A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0028);
            L0010: ShowMessage(party, String0D01); // Welcome to LABYRINTH ATTIC!
            L001D: ShowMessage(party, String0D1D); // Refresh yourself in the fountains nearby.  But do not take long!
            L002A: ShowMessage(party, String0D5E); // Bands of travelers rest here before exploring the Wind Labyrinths.
            L0037: return; // RETURN;
        }

        protected override MapEventHandler MapEvent1B => FnKEYDOORW_1B;
        private void FnKEYDOORW_1B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xDD, 0xDD);
            L0016: if (CompareResultEqual) goto L0066;
            L0018: PushStack(0x01);
            L001C: PushStack(0x00);
            L001F: ax = GetNextTile20(party);
            L0026: PushStack(ax);
            L0027: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0031: PushStack(0x00);
            L0034: ax = GetNextTile20(party);
            L003B: PushStack(ax);
            L003C: PushStack(0x01);
            L0040: SetUnblocked30(party);
            L004A: ShowMessage(party, String0DA1); // The door is unlocked.
            L0057: ShowMessage(party, String0DB7); // The soft breezes seem to whisper - 'Beware, those who seek the treasure of WIND KNIGHTS' TOMB.'
            L0064: goto L0073;
            L0066: ShowMessage(party, String0E17); // Winds pound furiously at the door.
            L0073: return; // RETURN;
        }

        protected override MapEventHandler MapEvent1C => FnTXTWYNS_1C;
        private void FnTXTWYNS_1C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0E3A); // The feeble survivors of Arnakkian's Experiment harbored hatred toward those who found home in the WYN SANCTUARY.
            L0010: return; // RETURN;
        }

        protected override MapEventHandler MapEvent1D => FnPITINFO_1D;
        private void FnPITINFO_1D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x002A);
            L0010: ShowMessage(party, String0EAB); // A Gremlin Cleric Appears
            L001D: ShowMessage(party, String0EC4); // 'Take my advice - Jump only into the pits with floors beneath them.
            L002A: ShowMessage(party, String0F08); // That is the way of the Labyrinth.'
            L0037: return; // RETURN;
        }

        protected override MapEventHandler MapEvent1E => FnWKTENCA_1E;
        private void FnWKTENCA_1E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x15);
            L0015: AddEncounter(party, 0x02, 0x15);
            L0027: AddEncounter(party, 0x05, 0x1E);
            L0039: AddEncounter(party, 0x06, 0x1E);
            L004B: return; // RETURN;
        }

        protected override MapEventHandler MapEvent1F => FnWKTTEXT_1F;
        private void FnWKTTEXT_1F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0F2B); // A message is etched in stone -- 
            L0010: ShowMessage(party, String0F4C); // 'The last of Arnakkian's Knights have been buried.  
            L001D: ShowMessage(party, String0F81); // At last I can tell my secret!  I watched as Arnakkian challenged the Time Elemental En-Li-Kil and lost.
            L002A: ShowMessage(party, String0FE9); // His greed for immortality cursed us all.' -- Morgard, ArchCleric
            L0037: return; // RETURN;
        }

        protected override MapEventHandler MapEvent20 => FnWKTENCC_20;
        private void FnWKTENCC_20(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: AddEncounter(party, 0x01, 0x15);
            L001B: AddEncounter(party, 0x02, 0x15);
            L002D: AddEncounter(party, 0x03, 0x0D);
            L003F: AddEncounter(party, 0x04, 0x0D);
            L0051: AddEncounter(party, 0x05, 0x1E);
            L0063: AddEncounter(party, 0x06, 0x1E);
            L0075: ax = CheckState04(party, 0x01, 0x01);
            L0086: Compare(ax, 0x0001);
            L0089: if (!CompareResultEqual) goto L008E;
            L008B: di = 0x000E;
            L008E: ax = CheckState04(party, 0x01, 0x02);
            L009F: Compare(ax, 0x0002);
            L00A2: if (!CompareResultEqual) goto L00A7;
            L00A4: si = 0x005B;
            L00A7: ax = CheckState04(party, 0x01, 0x03);
            L00B8: Compare(ax, 0x0002);
            L00BB: if (!CompareResultEqual) goto L00C0;
            L00BD: si = 0x006F;
            L00C0: AddTreasure(party, 0x07D0, 0x00, 0x00, si, di, 0xCF);
            L00DC: return; // RETURN (restoring si);
        }

        protected override MapEventHandler MapEvent21 => FnWKTENCD_21;
        private void FnWKTENCD_21(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: AddEncounter(party, 0x01, 0x1E);
            L001B: AddEncounter(party, 0x02, 0x1E);
            L002D: AddEncounter(party, 0x05, 0x0D);
            L003F: AddEncounter(party, 0x06, 0x0D);
            L0051: ax = CheckState04(party, 0x01, 0x01);
            L0062: Compare(ax, 0x0002);
            L0065: if (!CompareResultEqual) goto L006A;
            L0067: di = 0x0022;
            L006A: ax = CheckState04(party, 0x01, 0x02);
            L007B: Compare(ax, 0x0004);
            L007E: if (!CompareResultEqual) goto L0083;
            L0080: si = 0x0058;
            L0083: ax = CheckState04(party, 0x01, 0x03);
            L0094: Compare(ax, 0x0004);
            L0097: if (!CompareResultEqual) goto L009C;
            L0099: si = 0x006D;
            L009C: AddTreasure(party, 0x07D0, 0x00, 0x00, si, di, 0xCF);
            L00B8: return; // RETURN (restoring si);
        }

        protected override MapEventHandler MapEvent22 => FnWKTENCE_22;
        private void FnWKTENCE_22(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: ShowMessage(party, String102A); // The Four Winds gather strength once again as they throw skeletal bones against the wall.
            L0016: ShowMessage(party, String1083); // Monsters form out of the dust and winds.
            L0023: AddEncounter(party, 0x01, 0x14);
            L0035: AddEncounter(party, 0x02, 0x1B);
            L0047: AddEncounter(party, 0x03, 0x1C);
            L0059: AddEncounter(party, 0x04, 0x1D);
            L006B: AddEncounter(party, 0x05, 0x1E);
            L007D: AddEncounter(party, 0x06, 0x1E);
            L008F: ax = CheckState04(party, 0x01, 0x01);
            L00A0: Compare(ax, 0x0003);
            L00A3: if (!CompareResultEqual) goto L00A8;
            L00A5: di = 0x0029;
            L00A8: ax = CheckState04(party, 0x01, 0x02);
            L00B9: Compare(ax, 0x0001);
            L00BC: if (!CompareResultEqual) goto L00C1;
            L00BE: si = 0x0086;
            L00C1: ax = CheckState04(party, 0x01, 0x03);
            L00D2: Compare(ax, 0x0001);
            L00D5: if (!CompareResultEqual) goto L0106;
            L00D7: ax = CheckState04(party, 0x01, 0x01);
            L00E8: Compare(ax, 0x0002);
            L00EB: if (!CompareResultEqual) goto L0106;
            L00ED: ax = CheckState04(party, 0x01, 0x02);
            L00FE: Compare(ax, 0x0003);
            L0101: if (!CompareResultEqual) goto L0106;
            L0103: si = 0x00F6;
            L0106: AddTreasure(party, 0x07D0, 0x00, 0x00, si, di, 0xCF);
            L0122: return; // RETURN (restoring si);
        }

        protected override MapEventHandler MapEvent23 => FnWKTENCF_23;
        private void FnWKTENCF_23(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: AddEncounter(party, 0x01, 0x1E);
            L001B: AddEncounter(party, 0x02, 0x1E);
            L002D: AddEncounter(party, 0x03, 0x1E);
            L003F: AddEncounter(party, 0x04, 0x15);
            L0051: AddEncounter(party, 0x05, 0x0C);
            L0063: ax = CheckState04(party, 0x01, 0x01);
            L0074: Compare(ax, 0x0004);
            L0077: if (!CompareResultEqual) goto L007C;
            L0079: di = 0x0031;
            L007C: ax = CheckState04(party, 0x01, 0x02);
            L008D: Compare(ax, 0x0003);
            L0090: if (!CompareResultEqual) goto L0095;
            L0092: si = 0x005A;
            L0095: ax = CheckState04(party, 0x01, 0x03);
            L00A6: Compare(ax, 0x0003);
            L00A9: if (!CompareResultEqual) goto L00AE;
            L00AB: si = 0x0068;
            L00AE: AddTreasure(party, 0x07D0, 0x00, 0x00, si, di, 0xCF);
            L00CA: return; // RETURN (restoring si);
        }

        protected override MapEventHandler MapEvent24 => FnWKTENCG_24;
        private void FnWKTENCG_24(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String10AC); // In the midst of sleeping Hobgoblins, a small tempest swirls.  It whispers that one's treasure comes from the directions of the winds.
            L0010: ShowMessage(party, String1132); // Then the tempest roars into a nightmare and wakens the hobgoblins.
            L001D: AddEncounter(party, 0x01, 0x22);
            L002F: AddEncounter(party, 0x02, 0x22);
            L0041: AddEncounter(party, 0x05, 0x0D);
            L0053: AddEncounter(party, 0x06, 0x0D);
            L0065: return; // RETURN;
        }

        protected override MapEventHandler MapEvent25 => FnWKTENCH_25;
        private void FnWKTENCH_25(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1175); // Sleeping adventurers are disturbed.
            L0010: AddEncounter(party, 0x01, 0x25);
            L0022: AddEncounter(party, 0x02, 0x26);
            L0034: AddEncounter(party, 0x05, 0x02);
            L0046: AddEncounter(party, 0x06, 0x03);
            L0058: return; // RETURN;
        }

        protected override MapEventHandler MapEvent26 => FnWKTENCI_26;
        private void FnWKTENCI_26(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1199); // A dark corner hides an unlikely mix of beasts.
            L0010: AddEncounter(party, 0x01, 0x1B);
            L0022: AddEncounter(party, 0x02, 0x1B);
            L0034: AddEncounter(party, 0x05, 0x21);
            L0046: AddEncounter(party, 0x06, 0x21);
            L0058: return; // RETURN;
        }

        protected override MapEventHandler MapEvent27 => FnSIRFLAG_27;
        private void FnSIRFLAG_27(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String11C8); // Sirocco's powers no longer hold the Sirocco Door.
            L0010: SetState00(party, 0x02, 0x51, 0x01);
            L0025: return; // RETURN;
        }

        protected override MapEventHandler MapEvent28 => FnSIRDOOR_28;
        private void FnSIRDOOR_28(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x51);
            L0014: RefreshCompareFlags(ax);
            L0016: if (CompareResultEqual) goto L005B;
            L0018: PushStack(0x01);
            L001C: PushStack(0x01);
            L0020: ax = GetNextTile20(party);
            L0027: PushStack(ax);
            L0028: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0032: PushStack(0x01);
            L0036: ax = GetNextTile20(party);
            L003D: PushStack(ax);
            L003E: PushStack(0x01);
            L0042: SetUnblocked30(party);
            L004C: ShowMessage(party, String11FA); // Sirocco's powers no longer hold this door.  It is open.
            L0059: goto L0075;
            L005B: ShowMessage(party, String1232); // Sirocco's Door does not open.  In the distance, a wizard laughs aloud.
            L0068: ShowMessage(party, String1279); // 'It is I, Sirocco, who bars your way!'
            L0075: return; // RETURN;
        }

        protected override MapEventHandler MapEvent29 => FnSIROCCO_29;
        private void FnSIROCCO_29(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String12A0); // Sirocco, the wind labyrinth doorkeeper, materializes in the room.
            L0010: ShowMessage(party, String12E2); // 'You dare challenge the winds??!
            L001D: AddEncounter(party, 0x01, 0x1F);
            L002F: AddEncounter(party, 0x02, 0x1F);
            L0041: AddEncounter(party, 0x03, 0x1F);
            L0053: AddEncounter(party, 0x04, 0x1F);
            L0065: AddEncounter(party, 0x05, 0x1A);
            L0077: return; // RETURN;
        }

        protected override MapEventHandler MapEvent2A => FnWSBIGDR_2A;
        private void FnWSBIGDR_2A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckStrengthA4(party);
            L000F: Compare(ax, 0x0012);
            L0012: if (CompareResultBelow) goto L0041;
            L0014: ShowMessage(party, String1303); // You force the massive door open by sheer muscle power.
            L0021: PushStack(0x01);
            L0025: ax = GetFacing24(party);
            L002C: PushStack(ax);
            L002D: ax = GetNextTile20(party);
            L0034: PushStack(ax);
            L0035: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L003F: goto L006B;
            L0041: ShowMessage(party, String133A); // The door is stuck. You are not strong enough to force it open.
            L004E: PushStack(0x00);
            L0051: ax = GetFacing24(party);
            L0058: PushStack(ax);
            L0059: ax = GetNextTile20(party);
            L0060: PushStack(ax);
            L0061: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L006B: return; // RETURN;
        }

        protected override MapEventHandler MapEvent2B => FnWSENCA_2B;
        private void FnWSENCA_2B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1379); // A nest of dragons sneers at you. 'The Sanctuary belongs to us!'
            L0010: AddEncounter(party, 0x01, 0x20);
            L0022: AddEncounter(party, 0x02, 0x20);
            L0034: AddEncounter(party, 0x05, 0x28);
            L0046: AddEncounter(party, 0x06, 0x28);
            L0058: return; // RETURN;
        }

        protected override MapEventHandler MapEvent2C => FnWSENCB_2C;
        private void FnWSENCB_2C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String13B9); // A band of sanctuary guards are alerted.
            L0010: AddEncounter(party, 0x01, 0x1F);
            L0022: AddEncounter(party, 0x02, 0x1F);
            L0034: AddEncounter(party, 0x03, 0x21);
            L0046: AddEncounter(party, 0x05, 0x20);
            L0058: AddEncounter(party, 0x06, 0x20);
            L006A: return; // RETURN;
        }

        protected override MapEventHandler MapEvent2D => FnWSENCC_2D;
        private void FnWSENCC_2D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String13E1); // Your path is blocked.
            L0010: AddEncounter(party, 0x01, 0x24);
            L0022: AddEncounter(party, 0x02, 0x24);
            L0034: AddEncounter(party, 0x03, 0x23);
            L0046: AddEncounter(party, 0x04, 0x1F);
            L0058: AddEncounter(party, 0x05, 0x1C);
            L006A: AddEncounter(party, 0x06, 0x20);
            L007C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent30 => FnWSENCF_30;
        private void FnWSENCF_30(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String13F7); // Adventurers are disturbed.  'We are cursed to kill those who have seen our fate.'
            L0010: AddEncounter(party, 0x01, 0x11);
            L0022: AddEncounter(party, 0x02, 0x1E);
            L0034: AddEncounter(party, 0x03, 0x1C);
            L0046: AddEncounter(party, 0x04, 0x13);
            L0058: return; // RETURN;
        }

        protected override MapEventHandler MapEvent31 => FnWSENCG_31;
        private void FnWSENCG_31(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x1F);
            L0015: AddEncounter(party, 0x02, 0x1F);
            L0027: AddEncounter(party, 0x05, 0x20);
            L0039: AddEncounter(party, 0x06, 0x20);
            L004B: return; // RETURN;
        }

        protected override MapEventHandler MapEvent32 => FnWSNOTE_32;
        private void FnWSNOTE_32(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1449); // Stuffed behind a rock, you find a magical note that reads... 
            L0010: ShowRunes(party, String1487); // 'Red, Yellow, Green and Blue.  That is the order of the gems.'
            L001D: ShowMessage(party, String14C6); // -- signed last Wyn Survivor, Kanasgwyn.
            L002A: return; // RETURN;
        }

        protected override MapEventHandler MapEvent33 => FnWSENCI_33;
        private void FnWSENCI_33(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String14EE); // Commanders of the Wyn Ogres have set up camp here.
            L0010: AddEncounter(party, 0x01, 0x1F);
            L0022: AddEncounter(party, 0x02, 0x1F);
            L0034: AddEncounter(party, 0x03, 0x23);
            L0046: AddEncounter(party, 0x04, 0x23);
            L0058: AddEncounter(party, 0x05, 0x20);
            L006A: AddEncounter(party, 0x06, 0x20);
            L007C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent34 => FnSDOORWS_34;
        private void FnSDOORWS_34(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L000F: Compare(ax, 0x000A);
            L0012: if (CompareResultAbove || CompareResultEqual) goto L0039;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (!CompareResultEqual) goto L0039;
            L0024: ax = UsedItem54(party, 0xBE, 0xBE);
            L0037: if (CompareResultEqual) goto L0064;
            L0039: PushStack(0x01);
            L003D: ax = GetFacing24(party);
            L0044: PushStack(ax);
            L0045: ax = GetNextTile20(party);
            L004C: PushStack(ax);
            L004D: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0057: ShowMessage(party, String1521); // You found a secret door!
            L0064: return; // RETURN;
        }

        protected override MapEventHandler MapEvent35 => FnARKARCH_35;
        private void FnARKARCH_35(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String153A); // A message is inscribed on stone -- 
            L0010: ShowMessage(party, String155E); // 'Labyrinth and lower levels first explored by Arkarch of the Snow Elves.'
            L001D: return; // RETURN;
        }

        protected override MapEventHandler MapEvent36 => FnLAENCA_36;
        private void FnLAENCA_36(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String15A8); // Apprentice thieves jump you!  'We must earn our dues!'
            L0010: AddEncounter(party, 0x01, 0x26);
            L0022: AddEncounter(party, 0x02, 0x25);
            L0034: AddEncounter(party, 0x03, 0x27);
            L0046: return; // RETURN;
        }

        protected override MapEventHandler MapEvent37 => FnFNTNHEAL_37;
        private void FnFNTNHEAL_37(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetMaxHits74(party);
            L000A: AddHealth94(party, ax);
            L0014: ShowPortrait(party, 0x0042);
            L0021: ShowMessage(party, String15DF); // Your many wounds and lingering diseases are removed by the sweet waters of WindyBless Fountain.
            L002E: return; // RETURN;
        }

        protected override MapEventHandler MapEvent38 => FnFNTNMANA_38;
        private void FnFNTNMANA_38(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddMana(party, 0x012C);
            L0010: ShowPortrait(party, 0x0042);
            L001D: ShowMessage(party, String163F); // The mystic waters of the NightWillow Fountain restore your Mana level.
            L002A: return; // RETURN;
        }

        protected override MapEventHandler MapEvent39 => FnLAENCB_39;
        private void FnLAENCB_39(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1686); // You stumble into a den of angry monsters.
            L0010: AddEncounter(party, 0x01, 0x21);
            L0022: AddEncounter(party, 0x02, 0x21);
            L0034: AddEncounter(party, 0x03, 0x1C);
            L0046: AddEncounter(party, 0x04, 0x1C);
            L0058: AddEncounter(party, 0x05, 0x28);
            L006A: AddEncounter(party, 0x06, 0x28);
            L007C: return; // RETURN;
        }

        protected override MapEventHandler MapEvent3A => FnSDOORLTA_3A;
        private void FnSDOORLTA_3A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L000F: Compare(ax, 0x000A);
            L0012: if (CompareResultAbove || CompareResultEqual) goto L004E;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (!CompareResultEqual) goto L004E;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (!CompareResultEqual) goto L004E;
            L0039: ax = UsedItem54(party, 0xBE, 0xBE);
            L004C: if (CompareResultEqual) goto L0079;
            L004E: PushStack(0x01);
            L0052: ax = GetFacing24(party);
            L0059: PushStack(ax);
            L005A: ax = GetNextTile20(party);
            L0061: PushStack(ax);
            L0062: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L006C: ShowMessage(party, String16B0); // You found a secret door!
            L0079: return; // RETURN;
        }

        protected override MapEventHandler MapEvent3B => FnSDOORLTB_3B;
        private void FnSDOORLTB_3B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L000F: Compare(ax, 0x000A);
            L0012: if (CompareResultAbove || CompareResultEqual) goto L004E;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (!CompareResultEqual) goto L004E;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (!CompareResultEqual) goto L004E;
            L0039: ax = UsedItem54(party, 0xBE, 0xBE);
            L004C: if (CompareResultEqual) goto L0079;
            L004E: PushStack(0x01);
            L0052: ax = GetFacing24(party);
            L0059: PushStack(ax);
            L005A: ax = GetNextTile20(party);
            L0061: PushStack(ax);
            L0062: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L006C: ShowMessage(party, String16C9); // You discover a secret door!
            L0079: return; // RETURN;
        }

        protected override MapEventHandler MapEvent3C => FnSDOORLTC_3C;
        private void FnSDOORLTC_3C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L000F: Compare(ax, 0x000A);
            L0012: if (CompareResultAbove || CompareResultEqual) goto L004E;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (!CompareResultEqual) goto L004E;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (!CompareResultEqual) goto L004E;
            L0039: ax = UsedItem54(party, 0xBE, 0xBE);
            L004C: if (CompareResultEqual) goto L0079;
            L004E: PushStack(0x01);
            L0052: ax = GetFacing24(party);
            L0059: PushStack(ax);
            L005A: ax = GetNextTile20(party);
            L0061: PushStack(ax);
            L0062: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L006C: ShowMessage(party, String16E5); // A secret door suddenly appears!
            L0079: return; // RETURN;
        }

        protected override MapEventHandler MapEvent3D => FnBDOORLTD_3D;
        private void FnBDOORLTD_3D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckStrengthA4(party);
            L000F: Compare(ax, 0x0010);
            L0012: if (CompareResultBelow) goto L003F;
            L0014: ShowMessage(party, String1705); // You bash the massive door open.
            L0021: PushStack(0x01);
            L0025: ax = GetFacing24(party);
            L002C: PushStack(ax);
            L002D: ax = GetNextTile20(party);
            L0034: PushStack(ax);
            L0035: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L003F: return; // RETURN;
        }

        protected override MapEventHandler MapEvent3E => FnLTENCA_3E;
        private void FnLTENCA_3E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x0F);
            L0015: AddEncounter(party, 0x02, 0x10);
            L0027: AddEncounter(party, 0x05, 0x22);
            L0039: AddEncounter(party, 0x06, 0x25);
            L004B: return; // RETURN;
        }

        protected override MapEventHandler MapEvent3F => FnLTENCB_3F;
        private void FnLTENCB_3F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1725); // A note -- 'The Runes suggest a path to Arnakkian's Treasure Room.'
            L0010: AddEncounter(party, 0x01, 0x23);
            L0022: AddEncounter(party, 0x02, 0x22);
            L0034: AddEncounter(party, 0x05, 0x25);
            L0046: AddEncounter(party, 0x06, 0x26);
            L0058: return; // RETURN;
        }

        protected override MapEventHandler MapEvent40 => FnLTENCC_40;
        private void FnLTENCC_40(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1768); // Upon the wall you see a message -- 
            L0010: ShowMessage(party, String178C); // 'Beneath each pit is a floor or another pit.  Fall to the floors to find more passages.'
            L001D: AddEncounter(party, 0x01, 0x22);
            L002F: AddEncounter(party, 0x02, 0x22);
            L0041: AddEncounter(party, 0x05, 0x25);
            L0053: AddEncounter(party, 0x06, 0x27);
            L0065: return; // RETURN;
        }

        protected override MapEventHandler MapEvent41 => FnLTENCD_41;
        private void FnLTENCD_41(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x0F);
            L0015: AddEncounter(party, 0x02, 0x0F);
            L0027: AddEncounter(party, 0x05, 0x26);
            L0039: AddEncounter(party, 0x06, 0x27);
            L004B: return; // RETURN;
        }

        protected override MapEventHandler MapEvent42 => FnLTENCE_42;
        private void FnLTENCE_42(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x0D);
            L0015: AddEncounter(party, 0x02, 0x23);
            L0027: AddEncounter(party, 0x05, 0x24);
            L0039: AddEncounter(party, 0x06, 0x18);
            L004B: return; // RETURN;
        }

        protected override MapEventHandler MapEvent44 => FnLTENCG_44;
        private void FnLTENCG_44(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String17E5); // Hobgoblins smile, then attack.
            L0010: AddEncounter(party, 0x01, 0x22);
            L0022: AddEncounter(party, 0x02, 0x22);
            L0034: AddEncounter(party, 0x03, 0x0F);
            L0046: AddEncounter(party, 0x04, 0x0F);
            L0058: return; // RETURN;
        }

        protected override MapEventHandler MapEvent45 => FnLTSKILL_45;
        private void FnLTSKILL_45(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1804); // A special thieves' shrine magically glows.
            L0010: ax = CheckState04(party, 0x02, 0x59);
            L0021: RefreshCompareFlags(ax);
            L0023: if (CompareResultEqual) goto L0028;
            L0025: goto L010D;
            L0028: SetState00(party, 0x02, 0x59, 0x01);
            L003D: ax = GetSkillLevel5C(party, 0x0D);
            L0049: RefreshCompareFlags(ax);
            L004B: if (!CompareResultEqual) goto L006E;
            L004D: SetSkillLevel60(party, 0x0D, 0x01);
            L005E: ShowMessage(party, String182F); // You gain the skill of Detection!
            L006B: goto L010B;
            L006E: ax = GetSkillLevel5C(party, 0x0E);
            L007A: RefreshCompareFlags(ax);
            L007C: if (!CompareResultEqual) goto L009E;
            L007E: SetSkillLevel60(party, 0x0E, 0x01);
            L008F: ShowMessage(party, String1850); // You gain the skill of Lockpicking!
            L009C: goto L010B;
            L009E: ax = GetSkillLevel5C(party, 0x0C);
            L00AA: RefreshCompareFlags(ax);
            L00AC: if (!CompareResultEqual) goto L00CE;
            L00AE: SetSkillLevel60(party, 0x0C, 0x02);
            L00BF: ShowMessage(party, String1873); // You gain the Bard skill!
            L00CC: goto L010B;
            L00CE: ax = GetSkillLevel5C(party, 0x0F);
            L00DA: RefreshCompareFlags(ax);
            L00DC: if (!CompareResultEqual) goto L00FE;
            L00DE: SetSkillLevel60(party, 0x0F, 0x01);
            L00EF: ShowMessage(party, String188C); // You gain the Pickpocketing skill!
            L00FC: goto L010B;
            L00FE: ShowMessage(party, String18AE); // Nothing happens.
            L010B: goto L011A;
            L010D: ShowMessage(party, String18BF); // The shrines does nothing.
            L011A: return; // RETURN;
        }

        protected override MapEventHandler MapEvent46 => FnLTENCI_46;
        private void FnLTENCI_46(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String18D9); // Thieves make a desperate stand.
            L0010: AddEncounter(party, 0x01, 0x01);
            L0022: AddEncounter(party, 0x02, 0x05);
            L0034: AddEncounter(party, 0x03, 0x25);
            L0046: AddEncounter(party, 0x04, 0x26);
            L0058: return; // RETURN;
        }

        protected override MapEventHandler MapEvent47 => FnLTENCJ_47;
        private void FnLTENCJ_47(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String18F9); // Master Thieves Attack!
            L0010: AddEncounter(party, 0x01, 0x04);
            L0022: AddEncounter(party, 0x02, 0x08);
            L0034: AddEncounter(party, 0x03, 0x25);
            L0046: AddEncounter(party, 0x04, 0x26);
            L0058: AddEncounter(party, 0x05, 0x27);
            L006A: return; // RETURN;
        }

        protected override MapEventHandler MapEvent48 => FnLTENCK_48;
        private void FnLTENCK_48(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1910); // Master Thieves ready themselves.
            L0010: AddEncounter(party, 0x01, 0x25);
            L0022: AddEncounter(party, 0x02, 0x26);
            L0034: AddEncounter(party, 0x03, 0x10);
            L0046: AddEncounter(party, 0x04, 0x10);
            L0058: AddEncounter(party, 0x05, 0x02);
            L006A: AddEncounter(party, 0x06, 0x02);
            L007C: ax = HasItem50(party, 0xDD);
            L008A: if (CompareResultEqual) goto L00AD;
            L008C: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L00AB: goto L00DB;
            L00AD: ShowMessage(party, String1931); // Light sparks off a key tied to the neck of the leader.
            L00BA: AddTreasure(party, 0x3A98, 0x00, 0x00, 0x46, 0x61, 0xDD);
            L00DB: return; // RETURN;
        }

        protected override MapEventHandler MapEvent49 => FnTXTAWIND_49;
        private void FnTXTAWIND_49(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x000A);
            L0010: ShowMessage(party, String1968); // A voice echoes through the winds...
            L001D: ShowMessage(party, String198C); // 'You have traveled well, fair adventurers!
            L002A: ShowMessage(party, String19B7); // I laughed when you troubled King Cleowyn's ghost!
            L0037: ShowMessage(party, String19E9); // But now you enter my tunnels!  Go back whence you came!
            L0044: ShowMessage(party, String1A21); // The Winds will keep these places clean.'
            L0051: return; // RETURN;
        }

    }
}
