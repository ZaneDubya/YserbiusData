#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Twinion.Maps {
    class TwMap21 : AMapScripted {
        protected override int MapIndex => 21;
        protected override int RandomEncounterChance => 0;
        protected override int RandomEncounterExtraCount => 0;

        public TwMap21() {
            MapEvent01 = FnTELEA_01;
            MapEvent02 = FnTELEB_02;
            MapEvent03 = FnTELEC_03;
            MapEvent04 = FnTELED_04;
            MapEvent05 = FnTELEE_05;
            MapEvent06 = FnTELEF_06;
            MapEvent07 = FnBANQUET_07;
            MapEvent08 = FnINSTRUC_08;
            MapEvent09 = FnGUARD_09;
            MapEvent0A = FnLIBRARY_0A;
            MapEvent0B = FnADMIN_0B;
            MapEvent0C = FnFLAGCK_0C;
            MapEvent0D = FnTEXTA_0D;
            MapEvent0E = FnHOMEA_0E;
            MapEvent10 = FnTEXTB_10;
            MapEvent11 = FnHOMEB_11;
            MapEvent12 = FnHERB_12;
            MapEvent13 = FnTEXTC_13;
            MapEvent14 = FnCLUEC_14;
            MapEvent15 = FnTXT_15;
            MapEvent16 = FnCLUEE_16;
            MapEvent17 = FnLAVA_17;
            MapEvent18 = FnPIT_18;
            MapEvent19 = FnWATER_19;
            MapEvent1A = FnHERBTXT_1A;
            MapEvent1B = FnILL_1B;
            MapEvent1C = FnSECA_1C;
            MapEvent1E = FnALCHEMY_1E;
            MapEvent1F = FnARMORY_1F;
            MapEvent20 = FnGENERAL_20;
            MapEvent21 = FnMAGIC_21;
            MapEvent22 = FnBONUSA_22;
            MapEvent23 = FnBONUSB_23;
            MapEvent24 = FnMANAZAP_24;
            MapEvent25 = FnNISYM_25;
            MapEvent26 = FnINN_26;
            MapEvent27 = FnITEMC_27;
            MapEvent28 = FnWIZARD_28;
            MapEvent29 = FnFLAGDOOR_29;
            MapEvent2A = FnITEMB_2A;
            MapEvent2B = FnITEMA_2B;
            MapEvent2C = FnSPELL_2C;
            MapEvent2D = FnSKILL_2D;
            MapEvent2E = FnPRIESTSS_2E;
            MapEvent2F = FnGEADCLUE_2F;
            MapEvent30 = FnSETBA_30;
            MapEvent31 = FnSETBB_31;
            MapEvent32 = FnSETBC_32;
            MapEvent33 = FnSECBD_33;
            MapEvent34 = FnSETBE_34;
            MapEvent35 = FnSETBF_35;
            MapEvent36 = FnSETBG_36;
            MapEvent37 = FnSETBH_37;
            MapEvent38 = FnPARTYCT_38;
            MapEvent39 = FnSTRIP_39;
            MapEvent3A = FnNOENTER_3A;
        }
        
        // === Strings ================================================
        private const string String03FC = "All ye who enter here, abandon hope.";
        private const string String0421 = "This portal has markings similar to the great dragon's lair above.";
        private const string String0464 = "You enter the Cup and Sorcerer banquet hall. Students and instructors dine here.";
        private const string String04B5 = "The classroom is empty.";
        private const string String04CD = "You observe a wise old mage teaching his craft. His lessons are very helpful.";
        private const string String051B = "The guard nods and goes back to his work.";
        private const string String0545 = "The library is silent as students concentrate on their tomes.";
        private const string String0583 = "The administrative clerks are hard at work.";
        private const string String05AF = "The door swings open.";
        private const string String05C5 = "A note on the door from the town clerk reads:";
        private const string String05F3 = "'Faerlun, I'll be back after lunch.'";
        private const string String0618 = "You throw a few coins into the well for luck.";
        private const string String0646 = "You marvel at the splendor of this wizard's home.";
        private const string String0678 = "To the west is the Alchemy Shop; to the east, the Armory.";
        private const string String06B2 = "You enter a modest home.";
        private const string String06CB = "You pass a resident tending the garden where the wizards grow ingredients for their spells.";
        private const string String0727 = "To the west you see the General Store; to the east, the Magic Shop.";
        private const string String076B = "A sign reads -";
        private const string String077A = "'See the town clerk for information on training.'";
        private const string String07AC = "Hocus Pocus Stables";
        private const string String07C0 = "A plaque reads -";
        private const string String07D1 = "'Items at the shops are not free.'";
        private const string String07F4 = "You step into a pool of lava.";
        private const string String0812 = "The pit is bottomless.";
        private const string String0829 = "The mystical waters weaken you.";
        private const string String0849 = "Hocus Pocus Herb Garden";
        private const string String0861 = "A passageway appears.";
        private const string String0877 = "You find nothing you need.";
        private const string String0892 = "The shopkeeper is happy to take your gold.";
        private const string String08BD = "The armorer is busy forging new weapons.";
        private const string String08E6 = "You exchange your gold for weapons.";
        private const string String090A = "The shopkeeper is too busy to help you.";
        private const string String0932 = "You decide on some helpful items.";
        private const string String0954 = "You have already made your purchase.";
        private const string String0979 = "You purchase scrolls.";
        private const string String098F = "The building is empty.";
        private const string String09A6 = "You discover a lost quest bag filled with gold.";
        private const string String09D6 = "The room is empty.";
        private const string String09E9 = "A search yields scrolls.";
        private const string String0A02 = "A strange magical aura drains your mana.";
        private const string String0A2B = "The acolytes of Nisym Temple restore your mana free of charge.";
        private const string String0A6A = "'Welcome to the Talisman Inn. I have taken payment for your accommodations. You will find your health improved after your brief rest.'";
        private const string String0AF1 = "The clerk greets you.";
        private const string String0B07 = "'Hail! I've been expecting you.";
        private const string String0B27 = "Word has been sent to the training area guard. You will now be granted access.'";
        private const string String0B77 = "Ah! You have found my items! Now walk alone through the door to the east for your promised reward.";
        private const string String0BDA = "Try again, my friend. The path is tricky, but very rewarding.";
        private const string String0C18 = "'Hail, brave adventurers!  My name is Faerlun.";
        private const string String0C47 = "What an interesting dragon skin you've found! Let's do a little swap, shall we?";
        private const string String0C97 = "I'll take the skin. You take this gold.";
        private const string String0CBF = "Now that you are here, maybe you can help me find the wing of a bat and eye of a newt.";
        private const string String0D16 = "These items you will find in Hocus Pocus.";
        private const string String0D40 = "By the way, do NOT leave the village until you find them.";
        private const string String0D7A = "Bring them to me and I will show you the way to a challenge of great reward.'";
        private const string String0DC8 = "'Hail, adventurers. My name is Faerlun and I could use some assistance.";
        private const string String0E10 = "For an experiment I am doing, I seek the wing of a bat and the eye of a newt.";
        private const string String0E5E = "Do NOT leave Hocus Pocus until you find these items.";
        private const string String0E93 = "In exchange for your help, I will show you the way to a challenge of great reward.'";
        private const string String0EE7 = "The guard notes your name on the list and allows you access.";
        private const string String0F24 = "You meet Morai, who hands you a vial.";
        private const string String0F4A = "She explains 'I see that you have found the bat wings. Now, this eye of newt will complete Faerlun's needs.'";
        private const string String0FB7 = "You pocket the vial and leave.";
        private const string String0FD6 = "'Take this eye of newt back to Faerlun. It is part of what he needs for his studies.'";
        private const string String102C = "Morai is concentrating on her studies.";
        private const string String1053 = "Keoana greets you. Noticing the eye of newt you carry, she hands you a vial of bat wings.";
        private const string String10AD = "She says, 'Faerlun will be pleased that you have found his ingredients.'";
        private const string String10F6 = "Keoana smiles as you enter.";
        private const string String1112 = "'Faerlun is in need of these bat wings. Please take them to him so that he may complete his studies.'";
        private const string String1178 = "You nod and pocket the vial.";
        private const string String1195 = "Keoana ignores you.";
        private const string String11A9 = "Taemen nods as you pass.";
        private const string String11C2 = "Taemen teaches you the Refresh spell.";
        private const string String11E8 = "Taemen teaches you how to cast the Hail spell.";
        private const string String1217 = "Taemen teaches you the Dissipate spell.";
        private const string String123F = "Saronel nods as you pass through.";
        private const string String1261 = "'Greetings my friends. I am Saronel. I've gotten word that you are doing fine in your studies of the ways of a mage.'";
        private const string String12D7 = "With that he raises his arms and in a flash you sense your defenses improve.";
        private const string String1324 = "'Continue your journey. Hopefully my gift will aid you on your way.'";
        private const string String1369 = "Geadiax nods as you pass.";
        private const string String1383 = "Geadiax congratulates you on successfully completing your challenge.";
        private const string String13C8 = "He raises his arms and magically endows you with the Blast spell and presents you with fine gifts.";
        private const string String142B = "You find the experience most rewarding.";
        private const string String1453 = "He raises his arms and magically endows you with the Martial Arts skill and presents you with a fine gift.";
        private const string String14BE = "He raises his arms and magically endows you with a skill to deflect magic and presents you with fine gifts.";
        private const string String152A = "You open a book which you find on one of the tables.";
        private const string String155F = "'Harken, ye, to the report of a great door maze in Hocus Pocus. Yet unto this day, no one has discovered the hiding place of Geadiax, verily I say unto ye.";
        private const string String15FB = "Tis rumored that he has imprisoned powerful monsters within, to keep the likes such as ye from discovering his whereabouts.'";
        private const string String1678 = "The wizards test what you have learned.";
        private const string String16A0 = "The instructors decide to evaluate your spellcasting abilities.";
        private const string String16E0 = "You prepare to show your instructors what you have learned.";
        private const string String171C = "You are given the chance to practice your spellcasting.";
        private const string String1754 = "The training hall provides you with battles to test your abilities.";
        private const string String1798 = "A stranded Erebus Fiend pounces on you!";
        private const string String17C0 = "You disturb a secret meeting.";
        private const string String17DE = "Proceed through the portal for your final test.";
        private const string String180E = "You must proceed through the door in single file.";
        private const string String1840 = "You see a sign on the door reading, 'DO NOT ENTER'.";
        
        // === Functions ================================================
        private void FnTELEA_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x09, 0x01, 0x71, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELEB_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x09, 0x01, 0x16, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void FnTELEC_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String03FC); // All ye who enter here, abandon hope.
            L0010: TeleportParty(player, 0x09, 0x02, 0x77, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnTELED_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x09, 0x01, 0xF0, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTELEE_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0421); // This portal has markings similar to the great dragon's lair above.
            L0010: TeleportParty(player, 0x08, 0x01, 0xEF, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void FnTELEF_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x09, 0x01, 0x0F, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnBANQUET_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0464); // You enter the Cup and Sorcerer banquet hall. Students and instructors dine here.
            L0010: return; // RETURN;
        }

        private void FnINSTRUC_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x59), 0x0001);
            L0017: if (JumpNotEqual) goto L001E;
0107  0019 B8 B5 04  mov ax, 0x4b5
            L001C: goto L0047;
            L001E: AddExperience(player, 0x00004E20);
            L002F: SetFlag(player, 0x02, 0x59, 0x01);
            L0044: ShowMessage(player, String04CD); // You observe a wise old mage teaching his craft. His lessons are very helpful.
            L0051: return; // RETURN;
        }

        private void FnGUARD_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String051B); // The guard nods and goes back to his work.
            L0010: return; // RETURN;
        }

        private void FnLIBRARY_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0545); // The library is silent as students concentrate on their tomes.
            L0010: return; // RETURN;
        }

        private void FnADMIN_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0583); // The administrative clerks are hard at work.
            L0010: return; // RETURN;
        }

        private void FnFLAGCK_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0017: if (JumpNotEqual) goto L003C;
            L0019: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
01AE  0037 B8 AF 05  mov ax, 0x5af
            L003A: goto L0069;
            L003C: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0059: ShowMessage(player, String05C5); // A note on the door from the town clerk reads:
            L0066: ShowMessage(player, String05F3); // 'Faerlun, I'll be back after lunch.'
            L0073: return; // RETURN;
        }

        private void FnTEXTA_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0618); // You throw a few coins into the well for luck.
            L0010: ModifyGold(player, 0xFFFF9CBA);
            L0022: return; // RETURN;
        }

        private void FnHOMEA_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0646); // You marvel at the splendor of this wizard's home.
            L0010: return; // RETURN;
        }

        private void FnTEXTB_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0678); // To the west is the Alchemy Shop; to the east, the Armory.
            L0010: return; // RETURN;
        }

        private void FnHOMEB_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String06B2); // You enter a modest home.
            L0010: return; // RETURN;
        }

        private void FnHERB_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001F);
            L0010: ShowMessage(player, String06CB); // You pass a resident tending the garden where the wizards grow ingredients for their spells.
            L001D: return; // RETURN;
        }

        private void FnTEXTC_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0727); // To the west you see the General Store; to the east, the Magic Shop.
            L0010: return; // RETURN;
        }

        private void FnCLUEC_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String076B); // A sign reads -
            L0010: ShowMessage(player, String077A); // 'See the town clerk for information on training.'
            L001D: return; // RETURN;
        }

        private void FnTXT_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String07AC); // Hocus Pocus Stables
            L0010: return; // RETURN;
        }

        private void FnCLUEE_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String07C0); // A plaque reads -
            L0010: ShowMessage(player, String07D1); // 'Items at the shops are not free.'
            L001D: return; // RETURN;
        }

        private void FnLAVA_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String07F4); // You step into a pool of lava.
            L0010: DamagePlayer(player, GetMaxHits(player));
            L0021: return; // RETURN;
        }

        private void FnPIT_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0812); // The pit is bottomless.
            L0010: DamagePlayer(player, GetMaxHits(player));
            L0021: return; // RETURN;
        }

        private void FnWATER_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoHealZone(player);
            L000B: PushStack(player, 0x01);
            L000F: PushStack(player, 0x00);
0324  0012 C4 5E 06  les bx, [bp+0x6]
0327  0015 26 FF 5F 04  call far word [es:bx+0x4]
            L0019: cx = PopStack(player);
            L001A: cx = PopStack(player);
            L001B: RefreshCompareFlags(ax);
            L001D: if (JumpNotEqual) goto L0054;
            L001F: ShowMessage(player, String0829); // The mystical waters weaken you.
            L002C: ax = GetMaxHits(player);
            L0033: bx = 0x0004;
            L0036: dx = ax % bx; ax = ax / bx;
            L0039: DamagePlayer(player, ax);
            L0043: PushStack(player, 0x01);
            L0047: PushStack(player, ax);
            L0048: PushStack(player, 0x00);
035D  004B C4 5E 06  les bx, [bp+0x6]
0360  004E 26 FF 1F  call far word [es:bx]
0363  0051 83 C4 06  add sp, 0x6
            L0054: return; // RETURN;
        }

        private void FnHERBTXT_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0849); // Hocus Pocus Herb Garden
            L0010: return; // RETURN;
        }

        private void FnILL_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0021: return; // RETURN;
        }

        private void FnSECA_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L006C;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L006C;
            L0024: PushStack(player, 0x68);
            L0028: PushStack(player, ax);
03C6  0029 C4 5E 06  les bx, [bp+0x6]
03C9  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L006C;
            L0036: PushStack(player, 0x6E);
            L003A: PushStack(player, ax);
03D8  003B C4 5E 06  les bx, [bp+0x6]
03DB  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L006C;
            L0048: PushStack(player, 0x90);
            L004C: PushStack(player, ax);
03EA  004D C4 5E 06  les bx, [bp+0x6]
03ED  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L006C;
            L005A: PushStack(player, 0xA4);
            L005E: PushStack(player, ax);
03FC  005F C4 5E 06  les bx, [bp+0x6]
03FF  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpEqual) goto L009C;
            L006C: ShowMessage(player, String0861); // A passageway appears.
            L0079: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
0434  0097 B8 01 00  mov ax, 0x1
            L009A: goto L009E;
            L009C: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00B9: return; // RETURN;
        }

        private void FnALCHEMY_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0022);
            L0010: Compare(GetFlag(player, 0x02, 0x5A), 0x0001);
            L0024: if (JumpNotEqual) goto L002B;
0483  0026 B8 77 08  mov ax, 0x877
            L0029: goto L006D;
            L002B: SetFlag(player, 0x02, 0x5A, 0x01);
            L0040: ModifyGold(player, 0xFFFFE0BA);
            L0052: GiveItem(player, 0xCE);
            L005E: GiveItem(player, 0xB8);
            L006A: ShowMessage(player, String0892); // The shopkeeper is happy to take your gold.
            L0077: return; // RETURN;
        }

        private void FnARMORY_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001A);
            L0010: Compare(GetFlag(player, 0x02, 0x5B), 0x0001);
            L0024: if (JumpNotEqual) goto L002B;
04FC  0026 B8 BD 08  mov ax, 0x8bd
            L0029: goto L0079;
            L002B: SetFlag(player, 0x02, 0x5B, 0x01);
            L0040: ModifyGold(player, 0xFFFF78BA);
            L0052: GiveItem(player, 0x4C);
            L005E: GiveItem(player, 0x3C);
            L006A: GiveItem(player, 0x47);
            L0076: ShowMessage(player, String08E6); // You exchange your gold for weapons.
            L0083: return; // RETURN;
        }

        private void FnGENERAL_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0028);
            L0010: Compare(GetFlag(player, 0x02, 0x5C), 0x0001);
            L0024: if (JumpNotEqual) goto L002B;
0581  0026 B8 0A 09  mov ax, 0x90a
            L0029: goto L0079;
            L002B: SetFlag(player, 0x02, 0x5C, 0x01);
            L0040: ModifyGold(player, 0xFFFFF0BA);
            L0052: GiveItem(player, 0x9B);
            L005E: GiveItem(player, 0x99);
            L006A: GiveItem(player, 0x8E);
            L0076: ShowMessage(player, String0932); // You decide on some helpful items.
            L0083: return; // RETURN;
        }

        private void FnMAGIC_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0029);
            L0010: Compare(GetFlag(player, 0x02, 0x5D), 0x0001);
            L0024: if (JumpNotEqual) goto L002B;
0606  0026 B8 54 09  mov ax, 0x954
            L0029: goto L006D;
            L002B: SetFlag(player, 0x02, 0x5D, 0x01);
            L0040: ModifyGold(player, 0xFFFF58BA);
            L0052: GiveItem(player, 0xAD);
            L005E: GiveItem(player, 0xAA);
            L006A: ShowMessage(player, String0979); // You purchase scrolls.
            L0077: return; // RETURN;
        }

        private void FnBONUSA_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x5E), 0x0001);
            L0017: if (JumpNotEqual) goto L001E;
0672  0019 B8 8F 09  mov ax, 0x98f
            L001C: goto L0047;
            L001E: SetFlag(player, 0x02, 0x5E, 0x01);
            L0033: ModifyGold(player, 0x61A8);
            L0044: ShowMessage(player, String09A6); // You discover a lost quest bag filled with gold.
            L0051: return; // RETURN;
        }

        private void FnBONUSB_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x5F), 0x0001);
            L0017: if (JumpNotEqual) goto L001E;
06C5  0019 B8 D6 09  mov ax, 0x9d6
            L001C: goto L005A;
            L001E: SetFlag(player, 0x02, 0x5F, 0x01);
            L0033: GiveItem(player, 0xB1);
            L003F: GiveItem(player, 0xAF);
            L004B: GiveItem(player, 0xAC);
            L0057: ShowMessage(player, String09E9); // A search yields scrolls.
            L0064: return; // RETURN;
        }

        private void FnMANAZAP_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0A02); // A strange magical aura drains your mana.
            L0010: AddMana(player, 0xFED4);
            L001D: return; // RETURN;
        }

        private void FnNISYM_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0A2B); // The acolytes of Nisym Temple restore your mana free of charge.
            L0010: AddMana(player, 0x2710);
            L001D: return; // RETURN;
        }

        private void FnINN_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0021);
            L0010: ShowMessage(player, String0A6A); // 'Welcome to the Talisman Inn. I have taken payment for your accommodations. You will find your health improved after your brief rest.'
            L001D: HealPlayer(player, GetMaxHits(player));
            L002E: ModifyGold(player, 0xFFFF18BA);
            L0040: return; // RETURN;
        }

        private void FnITEMC_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001C);
            L0010: PushStack(player, 0x01);
            L0014: PushStack(player, ax);
            L0015: PushStack(player, 0x03);
07AB  0019 C4 5E 06  les bx, [bp+0x6]
07AE  001C 26 FF 1F  call far word [es:bx]
07B1  001F 83 C4 06  add sp, 0x6
            L0022: ShowMessage(player, String0AF1); // The clerk greets you.
            L002F: ShowMessage(player, String0B07); // 'Hail! I've been expecting you.
            L003C: ShowMessage(player, String0B27); // Word has been sent to the training area guard. You will now be granted access.'
            L0049: return; // RETURN;
        }

        private void FnWIZARD_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002B);
            L0010: Compare(GetFlag(player, 0x02, 0x78), 0x0001);
            L0024: if (JumpNotEqual) goto L007D;
            L0026: SetFlag(player, 0x03, 0x02, 0x01);
            L003B: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0059: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
0854  0077 B8 77 0B  mov ax, 0xb77
            L007A: goto L01FB;
            L007D: Compare(GetFlag(player, 0x02, 0x78), 0x0002);
            L0091: if (JumpNotEqual) goto L00EA;
            L0093: SetFlag(player, 0x03, 0x02, 0x01);
            L00A8: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00C6: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
08C1  00E4 B8 DA 0B  mov ax, 0xbda
            L00E7: goto L01FB;
            L00EA: ax = HasItem(player, 0x84);
            L00F8: if (JumpNotEqual) goto L00FD;
            L00FA: goto L019F;
            L00FD: SetFlag(player, 0x03, 0x02, 0x01);
            L0112: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L012F: RemoveItem(player, 0x84);
            L013B: ModifyGold(player, 0x2710);
            L014C: ShowMessage(player, String0C18); // 'Hail, brave adventurers!  My name is Faerlun.
            L0159: ShowMessage(player, String0C47); // What an interesting dragon skin you've found! Let's do a little swap, shall we?
            L0166: ShowMessage(player, String0C97); // I'll take the skin. You take this gold.
            L0173: ShowMessage(player, String0CBF); // Now that you are here, maybe you can help me find the wing of a bat and eye of a newt.
            L0180: ShowMessage(player, String0D16); // These items you will find in Hocus Pocus.
            L018D: ShowMessage(player, String0D40); // By the way, do NOT leave the village until you find them.
0977  019A B8 7A 0D  mov ax, 0xd7a
            L019D: goto L01FB;
            L019F: SetFlag(player, 0x03, 0x02, 0x01);
            L01B4: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L01D1: ShowMessage(player, String0DC8); // 'Hail, adventurers. My name is Faerlun and I could use some assistance.
            L01DE: ShowMessage(player, String0E10); // For an experiment I am doing, I seek the wing of a bat and the eye of a newt.
            L01EB: ShowMessage(player, String0E5E); // Do NOT leave Hocus Pocus until you find these items.
            L01F8: ShowMessage(player, String0E93); // In exchange for your help, I will show you the way to a challenge of great reward.'
            L0205: return; // RETURN;
        }

        private void FnFLAGDOOR_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L0017: if (JumpNotEqual) goto L007A;
            L0019: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L002D: if (JumpNotEqual) goto L007A;
            L002F: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L004D: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L006B: ShowMessage(player, String0EE7); // The guard notes your name on the list and allows you access.
            L0078: goto L0097;
            L007A: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0097: return; // RETURN;
        }

        private void FnITEMB_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002C);
            L0010: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0024: if (JumpEqual) goto L0029;
            L0026: goto L00C2;
            L0029: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L003D: if (JumpEqual) goto L0042;
            L003F: goto L00C2;
            L0042: PushStack(player, 0x03);
            L0046: PushStack(player, ax);
0AC4  0047 C4 5E 06  les bx, [bp+0x6]
0AC7  004A 26 FF 5F 04  call far word [es:bx+0x4]
            L004E: cx = PopStack(player);
            L004F: cx = PopStack(player);
            L0050: Compare(ax, 0x0001);
            L0053: if (JumpNotEqual) goto L00C2;
            L0055: SetFlag(player, 0x02, 0x78, 0x01);
            L006A: SetFlag(player, 0x03, 0x02, 0x00);
            L007E: SetFlag(player, 0x03, 0x01, 0x00);
            L0092: PushStack(player, 0x00);
            L0095: PushStack(player, 0x03);
            L0099: PushStack(player, ax);
0B17  009A C4 5E 06  les bx, [bp+0x6]
0B1A  009D 26 FF 1F  call far word [es:bx]
0B1D  00A0 83 C4 06  add sp, 0x6
            L00A3: ShowMessage(player, String0F24); // You meet Morai, who hands you a vial.
            L00B0: ShowMessage(player, String0F4A); // She explains 'I see that you have found the bat wings. Now, this eye of newt will complete Faerlun's needs.'
0B3A  00BD B8 B7 0F  mov ax, 0xfb7
            L00C0: goto L0118;
            L00C2: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L00D6: if (JumpNotEqual) goto L0115;
            L00D8: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L00EC: if (JumpNotEqual) goto L0115;
            L00EE: SetFlag(player, 0x03, 0x04, 0x01);
            L0103: ShowMessage(player, String0F24); // You meet Morai, who hands you a vial.
0B8D  0110 B8 D6 0F  mov ax, 0xfd6
            L0113: goto L00B3;
            L0115: ShowMessage(player, String102C); // Morai is concentrating on her studies.
            L0122: return; // RETURN;
        }

        private void FnITEMA_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002E);
            L0010: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0024: if (JumpEqual) goto L0029;
            L0026: goto L00B8;
            L0029: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L003D: if (JumpNotEqual) goto L00B8;
            L003F: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L0053: if (JumpNotEqual) goto L00B8;
            L0055: SetFlag(player, 0x02, 0x78, 0x01);
            L006A: SetFlag(player, 0x03, 0x02, 0x00);
            L007E: SetFlag(player, 0x03, 0x01, 0x00);
            L0092: SetFlag(player, 0x03, 0x04, 0x00);
            L00A6: ShowMessage(player, String1053); // Keoana greets you. Noticing the eye of newt you carry, she hands you a vial of bat wings.
0C54  00B3 B8 AD 10  mov ax, 0x10ad
            L00B6: goto L0118;
            L00B8: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L00CC: if (JumpNotEqual) goto L0115;
            L00CE: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L00E2: if (JumpNotEqual) goto L0115;
            L00E4: PushStack(player, 0x01);
            L00E8: PushStack(player, 0x03);
            L00EC: PushStack(player, ax);
0C8E  00ED C4 5E 06  les bx, [bp+0x6]
0C91  00F0 26 FF 1F  call far word [es:bx]
0C94  00F3 83 C4 06  add sp, 0x6
            L00F6: ShowMessage(player, String10F6); // Keoana smiles as you enter.
            L0103: ShowMessage(player, String1112); // 'Faerlun is in need of these bat wings. Please take them to him so that he may complete his studies.'
0CB1  0110 B8 78 11  mov ax, 0x1178
            L0113: goto L0118;
            L0115: ShowMessage(player, String1195); // Keoana ignores you.
            L0122: return; // RETURN;
        }

        private void FnSPELL_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002D);
            L0010: Compare(GetFlag(player, 0x02, 0x60), 0x0001);
            L0024: if (JumpNotEqual) goto L002C;
0CEB  0026 B8 A9 11  mov ax, 0x11a9
            L0029: goto L00C3;
            L002C: Compare(GetGuild(player), 0x0001);
            L0036: if (JumpNotEqual) goto L0063;
            L0038: SetFlag(player, 0x02, 0x60, 0x01);
            L004D: SetSpellLevel(player, 0x10, 0x01);
0D23  005E B8 C2 11  mov ax, 0x11c2
            L0061: goto L00C3;
            L0063: Compare(GetGuild(player), 0x0002);
            L006D: if (JumpNotEqual) goto L009A;
            L006F: SetFlag(player, 0x02, 0x60, 0x01);
            L0084: SetSpellLevel(player, 0x07, 0x01);
0D5A  0095 B8 E8 11  mov ax, 0x11e8
            L0098: goto L00C3;
            L009A: SetFlag(player, 0x02, 0x60, 0x01);
            L00AF: SetSpellLevel(player, 0x05, 0x01);
            L00C0: ShowMessage(player, String1217); // Taemen teaches you the Dissipate spell.
            L00CD: return; // RETURN;
        }

        private void FnSKILL_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002B);
            L0010: Compare(GetFlag(player, 0x02, 0x61), 0x0001);
            L0024: if (JumpNotEqual) goto L002B;
0DBA  0026 B8 3F 12  mov ax, 0x123f
            L0029: goto L007B;
            L002B: SetFlag(player, 0x02, 0x61, 0x01);
            L0040: PushStack(player, 0x02);
            L0044: PushStack(player, ax);
0DD9  0045 C4 5E 06  les bx, [bp+0x6]
0DDC  0048 26 FF 9F A8 00  call far word [es:bx+0xa8]
            L004D: cx = PopStack(player);
            L004E: cx = PopStack(player);
            L004F: PushStack(player, 0x01);
            L0053: PushStack(player, ax);
0DE8  0054 C4 5E 06  les bx, [bp+0x6]
0DEB  0057 26 FF 9F A8 00  call far word [es:bx+0xa8]
            L005C: cx = PopStack(player);
            L005D: cx = PopStack(player);
            L005E: ShowMessage(player, String1261); // 'Greetings my friends. I am Saronel. I've gotten word that you are doing fine in your studies of the ways of a mage.'
            L006B: ShowMessage(player, String12D7); // With that he raises his arms and in a flash you sense your defenses improve.
            L0078: ShowMessage(player, String1324); // 'Continue your journey. Hopefully my gift will aid you on your way.'
            L0085: return; // RETURN;
        }

        private void FnPRIESTSS_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0014);
            L0010: Compare(GetFlag(player, 0x02, 0x62), 0x0001);
            L0024: if (JumpNotEqual) goto L002C;
0E41  0026 B8 69 13  mov ax, 0x1369
            L0029: goto L0172;
            L002C: Compare(GetGuild(player), 0x0004);
            L0036: if (JumpEqual) goto L0044;
            L0038: Compare(GetGuild(player), 0x0005);
            L0042: if (JumpNotEqual) goto L00A4;
            L0044: SetFlag(player, 0x02, 0x62, 0x01);
            L0059: PushStack(player, 0x01);
            L005D: PushStack(player, ax);
0E79  005E C4 5E 06  les bx, [bp+0x6]
0E7C  0061 26 FF 5F 68  call far word [es:bx+0x68]
            L0065: cx = PopStack(player);
            L0066: cx = PopStack(player);
            L0067: GiveItem(player, 0x86);
            L0073: GiveItem(player, 0x81);
            L007F: AddExperience(player, 0x000AAE60);
            L0091: ShowMessage(player, String1383); // Geadiax congratulates you on successfully completing your challenge.
0EB9  009E B8 C8 13  mov ax, 0x13c8
            L00A1: goto L0165;
            L00A4: RefreshCompareFlags(GetGuild(player));
            L00AD: if (JumpNotEqual) goto L0105;
            L00AF: SetFlag(player, 0x02, 0x62, 0x01);
            L00C4: GiveItem(player, 0x5C);
            L00D0: SetSkillLevel(player, 0x10, 0x01);
            L00E1: AddExperience(player, 0x000AAE60);
            L00F3: ShowMessage(player, String1383); // Geadiax congratulates you on successfully completing your challenge.
0F1B  0100 B8 53 14  mov ax, 0x1453
            L0103: goto L0165;
            L0105: SetFlag(player, 0x02, 0x62, 0x01);
            L011A: GiveItem(player, 0x10);
            L0126: GiveItem(player, 0x4B);
            L0132: SetSkillLevel(player, 0x11, 0x01);
            L0143: AddExperience(player, 0x000AAE60);
            L0155: ShowMessage(player, String1383); // Geadiax congratulates you on successfully completing your challenge.
            L0162: ShowMessage(player, String14BE); // He raises his arms and magically endows you with a skill to deflect magic and presents you with fine gifts.
            L016F: ShowMessage(player, String142B); // You find the experience most rewarding.
            L017C: return; // RETURN;
        }

        private void FnGEADCLUE_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String152A); // You open a book which you find on one of the tables.
            L0010: ShowMessage(player, String155F); // 'Harken, ye, to the report of a great door maze in Hocus Pocus. Yet unto this day, no one has discovered the hiding place of Geadiax, verily I say unto ye.
            L001D: ShowMessage(player, String15FB); // Tis rumored that he has imprisoned powerful monsters within, to keep the likes such as ye from discovering his whereabouts.'
            L002A: return; // RETURN;
        }

        private void FnSETBA_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1678); // The wizards test what you have learned.
            L0010: ax = HasItem(player, 0xB8);
            L001E: if (JumpEqual) goto L002F;
0FE5  0020 B8 D0 07  mov ax, 0x7d0
            L0023: PushStack(player, ax);
            L0024: PushStack(player, 0x00);
            L0027: PushStack(player, ax);
            L0028: PushStack(player, ax);
            L0029: PushStack(player, ax);
0FEF  002A B8 AE 00  mov ax, 0xae
            L002D: goto L0042;
0FF4  002F B8 88 13  mov ax, 0x1388
            L0032: PushStack(player, ax);
            L0033: PushStack(player, 0x00);
            L0036: PushStack(player, ax);
            L0037: PushStack(player, 0xA5);
            L003B: PushStack(player, 0xCD);
            L003F: PushStack(player, 0xB8);
1008  0043 C4 5E 06  les bx, [bp+0x6]
100B  0046 26 FF 9F D8 00  call far word [es:bx+0xd8]
1010  004B 83 C4 0C  add sp, 0xc
            L004E: Compare(PartyCount(player), 0x0001);
            L0059: if (JumpNotEqual) goto L0077;
            L005B: AddEncounter(player, 0x01, 0x13);
            L006D: PushStack(player, 0x1C);
1036  0071 B8 02 00  mov ax, 0x2
            L0074: goto L0120;
            L0077: Compare(PartyCount(player), 0x0002);
            L0082: if (JumpNotEqual) goto L00BF;
            L0084: AddEncounter(player, 0x01, 0x08);
            L0096: AddEncounter(player, 0x02, 0x0B);
            L00A8: AddEncounter(player, 0x05, 0x24);
107F  00BA B8 25 00  mov ax, 0x25
            L00BD: goto L011C;
            L00BF: AddEncounter(player, 0x01, 0x0A);
            L00D1: AddEncounter(player, 0x02, 0x0B);
            L00E3: AddEncounter(player, 0x03, 0x08);
            L00F5: AddEncounter(player, 0x04, 0x09);
            L0107: AddEncounter(player, 0x05, 0x26);
            L0119: AddEncounter(player, 0x06, 0x1C);
            L012B: return; // RETURN;
        }

        private void FnSETBB_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String16A0); // The instructors decide to evaluate your spellcasting abilities.
            L0010: ax = HasItem(player, 0xAB);
            L001E: if (JumpEqual) goto L0035;
1112  0020 B8 D0 07  mov ax, 0x7d0
            L0023: PushStack(player, ax);
            L0024: PushStack(player, 0x00);
            L0027: PushStack(player, ax);
            L0028: PushStack(player, 0xA1);
            L002C: PushStack(player, 0xA8);
1122  0030 B8 A9 00  mov ax, 0xa9
            L0033: goto L0048;
1127  0035 B8 B8 0B  mov ax, 0xbb8
            L0038: PushStack(player, ax);
            L0039: PushStack(player, 0x00);
            L003C: PushStack(player, ax);
            L003D: PushStack(player, 0xB1);
            L0041: PushStack(player, 0xA8);
            L0045: PushStack(player, 0xAB);
113B  0049 C4 5E 06  les bx, [bp+0x6]
113E  004C 26 FF 9F D8 00  call far word [es:bx+0xd8]
1143  0051 83 C4 0C  add sp, 0xc
            L0054: Compare(PartyCount(player), 0x0001);
            L005F: if (JumpNotEqual) goto L007D;
            L0061: AddEncounter(player, 0x01, 0x19);
            L0073: PushStack(player, 0x21);
1169  0077 B8 02 00  mov ax, 0x2
            L007A: goto L0106;
            L007D: Compare(PartyCount(player), 0x0002);
            L0088: if (JumpNotEqual) goto L00B7;
            L008A: AddEncounter(player, 0x01, 0x19);
            L009C: AddEncounter(player, 0x02, 0x19);
            L00AE: PushStack(player, 0x20);
11A4  00B2 B8 03 00  mov ax, 0x3
            L00B5: goto L0106;
            L00B7: AddEncounter(player, 0x01, 0x19);
            L00C9: AddEncounter(player, 0x02, 0x19);
            L00DB: AddEncounter(player, 0x03, 0x1A);
            L00ED: AddEncounter(player, 0x04, 0x1A);
            L00FF: AddEncounter(player, 0x05, 0x1B);
            L0111: return; // RETURN;
        }

        private void FnSETBC_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String16E0); // You prepare to show your instructors what you have learned.
            L0010: ax = HasItem(player, 0xAD);
            L001E: if (JumpEqual) goto L0032;
1225  0020 B8 D0 07  mov ax, 0x7d0
            L0023: PushStack(player, ax);
            L0024: PushStack(player, 0x00);
            L0027: PushStack(player, ax);
            L0028: PushStack(player, ax);
            L0029: PushStack(player, 0xB0);
1232  002D B8 B2 00  mov ax, 0xb2
            L0030: goto L0045;
1237  0032 B8 B8 0B  mov ax, 0xbb8
            L0035: PushStack(player, ax);
            L0036: PushStack(player, 0x00);
            L0039: PushStack(player, ax);
            L003A: PushStack(player, 0xB7);
            L003E: PushStack(player, 0xB4);
            L0042: PushStack(player, 0xAD);
124B  0046 C4 5E 06  les bx, [bp+0x6]
124E  0049 26 FF 9F D8 00  call far word [es:bx+0xd8]
1253  004E 83 C4 0C  add sp, 0xc
            L0051: Compare(PartyCount(player), 0x0001);
            L005C: if (JumpNotEqual) goto L007A;
            L005E: AddEncounter(player, 0x01, 0x1C);
            L0070: PushStack(player, 0x23);
1279  0074 B8 02 00  mov ax, 0x2
            L0077: goto L0123;
            L007A: Compare(PartyCount(player), 0x0002);
            L0085: if (JumpNotEqual) goto L00C2;
            L0087: AddEncounter(player, 0x01, 0x15);
            L0099: AddEncounter(player, 0x02, 0x16);
            L00AB: AddEncounter(player, 0x05, 0x1C);
12C2  00BD B8 13 00  mov ax, 0x13
            L00C0: goto L011F;
            L00C2: AddEncounter(player, 0x01, 0x24);
            L00D4: AddEncounter(player, 0x02, 0x25);
            L00E6: AddEncounter(player, 0x03, 0x26);
            L00F8: AddEncounter(player, 0x04, 0x27);
            L010A: AddEncounter(player, 0x05, 0x11);
            L011C: AddEncounter(player, 0x06, 0x1C);
            L012E: return; // RETURN;
        }

        private void FnSECBD_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String171C); // You are given the chance to practice your spellcasting.
1345  0010 B8 D0 07  mov ax, 0x7d0
            L0013: PushStack(player, ax);
            L0014: PushStack(player, 0x00);
            L0017: PushStack(player, ax);
            L0018: PushStack(player, 0xA2);
            L001C: PushStack(player, 0xC2);
            L0020: PushStack(player, 0x2D);
1359  0024 C4 5E 06  les bx, [bp+0x6]
135C  0027 26 FF 9F D8 00  call far word [es:bx+0xd8]
1361  002C 83 C4 0C  add sp, 0xc
            L002F: Compare(PartyCount(player), 0x0001);
            L003A: if (JumpNotEqual) goto L0058;
            L003C: AddEncounter(player, 0x01, 0x03);
            L004E: PushStack(player, 0x05);
1387  0052 B8 02 00  mov ax, 0x2
            L0055: goto L00DB;
            L0058: Compare(PartyCount(player), 0x0002);
            L0063: if (JumpNotEqual) goto L008C;
            L0065: PushStack(player, 0x01);
            L0069: PushStack(player, ax);
139F  006A C4 5E 06  les bx, [bp+0x6]
13A2  006D 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0072: cx = PopStack(player);
            L0073: cx = PopStack(player);
            L0074: PushStack(player, 0x02);
            L0078: PushStack(player, ax);
13AE  0079 C4 5E 06  les bx, [bp+0x6]
13B1  007C 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0081: cx = PopStack(player);
            L0082: cx = PopStack(player);
            L0083: PushStack(player, 0x03);
13BC  0087 B8 05 00  mov ax, 0x5
            L008A: goto L00DB;
            L008C: AddEncounter(player, 0x01, 0x03);
            L009E: AddEncounter(player, 0x02, 0x04);
            L00B0: AddEncounter(player, 0x03, 0x02);
            L00C2: AddEncounter(player, 0x05, 0x1E);
            L00D4: AddEncounter(player, 0x06, 0x1E);
            L00E6: return; // RETURN;
        }

        private void FnSETBE_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1754); // The training hall provides you with battles to test your abilities.
            L0010: ax = HasItem(player, 0xA7);
            L001E: if (JumpEqual) goto L0032;
143D  0020 B8 D0 07  mov ax, 0x7d0
            L0023: PushStack(player, ax);
            L0024: PushStack(player, 0x00);
            L0027: PushStack(player, ax);
            L0028: PushStack(player, ax);
            L0029: PushStack(player, 0x8F);
144A  002D B8 8B 00  mov ax, 0x8b
            L0030: goto L0055;
            L0032: ax = HasItem(player, 0xCD);
            L0040: if (JumpNotEqual) goto L0061;
145F  0042 B8 D0 07  mov ax, 0x7d0
            L0045: PushStack(player, ax);
            L0046: PushStack(player, 0x00);
            L0049: PushStack(player, ax);
            L004A: PushStack(player, 0xB7);
            L004E: PushStack(player, 0xCD);
            L0052: PushStack(player, 0xA7);
1473  0056 C4 5E 06  les bx, [bp+0x6]
1476  0059 26 FF 9F D8 00  call far word [es:bx+0xd8]
147B  005E 83 C4 0C  add sp, 0xc
            L0061: Compare(PartyCount(player), 0x0001);
            L006C: if (JumpNotEqual) goto L0077;
            L006E: PushStack(player, 0x0C);
148F  0072 B8 01 00  mov ax, 0x1
            L0075: goto L00DC;
            L0077: Compare(PartyCount(player), 0x0002);
            L0082: if (JumpNotEqual) goto L009F;
            L0084: AddEncounter(player, 0x01, 0x0C);
            L0096: PushStack(player, 0x0D);
14B7  009A B8 02 00  mov ax, 0x2
            L009D: goto L00DC;
            L009F: AddEncounter(player, 0x01, 0x0F);
            L00B1: AddEncounter(player, 0x02, 0x0F);
            L00C3: AddEncounter(player, 0x03, 0x10);
            L00D5: AddEncounter(player, 0x04, 0x22);
            L00E7: return; // RETURN;
        }

        private void FnSETBF_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1798); // A stranded Erebus Fiend pounces on you!
1516  0010 B8 10 27  mov ax, 0x2710
            L0013: PushStack(player, ax);
            L0014: PushStack(player, 0x00);
            L0017: PushStack(player, ax);
            L0018: PushStack(player, ax);
            L0019: PushStack(player, 0x90);
            L001D: PushStack(player, 0xBC);
1527  0021 C4 5E 06  les bx, [bp+0x6]
152A  0024 26 FF 9F D8 00  call far word [es:bx+0xd8]
152F  0029 83 C4 0C  add sp, 0xc
            L002C: AddEncounter(player, 0x01, 0x28);
            L003E: return; // RETURN;
        }

        private void FnSETBG_36(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String17C0); // You disturb a secret meeting.
            L0010: Compare(PartyCount(player), 0x0001);
            L001B: if (JumpNotEqual) goto L0039;
            L001D: AddEncounter(player, 0x01, 0x1C);
            L002F: PushStack(player, 0x06);
1579  0033 B8 05 00  mov ax, 0x5
            L0036: goto L00E2;
            L0039: Compare(PartyCount(player), 0x0002);
            L0044: if (JumpNotEqual) goto L0081;
            L0046: AddEncounter(player, 0x01, 0x15);
            L0058: AddEncounter(player, 0x02, 0x17);
            L006A: AddEncounter(player, 0x05, 0x1E);
15C2  007C B8 06 00  mov ax, 0x6
            L007F: goto L00DE;
            L0081: AddEncounter(player, 0x01, 0x24);
            L0093: AddEncounter(player, 0x02, 0x25);
            L00A5: AddEncounter(player, 0x03, 0x06);
            L00B7: AddEncounter(player, 0x04, 0x06);
            L00C9: AddEncounter(player, 0x05, 0x20);
            L00DB: AddEncounter(player, 0x06, 0x21);
            L00ED: return; // RETURN;
        }

        private void FnSETBH_37(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x08);
            L0022: PushStack(player, 0x0B);
165B  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00C3;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0074;
            L0039: AddEncounter(player, 0x01, 0x09);
            L004B: AddEncounter(player, 0x02, 0x09);
            L005D: AddEncounter(player, 0x05, 0x0B);
16A4  006F B8 0B 00  mov ax, 0xb
            L0072: goto L00D1;
            L0074: AddEncounter(player, 0x01, 0x09);
            L0086: AddEncounter(player, 0x02, 0x09);
            L0098: AddEncounter(player, 0x03, 0x0A);
            L00AA: AddEncounter(player, 0x04, 0x0A);
            L00BC: AddEncounter(player, 0x05, 0x23);
            L00CE: AddEncounter(player, 0x06, 0x23);
            L00E0: return; // RETURN;
        }

        private void FnPARTYCT_38(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L001F;
            L0010: ShowMessage(player, String17DE); // Proceed through the portal for your final test.
            L001D: goto L0047;
            L001F: ShowMessage(player, String180E); // You must proceed through the door in single file.
            L002C: TeleportParty(player, 0x09, 0x01, 0xFE, 0x02, isForwardMove);
            L0047: return; // RETURN;
        }

        private void FnSTRIP_39(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x78, 0x02);
            L0018: SetFlag(player, 0x03, 0x02, 0x00);
            L002C: SetFlag(player, 0x03, 0x01, 0x00);
            L0040: return; // RETURN;
        }

        private void FnNOENTER_3A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1840); // You see a sign on the door reading, 'DO NOT ENTER'.
            L0010: return; // RETURN;
        }

    }
}
