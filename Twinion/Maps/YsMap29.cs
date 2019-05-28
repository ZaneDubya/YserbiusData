#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap29 : AMapScripted {
        protected override int MapIndex => 29;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 1;

        public YserMap29() {
            MapEvent01 = FnASTRAL_01;
            MapEvent02 = FnHELL_02;
            MapEvent03 = FnHEAVEN_03;
            MapEvent04 = FnELMNTONE_04;
            MapEvent05 = FnELMNTTWO_05;
            MapEvent06 = FnPLANEPNT_06;
            MapEvent07 = FnPHYSMES_07;
            MapEvent08 = FnHEVMESS_08;
            MapEvent09 = FnHELLMES_09;
            MapEvent0A = FnELMNTMES_0A;
            MapEvent0B = FnBLOCKWAL_0B;
            MapEvent0C = FnLUREMESZ_0C;
            MapEvent0D = FnPHYSTAT_0D;
            MapEvent0E = FnELMNTALT_0E;
            MapEvent0F = FnHEVALTAR_0F;
            MapEvent10 = FnHELALTAR_10;
            MapEvent11 = FnASTRLALT_11;
            MapEvent13 = FnENTRNPRT_13;
            MapEvent14 = FnTOANTECH_14;
            MapEvent15 = FnTHEBECK_15;
            MapEvent16 = FnSTATBLCK_16;
            MapEvent17 = FnASTRLMES_17;
            MapEvent18 = FnPHYSALTR_18;
            MapEvent19 = FnTHEGIFT_19;
            MapEvent1A = FnQUEENAEO_1A;
            MapEvent1B = FnQUENTEXT_1B;
            MapEvent1C = FnTOMAINEN_1C;
            MapEvent2B = Fn_2B;
        }
        
        // === Strings ================================================
        private const string String03FC = "You manage to move through the astral material.";
        private const string String042C = "The vile evil that sustains this pocket of Ashakkar here drains life from you!";
        private const string String047B = "You thrive on the vicious forces that exist here.";
        private const string String04AD = "Your struggle against the forces in this piece of Enakkar twists and drains your energy.";
        private const string String0506 = "You feel revived and refreshed as you travel through this segment of Enakkar.";
        private const string String0554 = "The forces of Fire sear and singe you as you travel through some small part of the Elemental plane.";
        private const string String05B8 = "The Waters here drench you with ominous force.";
        private const string String05E7 = "Violent forces whip into a fury of vorticies; forming an arsenal of Planar Guardians who prevent transgressions!!";
        private const string String0659 = "A splendor of sculptures and jewels decorate this elaborate setting.  For you have come into Corpeus' re-creation of his home.";
        private const string String06D8 = "This is a semblance of the Physical Plane.";
        private const string String0703 = "Pillars of pure light shoot upwards into oblivion, setting this space ablaze with Juvalad magic.";
        private const string String0764 = "This is a semblance of the plane Enakkar!";
        private const string String078E = "Violent waves of lava cascade against the astral shores as fire and brimstone fly in Pluthros' throne room.";
        private const string String07FA = "This is a semblance of the plane Ashakkar!";
        private const string String0825 = "The four corners of creation scorn at each other in Malos' domain.";
        private const string String0868 = "This is a semblance of the Elemental Plane.";
        private const string String0894 = "Turbulent forces impede you from going any further in this direction.";
        private const string String08DA = "You can just make out a distant plane ahead of you...perhaps you can reach it through here.";
        private const string String0936 = "A maginficent likeness of some powerful demigod stands here as guardian to this chamber.";
        private const string String098F = "Malos weaves magical mists as he speaks at you, 'You dare to challenge the Guardian of the Elements! I shall not be so easy to defeat!";
        private const string String0A16 = "My ring shall be yours if you can conquer the Elements!'";
        private const string String0A4F = "The Dralkarian Lord of the Elements is not here.";
        private const string String0A80 = "Juvalad strips you of the ability to use magic! Your alignment opposes his own!";
        private const string String0AD0 = "Your alignment has weakened your magic; but your devotion lets you retain your spells, your skills though are useless!";
        private const string String0B47 = "Juvalad rises before you, 'Foul fool! Do you not know death, when you see it? Die now and curse in vain!'";
        private const string String0BB1 = "The Dralkarian Lord of Enakkar is not here.";
        private const string String0BDD = "Your alignment opposes Pluthros'!";
        private const string String0BFF = "For that, he strips your ability to use magic! ";
        private const string String0C2F = "For that, he has weakened your magic; but your devotion let's you retain your spells! Your skills, however, are useless!";
        private const string String0CA8 = "Pluthros offers a resonating cry as you approach, 'You do not know of the prophecies! You are not one of the followers!";
        private const string String0D20 = "Now I shall teach you the price of incredulity!'";
        private const string String0D51 = "The Dralkarian Lord of Ashakkar is not here.";
        private const string String0D7E = "Astelligus roars as you near his throne room, 'Damn you to Ashakkar! Your intrusion shall be short lived! I shall send you on your way to the next life!'";
        private const string String0E18 = "The Dralkarian Lord of the Astral plane is not here.";
        private const string String0E4D = "A glowing portal here will send you back to the Main Entrance. You will not be able to return lest you traverse the pathway here again!";
        private const string String0ED5 = "You are pulled into the antechamber of the throne room. You must not leave this realm, lest your efforts are wasted!";
        private const string String0F4A = "You cannot step here together. Disband and return.";
        private const string String0F7D = "Nothing happens.";
        private const string String0F8E = "In front of you sits an enormous throne, where one of the Dralkarians ponders Fate.";
        private const string String0FE2 = "As he notices you, he spots something you're carrying and beckons you forth with an evil grin.";
        private const string String1041 = "Corpeus bellows at you, 'Without the Rampart, you have no defense. Away, come again once you've found my Reality!'";
        private const string String10B4 = "Pluthros scorns you, 'Hath you no Hope? No Fury? Do not trouble me again without some sign of these!'";
        private const string String111A = "Malos screeches at you, 'Have you no wisdom? Dost thou truly believe your puny weapons could defeat the elements? Another, will surely offer me challenge.'";
        private const string String11B6 = "Juvalad sighs in disgust, 'Your efforts are wasted here! Back to Tribulations with you! You can not survive without the Flask.";
        private const string String1235 = "Astelligus' voice echoes across the great void:";
        private const string String1265 = "'Puny mortal...you fail to honor me with the proper artifact. Seek the Nimbus, and return, you will make for interesting prey!'";
        private const string String12E5 = "His magics swirl around you and hurl you through a vortex, back to the pathway.";
        private const string String1335 = "Away! You've left this domain and re-entered. You must remain here once you've started until you've killed the Dralk or died trying!";
        private const string String13BA = "The Dralk sends you to the entrance of His home!";
        private const string String13EB = "An enormous void of darkness and surreal images haunts your vision now that you've stepped into a piece of Astelligus' home.";
        private const string String1468 = "This is a semblance of the Astral plane.";
        private const string String1491 = "Your prowess with magic allows you to retain your abilities; but not to restore your mana!!!";
        private const string String14EE = "Your magical powers are feeble and lack the discipline of a Wizard or Cleric. Your magics are useless here!";
        private const string String155A = "Corpeus is here. His voice shakes the great hall: 'Puny mortal. You dare come to challenge me? For my ring, you must take my life. For your attempt, I will take yours!'";
        private const string String1603 = "The Dralkarian Lord of the Physical plane is not here.";
        private const string String163A = "The mystical device that aided you in the demise of this Dralk has also vanished!";
        private const string String168C = "You've passed here before! Live on and remember the Dralk as he was!";
        private const string String16D1 = "You must continue, for the Dralk's ring and his embodiment are gone from here.";
        private const string String1720 = "'My Great Champion! You've returned one of the Dralk's Rings! This will ensure us the power to enter the final phase of this most grand design!";
        private const string String17B0 = "With each ring, I can use its power to increase your wisdom. Reap the benefits of the services you have sewn!";
        private const string String181E = "Quickly now, with each passing Dralk we step closer to finding the nexus of immortality. Onward, return once you've conquered the next Dralk!'";
        private const string String18AD = "As the Queen takes the fifth ring from your grasp, the forces here explode in a violent shockwave, throwing you to the ground.";
        private const string String192C = "Aeowyn is absorbed in a fiery light of pure magic, she hovers and offers an evil laugh!";
        private const string String1984 = "'Did you truly believe I would share the greatest triumph with you! Your powers are no match for mine now! Away with you! Your faith in my friendship was your weakness! I alone shall breach The Gateway; I alone shall enter the next phase!'";
        private const string String1A74 = "Driven mad with power, Aeowyn hurls untamed forces upon you, stripping away parts of your attributes! A blast explodes on the southern wall, where a teleport will allow you escape.";
        private const string String1B29 = "The mad Queen, then dissipates into nothingness, only her evil laughter echoing as she heads off to The Gateway.";
        private const string String1B9A = "'My Champion, you must return the Dralks' rings to me! Without them we will never be able to enter the ultimate goal of our Quest!'";
        private const string String1C1E = "The Queen conjurs a gateway behind you. 'Take this to the entrance, and try again! I will be here as long as possible...' She then returns to her magics and dismisses you.";
        private const string String1CCA = "Her Majesty hovers before you in a misty hue of grey-blue smoke. She is conjuring powerful forces to hold her presence here!";
        private const string String1D47 = "Approach her to the north, and report!";
        private const string String1D6E = "This shall lead you out.";
        private const string String1D87 = "A wall slides silently shut behind you, trapping you in the Dralk's throne room.";
        private const string String1DD8 = "Brilliant crystals offset a stunning portal on the now closed egress!";
        
        // === Functions ================================================
        private void FnASTRAL_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String03FC); // You manage to move through the astral material.
            L0010: return; // RETURN;
        }

        private void FnHELL_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0023  0003 C4 5E 06  les bx, [bp+0x6]
0026  0006 26 FF 5F 40  call far word [es:bx+0x40]
002A  000A C4 5E 06  les bx, [bp+0x6]
002D  000D 26 FF 5F 3C  call far word [es:bx+0x3c]
0031  0011 C4 5E 06  les bx, [bp+0x6]
0034  0014 26 FF 9F C8 00  call far word [es:bx+0xc8]
            L0019: AddMana(player, 0xFF38);
            L0026: PushStack(player, 0x01);
            L002A: PushStack(player, 0x00);
004D  002D C4 5E 06  les bx, [bp+0x6]
0050  0030 26 FF 5F 04  call far word [es:bx+0x4]
            L0034: cx = PopStack(player);
            L0035: cx = PopStack(player);
            L0036: RefreshCompareFlags(ax);
            L0038: if (JumpNotEqual) goto L00A9;
            L003A: RefreshCompareFlags(GetAlignment(player));
            L0044: if (JumpNotEqual) goto L006B;
            L0046: ax = GetMaxHits(player);
            L004D: bx = 0x0008;
            L0050: dx = ax % bx; ax = ax / bx;
            L0053: DamagePlayer(player, ax);
007D  005D B8 2C 04  mov ax, 0x42c
            L0060: PushStack(player, ax);
0081  0061 C4 5E 06  les bx, [bp+0x6]
0084  0064 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L0069: goto L009B;
            L006B: ShowMessage(player, String047B); // You thrive on the vicious forces that exist here.
            L0078: ax = GetCurrentHits(player);
            L007F: bx = 0x0003;
            L0082: dx = ax % bx; ax = ax / bx;
            L0085: HealPlayer(player, ax);
            L008F: AddMana(player, 0x00C8);
00BC  009C FF 76 08  push word [bp+0x8]
00BF  009F FF 76 06  push word [bp+0x6]
00C2  00A2 0E     push cs
00C3  00A3 E8 A6 0F  call 0x104c
            L00A6: // NOP
            L00A7: cx = PopStack(player);
            L00A8: cx = PopStack(player);
            L00A9: return; // RETURN;
        }

        private void FnHEAVEN_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
00CE  0003 C4 5E 06  les bx, [bp+0x6]
00D1  0006 26 FF 5F 40  call far word [es:bx+0x40]
00D5  000A C4 5E 06  les bx, [bp+0x6]
00D8  000D 26 FF 5F 3C  call far word [es:bx+0x3c]
00DC  0011 C4 5E 06  les bx, [bp+0x6]
00DF  0014 26 FF 9F C8 00  call far word [es:bx+0xc8]
            L0019: AddMana(player, 0xFF38);
            L0026: PushStack(player, 0x01);
            L002A: PushStack(player, 0x00);
00F8  002D C4 5E 06  les bx, [bp+0x6]
00FB  0030 26 FF 5F 04  call far word [es:bx+0x4]
            L0034: cx = PopStack(player);
            L0035: cx = PopStack(player);
            L0036: RefreshCompareFlags(ax);
            L0038: if (JumpNotEqual) goto L00AA;
            L003A: Compare(GetAlignment(player), 0x0001);
            L0045: if (JumpNotEqual) goto L006C;
            L0047: ax = GetCurrentHits(player);
            L004E: bx = 0x0008;
            L0051: dx = ax % bx; ax = ax / bx;
            L0054: DamagePlayer(player, ax);
0129  005E B8 AD 04  mov ax, 0x4ad
            L0061: PushStack(player, ax);
012D  0062 C4 5E 06  les bx, [bp+0x6]
0130  0065 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L006A: goto L009C;
            L006C: ShowMessage(player, String0506); // You feel revived and refreshed as you travel through this segment of Enakkar.
            L0079: ax = GetCurrentHits(player);
            L0080: bx = 0x0003;
            L0083: dx = ax % bx; ax = ax / bx;
            L0086: HealPlayer(player, ax);
            L0090: AddMana(player, 0x00C8);
0168  009D FF 76 08  push word [bp+0x8]
016B  00A0 FF 76 06  push word [bp+0x6]
016E  00A3 0E     push cs
016F  00A4 E8 FA 0E  call 0xfa1
            L00A7: // NOP
            L00A8: cx = PopStack(player);
            L00A9: cx = PopStack(player);
            L00AA: return; // RETURN;
        }

        private void FnELMNTONE_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
            L0007: PushStack(player, 0x00);
0181  000A C4 5E 06  les bx, [bp+0x6]
0184  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L0048;
            L0017: ax = GetCurrentHits(player);
            L001E: bx = 0x0003;
            L0021: dx = ax % bx; ax = ax / bx;
            L0024: DamagePlayer(player, ax);
            L002E: ShowMessage(player, String0554); // The forces of Fire sear and singe you as you travel through some small part of the Elemental plane.
01B2  003B FF 76 08  push word [bp+0x8]
01B5  003E FF 76 06  push word [bp+0x6]
01B8  0041 0E     push cs
01B9  0042 E8 B0 0E  call 0xef5
            L0045: // NOP
            L0046: cx = PopStack(player);
            L0047: cx = PopStack(player);
            L0048: return; // RETURN;
        }

        private void FnELMNTTWO_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
            L0007: PushStack(player, 0x00);
01CB  000A C4 5E 06  les bx, [bp+0x6]
01CE  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpNotEqual) goto L0048;
            L0017: ax = GetCurrentHits(player);
            L001E: bx = 0x0003;
            L0021: dx = ax % bx; ax = ax / bx;
            L0024: DamagePlayer(player, ax);
            L002E: ShowMessage(player, String05B8); // The Waters here drench you with ominous force.
01FC  003B FF 76 08  push word [bp+0x8]
01FF  003E FF 76 06  push word [bp+0x6]
0202  0041 0E     push cs
0203  0042 E8 66 0E  call 0xeab
            L0045: // NOP
            L0046: cx = PopStack(player);
            L0047: cx = PopStack(player);
            L0048: return; // RETURN;
        }

        private void FnPLANEPNT_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String05E7); // Violent forces whip into a fury of vorticies; forming an arsenal of Planar Guardians who prevent transgressions!!
            L0011: si = 0x0001;
            L0014: goto L0026;
            L0016: AddEncounter(player, si, 0x27);
            L0025: si = si + 1;
            L0026: Compare(si, 0x04);
            L0029: if (JumpLessOrEqual) goto L0016;
            L002B: si = 0x0005;
            L002E: goto L0040;
            L0030: AddEncounter(player, si, 0x28);
            L003F: si = si + 1;
            L0040: Compare(si, 0x06);
            L0043: if (JumpLessOrEqual) goto L0030;
            L0045: return; // RETURN (restoring si);
        }

        private void FnPHYSMES_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L0016: if (JumpNotEqual) goto L0044;
            L0018: ShowMessage(player, String0659); // A splendor of sculptures and jewels decorate this elaborate setting.  For you have come into Corpeus' re-creation of his home.
            L0025: ShowMessage(player, String06D8); // This is a semblance of the Physical Plane.
            L0032: PushStack(player, 0x01);
            L0036: PushStack(player, ax);
            L0037: PushStack(player, 0x03);
028E  003B C4 5E 06  les bx, [bp+0x6]
0291  003E 26 FF 1F  call far word [es:bx]
0294  0041 83 C4 06  add sp, 0x6
            L0044: return; // RETURN;
        }

        private void FnHEVMESS_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L0016: if (JumpNotEqual) goto L0044;
            L0018: ShowMessage(player, String0703); // Pillars of pure light shoot upwards into oblivion, setting this space ablaze with Juvalad magic.
            L0025: ShowMessage(player, String0764); // This is a semblance of the plane Enakkar!
            L0032: PushStack(player, 0x01);
            L0036: PushStack(player, ax);
            L0037: PushStack(player, 0x03);
02D4  003B C4 5E 06  les bx, [bp+0x6]
02D7  003E 26 FF 1F  call far word [es:bx]
02DA  0041 83 C4 06  add sp, 0x6
            L0044: return; // RETURN;
        }

        private void FnHELLMES_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L0016: if (JumpNotEqual) goto L0044;
            L0018: ShowMessage(player, String078E); // Violent waves of lava cascade against the astral shores as fire and brimstone fly in Pluthros' throne room.
            L0025: ShowMessage(player, String07FA); // This is a semblance of the plane Ashakkar!
            L0032: PushStack(player, 0x01);
            L0036: PushStack(player, ax);
            L0037: PushStack(player, 0x03);
031A  003B C4 5E 06  les bx, [bp+0x6]
031D  003E 26 FF 1F  call far word [es:bx]
0320  0041 83 C4 06  add sp, 0x6
            L0044: return; // RETURN;
        }

        private void FnELMNTMES_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L0016: if (JumpNotEqual) goto L0044;
            L0018: ShowMessage(player, String0825); // The four corners of creation scorn at each other in Malos' domain.
            L0025: ShowMessage(player, String0868); // This is a semblance of the Elemental Plane.
            L0032: PushStack(player, 0x01);
            L0036: PushStack(player, ax);
            L0037: PushStack(player, 0x03);
0360  003B C4 5E 06  les bx, [bp+0x6]
0363  003E 26 FF 1F  call far word [es:bx]
0366  0041 83 C4 06  add sp, 0x6
            L0044: return; // RETURN;
        }

        private void FnBLOCKWAL_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0020: ShowMessage(player, String0894); // Turbulent forces impede you from going any further in this direction.
            L002D: return; // RETURN;
        }

        private void FnLUREMESZ_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String08DA); // You can just make out a distant plane ahead of you...perhaps you can reach it through here.
            L0010: return; // RETURN;
        }

        private void FnPHYSTAT_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0936); // A maginficent likeness of some powerful demigod stands here as guardian to this chamber.
            L0010: return; // RETURN;
        }

        private void FnELMNTALT_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
03C1  0003 C4 5E 06  les bx, [bp+0x6]
03C4  0006 26 FF 9F C8 00  call far word [es:bx+0xc8]
            L000B: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L001F: if (JumpEqual) goto L0024;
            L0021: goto L00DD;
            L0024: RefreshCompareFlags(GetFlag(player, 0x02, 0x8F));
            L0037: if (JumpNotEqual) goto L006D;
            L0039: ShowMessage(player, String098F); // Malos weaves magical mists as he speaks at you, 'You dare to challenge the Guardian of the Elements! I shall not be so easy to defeat!
            L0046: ShowMessage(player, String0A16); // My ring shall be yours if you can conquer the Elements!'
0411  0053 FF 76 08  push word [bp+0x8]
0414  0056 FF 76 06  push word [bp+0x6]
0417  0059 0E     push cs
0418  005A E8 33 0C  call 0xc90
            L005D: // NOP
            L005E: cx = PopStack(player);
            L005F: cx = PopStack(player);
041E  0060 FF 76 08  push word [bp+0x8]
0421  0063 FF 76 06  push word [bp+0x6]
0424  0066 0E     push cs
0425  0067 E8 7A 0C  call 0xce4
            L006A: // NOP
            L006B: cx = PopStack(player);
            L006C: cx = PopStack(player);
            L006D: Compare(PartyCount(player), 0x0001);
            L0078: if (JumpEqual) goto L0081;
            L007A: Compare(ax, 0x0002);
            L007D: if (JumpEqual) goto L0095;
            L007F: goto L00B0;
            L0081: AddEncounter(player, 0x01, 0x23);
            L0093: goto L00EA;
            L0095: AddEncounter(player, 0x01, 0x26);
            L00A7: PushStack(player, 0x23);
0469  00AB B8 05 00  mov ax, 0x5
            L00AE: goto L0088;
            L00B0: AddEncounter(player, 0x01, 0x26);
            L00C2: AddEncounter(player, 0x02, 0x06);
            L00D4: PushStack(player, 0x23);
0496  00D8 B8 06 00  mov ax, 0x6
            L00DB: goto L0088;
            L00DD: ShowMessage(player, String0A4F); // The Dralkarian Lord of the Elements is not here.
            L00EA: return; // RETURN;
        }

        private void FnHEVALTAR_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetAlignment(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0062;
            L0010: Compare(GetGuild(player), 0x0005);
            L001A: if (JumpNotEqual) goto L0028;
            L001C: Compare(GetGuild(player), 0x0004);
            L0026: if (JumpEqual) goto L0046;
04D2  0028 C4 5E 06  les bx, [bp+0x6]
04D5  002B 26 FF 5F 40  call far word [es:bx+0x40]
04D9  002F C4 5E 06  les bx, [bp+0x6]
04DC  0032 26 FF 9F C8 00  call far word [es:bx+0xc8]
            L0037: ShowMessage(player, String0A80); // Juvalad strips you of the ability to use magic! Your alignment opposes his own!
            L0044: goto L0062;
            L0046: ShowMessage(player, String0AD0); // Your alignment has weakened your magic; but your devotion lets you retain your spells, your skills though are useless!
04FD  0053 C4 5E 06  les bx, [bp+0x6]
0500  0056 26 FF 9F C8 00  call far word [es:bx+0xc8]
0505  005B C4 5E 06  les bx, [bp+0x6]
0508  005E 26 FF 5F 3C  call far word [es:bx+0x3c]
            L0062: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0076: if (JumpEqual) goto L007B;
            L0078: goto L0127;
            L007B: RefreshCompareFlags(GetFlag(player, 0x02, 0x8E));
            L008E: if (JumpNotEqual) goto L00B7;
            L0090: ShowMessage(player, String0B47); // Juvalad rises before you, 'Foul fool! Do you not know death, when you see it? Die now and curse in vain!'
0547  009D FF 76 08  push word [bp+0x8]
054A  00A0 FF 76 06  push word [bp+0x6]
054D  00A3 0E     push cs
054E  00A4 E8 51 0B  call 0xbf8
            L00A7: // NOP
            L00A8: cx = PopStack(player);
            L00A9: cx = PopStack(player);
0554  00AA FF 76 08  push word [bp+0x8]
0557  00AD FF 76 06  push word [bp+0x6]
055A  00B0 0E     push cs
055B  00B1 E8 F0 0A  call 0xba4
            L00B4: // NOP
            L00B5: cx = PopStack(player);
            L00B6: cx = PopStack(player);
            L00B7: Compare(PartyCount(player), 0x0001);
            L00C2: if (JumpEqual) goto L00CB;
            L00C4: Compare(ax, 0x0002);
            L00C7: if (JumpEqual) goto L00DF;
            L00C9: goto L00FA;
            L00CB: AddEncounter(player, 0x01, 0x24);
            L00DD: goto L0134;
            L00DF: AddEncounter(player, 0x01, 0x26);
            L00F1: PushStack(player, 0x24);
059F  00F5 B8 05 00  mov ax, 0x5
            L00F8: goto L00D2;
            L00FA: AddEncounter(player, 0x01, 0x26);
            L010C: AddEncounter(player, 0x02, 0x06);
            L011E: PushStack(player, 0x24);
05CC  0122 B8 06 00  mov ax, 0x6
            L0125: goto L00D2;
            L0127: ShowMessage(player, String0BB1); // The Dralkarian Lord of Enakkar is not here.
            L0134: return; // RETURN;
        }

        private void FnHELALTAR_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetAlignment(player));
            L000D: if (JumpNotEqual) goto L006E;
            L000F: ShowMessage(player, String0BDD); // Your alignment opposes Pluthros'!
            L001C: Compare(GetGuild(player), 0x0005);
            L0026: if (JumpNotEqual) goto L0034;
            L0028: Compare(GetGuild(player), 0x0004);
            L0032: if (JumpEqual) goto L0052;
0614  0034 C4 5E 06  les bx, [bp+0x6]
0617  0037 26 FF 5F 40  call far word [es:bx+0x40]
061B  003B C4 5E 06  les bx, [bp+0x6]
061E  003E 26 FF 9F C8 00  call far word [es:bx+0xc8]
            L0043: ShowMessage(player, String0BFF); // For that, he strips your ability to use magic! 
            L0050: goto L006E;
            L0052: ShowMessage(player, String0C2F); // For that, he has weakened your magic; but your devotion let's you retain your spells! Your skills, however, are useless!
063F  005F C4 5E 06  les bx, [bp+0x6]
0642  0062 26 FF 9F C8 00  call far word [es:bx+0xc8]
0647  0067 C4 5E 06  les bx, [bp+0x6]
064A  006A 26 FF 5F 3C  call far word [es:bx+0x3c]
            L006E: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0082: if (JumpEqual) goto L0087;
            L0084: goto L0140;
            L0087: RefreshCompareFlags(GetFlag(player, 0x02, 0x9C));
            L009A: if (JumpNotEqual) goto L00D0;
            L009C: ShowMessage(player, String0CA8); // Pluthros offers a resonating cry as you approach, 'You do not know of the prophecies! You are not one of the followers!
            L00A9: ShowMessage(player, String0D20); // Now I shall teach you the price of incredulity!'
0696  00B6 FF 76 08  push word [bp+0x8]
0699  00B9 FF 76 06  push word [bp+0x6]
069C  00BC 0E     push cs
069D  00BD E8 AE 09  call 0xa6e
            L00C0: // NOP
            L00C1: cx = PopStack(player);
            L00C2: cx = PopStack(player);
06A3  00C3 FF 76 08  push word [bp+0x8]
06A6  00C6 FF 76 06  push word [bp+0x6]
06A9  00C9 0E     push cs
06AA  00CA E8 F5 09  call 0xac2
            L00CD: // NOP
            L00CE: cx = PopStack(player);
            L00CF: cx = PopStack(player);
            L00D0: Compare(PartyCount(player), 0x0001);
            L00DB: if (JumpEqual) goto L00E4;
            L00DD: Compare(ax, 0x0002);
            L00E0: if (JumpEqual) goto L00F8;
            L00E2: goto L0113;
            L00E4: AddEncounter(player, 0x01, 0x22);
            L00F6: goto L014D;
            L00F8: AddEncounter(player, 0x01, 0x26);
            L010A: PushStack(player, 0x22);
06EE  010E B8 05 00  mov ax, 0x5
            L0111: goto L00EB;
            L0113: AddEncounter(player, 0x01, 0x26);
            L0125: AddEncounter(player, 0x02, 0x06);
            L0137: PushStack(player, 0x22);
071B  013B B8 06 00  mov ax, 0x6
            L013E: goto L00EB;
            L0140: ShowMessage(player, String0D51); // The Dralkarian Lord of Ashakkar is not here.
            L014D: return; // RETURN;
        }

        private void FnASTRLALT_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0017: if (JumpEqual) goto L001C;
            L0019: goto L00C8;
            L001C: RefreshCompareFlags(GetFlag(player, 0x02, 0x8D));
            L002F: if (JumpNotEqual) goto L0058;
            L0031: ShowMessage(player, String0D7E); // Astelligus roars as you near his throne room, 'Damn you to Ashakkar! Your intrusion shall be short lived! I shall send you on your way to the next life!'
076D  003E FF 76 08  push word [bp+0x8]
0770  0041 FF 76 06  push word [bp+0x6]
0773  0044 0E     push cs
0774  0045 E8 2B 09  call 0x973
            L0048: // NOP
            L0049: cx = PopStack(player);
            L004A: cx = PopStack(player);
077A  004B FF 76 08  push word [bp+0x8]
077D  004E FF 76 06  push word [bp+0x6]
0780  0051 0E     push cs
0781  0052 E8 CA 08  call 0x91f
            L0055: // NOP
            L0056: cx = PopStack(player);
            L0057: cx = PopStack(player);
            L0058: Compare(PartyCount(player), 0x0001);
            L0063: if (JumpEqual) goto L006C;
            L0065: Compare(ax, 0x0002);
            L0068: if (JumpEqual) goto L0080;
            L006A: goto L009B;
            L006C: AddEncounter(player, 0x01, 0x21);
            L007E: goto L00D5;
            L0080: AddEncounter(player, 0x01, 0x26);
            L0092: PushStack(player, 0x21);
07C5  0096 B8 05 00  mov ax, 0x5
            L0099: goto L0073;
            L009B: AddEncounter(player, 0x01, 0x26);
            L00AD: AddEncounter(player, 0x02, 0x06);
            L00BF: PushStack(player, 0x21);
07F2  00C3 B8 06 00  mov ax, 0x6
            L00C6: goto L0073;
            L00C8: ShowMessage(player, String0E18); // The Dralkarian Lord of the Astral plane is not here.
            L00D5: return; // RETURN;
        }

        private void FnENTRNPRT_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0E4D); // A glowing portal here will send you back to the Main Entrance. You will not be able to return lest you traverse the pathway here again!
            L0010: PushStack(player, 0x03);
            L0014: PushStack(player, 0x0E);
            L0018: PushStack(player, 0x01);
            L001C: PushStack(player, ax);
0828  001D C4 5E 06  les bx, [bp+0x6]
082B  0020 26 FF 9F BC 00  call far word [es:bx+0xbc]
0830  0025 83 C4 08  add sp, 0x8
            L0028: return; // RETURN;
        }

        private void FnTOANTECH_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0838  0003 83 EC 08  sub sp, 0x8
083B  0006 56     push si
083C  0007 57     push di
            L0008: ax = GetCurrentTile(player);
0844  000F 89 46 F8  mov [bp-0x8], ax
0847  0012 B9 05 00  mov cx, 0x5
            L0015: bx = 0x096A;
084D  0018 2E 8B 07  mov ax, [cs:bx]
0850  001B 3B 46 F8  cmp ax, [bp-0x8]
            L001E: if (JumpEqual) goto L0026;
0855  0020 43     inc bx
0856  0021 43     inc bx
0857  0022 E2 F4  loop 0x18
            L0024: goto L0082;
085B  0026 2E FF 67 0A  jmp word [cs:bx+0xa]
            L002A: si = 0x008C;
            L002D: di = 0x000E;
0865  0030 C7 46 FE 2E 00  mov word [bp-0x2], 0x2e
086A  0035 C7 46 FC 03 00  mov word [bp-0x4], 0x3
086F  003A C7 46 FA 01 00  mov word [bp-0x6], 0x1
            L003F: goto L0082;
            L0041: si = 0x008D;
            L0044: di = 0x0098;
087C  0047 C7 46 FE B8 00  mov word [bp-0x2], 0xb8
            L004C: goto L0035;
            L004E: si = 0x008E;
            L0051: di = 0x0001;
0889  0054 C7 46 FE 02 00  mov word [bp-0x2], 0x2
            L0059: goto L0035;
            L005B: si = 0x009C;
            L005E: di = 0x00FE;
0896  0061 C7 46 FE EF 00  mov word [bp-0x2], 0xef
089B  0066 C7 46 FC 01 00  mov word [bp-0x4], 0x1
            L006B: goto L007D;
            L006D: si = 0x008F;
            L0070: di = 0x00A0;
08A8  0073 C7 46 FE D2 00  mov word [bp-0x2], 0xd2
08AD  0078 C7 46 FC 00 00  mov word [bp-0x4], 0x0
08B2  007D C7 46 FA 03 00  mov word [bp-0x6], 0x3
            L0082: Compare(PartyCount(player), 0x0001);
            L008D: if (JumpNotEqual) goto L00F7;
08C4  008F 56     push si
            L0090: PushStack(player, 0x02);
08C9  0094 C4 5E 06  les bx, [bp+0x6]
08CC  0097 26 FF 5F 04  call far word [es:bx+0x4]
            L009B: cx = PopStack(player);
            L009C: cx = PopStack(player);
            L009D: RefreshCompareFlags(ax);
            L009F: if (JumpEqual) goto L00B4;
08D6  00A1 56     push si
            L00A2: PushStack(player, 0x02);
08DB  00A6 C4 5E 06  les bx, [bp+0x6]
08DE  00A9 26 FF 5F 04  call far word [es:bx+0x4]
            L00AD: cx = PopStack(player);
            L00AE: cx = PopStack(player);
            L00AF: Compare(ax, 0x0002);
            L00B2: if (JumpNotEqual) goto L00F7;
08E9  00B4 56     push si
            L00B5: PushStack(player, 0x02);
08EE  00B9 C4 5E 06  les bx, [bp+0x6]
08F1  00BC 26 FF 5F 04  call far word [es:bx+0x4]
            L00C0: cx = PopStack(player);
            L00C1: cx = PopStack(player);
            L00C2: RefreshCompareFlags(ax);
            L00C4: if (JumpNotEqual) goto L00DB;
            L00C6: SetFlag(player, 0x03, 0x02, 0x01);
0910  00DB FF 76 FC  push word [bp-0x4]
0913  00DE 57     push di
            L00DF: PushStack(player, 0x04);
            L00E3: PushStack(player, 0x0B);
091C  00E7 C4 5E 06  les bx, [bp+0x6]
091F  00EA 26 FF 9F BC 00  call far word [es:bx+0xbc]
0924  00EF 83 C4 08  add sp, 0x8
0927  00F2 B8 D5 0E  mov ax, 0xed5
            L00F5: goto L0125;
            L00F7: Compare(PartyCount(player), 0x0001);
            L0102: if (JumpBelowOrEqual) goto L0122;
0939  0104 FF 76 FA  push word [bp-0x6]
093C  0107 FF 76 FE  push word [bp-0x2]
            L010A: PushStack(player, 0x04);
            L010E: PushStack(player, 0x0B);
0947  0112 C4 5E 06  les bx, [bp+0x6]
094A  0115 26 FF 9F BC 00  call far word [es:bx+0xbc]
094F  011A 83 C4 08  add sp, 0x8
0952  011D B8 4A 0F  mov ax, 0xf4a
            L0120: goto L0125;
            L0122: ShowMessage(player, String0F7D); // Nothing happens.
0964  012F 5F     pop di
0965  0130 5E     pop si
            L0131: // restore stack ptr: sp = bp;
            L0133: return; // RETURN;
            // Extra data: 11 00 1E 00 A8 00 E1 00 FF 00 83 08 5F 08 76 08 A2 08 90 08 
        }

        private void FnTHEBECK_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0981  0003 83 EC 0A  sub sp, 0xa
0984  0006 56     push si
0985  0007 57     push di
            L0008: ax = GetCurrentTile(player);
098D  000F 89 46 FA  mov [bp-0x6], ax
0990  0012 B9 05 00  mov cx, 0x5
            L0015: bx = 0x0B54;
0996  0018 2E 8B 07  mov ax, [cs:bx]
0999  001B 3B 46 FA  cmp ax, [bp-0x6]
            L001E: if (JumpEqual) goto L0026;
099E  0020 43     inc bx
099F  0021 43     inc bx
09A0  0022 E2 F4  loop 0x18
            L0024: goto L0073;
09A4  0026 2E FF 67 0A  jmp word [cs:bx+0xa]
            L002A: si = 0x00EF;
            L002D: di = 0x0003;
09AE  0030 C7 46 FE 10 00  mov word [bp-0x2], 0x10
            L0035: goto L006E;
            L0037: si = 0x00C6;
            L003A: di = 0x0002;
09BB  003D C7 46 FE F1 00  mov word [bp-0x2], 0xf1
09C0  0042 C7 46 FC 03 00  mov word [bp-0x4], 0x3
            L0047: goto L0073;
            L0049: si = 0x00C9;
            L004C: di = 0x0002;
09CD  004F C7 46 FE AF 00  mov word [bp-0x2], 0xaf
            L0054: goto L0042;
            L0056: si = 0x00CA;
            L0059: di = 0x0002;
09DA  005C C7 46 FE 28 00  mov word [bp-0x2], 0x28
            L0061: goto L0042;
            L0063: si = 0x00EE;
            L0066: di = 0x0003;
09E7  0069 C7 46 FE F0 00  mov word [bp-0x2], 0xf0
09EC  006E C7 46 FC 02 00  mov word [bp-0x4], 0x2
            L0073: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0087: if (JumpEqual) goto L008C;
            L0089: goto L0130;
0A0A  008C 56     push si
0A0B  008D C4 5E 06  les bx, [bp+0x6]
0A0E  0090 26 FF 5F 50  call far word [es:bx+0x50]
            L0094: cx = PopStack(player);
            L0095: RefreshCompareFlags(ax);
            L0097: if (JumpEqual) goto L00B6;
            L0099: ShowMessage(player, String0F8E); // In front of you sits an enormous throne, where one of the Dralkarians ponders Fate.
            L00A6: ShowMessage(player, String0FE2); // As he notices you, he spots something you're carrying and beckons you forth with an evil grin.
            L00B3: goto L01A8;
            L00B6: ax = GetCurrentTile(player);
0A3B  00BD 89 46 F8  mov [bp-0x8], ax
0A3E  00C0 B9 05 00  mov cx, 0x5
            L00C3: bx = 0x0B40;
0A44  00C6 2E 8B 07  mov ax, [cs:bx]
0A47  00C9 3B 46 F8  cmp ax, [bp-0x8]
            L00CC: if (JumpEqual) goto L00D4;
0A4C  00CE 43     inc bx
0A4D  00CF 43     inc bx
0A4E  00D0 E2 F4  loop 0xc6
            L00D2: goto L0106;
0A52  00D4 2E FF 67 0A  jmp word [cs:bx+0xa]
0A56  00D8 B8 41 10  mov ax, 0x1041
            L00DB: goto L00FC;
0A5B  00DD B8 B4 10  mov ax, 0x10b4
            L00E0: goto L00FC;
0A60  00E2 B8 1A 11  mov ax, 0x111a
            L00E5: goto L00FC;
0A65  00E7 B8 B6 11  mov ax, 0x11b6
            L00EA: goto L00FC;
            L00EC: ShowMessage(player, String1235); // Astelligus' voice echoes across the great void:
            L00F9: ShowMessage(player, String1265); // 'Puny mortal...you fail to honor me with the proper artifact. Seek the Nimbus, and return, you will make for interesting prey!'
            L0106: ShowMessage(player, String12E5); // His magics swirl around you and hurl you through a vortex, back to the pathway.
            L0113: DamagePlayer(player, GetCurrentHits(player) + 0xFFF6);
0AA5  0127 FF 76 FC  push word [bp-0x4]
0AA8  012A FF 76 FE  push word [bp-0x2]
0AAB  012D 57     push di
            L012E: goto L0199;
            L0130: ShowMessage(player, String1335); // Away! You've left this domain and re-entered. You must remain here once you've started until you've killed the Dralk or died trying!
            L013D: ShowMessage(player, String13BA); // The Dralk sends you to the entrance of His home!
            L014A: ax = GetCurrentTile(player);
0ACF  0151 89 46 F6  mov [bp-0xa], ax
0AD2  0154 B9 05 00  mov cx, 0x5
            L0157: bx = 0x0B2C;
0AD8  015A 2E 8B 07  mov ax, [cs:bx]
0ADB  015D 3B 46 F6  cmp ax, [bp-0xa]
            L0160: if (JumpEqual) goto L0168;
0AE0  0162 43     inc bx
0AE1  0163 43     inc bx
0AE2  0164 E2 F4  loop 0x15a
            L0166: goto L01A8;
0AE6  0168 2E FF 67 0A  jmp word [cs:bx+0xa]
            L016C: PushStack(player, 0x00);
0AED  016F B8 B5 00  mov ax, 0xb5
            L0172: goto L0194;
            L0174: PushStack(player, 0x02);
0AF6  0178 B8 4B 00  mov ax, 0x4b
            L017B: goto L0194;
            L017D: PushStack(player, 0x00);
0AFE  0180 B8 45 00  mov ax, 0x45
            L0183: goto L0194;
            L0185: PushStack(player, 0x02);
0B07  0189 B8 BB 00  mov ax, 0xbb
            L018C: goto L0194;
            L018E: TeleportParty(player, 0x0B, 0x04, 0x7D, 0x00, isForwardMove);
0B26  01A8 5F     pop di
0B27  01A9 5E     pop si
            L01AA: // restore stack ptr: sp = bp;
            L01AC: return; // RETURN;
            // Extra data: 01 00 0E 00 78 00 A0 00 FE 00 FB 0A F2 0A 0C 0B EA 0A 03 0B 01 00 0E 00 78 00 A0 00 FE 00 65 0A 56 0A 6A 0A 60 0A 5B 0A 01 00 0E 00 78 00 A0 00 FE 00 D4 09 A8 09 E1 09 C7 09 B5 09 
        }

        private void FnSTATBLCK_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFloorPassable(player, 0x00, GetCurrentTile(player));
            L0017: return; // RETURN;
        }

        private void FnASTRLMES_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L0016: if (JumpNotEqual) goto L0044;
            L0018: ShowMessage(player, String13EB); // An enormous void of darkness and surreal images haunts your vision now that you've stepped into a piece of Astelligus' home.
            L0025: ShowMessage(player, String1468); // This is a semblance of the Astral plane.
            L0032: PushStack(player, 0x01);
            L0036: PushStack(player, ax);
            L0037: PushStack(player, 0x03);
0BBC  003B C4 5E 06  les bx, [bp+0x6]
0BBF  003E 26 FF 1F  call far word [es:bx]
0BC2  0041 83 C4 06  add sp, 0x6
            L0044: return; // RETURN;
        }

        private void FnPHYSALTR_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0005);
            L000D: if (JumpEqual) goto L0033;
            L000F: Compare(GetGuild(player), 0x0004);
            L0019: if (JumpEqual) goto L0033;
            L001B: Compare(GetGuild(player), 0x0002);
            L0025: if (JumpEqual) goto L0033;
            L0027: Compare(GetGuild(player), 0x0003);
            L0031: if (JumpNotEqual) goto L0042;
            L0033: ShowMessage(player, String1491); // Your prowess with magic allows you to retain your abilities; but not to restore your mana!!!
            L0040: goto L0056;
            L0042: ShowMessage(player, String14EE); // Your magical powers are feeble and lack the discipline of a Wizard or Cleric. Your magics are useless here!
0C16  004F C4 5E 06  les bx, [bp+0x6]
0C19  0052 26 FF 5F 40  call far word [es:bx+0x40]
0C1D  0056 C4 5E 06  les bx, [bp+0x6]
0C20  0059 26 FF 9F C8 00  call far word [es:bx+0xc8]
            L005E: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0072: if (JumpEqual) goto L0077;
            L0074: goto L0123;
            L0077: RefreshCompareFlags(GetFlag(player, 0x02, 0x8C));
            L008A: if (JumpNotEqual) goto L00B3;
            L008C: ShowMessage(player, String155A); // Corpeus is here. His voice shakes the great hall: 'Puny mortal. You dare come to challenge me? For my ring, you must take my life. For your attempt, I will take yours!'
0C60  0099 FF 76 08  push word [bp+0x8]
0C63  009C FF 76 06  push word [bp+0x6]
0C66  009F 0E     push cs
0C67  00A0 E8 E4 03  call 0x487
            L00A3: // NOP
            L00A4: cx = PopStack(player);
            L00A5: cx = PopStack(player);
0C6D  00A6 FF 76 08  push word [bp+0x8]
0C70  00A9 FF 76 06  push word [bp+0x6]
0C73  00AC 0E     push cs
0C74  00AD E8 2B 04  call 0x4db
            L00B0: // NOP
            L00B1: cx = PopStack(player);
            L00B2: cx = PopStack(player);
            L00B3: Compare(PartyCount(player), 0x0001);
            L00BE: if (JumpEqual) goto L00C7;
            L00C0: Compare(ax, 0x0002);
            L00C3: if (JumpEqual) goto L00DB;
            L00C5: goto L00F6;
            L00C7: AddEncounter(player, 0x01, 0x25);
            L00D9: goto L0130;
            L00DB: AddEncounter(player, 0x01, 0x26);
            L00ED: PushStack(player, 0x25);
0CB8  00F1 B8 05 00  mov ax, 0x5
            L00F4: goto L00CE;
            L00F6: AddEncounter(player, 0x01, 0x26);
            L0108: AddEncounter(player, 0x02, 0x06);
            L011A: PushStack(player, 0x25);
0CE5  011E B8 06 00  mov ax, 0x6
            L0121: goto L00CE;
            L0123: ShowMessage(player, String1603); // The Dralkarian Lord of the Physical plane is not here.
            L0130: return; // RETURN;
        }

        private void FnTHEGIFT_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
0CFE  0005 56     push si
0CFF  0006 57     push di
            L0007: ax = GetCurrentTile(player);
0D07  000E 89 46 FE  mov [bp-0x2], ax
0D0A  0011 B9 05 00  mov cx, 0x5
            L0014: bx = 0x0DDE;
0D10  0017 2E 8B 07  mov ax, [cs:bx]
0D13  001A 3B 46 FE  cmp ax, [bp-0x2]
            L001D: if (JumpEqual) goto L0025;
0D18  001F 43     inc bx
0D19  0020 43     inc bx
0D1A  0021 E2 F4  loop 0x17
            L0023: goto L004F;
0D1E  0025 2E FF 67 0A  jmp word [cs:bx+0xa]
            L0029: si = 0x008D;
            L002C: di = 0x00EE;
            L002F: goto L004F;
            L0031: si = 0x008C;
            L0034: di = 0x00EF;
            L0037: goto L004F;
            L0039: si = 0x008E;
            L003C: di = 0x00CA;
            L003F: goto L004F;
            L0041: si = 0x008F;
            L0044: di = 0x00C9;
            L0047: goto L004F;
            L0049: si = 0x009C;
            L004C: di = 0x00C6;
            L004F: ax = HasItem(player, 0xE9);
            L005D: if (JumpEqual) goto L00AD;
0D58  005F 56     push si
            L0060: PushStack(player, 0x02);
0D5D  0064 C4 5E 06  les bx, [bp+0x6]
0D60  0067 26 FF 5F 04  call far word [es:bx+0x4]
            L006B: cx = PopStack(player);
            L006C: cx = PopStack(player);
            L006D: RefreshCompareFlags(ax);
            L006F: if (JumpNotEqual) goto L00AD;
0D6A  0071 57     push di
0D6B  0072 C4 5E 06  les bx, [bp+0x6]
0D6E  0075 26 FF 5F 4C  call far word [es:bx+0x4c]
            L0079: cx = PopStack(player);
            L007A: AddExperience(player, 0x001312D0);
            L008C: ShowMessage(player, String163A); // The mystical device that aided you in the demise of this Dralk has also vanished!
            L0099: PushStack(player, 0x01);
0D96  009D 56     push si
            L009E: PushStack(player, 0x02);
0D9B  00A2 C4 5E 06  les bx, [bp+0x6]
0D9E  00A5 26 FF 1F  call far word [es:bx]
0DA1  00A8 83 C4 06  add sp, 0x6
            L00AB: goto L00D2;
0DA6  00AD 56     push si
            L00AE: PushStack(player, 0x02);
0DAB  00B2 C4 5E 06  les bx, [bp+0x6]
0DAE  00B5 26 FF 5F 04  call far word [es:bx+0x4]
            L00B9: cx = PopStack(player);
            L00BA: cx = PopStack(player);
            L00BB: Compare(ax, 0x0002);
            L00BE: if (JumpNotEqual) goto L00C5;
0DB9  00C0 B8 8C 16  mov ax, 0x168c
            L00C3: goto L00C8;
            L00C5: ShowMessage(player, String16D1); // You must continue, for the Dralk's ring and his embodiment are gone from here.
0DCB  00D2 FF 76 08  push word [bp+0x8]
0DCE  00D5 FF 76 06  push word [bp+0x6]
0DD1  00D8 0E     push cs
0DD2  00D9 E8 AD 02  call 0x389
            L00DC: // NOP
            L00DD: cx = PopStack(player);
            L00DE: cx = PopStack(player);
0DD8  00DF 5F     pop di
0DD9  00E0 5E     pop si
            L00E1: // restore stack ptr: sp = bp;
            L00E3: return; // RETURN;
            // Extra data: 00 00 0F 00 68 00 A1 00 EE 00 32 0D 2A 0D 22 0D 3A 0D 42 0D 
        }

        private void FnQUEENAEO_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
0DF7  0005 C4 5E 06  les bx, [bp+0x6]
0DFA  0008 26 FF 5F 40  call far word [es:bx+0x40]
            L000C: dx = GetFlag(player, 0x02, 0x8D) + GetFlag(player, 0x02, 0x9C);
            L0032: dx = dx + GetFlag(player, 0x02, 0x8F);
            L0047: dx = dx + GetFlag(player, 0x02, 0x8E);
            L005C: dx = dx + GetFlag(player, 0x02, 0x8C);
            L0071: tmp = dx;
            L0074: ax = HasItem(player, 0xE9);
            L0082: if (JumpNotEqual) goto L0087;
            L0084: goto L01AA;
            L0087: RemoveItem(player, 0xE9);
            L0093: AddExperience(player, 0x000F4240);
            L00A5: Compare(tmp, 0xFE);
            L00A9: if (JumpGreater) goto L00D8;
            L00AB: ShowPortrait(player, 0x0015);
            L00B8: ShowMessage(player, String1720); // 'My Great Champion! You've returned one of the Dralk's Rings! This will ensure us the power to enter the final phase of this most grand design!
            L00C5: ShowMessage(player, String17B0); // With each ring, I can use its power to increase your wisdom. Reap the benefits of the services you have sewn!
0EC4  00D2 B8 1E 18  mov ax, 0x181e
            L00D5: goto L01BA;
            L00D8: ShowPortrait(player, 0x0015);
            L00E5: ShowMessage(player, String18AD); // As the Queen takes the fifth ring from your grasp, the forces here explode in a violent shockwave, throwing you to the ground.
            L00F2: ShowMessage(player, String192C); // Aeowyn is absorbed in a fiery light of pure magic, she hovers and offers an evil laugh!
            L00FF: ShowMessage(player, String1984); // 'Did you truly believe I would share the greatest triumph with you! Your powers are no match for mine now! Away with you! Your faith in my friendship was your weakness! I alone shall breach The Gateway; I alone shall enter the next phase!'
            L010C: ShowMessage(player, String1A74); // Driven mad with power, Aeowyn hurls untamed forces upon you, stripping away parts of your attributes! A blast explodes on the southern wall, where a teleport will allow you escape.
            L0119: ShowMessage(player, String1B29); // The mad Queen, then dissipates into nothingness, only her evil laughter echoing as she heads off to The Gateway.
            L0126: ax = GetCurrentHits(player);
            L012D: bx = 0x0002;
            L0130: dx = ax % bx; ax = ax / bx;
            L0133: DamagePlayer(player, ax);
            L013D: RemoveItem(player, 0xF0);
            L0149: RefreshCompareFlags(GetFlag(player, 0x02, 0xDF));
            L015C: if (JumpNotEqual) goto L01C4;
            L015E: ModifyAttribute(player, 0x00, 0xFFFF);
            L016F: ModifyAttribute(player, 0x02, 0xFFFE);
            L0181: ModifyAttribute(player, 0x03, 0xFFFE);
            L0193: SetFlag(player, 0x02, 0xDF, 0x01);
            L01A8: goto L01C4;
            L01AA: ShowMessage(player, String1B9A); // 'My Champion, you must return the Dralks' rings to me! Without them we will never be able to enter the ultimate goal of our Quest!'
            L01B7: ShowMessage(player, String1C1E); // The Queen conjurs a gateway behind you. 'Take this to the entrance, and try again! I will be here as long as possible...' She then returns to her magics and dismisses you.
            L01C4: // restore stack ptr: sp = bp;
            L01C6: return; // RETURN;
        }

        private void FnQUENTEXT_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1CCA); // Her Majesty hovers before you in a misty hue of grey-blue smoke. She is conjuring powerful forces to hold her presence here!
            L0010: ShowMessage(player, String1D47); // Approach her to the north, and report!
            L001D: return; // RETURN;
        }

        private void FnTOMAINEN_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1D6E); // This shall lead you out.
            L0010: PushStack(player, 0x01);
            L0014: PushStack(player, 0x03);
            L0018: PushStack(player, 0x01);
            L001C: PushStack(player, ax);
0FF6  001D C4 5E 06  les bx, [bp+0x6]
0FF9  0020 26 FF 9F BC 00  call far word [es:bx+0xbc]
0FFE  0025 83 C4 08  add sp, 0x8
            L0028: return; // RETURN;
        }

        private void Fn_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: return; // RETURN;
            // Extra data: 55 8B EC B8 40 0D 50 33 C0 50 50 50 50 B8 E9 00 50 C4 5E 06 26 FF 9F D8 00 83 C4 0C 5D CB 55 8B EC B8 01 00 50 50 33 C0 50 C4 5E 06 26 FF 1F 83 C4 06 5D CB 55 8B EC B8 03 00 50 B8 38 00 50 B8 04 00 50 B8 0B 00 50 C4 5E 06 26 FF 9F BC 00 83 C4 08 5D CB 55 8B EC B8 87 1D 50 C4 5E 06 26 FF 9F F8 00 59 B8 D8 1D 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 
        }

    }
}
