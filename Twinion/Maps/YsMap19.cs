#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap19 : AMapScripted {
        protected override int MapIndex => 19;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 1;

        public YserMap19() {
            MapEvent01 = FnDETHLAVA_01;
            MapEvent02 = FnDETHPIT_02;
            MapEvent03 = FnRIVER_03;
            MapEvent04 = FnSPCPIT_04;
            MapEvent05 = FnSPCLAVA_05;
            MapEvent06 = FnMAINEXIT_06;
            MapEvent07 = FnCHESMESS_07;
            MapEvent08 = FnEREBUSA_08;
            MapEvent0A = FnCOMMONDR_0A;
            MapEvent0B = FnTOMACS_0B;
            MapEvent0C = FnSECRTDOR_0C;
            MapEvent0D = FnGRTDRAGN_0D;
            MapEvent0E = FnHEATSQRS_0E;
            MapEvent0F = FnFIREBALS_0F;
            MapEvent10 = FnGASTRAP_10;
            MapEvent11 = FnLAIRDESC_11;
            MapEvent12 = FnREDKNIGT_12;
            MapEvent13 = FnKNITRED_13;
            MapEvent14 = FnCRNRROOK_14;
            MapEvent15 = FnPAWNBLCK_15;
            MapEvent16 = FnREDKNIGT_16;
            MapEvent17 = FnBLCKING_17;
            MapEvent18 = FnREDARCH_18;
            MapEvent19 = FnPSNSCRIP_19;
            MapEvent1F = FnBLCDRAG_1F;
            MapEvent20 = FnSMLERBUS_20;
            MapEvent21 = FnPISNFNT_21;
            MapEvent22 = FnHEALFNT_22;
            MapEvent23 = FnMANAFNT_23;
            MapEvent24 = FnMANAVAPR_24;
            MapEvent25 = FnTHRULLS_25;
            MapEvent26 = FnOWNER_26;
            MapEvent27 = FnTRAINER_27;
            MapEvent28 = FnTOCHESS_28;
            MapEvent2A = FnSMLPRAX_2A;
            MapEvent2B = FnNPCTHRUL_2B;
            MapEvent2C = FnNPCPLYER_2C;
            MapEvent2D = FnTUFNPCS_2D;
            MapEvent2E = FnBOOKS_2E;
            MapEvent2F = FnTODRAGB_2F;
            MapEvent30 = FnTODRAGA_30;
            MapEvent31 = FnSETFLAG_31;
            MapEvent32 = FnMAPDESCR_32;
            MapEvent33 = FnPORTME_33;
            MapEvent34 = FnQAOCHESS_34;
            MapEvent35 = FnLAVAGLOV_35;
            MapEvent37 = FnQUIKMAST_37;
            MapEvent38 = FnSETFLAG_38;
            MapEvent39 = FnQUICERBS_39;
            MapEvent3B = FnNOJOIN_3B;
            MapEvent3C = FnTOMRMORE_3C;
            MapEvent3D = FnQAOSRVNT_3D;
        }
        
        // === Strings ================================================
        private const string String03FC = "The molten lava incinerates you!";
        private const string String041D = "You fall helplessly into oblivion.";
        private const string String0440 = "The unusual force within this green blue fluid saps your magic powers.";
        private const string String0487 = "You bravely step onto this illusionary pit!";
        private const string String04B3 = "The Lava Glove has led you to an illusionary lava pit!";
        private const string String04EA = "The lava here is an illusion!";
        private const string String0508 = "To the Main Entrance.";
        private const string String051E = "You enter an enormous chessboard arena. It differs greatly from the one built by Arnakkian so many moons ago.";
        private const string String058C = "The red marble and onyx floor are truly beautiful.";
        private const string String05BF = "You notice, however, that the pieces are not mere toys. They are real creatures. A black dragon, a white knight, and many others are present.";
        private const string String064D = "An ominous Erebus is seated against the southern wall. Next to him stands a magnificent Praxis.";
        private const string String06AD = "They appear to be controlling the pieces, one of which you have now become.";
        private const string String06F9 = "Once again you enter the board.";
        private const string String0719 = "The Erebus laughs at you.";
        private const string String0733 = "'Away with you! You have not earned the right to challenge me!'";
        private const string String0773 = "The Erebus' laugh is loud and obnoxious. 'You puny mortals have no faith in games. Let us play another one, to the death!'";
        private const string String07EE = "The Praxis flaps his wings.";
        private const string String080A = "'Come, my friends, let us not be hasty.";
        private const string String0832 = "I shall give you one chance to flee. Then you shall suffer my wrath.'";
        private const string String0878 = "The Praxis' wings flap powerful bursts of magical winds at you.";
        private const string String08B8 = "'Enough! You have earned my rage!'";
        private const string String08DB = "This chess master now lays dead upon his throne.";
        private const string String090C = "An eerie blue light sifts through a fissure in the wall.";
        private const string String0945 = "I wouldn't venture here until you've completed the tasks Aeowyn has enjoined you with - namely, destroying the Dralkarians!";
        private const string String09C1 = "You must enter here alone!";
        private const string String09DC = "The ancient stones become a portal.";
        private const string String0A00 = "Qao Tsur slowly opens his eyes, now thin slits of black in green-gold spheres. He sniffs at you.";
        private const string String0A61 = "His booming voice shakes the walls.";
        private const string String0A85 = "'So, mere mortals have at last appeared to seek the Dralkarians.";
        private const string String0AC6 = "Your puny magics will not save you. I once stood at claw's length with the mighty beasts. You are no match for them in your weakling state.";
        private const string String0B52 = "Go, seek my feuding children below. They will offer you a task more suited to your abilities.";
        private const string String0BB0 = "The Dralkarians will require special means before YOU can even dream of defeating them.";
        private const string String0C08 = "The chessmasters await you, you must outwit them...";
        private const string String0C3C = "...or out-fight them.";
        private const string String0C52 = "I offer you this advice, listen not to vain words of empty tongue.'";
        private const string String0C96 = "Qao then recedes into his slumber, ignoring you.";
        private const string String0CC7 = "Qao ignores you in his uneasy sleep.";
        private const string String0CEC = "The tremendous heat is devastating here.";
        private const string String0D15 = "As you round the corner of this Dragon's Lair, a series of fire-bursts fly from the shadows, scorching you.";
        private const string String0D81 = "Poisonous gases seep into this area.";
        private const string String0DA6 = "An ancient Red Dragon lies on his mountain of gold and other booty. As you enter his lair, you are weakened by the tremendous heat.";
        private const string String0E2A = "You may leave the board through here.";
        private const string String0E50 = "The lair is filled with lava pools and noxious odors.";
        private const string String0E86 = "A group of young Erebus move towards you, mumbling in their guttural tongue.";
        private const string String0ED3 = "The sweet waters feel refreshing at first, but soon make you feel nauseated.";
        private const string String0F20 = "The fountain's sickening waters churn in your stomach, but slowly you begin feeling revived and healthy!";
        private const string String0F89 = "These sparkling waters are magical in nature and instantly restore your mana level.";
        private const string String0FDD = "Fetid fumes reek of evil magic.";
        private const string String0FFD = "A young Praxis is donning his armor.";
        private const string String1022 = "'Hail, young warriors!'";
        private const string String103A = "'Many secrets are hidden about that will aid you in solving the enigma of the Master's Arena. Be aware of whose square you are fighting for!'";
        private const string String10C8 = "A portly wizard fumbles with some magical tomes.";
        private const string String10F9 = "'What, what, what...? Who are you? Hmm, don't know the name.'";
        private const string String1137 = "'Yes, yes, I know the Arena area. Have a look at those books over there on the wall. They should help you with your problem.'";
        private const string String11B5 = "He mumbles something about being bothered and returns to his reading.";
        private const string String11FB = "'So, you're after the Dralkarians, eh? Well, good luck! The Night Elves worship those powerful deities.";
        private const string String1263 = "If I were you - and I'm NOT, thank the heavens! - I'd be on the lookout for some peculiar items.";
        private const string String12C4 = "After all, the Dralks are not of this earth. Seek them in their unique homes. You will know what I mean in time.'";
        private const string String1336 = "Archaic runes in some forgotten tongue cover this gateway.";
        private const string String1371 = "The lava glove allows you to open the portal.";
        private const string String139F = "'This portal may be opened by the owner of the Lava Glove.'";
        private const string String13DB = "Praxis thaumaturges hurl magical bolts at you.";
        private const string String140A = "A wounded Erebus grabs your ankle.";
        private const string String142D = "'Kill me...kill me! If the Praxis discover me here, the war will be imminent.'";
        private const string String147C = "He then collapses...";
        private const string String1491 = "'These feuding creatures are enough to drive me insane! I must defeat one of the Masters in the Arena.";
        private const string String14F8 = "Go see the scholar just south of here before you test your luck in the Arena. He has some books that will help you!'";
        private const string String156D = "War-hardened guildsmen attack!";
        private const string String158C = "A dusty collection of books, similar to those you can find in the Queen's Palace, offers you hints on the Masters' Arena.";
        private const string String1606 = "'When you take over a square, you acquire the piece's abilities you just defeated!";
        private const string String1659 = "Bishops move to corners, as north is to northeast.";
        private const string String168C = "Knights attack in leaps in bounds. From here to there, by an L of renown.";
        private const string String16D6 = "Rooks connect onto that which is directly in front of them. Remember, you become that which you destroy.'";
        private const string String1740 = "      ==============";
        private const string String1755 = "      =0 0 0 0 0 0 =";
        private const string String176A = "      =  0 0 0 B 0 =";
        private const string String177F = "      =  B>0 K R 0 =";
        private const string String1794 = "      =0 0 K 0 0 0 =";
        private const string String17A9 = "      =0 0 E P 0 0 =";
        private const string String17BE = "A long tunnel twists downward to Dragon's Flame.";
        private const string String17EF = "A flickering torch in the distance breaks the blackness around you. It marks the entrance to Dragon's Flame.";
        private const string String185C = "A hidden portal opens, allowing those who have defeated the Master an ingress.";
        private const string String18AB = "There's something strange about the wall here. Only alone, and once you've defeated a Master of the Arena, will you be able to see it!";
        private const string String1932 = "A move here would place you off the chessboard!";
        private const string String1962 = "A maniacal fiend appears; removes an item you stole from him; and kills you outright.";
        private const string String19B8 = "This area is certainly not the grand entrance to the Dralkarian kingdom you had envisioned.";
        private const string String1A14 = "The walls and floors are in decay, all covered with lichens and scorch marks. Pools of lava and shadow litter the floor.";
        private const string String1A8D = "The crumbling stones and cracked granite act as testimony to the war brewing between the Praxis and Erebus armies that dominate this domain.";
        private const string String1B1A = "Ancient carvings of living chess pieces decorate this mysterious portal. Heavy fumes of evil seep upwards from this portal to Dragon's Flame.";
        private const string String1BA8 = "Your Lava Glove begins to glow with white-hot intensity...tugging you in this direction.";
        private const string String1C01 = "Your prowess is acknowledged. Gain wisdom from your actions.";
        private const string String1C3E = "A dark portal offers you descent into untamed depths of this dark underworld.";
        private const string String1C8C = "Servants of Qao rise from the lava to repel encroaching invaders!";
        
        // === Functions ================================================
        private void FnDETHLAVA_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String03FC); // The molten lava incinerates you!
001E  0010 FF 76 08  push word [bp+0x8]
0021  0013 FF 76 06  push word [bp+0x6]
0024  0016 0E     push cs
0025  0017 E8 E2 15  call 0x15fc
            L001A: // NOP
            L001B: cx = PopStack(player);
            L001C: cx = PopStack(player);
            L001D: return; // RETURN;
        }

        private void FnDETHPIT_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String041D); // You fall helplessly into oblivion.
003D  0010 FF 76 08  push word [bp+0x8]
0040  0013 FF 76 06  push word [bp+0x6]
0043  0016 0E     push cs
0044  0017 E8 C3 15  call 0x15dd
            L001A: // NOP
            L001B: cx = PopStack(player);
            L001C: cx = PopStack(player);
            L001D: return; // RETURN;
        }

        private void FnRIVER_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
            L0007: PushStack(player, 0x00);
0056  000A C4 5E 06  les bx, [bp+0x6]
0059  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L004B;
            L0017: ShowMessage(player, String0440); // The unusual force within this green blue fluid saps your magic powers.
            L0024: AddMana(player, 0xFF9C);
007D  0031 FF 76 08  push word [bp+0x8]
0080  0034 FF 76 06  push word [bp+0x6]
0083  0037 0E     push cs
0084  0038 E8 B5 15  call 0x15f0
            L003B: // NOP
            L003C: cx = PopStack(player);
            L003D: cx = PopStack(player);
008A  003E FF 76 08  push word [bp+0x8]
008D  0041 FF 76 06  push word [bp+0x6]
0090  0044 0E     push cs
0091  0045 E8 C4 15  call 0x160c
            L0048: // NOP
            L0049: cx = PopStack(player);
            L004A: cx = PopStack(player);
            L004B: return; // RETURN;
        }

        private void FnSPCPIT_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0487); // You bravely step onto this illusionary pit!
            L0010: return; // RETURN;
        }

        private void FnSPCLAVA_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xC8);
            L0011: if (JumpEqual) goto L0018;
00BE  0013 B8 B3 04  mov ax, 0x4b3
            L0016: goto L001B;
            L0018: ShowMessage(player, String04EA); // The lava here is an illusion!
            L0025: SetWallObject(player, 0x00, 0xB4, 0x02);
            L003A: SetWallObject(player, 0x00, 0xB6, 0x00);
            L004E: SetWallObject(player, 0x00, 0xB5, 0x02);
            L0063: SetWallObject(player, 0x00, 0xB5, 0x00);
            L0077: return; // RETURN;
        }

        private void FnMAINEXIT_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0508); // To the Main Entrance.
            L0010: PushStack(player, 0x01);
            L0014: PushStack(player, 0xAE);
            L0018: PushStack(player, 0x01);
            L001C: PushStack(player, ax);
0141  001D C4 5E 06  les bx, [bp+0x6]
0144  0020 26 FF 9F BC 00  call far word [es:bx+0xbc]
0149  0025 83 C4 08  add sp, 0x8
            L0028: return; // RETURN;
        }

        private void FnCHESMESS_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x6F, 0x00);
            L0017: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L002A: if (JumpNotEqual) goto L0081;
            L002C: ShowMessage(player, String051E); // You enter an enormous chessboard arena. It differs greatly from the one built by Arnakkian so many moons ago.
            L0039: ShowMessage(player, String058C); // The red marble and onyx floor are truly beautiful.
            L0046: ShowMessage(player, String05BF); // You notice, however, that the pieces are not mere toys. They are real creatures. A black dragon, a white knight, and many others are present.
            L0053: ShowMessage(player, String064D); // An ominous Erebus is seated against the southern wall. Next to him stands a magnificent Praxis.
            L0060: ShowMessage(player, String06AD); // They appear to be controlling the pieces, one of which you have now become.
            L006D: PushStack(player, 0x01);
            L0071: PushStack(player, ax);
            L0072: PushStack(player, 0x03);
01C4  0076 C4 5E 06  les bx, [bp+0x6]
01C7  0079 26 FF 1F  call far word [es:bx]
01CA  007C 83 C4 06  add sp, 0x6
            L007F: goto L008E;
            L0081: ShowMessage(player, String06F9); // Once again you enter the board.
            L008E: return; // RETURN;
        }

        private void FnEREBUSA_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
01E3  0005 56     push si
01E4  0006 57     push di
            L0007: Compare(GetCurrentTile(player), 0x0077);
            L0011: if (JumpEqual) goto L001A;
            L0013: Compare(ax, 0x0078);
            L0016: if (JumpEqual) goto L0027;
            L0018: goto L0032;
            L001A: si = 0x007C;
01FB  001D C7 46 FE 03 00  mov word [bp-0x2], 0x3
            L0022: di = 0x0024;
            L0025: goto L0032;
            L0027: si = 0x007B;
0208  002A C7 46 FE 04 00  mov word [bp-0x2], 0x4
            L002F: di = 0x0025;
0210  0032 56     push si
            L0033: PushStack(player, 0x02);
0215  0037 C4 5E 06  les bx, [bp+0x6]
0218  003A 26 FF 5F 04  call far word [es:bx+0x4]
            L003E: cx = PopStack(player);
            L003F: cx = PopStack(player);
            L0040: Compare(ax, 0x0001);
            L0043: if (JumpNotEqual) goto L006A;
            L0045: Compare(si, 0x7C);
            L0048: if (JumpNotEqual) goto L0061;
            L004A: SetFlag(player, 0x03, 0x03, 0x01);
            L005F: goto L0077;
            L0061: PushStack(player, 0x01);
0243  0065 B8 04 00  mov ax, 0x4
            L0068: goto L0051;
0248  006A FF 76 08  push word [bp+0x8]
024B  006D FF 76 06  push word [bp+0x6]
024E  0070 0E     push cs
024F  0071 E8 DD 00  call 0x151
            L0074: // NOP
            L0075: cx = PopStack(player);
            L0076: cx = PopStack(player);
            L0077: PushStack(player, 0x03);
            L007B: PushStack(player, ax);
025A  007C C4 5E 06  les bx, [bp+0x6]
025D  007F 26 FF 5F 04  call far word [es:bx+0x4]
            L0083: cx = PopStack(player);
            L0084: cx = PopStack(player);
            L0085: Compare(ax, 0x0001);
            L0088: if (JumpEqual) goto L00A0;
            L008A: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L009E: if (JumpNotEqual) goto L00CF;
            L00A0: Compare(tmp, 0xFE);
            L00A4: if (JumpNotEqual) goto L00B3;
0284  00A6 FF 76 08  push word [bp+0x8]
0287  00A9 FF 76 06  push word [bp+0x6]
028A  00AC 0E     push cs
028B  00AD E8 44 00  call 0xf4
            L00B0: // NOP
            L00B1: goto L00BE;
0291  00B3 FF 76 08  push word [bp+0x8]
0294  00B6 FF 76 06  push word [bp+0x6]
0297  00B9 0E     push cs
0298  00BA E8 75 00  call 0x132
            L00BD: // NOP
            L00BE: cx = PopStack(player);
            L00BF: cx = PopStack(player);
029E  00C0 57     push di
            L00C1: PushStack(player, 0x01);
02A3  00C5 C4 5E 06  les bx, [bp+0x6]
02A6  00C8 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L00CD: cx = PopStack(player);
            L00CE: cx = PopStack(player);
02AD  00CF 5F     pop di
02AE  00D0 5E     pop si
            L00D1: // restore stack ptr: sp = bp;
            L00D3: return; // RETURN;
            // Extra data: 55 8B EC B8 19 07 50 C4 5E 06 26 FF 9F F8 00 59 B8 33 07 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC B8 73 07 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC B8 EE 07 50 C4 5E 06 26 FF 9F F8 00 59 B8 0A 08 50 C4 5E 06 26 FF 9F F8 00 59 B8 32 08 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC B8 78 08 50 C4 5E 06 26 FF 9F F8 00 59 B8 B8 08 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC B8 DB 08 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 
        }

        private void FnCOMMONDR_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0021: return; // RETURN;
        }

        private void FnTOMACS_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0047;
            L0010: ShowMessage(player, String090C); // An eerie blue light sifts through a fissure in the wall.
            L001D: ShowMessage(player, String0945); // I wouldn't venture here until you've completed the tasks Aeowyn has enjoined you with - namely, destroying the Dralkarians!
            L002A: TeleportParty(player, 0x0D, 0x01, 0xFC, 0x03, isForwardMove);
            L0045: goto L0061;
            L0047: ShowMessage(player, String09C1); // You must enter here alone!
            L0054: PushStack(player, 0x02);
03C1  0058 C4 5E 06  les bx, [bp+0x6]
03C4  005B 26 FF 9F CC 00  call far word [es:bx+0xcc]
            L0060: cx = PopStack(player);
            L0061: return; // RETURN;
        }

        private void FnSECRTDOR_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0003);
            L000D: if (JumpEqual) goto L001E;
            L000F: Compare(GetGuild(player), 0x0005);
            L0019: if (JumpEqual) goto L001E;
            L001B: goto L00A0;
            L001E: Compare(HasUsedSkill(player, 0x0D), 0x000C);
            L002D: if (JumpNotBelow) goto L0087;
            L002F: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L003D: if (JumpNotEqual) goto L0087;
            L003F: PushStack(player, 0x68);
            L0043: PushStack(player, ax);
0410  0044 C4 5E 06  les bx, [bp+0x6]
0413  0047 26 FF 5F 54  call far word [es:bx+0x54]
            L004B: cx = PopStack(player);
            L004C: cx = PopStack(player);
            L004D: RefreshCompareFlags(ax);
            L004F: if (JumpNotEqual) goto L0087;
            L0051: PushStack(player, 0x6E);
            L0055: PushStack(player, ax);
0422  0056 C4 5E 06  les bx, [bp+0x6]
0425  0059 26 FF 5F 54  call far word [es:bx+0x54]
            L005D: cx = PopStack(player);
            L005E: cx = PopStack(player);
            L005F: RefreshCompareFlags(ax);
            L0061: if (JumpNotEqual) goto L0087;
            L0063: PushStack(player, 0x90);
            L0067: PushStack(player, ax);
0434  0068 C4 5E 06  les bx, [bp+0x6]
0437  006B 26 FF 5F 54  call far word [es:bx+0x54]
            L006F: cx = PopStack(player);
            L0070: cx = PopStack(player);
            L0071: RefreshCompareFlags(ax);
            L0073: if (JumpNotEqual) goto L0087;
            L0075: PushStack(player, 0xA4);
            L0079: PushStack(player, ax);
0446  007A C4 5E 06  les bx, [bp+0x6]
0449  007D 26 FF 5F 54  call far word [es:bx+0x54]
            L0081: cx = PopStack(player);
            L0082: cx = PopStack(player);
            L0083: RefreshCompareFlags(ax);
            L0085: if (JumpEqual) goto L00AD;
            L0087: ShowMessage(player, String09DC); // The ancient stones become a portal.
0460  0094 FF 76 08  push word [bp+0x8]
0463  0097 FF 76 06  push word [bp+0x6]
0466  009A 0E     push cs
0467  009B E8 DC FE  call 0xff7a
            L009E: goto L00AB;
046C  00A0 FF 76 08  push word [bp+0x8]
046F  00A3 FF 76 06  push word [bp+0x6]
0472  00A6 0E     push cs
0473  00A7 E8 72 11  call 0x121c
            L00AA: // NOP
            L00AB: cx = PopStack(player);
            L00AC: cx = PopStack(player);
            L00AD: return; // RETURN;
        }

        private void FnGRTDRAGN_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x000E);
            L0010: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0023: if (JumpEqual) goto L0028;
            L0025: goto L00D6;
            L0028: ShowMessage(player, String0A00); // Qao Tsur slowly opens his eyes, now thin slits of black in green-gold spheres. He sniffs at you.
            L0035: ShowMessage(player, String0A61); // His booming voice shakes the walls.
            L0042: ShowMessage(player, String0A85); // 'So, mere mortals have at last appeared to seek the Dralkarians.
            L004F: ShowMessage(player, String0AC6); // Your puny magics will not save you. I once stood at claw's length with the mighty beasts. You are no match for them in your weakling state.
            L005C: ShowMessage(player, String0B52); // Go, seek my feuding children below. They will offer you a task more suited to your abilities.
            L0069: ShowMessage(player, String0BB0); // The Dralkarians will require special means before YOU can even dream of defeating them.
            L0076: ShowMessage(player, String0C08); // The chessmasters await you, you must outwit them...
            L0083: ShowMessage(player, String0C3C); // ...or out-fight them.
            L0090: ShowMessage(player, String0C52); // I offer you this advice, listen not to vain words of empty tongue.'
            L009D: ShowMessage(player, String0C96); // Qao then recedes into his slumber, ignoring you.
            L00AA: SetFlag(player, 0x03, 0x02, 0x01);
            L00BF: SetFlag(player, 0x02, 0x80, 0x02);
            L00D4: goto L00E3;
            L00D6: ShowMessage(player, String0CC7); // Qao ignores you in his uneasy sleep.
            L00E3: return; // RETURN;
        }

        private void FnHEATSQRS_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
            L0007: PushStack(player, 0x00);
056A  000A C4 5E 06  les bx, [bp+0x6]
056D  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L0042;
            L0017: ShowMessage(player, String0CEC); // The tremendous heat is devastating here.
0584  0024 FF 76 08  push word [bp+0x8]
0587  0027 FF 76 06  push word [bp+0x6]
058A  002A 0E     push cs
058B  002B E8 AE 10  call 0x10dc
            L002E: // NOP
            L002F: cx = PopStack(player);
            L0030: cx = PopStack(player);
            L0031: PushStack(player, 0x01);
            L0035: PushStack(player, ax);
            L0036: PushStack(player, 0x00);
0599  0039 C4 5E 06  les bx, [bp+0x6]
059C  003C 26 FF 1F  call far word [es:bx]
059F  003F 83 C4 06  add sp, 0x6
            L0042: return; // RETURN;
        }

        private void FnFIREBALS_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
            L0007: PushStack(player, 0x00);
05AE  000A C4 5E 06  les bx, [bp+0x6]
05B1  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L003E;
            L0017: ShowMessage(player, String0D15); // As you round the corner of this Dragon's Lair, a series of fire-bursts fly from the shadows, scorching you.
05C8  0024 FF 76 08  push word [bp+0x8]
05CB  0027 FF 76 06  push word [bp+0x6]
05CE  002A 0E     push cs
05CF  002B E8 4E 10  call 0x107c
            L002E: // NOP
            L002F: cx = PopStack(player);
            L0030: cx = PopStack(player);
05D5  0031 FF 76 08  push word [bp+0x8]
05D8  0034 FF 76 06  push word [bp+0x6]
05DB  0037 0E     push cs
05DC  0038 E8 79 10  call 0x10b4
            L003B: // NOP
            L003C: cx = PopStack(player);
            L003D: cx = PopStack(player);
            L003E: return; // RETURN;
        }

        private void FnGASTRAP_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
05E7  0003 C4 5E 06  les bx, [bp+0x6]
05EA  0006 26 FF 5F 40  call far word [es:bx+0x40]
            L000A: PushStack(player, 0x01);
            L000E: PushStack(player, 0x00);
05F5  0011 C4 5E 06  les bx, [bp+0x6]
05F8  0014 26 FF 5F 04  call far word [es:bx+0x4]
            L0018: cx = PopStack(player);
            L0019: cx = PopStack(player);
            L001A: RefreshCompareFlags(ax);
            L001C: if (JumpNotEqual) goto L0045;
            L001E: ShowMessage(player, String0D81); // Poisonous gases seep into this area.
060F  002B FF 76 08  push word [bp+0x8]
0612  002E FF 76 06  push word [bp+0x6]
0615  0031 0E     push cs
0616  0032 E8 79 10  call 0x10ae
            L0035: // NOP
            L0036: cx = PopStack(player);
            L0037: cx = PopStack(player);
061C  0038 FF 76 08  push word [bp+0x8]
061F  003B FF 76 06  push word [bp+0x6]
0622  003E 0E     push cs
0623  003F E8 32 10  call 0x1074
            L0042: // NOP
            L0043: cx = PopStack(player);
            L0044: cx = PopStack(player);
            L0045: return; // RETURN;
        }

        private void FnLAIRDESC_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0DA6); // An ancient Red Dragon lies on his mountain of gold and other booty. As you enter his lair, you are weakened by the tremendous heat.
            L0010: PushStack(player, 0x01);
            L0014: PushStack(player, 0x00);
0642  0017 C4 5E 06  les bx, [bp+0x6]
0645  001A 26 FF 5F 04  call far word [es:bx+0x4]
            L001E: cx = PopStack(player);
            L001F: cx = PopStack(player);
            L0020: RefreshCompareFlags(ax);
            L0022: if (JumpNotEqual) goto L0061;
064F  0024 FF 76 08  push word [bp+0x8]
0652  0027 FF 76 06  push word [bp+0x6]
0655  002A 0E     push cs
0656  002B E8 E3 0F  call 0x1011
            L002E: // NOP
            L002F: cx = PopStack(player);
            L0030: cx = PopStack(player);
065C  0031 FF 76 08  push word [bp+0x8]
065F  0034 FF 76 06  push word [bp+0x6]
0662  0037 0E     push cs
0663  0038 E8 2C 10  call 0x1067
            L003B: // NOP
            L003C: cx = PopStack(player);
            L003D: cx = PopStack(player);
            L003E: PushStack(player, 0x00);
            L0041: PushStack(player, 0x32);
            L0045: PushStack(player, 0x02);
0674  0049 C4 5E 06  les bx, [bp+0x6]
0677  004C 26 FF 9F 9C 00  call far word [es:bx+0x9c]
067C  0051 83 C4 06  add sp, 0x6
067F  0054 FF 76 08  push word [bp+0x8]
0682  0057 FF 76 06  push word [bp+0x6]
0685  005A 0E     push cs
0686  005B E8 CF 0F  call 0x102d
            L005E: // NOP
            L005F: cx = PopStack(player);
            L0060: cx = PopStack(player);
            L0061: return; // RETURN;
        }

        private void FnREDKNIGT_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x20);
            L0015: return; // RETURN;
        }

        private void FnKNITRED_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: ax = GetFlag(player, 0x02, 0x6F);
06BB  0016 8B F8  mov di, ax
06BD  0018 83 FF 02  cmp di, 0x2
            L001B: if (JumpNotEqual) goto L0034;
            L001D: Compare(GetCurrentTile(player), 0x0046);
            L0027: if (JumpNotEqual) goto L0034;
            L0029: RefreshCompareFlags(GetFacing(player));
            L0032: if (JumpEqual) goto L007B;
            L0034: Compare(GetCurrentTile(player), 0x0049);
            L003E: if (JumpNotEqual) goto L004C;
            L0040: Compare(GetFacing(player), 0x0002);
            L004A: if (JumpEqual) goto L007B;
            L004C: Compare(GetCurrentTile(player), 0x0056);
            L0056: if (JumpNotEqual) goto L0063;
            L0058: RefreshCompareFlags(GetFacing(player));
            L0061: if (JumpEqual) goto L007B;
            L0063: Compare(GetCurrentTile(player), 0x0059);
            L006D: if (JumpNotEqual) goto L008B;
            L006F: Compare(GetFacing(player), 0x0002);
            L0079: if (JumpNotEqual) goto L008B;
            L007B: ShowMessage(player, String0E2A); // You may leave the board through here.
            L0088: goto L0233;
0730  008B FF 76 08  push word [bp+0x8]
0733  008E FF 76 06  push word [bp+0x6]
0736  0091 0E     push cs
0737  0092 E8 AE 0E  call 0xf43
            L0095: // NOP
            L0096: cx = PopStack(player);
            L0097: cx = PopStack(player);
073D  0098 8B C7  mov ax, di
            L009A: Compare(ax, 0x0001);
            L009D: if (JumpEqual) goto L00AF;
            L009F: Compare(ax, 0x0002);
            L00A2: if (JumpEqual) goto L0112;
            L00A4: Compare(ax, 0x0003);
            L00A7: if (JumpNotEqual) goto L00AC;
            L00A9: goto L0171;
            L00AC: goto L01CC;
            L00AF: Compare(GetFacing(player), 0x0003);
            L00B9: if (JumpNotEqual) goto L00C7;
            L00BB: si = GetCurrentTile(player) + 0xFFF1;
            L00C7: Compare(GetFacing(player), 0x0002);
            L00D1: if (JumpNotEqual) goto L00DF;
            L00D3: si = GetCurrentTile(player) + 0x0011;
            L00DF: Compare(GetFacing(player), 0x0001);
            L00E9: if (JumpNotEqual) goto L00F7;
            L00EB: si = GetCurrentTile(player) + 0x000F;
            L00F7: RefreshCompareFlags(GetFacing(player));
            L0100: if (JumpEqual) goto L0105;
            L0102: goto L01CC;
            L0105: ax = GetCurrentTile(player) + 0xFFEF;
            L010F: goto L01CA;
            L0112: Compare(GetFacing(player), 0x0003);
            L011C: if (JumpNotEqual) goto L012A;
            L011E: si = GetCurrentTile(player) + 0xFFDF;
            L012A: Compare(GetFacing(player), 0x0002);
            L0134: if (JumpNotEqual) goto L0142;
            L0136: si = GetCurrentTile(player) + 0xFFF2;
            L0142: Compare(GetFacing(player), 0x0001);
            L014C: if (JumpNotEqual) goto L015A;
            L014E: si = GetCurrentTile(player) + 0x0021;
            L015A: RefreshCompareFlags(GetFacing(player));
            L0163: if (JumpNotEqual) goto L01CC;
            L0165: ax = GetCurrentTile(player) + 0x000E;
            L016F: goto L01CA;
            L0171: Compare(GetFacing(player), 0x0003);
            L017B: if (JumpNotEqual) goto L0189;
            L017D: si = GetCurrentTile(player) + 0xFFF0;
            L0189: Compare(GetFacing(player), 0x0002);
            L0193: if (JumpNotEqual) goto L019F;
            L0195: ax = GetCurrentTile(player);
0841  019C 40     inc ax
            L019D: si = ax;
            L019F: Compare(GetFacing(player), 0x0001);
            L01A9: if (JumpNotEqual) goto L01B7;
            L01AB: si = GetCurrentTile(player) + 0x0010;
            L01B7: RefreshCompareFlags(GetFacing(player));
            L01C0: if (JumpNotEqual) goto L01CC;
            L01C2: ax = GetCurrentTile(player);
086E  01C9 48     dec ax
            L01CA: si = ax;
            L01CC: Compare(si, 0x25);
            L01CF: if (JumpLess) goto L01D6;
            L01D1: Compare(si, 0x2A);
            L01D4: if (JumpLessOrEqual) goto L0208;
            L01D6: Compare(si, 0x35);
            L01D9: if (JumpLess) goto L01E0;
            L01DB: Compare(si, 0x3A);
            L01DE: if (JumpLessOrEqual) goto L0208;
            L01E0: Compare(si, 0x44);
            L01E3: if (JumpLess) goto L01EA;
            L01E5: Compare(si, 0x4B);
            L01E8: if (JumpLessOrEqual) goto L0208;
            L01EA: Compare(si, 0x54);
            L01ED: if (JumpLess) goto L01F4;
            L01EF: Compare(si, 0x5B);
            L01F2: if (JumpLessOrEqual) goto L0208;
            L01F4: Compare(si, 0x65);
            L01F7: if (JumpLess) goto L01FE;
            L01F9: Compare(si, 0x6A);
            L01FC: if (JumpLessOrEqual) goto L0208;
            L01FE: Compare(si, 0x75);
            L0201: if (JumpLess) goto L0226;
            L0203: Compare(si, 0x7A);
            L0206: if (JumpGreater) goto L0226;
            L0208: TeleportParty(player, 0x08, 0x01, si, GetFacing(player), isForwardMove);
            L0224: goto L0233;
08CB  0226 FF 76 08  push word [bp+0x8]
08CE  0229 FF 76 06  push word [bp+0x6]
08D1  022C 0E     push cs
08D2  022D E8 AB 0D  call 0xfdb
            L0230: // NOP
            L0231: cx = PopStack(player);
            L0232: cx = PopStack(player);
            L0233: return; // RETURN (restoring si, di);
        }

        private void FnCRNRROOK_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: Compare(GetCurrentTile(player), 0x0066);
            L000E: if (JumpEqual) goto L0017;
            L0010: Compare(ax, 0x0069);
            L0013: if (JumpEqual) goto L001C;
            L0015: goto L001F;
            L0017: si = 0x0027;
            L001A: goto L001F;
            L001C: si = 0x0026;
08FB  001F 56     push si
            L0020: PushStack(player, 0x01);
0900  0024 C4 5E 06  les bx, [bp+0x6]
0903  0027 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L002C: cx = PopStack(player);
            L002D: cx = PopStack(player);
            L002E: return; // RETURN (restoring si);
        }

        private void FnPAWNBLCK_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: ax = GetFlag(player, 0x02, 0x6F);
0923  0016 8B F8  mov di, ax
0925  0018 83 FF 02  cmp di, 0x2
            L001B: if (JumpNotEqual) goto L0034;
            L001D: Compare(GetCurrentTile(player), 0x0046);
            L0027: if (JumpNotEqual) goto L0034;
            L0029: RefreshCompareFlags(GetFacing(player));
            L0032: if (JumpEqual) goto L007B;
            L0034: Compare(GetCurrentTile(player), 0x0049);
            L003E: if (JumpNotEqual) goto L004C;
            L0040: Compare(GetFacing(player), 0x0002);
            L004A: if (JumpEqual) goto L007B;
            L004C: Compare(GetCurrentTile(player), 0x0056);
            L0056: if (JumpNotEqual) goto L0063;
            L0058: RefreshCompareFlags(GetFacing(player));
            L0061: if (JumpEqual) goto L007B;
            L0063: Compare(GetCurrentTile(player), 0x0059);
            L006D: if (JumpNotEqual) goto L008B;
            L006F: Compare(GetFacing(player), 0x0002);
            L0079: if (JumpNotEqual) goto L008B;
            L007B: ShowMessage(player, String0E2A); // You may leave the board through here.
            L0088: goto L0233;
0998  008B FF 76 08  push word [bp+0x8]
099B  008E FF 76 06  push word [bp+0x6]
099E  0091 0E     push cs
099F  0092 E8 46 0C  call 0xcdb
            L0095: // NOP
            L0096: cx = PopStack(player);
            L0097: cx = PopStack(player);
09A5  0098 8B C7  mov ax, di
            L009A: Compare(ax, 0x0001);
            L009D: if (JumpEqual) goto L00AF;
            L009F: Compare(ax, 0x0002);
            L00A2: if (JumpEqual) goto L0112;
            L00A4: Compare(ax, 0x0003);
            L00A7: if (JumpNotEqual) goto L00AC;
            L00A9: goto L0171;
            L00AC: goto L01CC;
            L00AF: Compare(GetFacing(player), 0x0003);
            L00B9: if (JumpNotEqual) goto L00C7;
            L00BB: si = GetCurrentTile(player) + 0xFFF1;
            L00C7: Compare(GetFacing(player), 0x0002);
            L00D1: if (JumpNotEqual) goto L00DF;
            L00D3: si = GetCurrentTile(player) + 0x0011;
            L00DF: Compare(GetFacing(player), 0x0001);
            L00E9: if (JumpNotEqual) goto L00F7;
            L00EB: si = GetCurrentTile(player) + 0x000F;
            L00F7: RefreshCompareFlags(GetFacing(player));
            L0100: if (JumpEqual) goto L0105;
            L0102: goto L01CC;
            L0105: ax = GetCurrentTile(player) + 0xFFEF;
            L010F: goto L01CA;
            L0112: Compare(GetFacing(player), 0x0003);
            L011C: if (JumpNotEqual) goto L012A;
            L011E: si = GetCurrentTile(player) + 0xFFE1;
            L012A: Compare(GetFacing(player), 0x0002);
            L0134: if (JumpNotEqual) goto L0142;
            L0136: si = GetCurrentTile(player) + 0x0012;
            L0142: Compare(GetFacing(player), 0x0001);
            L014C: if (JumpNotEqual) goto L015A;
            L014E: si = GetCurrentTile(player) + 0x001F;
            L015A: RefreshCompareFlags(GetFacing(player));
            L0163: if (JumpNotEqual) goto L01CC;
            L0165: ax = GetCurrentTile(player) + 0xFFEE;
            L016F: goto L01CA;
            L0171: Compare(GetFacing(player), 0x0003);
            L017B: if (JumpNotEqual) goto L0189;
            L017D: si = GetCurrentTile(player) + 0xFFF0;
            L0189: Compare(GetFacing(player), 0x0002);
            L0193: if (JumpNotEqual) goto L019F;
            L0195: ax = GetCurrentTile(player);
0AA9  019C 40     inc ax
            L019D: si = ax;
            L019F: Compare(GetFacing(player), 0x0001);
            L01A9: if (JumpNotEqual) goto L01B7;
            L01AB: si = GetCurrentTile(player) + 0x0010;
            L01B7: RefreshCompareFlags(GetFacing(player));
            L01C0: if (JumpNotEqual) goto L01CC;
            L01C2: ax = GetCurrentTile(player);
0AD6  01C9 48     dec ax
            L01CA: si = ax;
            L01CC: Compare(si, 0x25);
            L01CF: if (JumpLess) goto L01D6;
            L01D1: Compare(si, 0x2A);
            L01D4: if (JumpLessOrEqual) goto L0208;
            L01D6: Compare(si, 0x35);
            L01D9: if (JumpLess) goto L01E0;
            L01DB: Compare(si, 0x3A);
            L01DE: if (JumpLessOrEqual) goto L0208;
            L01E0: Compare(si, 0x44);
            L01E3: if (JumpLess) goto L01EA;
            L01E5: Compare(si, 0x4B);
            L01E8: if (JumpLessOrEqual) goto L0208;
            L01EA: Compare(si, 0x54);
            L01ED: if (JumpLess) goto L01F4;
            L01EF: Compare(si, 0x5B);
            L01F2: if (JumpLessOrEqual) goto L0208;
            L01F4: Compare(si, 0x65);
            L01F7: if (JumpLess) goto L01FE;
            L01F9: Compare(si, 0x6A);
            L01FC: if (JumpLessOrEqual) goto L0208;
            L01FE: Compare(si, 0x75);
            L0201: if (JumpLess) goto L0226;
            L0203: Compare(si, 0x7A);
            L0206: if (JumpGreater) goto L0226;
            L0208: TeleportParty(player, 0x08, 0x01, si, GetFacing(player), isForwardMove);
            L0224: goto L0233;
0B33  0226 FF 76 08  push word [bp+0x8]
0B36  0229 FF 76 06  push word [bp+0x6]
0B39  022C 0E     push cs
0B3A  022D E8 43 0B  call 0xd73
            L0230: // NOP
            L0231: cx = PopStack(player);
            L0232: cx = PopStack(player);
            L0233: return; // RETURN (restoring si, di);
        }

        private void FnREDKNIGT_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
0B48  0004 FF 76 08  push word [bp+0x8]
0B4B  0007 FF 76 06  push word [bp+0x6]
0B4E  000A 0E     push cs
0B4F  000B E8 96 0A  call 0xaa4
            L000E: // NOP
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: SetFlag(player, 0x02, 0x6F, 0x02);
            L0026: Compare(GetFacing(player), 0x0003);
            L0030: if (JumpNotEqual) goto L003E;
            L0032: si = GetCurrentTile(player) + 0xFFDF;
            L003E: Compare(GetFacing(player), 0x0002);
            L0048: if (JumpNotEqual) goto L0056;
            L004A: si = GetCurrentTile(player) + 0xFFF2;
            L0056: Compare(GetFacing(player), 0x0001);
            L0060: if (JumpNotEqual) goto L006E;
            L0062: si = GetCurrentTile(player) + 0x0021;
            L006E: RefreshCompareFlags(GetFacing(player));
            L0077: if (JumpNotEqual) goto L0085;
            L0079: si = GetCurrentTile(player) + 0x000E;
            L0085: Compare(GetCurrentTile(player), 0x0067);
            L008F: if (JumpEqual) goto L0093;
            L0091: goto L00FA;
            L0093: Compare(si, 0x25);
            L0096: if (JumpLess) goto L009D;
            L0098: Compare(si, 0x2A);
            L009B: if (JumpLessOrEqual) goto L00CF;
            L009D: Compare(si, 0x35);
            L00A0: if (JumpLess) goto L00A7;
            L00A2: Compare(si, 0x3A);
            L00A5: if (JumpLessOrEqual) goto L00CF;
            L00A7: Compare(si, 0x44);
            L00AA: if (JumpLess) goto L00B1;
            L00AC: Compare(si, 0x4B);
            L00AF: if (JumpLessOrEqual) goto L00CF;
            L00B1: Compare(si, 0x54);
            L00B4: if (JumpLess) goto L00BB;
            L00B6: Compare(si, 0x5B);
            L00B9: if (JumpLessOrEqual) goto L00CF;
            L00BB: Compare(si, 0x65);
            L00BE: if (JumpLess) goto L00C5;
            L00C0: Compare(si, 0x6A);
            L00C3: if (JumpLessOrEqual) goto L00CF;
            L00C5: Compare(si, 0x75);
            L00C8: if (JumpLess) goto L00ED;
            L00CA: Compare(si, 0x7A);
            L00CD: if (JumpGreater) goto L00ED;
            L00CF: TeleportParty(player, 0x08, 0x01, si, GetFacing(player), isForwardMove);
            L00EB: goto L00FA;
0C31  00ED FF 76 08  push word [bp+0x8]
0C34  00F0 FF 76 06  push word [bp+0x6]
0C37  00F3 0E     push cs
0C38  00F4 E8 45 0A  call 0xb3c
            L00F7: // NOP
            L00F8: cx = PopStack(player);
            L00F9: cx = PopStack(player);
            L00FA: return; // RETURN (restoring si);
        }

        private void FnBLCKING_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
0C45  0004 FF 76 08  push word [bp+0x8]
0C48  0007 FF 76 06  push word [bp+0x6]
0C4B  000A 0E     push cs
0C4C  000B E8 99 09  call 0x9a7
            L000E: // NOP
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: SetFlag(player, 0x02, 0x6F, 0x03);
            L0026: Compare(GetFacing(player), 0x0003);
            L0030: if (JumpNotEqual) goto L003E;
            L0032: si = GetCurrentTile(player) + 0xFFF0;
            L003E: Compare(GetFacing(player), 0x0002);
            L0048: if (JumpNotEqual) goto L0054;
            L004A: ax = GetCurrentTile(player);
0C92  0051 40     inc ax
            L0052: si = ax;
            L0054: Compare(GetFacing(player), 0x0001);
            L005E: if (JumpNotEqual) goto L006C;
            L0060: si = GetCurrentTile(player) + 0x0010;
            L006C: RefreshCompareFlags(GetFacing(player));
            L0075: if (JumpNotEqual) goto L0081;
            L0077: ax = GetCurrentTile(player);
0CBF  007E 48     dec ax
            L007F: si = ax;
            L0081: Compare(si, 0x25);
            L0084: if (JumpLess) goto L008B;
            L0086: Compare(si, 0x2A);
            L0089: if (JumpLessOrEqual) goto L00BD;
            L008B: Compare(si, 0x35);
            L008E: if (JumpLess) goto L0095;
            L0090: Compare(si, 0x3A);
            L0093: if (JumpLessOrEqual) goto L00BD;
            L0095: Compare(si, 0x44);
            L0098: if (JumpLess) goto L009F;
            L009A: Compare(si, 0x4B);
            L009D: if (JumpLessOrEqual) goto L00BD;
            L009F: Compare(si, 0x54);
            L00A2: if (JumpLess) goto L00A9;
            L00A4: Compare(si, 0x5B);
            L00A7: if (JumpLessOrEqual) goto L00BD;
            L00A9: Compare(si, 0x65);
            L00AC: if (JumpLess) goto L00B3;
            L00AE: Compare(si, 0x6A);
            L00B1: if (JumpLessOrEqual) goto L00BD;
            L00B3: Compare(si, 0x75);
            L00B6: if (JumpLess) goto L00DB;
            L00B8: Compare(si, 0x7A);
            L00BB: if (JumpGreater) goto L00DB;
            L00BD: TeleportParty(player, 0x08, 0x01, si, GetFacing(player), isForwardMove);
            L00D9: goto L00E8;
0D1C  00DB FF 76 08  push word [bp+0x8]
0D1F  00DE FF 76 06  push word [bp+0x6]
0D22  00E1 0E     push cs
0D23  00E2 E8 5A 09  call 0xa3f
            L00E5: // NOP
            L00E6: cx = PopStack(player);
            L00E7: cx = PopStack(player);
            L00E8: return; // RETURN (restoring si);
        }

        private void FnREDARCH_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
0D30  0004 FF 76 08  push word [bp+0x8]
0D33  0007 FF 76 06  push word [bp+0x6]
0D36  000A 0E     push cs
0D37  000B E8 AE 08  call 0x8bc
            L000E: // NOP
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: SetFlag(player, 0x02, 0x6F, 0x02);
            L0026: Compare(GetFacing(player), 0x0003);
            L0030: if (JumpNotEqual) goto L003E;
            L0032: si = GetCurrentTile(player) + 0xFFE1;
            L003E: Compare(GetFacing(player), 0x0002);
            L0048: if (JumpNotEqual) goto L0056;
            L004A: si = GetCurrentTile(player) + 0x0012;
            L0056: Compare(GetFacing(player), 0x0001);
            L0060: if (JumpNotEqual) goto L006E;
            L0062: si = GetCurrentTile(player) + 0x001F;
            L006E: RefreshCompareFlags(GetFacing(player));
            L0077: if (JumpNotEqual) goto L0085;
            L0079: si = GetCurrentTile(player) + 0xFFEE;
            L0085: Compare(si, 0x25);
            L0088: if (JumpLess) goto L008F;
            L008A: Compare(si, 0x2A);
            L008D: if (JumpLessOrEqual) goto L00C1;
            L008F: Compare(si, 0x35);
            L0092: if (JumpLess) goto L0099;
            L0094: Compare(si, 0x3A);
            L0097: if (JumpLessOrEqual) goto L00C1;
            L0099: Compare(si, 0x44);
            L009C: if (JumpLess) goto L00A3;
            L009E: Compare(si, 0x4B);
            L00A1: if (JumpLessOrEqual) goto L00C1;
            L00A3: Compare(si, 0x54);
            L00A6: if (JumpLess) goto L00AD;
            L00A8: Compare(si, 0x5B);
            L00AB: if (JumpLessOrEqual) goto L00C1;
            L00AD: Compare(si, 0x65);
            L00B0: if (JumpLess) goto L00B7;
            L00B2: Compare(si, 0x6A);
            L00B5: if (JumpLessOrEqual) goto L00C1;
            L00B7: Compare(si, 0x75);
            L00BA: if (JumpLess) goto L00DF;
            L00BC: Compare(si, 0x7A);
            L00BF: if (JumpGreater) goto L00DF;
            L00C1: TeleportParty(player, 0x08, 0x01, si, GetFacing(player), isForwardMove);
            L00DD: goto L00EC;
0E0B  00DF FF 76 08  push word [bp+0x8]
0E0E  00E2 FF 76 06  push word [bp+0x6]
0E11  00E5 0E     push cs
0E12  00E6 E8 6B 08  call 0x954
            L00E9: // NOP
            L00EA: cx = PopStack(player);
            L00EB: cx = PopStack(player);
            L00EC: return; // RETURN (restoring si);
        }

        private void FnPSNSCRIP_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
            L0007: PushStack(player, 0x00);
0E25  000A C4 5E 06  les bx, [bp+0x6]
0E28  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L003E;
            L0017: ShowMessage(player, String0E50); // The lair is filled with lava pools and noxious odors.
0E3F  0024 FF 76 08  push word [bp+0x8]
0E42  0027 FF 76 06  push word [bp+0x6]
0E45  002A 0E     push cs
0E46  002B E8 49 08  call 0x877
            L002E: // NOP
            L002F: cx = PopStack(player);
            L0030: cx = PopStack(player);
0E4C  0031 FF 76 08  push word [bp+0x8]
0E4F  0034 FF 76 06  push word [bp+0x6]
0E52  0037 0E     push cs
0E53  0038 E8 02 08  call 0x83d
            L003B: // NOP
            L003C: cx = PopStack(player);
            L003D: cx = PopStack(player);
            L003E: return; // RETURN;
        }

        private void FnBLCDRAG_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x21);
            L0015: return; // RETURN;
        }

        private void FnSMLERBUS_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0E86); // A group of young Erebus move towards you, mumbling in their guttural tongue.
0E9B  0010 FF 76 08  push word [bp+0x8]
0E9E  0013 FF 76 06  push word [bp+0x6]
0EA1  0016 0E     push cs
0EA2  0017 E8 84 06  call 0x69e
            L001A: // NOP
            L001B: cx = PopStack(player);
            L001C: cx = PopStack(player);
            L001D: Compare(PartyCount(player), 0x0001);
            L0028: if (JumpEqual) goto L002C;
            L002A: goto L0035;
            L002C: PushStack(player, 0x1F);
0EBB  0030 B8 01 00  mov ax, 0x1
            L0033: goto L0060;
            L0035: AddEncounter(player, 0x01, 0x1F);
            L0047: AddEncounter(player, 0x02, 0x1F);
            L0059: AddEncounter(player, 0x05, 0x1F);
            L006B: return; // RETURN;
        }

        private void FnPISNFNT_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0EFB  0003 C4 5E 06  les bx, [bp+0x6]
0EFE  0006 26 FF 5F 40  call far word [es:bx+0x40]
            L000A: PushStack(player, 0x01);
            L000E: PushStack(player, 0x00);
0F09  0011 C4 5E 06  les bx, [bp+0x6]
0F0C  0014 26 FF 5F 04  call far word [es:bx+0x4]
            L0018: cx = PopStack(player);
            L0019: cx = PopStack(player);
            L001A: RefreshCompareFlags(ax);
            L001C: if (JumpNotEqual) goto L005F;
0F16  001E FF 76 08  push word [bp+0x8]
0F19  0021 FF 76 06  push word [bp+0x6]
0F1C  0024 0E     push cs
0F1D  0025 E8 4E 07  call 0x776
            L0028: // NOP
            L0029: cx = PopStack(player);
            L002A: cx = PopStack(player);
            L002B: ShowMessage(player, String0ED3); // The sweet waters feel refreshing at first, but soon make you feel nauseated.
0F30  0038 FF 76 08  push word [bp+0x8]
0F33  003B FF 76 06  push word [bp+0x6]
0F36  003E 0E     push cs
0F37  003F E8 58 07  call 0x79a
            L0042: // NOP
            L0043: cx = PopStack(player);
            L0044: cx = PopStack(player);
0F3D  0045 FF 76 08  push word [bp+0x8]
0F40  0048 FF 76 06  push word [bp+0x6]
0F43  004B 0E     push cs
0F44  004C E8 F5 06  call 0x744
            L004F: // NOP
            L0050: cx = PopStack(player);
            L0051: cx = PopStack(player);
0F4A  0052 FF 76 08  push word [bp+0x8]
0F4D  0055 FF 76 06  push word [bp+0x6]
0F50  0058 0E     push cs
0F51  0059 E8 04 07  call 0x760
            L005C: // NOP
            L005D: cx = PopStack(player);
            L005E: cx = PopStack(player);
            L005F: return; // RETURN;
        }

        private void FnHEALFNT_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0F5C  0003 FF 76 08  push word [bp+0x8]
0F5F  0006 FF 76 06  push word [bp+0x6]
0F62  0009 0E     push cs
0F63  000A E8 08 07  call 0x715
            L000D: // NOP
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
            L0010: ShowMessage(player, String0F20); // The fountain's sickening waters churn in your stomach, but slowly you begin feeling revived and healthy!
            L001D: HealPlayer(player, GetMaxHits(player));
            L002E: return; // RETURN;
        }

        private void FnMANAFNT_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0F8C  0003 FF 76 08  push word [bp+0x8]
0F8F  0006 FF 76 06  push word [bp+0x6]
0F92  0009 0E     push cs
0F93  000A E8 D8 06  call 0x6e5
            L000D: // NOP
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
            L0010: PushStack(player, 0x01);
            L0014: PushStack(player, 0x00);
0FA0  0017 C4 5E 06  les bx, [bp+0x6]
0FA3  001A 26 FF 5F 04  call far word [es:bx+0x4]
            L001E: cx = PopStack(player);
            L001F: cx = PopStack(player);
            L0020: RefreshCompareFlags(ax);
            L0022: if (JumpNotEqual) goto L004F;
            L0024: ShowMessage(player, String0F89); // These sparkling waters are magical in nature and instantly restore your mana level.
            L0031: AddMana(player, 0x1388);
            L003E: PushStack(player, 0x01);
            L0042: PushStack(player, ax);
            L0043: PushStack(player, 0x00);
0FCF  0046 C4 5E 06  les bx, [bp+0x6]
0FD2  0049 26 FF 1F  call far word [es:bx]
0FD5  004C 83 C4 06  add sp, 0x6
            L004F: return; // RETURN;
        }

        private void FnMANAVAPR_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
            L0007: PushStack(player, 0x00);
0FE4  000A C4 5E 06  les bx, [bp+0x6]
0FE7  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L004A;
            L0017: ShowMessage(player, String0FDD); // Fetid fumes reek of evil magic.
            L0024: Compare(GetGuild(player), 0x0005);
            L002E: if (JumpNotEqual) goto L003D;
            L0030: AddMana(player, 0xFF06);
1017  003D FF 76 08  push word [bp+0x8]
101A  0040 FF 76 06  push word [bp+0x6]
101D  0043 0E     push cs
101E  0044 E8 37 06  call 0x67e
            L0047: // NOP
            L0048: cx = PopStack(player);
            L0049: cx = PopStack(player);
            L004A: return; // RETURN;
        }

        private void FnTHRULLS_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0013);
            L0010: ShowMessage(player, String0FFD); // A young Praxis is donning his armor.
            L001D: ShowMessage(player, String1022); // 'Hail, young warriors!'
            L002A: ShowMessage(player, String103A); // 'Many secrets are hidden about that will aid you in solving the enigma of the Master's Arena. Be aware of whose square you are fighting for!'
            L0037: return; // RETURN;
        }

        private void FnOWNER_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002B);
            L0010: ShowMessage(player, String10C8); // A portly wizard fumbles with some magical tomes.
            L001D: ShowMessage(player, String10F9); // 'What, what, what...? Who are you? Hmm, don't know the name.'
            L002A: ShowMessage(player, String1137); // 'Yes, yes, I know the Arena area. Have a look at those books over there on the wall. They should help you with your problem.'
            L0037: ShowMessage(player, String11B5); // He mumbles something about being bothered and returns to his reading.
            L0044: return; // RETURN;
        }

        private void FnTRAINER_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0018);
            L0010: ShowMessage(player, String11FB); // 'So, you're after the Dralkarians, eh? Well, good luck! The Night Elves worship those powerful deities.
            L001D: ShowMessage(player, String1263); // If I were you - and I'm NOT, thank the heavens! - I'd be on the lookout for some peculiar items.
            L002A: ShowMessage(player, String12C4); // After all, the Dralks are not of this earth. Seek them in their unique homes. You will know what I mean in time.'
            L0037: return; // RETURN;
        }

        private void FnTOCHESS_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1336); // Archaic runes in some forgotten tongue cover this gateway.
            L0010: ax = HasItem(player, 0xC8);
            L001E: if (JumpEqual) goto L005A;
            L0020: PushStack(player, 0x01);
            L0024: PushStack(player, 0x00);
1105  0027 C4 5E 06  les bx, [bp+0x6]
1108  002A 26 FF 5F 04  call far word [es:bx+0x4]
            L002E: cx = PopStack(player);
            L002F: cx = PopStack(player);
            L0030: RefreshCompareFlags(ax);
            L0032: if (JumpNotEqual) goto L0089;
            L0034: ShowMessage(player, String1371); // The lava glove allows you to open the portal.
111F  0041 FF 76 08  push word [bp+0x8]
1122  0044 FF 76 06  push word [bp+0x6]
1125  0047 0E     push cs
1126  0048 E8 2F 05  call 0x57a
            L004B: // NOP
            L004C: cx = PopStack(player);
            L004D: cx = PopStack(player);
112C  004E FF 76 08  push word [bp+0x8]
112F  0051 FF 76 06  push word [bp+0x6]
1132  0054 0E     push cs
1133  0055 E8 10 F2  call 0xf268
            L0058: goto L0087;
            L005A: ShowRunes(player, String139F); // 'This portal may be opened by the owner of the Lava Glove.'
            L0067: SetFlag(player, 0x02, 0x80, 0x02);
115A  007C FF 76 08  push word [bp+0x8]
115D  007F FF 76 06  push word [bp+0x6]
1160  0082 0E     push cs
1161  0083 E8 84 04  call 0x50a
            L0086: // NOP
            L0087: cx = PopStack(player);
            L0088: cx = PopStack(player);
            L0089: return; // RETURN;
        }

        private void FnSMLPRAX_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String13DB); // Praxis thaumaturges hurl magical bolts at you.
117E  0010 FF 76 08  push word [bp+0x8]
1181  0013 FF 76 06  push word [bp+0x6]
1184  0016 0E     push cs
1185  0017 E8 A1 03  call 0x3bb
            L001A: // NOP
            L001B: cx = PopStack(player);
            L001C: cx = PopStack(player);
            L001D: Compare(PartyCount(player), 0x0001);
            L0028: if (JumpEqual) goto L0031;
            L002A: Compare(ax, 0x0002);
            L002D: if (JumpEqual) goto L004C;
            L002F: goto L0079;
            L0031: AddEncounter(player, 0x01, 0x1B);
            L0043: PushStack(player, 0x1C);
11B5  0047 B8 02 00  mov ax, 0x2
            L004A: goto L00B6;
            L004C: AddEncounter(player, 0x01, 0x1B);
            L005E: AddEncounter(player, 0x02, 0x1C);
            L0070: PushStack(player, 0x1C);
11E2  0074 B8 03 00  mov ax, 0x3
            L0077: goto L00B6;
            L0079: AddEncounter(player, 0x01, 0x1B);
            L008B: AddEncounter(player, 0x02, 0x1C);
            L009D: AddEncounter(player, 0x05, 0x1D);
            L00AF: AddEncounter(player, 0x06, 0x1D);
            L00C1: return; // RETURN;
        }

        private void FnNPCTHRUL_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x000D);
            L0010: ShowMessage(player, String140A); // A wounded Erebus grabs your ankle.
            L001D: ShowMessage(player, String142D); // 'Kill me...kill me! If the Praxis discover me here, the war will be imminent.'
            L002A: ShowMessage(player, String147C); // He then collapses...
            L0037: return; // RETURN;
        }

        private void FnNPCPLYER_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001C);
            L0010: ShowMessage(player, String1491); // 'These feuding creatures are enough to drive me insane! I must defeat one of the Masters in the Arena.
            L001D: ShowMessage(player, String14F8); // Go see the scholar just south of here before you test your luck in the Arena. He has some books that will help you!'
            L002A: return; // RETURN;
        }

        private void FnTUFNPCS_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String156D); // War-hardened guildsmen attack!
12A6  0010 FF 76 08  push word [bp+0x8]
12A9  0013 FF 76 06  push word [bp+0x6]
12AC  0016 0E     push cs
12AD  0017 E8 79 02  call 0x293
            L001A: // NOP
            L001B: cx = PopStack(player);
            L001C: cx = PopStack(player);
            L001D: Compare(PartyCount(player), 0x0001);
            L0028: if (JumpEqual) goto L0031;
            L002A: Compare(ax, 0x0002);
            L002D: if (JumpEqual) goto L004C;
            L002F: goto L0079;
            L0031: AddEncounter(player, 0x01, 0x19);
            L0043: PushStack(player, 0x1E);
12DD  0047 B8 02 00  mov ax, 0x2
            L004A: goto L00C8;
            L004C: AddEncounter(player, 0x01, 0x19);
            L005E: AddEncounter(player, 0x02, 0x1E);
            L0070: PushStack(player, 0x1E);
130A  0074 B8 03 00  mov ax, 0x3
            L0077: goto L00C8;
            L0079: AddEncounter(player, 0x01, 0x19);
            L008B: AddEncounter(player, 0x02, 0x1E);
            L009D: AddEncounter(player, 0x03, 0x1E);
            L00AF: AddEncounter(player, 0x04, 0x23);
            L00C1: AddEncounter(player, 0x05, 0x1A);
            L00D3: return; // RETURN;
        }

        private void FnBOOKS_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String158C); // A dusty collection of books, similar to those you can find in the Queen's Palace, offers you hints on the Masters' Arena.
            L0010: ShowMessage(player, String1606); // 'When you take over a square, you acquire the piece's abilities you just defeated!
            L001D: ShowMessage(player, String1659); // Bishops move to corners, as north is to northeast.
            L002A: ShowMessage(player, String168C); // Knights attack in leaps in bounds. From here to there, by an L of renown.
            L0037: ShowMessage(player, String16D6); // Rooks connect onto that which is directly in front of them. Remember, you become that which you destroy.'
            L0044: ShowMessage(player, String1740); //       ==============
            L0051: ShowMessage(player, String1755); //       =0 0 0 0 0 0 =
            L005E: ShowMessage(player, String1755); //       =0 0 0 0 0 0 =
            L006B: ShowMessage(player, String176A); //       =  0 0 0 B 0 =
            L0078: ShowMessage(player, String177F); //       =  B>0 K R 0 =
            L0085: ShowMessage(player, String1794); //       =0 0 K 0 0 0 =
            L0092: ShowMessage(player, String17A9); //       =0 0 E P 0 0 =
            L009F: ShowMessage(player, String1740); //       ==============
            L00AC: return; // RETURN;
        }

        private void FnTODRAGB_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String17BE); // A long tunnel twists downward to Dragon's Flame.
            L0010: TeleportParty(player, 0x08, 0x02, 0x26, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void FnTODRAGA_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String17EF); // A flickering torch in the distance breaks the blackness around you. It marks the entrance to Dragon's Flame.
            L0010: TeleportParty(player, 0x08, 0x02, 0x9C, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnSETFLAG_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
1477  0005 56     push si
1478  0006 57     push di
            L0007: si = GetFlag(player, 0x02, 0x6F);
            L001A: si = si + 1;
            L001B: bx = si;
            L001D: bx = bx - 1;
            L001E: Compare(bx, 0x03);
            L0021: if (JumpAbove) goto L0049;
            L0023: switch (bx) {
                case 0:
                    goto L002A;
                case 1:
                    goto L0033;
                case 2:
                    goto L003A;
                case 3:
                    goto L0041;
                case 4:
                    goto L76E3;
                case 5:
                    goto LA47A;
                case 6:
                    goto L03EA;
                case 7:
                    goto LAFDE;
                case 8:
                    goto LFFFFF1EC;
                case 9:
                    goto LEAB4;
                case 10:
                    goto LE42D;
                case 11:
                    goto L448E;
                case 12:
                    goto L628D;
                case 13:
                    goto LEA96;
                case 14:
                    goto LFFFFF204;
                case 15:
                    goto LD39C;
                case 16:
                    goto LD9CE;
                case 17:
                    goto L44E7;
                case 18:
                    goto LB6EB;
                case 19:
                    goto L76E3;
                case 20:
                    goto LA47A;
                case 21:
                    goto L0439;
                case 22:
                    goto LAFDE;
                case 23:
                    goto LFFFFF1EC;
                case 24:
                    goto LEAB4;
                case 25:
                    goto LE42D;
                case 26:
                    goto L448E;
                case 27:
                    goto L628D;
                case 28:
                    goto LEA96;
                case 29:
                    goto LFFFFF204;
                case 30:
                    goto LD39C;
                case 31:
                    goto LFFFFEC52;
                case 32:
                    goto L451E;
                case 33:
                    goto L48E7;
                case 34:
                    goto L4159;
                case 35:
                    goto LD819;
                case 36:
                    goto LD811;
                case 37:
                    goto L4192;
                case 38:
                    goto L1EE5;
                case 39:
                    goto L1F84;
                case 40:
                    goto LB38D;
                case 41:
                    goto LE9D4;
                case 42:
                    goto LFFFFEB8E;
                case 43:
                    goto L4A52;
                case 44:
                    goto L1194;
                case 45:
                    goto L4B8D;
                case 46:
                    goto L74AE;
                case 47:
                    goto LE7D4;
                case 48:
                    goto LFFFFF047;
                case 49:
                    goto LA68E;
                case 50:
                    goto L0166;
                case 51:
                    goto L76BC;
                case 52:
                    goto L2695;
                case 53:
                    goto LE7D4;
                case 54:
                    goto LFFFFF202;
                case 55:
                    goto L2ED1;
                case 56:
                    goto LE070;
                case 57:
                    goto L1D79;
                case 58:
                    goto LEABC;
                case 59:
                    goto LFFFFF3F5;
                case 60:
                    goto LBA4C;
                case 61:
                    goto LAA8E;
                case 62:
                    goto LFFFFEB9A;
                case 63:
                    goto L1179;
                case 64:
                    goto LA44C;
                case 65:
                    goto LAA8E;
                case 66:
                    goto LFFFFEC11;
                case 67:
                    goto L3255;
                case 68:
                    goto L7B8C;
                case 69:
                    goto LD68E;
                case 70:
                    goto LA9A6;
                case 71:
                    goto LFFFFEC46;
                case 72:
                    goto L274D;
                case 73:
                    goto LB28E;
                case 74:
                    goto LE9D4;
                case 75:
                    goto LFFFFEC22;
                case 76:
                    goto LFFFFF779;
                case 77:
                    goto L424C;
                case 78:
                    goto LAA8E;
                case 79:
                    goto LFFFFEC5C;
                case 80:
                    goto L3255;
                case 81:
                    goto L698C;
                case 82:
                    goto LAF8E;
                case 83:
                    goto LFFFFF1EC;
                case 84:
                    goto LEAB4;
                case 85:
                    goto LFFFFFBED;
                case 86:
                    goto LAFDE;
                case 87:
                    goto LFFFFF1EC;
                case 88:
                    goto LEAB4;
                case 89:
                    goto L0BED;
                case 90:
                    goto L26E8;
                case 91:
                    goto L605E;
                case 92:
                    goto L41C3;
                case 93:
                    goto L4A52;
                case 94:
                    goto L1194;
                case 95:
                    goto L4B8D;
                case 96:
                    goto L44DE;
                case 97:
                    goto LAB99;
                case 98:
                    goto L1403;
                case 99:
                    goto LBC46;
                case 100:
                    goto L3B95;
                case 101:
                    goto LABC1;
                case 102:
                    goto L3BDE;
                case 103:
                    goto L628D;
                case 104:
                    goto L438C;
                case 105:
                    goto LAFE4;
                case 106:
                    goto LFFFFF1EC;
                case 107:
                    goto LEAB4;
                case 108:
                    goto LC42D;
                case 109:
                    goto L6E8E;
                case 110:
                    goto LFFFFF852;
                case 111:
                    goto L4A52;
                case 112:
                    goto L1194;
                case 113:
                    goto L4B8D;
                case 114:
                    goto L3BAE;
                case 115:
                    goto L4A52;
                case 116:
                    goto L1194;
                case 117:
                    goto L4B8D;
                case 118:
                    goto L44AA;
                case 119:
                    goto L49ED;
                case 120:
                    goto LD119;
                case 121:
                    goto LB6EB;
                case 122:
                    goto LFFFFEBCC;
                case 123:
                    goto LFFFFEC40;
                case 124:
                    goto LFFFFEC48;
                case 125:
                    goto LFFFFEC85;
                case 126:
                    goto L00F2;
                case 127:
                    goto L00EA;
                case 128:
                    goto L00FF;
                case 129:
                    goto L010C;
                case 130:
                    goto L76E3;
                case 131:
                    goto L1F7A;
                case 132:
                    goto L3C4E;
                case 133:
                    goto L4A52;
                case 134:
                    goto L1194;
                case 135:
                    goto L4B8D;
                case 136:
                    goto L3BB2;
                case 137:
                    goto L4A52;
                case 138:
                    goto L1194;
                case 139:
                    goto L4B8D;
                case 140:
                    goto L3BAE;
                case 141:
                    goto L4A52;
                case 142:
                    goto L1194;
                case 143:
                    goto L4B8D;
                case 144:
                    goto L6EBA;
                case 145:
                    goto LFFFFF252;
                case 146:
                    goto LB6EB;
                case 147:
                    goto L76E3;
                case 148:
                    goto LB07A;
                case 149:
                    goto LFFFFF1EC;
                case 150:
                    goto LEAB4;
                case 151:
                    goto L5FED;
                case 152:
                    goto LAFDE;
                case 153:
                    goto LFFFFF1EC;
                case 154:
                    goto LEAB4;
                case 155:
                    goto L7C2D;
                case 156:
                    goto L448E;
                case 157:
                    goto LB6EB;
                case 158:
                    goto L76E3;
                case 159:
                    goto LB07A;
                case 160:
                    goto LFFFFF1EC;
                case 161:
                    goto LEAB4;
                case 162:
                    goto L5BED;
                case 163:
                    goto LFFFFEE49;
                case 164:
                    goto L848E;
                case 165:
                    goto LE785;
                case 166:
                    goto LAFDE;
                case 167:
                    goto LFFFFF1EC;
                case 168:
                    goto LEAB4;
                case 169:
                    goto L7C2D;
                case 170:
                    goto L448E;
                case 171:
                    goto LB6EB;
                case 172:
                    goto L76E3;
                case 173:
                    goto LB07A;
                case 174:
                    goto LFFFFF1EC;
                case 175:
                    goto LEAB4;
                case 176:
                    goto L5BED;
                case 177:
                    goto LFFFFF249;
                case 178:
                    goto L848E;
                case 179:
                    goto LE785;
                case 180:
                    goto LAFDE;
                case 181:
                    goto LFFFFF1EC;
                case 182:
                    goto LEAB4;
                case 183:
                    goto L7C2D;
                case 184:
                    goto L448E;
                case 185:
                    goto LB6EB;
                case 186:
                    goto L76E3;
                case 187:
                    goto LA47A;
                case 188:
                    goto LFFFFEB8F;
                case 189:
                    goto L3BDE;
                case 190:
                    goto LABC1;
                case 191:
                    goto LAFDE;
                case 192:
                    goto LFFFFF1EC;
                case 193:
                    goto LEAB4;
                case 194:
                    goto L6EAD;
                case 195:
                    goto LFFFFF252;
                case 196:
                    goto LB6EB;
                case 197:
                    goto L76E3;
                case 198:
                    goto LA47A;
                case 199:
                    goto LFFFFEBD0;
                case 200:
                    goto LAFDE;
                case 201:
                    goto LFFFFF1EC;
                case 202:
                    goto LEAB4;
                case 203:
                    goto LE82D;
                case 204:
                    goto L448E;
                case 205:
                    goto LB6EB;
                case 206:
                    goto L76E3;
                case 207:
                    goto LA47A;
                case 208:
                    goto L04C0;
                case 209:
                    goto LAFDE;
                case 210:
                    goto LFFFFF1EC;
                case 211:
                    goto LEAB4;
                case 212:
                    goto LE42D;
                case 213:
                    goto L448E;
                case 214:
                    goto LB6EB;
                case 215:
                    goto L76E3;
                case 216:
                    goto LA47A;
                case 217:
                    goto LFFFFEC24;
                case 218:
                    goto LA3DE;
                case 219:
                    goto LFFFFEB98;
                case 220:
                    goto LA3DE;
                case 221:
                    goto LFFFFEB8F;
                case 222:
                    goto LAFDE;
                case 223:
                    goto LFFFFF1EC;
                case 224:
                    goto LEAB4;
                case 225:
                    goto L882D;
                case 226:
                    goto L6E8E;
                case 227:
                    goto LFFFFF252;
                case 228:
                    goto LB6EB;
            }
149C  002A C7 46 FE 22 00  mov word [bp-0x2], 0x22
14A1  002F 8B FE  mov di, si
            L0031: goto L0049;
14A5  0033 C7 46 FE 23 00  mov word [bp-0x2], 0x23
            L0038: goto L002F;
14AC  003A C7 46 FE 26 00  mov word [bp-0x2], 0x26
            L003F: goto L002F;
14B3  0041 C7 46 FE 22 00  mov word [bp-0x2], 0x22
            L0046: di = 0x0001;
14BB  0049 FF 76 FE  push word [bp-0x2]
            L004C: PushStack(player, 0x01);
14C2  0050 C4 5E 06  les bx, [bp+0x6]
14C5  0053 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0058: cx = PopStack(player);
            L0059: cx = PopStack(player);
14CC  005A 57     push di
            L005B: PushStack(player, 0x6F);
            L005F: PushStack(player, 0x02);
14D5  0063 C4 5E 06  les bx, [bp+0x6]
14D8  0066 26 FF 1F  call far word [es:bx]
14DB  0069 83 C4 06  add sp, 0x6
14DE  006C 5F     pop di
14DF  006D 5E     pop si
            L006E: // restore stack ptr: sp = bp;
            L0070: return; // RETURN;
        }

        private void FnMAPDESCR_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x71);
            L0011: if (JumpEqual) goto L008D;
            L0013: ax = GetFlag(player, 0x02, 0x39);
16D2  0024 F7 D8  neg ax
16D4  0026 1B C0  sbb ax, ax
16D6  0028 40     inc ax
16D7  0029 A9 04 00  test ax, 0x4
            L002C: if (JumpEqual) goto L008D;
16DC  002E B8 62 19  mov ax, 0x1962
            L0031: PushStack(player, ax);
16E0  0032 C4 5E 06  les bx, [bp+0x6]
16E3  0035 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L003A: goto L0047;
            L003C: RemoveItem(player, 0x71);
            L0048: ax = HasItem(player, 0x71);
            L0056: if (JumpNotEqual) goto L003C;
            L0058: ModifyGold(player, 0xFFFFF0BA);
            L006A: AddExperience(player, 0xFFFCF2C0);
            L007C: DamagePlayer(player, GetMaxHits(player));
            L008D: ShowMessage(player, String19B8); // This area is certainly not the grand entrance to the Dralkarian kingdom you had envisioned.
            L009A: ShowMessage(player, String1A14); // The walls and floors are in decay, all covered with lichens and scorch marks. Pools of lava and shadow litter the floor.
            L00A7: ShowMessage(player, String1A8D); // The crumbling stones and cracked granite act as testimony to the war brewing between the Praxis and Erebus armies that dominate this domain.
            L00B4: return; // RETURN;
        }

        private void FnPORTME_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: Compare(GetCurrentTile(player), 0x0077);
            L000F: if (JumpEqual) goto L0018;
            L0011: Compare(ax, 0x0078);
            L0014: if (JumpEqual) goto L0020;
            L0016: goto L0026;
            L0018: si = 0x007C;
            L001B: di = 0x0036;
            L001E: goto L0026;
            L0020: si = 0x007B;
            L0023: di = 0x0039;
178A  0026 56     push si
            L0027: PushStack(player, 0x02);
178F  002B C4 5E 06  les bx, [bp+0x6]
1792  002E 26 FF 5F 04  call far word [es:bx+0x4]
            L0032: cx = PopStack(player);
            L0033: cx = PopStack(player);
            L0034: RefreshCompareFlags(ax);
            L0036: if (JumpNotEqual) goto L0094;
            L0038: Compare(si, 0x7C);
            L003B: if (JumpNotEqual) goto L0049;
17A1  003D FF 76 08  push word [bp+0x8]
17A4  0040 FF 76 06  push word [bp+0x6]
17A7  0043 0E     push cs
17A8  0044 E8 08 EB  call 0xeb4f
            L0047: goto L0053;
17AD  0049 FF 76 08  push word [bp+0x8]
17B0  004C FF 76 06  push word [bp+0x6]
17B3  004F 0E     push cs
17B4  0050 E8 2D EB  call 0xeb80
            L0053: cx = PopStack(player);
            L0054: cx = PopStack(player);
            L0055: PushStack(player, 0x01);
17BD  0059 56     push si
            L005A: PushStack(player, 0x02);
17C2  005E C4 5E 06  les bx, [bp+0x6]
17C5  0061 26 FF 1F  call far word [es:bx]
17C8  0064 83 C4 06  add sp, 0x6
            L0067: SetFlag(player, 0x02, 0x6F, 0x02);
            L007C: PushStack(player, 0x03);
17E4  0080 57     push di
            L0081: PushStack(player, 0x01);
            L0085: PushStack(player, 0x08);
17ED  0089 C4 5E 06  les bx, [bp+0x6]
17F0  008C 26 FF 9F BC 00  call far word [es:bx+0xbc]
17F5  0091 83 C4 08  add sp, 0x8
            L0094: return; // RETURN (restoring si, di);
        }

        private void FnQAOCHESS_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
            L0007: PushStack(player, 0x00);
1806  000A C4 5E 06  les bx, [bp+0x6]
1809  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L0030;
            L0017: ShowMessage(player, String1B1A); // Ancient carvings of living chess pieces decorate this mysterious portal. Heavy fumes of evil seep upwards from this portal to Dragon's Flame.
1820  0024 FF 76 08  push word [bp+0x8]
1823  0027 FF 76 06  push word [bp+0x6]
1826  002A 0E     push cs
1827  002B E8 2E FE  call 0xfe5c
            L002E: cx = PopStack(player);
            L002F: cx = PopStack(player);
            L0030: TeleportParty(player, 0x08, 0x02, 0x26, 0x00, isForwardMove);
            L004A: return; // RETURN;
        }

        private void FnLAVAGLOV_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xC8);
            L0011: if (JumpEqual) goto L0020;
            L0013: ShowMessage(player, String1BA8); // Your Lava Glove begins to glow with white-hot intensity...tugging you in this direction.
            L0020: return; // RETURN;
        }

        private void FnQUIKMAST_37(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0032;
            L0010: Compare(GetFlag(player, 0x02, 0x7B), 0x0002);
            L0024: if (JumpNotEqual) goto L003E;
1895  0026 FF 76 08  push word [bp+0x8]
1898  0029 FF 76 06  push word [bp+0x6]
189B  002C 0E     push cs
189C  002D E8 4D FC  call 0xfc7d
            L0030: goto L003C;
18A1  0032 FF 76 08  push word [bp+0x8]
18A4  0035 FF 76 06  push word [bp+0x6]
18A7  0038 0E     push cs
18A8  0039 E8 5F FC  call 0xfc9b
            L003C: cx = PopStack(player);
            L003D: cx = PopStack(player);
            L003E: return; // RETURN;
        }

        private void FnSETFLAG_38(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = 0x00DE;
            L0007: Compare(GetCurrentTile(player), 0x0087);
            L0011: if (JumpEqual) goto L001A;
            L0013: Compare(ax, 0x0088);
            L0016: if (JumpEqual) goto L001F;
            L0018: goto L0022;
            L001A: si = 0x007C;
            L001D: goto L0022;
            L001F: si = 0x007B;
18D1  0022 56     push si
            L0023: PushStack(player, 0x02);
18D6  0027 C4 5E 06  les bx, [bp+0x6]
18D9  002A 26 FF 5F 04  call far word [es:bx+0x4]
            L002E: cx = PopStack(player);
            L002F: cx = PopStack(player);
            L0030: Compare(ax, 0x0002);
            L0033: if (JumpEqual) goto L0076;
18E4  0035 56     push si
            L0036: PushStack(player, 0x02);
18E9  003A C4 5E 06  les bx, [bp+0x6]
18EC  003D 26 FF 5F 04  call far word [es:bx+0x4]
            L0041: cx = PopStack(player);
            L0042: cx = PopStack(player);
            L0043: Compare(ax, 0x0001);
            L0046: if (JumpNotEqual) goto L0076;
            L0048: PushStack(player, 0x02);
18FB  004C 56     push si
            L004D: PushStack(player, ax);
18FD  004E C4 5E 06  les bx, [bp+0x6]
1900  0051 26 FF 1F  call far word [es:bx]
1903  0054 83 C4 06  add sp, 0x6
            L0057: AddExperience(player, 0x00055730);
            L0069: ShowMessage(player, String1C01); // Your prowess is acknowledged. Gain wisdom from your actions.
            L0076: return; // RETURN (restoring si);
        }

        private void FnQUICERBS_39(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0032;
            L0010: Compare(GetFlag(player, 0x02, 0x7C), 0x0002);
            L0024: if (JumpNotEqual) goto L003E;
194E  0026 FF 76 08  push word [bp+0x8]
1951  0029 FF 76 06  push word [bp+0x6]
1954  002C 0E     push cs
1955  002D E8 94 FB  call 0xfbc4
            L0030: goto L003C;
195A  0032 FF 76 08  push word [bp+0x8]
195D  0035 FF 76 06  push word [bp+0x6]
1960  0038 0E     push cs
1961  0039 E8 A6 FB  call 0xfbe2
            L003C: cx = PopStack(player);
            L003D: cx = PopStack(player);
            L003E: return; // RETURN;
        }

        private void FnNOJOIN_3B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(player);
            L000B: return; // RETURN;
        }

        private void FnTOMRMORE_3C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1C3E); // A dark portal offers you descent into untamed depths of this dark underworld.
            L0010: TeleportParty(player, 0x09, 0x02, 0x77, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnQAOSRVNT_3D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String1C8C); // Servants of Qao rise from the lava to repel encroaching invaders!
            L0011: ax = HasItem(player, 0xB8);
            L001F: if (JumpNotEqual) goto L006A;
            L0021: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0034: if (JumpNotEqual) goto L006A;
19DD  0036 B8 D0 07  mov ax, 0x7d0
            L0039: PushStack(player, ax);
            L003A: PushStack(player, 0x00);
            L003D: PushStack(player, ax);
            L003E: PushStack(player, 0xAF);
            L0042: PushStack(player, 0xA7);
            L0046: PushStack(player, 0xB8);
19F1  004A C4 5E 06  les bx, [bp+0x6]
19F4  004D 26 FF 9F D8 00  call far word [es:bx+0xd8]
19F9  0052 83 C4 0C  add sp, 0xc
            L0055: SetFlag(player, 0x03, 0x05, 0x01);
            L006A: Compare(PartyCount(player), 0x0001);
            L0075: if (JumpEqual) goto L007E;
            L0077: Compare(ax, 0x0002);
            L007A: if (JumpEqual) goto L007E;
            L007C: goto L0098;
            L007E: si = 0x0001;
            L0081: goto L0093;
            L0083: AddEncounter(player, si, 0x18);
            L0092: si = si + 1;
            L0093: Compare(si, 0x02);
            L0096: if (JumpLessOrEqual) goto L0083;
            L0098: si = 0x0001;
            L009B: goto L00AD;
            L009D: AddEncounter(player, si, 0x18);
            L00AC: si = si + 1;
            L00AD: Compare(si, 0x04);
            L00B0: if (JumpLessOrEqual) goto L009D;
            L00B2: return; // RETURN (restoring si);
        }

    }
}
