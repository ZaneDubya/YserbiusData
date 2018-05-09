namespace ZCF.Scripts.Maps {
    class YserMap20 : ACanoMapScript {
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
        private override MapEventHandler MapEvent01 => VOID_01;
        private void VOID_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String03FC); // You step into nothingness...
            L0010: ShowMessage(party, String0419); //                                          ...and die!
            L001D: ax = GetMaxHits74(party);
            L0024: DoDamage90(party, ax);
            L002E: // RETURN;
        }

        private override MapEventHandler MapEvent02 => MOONHOLO_02;
        private void MOONHOLO_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String044E); // Cast in shadowy blue light, the tunnels of MOON HOLLOW are a nexus to more dangerous locations.
            L0010: SetMoveMap(party, 0x01, 0x03, 0x01, 0x34);
            L002B: // RETURN;
        }

        private override MapEventHandler MapEvent03 => ZEPHYR_03;
        private void ZEPHYR_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String04AE); // Well worn trails greet those who dare travel the corridors of the ZEPHYR.
            L0010: SetMoveMap(party, 0x03, 0xC3, 0x01, 0x34);
            L002B: // RETURN;
        }

        private override MapEventHandler MapEvent04 => ZZYZX_04;
        private void ZZYZX_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String04F8); // Dry desert winds parch your throat as you peer down the winding passages leading to ZZYZX.
            L0010: SetMoveMap(party, 0x00, 0x6D, 0x01, 0x34);
            L002A: // RETURN;
        }

        private override MapEventHandler MapEvent05 => DRGNLEAP_05;
        private void DRGNLEAP_05(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0553); // A brave step..
            L0010: ShowMessage(party, String0562); // Death does not greet you now, but it will perhaps when you meet the DRAGONS OF THE LEAP.
            L001D: SetMoveMap(party, 0x01, 0xCB, 0x01, 0x34);
            L0038: // RETURN;
        }

        private override MapEventHandler MapEvent06 => TORBRIAR_06;
        private void TORBRIAR_06(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String05BB); // You drop into TORBRIAR'S TREASURE.
            L0010: ShowMessage(party, String05DE); // An inscription on the wall reads...
            L001D: ShowMessage(party, String0602); // 'We, the Knights of Torbriar, build this shrine to celebrate WarMaster Torbriar's stunning victory over the armies of Ogres and Trolls.'
            L002A: SetMoveMap(party, 0x02, 0x35, 0x01, 0x34);
            L0045: // RETURN;
        }

        private override MapEventHandler MapEvent07 => MOONHOLO_07;
        private void MOONHOLO_07(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String068B); // You land squarely in the center of MOON HOLLOW!
            L0010: ShowMessage(party, String06BB); // The howling of winds screams harsh against the blue light of a fool moon.
            L001D: SetMoveMap(party, 0x02, 0x73, 0x01, 0x34);
            L0038: // RETURN;
        }

        private override MapEventHandler MapEvent08 => MAGEOVRL_08;
        private void MAGEOVRL_08(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0705); // You drop into MAGES OVERLOOK.
            L0010: ShowMessage(party, String0723); // Mages found this plateau useful for looking out over the labyrinth denizens following the great cataclysm.
            L001D: SetMoveMap(party, 0x03, 0x7A, 0x01, 0x34);
            L0038: // RETURN;
        }

        private override MapEventHandler MapEvent09 => ENCWINDN_09;
        private void ENCWINDN_09(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String078E); // The North Wind blows a wintry chill.
            L0010: AddEncounter(party, 0x1B, 0x01);
            L0022: AddEncounter(party, 0x1B, 0x02);
            L0034: AddEncounter(party, 0x1B, 0x03);
            L0046: AddEncounter(party, 0x19, 0x05);
            L0058: AddEncounter(party, 0x1A, 0x06);
            L006A: // RETURN;
        }

        private override MapEventHandler MapEvent0A => ENCWINDE_0A;
        private void ENCWINDE_0A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String07B3); // Warriors of the East Wind challenge you.
            L0010: AddEncounter(party, 0x11, 0x01);
            L0022: AddEncounter(party, 0x11, 0x02);
            L0034: AddEncounter(party, 0x11, 0x04);
            L0046: AddEncounter(party, 0x19, 0x05);
            L0058: AddEncounter(party, 0x1A, 0x06);
            L006A: // RETURN;
        }

        private override MapEventHandler MapEvent0B => ENCWINDS_0B;
        private void ENCWINDS_0B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String07DC); // Monsters materialize from the South Wind.
            L0010: AddEncounter(party, 0x1C, 0x01);
            L0022: AddEncounter(party, 0x1C, 0x02);
            L0034: AddEncounter(party, 0x1C, 0x03);
            L0046: AddEncounter(party, 0x19, 0x05);
            L0058: AddEncounter(party, 0x1A, 0x06);
            L006A: // RETURN;
        }

        private override MapEventHandler MapEvent0C => ENCWINDW_0C;
        private void ENCWINDW_0C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0806); // The fury of the West Wind is upon you.
            L0010: AddEncounter(party, 0x1D, 0x01);
            L0022: AddEncounter(party, 0x1D, 0x02);
            L0034: AddEncounter(party, 0x1D, 0x04);
            L0046: AddEncounter(party, 0x1A, 0x05);
            L0058: AddEncounter(party, 0x19, 0x06);
            L006A: // RETURN;
        }

        private override MapEventHandler MapEvent0D => FLGWINDN_0D;
        private void FLGWINDN_0D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = 0x0001;
            L0007: ax = CheckState04(party, 0x01, 0x01);
            L0018: RefreshCompareFlags(ax);
            L001A: if (result.notequal) goto L0070;
            L001C: ax = CheckState04(party, 0x01, 0x02);
            L002D: RefreshCompareFlags(ax);
            L002F: if (result.equal) goto L0032;
            L0031: si = si + 1;
            L0032: ax = CheckState04(party, 0x01, 0x03);
            L0043: RefreshCompareFlags(ax);
            L0045: if (result.equal) goto L0048;
            L0047: si = si + 1;
            L0048: ax = CheckState04(party, 0x01, 0x04);
            L0059: RefreshCompareFlags(ax);
            L005B: if (result.equal) goto L005E;
            L005D: si = si + 1;
            L005E: SetState00(party, 0xC4, 0xB8, si);
            L0070: ax = CheckState04(party, 0x01, 0x01);
            L0081: compare(ax, 0x0001);
            L0084: if (result.equal) goto L0088;
            L0086: goto L0095;
            L0088: ShowMessage(party, String082D); // The North Wind is the first to be defeated.
            L0095: ShowMessage(party, String0859); // The North Wind has been quieted.
            L00A2: // RETURN (restoring si);
        }

        private override MapEventHandler MapEvent0E => FLGWINDE_0E;
        private void FLGWINDE_0E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = 0x0001;
            L0007: ax = CheckState04(party, 0x01, 0x02);
            L0018: RefreshCompareFlags(ax);
            L001A: if (result.notequal) goto L0070;
            L001C: ax = CheckState04(party, 0x01, 0x01);
            L002D: RefreshCompareFlags(ax);
            L002F: if (result.equal) goto L0032;
            L0031: si = si + 1;
            L0032: ax = CheckState04(party, 0x01, 0x03);
            L0043: RefreshCompareFlags(ax);
            L0045: if (result.equal) goto L0048;
            L0047: si = si + 1;
            L0048: ax = CheckState04(party, 0x01, 0x04);
            L0059: RefreshCompareFlags(ax);
            L005B: if (result.equal) goto L005E;
            L005D: si = si + 1;
            L005E: SetState00(party, 0xC4, 0xB8, si);
            L0070: ax = CheckState04(party, 0x01, 0x02);
            L0081: compare(ax, 0x0001);
            L0084: if (result.equal) goto L0088;
            L0086: goto L0095;
            L0088: ShowMessage(party, String087A); // The East Wind is the first to be defeated.
            L0095: ShowMessage(party, String08A5); // The East Wind has been quieted.
            L00A2: // RETURN (restoring si);
        }

        private override MapEventHandler MapEvent0F => FLGWINDS_0F;
        private void FLGWINDS_0F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = 0x0001;
            L0007: ax = CheckState04(party, 0x01, 0x03);
            L0018: RefreshCompareFlags(ax);
            L001A: if (result.notequal) goto L0070;
            L001C: ax = CheckState04(party, 0x01, 0x01);
            L002D: RefreshCompareFlags(ax);
            L002F: if (result.equal) goto L0032;
            L0031: si = si + 1;
            L0032: ax = CheckState04(party, 0x01, 0x02);
            L0043: RefreshCompareFlags(ax);
            L0045: if (result.equal) goto L0048;
            L0047: si = si + 1;
            L0048: ax = CheckState04(party, 0x01, 0x04);
            L0059: RefreshCompareFlags(ax);
            L005B: if (result.equal) goto L005E;
            L005D: si = si + 1;
            L005E: SetState00(party, 0xC4, 0xB8, si);
            L0070: ax = CheckState04(party, 0x01, 0x03);
            L0081: compare(ax, 0x0001);
            L0084: if (result.equal) goto L0088;
            L0086: goto L0095;
            L0088: ShowMessage(party, String08C5); // The South Wind is the first to be defeated.
            L0095: ShowMessage(party, String08F1); // The South Wind has been quieted.
            L00A2: // RETURN (restoring si);
        }

        private override MapEventHandler MapEvent10 => FLGWINDW_10;
        private void FLGWINDW_10(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = 0x0001;
            L0007: ax = CheckState04(party, 0x01, 0x04);
            L0018: RefreshCompareFlags(ax);
            L001A: if (result.notequal) goto L0070;
            L001C: ax = CheckState04(party, 0x01, 0x01);
            L002D: RefreshCompareFlags(ax);
            L002F: if (result.equal) goto L0032;
            L0031: si = si + 1;
            L0032: ax = CheckState04(party, 0x01, 0x02);
            L0043: RefreshCompareFlags(ax);
            L0045: if (result.equal) goto L0048;
            L0047: si = si + 1;
            L0048: ax = CheckState04(party, 0x01, 0x03);
            L0059: RefreshCompareFlags(ax);
            L005B: if (result.equal) goto L005E;
            L005D: si = si + 1;
            L005E: SetState00(party, 0xC4, 0xB8, si);
            L0070: ax = CheckState04(party, 0x01, 0x04);
            L0081: compare(ax, 0x0001);
            L0084: if (result.equal) goto L0088;
            L0086: goto L0095;
            L0088: ShowMessage(party, String0912); // The West Wind is the first to be defeated.
            L0095: ShowMessage(party, String093D); // The West Wind has been quieted.
            L00A2: // RETURN (restoring si);
        }

        private override MapEventHandler MapEvent11 => EXPRESS_11;
        private void EXPRESS_11(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x57);
            L0014: RefreshCompareFlags(ax);
            L0016: if (result.equal) goto L0046;
            L0018: ShowMessage(party, String095D); // This wall is the teleport to CASTLEGATE.
            L0025: Push(03);
            L0029: ax = GetNextTile20(party);
            L0030: SetMoveMap(party, PopStack(), ax, 0x01, 0x36);
            L0044: goto L0053;
            L0046: ShowMessage(party, String0986); // There is something strange about this wall.
            L0053: // RETURN;
        }

        private override MapEventHandler MapEvent12 => TXTLABY_12;
        private void TXTLABY_12(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String09B2); // You enter the Labyrinths of the Winds.
            L0010: ShowMessage(party, String09D9); // A network of tunnels seems to wind its way past pits and lava.
            L001D: // RETURN;
        }

        private override MapEventHandler MapEvent13 => WSTRES_13;
        private void WSTRES_13(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0A18); // Wyn's Fountain is old and cracked.
            L0010: ax = CheckState04(party, 0x02, 0x58);
            L0021: RefreshCompareFlags(ax);
            L0023: if (result.notequal) goto L0082;
            L0025: SetState00(party, 0x02, 0x58, 0x01);
            L003A: ShowPortrait(party, 0x0042);
            L0047: ModifyAttributeA8(party, 0x03, 0x0003);
            L0059: ShowMessage(party, String0A3B); // A small puddle of magic water sits at the bottom.
            L0066: ShowMessage(party, String0A6D); // It seems to instantly evaporate into a large steam cloud.
            L0073: ShowMessage(party, String0AA7); // You feel you may be quicker in a fight.
            L0080: goto L008F;
            L0082: ShowMessage(party, String0ACF); // The basin is dust dry.
            L008F: // RETURN;
        }

        private override MapEventHandler MapEvent14 => MOUNTAIN_14;
        private void MOUNTAIN_14(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetMoveMap(party, 0x33, 0x00, 0x01, 0x01);
            L001D: // RETURN;
        }

        private override MapEventHandler MapEvent15 => TXTMNTN_15;
        private void TXTMNTN_15(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0AE6); // A twisting passage to the east offers a quick way to the entrance.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent16 => THIEVMAZ_16;
        private void THIEVMAZ_16(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0B29); // You discover the back entrance to the THIEVES' DEN.
            L0010: SetMoveMap(party, 0x01, 0xBE, 0x01, 0x05);
            L002B: // RETURN;
        }

        private override MapEventHandler MapEvent17 => LAVA_17;
        private void LAVA_17(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0B5D); // You stumble into the lava pools and die.
            L0010: ax = GetMaxHits74(party);
            L0017: DoDamage90(party, ax);
            L0021: // RETURN;
        }

        private override MapEventHandler MapEvent18 => ZEPHYRB_18;
        private void ZEPHYRB_18(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0B86); // Well worn trails greet those who dare travel the windswept corridors of the ZEPHYR.
            L0010: SetMoveMap(party, 0x01, 0x6E, 0x01, 0x34);
            L002B: // RETURN;
        }

        private override MapEventHandler MapEvent19 => SDOORWKT_19;
        private void SDOORWKT_19(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0BDA); // Skeletal voices echo...
            L0010: ax = CheckState04(party, 0x01, 0x01);
            L0021: RefreshCompareFlags(ax);
            L0023: if (result.notequal) goto L0028;
            L0025: goto L00D7;
            L0028: ax = CheckState04(party, 0x01, 0x02);
            L0039: RefreshCompareFlags(ax);
            L003B: if (result.notequal) goto L0040;
            L003D: goto L00D7;
            L0040: ax = CheckState04(party, 0x01, 0x03);
            L0051: RefreshCompareFlags(ax);
            L0053: if (result.notequal) goto L0058;
            L0055: goto L00D7;
            L0058: ax = CheckState04(party, 0x01, 0x04);
            L0069: RefreshCompareFlags(ax);
            L006B: if (result.equal) goto L00D7;
            L006D: ShowPortrait(party, 0x000A);
            L007A: ShowMessage(party, String0BF2); // 'The four winds have been defeated!!!!
            L0087: ShowMessage(party, String0C19); // ARGGG!  We cannot hold you back.  You are indeed a powerful force!!
            L0094: ShowMessage(party, String0C5D); // Enter the WIND KNIGHTS' TOMB if you dare, but if you have any honor, do not disturb our bones.'
            L00A1: Push(01);
            L00A5: Push(03);
            L00A9: ax = GetNextTile20(party);
            L00B0: PushStack(ax);
            L00B1: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L00BB: Push(03);
            L00BF: ax = GetNextTile20(party);
            L00C6: PushStack(ax);
            L00C7: Push(01);
            L00CB: SetUnblocked30(party);
            L00D5: goto L00E4;
            L00D7: ShowMessage(party, String0CBD); // 'Only Forces more powerful than all four winds can open this door!'
            L00E4: // RETURN;
        }

        private override MapEventHandler MapEvent1A => TXTCAMP_1A;
        private void TXTCAMP_1A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0028);
            L0010: ShowMessage(party, String0D01); // Welcome to LABYRINTH ATTIC!
            L001D: ShowMessage(party, String0D1D); // Refresh yourself in the fountains nearby.  But do not take long!
            L002A: ShowMessage(party, String0D5E); // Bands of travelers rest here before exploring the Wind Labyrinths.
            L0037: // RETURN;
        }

        private override MapEventHandler MapEvent1B => KEYDOORW_1B;
        private void KEYDOORW_1B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xDD, 0xDD);
            L0016: if (result.equal) goto L0066;
            L0018: Push(01);
            L001C: PushStack(0x00);
            L001F: ax = GetNextTile20(party);
            L0026: PushStack(ax);
            L0027: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0031: PushStack(0x00);
            L0034: ax = GetNextTile20(party);
            L003B: PushStack(ax);
            L003C: Push(01);
            L0040: SetUnblocked30(party);
            L004A: ShowMessage(party, String0DA1); // The door is unlocked.
            L0057: ShowMessage(party, String0DB7); // The soft breezes seem to whisper - 'Beware, those who seek the treasure of WIND KNIGHTS' TOMB.'
            L0064: goto L0073;
            L0066: ShowMessage(party, String0E17); // Winds pound furiously at the door.
            L0073: // RETURN;
        }

        private override MapEventHandler MapEvent1C => TXTWYNS_1C;
        private void TXTWYNS_1C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0E3A); // The feeble survivors of Arnakkian's Experiment harbored hatred toward those who found home in the WYN SANCTUARY.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent1D => PITINFO_1D;
        private void PITINFO_1D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x002A);
            L0010: ShowMessage(party, String0EAB); // A Gremlin Cleric Appears
            L001D: ShowMessage(party, String0EC4); // 'Take my advice - Jump only into the pits with floors beneath them.
            L002A: ShowMessage(party, String0F08); // That is the way of the Labyrinth.'
            L0037: // RETURN;
        }

        private override MapEventHandler MapEvent1E => WKTENCA_1E;
        private void WKTENCA_1E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x15, 0x01);
            L0015: AddEncounter(party, 0x15, 0x02);
            L0027: AddEncounter(party, 0x1E, 0x05);
            L0039: AddEncounter(party, 0x1E, 0x06);
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent1F => WKTTEXT_1F;
        private void WKTTEXT_1F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0F2B); // A message is etched in stone -- 
            L0010: ShowMessage(party, String0F4C); // 'The last of Arnakkian's Knights have been buried.  
            L001D: ShowMessage(party, String0F81); // At last I can tell my secret!  I watched as Arnakkian challenged the Time Elemental En-Li-Kil and lost.
            L002A: ShowMessage(party, String0FE9); // His greed for immortality cursed us all.' -- Morgard, ArchCleric
            L0037: // RETURN;
        }

        private override MapEventHandler MapEvent20 => WKTENCC_20;
        private void WKTENCC_20(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: AddEncounter(party, 0x15, 0x01);
            L001B: AddEncounter(party, 0x15, 0x02);
            L002D: AddEncounter(party, 0x0D, 0x03);
            L003F: AddEncounter(party, 0x0D, 0x04);
            L0051: AddEncounter(party, 0x1E, 0x05);
            L0063: AddEncounter(party, 0x1E, 0x06);
            L0075: ax = CheckState04(party, 0x01, 0x01);
            L0086: compare(ax, 0x0001);
            L0089: if (result.notequal) goto L008E;
            L008B: di = 0x000E;
            L008E: ax = CheckState04(party, 0x01, 0x02);
            L009F: compare(ax, 0x0002);
            L00A2: if (result.notequal) goto L00A7;
            L00A4: si = 0x005B;
            L00A7: ax = CheckState04(party, 0x01, 0x03);
            L00B8: compare(ax, 0x0002);
            L00BB: if (result.notequal) goto L00C0;
            L00BD: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x6F, di, 0xCF);
            L00DB: // RETURN (restoring si, di);
        }

        private override MapEventHandler MapEvent21 => WKTENCD_21;
        private void WKTENCD_21(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: AddEncounter(party, 0x1E, 0x01);
            L001B: AddEncounter(party, 0x1E, 0x02);
            L002D: AddEncounter(party, 0x0D, 0x05);
            L003F: AddEncounter(party, 0x0D, 0x06);
            L0051: ax = CheckState04(party, 0x01, 0x01);
            L0062: compare(ax, 0x0002);
            L0065: if (result.notequal) goto L006A;
            L0067: di = 0x0022;
            L006A: ax = CheckState04(party, 0x01, 0x02);
            L007B: compare(ax, 0x0004);
            L007E: if (result.notequal) goto L0083;
            L0080: si = 0x0058;
            L0083: ax = CheckState04(party, 0x01, 0x03);
            L0094: compare(ax, 0x0004);
            L0097: if (result.notequal) goto L009C;
            L0099: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x6D, di, 0xCF);
            L00B7: // RETURN (restoring si, di);
        }

        private override MapEventHandler MapEvent22 => WKTENCE_22;
        private void WKTENCE_22(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: ShowMessage(party, String102A); // The Four Winds gather strength once again as they throw skeletal bones against the wall.
            L0016: ShowMessage(party, String1083); // Monsters form out of the dust and winds.
            L0023: AddEncounter(party, 0x14, 0x01);
            L0035: AddEncounter(party, 0x1B, 0x02);
            L0047: AddEncounter(party, 0x1C, 0x03);
            L0059: AddEncounter(party, 0x1D, 0x04);
            L006B: AddEncounter(party, 0x1E, 0x05);
            L007D: AddEncounter(party, 0x1E, 0x06);
            L008F: ax = CheckState04(party, 0x01, 0x01);
            L00A0: compare(ax, 0x0003);
            L00A3: if (result.notequal) goto L00A8;
            L00A5: di = 0x0029;
            L00A8: ax = CheckState04(party, 0x01, 0x02);
            L00B9: compare(ax, 0x0001);
            L00BC: if (result.notequal) goto L00C1;
            L00BE: si = 0x0086;
            L00C1: ax = CheckState04(party, 0x01, 0x03);
            L00D2: compare(ax, 0x0001);
            L00D5: if (result.notequal) goto L0106;
            L00D7: ax = CheckState04(party, 0x01, 0x01);
            L00E8: compare(ax, 0x0002);
            L00EB: if (result.notequal) goto L0106;
            L00ED: ax = CheckState04(party, 0x01, 0x02);
            L00FE: compare(ax, 0x0003);
            L0101: if (result.notequal) goto L0106;
            L0103: AddTreasure(party, 0x07D0, 0x00, 0x00, 0xF6, di, 0xCF);
            L0121: // RETURN (restoring si, di);
        }

        private override MapEventHandler MapEvent23 => WKTENCF_23;
        private void WKTENCF_23(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: AddEncounter(party, 0x1E, 0x01);
            L001B: AddEncounter(party, 0x1E, 0x02);
            L002D: AddEncounter(party, 0x1E, 0x03);
            L003F: AddEncounter(party, 0x15, 0x04);
            L0051: AddEncounter(party, 0x0C, 0x05);
            L0063: ax = CheckState04(party, 0x01, 0x01);
            L0074: compare(ax, 0x0004);
            L0077: if (result.notequal) goto L007C;
            L0079: di = 0x0031;
            L007C: ax = CheckState04(party, 0x01, 0x02);
            L008D: compare(ax, 0x0003);
            L0090: if (result.notequal) goto L0095;
            L0092: si = 0x005A;
            L0095: ax = CheckState04(party, 0x01, 0x03);
            L00A6: compare(ax, 0x0003);
            L00A9: if (result.notequal) goto L00AE;
            L00AB: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x68, di, 0xCF);
            L00C9: // RETURN (restoring si, di);
        }

        private override MapEventHandler MapEvent24 => WKTENCG_24;
        private void WKTENCG_24(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String10AC); // In the midst of sleeping Hobgoblins, a small tempest swirls.  It whispers that one's treasure comes from the directions of the winds.
            L0010: ShowMessage(party, String1132); // Then the tempest roars into a nightmare and wakens the hobgoblins.
            L001D: AddEncounter(party, 0x22, 0x01);
            L002F: AddEncounter(party, 0x22, 0x02);
            L0041: AddEncounter(party, 0x0D, 0x05);
            L0053: AddEncounter(party, 0x0D, 0x06);
            L0065: // RETURN;
        }

        private override MapEventHandler MapEvent25 => WKTENCH_25;
        private void WKTENCH_25(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1175); // Sleeping adventurers are disturbed.
            L0010: AddEncounter(party, 0x25, 0x01);
            L0022: AddEncounter(party, 0x26, 0x02);
            L0034: AddEncounter(party, 0x02, 0x05);
            L0046: AddEncounter(party, 0x03, 0x06);
            L0058: // RETURN;
        }

        private override MapEventHandler MapEvent26 => WKTENCI_26;
        private void WKTENCI_26(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1199); // A dark corner hides an unlikely mix of beasts.
            L0010: AddEncounter(party, 0x1B, 0x01);
            L0022: AddEncounter(party, 0x1B, 0x02);
            L0034: AddEncounter(party, 0x21, 0x05);
            L0046: AddEncounter(party, 0x21, 0x06);
            L0058: // RETURN;
        }

        private override MapEventHandler MapEvent27 => SIRFLAG_27;
        private void SIRFLAG_27(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String11C8); // Sirocco's powers no longer hold the Sirocco Door.
            L0010: SetState00(party, 0x02, 0x51, 0x01);
            L0025: // RETURN;
        }

        private override MapEventHandler MapEvent28 => SIRDOOR_28;
        private void SIRDOOR_28(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x51);
            L0014: RefreshCompareFlags(ax);
            L0016: if (result.equal) goto L005B;
            L0018: Push(01);
            L001C: Push(01);
            L0020: ax = GetNextTile20(party);
            L0027: PushStack(ax);
            L0028: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0032: Push(01);
            L0036: ax = GetNextTile20(party);
            L003D: PushStack(ax);
            L003E: Push(01);
            L0042: SetUnblocked30(party);
            L004C: ShowMessage(party, String11FA); // Sirocco's powers no longer hold this door.  It is open.
            L0059: goto L0075;
            L005B: ShowMessage(party, String1232); // Sirocco's Door does not open.  In the distance, a wizard laughs aloud.
            L0068: ShowMessage(party, String1279); // 'It is I, Sirocco, who bars your way!'
            L0075: // RETURN;
        }

        private override MapEventHandler MapEvent29 => SIROCCO_29;
        private void SIROCCO_29(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String12A0); // Sirocco, the wind labyrinth doorkeeper, materializes in the room.
            L0010: ShowMessage(party, String12E2); // 'You dare challenge the winds??!
            L001D: AddEncounter(party, 0x1F, 0x01);
            L002F: AddEncounter(party, 0x1F, 0x02);
            L0041: AddEncounter(party, 0x1F, 0x03);
            L0053: AddEncounter(party, 0x1F, 0x04);
            L0065: AddEncounter(party, 0x1A, 0x05);
            L0077: // RETURN;
        }

        private override MapEventHandler MapEvent2A => WSBIGDR_2A;
        private void WSBIGDR_2A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckStrengthA4(party);
            L000F: compare(ax, 0x0012);
            L0012: if (result.below) goto L0041;
            L0014: ShowMessage(party, String1303); // You force the massive door open by sheer muscle power.
            L0021: Push(01);
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
            L006B: // RETURN;
        }

        private override MapEventHandler MapEvent2B => WSENCA_2B;
        private void WSENCA_2B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1379); // A nest of dragons sneers at you. 'The Sanctuary belongs to us!'
            L0010: AddEncounter(party, 0x20, 0x01);
            L0022: AddEncounter(party, 0x20, 0x02);
            L0034: AddEncounter(party, 0x28, 0x05);
            L0046: AddEncounter(party, 0x28, 0x06);
            L0058: // RETURN;
        }

        private override MapEventHandler MapEvent2C => WSENCB_2C;
        private void WSENCB_2C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String13B9); // A band of sanctuary guards are alerted.
            L0010: AddEncounter(party, 0x1F, 0x01);
            L0022: AddEncounter(party, 0x1F, 0x02);
            L0034: AddEncounter(party, 0x21, 0x03);
            L0046: AddEncounter(party, 0x20, 0x05);
            L0058: AddEncounter(party, 0x20, 0x06);
            L006A: // RETURN;
        }

        private override MapEventHandler MapEvent2D => WSENCC_2D;
        private void WSENCC_2D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String13E1); // Your path is blocked.
            L0010: AddEncounter(party, 0x24, 0x01);
            L0022: AddEncounter(party, 0x24, 0x02);
            L0034: AddEncounter(party, 0x23, 0x03);
            L0046: AddEncounter(party, 0x1F, 0x04);
            L0058: AddEncounter(party, 0x1C, 0x05);
            L006A: AddEncounter(party, 0x20, 0x06);
            L007C: // RETURN;
        }

        private override MapEventHandler MapEvent30 => WSENCF_30;
        private void WSENCF_30(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String13F7); // Adventurers are disturbed.  'We are cursed to kill those who have seen our fate.'
            L0010: AddEncounter(party, 0x11, 0x01);
            L0022: AddEncounter(party, 0x1E, 0x02);
            L0034: AddEncounter(party, 0x1C, 0x03);
            L0046: AddEncounter(party, 0x13, 0x04);
            L0058: // RETURN;
        }

        private override MapEventHandler MapEvent31 => WSENCG_31;
        private void WSENCG_31(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x1F, 0x01);
            L0015: AddEncounter(party, 0x1F, 0x02);
            L0027: AddEncounter(party, 0x20, 0x05);
            L0039: AddEncounter(party, 0x20, 0x06);
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent32 => WSNOTE_32;
        private void WSNOTE_32(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1449); // Stuffed behind a rock, you find a magical note that reads... 
            L0010: ShowRunes(party, String1487); // 'Red, Yellow, Green and Blue.  That is the order of the gems.'
            L001D: ShowMessage(party, String14C6); // -- signed last Wyn Survivor, Kanasgwyn.
            L002A: // RETURN;
        }

        private override MapEventHandler MapEvent33 => WSENCI_33;
        private void WSENCI_33(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String14EE); // Commanders of the Wyn Ogres have set up camp here.
            L0010: AddEncounter(party, 0x1F, 0x01);
            L0022: AddEncounter(party, 0x1F, 0x02);
            L0034: AddEncounter(party, 0x23, 0x03);
            L0046: AddEncounter(party, 0x23, 0x04);
            L0058: AddEncounter(party, 0x20, 0x05);
            L006A: AddEncounter(party, 0x20, 0x06);
            L007C: // RETURN;
        }

        private override MapEventHandler MapEvent34 => SDOORWS_34;
        private void SDOORWS_34(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L000F: compare(ax, 0x000A);
            L0012: if (result.above or result.equal) goto L0039;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (result.notequal) goto L0039;
            L0024: ax = UsedItem54(party, 0xBE, 0xBE);
            L0037: if (result.equal) goto L0064;
            L0039: Push(01);
            L003D: ax = GetFacing24(party);
            L0044: PushStack(ax);
            L0045: ax = GetNextTile20(party);
            L004C: PushStack(ax);
            L004D: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0057: ShowMessage(party, String1521); // You found a secret door!
            L0064: // RETURN;
        }

        private override MapEventHandler MapEvent35 => ARKARCH_35;
        private void ARKARCH_35(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String153A); // A message is inscribed on stone -- 
            L0010: ShowMessage(party, String155E); // 'Labyrinth and lower levels first explored by Arkarch of the Snow Elves.'
            L001D: // RETURN;
        }

        private override MapEventHandler MapEvent36 => LAENCA_36;
        private void LAENCA_36(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String15A8); // Apprentice thieves jump you!  'We must earn our dues!'
            L0010: AddEncounter(party, 0x26, 0x01);
            L0022: AddEncounter(party, 0x25, 0x02);
            L0034: AddEncounter(party, 0x27, 0x03);
            L0046: // RETURN;
        }

        private override MapEventHandler MapEvent37 => FNTNHEAL_37;
        private void FNTNHEAL_37(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetMaxHits74(party);
            L000A: AddHealth94(party, ax);
            L0014: ShowPortrait(party, 0x0042);
            L0021: ShowMessage(party, String15DF); // Your many wounds and lingering diseases are removed by the sweet waters of WindyBless Fountain.
            L002E: // RETURN;
        }

        private override MapEventHandler MapEvent38 => FNTNMANA_38;
        private void FNTNMANA_38(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddMana(party, 0x012C);
            L0010: ShowPortrait(party, 0x0042);
            L001D: ShowMessage(party, String163F); // The mystic waters of the NightWillow Fountain restore your Mana level.
            L002A: // RETURN;
        }

        private override MapEventHandler MapEvent39 => LAENCB_39;
        private void LAENCB_39(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1686); // You stumble into a den of angry monsters.
            L0010: AddEncounter(party, 0x21, 0x01);
            L0022: AddEncounter(party, 0x21, 0x02);
            L0034: AddEncounter(party, 0x1C, 0x03);
            L0046: AddEncounter(party, 0x1C, 0x04);
            L0058: AddEncounter(party, 0x28, 0x05);
            L006A: AddEncounter(party, 0x28, 0x06);
            L007C: // RETURN;
        }

        private override MapEventHandler MapEvent3A => SDOORLTA_3A;
        private void SDOORLTA_3A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L000F: compare(ax, 0x000A);
            L0012: if (result.above or result.equal) goto L004E;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (result.notequal) goto L004E;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (result.notequal) goto L004E;
            L0039: ax = UsedItem54(party, 0xBE, 0xBE);
            L004C: if (result.equal) goto L0079;
            L004E: Push(01);
            L0052: ax = GetFacing24(party);
            L0059: PushStack(ax);
            L005A: ax = GetNextTile20(party);
            L0061: PushStack(ax);
            L0062: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L006C: ShowMessage(party, String16B0); // You found a secret door!
            L0079: // RETURN;
        }

        private override MapEventHandler MapEvent3B => SDOORLTB_3B;
        private void SDOORLTB_3B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L000F: compare(ax, 0x000A);
            L0012: if (result.above or result.equal) goto L004E;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (result.notequal) goto L004E;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (result.notequal) goto L004E;
            L0039: ax = UsedItem54(party, 0xBE, 0xBE);
            L004C: if (result.equal) goto L0079;
            L004E: Push(01);
            L0052: ax = GetFacing24(party);
            L0059: PushStack(ax);
            L005A: ax = GetNextTile20(party);
            L0061: PushStack(ax);
            L0062: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L006C: ShowMessage(party, String16C9); // You discover a secret door!
            L0079: // RETURN;
        }

        private override MapEventHandler MapEvent3C => SDOORLTC_3C;
        private void SDOORLTC_3C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L000F: compare(ax, 0x000A);
            L0012: if (result.above or result.equal) goto L004E;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (result.notequal) goto L004E;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (result.notequal) goto L004E;
            L0039: ax = UsedItem54(party, 0xBE, 0xBE);
            L004C: if (result.equal) goto L0079;
            L004E: Push(01);
            L0052: ax = GetFacing24(party);
            L0059: PushStack(ax);
            L005A: ax = GetNextTile20(party);
            L0061: PushStack(ax);
            L0062: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L006C: ShowMessage(party, String16E5); // A secret door suddenly appears!
            L0079: // RETURN;
        }

        private override MapEventHandler MapEvent3D => BDOORLTD_3D;
        private void BDOORLTD_3D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckStrengthA4(party);
            L000F: compare(ax, 0x0010);
            L0012: if (result.below) goto L003F;
            L0014: ShowMessage(party, String1705); // You bash the massive door open.
            L0021: Push(01);
            L0025: ax = GetFacing24(party);
            L002C: PushStack(ax);
            L002D: ax = GetNextTile20(party);
            L0034: PushStack(ax);
            L0035: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L003F: // RETURN;
        }

        private override MapEventHandler MapEvent3E => LTENCA_3E;
        private void LTENCA_3E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x0F, 0x01);
            L0015: AddEncounter(party, 0x10, 0x02);
            L0027: AddEncounter(party, 0x22, 0x05);
            L0039: AddEncounter(party, 0x25, 0x06);
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent3F => LTENCB_3F;
        private void LTENCB_3F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1725); // A note -- 'The Runes suggest a path to Arnakkian's Treasure Room.'
            L0010: AddEncounter(party, 0x23, 0x01);
            L0022: AddEncounter(party, 0x22, 0x02);
            L0034: AddEncounter(party, 0x25, 0x05);
            L0046: AddEncounter(party, 0x26, 0x06);
            L0058: // RETURN;
        }

        private override MapEventHandler MapEvent40 => LTENCC_40;
        private void LTENCC_40(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1768); // Upon the wall you see a message -- 
            L0010: ShowMessage(party, String178C); // 'Beneath each pit is a floor or another pit.  Fall to the floors to find more passages.'
            L001D: AddEncounter(party, 0x22, 0x01);
            L002F: AddEncounter(party, 0x22, 0x02);
            L0041: AddEncounter(party, 0x25, 0x05);
            L0053: AddEncounter(party, 0x27, 0x06);
            L0065: // RETURN;
        }

        private override MapEventHandler MapEvent41 => LTENCD_41;
        private void LTENCD_41(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x0F, 0x01);
            L0015: AddEncounter(party, 0x0F, 0x02);
            L0027: AddEncounter(party, 0x26, 0x05);
            L0039: AddEncounter(party, 0x27, 0x06);
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent42 => LTENCE_42;
        private void LTENCE_42(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x0D, 0x01);
            L0015: AddEncounter(party, 0x23, 0x02);
            L0027: AddEncounter(party, 0x24, 0x05);
            L0039: AddEncounter(party, 0x18, 0x06);
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent44 => LTENCG_44;
        private void LTENCG_44(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String17E5); // Hobgoblins smile, then attack.
            L0010: AddEncounter(party, 0x22, 0x01);
            L0022: AddEncounter(party, 0x22, 0x02);
            L0034: AddEncounter(party, 0x0F, 0x03);
            L0046: AddEncounter(party, 0x0F, 0x04);
            L0058: // RETURN;
        }

        private override MapEventHandler MapEvent45 => LTSKILL_45;
        private void LTSKILL_45(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1804); // A special thieves' shrine magically glows.
            L0010: ax = CheckState04(party, 0x02, 0x59);
            L0021: RefreshCompareFlags(ax);
            L0023: if (result.equal) goto L0028;
            L0025: goto L010D;
            L0028: SetState00(party, 0x02, 0x59, 0x01);
            L003D: ax = GetSkillLevel5C(party, 0x0D);
            L0049: RefreshCompareFlags(ax);
            L004B: if (result.notequal) goto L006E;
            L004D: SetSkillLevel60(party, 0x0D, 0x01);
            L005E: ShowMessage(party, String182F); // You gain the skill of Detection!
            L006B: goto L010B;
            L006E: ax = GetSkillLevel5C(party, 0x0E);
            L007A: RefreshCompareFlags(ax);
            L007C: if (result.notequal) goto L009E;
            L007E: SetSkillLevel60(party, 0x0E, 0x01);
            L008F: ShowMessage(party, String1850); // You gain the skill of Lockpicking!
            L009C: goto L010B;
            L009E: ax = GetSkillLevel5C(party, 0x0C);
            L00AA: RefreshCompareFlags(ax);
            L00AC: if (result.notequal) goto L00CE;
            L00AE: SetSkillLevel60(party, 0x0C, 0x02);
            L00BF: ShowMessage(party, String1873); // You gain the Bard skill!
            L00CC: goto L010B;
            L00CE: ax = GetSkillLevel5C(party, 0x0F);
            L00DA: RefreshCompareFlags(ax);
            L00DC: if (result.notequal) goto L00FE;
            L00DE: SetSkillLevel60(party, 0x0F, 0x01);
            L00EF: ShowMessage(party, String188C); // You gain the Pickpocketing skill!
            L00FC: goto L010B;
            L00FE: ShowMessage(party, String18AE); // Nothing happens.
            L010B: goto L011A;
            L010D: ShowMessage(party, String18BF); // The shrines does nothing.
            L011A: // RETURN;
        }

        private override MapEventHandler MapEvent46 => LTENCI_46;
        private void LTENCI_46(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String18D9); // Thieves make a desperate stand.
            L0010: AddEncounter(party, 0x01, 0x01);
            L0022: AddEncounter(party, 0x05, 0x02);
            L0034: AddEncounter(party, 0x25, 0x03);
            L0046: AddEncounter(party, 0x26, 0x04);
            L0058: // RETURN;
        }

        private override MapEventHandler MapEvent47 => LTENCJ_47;
        private void LTENCJ_47(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String18F9); // Master Thieves Attack!
            L0010: AddEncounter(party, 0x04, 0x01);
            L0022: AddEncounter(party, 0x08, 0x02);
            L0034: AddEncounter(party, 0x25, 0x03);
            L0046: AddEncounter(party, 0x26, 0x04);
            L0058: AddEncounter(party, 0x27, 0x05);
            L006A: // RETURN;
        }

        private override MapEventHandler MapEvent48 => LTENCK_48;
        private void LTENCK_48(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1910); // Master Thieves ready themselves.
            L0010: AddEncounter(party, 0x25, 0x01);
            L0022: AddEncounter(party, 0x26, 0x02);
            L0034: AddEncounter(party, 0x10, 0x03);
            L0046: AddEncounter(party, 0x10, 0x04);
            L0058: AddEncounter(party, 0x02, 0x05);
            L006A: AddEncounter(party, 0x02, 0x06);
            L007C: ax = HasItem50(party, 0xDD);
            L008A: if (result.equal) goto L00AD;
            L008C: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L00AB: goto L00DB;
            L00AD: ShowMessage(party, String1931); // Light sparks off a key tied to the neck of the leader.
            L00BA: AddTreasure(party, 0x3A98, 0x00, 0x00, 0x46, 0x61, 0xDD);
            L00DB: // RETURN;
        }

        private override MapEventHandler MapEvent49 => TXTAWIND_49;
        private void TXTAWIND_49(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x000A);
            L0010: ShowMessage(party, String1968); // A voice echoes through the winds...
            L001D: ShowMessage(party, String198C); // 'You have traveled well, fair adventurers!
            L002A: ShowMessage(party, String19B7); // I laughed when you troubled King Cleowyn's ghost!
            L0037: ShowMessage(party, String19E9); // But now you enter my tunnels!  Go back whence you came!
            L0044: ShowMessage(party, String1A21); // The Winds will keep these places clean.'
            L0051: // RETURN;
        }

    }
}
