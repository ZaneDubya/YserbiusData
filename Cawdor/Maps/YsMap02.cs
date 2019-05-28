#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap02 : AMapScripted {
        protected override int MapIndex => 2;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap02() {
            MapEvent01 = Fn_01;
            MapEvent02 = Fn_02;
            MapEvent03 = Fn_03;
            MapEvent04 = Fn_04;
            MapEvent05 = Fn_05;
            MapEvent06 = Fn_06;
            MapEvent07 = Fn_07;
            MapEvent09 = Fn_09;
            MapEvent0A = Fn_0A;
            MapEvent0B = Fn_0B;
            MapEvent0C = Fn_0C;
            MapEvent0D = Fn_0D;
            MapEvent0E = Fn_0E;
            MapEvent0F = Fn_0F;
            MapEvent10 = Fn_10;
            MapEvent11 = Fn_11;
            MapEvent12 = Fn_12;
            MapEvent13 = Fn_13;
            MapEvent14 = Fn_14;
            MapEvent15 = Fn_15;
            MapEvent16 = Fn_16;
            MapEvent17 = Fn_17;
            MapEvent18 = Fn_18;
            MapEvent19 = Fn_19;
            MapEvent1A = Fn_1A;
            MapEvent1B = Fn_1B;
            MapEvent2D = Fn_2D;
            MapEvent2E = Fn_2E;
            MapEvent2F = Fn_2F;
            MapEvent30 = Fn_30;
            MapEvent31 = Fn_31;
        }
        
        // === Strings ================================================
        private const string String0140 = "Through here is the Foyer of Cawdor.";
        private const string String0165 = "A voice whispers from thin air....";
        private const string String0188 = "'I'm sorry, but there's nothing else I can do for you here.'";
        private const string String01C5 = "*";
        private const string String01C7 = "'Huzzah!  Thou hast done so well hitherto that I can safely reward thee.  I think me knowledge of the spell of shielding will best serve thee now.'";
        private const string String025B = "You now know that spell!";
        private const string String0274 = "Galatea takes you aside so that only you can hear her remarks.";
        private const string String02B3 = "'What ho!  Stalwart skulker, thou hast earned a reward.  I shall grant thee the skill of Reverie.'";
        private const string String0316 = "'Greedy thou art, and yet I knew it of thee when I chose you as my champion and savior of my soul.  Thou hast already received all the rewards I can safely grant thee here, lest my sisters notice and suspect the usage of my power.'";
        private const string String03FE = "Galatea pulls your party's thieves aside for a few private words, and then returns.";
        private const string String0452 = "'Thou art surviving, which is the important thing.  Take thee this item which mayhaps will help thee to continue doing so.'";
        private const string String04CE = "'Thou hast earned no further rewards from me, greedyguts.'";
        private const string String0509 = "Your hackles rise.  Something's not right here.";
        private const string String0539 = "You've uncovered a hidden door!";
        private const string String0559 = "You thought you saw - naw, it must have just been nerves after that battle.";
        private const string String05A5 = "Wait a second.  You've uncovered a hidden stairway going up!";
        private const string String05E2 = "There used to be a stairwell here, but it has collapsed after decades of neglect.";
        private const string String0634 = "But I like the way you think.  Have 1,000 experience points!";
        private const string String0671 = "Okay, it was cute the first time, but you're not going to get any further rewards here.";
        private const string String06C9 = "A wizard is muttering to himself, ignoring you.";
        private const string String06F9 = "'I did fight the brinded cats.  I fought them twice.  I fought them thrice.  I fought the hedge pig.  I fought them twice.  I fought them thrice.  Why, then, could I not find the harpy, or the Lady?  Let me recount....I fought the brinded cats.  I fought them twice....'";
        private const string String0808 = "Huddled in a corner, you find a delirious halfling mumbling incoherently to himself.";
        private const string String085D = "'Ahh, Rory....  Would that thou hadst not drunk too soon from the Flowing Flagon.  All dead....  Its powers should have been reserved for the shade of he not born of woman.  Deanna, Philbert, all gone....'";
        private const string String092B = "What have we here?  You've discovered a secret door!";
        private const string String0960 = "A woman sits at a desk to the west.";
        private const string String0984 = "'Yes, yes.  Thou hast fully convinced me of thy skill at detections.  Howsomever, I have naught to give thee.  Seekest thou elsewhere.'";
        private const string String0A0C = "'Fine, fine.  You either know how to find things or how to find friends who can find things.  Run along and play somewhere else.  I'm busy!'";
        private const string String0A99 = "'Adequate, but fully adequate.  Let me give thee something that, fortune willing, will prove a more interesting challenge to thee.'";
        private const string String0B1D = "You've picked the lock. Proceed.";
        private const string String0B3E = "Funny how an irksome little lock on a flimsy little door can keep out a big strong person like you.";
        private const string String0BA2 = "The refreshing waters heal your wounds.";
        private const string String0BCA = "The fountain does nothing for you.";
        private const string String0BED = "'Arroint thee, oh thou canker of a boomerang!Thou hast received all the reward thou shalt get from mine own self this day.  Be gone!'";
        private const string String0C73 = "'Ah!  Thou hast returned.  Hast an apple for thy teacher?  Mayhaps a coffee candy?  Ah, for the good old days, when pupils knew how to reward their teachers.  Begone!'";
        private const string String0D1B = "'Cease thy smirking, oh addlepated initiate! ";
        private const string String0D49 = "'Thou hast proven thyself fit against these minor impediments, but when thou dost match thyself against the greater locks, aye, and with Herself breathing down thy neck, then wilt thou be able to call thyself a locksmith!";
        private const string String0E27 = "Ah, well; I suppose thou dost feel deserving of a reward, then.  I shall grant thee a golden one, an thou dost take thyself elsewhere.'";
        private const string String0EAF = "In the corner, behind a desk piled high with papers, you can see a woman scribbling furiously.";
        private const string String0F0E = "The scroll on the wall reads: 'Do unto others before they do unto you.'";
        private const string String0F56 = "The scroll on the wall reads: 'Courage!  And cut the cards.'";
        private const string String0F93 = "The scroll on the wall reads: 'A snitch in time saves nine.'";
        private const string String0FD0 = "The caption reads: 'Our founder: Hieronymous Snivel.'";
        private const string String1006 = "You come across some sinister sorcerors!";
        private const string String102F = "And their servants!";
        private const string String1043 = "All that remains of your battle here is a slightly smoking mage's hat.";
        private const string String108A = "Uh oh!  Here come some vicious Vikings!";
        private const string String10B2 = "And some naughty northmen, too!";
        private const string String10D2 = "All that remains of your battle here is a broken axe and some sunscreen.";
        private const string String111B = "Even in 1200 A.D. they knew how susceptible fair-skinned folks are to skin cancer.";
        private const string String116E = "We now leave our public service announcement and return to our regularly scheduled game.";
        private const string String11C7 = "Those nasty nuns aren't wielding rulers!";
        private const string String11F0 = "Neither are those bad brothers!";
        private const string String1210 = "All that remains of your battle here are some bad habits.";
        private const string String124A = "I couldn't resist.";
        private const string String125D = "Gadzooks!  'Tis a gang of wretched refugees from this unholy hive of scum and villainy.";
        private const string String12B5 = "Hmm.  There are an awful lot of them.";
        private const string String12DB = "Fie!  'Tis a veritable herd of belligerent bovines!";
        private const string String130F = "And their owners?";
        private const string String1321 = "All that remains of your battle here is an empty milk carton.  Fortunately it isn't your picture on the back.";
        private const string String138F = "Comets and meteors!  An enormous red dragon rears up and addresses to you.";
        private const string String13DA = "'Hmm.  There are two ways this could go.  We could have similar senses of humor, and part friends, or I could just eat thee.  So.  Wouldst hear a joke about a stupid green dragon named Gwalter the Dim?'";
        private const string String14A5 = "'Ah!  I remember thee.  As I recall, thou didst enjoy my last joke.  Wouldst thou hear another?'";
        private const string String1506 = "You quickly nod.";
        private const string String1517 = "'Gwalter was such a stupid green dragon that he made his abode in a live volcano.  One day a friend of his, a much wiser red dragon, came to visit.  In landing the friend knocked a farthing off the ledge down into the murky depths.  Gwalter immediately threw his finest jewels and gems down the shaft.'";
        private const string String1646 = "'Gwalter's friend asked, 'By my claws and scales, what art thou doing?'";
        private const string String168E = "'Gwalter replied, 'I am not going down there for just a farthing!'";
        private const string String16D1 = "You manage to join the dragon in a chuckle.  The dragon flies off smiling, or at least showing many teeth.";
        private const string String173C = "The caption reads: 'MissyCD, the Guildmother of us all, who toiled on behalf of Cawdor's Thieves until her enormous heart gave out.  We honor her memory.'";
        private const string String17D7 = "Any resemblance between her and the lovely Galatea is purely coincidental.";
        private const string String1822 = "The caption reads: 'Borboriador Demonslayer, thief of the decade 1150-1159'";
        private const string String186E = "The caption reads: 'Gnorm Gnorton, thief of the decade 1160-1169'";
        private const string String18B0 = "The caption reads: 'Rory Applebush, thief of the decade 1170-1179, holder of the all time record for gold piece to body weight ratio.'";
        private const string String1937 = "The caption reads: 'Angus McSneaky, the Gremlin who survived the longest after looting a dragon's horde: six hours, twelve minutes.";
        
        // === Functions ================================================
        private void Fn_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0140); // Through here is the Foyer of Cawdor.
            L0010: PushStack(player, 0x00);
            L0013: PushStack(player, 0x3F);
            L0017: PushStack(player, 0x01);
            L001B: PushStack(player, ax);
0027  001C C4 5E 06  les bx, [bp+0x6]
002A  001F 26 FF 9F BC 00  call far word [es:bx+0xbc]
002F  0024 83 C4 08  add sp, 0x8
            L0027: return; // RETURN;
        }

        private void Fn_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x06), 0x0001);
            L0017: if (JumpEqual) goto L002F;
            L0019: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L002D: if (JumpNotEqual) goto L0042;
            L002F: ShowMessage(player, String0165); // A voice whispers from thin air....
0070  003C B8 88 01  mov ax, 0x188
            L003F: goto L02A3;
            L0042: ShowPortrait(player, 0x0015);
            L004F: SetFlag(player, 0x03, 0x02, 0x01);
            L0064: SetFlag(player, 0x02, 0x04, 0x01);
            L0079: Compare(GetFlag(player, 0x02, 0x00), 0x0001);
            L008C: if (JumpEqual) goto L0091;
            L008E: goto L01E8;
            L0091: Compare(GetFlag(player, 0x02, 0x01), 0x0001);
            L00A5: if (JumpEqual) goto L00AA;
            L00A7: goto L01E8;
            L00AA: PushStack(player, 0x02);
            L00AE: PushStack(player, ax);
00E3  00AF C4 5E 06  les bx, [bp+0x6]
00E6  00B2 26 FF 5F 04  call far word [es:bx+0x4]
            L00B6: cx = PopStack(player);
            L00B7: cx = PopStack(player);
            L00B8: Compare(ax, 0x0001);
            L00BB: if (JumpEqual) goto L00C0;
            L00BD: goto L01E8;
            L00C0: Compare(GetFlag(player, 0x02, 0x03), 0x0001);
            L00D4: if (JumpEqual) goto L00D9;
            L00D6: goto L01E8;
            L00D9: Compare(GetFlag(player, 0x02, 0x05), 0x0001);
            L00ED: if (JumpEqual) goto L00F2;
            L00EF: goto L01E8;
            L00F2: RefreshCompareFlags(GetFlag(player, 0x02, 0x06));
            L0105: if (JumpEqual) goto L010A;
            L0107: goto L01E8;
            L010A: ShowMessage(player, String01C5); // *
            L0117: ShowMessage(player, String01C5); // *
            L0124: ShowMessage(player, String01C5); // *
            L0131: ShowMessage(player, String01C7); // 'Huzzah!  Thou hast done so well hitherto that I can safely reward thee.  I think me knowledge of the spell of shielding will best serve thee now.'
            L013E: ShowMessage(player, String025B); // You now know that spell!
            L014B: SetSpellLevel(player, 0x0F, 0x01);
            L015C: SetFlag(player, 0x02, 0x06, 0x01);
            L0171: RefreshCompareFlags(GetSkillLevel(player, 0x13));
            L017F: if (JumpEqual) goto L0184;
            L0181: goto L02AD;
            L0184: Compare(GetGuild(player), 0x0003);
            L018E: if (JumpEqual) goto L0193;
            L0190: goto L02AD;
            L0193: ShowMessage(player, String01C5); // *
            L01A0: ShowMessage(player, String01C5); // *
            L01AD: ShowMessage(player, String01C5); // *
            L01BA: ShowMessage(player, String0274); // Galatea takes you aside so that only you can hear her remarks.
            L01C7: ShowMessage(player, String02B3); // 'What ho!  Stalwart skulker, thou hast earned a reward.  I shall grant thee the skill of Reverie.'
            L01D4: SetSkillLevel(player, 0x13, 0x01);
            L01E5: goto L02AD;
            L01E8: RefreshCompareFlags(GetSkillLevel(player, 0x13));
            L01F6: if (JumpNotEqual) goto L0206;
            L01F8: Compare(GetGuild(player), 0x0003);
            L0202: if (JumpNotEqual) goto L0206;
            L0204: goto L0193;
            L0206: Compare(GetGuild(player), 0x0003);
            L0210: if (JumpNotEqual) goto L023E;
            L0212: ShowMessage(player, String01C5); // *
            L021F: ShowMessage(player, String01C5); // *
            L022C: ShowMessage(player, String01C5); // *
026D  0239 B8 16 03  mov ax, 0x316
            L023C: goto L02A3;
            L023E: PushStack(player, 0x03);
0276  0242 C4 5E 06  les bx, [bp+0x6]
0279  0245 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L024A: cx = PopStack(player);
            L024B: RefreshCompareFlags(ax);
            L024D: if (JumpEqual) goto L025C;
            L024F: ShowMessage(player, String03FE); // Galatea pulls your party's thieves aside for a few private words, and then returns.
            L025C: RefreshCompareFlags(GetFlag(player, 0x02, 0x74));
            L026F: if (JumpNotEqual) goto L02A0;
            L0271: ShowMessage(player, String0452); // 'Thou art surviving, which is the important thing.  Take thee this item which mayhaps will help thee to continue doing so.'
            L027E: SetFlag(player, 0x02, 0x74, 0x01);
            L0293: PushStack(player, 0x8E);
02CB  0297 C4 5E 06  les bx, [bp+0x6]
02CE  029A 26 FF 5F 48  call far word [es:bx+0x48]
            L029E: goto L02AC;
            L02A0: ShowMessage(player, String04CE); // 'Thou hast earned no further rewards from me, greedyguts.'
            L02AD: return; // RETURN;
        }

        private void Fn_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0509); // Your hackles rise.  Something's not right here.
            L0010: Compare(HasUsedSkill(player, 0x0D), 0x0002);
            L001F: if (JumpNotBelow) goto L008B;
            L0021: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L002F: if (JumpNotEqual) goto L008B;
            L0031: PushStack(player, 0xA7);
            L0035: PushStack(player, ax);
0319  0036 C4 5E 06  les bx, [bp+0x6]
031C  0039 26 FF 5F 54  call far word [es:bx+0x54]
            L003D: cx = PopStack(player);
            L003E: cx = PopStack(player);
            L003F: RefreshCompareFlags(ax);
            L0041: if (JumpNotEqual) goto L008B;
            L0043: PushStack(player, 0x67);
            L0047: PushStack(player, ax);
032B  0048 C4 5E 06  les bx, [bp+0x6]
032E  004B 26 FF 5F 54  call far word [es:bx+0x54]
            L004F: cx = PopStack(player);
            L0050: cx = PopStack(player);
            L0051: RefreshCompareFlags(ax);
            L0053: if (JumpNotEqual) goto L008B;
            L0055: PushStack(player, 0x61);
            L0059: PushStack(player, ax);
033D  005A C4 5E 06  les bx, [bp+0x6]
0340  005D 26 FF 5F 54  call far word [es:bx+0x54]
            L0061: cx = PopStack(player);
            L0062: cx = PopStack(player);
            L0063: RefreshCompareFlags(ax);
            L0065: if (JumpNotEqual) goto L008B;
            L0067: PushStack(player, 0x93);
            L006B: PushStack(player, ax);
034F  006C C4 5E 06  les bx, [bp+0x6]
0352  006F 26 FF 5F 54  call far word [es:bx+0x54]
            L0073: cx = PopStack(player);
            L0074: cx = PopStack(player);
            L0075: RefreshCompareFlags(ax);
            L0077: if (JumpNotEqual) goto L008B;
            L0079: PushStack(player, 0x86);
            L007D: PushStack(player, ax);
0361  007E C4 5E 06  les bx, [bp+0x6]
0364  0081 26 FF 5F 54  call far word [es:bx+0x54]
            L0085: cx = PopStack(player);
            L0086: cx = PopStack(player);
            L0087: RefreshCompareFlags(ax);
            L0089: if (JumpEqual) goto L00CB;
            L008B: ShowMessage(player, String0539); // You've uncovered a hidden door!
            L0098: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00B6: PushStack(player, GetFacing(player));
            L00BE: PushStack(player, GetCurrentTile(player));
03A9  00C6 B8 01 00  mov ax, 0x1
            L00C9: goto L00FA;
            L00CB: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00E8: SetWallObject(player, 0x00, GetCurrentTile(player), GetFacing(player));
            L0105: return; // RETURN;
        }

        private void Fn_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0559); // You thought you saw - naw, it must have just been nerves after that battle.
            L0010: Compare(HasUsedSkill(player, 0x0D), 0x0003);
            L001F: if (JumpNotBelow) goto L008B;
            L0021: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L002F: if (JumpNotEqual) goto L008B;
            L0031: PushStack(player, 0xA7);
            L0035: PushStack(player, ax);
0420  0036 C4 5E 06  les bx, [bp+0x6]
0423  0039 26 FF 5F 54  call far word [es:bx+0x54]
            L003D: cx = PopStack(player);
            L003E: cx = PopStack(player);
            L003F: RefreshCompareFlags(ax);
            L0041: if (JumpNotEqual) goto L008B;
            L0043: PushStack(player, 0x67);
            L0047: PushStack(player, ax);
0432  0048 C4 5E 06  les bx, [bp+0x6]
0435  004B 26 FF 5F 54  call far word [es:bx+0x54]
            L004F: cx = PopStack(player);
            L0050: cx = PopStack(player);
            L0051: RefreshCompareFlags(ax);
            L0053: if (JumpNotEqual) goto L008B;
            L0055: PushStack(player, 0x61);
            L0059: PushStack(player, ax);
0444  005A C4 5E 06  les bx, [bp+0x6]
0447  005D 26 FF 5F 54  call far word [es:bx+0x54]
            L0061: cx = PopStack(player);
            L0062: cx = PopStack(player);
            L0063: RefreshCompareFlags(ax);
            L0065: if (JumpNotEqual) goto L008B;
            L0067: PushStack(player, 0x93);
            L006B: PushStack(player, ax);
0456  006C C4 5E 06  les bx, [bp+0x6]
0459  006F 26 FF 5F 54  call far word [es:bx+0x54]
            L0073: cx = PopStack(player);
            L0074: cx = PopStack(player);
            L0075: RefreshCompareFlags(ax);
            L0077: if (JumpNotEqual) goto L008B;
            L0079: PushStack(player, 0x86);
            L007D: PushStack(player, ax);
0468  007E C4 5E 06  les bx, [bp+0x6]
046B  0081 26 FF 5F 54  call far word [es:bx+0x54]
            L0085: cx = PopStack(player);
            L0086: cx = PopStack(player);
            L0087: RefreshCompareFlags(ax);
            L0089: if (JumpEqual) goto L00E4;
            L008B: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00A9: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00C7: ShowMessage(player, String05A5); // Wait a second.  You've uncovered a hidden stairway going up!
            L00D4: PushStack(player, 0x01);
            L00D8: PushStack(player, ax);
            L00D9: PushStack(player, 0x00);
04C6  00DC C4 5E 06  les bx, [bp+0x6]
04C9  00DF 26 FF 1F  call far word [es:bx]
            L00E2: goto L012E;
            L00E4: PushStack(player, 0x00);
            L00E7: PushStack(player, 0x01);
            L00EB: PushStack(player, 0x00);
04D8  00EE C4 5E 06  les bx, [bp+0x6]
04DB  00F1 26 FF 1F  call far word [es:bx]
04DE  00F4 83 C4 06  add sp, 0x6
            L00F7: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0114: SetWallObject(player, 0x00, GetCurrentTile(player), GetFacing(player));
            L0131: return; // RETURN;
        }

        private void Fn_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x0002);
            L0012: if (JumpNotBelow) goto L007E;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L007E;
            L0024: PushStack(player, 0xA7);
            L0028: PushStack(player, ax);
0546  0029 C4 5E 06  les bx, [bp+0x6]
0549  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L007E;
            L0036: PushStack(player, 0x67);
            L003A: PushStack(player, ax);
0558  003B C4 5E 06  les bx, [bp+0x6]
055B  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L007E;
            L0048: PushStack(player, 0x61);
            L004C: PushStack(player, ax);
056A  004D C4 5E 06  les bx, [bp+0x6]
056D  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L007E;
            L005A: PushStack(player, 0x93);
            L005E: PushStack(player, ax);
057C  005F C4 5E 06  les bx, [bp+0x6]
057F  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpNotEqual) goto L007E;
            L006C: PushStack(player, 0x86);
            L0070: PushStack(player, ax);
058E  0071 C4 5E 06  les bx, [bp+0x6]
0591  0074 26 FF 5F 54  call far word [es:bx+0x54]
            L0078: cx = PopStack(player);
            L0079: cx = PopStack(player);
            L007A: RefreshCompareFlags(ax);
            L007C: if (JumpEqual) goto L00E2;
            L007E: ShowMessage(player, String05E2); // There used to be a stairwell here, but it has collapsed after decades of neglect.
            L008B: RefreshCompareFlags(GetFlag(player, 0x02, 0x39));
            L009E: if (JumpNotEqual) goto L00D5;
            L00A0: ShowMessage(player, String0634); // But I like the way you think.  Have 1,000 experience points!
            L00AD: AddExperience(player, 0x000003E8);
            L00BE: SetFlag(player, 0x02, 0x39, 0x01);
            L00D3: goto L00E2;
            L00D5: ShowMessage(player, String0671); // Okay, it was cute the first time, but you're not going to get any further rewards here.
            L00E2: return; // RETURN;
        }

        private void Fn_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0016: if (JumpNotEqual) goto L007B;
            L0018: SetFlag(player, 0x03, 0x04, 0x01);
            L002D: ShowPortrait(player, 0x002B);
            L003A: ShowMessage(player, String01C5); // *
            L0047: ShowMessage(player, String01C5); // *
            L0054: ShowMessage(player, String01C5); // *
            L0061: ShowMessage(player, String06C9); // A wizard is muttering to himself, ignoring you.
            L006E: ShowMessage(player, String06F9); // 'I did fight the brinded cats.  I fought them twice.  I fought them thrice.  I fought the hedge pig.  I fought them twice.  I fought them thrice.  Why, then, could I not find the harpy, or the Lady?  Let me recount....I fought the brinded cats.  I fought them twice....'
            L007B: return; // RETURN;
        }

        private void Fn_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0029);
            L0010: ShowMessage(player, String01C5); // *
            L001D: ShowMessage(player, String01C5); // *
            L002A: ShowMessage(player, String01C5); // *
            L0037: ShowMessage(player, String0808); // Huddled in a corner, you find a delirious halfling mumbling incoherently to himself.
            L0044: ShowMessage(player, String085D); // 'Ahh, Rory....  Would that thou hadst not drunk too soon from the Flowing Flagon.  All dead....  Its powers should have been reserved for the shade of he not born of woman.  Deanna, Philbert, all gone....'
            L0051: return; // RETURN;
        }

        private void Fn_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x0003);
            L0012: if (JumpNotBelow) goto L007E;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L007E;
            L0024: PushStack(player, 0xA7);
            L0028: PushStack(player, ax);
06FF  0029 C4 5E 06  les bx, [bp+0x6]
0702  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L007E;
            L0036: PushStack(player, 0x67);
            L003A: PushStack(player, ax);
0711  003B C4 5E 06  les bx, [bp+0x6]
0714  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L007E;
            L0048: PushStack(player, 0x61);
            L004C: PushStack(player, ax);
0723  004D C4 5E 06  les bx, [bp+0x6]
0726  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L007E;
            L005A: PushStack(player, 0x93);
            L005E: PushStack(player, ax);
0735  005F C4 5E 06  les bx, [bp+0x6]
0738  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpNotEqual) goto L007E;
            L006C: PushStack(player, 0x86);
            L0070: PushStack(player, ax);
0747  0071 C4 5E 06  les bx, [bp+0x6]
074A  0074 26 FF 5F 54  call far word [es:bx+0x54]
            L0078: cx = PopStack(player);
            L0079: cx = PopStack(player);
            L007A: RefreshCompareFlags(ax);
            L007C: if (JumpEqual) goto L00CF;
            L007E: ShowMessage(player, String092B); // What have we here?  You've discovered a secret door!
            L008B: PushStack(player, 0x01);
            L008F: PushStack(player, ax);
            L0090: PushStack(player, 0x00);
0769  0093 C4 5E 06  les bx, [bp+0x6]
076C  0096 26 FF 1F  call far word [es:bx]
076F  0099 83 C4 06  add sp, 0x6
            L009C: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00BA: PushStack(player, GetFacing(player));
            L00C2: PushStack(player, GetCurrentTile(player));
07A0  00CA B8 01 00  mov ax, 0x1
            L00CD: goto L0111;
            L00CF: PushStack(player, 0x00);
            L00D2: PushStack(player, 0x01);
            L00D6: PushStack(player, 0x00);
07AF  00D9 C4 5E 06  les bx, [bp+0x6]
07B2  00DC 26 FF 1F  call far word [es:bx]
07B5  00DF 83 C4 06  add sp, 0x6
            L00E2: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00FF: SetWallObject(player, 0x00, GetCurrentTile(player), GetFacing(player));
            L011C: return; // RETURN;
        }

        private void Fn_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0960); // A woman sits at a desk to the west.
            L0010: return; // RETURN;
        }

        private void Fn_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0022);
            L0010: ax = HasItem(player, 0xC1);
            L001E: if (JumpNotEqual) goto L0080;
            L0020: ax = HasItem(player, 0xC2);
            L002E: if (JumpNotEqual) goto L0080;
            L0030: ax = HasItem(player, 0xC3);
            L003E: if (JumpNotEqual) goto L0080;
            L0040: ax = HasItem(player, 0xDA);
            L004E: if (JumpNotEqual) goto L0080;
            L0050: ax = HasItem(player, 0xDB);
            L005E: if (JumpNotEqual) goto L0080;
            L0060: ax = HasItem(player, 0xDC);
            L006E: if (JumpNotEqual) goto L0080;
            L0070: ax = HasItem(player, 0xDD);
            L007E: if (JumpEqual) goto L00A0;
            L0080: Compare(PartyCount(player), 0x0001);
            L008B: if (JumpNotEqual) goto L009B;
0893  008D B8 84 09  mov ax, 0x984
            L0090: PushStack(player, ax);
0897  0091 C4 5E 06  les bx, [bp+0x6]
089A  0094 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L0099: goto L00B8;
08A1  009B B8 0C 0A  mov ax, 0xa0c
            L009E: goto L0090;
            L00A0: ShowMessage(player, String0A99); // 'Adequate, but fully adequate.  Let me give thee something that, fortune willing, will prove a more interesting challenge to thee.'
            L00AD: GiveItem(player, 0xC3);
            L00B9: return; // RETURN;
        }

        private void Fn_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x68);
            L0007: PushStack(player, ax);
08C9  0008 C4 5E 06  les bx, [bp+0x6]
08CC  000B 26 FF 5F 54  call far word [es:bx+0x54]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L008E;
            L0015: ax = HasItem(player, 0xC1);
            L0023: if (JumpEqual) goto L0028;
            L0025: goto L00DB;
            L0028: ax = HasItem(player, 0xC2);
            L0036: if (JumpEqual) goto L003B;
            L0038: goto L00DB;
            L003B: ax = HasItem(player, 0xC3);
            L0049: if (JumpEqual) goto L004E;
            L004B: goto L00DB;
            L004E: ax = HasItem(player, 0xDA);
            L005C: if (JumpNotEqual) goto L00DB;
            L005E: ax = HasItem(player, 0xDB);
            L006C: if (JumpNotEqual) goto L00DB;
            L006E: ax = HasItem(player, 0xDC);
            L007C: if (JumpNotEqual) goto L00DB;
            L007E: ax = HasItem(player, 0xDD);
            L008C: if (JumpNotEqual) goto L00DB;
            L008E: Compare(GetSkillLevel(player, 0x0E), 0x0001);
            L009D: if (JumpBelow) goto L00C9;
            L009F: ax = HasUsedItem(player, 0xC1, 0xC3);
            L00B2: if (JumpNotEqual) goto L00DB;
            L00B4: ax = HasUsedItem(player, 0xDA, 0xDD);
            L00C7: if (JumpNotEqual) goto L00DB;
            L00C9: PushStack(player, 0xC0);
            L00CD: PushStack(player, ax);
098F  00CE C4 5E 06  les bx, [bp+0x6]
0992  00D1 26 FF 5F 54  call far word [es:bx+0x54]
            L00D5: cx = PopStack(player);
            L00D6: cx = PopStack(player);
            L00D7: RefreshCompareFlags(ax);
            L00D9: if (JumpEqual) goto L0108;
            L00DB: ShowMessage(player, String0B1D); // You've picked the lock. Proceed.
            L00E8: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0106: goto L0132;
            L0108: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0125: ShowMessage(player, String0B3E); // Funny how an irksome little lock on a flimsy little door can keep out a big strong person like you.
            L0132: return; // RETURN;
        }

        private void Fn_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: ax = CheckLevel(player, 0x000A);
            L001E: if (JumpEqual) goto L0022;
            L0020: goto L0056;
            L0022: PushStack(player, GetCurrentHits(player));
            L002A: ax = GetMaxHits(player);
            L0031: dx = PopStack(player);
0A27  0032 3B D0  cmp dx, ax
            L0034: if (JumpNotBelow) goto L0056;
            L0036: ShowMessage(player, String0BA2); // The refreshing waters heal your wounds.
            L0043: HealPlayer(player, GetMaxHits(player));
            L0054: goto L0063;
0A4B  0056 FF 76 08  push word [bp+0x8]
0A4E  0059 FF 76 06  push word [bp+0x6]
0A51  005C 0E     push cs
0A52  005D E8 05 00  call 0x65
            L0060: // NOP
            L0061: cx = PopStack(player);
            L0062: cx = PopStack(player);
            L0063: return; // RETURN;
            // Extra data: 55 8B EC B8 CA 0B 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 
        }

        private void Fn_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0022);
            L0010: Compare(GetFlag(player, 0x03, 0x5D), 0x0001);
            L0024: if (JumpNotEqual) goto L0036;
            L0026: ShowMessage(player, String0BED); // 'Arroint thee, oh thou canker of a boomerang!Thou hast received all the reward thou shalt get from mine own self this day.  Be gone!'
            L0033: goto L00AF;
            L0035: // NOP
            L0036: Compare(GetFlag(player, 0x02, 0x5D), 0x0001);
            L004A: if (JumpNotEqual) goto L0051;
0AB8  004C B8 73 0C  mov ax, 0xc73
            L004F: goto L0029;
            L0051: SetFlag(player, 0x02, 0x5D, 0x01);
            L0066: ShowMessage(player, String0D1B); // 'Cease thy smirking, oh addlepated initiate! 
            L0073: ShowMessage(player, String0D49); // 'Thou hast proven thyself fit against these minor impediments, but when thou dost match thyself against the greater locks, aye, and with Herself breathing down thy neck, then wilt thou be able to call thyself a locksmith!
            L0080: ShowMessage(player, String0E27); // Ah, well; I suppose thou dost feel deserving of a reward, then.  I shall grant thee a golden one, an thou dost take thyself elsewhere.'
            L008D: AddExperience(player, 0x000003E8);
            L009E: ModifyGold(player, 0x03E8);
            L00AF: return; // RETURN;
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0EAF); // In the corner, behind a desk piled high with papers, you can see a woman scribbling furiously.
            L0010: return; // RETURN;
        }

        private void Fn_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String01C5); // *
            L0010: ShowMessage(player, String01C5); // *
            L001D: ShowMessage(player, String01C5); // *
            L002A: ShowMessage(player, String0F0E); // The scroll on the wall reads: 'Do unto others before they do unto you.'
            L0037: return; // RETURN;
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String01C5); // *
            L0010: ShowMessage(player, String01C5); // *
            L001D: ShowMessage(player, String01C5); // *
            L002A: ShowMessage(player, String0F56); // The scroll on the wall reads: 'Courage!  And cut the cards.'
            L0037: return; // RETURN;
        }

        private void Fn_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String01C5); // *
            L0010: ShowMessage(player, String01C5); // *
            L001D: ShowMessage(player, String01C5); // *
            L002A: ShowMessage(player, String0F93); // The scroll on the wall reads: 'A snitch in time saves nine.'
            L0037: return; // RETURN;
        }

        private void Fn_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0022);
            L0010: ShowMessage(player, String01C5); // *
            L001D: ShowMessage(player, String01C5); // *
            L002A: ShowMessage(player, String01C5); // *
            L0037: ShowMessage(player, String0FD0); // The caption reads: 'Our founder: Hieronymous Snivel.'
            L0044: return; // RETURN;
        }

        private void Fn_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00EF;
            L001B: SetFlag(player, 0x03, 0x05, 0x01);
            L0030: ShowMessage(player, String1006); // You come across some sinister sorcerors!
            L003D: Compare(PartyCount(player), 0x0002);
            L0048: if (JumpBelowOrEqual) goto L0057;
            L004A: ShowMessage(player, String102F); // And their servants!
            L0057: PushStack(player, 0x87);
            L005B: PushStack(player, 0x00);
            L005E: PushStack(player, ax);
            L005F: PushStack(player, ax);
            L0060: PushStack(player, ax);
            L0061: PushStack(player, 0xB8);
0C85  0065 C4 5E 06  les bx, [bp+0x6]
0C88  0068 26 FF 9F D8 00  call far word [es:bx+0xd8]
0C8D  006D 83 C4 0C  add sp, 0xc
            L0070: AddEncounter(player, 0x01, 0x28);
            L0082: Compare(PartyCount(player), 0x0002);
            L008D: if (JumpBelowOrEqual) goto L00C7;
            L008F: AddEncounter(player, 0x02, 0x28);
            L00A1: AddEncounter(player, 0x03, 0x0E);
            L00B3: AddEncounter(player, 0x04, 0x0E);
            L00C5: goto L00FC;
            L00C7: Compare(PartyCount(player), 0x0001);
            L00D2: if (JumpBelowOrEqual) goto L00FC;
            L00D4: AddEncounter(player, 0x02, 0x28);
            L00E6: PushStack(player, 0x28);
0D0A  00EA B8 03 00  mov ax, 0x3
            L00ED: goto L00BA;
            L00EF: ShowMessage(player, String1043); // All that remains of your battle here is a slightly smoking mage's hat.
            L00FC: return; // RETURN;
        }

        private void Fn_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00F2;
            L001B: ShowMessage(player, String108A); // Uh oh!  Here come some vicious Vikings!
            L0028: SetFlag(player, 0x03, 0x06, 0x01);
            L003D: Compare(PartyCount(player), 0x0002);
            L0048: if (JumpBelowOrEqual) goto L0057;
            L004A: ShowMessage(player, String10B2); // And some naughty northmen, too!
            L0057: PushStack(player, 0x87);
            L005B: PushStack(player, 0x00);
            L005E: PushStack(player, ax);
            L005F: PushStack(player, ax);
            L0060: PushStack(player, 0x26);
            L0064: PushStack(player, 0xB8);
0D86  0068 C4 5E 06  les bx, [bp+0x6]
0D89  006B 26 FF 9F D8 00  call far word [es:bx+0xd8]
0D8E  0070 83 C4 0C  add sp, 0xc
            L0073: AddEncounter(player, 0x01, 0x1E);
            L0085: Compare(PartyCount(player), 0x0002);
            L0090: if (JumpBelowOrEqual) goto L00CA;
            L0092: AddEncounter(player, 0x02, 0x1E);
            L00A4: AddEncounter(player, 0x03, 0x21);
            L00B6: AddEncounter(player, 0x04, 0x21);
            L00C8: goto L0144;
            L00CA: Compare(PartyCount(player), 0x0001);
            L00D5: if (JumpBelowOrEqual) goto L0144;
            L00D7: AddEncounter(player, 0x02, 0x1E);
            L00E9: PushStack(player, 0x1E);
0E0B  00ED B8 03 00  mov ax, 0x3
            L00F0: goto L00BD;
            L00F2: ShowMessage(player, String10D2); // All that remains of your battle here is a broken axe and some sunscreen.
            L00FF: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L0113: if (JumpNotEqual) goto L0144;
            L0115: SetFlag(player, 0x03, 0x06, 0x02);
            L012A: ShowMessage(player, String111B); // Even in 1200 A.D. they knew how susceptible fair-skinned folks are to skin cancer.
            L0137: ShowMessage(player, String116E); // We now leave our public service announcement and return to our regularly scheduled game.
            L0144: return; // RETURN;
        }

        private void Fn_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00F2;
            L001B: SetFlag(player, 0x03, 0x07, 0x01);
            L0030: ShowMessage(player, String11C7); // Those nasty nuns aren't wielding rulers!
            L003D: Compare(PartyCount(player), 0x0002);
            L0048: if (JumpBelowOrEqual) goto L0057;
            L004A: ShowMessage(player, String11F0); // Neither are those bad brothers!
            L0057: PushStack(player, 0x87);
            L005B: PushStack(player, 0x00);
            L005E: PushStack(player, ax);
            L005F: PushStack(player, ax);
            L0060: PushStack(player, 0xB7);
            L0064: PushStack(player, 0x39);
0ECC  0068 C4 5E 06  les bx, [bp+0x6]
0ECF  006B 26 FF 9F D8 00  call far word [es:bx+0xd8]
0ED4  0070 83 C4 0C  add sp, 0xc
            L0073: AddEncounter(player, 0x01, 0x27);
            L0085: Compare(PartyCount(player), 0x0002);
            L0090: if (JumpBelowOrEqual) goto L00CA;
            L0092: AddEncounter(player, 0x02, 0x27);
            L00A4: AddEncounter(player, 0x03, 0x17);
            L00B6: AddEncounter(player, 0x04, 0x17);
            L00C8: goto L010C;
            L00CA: Compare(PartyCount(player), 0x0001);
            L00D5: if (JumpBelowOrEqual) goto L010C;
            L00D7: AddEncounter(player, 0x02, 0x27);
            L00E9: PushStack(player, 0x27);
0F51  00ED B8 03 00  mov ax, 0x3
            L00F0: goto L00BD;
            L00F2: ShowMessage(player, String1210); // All that remains of your battle here are some bad habits.
            L00FF: ShowMessage(player, String124A); // I couldn't resist.
            L010C: return; // RETURN;
        }

        private void Fn_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x08));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0132;
            L001B: SetFlag(player, 0x03, 0x08, 0x01);
            L0030: ShowMessage(player, String125D); // Gadzooks!  'Tis a gang of wretched refugees from this unholy hive of scum and villainy.
            L003D: Compare(PartyCount(player), 0x0002);
            L0048: if (JumpBelowOrEqual) goto L0057;
            L004A: ShowMessage(player, String12B5); // Hmm.  There are an awful lot of them.
            L0057: PushStack(player, 0x87);
            L005B: PushStack(player, 0x00);
            L005E: PushStack(player, ax);
            L005F: PushStack(player, 0x3C);
            L0063: PushStack(player, 0xCB);
            L0067: PushStack(player, 0xB8);
0FDD  006B C4 5E 06  les bx, [bp+0x6]
0FE0  006E 26 FF 9F D8 00  call far word [es:bx+0xd8]
0FE5  0073 83 C4 0C  add sp, 0xc
            L0076: AddEncounter(player, 0x01, 0x19);
            L0088: Compare(PartyCount(player), 0x0002);
            L0093: if (JumpBelowOrEqual) goto L00E6;
            L0095: AddEncounter(player, 0x02, 0x22);
            L00A7: AddEncounter(player, 0x03, 0x25);
            L00B9: AddEncounter(player, 0x04, 0x24);
            L00CB: AddEncounter(player, 0x05, 0x1D);
            L00DD: PushStack(player, 0x23);
1053  00E1 B8 06 00  mov ax, 0x6
            L00E4: goto L0127;
            L00E6: Compare(PartyCount(player), 0x0001);
            L00F1: if (JumpBelowOrEqual) goto L0120;
            L00F3: AddEncounter(player, 0x02, 0x23);
            L0105: AddEncounter(player, 0x03, 0x1F);
            L0117: PushStack(player, 0x1C);
108D  011B B8 04 00  mov ax, 0x4
            L011E: goto L0127;
            L0120: AddEncounter(player, 0x02, 0x25);
            L0132: return; // RETURN;
        }

        private void Fn_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x09));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L011C;
            L001B: SetFlag(player, 0x03, 0x09, 0x01);
            L0030: ShowMessage(player, String12DB); // Fie!  'Tis a veritable herd of belligerent bovines!
            L003D: Compare(PartyCount(player), 0x0002);
            L0048: if (JumpBelowOrEqual) goto L0057;
            L004A: ShowMessage(player, String130F); // And their owners?
            L0057: AddTreasure(player, 0x0087, 0x00, 0x73, 0x48, 0xCB, 0xB8);
            L0079: AddEncounter(player, 0x01, 0x26);
            L008B: AddEncounter(player, 0x02, 0x26);
            L009D: Compare(PartyCount(player), 0x0002);
            L00A8: if (JumpBelowOrEqual) goto L00F4;
            L00AA: AddEncounter(player, 0x03, 0x26);
            L00BC: AddEncounter(player, 0x04, 0x26);
            L00CE: AddEncounter(player, 0x05, 0x28);
            L00E0: AddEncounter(player, 0x06, 0x28);
            L00F2: goto L0129;
            L00F4: Compare(PartyCount(player), 0x0001);
            L00FF: if (JumpBelowOrEqual) goto L0129;
            L0101: AddEncounter(player, 0x03, 0x26);
            L0113: PushStack(player, 0x26);
11BD  0117 B8 04 00  mov ax, 0x4
            L011A: goto L00E7;
            L011C: ShowMessage(player, String1321); // All that remains of your battle here is an empty milk carton.  Fortunately it isn't your picture on the back.
            L0129: return; // RETURN;
        }

        private void Fn_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0509); // Your hackles rise.  Something's not right here.
            L0010: Compare(HasUsedSkill(player, 0x0D), 0x0003);
            L001F: if (JumpNotBelow) goto L008B;
            L0021: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L002F: if (JumpNotEqual) goto L008B;
            L0031: PushStack(player, 0xA7);
            L0035: PushStack(player, ax);
1207  0036 C4 5E 06  les bx, [bp+0x6]
120A  0039 26 FF 5F 54  call far word [es:bx+0x54]
            L003D: cx = PopStack(player);
            L003E: cx = PopStack(player);
            L003F: RefreshCompareFlags(ax);
            L0041: if (JumpNotEqual) goto L008B;
            L0043: PushStack(player, 0x67);
            L0047: PushStack(player, ax);
1219  0048 C4 5E 06  les bx, [bp+0x6]
121C  004B 26 FF 5F 54  call far word [es:bx+0x54]
            L004F: cx = PopStack(player);
            L0050: cx = PopStack(player);
            L0051: RefreshCompareFlags(ax);
            L0053: if (JumpNotEqual) goto L008B;
            L0055: PushStack(player, 0x61);
            L0059: PushStack(player, ax);
122B  005A C4 5E 06  les bx, [bp+0x6]
122E  005D 26 FF 5F 54  call far word [es:bx+0x54]
            L0061: cx = PopStack(player);
            L0062: cx = PopStack(player);
            L0063: RefreshCompareFlags(ax);
            L0065: if (JumpNotEqual) goto L008B;
            L0067: PushStack(player, 0x93);
            L006B: PushStack(player, ax);
123D  006C C4 5E 06  les bx, [bp+0x6]
1240  006F 26 FF 5F 54  call far word [es:bx+0x54]
            L0073: cx = PopStack(player);
            L0074: cx = PopStack(player);
            L0075: RefreshCompareFlags(ax);
            L0077: if (JumpNotEqual) goto L008B;
            L0079: PushStack(player, 0x86);
            L007D: PushStack(player, ax);
124F  007E C4 5E 06  les bx, [bp+0x6]
1252  0081 26 FF 5F 54  call far word [es:bx+0x54]
            L0085: cx = PopStack(player);
            L0086: cx = PopStack(player);
            L0087: RefreshCompareFlags(ax);
            L0089: if (JumpEqual) goto L00CB;
            L008B: ShowMessage(player, String0539); // You've uncovered a hidden door!
            L0098: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00B6: PushStack(player, GetFacing(player));
            L00BE: PushStack(player, GetCurrentTile(player));
1297  00C6 B8 01 00  mov ax, 0x1
            L00C9: goto L00FA;
            L00CB: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00E8: SetWallObject(player, 0x00, GetCurrentTile(player), GetFacing(player));
            L0105: return; // RETURN;
        }

        private void Fn_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x4A));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0103;
            L001B: SetFlag(player, 0x02, 0x4A, 0x01);
            L0030: ShowPortrait(player, 0x000E);
            L003D: ShowMessage(player, String01C5); // *
            L004A: ShowMessage(player, String01C5); // *
            L0057: ShowMessage(player, String01C5); // *
            L0064: ShowMessage(player, String138F); // Comets and meteors!  An enormous red dragon rears up and addresses to you.
            L0071: RefreshCompareFlags(GetFlag(player, 0x02, 0x49));
            L0084: if (JumpNotEqual) goto L00B5;
            L0086: RefreshCompareFlags(GetFlag(player, 0x02, 0x54));
            L0099: if (JumpNotEqual) goto L00B5;
            L009B: RefreshCompareFlags(GetFlag(player, 0x02, 0x4B));
            L00AE: if (JumpNotEqual) goto L00B5;
1388  00B0 B8 DA 13  mov ax, 0x13da
            L00B3: goto L00B8;
            L00B5: ShowMessage(player, String14A5); // 'Ah!  I remember thee.  As I recall, thou didst enjoy my last joke.  Wouldst thou hear another?'
            L00C2: ShowMessage(player, String1506); // You quickly nod.
            L00CF: ShowMessage(player, String1517); // 'Gwalter was such a stupid green dragon that he made his abode in a live volcano.  One day a friend of his, a much wiser red dragon, came to visit.  In landing the friend knocked a farthing off the ledge down into the murky depths.  Gwalter immediately threw his finest jewels and gems down the shaft.'
            L00DC: ShowMessage(player, String1646); // 'Gwalter's friend asked, 'By my claws and scales, what art thou doing?'
            L00E9: ShowMessage(player, String168E); // 'Gwalter replied, 'I am not going down there for just a farthing!'
            L00F6: ShowMessage(player, String16D1); // You manage to join the dragon in a chuckle.  The dragon flies off smiling, or at least showing many teeth.
            L0103: return; // RETURN;
        }

        private void Fn_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x4D, 0x01);
            L0018: return; // RETURN;
        }

        private void Fn_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0015);
            L0010: ShowMessage(player, String01C5); // *
            L001D: ShowMessage(player, String01C5); // *
            L002A: ShowMessage(player, String01C5); // *
            L0037: ShowMessage(player, String173C); // The caption reads: 'MissyCD, the Guildmother of us all, who toiled on behalf of Cawdor's Thieves until her enormous heart gave out.  We honor her memory.'
            L0044: ShowMessage(player, String17D7); // Any resemblance between her and the lovely Galatea is purely coincidental.
            L0051: return; // RETURN;
        }

        private void Fn_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0023);
            L0010: ShowMessage(player, String01C5); // *
            L001D: ShowMessage(player, String01C5); // *
            L002A: ShowMessage(player, String01C5); // *
            L0037: ShowMessage(player, String1822); // The caption reads: 'Borboriador Demonslayer, thief of the decade 1150-1159'
            L0044: return; // RETURN;
        }

        private void Fn_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0024);
            L0010: ShowMessage(player, String01C5); // *
            L001D: ShowMessage(player, String01C5); // *
            L002A: ShowMessage(player, String01C5); // *
            L0037: ShowMessage(player, String186E); // The caption reads: 'Gnorm Gnorton, thief of the decade 1160-1169'
            L0044: return; // RETURN;
        }

        private void Fn_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0025);
            L0010: ShowMessage(player, String01C5); // *
            L001D: ShowMessage(player, String01C5); // *
            L002A: ShowMessage(player, String01C5); // *
            L0037: ShowMessage(player, String18B0); // The caption reads: 'Rory Applebush, thief of the decade 1170-1179, holder of the all time record for gold piece to body weight ratio.'
            L0044: return; // RETURN;
        }

        private void Fn_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0026);
            L0010: ShowMessage(player, String01C5); // *
            L001D: ShowMessage(player, String01C5); // *
            L002A: ShowMessage(player, String01C5); // *
            L0037: ShowMessage(player, String1937); // The caption reads: 'Angus McSneaky, the Gremlin who survived the longest after looting a dragon's horde: six hours, twelve minutes.
            L0044: return; // RETURN;
        }

    }
}
