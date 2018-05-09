namespace ZCF.Scripts.Maps {
    class YserMap22 : ACanoMapScript {
        // === Strings ================================================
        private const string String03FC = "Other pits in the Labyrinth provide access to hidden areas...";
        private const string String043A = "This pit, however, sends you to the gates of Death.";
        private const string String046E = "A magical platform forms a bridge across the abyss.";
        private const string String04A2 = "You fall into the abyss and die.";
        private const string String04C3 = "With help, you might have been able to cross here.";
        private const string String04F6 = "Something strange happens!";
        private const string String0511 = "When you step onto the stone, a magical platform appears nearby.";
        private const string String0552 = "You do not suffer the death found in other pits in the Labyrinth.  Instead you are rewarded with a trip to CASTLEGATE BAZAAR.";
        private const string String05D0 = "The Dark Dwarf Voranti tricked the Lords of Harmony many moons ago.";
        private const string String0614 = "He stole the secrets of the Winds from the Lords and has used them for his own purposes every since.";
        private const string String0679 = "The Lords' Harmonic Shrine has now become the raging passageway known as HEAVEN'S FURY.";
        private const string String06D1 = "The survivors of the cataclysm named this place EXODUS.";
        private const string String0709 = "It is here they escaped the horrors of Arnakkian's Castle and began their new subterranean life.";
        private const string String076A = "No adventurer dares camp in WIND HOLLOW.  At night the howling wind makes one deaf to the dangers.";
        private const string String07CD = "TEMPEST dares all to explore the magic rooms along her narrow corridor.";
        private const string String0815 = "The barren rocks are swept clean by the violent winds that race through WIND HOLLOW.";
        private const string String086A = "'Beware!  Those who enter the Labyrinth BACK ALLEY must guard against all!'";
        private const string String08B6 = "Enter HEAVEN'S FURY if you must.  Here is where Voranti cursed the winds.";
        private const string String0900 = "The gates of LABYRINTH ATTIC are a welcome sight.";
        private const string String0932 = "The door leads to WYN SANCTUARY.";
        private const string String0953 = "The gateway opens, revealing the secret chambers of the Labyrinth Thieves.";
        private const string String099E = "You stumble into the lava pools.  You die.";
        private const string String09C9 = "This door locks out all except those who have the alley key.";
        private const string String0A06 = "Your key unlocks the door.";
        private const string String0A21 = "You return to LABYRINTH ATTIC through a one-way tunnel.";
        private const string String0A59 = "The door to WIND HOLLOW bursts open with terrible force, throwing all adventurers against the rocks...";
        private const string String0AC0 = "...and inflicting heavy damage.";
        private const string String0AE0 = "You have died.";
        private const string String0AEF = "Runes can be the most powerful of weapons in the hands of an adept Wizard.";
        private const string String0B3A = "Here, the runes also protect the great mage's magical possessions against the unwanted.";
        private const string String0B92 = "The Zephyr Wind whispers, 'I have taken the Harvest Horn, and I give you something to help defeat the Wind Elemental'.";
        private const string String0C09 = "The Zephyr Wind whistles 'No harm was intended, but I am sworn to serve the Wind Elemental.  Return the Harvest Horn to my Wyverns to release my bonds.'";
        private const string String0CA2 = "A magical platform nearby seems to disappear.";
        private const string String0CD0 = "The Zephyr Wind gusts in fury, causing damage!";
        private const string String0CFF = "You have died.";
        private const string String0D0E = "Wafts of reddish smoke eminate from the rooms ahead.";
        private const string String0D43 = "An acrid odor fills these chambers.";
        private const string String0D67 = "The fiery eyes of Ancient Dragons blaze through the thick clouds that fill the chamber.";
        private const string String0DBF = "You detect a secret door in the wall.";
        private const string String0DE5 = "A stash of wizard items is being raided.";
        private const string String0E0E = "You locate a hidden door in the wall.";
        private const string String0E34 = "A powerful Dwarf Thief stands before you. 'I am Voranti, Lord of Dwarf Thieves!  Fight me if you must, but you shall not find my secret treasure!  Do not fear, for I will provide decent burial when I am finished.'";
        private const string String0F0A = "Voranti's dark eyes glow bright with hatred. 'As for you, miserable Elf, my pet gargoyles will pick your bones clean.'";
        private const string String0F81 = "Voranti smiles sadly. 'It saddens me that I must kill a fellow dwarf, but you have brought death upon yourself.'";
        private const string String0FF2 = "You find a secret door in the wall.";
        private const string String1016 = "A nest of young dragons!";
        private const string String102F = "A yellowed piece of paper  --";
        private const string String104D = "'Help! My brother Orilon has been bitten by bears and is transformed.'  - signed Margery";
        private const string String10A6 = "A note -- 'Only past the Darkside will you find En-Li-Kil himself.'";
        private const string String10EA = "This door requires immense strength to open.";
        private const string String1117 = "You push against the door and barely manage to open it.";
        private const string String114F = "Your Moon Prism reveals a secret door!";
        private const string String1176 = "You find a door hidden in the wall.";
        private const string String119A = "The signature of the spectrum appears on the wall.";
        private const string String11CD = "In the wall is a secret door.";
        private const string String11EB = "Your Ranger skills help you locate a door hidden in the wall.";
        private const string String1229 = "Your holy calling allows you find a door hidden in the wall.";
        private const string String1266 = "You barely manage to force open the door.";
        private const string String1290 = "The door is stuck shut.";
        private const string String12A8 = "Your training helps you find a secret door in the wall.";
        private const string String12E0 = "You detect a door cleverly hidden in the wall.";
        private const string String130F = "Piles of dirt cover the floor.";
        private const string String132E = "You find a Moon Prism on the floor.";
        private const string String1352 = "The floor is bare.";
        private const string String1365 = "You find the Ranger Spear on the floor.";
        private const string String138D = "There is nothing of interest in this area.";
        private const string String13B8 = "You find a Holy Halberd lying on the floor.";
        private const string String13E4 = "Pictorials of War are painted on the walls surrounding Torbriar's Fountain.";
        private const string String1430 = "You gain the skill of Archery!";
        private const string String144F = "You gain the skill of Clubs and Axes!";
        private const string String1475 = "You gain the skill of Swordsmanship!";
        private const string String149A = "You gain the Bard skill!";
        private const string String14B3 = "You gain the skill of Martial Arts!";
        private const string String14D7 = "You gain the Channel skill!";
        private const string String14F3 = "The waters have no effect.";
        private const string String150E = "Dust fills the fountain basin.";
        private const string String152D = "A bard's scroll sings a simple song of how someday bands of adventurers will form an invisible bridge across a deadly chasm.";
        private const string String15AA = "A secret door visible only to knights appears in the wall .";
        private const string String15E6 = "In the wall you find a hidden door.";
        private const string String160A = "The wind is nasty here!  You take 100 damage.";
        private const string String1638 = "You have died.";
        private const string String1647 = "The Moon Hollow winds steals 300 Mana!";
        private const string String166E = "A violent whirlwind pounds you, taking half your health!";
        private const string String16A7 = "You have died.";
        
        // === Functions ================================================
        private override MapEventHandler MapEvent01 => DROP_01;
        private void DROP_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String03FC); // Other pits in the Labyrinth provide access to hidden areas...
            L0010: ShowMessage(party, String043A); // This pit, however, sends you to the gates of Death.
            L001D: ax = GetMaxHits74(party);
            L0024: DoDamage90(party, ax);
            L002E: // RETURN;
        }

        private override MapEventHandler MapEvent02 => XOVER_02;
        private void XOVER_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetNextTile20(party);
            L000A: compare(ax, 0x0047);
            L000D: if (result.notequal) goto L0070;
            L000F: ax = CheckState04(party, 0x01, 0x01);
            L0020: RefreshCompareFlags(ax);
            L0022: if (result.equal) goto L0043;
            L0024: SetMove38(party, 0x47, 0x00);
            L0034: ShowMessage(party, String046E); // A magical platform forms a bridge across the abyss.
            L0041: goto L006E;
            L0043: ShowMessage(party, String04A2); // You fall into the abyss and die.
            L0050: ShowMessage(party, String04C3); // With help, you might have been able to cross here.
            L005D: ax = GetMaxHits74(party);
            L0064: DoDamage90(party, ax);
            L006E: goto L00A8;
            L0070: ax = CheckState04(party, 0x01, 0x01);
            L0081: RefreshCompareFlags(ax);
            L0083: if (result.equal) goto L0097;
            L0085: SetMove38(party, 0x47, 0x00);
            L0095: goto L00A8;
            L0097: SetMove38(party, 0x47, 0x01);
            L00A8: // RETURN;
        }

        private override MapEventHandler MapEvent03 => XOVERON_03;
        private void XOVERON_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetState00(party, 0x01, 0x01, 0x01);
            L0018: SetMove38(party, 0x47, 0x00);
            L0028: ShowMessage(party, String04F6); // Something strange happens!
            L0035: ShowMessage(party, String0511); // When you step onto the stone, a magical platform appears nearby.
            L0042: // RETURN;
        }

        private override MapEventHandler MapEvent04 => BAZAAR_04;
        private void BAZAAR_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0552); // You do not suffer the death found in other pits in the Labyrinth.  Instead you are rewarded with a trip to CASTLEGATE BAZAAR.
            L0010: SetMoveMap(party, 0x03, 0x12, 0x01, 0x36);
            L002B: // RETURN;
        }

        private override MapEventHandler MapEvent05 => HEAVENS_05;
        private void HEAVENS_05(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String05D0); // The Dark Dwarf Voranti tricked the Lords of Harmony many moons ago.
            L0010: ShowMessage(party, String0614); // He stole the secrets of the Winds from the Lords and has used them for his own purposes every since.
            L001D: ShowMessage(party, String0679); // The Lords' Harmonic Shrine has now become the raging passageway known as HEAVEN'S FURY.
            L002A: SetMoveMap(party, 0x02, 0xA3, 0x01, 0x35);
            L0045: // RETURN;
        }

        private override MapEventHandler MapEvent06 => EXODUS_06;
        private void EXODUS_06(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06D1); // The survivors of the cataclysm named this place EXODUS.
            L0010: ShowMessage(party, String0709); // It is here they escaped the horrors of Arnakkian's Castle and began their new subterranean life.
            L001D: SetMoveMap(party, 0x02, 0x75, 0x01, 0x35);
            L0038: // RETURN;
        }

        private override MapEventHandler MapEvent07 => WINDHOLO_07;
        private void WINDHOLO_07(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String076A); // No adventurer dares camp in WIND HOLLOW.  At night the howling wind makes one deaf to the dangers.
            L0010: SetMoveMap(party, 0x03, 0x8A, 0x01, 0x35);
            L002B: // RETURN;
        }

        private override MapEventHandler MapEvent08 => TEMPEST_08;
        private void TEMPEST_08(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String07CD); // TEMPEST dares all to explore the magic rooms along her narrow corridor.
            L0010: SetMoveMap(party, 0x01, 0x9B, 0x01, 0x35);
            L002B: // RETURN;
        }

        private override MapEventHandler MapEvent09 => WINDHOLO_09;
        private void WINDHOLO_09(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0815); // The barren rocks are swept clean by the violent winds that race through WIND HOLLOW.
            L0010: SetMoveMap(party, 0x00, 0x7D, 0x01, 0x35);
            L002A: // RETURN;
        }

        private override MapEventHandler MapEvent0A => BACKALLY_0A;
        private void BACKALLY_0A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String086A); // 'Beware!  Those who enter the Labyrinth BACK ALLEY must guard against all!'
            L0010: SetMoveMap(party, 0x00, 0x4D, 0x01, 0x35);
            L002A: // RETURN;
        }

        private override MapEventHandler MapEvent0B => HEAVENS_0B;
        private void HEAVENS_0B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String08B6); // Enter HEAVEN'S FURY if you must.  Here is where Voranti cursed the winds.
            L0010: SetMoveMap(party, 0x02, 0xF3, 0x01, 0x35);
            L002B: // RETURN;
        }

        private override MapEventHandler MapEvent0C => LABYATIC_0C;
        private void LABYATIC_0C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0900); // The gates of LABYRINTH ATTIC are a welcome sight.
            L0010: SetMoveMap(party, 0x02, 0xC3, 0x01, 0x33);
            L002B: // RETURN;
        }

        private override MapEventHandler MapEvent0D => WINDHOLO_0D;
        private void WINDHOLO_0D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0932); // The door leads to WYN SANCTUARY.
            L0010: SetMoveMap(party, 0x00, 0x6D, 0x01, 0x33);
            L002A: // RETURN;
        }

        private override MapEventHandler MapEvent0E => THVTRESR_0E;
        private void THVTRESR_0E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0953); // The gateway opens, revealing the secret chambers of the Labyrinth Thieves.
            L0010: SetMoveMap(party, 0x02, 0x6E, 0x01, 0x33);
            L002B: // RETURN;
        }

        private override MapEventHandler MapEvent0F => LAVA_0F;
        private void LAVA_0F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String099E); // You stumble into the lava pools.  You die.
            L0010: ax = GetMaxHits74(party);
            L0017: DoDamage90(party, ax);
            L0021: // RETURN;
        }

        private override MapEventHandler MapEvent10 => DRTOBALY_10;
        private void DRTOBALY_10(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String09C9); // This door locks out all except those who have the alley key.
            L0010: ax = UsedItem54(party, 0xE0, 0xE0);
            L0023: if (result.equal) goto L0066;
            L0025: Push(01);
            L0029: Push(03);
            L002D: ax = GetNextTile20(party);
            L0034: PushStack(ax);
            L0035: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L003F: Push(03);
            L0043: ax = GetNextTile20(party);
            L004A: PushStack(ax);
            L004B: Push(01);
            L004F: SetUnblocked30(party);
            L0059: ShowMessage(party, String0A06); // Your key unlocks the door.
            L0066: // RETURN;
        }

        private override MapEventHandler MapEvent14 => LABYATIC_14;
        private void LABYATIC_14(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0A21); // You return to LABYRINTH ATTIC through a one-way tunnel.
            L0010: SetMoveMap(party, 0x02, 0x59, 0x01, 0x33);
            L002B: // RETURN;
        }

        private override MapEventHandler MapEvent15 => WINDHOLO_15;
        private void WINDHOLO_15(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0A59); // The door to WIND HOLLOW bursts open with terrible force, throwing all adventurers against the rocks...
            L0010: ShowMessage(party, String0AC0); // ...and inflicting heavy damage.
            L001D: DoDamage90(party, 0x00C8);
            L002A: ax = GetCurrentHits70(party);
            L0031: RefreshCompareFlags(ax);
            L0033: if (result.unsigned_greater_than) goto L0042;
            L0035: ShowMessage(party, String0AE0); // You have died.
            L0042: SetMoveMap(party, 0x03, 0xBC, 0x01, 0x35);
            L005D: // RETURN;
        }

        private override MapEventHandler MapEvent16 => MAGICRMS_16;
        private void MAGICRMS_16(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0AEF); // Runes can be the most powerful of weapons in the hands of an adept Wizard.
            L0010: ShowMessage(party, String0B3A); // Here, the runes also protect the great mage's magical possessions against the unwanted.
            L001D: SetMoveMap(party, 0x02, 0x30, 0x02, 0x34);
            L0038: // RETURN;
        }

        private override MapEventHandler MapEvent18 => ZEPHENCA_18;
        private void ZEPHENCA_18(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x16, 0x01);
            L0015: AddEncounter(party, 0x16, 0x02);
            L0027: AddEncounter(party, 0x19, 0x05);
            L0039: AddEncounter(party, 0x19, 0x06);
            L004B: ax = HasItem50(party, 0xB4);
            L0059: if (result.equal) goto L007C;
            L005B: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0xD1);
            L007A: goto L009D;
            L007C: AddTreasure(party, 0x07D0, 0x00, 0x00, 0xC8, 0xB4, 0xD0);
            L009D: // RETURN;
        }

        private override MapEventHandler MapEvent19 => ZEPHENCB_19;
        private void ZEPHENCB_19(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState08(party, 0x02, 0x79);
            L0016: if (result.equal) goto L007B;
            L0018: ax = HasItem50(party, 0x09);
            L0026: if (result.notequal) goto L0038;
            L0028: ax = HasItem50(party, 0xF0);
            L0036: if (result.equal) goto L005A;
            L0038: AddTreasure(party, 0x1388, 0x00, 0x00, 0x00, 0xB3, 0xD0);
            L0058: goto L0079;
            L005A: AddTreasure(party, 0x2710, 0x00, 0x00, 0x00, 0x00, 0xF0);
            L0079: goto L00EA;
            L007B: ax = HasItem50(party, 0xE6);
            L0089: if (result.equal) goto L00EA;
            L008B: RemoveItem4C(party, 0xE6);
            L0097: SetState00(party, 0x02, 0x79, 0x01);
            L00AC: AddTreasure(party, 0x2710, 0x00, 0x00, 0x00, 0x00, 0xF0);
            L00CB: AddExperience98(party, 0x0003D090);
            L00DD: ShowMessage(party, String0B92); // The Zephyr Wind whispers, 'I have taken the Harvest Horn, and I give you something to help defeat the Wind Elemental'.
            L00EA: AddEncounter(party, 0x10, 0x01);
            L00FC: AddEncounter(party, 0x10, 0x02);
            L010E: AddEncounter(party, 0x0F, 0x05);
            L0120: AddEncounter(party, 0x0F, 0x06);
            L0132: // RETURN;
        }

        private override MapEventHandler MapEvent1B => TXTZEPHR_1B;
        private void TXTZEPHR_1B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0C09); // The Zephyr Wind whistles 'No harm was intended, but I am sworn to serve the Wind Elemental.  Return the Harvest Horn to my Wyverns to release my bonds.'
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent1C => XOVEROFF_1C;
        private void XOVEROFF_1C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetState00(party, 0x01, 0x01, 0x00);
            L0017: SetMove38(party, 0x47, 0x01);
            L0028: ShowMessage(party, String0CA2); // A magical platform nearby seems to disappear.
            L0035: // RETURN;
        }

        private override MapEventHandler MapEvent1D => ZEPHBLOW_1D;
        private void ZEPHBLOW_1D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0CD0); // The Zephyr Wind gusts in fury, causing damage!
            L0010: ax = GetMaxHits74(party);
            L0017: bx = 0x0003;
            L001A: dx = ax % bx; ax = ax / bx; // (signed, dx = quotient)
            L001D: DoDamage90(party, ax);
            L0027: ax = GetCurrentHits70(party);
            L002E: RefreshCompareFlags(ax);
            L0030: if (result.unsigned_greater_than) goto L003F;
            L0032: ShowMessage(party, String0CFF); // You have died.
            L003F: // RETURN;
        }

        private override MapEventHandler MapEvent1E => DRLPENCA_1E;
        private void DRLPENCA_1E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0D0E); // Wafts of reddish smoke eminate from the rooms ahead.
            L0010: AddEncounter(party, 0x19, 0x01);
            L0022: AddEncounter(party, 0x19, 0x02);
            L0034: AddEncounter(party, 0x0F, 0x05);
            L0046: AddEncounter(party, 0x0F, 0x06);
            L0058: // RETURN;
        }

        private override MapEventHandler MapEvent1F => DRLPENCB_1F;
        private void DRLPENCB_1F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0D43); // An acrid odor fills these chambers.
            L0010: AddEncounter(party, 0x0F, 0x01);
            L0022: AddEncounter(party, 0x0F, 0x02);
            L0034: AddEncounter(party, 0x1B, 0x05);
            L0046: AddEncounter(party, 0x1B, 0x06);
            L0058: // RETURN;
        }

        private override MapEventHandler MapEvent20 => DRLPENCC_20;
        private void DRLPENCC_20(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0D67); // The fiery eyes of Ancient Dragons blaze through the thick clouds that fill the chamber.
            L0010: AddEncounter(party, 0x1C, 0x01);
            L0022: AddEncounter(party, 0x1C, 0x02);
            L0034: AddEncounter(party, 0x1C, 0x03);
            L0046: AddEncounter(party, 0x1C, 0x04);
            L0058: AddEncounter(party, 0x1A, 0x05);
            L006A: AddEncounter(party, 0x1A, 0x06);
            L007C: ax = HasItem50(party, 0xDF);
            L008A: if (result.equal) goto L00AD;
            L008C: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0xD1);
            L00AB: goto L00CE;
            L00AD: AddTreasure(party, 0x4E20, 0x00, 0x00, 0xDF, 0x46, 0x6E);
            L00CE: // RETURN;
        }

        private override MapEventHandler MapEvent21 => ZZYZENCA_21;
        private void ZZYZENCA_21(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x1E, 0x01);
            L0015: AddEncounter(party, 0x1E, 0x02);
            L0027: AddEncounter(party, 0x1E, 0x03);
            L0039: AddEncounter(party, 0x1E, 0x04);
            L004B: AddEncounter(party, 0x1D, 0x05);
            L005D: AddEncounter(party, 0x1D, 0x06);
            L006F: AddTreasure(party, 0x1388, 0x00, 0x00, 0x17, 0x08, 0x6C);
            L0090: // RETURN;
        }

        private override MapEventHandler MapEvent23 => SDRZZYZA_23;
        private void SDRZZYZA_23(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L000F: compare(ax, 0x000B);
            L0012: if (result.above or result.equal) goto L0039;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (result.notequal) goto L0039;
            L0024: ax = UsedItem54(party, 0xBE, 0xBE);
            L0037: if (result.equal) goto L0082;
            L0039: ShowMessage(party, String0DBF); // You detect a secret door in the wall.
            L0046: Push(01);
            L004A: ax = GetFacing24(party);
            L0051: PushStack(ax);
            L0052: ax = GetNextTile20(party);
            L0059: PushStack(ax);
            L005A: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0064: ax = GetFacing24(party);
            L006B: PushStack(ax);
            L006C: ax = GetNextTile20(party);
            L0073: PushStack(ax);
            L0074: Push(01);
            L0078: SetUnblocked30(party);
            L0082: // RETURN;
        }

        private override MapEventHandler MapEvent24 => ZZYZENCC_24;
        private void ZZYZENCC_24(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x10, 0x01);
            L0015: AddEncounter(party, 0x10, 0x02);
            L0027: AddEncounter(party, 0x1D, 0x03);
            L0039: AddEncounter(party, 0x1D, 0x04);
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent25 => MGOVENCA_25;
        private void MGOVENCA_25(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0DE5); // A stash of wizard items is being raided.
            L0010: AddEncounter(party, 0x1F, 0x01);
            L0022: AddEncounter(party, 0x1F, 0x02);
            L0034: AddEncounter(party, 0x20, 0x03);
            L0046: AddEncounter(party, 0x20, 0x04);
            L0058: AddTreasure(party, 0x03E8, 0x00, 0x00, 0xCA, 0xB2, 0xB1);
            L0079: // RETURN;
        }

        private override MapEventHandler MapEvent26 => MGOVENCB_26;
        private void MGOVENCB_26(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x1F, 0x01);
            L0015: AddEncounter(party, 0x1F, 0x02);
            L0027: AddEncounter(party, 0x1F, 0x03);
            L0039: AddEncounter(party, 0x19, 0x04);
            L004B: AddEncounter(party, 0x05, 0x05);
            L005D: // RETURN;
        }

        private override MapEventHandler MapEvent28 => SDRMGOVA_28;
        private void SDRMGOVA_28(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetGuild7C(party);
            L000A: compare(ax, 0x0005);
            L000D: if (result.equal) goto L0012;
            L000F: goto L0091;
            L0012: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L001E: compare(ax, 0x000C);
            L0021: if (result.above or result.equal) goto L0048;
            L0023: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L002F: RefreshCompareFlags(ax);
            L0031: if (result.notequal) goto L0048;
            L0033: ax = UsedItem54(party, 0xBE, 0xBE);
            L0046: if (result.equal) goto L0091;
            L0048: ShowMessage(party, String0E0E); // You locate a hidden door in the wall.
            L0055: Push(01);
            L0059: ax = GetFacing24(party);
            L0060: PushStack(ax);
            L0061: ax = GetNextTile20(party);
            L0068: PushStack(ax);
            L0069: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0073: ax = GetFacing24(party);
            L007A: PushStack(ax);
            L007B: ax = GetNextTile20(party);
            L0082: PushStack(ax);
            L0083: Push(01);
            L0087: SetUnblocked30(party);
            L0091: // RETURN;
        }

        private override MapEventHandler MapEvent29 => VORAENCA_29;
        private void VORAENCA_29(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x22, 0x01);
            L0015: AddEncounter(party, 0x22, 0x02);
            L0027: AddEncounter(party, 0x10, 0x03);
            L0039: AddEncounter(party, 0x10, 0x04);
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent2A => VORAENCB_2A;
        private void VORAENCB_2A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x22, 0x01);
            L0015: AddEncounter(party, 0x22, 0x02);
            L0027: AddEncounter(party, 0x15, 0x03);
            L0039: AddEncounter(party, 0x12, 0x04);
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent30 => VORAENCV_30;
        private void VORAENCV_30(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0E34); // A powerful Dwarf Thief stands before you. 'I am Voranti, Lord of Dwarf Thieves!  Fight me if you must, but you shall not find my secret treasure!  Do not fear, for I will provide decent burial when I am finished.'
            L0010: ax = GetRace78(party);
            L0017: compare(ax, 0x0002);
            L001A: if (result.notequal) goto L0029;
            L001C: ShowMessage(party, String0F0A); // Voranti's dark eyes glow bright with hatred. 'As for you, miserable Elf, my pet gargoyles will pick your bones clean.'
            L0029: ax = GetRace78(party);
            L0030: compare(ax, 0x0004);
            L0033: if (result.notequal) goto L0042;
            L0035: ShowMessage(party, String0F81); // Voranti smiles sadly. 'It saddens me that I must kill a fellow dwarf, but you have brought death upon yourself.'
            L0042: AddEncounter(party, 0x1C, 0x01);
            L0054: AddEncounter(party, 0x21, 0x05);
            L0066: ax = HasItem50(party, 0xED);
            L0074: if (result.equal) goto L0097;
            L0076: AddTreasure(party, 0x1388, 0x00, 0x00, 0x00, 0x00, 0xCC);
            L0095: goto L00B6;
            L0097: AddTreasure(party, 0x2710, 0x00, 0x00, 0x00, 0x00, 0xED);
            L00B6: // RETURN;
        }

        private override MapEventHandler MapEvent31 => SDRVORDW_31;
        private void SDRVORDW_31(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L000F: compare(ax, 0x000B);
            L0012: if (result.above or result.equal) goto L0039;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (result.notequal) goto L0039;
            L0024: ax = UsedItem54(party, 0xBE, 0xBE);
            L0037: if (result.equal) goto L0082;
            L0039: ShowMessage(party, String0FF2); // You find a secret door in the wall.
            L0046: ax = GetFacing24(party);
            L004D: PushStack(ax);
            L004E: ax = GetNextTile20(party);
            L0055: PushStack(ax);
            L0056: Push(01);
            L005A: SetUnblocked30(party);
            L0064: Push(01);
            L0068: ax = GetFacing24(party);
            L006F: PushStack(ax);
            L0070: ax = GetNextTile20(party);
            L0077: PushStack(ax);
            L0078: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0082: // RETURN;
        }

        private override MapEventHandler MapEvent32 => MOONENCA_32;
        private void MOONENCA_32(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x0A, 0x01);
            L0015: AddEncounter(party, 0x0A, 0x02);
            L0027: AddEncounter(party, 0x24, 0x03);
            L0039: AddEncounter(party, 0x24, 0x04);
            L004B: ax = HasItem50(party, 0xBE);
            L0059: if (result.equal) goto L007D;
            L005B: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0xD0, 0xB7);
            L007B: goto L009E;
            L007D: AddTreasure(party, 0x1388, 0x00, 0x00, 0xC6, 0xD1, 0xBE);
            L009E: // RETURN;
        }

        private override MapEventHandler MapEvent33 => MOONENCB_33;
        private void MOONENCB_33(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x26, 0x01);
            L0015: AddEncounter(party, 0x26, 0x02);
            L0027: AddEncounter(party, 0x25, 0x03);
            L0039: AddEncounter(party, 0x26, 0x05);
            L004B: AddEncounter(party, 0x26, 0x06);
            L005D: AddTreasure(party, 0x1B58, 0x00, 0x00, 0x00, 0x59, 0x13);
            L007D: // RETURN;
        }

        private override MapEventHandler MapEvent34 => MOONENCC_34;
        private void MOONENCC_34(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x0E, 0x01);
            L0015: AddEncounter(party, 0x0E, 0x02);
            L0027: AddEncounter(party, 0x1C, 0x03);
            L0039: AddEncounter(party, 0x1C, 0x04);
            L004B: AddEncounter(party, 0x1B, 0x05);
            L005D: AddEncounter(party, 0x1B, 0x06);
            L006F: AddTreasure(party, 0x2710, 0x00, 0x00, 0x00, 0x83, 0x10);
            L008F: // RETURN;
        }

        private override MapEventHandler MapEvent35 => MOONENCD_35;
        private void MOONENCD_35(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x24, 0x01);
            L0015: AddEncounter(party, 0x24, 0x02);
            L0027: AddEncounter(party, 0x24, 0x03);
            L0039: AddEncounter(party, 0x24, 0x04);
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent36 => MOONENCE_36;
        private void MOONENCE_36(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1016); // A nest of young dragons!
            L0010: AddEncounter(party, 0x0E, 0x01);
            L0022: AddEncounter(party, 0x0E, 0x02);
            L0034: AddEncounter(party, 0x0F, 0x03);
            L0046: AddEncounter(party, 0x1C, 0x04);
            L0058: // RETURN;
        }

        private override MapEventHandler MapEvent37 => MOONENCF_37;
        private void MOONENCF_37(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x24, 0x01);
            L0015: AddEncounter(party, 0x24, 0x02);
            L0027: AddEncounter(party, 0x24, 0x05);
            L0039: // RETURN;
        }

        private override MapEventHandler MapEvent38 => MOONENCG_38;
        private void MOONENCG_38(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String102F); // A yellowed piece of paper  --
            L0010: ShowMessage(party, String104D); // 'Help! My brother Orilon has been bitten by bears and is transformed.'  - signed Margery
            L001D: AddEncounter(party, 0x28, 0x01);
            L002F: AddEncounter(party, 0x28, 0x02);
            L0041: AddEncounter(party, 0x28, 0x03);
            L0053: AddEncounter(party, 0x24, 0x05);
            L0065: AddEncounter(party, 0x24, 0x06);
            L0077: ax = HasItem50(party, 0xEA);
            L0085: if (result.equal) goto L00A8;
            L0087: AddTreasure(party, 0x2328, 0x00, 0x00, 0x00, 0x00, 0xBB);
            L00A6: goto L00C8;
            L00A8: AddTreasure(party, 0x1388, 0x00, 0x00, 0x00, 0xEA, 0x85);
            L00C8: // RETURN;
        }

        private override MapEventHandler MapEvent3A => TXTMOONB_3A;
        private void TXTMOONB_3A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String10A6); // A note -- 'Only past the Darkside will you find En-Li-Kil himself.'
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent3B => MOONENCJ_3B;
        private void MOONENCJ_3B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x12, 0x01);
            L0015: AddEncounter(party, 0x12, 0x02);
            L0027: AddEncounter(party, 0x1E, 0x03);
            L0039: AddEncounter(party, 0x1E, 0x04);
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent3C => MOONENCK_3C;
        private void MOONENCK_3C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x26, 0x01);
            L0015: AddEncounter(party, 0x26, 0x02);
            L0027: AddEncounter(party, 0x26, 0x03);
            L0039: AddEncounter(party, 0x25, 0x05);
            L004B: AddEncounter(party, 0x25, 0x06);
            L005D: // RETURN;
        }

        private override MapEventHandler MapEvent3E => BDRMOONB_3E;
        private void BDRMOONB_3E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String10EA); // This door requires immense strength to open.
            L0010: ax = CheckStrengthA4(party);
            L001C: compare(ax, 0x0015);
            L001F: if (result.below) goto L006A;
            L0021: ShowMessage(party, String1117); // You push against the door and barely manage to open it.
            L002E: ax = GetFacing24(party);
            L0035: PushStack(ax);
            L0036: ax = GetNextTile20(party);
            L003D: PushStack(ax);
            L003E: Push(01);
            L0042: SetUnblocked30(party);
            L004C: Push(01);
            L0050: ax = GetFacing24(party);
            L0057: PushStack(ax);
            L0058: ax = GetNextTile20(party);
            L005F: PushStack(ax);
            L0060: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L006A: // RETURN;
        }

        private override MapEventHandler MapEvent3F => SDRMOONC_3F;
        private void SDRMOONC_3F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xF2, 0xF2);
            L0016: if (result.equal) goto L0061;
            L0018: ShowMessage(party, String114F); // Your Moon Prism reveals a secret door!
            L0025: ax = GetFacing24(party);
            L002C: PushStack(ax);
            L002D: ax = GetNextTile20(party);
            L0034: PushStack(ax);
            L0035: Push(01);
            L0039: SetUnblocked30(party);
            L0043: Push(01);
            L0047: ax = GetFacing24(party);
            L004E: PushStack(ax);
            L004F: ax = GetNextTile20(party);
            L0056: PushStack(ax);
            L0057: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0061: // RETURN;
        }

        private override MapEventHandler MapEvent40 => SDRMOOND_40;
        private void SDRMOOND_40(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L000F: compare(ax, 0x000B);
            L0012: if (result.above or result.equal) goto L004E;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (result.notequal) goto L004E;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (result.notequal) goto L004E;
            L0039: ax = UsedItem54(party, 0xBE, 0xBE);
            L004C: if (result.equal) goto L0097;
            L004E: ShowMessage(party, String1176); // You find a door hidden in the wall.
            L005B: ax = GetFacing24(party);
            L0062: PushStack(ax);
            L0063: ax = GetNextTile20(party);
            L006A: PushStack(ax);
            L006B: Push(01);
            L006F: SetUnblocked30(party);
            L0079: Push(01);
            L007D: ax = GetFacing24(party);
            L0084: PushStack(ax);
            L0085: ax = GetNextTile20(party);
            L008C: PushStack(ax);
            L008D: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0097: // RETURN;
        }

        private override MapEventHandler MapEvent41 => SDRMOONE_41;
        private void SDRMOONE_41(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String119A); // The signature of the spectrum appears on the wall.
            L0010: ax = UsedItem54(party, 0xBD, 0xBD);
            L0023: if (result.notequal) goto L003A;
            L0025: ax = UsedItem54(party, 0xBE, 0xBE);
            L0038: if (result.equal) goto L0083;
            L003A: ShowMessage(party, String11CD); // In the wall is a secret door.
            L0047: ax = GetFacing24(party);
            L004E: PushStack(ax);
            L004F: ax = GetNextTile20(party);
            L0056: PushStack(ax);
            L0057: Push(01);
            L005B: SetUnblocked30(party);
            L0065: Push(01);
            L0069: ax = GetFacing24(party);
            L0070: PushStack(ax);
            L0071: ax = GetNextTile20(party);
            L0078: PushStack(ax);
            L0079: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0083: // RETURN;
        }

        private override MapEventHandler MapEvent42 => MOONENCM_42;
        private void MOONENCM_42(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x26, 0x01);
            L0015: AddEncounter(party, 0x26, 0x02);
            L0027: AddEncounter(party, 0x25, 0x03);
            L0039: AddEncounter(party, 0x25, 0x04);
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent43 => SDRMOONF_43;
        private void SDRMOONF_43(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetGuild7C(party);
            L000A: compare(ax, 0x0002);
            L000D: if (result.equal) goto L0012;
            L000F: goto L0091;
            L0012: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L001E: compare(ax, 0x000A);
            L0021: if (result.above or result.equal) goto L0048;
            L0023: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L002F: RefreshCompareFlags(ax);
            L0031: if (result.notequal) goto L0048;
            L0033: ax = UsedItem54(party, 0xBE, 0xBE);
            L0046: if (result.equal) goto L0091;
            L0048: ShowMessage(party, String11EB); // Your Ranger skills help you locate a door hidden in the wall.
            L0055: ax = GetFacing24(party);
            L005C: PushStack(ax);
            L005D: ax = GetNextTile20(party);
            L0064: PushStack(ax);
            L0065: Push(01);
            L0069: SetUnblocked30(party);
            L0073: Push(01);
            L0077: ax = GetFacing24(party);
            L007E: PushStack(ax);
            L007F: ax = GetNextTile20(party);
            L0086: PushStack(ax);
            L0087: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0091: // RETURN;
        }

        private override MapEventHandler MapEvent44 => SDRMOONJ_44;
        private void SDRMOONJ_44(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetGuild7C(party);
            L000A: compare(ax, 0x0004);
            L000D: if (result.equal) goto L0012;
            L000F: goto L0091;
            L0012: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L001E: compare(ax, 0x000A);
            L0021: if (result.above or result.equal) goto L0048;
            L0023: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L002F: RefreshCompareFlags(ax);
            L0031: if (result.notequal) goto L0048;
            L0033: ax = UsedItem54(party, 0xBE, 0xBE);
            L0046: if (result.equal) goto L0091;
            L0048: ShowMessage(party, String1229); // Your holy calling allows you find a door hidden in the wall.
            L0055: ax = GetFacing24(party);
            L005C: PushStack(ax);
            L005D: ax = GetNextTile20(party);
            L0064: PushStack(ax);
            L0065: Push(01);
            L0069: SetUnblocked30(party);
            L0073: Push(01);
            L0077: ax = GetFacing24(party);
            L007E: PushStack(ax);
            L007F: ax = GetNextTile20(party);
            L0086: PushStack(ax);
            L0087: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0091: // RETURN;
        }

        private override MapEventHandler MapEvent45 => BDRMOONK_45;
        private void BDRMOONK_45(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckStrengthA4(party);
            L000F: compare(ax, 0x0014);
            L0012: if (result.below) goto L005F;
            L0014: ShowMessage(party, String1266); // You barely manage to force open the door.
            L0021: ax = GetFacing24(party);
            L0028: PushStack(ax);
            L0029: ax = GetNextTile20(party);
            L0030: PushStack(ax);
            L0031: Push(01);
            L0035: SetUnblocked30(party);
            L003F: Push(01);
            L0043: ax = GetFacing24(party);
            L004A: PushStack(ax);
            L004B: ax = GetNextTile20(party);
            L0052: PushStack(ax);
            L0053: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L005D: goto L00A7;
            L005F: ShowMessage(party, String1290); // The door is stuck shut.
            L006C: ax = GetFacing24(party);
            L0073: PushStack(ax);
            L0074: ax = GetNextTile20(party);
            L007B: PushStack(ax);
            L007C: Push(01);
            L0080: SetUnblocked30(party);
            L008A: PushStack(0x00);
            L008D: ax = GetFacing24(party);
            L0094: PushStack(ax);
            L0095: ax = GetNextTile20(party);
            L009C: PushStack(ax);
            L009D: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L00A7: // RETURN;
        }

        private override MapEventHandler MapEvent46 => SDRMOONM_46;
        private void SDRMOONM_46(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L000F: compare(ax, 0x0008);
            L0012: if (result.above or result.equal) goto L0039;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (result.notequal) goto L0039;
            L0024: ax = UsedItem54(party, 0xBE, 0xBE);
            L0037: if (result.equal) goto L0082;
            L0039: ShowMessage(party, String12A8); // Your training helps you find a secret door in the wall.
            L0046: Push(01);
            L004A: ax = GetFacing24(party);
            L0051: PushStack(ax);
            L0052: ax = GetNextTile20(party);
            L0059: PushStack(ax);
            L005A: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0064: ax = GetFacing24(party);
            L006B: PushStack(ax);
            L006C: ax = GetNextTile20(party);
            L0073: PushStack(ax);
            L0074: Push(01);
            L0078: SetUnblocked30(party);
            L0082: // RETURN;
        }

        private override MapEventHandler MapEvent47 => SDRMOONN_47;
        private void SDRMOONN_47(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String12E0); // You detect a door cleverly hidden in the wall.
            L0010: ax = GetFacing24(party);
            L0017: PushStack(ax);
            L0018: ax = GetNextTile20(party);
            L001F: PushStack(ax);
            L0020: Push(01);
            L0024: SetUnblocked30(party);
            L002E: Push(01);
            L0032: ax = GetFacing24(party);
            L0039: PushStack(ax);
            L003A: ax = GetNextTile20(party);
            L0041: PushStack(ax);
            L0042: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L004C: // RETURN;
        }

        private override MapEventHandler MapEvent48 => MOONTRSA_48;
        private void MOONTRSA_48(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xF2);
            L0011: if (result.equal) goto L0022;
            L0013: ShowMessage(party, String130F); // Piles of dirt cover the floor.
            L0020: goto L0050;
            L0022: GiveItem48(party, 0xF2);
            L002E: SetState00(party, 0x02, 0x46, 0x01);
            L0043: ShowMessage(party, String132E); // You find a Moon Prism on the floor.
            L0050: // RETURN;
        }

        private override MapEventHandler MapEvent49 => MOONTRSB_49;
        private void MOONTRSB_49(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x47);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L0028;
            L0019: ShowMessage(party, String1352); // The floor is bare.
            L0026: goto L0056;
            L0028: GiveItem48(party, 0x37);
            L0034: SetState00(party, 0x02, 0x47, 0x01);
            L0049: ShowMessage(party, String1365); // You find the Ranger Spear on the floor.
            L0056: // RETURN;
        }

        private override MapEventHandler MapEvent4A => MOONTRSC_4A;
        private void MOONTRSC_4A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckState04(party, 0x02, 0x48);
            L0014: compare(ax, 0x0001);
            L0017: if (result.notequal) goto L0028;
            L0019: ShowMessage(party, String138D); // There is nothing of interest in this area.
            L0026: goto L0056;
            L0028: GiveItem48(party, 0x3D);
            L0034: SetState00(party, 0x02, 0x48, 0x01);
            L0049: ShowMessage(party, String13B8); // You find a Holy Halberd lying on the floor.
            L0056: // RETURN;
        }

        private override MapEventHandler MapEvent4B => TORBFOUN_4B;
        private void TORBFOUN_4B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0042);
            L0010: ShowMessage(party, String13E4); // Pictorials of War are painted on the walls surrounding Torbriar's Fountain.
            L001D: ax = CheckState04(party, 0x02, 0x63);
            L002E: RefreshCompareFlags(ax);
            L0030: if (result.equal) goto L0035;
            L0032: goto L017C;
            L0035: SetState00(party, 0x02, 0x63, 0x01);
            L004A: ax = GetSkillLevel5C(party, 0x08);
            L0056: RefreshCompareFlags(ax);
            L0058: if (result.notequal) goto L007B;
            L005A: SetSkillLevel60(party, 0x08, 0x02);
            L006B: ShowMessage(party, String1430); // You gain the skill of Archery!
            L0078: goto L017A;
            L007B: ax = GetSkillLevel5C(party, 0x01);
            L0087: RefreshCompareFlags(ax);
            L0089: if (result.notequal) goto L00AC;
            L008B: SetSkillLevel60(party, 0x01, 0x02);
            L009C: ShowMessage(party, String144F); // You gain the skill of Clubs and Axes!
            L00A9: goto L017A;
            L00AC: ax = GetSkillLevel5C(party, 0x05);
            L00B8: RefreshCompareFlags(ax);
            L00BA: if (result.notequal) goto L00DD;
            L00BC: SetSkillLevel60(party, 0x05, 0x02);
            L00CD: ShowMessage(party, String1475); // You gain the skill of Swordsmanship!
            L00DA: goto L017A;
            L00DD: ax = GetSkillLevel5C(party, 0x0C);
            L00E9: RefreshCompareFlags(ax);
            L00EB: if (result.notequal) goto L010D;
            L00ED: SetSkillLevel60(party, 0x0C, 0x02);
            L00FE: ShowMessage(party, String149A); // You gain the Bard skill!
            L010B: goto L017A;
            L010D: ax = GetSkillLevel5C(party, 0x10);
            L0119: RefreshCompareFlags(ax);
            L011B: if (result.notequal) goto L013D;
            L011D: SetSkillLevel60(party, 0x10, 0x02);
            L012E: ShowMessage(party, String14B3); // You gain the skill of Martial Arts!
            L013B: goto L017A;
            L013D: ax = GetSkillLevel5C(party, 0x16);
            L0149: RefreshCompareFlags(ax);
            L014B: if (result.notequal) goto L016D;
            L014D: SetSkillLevel60(party, 0x16, 0x02);
            L015E: ShowMessage(party, String14D7); // You gain the Channel skill!
            L016B: goto L017A;
            L016D: ShowMessage(party, String14F3); // The waters have no effect.
            L017A: goto L0189;
            L017C: ShowMessage(party, String150E); // Dust fills the fountain basin.
            L0189: // RETURN;
        }

        private override MapEventHandler MapEvent4C => TORBENCB_4C;
        private void TORBENCB_4C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x28, 0x01);
            L0015: AddEncounter(party, 0x28, 0x02);
            L0027: AddEncounter(party, 0x27, 0x04);
            L0039: AddEncounter(party, 0x15, 0x05);
            L004B: AddEncounter(party, 0x15, 0x06);
            L005D: ax = GetGuild7C(party);
            L0064: RefreshCompareFlags(ax);
            L0066: if (result.notequal) goto L0087;
            L0068: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x18);
            L0087: ax = GetGuild7C(party);
            L008E: compare(ax, 0x0001);
            L0091: if (result.notequal) goto L00B2;
            L0093: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x11);
            L00B2: // RETURN;
        }

        private override MapEventHandler MapEvent4D => TORBENCC_4D;
        private void TORBENCC_4D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x28, 0x01);
            L0015: AddEncounter(party, 0x28, 0x02);
            L0027: AddEncounter(party, 0x15, 0x03);
            L0039: AddEncounter(party, 0x15, 0x04);
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent52 => TXTTORB_52;
        private void TXTTORB_52(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String152D); // A bard's scroll sings a simple song of how someday bands of adventurers will form an invisible bridge across a deadly chasm.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent53 => SDRTORBA_53;
        private void SDRTORBA_53(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetGuild7C(party);
            L000A: compare(ax, 0x0001);
            L000D: if (result.equal) goto L0012;
            L000F: goto L0091;
            L0012: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L001E: compare(ax, 0x0008);
            L0021: if (result.above or result.equal) goto L0048;
            L0023: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L002F: RefreshCompareFlags(ax);
            L0031: if (result.notequal) goto L0048;
            L0033: ax = UsedItem54(party, 0xBE, 0xBE);
            L0046: if (result.equal) goto L0091;
            L0048: ShowMessage(party, String15AA); // A secret door visible only to knights appears in the wall .
            L0055: Push(01);
            L0059: ax = GetFacing24(party);
            L0060: PushStack(ax);
            L0061: ax = GetNextTile20(party);
            L0068: PushStack(ax);
            L0069: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0073: ax = GetFacing24(party);
            L007A: PushStack(ax);
            L007B: ax = GetNextTile20(party);
            L0082: PushStack(ax);
            L0083: Push(01);
            L0087: SetUnblocked30(party);
            L0091: // RETURN;
        }

        private override MapEventHandler MapEvent54 => SDRTORBB_54;
        private void SDRTORBB_54(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetGuild7C(party);
            L000A: RefreshCompareFlags(ax);
            L000C: if (result.equal) goto L0011;
            L000E: goto L0090;
            L0011: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L001D: compare(ax, 0x0008);
            L0020: if (result.above or result.equal) goto L0047;
            L0022: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L002E: RefreshCompareFlags(ax);
            L0030: if (result.notequal) goto L0047;
            L0032: ax = UsedItem54(party, 0xBE, 0xBE);
            L0045: if (result.equal) goto L0090;
            L0047: ShowMessage(party, String15E6); // In the wall you find a hidden door.
            L0054: Push(01);
            L0058: ax = GetFacing24(party);
            L005F: PushStack(ax);
            L0060: ax = GetNextTile20(party);
            L0067: PushStack(ax);
            L0068: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0072: ax = GetFacing24(party);
            L0079: PushStack(ax);
            L007A: ax = GetNextTile20(party);
            L0081: PushStack(ax);
            L0082: Push(01);
            L0086: SetUnblocked30(party);
            L0090: // RETURN;
        }

        private override MapEventHandler MapEvent55 => TORBWIND_55;
        private void TORBWIND_55(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String160A); // The wind is nasty here!  You take 100 damage.
            L0010: DoDamage90(party, 0x0064);
            L001D: ax = GetCurrentHits70(party);
            L0024: RefreshCompareFlags(ax);
            L0026: if (result.unsigned_greater_than) goto L0035;
            L0028: ShowMessage(party, String1638); // You have died.
            L0035: // RETURN;
        }

        private override MapEventHandler MapEvent56 => MOONWIND_56;
        private void MOONWIND_56(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1647); // The Moon Hollow winds steals 300 Mana!
            L0010: AddMana(party, 0xFED4);
            L001D: // RETURN;
        }

        private override MapEventHandler MapEvent57 => VORAWIND_57;
        private void VORAWIND_57(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String166E); // A violent whirlwind pounds you, taking half your health!
            L0010: ax = GetCurrentHits70(party);
            L0017: bx = 0x0002;
            L001A: dx = ax % bx; ax = ax / bx; // (signed, dx = quotient)
            L001D: DoDamage90(party, ax);
            L0027: ax = GetCurrentHits70(party);
            L002E: RefreshCompareFlags(ax);
            L0030: if (result.unsigned_greater_than) goto L003F;
            L0032: ShowMessage(party, String16A7); // You have died.
            L003F: // RETURN;
        }

    }
}
