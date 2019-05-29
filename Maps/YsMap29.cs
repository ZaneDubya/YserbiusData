#pragma warning disable
using System.Collections.Generic;
using XPT.Legacy;
using XPT.Legacy.Entities;

namespace XPT.Legacy.Maps {
    class YserMap29 : AMapScripted {
        protected override int MapIndex => 29;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 1;

        public YserMap29() {
            MapEvent01 = FnRIVER_01;
            MapEvent02 = FnRIVRBANK_02;
            MapEvent03 = FnSECDOORA_03;
            MapEvent04 = FnLAVA_04;
            MapEvent05 = FnSECDOORB_05;
            MapEvent06 = FnLAVALEDG_06;
            MapEvent07 = FnLAVAPA_07;
            MapEvent08 = FnLAVAPB_08;
            MapEvent09 = FnLAVAPC_09;
            MapEvent0A = FnLAVAPD_0A;
            MapEvent0B = FnLAVASWA_0B;
            MapEvent0C = FnLAVASWB_0C;
            MapEvent0D = FnLAVASWC_0D;
            MapEvent0E = FnLAVASWD_0E;
            MapEvent0F = FnKINGROOM_0F;
            MapEvent10 = FnDWARKING_10;
            MapEvent11 = FnFLEXSWOR_11;
            MapEvent12 = FnBLAKSMTH_12;
            MapEvent13 = FnCYCLQUST_13;
            MapEvent14 = FnMNRPLATC_14;
            MapEvent15 = FnNSTYOGRE_15;
            MapEvent16 = FnOPENER_16;
            MapEvent17 = FnOPENEE_17;
            MapEvent18 = FnMANTICOR_18;
            MapEvent19 = FnBASILISK_19;
            MapEvent1A = FnKINGGOBL_1A;
            MapEvent1B = FnDRAGON_1B;
            MapEvent1C = FnKEYCLUEA_1C;
            MapEvent1D = FnKEYCLUEB_1D;
            MapEvent1E = FnKEYCLUEC_1E;
            MapEvent1F = FnGATEA_1F;
            MapEvent20 = FnCYCLKEY_20;
            MapEvent21 = FnSECDOORC_21;
            MapEvent25 = FnFNTNATTR_25;
            MapEvent26 = FnNSTYGIAN_26;
            MapEvent27 = FnMAINGIAN_27;
            MapEvent2C = FnTOELVES_2C;
        }
        
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

        // === The Red Gem Quest =====================================================================================
        // This quest requires the player to cross the 'keyhole lava' in the center of the map. The players have two
        // options as to how to complete this quest: they can have a friend help then across in the same way as the
        // parapets quest (revised), or they can use items in sequence to unlock the bridge (original).
        // MapFlag 0x03 is the state of the revised crossing. It is either 0, indicating no tile is passable, or 
        // 1, 2, 3, or 4, indicating that a specific tile is passable, or 5, where the entire bridge is passable.
        // MapFlag 0x02 is the state of the original crossing. It is either 0, indicating the quest has yet to begin,
        // or 0x01-0x0f, indicating a step in the quest. If it is 0x0f, the bridge is passable.
        // ===========================================================================================================

        // === Functions ================================================
        private void FnRIVER_01(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String03FC); // The River of Eternity taps your life energy.
            L0010: SetNoHealZone(player);
            L0018: ax = GetMaxHits(player);
            L001F: bx = 0x0004;
            L0022: dx = ax % bx; ax = ax / bx;
            L0025: DamagePlayer(player, ax);
            L0047: return; // RETURN;
        }

        private void FnRIVRBANK_02(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0438); // Only the bravest adventurers explore the life-devouring River of Eternity for hidden passages.
            L0010: return; // RETURN;
        }

        private void FnSECDOORA_03(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, type, ref doMsgs, ItemSunbeamKey, ItemSunbeamKey);
            L0016: if (JumpNotEqual) goto L002D;
            L0018: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagUsedItemD4ToOpenDwarfDoor));
            L002B: if (JumpEqual) goto L0093;
            L002D: RemoveItem(player, ItemSunbeamKey);
            L0039: SetFlag(player, FlagTypeDungeon, FlagUsedItemD4ToOpenDwarfDoor, 0x01);
            L004E: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L006C: SetWallItem(player, 0x01, GetCurrentTile(player), 0x01);
            L0086: ShowMessage(player, doMsgs, String0497); // A great dwarven door appears in the wall.
            L0093: return; // RETURN;
        }

        private void FnLAVA_04(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String04C1); // Your step into lava is fatal.
            L0010: DamagePlayer(player, GetMaxHits(player));
            L0021: return; // RETURN;
        }

        private void FnSECDOORB_05(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x000B);
            L0012: if (JumpNotBelow) goto L004E;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L004E;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0037: if (JumpNotEqual) goto L004E;
            L0039: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L004C: if (JumpEqual) goto L0099;
            L004E: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L006C: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L008A: ShowMessage(player, doMsgs, String04DF); // You locate a hidden door!
            L0097: goto L00B6;
            L0099: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00B6: return; // RETURN;
        }

        private void FnLAVALEDG_06(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String04F9); // A ledge can be seen across the lava pit.
            if (GetFlag(player, FlagTypeMap, 0x03) == 0x05) {
                ShowMessage(player, doMsgs, "A way has been cleared for you across the pit.");
                return;
            }
            if (GetFlag(player, FlagTypeMap, 0x02) == 0x04) {
                ShowMessage(player, doMsgs, "The way is now clear");
                return;
            }
            if (GetFlag(player,FlagTypeMap, 0x02) == 0x00) {
                ShowMessage(player, doMsgs, "A voice booms out: 'Seek the walls that speak. Heed them well. Do as they ask from south to north and you shall find safe crossing.'");
                return;
            }
        }

        private void FnLAVAPA_07(ServerPlayer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, FlagTypeMap, 0x03) == 0x0001 ||
                GetFlag(player, FlagTypeMap, 0x03) == 0x0005 ||
                GetFlag(player, FlagTypeMap, 0x02) == 0x000f) {
                ShowMessage(player, doMsgs, String0522); // A platform appears beneath your feet..
                SetFloorItem(player, 0x00, 0xA8);
                SetFloorPassable(player, 0xA8, 0x01);
                SetFloorItem(player, 0x00, 0x79);
                SetFloorPassable(player, 0x79, 0x01);
                return;
            }
            ShowMessage(player, doMsgs, String0549); // You step into a lava pit and die!
            DamagePlayer(player, GetMaxHits(player));
        }

        private void FnLAVAPB_08(ServerPlayer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, FlagTypeMap, 0x03) == 0x0002 ||
                GetFlag(player, FlagTypeMap, 0x03) == 0x0005 ||
                GetFlag(player, FlagTypeMap, 0x02) == 0x000f) {
                ShowMessage(player, doMsgs, String0522); // A platform appears beneath your feet..
                SetFloorItem(player, 0x00, 0xA8);
                SetFloorPassable(player, 0xA8, 0x01);
                SetFloorItem(player, 0x00, 0x79);
                SetFloorPassable(player, 0x79, 0x01);
                return;
            }
            ShowMessage(player, doMsgs, String0549); // You step into a lava pit and die!
            DamagePlayer(player, GetMaxHits(player));
        }

        private void FnLAVAPC_09(ServerPlayer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, FlagTypeMap, 0x03) == 0x0003 ||
                GetFlag(player, FlagTypeMap, 0x03) == 0x0005 ||
                GetFlag(player, FlagTypeMap, 0x02) == 0x000f) {
                ShowMessage(player, doMsgs, String0522); // A platform appears beneath your feet..
                SetFloorItem(player, 0x00, 0xA8);
                SetFloorPassable(player, 0xA8, 0x01);
                SetFloorItem(player, 0x00, 0x79);
                SetFloorPassable(player, 0x79, 0x01);
                return;
            }
            ShowMessage(player, doMsgs, String0549); // You step into a lava pit and die!
            DamagePlayer(player, GetMaxHits(player));
        }

        private void FnLAVAPD_0A(ServerPlayer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, FlagTypeMap, 0x03) == 0x0004 ||
                GetFlag(player, FlagTypeMap, 0x03) == 0x0005 ||
                GetFlag(player, FlagTypeMap, 0x02) == 0x000f) {
                ShowMessage(player, doMsgs, String0522); // A platform appears beneath your feet..
                SetFloorItem(player, 0x00, 0xA8);
                SetFloorPassable(player, 0xA8, 0x01);
                SetFloorItem(player, 0x00, 0x79);
                SetFloorPassable(player, 0x79, 0x01);
                return;
            }
            ShowMessage(player, doMsgs, String0549); // You step into a lava pit and die!
            DamagePlayer(player, GetMaxHits(player));
        }

        /// <summary>
        /// Returns true if this wall has been satisfied, false if the calling function should show a hint.
        /// </summary>
        private bool FnLavaWalls(ServerPlayer player, MapEventType type, ref bool doMsgs, int wallBit, int itemType) {
            if (GetFlag(player, FlagTypeMap, 0x02) == 0x0f) {
                ShowMessage(player, doMsgs, "The walls have been satisfied. The way is clear.");
                return true;
            }
            if ((GetFlag(player, FlagTypeMap, 0x02) & wallBit) == wallBit) {
                ShowMessage(player, doMsgs, "This wall is satisfied. There are yet more gifts to give.");
                return true;
            }
            if (HasUsedItem(player, type, ref doMsgs, itemType, itemType) == 1) {
                player.RemoveItemByType(itemType, onlyOne: true);
                SetFlag(player, FlagTypeMap, 0x02, GetFlag(player, FlagTypeMap, 0x02) | wallBit);
                ShowMessage(player, doMsgs, "This gift satisfies the wall.");
                if (GetFlag(player, FlagTypeMap, 0x02) == 0x0f) {
                    ShowMessage(player, doMsgs, "The walls have been satisfied. The way is clear.");
                }
                else {
                    ShowMessage(player, doMsgs, "There are yet more gifts to give.");
                }
                return true;
            }
            return false;
        }

        private void FnLAVASWA_0B(ServerPlayer player, MapEventType type, bool doMsgs) {
            if (!FnLavaWalls(player, type, ref doMsgs, 0x01, 184)) {
                ShowMessage(player, doMsgs, "The wall speaks: 'If you come with friends, I will take them one step of the way. If you wish a path for all, you must satisfy these walls.");
                ShowMessage(player, doMsgs, "'I demand something of worth! A thing that will lighten your purse. Yet no more than would be allowed: what's found in lining of any cloud.'");
            }
            // ShowMessage(player, doMsgs, String0662); // In the distance you hear a platform moving.
            SetFlag(player, FlagTypeMap, 0x03, 0x01);
        }

        private void FnLAVASWB_0C(ServerPlayer player, MapEventType type, bool doMsgs) {
            if (!FnLavaWalls(player, type, ref doMsgs, 0x02, 1)) {
                ShowMessage(player, doMsgs, "The wall speaks: 'If you come with friends, I will take them one step of the way. If you wish a path for all, you must satisfy these walls.");
                ShowMessage(player, doMsgs, "'I demand a stunted blade, of steel or iron simply made! Small in stature, a halflings sword, that anyone could well afford.'");
            }
            // ShowMessage(player, doMsgs, String0662); // In the distance you hear a platform moving.
            SetFlag(player, FlagTypeMap, 0x03, 0x02);
        }

        private void FnLAVASWC_0D(ServerPlayer player, MapEventType type, bool doMsgs) {
            if (!FnLavaWalls(player, type, ref doMsgs, 0x04, 191)) {
                ShowMessage(player, doMsgs, "The wall speaks: 'If you come with friends, I will take them one step of the way. If you wish a path for all, you must satisfy these walls.");
                ShowMessage(player, doMsgs, "'I demand a young thief's tool, the color of an emerald jewel! Such as might open simple drawers, lockboxes, chests, and miner's doors.'");
            }
            // ShowMessage(player, doMsgs, String0662); // In the distance you hear a platform moving.
            SetFlag(player, FlagTypeMap, 0x03, 0x03);
        }

        private void FnLAVASWD_0E(ServerPlayer player, MapEventType type, bool doMsgs) {
            if (!FnLavaWalls(player, type, ref doMsgs, 0x08, 211)) {
                ShowMessage(player, doMsgs, "The wall speaks: 'If you come with friends, I will take them one step of the way. If you wish a path for all, you must satisfy these walls.");
                ShowMessage(player, doMsgs, "'I demand the dead king's key! That's all I want, no more for me.'");
            }
            // ShowMessage(player, doMsgs, String0662); // In the distance you hear a platform moving.
            SetFlag(player, FlagTypeMap, 0x03, 0x04);
        }

        private void FnKINGROOM_0F(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0799); // You enter a magnificently ornamented room, bedecked with jewels and the finely crafted metalworks of dwarf craftsmen.
            L0010: ShowMessage(player, doMsgs, String080F); // In a small chair in the center of this royal treasure sits the Dwarf King.
            L001D: return; // RETURN;
        }

        private void FnDWARKING_10(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, ItemRanbowGemRed);
            L0011: if (JumpNotEqual) goto L0061;
            L0013: ShowPortrait(player, 0x001C);
            L0020: ShowMessage(player, doMsgs, String085A); // The Dwarf King nods.
            L002D: ShowMessage(player, doMsgs, String086F); // 'Welcome strangers! 
            L003A: ShowMessage(player, doMsgs, String0884); // I have a quest for you, if you are brave enough!
            L0047: ShowMessage(player, doMsgs, String08B5); // Beyond the keyhole lava lies a gem of great value, stolen by a fiercesome Dragon.
            L0054: ShowMessage(player, doMsgs, String0907); // Keep the gem if you like, as our token of friendship. We ask only that you destroy this vile creature who blackmails us in return for peace.'
            L0061: return; // RETURN;
        }

        private void FnFLEXSWOR_11(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002C);
            L0010: ax = HasItem(player, 0x09);
            L001E: if (JumpNotEqual) goto L008D;
            L0020: ax = HasItem(player, 0xF0);
            L002E: if (JumpEqual) goto L0071;
            L0030: ShowMessage(player, doMsgs, String0995); // The dwarf takes the Flex Metal and smiles broadly. 'No greater pleasure can a dwarf blacksmith have than to test the powers of a new metal.'
            L003D: ShowMessage(player, doMsgs, String0A22); // After a few hours working the metal, she holds up a brilliant blue sword.
            L004A: ShowMessage(player, doMsgs, String0A6C); // 'There!  My finest weapon, made from your Flex Metal.  I dub it The Wind Sword!  May it destroy your enemies at first blow!'
            L0057: RemoveItem(player, ItemFlexMetal);
            L0063: GiveItem(player, 0x09);
            L006F: goto L008B;
            L0071: ShowMessage(player, doMsgs, String0AE9); // The dwarf blacksmith cuts down the furnace, then turns to greet you. 
            L007E: ShowMessage(player, doMsgs, String0B2F); // 'I am a wizard swordmaker, ready to make the finest weapons from your valuable metals.  What may I build for you?'
            L008B: goto L00C1;
            L008D: ShowMessage(player, doMsgs, String0BA2); // The dwarf blacksmith pauses briefly from her work.
            L009A: ShowMessage(player, doMsgs, String0BD5); // 'I see you have returned!'  An expression of worry crosses her face.  'Oh, I hope The Wind Sword has given you no trouble.'
            L00A7: ShowMessage(player, doMsgs, String0C51); // She then notices the great blue sword.  'Ah, it's in fine shape!
            L00B4: ShowMessage(player, doMsgs, String0C92); // If you find other types of metals, I will gladly make you another weapon!'
            L00C1: return; // RETURN;
        }

        private void FnBLAKSMTH_12(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0CDD); // The room you enter contains furnaces, hammers and anvils.
            L0010: ShowMessage(player, doMsgs, String0D17); // In a corner is a dwarf blacksmith, hard at work on her latest golden creation.
            L001D: return; // RETURN;
        }

        private void FnCYCLQUST_13(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002C);
            L0010: ax = HasItem(player, ItemGoldenBoat);
            L001E: if (JumpEqual) goto L0023;
            L0020: goto L00DD;
            L0023: ax = HasItem(player, ItemCyclopsHead);
            L0031: if (JumpEqual) goto L0099;
            L0033: ShowMessage(player, doMsgs, String0D66); // A mean, twisted smile appears across the face of the dwarf blacksmith.
            L0040: ShowMessage(player, doMsgs, String0DAD); // 'You have killed the cyclop!  My gold caves are won!
            L004D: ShowMessage(player, doMsgs, String0DE2); // Hmmph.  It is my debt to repay you.  And I shall!'
            L005A: ShowMessage(player, doMsgs, String0E15); // A few hours pass as the blacksmith weaves a magnificent treasure from golden threads.  Then she appears again.
            L0067: ShowMessage(player, doMsgs, String0E84); // 'Here.  My proudest work!  A golden boat that can ride the rainbows.  May you find treasure wherever you go.'
            L0074: ShowMessage(player, doMsgs, String0EF2); // Then she scoots away.
            L0081: RemoveItem(player, ItemCyclopsHead);
            L008D: GiveItem(player, ItemGoldenBoat);
            L0099: ax = HasItem(player, ItemCyclopsHead);
            L00A7: if (JumpNotEqual) goto L00DD;
            L00A9: ShowMessage(player, doMsgs, String0F08); // The old dwarf blacksmith at first does not hear you approach. Then she senses your presence and wheels on you. 
            L00B6: ShowMessage(player, doMsgs, String0F78); // 'A mean trick you play on a wise one!  No matter.  No doubt you're looking for another golden trinket of mine.
            L00C3: ShowMessage(player, doMsgs, String0FE7); // Well, I will not give you any of my creations.  Never!
            L00D0: ShowMessage(player, doMsgs, String101E); // Unless, hmmm, Unless you are able to rid my gold caves of a horrible Cyclop! He fancies himself King of the Cyclops.'
            L00DD: return; // RETURN;
        }

        private void FnMNRPLATC_14(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0023);
            L0010: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagUsedHiddenMineKey));
            L0023: if (JumpEqual) goto L008F;
            L0025: ShowMessage(player, doMsgs, String1094); // The dwarf miner greets you with youthful enthusiasm.
            L0032: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagMinerReward));
            L0045: if (JumpNotEqual) goto L008D;
            L0047: SetFlag(player, FlagTypeDungeon, FlagMinerReward, 0x01);
            L005C: ShowMessage(player, doMsgs, String10C9); // You show signs of entering my caves!  I thank-you for clearing my mines and repay you with treasure.
            L0069: GiveItem(player, 0xBA);
            L0075: GiveItem(player, 0xBA);
            L0081: GiveItem(player, 0xBA);
            L008D: goto L00FB;
            L008F: ax = HasItem(player, ItemHiddenMineKey); // has the hidden mine key?
            L009D: if (JumpEqual) goto L00BB;
            L009F: ShowMessage(player, doMsgs, String112E); // The dwarf miner smiles as you approach.
            L00AC: ShowMessage(player, doMsgs, String1156); // 'Have you found my cave yet?  It is by the water's edge.'
            L00B9: goto L00FB;
            L00BB: ShowMessage(player, doMsgs, String1190); // An apprentice dwarf miner notices your arrival.
            L00C8: ShowMessage(player, doMsgs, String11C0); // 'Adventurers!  At last!  I've heard tales from the elders about your deeds.  I, too, have a cave, well hidden beyond the edges of the waters.
            L00D5: ShowMessage(player, doMsgs, String124E); // Monsters have forced me from my home. I am not strong enough to fight them.
            L00E2: ShowMessage(player, doMsgs, String129A); // Perhaps, if I give you the key to my small cave, you will do me a favor. Then I may repay you well some day.'
            L00EF: GiveItem(player, ItemHiddenMineKey);
            L00FB: return; // RETURN;
        }

        private void FnNSTYOGRE_15(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x14);
            L0015: AddEncounter(player, 0x02, 0x14);
            L0027: AddEncounter(player, 0x03, 0x14);
            L0039: AddEncounter(player, 0x04, 0x14);
            L004B: AddEncounter(player, 0x05, 0x14);
            L005D: AddEncounter(player, 0x06, 0x14);
            L006F: return; // RETURN;
        }

        private void FnOPENER_16(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, FlagTypeMap, 0x03, 0x05);
            L0018: ShowMessage(player, doMsgs, String1308); // All the east side platforms appear to be up.
            L0025: SetFloorItem(player, 0x00, 0xA9);
            L0035: SetFloorPassable(player, 0xA9, 0x01);
            L0046: SetFloorItem(player, 0x00, 0x99);
            L0056: SetFloorPassable(player, 0x99, 0x01);
            L0067: SetFloorItem(player, 0x00, 0x89);
            L0077: SetFloorPassable(player, 0x89, 0x01);
            L0088: SetFloorItem(player, 0x00, 0x79);
            L0098: SetFloorPassable(player, 0x79, 0x01);
            L00A9: return; // RETURN;
        }

        private void FnOPENEE_17(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, FlagTypeMap, 0x03), 0x0005);
            L0017: if (JumpNotEqual) goto L004D;
            L0019: SetWallItem(player, 0x01, GetCurrentTile(player), 0x03);
            L0033: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x01);
            L004D: return; // RETURN;
        }

        private void FnMANTICOR_18(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x23);
            L0015: AddEncounter(player, 0x02, 0x24);
            L0027: AddEncounter(player, 0x03, 0x24);
            L0039: AddEncounter(player, 0x04, 0x23);
            L004B: AddEncounter(player, 0x05, 0x19);
            L005D: AddEncounter(player, 0x06, 0x19);
            L006F: return; // RETURN;
        }

        private void FnBASILISK_19(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, "Runes on the far wall read: 'The Keyhole Lava lies at the centre of this Kingdom.Give the greedy walls that which they request and the way across the lava will be clear.'");
            ShowMessage(player, doMsgs, "Between you and the runes are Basilisks.");
            AddEncounter(player, 0x01, 0x11);
            AddEncounter(player, 0x02, 0x11);
            AddEncounter(player, 0x03, 0x12);
            AddEncounter(player, 0x04, 0x12);
            AddEncounter(player, 0x05, 0x13);
            AddEncounter(player, 0x06, 0x13);
        }

        private void FnKINGGOBL_1A(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x04);
            L0015: AddEncounter(player, 0x02, 0x04);
            L0027: AddEncounter(player, 0x03, 0x04);
            L0039: AddEncounter(player, 0x04, 0x04);
            L004B: AddEncounter(player, 0x05, 0x06);
            L005D: AddEncounter(player, 0x06, 0x06);
            L006F: return; // RETURN;
        }

        private void FnDRAGON_1B(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x06);
            L0015: AddEncounter(player, 0x02, 0x06);
            L0027: AddEncounter(player, 0x03, 0x19);
            L0039: AddEncounter(player, 0x04, 0x19);
            L004B: AddEncounter(player, 0x05, 0x1B);
            L005D: AddEncounter(player, 0x06, 0x13);
            L006F: ax = HasItem(player, ItemRanbowGemRed);
            L007D: if (JumpEqual) goto L00A1;
            L007F: AddTreasure(player, 0x07D0, 0x00, 0x00, 0x00, 0xC6, 0xB7);
            L009F: goto L00D0;
            L00A1: ShowMessage(player, doMsgs, String1335); // A glowing red gem casts a beam from under the dragon's lair.
            L00AE: AddTreasure(player, 0x2328, 0x00, 0x14, 0xD0, 0xD0, ItemRanbowGemRed);
            L00D0: return; // RETURN;
        }

        private void FnKEYCLUEA_1C(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String1372); // A collection of runes reveals a clue -- 
            L0010: ShowRunes(player, doMsgs, String139B); // The Keyhole Lava lies at the center of the Kingdom.
            L001D: ShowRunes(player, doMsgs, String13CF); // Activate the switches to the west one at a time to move a party from south to north.
            L002A: return; // RETURN;
        }

        private void FnKEYCLUEB_1D(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String1424); // A faint message written in dust -- 
            L0010: ShowRunes(player, doMsgs, String1448); // The Keyhole Lava lies at the center of the Kingdom.
            L001D: ShowRunes(player, doMsgs, String147C); // Repeat the sequence that moved a party south to north to move  a party north to south.
            L002A: return; // RETURN;
        }

        private void FnKEYCLUEC_1E(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String14D3); // A note is found behind a rock -- 
            L0010: ShowRunes(player, doMsgs, String14F5); // The one who switches a party across the Keyhole Lava may join the party at the south end of a second crossing.
            L001D: return; // RETURN;
        }

        private void FnGATEA_1F(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String1564); // Distant bellows from gruesome monsters echo through the cavern.
            L0010: TeleportParty(player, 0x38, 0x02, 0x30, 0x02, type);
            L002B: return; // RETURN;
        }

        private void FnCYCLKEY_20(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, ItemCyclopsMineKey);
            L0011: if (JumpEqual) goto L0022;
            L0013: ShowMessage(player, doMsgs, String15A4); // The room has been emptied.
            L0020: goto L003B;
            L0022: GiveItem(player, ItemCyclopsMineKey);
            L002E: ShowMessage(player, doMsgs, String15BF); // You find a key to the Cyclop's Mine on the floor.
            L003B: return; // RETURN;
        }

        private void FnSECDOORC_21(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0004);
            L000D: if (JumpEqual) goto L0012;
            L000F: goto L00C8;
            L0012: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x0008);
            L0021: if (JumpNotBelow) goto L005D;
            L0023: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0031: if (JumpNotEqual) goto L005D;
            L0033: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L0046: if (JumpNotEqual) goto L005D;
            L0048: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L005B: if (JumpEqual) goto L00A8;
            L005D: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L007B: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0099: ShowMessage(player, doMsgs, String15F1); // You found a hidden door!
            L00A6: goto L00C5;
            L00A8: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00C5: goto L017B;
            L00C8: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x000B);
            L00D7: if (JumpNotBelow) goto L0113;
            L00D9: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L00E7: if (JumpNotEqual) goto L0113;
            L00E9: ax = HasUsedItem(player, type, ref doMsgs, 0xA2, 0xA2);
            L00FC: if (JumpNotEqual) goto L0113;
            L00FE: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L0111: if (JumpEqual) goto L015E;
            L0113: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0131: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L014F: ShowMessage(player, doMsgs, String160A); // You found a hidden door!
            L015C: goto L017B;
            L015E: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L017B: return; // RETURN;
        }

        private void FnFNTNATTR_25(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagModAttr_FountainOfAttr));
            L0016: if (JumpNotEqual) goto L006C;
            L0018: SetFlag(player, FlagTypeDungeon, FlagModAttr_FountainOfAttr, 0x01);
            L002D: ShowPortrait(player, 0x0042);
            L003A: ModifyAttribute(player, 0x00, 0x0002);
            L004B: ModifyAttribute(player, 0x01, 0x0001);
            L005D: ShowMessage(player, doMsgs, String1623); // You drink from the Fountain of Attributes and feel your powers greatly increase.
            L006A: goto L0086;
            L006C: ShowPortrait(player, 0x0042);
            L0079: ShowMessage(player, doMsgs, String1674); // The waters of the Fountain of Attributes quench your thirst but do not otherwise affect you.
            L0086: return; // RETURN;
        }

        private void FnNSTYGIAN_26(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x1E);
            L0015: AddEncounter(player, 0x02, 0x1E);
            L0027: AddEncounter(player, 0x03, 0x1E);
            L0039: AddEncounter(player, 0x04, 0x1E);
            L004B: AddEncounter(player, 0x05, 0x1E);
            L005D: AddEncounter(player, 0x06, 0x1E);
            L006F: return; // RETURN;
        }

        private void FnMAINGIAN_27(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x1F);
            L0015: AddEncounter(player, 0x02, 0x1F);
            L0027: AddEncounter(player, 0x03, 0x1E);
            L0039: AddEncounter(player, 0x04, 0x1E);
            L004B: AddEncounter(player, 0x05, 0x20);
            L005D: AddEncounter(player, 0x06, 0x1F);
            L006F: return; // RETURN;
        }

        private void FnTOELVES_2C(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String16D1); // A passageway leads up to the elfin lands.
            L0010: TeleportParty(player, 0x37, 0x01, 0x7F, 0x01, type);
            L002B: return; // RETURN;
        }

    }
}
