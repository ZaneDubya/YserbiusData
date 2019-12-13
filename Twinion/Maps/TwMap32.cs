#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Twinion.Maps {
    class TwMap32 : AMapScripted {
        protected override int MapIndex => 32;
        protected override int RandomEncounterChance => 0;
        protected override int RandomEncounterExtraCount => 2;

        public TwMap32() {
            MapEvent01 = FnLAVA_01;
            MapEvent02 = FnTHRNWTR_02;
            MapEvent03 = FnTHRNPIT_03;
            MapEvent04 = FnTREASPIT_04;
            MapEvent05 = FnTHRNPILR_05;
            MapEvent06 = FnTRMPIT_06;
            MapEvent07 = FnPRKWTR_07;
            MapEvent08 = FnCOASTER_08;
            MapEvent09 = FnBRIDGE_09;
            MapEvent0A = FnFEEDFISH_0A;
            MapEvent0B = FnSEEFISH_0B;
            MapEvent0C = FnTHRNGATE_0C;
            MapEvent0D = FnLVRCLUE_0D;
            MapEvent0E = FnLIBRARY_0E;
            MapEvent0F = FnTHRONE_0F;
            MapEvent10 = FnCSTRSTRT_10;
            MapEvent11 = FnRIFT_11;
            MapEvent12 = FnTOSECRET_12;
            MapEvent13 = FnBLKWALL_13;
            MapEvent14 = FnUSEBNCH_14;
            MapEvent15 = FnTHRNROOM_15;
            MapEvent16 = FnTREASURE_16;
            MapEvent17 = FnFREEZER_17;
            MapEvent18 = FnSTEAKS_18;
            MapEvent19 = FnMADCAP_19;
            MapEvent1A = FnSCRTPSG_1A;
            MapEvent1C = FnLIBSIGN_1C;
            MapEvent1D = FnSHADSTSH_1D;
            MapEvent1E = FnCHORKILD_1E;
            MapEvent1F = FnFRZRLCKR_1F;
            MapEvent21 = FnSETALCH_21;
            MapEvent32 = FnGETPWORD_32;
            MapEvent33 = FnGIVEPWRD_33;
            MapEvent34 = FnNAOMIA_34;
            MapEvent35 = FnSOFCDESC_35;
            MapEvent36 = FnSHDXBDRM_36;
            MapEvent37 = FnSCPNTNG_37;
            MapEvent38 = FnCSTRMSG_38;
            MapEvent39 = FnLVRPUZZ_39;
            MapEvent3A = FnSTORROOM_3A;
            MapEvent3B = FnSORDERS_3B;
            MapEvent64 = FnCHISS_64;
            MapEvent65 = FnSHADAX_65;
            MapEvent67 = FnNAOMIB_67;
            MapEvent68 = FnCONCRG_68;
            MapEvent69 = FnGRDAPST_69;
            MapEvent6A = FnGRDAWNDR_6A;
            MapEvent6B = FnGRDARLX_6B;
            MapEvent6C = FnGRDBPST_6C;
            MapEvent6D = FnGRDBWNDR_6D;
            MapEvent6E = FnHALLDETH_6E;
            MapEvent6F = FnKEKEKTL_6F;
            MapEvent70 = FnGAOLER_70;
            MapEvent71 = FnGRDDPST_71;
            MapEvent72 = FnCHORNZAR_72;
            MapEvent73 = FnGRDDWNDR_73;
            MapEvent74 = FnSHDXKLLD_74;
            MapEvent75 = FnGLRKLLD_75;
        }
        
        // === Strings ================================================
        private const string String03FC = "Choronzar hopes to advance his position among the gods by magical means. To this end he is attempting an alchemical Binding Ritual on the mortal spirits his minions kidnap. Thus far success -- in the form of the correct formula -- has eluded him.";
        private const string String04F3 = "Choronzar is a trickster deity. Although he is a lesser light among the evil pantheon, his cunning and ambition far exceed the comprehension of his more powerful brethren, many of whom consider him insane and hence relatively harmless.";
        private const string String05DF = "Princess Naomi was abducted from her world by Shadax, who was attracted by the purity of her spirit. Choronzar fell in love with her and spared her from his experiments in the hope that she would return his affections. She has not.";
        private const string String06C7 = "The cauldron boils up as the bar dissolves.";
        private const string String06F3 = "The liquid in the cauldron turns a brackish gray-brown and stops bubbling.";
        private const string String073E = "'You have saved us from eternal torment. Our strength is now yours in the battle to come.'";
        private const string String0799 = "You are swarmed by a school of vicious piranhas and torn to shreds.";
        private const string String07DD = "You jostle each other and tumble into the water.";
        private const string String080E = "The boiling lava scorches you terribly.";
        private const string String0836 = "You writhe in agony as the poisonous waters close over you";
        private const string String0871 = "The piranhas have returned! They begin to snap and bite, mauling you horribly.";
        private const string String08C0 = "The water to the north is less agitated than before.";
        private const string String08F5 = "Gingerly you wade through the pond. North of you the water continues to seethe where the piranhas are feeding.";
        private const string String0964 = "The coaster cars are only big enough for one of you at a time.";
        private const string String09A3 = "The coaster gains speed as it dips giddily into the darkness.";
        private const string String09E1 = "The coaster stops.";
        private const string String09F4 = "You twist the Funhouse Key in the keyhole. With a lurch the car begins to rumble forward along the rails.";
        private const string String0A5E = "You are standing on a small jetty above a fish pond. Before you a raised, earthen pathway snakes out across the water.";
        private const string String0AD5 = "The path is narrow and slippery. You had better proceed alone.";
        private const string String0B14 = "To the south and east you can dimly make out the silhouette of a woman standing on a small island.";
        private const string String0B77 = "A swarm of fish churns the water in a mad feeding frenzy.";
        private const string String0BB1 = "The nearby fish quickly gather and begin tearing at the steak.";
        private const string String0BF0 = "As you approach the water's edge you see the fish gathering expectantly.";
        private const string String0C39 = "Nasty-looking fish dart through the dark water below.";
        private const string String0C6F = "Beneath some debris you find a water-damaged book entitled Journal of Bragadan the Brave. The only legible entry reads '...believe I have found a way through the accursed lever maze.";
        private const string String0D26 = "Though I have struggled lifelong to uphold the right and good, now I must follow the sinister path...'";
        private const string String0D8D = "Poring over the dusty tomes you learn the following:";
        private const string String0DC2 = "This is a massive throne carved from a single block of polished obsidian.  It is inlaid with strange, beautiful sigils in a delicate silver filigree.";
        private const string String0E58 = "You thrill to the surge of life force coursing into you from the throne.";
        private const string String0EA1 = "Embedded in the front panel of the car is a keyhole.";
        private const string String0ED6 = "The glowing rift is the only way back to your world.";
        private const string String0F0B = "You discover a narrow secret passageway.";
        private const string String0F34 = "You will have to squeeze through one at a time.";
        private const string String0F64 = "Alchemical implements of all descriptions clutter this workbench, including four large black kettles full of bubbling liquid.";
        private const string String0FE2 = "Eerie green light floods the room as all of the cauldrons begin to boil violently. With an unearthly moan the spirits trapped within begin to stream forth in twisting, vaporous tendrils.";
        private const string String109D = "Dazzled, you step into a brightly-lit, vaulted chamber. The musky smell of incense hangs in the air and the delicate music of chimes is audible in the distance.";
        private const string String113E = "Ahead of you through the layers of smoke you see a massive golden throne.";
        private const string String1188 = "As you draw closer you make out an insoucient figure lounging on the throne, dressed in jester's motley.";
        private const string String11F1 = "The crazed figure on the throne stands, stares at you briefly, then prances off to the southeast, cackling like a lunatic. He dives into a pit and vanishes.";
        private const string String128E = "There is a pile of treasure here!";
        private const string String12B0 = "You bash the lock off the door.";
        private const string String12D0 = "The door is held shut by a hefty padlock which does not appear to have a keyhole.";
        private const string String1322 = "You find a package of juicy dragon steaks!";
        private const string String134D = "A small brass sign on the door reads 'Madcap Labs. Absolutely NO solicitors!'";
        private const string String139B = "The passage is too narrow.";
        private const string String13B6 = "You are not worthy.";
        private const string String13CA = "Above the door is a wooden sign: 'Library. SHHHH!!!!'";
        private const string String1400 = "You discover a secret compartment in the floor of the closet. A scroll reads 'Commander Shadax, You are to step up the acquisition of mortals for my experiments immediately. Signed, Choronzar'";
        private const string String14C1 = "Choronzar's body begins to deliquesce as hissing smoke pours from his bloodied clothes. The room bucks and lurches as shockwaves roll through, knocking you to your knees.";
        private const string String156C = "Over the din of the reverberations you hear a British voice asking 'what was that about HATS?' There is a sickening peal of hysterical, eldritch laughter. Then silence.";
        private const string String1615 = "This is a freezer-locker.  Oversized blocks of ice stacked half-way to the ceiling keep it very cold in here.";
        private const string String1683 = "On the south wall is a poster depicting a scantily-clad Kaalroth posing beside an enormous tankard of mead. Tearing it aside you discover the word 'SMILE' scrawled on the wall in charcoal.";
        private const string String1740 = "A slit in the door shoots open and a gutteral voice demands, 'Wot's th' password?'";
        private const string String1793 = "You reply 'the password is 'SMILE',' and the door creaks open. The gaoler growls, 'Come on in so's I can look at ye. One at a time!'";
        private const string String1818 = "You stammer helplessly, not knowing the password. 'Come back when ye've remembered it!' The slit slams shut.";
        private const string String1885 = "You step into the dismal little cell and draw up short. Before you stands a radiant woman in a flowing, violet gown. She is slender and graceful but her eyes bore into you with unnerving intensity.";
        private const string String194B = "'Enough!' she cries. 'I grow tired of these pathetic ruses. Tell your master my answer is 'NO!'' Before you can respond she stalks past you and is gone.";
        private const string String19E4 = "Charts and war-trophies decorate the walls of this military command center. Several crude desks are strewn with scrolls and parchments.";
        private const string String1A6C = "This room, though spartan, appears to be the personal quarters of a high-ranking officer.";
        private const string String1AC6 = "A portrait on the north wall depicts Shadax and a snake-woman posing in their wedding clothes. 'Shadax and Chiss, 8743 A.C.'";
        private const string String1B43 = "Before you gleams a wondrous, cunningly crafted chariot. Fashioned of hardwood and steel, it has been gaudily painted in glossy red and green lacquers. In front of the first car two shiny rails extend into the darkness to the north.";
        private const string String1C2C = "You pull the lever.";
        private const string String1C40 = "Mocking laughter echoes from far away.";
        private const string String1C67 = "You hear a rumbling sound to the east.";
        private const string String1C8E = "This is a storage room. Barrels and crates are stacked haphazardly.";
        private const string String1CD2 = "Buried beneath a stack of papers you find a scroll: 'Commander Shadax, It seems the princess prefers a gaol cell to the comforts of her chambers. Advise the Gaoler that she may come and go as she pleases. Signed, Choronzar'";
        private const string String1DB2 = "A gigantic snake-woman looms over you, swaying hypnotically. 'Yessss,' she hisses, 'it will be sweet revenge to taste the mortal blood that stole my husband Shadax!'";
        private const string String1E58 = "You feel a rush of vertigo as you pass through the rift.";
        private const string String1E91 = "Before you towers an enormous Kaalroth in full battle dress. 'Who dares to invade the realm of Choronzar?', he roars. 'I, Shadax, shall see that you never return!'";
        private const string String1F35 = "You clamber from the muddy water onto the island. Naomi is here.";
        private const string String1F76 = "'Well,' she says icily, 'you are persistent in your mendacity, I grant you that.' She smiles slyly. 'If you really want me to believe you were not sent by Choronzar then find and return my Spirit Bottle!'";
        private const string String2043 = "You offer the Spirit Bottle to Naomi. She snatches it from your hand and squints at it suspiciously. Then her eyes widen and her expression softens.";
        private const string String20D8 = "'I have misjudged you,' she says quietly. 'My debt to you is so great that I can never hope to repay it. Still, I will do what I can.";
        private const string String215E = "I once saw Choronzar slip through a secret passageway in the back of his laboratory. I believe it leads to his throne room!  Perhaps you can use it to circumvent his many guards.";
        private const string String2211 = "Now I must go. Farewell, and may Fortune smile upon you always!' She uncorks the bottle and a cloud of coruscating crimson fog quickly envelops her.  'I no longer exist here!'";
        private const string String22C1 = "When the fog clears Naomi is gone.";
        private const string String22E4 = "Naomi snaps, 'Have you brought my Spirit Bottle, or is this another feeble attempt to deceive me?'";
        private const string String2347 = "An owlish man sits poring over some documents behind an imposing, oaken desk. Without glancing up he gestures toward a ledger-book. 'Sign in please.'";
        private const string String23DD = "You trudge forward down the Hall of Death.";
        private const string String2408 = "This antechamber is littered with bones. As you step forward some of the grisly debris flies up and forms itself into a horrific, skeletal figure. 'I am Kekeketl,' it rasps. 'I am sworn to defend this place.'";
        private const string String24D9 = "You advance, and once more Kekeketl rises from the carnage. 'I have told thee, I am sworn to defend this place.'";
        private const string String254A = "As you step through the door the Gaoler pushes you back roughly. 'One at a time!' he growls.";
        private const string String25A7 = "As you step into the light the Gaoler flies into a rage. 'Wot's this then?' he cries. 'Oi've been tricked!'";
        private const string String2613 = "You rush through the wall and surprise Choronzar pacing behind his throne!";
        private const string String265E = "He shrieks and turns to flee, but you are upon him in an instant.";
        private const string String26A0 = "He smiles grimly. 'So it comes to this? % I hope you know what you're doing.'";
        private const string String26EE = "UìLLÄ^&ÿð";
        private const string String26FB = "=";
        private const string String26FE = "t=";
        private const string String2703 = "t=";
        private const string String2708 = "tëÆFþëÆFþë
ÆFþëÆFþÆFÿëF
´";
        private const string String272D = "PFÿ´";
        private const string String2733 = "PÄ^&ÿÔ";
        private const string String273C =         
        // === Functions ================================================
        private void FnLAVA_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: ShowMessage(player, String080E); // The boiling lava scorches you terribly.
            L0012: ax = GetCurrentHits(player);
0026  0019 48     dec ax
0027  001A 89 46 FE  mov [bp-0x2], ax
002A  001D FF 76 FE  push word [bp-0x2]
002D  0020 C4 5E 06  les bx, [bp+0x6]
0030  0023 26 FF 9F 90 00  call far word [es:bx+0x90]
            L0028: cx = PopStack(player);
            L0029: // restore stack ptr: sp = bp;
            L002B: return; // RETURN;
        }

        private void FnTHRNWTR_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0836); // You writhe in agony as the poisonous waters close over you
            L0010: DamagePlayer(player, GetMaxHits(player));
            L0021: return; // RETURN;
        }

        private void FnTHRNPIT_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetCurrentTile(player);
            L000A: TeleportParty(player, 0x08, 0x01, 0x00, 0x33, isForwardMove);
            L0024: return; // RETURN;
        }

        private void FnTREASPIT_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetFlag(player, 0x02, 0x39);
0097  0014 A9 04 00  test ax, 0x4
            L0017: if (JumpEqual) goto L002A;
            L0019: PushStack(player, 0x02);
            L001D: PushStack(player, 0x4A);
            L0021: PushStack(player, 0x01);
00A8  0025 B8 0D 00  mov ax, 0xd
            L0028: goto L0038;
            L002A: TeleportParty(player, 0x08, 0x01, 0x00, 0x33, isForwardMove);
            L0044: return; // RETURN;
        }

        private void FnTHRNPILR_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFloorPassable(player, 0x00, GetCurrentTile(player));
            L0017: return; // RETURN;
        }

        private void FnTRMPIT_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0D, 0x01, 0x38, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnPRKWTR_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: ax = GetFlag(player, 0x03, 0x05);
0118  0016 88 46 FF  mov [bp-0x1], al
            L0019: ax = GetCurrentTile(player);
0122  0020 88 46 FE  mov [bp-0x2], al
0125  0023 80 7E FE 94  cmp byte [bp-0x2], 0x94
            L0027: if (JumpBelowOrEqual) goto L002F;
012B  0029 80 7E FF 00  cmp byte [bp-0x1], 0x0
            L002D: if (JumpNotEqual) goto L0050;
            L002F: ShowMessage(player, String0799); // You are swarmed by a school of vicious piranhas and torn to shreds.
            L003C: DamagePlayer(player, GetMaxHits(player));
            L004D: goto L00D5;
0152  0050 8A 46 FF  mov al, [bp-0x1]
0155  0053 B4 00  mov ah, 0x0
            L0055: RefreshCompareFlags(ax);
            L0057: if (JumpEqual) goto L0065;
            L0059: Compare(ax, 0x0001);
            L005C: if (JumpEqual) goto L0084;
            L005E: Compare(ax, 0x0002);
            L0061: if (JumpEqual) goto L00A9;
            L0063: goto L00AE;
            L0065: ShowMessage(player, String0799); // You are swarmed by a school of vicious piranhas and torn to shreds.
            L0072: PushStack(player, GetMaxHits(player));
017C  007A C4 5E 06  les bx, [bp+0x6]
017F  007D 26 FF 9F 90 00  call far word [es:bx+0x90]
            L0082: goto L00BA;
            L0084: ShowMessage(player, String0871); // The piranhas have returned! They begin to snap and bite, mauling you horribly.
            L0091: ax = GetMaxHits(player);
            L0098: bx = 0x0002;
            L009B: dx = ax % bx; ax = ax / bx;
            L009E: PushStack(player, ax);
01A1  009F C4 5E 06  les bx, [bp+0x6]
01A4  00A2 26 FF 9F 90 00  call far word [es:bx+0x90]
            L00A7: goto L00BA;
01AB  00A9 B8 C0 08  mov ax, 0x8c0
            L00AC: goto L00B1;
            L00AE: ShowMessage(player, String08F5); // Gingerly you wade through the pond. North of you the water continues to seethe where the piranhas are feeding.
01BD  00BB FE 4E FF  dec byte [bp-0x1]
01C0  00BE 8A 46 FF  mov al, [bp-0x1]
01C3  00C1 B4 00  mov ah, 0x0
            L00C3: PushStack(player, ax);
            L00C4: PushStack(player, 0x05);
            L00C8: PushStack(player, 0x03);
01CE  00CC C4 5E 06  les bx, [bp+0x6]
01D1  00CF 26 FF 1F  call far word [es:bx]
01D4  00D2 83 C4 06  add sp, 0x6
            L00D5: // restore stack ptr: sp = bp;
            L00D7: return; // RETURN;
        }

        private void FnCOASTER_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(player);
            L000B: Compare(PartyCount(player), 0x0001);
            L0016: if (JumpBelowOrEqual) goto L0053;
            L0018: ShowMessage(player, String0964); // The coaster cars are only big enough for one of you at a time.
            L0025: SetFlag(player, 0x03, 0x02, 0x00);
            L0039: TeleportParty(player, 0x0D, 0x01, 0x67, 0x00, isForwardMove);
            L0053: Compare(GetCurrentTile(player), 0x0056);
            L005D: if (JumpEqual) goto L0067;
            L005F: Compare(ax, 0x0066);
            L0062: if (JumpEqual) goto L0081;
            L0064: goto L0118;
            L0067: ShowMessage(player, String09A3); // The coaster gains speed as it dips giddily into the darkness.
            L0074: PushStack(player, 0x00);
            L0077: PushStack(player, 0xFF);
0256  007B B8 02 00  mov ax, 0x2
            L007E: goto L0138;
            L0081: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x00);
            L009A: SetWallPassable(player, GetCurrentTile(player), 0x01, 0x00);
            L00B3: ax = IsFlagOn(player, 0x03, 0x02);
            L00C6: if (JumpEqual) goto L00F2;
            L00C8: ShowMessage(player, String09E1); // The coaster stops.
            L00D5: SetFlag(player, 0x03, 0x02, 0x00);
            L00E9: PushStack(player, 0x02);
02C8  00ED B8 67 00  mov ax, 0x67
            L00F0: goto L0134;
            L00F2: ax = HasItem(player, 0xED);
            L0100: if (JumpEqual) goto L0148;
            L0102: ShowMessage(player, String09F4); // You twist the Funhouse Key in the keyhole. With a lurch the car begins to rumble forward along the rails.
            L010F: PushStack(player, 0x03);
02EE  0113 B8 56 00  mov ax, 0x56
            L0116: goto L0134;
            L0118: SetFlag(player, 0x03, 0x02, 0x01);
            L012D: TeleportParty(player, 0x0D, 0x01, 0x66, 0x03, isForwardMove);
            L0148: return; // RETURN;
        }

        private void FnBRIDGE_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0328  0003 83 EC 04  sub sp, 0x4
            L0006: ax = GetFlag(player, 0x03, 0x01);
033C  0017 88 46 FF  mov [bp-0x1], al
            L001A: ax = GetCurrentTile(player);
0346  0021 88 46 FE  mov [bp-0x2], al
0349  0024 B4 00  mov ah, 0x0
            L0026: Compare(ax, 0x0084);
            L0029: if (JumpEqual) goto L0033;
            L002B: Compare(ax, 0x00B1);
            L002E: if (JumpEqual) goto L0086;
            L0030: goto L00FC;
0358  0033 8A 46 FF  mov al, [bp-0x1]
035B  0036 24 02  and al, 0x2
035D  0038 B4 00  mov ah, 0x0
            L003A: RefreshCompareFlags(ax);
            L003C: if (JumpEqual) goto L0041;
            L003E: goto L014E;
            L0041: ShowMessage(player, String0A5E); // You are standing on a small jetty above a fish pond. Before you a raised, earthen pathway snakes out across the water.
            L004E: Compare(PartyCount(player), 0x0001);
            L0059: if (JumpBelowOrEqual) goto L0068;
            L005B: ShowMessage(player, String0AD5); // The path is narrow and slippery. You had better proceed alone.
038D  0068 80 4E FF 02  or byte [bp-0x1], 0x2
0391  006C 8A 46 FF  mov al, [bp-0x1]
0394  006F B4 00  mov ah, 0x0
            L0071: PushStack(player, ax);
            L0072: PushStack(player, 0x01);
            L0076: PushStack(player, 0x03);
039F  007A C4 5E 06  les bx, [bp+0x6]
03A2  007D 26 FF 1F  call far word [es:bx]
03A5  0080 83 C4 06  add sp, 0x6
            L0083: goto L014E;
            L0086: Compare(PartyCount(player), 0x0001);
            L0091: if (JumpBelowOrEqual) goto L00BE;
            L0093: ShowMessage(player, String07DD); // You jostle each other and tumble into the water.
            L00A0: PushStack(player, 0x02);
03C9  00A4 8A 46 FE  mov al, [bp-0x2]
03CC  00A7 B4 00  mov ah, 0x0
03CE  00A9 40     inc ax
            L00AA: TeleportParty(player, 0x0D, 0x01, ax, PopStack(player), isForwardMove);
            L00BE: Compare(GetFacing(player), 0x0001);
            L00C8: if (JumpEqual) goto L00CD;
            L00CA: goto L014E;
            L00CD: ax = GetFlag(player, 0x02, 0x6B);
0403  00DE 88 46 FD  mov [bp-0x3], al
0406  00E1 80 7E FD 01  cmp byte [bp-0x3], 0x1
            L00E5: if (JumpEqual) goto L00ED;
040C  00E7 80 7E FD 02  cmp byte [bp-0x3], 0x2
            L00EB: if (JumpNotEqual) goto L014E;
            L00ED: ShowMessage(player, String0B14); // To the south and east you can dimly make out the silhouette of a woman standing on a small island.
            L00FA: goto L014E;
            L00FC: Compare(PartyCount(player), 0x0001);
            L0107: if (JumpBelowOrEqual) goto L014E;
            L0109: ShowMessage(player, String07DD); // You jostle each other and tumble into the water.
043B  0116 80 7E FE A1  cmp byte [bp-0x2], 0xa1
            L011A: if (JumpEqual) goto L0122;
0441  011C 80 7E FE 92  cmp byte [bp-0x2], 0x92
            L0120: if (JumpNotEqual) goto L012E;
            L0122: PushStack(player, 0x02);
044B  0126 8A 46 FE  mov al, [bp-0x2]
044E  0129 B4 00  mov ah, 0x0
0450  012B 40     inc ax
            L012C: goto L013A;
            L012E: PushStack(player, 0x02);
0457  0132 8A 46 FE  mov al, [bp-0x2]
045A  0135 B4 00  mov ah, 0x0
            L0137: TeleportParty(player, 0x0D, 0x01, ax + 0xFFF0, PopStack(player), isForwardMove);
            L014E: // restore stack ptr: sp = bp;
            L0150: return; // RETURN;
        }

        private void FnFEEDFISH_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: PushStack(player, 0xEC);
            L0009: PushStack(player, ax);
0481  000A C4 5E 06  les bx, [bp+0x6]
0484  000D 26 FF 5F 54  call far word [es:bx+0x54]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L001A;
            L0017: goto L00CE;
            L001A: RemoveItem(player, 0xEC);
            L0026: ax = GetFlag(player, 0x03, 0x01);
04AE  0037 88 46 FF  mov [bp-0x1], al
            L003A: ax = GetFlag(player, 0x03, 0x05);
04C2  004B 88 46 FE  mov [bp-0x2], al
04C5  004E 80 7E FE 00  cmp byte [bp-0x2], 0x0
            L0052: if (JumpNotEqual) goto L009A;
            L0054: Compare(GetCurrentTile(player), 0x0084);
            L005E: if (JumpNotEqual) goto L0066;
04D7  0060 80 4E FF 10  or byte [bp-0x1], 0x10
            L0064: goto L006A;
04DD  0066 80 4E FF 20  or byte [bp-0x1], 0x20
04E1  006A 8A 46 FF  mov al, [bp-0x1]
04E4  006D B4 00  mov ah, 0x0
04E6  006F A9 10 00  test ax, 0x10
            L0072: if (JumpEqual) goto L0095;
04EB  0074 8A 46 FF  mov al, [bp-0x1]
04EE  0077 B4 00  mov ah, 0x0
04F0  0079 A9 20 00  test ax, 0x20
            L007C: if (JumpEqual) goto L0095;
04F5  007E 80 66 FF CF  and byte [bp-0x1], 0xcf
04F9  0082 C6 46 FE 06  mov byte [bp-0x2], 0x6
            L0086: ShowMessage(player, String0B77); // A swarm of fish churns the water in a mad feeding frenzy.
            L0093: goto L009E;
050C  0095 B8 B1 0B  mov ax, 0xbb1
            L0098: goto L0089;
0511  009A C6 46 FE 06  mov byte [bp-0x2], 0x6
0515  009E 8A 46 FF  mov al, [bp-0x1]
0518  00A1 B4 00  mov ah, 0x0
            L00A3: PushStack(player, ax);
            L00A4: PushStack(player, 0x01);
            L00A8: PushStack(player, 0x03);
0523  00AC C4 5E 06  les bx, [bp+0x6]
0526  00AF 26 FF 1F  call far word [es:bx]
0529  00B2 83 C4 06  add sp, 0x6
052C  00B5 8A 46 FE  mov al, [bp-0x2]
052F  00B8 B4 00  mov ah, 0x0
            L00BA: PushStack(player, ax);
            L00BB: PushStack(player, 0x05);
            L00BF: PushStack(player, 0x03);
053A  00C3 C4 5E 06  les bx, [bp+0x6]
053D  00C6 26 FF 1F  call far word [es:bx]
0540  00C9 83 C4 06  add sp, 0x6
            L00CC: goto L00F0;
            L00CE: ax = IsFlagOff(player, 0x03, 0x05);
            L00E1: if (JumpEqual) goto L00F0;
            L00E3: ShowMessage(player, String0BF0); // As you approach the water's edge you see the fish gathering expectantly.
            L00F0: // restore stack ptr: sp = bp;
            L00F2: return; // RETURN;
        }

        private void FnSEEFISH_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOff(player, 0x03, 0x05);
            L0016: if (JumpEqual) goto L0025;
            L0018: ShowMessage(player, String0C39); // Nasty-looking fish dart through the dark water below.
            L0025: return; // RETURN;
        }

        private void FnTHRNGATE_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetFlag(player, 0x03, 0x01);
05A6  0014 A9 01 00  test ax, 0x1
            L0017: if (JumpEqual) goto L001E;
05AB  0019 B8 01 00  mov ax, 0x1
            L001C: goto L0020;
            L001E: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x00);
            L0037: return; // RETURN;
        }

        private void FnLVRCLUE_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0C6F); // Beneath some debris you find a water-damaged book entitled Journal of Bragadan the Brave. The only legible entry reads '...believe I have found a way through the accursed lever maze.
            L0010: ShowMessage(player, String0D26); // Though I have struggled lifelong to uphold the right and good, now I must follow the sinister path...'
            L001D: return; // RETURN;
        }

        private void FnLIBRARY_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
05ED  0003 83 EC 06  sub sp, 0x6
05F0  0006 56     push si
05F1  0007 C7 46 FE 00 00  mov word [bp-0x2], 0x0
05F6  000C C7 46 FC 00 00  mov word [bp-0x4], 0x0
            L0011: si = GetCurrentTile(player);
0604  001A B1 08  mov cl, 0x8
0606  001C D3 E0  shl ax, cl
            L001E: si = ax;
            L0020: ax = GetFacing(player);
0611  0027 03 F0  add si, ax
            L0029: ax = GetFlag(player, 0x02, 0x3A);
0624  003A 88 46 FB  mov [bp-0x5], al
0627  003D 8B C6  mov ax, si
            L003F: Compare(ax, 0x5E02);
            L0042: if (JumpEqual) goto L0064;
            L0044: Compare(ax, 0x5E03);
            L0047: if (JumpEqual) goto L0050;
            L0049: Compare(ax, 0x6C00);
            L004C: if (JumpEqual) goto L006E;
            L004E: goto L0080;
063A  0050 8A 46 FB  mov al, [bp-0x5]
063D  0053 B4 00  mov ah, 0x0
063F  0055 A9 02 00  test ax, 0x2
            L0058: if (JumpEqual) goto L0080;
0644  005A 8C 5E FE  mov [bp-0x2], ds
0647  005D C7 46 FC FC 03  mov word [bp-0x4], 0x3fc
            L0062: goto L0080;
064E  0064 8C 5E FE  mov [bp-0x2], ds
0651  0067 C7 46 FC F3 04  mov word [bp-0x4], 0x4f3
            L006C: goto L0080;
0658  006E 8A 46 FB  mov al, [bp-0x5]
065B  0071 B4 00  mov ah, 0x0
065D  0073 A9 40 00  test ax, 0x40
            L0076: if (JumpEqual) goto L0080;
0662  0078 8C 5E FE  mov [bp-0x2], ds
0665  007B C7 46 FC DF 05  mov word [bp-0x4], 0x5df
066A  0080 8B 46 FC  mov ax, [bp-0x4]
066D  0083 0B 46 FE  or ax, [bp-0x2]
            L0086: if (JumpEqual) goto L00A1;
            L0088: ShowMessage(player, String0D8D); // Poring over the dusty tomes you learn the following:
067F  0095 FF 76 FC  push word [bp-0x4]
0682  0098 C4 5E 06  les bx, [bp+0x6]
0685  009B 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L00A0: cx = PopStack(player);
068B  00A1 5E     pop si
            L00A2: // restore stack ptr: sp = bp;
            L00A4: return; // RETURN;
        }

        private void FnTHRONE_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: ShowMessage(player, String0DC2); // This is a massive throne carved from a single block of polished obsidian.  It is inlaid with strange, beautiful sigils in a delicate silver filigree.
            L0012: ax = GetFlag(player, 0x02, 0x6E);
06B3  0023 88 46 FF  mov [bp-0x1], al
            L0026: ax = GetFlag(player, 0x02, 0x39);
06C7  0037 88 46 FE  mov [bp-0x2], al
06CA  003A B4 00  mov ah, 0x0
06CC  003C A9 04 00  test ax, 0x4
            L003F: if (JumpEqual) goto L0086;
06D1  0041 8A 46 FF  mov al, [bp-0x1]
06D4  0044 24 01  and al, 0x1
06D6  0046 B4 00  mov ah, 0x0
            L0048: RefreshCompareFlags(ax);
            L004A: if (JumpNotEqual) goto L0086;
            L004C: ShowMessage(player, String0E58); // You thrill to the surge of life force coursing into you from the throne.
            L0059: AddExperience(player, 0x00989680);
06FB  006B 80 4E FF 01  or byte [bp-0x1], 0x1
06FF  006F 8A 46 FF  mov al, [bp-0x1]
0702  0072 B4 00  mov ah, 0x0
            L0074: PushStack(player, ax);
            L0075: PushStack(player, 0x6E);
            L0079: PushStack(player, 0x02);
070D  007D C4 5E 06  les bx, [bp+0x6]
0710  0080 26 FF 1F  call far word [es:bx]
0713  0083 83 C4 06  add sp, 0x6
            L0086: // restore stack ptr: sp = bp;
            L0088: return; // RETURN;
        }

        private void FnCSTRSTRT_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0EA1); // Embedded in the front panel of the car is a keyhole.
            L0010: return; // RETURN;
        }

        private void FnRIFT_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0ED6); // The glowing rift is the only way back to your world.
            L0010: TeleportParty(player, 0x08, 0x01, 0x00, 0x33, isForwardMove);
            L002A: return; // RETURN;
        }

        private void FnTOSECRET_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x6B), 0x0003);
            L0017: if (JumpBelow) goto L007F;
            L0019: ShowMessage(player, String0F0B); // You discover a narrow secret passageway.
            L0026: Compare(PartyCount(player), 0x0001);
            L0031: if (JumpBelowOrEqual) goto L0040;
            L0033: ShowMessage(player, String0F34); // You will have to squeeze through one at a time.
            L0040: ax = GetFlag(player, 0x02, 0x6E);
07A9  0051 0D 10 00  or ax, 0x10
            L0054: PushStack(player, ax);
            L0055: PushStack(player, 0x6E);
            L0059: PushStack(player, 0x02);
07B5  005D C4 5E 06  les bx, [bp+0x6]
07B8  0060 26 FF 1F  call far word [es:bx]
07BB  0063 83 C4 06  add sp, 0x6
            L0066: SetWallPassable(player, GetCurrentTile(player), 0x00, 0x01);
            L007F: return; // RETURN;
        }

        private void FnBLKWALL_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0020: return; // RETURN;
        }

        private void FnUSEBNCH_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
07FE  0003 83 EC 06  sub sp, 0x6
0801  0006 C6 46 FE 00  mov byte [bp-0x2], 0x0
0805  000A C7 46 FC 00 00  mov word [bp-0x4], 0x0
080A  000F C7 46 FA 00 00  mov word [bp-0x6], 0x0
            L0014: PushStack(player, 0x00);
            L0017: PushStack(player, 0x0D);
0816  001B C4 5E 06  les bx, [bp+0x6]
0819  001E 26 FF 5F 34  call far word [es:bx+0x34]
            L0022: cx = PopStack(player);
            L0023: cx = PopStack(player);
            L0024: PushStack(player, 0x00);
            L0027: PushStack(player, 0x0E);
0826  002B C4 5E 06  les bx, [bp+0x6]
0829  002E 26 FF 5F 34  call far word [es:bx+0x34]
            L0032: cx = PopStack(player);
            L0033: cx = PopStack(player);
            L0034: PushStack(player, 0x00);
            L0037: PushStack(player, 0x0F);
0836  003B C4 5E 06  les bx, [bp+0x6]
0839  003E 26 FF 5F 34  call far word [es:bx+0x34]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: PushStack(player, 0x00);
            L0047: PushStack(player, 0x1F);
0846  004B C4 5E 06  les bx, [bp+0x6]
0849  004E 26 FF 5F 34  call far word [es:bx+0x34]
            L0052: cx = PopStack(player);
            L0053: cx = PopStack(player);
            L0054: PushStack(player, 0x00);
            L0057: PushStack(player, 0x39);
0856  005B C4 5E 06  les bx, [bp+0x6]
0859  005E 26 FF 5F 34  call far word [es:bx+0x34]
            L0062: cx = PopStack(player);
            L0063: cx = PopStack(player);
            L0064: ax = GetFlag(player, 0x03, 0x06);
0870  0075 88 46 FF  mov [bp-0x1], al
            L0078: ShowMessage(player, String0F64); // Alchemical implements of all descriptions clutter this workbench, including four large black kettles full of bubbling liquid.
            L0085: ax = GetFlag(player, 0x02, 0x3A);
0891  0096 0D 02 00  or ax, 0x2
            L0099: PushStack(player, ax);
            L009A: PushStack(player, 0x3A);
            L009E: PushStack(player, 0x02);
089D  00A2 C4 5E 06  les bx, [bp+0x6]
08A0  00A5 26 FF 1F  call far word [es:bx]
08A3  00A8 83 C4 06  add sp, 0x6
            L00AB: PushStack(player, 0xBA);
            L00AF: PushStack(player, ax);
08AB  00B0 C4 5E 06  les bx, [bp+0x6]
08AE  00B3 26 FF 5F 54  call far word [es:bx+0x54]
            L00B7: cx = PopStack(player);
            L00B8: cx = PopStack(player);
            L00B9: RefreshCompareFlags(ax);
            L00BB: if (JumpEqual) goto L00D9;
08B8  00BD C6 46 FE BA  mov byte [bp-0x2], 0xba
08BC  00C1 80 7E FF 00  cmp byte [bp-0x1], 0x0
            L00C5: if (JumpNotEqual) goto L00D6;
08C2  00C7 C6 46 FF 01  mov byte [bp-0x1], 0x1
08C6  00CB 8C 5E FC  mov [bp-0x4], ds
08C9  00CE C7 46 FA C7 06  mov word [bp-0x6], 0x6c7
            L00D3: goto L0164;
            L00D6: goto L0158;
            L00D9: PushStack(player, 0xBB);
            L00DD: PushStack(player, ax);
08D9  00DE C4 5E 06  les bx, [bp+0x6]
08DC  00E1 26 FF 5F 54  call far word [es:bx+0x54]
            L00E5: cx = PopStack(player);
            L00E6: cx = PopStack(player);
            L00E7: RefreshCompareFlags(ax);
            L00E9: if (JumpEqual) goto L00FD;
08E6  00EB C6 46 FE BB  mov byte [bp-0x2], 0xbb
08EA  00EF 80 7E FF 01  cmp byte [bp-0x1], 0x1
            L00F3: if (JumpNotEqual) goto L00FB;
08F0  00F5 C6 46 FF 02  mov byte [bp-0x1], 0x2
            L00F9: goto L00CB;
            L00FB: goto L0158;
            L00FD: PushStack(player, 0xBC);
            L0101: PushStack(player, ax);
08FD  0102 C4 5E 06  les bx, [bp+0x6]
0900  0105 26 FF 5F 54  call far word [es:bx+0x54]
            L0109: cx = PopStack(player);
            L010A: cx = PopStack(player);
            L010B: RefreshCompareFlags(ax);
            L010D: if (JumpEqual) goto L0121;
090A  010F C6 46 FE BC  mov byte [bp-0x2], 0xbc
090E  0113 80 7E FF 02  cmp byte [bp-0x1], 0x2
            L0117: if (JumpNotEqual) goto L011F;
0914  0119 C6 46 FF 03  mov byte [bp-0x1], 0x3
            L011D: goto L00CB;
            L011F: goto L0158;
            L0121: PushStack(player, 0xE8);
            L0125: PushStack(player, ax);
0921  0126 C4 5E 06  les bx, [bp+0x6]
0924  0129 26 FF 5F 54  call far word [es:bx+0x54]
            L012D: cx = PopStack(player);
            L012E: cx = PopStack(player);
            L012F: RefreshCompareFlags(ax);
            L0131: if (JumpEqual) goto L0164;
092E  0133 C6 46 FE E8  mov byte [bp-0x2], 0xe8
0932  0137 80 7E FF 03  cmp byte [bp-0x1], 0x3
            L013B: if (JumpNotEqual) goto L0158;
0938  013D C6 46 FF 04  mov byte [bp-0x1], 0x4
            L0141: ShowMessage(player, String0FE2); // Eerie green light floods the room as all of the cauldrons begin to boil violently. With an unearthly moan the spirits trapped within begin to stream forth in twisting, vaporous tendrils.
0949  014E 8C 5E FC  mov [bp-0x4], ds
094C  0151 C7 46 FA 3E 07  mov word [bp-0x6], 0x73e
            L0156: goto L0164;
0953  0158 8C 5E FC  mov [bp-0x4], ds
0956  015B C7 46 FA F3 06  mov word [bp-0x6], 0x6f3
095B  0160 C6 46 FF 00  mov byte [bp-0x1], 0x0
095F  0164 80 7E FE 00  cmp byte [bp-0x2], 0x0
            L0168: if (JumpEqual) goto L0178;
0965  016A 8A 46 FE  mov al, [bp-0x2]
0968  016D B4 00  mov ah, 0x0
            L016F: RemoveItem(player, ax);
0973  0178 8B 46 FA  mov ax, [bp-0x6]
0976  017B 0B 46 FC  or ax, [bp-0x4]
            L017E: if (JumpEqual) goto L018C;
097B  0180 FF 76 FA  push word [bp-0x6]
097E  0183 C4 5E 06  les bx, [bp+0x6]
0981  0186 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L018B: cx = PopStack(player);
0987  018C 8A 46 FF  mov al, [bp-0x1]
098A  018F B4 00  mov ah, 0x0
            L0191: PushStack(player, ax);
            L0192: PushStack(player, 0x06);
            L0196: PushStack(player, 0x03);
0995  019A C4 5E 06  les bx, [bp+0x6]
0998  019D 26 FF 1F  call far word [es:bx]
099B  01A0 83 C4 06  add sp, 0x6
            L01A3: // restore stack ptr: sp = bp;
            L01A5: return; // RETURN;
        }

        private void FnTHRNROOM_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: ax = GetFlag(player, 0x02, 0x39);
09B8  0016 25 04 00  and ax, 0x4
            L0019: RefreshCompareFlags(ax);
            L001B: if (JumpEqual) goto L0020;
            L001D: goto L00D1;
            L0020: Compare(GetCurrentTile(player), 0x0023);
            L002A: if (JumpEqual) goto L0038;
            L002C: Compare(ax, 0x0024);
            L002F: if (JumpEqual) goto L0065;
            L0031: Compare(ax, 0x0025);
            L0034: if (JumpEqual) goto L0085;
            L0036: goto L00A2;
            L0038: ShowMessage(player, String109D); // Dazzled, you step into a brightly-lit, vaulted chamber. The musky smell of incense hangs in the air and the delicate music of chimes is audible in the distance.
09E7  0045 C7 46 FE 19 00  mov word [bp-0x2], 0x19
            L004A: SetWallPassable(player, GetCurrentTile(player), 0x00, 0x01);
            L0063: goto L00C0;
            L0065: Compare(GetFacing(player), 0x0002);
            L006F: if (JumpNotEqual) goto L007E;
            L0071: ShowMessage(player, String113E); // Ahead of you through the layers of smoke you see a massive golden throne.
0A20  007E C7 46 FE 19 00  mov word [bp-0x2], 0x19
            L0083: goto L00C0;
            L0085: Compare(GetFacing(player), 0x0002);
            L008F: if (JumpNotEqual) goto L00A0;
            L0091: ShowMessage(player, String1188); // As you draw closer you make out an insoucient figure lounging on the throne, dressed in jester's motley.
            L009E: goto L00BB;
            L00A0: goto L00BB;
            L00A2: Compare(GetFacing(player), 0x0002);
            L00AC: if (JumpNotEqual) goto L00BB;
            L00AE: ShowMessage(player, String11F1); // The crazed figure on the throne stands, stares at you briefly, then prances off to the southeast, cackling like a lunatic. He dives into a pit and vanishes.
0A5D  00BB C7 46 FE 1A 00  mov word [bp-0x2], 0x1a
0A62  00C0 8A 46 FE  mov al, [bp-0x2]
            L00C3: PushStack(player, ax);
0A66  00C4 FF 76 08  push word [bp+0x8]
0A69  00C7 FF 76 06  push word [bp+0x6]
0A6C  00CA 0E     push cs
0A6D  00CB E8 3E F5  call 0xf60c
0A70  00CE 83 C4 06  add sp, 0x6
            L00D1: // restore stack ptr: sp = bp;
            L00D3: return; // RETURN;
        }

        private void FnTREASURE_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0A7A  0003 83 EC 06  sub sp, 0x6
0A7D  0006 C6 46 FE 00  mov byte [bp-0x2], 0x0
0A81  000A C6 46 FD 00  mov byte [bp-0x3], 0x0
0A85  000E C6 46 FC 00  mov byte [bp-0x4], 0x0
            L0012: ax = GetFlag(player, 0x02, 0x6C);
0A9A  0023 88 46 FF  mov [bp-0x1], al
            L0026: ax = GetCurrentTile(player);
0AA4  002D 89 46 FA  mov [bp-0x6], ax
0AA7  0030 B9 05 00  mov cx, 0x5
            L0033: bx = 0x0C2C;
0AAD  0036 2E 8B 07  mov ax, [cs:bx]
0AB0  0039 3B 46 FA  cmp ax, [bp-0x6]
            L003C: if (JumpEqual) goto L0045;
0AB5  003E 43     inc bx
0AB6  003F 43     inc bx
0AB7  0040 E2 F4  loop 0x36
            L0042: goto L00E2;
0ABC  0045 2E FF 67 0A  jmp word [cs:bx+0xa]
0AC0  0049 8A 46 FF  mov al, [bp-0x1]
0AC3  004C 24 01  and al, 0x1
0AC5  004E B4 00  mov ah, 0x0
            L0050: RefreshCompareFlags(ax);
            L0052: if (JumpEqual) goto L0057;
            L0054: goto L00FD;
0ACE  0057 C6 46 FE 0E  mov byte [bp-0x2], 0xe
0AD2  005B C6 46 FD 27  mov byte [bp-0x3], 0x27
0AD6  005F C6 46 FC 4C  mov byte [bp-0x4], 0x4c
0ADA  0063 80 4E FF 01  or byte [bp-0x1], 0x1
            L0067: goto L00FD;
0AE1  006A 8A 46 FF  mov al, [bp-0x1]
0AE4  006D 24 02  and al, 0x2
0AE6  006F B4 00  mov ah, 0x0
            L0071: RefreshCompareFlags(ax);
            L0073: if (JumpEqual) goto L0078;
            L0075: goto L00FD;
0AEF  0078 C6 46 FE 86  mov byte [bp-0x2], 0x86
0AF3  007C C6 46 FD AB  mov byte [bp-0x3], 0xab
0AF7  0080 C6 46 FC 28  mov byte [bp-0x4], 0x28
0AFB  0084 80 4E FF 02  or byte [bp-0x1], 0x2
            L0088: goto L00FD;
            L008A: // NOP
0B02  008B 8A 46 FF  mov al, [bp-0x1]
0B05  008E 24 04  and al, 0x4
0B07  0090 B4 00  mov ah, 0x0
            L0092: RefreshCompareFlags(ax);
            L0094: if (JumpNotEqual) goto L00FD;
0B0D  0096 C6 46 FE 5C  mov byte [bp-0x2], 0x5c
0B11  009A C6 46 FD AB  mov byte [bp-0x3], 0xab
0B15  009E C6 46 FC 3D  mov byte [bp-0x4], 0x3d
0B19  00A2 80 4E FF 04  or byte [bp-0x1], 0x4
            L00A6: goto L00FD;
0B1F  00A8 8A 46 FF  mov al, [bp-0x1]
0B22  00AB 24 10  and al, 0x10
0B24  00AD B4 00  mov ah, 0x0
            L00AF: RefreshCompareFlags(ax);
            L00B1: if (JumpNotEqual) goto L00FD;
0B2A  00B3 C6 46 FE 10  mov byte [bp-0x2], 0x10
0B2E  00B7 C6 46 FD A6  mov byte [bp-0x3], 0xa6
0B32  00BB C6 46 FC 18  mov byte [bp-0x4], 0x18
0B36  00BF 80 4E FF 10  or byte [bp-0x1], 0x10
            L00C3: goto L00FD;
0B3C  00C5 8A 46 FF  mov al, [bp-0x1]
0B3F  00C8 24 20  and al, 0x20
0B41  00CA B4 00  mov ah, 0x0
            L00CC: RefreshCompareFlags(ax);
            L00CE: if (JumpNotEqual) goto L00FD;
0B47  00D0 C6 46 FE AB  mov byte [bp-0x2], 0xab
0B4B  00D4 C6 46 FD 88  mov byte [bp-0x3], 0x88
0B4F  00D8 C6 46 FC 3B  mov byte [bp-0x4], 0x3b
0B53  00DC 80 4E FF 20  or byte [bp-0x1], 0x20
            L00E0: goto L00FD;
0B59  00E2 8A 46 FF  mov al, [bp-0x1]
0B5C  00E5 24 40  and al, 0x40
0B5E  00E7 B4 00  mov ah, 0x0
            L00E9: RefreshCompareFlags(ax);
            L00EB: if (JumpNotEqual) goto L00FD;
0B64  00ED C6 46 FE 5A  mov byte [bp-0x2], 0x5a
0B68  00F1 C6 46 FD AB  mov byte [bp-0x3], 0xab
0B6C  00F5 C6 46 FC 11  mov byte [bp-0x4], 0x11
0B70  00F9 80 4E FF 40  or byte [bp-0x1], 0x40
0B74  00FD 80 7E FE 00  cmp byte [bp-0x2], 0x0
            L0101: if (JumpEqual) goto L013A;
            L0103: ShowMessage(player, String128E); // There is a pile of treasure here!
0B87  0110 8A 46 FE  mov al, [bp-0x2]
0B8A  0113 B4 00  mov ah, 0x0
            L0115: GiveItem(player, ax);
0B95  011E 8A 46 FD  mov al, [bp-0x3]
0B98  0121 B4 00  mov ah, 0x0
            L0123: GiveItem(player, ax);
0BA3  012C 8A 46 FC  mov al, [bp-0x4]
0BA6  012F B4 00  mov ah, 0x0
            L0131: GiveItem(player, ax);
0BB1  013A 8A 46 FF  mov al, [bp-0x1]
0BB4  013D B4 00  mov ah, 0x0
            L013F: PushStack(player, ax);
            L0140: PushStack(player, 0x6C);
            L0144: PushStack(player, 0x02);
0BBF  0148 C4 5E 06  les bx, [bp+0x6]
0BC2  014B 26 FF 1F  call far word [es:bx]
0BC5  014E 83 C4 06  add sp, 0x6
            L0151: // restore stack ptr: sp = bp;
            L0153: return; // RETURN;
            // Extra data: 39 00 3A 00 3B 00 5A 00 5B 00 20 0B 41 0B 62 0B 9C 0B 7F 0B 
        }

        private void FnFREEZER_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, GetEquippedWeapon(player));
            L000C: PushStack(player, GetEquippedWeapon(player));
0BF5  0015 C4 5E 06  les bx, [bp+0x6]
0BF8  0018 26 FF 5F 54  call far word [es:bx+0x54]
            L001C: cx = PopStack(player);
            L001D: cx = PopStack(player);
            L001E: RefreshCompareFlags(ax);
            L0020: if (JumpEqual) goto L0041;
            L0022: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x01);
0C1C  003C B8 B0 12  mov ax, 0x12b0
            L003F: goto L0044;
            L0041: ShowMessage(player, String12D0); // The door is held shut by a hefty padlock which does not appear to have a keyhole.
            L004E: return; // RETURN;
        }

        private void FnSTEAKS_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: PushStack(player, 0x03);
            L0008: PushStack(player, ax);
0C39  0009 C4 5E 06  les bx, [bp+0x6]
0C3C  000C 26 FF 5F 04  call far word [es:bx+0x4]
            L0010: cx = PopStack(player);
            L0011: cx = PopStack(player);
            L0012: si = ax;
            L0014: ax = HasItem(player, 0xEC);
            L0022: if (JumpNotEqual) goto L0050;
            L0024: Compare(si, 0x06);
            L0027: if (JumpNotBelow) goto L0050;
            L0029: ShowMessage(player, String1322); // You find a package of juicy dragon steaks!
            L0036: si = si + 1;
            L0037: si = si + 1;
            L0038: GiveItem(player, 0xEC);
            L0044: GiveItem(player, 0xEC);
0C80  0050 56     push si
            L0051: PushStack(player, 0x03);
            L0055: PushStack(player, ax);
0C86  0056 C4 5E 06  les bx, [bp+0x6]
0C89  0059 26 FF 1F  call far word [es:bx]
0C8C  005C 83 C4 06  add sp, 0x6
            L005F: return; // RETURN (restoring si);
        }

        private void FnMADCAP_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String134D); // A small brass sign on the door reads 'Madcap Labs. Absolutely NO solicitors!'
            L0010: return; // RETURN;
        }

        private void FnSCRTPSG_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(player);
            L000B: Compare(PartyCount(player), 0x0001);
            L0016: if (JumpBelowOrEqual) goto L001D;
0CBC  0018 B8 9B 13  mov ax, 0x139b
            L001B: goto L0036;
            L001D: Compare(GetFlag(player, 0x02, 0x6B), 0x0003);
            L0031: if (JumpNotBelow) goto L005A;
            L0033: ShowMessage(player, String13B6); // You are not worthy.
            L0040: TeleportParty(player, 0x0D, 0x01, 0x0C, 0x00, isForwardMove);
            L005A: return; // RETURN;
        }

        private void FnLIBSIGN_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String13CA); // Above the door is a wooden sign: 'Library. SHHHH!!!!'
            L0010: return; // RETURN;
        }

        private void FnSHADSTSH_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000C);
            L0012: if (JumpBelow) goto L0047;
            L0014: ShowMessage(player, String1400); // You discover a secret compartment in the floor of the closet. A scroll reads 'Commander Shadax, You are to step up the acquisition of mortals for my experiments immediately. Signed, Choronzar'
            L0021: ax = GetFlag(player, 0x02, 0x3A);
0D49  0032 0D 02 00  or ax, 0x2
            L0035: PushStack(player, ax);
            L0036: PushStack(player, 0x3A);
            L003A: PushStack(player, 0x02);
0D55  003E C4 5E 06  les bx, [bp+0x6]
0D58  0041 26 FF 1F  call far word [es:bx]
0D5B  0044 83 C4 06  add sp, 0x6
            L0047: return; // RETURN;
        }

        private void FnCHORKILD_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: ax = GetFlag(player, 0x02, 0x39);
0D76  0016 88 46 FF  mov [bp-0x1], al
            L0019: ax = HasItem(player, 0x71);
            L0027: if (JumpEqual) goto L0069;
0D89  0029 8A 46 FF  mov al, [bp-0x1]
0D8C  002C 24 04  and al, 0x4
0D8E  002E B4 00  mov ah, 0x0
            L0030: RefreshCompareFlags(ax);
            L0032: if (JumpNotEqual) goto L0069;
0D94  0034 80 4E FF 04  or byte [bp-0x1], 0x4
0D98  0038 8A 46 FF  mov al, [bp-0x1]
0D9B  003B B4 00  mov ah, 0x0
            L003D: PushStack(player, ax);
            L003E: PushStack(player, 0x39);
            L0042: PushStack(player, 0x02);
0DA6  0046 C4 5E 06  les bx, [bp+0x6]
0DA9  0049 26 FF 1F  call far word [es:bx]
0DAC  004C 83 C4 06  add sp, 0x6
            L004F: ShowMessage(player, String14C1); // Choronzar's body begins to deliquesce as hissing smoke pours from his bloodied clothes. The room bucks and lurches as shockwaves roll through, knocking you to your knees.
            L005C: ShowMessage(player, String156C); // Over the din of the reverberations you hear a British voice asking 'what was that about HATS?' There is a sickening peal of hysterical, eldritch laughter. Then silence.
            L0069: // restore stack ptr: sp = bp;
            L006B: return; // RETURN;
        }

        private void FnFRZRLCKR_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1615); // This is a freezer-locker.  Oversized blocks of ice stacked half-way to the ceiling keep it very cold in here.
            L0010: return; // RETURN;
        }

        private void FnSETALCH_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x06), 0x0004);
            L0017: if (JumpNotEqual) goto L003F;
            L0019: ax = GetFlag(player, 0x02, 0x6E);
0E0E  002A 0D 02 00  or ax, 0x2
            L002D: PushStack(player, ax);
            L002E: PushStack(player, 0x6E);
            L0032: PushStack(player, 0x02);
0E1A  0036 C4 5E 06  les bx, [bp+0x6]
0E1D  0039 26 FF 1F  call far word [es:bx]
0E20  003C 83 C4 06  add sp, 0x6
            L003F: return; // RETURN;
        }

        private void FnGETPWORD_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: ShowMessage(player, String1683); // On the south wall is a poster depicting a scantily-clad Kaalroth posing beside an enormous tankard of mead. Tearing it aside you discover the word 'SMILE' scrawled on the wall in charcoal.
            L0012: ax = GetFlag(player, 0x03, 0x01);
0E98  0023 88 46 FF  mov [bp-0x1], al
0E9B  0026 80 4E FF 04  or byte [bp-0x1], 0x4
0E9F  002A 8A 46 FF  mov al, [bp-0x1]
0EA2  002D B4 00  mov ah, 0x0
            L002F: PushStack(player, ax);
            L0030: PushStack(player, 0x01);
            L0034: PushStack(player, 0x03);
0EAD  0038 C4 5E 06  les bx, [bp+0x6]
0EB0  003B 26 FF 1F  call far word [es:bx]
0EB3  003E 83 C4 06  add sp, 0x6
            L0041: // restore stack ptr: sp = bp;
            L0043: return; // RETURN;
        }

        private void FnGIVEPWRD_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: ax = GetFlag(player, 0x02, 0x39);
0ED0  0016 A9 08 00  test ax, 0x8
            L0019: if (JumpEqual) goto L0036;
            L001B: SetWallPassable(player, GetCurrentTile(player), 0x00, 0x01);
            L0034: goto L007A;
            L0036: ShowMessage(player, String1740); // A slit in the door shoots open and a gutteral voice demands, 'Wot's th' password?'
            L0043: ax = GetFlag(player, 0x03, 0x01);
0F0E  0054 88 46 FF  mov [bp-0x1], al
0F11  0057 B4 00  mov ah, 0x0
0F13  0059 A9 04 00  test ax, 0x4
            L005C: if (JumpEqual) goto L006D;
            L005E: ShowMessage(player, String1793); // You reply 'the password is 'SMILE',' and the door creaks open. The gaoler growls, 'Come on in so's I can look at ye. One at a time!'
            L006B: goto L001B;
            L006D: ShowMessage(player, String1818); // You stammer helplessly, not knowing the password. 'Come back when ye've remembered it!' The slit slams shut.
            L007A: // restore stack ptr: sp = bp;
            L007C: return; // RETURN;
        }

        private void FnNAOMIA_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: ax = GetFlag(player, 0x02, 0x6B);
0F4E  0016 88 46 FF  mov [bp-0x1], al
0F51  0019 80 7E FF 00  cmp byte [bp-0x1], 0x0
            L001D: if (JumpNotEqual) goto L008F;
0F57  001F FE 46 FF  inc byte [bp-0x1]
0F5A  0022 8A 46 FF  mov al, [bp-0x1]
0F5D  0025 B4 00  mov ah, 0x0
            L0027: PushStack(player, ax);
            L0028: PushStack(player, 0x6B);
            L002C: PushStack(player, 0x02);
0F68  0030 C4 5E 06  les bx, [bp+0x6]
0F6B  0033 26 FF 1F  call far word [es:bx]
0F6E  0036 83 C4 06  add sp, 0x6
            L0039: ShowPortrait(player, 0x002C);
            L0046: ShowMessage(player, String1885); // You step into the dismal little cell and draw up short. Before you stands a radiant woman in a flowing, violet gown. She is slender and graceful but her eyes bore into you with unnerving intensity.
            L0053: ShowMessage(player, String194B); // 'Enough!' she cries. 'I grow tired of these pathetic ruses. Tell your master my answer is 'NO!'' Before you can respond she stalks past you and is gone.
            L0060: ax = GetFlag(player, 0x02, 0x3A);
0FA9  0071 88 46 FF  mov [bp-0x1], al
0FAC  0074 80 4E FF 40  or byte [bp-0x1], 0x40
0FB0  0078 8A 46 FF  mov al, [bp-0x1]
0FB3  007B B4 00  mov ah, 0x0
            L007D: PushStack(player, ax);
            L007E: PushStack(player, 0x3A);
            L0082: PushStack(player, 0x02);
0FBE  0086 C4 5E 06  les bx, [bp+0x6]
0FC1  0089 26 FF 1F  call far word [es:bx]
0FC4  008C 83 C4 06  add sp, 0x6
            L008F: // restore stack ptr: sp = bp;
            L0091: return; // RETURN;
        }

        private void FnSOFCDESC_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String19E4); // Charts and war-trophies decorate the walls of this military command center. Several crude desks are strewn with scrolls and parchments.
            L0010: return; // RETURN;
        }

        private void FnSHDXBDRM_36(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1A6C); // This room, though spartan, appears to be the personal quarters of a high-ranking officer.
            L0010: return; // RETURN;
        }

        private void FnSCPNTNG_37(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1AC6); // A portrait on the north wall depicts Shadax and a snake-woman posing in their wedding clothes. 'Shadax and Chiss, 8743 A.C.'
            L0010: return; // RETURN;
        }

        private void FnCSTRMSG_38(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1B43); // Before you gleams a wondrous, cunningly crafted chariot. Fashioned of hardwood and steel, it has been gaudily painted in glossy red and green lacquers. In front of the first car two shiny rails extend into the darkness to the north.
            L0010: return; // RETURN;
        }

        private void FnLVRPUZZ_39(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
1016  0003 83 EC 04  sub sp, 0x4
            L0006: ShowMessage(player, String1C2C); // You pull the lever.
            L0013: ax = GetFlag(player, 0x03, 0x00);
1036  0023 88 46 FF  mov [bp-0x1], al
            L0026: ax = GetCurrentTile(player);
1040  002D 89 46 FC  mov [bp-0x4], ax
1043  0030 B9 04 00  mov cx, 0x4
            L0033: bx = 0x115D;
1049  0036 2E 8B 07  mov ax, [cs:bx]
104C  0039 3B 46 FC  cmp ax, [bp-0x4]
            L003C: if (JumpEqual) goto L0044;
1051  003E 43     inc bx
1052  003F 43     inc bx
1053  0040 E2 F4  loop 0x36
            L0042: goto L00AA;
1057  0044 2E FF 67 08  jmp word [cs:bx+0x8]
105B  0048 80 7E FF 00  cmp byte [bp-0x1], 0x0
            L004C: if (JumpNotEqual) goto L0054;
1061  004E C6 46 FF 01  mov byte [bp-0x1], 0x1
            L0052: goto L00AE;
            L0054: goto L00AA;
1069  0056 80 7E FF 01  cmp byte [bp-0x1], 0x1
            L005A: if (JumpNotEqual) goto L0062;
106F  005C C6 46 FF 02  mov byte [bp-0x1], 0x2
            L0060: goto L00AE;
            L0062: goto L00AA;
1077  0064 80 7E FF 02  cmp byte [bp-0x1], 0x2
            L0068: if (JumpNotEqual) goto L0070;
107D  006A C6 46 FF 03  mov byte [bp-0x1], 0x3
            L006E: goto L00AE;
            L0070: goto L00AA;
1085  0072 80 7E FF 03  cmp byte [bp-0x1], 0x3
            L0076: if (JumpNotEqual) goto L00AE;
            L0078: SetWallObject(player, 0x01, 0x7F, 0x03);
            L008E: SetWallPassable(player, 0x7F, 0x03, 0x01);
10B7  00A4 C6 46 FF 04  mov byte [bp-0x1], 0x4
            L00A8: goto L00AE;
10BD  00AA C6 46 FF 00  mov byte [bp-0x1], 0x0
10C1  00AE 80 7E FF 00  cmp byte [bp-0x1], 0x0
            L00B2: if (JumpNotEqual) goto L00B9;
10C7  00B4 B8 40 1C  mov ax, 0x1c40
            L00B7: goto L00C6;
10CC  00B9 80 7E FF 04  cmp byte [bp-0x1], 0x4
            L00BD: if (JumpNotEqual) goto L00D0;
10D2  00BF C6 46 FF 00  mov byte [bp-0x1], 0x0
            L00C3: ShowMessage(player, String1C67); // You hear a rumbling sound to the east.
10E3  00D0 8A 46 FF  mov al, [bp-0x1]
10E6  00D3 B4 00  mov ah, 0x0
            L00D5: PushStack(player, ax);
            L00D6: PushStack(player, 0x00);
            L00D9: PushStack(player, 0x03);
10F0  00DD C4 5E 06  les bx, [bp+0x6]
10F3  00E0 26 FF 1F  call far word [es:bx]
10F6  00E3 83 C4 06  add sp, 0x6
            L00E6: // restore stack ptr: sp = bp;
            L00E8: return; // RETURN;
            // Extra data: 57 00 6B 00 79 00 99 00 BB 10 C9 10 E5 10 D7 10 
        }

        private void FnSTORROOM_3A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1C8E); // This is a storage room. Barrels and crates are stacked haphazardly.
            L0010: return; // RETURN;
        }

        private void FnSORDERS_3B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: ShowMessage(player, String1CD2); // Buried beneath a stack of papers you find a scroll: 'Commander Shadax, It seems the princess prefers a gaol cell to the comforts of her chambers. Advise the Gaoler that she may come and go as she pleases. Signed, Choronzar'
            L0012: ax = GetFlag(player, 0x02, 0x3A);
1142  0023 88 46 FF  mov [bp-0x1], al
1145  0026 80 4E FF 40  or byte [bp-0x1], 0x40
1149  002A 8A 46 FF  mov al, [bp-0x1]
114C  002D B4 00  mov ah, 0x0
            L002F: PushStack(player, ax);
            L0030: PushStack(player, 0x3A);
            L0034: PushStack(player, 0x02);
1157  0038 C4 5E 06  les bx, [bp+0x6]
115A  003B 26 FF 1F  call far word [es:bx]
115D  003E 83 C4 06  add sp, 0x6
            L0041: // restore stack ptr: sp = bp;
            L0043: return; // RETURN;
        }

        private void FnCHISS_64(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xED);
            L0011: if (JumpNotEqual) goto L0048;
            L0013: ShowMessage(player, String1DB2); // A gigantic snake-woman looms over you, swaying hypnotically. 'Yessss,' she hisses, 'it will be sweet revenge to taste the mortal blood that stole my husband Shadax!'
            L0020: PushStack(player, 0x00);
            L0023: PushStack(player, ax);
            L0024: PushStack(player, ax);
            L0025: PushStack(player, ax);
            L0026: PushStack(player, ax);
            L0027: PushStack(player, 0xED);
1257  002B C4 5E 06  les bx, [bp+0x6]
125A  002E 26 FF 9F D8 00  call far word [es:bx+0xd8]
125F  0033 83 C4 0C  add sp, 0xc
            L0036: AddEncounter(player, 0x01, 0x27);
            L0048: return; // RETURN;
        }

        private void FnSHADAX_65(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: ax = GetFlag(player, 0x02, 0x39);
128C  0016 88 46 FF  mov [bp-0x1], al
128F  0019 24 01  and al, 0x1
1291  001B B4 00  mov ah, 0x0
            L001D: RefreshCompareFlags(ax);
            L001F: if (JumpNotEqual) goto L007C;
            L0021: ShowMessage(player, String1E58); // You feel a rush of vertigo as you pass through the rift.
            L002E: ShowMessage(player, String1E91); // Before you towers an enormous Kaalroth in full battle dress. 'Who dares to invade the realm of Choronzar?', he roars. 'I, Shadax, shall see that you never return!'
            L003B: ax = GetFlag(player, 0x02, 0x3A);
12C2  004C 88 46 FF  mov [bp-0x1], al
12C5  004F 80 4E FF 08  or byte [bp-0x1], 0x8
12C9  0053 8A 46 FF  mov al, [bp-0x1]
12CC  0056 B4 00  mov ah, 0x0
            L0058: PushStack(player, ax);
            L0059: PushStack(player, 0x3A);
            L005D: PushStack(player, 0x02);
12D7  0061 C4 5E 06  les bx, [bp+0x6]
12DA  0064 26 FF 1F  call far word [es:bx]
12DD  0067 83 C4 06  add sp, 0x6
            L006A: AddEncounter(player, 0x01, 0x1B);
            L007C: // restore stack ptr: sp = bp;
            L007E: return; // RETURN;
        }

        private void FnNAOMIB_67(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: ax = GetFlag(player, 0x02, 0x6B);
1311  0016 88 46 FF  mov [bp-0x1], al
1314  0019 80 7E FF 00  cmp byte [bp-0x1], 0x0
            L001D: if (JumpBelowOrEqual) goto L0061;
131A  001F 80 7E FF 03  cmp byte [bp-0x1], 0x3
            L0023: if (JumpNotBelow) goto L0061;
            L0025: PushStack(player, 0x00);
            L0028: PushStack(player, ax);
1324  0029 C4 5E 06  les bx, [bp+0x6]
1327  002C 26 FF 5F 0C  call far word [es:bx+0xc]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpEqual) goto L0061;
            L0036: ShowPortrait(player, 0x002C);
            L0043: ShowMessage(player, String1F35); // You clamber from the muddy water onto the island. Naomi is here.
            L0050: PushStack(player, 0x01);
            L0054: PushStack(player, 0x00);
            L0057: PushStack(player, ax);
1353  0058 C4 5E 06  les bx, [bp+0x6]
1356  005B 26 FF 1F  call far word [es:bx]
1359  005E 83 C4 06  add sp, 0x6
135C  0061 8A 46 FF  mov al, [bp-0x1]
135F  0064 B4 00  mov ah, 0x0
            L0066: Compare(ax, 0x0001);
            L0069: if (JumpEqual) goto L0073;
            L006B: Compare(ax, 0x0002);
            L006E: if (JumpEqual) goto L0092;
            L0070: goto L011B;
            L0073: ShowMessage(player, String1F76); // 'Well,' she says icily, 'you are persistent in your mendacity, I grant you that.' She smiles slyly. 'If you really want me to believe you were not sent by Choronzar then find and return my Spirit Bottle!'
            L0080: GiveItem(player, 0xFA);
1387  008C FE 46 FF  inc byte [bp-0x1]
            L008F: goto L011B;
            L0092: PushStack(player, 0xE7);
            L0096: PushStack(player, ax);
1392  0097 C4 5E 06  les bx, [bp+0x6]
1395  009A 26 FF 5F 54  call far word [es:bx+0x54]
            L009E: cx = PopStack(player);
            L009F: cx = PopStack(player);
            L00A0: RefreshCompareFlags(ax);
            L00A2: if (JumpEqual) goto L00F2;
            L00A4: RemoveItem(player, 0xE7);
            L00B0: ShowMessage(player, String2043); // You offer the Spirit Bottle to Naomi. She snatches it from your hand and squints at it suspiciously. Then her eyes widen and her expression softens.
            L00BD: ShowMessage(player, String20D8); // 'I have misjudged you,' she says quietly. 'My debt to you is so great that I can never hope to repay it. Still, I will do what I can.
            L00CA: ShowMessage(player, String215E); // I once saw Choronzar slip through a secret passageway in the back of his laboratory. I believe it leads to his throne room!  Perhaps you can use it to circumvent his many guards.
            L00D7: ShowMessage(player, String2211); // Now I must go. Farewell, and may Fortune smile upon you always!' She uncorks the bottle and a cloud of coruscating crimson fog quickly envelops her.  'I no longer exist here!'
13DF  00E4 B8 C1 22  mov ax, 0x22c1
            L00E7: PushStack(player, ax);
13E3  00E8 C4 5E 06  les bx, [bp+0x6]
13E6  00EB 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L00F0: goto L008B;
            L00F2: ShowMessage(player, String22E4); // Naomi snaps, 'Have you brought my Spirit Bottle, or is this another feeble attempt to deceive me?'
            L00FF: ax = HasItem(player, 0xFA);
            L010D: if (JumpNotEqual) goto L011B;
            L010F: GiveItem(player, 0xFA);
1416  011B 8A 46 FF  mov al, [bp-0x1]
1419  011E B4 00  mov ah, 0x0
            L0120: PushStack(player, ax);
            L0121: PushStack(player, 0x6B);
            L0125: PushStack(player, 0x02);
1424  0129 C4 5E 06  les bx, [bp+0x6]
1427  012C 26 FF 1F  call far word [es:bx]
142A  012F 83 C4 06  add sp, 0x6
            L0132: // restore stack ptr: sp = bp;
            L0134: return; // RETURN;
        }

        private void FnCONCRG_68(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: ax = GetFlag(player, 0x03, 0x01);
1447  0016 88 46 FF  mov [bp-0x1], al
144A  0019 24 01  and al, 0x1
144C  001B B4 00  mov ah, 0x0
            L001D: RefreshCompareFlags(ax);
            L001F: if (JumpNotEqual) goto L006A;
            L0021: ShowPortrait(player, 0x002D);
            L002E: ShowMessage(player, String2347); // An owlish man sits poring over some documents behind an imposing, oaken desk. Without glancing up he gestures toward a ledger-book. 'Sign in please.'
146C  003B 80 4E FF 01  or byte [bp-0x1], 0x1
1470  003F 8A 46 FF  mov al, [bp-0x1]
1473  0042 B4 00  mov ah, 0x0
            L0044: PushStack(player, ax);
            L0045: PushStack(player, 0x01);
            L0049: PushStack(player, 0x03);
147E  004D C4 5E 06  les bx, [bp+0x6]
1481  0050 26 FF 1F  call far word [es:bx]
1484  0053 83 C4 06  add sp, 0x6
            L0056: SetFlag(player, 0x03, 0x04, 0x00);
            L006A: // restore stack ptr: sp = bp;
            L006C: return; // RETURN;
        }

        private void FnGRDAPST_69(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
14A2  0003 B0 04  mov al, 0x4
            L0005: PushStack(player, ax);
14A5  0006 FF 76 08  push word [bp+0x8]
14A8  0009 FF 76 06  push word [bp+0x6]
14AB  000C 0E     push cs
14AC  000D E8 FF EA  call 0xeb0f
14AF  0010 83 C4 06  add sp, 0x6
            L0013: return; // RETURN;
        }

        private void FnGRDAWNDR_6A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
14B7  0003 B0 0B  mov al, 0xb
            L0005: PushStack(player, ax);
14BA  0006 FF 76 08  push word [bp+0x8]
14BD  0009 FF 76 06  push word [bp+0x6]
14C0  000C 0E     push cs
14C1  000D E8 EA EA  call 0xeafa
14C4  0010 83 C4 06  add sp, 0x6
            L0013: return; // RETURN;
        }

        private void FnGRDARLX_6B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
14CC  0003 B0 03  mov al, 0x3
            L0005: PushStack(player, ax);
14CF  0006 FF 76 08  push word [bp+0x8]
14D2  0009 FF 76 06  push word [bp+0x6]
14D5  000C 0E     push cs
14D6  000D E8 D5 EA  call 0xeae5
14D9  0010 83 C4 06  add sp, 0x6
            L0013: return; // RETURN;
        }

        private void FnGRDBPST_6C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
14E1  0003 B0 18  mov al, 0x18
            L0005: PushStack(player, ax);
14E4  0006 FF 76 08  push word [bp+0x8]
14E7  0009 FF 76 06  push word [bp+0x6]
14EA  000C 0E     push cs
14EB  000D E8 C0 EA  call 0xead0
14EE  0010 83 C4 06  add sp, 0x6
            L0013: return; // RETURN;
        }

        private void FnGRDBWNDR_6D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
14F6  0003 B0 16  mov al, 0x16
            L0005: PushStack(player, ax);
14F9  0006 FF 76 08  push word [bp+0x8]
14FC  0009 FF 76 06  push word [bp+0x6]
14FF  000C 0E     push cs
1500  000D E8 AB EA  call 0xeabb
1503  0010 83 C4 06  add sp, 0x6
            L0013: return; // RETURN;
        }

        private void FnHALLDETH_6E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
150B  0003 83 EC 04  sub sp, 0x4
            L0006: ax = GetFlag(player, 0x03, 0x01);
151F  0017 88 46 FF  mov [bp-0x1], al
            L001A: ax = GetFlag(player, 0x03, 0x04);
1533  002B 88 46 FE  mov [bp-0x2], al
            L002E: PushStack(player, 0x00);
            L0031: PushStack(player, ax);
153A  0032 C4 5E 06  les bx, [bp+0x6]
153D  0035 26 FF 5F 0C  call far word [es:bx+0xc]
            L0039: cx = PopStack(player);
            L003A: cx = PopStack(player);
            L003B: RefreshCompareFlags(ax);
            L003D: if (JumpEqual) goto L006A;
1547  003F 8A 46 FF  mov al, [bp-0x1]
154A  0042 B4 00  mov ah, 0x0
154C  0044 A9 01 00  test ax, 0x1
            L0047: if (JumpEqual) goto L006A;
            L0049: ShowMessage(player, String23DD); // You trudge forward down the Hall of Death.
155E  0056 FE 46 FE  inc byte [bp-0x2]
            L0059: PushStack(player, 0x01);
            L005D: PushStack(player, 0x00);
            L0060: PushStack(player, ax);
1569  0061 C4 5E 06  les bx, [bp+0x6]
156C  0064 26 FF 1F  call far word [es:bx]
156F  0067 83 C4 06  add sp, 0x6
1572  006A 8A 46 FF  mov al, [bp-0x1]
1575  006D B4 00  mov ah, 0x0
1577  006F A9 01 00  test ax, 0x1
            L0072: if (JumpEqual) goto L00A2;
157C  0074 8A 46 FE  mov al, [bp-0x2]
157F  0077 B4 00  mov ah, 0x0
            L0079: bx = 0x0003;
            L007C: dx = ax % bx; ax = ax / bx;
1587  007F 89 46 FC  mov [bp-0x4], ax
158A  0082 83 7E FC 06  cmp word [bp-0x4], 0x6
            L0086: if (JumpBelowOrEqual) goto L008D;
1590  0088 C7 46 FC 06 00  mov word [bp-0x4], 0x6
1595  008D 83 46 FC 1C  add word [bp-0x4], 0x1c
1599  0091 8A 46 FC  mov al, [bp-0x4]
            L0094: PushStack(player, ax);
159D  0095 FF 76 08  push word [bp+0x8]
15A0  0098 FF 76 06  push word [bp+0x6]
15A3  009B 0E     push cs
15A4  009C E8 07 EA  call 0xeaa6
15A7  009F 83 C4 06  add sp, 0x6
15AA  00A2 8A 46 FE  mov al, [bp-0x2]
15AD  00A5 B4 00  mov ah, 0x0
            L00A7: PushStack(player, ax);
            L00A8: PushStack(player, 0x04);
            L00AC: PushStack(player, 0x03);
15B8  00B0 C4 5E 06  les bx, [bp+0x6]
15BB  00B3 26 FF 1F  call far word [es:bx]
15BE  00B6 83 C4 06  add sp, 0x6
            L00B9: // restore stack ptr: sp = bp;
            L00BB: return; // RETURN;
        }

        private void FnKEKEKTL_6F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
15CA  0005 56     push si
15CB  0006 57     push di
            L0007: di = 0x0022;
            L000A: ax = GetFlag(player, 0x03, 0x01);
15E0  001B A9 01 00  test ax, 0x1
            L001E: if (JumpNotEqual) goto L0023;
            L0020: goto L00A7;
            L0023: ax = GetFlag(player, 0x03, 0x01);
15F9  0034 88 46 FF  mov [bp-0x1], al
15FC  0037 24 08  and al, 0x8
15FE  0039 B4 00  mov ah, 0x0
            L003B: RefreshCompareFlags(ax);
            L003D: if (JumpNotEqual) goto L0052;
            L003F: ShowMessage(player, String2408); // This antechamber is littered with bones. As you step forward some of the grisly debris flies up and forms itself into a horrific, skeletal figure. 'I am Kekeketl,' it rasps. 'I am sworn to defend this place.'
1611  004C 80 4E FF 08  or byte [bp-0x1], 0x8
            L0050: goto L005F;
            L0052: ShowMessage(player, String24D9); // You advance, and once more Kekeketl rises from the carnage. 'I have told thee, I am sworn to defend this place.'
1624  005F 8A 46 FF  mov al, [bp-0x1]
1627  0062 B4 00  mov ah, 0x0
            L0064: PushStack(player, ax);
            L0065: PushStack(player, 0x01);
            L0069: PushStack(player, 0x03);
1632  006D C4 5E 06  les bx, [bp+0x6]
1635  0070 26 FF 1F  call far word [es:bx]
1638  0073 83 C4 06  add sp, 0x6
            L0076: AddEncounter(player, 0x01, 0x23);
            L0088: si = 0x0002;
            L008B: goto L009A;
1652  008D 57     push di
1653  008E 56     push si
1654  008F C4 5E 06  les bx, [bp+0x6]
1657  0092 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0097: cx = PopStack(player);
            L0098: cx = PopStack(player);
            L0099: si = si + 1;
            L009A: ax = PartyCount(player);
1667  00A2 40     inc ax
            L00A3: Compare(ax, si);
            L00A5: if (JumpNotBelow) goto L008D;
166C  00A7 5F     pop di
166D  00A8 5E     pop si
            L00A9: // restore stack ptr: sp = bp;
            L00AB: return; // RETURN;
        }

        private void FnGAOLER_70(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetFlag(player, 0x02, 0x39);
1686  0014 25 08 00  and ax, 0x8
            L0017: RefreshCompareFlags(ax);
            L0019: if (JumpNotEqual) goto L006E;
            L001B: Compare(PartyCount(player), 0x0001);
            L0026: if (JumpBelowOrEqual) goto L004F;
            L0028: ShowMessage(player, String254A); // As you step through the door the Gaoler pushes you back roughly. 'One at a time!' he growls.
            L0035: TeleportParty(player, 0x0D, 0x01, 0xF9, 0x00, isForwardMove);
            L004F: ShowMessage(player, String25A7); // As you step into the light the Gaoler flies into a rage. 'Wot's this then?' he cries. 'Oi've been tricked!'
            L005C: AddEncounter(player, 0x01, 0x24);
            L006E: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x01);
            L0088: return; // RETURN;
        }

        private void FnGRDDPST_71(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
16FF  0003 B0 10  mov al, 0x10
            L0005: PushStack(player, ax);
1702  0006 FF 76 08  push word [bp+0x8]
1705  0009 FF 76 06  push word [bp+0x6]
1708  000C 0E     push cs
1709  000D E8 A2 E8  call 0xe8b2
170C  0010 83 C4 06  add sp, 0x6
            L0013: return; // RETURN;
        }

        private void FnCHORNZAR_72(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
1716  0005 56     push si
            L0006: SetWallPassable(player, GetCurrentTile(player), ax, 0x00);
            L001C: ax = GetFlag(player, 0x02, 0x6E);
173E  002D 88 46 FF  mov [bp-0x1], al
            L0030: ax = GetFlag(player, 0x02, 0x39);
1752  0041 88 46 FE  mov [bp-0x2], al
1755  0044 8A 46 FF  mov al, [bp-0x1]
1758  0047 B4 00  mov ah, 0x0
175A  0049 A9 10 00  test ax, 0x10
            L004C: if (JumpEqual) goto L00B7;
175F  004E 8A 46 FE  mov al, [bp-0x2]
1762  0051 24 04  and al, 0x4
1764  0053 B4 00  mov ah, 0x0
            L0055: RefreshCompareFlags(ax);
            L0057: if (JumpNotEqual) goto L00B7;
            L0059: ShowMessage(player, String2613); // You rush through the wall and surprise Choronzar pacing behind his throne!
1777  0066 8A 46 FF  mov al, [bp-0x1]
177A  0069 B4 00  mov ah, 0x0
177C  006B A9 02 00  test ax, 0x2
            L006E: if (JumpEqual) goto L0082;
            L0070: ShowMessage(player, String265E); // He shrieks and turns to flee, but you are upon him in an instant.
            L007D: si = 0x0025;
            L0080: goto L0092;
            L0082: ShowMessage(player, String26A0); // He smiles grimly. 'So it comes to this? % I hope you know what you're doing.'
            L008F: si = 0x0026;
            L0092: PushStack(player, 0x00);
            L0095: PushStack(player, ax);
            L0096: PushStack(player, ax);
            L0097: PushStack(player, ax);
            L0098: PushStack(player, ax);
            L0099: PushStack(player, 0x71);
17AE  009D C4 5E 06  les bx, [bp+0x6]
17B1  00A0 26 FF 9F D8 00  call far word [es:bx+0xd8]
17B6  00A5 83 C4 0C  add sp, 0xc
17B9  00A8 56     push si
            L00A9: PushStack(player, 0x01);
17BE  00AD C4 5E 06  les bx, [bp+0x6]
17C1  00B0 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L00B5: cx = PopStack(player);
            L00B6: cx = PopStack(player);
17C8  00B7 5E     pop si
            L00B8: // restore stack ptr: sp = bp;
            L00BA: return; // RETURN;
        }

        private void FnGRDDWNDR_73(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
17D0  0003 B0 11  mov al, 0x11
            L0005: PushStack(player, ax);
17D3  0006 FF 76 08  push word [bp+0x8]
17D6  0009 FF 76 06  push word [bp+0x6]
17D9  000C 0E     push cs
17DA  000D E8 D1 E7  call 0xe7e1
17DD  0010 83 C4 06  add sp, 0x6
            L0013: return; // RETURN;
        }

        private void FnSHDXKLLD_74(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: ax = GetFlag(player, 0x02, 0x39);
17F8  0016 88 46 FF  mov [bp-0x1], al
17FB  0019 80 4E FF 01  or byte [bp-0x1], 0x1
17FF  001D 8A 46 FF  mov al, [bp-0x1]
1802  0020 B4 00  mov ah, 0x0
            L0022: PushStack(player, ax);
            L0023: PushStack(player, 0x39);
            L0027: PushStack(player, 0x02);
180D  002B C4 5E 06  les bx, [bp+0x6]
1810  002E 26 FF 1F  call far word [es:bx]
1813  0031 83 C4 06  add sp, 0x6
            L0034: // restore stack ptr: sp = bp;
            L0036: return; // RETURN;
        }

        private void FnGLRKLLD_75(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: ax = GetFlag(player, 0x02, 0x39);
1830  0016 88 46 FF  mov [bp-0x1], al
1833  0019 80 4E FF 08  or byte [bp-0x1], 0x8
1837  001D 8A 46 FF  mov al, [bp-0x1]
183A  0020 B4 00  mov ah, 0x0
            L0022: PushStack(player, ax);
            L0023: PushStack(player, 0x39);
            L0027: PushStack(player, 0x02);
1845  002B C4 5E 06  les bx, [bp+0x6]
1848  002E 26 FF 1F  call far word [es:bx]
184B  0031 83 C4 06  add sp, 0x6
            L0034: // restore stack ptr: sp = bp;
            L0036: return; // RETURN;
        }

    }
}
