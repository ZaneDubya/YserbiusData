#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap17 : AMapScripted {
        protected override int MapIndex => 17;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 1;

        public YserMap17() {
            MapEvent01 = Fn_01;
            MapEvent02 = Fn_02;
            MapEvent03 = Fn_03;
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
        }
        
        // === Strings ================================================
        private const string String0140 = "I guess you weren't above stealing a spoon.  You find six gold pieces worth of random silverware.";
        private const string String01A2 = "But you sure feel bad doing it.  Cheap, somehow.  As if it is beneath the dignity of your profession to be reduced to filching forks.";
        private const string String0228 = "You have unlocked the hidden door!";
        private const string String024B = "Your lockpick is no more.  It has ceased to key.  It's a stick.  Bereft of heft, it rests in pieces.  This is an ex-lockpick.";
        private const string String02C9 = "You detect a hidden door, but it is locked.";
        private const string String02F5 = "That was a stiff lock, but you finally got it open.";
        private const string String0329 = "Funny how an irksome little lock on a flimsy little door can keep out a big strong person like you.";
        private const string String038D = "You find some tracks indicating that something headed off this way.";
        private const string String03D1 = "You hear some footsteps running away.";
        private const string String03F7 = "You hear someone staggering towards you.";
        private const string String0420 = "A happy halfling knight doffs his cap in your general direction.  Or perhaps that should be a halfling aleknight.";
        private const string String0492 = "'By my stars and HIC! garters!  This is a great place, is it not?  No matter how much I drink in the cooling room, they keep on putting out more.  I will say this for the Lords of Cawdor: they keep a fine cellar.'";
        private const string String0568 = "The halfling wobbles off, happily.";
        private const string String058B = "The dragon opens his mouth wide, and as you cower in terror, issues forth a tremendous belch.";
        private const string String05E9 = "'What fears thee so?  I am but taking my constitutional.  There is so much food here that I need not prey on thee.  But I must walk frequently lest I not fit through the doors.  Adieu, little one, adieu.'";
        private const string String06B6 = "Somehow, now that he's gone, the Prunes of Cawdor that Rory told you about will seem less, well, pruney.";
        private const string String071F = "'Ah!  Mine bosom companions, chums, friends of great worth!  I am most cheered to see thee, for I have learned that in this very Kitchen one can find The Prunes of Cawdor!";
        private const string String07CB = "Used with wit and wisdom, they make certain monsters run away.  'S'truth!  As true as my name is Rory Applebush!  Good seeking!'";
        private const string String084C = "Rory struts off, smiling.";
        private const string String0866 = "A clutch of clerics decides that they must preach at you of the Gospel of the Bigger Stick!";
        private const string String08C2 = "A cold breeze sends shivers down your spine.";
        private const string String08EF = "The power of the dagger you are holding lifts you above the acidic waters of The Dissolving Pool.";
        private const string String0951 = "Ohthere's Dagger glows, as if it wants to help you, but it seems ineffective from its current location.";
        private const string String09B9 = "Those boiling hot acidic waters really sting!";
        private const string String09E7 = "The Dissolving Pool continues to work its unpleasant will upon you.";
        private const string String0A2B = "This isn't good.  The hot waters of the Dissolving Pool have cracked all your potion bottles!";
        private const string String0A89 = "Banquo's ghost is through that door.  If you go through, you better go through fast and low.  The military mastermind that arranged this little steambath is sure to have an ambush waiting.";
        private const string String0B46 = "This room is filled with bins.  The bins are filled with flour.";
        private const string String0B86 = "This room is filled with bins.  The bins are filled with sugar.";
        private const string String0BC6 = "This room is filled with bins.  The bins are filled with salt.";
        private const string String0C05 = "This room is filled with bins.  The bins are filled with pepper.";
        private const string String0C46 = "This room is filled with barrels.  The barrels are filled with ale.";
        private const string String0C8A = "This room is filled with barrels and jars.  They are filled with pickled vegetables and preserves.";
        private const string String0CED = "This is one hot room.  The center aisle is stacked high with cords of firewood, mostly oak.  On the east and west walls are huge fireplaces, heating something (you assume ovens) in the room beyond.  The fires are being stoked by skeletons who glare unfriendlily towards you.";
        private const string String0E00 = "Oh, all right; it's impossible to tell just how a skeleton is glaring, but sure as shooting you wouldn't want to get stuck in the subway after dark with these guys.";
        private const string String0EA5 = "Yes, it's a group of lumbar lumberjacks, with more regenerating right next door!  And to top it off, they don't appear to be affected by the stifling heat in here the way you are.";
        private const string String0F59 = "In wisdom or great folly you enter the flames, and let me tell you, it sure is warm in here!  About 5000 hit points warm!";
        private const string String0FD3 = "Wait for it!";
        private const string String0FE0 = "**********";
        private const string String0FEB = "My money's on folly, but what do I know?";
        private const string String1014 = "If you wanted to kill yourself, couldn't you have found a gas oven?  These ovens are too hot to be comfortable, and, like I said, they are empty and uninteresting.";
        private const string String10B8 = "Look, mate, it's an oven.  It gets hot.  Very hot.  You put things in it and they get cooked.  Like you are getting cooked right now.  Would I lie to you?";
        private const string String1153 = "All right, all right.  Yes, I would lie to you.  But I'm not lying to you now.  This is a hot hot oven.  Nothing more.  Nothing less.";
        private const string String11D9 = "Through a leaded glass window in the oven doors you can see a hot oven glowing cheerily.  The doors are very warm to your touch, enough to inflict a slight burn.  The oven is empty and uninteresting.";
        private const string String12A1 = "There is a noticeable chill in the air.  This room is filled with countertops and chopping blocks, and many frozen pieces of meat have been set out to thaw.  There are also some jugs of cider and a few bottles of wine set out to chill.  The chill seems to radiate from the east wall.";
        private const string String13BD = "The sign on the door reads: 'The Freezer.'";
        private const string String13E8 = "Boy, is it cold in here!  The entire south and east walls are packed with ice, some of which has been chipped off for personal use, no doubt.";
        private const string String1476 = "Many kinds of foodstuffs, including sides of beef, several types of plucked poultry, hogs, sheep, and fish, are stored in here, as well as many things you do not recognise.  Whoever stocked this freezer has a good appetite and a better purse.";
        private const string String1569 = "Now that you've adjusted a bit, you realize that the bitter cold is enough to wound you.";
        private const string String15C2 = "How nice.  That spook wants to play, and is throwing a snowball at you.";
        private const string String160A = "Gadzooks!  That's no snowball.  That's a fireball!";
        private const string String163D = "The way you splattered those spooks, maybe they were slowed down a bit by the cold.  Speaking of which, it is still cold enough to hurt here.";
        private const string String16CB = "The good news is that the undead think this is a cool place to hang out.  The bad news is that the undead think you are uncool.";
        private const string String174B = "You fought the undead, but kept your cool.  In fact, you kept it a tad too cool.";
        private const string String179C = "It sure is cold in here.";
        private const string String17B5 = "That's better!  Even though you are right next to the blocks of ice, it doesn't hurt any more.  That is better, isn't it?";
        private const string String182F = "This room is filled with implements of mixing: bowls, spoons, whippers, mortars and pestles, of different sizes.";
        private const string String18A0 = "A small sign posted on the door to the north reads: 'Warning.  The spice room is specially enmagicked to eliminate all unsealed strong odors, lest they contaminate the spices.";
        private const string String1950 = "Tchee!  A bunch of vampires invite you to dinner, and you don't have any garlic to bring them!";
        private const string String19AF = "The scratches on your gorget are all that remind you of the vampires you fought here.";
        private const string String1A05 = "This room is filled with implements of kneading: rolling pins, boards, big rising bowls, containers holding many types of flour, atomizers, etc.";
        private const string String1A96 = "This room is filled with implements of confectionary: small double boilers, frosting appliers, sugars and nuts of every variety, and several types of chocolate.";
        private const string String1B37 = "This room is filled with crockpots and staples.  Turnips, parsnips, potatoes, onions, carrots, peas, and most every kind of root vegetable simmer in a plethora of pots.  In fact, the atmosphere in here is rather soupy.";
        private const string String1C12 = "This is the way back to the Chambers.";
        private const string String1C38 = "This room is filled with implements of saladizing.  There are six different types of lettuce washers.  There are collanders, and carrot peelers, and intricate little tools that turn radishes into lovely garnishes, yum yum.";
        private const string String1D17 = "Right.  Too much time in the kitchen.  Sigh....";
        private const string String1D47 = "This is where they prepare the meat prior to using or freezing it.  A number of processes far too detailed to pass INN's Community Standards are in various states of completion.  It's enough to make you consider becoming a vegetarian.";
        private const string String1E32 = "This is a normal, run of the mill, multipurpose kitchen room, adaptable to any requirement.";
        private const string String1E8E = "Boy, is this a big room!  Most of the west end is filled with implements of washing.  There are oodles of silverware and boodles of flatware prepared in hutches and on shelves along the south wall, ready to be loaded onto the many trolleys and taken, well, somewhere else.";
        private const string String1F9F = "Of course, we know you are far too honest to consider knicking the cutlery, eh?";
        private const string String1FEF = "This must have good salads here, because they have attracted a party of adventurers.  Unfortunately, the adventurers want to fight you for the table.";
        private const string String2085 = "All that remains of your battle here are some crushed croutons and a crumble of blue cheese.";
        private const string String20E2 = "It isn't hard to figure out that all this meat is what has lured those dogs and cats here.  It's just a shame that they seem to prefer adventurers to beef.  You must be the other other white meat.";
        private const string String21A7 = "All that remains of the battle you fought here is enough animal fur to clog an allergic titan.";
        private const string String2206 = "It's an aerial assault!";
        private const string String221E = "The battle you fought here showed that you were just a tad more impressive than those imps.";
        private const string String227A = "You didn't want to fight imps?  Well, that's what you pict.";
        private const string String22B6 = "Some short adventurers hold the door for you.";
        private const string String22E4 = "'Well met!  There are enough undead in there for all of us, and some giants and dragons as well.  May providence smile upon thy works.'";
        private const string String236C = "Not another locked door!  This one leads to The Cabinet, or at least it would if you had the right combination of people to get it open.";
        private const string String23F5 = "Oh, come on.  You had to figure out at least a level down that some of these rooms require names acronymically defined before they'll let you in the first time.";
        private const string String2496 = "You didn't?  You mean I just told you?  Oh dear.  Would you mind not mentioning this to any of the other computers?  It can be our secret.  You wouldn't want me to look bad, would you?";
        private const string String254F = "Oh.  Cool!  You're pretending you don't know you need a Cleric, Barbarian, and Thief to enter the Cabinet so nobody will suspect that I gave away the secret of those types of puzzles.";
        private const string String2607 = "Don't worry!  To reward you, I won't make any more of those upstairs.";
        private const string String264D = "Deep in a cabinet, hidden behind many bottles, you spot a glimpse of blue.  You investigate further, and find an unused bottle of Woad Wine.  Nasty stuff, Woad Wine, but it sure restores the mana points!";
        private const string String2719 = "Buried in the salt you find something worth far more than its weight in salt.  It's a palace chalice!";
        private const string String277F = "Wait a second.  Those are no pickles.  They must be the legendary Prunes of Cawdor!";
        private const string String27D3 = "UìV¾";
        private const string String27DA = "é¤3ÀP¸
";
        private const string String27E3 = "P¸";
        private const string String27E7 = "PÄ^&ÿÄ¸¸";
        private const string String27F4 = "PÄ^&ÿ_PYÀt!¸";
        private const string String2804 = "P¸
";
        private const string String2808 = "P¸";
        private const string String280C = "PÄ^&ÿÄ¸¸";
        private const string String2819 = "PÄ^&ÿ_LY¸¹";
        private const string String2825 = "PÄ^&ÿ_PYÀt!¸";
        private const string String2835 = "P¸
";
        private const string String2839 = "P¸";
        private const string String283D = "PÄ^&ÿÄ¸¹";
        private const string String284A = "PÄ^&ÿ_LY¸º";
        private const string String2856 = "PÄ^&ÿ_PYÀt!¸";
        private const string String2866 = "P¸
";
        private const string String286A = "P¸";
        private const string String286E = "PÄ^&ÿÄ¸º";
        private const string String287B = "PÄ^&ÿ_LY¸»";
        private const string String2887 = "PÄ^&ÿ_PYÀt!¸";
        private const string String2897 = "P¸
";
        private const string String289B = "P¸";
        private const string String289F = "PÄ^&ÿÄ¸»";
        private const string String28AC = "PÄ^&ÿ_LY¸Ä";
        private const string String28B8 = "PÄ^&ÿ_PYÀt!¸";
        private const string String28C8 = "P¸
";
        private const string String28CC = "P¸";
        private const string String28D0 = "PÄ^&ÿÄ¸Ä";
        private const string String28DD = "PÄ^&ÿ_LY¸Å";
        private const string String28E9 = "PÄ^&ÿ_PYÀt!¸";
        private const string String28F9 = "P¸
";
        private const string String28FD = "P¸";
        private const string String2901 = "PÄ^&ÿÄ¸Å";
        private const string String290E = "PÄ^&ÿ_LY¸Æ";
        private const string String291A = "PÄ^&ÿ_PYÀt!¸";
        private const string String292A = "P¸
";
        private const string String292E = "P¸";
        private const string String2932 = "PÄ^&ÿÄ¸Æ";
        private const string String293F = "PÄ^&ÿ_LY¸Ç";
        private const string String294B = "PÄ^&ÿ_PYÀt!¸";
        private const string String295B = "P¸
";
        private const string String295F = "P¸";
        private const string String2963 = "PÄ^&ÿÄ¸Ç";
        private const string String2970 = "PÄ^&ÿ_LY¸Ë";
        private const string String297C = "PÄ^&ÿ_PYÀt!¸";
        private const string String298C = "P¸
";
        private const string String2990 = "P¸";
        private const string String2994 = "PÄ^&ÿÄ¸Ë";
        private const string String29A1 = "PÄ^&ÿ_LY¸Ì";
        private const string String29AD = "PÄ^&ÿ_PYÀt!¸";
        private const string String29BD = "P¸
";
        private const string String29C1 = "P¸";
        private const string String29C5 = "PÄ^&ÿÄ¸Ì";
        private const string String29D2 = "PÄ^&ÿ_LY¸Í";
        private const string String29DE = "PÄ^&ÿ_PYÀt!¸";
        private const string String29EE = "P¸
";
        private const string String29F2 = "P¸";
        private const string String29F6 = "PÄ^&ÿÄ¸Í";
        private const string String2A03 = "PÄ^&ÿ_LY¸Î";
        private const string String2A0F = "PÄ^&ÿ_PYÀt!¸";
        private const string String2A1F = "P¸
";
        private const string String2A23 = "P¸";
        private const string String2A27 = "PÄ^&ÿÄ¸Î";
        private const string String2A34 = "PÄ^&ÿ_LY¸
";
        private const string String2A40 = "P¸";
        private const string String2A44 = "PÄ^&ÿ_YY=";
        private const string String2A51 = "u¸";
        private const string String2A56 = "P¸";
        private const string String2A5A = "P¸";
        private const string String2A5E = "PÄ^&ÿÄ¸
";
        private const string String2A6B = "P¸";
        private const string String2A6F = "PÄ^&ÿ_YYÀu¾";
        private const string String2A80 =         
        // === Functions ================================================
        private void Fn_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x0004);
            L0012: if (JumpNotBelow) goto L006C;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L006C;
            L0024: PushStack(player, 0x67);
            L0028: PushStack(player, ax);
0035  0029 C4 5E 06  les bx, [bp+0x6]
0038  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L006C;
            L0036: PushStack(player, 0x61);
            L003A: PushStack(player, ax);
0047  003B C4 5E 06  les bx, [bp+0x6]
004A  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L006C;
            L0048: PushStack(player, 0x93);
            L004C: PushStack(player, ax);
0059  004D C4 5E 06  les bx, [bp+0x6]
005C  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L006C;
            L005A: PushStack(player, 0x86);
            L005E: PushStack(player, ax);
006B  005F C4 5E 06  les bx, [bp+0x6]
006E  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpEqual) goto L00B5;
            L006C: ShowMessage(player, String0140); // I guess you weren't above stealing a spoon.  You find six gold pieces worth of random silverware.
            L0079: ModifyGold(player, 0x0006);
            L008A: Compare(GetGuild(player), 0x0003);
            L0094: if (JumpEqual) goto L00B5;
            L0096: ShowMessage(player, String01A2); // But you sure feel bad doing it.  Cheap, somehow.  As if it is beneath the dignity of your profession to be reduced to filching forks.
            L00A3: AddExperience(player, 0xFFFFFE0C);
            L00B5: return; // RETURN;
        }

        private void Fn_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x0009);
            L0012: if (JumpNotBelow) goto L0083;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L0083;
            L0024: PushStack(player, 0x67);
            L0028: PushStack(player, ax);
00EC  0029 C4 5E 06  les bx, [bp+0x6]
00EF  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L0083;
            L0036: PushStack(player, 0x61);
            L003A: PushStack(player, ax);
00FE  003B C4 5E 06  les bx, [bp+0x6]
0101  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L0083;
            L0048: PushStack(player, 0x93);
            L004C: PushStack(player, ax);
0110  004D C4 5E 06  les bx, [bp+0x6]
0113  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L0083;
            L005A: PushStack(player, 0x86);
            L005E: PushStack(player, ax);
0122  005F C4 5E 06  les bx, [bp+0x6]
0125  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpNotEqual) goto L0083;
            L006C: ax = IsFlagOn(player, 0x00, 0x01);
            L007E: if (JumpNotEqual) goto L0083;
            L0080: goto L020C;
            L0083: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00A1: PushStack(player, 0x01);
            L00A5: PushStack(player, ax);
            L00A6: PushStack(player, 0x00);
016C  00A9 C4 5E 06  les bx, [bp+0x6]
016F  00AC 26 FF 1F  call far word [es:bx]
0172  00AF 83 C4 06  add sp, 0x6
            L00B2: PushStack(player, 0x68);
            L00B6: PushStack(player, ax);
017A  00B7 C4 5E 06  les bx, [bp+0x6]
017D  00BA 26 FF 5F 54  call far word [es:bx+0x54]
            L00BE: cx = PopStack(player);
            L00BF: cx = PopStack(player);
            L00C0: RefreshCompareFlags(ax);
            L00C2: if (JumpEqual) goto L012A;
            L00C4: ax = HasItem(player, 0xC2);
            L00D2: if (JumpEqual) goto L00D7;
            L00D4: goto L0174;
            L00D7: ax = HasItem(player, 0xC3);
            L00E5: if (JumpEqual) goto L00EA;
            L00E7: goto L0174;
            L00EA: ax = HasItem(player, 0xDA);
            L00F8: if (JumpNotEqual) goto L0174;
            L00FA: ax = HasItem(player, 0xDB);
            L0108: if (JumpNotEqual) goto L0174;
            L010A: ax = HasItem(player, 0xDC);
            L0118: if (JumpNotEqual) goto L0174;
            L011A: ax = HasItem(player, 0xDD);
            L0128: if (JumpNotEqual) goto L0174;
            L012A: Compare(GetSkillLevel(player, 0x0E), 0x0009);
            L0139: if (JumpBelow) goto L0162;
            L013B: PushStack(player, 0xC3);
            L013F: PushStack(player, ax);
0203  0140 C4 5E 06  les bx, [bp+0x6]
0206  0143 26 FF 5F 54  call far word [es:bx+0x54]
            L0147: cx = PopStack(player);
            L0148: cx = PopStack(player);
            L0149: RefreshCompareFlags(ax);
            L014B: if (JumpNotEqual) goto L0174;
            L014D: ax = HasUsedItem(player, 0xDA, 0xDD);
            L0160: if (JumpNotEqual) goto L0174;
            L0162: PushStack(player, 0xC0);
            L0166: PushStack(player, ax);
022A  0167 C4 5E 06  les bx, [bp+0x6]
022D  016A 26 FF 5F 54  call far word [es:bx+0x54]
            L016E: cx = PopStack(player);
            L016F: cx = PopStack(player);
            L0170: RefreshCompareFlags(ax);
            L0172: if (JumpEqual) goto L0187;
            L0174: ShowMessage(player, String0228); // You have unlocked the hidden door!
0244  0181 B8 01 00  mov ax, 0x1
            L0184: goto L020E;
            L0187: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L01A4: ax = HasUsedItem(player, 0xC1, 0xC2);
            L01B7: if (JumpEqual) goto L01E0;
            L01B9: RemoveItem(player, 0xC1);
            L01C5: RemoveItem(player, 0xC2);
            L01D1: ShowMessage(player, String024B); // Your lockpick is no more.  It has ceased to key.  It's a stick.  Bereft of heft, it rests in pieces.  This is an ex-lockpick.
            L01DE: goto L0229;
            L01E0: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L01FD: ShowMessage(player, String02C9); // You detect a hidden door, but it is locked.
            L020A: goto L0229;
            L020C: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0229: return; // RETURN;
        }

        private void Fn_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x68);
            L0007: PushStack(player, ax);
02F6  0008 C4 5E 06  les bx, [bp+0x6]
02F9  000B 26 FF 5F 54  call far word [es:bx+0x54]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L007B;
            L0015: ax = HasItem(player, 0xC2);
            L0023: if (JumpEqual) goto L0028;
            L0025: goto L00C5;
            L0028: ax = HasItem(player, 0xC3);
            L0036: if (JumpEqual) goto L003B;
            L0038: goto L00C5;
            L003B: ax = HasItem(player, 0xDA);
            L0049: if (JumpNotEqual) goto L00C5;
            L004B: ax = HasItem(player, 0xDB);
            L0059: if (JumpNotEqual) goto L00C5;
            L005B: ax = HasItem(player, 0xDC);
            L0069: if (JumpNotEqual) goto L00C5;
            L006B: ax = HasItem(player, 0xDD);
            L0079: if (JumpNotEqual) goto L00C5;
            L007B: Compare(GetSkillLevel(player, 0x0E), 0x0009);
            L008A: if (JumpBelow) goto L00B3;
            L008C: PushStack(player, 0xC3);
            L0090: PushStack(player, ax);
037F  0091 C4 5E 06  les bx, [bp+0x6]
0382  0094 26 FF 5F 54  call far word [es:bx+0x54]
            L0098: cx = PopStack(player);
            L0099: cx = PopStack(player);
            L009A: RefreshCompareFlags(ax);
            L009C: if (JumpNotEqual) goto L00C5;
            L009E: ax = HasUsedItem(player, 0xDA, 0xDD);
            L00B1: if (JumpNotEqual) goto L00C5;
            L00B3: PushStack(player, 0xC0);
            L00B7: PushStack(player, ax);
03A6  00B8 C4 5E 06  les bx, [bp+0x6]
03A9  00BB 26 FF 5F 54  call far word [es:bx+0x54]
            L00BF: cx = PopStack(player);
            L00C0: cx = PopStack(player);
            L00C1: RefreshCompareFlags(ax);
            L00C3: if (JumpEqual) goto L00F2;
            L00C5: ShowMessage(player, String02F5); // That was a stiff lock, but you finally got it open.
            L00D2: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L00F0: goto L016B;
            L00F2: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L010F: ax = HasUsedItem(player, 0xC1, 0xC2);
            L0122: if (JumpEqual) goto L0141;
            L0124: RemoveItem(player, 0xC1);
            L0130: RemoveItem(player, 0xC2);
042A  013C B8 4B 02  mov ax, 0x24b
            L013F: goto L0161;
            L0141: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L015E: ShowMessage(player, String0329); // Funny how an irksome little lock on a flimsy little door can keep out a big strong person like you.
            L016B: return; // RETURN;
        }

        private void Fn_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0B), 0x0009);
            L0012: if (JumpNotBelow) goto L0038;
            L0014: PushStack(player, 0x62);
            L0018: PushStack(player, ax);
0474  0019 C4 5E 06  les bx, [bp+0x6]
0477  001C 26 FF 5F 54  call far word [es:bx+0x54]
            L0020: cx = PopStack(player);
            L0021: cx = PopStack(player);
            L0022: RefreshCompareFlags(ax);
            L0024: if (JumpNotEqual) goto L0038;
            L0026: PushStack(player, 0x8F);
            L002A: PushStack(player, ax);
0486  002B C4 5E 06  les bx, [bp+0x6]
0489  002E 26 FF 5F 54  call far word [es:bx+0x54]
            L0032: cx = PopStack(player);
            L0033: cx = PopStack(player);
            L0034: RefreshCompareFlags(ax);
            L0036: if (JumpEqual) goto L005A;
            L0038: ShowMessage(player, String038D); // You find some tracks indicating that something headed off this way.
            L0045: SetFlag(player, 0x03, 0x09, 0x01);
            L005A: return; // RETURN;
        }

        private void Fn_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0;
            L0007: si = 0;
            L0009: ax = GetFlag(player, 0x03, 0x08);
04D1  001A 8B F8  mov di, ax
04D3  001C 47     inc di
04D4  001D 8B F7  mov si, di
            L001F: Compare(si, 0x13);
            L0022: if (JumpLessOrEqual) goto L002B;
04DB  0024 8B C6  mov ax, si
            L0026: si = ax + 0xFFEC;
            L002B: Compare(si, 0x0E);
            L002E: if (JumpLessOrEqual) goto L0037;
04E7  0030 8B C6  mov ax, si
            L0032: si = ax + 0xFFF1;
            L0037: Compare(si, 0x09);
            L003A: if (JumpLessOrEqual) goto L0043;
04F3  003C 8B C6  mov ax, si
            L003E: si = ax + 0xFFF6;
            L0043: Compare(si, 0x04);
            L0046: if (JumpLessOrEqual) goto L004F;
04FF  0048 8B C6  mov ax, si
            L004A: si = ax + 0xFFFB;
0506  004F 0B F6  or si, si
0508  0051 7D 02  jge 0x55
            L0053: si = 0;
            L0055: Compare(si, 0x1D);
            L0058: if (JumpLessOrEqual) goto L005C;
            L005A: si = 0;
0513  005C 83 FF 1E  cmp di, 0x1e
            L005F: if (JumpLessOrEqual) goto L0063;
            L0061: di = 0;
051A  0063 57     push di
            L0064: PushStack(player, 0x08);
            L0068: PushStack(player, 0x03);
0523  006C C4 5E 06  les bx, [bp+0x6]
0526  006F 26 FF 1F  call far word [es:bx]
0529  0072 83 C4 06  add sp, 0x6
052C  0075 83 FF 1A  cmp di, 0x1a
            L0078: if (JumpNotEqual) goto L007F;
0531  007A B8 01 00  mov ax, 0x1
            L007D: goto L0081;
            L007F: PushStack(player, 0x00);
0539  0082 83 FF 14  cmp di, 0x14
            L0085: if (JumpNotEqual) goto L008C;
053E  0087 B8 01 00  mov ax, 0x1
            L008A: goto L008E;
0543  008C 33 C0  xor ax, ax
            L008E: dx = PopStack(player);
0546  008F 0B D0  or dx, ax
            L0091: PushStack(player, dx);
0549  0092 83 FF 0E  cmp di, 0xe
            L0095: if (JumpNotEqual) goto L009C;
054E  0097 B8 01 00  mov ax, 0x1
            L009A: goto L009E;
0553  009C 33 C0  xor ax, ax
            L009E: dx = PopStack(player);
0556  009F 0B D0  or dx, ax
            L00A1: PushStack(player, dx);
0559  00A2 83 FF 08  cmp di, 0x8
            L00A5: if (JumpNotEqual) goto L00AC;
055E  00A7 B8 01 00  mov ax, 0x1
            L00AA: goto L00AE;
0563  00AC 33 C0  xor ax, ax
            L00AE: dx = PopStack(player);
0566  00AF 0B D0  or dx, ax
            L00B1: PushStack(player, dx);
0569  00B2 83 FF 02  cmp di, 0x2
            L00B5: if (JumpNotEqual) goto L00BC;
056E  00B7 B8 01 00  mov ax, 0x1
            L00BA: goto L00BE;
0573  00BC 33 C0  xor ax, ax
            L00BE: dx = PopStack(player);
0576  00BF 0B D0  or dx, ax
            L00C1: if (JumpNotEqual) goto L00C6;
            L00C3: goto L021F;
            L00C6: bx = si;
            L00C8: Compare(bx, 0x04);
            L00CB: if (JumpBelowOrEqual) goto L00D0;
            L00CD: goto L021F;
            L00D0: switch (bx) {
                case 0:
                    goto L0387;
                case 1:
                    goto L0397;
                case 2:
                    goto L03D0;
                case 3:
                    goto L03EF;
                case 4:
                    goto L0437;
            }
            L00D7: ShowMessage(player, String03D1); // You hear some footsteps running away.
            L00E4: goto L021F;
            L00E7: ShowMessage(player, String03F7); // You hear someone staggering towards you.
            L00F4: ShowPortrait(player, 0x001D);
            L0101: ShowMessage(player, String0420); // A happy halfling knight doffs his cap in your general direction.  Or perhaps that should be a halfling aleknight.
            L010E: ShowMessage(player, String0492); // 'By my stars and HIC! garters!  This is a great place, is it not?  No matter how much I drink in the cooling room, they keep on putting out more.  I will say this for the Lords of Cawdor: they keep a fine cellar.'
05D2  011B B8 68 05  mov ax, 0x568
            L011E: goto L00DA;
            L0120: ShowPortrait(player, 0x000E);
            L012D: ShowMessage(player, String058B); // The dragon opens his mouth wide, and as you cower in terror, issues forth a tremendous belch.
05F1  013A B8 E9 05  mov ax, 0x5e9
            L013D: goto L00DA;
            L013F: Compare(GetFlag(player, 0x02, 0x47), 0x0001);
            L0153: if (JumpNotEqual) goto L015A;
060C  0155 B8 B6 06  mov ax, 0x6b6
            L0158: goto L00DA;
            L015A: ShowPortrait(player, 0x0025);
            L0167: ShowMessage(player, String071F); // 'Ah!  Mine bosom companions, chums, friends of great worth!  I am most cheered to see thee, for I have learned that in this very Kitchen one can find The Prunes of Cawdor!
            L0174: ShowMessage(player, String07CB); // Used with wit and wisdom, they make certain monsters run away.  'S'truth!  As true as my name is Rory Applebush!  Good seeking!'
0638  0181 B8 4C 08  mov ax, 0x84c
            L0184: goto L00DA;
            L0187: ShowPortrait(player, 0x0026);
            L0194: ShowMessage(player, String0866); // A clutch of clerics decides that they must preach at you of the Gospel of the Bigger Stick!
0658  01A1 B8 89 01  mov ax, 0x189
            L01A4: PushStack(player, ax);
            L01A5: PushStack(player, 0x00);
            L01A8: PushStack(player, ax);
            L01A9: PushStack(player, ax);
            L01AA: PushStack(player, 0xB0);
            L01AE: PushStack(player, 0xBE);
0669  01B2 C4 5E 06  les bx, [bp+0x6]
066C  01B5 26 FF 9F D8 00  call far word [es:bx+0xd8]
0671  01BA 83 C4 0C  add sp, 0xc
            L01BD: AddEncounter(player, 0x01, 0x19);
            L01CF: Compare(PartyCount(player), 0x0001);
            L01DA: if (JumpBelowOrEqual) goto L01EE;
            L01DC: AddEncounter(player, 0x05, 0x19);
            L01EE: Compare(PartyCount(player), 0x0002);
            L01F9: if (JumpBelowOrEqual) goto L021F;
            L01FB: AddEncounter(player, 0x02, 0x19);
            L020D: AddEncounter(player, 0x06, 0x19);
            L021F: return; // RETURN (restoring si, di);
        }

        private void Fn_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String08C2); // A cold breeze sends shivers down your spine.
            L0010: return; // RETURN;
        }

        private void Fn_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetEquippedWeapon(player), 0x00D8);
            L000E: if (JumpNotEqual) goto L001E;
0706  0010 B8 EF 08  mov ax, 0x8ef
            L0013: PushStack(player, ax);
070A  0014 C4 5E 06  les bx, [bp+0x6]
070D  0017 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L001C: goto L0054;
            L001E: ax = HasItem(player, 0xD8);
            L002C: if (JumpEqual) goto L003B;
            L002E: ShowMessage(player, String0951); // Ohthere's Dagger glows, as if it wants to help you, but it seems ineffective from its current location.
            L003B: ShowMessage(player, String09B9); // Those boiling hot acidic waters really sting!
            L0048: DamagePlayer(player, 0x07D0);
            L0055: return; // RETURN;
        }

        private void Fn_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetEquippedWeapon(player), 0x00D8);
            L000E: if (JumpNotEqual) goto L001E;
075D  0010 B8 EF 08  mov ax, 0x8ef
            L0013: PushStack(player, ax);
0761  0014 C4 5E 06  les bx, [bp+0x6]
0764  0017 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L001C: goto L0066;
            L001E: ShowMessage(player, String09E7); // The Dissolving Pool continues to work its unpleasant will upon you.
0778  002B FF 76 08  push word [bp+0x8]
077B  002E FF 76 06  push word [bp+0x6]
077E  0031 0E     push cs
077F  0032 E8 D1 F5  call 0xf606
            L0035: cx = PopStack(player);
            L0036: cx = PopStack(player);
            L0037: Compare(GetFlag(player, 0x03, 0x19), 0x0001);
            L004B: if (JumpNotEqual) goto L005A;
            L004D: ShowMessage(player, String0A2B); // This isn't good.  The hot waters of the Dissolving Pool have cracked all your potion bottles!
            L005A: DamagePlayer(player, 0x07D0);
            L0067: return; // RETURN;
        }

        private void Fn_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0A89); // Banquo's ghost is through that door.  If you go through, you better go through fast and low.  The military mastermind that arranged this little steambath is sure to have an ambush waiting.
            L0010: ax = HasItem(player, 0xE9);
            L001E: if (JumpEqual) goto L0029;
            L0020: PushStack(player, 0x02);
07DA  0024 B8 F2 00  mov ax, 0xf2
            L0027: goto L0049;
            L0029: ax = CheckLevel(player, 0x001C);
            L0037: if (JumpEqual) goto L0042;
            L0039: PushStack(player, 0x02);
07F3  003D B8 F0 00  mov ax, 0xf0
            L0040: goto L0049;
            L0042: TeleportParty(player, 0x07, 0x02, 0xF1, 0x02, isForwardMove);
            L005D: return; // RETURN;
        }

        private void Fn_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0B46); // This room is filled with bins.  The bins are filled with flour.
            L0010: return; // RETURN;
        }

        private void Fn_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0B86); // This room is filled with bins.  The bins are filled with sugar.
            L0010: return; // RETURN;
        }

        private void Fn_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0BC6); // This room is filled with bins.  The bins are filled with salt.
            L0010: return; // RETURN;
        }

        private void Fn_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0C05); // This room is filled with bins.  The bins are filled with pepper.
            L0010: return; // RETURN;
        }

        private void Fn_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0C46); // This room is filled with barrels.  The barrels are filled with ale.
            L0010: return; // RETURN;
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0C8A); // This room is filled with barrels and jars.  They are filled with pickled vegetables and preserves.
            L0010: return; // RETURN;
        }

        private void Fn_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0CED); // This is one hot room.  The center aisle is stacked high with cords of firewood, mostly oak.  On the east and west walls are huge fireplaces, heating something (you assume ovens) in the room beyond.  The fires are being stoked by skeletons who glare unfriendlily towards you.
            L0010: ShowMessage(player, String0E00); // Oh, all right; it's impossible to tell just how a skeleton is glaring, but sure as shooting you wouldn't want to get stuck in the subway after dark with these guys.
            L001D: return; // RETURN;
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0EA5); // Yes, it's a group of lumbar lumberjacks, with more regenerating right next door!  And to top it off, they don't appear to be affected by the stifling heat in here the way you are.
            L0010: ax = GetMaxHits(player);
            L0017: bx = 0x0003;
            L001A: dx = ax % bx; ax = ax / bx;
            L001D: DamagePlayer(player, ax);
            L0027: PushStack(player, 0x02);
            L002B: PushStack(player, 0x00);
            L002E: PushStack(player, ax);
            L002F: PushStack(player, ax);
            L0030: PushStack(player, ax);
            L0031: PushStack(player, ax);
08D2  0032 C4 5E 06  les bx, [bp+0x6]
08D5  0035 26 FF 9F D8 00  call far word [es:bx+0xd8]
08DA  003A 83 C4 0C  add sp, 0xc
            L003D: AddEncounter(player, 0x01, 0x1C);
            L004F: AddEncounter(player, 0x05, 0x1C);
            L0061: Compare(PartyCount(player), 0x0002);
            L006C: if (JumpBelowOrEqual) goto L0092;
            L006E: AddEncounter(player, 0x02, 0x1C);
            L0080: AddEncounter(player, 0x06, 0x1C);
            L0092: return; // RETURN;
        }

        private void Fn_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0F59); // In wisdom or great folly you enter the flames, and let me tell you, it sure is warm in here!  About 5000 hit points warm!
            L0010: DamagePlayer(player, 0x1388);
            L001D: ShowMessage(player, String0FD3); // Wait for it!
            L002A: ShowMessage(player, String0FE0); // **********
            L0037: ShowMessage(player, String0FE0); // **********
            L0044: ShowMessage(player, String0FE0); // **********
            L0051: ShowMessage(player, String0FEB); // My money's on folly, but what do I know?
            L005E: return; // RETURN;
        }

        private void Fn_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1014); // If you wanted to kill yourself, couldn't you have found a gas oven?  These ovens are too hot to be comfortable, and, like I said, they are empty and uninteresting.
            L0010: DamagePlayer(player, 0x01F4);
            L001D: return; // RETURN;
        }

        private void Fn_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String10B8); // Look, mate, it's an oven.  It gets hot.  Very hot.  You put things in it and they get cooked.  Like you are getting cooked right now.  Would I lie to you?
            L0010: ShowMessage(player, String1153); // All right, all right.  Yes, I would lie to you.  But I'm not lying to you now.  This is a hot hot oven.  Nothing more.  Nothing less.
            L001D: DamagePlayer(player, 0x05DC);
            L002A: return; // RETURN;
        }

        private void Fn_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String11D9); // Through a leaded glass window in the oven doors you can see a hot oven glowing cheerily.  The doors are very warm to your touch, enough to inflict a slight burn.  The oven is empty and uninteresting.
            L0010: DamagePlayer(player, 0x000A);
            L001D: return; // RETURN;
            // Extra data: 55 8B EC B8 A1 12 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 
        }

        private void Fn_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFacing(player), 0x0002);
            L000D: if (JumpNotEqual) goto L001E;
            L000F: ShowMessage(player, String13BD); // The sign on the door reads: 'The Freezer.'
            L001C: goto L0054;
            L001E: RefreshCompareFlags(GetFlag(player, 0x03, 0x12));
            L0031: if (JumpNotEqual) goto L0054;
            L0033: SetFlag(player, 0x03, 0x12, 0x01);
0A58  0048 FF 76 08  push word [bp+0x8]
0A5B  004B FF 76 06  push word [bp+0x6]
0A5E  004E 0E     push cs
0A5F  004F E8 9C FF  call 0xffee
            L0052: cx = PopStack(player);
            L0053: cx = PopStack(player);
            L0054: return; // RETURN;
        }

        private void Fn_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0D));
            L0016: if (JumpNotEqual) goto L0056;
            L0018: SetFlag(player, 0x03, 0x0D, 0x01);
            L002D: ShowMessage(player, String13E8); // Boy, is it cold in here!  The entire south and east walls are packed with ice, some of which has been chipped off for personal use, no doubt.
            L003A: ShowMessage(player, String1476); // Many kinds of foodstuffs, including sides of beef, several types of plucked poultry, hogs, sheep, and fish, are stored in here, as well as many things you do not recognise.  Whoever stocked this freezer has a good appetite and a better purse.
            L0047: ShowMessage(player, String1569); // Now that you've adjusted a bit, you realize that the bitter cold is enough to wound you.
            L0054: goto L0056;
            L0056: DamagePlayer(player, 0x0032);
            L0063: return; // RETURN;
        }

        private void Fn_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00FB;
            L001B: PushStack(player, 0x01);
            L001F: PushStack(player, ax);
            L0020: PushStack(player, 0x03);
0AEF  0024 C4 5E 06  les bx, [bp+0x6]
0AF2  0027 26 FF 1F  call far word [es:bx]
0AF5  002A 83 C4 06  add sp, 0x6
            L002D: ShowMessage(player, String15C2); // How nice.  That spook wants to play, and is throwing a snowball at you.
            L003A: ShowMessage(player, String160A); // Gadzooks!  That's no snowball.  That's a fireball!
            L0047: DamagePlayer(player, 0x03E8);
0B1F  0054 B8 39 03  mov ax, 0x339
            L0057: PushStack(player, ax);
            L0058: PushStack(player, 0x00);
            L005B: PushStack(player, ax);
            L005C: PushStack(player, 0xB9);
            L0060: PushStack(player, 0x94);
            L0064: PushStack(player, 0x0D);
0B33  0068 C4 5E 06  les bx, [bp+0x6]
0B36  006B 26 FF 9F D8 00  call far word [es:bx+0xd8]
0B3B  0070 83 C4 0C  add sp, 0xc
            L0073: AddEncounter(player, 0x01, 0x1E);
            L0085: AddEncounter(player, 0x02, 0x1E);
            L0097: AddEncounter(player, 0x05, 0x1F);
            L00A9: Compare(PartyCount(player), 0x0002);
            L00B4: if (JumpBelowOrEqual) goto L00C8;
            L00B6: AddEncounter(player, 0x06, 0x1F);
            L00C8: Compare(PartyCount(player), 0x0003);
            L00D3: if (JumpBelowOrEqual) goto L0115;
            L00D5: AddEncounter(player, 0x04, 0x1E);
            L00E7: AddEncounter(player, 0x03, 0x1E);
            L00F9: goto L0115;
            L00FB: ShowMessage(player, String163D); // The way you splattered those spooks, maybe they were slowed down a bit by the cold.  Speaking of which, it is still cold enough to hurt here.
            L0108: DamagePlayer(player, 0x0064);
            L0115: return; // RETURN;
        }

        private void Fn_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00F1;
            L001B: SetFlag(player, 0x03, 0x02, 0x01);
            L0030: ShowMessage(player, String16CB); // The good news is that the undead think this is a cool place to hang out.  The bad news is that the undead think you are uncool.
            L003D: DamagePlayer(player, 0x05DC);
0C2C  004A B8 9A 02  mov ax, 0x29a
            L004D: PushStack(player, ax);
            L004E: PushStack(player, 0x00);
            L0051: PushStack(player, ax);
            L0052: PushStack(player, 0xBA);
            L0056: PushStack(player, 0xB0);
            L005A: PushStack(player, 0x89);
0C40  005E C4 5E 06  les bx, [bp+0x6]
0C43  0061 26 FF 9F D8 00  call far word [es:bx+0xd8]
0C48  0066 83 C4 0C  add sp, 0xc
            L0069: AddEncounter(player, 0x01, 0x22);
            L007B: AddEncounter(player, 0x02, 0x23);
            L008D: AddEncounter(player, 0x05, 0x1D);
            L009F: Compare(PartyCount(player), 0x0001);
            L00AA: if (JumpBelowOrEqual) goto L00BE;
            L00AC: AddEncounter(player, 0x06, 0x1D);
            L00BE: Compare(PartyCount(player), 0x0002);
            L00C9: if (JumpBelowOrEqual) goto L010B;
            L00CB: AddEncounter(player, 0x04, 0x22);
            L00DD: AddEncounter(player, 0x03, 0x23);
            L00EF: goto L010B;
            L00F1: ShowMessage(player, String174B); // You fought the undead, but kept your cool.  In fact, you kept it a tad too cool.
            L00FE: DamagePlayer(player, 0x0320);
            L010B: return; // RETURN;
        }

        private void Fn_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String179C); // It sure is cold in here.
            L0010: DamagePlayer(player, 0x0064);
            L001D: return; // RETURN;
        }

        private void Fn_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String17B5); // That's better!  Even though you are right next to the blocks of ice, it doesn't hurt any more.  That is better, isn't it?
            L0010: DamagePlayer(player, 0x01F4);
            L001D: return; // RETURN;
        }

        private void Fn_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0E));
            L0016: if (JumpNotEqual) goto L003A;
            L0018: SetFlag(player, 0x03, 0x0E, 0x01);
            L002D: ShowMessage(player, String182F); // This room is filled with implements of mixing: bowls, spoons, whippers, mortars and pestles, of different sizes.
            L003A: return; // RETURN;
        }

        private void Fn_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String18A0); // A small sign posted on the door to the north reads: 'Warning.  The spice room is specially enmagicked to eliminate all unsealed strong odors, lest they contaminate the spices.
            L0010: return; // RETURN;
        }

        private void Fn_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0x9D);
            L0011: if (JumpEqual) goto L001F;
            L0013: RemoveItem(player, 0x9D);
            L001F: return; // RETURN;
        }

        private void Fn_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x03);
            L0007: PushStack(player, ax);
0DA4  0008 C4 5E 06  les bx, [bp+0x6]
0DA7  000B 26 FF 5F 04  call far word [es:bx+0x4]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0018;
            L0015: goto L00DE;
            L0018: PushStack(player, 0x01);
            L001C: PushStack(player, 0x03);
            L0020: PushStack(player, ax);
0DBD  0021 C4 5E 06  les bx, [bp+0x6]
0DC0  0024 26 FF 1F  call far word [es:bx]
0DC3  0027 83 C4 06  add sp, 0x6
            L002A: ShowMessage(player, String1950); // Tchee!  A bunch of vampires invite you to dinner, and you don't have any garlic to bring them!
0DD3  0037 B8 4F 03  mov ax, 0x34f
            L003A: PushStack(player, ax);
            L003B: PushStack(player, 0x00);
            L003E: PushStack(player, ax);
            L003F: PushStack(player, 0xBA);
            L0043: PushStack(player, 0x41);
            L0047: PushStack(player, 0x1F);
0DE7  004B C4 5E 06  les bx, [bp+0x6]
0DEA  004E 26 FF 9F D8 00  call far word [es:bx+0xd8]
0DEF  0053 83 C4 0C  add sp, 0xc
            L0056: AddEncounter(player, 0x01, 0x20);
            L0068: AddEncounter(player, 0x02, 0x20);
            L007A: AddEncounter(player, 0x05, 0x21);
            L008C: Compare(PartyCount(player), 0x0001);
            L0097: if (JumpBelowOrEqual) goto L00AB;
            L0099: AddEncounter(player, 0x06, 0x21);
            L00AB: Compare(PartyCount(player), 0x0002);
            L00B6: if (JumpBelowOrEqual) goto L00EB;
            L00B8: AddEncounter(player, 0x04, 0x21);
            L00CA: AddEncounter(player, 0x03, 0x21);
            L00DC: goto L00EB;
            L00DE: ShowMessage(player, String19AF); // The scratches on your gorget are all that remind you of the vampires you fought here.
            L00EB: return; // RETURN;
        }

        private void Fn_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x0F));
            L0016: if (JumpNotEqual) goto L003A;
            L0018: SetFlag(player, 0x03, 0x0F, 0x01);
            L002D: ShowMessage(player, String1A05); // This room is filled with implements of kneading: rolling pins, boards, big rising bowls, containers holding many types of flour, atomizers, etc.
            L003A: return; // RETURN;
        }

        private void Fn_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x10));
            L0016: if (JumpNotEqual) goto L003A;
            L0018: SetFlag(player, 0x03, 0x10, 0x01);
            L002D: ShowMessage(player, String1A96); // This room is filled with implements of confectionary: small double boilers, frosting appliers, sugars and nuts of every variety, and several types of chocolate.
            L003A: return; // RETURN;
        }

        private void Fn_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x11));
            L0016: if (JumpNotEqual) goto L003A;
            L0018: SetFlag(player, 0x03, 0x11, 0x01);
            L002D: ShowMessage(player, String1B37); // This room is filled with crockpots and staples.  Turnips, parsnips, potatoes, onions, carrots, peas, and most every kind of root vegetable simmer in a plethora of pots.  In fact, the atmosphere in here is rather soupy.
            L003A: return; // RETURN;
        }

        private void Fn_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFacing(player), 0x0001);
            L000D: if (JumpNotEqual) goto L001E;
            L000F: ShowMessage(player, String13BD); // The sign on the door reads: 'The Freezer.'
            L001C: goto L0054;
            L001E: RefreshCompareFlags(GetFlag(player, 0x03, 0x13));
            L0031: if (JumpNotEqual) goto L0054;
            L0033: SetFlag(player, 0x03, 0x13, 0x01);
0F85  0048 FF 76 08  push word [bp+0x8]
0F88  004B FF 76 06  push word [bp+0x6]
0F8B  004E 0E     push cs
0F8C  004F E8 6F FA  call 0xfac1
            L0052: cx = PopStack(player);
            L0053: cx = PopStack(player);
            L0054: return; // RETURN;
        }

        private void Fn_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x1E, 0x01);
            L0018: RefreshCompareFlags(GetFlag(player, 0x03, 0x13));
            L002B: if (JumpNotEqual) goto L004E;
            L002D: SetFlag(player, 0x03, 0x13, 0x01);
0FD5  0042 FF 76 08  push word [bp+0x8]
0FD8  0045 FF 76 06  push word [bp+0x6]
0FDB  0048 0E     push cs
0FDC  0049 E8 1F FA  call 0xfa6b
            L004C: cx = PopStack(player);
            L004D: cx = PopStack(player);
            L004E: return; // RETURN;
        }

        private void Fn_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1C12); // This is the way back to the Chambers.
            L0010: TeleportParty(player, 0x06, 0x03, 0xB0, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void Fn_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x12));
            L0016: if (JumpNotEqual) goto L0039;
            L0018: SetFlag(player, 0x03, 0x12, 0x01);
103D  002D FF 76 08  push word [bp+0x8]
1040  0030 FF 76 06  push word [bp+0x6]
1043  0033 0E     push cs
1044  0034 E8 B7 F9  call 0xf9ee
            L0037: cx = PopStack(player);
            L0038: cx = PopStack(player);
            L0039: return; // RETURN;
        }

        private void Fn_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x14));
            L0016: if (JumpNotEqual) goto L0047;
            L0018: SetFlag(player, 0x03, 0x14, 0x01);
            L002D: ShowMessage(player, String1C38); // This room is filled with implements of saladizing.  There are six different types of lettuce washers.  There are collanders, and carrot peelers, and intricate little tools that turn radishes into lovely garnishes, yum yum.
            L003A: ShowMessage(player, String1D17); // Right.  Too much time in the kitchen.  Sigh....
            L0047: return; // RETURN;
        }

        private void Fn_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x17));
            L0016: if (JumpNotEqual) goto L003A;
            L0018: SetFlag(player, 0x03, 0x17, 0x01);
            L002D: ShowMessage(player, String1D47); // This is where they prepare the meat prior to using or freezing it.  A number of processes far too detailed to pass INN's Community Standards are in various states of completion.  It's enough to make you consider becoming a vegetarian.
            L003A: return; // RETURN;
        }

        private void Fn_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x15));
            L0016: if (JumpNotEqual) goto L003A;
            L0018: SetFlag(player, 0x03, 0x15, 0x01);
            L002D: ShowMessage(player, String1E32); // This is a normal, run of the mill, multipurpose kitchen room, adaptable to any requirement.
            L003A: return; // RETURN;
        }

        private void Fn_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x16));
            L0016: if (JumpNotEqual) goto L0047;
            L0018: SetFlag(player, 0x03, 0x16, 0x01);
            L002D: ShowMessage(player, String1E8E); // Boy, is this a big room!  Most of the west end is filled with implements of washing.  There are oodles of silverware and boodles of flatware prepared in hutches and on shelves along the south wall, ready to be loaded onto the many trolleys and taken, well, somewhere else.
            L003A: ShowMessage(player, String1F9F); // Of course, we know you are far too honest to consider knicking the cutlery, eh?
            L0047: return; // RETURN;
        }

        private void Fn_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E4;
            L001B: SetFlag(player, 0x03, 0x04, 0x01);
            L0030: ShowMessage(player, String1FEF); // This must have good salads here, because they have attracted a party of adventurers.  Unfortunately, the adventurers want to fight you for the table.
1192  003D B8 4F 03  mov ax, 0x34f
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, 0xBA);
            L0049: PushStack(player, 0xC6);
            L004D: PushStack(player, 0x34);
11A6  0051 C4 5E 06  les bx, [bp+0x6]
11A9  0054 26 FF 9F D8 00  call far word [es:bx+0xd8]
11AE  0059 83 C4 0C  add sp, 0xc
            L005C: AddEncounter(player, 0x01, 0x1B);
            L006E: AddEncounter(player, 0x02, 0x1A);
            L0080: AddEncounter(player, 0x05, 0x19);
            L0092: Compare(PartyCount(player), 0x0001);
            L009D: if (JumpBelowOrEqual) goto L00B1;
            L009F: AddEncounter(player, 0x06, 0x19);
            L00B1: Compare(PartyCount(player), 0x0002);
            L00BC: if (JumpBelowOrEqual) goto L00F1;
            L00BE: AddEncounter(player, 0x04, 0x1A);
            L00D0: AddEncounter(player, 0x03, 0x1B);
            L00E2: goto L00F1;
            L00E4: ShowMessage(player, String2085); // All that remains of your battle here are some crushed croutons and a crumble of blue cheese.
            L00F1: return; // RETURN;
        }

        private void Fn_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x05));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E4;
            L001B: SetFlag(player, 0x03, 0x05, 0x01);
            L0030: ShowMessage(player, String20E2); // It isn't hard to figure out that all this meat is what has lured those dogs and cats here.  It's just a shame that they seem to prefer adventurers to beef.  You must be the other other white meat.
1285  003D B8 4F 03  mov ax, 0x34f
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, 0xBA);
            L0049: PushStack(player, 0xCD);
            L004D: PushStack(player, 0x67);
1299  0051 C4 5E 06  les bx, [bp+0x6]
129C  0054 26 FF 9F D8 00  call far word [es:bx+0xd8]
12A1  0059 83 C4 0C  add sp, 0xc
            L005C: AddEncounter(player, 0x01, 0x24);
            L006E: AddEncounter(player, 0x02, 0x26);
            L0080: AddEncounter(player, 0x05, 0x24);
            L0092: Compare(PartyCount(player), 0x0001);
            L009D: if (JumpBelowOrEqual) goto L00B1;
            L009F: AddEncounter(player, 0x06, 0x26);
            L00B1: Compare(PartyCount(player), 0x0002);
            L00BC: if (JumpBelowOrEqual) goto L00F1;
            L00BE: AddEncounter(player, 0x04, 0x24);
            L00D0: AddEncounter(player, 0x03, 0x26);
            L00E2: goto L00F1;
            L00E4: ShowMessage(player, String21A7); // All that remains of the battle you fought here is enough animal fur to clog an allergic titan.
            L00F1: return; // RETURN;
        }

        private void Fn_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x06));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E1;
            L001B: SetFlag(player, 0x03, 0x06, 0x01);
            L0030: ShowMessage(player, String2206); // It's an aerial assault!
1378  003D B8 07 06  mov ax, 0x607
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, ax);
            L0046: PushStack(player, 0xCD);
            L004A: PushStack(player, 0x50);
1389  004E C4 5E 06  les bx, [bp+0x6]
138C  0051 26 FF 9F D8 00  call far word [es:bx+0xd8]
1391  0056 83 C4 0C  add sp, 0xc
            L0059: AddEncounter(player, 0x01, 0x25);
            L006B: AddEncounter(player, 0x02, 0x25);
            L007D: AddEncounter(player, 0x05, 0x28);
            L008F: Compare(PartyCount(player), 0x0001);
            L009A: if (JumpBelowOrEqual) goto L00AE;
            L009C: AddEncounter(player, 0x06, 0x28);
            L00AE: Compare(PartyCount(player), 0x0002);
            L00B9: if (JumpBelowOrEqual) goto L00EE;
            L00BB: AddEncounter(player, 0x04, 0x28);
            L00CD: AddEncounter(player, 0x03, 0x28);
            L00DF: goto L00EE;
            L00E1: ShowMessage(player, String221E); // The battle you fought here showed that you were just a tad more impressive than those imps.
            L00EE: return; // RETURN;
        }

        private void Fn_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x07));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00E4;
            L001B: SetFlag(player, 0x03, 0x07, 0x01);
            L0030: ShowMessage(player, String227A); // You didn't want to fight imps?  Well, that's what you pict.
1468  003D B8 89 07  mov ax, 0x789
            L0040: PushStack(player, ax);
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, 0xBA);
            L0049: PushStack(player, 0xCD);
            L004D: PushStack(player, 0x68);
147C  0051 C4 5E 06  les bx, [bp+0x6]
147F  0054 26 FF 9F D8 00  call far word [es:bx+0xd8]
1484  0059 83 C4 0C  add sp, 0xc
            L005C: AddEncounter(player, 0x01, 0x27);
            L006E: AddEncounter(player, 0x02, 0x27);
            L0080: AddEncounter(player, 0x05, 0x28);
            L0092: Compare(PartyCount(player), 0x0001);
            L009D: if (JumpBelowOrEqual) goto L00B1;
            L009F: AddEncounter(player, 0x06, 0x28);
            L00B1: Compare(PartyCount(player), 0x0002);
            L00BC: if (JumpBelowOrEqual) goto L00F1;
            L00BE: AddEncounter(player, 0x04, 0x28);
            L00D0: AddEncounter(player, 0x03, 0x28);
            L00E2: goto L00F1;
            L00E4: ShowMessage(player, String221E); // The battle you fought here showed that you were just a tad more impressive than those imps.
            L00F1: return; // RETURN;
        }

        private void Fn_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x04);
1525  0007 C4 5E 06  les bx, [bp+0x6]
1528  000A 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L000F: cx = PopStack(player);
            L0010: RefreshCompareFlags(ax);
            L0012: if (JumpEqual) goto L0035;
            L0014: PushStack(player, 0x00);
1535  0017 C4 5E 06  les bx, [bp+0x6]
1538  001A 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L001F: cx = PopStack(player);
            L0020: RefreshCompareFlags(ax);
            L0022: if (JumpEqual) goto L0035;
            L0024: PushStack(player, 0x03);
1546  0028 C4 5E 06  les bx, [bp+0x6]
1549  002B 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L0030: cx = PopStack(player);
            L0031: RefreshCompareFlags(ax);
            L0033: if (JumpNotEqual) goto L0061;
            L0035: Compare(GetFlag(player, 0x02, 0x14), 0x0001);
            L0049: if (JumpEqual) goto L0061;
            L004B: Compare(GetFlag(player, 0x02, 0x1F), 0x0001);
            L005F: if (JumpNotEqual) goto L00A6;
            L0061: ShowPortrait(player, 0x0029);
            L006E: ShowMessage(player, String22B6); // Some short adventurers hold the door for you.
            L007B: ShowMessage(player, String22E4); // 'Well met!  There are enough undead in there for all of us, and some giants and dragons as well.  May providence smile upon thy works.'
            L0088: TeleportParty(player, 0x07, 0x02, 0xFC, 0x03, isForwardMove);
            L00A3: goto L0126;
            L00A6: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00C3: RefreshCompareFlags(GetFlag(player, 0x02, 0x35));
            L00D6: if (JumpNotEqual) goto L010C;
            L00D8: SetFlag(player, 0x02, 0x35, 0x01);
            L00ED: ShowMessage(player, String236C); // Not another locked door!  This one leads to The Cabinet, or at least it would if you had the right combination of people to get it open.
            L00FA: ShowMessage(player, String23F5); // Oh, come on.  You had to figure out at least a level down that some of these rooms require names acronymically defined before they'll let you in the first time.
1625  0107 B8 96 24  mov ax, 0x2496
            L010A: goto L011C;
            L010C: ShowMessage(player, String254F); // Oh.  Cool!  You're pretending you don't know you need a Cleric, Barbarian, and Thief to enter the Cabinet so nobody will suspect that I gave away the secret of those types of puzzles.
            L0119: ShowMessage(player, String2607); // Don't worry!  To reward you, I won't make any more of those upstairs.
            L0126: return; // RETURN;
        }

        private void Fn_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000B);
            L0012: if (JumpNotBelow) goto L0026;
            L0014: PushStack(player, 0x86);
            L0018: PushStack(player, ax);
165F  0019 C4 5E 06  les bx, [bp+0x6]
1662  001C 26 FF 5F 54  call far word [es:bx+0x54]
            L0020: cx = PopStack(player);
            L0021: cx = PopStack(player);
            L0022: RefreshCompareFlags(ax);
            L0024: if (JumpEqual) goto L0069;
            L0026: RefreshCompareFlags(GetFlag(player, 0x03, 0x18));
            L0039: if (JumpNotEqual) goto L0069;
            L003B: SetFlag(player, 0x03, 0x18, 0x01);
            L0050: ShowMessage(player, String264D); // Deep in a cabinet, hidden behind many bottles, you spot a glimpse of blue.  You investigate further, and find an unused bottle of Woad Wine.  Nasty stuff, Woad Wine, but it sure restores the mana points!
            L005D: GiveItem(player, 0xCD);
            L0069: return; // RETURN;
        }

        private void Fn_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000B);
            L0012: if (JumpNotBelow) goto L0026;
            L0014: PushStack(player, 0x86);
            L0018: PushStack(player, ax);
16CA  0019 C4 5E 06  les bx, [bp+0x6]
16CD  001C 26 FF 5F 54  call far word [es:bx+0x54]
            L0020: cx = PopStack(player);
            L0021: cx = PopStack(player);
            L0022: RefreshCompareFlags(ax);
            L0024: if (JumpEqual) goto L0079;
            L0026: RefreshCompareFlags(GetFlag(player, 0x03, 0x0C));
            L0039: if (JumpNotEqual) goto L0079;
            L003B: ax = HasItem(player, 0xCE);
            L0049: if (JumpNotEqual) goto L0079;
            L004B: SetFlag(player, 0x03, 0x0C, 0x01);
            L0060: ShowMessage(player, String2719); // Buried in the salt you find something worth far more than its weight in salt.  It's a palace chalice!
            L006D: GiveItem(player, 0xCE);
            L0079: return; // RETURN;
        }

        private void Fn_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000B);
            L0012: if (JumpNotBelow) goto L0026;
            L0014: PushStack(player, 0x86);
            L0018: PushStack(player, ax);
1745  0019 C4 5E 06  les bx, [bp+0x6]
1748  001C 26 FF 5F 54  call far word [es:bx+0x54]
            L0020: cx = PopStack(player);
            L0021: cx = PopStack(player);
            L0022: RefreshCompareFlags(ax);
            L0024: if (JumpEqual) goto L0079;
            L0026: RefreshCompareFlags(GetFlag(player, 0x03, 0x0B));
            L0039: if (JumpNotEqual) goto L0079;
            L003B: ax = HasItem(player, 0xE2);
            L0049: if (JumpNotEqual) goto L0079;
            L004B: SetFlag(player, 0x03, 0x0B, 0x01);
            L0060: ShowMessage(player, String277F); // Wait a second.  Those are no pickles.  They must be the legendary Prunes of Cawdor!
            L006D: GiveItem(player, 0xE2);
            L0079: return; // RETURN;
        }

        private void Fn_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x1E, 0x01);
            L0018: return; // RETURN;
        }

    }
}
