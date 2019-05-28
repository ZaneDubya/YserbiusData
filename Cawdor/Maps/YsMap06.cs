#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap06 : AMapScripted {
        protected override int MapIndex => 6;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap06() {
            MapEvent01 = Fn_01;
            MapEvent02 = Fn_02;
            MapEvent03 = Fn_03;
            MapEvent04 = Fn_04;
            MapEvent06 = Fn_06;
            MapEvent08 = Fn_08;
            MapEvent0A = Fn_0A;
            MapEvent0B = Fn_0B;
            MapEvent0C = Fn_0C;
            MapEvent0D = Fn_0D;
            MapEvent0E = Fn_0E;
            MapEvent0F = Fn_0F;
            MapEvent10 = Fn_10;
            MapEvent11 = Fn_11;
            MapEvent12 = Fn_12;
            MapEvent15 = Fn_15;
            MapEvent16 = Fn_16;
            MapEvent17 = Fn_17;
            MapEvent18 = Fn_18;
            MapEvent1C = Fn_1C;
            MapEvent1D = Fn_1D;
            MapEvent1E = Fn_1E;
            MapEvent1F = Fn_1F;
            MapEvent20 = Fn_20;
            MapEvent21 = Fn_21;
            MapEvent22 = Fn_22;
            MapEvent23 = Fn_23;
            MapEvent24 = Fn_24;
            MapEvent27 = Fn_27;
        }
        
        // === Strings ================================================
        private const string String0140 = "This way to the Foyer of Cawdor.";
        private const string String0161 = "*";
        private const string String0163 = "Welcome back!  I know thou art fully up to the quests found herein, having bested them once, but I can grant thee fair warning that some of the monsters have returned, and in greater numbers than before.";
        private const string String022F = "Thou shalt have my gratitude, and that of all good folk, an thou dost help rid this room of the unholy plague of undead.  I can give thee no more rewards for thy efforts here, appreciated though they are.'";
        private const string String02FD = "'I suppose that this once I can cast a simple healing spell upon thee without endangering either of our souls,' he says, winking.";
        private const string String037F = "The elf closes his eyes and begins chanting.";
        private const string String03AC = "You see an elf, seated, with his eyes closed.  He is chanting melodically in a surprisingly deep voice.  Soon he finishes, opens his eyes, and speaks.";
        private const string String0443 = "'Hail and well met, fellow cleric.  My divinations told me that thou wouldst arrive today.  I have a mission for thee.' His voice deepens.";
        private const string String04CE = "'There are, within this room, many creatures of undying yet unliving form.  Their souls are trapped on this earth, finding neither judgment nor salvation.  To release them, thou must destroy their corporeal beings.  Wilt thou undertake this task for me, and for them?'";
        private const string String05DB = "You assure him that you will.";
        private const string String05F9 = "'Then I can warn thee that, although thou shalt find thy spell of dissipate most puissant against them, that there are others here, some beasts, some beings lured by the unholy prospect of unending life, who will also try to defeat thee.";
        private const string String06E7 = "To assist thee against these such, I shall give unto thee the spell of Hail.  May it serve thee well!'";
        private const string String074E = "The cleric gestures; you now know that spell!";
        private const string String077C = "'My blessing upon thee; and remember, there is no dishonor in retreating from a more powerful foe.'  The elf closes his eyes and begins chanting again.";
        private const string String0814 = "'Thou hast performed many mighty deeds, and thou dost deserve all the rewards I can grant.";
        private const string String086F = "Although we are discouraged from worldly things, nonetheless thou shalt need a heavy purse to obtain the items which shall sustain and support thee in our cause.'";
        private const string String0912 = "'And thou dost know well that thou hast acted in a state of grace, for thou art rewarded in other ways.  Behold!'";
        private const string String0984 = "You now know the skill of binding!";
        private const string String09A7 = "'May I offer my personal gratitude for all that thou hast done here.'  He shakes your hand, and then returns to his chanting.";
        private const string String0A25 = "'I do appreciate thy efforts against the unholy creatures that reside within, and yet I have not the wherewithal to reward thee fully for thy repeated efforts.  This will have to suffice.'";
        private const string String0AE2 = "'But now I fear me that thou art needed elsewhere.  Farewell....'";
        private const string String0B24 = "'Be not disenheartened.  Remember, 'tis neither shame nor sin to retreat, regroup, return.  An thou maintains thy honor and grace, thou shalt succeed.'";
        private const string String0BBC = "'Of course, the greatest rewards accrue to the champion who can survive this entire area,' he says, with a wink.";
        private const string String0C2D = "What a motley crew.  Motley, but ready to rumble.";
        private const string String0C5F = "The recollection of living and undead fighting together against you here is enough to make you shudder.";
        private const string String0CC7 = "You think the tool will enable you to proceed discreetly.";
        private const string String0D01 = "A familiar voice whispers to you.";
        private const string String0D23 = "'Before thou dost assay the ultimate combat in this place, thou hadst best prove thy mettle against the lesser evils found hereabouts.";
        private const string String0DAA = "You see a heavily scarred and well equipped halfling thief scuttling from pillar to post.  He wears a Thief's Tabard and carries a Dalriadan Bow, and you can hear him softly chanting, 'Here, ghoulie ghoulie ghoulie.'";
        private const string String0E83 = "You wisely decide to let him go his own way.";
        private const string String0EB0 = "A large orcish knight, bearing Wulfherd's Shield and Hilda's Hammer, greets you.";
        private const string String0F01 = "'Hail and well met.  I have equipped myself for a return engagement with a certain ghost, who killed my brother.  He was about fourteen feet tall, bright puce.  Hast thou seen him?' You shake your head.  He sighs. 'Until we meet again, then.'";
        private const string String0FF4 = "A small, smiling halfling knight, wearing a Holy Relic, bearing Oswald's Bane, and wielding Malcolm's Chopper, is noisily stalking an obviously empty part of the room.  Her eyes are filled with madness as they meet yours.";
        private const string String10D2 = "'Shh!  I have found that which will enable me to defeat all forms of undead.  By conquering death I shall live forever!  Do not follow me!  He is MINE!'";
        private const string String116B = "You see no reason to argue, as the knight clatters off.";
        private const string String11A3 = "A dwarf holds up her hand in greeting.";
        private const string String11CA = "'I say, chaps!  I have been literally going in circles searching for Oswald's Bane or My Lady's Favor, both of which I need to teach a certain lich a lesson.  Would you happen to have a spare set on you?'";
        private const string String1297 = "You shake your head.";
        private const string String12AC = "'Ta, then.'  The dwarf departs.";
        private const string String12CC = "Rushing towards you are the biggest giant and the biggest ghost you have ever seen.  The ghost drives the giant with huge hammering blows, and yet the giant's shield, Edwin's Defender, seems to deflect most of the damage.  You decide, wisely, not to intervene.";
        private const string String13D1 = "A voice whispers from thin air....";
        private const string String13F4 = "'I'm sorry, but there's nothing else I can do for you here.'";
        private const string String1431 = "'Huzzah!  Thou hast done so well hitherto that I can safely reward thee.  I think me knowledge of the spell of shielding will best serve thee now.'";
        private const string String14C5 = "You realize that you now know that spell!";
        private const string String14EF = "'And Oh! Stalwart questor!  Thou hast been well and throughly blooded on this journey.  I think me it is long past time that thou didst know the magical ways of self-healing.'";
        private const string String159F = "Galatea draws you aside for a private message.";
        private const string String15CE = "'Oh! Stalwart questor!  Thou hast been well and throughly blooded on this journey.  I think me it is long past time that thou didst know the magical ways of self-healing.'";
        private const string String167A = "'Thou hast already received all the rewards thou hast earned and that I can safely grant thee here, lest my sisters notice and suspect the usage of my power.'";
        private const string String1719 = "Galatea pulls your party's clerics aside for a few private words, and then returns.";
        private const string String176D = "'Thou art surviving, which is the important thing.  Take thee this item which mayhaps will help thee to continue doing so.'";
        private const string String17E9 = "'Thou hast earned no further rewards from me, thou witless chaff.'";
        private const string String182C = "When these ghouls were bad, they were very very bad.";
        private const string String1861 = "Some ghouls just don't take no for an answer.";
        private const string String188F = "Bloodsuckers and would be bloodsuckers make this place painful to recollect.";
        private const string String18DC = "You've just found crypt central!";
        private const string String18FD = "Again!";
        private const string String1904 = "And you without your Red Cross card.";
        private const string String1929 = "At least the beings you fought here bled when cut.";
        private const string String195C = "The good news is there don't appear to be any undead in this group of folks attacking you.";
        private const string String19B7 = "The bad news is, there probably doesn't need to be!";
        private const string String19EB = "'This battle was nae so bad,' you tell yourself.  Of course, having survived it makes all the difference in the world.";
        private const string String1A62 = "The canny undead were lying in wait.";
        private const string String1A87 = "There are the makings of an ambush here, but you seem to have caught them unawares.  Then again, who can tell what undead are thinking.";
        private const string String1B0F = "You're thinking it's a good thing that undead have short attention spans.";
        private const string String1B59 = "This looked bad enough, but as the rest of them shamble forwards, it looks worse.";
        private const string String1BAB = "Carefully using the tool, you managed to open the door without much noise.";
        private const string String1BF6 = "The door made a lot of noise as you came through.";
        private const string String1C28 = "This appears to be another confessional waiting room.";
        private const string String1C5E = "This seems to be a well-appointed confessional waiting room.  There are chairs and a sofa here.  The confessional proper is behind a partition on the southern wall.";
        private const string String1D03 = "You smile, grimly: you, at least, walked away from this killing place.";
        private const string String1D4A = "Oh fie!  'Tis an ambush!";
        private const string String1D63 = "Your careful approach prevents you from being surprised.  Well done!";
        private const string String1DA8 = "You have a job ahead of you.";
        private const string String1DC5 = "This appears to be a well-appointed confessional waiting room.  Several chairs lie around.  The confessional itself seems to be behind a partition on the northern wall.";
        private const string String1E6E = "This appears to be a well-appointed confessional waiting room.  Several chairs lie around.  The confessional itself seems to be behind a partition on the southern wall.";
        private const string String1F17 = "This seems to be a well-appointed confessional waiting room.  There are chairs and a sofa here.  The confessional proper is behind a partition on the northern wall.";
        private const string String1FBC = "You find some fresh tracks leading towards the altar in the northwest corner.  You start moving more warily. ";
        private const string String202A = "This was the nave of this chapel.  The outside walls are covered with stained glass.  Someone scavenged the pews for firewood, leaving only their stone foundations and the odd broken piece of wood.  In the northwest corner an altar lies in serious disrepair.";
        private const string String212D = "Nobody buried any more treasure here for you.";
        private const string String215B = "After several minutes of dusty digging, you uncover a veritable kobold's fortune: 471 gold pieces!";
        private const string String21BE = "Sadly, this once fine altar has been thoroughly vandalised.";
        private const string String21FA = "This was once a humbly furnished dining room, but the benches and tables have long since been converted to kindling.";
        private const string String226F = "This was once a large and well equipped kitchen, but it is obvious that over the years it has been well and thoroughly ransacked.";
        private const string String22F1 = "This is an overgrown but still beautiful garden.  It is filled with roses and other flowers.  A plot to the south has herbs clearly labelled.  To the north some fountains still provide running water.  After a minute of silent admiration, some birds begin singing, as if accepting your presence here.";
        private const string String241D = "You have already harvested the only ripe bud.";
        private const string String244B = "You remember how to find the garlic here.  There is one big ripe bud.";
        private const string String2491 = "And one of these days you might be able to master the knack of harvesting it without it sliding away.  Hmm. Maybe somewhere to the east is a powerful garlic magnet.";
        private const string String2536 = "A plethora of fine herbs are here: thyme, basil, rosemary, and - what is this?  You have found a healthy patch of garlic!";
        private const string String25B0 = "The good news is that you tug some loose!  The bad news is that it slides out of your hand to the east.";
        private const string String2618 = "These herbs will be a pleasant addition to your cooking kit.  Almost anything to flavor trail rations will be much appreciated.";
        private const string String2698 = "'Ah!  So thou, too, hast heard of the tremendous powers the Gaelic Garlic has against undead.  But there is none to be found this way.  I am most sure of that.'";
        private const string String2739 = "This warm, almost hot fountain provides some relief to your bruises, but does nothing special for you.";
        private const string String27A0 = "This cold fountain provides a refreshing drink for you, but does nothing special otherwise.";
        private const string String27FC = "You pick up a bouncing bud of Gaelic Garlic.";
        
        // === Functions ================================================
        private void Fn_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x51, 0x01);
            L0018: Compare(GetFacing(player), 0x0002);
            L0022: if (JumpNotEqual) goto L0031;
            L0024: ShowMessage(player, String0140); // This way to the Foyer of Cawdor.
            L0031: return; // RETURN;
        }

        private void Fn_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0027);
            L0010: Compare(GetFlag(player, 0x02, 0x01), 0x0001);
            L0024: if (JumpEqual) goto L0029;
            L0026: goto L00FB;
            L0029: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L003C: if (JumpNotEqual) goto L00AC;
            L003E: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L0051: if (JumpNotEqual) goto L00AC;
            L0053: ShowMessage(player, String0161); // *
            L0060: ShowMessage(player, String0161); // *
            L006D: ShowMessage(player, String0161); // *
            L007A: ShowMessage(player, String0163); // Welcome back!  I know thou art fully up to the quests found herein, having bested them once, but I can grant thee fair warning that some of the monsters have returned, and in greater numbers than before.
            L0087: ShowMessage(player, String022F); // Thou shalt have my gratitude, and that of all good folk, an thou dost help rid this room of the unholy plague of undead.  I can give thee no more rewards for thy efforts here, appreciated though they are.'
            L0094: SetFlag(player, 0x03, 0x01, 0x02);
            L00A9: goto L040B;
            L00AC: Compare(GetFlag(player, 0x03, 0x01), 0x0002);
            L00C0: if (JumpEqual) goto L00C5;
            L00C2: goto L040B;
            L00C5: ShowMessage(player, String02FD); // 'I suppose that this once I can cast a simple healing spell upon thee without endangering either of our souls,' he says, winking.
            L00D2: HealPlayer(player, GetMaxHits(player));
            L00E3: PushStack(player, 0x01);
            L00E7: PushStack(player, ax);
            L00E8: PushStack(player, 0x03);
0128  00EC C4 5E 06  les bx, [bp+0x6]
012B  00EF 26 FF 1F  call far word [es:bx]
012E  00F2 83 C4 06  add sp, 0x6
0131  00F5 B8 7F 03  mov ax, 0x37f
            L00F8: goto L0401;
            L00FB: RefreshCompareFlags(GetFlag(player, 0x02, 0x0C));
            L010E: if (JumpEqual) goto L0113;
            L0110: goto L01CC;
            L0113: Compare(GetGuild(player), 0x0004);
            L011D: if (JumpEqual) goto L0122;
            L011F: goto L01CC;
            L0122: ShowMessage(player, String0161); // *
            L012F: ShowMessage(player, String0161); // *
            L013C: ShowMessage(player, String0161); // *
            L0149: ShowMessage(player, String03AC); // You see an elf, seated, with his eyes closed.  He is chanting melodically in a surprisingly deep voice.  Soon he finishes, opens his eyes, and speaks.
            L0156: ShowMessage(player, String0443); // 'Hail and well met, fellow cleric.  My divinations told me that thou wouldst arrive today.  I have a mission for thee.' His voice deepens.
            L0163: ShowMessage(player, String04CE); // 'There are, within this room, many creatures of undying yet unliving form.  Their souls are trapped on this earth, finding neither judgment nor salvation.  To release them, thou must destroy their corporeal beings.  Wilt thou undertake this task for me, and for them?'
            L0170: ShowMessage(player, String05DB); // You assure him that you will.
            L017D: ShowMessage(player, String05F9); // 'Then I can warn thee that, although thou shalt find thy spell of dissipate most puissant against them, that there are others here, some beasts, some beings lured by the unholy prospect of unending life, who will also try to defeat thee.
            L018A: ShowMessage(player, String06E7); // To assist thee against these such, I shall give unto thee the spell of Hail.  May it serve thee well!'
            L0197: PushStack(player, 0x01);
            L019B: PushStack(player, 0x07);
01DB  019F C4 5E 06  les bx, [bp+0x6]
01DE  01A2 26 FF 5F 6C  call far word [es:bx+0x6c]
            L01A6: cx = PopStack(player);
            L01A7: cx = PopStack(player);
            L01A8: ShowMessage(player, String074E); // The cleric gestures; you now know that spell!
            L01B5: ShowMessage(player, String077C); // 'My blessing upon thee; and remember, there is no dishonor in retreating from a more powerful foe.'  The elf closes his eyes and begins chanting again.
            L01C2: PushStack(player, 0x01);
0202  01C6 B8 0C 00  mov ax, 0xc
            L01C9: goto L0316;
            L01CC: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L01DF: if (JumpNotEqual) goto L01E4;
            L01E1: goto L031D;
            L01E4: PushStack(player, 0x03);
            L01E8: PushStack(player, ax);
0225  01E9 C4 5E 06  les bx, [bp+0x6]
0228  01EC 26 FF 5F 04  call far word [es:bx+0x4]
            L01F0: cx = PopStack(player);
            L01F1: cx = PopStack(player);
            L01F2: RefreshCompareFlags(ax);
            L01F4: if (JumpNotEqual) goto L01F9;
            L01F6: goto L031D;
            L01F9: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L020C: if (JumpNotEqual) goto L0211;
            L020E: goto L031D;
            L0211: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0224: if (JumpNotEqual) goto L0229;
            L0226: goto L031D;
            L0229: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L023C: if (JumpNotEqual) goto L0241;
            L023E: goto L031D;
            L0241: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0254: if (JumpNotEqual) goto L0259;
            L0256: goto L031D;
            L0259: RefreshCompareFlags(GetFlag(player, 0x02, 0x01));
            L026C: if (JumpEqual) goto L0287;
            L026E: Compare(GetFlag(player, 0x03, 0x0D), 0x0001);
            L0282: if (JumpEqual) goto L0287;
            L0284: goto L031D;
            L0287: ShowMessage(player, String0814); // 'Thou hast performed many mighty deeds, and thou dost deserve all the rewards I can grant.
            L0294: ShowMessage(player, String086F); // Although we are discouraged from worldly things, nonetheless thou shalt need a heavy purse to obtain the items which shall sustain and support thee in our cause.'
            L02A1: GiveItem(player, 0xBD);
            L02AD: ShowMessage(player, String0912); // 'And thou dost know well that thou hast acted in a state of grace, for thou art rewarded in other ways.  Behold!'
            L02BA: AddExperience(player, 0x00000FA0);
            L02CB: RefreshCompareFlags(GetSkillLevel(player, 0x06));
            L02D9: if (JumpNotEqual) goto L0305;
            L02DB: Compare(GetGuild(player), 0x0004);
            L02E5: if (JumpNotEqual) goto L0305;
            L02E7: SetSkillLevel(player, 0x06, 0x01);
            L02F8: ShowMessage(player, String0984); // You now know the skill of binding!
            L0305: ShowMessage(player, String09A7); // 'May I offer my personal gratitude for all that thou hast done here.'  He shakes your hand, and then returns to his chanting.
            L0312: PushStack(player, 0x01);
            L0316: PushStack(player, ax);
0353  0317 B8 02 00  mov ax, 0x2
            L031A: goto L009F;
            L031D: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0330: if (JumpNotEqual) goto L0335;
            L0332: goto L03F1;
            L0335: PushStack(player, 0x03);
            L0339: PushStack(player, ax);
0376  033A C4 5E 06  les bx, [bp+0x6]
0379  033D 26 FF 5F 04  call far word [es:bx+0x4]
            L0341: cx = PopStack(player);
            L0342: cx = PopStack(player);
            L0343: RefreshCompareFlags(ax);
            L0345: if (JumpNotEqual) goto L034A;
            L0347: goto L03F1;
            L034A: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L035D: if (JumpNotEqual) goto L0362;
            L035F: goto L03F1;
            L0362: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0375: if (JumpEqual) goto L03F1;
            L0377: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L038A: if (JumpEqual) goto L03F1;
            L038C: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L039F: if (JumpEqual) goto L03F1;
            L03A1: ShowMessage(player, String0A25); // 'I do appreciate thy efforts against the unholy creatures that reside within, and yet I have not the wherewithal to reward thee fully for thy repeated efforts.  This will have to suffice.'
            L03AE: AddExperience(player, 0x000003E8);
            L03BF: GiveItem(player, 0xBD);
            L03CB: ShowMessage(player, String0AE2); // 'But now I fear me that thou art needed elsewhere.  Farewell....'
            L03D8: PushStack(player, 0x00);
            L03DB: PushStack(player, 0x40);
            L03DF: PushStack(player, 0x01);
            L03E3: PushStack(player, ax);
0420  03E4 C4 5E 06  les bx, [bp+0x6]
0423  03E7 26 FF 9F BC 00  call far word [es:bx+0xbc]
0428  03EC 83 C4 08  add sp, 0x8
            L03EF: goto L040B;
            L03F1: ShowMessage(player, String0B24); // 'Be not disenheartened.  Remember, 'tis neither shame nor sin to retreat, regroup, return.  An thou maintains thy honor and grace, thou shalt succeed.'
            L03FE: ShowMessage(player, String0BBC); // 'Of course, the greatest rewards accrue to the champion who can survive this entire area,' he says, with a wink.
            L040B: return; // RETURN;
        }

        private void Fn_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E1;
            L001B: SetFlag(player, 0x03, 0x02, 0x01);
            L0030: ShowMessage(player, String0C2D); // What a motley crew.  Motley, but ready to rumble.
            L003D: PushStack(player, 0x7D);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, ax);
            L0046: PushStack(player, 0xBD);
            L004A: PushStack(player, 0xA0);
0497  004E C4 5E 06  les bx, [bp+0x6]
049A  0051 26 FF 9F D8 00  call far word [es:bx+0xd8]
049F  0056 83 C4 0C  add sp, 0xc
            L0059: AddEncounter(player, 0x01, 0x28);
            L006B: AddEncounter(player, 0x05, 0x20);
            L007D: Compare(PartyCount(player), 0x0002);
            L0088: if (JumpBelowOrEqual) goto L00AE;
            L008A: AddEncounter(player, 0x02, 0x1A);
            L009C: AddEncounter(player, 0x06, 0x1B);
            L00AE: Compare(PartyCount(player), 0x0003);
            L00B9: if (JumpBelowOrEqual) goto L00EE;
            L00BB: AddEncounter(player, 0x04, 0x26);
            L00CD: AddEncounter(player, 0x03, 0x1D);
            L00DF: goto L00EE;
            L00E1: ShowMessage(player, String0C5F); // The recollection of living and undead fighting together against you here is enough to make you shudder.
            L00EE: return; // RETURN;
        }

        private void Fn_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0017: if (JumpNotEqual) goto L006E;
            L0019: PushStack(player, 0x03);
            L001D: PushStack(player, ax);
0557  001E C4 5E 06  les bx, [bp+0x6]
055A  0021 26 FF 5F 04  call far word [es:bx+0x4]
            L0025: cx = PopStack(player);
            L0026: cx = PopStack(player);
            L0027: Compare(ax, 0x0001);
            L002A: if (JumpNotEqual) goto L006E;
            L002C: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L0040: if (JumpNotEqual) goto L006E;
            L0042: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L0056: if (JumpNotEqual) goto L006E;
            L0058: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L006C: if (JumpEqual) goto L009D;
            L006E: Compare(GetFlag(player, 0x02, 0x01), 0x0001);
            L0082: if (JumpEqual) goto L009D;
            L0084: Compare(GetFlag(player, 0x02, 0x01), 0x0002);
            L0098: if (JumpEqual) goto L009D;
            L009A: goto L0136;
            L009D: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00BB: Compare(GetFlag(player, 0x03, 0x0E), 0x0002);
            L00CF: if (JumpEqual) goto L0131;
            L00D1: ax = HasUsedItem(player, 0xC1, 0xC3);
            L00E4: if (JumpNotEqual) goto L010D;
            L00E6: ax = HasUsedItem(player, 0xDA, 0xDD);
            L00F9: if (JumpNotEqual) goto L010D;
            L00FB: PushStack(player, 0xC0);
            L00FF: PushStack(player, ax);
0639  0100 C4 5E 06  les bx, [bp+0x6]
063C  0103 26 FF 5F 54  call far word [es:bx+0x54]
            L0107: cx = PopStack(player);
            L0108: cx = PopStack(player);
            L0109: RefreshCompareFlags(ax);
            L010B: if (JumpEqual) goto L0131;
            L010D: ShowMessage(player, String0CC7); // You think the tool will enable you to proceed discreetly.
            L011A: SetFlag(player, 0x03, 0x0E, 0x03);
            L012F: goto L0150;
066A  0131 B8 01 00  mov ax, 0x1
            L0134: goto L011D;
            L0136: ShowMessage(player, String0D01); // A familiar voice whispers to you.
            L0143: ShowMessage(player, String0D23); // 'Before thou dost assay the ultimate combat in this place, thou hadst best prove thy mettle against the lesser evils found hereabouts.
            L0150: return; // RETURN;
        }

        private void Fn_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: ax = GetFlag(player, 0x02, 0x53);
06AA  001A 8B F8  mov di, ax
06AC  001C 47     inc di
06AD  001D 8B F7  mov si, di
            L001F: Compare(si, 0x13);
            L0022: if (JumpLessOrEqual) goto L002B;
06B4  0024 8B C6  mov ax, si
            L0026: si = ax + 0xFFEC;
            L002B: Compare(si, 0x0E);
            L002E: if (JumpLessOrEqual) goto L0037;
06C0  0030 8B C6  mov ax, si
            L0032: si = ax + 0xFFF1;
            L0037: Compare(si, 0x09);
            L003A: if (JumpLessOrEqual) goto L0043;
06CC  003C 8B C6  mov ax, si
            L003E: si = ax + 0xFFF6;
            L0043: Compare(si, 0x04);
            L0046: if (JumpLessOrEqual) goto L004F;
06D8  0048 8B C6  mov ax, si
            L004A: si = ax + 0xFFFB;
06DF  004F 0B F6  or si, si
06E1  0051 7D 02  jge 0x55
            L0053: si = 0;
            L0055: Compare(si, 0x1D);
            L0058: if (JumpLessOrEqual) goto L005C;
            L005A: si = 0;
06EC  005C 83 FF 18  cmp di, 0x18
            L005F: if (JumpLessOrEqual) goto L0063;
            L0061: di = 0;
06F3  0063 57     push di
            L0064: PushStack(player, 0x53);
            L0068: PushStack(player, 0x02);
06FC  006C C4 5E 06  les bx, [bp+0x6]
06FF  006F 26 FF 1F  call far word [es:bx]
0702  0072 83 C4 06  add sp, 0x6
0705  0075 83 FF 1A  cmp di, 0x1a
            L0078: if (JumpNotEqual) goto L007F;
070A  007A B8 01 00  mov ax, 0x1
            L007D: goto L0081;
            L007F: PushStack(player, 0x00);
0712  0082 83 FF 14  cmp di, 0x14
            L0085: if (JumpNotEqual) goto L008C;
0717  0087 B8 01 00  mov ax, 0x1
            L008A: goto L008E;
071C  008C 33 C0  xor ax, ax
            L008E: dx = PopStack(player);
071F  008F 0B D0  or dx, ax
            L0091: PushStack(player, dx);
0722  0092 83 FF 0E  cmp di, 0xe
            L0095: if (JumpNotEqual) goto L009C;
0727  0097 B8 01 00  mov ax, 0x1
            L009A: goto L009E;
072C  009C 33 C0  xor ax, ax
            L009E: dx = PopStack(player);
072F  009F 0B D0  or dx, ax
            L00A1: PushStack(player, dx);
0732  00A2 83 FF 08  cmp di, 0x8
            L00A5: if (JumpNotEqual) goto L00AC;
0737  00A7 B8 01 00  mov ax, 0x1
            L00AA: goto L00AE;
073C  00AC 33 C0  xor ax, ax
            L00AE: dx = PopStack(player);
073F  00AF 0B D0  or dx, ax
            L00B1: PushStack(player, dx);
0742  00B2 83 FF 02  cmp di, 0x2
            L00B5: if (JumpNotEqual) goto L00BC;
0747  00B7 B8 01 00  mov ax, 0x1
            L00BA: goto L00BE;
074C  00BC 33 C0  xor ax, ax
            L00BE: dx = PopStack(player);
074F  00BF 0B D0  or dx, ax
            L00C1: if (JumpNotEqual) goto L00C6;
            L00C3: goto L01DA;
0756  00C6 8B C6  mov ax, si
            L00C8: bx = ax;
            L00CA: Compare(bx, 0x04);
            L00CD: if (JumpBelowOrEqual) goto L00D2;
            L00CF: goto L01DA;
            L00D2: switch (bx) {
                case 0:
                    goto L00D9;
                case 1:
                    goto L00F9;
                case 2:
                    goto L0119;
                case 3:
                    goto L0146;
                case 4:
                    goto L01A6;
            }
            L00D9: ShowPortrait(player, 0x0025);
            L00E6: ShowMessage(player, String0DAA); // You see a heavily scarred and well equipped halfling thief scuttling from pillar to post.  He wears a Thief's Tabard and carries a Dalriadan Bow, and you can hear him softly chanting, 'Here, ghoulie ghoulie ghoulie.'
0783  00F3 B8 83 0E  mov ax, 0xe83
            L00F6: goto L01D0;
            L00F9: ShowPortrait(player, 0x001A);
            L0106: ShowMessage(player, String0EB0); // A large orcish knight, bearing Wulfherd's Shield and Hilda's Hammer, greets you.
07A3  0113 B8 01 0F  mov ax, 0xf01
            L0116: goto L01D0;
            L0119: ShowPortrait(player, 0x001D);
            L0126: ShowMessage(player, String0FF4); // A small, smiling halfling knight, wearing a Holy Relic, bearing Oswald's Bane, and wielding Malcolm's Chopper, is noisily stalking an obviously empty part of the room.  Her eyes are filled with madness as they meet yours.
            L0133: ShowMessage(player, String10D2); // 'Shh!  I have found that which will enable me to defeat all forms of undead.  By conquering death I shall live forever!  Do not follow me!  He is MINE!'
07D0  0140 B8 6B 11  mov ax, 0x116b
            L0143: goto L01D0;
            L0146: ShowPortrait(player, 0x002C);
            L0153: ShowMessage(player, String0161); // *
            L0160: ShowMessage(player, String0161); // *
            L016D: ShowMessage(player, String0161); // *
            L017A: ShowMessage(player, String11A3); // A dwarf holds up her hand in greeting.
            L0187: ShowMessage(player, String11CA); // 'I say, chaps!  I have been literally going in circles searching for Oswald's Bane or My Lady's Favor, both of which I need to teach a certain lich a lesson.  Would you happen to have a spare set on you?'
            L0194: ShowMessage(player, String1297); // You shake your head.
0831  01A1 B8 AC 12  mov ax, 0x12ac
            L01A4: goto L01D0;
            L01A6: ShowMessage(player, String0161); // *
            L01B3: ShowMessage(player, String0161); // *
            L01C0: ShowMessage(player, String0161); // *
            L01CD: ShowMessage(player, String12CC); // Rushing towards you are the biggest giant and the biggest ghost you have ever seen.  The ghost drives the giant with huge hammering blows, and yet the giant's shield, Edwin's Defender, seems to deflect most of the damage.  You decide, wisely, not to intervene.
            L01DA: return; // RETURN (restoring si, di);
        }

        private void Fn_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x06), 0x0001);
            L0017: if (JumpEqual) goto L002F;
            L0019: Compare(GetFlag(player, 0x03, 0x0A), 0x0001);
            L002D: if (JumpNotEqual) goto L0042;
            L002F: ShowMessage(player, String13D1); // A voice whispers from thin air....
08B9  003C B8 F4 13  mov ax, 0x13f4
            L003F: goto L03D2;
            L0042: ShowPortrait(player, 0x0015);
            L004F: SetFlag(player, 0x03, 0x0A, 0x01);
            L0064: Compare(GetFlag(player, 0x02, 0x00), 0x0001);
            L0077: if (JumpEqual) goto L007C;
            L0079: goto L025B;
            L007C: Compare(GetFlag(player, 0x02, 0x05), 0x0001);
            L0090: if (JumpEqual) goto L0095;
            L0092: goto L025B;
            L0095: PushStack(player, 0x02);
            L0099: PushStack(player, ax);
0917  009A C4 5E 06  les bx, [bp+0x6]
091A  009D 26 FF 5F 04  call far word [es:bx+0x4]
            L00A1: cx = PopStack(player);
            L00A2: cx = PopStack(player);
            L00A3: Compare(ax, 0x0001);
            L00A6: if (JumpEqual) goto L00AB;
            L00A8: goto L025B;
            L00AB: Compare(GetFlag(player, 0x02, 0x03), 0x0001);
            L00BF: if (JumpEqual) goto L00C4;
            L00C1: goto L025B;
            L00C4: Compare(GetFlag(player, 0x02, 0x04), 0x0001);
            L00D8: if (JumpEqual) goto L00DD;
            L00DA: goto L025B;
            L00DD: ShowMessage(player, String0161); // *
            L00EA: ShowMessage(player, String0161); // *
            L00F7: ShowMessage(player, String0161); // *
            L0104: ShowMessage(player, String1431); // 'Huzzah!  Thou hast done so well hitherto that I can safely reward thee.  I think me knowledge of the spell of shielding will best serve thee now.'
            L0111: ShowMessage(player, String14C5); // You realize that you now know that spell!
            L011E: SetSpellLevel(player, 0x0F, 0x01);
            L012F: SetFlag(player, 0x02, 0x06, 0x01);
            L0144: RefreshCompareFlags(GetFlag(player, 0x02, 0x01));
            L0157: if (JumpNotEqual) goto L0180;
            L0159: PushStack(player, 0x01);
            L015D: PushStack(player, ax);
            L015E: PushStack(player, 0x02);
09DF  0162 C4 5E 06  les bx, [bp+0x6]
09E2  0165 26 FF 1F  call far word [es:bx]
09E5  0168 83 C4 06  add sp, 0x6
            L016B: SetFlag(player, 0x03, 0x0D, 0x01);
            L0180: RefreshCompareFlags(GetFlag(player, 0x02, 0x0E));
            L0193: if (JumpEqual) goto L0198;
            L0195: goto L03DC;
            L0198: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L01AB: if (JumpNotEqual) goto L01B0;
            L01AD: goto L03DC;
            L01B0: PushStack(player, 0x03);
            L01B4: PushStack(player, ax);
0A32  01B5 C4 5E 06  les bx, [bp+0x6]
0A35  01B8 26 FF 5F 04  call far word [es:bx+0x4]
            L01BC: cx = PopStack(player);
            L01BD: cx = PopStack(player);
            L01BE: RefreshCompareFlags(ax);
            L01C0: if (JumpNotEqual) goto L01C5;
            L01C2: goto L03DC;
            L01C5: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L01D8: if (JumpNotEqual) goto L01DD;
            L01DA: goto L03DC;
            L01DD: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L01F0: if (JumpNotEqual) goto L01F5;
            L01F2: goto L03DC;
            L01F5: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0208: if (JumpNotEqual) goto L020D;
            L020A: goto L03DC;
            L020D: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0220: if (JumpNotEqual) goto L0225;
            L0222: goto L03DC;
            L0225: SetFlag(player, 0x02, 0x0E, 0x01);
            L023A: ShowMessage(player, String14EF); // 'And Oh! Stalwart questor!  Thou hast been well and throughly blooded on this journey.  I think me it is long past time that thou didst know the magical ways of self-healing.'
            L0247: SetSpellLevel(player, 0x14, 0x03);
            L0258: goto L03DC;
            L025B: RefreshCompareFlags(GetFlag(player, 0x02, 0x0E));
            L026E: if (JumpEqual) goto L0273;
            L0270: goto L034F;
            L0273: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0286: if (JumpNotEqual) goto L028B;
            L0288: goto L034F;
            L028B: PushStack(player, 0x03);
            L028F: PushStack(player, ax);
0B0D  0290 C4 5E 06  les bx, [bp+0x6]
0B10  0293 26 FF 5F 04  call far word [es:bx+0x4]
            L0297: cx = PopStack(player);
            L0298: cx = PopStack(player);
            L0299: RefreshCompareFlags(ax);
            L029B: if (JumpNotEqual) goto L02A0;
            L029D: goto L034F;
            L02A0: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L02B3: if (JumpNotEqual) goto L02B8;
            L02B5: goto L034F;
            L02B8: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L02CB: if (JumpNotEqual) goto L02D0;
            L02CD: goto L034F;
            L02D0: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L02E3: if (JumpEqual) goto L034F;
            L02E5: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L02F8: if (JumpEqual) goto L034F;
            L02FA: ShowMessage(player, String159F); // Galatea draws you aside for a private message.
            L0307: ShowMessage(player, String15CE); // 'Oh! Stalwart questor!  Thou hast been well and throughly blooded on this journey.  I think me it is long past time that thou didst know the magical ways of self-healing.'
            L0314: PushStack(player, 0x01);
            L0318: PushStack(player, ax);
            L0319: PushStack(player, 0x02);
0B9A  031D C4 5E 06  les bx, [bp+0x6]
0B9D  0320 26 FF 1F  call far word [es:bx]
0BA0  0323 83 C4 06  add sp, 0x6
            L0326: SetSpellLevel(player, 0x14, 0x03);
            L0337: SetFlag(player, 0x02, 0x0E, 0x01);
            L034C: goto L03DC;
            L034F: Compare(GetGuild(player), 0x0004);
            L0359: if (JumpNotEqual) goto L036D;
            L035B: ShowMessage(player, String159F); // Galatea draws you aside for a private message.
0BE5  0368 B8 7A 16  mov ax, 0x167a
            L036B: goto L03D2;
            L036D: PushStack(player, 0x04);
0BEE  0371 C4 5E 06  les bx, [bp+0x6]
0BF1  0374 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L0379: cx = PopStack(player);
            L037A: RefreshCompareFlags(ax);
            L037C: if (JumpEqual) goto L038B;
            L037E: ShowMessage(player, String1719); // Galatea pulls your party's clerics aside for a few private words, and then returns.
            L038B: RefreshCompareFlags(GetFlag(player, 0x02, 0x72));
            L039E: if (JumpNotEqual) goto L03CF;
            L03A0: ShowMessage(player, String176D); // 'Thou art surviving, which is the important thing.  Take thee this item which mayhaps will help thee to continue doing so.'
            L03AD: SetFlag(player, 0x02, 0x72, 0x01);
            L03C2: PushStack(player, 0xBD);
0C43  03C6 C4 5E 06  les bx, [bp+0x6]
0C46  03C9 26 FF 5F 48  call far word [es:bx+0x48]
            L03CD: goto L03DB;
            L03CF: ShowMessage(player, String17E9); // 'Thou hast earned no further rewards from me, thou witless chaff.'
            L03DC: return; // RETURN;
        }

        private void Fn_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L0017: if (JumpNotEqual) goto L0029;
            L0019: ShowMessage(player, String182C); // When these ghouls were bad, they were very very bad.
            L0026: goto L00ED;
            L0029: SetFlag(player, 0x03, 0x04, 0x01);
            L003E: ShowMessage(player, String1861); // Some ghouls just don't take no for an answer.
            L004B: PushStack(player, 0xCF);
            L004F: PushStack(player, 0x00);
            L0052: PushStack(player, ax);
            L0053: PushStack(player, ax);
            L0054: PushStack(player, 0xB9);
            L0058: PushStack(player, 0xCB);
0CBC  005C C4 5E 06  les bx, [bp+0x6]
0CBF  005F 26 FF 9F D8 00  call far word [es:bx+0xd8]
0CC4  0064 83 C4 0C  add sp, 0xc
            L0067: AddEncounter(player, 0x01, 0x28);
            L0079: AddEncounter(player, 0x05, 0x20);
            L008B: Compare(PartyCount(player), 0x0002);
            L0096: if (JumpBelowOrEqual) goto L00BC;
            L0098: AddEncounter(player, 0x02, 0x28);
            L00AA: AddEncounter(player, 0x06, 0x19);
            L00BC: Compare(PartyCount(player), 0x0003);
            L00C7: if (JumpBelowOrEqual) goto L00ED;
            L00C9: AddEncounter(player, 0x03, 0x1E);
            L00DB: AddEncounter(player, 0x04, 0x1F);
            L00ED: return; // RETURN;
        }

        private void Fn_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L0017: if (JumpNotEqual) goto L0029;
            L0019: ShowMessage(player, String188F); // Bloodsuckers and would be bloodsuckers make this place painful to recollect.
            L0026: goto L016D;
            L0029: ShowMessage(player, String18DC); // You've just found crypt central!
            L0036: Compare(GetCurrentTile(player), 0x0088);
            L0040: if (JumpNotEqual) goto L0081;
            L0042: Compare(GetFlag(player, 0x03, 0x05), 0x0003);
            L0056: if (JumpNotEqual) goto L007C;
            L0058: SetFlag(player, 0x03, 0x05, 0x01);
            L006D: ShowMessage(player, String18FD); // Again!
            L007A: goto L00AE;
0DCB  007C B8 02 00  mov ax, 0x2
            L007F: goto L009C;
            L0081: Compare(GetFlag(player, 0x03, 0x05), 0x0002);
            L0095: if (JumpNotEqual) goto L0099;
            L0097: goto L0058;
            L0099: SetFlag(player, 0x03, 0x05, 0x03);
            L00AE: Compare(PartyCount(player), 0x0002);
            L00B9: if (JumpBelowOrEqual) goto L00C8;
            L00BB: ShowMessage(player, String1904); // And you without your Red Cross card.
            L00C8: PushStack(player, 0xBC);
            L00CC: PushStack(player, 0x00);
            L00CF: PushStack(player, ax);
            L00D0: PushStack(player, 0xCB);
            L00D4: PushStack(player, 0x72);
            L00D8: PushStack(player, 0xA0);
0E2B  00DC C4 5E 06  les bx, [bp+0x6]
0E2E  00DF 26 FF 9F D8 00  call far word [es:bx+0xd8]
0E33  00E4 83 C4 0C  add sp, 0xc
            L00E7: AddEncounter(player, 0x01, 0x28);
            L00F9: AddEncounter(player, 0x02, 0x22);
            L010B: Compare(PartyCount(player), 0x0001);
            L0116: if (JumpBelowOrEqual) goto L012A;
            L0118: AddEncounter(player, 0x05, 0x20);
            L012A: Compare(PartyCount(player), 0x0002);
            L0135: if (JumpBelowOrEqual) goto L016D;
            L0137: AddEncounter(player, 0x03, 0x22);
            L0149: AddEncounter(player, 0x04, 0x22);
            L015B: AddEncounter(player, 0x06, 0x20);
            L016D: return; // RETURN;
        }

        private void Fn_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L0017: if (JumpNotEqual) goto L0029;
            L0019: ShowMessage(player, String1929); // At least the beings you fought here bled when cut.
            L0026: goto L016D;
            L0029: ShowMessage(player, String195C); // The good news is there don't appear to be any undead in this group of folks attacking you.
            L0036: Compare(GetCurrentTile(player), 0x00F8);
            L0040: if (JumpNotEqual) goto L0081;
            L0042: Compare(GetFlag(player, 0x03, 0x06), 0x0003);
            L0056: if (JumpNotEqual) goto L007C;
            L0058: SetFlag(player, 0x03, 0x06, 0x01);
            L006D: ShowMessage(player, String18FD); // Again!
            L007A: goto L00AE;
0F3A  007C B8 02 00  mov ax, 0x2
            L007F: goto L009C;
            L0081: Compare(GetFlag(player, 0x03, 0x06), 0x0002);
            L0095: if (JumpNotEqual) goto L0099;
            L0097: goto L0058;
            L0099: SetFlag(player, 0x03, 0x06, 0x03);
            L00AE: Compare(PartyCount(player), 0x0002);
            L00B9: if (JumpBelowOrEqual) goto L00C8;
            L00BB: ShowMessage(player, String19B7); // The bad news is, there probably doesn't need to be!
            L00C8: PushStack(player, 0xBC);
            L00CC: PushStack(player, 0x00);
            L00CF: PushStack(player, ax);
            L00D0: PushStack(player, 0xCB);
            L00D4: PushStack(player, 0x83);
            L00D8: PushStack(player, 0xB9);
0F9A  00DC C4 5E 06  les bx, [bp+0x6]
0F9D  00DF 26 FF 9F D8 00  call far word [es:bx+0xd8]
0FA2  00E4 83 C4 0C  add sp, 0xc
            L00E7: AddEncounter(player, 0x01, 0x19);
            L00F9: AddEncounter(player, 0x02, 0x27);
            L010B: Compare(PartyCount(player), 0x0001);
            L0116: if (JumpBelowOrEqual) goto L012A;
            L0118: AddEncounter(player, 0x05, 0x19);
            L012A: Compare(PartyCount(player), 0x0002);
            L0135: if (JumpBelowOrEqual) goto L016D;
            L0137: AddEncounter(player, 0x03, 0x21);
            L0149: AddEncounter(player, 0x04, 0x23);
            L015B: AddEncounter(player, 0x06, 0x24);
            L016D: return; // RETURN;
        }

        private void Fn_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L0017: if (JumpNotEqual) goto L0029;
            L0019: ShowMessage(player, String19EB); // 'This battle was nae so bad,' you tell yourself.  Of course, having survived it makes all the difference in the world.
            L0026: goto L017C;
            L0029: SetFlag(player, 0x03, 0x07, 0x01);
            L003E: RefreshCompareFlags(GetFlag(player, 0x03, 0x0E));
            L0051: if (JumpNotEqual) goto L0078;
            L0053: ShowMessage(player, String1A62); // The canny undead were lying in wait.
            L0060: ax = GetCurrentHits(player);
            L0067: bx = 0x0003;
            L006A: dx = ax % bx; ax = ax / bx;
            L006D: PushStack(player, ax);
109B  006E C4 5E 06  les bx, [bp+0x6]
109E  0071 26 FF 9F 90 00  call far word [es:bx+0x90]
            L0076: goto L00B8;
            L0078: ShowMessage(player, String1A87); // There are the makings of an ambush here, but you seem to have caught them unawares.  Then again, who can tell what undead are thinking.
            L0085: AddExperience(player, 0x000001F4);
            L0096: Compare(GetFlag(player, 0x03, 0x0F), 0x0001);
            L00AA: if (JumpNotEqual) goto L00B9;
            L00AC: ShowMessage(player, String1B0F); // You're thinking it's a good thing that undead have short attention spans.
            L00B9: Compare(PartyCount(player), 0x0002);
            L00C4: if (JumpBelowOrEqual) goto L00D3;
            L00C6: ShowMessage(player, String1B59); // This looked bad enough, but as the rest of them shamble forwards, it looks worse.
            L00D3: SetFlag(player, 0x03, 0x0E, 0x00);
1114  00E7 B8 1E 02  mov ax, 0x21e
            L00EA: PushStack(player, ax);
            L00EB: PushStack(player, 0x00);
            L00EE: PushStack(player, ax);
            L00EF: PushStack(player, ax);
            L00F0: PushStack(player, 0xCB);
            L00F4: PushStack(player, 0xB9);
1125  00F8 C4 5E 06  les bx, [bp+0x6]
1128  00FB 26 FF 9F D8 00  call far word [es:bx+0xd8]
112D  0100 83 C4 0C  add sp, 0xc
            L0103: AddEncounter(player, 0x01, 0x28);
            L0115: AddEncounter(player, 0x02, 0x28);
            L0127: AddEncounter(player, 0x05, 0x25);
            L0139: AddEncounter(player, 0x06, 0x25);
            L014B: Compare(PartyCount(player), 0x0002);
            L0156: if (JumpBelowOrEqual) goto L017C;
            L0158: AddEncounter(player, 0x03, 0x28);
            L016A: AddEncounter(player, 0x04, 0x28);
            L017C: return; // RETURN;
        }

        private void Fn_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00BD;
            L001B: Compare(GetFlag(player, 0x03, 0x0E), 0x0003);
            L002F: if (JumpEqual) goto L0071;
            L0031: Compare(GetFlag(player, 0x03, 0x0E), 0x0001);
            L0045: if (JumpNotEqual) goto L0087;
            L0047: ax = HasUsedItem(player, 0xC1, 0xC3);
            L005A: if (JumpNotEqual) goto L0071;
            L005C: ax = HasUsedItem(player, 0xDA, 0xDD);
            L006F: if (JumpEqual) goto L0087;
            L0071: ShowMessage(player, String1BAB); // Carefully using the tool, you managed to open the door without much noise.
            L007E: PushStack(player, 0x03);
122D  0082 B8 0E 00  mov ax, 0xe
            L0085: goto L00AF;
            L0087: ShowMessage(player, String1BF6); // The door made a lot of noise as you came through.
            L0094: SetFlag(player, 0x03, 0x0E, 0x00);
            L00A8: SetFlag(player, 0x03, 0x0F, 0x01);
            L00BD: return; // RETURN;
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x03, 0x0E, 0x00);
            L0017: return; // RETURN;
        }

        private void Fn_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x10));
            L0016: if (JumpNotEqual) goto L005F;
            L0018: Compare(GetFlag(player, 0x03, 0x13), 0x0001);
            L002C: if (JumpNotEqual) goto L003D;
            L002E: ShowMessage(player, String1C28); // This appears to be another confessional waiting room.
            L003B: goto L005F;
            L003D: ShowMessage(player, String1C5E); // This seems to be a well-appointed confessional waiting room.  There are chairs and a sofa here.  The confessional proper is behind a partition on the southern wall.
            L004A: SetFlag(player, 0x03, 0x10, 0x01);
            L005F: return; // RETURN;
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
12EC  0008 C4 5E 06  les bx, [bp+0x6]
12EF  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: Compare(ax, 0x0001);
            L0014: if (JumpNotEqual) goto L0026;
            L0016: ShowMessage(player, String1D03); // You smile, grimly: you, at least, walked away from this killing place.
            L0023: goto L014D;
            L0026: RefreshCompareFlags(GetFlag(player, 0x03, 0x19));
            L0039: if (JumpNotEqual) goto L0061;
            L003B: ShowMessage(player, String1D4A); // Oh fie!  'Tis an ambush!
            L0048: ax = GetMaxHits(player);
            L004F: bx = 0x0004;
            L0052: dx = ax % bx; ax = ax / bx;
            L0055: DamagePlayer(player, ax);
            L005F: goto L007F;
            L0061: ShowMessage(player, String1D63); // Your careful approach prevents you from being surprised.  Well done!
            L006E: AddExperience(player, 0x000001F4);
            L007F: PushStack(player, 0x01);
            L0083: PushStack(player, 0x03);
            L0087: PushStack(player, ax);
136C  0088 C4 5E 06  les bx, [bp+0x6]
136F  008B 26 FF 1F  call far word [es:bx]
1372  008E 83 C4 06  add sp, 0x6
            L0091: Compare(PartyCount(player), 0x0003);
            L009C: if (JumpBelowOrEqual) goto L00AB;
            L009E: ShowMessage(player, String1DA8); // You have a job ahead of you.
138F  00AB B8 1E 02  mov ax, 0x21e
            L00AE: PushStack(player, ax);
            L00AF: PushStack(player, 0x00);
            L00B2: PushStack(player, ax);
            L00B3: PushStack(player, ax);
            L00B4: PushStack(player, 0xCB);
            L00B8: PushStack(player, 0xB8);
13A0  00BC C4 5E 06  les bx, [bp+0x6]
13A3  00BF 26 FF 9F D8 00  call far word [es:bx+0xd8]
13A8  00C4 83 C4 0C  add sp, 0xc
            L00C7: AddEncounter(player, 0x01, 0x28);
            L00D9: AddEncounter(player, 0x02, 0x28);
            L00EB: Compare(PartyCount(player), 0x0002);
            L00F6: if (JumpBelowOrEqual) goto L011C;
            L00F8: AddEncounter(player, 0x05, 0x20);
            L010A: AddEncounter(player, 0x06, 0x20);
            L011C: Compare(PartyCount(player), 0x0003);
            L0127: if (JumpBelowOrEqual) goto L014D;
            L0129: AddEncounter(player, 0x03, 0x28);
            L013B: AddEncounter(player, 0x04, 0x28);
            L014D: return; // RETURN;
        }

        private void Fn_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x11));
            L0016: if (JumpNotEqual) goto L005F;
            L0018: Compare(GetFlag(player, 0x03, 0x12), 0x0001);
            L002C: if (JumpNotEqual) goto L003D;
            L002E: ShowMessage(player, String1C28); // This appears to be another confessional waiting room.
            L003B: goto L005F;
            L003D: ShowMessage(player, String1DC5); // This appears to be a well-appointed confessional waiting room.  Several chairs lie around.  The confessional itself seems to be behind a partition on the northern wall.
            L004A: SetFlag(player, 0x03, 0x11, 0x01);
            L005F: return; // RETURN;
        }

        private void Fn_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x02);
            L0007: PushStack(player, 0x40);
            L000B: PushStack(player, 0x01);
            L000F: PushStack(player, ax);
14AE  0010 C4 5E 06  les bx, [bp+0x6]
14B1  0013 26 FF 9F BC 00  call far word [es:bx+0xbc]
14B6  0018 83 C4 08  add sp, 0x8
            L001B: return; // RETURN;
        }

        private void Fn_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x12));
            L0016: if (JumpNotEqual) goto L005F;
            L0018: Compare(GetFlag(player, 0x03, 0x11), 0x0001);
            L002C: if (JumpNotEqual) goto L003D;
            L002E: ShowMessage(player, String1C28); // This appears to be another confessional waiting room.
            L003B: goto L005F;
            L003D: ShowMessage(player, String1E6E); // This appears to be a well-appointed confessional waiting room.  Several chairs lie around.  The confessional itself seems to be behind a partition on the southern wall.
            L004A: SetFlag(player, 0x03, 0x12, 0x01);
            L005F: return; // RETURN;
        }

        private void Fn_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x13));
            L0016: if (JumpNotEqual) goto L005F;
            L0018: Compare(GetFlag(player, 0x03, 0x10), 0x0001);
            L002C: if (JumpNotEqual) goto L003D;
            L002E: ShowMessage(player, String1C28); // This appears to be another confessional waiting room.
            L003B: goto L005F;
            L003D: ShowMessage(player, String1F17); // This seems to be a well-appointed confessional waiting room.  There are chairs and a sofa here.  The confessional proper is behind a partition on the northern wall.
            L004A: SetFlag(player, 0x03, 0x13, 0x01);
            L005F: return; // RETURN;
        }

        private void Fn_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0B), 0x0001);
            L0012: if (JumpNotBelow) goto L004A;
            L0014: PushStack(player, 0xA6);
            L0018: PushStack(player, ax);
1596  0019 C4 5E 06  les bx, [bp+0x6]
1599  001C 26 FF 5F 54  call far word [es:bx+0x54]
            L0020: cx = PopStack(player);
            L0021: cx = PopStack(player);
            L0022: RefreshCompareFlags(ax);
            L0024: if (JumpNotEqual) goto L004A;
            L0026: PushStack(player, 0x62);
            L002A: PushStack(player, ax);
15A8  002B C4 5E 06  les bx, [bp+0x6]
15AB  002E 26 FF 5F 54  call far word [es:bx+0x54]
            L0032: cx = PopStack(player);
            L0033: cx = PopStack(player);
            L0034: RefreshCompareFlags(ax);
            L0036: if (JumpNotEqual) goto L004A;
            L0038: PushStack(player, 0x8F);
            L003C: PushStack(player, ax);
15BA  003D C4 5E 06  les bx, [bp+0x6]
15BD  0040 26 FF 5F 54  call far word [es:bx+0x54]
            L0044: cx = PopStack(player);
            L0045: cx = PopStack(player);
            L0046: RefreshCompareFlags(ax);
            L0048: if (JumpEqual) goto L006C;
            L004A: ShowMessage(player, String1FBC); // You find some fresh tracks leading towards the altar in the northwest corner.  You start moving more warily. 
            L0057: SetFlag(player, 0x03, 0x19, 0x01);
            L006C: return; // RETURN;
        }

        private void Fn_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x15));
            L0016: if (JumpNotEqual) goto L0061;
            L0018: ShowMessage(player, String0161); // *
            L0025: ShowMessage(player, String0161); // *
            L0032: ShowMessage(player, String0161); // *
            L003F: ShowMessage(player, String202A); // This was the nave of this chapel.  The outside walls are covered with stained glass.  Someone scavenged the pews for firewood, leaving only their stone foundations and the odd broken piece of wood.  In the northwest corner an altar lies in serious disrepair.
            L004C: SetFlag(player, 0x03, 0x15, 0x01);
            L0061: SetFlag(player, 0x03, 0x19, 0x00);
            L0075: return; // RETURN;
        }

        private void Fn_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x0F), 0x0001);
            L0017: if (JumpNotEqual) goto L001F;
168A  0019 B8 2D 21  mov ax, 0x212d
            L001C: goto L00D2;
            L001F: Compare(HasUsedSkill(player, 0x0D), 0x0004);
            L002E: if (JumpAbove) goto L009A;
            L0030: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L003E: if (JumpNotEqual) goto L009A;
            L0040: PushStack(player, 0xA7);
            L0044: PushStack(player, ax);
16B6  0045 C4 5E 06  les bx, [bp+0x6]
16B9  0048 26 FF 5F 54  call far word [es:bx+0x54]
            L004C: cx = PopStack(player);
            L004D: cx = PopStack(player);
            L004E: RefreshCompareFlags(ax);
            L0050: if (JumpNotEqual) goto L009A;
            L0052: PushStack(player, 0x67);
            L0056: PushStack(player, ax);
16C8  0057 C4 5E 06  les bx, [bp+0x6]
16CB  005A 26 FF 5F 54  call far word [es:bx+0x54]
            L005E: cx = PopStack(player);
            L005F: cx = PopStack(player);
            L0060: RefreshCompareFlags(ax);
            L0062: if (JumpNotEqual) goto L009A;
            L0064: PushStack(player, 0x61);
            L0068: PushStack(player, ax);
16DA  0069 C4 5E 06  les bx, [bp+0x6]
16DD  006C 26 FF 5F 54  call far word [es:bx+0x54]
            L0070: cx = PopStack(player);
            L0071: cx = PopStack(player);
            L0072: RefreshCompareFlags(ax);
            L0074: if (JumpNotEqual) goto L009A;
            L0076: PushStack(player, 0x93);
            L007A: PushStack(player, ax);
16EC  007B C4 5E 06  les bx, [bp+0x6]
16EF  007E 26 FF 5F 54  call far word [es:bx+0x54]
            L0082: cx = PopStack(player);
            L0083: cx = PopStack(player);
            L0084: RefreshCompareFlags(ax);
            L0086: if (JumpNotEqual) goto L009A;
            L0088: PushStack(player, 0x86);
            L008C: PushStack(player, ax);
16FE  008D C4 5E 06  les bx, [bp+0x6]
1701  0090 26 FF 5F 54  call far word [es:bx+0x54]
            L0094: cx = PopStack(player);
            L0095: cx = PopStack(player);
            L0096: RefreshCompareFlags(ax);
            L0098: if (JumpEqual) goto L00CF;
            L009A: ShowMessage(player, String215B); // After several minutes of dusty digging, you uncover a veritable kobold's fortune: 471 gold pieces!
            L00A7: SetFlag(player, 0x02, 0x0F, 0x01);
            L00BC: ModifyGold(player, 0x01D7);
            L00CD: goto L00DC;
            L00CF: ShowMessage(player, String21BE); // Sadly, this once fine altar has been thoroughly vandalised.
            L00DC: return; // RETURN;
        }

        private void Fn_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x14));
            L0016: if (JumpNotEqual) goto L0061;
            L0018: ShowMessage(player, String0161); // *
            L0025: ShowMessage(player, String0161); // *
            L0032: ShowMessage(player, String0161); // *
            L003F: ShowMessage(player, String21FA); // This was once a humbly furnished dining room, but the benches and tables have long since been converted to kindling.
            L004C: SetFlag(player, 0x03, 0x14, 0x01);
            L0061: return; // RETURN;
        }

        private void Fn_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x16));
            L0016: if (JumpNotEqual) goto L003A;
            L0018: ShowMessage(player, String226F); // This was once a large and well equipped kitchen, but it is obvious that over the years it has been well and thoroughly ransacked.
            L0025: SetFlag(player, 0x03, 0x16, 0x01);
            L003A: return; // RETURN;
        }

        private void Fn_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x17));
            L0016: if (JumpNotEqual) goto L003A;
            L0018: ShowMessage(player, String22F1); // This is an overgrown but still beautiful garden.  It is filled with roses and other flowers.  A plot to the south has herbs clearly labelled.  To the north some fountains still provide running water.  After a minute of silent admiration, some birds begin singing, as if accepting your presence here.
            L0025: SetFlag(player, 0x03, 0x17, 0x01);
            L003A: return; // RETURN;
        }

        private void Fn_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x1B), 0x0001);
            L0017: if (JumpNotEqual) goto L001F;
1843  0019 B8 1D 24  mov ax, 0x241d
            L001C: goto L013C;
            L001F: ax = HasItem(player, 0x9D);
            L002D: if (JumpNotEqual) goto L0045;
            L002F: Compare(GetFlag(player, 0x02, 0x10), 0x0001);
            L0043: if (JumpNotEqual) goto L0082;
            L0045: SetFlag(player, 0x03, 0x1A, 0x01);
            L005A: SetFlag(player, 0x03, 0x1B, 0x01);
            L006F: ShowMessage(player, String244B); // You remember how to find the garlic here.  There is one big ripe bud.
18A6  007C B8 91 24  mov ax, 0x2491
            L007F: goto L013C;
            L0082: Compare(HasUsedSkill(player, 0x0D), 0x0004);
            L0091: if (JumpAbove) goto L00FD;
            L0093: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L00A1: if (JumpNotEqual) goto L00FD;
            L00A3: PushStack(player, 0xA7);
            L00A7: PushStack(player, ax);
18D2  00A8 C4 5E 06  les bx, [bp+0x6]
18D5  00AB 26 FF 5F 54  call far word [es:bx+0x54]
            L00AF: cx = PopStack(player);
            L00B0: cx = PopStack(player);
            L00B1: RefreshCompareFlags(ax);
            L00B3: if (JumpNotEqual) goto L00FD;
            L00B5: PushStack(player, 0x67);
            L00B9: PushStack(player, ax);
18E4  00BA C4 5E 06  les bx, [bp+0x6]
18E7  00BD 26 FF 5F 54  call far word [es:bx+0x54]
            L00C1: cx = PopStack(player);
            L00C2: cx = PopStack(player);
            L00C3: RefreshCompareFlags(ax);
            L00C5: if (JumpNotEqual) goto L00FD;
            L00C7: PushStack(player, 0x61);
            L00CB: PushStack(player, ax);
18F6  00CC C4 5E 06  les bx, [bp+0x6]
18F9  00CF 26 FF 5F 54  call far word [es:bx+0x54]
            L00D3: cx = PopStack(player);
            L00D4: cx = PopStack(player);
            L00D5: RefreshCompareFlags(ax);
            L00D7: if (JumpNotEqual) goto L00FD;
            L00D9: PushStack(player, 0x93);
            L00DD: PushStack(player, ax);
1908  00DE C4 5E 06  les bx, [bp+0x6]
190B  00E1 26 FF 5F 54  call far word [es:bx+0x54]
            L00E5: cx = PopStack(player);
            L00E6: cx = PopStack(player);
            L00E7: RefreshCompareFlags(ax);
            L00E9: if (JumpNotEqual) goto L00FD;
            L00EB: PushStack(player, 0x86);
            L00EF: PushStack(player, ax);
191A  00F0 C4 5E 06  les bx, [bp+0x6]
191D  00F3 26 FF 5F 54  call far word [es:bx+0x54]
            L00F7: cx = PopStack(player);
            L00F8: cx = PopStack(player);
            L00F9: RefreshCompareFlags(ax);
            L00FB: if (JumpEqual) goto L0139;
            L00FD: SetFlag(player, 0x02, 0x10, 0x01);
            L0112: SetFlag(player, 0x03, 0x1A, 0x01);
            L0127: ShowMessage(player, String2536); // A plethora of fine herbs are here: thyme, basil, rosemary, and - what is this?  You have found a healthy patch of garlic!
195E  0134 B8 B0 25  mov ax, 0x25b0
            L0137: goto L013C;
            L0139: ShowMessage(player, String2618); // These herbs will be a pleasant addition to your cooking kit.  Almost anything to flavor trail rations will be much appreciated.
            L0146: return; // RETURN;
        }

        private void Fn_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x18));
            L0016: if (JumpNotEqual) goto L0047;
            L0018: ShowPortrait(player, 0x0029);
            L0025: ShowMessage(player, String2698); // 'Ah!  So thou, too, hast heard of the tremendous powers the Gaelic Garlic has against undead.  But there is none to be found this way.  I am most sure of that.'
            L0032: SetFlag(player, 0x03, 0x18, 0x01);
            L0047: return; // RETURN;
        }

        private void Fn_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: ShowMessage(player, String2739); // This warm, almost hot fountain provides some relief to your bruises, but does nothing special for you.
            L001D: return; // RETURN;
        }

        private void Fn_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: ShowMessage(player, String27A0); // This cold fountain provides a refreshing drink for you, but does nothing special otherwise.
            L001D: return; // RETURN;
        }

        private void Fn_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x1A), 0x0001);
            L0017: if (JumpNotEqual) goto L0046;
            L0019: ShowMessage(player, String27FC); // You pick up a bouncing bud of Gaelic Garlic.
            L0026: GiveItem(player, 0x9D);
            L0032: SetFlag(player, 0x03, 0x1A, 0x00);
            L0046: return; // RETURN;
        }

    }
}
