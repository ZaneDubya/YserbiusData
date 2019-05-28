#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap01 : AMapScripted {
        protected override int MapIndex => 1;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap01() {
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
            MapEvent34 = Fn_34;
            MapEvent35 = Fn_35;
            MapEvent36 = Fn_36;
            MapEvent37 = Fn_37;
            MapEvent38 = Fn_38;
            MapEvent39 = Fn_39;
            MapEvent3A = Fn_3A;
            MapEvent3C = Fn_3C;
            MapEvent3D = Fn_3D;
            MapEvent3E = Fn_3E;
            MapEvent3F = Fn_3F;
            MapEvent40 = Fn_40;
            MapEvent41 = Fn_41;
        }
        
        // === Strings ================================================
        private const string String0140 = "This gateway leads to the Foyer of Cawdor.";
        private const string String016B = "A: This wyrd sister lives no more";
        private const string String018D = "A: Save words here writ in living stone.";
        private const string String01B6 = "A: And for a life knee deep in gore";
        private const string String01DA = "A: Beyond the grave I must atone.";
        private const string String01FC = "A: Cawdor's bones are full of beasts.";
        private const string String0222 = "A: Thy challenge: to defeat them.";
        private const string String0244 = "A: To help my soul I can at least";
        private const string String0266 = "A: Leave hints an thou canst read them.";
        private const string String028E = "A: Each clue thou findst upon these walls";
        private const string String02B8 = "A: Is split in sections various.";
        private const string String02D9 = "A: Together they will tell thee all";
        private const string String02FD = "A: To kill the most nefarious.";
        private const string String031C = "A: Not all my clues are openly writ.";
        private const string String0341 = "A: Some messages are obscure.";
        private const string String035F = "A: But when deciphered by thine own wit";
        private const string String0387 = "A: Thy victory they'll ensure.";
        private const string String03A6 = "B: Cawdor's doors have mighty wards,";
        private const string String03CB = "B: Protections hale and hearty.";
        private const string String03EB = "B: An thou wouldst earn thy just rewards";
        private const string String0414 = "B: Thou wilt need a balanced party.";
        private const string String0438 = "B: Thou canst not force an entryway";
        private const string String045C = "B: Be thou strong or willful.";
        private const string String047A = "B: But oft a group can make their way";
        private const string String04A0 = "B: As can a thief most skillful.";
        private const string String04C1 = "The Brinded Cat is a giant beast; ";
        private const string String04E4 = "Its fur is hard and curly. ";
        private const string String0500 = "But it cannot resist the power ";
        private const string String0520 = "Of the mighty Hurlyburly.";
        private const string String053A = "The Harpier's bite can strike thee dead,";
        private const string String0563 = "Diseased and full of blindness.";
        private const string String0583 = "But thou canst face its awesome dread,";
        private const string String05AA = "With the Milk of Human Kindness.";
        private const string String05CB = "The dragon, fenny snake, and wolf,";
        private const string String05EE = "The adder, newt, and frog,";
        private const string String0609 = "The blind-worm, bat, goat, and witch,";
        private const string String062F = "The lizard, howlet, and dog,";
        private const string String064C = "Use thou which they do have within,";
        private const string String0670 = "To drive them full agog.";
        private const string String0689 = "King Hadrian's great masonic fame,";
        private const string String06AC = "Was his engirdling wall.";
        private const string String06C5 = "The Shield thou finds that bears his name";
        private const string String06EF = "Ensures that thou won't fall.";
        private const string String070D = "Hilda, Whitby's Abbess,";
        private const string String0725 = "Healed with her self-named glove.";
        private const string String0747 = "Streoneshalh, the mail of plate,";
        private const string String0768 = "Defends with Hilda's love.";
        private const string String0783 = "The Scramasax the Picts did use";
        private const string String07A3 = "Its poisons did not scare them.";
        private const string String07C3 = "An thou dost find such doughty blades,";
        private const string String07EA = "Then let thy foes beware them.";
        private const string String0809 = "When things are bleak, thy foes are nigh,";
        private const string String0833 = "The darkness seems most Stygian,";
        private const string String0854 = "An thou wouldst find help from on high,";
        private const string String087C = "Then use the Cap of Phrygian.";
        private const string String089A = "When runes are seen yet make no sense,";
        private const string String08C1 = "They set thy head to stewin'";
        private const string String08DE = "There's still a chance: do not be tense.";
        private const string String0907 = "An thou hast the Cap of Alcuin.";
        private const string String0927 = "But 'ware the usage of the cap.";
        private const string String0947 = "Thou wilt not be overjoyed.";
        private const string String0963 = "An thou dost use it like foolscap";
        private const string String0985 = "Thou wilt find thy cap destroyed.";
        private const string String09A7 = "D: gYoun allcomM saw a volley dal";
        private const string String09C9 = "D: siH cafe thob raif dan swimone";
        private const string String09EB = "D: If hout muts ghfti mih hent eb dlag";
        private const string String0A12 = "D: uToh wares het rnwoC of soCimrn";
        private const string String0A35 = "E: Mdgi moysry ie hpt Lhtsashi";
        private const string String0A54 = "E: 'Ttg hsio ta mrrr hge sdkeeaa";
        private const string String0A75 = "E: Utplus teys hahh a mrgstro giin";
        private const string String0A98 = "E: Agg wadddi a Lleeee Darnns.";
        private const string String0AB7 = "J: Tk dBfg oiea ihlaneol dqrsuctoe' ssome";
        private const string String0AE1 = "J: Tnbt fhewal oeo nyudnis entrgs";
        private const string String0B03 = "J: TBt otkhhh lhn hii oeue ealss etl t'ss";
        private const string String0B2D = "J: TOs hdhrei yeat min ngsge.";
        private const string String0B4B = "Alcuin's cap glows warm to the touch.  You can read the runes!";
        private const string String0B8A = "F: Macduff's heroic fighting spirit.";
        private const string String0BAF = "F: sashfff'rherMocugdctingiiiipt";
        private const string String0BD0 = "F: Will set thy face to frowning.";
        private const string String0BF2 = "F: illsetttcygaehirooffwWnn.";
        private const string String0C0F = "F: If thou wouldst know how not to fear it";
        private const string String0C3A = "F: Iiahhuuldsknwwwnooooootttttffre";
        private const string String0C5D = "F: Then use the Cup of Drowning.";
        private const string String0C7E = "F: TtCfDsroowighheeennnuup.";
        private const string String0C9A = "G: Macbeth's shade is strongest of all";
        private const string String0CC1 = "G: aaaaaaaaa abbBc cc dddeeeeee ee eee";
        private const string String0CE8 = "G: But an thou earns his pocket";
        private const string String0D08 = "G: ffg gh hhhh hhhhH iii iikkll";
        private const string String0D28 = "G: Then in thy hands mayhaps will fall";
        private const string String0D4F = "G: llll ll LmM nnnnn nnooooo pprr ssss";
        private const string String0D76 = "G: The blessed Healing Locket.";
        private const string String0D95 = "G: sss ssssttt tttttTT uuwyy'";
        private const string String0DB3 = "H:  Thou hast solved clues that I did brew";
        private const string String0DDE = "H:  With means anagrammatic.";
        private const string String0DFB = "H:  But these last clues are those that thou";
        private const string String0E28 = "H:  Solve with means cryptographic.";
        private const string String0E4C = "Alcuin's cap glows red hot, and then dissolves into wisps of steam.  But at least you get to read the runes!";
        private const string String0EB9 = "I: The Healing Locket's all that might";
        private const string String0EE0 = "I: Ward off my sisters's power.";
        private const string String0F00 = "I: Use it steadfastly through the fight";
        private const string String0F28 = "I: And watch it make them glower.";
        private const string String0F4A = "I:  Bkw Kwqgmoy Glhuwb'c qgg bkqb amykb";
        private const string String0F72 = "I:  Nqti ljj ap cmcbwtc'c flnwt.";
        private const string String0F93 = "I:  Scw mb cbwqijqcbgp bktlsyk bkw jmykb";
        private const string String0FBC = "I:  Qoi nqbhk mb aquw bkwa yglnwt.";
        private const string String0FDF = "The doors refuse to budge.";
        private const string String0FFA = "These narrow stairs will force you to descend single file.";
        private const string String1035 = "Whoever last passed these doors did not pull them to.  You carefully make sure they stay ajar as you pass.  They lead to stairs descending into darkness.";
        private const string String10CF = "A beatific figure, old, wise, and happy, appears before you.";
        private const string String110C = "'I am Aldhelm.  Long have I hoped to aid one of good heart in ridding this earth of the canker of the Wyrd Sisters.";
        private const string String1180 = "There is a secret path, somewhat safer, that will lead thee to thy goal.  It will bypass many fiercesome beasts set here to sap thy will and vigor.  Take it, and my blessing.'";
        private const string String1230 = "C:  Fancel epadsce teh mrrrduee's balde";
        private const string String1258 = "C:  Btu he sllit flees hsi golom.";
        private const string String127A = "C:  If thuo wosdutl bets daeeft hsi shead";
        private const string String12A4 = "C:  Tehn wedil teh Cckar of Dmoo.";
        private const string String12C6 = "*";
        private const string String12C8 = "By all the fins and feathers!  An enormous red dragon rears up and speaks to you.";
        private const string String131A = "'Hmm.  There are two ways this could go.  We could have similar senses of humor, and part friends, or I could just eat thee.  So.  Wouldst hear a joke about a stupid green dragon named Gwalter the Dim?'";
        private const string String13E5 = "'Ah!  I remember thee.  As I recall, thou didst enjoy my last joke.  Wouldst thou hear another?'";
        private const string String1446 = "You quickly nod.";
        private const string String1457 = "'There was a very stupid green dragon named Gwalter the Dim.  Do not laugh yet!  One day Gwalter received three wishes from a djinn.  For his first wish he asked for a bag that would always be full of gold, no matter how much he removed.  Lo and behold!  His wish was granted.";
        private const string String156C = "The genie asked what he wanted for his other wishes.  Gwalter asked for two more of those bags.  Get it?'";
        private const string String15D6 = "You laugh politely.";
        private const string String15EA = "'Good enough.  But remember; 'tis only the green drakes that exhibit such stupidity.  I shall remember thee.'";
        private const string String1658 = "The dragon departs.";
        private const string String166C = "A halfling cleric approaches you surreptitiously.";
        private const string String169E = "'Psst!  Cuz!  Thou dost look like a being of wit and wisdom.  I will gladly share with thee a great secret.'";
        private const string String170B = "He opens his coat to show, pinned to the inside, a slightly turned pig's foot.";
        private const string String175A = "'This is the Lucky Pig's Foot.  It is the sovereign against dragons, for wyrms cannot abide the smell of burnt pig's foot.  Thou needst only to brandish it boldly before thee in battle....'";
        private const string String1818 = "His voice trails off as he sees someone approaching, waving another lucky pig's foot.  'Anon!'";
        
        // === Functions ================================================
        private void Fn_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0140); // This gateway leads to the Foyer of Cawdor.
            L0010: return; // RETURN;
        }

        private void Fn_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String016B); // A: This wyrd sister lives no more
            L0010: return; // RETURN;
        }

        private void Fn_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String018D); // A: Save words here writ in living stone.
            L0010: return; // RETURN;
        }

        private void Fn_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String01B6); // A: And for a life knee deep in gore
            L0010: return; // RETURN;
        }

        private void Fn_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String01DA); // A: Beyond the grave I must atone.
            L0010: return; // RETURN;
        }

        private void Fn_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String01FC); // A: Cawdor's bones are full of beasts.
            L0010: return; // RETURN;
        }

        private void Fn_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0222); // A: Thy challenge: to defeat them.
            L0010: return; // RETURN;
        }

        private void Fn_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0244); // A: To help my soul I can at least
            L0010: return; // RETURN;
        }

        private void Fn_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0266); // A: Leave hints an thou canst read them.
            L0010: return; // RETURN;
        }

        private void Fn_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String028E); // A: Each clue thou findst upon these walls
            L0010: return; // RETURN;
        }

        private void Fn_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String02B8); // A: Is split in sections various.
            L0010: return; // RETURN;
        }

        private void Fn_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String02D9); // A: Together they will tell thee all
            L0010: return; // RETURN;
        }

        private void Fn_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String02FD); // A: To kill the most nefarious.
            L0010: return; // RETURN;
        }

        private void Fn_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String031C); // A: Not all my clues are openly writ.
            L0010: return; // RETURN;
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0341); // A: Some messages are obscure.
            L0010: return; // RETURN;
        }

        private void Fn_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String035F); // A: But when deciphered by thine own wit
            L0010: return; // RETURN;
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0387); // A: Thy victory they'll ensure.
            L0010: return; // RETURN;
        }

        private void Fn_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String03A6); // B: Cawdor's doors have mighty wards,
            L0010: return; // RETURN;
        }

        private void Fn_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String03CB); // B: Protections hale and hearty.
            L0010: return; // RETURN;
        }

        private void Fn_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String03EB); // B: An thou wouldst earn thy just rewards
            L0010: return; // RETURN;
        }

        private void Fn_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0414); // B: Thou wilt need a balanced party.
            L0010: return; // RETURN;
        }

        private void Fn_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0438); // B: Thou canst not force an entryway
            L0010: return; // RETURN;
        }

        private void Fn_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String045C); // B: Be thou strong or willful.
            L0010: return; // RETURN;
        }

        private void Fn_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String047A); // B: But oft a group can make their way
            L0010: return; // RETURN;
        }

        private void Fn_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String04A0); // B: As can a thief most skillful.
            L0010: return; // RETURN;
        }

        private void Fn_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String04C1); // The Brinded Cat is a giant beast; 
            L0010: ShowRunes(player, String04E4); // Its fur is hard and curly. 
            L001D: ShowRunes(player, String0500); // But it cannot resist the power 
            L002A: ShowRunes(player, String0520); // Of the mighty Hurlyburly.
            L0037: return; // RETURN;
        }

        private void Fn_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String053A); // The Harpier's bite can strike thee dead,
            L0010: ShowRunes(player, String0563); // Diseased and full of blindness.
            L001D: ShowRunes(player, String0583); // But thou canst face its awesome dread,
            L002A: ShowRunes(player, String05AA); // With the Milk of Human Kindness.
            L0037: return; // RETURN;
        }

        private void Fn_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String05CB); // The dragon, fenny snake, and wolf,
            L0010: ShowRunes(player, String05EE); // The adder, newt, and frog,
            L001D: ShowRunes(player, String0609); // The blind-worm, bat, goat, and witch,
            L002A: ShowRunes(player, String062F); // The lizard, howlet, and dog,
            L0037: ShowRunes(player, String064C); // Use thou which they do have within,
            L0044: ShowRunes(player, String0670); // To drive them full agog.
            L0051: return; // RETURN;
        }

        private void Fn_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0689); // King Hadrian's great masonic fame,
            L0010: ShowRunes(player, String06AC); // Was his engirdling wall.
            L001D: ShowRunes(player, String06C5); // The Shield thou finds that bears his name
            L002A: ShowRunes(player, String06EF); // Ensures that thou won't fall.
            L0037: return; // RETURN;
        }

        private void Fn_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String070D); // Hilda, Whitby's Abbess,
            L0010: ShowRunes(player, String0725); // Healed with her self-named glove.
            L001D: ShowRunes(player, String0747); // Streoneshalh, the mail of plate,
            L002A: ShowRunes(player, String0768); // Defends with Hilda's love.
            L0037: return; // RETURN;
        }

        private void Fn_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0783); // The Scramasax the Picts did use
            L0010: ShowRunes(player, String07A3); // Its poisons did not scare them.
            L001D: ShowRunes(player, String07C3); // An thou dost find such doughty blades,
            L002A: ShowRunes(player, String07EA); // Then let thy foes beware them.
            L0037: return; // RETURN;
        }

        private void Fn_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0809); // When things are bleak, thy foes are nigh,
            L0010: ShowRunes(player, String0833); // The darkness seems most Stygian,
            L001D: ShowRunes(player, String0854); // An thou wouldst find help from on high,
            L002A: ShowRunes(player, String087C); // Then use the Cap of Phrygian.
            L0037: return; // RETURN;
        }

        private void Fn_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String089A); // When runes are seen yet make no sense,
            L0010: ShowRunes(player, String08C1); // They set thy head to stewin'
            L001D: ShowRunes(player, String08DE); // There's still a chance: do not be tense.
            L002A: ShowRunes(player, String0907); // An thou hast the Cap of Alcuin.
            L0037: ShowRunes(player, String0927); // But 'ware the usage of the cap.
            L0044: ShowRunes(player, String0947); // Thou wilt not be overjoyed.
            L0051: ShowRunes(player, String0963); // An thou dost use it like foolscap
            L005E: ShowRunes(player, String0985); // Thou wilt find thy cap destroyed.
            L006B: return; // RETURN;
        }

        private void Fn_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String09A7); // D: gYoun allcomM saw a volley dal
            L0010: return; // RETURN;
        }

        private void Fn_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String09C9); // D: siH cafe thob raif dan swimone
            L0010: return; // RETURN;
        }

        private void Fn_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String09EB); // D: If hout muts ghfti mih hent eb dlag
            L0010: return; // RETURN;
        }

        private void Fn_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0A12); // D: uToh wares het rnwoC of soCimrn
            L0010: return; // RETURN;
        }

        private void Fn_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0A35); // E: Mdgi moysry ie hpt Lhtsashi
            L0010: return; // RETURN;
        }

        private void Fn_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0A54); // E: 'Ttg hsio ta mrrr hge sdkeeaa
            L0010: return; // RETURN;
        }

        private void Fn_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0A75); // E: Utplus teys hahh a mrgstro giin
            L0010: return; // RETURN;
        }

        private void Fn_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0A98); // E: Agg wadddi a Lleeee Darnns.
            L0010: return; // RETURN;
        }

        private void Fn_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0AB7); // J: Tk dBfg oiea ihlaneol dqrsuctoe' ssome
            L0010: return; // RETURN;
        }

        private void Fn_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0AE1); // J: Tnbt fhewal oeo nyudnis entrgs
            L0010: return; // RETURN;
        }

        private void Fn_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0B03); // J: TBt otkhhh lhn hii oeue ealss etl t'ss
            L0010: return; // RETURN;
        }

        private void Fn_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0B2D); // J: TOs hdhrei yeat min ngsge.
            L0010: return; // RETURN;
        }

        private void Fn_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = GetFlag(player, 0x02, 0x42);
            L0017: si = si + 1;
            L0018: PushStack(player, 0x6A);
            L001C: PushStack(player, ax);
04D4  001D C4 5E 06  les bx, [bp+0x6]
04D7  0020 26 FF 5F 54  call far word [es:bx+0x54]
            L0024: cx = PopStack(player);
            L0025: cx = PopStack(player);
            L0026: RefreshCompareFlags(ax);
            L0028: if (JumpEqual) goto L006A;
            L002A: Compare(si, 0x06);
            L002D: if (JumpLessOrEqual) goto L003D;
            L002F: si = 0;
            L0031: RemoveItem(player, 0x6A);
            L003D: SetFlag(player, 0xC4, 0xB8, si);
            L004F: ShowMessage(player, String0B4B); // Alcuin's cap glows warm to the touch.  You can read the runes!
0513  005C B8 8A 0B  mov ax, 0xb8a
            L005F: PushStack(player, ax);
0517  0060 C4 5E 06  les bx, [bp+0x6]
051A  0063 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L0068: goto L0076;
            L006A: ShowRunes(player, String0BAF); // F: sashfff'rherMocugdctingiiiipt
            L0077: return; // RETURN (restoring si);
        }

        private void Fn_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = GetFlag(player, 0x02, 0x42);
            L0017: si = si + 1;
            L0018: PushStack(player, 0x6A);
            L001C: PushStack(player, ax);
054E  001D C4 5E 06  les bx, [bp+0x6]
0551  0020 26 FF 5F 54  call far word [es:bx+0x54]
            L0024: cx = PopStack(player);
            L0025: cx = PopStack(player);
            L0026: RefreshCompareFlags(ax);
            L0028: if (JumpEqual) goto L006A;
            L002A: Compare(si, 0x06);
            L002D: if (JumpLessOrEqual) goto L003D;
            L002F: si = 0;
            L0031: RemoveItem(player, 0x6A);
            L003D: SetFlag(player, 0xC4, 0xB8, si);
            L004F: ShowMessage(player, String0B4B); // Alcuin's cap glows warm to the touch.  You can read the runes!
058D  005C B8 D0 0B  mov ax, 0xbd0
            L005F: PushStack(player, ax);
0591  0060 C4 5E 06  les bx, [bp+0x6]
0594  0063 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L0068: goto L0076;
            L006A: ShowRunes(player, String0BF2); // F: illsetttcygaehirooffwWnn.
            L0077: return; // RETURN (restoring si);
        }

        private void Fn_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = GetFlag(player, 0x02, 0x42);
            L0017: si = si + 1;
            L0018: PushStack(player, 0x6A);
            L001C: PushStack(player, ax);
05C8  001D C4 5E 06  les bx, [bp+0x6]
05CB  0020 26 FF 5F 54  call far word [es:bx+0x54]
            L0024: cx = PopStack(player);
            L0025: cx = PopStack(player);
            L0026: RefreshCompareFlags(ax);
            L0028: if (JumpEqual) goto L006A;
            L002A: Compare(si, 0x06);
            L002D: if (JumpLessOrEqual) goto L003D;
            L002F: si = 0;
            L0031: RemoveItem(player, 0x6A);
            L003D: SetFlag(player, 0xC4, 0xB8, si);
            L004F: ShowMessage(player, String0B4B); // Alcuin's cap glows warm to the touch.  You can read the runes!
0607  005C B8 0F 0C  mov ax, 0xc0f
            L005F: PushStack(player, ax);
060B  0060 C4 5E 06  les bx, [bp+0x6]
060E  0063 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L0068: goto L0076;
            L006A: ShowRunes(player, String0C3A); // F: Iiahhuuldsknwwwnooooootttttffre
            L0077: return; // RETURN (restoring si);
        }

        private void Fn_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = GetFlag(player, 0x02, 0x42);
            L0017: si = si + 1;
            L0018: PushStack(player, 0x6A);
            L001C: PushStack(player, ax);
0642  001D C4 5E 06  les bx, [bp+0x6]
0645  0020 26 FF 5F 54  call far word [es:bx+0x54]
            L0024: cx = PopStack(player);
            L0025: cx = PopStack(player);
            L0026: RefreshCompareFlags(ax);
            L0028: if (JumpEqual) goto L006A;
            L002A: Compare(si, 0x06);
            L002D: if (JumpLessOrEqual) goto L003D;
            L002F: si = 0;
            L0031: RemoveItem(player, 0x6A);
            L003D: SetFlag(player, 0xC4, 0xB8, si);
            L004F: ShowMessage(player, String0B4B); // Alcuin's cap glows warm to the touch.  You can read the runes!
0681  005C B8 5D 0C  mov ax, 0xc5d
            L005F: PushStack(player, ax);
0685  0060 C4 5E 06  les bx, [bp+0x6]
0688  0063 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L0068: goto L0076;
            L006A: ShowRunes(player, String0C7E); // F: TtCfDsroowighheeennnuup.
            L0077: return; // RETURN (restoring si);
        }

        private void Fn_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = GetFlag(player, 0x02, 0x42);
            L0017: si = si + 1;
            L0018: PushStack(player, 0x6A);
            L001C: PushStack(player, ax);
06BC  001D C4 5E 06  les bx, [bp+0x6]
06BF  0020 26 FF 5F 54  call far word [es:bx+0x54]
            L0024: cx = PopStack(player);
            L0025: cx = PopStack(player);
            L0026: RefreshCompareFlags(ax);
            L0028: if (JumpEqual) goto L006A;
            L002A: Compare(si, 0x06);
            L002D: if (JumpLessOrEqual) goto L003D;
            L002F: si = 0;
            L0031: RemoveItem(player, 0x6A);
            L003D: SetFlag(player, 0xC4, 0xB8, si);
            L004F: ShowMessage(player, String0B4B); // Alcuin's cap glows warm to the touch.  You can read the runes!
06FB  005C B8 9A 0C  mov ax, 0xc9a
            L005F: PushStack(player, ax);
06FF  0060 C4 5E 06  les bx, [bp+0x6]
0702  0063 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L0068: goto L0076;
            L006A: ShowRunes(player, String0CC1); // G: aaaaaaaaa abbBc cc dddeeeeee ee eee
            L0077: return; // RETURN (restoring si);
        }

        private void Fn_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = GetFlag(player, 0x02, 0x42);
            L0017: si = si + 1;
            L0018: PushStack(player, 0x6A);
            L001C: PushStack(player, ax);
0736  001D C4 5E 06  les bx, [bp+0x6]
0739  0020 26 FF 5F 54  call far word [es:bx+0x54]
            L0024: cx = PopStack(player);
            L0025: cx = PopStack(player);
            L0026: RefreshCompareFlags(ax);
            L0028: if (JumpEqual) goto L006A;
            L002A: Compare(si, 0x06);
            L002D: if (JumpLessOrEqual) goto L003D;
            L002F: si = 0;
            L0031: RemoveItem(player, 0x6A);
            L003D: SetFlag(player, 0xC4, 0xB8, si);
            L004F: ShowMessage(player, String0B4B); // Alcuin's cap glows warm to the touch.  You can read the runes!
0775  005C B8 E8 0C  mov ax, 0xce8
            L005F: PushStack(player, ax);
0779  0060 C4 5E 06  les bx, [bp+0x6]
077C  0063 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L0068: goto L0076;
            L006A: ShowRunes(player, String0D08); // G: ffg gh hhhh hhhhH iii iikkll
            L0077: return; // RETURN (restoring si);
        }

        private void Fn_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = GetFlag(player, 0x02, 0x42);
            L0017: si = si + 1;
            L0018: PushStack(player, 0x6A);
            L001C: PushStack(player, ax);
07B0  001D C4 5E 06  les bx, [bp+0x6]
07B3  0020 26 FF 5F 54  call far word [es:bx+0x54]
            L0024: cx = PopStack(player);
            L0025: cx = PopStack(player);
            L0026: RefreshCompareFlags(ax);
            L0028: if (JumpEqual) goto L006A;
            L002A: Compare(si, 0x06);
            L002D: if (JumpLessOrEqual) goto L003D;
            L002F: si = 0;
            L0031: RemoveItem(player, 0x6A);
            L003D: SetFlag(player, 0xC4, 0xB8, si);
            L004F: ShowMessage(player, String0B4B); // Alcuin's cap glows warm to the touch.  You can read the runes!
07EF  005C B8 28 0D  mov ax, 0xd28
            L005F: PushStack(player, ax);
07F3  0060 C4 5E 06  les bx, [bp+0x6]
07F6  0063 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L0068: goto L0076;
            L006A: ShowRunes(player, String0D4F); // G: llll ll LmM nnnnn nnooooo pprr ssss
            L0077: return; // RETURN (restoring si);
        }

        private void Fn_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = GetFlag(player, 0x02, 0x42);
            L0017: si = si + 1;
            L0018: PushStack(player, 0x6A);
            L001C: PushStack(player, ax);
082A  001D C4 5E 06  les bx, [bp+0x6]
082D  0020 26 FF 5F 54  call far word [es:bx+0x54]
            L0024: cx = PopStack(player);
            L0025: cx = PopStack(player);
            L0026: RefreshCompareFlags(ax);
            L0028: if (JumpEqual) goto L006A;
            L002A: Compare(si, 0x06);
            L002D: if (JumpLessOrEqual) goto L003D;
            L002F: si = 0;
            L0031: RemoveItem(player, 0x6A);
            L003D: SetFlag(player, 0xC4, 0xB8, si);
            L004F: ShowMessage(player, String0B4B); // Alcuin's cap glows warm to the touch.  You can read the runes!
0869  005C B8 76 0D  mov ax, 0xd76
            L005F: PushStack(player, ax);
086D  0060 C4 5E 06  les bx, [bp+0x6]
0870  0063 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L0068: goto L0076;
            L006A: ShowRunes(player, String0D95); // G: sss ssssttt tttttTT uuwyy'
            L0077: return; // RETURN (restoring si);
        }

        private void Fn_36(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0DB3); // H:  Thou hast solved clues that I did brew
            L0010: ShowRunes(player, String0DDE); // H:  With means anagrammatic.
            L001D: ShowRunes(player, String0DFB); // H:  But these last clues are those that thou
            L002A: ShowRunes(player, String0E28); // H:  Solve with means cryptographic.
            L0037: return; // RETURN;
        }

        private void Fn_37(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x6A);
            L0007: PushStack(player, ax);
08C8  0008 C4 5E 06  les bx, [bp+0x6]
08CB  000B 26 FF 5F 54  call far word [es:bx+0x54]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0077;
            L0015: RemoveItem(player, 0x6A);
            L0021: SetFlag(player, 0x02, 0x42, 0x00);
            L0035: ShowMessage(player, String0E4C); // Alcuin's cap glows red hot, and then dissolves into wisps of steam.  But at least you get to read the runes!
            L0042: ShowMessage(player, String0EB9); // I: The Healing Locket's all that might
            L004F: ShowMessage(player, String0EE0); // I: Ward off my sisters's power.
            L005C: ShowMessage(player, String0F00); // I: Use it steadfastly through the fight
0929  0069 B8 28 0F  mov ax, 0xf28
            L006C: PushStack(player, ax);
092D  006D C4 5E 06  les bx, [bp+0x6]
0930  0070 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L0075: goto L00AA;
            L0077: ShowRunes(player, String0F4A); // I:  Bkw Kwqgmoy Glhuwb'c qgg bkqb amykb
            L0084: ShowRunes(player, String0F72); // I:  Nqti ljj ap cmcbwtc'c flnwt.
            L0091: ShowRunes(player, String0F93); // I:  Scw mb cbwqijqcbgp bktlsyk bkw jmykb
            L009E: ShowRunes(player, String0FBC); // I:  Qoi nqbhk mb aquw bkwa yglnwt.
            L00AB: return; // RETURN;
        }

        private void Fn_38(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x3C));
            L0016: if (JumpNotEqual) goto L003D;
            L0018: RefreshCompareFlags(GetFlag(player, 0x02, 0x14));
            L002B: if (JumpNotEqual) goto L003D;
            L002D: ShowMessage(player, String0FDF); // The doors refuse to budge.
            L003A: goto L013E;
            L003D: Compare(PartyCount(player), 0x0001);
            L0048: if (JumpBelowOrEqual) goto L005A;
            L004A: ShowMessage(player, String0FFA); // These narrow stairs will force you to descend single file.
            L0057: goto L013E;
            L005A: ShowMessage(player, String1035); // Whoever last passed these doors did not pull them to.  You carefully make sure they stay ajar as you pass.  They lead to stairs descending into darkness.
            L0067: ax = HasItem(player, 0x38);
            L0075: if (JumpEqual) goto L00AD;
            L0077: ax = HasItem(player, 0x88);
            L0085: if (JumpEqual) goto L00AD;
            L0087: ax = HasItem(player, 0x95);
            L0095: if (JumpEqual) goto L00AD;
            L0097: Compare(GetFlag(player, 0x02, 0x3E), 0x0001);
            L00AB: if (JumpEqual) goto L00C3;
            L00AD: Compare(GetFlag(player, 0x02, 0x43), 0x0001);
            L00C1: if (JumpNotEqual) goto L0123;
            L00C3: ShowMessage(player, String10CF); // A beatific figure, old, wise, and happy, appears before you.
            L00D0: ShowMessage(player, String110C); // 'I am Aldhelm.  Long have I hoped to aid one of good heart in ridding this earth of the canker of the Wyrd Sisters.
            L00DD: ShowMessage(player, String1180); // There is a secret path, somewhat safer, that will lead thee to thy goal.  It will bypass many fiercesome beasts set here to sap thy will and vigor.  Take it, and my blessing.'
            L00EA: ax = HasItem(player, 0xA3);
            L00F8: if (JumpNotEqual) goto L0106;
            L00FA: GiveItem(player, 0xA3);
            L0106: SetFlag(player, 0x02, 0x43, 0x01);
            L011B: PushStack(player, 0x02);
0A8C  011F 33 C0  xor ax, ax
            L0121: goto L012A;
            L0123: TeleportParty(player, 0x0A, 0x02, 0x10, 0x02, isForwardMove);
            L013E: return; // RETURN;
        }

        private void Fn_39(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x00);
            L0006: PushStack(player, 0xAF);
            L000A: PushStack(player, 0x01);
            L000E: PushStack(player, ax);
0ABC  000F C4 5E 06  les bx, [bp+0x6]
0ABF  0012 26 FF 9F BC 00  call far word [es:bx+0xbc]
0AC4  0017 83 C4 08  add sp, 0x8
            L001A: return; // RETURN;
        }

        private void Fn_3A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0x1F, 0x01);
            L0018: return; // RETURN;
        }

        private void Fn_3C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String1230); // C:  Fancel epadsce teh mrrrduee's balde
            L0010: return; // RETURN;
        }

        private void Fn_3D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String1258); // C:  Btu he sllit flees hsi golom.
            L0010: return; // RETURN;
        }

        private void Fn_3E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String127A); // C:  If thuo wosdutl bets daeeft hsi shead
            L0010: return; // RETURN;
        }

        private void Fn_3F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String12A4); // C:  Tehn wedil teh Cckar of Dmoo.
            L0010: return; // RETURN;
        }

        private void Fn_40(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x49));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L0110;
            L001B: SetFlag(player, 0x02, 0x49, 0x01);
            L0030: ShowPortrait(player, 0x000E);
            L003D: ShowMessage(player, String12C6); // *
            L004A: ShowMessage(player, String12C6); // *
            L0057: ShowMessage(player, String12C6); // *
            L0064: ShowMessage(player, String12C8); // By all the fins and feathers!  An enormous red dragon rears up and speaks to you.
            L0071: RefreshCompareFlags(GetFlag(player, 0x02, 0x54));
            L0084: if (JumpNotEqual) goto L00B5;
            L0086: RefreshCompareFlags(GetFlag(player, 0x02, 0x4A));
            L0099: if (JumpNotEqual) goto L00B5;
            L009B: RefreshCompareFlags(GetFlag(player, 0x02, 0x4B));
            L00AE: if (JumpNotEqual) goto L00B5;
0BE0  00B0 B8 1A 13  mov ax, 0x131a
            L00B3: goto L00B8;
            L00B5: ShowMessage(player, String13E5); // 'Ah!  I remember thee.  As I recall, thou didst enjoy my last joke.  Wouldst thou hear another?'
            L00C2: ShowMessage(player, String1446); // You quickly nod.
            L00CF: ShowMessage(player, String1457); // 'There was a very stupid green dragon named Gwalter the Dim.  Do not laugh yet!  One day Gwalter received three wishes from a djinn.  For his first wish he asked for a bag that would always be full of gold, no matter how much he removed.  Lo and behold!  His wish was granted.
            L00DC: ShowMessage(player, String156C); // The genie asked what he wanted for his other wishes.  Gwalter asked for two more of those bags.  Get it?'
            L00E9: ShowMessage(player, String15D6); // You laugh politely.
            L00F6: ShowMessage(player, String15EA); // 'Good enough.  But remember; 'tis only the green drakes that exhibit such stupidity.  I shall remember thee.'
            L0103: ShowMessage(player, String1658); // The dragon departs.
            L0110: return; // RETURN;
        }

        private void Fn_41(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x01));
            L0016: if (JumpNotEqual) goto L0078;
            L0018: PushStack(player, 0x01);
            L001C: PushStack(player, ax);
            L001D: PushStack(player, 0x03);
0C63  0021 C4 5E 06  les bx, [bp+0x6]
0C66  0024 26 FF 1F  call far word [es:bx]
0C69  0027 83 C4 06  add sp, 0x6
            L002A: ShowPortrait(player, 0x0029);
            L0037: ShowMessage(player, String166C); // A halfling cleric approaches you surreptitiously.
            L0044: ShowMessage(player, String169E); // 'Psst!  Cuz!  Thou dost look like a being of wit and wisdom.  I will gladly share with thee a great secret.'
            L0051: ShowMessage(player, String170B); // He opens his coat to show, pinned to the inside, a slightly turned pig's foot.
            L005E: ShowMessage(player, String175A); // 'This is the Lucky Pig's Foot.  It is the sovereign against dragons, for wyrms cannot abide the smell of burnt pig's foot.  Thou needst only to brandish it boldly before thee in battle....'
            L006B: ShowMessage(player, String1818); // His voice trails off as he sees someone approaching, waving another lucky pig's foot.  'Anon!'
            L0078: return; // RETURN;
        }

    }
}
