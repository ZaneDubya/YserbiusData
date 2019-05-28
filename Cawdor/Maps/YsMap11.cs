#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap11 : AMapScripted {
        protected override int MapIndex => 11;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap11() {
            MapEvent02 = Fn_02;
            MapEvent05 = Fn_05;
            MapEvent06 = Fn_06;
            MapEvent07 = Fn_07;
            MapEvent08 = Fn_08;
            MapEvent09 = Fn_09;
            MapEvent0A = Fn_0A;
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
            MapEvent19 = Fn_19;
            MapEvent1A = Fn_1A;
            MapEvent1B = Fn_1B;
            MapEvent1C = Fn_1C;
            MapEvent1D = Fn_1D;
            MapEvent1E = Fn_1E;
            MapEvent1F = Fn_1F;
        }
        
        // === Strings ================================================
        private const string String0140 = "You have unlocked the hidden door!";
        private const string String0163 = "You detect a hidden door, but it is locked.";
        private const string String018F = "This way to the Brewery.  And all you teamsters should remember: if you must drive, don't drink.  If you must drink, don't drive.";
        private const string String0211 = "Of course, in cyberspace there are no accidents.  Only fiendish designs.  And typos.";
        private const string String0266 = "I guess you're gonna find out who slew the sorceror.";
        private const string String029B = "Or, more likely, what.";
        private const string String02B2 = "This looks ugly.  At least the survivors will be more experienced.";
        private const string String02F5 = "*";
        private const string String02F7 = "'Hush!  I have little time; our enemies track me as I speak.";
        private const string String0334 = "The undying now own this room, and a vampiric king holds a great prize, even thou he himself is but a servant to the Macbeths.  He has protected himself with a maze of death.  An thou canst cast enough dissipate spells, thou mayst win clear to - to....'";
        private const string String0432 = "With a groan, the wizard slumps over, dead.";
        private const string String045E = "You see a huge pile of skeleton bones.  You shiver as you realize that not only are several skeletons advancing towards you, but that the remaining bones are reforming into more skeletons.  This is not a good place to be.";
        private const string String053C = "'Tis yet another pile of regenerating skeletons.";
        private const string String056D = "This doorway leads to the Pantry.";
        private const string String058F = "You see a huge pile of skeleton bones.  Your blood runs cold as you realize that not only are many large and ominous skeletons advancing towards you, but that the remaining bones are reforming into more skeletons.  This is not a good place to be.";
        private const string String0686 = "'Tis yet another huge pile of regenerating skeletons.";
        private const string String06BC = "Who needs napalm when you have fireballs?  Ouch!";
        private const string String06ED = "Bad ghouls bad ghouls.  Whatcha gonna do?";
        private const string String0717 = "You're just grateful that that fireball ambush didn't barbecue the Tongue of Dog.  In fact, you're grateful it didn't barbecue you, either!";
        private const string String07A3 = "You really feel hounded.  Perhaps you are cursed.";
        private const string String07D5 = "The good news is that these aren't the dogs of war.  The bad news is they are the dogs of unpleasant arguments.";
        private const string String0845 = "Backed by a pack of dogs of disagreements.";
        private const string String0870 = "The battle you fought here left you dog-tired.";
        private const string String089F = "Yuk!  Somebody should clean out the drains once in a while!";
        private const string String08DB = "It took you hours to get all the slime out of your hair after the battle you had here.";
        private const string String0932 = "You've found a hive of harpies, assuming harpies hang in hives.";
        private const string String0972 = "This many harpies is giving you a bad case of hives.";
        private const string String09A7 = "You examine the battleground.  Amidst all the feathers and flesh of the fiends you fought is a small piece of white paper with the name 'A. Hitchcock' printed on it, and written on the back the words 'Call me.'";
        private const string String0A7A = "'Call me what?' you wonder.";
        private const string String0A96 = "All the remains of your battle here are some fractured feathers and a broken beak.";
        private const string String0AE9 = "A party has been arranged on your behalf.";
        private const string String0B13 = "Unfortunately, it appears to be a hanging party arranged by those arrayed rangers.  En garde!";
        private const string String0B71 = "You remember the rangers here.  You just picked them up and squeezed them and loved them, and now they don't move no more.";
        private const string String0BEC = "Good thing for you, too";
        private const string String0C04 = "It must be Balkan Night in Cawdor.  You see minotaurs and medusae arrayed against you.";
        private const string String0C5B = "In fact, you're balkin' at the thought of fighting these guys!";
        private const string String0C9A = "Sometimes the good guys win.  Or at least run away.";
        private const string String0CCE = "Yup.  That's an incoming fireball.  You recognise it from the pain.";
        private const string String0D12 = "And these must be the ghouls Mom warned you about.";
        private const string String0D45 = "Your bones still ache from the battle you fought here.  But you think the Tongue of Dog you won will more than make up for your aches, heh heh.";
        private const string String0DD5 = "You hear some footsteps running away.";
        private const string String0DFB = "You see a ghoul dragging a corpse.  It decides it likes dead meat better than live, and runs off.";
        private const string String0E5D = "You find the body of the panicked elf cleric, drained of its blood.  There was reason to panic after all.";
        private const string String0EC7 = "You hear someone running towards you.";
        private const string String0EED = "'By all the saints, thou must know this! We fought the vampires here, and one of us, wielding Malcolm's Chopper, harmed it, but not as much as the Hunting Bow or Oswald's Bane.  My comrades there lie dead.  I dare no longer stay.'";
        private const string String0FD4 = "The cleric departs, rapidly.";
        private const string String0FF1 = "The dragon examines you with a baleful eye.  It has seen better days.";
        private const string String1037 = "'Thou art living, and I am desperate.  I must have a petunia poultice.  I will pay well for one.'";
        private const string String1099 = "'I thank thee, and give thee enough to buy ten more to replace that which I have taken.  Fare thee well!'";
        private const string String1103 = "'Thou hast none?  I can see the truth in thee.  An thou dost find one, thou wilt be well rewarded to find me with it.  Fare thee well.'";
        private const string String118B = "It was here that Rory taught you about the Gaelic Garlic's power against undead.  You know not whether the tear in your eye is from the memory or from a faint residue of the pungent bud.";
        private const string String1246 = "The thief looks somewhat bruised.";
        private const string String1268 = "'Ah! 'Tis my friends, not more of these thrice bedamned undead.  I must say, My Lady's Favor is well and good, as is the Thief's Tabard and the Gaelic Garlic, but none match the power of the Holy Relic against them.  Would that I had one!  May fortune favor thee.'";
        private const string String1371 = "The halfling limps off, smiling grimly.";
        private const string String1399 = "A slew o'Slyfeet decide, rather insultingly, that they are bigger than you are.";
        private const string String13E9 = "'I have been waiting for thee.  Pay close heed!'";
        private const string String141A = "'The Vampiric Servant who rules this level can most oft be found upon his throne nigh unto the very center of this room.";
        private const string String1493 = "An thou defeats him, then thou shalt earn thereby a Tongue of Dog.  This puissant part has but one charge: use it wisely!'";
        private const string String150E = "'I did observe thee defeat the Vampire who, until today, held sway here.  The item thou should prize above all others from him is the Tongue of Dog.";
        private const string String15A3 = "Use it wisely; that item doth possess but one charge.  One very potent charge.'";
        private const string String15F3 = "This large, well appointed room features many fine marble columns.  Towards the center of the room you think you can see a throne.";
        private const string String1676 = "A small piece of paper on the ground catches your eye.  As you look more closely, its letters flame up, reading: 'Spiral-G.'  The card soon burns to ash.";
        private const string String1710 = "The throne room remains as you last saw it: a dangerous place for the quick and the dead.";
        private const string String176A = "You recognise the minotaurs and medusae from your studies in recent history.  You just hope that you aren't about to join them as yet another statistic.";
        private const string String1803 = "Sometimes the good guys win.  This was one of them. Or at least close enough for jazz.";
        private const string String185A = "My gosh!  It's one of your childhood heroes: The Lonely Ranger!";
        private const string String189A = "Unfortunately, you don't seem to be one of his heroes.  And in that crowd, who has time to be lonely?";
        private const string String1900 = "All that remains of your battle here is a broken old decoder ring.";
        private const string String1943 = "This entrance to The Lesser Hall is guarded!";
        private const string String1970 = "Hmmm.  Cigarette butts, candy wrappers, loaded dice: there might not be any guards here now, but there used to be.";
        private const string String19E3 = "And not very tidy guards, either!";
        
        // === Functions ================================================
        private void Fn_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x0004);
            L0012: if (JumpNotBelow) goto L0071;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L0071;
            L0024: PushStack(player, 0xA7);
            L0028: PushStack(player, ax);
0033  0029 C4 5E 06  les bx, [bp+0x6]
0036  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L0071;
            L0036: PushStack(player, 0x93);
            L003A: PushStack(player, ax);
0045  003B C4 5E 06  les bx, [bp+0x6]
0048  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L0071;
            L0048: PushStack(player, 0x86);
            L004C: PushStack(player, ax);
0057  004D C4 5E 06  les bx, [bp+0x6]
005A  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L0071;
            L005A: ax = IsFlagOn(player, 0x00, 0x01);
            L006C: if (JumpNotEqual) goto L0071;
            L006E: goto L01CF;
            L0071: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L008F: PushStack(player, 0x01);
            L0093: PushStack(player, ax);
            L0094: PushStack(player, 0x00);
00A1  0097 C4 5E 06  les bx, [bp+0x6]
00A4  009A 26 FF 1F  call far word [es:bx]
00A7  009D 83 C4 06  add sp, 0x6
            L00A0: PushStack(player, 0x68);
            L00A4: PushStack(player, ax);
00AF  00A5 C4 5E 06  les bx, [bp+0x6]
00B2  00A8 26 FF 5F 54  call far word [es:bx+0x54]
            L00AC: cx = PopStack(player);
            L00AD: cx = PopStack(player);
            L00AE: RefreshCompareFlags(ax);
            L00B0: if (JumpEqual) goto L012B;
            L00B2: ax = HasItem(player, 0xC1);
            L00C0: if (JumpEqual) goto L00C5;
            L00C2: goto L0178;
            L00C5: ax = HasItem(player, 0xC2);
            L00D3: if (JumpEqual) goto L00D8;
            L00D5: goto L0178;
            L00D8: ax = HasItem(player, 0xC3);
            L00E6: if (JumpEqual) goto L00EB;
            L00E8: goto L0178;
            L00EB: ax = HasItem(player, 0xDA);
            L00F9: if (JumpNotEqual) goto L0178;
            L00FB: ax = HasItem(player, 0xDB);
            L0109: if (JumpNotEqual) goto L0178;
            L010B: ax = HasItem(player, 0xDC);
            L0119: if (JumpNotEqual) goto L0178;
            L011B: ax = HasItem(player, 0xDD);
            L0129: if (JumpNotEqual) goto L0178;
            L012B: Compare(GetSkillLevel(player, 0x0E), 0x0006);
            L013A: if (JumpBelow) goto L0166;
            L013C: ax = HasUsedItem(player, 0xC1, 0xC3);
            L014F: if (JumpNotEqual) goto L0178;
            L0151: ax = HasUsedItem(player, 0xDA, 0xDD);
            L0164: if (JumpNotEqual) goto L0178;
            L0166: PushStack(player, 0xC0);
            L016A: PushStack(player, ax);
0175  016B C4 5E 06  les bx, [bp+0x6]
0178  016E 26 FF 5F 54  call far word [es:bx+0x54]
            L0172: cx = PopStack(player);
            L0173: cx = PopStack(player);
            L0174: RefreshCompareFlags(ax);
            L0176: if (JumpEqual) goto L01C0;
            L0178: ShowMessage(player, String0140); // You have unlocked the hidden door!
            L0185: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L01A3: PushStack(player, GetFacing(player));
            L01AB: PushStack(player, GetCurrentTile(player));
            L01B3: PushStack(player, 0x01);
01C1  01B7 C4 5E 06  les bx, [bp+0x6]
01C4  01BA 26 FF 5F 30  call far word [es:bx+0x30]
            L01BE: goto L01E9;
            L01C0: ShowMessage(player, String0163); // You detect a hidden door, but it is locked.
            L01CD: goto L01CF;
            L01CF: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L01EC: return; // RETURN;
        }

        private void Fn_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String018F); // This way to the Brewery.  And all you teamsters should remember: if you must drive, don't drink.  If you must drink, don't drive.
            L0010: ShowMessage(player, String0211); // Of course, in cyberspace there are no accidents.  Only fiendish designs.  And typos.
            L001D: TeleportParty(player, 0x04, 0x03, 0x0A, 0x01, isForwardMove);
            L0038: return; // RETURN;
        }

        private void Fn_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
0244  0008 C4 5E 06  les bx, [bp+0x6]
0247  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: Compare(ax, 0x0001);
            L0014: if (JumpNotEqual) goto L0030;
            L0016: ShowMessage(player, String0266); // I guess you're gonna find out who slew the sorceror.
            L0023: ShowMessage(player, String029B); // Or, more likely, what.
            L0030: PushStack(player, 0x03);
            L0034: PushStack(player, ax);
0271  0035 C4 5E 06  les bx, [bp+0x6]
0274  0038 26 FF 5F 04  call far word [es:bx+0x4]
            L003C: cx = PopStack(player);
            L003D: cx = PopStack(player);
            L003E: Compare(ax, 0x0001);
            L0041: if (JumpEqual) goto L005C;
            L0043: Compare(GetFlag(player, 0x03, 0x04), 0x0002);
            L0057: if (JumpBelow) goto L005C;
            L0059: goto L01B2;
            L005C: PushStack(player, 0x02);
            L0060: PushStack(player, 0x03);
            L0064: PushStack(player, ax);
02A1  0065 C4 5E 06  les bx, [bp+0x6]
02A4  0068 26 FF 1F  call far word [es:bx]
02A7  006B 83 C4 06  add sp, 0x6
            L006E: SetFlag(player, 0x03, 0x19, 0x02);
            L0083: ax = GetMaxHits(player);
            L008A: bx = 0x0005;
            L008D: dx = ax % bx; ax = ax / bx;
            L0090: DamagePlayer(player, ax);
            L009A: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L00AE: if (JumpNotEqual) goto L00B5;
02EC  00B0 B8 02 00  mov ax, 0x2
            L00B3: goto L00B8;
            L00B5: SetFlag(player, 0x03, 0x04, 0x01);
            L00CA: Compare(GetFlag(player, 0x03, 0x04), 0x0002);
            L00DE: if (JumpNotEqual) goto L00ED;
            L00E0: ShowMessage(player, String02B2); // This looks ugly.  At least the survivors will be more experienced.
0329  00ED B8 20 01  mov ax, 0x120
            L00F0: PushStack(player, ax);
            L00F1: PushStack(player, 0x00);
            L00F4: PushStack(player, ax);
            L00F5: PushStack(player, 0x49);
            L00F9: PushStack(player, 0x3B);
            L00FD: PushStack(player, 0x07);
033D  0101 C4 5E 06  les bx, [bp+0x6]
0340  0104 26 FF 9F D8 00  call far word [es:bx+0xd8]
0345  0109 83 C4 0C  add sp, 0xc
            L010C: AddEncounter(player, 0x01, 0x1A);
            L011E: AddEncounter(player, 0x02, 0x1B);
            L0130: Compare(GetFlag(player, 0x03, 0x04), 0x0002);
            L0144: if (JumpNotEqual) goto L0181;
            L0146: AddEncounter(player, 0x03, 0x20);
            L0158: AddEncounter(player, 0x04, 0x20);
            L016A: AddEncounter(player, 0x05, 0x1C);
03B8  017C B8 1C 00  mov ax, 0x1c
            L017F: goto L01A3;
            L0181: Compare(PartyCount(player), 0x0002);
            L018C: if (JumpBelowOrEqual) goto L01B2;
            L018E: AddEncounter(player, 0x05, 0x1A);
            L01A0: AddEncounter(player, 0x06, 0x1B);
            L01B2: return; // RETURN;
        }

        private void Fn_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x24));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L009D;
            L001B: SetFlag(player, 0x02, 0x24, 0x01);
            L0030: PushStack(player, 0x01);
            L0034: PushStack(player, 0x03);
            L0038: PushStack(player, ax);
0429  0039 C4 5E 06  les bx, [bp+0x6]
042C  003C 26 FF 1F  call far word [es:bx]
042F  003F 83 C4 06  add sp, 0x6
            L0042: ShowMessage(player, String02F5); // *
            L004F: ShowMessage(player, String02F5); // *
            L005C: ShowMessage(player, String02F5); // *
            L0069: ShowPortrait(player, 0x002E);
            L0076: ShowMessage(player, String02F7); // 'Hush!  I have little time; our enemies track me as I speak.
            L0083: ShowMessage(player, String0334); // The undying now own this room, and a vampiric king holds a great prize, even thou he himself is but a servant to the Macbeths.  He has protected himself with a maze of death.  An thou canst cast enough dissipate spells, thou mayst win clear to - to....'
            L0090: ShowMessage(player, String0432); // With a groan, the wizard slumps over, dead.
            L009D: return; // RETURN;
        }

        private void Fn_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0D));
            L0016: if (JumpNotEqual) goto L0032;
            L0018: SetFlag(player, 0x03, 0x0D, 0x01);
04BC  002D B8 5E 04  mov ax, 0x45e
            L0030: goto L0035;
            L0032: ShowMessage(player, String053C); // 'Tis yet another pile of regenerating skeletons.
            L003F: PushStack(player, 0x00);
            L0042: PushStack(player, ax);
            L0043: PushStack(player, ax);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, ax);
            L0046: PushStack(player, ax);
04D6  0047 C4 5E 06  les bx, [bp+0x6]
04D9  004A 26 FF 9F D8 00  call far word [es:bx+0xd8]
04DE  004F 83 C4 0C  add sp, 0xc
            L0052: AddEncounter(player, 0x01, 0x13);
            L0064: AddEncounter(player, 0x02, 0x13);
            L0076: Compare(PartyCount(player), 0x0003);
            L0081: if (JumpBelowOrEqual) goto L00A7;
            L0083: AddEncounter(player, 0x03, 0x1B);
            L0095: AddEncounter(player, 0x04, 0x1B);
            L00A7: return; // RETURN;
        }

        private void Fn_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x04, 0x02, 0x80, 0x02, isForwardMove);
            L001E: ShowMessage(player, String056D); // This doorway leads to the Pantry.
            L002B: return; // RETURN;
        }

        private void Fn_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x18));
            L0016: if (JumpNotEqual) goto L0032;
            L0018: SetFlag(player, 0x03, 0x18, 0x01);
0592  002D B8 8F 05  mov ax, 0x58f
            L0030: goto L0035;
            L0032: ShowMessage(player, String0686); // 'Tis yet another huge pile of regenerating skeletons.
            L003F: PushStack(player, 0x00);
            L0042: PushStack(player, ax);
            L0043: PushStack(player, ax);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, ax);
            L0046: PushStack(player, ax);
05AC  0047 C4 5E 06  les bx, [bp+0x6]
05AF  004A 26 FF 9F D8 00  call far word [es:bx+0xd8]
05B4  004F 83 C4 0C  add sp, 0xc
            L0052: AddEncounter(player, 0x01, 0x1B);
            L0064: AddEncounter(player, 0x02, 0x1B);
            L0076: AddEncounter(player, 0x05, 0x13);
            L0088: AddEncounter(player, 0x06, 0x13);
            L009A: Compare(PartyCount(player), 0x0003);
            L00A5: if (JumpBelowOrEqual) goto L00CB;
            L00A7: AddEncounter(player, 0x03, 0x1B);
            L00B9: AddEncounter(player, 0x04, 0x1B);
            L00CB: return; // RETURN;
        }

        private void Fn_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x17));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0180;
            L001B: SetFlag(player, 0x03, 0x17, 0x01);
            L0030: ShowMessage(player, String06BC); // Who needs napalm when you have fireballs?  Ouch!
            L003D: ax = GetMaxHits(player);
            L0044: bx = 0x0003;
            L0047: dx = ax % bx; ax = ax / bx;
            L004A: DamagePlayer(player, ax);
            L0054: Compare(PartyCount(player), 0x0003);
            L005F: if (JumpBelowOrEqual) goto L006E;
            L0061: ShowMessage(player, String06ED); // Bad ghouls bad ghouls.  Whatcha gonna do?
            L006E: AddTreasure(player, 0x007D, 0x00, 0x72, 0x1B, 0xF3, 0x8E);
            L0090: AddEncounter(player, 0x01, 0x1D);
            L00A2: AddEncounter(player, 0x05, 0x1C);
            L00B4: ax = CheckLevel(player, 0x000C);
            L00C2: if (JumpEqual) goto L012B;
            L00C4: Compare(PartyCount(player), 0x0002);
            L00CF: if (JumpBelowOrEqual) goto L00F5;
            L00D1: AddEncounter(player, 0x02, 0x1D);
            L00E3: AddEncounter(player, 0x06, 0x1C);
            L00F5: Compare(PartyCount(player), 0x0003);
            L0100: if (JumpAbove) goto L0105;
            L0102: goto L018D;
            L0105: AddEncounter(player, 0x04, 0x19);
            L0117: AddEncounter(player, 0x03, 0x19);
            L0129: goto L018D;
            L012B: Compare(PartyCount(player), 0x0002);
            L0136: if (JumpBelowOrEqual) goto L015C;
            L0138: AddEncounter(player, 0x02, 0x17);
            L014A: AddEncounter(player, 0x06, 0x12);
            L015C: Compare(PartyCount(player), 0x0003);
            L0167: if (JumpBelowOrEqual) goto L018D;
            L0169: AddEncounter(player, 0x04, 0x18);
07BC  017B B8 18 00  mov ax, 0x18
            L017E: goto L011A;
            L0180: ShowMessage(player, String0717); // You're just grateful that that fireball ambush didn't barbecue the Tongue of Dog.  In fact, you're grateful it didn't barbecue you, either!
            L018D: return; // RETURN;
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0125;
            L001B: SetFlag(player, 0x03, 0x05, 0x01);
            L0030: Compare(GetFlag(player, 0x03, 0x12), 0x0001);
            L0044: if (JumpNotEqual) goto L004B;
0816  0046 B8 A3 07  mov ax, 0x7a3
            L0049: goto L004E;
            L004B: ShowMessage(player, String07D5); // The good news is that these aren't the dogs of war.  The bad news is they are the dogs of unpleasant arguments.
            L0058: Compare(PartyCount(player), 0x0003);
            L0063: if (JumpBelowOrEqual) goto L0087;
            L0065: RefreshCompareFlags(GetFlag(player, 0x03, 0x12));
            L0078: if (JumpNotEqual) goto L0087;
            L007A: ShowMessage(player, String0845); // Backed by a pack of dogs of disagreements.
            L0087: PushStack(player, 0xBB);
            L008B: PushStack(player, 0x00);
            L008E: PushStack(player, ax);
            L008F: PushStack(player, ax);
            L0090: PushStack(player, ax);
            L0091: PushStack(player, ax);
0862  0092 C4 5E 06  les bx, [bp+0x6]
0865  0095 26 FF 9F D8 00  call far word [es:bx+0xd8]
086A  009A 83 C4 0C  add sp, 0xc
            L009D: AddEncounter(player, 0x01, 0x1F);
            L00AF: AddEncounter(player, 0x02, 0x20);
            L00C1: Compare(PartyCount(player), 0x0002);
            L00CC: if (JumpBelowOrEqual) goto L00F2;
            L00CE: AddEncounter(player, 0x03, 0x21);
            L00E0: AddEncounter(player, 0x04, 0x22);
            L00F2: Compare(PartyCount(player), 0x0003);
            L00FD: if (JumpBelowOrEqual) goto L0132;
            L00FF: AddEncounter(player, 0x05, 0x21);
            L0111: AddEncounter(player, 0x06, 0x22);
            L0123: goto L0132;
            L0125: ShowMessage(player, String0870); // The battle you fought here left you dog-tired.
            L0132: return; // RETURN;
        }

        private void Fn_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E4;
            L001B: SetFlag(player, 0x03, 0x06, 0x01);
            L0030: ShowMessage(player, String089F); // Yuk!  Somebody should clean out the drains once in a while!
            L003D: PushStack(player, 0x7D);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, 0xB9);
            L0049: PushStack(player, 0xAC);
            L004D: PushStack(player, 0x15);
0955  0051 C4 5E 06  les bx, [bp+0x6]
0958  0054 26 FF 9F D8 00  call far word [es:bx+0xd8]
095D  0059 83 C4 0C  add sp, 0xc
            L005C: AddEncounter(player, 0x01, 0x25);
            L006E: AddEncounter(player, 0x02, 0x25);
            L0080: Compare(PartyCount(player), 0x0002);
            L008B: if (JumpBelowOrEqual) goto L00B1;
            L008D: AddEncounter(player, 0x03, 0x25);
            L009F: AddEncounter(player, 0x04, 0x25);
            L00B1: Compare(PartyCount(player), 0x0003);
            L00BC: if (JumpBelowOrEqual) goto L00F1;
            L00BE: AddEncounter(player, 0x05, 0x25);
            L00D0: AddEncounter(player, 0x06, 0x25);
            L00E2: goto L00F1;
            L00E4: ShowMessage(player, String08DB); // It took you hours to get all the slime out of your hair after the battle you had here.
            L00F1: return; // RETURN;
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00FE;
            L001B: SetFlag(player, 0x03, 0x07, 0x01);
            L0030: ShowMessage(player, String0932); // You've found a hive of harpies, assuming harpies hang in hives.
            L003D: Compare(PartyCount(player), 0x0003);
            L0048: if (JumpBelowOrEqual) goto L0057;
            L004A: ShowMessage(player, String0972); // This many harpies is giving you a bad case of hives.
0A4E  0057 B8 B9 03  mov ax, 0x3b9
            L005A: PushStack(player, ax);
            L005B: PushStack(player, 0x00);
            L005E: PushStack(player, ax);
            L005F: PushStack(player, 0xB9);
            L0063: PushStack(player, 0xB6);
            L0067: PushStack(player, 0x2A);
0A62  006B C4 5E 06  les bx, [bp+0x6]
0A65  006E 26 FF 9F D8 00  call far word [es:bx+0xd8]
0A6A  0073 83 C4 0C  add sp, 0xc
            L0076: AddEncounter(player, 0x01, 0x10);
            L0088: AddEncounter(player, 0x02, 0x1E);
            L009A: Compare(PartyCount(player), 0x0002);
            L00A5: if (JumpBelowOrEqual) goto L00CB;
            L00A7: AddEncounter(player, 0x03, 0x11);
            L00B9: AddEncounter(player, 0x04, 0x1E);
            L00CB: Compare(PartyCount(player), 0x0003);
            L00D6: if (JumpBelowOrEqual) goto L0147;
            L00D8: AddEncounter(player, 0x05, 0x11);
            L00EA: AddEncounter(player, 0x06, 0x1E);
            L00FC: goto L0147;
            L00FE: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L0111: if (JumpNotEqual) goto L013A;
            L0113: SetFlag(player, 0x03, 0x0F, 0x01);
            L0128: ShowMessage(player, String09A7); // You examine the battleground.  Amidst all the feathers and flesh of the fiends you fought is a small piece of white paper with the name 'A. Hitchcock' printed on it, and written on the back the words 'Call me.'
0B2C  0135 B8 7A 0A  mov ax, 0xa7a
            L0138: goto L013D;
            L013A: ShowMessage(player, String0A96); // All the remains of your battle here are some fractured feathers and a broken beak.
            L0147: return; // RETURN;
        }

        private void Fn_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x08));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00F1;
            L001B: SetFlag(player, 0x03, 0x08, 0x01);
            L0030: ShowMessage(player, String0AE9); // A party has been arranged on your behalf.
            L003D: ShowMessage(player, String0B13); // Unfortunately, it appears to be a hanging party arranged by those arrayed rangers.  En garde!
0B8A  004A B8 32 02  mov ax, 0x232
            L004D: PushStack(player, ax);
            L004E: PushStack(player, 0x00);
            L0051: PushStack(player, ax);
            L0052: PushStack(player, 0x98);
            L0056: PushStack(player, 0x5B);
            L005A: PushStack(player, 0x91);
0B9E  005E C4 5E 06  les bx, [bp+0x6]
0BA1  0061 26 FF 9F D8 00  call far word [es:bx+0xd8]
0BA6  0066 83 C4 0C  add sp, 0xc
            L0069: AddEncounter(player, 0x01, 0x23);
            L007B: AddEncounter(player, 0x05, 0x24);
            L008D: Compare(PartyCount(player), 0x0002);
            L0098: if (JumpBelowOrEqual) goto L00BE;
            L009A: AddEncounter(player, 0x02, 0x23);
            L00AC: AddEncounter(player, 0x06, 0x24);
            L00BE: Compare(PartyCount(player), 0x0003);
            L00C9: if (JumpBelowOrEqual) goto L010B;
            L00CB: AddEncounter(player, 0x04, 0x23);
            L00DD: AddEncounter(player, 0x03, 0x24);
            L00EF: goto L010B;
            L00F1: ShowMessage(player, String0B71); // You remember the rangers here.  You just picked them up and squeezed them and loved them, and now they don't move no more.
            L00FE: ShowMessage(player, String0BEC); // Good thing for you, too
            L010B: return; // RETURN;
        }

        private void Fn_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x09));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00FE;
            L001B: SetFlag(player, 0x03, 0x09, 0x01);
            L0030: ShowMessage(player, String0C04); // It must be Balkan Night in Cawdor.  You see minotaurs and medusae arrayed against you.
            L003D: Compare(PartyCount(player), 0x0003);
            L0048: if (JumpBelowOrEqual) goto L0057;
            L004A: ShowMessage(player, String0C5B); // In fact, you're balkin' at the thought of fighting these guys!
            L0057: PushStack(player, 0x7D);
            L005B: PushStack(player, 0x00);
            L005E: PushStack(player, ax);
            L005F: PushStack(player, 0x13);
            L0063: PushStack(player, 0x8F);
            L0067: PushStack(player, 0x5C);
0CB8  006B C4 5E 06  les bx, [bp+0x6]
0CBB  006E 26 FF 9F D8 00  call far word [es:bx+0xd8]
0CC0  0073 83 C4 0C  add sp, 0xc
            L0076: AddEncounter(player, 0x01, 0x27);
            L0088: AddEncounter(player, 0x02, 0x26);
            L009A: AddEncounter(player, 0x03, 0x28);
            L00AC: Compare(PartyCount(player), 0x0002);
            L00B7: if (JumpBelowOrEqual) goto L00CB;
            L00B9: AddEncounter(player, 0x04, 0x27);
            L00CB: Compare(PartyCount(player), 0x0003);
            L00D6: if (JumpBelowOrEqual) goto L010B;
            L00D8: AddEncounter(player, 0x05, 0x26);
            L00EA: AddEncounter(player, 0x06, 0x28);
            L00FC: goto L010B;
            L00FE: ShowMessage(player, String0C9A); // Sometimes the good guys win.  Or at least run away.
            L010B: return; // RETURN;
        }

        private void Fn_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0180;
            L001B: SetFlag(player, 0x03, 0x0A, 0x01);
            L0030: ShowMessage(player, String0CCE); // Yup.  That's an incoming fireball.  You recognise it from the pain.
            L003D: ax = GetMaxHits(player);
            L0044: bx = 0x0003;
            L0047: dx = ax % bx; ax = ax / bx;
            L004A: DamagePlayer(player, ax);
            L0054: Compare(PartyCount(player), 0x0003);
            L005F: if (JumpBelowOrEqual) goto L006E;
            L0061: ShowMessage(player, String0D12); // And these must be the ghouls Mom warned you about.
            L006E: AddTreasure(player, 0x007D, 0x00, 0x72, 0x1B, 0xF3, 0x8E);
            L0090: AddEncounter(player, 0x01, 0x1D);
            L00A2: AddEncounter(player, 0x05, 0x1C);
            L00B4: ax = CheckLevel(player, 0x000C);
            L00C2: if (JumpEqual) goto L012B;
            L00C4: Compare(PartyCount(player), 0x0002);
            L00CF: if (JumpBelowOrEqual) goto L00F5;
            L00D1: AddEncounter(player, 0x02, 0x1D);
            L00E3: AddEncounter(player, 0x06, 0x1C);
            L00F5: Compare(PartyCount(player), 0x0003);
            L0100: if (JumpAbove) goto L0105;
            L0102: goto L018D;
            L0105: AddEncounter(player, 0x04, 0x19);
            L0117: AddEncounter(player, 0x03, 0x19);
            L0129: goto L018D;
            L012B: Compare(PartyCount(player), 0x0002);
            L0136: if (JumpBelowOrEqual) goto L015C;
            L0138: AddEncounter(player, 0x02, 0x17);
            L014A: AddEncounter(player, 0x06, 0x12);
            L015C: Compare(PartyCount(player), 0x0003);
            L0167: if (JumpBelowOrEqual) goto L018D;
            L0169: AddEncounter(player, 0x04, 0x18);
0ED5  017B B8 18 00  mov ax, 0x18
            L017E: goto L011A;
            L0180: ShowMessage(player, String0D45); // Your bones still ache from the battle you fought here.  But you think the Tongue of Dog you won will more than make up for your aches, heh heh.
            L018D: return; // RETURN;
        }

        private void Fn_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: ax = GetFlag(player, 0x03, 0x0B);
0F03  001A 8B F8  mov di, ax
0F05  001C 47     inc di
0F06  001D 8B F7  mov si, di
            L001F: Compare(si, 0x13);
            L0022: if (JumpLessOrEqual) goto L002B;
0F0D  0024 8B C6  mov ax, si
            L0026: si = ax + 0xFFEC;
            L002B: Compare(si, 0x0E);
            L002E: if (JumpLessOrEqual) goto L0037;
0F19  0030 8B C6  mov ax, si
            L0032: si = ax + 0xFFF1;
            L0037: Compare(si, 0x09);
            L003A: if (JumpLessOrEqual) goto L0043;
0F25  003C 8B C6  mov ax, si
            L003E: si = ax + 0xFFF6;
            L0043: Compare(si, 0x04);
            L0046: if (JumpLessOrEqual) goto L004F;
0F31  0048 8B C6  mov ax, si
            L004A: si = ax + 0xFFFB;
0F38  004F 0B F6  or si, si
0F3A  0051 7D 02  jge 0x55
            L0053: si = 0;
            L0055: Compare(si, 0x1D);
            L0058: if (JumpLessOrEqual) goto L005C;
            L005A: si = 0;
0F45  005C 83 FF 1E  cmp di, 0x1e
            L005F: if (JumpLessOrEqual) goto L0063;
            L0061: di = 0;
0F4C  0063 57     push di
            L0064: PushStack(player, 0x0B);
            L0068: PushStack(player, 0x03);
0F55  006C C4 5E 06  les bx, [bp+0x6]
0F58  006F 26 FF 1F  call far word [es:bx]
0F5B  0072 83 C4 06  add sp, 0x6
0F5E  0075 83 FF 1A  cmp di, 0x1a
            L0078: if (JumpNotEqual) goto L007F;
0F63  007A B8 01 00  mov ax, 0x1
            L007D: goto L0081;
            L007F: PushStack(player, 0x00);
0F6B  0082 83 FF 14  cmp di, 0x14
            L0085: if (JumpNotEqual) goto L008C;
0F70  0087 B8 01 00  mov ax, 0x1
            L008A: goto L008E;
0F75  008C 33 C0  xor ax, ax
            L008E: dx = PopStack(player);
0F78  008F 0B D0  or dx, ax
            L0091: PushStack(player, dx);
0F7B  0092 83 FF 0E  cmp di, 0xe
            L0095: if (JumpNotEqual) goto L009C;
0F80  0097 B8 01 00  mov ax, 0x1
            L009A: goto L009E;
0F85  009C 33 C0  xor ax, ax
            L009E: dx = PopStack(player);
0F88  009F 0B D0  or dx, ax
            L00A1: PushStack(player, dx);
0F8B  00A2 83 FF 08  cmp di, 0x8
            L00A5: if (JumpNotEqual) goto L00AC;
0F90  00A7 B8 01 00  mov ax, 0x1
            L00AA: goto L00AE;
0F95  00AC 33 C0  xor ax, ax
            L00AE: dx = PopStack(player);
0F98  00AF 0B D0  or dx, ax
            L00B1: PushStack(player, dx);
0F9B  00B2 83 FF 02  cmp di, 0x2
            L00B5: if (JumpNotEqual) goto L00BC;
0FA0  00B7 B8 01 00  mov ax, 0x1
            L00BA: goto L00BE;
0FA5  00BC 33 C0  xor ax, ax
            L00BE: dx = PopStack(player);
0FA8  00BF 0B D0  or dx, ax
            L00C1: if (JumpNotEqual) goto L00C6;
            L00C3: goto L0359;
            L00C6: bx = si;
            L00C8: Compare(bx, 0x04);
            L00CB: if (JumpBelowOrEqual) goto L00D0;
            L00CD: goto L0359;
            L00D0: switch (bx) {
                case 0:
                    goto L00D7;
                case 1:
                    goto L00E7;
                case 2:
                    goto L01CD;
                case 3:
                    goto L022D;
                case 4:
                    goto L029D;
            }
            L00D7: ShowMessage(player, String0DD5); // You hear some footsteps running away.
            L00E4: goto L0359;
            L00E7: Compare(GetFlag(player, 0x03, 0x0E), 0x0002);
            L00FB: if (JumpNotEqual) goto L010A;
            L00FD: ShowMessage(player, String0DFB); // You see a ghoul dragging a corpse.  It decides it likes dead meat better than live, and runs off.
            L010A: Compare(GetFlag(player, 0x03, 0x0E), 0x0001);
            L011E: if (JumpNotEqual) goto L0142;
            L0120: ShowMessage(player, String0E5D); // You find the body of the panicked elf cleric, drained of its blood.  There was reason to panic after all.
            L012D: SetFlag(player, 0x03, 0x0E, 0x02);
            L0142: RefreshCompareFlags(GetFlag(player, 0x03, 0x0E));
            L0155: if (JumpEqual) goto L015A;
            L0157: goto L0359;
            L015A: ShowMessage(player, String0EC7); // You hear someone running towards you.
            L0167: ShowPortrait(player, 0x0027);
            L0174: ShowMessage(player, String02F5); // *
            L0181: ShowMessage(player, String02F5); // *
            L018E: ShowMessage(player, String02F5); // *
            L019B: ShowMessage(player, String0EED); // 'By all the saints, thou must know this! We fought the vampires here, and one of us, wielding Malcolm's Chopper, harmed it, but not as much as the Hunting Bow or Oswald's Bane.  My comrades there lie dead.  I dare no longer stay.'
            L01A8: ShowMessage(player, String0FD4); // The cleric departs, rapidly.
            L01B5: SetFlag(player, 0x03, 0x0E, 0x01);
            L01CA: goto L0359;
            L01CD: ShowPortrait(player, 0x000E);
            L01DA: ShowMessage(player, String0FF1); // The dragon examines you with a baleful eye.  It has seen better days.
            L01E7: ShowMessage(player, String1037); // 'Thou art living, and I am desperate.  I must have a petunia poultice.  I will pay well for one.'
            L01F4: ax = HasItem(player, 0xB9);
            L0202: if (JumpEqual) goto L0227;
            L0204: RemoveItem(player, 0xB9);
            L0210: ModifyGold(player, 0x157C);
110A  0221 B8 99 10  mov ax, 0x1099
            L0224: goto L00DA;
1110  0227 B8 03 11  mov ax, 0x1103
            L022A: goto L00DA;
            L022D: Compare(GetFlag(player, 0x02, 0x47), 0x0001);
            L0241: if (JumpNotEqual) goto L0249;
112C  0243 B8 8B 11  mov ax, 0x118b
            L0246: goto L00DA;
            L0249: ShowPortrait(player, 0x0025);
            L0256: ShowMessage(player, String02F5); // *
            L0263: ShowMessage(player, String02F5); // *
            L0270: ShowMessage(player, String02F5); // *
            L027D: ShowMessage(player, String1246); // The thief looks somewhat bruised.
            L028A: ShowMessage(player, String1268); // 'Ah! 'Tis my friends, not more of these thrice bedamned undead.  I must say, My Lady's Favor is well and good, as is the Thief's Tabard and the Gaelic Garlic, but none match the power of the Holy Relic against them.  Would that I had one!  May fortune favor thee.'
1180  0297 B8 71 13  mov ax, 0x1371
            L029A: goto L00DA;
            L029D: ShowPortrait(player, 0x0026);
            L02AA: ShowMessage(player, String02F5); // *
            L02B7: ShowMessage(player, String02F5); // *
            L02C4: ShowMessage(player, String02F5); // *
            L02D1: ShowMessage(player, String1399); // A slew o'Slyfeet decide, rather insultingly, that they are bigger than you are.
            L02DE: PushStack(player, 0x93);
            L02E2: PushStack(player, 0x00);
            L02E5: PushStack(player, ax);
            L02E6: PushStack(player, ax);
            L02E7: PushStack(player, 0xB6);
            L02EB: PushStack(player, 0xBD);
11D8  02EF C4 5E 06  les bx, [bp+0x6]
11DB  02F2 26 FF 9F D8 00  call far word [es:bx+0xd8]
11E0  02F7 83 C4 0C  add sp, 0xc
            L02FA: PushStack(player, 0x01);
            L02FE: PushStack(player, ax);
11E8  02FF C4 5E 06  les bx, [bp+0x6]
11EB  0302 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0307: cx = PopStack(player);
            L0308: cx = PopStack(player);
            L0309: Compare(PartyCount(player), 0x0001);
            L0314: if (JumpBelowOrEqual) goto L0328;
            L0316: AddEncounter(player, 0x05, 0x02);
            L0328: Compare(PartyCount(player), 0x0002);
            L0333: if (JumpBelowOrEqual) goto L0359;
            L0335: AddEncounter(player, 0x02, 0x01);
            L0347: AddEncounter(player, 0x06, 0x02);
            L0359: return; // RETURN (restoring si, di);
        }

        private void Fn_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0C));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00B2;
            L001B: SetFlag(player, 0x03, 0x0C, 0x01);
            L0030: ShowPortrait(player, 0x0027);
            L003D: ShowMessage(player, String02F5); // *
            L004A: ShowMessage(player, String02F5); // *
            L0057: ShowMessage(player, String02F5); // *
            L0064: ShowMessage(player, String13E9); // 'I have been waiting for thee.  Pay close heed!'
            L0071: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L0084: if (JumpNotEqual) goto L0098;
            L0086: ShowMessage(player, String141A); // 'The Vampiric Servant who rules this level can most oft be found upon his throne nigh unto the very center of this room.
12E3  0093 B8 93 14  mov ax, 0x1493
            L0096: goto L00A8;
            L0098: ShowMessage(player, String150E); // 'I did observe thee defeat the Vampire who, until today, held sway here.  The item thou should prize above all others from him is the Tongue of Dog.
            L00A5: ShowMessage(player, String15A3); // Use it wisely; that item doth possess but one charge.  One very potent charge.'
            L00B2: return; // RETURN;
        }

        private void Fn_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x10));
            L0016: if (JumpNotEqual) goto L003F;
            L0018: SetFlag(player, 0x03, 0x10, 0x01);
            L002D: ShowMessage(player, String15F3); // This large, well appointed room features many fine marble columns.  Towards the center of the room you think you can see a throne.
133E  003A B8 76 16  mov ax, 0x1676
            L003D: goto L0042;
            L003F: ShowMessage(player, String1710); // The throne room remains as you last saw it: a dangerous place for the quick and the dead.
            L004C: return; // RETURN;
        }

        private void Fn_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x13));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E4;
            L001B: SetFlag(player, 0x03, 0x13, 0x01);
            L0030: ShowMessage(player, String089F); // Yuk!  Somebody should clean out the drains once in a while!
            L003D: PushStack(player, 0x7D);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, 0xB9);
            L0049: PushStack(player, 0xAC);
            L004D: PushStack(player, 0x15);
13A8  0051 C4 5E 06  les bx, [bp+0x6]
13AB  0054 26 FF 9F D8 00  call far word [es:bx+0xd8]
13B0  0059 83 C4 0C  add sp, 0xc
            L005C: AddEncounter(player, 0x01, 0x25);
            L006E: AddEncounter(player, 0x02, 0x25);
            L0080: Compare(PartyCount(player), 0x0002);
            L008B: if (JumpBelowOrEqual) goto L00B1;
            L008D: AddEncounter(player, 0x03, 0x25);
            L009F: AddEncounter(player, 0x04, 0x25);
            L00B1: Compare(PartyCount(player), 0x0003);
            L00BC: if (JumpBelowOrEqual) goto L00F1;
            L00BE: AddEncounter(player, 0x05, 0x25);
            L00D0: AddEncounter(player, 0x06, 0x25);
            L00E2: goto L00F1;
            L00E4: ShowMessage(player, String08DB); // It took you hours to get all the slime out of your hair after the battle you had here.
            L00F1: return; // RETURN;
        }

        private void Fn_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x12));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0125;
            L001B: SetFlag(player, 0x03, 0x12, 0x01);
            L0030: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L0044: if (JumpNotEqual) goto L004B;
1490  0046 B8 A3 07  mov ax, 0x7a3
            L0049: goto L004E;
            L004B: ShowMessage(player, String07D5); // The good news is that these aren't the dogs of war.  The bad news is they are the dogs of unpleasant arguments.
            L0058: Compare(PartyCount(player), 0x0003);
            L0063: if (JumpBelowOrEqual) goto L0087;
            L0065: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0078: if (JumpNotEqual) goto L0087;
            L007A: ShowMessage(player, String0845); // Backed by a pack of dogs of disagreements.
            L0087: PushStack(player, 0xBB);
            L008B: PushStack(player, 0x00);
            L008E: PushStack(player, ax);
            L008F: PushStack(player, ax);
            L0090: PushStack(player, ax);
            L0091: PushStack(player, ax);
14DC  0092 C4 5E 06  les bx, [bp+0x6]
14DF  0095 26 FF 9F D8 00  call far word [es:bx+0xd8]
14E4  009A 83 C4 0C  add sp, 0xc
            L009D: AddEncounter(player, 0x01, 0x1F);
            L00AF: AddEncounter(player, 0x02, 0x20);
            L00C1: Compare(PartyCount(player), 0x0002);
            L00CC: if (JumpBelowOrEqual) goto L00F2;
            L00CE: AddEncounter(player, 0x03, 0x21);
            L00E0: AddEncounter(player, 0x04, 0x22);
            L00F2: Compare(PartyCount(player), 0x0003);
            L00FD: if (JumpBelowOrEqual) goto L0132;
            L00FF: AddEncounter(player, 0x05, 0x21);
            L0111: AddEncounter(player, 0x06, 0x22);
            L0123: goto L0132;
            L0125: ShowMessage(player, String0870); // The battle you fought here left you dog-tired.
            L0132: return; // RETURN;
        }

        private void Fn_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x14));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00FE;
            L001B: SetFlag(player, 0x03, 0x14, 0x01);
            L0030: ShowMessage(player, String0932); // You've found a hive of harpies, assuming harpies hang in hives.
            L003D: Compare(PartyCount(player), 0x0003);
            L0048: if (JumpBelowOrEqual) goto L0057;
            L004A: ShowMessage(player, String0972); // This many harpies is giving you a bad case of hives.
15D5  0057 B8 B9 03  mov ax, 0x3b9
            L005A: PushStack(player, ax);
            L005B: PushStack(player, 0x00);
            L005E: PushStack(player, ax);
            L005F: PushStack(player, 0xB9);
            L0063: PushStack(player, 0xB6);
            L0067: PushStack(player, 0x2A);
15E9  006B C4 5E 06  les bx, [bp+0x6]
15EC  006E 26 FF 9F D8 00  call far word [es:bx+0xd8]
15F1  0073 83 C4 0C  add sp, 0xc
            L0076: AddEncounter(player, 0x01, 0x10);
            L0088: AddEncounter(player, 0x02, 0x1E);
            L009A: Compare(PartyCount(player), 0x0002);
            L00A5: if (JumpBelowOrEqual) goto L00CB;
            L00A7: AddEncounter(player, 0x03, 0x11);
            L00B9: AddEncounter(player, 0x04, 0x1E);
            L00CB: Compare(PartyCount(player), 0x0003);
            L00D6: if (JumpBelowOrEqual) goto L0147;
            L00D8: AddEncounter(player, 0x05, 0x11);
            L00EA: AddEncounter(player, 0x06, 0x1E);
            L00FC: goto L0147;
            L00FE: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L0111: if (JumpNotEqual) goto L013A;
            L0113: SetFlag(player, 0x03, 0x0F, 0x01);
            L0128: ShowMessage(player, String09A7); // You examine the battleground.  Amidst all the feathers and flesh of the fiends you fought is a small piece of white paper with the name 'A. Hitchcock' printed on it, and written on the back the words 'Call me.'
16B3  0135 B8 7A 0A  mov ax, 0xa7a
            L0138: goto L013D;
            L013A: ShowMessage(player, String0A96); // All the remains of your battle here are some fractured feathers and a broken beak.
            L0147: return; // RETURN;
        }

        private void Fn_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x15));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00F1;
            L001B: SetFlag(player, 0x03, 0x15, 0x01);
            L0030: ShowMessage(player, String0AE9); // A party has been arranged on your behalf.
            L003D: ShowMessage(player, String0B13); // Unfortunately, it appears to be a hanging party arranged by those arrayed rangers.  En garde!
1711  004A B8 32 02  mov ax, 0x232
            L004D: PushStack(player, ax);
            L004E: PushStack(player, 0x00);
            L0051: PushStack(player, ax);
            L0052: PushStack(player, 0x98);
            L0056: PushStack(player, 0x5B);
            L005A: PushStack(player, 0x91);
1725  005E C4 5E 06  les bx, [bp+0x6]
1728  0061 26 FF 9F D8 00  call far word [es:bx+0xd8]
172D  0066 83 C4 0C  add sp, 0xc
            L0069: AddEncounter(player, 0x01, 0x23);
            L007B: AddEncounter(player, 0x05, 0x24);
            L008D: Compare(PartyCount(player), 0x0002);
            L0098: if (JumpBelowOrEqual) goto L00BE;
            L009A: AddEncounter(player, 0x02, 0x23);
            L00AC: AddEncounter(player, 0x06, 0x24);
            L00BE: Compare(PartyCount(player), 0x0003);
            L00C9: if (JumpBelowOrEqual) goto L010B;
            L00CB: AddEncounter(player, 0x04, 0x23);
            L00DD: AddEncounter(player, 0x03, 0x24);
            L00EF: goto L010B;
            L00F1: ShowMessage(player, String0B71); // You remember the rangers here.  You just picked them up and squeezed them and loved them, and now they don't move no more.
            L00FE: ShowMessage(player, String0BEC); // Good thing for you, too
            L010B: return; // RETURN;
        }

        private void Fn_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x16));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E4;
            L001B: SetFlag(player, 0x03, 0x16, 0x01);
            L0030: ShowMessage(player, String176A); // You recognise the minotaurs and medusae from your studies in recent history.  You just hope that you aren't about to join them as yet another statistic.
            L003D: PushStack(player, 0x7D);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, 0x13);
            L0049: PushStack(player, 0x8F);
            L004D: PushStack(player, 0x5C);
1825  0051 C4 5E 06  les bx, [bp+0x6]
1828  0054 26 FF 9F D8 00  call far word [es:bx+0xd8]
182D  0059 83 C4 0C  add sp, 0xc
            L005C: AddEncounter(player, 0x01, 0x27);
            L006E: AddEncounter(player, 0x02, 0x26);
            L0080: AddEncounter(player, 0x03, 0x28);
            L0092: Compare(PartyCount(player), 0x0002);
            L009D: if (JumpBelowOrEqual) goto L00B1;
            L009F: AddEncounter(player, 0x04, 0x27);
            L00B1: Compare(PartyCount(player), 0x0003);
            L00BC: if (JumpBelowOrEqual) goto L00F1;
            L00BE: AddEncounter(player, 0x05, 0x26);
            L00D0: AddEncounter(player, 0x06, 0x28);
            L00E2: goto L00F1;
            L00E4: ShowMessage(player, String1803); // Sometimes the good guys win.  This was one of them. Or at least close enough for jazz.
            L00F1: return; // RETURN;
        }

        private void Fn_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x1B));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00F1;
            L001B: SetFlag(player, 0x03, 0x1B, 0x01);
            L0030: ShowMessage(player, String185A); // My gosh!  It's one of your childhood heroes: The Lonely Ranger!
            L003D: ShowMessage(player, String189A); // Unfortunately, you don't seem to be one of his heroes.  And in that crowd, who has time to be lonely?
1911  004A B8 32 02  mov ax, 0x232
            L004D: PushStack(player, ax);
            L004E: PushStack(player, 0x00);
            L0051: PushStack(player, ax);
            L0052: PushStack(player, 0x98);
            L0056: PushStack(player, 0x5B);
            L005A: PushStack(player, 0x91);
1925  005E C4 5E 06  les bx, [bp+0x6]
1928  0061 26 FF 9F D8 00  call far word [es:bx+0xd8]
192D  0066 83 C4 0C  add sp, 0xc
            L0069: AddEncounter(player, 0x01, 0x23);
            L007B: AddEncounter(player, 0x05, 0x24);
            L008D: Compare(PartyCount(player), 0x0002);
            L0098: if (JumpBelowOrEqual) goto L00BE;
            L009A: AddEncounter(player, 0x02, 0x23);
            L00AC: AddEncounter(player, 0x06, 0x24);
            L00BE: Compare(PartyCount(player), 0x0003);
            L00C9: if (JumpBelowOrEqual) goto L00FE;
            L00CB: AddEncounter(player, 0x04, 0x23);
            L00DD: AddEncounter(player, 0x03, 0x24);
            L00EF: goto L00FE;
            L00F1: ShowMessage(player, String1900); // All that remains of your battle here is a broken old decoder ring.
            L00FE: return; // RETURN;
        }

        private void Fn_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x1A));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00B6;
            L001B: ShowMessage(player, String1943); // This entrance to The Lesser Hall is guarded!
            L0028: SetFlag(player, 0x03, 0x1A, 0x01);
            L003D: AddTreasure(player, 0x0223, 0x00, 0xB9, 0xCC, 0x9B, 0xDA);
            L005F: AddEncounter(player, 0x01, 0x19);
            L0071: AddEncounter(player, 0x05, 0x1C);
            L0083: Compare(PartyCount(player), 0x0002);
            L008E: if (JumpBelowOrEqual) goto L00D0;
            L0090: AddEncounter(player, 0x02, 0x19);
            L00A2: AddEncounter(player, 0x06, 0x1C);
            L00B4: goto L00D0;
            L00B6: ShowMessage(player, String1970); // Hmmm.  Cigarette butts, candy wrappers, loaded dice: there might not be any guards here now, but there used to be.
            L00C3: ShowMessage(player, String19E3); // And not very tidy guards, either!
            L00D0: return; // RETURN;
        }

    }
}
