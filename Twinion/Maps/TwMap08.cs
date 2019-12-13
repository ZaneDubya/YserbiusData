#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Twinion.Maps {
    class TwMap08 : AMapScripted {
        protected override int MapIndex => 8;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public TwMap08() {
            MapEvent01 = FnFTNA_01;
            MapEvent02 = FnTELEA_02;
            MapEvent03 = FnLAVA_03;
            MapEvent04 = FnSECA_04;
            MapEvent05 = FnTELEB_05;
            MapEvent06 = FnPIT_06;
            MapEvent07 = FnROPE_07;
            MapEvent08 = FnSECB_08;
            MapEvent09 = FnCLUEA_09;
            MapEvent0A = FnTELEC_0A;
            MapEvent0B = FnTELED_0B;
            MapEvent0C = FnTEXTCLU_0C;
            MapEvent0D = FnCLUEB_0D;
            MapEvent0E = FnGOODIEA_0E;
            MapEvent0F = FnKEYA_0F;
            MapEvent10 = FnCLUEC_10;
            MapEvent12 = FnTELEE_12;
            MapEvent14 = FnCLUEE_14;
            MapEvent15 = FnKEYB_15;
            MapEvent16 = FnGOLD_16;
            MapEvent17 = FnKEYC_17;
            MapEvent18 = FnSECD_18;
            MapEvent1A = FnDEATHDR_1A;
            MapEvent1B = FnSNEER_1B;
            MapEvent1C = FnCLUEF_1C;
            MapEvent1D = FnKEYD_1D;
            MapEvent1E = FnGOODIEB_1E;
            MapEvent20 = FnSECKNT_20;
            MapEvent21 = FnSNRDOOR_21;
            MapEvent22 = FnCLUEG_22;
            MapEvent23 = FnPITA_23;
            MapEvent24 = FnPITB_24;
            MapEvent25 = FnCLUEH_25;
            MapEvent26 = FnCLUEI_26;
            MapEvent27 = FnGHOSTENC_27;
            MapEvent29 = FnKEYE_29;
            MapEvent2A = FnSECWIZ_2A;
            MapEvent2B = FnSNICKER_2B;
            MapEvent2C = FnTELEF_2C;
            MapEvent2F = FnTELEG_2F;
            MapEvent32 = FnGOLDDOWN_32;
            MapEvent34 = FnFTNB_34;
            MapEvent37 = FnCLUEL_37;
            MapEvent38 = FnFTNC_38;
            MapEvent39 = FnKEYOFC_39;
            MapEvent3B = FnFTND_3B;
            MapEvent3C = FnTELEH_3C;
            MapEvent3D = FnFTNE_3D;
            MapEvent3E = FnGOODIEC_3E;
            MapEvent3F = FnTEXTD_3F;
            MapEvent40 = FnTELEI_40;
            MapEvent41 = FnFRNTDOOR_41;
            MapEvent44 = FnCLUEM_44;
            MapEvent47 = FnMEDA_47;
            MapEvent48 = FnMEDB_48;
            MapEvent49 = FnHRDB_49;
            MapEvent4A = FnEZA_4A;
            MapEvent4B = FnMEDC_4B;
            MapEvent4C = FnHRDC_4C;
            MapEvent4D = Fn_4D;
        }
        
        // === Strings ================================================
        private const string String03FC = "The chill waters of Snowy Fountain are refreshing.";
        private const string String042F = "Your rope falls into the water.";
        private const string String044F = "The chill waters of Snowy Fountain enrich you with the Fencing skill.";
        private const string String0495 = "The chill waters of Snowy Fountain enrich you with the Clubs and Axes skill.";
        private const string String04E2 = "You must prove you have completed the Rope Quest to gain your skill.";
        private const string String0527 = "You step into a stream of lava.";
        private const string String0547 = "You discover a hidden door.";
        private const string String0563 = "You lose your footing and tumble down a slope, landing safely in the Infirmary.";
        private const string String05B3 = "You step into a pit and fall to your death.";
        private const string String05DF = "By throwing the Rope over a protruding rock, you manage to swing across the pit.";
        private const string String0630 = "Nothing extraordinary happens.";
        private const string String064F = "A pit blocks your passage to the west.";
        private const string String0676 = "You notice a protruding rock above the pit.";
        private const string String06A2 = "You successfully unlock the door.";
        private const string String06C4 = "You detect a hidden door, but it is locked.";
        private const string String06F0 = "You see a warning sign on the cliff.";
        private const string String0715 = "'DANGER! Loose rocks. Proceed at your own risk.'";
        private const string String0746 = "The door to the Armory has seen many a traveler pass, each in search of the secret rooms inside.";
        private const string String07A7 = "The gateway leads to the Statuary.";
        private const string String07CA = "A few walls in this area seem to have been altered by some construction.";
        private const string String0813 = "To the Cellar";
        private const string String0821 = "As you search the cave, you are startled by bats.";
        private const string String0853 = "You enter a cave crammed with hostile monsters.";
        private const string String0883 = "You inadvertantly join a battle over a key.";
        private const string String08AF = "As you turn to leave, Snicker slips you a note saying - ";
        private const string String08E8 = "'A dark and dangerous place hides your key to rewards.'";
        private const string String0920 = "Path to Tipekans' Bridge.";
        private const string String093A = "On the the plaque you see OT.";
        private const string String0958 = "In a corner of this otherwise empty room you find a key.";
        private const string String0991 = "The key bears the initials M.A.Z.E.";
        private const string String09B5 = "You find 5,000 gold pieces behind a wooden vat, which was used to store the Vineyard grapes.";
        private const string String0A12 = "You see a reflection in the light and pick up items an unlucky adventurer must have dropped.";
        private const string String0A6F = "The items are useful, but are not particularly important to your quest.";
        private const string String0AB7 = "The room is empty except for some wooden vats.";
        private const string String0AE6 = "You find a key which may open seemingly impassable doors in your race to finish Queen Aeowyn's Map Quest.";
        private const string String0B50 = "Your Guildmaster left you a special key that will give you access to magical armor.";
        private const string String0BA4 = "A hidden door is revealed.";
        private const string String0BBF = "Sneer's guard hears you attempting to get in the back door and kills you.";
        private const string String0C09 = "You see the back door to Sneer's Pawn Shop.";
        private const string String0C35 = "Sneer looks you over and notices your Ruby Lockpick. He motions you to continue to the north.";
        private const string String0C93 = "On the plaque you see LALF.";
        private const string String0CAF = "The bard has already sung his tale.";
        private const string String0CD3 = "You meet a bard who is grateful for your attentiveness as he sings his tale. He expresses his gratitude with a gift of a special key.";
        private const string String0D59 = "'Music will open new doors for you,' the bard says.";
        private const string String0D8D = "You disturb the spirits of long dead vintners.";
        private const string String0DBC = "A sign on the door says KNIGHTS ONLY.";
        private const string String0DE2 = "Sneer's is now open for business.";
        private const string String0E04 = "The entrance to Sneer's Pawn Shop is locked.";
        private const string String0E31 = "On the plaque you see SRAHMC.";
        private const string String0E4F = "You plunge into the pit and find yourself at the bottom of a secret shaft to the Vault.";
        private const string String0EA7 = "You congratulate yourself on your choice. But your confidence turns to alarm as you feel yourself approaching the Fringe of Madness.";
        private const string String0F2C = "You meet an old seafarer.";
        private const string String0F46 = "'Beware of Lake Despair, matey. Many a foolhardy adventurer has sunk into its treacherous depths.";
        private const string String0FA8 = "A special jacket helped me cross the lake once, but I lost it somewhere in the dungeon. Pity.'";
        private const string String1007 = "You meet a friendly but puzzled ranger, 'This MUST be Clueless! Hmmm...I suspect a wizard has tampered with the clues in this area.' He shows you a parchment on which he has written SPAS.";
        private const string String10C3 = "An apparition appears before you, 'I almost met my death while trying to squeeze past my stony friend who was concealing a shortcut to this place.";
        private const string String1156 = "However, my statuesque form encountered its demise elsewhere.'";
        private const string String1195 = "A sign on the door reads WIZARDS ONLY.";
        private const string String11BC = "You meet a thief named Snicker, 'Three brothers have I, and courtesy is very important to all of them. One will show you the true path to what you seek. But all are fond of red gems.";
        private const string String1273 = "In exchange for this information, you find your purse a little lighter.'";
        private const string String12BC = "'Ah, my informants said you might return! You must learn to guard your pockets better. Since I've relieved you of your gold again, take this ring. It's magic will lead you to paths you might have missed without its magic.'";
        private const string String139B = "'Greetings! I have pil...acquired this from an adventurer who bragged about the protective properties of the crown. I've taken your gold, you might as well have it. I'm sure I'll happen upon another.'";
        private const string String1464 = "Snicker is busy helping himself to the goods of others.";
        private const string String149C = "You can hear the rushing waters of Lake Despair.";
        private const string String14CD = "A sign on the portal says, 'Entrance to the Gallery'.";
        private const string String1503 = "You lose your footing on a loose rock and your bag of gold falls to the ground.";
        private const string String1553 = "You manage to gather all but 1000 pieces, which fall through cracks in the floor.";
        private const string String15A5 = "The dark waters of Sunset Fountain poison you when you attempt to refresh yourself.";
        private const string String15F9 = "On the plaque you see EPRY.";
        private const string String1615 = "The waters of Windy Fountain have no effect.";
        private const string String1642 = "The Key of C falls into the fountain.";
        private const string String1668 = "The waters of Windy Fountain endow you with the Martial Arts skill.";
        private const string String16AC = "The waters of Windy Fountain give you the powers to intimidate your enemies.";
        private const string String16F9 = "The waters of Windy Fountain endow you with the Bard skill.";
        private const string String1735 = "The waters of Windy Fountain aid in your proficiency with a bow.";
        private const string String1776 = "A gift from a bard makes these waters magical.";
        private const string String17A5 = "The Key of C unlocks this Ballroom door.";
        private const string String17CE = "You see a musical note on the locked door.";
        private const string String17F9 = "The fresh waters of Sunrise Fountain restore your mana.";
        private const string String1831 = "Enter the Rat Race.";
        private const string String1845 = "The haze surrounding Misty Fountain has no further effect.";
        private const string String1880 = "The Front Door Key disappears.";
        private const string String189F = "The haze surrounding Misty Fountain empowers you with the True Seeing spell.";
        private const string String18EC = "The haze surrounding Misty Fountain empowers you with the Lightning spell.";
        private const string String1937 = "A door key will channel the powers in the haze.";
        private const string String1967 = "Where music once played, battle sounds now rage.";
        private const string String1998 = "This is the Ingress to the Night Elves' Domain. The southern gateway will take you back to the Main Entrance.";
        private const string String1A06 = "The Front Door Key opens the door.";
        private const string String1A29 = "The front door is locked.";
        private const string String1A43 = "You find a sheet of music with a song written in the key of C. The lyrics tell of two areas where race is the key to discovering treasure.";
        private const string String1ACE = "The key is made of bone. The grasp is shaped like a skull and the shaft like two crossed, bony arms.";
        private const string String1B33 = "The room is empty.";
        
        // === Functions ================================================
        private void FnFTNA_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0009  0003 FF 76 08  push word [bp+0x8]
000C  0006 FF 76 06  push word [bp+0x6]
000F  0009 0E     push cs
0010  000A E8 FA 19  call 0x1a07
            L000D: // NOP
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
            L0010: Compare(GetFlag(player, 0x02, 0x3D), 0x0001);
            L0024: if (JumpNotEqual) goto L0045;
            L0026: RemoveItem(player, 0xE0);
            L0032: ShowMessage(player, String03FC); // The chill waters of Snowy Fountain are refreshing.
0045  003F B8 2F 04  mov ax, 0x42f
            L0042: goto L0119;
            L0045: ax = HasItem(player, 0xE0);
            L0053: if (JumpNotEqual) goto L0058;
            L0055: goto L0116;
            L0058: RemoveItem(player, 0xE0);
            L0064: ShowMessage(player, String042F); // Your rope falls into the water.
            L0071: SetFlag(player, 0x02, 0x3D, 0x01);
            L0086: RefreshCompareFlags(GetGuild(player));
            L008F: if (JumpEqual) goto L00B5;
            L0091: Compare(GetGuild(player), 0x0002);
            L009B: if (JumpEqual) goto L00B5;
            L009D: Compare(GetGuild(player), 0x0003);
            L00A7: if (JumpEqual) goto L00B5;
            L00A9: Compare(GetGuild(player), 0x0005);
            L00B3: if (JumpNotEqual) goto L00DB;
            L00B5: RefreshCompareFlags(GetSkillLevel(player, 0x05));
            L00C3: if (JumpNotEqual) goto L00D6;
            L00C5: SetSkillLevel(player, 0x05, 0x01);
00DC  00D6 B8 4F 04  mov ax, 0x44f
            L00D9: goto L0119;
            L00DB: Compare(GetGuild(player), 0x0004);
            L00E5: if (JumpEqual) goto L00F3;
            L00E7: Compare(GetGuild(player), 0x0001);
            L00F1: if (JumpNotEqual) goto L0123;
            L00F3: RefreshCompareFlags(GetSkillLevel(player, 0x01));
            L0101: if (JumpNotEqual) goto L0111;
            L0103: PushStack(player, 0x01);
            L0107: PushStack(player, ax);
010E  0108 C4 5E 06  les bx, [bp+0x6]
0111  010B 26 FF 5F 60  call far word [es:bx+0x60]
            L010F: cx = PopStack(player);
            L0110: cx = PopStack(player);
0117  0111 B8 95 04  mov ax, 0x495
            L0114: goto L0119;
            L0116: ShowMessage(player, String04E2); // You must prove you have completed the Rope Quest to gain your skill.
            L0123: return; // RETURN;
        }

        private void FnTELEA_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x06, 0x01, 0x59, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnLAVA_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0527); // You step into a stream of lava.
015B  0010 FF 76 08  push word [bp+0x8]
015E  0013 FF 76 06  push word [bp+0x6]
0161  0016 0E     push cs
0162  0017 E8 70 18  call 0x188a
            L001A: // NOP
            L001B: cx = PopStack(player);
            L001C: cx = PopStack(player);
            L001D: return; // RETURN;
        }

        private void FnSECA_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x0005);
            L0012: if (JumpNotBelow) goto L006C;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L006C;
            L0024: PushStack(player, 0x68);
            L0028: PushStack(player, ax);
0193  0029 C4 5E 06  les bx, [bp+0x6]
0196  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L006C;
            L0036: PushStack(player, 0x6E);
            L003A: PushStack(player, ax);
01A5  003B C4 5E 06  les bx, [bp+0x6]
01A8  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L006C;
            L0048: PushStack(player, 0x90);
            L004C: PushStack(player, ax);
01B7  004D C4 5E 06  les bx, [bp+0x6]
01BA  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L006C;
            L005A: PushStack(player, 0xA4);
            L005E: PushStack(player, ax);
01C9  005F C4 5E 06  les bx, [bp+0x6]
01CC  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpEqual) goto L0093;
            L006C: ShowMessage(player, String0547); // You discover a hidden door.
01E3  0079 FF 76 08  push word [bp+0x8]
01E6  007C FF 76 06  push word [bp+0x6]
01E9  007F 0E     push cs
01EA  0080 E8 A2 17  call 0x1825
            L0083: // NOP
            L0084: cx = PopStack(player);
            L0085: cx = PopStack(player);
01F0  0086 FF 76 08  push word [bp+0x8]
01F3  0089 FF 76 06  push word [bp+0x6]
01F6  008C 0E     push cs
01F7  008D E8 B8 17  call 0x1848
            L0090: // NOP
            L0091: goto L009E;
01FD  0093 FF 76 08  push word [bp+0x8]
0200  0096 FF 76 06  push word [bp+0x6]
0203  0099 0E     push cs
0204  009A E8 E4 17  call 0x1881
            L009D: // NOP
            L009E: cx = PopStack(player);
            L009F: cx = PopStack(player);
            L00A0: return; // RETURN;
        }

        private void FnTELEB_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0563); // You lose your footing and tumble down a slope, landing safely in the Infirmary.
            L0010: TeleportParty(player, 0x05, 0x01, 0x3D, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void FnPIT_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String05B3); // You step into a pit and fall to your death.
0248  0010 FF 76 08  push word [bp+0x8]
024B  0013 FF 76 06  push word [bp+0x6]
024E  0016 0E     push cs
024F  0017 E8 83 17  call 0x179d
            L001A: // NOP
            L001B: cx = PopStack(player);
            L001C: cx = PopStack(player);
            L001D: return; // RETURN;
        }

        private void FnROPE_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: ax = HasItem(player, 0xE0);
            L0013: if (JumpEqual) goto L0066;
            L0015: RefreshCompareFlags(GetFacing(player));
            L001E: if (JumpEqual) goto L0023;
            L0020: goto L00C9;
            L0023: ax = GetCurrentTile(player) + 0xFFFE;
0284  002D 89 46 FE  mov [bp-0x2], ax
0287  0030 FF 76 08  push word [bp+0x8]
028A  0033 FF 76 06  push word [bp+0x6]
028D  0036 0E     push cs
028E  0037 E8 5A 17  call 0x1794
            L003A: // NOP
            L003B: cx = PopStack(player);
            L003C: cx = PopStack(player);
            L003D: ShowMessage(player, String05DF); // By throwing the Rope over a protruding rock, you manage to swing across the pit.
            L004A: PushStack(player, 0x02);
02A5  004E FF 76 FE  push word [bp-0x2]
            L0051: PushStack(player, 0x01);
            L0055: PushStack(player, 0x04);
02B0  0059 C4 5E 06  les bx, [bp+0x6]
02B3  005C 26 FF 9F BC 00  call far word [es:bx+0xbc]
02B8  0061 83 C4 08  add sp, 0x8
            L0064: goto L00C9;
            L0066: ax = HasUsedItem(player, 0x01, 0xDF);
            L0079: if (JumpNotEqual) goto L0090;
            L007B: ax = HasUsedItem(player, 0xE1, 0xFE);
            L008E: if (JumpEqual) goto L00A2;
02E7  0090 FF 76 08  push word [bp+0x8]
02EA  0093 FF 76 06  push word [bp+0x6]
02ED  0096 0E     push cs
02EE  0097 E8 C1 16  call 0x175b
            L009A: // NOP
            L009B: cx = PopStack(player);
            L009C: cx = PopStack(player);
02F4  009D B8 30 06  mov ax, 0x630
            L00A0: goto L00BF;
02F9  00A2 FF 76 08  push word [bp+0x8]
02FC  00A5 FF 76 06  push word [bp+0x6]
02FF  00A8 0E     push cs
0300  00A9 E8 AF 16  call 0x175b
            L00AC: // NOP
            L00AD: cx = PopStack(player);
            L00AE: cx = PopStack(player);
            L00AF: ShowMessage(player, String064F); // A pit blocks your passage to the west.
            L00BC: ShowMessage(player, String0676); // You notice a protruding rock above the pit.
            L00C9: // restore stack ptr: sp = bp;
            L00CB: return; // RETURN;
        }

        private void FnSECB_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x0005);
            L0012: if (JumpNotBelow) goto L0083;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L0083;
            L0024: PushStack(player, 0x68);
            L0028: PushStack(player, ax);
034D  0029 C4 5E 06  les bx, [bp+0x6]
0350  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L0083;
            L0036: PushStack(player, 0x6E);
            L003A: PushStack(player, ax);
035F  003B C4 5E 06  les bx, [bp+0x6]
0362  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L0083;
            L0048: PushStack(player, 0x90);
            L004C: PushStack(player, ax);
0371  004D C4 5E 06  les bx, [bp+0x6]
0374  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L0083;
            L005A: PushStack(player, 0xA4);
            L005E: PushStack(player, ax);
0383  005F C4 5E 06  les bx, [bp+0x6]
0386  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpNotEqual) goto L0083;
            L006C: ax = IsFlagOn(player, 0x00, 0x06);
            L007E: if (JumpNotEqual) goto L0083;
            L0080: goto L011F;
            L0083: SetFlag(player, 0x00, 0x06, 0x01);
            L0097: ax = HasUsedItem(player, 0xBF, 0xC0);
            L00AA: if (JumpNotEqual) goto L00CF;
            L00AC: PushStack(player, 0x6F);
            L00B0: PushStack(player, ax);
03D5  00B1 C4 5E 06  les bx, [bp+0x6]
03D8  00B4 26 FF 5F 54  call far word [es:bx+0x54]
            L00B8: cx = PopStack(player);
            L00B9: cx = PopStack(player);
            L00BA: RefreshCompareFlags(ax);
            L00BC: if (JumpNotEqual) goto L00CF;
            L00BE: Compare(HasUsedSkill(player, 0x0E), 0x0006);
            L00CD: if (JumpBelow) goto L00F6;
            L00CF: ShowMessage(player, String06A2); // You successfully unlock the door.
0400  00DC FF 76 08  push word [bp+0x8]
0403  00DF FF 76 06  push word [bp+0x6]
0406  00E2 0E     push cs
0407  00E3 E8 85 15  call 0x166b
            L00E6: // NOP
            L00E7: cx = PopStack(player);
            L00E8: cx = PopStack(player);
040D  00E9 FF 76 08  push word [bp+0x8]
0410  00EC FF 76 06  push word [bp+0x6]
0413  00EF 0E     push cs
0414  00F0 E8 9B 15  call 0x168e
            L00F3: // NOP
            L00F4: goto L012A;
041A  00F6 FF 76 08  push word [bp+0x8]
041D  00F9 FF 76 06  push word [bp+0x6]
0420  00FC 0E     push cs
0421  00FD E8 C7 15  call 0x16c7
            L0100: // NOP
            L0101: cx = PopStack(player);
            L0102: cx = PopStack(player);
0427  0103 FF 76 08  push word [bp+0x8]
042A  0106 FF 76 06  push word [bp+0x6]
042D  0109 0E     push cs
042E  010A E8 5E 15  call 0x166b
            L010D: // NOP
            L010E: cx = PopStack(player);
            L010F: cx = PopStack(player);
            L0110: ShowMessage(player, String06C4); // You detect a hidden door, but it is locked.
            L011D: goto L012C;
0443  011F FF 76 08  push word [bp+0x8]
0446  0122 FF 76 06  push word [bp+0x6]
0449  0125 0E     push cs
044A  0126 E8 9E 15  call 0x16c7
            L0129: // NOP
            L012A: cx = PopStack(player);
            L012B: cx = PopStack(player);
            L012C: return; // RETURN;
        }

        private void FnCLUEA_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String06F0); // You see a warning sign on the cliff.
            L0010: ShowMessage(player, String0715); // 'DANGER! Loose rocks. Proceed at your own risk.'
            L001D: return; // RETURN;
        }

        private void FnTELEC_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0746); // The door to the Armory has seen many a traveler pass, each in search of the secret rooms inside.
            L0010: TeleportParty(player, 0x04, 0x03, 0x40, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnTELED_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String07A7); // The gateway leads to the Statuary.
            L0010: TeleportParty(player, 0x05, 0x01, 0xEE, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void FnTEXTCLU_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String07CA); // A few walls in this area seem to have been altered by some construction.
            L0010: return; // RETURN;
        }

        private void FnCLUEB_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x06, 0x01, 0x48, 0x03, isForwardMove);
            L001E: ShowMessage(player, String0813); // To the Cellar
            L002B: return; // RETURN;
        }

        private void FnGOODIEA_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0821); // As you search the cave, you are startled by bats.
            L0010: ax = HasItem(player, 0x99);
            L001E: if (JumpEqual) goto L0035;
0529  0020 B8 E8 03  mov ax, 0x3e8
            L0023: PushStack(player, ax);
            L0024: PushStack(player, 0x00);
            L0027: PushStack(player, ax);
            L0028: PushStack(player, 0x9C);
            L002C: PushStack(player, 0x9D);
0539  0030 B8 8C 00  mov ax, 0x8c
            L0033: goto L0048;
053E  0035 B8 DC 05  mov ax, 0x5dc
            L0038: PushStack(player, ax);
            L0039: PushStack(player, 0x00);
            L003C: PushStack(player, ax);
            L003D: PushStack(player, 0xB2);
            L0041: PushStack(player, 0xB0);
            L0045: PushStack(player, 0x99);
0552  0049 C4 5E 06  les bx, [bp+0x6]
0555  004C 26 FF 9F D8 00  call far word [es:bx+0xd8]
055A  0051 83 C4 0C  add sp, 0xc
            L0054: Compare(PartyCount(player), 0x0001);
            L005F: if (JumpEqual) goto L006E;
            L0061: Compare(PartyCount(player), 0x0002);
            L006C: if (JumpNotEqual) goto L009B;
            L006E: AddEncounter(player, 0x01, 0x0B);
            L0080: AddEncounter(player, 0x02, 0x0B);
            L0092: PushStack(player, 0x0C);
059F  0096 B8 05 00  mov ax, 0x5
            L0099: goto L00D8;
            L009B: AddEncounter(player, 0x01, 0x0B);
            L00AD: AddEncounter(player, 0x02, 0x0C);
            L00BF: AddEncounter(player, 0x03, 0x20);
            L00D1: AddEncounter(player, 0x06, 0x21);
            L00E3: return; // RETURN;
        }

        private void FnKEYA_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xDE);
            L0011: if (JumpEqual) goto L0034;
0601  0013 B8 E8 03  mov ax, 0x3e8
            L0016: PushStack(player, ax);
            L0017: PushStack(player, 0x00);
            L001A: PushStack(player, ax);
            L001B: PushStack(player, ax);
            L001C: PushStack(player, 0xB6);
            L0020: PushStack(player, 0x8A);
0612  0024 C4 5E 06  les bx, [bp+0x6]
0615  0027 26 FF 9F D8 00  call far word [es:bx+0xd8]
061A  002C 83 C4 0C  add sp, 0xc
061D  002F B8 53 08  mov ax, 0x853
            L0032: goto L0056;
0622  0034 B8 B8 0B  mov ax, 0xbb8
            L0037: PushStack(player, ax);
            L0038: PushStack(player, 0x00);
            L003B: PushStack(player, ax);
            L003C: PushStack(player, 0xB6);
            L0040: PushStack(player, 0xA3);
            L0044: PushStack(player, 0xDE);
0636  0048 C4 5E 06  les bx, [bp+0x6]
0639  004B 26 FF 9F D8 00  call far word [es:bx+0xd8]
063E  0050 83 C4 0C  add sp, 0xc
            L0053: ShowMessage(player, String0883); // You inadvertantly join a battle over a key.
            L0060: Compare(PartyCount(player), 0x0001);
            L006B: if (JumpNotEqual) goto L0089;
            L006D: AddEncounter(player, 0x01, 0x28);
            L007F: PushStack(player, 0x16);
0671  0083 B8 02 00  mov ax, 0x2
            L0086: goto L0136;
            L0089: Compare(PartyCount(player), 0x0002);
            L0094: if (JumpNotEqual) goto L00D5;
            L0096: AddEncounter(player, 0x01, 0x28);
            L00A8: AddEncounter(player, 0x02, 0x28);
            L00BA: AddEncounter(player, 0x03, 0x16);
            L00CC: PushStack(player, 0x16);
06BE  00D0 B8 04 00  mov ax, 0x4
            L00D3: goto L0136;
            L00D5: AddEncounter(player, 0x01, 0x28);
            L00E7: AddEncounter(player, 0x02, 0x28);
            L00F9: AddEncounter(player, 0x03, 0x26);
            L010B: AddEncounter(player, 0x04, 0x26);
            L011D: AddEncounter(player, 0x05, 0x16);
            L012F: AddEncounter(player, 0x06, 0x16);
            L0141: return; // RETURN;
        }

        private void FnCLUEC_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0003);
            L000D: if (JumpNotEqual) goto L0029;
            L000F: ShowMessage(player, String08AF); // As you turn to leave, Snicker slips you a note saying - 
            L001C: ShowMessage(player, String08E8); // 'A dark and dangerous place hides your key to rewards.'
            L0029: return; // RETURN;
        }

        private void FnTELEE_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0920); // Path to Tipekans' Bridge.
            L0010: TeleportParty(player, 0x07, 0x01, 0xA1, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnCLUEE_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String093A); // On the the plaque you see OT.
            L0010: return; // RETURN;
        }

        private void FnKEYB_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xD2);
            L0011: if (JumpEqual) goto L0022;
07B8  0013 FF 76 08  push word [bp+0x8]
07BB  0016 FF 76 06  push word [bp+0x6]
07BE  0019 0E     push cs
07BF  001A E8 BB 11  call 0x11d8
            L001D: // NOP
            L001E: cx = PopStack(player);
            L001F: cx = PopStack(player);
            L0020: goto L0048;
            L0022: GiveItem(player, 0xD2);
            L002E: ShowMessage(player, String0958); // In a corner of this otherwise empty room you find a key.
            L003B: ShowMessage(player, String0991); // The key bears the initials M.A.Z.E.
            L0048: return; // RETURN;
        }

        private void FnGOLD_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x3E));
            L0016: if (JumpNotEqual) goto L0043;
            L0018: ModifyGold(player, 0x1388);
            L0029: SetFlag(player, 0x02, 0x3E, 0x01);
082D  003E B8 B5 09  mov ax, 0x9b5
            L0041: goto L00B1;
            L0043: Compare(GetFlag(player, 0x02, 0x3E), 0x0001);
            L0057: if (JumpNotEqual) goto L00AE;
            L0059: Compare(GetFlag(player, 0x02, 0x42), 0x0001);
            L006D: if (JumpNotEqual) goto L00AE;
            L006F: SetFlag(player, 0x02, 0x3E, 0x02);
            L0084: GiveItem(player, 0x6C);
            L0090: GiveItem(player, 0x96);
            L009C: ShowMessage(player, String0A12); // You see a reflection in the light and pick up items an unlucky adventurer must have dropped.
0898  00A9 B8 6F 0A  mov ax, 0xa6f
            L00AC: goto L00B1;
            L00AE: ShowMessage(player, String0AB7); // The room is empty except for some wooden vats.
            L00BB: return; // RETURN;
        }

        private void FnKEYC_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0001);
            L000D: if (JumpNotEqual) goto L006E;
            L000F: ax = HasItem(player, 0xD0);
            L001D: if (JumpEqual) goto L0021;
            L001F: goto L006E;
            L0021: Compare(GetFlag(player, 0x02, 0x45), 0x0001);
            L0035: if (JumpNotEqual) goto L005D;
            L0037: GiveItem(player, 0xD0);
            L0043: ShowMessage(player, String0AE6); // You find a key which may open seemingly impassable doors in your race to finish Queen Aeowyn's Map Quest.
08FC  0050 FF 76 08  push word [bp+0x8]
08FF  0053 FF 76 06  push word [bp+0x6]
0902  0056 0E     push cs
0903  0057 E8 65 10  call 0x10bf
            L005A: // NOP
            L005B: goto L0079;
            L005D: GiveItem(player, 0xD0);
0915  0069 B8 50 0B  mov ax, 0xb50
            L006C: goto L0046;
091A  006E FF 76 08  push word [bp+0x8]
091D  0071 FF 76 06  push word [bp+0x6]
0920  0074 0E     push cs
0921  0075 E8 59 10  call 0x10d1
            L0078: // NOP
            L0079: cx = PopStack(player);
            L007A: cx = PopStack(player);
            L007B: return; // RETURN;
        }

        private void FnSECD_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x0005);
            L0012: if (JumpNotBelow) goto L006C;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L006C;
            L0024: PushStack(player, 0x68);
            L0028: PushStack(player, ax);
0952  0029 C4 5E 06  les bx, [bp+0x6]
0955  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L006C;
            L0036: PushStack(player, 0x6E);
            L003A: PushStack(player, ax);
0964  003B C4 5E 06  les bx, [bp+0x6]
0967  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L006C;
            L0048: PushStack(player, 0x90);
            L004C: PushStack(player, ax);
0976  004D C4 5E 06  les bx, [bp+0x6]
0979  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L006C;
            L005A: PushStack(player, 0xA4);
            L005E: PushStack(player, ax);
0988  005F C4 5E 06  les bx, [bp+0x6]
098B  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpEqual) goto L0093;
            L006C: ShowMessage(player, String0BA4); // A hidden door is revealed.
09A2  0079 FF 76 08  push word [bp+0x8]
09A5  007C FF 76 06  push word [bp+0x6]
09A8  007F 0E     push cs
09A9  0080 E8 E3 0F  call 0x1066
            L0083: // NOP
            L0084: cx = PopStack(player);
            L0085: cx = PopStack(player);
09AF  0086 FF 76 08  push word [bp+0x8]
09B2  0089 FF 76 06  push word [bp+0x6]
09B5  008C 0E     push cs
09B6  008D E8 F9 0F  call 0x1089
            L0090: // NOP
            L0091: goto L009E;
09BC  0093 FF 76 08  push word [bp+0x8]
09BF  0096 FF 76 06  push word [bp+0x6]
09C2  0099 0E     push cs
09C3  009A E8 25 10  call 0x10c2
            L009D: // NOP
            L009E: cx = PopStack(player);
            L009F: cx = PopStack(player);
            L00A0: return; // RETURN;
        }

        private void FnDEATHDR_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0xDD);
            L0007: PushStack(player, ax);
09D8  0008 C4 5E 06  les bx, [bp+0x6]
09DB  000B 26 FF 5F 54  call far word [es:bx+0x54]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L002F;
            L0015: ShowMessage(player, String0BBF); // Sneer's guard hears you attempting to get in the back door and kills you.
09F2  0022 FF 76 08  push word [bp+0x8]
09F5  0025 FF 76 06  push word [bp+0x6]
09F8  0028 0E     push cs
09F9  0029 E8 D9 0F  call 0x1005
            L002C: // NOP
            L002D: goto L0047;
            L002F: ShowMessage(player, String0C09); // You see the back door to Sneer's Pawn Shop.
0A0C  003C FF 76 08  push word [bp+0x8]
0A0F  003F FF 76 06  push word [bp+0x6]
0A12  0042 0E     push cs
0A13  0043 E8 D5 0F  call 0x101b
            L0046: // NOP
            L0047: cx = PopStack(player);
            L0048: cx = PopStack(player);
            L0049: return; // RETURN;
        }

        private void FnSNEER_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0025);
            L0010: ShowMessage(player, String0C35); // Sneer looks you over and notices your Ruby Lockpick. He motions you to continue to the north.
            L001D: return; // RETURN;
        }

        private void FnCLUEF_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0C93); // On the plaque you see LALF.
            L0010: return; // RETURN;
        }

        private void FnKEYD_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xDF);
            L0011: if (JumpEqual) goto L0018;
0A5F  0013 B8 AF 0C  mov ax, 0xcaf
            L0016: goto L0041;
            L0018: ShowPortrait(player, 0x0027);
            L0025: GiveItem(player, 0xDF);
            L0031: ShowMessage(player, String0CD3); // You meet a bard who is grateful for your attentiveness as he sings his tale. He expresses his gratitude with a gift of a special key.
            L003E: ShowMessage(player, String0D59); // 'Music will open new doors for you,' the bard says.
            L004B: return; // RETURN;
        }

        private void FnGOODIEB_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0D8D); // You disturb the spirits of long dead vintners.
            L0010: ax = HasItem(player, 0xAE);
            L001E: if (JumpEqual) goto L0032;
0AB9  0020 B8 E8 03  mov ax, 0x3e8
            L0023: PushStack(player, ax);
            L0024: PushStack(player, 0x00);
            L0027: PushStack(player, ax);
            L0028: PushStack(player, ax);
            L0029: PushStack(player, 0xA1);
0AC6  002D B8 9F 00  mov ax, 0x9f
            L0030: goto L0045;
0ACB  0032 B8 D0 07  mov ax, 0x7d0
            L0035: PushStack(player, ax);
            L0036: PushStack(player, 0x00);
            L0039: PushStack(player, ax);
            L003A: PushStack(player, 0xC0);
            L003E: PushStack(player, 0xAE);
            L0042: PushStack(player, 0xA0);
0ADF  0046 C4 5E 06  les bx, [bp+0x6]
0AE2  0049 26 FF 9F D8 00  call far word [es:bx+0xd8]
0AE7  004E 83 C4 0C  add sp, 0xc
            L0051: Compare(PartyCount(player), 0x0001);
            L005C: if (JumpNotEqual) goto L0077;
            L005E: PushStack(player, 0x01);
            L0062: PushStack(player, ax);
0AFC  0063 C4 5E 06  les bx, [bp+0x6]
0AFF  0066 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L006B: cx = PopStack(player);
            L006C: cx = PopStack(player);
            L006D: PushStack(player, 0x05);
0B0A  0071 B8 02 00  mov ax, 0x2
            L0074: goto L0100;
            L0077: Compare(PartyCount(player), 0x0002);
            L0082: if (JumpNotEqual) goto L00B1;
            L0084: AddEncounter(player, 0x01, 0x05);
            L0096: AddEncounter(player, 0x02, 0x1D);
            L00A8: PushStack(player, 0x1E);
0B45  00AC B8 05 00  mov ax, 0x5
            L00AF: goto L0100;
            L00B1: AddEncounter(player, 0x01, 0x1C);
            L00C3: AddEncounter(player, 0x02, 0x1B);
            L00D5: AddEncounter(player, 0x04, 0x09);
            L00E7: AddEncounter(player, 0x05, 0x1E);
            L00F9: AddEncounter(player, 0x06, 0x1F);
            L010B: return; // RETURN;
        }

        private void FnSECKNT_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0001);
            L000D: if (JumpNotEqual) goto L0036;
            L000F: ShowMessage(player, String0DBC); // A sign on the door says KNIGHTS ONLY.
0BC7  001C FF 76 08  push word [bp+0x8]
0BCA  001F FF 76 06  push word [bp+0x6]
0BCD  0022 0E     push cs
0BCE  0023 E8 BE 0D  call 0xde4
            L0026: // NOP
            L0027: cx = PopStack(player);
            L0028: cx = PopStack(player);
0BD4  0029 FF 76 08  push word [bp+0x8]
0BD7  002C FF 76 06  push word [bp+0x6]
0BDA  002F 0E     push cs
0BDB  0030 E8 D4 0D  call 0xe07
            L0033: // NOP
            L0034: goto L0041;
0BE1  0036 FF 76 08  push word [bp+0x8]
0BE4  0039 FF 76 06  push word [bp+0x6]
0BE7  003C 0E     push cs
0BE8  003D E8 00 0E  call 0xe40
            L0040: // NOP
            L0041: cx = PopStack(player);
            L0042: cx = PopStack(player);
            L0043: return; // RETURN;
        }

        private void FnSNRDOOR_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0xDD);
            L0007: PushStack(player, ax);
0BF8  0008 C4 5E 06  les bx, [bp+0x6]
0BFB  000B 26 FF 5F 54  call far word [es:bx+0x54]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0034;
0C05  0015 FF 76 08  push word [bp+0x8]
0C08  0018 FF 76 06  push word [bp+0x6]
0C0B  001B 0E     push cs
0C0C  001C E8 A3 0D  call 0xdc2
            L001F: // NOP
            L0020: cx = PopStack(player);
            L0021: cx = PopStack(player);
0C12  0022 FF 76 08  push word [bp+0x8]
0C15  0025 FF 76 06  push word [bp+0x6]
0C18  0028 0E     push cs
0C19  0029 E8 73 0D  call 0xd9f
            L002C: // NOP
            L002D: cx = PopStack(player);
            L002E: cx = PopStack(player);
0C1F  002F B8 E2 0D  mov ax, 0xde2
            L0032: goto L0044;
0C24  0034 FF 76 08  push word [bp+0x8]
0C27  0037 FF 76 06  push word [bp+0x6]
0C2A  003A 0E     push cs
0C2B  003B E8 BD 0D  call 0xdfb
            L003E: // NOP
            L003F: cx = PopStack(player);
            L0040: cx = PopStack(player);
            L0041: ShowMessage(player, String0E04); // The entrance to Sneer's Pawn Shop is locked.
            L004E: return; // RETURN;
        }

        private void FnCLUEG_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0E31); // On the plaque you see SRAHMC.
            L0010: return; // RETURN;
        }

        private void FnPITA_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0E4F); // You plunge into the pit and find yourself at the bottom of a secret shaft to the Vault.
            L0010: TeleportParty(player, 0x05, 0x01, 0x87, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnPITB_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0EA7); // You congratulate yourself on your choice. But your confidence turns to alarm as you feel yourself approaching the Fringe of Madness.
            L0010: TeleportParty(player, 0x05, 0x01, 0x8B, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnCLUEH_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0016);
            L0010: ShowMessage(player, String0F2C); // You meet an old seafarer.
            L001D: ShowMessage(player, String0F46); // 'Beware of Lake Despair, matey. Many a foolhardy adventurer has sunk into its treacherous depths.
            L002A: ShowMessage(player, String0FA8); // A special jacket helped me cross the lake once, but I lost it somewhere in the dungeon. Pity.'
            L0037: return; // RETURN;
        }

        private void FnCLUEI_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0020);
            L0010: ShowMessage(player, String1007); // You meet a friendly but puzzled ranger, 'This MUST be Clueless! Hmmm...I suspect a wizard has tampered with the clues in this area.' He shows you a parchment on which he has written SPAS.
            L001D: return; // RETURN;
        }

        private void FnGHOSTENC_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x000B);
            L0010: ShowMessage(player, String10C3); // An apparition appears before you, 'I almost met my death while trying to squeeze past my stony friend who was concealing a shortcut to this place.
            L001D: ShowMessage(player, String1156); // However, my statuesque form encountered its demise elsewhere.'
            L002A: return; // RETURN;
        }

        private void FnKEYE_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0005);
            L000D: if (JumpNotEqual) goto L006E;
            L000F: ax = HasItem(player, 0xD0);
            L001D: if (JumpEqual) goto L0021;
            L001F: goto L006E;
            L0021: Compare(GetFlag(player, 0x02, 0x45), 0x0001);
            L0035: if (JumpNotEqual) goto L005D;
            L0037: GiveItem(player, 0xD0);
            L0043: ShowMessage(player, String0AE6); // You find a key which may open seemingly impassable doors in your race to finish Queen Aeowyn's Map Quest.
0D85  0050 FF 76 08  push word [bp+0x8]
0D88  0053 FF 76 06  push word [bp+0x6]
0D8B  0056 0E     push cs
0D8C  0057 E8 DC 0B  call 0xc36
            L005A: // NOP
            L005B: goto L0079;
            L005D: GiveItem(player, 0xD0);
0D9E  0069 B8 50 0B  mov ax, 0xb50
            L006C: goto L0046;
0DA3  006E FF 76 08  push word [bp+0x8]
0DA6  0071 FF 76 06  push word [bp+0x6]
0DA9  0074 0E     push cs
0DAA  0075 E8 D0 0B  call 0xc48
            L0078: // NOP
            L0079: cx = PopStack(player);
            L007A: cx = PopStack(player);
            L007B: return; // RETURN;
        }

        private void FnSECWIZ_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0005);
            L000D: if (JumpNotEqual) goto L0036;
            L000F: ShowMessage(player, String1195); // A sign on the door reads WIZARDS ONLY.
0DCE  001C FF 76 08  push word [bp+0x8]
0DD1  001F FF 76 06  push word [bp+0x6]
0DD4  0022 0E     push cs
0DD5  0023 E8 B7 0B  call 0xbdd
            L0026: // NOP
            L0027: cx = PopStack(player);
            L0028: cx = PopStack(player);
0DDB  0029 FF 76 08  push word [bp+0x8]
0DDE  002C FF 76 06  push word [bp+0x6]
0DE1  002F 0E     push cs
0DE2  0030 E8 CD 0B  call 0xc00
            L0033: // NOP
            L0034: goto L0041;
0DE8  0036 FF 76 08  push word [bp+0x8]
0DEB  0039 FF 76 06  push word [bp+0x6]
0DEE  003C 0E     push cs
0DEF  003D E8 F9 0B  call 0xc39
            L0040: // NOP
            L0041: cx = PopStack(player);
            L0042: cx = PopStack(player);
            L0043: return; // RETURN;
        }

        private void FnSNICKER_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0025);
            L0010: RefreshCompareFlags(GetFlag(player, 0x02, 0x3F));
            L0023: if (JumpNotEqual) goto L005F;
            L0025: SetFlag(player, 0x02, 0x3F, 0x01);
            L003A: ModifyGold(player, 0xFFFF18BA);
            L004C: ShowMessage(player, String11BC); // You meet a thief named Snicker, 'Three brothers have I, and courtesy is very important to all of them. One will show you the true path to what you seek. But all are fond of red gems.
0E50  0059 B8 73 12  mov ax, 0x1273
            L005C: goto L010E;
            L005F: Compare(GetFlag(player, 0x02, 0x3F), 0x0001);
            L0073: if (JumpNotEqual) goto L00AD;
            L0075: GiveItem(player, 0x90);
            L0081: SetFlag(player, 0x02, 0x3F, 0x02);
            L0096: ModifyGold(player, 0xFFFF78BA);
0E9F  00A8 B8 BC 12  mov ax, 0x12bc
            L00AB: goto L010E;
            L00AD: Compare(GetFlag(player, 0x02, 0x3F), 0x0002);
            L00C1: if (JumpNotEqual) goto L010B;
            L00C3: ax = HasItem(player, 0xDF);
            L00D1: if (JumpEqual) goto L010B;
            L00D3: GiveItem(player, 0x65);
            L00DF: SetFlag(player, 0x02, 0x3F, 0x03);
            L00F4: ModifyGold(player, 0xFFFF78BA);
0EFD  0106 B8 9B 13  mov ax, 0x139b
            L0109: goto L010E;
            L010B: ShowMessage(player, String1464); // Snicker is busy helping himself to the goods of others.
            L0118: return; // RETURN;
        }

        private void FnTELEF_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String149C); // You can hear the rushing waters of Lake Despair.
            L0010: TeleportParty(player, 0x05, 0x01, 0x93, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnTELEG_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String14CD); // A sign on the portal says, 'Entrance to the Gallery'.
            L0010: TeleportParty(player, 0x06, 0x01, 0xC3, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void FnGOLDDOWN_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1503); // You lose your footing on a loose rock and your bag of gold falls to the ground.
            L0010: ShowMessage(player, String1553); // You manage to gather all but 1000 pieces, which fall through cracks in the floor.
            L001D: ModifyGold(player, 0xFFFF18BA);
            L002F: return; // RETURN;
        }

        private void FnFTNB_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x07);
            L0007: PushStack(player, 0x00);
0FBE  000A C4 5E 06  les bx, [bp+0x6]
0FC1  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L0066;
0FCB  0017 FF 76 08  push word [bp+0x8]
0FCE  001A FF 76 06  push word [bp+0x6]
0FD1  001D 0E     push cs
0FD2  001E E8 38 0A  call 0xa59
            L0021: // NOP
            L0022: cx = PopStack(player);
            L0023: cx = PopStack(player);
            L0024: ShowMessage(player, String15A5); // The dark waters of Sunset Fountain poison you when you attempt to refresh yourself.
            L0031: ax = GetMaxHits(player);
            L0038: bx = 0x000A;
            L003B: dx = ax % bx; ax = ax / bx;
            L003E: PushStack(player, ax);
            L003F: PushStack(player, 0x05);
            L0043: PushStack(player, 0x01);
0FFB  0047 C4 5E 06  les bx, [bp+0x6]
0FFE  004A 26 FF 9F 9C 00  call far word [es:bx+0x9c]
1003  004F 83 C4 06  add sp, 0x6
            L0052: SetFlag(player, 0x00, 0x07, 0x01);
            L0066: return; // RETURN;
        }

        private void FnCLUEL_37(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String15F9); // On the plaque you see EPRY.
            L0010: return; // RETURN;
        }

        private void FnFTNC_38(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
103B  0003 FF 76 08  push word [bp+0x8]
103E  0006 FF 76 06  push word [bp+0x6]
1041  0009 0E     push cs
1042  000A E8 C8 09  call 0x9d5
            L000D: // NOP
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
            L0010: Compare(GetFlag(player, 0x02, 0x40), 0x0001);
            L0024: if (JumpNotEqual) goto L004E;
            L0026: ShowMessage(player, String1615); // The waters of Windy Fountain have no effect.
            L0033: ShowMessage(player, String1642); // The Key of C falls into the fountain.
            L0040: PushStack(player, 0xDF);
107C  0044 C4 5E 06  les bx, [bp+0x6]
107F  0047 26 FF 5F 4C  call far word [es:bx+0x4c]
            L004B: goto L0186;
            L004E: ax = HasItem(player, 0xDF);
            L005C: if (JumpNotEqual) goto L0061;
            L005E: goto L017A;
            L0061: Compare(GetGuild(player), 0x0003);
            L006B: if (JumpNotEqual) goto L00A5;
            L006D: RemoveItem(player, 0xDF);
            L0079: SetFlag(player, 0x02, 0x40, 0x01);
            L008E: SetSkillLevel(player, 0x10, 0x01);
10D7  009F B8 68 16  mov ax, 0x1668
            L00A2: goto L017D;
            L00A5: RefreshCompareFlags(GetGuild(player));
            L00AE: if (JumpEqual) goto L00BC;
            L00B0: Compare(GetGuild(player), 0x0005);
            L00BA: if (JumpNotEqual) goto L00F4;
            L00BC: RemoveItem(player, 0xDF);
            L00C8: SetFlag(player, 0x02, 0x40, 0x01);
            L00DD: SetSkillLevel(player, 0x07, 0x01);
1126  00EE B8 AC 16  mov ax, 0x16ac
            L00F1: goto L017D;
            L00F4: Compare(GetGuild(player), 0x0002);
            L00FE: if (JumpEqual) goto L010C;
            L0100: Compare(GetGuild(player), 0x0004);
            L010A: if (JumpNotEqual) goto L0143;
            L010C: RemoveItem(player, 0xDF);
            L0118: SetFlag(player, 0x02, 0x40, 0x01);
            L012D: SetSkillLevel(player, 0x0C, 0x01);
1176  013E B8 F9 16  mov ax, 0x16f9
            L0141: goto L017D;
            L0143: RemoveItem(player, 0xDF);
            L014F: SetFlag(player, 0x02, 0x40, 0x01);
            L0164: SetSkillLevel(player, 0x08, 0x01);
11AD  0175 B8 35 17  mov ax, 0x1735
            L0178: goto L017D;
            L017A: ShowMessage(player, String1776); // A gift from a bard makes these waters magical.
            L0187: return; // RETURN;
        }

        private void FnKEYOFC_39(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0xDF);
            L0007: PushStack(player, ax);
11C9  0008 C4 5E 06  les bx, [bp+0x6]
11CC  000B 26 FF 5F 54  call far word [es:bx+0x54]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0034;
11D6  0015 FF 76 08  push word [bp+0x8]
11D9  0018 FF 76 06  push word [bp+0x6]
11DC  001B 0E     push cs
11DD  001C E8 D2 07  call 0x7f1
            L001F: // NOP
            L0020: cx = PopStack(player);
            L0021: cx = PopStack(player);
11E3  0022 FF 76 08  push word [bp+0x8]
11E6  0025 FF 76 06  push word [bp+0x6]
11E9  0028 0E     push cs
11EA  0029 E8 A2 07  call 0x7ce
            L002C: // NOP
            L002D: cx = PopStack(player);
            L002E: cx = PopStack(player);
11F0  002F B8 A5 17  mov ax, 0x17a5
            L0032: goto L0044;
11F5  0034 FF 76 08  push word [bp+0x8]
11F8  0037 FF 76 06  push word [bp+0x6]
11FB  003A 0E     push cs
11FC  003B E8 EC 07  call 0x82a
            L003E: // NOP
            L003F: cx = PopStack(player);
            L0040: cx = PopStack(player);
            L0041: ShowMessage(player, String17CE); // You see a musical note on the locked door.
            L004E: return; // RETURN;
        }

        private void FnFTND_3B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
1219  0003 FF 76 08  push word [bp+0x8]
121C  0006 FF 76 06  push word [bp+0x6]
121F  0009 0E     push cs
1220  000A E8 EA 07  call 0x7f7
            L000D: // NOP
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
            L0010: ShowMessage(player, String17F9); // The fresh waters of Sunrise Fountain restore your mana.
            L001D: AddMana(player, 0x1388);
            L002A: return; // RETURN;
        }

        private void FnTELEH_3C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1831); // Enter the Rat Race.
            L0010: TeleportParty(player, 0x06, 0x03, 0xF1, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void FnFTNE_3D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
1271  0003 FF 76 08  push word [bp+0x8]
1274  0006 FF 76 06  push word [bp+0x6]
1277  0009 0E     push cs
1278  000A E8 92 07  call 0x79f
            L000D: // NOP
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
            L0010: Compare(GetFlag(player, 0x02, 0x41), 0x0001);
            L0024: if (JumpNotEqual) goto L0045;
            L0026: RemoveItem(player, 0xDE);
            L0032: ShowMessage(player, String1845); // The haze surrounding Misty Fountain has no further effect.
12AD  003F B8 80 18  mov ax, 0x1880
            L0042: goto L00FC;
            L0045: ax = HasItem(player, 0xDE);
            L0053: if (JumpNotEqual) goto L0058;
            L0055: goto L00F9;
            L0058: RemoveItem(player, 0xDE);
            L0064: ShowMessage(player, String1880); // The Front Door Key disappears.
            L0071: SetFlag(player, 0x02, 0x41, 0x01);
            L0086: RefreshCompareFlags(GetGuild(player));
            L008F: if (JumpEqual) goto L00B5;
            L0091: Compare(GetGuild(player), 0x0004);
            L009B: if (JumpEqual) goto L00B5;
            L009D: Compare(GetGuild(player), 0x0002);
            L00A7: if (JumpEqual) goto L00B5;
            L00A9: Compare(GetGuild(player), 0x0005);
            L00B3: if (JumpNotEqual) goto L00CB;
            L00B5: SetSpellLevel(player, 0x17, 0x01);
1334  00C6 B8 9F 18  mov ax, 0x189f
            L00C9: goto L00FC;
            L00CB: Compare(GetGuild(player), 0x0001);
            L00D5: if (JumpEqual) goto L00E3;
            L00D7: Compare(GetGuild(player), 0x0003);
            L00E1: if (JumpNotEqual) goto L0106;
            L00E3: SetSpellLevel(player, 0x08, 0x01);
1362  00F4 B8 EC 18  mov ax, 0x18ec
            L00F7: goto L00FC;
            L00F9: ShowMessage(player, String1937); // A door key will channel the powers in the haze.
            L0106: return; // RETURN;
        }

        private void FnGOODIEC_3E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1967); // Where music once played, battle sounds now rage.
            L0010: ax = HasItem(player, 0x91);
            L001E: if (JumpEqual) goto L0032;
1396  0020 B8 E8 03  mov ax, 0x3e8
            L0023: PushStack(player, ax);
            L0024: PushStack(player, 0x00);
            L0027: PushStack(player, ax);
            L0028: PushStack(player, ax);
            L0029: PushStack(player, 0x9C);
13A3  002D B8 9D 00  mov ax, 0x9d
            L0030: goto L0045;
13A8  0032 B8 B8 0B  mov ax, 0xbb8
            L0035: PushStack(player, ax);
            L0036: PushStack(player, 0x00);
            L0039: PushStack(player, ax);
            L003A: PushStack(player, 0x9F);
            L003E: PushStack(player, 0xA8);
            L0042: PushStack(player, 0x91);
13BC  0046 C4 5E 06  les bx, [bp+0x6]
13BF  0049 26 FF 9F D8 00  call far word [es:bx+0xd8]
13C4  004E 83 C4 0C  add sp, 0xc
            L0051: Compare(PartyCount(player), 0x0001);
            L005C: if (JumpNotEqual) goto L007A;
            L005E: AddEncounter(player, 0x01, 0x0F);
            L0070: PushStack(player, 0x15);
13EA  0074 B8 02 00  mov ax, 0x2
            L0077: goto L0103;
            L007A: Compare(PartyCount(player), 0x0002);
            L0085: if (JumpNotEqual) goto L00B4;
            L0087: AddEncounter(player, 0x01, 0x0F);
            L0099: AddEncounter(player, 0x02, 0x0F);
            L00AB: PushStack(player, 0x15);
1425  00AF B8 05 00  mov ax, 0x5
            L00B2: goto L0103;
            L00B4: AddEncounter(player, 0x01, 0x0F);
            L00C6: AddEncounter(player, 0x02, 0x0F);
            L00D8: AddEncounter(player, 0x03, 0x13);
            L00EA: AddEncounter(player, 0x05, 0x14);
            L00FC: AddEncounter(player, 0x06, 0x16);
            L010E: return; // RETURN;
        }

        private void FnTEXTD_3F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1998); // This is the Ingress to the Night Elves' Domain. The southern gateway will take you back to the Main Entrance.
            L0010: return; // RETURN;
        }

        private void FnTELEI_40(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, 0xDE);
            L000B: PushStack(player, 0x01);
            L000F: PushStack(player, ax);
14A8  0010 C4 5E 06  les bx, [bp+0x6]
14AB  0013 26 FF 9F BC 00  call far word [es:bx+0xbc]
14B0  0018 83 C4 08  add sp, 0x8
            L001B: return; // RETURN;
        }

        private void FnFRNTDOOR_41(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0xDE);
            L0007: PushStack(player, ax);
14BD  0008 C4 5E 06  les bx, [bp+0x6]
14C0  000B 26 FF 5F 54  call far word [es:bx+0x54]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0034;
14CA  0015 FF 76 08  push word [bp+0x8]
14CD  0018 FF 76 06  push word [bp+0x6]
14D0  001B 0E     push cs
14D1  001C E8 DE 04  call 0x4fd
            L001F: // NOP
            L0020: cx = PopStack(player);
            L0021: cx = PopStack(player);
14D7  0022 FF 76 08  push word [bp+0x8]
14DA  0025 FF 76 06  push word [bp+0x6]
14DD  0028 0E     push cs
14DE  0029 E8 AE 04  call 0x4da
            L002C: // NOP
            L002D: cx = PopStack(player);
            L002E: cx = PopStack(player);
14E4  002F B8 06 1A  mov ax, 0x1a06
            L0032: goto L0044;
14E9  0034 FF 76 08  push word [bp+0x8]
14EC  0037 FF 76 06  push word [bp+0x6]
14EF  003A 0E     push cs
14F0  003B E8 F8 04  call 0x536
            L003E: // NOP
            L003F: cx = PopStack(player);
            L0040: cx = PopStack(player);
            L0041: ShowMessage(player, String1A29); // The front door is locked.
            L004E: return; // RETURN;
        }

        private void FnCLUEM_44(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1A43); // You find a sheet of music with a song written in the key of C. The lyrics tell of two areas where race is the key to discovering treasure.
            L0010: return; // RETURN;
        }

        private void FnMEDA_47(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L001A;
            L0010: PushStack(player, 0x1C);
153F  0014 B8 01 00  mov ax, 0x1
            L0017: goto L00A3;
            L001A: Compare(PartyCount(player), 0x0002);
            L0025: if (JumpNotEqual) goto L0054;
            L0027: AddEncounter(player, 0x01, 0x05);
            L0039: AddEncounter(player, 0x02, 0x1D);
            L004B: PushStack(player, 0x1B);
157A  004F B8 03 00  mov ax, 0x3
            L0052: goto L00A3;
            L0054: AddEncounter(player, 0x01, 0x1C);
            L0066: AddEncounter(player, 0x02, 0x1D);
            L0078: AddEncounter(player, 0x03, 0x1D);
            L008A: AddEncounter(player, 0x04, 0x1E);
            L009C: AddEncounter(player, 0x06, 0x1F);
            L00AE: return; // RETURN;
        }

        private void FnMEDB_48(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002B;
            L0010: AddEncounter(player, 0x01, 0x0B);
            L0022: PushStack(player, 0x10);
1601  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00A2;
            L002B: Compare(PartyCount(player), 0x0002);
            L0036: if (JumpNotEqual) goto L0053;
            L0038: AddEncounter(player, 0x01, 0x0C);
            L004A: PushStack(player, 0x11);
1629  004E B8 02 00  mov ax, 0x2
            L0051: goto L0090;
            L0053: AddEncounter(player, 0x01, 0x0D);
            L0065: AddEncounter(player, 0x02, 0x0E);
            L0077: AddEncounter(player, 0x03, 0x20);
            L0089: AddEncounter(player, 0x05, 0x0F);
            L009B: AddEncounter(player, 0x06, 0x12);
            L00AD: return; // RETURN;
        }

        private void FnHRDB_49(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x19);
            L0022: PushStack(player, 0x1A);
16B0  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00B5;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0066;
            L0039: AddEncounter(player, 0x01, 0x19);
            L004B: AddEncounter(player, 0x02, 0x19);
            L005D: PushStack(player, 0x23);
16EB  0061 B8 05 00  mov ax, 0x5
            L0064: goto L00B5;
            L0066: AddEncounter(player, 0x01, 0x19);
            L0078: AddEncounter(player, 0x02, 0x19);
            L008A: AddEncounter(player, 0x03, 0x22);
            L009C: AddEncounter(player, 0x04, 0x22);
            L00AE: AddEncounter(player, 0x06, 0x25);
            L00C0: return; // RETURN;
        }

        private void FnEZA_4A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0029;
            L0010: PushStack(player, 0x01);
            L0014: PushStack(player, ax);
1761  0015 C4 5E 06  les bx, [bp+0x6]
1764  0018 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L001D: cx = PopStack(player);
            L001E: cx = PopStack(player);
            L001F: PushStack(player, 0x0B);
176F  0023 B8 02 00  mov ax, 0x2
            L0026: goto L00AE;
            L0029: Compare(PartyCount(player), 0x0002);
            L0034: if (JumpNotEqual) goto L005F;
            L0036: AddEncounter(player, 0x01, 0x03);
            L0048: AddEncounter(player, 0x02, 0x01);
17A6  005A B8 0C 00  mov ax, 0xc
            L005D: goto L00AA;
            L005F: AddEncounter(player, 0x01, 0x03);
            L0071: AddEncounter(player, 0x02, 0x01);
            L0083: AddEncounter(player, 0x03, 0x01);
            L0095: AddEncounter(player, 0x05, 0x0C);
            L00A7: AddEncounter(player, 0x06, 0x0D);
            L00B9: return; // RETURN;
        }

        private void FnMEDC_4B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0019;
            L0010: PushStack(player, 0x24);
181B  0014 B8 01 00  mov ax, 0x1
            L0017: goto L0090;
            L0019: Compare(PartyCount(player), 0x0002);
            L0024: if (JumpNotEqual) goto L0041;
            L0026: AddEncounter(player, 0x01, 0x22);
            L0038: PushStack(player, 0x25);
1843  003C B8 02 00  mov ax, 0x2
            L003F: goto L0090;
            L0041: AddEncounter(player, 0x01, 0x24);
            L0053: AddEncounter(player, 0x02, 0x24);
            L0065: AddEncounter(player, 0x03, 0x25);
            L0077: AddEncounter(player, 0x04, 0x25);
            L0089: AddEncounter(player, 0x05, 0x16);
            L009B: return; // RETURN;
        }

        private void FnHRDC_4C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x14);
            L0022: PushStack(player, 0x15);
18CA  0026 B8 05 00  mov ax, 0x5
            L0029: goto L00B5;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0066;
            L0039: AddEncounter(player, 0x01, 0x14);
            L004B: AddEncounter(player, 0x02, 0x16);
            L005D: PushStack(player, 0x15);
1905  0061 B8 03 00  mov ax, 0x3
            L0064: goto L00A3;
            L0066: AddEncounter(player, 0x01, 0x14);
            L0078: AddEncounter(player, 0x02, 0x16);
            L008A: AddEncounter(player, 0x03, 0x16);
            L009C: AddEncounter(player, 0x05, 0x28);
            L00AE: AddEncounter(player, 0x06, 0x28);
            L00C0: return; // RETURN;
        }

        private void Fn_4D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: return; // RETURN;
            // Extra data: 55 8B EC B8 CE 1A 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC B8 33 1B 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 B8 01 00 50 C4 5E 06 26 FF 5F 30 83 C4 06 5D CB 55 8B EC B8 01 00 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 55 8B EC C4 5E 06 26 FF 5F 74 50 C4 5E 06 26 FF 9F 90 00 59 5D CB 55 8B EC 33 C0 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 55 8B EC B8 42 00 50 C4 5E 06 26 FF 9F FC 00 59 5D CB 
        }

    }
}
