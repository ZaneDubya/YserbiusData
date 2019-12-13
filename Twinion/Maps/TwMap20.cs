#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Twinion.Maps {
    class TwMap20 : AMapScripted {
        protected override int MapIndex => 20;
        protected override int RandomEncounterChance => 12;
        protected override int RandomEncounterExtraCount => 2;

        public TwMap20() {
            MapEvent01 = FnTELEA_01;
            MapEvent02 = FnTELEB_02;
            MapEvent03 = FnTELEC_03;
            MapEvent04 = FnTELED_04;
            MapEvent05 = FnTELEE_05;
            MapEvent06 = FnTELEF_06;
            MapEvent07 = FnTELEG_07;
            MapEvent08 = FnTELEH_08;
            MapEvent09 = FnTELEI_09;
            MapEvent0A = FnTELEJ_0A;
            MapEvent0B = FnTELEK_0B;
            MapEvent0C = FnWIZA_0C;
            MapEvent0D = FnTEXTA_0D;
            MapEvent0E = FnWIZB_0E;
            MapEvent0F = FnCLUEA_0F;
            MapEvent10 = FnCLUEB_10;
            MapEvent11 = FnCLUEC_11;
            MapEvent12 = FnWIZD_12;
            MapEvent13 = FnNASTYB_13;
            MapEvent14 = FnWIZC_14;
            MapEvent15 = FnPIT_15;
            MapEvent16 = FnLAVA_16;
            MapEvent17 = FnSECA_17;
            MapEvent18 = FnSECB_18;
            MapEvent19 = FnSECC_19;
            MapEvent1A = FnILL_1A;
            MapEvent1B = FnTELONE_1B;
            MapEvent1C = FnTLTWO_1C;
            MapEvent1D = FnTLTHREE_1D;
            MapEvent1E = FnTLFOUR_1E;
            MapEvent1F = FnDRAGBDR_1F;
            MapEvent20 = FnDRAGBBDR_20;
            MapEvent21 = FnDRAGADR_21;
            MapEvent22 = FnDRAGAADR_22;
            MapEvent23 = FnTWONORTH_23;
            MapEvent25 = FnTWOCTR_25;
            MapEvent26 = FnBAWCRS_26;
            MapEvent28 = FnTWOSTH_28;
            MapEvent29 = FnDRAGB_29;
            MapEvent2A = FnDRAGBB_2A;
            MapEvent2B = FnDRAGA_2B;
            MapEvent2C = FnDRAGAA_2C;
            MapEvent2D = FnSETBA_2D;
            MapEvent2E = FnSETBB_2E;
            MapEvent2F = FnSETBC_2F;
            MapEvent30 = FnSTRENGTH_30;
            MapEvent31 = FnDEFENSE_31;
            MapEvent32 = FnINIT_32;
            MapEvent33 = FnAGILITY_33;
            MapEvent34 = FnCLUESPEL_34;
            MapEvent35 = FnTPORTB_35;
            MapEvent36 = FnTPORTA_36;
            MapEvent37 = FnCLEAR_37;
        }
        
        // === Strings ================================================
        private const string String03FC = "Beyond this portal lies the wizard village Hocus Pocus.";
        private const string String0434 = "'I am the wizard Majikyl. For a mere pittance I shall envelop you in a Vapor Cloud. This cloud will allow you to approach the dragon unseen.";
        private const string String04C1 = "If you wish to continue, step through the door to the east.'";
        private const string String04FE = "You find a page from MyMy's and Sinestra's journal with a faded map of many doors.";
        private const string String0551 = "Across the top you can barely make out the words 'Hocus Pocus' and across the bottom you see four words but can only decipher S   h W   S    We  .";
        private const string String05E4 = "'I am the wizard Artsenis. For this fee I will aid your quest. I shall place upon you a Chameleon Shroud spell. So disguised, you should be successful in approaching the dragon.";
        private const string String0696 = "If you choose to continue, step through the door to the south.'";
        private const string String06D6 = "'I was told that you have to search every nook and cranny in the tunnels to find access to the dragons.'";
        private const string String073F = "A bloody hand print marks the wall.";
        private const string String0763 = "You cross paths with a Troll Cleric, who whispers to you,";
        private const string String079D = "'After searching all over, I retraced my steps and found an opening where none appeared before. This dungeon is a strange place.'";
        private const string String081F = "'I am the wizard Aillacsar. I shall take my fee for the Invisibility I cast upon you. It will get you close to your prey.";
        private const string String0899 = "If you choose to continue, walk east through the teleport.'";
        private const string String08D5 = "'I am the wizard Mirloch. Accept my magic for a small fee. I have cast upon you a Charismatic Aura. The enemy will look upon you as a friend.";
        private const string String0963 = "If you wish to continue, walk to the west through the teleport.";
        private const string String09A3 = "You step into a deep crevice and fall to your death.";
        private const string String09D8 = "The searing heat of the lava engulfs you in flames.";
        private const string String0A0C = "You discover an opening.";
        private const string String0A25 = "You push aside a pile of rubble and find a clear path ahead.";
        private const string String0A62 = "Your keen senses detect a hidden door.";
        private const string String0A89 = "You are teleported to a series of long, dark tunnels. Here is where the dragons continue their feud.";
        private const string String0AEE = "'Greetings! Have you seen my two companions? We were separated when we walked alone through a teleport.'";
        private const string String0B57 = "'You say you have visited a wizard for magic? Hmmm, I see no signs of that.  Well, good journeys!'";
        private const string String0BBA = "'If you see them, please tell them I'm still searching. Good journeys to you!'";
        private const string String0C09 = "You encounter a tired elf leaning on a wall.";
        private const string String0C36 = "'Have you had the same problem as us? Either the magic was weak or something stripped it from us in our wanderings.'";
        private const string String0CAB = "'Well met! I am searching for my lost companions. I must hurry on, safe paths!'";
        private const string String0CFB = "You notice a sign in pieces on the ground and barely make out the wording 'WARNING!!! These teleports are condemned by order of Queen Aeowyn!!!'";
        private const string String0D8C = "Attached to the sign is a hand written note, 'Olyces, some thief told me my magic protection was gone! Something odd about these teleports or where they take me.";
        private const string String0E2E = "I'm off to the wizards again and will meet you inside. I hope to use the correct teleport this time.' The note is signed, Bawcrs.";
        private const string String0EB0 = "You stumble upon an injured troll and administer aid.";
        private const string String0EE6 = "'A dangerous place indeed. I see no signs of magic about you. If you have visited the wizards, I suggest you try again. Sometimes shifting clouds of old magic strip the defenses. My thanks to you.'";
        private const string String0FAC = "'My thanks to you for much needed aid. You appear to be well protected. I shall remember your kindness; fare well my friends.'";
        private const string String102B = "Gambril lumbers away.";
        private const string String1041 = "Gambril is obviously relieved that his nemesis is finally dead.";
        private const string String1081 = "He gives you a reward and says, 'It would be wise to take your trophy to Hocus Pocus. The wizards there oftentimes need unique items.'";
        private const string String1108 = "You meet Gambril, the Frost Dragon.";
        private const string String112C = "'For longer than I care to remember, I have feuded with my nemesis Osterog, the Ice Dragon.";
        private const string String1188 = "Our continued battles have formed tunnels within the land, and we can no longer maneuver ourselves through them.";
        private const string String11F9 = "I beseech you to help me. I will reward you generously if you bring me proof of your kill.";
        private const string String1254 = "To be successful, you may need greater magic than you now possess.'";
        private const string String1298 = "With the help of the proper magic, you find the dragon Gambril.";
        private const string String12D8 = "The magic protection you try to weave around yourself is not enough to protect you from Gambril's keen vision.";
        private const string String1347 = "Scoffing that Osterog has selected a particularly pitiful party to kill him, the dragon toasts you with his flame-breath.";
        private const string String13C1 = "Osterog lumbers away.";
        private const string String13D7 = "Osterog smiles broadly, gloating that his nemesis is finally dead.";
        private const string String141A = "As he doles out his reward, he says, 'I understand that the wizards of Hocus Pocus are much interested in unusual items. You may wish to show them your trophies.'";
        private const string String14BD = "You encounter Osterog, the Ice Dragon.";
        private const string String14E4 = "'Long have I feuded with Gambril, the Frost Dragon.";
        private const string String1518 = "Our endless battles have weakened the tunnels hereabout, and we no longer dare tread them.";
        private const string String1573 = "If you can help me destroy my sworn enemy, I will reward you most generously. Bring me proof of your kill.";
        private const string String15DE = "Your success may depend on greater magic than you now know.'";
        private const string String161B = "The proper magic has led you to the dragon Osterog.";
        private const string String164F = "As you tiptoe towards the great beast, Osterog sniffs once and smiles a saurian smile.";
        private const string String16A6 = "'Gambril has sent fools to kill me.'";
        private const string String16CB = "He turns toward you and roasts you with his flame-breath.";
        private const string String1705 = "You encounter other adventurers who seek the dragon's reward.";
        private const string String1743 = "You push open the broken door with ease.";
        private const string String176C = "As you push against the stubborn door, debris falls and injures you.";
        private const string String17B1 = "The walls around you have been fortified.";
        private const string String17DB = "The walls collapse upon you! Amnesia causes you to forget your more recent experiences.";
        private const string String1833 = "You elude a thief hiding in the shadows.";
        private const string String185C = "A thief runs by you and picks your pocket.";
        private const string String1887 = "You resist the magical forces emanating from the chamber.";
        private const string String18C1 = "You feel magical forces drain your mana.";
        private const string String18EA = "The ghost of an adventurer appears before you.";
        private const string String1919 = "'Seek out the wizards in Dragon's Flame for help. Each, for a fee, will aid you with his or her unusual magic.";
        private const string String1988 = "BUT, all spells are not successful for all.";
        private const string String19B4 = "I wish you better luck than I had. And remember, it is imperative that you stay in the area until you successfully complete your quest.'";
        
        // === Functions ================================================
        private void FnTELEA_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
            L0007: PushStack(player, ax);
            L0008: PushStack(player, 0x03);
0019  000C C4 5E 06  les bx, [bp+0x6]
001C  000F 26 FF 1F  call far word [es:bx]
001F  0012 83 C4 06  add sp, 0x6
            L0015: TeleportParty(player, 0x08, 0x02, 0x7C, 0x01, isForwardMove);
            L0030: return; // RETURN;
        }

        private void FnTELEB_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0005);
            L000D: if (JumpEqual) goto L001B;
            L000F: Compare(GetRace(player), 0x0003);
            L0019: if (JumpNotEqual) goto L0024;
            L001B: PushStack(player, 0x03);
005E  001F B8 FB 00  mov ax, 0xfb
            L0022: goto L006C;
            L0024: Compare(GetRace(player), 0x0002);
            L002E: if (JumpEqual) goto L003C;
            L0030: Compare(GetRace(player), 0x0007);
            L003A: if (JumpNotEqual) goto L0045;
            L003C: PushStack(player, 0x02);
007F  0040 B8 60 00  mov ax, 0x60
            L0043: goto L006C;
            L0045: Compare(GetRace(player), 0x0004);
            L004F: if (JumpEqual) goto L005D;
            L0051: Compare(GetRace(player), 0x0001);
            L005B: if (JumpNotEqual) goto L0066;
            L005D: PushStack(player, 0x02);
00A0  0061 B8 4D 00  mov ax, 0x4d
            L0064: goto L006C;
            L0066: TeleportParty(player, 0x08, 0x02, 0x91, 0x00, isForwardMove);
            L0080: return; // RETURN;
        }

        private void FnTELEC_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x03, 0x01, 0x02);
            L0018: TeleportParty(player, 0x08, 0x02, 0x7C, 0x02, isForwardMove);
            L0033: return; // RETURN;
        }

        private void FnTELED_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0005);
            L000D: if (JumpEqual) goto L001B;
            L000F: Compare(GetRace(player), 0x0002);
            L0019: if (JumpNotEqual) goto L0024;
            L001B: PushStack(player, 0x02);
0115  001F B8 51 00  mov ax, 0x51
            L0022: goto L006B;
            L0024: Compare(GetRace(player), 0x0003);
            L002E: if (JumpEqual) goto L003C;
            L0030: Compare(GetRace(player), 0x0007);
            L003A: if (JumpNotEqual) goto L0045;
            L003C: PushStack(player, 0x03);
0136  0040 B8 A3 00  mov ax, 0xa3
            L0043: goto L006B;
            L0045: Compare(GetRace(player), 0x0004);
            L004F: if (JumpEqual) goto L005D;
            L0051: Compare(GetRace(player), 0x0006);
            L005B: if (JumpNotEqual) goto L0065;
            L005D: PushStack(player, 0x00);
0156  0060 B8 CC 00  mov ax, 0xcc
            L0063: goto L006B;
            L0065: TeleportParty(player, 0x08, 0x02, 0x2C, 0x00, isForwardMove);
            L007F: return; // RETURN;
        }

        private void FnTELEE_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0005);
            L000D: if (JumpEqual) goto L001B;
            L000F: Compare(GetRace(player), 0x0002);
            L0019: if (JumpNotEqual) goto L0023;
            L001B: PushStack(player, 0x00);
0195  001E B8 CC 00  mov ax, 0xcc
            L0021: goto L006B;
            L0023: Compare(GetRace(player), 0x0003);
            L002D: if (JumpEqual) goto L003B;
            L002F: Compare(GetRace(player), 0x0007);
            L0039: if (JumpNotEqual) goto L0043;
            L003B: PushStack(player, 0x00);
01B5  003E B8 2C 00  mov ax, 0x2c
            L0041: goto L006B;
            L0043: Compare(GetRace(player), 0x0004);
            L004D: if (JumpEqual) goto L005B;
            L004F: Compare(GetRace(player), 0x0006);
            L0059: if (JumpNotEqual) goto L0064;
            L005B: PushStack(player, 0x02);
01D6  005F B8 51 00  mov ax, 0x51
            L0062: goto L006B;
            L0064: TeleportParty(player, 0x08, 0x02, 0xA3, 0x03, isForwardMove);
            L007F: return; // RETURN;
        }

        private void FnTELEF_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0005);
            L000D: if (JumpEqual) goto L001B;
            L000F: Compare(GetRace(player), 0x0002);
            L0019: if (JumpNotEqual) goto L0023;
            L001B: PushStack(player, 0x00);
0216  001E B8 2C 00  mov ax, 0x2c
            L0021: goto L006B;
            L0023: Compare(GetRace(player), 0x0003);
            L002D: if (JumpEqual) goto L003B;
            L002F: Compare(GetRace(player), 0x0007);
            L0039: if (JumpNotEqual) goto L0043;
            L003B: PushStack(player, 0x00);
0236  003E B8 CC 00  mov ax, 0xcc
            L0041: goto L006B;
            L0043: Compare(GetRace(player), 0x0004);
            L004D: if (JumpEqual) goto L005B;
            L004F: Compare(GetRace(player), 0x0006);
            L0059: if (JumpNotEqual) goto L0064;
            L005B: PushStack(player, 0x03);
0257  005F B8 A3 00  mov ax, 0xa3
            L0062: goto L006B;
            L0064: TeleportParty(player, 0x08, 0x02, 0x51, 0x02, isForwardMove);
            L007F: return; // RETURN;
        }

        private void FnTELEG_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0005);
            L000D: if (JumpEqual) goto L001B;
            L000F: Compare(GetRace(player), 0x0002);
            L0019: if (JumpNotEqual) goto L0024;
            L001B: PushStack(player, 0x03);
0298  001F B8 A3 00  mov ax, 0xa3
            L0022: goto L006B;
            L0024: Compare(GetRace(player), 0x0003);
            L002E: if (JumpEqual) goto L003C;
            L0030: Compare(GetRace(player), 0x0007);
            L003A: if (JumpNotEqual) goto L0045;
            L003C: PushStack(player, 0x02);
02B9  0040 B8 51 00  mov ax, 0x51
            L0043: goto L006B;
            L0045: Compare(GetRace(player), 0x0004);
            L004F: if (JumpEqual) goto L005D;
            L0051: Compare(GetRace(player), 0x0006);
            L005B: if (JumpNotEqual) goto L0065;
            L005D: PushStack(player, 0x00);
02D9  0060 B8 2C 00  mov ax, 0x2c
            L0063: goto L006B;
            L0065: TeleportParty(player, 0x08, 0x02, 0xCC, 0x00, isForwardMove);
            L007F: return; // RETURN;
        }

        private void FnTELEH_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0005);
            L000D: if (JumpEqual) goto L001B;
            L000F: Compare(GetRace(player), 0x0003);
            L0019: if (JumpNotEqual) goto L0023;
            L001B: PushStack(player, 0x00);
0318  001E B8 FF 00  mov ax, 0xff
            L0021: goto L006C;
            L0023: Compare(GetRace(player), 0x0002);
            L002D: if (JumpEqual) goto L003B;
            L002F: Compare(GetRace(player), 0x0007);
            L0039: if (JumpNotEqual) goto L0044;
            L003B: PushStack(player, 0x02);
0339  003F B8 F0 00  mov ax, 0xf0
            L0042: goto L006C;
            L0044: Compare(GetRace(player), 0x0004);
            L004E: if (JumpEqual) goto L005C;
            L0050: Compare(GetRace(player), 0x0001);
            L005A: if (JumpNotEqual) goto L0065;
            L005C: PushStack(player, 0x01);
035A  0060 B8 0A 00  mov ax, 0xa
            L0063: goto L006C;
            L0065: TeleportParty(player, 0x08, 0x02, 0x04, 0x01, isForwardMove);
            L0080: return; // RETURN;
        }

        private void FnTELEI_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x03, 0x01, 0x04);
            L0018: TeleportParty(player, 0x08, 0x02, 0x7C, 0x00, isForwardMove);
            L0032: return; // RETURN;
        }

        private void FnTELEJ_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x03, 0x01, 0x03);
            L0018: TeleportParty(player, 0x08, 0x02, 0x7C, 0x03, isForwardMove);
            L0033: return; // RETURN;
        }

        private void FnTELEK_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String03FC); // Beyond this portal lies the wizard village Hocus Pocus.
            L0010: TeleportParty(player, 0x09, 0x01, 0xF7, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnWIZA_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002E);
            L0010: ModifyGold(player, 0xFFFF18BA);
            L0022: ShowMessage(player, String0434); // 'I am the wizard Majikyl. For a mere pittance I shall envelop you in a Vapor Cloud. This cloud will allow you to approach the dragon unseen.
            L002F: ShowMessage(player, String04C1); // If you wish to continue, step through the door to the east.'
            L003C: return; // RETURN;
        }

        private void FnTEXTA_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String04FE); // You find a page from MyMy's and Sinestra's journal with a faded map of many doors.
            L0010: ShowMessage(player, String0551); // Across the top you can barely make out the words 'Hocus Pocus' and across the bottom you see four words but can only decipher S   h W   S    We  .
            L001D: return; // RETURN;
        }

        private void FnWIZB_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002B);
            L0010: ModifyGold(player, 0xFFFF18BA);
            L0022: ShowMessage(player, String05E4); // 'I am the wizard Artsenis. For this fee I will aid your quest. I shall place upon you a Chameleon Shroud spell. So disguised, you should be successful in approaching the dragon.
            L002F: ShowMessage(player, String0696); // If you choose to continue, step through the door to the south.'
            L003C: return; // RETURN;
        }

        private void FnCLUEA_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0018);
            L0010: ShowMessage(player, String06D6); // 'I was told that you have to search every nook and cranny in the tunnels to find access to the dragons.'
            L001D: return; // RETURN;
        }

        private void FnCLUEB_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String073F); // A bloody hand print marks the wall.
            L0010: return; // RETURN;
        }

        private void FnCLUEC_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0028);
            L0010: ShowMessage(player, String0763); // You cross paths with a Troll Cleric, who whispers to you,
            L001D: ShowMessage(player, String079D); // 'After searching all over, I retraced my steps and found an opening where none appeared before. This dungeon is a strange place.'
            L002A: return; // RETURN;
        }

        private void FnWIZD_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002C);
            L0010: ModifyGold(player, 0xFFFF18BA);
            L0022: ShowMessage(player, String081F); // 'I am the wizard Aillacsar. I shall take my fee for the Invisibility I cast upon you. It will get you close to your prey.
            L002F: ShowMessage(player, String0899); // If you choose to continue, walk east through the teleport.'
            L003C: return; // RETURN;
        }

        private void FnNASTYB_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x10);
            L0015: AddEncounter(player, 0x02, 0x1C);
            L0027: AddEncounter(player, 0x03, 0x25);
            L0039: AddEncounter(player, 0x04, 0x24);
            L004B: AddEncounter(player, 0x05, 0x26);
            L005D: AddEncounter(player, 0x06, 0x1D);
            L006F: return; // RETURN;
        }

        private void FnWIZC_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002D);
            L0010: ModifyGold(player, 0xFFFF18BA);
            L0022: ShowMessage(player, String08D5); // 'I am the wizard Mirloch. Accept my magic for a small fee. I have cast upon you a Charismatic Aura. The enemy will look upon you as a friend.
            L002F: ShowMessage(player, String0963); // If you wish to continue, walk to the west through the teleport.
            L003C: return; // RETURN;
        }

        private void FnPIT_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String09A3); // You step into a deep crevice and fall to your death.
            L0010: DamagePlayer(player, GetMaxHits(player));
            L0021: return; // RETURN;
        }

        private void FnLAVA_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String09D8); // The searing heat of the lava engulfs you in flames.
            L0010: DamagePlayer(player, GetMaxHits(player));
            L0021: return; // RETURN;
        }

        private void FnSECA_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L006C;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L006C;
            L0024: PushStack(player, 0x68);
            L0028: PushStack(player, ax);
0666  0029 C4 5E 06  les bx, [bp+0x6]
0669  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L006C;
            L0036: PushStack(player, 0x6E);
            L003A: PushStack(player, ax);
0678  003B C4 5E 06  les bx, [bp+0x6]
067B  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L006C;
            L0048: PushStack(player, 0x90);
            L004C: PushStack(player, ax);
068A  004D C4 5E 06  les bx, [bp+0x6]
068D  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L006C;
            L005A: PushStack(player, 0xA4);
            L005E: PushStack(player, ax);
069C  005F C4 5E 06  les bx, [bp+0x6]
069F  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpEqual) goto L009C;
            L006C: ShowMessage(player, String0A0C); // You discover an opening.
            L0079: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
06D4  0097 B8 01 00  mov ax, 0x1
            L009A: goto L009E;
            L009C: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00B9: return; // RETURN;
        }

        private void FnSECB_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L006C;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L006C;
            L0024: PushStack(player, 0x68);
            L0028: PushStack(player, ax);
0721  0029 C4 5E 06  les bx, [bp+0x6]
0724  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L006C;
            L0036: PushStack(player, 0x6E);
            L003A: PushStack(player, ax);
0733  003B C4 5E 06  les bx, [bp+0x6]
0736  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L006C;
            L0048: PushStack(player, 0x90);
            L004C: PushStack(player, ax);
0745  004D C4 5E 06  les bx, [bp+0x6]
0748  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L006C;
            L005A: PushStack(player, 0xA4);
            L005E: PushStack(player, ax);
0757  005F C4 5E 06  les bx, [bp+0x6]
075A  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpEqual) goto L009C;
            L006C: ShowMessage(player, String0A25); // You push aside a pile of rubble and find a clear path ahead.
            L0079: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
078F  0097 B8 01 00  mov ax, 0x1
            L009A: goto L009E;
            L009C: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00B9: return; // RETURN;
        }

        private void FnSECC_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x000A);
            L0012: if (JumpNotBelow) goto L006C;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L006C;
            L0024: PushStack(player, 0x68);
            L0028: PushStack(player, ax);
07DC  0029 C4 5E 06  les bx, [bp+0x6]
07DF  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L006C;
            L0036: PushStack(player, 0x6E);
            L003A: PushStack(player, ax);
07EE  003B C4 5E 06  les bx, [bp+0x6]
07F1  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L006C;
            L0048: PushStack(player, 0x90);
            L004C: PushStack(player, ax);
0800  004D C4 5E 06  les bx, [bp+0x6]
0803  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L006C;
            L005A: PushStack(player, 0xA4);
            L005E: PushStack(player, ax);
0812  005F C4 5E 06  les bx, [bp+0x6]
0815  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpEqual) goto L009C;
            L006C: ShowMessage(player, String0A62); // Your keen senses detect a hidden door.
            L0079: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
084A  0097 B8 01 00  mov ax, 0x1
            L009A: goto L009E;
            L009C: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00B9: return; // RETURN;
        }

        private void FnILL_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0021: return; // RETURN;
        }

        private void FnTELONE_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0A89); // You are teleported to a series of long, dark tunnels. Here is where the dragons continue their feud.
            L0010: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L0024: if (JumpNotEqual) goto L003B;
            L0026: SetFlag(player, 0x03, 0x01, 0x05);
            L003B: return; // RETURN;
        }

        private void FnTLTWO_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0A89); // You are teleported to a series of long, dark tunnels. Here is where the dragons continue their feud.
            L0010: Compare(GetFlag(player, 0x03, 0x01), 0x0002);
            L0024: if (JumpNotEqual) goto L003B;
            L0026: SetFlag(player, 0x03, 0x01, 0x05);
            L003B: return; // RETURN;
        }

        private void FnTLTHREE_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0A89); // You are teleported to a series of long, dark tunnels. Here is where the dragons continue their feud.
            L0010: Compare(GetFlag(player, 0x03, 0x01), 0x0003);
            L0024: if (JumpNotEqual) goto L003B;
            L0026: SetFlag(player, 0x03, 0x01, 0x05);
            L003B: return; // RETURN;
        }

        private void FnTLFOUR_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0A89); // You are teleported to a series of long, dark tunnels. Here is where the dragons continue their feud.
            L0010: Compare(GetFlag(player, 0x03, 0x01), 0x0004);
            L0024: if (JumpNotEqual) goto L003B;
            L0026: SetFlag(player, 0x03, 0x01, 0x05);
            L003B: return; // RETURN;
        }

        private void FnDRAGBDR_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L0017: if (JumpNotEqual) goto L0064;
            L0019: ax = HasItem(player, 0x84);
            L0027: if (JumpEqual) goto L0064;
            L0029: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0047: PushStack(player, GetFacing(player));
            L004F: PushStack(player, GetCurrentTile(player));
            L0057: PushStack(player, 0x01);
09E0  005B C4 5E 06  les bx, [bp+0x6]
09E3  005E 26 FF 5F 30  call far word [es:bx+0x30]
            L0062: goto L007E;
            L0064: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0081: return; // RETURN;
        }

        private void FnDRAGBBDR_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x0A), 0x0001);
            L0017: if (JumpNotEqual) goto L0096;
            L0019: Compare(GetFlag(player, 0x03, 0x0E), 0x0001);
            L002D: if (JumpNotEqual) goto L0096;
            L002F: Compare(GetFlag(player, 0x03, 0x0F), 0x0001);
            L0043: if (JumpNotEqual) goto L0096;
            L0045: Compare(GetFlag(player, 0x03, 0x10), 0x0001);
            L0059: if (JumpNotEqual) goto L0096;
            L005B: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0079: PushStack(player, GetFacing(player));
            L0081: PushStack(player, GetCurrentTile(player));
            L0089: PushStack(player, 0x01);
0A95  008D C4 5E 06  les bx, [bp+0x6]
0A98  0090 26 FF 5F 30  call far word [es:bx+0x30]
            L0094: goto L00B0;
            L0096: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00B3: return; // RETURN;
        }

        private void FnDRAGADR_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x0A), 0x0001);
            L0017: if (JumpNotEqual) goto L0064;
            L0019: ax = HasItem(player, 0x84);
            L0027: if (JumpEqual) goto L0064;
            L0029: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0047: PushStack(player, GetFacing(player));
            L004F: PushStack(player, GetCurrentTile(player));
            L0057: PushStack(player, 0x01);
0B18  005B C4 5E 06  les bx, [bp+0x6]
0B1B  005E 26 FF 5F 30  call far word [es:bx+0x30]
            L0062: goto L007E;
            L0064: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0081: return; // RETURN;
        }

        private void FnDRAGAADR_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L0017: if (JumpNotEqual) goto L0096;
            L0019: Compare(GetFlag(player, 0x03, 0x0E), 0x0001);
            L002D: if (JumpNotEqual) goto L0096;
            L002F: Compare(GetFlag(player, 0x03, 0x0F), 0x0001);
            L0043: if (JumpNotEqual) goto L0096;
            L0045: Compare(GetFlag(player, 0x03, 0x10), 0x0001);
            L0059: if (JumpNotEqual) goto L0096;
            L005B: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0079: PushStack(player, GetFacing(player));
            L0081: PushStack(player, GetCurrentTile(player));
            L0089: PushStack(player, 0x01);
0BCD  008D C4 5E 06  les bx, [bp+0x6]
0BD0  0090 26 FF 5F 30  call far word [es:bx+0x30]
            L0094: goto L00B0;
            L0096: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00B3: return; // RETURN;
        }

        private void FnTWONORTH_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0026);
            L0010: ShowMessage(player, String0AEE); // 'Greetings! Have you seen my two companions? We were separated when we walked alone through a teleport.'
            L001D: SetFlag(player, 0x03, 0x0E, 0x01);
            L0032: Compare(GetFlag(player, 0x03, 0x01), 0x0005);
            L0046: if (JumpEqual) goto L004D;
0C3D  0048 B8 57 0B  mov ax, 0xb57
            L004B: goto L0050;
            L004D: ShowMessage(player, String0BBA); // 'If you see them, please tell them I'm still searching. Good journeys to you!'
            L005A: return; // RETURN;
        }

        private void FnTWOCTR_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0027);
            L0010: ShowMessage(player, String0C09); // You encounter a tired elf leaning on a wall.
            L001D: SetFlag(player, 0x03, 0x10, 0x01);
            L0032: Compare(GetFlag(player, 0x03, 0x01), 0x0005);
            L0046: if (JumpEqual) goto L004D;
0C9E  0048 B8 36 0C  mov ax, 0xc36
            L004B: goto L0050;
            L004D: ShowMessage(player, String0CAB); // 'Well met! I am searching for my lost companions. I must hurry on, safe paths!'
            L005A: return; // RETURN;
        }

        private void FnBAWCRS_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0CFB); // You notice a sign in pieces on the ground and barely make out the wording 'WARNING!!! These teleports are condemned by order of Queen Aeowyn!!!'
            L0010: ShowMessage(player, String0D8C); // Attached to the sign is a hand written note, 'Olyces, some thief told me my magic protection was gone! Something odd about these teleports or where they take me.
            L001D: ShowMessage(player, String0E2E); // I'm off to the wizards again and will meet you inside. I hope to use the correct teleport this time.' The note is signed, Bawcrs.
            L002A: return; // RETURN;
        }

        private void FnTWOSTH_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001B);
            L0010: ShowMessage(player, String0EB0); // You stumble upon an injured troll and administer aid.
            L001D: SetFlag(player, 0x03, 0x0F, 0x01);
            L0032: Compare(GetFlag(player, 0x03, 0x01), 0x0005);
            L0046: if (JumpEqual) goto L004D;
0D2B  0048 B8 E6 0E  mov ax, 0xee6
            L004B: goto L0050;
            L004D: ShowMessage(player, String0FAC); // 'My thanks to you for much needed aid. You appear to be well protected. I shall remember your kindness; fare well my friends.'
            L005A: return; // RETURN;
        }

        private void FnDRAGB_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x58), 0x0001);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: ShowMessage(player, String102B); // Gambril lumbers away.
            L0026: SetFlag(player, 0x03, 0x09, 0x01);
            L003B: goto L0147;
            L003E: ax = HasItem(player, 0x84);
            L004C: if (JumpNotEqual) goto L0051;
            L004E: goto L00E4;
            L0051: ShowPortrait(player, 0x000E);
            L005E: SetFlag(player, 0x02, 0x58, 0x01);
            L0073: AddExperience(player, 0x0007A120);
            L0085: ModifyGold(player, 0x61A8);
            L0096: GiveItem(player, 0x28);
            L00A2: GiveItem(player, 0x5A);
            L00AE: GiveItem(player, 0x0F);
            L00BA: GiveItem(player, 0xB8);
            L00C6: GiveItem(player, 0xAB);
            L00D2: ShowMessage(player, String1041); // Gambril is obviously relieved that his nemesis is finally dead.
0E1E  00DF B8 81 10  mov ax, 0x1081
            L00E2: goto L013D;
            L00E4: ShowPortrait(player, 0x000E);
            L00F1: SetFlag(player, 0x03, 0x09, 0x01);
            L0106: ShowMessage(player, String1108); // You meet Gambril, the Frost Dragon.
            L0113: ShowMessage(player, String112C); // 'For longer than I care to remember, I have feuded with my nemesis Osterog, the Ice Dragon.
            L0120: ShowMessage(player, String1188); // Our continued battles have formed tunnels within the land, and we can no longer maneuver ourselves through them.
            L012D: ShowMessage(player, String11F9); // I beseech you to help me. I will reward you generously if you bring me proof of your kill.
            L013A: ShowMessage(player, String1254); // To be successful, you may need greater magic than you now possess.'
            L0147: return; // RETURN;
        }

        private void FnDRAGBB_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x01), 0x0005);
            L0017: if (JumpEqual) goto L001C;
            L0019: goto L00ED;
            L001C: ShowMessage(player, String1298); // With the help of the proper magic, you find the dragon Gambril.
            L0029: ax = HasItem(player, 0x84);
            L0037: if (JumpEqual) goto L0048;
0EC1  0039 B8 D0 07  mov ax, 0x7d0
            L003C: PushStack(player, ax);
            L003D: PushStack(player, 0x00);
            L0040: PushStack(player, ax);
            L0041: PushStack(player, ax);
            L0042: PushStack(player, ax);
0ECB  0043 B8 B6 00  mov ax, 0xb6
            L0046: goto L0058;
0ED0  0048 B8 88 13  mov ax, 0x1388
            L004B: PushStack(player, ax);
            L004C: PushStack(player, 0x00);
            L004F: PushStack(player, ax);
            L0050: PushStack(player, ax);
            L0051: PushStack(player, 0xB7);
            L0055: PushStack(player, 0x84);
0EE1  0059 C4 5E 06  les bx, [bp+0x6]
0EE4  005C 26 FF 9F D8 00  call far word [es:bx+0xd8]
0EE9  0061 83 C4 0C  add sp, 0xc
            L0064: Compare(PartyCount(player), 0x0001);
            L006F: if (JumpNotEqual) goto L0086;
            L0071: AddEncounter(player, 0x01, 0x27);
            L0083: goto L0118;
            L0086: Compare(PartyCount(player), 0x0002);
            L0091: if (JumpNotEqual) goto L00AE;
            L0093: AddEncounter(player, 0x01, 0x0B);
            L00A5: PushStack(player, 0x26);
0F31  00A9 B8 02 00  mov ax, 0x2
            L00AC: goto L00D9;
            L00AE: AddEncounter(player, 0x01, 0x0B);
            L00C0: AddEncounter(player, 0x02, 0x0B);
            L00D2: AddEncounter(player, 0x03, 0x0C);
            L00E4: PushStack(player, 0x27);
0F70  00E8 B8 06 00  mov ax, 0x6
            L00EB: goto L0078;
            L00ED: ShowMessage(player, String12D8); // The magic protection you try to weave around yourself is not enough to protect you from Gambril's keen vision.
            L00FA: ShowMessage(player, String1347); // Scoffing that Osterog has selected a particularly pitiful party to kill him, the dragon toasts you with his flame-breath.
            L0107: DamagePlayer(player, GetMaxHits(player));
            L0118: return; // RETURN;
        }

        private void FnDRAGA_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x58), 0x0001);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: ShowMessage(player, String13C1); // Osterog lumbers away.
            L0026: SetFlag(player, 0x03, 0x0A, 0x01);
            L003B: goto L0147;
            L003E: ax = HasItem(player, 0x84);
            L004C: if (JumpNotEqual) goto L0051;
            L004E: goto L00E4;
            L0051: ShowPortrait(player, 0x000E);
            L005E: SetFlag(player, 0x02, 0x58, 0x01);
            L0073: AddExperience(player, 0x0007A120);
            L0085: ModifyGold(player, 0x61A8);
            L0096: GiveItem(player, 0x28);
            L00A2: GiveItem(player, 0x5A);
            L00AE: GiveItem(player, 0x0F);
            L00BA: GiveItem(player, 0xB8);
            L00C6: GiveItem(player, 0xAB);
            L00D2: ShowMessage(player, String13D7); // Osterog smiles broadly, gloating that his nemesis is finally dead.
1081  00DF B8 1A 14  mov ax, 0x141a
            L00E2: goto L013D;
            L00E4: ShowPortrait(player, 0x000E);
            L00F1: SetFlag(player, 0x03, 0x0A, 0x01);
            L0106: ShowMessage(player, String14BD); // You encounter Osterog, the Ice Dragon.
            L0113: ShowMessage(player, String14E4); // 'Long have I feuded with Gambril, the Frost Dragon.
            L0120: ShowMessage(player, String1518); // Our endless battles have weakened the tunnels hereabout, and we no longer dare tread them.
            L012D: ShowMessage(player, String1573); // If you can help me destroy my sworn enemy, I will reward you most generously. Bring me proof of your kill.
            L013A: ShowMessage(player, String15DE); // Your success may depend on greater magic than you now know.'
            L0147: return; // RETURN;
        }

        private void FnDRAGAA_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x01), 0x0005);
            L0017: if (JumpEqual) goto L001C;
            L0019: goto L00ED;
            L001C: ShowMessage(player, String161B); // The proper magic has led you to the dragon Osterog.
            L0029: ax = HasItem(player, 0x84);
            L0037: if (JumpEqual) goto L0048;
1124  0039 B8 D0 07  mov ax, 0x7d0
            L003C: PushStack(player, ax);
            L003D: PushStack(player, 0x00);
            L0040: PushStack(player, ax);
            L0041: PushStack(player, ax);
            L0042: PushStack(player, ax);
112E  0043 B8 B6 00  mov ax, 0xb6
            L0046: goto L0058;
1133  0048 B8 88 13  mov ax, 0x1388
            L004B: PushStack(player, ax);
            L004C: PushStack(player, 0x00);
            L004F: PushStack(player, ax);
            L0050: PushStack(player, ax);
            L0051: PushStack(player, 0xB7);
            L0055: PushStack(player, 0x84);
1144  0059 C4 5E 06  les bx, [bp+0x6]
1147  005C 26 FF 9F D8 00  call far word [es:bx+0xd8]
114C  0061 83 C4 0C  add sp, 0xc
            L0064: Compare(PartyCount(player), 0x0001);
            L006F: if (JumpNotEqual) goto L0086;
            L0071: AddEncounter(player, 0x01, 0x28);
            L0083: goto L0125;
            L0086: Compare(PartyCount(player), 0x0002);
            L0091: if (JumpNotEqual) goto L00AE;
            L0093: AddEncounter(player, 0x01, 0x0B);
            L00A5: PushStack(player, 0x26);
1194  00A9 B8 02 00  mov ax, 0x2
            L00AC: goto L00D9;
            L00AE: AddEncounter(player, 0x01, 0x0B);
            L00C0: AddEncounter(player, 0x02, 0x0B);
            L00D2: AddEncounter(player, 0x04, 0x1D);
            L00E4: PushStack(player, 0x28);
11D3  00E8 B8 06 00  mov ax, 0x6
            L00EB: goto L0078;
            L00ED: ShowMessage(player, String164F); // As you tiptoe towards the great beast, Osterog sniffs once and smiles a saurian smile.
            L00FA: ShowMessage(player, String16A6); // 'Gambril has sent fools to kill me.'
            L0107: ShowMessage(player, String16CB); // He turns toward you and roasts you with his flame-breath.
            L0114: DamagePlayer(player, GetMaxHits(player));
            L0125: return; // RETURN;
        }

        private void FnSETBA_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1705); // You encounter other adventurers who seek the dragon's reward.
            L0010: Compare(PartyCount(player), 0x0001);
            L001B: if (JumpNotEqual) goto L0039;
            L001D: AddEncounter(player, 0x01, 0x14);
            L002F: PushStack(player, 0x24);
1245  0033 B8 02 00  mov ax, 0x2
            L0036: goto L00E2;
            L0039: Compare(PartyCount(player), 0x0002);
            L0044: if (JumpNotEqual) goto L0081;
            L0046: AddEncounter(player, 0x01, 0x14);
            L0058: AddEncounter(player, 0x02, 0x1C);
            L006A: AddEncounter(player, 0x05, 0x24);
128E  007C B8 21 00  mov ax, 0x21
            L007F: goto L00DE;
            L0081: AddEncounter(player, 0x01, 0x14);
            L0093: AddEncounter(player, 0x02, 0x14);
            L00A5: AddEncounter(player, 0x03, 0x18);
            L00B7: AddEncounter(player, 0x04, 0x18);
            L00C9: AddEncounter(player, 0x05, 0x24);
            L00DB: AddEncounter(player, 0x06, 0x25);
            L00ED: return; // RETURN;
        }

        private void FnSETBB_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x11);
            L0022: PushStack(player, 0x1C);
1327  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00B5;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0066;
            L0039: AddEncounter(player, 0x01, 0x1C);
            L004B: AddEncounter(player, 0x02, 0x0F);
            L005D: PushStack(player, 0x0C);
1362  0061 B8 05 00  mov ax, 0x5
            L0064: goto L00B5;
            L0066: AddEncounter(player, 0x01, 0x0E);
            L0078: AddEncounter(player, 0x02, 0x0E);
            L008A: AddEncounter(player, 0x03, 0x1D);
            L009C: AddEncounter(player, 0x05, 0x20);
            L00AE: AddEncounter(player, 0x06, 0x20);
            L00C0: return; // RETURN;
        }

        private void FnSETBC_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x02);
            L0022: PushStack(player, 0x1F);
13E9  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00C7;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0078;
            L0039: AddEncounter(player, 0x01, 0x1F);
            L004B: AddEncounter(player, 0x02, 0x01);
            L005D: AddEncounter(player, 0x05, 0x19);
            L006F: PushStack(player, 0x1A);
1436  0073 B8 06 00  mov ax, 0x6
            L0076: goto L00C7;
            L0078: AddEncounter(player, 0x01, 0x05);
            L008A: AddEncounter(player, 0x02, 0x05);
            L009C: AddEncounter(player, 0x03, 0x1B);
            L00AE: AddEncounter(player, 0x04, 0x1E);
            L00C0: AddEncounter(player, 0x05, 0x1D);
            L00D2: return; // RETURN;
        }

        private void FnSTRENGTH_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x90), 0x0001);
            L0017: if (JumpNotEqual) goto L0027;
14B0  0019 B8 43 17  mov ax, 0x1743
            L001C: PushStack(player, ax);
14B4  001D C4 5E 06  les bx, [bp+0x6]
14B7  0020 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L0025: goto L0091;
            L0027: ShowMessage(player, String176C); // As you push against the stubborn door, debris falls and injures you.
            L0034: Compare(CheckStrength(player), 0x0017);
            L0043: if (JumpBelow) goto L0066;
            L0045: SetFlag(player, 0x02, 0x90, 0x01);
            L005A: ax = GetMaxHits(player);
            L0061: bx = 0x0003;
            L0064: goto L0085;
            L0066: SetFlag(player, 0x02, 0x90, 0x01);
            L007B: ax = GetMaxHits(player);
            L0082: bx = 0x0004;
            L0085: dx = ax % bx; ax = ax / bx;
            L0088: DamagePlayer(player, ax);
            L0092: return; // RETURN;
        }

        private void FnDEFENSE_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x93), 0x0001);
            L0017: if (JumpNotEqual) goto L0028;
            L0019: ShowMessage(player, String17B1); // The walls around you have been fortified.
            L0026: goto L0076;
            L0028: ShowMessage(player, String17DB); // The walls collapse upon you! Amnesia causes you to forget your more recent experiences.
            L0035: PushStack(player, 0x01);
1564  0039 C4 5E 06  les bx, [bp+0x6]
1567  003C 26 FF 9F A4 00  call far word [es:bx+0xa4]
            L0041: cx = PopStack(player);
            L0042: Compare(ax, 0x0012);
            L0045: if (JumpBelow) goto L004F;
1572  0047 B8 FF FF  mov ax, 0xffff
1575  004A BA F0 D8  mov dx, 0xd8f0
            L004D: goto L0055;
            L004F: AddExperience(player, 0xFFFFB1E0);
            L0061: SetFlag(player, 0x02, 0x93, 0x01);
            L0076: return; // RETURN;
        }

        private void FnINIT_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x91), 0x0001);
            L0017: if (JumpNotEqual) goto L0028;
            L0019: ShowMessage(player, String1833); // You elude a thief hiding in the shadows.
            L0026: goto L0076;
            L0028: ShowMessage(player, String185C); // A thief runs by you and picks your pocket.
            L0035: PushStack(player, 0x03);
15DC  0039 C4 5E 06  les bx, [bp+0x6]
15DF  003C 26 FF 9F A4 00  call far word [es:bx+0xa4]
            L0041: cx = PopStack(player);
            L0042: Compare(ax, 0x000D);
            L0045: if (JumpBelow) goto L004F;
15EA  0047 B8 FF FF  mov ax, 0xffff
15ED  004A BA 58 9E  mov dx, 0x9e58
            L004D: goto L0055;
            L004F: ModifyGold(player, 0xFFFFB0BA);
            L0061: SetFlag(player, 0x02, 0x91, 0x01);
            L0076: return; // RETURN;
        }

        private void FnAGILITY_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x92), 0x0001);
            L0017: if (JumpNotEqual) goto L0028;
            L0019: ShowMessage(player, String1887); // You resist the magical forces emanating from the chamber.
            L0026: goto L006E;
            L0028: ShowMessage(player, String18C1); // You feel magical forces drain your mana.
            L0035: PushStack(player, 0x02);
1654  0039 C4 5E 06  les bx, [bp+0x6]
1657  003C 26 FF 9F A4 00  call far word [es:bx+0xa4]
            L0041: cx = PopStack(player);
            L0042: Compare(ax, 0x000B);
            L0045: if (JumpBelow) goto L004C;
1662  0047 B8 38 FF  mov ax, 0xff38
            L004A: goto L004F;
            L004C: AddMana(player, 0xFE70);
            L0059: SetFlag(player, 0x02, 0x92, 0x01);
            L006E: return; // RETURN;
        }

        private void FnCLUESPEL_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x000B);
            L0010: ShowMessage(player, String18EA); // The ghost of an adventurer appears before you.
            L001D: ShowMessage(player, String1919); // 'Seek out the wizards in Dragon's Flame for help. Each, for a fee, will aid you with his or her unusual magic.
            L002A: ShowMessage(player, String1988); // BUT, all spells are not successful for all.
            L0037: ShowMessage(player, String19B4); // I wish you better luck than I had. And remember, it is imperative that you stay in the area until you successfully complete your quest.'
            L0044: return; // RETURN;
        }

        private void FnTPORTB_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x08, 0x02, 0x45, 0x02, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnTPORTA_36(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x08, 0x02, 0xB9, 0x03, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnCLEAR_37(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x03, 0x01, 0x00);
            L0017: SetFlag(player, 0x03, 0x0E, 0x00);
            L002B: SetFlag(player, 0x03, 0x0F, 0x00);
            L003F: SetFlag(player, 0x03, 0x10, 0x00);
            L0053: return; // RETURN;
        }

    }
}
