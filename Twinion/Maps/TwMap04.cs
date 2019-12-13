#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Twinion.Maps {
    class TwMap04 : AMapScripted {
        protected override int MapIndex => 4;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public TwMap04() {
            MapEvent01 = FnRIVER_01;
            MapEvent02 = FnPITPUMP_02;
            MapEvent03 = FnCOLUMN_03;
            MapEvent04 = FnTOSOUTHE_04;
            MapEvent05 = FnTONORTHW_05;
            MapEvent06 = FnTOSOUTHW_06;
            MapEvent07 = FnEGRESS_07;
            MapEvent08 = FnCELLONE_08;
            MapEvent09 = FnCELLTWO_09;
            MapEvent0A = FnCELTHREE_0A;
            MapEvent0B = FnBLOCKWAL_0B;
            MapEvent0C = FnGUARDMES_0C;
            MapEvent0D = FnTOMAPA_0D;
            MapEvent0E = FnMESSA_0E;
            MapEvent0F = FnMESSB_0F;
            MapEvent10 = FnMESSC_10;
            MapEvent11 = FnTOAMESS_11;
            MapEvent12 = FnEASTMESS_12;
            MapEvent13 = FnBAZAAR_13;
            MapEvent14 = FnCNTRMESS_14;
            MapEvent15 = FnTWRDOOR_15;
            MapEvent16 = FnQUEENGRD_16;
            MapEvent17 = FnWATCHMAN_17;
            MapEvent18 = FnSWITCH_18;
            MapEvent19 = FnROGUEONE_19;
            MapEvent1A = FnROGUETWO_1A;
            MapEvent1B = FnPRSNERA_1B;
            MapEvent1C = FnPRSNERB_1C;
            MapEvent1D = FnPRSNERC_1D;
            MapEvent1E = FnLOSTNPCA_1E;
            MapEvent1F = FnLOSTNPCB_1F;
            MapEvent20 = FnSOAKINGA_20;
            MapEvent21 = FnROTATEME_21;
            MapEvent22 = FnTOUGHBAT_22;
            MapEvent23 = FnNPCINFO_23;
            MapEvent24 = FnNPCDRY_24;
            MapEvent25 = FnGOODBOOT_25;
            MapEvent26 = FnINFOONE_26;
            MapEvent28 = FnSTEALONE_28;
            MapEvent29 = FnBIGBATL_29;
            MapEvent2A = FnDUCTSWIT_2A;
            MapEvent2B = FnDIDPATH_2B;
            MapEvent2C = FnWATRFALL_2C;
            MapEvent2D = FnBRIDGSPC_2D;
            MapEvent2E = FnBRIDGB_2E;
            MapEvent2F = FnSETBRIDG_2F;
            MapEvent30 = FnSETUPTWR_30;
            MapEvent31 = FnTHFWIZ_31;
            MapEvent32 = FnBARBRANG_32;
            MapEvent33 = FnRESIST_33;
            MapEvent34 = FnPICKTHIS_34;
            MapEvent35 = FnILLUSION_35;
        }
        
        // === Strings ================================================
        private const string String03FC = "The rushing waters pummel your body.";
        private const string String0421 = "You have been drowned by the force.";
        private const string String0445 = "You've defeated Aqueus! You may travel safely through these waters now.";
        private const string String048D = "The magical force of the pump propels you southeastward and slams you squarely into a wall.";
        private const string String04E9 = "To the other shore...";
        private const string String04FF = "Closer and closer you go.";
        private const string String0519 = "Take this experience and these coins to aid thee in thy travels!";
        private const string String055A = "And yet one step further along the path.";
        private const string String0583 = "Westward takes you back to the main Aqueduct.";
        private const string String05B1 = "A magical wall bars you from moving any closer to the prisoner in the southern cell.";
        private const string String0606 = "A mystical force prevents access southward to another prisoner in the Aqueduct's cells.";
        private const string String065E = "A hulking beast is imprisoned southward behind some unseen forces of magic.";
        private const string String06AA = "An unseen force holds you back.";
        private const string String06CA = "BEHOLD: This tower was built by Queen Aeowyn to control the force of the Aqueduct as it leaves this place. Hail her Royal Highness!";
        private const string String074E = "This path leads back whence you came.";
        private const string String0774 = "Do not forsake your loyal friends.";
        private const string String0797 = "WARNING: DO NOT READ THIS SIGN!";
        private const string String07B7 = "For true friendship can bridge time...";
        private const string String07DE = "I'M TELLING YOU - STOP READING THIS!";
        private const string String0803 = "Personal sacrifice will send your friends forward.";
        private const string String0836 = "I CAN'T BELIEVE YOU DON'T LISTEN TO ME!";
        private const string String085E = "Obviously some vandalish rogues have been at these signs.";
        private const string String0898 = "Well done!  Westward now and hurry. You're almost to the end of the Proving Grounds!";
        private const string String08ED = "You stand midway between the two watch towers. The view really is quite magnificent.";
        private const string String0942 = "Invisible forces keep you from falling off the bridge into the icy waters below.";
        private const string String0993 = "You stand directly below a narrow bridge that spans the Aqueduct. Eastward is a great waterfall that pours from the side of the volcano.";
        private const string String0A1C = "This majestic meeting hall bustles with commerce.";
        private const string String0A4E = "The walls reverberate with the din of haggling and betrayal.";
        private const string String0A8B = "None of the merchants wishes to deal with you.";
        private const string String0ABA = "Perhaps another time, when you have items worth their interest.";
        private const string String0AFA = "The Cross Key easily unlocks the door.";
        private const string String0B21 = "A strange keyhole, marked with an X, obviously suggests that a special key is needed to unlock this door.";
        private const string String0B8B = "One of the Queen's Guard is here.";
        private const string String0BAD = "'Away with you.  I have no time to waste with the likes of you.'";
        private const string String0BEE = "The guard is still here.";
        private const string String0C07 = "'What now?  Stop bothering me or I shall be forced to remove you.'";
        private const string String0C4A = "'ENOUGH! Have at you!'";
        private const string String0C61 = "You notice a variety of levers on the wall here.";
        private const string String0C92 = "'Welcome to the tower! Don't play with the switches, please.  And please be careful on the bridge.'";
        private const string String0CF6 = "You hear the sounds of locking mechanisms being released by the opening of the sluice gates; as if some doors off to the west are now unlocked!";
        private const string String0D86 = "The sluice gates have been closed, slowing the waters' flow. A low rumbling sound can be heard as though some mechanism has just been locked down again.";
        private const string String0E1F = "You fiddle with the various switches here against the watchman's advice. Upon hitting an odd-shaped lever, you hear the sound of the Aqueduct change.";
        private const string String0EB5 = "Rogues rush at you from the shadows.";
        private const string String0EDA = "Assassins!!";
        private const string String0EE6 = "As you enter the prisoner's cell, he turns to make his escape by force.";
        private const string String0F2E = "'Fools! Fools! Do you think the waters always run! Mad, mad, mad, ahahahhahah!!'";
        private const string String0F7F = "Obviously this prisoner is insane.";
        private const string String0FA2 = "A tiny door is visible to the west. You should be able to make it through.";
        private const string String0FED = "The Coelus here, however, is another story.";
        private const string String1019 = "'Hmm...these foul spinning squares confuse and confound me. I do not understand how to defeat them.'";
        private const string String107E = "The Cleric has wandered off.";
        private const string String109B = "You tell the Ranger where you recently saw a confused Cleric.";
        private const string String10D9 = "'Excellent! I shall search there for him. My gratitude to you, good friend. Here, presents for your help.'";
        private const string String1144 = "He then marches off.";
        private const string String1159 = "'Well, never mind then.' The Ranger turns and walks away.";
        private const string String1193 = "'Pardon me, did you happen to see a Cleric friend of mine?  I'm afraid he gets confused quite easily.'";
        private const string String11FA = "A sopping wet thief is here.";
        private const string String1217 = "'I say, that blasted Aqueduct is frigid today. There must be a way to regulate the water's flow.'";
        private const string String1279 = "Vicious creatures surround you!";
        private const string String1299 = "'Kill the intruders!'";
        private const string String12AF = "A familiar traveler is here and is now dry.";
        private const string String12DB = "'Hello there! I see you've managed to get yourself saturated in these waters too!'";
        private const string String132E = "Large beasts turn to challenge you as you stumble into their lair.";
        private const string String1371 = "A wizard here ponders a message on the wall: 'How do you keep an adventurer busy???'";
        private const string String13C6 = "'See 2 east...hmmm.'";
        private const string String13DB = "'See 2 west...hmmm.'";
        private const string String13F0 = "'I don't understand! I was just here!!'";
        private const string String1418 = "'Strangely enough, so were you!!'";
        private const string String143A = "'Aha! Now I get it! Such a simple puzzle, it eluded me at first! Learn from this that all is not as challenging as you may think!'";
        private const string String14BD = "The wall message and the wizard have vanished.";
        private const string String14EC = "A familiar looking thief lifts some more of your gold!";
        private const string String1523 = "'Ahhh...this is quite generous! Thank you again for the offering!'";
        private const string String1566 = "The thief has wandered off to loot other parties.";
        private const string String1598 = "Corpses litter the floor here, stripped of all their belongings. Seeing their fallen friends, other rogues attack!";
        private const string String160B = "An 'X' is carved on the end of an ornate key that dangles on the rogue leader's neck.";
        private const string String1661 = "The switch you set to open the sluice gates has released the pressure locks on this door!";
        private const string String16BB = "The doors are sealed shut and no lock is visible. Further examination reveals a lever mechanism concealed in the walls.";
        private const string String1733 = "Perhaps there is a trigger somewhere that will unlock this door.";
        private const string String1774 = "There's a second way to the egress you are nearing. You need not seek it now; but return, and find the more profitable path later.";
        private const string String17F7 = "The door opens for those who have completed the sluice quest.";
        private const string String1835 = "Only those who solve the sluice and proceed alone may enter here.";
        private const string String1877 = "You must approach alone! You will know when you've found the way to unlock this door.";
        private const string String18CD = "The waterfall drags you out of the dungeon and dumps you into the sea.";
        private const string String1914 = "You stand at one end of the bridge.";
        private const string String1938 = "Invisible walls keep you from falling off the bridge into the freezing waters below.";
        private const string String198D = "You see the base of a watch tower to the south.";
        private const string String19BD = "A bridge spans the Aqueduct overhead.";
        private const string String19E3 = "You see the base of a watch tower to the north.";
        private const string String1A13 = "An honorable merchant offers you a taste of his drink in exchange for some gold.";
        private const string String1A64 = "As you sip the thick grog, you learn the petrify spell!!";
        private const string String1A9D = "'A trifle of gold for a sup of health? Tis a fair lot, m'good champion.' You feel your health and mana restored!";
        private const string String1B0E = "Gleaming rays of light pour from this fountain. You drink of its sweet waters and gain new powers.";
        private const string String1B71 = "The waters offer limited refreshment, but nothing more.";
        private const string String1BA9 = "Sour waters turn into sweet nectar as you learn how to resist the elements.";
        private const string String1BF5 = "Radiant waters enlighten you with a new spell!";
        private const string String1C24 = "A dry well is all that greets you here.";
        private const string String1C4C = "You managed to pick the lock!";
        private const string String1C6A = "A very stubborn lock impedes your progress here.";
        private const string String1C9B = "An illusionary door vanishes as you approach!";
        private const string String1CC9 =         
        // === Functions ================================================
        private void FnRIVER_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoHealZone(player);
            L000B: PushStack(player, 0x01);
            L000F: PushStack(player, 0x00);
001D  0012 C4 5E 06  les bx, [bp+0x6]
0020  0015 26 FF 5F 04  call far word [es:bx+0x4]
            L0019: cx = PopStack(player);
            L001A: cx = PopStack(player);
            L001B: RefreshCompareFlags(ax);
            L001D: if (JumpNotEqual) goto L0087;
            L001F: RefreshCompareFlags(GetFlag(player, 0x02, 0x0A));
            L0032: if (JumpNotEqual) goto L0069;
            L0034: ShowMessage(player, String03FC); // The rushing waters pummel your body.
            L0041: ax = GetMaxHits(player);
            L0048: bx = 0x0008;
            L004B: dx = ax % bx; ax = ax / bx;
0059  004E 40     inc ax
            L004F: DamagePlayer(player, ax);
            L0059: RefreshCompareFlags(GetCurrentHits(player));
            L0062: if (JumpAbove) goto L0076;
006F  0064 B8 21 04  mov ax, 0x421
            L0067: goto L006C;
            L0069: ShowMessage(player, String0445); // You've defeated Aqueus! You may travel safely through these waters now.
            L0076: PushStack(player, 0x01);
            L007A: PushStack(player, ax);
            L007B: PushStack(player, 0x00);
0089  007E C4 5E 06  les bx, [bp+0x6]
008C  0081 26 FF 1F  call far word [es:bx]
008F  0084 83 C4 06  add sp, 0x6
            L0087: return; // RETURN;
            // Extra data: 55 8B EC B8 01 00 50 50 33 C0 50 C4 5E 06 26 FF 1F 83 C4 06 5D CB 
        }

        private void FnPITPUMP_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String048D); // The magical force of the pump propels you southeastward and slams you squarely into a wall.
            L0010: ax = GetCurrentHits(player);
            L0017: bx = 0x0002;
            L001A: dx = ax % bx; ax = ax / bx;
            L001D: DamagePlayer(player, ax);
            L0027: PushStack(player, 0x02);
            L002B: PushStack(player, 0xAA);
            L002F: PushStack(player, 0x02);
            L0033: PushStack(player, ax);
00DE  0034 C4 5E 06  les bx, [bp+0x6]
00E1  0037 26 FF 9F BC 00  call far word [es:bx+0xbc]
00E6  003C 83 C4 08  add sp, 0x8
            L003F: return; // RETURN;
        }

        private void FnCOLUMN_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFloorPassable(player, 0x00, GetCurrentTile(player));
            L0017: return; // RETURN;
        }

        private void FnTOSOUTHE_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String04E9); // To the other shore...
            L0010: PushStack(player, 0x02);
            L0014: PushStack(player, 0xBD);
            L0018: PushStack(player, 0x02);
            L001C: PushStack(player, ax);
0121  001D C4 5E 06  les bx, [bp+0x6]
0124  0020 26 FF 9F BC 00  call far word [es:bx+0xbc]
0129  0025 83 C4 08  add sp, 0x8
            L0028: return; // RETURN;
        }

        private void FnTONORTHW_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String04FF); // Closer and closer you go.
            L0010: PushStack(player, 0x02);
            L0014: PushStack(player, 0x03);
            L0018: PushStack(player, 0x02);
            L001C: PushStack(player, ax);
014B  001D C4 5E 06  les bx, [bp+0x6]
014E  0020 26 FF 9F BC 00  call far word [es:bx+0xbc]
0153  0025 83 C4 08  add sp, 0x8
            L0028: return; // RETURN;
        }

        private void FnTOSOUTHW_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetCurrentTile(player), 0x0035);
            L000D: if (JumpNotEqual) goto L007E;
            L000F: RefreshCompareFlags(GetFlag(player, 0x02, 0x10));
            L0022: if (JumpEqual) goto L003A;
            L0024: Compare(GetFlag(player, 0x02, 0x10), 0x0001);
            L0038: if (JumpNotEqual) goto L007E;
            L003A: SetFlag(player, 0x02, 0x10, 0x02);
            L004F: AddExperience(player, 0x000007D0);
            L0060: ModifyGold(player, 0x04B0);
            L0071: ShowMessage(player, String0519); // Take this experience and these coins to aid thee in thy travels!
            L007E: ShowMessage(player, String055A); // And yet one step further along the path.
            L008B: PushStack(player, 0x02);
            L008F: PushStack(player, 0xE0);
            L0093: PushStack(player, 0x02);
            L0097: PushStack(player, ax);
01F0  0098 C4 5E 06  les bx, [bp+0x6]
01F3  009B 26 FF 9F BC 00  call far word [es:bx+0xbc]
01F8  00A0 83 C4 08  add sp, 0x8
            L00A3: return; // RETURN;
        }

        private void FnEGRESS_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0583); // Westward takes you back to the main Aqueduct.
            L0010: TeleportParty(player, 0x02, 0x01, 0xFF, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void FnCELLONE_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
022C  0003 FF 76 08  push word [bp+0x8]
022F  0006 FF 76 06  push word [bp+0x6]
0232  0009 0E     push cs
0233  000A E8 B3 FD  call 0xfdc0
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowPortrait(player, 0x001C);
            L001C: ShowMessage(player, String05B1); // A magical wall bars you from moving any closer to the prisoner in the southern cell.
            L0029: return; // RETURN;
        }

        private void FnCELLTWO_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0257  0003 FF 76 08  push word [bp+0x8]
025A  0006 FF 76 06  push word [bp+0x6]
025D  0009 0E     push cs
025E  000A E8 88 FD  call 0xfd95
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowPortrait(player, 0x0020);
            L001C: ShowMessage(player, String0606); // A mystical force prevents access southward to another prisoner in the Aqueduct's cells.
            L0029: return; // RETURN;
        }

        private void FnCELTHREE_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0282  0003 FF 76 08  push word [bp+0x8]
0285  0006 FF 76 06  push word [bp+0x6]
0288  0009 0E     push cs
0289  000A E8 5D FD  call 0xfd6a
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowPortrait(player, 0x0004);
            L001C: ShowMessage(player, String065E); // A hulking beast is imprisoned southward behind some unseen forces of magic.
            L0029: return; // RETURN;
        }

        private void FnBLOCKWAL_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
02AD  0003 FF 76 08  push word [bp+0x8]
02B0  0006 FF 76 06  push word [bp+0x6]
02B3  0009 0E     push cs
02B4  000A E8 32 FD  call 0xfd3f
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowMessage(player, String06AA); // An unseen force holds you back.
            L001C: return; // RETURN;
        }

        private void FnGUARDMES_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String06CA); // BEHOLD: This tower was built by Queen Aeowyn to control the force of the Aqueduct as it leaves this place. Hail her Royal Highness!
            L0010: return; // RETURN;
        }

        private void FnTOMAPA_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String074E); // This path leads back whence you came.
            L0010: TeleportParty(player, 0x02, 0x01, 0xAF, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void FnMESSA_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0774); // Do not forsake your loyal friends.
            L0010: ShowMessage(player, String0797); // WARNING: DO NOT READ THIS SIGN!
            L001D: return; // RETURN;
        }

        private void FnMESSB_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String07B7); // For true friendship can bridge time...
            L0010: ShowMessage(player, String07DE); // I'M TELLING YOU - STOP READING THIS!
            L001D: return; // RETURN;
        }

        private void FnMESSC_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0803); // Personal sacrifice will send your friends forward.
            L0010: ShowMessage(player, String0836); // I CAN'T BELIEVE YOU DON'T LISTEN TO ME!
            L001D: ShowMessage(player, String085E); // Obviously some vandalish rogues have been at these signs.
            L002A: return; // RETURN;
        }

        private void FnTOAMESS_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0898); // Well done!  Westward now and hurry. You're almost to the end of the Proving Grounds!
            L0010: RefreshCompareFlags(GetFlag(player, 0x02, 0x10));
            L0023: if (JumpNotEqual) goto L003A;
            L0025: SetFlag(player, 0x02, 0x10, 0x01);
            L003A: return; // RETURN;
        }

        private void FnEASTMESS_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x11), 0x0001);
            L0017: if (JumpEqual) goto L001C;
            L0019: goto L00CD;
            L001C: SetFloorPassable(player, 0x8E, 0x01);
            L002D: SetFloorPassable(player, 0x7E, 0x01);
            L003E: SetFloorPassable(player, 0x9E, 0x01);
            L004F: SetFloorObject(player, 0x01, 0x8E);
            L0060: SetFloorObject(player, 0x01, 0x7E);
            L0071: SetFloorObject(player, 0x01, 0x9E);
            L0082: ShowMessage(player, String08ED); // You stand midway between the two watch towers. The view really is quite magnificent.
            L008F: ShowMessage(player, String0942); // Invisible forces keep you from falling off the bridge into the icy waters below.
            L009C: SetWallPassable(player, GetCurrentTile(player), ax, 0x00);
            L00B2: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x00);
            L00CB: goto L00DA;
            L00CD: ShowMessage(player, String0993); // You stand directly below a narrow bridge that spans the Aqueduct. Eastward is a great waterfall that pours from the side of the volcano.
            L00DA: return; // RETURN;
        }

        private void FnBAZAAR_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0A1C); // This majestic meeting hall bustles with commerce.
            L0010: ShowMessage(player, String0A4E); // The walls reverberate with the din of haggling and betrayal.
            L001D: return; // RETURN;
        }

        private void FnCNTRMESS_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0A8B); // None of the merchants wishes to deal with you.
            L0010: ShowMessage(player, String0ABA); // Perhaps another time, when you have items worth their interest.
            L001D: return; // RETURN;
        }

        private void FnTWRDOOR_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0xF1);
            L0007: PushStack(player, ax);
04CE  0008 C4 5E 06  les bx, [bp+0x6]
04D1  000B 26 FF 5F 54  call far word [es:bx+0x54]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0060;
            L0015: ShowMessage(player, String0AFA); // The Cross Key easily unlocks the door.
            L0022: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0040: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L005E: goto L006D;
            L0060: ShowMessage(player, String0B21); // A strange keyhole, marked with an X, obviously suggests that a special key is needed to unlock this door.
            L006D: return; // RETURN;
        }

        private void FnQUEENGRD_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(player);
            L000B: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L001E: if (JumpNotEqual) goto L005F;
            L0020: ShowPortrait(player, 0x001C);
            L002D: ShowMessage(player, String0B8B); // One of the Queen's Guard is here.
            L003A: ShowMessage(player, String0BAD); // 'Away with you.  I have no time to waste with the likes of you.'
            L0047: SetFlag(player, 0x03, 0x01, 0x01);
            L005C: goto L00EA;
            L005F: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L0073: if (JumpNotEqual) goto L00A1;
            L0075: ShowPortrait(player, 0x001C);
            L0082: ShowMessage(player, String0BEE); // The guard is still here.
            L008F: ShowMessage(player, String0C07); // 'What now?  Stop bothering me or I shall be forced to remove you.'
05D1  009C B8 02 00  mov ax, 0x2
            L009F: goto L004A;
            L00A1: Compare(GetFlag(player, 0x03, 0x01), 0x0002);
            L00B5: if (JumpNotEqual) goto L00EA;
            L00B7: ShowMessage(player, String0C4A); // 'ENOUGH! Have at you!'
            L00C4: SetFlag(player, 0x03, 0x01, 0x00);
            L00D8: AddEncounter(player, 0x01, 0x1E);
            L00EA: return; // RETURN;
        }

        private void FnWATCHMAN_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002D);
            L0010: ShowMessage(player, String0C61); // You notice a variety of levers on the wall here.
            L001D: ShowMessage(player, String0C92); // 'Welcome to the tower! Don't play with the switches, please.  And please be careful on the bridge.'
            L002A: SetFlag(player, 0x02, 0x11, 0x01);
            L003F: SetFloorPassable(player, 0x8E, 0x01);
            L0050: SetFloorPassable(player, 0x7E, 0x01);
            L0061: SetFloorPassable(player, 0x9E, 0x01);
            L0072: SetFloorObject(player, 0x01, 0x8E);
            L0083: SetFloorObject(player, 0x01, 0x7E);
            L0094: SetFloorObject(player, 0x01, 0x9E);
            L00A5: return; // RETURN;
        }

        private void FnSWITCH_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x0F));
            L0016: if (JumpNotEqual) goto L0037;
            L0018: XCall Fn0067
            L0023: cx = PopStack(player);
            L0024: cx = PopStack(player);
            L0025: ShowMessage(player, String0CF6); // You hear the sounds of locking mechanisms being released by the opening of the sluice gates; as if some doors off to the west are now unlocked!
06FA  0032 B8 01 00  mov ax, 0x1
            L0035: goto L0053;
            L0037: XCall Fn0067
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: ShowMessage(player, String0D86); // The sluice gates have been closed, slowing the waters' flow. A low rumbling sound can be heard as though some mechanism has just been locked down again.
            L0051: SetFlag(player, 0x02, 0x0F, 0x00);
            L0065: return; // RETURN;
            // Extra data: 55 8B EC B8 1F 0E 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 
        }

        private void FnROGUEONE_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x09));
            L0016: if (JumpNotEqual) goto L0034;
0759  0018 B8 F4 01  mov ax, 0x1f4
            L001B: PushStack(player, ax);
            L001C: PushStack(player, 0x00);
            L001F: PushStack(player, ax);
            L0020: PushStack(player, ax);
            L0021: PushStack(player, 0x4E);
            L0025: PushStack(player, 0x41);
076A  0029 C4 5E 06  les bx, [bp+0x6]
076D  002C 26 FF 9F D8 00  call far word [es:bx+0xd8]
0772  0031 83 C4 0C  add sp, 0xc
            L0034: ShowMessage(player, String0EB5); // Rogues rush at you from the shadows.
            L0041: SetFlag(player, 0x03, 0x09, 0x01);
            L0056: Compare(PartyCount(player), 0x0001);
            L0061: if (JumpNotEqual) goto L006C;
            L0063: PushStack(player, 0x1C);
07A8  0067 B8 01 00  mov ax, 0x1
            L006A: goto L0085;
            L006C: AddEncounter(player, 0x01, 0x1C);
            L007E: AddEncounter(player, 0x02, 0x1C);
            L0090: AddEncounter(player, 0x05, 0x1D);
            L00A2: return; // RETURN;
        }

        private void FnROGUETWO_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L0016: if (JumpNotEqual) goto L0034;
07FD  0018 B8 E8 03  mov ax, 0x3e8
            L001B: PushStack(player, ax);
            L001C: PushStack(player, 0x00);
            L001F: PushStack(player, ax);
            L0020: PushStack(player, ax);
            L0021: PushStack(player, 0xB6);
            L0025: PushStack(player, 0x03);
080E  0029 C4 5E 06  les bx, [bp+0x6]
0811  002C 26 FF 9F D8 00  call far word [es:bx+0xd8]
0816  0031 83 C4 0C  add sp, 0xc
            L0034: ShowMessage(player, String0EDA); // Assassins!!
            L0041: SetFlag(player, 0x03, 0x0A, 0x01);
            L0056: ModifyGold(player, 0xFFFF18BA);
            L0068: ax = GetCurrentHits(player);
            L006F: bx = 0x0006;
            L0072: dx = ax % bx; ax = ax / bx;
            L0075: DamagePlayer(player, ax);
            L007F: Compare(PartyCount(player), 0x0001);
            L008A: if (JumpNotEqual) goto L00A7;
            L008C: AddEncounter(player, 0x01, 0x21);
            L009E: PushStack(player, 0x22);
0887  00A2 B8 05 00  mov ax, 0x5
            L00A5: goto L00E4;
            L00A7: AddEncounter(player, 0x01, 0x21);
            L00B9: AddEncounter(player, 0x02, 0x21);
            L00CB: AddEncounter(player, 0x05, 0x22);
            L00DD: AddEncounter(player, 0x06, 0x22);
            L00EF: return; // RETURN;
        }

        private void FnPRSNERA_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0EE6); // As you enter the prisoner's cell, he turns to make his escape by force.
            L0010: AddEncounter(player, 0x01, 0x1A);
            L0022: return; // RETURN;
        }

        private void FnPRSNERB_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001F);
            L0010: ShowMessage(player, String0F2E); // 'Fools! Fools! Do you think the waters always run! Mad, mad, mad, ahahahhahah!!'
            L001D: ShowMessage(player, String0F7F); // Obviously this prisoner is insane.
            L002A: return; // RETURN;
        }

        private void FnPRSNERC_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0FA2); // A tiny door is visible to the west. You should be able to make it through.
            L0010: ShowMessage(player, String0FED); // The Coelus here, however, is another story.
            L001D: AddEncounter(player, 0x01, 0x28);
            L002F: return; // RETURN;
        }

        private void FnLOSTNPCA_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0B));
            L0016: if (JumpNotEqual) goto L003F;
            L0018: SetFlag(player, 0x03, 0x0B, 0x01);
            L002D: ShowPortrait(player, 0x0027);
0991  003A B8 19 10  mov ax, 0x1019
            L003D: goto L0042;
            L003F: ShowMessage(player, String107E); // The Cleric has wandered off.
            L004C: return; // RETURN;
        }

        private void FnLOSTNPCB_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x79));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E0;
            L001B: Compare(GetFlag(player, 0x03, 0x0B), 0x0001);
            L002F: if (JumpEqual) goto L0034;
            L0031: goto L00B1;
            L0033: // NOP
            L0034: XCall Fn00E2
            L003F: cx = PopStack(player);
            L0040: cx = PopStack(player);
            L0041: ShowMessage(player, String109B); // You tell the Ranger where you recently saw a confused Cleric.
            L004E: ShowMessage(player, String10D9); // 'Excellent! I shall search there for him. My gratitude to you, good friend. Here, presents for your help.'
            L005B: ShowMessage(player, String1144); // He then marches off.
            L0068: ModifyGold(player, 0x0064);
            L0079: GiveItem(player, 0xB6);
            L0085: SetFlag(player, 0x03, 0x0B, 0x02);
            L009A: SetFlag(player, 0x02, 0x79, 0x01);
            L00AF: goto L00E0;
            L00B1: RefreshCompareFlags(GetFlag(player, 0x03, 0x0B));
            L00C4: if (JumpNotEqual) goto L00E0;
            L00C6: XCall Fn00E2
            L00D1: cx = PopStack(player);
            L00D2: cx = PopStack(player);
            L00D3: ShowMessage(player, String1159); // 'Well, never mind then.' The Ranger turns and walks away.
            L00E0: return; // RETURN;
            // Extra data: 55 8B EC B8 1F 00 50 C4 5E 06 26 FF 9F FC 00 59 B8 93 11 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 
        }

        private void FnSOAKINGA_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0022);
            L0010: ShowMessage(player, String11FA); // A sopping wet thief is here.
            L001D: ShowMessage(player, String1217); // 'I say, that blasted Aqueduct is frigid today. There must be a way to regulate the water's flow.'
            L002A: return; // RETURN;
        }

        private void FnROTATEME_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
            L0007: PushStack(player, 0x00);
0ADC  000A C4 5E 06  les bx, [bp+0x6]
0ADF  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L0055;
            L0017: bx = GetFacing(player);
            L0020: Compare(bx, 0x03);
            L0023: if (JumpAbove) goto L0044;
            L0025: switch (bx) {
                case 0:
                    goto L0057;
                case 1:
                    goto L0050;
                case 2:
                    goto L0052;
                case 3:
                    goto L004C;
            }
0AFE  002C 33 C0  xor ax, ax
            L002E: goto L003A;
            L0030: goto L002C;
0B04  0032 B8 01 00  mov ax, 0x1
            L0035: goto L003A;
            L0037: PushStack(player, 0x02);
0B0D  003B C4 5E 06  les bx, [bp+0x6]
0B10  003E 26 FF 9F CC 00  call far word [es:bx+0xcc]
            L0043: cx = PopStack(player);
            L0044: PushStack(player, 0x01);
            L0048: PushStack(player, ax);
            L0049: PushStack(player, 0x00);
0B1E  004C C4 5E 06  les bx, [bp+0x6]
0B21  004F 26 FF 1F  call far word [es:bx]
0B24  0052 83 C4 06  add sp, 0x6
            L0055: return; // RETURN;
        }

        private void FnTOUGHBAT_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String1279); // Vicious creatures surround you!
            L0011: Compare(PartyCount(player), 0x0001);
            L001C: if (JumpNotEqual) goto L003A;
            L001E: AddEncounter(player, 0x01, 0x27);
            L0030: PushStack(player, 0x28);
0B65  0034 B8 05 00  mov ax, 0x5
            L0037: goto L0118;
            L003A: Compare(PartyCount(player), 0x0002);
            L0045: if (JumpNotEqual) goto L0062;
            L0047: AddEncounter(player, 0x01, 0x26);
            L0059: PushStack(player, 0x27);
0B8E  005D B8 02 00  mov ax, 0x2
            L0060: goto L0025;
            L0062: Compare(PartyCount(player), 0x0003);
            L006D: if (JumpNotEqual) goto L00B7;
            L006F: AddEncounter(player, 0x01, 0x26);
            L0081: si = 0x0002;
            L0084: goto L0096;
            L0086: AddEncounter(player, si, 0x27);
            L0095: si = si + 1;
            L0096: Compare(si, 0x03);
            L0099: if (JumpLessOrEqual) goto L0086;
            L009B: si = 0x0004;
            L009E: goto L00B0;
            L00A0: AddEncounter(player, si, 0x28);
            L00AF: si = si + 1;
            L00B0: Compare(si, 0x06);
            L00B3: if (JumpLessOrEqual) goto L00A0;
            L00B5: goto L0123;
            L00B7: AddEncounter(player, 0x01, 0x26);
            L00C9: AddEncounter(player, 0x02, 0x26);
            L00DB: AddEncounter(player, 0x03, 0x27);
            L00ED: AddEncounter(player, 0x04, 0x27);
            L00FF: AddEncounter(player, 0x05, 0x28);
            L0111: AddEncounter(player, 0x06, 0x28);
            L0123: return; // RETURN (restoring si);
        }

        private void FnNPCINFO_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x08));
            L0016: if (JumpNotEqual) goto L0034;
0C6F  0018 B8 58 02  mov ax, 0x258
            L001B: PushStack(player, ax);
            L001C: PushStack(player, 0x00);
            L001F: PushStack(player, ax);
            L0020: PushStack(player, ax);
            L0021: PushStack(player, 0xB6);
            L0025: PushStack(player, 0x08);
0C80  0029 C4 5E 06  les bx, [bp+0x6]
0C83  002C 26 FF 9F D8 00  call far word [es:bx+0xd8]
0C88  0031 83 C4 0C  add sp, 0xc
            L0034: ShowMessage(player, String1299); // 'Kill the intruders!'
            L0041: Compare(PartyCount(player), 0x0001);
            L004C: if (JumpNotEqual) goto L006A;
            L004E: AddEncounter(player, 0x01, 0x1F);
            L0060: PushStack(player, 0x20);
0CBB  0064 B8 05 00  mov ax, 0x5
            L0067: goto L014E;
            L006A: Compare(PartyCount(player), 0x0002);
            L0075: if (JumpNotEqual) goto L00A5;
            L0077: AddEncounter(player, 0x01, 0x1F);
            L0089: AddEncounter(player, 0x02, 0x1F);
            L009B: PushStack(player, 0x20);
0CF6  009F B8 05 00  mov ax, 0x5
            L00A2: goto L014E;
            L00A5: Compare(PartyCount(player), 0x0003);
            L00B0: if (JumpNotEqual) goto L00ED;
            L00B2: AddEncounter(player, 0x01, 0x1F);
            L00C4: AddEncounter(player, 0x02, 0x20);
            L00D6: AddEncounter(player, 0x03, 0x20);
0D3F  00E8 B8 1F 00  mov ax, 0x1f
            L00EB: goto L0138;
            L00ED: AddEncounter(player, 0x01, 0x1F);
            L00FF: AddEncounter(player, 0x02, 0x1F);
            L0111: AddEncounter(player, 0x03, 0x20);
            L0123: AddEncounter(player, 0x04, 0x20);
            L0135: AddEncounter(player, 0x05, 0x20);
            L0147: AddEncounter(player, 0x06, 0x1F);
            L0159: return; // RETURN;
        }

        private void FnNPCDRY_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0022);
            L0010: ShowMessage(player, String12AF); // A familiar traveler is here and is now dry.
            L001D: ShowMessage(player, String12DB); // 'Hello there! I see you've managed to get yourself saturated in these waters too!'
            L002A: return; // RETURN;
        }

        private void FnGOODBOOT_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0016: if (JumpNotEqual) goto L0037;
0DF6  0018 B8 E8 03  mov ax, 0x3e8
            L001B: PushStack(player, ax);
            L001C: PushStack(player, 0x00);
            L001F: PushStack(player, ax);
            L0020: PushStack(player, 0x8A);
            L0024: PushStack(player, 0x4E);
            L0028: PushStack(player, 0x2C);
0E0A  002C C4 5E 06  les bx, [bp+0x6]
0E0D  002F 26 FF 9F D8 00  call far word [es:bx+0xd8]
0E12  0034 83 C4 0C  add sp, 0xc
            L0037: ShowMessage(player, String132E); // Large beasts turn to challenge you as you stumble into their lair.
            L0044: SetFlag(player, 0x03, 0x07, 0x01);
            L0059: Compare(PartyCount(player), 0x0001);
            L0064: if (JumpNotEqual) goto L0082;
            L0066: AddEncounter(player, 0x01, 0x27);
            L0078: PushStack(player, 0x28);
0E5A  007C B8 05 00  mov ax, 0x5
            L007F: goto L0158;
            L0082: Compare(PartyCount(player), 0x0002);
            L008D: if (JumpNotEqual) goto L00BD;
            L008F: AddEncounter(player, 0x01, 0x26);
            L00A1: AddEncounter(player, 0x02, 0x27);
            L00B3: PushStack(player, 0x28);
0E95  00B7 B8 05 00  mov ax, 0x5
            L00BA: goto L0158;
            L00BD: Compare(PartyCount(player), 0x0003);
            L00C8: if (JumpNotEqual) goto L00F7;
            L00CA: AddEncounter(player, 0x01, 0x26);
            L00DC: AddEncounter(player, 0x02, 0x27);
            L00EE: PushStack(player, 0x27);
0ED0  00F2 B8 03 00  mov ax, 0x3
            L00F5: goto L0134;
            L00F7: AddEncounter(player, 0x01, 0x26);
            L0109: AddEncounter(player, 0x02, 0x27);
            L011B: AddEncounter(player, 0x03, 0x28);
            L012D: AddEncounter(player, 0x04, 0x28);
            L013F: AddEncounter(player, 0x05, 0x28);
            L0151: AddEncounter(player, 0x06, 0x28);
            L0163: return; // RETURN;
        }

        private void FnINFOONE_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: Compare(GetCurrentTile(player), 0x00C7);
            L000F: if (JumpEqual) goto L0018;
            L0011: Compare(ax, 0x00C9);
            L0014: if (JumpEqual) goto L0020;
            L0016: goto L0026;
            L0018: si = 0x0003;
            L001B: di = 0x0004;
            L001E: goto L0026;
            L0020: si = 0x0004;
            L0023: di = 0x0003;
0F69  0026 56     push si
            L0027: PushStack(player, 0x03);
0F6E  002B C4 5E 06  les bx, [bp+0x6]
0F71  002E 26 FF 5F 04  call far word [es:bx+0x4]
            L0032: cx = PopStack(player);
            L0033: cx = PopStack(player);
            L0034: RefreshCompareFlags(ax);
            L0036: if (JumpEqual) goto L004A;
0F7B  0038 57     push di
            L0039: PushStack(player, 0x03);
0F80  003D C4 5E 06  les bx, [bp+0x6]
0F83  0040 26 FF 5F 04  call far word [es:bx+0x4]
            L0044: cx = PopStack(player);
            L0045: cx = PopStack(player);
            L0046: RefreshCompareFlags(ax);
            L0048: if (JumpNotEqual) goto L0097;
            L004A: XCall Fn019B
            L0055: cx = PopStack(player);
            L0056: cx = PopStack(player);
            L0057: ShowMessage(player, String1371); // A wizard here ponders a message on the wall: 'How do you keep an adventurer busy???'
            L0064: Compare(GetCurrentTile(player), 0x00C7);
            L006E: if (JumpNotEqual) goto L0075;
0FB3  0070 B8 C6 13  mov ax, 0x13c6
            L0073: goto L0078;
            L0075: ShowMessage(player, String13DB); // 'See 2 west...hmmm.'
            L0082: PushStack(player, 0x01);
0FC9  0086 57     push di
            L0087: PushStack(player, 0x03);
0FCE  008B C4 5E 06  les bx, [bp+0x6]
0FD1  008E 26 FF 1F  call far word [es:bx]
0FD4  0091 83 C4 06  add sp, 0x6
            L0094: goto L0197;
0FDA  0097 56     push si
            L0098: PushStack(player, 0x03);
0FDF  009C C4 5E 06  les bx, [bp+0x6]
0FE2  009F 26 FF 5F 04  call far word [es:bx+0x4]
            L00A3: cx = PopStack(player);
            L00A4: cx = PopStack(player);
            L00A5: Compare(ax, 0x0001);
            L00A8: if (JumpNotEqual) goto L00EA;
            L00AA: XCall Fn019B
            L00B5: cx = PopStack(player);
            L00B6: cx = PopStack(player);
            L00B7: ShowMessage(player, String13F0); // 'I don't understand! I was just here!!'
            L00C4: ShowMessage(player, String1418); // 'Strangely enough, so were you!!'
            L00D1: PushStack(player, 0x02);
1018  00D5 57     push di
            L00D6: PushStack(player, 0x03);
101D  00DA C4 5E 06  les bx, [bp+0x6]
1020  00DD 26 FF 1F  call far word [es:bx]
1023  00E0 83 C4 06  add sp, 0x6
            L00E3: PushStack(player, 0x03);
102A  00E7 56     push si
            L00E8: goto L0087;
102D  00EA 56     push si
            L00EB: PushStack(player, 0x03);
1032  00EF C4 5E 06  les bx, [bp+0x6]
1035  00F2 26 FF 5F 04  call far word [es:bx+0x4]
            L00F6: cx = PopStack(player);
            L00F7: cx = PopStack(player);
            L00F8: Compare(ax, 0x0002);
            L00FB: if (JumpNotEqual) goto L0164;
            L00FD: PushStack(player, 0x03);
1044  0101 56     push si
            L0102: PushStack(player, ax);
1046  0103 C4 5E 06  les bx, [bp+0x6]
1049  0106 26 FF 1F  call far word [es:bx]
104C  0109 83 C4 06  add sp, 0x6
            L010C: Compare(GetFlag(player, 0x02, 0x2F), 0x0001);
            L0120: if (JumpNotEqual) goto L0124;
            L0122: goto L018A;
            L0124: XCall Fn019B
            L012F: cx = PopStack(player);
            L0130: cx = PopStack(player);
            L0131: ShowMessage(player, String143A); // 'Aha! Now I get it! Such a simple puzzle, it eluded me at first! Learn from this that all is not as challenging as you may think!'
            L013E: SetFlag(player, 0x02, 0x2F, 0x01);
1096  0153 33 C0  xor ax, ax
1098  0155 BA EE 02  mov dx, 0x2ee
            L0158: PushStack(player, ax);
            L0159: PushStack(player, dx);
109D  015A C4 5E 06  les bx, [bp+0x6]
10A0  015D 26 FF 9F 98 00  call far word [es:bx+0x98]
            L0162: goto L0195;
10A7  0164 56     push si
            L0165: PushStack(player, 0x03);
10AC  0169 C4 5E 06  les bx, [bp+0x6]
10AF  016C 26 FF 5F 04  call far word [es:bx+0x4]
            L0170: cx = PopStack(player);
            L0171: cx = PopStack(player);
            L0172: Compare(ax, 0x0003);
            L0175: if (JumpEqual) goto L018A;
10BA  0177 57     push di
            L0178: PushStack(player, 0x03);
10BF  017C C4 5E 06  les bx, [bp+0x6]
10C2  017F 26 FF 5F 04  call far word [es:bx+0x4]
            L0183: cx = PopStack(player);
            L0184: cx = PopStack(player);
            L0185: Compare(ax, 0x0003);
            L0188: if (JumpNotEqual) goto L0197;
            L018A: XCall Fn01AD
            L0195: cx = PopStack(player);
            L0196: cx = PopStack(player);
            L0197: return; // RETURN (restoring si, di);
            // Extra data: 55 8B EC B8 2C 00 50 C4 5E 06 26 FF 9F FC 00 59 5D CB 55 8B EC B8 BD 14 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 
        }

        private void FnSTEALONE_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpNotEqual) goto L0068;
            L0018: ShowPortrait(player, 0x0025);
            L0025: ShowMessage(player, String14EC); // A familiar looking thief lifts some more of your gold!
            L0032: ShowMessage(player, String1523); // 'Ahhh...this is quite generous! Thank you again for the offering!'
            L003F: ModifyGold(player, 0xFFFF0CBA);
            L0051: SetFlag(player, 0x03, 0x02, 0x01);
            L0066: goto L0075;
            L0068: ShowMessage(player, String1566); // The thief has wandered off to loot other parties.
            L0075: return; // RETURN;
        }

        private void FnBIGBATL_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF1);
            L0011: if (JumpEqual) goto L0022;
            L0013: ShowMessage(player, String1598); // Corpses litter the floor here, stripped of all their belongings. Seeing their fallen friends, other rogues attack!
            L0020: goto L0048;
            L0022: ShowMessage(player, String160B); // An 'X' is carved on the end of an ornate key that dangles on the rogue leader's neck.
            L002F: PushStack(player, 0x96);
            L0033: PushStack(player, 0x00);
            L0036: PushStack(player, ax);
            L0037: PushStack(player, ax);
            L0038: PushStack(player, ax);
            L0039: PushStack(player, 0xF1);
11BB  003D C4 5E 06  les bx, [bp+0x6]
11BE  0040 26 FF 9F D8 00  call far word [es:bx+0xd8]
11C3  0045 83 C4 0C  add sp, 0xc
            L0048: Compare(PartyCount(player), 0x0001);
            L0053: if (JumpNotEqual) goto L0071;
            L0055: AddEncounter(player, 0x01, 0x24);
            L0067: PushStack(player, 0x25);
11E9  006B B8 05 00  mov ax, 0x5
            L006E: goto L0159;
            L0071: Compare(PartyCount(player), 0x0002);
            L007C: if (JumpNotEqual) goto L00AC;
            L007E: AddEncounter(player, 0x01, 0x24);
            L0090: AddEncounter(player, 0x02, 0x23);
            L00A2: PushStack(player, 0x25);
1224  00A6 B8 05 00  mov ax, 0x5
            L00A9: goto L0159;
            L00AC: Compare(PartyCount(player), 0x0003);
            L00B7: if (JumpNotEqual) goto L00F8;
            L00B9: AddEncounter(player, 0x01, 0x24);
            L00CB: AddEncounter(player, 0x02, 0x24);
            L00DD: AddEncounter(player, 0x03, 0x23);
            L00EF: PushStack(player, 0x23);
1271  00F3 B8 04 00  mov ax, 0x4
            L00F6: goto L0147;
            L00F8: AddEncounter(player, 0x01, 0x23);
            L010A: AddEncounter(player, 0x02, 0x23);
            L011C: AddEncounter(player, 0x03, 0x24);
            L012E: AddEncounter(player, 0x04, 0x24);
            L0140: AddEncounter(player, 0x05, 0x23);
            L0152: AddEncounter(player, 0x06, 0x25);
            L0164: return; // RETURN;
        }

        private void FnDUCTSWIT_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x0F), 0x0001);
            L0017: if (JumpNotEqual) goto L0064;
            L0019: ShowMessage(player, String1661); // The switch you set to open the sluice gates has released the pressure locks on this door!
            L0026: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0044: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0062: goto L007E;
            L0064: ShowMessage(player, String16BB); // The doors are sealed shut and no lock is visible. Further examination reveals a lever mechanism concealed in the walls.
            L0071: ShowMessage(player, String1733); // Perhaps there is a trigger somewhere that will unlock this door.
            L007E: return; // RETURN;
        }

        private void FnDIDPATH_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpEqual) goto L0013;
            L0010: goto L00E9;
            L0013: Compare(GetFlag(player, 0x02, 0x10), 0x0001);
            L0027: if (JumpEqual) goto L0054;
            L0029: Compare(GetFlag(player, 0x02, 0x10), 0x0002);
            L003D: if (JumpEqual) goto L0054;
            L003F: ax = IsFlagOn(player, 0x02, 0x0F);
            L0052: if (JumpEqual) goto L00CE;
            L0054: ax = IsFlagOn(player, 0x02, 0x0F);
            L0067: if (JumpEqual) goto L0083;
            L0069: RefreshCompareFlags(GetFlag(player, 0x02, 0x10));
            L007C: if (JumpNotEqual) goto L0083;
13E2  007E B8 74 17  mov ax, 0x1774
            L0081: goto L0086;
            L0083: ShowMessage(player, String17F7); // The door opens for those who have completed the sluice quest.
            L0090: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00AE: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00CC: goto L0102;
            L00CE: ShowMessage(player, String1835); // Only those who solve the sluice and proceed alone may enter here.
143F  00DB FF 76 08  push word [bp+0x8]
1442  00DE FF 76 06  push word [bp+0x6]
1445  00E1 0E     push cs
1446  00E2 E8 A0 EB  call 0xec85
            L00E5: cx = PopStack(player);
            L00E6: cx = PopStack(player);
            L00E7: goto L0102;
144D  00E9 FF 76 08  push word [bp+0x8]
1450  00EC FF 76 06  push word [bp+0x6]
1453  00EF 0E     push cs
1454  00F0 E8 92 EB  call 0xec85
            L00F3: cx = PopStack(player);
            L00F4: cx = PopStack(player);
            L00F5: ShowMessage(player, String1877); // You must approach alone! You will know when you've found the way to unlock this door.
            L0102: return; // RETURN;
        }

        private void FnWATRFALL_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String18CD); // The waterfall drags you out of the dungeon and dumps you into the sea.
            L0010: ExitDungeon(player, isForwardMove);
            L0018: return; // RETURN;
        }

        private void FnBRIDGSPC_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x11), 0x0001);
            L0017: if (JumpEqual) goto L001C;
            L0019: goto L0120;
            L001C: SetWallVisibile(player, 0x7E, 0x03, 0x01);
            L0032: SetWallPassable(player, 0x7E, 0x03, 0x01);
            L0048: PushStack(player, 0x01);
            L004C: PushStack(player, ax);
            L004D: PushStack(player, 0x9E);
14D3  0051 C4 5E 06  les bx, [bp+0x6]
14D6  0054 26 FF 5F 28  call far word [es:bx+0x28]
14DA  0058 83 C4 06  add sp, 0x6
            L005B: SetWallPassable(player, 0x9E, ax, 0x01);
            L006E: SetFloorPassable(player, 0x8E, 0x01);
            L007F: SetFloorPassable(player, 0x7E, 0x01);
            L0090: SetFloorPassable(player, 0x9E, 0x01);
            L00A1: SetFloorObject(player, 0x01, 0x8E);
            L00B2: SetFloorObject(player, 0x01, 0x7E);
            L00C3: SetFloorObject(player, 0x01, 0x9E);
            L00D4: ShowMessage(player, String1914); // You stand at one end of the bridge.
            L00E1: ShowMessage(player, String1938); // Invisible walls keep you from falling off the bridge into the freezing waters below.
            L00EE: SetWallPassable(player, GetCurrentTile(player), ax, 0x00);
            L0104: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x00);
            L011D: goto L01C1;
            L0120: ShowMessage(player, String198D); // You see the base of a watch tower to the south.
            L012D: ShowMessage(player, String19BD); // A bridge spans the Aqueduct overhead.
            L013A: SetWallPassable(player, GetCurrentTile(player), 0x01, 0x00);
            L0153: PushStack(player, 0x00);
            L0156: PushStack(player, 0x01);
            L015A: PushStack(player, 0x9E);
15E0  015E C4 5E 06  les bx, [bp+0x6]
15E3  0161 26 FF 5F 28  call far word [es:bx+0x28]
15E7  0165 83 C4 06  add sp, 0x6
            L0168: PushStack(player, 0x00);
            L016B: PushStack(player, 0x03);
            L016F: PushStack(player, 0x7E);
15F5  0173 C4 5E 06  les bx, [bp+0x6]
15F8  0176 26 FF 5F 28  call far word [es:bx+0x28]
15FC  017A 83 C4 06  add sp, 0x6
            L017D: PushStack(player, 0x01);
            L0181: PushStack(player, 0x00);
1606  0184 C4 5E 06  les bx, [bp+0x6]
1609  0187 26 FF 5F 04  call far word [es:bx+0x4]
            L018B: cx = PopStack(player);
            L018C: cx = PopStack(player);
            L018D: RefreshCompareFlags(ax);
            L018F: if (JumpNotEqual) goto L01C1;
            L0191: ShowMessage(player, String03FC); // The rushing waters pummel your body.
            L019E: ax = GetMaxHits(player);
            L01A5: bx = 0x0004;
            L01A8: dx = ax % bx; ax = ax / bx;
            L01AB: DamagePlayer(player, ax);
1637  01B5 FF 76 08  push word [bp+0x8]
163A  01B8 FF 76 06  push word [bp+0x6]
163D  01BB 0E     push cs
163E  01BC E8 53 EA  call 0xec12
            L01BF: cx = PopStack(player);
            L01C0: cx = PopStack(player);
            L01C1: return; // RETURN;
        }

        private void FnBRIDGB_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x11), 0x0001);
            L0017: if (JumpEqual) goto L001C;
            L0019: goto L0120;
            L001C: PushStack(player, 0x01);
            L0020: PushStack(player, ax);
            L0021: PushStack(player, 0x9E);
166A  0025 C4 5E 06  les bx, [bp+0x6]
166D  0028 26 FF 5F 28  call far word [es:bx+0x28]
1671  002C 83 C4 06  add sp, 0x6
            L002F: SetWallPassable(player, 0x9E, ax, 0x01);
            L0042: SetWallVisibile(player, 0x7E, 0x03, 0x01);
            L0058: SetWallPassable(player, 0x7E, 0x03, 0x01);
            L006E: SetFloorPassable(player, 0x8E, 0x01);
            L007F: SetFloorPassable(player, 0x7E, 0x01);
            L0090: SetFloorPassable(player, 0x9E, 0x01);
            L00A1: SetFloorObject(player, 0x01, 0x8E);
            L00B2: SetFloorObject(player, 0x01, 0x7E);
            L00C3: SetFloorObject(player, 0x01, 0x9E);
            L00D4: ShowMessage(player, String1914); // You stand at one end of the bridge.
            L00E1: ShowMessage(player, String1938); // Invisible walls keep you from falling off the bridge into the freezing waters below.
            L00EE: SetWallPassable(player, GetCurrentTile(player), ax, 0x00);
            L0104: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x00);
            L011D: goto L01D2;
            L0120: ShowMessage(player, String19E3); // You see the base of a watch tower to the north.
            L012D: ShowMessage(player, String19BD); // A bridge spans the Aqueduct overhead.
            L013A: PushStack(player, 0x00);
            L013D: PushStack(player, 0x01);
            L0141: PushStack(player, 0x9E);
178A  0145 C4 5E 06  les bx, [bp+0x6]
178D  0148 26 FF 5F 28  call far word [es:bx+0x28]
1791  014C 83 C4 06  add sp, 0x6
            L014F: PushStack(player, 0x00);
            L0152: PushStack(player, 0x03);
            L0156: PushStack(player, 0x7E);
179F  015A C4 5E 06  les bx, [bp+0x6]
17A2  015D 26 FF 5F 28  call far word [es:bx+0x28]
17A6  0161 83 C4 06  add sp, 0x6
            L0164: SetWallPassable(player, 0x7E, 0x03, 0x00);
            L0179: SetWallPassable(player, 0x9E, 0x01, 0x00);
            L018E: PushStack(player, 0x01);
            L0192: PushStack(player, 0x00);
17DA  0195 C4 5E 06  les bx, [bp+0x6]
17DD  0198 26 FF 5F 04  call far word [es:bx+0x4]
            L019C: cx = PopStack(player);
            L019D: cx = PopStack(player);
            L019E: RefreshCompareFlags(ax);
            L01A0: if (JumpNotEqual) goto L01D2;
            L01A2: ShowMessage(player, String03FC); // The rushing waters pummel your body.
            L01AF: ax = GetMaxHits(player);
            L01B6: bx = 0x0004;
            L01B9: dx = ax % bx; ax = ax / bx;
            L01BC: DamagePlayer(player, ax);
180B  01C6 FF 76 08  push word [bp+0x8]
180E  01C9 FF 76 06  push word [bp+0x6]
1811  01CC 0E     push cs
1812  01CD E8 7F E8  call 0xea4f
            L01D0: cx = PopStack(player);
            L01D1: cx = PopStack(player);
            L01D2: return; // RETURN;
        }

        private void FnSETBRIDG_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x11, 0x00);
            L0017: return; // RETURN;
        }

        private void FnSETUPTWR_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoHealZone(player);
            L000B: PushStack(player, 0x00);
            L000E: PushStack(player, 0x01);
            L0012: PushStack(player, 0x9E);
1848  0016 C4 5E 06  les bx, [bp+0x6]
184B  0019 26 FF 5F 28  call far word [es:bx+0x28]
184F  001D 83 C4 06  add sp, 0x6
            L0020: PushStack(player, 0x00);
            L0023: PushStack(player, 0x03);
            L0027: PushStack(player, 0x7E);
185D  002B C4 5E 06  les bx, [bp+0x6]
1860  002E 26 FF 5F 28  call far word [es:bx+0x28]
1864  0032 83 C4 06  add sp, 0x6
            L0035: SetWallPassable(player, 0x7E, 0x03, 0x00);
            L004A: SetWallPassable(player, 0x9E, 0x01, 0x00);
            L005F: PushStack(player, 0x01);
            L0063: PushStack(player, 0x00);
1898  0066 C4 5E 06  les bx, [bp+0x6]
189B  0069 26 FF 5F 04  call far word [es:bx+0x4]
            L006D: cx = PopStack(player);
            L006E: cx = PopStack(player);
            L006F: RefreshCompareFlags(ax);
            L0071: if (JumpNotEqual) goto L00A3;
            L0073: ShowMessage(player, String03FC); // The rushing waters pummel your body.
            L0080: ax = GetMaxHits(player);
            L0087: bx = 0x0004;
            L008A: dx = ax % bx; ax = ax / bx;
            L008D: DamagePlayer(player, ax);
18C9  0097 FF 76 08  push word [bp+0x8]
18CC  009A FF 76 06  push word [bp+0x6]
18CF  009D 0E     push cs
18D0  009E E8 C1 E7  call 0xe862
            L00A1: cx = PopStack(player);
            L00A2: cx = PopStack(player);
            L00A3: return; // RETURN;
        }

        private void FnTHFWIZ_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x83));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0097;
            L001A: // NOP
            L001B: Compare(GetGuild(player), 0x0003);
            L0025: if (JumpEqual) goto L0036;
            L0027: Compare(GetGuild(player), 0x0005);
            L0031: if (JumpEqual) goto L0036;
            L0033: goto L00F5;
            L0036: SetSpellLevel(player, 0x09, 0x01);
            L0047: ShowPortrait(player, 0x002D);
            L0054: ModifyGold(player, 0xFFFF18BA);
            L0066: ShowMessage(player, String1A13); // An honorable merchant offers you a taste of his drink in exchange for some gold.
            L0073: ShowMessage(player, String1A64); // As you sip the thick grog, you learn the petrify spell!!
            L0080: SetFlag(player, 0x02, 0x83, 0x01);
            L0095: goto L00F5;
            L0097: PushStack(player, GetCurrentHits(player));
            L009F: ax = GetMaxHits(player);
            L00A6: dx = PopStack(player);
197E  00A7 3B D0  cmp dx, ax
            L00A9: if (JumpNotBelow) goto L00F5;
            L00AB: ShowPortrait(player, 0x002D);
            L00B8: ShowMessage(player, String1A9D); // 'A trifle of gold for a sup of health? Tis a fair lot, m'good champion.' You feel your health and mana restored!
            L00C5: ModifyGold(player, 0xFFFF9CBA);
            L00D7: AddMana(player, 0x07D0);
            L00E4: HealPlayer(player, GetMaxHits(player));
            L00F5: return; // RETURN;
        }

        private void FnBARBRANG_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: RefreshCompareFlags(GetFlag(player, 0x02, 0x84));
            L0017: if (JumpEqual) goto L001C;
            L0019: goto L00CC;
            L001C: Compare(GetGuild(player), 0x0004);
            L0026: if (JumpEqual) goto L0040;
            L0028: Compare(GetGuild(player), 0x0005);
            L0032: if (JumpEqual) goto L0040;
            L0034: Compare(GetGuild(player), 0x0002);
            L003E: if (JumpNotEqual) goto L00B5;
            L0040: Compare(GetGuild(player), 0x0002);
            L004A: if (JumpEqual) goto L0062;
            L004C: Compare(ax, 0x0004);
            L004F: if (JumpEqual) goto L0058;
            L0051: Compare(ax, 0x0005);
            L0054: if (JumpEqual) goto L005D;
            L0056: goto L0076;
            L0058: si = 0x000C;
            L005B: goto L0076;
            L005D: si = 0x0010;
            L0060: goto L0076;
            L0062: si = 0x0014;
            L0065: SetSpellLevel(player, 0x15, 0x01);
            L0076: PushStack(player, 0x01);
1A48  007A 56     push si
1A49  007B C4 5E 06  les bx, [bp+0x6]
1A4C  007E 26 FF 5F 68  call far word [es:bx+0x68]
            L0082: cx = PopStack(player);
            L0083: cx = PopStack(player);
            L0084: ShowPortrait(player, 0x0042);
            L0091: ShowMessage(player, String1B0E); // Gleaming rays of light pour from this fountain. You drink of its sweet waters and gain new powers.
            L009E: SetFlag(player, 0x02, 0x84, 0x01);
            L00B3: goto L00D9;
            L00B5: SetFlag(player, 0x02, 0x84, 0x01);
            L00CA: goto L00CC;
            L00CC: XCall Fn00DC
            L00D7: cx = PopStack(player);
            L00D8: cx = PopStack(player);
            L00D9: return; // RETURN (restoring si);
            // Extra data: 55 8B EC B8 42 00 50 C4 5E 06 26 FF 9F FC 00 59 B8 71 1B 50 C4 5E 06 26 FF 9F F8 00 59 C4 5E 06 26 FF 5F 74 BB 04 00 99 F7 FB 50 C4 5E 06 26 FF 9F 94 00 59 5D CB 
        }

        private void FnRESIST_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x85));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00AE;
            L001B: Compare(GetGuild(player), 0x0004);
            L0025: if (JumpEqual) goto L0033;
            L0027: Compare(GetGuild(player), 0x0005);
            L0031: if (JumpNotEqual) goto L0075;
            L0033: SetSpellLevel(player, 0x15, 0x01);
            L0044: ShowPortrait(player, 0x0042);
            L0051: ShowMessage(player, String1BA9); // Sour waters turn into sweet nectar as you learn how to resist the elements.
            L005E: SetFlag(player, 0x02, 0x85, 0x01);
            L0073: goto L00C8;
            L0075: Compare(GetGuild(player), 0x0002);
            L007F: if (JumpNotEqual) goto L00C8;
            L0081: ShowPortrait(player, 0x0042);
            L008E: ShowMessage(player, String1BF5); // Radiant waters enlighten you with a new spell!
            L009B: SetSpellLevel(player, 0x0C, 0x01);
            L00AC: goto L005E;
            L00AE: ShowPortrait(player, 0x0042);
            L00BB: ShowMessage(player, String1C24); // A dry well is all that greets you here.
            L00C8: return; // RETURN;
        }

        private void FnPICKTHIS_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0E), 0x0006);
            L0012: if (JumpNotBelow) goto L003B;
            L0014: PushStack(player, 0x6F);
            L0018: PushStack(player, ax);
1BC3  0019 C4 5E 06  les bx, [bp+0x6]
1BC6  001C 26 FF 5F 54  call far word [es:bx+0x54]
            L0020: cx = PopStack(player);
            L0021: cx = PopStack(player);
            L0022: RefreshCompareFlags(ax);
            L0024: if (JumpNotEqual) goto L003B;
            L0026: ax = HasUsedItem(player, 0xBE, 0xC0);
            L0039: if (JumpEqual) goto L004D;
            L003B: ShowMessage(player, String1C4C); // You managed to pick the lock!
1BF2  0048 B8 01 00  mov ax, 0x1
            L004B: goto L005C;
            L004D: ShowMessage(player, String1C6A); // A very stubborn lock impedes your progress here.
            L005A: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0077: return; // RETURN;
        }

        private void FnILLUSION_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallObject(player, 0x00, GetCurrentTile(player), GetFacing(player));
            L0020: ShowMessage(player, String1C9B); // An illusionary door vanishes as you approach!
            L002D: return; // RETURN;
        }

    }
}
