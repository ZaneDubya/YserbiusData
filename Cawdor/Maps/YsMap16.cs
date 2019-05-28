#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap16 : AMapScripted {
        protected override int MapIndex => 16;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 1;

        public YserMap16() {
            MapEvent01 = Fn_01;
            MapEvent04 = Fn_04;
            MapEvent05 = Fn_05;
            MapEvent06 = Fn_06;
            MapEvent07 = Fn_07;
            MapEvent08 = Fn_08;
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
            MapEvent27 = Fn_27;
            MapEvent28 = Fn_28;
            MapEvent29 = Fn_29;
            MapEvent2A = Fn_2A;
        }
        
        // === Strings ================================================
        private const string String0140 = "It sure is drafty in here.";
        private const string String015B = "You've uncovered a hidden door!";
        private const string String017B = "You are watching out for ambushes.";
        private const string String019E = "AMBUSH!  Something ghostly and ghastly cast a fireball at you and then retreated!";
        private const string String01F0 = "We did damage - did we get Ambush msg?";
        private const string String0217 = "Some faint tracks lure you onward.";
        private const string String023A = "You try squeezing down this narrow corridor, but it's so tight that - aargh!  You've been impaled on your companion's weapon!";
        private const string String02B8 = "Galatea greets you. 'Thou hast done well, and well again.  But I can stay but briefly with thee here, and I think me this will be the last time I can meet with thee.  Any future hints must be given via runes and messengers.  Certes, thou must be most interested in improving thyself.";
        private const string String03D4 = "'As thou art uninhibited by nature, thou canst well benefit from knowledge of the sudden deadly strike: the furtive attack.'";
        private const string String0451 = "'Thou hast great magical powers, and thou canst show thy abilities to put fear into thy foes, to intimidate them into fighting at less than full capability.  Behold!'  You now know how to intimidate!";
        private const string String0519 = "'Thou canst use thy skills at tracking to follow, so it is but an obvious extension of what thou art to enable thee to divine passages not apparent to the eye.  Behold!'  You now know the detection skill.";
        private const string String05E6 = "'As thou must face ever greater evils, thou shouldst know better how to husband thy strength against the foes that will face thee.  Behold!'  You now know the stamina skill!";
        private const string String0694 = "'On this level, Banquo's Ghost dost reside.  Canny general that he was and is, he awaits thee behind the great rendering pools in the kitchen, full confident that any who would assail him will be so weakened by the pool as to make them easy prey.";
        private const string String078B = "An thou dost equip thyself with an item thou dost possess, thou shalt find the pools no hindrance to thee.";
        private const string String07F6 = "'I can but say this once.  Unless thou art as mighty as the Tuatha De' Danann, thou shalt find Banquo's defense behind the rendering pools in the kitchen unassailable.";
        private const string String089E = "Thou shouldst return to the next lower level and obtain the aid of Manannan Mac Lir by finding him in the Music Room and invoking him in the library.";
        private const string String0934 = "An thou art as powerful as the ancient gods of Scotland, then thou hast no need of my advice or succor to accomplish my righteous quest.";
        private const string String09BD = "'I believe thou wilt find this item of some use.  It has but ten charges, but will still defend thee both before and after thou dost drain it.";
        private const string String0A4C = "You hear a whisper.  'Banquo's fortress is mighty, his defenses puissant, and without Mannanan's aid, thou shalt find them nigh unto insurmountable.'";
        private const string String0AE2 = "This narrow corridor forces you to proceed single file.";
        private const string String0B1A = "This way to The Gallery.";
        private const string String0B33 = "These stairs lead up to The Great Hall.";
        private const string String0B5B = "A voice whispers to you....";
        private const string String0B77 = "An thou dost leave Banquo's ghost untended behind thee, then thou shalt surely suffer for it.";
        private const string String0BD5 = "Three halflings catch the door before it closes.";
        private const string String0C06 = "'Well met!  There are enough undead in there for all of us, and some giants and dragons as well.  May providence smile upon thy works.'";
        private const string String0C8E = "The door to the Conservatory refuses to budge.";
        private const string String0CBD = "It is eerily quiet here.";
        private const string String0CD6 = "Three halflings, two of whom look badly wounded and in serious need of a smithy, hold the door open for you.";
        private const string String0D43 = "'Go on in, go on in,' they say.  'But do not travel this path in ignorance.  There are more fiercesome beasts within than yet we have encountered, and lacking the wherewithal to withstand the Dissolving Pool we were forced to flee Banquo's unknightly assault.";
        private const string String0E47 = "Mayhaps thou wilt receive better fortune than we had, cousin.'";
        private const string String0E86 = "Struggle though you will, you are unable to open the door that leads to the Kitchen.";
        private const string String0EDB = "'Good gentles, hast thou seen my son?";
        private const string String0F01 = "Thou shouldst know him.  Broody fellow.  Given to soliloquies.  Name of Hamlet.  Seen him?'";
        private const string String0F5D = "You shake your head.";
        private const string String0F72 = "'I thank thee for thy time.  'Tis not as though I had aught else to do.'  The ghost departs.";
        private const string String0FCF = "'My good hero!  This was the most difficult task yet before thee.  Naetheless, thou hast emptied this room of our enemies, and in the short time I have I can do this much for thee, for thou art healed and granted yet more experience.'";
        private const string String10BA = "'And thou gavest me warning in such amplitude that I was able to intercede and plead with Manannan Mac Lir on thy behalf.  I have this item for thee.";
        private const string String1150 = "Use it wisely in the kitchen, and may providence grant that thou shalt dispatch Banquo's shade as easily as thou didst empty this room of my sisters's agents.";
        private const string String11EF = "'But soft!  Our time together grows short.  I must urge thee to leave this area now.' She disappears.";
        private const string String1255 = "A boisterous bunch of bloodsuckers is waiting for you.";
        private const string String128C = "No, they are not agents; they're vampires.";
        private const string String12B7 = "All that remains from your battle here is a tattered piece of cape.  Harrumph.  Polyester.  Not even satin.  What are vampires coming to these days?";
        private const string String134C = "I wonder what Dana and Fox would say about these gruesome ghosts.";
        private const string String138E = "Did they have swamp gas in the 12th century?";
        private const string String13BB = "All that remains from your battle here is the remains of a stained muslin bedsheet.";
        private const string String140F = "It looks like you're under attack by pigs knuckles.  No, wait!  I meant pigs AND knuckles.";
        private const string String146A = "Make that more knuckles than pigs.";
        private const string String148D = "All that remains from your battle here is an empty bag of pork rinds.";
        private const string String14D3 = "It serves you right for showing just a little too much pocket change at the Rampant Cat Inn.  You'll be hanged before you buy any of these guys any more drinks!";
        private const string String1574 = "In fact, there just might be enough of them to take that hanging part literally!";
        private const string String15C5 = "All that remains of your battle here is a brass farthing.  No, it isn't even worth a plugged nickel.";
        private const string String162A = "You remember when you were just a wee adventurer, and a visit to grandmummy's house was something to look forward to.";
        private const string String16A0 = "Well, you can say this: she has not aged well!";
        private const string String16CF = "Boy, after your fight it here it looks like someone teepeed this place with a vengeance!";
        private const string String1728 = "How are you going to explain this to the nice constable?  'See, there was this group of harpies taking their dogs out for a nice drag.'";
        private const string String17B0 = "If you want to avoid a public intoxication charge, you had better collect lots of souvenirs from this battle.  And yes, there are lots of potential souvenir donors right in front of you!";
        private const string String186B = "On second thought, you'll just avoid the constable lest he slap failure to curb your dog on top of the public intoxication charge.";
        private const string String18EE = "It's hard to tell who is angrier: those medusae because they have bats tangled in their, uh, hair, or the bats so entangled.  Either way, they seem to have decided to release their frustrations on you!";
        private const string String19B8 = "You could have tried turning away their wrath by complimenting their new hairstyle, but you know that you wouldn't have sounded sincere.";
        private const string String1A41 = "You remember how the medusae almost drove you batty here before.";
        private const string String1A82 = "You hear some footsteps running away.";
        private const string String1AA8 = "You hear someone running towards you.";
        private const string String1ACE = "'A thousand pardons.  Hast thou seen an angry minotaur in this area?  I solved the labyrinth in the center of this area, and, well, in a nutshell I do confess that they have cause to find me.  I had best be moving on, good gentles.";
        private const string String1BB6 = "'Hold!  I am seeking a - ah, but thou art not the elf barbarian who did beard me in my lair, damn her thieving heart.  An thou dost see her, let her know; I am relentless when once on the chase.";
        private const string String1C79 = "You recall being annoyed at Rory's smugness here before.  You'd give a lot to see his smug mug again.";
        private const string String1CDF = "'A marvelous day, friends, 'tis it not? Glorious enough for me to report my skill at detection was adequate for me to find both the northern and the southern entrances into the labyrinth.  Go ye and do likewise, eh?'";
        private const string String1DB8 = "The halfling struts off, smiling.  Now that you think of it, he always has been rather smug.";
        private const string String1E15 = "A large group of minotaurs spots you.";
        private const string String1E3B = "'There is the robber!' shouts one.";
        private const string String1E5E = "'Nay not,' retorts another.";
        private const string String1E7A = "'Let's get'm anyways!' cries a third, just before the arrival of the thundering herd.";
        private const string String1ED0 = "The narrow corridor to the south forces you to enter it single file.";
        private const string String1F15 = "'Galatea forgot to mention that items of great use are being guarded by the minotaurs in the center of the labyrinth, but that thou must have an excellent nose for secret doors to access them.";
        private const string String1FD6 = "'But I think me thou hast already shown thy mettle in the labyrinth,' he says, smiling.";
        private const string String202E = "'Good on thee!  Thou hast cleared the minotaur's lair, whose tricksome turns will baffle my sister's agents long enough for me to reward thee yet again!  As I gave thee skills before, this time I shall grant thee a spell.";
        private const string String210C = "The mightiest spell I can grant thee is now to be thine.  This spell harms all that thou dost fight, with a power nigh unto the most mighty.  It is called Death Darts.'  You now know that spell!";
        private const string String21CF = "Galatea gets a distant look in her eyes.  'I dare no longer stay.  Good fortune!'";
        private const string String2221 = "There seem to be many minotaurs in this labyrinth.";
        private const string String2254 = "Sirloin; prime rib; yup, you fought minotaurs here.";
        private const string String2288 = "The minotaurs seem to be arriving in ever larger herds.  You hope that means you are getting near the center.";
        private const string String22F6 = "Y'know, these minotaurs seem a lot meaner than the last group.";
        private const string String2335 = "You showed them who ranked where on the food chain!";
        
        // === Functions ================================================
        private void Fn_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0140); // It sure is drafty in here.
            L0010: Compare(HasUsedSkill(player, 0x0D), 0x0009);
            L001F: if (JumpNotBelow) goto L008D;
            L0021: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L002F: if (JumpNotEqual) goto L008D;
            L0031: PushStack(player, 0x67);
            L0035: PushStack(player, ax);
003F  0036 C4 5E 06  les bx, [bp+0x6]
0042  0039 26 FF 5F 54  call far word [es:bx+0x54]
            L003D: cx = PopStack(player);
            L003E: cx = PopStack(player);
            L003F: RefreshCompareFlags(ax);
            L0041: if (JumpNotEqual) goto L008D;
            L0043: PushStack(player, 0x61);
            L0047: PushStack(player, ax);
0051  0048 C4 5E 06  les bx, [bp+0x6]
0054  004B 26 FF 5F 54  call far word [es:bx+0x54]
            L004F: cx = PopStack(player);
            L0050: cx = PopStack(player);
            L0051: RefreshCompareFlags(ax);
            L0053: if (JumpNotEqual) goto L008D;
            L0055: PushStack(player, 0x93);
            L0059: PushStack(player, ax);
0063  005A C4 5E 06  les bx, [bp+0x6]
0066  005D 26 FF 5F 54  call far word [es:bx+0x54]
            L0061: cx = PopStack(player);
            L0062: cx = PopStack(player);
            L0063: RefreshCompareFlags(ax);
            L0065: if (JumpNotEqual) goto L008D;
            L0067: PushStack(player, 0x86);
            L006B: PushStack(player, ax);
0075  006C C4 5E 06  les bx, [bp+0x6]
0078  006F 26 FF 5F 54  call far word [es:bx+0x54]
            L0073: cx = PopStack(player);
            L0074: cx = PopStack(player);
            L0075: RefreshCompareFlags(ax);
            L0077: if (JumpNotEqual) goto L008D;
            L0079: ax = IsFlagOn(player, 0x00, 0x01);
            L008B: if (JumpEqual) goto L00E9;
            L008D: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00AB: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00C9: PushStack(player, 0x01);
            L00CD: PushStack(player, ax);
            L00CE: PushStack(player, 0x00);
00DA  00D1 C4 5E 06  les bx, [bp+0x6]
00DD  00D4 26 FF 1F  call far word [es:bx]
00E0  00D7 83 C4 06  add sp, 0x6
            L00DA: ShowMessage(player, String015B); // You've uncovered a hidden door!
            L00E7: goto L0123;
            L00E9: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0106: SetWallObject(player, 0x00, GetCurrentTile(player), GetFacing(player));
            L0123: return; // RETURN;
        }

        private void Fn_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00ED;
            L001B: PushStack(player, 0x02);
            L001F: PushStack(player, 0x00);
015A  0022 C4 5E 06  les bx, [bp+0x6]
015D  0025 26 FF 5F 04  call far word [es:bx+0x4]
            L0029: cx = PopStack(player);
            L002A: cx = PopStack(player);
            L002B: RefreshCompareFlags(ax);
            L002D: if (JumpEqual) goto L0032;
            L002F: goto L00ED;
            L0032: Compare(HasUsedSkill(player, 0x0B), 0x0003);
            L0041: if (JumpAbove) goto L0079;
            L0043: PushStack(player, 0xA6);
            L0047: PushStack(player, ax);
0180  0048 C4 5E 06  les bx, [bp+0x6]
0183  004B 26 FF 5F 54  call far word [es:bx+0x54]
            L004F: cx = PopStack(player);
            L0050: cx = PopStack(player);
            L0051: RefreshCompareFlags(ax);
            L0053: if (JumpNotEqual) goto L0079;
            L0055: PushStack(player, 0x62);
            L0059: PushStack(player, ax);
0192  005A C4 5E 06  les bx, [bp+0x6]
0195  005D 26 FF 5F 54  call far word [es:bx+0x54]
            L0061: cx = PopStack(player);
            L0062: cx = PopStack(player);
            L0063: RefreshCompareFlags(ax);
            L0065: if (JumpNotEqual) goto L0079;
            L0067: PushStack(player, 0x8F);
            L006B: PushStack(player, ax);
01A4  006C C4 5E 06  les bx, [bp+0x6]
01A7  006F 26 FF 5F 54  call far word [es:bx+0x54]
            L0073: cx = PopStack(player);
            L0074: cx = PopStack(player);
            L0075: RefreshCompareFlags(ax);
            L0077: if (JumpEqual) goto L00A5;
            L0079: ShowMessage(player, String017B); // You are watching out for ambushes.
            L0086: PushStack(player, 0x01);
            L008A: PushStack(player, ax);
            L008B: PushStack(player, 0x03);
01C7  008F C4 5E 06  les bx, [bp+0x6]
01CA  0092 26 FF 1F  call far word [es:bx]
01CD  0095 83 C4 06  add sp, 0x6
            L0098: PushStack(player, 0x01);
            L009C: PushStack(player, 0x02);
01D8  00A0 33 C0  xor ax, ax
            L00A2: goto L0164;
            L00A5: SetFlag(player, 0x03, 0x01, 0x00);
            L00B9: ShowMessage(player, String019E); // AMBUSH!  Something ghostly and ghastly cast a fireball at you and then retreated!
            L00C6: ax = GetMaxHits(player);
            L00CD: bx = 0x0004;
            L00D0: dx = ax % bx; ax = ax / bx;
            L00D3: DamagePlayer(player, ax);
            L00DD: ShowMessage(player, String01F0); // We did damage - did we get Ambush msg?
            L00EA: goto L016E;
            L00ED: Compare(HasUsedSkill(player, 0x0B), 0x0003);
            L00FC: if (JumpAbove) goto L0134;
            L00FE: PushStack(player, 0xA6);
            L0102: PushStack(player, ax);
023B  0103 C4 5E 06  les bx, [bp+0x6]
023E  0106 26 FF 5F 54  call far word [es:bx+0x54]
            L010A: cx = PopStack(player);
            L010B: cx = PopStack(player);
            L010C: RefreshCompareFlags(ax);
            L010E: if (JumpNotEqual) goto L0134;
            L0110: PushStack(player, 0x62);
            L0114: PushStack(player, ax);
024D  0115 C4 5E 06  les bx, [bp+0x6]
0250  0118 26 FF 5F 54  call far word [es:bx+0x54]
            L011C: cx = PopStack(player);
            L011D: cx = PopStack(player);
            L011E: RefreshCompareFlags(ax);
            L0120: if (JumpNotEqual) goto L0134;
            L0122: PushStack(player, 0x8F);
            L0126: PushStack(player, ax);
025F  0127 C4 5E 06  les bx, [bp+0x6]
0262  012A 26 FF 5F 54  call far word [es:bx+0x54]
            L012E: cx = PopStack(player);
            L012F: cx = PopStack(player);
            L0130: RefreshCompareFlags(ax);
            L0132: if (JumpEqual) goto L015A;
            L0134: ShowMessage(player, String0217); // Some faint tracks lure you onward.
            L0141: SetFlag(player, 0x00, 0x02, 0x01);
028D  0155 B8 01 00  mov ax, 0x1
            L0158: goto L015C;
            L015A: SetFlag(player, 0x03, 0x01, 0x00);
            L016E: return; // RETURN;
        }

        private void Fn_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x05, 0x02, 0xF9, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void Fn_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpBelowOrEqual) goto L0030;
            L0010: ShowMessage(player, String023A); // You try squeezing down this narrow corridor, but it's so tight that - aargh!  You've been impaled on your companion's weapon!
            L001D: DamagePlayer(player, GetMaxHits(player));
            L002E: goto L006F;
            L0030: RefreshCompareFlags(GetFlag(player, 0x02, 0x29));
            L0043: if (JumpNotEqual) goto L006F;
            L0045: SetWallObject(player, 0x00, 0xF9, 0x01);
            L005A: SetWallPassable(player, 0xF9, 0x01, 0x00);
            L006F: return; // RETURN;
        }

        private void Fn_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(player);
            L000B: SetFlag(player, 0x02, 0x1D, 0x01);
            L0020: Compare(PartyCount(player), 0x0001);
            L002B: if (JumpBelowOrEqual) goto L004D;
            L002D: ShowMessage(player, String023A); // You try squeezing down this narrow corridor, but it's so tight that - aargh!  You've been impaled on your companion's weapon!
            L003A: PushStack(player, GetMaxHits(player));
037B  0042 C4 5E 06  les bx, [bp+0x6]
037E  0045 26 FF 9F 90 00  call far word [es:bx+0x90]
            L004A: goto L0227;
            L004D: RefreshCompareFlags(GetFlag(player, 0x02, 0x34));
            L0060: if (JumpEqual) goto L0065;
            L0062: goto L01F6;
            L0065: ShowPortrait(player, 0x0015);
            L0072: SetFlag(player, 0x02, 0x34, 0x01);
            L0087: ShowMessage(player, String02B8); // Galatea greets you. 'Thou hast done well, and well again.  But I can stay but briefly with thee here, and I think me this will be the last time I can meet with thee.  Any future hints must be given via runes and messengers.  Certes, thou must be most interested in improving thyself.
            L0094: RefreshCompareFlags(GetGuild(player));
            L009D: if (JumpEqual) goto L00AB;
            L009F: Compare(GetGuild(player), 0x0003);
            L00A9: if (JumpNotEqual) goto L00D9;
            L00AB: RefreshCompareFlags(GetSkillLevel(player, 0x0A));
            L00B9: if (JumpNotEqual) goto L00D9;
            L00BB: ShowMessage(player, String03D4); // 'As thou art uninhibited by nature, thou canst well benefit from knowledge of the sudden deadly strike: the furtive attack.'
            L00C8: SetSkillLevel(player, 0x0A, 0x01);
            L00D9: Compare(GetGuild(player), 0x0005);
            L00E3: if (JumpEqual) goto L00F1;
            L00E5: Compare(GetGuild(player), 0x0004);
            L00EF: if (JumpNotEqual) goto L011F;
            L00F1: RefreshCompareFlags(GetSkillLevel(player, 0x07));
            L00FF: if (JumpNotEqual) goto L011F;
            L0101: ShowMessage(player, String0451); // 'Thou hast great magical powers, and thou canst show thy abilities to put fear into thy foes, to intimidate them into fighting at less than full capability.  Behold!'  You now know how to intimidate!
            L010E: SetSkillLevel(player, 0x07, 0x01);
            L011F: Compare(GetGuild(player), 0x0002);
            L0129: if (JumpNotEqual) goto L0159;
            L012B: RefreshCompareFlags(GetSkillLevel(player, 0x0D));
            L0139: if (JumpNotEqual) goto L0159;
            L013B: ShowMessage(player, String0519); // 'Thou canst use thy skills at tracking to follow, so it is but an obvious extension of what thou art to enable thee to divine passages not apparent to the eye.  Behold!'  You now know the detection skill.
            L0148: SetSkillLevel(player, 0x0D, 0x01);
            L0159: Compare(GetGuild(player), 0x0001);
            L0163: if (JumpNotEqual) goto L0193;
            L0165: RefreshCompareFlags(GetSkillLevel(player, 0x09));
            L0173: if (JumpNotEqual) goto L0193;
            L0175: ShowMessage(player, String05E6); // 'As thou must face ever greater evils, thou shouldst know better how to husband thy strength against the foes that will face thee.  Behold!'  You now know the stamina skill!
            L0182: SetSkillLevel(player, 0x09, 0x01);
            L0193: ax = HasItem(player, 0xD8);
            L01A1: if (JumpEqual) goto L01B5;
            L01A3: ShowMessage(player, String0694); // 'On this level, Banquo's Ghost dost reside.  Canny general that he was and is, he awaits thee behind the great rendering pools in the kitchen, full confident that any who would assail him will be so weakened by the pool as to make them easy prey.
04E9  01B0 B8 8B 07  mov ax, 0x78b
            L01B3: goto L01D2;
            L01B5: ShowMessage(player, String07F6); // 'I can but say this once.  Unless thou art as mighty as the Tuatha De' Danann, thou shalt find Banquo's defense behind the rendering pools in the kitchen unassailable.
            L01C2: ShowMessage(player, String089E); // Thou shouldst return to the next lower level and obtain the aid of Manannan Mac Lir by finding him in the Music Room and invoking him in the library.
            L01CF: ShowMessage(player, String0934); // An thou art as powerful as the ancient gods of Scotland, then thou hast no need of my advice or succor to accomplish my righteous quest.
            L01DC: ShowMessage(player, String09BD); // 'I believe thou wilt find this item of some use.  It has but ten charges, but will still defend thee both before and after thou dost drain it.
            L01E9: PushStack(player, 0x51);
0526  01ED C4 5E 06  les bx, [bp+0x6]
0529  01F0 26 FF 5F 48  call far word [es:bx+0x48]
            L01F4: goto L0227;
            L01F6: ax = HasItem(player, 0xD8);
            L0204: if (JumpNotEqual) goto L0228;
            L0206: RefreshCompareFlags(GetFlag(player, 0x02, 0x29));
            L0219: if (JumpNotEqual) goto L0228;
            L021B: ShowMessage(player, String0A4C); // You hear a whisper.  'Banquo's fortress is mighty, his defenses puissant, and without Mannanan's aid, thou shalt find them nigh unto insurmountable.'
            L0228: return; // RETURN;
        }

        private void Fn_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(player);
            L000B: Compare(PartyCount(player), 0x0001);
            L0016: if (JumpBelowOrEqual) goto L0038;
            L0018: ShowMessage(player, String023A); // You try squeezing down this narrow corridor, but it's so tight that - aargh!  You've been impaled on your companion's weapon!
            L0025: PushStack(player, GetMaxHits(player));
0590  002D C4 5E 06  les bx, [bp+0x6]
0593  0030 26 FF 9F 90 00  call far word [es:bx+0x90]
            L0035: goto L00C6;
            L0038: RefreshCompareFlags(GetFlag(player, 0x03, 0x0D));
            L004B: if (JumpNotEqual) goto L006F;
            L004D: SetFlag(player, 0x03, 0x0D, 0x01);
            L0062: ShowMessage(player, String0AE2); // This narrow corridor forces you to proceed single file.
            L006F: RefreshCompareFlags(GetFlag(player, 0x02, 0x29));
            L0082: if (JumpNotEqual) goto L00AE;
            L0084: SetWallObject(player, 0x00, 0xF9, 0x01);
            L0099: SetWallPassable(player, 0xF9, 0x01, 0x00);
            L00AE: Compare(GetFacing(player), 0x0001);
            L00B8: if (JumpNotEqual) goto L00C7;
            L00BA: ShowMessage(player, String0B1A); // This way to The Gallery.
            L00C7: return; // RETURN;
        }

        private void Fn_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x29), 0x0001);
            L0017: if (JumpNotEqual) goto L0043;
            L0019: ShowMessage(player, String0B33); // These stairs lead up to The Great Hall.
            L0026: TeleportParty(player, 0x08, 0x02, 0xF9, 0x03, isForwardMove);
            L0041: goto L0097;
            L0043: ShowMessage(player, String0B5B); // A voice whispers to you....
            L0050: ShowMessage(player, String0B77); // An thou dost leave Banquo's ghost untended behind thee, then thou shalt surely suffer for it.
            L005D: SetWallObject(player, 0x00, GetCurrentTile(player), GetFacing(player));
            L007A: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0097: return; // RETURN;
        }

        private void Fn_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x04);
06CC  0007 C4 5E 06  les bx, [bp+0x6]
06CF  000A 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L000F: cx = PopStack(player);
            L0010: RefreshCompareFlags(ax);
            L0012: if (JumpEqual) goto L0036;
            L0014: PushStack(player, 0x02);
06DD  0018 C4 5E 06  les bx, [bp+0x6]
06E0  001B 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L0020: cx = PopStack(player);
            L0021: RefreshCompareFlags(ax);
            L0023: if (JumpEqual) goto L0036;
            L0025: PushStack(player, 0x03);
06EE  0029 C4 5E 06  les bx, [bp+0x6]
06F1  002C 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L0065;
            L0036: Compare(GetFlag(player, 0x02, 0x14), 0x0001);
            L004A: if (JumpEqual) goto L0065;
            L004C: Compare(GetFlag(player, 0x02, 0x6F), 0x0001);
            L0060: if (JumpEqual) goto L0065;
            L0062: goto L00E5;
            L0065: ShowPortrait(player, 0x0029);
            L0072: ShowMessage(player, String0BD5); // Three halflings catch the door before it closes.
            L007F: ShowMessage(player, String0C06); // 'Well met!  There are enough undead in there for all of us, and some giants and dragons as well.  May providence smile upon thy works.'
            L008C: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00AA: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00C8: TeleportParty(player, 0x08, 0x01, 0xFD, 0x03, isForwardMove);
            L00E3: goto L00F2;
            L00E5: ShowMessage(player, String0C8E); // The door to the Conservatory refuses to budge.
            L00F2: return; // RETURN;
        }

        private void Fn_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0CBD); // It is eerily quiet here.
            L0010: return; // RETURN;
        }

        private void Fn_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
07D2  0007 C4 5E 06  les bx, [bp+0x6]
07D5  000A 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L000F: cx = PopStack(player);
            L0010: RefreshCompareFlags(ax);
            L0012: if (JumpEqual) goto L0036;
            L0014: PushStack(player, 0x04);
07E3  0018 C4 5E 06  les bx, [bp+0x6]
07E6  001B 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L0020: cx = PopStack(player);
            L0021: RefreshCompareFlags(ax);
            L0023: if (JumpEqual) goto L0036;
            L0025: PushStack(player, 0x03);
07F4  0029 C4 5E 06  les bx, [bp+0x6]
07F7  002C 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L0065;
            L0036: Compare(GetFlag(player, 0x02, 0x14), 0x0001);
            L004A: if (JumpEqual) goto L0065;
            L004C: Compare(GetFlag(player, 0x02, 0x1E), 0x0001);
            L0060: if (JumpEqual) goto L0065;
            L0062: goto L00F1;
            L0065: ShowPortrait(player, 0x001D);
            L0072: ShowMessage(player, String0CD6); // Three halflings, two of whom look badly wounded and in serious need of a smithy, hold the door open for you.
            L007F: ShowMessage(player, String0D43); // 'Go on in, go on in,' they say.  'But do not travel this path in ignorance.  There are more fiercesome beasts within than yet we have encountered, and lacking the wherewithal to withstand the Dissolving Pool we were forced to flee Banquo's unknightly assault.
            L008C: ShowMessage(player, String0E47); // Mayhaps thou wilt receive better fortune than we had, cousin.'
            L0099: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00B7: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00D5: TeleportParty(player, 0x07, 0x01, 0xBF, 0x00, isForwardMove);
            L00EF: goto L00FE;
            L00F1: ShowMessage(player, String0E86); // Struggle though you will, you are unable to open the door that leads to the Kitchen.
            L00FE: return; // RETURN;
        }

        private void Fn_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
08D3  0008 C4 5E 06  les bx, [bp+0x6]
08D6  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpNotEqual) goto L0068;
            L0015: PushStack(player, 0x01);
            L0019: PushStack(player, 0x03);
            L001D: PushStack(player, ax);
08E9  001E C4 5E 06  les bx, [bp+0x6]
08EC  0021 26 FF 1F  call far word [es:bx]
08EF  0024 83 C4 06  add sp, 0x6
            L0027: ShowPortrait(player, 0x0009);
            L0034: ShowMessage(player, String0EDB); // 'Good gentles, hast thou seen my son?
            L0041: ShowMessage(player, String0F01); // Thou shouldst know him.  Broody fellow.  Given to soliloquies.  Name of Hamlet.  Seen him?'
            L004E: ShowMessage(player, String0F5D); // You shake your head.
            L005B: ShowMessage(player, String0F72); // 'I thank thee for thy time.  'Tis not as though I had aught else to do.'  The ghost departs.
            L0068: return; // RETURN;
            // Extra data: 55 8B EC B8 01 00 50 B8 0F 00 50 B8 03 00 50 C4 5E 06 26 FF 1F 83 C4 06 B8 15 00 50 C4 5E 06 26 FF 9F FC 00 59 B8 13 00 BA 20 D6 50 52 C4 5E 06 26 FF 9F 98 00 59 59 C4 5E 06 26 FF 5F 74 50 C4 5E 06 26 FF 9F 94 00 59 B8 CF 0F 50 C4 5E 06 26 FF 9F F8 00 59 B8 D8 00 50 C4 5E 06 26 FF 5F 50 59 0B C0 75 3B B8 29 00 50 B8 02 00 50 C4 5E 06 26 FF 5F 04 59 59 0B C0 75 26 B8 BA 10 50 C4 5E 06 26 FF 9F F8 00 59 B8 50 11 50 C4 5E 06 26 FF 9F F8 00 59 B8 D8 00 50 C4 5E 06 26 FF 5F 48 59 B8 EF 11 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 
        }

        private void Fn_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00F5;
            L001B: SetFlag(player, 0x03, 0x04, 0x01);
            L0030: ShowMessage(player, String1255); // A boisterous bunch of bloodsuckers is waiting for you.
            L003D: ShowMessage(player, String128C); // No, they are not agents; they're vampires.
0A2E  004A B8 45 01  mov ax, 0x145
            L004D: PushStack(player, ax);
            L004E: PushStack(player, 0x00);
            L0051: PushStack(player, ax);
            L0052: PushStack(player, 0xB9);
            L0056: PushStack(player, 0xBE);
            L005A: PushStack(player, 0x0C);
0A42  005E C4 5E 06  les bx, [bp+0x6]
0A45  0061 26 FF 9F D8 00  call far word [es:bx+0xd8]
0A4A  0066 83 C4 0C  add sp, 0xc
            L0069: AddEncounter(player, 0x01, 0x24);
            L007B: AddEncounter(player, 0x02, 0x25);
            L008D: Compare(PartyCount(player), 0x0002);
            L0098: if (JumpBelowOrEqual) goto L00BE;
            L009A: AddEncounter(player, 0x05, 0x25);
            L00AC: AddEncounter(player, 0x06, 0x25);
            L00BE: Compare(PartyCount(player), 0x0003);
            L00C9: if (JumpAbove) goto L00CE;
            L00CB: goto L01C4;
            L00CE: AddEncounter(player, 0x04, 0x24);
            L00E0: AddEncounter(player, 0x03, 0x24);
            L00F2: goto L01C4;
            L00F5: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L0109: if (JumpEqual) goto L010E;
            L010B: goto L01B7;
            L010E: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L0122: if (JumpEqual) goto L0127;
            L0124: goto L01B7;
            L0127: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L013B: if (JumpNotEqual) goto L01B7;
            L013D: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L0151: if (JumpNotEqual) goto L01B7;
            L0153: Compare(GetFlag(player, 0x03, 0x08), 0x0001);
            L0167: if (JumpNotEqual) goto L01B7;
            L0169: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L017D: if (JumpNotEqual) goto L01B7;
            L017F: Compare(GetFlag(player, 0x03, 0x0A), 0x0001);
            L0193: if (JumpNotEqual) goto L01B7;
            L0195: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L01A8: if (JumpNotEqual) goto L01B7;
0B8E  01AA FF 76 08  push word [bp+0x8]
0B91  01AD FF 76 06  push word [bp+0x6]
0B94  01B0 0E     push cs
0B95  01B1 E8 9D FD  call 0xff51
            L01B4: goto L00F0;
            L01B7: ShowMessage(player, String12B7); // All that remains from your battle here is a tattered piece of cape.  Harrumph.  Polyester.  Not even satin.  What are vampires coming to these days?
            L01C4: return; // RETURN;
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0102;
            L001B: SetFlag(player, 0x03, 0x05, 0x01);
            L0030: ShowMessage(player, String134C); // I wonder what Dana and Fox would say about these gruesome ghosts.
            L003D: Compare(PartyCount(player), 0x0003);
            L0048: if (JumpBelowOrEqual) goto L0057;
            L004A: ShowMessage(player, String138E); // Did they have swamp gas in the 12th century?
0C01  0057 B8 E7 01  mov ax, 0x1e7
            L005A: PushStack(player, ax);
            L005B: PushStack(player, 0x00);
            L005E: PushStack(player, ax);
            L005F: PushStack(player, 0x9C);
            L0063: PushStack(player, 0x18);
            L0067: PushStack(player, 0xBA);
0C15  006B C4 5E 06  les bx, [bp+0x6]
0C18  006E 26 FF 9F D8 00  call far word [es:bx+0xd8]
0C1D  0073 83 C4 0C  add sp, 0xc
            L0076: AddEncounter(player, 0x01, 0x22);
            L0088: AddEncounter(player, 0x02, 0x23);
            L009A: Compare(PartyCount(player), 0x0002);
            L00A5: if (JumpBelowOrEqual) goto L00CB;
            L00A7: AddEncounter(player, 0x03, 0x22);
            L00B9: AddEncounter(player, 0x04, 0x23);
            L00CB: Compare(PartyCount(player), 0x0003);
            L00D6: if (JumpAbove) goto L00DB;
            L00D8: goto L01D1;
            L00DB: AddEncounter(player, 0x05, 0x23);
            L00ED: AddEncounter(player, 0x06, 0x23);
            L00FF: goto L01D1;
            L0102: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L0116: if (JumpEqual) goto L011B;
            L0118: goto L01C4;
            L011B: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L012F: if (JumpEqual) goto L0134;
            L0131: goto L01C4;
            L0134: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L0148: if (JumpNotEqual) goto L01C4;
            L014A: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L015E: if (JumpNotEqual) goto L01C4;
            L0160: Compare(GetFlag(player, 0x03, 0x08), 0x0001);
            L0174: if (JumpNotEqual) goto L01C4;
            L0176: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L018A: if (JumpNotEqual) goto L01C4;
            L018C: Compare(GetFlag(player, 0x03, 0x0A), 0x0001);
            L01A0: if (JumpNotEqual) goto L01C4;
            L01A2: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L01B5: if (JumpNotEqual) goto L01C4;
0D61  01B7 FF 76 08  push word [bp+0x8]
0D64  01BA FF 76 06  push word [bp+0x6]
0D67  01BD 0E     push cs
0D68  01BE E8 CA FB  call 0xfd8b
            L01C1: goto L00FD;
            L01C4: ShowMessage(player, String13BB); // All that remains from your battle here is the remains of a stained muslin bedsheet.
            L01D1: return; // RETURN;
        }

        private void Fn_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00F5;
            L001B: SetFlag(player, 0x03, 0x06, 0x01);
            L0030: ShowMessage(player, String140F); // It looks like you're under attack by pigs knuckles.  No, wait!  I meant pigs AND knuckles.
            L003D: Compare(PartyCount(player), 0x0003);
            L0048: if (JumpBelowOrEqual) goto L0057;
            L004A: ShowMessage(player, String146A); // Make that more knuckles than pigs.
0DD4  0057 B8 71 02  mov ax, 0x271
            L005A: PushStack(player, ax);
            L005B: PushStack(player, 0x00);
            L005E: PushStack(player, ax);
            L005F: PushStack(player, 0xBA);
            L0063: PushStack(player, 0x88);
            L0067: PushStack(player, 0xCC);
0DE8  006B C4 5E 06  les bx, [bp+0x6]
0DEB  006E 26 FF 9F D8 00  call far word [es:bx+0xd8]
0DF0  0073 83 C4 0C  add sp, 0xc
            L0076: AddEncounter(player, 0x01, 0x1E);
            L0088: AddEncounter(player, 0x02, 0x1E);
            L009A: AddEncounter(player, 0x05, 0x20);
            L00AC: AddEncounter(player, 0x06, 0x20);
            L00BE: Compare(PartyCount(player), 0x0003);
            L00C9: if (JumpAbove) goto L00CE;
            L00CB: goto L01C4;
            L00CE: AddEncounter(player, 0x03, 0x1F);
            L00E0: AddEncounter(player, 0x04, 0x1F);
            L00F2: goto L01C4;
            L00F5: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L0109: if (JumpEqual) goto L010E;
            L010B: goto L01B7;
            L010E: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L0122: if (JumpEqual) goto L0127;
            L0124: goto L01B7;
            L0127: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L013B: if (JumpNotEqual) goto L01B7;
            L013D: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L0151: if (JumpNotEqual) goto L01B7;
            L0153: Compare(GetFlag(player, 0x03, 0x08), 0x0001);
            L0167: if (JumpNotEqual) goto L01B7;
            L0169: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L017D: if (JumpNotEqual) goto L01B7;
            L017F: Compare(GetFlag(player, 0x03, 0x0A), 0x0001);
            L0193: if (JumpNotEqual) goto L01B7;
            L0195: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L01A8: if (JumpNotEqual) goto L01B7;
0F27  01AA FF 76 08  push word [bp+0x8]
0F2A  01AD FF 76 06  push word [bp+0x6]
0F2D  01B0 0E     push cs
0F2E  01B1 E8 04 FA  call 0xfbb8
            L01B4: goto L00F0;
            L01B7: ShowMessage(player, String148D); // All that remains from your battle here is an empty bag of pork rinds.
            L01C4: return; // RETURN;
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0114;
            L001B: SetFlag(player, 0x03, 0x07, 0x01);
            L0030: ModifyGold(player, 0xFFFF78BA);
            L0042: ShowMessage(player, String14D3); // It serves you right for showing just a little too much pocket change at the Rampant Cat Inn.  You'll be hanged before you buy any of these guys any more drinks!
            L004F: Compare(PartyCount(player), 0x0003);
            L005A: if (JumpBelowOrEqual) goto L0069;
            L005C: ShowMessage(player, String1574); // In fact, there just might be enough of them to take that hanging part literally!
0FAC  0069 B8 41 17  mov ax, 0x1741
            L006C: PushStack(player, ax);
            L006D: PushStack(player, 0x00);
            L0070: PushStack(player, ax);
            L0071: PushStack(player, 0xBA);
            L0075: PushStack(player, 0x35);
            L0079: PushStack(player, 0xF8);
0FC0  007D C4 5E 06  les bx, [bp+0x6]
0FC3  0080 26 FF 9F D8 00  call far word [es:bx+0xd8]
0FC8  0085 83 C4 0C  add sp, 0xc
            L0088: AddEncounter(player, 0x01, 0x26);
            L009A: AddEncounter(player, 0x05, 0x27);
            L00AC: Compare(PartyCount(player), 0x0002);
            L00B7: if (JumpBelowOrEqual) goto L00DD;
            L00B9: AddEncounter(player, 0x02, 0x28);
            L00CB: AddEncounter(player, 0x06, 0x27);
            L00DD: Compare(PartyCount(player), 0x0003);
            L00E8: if (JumpAbove) goto L00ED;
            L00EA: goto L01E3;
            L00ED: AddEncounter(player, 0x04, 0x28);
            L00FF: AddEncounter(player, 0x03, 0x26);
            L0111: goto L01E3;
            L0114: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L0128: if (JumpEqual) goto L012D;
            L012A: goto L01D6;
            L012D: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L0141: if (JumpEqual) goto L0146;
            L0143: goto L01D6;
            L0146: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L015A: if (JumpNotEqual) goto L01D6;
            L015C: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L0170: if (JumpNotEqual) goto L01D6;
            L0172: Compare(GetFlag(player, 0x03, 0x08), 0x0001);
            L0186: if (JumpNotEqual) goto L01D6;
            L0188: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L019C: if (JumpNotEqual) goto L01D6;
            L019E: Compare(GetFlag(player, 0x03, 0x0A), 0x0001);
            L01B2: if (JumpNotEqual) goto L01D6;
            L01B4: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L01C7: if (JumpNotEqual) goto L01D6;
110C  01C9 FF 76 08  push word [bp+0x8]
110F  01CC FF 76 06  push word [bp+0x6]
1112  01CF 0E     push cs
1113  01D0 E8 1F F8  call 0xf9f2
            L01D3: goto L010F;
            L01D6: ShowMessage(player, String15C5); // All that remains of your battle here is a brass farthing.  No, it isn't even worth a plugged nickel.
            L01E3: return; // RETURN;
        }

        private void Fn_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x08));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0102;
            L001B: SetFlag(player, 0x03, 0x08, 0x01);
            L0030: ShowMessage(player, String162A); // You remember when you were just a wee adventurer, and a visit to grandmummy's house was something to look forward to.
            L003D: Compare(PartyCount(player), 0x0002);
            L0048: if (JumpBelowOrEqual) goto L0057;
            L004A: ShowMessage(player, String16A0); // Well, you can say this: she has not aged well!
117F  0057 B8 32 02  mov ax, 0x232
            L005A: PushStack(player, ax);
            L005B: PushStack(player, 0x00);
            L005E: PushStack(player, ax);
            L005F: PushStack(player, 0xCD);
            L0063: PushStack(player, 0xBA);
            L0067: PushStack(player, 0x43);
1193  006B C4 5E 06  les bx, [bp+0x6]
1196  006E 26 FF 9F D8 00  call far word [es:bx+0xd8]
119B  0073 83 C4 0C  add sp, 0xc
            L0076: AddEncounter(player, 0x01, 0x21);
            L0088: AddEncounter(player, 0x05, 0x21);
            L009A: Compare(PartyCount(player), 0x0002);
            L00A5: if (JumpBelowOrEqual) goto L00CB;
            L00A7: AddEncounter(player, 0x02, 0x21);
            L00B9: AddEncounter(player, 0x06, 0x21);
            L00CB: Compare(PartyCount(player), 0x0003);
            L00D6: if (JumpAbove) goto L00DB;
            L00D8: goto L01D1;
            L00DB: AddEncounter(player, 0x04, 0x21);
            L00ED: AddEncounter(player, 0x03, 0x21);
            L00FF: goto L01D1;
            L0102: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L0116: if (JumpEqual) goto L011B;
            L0118: goto L01C4;
            L011B: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L012F: if (JumpEqual) goto L0134;
            L0131: goto L01C4;
            L0134: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L0148: if (JumpNotEqual) goto L01C4;
            L014A: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L015E: if (JumpNotEqual) goto L01C4;
            L0160: Compare(GetFlag(player, 0x03, 0x08), 0x0001);
            L0174: if (JumpNotEqual) goto L01C4;
            L0176: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L018A: if (JumpNotEqual) goto L01C4;
            L018C: Compare(GetFlag(player, 0x03, 0x0A), 0x0001);
            L01A0: if (JumpNotEqual) goto L01C4;
            L01A2: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L01B5: if (JumpNotEqual) goto L01C4;
12DF  01B7 FF 76 08  push word [bp+0x8]
12E2  01BA FF 76 06  push word [bp+0x6]
12E5  01BD 0E     push cs
12E6  01BE E8 4C F6  call 0xf80d
            L01C1: goto L00FD;
            L01C4: ShowMessage(player, String16CF); // Boy, after your fight it here it looks like someone teepeed this place with a vengeance!
            L01D1: return; // RETURN;
        }

        private void Fn_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x09));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0102;
            L001B: SetFlag(player, 0x03, 0x09, 0x01);
            L0030: ShowMessage(player, String1728); // How are you going to explain this to the nice constable?  'See, there was this group of harpies taking their dogs out for a nice drag.'
            L003D: Compare(PartyCount(player), 0x0003);
            L0048: if (JumpBelowOrEqual) goto L0057;
            L004A: ShowMessage(player, String17B0); // If you want to avoid a public intoxication charge, you had better collect lots of souvenirs from this battle.  And yes, there are lots of potential souvenir donors right in front of you!
1352  0057 B8 0D 02  mov ax, 0x20d
            L005A: PushStack(player, ax);
            L005B: PushStack(player, 0x00);
            L005E: PushStack(player, ax);
            L005F: PushStack(player, 0xCC);
            L0063: PushStack(player, 0xAD);
            L0067: PushStack(player, 0x68);
1366  006B C4 5E 06  les bx, [bp+0x6]
1369  006E 26 FF 9F D8 00  call far word [es:bx+0xd8]
136E  0073 83 C4 0C  add sp, 0xc
            L0076: AddEncounter(player, 0x01, 0x1A);
            L0088: AddEncounter(player, 0x05, 0x19);
            L009A: Compare(PartyCount(player), 0x0001);
            L00A5: if (JumpBelowOrEqual) goto L00B9;
            L00A7: AddEncounter(player, 0x02, 0x1A);
            L00B9: Compare(PartyCount(player), 0x0003);
            L00C4: if (JumpAbove) goto L00C9;
            L00C6: goto L01D1;
            L00C9: AddEncounter(player, 0x04, 0x1A);
            L00DB: AddEncounter(player, 0x03, 0x1A);
            L00ED: AddEncounter(player, 0x06, 0x19);
            L00FF: goto L01D1;
            L0102: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L0116: if (JumpEqual) goto L011B;
            L0118: goto L01C4;
            L011B: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L012F: if (JumpEqual) goto L0134;
            L0131: goto L01C4;
            L0134: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L0148: if (JumpNotEqual) goto L01C4;
            L014A: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L015E: if (JumpNotEqual) goto L01C4;
            L0160: Compare(GetFlag(player, 0x03, 0x08), 0x0001);
            L0174: if (JumpNotEqual) goto L01C4;
            L0176: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L018A: if (JumpNotEqual) goto L01C4;
            L018C: Compare(GetFlag(player, 0x03, 0x0A), 0x0001);
            L01A0: if (JumpNotEqual) goto L01C4;
            L01A2: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L01B5: if (JumpNotEqual) goto L01C4;
14B2  01B7 FF 76 08  push word [bp+0x8]
14B5  01BA FF 76 06  push word [bp+0x6]
14B8  01BD 0E     push cs
14B9  01BE E8 79 F4  call 0xf63a
            L01C1: goto L00FD;
            L01C4: ShowMessage(player, String186B); // On second thought, you'll just avoid the constable lest he slap failure to curb your dog on top of the public intoxication charge.
            L01D1: return; // RETURN;
        }

        private void Fn_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0102;
            L001B: SetFlag(player, 0x03, 0x0A, 0x01);
            L0030: ShowMessage(player, String18EE); // It's hard to tell who is angrier: those medusae because they have bats tangled in their, uh, hair, or the bats so entangled.  Either way, they seem to have decided to release their frustrations on you!
            L003D: Compare(PartyCount(player), 0x0003);
            L0048: if (JumpBelowOrEqual) goto L0057;
            L004A: ShowMessage(player, String19B8); // You could have tried turning away their wrath by complimenting their new hairstyle, but you know that you wouldn't have sounded sincere.
1525  0057 B8 71 02  mov ax, 0x271
            L005A: PushStack(player, ax);
            L005B: PushStack(player, 0x00);
            L005E: PushStack(player, ax);
            L005F: PushStack(player, 0x3F);
            L0063: PushStack(player, 0xAD);
            L0067: PushStack(player, 0x55);
1539  006B C4 5E 06  les bx, [bp+0x6]
153C  006E 26 FF 9F D8 00  call far word [es:bx+0xd8]
1541  0073 83 C4 0C  add sp, 0xc
            L0076: AddEncounter(player, 0x01, 0x1B);
            L0088: AddEncounter(player, 0x05, 0x1C);
            L009A: Compare(PartyCount(player), 0x0002);
            L00A5: if (JumpBelowOrEqual) goto L00CB;
            L00A7: AddEncounter(player, 0x02, 0x1B);
            L00B9: AddEncounter(player, 0x06, 0x1C);
            L00CB: Compare(PartyCount(player), 0x0003);
            L00D6: if (JumpAbove) goto L00DB;
            L00D8: goto L01D1;
            L00DB: AddEncounter(player, 0x04, 0x1B);
            L00ED: AddEncounter(player, 0x03, 0x1C);
            L00FF: goto L01D1;
            L0102: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L0116: if (JumpEqual) goto L011B;
            L0118: goto L01C4;
            L011B: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L012F: if (JumpEqual) goto L0134;
            L0131: goto L01C4;
            L0134: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L0148: if (JumpNotEqual) goto L01C4;
            L014A: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L015E: if (JumpNotEqual) goto L01C4;
            L0160: Compare(GetFlag(player, 0x03, 0x08), 0x0001);
            L0174: if (JumpNotEqual) goto L01C4;
            L0176: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L018A: if (JumpNotEqual) goto L01C4;
            L018C: Compare(GetFlag(player, 0x03, 0x0A), 0x0001);
            L01A0: if (JumpNotEqual) goto L01C4;
            L01A2: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L01B5: if (JumpNotEqual) goto L01C4;
1685  01B7 FF 76 08  push word [bp+0x8]
1688  01BA FF 76 06  push word [bp+0x6]
168B  01BD 0E     push cs
168C  01BE E8 A6 F2  call 0xf467
            L01C1: goto L00FD;
            L01C4: ShowMessage(player, String1A41); // You remember how the medusae almost drove you batty here before.
            L01D1: return; // RETURN;
        }

        private void Fn_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: ax = GetFlag(player, 0x03, 0x0B);
16BB  001A 8B F8  mov di, ax
16BD  001C 47     inc di
16BE  001D 8B F7  mov si, di
            L001F: Compare(si, 0x13);
            L0022: if (JumpLessOrEqual) goto L002B;
16C5  0024 8B C6  mov ax, si
            L0026: si = ax + 0xFFEC;
            L002B: Compare(si, 0x0E);
            L002E: if (JumpLessOrEqual) goto L0037;
16D1  0030 8B C6  mov ax, si
            L0032: si = ax + 0xFFF1;
            L0037: Compare(si, 0x09);
            L003A: if (JumpLessOrEqual) goto L0043;
16DD  003C 8B C6  mov ax, si
            L003E: si = ax + 0xFFF6;
            L0043: Compare(si, 0x04);
            L0046: if (JumpLessOrEqual) goto L004F;
16E9  0048 8B C6  mov ax, si
            L004A: si = ax + 0xFFFB;
16F0  004F 0B F6  or si, si
16F2  0051 7D 02  jge 0x55
            L0053: si = 0;
            L0055: Compare(si, 0x1D);
            L0058: if (JumpLessOrEqual) goto L005C;
            L005A: si = 0;
16FD  005C 83 FF 1E  cmp di, 0x1e
            L005F: if (JumpLessOrEqual) goto L0063;
            L0061: di = 0;
1704  0063 57     push di
            L0064: PushStack(player, 0x0B);
            L0068: PushStack(player, 0x03);
170D  006C C4 5E 06  les bx, [bp+0x6]
1710  006F 26 FF 1F  call far word [es:bx]
1713  0072 83 C4 06  add sp, 0x6
1716  0075 83 FF 1A  cmp di, 0x1a
            L0078: if (JumpNotEqual) goto L007F;
171B  007A B8 01 00  mov ax, 0x1
            L007D: goto L0081;
            L007F: PushStack(player, 0x00);
1723  0082 83 FF 14  cmp di, 0x14
            L0085: if (JumpNotEqual) goto L008C;
1728  0087 B8 01 00  mov ax, 0x1
            L008A: goto L008E;
172D  008C 33 C0  xor ax, ax
            L008E: dx = PopStack(player);
1730  008F 0B D0  or dx, ax
            L0091: PushStack(player, dx);
1733  0092 83 FF 0E  cmp di, 0xe
            L0095: if (JumpNotEqual) goto L009C;
1738  0097 B8 01 00  mov ax, 0x1
            L009A: goto L009E;
173D  009C 33 C0  xor ax, ax
            L009E: dx = PopStack(player);
1740  009F 0B D0  or dx, ax
            L00A1: PushStack(player, dx);
1743  00A2 83 FF 08  cmp di, 0x8
            L00A5: if (JumpNotEqual) goto L00AC;
1748  00A7 B8 01 00  mov ax, 0x1
            L00AA: goto L00AE;
174D  00AC 33 C0  xor ax, ax
            L00AE: dx = PopStack(player);
1750  00AF 0B D0  or dx, ax
            L00B1: PushStack(player, dx);
1753  00B2 83 FF 02  cmp di, 0x2
            L00B5: if (JumpNotEqual) goto L00BC;
1758  00B7 B8 01 00  mov ax, 0x1
            L00BA: goto L00BE;
175D  00BC 33 C0  xor ax, ax
            L00BE: dx = PopStack(player);
1760  00BF 0B D0  or dx, ax
            L00C1: if (JumpNotEqual) goto L00C6;
            L00C3: goto L0207;
            L00C6: bx = si;
            L00C8: Compare(bx, 0x04);
            L00CB: if (JumpBelowOrEqual) goto L00D0;
            L00CD: goto L0207;
            L00D0: switch (bx) {
                case 0:
                    goto L00D7;
                case 1:
                    goto L00E7;
                case 2:
                    goto L0106;
                case 3:
                    goto L0118;
                case 4:
                    goto L0152;
            }
            L00D7: ShowMessage(player, String1A82); // You hear some footsteps running away.
            L00E4: goto L0207;
            L00E7: ShowMessage(player, String1AA8); // You hear someone running towards you.
            L00F4: ShowPortrait(player, 0x0018);
17A2  0101 B8 CE 1A  mov ax, 0x1ace
            L0104: goto L00DA;
            L0106: ShowPortrait(player, 0x0003);
17B4  0113 B8 B6 1B  mov ax, 0x1bb6
            L0116: goto L00DA;
            L0118: Compare(GetFlag(player, 0x02, 0x47), 0x0001);
            L012C: if (JumpNotEqual) goto L0133;
17CF  012E B8 79 1C  mov ax, 0x1c79
            L0131: goto L00DA;
            L0133: ShowPortrait(player, 0x0025);
            L0140: ShowMessage(player, String1CDF); // 'A marvelous day, friends, 'tis it not? Glorious enough for me to report my skill at detection was adequate for me to find both the northern and the southern entrances into the labyrinth.  Go ye and do likewise, eh?'
17EE  014D B8 B8 1D  mov ax, 0x1db8
            L0150: goto L00DA;
            L0152: ShowMessage(player, String1E15); // A large group of minotaurs spots you.
            L015F: ShowMessage(player, String1E3B); // 'There is the robber!' shouts one.
            L016C: ShowMessage(player, String1E5E); // 'Nay not,' retorts another.
            L0179: ShowMessage(player, String1E7A); // 'Let's get'm anyways!' cries a third, just before the arrival of the thundering herd.
            L0186: PushStack(player, 0xC1);
            L018A: PushStack(player, 0x00);
            L018D: PushStack(player, ax);
            L018E: PushStack(player, 0xCC);
            L0192: PushStack(player, 0x4C);
            L0196: PushStack(player, 0xB9);
183B  019A C4 5E 06  les bx, [bp+0x6]
183E  019D 26 FF 9F D8 00  call far word [es:bx+0xd8]
1843  01A2 83 C4 0C  add sp, 0xc
            L01A5: AddEncounter(player, 0x01, 0x14);
            L01B7: Compare(PartyCount(player), 0x0001);
            L01C2: if (JumpBelowOrEqual) goto L01D6;
            L01C4: AddEncounter(player, 0x05, 0x14);
            L01D6: Compare(PartyCount(player), 0x0002);
            L01E1: if (JumpBelowOrEqual) goto L0207;
            L01E3: AddEncounter(player, 0x02, 0x14);
            L01F5: AddEncounter(player, 0x06, 0x14);
            L0207: return; // RETURN (restoring si, di);
        }

        private void Fn_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0C));
            L0016: if (JumpNotEqual) goto L002D;
            L0018: SetFlag(player, 0x03, 0x0C, 0x01);
            L002D: return; // RETURN;
        }

        private void Fn_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpBelowOrEqual) goto L006B;
            L0010: SetWallPassable(player, GetCurrentTile(player), 0x01, 0x00);
            L0029: Compare(GetFacing(player), 0x0001);
            L0033: if (JumpEqual) goto L004A;
            L0035: RefreshCompareFlags(GetFlag(player, 0x03, 0x0E));
            L0048: if (JumpNotEqual) goto L0082;
            L004A: ShowMessage(player, String1ED0); // The narrow corridor to the south forces you to enter it single file.
            L0057: PushStack(player, 0x01);
            L005B: PushStack(player, 0x0E);
            L005F: PushStack(player, 0x03);
1948  0063 C4 5E 06  les bx, [bp+0x6]
194B  0066 26 FF 1F  call far word [es:bx]
            L0069: goto L007F;
            L006B: SetWallPassable(player, GetCurrentTile(player), ax, 0x01);
            L0082: return; // RETURN;
        }

        private void Fn_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000C);
            L0012: if (JumpNotBelow) goto L0026;
            L0014: PushStack(player, 0x86);
            L0018: PushStack(player, ax);
1982  0019 C4 5E 06  les bx, [bp+0x6]
1985  001C 26 FF 5F 54  call far word [es:bx+0x54]
            L0020: cx = PopStack(player);
            L0021: cx = PopStack(player);
            L0022: RefreshCompareFlags(ax);
            L0024: if (JumpEqual) goto L0082;
            L0026: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0044: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0062: PushStack(player, 0x01);
            L0066: PushStack(player, ax);
            L0067: PushStack(player, 0x00);
19D3  006A C4 5E 06  les bx, [bp+0x6]
19D6  006D 26 FF 1F  call far word [es:bx]
19D9  0070 83 C4 06  add sp, 0x6
            L0073: ShowMessage(player, String015B); // You've uncovered a hidden door!
            L0080: goto L00BC;
            L0082: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L009F: SetWallObject(player, 0x00, GetCurrentTile(player), GetFacing(player));
            L00BC: return; // RETURN;
        }

        private void Fn_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0C));
            L0016: if (JumpNotEqual) goto L006A;
            L0018: SetFlag(player, 0x03, 0x0C, 0x01);
            L002D: ShowPortrait(player, 0x0027);
            L003A: ShowMessage(player, String1F15); // 'Galatea forgot to mention that items of great use are being guarded by the minotaurs in the center of the labyrinth, but that thou must have an excellent nose for secret doors to access them.
            L0047: Compare(GetFlag(player, 0x03, 0x13), 0x0001);
            L005B: if (JumpNotEqual) goto L006A;
            L005D: ShowMessage(player, String1FD6); // 'But I think me thou hast already shown thy mettle in the labyrinth,' he says, smiling.
            L006A: return; // RETURN;
        }

        private void Fn_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x0B));
            L0016: if (JumpNotEqual) goto L0088;
            L0018: Compare(GetFlag(player, 0x03, 0x13), 0x0001);
            L002C: if (JumpNotEqual) goto L0088;
            L002E: ShowPortrait(player, 0x0015);
            L003B: ShowMessage(player, String202E); // 'Good on thee!  Thou hast cleared the minotaur's lair, whose tricksome turns will baffle my sister's agents long enough for me to reward thee yet again!  As I gave thee skills before, this time I shall grant thee a spell.
            L0048: ShowMessage(player, String210C); // The mightiest spell I can grant thee is now to be thine.  This spell harms all that thou dost fight, with a power nigh unto the most mighty.  It is called Death Darts.'  You now know that spell!
            L0055: SetSpellLevel(player, 0x04, 0x03);
            L0066: SetFlag(player, 0x02, 0x0B, 0x01);
            L007B: ShowMessage(player, String21CF); // Galatea gets a distant look in her eyes.  'I dare no longer stay.  Good fortune!'
            L0088: return; // RETURN;
        }

        private void Fn_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x10));
            L0016: if (JumpNotEqual) goto L0091;
            L0018: SetFlag(player, 0x03, 0x10, 0x01);
            L002D: ShowMessage(player, String2221); // There seem to be many minotaurs in this labyrinth.
            L003A: AddEncounter(player, 0x01, 0x14);
            L004C: AddEncounter(player, 0x02, 0x14);
            L005E: Compare(PartyCount(player), 0x0003);
            L0069: if (JumpBelowOrEqual) goto L009E;
            L006B: AddEncounter(player, 0x04, 0x14);
            L007D: AddEncounter(player, 0x03, 0x14);
            L008F: goto L009E;
            L0091: ShowMessage(player, String2254); // Sirloin; prime rib; yup, you fought minotaurs here.
            L009E: return; // RETURN;
        }

        private void Fn_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x11));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00A6;
            L001B: SetFlag(player, 0x03, 0x11, 0x01);
            L0030: ShowMessage(player, String2221); // There seem to be many minotaurs in this labyrinth.
            L003D: AddEncounter(player, 0x01, 0x14);
            L004F: AddEncounter(player, 0x02, 0x14);
            L0061: AddEncounter(player, 0x03, 0x14);
            L0073: Compare(PartyCount(player), 0x0003);
            L007E: if (JumpBelowOrEqual) goto L00B3;
            L0080: AddEncounter(player, 0x04, 0x14);
            L0092: AddEncounter(player, 0x05, 0x14);
            L00A4: goto L00B3;
            L00A6: ShowMessage(player, String2254); // Sirloin; prime rib; yup, you fought minotaurs here.
            L00B3: return; // RETURN;
        }

        private void Fn_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x12));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00B8;
            L001B: SetFlag(player, 0x03, 0x12, 0x01);
            L0030: ShowMessage(player, String2288); // The minotaurs seem to be arriving in ever larger herds.  You hope that means you are getting near the center.
            L003D: AddEncounter(player, 0x01, 0x14);
            L004F: AddEncounter(player, 0x02, 0x14);
            L0061: AddEncounter(player, 0x03, 0x14);
            L0073: AddEncounter(player, 0x04, 0x14);
            L0085: Compare(PartyCount(player), 0x0003);
            L0090: if (JumpBelowOrEqual) goto L00C5;
            L0092: AddEncounter(player, 0x05, 0x14);
            L00A4: AddEncounter(player, 0x06, 0x14);
            L00B6: goto L00C5;
            L00B8: ShowMessage(player, String2254); // Sirloin; prime rib; yup, you fought minotaurs here.
            L00C5: return; // RETURN;
        }

        private void Fn_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x13));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00D7;
            L001B: SetFlag(player, 0x03, 0x13, 0x01);
            L0030: ShowMessage(player, String22F6); // Y'know, these minotaurs seem a lot meaner than the last group.
1DB2  003D B8 C1 48  mov ax, 0x48c1
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, 0xCD);
            L0049: PushStack(player, 0x9A);
            L004D: PushStack(player, 0x7F);
1DC6  0051 C4 5E 06  les bx, [bp+0x6]
1DC9  0054 26 FF 9F D8 00  call far word [es:bx+0xd8]
1DCE  0059 83 C4 0C  add sp, 0xc
            L005C: AddEncounter(player, 0x01, 0x1D);
            L006E: AddEncounter(player, 0x02, 0x1D);
            L0080: AddEncounter(player, 0x03, 0x1D);
            L0092: AddEncounter(player, 0x04, 0x1D);
            L00A4: Compare(PartyCount(player), 0x0002);
            L00AF: if (JumpBelowOrEqual) goto L00E4;
            L00B1: AddEncounter(player, 0x05, 0x1D);
            L00C3: AddEncounter(player, 0x06, 0x1D);
            L00D5: goto L00E4;
            L00D7: ShowMessage(player, String2335); // You showed them who ranked where on the food chain!
            L00E4: return; // RETURN;
        }

    }
}
