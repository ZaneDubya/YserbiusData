#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Twinion.Maps {
    class TwMap33 : AMapScripted {
        protected override int MapIndex => 33;
        protected override int RandomEncounterChance => 0;
        protected override int RandomEncounterExtraCount => 2;

        public TwMap33() {
            MapEvent01 = FnCOASTER_01;
            MapEvent03 = FnCSTRMSG_03;
            MapEvent04 = FnMIRRORS_04;
            MapEvent05 = FnCAROUSEL_05;
            MapEvent06 = FnBRSRING_06;
            MapEvent07 = FnCRSLLVR_07;
            MapEvent08 = FnTOHALFWY_08;
            MapEvent09 = FnFRMHLFWY_09;
            MapEvent0A = FnPILLAR_0A;
            MapEvent0B = FnHEALFNTN_0B;
            MapEvent0C = FnMANAFNTN_0C;
            MapEvent0D = FnTOTWISTY_0D;
            MapEvent0E = FnMAJRDOMO_0E;
            MapEvent10 = FnMDMAD_10;
            MapEvent11 = FnTWISTY_11;
            MapEvent12 = FnTOOGRESS_12;
            MapEvent13 = FnOGRESS_13;
            MapEvent14 = FnTOFAKE_14;
            MapEvent15 = FnFROMFAKE_15;
            MapEvent16 = FnFAKEGRDS_16;
            MapEvent17 = FnSEETHRN_17;
            MapEvent18 = FnLAVA_18;
            MapEvent19 = FnTHRNWTR_19;
            MapEvent1A = FnTHRNPIT_1A;
            MapEvent1B = FnTREASPIT_1B;
            MapEvent1C = FnFAKECHOR_1C;
            MapEvent1D = FnFAKETOMB_1D;
            MapEvent1E = FnTWRHANOI_1E;
            MapEvent1F = FnDEATHPIT_1F;
            MapEvent20 = FnTOTAUNT_20;
            MapEvent21 = FnTAUNT_21;
            MapEvent22 = FnFRMTAUNT_22;
            MapEvent23 = FnTONEXUS_23;
            MapEvent25 = FnRIDDLCLU_25;
            MapEvent26 = FnNXSMNSTR_26;
            MapEvent27 = FnVORTEX_27;
            MapEvent28 = FnMENAGE_28;
            MapEvent29 = FnFRMMENAG_29;
            MapEvent2A = FnCRSLSTRT_2A;
            MapEvent2B = FnHLMRENCA_2B;
            MapEvent2C = FnHLMRENCB_2C;
            MapEvent2D = FnHLMRENCC_2D;
            MapEvent2F = FnNEXUSDOR_2F;
            MapEvent30 = FnFRMNEXUS_30;
            MapEvent32 = FnBLOCKWAL_32;
            MapEvent33 = FnVRTXMOV_33;
            MapEvent34 = FnFRMVRTX_34;
            MapEvent35 = FnPENALTY_35;
            MapEvent36 = FnTOHALL_36;
            MapEvent37 = FnFRMPNLTY_37;
            MapEvent38 = FnHMWELCOM_38;
            MapEvent39 = FnTWISTFLR_39;
            MapEvent3A = FnEASTRFLR_3A;
            MapEvent3C = FnEASTREGG_3C;
            MapEvent3D = FnFAKETHRN_3D;
            MapEvent3E = FnCHORGHST_3E;
            MapEvent3F = FnTOEASTER_3F;
            MapEvent40 = FnFAKETRSR_40;
            MapEvent41 = FnSETEASTR_41;
            MapEvent43 = FnTWRDESC_43;
        }
        
        // === Strings ================================================
        private const string String03FC = "ANOMIE";
        private const string String0403 = "BEWILDERMENT";
        private const string String0410 = "CONFUSION";
        private const string String041A = "DESPAIR";
        private const string String0422 = "ENNUI";
        private const string String0428 = "FATALISM";
        private const string String0431 = "GRIEF";
        private const string String0437 = "HOPELESSNESS";
        private const string String0444 = "There is a pile of moldering bones here, bound by rusty chains.";
        private const string String0484 = "A wild-eyed, delirious prisoner is slumped in the corner, confined by a glowing neck-manacle.";
        private const string String04E2 = "The prisoner rises, bows deeply, and thanks you.";
        private const string String0513 = "'I am Shelia, erstwhile architect to His Madness. I was ordered to design the chambers of this maze to be indistinguishable. But a number of them have unique features. As for the rest, perhaps a clever party could mark them also...'";
        private const string String05FC = "'I am Gravus, a Master Puzzlemaker. I created the traps here. The Puzzlers' Code prohibits divulging solutions, but listen: At least one door speaks the truth, and at least one lies. But first you must raise The Tower.";
        private const string String06D7 = "'Choronzar has been performing alchemical experiments using the precious metals. If you can complete these experiments perhaps they will help you defeat him.'";
        private const string String0776 = "'I was taken with my lady Naomi from her chamber room on the very eve of her wedding. Twas awful! Now Choronzar's stolen her spirit and locked it in a bottle so we can never leave! One of the other prisoners told me it was tossed into The Vortex.'";
        private const string String086E = "'... it's a ramshonkle junkycam ...'";
        private const string String0893 = "'... flowing with and curling in ... it doesn't make any go ...'";
        private const string String08D4 = "'... she was a beautiful lad ...'";
        private const string String08F6 = "'... the three-eyed man in the kingdom of the blind ... ' the brabham and the braugham ...'";
        private const string String0952 = "'... giant meteor, KILL ME NOW ...'";
        private const string String0976 = "'... a godzillion ... killyajolts ... a hundred jillion killyazolts ... '";
        private const string String09C0 = "'... is points-of-light happy? .... no, points-of-light is not happy ...'";
        private const string String0A0A = "The middle door does not lead to the maze.";
        private const string String0A35 = "I do not lead to the maze.";
        private const string String0A50 = "'I lead to the maze.'";
        private const string String0A66 = "Pushing the BIG RED BUTTON opens the door to the Easter Egg.";
        private const string String0AA3 = "As you step through the archway a bald, portly, little man in coat and tails hails you. 'Greetings', he beams, 'and welcome to the Halfway House! I am the Major Domo.'";
        private const string String0B4B = "The Major Domo falls into step with you. 'You look tired,' he observes, 'but you've come the right place!' He pauses to blot at his brow with a flannel kerchief. 'The pools will have you feeling right in a jiffy!'";
        private const string String0C21 = "The Major Domo continues: 'You mustn't give up, you know. A real adventurer NEVER gives up. Surrender is expressly forbidden by the Hero's Creed and reflects very poorly upon one's ancestry.'";
        private const string String0CE1 = "'And besides, you're halfway there! That's why we call this place the Halfway House, after all.  It's all downhill from here!'";
        private const string String0D60 = "The Major Domo prattles on: 'So take your time, catch your breath, and steel yourself for the glorious battles to come. Farewell!'";
        private const string String0DE3 = "The coaster cars are only big enough for one of you at a time.";
        private const string String0E22 = "The coaster stops.";
        private const string String0E35 = "You twist the Funhouse Key in the keyhole. With a lurch the car begins to rumble forward along the rails.";
        private const string String0E9F = "WELCOME TO THE FUNHOUSE!!!";
        private const string String0EBA = "Rules of the Establishment:";
        private const string String0ED6 = "1. No spitting.";
        private const string String0EE6 = "2. No cussing.";
        private const string String0EF5 = "3. Please don't feed the monsters!";
        private const string String0F18 = "     -- the Management";
        private const string String0F2F = "The roller coaster is here.";
        private const string String0F4B = "The magic mirror twists and warps your reflection.";
        private const string String0F7E = "The horse you are riding is only big enough for one. You lose your grip!";
        private const string String0FC7 = "The ride ends.";
        private const string String0FD6 = "You reach for the brass ring, but it's stuck.";
        private const string String1004 = "With a mighty tug you dislodge the brass ring from the armature.";
        private const string String1045 = "You throw the rusty knife switch.";
        private const string String1067 = "You unlock the door.";
        private const string String107C = "This door requires a special key.";
        private const string String109E = "The cool water invigorates you.";
        private const string String10BE = "The fizzy water refreshes you.";
        private const string String10DD = "The Major Domo spies you. His eyes widen and he begins to shake with rage. 'No no no! You musn't give up, whatever you do! Show some pluck, some spirit, some gumption for heaven's sake!' He begins to whack at you with an andiron.";
        private const string String11C3 = "A sign on the wall proclaims 'This way to the Ogress!'";
        private const string String11FA = "Squatting in a pile of refuse is a repulsive, mottle-skinned creature. 'Ah!' she gurgles, smacking her rubbery lips, 'You must be dinner!'";
        private const string String1285 = "Ahead of you through the layers of smoke you see a massive golden throne.";
        private const string String12CF = "As you draw closer you make out an insoucient figure lounging on the throne, dressed in jester's motley.";
        private const string String1338 = "The crazed figure on the throne stands, stares at you briefly, then prances off to the southeast, cackling like a lunatic. He dives into a pit and vanishes.";
        private const string String13D5 = "The boiling lava scorches you mildly.";
        private const string String13FB = "The brackish water offends your nostrils.";
        private const string String1425 = "You set upon Choronzar as he scurries away. 'No!,' he squeals, 'you can't do this!'";
        private const string String1479 = "A golden sarcophagus of regal dimensions glows dully in the torchlight. Upon further inspection you notice a ring-shaped indentation in the lid.";
        private const string String150A = "You place the Brass Ring in the indentation. There is a hissing sound and a flash of intense white light, then the Brass Ring is gone. A portal has opened to the west!";
        private const string String15B2 = "The small wooden disk spins into the air and lands gracefully on the next peg.";
        private const string String1601 = "The medium wooden disk spins into the air and lands gracefully on the next peg.";
        private const string String1651 = "The large wooden disk spins into the air and lands gracefully on the next peg.";
        private const string String16A0 = "There is an iron peg sticking up from the floor here. Impaled on the peg you see:";
        private const string String16F2 = "Nothing.";
        private const string String16FB = "All three wooden disks -- the completed Tower of Annoy!";
        private const string String1733 = "A large wooden disk.";
        private const string String1748 = "A medium-sized wooden disk.";
        private const string String1764 = "A small wooden disk.";
        private const string String1779 = "You plunge to your doom.";
        private const string String1792 = "A sepuchral voice speaks from the door:";
        private const string String17BA = "The door across the chasm opens and a strange figure in red and green jester's motley capers through. 'How delightful! % It is SO rare these days that I entertain mortals. %%' He grins and cocks his head, jingling the bells on his cap.";
        private const string String18A6 = "'You needn't look so crestfallen...surely you didn't mistake my little simulacrum for the real thing! %' He giggles to himself and stares vacantly into the distance for a moment.";
        private const string String1959 = "You've created quite a stir here in my household %, and I'm sure you are MOST charming -- for mortals %% -- but I really MUST insist that you leave now.";
        private const string String19F2 = "I have plans -- so MANY plans %% -- and I simply can't allow any interference from the likes of you.  I trust you know the way out. % Good Bye! %%'";
        private const string String1A86 = "Choronzar's face twists into a rictus of rage. 'What!?! ^', he shrieks. 'Still here!? ^' Frothy flecks of spittle fly from his lips.";
        private const string String1B0B = "'You poor, pathetic mortals. %^ How strange it must be to crawl about the surface of your dirty world, knowing that you are doomed to die -- like a condemned criminal who knows not when the executioner will call.";
        private const string String1BE0 = "You realize the cause is hopeless, yet you persist!' He sighs. 'So be it. % Continue on if you must, for the Riddle Room is far beyond your puny powers of comprehension. ^%' He whirls abruptly and stalks away through the door to the West.";
        private const string String1CCF = "A gleaming platinum plaque set into the floor reads: 'Riddle me this: I am He who lurks at the end of Life. Mine is the power to alter that which came before Me.'";
        private const string String1D72 = "You continue to tumble through the Vortex, buffeted by gusts of stale wind.";
        private const string String1DBE = "With a CRACK the shackles burst open in a shower of sparks.  The Hacksaw Blade has been ruined as well.";
        private const string String1E26 = "As if in a feverish dream, the prisoner cries out:";
        private const string String1E59 = "Above the door a stone tablet reads:";
        private const string String1E7E = "From the darkness above you Choronzar's voice whispers, 'Good guess! % Too bad it was WRONG. %% Welcome to the Penalty Box...'";
        private const string String1EFD = "A wooden sign hanging from the ceiling reads:";
        private const string String1F2B = "'HALL OF MIRRORS.";
        private const string String1F3D = "These mirrors show thine own face,";
        private const string String1F60 = "Distorted and impure.";
        private const string String1F76 = "But seek the dour countenance,";
        private const string String1F95 = "Brow girdled with azure.'";
        private const string String1FAF = "Your search reveals monsters!";
        private const string String1FCD = "An exquisitely delicate egg of opal and white gold rests atop a polished marble dais. Congratulations! You have found the Easter Egg.";
        private const string String2053 = "This is a massive throne carved from a single block of polished obsidian. It is inlaid with strange, beautiful sigils in delicate silver filigree.";
        private const string String20E6 = "Wailing piteously, the spirit of Choronzar drifts from his fallen body into the tomb.";
        private const string String213C = "This vast stack of ingots seems virtually inexhaustible.";
        private const string String2175 = "The Tower disks are controlled by the Funhouse Key.";
        private const string String21A9 = "UìLLÄ^&ÿð";
        private const string String21B6 = "=";
        private const string String21B9 = "t=";
        private const string String21BE = "t=";
        private const string String21C3 = "tëÆFþëÆFþë
ÆFþëÆFþÆFÿëF
´";
        private const string String21E8 = "PFÿ´";
        private const string String21EE = "PÄ^&ÿÔ";
        private const string String21F7 =         
        // === Functions ================================================
        private void FnCOASTER_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(player);
            L000B: Compare(PartyCount(player), 0x0001);
            L0016: if (JumpBelowOrEqual) goto L0054;
            L0018: ShowMessage(player, String0DE3); // The coaster cars are only big enough for one of you at a time.
            L0025: SetFlag(player, 0x03, 0x09, 0x00);
            L0039: TeleportParty(player, 0x0D, 0x02, 0xDE, 0x03, isForwardMove);
            L0054: ax = GetCurrentTile(player);
0063  005B 2D EB 00  sub ax, 0xeb
            L005E: bx = ax;
            L0060: Compare(bx, 0x14);
            L0063: if (JumpBelowOrEqual) goto L0068;
            L0065: goto L0185;
            L0068: switch (bx) {
                case 0:
                    goto L00CF;
                case 1:
                    goto L00E6;
                case 2:
                    goto L00F0;
                case 3:
                    goto L010F;
                case 4:
                    goto L01A3;
                case 5:
                    goto L01E5;
                case 6:
                    goto L01E5;
                case 7:
                    goto L01E5;
                case 8:
                    goto L01E5;
                case 9:
                    goto L01E5;
                case 10:
                    goto L01E5;
                case 11:
                    goto L01E5;
                case 12:
                    goto L01E5;
                case 13:
                    goto L01E5;
                case 14:
                    goto L01E5;
                case 15:
                    goto L01E5;
                case 16:
                    goto L01B0;
                case 17:
                    goto L01C6;
                case 18:
                    goto L01C6;
                case 19:
                    goto L01C6;
                case 20:
                    goto L01C6;
            }
            L006F: PushStack(player, 0x02);
007B  0073 C4 5E 06  les bx, [bp+0x6]
007E  0076 26 FF 9F CC 00  call far word [es:bx+0xcc]
            L007B: cx = PopStack(player);
            L007C: PushStack(player, 0x02);
0088  0080 B8 EC 00  mov ax, 0xec
            L0083: goto L0171;
            L0086: PushStack(player, 0x02);
0092  008A B8 ED 00  mov ax, 0xed
            L008D: goto L0171;
            L0090: SetFlag(player, 0x03, 0x09, 0x01);
            L00A5: PushStack(player, 0x02);
00B1  00A9 B8 EE 00  mov ax, 0xee
            L00AC: goto L0171;
            L00AF: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x00);
            L00C8: SetWallPassable(player, GetCurrentTile(player), ax, 0x00);
            L00DE: ax = IsFlagOn(player, 0x03, 0x09);
            L00F1: if (JumpEqual) goto L011D;
            L00F3: ShowMessage(player, String0E22); // The coaster stops.
            L0100: SetFlag(player, 0x03, 0x09, 0x00);
            L0114: PushStack(player, 0x03);
0120  0118 B8 DE 00  mov ax, 0xde
            L011B: goto L0171;
            L011D: ax = HasItem(player, 0xED);
            L012B: if (JumpEqual) goto L0185;
            L012D: ShowMessage(player, String0E35); // You twist the Funhouse Key in the keyhole. With a lurch the car begins to rumble forward along the rails.
            L013A: PushStack(player, 0x02);
0146  013E B8 EF 00  mov ax, 0xef
            L0141: goto L0171;
            L0143: PushStack(player, 0x03);
            L0147: PushStack(player, 0x76);
0153  014B B8 01 00  mov ax, 0x1
            L014E: goto L0175;
            L0150: PushStack(player, 0x03);
015C  0154 C4 5E 06  les bx, [bp+0x6]
015F  0157 26 FF 9F CC 00  call far word [es:bx+0xcc]
            L015C: cx = PopStack(player);
            L015D: PushStack(player, 0x03);
0169  0161 B8 EB 00  mov ax, 0xeb
            L0164: goto L0171;
            L0166: PushStack(player, 0x00);
            L0169: ax = GetCurrentTile(player);
0178  0170 48     dec ax
            L0171: TeleportParty(player, 0x0D, 0x02, ax, PopStack(player), isForwardMove);
            L0185: return; // RETURN;
        }

        private void FnCSTRMSG_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFacing(player), 0x0001);
            L000D: if (JumpEqual) goto L005C;
            L000F: Compare(ax, 0x0003);
            L0012: if (JumpEqual) goto L0016;
            L0014: goto L0069;
            L0016: ShowMessage(player, String0E9F); // WELCOME TO THE FUNHOUSE!!!
            L0023: ShowMessage(player, String0EBA); // Rules of the Establishment:
            L0030: ShowMessage(player, String0ED6); // 1. No spitting.
            L003D: ShowMessage(player, String0EE6); // 2. No cussing.
            L004A: ShowMessage(player, String0EF5); // 3. Please don't feed the monsters!
0215  0057 B8 18 0F  mov ax, 0xf18
            L005A: goto L005F;
            L005C: ShowMessage(player, String0F2F); // The roller coaster is here.
            L0069: return; // RETURN;
        }

        private void FnMIRRORS_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
022C  0003 83 EC 04  sub sp, 0x4
022F  0006 C6 46 FF F5  mov byte [bp-0x1], 0xf5
            L000A: ShowMessage(player, String0F4B); // The magic mirror twists and warps your reflection.
            L0017: ax = GetCurrentTile(player);
0247  001E 89 46 FC  mov [bp-0x4], ax
024A  0021 B9 0A 00  mov cx, 0xa
            L0024: bx = 0x0330;
0250  0027 2E 8B 07  mov ax, [cs:bx]
0253  002A 3B 46 FC  cmp ax, [bp-0x4]
            L002D: if (JumpEqual) goto L0035;
0258  002F 43     inc bx
0259  0030 43     inc bx
025A  0031 E2 F4  loop 0x27
            L0033: goto L0077;
025E  0035 2E FF 67 14  jmp word [cs:bx+0x14]
0262  0039 C6 46 FE 19  mov byte [bp-0x2], 0x19
            L003D: goto L0077;
0268  003F C6 46 FE 17  mov byte [bp-0x2], 0x17
            L0043: goto L0077;
026E  0045 C6 46 FE 18  mov byte [bp-0x2], 0x18
            L0049: goto L0077;
0274  004B C6 46 FE 16  mov byte [bp-0x2], 0x16
0278  004F C6 46 FF 36  mov byte [bp-0x1], 0x36
            L0053: goto L0077;
027E  0055 C6 46 FE 1A  mov byte [bp-0x2], 0x1a
            L0059: goto L0077;
0284  005B C6 46 FE 1B  mov byte [bp-0x2], 0x1b
            L005F: goto L0077;
028A  0061 C6 46 FE 1C  mov byte [bp-0x2], 0x1c
            L0065: goto L0077;
0290  0067 C6 46 FE 1D  mov byte [bp-0x2], 0x1d
            L006B: goto L0077;
0296  006D C6 46 FE 1E  mov byte [bp-0x2], 0x1e
            L0071: goto L0077;
029C  0073 C6 46 FE 1F  mov byte [bp-0x2], 0x1f
02A0  0077 8A 46 FE  mov al, [bp-0x2]
02A3  007A B4 00  mov ah, 0x0
            L007C: PushStack(player, ax);
02A6  007D C4 5E 06  les bx, [bp+0x6]
02A9  0080 26 FF 9F FC 00  call far word [es:bx+0xfc]
            L0085: cx = PopStack(player);
            L0086: PushStack(player, 0x01);
02B3  008A 8A 46 FF  mov al, [bp-0x1]
02B6  008D B4 00  mov ah, 0x0
            L008F: TeleportParty(player, 0x0D, 0x02, ax, PopStack(player), isForwardMove);
            L00A3: // restore stack ptr: sp = bp;
            L00A5: return; // RETURN;
            // Extra data: 8A 00 8B 00 9A 00 AB 00 BB 00 BE 00 CC 00 CF 00 DB 00 DD 00 C2 02 C8 02 CE 02 D4 02 DE 02 E4 02 EA 02 F0 02 F6 02 FC 02 
        }

        private void FnCAROUSEL_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
02FB  0003 83 EC 04  sub sp, 0x4
            L0006: SetNoJoinArea(player);
            L000E: Compare(PartyCount(player), 0x0001);
            L0019: if (JumpBelowOrEqual) goto L0042;
            L001B: ShowMessage(player, String0F7E); // The horse you are riding is only big enough for one. You lose your grip!
            L0028: TeleportParty(player, 0x0D, 0x02, 0x8D, 0x00, isForwardMove);
            L0042: ax = IsFlagOff(player, 0x03, 0x07);
            L0055: if (JumpNotEqual) goto L005A;
            L0057: goto L016F;
            L005A: ax = GetFlag(player, 0x03, 0x19);
0363  006B 88 46 FF  mov [bp-0x1], al
            L006E: ax = GetCurrentTile(player);
036D  0075 B1 08  mov cl, 0x8
036F  0077 D3 E0  shl ax, cl
            L0079: dx = ax + GetFacing(player);
037C  0084 89 56 FC  mov [bp-0x4], dx
037F  0087 B9 0B 00  mov cx, 0xb
            L008A: bx = 0x04CB;
0385  008D 2E 8B 07  mov ax, [cs:bx]
0388  0090 3B 46 FC  cmp ax, [bp-0x4]
            L0093: if (JumpEqual) goto L009C;
038D  0095 43     inc bx
038E  0096 43     inc bx
038F  0097 E2 F4  loop 0x8d
            L0099: goto L016F;
0394  009C 2E FF 67 16  jmp word [cs:bx+0x16]
0398  00A0 80 7E FF 00  cmp byte [bp-0x1], 0x0
            L00A4: if (JumpLessOrEqual) goto L00D6;
039E  00A6 FE 4E FF  dec byte [bp-0x1]
03A1  00A9 8A 46 FF  mov al, [bp-0x1]
03A4  00AC 98     cbw
            L00AD: PushStack(player, ax);
            L00AE: PushStack(player, 0x19);
            L00B2: PushStack(player, 0x03);
03AE  00B6 C4 5E 06  les bx, [bp+0x6]
03B1  00B9 26 FF 1F  call far word [es:bx]
03B4  00BC 83 C4 06  add sp, 0x6
            L00BF: PushStack(player, 0x01);
03BB  00C3 C4 5E 06  les bx, [bp+0x6]
03BE  00C6 26 FF 9F CC 00  call far word [es:bx+0xcc]
            L00CB: cx = PopStack(player);
            L00CC: PushStack(player, 0x01);
03C8  00D0 B8 9D 00  mov ax, 0x9d
            L00D3: goto L015B;
            L00D6: ShowMessage(player, String0FC7); // The ride ends.
            L00E3: PushStack(player, 0x00);
03DE  00E6 B8 8C 00  mov ax, 0x8c
            L00E9: goto L015B;
            L00EB: goto L00BF;
            L00ED: PushStack(player, 0x00);
03E8  00F0 B8 8D 00  mov ax, 0x8d
            L00F3: goto L015B;
            L00F5: PushStack(player, 0x00);
03F0  00F8 C4 5E 06  les bx, [bp+0x6]
03F3  00FB 26 FF 9F CC 00  call far word [es:bx+0xcc]
            L0100: cx = PopStack(player);
            L0101: PushStack(player, 0x00);
03FC  0104 B8 8E 00  mov ax, 0x8e
            L0107: goto L015B;
            L0109: PushStack(player, 0x01);
0405  010D B8 AD 00  mov ax, 0xad
            L0110: goto L015B;
            L0112: PushStack(player, 0x03);
040E  0116 B8 8F 00  mov ax, 0x8f
            L0119: goto L015B;
            L011B: PushStack(player, 0x02);
0417  011F C4 5E 06  les bx, [bp+0x6]
041A  0122 26 FF 9F CC 00  call far word [es:bx+0xcc]
            L0127: cx = PopStack(player);
            L0128: PushStack(player, 0x02);
0424  012C B8 AE 00  mov ax, 0xae
            L012F: goto L015B;
            L0131: PushStack(player, 0x02);
042D  0135 B8 AF 00  mov ax, 0xaf
            L0138: goto L015B;
            L013A: ShowMessage(player, String0FD6); // You reach for the brass ring, but it's stuck.
            L0147: PushStack(player, 0x03);
0443  014B C4 5E 06  les bx, [bp+0x6]
0446  014E 26 FF 9F CC 00  call far word [es:bx+0xcc]
            L0153: cx = PopStack(player);
            L0154: TeleportParty(player, 0x0D, 0x02, 0x9F, 0x03, isForwardMove);
            L016F: // restore stack ptr: sp = bp;
            L0171: return; // RETURN;
            // Extra data: 00 8D 01 8D 02 8D 03 8D 00 8E 03 8F 01 9D 03 9F 01 AD 02 AE 02 AF F8 03 43 04 43 04 43 04 45 04 4D 04 61 04 6A 04 73 04 89 04 92 04 
        }

        private void FnBRSRING_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF2);
            L0011: if (JumpNotEqual) goto L002C;
            L0013: ShowMessage(player, String1004); // With a mighty tug you dislodge the brass ring from the armature.
            L0020: GiveItem(player, 0xF2);
            L002C: return; // RETURN;
        }

        private void FnCRSLLVR_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0016: if (JumpNotEqual) goto L003A;
            L0018: ShowMessage(player, String1045); // You throw the rusty knife switch.
            L0025: SetFlag(player, 0x03, 0x07, 0x01);
            L003A: return; // RETURN;
        }

        private void FnTOHALFWY_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOn(player, 0x00, 0x01);
            L0015: if (JumpEqual) goto L0034;
            L0017: TeleportParty(player, 0x0D, 0x02, 0xC2, 0x03, isForwardMove);
            L0032: goto L0069;
            L0034: PushStack(player, 0xFA);
            L0038: PushStack(player, ax);
053A  0039 C4 5E 06  les bx, [bp+0x6]
053D  003C 26 FF 5F 54  call far word [es:bx+0x54]
            L0040: cx = PopStack(player);
            L0041: cx = PopStack(player);
            L0042: RefreshCompareFlags(ax);
            L0044: if (JumpEqual) goto L005C;
            L0046: PushStack(player, 0x01);
            L004A: PushStack(player, ax);
            L004B: PushStack(player, 0x00);
054F  004E C4 5E 06  les bx, [bp+0x6]
0552  0051 26 FF 1F  call far word [es:bx]
0555  0054 83 C4 06  add sp, 0x6
0558  0057 B8 67 10  mov ax, 0x1067
            L005A: goto L005F;
            L005C: ShowMessage(player, String107C); // This door requires a special key.
            L0069: return; // RETURN;
        }

        private void FnFRMHLFWY_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0D, 0x02, 0x67, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnPILLAR_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFloorPassable(player, 0x00, GetCurrentTile(player));
            L0017: return; // RETURN;
        }

        private void FnHEALFNTN_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, GetCurrentHits(player));
            L000B: ax = GetMaxHits(player);
            L0012: dx = PopStack(player);
05B7  0013 3B D0  cmp dx, ax
            L0015: if (JumpEqual) goto L0035;
            L0017: ShowMessage(player, String109E); // The cool water invigorates you.
            L0024: HealPlayer(player, GetMaxHits(player));
            L0035: return; // RETURN;
        }

        private void FnMANAFNTN_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String10BE); // The fizzy water refreshes you.
            L0010: AddMana(player, 0x7530);
            L001D: return; // RETURN;
        }

        private void FnTOTWISTY_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0D, 0x02, 0x30, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnMAJRDOMO_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
061D  0003 83 EC 06  sub sp, 0x6
0620  0006 C7 46 FC 00 00  mov word [bp-0x4], 0x0
0625  000B C7 46 FA 00 00  mov word [bp-0x6], 0x0
            L0010: ax = GetFlag(player, 0x03, 0x1A);
063B  0021 88 46 FF  mov [bp-0x1], al
063E  0024 80 7E FF 04  cmp byte [bp-0x1], 0x4
            L0028: if (JumpAbove) goto L0037;
            L002A: ShowPortrait(player, 0x0027);
0651  0037 8A 46 FF  mov al, [bp-0x1]
0654  003A B4 00  mov ah, 0x0
            L003C: bx = ax;
            L003E: Compare(bx, 0x04);
            L0041: if (JumpAbove) goto L007A;
            L0043: switch (bx) {
                case 0:
                    goto L00AA;
                case 1:
                    goto L00B4;
                case 2:
                    goto L00BE;
                case 3:
                    goto L00C8;
                case 4:
                    goto L00D2;
            }
0664  004A 8C 5E FC  mov [bp-0x4], ds
0667  004D C7 46 FA A3 0A  mov word [bp-0x6], 0xaa3
            L0052: goto L007A;
066E  0054 8C 5E FC  mov [bp-0x4], ds
0671  0057 C7 46 FA 4B 0B  mov word [bp-0x6], 0xb4b
            L005C: goto L007A;
0678  005E 8C 5E FC  mov [bp-0x4], ds
067B  0061 C7 46 FA 21 0C  mov word [bp-0x6], 0xc21
            L0066: goto L007A;
0682  0068 8C 5E FC  mov [bp-0x4], ds
0685  006B C7 46 FA E1 0C  mov word [bp-0x6], 0xce1
            L0070: goto L007A;
068C  0072 8C 5E FC  mov [bp-0x4], ds
068F  0075 C7 46 FA 60 0D  mov word [bp-0x6], 0xd60
0694  007A 8B 46 FA  mov ax, [bp-0x6]
0697  007D 0B 46 FC  or ax, [bp-0x4]
            L0080: if (JumpEqual) goto L00A8;
069C  0082 FE 46 FF  inc byte [bp-0x1]
069F  0085 8A 46 FF  mov al, [bp-0x1]
06A2  0088 B4 00  mov ah, 0x0
            L008A: PushStack(player, ax);
            L008B: PushStack(player, 0x1A);
            L008F: PushStack(player, 0x03);
06AD  0093 C4 5E 06  les bx, [bp+0x6]
06B0  0096 26 FF 1F  call far word [es:bx]
06B3  0099 83 C4 06  add sp, 0x6
06B6  009C FF 76 FA  push word [bp-0x6]
06B9  009F C4 5E 06  les bx, [bp+0x6]
06BC  00A2 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L00A7: cx = PopStack(player);
            L00A8: // restore stack ptr: sp = bp;
            L00AA: return; // RETURN;
        }

        private void FnMDMAD_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x1A), 0x0006);
            L0017: if (JumpNotEqual) goto L004D;
            L0019: ShowMessage(player, String10DD); // The Major Domo spies you. His eyes widen and he begins to shake with rage. 'No no no! You musn't give up, whatever you do! Show some pluck, some spirit, some gumption for heaven's sake!' He begins to whack at you with an andiron.
            L0026: SetFlag(player, 0x03, 0x1A, 0x07);
            L003B: AddEncounter(player, 0x01, 0x1A);
            L004D: return; // RETURN;
        }

        private void FnTWISTY_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0727  0003 83 EC 04  sub sp, 0x4
072A  0006 56     push si
072B  0007 57     push di
            L0008: ax = GetCurrentTile(player);
0733  000F 89 46 FE  mov [bp-0x2], ax
0736  0012 B1 08  mov cl, 0x8
0738  0014 D3 66 FE  shl word [bp-0x2], cl
            L0017: ax = GetFacing(player);
0742  001E 01 46 FE  add [bp-0x2], ax
            L0021: ax = tmp;
0748  0024 89 46 FC  mov [bp-0x4], ax
074B  0027 B9 3C 00  mov cx, 0x3c
            L002A: bx = 0x08F1;
0751  002D 2E 8B 07  mov ax, [cs:bx]
0754  0030 3B 46 FC  cmp ax, [bp-0x4]
            L0033: if (JumpEqual) goto L003C;
0759  0035 43     inc bx
075A  0036 43     inc bx
075B  0037 E2 F4  loop 0x2d
            L0039: goto L014C;
0760  003C 2E FF 67 78  jmp word [cs:bx+0x78]
            L0040: si = 0x0075;
            L0043: goto L014F;
            L0046: si = 0x0030;
            L0049: di = 0x0002;
            L004C: goto L0152;
            L004F: si = 0x0041;
            L0052: goto L014F;
            L0055: goto L0145;
            L0058: si = 0x0065;
            L005B: goto L0140;
            L005E: goto L012C;
            L0061: goto L0117;
            L0064: goto L00E2;
            L0066: // NOP
            L0067: si = 0x0077;
            L006A: goto L0148;
            L006D: goto L00AB;
            L006F: si = 0x0070;
            L0072: goto L0148;
            L0075: si = 0x0090;
            L0078: goto L0148;
            L007B: goto L0122;
            L007E: si = 0x0075;
            L0081: goto L0148;
            L0084: si = 0x0030;
            L0087: goto L014F;
            L008A: goto L00BD;
            L008C: goto L00C3;
            L008E: si = 0x0065;
            L0091: goto L014F;
            L0094: goto L00BD;
            L0096: goto L0067;
            L0098: goto L0046;
            L009A: goto L0040;
            L009C: si = 0x0066;
            L009F: goto L014F;
            L00A2: goto L0145;
            L00A5: si = 0x0074;
            L00A8: goto L0140;
            L00AB: si = 0x0040;
            L00AE: goto L0140;
            L00B1: goto L00FC;
            L00B3: goto L00C3;
            L00B5: goto L0040;
            L00B7: si = 0x0002;
            L00BA: goto L014F;
            L00BD: si = 0x0080;
            L00C0: goto L0140;
            L00C2: // NOP
            L00C3: si = 0x0090;
            L00C6: goto L014F;
            L00C9: si = 0x0075;
            L00CC: goto L0140;
            L00CE: // NOP
            L00CF: goto L0058;
            L00D1: goto L010A;
            L00D3: goto L0046;
            L00D6: si = 0x001F;
            L00D9: goto L0140;
            L00DB: si = 0x0066;
            L00DE: goto L0148;
            L00E0: goto L011C;
            L00E2: si = 0x0074;
            L00E5: goto L0049;
            L00E8: si = 0x0076;
            L00EB: goto L0140;
            L00ED: si = 0x001E;
            L00F0: goto L0140;
            L00F2: si = 0x0040;
            L00F5: goto L0148;
            L00F7: si = 0x004F;
            L00FA: goto L0148;
            L00FC: si = 0x0080;
            L00FF: goto L0049;
            L0102: goto L0112;
            L0104: si = 0x0090;
            L0107: goto L0049;
            L010A: si = 0x000B;
            L010D: goto L0148;
            L010F: goto L0046;
            L0112: si = 0x000F;
            L0115: goto L0148;
            L0117: si = 0x0066;
            L011A: goto L0140;
            L011C: si = 0x001B;
            L011F: goto L0049;
            L0122: si = 0x00A0;
            L0125: goto L0140;
            L0127: si = 0x001E;
            L012A: goto L0148;
            L012C: si = 0x0070;
            L012F: goto L014F;
            L0131: si = 0x001B;
            L0134: goto L0140;
            L0136: goto L0127;
            L0138: si = 0x000F;
            L013B: goto L014F;
            L013D: si = 0x0055;
            L0140: di = 0x0003;
            L0143: goto L0152;
            L0145: si = 0x00A0;
            L0148: di = 0;
            L014A: goto L0152;
            L014C: si = 0x00DE;
            L014F: di = 0x0001;
0876  0152 57     push di
0877  0153 56     push si
            L0154: PushStack(player, 0x02);
            L0158: PushStack(player, 0x0D);
0880  015C C4 5E 06  les bx, [bp+0x6]
0883  015F 26 FF 9F BC 00  call far word [es:bx+0xbc]
0888  0164 83 C4 08  add sp, 0x8
088B  0167 5F     pop di
088C  0168 5E     pop si
            L0169: // restore stack ptr: sp = bp;
            L016B: return; // RETURN;
            // Extra data: 00 0B 02 0B 03 0B 00 0E 02 0E 03 0E 00 0F 02 0F 03 0F 00 1B 01 1B 02 1B 00 1E 01 1E 02 1E 00 1F 01 1F 02 1F 00 30 02 30 03 30 00 40 01 40 02 40 00 4E 01 4E 03 4E 01 4F 02 4F 03 4F 00 65 01 65 03 65 01 66 02 66 03 66 00 70 02 70 03 70 00 74 01 74 03 74 01 75 02 75 03 75 00 76 01 76 03 76 01 77 02 77 03 77 00 80 01 80 02 80 00 90 02 90 03 90 00 A0 01 A0 02 A0 64 08 5F 08 5A 08 80 08 7B 08 76 08 9B 08 96 08 93 08 71 08 6C 08 66 08 8E 08 88 08 86 08 AB 08 A6 08 A0 08 D3 07 CA 07 C4 07 E2 07 DC 07 D9 07 BA 08 B5 08 B0 08 C9 08 C1 08 BC 08 35 08 2F 08 29 08 3B 08 39 08 37 08 EB 07 E8 07 E5 07 1C 08 1A 08 18 08 26 08 20 08 1E 08 4D 08 47 08 41 08 57 08 55 08 53 08 F9 07 F3 07 F1 07 08 08 02 08 FF 07 12 08 10 08 0E 08 
        }

        private void FnTOOGRESS_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String11C3); // A sign on the wall proclaims 'This way to the Ogress!'
            L0010: return; // RETURN;
        }

        private void FnOGRESS_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOff(player, 0x03, 0x1B);
            L0016: if (JumpEqual) goto L005F;
            L0018: SetFlag(player, 0x03, 0x1B, 0x01);
            L002D: ShowMessage(player, String11FA); // Squatting in a pile of refuse is a repulsive, mottle-skinned creature. 'Ah!' she gurgles, smacking her rubbery lips, 'You must be dinner!'
            L003A: PushStack(player, 0x00);
            L003D: PushStack(player, ax);
            L003E: PushStack(player, ax);
            L003F: PushStack(player, ax);
            L0040: PushStack(player, ax);
            L0041: PushStack(player, ax);
09D5  0042 C4 5E 06  les bx, [bp+0x6]
09D8  0045 26 FF 9F D8 00  call far word [es:bx+0xd8]
09DD  004A 83 C4 0C  add sp, 0xc
            L004D: AddEncounter(player, 0x01, 0x1B);
            L005F: return; // RETURN;
        }

        private void FnTOFAKE_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0D, 0x02, 0xA4, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnFROMFAKE_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0D, 0x02, 0xA4, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnFAKEGRDS_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0A37  0003 B0 19  mov al, 0x19
            L0005: PushStack(player, ax);
0A3A  0006 FF 76 08  push word [bp+0x8]
0A3D  0009 FF 76 06  push word [bp+0x6]
0A40  000C 0E     push cs
0A41  000D E8 65 F5  call 0xf575
0A44  0010 83 C4 06  add sp, 0x6
            L0013: return; // RETURN;
        }

        private void FnSEETHRN_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: ax = GetFlag(player, 0x03, 0x0C);
0A5F  0016 88 46 FF  mov [bp-0x1], al
            L0019: Compare(GetCurrentTile(player), 0x00A5);
            L0023: if (JumpEqual) goto L0031;
            L0025: Compare(ax, 0x00A6);
            L0028: if (JumpEqual) goto L004F;
            L002A: Compare(ax, 0x00A7);
            L002D: if (JumpEqual) goto L006D;
            L002F: goto L0089;
0A7A  0031 8A 46 FF  mov al, [bp-0x1]
0A7D  0034 24 01  and al, 0x1
0A7F  0036 B4 00  mov ah, 0x0
            L0038: RefreshCompareFlags(ax);
            L003A: if (JumpNotEqual) goto L0089;
            L003C: ShowMessage(player, String1285); // Ahead of you through the layers of smoke you see a massive golden throne.
0A92  0049 80 4E FF 01  or byte [bp-0x1], 0x1
            L004D: goto L0089;
0A98  004F 8A 46 FF  mov al, [bp-0x1]
0A9B  0052 24 02  and al, 0x2
0A9D  0054 B4 00  mov ah, 0x0
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L0089;
            L005A: ShowMessage(player, String12CF); // As you draw closer you make out an insoucient figure lounging on the throne, dressed in jester's motley.
0AB0  0067 80 4E FF 02  or byte [bp-0x1], 0x2
            L006B: goto L0089;
0AB6  006D 8A 46 FF  mov al, [bp-0x1]
0AB9  0070 24 04  and al, 0x4
0ABB  0072 B4 00  mov ah, 0x0
            L0074: RefreshCompareFlags(ax);
            L0076: if (JumpNotEqual) goto L0089;
            L0078: ShowMessage(player, String1338); // The crazed figure on the throne stands, stares at you briefly, then prances off to the southeast, cackling like a lunatic. He dives into a pit and vanishes.
0ACE  0085 80 4E FF 04  or byte [bp-0x1], 0x4
0AD2  0089 8A 46 FF  mov al, [bp-0x1]
0AD5  008C B4 00  mov ah, 0x0
            L008E: PushStack(player, ax);
            L008F: PushStack(player, 0x0C);
            L0093: PushStack(player, 0x03);
0AE0  0097 C4 5E 06  les bx, [bp+0x6]
0AE3  009A 26 FF 1F  call far word [es:bx]
0AE6  009D 83 C4 06  add sp, 0x6
            L00A0: // restore stack ptr: sp = bp;
            L00A2: return; // RETURN;
        }

        private void FnLAVA_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String13D5); // The boiling lava scorches you mildly.
            L0010: DamagePlayer(player, 0x0001);
            L001D: return; // RETURN;
        }

        private void FnTHRNWTR_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String13FB); // The brackish water offends your nostrils.
            L0010: return; // RETURN;
        }

        private void FnTHRNPIT_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetCurrentTile(player);
            L000A: TeleportParty(player, 0x0D, 0x02, 0xDE, 0x03, isForwardMove);
            L0025: return; // RETURN;
        }

        private void FnTREASPIT_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetCurrentTile(player), 0x00C9);
            L000D: if (JumpEqual) goto L0011;
            L000F: goto L001A;
            L0011: PushStack(player, 0x01);
0B5A  0015 B8 DA 00  mov ax, 0xda
            L0018: goto L0021;
            L001A: TeleportParty(player, 0x0D, 0x02, 0xB9, 0x03, isForwardMove);
            L0035: return; // RETURN;
        }

        private void FnFAKECHOR_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOff(player, 0x03, 0x0A);
            L0016: if (JumpEqual) goto L004C;
            L0018: SetFlag(player, 0x03, 0x0A, 0x01);
            L002D: ShowMessage(player, String1425); // You set upon Choronzar as he scurries away. 'No!,' he squeals, 'you can't do this!'
            L003A: AddEncounter(player, 0x01, 0x1C);
            L004C: return; // RETURN;
        }

        private void FnFAKETOMB_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x00);
            L0006: PushStack(player, ax);
0BD1  0007 C4 5E 06  les bx, [bp+0x6]
0BD4  000A 26 FF 5F 0C  call far word [es:bx+0xc]
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
            L0010: RefreshCompareFlags(ax);
            L0012: if (JumpEqual) goto L0032;
            L0014: PushStack(player, 0x01);
            L0018: PushStack(player, 0x00);
            L001B: PushStack(player, ax);
0BE6  001C C4 5E 06  les bx, [bp+0x6]
0BE9  001F 26 FF 1F  call far word [es:bx]
0BEC  0022 83 C4 06  add sp, 0x6
            L0025: ShowMessage(player, String1479); // A golden sarcophagus of regal dimensions glows dully in the torchlight. Upon further inspection you notice a ring-shaped indentation in the lid.
            L0032: PushStack(player, 0xF2);
            L0036: PushStack(player, ax);
0C01  0037 C4 5E 06  les bx, [bp+0x6]
0C04  003A 26 FF 5F 54  call far word [es:bx+0x54]
            L003E: cx = PopStack(player);
            L003F: cx = PopStack(player);
            L0040: RefreshCompareFlags(ax);
            L0042: if (JumpNotEqual) goto L0047;
            L0044: goto L00F6;
            L0047: ax = IsFlagOff(player, 0x00, 0x01);
            L0059: if (JumpEqual) goto L006C;
            L005B: PushStack(player, 0x01);
            L005F: PushStack(player, ax);
            L0060: PushStack(player, 0x00);
0C2D  0063 C4 5E 06  les bx, [bp+0x6]
0C30  0066 26 FF 1F  call far word [es:bx]
0C33  0069 83 C4 06  add sp, 0x6
            L006C: ShowMessage(player, String150A); // You place the Brass Ring in the indentation. There is a hissing sound and a flash of intense white light, then the Brass Ring is gone. A portal has opened to the west!
            L0079: RemoveItem(player, 0xF2);
            L0085: PushStack(player, 0x01);
            L0089: PushStack(player, 0x00);
            L008C: PushStack(player, GetCurrentTile(player));
0C5E  0094 C4 5E 06  les bx, [bp+0x6]
0C61  0097 26 FF 5F 28  call far word [es:bx+0x28]
0C65  009B 83 C4 06  add sp, 0x6
            L009E: SetWallPassable(player, GetCurrentTile(player), 0x00, 0x01);
            L00B7: SetFlag(player, 0x03, 0x04, 0x01);
            L00CC: SetFlag(player, 0x03, 0x05, 0x02);
            L00E1: SetFlag(player, 0x03, 0x06, 0x04);
            L00F6: return; // RETURN;
        }

        private void FnTWRHANOI_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0CC5  0003 83 EC 08  sub sp, 0x8
0CC8  0006 56     push si
0CC9  0007 C6 46 FC 64  mov byte [bp-0x4], 0x64
0CCD  000B C6 46 FB 01  mov byte [bp-0x5], 0x1
0CD1  000F C6 46 FA 01  mov byte [bp-0x6], 0x1
            L0013: si = GetCurrentTile(player);
            L001C: Compare(ax, 0x00D6);
            L001F: if (JumpEqual) goto L002D;
            L0021: Compare(ax, 0x00E6);
            L0024: if (JumpEqual) goto L0033;
            L0026: Compare(ax, 0x00F6);
            L0029: if (JumpEqual) goto L0039;
            L002B: goto L003D;
0CEF  002D C6 46 FD 00  mov byte [bp-0x3], 0x0
            L0031: goto L003D;
0CF5  0033 C6 46 FD 01  mov byte [bp-0x3], 0x1
            L0037: goto L003D;
0CFB  0039 C6 46 FD 02  mov byte [bp-0x3], 0x2
0CFF  003D 8A 46 FD  mov al, [bp-0x3]
0D02  0040 B4 00  mov ah, 0x0
            L0042: PushStack(player, ax + 0x0004);
            L0046: PushStack(player, 0x03);
0D0C  004A C4 5E 06  les bx, [bp+0x6]
0D0F  004D 26 FF 5F 04  call far word [es:bx+0x4]
            L0051: cx = PopStack(player);
            L0052: cx = PopStack(player);
0D15  0053 88 46 FF  mov [bp-0x1], al
            L0056: PushStack(player, 0xED);
            L005A: PushStack(player, ax);
0D1D  005B C4 5E 06  les bx, [bp+0x6]
0D20  005E 26 FF 5F 54  call far word [es:bx+0x54]
            L0062: cx = PopStack(player);
            L0063: cx = PopStack(player);
            L0064: RefreshCompareFlags(ax);
            L0066: if (JumpNotEqual) goto L006B;
            L0068: goto L019B;
0D2D  006B B1 08  mov cl, 0x8
0D2F  006D D3 E6  shl si, cl
            L006F: ax = GetFacing(player);
0D38  0076 0B F0  or si, ax
0D3A  0078 89 76 F8  mov [bp-0x8], si
0D3D  007B B9 04 00  mov cx, 0x4
            L007E: bx = 0x0F4F;
0D43  0081 2E 8B 07  mov ax, [cs:bx]
0D46  0084 3B 46 F8  cmp ax, [bp-0x8]
            L0087: if (JumpEqual) goto L008F;
0D4B  0089 43     inc bx
0D4C  008A 43     inc bx
0D4D  008B E2 F4  loop 0x81
            L008D: goto L00A7;
0D51  008F 2E FF 67 08  jmp word [cs:bx+0x8]
            L0093: goto L00A3;
            L0095: goto L00A3;
0D59  0097 C6 46 FC 00  mov byte [bp-0x4], 0x0
            L009B: goto L00A7;
0D5F  009D C6 46 FC 02  mov byte [bp-0x4], 0x2
            L00A1: goto L00A7;
0D65  00A3 C6 46 FC 01  mov byte [bp-0x4], 0x1
0D69  00A7 80 7E FC 64  cmp byte [bp-0x4], 0x64
            L00AB: if (JumpNotEqual) goto L00B0;
            L00AD: goto L019B;
0D72  00B0 8A 46 FC  mov al, [bp-0x4]
0D75  00B3 B4 00  mov ah, 0x0
            L00B5: PushStack(player, ax + 0x0004);
            L00B9: PushStack(player, 0x03);
0D7F  00BD C4 5E 06  les bx, [bp+0x6]
0D82  00C0 26 FF 5F 04  call far word [es:bx+0x4]
            L00C4: cx = PopStack(player);
            L00C5: cx = PopStack(player);
0D88  00C6 88 46 FE  mov [bp-0x2], al
0D8B  00C9 80 4E FF 08  or byte [bp-0x1], 0x8
            L00CD: goto L00D2;
0D91  00CF D0 66 FB  shl byte [bp-0x5], 1
0D94  00D2 8A 46 FF  mov al, [bp-0x1]
0D97  00D5 22 46 FB  and al, [bp-0x5]
0D9A  00D8 B4 00  mov ah, 0x0
            L00DA: RefreshCompareFlags(ax);
            L00DC: if (JumpEqual) goto L00CF;
0DA0  00DE 80 66 FF 07  and byte [bp-0x1], 0x7
0DA4  00E2 80 66 FB 07  and byte [bp-0x5], 0x7
0DA8  00E6 80 4E FE 08  or byte [bp-0x2], 0x8
            L00EA: goto L00EF;
0DAE  00EC D0 66 FA  shl byte [bp-0x6], 1
0DB1  00EF 8A 46 FE  mov al, [bp-0x2]
0DB4  00F2 22 46 FA  and al, [bp-0x6]
0DB7  00F5 B4 00  mov ah, 0x0
            L00F7: RefreshCompareFlags(ax);
            L00F9: if (JumpEqual) goto L00EC;
0DBD  00FB 80 66 FE 07  and byte [bp-0x2], 0x7
0DC1  00FF 80 66 FA 07  and byte [bp-0x6], 0x7
0DC5  0103 80 7E FB 00  cmp byte [bp-0x5], 0x0
            L0107: if (JumpNotEqual) goto L010C;
            L0109: goto L019B;
0DCE  010C 80 7E FA 00  cmp byte [bp-0x6], 0x0
            L0110: if (JumpEqual) goto L011D;
0DD4  0112 8A 46 FB  mov al, [bp-0x5]
0DD7  0115 3A 46 FA  cmp al, [bp-0x6]
            L0118: if (JumpBelow) goto L011D;
            L011A: goto L019B;
            L011C: // NOP
0DDF  011D 8A 46 FB  mov al, [bp-0x5]
0DE2  0120 B4 00  mov ah, 0x0
            L0122: Compare(ax, 0x0001);
            L0125: if (JumpEqual) goto L0133;
            L0127: Compare(ax, 0x0002);
            L012A: if (JumpEqual) goto L0138;
            L012C: Compare(ax, 0x0003);
            L012F: if (JumpEqual) goto L013D;
            L0131: goto L014A;
0DF5  0133 B8 B2 15  mov ax, 0x15b2
            L0136: goto L0140;
0DFA  0138 B8 01 16  mov ax, 0x1601
            L013B: goto L0140;
            L013D: ShowMessage(player, String1651); // The large wooden disk spins into the air and lands gracefully on the next peg.
0E0C  014A 8A 46 FB  mov al, [bp-0x5]
0E0F  014D 08 46 FE  or [bp-0x2], al
0E12  0150 F6 D0  not al
0E14  0152 20 46 FF  and [bp-0x1], al
0E17  0155 8A 46 FF  mov al, [bp-0x1]
0E1A  0158 B4 00  mov ah, 0x0
            L015A: PushStack(player, ax);
0E1D  015B 8A 46 FD  mov al, [bp-0x3]
0E20  015E B4 00  mov ah, 0x0
            L0160: PushStack(player, ax + 0x0004);
            L0164: PushStack(player, 0x03);
0E2A  0168 C4 5E 06  les bx, [bp+0x6]
0E2D  016B 26 FF 1F  call far word [es:bx]
0E30  016E 83 C4 06  add sp, 0x6
0E33  0171 8A 46 FE  mov al, [bp-0x2]
0E36  0174 B4 00  mov ah, 0x0
            L0176: PushStack(player, ax);
0E39  0177 8A 46 FC  mov al, [bp-0x4]
0E3C  017A B4 00  mov ah, 0x0
            L017C: PushStack(player, ax + 0x0004);
            L0180: PushStack(player, 0x03);
0E46  0184 C4 5E 06  les bx, [bp+0x6]
0E49  0187 26 FF 1F  call far word [es:bx]
0E4C  018A 83 C4 06  add sp, 0x6
            L018D: PushStack(player, 0x00);
            L0190: PushStack(player, ax);
            L0191: PushStack(player, ax);
0E54  0192 C4 5E 06  les bx, [bp+0x6]
0E57  0195 26 FF 1F  call far word [es:bx]
0E5A  0198 83 C4 06  add sp, 0x6
            L019B: PushStack(player, 0x00);
            L019E: PushStack(player, ax);
0E61  019F C4 5E 06  les bx, [bp+0x6]
0E64  01A2 26 FF 5F 0C  call far word [es:bx+0xc]
            L01A6: cx = PopStack(player);
            L01A7: cx = PopStack(player);
            L01A8: RefreshCompareFlags(ax);
            L01AA: if (JumpNotEqual) goto L01AF;
            L01AC: goto L0228;
            L01AE: // NOP
            L01AF: PushStack(player, 0x01);
            L01B3: PushStack(player, 0x00);
            L01B6: PushStack(player, ax);
0E79  01B7 C4 5E 06  les bx, [bp+0x6]
0E7C  01BA 26 FF 1F  call far word [es:bx]
0E7F  01BD 83 C4 06  add sp, 0x6
            L01C0: ShowMessage(player, String16A0); // There is an iron peg sticking up from the floor here. Impaled on the peg you see:
0E8F  01CD 80 7E FF 00  cmp byte [bp-0x1], 0x0
            L01D1: if (JumpNotEqual) goto L01D8;
0E95  01D3 B8 F2 16  mov ax, 0x16f2
            L01D6: goto L021E;
0E9A  01D8 80 7E FF 07  cmp byte [bp-0x1], 0x7
            L01DC: if (JumpNotEqual) goto L01E3;
0EA0  01DE B8 FB 16  mov ax, 0x16fb
            L01E1: goto L021E;
0EA5  01E3 8A 46 FF  mov al, [bp-0x1]
0EA8  01E6 B4 00  mov ah, 0x0
0EAA  01E8 A9 04 00  test ax, 0x4
            L01EB: if (JumpEqual) goto L01FA;
            L01ED: ShowMessage(player, String1733); // A large wooden disk.
0EBC  01FA 8A 46 FF  mov al, [bp-0x1]
0EBF  01FD B4 00  mov ah, 0x0
0EC1  01FF A9 02 00  test ax, 0x2
            L0202: if (JumpEqual) goto L0211;
            L0204: ShowMessage(player, String1748); // A medium-sized wooden disk.
0ED3  0211 8A 46 FF  mov al, [bp-0x1]
0ED6  0214 B4 00  mov ah, 0x0
0ED8  0216 A9 01 00  test ax, 0x1
            L0219: if (JumpEqual) goto L0228;
            L021B: ShowMessage(player, String1764); // A small wooden disk.
0EEA  0228 5E     pop si
            L0229: // restore stack ptr: sp = bp;
            L022B: return; // RETURN;
            // Extra data: 01 D6 01 E6 03 E6 03 F6 B7 0D BF 0D B9 0D C5 0D 
        }

        private void FnDEATHPIT_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOff(player, 0x03, 0x08);
            L0016: if (JumpEqual) goto L0036;
            L0018: ShowMessage(player, String1779); // You plunge to your doom.
            L0025: DamagePlayer(player, GetMaxHits(player));
            L0036: return; // RETURN;
        }

        private void FnTOTAUNT_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0F3A  0003 83 EC 06  sub sp, 0x6
0F3D  0006 C7 46 FE 00 00  mov word [bp-0x2], 0x0
0F42  000B C7 46 FC 00 00  mov word [bp-0x4], 0x0
            L0010: Compare(GetCurrentTile(player), 0x00D6);
            L001A: if (JumpEqual) goto L0028;
            L001C: Compare(ax, 0x00E6);
            L001F: if (JumpEqual) goto L0036;
            L0021: Compare(ax, 0x00F6);
            L0024: if (JumpEqual) goto L0044;
            L0026: goto L0050;
0F5F  0028 8C 5E FE  mov [bp-0x2], ds
0F62  002B C7 46 FC 0A 0A  mov word [bp-0x4], 0xa0a
0F67  0030 C6 46 FB 00  mov byte [bp-0x5], 0x0
            L0034: goto L0050;
0F6D  0036 8C 5E FE  mov [bp-0x2], ds
0F70  0039 C7 46 FC 35 0A  mov word [bp-0x4], 0xa35
0F75  003E C6 46 FB 01  mov byte [bp-0x5], 0x1
            L0042: goto L0050;
0F7B  0044 8C 5E FE  mov [bp-0x2], ds
0F7E  0047 C7 46 FC 50 0A  mov word [bp-0x4], 0xa50
0F83  004C C6 46 FB 02  mov byte [bp-0x5], 0x2
            L0050: PushStack(player, 0x00);
            L0053: PushStack(player, ax);
0F8B  0054 C4 5E 06  les bx, [bp+0x6]
0F8E  0057 26 FF 5F 0C  call far word [es:bx+0xc]
            L005B: cx = PopStack(player);
            L005C: cx = PopStack(player);
            L005D: RefreshCompareFlags(ax);
            L005F: if (JumpEqual) goto L008B;
            L0061: PushStack(player, 0x01);
            L0065: PushStack(player, 0x00);
            L0068: PushStack(player, ax);
0FA0  0069 C4 5E 06  les bx, [bp+0x6]
0FA3  006C 26 FF 1F  call far word [es:bx]
0FA6  006F 83 C4 06  add sp, 0x6
            L0072: ShowMessage(player, String1792); // A sepuchral voice speaks from the door:
0FB6  007F FF 76 FC  push word [bp-0x4]
0FB9  0082 C4 5E 06  les bx, [bp+0x6]
0FBC  0085 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L008A: cx = PopStack(player);
0FC2  008B 8A 46 FB  mov al, [bp-0x5]
0FC5  008E B4 00  mov ah, 0x0
            L0090: PushStack(player, ax + 0x0004);
            L0094: PushStack(player, 0x03);
0FCF  0098 C4 5E 06  les bx, [bp+0x6]
0FD2  009B 26 FF 5F 04  call far word [es:bx+0x4]
            L009F: cx = PopStack(player);
            L00A0: cx = PopStack(player);
0FD8  00A1 88 46 FA  mov [bp-0x6], al
0FDB  00A4 80 7E FA 07  cmp byte [bp-0x6], 0x7
            L00A8: if (JumpNotEqual) goto L00E3;
0FE1  00AA 8A 46 FB  mov al, [bp-0x5]
0FE4  00AD B4 00  mov ah, 0x0
            L00AF: RefreshCompareFlags(ax);
            L00B1: if (JumpEqual) goto L00BF;
            L00B3: Compare(ax, 0x0001);
            L00B6: if (JumpEqual) goto L00C8;
            L00B8: Compare(ax, 0x0002);
            L00BB: if (JumpEqual) goto L00C8;
            L00BD: goto L00E3;
            L00BF: PushStack(player, 0x01);
0FFA  00C3 B8 B0 00  mov ax, 0xb0
            L00C6: goto L00CF;
            L00C8: TeleportParty(player, 0x0D, 0x02, 0xF5, 0x01, isForwardMove);
            L00E3: // restore stack ptr: sp = bp;
            L00E5: return; // RETURN;
        }

        private void FnTAUNT_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: ax = GetFlag(player, 0x02, 0x39);
1034  0016 25 04 00  and ax, 0x4
            L0019: RefreshCompareFlags(ax);
            L001B: if (JumpEqual) goto L0020;
            L001D: goto L00BE;
            L0020: PushStack(player, 0x03);
            L0024: PushStack(player, ax);
1043  0025 C4 5E 06  les bx, [bp+0x6]
1046  0028 26 FF 5F 04  call far word [es:bx+0x4]
            L002C: cx = PopStack(player);
            L002D: cx = PopStack(player);
104C  002E 88 46 FF  mov [bp-0x1], al
104F  0031 80 7E FF 01  cmp byte [bp-0x1], 0x1
            L0035: if (JumpAbove) goto L0044;
            L0037: ShowPortrait(player, 0x001F);
1062  0044 8A 46 FF  mov al, [bp-0x1]
1065  0047 B4 00  mov ah, 0x0
            L0049: RefreshCompareFlags(ax);
            L004B: if (JumpEqual) goto L0054;
            L004D: Compare(ax, 0x0001);
            L0050: if (JumpEqual) goto L0080;
            L0052: goto L00A7;
            L0054: ShowMessage(player, String17BA); // The door across the chasm opens and a strange figure in red and green jester's motley capers through. 'How delightful! % It is SO rare these days that I entertain mortals. %%' He grins and cocks his head, jingling the bells on his cap.
            L0061: ShowMessage(player, String18A6); // 'You needn't look so crestfallen...surely you didn't mistake my little simulacrum for the real thing! %' He giggles to himself and stares vacantly into the distance for a moment.
            L006E: ShowMessage(player, String1959); // You've created quite a stir here in my household %, and I'm sure you are MOST charming -- for mortals %% -- but I really MUST insist that you leave now.
1099  007B B8 F2 19  mov ax, 0x19f2
            L007E: goto L009D;
            L0080: ShowMessage(player, String1A86); // Choronzar's face twists into a rictus of rage. 'What!?! ^', he shrieks. 'Still here!? ^' Frothy flecks of spittle fly from his lips.
            L008D: ShowMessage(player, String1B0B); // 'You poor, pathetic mortals. %^ How strange it must be to crawl about the surface of your dirty world, knowing that you are doomed to die -- like a condemned criminal who knows not when the executioner will call.
            L009A: ShowMessage(player, String1BE0); // You realize the cause is hopeless, yet you persist!' He sighs. 'So be it. % Continue on if you must, for the Riddle Room is far beyond your puny powers of comprehension. ^%' He whirls abruptly and stalks away through the door to the West.
10C5  00A7 FE 46 FF  inc byte [bp-0x1]
10C8  00AA 8A 46 FF  mov al, [bp-0x1]
10CB  00AD B4 00  mov ah, 0x0
            L00AF: PushStack(player, ax);
            L00B0: PushStack(player, 0x03);
            L00B4: PushStack(player, ax);
10D3  00B5 C4 5E 06  les bx, [bp+0x6]
10D6  00B8 26 FF 1F  call far word [es:bx]
10D9  00BB 83 C4 06  add sp, 0x6
            L00BE: // restore stack ptr: sp = bp;
            L00C0: return; // RETURN;
        }

        private void FnFRMTAUNT_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0D, 0x02, 0xE6, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTONEXUS_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetCurrentTile(player), 0x001D);
            L000D: if (JumpEqual) goto L001F;
            L000F: Compare(ax, 0x00F2);
            L0012: if (JumpEqual) goto L0016;
            L0014: goto L0028;
            L0016: PushStack(player, 0x03);
111A  001A B8 7B 00  mov ax, 0x7b
            L001D: goto L002F;
            L001F: PushStack(player, 0x03);
1123  0023 B8 16 00  mov ax, 0x16
            L0026: goto L002F;
            L0028: TeleportParty(player, 0x0D, 0x02, 0xF5, 0x01, isForwardMove);
            L0043: return; // RETURN;
        }

        private void FnRIDDLCLU_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1CCF); // A gleaming platinum plaque set into the floor reads: 'Riddle me this: I am He who lurks at the end of Life. Mine is the power to alter that which came before Me.'
            L0010: return; // RETURN;
        }

        private void FnNXSMNSTR_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
115F  0003 83 EC 04  sub sp, 0x4
            L0006: ax = GetCurrentTile(player);
1169  000D 89 46 FC  mov [bp-0x4], ax
116C  0010 B9 20 00  mov cx, 0x20
            L0013: bx = 0x1213;
1172  0016 2E 8B 07  mov ax, [cs:bx]
1175  0019 3B 46 FC  cmp ax, [bp-0x4]
            L001C: if (JumpEqual) goto L0024;
117A  001E 43     inc bx
117B  001F 43     inc bx
117C  0020 E2 F4  loop 0x16
            L0022: goto L0042;
1180  0024 2E FF 67 40  jmp word [cs:bx+0x40]
1184  0028 C7 46 FE 1D 00  mov word [bp-0x2], 0x1d
            L002D: goto L0042;
118B  002F C7 46 FE 1E 00  mov word [bp-0x2], 0x1e
            L0034: goto L0042;
1192  0036 C7 46 FE 1F 00  mov word [bp-0x2], 0x1f
            L003B: goto L0042;
1199  003D C7 46 FE 20 00  mov word [bp-0x2], 0x20
119E  0042 8A 46 FE  mov al, [bp-0x2]
            L0045: PushStack(player, ax);
11A2  0046 FF 76 08  push word [bp+0x8]
11A5  0049 FF 76 06  push word [bp+0x6]
11A8  004C 0E     push cs
11A9  004D E8 FD ED  call 0xee4d
11AC  0050 83 C4 06  add sp, 0x6
            L0053: // restore stack ptr: sp = bp;
            L0055: return; // RETURN;
            // Extra data: 08 00 09 00 0A 00 0C 00 0D 00 18 00 19 00 1A 00 1C 00 1D 00 28 00 2E 00 2F 00 37 00 38 00 3E 00 3F 00 47 00 48 00 58 00 5E 00 5F 00 68 00 6E 00 6F 00 78 00 79 00 7A 00 7C 00 7D 00 7E 00 7F 00 F9 11 F2 11 EB 11 F2 11 EB 11 F2 11 F9 11 E4 11 E4 11 F9 11 EB 11 F9 11 F2 11 F9 11 E4 11 E4 11 EB 11 F2 11 EB 11 E4 11 E4 11 EB 11 F9 11 F9 11 F2 11 F2 11 EB 11 E4 11 E4 11 EB 11 F2 11 F9 11 
        }

        private void FnVORTEX_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
1236  0003 83 EC 04  sub sp, 0x4
1239  0006 56     push si
123A  0007 C4 5E 06  les bx, [bp+0x6]
123D  000A 26 FF 9F E8 00  call far word [es:bx+0xe8]
            L000F: ShowMessage(player, String1D72); // You continue to tumble through the Vortex, buffeted by gusts of stale wind.
            L001C: ax = GetFlag(player, 0x03, 0x1E);
1260  002D 88 46 FF  mov [bp-0x1], al
1263  0030 B4 00  mov ah, 0x0
1265  0032 40     inc ax
            L0033: PushStack(player, ax);
            L0034: PushStack(player, 0x1E);
            L0038: PushStack(player, 0x03);
126F  003C C4 5E 06  les bx, [bp+0x6]
1272  003F 26 FF 1F  call far word [es:bx]
1275  0042 83 C4 06  add sp, 0x6
1278  0045 8A 46 FF  mov al, [bp-0x1]
127B  0048 B4 00  mov ah, 0x0
            L004A: bx = 0x0009;
            L004D: dx = ax % bx; ax = ax / bx;
1283  0050 8B DA  mov bx, dx
            L0052: Compare(bx, 0x07);
            L0055: if (JumpAbove) goto L00A6;
            L0057: switch (bx) {
                case 0:
                    goto L00BE;
                case 1:
                    goto L00C8;
                case 2:
                    goto L00D2;
                case 3:
                    goto L00DC;
                case 4:
                    goto L00E6;
                case 5:
                    goto L00EC;
                case 6:
                    goto L00F2;
                case 7:
                    goto L00FC;
            }
1291  005E C6 46 FD 26  mov byte [bp-0x3], 0x26
1295  0062 C6 46 FC 03  mov byte [bp-0x4], 0x3
            L0066: goto L00AE;
129B  0068 C6 46 FD 07  mov byte [bp-0x3], 0x7
129F  006C C6 46 FC 00  mov byte [bp-0x4], 0x0
            L0070: goto L00AE;
12A5  0072 C6 46 FD 15  mov byte [bp-0x3], 0x15
12A9  0076 C6 46 FC 02  mov byte [bp-0x4], 0x2
            L007A: goto L00AE;
12AF  007C C6 46 FD 05  mov byte [bp-0x3], 0x5
12B3  0080 C6 46 FC 02  mov byte [bp-0x4], 0x2
            L0084: goto L00AE;
12B9  0086 C6 46 FD 16  mov byte [bp-0x3], 0x16
            L008A: goto L0062;
12BF  008C C6 46 FD 27  mov byte [bp-0x3], 0x27
            L0090: goto L0096;
12C5  0092 C6 46 FD 17  mov byte [bp-0x3], 0x17
12C9  0096 C6 46 FC 00  mov byte [bp-0x4], 0x0
            L009A: goto L00AE;
12CF  009C C6 46 FD 25  mov byte [bp-0x3], 0x25
12D3  00A0 C6 46 FC 02  mov byte [bp-0x4], 0x2
            L00A4: goto L00AE;
12D9  00A6 C6 46 FD 06  mov byte [bp-0x3], 0x6
12DD  00AA C6 46 FC 01  mov byte [bp-0x4], 0x1
            L00AE: Compare(GetCurrentTile(player), 0x0006);
            L00B8: if (JumpNotEqual) goto L00C7;
            L00BA: PushStack(player, 0x03);
            L00BE: PushStack(player, 0x06);
12F5  00C2 B8 02 00  mov ax, 0x2
            L00C5: goto L00D1;
            L00C7: SetWallObject(player, 0x00, 0x06, 0x03);
130F  00DC 8A 46 FD  mov al, [bp-0x3]
1312  00DF B4 00  mov ah, 0x0
            L00E1: PushStack(player, ax);
            L00E2: PushStack(player, 0x00);
            L00E5: PushStack(player, 0x03);
131C  00E9 C4 5E 06  les bx, [bp+0x6]
131F  00EC 26 FF 1F  call far word [es:bx]
1322  00EF 83 C4 06  add sp, 0x6
1325  00F2 8A 46 FC  mov al, [bp-0x4]
1328  00F5 B4 00  mov ah, 0x0
            L00F7: PushStack(player, ax);
            L00F8: PushStack(player, 0x01);
            L00FC: PushStack(player, 0x03);
1333  0100 C4 5E 06  les bx, [bp+0x6]
1336  0103 26 FF 1F  call far word [es:bx]
1339  0106 83 C4 06  add sp, 0x6
133C  0109 80 7E FF 00  cmp byte [bp-0x1], 0x0
            L010D: if (JumpEqual) goto L0124;
1342  010F 8A 46 FF  mov al, [bp-0x1]
1345  0112 B4 00  mov ah, 0x0
            L0114: bx = 0x0007;
            L0117: dx = ax % bx; ax = ax / bx;
134D  011A 0B D2  or dx, dx
            L011C: if (JumpNotEqual) goto L0124;
1351  011E C6 46 FE E7  mov byte [bp-0x2], 0xe7
            L0122: goto L0128;
1357  0124 C6 46 FE C1  mov byte [bp-0x2], 0xc1
135B  0128 8A 46 FF  mov al, [bp-0x1]
135E  012B B4 00  mov ah, 0x0
            L012D: bx = 0x0003;
            L0130: dx = ax % bx; ax = ax / bx;
1366  0133 88 56 FF  mov [bp-0x1], dl
            L0136: PushStack(player, 0x00);
            L0139: PushStack(player, 0xC1);
1370  013D 8A 46 FE  mov al, [bp-0x2]
1373  0140 B4 00  mov ah, 0x0
            L0142: PushStack(player, ax);
            L0143: PushStack(player, 0xC1);
            L0147: PushStack(player, ax);
            L0148: PushStack(player, ax);
137C  0149 C4 5E 06  les bx, [bp+0x6]
137F  014C 26 FF 9F D8 00  call far word [es:bx+0xd8]
1384  0151 83 C4 0C  add sp, 0xc
            L0154: si = 0x0001;
            L0157: goto L016E;
138C  0159 8A 46 FF  mov al, [bp-0x1]
138F  015C B4 00  mov ah, 0x0
            L015E: AddEncounter(player, si, ax + 0x0024);
            L016D: si = si + 1;
            L016E: ax = PartyCount(player);
13A9  0176 40     inc ax
            L0177: Compare(ax, si);
            L0179: if (JumpNotBelow) goto L0159;
13AE  017B 5E     pop si
            L017C: // restore stack ptr: sp = bp;
            L017E: return; // RETURN;
        }

        private void FnMENAGE_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
13C6  0003 83 EC 0C  sub sp, 0xc
13C9  0006 C7 46 FE 00 00  mov word [bp-0x2], 0x0
13CE  000B C7 46 FC 00 00  mov word [bp-0x4], 0x0
13D3  0010 C7 46 FA 00 00  mov word [bp-0x6], 0x0
13D8  0015 C7 46 F8 00 00  mov word [bp-0x8], 0x0
            L001A: PushStack(player, 0xFB);
            L001E: PushStack(player, ax);
13E2  001F C4 5E 06  les bx, [bp+0x6]
13E5  0022 26 FF 5F 54  call far word [es:bx+0x54]
            L0026: cx = PopStack(player);
            L0027: cx = PopStack(player);
            L0028: RefreshCompareFlags(ax);
            L002A: if (JumpNotEqual) goto L002F;
            L002C: goto L00CE;
            L002F: ax = IsFlagOff(player, 0x00, 0x01);
            L0041: if (JumpNotEqual) goto L0046;
            L0043: goto L00CE;
            L0046: PushStack(player, 0x01);
            L004A: PushStack(player, ax);
            L004B: PushStack(player, 0x00);
1411  004E C4 5E 06  les bx, [bp+0x6]
1414  0051 26 FF 1F  call far word [es:bx]
1417  0054 83 C4 06  add sp, 0x6
            L0057: ShowMessage(player, String1DBE); // With a CRACK the shackles burst open in a shower of sparks.  The Hacksaw Blade has been ruined as well.
            L0064: RemoveItem(player, 0xFB);
            L0070: ax = GetCurrentTile(player);
143A  0077 89 46 F6  mov [bp-0xa], ax
143D  007A B9 07 00  mov cx, 0x7
            L007D: bx = 0x1672;
1443  0080 2E 8B 07  mov ax, [cs:bx]
1446  0083 3B 46 F6  cmp ax, [bp-0xa]
            L0086: if (JumpEqual) goto L008F;
144B  0088 43     inc bx
144C  0089 43     inc bx
144D  008A E2 F4  loop 0x80
            L008C: goto L01FA;
1452  008F 2E FF 67 0E  jmp word [cs:bx+0xe]
1456  0093 8C 5E FE  mov [bp-0x2], ds
1459  0096 C7 46 FC E2 04  mov word [bp-0x4], 0x4e2
            L009B: goto L01FA;
1461  009E 8C 5E FE  mov [bp-0x2], ds
1464  00A1 C7 46 FC 13 05  mov word [bp-0x4], 0x513
            L00A6: goto L01FA;
146C  00A9 8C 5E FE  mov [bp-0x2], ds
146F  00AC C7 46 FC 76 07  mov word [bp-0x4], 0x776
            L00B1: goto L01FA;
            L00B4: goto L0093;
1479  00B6 8C 5E FE  mov [bp-0x2], ds
147C  00B9 C7 46 FC D7 06  mov word [bp-0x4], 0x6d7
            L00BE: goto L01FA;
1484  00C1 8C 5E FE  mov [bp-0x2], ds
1487  00C4 C7 46 FC FC 05  mov word [bp-0x4], 0x5fc
            L00C9: goto L01FA;
            L00CC: goto L0093;
            L00CE: PushStack(player, 0x00);
            L00D1: PushStack(player, ax);
1495  00D2 C4 5E 06  les bx, [bp+0x6]
1498  00D5 26 FF 5F 0C  call far word [es:bx+0xc]
            L00D9: cx = PopStack(player);
            L00DA: cx = PopStack(player);
            L00DB: RefreshCompareFlags(ax);
            L00DD: if (JumpNotEqual) goto L00E2;
            L00DF: goto L01FA;
            L00E2: PushStack(player, 0x01);
            L00E6: PushStack(player, 0x00);
            L00E9: PushStack(player, ax);
14AD  00EA C4 5E 06  les bx, [bp+0x6]
14B0  00ED 26 FF 1F  call far word [es:bx]
14B3  00F0 83 C4 06  add sp, 0x6
            L00F3: ax = GetCurrentTile(player);
14BD  00FA 89 46 F4  mov [bp-0xc], ax
14C0  00FD B9 07 00  mov cx, 0x7
            L0100: bx = 0x1656;
14C6  0103 2E 8B 07  mov ax, [cs:bx]
14C9  0106 3B 46 F4  cmp ax, [bp-0xc]
            L0109: if (JumpEqual) goto L0112;
14CE  010B 43     inc bx
14CF  010C 43     inc bx
14D0  010D E2 F4  loop 0x103
            L010F: goto L01F2;
14D5  0112 2E FF 67 0E  jmp word [cs:bx+0xe]
            L0116: ShowPortrait(player, 0x0019);
14E6  0123 8C 5E FE  mov [bp-0x2], ds
14E9  0126 C7 46 FC 84 04  mov word [bp-0x4], 0x484
14EE  012B 8C 5E FA  mov [bp-0x6], ds
14F1  012E C7 46 F8 6E 08  mov word [bp-0x8], 0x86e
            L0133: goto L01FA;
            L0136: ShowPortrait(player, 0x0022);
1506  0143 8C 5E FE  mov [bp-0x2], ds
1509  0146 C7 46 FC 84 04  mov word [bp-0x4], 0x484
150E  014B 8C 5E FA  mov [bp-0x6], ds
1511  014E C7 46 F8 93 08  mov word [bp-0x8], 0x893
            L0153: goto L01FA;
            L0156: ShowPortrait(player, 0x0018);
1526  0163 8C 5E FE  mov [bp-0x2], ds
1529  0166 C7 46 FC 84 04  mov word [bp-0x4], 0x484
152E  016B 8C 5E FA  mov [bp-0x6], ds
1531  016E C7 46 F8 D4 08  mov word [bp-0x8], 0x8d4
            L0173: goto L01FA;
            L0176: ShowPortrait(player, 0x001B);
1546  0183 8C 5E FE  mov [bp-0x2], ds
1549  0186 C7 46 FC 84 04  mov word [bp-0x4], 0x484
154E  018B 8C 5E FA  mov [bp-0x6], ds
1551  018E C7 46 F8 F6 08  mov word [bp-0x8], 0x8f6
            L0193: goto L01FA;
            L0195: ShowPortrait(player, 0x002E);
1565  01A2 8C 5E FE  mov [bp-0x2], ds
1568  01A5 C7 46 FC 84 04  mov word [bp-0x4], 0x484
156D  01AA 8C 5E FA  mov [bp-0x6], ds
1570  01AD C7 46 F8 52 09  mov word [bp-0x8], 0x952
            L01B2: goto L01FA;
            L01B4: ShowPortrait(player, 0x002B);
1584  01C1 8C 5E FE  mov [bp-0x2], ds
1587  01C4 C7 46 FC 84 04  mov word [bp-0x4], 0x484
158C  01C9 8C 5E FA  mov [bp-0x6], ds
158F  01CC C7 46 F8 76 09  mov word [bp-0x8], 0x976
            L01D1: goto L01FA;
            L01D3: ShowPortrait(player, 0x001E);
15A3  01E0 8C 5E FE  mov [bp-0x2], ds
15A6  01E3 C7 46 FC 84 04  mov word [bp-0x4], 0x484
15AB  01E8 8C 5E FA  mov [bp-0x6], ds
15AE  01EB C7 46 F8 C0 09  mov word [bp-0x8], 0x9c0
            L01F0: goto L01FA;
15B5  01F2 8C 5E FE  mov [bp-0x2], ds
15B8  01F5 C7 46 FC 44 04  mov word [bp-0x4], 0x444
15BD  01FA 8B 46 FC  mov ax, [bp-0x4]
15C0  01FD 0B 46 FE  or ax, [bp-0x2]
            L0200: if (JumpEqual) goto L020E;
15C5  0202 FF 76 FC  push word [bp-0x4]
15C8  0205 C4 5E 06  les bx, [bp+0x6]
15CB  0208 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L020D: cx = PopStack(player);
15D1  020E 8B 46 F8  mov ax, [bp-0x8]
15D4  0211 0B 46 FA  or ax, [bp-0x6]
            L0214: if (JumpEqual) goto L022F;
            L0216: ShowMessage(player, String1E26); // As if in a feverish dream, the prisoner cries out:
15E6  0223 FF 76 F8  push word [bp-0x8]
15E9  0226 C4 5E 06  les bx, [bp+0x6]
15EC  0229 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L022E: cx = PopStack(player);
            L022F: // restore stack ptr: sp = bp;
            L0231: return; // RETURN;
            // Extra data: 00 00 10 00 12 00 14 00 24 00 31 00 32 00 39 15 59 15 79 15 99 15 B8 15 D7 15 F6 15 00 00 10 00 12 00 14 00 24 00 31 00 32 00 B6 14 C1 14 CC 14 D7 14 D9 14 E4 14 EF 14 
        }

        private void FnFRMMENAG_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0D, 0x02, 0x65, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnCRSLSTRT_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x03, 0x19, 0x01);
            L0018: return; // RETURN;
        }

        private void FnHLMRENCA_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
166B  0003 B0 21  mov al, 0x21
            L0005: PushStack(player, ax);
166E  0006 FF 76 08  push word [bp+0x8]
1671  0009 FF 76 06  push word [bp+0x6]
1674  000C 0E     push cs
1675  000D E8 31 E9  call 0xe941
1678  0010 83 C4 06  add sp, 0x6
            L0013: return; // RETURN;
        }

        private void FnHLMRENCB_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
1680  0003 B0 22  mov al, 0x22
            L0005: PushStack(player, ax);
1683  0006 FF 76 08  push word [bp+0x8]
1686  0009 FF 76 06  push word [bp+0x6]
1689  000C 0E     push cs
168A  000D E8 1C E9  call 0xe92c
168D  0010 83 C4 06  add sp, 0x6
            L0013: return; // RETURN;
        }

        private void FnHLMRENCC_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
1695  0003 B0 23  mov al, 0x23
            L0005: PushStack(player, ax);
1698  0006 FF 76 08  push word [bp+0x8]
169B  0009 FF 76 06  push word [bp+0x6]
169E  000C 0E     push cs
169F  000D E8 07 E9  call 0xe917
16A2  0010 83 C4 06  add sp, 0x6
            L0013: return; // RETURN;
        }

        private void FnNEXUSDOR_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
16AF  0003 83 EC 08  sub sp, 0x8
16B2  0006 56     push si
16B3  0007 C7 46 FE 00 00  mov word [bp-0x2], 0x0
16B8  000C C7 46 FC 00 00  mov word [bp-0x4], 0x0
            L0011: si = 0xFFFF;
            L0014: ax = GetFlag(player, 0x03, 0x1D);
16D1  0025 88 46 FB  mov [bp-0x5], al
16D4  0028 80 7E FB 00  cmp byte [bp-0x5], 0x0
            L002C: if (JumpEqual) goto L0031;
            L002E: goto L00F2;
            L0031: ax = GetCurrentTile(player);
16E4  0038 89 46 F8  mov [bp-0x8], ax
16E7  003B B9 08 00  mov cx, 0x8
            L003E: bx = 0x1824;
16ED  0041 2E 8B 07  mov ax, [cs:bx]
16F0  0044 3B 46 F8  cmp ax, [bp-0x8]
            L0047: if (JumpEqual) goto L0050;
16F5  0049 43     inc bx
16F6  004A 43     inc bx
16F7  004B E2 F4  loop 0x41
            L004D: goto L00D5;
16FC  0050 2E FF 67 10  jmp word [cs:bx+0x10]
            L0054: si = 0x007B;
1703  0057 8C 5E FE  mov [bp-0x2], ds
1706  005A C7 46 FC FC 03  mov word [bp-0x4], 0x3fc
            L005F: goto L00D5;
            L0061: si = 0x007B;
1710  0064 8C 5E FE  mov [bp-0x2], ds
1713  0067 C7 46 FC 03 04  mov word [bp-0x4], 0x403
            L006C: goto L00D5;
            L006E: si = 0x007B;
171D  0071 8C 5E FE  mov [bp-0x2], ds
1720  0074 C7 46 FC 10 04  mov word [bp-0x4], 0x410
            L0079: goto L00D5;
            L007B: si = 0x007B;
172A  007E 8C 5E FE  mov [bp-0x2], ds
172D  0081 C7 46 FC 1A 04  mov word [bp-0x4], 0x41a
            L0086: goto L00D5;
1734  0088 8C 5E FE  mov [bp-0x2], ds
1737  008B C7 46 FC 22 04  mov word [bp-0x4], 0x422
            L0090: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00AE: goto L00D5;
            L00B0: si = 0x007B;
175F  00B3 8C 5E FE  mov [bp-0x2], ds
1762  00B6 C7 46 FC 28 04  mov word [bp-0x4], 0x428
            L00BB: goto L00D5;
            L00BD: si = 0x007B;
176C  00C0 8C 5E FE  mov [bp-0x2], ds
176F  00C3 C7 46 FC 31 04  mov word [bp-0x4], 0x431
            L00C8: goto L00D5;
            L00CA: si = 0x007B;
1779  00CD 8C 5E FE  mov [bp-0x2], ds
177C  00D0 C7 46 FC 37 04  mov word [bp-0x4], 0x437
            L00D5: Compare(si, 0xFF);
            L00D8: if (JumpEqual) goto L00F2;
            L00DA: PushStack(player, 0x03);
178A  00DE 56     push si
            L00DF: PushStack(player, 0x02);
            L00E3: PushStack(player, 0x0D);
1793  00E7 C4 5E 06  les bx, [bp+0x6]
1796  00EA 26 FF 9F BC 00  call far word [es:bx+0xbc]
179B  00EF 83 C4 08  add sp, 0x8
179E  00F2 8B 46 FC  mov ax, [bp-0x4]
17A1  00F5 0B 46 FE  or ax, [bp-0x2]
            L00F8: if (JumpEqual) goto L0113;
            L00FA: ShowMessage(player, String1E59); // Above the door a stone tablet reads:
17B3  0107 FF 76 FC  push word [bp-0x4]
17B6  010A C4 5E 06  les bx, [bp+0x6]
17B9  010D 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L0112: cx = PopStack(player);
17BF  0113 5E     pop si
            L0114: // restore stack ptr: sp = bp;
            L0116: return; // RETURN;
            // Extra data: 2A 00 2C 00 39 00 3D 00 59 00 5D 00 6A 00 6C 00 87 17 94 17 7A 17 BC 17 6D 17 C9 17 60 17 D6 17 
        }

        private void FnFRMNEXUS_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0D, 0x02, 0xF2, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnBLOCKWAL_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0020: return; // RETURN;
        }

        private void FnVRTXMOV_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0020: TeleportParty(player, 0x0D, 0x02, GetFlag(player, 0x03, 0x00), GetFlag(player, 0x03, 0x01), isForwardMove);
            L0056: return; // RETURN;
        }

        private void FnFRMVRTX_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0D, 0x02, 0xDE, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnPENALTY_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
18A5  0003 C4 5E 06  les bx, [bp+0x6]
18A8  0006 26 FF 9F E8 00  call far word [es:bx+0xe8]
            L000B: ShowMessage(player, String1E7E); // From the darkness above you Choronzar's voice whispers, 'Good guess! % Too bad it was WRONG. %% Welcome to the Penalty Box...'
18BA  0018 B0 27  mov al, 0x27
            L001A: PushStack(player, ax);
18BD  001B FF 76 08  push word [bp+0x8]
18C0  001E FF 76 06  push word [bp+0x6]
18C3  0021 0E     push cs
18C4  0022 E8 E2 E6  call 0xe707
18C7  0025 83 C4 06  add sp, 0x6
            L0028: return; // RETURN;
        }

        private void FnTOHALL_36(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0D, 0x02, 0xAB, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnFRMPNLTY_37(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0D, 0x02, 0xDE, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnHMWELCOM_38(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1EFD); // A wooden sign hanging from the ceiling reads:
            L0010: ShowMessage(player, String1F2B); // 'HALL OF MIRRORS.
            L001D: ShowMessage(player, String1F3D); // These mirrors show thine own face,
            L002A: ShowMessage(player, String1F60); // Distorted and impure.
            L0037: ShowMessage(player, String1F76); // But seek the dour countenance,
            L0044: ShowMessage(player, String1F95); // Brow girdled with azure.'
            L0051: return; // RETURN;
        }

        private void FnTWISTFLR_39(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
1964  0005 C4 5E 06  les bx, [bp+0x6]
1967  0008 26 FF 9F E8 00  call far word [es:bx+0xe8]
            L000D: Compare(GetCurrentTile(player), 0x0030);
            L0017: if (JumpNotEqual) goto L002E;
            L0019: SetFlag(player, 0x03, 0x1A, 0x06);
            L002E: ax = IsFlagOff(player, 0x00, 0x01);
            L0040: if (JumpNotEqual) goto L0045;
            L0042: goto L00F1;
            L0045: ax = GetFlag(player, 0x03, 0x02);
19B5  0056 88 46 FF  mov [bp-0x1], al
            L0059: Compare(HasUsedSkill(player, 0x0D), 0x0001);
            L0068: if (JumpBelow) goto L0079;
            L006A: ShowMessage(player, String1FAF); // Your search reveals monsters!
            L0077: goto L00B9;
19D8  0079 FE 46 FF  inc byte [bp-0x1]
19DB  007C 8A 46 FF  mov al, [bp-0x1]
19DE  007F B4 00  mov ah, 0x0
            L0081: bx = 0x0005;
            L0084: dx = ax % bx; ax = ax / bx;
19E6  0087 0B D2  or dx, dx
            L0089: if (JumpEqual) goto L009A;
19EA  008B 8A 46 FF  mov al, [bp-0x1]
19ED  008E B4 00  mov ah, 0x0
            L0090: bx = 0x0007;
            L0093: dx = ax % bx; ax = ax / bx;
19F5  0096 0B D2  or dx, dx
            L0098: if (JumpNotEqual) goto L00DA;
            L009A: PushStack(player, 0x00);
            L009D: PushStack(player, ax);
            L009E: PushStack(player, 0xFB);
            L00A2: PushStack(player, 0xC1);
            L00A6: PushStack(player, 0xB8);
            L00AA: PushStack(player, 0xCE);
1A0D  00AE C4 5E 06  les bx, [bp+0x6]
1A10  00B1 26 FF 9F D8 00  call far word [es:bx+0xd8]
1A15  00B6 83 C4 0C  add sp, 0xc
1A18  00B9 B0 0D  mov al, 0xd
            L00BB: PushStack(player, ax);
1A1B  00BC FF 76 08  push word [bp+0x8]
1A1E  00BF FF 76 06  push word [bp+0x6]
1A21  00C2 0E     push cs
1A22  00C3 E8 84 E5  call 0xe64a
1A25  00C6 83 C4 06  add sp, 0x6
            L00C9: PushStack(player, 0x01);
            L00CD: PushStack(player, ax);
            L00CE: PushStack(player, 0x00);
1A30  00D1 C4 5E 06  les bx, [bp+0x6]
1A33  00D4 26 FF 1F  call far word [es:bx]
1A36  00D7 83 C4 06  add sp, 0x6
1A39  00DA 8A 46 FF  mov al, [bp-0x1]
1A3C  00DD B4 00  mov ah, 0x0
            L00DF: PushStack(player, ax);
            L00E0: PushStack(player, 0x02);
            L00E4: PushStack(player, 0x03);
1A47  00E8 C4 5E 06  les bx, [bp+0x6]
1A4A  00EB 26 FF 1F  call far word [es:bx]
1A4D  00EE 83 C4 06  add sp, 0x6
            L00F1: // restore stack ptr: sp = bp;
            L00F3: return; // RETURN;
        }

        private void FnEASTRFLR_3A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
1A57  0003 C4 5E 06  les bx, [bp+0x6]
1A5A  0006 26 FF 9F E8 00  call far word [es:bx+0xe8]
            L000B: return; // RETURN;
        }

        private void FnEASTREGG_3C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
1A69  0003 C4 5E 06  les bx, [bp+0x6]
1A6C  0006 26 FF 9F E8 00  call far word [es:bx+0xe8]
            L000B: PushStack(player, 0x00);
            L000E: PushStack(player, ax);
1A75  000F C4 5E 06  les bx, [bp+0x6]
1A78  0012 26 FF 5F 0C  call far word [es:bx+0xc]
            L0016: cx = PopStack(player);
            L0017: cx = PopStack(player);
            L0018: RefreshCompareFlags(ax);
            L001A: if (JumpEqual) goto L0046;
            L001C: PushStack(player, 0x01);
            L0020: PushStack(player, 0x00);
            L0023: PushStack(player, ax);
1A8A  0024 C4 5E 06  les bx, [bp+0x6]
1A8D  0027 26 FF 1F  call far word [es:bx]
1A90  002A 83 C4 06  add sp, 0x6
            L002D: ShowMessage(player, String1FCD); // An exquisitely delicate egg of opal and white gold rests atop a polished marble dais. Congratulations! You have found the Easter Egg.
            L003A: GiveItem(player, 0xF8);
            L0046: return; // RETURN;
        }

        private void FnFAKETHRN_3D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String2053); // This is a massive throne carved from a single block of polished obsidian. It is inlaid with strange, beautiful sigils in delicate silver filigree.
            L0010: return; // RETURN;
        }

        private void FnCHORGHST_3E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOff(player, 0x03, 0x0B);
            L0016: if (JumpEqual) goto L003A;
            L0018: SetFlag(player, 0x03, 0x0B, 0x01);
            L002D: ShowMessage(player, String20E6); // Wailing piteously, the spirit of Choronzar drifts from his fallen body into the tomb.
            L003A: return; // RETURN;
        }

        private void FnTOEASTER_3F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0D, 0x02, 0xE3, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnFAKETRSR_40(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
1B1E  0003 83 EC 04  sub sp, 0x4
            L0006: ax = IsFlagOff(player, 0x00, 0x01);
            L0018: if (JumpNotEqual) goto L001D;
            L001A: goto L00F7;
            L001D: PushStack(player, 0x01);
            L0021: PushStack(player, ax);
            L0022: PushStack(player, 0x00);
1B40  0025 C4 5E 06  les bx, [bp+0x6]
1B43  0028 26 FF 1F  call far word [es:bx]
1B46  002B 83 C4 06  add sp, 0x6
            L002E: ax = GetFlag(player, 0x02, 0xD2);
1B5A  003F 88 46 FE  mov [bp-0x2], al
1B5D  0042 80 7E FE 64  cmp byte [bp-0x2], 0x64
            L0046: if (JumpBelow) goto L004B;
            L0048: goto L00E0;
            L004B: ax = GetCurrentTile(player);
1B6D  0052 89 46 FC  mov [bp-0x4], ax
1B70  0055 B9 04 00  mov cx, 0x4
            L0058: bx = 0x1C76;
1B76  005B 2E 8B 07  mov ax, [cs:bx]
1B79  005E 3B 46 FC  cmp ax, [bp-0x4]
            L0061: if (JumpEqual) goto L0069;
1B7E  0063 43     inc bx
1B7F  0064 43     inc bx
1B80  0065 E2 F4  loop 0x5b
            L0067: goto L0085;
1B84  0069 2E FF 67 08  jmp word [cs:bx+0x8]
1B88  006D C6 46 FF BA  mov byte [bp-0x1], 0xba
            L0071: goto L0089;
1B8E  0073 C6 46 FF BB  mov byte [bp-0x1], 0xbb
            L0077: goto L0089;
1B94  0079 C6 46 FF BD  mov byte [bp-0x1], 0xbd
            L007D: goto L0089;
1B9A  007F C6 46 FF E8  mov byte [bp-0x1], 0xe8
            L0083: goto L0089;
1BA0  0085 C6 46 FF BC  mov byte [bp-0x1], 0xbc
            L0089: ShowMessage(player, String213C); // This vast stack of ingots seems virtually inexhaustible.
1BB1  0096 8A 46 FF  mov al, [bp-0x1]
1BB4  0099 B4 00  mov ah, 0x0
            L009B: GiveItem(player, ax);
1BBF  00A4 8A 46 FF  mov al, [bp-0x1]
1BC2  00A7 B4 00  mov ah, 0x0
            L00A9: GiveItem(player, ax);
1BCD  00B2 8A 46 FF  mov al, [bp-0x1]
1BD0  00B5 B4 00  mov ah, 0x0
            L00B7: GiveItem(player, ax);
1BDB  00C0 8A 46 FF  mov al, [bp-0x1]
1BDE  00C3 B4 00  mov ah, 0x0
            L00C5: GiveItem(player, ax);
1BE9  00CE 8A 46 FF  mov al, [bp-0x1]
1BEC  00D1 B4 00  mov ah, 0x0
            L00D3: GiveItem(player, ax);
1BF7  00DC 80 46 FE 05  add byte [bp-0x2], 0x5
1BFB  00E0 8A 46 FE  mov al, [bp-0x2]
1BFE  00E3 B4 00  mov ah, 0x0
            L00E5: PushStack(player, ax);
            L00E6: PushStack(player, 0xD2);
            L00EA: PushStack(player, 0x02);
1C09  00EE C4 5E 06  les bx, [bp+0x6]
1C0C  00F1 26 FF 1F  call far word [es:bx]
1C0F  00F4 83 C4 06  add sp, 0x6
            L00F7: // restore stack ptr: sp = bp;
            L00F9: return; // RETURN;
            // Extra data: D7 00 D8 00 E7 00 F7 00 E8 1B EE 1B F4 1B FA 1B 
        }

        private void FnSETEASTR_41(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOff(player, 0x00, 0x01);
            L0015: if (JumpEqual) goto L0032;
            L0017: PushStack(player, 0x71);
            L001B: PushStack(player, ax);
1C42  001C C4 5E 06  les bx, [bp+0x6]
1C45  001F 26 FF 5F 54  call far word [es:bx+0x54]
            L0023: cx = PopStack(player);
            L0024: cx = PopStack(player);
            L0025: RefreshCompareFlags(ax);
            L0027: if (JumpEqual) goto L0059;
            L0029: PushStack(player, 0x01);
            L002D: PushStack(player, ax);
1C54  002E 33 C0  xor ax, ax
            L0030: goto L004F;
            L0032: PushStack(player, 0xE8);
            L0036: PushStack(player, ax);
1C5D  0037 C4 5E 06  les bx, [bp+0x6]
1C60  003A 26 FF 5F 54  call far word [es:bx+0x54]
            L003E: cx = PopStack(player);
            L003F: cx = PopStack(player);
            L0040: RefreshCompareFlags(ax);
            L0042: if (JumpEqual) goto L0059;
            L0044: SetFlag(player, 0x03, 0x08, 0x01);
            L0059: return; // RETURN;
        }

        private void FnTWRDESC_43(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String2175); // The Tower disks are controlled by the Funhouse Key.
            L0010: return; // RETURN;
        }

    }
}
