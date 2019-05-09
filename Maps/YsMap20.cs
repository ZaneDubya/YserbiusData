#pragma warning disable
using System.Collections.Generic;
using XPT.Legacy;
using XPT.Legacy.Entities;

namespace XPT.Legacy.Maps {
    class YserMap20 : AMapScripted {
        protected override int MapIndex => 20;
        protected override int RandomEncounterChance => 12;
        protected override int RandomEncounterExtraCount => 2;

        public YserMap20() {
            MapEvent01 = FnVOID_01;
            MapEvent02 = FnMOONHOLO_02;
            MapEvent03 = FnZEPHYR_03;
            MapEvent04 = FnZZYZX_04;
            MapEvent05 = FnDRGNLEAP_05;
            MapEvent06 = FnTORBRIAR_06;
            MapEvent07 = FnMOONHOLO_07;
            MapEvent08 = FnMAGEOVRL_08;
            MapEvent09 = FnENCWINDN_09;
            MapEvent0A = FnENCWINDE_0A;
            MapEvent0B = FnENCWINDS_0B;
            MapEvent0C = FnENCWINDW_0C;
            MapEvent0D = FnFLGWINDN_0D;
            MapEvent0E = FnFLGWINDE_0E;
            MapEvent0F = FnFLGWINDS_0F;
            MapEvent10 = FnFLGWINDW_10;
            MapEvent11 = FnEXPRESS_11;
            MapEvent12 = FnTXTLABY_12;
            MapEvent13 = FnWSTRES_13;
            MapEvent14 = FnMOUNTAIN_14;
            MapEvent15 = FnTXTMNTN_15;
            MapEvent16 = FnTHIEVMAZ_16;
            MapEvent17 = FnLAVA_17;
            MapEvent18 = FnZEPHYRB_18;
            MapEvent19 = FnSDOORWKT_19;
            MapEvent1A = FnTXTCAMP_1A;
            MapEvent1B = FnKEYDOORW_1B;
            MapEvent1C = FnTXTWYNS_1C;
            MapEvent1D = FnPITINFO_1D;
            MapEvent1E = FnWKTENCA_1E;
            MapEvent1F = FnWKTTEXT_1F;
            MapEvent20 = FnWKTENCC_20;
            MapEvent21 = FnWKTENCD_21;
            MapEvent22 = FnWKTENCE_22;
            MapEvent23 = FnWKTENCF_23;
            MapEvent24 = FnWKTENCG_24;
            MapEvent25 = FnWKTENCH_25;
            MapEvent26 = FnWKTENCI_26;
            MapEvent27 = FnSIRFLAG_27;
            MapEvent28 = FnSIRDOOR_28;
            MapEvent29 = FnSIROCCO_29;
            MapEvent2A = FnWSBIGDR_2A;
            MapEvent2B = FnWSENCA_2B;
            MapEvent2C = FnWSENCB_2C;
            MapEvent2D = FnWSENCC_2D;
            MapEvent30 = FnWSENCF_30;
            MapEvent31 = FnWSENCG_31;
            MapEvent32 = FnWSNOTE_32;
            MapEvent33 = FnWSENCI_33;
            MapEvent34 = FnSDOORWS_34;
            MapEvent35 = FnARKARCH_35;
            MapEvent36 = FnLAENCA_36;
            MapEvent37 = FnFNTNHEAL_37;
            MapEvent38 = FnFNTNMANA_38;
            MapEvent39 = FnLAENCB_39;
            MapEvent3A = FnSDOORLTA_3A;
            MapEvent3B = FnSDOORLTB_3B;
            MapEvent3C = FnSDOORLTC_3C;
            MapEvent3D = FnBDOORLTD_3D;
            MapEvent3E = FnLTENCA_3E;
            MapEvent3F = FnLTENCB_3F;
            MapEvent40 = FnLTENCC_40;
            MapEvent41 = FnLTENCD_41;
            MapEvent42 = FnLTENCE_42;
            MapEvent44 = FnLTENCG_44;
            MapEvent45 = FnLTSKILL_45;
            MapEvent46 = FnLTENCI_46;
            MapEvent47 = FnLTENCJ_47;
            MapEvent48 = FnLTENCK_48;
            MapEvent49 = FnTXTAWIND_49;
        }
        
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

        // === The Winds / Green Gem Quest ===================================
        // The player must defeat the four winds in the correct order to open the Wind Knight tomb.
        // The "winds" are encounter events 09, 0A, 0B, and 0C.
        // After defeating a wind, the player must turn to face the door to exit the room.
        // These doors are events 0D, 0E, 0F, and 10, which set MapFlags indicating defeat of a wind.
        // The values of the flags will be the order in which the winds were defeated.
        // The MapFlags are 01 (North wind), 02 (East wind), 03 (South wind), and 04 (West wind).
        // Defeating the winds in any order will open the Wind Knight's Tomb.
        // The winds must be defeated in a specific order to unlock the Green Gem:
        //      03==1 (South at F2), 01==2 (North at B2), 02==3 (East at H2) and 04==4 (West at D2).
        // The wind knight's tomb is filled with little one tile rooms. Most have encounter 1E.
        // But it also has treasure encounters at 20, 21, 22, and 23. If the winds have been unlocked
        // in the correct order, these treasure encounters will have treasure and the green gem.
        // Otherwise they will have alternate treasure. So you have to do this multiple times to see everything.

        private bool AreFourWindsDefeated(ServerPlayer player) {
            if (GetFlag(player, FlagTypeMap, 0x01) != 0 &&
                GetFlag(player, FlagTypeMap, 0x02) != 0 &&
                GetFlag(player, FlagTypeMap, 0x03) != 0 &&
                GetFlag(player, FlagTypeMap, 0x04) != 0) {
                return true;
            }
            return false;
        }

        private bool AreFourWindsDefeatedInCorrectOrder(ServerPlayer player) {
            if (GetFlag(player, FlagTypeMap, 0x01) == 2 &&
                GetFlag(player, FlagTypeMap, 0x02) == 3 &&
                GetFlag(player, FlagTypeMap, 0x03) == 1 &&
                GetFlag(player, FlagTypeMap, 0x04) == 4) {
                return true;
            }
            return false;
        }

        // === Functions ================================================
        private void FnVOID_01(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String03FC); // You step into nothingness...
            ShowMessage(player, isForwardMove, String0419); //                                          ...and die!
            DamagePlayer(player, GetMaxHits(player));
        }

        private void FnMOONHOLO_02(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String044E); // Cast in shadowy blue light, the tunnels of MOON HOLLOW are a nexus to more dangerous locations.
            TeleportParty(player, 0x34, 0x01, 0x03, 0x01, isForwardMove);
        }

        private void FnZEPHYR_03(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String04AE); // Well worn trails greet those who dare travel the corridors of the ZEPHYR.
            TeleportParty(player, 0x34, 0x01, 0xC3, 0x03, isForwardMove);
        }

        private void FnZZYZX_04(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String04F8); // Dry desert winds parch your throat as you peer down the winding passages leading to ZZYZX.
            TeleportParty(player, 0x34, 0x01, 0x6D, 0x00, isForwardMove);
        }

        private void FnDRGNLEAP_05(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String0553); // A brave step..
            ShowMessage(player, isForwardMove, String0562); // Death does not greet you now, but it will perhaps when you meet the DRAGONS OF THE LEAP.
            TeleportParty(player, 0x34, 0x01, 0xCB, 0x01, isForwardMove);
        }

        private void FnTORBRIAR_06(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String05BB); // You drop into TORBRIAR'S TREASURE.
            ShowMessage(player, isForwardMove, String05DE); // An inscription on the wall reads...
            ShowMessage(player, isForwardMove, String0602); // 'We, the Knights of Torbriar, build this shrine to celebrate WarMaster Torbriar's stunning victory over the armies of Ogres and Trolls.'
            TeleportParty(player, 0x34, 0x01, 0x35, 0x02, isForwardMove);
        }

        private void FnMOONHOLO_07(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String068B); // You land squarely in the center of MOON HOLLOW!
            ShowMessage(player, isForwardMove, String06BB); // The howling of winds screams harsh against the blue light of a fool moon.
            TeleportParty(player, 0x34, 0x01, 0x73, 0x02, isForwardMove);
        }

        private void FnMAGEOVRL_08(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String0705); // You drop into MAGES OVERLOOK.
            ShowMessage(player, isForwardMove, String0723); // Mages found this plateau useful for looking out over the labyrinth denizens following the great cataclysm.
            TeleportParty(player, 0x34, 0x01, 0x7A, 0x03, isForwardMove);
        }

        private void FnENCWINDN_09(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String078E); // The North Wind blows a wintry chill.
            AddEncounter(player, 0x01, 0x1B);
            AddEncounter(player, 0x02, 0x1B);
            AddEncounter(player, 0x03, 0x1B);
            AddEncounter(player, 0x05, 0x19);
            AddEncounter(player, 0x06, 0x1A);
        }

        private void FnENCWINDE_0A(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String07B3); // Warriors of the East Wind challenge you.
            AddEncounter(player, 0x01, 0x11);
            AddEncounter(player, 0x02, 0x11);
            AddEncounter(player, 0x04, 0x11);
            AddEncounter(player, 0x05, 0x19);
            AddEncounter(player, 0x06, 0x1A);
        }

        private void FnENCWINDS_0B(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String07DC); // Monsters materialize from the South Wind.
            AddEncounter(player, 0x01, 0x1C);
            AddEncounter(player, 0x02, 0x1C);
            AddEncounter(player, 0x03, 0x1C);
            AddEncounter(player, 0x05, 0x19);
            AddEncounter(player, 0x06, 0x1A);
        }

        private void FnENCWINDW_0C(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String0806); // The fury of the West Wind is upon you.
            AddEncounter(player, 0x01, 0x1D);
            AddEncounter(player, 0x02, 0x1D);
            AddEncounter(player, 0x04, 0x1D);
            AddEncounter(player, 0x05, 0x1A);
            AddEncounter(player, 0x06, 0x19);
        }

        /// <summary>
        /// MapFlags 1-4 are the order in which the player has bested the winds.
        /// This sets those variables.
        /// </summary>
        private void DoDefeatWind(ServerPlayer player, int windIndex, string windName) {
            int countAlreadyDefeated =
                (GetFlag(player, FlagTypeMap, 0x01) == 0 ? 0 : 1) +
                (GetFlag(player, FlagTypeMap, 0x02) == 0 ? 0 : 1) +
                (GetFlag(player, FlagTypeMap, 0x03) == 0 ? 0 : 1) +
                (GetFlag(player, FlagTypeMap, 0x04) == 0 ? 0 : 1);
            if (countAlreadyDefeated == 0) {
                ShowMessage(player, false, $"The {windName} is the first to be defeated.");
            }
            else {
                ShowMessage(player, false, $"The {windName} has been quieted.");
            }
            if (GetFlag(player, FlagTypeMap, windIndex) == 0) {
                SetFlag(player, FlagTypeMap, windIndex, (byte)(countAlreadyDefeated + 1));
            }
            int countNowDefeated =
                (GetFlag(player, FlagTypeMap, 0x01) == 0 ? 0 : 1) +
                (GetFlag(player, FlagTypeMap, 0x02) == 0 ? 0 : 1) +
                (GetFlag(player, FlagTypeMap, 0x03) == 0 ? 0 : 1) +
                (GetFlag(player, FlagTypeMap, 0x04) == 0 ? 0 : 1);
            if (countNowDefeated == 4) {
                ShowMessage(player, false, "A stillness fills the labryinth.");
            }
        }

        /// <summary>
        /// North wind enconter.
        /// </summary>
        private void FnFLGWINDN_0D(ServerPlayer player, bool isForwardMove) {
            DoDefeatWind(player, 0x01, "North Wind");
        }

        /// <summary>
        /// East wind encounter.
        /// </summary>
        private void FnFLGWINDE_0E(ServerPlayer player, bool isForwardMove) {
            DoDefeatWind(player, 0x02, "East Wind");
        }

        /// <summary>
        /// South wind encounter.
        /// </summary>
        private void FnFLGWINDS_0F(ServerPlayer player, bool isForwardMove) {
            DoDefeatWind(player, 0x03, "South Wind");
        }

        /// <summary>
        /// West wind encounter.
        /// </summary>
        private void FnFLGWINDW_10(ServerPlayer player, bool isForwardMove) {
            DoDefeatWind(player, 0x04, "West Wind");
        }

        private void FnEXPRESS_11(ServerPlayer player, bool isForwardMove) {
            if (GetFlag(player, FlagTypeDungeon, FlagLabyrinthICastleGateTeleport) == 0) {
                ShowMessage(player, isForwardMove, String0986); // There is something strange about this wall.
                return;
            }
            ShowMessage(player, isForwardMove, String095D); // This wall is the teleport to CASTLEGATE.
            TeleportParty(player, 0x36, 0x01, GetCurrentTile(player), 0x03, isForwardMove);
        }

        private void FnTXTLABY_12(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String09B2); // You enter the Labyrinths of the Winds.
            ShowMessage(player, isForwardMove, String09D9); // A network of tunnels seems to wind its way past pits and lava.
        }

        private void FnWSTRES_13(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String0A18); // Wyn's Fountain is old and cracked.
            if (GetFlag(player, FlagTypeDungeon, FlagModAttr_WynFountain) == 0) {
                SetFlag(player, FlagTypeDungeon, FlagModAttr_WynFountain, 0x01);
                ShowPortrait(player, 0x0042);
                ModifyAttribute(player, 0x03, 0x0003);
                ShowMessage(player, isForwardMove, String0A3B); // A small puddle of magic water sits at the bottom.
                ShowMessage(player, isForwardMove, String0A6D); // It seems to instantly evaporate into a large steam cloud.
                ShowMessage(player, isForwardMove, String0AA7); // You feel you may be quicker in a fight.
                return;
            }
            L0082: ShowMessage(player, isForwardMove, String0ACF); // The basin is dust dry.
        }

        private void FnMOUNTAIN_14(ServerPlayer player, bool isForwardMove) {
            TeleportParty(player, 0x01, 0x01, 0x00, 0x33, isForwardMove);
        }

        private void FnTXTMNTN_15(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String0AE6); // A twisting passage to the east offers a quick way to the entrance.
        }

        private void FnTHIEVMAZ_16(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String0B29); // You discover the back entrance to the THIEVES' DEN.
            TeleportParty(player, 0x05, 0x01, 0xBE, 0x01, isForwardMove);
        }

        private void FnLAVA_17(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String0B5D); // You stumble into the lava pools and die.
            DamagePlayer(player, GetMaxHits(player));
        }

        private void FnZEPHYRB_18(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String0B86); // Well worn trails greet those who dare travel the windswept corridors of the ZEPHYR.
            TeleportParty(player, 0x34, 0x01, 0x6E, 0x01, isForwardMove);
        }

        private void FnSDOORWKT_19(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, "Skeletal voices echo...");
            ShowPortrait(player, 0x000A);
            if (AreFourWindsDefeated(player)) {
                ShowMessage(player, isForwardMove, "'You have defeated the four winds! We cannot hold you back. Enter the WIND KNIGHTS' TOMB if you dare.");
                SetWallPassable(player, GetCurrentTile(player), 0x03, 0x01);
                SetWallItem(player, 0x01, GetCurrentTile(player), 0x03);
            }
            else {
                ShowMessage(player, isForwardMove, "'Only Forces more powerful than the four winds can open this door!'");
            }
        }

        private void FnTXTCAMP_1A(ServerPlayer player, bool isForwardMove) {
            ShowPortrait(player, 0x0028);
            ShowMessage(player, isForwardMove, String0D01); // Welcome to LABYRINTH ATTIC!
            ShowMessage(player, isForwardMove, String0D1D); // Refresh yourself in the fountains nearby.  But do not take long!
            ShowMessage(player, isForwardMove, String0D5E); // Bands of travelers rest here before exploring the Wind Labyrinths.
        }

        private void FnKEYDOORW_1B(ServerPlayer player, bool isForwardMove) {
            if (HasUsedItem(player, 0xDD, 0xDD) == 1) {
                SetWallPassable(player, GetCurrentTile(player), 0x00, 0x01);
                SetWallItem(player, 0x01, GetCurrentTile(player), 0x00);
                ShowMessage(player, isForwardMove, String0DA1); // The door is unlocked.
                ShowMessage(player, isForwardMove, String0DB7); // The soft breezes seem to whisper - 'Beware, those who seek the treasure of WIND KNIGHTS' TOMB.'
                return;
            }
            ShowMessage(player, isForwardMove, String0E17); // Winds pound furiously at the door.
        }

        private void FnTXTWYNS_1C(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String0E3A); // The feeble survivors of Arnakkian's Experiment harbored hatred toward those who found home in the WYN SANCTUARY.
        }

        private void FnPITINFO_1D(ServerPlayer player, bool isForwardMove) {
            ShowPortrait(player, 0x002A);
            ShowMessage(player, isForwardMove, String0EAB); // A Gremlin Cleric Appears
            ShowMessage(player, isForwardMove, String0EC4); // 'Take my advice - Jump only into the pits with floors beneath them.
            ShowMessage(player, isForwardMove, String0F08); // That is the way of the Labyrinth.'
        }

        private void FnWKTENCA_1E(ServerPlayer player, bool isForwardMove) {
            AddEncounter(player, 0x01, 0x15);
            AddEncounter(player, 0x02, 0x15);
            AddEncounter(player, 0x05, 0x1E);
            AddEncounter(player, 0x06, 0x1E);
        }

        private void FnWKTTEXT_1F(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String0F2B); // A message is etched in stone -- 
            ShowMessage(player, isForwardMove, String0F4C); // 'The last of Arnakkian's Knights have been buried.  
            ShowMessage(player, isForwardMove, String0F81); // At last I can tell my secret!  I watched as Arnakkian challenged the Time Elemental En-Li-Kil and lost.
            ShowMessage(player, isForwardMove, String0FE9); // His greed for immortality cursed us all.' -- Morgard, ArchCleric
        }

        private void FnWKTENCC_20(ServerPlayer player, bool isForwardMove) {
            AddEncounter(player, 0x01, 0x15);
            AddEncounter(player, 0x02, 0x15);
            AddEncounter(player, 0x03, 0x0D);
            AddEncounter(player, 0x04, 0x0D);
            AddEncounter(player, 0x05, 0x1E);
            AddEncounter(player, 0x06, 0x1E);
            if (AreFourWindsDefeatedInCorrectOrder(player)) {
                AddTreasure(player, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0xCF); // Nothing extra.
            }
            else if (GetFlag(player, FlagTypeMap, 0x01) == 0x0001) { // did North first
                AddTreasure(player, 0x07D0, 0x00, 0x00, 0x00, 0x0E, 0xCF); // Sword of Storms	
            }
            else if (GetFlag(player, FlagTypeMap, 0x03) == 0x0001) { // did East first
                AddTreasure(player, 0x07D0, 0x00, 0x00, 0x00, 0x5B, 0xCF); // Shield of Silence	
            }
            else { // did West first.
                AddTreasure(player, 0x07D0, 0x00, 0x00, 0x00, 0x6F, 0xCF); // Helm of Mercy	
            }
        }

        private void FnWKTENCD_21(ServerPlayer player, bool isForwardMove) {
            AddEncounter(player, 0x01, 0x1E);
            AddEncounter(player, 0x02, 0x1E);
            AddEncounter(player, 0x05, 0x0D);
            AddEncounter(player, 0x06, 0x0D);
            if (AreFourWindsDefeatedInCorrectOrder(player)) {
                AddTreasure(player, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0xCF); // Nothing extra.
            }
            else if (GetFlag(player, FlagTypeMap, 0x01) == 0x0001) { // did North first
                AddTreasure(player, 0x07D0, 0x00, 0x00, 0x00, 0x22, 0xCF); // Harmony Hammer	
            }
            else if (GetFlag(player, FlagTypeMap, 0x03) == 0x0001) { // did East first
                AddTreasure(player, 0x07D0, 0x00, 0x00, 0x00, 0x58, 0xCF); // Shield of Sanity
            }
            else { // did West first.
                AddTreasure(player, 0x07D0, 0x00, 0x00, 0x00, 0x6D, 0xCF); // Sallet of Victory
            }
        }

        private void FnWKTENCE_22(ServerPlayer player, bool isForwardMove) {
            AddEncounter(player, 0x01, 0x14);
            AddEncounter(player, 0x02, 0x1B);
            AddEncounter(player, 0x03, 0x1C);
            AddEncounter(player, 0x04, 0x1D);
            AddEncounter(player, 0x05, 0x1E);
            AddEncounter(player, 0x06, 0x1E);
            ShowMessage(player, isForwardMove, "The WIND KNIGHTS rise from their tombs.");
            if (AreFourWindsDefeatedInCorrectOrder(player)) {
                ShowMessage(player, isForwardMove, "You see a flash of green and then the dead are upon you.");
                AddTreasure(player, 0x07D0, 0x00, 0x00, 0x00, 0xF6, 0xCF); // Green Gem
            }
            else if (GetFlag(player, FlagTypeMap, 0x01) == 0x0001) { // did North first
                ShowMessage(player, isForwardMove, "You feel as if something is out of order, but that thought is shoved aside as the dead are upon you.");
                AddTreasure(player, 0x07D0, 0x00, 0x00, 0x00, 0x29, 0xCF); // Mace of Chivalry	
            }
            else if (GetFlag(player, FlagTypeMap, 0x03) == 0x0001) { // did East first
                ShowMessage(player, isForwardMove, "You feel as if something is out of order, but that thought is shoved aside as the dead are upon you.");
                AddTreasure(player, 0x07D0, 0x00, 0x00, 0x00, 0x29, 0xCF); // War Harness
            }
            else { // did West first.
                ShowMessage(player, isForwardMove, "You feel as if something is out of order, but that thought is shoved aside as the dead are upon you.");
                AddTreasure(player, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0xCF); // Nothing extra.
            }
        }

        private void FnWKTENCF_23(ServerPlayer player, bool isForwardMove) {
            AddEncounter(player, 0x01, 0x1E);
            AddEncounter(player, 0x02, 0x1E);
            AddEncounter(player, 0x03, 0x1E);
            AddEncounter(player, 0x04, 0x15);
            AddEncounter(player, 0x05, 0x0C);
            if (AreFourWindsDefeatedInCorrectOrder(player)) {
                AddTreasure(player, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0xCF); // Nothing extra.
            }
            else if (GetFlag(player, FlagTypeMap, 0x01) == 0x0001) { // did North first
                AddTreasure(player, 0x07D0, 0x00, 0x00, 0x00, 0x31, 0xCF); // Quarterstaff of Terror
            }
            else if (GetFlag(player, FlagTypeMap, 0x03) == 0x0001) { // did East first
                AddTreasure(player, 0x07D0, 0x00, 0x00, 0x00, 0x5A, 0xCF); // Rotund Shield
            }
            else { // did West first.
                AddTreasure(player, 0x07D0, 0x00, 0x00, 0x00, 0x68, 0xCF); // Headmail of Health
            }
        }

        private void FnWKTENCG_24(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String10AC); // In the midst of sleeping Hobgoblins, a small tempest swirls.  It whispers that one's treasure comes from the directions of the winds.
            ShowMessage(player, isForwardMove, String1132); // Then the tempest roars into a nightmare and wakens the hobgoblins.
            AddEncounter(player, 0x01, 0x22);
            AddEncounter(player, 0x02, 0x22);
            AddEncounter(player, 0x05, 0x0D);
            AddEncounter(player, 0x06, 0x0D);
        }

        private void FnWKTENCH_25(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String1175); // Sleeping adventurers are disturbed.
            AddEncounter(player, 0x01, 0x25);
            AddEncounter(player, 0x02, 0x26);
            AddEncounter(player, 0x05, 0x02);
            AddEncounter(player, 0x06, 0x03);
        }

        private void FnWKTENCI_26(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String1199); // A dark corner hides an unlikely mix of beasts.
            AddEncounter(player, 0x01, 0x1B);
            AddEncounter(player, 0x02, 0x1B);
            AddEncounter(player, 0x05, 0x21);
            AddEncounter(player, 0x06, 0x21);
        }

        private void FnSIRFLAG_27(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String11C8); // Sirocco's powers no longer hold the Sirocco Door.
            SetFlag(player, FlagTypeDungeon, FlagLabyrinthISiroccoDoorUnlocked, 0x01);
        }

        private void FnSIRDOOR_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagLabyrinthISiroccoDoorUnlocked));
            L0016: if (JumpEqual) goto L005B;
            L0018: SetWallPassable(player, GetCurrentTile(player), 0x01, 0x01);
            L0032: SetWallItem(player, 0x01, GetCurrentTile(player), 0x01);
            L004C: ShowMessage(player, isForwardMove, String11FA); // Sirocco's powers no longer hold this door.  It is open.
            L0059: goto L0075;
            L005B: ShowMessage(player, isForwardMove, String1232); // Sirocco's Door does not open.  In the distance, a wizard laughs aloud.
            L0068: ShowMessage(player, isForwardMove, String1279); // 'It is I, Sirocco, who bars your way!'
            L0075: return; // RETURN;
        }

        private void FnSIROCCO_29(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String12A0); // Sirocco, the wind labyrinth doorkeeper, materializes in the room.
            ShowMessage(player, isForwardMove, String12E2); // 'You dare challenge the winds??!
            AddEncounter(player, 0x01, 0x1F);
            AddEncounter(player, 0x02, 0x1F);
            AddEncounter(player, 0x03, 0x1F);
            AddEncounter(player, 0x04, 0x1F);
            AddEncounter(player, 0x05, 0x1A);
        }

        private void FnWSBIGDR_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(CheckStrength(player), 0x0012);
            L0012: if (JumpBelow) goto L0041;
            L0014: ShowMessage(player, isForwardMove, String1303); // You force the massive door open by sheer muscle power.
            L0021: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L003F: goto L006B;
            L0041: ShowMessage(player, isForwardMove, String133A); // The door is stuck. You are not strong enough to force it open.
            L004E: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L006B: return; // RETURN;
        }

        private void FnWSENCA_2B(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String1379); // A nest of dragons sneers at you. 'The Sanctuary belongs to us!'
            AddEncounter(player, 0x01, 0x20);
            AddEncounter(player, 0x02, 0x20);
            AddEncounter(player, 0x05, 0x28);
            AddEncounter(player, 0x06, 0x28);
        }

        private void FnWSENCB_2C(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String13B9); // A band of sanctuary guards are alerted.
            AddEncounter(player, 0x01, 0x1F);
            AddEncounter(player, 0x02, 0x1F);
            AddEncounter(player, 0x03, 0x21);
            AddEncounter(player, 0x05, 0x20);
            AddEncounter(player, 0x06, 0x20);
        }

        private void FnWSENCC_2D(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String13E1); // Your path is blocked.
            AddEncounter(player, 0x01, 0x24);
            AddEncounter(player, 0x02, 0x24);
            AddEncounter(player, 0x03, 0x23);
            AddEncounter(player, 0x04, 0x1F);
            AddEncounter(player, 0x05, 0x1C);
            AddEncounter(player, 0x06, 0x20);
        }

        private void FnWSENCF_30(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String13F7); // Adventurers are disturbed.  'We are cursed to kill those who have seen our fate.'
            AddEncounter(player, 0x01, 0x11);
            AddEncounter(player, 0x02, 0x1E);
            AddEncounter(player, 0x03, 0x1C);
            AddEncounter(player, 0x04, 0x13);
        }

        private void FnWSENCG_31(ServerPlayer player, bool isForwardMove) {
            AddEncounter(player, 0x01, 0x1F);
            AddEncounter(player, 0x02, 0x1F);
            AddEncounter(player, 0x05, 0x20);
            AddEncounter(player, 0x06, 0x20);
        }

        private void FnWSNOTE_32(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String1449); // Stuffed behind a rock, you find a magical note that reads... 
            ShowRunes(player, String1487); // 'Red, Yellow, Green and Blue.  That is the order of the gems.'
            ShowMessage(player, isForwardMove, String14C6); // -- signed last Wyn Survivor, Kanasgwyn.
        }

        private void FnWSENCI_33(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String14EE); // Commanders of the Wyn Ogres have set up camp here.
            AddEncounter(player, 0x01, 0x1F);
            AddEncounter(player, 0x02, 0x1F);
            AddEncounter(player, 0x03, 0x23);
            AddEncounter(player, 0x04, 0x23);
            AddEncounter(player, 0x05, 0x20);
            AddEncounter(player, 0x06, 0x20);
        }

        private void FnSDOORWS_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L0039;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L0039;
            L0024: ax = HasUsedItem(player, 0xBE, 0xBE);
            L0037: if (JumpEqual) goto L0064;
            L0039: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0057: ShowMessage(player, isForwardMove, String1521); // You found a secret door!
            L0064: return; // RETURN;
        }

        private void FnARKARCH_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, isForwardMove, String153A); // A message is inscribed on stone -- 
            L0010: ShowMessage(player, isForwardMove, String155E); // 'Labyrinth and lower levels first explored by Arkarch of the Snow Elves.'
            L001D: return; // RETURN;
        }

        private void FnLAENCA_36(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, isForwardMove, String15A8); // Apprentice thieves jump you!  'We must earn our dues!'
            L0010: AddEncounter(player, 0x01, 0x26);
            L0022: AddEncounter(player, 0x02, 0x25);
            L0034: AddEncounter(player, 0x03, 0x27);
            L0046: return; // RETURN;
        }

        private void FnFNTNHEAL_37(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: HealPlayer(player, (ushort)GetMaxHits(player));
            L0014: ShowPortrait(player, 0x0042);
            L0021: ShowMessage(player, isForwardMove, String15DF); // Your many wounds and lingering diseases are removed by the sweet waters of WindyBless Fountain.
            L002E: return; // RETURN;
        }

        private void FnFNTNMANA_38(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddMana(player, 0x012C);
            L0010: ShowPortrait(player, 0x0042);
            L001D: ShowMessage(player, isForwardMove, String163F); // The mystic waters of the NightWillow Fountain restore your Mana level.
            L002A: return; // RETURN;
        }

        private void FnLAENCB_39(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, isForwardMove, String1686); // You stumble into a den of angry monsters.
            L0010: AddEncounter(player, 0x01, 0x21);
            L0022: AddEncounter(player, 0x02, 0x21);
            L0034: AddEncounter(player, 0x03, 0x1C);
            L0046: AddEncounter(player, 0x04, 0x1C);
            L0058: AddEncounter(player, 0x05, 0x28);
            L006A: AddEncounter(player, 0x06, 0x28);
            L007C: return; // RETURN;
        }

        private void FnSDOORLTA_3A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L004E;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L004E;
            L0024: ax = HasUsedItem(player, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L004E;
            L0039: ax = HasUsedItem(player, 0xBE, 0xBE);
            L004C: if (JumpEqual) goto L0079;
            L004E: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L006C: ShowMessage(player, isForwardMove, String16B0); // You found a secret door!
            L0079: return; // RETURN;
        }

        private void FnSDOORLTB_3B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L004E;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L004E;
            L0024: ax = HasUsedItem(player, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L004E;
            L0039: ax = HasUsedItem(player, 0xBE, 0xBE);
            L004C: if (JumpEqual) goto L0079;
            L004E: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L006C: ShowMessage(player, isForwardMove, String16C9); // You discover a secret door!
            L0079: return; // RETURN;
        }

        private void FnSDOORLTC_3C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L004E;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L004E;
            L0024: ax = HasUsedItem(player, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L004E;
            L0039: ax = HasUsedItem(player, 0xBE, 0xBE);
            L004C: if (JumpEqual) goto L0079;
            L004E: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L006C: ShowMessage(player, isForwardMove, String16E5); // A secret door suddenly appears!
            L0079: return; // RETURN;
        }

        private void FnBDOORLTD_3D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(CheckStrength(player), 0x0010);
            L0012: if (JumpBelow) goto L003F;
            L0014: ShowMessage(player, isForwardMove, String1705); // You bash the massive door open.
            L0021: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L003F: return; // RETURN;
        }

        private void FnLTENCA_3E(ServerPlayer player, bool isForwardMove) {
            AddEncounter(player, 0x01, 0x0F);
            AddEncounter(player, 0x02, 0x10);
            AddEncounter(player, 0x05, 0x22);
            AddEncounter(player, 0x06, 0x25);
        }

        private void FnLTENCB_3F(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String1725); // A note -- 'The Runes suggest a path to Arnakkian's Treasure Room.'
            AddEncounter(player, 0x01, 0x23);
            AddEncounter(player, 0x02, 0x22);
            AddEncounter(player, 0x05, 0x25);
            AddEncounter(player, 0x06, 0x26);
        }

        private void FnLTENCC_40(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String1768); // Upon the wall you see a message -- 
            ShowMessage(player, isForwardMove, String178C); // 'Beneath each pit is a floor or another pit.  Fall to the floors to find more passages.'
            AddEncounter(player, 0x01, 0x22);
            AddEncounter(player, 0x02, 0x22);
            AddEncounter(player, 0x05, 0x25);
            AddEncounter(player, 0x06, 0x27);
        }

        private void FnLTENCD_41(ServerPlayer player, bool isForwardMove) {
            AddEncounter(player, 0x01, 0x0F);
            AddEncounter(player, 0x02, 0x0F);
            AddEncounter(player, 0x05, 0x26);
            AddEncounter(player, 0x06, 0x27);
        }

        private void FnLTENCE_42(ServerPlayer player, bool isForwardMove) {
            AddEncounter(player, 0x01, 0x0D);
            AddEncounter(player, 0x02, 0x23);
            AddEncounter(player, 0x05, 0x24);
            AddEncounter(player, 0x06, 0x18);
        }

        private void FnLTENCG_44(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String17E5); // Hobgoblins smile, then attack.
            AddEncounter(player, 0x01, 0x22);
            AddEncounter(player, 0x02, 0x22);
            AddEncounter(player, 0x03, 0x0F);
            AddEncounter(player, 0x04, 0x0F);
        }

        private void FnLTSKILL_45(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, isForwardMove, String1804); // A special thieves' shrine magically glows.
            L0010: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagLabryinthITeachSkill));
            L0023: if (JumpEqual) goto L0028;
            L0025: goto L010D;
            L0028: SetFlag(player, FlagTypeDungeon, FlagLabryinthITeachSkill, 0x01);
            L003D: RefreshCompareFlags(GetSkillLevel(player, 0x0D));
            L004B: if (JumpNotEqual) goto L006E;
            L004D: SetSkillLevel(player, 0x0D, 0x01);
            L005E: ShowMessage(player, isForwardMove, String182F); // You gain the skill of Detection!
            L006B: goto L010B;
            L006E: RefreshCompareFlags(GetSkillLevel(player, 0x0E));
            L007C: if (JumpNotEqual) goto L009E;
            L007E: SetSkillLevel(player, 0x0E, 0x01);
            L008F: ShowMessage(player, isForwardMove, String1850); // You gain the skill of Lockpicking!
            L009C: goto L010B;
            L009E: RefreshCompareFlags(GetSkillLevel(player, 0x0C));
            L00AC: if (JumpNotEqual) goto L00CE;
            L00AE: SetSkillLevel(player, 0x0C, 0x02);
            L00BF: ShowMessage(player, isForwardMove, String1873); // You gain the Bard skill!
            L00CC: goto L010B;
            L00CE: RefreshCompareFlags(GetSkillLevel(player, 0x0F));
            L00DC: if (JumpNotEqual) goto L00FE;
            L00DE: SetSkillLevel(player, 0x0F, 0x01);
            L00EF: ShowMessage(player, isForwardMove, String188C); // You gain the Pickpocketing skill!
            L00FC: goto L010B;
            L00FE: ShowMessage(player, isForwardMove, String18AE); // Nothing happens.
            L010B: goto L011A;
            L010D: ShowMessage(player, isForwardMove, String18BF); // The shrines does nothing.
            L011A: return; // RETURN;
        }

        private void FnLTENCI_46(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String18D9); // Thieves make a desperate stand.
            AddEncounter(player, 0x01, 0x01);
            AddEncounter(player, 0x02, 0x05);
            AddEncounter(player, 0x03, 0x25);
            AddEncounter(player, 0x04, 0x26);
        }

        private void FnLTENCJ_47(ServerPlayer player, bool isForwardMove) {
            ShowMessage(player, isForwardMove, String18F9); // Master Thieves Attack!
            AddEncounter(player, 0x01, 0x04);
            AddEncounter(player, 0x02, 0x08);
            AddEncounter(player, 0x03, 0x25);
            AddEncounter(player, 0x04, 0x26);
            AddEncounter(player, 0x05, 0x27);
        }

        private void FnLTENCK_48(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            // BEGIN;
            ShowMessage(player, isForwardMove, String1910); // Master Thieves ready themselves.
            AddEncounter(player, 0x01, 0x25);
            AddEncounter(player, 0x02, 0x26);
            AddEncounter(player, 0x03, 0x10);
            AddEncounter(player, 0x04, 0x10);
            AddEncounter(player, 0x05, 0x02);
            AddEncounter(player, 0x06, 0x02);
            ax = HasItem(player, 0xDD);
            L008A: if (JumpEqual) goto L00AD;
            L008C: AddTreasure(player, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0xCF);
            L00AB: goto L00DB;
            L00AD: ShowMessage(player, isForwardMove, String1931); // Light sparks off a key tied to the neck of the leader.
            L00BA: AddTreasure(player, 0x3A98, 0x00, 0x00, 0x46, 0x61, 0xDD);
            L00DB: return; // RETURN;
        }

        private void FnTXTAWIND_49(ServerPlayer player, bool isForwardMove) {
            ShowPortrait(player, 0x000A);
            ShowMessage(player, isForwardMove, String1968); // A voice echoes through the winds...
            ShowMessage(player, isForwardMove, String198C); // 'You have traveled well, fair adventurers!
            ShowMessage(player, isForwardMove, String19B7); // I laughed when you troubled King Cleowyn's ghost!
            ShowMessage(player, isForwardMove, String19E9); // But now you enter my tunnels!  Go back whence you came!
            ShowMessage(player, isForwardMove, String1A21); // The Winds will keep these places clean.'
        }

    }
}
