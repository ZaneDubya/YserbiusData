#pragma warning disable
using System.Collections.Generic;
using XPT.Legacy;
using XPT.Legacy.Entities;

namespace XPT.Legacy.Maps {
    class YserMap25 : AMapScripted {
        protected override int MapIndex => 25;
        protected override int RandomEncounterChance => 15;
        protected override int RandomEncounterExtraCount => 2;

        public YserMap25() {
            MapEvent01 = FnCHESLITE_01;
            MapEvent02 = FnCHESDARK_02;
            MapEvent03 = FnVOID_03;
            MapEvent04 = FnPOKERBRG_04;
            MapEvent05 = FnPOKERSW_05;
            MapEvent06 = FnHEARTSDR_06;
            MapEvent07 = FnMOONSW_07;
            MapEvent08 = FnBLAKJAK_08;
            MapEvent09 = FnBLAKJAKK_09;
            MapEvent0A = FnCRIB_0A;
            MapEvent0B = FnCRIBJACK_0B;
            MapEvent0C = FnCRIBFIVE_0C;
            MapEvent0D = FnBRDGFALL_0D;
            MapEvent0E = FnDICEPASS_0E;
            MapEvent0F = FnDICESNAK_0F;
            MapEvent10 = FnDICEBOXC_10;
            MapEvent11 = FnDICEENCA_11;
            MapEvent12 = FnDICEENCB_12;
            MapEvent13 = FnBLJKFOUN_13;
            MapEvent14 = FnCRIBFOUN_14;
            MapEvent15 = FnDICETRSA_15;
            MapEvent16 = FnDICETRSB_16;
            MapEvent17 = FnDICETRSC_17;
            MapEvent18 = FnDICETRSD_18;
            MapEvent19 = FnDICETRSE_19;
            MapEvent1A = FnDICETRSF_1A;
            MapEvent1B = FnDICETRSG_1B;
            MapEvent1C = FnDICETRSH_1C;
            MapEvent1D = FnDICETRSI_1D;
            MapEvent22 = FnBARD_22;
            MapEvent23 = FnAPPLES_23;
            MapEvent24 = FnAPPLEENC_24;
            MapEvent25 = FnCHESENCA_25;
            MapEvent26 = FnCHESENCB_26;
            MapEvent27 = FnCHESENCC_27;
            MapEvent28 = FnCHESENCD_28;
            MapEvent29 = FnCHESENCE_29;
            MapEvent2A = FnCHESENCF_2A;
            MapEvent2B = FnPOKRENCA_2B;
            MapEvent2C = FnCRIBENCA_2C;
            MapEvent2D = FnBLJKENCA_2D;
            MapEvent2E = FnBLJKENCB_2E;
            MapEvent2F = FnCRIBENCB_2F;
            MapEvent30 = FnVARYENCA_30;
            MapEvent31 = FnVARYENCB_31;
            MapEvent34 = FnVARYENCE_34;
            MapEvent35 = FnGATEA_35;
            MapEvent36 = FnTOLABY_36;
            MapEvent37 = FnTXTCHESL_37;
            MapEvent38 = FnTXTCHESD_38;
            MapEvent39 = FnTXTDICEB_39;
            MapEvent3A = FnTXTDICEA_3A;
        }
        
        // === Strings ================================================
        private const string String03FC = "You may leave the chessboard through this opening.";
        private const string String042F = "A knight move here would place you off the chessboard!";
        private const string String0466 = "With a chess piece you may step across the chessboard.";
        private const string String049D = "You may leave the chessboard through this opening.";
        private const string String04D0 = "A knight move here would place you off the chessboard!";
        private const string String0507 = "With a chess piece you may step across the chessboard.";
        private const string String053E = "You fall to your death in the lava below!";
        private const string String0568 = "Planks of the Poker Bridge are made from used playing cards.";
        private const string String05A5 = "The rickety bridge barely holds your weight.";
        private const string String05D2 = "The bridge collapses as you step on it, sending you to your death.";
        private const string String0615 = "The King laughs at his clever ruse.";
        private const string String0639 = "The royal flush beats the Joker!  A bridge forms across the pit.";
        private const string String067A = "A bottomless pit lies before you, and a broken bridge spans the pit.";
        private const string String06BF = "Upon each board are the symbols for 10, Jack, Queen and Ace.  A voice proclaims, 'I call your bluff'.";
        private const string String0725 = "The door bellows, 'I am all hearts!'";
        private const string String074A = "The door proclaims,  'You shot the Moon!'";
        private const string String0774 = "A small button, shaped like the crescent moon, lies just out of reach.";
        private const string String07BB = "The Ace is played as eleven points, scoring the BlackJack!";
        private const string String07F6 = "A door unlocks...";
        private const string String0808 = "You enter a treasure room without any treasure.";
        private const string String0838 = "A dwarf thief voice menacingly orders, 'The Kings guard their treasure.  Only one can find it.'";
        private const string String0898 = "Stand back!  A King guards this wall!";
        private const string String08BE = "The Jack scores the hand 22.  Cribbage is the game.";
        private const string String08F2 = "A door unlocks...";
        private const string String0904 = "The 22nd room of this fine castle...";
        private const string String0929 = "On the floor is a five, on two walls are fives, and the third wall holds a Jack.";
        private const string String097A = "A voice laughs, 'You stand on face up!'";
        private const string String09A2 = "I, the Jack, throw dust in your general direction.";
        private const string String09D5 = "The 5 card smiles back.";
        private const string String09ED = "The Poker Bridge behind you collapses.";
        private const string String0A14 = "Lucky Sevens! Lucky Sevens on the first roll!";
        private const string String0A42 = "The door says, 'Snake eyes' ...";
        private const string String0A62 = "The door shows two squares of six.  'Box Cars' ...";
        private const string String0A95 = "The Blackjack Fountain is made of playing cards.";
        private const string String0AC6 = "Still water fills the basin.";
        private const string String0AE3 = "A sip of it makes you feel healthier and more agile.";
        private const string String0B18 = "As you sip, a voice whispers -";
        private const string String0B37 = "'The Jack has come home.  Thank you for your help.'";
        private const string String0B6B = "The fountain is dry as a bone.";
        private const string String0B8A = "The Cribbage Fountain is bedecked with golden pegs.";
        private const string String0BBE = "A puff of steam from the fountain blows in your face.";
        private const string String0BF4 = "Your Mana is restored and you feel readier to fight.";
        private const string String0C29 = "A voice whispers -";
        private const string String0C3C = "'The Ace has returned.  Three points for you.'";
        private const string String0C6B = "The basin is empty.";
        private const string String0C7F = "A message is inscribed on a wall -- ";
        private const string String0CA4 = "'The Waters of Winter are needed to transform Spring into Summer.";
        private const string String0CE6 = "In return for your deeds, you will receive the Radiance of Summer.'";
        private const string String0D2A = "A note is inscribed on a wall -- ";
        private const string String0D4C = "'To reach En-Li-Kil, you must defeat his Wind Elemental.";
        private const string String0D85 = "Remember to use weapons that do not break when the Wind Elemental attacks.";
        private const string String0DD0 = "A message is written in blood on a wall -- ";
        private const string String0DFC = "'Be careful in the River of Eternity.";
        private const string String0E22 = "The river takes one fourth of your full health every step you take with no opportunity to heal.";
        private const string String0E82 = "'A safe fourth square must be found to cross the Rivers of Eternity.'";
        private const string String0EC8 = "A message is written on a wall -- ";
        private const string String0EEB = "'Use the outer walls to set the location of another's next step in the Parapet Chasm.";
        private const string String0F41 = "Once across, encounter Andreas to gain access to Arnakkian.'";
        private const string String0F7E = "A message is written on a wall -- ";
        private const string String0FA1 = "'The Promise of Spring Renewal must be sworn to convert Autumn to Winter.";
        private const string String0FEB = "In return you will receive the cold Waters of Winter.'";
        private const string String1022 = "An Elf Ranger appears.";
        private const string String1039 = "'In levels below the labyrinth, Snow Elves hide from the curses ";
        private const string String107A = "of Arnakkian and await the day they may return to their faraway land.";
        private const string String10C0 = "A proud tree may be found in their caves.";
        private const string String10EA = "The Snow Elves call this grand tree the Aldbora.";
        private const string String111B = "The Aldbora bears the fruit of knowledge to all adventurers during the season of winter.";
        private const string String1174 = "It lies dormant now, unable to ripen its fruit without the change of seasons and the Radiance of Summer.'";
        private const string String11DE = "A message is scrawled on a wall -- ";
        private const string String1202 = "'Use the Autumn Seeds to transform Winter into flowering Spring.";
        private const string String1243 = "The promise of Spring Renewal for another year will be given in return.'";
        private const string String128C = "A message is carved in the floor -- ";
        private const string String12B1 = "'The bones of a past king may be found in the Elven Caves.'";
        private const string String12ED = "A message is scribbled on a wall -- ";
        private const string String1312 = "'The trumpet sound of the Harvest Horn will announce Summer's conversion to Autumn.";
        private const string String1366 = "From the conversion you will receive the seeds of Autumn.'";
        private const string String13A1 = "A ghost elf bard sings a tale of how four colored magical gems placed side by side can form a rainbow to a far away island.";
        private const string String141D = "The spirit of a beautiful wench appears. She hold a wooden bucket filled wtih floating apples.";
        private const string String147C = "'Step forward and honor me with your kindness!  Bob for apples and win a prize.'";
        private const string String14CD = "You have accepted the ghost's challenge.";
        private const string String14F6 = "You close your eyes and dunk your head into the wood bucket.";
        private const string String1533 = "The ripe apples are rotten and filled with Leeches!";
        private const string String1567 = "You are able to dodge several bursts of flame as you enter a Dragon's Lair.";
        private const string String15B3 = "The gate takes you back to the labyrinth.";
        private const string String15DD = "Use the red squares and you shall turn clockwise on your mount.";
        private const string String161D = "The stallion must go counterclockwise on blue squares!";
        private const string String1654 = "To the west you will find a second dice maze.";
        private const string String1682 = "A maze made out of dice lies just to the north.";
        
        // === Functions ================================================
        private void FnCHESLITE_01(ServerPlayer player, MapEventType type, bool doMsgs) {
            if (GetCurrentTile(player) == 0x0062 && GetFacing(player) == 0) {
                ShowMessage(player, doMsgs, String03FC); // You may leave the chessboard through this opening.
                return;
            }
            if (GetCurrentTile(player) == 0x0069 && GetFacing(player) == 2) {
                ShowMessage(player, doMsgs, String03FC); // You may leave the chessboard through this opening.
                return;
            }
            if (GetCurrentTile(player) == 0x0092 && GetFacing(player) == 0) {
                ShowMessage(player, doMsgs, String03FC); // You may leave the chessboard through this opening.
                return;
            }
            if (GetCurrentTile(player) == 0x0099 && GetFacing(player) == 2) {
                ShowMessage(player, doMsgs, String03FC); // You may leave the chessboard through this opening.
                return;
            }
            SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            if (HasItem(player, 0xEE) == 0) {
                ShowMessage(player, doMsgs, String0466); // With a chess piece you may step across the chessboard.
                return;
            }
            ushort nextTile = (ushort)GetCurrentTile(player);
            switch (GetFacing(player)) {
                case 0: // west
                    nextTile += 0xFFEE;
                    break;
                case 1: // south
                    nextTile += 0x001F; // 
                    break;
                case 2: // east
                    nextTile += 0x0012; //
                    break;
                case 3: // north
                    nextTile += 0xFFE1; // 
                    break;
            }
            int x = nextTile & 0x000f;
            int y = nextTile & 0x00f0;
            if (x < 2 || x > 9 || y < 0x40 || y > 0xB0) {
                ShowMessage(player, doMsgs, String042F); // A knight move here would place you off the chessboard!
                return;
            }
            TeleportParty(player, 0x35, 0x02, nextTile, GetFacing(player), type);
        }

        private void FnCHESDARK_02(ServerPlayer player, MapEventType type, bool doMsgs) {
            if (GetCurrentTile(player) == 0x0062 && GetFacing(player) == 0) {
                ShowMessage(player, doMsgs, String03FC); // You may leave the chessboard through this opening.
                return;
            }
            if (GetCurrentTile(player) == 0x0069 && GetFacing(player) == 2) {
                ShowMessage(player, doMsgs, String03FC); // You may leave the chessboard through this opening.
                return;
            }
            if (GetCurrentTile(player) == 0x0092 && GetFacing(player) == 0) {
                ShowMessage(player, doMsgs, String03FC); // You may leave the chessboard through this opening.
                return;
            }
            if (GetCurrentTile(player) == 0x0099 && GetFacing(player) == 2) {
                ShowMessage(player, doMsgs, String03FC); // You may leave the chessboard through this opening.
                return;
            }
            SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            if (HasItem(player, 0xEE) == 0) {
                ShowMessage(player, doMsgs, String0466); // With a chess piece you may step across the chessboard.
                return;
            }
            ushort nextTile = (ushort)GetCurrentTile(player);
            switch (GetFacing(player)) {
                case 0: // west
                    nextTile += 0x000E;
                    break;
                case 1: // south
                    nextTile += 0x0021; // 
                    break;
                case 2: // east
                    nextTile += 0xFFF2; // -y, +x
                    break;
                case 3: // north
                    nextTile += 0xFFDF; // 
                    break;
            }
            int x = nextTile & 0x000f;
            int y = nextTile & 0x00f0;
            if (x < 2 || x > 9 || y < 0x40 || y > 0xB0) {
                ShowMessage(player, doMsgs, String042F); // A knight move here would place you off the chessboard!
                return;
            }
            TeleportParty(player, 0x35, 0x02, nextTile, GetFacing(player), type);
        }

        private void FnVOID_03(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String053E); // You fall to your death in the lava below!
            DamagePlayer(player, GetMaxHits(player));
        }

        private void FnPOKERBRG_04(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String0568); // Planks of the Poker Bridge are made from used playing cards.
            Compare(GetFlag(player, FlagTypeMap, 0x01), 0x0001);
            if (JumpNotEqual) {
                ShowMessage(player, doMsgs, String05D2); // The bridge collapses as you step on it, sending you to your death.
                ShowMessage(player, doMsgs, String0615); // The King laughs at his clever ruse.
                DamagePlayer(player, GetMaxHits(player));
                return;
            }
            ShowMessage(player, doMsgs, String05A5); // The rickety bridge barely holds your weight.
            SetFloorItem(player, 0x00, 0xDD);
            SetFloorPassable(player, 0xDD, 0x01);
        }

        private void FnPOKERSW_05(ServerPlayer player, MapEventType type, bool doMsgs) {
            if (HasUsedItem(player, type, ref doMsgs, 0xEC, 0xEC) == 0) {
                ShowMessage(player, doMsgs, String067A); // A bottomless pit lies before you, and a broken bridge spans the pit.
                ShowMessage(player, doMsgs, String06BF); // Upon each board are the symbols for 10, Jack, Queen and Ace.  A voice proclaims, 'I call your bluff'.
                return;
            }
            SetFlag(player, FlagTypeMap, 0x01, 0x01);
            SetFloorItem(player, 0x00, 0xDD);
            SetFloorPassable(player, 0xDD, 0x01);
            ShowMessage(player, doMsgs, String0639); // The royal flush beats the Joker!  A bridge forms across the pit.
        }

        private void FnHEARTSDR_06(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String0725); // The door bellows, 'I am all hearts!'
        }

        private void FnMOONSW_07(ServerPlayer player, MapEventType type, bool doMsgs) {
            if (HasUsedItem(player, type, ref doMsgs, 0xEB, 0xEB) == 0) {
                ShowMessage(player, doMsgs, String0774); // A small button, shaped like the crescent moon, lies just out of reach.
                return;
            }
            SetWallItem(player, 0x01, 0xBF, 0x03);
            SetWallPassable(player, 0xBF, 0x03, 0x01);
            ShowMessage(player, doMsgs, String074A); // The door proclaims,  'You shot the Moon!'
        }

        private void FnBLAKJAK_08(ServerPlayer player, MapEventType type, bool doMsgs) {
            if (HasUsedItem(player, type, ref doMsgs, 0xED, 0xED) == 0) goto L0060;
            SetWallItem(player, 0x01, 0x8D, 0x01);
            SetWallPassable(player, 0x8D, 0x01, 0x01);
            ShowMessage(player, doMsgs, String07BB); // The Ace is played as eleven points, scoring the BlackJack!
            ShowMessage(player, doMsgs, String07F6); // A door unlocks...
            return;
            L0060: ShowMessage(player, doMsgs, String0808); // You enter a treasure room without any treasure.
            ShowMessage(player, doMsgs, String0838); // A dwarf thief voice menacingly orders, 'The Kings guard their treasure.  Only one can find it.'
        }

        private void FnBLAKJAKK_09(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String0898); // Stand back!  A King guards this wall!
        }

        private void FnCRIB_0A(ServerPlayer player, MapEventType type, bool doMsgs) {
            if (HasUsedItem(player, type, ref doMsgs, 0xEA, 0xEA) == 0) goto L0060;
            SetWallItem(player, 0x01, 0x7D, 0x03);
            SetWallPassable(player, 0x7D, 0x03, 0x01);
            ShowMessage(player, doMsgs, String08BE); // The Jack scores the hand 22.  Cribbage is the game.
            ShowMessage(player, doMsgs, String08F2); // A door unlocks...
            return;
            L0060: ShowMessage(player, doMsgs, String0904); // The 22nd room of this fine castle...
            ShowMessage(player, doMsgs, String0929); // On the floor is a five, on two walls are fives, and the third wall holds a Jack.
            ShowMessage(player, doMsgs, String097A); // A voice laughs, 'You stand on face up!'
        }

        private void FnCRIBJACK_0B(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String09A2); // I, the Jack, throw dust in your general direction.
        }

        private void FnCRIBFIVE_0C(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String09D5); // The 5 card smiles back.
        }

        private void FnBRDGFALL_0D(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String09ED); // The Poker Bridge behind you collapses.
            SetFlag(player, FlagTypeMap, 0x01, 0x00);
            SetFloorItem(player, 0x01, 0xDD);
        }

        private void FnDICEPASS_0E(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String0A14); // Lucky Sevens! Lucky Sevens on the first roll!
        }

        private void FnDICESNAK_0F(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String0A42); // The door says, 'Snake eyes' ...
        }

        private void FnDICEBOXC_10(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String0A62); // The door shows two squares of six.  'Box Cars' ...
        }

        private void FnDICEENCA_11(ServerPlayer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, 0x01, 0x0A);
            AddEncounter(player, 0x02, 0x0A);
            AddEncounter(player, 0x03, 0x0A);
            AddEncounter(player, 0x04, 0x0A);
            AddEncounter(player, 0x05, 0x04);
            AddEncounter(player, 0x06, 0x04);
        }

        private void FnDICEENCB_12(ServerPlayer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, 0x01, 0x0A);
            AddEncounter(player, 0x02, 0x0A);
            AddEncounter(player, 0x03, 0x0A);
            AddEncounter(player, 0x04, 0x0A);
            AddEncounter(player, 0x05, 0x0A);
            AddEncounter(player, 0x06, 0x0A);
        }

        private void FnBLJKFOUN_13(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String0A95); // The Blackjack Fountain is made of playing cards.
            RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagModAttr_BlackjackFountain));
            if (JumpEqual) goto L0028;
            goto L00AF;
            L0028: SetFlag(player, FlagTypeDungeon, FlagModAttr_BlackjackFountain, 0x01);
            RemoveItem(player, 0xEA);
            ShowPortrait(player, 0x0042);
            ModifyAttribute(player, 0x02, 0x0003);
            HealPlayer(player, (ushort)GetMaxHits(player));
            ShowMessage(player, doMsgs, String0AC6); // Still water fills the basin.
            ShowMessage(player, doMsgs, String0AE3); // A sip of it makes you feel healthier and more agile.
            ShowMessage(player, doMsgs, String0B18); // As you sip, a voice whispers -
            ShowMessage(player, doMsgs, String0B37); // 'The Jack has come home.  Thank you for your help.'
            return;
            L00AF: ShowMessage(player, doMsgs, String0B6B); // The fountain is dry as a bone.
        }

        private void FnCRIBFOUN_14(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String0B8A); // The Cribbage Fountain is bedecked with golden pegs.
            RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagModAttr_CribbageFountain));
            if (JumpEqual) goto L0028;
            goto L00AB;
            L0028: SetFlag(player, FlagTypeDungeon, FlagModAttr_CribbageFountain, 0x01);
            ShowPortrait(player, 0x0042);
            RemoveItem(player, 0xED);
            ModifyAttribute(player, 0x03, 0x0003);
            AddMana(player, 0x0BB8);
            ShowMessage(player, doMsgs, String0BBE); // A puff of steam from the fountain blows in your face.
            ShowMessage(player, doMsgs, String0BF4); // Your Mana is restored and you feel readier to fight.
            ShowMessage(player, doMsgs, String0C29); // A voice whispers -
            ShowMessage(player, doMsgs, String0C3C); // 'The Ace has returned.  Three points for you.'
            return;
            L00AB: ShowMessage(player, doMsgs, String0C6B); // The basin is empty.
        }

        private void FnDICETRSA_15(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String0C7F); // A message is inscribed on a wall -- 
            ShowRunes(player, doMsgs, String0CA4); // 'The Waters of Winter are needed to transform Spring into Summer.
            ShowRunes(player, doMsgs, String0CE6); // In return for your deeds, you will receive the Radiance of Summer.'
        }

        private void FnDICETRSB_16(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String0D2A); // A note is inscribed on a wall -- 
            ShowRunes(player, doMsgs, String0D4C); // 'To reach En-Li-Kil, you must defeat his Wind Elemental.
            ShowRunes(player, doMsgs, String0D85); // Remember to use weapons that do not break when the Wind Elemental attacks.
        }

        private void FnDICETRSC_17(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String0DD0); // A message is written in blood on a wall -- 
            ShowRunes(player, doMsgs, String0DFC); // 'Be careful in the River of Eternity.
            ShowRunes(player, doMsgs, String0E22); // The river takes one fourth of your full health every step you take with no opportunity to heal.
            ShowRunes(player, doMsgs, String0E82); // 'A safe fourth square must be found to cross the Rivers of Eternity.'
        }

        private void FnDICETRSD_18(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String0EC8); // A message is written on a wall -- 
            ShowRunes(player, doMsgs, String0EEB); // 'Use the outer walls to set the location of another's next step in the Parapet Chasm.
            ShowRunes(player, doMsgs, String0F41); // Once across, encounter Andreas to gain access to Arnakkian.'
        }

        private void FnDICETRSE_19(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String0F7E); // A message is written on a wall -- 
            ShowRunes(player, doMsgs, String0FA1); // 'The Promise of Spring Renewal must be sworn to convert Autumn to Winter.
            ShowRunes(player, doMsgs, String0FEB); // In return you will receive the cold Waters of Winter.'
        }

        private void FnDICETRSF_1A(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, 0x001F);
            ShowMessage(player, doMsgs, String1022); // An Elf Ranger appears.
            ShowMessage(player, doMsgs, String1039); // 'In levels below the labyrinth, Snow Elves hide from the curses 
            ShowMessage(player, doMsgs, String107A); // of Arnakkian and await the day they may return to their faraway land.
            ShowMessage(player, doMsgs, String10C0); // A proud tree may be found in their caves.
            ShowMessage(player, doMsgs, String10EA); // The Snow Elves call this grand tree the Aldbora.
            ShowMessage(player, doMsgs, String111B); // The Aldbora bears the fruit of knowledge to all adventurers during the season of winter.
            ShowMessage(player, doMsgs, String1174); // It lies dormant now, unable to ripen its fruit without the change of seasons and the Radiance of Summer.'
        }

        private void FnDICETRSG_1B(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String11DE); // A message is scrawled on a wall -- 
            ShowRunes(player, doMsgs, String1202); // 'Use the Autumn Seeds to transform Winter into flowering Spring.
            ShowRunes(player, doMsgs, String1243); // The promise of Spring Renewal for another year will be given in return.'
        }

        private void FnDICETRSH_1C(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String128C); // A message is carved in the floor -- 
            ShowRunes(player, doMsgs, String12B1); // 'The bones of a past king may be found in the Elven Caves.'
        }

        private void FnDICETRSI_1D(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String12ED); // A message is scribbled on a wall -- 
            ShowRunes(player, doMsgs, String1312); // 'The trumpet sound of the Harvest Horn will announce Summer's conversion to Autumn.
            ShowRunes(player, doMsgs, String1366); // From the conversion you will receive the seeds of Autumn.'
        }

        private void FnBARD_22(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String13A1); // A ghost elf bard sings a tale of how four colored magical gems placed side by side can form a rainbow to a far away island.
        }

        private void FnAPPLES_23(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String141D); // The spirit of a beautiful wench appears. She hold a wooden bucket filled wtih floating apples.
            ShowMessage(player, doMsgs, String147C); // 'Step forward and honor me with your kindness!  Bob for apples and win a prize.'
        }

        private void FnAPPLEENC_24(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String14CD); // You have accepted the ghost's challenge.
            ShowMessage(player, doMsgs, String14F6); // You close your eyes and dunk your head into the wood bucket.
            ShowMessage(player, doMsgs, String1533); // The ripe apples are rotten and filled with Leeches!
            AddEncounter(player, 0x01, 0x1A);
            AddEncounter(player, 0x02, 0x1A);
            AddEncounter(player, 0x03, 0x1B);
            AddEncounter(player, 0x04, 0x1B);
            AddEncounter(player, 0x05, 0x1A);
            AddEncounter(player, 0x06, 0x1A);
        }

        private void FnCHESENCA_25(ServerPlayer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, 0x01, 0x1C);
            AddEncounter(player, 0x02, 0x1D);
            AddEncounter(player, 0x03, 0x1E);
            AddEncounter(player, 0x04, 0x1F);
            AddEncounter(player, 0x05, 0x20);
            AddEncounter(player, 0x06, 0x21);
        }

        private void FnCHESENCB_26(ServerPlayer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, 0x01, 0x1E);
            AddEncounter(player, 0x02, 0x1E);
            AddEncounter(player, 0x03, 0x1E);
            AddEncounter(player, 0x04, 0x1E);
            AddEncounter(player, 0x05, 0x1E);
            AddEncounter(player, 0x06, 0x1E);
        }

        private void FnCHESENCC_27(ServerPlayer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, 0x01, 0x1F);
            AddEncounter(player, 0x02, 0x1F);
            AddEncounter(player, 0x03, 0x1F);
            AddEncounter(player, 0x04, 0x1F);
            AddEncounter(player, 0x05, 0x1F);
            AddEncounter(player, 0x06, 0x1F);
        }

        private void FnCHESENCD_28(ServerPlayer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, 0x01, 0x20);
            AddEncounter(player, 0x02, 0x20);
            AddEncounter(player, 0x03, 0x20);
            AddEncounter(player, 0x04, 0x20);
            AddEncounter(player, 0x05, 0x26);
            AddEncounter(player, 0x06, 0x26);
        }

        private void FnCHESENCE_29(ServerPlayer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, 0x01, 0x22);
            AddEncounter(player, 0x02, 0x22);
            AddEncounter(player, 0x03, 0x22);
            AddEncounter(player, 0x04, 0x22);
            AddEncounter(player, 0x05, 0x22);
            AddEncounter(player, 0x06, 0x1D);
            if (HasItem(player, 0xEB) == 0) {
                AddTreasure(player, 0x03E8, 0x00, 0x00, 0x00, 0xEB, 0xD0);
            }
            else {
                AddTreasure(player, 0x0000, 0x00, 0x00, 0x00, 0x90, 0xAF);
            }
        }

        private void FnCHESENCF_2A(ServerPlayer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, 0x01, 0x18);
            AddEncounter(player, 0x02, 0x18);
            AddEncounter(player, 0x03, 0x15);
            AddEncounter(player, 0x04, 0x18);
            AddEncounter(player, 0x05, 0x15);
            AddEncounter(player, 0x06, 0x1C);
            if (HasItem(player, 0xEC) == 0) {
                AddTreasure(player, 0x03E8, 0x00, 0x00, 0x00, 0xEC, 0xD0);
            }
            else {
                AddTreasure(player, 0x0000, 0x00, 0x00, 0x00, 0x8D, 0xCF);
            }
        }

        private void FnPOKRENCA_2B(ServerPlayer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, 0x01, 0x1F);
            AddEncounter(player, 0x02, 0x1F);
            AddEncounter(player, 0x03, 0x1F);
            AddEncounter(player, 0x04, 0x1F);
            AddEncounter(player, 0x05, 0x1F);
            AddEncounter(player, 0x06, 0x1F);
        }

        private void FnCRIBENCA_2C(ServerPlayer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, 0x01, 0x23);
            AddEncounter(player, 0x02, 0x23);
            AddEncounter(player, 0x05, 0x23);
            AddEncounter(player, 0x06, 0x23);
            AddTreasure(player, 0x2710, 0x00, 0x00, 0xD0, 0xD0, 0x71);
        }

        private void FnBLJKENCA_2D(ServerPlayer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, 0x01, 0x26);
            AddEncounter(player, 0x02, 0x26);
            AddEncounter(player, 0x03, 0x26);
            AddEncounter(player, 0x04, 0x26);
            AddEncounter(player, 0x05, 0x26);
            AddEncounter(player, 0x06, 0x26);
            AddTreasure(player, 0x2710, 0x00, 0x00, 0x00, 0xD0, 0x1D);
        }

        private void FnBLJKENCB_2E(ServerPlayer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, 0x01, 0x26);
            AddEncounter(player, 0x02, 0x26);
            AddEncounter(player, 0x03, 0x26);
            AddEncounter(player, 0x04, 0x26);
            AddEncounter(player, 0x05, 0x26);
            AddEncounter(player, 0x06, 0x26);
            AddTreasure(player, 0x2710, 0x00, 0x00, 0x00, 0xD0, 0xBE);
        }

        private void FnCRIBENCB_2F(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String1567); // You are able to dodge several bursts of flame as you enter a Dragon's Lair.
            AddEncounter(player, 0x01, 0x24);
            AddEncounter(player, 0x02, 0x24);
            AddEncounter(player, 0x03, 0x24);
            AddEncounter(player, 0x05, 0x25);
            AddEncounter(player, 0x06, 0x25);
            AddTreasure(player, 0x2710, 0x00, 0x00, 0xCF, 0xBD, 0x5C);
        }

        private void FnVARYENCA_30(ServerPlayer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, 0x01, 0x04);
            AddEncounter(player, 0x02, 0x04);
            AddEncounter(player, 0x04, 0x04);
            AddEncounter(player, 0x05, 0x04);
        }

        private void FnVARYENCB_31(ServerPlayer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, 0x01, 0x0E);
            AddEncounter(player, 0x02, 0x0E);
            AddEncounter(player, 0x03, 0x0E);
            AddEncounter(player, 0x05, 0x0D);
        }

        private void FnVARYENCE_34(ServerPlayer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, 0x01, 0x13);
            AddEncounter(player, 0x02, 0x13);
            AddEncounter(player, 0x03, 0x13);
            AddEncounter(player, 0x04, 0x13);
            AddEncounter(player, 0x05, 0x17);
            AddEncounter(player, 0x06, 0x02);
        }

        private void FnGATEA_35(ServerPlayer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, 0x35, 0x01, 0x3F, 0x00, type);
        }

        private void FnTOLABY_36(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String15B3); // The gate takes you back to the labyrinth.
        }

        private void FnTXTCHESL_37(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String15DD); // Use the red squares and you shall turn clockwise on your mount.
        }

        private void FnTXTCHESD_38(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String161D); // The stallion must go counterclockwise on blue squares!
        }

        private void FnTXTDICEB_39(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String1654); // To the west you will find a second dice maze.
        }

        private void FnTXTDICEA_3A(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String1682); // A maze made out of dice lies just to the north.
        }

    }
}
