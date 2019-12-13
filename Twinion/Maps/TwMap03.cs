#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Twinion.Maps {
    class TwMap03 : AMapScripted {
        protected override int MapIndex => 3;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public TwMap03() {
            MapEvent01 = FnTOLVLON_01;
            MapEvent02 = FnTOMAPTWO_02;
            MapEvent03 = FnTOMAPTRI_03;
            MapEvent04 = FnBCKTOTWO_04;
            MapEvent05 = FnTOEGRESS_05;
            MapEvent06 = FnTONXTLVL_06;
            MapEvent07 = FnIQSTLFT_07;
            MapEvent08 = FnIQSTRGT_08;
            MapEvent09 = FnCRNRTP_09;
            MapEvent0A = FnRIVERMES_0A;
            MapEvent0B = FnDONOTENT_0B;
            MapEvent0C = FnWRNGWAY_0C;
            MapEvent0D = FnCANTREAD_0D;
            MapEvent0E = FnENJOY_0E;
            MapEvent0F = FnILFTMESS_0F;
            MapEvent10 = FnIRGTMESS_10;
            MapEvent11 = FnDESCRIP_11;
            MapEvent12 = FnDESCRIPB_12;
            MapEvent13 = FnDEATHRIV_13;
            MapEvent14 = FnRIVER_14;
            MapEvent15 = FnCOLUMN_15;
            MapEvent16 = FnWTRWARN_16;
            MapEvent17 = FnBRIDGE_17;
            MapEvent18 = FnDOMAPTRI_18;
            MapEvent19 = FnDETECTDR_19;
            MapEvent1A = FnDIDBOTH_1A;
            MapEvent1B = FnWNTTHRU_1B;
            MapEvent1C = FnCHKIQST_1C;
            MapEvent1D = FnWETELF_1D;
            MapEvent1E = FnHDBATONE_1E;
            MapEvent1F = FnHDBATTWO_1F;
            MapEvent20 = FnEZBATONE_20;
            MapEvent21 = FnMDBATONE_21;
            MapEvent22 = FnMDBATTWO_22;
            MapEvent23 = FnVIKBAT_23;
            MapEvent24 = FnNPCBAT_24;
            MapEvent25 = FnNPCTWO_25;
            MapEvent26 = FnNPCGIFT_26;
            MapEvent27 = FnNPCSTEAL_27;
            MapEvent28 = FnNPCCONVO_28;
            MapEvent29 = FnSTEALTWO_29;
            MapEvent2A = FnDRYELF_2A;
            MapEvent2B = FnKNIGHT_2B;
            MapEvent2C = FnSTEALTRI_2C;
            MapEvent2D = FnTURNWATR_2D;
            MapEvent2E = FnHIDETECT_2E;
            MapEvent2F = FnWNTFLAG_2F;
            MapEvent30 = FnREWARDI_30;
            MapEvent31 = FnQIKDOOR_31;
            MapEvent32 = FnROPEME_32;
            MapEvent33 = FnSETFLAG_33;
            MapEvent34 = FnRUSTYDOR_34;
            MapEvent35 = FnGETFLAG_35;
            MapEvent36 = FnQUICKIN_36;
            MapEvent37 = FnNOJOIN_37;
            MapEvent38 = FnPC_38;
        }
        
        // === Strings ================================================
        private const string String03FC = "This portal leads back to the main entrance.";
        private const string String0429 = "You see another room through the east door.";
        private const string String0455 = "Another hall leads west through this door.";
        private const string String0480 = "This may lead back to whence you came....";
        private const string String04AA = "This must take you somewhere important....";
        private const string String04D5 = "This portal will send you to the next level of the Queen's tests.";
        private const string String0517 = "You see a teleport.";
        private const string String052B = "Where does this lead, you wonder...";
        private const string String054F = "BEHOLD: Here is the Twinion aqueduct, built by her majesty Queen Aeowyn for her loyal subjects' benefit. Long live the Queen!";
        private const string String05CD = "DO NOT ENTER!";
        private const string String05DB = "WRONG WAY!!!";
        private const string String05E8 = "For your own sake, can't you read??? TURN BACK!!";
        private const string String0619 = "Okay, fine...don't listen to the warnings but see if I warn you again not to do something!!!";
        private const string String0676 = "Well done! Onward to more adventure...";
        private const string String069D = "Well done! Onward to greater tests...";
        private const string String06C3 = "Sounds of flowing water echo and cascade all around you, as you enter the corridors of the Aqueduct.";
        private const string String0728 = "The water in the magical Aqueduct rushes by in a fierce torrent...";
        private const string String076B = "The treacherous undertow quickly pulls you under, drowning you as it has done so many others.";
        private const string String07C9 = "The force of the Aqueduct's waters pound violently against your body...";
        private const string String0811 = "You have been drowned by the force.";
        private const string String0835 = "You've defeated Aqueus! You may travel safely through these waters.";
        private const string String0879 = "The Aqueduct's current seems particularly violent and dangerous to the east...";
        private const string String08C8 = "This bridge seems stable enough... However, the water rushing below your feet makes you nervous.";
        private const string String0929 = "Enter here, now that you've conquered Lord Aqueus.";
        private const string String095C = "Seek the protector of this Aqueduct in the west. His magic blocks your forward path.";
        private const string String09B1 = "You must pass through alone.";
        private const string String09CE = "You've located a secret passageway!!";
        private const string String09F3 = "There seems to be a subtle draft coming from a nearby wall.";
        private const string String0A2F = "You've passed here before! Onward with you!";
        private const string String0A5B = "A female voice whispers: 'You've so far passed our test with high marks.";
        private const string String0AA4 = "Let's see how well you finish it.'";
        private const string String0AC7 = "A woman's voice carries on the wind: 'You have completed enough to carry forward.";
        private const string String0B19 = "I pray thee, complete more and return later.'";
        private const string String0B47 = "A woman's voice carries on the wind: 'Come back when you've done more of this quest.'";
        private const string String0B9D = "Now, to your reward for this trial...";
        private const string String0BC3 = "Continue northward through the rest of this corner, my heroes...";
        private const string String0C04 = "This direction is open to you.";
        private const string String0C23 = "The eastern door is sealed shut.";
        private const string String0C44 = "The southern door is sealed shut.";
        private const string String0C66 = "The doors are sealed.";
        private const string String0C7C = "You must start from here alone.";
        private const string String0C9C = "You encounter a soaking wet elf, wringing out her clothes. 'Her majesty's idea of draining the River of Eternity is a good one, albeit a bit late for my brother.'";
        private const string String0D3F = "'Beware of the strong currents of this vile water.'";
        private const string String0D73 = "The elf stares blankly at the waters.";
        private const string String0D99 = "You approach a band of Warriors, who howl furiously as they charge you with axes held high.";
        private const string String0DF5 = "A party of adventurers springs at you!";
        private const string String0E1C = "Some worthy opponents challenge you to combat...";
        private const string String0E4D = "'Well done! You managed to complete that simple maze of doors.  A gift of experience, gold and booty is yours.'";
        private const string String0EBD = "The ranger is gone.";
        private const string String0ED1 = "A nimble thief lifts a sack of gold from you.";
        private const string String0EFF = "'Hmmm, what a lovely purse! Perchance I will find its twin once I've dispensed with you!'";
        private const string String0F59 = "A dying thief lies on the floor. 'Forgive my brethren. They know only to survive...'";
        private const string String0FAE = "He then collapses, dead.";
        private const string String0FC7 = "'You have done this...murderers!!!!!'";
        private const string String0FED = "'How lovely, what marvelous gold you had...'";
        private const string String101A = "'A thousand gratitudes for your generosity.'";
        private const string String1047 = "A familiar pickpocket is here with some of his friends. Now's your chance!";
        private const string String1092 = "The elf you met earlier is here, now drying out from her travels.";
        private const string String10D4 = "'Hmm...if right were first, left would be worse... If left were before, the bridge would lead thru the door... Very confusing...'";
        private const string String1156 = "'I guess you must do one of the other rooms on this level first. Then come back here to go on.'";
        private const string String11B6 = "She pays no attention to you.";
        private const string String11D4 = "'You dare think you can challenge me...you with your puny stature? Away with you!!'";
        private const string String1228 = "So saying, this massive knight flies into a rage, critically wounding all in his path as he marches off.";
        private const string String1291 = "You have died.";
        private const string String12A0 = "A nimble thief steps from the shadows in front of you.";
        private const string String12D7 = "The thief glances in your direction, sees his mark, and ignores you.";
        private const string String131C = "'A scar for you to prove you've done this task. Pray thee, continue south.'";
        private const string String1368 = "'AH HA! Too much gold in your purse! Allow me...";
        private const string String1399 = "Complete the tasks at hand before you attempt the quests east of here!'";
        private const string String13E1 = "The swirling currents here batter and sting your body.";
        private const string String1418 = "You unlock the door.";
        private const string String142D = "An impressive lock bars this shortcut from you.";
        private const string String145D = "Ah, an easy task, but necessary all the same.";
        private const string String148B = "You are granted experience and gold for your completion of this side.";
        private const string String14D1 = "A door appears in the wall!";
        private const string String14ED = "The magical gate has recognized the marks of your achievements.";
        private const string String152D = "Return here, once you've completed what must be done elsewhere.";
        private const string String156D = "You must proceed alone.";
        private const string String1585 = "There is nothing here.";
        private const string String159C = "You find a coil of rope here. You'd better tuck it away for safe keeping.";
        private const string String15E6 = "You manage to pick the rusty lock.";
        private const string String1609 = "An iron door with a rusty lock blocks your way here.";
        private const string String163E = "As long as you remain in this map, you may use this door. Upon leaving the map, it will vanish.";
        private const string String169E = "You must re-enter the area east of here to to make the door reappear.";
        private const string String16E4 = "You must enter the maze south of here to open it again!";
        private const string String171C = "You cannot join together here.";
        
        // === Functions ================================================
        private void FnTOLVLON_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String03FC); // This portal leads back to the main entrance.
            L0010: PushStack(player, 0x01);
            L0014: PushStack(player, 0x47);
            L0018: PushStack(player, 0x01);
            L001C: PushStack(player, ax);
0028  001D C4 5E 06  les bx, [bp+0x6]
002B  0020 26 FF 9F BC 00  call far word [es:bx+0xbc]
0030  0025 83 C4 08  add sp, 0x8
            L0028: return; // RETURN;
        }

        private void FnTOMAPTWO_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0429); // You see another room through the east door.
            L0010: PushStack(player, 0x02);
            L0014: PushStack(player, 0xA0);
            L0018: PushStack(player, 0x02);
            L001C: PushStack(player, ax);
0052  001D C4 5E 06  les bx, [bp+0x6]
0055  0020 26 FF 9F BC 00  call far word [es:bx+0xbc]
005A  0025 83 C4 08  add sp, 0x8
            L0028: return; // RETURN;
        }

        private void FnTOMAPTRI_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0455); // Another hall leads west through this door.
            L0010: TeleportParty(player, 0x02, 0x03, 0xAF, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void FnBCKTOTWO_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0480); // This may lead back to whence you came....
            L0010: PushStack(player, 0x02);
            L0014: PushStack(player, 0xF0);
            L0018: PushStack(player, 0x02);
            L001C: PushStack(player, ax);
00A8  001D C4 5E 06  les bx, [bp+0x6]
00AB  0020 26 FF 9F BC 00  call far word [es:bx+0xbc]
00B0  0025 83 C4 08  add sp, 0x8
            L0028: return; // RETURN;
        }

        private void FnTOEGRESS_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String04AA); // This must take you somewhere important....
            L0010: TeleportParty(player, 0x02, 0x01, 0x55, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnTONXTLVL_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x02);
            L0007: PushStack(player, 0x00);
00EC  000A C4 5E 06  les bx, [bp+0x6]
00EF  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L0038;
            L0017: ShowMessage(player, String04D5); // This portal will send you to the next level of the Queen's tests.
            L0024: SetFlag(player, 0x00, 0x02, 0x01);
            L0038: TeleportParty(player, 0x03, 0x01, 0x88, 0x03, isForwardMove);
            L0053: return; // RETURN;
        }

        private void FnIQSTLFT_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0517); // You see a teleport.
            L0010: TeleportParty(player, 0x02, 0x01, 0x07, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void FnIQSTRGT_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0517); // You see a teleport.
            L0010: TeleportParty(player, 0x02, 0x01, 0x09, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnCRNRTP_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String052B); // Where does this lead, you wonder...
            L0010: TeleportParty(player, 0x02, 0x01, ax, 0x00, isForwardMove);
            L0027: return; // RETURN;
        }

        private void FnRIVERMES_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String054F); // BEHOLD: Here is the Twinion aqueduct, built by her majesty Queen Aeowyn for her loyal subjects' benefit. Long live the Queen!
            L0010: return; // RETURN;
        }

        private void FnDONOTENT_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String05CD); // DO NOT ENTER!
            L0010: return; // RETURN;
        }

        private void FnWRNGWAY_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String05DB); // WRONG WAY!!!
            L0010: return; // RETURN;
        }

        private void FnCANTREAD_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String05E8); // For your own sake, can't you read??? TURN BACK!!
            L0010: return; // RETURN;
        }

        private void FnENJOY_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0619); // Okay, fine...don't listen to the warnings but see if I warn you again not to do something!!!
            L0010: return; // RETURN;
        }

        private void FnILFTMESS_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x07));
            L0016: if (JumpNotEqual) goto L003A;
            L0018: ShowMessage(player, String0676); // Well done! Onward to more adventure...
            L0025: SetFlag(player, 0x02, 0x07, 0x01);
            L003A: return; // RETURN;
        }

        private void FnIRGTMESS_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x06));
            L0016: if (JumpNotEqual) goto L003A;
            L0018: ShowMessage(player, String069D); // Well done! Onward to greater tests...
            L0025: SetFlag(player, 0x02, 0x06, 0x01);
            L003A: return; // RETURN;
        }

        private void FnDESCRIP_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String06C3); // Sounds of flowing water echo and cascade all around you, as you enter the corridors of the Aqueduct.
            L0010: return; // RETURN;
        }

        private void FnDESCRIPB_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0728); // The water in the magical Aqueduct rushes by in a fierce torrent...
            L0010: return; // RETURN;
        }

        private void FnDEATHRIV_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String076B); // The treacherous undertow quickly pulls you under, drowning you as it has done so many others.
            L0010: DamagePlayer(player, GetMaxHits(player));
            L0021: return; // RETURN;
        }

        private void FnRIVER_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoHealZone(player);
            L000B: PushStack(player, 0x02);
            L000F: PushStack(player, 0x00);
02E4  0012 C4 5E 06  les bx, [bp+0x6]
02E7  0015 26 FF 5F 04  call far word [es:bx+0x4]
            L0019: cx = PopStack(player);
            L001A: cx = PopStack(player);
            L001B: RefreshCompareFlags(ax);
            L001D: if (JumpNotEqual) goto L008A;
            L001F: RefreshCompareFlags(GetFlag(player, 0x02, 0x0A));
            L0032: if (JumpNotEqual) goto L0069;
            L0034: ShowMessage(player, String07C9); // The force of the Aqueduct's waters pound violently against your body...
            L0041: ax = GetMaxHits(player);
            L0048: bx = 0x0008;
            L004B: dx = ax % bx; ax = ax / bx;
0320  004E 40     inc ax
            L004F: DamagePlayer(player, ax);
            L0059: RefreshCompareFlags(GetCurrentHits(player));
            L0062: if (JumpAbove) goto L0076;
0336  0064 B8 11 08  mov ax, 0x811
            L0067: goto L006C;
            L0069: ShowMessage(player, String0835); // You've defeated Aqueus! You may travel safely through these waters.
            L0076: SetFlag(player, 0x00, 0x02, 0x01);
            L008A: return; // RETURN;
            // Extra data: 55 8B EC C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 B8 01 00 50 C4 5E 06 26 FF 5F 30 83 C4 06 5D CB 55 8B EC B8 01 00 50 50 33 C0 50 C4 5E 06 26 FF 1F 83 C4 06 5D CB 55 8B EC 33 C0 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 55 8B EC B8 01 00 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 55 8B EC 5D CB 
        }

        private void FnCOLUMN_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFloorPassable(player, 0x00, GetCurrentTile(player));
            L0017: return; // RETURN;
        }

        private void FnWTRWARN_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0879); // The Aqueduct's current seems particularly violent and dangerous to the east...
            L0010: return; // RETURN;
        }

        private void FnBRIDGE_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String08C8); // This bridge seems stable enough... However, the water rushing below your feet makes you nervous.
            L0010: return; // RETURN;
        }

        private void FnDOMAPTRI_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0052;
            L0010: Compare(GetFlag(player, 0x02, 0x0A), 0x0001);
            L0024: if (JumpNotEqual) goto L0041;
0444  0026 FF 76 08  push word [bp+0x8]
0447  0029 FF 76 06  push word [bp+0x6]
044A  002C 0E     push cs
044B  002D E8 6B FF  call 0xff9b
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: ShowMessage(player, String0929); // Enter here, now that you've conquered Lord Aqueus.
            L003F: goto L006B;
045F  0041 FF 76 08  push word [bp+0x8]
0462  0044 FF 76 06  push word [bp+0x6]
0465  0047 0E     push cs
0466  0048 E8 2E FF  call 0xff79
            L004B: cx = PopStack(player);
            L004C: cx = PopStack(player);
046B  004D B8 5C 09  mov ax, 0x95c
            L0050: goto L0035;
            L0052: ShowMessage(player, String09B1); // You must pass through alone.
047D  005F FF 76 08  push word [bp+0x8]
0480  0062 FF 76 06  push word [bp+0x6]
0483  0065 0E     push cs
0484  0066 E8 10 FF  call 0xff79
            L0069: cx = PopStack(player);
            L006A: cx = PopStack(player);
            L006B: return; // RETURN;
        }

        private void FnDETECTDR_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x0006);
            L0012: if (JumpNotBelow) goto L006C;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L006C;
            L0024: PushStack(player, 0x68);
            L0028: PushStack(player, ax);
04B4  0029 C4 5E 06  les bx, [bp+0x6]
04B7  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L006C;
            L0036: PushStack(player, 0x6E);
            L003A: PushStack(player, ax);
04C6  003B C4 5E 06  les bx, [bp+0x6]
04C9  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L006C;
            L0048: PushStack(player, 0x90);
            L004C: PushStack(player, ax);
04D8  004D C4 5E 06  les bx, [bp+0x6]
04DB  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L006C;
            L005A: PushStack(player, 0xA4);
            L005E: PushStack(player, ax);
04EA  005F C4 5E 06  les bx, [bp+0x6]
04ED  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpEqual) goto L0093;
            L006C: ShowMessage(player, String09CE); // You've located a secret passageway!!
0504  0079 FF 76 08  push word [bp+0x8]
0507  007C FF 76 06  push word [bp+0x6]
050A  007F 0E     push cs
050B  0080 E8 AB FE  call 0xff2e
            L0083: cx = PopStack(player);
            L0084: cx = PopStack(player);
0510  0085 FF 76 08  push word [bp+0x8]
0513  0088 FF 76 06  push word [bp+0x6]
0516  008B 0E     push cs
0517  008C E8 44 FE  call 0xfed3
            L008F: cx = PopStack(player);
            L0090: cx = PopStack(player);
            L0091: goto L00AC;
051E  0093 FF 76 08  push word [bp+0x8]
0521  0096 FF 76 06  push word [bp+0x6]
0524  0099 0E     push cs
0525  009A E8 6F FE  call 0xff0c
            L009D: cx = PopStack(player);
            L009E: cx = PopStack(player);
            L009F: ShowMessage(player, String09F3); // There seems to be a subtle draft coming from a nearby wall.
            L00AC: return; // RETURN;
        }

        private void FnDIDBOTH_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x09), 0x0002);
            L0017: if (JumpNotEqual) goto L0033;
            L0019: ShowMessage(player, String0A2F); // You've passed here before! Onward with you!
055F  0026 FF 76 08  push word [bp+0x8]
0562  0029 FF 76 06  push word [bp+0x6]
0565  002C 0E     push cs
0566  002D E8 50 FE  call 0xfe80
            L0030: goto L00F9;
            L0033: Compare(GetFlag(player, 0x02, 0x09), 0x0001);
            L0047: if (JumpNotEqual) goto L00A3;
            L0049: ShowMessage(player, String0A5B); // A female voice whispers: 'You've so far passed our test with high marks.
            L0056: ShowMessage(player, String0AA4); // Let's see how well you finish it.'
059C  0063 FF 76 08  push word [bp+0x8]
059F  0066 FF 76 06  push word [bp+0x6]
05A2  0069 0E     push cs
05A3  006A E8 13 FE  call 0xfe80
            L006D: cx = PopStack(player);
            L006E: cx = PopStack(player);
05A8  006F FF 76 08  push word [bp+0x8]
05AB  0072 FF 76 06  push word [bp+0x6]
05AE  0075 0E     push cs
05AF  0076 E8 AC FD  call 0xfe25
            L0079: cx = PopStack(player);
            L007A: cx = PopStack(player);
            L007B: AddExperience(player, 0x000009C4);
            L008C: SetFlag(player, 0x02, 0x09, 0x02);
            L00A1: goto L00FB;
            L00A3: Compare(GetFlag(player, 0x02, 0x06), 0x0003);
            L00B7: if (JumpNotEqual) goto L00E2;
            L00B9: Compare(GetFlag(player, 0x02, 0x07), 0x0003);
            L00CD: if (JumpNotEqual) goto L00E2;
            L00CF: ShowMessage(player, String0AC7); // A woman's voice carries on the wind: 'You have completed enough to carry forward.
0615  00DC B8 19 0B  mov ax, 0xb19
            L00DF: goto L001C;
            L00E2: ShowMessage(player, String0B47); // A woman's voice carries on the wind: 'Come back when you've done more of this quest.'
0628  00EF FF 76 08  push word [bp+0x8]
062B  00F2 FF 76 06  push word [bp+0x6]
062E  00F5 0E     push cs
062F  00F6 E8 65 FD  call 0xfe5e
            L00F9: cx = PopStack(player);
            L00FA: cx = PopStack(player);
            L00FB: return; // RETURN;
        }

        private void FnWNTTHRU_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
063E  0008 C4 5E 06  les bx, [bp+0x6]
0641  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: Compare(ax, 0x0001);
            L0014: if (JumpNotEqual) goto L003B;
            L0016: ShowMessage(player, String0B9D); // Now, to your reward for this trial...
0659  0023 FF 76 08  push word [bp+0x8]
065C  0026 FF 76 06  push word [bp+0x6]
065F  0029 0E     push cs
0660  002A E8 56 FD  call 0xfd83
            L002D: cx = PopStack(player);
            L002E: cx = PopStack(player);
0665  002F FF 76 08  push word [bp+0x8]
0668  0032 FF 76 06  push word [bp+0x6]
066B  0035 0E     push cs
066C  0036 E8 EF FC  call 0xfd28
            L0039: goto L0052;
            L003B: ShowMessage(player, String0BC3); // Continue northward through the rest of this corner, my heroes...
067E  0048 FF 76 08  push word [bp+0x8]
0681  004B FF 76 06  push word [bp+0x6]
0684  004E 0E     push cs
0685  004F E8 0F FD  call 0xfd61
            L0052: cx = PopStack(player);
            L0053: cx = PopStack(player);
            L0054: return; // RETURN;
        }

        private void FnCHKIQST_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpEqual) goto L0013;
            L0010: goto L0149;
            L0013: RefreshCompareFlags(GetFlag(player, 0x02, 0x07));
            L0026: if (JumpNotEqual) goto L0059;
            L0028: RefreshCompareFlags(GetFlag(player, 0x02, 0x06));
            L003B: if (JumpNotEqual) goto L0059;
            L003D: ShowMessage(player, String0C04); // This direction is open to you.
06D6  004A FF 76 08  push word [bp+0x8]
06D9  004D FF 76 06  push word [bp+0x6]
06DC  0050 0E     push cs
06DD  0051 E8 D9 FC  call 0xfd2d
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: goto L0162;
            L0059: ax = IsFlagOn(player, 0x02, 0x06);
            L006C: if (JumpEqual) goto L00C3;
            L006E: RefreshCompareFlags(GetFlag(player, 0x02, 0x07));
            L0081: if (JumpNotEqual) goto L00C3;
            L0083: ShowMessage(player, String0C23); // The eastern door is sealed shut.
            L0090: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x00);
            L00A9: SetWallPassable(player, GetCurrentTile(player), ax, 0x01);
            L00C0: goto L0162;
            L00C3: ax = IsFlagOn(player, 0x02, 0x07);
            L00D6: if (JumpEqual) goto L012F;
            L00D8: RefreshCompareFlags(GetFlag(player, 0x02, 0x06));
            L00EB: if (JumpNotEqual) goto L012F;
            L00ED: ShowMessage(player, String0C44); // The southern door is sealed shut.
            L00FA: SetWallPassable(player, GetCurrentTile(player), 0x01, 0x00);
            L0113: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x01);
            L012D: goto L0162;
            L012F: ShowMessage(player, String0C66); // The doors are sealed.
07C8  013C FF 76 08  push word [bp+0x8]
07CB  013F FF 76 06  push word [bp+0x6]
07CE  0142 0E     push cs
07CF  0143 E8 C5 FB  call 0xfd0b
            L0146: goto L0054;
07D5  0149 FF 76 08  push word [bp+0x8]
07D8  014C FF 76 06  push word [bp+0x6]
07DB  014F 0E     push cs
07DC  0150 E8 B8 FB  call 0xfd0b
            L0153: cx = PopStack(player);
            L0154: cx = PopStack(player);
            L0155: ShowMessage(player, String0C7C); // You must start from here alone.
            L0162: return; // RETURN;
        }

        private void FnWETELF_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0018);
            L0010: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0023: if (JumpNotEqual) goto L0049;
            L0025: ShowMessage(player, String0C9C); // You encounter a soaking wet elf, wringing out her clothes. 'Her majesty's idea of draining the River of Eternity is a good one, albeit a bit late for my brother.'
            L0032: SetFlag(player, 0x03, 0x02, 0x01);
            L0047: goto L007E;
            L0049: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L005D: if (JumpNotEqual) goto L0071;
            L005F: ShowMessage(player, String0D3F); // 'Beware of the strong currents of this vile water.'
085C  006C B8 02 00  mov ax, 0x2
            L006F: goto L0035;
            L0071: ShowMessage(player, String0D73); // The elf stares blankly at the waters.
            L007E: return; // RETURN;
        }

        private void FnHDBATONE_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0873  0003 83 EC 0A  sub sp, 0xa
0876  0006 56     push si
0877  0007 57     push di
            L0008: di = 0;
087A  000A C7 46 FE 00 00  mov word [bp-0x2], 0x0
087F  000F C7 46 FC 00 00  mov word [bp-0x4], 0x0
0884  0014 C7 46 FA 00 00  mov word [bp-0x6], 0x0
            L0019: si = 0;
088B  001B C7 46 F8 00 00  mov word [bp-0x8], 0x0
0890  0020 C7 46 F6 00 00  mov word [bp-0xa], 0x0
            L0025: Compare(PartyCount(player), 0x0001);
            L0030: if (JumpEqual) goto L0039;
            L0032: Compare(ax, 0x0002);
            L0035: if (JumpEqual) goto L0046;
            L0037: goto L005D;
            L0039: di = 0x0025;
08AC  003C C7 46 FE 25 00  mov word [bp-0x2], 0x25
            L0041: si = 0x0002;
            L0044: goto L007C;
            L0046: di = 0x0025;
08B9  0049 C7 46 FE 25 00  mov word [bp-0x2], 0x25
08BE  004E C7 46 FC 26 00  mov word [bp-0x4], 0x26
            L0053: si = 0x0002;
08C6  0056 C7 46 F8 04 00  mov word [bp-0x8], 0x4
            L005B: goto L007C;
            L005D: di = 0x0021;
08D0  0060 C7 46 FE 21 00  mov word [bp-0x2], 0x21
08D5  0065 C7 46 FC 26 00  mov word [bp-0x4], 0x26
08DA  006A C7 46 FA 26 00  mov word [bp-0x6], 0x26
            L006F: si = 0x0002;
08E2  0072 C7 46 F8 05 00  mov word [bp-0x8], 0x5
08E7  0077 C7 46 F6 06 00  mov word [bp-0xa], 0x6
08EC  007C 57     push di
            L007D: PushStack(player, 0x01);
08F1  0081 C4 5E 06  les bx, [bp+0x6]
08F4  0084 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0089: cx = PopStack(player);
            L008A: cx = PopStack(player);
08FB  008B 0B F6  or si, si
            L008D: if (JumpEqual) goto L00C9;
08FF  008F FF 76 FE  push word [bp-0x2]
0902  0092 56     push si
0903  0093 C4 5E 06  les bx, [bp+0x6]
0906  0096 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L009B: cx = PopStack(player);
            L009C: cx = PopStack(player);
090D  009D 83 7E F8 00  cmp word [bp-0x8], 0x0
            L00A1: if (JumpEqual) goto L00C9;
0913  00A3 FF 76 FC  push word [bp-0x4]
0916  00A6 FF 76 F8  push word [bp-0x8]
0919  00A9 C4 5E 06  les bx, [bp+0x6]
091C  00AC 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L00B1: cx = PopStack(player);
            L00B2: cx = PopStack(player);
0923  00B3 83 7E F6 00  cmp word [bp-0xa], 0x0
            L00B7: if (JumpEqual) goto L00C9;
0929  00B9 FF 76 FA  push word [bp-0x6]
092C  00BC FF 76 F6  push word [bp-0xa]
092F  00BF C4 5E 06  les bx, [bp+0x6]
0932  00C2 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L00C7: cx = PopStack(player);
            L00C8: cx = PopStack(player);
0939  00C9 5F     pop di
093A  00CA 5E     pop si
            L00CB: // restore stack ptr: sp = bp;
            L00CD: return; // RETURN;
        }

        private void FnHDBATTWO_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0942  0003 83 EC 0A  sub sp, 0xa
0945  0006 56     push si
0946  0007 57     push di
            L0008: di = 0;
0949  000A C7 46 FE 00 00  mov word [bp-0x2], 0x0
094E  000F C7 46 FC 00 00  mov word [bp-0x4], 0x0
0953  0014 C7 46 FA 00 00  mov word [bp-0x6], 0x0
            L0019: si = 0;
095A  001B C7 46 F8 00 00  mov word [bp-0x8], 0x0
095F  0020 C7 46 F6 00 00  mov word [bp-0xa], 0x0
            L0025: Compare(PartyCount(player), 0x0001);
            L0030: if (JumpEqual) goto L0039;
            L0032: Compare(ax, 0x0002);
            L0035: if (JumpEqual) goto L0046;
            L0037: goto L005D;
            L0039: di = 0x0022;
097B  003C C7 46 FE 24 00  mov word [bp-0x2], 0x24
            L0041: si = 0x0005;
            L0044: goto L007C;
            L0046: di = 0x0022;
0988  0049 C7 46 FE 24 00  mov word [bp-0x2], 0x24
098D  004E C7 46 FC 23 00  mov word [bp-0x4], 0x23
            L0053: si = 0x0002;
0995  0056 C7 46 F8 05 00  mov word [bp-0x8], 0x5
            L005B: goto L007C;
            L005D: di = 0x0023;
099F  0060 C7 46 FE 23 00  mov word [bp-0x2], 0x23
09A4  0065 C7 46 FC 23 00  mov word [bp-0x4], 0x23
09A9  006A C7 46 FA 24 00  mov word [bp-0x6], 0x24
            L006F: si = 0x0002;
09B1  0072 C7 46 F8 03 00  mov word [bp-0x8], 0x3
09B6  0077 C7 46 F6 04 00  mov word [bp-0xa], 0x4
09BB  007C 57     push di
            L007D: PushStack(player, 0x01);
09C0  0081 C4 5E 06  les bx, [bp+0x6]
09C3  0084 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0089: cx = PopStack(player);
            L008A: cx = PopStack(player);
09CA  008B 0B F6  or si, si
            L008D: if (JumpEqual) goto L00C9;
09CE  008F FF 76 FE  push word [bp-0x2]
09D1  0092 56     push si
09D2  0093 C4 5E 06  les bx, [bp+0x6]
09D5  0096 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L009B: cx = PopStack(player);
            L009C: cx = PopStack(player);
09DC  009D 83 7E F8 00  cmp word [bp-0x8], 0x0
            L00A1: if (JumpEqual) goto L00C9;
09E2  00A3 FF 76 FC  push word [bp-0x4]
09E5  00A6 FF 76 F8  push word [bp-0x8]
09E8  00A9 C4 5E 06  les bx, [bp+0x6]
09EB  00AC 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L00B1: cx = PopStack(player);
            L00B2: cx = PopStack(player);
09F2  00B3 83 7E F6 00  cmp word [bp-0xa], 0x0
            L00B7: if (JumpEqual) goto L00C9;
09F8  00B9 FF 76 FA  push word [bp-0x6]
09FB  00BC FF 76 F6  push word [bp-0xa]
09FE  00BF C4 5E 06  les bx, [bp+0x6]
0A01  00C2 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L00C7: cx = PopStack(player);
            L00C8: cx = PopStack(player);
0A08  00C9 5F     pop di
0A09  00CA 5E     pop si
            L00CB: // restore stack ptr: sp = bp;
            L00CD: return; // RETURN;
        }

        private void FnEZBATONE_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: Compare(GetCurrentTile(player), 0x00E4);
            L000E: if (JumpNotEqual) goto L0029;
            L0010: PushStack(player, 0x64);
            L0014: PushStack(player, 0x00);
            L0017: PushStack(player, ax);
            L0018: PushStack(player, ax);
            L0019: PushStack(player, ax);
            L001A: PushStack(player, 0xBF);
0A2C  001E C4 5E 06  les bx, [bp+0x6]
0A2F  0021 26 FF 9F D8 00  call far word [es:bx+0xd8]
0A34  0026 83 C4 0C  add sp, 0xc
            L0029: si = 0x0001;
            L002C: goto L003E;
            L002E: AddEncounter(player, si, 0x05);
            L003D: si = si + 1;
            L003E: Compare(si, 0x03);
            L0041: if (JumpLessOrEqual) goto L002E;
            L0043: return; // RETURN (restoring si);
        }

        private void FnMDBATONE_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0A57  0003 83 EC 06  sub sp, 0x6
0A5A  0006 56     push si
0A5B  0007 57     push di
            L0008: di = 0;
0A5E  000A C7 46 FE 00 00  mov word [bp-0x2], 0x0
0A63  000F C7 46 FC 00 00  mov word [bp-0x4], 0x0
            L0014: si = 0;
0A6A  0016 C7 46 FA 00 00  mov word [bp-0x6], 0x0
            L001B: Compare(PartyCount(player), 0x0001);
            L0026: if (JumpEqual) goto L002F;
            L0028: Compare(ax, 0x0002);
            L002B: if (JumpEqual) goto L003C;
            L002D: goto L0046;
            L002F: di = 0x0003;
0A86  0032 C7 46 FE 03 00  mov word [bp-0x2], 0x3
            L0037: si = 0x0002;
            L003A: goto L005B;
            L003C: di = 0x0003;
0A93  003F C7 46 FE 04 00  mov word [bp-0x2], 0x4
            L0044: goto L0037;
            L0046: di = 0x0003;
0A9D  0049 C7 46 FE 04 00  mov word [bp-0x2], 0x4
0AA2  004E C7 46 FC 05 00  mov word [bp-0x4], 0x5
            L0053: si = 0x0002;
0AAA  0056 C7 46 FA 06 00  mov word [bp-0x6], 0x6
0AAF  005B 57     push di
            L005C: PushStack(player, 0x01);
0AB4  0060 C4 5E 06  les bx, [bp+0x6]
0AB7  0063 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0068: cx = PopStack(player);
            L0069: cx = PopStack(player);
0ABE  006A 0B F6  or si, si
            L006C: if (JumpEqual) goto L0092;
0AC2  006E FF 76 FE  push word [bp-0x2]
0AC5  0071 56     push si
0AC6  0072 C4 5E 06  les bx, [bp+0x6]
0AC9  0075 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L007A: cx = PopStack(player);
            L007B: cx = PopStack(player);
0AD0  007C 83 7E FA 00  cmp word [bp-0x6], 0x0
            L0080: if (JumpEqual) goto L0092;
0AD6  0082 FF 76 FC  push word [bp-0x4]
0AD9  0085 FF 76 FA  push word [bp-0x6]
0ADC  0088 C4 5E 06  les bx, [bp+0x6]
0ADF  008B 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0090: cx = PopStack(player);
            L0091: cx = PopStack(player);
0AE6  0092 5F     pop di
0AE7  0093 5E     pop si
            L0094: // restore stack ptr: sp = bp;
            L0096: return; // RETURN;
        }

        private void FnMDBATTWO_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002B;
            L0010: AddEncounter(player, 0x01, 0x25);
            L0022: PushStack(player, 0x25);
0B12  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00A2;
            L002B: Compare(PartyCount(player), 0x0002);
            L0036: if (JumpNotEqual) goto L0065;
            L0038: AddEncounter(player, 0x01, 0x25);
            L004A: AddEncounter(player, 0x02, 0x25);
            L005C: PushStack(player, 0x26);
0B4C  0060 B8 03 00  mov ax, 0x3
            L0063: goto L00A2;
            L0065: AddEncounter(player, 0x01, 0x21);
            L0077: AddEncounter(player, 0x02, 0x21);
            L0089: AddEncounter(player, 0x03, 0x26);
            L009B: AddEncounter(player, 0x04, 0x26);
            L00AD: return; // RETURN;
        }

        private void FnVIKBAT_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String0D99); // You approach a band of Warriors, who howl furiously as they charge you with axes held high.
            L0011: Compare(PartyCount(player), 0x0001);
            L001C: if (JumpEqual) goto L0020;
            L001E: goto L003C;
            L0020: si = 0x0001;
            L0023: goto L0035;
            L0025: AddEncounter(player, si, 0x26);
            L0034: si = si + 1;
            L0035: Compare(si, 0x03);
            L0038: if (JumpLessOrEqual) goto L0025;
            L003A: goto L0056;
            L003C: si = 0x0001;
            L003F: goto L0051;
            L0041: AddEncounter(player, si, 0x26);
            L0050: si = si + 1;
            L0051: Compare(si, 0x06);
            L0054: if (JumpLessOrEqual) goto L0041;
            L0056: return; // RETURN (restoring si);
        }

        private void FnNPCBAT_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0DF5); // A party of adventurers springs at you!
            L0010: Compare(PartyCount(player), 0x0001);
            L001B: if (JumpEqual) goto L0024;
            L001D: Compare(ax, 0x0002);
            L0020: if (JumpEqual) goto L0040;
            L0022: goto L007B;
            L0024: AddEncounter(player, 0x01, 0x0A);
            L0036: PushStack(player, 0x12);
0C2E  003A B8 02 00  mov ax, 0x2
            L003D: goto L00DC;
            L0040: AddEncounter(player, 0x01, 0x0A);
            L0052: AddEncounter(player, 0x02, 0x12);
            L0064: AddEncounter(player, 0x05, 0x17);
0C6A  0076 B8 1B 00  mov ax, 0x1b
            L0079: goto L00D8;
            L007B: AddEncounter(player, 0x01, 0x0A);
            L008D: AddEncounter(player, 0x02, 0x12);
            L009F: AddEncounter(player, 0x03, 0x17);
            L00B1: AddEncounter(player, 0x04, 0x1B);
            L00C3: AddEncounter(player, 0x05, 0x0C);
            L00D5: AddEncounter(player, 0x06, 0x1F);
            L00E7: return; // RETURN;
        }

        private void FnNPCTWO_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0E1C); // Some worthy opponents challenge you to combat...
            L0010: AddEncounter(player, 0x01, 0x0F);
            L0022: AddEncounter(player, 0x02, 0x15);
            L0034: AddEncounter(player, 0x03, 0x16);
            L0046: AddEncounter(player, 0x04, 0x17);
            L0058: return; // RETURN;
        }

        private void FnNPCGIFT_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: RefreshCompareFlags(GetFlag(player, 0x02, 0x04));
            L0017: if (JumpEqual) goto L001C;
            L0019: goto L00A6;
            L001C: ShowPortrait(player, 0x001E);
            L0029: ShowMessage(player, String0E4D); // 'Well done! You managed to complete that simple maze of doors.  A gift of experience, gold and booty is yours.'
            L0036: SetFlag(player, 0x02, 0x04, 0x01);
            L004B: bx = GetGuild(player);
            L0054: Compare(bx, 0x05);
            L0057: if (JumpAbove) goto L0079;
            L0059: switch (bx) {
                case 0:
                    goto L0060;
                case 1:
                    goto L0065;
                case 2:
                    goto L0067;
                case 3:
                    goto L006C;
                case 4:
                    goto L0071;
                case 5:
                    goto L0076;
            }
            L0060: si = 0x001C;
            L0063: goto L0079;
            L0065: goto L0067;
            L0067: si = 0x0074;
            L006A: goto L0079;
            L006C: si = 0x004F;
            L006F: goto L0079;
            L0071: si = 0x008E;
            L0074: goto L0079;
            L0076: si = 0x002B;
0DB0  0079 56     push si
0DB1  007A C4 5E 06  les bx, [bp+0x6]
0DB4  007D 26 FF 5F 48  call far word [es:bx+0x48]
            L0081: cx = PopStack(player);
            L0082: ModifyGold(player, 0x01F4);
            L0093: AddExperience(player, 0x00000190);
            L00A4: goto L00B3;
            L00A6: ShowMessage(player, String0EBD); // The ranger is gone.
            L00B3: return; // RETURN (restoring si);
        }

        private void FnNPCSTEAL_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0016: if (JumpNotEqual) goto L0056;
            L0018: ShowMessage(player, String0ED1); // A nimble thief lifts a sack of gold from you.
            L0025: ShowMessage(player, String0EFF); // 'Hmmm, what a lovely purse! Perchance I will find its twin once I've dispensed with you!'
            L0032: ModifyGold(player, 0xFFFF0CBA);
            L0044: AddEncounter(player, 0x01, 0x19);
            L0056: return; // RETURN;
        }

        private void FnNPCCONVO_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L0016: if (JumpNotEqual) goto L0053;
            L0018: ShowPortrait(player, 0x0025);
            L0025: ShowMessage(player, String0F59); // A dying thief lies on the floor. 'Forgive my brethren. They know only to survive...'
            L0032: ShowMessage(player, String0FAE); // He then collapses, dead.
            L003F: PushStack(player, 0x01);
            L0043: PushStack(player, ax);
            L0044: PushStack(player, 0x03);
0E99  0048 C4 5E 06  les bx, [bp+0x6]
0E9C  004B 26 FF 1F  call far word [es:bx]
0E9F  004E 83 C4 06  add sp, 0x6
            L0051: goto L00C4;
            L0053: ShowMessage(player, String0FC7); // 'You have done this...murderers!!!!!'
0EB1  0060 B8 D0 07  mov ax, 0x7d0
            L0063: PushStack(player, ax);
            L0064: PushStack(player, 0x00);
            L0067: PushStack(player, ax);
            L0068: PushStack(player, ax);
            L0069: PushStack(player, 0x1F);
            L006D: PushStack(player, 0x09);
0EC2  0071 C4 5E 06  les bx, [bp+0x6]
0EC5  0074 26 FF 9F D8 00  call far word [es:bx+0xd8]
0ECA  0079 83 C4 0C  add sp, 0xc
            L007C: AddEncounter(player, 0x01, 0x1A);
            L008E: AddEncounter(player, 0x02, 0x1A);
            L00A0: AddEncounter(player, 0x05, 0x19);
            L00B2: AddEncounter(player, 0x06, 0x28);
            L00C4: return; // RETURN;
        }

        private void FnSTEALTWO_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: Compare(GetFlag(player, 0x02, 0x04), 0x0001);
            L0018: if (JumpAbove) goto L0058;
            L001A: ShowPortrait(player, 0x0025);
            L0027: ShowMessage(player, String0FED); // 'How lovely, what marvelous gold you had...'
            L0034: ModifyGold(player, 0xFFFF06BA);
            L0046: ShowMessage(player, String101A); // 'A thousand gratitudes for your generosity.'
0F6A  0053 B8 02 00  mov ax, 0x2
            L0056: goto L009A;
            L0058: Compare(GetFlag(player, 0x02, 0x04), 0x0002);
            L006C: if (JumpNotEqual) goto L00AC;
            L006E: ShowMessage(player, String1047); // A familiar pickpocket is here with some of his friends. Now's your chance!
            L007B: PushStack(player, 0xFA);
            L007F: PushStack(player, 0x00);
            L0082: PushStack(player, ax);
            L0083: PushStack(player, ax);
            L0084: PushStack(player, 0x8D);
            L0088: PushStack(player, 0x03);
0FA3  008C C4 5E 06  les bx, [bp+0x6]
0FA6  008F 26 FF 9F D8 00  call far word [es:bx+0xd8]
0FAB  0094 83 C4 0C  add sp, 0xc
            L0097: SetFlag(player, 0x02, 0x04, 0x03);
            L00AC: si = 0x0001;
            L00AF: goto L00C1;
            L00B1: AddEncounter(player, si, 0x1A);
            L00C0: si = si + 1;
            L00C1: Compare(si, 0x03);
            L00C4: if (JumpLessOrEqual) goto L00B1;
            L00C6: return; // RETURN (restoring si);
        }

        private void FnDRYELF_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0018);
            L0010: ShowMessage(player, String1092); // The elf you met earlier is here, now drying out from her travels.
            L001D: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0030: if (JumpEqual) goto L0048;
            L0032: Compare(GetFlag(player, 0x03, 0x02), 0x0002);
            L0046: if (JumpNotEqual) goto L005A;
            L0048: ShowMessage(player, String10D4); // 'Hmm...if right were first, left would be worse... If left were before, the bridge would lead thru the door... Very confusing...'
1035  0055 B8 03 00  mov ax, 0x3
            L0058: goto L008F;
            L005A: Compare(GetFlag(player, 0x03, 0x02), 0x0003);
            L006E: if (JumpNotEqual) goto L007F;
            L0070: ShowMessage(player, String1156); // 'I guess you must do one of the other rooms on this level first. Then come back here to go on.'
            L007D: goto L00A1;
            L007F: ShowMessage(player, String11B6); // She pays no attention to you.
            L008C: SetFlag(player, 0x03, 0x02, 0x02);
            L00A1: return; // RETURN;
        }

        private void FnKNIGHT_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
            L0007: PushStack(player, 0x00);
108D  000A C4 5E 06  les bx, [bp+0x6]
1090  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpEqual) goto L001A;
            L0017: goto L009F;
            L001A: ShowPortrait(player, 0x001C);
            L0027: ShowMessage(player, String11D4); // 'You dare think you can challenge me...you with your puny stature? Away with you!!'
            L0034: ShowMessage(player, String1228); // So saying, this massive knight flies into a rage, critically wounding all in his path as he marches off.
            L0041: ax = GetMaxHits(player);
            L0048: bx = 0x0002;
            L004B: dx = ax % bx; ax = ax / bx;
            L004E: DamagePlayer(player, ax);
            L0058: RefreshCompareFlags(GetCurrentHits(player));
            L0061: if (JumpAbove) goto L007C;
            L0063: ShowMessage(player, String1291); // You have died.
10F3  0070 FF 76 08  push word [bp+0x8]
10F6  0073 FF 76 06  push word [bp+0x6]
10F9  0076 0E     push cs
10FA  0077 E8 DF F2  call 0xf359
            L007A: cx = PopStack(player);
            L007B: cx = PopStack(player);
            L007C: ax = GetCurrentHits(player);
            L0083: bx = 0x0002;
            L0086: dx = ax % bx; ax = ax / bx;
            L0089: DamagePlayer(player, ax);
1116  0093 FF 76 08  push word [bp+0x8]
1119  0096 FF 76 06  push word [bp+0x6]
111C  0099 0E     push cs
111D  009A E8 61 F2  call 0xf2fe
            L009D: cx = PopStack(player);
            L009E: cx = PopStack(player);
            L009F: return; // RETURN;
        }

        private void FnSTEALTRI_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0023);
            L0010: ShowMessage(player, String12A0); // A nimble thief steps from the shadows in front of you.
            L001D: Compare(GetFlag(player, 0x02, 0x08), 0x0001);
            L0031: if (JumpNotEqual) goto L0043;
            L0033: ShowMessage(player, String12D7); // The thief glances in your direction, sees his mark, and ignores you.
            L0040: goto L0133;
            L0043: PushStack(player, 0x06);
            L0047: PushStack(player, 0x02);
116F  004B C4 5E 06  les bx, [bp+0x6]
1172  004E 26 FF 5F 08  call far word [es:bx+0x8]
            L0052: cx = PopStack(player);
            L0053: cx = PopStack(player);
            L0054: Compare(ax, 0x0001);
            L0057: if (JumpNotEqual) goto L006F;
            L0059: PushStack(player, 0x07);
            L005D: PushStack(player, 0x02);
1185  0061 C4 5E 06  les bx, [bp+0x6]
1188  0064 26 FF 5F 08  call far word [es:bx+0x8]
            L0068: cx = PopStack(player);
            L0069: cx = PopStack(player);
            L006A: Compare(ax, 0x0001);
            L006D: if (JumpEqual) goto L0085;
            L006F: Compare(GetFlag(player, 0x02, 0x0A), 0x0001);
            L0083: if (JumpNotEqual) goto L00D5;
            L0085: SetFlag(player, 0x02, 0x09, 0x01);
            L009A: ShowMessage(player, String131C); // 'A scar for you to prove you've done this task. Pray thee, continue south.'
            L00A7: ax = GetCurrentHits(player);
            L00AE: bx = 0x000A;
            L00B1: dx = ax % bx; ax = ax / bx;
            L00B4: DamagePlayer(player, ax);
            L00BE: SetFlag(player, 0x02, 0x08, 0x01);
            L00D3: goto L0133;
            L00D5: ShowMessage(player, String1368); // 'AH HA! Too much gold in your purse! Allow me...
            L00E2: ModifyGold(player, 0xFFFFD4BA);
            L00F4: ShowMessage(player, String1399); // Complete the tasks at hand before you attempt the quests east of here!'
            L0101: ax = GetCurrentHits(player);
            L0108: bx = 0x0002;
            L010B: dx = ax % bx; ax = ax / bx;
            L010E: DamagePlayer(player, ax);
            L0118: TeleportParty(player, 0x02, 0x01, 0x79, 0x03, isForwardMove);
            L0133: return; // RETURN;
        }

        private void FnTURNWATR_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoHealZone(player);
            L000B: PushStack(player, 0x01);
            L000F: PushStack(player, 0x00);
126B  0012 C4 5E 06  les bx, [bp+0x6]
126E  0015 26 FF 5F 04  call far word [es:bx+0x4]
            L0019: cx = PopStack(player);
            L001A: cx = PopStack(player);
            L001B: RefreshCompareFlags(ax);
            L001D: if (JumpNotEqual) goto L0081;
            L001F: PushStack(player, 0x02);
127C  0023 C4 5E 06  les bx, [bp+0x6]
127F  0026 26 FF 9F CC 00  call far word [es:bx+0xcc]
            L002B: cx = PopStack(player);
            L002C: ShowMessage(player, String13E1); // The swirling currents here batter and sting your body.
            L0039: ax = GetMaxHits(player);
            L0040: bx = 0x0004;
            L0043: dx = ax % bx; ax = ax / bx;
129F  0046 40     inc ax
            L0047: DamagePlayer(player, ax);
            L0051: RefreshCompareFlags(GetCurrentHits(player));
            L005A: if (JumpAbove) goto L0075;
            L005C: ShowMessage(player, String0811); // You have been drowned by the force.
12C2  0069 FF 76 08  push word [bp+0x8]
12C5  006C FF 76 06  push word [bp+0x6]
12C8  006F 0E     push cs
12C9  0070 E8 10 F1  call 0xf183
            L0073: cx = PopStack(player);
            L0074: cx = PopStack(player);
12CE  0075 FF 76 08  push word [bp+0x8]
12D1  0078 FF 76 06  push word [bp+0x6]
12D4  007B 0E     push cs
12D5  007C E8 A9 F0  call 0xf128
            L007F: cx = PopStack(player);
            L0080: cx = PopStack(player);
            L0081: return; // RETURN;
        }

        private void FnHIDETECT_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0E), 0x000C);
            L0012: if (JumpEqual) goto L003B;
            L0014: PushStack(player, 0x6F);
            L0018: PushStack(player, ax);
12F5  0019 C4 5E 06  les bx, [bp+0x6]
12F8  001C 26 FF 5F 54  call far word [es:bx+0x54]
            L0020: cx = PopStack(player);
            L0021: cx = PopStack(player);
            L0022: RefreshCompareFlags(ax);
            L0024: if (JumpNotEqual) goto L003B;
            L0026: ax = HasUsedItem(player, 0xBF, 0xC0);
            L0039: if (JumpEqual) goto L0056;
            L003B: ShowMessage(player, String1418); // You unlock the door.
1324  0048 FF 76 08  push word [bp+0x8]
1327  004B FF 76 06  push word [bp+0x6]
132A  004E 0E     push cs
132B  004F E8 8B F0  call 0xf0dd
            L0052: cx = PopStack(player);
            L0053: cx = PopStack(player);
            L0054: goto L006F;
1332  0056 FF 76 08  push word [bp+0x8]
1335  0059 FF 76 06  push word [bp+0x6]
1338  005C 0E     push cs
1339  005D E8 5B F0  call 0xf0bb
            L0060: cx = PopStack(player);
            L0061: cx = PopStack(player);
            L0062: ShowMessage(player, String142D); // An impressive lock bars this shortcut from you.
            L006F: return; // RETURN;
        }

        private void FnWNTFLAG_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String145D); // Ah, an easy task, but necessary all the same.
            L0010: PushStack(player, 0x01);
            L0014: PushStack(player, 0x03);
            L0018: PushStack(player, ax);
1366  0019 C4 5E 06  les bx, [bp+0x6]
1369  001C 26 FF 1F  call far word [es:bx]
136C  001F 83 C4 06  add sp, 0x6
            L0022: return; // RETURN;
        }

        private void FnREWARDI_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
1374  0003 C4 5E 06  les bx, [bp+0x6]
1377  0006 26 FF 5F 40  call far word [es:bx+0x40]
            L000A: Compare(GetFlag(player, 0x02, 0x07), 0x0001);
            L001E: if (JumpNotEqual) goto L0029;
            L0020: PushStack(player, 0x02);
1395  0024 B8 07 00  mov ax, 0x7
            L0027: goto L0046;
            L0029: Compare(GetFlag(player, 0x02, 0x06), 0x0001);
            L003D: if (JumpNotEqual) goto L0061;
            L003F: SetFlag(player, 0x02, 0x06, 0x02);
13C5  0054 FF 76 08  push word [bp+0x8]
13C8  0057 FF 76 06  push word [bp+0x6]
13CB  005A 0E     push cs
13CC  005B E8 05 00  call 0x63
            L005E: // NOP
            L005F: cx = PopStack(player);
            L0060: cx = PopStack(player);
            L0061: return; // RETURN;
            // Extra data: 55 8B EC B8 8B 14 50 C4 5E 06 26 FF 9F F8 00 59 33 C0 BA B0 04 50 52 C4 5E 06 26 FF 9F 98 00 59 59 33 C0 BA EE 02 50 52 C4 5E 06 26 FF 9F AC 00 59 59 5D CB 
        }

        private void FnQIKDOOR_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0069;
            L0010: Compare(GetFlag(player, 0x02, 0x10), 0x0001);
            L0024: if (JumpEqual) goto L003C;
            L0026: Compare(GetFlag(player, 0x02, 0x10), 0x0002);
            L003A: if (JumpNotEqual) goto L0064;
            L003C: ShowMessage(player, String14D1); // A door appears in the wall!
            L0049: ShowMessage(player, String14ED); // The magical gate has recognized the marks of your achievements.
145E  0056 FF 76 08  push word [bp+0x8]
1461  0059 FF 76 06  push word [bp+0x6]
1464  005C 0E     push cs
1465  005D E8 51 EF  call 0xefb1
            L0060: cx = PopStack(player);
            L0061: cx = PopStack(player);
            L0062: goto L0082;
146C  0064 B8 2D 15  mov ax, 0x152d
            L0067: goto L0078;
1471  0069 FF 76 08  push word [bp+0x8]
1474  006C FF 76 06  push word [bp+0x6]
1477  006F 0E     push cs
1478  0070 E8 1C EF  call 0xef8f
            L0073: cx = PopStack(player);
            L0074: cx = PopStack(player);
            L0075: ShowMessage(player, String156D); // You must proceed alone.
            L0082: return; // RETURN;
        }

        private void FnROPEME_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x03), 0x0001);
            L0017: if (JumpNotEqual) goto L0028;
            L0019: ShowMessage(player, String1585); // There is nothing here.
            L0026: goto L0056;
            L0028: ShowMessage(player, String159C); // You find a coil of rope here. You'd better tuck it away for safe keeping.
            L0035: GiveItem(player, 0xE0);
            L0041: SetFlag(player, 0x02, 0x03, 0x01);
            L0056: return; // RETURN;
        }

        private void FnSETFLAG_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x03, 0x04, 0x01);
            L0018: return; // RETURN;
        }

        private void FnRUSTYDOR_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, 0xBE, 0xC0);
            L0016: if (JumpNotEqual) goto L003B;
            L0018: Compare(HasUsedSkill(player, 0x0E), 0x0004);
            L0027: if (JumpAbove) goto L003B;
            L0029: PushStack(player, 0x6F);
            L002D: PushStack(player, ax);
152C  002E C4 5E 06  les bx, [bp+0x6]
152F  0031 26 FF 5F 54  call far word [es:bx+0x54]
            L0035: cx = PopStack(player);
            L0036: cx = PopStack(player);
            L0037: RefreshCompareFlags(ax);
            L0039: if (JumpEqual) goto L004C;
1539  003B FF 76 08  push word [bp+0x8]
153C  003E FF 76 06  push word [bp+0x6]
153F  0041 0E     push cs
1540  0042 E8 76 EE  call 0xeebb
            L0045: cx = PopStack(player);
            L0046: cx = PopStack(player);
1545  0047 B8 E6 15  mov ax, 0x15e6
            L004A: goto L005B;
154A  004C FF 76 08  push word [bp+0x8]
154D  004F FF 76 06  push word [bp+0x6]
1550  0052 0E     push cs
1551  0053 E8 43 EE  call 0xee99
            L0056: cx = PopStack(player);
            L0057: cx = PopStack(player);
            L0058: ShowMessage(player, String1609); // An iron door with a rusty lock blocks your way here.
            L0065: return; // RETURN;
        }

        private void FnGETFLAG_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: Compare(GetCurrentTile(player), 0x00E4);
            L000E: if (JumpEqual) goto L0017;
            L0010: Compare(ax, 0x00EB);
            L0013: if (JumpEqual) goto L001C;
            L0015: goto L001F;
            L0017: si = 0x0001;
            L001A: goto L001F;
            L001C: si = 0x0002;
            L001F: SetFlag(player, 0xC4, 0xB8, si);
            L0031: return; // RETURN (restoring si);
        }

        private void FnQUICKIN_36(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
159C  0003 83 EC 04  sub sp, 0x4
159F  0006 56     push si
            L0007: ax = GetCurrentTile(player);
15A7  000E 89 46 FE  mov [bp-0x2], ax
15AA  0011 B9 04 00  mov cx, 0x4
            L0014: bx = 0x164D;
15B0  0017 2E 8B 07  mov ax, [cs:bx]
15B3  001A 3B 46 FE  cmp ax, [bp-0x2]
            L001D: if (JumpEqual) goto L0025;
15B8  001F 43     inc bx
15B9  0020 43     inc bx
15BA  0021 E2 F4  loop 0x17
            L0023: goto L0031;
15BE  0025 2E FF 67 08  jmp word [cs:bx+0x8]
            L0029: si = 0x0002;
            L002C: goto L0031;
            L002E: si = 0x0001;
            L0031: Compare(GetFlag(player, 0x03, 0x05), si);
            L0044: if (JumpBelow) goto L009F;
15DF  0046 FF 76 08  push word [bp+0x8]
15E2  0049 FF 76 06  push word [bp+0x6]
15E5  004C 0E     push cs
15E6  004D E8 75 ED  call 0xedc5
            L0050: cx = PopStack(player);
            L0051: cx = PopStack(player);
15EB  0052 FF 76 08  push word [bp+0x8]
15EE  0055 FF 76 06  push word [bp+0x6]
15F1  0058 0E     push cs
15F2  0059 E8 C4 ED  call 0xee20
            L005C: cx = PopStack(player);
            L005D: cx = PopStack(player);
            L005E: ShowMessage(player, String163E); // As long as you remain in this map, you may use this door. Upon leaving the map, it will vanish.
            L006B: ax = GetCurrentTile(player);
160B  0072 89 46 FC  mov [bp-0x4], ax
160E  0075 B9 04 00  mov cx, 0x4
            L0078: bx = 0x163D;
1614  007B 2E 8B 07  mov ax, [cs:bx]
1617  007E 3B 46 FC  cmp ax, [bp-0x4]
            L0081: if (JumpEqual) goto L0089;
161C  0083 43     inc bx
161D  0084 43     inc bx
161E  0085 E2 F4  loop 0x7b
            L0087: goto L009F;
1622  0089 2E FF 67 08  jmp word [cs:bx+0x8]
1626  008D B8 9E 16  mov ax, 0x169e
            L0090: goto L0095;
            L0092: ShowMessage(player, String16E4); // You must enter the maze south of here to open it again!
1638  009F 5E     pop si
            L00A0: // restore stack ptr: sp = bp;
            L00A2: return; // RETURN;
            // Extra data: D5 00 D8 00 E6 00 EA 00 2B 16 26 16 2B 16 26 16 D5 00 D8 00 E6 00 EA 00 C7 15 C2 15 C7 15 C2 15 
        }

        private void FnNOJOIN_37(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(player);
            L000B: ShowMessage(player, String171C); // You cannot join together here.
            L0018: return; // RETURN;
        }

        private void FnPC_38(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: ax = GetCurrentTile(player) + 0x0010;
1686  000F 88 46 FF  mov [bp-0x1], al
            L0012: Compare(PartyCount(player), 0x0001);
            L001D: if (JumpBelowOrEqual) goto L003C;
            L001F: PushStack(player, 0x01);
169A  0023 8A 46 FF  mov al, [bp-0x1]
169D  0026 B4 00  mov ah, 0x0
            L0028: TeleportParty(player, 0x02, 0x01, ax, PopStack(player), isForwardMove);
            L003C: // restore stack ptr: sp = bp;
            L003E: return; // RETURN;
        }

    }
}
