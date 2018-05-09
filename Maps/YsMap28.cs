#pragma warning disable
using ZCF.WorldData;

namespace ZCF.Scripts.Maps {
    class YserMap28 : AMapScript {
        // === Strings ================================================
        private const string String03FC = "The AldBora Tree bears... ";
        private const string String0417 = "the knowledge of Athletics!";
        private const string String0433 = "the knowledge of Clubs and Axes!";
        private const string String0454 = "the knowledge of Berserker!";
        private const string String0470 = "the knowledge of Pursuit!";
        private const string String048A = "the knowledge of Leadership!";
        private const string String04A7 = "the knowledge of Fencing!";
        private const string String04C1 = "the knowledge of Binding!";
        private const string String04DB = "the knowledge of Intimidation!";
        private const string String04FA = "the knowledge of Archery!";
        private const string String0514 = "the knowledge of Stamina!";
        private const string String052E = "the knowledge of Furtiveness!";
        private const string String054C = "the knowledge of Reading Tracks!";
        private const string String056D = "the knowledge of Martial Arts!";
        private const string String058C = "the knowledge of Deflect Magic!";
        private const string String05AC = "the knowledge of Medic!";
        private const string String05C4 = "the knowledge of Reverie!";
        private const string String05DE = "the knowledge of Rune Reading!";
        private const string String05FD = "the knowledge of Staff!";
        private const string String0615 = "the knowledge of Channeling!";
        private const string String0632 = "the knowledge of Deep Trance!";
        private const string String0650 = "The leaves whisper, 'Defeat my enemies the four winds, South, North, East and West, and you will find a precious gem as green as my foliage.'";
        private const string String06DE = "Spring flowers and new leaves appear on the magical Aldbora Tree.";
        private const string String0720 = "The Aldbora Tree proudly displays its summer foliage.";
        private const string String0756 = "Golden Autumn leaves fall from the Aldbora Tree.";
        private const string String0787 = "In the Winter, the Aldbora Tree shows its age.  The fruits of Knowledge are now ripe.";
        private const string String07DD = "Dwarven Knights attempt an ambush.";
        private const string String0800 = "You see scattered bones and a bag under a Dragon.";
        private const string String0832 = "A glowing yellow gem lights the area.";
        private const string String0858 = "A path leads up to CASTLEGATE";
        private const string String0876 = "A narrow tunnel appears, leading down to the DWARF KINGDOM.";
        private const string String08B2 = "At level thirty, the entrance to the land of dwarfs will be open to you.";
        private const string String08FB = "Upon a wood sign is written -- 'Wilderness of BeechWood.'";
        private const string String0935 = "A wreath of leaves encircles the words -- 'Wilderness of OakLeaf.'";
        private const string String0978 = "A sign of ancient wood reads -- 'Wilderness of MapleBrush.'";
        private const string String09B4 = "In the dust of pine needles is written -- 'Wilderness of PineCone.'";
        private const string String09F8 = "We are the Wise Ones of Beechwood who serve the Seasons.";
        private const string String0A31 = "I am Lobard, and the Season I serve is gentle Spring.";
        private const string String0A67 = "The soft breezes of Spring warned me of your coming.";
        private const string String0A9C = "Wise are they who know how to please my master.";
        private const string String0ACC = "My name is Shushian, servant to vibrant Summer.";
        private const string String0AFC = "The Summer gently warms those who serve it and parches those who anger it.";
        private const string String0B47 = "Why have you come to me in these sultry days of Summer?";
        private const string String0B7F = "Distly Bombak, the vassal of Autumn, greets you.";
        private const string String0BB0 = "Lovely Autumn in its varicolored foliage urges you to gather in your harvest before harsh Winter comes.";
        private const string String0C18 = "Autumn begins to fade, and so asks why you have come.";
        private const string String0C4E = "You may call me Karakiar, since that is my name. My liege is Winter.";
        private const string String0C93 = "The bracing sting of Winter's winds refresh those who love its white wonderland.";
        private const string String0CE4 = "Winter would know why you are here.";
        private const string String0D08 = "Spring thanks you for the Winter Waters.";
        private const string String0D31 = "See how soft Spring transforms into vibrant Summer!";
        private const string String0D65 = "Take this Summer Radiance for your troubles.";
        private const string String0D92 = "You dishonor Spring with your false gift.";
        private const string String0DBC = "Summer rejoices in the wondrous Harvest Horn.";
        private const string String0DEA = "Behold!  Summer ripens into mature Autumn!";
        private const string String0E15 = "The golden Autumn Seeds are ample reward for your generosity.";
        private const string String0E53 = "Summer burns in anger at your false gift.  Begone!";
        private const string String0E86 = "Autumn gladly accepts the Spring Renewal.";
        private const string String0EB0 = "Lo!  Golden Autumn pales to white Winter and now sleeps under snowy blankets.";
        private const string String0EFE = "These icy Winter Waters are a present to you.";
        private const string String0F2C = "Autumn is angry that you mock it with a false gift.";
        private const string String0F60 = "These Autumn Seeds are wonderful, indeed!";
        private const string String0F8A = "See sleeping Winter blossom with new life!";
        private const string String0FB5 = "You now receive the glory of Spring Renewal.  It is a priceless gift!";
        private const string String0FFB = "Winter turns a cold back on your poor gift.";
        private const string String1027 = "Leave before Winter blasts you!";
        private const string String1047 = "That item is of no interest to my master.";
        private const string String1071 = "We are the Clerics of Oakleaf who comfort the Seasons.";
        private const string String10A8 = "Call me Donbard.  I ease the distress of gentle Spring.";
        private const string String10E0 = "Spring quakes in fear at your coming.";
        private const string String1106 = "Why have you come to Spring's home?";
        private const string String112A = "I am Shashamia, friend to the temperate Summer.";
        private const string String115A = "Sullen summer is nervous around mortals.";
        private const string String1183 = "Do you have some business with Summer?";
        private const string String11AA = "Dindly Bindiak is my name.  Autumn is my friend.";
        private const string String11DB = "Russet-clad Autumn welcomes you if you are true friends of the Seasons.";
        private const string String1223 = "Autumn will fade away unless you tell me why you have come.";
        private const string String125F = "I am called Kalakial, and I help poor Winter.";
        private const string String128D = "Wistful Winter is too shy to speak to you directly.";
        private const string String12C1 = "Winter wishes you to leave, so do quickly what you came to do.";
        private const string String1300 = "Spring accepts the Winter Waters.";
        private const string String1322 = "Spring sings sweetly of its transformation into Summer!";
        private const string String135A = "Summer Radiance is yours as happy reward.";
        private const string String1384 = "Spring departs at the sight of your poor gift.";
        private const string String13B3 = "Summer accepts the Harvest Horn.";
        private const string String13D4 = "Summer mellows by the sweet music and is now Autumn!";
        private const string String1409 = "Autumn Seeds are now yours to enjoy.";
        private const string String142E = "Summer shies away from your pitiful gift.";
        private const string String1458 = "Autumn shyly receives the Spring Renewal.";
        private const string String1482 = "Now Autumn turns to Winter, still clutching the hope of vernal renewal.";
        private const string String14CA = "Winter Waters are yours, my friends.";
        private const string String14EF = "Autumn rejects your horrid gift.";
        private const string String1510 = "Autumn Seeds hold the germ of life!";
        private const string String1534 = "Cold Winter is become warm Spring.  Rejoice!";
        private const string String1561 = "The magnificent Spring Renewal is your just reward.";
        private const string String1595 = "Winter weeps at your cruelty.";
        private const string String15B3 = "No season is interested in the item you offer.";
        private const string String15E2 = "We are the Wardens of Maplebrush and hold the Seasons.";
        private const string String1619 = "You may not know my name.";
        private const string String1633 = "It is Spring.  That is all you need know.";
        private const string String165D = "My name is my secret.";
        private const string String1673 = "It is Summer. That is all I'll say.";
        private const string String1697 = "Never mind what my name is.";
        private const string String16B3 = "It is Autumn.  That is enough for now.";
        private const string String16DA = "Not even I know my true name.";
        private const string String16F8 = "It is Winter.  I may say no more.";
        private const string String171A = "From Winter Waters comes the change of Spring to Summer.";
        private const string String1753 = "You are rewarded.";
        private const string String1765 = "Wrong gift, mortal!";
        private const string String1779 = "The Harvest Horn blows Summer into Autumn.";
        private const string String17A4 = "A reward is yours.";
        private const string String17B7 = "Wrong present, mortal!";
        private const string String17CE = "The Spring Renewal eases Autumn's slide into Winter.";
        private const string String1803 = "Enjoy your reward.";
        private const string String1816 = "Not even close, mortal!";
        private const string String182E = "Winter devours the Autumn Seeds and becomes Spring.";
        private const string String1862 = "You are well rewarded.";
        private const string String1879 = "Wrong, wrong, wrong, mortal!";
        private const string String1896 = "Why do you offer the seasons such a thing?";
        private const string String18C1 = "We are the Seasons incarnate in mortal form.";
        private const string String18EE = "I am Spring";
        private const string String18FA = "I am Summer";
        private const string String1906 = "I am Autumn";
        private const string String1912 = "I am Winter";
        private const string String191E = "The Winter Waters you offer quench my thirst.";
        private const string String194C = "Look how I have become Summer!";
        private const string String196B = "Take my new Summer Radiance.";
        private const string String1988 = "I have no need for that item.";
        private const string String19A6 = "I blow the Harvest Horn you give me...";
        private const string String19CD = "...and I change to Autumn!";
        private const string String19E8 = "Have some of my Autumn Seeds as thanks.";
        private const string String1A10 = "The present you offer I must reject.";
        private const string String1A35 = "Because you give me Spring Renewal...";
        private const string String1A5B = "...I can safely transform into Winter and still survive.";
        private const string String1A94 = "May my Winter Waters refresh you.";
        private const string String1AB6 = "I cannot accept your present.";
        private const string String1AD4 = "The Autumn Seeds awaken me from my long hibernation.";
        private const string String1B09 = "I am Spring again!";
        private const string String1B1C = "Take the Renewal of Spring and rejoice with me!";
        private const string String1B4C = "I have no use for what you offer.";
        private const string String1B6E = "We Seasons cannot use the item you offer.";
        private const string String1B98 = "'Welcome, Adventurer.  I am Varstad, counselor to the Elf King.";
        private const string String1BD8 = "The magic Aldbora requires Summer Radiance to shed its knowledge fruit.'";
        private const string String1C21 = "The storyteller Sorshian honors your arrival.";
        private const string String1C4F = "'Only when the season is winter will the Aldbora shed its fruit.'";
        private const string String1C91 = "A wooden sign says, 'To the cave of NeedleWood.'";
        private const string String1CC2 = "The door unlocks.";
        private const string String1CD4 = "Young elves scurry and hide when you enter this elf home.";
        private const string String1D0E = "Carvings of elfin rangers crossing glacial landscapes proudly mount the walls of a typical elfin dwelling.";
        private const string String1D79 = "'I am Fernank, Hunter to the Elf King.";
        private const string String1DA0 = "It is known in the trees that Nature's Robe must be used for the harvest.'";
        
        // === Functions ================================================
        protected override MapEventHandler MapEvent01 => FnALDBORA_01;
        private void FnALDBORA_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ax = CheckState04(party, 0x01, 0x01);
            L0015: si = ax;
            L0017: ax = UsedItem54(party, 0xE8, 0xE8);
            L002A: if (!CompareResultEqual) goto L002F;
            L002C: goto L0414;
            L002F: Compare(si, 0x04);
            L0032: if (CompareResultEqual) goto L0037;
            L0034: goto L0414;
            L0037: ax = HasItem50(party, 0xE9);
            L0045: if (!CompareResultEqual) goto L004A;
            L0047: goto L0414;
            L004A: ShowMessage(party, String03FC); // The AldBora Tree bears... 
            L0057: RemoveItem4C(party, 0xE8);
            L0063: RemoveItem4C(party, 0xE9);
            L006F: ax = GetSkillLevel5C(party, 0x00);
            L007A: RefreshCompareFlags(ax);
            L007C: if (!CompareResultEqual) goto L009B;
            L007E: SetSkillLevel60(party, 0x00, 0x02);
            L008E: ShowMessage(party, String0417); // the knowledge of Athletics!
            L009B: ax = GetSkillLevel5C(party, 0x01);
            L00A7: RefreshCompareFlags(ax);
            L00A9: if (!CompareResultEqual) goto L00C9;
            L00AB: SetSkillLevel60(party, 0x01, 0x02);
            L00BC: ShowMessage(party, String0433); // the knowledge of Clubs and Axes!
            L00C9: ax = GetSkillLevel5C(party, 0x02);
            L00D5: RefreshCompareFlags(ax);
            L00D7: if (!CompareResultEqual) goto L00F7;
            L00D9: SetSkillLevel60(party, 0x02, 0x02);
            L00EA: ShowMessage(party, String0454); // the knowledge of Berserker!
            L00F7: ax = GetSkillLevel5C(party, 0x03);
            L0103: RefreshCompareFlags(ax);
            L0105: if (!CompareResultEqual) goto L0125;
            L0107: SetSkillLevel60(party, 0x03, 0x02);
            L0118: ShowMessage(party, String0470); // the knowledge of Pursuit!
            L0125: ax = GetSkillLevel5C(party, 0x04);
            L0131: RefreshCompareFlags(ax);
            L0133: if (!CompareResultEqual) goto L0153;
            L0135: SetSkillLevel60(party, 0x04, 0x02);
            L0146: ShowMessage(party, String048A); // the knowledge of Leadership!
            L0153: ax = GetSkillLevel5C(party, 0x05);
            L015F: RefreshCompareFlags(ax);
            L0161: if (!CompareResultEqual) goto L0181;
            L0163: SetSkillLevel60(party, 0x05, 0x02);
            L0174: ShowMessage(party, String04A7); // the knowledge of Fencing!
            L0181: ax = GetSkillLevel5C(party, 0x06);
            L018D: RefreshCompareFlags(ax);
            L018F: if (!CompareResultEqual) goto L01AF;
            L0191: SetSkillLevel60(party, 0x06, 0x02);
            L01A2: ShowMessage(party, String04C1); // the knowledge of Binding!
            L01AF: ax = GetSkillLevel5C(party, 0x07);
            L01BB: RefreshCompareFlags(ax);
            L01BD: if (!CompareResultEqual) goto L01DD;
            L01BF: SetSkillLevel60(party, 0x07, 0x02);
            L01D0: ShowMessage(party, String04DB); // the knowledge of Intimidation!
            L01DD: ax = GetSkillLevel5C(party, 0x08);
            L01E9: RefreshCompareFlags(ax);
            L01EB: if (!CompareResultEqual) goto L020B;
            L01ED: SetSkillLevel60(party, 0x08, 0x02);
            L01FE: ShowMessage(party, String04FA); // the knowledge of Archery!
            L020B: ax = GetSkillLevel5C(party, 0x09);
            L0217: RefreshCompareFlags(ax);
            L0219: if (!CompareResultEqual) goto L0239;
            L021B: SetSkillLevel60(party, 0x09, 0x02);
            L022C: ShowMessage(party, String0514); // the knowledge of Stamina!
            L0239: ax = GetSkillLevel5C(party, 0x0A);
            L0245: RefreshCompareFlags(ax);
            L0247: if (!CompareResultEqual) goto L0267;
            L0249: SetSkillLevel60(party, 0x0A, 0x02);
            L025A: ShowMessage(party, String052E); // the knowledge of Furtiveness!
            L0267: ax = GetSkillLevel5C(party, 0x0B);
            L0273: RefreshCompareFlags(ax);
            L0275: if (!CompareResultEqual) goto L0295;
            L0277: SetSkillLevel60(party, 0x0B, 0x02);
            L0288: ShowMessage(party, String054C); // the knowledge of Reading Tracks!
            L0295: ax = GetSkillLevel5C(party, 0x10);
            L02A1: RefreshCompareFlags(ax);
            L02A3: if (!CompareResultEqual) goto L02C3;
            L02A5: SetSkillLevel60(party, 0x10, 0x02);
            L02B6: ShowMessage(party, String056D); // the knowledge of Martial Arts!
            L02C3: ax = GetSkillLevel5C(party, 0x11);
            L02CF: RefreshCompareFlags(ax);
            L02D1: if (!CompareResultEqual) goto L02F1;
            L02D3: SetSkillLevel60(party, 0x11, 0x02);
            L02E4: ShowMessage(party, String058C); // the knowledge of Deflect Magic!
            L02F1: ax = GetSkillLevel5C(party, 0x12);
            L02FD: RefreshCompareFlags(ax);
            L02FF: if (!CompareResultEqual) goto L031F;
            L0301: SetSkillLevel60(party, 0x12, 0x02);
            L0312: ShowMessage(party, String05AC); // the knowledge of Medic!
            L031F: ax = GetSkillLevel5C(party, 0x13);
            L032B: RefreshCompareFlags(ax);
            L032D: if (!CompareResultEqual) goto L034D;
            L032F: SetSkillLevel60(party, 0x13, 0x02);
            L0340: ShowMessage(party, String05C4); // the knowledge of Reverie!
            L034D: ax = GetSkillLevel5C(party, 0x14);
            L0359: RefreshCompareFlags(ax);
            L035B: if (!CompareResultEqual) goto L037B;
            L035D: SetSkillLevel60(party, 0x14, 0x02);
            L036E: ShowMessage(party, String05DE); // the knowledge of Rune Reading!
            L037B: ax = GetSkillLevel5C(party, 0x15);
            L0387: RefreshCompareFlags(ax);
            L0389: if (!CompareResultEqual) goto L03A9;
            L038B: SetSkillLevel60(party, 0x15, 0x02);
            L039C: ShowMessage(party, String05FD); // the knowledge of Staff!
            L03A9: ax = GetSkillLevel5C(party, 0x16);
            L03B5: RefreshCompareFlags(ax);
            L03B7: if (!CompareResultEqual) goto L03D7;
            L03B9: SetSkillLevel60(party, 0x16, 0x02);
            L03CA: ShowMessage(party, String0615); // the knowledge of Channeling!
            L03D7: ax = GetSkillLevel5C(party, 0x17);
            L03E3: RefreshCompareFlags(ax);
            L03E5: if (!CompareResultEqual) goto L0405;
            L03E7: SetSkillLevel60(party, 0x17, 0x02);
            L03F8: ShowMessage(party, String0632); // the knowledge of Deep Trance!
            L0405: ShowMessage(party, String0650); // The leaves whisper, 'Defeat my enemies the four winds, South, North, East and West, and you will find a precious gem as green as my foliage.'
            L0412: goto L045F;
            L0414: bx = si;
            L0416: bx = bx - 1;
            L0417: Compare(bx, 0x03);
            L041A: if (CompareResultUnsignedGreaterThan) goto L045F;
            L041C: switch (bx) {
                case 0:
                    goto L0423;
                case 1:
                    goto L0432;
                case 2:
                    goto L0441;
                case 3:
                    goto L0450;
            }
            L0423: ShowMessage(party, String06DE); // Spring flowers and new leaves appear on the magical Aldbora Tree.
            L0430: goto L045F;
            L0432: ShowMessage(party, String0720); // The Aldbora Tree proudly displays its summer foliage.
            L043F: goto L045F;
            L0441: ShowMessage(party, String0756); // Golden Autumn leaves fall from the Aldbora Tree.
            L044E: goto L045F;
            L0450: ShowMessage(party, String0787); // In the Winter, the Aldbora Tree shows its age.  The fruits of Knowledge are now ripe.
            L045D: goto L045F;
            L045F: return; // RETURN (restoring si);
        }

        protected override MapEventHandler MapEvent02 => FnENCA_02;
        private void FnENCA_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String07DD); // Dwarven Knights attempt an ambush.
            L0010: AddEncounter(party, 0x01, 0x20);
            L0022: AddEncounter(party, 0x02, 0x20);
            L0034: AddEncounter(party, 0x05, 0x22);
            L0046: AddEncounter(party, 0x06, 0x22);
            L0058: return; // RETURN;
        }

        protected override MapEventHandler MapEvent03 => FnENCB_03;
        private void FnENCB_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x1F);
            L0015: AddEncounter(party, 0x02, 0x1E);
            L0027: AddEncounter(party, 0x03, 0x1D);
            L0039: AddEncounter(party, 0x04, 0x1B);
            L004B: AddEncounter(party, 0x05, 0x23);
            L005D: AddEncounter(party, 0x06, 0x23);
            L006F: return; // RETURN;
        }

        protected override MapEventHandler MapEvent04 => FnENCC_04;
        private void FnENCC_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x1F);
            L0015: AddEncounter(party, 0x02, 0x1F);
            L0027: AddEncounter(party, 0x03, 0x24);
            L0039: AddEncounter(party, 0x04, 0x19);
            L004B: return; // RETURN;
        }

        protected override MapEventHandler MapEvent05 => FnENCD_05;
        private void FnENCD_05(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x18);
            L0015: AddEncounter(party, 0x02, 0x1A);
            L0027: AddEncounter(party, 0x03, 0x26);
            L0039: AddEncounter(party, 0x04, 0x26);
            L004B: AddEncounter(party, 0x05, 0x22);
            L005D: AddEncounter(party, 0x06, 0x22);
            L006F: return; // RETURN;
        }

        protected override MapEventHandler MapEvent06 => FnENCE_06;
        private void FnENCE_06(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x14);
            L0015: AddEncounter(party, 0x02, 0x16);
            L0027: AddEncounter(party, 0x03, 0x26);
            L0039: AddEncounter(party, 0x04, 0x27);
            L004B: return; // RETURN;
        }

        protected override MapEventHandler MapEvent07 => FnENCF_07;
        private void FnENCF_07(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xFA);
            L0011: if (CompareResultEqual) goto L0034;
            L0013: AddTreasure(party, 0x012C, 0x00, 0x00, 0x00, 0x00, 0xCE);
            L0032: goto L0061;
            L0034: AddTreasure(party, 0x012C, 0x00, 0x00, 0x00, 0xD0, 0xFA);
            L0054: ShowMessage(party, String0800); // You see scattered bones and a bag under a Dragon.
            L0061: AddEncounter(party, 0x01, 0x1B);
            L0073: AddEncounter(party, 0x02, 0x1B);
            L0085: AddEncounter(party, 0x03, 0x19);
            L0097: AddEncounter(party, 0x04, 0x19);
            L00A9: return; // RETURN;
        }

        protected override MapEventHandler MapEvent08 => FnENCG_08;
        private void FnENCG_08(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x1A);
            L0015: AddEncounter(party, 0x02, 0x1A);
            L0027: AddEncounter(party, 0x03, 0x1B);
            L0039: AddEncounter(party, 0x04, 0x1B);
            L004B: return; // RETURN;
        }

        protected override MapEventHandler MapEvent09 => FnENCH_09;
        private void FnENCH_09(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x21);
            L0015: AddEncounter(party, 0x02, 0x22);
            L0027: AddEncounter(party, 0x05, 0x26);
            L0039: AddEncounter(party, 0x06, 0x28);
            L004B: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0A => FnENCI_0A;
        private void FnENCI_0A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x1C);
            L0015: AddEncounter(party, 0x02, 0x1C);
            L0027: AddEncounter(party, 0x03, 0x22);
            L0039: AddEncounter(party, 0x04, 0x22);
            L004B: ax = HasItem50(party, 0xF5);
            L0059: if (CompareResultEqual) goto L007D;
            L005B: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0xCF, 0xC6);
            L007B: goto L00AB;
            L007D: ShowMessage(party, String0832); // A glowing yellow gem lights the area.
            L008A: AddTreasure(party, 0x2710, 0x00, 0x00, 0xD0, 0xD0, 0xF5);
            L00AB: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0B => FnCGATE_0B;
        private void FnCGATE_0B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0858); // A path leads up to CASTLEGATE
            L0010: SetMoveMap(party, 0x36, 0x01, 0x74, 0x01);
            L002B: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0C => FnDWARF_0C;
        private void FnDWARF_0C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckLevel44(party, 0x001E);
            L0011: if (CompareResultEqual) goto L003D;
            L0013: ShowMessage(party, String0876); // A narrow tunnel appears, leading down to the DWARF KINGDOM.
            L0020: SetMoveMap(party, 0x38, 0x01, 0x7A, 0x02);
            L003B: goto L004A;
            L003D: ShowRunes(party, String08B2); // At level thirty, the entrance to the land of dwarfs will be open to you.
            L004A: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0D => FnNOJOIN_0D;
        private void FnNOJOIN_0D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TileIsNoJoinArea(party);
            L000B: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0E => FnBEECHWD_0E;
        private void FnBEECHWD_0E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String08FB); // Upon a wood sign is written -- 'Wilderness of BeechWood.'
            L0010: ax = CheckState04(party, 0x01, 0x01);
            L0021: RefreshCompareFlags(ax);
            L0023: if (!CompareResultEqual) goto L0079;
            L0025: SetState00(party, 0x01, 0x03, 0x01);
            L003A: SetState00(party, 0x01, 0x02, 0x02);
            L004F: SetState00(party, 0x01, 0x01, 0x03);
            L0064: SetState00(party, 0x01, 0x04, 0x04);
            L0079: return; // RETURN;
        }

        protected override MapEventHandler MapEvent0F => FnOAKLEAF_0F;
        private void FnOAKLEAF_0F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0935); // A wreath of leaves encircles the words -- 'Wilderness of OakLeaf.'
            L0010: ax = CheckState04(party, 0x01, 0x02);
            L0021: RefreshCompareFlags(ax);
            L0023: if (!CompareResultEqual) goto L0079;
            L0025: SetState00(party, 0x01, 0x03, 0x01);
            L003A: SetState00(party, 0x01, 0x02, 0x02);
            L004F: SetState00(party, 0x01, 0x01, 0x03);
            L0064: SetState00(party, 0x01, 0x04, 0x04);
            L0079: return; // RETURN;
        }

        protected override MapEventHandler MapEvent10 => FnMAPLEBRS_10;
        private void FnMAPLEBRS_10(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0978); // A sign of ancient wood reads -- 'Wilderness of MapleBrush.'
            L0010: ax = CheckState04(party, 0x01, 0x03);
            L0021: RefreshCompareFlags(ax);
            L0023: if (!CompareResultEqual) goto L0079;
            L0025: SetState00(party, 0x01, 0x03, 0x01);
            L003A: SetState00(party, 0x01, 0x02, 0x02);
            L004F: SetState00(party, 0x01, 0x01, 0x03);
            L0064: SetState00(party, 0x01, 0x04, 0x04);
            L0079: return; // RETURN;
        }

        protected override MapEventHandler MapEvent11 => FnPINECONE_11;
        private void FnPINECONE_11(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String09B4); // In the dust of pine needles is written -- 'Wilderness of PineCone.'
            L0010: ax = CheckState04(party, 0x01, 0x04);
            L0021: RefreshCompareFlags(ax);
            L0023: if (!CompareResultEqual) goto L0079;
            L0025: SetState00(party, 0x01, 0x03, 0x01);
            L003A: SetState00(party, 0x01, 0x02, 0x02);
            L004F: SetState00(party, 0x01, 0x01, 0x03);
            L0064: SetState00(party, 0x01, 0x04, 0x04);
            L0079: return; // RETURN;
        }

        protected override MapEventHandler MapEvent12 => FnBWACTOR_12;
        private void FnBWACTOR_12(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(party, String09F8); // We are the Wise Ones of Beechwood who serve the Seasons.
            L0011: ShowPortrait(party, 0x0027);
            L001E: ax = CheckState04(party, 0x01, 0x01);
            L002F: si = ax;
            L0031: bx = si;
            L0033: bx = bx - 1;
            L0034: Compare(bx, 0x03);
            L0037: if (CompareResultEqual || CompareResultUnsignedLessThan) goto L003C;
            L0039: goto L00E8;
            L003C: switch (bx) {
                case 0:
                    goto L0043;
                case 1:
                    goto L006D;
                case 2:
                    goto L0096;
                case 3:
                    goto L00BF;
            }
            L0043: ShowMessage(party, String0A31); // I am Lobard, and the Season I serve is gentle Spring.
            L0050: ShowMessage(party, String0A67); // The soft breezes of Spring warned me of your coming.
            L005D: ShowMessage(party, String0A9C); // Wise are they who know how to please my master.
            L006A: goto L00E8;
            L006C: // NOP
            L006D: ShowMessage(party, String0ACC); // My name is Shushian, servant to vibrant Summer.
            L007A: ShowMessage(party, String0AFC); // The Summer gently warms those who serve it and parches those who anger it.
            L0087: ShowMessage(party, String0B47); // Why have you come to me in these sultry days of Summer?
            L0094: goto L00E8;
            L0096: ShowMessage(party, String0B7F); // Distly Bombak, the vassal of Autumn, greets you.
            L00A3: ShowMessage(party, String0BB0); // Lovely Autumn in its varicolored foliage urges you to gather in your harvest before harsh Winter comes.
            L00B0: ShowMessage(party, String0C18); // Autumn begins to fade, and so asks why you have come.
            L00BD: goto L00E8;
            L00BF: ShowMessage(party, String0C4E); // You may call me Karakiar, since that is my name. My liege is Winter.
            L00CC: ShowMessage(party, String0C93); // The bracing sting of Winter's winds refresh those who love its white wonderland.
            L00D9: ShowMessage(party, String0CE4); // Winter would know why you are here.
            L00E6: goto L00E8;
            L00E8: ax = UsedItem54(party, 0xE5, 0xE5);
            L00FB: if (CompareResultEqual) goto L0168;
            L00FD: Compare(si, 0x01);
            L0100: if (!CompareResultEqual) goto L0158;
            L0102: RemoveItem4C(party, 0xE5);
            L010E: GiveItem48(party, 0xE8);
            L011A: SetState00(party, 0x01, 0x01, 0x02);
            L012F: ShowMessage(party, String0D08); // Spring thanks you for the Winter Waters.
            L013C: ShowMessage(party, String0D31); // See how soft Spring transforms into vibrant Summer!
            L0149: ShowMessage(party, String0D65); // Take this Summer Radiance for your troubles.
            L0156: goto L0165;
            L0158: ShowMessage(party, String0D92); // You dishonor Spring with your false gift.
            L0165: goto L0301;
            L0168: ax = UsedItem54(party, 0xE6, 0xE6);
            L017B: if (CompareResultEqual) goto L01E8;
            L017D: Compare(si, 0x02);
            L0180: if (!CompareResultEqual) goto L01D8;
            L0182: RemoveItem4C(party, 0xE6);
            L018E: GiveItem48(party, 0xE4);
            L019A: SetState00(party, 0x01, 0x01, 0x03);
            L01AF: ShowMessage(party, String0DBC); // Summer rejoices in the wondrous Harvest Horn.
            L01BC: ShowMessage(party, String0DEA); // Behold!  Summer ripens into mature Autumn!
            L01C9: ShowMessage(party, String0E15); // The golden Autumn Seeds are ample reward for your generosity.
            L01D6: goto L01E5;
            L01D8: ShowMessage(party, String0E53); // Summer burns in anger at your false gift.  Begone!
            L01E5: goto L0301;
            L01E8: ax = UsedItem54(party, 0xE7, 0xE7);
            L01FB: if (CompareResultEqual) goto L0268;
            L01FD: Compare(si, 0x03);
            L0200: if (!CompareResultEqual) goto L0258;
            L0202: RemoveItem4C(party, 0xE7);
            L020E: GiveItem48(party, 0xE5);
            L021A: SetState00(party, 0x01, 0x01, 0x04);
            L022F: ShowMessage(party, String0E86); // Autumn gladly accepts the Spring Renewal.
            L023C: ShowMessage(party, String0EB0); // Lo!  Golden Autumn pales to white Winter and now sleeps under snowy blankets.
            L0249: ShowMessage(party, String0EFE); // These icy Winter Waters are a present to you.
            L0256: goto L0265;
            L0258: ShowMessage(party, String0F2C); // Autumn is angry that you mock it with a false gift.
            L0265: goto L0301;
            L0268: ax = UsedItem54(party, 0xE4, 0xE4);
            L027B: if (CompareResultEqual) goto L02F4;
            L027D: Compare(si, 0x04);
            L0280: if (!CompareResultEqual) goto L02D8;
            L0282: RemoveItem4C(party, 0xE4);
            L028E: GiveItem48(party, 0xE7);
            L029A: SetState00(party, 0x01, 0x01, 0x01);
            L02AF: ShowMessage(party, String0F60); // These Autumn Seeds are wonderful, indeed!
            L02BC: ShowMessage(party, String0F8A); // See sleeping Winter blossom with new life!
            L02C9: ShowMessage(party, String0FB5); // You now receive the glory of Spring Renewal.  It is a priceless gift!
            L02D6: goto L02F2;
            L02D8: ShowMessage(party, String0FFB); // Winter turns a cold back on your poor gift.
            L02E5: ShowMessage(party, String1027); // Leave before Winter blasts you!
            L02F2: goto L0301;
            L02F4: ShowMessage(party, String1047); // That item is of no interest to my master.
            L0301: return; // RETURN (restoring si);
        }

        protected override MapEventHandler MapEvent13 => FnOLACTOR_13;
        private void FnOLACTOR_13(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(party, String1071); // We are the Clerics of Oakleaf who comfort the Seasons.
            L0011: ShowPortrait(party, 0x0027);
            L001E: ax = CheckState04(party, 0x01, 0x02);
            L002F: si = ax;
            L0031: bx = si;
            L0033: bx = bx - 1;
            L0034: Compare(bx, 0x03);
            L0037: if (CompareResultEqual || CompareResultUnsignedLessThan) goto L003C;
            L0039: goto L00E8;
            L003C: switch (bx) {
                case 0:
                    goto L0043;
                case 1:
                    goto L006D;
                case 2:
                    goto L0096;
                case 3:
                    goto L00BF;
            }
            L0043: ShowMessage(party, String10A8); // Call me Donbard.  I ease the distress of gentle Spring.
            L0050: ShowMessage(party, String10E0); // Spring quakes in fear at your coming.
            L005D: ShowMessage(party, String1106); // Why have you come to Spring's home?
            L006A: goto L00E8;
            L006C: // NOP
            L006D: ShowMessage(party, String112A); // I am Shashamia, friend to the temperate Summer.
            L007A: ShowMessage(party, String115A); // Sullen summer is nervous around mortals.
            L0087: ShowMessage(party, String1183); // Do you have some business with Summer?
            L0094: goto L00E8;
            L0096: ShowMessage(party, String11AA); // Dindly Bindiak is my name.  Autumn is my friend.
            L00A3: ShowMessage(party, String11DB); // Russet-clad Autumn welcomes you if you are true friends of the Seasons.
            L00B0: ShowMessage(party, String1223); // Autumn will fade away unless you tell me why you have come.
            L00BD: goto L00E8;
            L00BF: ShowMessage(party, String125F); // I am called Kalakial, and I help poor Winter.
            L00CC: ShowMessage(party, String128D); // Wistful Winter is too shy to speak to you directly.
            L00D9: ShowMessage(party, String12C1); // Winter wishes you to leave, so do quickly what you came to do.
            L00E6: goto L00E8;
            L00E8: ax = UsedItem54(party, 0xE5, 0xE5);
            L00FB: if (CompareResultEqual) goto L0168;
            L00FD: Compare(si, 0x01);
            L0100: if (!CompareResultEqual) goto L0158;
            L0102: RemoveItem4C(party, 0xE5);
            L010E: GiveItem48(party, 0xE8);
            L011A: SetState00(party, 0x01, 0x02, 0x02);
            L012F: ShowMessage(party, String1300); // Spring accepts the Winter Waters.
            L013C: ShowMessage(party, String1322); // Spring sings sweetly of its transformation into Summer!
            L0149: ShowMessage(party, String135A); // Summer Radiance is yours as happy reward.
            L0156: goto L0165;
            L0158: ShowMessage(party, String1384); // Spring departs at the sight of your poor gift.
            L0165: goto L02F4;
            L0168: ax = UsedItem54(party, 0xE6, 0xE6);
            L017B: if (CompareResultEqual) goto L01E8;
            L017D: Compare(si, 0x02);
            L0180: if (!CompareResultEqual) goto L01D8;
            L0182: RemoveItem4C(party, 0xE6);
            L018E: GiveItem48(party, 0xE4);
            L019A: SetState00(party, 0x01, 0x02, 0x03);
            L01AF: ShowMessage(party, String13B3); // Summer accepts the Harvest Horn.
            L01BC: ShowMessage(party, String13D4); // Summer mellows by the sweet music and is now Autumn!
            L01C9: ShowMessage(party, String1409); // Autumn Seeds are now yours to enjoy.
            L01D6: goto L01E5;
            L01D8: ShowMessage(party, String142E); // Summer shies away from your pitiful gift.
            L01E5: goto L02F4;
            L01E8: ax = UsedItem54(party, 0xE7, 0xE7);
            L01FB: if (CompareResultEqual) goto L0268;
            L01FD: Compare(si, 0x03);
            L0200: if (!CompareResultEqual) goto L0258;
            L0202: RemoveItem4C(party, 0xE7);
            L020E: GiveItem48(party, 0xE5);
            L021A: SetState00(party, 0x01, 0x02, 0x04);
            L022F: ShowMessage(party, String1458); // Autumn shyly receives the Spring Renewal.
            L023C: ShowMessage(party, String1482); // Now Autumn turns to Winter, still clutching the hope of vernal renewal.
            L0249: ShowMessage(party, String14CA); // Winter Waters are yours, my friends.
            L0256: goto L0265;
            L0258: ShowMessage(party, String14EF); // Autumn rejects your horrid gift.
            L0265: goto L02F4;
            L0268: ax = UsedItem54(party, 0xE4, 0xE4);
            L027B: if (CompareResultEqual) goto L02E7;
            L027D: Compare(si, 0x04);
            L0280: if (!CompareResultEqual) goto L02D8;
            L0282: RemoveItem4C(party, 0xE4);
            L028E: GiveItem48(party, 0xE7);
            L029A: SetState00(party, 0x01, 0x02, 0x01);
            L02AF: ShowMessage(party, String1510); // Autumn Seeds hold the germ of life!
            L02BC: ShowMessage(party, String1534); // Cold Winter is become warm Spring.  Rejoice!
            L02C9: ShowMessage(party, String1561); // The magnificent Spring Renewal is your just reward.
            L02D6: goto L02E5;
            L02D8: ShowMessage(party, String1595); // Winter weeps at your cruelty.
            L02E5: goto L02F4;
            L02E7: ShowMessage(party, String15B3); // No season is interested in the item you offer.
            L02F4: return; // RETURN (restoring si);
        }

        protected override MapEventHandler MapEvent14 => FnMBACTOR_14;
        private void FnMBACTOR_14(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(party, String15E2); // We are the Wardens of Maplebrush and hold the Seasons.
            L0011: ShowPortrait(party, 0x0027);
            L001E: ax = CheckState04(party, 0x01, 0x03);
            L002F: si = ax;
            L0031: bx = si;
            L0033: bx = bx - 1;
            L0034: Compare(bx, 0x03);
            L0037: if (CompareResultEqual || CompareResultUnsignedLessThan) goto L003C;
            L0039: goto L00B3;
            L003B: // NOP
            L003C: switch (bx) {
                case 0:
                    goto L0043;
                case 1:
                    goto L005F;
                case 2:
                    goto L007B;
                case 3:
                    goto L0097;
            }
            L0043: ShowMessage(party, String1619); // You may not know my name.
            L0050: ShowMessage(party, String1633); // It is Spring.  That is all you need know.
            L005D: goto L00B3;
            L005F: ShowMessage(party, String165D); // My name is my secret.
            L006C: ShowMessage(party, String1673); // It is Summer. That is all I'll say.
            L0079: goto L00B3;
            L007B: ShowMessage(party, String1697); // Never mind what my name is.
            L0088: ShowMessage(party, String16B3); // It is Autumn.  That is enough for now.
            L0095: goto L00B3;
            L0097: ShowMessage(party, String16DA); // Not even I know my true name.
            L00A4: ShowMessage(party, String16F8); // It is Winter.  I may say no more.
            L00B1: goto L00B3;
            L00B3: ax = UsedItem54(party, 0xE5, 0xE5);
            L00C6: if (CompareResultEqual) goto L0126;
            L00C8: Compare(si, 0x01);
            L00CB: if (!CompareResultEqual) goto L0116;
            L00CD: RemoveItem4C(party, 0xE5);
            L00D9: GiveItem48(party, 0xE8);
            L00E5: SetState00(party, 0x01, 0x03, 0x02);
            L00FA: ShowMessage(party, String171A); // From Winter Waters comes the change of Spring to Summer.
            L0107: ShowMessage(party, String1753); // You are rewarded.
            L0114: goto L0123;
            L0116: ShowMessage(party, String1765); // Wrong gift, mortal!
            L0123: goto L028B;
            L0126: ax = UsedItem54(party, 0xE6, 0xE6);
            L0139: if (CompareResultEqual) goto L0199;
            L013B: Compare(si, 0x02);
            L013E: if (!CompareResultEqual) goto L0189;
            L0140: RemoveItem4C(party, 0xE6);
            L014C: GiveItem48(party, 0xE4);
            L0158: SetState00(party, 0x01, 0x03, 0x03);
            L016D: ShowMessage(party, String1779); // The Harvest Horn blows Summer into Autumn.
            L017A: ShowMessage(party, String17A4); // A reward is yours.
            L0187: goto L0196;
            L0189: ShowMessage(party, String17B7); // Wrong present, mortal!
            L0196: goto L028B;
            L0199: ax = UsedItem54(party, 0xE7, 0xE7);
            L01AC: if (CompareResultEqual) goto L020C;
            L01AE: Compare(si, 0x03);
            L01B1: if (!CompareResultEqual) goto L01FC;
            L01B3: RemoveItem4C(party, 0xE7);
            L01BF: GiveItem48(party, 0xE5);
            L01CB: SetState00(party, 0x01, 0x03, 0x04);
            L01E0: ShowMessage(party, String17CE); // The Spring Renewal eases Autumn's slide into Winter.
            L01ED: ShowMessage(party, String1803); // Enjoy your reward.
            L01FA: goto L0209;
            L01FC: ShowMessage(party, String1816); // Not even close, mortal!
            L0209: goto L028B;
            L020C: ax = UsedItem54(party, 0xE4, 0xE4);
            L021F: if (CompareResultEqual) goto L027E;
            L0221: Compare(si, 0x04);
            L0224: if (!CompareResultEqual) goto L026F;
            L0226: RemoveItem4C(party, 0xE4);
            L0232: GiveItem48(party, 0xE7);
            L023E: SetState00(party, 0x01, 0x03, 0x01);
            L0253: ShowMessage(party, String182E); // Winter devours the Autumn Seeds and becomes Spring.
            L0260: ShowMessage(party, String1862); // You are well rewarded.
            L026D: goto L027C;
            L026F: ShowMessage(party, String1879); // Wrong, wrong, wrong, mortal!
            L027C: goto L028B;
            L027E: ShowMessage(party, String1896); // Why do you offer the seasons such a thing?
            L028B: return; // RETURN (restoring si);
        }

        protected override MapEventHandler MapEvent15 => FnPCACTOR_15;
        private void FnPCACTOR_15(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(party, String18C1); // We are the Seasons incarnate in mortal form.
            L0011: ShowPortrait(party, 0x0027);
            L001E: ax = CheckState04(party, 0x01, 0x04);
            L002F: si = ax;
            L0031: bx = si;
            L0033: bx = bx - 1;
            L0034: Compare(bx, 0x03);
            L0037: if (CompareResultUnsignedGreaterThan) goto L007C;
            L0039: switch (bx) {
                case 0:
                    goto L0040;
                case 1:
                    goto L004F;
                case 2:
                    goto L005E;
                case 3:
                    goto L006D;
            }
            L0040: ShowMessage(party, String18EE); // I am Spring
            L004D: goto L007C;
            L004F: ShowMessage(party, String18FA); // I am Summer
            L005C: goto L007C;
            L005E: ShowMessage(party, String1906); // I am Autumn
            L006B: goto L007C;
            L006D: ShowMessage(party, String1912); // I am Winter
            L007A: goto L007C;
            L007C: ax = UsedItem54(party, 0xE5, 0xE5);
            L008F: if (CompareResultEqual) goto L00FC;
            L0091: Compare(si, 0x01);
            L0094: if (!CompareResultEqual) goto L00EC;
            L0096: RemoveItem4C(party, 0xE5);
            L00A2: GiveItem48(party, 0xE8);
            L00AE: SetState00(party, 0x01, 0x04, 0x02);
            L00C3: ShowMessage(party, String191E); // The Winter Waters you offer quench my thirst.
            L00D0: ShowMessage(party, String194C); // Look how I have become Summer!
            L00DD: ShowMessage(party, String196B); // Take my new Summer Radiance.
            L00EA: goto L00F9;
            L00EC: ShowMessage(party, String1988); // I have no need for that item.
            L00F9: goto L0288;
            L00FC: ax = UsedItem54(party, 0xE6, 0xE6);
            L010F: if (CompareResultEqual) goto L017C;
            L0111: Compare(si, 0x02);
            L0114: if (!CompareResultEqual) goto L016C;
            L0116: RemoveItem4C(party, 0xE6);
            L0122: GiveItem48(party, 0xE4);
            L012E: SetState00(party, 0x01, 0x04, 0x03);
            L0143: ShowMessage(party, String19A6); // I blow the Harvest Horn you give me...
            L0150: ShowMessage(party, String19CD); // ...and I change to Autumn!
            L015D: ShowMessage(party, String19E8); // Have some of my Autumn Seeds as thanks.
            L016A: goto L0179;
            L016C: ShowMessage(party, String1A10); // The present you offer I must reject.
            L0179: goto L0288;
            L017C: ax = UsedItem54(party, 0xE7, 0xE7);
            L018F: if (CompareResultEqual) goto L01FC;
            L0191: Compare(si, 0x03);
            L0194: if (!CompareResultEqual) goto L01EC;
            L0196: RemoveItem4C(party, 0xE7);
            L01A2: GiveItem48(party, 0xE5);
            L01AE: SetState00(party, 0x01, 0x04, 0x04);
            L01C3: ShowMessage(party, String1A35); // Because you give me Spring Renewal...
            L01D0: ShowMessage(party, String1A5B); // ...I can safely transform into Winter and still survive.
            L01DD: ShowMessage(party, String1A94); // May my Winter Waters refresh you.
            L01EA: goto L01F9;
            L01EC: ShowMessage(party, String1AB6); // I cannot accept your present.
            L01F9: goto L0288;
            L01FC: ax = UsedItem54(party, 0xE4, 0xE4);
            L020F: if (CompareResultEqual) goto L027B;
            L0211: Compare(si, 0x04);
            L0214: if (!CompareResultEqual) goto L026C;
            L0216: RemoveItem4C(party, 0xE4);
            L0222: GiveItem48(party, 0xE7);
            L022E: SetState00(party, 0x01, 0x04, 0x01);
            L0243: ShowMessage(party, String1AD4); // The Autumn Seeds awaken me from my long hibernation.
            L0250: ShowMessage(party, String1B09); // I am Spring again!
            L025D: ShowMessage(party, String1B1C); // Take the Renewal of Spring and rejoice with me!
            L026A: goto L0279;
            L026C: ShowMessage(party, String1B4C); // I have no use for what you offer.
            L0279: goto L0288;
            L027B: ShowMessage(party, String1B6E); // We Seasons cannot use the item you offer.
            L0288: return; // RETURN (restoring si);
        }

        protected override MapEventHandler MapEvent16 => FnINFO_16;
        private void FnINFO_16(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x001F);
            L0010: ShowMessage(party, String1B98); // 'Welcome, Adventurer.  I am Varstad, counselor to the Elf King.
            L001D: ShowMessage(party, String1BD8); // The magic Aldbora requires Summer Radiance to shed its knowledge fruit.'
            L002A: return; // RETURN;
        }

        protected override MapEventHandler MapEvent17 => FnINFO_17;
        private void FnINFO_17(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0027);
            L0010: ShowMessage(party, String1C21); // The storyteller Sorshian honors your arrival.
            L001D: ShowMessage(party, String1C4F); // 'Only when the season is winter will the Aldbora shed its fruit.'
            L002A: return; // RETURN;
        }

        protected override MapEventHandler MapEvent18 => FnCAVEDOOR_18;
        private void FnCAVEDOOR_18(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1C91); // A wooden sign says, 'To the cave of NeedleWood.'
            L0010: ax = UsedItem54(party, 0xD8, 0xD8);
            L0023: if (CompareResultEqual) goto L0066;
            L0025: ShowMessage(party, String1CC2); // The door unlocks.
            L0032: PushStack(0x01);
            L0036: PushStack(0x03);
            L003A: ax = GetNextTile20(party);
            L0041: PushStack(ax);
            L0042: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L004C: PushStack(0x03);
            L0050: ax = GetNextTile20(party);
            L0057: PushStack(ax);
            L0058: PushStack(0x01);
            L005C: SetUnblocked30(party);
            L0066: return; // RETURN;
        }

        protected override MapEventHandler MapEvent19 => FnELFHOME_19;
        private void FnELFHOME_19(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1CD4); // Young elves scurry and hide when you enter this elf home.
            L0010: return; // RETURN;
        }

        protected override MapEventHandler MapEvent1A => FnELFHOME_1A;
        private void FnELFHOME_1A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1D0E); // Carvings of elfin rangers crossing glacial landscapes proudly mount the walls of a typical elfin dwelling.
            L0010: return; // RETURN;
        }

        protected override MapEventHandler MapEvent1B => FnINFO_1B;
        private void FnINFO_1B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x001F);
            L0010: ShowMessage(party, String1D79); // 'I am Fernank, Hunter to the Elf King.
            L001D: ShowMessage(party, String1DA0); // It is known in the trees that Nature's Robe must be used for the harvest.'
            L002A: return; // RETURN;
        }

    }
}
