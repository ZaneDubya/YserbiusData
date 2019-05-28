#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap00 : AMapScripted {
        protected override int MapIndex => 0;
        protected override int RandomEncounterChance => 0;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap00() {
            MapEvent01 = Fn_01;
            MapEvent02 = Fn_02;
            MapEvent03 = Fn_03;
            MapEvent04 = Fn_04;
            MapEvent05 = Fn_05;
            MapEvent06 = Fn_06;
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
            MapEvent1B = Fn_1B;
            MapEvent1C = Fn_1C;
            MapEvent1D = Fn_1D;
            MapEvent1E = Fn_1E;
            MapEvent1F = Fn_1F;
            MapEvent24 = Fn_24;
            MapEvent25 = Fn_25;
            MapEvent26 = Fn_26;
            MapEvent27 = Fn_27;
            MapEvent28 = Fn_28;
            MapEvent29 = Fn_29;
            MapEvent2A = Fn_2A;
            MapEvent2B = Fn_2B;
            MapEvent2C = Fn_2C;
            MapEvent2D = Fn_2D;
            MapEvent2E = Fn_2E;
            MapEvent2F = Fn_2F;
            MapEvent30 = Fn_30;
            MapEvent31 = Fn_31;
            MapEvent32 = Fn_32;
            MapEvent33 = Fn_33;
            MapEvent34 = Fn_34;
        }
        
        // === Strings ================================================
        private const string String0140 = "The torches are well maintained despite the decrepit nature of this place.";
        private const string String018B = "The flickering torchlight illumines the area.";
        private const string String01B9 = "This gateway leads to The Runed Room.";
        private const string String01DF = "These arches lead to The Runed Room.";
        private const string String0204 = "This door leads to a narrow rising stairwell.";
        private const string String0232 = "This narrow stairwell forces you to climb it single file.";
        private const string String026C = "The door slams shut in front of your face and disappears to boot!  How rude!";
        private const string String02B9 = "You hear a faint whisper, 'Thou art not yet ready to face the tests and travails upstairs.'";
        private const string String0315 = "To the south is the exit from the Ruins of Cawdor.";
        private const string String0348 = "Big mistake!";
        private const string String0355 = "The bearded face, now angry, reappears in the roiling and churning fountain.  Your legs convulse from sudden agony.  You'd have wished you'd worn your insulated boots if you knew what insulated boots were.";
        private const string String0423 = "'Arroint thee, rump-fed runion!  Stay out of my fountain!'";
        private const string String045E = "'Thou guttersnipe!  Cease befouling my home!'";
        private const string String048C = "'Eater of overripe peaches!  Leave me alone!'";
        private const string String04BA = "'Ignoramus!  Canst thou not understand the simplest instructions?  Leave me alone!'";
        private const string String050E = "'Art thou one of those perverted french types who dost enjoy being damaged? An thou art not, than heed my instructions and do not enter my fountain again!'";
        private const string String05AA = "'I hope thou art getting a charge out of this!'";
        private const string String05DA = "Watt's up, doc?";
        private const string String05EA = "All you need is five minutes alone with this guy in a dark alley.  Of course, guys that live in fountains rarely frequent dark alleys.";
        private const string String0671 = "As you frizzle and fry, you notice that there is one small benefit: it took out that gooseberry stain you've had since last solstice.";
        private const string String06F7 = "'Practiser of improper grooming!  Thou shalt feel the full brunt of my punishment when thy hairdresser informs thee that thy coiffure is irrevocably ruined!'";
        private const string String0795 = "You feel half dead, but squeaky clean!";
        private const string String07BC = "Wow!  Pour enough voltage into anyone and they glow in the dark!  I guess from here on your nickname will be twinkletoes, because they do.";
        private const string String0847 = "So you can't remember to stay out of a fountain after being asked politely and then being zapped half to death about a dozen times.";
        private const string String08CB = "So I'm betting you won't even notice that the messages are repeating.";
        private const string String0911 = "*";
        private const string String0913 = "An old bearded face appears, mirrorlike, in the waters of the fountain.  It speaks to you.";
        private const string String096E = "'If thou art so fascinated with runes, then I shall grant thee the skill to read them, an thou dost leave me alone henceforth.  Now begone!";
        private const string String09FA = "It feels good to splash around in this old runed fountain.";
        private const string String0A35 = "'Hah!  Hit me!  I dare thee!  'Tis right; thou cannot! I deduced and deciphered what to do in the six main rooms on this level, and now I know the Shield Spell.'";
        private const string String0AD7 = "'I am for the higher regions, thou ignorant clod; the real treasure awaits upstairs.  And I shall be eating of the fatted calf whilst thou still toils in the tedium down here!  Ah hah hah hah!'";
        private const string String0B99 = "The wizard wobbles off, laughing maniacally, obviously at least a pint over his limit.  But drunk on liquor or power, or just insane, that shield spell sounds very useful.";
        private const string String0C45 = "A familiar looking wizard limps towards you.";
        private const string String0C72 = "'Latha math!  Ah, I can see by thy expression that thou wouldst prefer we converse in the King's English.'";
        private const string String0CDD = "'I must confess, when I did gain command of the Shield spell, I thought my troubles with battles had come to an end.  How wrong I was!";
        private const string String0D64 = "'Upstairs there are mages aplenty, making the Resist spell nigh as useful as Shield.  And some of the dwellers upstairs are more than mighty enough to pierce a Shield spell.'";
        private const string String0E13 = "'The key to survival is to know which to cast, and when.  But I'm for a hot soak of this old wyrm injury.  Beannachd leibh!'";
        private const string String0E90 = "The wizard limps off.";
        private const string String0EA6 = "'Welcome to Cawdor!'";
        private const string String0EBB = "'As thou art but newly arrived, may I suggest that thou shouldst fully explore this room, and The Runed Room through the eastern corridor, afore thou dost pursue the more dangerous sections of Cawdor.'";
        private const string String0F85 = "'The Stables, accessible through the eastern end of the south wall, will afford thee an opportunity to meet the local blacksmith, but do not have much in the way of excitement.'";
        private const string String1037 = "Was there a magical glow off to the east?";
        private const string String1061 = "You're being driven batty!";
        private const string String107C = "To the north is the doorway to Uncivilization.";
        private const string String10AB = "To the west is the doorway to Uncivilization.";
        private const string String10D9 = "A gravelly voice, a voice created by too many centuries smoking bad cigars, gruffly speaks.";
        private const string String1135 = "'About time you got here, kid.  Have I got some tasks for you!'";
        private const string String1175 = "An old voice, a prehistoric voice, a voice so steeped in primordial ooze you can almost smell the tar, says, 'I wouldn't go forward if I were you, kid.  If you can't trust me, who can you trust?'";
        private const string String1239 = "To the north is the doorway to the Chivalrous Room.";
        private const string String126D = "To the east is the doorway to the Chivalrous Room.";
        private const string String12A0 = "You approach the portal to the Thaumaturgium.";
        private const string String12CE = "The door to the Trophy Room is nigh!";
        private const string String12F3 = "Happy is the traveller who can enter the Trophy Room!";
        private const string String1329 = "Enter, brother, and welcome!";
        private const string String1346 = "A voice whispers from the shadows....'Psst!  You better be one of the Brotherhood if you want to get through there, buddy.'";
        private const string String13C2 = "'I mean the Brotherhood of Thieves, pal.'";
        private const string String13EC = "The voice did not sound friendly.";
        private const string String140E = "This door leads to The Stables of Cawdor.";
        private const string String1438 = "You see two orc barbarians conversing.";
        private const string String145F = "'You have the B for Barbarian, the R for Ranger, and the W for wizard, right?' asks the woman.";
        private const string String14BE = "'Uh, er, but I thought it was M for Mage, like in the Music Room,' says the man.";
        private const string String150F = "'Wizards built this whole place, so naturally they gave themselves two acronyms!  Now do you understand?' asks the woman.";
        private const string String1589 = "'Almost.  Duh, uh, what's an acronym?'";
        private const string String15B0 = "You leave them arguing.  Barbarians are not noted for the breadth of their vocabularies.";
        private const string String1609 = "Angelic singing fills the room.  Seraphim and cherubim greet you with the sound of heaven's host.  The samite colored door opens wide.";
        private const string String1690 = "Well, maybe under all that paint it's samite colored.";
        private const string String16C6 = "A voice created by decades of simmering in bad cigars greets you gruffly.  'Talking lions out of lamb chops was easier than giving you a hint. Go away!'";
        private const string String175F = "The door opens itself before one schooled in the magical arts.  The Thaumaturgium awaits you!";
        private const string String17BD = "Everything you try, every skill, every spell, every item, plea, and curse, avails you nought. ";
        private const string String181C = "Only a wizard and that wizard's party can pass.";
        private const string String184C = "You hear the distinct sound of sniffing just before the door opens.  You don't know whether to be pleased or disappointed.";
        private const string String18C7 = "In fact, it sniffs for such a long time that you worry whether your recent bath in the stables has washed away too much dirt, but fear not!  Your natural odor, and the passage of time, compensated fully.";
        private const string String1993 = "'This door will open for neither cents nor sense, unless it senses the scents of a barbarian,' he says.";
        private const string String19FB = "A bright light shines down upon you, and bathed in its beneficence, the door opens.";
        private const string String1A4F = "An indirect light grows steadily brighter and the door creaks, but as if failing to find what it seeks, it stills.  You cannot enter.";
        private const string String1AD5 = "The magical wood of this door responds to your presence by swinging open before you.";
        private const string String1B2A = "After three bruised knuckles, one barked shin, and two stubbed toes, you decide there is no way in unless you find a ranger.";
        private const string String1BA7 = "Keep that up and in addition to being dead as a door knob you'll be dead from a door, Nob!";
        private const string String1C02 = "Someone in your party gives the secret thievish countersign.  The door swings open.";
        private const string String1C56 = "You hear a sound....";
        private const string String1C6B = "6,198 thieves, wielding nastily stained weapons, and most with a nimbus of magical defenses already cast, step forward to block your path.";
        private const string String1CF6 = "'Hmmm,' you think to yourself. 'That doorway's awfully crowded right now. Maybe I'll go find a thief and come back later.'";
        
        // === Functions ================================================
        private void Fn_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ExitDungeon(player, isForwardMove);
            L000B: return; // RETURN;
        }

        private void Fn_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0140); // The torches are well maintained despite the decrepit nature of this place.
            L0010: return; // RETURN;
        }

        private void Fn_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String018B); // The flickering torchlight illumines the area.
            L0010: return; // RETURN;
        }

        private void Fn_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String01B9); // This gateway leads to The Runed Room.
            L0010: return; // RETURN;
        }

        private void Fn_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String01DF); // These arches lead to The Runed Room.
            L0010: return; // RETURN;
        }

        private void Fn_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x06), 0x0001);
            L0017: if (JumpNotEqual) goto L007A;
            L0019: ShowMessage(player, String0204); // This door leads to a narrow rising stairwell.
            L0026: Compare(PartyCount(player), 0x0001);
            L0031: if (JumpNotEqual) goto L0051;
            L0033: TeleportParty(player, 0x04, 0x01, 0xFA, 0x03, isForwardMove);
            L004E: goto L00F8;
            L0051: ShowMessage(player, String0232); // This narrow stairwell forces you to climb it single file.
            L005E: PushStack(player, 0x00);
            L0061: PushStack(player, GetFacing(player));
            L0069: PushStack(player, GetCurrentTile(player));
00C7  0071 C4 5E 06  les bx, [bp+0x6]
00CA  0074 26 FF 5F 2C  call far word [es:bx+0x2c]
            L0078: goto L00F5;
            L007A: Compare(GetFlag(player, 0x03, 0x16), 0x0001);
            L008E: if (JumpNotEqual) goto L00F8;
            L0090: ShowMessage(player, String026C); // The door slams shut in front of your face and disappears to boot!  How rude!
            L009D: ShowMessage(player, String02B9); // You hear a faint whisper, 'Thou art not yet ready to face the tests and travails upstairs.'
            L00AA: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00C7: SetWallObject(player, 0x00, GetCurrentTile(player), GetFacing(player));
            L00E4: SetFlag(player, 0x03, 0x16, 0x00);
            L00F8: return; // RETURN;
        }

        private void Fn_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0315); // To the south is the exit from the Ruins of Cawdor.
            L0010: return; // RETURN;
        }

        private void Fn_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x01, 0x02, 0x80, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void Fn_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = 0;
            L0006: si = GetFlag(player, 0x02, 0x11);
            L0019: si = si + 1;
            L001A: Compare(si, 0x03);
            L001D: if (JumpGreater) goto L0022;
            L001F: goto L01D8;
            L0022: ShowPortrait(player, 0x002D);
            L002F: Compare(si, 0x10);
            L0032: if (JumpLessOrEqual) goto L0037;
            L0034: si = 0x0004;
            L0037: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L004B: if (JumpNotEqual) goto L0092;
            L004D: ShowMessage(player, String0348); // Big mistake!
            L005A: DamagePlayer(player, GetMaxHits(player));
            L006B: ModifyGold(player, 0xFFFF48BA);
            L007D: AddExperience(player, 0xFFFFFC18);
            L008F: goto L026E;
            L0092: SetFlag(player, 0xC4, 0xB8, si);
            L00A4: ShowPortrait(player, 0x002D);
            L00B1: ShowMessage(player, String0355); // The bearded face, now angry, reappears in the roiling and churning fountain.  Your legs convulse from sudden agony.  You'd have wished you'd worn your insulated boots if you knew what insulated boots were.
            L00BE: PushStack(player, 0x01);
            L00C2: PushStack(player, ax);
            L00C3: PushStack(player, 0x03);
024E  00C7 C4 5E 06  les bx, [bp+0x6]
0251  00CA 26 FF 1F  call far word [es:bx]
0254  00CD 83 C4 06  add sp, 0x6
            L00D0: ax = GetMaxHits(player);
            L00D7: bx = 0x0002;
            L00DA: dx = ax % bx; ax = ax / bx;
            L00DD: DamagePlayer(player, ax);
            L00E7: bx = si;
0270  00E9 83 EB 04  sub bx, 0x4
            L00EC: Compare(bx, 0x0B);
            L00EF: if (JumpBelowOrEqual) goto L00F4;
            L00F1: goto L01BB;
            L00F4: switch (bx) {
                case 0:
                    goto L00FB;
                case 1:
                    goto L010B;
                case 2:
                    goto L011B;
                case 3:
                    goto L012B;
                case 4:
                    goto L013B;
                case 5:
                    goto L014B;
                case 6:
                    goto L015B;
                case 7:
                    goto L016B;
                case 8:
                    goto L017B;
                case 9:
                    goto L018B;
                case 10:
                    goto L019B;
                case 11:
                    goto L01AB;
            }
            L00FB: ShowMessage(player, String0423); // 'Arroint thee, rump-fed runion!  Stay out of my fountain!'
            L0108: goto L026E;
            L010B: ShowMessage(player, String045E); // 'Thou guttersnipe!  Cease befouling my home!'
            L0118: goto L026E;
            L011B: ShowMessage(player, String048C); // 'Eater of overripe peaches!  Leave me alone!'
            L0128: goto L026E;
            L012B: ShowMessage(player, String04BA); // 'Ignoramus!  Canst thou not understand the simplest instructions?  Leave me alone!'
            L0138: goto L026E;
            L013B: ShowMessage(player, String050E); // 'Art thou one of those perverted french types who dost enjoy being damaged? An thou art not, than heed my instructions and do not enter my fountain again!'
            L0148: goto L026E;
            L014B: ShowMessage(player, String05AA); // 'I hope thou art getting a charge out of this!'
            L0158: goto L026E;
            L015B: ShowMessage(player, String05DA); // Watt's up, doc?
            L0168: goto L026E;
            L016B: ShowMessage(player, String05EA); // All you need is five minutes alone with this guy in a dark alley.  Of course, guys that live in fountains rarely frequent dark alleys.
            L0178: goto L026E;
            L017B: ShowMessage(player, String0671); // As you frizzle and fry, you notice that there is one small benefit: it took out that gooseberry stain you've had since last solstice.
            L0188: goto L026E;
            L018B: ShowMessage(player, String06F7); // 'Practiser of improper grooming!  Thou shalt feel the full brunt of my punishment when thy hairdresser informs thee that thy coiffure is irrevocably ruined!'
            L0198: goto L026E;
            L019B: ShowMessage(player, String0795); // You feel half dead, but squeaky clean!
            L01A8: goto L026E;
            L01AB: ShowMessage(player, String07BC); // Wow!  Pour enough voltage into anyone and they glow in the dark!  I guess from here on your nickname will be twinkletoes, because they do.
            L01B8: goto L026E;
            L01BB: ShowMessage(player, String0847); // So you can't remember to stay out of a fountain after being asked politely and then being zapped half to death about a dozen times.
            L01C8: ShowMessage(player, String08CB); // So I'm betting you won't even notice that the messages are repeating.
            L01D5: goto L026E;
            L01D8: Compare(si, 0x03);
            L01DB: if (JumpNotEqual) goto L0242;
            L01DD: ShowPortrait(player, 0x002D);
            L01EA: ShowMessage(player, String0911); // *
            L01F7: ShowMessage(player, String0911); // *
            L0204: ShowMessage(player, String0911); // *
            L0211: ShowMessage(player, String0913); // An old bearded face appears, mirrorlike, in the waters of the fountain.  It speaks to you.
            L021E: ShowMessage(player, String096E); // 'If thou art so fascinated with runes, then I shall grant thee the skill to read them, an thou dost leave me alone henceforth.  Now begone!
            L022B: SetSkillLevel(player, 0x14, 0x01);
            L023C: PushStack(player, 0x04);
            L0240: goto L025D;
            L0242: ShowPortrait(player, 0x0042);
            L024F: ShowMessage(player, String09FA); // It feels good to splash around in this old runed fountain.
            L025C: SetFlag(player, 0xC4, 0xB8, si);
            L026E: return; // RETURN (restoring si);
        }

        private void Fn_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x12));
            L0016: if (JumpNotEqual) goto L008B;
            L0018: ShowPortrait(player, 0x002B);
            L0025: ShowMessage(player, String0911); // *
            L0032: ShowMessage(player, String0911); // *
            L003F: ShowMessage(player, String0911); // *
            L004C: ShowMessage(player, String0A35); // 'Hah!  Hit me!  I dare thee!  'Tis right; thou cannot! I deduced and deciphered what to do in the six main rooms on this level, and now I know the Shield Spell.'
            L0059: ShowMessage(player, String0AD7); // 'I am for the higher regions, thou ignorant clod; the real treasure awaits upstairs.  And I shall be eating of the fatted calf whilst thou still toils in the tedium down here!  Ah hah hah hah!'
            L0066: ShowMessage(player, String0B99); // The wizard wobbles off, laughing maniacally, obviously at least a pint over his limit.  But drunk on liquor or power, or just insane, that shield spell sounds very useful.
            L0073: SetFlag(player, 0x02, 0x12, 0x01);
            L0088: goto L0110;
            L008B: RefreshCompareFlags(GetFlag(player, 0x03, 0x1E));
            L009E: if (JumpNotEqual) goto L0110;
            L00A0: SetFlag(player, 0x03, 0x1E, 0x01);
            L00B5: ShowPortrait(player, 0x002B);
            L00C2: ShowMessage(player, String0C45); // A familiar looking wizard limps towards you.
            L00CF: ShowMessage(player, String0C72); // 'Latha math!  Ah, I can see by thy expression that thou wouldst prefer we converse in the King's English.'
            L00DC: ShowMessage(player, String0CDD); // 'I must confess, when I did gain command of the Shield spell, I thought my troubles with battles had come to an end.  How wrong I was!
            L00E9: ShowMessage(player, String0D64); // 'Upstairs there are mages aplenty, making the Resist spell nigh as useful as Shield.  And some of the dwellers upstairs are more than mighty enough to pierce a Shield spell.'
            L00F6: ShowMessage(player, String0E13); // 'The key to survival is to know which to cast, and when.  But I'm for a hot soak of this old wyrm injury.  Beannachd leibh!'
            L0103: ShowMessage(player, String0E90); // The wizard limps off.
            L0110: return; // RETURN;
        }

        private void Fn_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x15));
            L0016: if (JumpNotEqual) goto L006E;
053A  0018 C4 5E 06  les bx, [bp+0x6]
053D  001B 26 FF 9F 84 00  call far word [es:bx+0x84]
            L0020: Compare(ax, 0x0004);
            L0023: if (JumpNotBelow) goto L006E;
            L0025: ShowPortrait(player, 0x002B);
            L0032: ShowMessage(player, String0EA6); // 'Welcome to Cawdor!'
            L003F: ShowMessage(player, String0EBB); // 'As thou art but newly arrived, may I suggest that thou shouldst fully explore this room, and The Runed Room through the eastern corridor, afore thou dost pursue the more dangerous sections of Cawdor.'
            L004C: ShowMessage(player, String0F85); // 'The Stables, accessible through the eastern end of the south wall, will afford thee an opportunity to meet the local blacksmith, but do not have much in the way of excitement.'
            L0059: SetFlag(player, 0x03, 0x15, 0x01);
            L006E: Compare(GetFlag(player, 0x02, 0x06), 0x0001);
            L0082: if (JumpNotEqual) goto L00CF;
            L0084: RefreshCompareFlags(GetFlag(player, 0x03, 0x14));
            L0097: if (JumpNotEqual) goto L00CF;
            L0099: ShowMessage(player, String1037); // Was there a magical glow off to the east?
            L00A6: SetFlag(player, 0x03, 0x16, 0x01);
            L00BB: PushStack(player, 0x01);
            L00BF: PushStack(player, 0x14);
            L00C3: PushStack(player, 0x03);
05E9  00C7 C4 5E 06  les bx, [bp+0x6]
05EC  00CA 26 FF 1F  call far word [es:bx]
            L00CD: goto L010B;
            L00CF: RefreshCompareFlags(GetFlag(player, 0x02, 0x06));
            L00E2: if (JumpNotEqual) goto L010E;
            L00E4: SetWallObject(player, 0x00, 0xFB, 0x01);
            L00F9: SetWallPassable(player, 0xFB, 0x01, 0x00);
            L010E: return; // RETURN;
        }

        private void Fn_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpNotEqual) goto L005E;
            L0018: SetFlag(player, 0x03, 0x02, 0x01);
            L002D: AddEncounter(player, 0x01, 0x19);
            L003F: Compare(PartyCount(player), 0x0001);
            L004A: if (JumpBelowOrEqual) goto L005E;
            L004C: AddEncounter(player, 0x02, 0x1E);
            L005E: return; // RETURN;
        }

        private void Fn_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
069A  0008 C4 5E 06  les bx, [bp+0x6]
069D  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpNotEqual) goto L0058;
            L0015: PushStack(player, 0x01);
            L0019: PushStack(player, 0x03);
            L001D: PushStack(player, ax);
06B0  001E C4 5E 06  les bx, [bp+0x6]
06B3  0021 26 FF 1F  call far word [es:bx]
06B6  0024 83 C4 06  add sp, 0x6
            L0027: AddEncounter(player, 0x01, 0x1A);
            L0039: Compare(PartyCount(player), 0x0001);
            L0044: if (JumpBelowOrEqual) goto L0058;
            L0046: AddEncounter(player, 0x02, 0x1E);
            L0058: return; // RETURN;
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0016: if (JumpNotEqual) goto L005E;
            L0018: SetFlag(player, 0x03, 0x04, 0x01);
            L002D: AddEncounter(player, 0x01, 0x1B);
            L003F: Compare(PartyCount(player), 0x0001);
            L004A: if (JumpBelowOrEqual) goto L005E;
            L004C: AddEncounter(player, 0x02, 0x1E);
            L005E: return; // RETURN;
        }

        private void Fn_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0016: if (JumpNotEqual) goto L0074;
            L0018: SetFlag(player, 0x03, 0x05, 0x01);
            L002D: PushStack(player, 0x00);
            L0030: PushStack(player, ax);
            L0031: PushStack(player, ax);
            L0032: PushStack(player, ax);
            L0033: PushStack(player, ax);
            L0034: PushStack(player, 0x01);
0784  0038 C4 5E 06  les bx, [bp+0x6]
0787  003B 26 FF 9F D8 00  call far word [es:bx+0xd8]
078C  0040 83 C4 0C  add sp, 0xc
            L0043: AddEncounter(player, 0x01, 0x1C);
            L0055: Compare(PartyCount(player), 0x0001);
            L0060: if (JumpBelowOrEqual) goto L0074;
            L0062: AddEncounter(player, 0x02, 0x1F);
            L0074: return; // RETURN;
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0016: if (JumpNotEqual) goto L0077;
            L0018: SetFlag(player, 0x03, 0x06, 0x01);
            L002D: PushStack(player, 0x00);
            L0030: PushStack(player, ax);
            L0031: PushStack(player, ax);
            L0032: PushStack(player, ax);
            L0033: PushStack(player, 0x46);
            L0037: PushStack(player, 0x01);
07FD  003B C4 5E 06  les bx, [bp+0x6]
0800  003E 26 FF 9F D8 00  call far word [es:bx+0xd8]
0805  0043 83 C4 0C  add sp, 0xc
            L0046: AddEncounter(player, 0x01, 0x1D);
            L0058: Compare(PartyCount(player), 0x0001);
            L0063: if (JumpBelowOrEqual) goto L0077;
            L0065: AddEncounter(player, 0x02, 0x1F);
            L0077: return; // RETURN;
        }

        private void Fn_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0016: if (JumpNotEqual) goto L0074;
            L0018: SetFlag(player, 0x03, 0x07, 0x01);
            L002D: PushStack(player, 0x00);
            L0030: PushStack(player, ax);
            L0031: PushStack(player, ax);
            L0032: PushStack(player, ax);
            L0033: PushStack(player, ax);
            L0034: PushStack(player, 0x01);
0873  0038 C4 5E 06  les bx, [bp+0x6]
0876  003B 26 FF 9F D8 00  call far word [es:bx+0xd8]
087B  0040 83 C4 0C  add sp, 0xc
            L0043: AddEncounter(player, 0x01, 0x21);
            L0055: Compare(PartyCount(player), 0x0001);
            L0060: if (JumpBelowOrEqual) goto L0074;
            L0062: AddEncounter(player, 0x02, 0x19);
            L0074: return; // RETURN;
        }

        private void Fn_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x08));
            L0016: if (JumpNotEqual) goto L005E;
            L0018: SetFlag(player, 0x03, 0x08, 0x01);
            L002D: AddEncounter(player, 0x01, 0x20);
            L003F: Compare(PartyCount(player), 0x0001);
            L004A: if (JumpBelowOrEqual) goto L005E;
            L004C: AddEncounter(player, 0x02, 0x1E);
            L005E: return; // RETURN;
        }

        private void Fn_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x09));
            L0016: if (JumpNotEqual) goto L006B;
            L0018: SetFlag(player, 0x03, 0x09, 0x01);
            L002D: AddEncounter(player, 0x01, 0x22);
            L003F: Compare(PartyCount(player), 0x0001);
            L004A: if (JumpBelowOrEqual) goto L006B;
            L004C: ShowMessage(player, String1061); // You're being driven batty!
            L0059: AddEncounter(player, 0x02, 0x25);
            L006B: return; // RETURN;
        }

        private void Fn_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L0016: if (JumpNotEqual) goto L005E;
            L0018: SetFlag(player, 0x03, 0x0A, 0x01);
            L002D: AddEncounter(player, 0x01, 0x23);
            L003F: Compare(PartyCount(player), 0x0001);
            L004A: if (JumpBelowOrEqual) goto L005E;
            L004C: AddEncounter(player, 0x02, 0x26);
            L005E: return; // RETURN;
        }

        private void Fn_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String107C); // To the north is the doorway to Uncivilization.
            L0010: return; // RETURN;
        }

        private void Fn_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String10AB); // To the west is the doorway to Uncivilization.
            L0010: return; // RETURN;
        }

        private void Fn_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x04);
0A09  0007 C4 5E 06  les bx, [bp+0x6]
0A0C  000A 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L000F: cx = PopStack(player);
            L0010: RefreshCompareFlags(ax);
            L0012: if (JumpNotEqual) goto L0056;
            L0014: Compare(GetFlag(player, 0x02, 0x51), 0x0001);
            L0028: if (JumpEqual) goto L0056;
            L002A: Compare(GetFlag(player, 0x02, 0x01), 0x0001);
            L003E: if (JumpEqual) goto L0056;
            L0040: Compare(GetFlag(player, 0x02, 0x06), 0x0001);
            L0054: if (JumpNotEqual) goto L00AE;
            L0056: ShowMessage(player, String0911); // *
            L0063: ShowMessage(player, String0911); // *
            L0070: ShowMessage(player, String0911); // *
            L007D: ShowMessage(player, String10D9); // A gravelly voice, a voice created by too many centuries smoking bad cigars, gruffly speaks.
            L008A: ShowMessage(player, String1135); // 'About time you got here, kid.  Have I got some tasks for you!'
            L0097: SetWallObject(player, 0x01, 0x40, 0x00);
            L00AC: goto L00E2;
            L00AE: ShowMessage(player, String0911); // *
            L00BB: ShowMessage(player, String0911); // *
            L00C8: ShowMessage(player, String0911); // *
            L00D5: ShowMessage(player, String1175); // An old voice, a prehistoric voice, a voice so steeped in primordial ooze you can almost smell the tar, says, 'I wouldn't go forward if I were you, kid.  If you can't trust me, who can you trust?'
            L00E2: return; // RETURN;
        }

        private void Fn_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1239); // To the north is the doorway to the Chivalrous Room.
            L0010: return; // RETURN;
        }

        private void Fn_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String126D); // To the east is the doorway to the Chivalrous Room.
            L0010: return; // RETURN;
        }

        private void Fn_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String12A0); // You approach the portal to the Thaumaturgium.
            L0010: return; // RETURN;
        }

        private void Fn_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String12CE); // The door to the Trophy Room is nigh!
            L0010: return; // RETURN;
        }

        private void Fn_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String12F3); // Happy is the traveller who can enter the Trophy Room!
            L0010: return; // RETURN;
        }

        private void Fn_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0003);
            L000D: if (JumpNotEqual) goto L0014;
0B4F  000F B8 29 13  mov ax, 0x1329
            L0012: goto L0058;
            L0014: ShowMessage(player, String0911); // *
            L0021: ShowMessage(player, String0911); // *
            L002E: ShowMessage(player, String0911); // *
            L003B: ShowMessage(player, String1346); // A voice whispers from the shadows....'Psst!  You better be one of the Brotherhood if you want to get through there, buddy.'
            L0048: ShowMessage(player, String13C2); // 'I mean the Brotherhood of Thieves, pal.'
            L0055: ShowMessage(player, String13EC); // The voice did not sound friendly.
            L0062: return; // RETURN;
        }

        private void Fn_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String140E); // This door leads to The Stables of Cawdor.
            L0010: TeleportParty(player, 0x0C, 0x01, 0x0D, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void Fn_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0017);
            L0010: ShowMessage(player, String1438); // You see two orc barbarians conversing.
            L001D: ShowMessage(player, String145F); // 'You have the B for Barbarian, the R for Ranger, and the W for wizard, right?' asks the woman.
            L002A: ShowMessage(player, String14BE); // 'Uh, er, but I thought it was M for Mage, like in the Music Room,' says the man.
            L0037: ShowMessage(player, String150F); // 'Wizards built this whole place, so naturally they gave themselves two acronyms!  Now do you understand?' asks the woman.
            L0044: ShowMessage(player, String1589); // 'Almost.  Duh, uh, what's an acronym?'
            L0051: ShowMessage(player, String15B0); // You leave them arguing.  Barbarians are not noted for the breadth of their vocabularies.
            L005E: return; // RETURN;
        }

        private void Fn_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x04);
0C4C  0007 C4 5E 06  les bx, [bp+0x6]
0C4F  000A 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L000F: cx = PopStack(player);
            L0010: RefreshCompareFlags(ax);
            L0012: if (JumpNotEqual) goto L0056;
            L0014: Compare(GetFlag(player, 0x02, 0x51), 0x0001);
            L0028: if (JumpEqual) goto L0056;
            L002A: Compare(GetFlag(player, 0x02, 0x01), 0x0001);
            L003E: if (JumpEqual) goto L0056;
            L0040: Compare(GetFlag(player, 0x02, 0x06), 0x0001);
            L0054: if (JumpNotEqual) goto L00B9;
            L0056: RefreshCompareFlags(GetFlag(player, 0x03, 0x19));
            L0069: if (JumpNotEqual) goto L00B9;
            L006B: SetFlag(player, 0x03, 0x19, 0x01);
            L0080: ShowMessage(player, String0911); // *
            L008D: ShowMessage(player, String0911); // *
            L009A: ShowMessage(player, String0911); // *
            L00A7: ShowMessage(player, String1609); // Angelic singing fills the room.  Seraphim and cherubim greet you with the sound of heaven's host.  The samite colored door opens wide.
0CF9  00B4 B8 90 16  mov ax, 0x1690
            L00B7: goto L00F8;
            L00B9: RefreshCompareFlags(GetFlag(player, 0x03, 0x19));
            L00CC: if (JumpNotEqual) goto L0102;
            L00CE: ShowMessage(player, String0911); // *
            L00DB: ShowMessage(player, String0911); // *
            L00E8: ShowMessage(player, String0911); // *
            L00F5: ShowMessage(player, String16C6); // A voice created by decades of simmering in bad cigars greets you gruffly.  'Talking lions out of lamb chops was easier than giving you a hint. Go away!'
            L0102: PushStack(player, 0x04);
0D4B  0106 C4 5E 06  les bx, [bp+0x6]
0D4E  0109 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L010E: cx = PopStack(player);
            L010F: RefreshCompareFlags(ax);
            L0111: if (JumpNotEqual) goto L0155;
            L0113: Compare(GetFlag(player, 0x02, 0x51), 0x0001);
            L0127: if (JumpEqual) goto L0155;
            L0129: Compare(GetFlag(player, 0x02, 0x01), 0x0001);
            L013D: if (JumpEqual) goto L0155;
            L013F: Compare(GetFlag(player, 0x02, 0x06), 0x0001);
            L0153: if (JumpNotEqual) goto L0165;
            L0155: PushStack(player, 0x00);
            L0158: PushStack(player, 0x4F);
            L015C: PushStack(player, 0x01);
0DA5  0160 B8 03 00  mov ax, 0x3
            L0163: goto L0171;
            L0165: PushStack(player, 0x02);
            L0169: PushStack(player, 0x42);
            L016D: PushStack(player, 0x01);
            L0171: PushStack(player, ax);
0DB7  0172 C4 5E 06  les bx, [bp+0x6]
0DBA  0175 26 FF 9F BC 00  call far word [es:bx+0xbc]
0DBF  017A 83 C4 08  add sp, 0x8
            L017D: return; // RETURN;
        }

        private void Fn_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x05);
0DCB  0007 C4 5E 06  les bx, [bp+0x6]
0DCE  000A 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L000F: cx = PopStack(player);
            L0010: RefreshCompareFlags(ax);
            L0012: if (JumpNotEqual) goto L0056;
            L0014: Compare(GetFlag(player, 0x02, 0x06), 0x0001);
            L0028: if (JumpEqual) goto L0056;
            L002A: Compare(GetFlag(player, 0x02, 0x05), 0x0001);
            L003E: if (JumpEqual) goto L0056;
            L0040: Compare(GetFlag(player, 0x02, 0x4F), 0x0001);
            L0054: if (JumpNotEqual) goto L00B6;
            L0056: RefreshCompareFlags(GetFlag(player, 0x03, 0x1D));
            L0069: if (JumpNotEqual) goto L00B6;
            L006B: SetFlag(player, 0x03, 0x1D, 0x01);
            L0080: ShowMessage(player, String0911); // *
            L008D: ShowMessage(player, String0911); // *
            L009A: ShowMessage(player, String0911); // *
            L00A7: ShowMessage(player, String175F); // The door opens itself before one schooled in the magical arts.  The Thaumaturgium awaits you!
            L00B4: goto L0125;
            L00B6: RefreshCompareFlags(GetFlag(player, 0x03, 0x1D));
            L00C9: if (JumpNotEqual) goto L0125;
            L00CB: ShowMessage(player, String0911); // *
            L00D8: ShowMessage(player, String0911); // *
            L00E5: ShowMessage(player, String0911); // *
            L00F2: ShowMessage(player, String17BD); // Everything you try, every skill, every spell, every item, plea, and curse, avails you nought. 
            L00FF: ShowMessage(player, String181C); // Only a wizard and that wizard's party can pass.
            L010C: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x00);
            L0125: PushStack(player, 0x05);
0EED  0129 C4 5E 06  les bx, [bp+0x6]
0EF0  012C 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L0131: cx = PopStack(player);
            L0132: RefreshCompareFlags(ax);
            L0134: if (JumpNotEqual) goto L0178;
            L0136: Compare(GetFlag(player, 0x02, 0x06), 0x0001);
            L014A: if (JumpEqual) goto L0178;
            L014C: Compare(GetFlag(player, 0x02, 0x05), 0x0001);
            L0160: if (JumpEqual) goto L0178;
            L0162: Compare(GetFlag(player, 0x02, 0x4F), 0x0001);
            L0176: if (JumpNotEqual) goto L0192;
            L0178: PushStack(player, 0x03);
            L017C: PushStack(player, 0xF7);
            L0180: PushStack(player, 0x02);
            L0184: PushStack(player, ax);
0F49  0185 C4 5E 06  les bx, [bp+0x6]
0F4C  0188 26 FF 9F BC 00  call far word [es:bx+0xbc]
0F51  018D 83 C4 08  add sp, 0x8
            L0190: goto L01AB;
            L0192: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x00);
            L01AB: return; // RETURN;
        }

        private void Fn_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x00);
0F77  0006 C4 5E 06  les bx, [bp+0x6]
0F7A  0009 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L000E: cx = PopStack(player);
            L000F: RefreshCompareFlags(ax);
            L0011: if (JumpNotEqual) goto L0054;
            L0013: Compare(GetFlag(player, 0x02, 0x00), 0x0001);
            L0026: if (JumpEqual) goto L0054;
            L0028: Compare(GetFlag(player, 0x02, 0x06), 0x0001);
            L003C: if (JumpEqual) goto L0054;
            L003E: Compare(GetFlag(player, 0x02, 0x52), 0x0001);
            L0052: if (JumpNotEqual) goto L00C7;
            L0054: RefreshCompareFlags(GetFlag(player, 0x03, 0x18));
            L0067: if (JumpNotEqual) goto L00C7;
            L0069: SetFlag(player, 0x03, 0x18, 0x01);
            L007E: ShowMessage(player, String184C); // You hear the distinct sound of sniffing just before the door opens.  You don't know whether to be pleased or disappointed.
            L008B: Compare(GetFlag(player, 0x02, 0x5B), 0x0001);
            L009F: if (JumpEqual) goto L00A4;
            L00A1: goto L0133;
            L00A4: SetFlag(player, 0x02, 0x5B, 0x00);
            L00B8: ShowMessage(player, String18C7); // In fact, it sniffs for such a long time that you worry whether your recent bath in the stables has washed away too much dirt, but fear not!  Your natural odor, and the passage of time, compensated fully.
            L00C5: goto L0133;
            L00C7: RefreshCompareFlags(GetFlag(player, 0x03, 0x18));
            L00DA: if (JumpNotEqual) goto L0133;
            L00DC: ShowPortrait(player, 0x0016);
            L00E9: ShowMessage(player, String0911); // *
            L00F6: ShowMessage(player, String0911); // *
            L0103: ShowMessage(player, String0911); // *
            L0110: ShowMessage(player, String1993); // 'This door will open for neither cents nor sense, unless it senses the scents of a barbarian,' he says.
            L011D: SetWallPassable(player, GetCurrentTile(player), ax, 0x00);
            L0133: PushStack(player, 0x00);
10A7  0136 C4 5E 06  les bx, [bp+0x6]
10AA  0139 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L013E: cx = PopStack(player);
            L013F: RefreshCompareFlags(ax);
            L0141: if (JumpNotEqual) goto L0184;
            L0143: Compare(GetFlag(player, 0x02, 0x00), 0x0001);
            L0156: if (JumpEqual) goto L0184;
            L0158: Compare(GetFlag(player, 0x02, 0x06), 0x0001);
            L016C: if (JumpEqual) goto L0184;
            L016E: Compare(GetFlag(player, 0x02, 0x52), 0x0001);
            L0182: if (JumpNotEqual) goto L01A0;
            L0184: TeleportParty(player, 0x03, 0x02, 0x9F, 0x00, isForwardMove);
            L019E: goto L01B6;
            L01A0: SetWallPassable(player, GetCurrentTile(player), ax, 0x00);
            L01B6: return; // RETURN;
        }

        private void Fn_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
1130  0007 C4 5E 06  les bx, [bp+0x6]
1133  000A 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L000F: cx = PopStack(player);
            L0010: RefreshCompareFlags(ax);
            L0012: if (JumpNotEqual) goto L0053;
            L0014: Compare(GetFlag(player, 0x02, 0x50), 0x0001);
            L0028: if (JumpEqual) goto L0053;
            L002A: PushStack(player, 0x02);
            L002E: PushStack(player, ax);
1158  002F C4 5E 06  les bx, [bp+0x6]
115B  0032 26 FF 5F 04  call far word [es:bx+0x4]
            L0036: cx = PopStack(player);
            L0037: cx = PopStack(player);
            L0038: Compare(ax, 0x0001);
            L003B: if (JumpEqual) goto L0053;
            L003D: Compare(GetFlag(player, 0x02, 0x06), 0x0001);
            L0051: if (JumpNotEqual) goto L00BF;
            L0053: Compare(GetFacing(player), 0x0003);
            L005D: if (JumpNotEqual) goto L00BF;
            L005F: RefreshCompareFlags(GetFlag(player, 0x03, 0x1A));
            L0072: if (JumpNotEqual) goto L00BF;
            L0074: SetFlag(player, 0x03, 0x1A, 0x01);
            L0089: ShowMessage(player, String0911); // *
            L0096: ShowMessage(player, String0911); // *
            L00A3: ShowMessage(player, String0911); // *
            L00B0: ShowMessage(player, String19FB); // A bright light shines down upon you, and bathed in its beneficence, the door opens.
            L00BD: goto L0121;
            L00BF: RefreshCompareFlags(GetFlag(player, 0x03, 0x1A));
            L00D2: if (JumpNotEqual) goto L0121;
            L00D4: ShowMessage(player, String0911); // *
            L00E1: ShowMessage(player, String0911); // *
            L00EE: ShowMessage(player, String0911); // *
            L00FB: ShowMessage(player, String1A4F); // An indirect light grows steadily brighter and the door creaks, but as if failing to find what it seeks, it stills.  You cannot enter.
            L0108: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x00);
            L0121: PushStack(player, 0x01);
124E  0125 C4 5E 06  les bx, [bp+0x6]
1251  0128 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L012D: cx = PopStack(player);
            L012E: RefreshCompareFlags(ax);
            L0130: if (JumpNotEqual) goto L0171;
            L0132: Compare(GetFlag(player, 0x02, 0x50), 0x0001);
            L0146: if (JumpEqual) goto L0171;
            L0148: PushStack(player, 0x02);
            L014C: PushStack(player, ax);
1276  014D C4 5E 06  les bx, [bp+0x6]
1279  0150 26 FF 5F 04  call far word [es:bx+0x4]
            L0154: cx = PopStack(player);
            L0155: cx = PopStack(player);
            L0156: Compare(ax, 0x0001);
            L0159: if (JumpEqual) goto L0171;
            L015B: Compare(GetFlag(player, 0x02, 0x06), 0x0001);
            L016F: if (JumpNotEqual) goto L018E;
            L0171: TeleportParty(player, 0x02, 0x03, 0xF3, 0x03, isForwardMove);
            L018C: goto L01A7;
            L018E: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x00);
            L01A7: return; // RETURN;
        }

        private void Fn_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x02);
12D9  0007 C4 5E 06  les bx, [bp+0x6]
12DC  000A 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L000F: cx = PopStack(player);
            L0010: RefreshCompareFlags(ax);
            L0012: if (JumpNotEqual) goto L0056;
            L0014: Compare(GetFlag(player, 0x02, 0x03), 0x0001);
            L0028: if (JumpEqual) goto L0056;
            L002A: Compare(GetFlag(player, 0x02, 0x06), 0x0001);
            L003E: if (JumpEqual) goto L0056;
            L0040: Compare(GetFlag(player, 0x02, 0x4E), 0x0001);
            L0054: if (JumpNotEqual) goto L00B6;
            L0056: RefreshCompareFlags(GetFlag(player, 0x03, 0x1B));
            L0069: if (JumpNotEqual) goto L00B6;
            L006B: SetFlag(player, 0x03, 0x1B, 0x01);
            L0080: ShowMessage(player, String0911); // *
            L008D: ShowMessage(player, String0911); // *
            L009A: ShowMessage(player, String0911); // *
            L00A7: ShowMessage(player, String1AD5); // The magical wood of this door responds to your presence by swinging open before you.
            L00B4: goto L0118;
            L00B6: RefreshCompareFlags(GetFlag(player, 0x03, 0x1B));
            L00C9: if (JumpNotEqual) goto L0118;
            L00CB: ShowMessage(player, String0911); // *
            L00D8: ShowMessage(player, String0911); // *
            L00E5: ShowMessage(player, String0911); // *
            L00F2: ShowMessage(player, String1B2A); // After three bruised knuckles, one barked shin, and two stubbed toes, you decide there is no way in unless you find a ranger.
            L00FF: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x00);
            L0118: PushStack(player, 0x02);
13EE  011C C4 5E 06  les bx, [bp+0x6]
13F1  011F 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L0124: cx = PopStack(player);
            L0125: RefreshCompareFlags(ax);
            L0127: if (JumpNotEqual) goto L016B;
            L0129: Compare(GetFlag(player, 0x02, 0x03), 0x0001);
            L013D: if (JumpEqual) goto L016B;
            L013F: Compare(GetFlag(player, 0x02, 0x06), 0x0001);
            L0153: if (JumpEqual) goto L016B;
            L0155: Compare(GetFlag(player, 0x02, 0x4E), 0x0001);
            L0169: if (JumpNotEqual) goto L0188;
            L016B: TeleportParty(player, 0x02, 0x01, 0xFC, 0x03, isForwardMove);
            L0186: goto L01E5;
            L0188: RefreshCompareFlags(GetFlag(player, 0x03, 0x1B));
            L019B: if (JumpNotEqual) goto L01E5;
            L019D: SetFlag(player, 0x03, 0x1B, 0x01);
            L01B2: SetWallPassable(player, GetCurrentTile(player), 0x03, 0x00);
            L01CB: DamagePlayer(player, 0x0001);
            L01D8: ShowMessage(player, String1BA7); // Keep that up and in addition to being dead as a door knob you'll be dead from a door, Nob!
            L01E5: return; // RETURN;
        }

        private void Fn_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
14C0  0007 C4 5E 06  les bx, [bp+0x6]
14C3  000A 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L000F: cx = PopStack(player);
            L0010: RefreshCompareFlags(ax);
            L0012: if (JumpNotEqual) goto L0056;
            L0014: Compare(GetFlag(player, 0x02, 0x06), 0x0001);
            L0028: if (JumpEqual) goto L0056;
            L002A: Compare(GetFlag(player, 0x02, 0x04), 0x0001);
            L003E: if (JumpEqual) goto L0056;
            L0040: Compare(GetFlag(player, 0x02, 0x4D), 0x0001);
            L0054: if (JumpNotEqual) goto L00B7;
            L0056: RefreshCompareFlags(GetFlag(player, 0x03, 0x1C));
            L0069: if (JumpNotEqual) goto L00B7;
            L006B: SetFlag(player, 0x03, 0x1C, 0x01);
            L0080: ShowMessage(player, String0911); // *
            L008D: ShowMessage(player, String0911); // *
            L009A: ShowMessage(player, String0911); // *
            L00A7: ShowMessage(player, String1C02); // Someone in your party gives the secret thievish countersign.  The door swings open.
            L00B4: goto L0133;
            L00B6: // NOP
            L00B7: RefreshCompareFlags(GetFlag(player, 0x03, 0x1C));
            L00CA: if (JumpNotEqual) goto L0133;
            L00CC: ShowMessage(player, String0911); // *
            L00D9: ShowMessage(player, String0911); // *
            L00E6: ShowMessage(player, String0911); // *
            L00F3: ShowMessage(player, String1C56); // You hear a sound....
            L0100: ShowMessage(player, String1C6B); // 6,198 thieves, wielding nastily stained weapons, and most with a nimbus of magical defenses already cast, step forward to block your path.
            L010D: ShowMessage(player, String1CF6); // 'Hmmm,' you think to yourself. 'That doorway's awfully crowded right now. Maybe I'll go find a thief and come back later.'
            L011A: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x00);
            L0133: PushStack(player, 0x03);
15F0  0137 C4 5E 06  les bx, [bp+0x6]
15F3  013A 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L013F: cx = PopStack(player);
            L0140: RefreshCompareFlags(ax);
            L0142: if (JumpNotEqual) goto L0186;
            L0144: Compare(GetFlag(player, 0x02, 0x06), 0x0001);
            L0158: if (JumpEqual) goto L0186;
            L015A: Compare(GetFlag(player, 0x02, 0x04), 0x0001);
            L016E: if (JumpEqual) goto L0186;
            L0170: Compare(GetFlag(player, 0x02, 0x4D), 0x0001);
            L0184: if (JumpNotEqual) goto L01A3;
            L0186: TeleportParty(player, 0x01, 0x03, 0x30, 0x02, isForwardMove);
            L01A1: goto L01BC;
            L01A3: SetWallPassable(player, GetCurrentTile(player), 0x02, 0x00);
            L01BC: return; // RETURN;
        }

        private void Fn_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0B));
            L0016: if (JumpNotEqual) goto L0074;
            L0018: SetFlag(player, 0x03, 0x0B, 0x01);
            L002D: PushStack(player, 0x00);
            L0030: PushStack(player, ax);
            L0031: PushStack(player, ax);
            L0032: PushStack(player, ax);
            L0033: PushStack(player, ax);
            L0034: PushStack(player, 0x19);
16AF  0038 C4 5E 06  les bx, [bp+0x6]
16B2  003B 26 FF 9F D8 00  call far word [es:bx+0xd8]
16B7  0040 83 C4 0C  add sp, 0xc
            L0043: AddEncounter(player, 0x01, 0x24);
            L0055: Compare(PartyCount(player), 0x0001);
            L0060: if (JumpBelowOrEqual) goto L0074;
            L0062: AddEncounter(player, 0x02, 0x27);
            L0074: return; // RETURN;
        }

        private void Fn_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0C));
            L0016: if (JumpNotEqual) goto L0067;
            L0018: SetFlag(player, 0x03, 0x0C, 0x01);
            L002D: PushStack(player, 0x00);
            L0030: PushStack(player, ax);
            L0031: PushStack(player, ax);
            L0032: PushStack(player, ax);
            L0033: PushStack(player, ax);
            L0034: PushStack(player, 0xB8);
1725  0038 C4 5E 06  les bx, [bp+0x6]
1728  003B 26 FF 9F D8 00  call far word [es:bx+0xd8]
172D  0040 83 C4 0C  add sp, 0xc
            L0043: AddEncounter(player, 0x01, 0x24);
            L0055: AddEncounter(player, 0x02, 0x28);
            L0067: return; // RETURN;
        }

        private void Fn_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0D));
            L0016: if (JumpNotEqual) goto L005E;
            L0018: SetFlag(player, 0x03, 0x0D, 0x01);
            L002D: AddEncounter(player, 0x01, 0x19);
            L003F: Compare(PartyCount(player), 0x0001);
            L004A: if (JumpBelowOrEqual) goto L005E;
            L004C: AddEncounter(player, 0x02, 0x22);
            L005E: return; // RETURN;
        }

        private void Fn_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0E));
            L0016: if (JumpNotEqual) goto L0074;
            L0018: SetFlag(player, 0x03, 0x0E, 0x01);
            L002D: PushStack(player, 0x00);
            L0030: PushStack(player, ax);
            L0031: PushStack(player, ax);
            L0032: PushStack(player, ax);
            L0033: PushStack(player, ax);
            L0034: PushStack(player, 0x46);
17EE  0038 C4 5E 06  les bx, [bp+0x6]
17F1  003B 26 FF 9F D8 00  call far word [es:bx+0xd8]
17F6  0040 83 C4 0C  add sp, 0xc
            L0043: AddEncounter(player, 0x01, 0x25);
            L0055: Compare(PartyCount(player), 0x0001);
            L0060: if (JumpBelowOrEqual) goto L0074;
            L0062: AddEncounter(player, 0x02, 0x28);
            L0074: return; // RETURN;
        }

        private void Fn_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L0016: if (JumpNotEqual) goto L007D;
            L0018: SetFlag(player, 0x03, 0x0F, 0x01);
            L002D: PushStack(player, 0x00);
            L0030: PushStack(player, ax);
            L0031: PushStack(player, ax);
            L0032: PushStack(player, ax);
            L0033: PushStack(player, ax);
            L0034: PushStack(player, 0xB8);
1864  0038 C4 5E 06  les bx, [bp+0x6]
1867  003B 26 FF 9F D8 00  call far word [es:bx+0xd8]
186C  0040 83 C4 0C  add sp, 0xc
            L0043: PushStack(player, 0x01);
            L0047: PushStack(player, ax);
1874  0048 C4 5E 06  les bx, [bp+0x6]
1877  004B 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0050: cx = PopStack(player);
            L0051: cx = PopStack(player);
            L0052: Compare(PartyCount(player), 0x0002);
            L005D: if (JumpBelowOrEqual) goto L007D;
            L005F: PushStack(player, 0x02);
            L0063: PushStack(player, ax);
1890  0064 C4 5E 06  les bx, [bp+0x6]
1893  0067 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L006C: cx = PopStack(player);
            L006D: cx = PopStack(player);
            L006E: PushStack(player, 0x03);
            L0072: PushStack(player, ax);
189F  0073 C4 5E 06  les bx, [bp+0x6]
18A2  0076 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L007B: cx = PopStack(player);
            L007C: cx = PopStack(player);
            L007D: return; // RETURN;
        }

        private void Fn_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x10));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00B0;
            L001B: SetFlag(player, 0x03, 0x10, 0x01);
            L0030: PushStack(player, 0x00);
            L0033: PushStack(player, ax);
            L0034: PushStack(player, ax);
            L0035: PushStack(player, ax);
            L0036: PushStack(player, 0x39);
            L003A: PushStack(player, 0xB8);
18E9  003E C4 5E 06  les bx, [bp+0x6]
18EC  0041 26 FF 9F D8 00  call far word [es:bx+0xd8]
18F1  0046 83 C4 0C  add sp, 0xc
            L0049: AddEncounter(player, 0x01, 0x1D);
            L005B: AddEncounter(player, 0x02, 0x1F);
            L006D: Compare(PartyCount(player), 0x0002);
            L0078: if (JumpBelowOrEqual) goto L00B0;
            L007A: AddEncounter(player, 0x05, 0x21);
            L008C: AddEncounter(player, 0x04, 0x28);
            L009E: AddEncounter(player, 0x03, 0x24);
            L00B0: return; // RETURN;
        }

        private void Fn_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x11));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00A1;
            L001B: SetFlag(player, 0x03, 0x11, 0x01);
            L0030: PushStack(player, 0x00);
            L0033: PushStack(player, ax);
            L0034: PushStack(player, ax);
            L0035: PushStack(player, 0x39);
            L0039: PushStack(player, 0x46);
            L003D: PushStack(player, 0xB8);
199E  0041 C4 5E 06  les bx, [bp+0x6]
19A1  0044 26 FF 9F D8 00  call far word [es:bx+0xd8]
19A6  0049 83 C4 0C  add sp, 0xc
            L004C: AddEncounter(player, 0x01, 0x24);
            L005E: AddEncounter(player, 0x02, 0x24);
            L0070: Compare(PartyCount(player), 0x0002);
            L007B: if (JumpBelowOrEqual) goto L00A1;
            L007D: AddEncounter(player, 0x03, 0x28);
            L008F: AddEncounter(player, 0x04, 0x28);
            L00A1: return; // RETURN;
        }

        private void Fn_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x12));
            L0016: if (JumpNotEqual) goto L0067;
            L0018: SetFlag(player, 0x03, 0x12, 0x01);
            L002D: PushStack(player, 0x01);
            L0031: PushStack(player, ax);
1A32  0032 C4 5E 06  les bx, [bp+0x6]
1A35  0035 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L003A: cx = PopStack(player);
            L003B: cx = PopStack(player);
            L003C: Compare(PartyCount(player), 0x0002);
            L0047: if (JumpBelowOrEqual) goto L0067;
            L0049: PushStack(player, 0x02);
            L004D: PushStack(player, ax);
1A4E  004E C4 5E 06  les bx, [bp+0x6]
1A51  0051 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0056: cx = PopStack(player);
            L0057: cx = PopStack(player);
            L0058: PushStack(player, 0x03);
            L005C: PushStack(player, ax);
1A5D  005D C4 5E 06  les bx, [bp+0x6]
1A60  0060 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0065: cx = PopStack(player);
            L0066: cx = PopStack(player);
            L0067: return; // RETURN;
        }

        private void Fn_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x13));
            L0016: if (JumpNotEqual) goto L007F;
            L0018: SetFlag(player, 0x03, 0x13, 0x01);
            L002D: PushStack(player, 0x01);
            L0031: PushStack(player, ax);
1A9B  0032 C4 5E 06  les bx, [bp+0x6]
1A9E  0035 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L003A: cx = PopStack(player);
            L003B: cx = PopStack(player);
            L003C: AddEncounter(player, 0x02, 0x04);
            L004E: Compare(PartyCount(player), 0x0002);
            L0059: if (JumpBelowOrEqual) goto L007F;
            L005B: AddEncounter(player, 0x03, 0x02);
            L006D: AddEncounter(player, 0x04, 0x03);
            L007F: return; // RETURN;
        }

        private void Fn_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x06));
            L0016: if (JumpNotEqual) goto L0042;
            L0018: SetWallPassable(player, 0xFB, 0x01, 0x00);
            L002D: SetWallObject(player, 0x00, 0xFB, 0x01);
            L0042: return; // RETURN;
        }

    }
}
