#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Twinion.Maps {
    class TwMap11 : AMapScripted {
        protected override int MapIndex => 11;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public TwMap11() {
            MapEvent01 = FnWATER_01;
            MapEvent02 = FnSSTEP_02;
            MapEvent03 = FnOTHERSTP_03;
            MapEvent04 = FnTELEA_04;
            MapEvent05 = FnLAVA_05;
            MapEvent06 = FnTELECLO_06;
            MapEvent07 = FnFTNA_07;
            MapEvent08 = FnMAPD_08;
            MapEvent09 = FnTELEC_09;
            MapEvent0A = FnPIT_0A;
            MapEvent0B = FnSECA_0B;
            MapEvent0C = FnKEYA_0C;
            MapEvent0D = FnNOMAP_0D;
            MapEvent0E = FnCONSTR_0E;
            MapEvent0F = FnCLUEA_0F;
            MapEvent10 = FnPITA_10;
            MapEvent11 = FnCLUEB_11;
            MapEvent12 = FnCL_12;
            MapEvent13 = FnTELEE_13;
            MapEvent14 = FnBLCK_14;
            MapEvent15 = FnTELEG_15;
            MapEvent16 = FnPITB_16;
            MapEvent17 = FnGOLD_17;
            MapEvent18 = FnROTWE_18;
            MapEvent19 = FnROTSTH_19;
            MapEvent1A = FnPITC_1A;
            MapEvent1D = FnTELEL_1D;
            MapEvent1E = FnTELEM_1E;
            MapEvent1F = FnSMUG_1F;
            MapEvent20 = FnPITTXT_20;
            MapEvent21 = FnDEATHDR_21;
            MapEvent22 = FnCLUEC_22;
            MapEvent25 = FnROPEPIT_25;
            MapEvent26 = FnSECTHF_26;
            MapEvent27 = FnSMUGDOOR_27;
            MapEvent28 = FnFTNB_28;
            MapEvent2C = FnTELES_2C;
            MapEvent2D = FnGOODIEB_2D;
            MapEvent2E = FnKEYTHF_2E;
            MapEvent2F = FnTELET_2F;
            MapEvent30 = FnCLUED_30;
            MapEvent31 = FnCLUEE_31;
            MapEvent32 = FnCLUEF_32;
            MapEvent33 = FnCLUEG_33;
            MapEvent34 = FnCLUEH_34;
            MapEvent35 = FnNOENT_35;
            MapEvent36 = FnEMLOCK_36;
            MapEvent37 = FnSECCLE_37;
            MapEvent38 = FnKEYCLE_38;
            MapEvent39 = FnCLUEI_39;
            MapEvent3A = FnCLUEJ_3A;
            MapEvent3B = FnTELEU_3B;
            MapEvent3C = FnNEWTP_3C;
            MapEvent3D = FnPTYTPT_3D;
            MapEvent3E = FnCLUEK_3E;
            MapEvent3F = FnMEDA_3F;
            MapEvent40 = FnHRD_40;
            MapEvent41 = FnMEDB_41;
            MapEvent42 = FnMEDC_42;
            MapEvent43 = FnMEDD_43;
            MapEvent44 = FnMEDE_44;
            MapEvent45 = FnEZ_45;
            MapEvent46 = FnTPBALL_46;
            MapEvent47 = FnLOCKTXT_47;
        }
        
        // === Strings ================================================
        private const string String03FC = "The waters drain your life energy.";
        private const string String041F = "The Life Jacket keeps you from drowning.";
        private const string String0448 = "The platform buckles under your weight.";
        private const string String0470 = "Your foot is snared by the sinking platform and you are dragged to the bottom of the lake.";
        private const string String04CB = "What appeared to be a platform is actually the back of a giant underwater creature.";
        private const string String051F = "He is awakened by your weight on his back and plunges deep into the lake, taking you to the bottom with him.";
        private const string String058C = "You have drowned!";
        private const string String059E = "However, he remains asleep and offers you a stable stepping stone.";
        private const string String05E1 = "Beyond the door are stairs leading down to the Cellar.";
        private const string String0618 = "You step into a stream of lava.";
        private const string String0638 = "The medicinal waters of Herbal Fountain heal you and renew your spell casting powers.";
        private const string String068E = "The medicinal waters of Herbal Fountain heal you, renew your spell casting powers and endow you with the Lightning spell.";
        private const string String0708 = "The medicinal waters of Herbal Fountain heal you, renew your spell casting powers and endow you with the Cure spell.";
        private const string String077D = "The heat from the lava is almost unbearable.";
        private const string String07AA = "You detect signs of a struggle on the ground near a torn parchment.";
        private const string String07EE = "It is one of the four maps the Queen asked you to find.";
        private const string String0826 = "You approach two men fighting over a piece of parchment.";
        private const string String085F = "Before you can intervene, they topple into the lava. The parchment flutters gracefully to the ground.";
        private const string String08C5 = "A glance at the Parchment Map proves it is one of the four maps Queen Aeowyn asked you to find.";
        private const string String0925 = "The teleport will lead you to the Carriage House.";
        private const string String0957 = "You fall into a pit.";
        private const string String096C = "The room is empty.";
        private const string String097F = "While stooping down to pick up a key, your Life Jacket falls into the water and floats away.";
        private const string String09DC = "The grasp of the key is engraved with two arms clasped in fellowship.";
        private const string String0A22 = "While stooping down to pick up some items, your Life Jacket falls into the water and floats away.";
        private const string String0A84 = "You stoop down to pick up a key but accidentally knock it into the water.";
        private const string String0ACE = "Unfortunately, you lack what you need to retrieve it.";
        private const string String0B04 = "Posted on the door you see: 'DANGER! Unstable ground.'";
        private const string String0B3B = "You overhear passers-by discussing the fact that not all pits lead to death; some have been transformed into passages.";
        private const string String0BB2 = "A jump into the pit lands you in the Library.";
        private const string String0BE0 = "A half-crazed Gnome Wizard looks in the direction of the Cartography Shop.";
        private const string String0C2B = "'Riddles, riddles,' he says mysteriously and wanders off.";
        private const string String0C65 = "Through this teleport you will find the Stables.";
        private const string String0C96 = "You fall into the Carriage House.";
        private const string String0CB8 = "You see an empty safe.";
        private const string String0CCF = "The safe opens easily with the Diamond Lockpick.";
        private const string String0D00 = "Inside are 100,000 gold pieces, which somehow find their way into your pocket, and a few items which were tucked away for safekeeping.";
        private const string String0D87 = "Deep within the Vault you find a safe; unfortunately, it is secured shut with a diamond shaped lock.";
        private const string String0DEC = "You discover a short cut to the Stables.";
        private const string String0E15 = "You can barely read the water-stained sign. It says, 'To Clueless.'";
        private const string String0E59 = "This way leads to Tipekans' Bridge.";
        private const string String0E7D = "Smug grins at the sight of your Ruby Lockpick.";
        private const string String0EAC = "He crooks a thumb towards the door to the west.";
        private const string String0EDC = "The ground gives way beneath you.";
        private const string String0EFE = "As you try to open the door, you spring a trap set by Smug.";
        private const string String0F3A = "This is the back door to Smug's Jewelry Shop.";
        private const string String0F68 = "A message is scrawled on the wall -";
        private const string String0F8C = "'Inventory items have been known to change hazardous steps into safe steps.'";
        private const string String0FD9 = "The ground gives way and you slide down a tunnel.";
        private const string String100B = "You quickly throw your rope over a rock and lower yourself into the Library.";
        private const string String1058 = "The ground gives way and you slide down a forked tunnel.";
        private const string String1091 = "This time, you tumble down the left tube.";
        private const string String10BB = "A sign on the door - 'THIEVES ONLY.'";
        private const string String10E0 = "You successfully unlock the door.";
        private const string String1102 = "The entrance to Smug's Jewelry Shop is locked.";
        private const string String1131 = "The Rich Waters of Sterling Fountain heal and restore you.";
        private const string String116C = "A ghostly voice cackles in glee, 'Cursed you are, cursed to go where I wish! Muhahahaha!'";
        private const string String11C6 = "It looks like you're not the only one to discover the thieves' hiding place.";
        private const string String1213 = "You find a key which may open seemingly impassable doors in your race to finish Queen Aeowyn's Map Quest.";
        private const string String127D = "The key is made of bone and features a skull and crossed arm bones.";
        private const string String12C1 = "Your Guildmaster left you a special key that will give you access to magical armor.";
        private const string String1315 = "The key is made of bone. The grasp is shaped like a skull and the shaft like two crossed, bony arms.";
        private const string String137A = "The room is bare.";
        private const string String138C = "Beyond the door lies a twisted maze. To find your way through would be aMAZEing.";
        private const string String13DD = "`Pluthros`";
        private const string String13E8 = "Ashakkar is where all who oppose Chaos shall find this Fate.";
        private const string String1425 = "Carved in the base you see the name `Lord Zzuf`";
        private const string String1455 = "This work of art, however is unfinished; perhaps later you can come back and see it completed.";
        private const string String14B4 = "Your quest bag shifts and hits the statue of Lord Zzuf, causing the great explorer's icon to move slightly.";
        private const string String1520 = "You push the statue's base and find enough room for a person to squeeze through.";
        private const string String1571 = "`Juvalad`";
        private const string String157B = "Enakkar is where all who oppose Harmony shall find this Fate.";
        private const string String15B9 = "`Malos`";
        private const string String15C1 = "En-Li-Kil's master, and guardian to the Elementals.";
        private const string String15F5 = "`Crysillus Draco and Sayvut d'Oi Vey`";
        private const string String161B = "These were the great engineers who built the shrines to the Fates those many moons ago.";
        private const string String1673 = "'Enter at your own risk!'";
        private const string String168D = "You see something green on the ground - and something nasty charging at you.";
        private const string String16DA = "A sign on the door - 'CLERICS ONLY.'";
        private const string String16FF = "`Astelligus`";
        private const string String170C = "The blackest pitch cannot compare to this Fate's home.";
        private const string String1743 = "An Orc Knight is frantically searching the ground.";
        private const string String1776 = "'All I need to get into the secret armory rooms is that blasted Skeleton Key I dropped somewhere back here!";
        private const string String17E2 = "Of course, one needs more than that, as you well know!'";
        private const string String181A = "The Knight dashes off before you can say anything.";
        private const string String184D = "Be sure of your footing when you scale the heights of Cliffhanger.";
        private const string String1890 = "Magical forces swirl about you, where you might end up you have no clue.";
        private const string String18D9 = "You have discovered the secret portal to the Ballroom.";
        private const string String1910 = "The space is too narrow for more than one person to squeeze through.";
        private const string String1955 = "`Corpeus`";
        private const string String195F = "This Fate welcomes all to sample his wisdom; or die from his wrath.";
        private const string String19A3 = "'Lockpicks for sale!! Lockpicks for sale!!";
        private const string String19CE = "Can I sell you a lockpick, brave champion? I see you have one, beautiful too. Care to sell it?";
        private const string String1A2D = "You must know that the brothers seek red, only red! No? Drat! Then be off with you and let me sell my wares!'";
        private const string String1A9B = "'Brave Warrior! Are you in search of the Emerald Lockpick, too? I must find it and get to Tipekans!'";
        
        // === Functions ================================================
        private void FnWATER_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoHealZone(player);
            L000B: PushStack(player, 0x01);
            L000F: PushStack(player, 0x00);
0012  0012 C4 5E 06  les bx, [bp+0x6]
0015  0015 26 FF 5F 04  call far word [es:bx+0x4]
            L0019: cx = PopStack(player);
            L001A: cx = PopStack(player);
            L001B: RefreshCompareFlags(ax);
            L001D: if (JumpNotEqual) goto L0054;
            L001F: ax = GetMaxHits(player);
            L0026: bx = 0x0004;
            L0029: dx = ax % bx; ax = ax / bx;
            L002C: DamagePlayer(player, ax);
            L0036: ShowMessage(player, String03FC); // The waters drain your life energy.
            L0043: PushStack(player, 0x01);
            L0047: PushStack(player, ax);
            L0048: PushStack(player, 0x00);
004B  004B C4 5E 06  les bx, [bp+0x6]
004E  004E 26 FF 1F  call far word [es:bx]
0051  0051 83 C4 06  add sp, 0x6
            L0054: return; // RETURN;
        }

        private void FnSSTEP_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xE1);
            L0011: if (JumpEqual) goto L0022;
            L0013: ShowMessage(player, String041F); // The Life Jacket keeps you from drowning.
            L0020: goto L0049;
            L0022: ShowMessage(player, String0448); // The platform buckles under your weight.
            L002F: ShowMessage(player, String0470); // Your foot is snared by the sinking platform and you are dragged to the bottom of the lake.
            L003C: XCall Fn1572
            L0047: cx = PopStack(player);
            L0048: cx = PopStack(player);
            L0049: return; // RETURN;
        }

        private void FnOTHERSTP_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String04CB); // What appeared to be a platform is actually the back of a giant underwater creature.
            L0010: ax = HasItem(player, 0xE1);
            L001E: if (JumpEqual) goto L0049;
            L0020: ShowMessage(player, String051F); // He is awakened by your weight on his back and plunges deep into the lake, taking you to the bottom with him.
            L002D: ShowMessage(player, String058C); // You have drowned!
            L003A: XCall Fn1527
            L0045: cx = PopStack(player);
            L0046: cx = PopStack(player);
            L0047: goto L0056;
            L0049: ShowMessage(player, String059E); // However, he remains asleep and offers you a stable stepping stone.
            L0056: return; // RETURN;
        }

        private void FnTELEA_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String05E1); // Beyond the door are stairs leading down to the Cellar.
            L0010: TeleportParty(player, 0x06, 0x01, 0x08, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnLAVA_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0618); // You step into a stream of lava.
            L0010: XCall Fn14A2
            L001B: cx = PopStack(player);
            L001C: cx = PopStack(player);
            L001D: return; // RETURN;
        }

        private void FnTELECLO_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x06, 0x01, 0x59, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnFTNA_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: Compare(GetFlag(player, 0x02, 0x48), 0x0001);
            L0024: if (JumpNotEqual) goto L0038;
            L0026: XCall Fn1479
            L0031: cx = PopStack(player);
            L0032: cx = PopStack(player);
0198  0033 B8 38 06  mov ax, 0x638
            L0036: goto L0090;
            L0038: SetFlag(player, 0x02, 0x48, 0x01);
            L004D: XCall Fn1479
            L0058: cx = PopStack(player);
            L0059: cx = PopStack(player);
            L005A: Compare(GetGuild(player), 0x0002);
            L0064: if (JumpNotEqual) goto L007C;
            L0066: SetSpellLevel(player, 0x08, 0x01);
01DC  0077 B8 8E 06  mov ax, 0x68e
            L007A: goto L0090;
            L007C: SetSpellLevel(player, 0x13, 0x01);
            L008D: ShowMessage(player, String0708); // The medicinal waters of Herbal Fountain heal you, renew your spell casting powers and endow you with the Cure spell.
            L009A: return; // RETURN;
        }

        private void FnMAPD_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x49), 0x0001);
            L0017: if (JumpNotEqual) goto L004C;
            L0019: ax = HasItem(player, 0xD4);
            L0027: if (JumpEqual) goto L002E;
022A  0029 B8 7D 07  mov ax, 0x77d
            L002C: goto L009C;
            L002E: GiveItem(player, 0xD4);
            L003A: ShowMessage(player, String07AA); // You detect signs of a struggle on the ground near a torn parchment.
0248  0047 B8 EE 07  mov ax, 0x7ee
            L004A: goto L009C;
            L004C: GiveItem(player, 0xD4);
            L0058: AddExperience(player, 0x00030D40);
            L006A: SetFlag(player, 0x02, 0x49, 0x01);
            L007F: ShowMessage(player, String0826); // You approach two men fighting over a piece of parchment.
            L008C: ShowMessage(player, String085F); // Before you can intervene, they topple into the lava. The parchment flutters gracefully to the ground.
            L0099: ShowMessage(player, String08C5); // A glance at the Parchment Map proves it is one of the four maps Queen Aeowyn asked you to find.
            L00A6: return; // RETURN;
        }

        private void FnTELEC_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0925); // The teleport will lead you to the Carriage House.
            L0010: TeleportParty(player, 0x06, 0x01, 0x44, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnPIT_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
02D9  0003 C4 5E 06  les bx, [bp+0x6]
02DC  0006 26 FF 9F E8 00  call far word [es:bx+0xe8]
            L000B: ShowMessage(player, String0957); // You fall into a pit.
            L0018: XCall Fn12F2
            L0023: cx = PopStack(player);
            L0024: cx = PopStack(player);
            L0025: return; // RETURN;
        }

        private void FnSECA_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0021: return; // RETURN;
        }

        private void FnKEYA_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x47), 0x0001);
            L0017: if (JumpNotEqual) goto L005A;
            L0019: RemoveItem(player, 0xE1);
            L0025: ax = HasItem(player, 0xD8);
            L0033: if (JumpEqual) goto L003B;
0355  0035 B8 6C 09  mov ax, 0x96c
            L0038: goto L00EB;
            L003B: GiveItem(player, 0xD8);
            L0047: ShowMessage(player, String097F); // While stooping down to pick up a key, your Life Jacket falls into the water and floats away.
0374  0054 B8 DC 09  mov ax, 0x9dc
            L0057: goto L00EB;
            L005A: ax = HasItem(player, 0xE1);
            L0068: if (JumpEqual) goto L00DB;
            L006A: GiveItem(player, 0xD8);
            L0076: GiveItem(player, 0x45);
            L0082: GiveItem(player, 0x8E);
            L008E: AddExperience(player, 0x0000C350);
            L009F: SetFlag(player, 0x02, 0x47, 0x01);
            L00B4: ShowMessage(player, String0A22); // While stooping down to pick up some items, your Life Jacket falls into the water and floats away.
            L00C1: ShowMessage(player, String09DC); // The grasp of the key is engraved with two arms clasped in fellowship.
            L00CE: PushStack(player, 0xE1);
03F2  00D2 C4 5E 06  les bx, [bp+0x6]
03F5  00D5 26 FF 5F 4C  call far word [es:bx+0x4c]
            L00D9: goto L00F4;
            L00DB: ShowMessage(player, String0A84); // You stoop down to pick up a key but accidentally knock it into the water.
            L00E8: ShowMessage(player, String0ACE); // Unfortunately, you lack what you need to retrieve it.
            L00F5: return; // RETURN;
        }

        private void FnNOMAP_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
041A  0003 C4 5E 06  les bx, [bp+0x6]
041D  0006 26 FF 9F E8 00  call far word [es:bx+0xe8]
            L000B: return; // RETURN;
        }

        private void FnCONSTR_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0B04); // Posted on the door you see: 'DANGER! Unstable ground.'
            L0010: return; // RETURN;
        }

        private void FnCLUEA_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0B3B); // You overhear passers-by discussing the fact that not all pits lead to death; some have been transformed into passages.
            L0010: return; // RETURN;
        }

        private void FnPITA_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0BB2); // A jump into the pit lands you in the Library.
            L0010: TeleportParty(player, 0x06, 0x01, 0x5A, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnCLUEB_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002D);
            L0010: ShowMessage(player, String0BE0); // A half-crazed Gnome Wizard looks in the direction of the Cartography Shop.
            L001D: ShowMessage(player, String0C2B); // 'Riddles, riddles,' he says mysteriously and wanders off.
            L002A: return; // RETURN;
        }

        private void FnCL_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0021: return; // RETURN;
        }

        private void FnTELEE_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x05, 0x01, 0x40, 0x01, isForwardMove);
            L001E: return; // RETURN;
        }

        private void FnBLCK_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0020: return; // RETURN;
        }

        private void FnTELEG_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0C65); // Through this teleport you will find the Stables.
            L0010: TeleportParty(player, 0x06, 0x01, 0xA4, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnPITB_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0C96); // You fall into the Carriage House.
            L0010: TeleportParty(player, 0x06, 0x01, 0x76, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnGOLD_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xDA);
            L0011: if (JumpEqual) goto L008B;
            L0013: Compare(GetFlag(player, 0x02, 0x4A), 0x0001);
            L0027: if (JumpNotEqual) goto L002E;
0589  0029 B8 B8 0C  mov ax, 0xcb8
            L002C: goto L008E;
058E  002E B8 01 00  mov ax, 0x1
0591  0031 BA A0 86  mov dx, 0x86a0
            L0034: PushStack(player, ax);
            L0035: PushStack(player, dx);
0596  0036 C4 5E 06  les bx, [bp+0x6]
0599  0039 26 FF 9F AC 00  call far word [es:bx+0xac]
            L003E: cx = PopStack(player);
            L003F: cx = PopStack(player);
            L0040: GiveItem(player, 0x92);
            L004C: GiveItem(player, 0x48);
            L0058: GiveItem(player, 0x36);
            L0064: SetFlag(player, 0x02, 0x4A, 0x01);
            L0079: ShowMessage(player, String0CCF); // The safe opens easily with the Diamond Lockpick.
05E6  0086 B8 00 0D  mov ax, 0xd00
            L0089: goto L008E;
            L008B: ShowMessage(player, String0D87); // Deep within the Vault you find a safe; unfortunately, it is secured shut with a diamond shaped lock.
            L0098: return; // RETURN;
        }

        private void FnROTWE_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
05FD  0003 C4 5E 06  les bx, [bp+0x6]
0600  0006 26 FF 9F E8 00  call far word [es:bx+0xe8]
            L000B: PushStack(player, 0x01);
            L000F: PushStack(player, 0x00);
060C  0012 C4 5E 06  les bx, [bp+0x6]
060F  0015 26 FF 5F 04  call far word [es:bx+0x4]
            L0019: cx = PopStack(player);
            L001A: cx = PopStack(player);
            L001B: RefreshCompareFlags(ax);
            L001D: if (JumpNotEqual) goto L003C;
            L001F: PushStack(player, 0x00);
061C  0022 C4 5E 06  les bx, [bp+0x6]
061F  0025 26 FF 9F CC 00  call far word [es:bx+0xcc]
            L002A: cx = PopStack(player);
            L002B: PushStack(player, 0x01);
            L002F: PushStack(player, ax);
            L0030: PushStack(player, 0x00);
062D  0033 C4 5E 06  les bx, [bp+0x6]
0630  0036 26 FF 1F  call far word [es:bx]
0633  0039 83 C4 06  add sp, 0x6
            L003C: return; // RETURN;
        }

        private void FnROTSTH_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
063B  0003 C4 5E 06  les bx, [bp+0x6]
063E  0006 26 FF 9F E8 00  call far word [es:bx+0xe8]
            L000B: PushStack(player, 0x01);
            L000F: PushStack(player, 0x00);
064A  0012 C4 5E 06  les bx, [bp+0x6]
064D  0015 26 FF 5F 04  call far word [es:bx+0x4]
            L0019: cx = PopStack(player);
            L001A: cx = PopStack(player);
            L001B: RefreshCompareFlags(ax);
            L001D: if (JumpNotEqual) goto L003D;
            L001F: PushStack(player, 0x01);
065B  0023 C4 5E 06  les bx, [bp+0x6]
065E  0026 26 FF 9F CC 00  call far word [es:bx+0xcc]
            L002B: cx = PopStack(player);
            L002C: PushStack(player, 0x01);
            L0030: PushStack(player, ax);
            L0031: PushStack(player, 0x00);
066C  0034 C4 5E 06  les bx, [bp+0x6]
066F  0037 26 FF 1F  call far word [es:bx]
0672  003A 83 C4 06  add sp, 0x6
            L003D: return; // RETURN;
        }

        private void FnPITC_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0DEC); // You discover a short cut to the Stables.
            L0010: TeleportParty(player, 0x06, 0x01, 0x86, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnTELEL_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0E15); // You can barely read the water-stained sign. It says, 'To Clueless.'
            L0010: TeleportParty(player, 0x04, 0x01, 0x45, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnTELEM_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0E59); // This way leads to Tipekans' Bridge.
            L0010: TeleportParty(player, 0x07, 0x01, 0xA1, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnSMUG_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
070B  0003 C4 5E 06  les bx, [bp+0x6]
070E  0006 26 FF 9F E8 00  call far word [es:bx+0xe8]
            L000B: ShowPortrait(player, 0x0025);
            L0018: ShowMessage(player, String0E7D); // Smug grins at the sight of your Ruby Lockpick.
            L0025: ShowMessage(player, String0EAC); // He crooks a thumb towards the door to the west.
            L0032: return; // RETURN;
        }

        private void FnPITTXT_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0EDC); // The ground gives way beneath you.
            L0010: DamagePlayer(player, GetMaxHits(player));
            L0021: return; // RETURN;
        }

        private void FnDEATHDR_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0xDD);
            L0007: PushStack(player, ax);
0767  0008 C4 5E 06  les bx, [bp+0x6]
076A  000B 26 FF 5F 54  call far word [es:bx+0x54]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L002F;
            L0015: ShowMessage(player, String0EFE); // As you try to open the door, you spring a trap set by Smug.
            L0022: XCall Fn0E69
            L002D: goto L0047;
            L002F: ShowMessage(player, String0F3A); // This is the back door to Smug's Jewelry Shop.
            L003C: XCall Fn0EC5
            L0047: cx = PopStack(player);
            L0048: cx = PopStack(player);
            L0049: return; // RETURN;
        }

        private void FnCLUEC_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0F68); // A message is scrawled on the wall -
            L0010: ShowMessage(player, String0F8C); // 'Inventory items have been known to change hazardous steps into safe steps.'
            L001D: return; // RETURN;
        }

        private void FnROPEPIT_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xE0);
            L0011: if (JumpEqual) goto L0036;
            L0013: ShowMessage(player, String0FD9); // The ground gives way and you slide down a tunnel.
            L0020: ShowMessage(player, String100B); // You quickly throw your rope over a rock and lower yourself into the Library.
            L002D: PushStack(player, 0x02);
0804  0031 B8 49 00  mov ax, 0x49
            L0034: goto L0056;
            L0036: ShowMessage(player, String1058); // The ground gives way and you slide down a forked tunnel.
            L0043: ShowMessage(player, String1091); // This time, you tumble down the left tube.
            L0050: TeleportParty(player, 0x06, 0x01, 0x46, 0x00, isForwardMove);
            L006A: return; // RETURN;
        }

        private void FnSECTHF_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0003);
            L000D: if (JumpNotEqual) goto L0036;
            L000F: ShowMessage(player, String10BB); // A sign on the door - 'THIEVES ONLY.'
            L001C: XCall Fn0E07
            L0027: cx = PopStack(player);
            L0028: cx = PopStack(player);
            L0029: XCall Fn0DC2
            L0034: goto L0041;
            L0036: XCall Fn0DE5
            L0041: cx = PopStack(player);
            L0042: cx = PopStack(player);
            L0043: return; // RETURN;
        }

        private void FnSMUGDOOR_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0xDD);
            L0007: PushStack(player, ax);
088C  0008 C4 5E 06  les bx, [bp+0x6]
088F  000B 26 FF 5F 54  call far word [es:bx+0x54]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0034;
            L0015: XCall Fn0D7D
            L0020: cx = PopStack(player);
            L0021: cx = PopStack(player);
            L0022: XCall Fn0DC2
            L002D: cx = PopStack(player);
            L002E: cx = PopStack(player);
08B3  002F B8 E0 10  mov ax, 0x10e0
            L0032: goto L0044;
            L0034: XCall Fn0DA0
            L003F: cx = PopStack(player);
            L0040: cx = PopStack(player);
            L0041: ShowMessage(player, String1102); // The entrance to Smug's Jewelry Shop is locked.
            L004E: return; // RETURN;
        }

        private void FnFTNB_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1131); // The Rich Waters of Sterling Fountain heal and restore you.
            L0010: XCall Fn0D95
            L001B: cx = PopStack(player);
            L001C: cx = PopStack(player);
            L001D: XCall Fn0D0A
            L0028: cx = PopStack(player);
            L0029: cx = PopStack(player);
            L002A: return; // RETURN;
        }

        private void FnTELES_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String116C); // A ghostly voice cackles in glee, 'Cursed you are, cursed to go where I wish! Muhahahaha!'
            L0010: ax = HasItem(player, 0xD0);
            L001E: if (JumpEqual) goto L0031;
            L0020: PushStack(player, 0x01);
            L0024: PushStack(player, 0x0F);
            L0028: PushStack(player, 0x03);
093B  002C B8 05 00  mov ax, 0x5
            L002F: goto L009E;
            L0031: ax = HasItem(player, 0x9F);
            L003F: if (JumpEqual) goto L0051;
            L0041: PushStack(player, 0x00);
            L0044: PushStack(player, 0x3D);
            L0048: PushStack(player, 0x01);
095B  004C B8 05 00  mov ax, 0x5
            L004F: goto L009E;
            L0051: ax = HasItem(player, 0xC4);
            L005F: if (JumpEqual) goto L0072;
            L0061: PushStack(player, 0x01);
            L0065: PushStack(player, 0xB6);
            L0069: PushStack(player, 0x01);
097C  006D B8 05 00  mov ax, 0x5
            L0070: goto L009E;
            L0072: ax = HasItem(player, 0x9C);
            L0080: if (JumpEqual) goto L008F;
            L0082: PushStack(player, 0x01);
            L0086: PushStack(player, 0x40);
0999  008A B8 03 00  mov ax, 0x3
            L008D: goto L009A;
            L008F: TeleportParty(player, 0x04, 0x01, 0xF1, 0x02, isForwardMove);
            L00AA: return; // RETURN;
        }

        private void FnGOODIEB_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String11C6); // It looks like you're not the only one to discover the thieves' hiding place.
            L0010: ax = HasItem(player, 0x32);
            L001E: if (JumpEqual) goto L0032;
09DB  0020 B8 E8 03  mov ax, 0x3e8
            L0023: PushStack(player, ax);
            L0024: PushStack(player, 0x00);
            L0027: PushStack(player, ax);
            L0028: PushStack(player, ax);
            L0029: PushStack(player, 0x9D);
09E8  002D B8 A0 00  mov ax, 0xa0
            L0030: goto L0045;
09ED  0032 B8 B8 0B  mov ax, 0xbb8
            L0035: PushStack(player, ax);
            L0036: PushStack(player, 0x00);
            L0039: PushStack(player, ax);
            L003A: PushStack(player, 0x9F);
            L003E: PushStack(player, 0xCC);
            L0042: PushStack(player, 0x32);
0A01  0046 C4 5E 06  les bx, [bp+0x6]
0A04  0049 26 FF 9F D8 00  call far word [es:bx+0xd8]
0A09  004E 83 C4 0C  add sp, 0xc
            L0051: Compare(PartyCount(player), 0x0001);
            L005C: if (JumpNotEqual) goto L007A;
            L005E: AddEncounter(player, 0x01, 0x06);
            L0070: PushStack(player, 0x07);
0A2F  0074 B8 02 00  mov ax, 0x2
            L0077: goto L0103;
            L007A: Compare(PartyCount(player), 0x0002);
            L0085: if (JumpNotEqual) goto L00B4;
            L0087: AddEncounter(player, 0x01, 0x04);
            L0099: AddEncounter(player, 0x02, 0x05);
            L00AB: PushStack(player, 0x0D);
0A6A  00AF B8 03 00  mov ax, 0x3
            L00B2: goto L0103;
            L00B4: AddEncounter(player, 0x01, 0x1B);
            L00C6: AddEncounter(player, 0x02, 0x1C);
            L00D8: AddEncounter(player, 0x03, 0x1C);
            L00EA: AddEncounter(player, 0x05, 0x23);
            L00FC: AddEncounter(player, 0x06, 0x24);
            L010E: return; // RETURN;
        }

        private void FnKEYTHF_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0ACE  0003 C4 5E 06  les bx, [bp+0x6]
0AD1  0006 26 FF 9F E8 00  call far word [es:bx+0xe8]
            L000B: Compare(GetGuild(player), 0x0003);
            L0015: if (JumpNotEqual) goto L007E;
            L0017: ax = HasItem(player, 0xD0);
            L0025: if (JumpEqual) goto L002C;
0AF2  0027 B8 6C 09  mov ax, 0x96c
            L002A: goto L0081;
            L002C: Compare(GetFlag(player, 0x02, 0x45), 0x0001);
            L0040: if (JumpNotEqual) goto L0060;
            L0042: GiveItem(player, 0xD0);
            L004E: ShowMessage(player, String1213); // You find a key which may open seemingly impassable doors in your race to finish Queen Aeowyn's Map Quest.
0B26  005B B8 7D 12  mov ax, 0x127d
            L005E: goto L0081;
            L0060: GiveItem(player, 0xD0);
            L006C: ShowMessage(player, String12C1); // Your Guildmaster left you a special key that will give you access to magical armor.
0B44  0079 B8 15 13  mov ax, 0x1315
            L007C: goto L0081;
            L007E: ShowMessage(player, String137A); // The room is bare.
            L008B: return; // RETURN;
        }

        private void FnTELET_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String138C); // Beyond the door lies a twisted maze. To find your way through would be aMAZEing.
            L0010: TeleportParty(player, 0x04, 0x02, 0xF0, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnCLUED_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String13DD); // `Pluthros`
            L0010: ShowMessage(player, String13E8); // Ashakkar is where all who oppose Chaos shall find this Fate.
            L001D: return; // RETURN;
        }

        private void FnCLUEE_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L0020: PushStack(player, 0x00);
            L0023: PushStack(player, 0xBF);
0BCB  0027 C4 5E 06  les bx, [bp+0x6]
0BCE  002A 26 FF 5F 34  call far word [es:bx+0x34]
            L002E: cx = PopStack(player);
            L002F: cx = PopStack(player);
            L0030: ShowMessage(player, String1425); // Carved in the base you see the name `Lord Zzuf`
            L003D: ShowMessage(player, String1455); // This work of art, however is unfinished; perhaps later you can come back and see it completed.
            L004A: Compare(GetFlag(player, 0x02, 0x56), 0x0001);
            L005E: if (JumpNotEqual) goto L00BF;
            L0060: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L007E: SetFloorPassable(player, 0xBF, 0x01);
            L008F: SetWallObject(player, 0x02, 0xBF, 0x02);
            L00A5: ShowMessage(player, String14B4); // Your quest bag shifts and hits the statue of Lord Zzuf, causing the great explorer's icon to move slightly.
            L00B2: ShowMessage(player, String1520); // You push the statue's base and find enough room for a person to squeeze through.
            L00BF: return; // RETURN;
        }

        private void FnCLUEF_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1571); // `Juvalad`
            L0010: ShowMessage(player, String157B); // Enakkar is where all who oppose Harmony shall find this Fate.
            L001D: return; // RETURN;
        }

        private void FnCLUEG_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String15B9); // `Malos`
            L0010: ShowMessage(player, String15C1); // En-Li-Kil's master, and guardian to the Elementals.
            L001D: return; // RETURN;
        }

        private void FnCLUEH_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String15F5); // `Crysillus Draco and Sayvut d'Oi Vey`
            L0010: ShowMessage(player, String161B); // These were the great engineers who built the shrines to the Fates those many moons ago.
            L001D: return; // RETURN;
        }

        private void FnNOENT_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1673); // 'Enter at your own risk!'
            L0010: return; // RETURN;
        }

        private void FnEMLOCK_36(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xDB);
            L0011: if (JumpEqual) goto L002E;
0CE7  0013 B8 E8 03  mov ax, 0x3e8
            L0016: PushStack(player, ax);
            L0017: PushStack(player, 0x00);
            L001A: PushStack(player, ax);
            L001B: PushStack(player, ax);
            L001C: PushStack(player, ax);
            L001D: PushStack(player, 0xC2);
0CF5  0021 C4 5E 06  les bx, [bp+0x6]
0CF8  0024 26 FF 9F D8 00  call far word [es:bx+0xd8]
0CFD  0029 83 C4 0C  add sp, 0xc
            L002C: goto L005A;
0D02  002E B8 B8 0B  mov ax, 0xbb8
            L0031: PushStack(player, ax);
            L0032: PushStack(player, 0x00);
            L0035: PushStack(player, ax);
            L0036: PushStack(player, 0xB6);
            L003A: PushStack(player, 0xC2);
            L003E: PushStack(player, 0xDB);
0D16  0042 C4 5E 06  les bx, [bp+0x6]
0D19  0045 26 FF 9F D8 00  call far word [es:bx+0xd8]
0D1E  004A 83 C4 0C  add sp, 0xc
            L004D: ShowMessage(player, String168D); // You see something green on the ground - and something nasty charging at you.
            L005A: Compare(PartyCount(player), 0x0001);
            L0065: if (JumpNotEqual) goto L0071;
            L0067: PushStack(player, 0x16);
0D3F  006B B8 01 00  mov ax, 0x1
            L006E: goto L00FA;
            L0071: Compare(PartyCount(player), 0x0002);
            L007C: if (JumpNotEqual) goto L00AB;
            L007E: AddEncounter(player, 0x01, 0x14);
            L0090: AddEncounter(player, 0x02, 0x14);
            L00A2: PushStack(player, 0x17);
0D7A  00A6 B8 05 00  mov ax, 0x5
            L00A9: goto L00FA;
            L00AB: AddEncounter(player, 0x01, 0x14);
            L00BD: AddEncounter(player, 0x02, 0x14);
            L00CF: AddEncounter(player, 0x03, 0x16);
            L00E1: AddEncounter(player, 0x05, 0x17);
            L00F3: AddEncounter(player, 0x06, 0x22);
            L0105: return; // RETURN;
        }

        private void FnSECCLE_37(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0004);
            L000D: if (JumpNotEqual) goto L0036;
            L000F: ShowMessage(player, String16DA); // A sign on the door - 'CLERICS ONLY.'
            L001C: XCall Fn086B
            L0027: cx = PopStack(player);
            L0028: cx = PopStack(player);
            L0029: XCall Fn0826
            L0034: goto L0041;
            L0036: XCall Fn0849
            L0041: cx = PopStack(player);
            L0042: cx = PopStack(player);
            L0043: return; // RETURN;
        }

        private void FnKEYCLE_38(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetGuild(player), 0x0004);
            L000D: if (JumpNotEqual) goto L0076;
            L000F: ax = HasItem(player, 0xD0);
            L001D: if (JumpEqual) goto L0024;
0E3F  001F B8 6C 09  mov ax, 0x96c
            L0022: goto L0079;
            L0024: Compare(GetFlag(player, 0x02, 0x45), 0x0001);
            L0038: if (JumpNotEqual) goto L0058;
            L003A: GiveItem(player, 0xD0);
            L0046: ShowMessage(player, String1213); // You find a key which may open seemingly impassable doors in your race to finish Queen Aeowyn's Map Quest.
0E73  0053 B8 7D 12  mov ax, 0x127d
            L0056: goto L0079;
            L0058: GiveItem(player, 0xD0);
            L0064: ShowMessage(player, String12C1); // Your Guildmaster left you a special key that will give you access to magical armor.
0E91  0071 B8 15 13  mov ax, 0x1315
            L0074: goto L0079;
            L0076: ShowMessage(player, String137A); // The room is bare.
            L0083: return; // RETURN;
        }

        private void FnCLUEI_39(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String16FF); // `Astelligus`
            L0010: ShowMessage(player, String170C); // The blackest pitch cannot compare to this Fate's home.
            L001D: return; // RETURN;
        }

        private void FnCLUEJ_3A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x45));
            L0016: if (JumpNotEqual) goto L0059;
            L0018: ShowPortrait(player, 0x001A);
            L0025: ShowMessage(player, String1743); // An Orc Knight is frantically searching the ground.
            L0032: ShowMessage(player, String1776); // 'All I need to get into the secret armory rooms is that blasted Skeleton Key I dropped somewhere back here!
            L003F: ShowMessage(player, String17E2); // Of course, one needs more than that, as you well know!'
            L004C: ShowMessage(player, String181A); // The Knight dashes off before you can say anything.
            L0059: return; // RETURN;
        }

        private void FnTELEU_3B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String184D); // Be sure of your footing when you scale the heights of Cliffhanger.
            L0010: TeleportParty(player, 0x04, 0x01, 0x22, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnNEWTP_3C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0F4F  0003 C4 5E 06  les bx, [bp+0x6]
0F52  0006 26 FF 9F E8 00  call far word [es:bx+0xe8]
            L000B: ShowMessage(player, String1890); // Magical forces swirl about you, where you might end up you have no clue.
            L0018: ax = HasItem(player, 0xD3);
            L0026: if (JumpEqual) goto L0038;
            L0028: PushStack(player, 0x01);
            L002C: PushStack(player, 0x00);
            L002F: PushStack(player, 0x01);
0F7F  0033 B8 06 00  mov ax, 0x6
            L0036: goto L00A1;
            L0038: ax = HasItem(player, 0xDE);
            L0046: if (JumpEqual) goto L0059;
            L0048: PushStack(player, 0x01);
            L004C: PushStack(player, 0xE4);
            L0050: PushStack(player, 0x02);
0FA0  0054 B8 04 00  mov ax, 0x4
            L0057: goto L00A1;
            L0059: ax = HasItem(player, 0xB0);
            L0067: if (JumpEqual) goto L007A;
            L0069: PushStack(player, 0x01);
            L006D: PushStack(player, 0x3A);
            L0071: PushStack(player, 0x01);
0FC1  0075 B8 04 00  mov ax, 0x4
            L0078: goto L00A1;
            L007A: ax = HasItem(player, 0x65);
            L0088: if (JumpEqual) goto L0093;
            L008A: PushStack(player, 0x01);
0FDA  008E B8 CB 00  mov ax, 0xcb
            L0091: goto L0099;
            L0093: TeleportParty(player, 0x05, 0x01, 0x00, 0x33, isForwardMove);
            L00AD: return; // RETURN;
        }

        private void FnPTYTPT_3D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002F;
            L0010: SetWallObject(player, 0x02, GetCurrentTile(player), 0x02);
1025  002A B8 D9 18  mov ax, 0x18d9
            L002D: goto L004C;
            L002F: TeleportParty(player, 0x05, 0x01, 0xCF, 0x00, isForwardMove);
            L0049: ShowMessage(player, String1910); // The space is too narrow for more than one person to squeeze through.
            L0056: return; // RETURN;
        }

        private void FnCLUEK_3E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1955); // `Corpeus`
            L0010: ShowMessage(player, String195F); // This Fate welcomes all to sample his wisdom; or die from his wrath.
            L001D: return; // RETURN;
        }

        private void FnMEDA_3F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L0029;
            L0010: PushStack(player, 0x01);
            L0014: PushStack(player, ax);
1087  0015 C4 5E 06  les bx, [bp+0x6]
108A  0018 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L001D: cx = PopStack(player);
            L001E: cx = PopStack(player);
            L001F: PushStack(player, 0x03);
1095  0023 B8 02 00  mov ax, 0x2
            L0026: goto L00AF;
            L0029: Compare(PartyCount(player), 0x0002);
            L0034: if (JumpNotEqual) goto L0060;
            L0036: PushStack(player, 0x01);
            L003A: PushStack(player, ax);
10AD  003B C4 5E 06  les bx, [bp+0x6]
10B0  003E 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0043: cx = PopStack(player);
            L0044: cx = PopStack(player);
            L0045: AddEncounter(player, 0x02, 0x03);
            L0057: PushStack(player, 0x19);
10CD  005B B8 05 00  mov ax, 0x5
            L005E: goto L00AF;
            L0060: AddEncounter(player, 0x01, 0x03);
            L0072: AddEncounter(player, 0x02, 0x03);
            L0084: AddEncounter(player, 0x03, 0x01);
            L0096: AddEncounter(player, 0x05, 0x1A);
            L00A8: AddEncounter(player, 0x06, 0x1A);
            L00BA: return; // RETURN;
        }

        private void FnHRD_40(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x06);
            L0022: PushStack(player, 0x05);
1154  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00B1;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0062;
            L0039: AddEncounter(player, 0x01, 0x1C);
            L004B: AddEncounter(player, 0x02, 0x1D);
118B  005D B8 09 00  mov ax, 0x9
            L0060: goto L00AD;
            L0062: AddEncounter(player, 0x01, 0x0A);
            L0074: AddEncounter(player, 0x02, 0x0A);
            L0086: AddEncounter(player, 0x03, 0x0B);
            L0098: AddEncounter(player, 0x05, 0x1C);
            L00AA: AddEncounter(player, 0x06, 0x1D);
            L00BC: return; // RETURN;
        }

        private void FnMEDB_41(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x11);
            L0022: PushStack(player, 0x26);
1212  0026 B8 02 00  mov ax, 0x2
            L0029: goto L00C7;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0078;
            L0039: AddEncounter(player, 0x01, 0x11);
            L004B: AddEncounter(player, 0x02, 0x11);
            L005D: AddEncounter(player, 0x03, 0x12);
            L006F: PushStack(player, 0x27);
125F  0073 B8 04 00  mov ax, 0x4
            L0076: goto L00C7;
            L0078: AddEncounter(player, 0x01, 0x11);
            L008A: AddEncounter(player, 0x02, 0x11);
            L009C: AddEncounter(player, 0x03, 0x13);
            L00AE: AddEncounter(player, 0x04, 0x13);
            L00C0: AddEncounter(player, 0x06, 0x27);
            L00D2: return; // RETURN;
        }

        private void FnMEDC_42(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L001A;
            L0010: PushStack(player, 0x27);
12D4  0014 B8 01 00  mov ax, 0x1
            L0017: goto L00A3;
            L001A: Compare(PartyCount(player), 0x0002);
            L0025: if (JumpNotEqual) goto L0054;
            L0027: AddEncounter(player, 0x01, 0x11);
            L0039: AddEncounter(player, 0x02, 0x12);
            L004B: PushStack(player, 0x23);
130F  004F B8 05 00  mov ax, 0x5
            L0052: goto L00A3;
            L0054: AddEncounter(player, 0x01, 0x25);
            L0066: AddEncounter(player, 0x02, 0x25);
            L0078: AddEncounter(player, 0x03, 0x27);
            L008A: AddEncounter(player, 0x04, 0x27);
            L009C: AddEncounter(player, 0x06, 0x26);
            L00AE: return; // RETURN;
        }

        private void FnMEDD_43(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L001A;
            L0010: PushStack(player, 0x0E);
1384  0014 B8 01 00  mov ax, 0x1
            L0017: goto L009F;
            L001A: Compare(PartyCount(player), 0x0002);
            L0025: if (JumpNotEqual) goto L0050;
            L0027: AddEncounter(player, 0x01, 0x0D);
            L0039: AddEncounter(player, 0x02, 0x0F);
13BB  004B B8 11 00  mov ax, 0x11
            L004E: goto L009B;
            L0050: AddEncounter(player, 0x01, 0x21);
            L0062: AddEncounter(player, 0x02, 0x21);
            L0074: AddEncounter(player, 0x04, 0x23);
            L0086: AddEncounter(player, 0x05, 0x24);
            L0098: AddEncounter(player, 0x06, 0x28);
            L00AA: return; // RETURN;
        }

        private void FnMEDE_44(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L001A;
            L0010: PushStack(player, 0x0A);
1430  0014 B8 01 00  mov ax, 0x1
            L0017: goto L00A3;
            L001A: Compare(PartyCount(player), 0x0002);
            L0025: if (JumpNotEqual) goto L0054;
            L0027: AddEncounter(player, 0x01, 0x09);
            L0039: AddEncounter(player, 0x02, 0x0A);
            L004B: PushStack(player, 0x1F);
146B  004F B8 04 00  mov ax, 0x4
            L0052: goto L00A3;
            L0054: AddEncounter(player, 0x01, 0x0A);
            L0066: AddEncounter(player, 0x02, 0x0A);
            L0078: AddEncounter(player, 0x04, 0x0B);
            L008A: AddEncounter(player, 0x05, 0x1E);
            L009C: AddEncounter(player, 0x06, 0x20);
            L00AE: return; // RETURN;
        }

        private void FnEZ_45(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L002C;
            L0010: AddEncounter(player, 0x01, 0x05);
            L0022: PushStack(player, 0x06);
14F2  0026 B8 05 00  mov ax, 0x5
            L0029: goto L00B1;
            L002C: Compare(PartyCount(player), 0x0002);
            L0037: if (JumpNotEqual) goto L0062;
            L0039: AddEncounter(player, 0x01, 0x06);
            L004B: AddEncounter(player, 0x02, 0x06);
1529  005D B8 13 00  mov ax, 0x13
            L0060: goto L0025;
            L0062: AddEncounter(player, 0x01, 0x06);
            L0074: AddEncounter(player, 0x02, 0x06);
            L0086: AddEncounter(player, 0x03, 0x08);
            L0098: AddEncounter(player, 0x05, 0x13);
            L00AA: AddEncounter(player, 0x06, 0x13);
            L00BC: return; // RETURN;
        }

        private void FnTPBALL_46(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallObject(player, 0x02, GetCurrentTile(player), GetFacing(player));
            L0021: TeleportParty(player, 0x04, 0x01, 0xB9, 0x01, isForwardMove);
            L003C: return; // RETURN;
            // Extra data: 55 8B EC C4 5E 06 26 FF 5F 74 50 C4 5E 06 26 FF 9F 90 00 59 5D CB 55 8B EC C4 5E 06 26 FF 5F 74 50 C4 5E 06 26 FF 9F 94 00 59 B8 10 27 50 C4 5E 06 26 FF 9F B4 00 59 5D CB 55 8B EC B8 01 00 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 55 8B EC 33 C0 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 55 8B EC C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 B8 01 00 50 C4 5E 06 26 FF 5F 30 83 C4 06 5D CB 55 8B EC B8 42 00 50 C4 5E 06 26 FF 9F FC 00 59 5D CB 
        }

        private void FnLOCKTXT_47(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xDB);
            L0011: if (JumpEqual) goto L003F;
            L0013: ShowPortrait(player, 0x0024);
            L0020: ShowMessage(player, String19A3); // 'Lockpicks for sale!! Lockpicks for sale!!
            L002D: ShowMessage(player, String19CE); // Can I sell you a lockpick, brave champion? I see you have one, beautiful too. Care to sell it?
16B5  003A B8 2D 1A  mov ax, 0x1a2d
            L003D: goto L004F;
            L003F: ShowPortrait(player, 0x0024);
            L004C: ShowMessage(player, String1A9B); // 'Brave Warrior! Are you in search of the Emerald Lockpick, too? I must find it and get to Tipekans!'
            L0059: return; // RETURN;
        }

    }
}
