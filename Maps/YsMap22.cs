#pragma warning disable
using XPT.WorldData;

namespace XPT.Scripts.Maps {
    class YserMap22 : AMapScripted {
        protected override int MapIndex => 22;
        
        public YserMap22() {
            MapEvent01 = FnDROP_01;
            MapEvent02 = FnXOVER_02;
            MapEvent03 = FnXOVERON_03;
            MapEvent04 = FnBAZAAR_04;
            MapEvent05 = FnHEAVENS_05;
            MapEvent06 = FnEXODUS_06;
            MapEvent07 = FnWINDHOLO_07;
            MapEvent08 = FnTEMPEST_08;
            MapEvent09 = FnWINDHOLO_09;
            MapEvent0A = FnBACKALLY_0A;
            MapEvent0B = FnHEAVENS_0B;
            MapEvent0C = FnLABYATIC_0C;
            MapEvent0D = FnWINDHOLO_0D;
            MapEvent0E = FnTHVTRESR_0E;
            MapEvent0F = FnLAVA_0F;
            MapEvent10 = FnDRTOBALY_10;
            MapEvent14 = FnLABYATIC_14;
            MapEvent15 = FnWINDHOLO_15;
            MapEvent16 = FnMAGICRMS_16;
            MapEvent18 = FnZEPHENCA_18;
            MapEvent19 = FnZEPHENCB_19;
            MapEvent1B = FnTXTZEPHR_1B;
            MapEvent1C = FnXOVEROFF_1C;
            MapEvent1D = FnZEPHBLOW_1D;
            MapEvent1E = FnDRLPENCA_1E;
            MapEvent1F = FnDRLPENCB_1F;
            MapEvent20 = FnDRLPENCC_20;
            MapEvent21 = FnZZYZENCA_21;
            MapEvent23 = FnSDRZZYZA_23;
            MapEvent24 = FnZZYZENCC_24;
            MapEvent25 = FnMGOVENCA_25;
            MapEvent26 = FnMGOVENCB_26;
            MapEvent28 = FnSDRMGOVA_28;
            MapEvent29 = FnVORAENCA_29;
            MapEvent2A = FnVORAENCB_2A;
            MapEvent30 = FnVORAENCV_30;
            MapEvent31 = FnSDRVORDW_31;
            MapEvent32 = FnMOONENCA_32;
            MapEvent33 = FnMOONENCB_33;
            MapEvent34 = FnMOONENCC_34;
            MapEvent35 = FnMOONENCD_35;
            MapEvent36 = FnMOONENCE_36;
            MapEvent37 = FnMOONENCF_37;
            MapEvent38 = FnMOONENCG_38;
            MapEvent3A = FnTXTMOONB_3A;
            MapEvent3B = FnMOONENCJ_3B;
            MapEvent3C = FnMOONENCK_3C;
            MapEvent3E = FnBDRMOONB_3E;
            MapEvent3F = FnSDRMOONC_3F;
            MapEvent40 = FnSDRMOOND_40;
            MapEvent41 = FnSDRMOONE_41;
            MapEvent42 = FnMOONENCM_42;
            MapEvent43 = FnSDRMOONF_43;
            MapEvent44 = FnSDRMOONJ_44;
            MapEvent45 = FnBDRMOONK_45;
            MapEvent46 = FnSDRMOONM_46;
            MapEvent47 = FnSDRMOONN_47;
            MapEvent48 = FnMOONTRSA_48;
            MapEvent49 = FnMOONTRSB_49;
            MapEvent4A = FnMOONTRSC_4A;
            MapEvent4B = FnTORBFOUN_4B;
            MapEvent4C = FnTORBENCB_4C;
            MapEvent4D = FnTORBENCC_4D;
            MapEvent52 = FnTXTTORB_52;
            MapEvent53 = FnSDRTORBA_53;
            MapEvent54 = FnSDRTORBB_54;
            MapEvent55 = FnTORBWIND_55;
            MapEvent56 = FnMOONWIND_56;
            MapEvent57 = FnVORAWIND_57;
        }
        
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
        private void FnDROP_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String03FC); // Other pits in the Labyrinth provide access to hidden areas...
            L0010: ShowMessage(party, String043A); // This pit, however, sends you to the gates of Death.
            L001D: ax = GetMaxHits74(party);
            L0024: DamagePlayer90(party, ax);
            L002E: return; // RETURN;
        }

        private void FnXOVER_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetCurrentTile20(party);
            L000A: Compare(ax, 0x0047);
            L000D: if (JumpNotEqual) goto L0070;
            L000F: ax = GetState(party, 0x01, 0x01);
            L0020: RefreshCompareFlags(ax);
            L0022: if (JumpEqual) goto L0043;
            L0024: SetFloorObject38(party, 0x00, 0x47);
            L0034: ShowMessage(party, String046E); // A magical platform forms a bridge across the abyss.
            L0041: goto L006E;
            L0043: ShowMessage(party, String04A2); // You fall into the abyss and die.
            L0050: ShowMessage(party, String04C3); // With help, you might have been able to cross here.
            L005D: ax = GetMaxHits74(party);
            L0064: DamagePlayer90(party, ax);
            L006E: goto L00A8;
            L0070: ax = GetState(party, 0x01, 0x01);
            L0081: RefreshCompareFlags(ax);
            L0083: if (JumpEqual) goto L0097;
            L0085: SetFloorObject38(party, 0x00, 0x47);
            L0095: goto L00A8;
            L0097: SetFloorObject38(party, 0x01, 0x47);
            L00A8: return; // RETURN;
        }

        private void FnXOVERON_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetState(party, 0x01, 0x01, 0x01);
            L0018: SetFloorObject38(party, 0x00, 0x47);
            L0028: ShowMessage(party, String04F6); // Something strange happens!
            L0035: ShowMessage(party, String0511); // When you step onto the stone, a magical platform appears nearby.
            L0042: return; // RETURN;
        }

        private void FnBAZAAR_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0552); // You do not suffer the death found in other pits in the Labyrinth.  Instead you are rewarded with a trip to CASTLEGATE BAZAAR.
            L0010: TeleportPartyBC(party, 0x36, 0x01, 0x12, 0x03);
            L002B: return; // RETURN;
        }

        private void FnHEAVENS_05(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String05D0); // The Dark Dwarf Voranti tricked the Lords of Harmony many moons ago.
            L0010: ShowMessage(party, String0614); // He stole the secrets of the Winds from the Lords and has used them for his own purposes every since.
            L001D: ShowMessage(party, String0679); // The Lords' Harmonic Shrine has now become the raging passageway known as HEAVEN'S FURY.
            L002A: TeleportPartyBC(party, 0x35, 0x01, 0xA3, 0x02);
            L0045: return; // RETURN;
        }

        private void FnEXODUS_06(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String06D1); // The survivors of the cataclysm named this place EXODUS.
            L0010: ShowMessage(party, String0709); // It is here they escaped the horrors of Arnakkian's Castle and began their new subterranean life.
            L001D: TeleportPartyBC(party, 0x35, 0x01, 0x75, 0x02);
            L0038: return; // RETURN;
        }

        private void FnWINDHOLO_07(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String076A); // No adventurer dares camp in WIND HOLLOW.  At night the howling wind makes one deaf to the dangers.
            L0010: TeleportPartyBC(party, 0x35, 0x01, 0x8A, 0x03);
            L002B: return; // RETURN;
        }

        private void FnTEMPEST_08(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String07CD); // TEMPEST dares all to explore the magic rooms along her narrow corridor.
            L0010: TeleportPartyBC(party, 0x35, 0x01, 0x9B, 0x01);
            L002B: return; // RETURN;
        }

        private void FnWINDHOLO_09(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0815); // The barren rocks are swept clean by the violent winds that race through WIND HOLLOW.
            L0010: TeleportPartyBC(party, 0x35, 0x01, 0x7D, 0x00);
            L002A: return; // RETURN;
        }

        private void FnBACKALLY_0A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String086A); // 'Beware!  Those who enter the Labyrinth BACK ALLEY must guard against all!'
            L0010: TeleportPartyBC(party, 0x35, 0x01, 0x4D, 0x00);
            L002A: return; // RETURN;
        }

        private void FnHEAVENS_0B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String08B6); // Enter HEAVEN'S FURY if you must.  Here is where Voranti cursed the winds.
            L0010: TeleportPartyBC(party, 0x35, 0x01, 0xF3, 0x02);
            L002B: return; // RETURN;
        }

        private void FnLABYATIC_0C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0900); // The gates of LABYRINTH ATTIC are a welcome sight.
            L0010: TeleportPartyBC(party, 0x33, 0x01, 0xC3, 0x02);
            L002B: return; // RETURN;
        }

        private void FnWINDHOLO_0D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0932); // The door leads to WYN SANCTUARY.
            L0010: TeleportPartyBC(party, 0x33, 0x01, 0x6D, 0x00);
            L002A: return; // RETURN;
        }

        private void FnTHVTRESR_0E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0953); // The gateway opens, revealing the secret chambers of the Labyrinth Thieves.
            L0010: TeleportPartyBC(party, 0x33, 0x01, 0x6E, 0x02);
            L002B: return; // RETURN;
        }

        private void FnLAVA_0F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String099E); // You stumble into the lava pools.  You die.
            L0010: ax = GetMaxHits74(party);
            L0017: DamagePlayer90(party, ax);
            L0021: return; // RETURN;
        }

        private void FnDRTOBALY_10(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String09C9); // This door locks out all except those who have the alley key.
            L0010: ax = UsedItem54(party, 0xE0, 0xE0);
            L0023: if (JumpEqual) goto L0066;
            L0025: PushStack(party, 0x01);
            L0029: PushStack(party, 0x03);
            L002D: ax = GetCurrentTile20(party);
            L0034: PushStack(party, ax);
            L0035: SetWallPassable2C(party, PopStack(party), PopStack(party), PopStack(party));
            L003F: PushStack(party, 0x03);
            L0043: ax = GetCurrentTile20(party);
            L004A: PushStack(party, ax);
            L004B: PushStack(party, 0x01);
            L004F: SetWallObject30(party, PopStack(party), PopStack(party), PopStack(party));
            L0059: ShowMessage(party, String0A06); // Your key unlocks the door.
            L0066: return; // RETURN;
        }

        private void FnLABYATIC_14(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0A21); // You return to LABYRINTH ATTIC through a one-way tunnel.
            L0010: TeleportPartyBC(party, 0x33, 0x01, 0x59, 0x02);
            L002B: return; // RETURN;
        }

        private void FnWINDHOLO_15(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0A59); // The door to WIND HOLLOW bursts open with terrible force, throwing all adventurers against the rocks...
            L0010: ShowMessage(party, String0AC0); // ...and inflicting heavy damage.
            L001D: DamagePlayer90(party, 0x00C8);
            L002A: ax = GetCurrentHits70(party);
            L0031: RefreshCompareFlags(ax);
            L0033: if (JumpAbove) goto L0042;
            L0035: ShowMessage(party, String0AE0); // You have died.
            L0042: TeleportPartyBC(party, 0x35, 0x01, 0xBC, 0x03);
            L005D: return; // RETURN;
        }

        private void FnMAGICRMS_16(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0AEF); // Runes can be the most powerful of weapons in the hands of an adept Wizard.
            L0010: ShowMessage(party, String0B3A); // Here, the runes also protect the great mage's magical possessions against the unwanted.
            L001D: TeleportPartyBC(party, 0x34, 0x02, 0x30, 0x02);
            L0038: return; // RETURN;
        }

        private void FnZEPHENCA_18(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x16);
            L0015: AddEncounter(party, 0x02, 0x16);
            L0027: AddEncounter(party, 0x05, 0x19);
            L0039: AddEncounter(party, 0x06, 0x19);
            L004B: ax = HasItem50(party, 0xB4);
            L0059: if (JumpEqual) goto L007C;
            L005B: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0xD1);
            L007A: goto L009D;
            L007C: AddTreasure(party, 0x07D0, 0x00, 0x00, 0xC8, 0xB4, 0xD0);
            L009D: return; // RETURN;
        }

        private void FnZEPHENCB_19(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsStateSet(party, 0x02, 0x79);
            L0016: if (JumpEqual) goto L007B;
            L0018: ax = HasItem50(party, 0x09);
            L0026: if (JumpNotEqual) goto L0038;
            L0028: ax = HasItem50(party, 0xF0);
            L0036: if (JumpEqual) goto L005A;
            L0038: AddTreasure(party, 0x1388, 0x00, 0x00, 0x00, 0xB3, 0xD0);
            L0058: goto L0079;
            L005A: AddTreasure(party, 0x2710, 0x00, 0x00, 0x00, 0x00, 0xF0);
            L0079: goto L00EA;
            L007B: ax = HasItem50(party, 0xE6);
            L0089: if (JumpEqual) goto L00EA;
            L008B: RemoveItem4C(party, 0xE6);
            L0097: SetState(party, 0x02, 0x79, 0x01);
            L00AC: AddTreasure(party, 0x2710, 0x00, 0x00, 0x00, 0x00, 0xF0);
            L00CB: AddExperience98(party, 0x0003D090);
            L00DD: ShowMessage(party, String0B92); // The Zephyr Wind whispers, 'I have taken the Harvest Horn, and I give you something to help defeat the Wind Elemental'.
            L00EA: AddEncounter(party, 0x01, 0x10);
            L00FC: AddEncounter(party, 0x02, 0x10);
            L010E: AddEncounter(party, 0x05, 0x0F);
            L0120: AddEncounter(party, 0x06, 0x0F);
            L0132: return; // RETURN;
        }

        private void FnTXTZEPHR_1B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0C09); // The Zephyr Wind whistles 'No harm was intended, but I am sworn to serve the Wind Elemental.  Return the Harvest Horn to my Wyverns to release my bonds.'
            L0010: return; // RETURN;
        }

        private void FnXOVEROFF_1C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetState(party, 0x01, 0x01, 0x00);
            L0017: SetFloorObject38(party, 0x01, 0x47);
            L0028: ShowMessage(party, String0CA2); // A magical platform nearby seems to disappear.
            L0035: return; // RETURN;
        }

        private void FnZEPHBLOW_1D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0CD0); // The Zephyr Wind gusts in fury, causing damage!
            L0010: ax = GetMaxHits74(party);
            L0017: bx = 0x0003;
            L001A: dx = ax % bx; ax = ax / bx; // (signed, dx = quotient)
            L001D: DamagePlayer90(party, ax);
            L0027: ax = GetCurrentHits70(party);
            L002E: RefreshCompareFlags(ax);
            L0030: if (JumpAbove) goto L003F;
            L0032: ShowMessage(party, String0CFF); // You have died.
            L003F: return; // RETURN;
        }

        private void FnDRLPENCA_1E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0D0E); // Wafts of reddish smoke eminate from the rooms ahead.
            L0010: AddEncounter(party, 0x01, 0x19);
            L0022: AddEncounter(party, 0x02, 0x19);
            L0034: AddEncounter(party, 0x05, 0x0F);
            L0046: AddEncounter(party, 0x06, 0x0F);
            L0058: return; // RETURN;
        }

        private void FnDRLPENCB_1F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0D43); // An acrid odor fills these chambers.
            L0010: AddEncounter(party, 0x01, 0x0F);
            L0022: AddEncounter(party, 0x02, 0x0F);
            L0034: AddEncounter(party, 0x05, 0x1B);
            L0046: AddEncounter(party, 0x06, 0x1B);
            L0058: return; // RETURN;
        }

        private void FnDRLPENCC_20(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0D67); // The fiery eyes of Ancient Dragons blaze through the thick clouds that fill the chamber.
            L0010: AddEncounter(party, 0x01, 0x1C);
            L0022: AddEncounter(party, 0x02, 0x1C);
            L0034: AddEncounter(party, 0x03, 0x1C);
            L0046: AddEncounter(party, 0x04, 0x1C);
            L0058: AddEncounter(party, 0x05, 0x1A);
            L006A: AddEncounter(party, 0x06, 0x1A);
            L007C: ax = HasItem50(party, 0xDF);
            L008A: if (JumpEqual) goto L00AD;
            L008C: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0xD1);
            L00AB: goto L00CE;
            L00AD: AddTreasure(party, 0x4E20, 0x00, 0x00, 0xDF, 0x46, 0x6E);
            L00CE: return; // RETURN;
        }

        private void FnZZYZENCA_21(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x1E);
            L0015: AddEncounter(party, 0x02, 0x1E);
            L0027: AddEncounter(party, 0x03, 0x1E);
            L0039: AddEncounter(party, 0x04, 0x1E);
            L004B: AddEncounter(party, 0x05, 0x1D);
            L005D: AddEncounter(party, 0x06, 0x1D);
            L006F: AddTreasure(party, 0x1388, 0x00, 0x00, 0x17, 0x08, 0x6C);
            L0090: return; // RETURN;
        }

        private void FnSDRZZYZA_23(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L000F: Compare(ax, 0x000B);
            L0012: if (JumpNotBelow) goto L0039;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (JumpNotEqual) goto L0039;
            L0024: ax = UsedItem54(party, 0xBE, 0xBE);
            L0037: if (JumpEqual) goto L0082;
            L0039: ShowMessage(party, String0DBF); // You detect a secret door in the wall.
            L0046: PushStack(party, 0x01);
            L004A: ax = GetFacing24(party);
            L0051: PushStack(party, ax);
            L0052: ax = GetCurrentTile20(party);
            L0059: PushStack(party, ax);
            L005A: SetWallPassable2C(party, PopStack(party), PopStack(party), PopStack(party));
            L0064: ax = GetFacing24(party);
            L006B: PushStack(party, ax);
            L006C: ax = GetCurrentTile20(party);
            L0073: PushStack(party, ax);
            L0074: PushStack(party, 0x01);
            L0078: SetWallObject30(party, PopStack(party), PopStack(party), PopStack(party));
            L0082: return; // RETURN;
        }

        private void FnZZYZENCC_24(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x10);
            L0015: AddEncounter(party, 0x02, 0x10);
            L0027: AddEncounter(party, 0x03, 0x1D);
            L0039: AddEncounter(party, 0x04, 0x1D);
            L004B: return; // RETURN;
        }

        private void FnMGOVENCA_25(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0DE5); // A stash of wizard items is being raided.
            L0010: AddEncounter(party, 0x01, 0x1F);
            L0022: AddEncounter(party, 0x02, 0x1F);
            L0034: AddEncounter(party, 0x03, 0x20);
            L0046: AddEncounter(party, 0x04, 0x20);
            L0058: AddTreasure(party, 0x03E8, 0x00, 0x00, 0xCA, 0xB2, 0xB1);
            L0079: return; // RETURN;
        }

        private void FnMGOVENCB_26(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x1F);
            L0015: AddEncounter(party, 0x02, 0x1F);
            L0027: AddEncounter(party, 0x03, 0x1F);
            L0039: AddEncounter(party, 0x04, 0x19);
            L004B: AddEncounter(party, 0x05, 0x05);
            L005D: return; // RETURN;
        }

        private void FnSDRMGOVA_28(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetGuild7C(party);
            L000A: Compare(ax, 0x0005);
            L000D: if (JumpEqual) goto L0012;
            L000F: goto L0091;
            L0012: ax = UsedSkill58(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L001E: Compare(ax, 0x000C);
            L0021: if (JumpNotBelow) goto L0048;
            L0023: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L002F: RefreshCompareFlags(ax);
            L0031: if (JumpNotEqual) goto L0048;
            L0033: ax = UsedItem54(party, 0xBE, 0xBE);
            L0046: if (JumpEqual) goto L0091;
            L0048: ShowMessage(party, String0E0E); // You locate a hidden door in the wall.
            L0055: PushStack(party, 0x01);
            L0059: ax = GetFacing24(party);
            L0060: PushStack(party, ax);
            L0061: ax = GetCurrentTile20(party);
            L0068: PushStack(party, ax);
            L0069: SetWallPassable2C(party, PopStack(party), PopStack(party), PopStack(party));
            L0073: ax = GetFacing24(party);
            L007A: PushStack(party, ax);
            L007B: ax = GetCurrentTile20(party);
            L0082: PushStack(party, ax);
            L0083: PushStack(party, 0x01);
            L0087: SetWallObject30(party, PopStack(party), PopStack(party), PopStack(party));
            L0091: return; // RETURN;
        }

        private void FnVORAENCA_29(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x22);
            L0015: AddEncounter(party, 0x02, 0x22);
            L0027: AddEncounter(party, 0x03, 0x10);
            L0039: AddEncounter(party, 0x04, 0x10);
            L004B: return; // RETURN;
        }

        private void FnVORAENCB_2A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x22);
            L0015: AddEncounter(party, 0x02, 0x22);
            L0027: AddEncounter(party, 0x03, 0x15);
            L0039: AddEncounter(party, 0x04, 0x12);
            L004B: return; // RETURN;
        }

        private void FnVORAENCV_30(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0E34); // A powerful Dwarf Thief stands before you. 'I am Voranti, Lord of Dwarf Thieves!  Fight me if you must, but you shall not find my secret treasure!  Do not fear, for I will provide decent burial when I am finished.'
            L0010: ax = GetRace78(party);
            L0017: Compare(ax, 0x0002);
            L001A: if (JumpNotEqual) goto L0029;
            L001C: ShowMessage(party, String0F0A); // Voranti's dark eyes glow bright with hatred. 'As for you, miserable Elf, my pet gargoyles will pick your bones clean.'
            L0029: ax = GetRace78(party);
            L0030: Compare(ax, 0x0004);
            L0033: if (JumpNotEqual) goto L0042;
            L0035: ShowMessage(party, String0F81); // Voranti smiles sadly. 'It saddens me that I must kill a fellow dwarf, but you have brought death upon yourself.'
            L0042: AddEncounter(party, 0x01, 0x1C);
            L0054: AddEncounter(party, 0x05, 0x21);
            L0066: ax = HasItem50(party, 0xED);
            L0074: if (JumpEqual) goto L0097;
            L0076: AddTreasure(party, 0x1388, 0x00, 0x00, 0x00, 0x00, 0xCC);
            L0095: goto L00B6;
            L0097: AddTreasure(party, 0x2710, 0x00, 0x00, 0x00, 0x00, 0xED);
            L00B6: return; // RETURN;
        }

        private void FnSDRVORDW_31(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L000F: Compare(ax, 0x000B);
            L0012: if (JumpNotBelow) goto L0039;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (JumpNotEqual) goto L0039;
            L0024: ax = UsedItem54(party, 0xBE, 0xBE);
            L0037: if (JumpEqual) goto L0082;
            L0039: ShowMessage(party, String0FF2); // You find a secret door in the wall.
            L0046: ax = GetFacing24(party);
            L004D: PushStack(party, ax);
            L004E: ax = GetCurrentTile20(party);
            L0055: PushStack(party, ax);
            L0056: PushStack(party, 0x01);
            L005A: SetWallObject30(party, PopStack(party), PopStack(party), PopStack(party));
            L0064: PushStack(party, 0x01);
            L0068: ax = GetFacing24(party);
            L006F: PushStack(party, ax);
            L0070: ax = GetCurrentTile20(party);
            L0077: PushStack(party, ax);
            L0078: SetWallPassable2C(party, PopStack(party), PopStack(party), PopStack(party));
            L0082: return; // RETURN;
        }

        private void FnMOONENCA_32(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x0A);
            L0015: AddEncounter(party, 0x02, 0x0A);
            L0027: AddEncounter(party, 0x03, 0x24);
            L0039: AddEncounter(party, 0x04, 0x24);
            L004B: ax = HasItem50(party, 0xBE);
            L0059: if (JumpEqual) goto L007D;
            L005B: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0xD0, 0xB7);
            L007B: goto L009E;
            L007D: AddTreasure(party, 0x1388, 0x00, 0x00, 0xC6, 0xD1, 0xBE);
            L009E: return; // RETURN;
        }

        private void FnMOONENCB_33(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x26);
            L0015: AddEncounter(party, 0x02, 0x26);
            L0027: AddEncounter(party, 0x03, 0x25);
            L0039: AddEncounter(party, 0x05, 0x26);
            L004B: AddEncounter(party, 0x06, 0x26);
            L005D: AddTreasure(party, 0x1B58, 0x00, 0x00, 0x00, 0x59, 0x13);
            L007D: return; // RETURN;
        }

        private void FnMOONENCC_34(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x0E);
            L0015: AddEncounter(party, 0x02, 0x0E);
            L0027: AddEncounter(party, 0x03, 0x1C);
            L0039: AddEncounter(party, 0x04, 0x1C);
            L004B: AddEncounter(party, 0x05, 0x1B);
            L005D: AddEncounter(party, 0x06, 0x1B);
            L006F: AddTreasure(party, 0x2710, 0x00, 0x00, 0x00, 0x83, 0x10);
            L008F: return; // RETURN;
        }

        private void FnMOONENCD_35(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x24);
            L0015: AddEncounter(party, 0x02, 0x24);
            L0027: AddEncounter(party, 0x03, 0x24);
            L0039: AddEncounter(party, 0x04, 0x24);
            L004B: return; // RETURN;
        }

        private void FnMOONENCE_36(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1016); // A nest of young dragons!
            L0010: AddEncounter(party, 0x01, 0x0E);
            L0022: AddEncounter(party, 0x02, 0x0E);
            L0034: AddEncounter(party, 0x03, 0x0F);
            L0046: AddEncounter(party, 0x04, 0x1C);
            L0058: return; // RETURN;
        }

        private void FnMOONENCF_37(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x24);
            L0015: AddEncounter(party, 0x02, 0x24);
            L0027: AddEncounter(party, 0x05, 0x24);
            L0039: return; // RETURN;
        }

        private void FnMOONENCG_38(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String102F); // A yellowed piece of paper  --
            L0010: ShowMessage(party, String104D); // 'Help! My brother Orilon has been bitten by bears and is transformed.'  - signed Margery
            L001D: AddEncounter(party, 0x01, 0x28);
            L002F: AddEncounter(party, 0x02, 0x28);
            L0041: AddEncounter(party, 0x03, 0x28);
            L0053: AddEncounter(party, 0x05, 0x24);
            L0065: AddEncounter(party, 0x06, 0x24);
            L0077: ax = HasItem50(party, 0xEA);
            L0085: if (JumpEqual) goto L00A8;
            L0087: AddTreasure(party, 0x2328, 0x00, 0x00, 0x00, 0x00, 0xBB);
            L00A6: goto L00C8;
            L00A8: AddTreasure(party, 0x1388, 0x00, 0x00, 0x00, 0xEA, 0x85);
            L00C8: return; // RETURN;
        }

        private void FnTXTMOONB_3A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String10A6); // A note -- 'Only past the Darkside will you find En-Li-Kil himself.'
            L0010: return; // RETURN;
        }

        private void FnMOONENCJ_3B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x12);
            L0015: AddEncounter(party, 0x02, 0x12);
            L0027: AddEncounter(party, 0x03, 0x1E);
            L0039: AddEncounter(party, 0x04, 0x1E);
            L004B: return; // RETURN;
        }

        private void FnMOONENCK_3C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x26);
            L0015: AddEncounter(party, 0x02, 0x26);
            L0027: AddEncounter(party, 0x03, 0x26);
            L0039: AddEncounter(party, 0x05, 0x25);
            L004B: AddEncounter(party, 0x06, 0x25);
            L005D: return; // RETURN;
        }

        private void FnBDRMOONB_3E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String10EA); // This door requires immense strength to open.
            L0010: ax = CheckStrengthA4(party);
            L001C: Compare(ax, 0x0015);
            L001F: if (JumpBelow) goto L006A;
            L0021: ShowMessage(party, String1117); // You push against the door and barely manage to open it.
            L002E: ax = GetFacing24(party);
            L0035: PushStack(party, ax);
            L0036: ax = GetCurrentTile20(party);
            L003D: PushStack(party, ax);
            L003E: PushStack(party, 0x01);
            L0042: SetWallObject30(party, PopStack(party), PopStack(party), PopStack(party));
            L004C: PushStack(party, 0x01);
            L0050: ax = GetFacing24(party);
            L0057: PushStack(party, ax);
            L0058: ax = GetCurrentTile20(party);
            L005F: PushStack(party, ax);
            L0060: SetWallPassable2C(party, PopStack(party), PopStack(party), PopStack(party));
            L006A: return; // RETURN;
        }

        private void FnSDRMOONC_3F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedItem54(party, 0xF2, 0xF2);
            L0016: if (JumpEqual) goto L0061;
            L0018: ShowMessage(party, String114F); // Your Moon Prism reveals a secret door!
            L0025: ax = GetFacing24(party);
            L002C: PushStack(party, ax);
            L002D: ax = GetCurrentTile20(party);
            L0034: PushStack(party, ax);
            L0035: PushStack(party, 0x01);
            L0039: SetWallObject30(party, PopStack(party), PopStack(party), PopStack(party));
            L0043: PushStack(party, 0x01);
            L0047: ax = GetFacing24(party);
            L004E: PushStack(party, ax);
            L004F: ax = GetCurrentTile20(party);
            L0056: PushStack(party, ax);
            L0057: SetWallPassable2C(party, PopStack(party), PopStack(party), PopStack(party));
            L0061: return; // RETURN;
        }

        private void FnSDRMOOND_40(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L000F: Compare(ax, 0x000B);
            L0012: if (JumpNotBelow) goto L004E;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (JumpNotEqual) goto L004E;
            L0024: ax = UsedItem54(party, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L004E;
            L0039: ax = UsedItem54(party, 0xBE, 0xBE);
            L004C: if (JumpEqual) goto L0097;
            L004E: ShowMessage(party, String1176); // You find a door hidden in the wall.
            L005B: ax = GetFacing24(party);
            L0062: PushStack(party, ax);
            L0063: ax = GetCurrentTile20(party);
            L006A: PushStack(party, ax);
            L006B: PushStack(party, 0x01);
            L006F: SetWallObject30(party, PopStack(party), PopStack(party), PopStack(party));
            L0079: PushStack(party, 0x01);
            L007D: ax = GetFacing24(party);
            L0084: PushStack(party, ax);
            L0085: ax = GetCurrentTile20(party);
            L008C: PushStack(party, ax);
            L008D: SetWallPassable2C(party, PopStack(party), PopStack(party), PopStack(party));
            L0097: return; // RETURN;
        }

        private void FnSDRMOONE_41(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String119A); // The signature of the spectrum appears on the wall.
            L0010: ax = UsedItem54(party, 0xBD, 0xBD);
            L0023: if (JumpNotEqual) goto L003A;
            L0025: ax = UsedItem54(party, 0xBE, 0xBE);
            L0038: if (JumpEqual) goto L0083;
            L003A: ShowMessage(party, String11CD); // In the wall is a secret door.
            L0047: ax = GetFacing24(party);
            L004E: PushStack(party, ax);
            L004F: ax = GetCurrentTile20(party);
            L0056: PushStack(party, ax);
            L0057: PushStack(party, 0x01);
            L005B: SetWallObject30(party, PopStack(party), PopStack(party), PopStack(party));
            L0065: PushStack(party, 0x01);
            L0069: ax = GetFacing24(party);
            L0070: PushStack(party, ax);
            L0071: ax = GetCurrentTile20(party);
            L0078: PushStack(party, ax);
            L0079: SetWallPassable2C(party, PopStack(party), PopStack(party), PopStack(party));
            L0083: return; // RETURN;
        }

        private void FnMOONENCM_42(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x26);
            L0015: AddEncounter(party, 0x02, 0x26);
            L0027: AddEncounter(party, 0x03, 0x25);
            L0039: AddEncounter(party, 0x04, 0x25);
            L004B: return; // RETURN;
        }

        private void FnSDRMOONF_43(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetGuild7C(party);
            L000A: Compare(ax, 0x0002);
            L000D: if (JumpEqual) goto L0012;
            L000F: goto L0091;
            L0012: ax = UsedSkill58(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L001E: Compare(ax, 0x000A);
            L0021: if (JumpNotBelow) goto L0048;
            L0023: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L002F: RefreshCompareFlags(ax);
            L0031: if (JumpNotEqual) goto L0048;
            L0033: ax = UsedItem54(party, 0xBE, 0xBE);
            L0046: if (JumpEqual) goto L0091;
            L0048: ShowMessage(party, String11EB); // Your Ranger skills help you locate a door hidden in the wall.
            L0055: ax = GetFacing24(party);
            L005C: PushStack(party, ax);
            L005D: ax = GetCurrentTile20(party);
            L0064: PushStack(party, ax);
            L0065: PushStack(party, 0x01);
            L0069: SetWallObject30(party, PopStack(party), PopStack(party), PopStack(party));
            L0073: PushStack(party, 0x01);
            L0077: ax = GetFacing24(party);
            L007E: PushStack(party, ax);
            L007F: ax = GetCurrentTile20(party);
            L0086: PushStack(party, ax);
            L0087: SetWallPassable2C(party, PopStack(party), PopStack(party), PopStack(party));
            L0091: return; // RETURN;
        }

        private void FnSDRMOONJ_44(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetGuild7C(party);
            L000A: Compare(ax, 0x0004);
            L000D: if (JumpEqual) goto L0012;
            L000F: goto L0091;
            L0012: ax = UsedSkill58(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L001E: Compare(ax, 0x000A);
            L0021: if (JumpNotBelow) goto L0048;
            L0023: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L002F: RefreshCompareFlags(ax);
            L0031: if (JumpNotEqual) goto L0048;
            L0033: ax = UsedItem54(party, 0xBE, 0xBE);
            L0046: if (JumpEqual) goto L0091;
            L0048: ShowMessage(party, String1229); // Your holy calling allows you find a door hidden in the wall.
            L0055: ax = GetFacing24(party);
            L005C: PushStack(party, ax);
            L005D: ax = GetCurrentTile20(party);
            L0064: PushStack(party, ax);
            L0065: PushStack(party, 0x01);
            L0069: SetWallObject30(party, PopStack(party), PopStack(party), PopStack(party));
            L0073: PushStack(party, 0x01);
            L0077: ax = GetFacing24(party);
            L007E: PushStack(party, ax);
            L007F: ax = GetCurrentTile20(party);
            L0086: PushStack(party, ax);
            L0087: SetWallPassable2C(party, PopStack(party), PopStack(party), PopStack(party));
            L0091: return; // RETURN;
        }

        private void FnBDRMOONK_45(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckStrengthA4(party);
            L000F: Compare(ax, 0x0014);
            L0012: if (JumpBelow) goto L005F;
            L0014: ShowMessage(party, String1266); // You barely manage to force open the door.
            L0021: ax = GetFacing24(party);
            L0028: PushStack(party, ax);
            L0029: ax = GetCurrentTile20(party);
            L0030: PushStack(party, ax);
            L0031: PushStack(party, 0x01);
            L0035: SetWallObject30(party, PopStack(party), PopStack(party), PopStack(party));
            L003F: PushStack(party, 0x01);
            L0043: ax = GetFacing24(party);
            L004A: PushStack(party, ax);
            L004B: ax = GetCurrentTile20(party);
            L0052: PushStack(party, ax);
            L0053: SetWallPassable2C(party, PopStack(party), PopStack(party), PopStack(party));
            L005D: goto L00A7;
            L005F: ShowMessage(party, String1290); // The door is stuck shut.
            L006C: ax = GetFacing24(party);
            L0073: PushStack(party, ax);
            L0074: ax = GetCurrentTile20(party);
            L007B: PushStack(party, ax);
            L007C: PushStack(party, 0x01);
            L0080: SetWallObject30(party, PopStack(party), PopStack(party), PopStack(party));
            L008A: PushStack(party, 0x00);
            L008D: ax = GetFacing24(party);
            L0094: PushStack(party, ax);
            L0095: ax = GetCurrentTile20(party);
            L009C: PushStack(party, ax);
            L009D: SetWallPassable2C(party, PopStack(party), PopStack(party), PopStack(party));
            L00A7: return; // RETURN;
        }

        private void FnSDRMOONM_46(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L000F: Compare(ax, 0x0008);
            L0012: if (JumpNotBelow) goto L0039;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (JumpNotEqual) goto L0039;
            L0024: ax = UsedItem54(party, 0xBE, 0xBE);
            L0037: if (JumpEqual) goto L0082;
            L0039: ShowMessage(party, String12A8); // Your training helps you find a secret door in the wall.
            L0046: PushStack(party, 0x01);
            L004A: ax = GetFacing24(party);
            L0051: PushStack(party, ax);
            L0052: ax = GetCurrentTile20(party);
            L0059: PushStack(party, ax);
            L005A: SetWallPassable2C(party, PopStack(party), PopStack(party), PopStack(party));
            L0064: ax = GetFacing24(party);
            L006B: PushStack(party, ax);
            L006C: ax = GetCurrentTile20(party);
            L0073: PushStack(party, ax);
            L0074: PushStack(party, 0x01);
            L0078: SetWallObject30(party, PopStack(party), PopStack(party), PopStack(party));
            L0082: return; // RETURN;
        }

        private void FnSDRMOONN_47(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String12E0); // You detect a door cleverly hidden in the wall.
            L0010: ax = GetFacing24(party);
            L0017: PushStack(party, ax);
            L0018: ax = GetCurrentTile20(party);
            L001F: PushStack(party, ax);
            L0020: PushStack(party, 0x01);
            L0024: SetWallObject30(party, PopStack(party), PopStack(party), PopStack(party));
            L002E: PushStack(party, 0x01);
            L0032: ax = GetFacing24(party);
            L0039: PushStack(party, ax);
            L003A: ax = GetCurrentTile20(party);
            L0041: PushStack(party, ax);
            L0042: SetWallPassable2C(party, PopStack(party), PopStack(party), PopStack(party));
            L004C: return; // RETURN;
        }

        private void FnMOONTRSA_48(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xF2);
            L0011: if (JumpEqual) goto L0022;
            L0013: ShowMessage(party, String130F); // Piles of dirt cover the floor.
            L0020: goto L0050;
            L0022: GiveItem48(party, 0xF2);
            L002E: SetState(party, 0x02, 0x46, 0x01);
            L0043: ShowMessage(party, String132E); // You find a Moon Prism on the floor.
            L0050: return; // RETURN;
        }

        private void FnMOONTRSB_49(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetState(party, 0x02, 0x47);
            L0014: Compare(ax, 0x0001);
            L0017: if (JumpNotEqual) goto L0028;
            L0019: ShowMessage(party, String1352); // The floor is bare.
            L0026: goto L0056;
            L0028: GiveItem48(party, 0x37);
            L0034: SetState(party, 0x02, 0x47, 0x01);
            L0049: ShowMessage(party, String1365); // You find the Ranger Spear on the floor.
            L0056: return; // RETURN;
        }

        private void FnMOONTRSC_4A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetState(party, 0x02, 0x48);
            L0014: Compare(ax, 0x0001);
            L0017: if (JumpNotEqual) goto L0028;
            L0019: ShowMessage(party, String138D); // There is nothing of interest in this area.
            L0026: goto L0056;
            L0028: GiveItem48(party, 0x3D);
            L0034: SetState(party, 0x02, 0x48, 0x01);
            L0049: ShowMessage(party, String13B8); // You find a Holy Halberd lying on the floor.
            L0056: return; // RETURN;
        }

        private void FnTORBFOUN_4B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0042);
            L0010: ShowMessage(party, String13E4); // Pictorials of War are painted on the walls surrounding Torbriar's Fountain.
            L001D: ax = GetState(party, 0x02, 0x63);
            L002E: RefreshCompareFlags(ax);
            L0030: if (JumpEqual) goto L0035;
            L0032: goto L017C;
            L0035: SetState(party, 0x02, 0x63, 0x01);
            L004A: ax = GetSkillLevel5C(party, 0x08);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L007B;
            L005A: SetSkillLevel60(party, 0x08, 0x02);
            L006B: ShowMessage(party, String1430); // You gain the skill of Archery!
            L0078: goto L017A;
            L007B: ax = GetSkillLevel5C(party, 0x01);
            L0087: RefreshCompareFlags(ax);
            L0089: if (JumpNotEqual) goto L00AC;
            L008B: SetSkillLevel60(party, 0x01, 0x02);
            L009C: ShowMessage(party, String144F); // You gain the skill of Clubs and Axes!
            L00A9: goto L017A;
            L00AC: ax = GetSkillLevel5C(party, 0x05);
            L00B8: RefreshCompareFlags(ax);
            L00BA: if (JumpNotEqual) goto L00DD;
            L00BC: SetSkillLevel60(party, 0x05, 0x02);
            L00CD: ShowMessage(party, String1475); // You gain the skill of Swordsmanship!
            L00DA: goto L017A;
            L00DD: ax = GetSkillLevel5C(party, 0x0C);
            L00E9: RefreshCompareFlags(ax);
            L00EB: if (JumpNotEqual) goto L010D;
            L00ED: SetSkillLevel60(party, 0x0C, 0x02);
            L00FE: ShowMessage(party, String149A); // You gain the Bard skill!
            L010B: goto L017A;
            L010D: ax = GetSkillLevel5C(party, 0x10);
            L0119: RefreshCompareFlags(ax);
            L011B: if (JumpNotEqual) goto L013D;
            L011D: SetSkillLevel60(party, 0x10, 0x02);
            L012E: ShowMessage(party, String14B3); // You gain the skill of Martial Arts!
            L013B: goto L017A;
            L013D: ax = GetSkillLevel5C(party, 0x16);
            L0149: RefreshCompareFlags(ax);
            L014B: if (JumpNotEqual) goto L016D;
            L014D: SetSkillLevel60(party, 0x16, 0x02);
            L015E: ShowMessage(party, String14D7); // You gain the Channel skill!
            L016B: goto L017A;
            L016D: ShowMessage(party, String14F3); // The waters have no effect.
            L017A: goto L0189;
            L017C: ShowMessage(party, String150E); // Dust fills the fountain basin.
            L0189: return; // RETURN;
        }

        private void FnTORBENCB_4C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x28);
            L0015: AddEncounter(party, 0x02, 0x28);
            L0027: AddEncounter(party, 0x04, 0x27);
            L0039: AddEncounter(party, 0x05, 0x15);
            L004B: AddEncounter(party, 0x06, 0x15);
            L005D: ax = GetGuild7C(party);
            L0064: RefreshCompareFlags(ax);
            L0066: if (JumpNotEqual) goto L0087;
            L0068: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x18);
            L0087: ax = GetGuild7C(party);
            L008E: Compare(ax, 0x0001);
            L0091: if (JumpNotEqual) goto L00B2;
            L0093: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x00, 0x11);
            L00B2: return; // RETURN;
        }

        private void FnTORBENCC_4D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x28);
            L0015: AddEncounter(party, 0x02, 0x28);
            L0027: AddEncounter(party, 0x03, 0x15);
            L0039: AddEncounter(party, 0x04, 0x15);
            L004B: return; // RETURN;
        }

        private void FnTXTTORB_52(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String152D); // A bard's scroll sings a simple song of how someday bands of adventurers will form an invisible bridge across a deadly chasm.
            L0010: return; // RETURN;
        }

        private void FnSDRTORBA_53(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetGuild7C(party);
            L000A: Compare(ax, 0x0001);
            L000D: if (JumpEqual) goto L0012;
            L000F: goto L0091;
            L0012: ax = UsedSkill58(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L001E: Compare(ax, 0x0008);
            L0021: if (JumpNotBelow) goto L0048;
            L0023: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L002F: RefreshCompareFlags(ax);
            L0031: if (JumpNotEqual) goto L0048;
            L0033: ax = UsedItem54(party, 0xBE, 0xBE);
            L0046: if (JumpEqual) goto L0091;
            L0048: ShowMessage(party, String15AA); // A secret door visible only to knights appears in the wall .
            L0055: PushStack(party, 0x01);
            L0059: ax = GetFacing24(party);
            L0060: PushStack(party, ax);
            L0061: ax = GetCurrentTile20(party);
            L0068: PushStack(party, ax);
            L0069: SetWallPassable2C(party, PopStack(party), PopStack(party), PopStack(party));
            L0073: ax = GetFacing24(party);
            L007A: PushStack(party, ax);
            L007B: ax = GetCurrentTile20(party);
            L0082: PushStack(party, ax);
            L0083: PushStack(party, 0x01);
            L0087: SetWallObject30(party, PopStack(party), PopStack(party), PopStack(party));
            L0091: return; // RETURN;
        }

        private void FnSDRTORBB_54(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetGuild7C(party);
            L000A: RefreshCompareFlags(ax);
            L000C: if (JumpEqual) goto L0011;
            L000E: goto L0090;
            L0011: ax = UsedSkill58(party, 0x0D); // returns 0 if did not use, compares to 2nd op if did use;
            L001D: Compare(ax, 0x0008);
            L0020: if (JumpNotBelow) goto L0047;
            L0022: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L002E: RefreshCompareFlags(ax);
            L0030: if (JumpNotEqual) goto L0047;
            L0032: ax = UsedItem54(party, 0xBE, 0xBE);
            L0045: if (JumpEqual) goto L0090;
            L0047: ShowMessage(party, String15E6); // In the wall you find a hidden door.
            L0054: PushStack(party, 0x01);
            L0058: ax = GetFacing24(party);
            L005F: PushStack(party, ax);
            L0060: ax = GetCurrentTile20(party);
            L0067: PushStack(party, ax);
            L0068: SetWallPassable2C(party, PopStack(party), PopStack(party), PopStack(party));
            L0072: ax = GetFacing24(party);
            L0079: PushStack(party, ax);
            L007A: ax = GetCurrentTile20(party);
            L0081: PushStack(party, ax);
            L0082: PushStack(party, 0x01);
            L0086: SetWallObject30(party, PopStack(party), PopStack(party), PopStack(party));
            L0090: return; // RETURN;
        }

        private void FnTORBWIND_55(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String160A); // The wind is nasty here!  You take 100 damage.
            L0010: DamagePlayer90(party, 0x0064);
            L001D: ax = GetCurrentHits70(party);
            L0024: RefreshCompareFlags(ax);
            L0026: if (JumpAbove) goto L0035;
            L0028: ShowMessage(party, String1638); // You have died.
            L0035: return; // RETURN;
        }

        private void FnMOONWIND_56(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1647); // The Moon Hollow winds steals 300 Mana!
            L0010: AddMana(party, 0xFED4);
            L001D: return; // RETURN;
        }

        private void FnVORAWIND_57(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String166E); // A violent whirlwind pounds you, taking half your health!
            L0010: ax = GetCurrentHits70(party);
            L0017: bx = 0x0002;
            L001A: dx = ax % bx; ax = ax / bx; // (signed, dx = quotient)
            L001D: DamagePlayer90(party, ax);
            L0027: ax = GetCurrentHits70(party);
            L002E: RefreshCompareFlags(ax);
            L0030: if (JumpAbove) goto L003F;
            L0032: ShowMessage(party, String16A7); // You have died.
            L003F: return; // RETURN;
        }

    }
}
