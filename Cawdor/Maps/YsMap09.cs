#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap09 : AMapScripted {
        protected override int MapIndex => 9;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap09() {
            MapEvent05 = Fn_05;
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
            MapEvent20 = Fn_20;
            MapEvent21 = Fn_21;
            MapEvent22 = Fn_22;
            MapEvent23 = Fn_23;
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
            MapEvent35 = Fn_35;
            MapEvent36 = Fn_36;
            MapEvent37 = Fn_37;
            MapEvent38 = Fn_38;
            MapEvent39 = Fn_39;
            MapEvent3A = Fn_3A;
            MapEvent3B = Fn_3B;
        }
        
        // === Strings ================================================
        private const string String0140 = "By jove!  It was an intact bottle underneath all that rubble!  Judging from the way it survived, it must contain a powerful healing potion which healed the flagon as fast as it was cracked.";
        private const string String01FE = "A hundred interesting odors battle for your attention.  Most pungent are the spices, but you can also smell grains, vegetables, and meat, as well as burlap, barrels, and sealing wax.  This must be the pantry.";
        private const string String02CF = "It lookth like thith ith going to be a wraith againtth time!";
        private const string String030C = "All that remains from your battle here is a broken scythe and a scrap of black cloth.";
        private const string String0362 = "Leaping lizards!  Look at all those leopards!";
        private const string String0390 = "Not to mention their mocking masters!";
        private const string String03B6 = "All that remains from your battle here is a snapped whisker and splintered claw.";
        private const string String0407 = "At least you can tell that those brain pans can't possibly know how to cast spells against you. ";
        private const string String0468 = "All that remains from your battle here is a broken club and a scrap of fur.";
        private const string String04B4 = "Those monsters are not just wyvern hello.";
        private const string String04DE = "All that remains from your battle here is a broken tooth and a bit of scale.  The scavengers in this place must have cast-iron stomachs.";
        private const string String0567 = "It looks like a whole mobs of halflings.  The question is: do you count their arms and divide by two or four to figure out how many halflings there are?";
        private const string String0600 = "And whether they are half, full, or quarter, those elves do not look friendly!";
        private const string String064F = "All that remains from your battle here is a broken goblet and a snapped bow string.";
        private const string String06A3 = "With a faint smell of sulphur and brimstone, you are impressively beset.";
        private const string String06EC = "All that remains from your battle here is a burnt pack of playing cards and a half melted poker chip.";
        private const string String0752 = "An unusual combination of creatures has chosen to inhabit this spot.  Maybe you will investigate it later.";
        private const string String07BD = "That is, of course, if you survive.";
        private const string String07E1 = "You hear some footsteps running away.";
        private const string String0807 = "You hear someone running towards you.";
        private const string String082D = "*";
        private const string String082F = "The knight looks you over carefully and arrives at a visible decision.  'Thou art neither strong enough nor large enough to be hiding my Claymore.  I need it to defeat the weird sisters.  By the sun and moon, when I find the rogue who stole it, I shall have his head!'  The knight departs.";
        private const string String0951 = "This is one dragging dragon.  It is bleeding from several wounds and one eye is closed shut.  Before you even consider attacking it, it turns and flies off.";
        private const string String09EE = "A group of desperate dragons decides to have you for lunch.";
        private const string String0A2A = "That is more of a command performance than an invitation.";
        private const string String0A64 = "'I think we have met before.  In sooth, did I not offer thee some wyrmish wampum?  If thou art headed westwards, forewarned is forearmed: undead hold much of the Lesser Hall. ";
        private const string String0B14 = "Southwards it is giants and golems and gremlins, oh my!  Be seeing you!";
        private const string String0B5C = "The halfling struts off, smiling.";
        private const string String0B7E = "Giants and golems and gremlins, indeed.  But it was dragons that Rory should have feared the most.";
        private const string String0BE1 = "A somewhat battered horde o'halflings decides, rather insultingly, that they are bigger than you are.";
        private const string String0C47 = "You come upon a dying elf.  His dying words are, 'I know not that I can trust thee, but my news forces the risk.  The Undead Kings have allied with the Picts, and oft where one is found, both are near.'  With a slowly released breath, the elf dies.";
        private const string String0D40 = "This must lead to that section of the Gallery that you could not reach before.";
        private const string String0D8F = "You have unlocked the hidden door!";
        private const string String0DB2 = "You detect a hidden door, but it is locked.";
        private const string String0DDE = "This room is noticeably cooler than the others.  Many wine racks have been toppled and you doubt any bottles remain intact.";
        private const string String0E5A = "The wine room remains as you saw it.";
        private const string String0E7F = "Yoicks!  Under the influence of your poking and prodding, something round makes a rolling escape from this pile of rubble to the north.";
        private const string String0F07 = "You've chased enough bashful bottles in your day to recognise the sound of one that's intact.";
        private const string String0F65 = "This room is full of broken bins of oatmeal, no doubt long since gone into the bellies of rats and, you shudder as the thought occurs to you, into haggis.";
        private const string String1000 = "The oat room remains as you saw it.";
        private const string String1024 = "There are many still sealed barrels labelled with the words 'Best Southfarthing Barley.'  Having nothing to carry it in, you decide not to take it.";
        private const string String10B8 = "The barley room remains as you saw it.";
        private const string String10DF = "This room contains many intact barrels labelled 'Best Bitter Hops.'  Maybe there's a brewery somewhere.";
        private const string String1147 = "The hops room remains as you saw it.";
        private const string String116C = "This room contains many intact sacks of rye, stored on shelves behind thick walls and doors to protect them from the rats.  Maybe there's a distillery in the vicinity.";
        private const string String1214 = "The rye room remains as you saw it.";
        private const string String1238 = "This large room is full of reasonably fresh bins of vegetables: carrots, onions, peas, turnips, all sealed for the winter.  A sign on one wall reads, 'Take as you please our parsnips and peas, but prithee, take no leek.";
        private const string String1314 = "Greengrocer humor: the worst.";
        private const string String1332 = "The grocery room remains as you saw it.";
        private const string String135A = "This cold cold room is full of hanging sides of beef, mutton, chickens and ducks.  You never sausage a place (sorry).  A sign on one wall reads, 'Cuz, thou may take a chicken or steak, but prithee, pluck no duck.'";
        private const string String1430 = "Butcher humor: the wurst.";
        private const string String144A = "The butcher's room remains as you saw it.";
        private const string String1474 = "This large room is well stocked with fruits of all kinds: apples, berries, cherries, limes, lemons.  A sign on one wall reads, 'Friend, if you dare you may snare thee a pear, but prithee, partake not of the deadly nightshade.' The bin labelled nightshade appears to hold tomatoes.";
        private const string String158D = "Orange you glad fruit mongers have no sense of humor?";
        private const string String15C3 = "The fruit mongers room remains as you saw it.";
        private const string String15F1 = "The plaque reads: 'Never eat a dragon's egg when a dragon is nearby.'";
        private const string String1637 = "The plaque reads: 'A light white wine is appropriate to serve with halflings on toast.'";
        private const string String168F = "The plaque reads: 'You can't oversalt a pickle.'";
        private const string String16C0 = "The plaque reads: 'Ware the deadly nightshade, save with fish and chips.'";
        private const string String170A = "The plaque reads: 'Be thou not hasty when cooking thy pasty.  Cooked low and slow is the best way to go.'";
        private const string String1774 = "The plaque reads: 'Chicken soup may do marvels for a sick person, but it does nothing for the chicken.'";
        private const string String17DC = "The plaque reads: 'Harpy: the other other white meat.'";
        private const string String1813 = "The plaque reads: 'If you invite a vampire to dinner, it is a grievous breach of etiquette to serve stake.'";
        private const string String187F = "The plaque reads: 'When dining with zombies, if a bit of your dinner companion should fall off, simply pick it up in a napkin and dispose of it without fuss.'";
        private const string String191E = "The plaque reads: 'When planning a dinner party for dragons, use this simple rule of thumb: twelve pounds of meat for every ten feet of the dragon's length.";
        private const string String19BB = "The plaque reads: 'If a harpy informs you that some food or drink has turned, believe her.'";
        private const string String1A17 = "The plaque reads: 'Hellhounds prefer their meat raw.  They will char it themselves to taste.  Dragons may or may not choose to do so; it is best to include such a query with the invitation.'";
        private const string String1AD6 = "The plaque reads: 'When inviting dragons to a barbeque, be sure to specify whether you are inviting dinner or guests.'";
        private const string String1B4D = "The plaque reads: 'It is unwise to invite skeletons and hellhounds to the same meal.  It is beyond the pale to do so and call out Bury!'";
        private const string String1BD6 = "The plaque reads: 'One should plan on ghosts consuming about one tenth as much as a humanoid guest.  But they will invariably consume ten times as much spirits.'";
        private const string String1C78 = "The plaque reads: 'Polite slimes will wait until your other guests have finished before consuming the table scraps.  Impolite slimes will consider your other guests table scraps.'";
        private const string String1D2C = "The plaque reads: 'Most imps enjoy a large, even an excessive quantity of garlic.  Most undead don't.'";
        private const string String1D93 = "The plaque reads: 'If a giant should forget his manners and begin eating his neighbors, rap his knuckles firmly and be prepared to flee.  It is wise, therefore, to seat your less desirable guests near the giants.'";
        private const string String1E69 = "The plaque reads: 'Dragons are very sensitive about their etiquette.  They believe you should consider yourself fortunate that they are not eating you.  Any corrections of a dragon's etiquette is likely to lead to a correction of that oversight.'";
        private const string String1F60 = "The plaque reads: 'Golems are obedient and do not eat.  As such, they make excellent last minute replacements for cancellations.  A wise hostess will keep one in her closet for emergencies.'";
        private const string String201F = "The plaque reads: 'It is unwise to invite medusae and bats to the same function.  The bats are sure to get caught in the medusa's hair.  Once that happens, either way, you may be sure that someone will have to write a note of apology.'";
        private const string String210B = "The plaque reads: 'It is not preferred to have hedgepigs both on the guest list and on a platter.'";
        private const string String216E = "The plaque reads: 'It is a little known fact that you can safely serve beef to minotaurs without offending them, unless they happen to be vegetarians.'";
        private const string String2206 = "The plaque reads: 'A wise hostess will move discretely upwind if a dragon appears about to belch.'";
        private const string String2269 = "The plaque reads: 'Virtually none of the inhabitants of Cawdor are offended when you serve harpy at your functions.  Few have the stomach to eat harpy, but none are offended.'";
        
        // === Functions ================================================
        private void Fn_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x14), 0x0001);
            L0017: if (JumpNotEqual) goto L0046;
            L0019: ShowMessage(player, String0140); // By jove!  It was an intact bottle underneath all that rubble!  Judging from the way it survived, it must contain a powerful healing potion which healed the flagon as fast as it was cracked.
            L0026: SetFlag(player, 0x03, 0x14, 0x00);
            L003A: GiveItem(player, 0xBB);
            L0046: return; // RETURN;
        }

        private void Fn_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0B));
            L0016: if (JumpNotEqual) goto L004F;
            L0018: SetFlag(player, 0x02, 0x16, 0x01);
            L002D: SetFlag(player, 0x03, 0x0B, 0x01);
            L0042: ShowMessage(player, String01FE); // A hundred interesting odors battle for your attention.  Most pungent are the spices, but you can also smell grains, vegetables, and meat, as well as burlap, barrels, and sealing wax.  This must be the pantry.
            L004F: return; // RETURN;
        }

        private void Fn_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L019F;
            L001B: PushStack(player, 0x01);
            L001F: PushStack(player, ax);
            L0020: PushStack(player, 0x03);
00FD  0024 C4 5E 06  les bx, [bp+0x6]
0100  0027 26 FF 1F  call far word [es:bx]
0103  002A 83 C4 06  add sp, 0x6
            L002D: ShowMessage(player, String02CF); // It lookth like thith ith going to be a wraith againtth time!
            L003A: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L004E: if (JumpEqual) goto L0053;
            L0050: goto L00F8;
            L0053: PushStack(player, 0x03);
            L0057: PushStack(player, ax);
0131  0058 C4 5E 06  les bx, [bp+0x6]
0134  005B 26 FF 5F 04  call far word [es:bx+0x4]
            L005F: cx = PopStack(player);
            L0060: cx = PopStack(player);
            L0061: Compare(ax, 0x0001);
            L0064: if (JumpEqual) goto L0069;
            L0066: goto L00F8;
            L0069: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L007D: if (JumpNotEqual) goto L00F8;
            L007F: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L0093: if (JumpNotEqual) goto L00F8;
            L0095: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L00A9: if (JumpNotEqual) goto L00F8;
            L00AB: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L00BF: if (JumpNotEqual) goto L00F8;
            L00C1: ax = HasItem(player, 0xFD);
            L00CF: if (JumpNotEqual) goto L00F8;
            L00D1: ax = IsFlagOn(player, 0x02, 0x20);
            L00E4: if (JumpEqual) goto L00F8;
            L00E6: PushStack(player, 0x7D);
            L00EA: PushStack(player, 0x00);
            L00ED: PushStack(player, ax);
            L00EE: PushStack(player, ax);
            L00EF: PushStack(player, 0xBA);
01CC  00F3 B8 FD 00  mov ax, 0xfd
            L00F6: goto L010B;
            L00F8: PushStack(player, 0x7D);
            L00FC: PushStack(player, 0x00);
            L00FF: PushStack(player, ax);
            L0100: PushStack(player, 0xB9);
            L0104: PushStack(player, 0xBD);
            L0108: PushStack(player, 0x04);
01E5  010C C4 5E 06  les bx, [bp+0x6]
01E8  010F 26 FF 9F D8 00  call far word [es:bx+0xd8]
01ED  0114 83 C4 0C  add sp, 0xc
            L0117: AddEncounter(player, 0x01, 0x26);
            L0129: AddEncounter(player, 0x05, 0x28);
            L013B: Compare(PartyCount(player), 0x0002);
            L0146: if (JumpBelowOrEqual) goto L016C;
            L0148: AddEncounter(player, 0x02, 0x27);
            L015A: AddEncounter(player, 0x06, 0x26);
            L016C: Compare(PartyCount(player), 0x0003);
            L0177: if (JumpBelowOrEqual) goto L01AC;
            L0179: AddEncounter(player, 0x04, 0x28);
            L018B: AddEncounter(player, 0x03, 0x28);
            L019D: goto L01AC;
            L019F: ShowMessage(player, String030C); // All that remains from your battle here is a broken scythe and a scrap of black cloth.
            L01AC: return; // RETURN;
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L01B3;
            L001B: SetFlag(player, 0x03, 0x02, 0x01);
            L0030: ShowMessage(player, String0362); // Leaping lizards!  Look at all those leopards!
            L003D: Compare(PartyCount(player), 0x0003);
            L0048: if (JumpBelowOrEqual) goto L0057;
            L004A: ShowMessage(player, String0390); // Not to mention their mocking masters!
            L0057: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L006B: if (JumpEqual) goto L0070;
            L006D: goto L0115;
            L0070: PushStack(player, 0x03);
            L0074: PushStack(player, ax);
02FC  0075 C4 5E 06  les bx, [bp+0x6]
02FF  0078 26 FF 5F 04  call far word [es:bx+0x4]
            L007C: cx = PopStack(player);
            L007D: cx = PopStack(player);
            L007E: Compare(ax, 0x0001);
            L0081: if (JumpEqual) goto L0086;
            L0083: goto L0115;
            L0086: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L009A: if (JumpNotEqual) goto L0115;
            L009C: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L00B0: if (JumpNotEqual) goto L0115;
            L00B2: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L00C6: if (JumpNotEqual) goto L0115;
            L00C8: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L00DC: if (JumpNotEqual) goto L0115;
            L00DE: ax = HasItem(player, 0xFD);
            L00EC: if (JumpNotEqual) goto L0115;
            L00EE: ax = IsFlagOn(player, 0x02, 0x20);
            L0101: if (JumpEqual) goto L0115;
            L0103: PushStack(player, 0x7D);
            L0107: PushStack(player, 0x00);
            L010A: PushStack(player, ax);
            L010B: PushStack(player, ax);
            L010C: PushStack(player, 0xBA);
0397  0110 B8 FD 00  mov ax, 0xfd
            L0113: goto L011F;
            L0115: PushStack(player, 0xBB);
            L0119: PushStack(player, 0x00);
            L011C: PushStack(player, ax);
            L011D: PushStack(player, ax);
            L011E: PushStack(player, ax);
            L011F: PushStack(player, ax);
03A7  0120 C4 5E 06  les bx, [bp+0x6]
03AA  0123 26 FF 9F D8 00  call far word [es:bx+0xd8]
03AF  0128 83 C4 0C  add sp, 0xc
            L012B: AddEncounter(player, 0x01, 0x22);
            L013D: AddEncounter(player, 0x02, 0x22);
            L014F: Compare(PartyCount(player), 0x0002);
            L015A: if (JumpBelowOrEqual) goto L0180;
            L015C: AddEncounter(player, 0x03, 0x22);
            L016E: AddEncounter(player, 0x04, 0x22);
            L0180: Compare(PartyCount(player), 0x0003);
            L018B: if (JumpBelowOrEqual) goto L01C0;
            L018D: AddEncounter(player, 0x05, 0x1C);
            L019F: AddEncounter(player, 0x06, 0x1C);
            L01B1: goto L01C0;
            L01B3: ShowMessage(player, String03B6); // All that remains from your battle here is a snapped whisker and splintered claw.
            L01C0: return; // RETURN;
        }

        private void Fn_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
0451  0008 C4 5E 06  les bx, [bp+0x6]
0454  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0018;
            L0015: goto L019F;
            L0018: PushStack(player, 0x01);
            L001C: PushStack(player, 0x03);
            L0020: PushStack(player, ax);
046A  0021 C4 5E 06  les bx, [bp+0x6]
046D  0024 26 FF 1F  call far word [es:bx]
0470  0027 83 C4 06  add sp, 0x6
            L002A: ShowMessage(player, String0407); // At least you can tell that those brain pans can't possibly know how to cast spells against you. 
            L0037: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L004B: if (JumpEqual) goto L0050;
            L004D: goto L00F8;
            L0050: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0064: if (JumpEqual) goto L0069;
            L0066: goto L00F8;
            L0069: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L007D: if (JumpNotEqual) goto L00F8;
            L007F: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L0093: if (JumpNotEqual) goto L00F8;
            L0095: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L00A9: if (JumpNotEqual) goto L00F8;
            L00AB: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L00BF: if (JumpNotEqual) goto L00F8;
            L00C1: ax = HasItem(player, 0xFD);
            L00CF: if (JumpNotEqual) goto L00F8;
            L00D1: ax = IsFlagOn(player, 0x02, 0x20);
            L00E4: if (JumpEqual) goto L00F8;
            L00E6: PushStack(player, 0x7D);
            L00EA: PushStack(player, 0x00);
            L00ED: PushStack(player, ax);
            L00EE: PushStack(player, ax);
            L00EF: PushStack(player, 0xBA);
053C  00F3 B8 FD 00  mov ax, 0xfd
            L00F6: goto L010B;
            L00F8: PushStack(player, 0x7D);
            L00FC: PushStack(player, 0x00);
            L00FF: PushStack(player, ax);
            L0100: PushStack(player, 0xB9);
            L0104: PushStack(player, 0xAC);
            L0108: PushStack(player, 0x14);
0555  010C C4 5E 06  les bx, [bp+0x6]
0558  010F 26 FF 9F D8 00  call far word [es:bx+0xd8]
055D  0114 83 C4 0C  add sp, 0xc
            L0117: AddEncounter(player, 0x01, 0x1F);
            L0129: AddEncounter(player, 0x02, 0x20);
            L013B: Compare(PartyCount(player), 0x0002);
            L0146: if (JumpBelowOrEqual) goto L016C;
            L0148: AddEncounter(player, 0x03, 0x1F);
            L015A: AddEncounter(player, 0x04, 0x20);
            L016C: Compare(PartyCount(player), 0x0003);
            L0177: if (JumpBelowOrEqual) goto L01AC;
            L0179: AddEncounter(player, 0x05, 0x21);
            L018B: AddEncounter(player, 0x06, 0x21);
            L019D: goto L01AC;
            L019F: ShowMessage(player, String0468); // All that remains from your battle here is a broken club and a scrap of fur.
            L01AC: return; // RETURN;
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L01A2;
            L001B: SetFlag(player, 0x03, 0x04, 0x01);
            L0030: ShowMessage(player, String04B4); // Those monsters are not just wyvern hello.
            L003D: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L0051: if (JumpEqual) goto L0056;
            L0053: goto L00FB;
            L0056: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L006A: if (JumpEqual) goto L006F;
            L006C: goto L00FB;
            L006F: PushStack(player, 0x03);
            L0073: PushStack(player, ax);
066B  0074 C4 5E 06  les bx, [bp+0x6]
066E  0077 26 FF 5F 04  call far word [es:bx+0x4]
            L007B: cx = PopStack(player);
            L007C: cx = PopStack(player);
            L007D: Compare(ax, 0x0001);
            L0080: if (JumpNotEqual) goto L00FB;
            L0082: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L0096: if (JumpNotEqual) goto L00FB;
            L0098: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L00AC: if (JumpNotEqual) goto L00FB;
            L00AE: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L00C2: if (JumpNotEqual) goto L00FB;
            L00C4: ax = HasItem(player, 0xFD);
            L00D2: if (JumpNotEqual) goto L00FB;
            L00D4: ax = IsFlagOn(player, 0x02, 0x20);
            L00E7: if (JumpEqual) goto L00FB;
            L00E9: PushStack(player, 0x7D);
            L00ED: PushStack(player, 0x00);
            L00F0: PushStack(player, ax);
            L00F1: PushStack(player, ax);
            L00F2: PushStack(player, 0xBA);
06ED  00F6 B8 FD 00  mov ax, 0xfd
            L00F9: goto L010E;
06F2  00FB B8 B9 03  mov ax, 0x3b9
            L00FE: PushStack(player, ax);
            L00FF: PushStack(player, 0x00);
            L0102: PushStack(player, ax);
            L0103: PushStack(player, 0xB9);
            L0107: PushStack(player, 0xB6);
            L010B: PushStack(player, 0x29);
0706  010F C4 5E 06  les bx, [bp+0x6]
0709  0112 26 FF 9F D8 00  call far word [es:bx+0xd8]
070E  0117 83 C4 0C  add sp, 0xc
            L011A: AddEncounter(player, 0x01, 0x23);
            L012C: AddEncounter(player, 0x05, 0x23);
            L013E: Compare(PartyCount(player), 0x0002);
            L0149: if (JumpBelowOrEqual) goto L016F;
            L014B: AddEncounter(player, 0x02, 0x24);
            L015D: AddEncounter(player, 0x06, 0x24);
            L016F: Compare(PartyCount(player), 0x0003);
            L017A: if (JumpBelowOrEqual) goto L01AF;
            L017C: AddEncounter(player, 0x04, 0x25);
            L018E: AddEncounter(player, 0x03, 0x25);
            L01A0: goto L01AF;
            L01A2: ShowMessage(player, String04DE); // All that remains from your battle here is a broken tooth and a bit of scale.  The scavengers in this place must have cast-iron stomachs.
            L01AF: return; // RETURN;
        }

        private void Fn_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L01BC;
            L001B: SetFlag(player, 0x03, 0x05, 0x01);
            L0030: ShowMessage(player, String0567); // It looks like a whole mobs of halflings.  The question is: do you count their arms and divide by two or four to figure out how many halflings there are?
            L003D: Compare(PartyCount(player), 0x0003);
            L0048: if (JumpBelowOrEqual) goto L0057;
            L004A: ShowMessage(player, String0600); // And whether they are half, full, or quarter, those elves do not look friendly!
            L0057: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L006B: if (JumpEqual) goto L0070;
            L006D: goto L0115;
            L0070: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0084: if (JumpEqual) goto L0089;
            L0086: goto L0115;
            L0089: PushStack(player, 0x03);
            L008D: PushStack(player, ax);
0836  008E C4 5E 06  les bx, [bp+0x6]
0839  0091 26 FF 5F 04  call far word [es:bx+0x4]
            L0095: cx = PopStack(player);
            L0096: cx = PopStack(player);
            L0097: Compare(ax, 0x0001);
            L009A: if (JumpNotEqual) goto L0115;
            L009C: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L00B0: if (JumpNotEqual) goto L0115;
            L00B2: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L00C6: if (JumpNotEqual) goto L0115;
            L00C8: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L00DC: if (JumpNotEqual) goto L0115;
            L00DE: ax = HasItem(player, 0xFD);
            L00EC: if (JumpNotEqual) goto L0115;
            L00EE: ax = IsFlagOn(player, 0x02, 0x20);
            L0101: if (JumpEqual) goto L0115;
            L0103: PushStack(player, 0x7D);
            L0107: PushStack(player, 0x00);
            L010A: PushStack(player, ax);
            L010B: PushStack(player, ax);
            L010C: PushStack(player, 0xBA);
08B8  0110 B8 FD 00  mov ax, 0xfd
            L0113: goto L0128;
08BD  0115 B8 32 02  mov ax, 0x232
            L0118: PushStack(player, ax);
            L0119: PushStack(player, 0x00);
            L011C: PushStack(player, ax);
            L011D: PushStack(player, 0x48);
            L0121: PushStack(player, 0xBD);
            L0125: PushStack(player, 0x3D);
08D1  0129 C4 5E 06  les bx, [bp+0x6]
08D4  012C 26 FF 9F D8 00  call far word [es:bx+0xd8]
08D9  0131 83 C4 0C  add sp, 0xc
            L0134: AddEncounter(player, 0x01, 0x19);
            L0146: AddEncounter(player, 0x05, 0x1A);
            L0158: Compare(PartyCount(player), 0x0002);
            L0163: if (JumpBelowOrEqual) goto L0189;
            L0165: AddEncounter(player, 0x02, 0x19);
            L0177: AddEncounter(player, 0x06, 0x1A);
            L0189: Compare(PartyCount(player), 0x0003);
            L0194: if (JumpBelowOrEqual) goto L01C9;
            L0196: AddEncounter(player, 0x04, 0x1B);
            L01A8: AddEncounter(player, 0x03, 0x1B);
            L01BA: goto L01C9;
            L01BC: ShowMessage(player, String064F); // All that remains from your battle here is a broken goblet and a snapped bow string.
            L01C9: return; // RETURN;
        }

        private void Fn_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L01A5;
            L001B: SetFlag(player, 0x03, 0x06, 0x01);
            L0030: ShowMessage(player, String06A3); // With a faint smell of sulphur and brimstone, you are impressively beset.
            L003D: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L0051: if (JumpEqual) goto L0056;
            L0053: goto L00FB;
            L0056: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L006A: if (JumpEqual) goto L006F;
            L006C: goto L00FB;
            L006F: PushStack(player, 0x03);
            L0073: PushStack(player, ax);
09E7  0074 C4 5E 06  les bx, [bp+0x6]
09EA  0077 26 FF 5F 04  call far word [es:bx+0x4]
            L007B: cx = PopStack(player);
            L007C: cx = PopStack(player);
            L007D: Compare(ax, 0x0001);
            L0080: if (JumpNotEqual) goto L00FB;
            L0082: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L0096: if (JumpNotEqual) goto L00FB;
            L0098: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L00AC: if (JumpNotEqual) goto L00FB;
            L00AE: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L00C2: if (JumpNotEqual) goto L00FB;
            L00C4: ax = HasItem(player, 0xFD);
            L00D2: if (JumpNotEqual) goto L00FB;
            L00D4: ax = IsFlagOn(player, 0x02, 0x20);
            L00E7: if (JumpEqual) goto L00FB;
            L00E9: PushStack(player, 0x7D);
            L00ED: PushStack(player, 0x00);
            L00F0: PushStack(player, ax);
            L00F1: PushStack(player, ax);
            L00F2: PushStack(player, 0xBA);
0A69  00F6 B8 FD 00  mov ax, 0xfd
            L00F9: goto L0111;
            L00FB: AddTreasure(player, 0x007D, 0x00, 0x71, 0x76, 0x73, 0x70);
            L011D: AddEncounter(player, 0x01, 0x1E);
            L012F: AddEncounter(player, 0x05, 0x1C);
            L0141: Compare(PartyCount(player), 0x0002);
            L014C: if (JumpBelowOrEqual) goto L0172;
            L014E: AddEncounter(player, 0x02, 0x1D);
            L0160: AddEncounter(player, 0x06, 0x1C);
            L0172: Compare(PartyCount(player), 0x0003);
            L017D: if (JumpBelowOrEqual) goto L01B2;
            L017F: AddEncounter(player, 0x04, 0x1E);
            L0191: AddEncounter(player, 0x03, 0x1D);
            L01A3: goto L01B2;
            L01A5: ShowMessage(player, String06EC); // All that remains from your battle here is a burnt pack of playing cards and a half melted poker chip.
            L01B2: return; // RETURN;
        }

        private void Fn_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0212;
            L001B: SetFlag(player, 0x03, 0x07, 0x01);
            L0030: ShowMessage(player, String0752); // An unusual combination of creatures has chosen to inhabit this spot.  Maybe you will investigate it later.
            L003D: Compare(PartyCount(player), 0x0003);
            L0048: if (JumpBelowOrEqual) goto L0057;
            L004A: ShowMessage(player, String07BD); // That is, of course, if you survive.
            L0057: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L006B: if (JumpEqual) goto L0070;
            L006D: goto L0115;
            L0070: Compare(GetFlag(player, 0x03, 0x02), 0x0001);
            L0084: if (JumpEqual) goto L0089;
            L0086: goto L0115;
            L0089: PushStack(player, 0x03);
            L008D: PushStack(player, ax);
0BB5  008E C4 5E 06  les bx, [bp+0x6]
0BB8  0091 26 FF 5F 04  call far word [es:bx+0x4]
            L0095: cx = PopStack(player);
            L0096: cx = PopStack(player);
            L0097: Compare(ax, 0x0001);
            L009A: if (JumpNotEqual) goto L0115;
            L009C: Compare(GetFlag(player, 0x03, 0x04), 0x0001);
            L00B0: if (JumpNotEqual) goto L0115;
            L00B2: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L00C6: if (JumpNotEqual) goto L0115;
            L00C8: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L00DC: if (JumpNotEqual) goto L0115;
            L00DE: ax = HasItem(player, 0xFD);
            L00EC: if (JumpNotEqual) goto L0115;
            L00EE: ax = IsFlagOn(player, 0x02, 0x20);
            L0101: if (JumpEqual) goto L0115;
            L0103: PushStack(player, 0x7D);
            L0107: PushStack(player, 0x00);
            L010A: PushStack(player, ax);
            L010B: PushStack(player, ax);
            L010C: PushStack(player, 0xBA);
0C37  0110 B8 FD 00  mov ax, 0xfd
            L0113: goto L012B;
            L0115: AddTreasure(player, 0x007D, 0x00, 0x72, 0x1B, 0x13, 0x5E);
            L0137: AddEncounter(player, 0x01, 0x21);
            L0149: AddEncounter(player, 0x05, 0x28);
            L015B: ax = CheckLevel(player, 0x000C);
            L0169: if (JumpEqual) goto L01CF;
            L016B: Compare(PartyCount(player), 0x0002);
            L0176: if (JumpBelowOrEqual) goto L019C;
            L0178: AddEncounter(player, 0x02, 0x21);
            L018A: AddEncounter(player, 0x06, 0x28);
            L019C: Compare(PartyCount(player), 0x0003);
            L01A7: if (JumpBelowOrEqual) goto L021F;
            L01A9: AddEncounter(player, 0x04, 0x20);
            L01BB: AddEncounter(player, 0x03, 0x20);
            L01CD: goto L021F;
            L01CF: Compare(PartyCount(player), 0x0002);
            L01DA: if (JumpBelowOrEqual) goto L0200;
            L01DC: AddEncounter(player, 0x02, 0x1F);
            L01EE: AddEncounter(player, 0x06, 0x26);
            L0200: Compare(PartyCount(player), 0x0003);
            L020B: if (JumpBelowOrEqual) goto L021F;
0D34  020D B8 1F 00  mov ax, 0x1f
            L0210: goto L01AC;
            L0212: ShowMessage(player, String030C); // All that remains from your battle here is a broken scythe and a scrap of black cloth.
            L021F: return; // RETURN;
        }

        private void Fn_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: ax = GetFlag(player, 0x03, 0x08);
0D62  001A 8B F8  mov di, ax
0D64  001C 47     inc di
0D65  001D 8B F7  mov si, di
            L001F: Compare(si, 0x13);
            L0022: if (JumpLessOrEqual) goto L002B;
0D6C  0024 8B C6  mov ax, si
            L0026: si = ax + 0xFFEC;
            L002B: Compare(si, 0x0E);
            L002E: if (JumpLessOrEqual) goto L0037;
0D78  0030 8B C6  mov ax, si
            L0032: si = ax + 0xFFF1;
            L0037: Compare(si, 0x09);
            L003A: if (JumpLessOrEqual) goto L0043;
0D84  003C 8B C6  mov ax, si
            L003E: si = ax + 0xFFF6;
            L0043: Compare(si, 0x04);
            L0046: if (JumpLessOrEqual) goto L004F;
0D90  0048 8B C6  mov ax, si
            L004A: si = ax + 0xFFFB;
0D97  004F 0B F6  or si, si
0D99  0051 7D 02  jge 0x55
            L0053: si = 0;
            L0055: Compare(si, 0x1D);
            L0058: if (JumpLessOrEqual) goto L005C;
            L005A: si = 0;
0DA4  005C 83 FF 1E  cmp di, 0x1e
            L005F: if (JumpLessOrEqual) goto L0063;
            L0061: di = 0;
0DAB  0063 57     push di
            L0064: PushStack(player, 0x08);
            L0068: PushStack(player, 0x03);
0DB4  006C C4 5E 06  les bx, [bp+0x6]
0DB7  006F 26 FF 1F  call far word [es:bx]
0DBA  0072 83 C4 06  add sp, 0x6
0DBD  0075 83 FF 1A  cmp di, 0x1a
            L0078: if (JumpNotEqual) goto L007F;
0DC2  007A B8 01 00  mov ax, 0x1
            L007D: goto L0081;
            L007F: PushStack(player, 0x00);
0DCA  0082 83 FF 14  cmp di, 0x14
            L0085: if (JumpNotEqual) goto L008C;
0DCF  0087 B8 01 00  mov ax, 0x1
            L008A: goto L008E;
0DD4  008C 33 C0  xor ax, ax
            L008E: dx = PopStack(player);
0DD7  008F 0B D0  or dx, ax
            L0091: PushStack(player, dx);
0DDA  0092 83 FF 0E  cmp di, 0xe
            L0095: if (JumpNotEqual) goto L009C;
0DDF  0097 B8 01 00  mov ax, 0x1
            L009A: goto L009E;
0DE4  009C 33 C0  xor ax, ax
            L009E: dx = PopStack(player);
0DE7  009F 0B D0  or dx, ax
            L00A1: PushStack(player, dx);
0DEA  00A2 83 FF 08  cmp di, 0x8
            L00A5: if (JumpNotEqual) goto L00AC;
0DEF  00A7 B8 01 00  mov ax, 0x1
            L00AA: goto L00AE;
0DF4  00AC 33 C0  xor ax, ax
            L00AE: dx = PopStack(player);
0DF7  00AF 0B D0  or dx, ax
            L00B1: PushStack(player, dx);
0DFA  00B2 83 FF 02  cmp di, 0x2
            L00B5: if (JumpNotEqual) goto L00BC;
0DFF  00B7 B8 01 00  mov ax, 0x1
            L00BA: goto L00BE;
0E04  00BC 33 C0  xor ax, ax
            L00BE: dx = PopStack(player);
0E07  00BF 0B D0  or dx, ax
            L00C1: if (JumpNotEqual) goto L00C6;
            L00C3: goto L02CC;
            L00C6: bx = si;
            L00C8: Compare(bx, 0x04);
            L00CB: if (JumpBelowOrEqual) goto L00D0;
            L00CD: goto L02CC;
            L00D0: switch (bx) {
                case 0:
                    goto L00D7;
                case 1:
                    goto L00E7;
                case 2:
                    goto L012D;
                case 3:
                    goto L01AB;
                case 4:
                    goto L021A;
            }
            L00D7: ShowMessage(player, String07E1); // You hear some footsteps running away.
            L00E4: goto L02CC;
            L00E7: ShowMessage(player, String0807); // You hear someone running towards you.
            L00F4: ShowPortrait(player, 0x001A);
            L0101: ShowMessage(player, String082D); // *
            L010E: ShowMessage(player, String082D); // *
            L011B: ShowMessage(player, String082D); // *
0E70  0128 B8 2F 08  mov ax, 0x82f
            L012B: goto L00DA;
            L012D: ax = CheckLevel(player, 0x0008);
            L013B: if (JumpEqual) goto L014F;
            L013D: ShowPortrait(player, 0x000E);
0E92  014A B8 51 09  mov ax, 0x951
            L014D: goto L00DA;
            L014F: ShowMessage(player, String09EE); // A group of desperate dragons decides to have you for lunch.
            L015C: ShowMessage(player, String0A2A); // That is more of a command performance than an invitation.
            L0169: PushStack(player, 0x0B);
            L016D: PushStack(player, 0x00);
            L0170: PushStack(player, ax);
            L0171: PushStack(player, ax);
            L0172: PushStack(player, ax);
            L0173: PushStack(player, ax);
0EBC  0174 C4 5E 06  les bx, [bp+0x6]
0EBF  0177 26 FF 9F D8 00  call far word [es:bx+0xd8]
0EC4  017C 83 C4 0C  add sp, 0xc
            L017F: AddEncounter(player, 0x01, 0x23);
            L0191: Compare(PartyCount(player), 0x0003);
            L019C: if (JumpAbove) goto L01A1;
            L019E: goto L02CC;
            L01A1: PushStack(player, 0x23);
0EED  01A5 B8 05 00  mov ax, 0x5
            L01A8: goto L02C1;
            L01AB: RefreshCompareFlags(GetFlag(player, 0x02, 0x47));
            L01BE: if (JumpNotEqual) goto L0214;
            L01C0: ShowPortrait(player, 0x0025);
            L01CD: ShowMessage(player, String082D); // *
            L01DA: ShowMessage(player, String082D); // *
            L01E7: ShowMessage(player, String082D); // *
            L01F4: ShowMessage(player, String0A64); // 'I think we have met before.  In sooth, did I not offer thee some wyrmish wampum?  If thou art headed westwards, forewarned is forearmed: undead hold much of the Lesser Hall. 
            L0201: ShowMessage(player, String0B14); // Southwards it is giants and golems and gremlins, oh my!  Be seeing you!
0F56  020E B8 5C 0B  mov ax, 0xb5c
            L0211: goto L00DA;
0F5C  0214 B8 7E 0B  mov ax, 0xb7e
            L0217: goto L00DA;
            L021A: ShowMessage(player, String082D); // *
            L0227: ShowMessage(player, String082D); // *
            L0234: ShowMessage(player, String082D); // *
            L0241: ShowMessage(player, String0BE1); // A somewhat battered horde o'halflings decides, rather insultingly, that they are bigger than you are.
            L024E: PushStack(player, 0x5D);
            L0252: PushStack(player, 0x00);
            L0255: PushStack(player, ax);
            L0256: PushStack(player, ax);
            L0257: PushStack(player, 0xB6);
            L025B: PushStack(player, 0xBD);
0FA7  025F C4 5E 06  les bx, [bp+0x6]
0FAA  0262 26 FF 9F D8 00  call far word [es:bx+0xd8]
0FAF  0267 83 C4 0C  add sp, 0xc
            L026A: AddEncounter(player, 0x01, 0x19);
            L027C: Compare(PartyCount(player), 0x0001);
            L0287: if (JumpBelowOrEqual) goto L029B;
            L0289: AddEncounter(player, 0x05, 0x1A);
            L029B: Compare(PartyCount(player), 0x0002);
            L02A6: if (JumpBelowOrEqual) goto L02CC;
            L02A8: AddEncounter(player, 0x02, 0x19);
            L02BA: AddEncounter(player, 0x06, 0x1A);
            L02CC: return; // RETURN (restoring si, di);
        }

        private void Fn_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L0016: if (JumpNotEqual) goto L006E;
            L0018: SetFlag(player, 0x03, 0x0A, 0x01);
            L002D: ShowPortrait(player, 0x0027);
            L003A: ShowMessage(player, String082D); // *
            L0047: ShowMessage(player, String082D); // *
            L0054: ShowMessage(player, String082D); // *
            L0061: ShowMessage(player, String0C47); // You come upon a dying elf.  His dying words are, 'I know not that I can trust thee, but my news forces the risk.  The Undead Kings have allied with the Picts, and oft where one is found, both are near.'  With a slowly released breath, the elf dies.
            L006E: return; // RETURN;
        }

        private void Fn_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = IsFlagOn(player, 0x00, 0x02);
            L0015: if (JumpEqual) goto L0042;
            L0017: TeleportParty(player, 0x04, 0x01, 0x0A, 0x01, isForwardMove);
            L0032: ShowMessage(player, String0D40); // This must lead to that section of the Gallery that you could not reach before.
            L003F: goto L0256;
            L0042: Compare(HasUsedSkill(player, 0x0D), 0x0006);
            L0051: if (JumpNotBelow) goto L00C6;
            L0053: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0061: if (JumpNotEqual) goto L00C6;
            L0063: PushStack(player, 0xA7);
            L0067: PushStack(player, ax);
10FA  0068 C4 5E 06  les bx, [bp+0x6]
10FD  006B 26 FF 5F 54  call far word [es:bx+0x54]
            L006F: cx = PopStack(player);
            L0070: cx = PopStack(player);
            L0071: RefreshCompareFlags(ax);
            L0073: if (JumpNotEqual) goto L00C6;
            L0075: PushStack(player, 0x93);
            L0079: PushStack(player, ax);
110C  007A C4 5E 06  les bx, [bp+0x6]
110F  007D 26 FF 5F 54  call far word [es:bx+0x54]
            L0081: cx = PopStack(player);
            L0082: cx = PopStack(player);
            L0083: RefreshCompareFlags(ax);
            L0085: if (JumpNotEqual) goto L00C6;
            L0087: PushStack(player, 0x86);
            L008B: PushStack(player, ax);
111E  008C C4 5E 06  les bx, [bp+0x6]
1121  008F 26 FF 5F 54  call far word [es:bx+0x54]
            L0093: cx = PopStack(player);
            L0094: cx = PopStack(player);
            L0095: RefreshCompareFlags(ax);
            L0097: if (JumpNotEqual) goto L00C6;
            L0099: ax = IsFlagOn(player, 0x00, 0x01);
            L00AB: if (JumpNotEqual) goto L00C6;
            L00AD: Compare(GetFlag(player, 0x02, 0x14), 0x0001);
            L00C1: if (JumpEqual) goto L00C6;
            L00C3: goto L0239;
            L00C6: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00E4: PushStack(player, 0x01);
            L00E8: PushStack(player, ax);
            L00E9: PushStack(player, 0x00);
117E  00EC C4 5E 06  les bx, [bp+0x6]
1181  00EF 26 FF 1F  call far word [es:bx]
1184  00F2 83 C4 06  add sp, 0x6
            L00F5: PushStack(player, 0x68);
            L00F9: PushStack(player, ax);
118C  00FA C4 5E 06  les bx, [bp+0x6]
118F  00FD 26 FF 5F 54  call far word [es:bx+0x54]
            L0101: cx = PopStack(player);
            L0102: cx = PopStack(player);
            L0103: RefreshCompareFlags(ax);
            L0105: if (JumpNotEqual) goto L010A;
            L0107: goto L0189;
            L010A: ax = HasItem(player, 0xC1);
            L0118: if (JumpEqual) goto L011D;
            L011A: goto L01EC;
            L011D: ax = HasItem(player, 0xC2);
            L012B: if (JumpEqual) goto L0130;
            L012D: goto L01EC;
            L0130: ax = HasItem(player, 0xC3);
            L013E: if (JumpEqual) goto L0143;
            L0140: goto L01EC;
            L0143: ax = HasItem(player, 0xDA);
            L0151: if (JumpEqual) goto L0156;
            L0153: goto L01EC;
            L0156: ax = HasItem(player, 0xDB);
            L0164: if (JumpEqual) goto L0169;
            L0166: goto L01EC;
            L0169: ax = HasItem(player, 0xDC);
            L0177: if (JumpNotEqual) goto L01EC;
            L0179: ax = HasItem(player, 0xDD);
            L0187: if (JumpNotEqual) goto L01EC;
            L0189: Compare(GetSkillLevel(player, 0x0E), 0x0008);
            L0198: if (JumpBelow) goto L01C4;
            L019A: ax = HasUsedItem(player, 0xC1, 0xC3);
            L01AD: if (JumpNotEqual) goto L01EC;
            L01AF: ax = HasUsedItem(player, 0xDA, 0xDD);
            L01C2: if (JumpNotEqual) goto L01EC;
            L01C4: PushStack(player, 0xC0);
            L01C8: PushStack(player, ax);
125B  01C9 C4 5E 06  les bx, [bp+0x6]
125E  01CC 26 FF 5F 54  call far word [es:bx+0x54]
            L01D0: cx = PopStack(player);
            L01D1: cx = PopStack(player);
            L01D2: RefreshCompareFlags(ax);
            L01D4: if (JumpNotEqual) goto L01EC;
            L01D6: Compare(GetFlag(player, 0x02, 0x14), 0x0001);
            L01EA: if (JumpNotEqual) goto L022A;
            L01EC: ShowMessage(player, String0D8F); // You have unlocked the hidden door!
            L01F9: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0217: PushStack(player, 0x01);
            L021B: PushStack(player, 0x02);
            L021F: PushStack(player, 0x00);
12B4  0222 C4 5E 06  les bx, [bp+0x6]
12B7  0225 26 FF 1F  call far word [es:bx]
            L0228: goto L0253;
            L022A: ShowMessage(player, String0DB2); // You detect a hidden door, but it is locked.
            L0237: goto L0239;
            L0239: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0256: return; // RETURN;
        }

        private void Fn_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x04, 0x01, 0x0D, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void Fn_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x05, 0x01, 0x8F, 0x00, isForwardMove);
            L001D: return; // RETURN;
        }

        private void Fn_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0C));
            L0016: if (JumpNotEqual) goto L003C;
            L0018: ShowMessage(player, String0DDE); // This room is noticeably cooler than the others.  Many wine racks have been toppled and you doubt any bottles remain intact.
            L0025: SetFlag(player, 0x03, 0x0C, 0x01);
            L003A: goto L0055;
            L003C: Compare(GetFacing(player), 0x0002);
            L0046: if (JumpNotEqual) goto L0055;
            L0048: ShowMessage(player, String0E5A); // The wine room remains as you saw it.
            L0055: return; // RETURN;
        }

        private void Fn_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x22));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00B6;
            L001B: Compare(HasUsedSkill(player, 0x0D), 0x0004);
            L002A: if (JumpNotBelow) goto L0072;
            L002C: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L003A: if (JumpNotEqual) goto L0072;
            L003C: PushStack(player, 0xA7);
            L0040: PushStack(player, ax);
13C1  0041 C4 5E 06  les bx, [bp+0x6]
13C4  0044 26 FF 5F 54  call far word [es:bx+0x54]
            L0048: cx = PopStack(player);
            L0049: cx = PopStack(player);
            L004A: RefreshCompareFlags(ax);
            L004C: if (JumpNotEqual) goto L0072;
            L004E: PushStack(player, 0x93);
            L0052: PushStack(player, ax);
13D3  0053 C4 5E 06  les bx, [bp+0x6]
13D6  0056 26 FF 5F 54  call far word [es:bx+0x54]
            L005A: cx = PopStack(player);
            L005B: cx = PopStack(player);
            L005C: RefreshCompareFlags(ax);
            L005E: if (JumpNotEqual) goto L0072;
            L0060: PushStack(player, 0x86);
            L0064: PushStack(player, ax);
13E5  0065 C4 5E 06  les bx, [bp+0x6]
13E8  0068 26 FF 5F 54  call far word [es:bx+0x54]
            L006C: cx = PopStack(player);
            L006D: cx = PopStack(player);
            L006E: RefreshCompareFlags(ax);
            L0070: if (JumpEqual) goto L00B6;
            L0072: SetFlag(player, 0x02, 0x22, 0x01);
            L0087: SetFlag(player, 0x03, 0x14, 0x01);
            L009C: ShowMessage(player, String0E7F); // Yoicks!  Under the influence of your poking and prodding, something round makes a rolling escape from this pile of rubble to the north.
            L00A9: ShowMessage(player, String0F07); // You've chased enough bashful bottles in your day to recognise the sound of one that's intact.
            L00B6: return; // RETURN;
        }

        private void Fn_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0D));
            L0016: if (JumpNotEqual) goto L003C;
            L0018: ShowMessage(player, String0F65); // This room is full of broken bins of oatmeal, no doubt long since gone into the bellies of rats and, you shudder as the thought occurs to you, into haggis.
            L0025: SetFlag(player, 0x03, 0x0D, 0x01);
            L003A: goto L0055;
            L003C: Compare(GetFacing(player), 0x0002);
            L0046: if (JumpNotEqual) goto L0055;
            L0048: ShowMessage(player, String1000); // The oat room remains as you saw it.
            L0055: return; // RETURN;
        }

        private void Fn_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0E));
            L0016: if (JumpNotEqual) goto L003C;
            L0018: ShowMessage(player, String1024); // There are many still sealed barrels labelled with the words 'Best Southfarthing Barley.'  Having nothing to carry it in, you decide not to take it.
            L0025: SetFlag(player, 0x03, 0x0E, 0x01);
            L003A: goto L0054;
            L003C: RefreshCompareFlags(GetFacing(player));
            L0045: if (JumpNotEqual) goto L0054;
            L0047: ShowMessage(player, String10B8); // The barley room remains as you saw it.
            L0054: return; // RETURN;
        }

        private void Fn_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L0016: if (JumpNotEqual) goto L003C;
            L0018: ShowMessage(player, String10DF); // This room contains many intact barrels labelled 'Best Bitter Hops.'  Maybe there's a brewery somewhere.
            L0025: SetFlag(player, 0x03, 0x0F, 0x01);
            L003A: goto L0054;
            L003C: RefreshCompareFlags(GetFacing(player));
            L0045: if (JumpNotEqual) goto L0054;
            L0047: ShowMessage(player, String1147); // The hops room remains as you saw it.
            L0054: return; // RETURN;
        }

        private void Fn_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x10));
            L0016: if (JumpNotEqual) goto L003C;
            L0018: ShowMessage(player, String116C); // This room contains many intact sacks of rye, stored on shelves behind thick walls and doors to protect them from the rats.  Maybe there's a distillery in the vicinity.
            L0025: SetFlag(player, 0x03, 0x10, 0x01);
            L003A: goto L0055;
            L003C: Compare(GetFacing(player), 0x0002);
            L0046: if (JumpNotEqual) goto L0055;
            L0048: ShowMessage(player, String1214); // The rye room remains as you saw it.
            L0055: return; // RETURN;
        }

        private void Fn_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x11));
            L0016: if (JumpNotEqual) goto L0049;
            L0018: ShowMessage(player, String1238); // This large room is full of reasonably fresh bins of vegetables: carrots, onions, peas, turnips, all sealed for the winter.  A sign on one wall reads, 'Take as you please our parsnips and peas, but prithee, take no leek.
            L0025: ShowMessage(player, String1314); // Greengrocer humor: the worst.
            L0032: SetFlag(player, 0x03, 0x11, 0x01);
            L0047: goto L0062;
            L0049: Compare(GetFacing(player), 0x0003);
            L0053: if (JumpNotEqual) goto L0062;
            L0055: ShowMessage(player, String1332); // The grocery room remains as you saw it.
            L0062: return; // RETURN;
        }

        private void Fn_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x12));
            L0016: if (JumpNotEqual) goto L0049;
            L0018: ShowMessage(player, String135A); // This cold cold room is full of hanging sides of beef, mutton, chickens and ducks.  You never sausage a place (sorry).  A sign on one wall reads, 'Cuz, thou may take a chicken or steak, but prithee, pluck no duck.'
            L0025: ShowMessage(player, String1430); // Butcher humor: the wurst.
            L0032: SetFlag(player, 0x03, 0x12, 0x01);
            L0047: goto L0062;
            L0049: Compare(GetFacing(player), 0x0001);
            L0053: if (JumpNotEqual) goto L0062;
            L0055: ShowMessage(player, String144A); // The butcher's room remains as you saw it.
            L0062: return; // RETURN;
        }

        private void Fn_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x13));
            L0016: if (JumpNotEqual) goto L0049;
            L0018: ShowMessage(player, String1474); // This large room is well stocked with fruits of all kinds: apples, berries, cherries, limes, lemons.  A sign on one wall reads, 'Friend, if you dare you may snare thee a pear, but prithee, partake not of the deadly nightshade.' The bin labelled nightshade appears to hold tomatoes.
            L0025: ShowMessage(player, String158D); // Orange you glad fruit mongers have no sense of humor?
            L0032: SetFlag(player, 0x03, 0x13, 0x01);
            L0047: goto L0062;
            L0049: Compare(GetFacing(player), 0x0001);
            L0053: if (JumpNotEqual) goto L0062;
            L0055: ShowMessage(player, String15C3); // The fruit mongers room remains as you saw it.
            L0062: return; // RETURN;
        }

        private void Fn_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String15F1); // The plaque reads: 'Never eat a dragon's egg when a dragon is nearby.'
            L0010: return; // RETURN;
        }

        private void Fn_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1637); // The plaque reads: 'A light white wine is appropriate to serve with halflings on toast.'
            L0010: return; // RETURN;
        }

        private void Fn_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String168F); // The plaque reads: 'You can't oversalt a pickle.'
            L0010: return; // RETURN;
        }

        private void Fn_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String16C0); // The plaque reads: 'Ware the deadly nightshade, save with fish and chips.'
            L0010: return; // RETURN;
        }

        private void Fn_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String170A); // The plaque reads: 'Be thou not hasty when cooking thy pasty.  Cooked low and slow is the best way to go.'
            L0010: return; // RETURN;
        }

        private void Fn_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1774); // The plaque reads: 'Chicken soup may do marvels for a sick person, but it does nothing for the chicken.'
            L0010: return; // RETURN;
        }

        private void Fn_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String17DC); // The plaque reads: 'Harpy: the other other white meat.'
            L0010: return; // RETURN;
        }

        private void Fn_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1813); // The plaque reads: 'If you invite a vampire to dinner, it is a grievous breach of etiquette to serve stake.'
            L0010: return; // RETURN;
        }

        private void Fn_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String187F); // The plaque reads: 'When dining with zombies, if a bit of your dinner companion should fall off, simply pick it up in a napkin and dispose of it without fuss.'
            L0010: return; // RETURN;
        }

        private void Fn_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String191E); // The plaque reads: 'When planning a dinner party for dragons, use this simple rule of thumb: twelve pounds of meat for every ten feet of the dragon's length.
            L0010: return; // RETURN;
        }

        private void Fn_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String19BB); // The plaque reads: 'If a harpy informs you that some food or drink has turned, believe her.'
            L0010: return; // RETURN;
        }

        private void Fn_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1A17); // The plaque reads: 'Hellhounds prefer their meat raw.  They will char it themselves to taste.  Dragons may or may not choose to do so; it is best to include such a query with the invitation.'
            L0010: return; // RETURN;
        }

        private void Fn_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1AD6); // The plaque reads: 'When inviting dragons to a barbeque, be sure to specify whether you are inviting dinner or guests.'
            L0010: return; // RETURN;
        }

        private void Fn_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1B4D); // The plaque reads: 'It is unwise to invite skeletons and hellhounds to the same meal.  It is beyond the pale to do so and call out Bury!'
            L0010: return; // RETURN;
        }

        private void Fn_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1BD6); // The plaque reads: 'One should plan on ghosts consuming about one tenth as much as a humanoid guest.  But they will invariably consume ten times as much spirits.'
            L0010: return; // RETURN;
        }

        private void Fn_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1C78); // The plaque reads: 'Polite slimes will wait until your other guests have finished before consuming the table scraps.  Impolite slimes will consider your other guests table scraps.'
            L0010: return; // RETURN;
        }

        private void Fn_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1D2C); // The plaque reads: 'Most imps enjoy a large, even an excessive quantity of garlic.  Most undead don't.'
            L0010: return; // RETURN;
        }

        private void Fn_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1D93); // The plaque reads: 'If a giant should forget his manners and begin eating his neighbors, rap his knuckles firmly and be prepared to flee.  It is wise, therefore, to seat your less desirable guests near the giants.'
            L0010: return; // RETURN;
        }

        private void Fn_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1E69); // The plaque reads: 'Dragons are very sensitive about their etiquette.  They believe you should consider yourself fortunate that they are not eating you.  Any corrections of a dragon's etiquette is likely to lead to a correction of that oversight.'
            L0010: return; // RETURN;
        }

        private void Fn_36(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1F60); // The plaque reads: 'Golems are obedient and do not eat.  As such, they make excellent last minute replacements for cancellations.  A wise hostess will keep one in her closet for emergencies.'
            L0010: return; // RETURN;
        }

        private void Fn_37(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String201F); // The plaque reads: 'It is unwise to invite medusae and bats to the same function.  The bats are sure to get caught in the medusa's hair.  Once that happens, either way, you may be sure that someone will have to write a note of apology.'
            L0010: return; // RETURN;
        }

        private void Fn_38(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String210B); // The plaque reads: 'It is not preferred to have hedgepigs both on the guest list and on a platter.'
            L0010: return; // RETURN;
        }

        private void Fn_39(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String216E); // The plaque reads: 'It is a little known fact that you can safely serve beef to minotaurs without offending them, unless they happen to be vegetarians.'
            L0010: return; // RETURN;
        }

        private void Fn_3A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String2206); // The plaque reads: 'A wise hostess will move discretely upwind if a dragon appears about to belch.'
            L0010: return; // RETURN;
        }

        private void Fn_3B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String2269); // The plaque reads: 'Virtually none of the inhabitants of Cawdor are offended when you serve harpy at your functions.  Few have the stomach to eat harpy, but none are offended.'
            L0010: return; // RETURN;
        }

    }
}
