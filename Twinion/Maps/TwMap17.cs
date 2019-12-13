#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Twinion.Maps {
    class TwMap17 : AMapScripted {
        protected override int MapIndex => 17;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 1;

        public TwMap17() {
            MapEvent01 = FnNPCKEY_01;
            MapEvent02 = FnCLUEA_02;
            MapEvent03 = FnTELEP_03;
            MapEvent04 = FnGOODIEA_04;
            MapEvent05 = FnSECA_05;
            MapEvent06 = FnDEATH_06;
            MapEvent07 = FnTELOA_07;
            MapEvent08 = FnPARTYCK_08;
            MapEvent09 = FnSTRENGTH_09;
            MapEvent0A = FnTELOB_0A;
            MapEvent0B = FnRPEDRTXT_0B;
            MapEvent0C = FnMANADOWN_0C;
            MapEvent0D = FnTELEB_0D;
            MapEvent0E = FnTELEC_0E;
            MapEvent0F = FnTELED_0F;
            MapEvent10 = FnGOLDAWAY_10;
            MapEvent11 = FnCLUEC_11;
            MapEvent12 = FnSPECDRA_12;
            MapEvent13 = FnCLUED_13;
            MapEvent14 = FnTELEE_14;
            MapEvent15 = FnDEATHA_15;
            MapEvent16 = FnSPECDRB_16;
            MapEvent17 = FnTELEF_17;
            MapEvent18 = FnMAPB_18;
            MapEvent19 = FnTEXTCLU_19;
            MapEvent1A = FnROPEX_1A;
            MapEvent1B = FnTELEG_1B;
            MapEvent1C = FnNPCLOCKA_1C;
            MapEvent1D = FnCLUEE_1D;
            MapEvent1E = FnTELEH_1E;
            MapEvent1F = FnTELEI_1F;
            MapEvent20 = FnNPCLOCKB_20;
            MapEvent21 = FnRRRTNPC_21;
            MapEvent22 = FnBLOCSPCL_22;
            MapEvent23 = FnTEXTB_23;
            MapEvent24 = FnNPCCLA_24;
            MapEvent25 = FnFINDSTF_25;
            MapEvent26 = FnTELEJ_26;
            MapEvent27 = FnFNTA_27;
            MapEvent28 = FnGOODIEB_28;
            MapEvent29 = FnCLUEBALL_29;
            MapEvent2A = FnWARN_2A;
            MapEvent2B = FnMEDA_2B;
            MapEvent2C = FnMEDB_2C;
            MapEvent2D = FnHRDA_2D;
            MapEvent2E = FnMEDC_2E;
            MapEvent2F = FnEZA_2F;
            MapEvent30 = FnMEDD_30;
            MapEvent31 = FnEZB_31;
            MapEvent32 = FnHRDB_32;
            MapEvent33 = FnBRDGNOTE_33;
            MapEvent34 = Fn_34;
        }
        
        // === Strings ================================================
        private const string String03FC = "You meet a watchman.";
        private const string String0411 = "'Greetings, adventurers! You've found your way to Tipekans.";
        private const string String044D = "Our laws require me to take your Tnepres Key. In exchange, however, I will register you for unlimited passage to our town.";
        private const string String04C8 = "As a first time visitor, please accept this welcome scroll.";
        private const string String0504 = "May your journey be safe and profitable.'";
        private const string String052E = "The thief says, 'You have no key for passage. Return when you have the proper item.";
        private const string String0582 = "It would certainly be amazing if such as you could find the right item.'";
        private const string String05CB = "You bump into a young thief.";
        private const string String05E8 = "'Tis a far better thing to be understood than to be heard!";
        private const string String0623 = "Confused?  Confounded?  Is there no one who knows a good clue when he hears it?'";
        private const string String0674 = "Vile creatures rise from the Snake Pit to attack you.";
        private const string String06AA = "You discover a door in the wall.";
        private const string String06CB = "You notice strange markings resembling a code on the wall.";
        private const string String0706 = "You step into a dark alley.";
        private const string String0722 = "The cold steel of a thief's stiletto in your back cuts your odds of surviving this ambush!";
        private const string String077D = "To the Ballroom";
        private const string String078D = "You may rejoin your party.";
        private const string String07A8 = "The stubborn door finally yields, and you push it open.";
        private const string String07E0 = "You lack the strength to push open the door.";
        private const string String080D = "To the Cellar";
        private const string String081B = "Your clever exchange of lockpicks now offers you a secret entrance into the Ballroom.";
        private const string String0871 = "You must proceed alone through this door.";
        private const string String089B = "Fumes momentarily overcome you, leeching away your spellcasting ability.";
        private const string String08E4 = "You disturb a sleeping thief.";
        private const string String0902 = "He gets revenge by deftly picking your pocket and fleeing.";
        private const string String093D = "An angry wizard grabs you by the lapel.";
        private const string String0965 = "'I was turned away from the Cartography Shop because I only had three pieces of a map. I must keep searching!'";
        private const string String09D4 = "The glow from the Sapphire Lockpick reveals a door.";
        private const string String0A08 = "You see footprints leading to the wall and disappearing, but you have no way through the obviously solid wall.";
        private const string String0A77 = "You find a note from a fellow adventurer -";
        private const string String0AA2 = "'My journey was fruitless because I lacked an Emerald Lockpick.'";
        private const string String0AE3 = "You walk through the passage and step confidently onto Tipekans' Bridge.";
        private const string String0B2C = "The bridge collapses under the weight of your party and you plunge to your death.";
        private const string String0B7E = "You manage to grab hold of an extending beam as the bridge collapses beneath you. The door here, unfortunately, is sealed forever shut.";
        private const string String0C06 = "As you try to swing back across, you lose your grip and hurl downwards into darkness!";
        private const string String0C5C = "Some mystical winds grab your body and pull you off into the Cloister!";
        private const string String0CA3 = "You open the door with your Diamond Lockpick.";
        private const string String0CD1 = "The locked door has a diamond-shaped keyhole.";
        private const string String0CFF = "You find nothing of interest. Your Ruby Lockpick suddenly crumbles into dust.";
        private const string String0D4D = "You find a map hastily drawn on a piece of snakeskin.";
        private const string String0D83 = "The Snakeskin Map must be one of the four the Queen sent you to find.";
        private const string String0DC9 = "Your Ruby Lockpick mysteriously crumbles into dust.";
        private const string String0DFD = "The Snakeskin Map must be one of the four Queen Aeowyn has sent you to find.";
        private const string String0E4A = "On the floor you find a page from an old journal.";
        private const string String0E7C = "It recounts the story of an adventurer who gained great wisdom by discovering a map piece.";
        private const string String0ED7 = "A wandering band of thieves overcomes you. They steal your lockpick.";
        private const string String0F1C = "You are attacked by thieves who bind you with rope.";
        private const string String0F50 = "The leader pilfers your lockpick.";
        private const string String0F72 = "You eventually manage to free yourself, and you tuck the rope away.";
        private const string String0FB6 = "A wandering band of thieves ignores you since you have nothing of value.";
        private const string String0FFF = "A Troll Ranger drags you into the shadows.";
        private const string String102A = "'I assume you found the note about the Emerald Lockpick I left by the entrance.";
        private const string String107A = "Congratulations on your success so far!";
        private const string String10A2 = "My reward for helping you is the Diamond Lockpick you possess - or used to possess, anyway.";
        private const string String10FE = "Take this Sapphire Lockpick in exchange. Though less valuable, it has the magical property to help you see things not readily apparent to the eye.'";
        private const string String1192 = "A Troll Ranger twirls a sparkling blue lockpick.";
        private const string String11C3 = "'I left a note by the entrance. It concerns an Emerald Lockpick.";
        private const string String1204 = "Heed its warning well, and you will be well rewarded.'";
        private const string String123B = "In the distance you hear the wail of a madman -";
        private const string String126B = "'Hither and yonder I have searched! Nowhere, nowhere could I find that lovely little map writ large upon a parchment!'";
        private const string String12E2 = "A Gremlin Cleric slaps you resoundingly on the back.";
        private const string String1317 = "'Well done! You've found my lost Emerald Lockpick.";
        private const string String134A = "I can't thank you enough for helping me!";
        private const string String1373 = "Please accept this Diamond Lockpick for your troubles.'";
        private const string String13AB = "A Gremlin Cleric is searching in the dust.";
        private const string String13D6 = "'I lost my beautiful Emerald Lockpick.";
        private const string String13FD = "If you retrieve it, I will reward you most handsomely.";
        private const string String1434 = "Remember, however, that you must be a registered visitor to Tipekans.'";
        private const string String147B = "An exasperated Halfling waves a piece of leather.";
        private const string String14AD = "'The Races! What an aptly named place it was, since only certain races can enter certain rooms.";
        private const string String150D = "I wish I had discovered that fact sooner. But, eventually, I did find the two doors for my race.'";
        private const string String156F = "You overhear two thieves talking about how clever Sneer, Smug and Smirk are in preventing bothersome adventurers from gaining access into the center of Tipekans.";
        private const string String1611 = "A Dwarf Knight walks up to you. He rubs his head.";
        private const string String1643 = "'I'm looking for a temple to take care of this wound!";
        private const string String1679 = "My journey has taken me to a strange place. Not one wall did I see, yet I could not advance. It was pure pandemonium.'";
        private const string String16F0 = "You find a secret hiding place in which the thieves of Tipekans store their ill-gotten goods.";
        private const string String174E = "What used to be a hiding place for stolen loot is now empty.";
        private const string String178B = "The cascading waters of Viper Fountain heal your wounds and restore your mana.";
        private const string String17DA = "You stumble upon a weird assortment of scavengers.";
        private const string String180D = "You surprise a wraith who seems to be dancing.";
        private const string String183C = "'Oh! You startled me. I was just recalling the wondrous sounds of music that used to fill these corridors.";
        private const string String18A7 = "I was sure there was a door somewhere along here to the Ballroom.'";
        private const string String18EA = "A flash of steel is quickly doused as you near a shadowy alley.";
        private const string String192A = "An unsturdy bridge leads eastward towards an ancient door covered in lichens. The fragile bridge creaks warningly as you approach.";
        
        // === Functions ================================================
        private void FnNPCKEY_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x54), 0x0001);
            L0017: if (JumpEqual) goto L002F;
            L0019: Compare(GetFlag(player, 0x02, 0x54), 0x0002);
            L002D: if (JumpNotEqual) goto L003D;
            L002F: PushStack(player, 0xD9);
0040  0033 C4 5E 06  les bx, [bp+0x6]
0043  0036 26 FF 5F 4C  call far word [es:bx+0x4c]
            L003A: goto L0116;
            L003D: ax = HasItem(player, 0xD9);
            L004B: if (JumpEqual) goto L00BF;
            L004D: ShowPortrait(player, 0x0023);
            L005A: GiveItem(player, 0xAA);
            L0066: SetFlag(player, 0x02, 0x54, 0x01);
            L007B: ShowMessage(player, String03FC); // You meet a watchman.
            L0088: ShowMessage(player, String0411); // 'Greetings, adventurers! You've found your way to Tipekans.
            L0095: ShowMessage(player, String044D); // Our laws require me to take your Tnepres Key. In exchange, however, I will register you for unlimited passage to our town.
            L00A2: ShowMessage(player, String04C8); // As a first time visitor, please accept this welcome scroll.
            L00AF: ShowMessage(player, String0504); // May your journey be safe and profitable.'
            L00BC: goto L002F;
            L00BF: ShowPortrait(player, 0x0023);
            L00CC: Compare(GetCurrentTile(player), 0x0006);
            L00D6: if (JumpEqual) goto L00DF;
            L00D8: Compare(ax, 0x0031);
            L00DB: if (JumpEqual) goto L00E7;
            L00DD: goto L00FD;
            L00DF: PushStack(player, 0x00);
00EF  00E2 B8 02 00  mov ax, 0x2
            L00E5: goto L00EA;
            L00E7: SetWallPassable(player, GetCurrentTile(player), ax, 0x00);
            L00FD: ShowMessage(player, String052E); // The thief says, 'You have no key for passage. Return when you have the proper item.
            L010A: ShowMessage(player, String0582); // It would certainly be amazing if such as you could find the right item.'
            L0117: return; // RETURN;
        }

        private void FnCLUEA_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0024);
            L0010: ShowMessage(player, String05CB); // You bump into a young thief.
            L001D: ShowMessage(player, String05E8); // 'Tis a far better thing to be understood than to be heard!
            L002A: ShowMessage(player, String0623); // Confused?  Confounded?  Is there no one who knows a good clue when he hears it?'
            L0037: return; // RETURN;
        }

        private void FnTELEP_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x07, 0x01, 0xD4, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnGOODIEA_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0674); // Vile creatures rise from the Snake Pit to attack you.
            L0010: ax = HasItem(player, 0x23);
            L001E: if (JumpEqual) goto L0032;
019F  0020 B8 D0 07  mov ax, 0x7d0
            L0023: PushStack(player, ax);
            L0024: PushStack(player, 0x00);
            L0027: PushStack(player, ax);
            L0028: PushStack(player, ax);
            L0029: PushStack(player, 0xBA);
01AC  002D B8 C3 00  mov ax, 0xc3
            L0030: goto L0042;
01B1  0032 B8 D0 07  mov ax, 0x7d0
            L0035: PushStack(player, ax);
            L0036: PushStack(player, 0x00);
            L0039: PushStack(player, ax);
            L003A: PushStack(player, ax);
            L003B: PushStack(player, 0x53);
            L003F: PushStack(player, 0x23);
01C2  0043 C4 5E 06  les bx, [bp+0x6]
01C5  0046 26 FF 9F D8 00  call far word [es:bx+0xd8]
01CA  004B 83 C4 0C  add sp, 0xc
            L004E: Compare(PartyCount(player), 0x0001);
            L0059: if (JumpNotEqual) goto L0077;
            L005B: AddEncounter(player, 0x01, 0x27);
            L006D: PushStack(player, 0x05);
01F0  0071 B8 02 00  mov ax, 0x2
            L0074: goto L010F;
            L0077: Compare(PartyCount(player), 0x0002);
            L0082: if (JumpNotEqual) goto L00B1;
            L0084: AddEncounter(player, 0x01, 0x27);
            L0096: AddEncounter(player, 0x02, 0x27);
            L00A8: PushStack(player, 0x19);
022B  00AC B8 03 00  mov ax, 0x3
            L00AF: goto L010F;
            L00B1: AddEncounter(player, 0x01, 0x27);
            L00C3: AddEncounter(player, 0x02, 0x27);
            L00D5: AddEncounter(player, 0x03, 0x19);
            L00E7: AddEncounter(player, 0x04, 0x19);
            L00F9: PushStack(player, 0x05);
            L00FD: PushStack(player, ax);
027D  00FE C4 5E 06  les bx, [bp+0x6]
0280  0101 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0106: cx = PopStack(player);
            L0107: cx = PopStack(player);
            L0108: AddEncounter(player, 0x06, 0x05);
            L011A: return; // RETURN;
        }

        private void FnSECA_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x0006);
            L0012: if (JumpNotBelow) goto L006C;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L006C;
            L0024: PushStack(player, 0x68);
            L0028: PushStack(player, ax);
02C4  0029 C4 5E 06  les bx, [bp+0x6]
02C7  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L006C;
            L0036: PushStack(player, 0x6E);
            L003A: PushStack(player, ax);
02D6  003B C4 5E 06  les bx, [bp+0x6]
02D9  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L006C;
            L0048: PushStack(player, 0x90);
            L004C: PushStack(player, ax);
02E8  004D C4 5E 06  les bx, [bp+0x6]
02EB  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L006C;
            L005A: PushStack(player, 0xA4);
            L005E: PushStack(player, ax);
02FA  005F C4 5E 06  les bx, [bp+0x6]
02FD  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpEqual) goto L0093;
            L006C: ShowMessage(player, String06AA); // You discover a door in the wall.
            L0079: XCall Fn1251
            L0084: cx = PopStack(player);
            L0085: cx = PopStack(player);
            L0086: XCall Fn122E
            L0091: goto L00AB;
            L0093: ShowMessage(player, String06CB); // You notice strange markings resembling a code on the wall.
            L00A0: XCall Fn120C
            L00AB: cx = PopStack(player);
            L00AC: cx = PopStack(player);
            L00AD: return; // RETURN;
        }

        private void FnDEATH_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = 0;
            L0006: ShowMessage(player, String0706); // You step into a dark alley.
            L0013: ShowMessage(player, String0722); // The cold steel of a thief's stiletto in your back cuts your odds of surviving this ambush!
            L0020: ax = GetCurrentHits(player);
            L0027: bx = 0x0003;
            L002A: dx = ax % bx; ax = ax / bx;
            L002D: DamagePlayer(player, ax);
            L0037: si = 0x0001;
            L003A: goto L004C;
            L003C: AddEncounter(player, si, 0x28);
            L004B: si = si + 1;
            L004C: Compare(si, 0x02);
            L004F: if (JumpLessOrEqual) goto L003C;
            L0051: return; // RETURN (restoring si);
        }

        private void FnTELOA_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String077D); // To the Ballroom
            L0010: TeleportParty(player, 0x04, 0x01, 0xAC, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnPARTYCK_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L001F;
            L0010: ShowMessage(player, String078D); // You may rejoin your party.
            L001D: goto L003A;
            L001F: TeleportParty(player, 0x07, 0x01, 0x3B, 0x02, isForwardMove);
            L003A: return; // RETURN;
        }

        private void FnSTRENGTH_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(CheckStrength(player), 0x0013);
            L0012: if (JumpBelow) goto L0033;
            L0014: XCall Fn10C2
            L001F: cx = PopStack(player);
            L0020: cx = PopStack(player);
            L0021: XCall Fn10E5
            L002C: cx = PopStack(player);
            L002D: cx = PopStack(player);
0435  002E B8 A8 07  mov ax, 0x7a8
            L0031: goto L0043;
            L0033: XCall Fn10A0
            L003E: cx = PopStack(player);
            L003F: cx = PopStack(player);
            L0040: ShowMessage(player, String07E0); // You lack the strength to push open the door.
            L004D: return; // RETURN;
        }

        private void FnTELOB_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String080D); // To the Cellar
            L0010: TeleportParty(player, 0x06, 0x01, 0x15, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnRPEDRTXT_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x56), 0x0001);
            L0017: if (JumpNotEqual) goto L0061;
            L0019: Compare(PartyCount(player), 0x0001);
            L0024: if (JumpNotEqual) goto L004F;
            L0026: XCall Fn1046
            L0031: cx = PopStack(player);
            L0032: cx = PopStack(player);
            L0033: XCall Fn1069
            L003E: cx = PopStack(player);
            L003F: cx = PopStack(player);
            L0040: ShowMessage(player, String081B); // Your clever exchange of lockpicks now offers you a secret entrance into the Ballroom.
            L004D: goto L006E;
            L004F: XCall Fn1024
            L005A: cx = PopStack(player);
            L005B: cx = PopStack(player);
04DF  005C B8 71 08  mov ax, 0x871
            L005F: goto L0043;
            L0061: XCall Fn1024
            L006C: cx = PopStack(player);
            L006D: cx = PopStack(player);
            L006E: return; // RETURN;
        }

        private void FnMANADOWN_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String089B); // Fumes momentarily overcome you, leeching away your spellcasting ability.
            L0010: AddMana(player, 0xFED4);
            L001D: return; // RETURN;
        }

        private void FnTELEB_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x07, 0x01, 0xF5, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnTELEC_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x07, 0x01, 0x71, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELED_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x07, 0x01, 0x35, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnGOLDAWAY_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String08E4); // You disturb a sleeping thief.
            L0010: ShowMessage(player, String0902); // He gets revenge by deftly picking your pocket and fleeing.
            L001D: ModifyGold(player, 0xFFFF18BA);
            L002F: return; // RETURN;
        }

        private void FnCLUEC_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002D);
            L0010: ShowMessage(player, String093D); // An angry wizard grabs you by the lapel.
            L001D: ShowMessage(player, String0965); // 'I was turned away from the Cartography Shop because I only had three pieces of a map. I must keep searching!'
            L002A: return; // RETURN;
        }

        private void FnSPECDRA_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xDC);
            L0011: if (JumpEqual) goto L0032;
            L0013: XCall Fn0EFB
            L001E: cx = PopStack(player);
            L001F: cx = PopStack(player);
            L0020: XCall Fn0F1E
            L002B: cx = PopStack(player);
            L002C: cx = PopStack(player);
05FB  002D B8 D4 09  mov ax, 0x9d4
            L0030: goto L0042;
            L0032: XCall Fn0ED9
            L003D: cx = PopStack(player);
            L003E: cx = PopStack(player);
            L003F: ShowMessage(player, String0A08); // You see footprints leading to the wall and disappearing, but you have no way through the obviously solid wall.
            L004C: return; // RETURN;
        }

        private void FnCLUED_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0A77); // You find a note from a fellow adventurer -
            L0010: ShowMessage(player, String0AA2); // 'My journey was fruitless because I lacked an Emerald Lockpick.'
            L001D: return; // RETURN;
        }

        private void FnTELEE_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x07, 0x01, 0xEA, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnDEATHA_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(player);
            L000B: ShowMessage(player, String0AE3); // You walk through the passage and step confidently onto Tipekans' Bridge.
            L0018: Compare(PartyCount(player), 0x0001);
            L0023: if (JumpBelowOrEqual) goto L0045;
            L0025: ShowMessage(player, String0B2C); // The bridge collapses under the weight of your party and you plunge to your death.
            L0032: DamagePlayer(player, GetMaxHits(player));
            L0043: goto L0087;
            L0045: ShowMessage(player, String0B7E); // You manage to grab hold of an extending beam as the bridge collapses beneath you. The door here, unfortunately, is sealed forever shut.
            L0052: ShowMessage(player, String0C06); // As you try to swing back across, you lose your grip and hurl downwards into darkness!
            L005F: ShowMessage(player, String0C5C); // Some mystical winds grab your body and pull you off into the Cloister!
            L006C: TeleportParty(player, 0x06, 0x01, 0x59, 0x01, isForwardMove);
            L0087: return; // RETURN;
        }

        private void FnSPECDRB_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0xDA);
            L0007: PushStack(player, ax);
06EB  0008 C4 5E 06  les bx, [bp+0x6]
06EE  000B 26 FF 5F 54  call far word [es:bx+0x54]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0034;
            L0015: XCall Fn0DE6
            L0020: cx = PopStack(player);
            L0021: cx = PopStack(player);
            L0022: XCall Fn0E09
            L002D: cx = PopStack(player);
            L002E: cx = PopStack(player);
0712  002F B8 A3 0C  mov ax, 0xca3
            L0032: goto L0044;
            L0034: XCall Fn0DC4
            L003F: cx = PopStack(player);
            L0040: cx = PopStack(player);
            L0041: ShowMessage(player, String0CD1); // The locked door has a diamond-shaped keyhole.
            L004E: return; // RETURN;
        }

        private void FnTELEF_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x07, 0x01, 0x39, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnMAPB_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x55), 0x0001);
            L0017: if (JumpNotEqual) goto L004D;
            L0019: ax = HasItem(player, 0xD6);
            L0027: if (JumpEqual) goto L002F;
077C  0029 B8 FF 0C  mov ax, 0xcff
            L002C: goto L00C1;
            L002F: GiveItem(player, 0xD6);
            L003B: ShowMessage(player, String0D4D); // You find a map hastily drawn on a piece of snakeskin.
079B  0048 B8 83 0D  mov ax, 0xd83
            L004B: goto L00B4;
            L004D: GiveItem(player, 0xD6);
            L0059: GiveItem(player, 0x6B);
            L0065: GiveItem(player, 0x68);
            L0071: GiveItem(player, 0xAB);
            L007D: AddExperience(player, 0x00030D40);
            L008F: SetFlag(player, 0x02, 0x55, 0x01);
            L00A4: ShowMessage(player, String0D4D); // You find a map hastily drawn on a piece of snakeskin.
            L00B1: ShowMessage(player, String0DFD); // The Snakeskin Map must be one of the four Queen Aeowyn has sent you to find.
            L00BE: ShowMessage(player, String0DC9); // Your Ruby Lockpick mysteriously crumbles into dust.
            L00CB: RemoveItem(player, 0xDD);
            L00D7: return; // RETURN;
        }

        private void FnTEXTCLU_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0E4A); // On the floor you find a page from an old journal.
            L0010: ShowMessage(player, String0E7C); // It recounts the story of an adventurer who gained great wisdom by discovering a map piece.
            L001D: return; // RETURN;
        }

        private void FnROPEX_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x56), 0x0001);
            L0017: if (JumpNotEqual) goto L0082;
            L0019: ax = HasItem(player, 0xE0);
            L0027: if (JumpEqual) goto L0044;
            L0029: ShowMessage(player, String0ED7); // A wandering band of thieves overcomes you. They steal your lockpick.
            L0036: PushStack(player, 0xDC);
0885  003A C4 5E 06  les bx, [bp+0x6]
0888  003D 26 FF 5F 4C  call far word [es:bx+0x4c]
            L0041: goto L0104;
            L0044: ax = HasItem(player, 0xDC);
            L0052: if (JumpNotEqual) goto L0057;
            L0054: goto L0105;
            L0057: GiveItem(player, 0xE0);
            L0063: ShowMessage(player, String0F1C); // You are attacked by thieves who bind you with rope.
            L0070: ShowMessage(player, String0F50); // The leader pilfers your lockpick.
08C8  007D B8 72 0F  mov ax, 0xf72
            L0080: goto L002C;
            L0082: ax = HasItem(player, 0xDC);
            L0090: if (JumpEqual) goto L00F8;
            L0092: RemoveItem(player, 0xDC);
            L009E: AddExperience(player, 0x0000C350);
            L00AF: SetFlag(player, 0x02, 0x56, 0x01);
            L00C4: ShowMessage(player, String0F1C); // You are attacked by thieves who bind you with rope.
            L00D1: ShowMessage(player, String0F50); // The leader pilfers your lockpick.
            L00DE: ShowMessage(player, String0F72); // You eventually manage to free yourself, and you tuck the rope away.
            L00EB: PushStack(player, 0xE0);
093A  00EF C4 5E 06  les bx, [bp+0x6]
093D  00F2 26 FF 5F 48  call far word [es:bx+0x48]
            L00F6: goto L0104;
            L00F8: ShowMessage(player, String0FB6); // A wandering band of thieves ignores you since you have nothing of value.
            L0105: return; // RETURN;
        }

        private void FnTELEG_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x07, 0x01, 0xC7, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnNPCLOCKA_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0020);
            L0010: ax = HasItem(player, 0xDA);
            L001E: if (JumpEqual) goto L007A;
            L0020: GiveItem(player, 0xDC);
            L002C: ShowMessage(player, String0FFF); // A Troll Ranger drags you into the shadows.
            L0039: ShowMessage(player, String102A); // 'I assume you found the note about the Emerald Lockpick I left by the entrance.
            L0046: ShowMessage(player, String107A); // Congratulations on your success so far!
            L0053: ShowMessage(player, String10A2); // My reward for helping you is the Diamond Lockpick you possess - or used to possess, anyway.
            L0060: ShowMessage(player, String10FE); // Take this Sapphire Lockpick in exchange. Though less valuable, it has the magical property to help you see things not readily apparent to the eye.'
            L006D: PushStack(player, 0xDA);
09E3  0071 C4 5E 06  les bx, [bp+0x6]
09E6  0074 26 FF 5F 4C  call far word [es:bx+0x4c]
            L0078: goto L00A0;
            L007A: ShowMessage(player, String1192); // A Troll Ranger twirls a sparkling blue lockpick.
            L0087: ShowMessage(player, String11C3); // 'I left a note by the entrance. It concerns an Emerald Lockpick.
            L0094: ShowMessage(player, String1204); // Heed its warning well, and you will be well rewarded.'
            L00A1: return; // RETURN;
        }

        private void FnCLUEE_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String123B); // In the distance you hear the wail of a madman -
            L0010: ShowMessage(player, String126B); // 'Hither and yonder I have searched! Nowhere, nowhere could I find that lovely little map writ large upon a parchment!'
            L001D: return; // RETURN;
        }

        private void FnTELEH_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x07, 0x01, 0x1C, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELEI_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x07, 0x01, 0x97, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnNPCLOCKB_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002A);
            L0010: ax = HasItem(player, 0xDB);
            L001E: if (JumpEqual) goto L0099;
            L0020: Compare(GetFlag(player, 0x02, 0x54), 0x0001);
            L0034: if (JumpEqual) goto L004C;
            L0036: Compare(GetFlag(player, 0x02, 0x54), 0x0002);
            L004A: if (JumpNotEqual) goto L0099;
            L004C: GiveItem(player, 0xDA);
            L0058: ShowMessage(player, String12E2); // A Gremlin Cleric slaps you resoundingly on the back.
            L0065: ShowMessage(player, String1317); // 'Well done! You've found my lost Emerald Lockpick.
            L0072: ShowMessage(player, String134A); // I can't thank you enough for helping me!
            L007F: ShowMessage(player, String1373); // Please accept this Diamond Lockpick for your troubles.'
            L008C: PushStack(player, 0xDB);
0B04  0090 C4 5E 06  les bx, [bp+0x6]
0B07  0093 26 FF 5F 4C  call far word [es:bx+0x4c]
            L0097: goto L00CC;
            L0099: ShowMessage(player, String13AB); // A Gremlin Cleric is searching in the dust.
            L00A6: ShowMessage(player, String13D6); // 'I lost my beautiful Emerald Lockpick.
            L00B3: ShowMessage(player, String13FD); // If you retrieve it, I will reward you most handsomely.
            L00C0: ShowMessage(player, String1434); // Remember, however, that you must be a registered visitor to Tipekans.'
            L00CD: return; // RETURN;
        }

        private void FnRRRTNPC_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001D);
            L0010: ShowMessage(player, String147B); // An exasperated Halfling waves a piece of leather.
            L001D: ShowMessage(player, String14AD); // 'The Races! What an aptly named place it was, since only certain races can enter certain rooms.
            L002A: ShowMessage(player, String150D); // I wish I had discovered that fact sooner. But, eventually, I did find the two doors for my race.'
            L0037: return; // RETURN;
        }

        private void FnBLOCSPCL_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x54));
            L0016: if (JumpNotEqual) goto L0025;
            L0018: XCall Fn092B
            L0023: cx = PopStack(player);
            L0024: cx = PopStack(player);
            L0025: return; // RETURN;
        }

        private void FnTEXTB_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String156F); // You overhear two thieves talking about how clever Sneer, Smug and Smirk are in preventing bothersome adventurers from gaining access into the center of Tipekans.
            L0010: return; // RETURN;
        }

        private void FnNPCCLA_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001C);
            L0010: ShowMessage(player, String1611); // A Dwarf Knight walks up to you. He rubs his head.
            L001D: ShowMessage(player, String1643); // 'I'm looking for a temple to take care of this wound!
            L002A: ShowMessage(player, String1679); // My journey has taken me to a strange place. Not one wall did I see, yet I could not advance. It was pure pandemonium.'
            L0037: return; // RETURN;
        }

        private void FnFINDSTF_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x54), 0x0001);
            L0017: if (JumpNotEqual) goto L0057;
            L0019: GiveItem(player, 0xBC);
            L0025: GiveItem(player, 0x93);
            L0031: GiveItem(player, 0xB8);
            L003D: SetFlag(player, 0x02, 0x54, 0x02);
0C40  0052 B8 F0 16  mov ax, 0x16f0
            L0055: goto L005A;
            L0057: ShowMessage(player, String174E); // What used to be a hiding place for stolen loot is now empty.
            L0064: return; // RETURN;
        }

        private void FnTELEJ_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x07, 0x01, 0x7D, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnFNTA_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: HealPlayer(player, GetMaxHits(player));
            L0021: AddMana(player, 0x2710);
            L002E: ShowMessage(player, String178B); // The cascading waters of Viper Fountain heal your wounds and restore your mana.
            L003B: return; // RETURN;
        }

        private void FnGOODIEB_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String17DA); // You stumble upon a weird assortment of scavengers.
            L0010: ax = HasItem(player, 0xA6);
            L001E: if (JumpEqual) goto L0032;
0CD1  0020 B8 E8 03  mov ax, 0x3e8
            L0023: PushStack(player, ax);
            L0024: PushStack(player, 0x00);
            L0027: PushStack(player, ax);
            L0028: PushStack(player, ax);
            L0029: PushStack(player, 0x73);
0CDE  002D B8 B0 00  mov ax, 0xb0
            L0030: goto L0042;
0CE3  0032 B8 C4 09  mov ax, 0x9c4
            L0035: PushStack(player, ax);
            L0036: PushStack(player, 0x00);
            L0039: PushStack(player, ax);
            L003A: PushStack(player, ax);
            L003B: PushStack(player, 0x73);
            L003F: PushStack(player, 0xA6);
0CF4  0043 C4 5E 06  les bx, [bp+0x6]
0CF7  0046 26 FF 9F D8 00  call far word [es:bx+0xd8]
0CFC  004B 83 C4 0C  add sp, 0xc
            L004E: Compare(PartyCount(player), 0x0001);
            L0059: if (JumpNotEqual) goto L0077;
            L005B: AddEncounter(player, 0x01, 0x21);
            L006D: PushStack(player, 0x22);
0D22  0071 B8 02 00  mov ax, 0x2
            L0074: goto L0124;
            L0077: Compare(PartyCount(player), 0x0002);
            L0082: if (JumpNotEqual) goto L00C3;
            L0084: AddEncounter(player, 0x01, 0x21);
            L0096: AddEncounter(player, 0x02, 0x22);
            L00A8: AddEncounter(player, 0x03, 0x05);
            L00BA: PushStack(player, 0x18);
0D6F  00BE B8 04 00  mov ax, 0x4
            L00C1: goto L0124;
            L00C3: AddEncounter(player, 0x01, 0x21);
            L00D5: AddEncounter(player, 0x02, 0x21);
            L00E7: AddEncounter(player, 0x03, 0x04);
            L00F9: AddEncounter(player, 0x04, 0x27);
            L010B: AddEncounter(player, 0x05, 0x1E);
            L011D: AddEncounter(player, 0x06, 0x1F);
            L012F: return; // RETURN;
        }

        private void FnCLUEBALL_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x000B);
            L0010: ShowMessage(player, String180D); // You surprise a wraith who seems to be dancing.
            L001D: ShowMessage(player, String183C); // 'Oh! You startled me. I was just recalling the wondrous sounds of music that used to fill these corridors.
            L002A: ShowMessage(player, String18A7); // I was sure there was a door somewhere along here to the Ballroom.'
            L0037: return; // RETURN;
        }

        private void FnWARN_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String18EA); // A flash of steel is quickly doused as you near a shadowy alley.
            L0010: return; // RETURN;
        }

        private void FnMEDA_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x10);
            L0022: PushStack(player, 0x12);
0E53  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00B5;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0066;
            L0039: AddEncounter(player, 0x01, 0x10);
            L004B: AddEncounter(player, 0x02, 0x0F);
            L005D: PushStack(player, 0x13);
0E8E  0061 B8 03 00  mov ax, 0x3
            L0064: goto L00B5;
            L0066: AddEncounter(player, 0x01, 0x10);
            L0078: AddEncounter(player, 0x02, 0x10);
            L008A: AddEncounter(player, 0x03, 0x13);
            L009C: AddEncounter(player, 0x04, 0x23);
            L00AE: AddEncounter(player, 0x05, 0x25);
            L00C0: return; // RETURN;
        }

        private void FnMEDB_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x09);
            L0022: PushStack(player, 0x07);
0F15  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00B1;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0074;
            L0039: AddEncounter(player, 0x01, 0x07);
            L004B: AddEncounter(player, 0x02, 0x17);
            L005D: AddEncounter(player, 0x05, 0x09);
0F5E  006F B8 0B 00  mov ax, 0xb
            L0072: goto L00AD;
            L0074: AddEncounter(player, 0x01, 0x1D);
            L0086: AddEncounter(player, 0x02, 0x1D);
            L0098: AddEncounter(player, 0x04, 0x20);
            L00AA: AddEncounter(player, 0x06, 0x20);
            L00BC: return; // RETURN;
        }

        private void FnHRDA_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x1A);
            L0022: PushStack(player, 0x1C);
0FD3  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00B5;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0066;
            L0039: AddEncounter(player, 0x01, 0x1C);
            L004B: AddEncounter(player, 0x02, 0x1C);
            L005D: PushStack(player, 0x1A);
100E  0061 B8 05 00  mov ax, 0x5
            L0064: goto L00A3;
            L0066: AddEncounter(player, 0x01, 0x1C);
            L0078: AddEncounter(player, 0x02, 0x1C);
            L008A: AddEncounter(player, 0x03, 0x05);
            L009C: AddEncounter(player, 0x04, 0x05);
            L00AE: AddEncounter(player, 0x06, 0x1A);
            L00C0: return; // RETURN;
        }

        private void FnMEDC_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x0D);
            L0022: PushStack(player, 0x21);
1095  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00C7;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0078;
            L0039: AddEncounter(player, 0x01, 0x0C);
            L004B: AddEncounter(player, 0x02, 0x0D);
            L005D: AddEncounter(player, 0x03, 0x0E);
            L006F: PushStack(player, 0x0E);
10E2  0073 B8 04 00  mov ax, 0x4
            L0076: goto L00C7;
            L0078: AddEncounter(player, 0x01, 0x0C);
            L008A: AddEncounter(player, 0x02, 0x0D);
            L009C: AddEncounter(player, 0x03, 0x21);
            L00AE: AddEncounter(player, 0x05, 0x22);
            L00C0: AddEncounter(player, 0x06, 0x22);
            L00D2: return; // RETURN;
        }

        private void FnEZA_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x13);
            L0022: PushStack(player, 0x25);
1169  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00C7;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0078;
            L0039: AddEncounter(player, 0x01, 0x12);
            L004B: AddEncounter(player, 0x02, 0x10);
            L005D: AddEncounter(player, 0x03, 0x13);
            L006F: PushStack(player, 0x25);
11B6  0073 B8 04 00  mov ax, 0x4
            L0076: goto L00C7;
            L0078: AddEncounter(player, 0x01, 0x13);
            L008A: AddEncounter(player, 0x02, 0x13);
            L009C: AddEncounter(player, 0x04, 0x26);
            L00AE: AddEncounter(player, 0x05, 0x11);
            L00C0: AddEncounter(player, 0x06, 0x0F);
            L00D2: return; // RETURN;
        }

        private void FnMEDD_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x06);
            L0022: PushStack(player, 0x09);
123D  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00C7;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0078;
            L0039: AddEncounter(player, 0x01, 0x06);
            L004B: AddEncounter(player, 0x02, 0x08);
            L005D: AddEncounter(player, 0x04, 0x1C);
            L006F: PushStack(player, 0x0B);
128A  0073 B8 05 00  mov ax, 0x5
            L0076: goto L00C7;
            L0078: AddEncounter(player, 0x01, 0x1C);
            L008A: AddEncounter(player, 0x02, 0x1D);
            L009C: AddEncounter(player, 0x04, 0x08);
            L00AE: AddEncounter(player, 0x05, 0x20);
            L00C0: AddEncounter(player, 0x06, 0x20);
            L00D2: return; // RETURN;
        }

        private void FnEZB_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x1C);
            L0022: PushStack(player, 0x25);
1311  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00C7;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0078;
            L0039: AddEncounter(player, 0x01, 0x1C);
            L004B: AddEncounter(player, 0x02, 0x1C);
            L005D: AddEncounter(player, 0x03, 0x1A);
            L006F: PushStack(player, 0x25);
135E  0073 B8 04 00  mov ax, 0x4
            L0076: goto L00C7;
            L0078: AddEncounter(player, 0x01, 0x1C);
            L008A: AddEncounter(player, 0x02, 0x1C);
            L009C: AddEncounter(player, 0x03, 0x26);
            L00AE: AddEncounter(player, 0x05, 0x1A);
            L00C0: AddEncounter(player, 0x06, 0x1A);
            L00D2: return; // RETURN;
        }

        private void FnHRDB_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = 0;
            L0006: Compare(PartyCount(player), 0x0001);
            L0011: if (JumpEqual) goto L001A;
            L0013: Compare(ax, 0x0002);
            L0016: if (JumpEqual) goto L0041;
            L0018: goto L0080;
            L001A: AddEncounter(player, 0x01, 0x1B);
            L002C: AddEncounter(player, 0x02, 0x23);
            L003E: goto L00CE;
            L0041: AddEncounter(player, 0x01, 0x23);
            L0053: AddEncounter(player, 0x02, 0x24);
            L0065: AddEncounter(player, 0x05, 0x1B);
            L0077: PushStack(player, 0x1B);
143A  007B B8 06 00  mov ax, 0x6
            L007E: goto L0033;
            L0080: si = 0x0001;
            L0083: goto L0095;
            L0085: AddEncounter(player, si, 0x24);
            L0094: si = si + 1;
            L0095: Compare(si, 0x02);
            L0098: if (JumpLessOrEqual) goto L0085;
            L009A: si = 0x0003;
            L009D: goto L00AF;
            L009F: AddEncounter(player, si, 0x23);
            L00AE: si = si + 1;
            L00AF: Compare(si, 0x04);
            L00B2: if (JumpLessOrEqual) goto L009F;
            L00B4: si = 0x0005;
            L00B7: goto L00C9;
            L00B9: AddEncounter(player, si, 0x1B);
            L00C8: si = si + 1;
            L00C9: Compare(si, 0x06);
            L00CC: if (JumpLessOrEqual) goto L00B9;
            L00CE: return; // RETURN (restoring si);
        }

        private void FnBRDGNOTE_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String192A); // An unsturdy bridge leads eastward towards an ancient door covered in lichens. The fragile bridge creaks warningly as you approach.
            L0010: return; // RETURN;
        }

        private void Fn_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: return; // RETURN;
            // Extra data: 55 8B EC 33 C0 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 55 8B EC B8 01 00 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 55 8B EC C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 B8 01 00 50 C4 5E 06 26 FF 5F 30 83 C4 06 5D CB 
        }

    }
}
