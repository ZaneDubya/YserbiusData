#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Twinion.Maps {
    class TwMap31 : AMapScripted {
        protected override int MapIndex => 31;
        protected override int RandomEncounterChance => 30;
        protected override int RandomEncounterExtraCount => 2;

        public TwMap31() {
            MapEvent01 = FnLOCKDOOR_01;
            MapEvent02 = FnARES_02;
            MapEvent03 = FnTOEOS_03;
            MapEvent04 = FnNEPTS_04;
            MapEvent05 = FnCMONDOOR_05;
            MapEvent06 = FnTOGAEAS_06;
            MapEvent07 = FnGIVEITEM_07;
            MapEvent08 = FnTOKEEPER_08;
            MapEvent0A = FnTOMAPA_0A;
            MapEvent0B = FnAEOWYN_0B;
            MapEvent0C = FnFAKEDOOR_0C;
            MapEvent0D = FnCASETRAP_0D;
            MapEvent0E = FnREWARD_0E;
            MapEvent0F = Fn_0F;
            MapEvent10 = FnNOJOIN_10;
            MapEvent12 = FnSTORMGIN_12;
            MapEvent15 = FnROTATONE_15;
            MapEvent16 = FnROTATTWO_16;
            MapEvent17 = FnBATCHECK_17;
            MapEvent19 = FnKEEPER_19;
            MapEvent1A = FnBLOCKFLR_1A;
            MapEvent1F = FnEOSBAT_1F;
            MapEvent20 = FnGAESBAT_20;
            MapEvent21 = FnNEPTSBAT_21;
            MapEvent22 = FnARESBAT_22;
            MapEvent23 = FnSTATESET_23;
            MapEvent24 = FnGURDONE_24;
            MapEvent25 = FnLOOKOUT_25;
            MapEvent26 = FnGURDTWO_26;
            MapEvent27 = FnUSETRIDN_27;
            MapEvent28 = FnUSETRIDN_28;
            MapEvent29 = FnGURDTHRE_29;
            MapEvent2A = FnGURDFOUR_2A;
            MapEvent2B = FnGRDFIVE_2B;
            MapEvent2C = FnUSEDFLAL_2C;
            MapEvent2D = FnFLALPIT_2D;
            MapEvent2E = Fn_2E;
            MapEvent32 = FnSTARTPRT_32;
            MapEvent33 = FnTOCNTER_33;
            MapEvent34 = FnCRYSINFO_34;
            MapEvent35 = FnTOSWOFCN_35;
            MapEvent36 = FnNOMAPS_36;
            MapEvent37 = FnENDTELE_37;
            MapEvent3C = Fn_3C;
        }
        
        // === Strings ================================================
        private const string String03FC = "Each of these four portals offers the passer-by an exotic weapon from a past visitor to this domain.";
        private const string String0461 = "You cannot enter here, you already have one of the weapons of the Gods.";
        private const string String04A9 = "Enter, and claim one of the four artifacts for your reward. You may only have one!";
        private const string String04FC = "Arm yourself with whichever artifact you choose before you challenge she who threatens the Gateway's existence.";
        private const string String056C = "Be off!! Only one Hero may enter here at a time!";
        private const string String059D = "WARNING: This will only take you back to the Keepers room. You must retrace your steps or take a different path to proceed from there.";
        private const string String0624 = "Pure Dissemination lies through this portal.";
        private const string String0651 = "Before you, now mad with power and muttering spells upon spells, hovers Aeowyn. Using the Rings of Fate, she is trying to manipulate the Gateway of Immortality. Shaping its destination and purpose.";
        private const string String0717 = "She scorns you as you approach, 'FOOL! MORTAL! You were so easily subdued; so quick to crave the power I offered; you lost sight of yourself and succumbed to my desires.";
        private const string String07C1 = "You shall learn the price of your ignorance! For only now, at the end do you understand. Had you kept the rings, had you breached the seal alone, then you may have had this power. But now, I WILL DESTROY YOU!'";
        private const string String0893 = "Aeowyn conjures four guardsmen to her aid, as well as summoning from their entombment, the five Dralkarians...";
        private const string String0902 = "Guardians of the Gateway are summoned to its defense as you attempt to gain access to its secrets.";
        private const string String0965 = "An illusionary door fades away as you approach.";
        private const string String0995 = "Evil winds rip through you, mauling you horribly.";
        private const string String09C7 = "Poisoned gas strangles you as it dissipates.";
        private const string String09F4 = "A flash of magical light blinds you temporarily; causing you damage.";
        private const string String0A39 = "Mystical currents from an ancient snare steal from and damage you.";
        private const string String0A7C = "A blast of fire greets you at this next snare.";
        private const string String0AAB = "Evil laughter echoes off the walls as yet another snare harms you.";
        private const string String0AEE = "You've defeated the Queen; preventing the her from threatening all the Portals that interconnect throughout this world and others.";
        private const string String0B71 = "Now, take these boosts to your attributes and to your wealths of knowledge and gold. You have restored the system to its rightful balance.";
        private const string String0BFC = "In time, when you are ready, the portal will grant you access to new planes of existence! But that, is another story...";
        private const string String0C74 = "You are bestowed with a new spell!";
        private const string String0C97 = "Mighty sorcerer, gain knowledge to control life from death.";
        private const string String0CD3 = "The portal glows with power. You may enter it now, but it will not take you to your true destination yet.";
        private const string String0D3D = "The future has taken root in the present. All will be explained... with Yserbius III!!%%";
        private const string String0D96 = "Here you must go, but only after you've retrieved one of the mystic artifacts that travelers of this portal have left as gifts.";
        private const string String0E16 = "An ominous force stands before you!";
        private const string String0E3A = "Using one of the mystical statues, you turn into a Storm Giant and kill them all!";
        private const string String0E8C = "Had you been alone and with their talisman, you may have stood a chance!";
        private const string String0ED5 = "Those who hath not faced the mad Queen must lead, lest your efforts are futile. You are one that may lead!";
        private const string String0F40 = "You have already defeated the Queen, you cannot face that which is no more.";
        private const string String0F8C = "Step forth ALONE!";
        private const string String0F9E = "The statue of an ancient guardian greets you here. It writhes to life as you approach: 'Hail to thee! I am Chrysagorn, Keeper of the Portal and Servant to the Fates.";
        private const string String1044 = "I have been imprisoned here in granite by the mad Queen! Her powers are farther reaching than you dare imagine. With the five rings, she is now trying to gain control of the Gateway.";
        private const string String10FB = "I cannot defend the Gate from her powers, you must destroy her or all of time shall fold in upon itself. Our fate will be sealed in oblivion's tomb.'";
        private const string String1191 = "The statue begins to crumble as you watch, 'Go! defeat her! I can no longer protect...' but its too late, the statue explodes into dust flying across the room and damaging you.";
        private const string String1242 = "Eos' servants form from the morning mists which permeate this place.";
        private const string String1287 = "Descendents of Gaea rise from the earthen floor to challenge you!";
        private const string String12C9 = "Ancient servants of Neptune rise from the waters and bar your way!";
        private const string String130C = "Masters of Warfare, students of Ares, ambush you!";
        private const string String133E = "This enormous hallway is adorned with precious jewels and artworks in every crevice. Golden statues in the images of greater deities and gods who hath passed this way line either side of the hall.";
        private const string String1403 = "A challenge of outrageous proportions guards this passageway before you. Northward, two rows of beasts and man stand as guardians to the ultimate Gateway.";
        private const string String149E = "The lava before you swirls into a wading pool! Neptune himself has used such power to bypass these foul snares.";
        private const string String150E = "The lava hardens into solid rock! Gaea herself has used such powers to pass safely by such traps!";
        private const string String1570 = "Dawn's light shines bright upon the bow forming a golden arch across the lava!";
        private const string String15BF = "The sword summons a powerful Ice Elemental! The elemental sinks into the lava, quenching the raging war between fire and ice!";
        private const string String163D = "The lava resumes its form.";
        private const string String1658 = "A vile pool of molten lava bubbles violently before you. You must find a way to alter this pool of sure death.";
        private const string String16C7 = "The magic sustains the pool, allowing you to safely pass.";
        private const string String1701 = "The lava scorches and torments your body. The magical fluids then hurl you across the maze...";
        private const string String175F = "The pit before you congeals into a solid earthen floor! Gaea's power is obvious concerning the nature of things.";
        private const string String17D0 = "The pit remains open.";
        private const string String17E6 = "An eerie black pit stretches deep into the earth here. Echoes of your every sound are barely audible whispers by the time they return.";
        private const string String186D = "The flail keeps the earth intact, allowing you to safely pass.";
        private const string String18AC = "The pit swallows you whole, this magical snare does not kill you, however, but you are swept away through the maze.";
        private const string String1920 = "An ancient portal carved of pure magic and wrought with precious gemstones stands guard here.";
        private const string String197E = "The ancient crystals merge into a teleport, allowing you to gain quick access to the Gateway's heart.";
        private const string String19E4 = "Here you will enter the ancient Gods' treasure room.";
        private const string String1A19 = "From here you enter the heart of The Gateway.";
        private const string String1A47 = "You pick up an odd statue. Perhaps it will protect you when you are alone.";
        private const string String1A92 = "A jeweled carving depicts a band of travelers journeying through an ancient dungeon in search of some great treasure.";
        private const string String1B08 = "This carving shows four ancient fragments brought unto themselves, forming some magical piece that allows access into a dark kingdom.";
        private const string String1B8E = "Here you see a myriad of images strewn across various puzzles and hordes of vile creatures that scorn the travelers as they seek the treasure.";
        private const string String1C1D = "Emblazoned in the stones you see your own image slaying the mad Queen and eventually entering the mystical Gateway of Immortality.";
        private const string String1CA0 = "Shadowy, incoherent images flash across the stones as though some part of future history is yet to be completed.";
        private const string String1D11 = "To the last pathway of challenge. From there you will ultimately meet your Fate.";
        private const string String1D62 = "An eerie, shimmering portal hangs before you. This is the Gateway...the ingress into new adventures and future history.";
        private const string String1DDA = "You will come back here in time, when you feel you are ready for new challenges and greater travels. Until then, you must rest and restore your drained powers for that day.";
        private const string String1E87 = "There is a place, guarded by Shaddax, the Keeper, you must journey there and unravel the riddles placed in your path by some vile deity that inhabits another dimension.";
        private const string String1F30 = "That is your task for now, you may return here when time dictates! Go now, seek Shaddax...you may find the entrance through Dragon's Ire! Go, brave champion!";
        private const string String1FCE = "The portal is here; but the future is not yours to see...yet.";
        private const string String200C = "This portal will offer you no advancement without the proper artifact.";
        private const string String2053 = "Through here you begin the final assault.";
        private const string String207D = "Ares had visited this place many moons ago. As his mark, he left behind a legend that clever Night Elf craftsmen emblazoned with ancient runes upon this jeweled blade.";
        private const string String2125 = "Lord Neptune, Master of the Wind and the Sea, used this Trident to command the waters that now surround Twinion to swirl into fury; crashing down upon his enemies. Its power is now yours to borrow.";
        private const string String21EB = "Gaea had exhausted herself in many travels, but her pleasures here have always been her favorite. She filled herself with energies and moved on to a new adventure via the Portal.";
        private const string String229E = "Her flail now remains as her mark, and is offered to you to defend the Portal from abuse.";
        private const string String22F8 = "Dawn shall come! Eos brings the sun, and the first arch of gold was wrought into this magnificent bow in honor of this goddess.";
        private const string String2378 = "Now the Bow of Eos, shall be your light and guide past the snares that await you along the paths to the Portal.";
        
        // === Functions ================================================
        private void FnLOCKDOOR_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String03FC); // Each of these four portals offers the passer-by an exotic weapon from a past visitor to this domain.
            L0010: Compare(PartyCount(player), 0x0001);
            L001B: if (JumpNotEqual) goto L008B;
            L001D: ax = HasItem(player, 0xF3);
            L002B: if (JumpNotEqual) goto L005D;
            L002D: ax = HasItem(player, 0xF6);
            L003B: if (JumpNotEqual) goto L005D;
            L003D: ax = HasItem(player, 0xF4);
            L004B: if (JumpNotEqual) goto L005D;
            L004D: ax = HasItem(player, 0xF5);
            L005B: if (JumpEqual) goto L0062;
0065  005D B8 61 04  mov ax, 0x461
            L0060: goto L008E;
            L0062: ShowMessage(player, String04A9); // Enter, and claim one of the four artifacts for your reward. You may only have one!
            L006F: ShowMessage(player, String04FC); // Arm yourself with whichever artifact you choose before you challenge she who threatens the Gateway's existence.
            L007C: XCall Fn15B9
            L0087: cx = PopStack(player);
            L0088: cx = PopStack(player);
            L0089: goto L00B5;
            L008B: ShowMessage(player, String056C); // Be off!! Only one Hero may enter here at a time!
            L0098: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L00B5: return; // RETURN;
        }

        private void FnARES_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF3);
            L0011: if (JumpEqual) goto L003D;
            L0013: XCall Fn14F0
            L001E: cx = PopStack(player);
            L001F: cx = PopStack(player);
            L0020: TeleportParty(player, 0x0C, 0x02, 0x44, 0x03, isForwardMove);
            L003B: goto L0057;
            L003D: XCall Fn14DE
            L0048: cx = PopStack(player);
            L0049: cx = PopStack(player);
            L004A: XCall Fn1502
            L0055: cx = PopStack(player);
            L0056: cx = PopStack(player);
            L0057: return; // RETURN;
        }

        private void FnTOEOS_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF6);
            L0011: if (JumpEqual) goto L003D;
            L0013: XCall Fn1497
            L001E: cx = PopStack(player);
            L001F: cx = PopStack(player);
            L0020: TeleportParty(player, 0x0C, 0x02, 0x40, 0x03, isForwardMove);
            L003B: goto L0057;
            L003D: XCall Fn1485
            L0048: cx = PopStack(player);
            L0049: cx = PopStack(player);
            L004A: XCall Fn14A9
            L0055: cx = PopStack(player);
            L0056: cx = PopStack(player);
            L0057: return; // RETURN;
        }

        private void FnNEPTS_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF5);
            L0011: if (JumpEqual) goto L003D;
            L0013: XCall Fn143E
            L001E: cx = PopStack(player);
            L001F: cx = PopStack(player);
            L0020: TeleportParty(player, 0x0C, 0x02, 0x43, 0x03, isForwardMove);
            L003B: goto L0057;
            L003D: XCall Fn142C
            L0048: cx = PopStack(player);
            L0049: cx = PopStack(player);
            L004A: XCall Fn1450
            L0055: cx = PopStack(player);
            L0056: cx = PopStack(player);
            L0057: return; // RETURN;
        }

        private void FnCMONDOOR_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L0021: XCall Fn13F7
            L002C: cx = PopStack(player);
            L002D: cx = PopStack(player);
            L002E: return; // RETURN;
        }

        private void FnTOGAEAS_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF4);
            L0011: if (JumpEqual) goto L003D;
            L0013: XCall Fn13B5
            L001E: cx = PopStack(player);
            L001F: cx = PopStack(player);
            L0020: TeleportParty(player, 0x0C, 0x02, 0x41, 0x03, isForwardMove);
            L003B: goto L0057;
            L003D: XCall Fn13A3
            L0048: cx = PopStack(player);
            L0049: cx = PopStack(player);
            L004A: XCall Fn13C7
            L0055: cx = PopStack(player);
            L0056: cx = PopStack(player);
            L0057: return; // RETURN;
        }

        private void FnGIVEITEM_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
0258  0005 56     push si
            L0006: ax = GetCurrentTile(player);
0260  000D 89 46 FE  mov [bp-0x2], ax
0263  0010 B9 04 00  mov cx, 0x4
            L0013: bx = 0x02D6;
0269  0016 2E 8B 07  mov ax, [cs:bx]
026C  0019 3B 46 FE  cmp ax, [bp-0x2]
            L001C: if (JumpEqual) goto L0024;
0271  001E 43     inc bx
0272  001F 43     inc bx
0273  0020 E2 F4  loop 0x16
            L0022: goto L0068;
0277  0024 2E FF 67 08  jmp word [cs:bx+0x8]
            L0028: si = 0x00F4;
            L002B: XCall Fn13B5
            L0036: goto L0066;
            L0038: si = 0x00F3;
            L003B: XCall Fn1391
            L0046: goto L0066;
            L0048: si = 0x00F6;
            L004B: XCall Fn13D4
            L0056: goto L0066;
            L0058: si = 0x00F5;
            L005B: XCall Fn13A3
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
02BB  0068 56     push si
02BC  0069 C4 5E 06  les bx, [bp+0x6]
02BF  006C 26 FF 5F 50  call far word [es:bx+0x50]
            L0070: cx = PopStack(player);
            L0071: RefreshCompareFlags(ax);
            L0073: if (JumpNotEqual) goto L007E;
02C8  0075 56     push si
02C9  0076 C4 5E 06  les bx, [bp+0x6]
02CC  0079 26 FF 5F 48  call far word [es:bx+0x48]
            L007D: cx = PopStack(player);
02D1  007E 5E     pop si
            L007F: // restore stack ptr: sp = bp;
            L0081: return; // RETURN;
            // Extra data: CB 00 DD 00 EA 00 FC 00 9B 02 AB 02 8B 02 7B 02 
        }

        private void FnTOKEEPER_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String059D); // WARNING: This will only take you back to the Keepers room. You must retrace your steps or take a different path to proceed from there.
            L0010: TeleportParty(player, 0x0C, 0x02, 0x00, 0x33, isForwardMove);
            L002A: return; // RETURN;
        }

        private void FnTOMAPA_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0624); // Pure Dissemination lies through this portal.
            L0010: TeleportParty(player, 0x0C, 0x01, 0xFF, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void FnAEOWYN_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x05), 0x0001);
            L0017: if (JumpEqual) goto L001C;
            L0019: goto L00E3;
            L001C: ShowMessage(player, String0651); // Before you, now mad with power and muttering spells upon spells, hovers Aeowyn. Using the Rings of Fate, she is trying to manipulate the Gateway of Immortality. Shaping its destination and purpose.
            L0029: ShowMessage(player, String0717); // She scorns you as you approach, 'FOOL! MORTAL! You were so easily subdued; so quick to crave the power I offered; you lost sight of yourself and succumbed to my desires.
            L0036: ShowMessage(player, String07C1); // You shall learn the price of your ignorance! For only now, at the end do you understand. Had you kept the rings, had you breached the seal alone, then you may have had this power. But now, I WILL DESTROY YOU!'
            L0043: ShowMessage(player, String0893); // Aeowyn conjures four guardsmen to her aid, as well as summoning from their entombment, the five Dralkarians...
            L0050: Compare(PartyCount(player), 0x0001);
            L005B: if (JumpEqual) goto L0064;
            L005D: Compare(ax, 0x0002);
            L0060: if (JumpEqual) goto L0064;
            L0062: goto L00A4;
            L0064: AddEncounter(player, 0x01, 0x1E);
            L0076: AddEncounter(player, 0x02, 0x1F);
            L0088: AddEncounter(player, 0x05, 0x27);
            L009A: PushStack(player, 0x28);
03E1  009E B8 06 00  mov ax, 0x6
            L00A1: goto L013F;
            L00A4: AddEncounter(player, 0x01, 0x1E);
            L00B6: AddEncounter(player, 0x02, 0x1F);
            L00C8: AddEncounter(player, 0x03, 0x20);
            L00DA: PushStack(player, 0x21);
0421  00DE B8 04 00  mov ax, 0x4
            L00E1: goto L007D;
            L00E3: ShowMessage(player, String0902); // Guardians of the Gateway are summoned to its defense as you attempt to gain access to its secrets.
            L00F0: AddEncounter(player, 0x01, 0x1E);
            L0102: AddEncounter(player, 0x02, 0x1F);
            L0114: AddEncounter(player, 0x03, 0x20);
            L0126: AddEncounter(player, 0x04, 0x21);
            L0138: AddEncounter(player, 0x05, 0x27);
            L014A: return; // RETURN;
        }

        private void FnFAKEDOOR_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0965); // An illusionary door fades away as you approach.
            L0010: SetWallObject(player, 0x00, GetCurrentTile(player), GetFacing(player));
            L002D: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x00);
            L004A: return; // RETURN;
        }

        private void FnCASETRAP_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = GetFlag(player, 0x03, 0x01);
            L0017: PushStack(player, 0x01);
            L001B: PushStack(player, 0x00);
04F9  001E C4 5E 06  les bx, [bp+0x6]
04FC  0021 26 FF 5F 04  call far word [es:bx+0x4]
            L0025: cx = PopStack(player);
            L0026: cx = PopStack(player);
            L0027: RefreshCompareFlags(ax);
            L0029: if (JumpEqual) goto L002E;
            L002B: goto L01AA;
            L002E: bx = si;
            L0030: bx = bx - 1;
            L0031: Compare(bx, 0x04);
            L0034: if (JumpBelowOrEqual) goto L0039;
            L0036: goto L014F;
            L0039: switch (bx) {
                case 0:
                    goto L0040;
                case 1:
                    goto L0082;
                case 2:
                    goto L00B2;
                case 3:
                    goto L00CE;
                case 4:
                    goto L011C;
            }
            L0040: ax = GetCurrentHits(player);
            L0047: bx = 0x0003;
            L004A: dx = ax % bx; ax = ax / bx;
            L004D: DamagePlayer(player, ax);
            L0057: XCall Fn116B
            L0062: cx = PopStack(player);
            L0063: cx = PopStack(player);
            L0064: XCall Fn1178
            L006F: cx = PopStack(player);
            L0070: cx = PopStack(player);
            L0071: ShowMessage(player, String0995); // Evil winds rip through you, mauling you horribly.
            L007E: si = si + 1;
            L007F: goto L018B;
            L0082: DamagePlayer(player, GetCurrentHits(player) + 0xF830);
            L0096: PushStack(player, 0x64);
            L009A: PushStack(player, 0x0F);
            L009E: PushStack(player, 0x01);
057D  00A2 C4 5E 06  les bx, [bp+0x6]
0580  00A5 26 FF 9F 9C 00  call far word [es:bx+0x9c]
0585  00AA 83 C4 06  add sp, 0x6
0588  00AD B8 C7 09  mov ax, 0x9c7
            L00B0: goto L0074;
            L00B2: ax = GetCurrentHits(player);
            L00B9: bx = 0x0004;
            L00BC: dx = ax % bx; ax = ax / bx;
            L00BF: DamagePlayer(player, ax);
05A4  00C9 B8 F4 09  mov ax, 0x9f4
            L00CC: goto L0074;
05A9  00CE B8 30 F8  mov ax, 0xf830
            L00D1: PushStack(player, ax);
05AD  00D2 C4 5E 06  les bx, [bp+0x6]
05B0  00D5 26 FF 9F B4 00  call far word [es:bx+0xb4]
            L00DA: goto L00E7;
            L00DC: RemoveItem(player, 0xAB);
            L00E8: ax = HasItem(player, 0xAB);
            L00F6: if (JumpNotEqual) goto L00DC;
            L00F8: goto L0106;
            L00FA: RemoveItem(player, 0xAC);
            L0106: ax = HasItem(player, 0xAC);
            L0114: if (JumpNotEqual) goto L00FA;
05F1  0116 B8 39 0A  mov ax, 0xa39
            L0119: goto L0074;
            L011C: ShowMessage(player, String0A7C); // A blast of fire greets you at this next snare.
            L0129: AddMana(player, 0xFF38);
            L0136: ax = GetMaxHits(player);
            L013D: bx = 0x0004;
            L0140: dx = ax % bx; ax = ax / bx;
            L0143: PushStack(player, ax);
061F  0144 C4 5E 06  les bx, [bp+0x6]
0622  0147 26 FF 9F 90 00  call far word [es:bx+0x90]
            L014C: goto L007D;
            L014F: ax = GetCurrentHits(player);
            L0156: bx = 0x0003;
            L0159: dx = ax % bx; ax = ax / bx;
            L015C: DamagePlayer(player, ax);
            L0166: SetNoHealZone(player);
            L016E: si = 0x0001;
            L0171: XCall Fn1178
            L017C: cx = PopStack(player);
            L017D: cx = PopStack(player);
            L017E: ShowMessage(player, String0AAB); // Evil laughter echoes off the walls as yet another snare harms you.
            L018B: SetFlag(player, 0xC4, 0xB8, si);
            L019D: XCall Fn1184
            L01A8: cx = PopStack(player);
            L01A9: cx = PopStack(player);
            L01AA: return; // RETURN (restoring si);
        }

        private void FnREWARD_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0xBF));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L012B;
            L001B: SetFlag(player, 0x02, 0xDF, 0x02);
            L0030: ShowMessage(player, String0AEE); // You've defeated the Queen; preventing the her from threatening all the Portals that interconnect throughout this world and others.
            L003D: ShowMessage(player, String0B71); // Now, take these boosts to your attributes and to your wealths of knowledge and gold. You have restored the system to its rightful balance.
            L004A: ShowMessage(player, String0BFC); // In time, when you are ready, the portal will grant you access to new planes of existence! But that, is another story...
            L0057: SetFlag(player, 0x02, 0xBF, 0x01);
            L006C: SetFlag(player, 0x02, 0x6A, 0x01);
            L0081: AddExperience(player, 0x007270E0);
0725  0093 B8 1E 00  mov ax, 0x1e
0728  0096 BA 80 84  mov dx, 0x8480
            L0099: PushStack(player, ax);
            L009A: PushStack(player, dx);
072D  009B C4 5E 06  les bx, [bp+0x6]
0730  009E 26 FF 9F AC 00  call far word [es:bx+0xac]
            L00A3: cx = PopStack(player);
            L00A4: cx = PopStack(player);
            L00A5: ModifyAttribute(player, 0x00, 0x0003);
            L00B6: ModifyAttribute(player, 0x02, 0x0003);
            L00C8: ModifyAttribute(player, 0x01, 0x0003);
            L00DA: PushStack(player, 0x03);
            L00DE: PushStack(player, ax);
0771  00DF C4 5E 06  les bx, [bp+0x6]
0774  00E2 26 FF 9F A8 00  call far word [es:bx+0xa8]
            L00E7: cx = PopStack(player);
            L00E8: cx = PopStack(player);
            L00E9: Compare(GetGuild(player), 0x0005);
            L00F3: if (JumpEqual) goto L0115;
            L00F5: ShowMessage(player, String0C74); // You are bestowed with a new spell!
            L0102: SetSpellLevel(player, 0x04, 0x06);
            L0113: goto L0145;
            L0115: ShowMessage(player, String0C97); // Mighty sorcerer, gain knowledge to control life from death.
            L0122: PushStack(player, 0x06);
07B8  0126 B8 16 00  mov ax, 0x16
            L0129: goto L0109;
            L012B: ShowMessage(player, String0CD3); // The portal glows with power. You may enter it now, but it will not take you to your true destination yet.
            L0138: ShowMessage(player, String0D3D); // The future has taken root in the present. All will be explained... with Yserbius III!!%%
            L0145: return; // RETURN;
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0D96); // Here you must go, but only after you've retrieved one of the mystic artifacts that travelers of this portal have left as gifts.
            L0010: TeleportParty(player, 0x0C, 0x02, 0xE8, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnNOJOIN_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoJoinArea(player);
            L000B: return; // RETURN;
        }

        private void FnSTORMGIN_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: XCall Fn017C
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: PushStack(player, GetFlag(player, 0x03, 0x12));
            L0023: ax = GetCurrentTile(player);
            L002A: dx = PopStack(player);
0843  002B 3B D0  cmp dx, ax
            L002D: if (JumpNotEqual) goto L0032;
            L002F: goto L016F;
            L0032: Compare(PartyCount(player), 0x0001);
            L003D: if (JumpEqual) goto L0042;
            L003F: goto L00FE;
            L0042: ShowMessage(player, String0E16); // An ominous force stands before you!
            L004F: ax = HasItem(player, 0xF9);
            L005D: if (JumpNotEqual) goto L0062;
            L005F: goto L0156;
            L0062: PushStack(player, 0x03);
            L0066: PushStack(player, ax);
087F  0067 C4 5E 06  les bx, [bp+0x6]
0882  006A 26 FF 5F 04  call far word [es:bx+0x4]
            L006E: cx = PopStack(player);
            L006F: cx = PopStack(player);
            L0070: PushStack(player, ax);
            L0071: ax = GetCurrentTile(player);
            L0078: dx = PopStack(player);
0891  0079 3B D0  cmp dx, ax
            L007B: if (JumpNotEqual) goto L0080;
            L007D: goto L0156;
            L0080: RefreshCompareFlags(GetFlag(player, 0x02, 0xC0));
            L0093: if (JumpEqual) goto L0098;
            L0095: goto L0156;
            L0098: XCall Fn0DA9
            L00A3: cx = PopStack(player);
            L00A4: cx = PopStack(player);
            L00A5: SetFlag(player, 0x02, 0xC0, 0x01);
            L00BA: ShowMessage(player, String0E3A); // Using one of the mystical statues, you turn into a Storm Giant and kill them all!
            L00C7: ModifyGold(player, 0x2710);
            L00D8: GiveItem(player, 0x11);
            L00E4: GiveItem(player, 0xB8);
            L00F0: GiveItem(player, 0xAB);
            L00FC: goto L0140;
            L00FE: PushStack(player, 0x03);
            L0102: PushStack(player, ax);
091B  0103 C4 5E 06  les bx, [bp+0x6]
091E  0106 26 FF 5F 04  call far word [es:bx+0x4]
            L010A: cx = PopStack(player);
            L010B: cx = PopStack(player);
            L010C: PushStack(player, ax);
            L010D: ax = GetCurrentTile(player);
            L0114: dx = PopStack(player);
092D  0115 3B D0  cmp dx, ax
            L0117: if (JumpEqual) goto L0156;
            L0119: ShowMessage(player, String0E8C); // Had you been alone and with their talisman, you may have stood a chance!
            L0126: si = 0x0001;
            L0129: goto L013B;
            L012B: AddEncounter(player, si, 0x19);
            L013A: si = si + 1;
            L013B: Compare(si, 0x04);
            L013E: if (JumpLessOrEqual) goto L012B;
            L0140: PushStack(player, GetCurrentTile(player));
            L0148: PushStack(player, 0x03);
            L014C: PushStack(player, ax);
0965  014D C4 5E 06  les bx, [bp+0x6]
0968  0150 26 FF 1F  call far word [es:bx]
096B  0153 83 C4 06  add sp, 0x6
            L0156: PushStack(player, GetCurrentTile(player));
            L015E: PushStack(player, 0x12);
            L0162: PushStack(player, 0x03);
097E  0166 C4 5E 06  les bx, [bp+0x6]
0981  0169 26 FF 1F  call far word [es:bx]
0984  016C 83 C4 06  add sp, 0x6
            L016F: return; // RETURN (restoring si);
        }

        private void FnROTATONE_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0997  0003 C4 5E 06  les bx, [bp+0x6]
099A  0006 26 FF 9F E8 00  call far word [es:bx+0xe8]
            L000B: PushStack(player, 0x01);
            L000F: PushStack(player, 0x00);
09A6  0012 C4 5E 06  les bx, [bp+0x6]
09A9  0015 26 FF 5F 04  call far word [es:bx+0x4]
            L0019: cx = PopStack(player);
            L001A: cx = PopStack(player);
            L001B: RefreshCompareFlags(ax);
            L001D: if (JumpNotEqual) goto L0059;
            L001F: bx = GetFacing(player);
            L0028: Compare(bx, 0x03);
            L002B: if (JumpAbove) goto L0059;
            L002D: switch (bx) {
                case 0:
                    goto L003F;
                case 1:
                    goto L0038;
                case 2:
                    goto L003A;
                case 3:
                    goto L0034;
            }
09C8  0034 33 C0  xor ax, ax
            L0036: goto L0042;
            L0038: goto L003F;
09CE  003A B8 01 00  mov ax, 0x1
            L003D: goto L0042;
            L003F: PushStack(player, 0x02);
09D7  0043 C4 5E 06  les bx, [bp+0x6]
09DA  0046 26 FF 9F CC 00  call far word [es:bx+0xcc]
            L004B: cx = PopStack(player);
            L004C: XCall Fn0CCB
            L0057: cx = PopStack(player);
            L0058: cx = PopStack(player);
            L0059: return; // RETURN;
        }

        private void FnROTATTWO_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
09FA  0003 C4 5E 06  les bx, [bp+0x6]
09FD  0006 26 FF 9F E8 00  call far word [es:bx+0xe8]
            L000B: PushStack(player, 0x01);
            L000F: PushStack(player, 0x00);
0A09  0012 C4 5E 06  les bx, [bp+0x6]
0A0C  0015 26 FF 5F 04  call far word [es:bx+0x4]
            L0019: cx = PopStack(player);
            L001A: cx = PopStack(player);
            L001B: RefreshCompareFlags(ax);
            L001D: if (JumpEqual) goto L0022;
            L001F: goto L00A1;
            L0022: bx = GetFacing(player);
            L002B: Compare(bx, 0x03);
            L002E: if (JumpAbove) goto L00A1;
            L0030: switch (bx) {
                case 0:
                    goto L0068;
                case 1:
                    goto L005F;
                case 2:
                    goto L0063;
                case 3:
                    goto L0037;
            }
            L0037: PushStack(player, 0x01);
0A32  003B C4 5E 06  les bx, [bp+0x6]
0A35  003E 26 FF 9F CC 00  call far word [es:bx+0xcc]
            L0043: cx = PopStack(player);
            L0044: PushStack(player, 0x00);
0A3E  0047 C4 5E 06  les bx, [bp+0x6]
0A41  004A 26 FF 9F CC 00  call far word [es:bx+0xcc]
            L004F: cx = PopStack(player);
            L0050: PushStack(player, 0x01);
0A4B  0054 C4 5E 06  les bx, [bp+0x6]
0A4E  0057 26 FF 9F CC 00  call far word [es:bx+0xcc]
            L005C: cx = PopStack(player);
            L005D: goto L0094;
0A56  005F 33 C0  xor ax, ax
            L0061: goto L0053;
0A5A  0063 B8 03 00  mov ax, 0x3
            L0066: goto L0053;
            L0068: PushStack(player, 0x02);
0A63  006C C4 5E 06  les bx, [bp+0x6]
0A66  006F 26 FF 9F CC 00  call far word [es:bx+0xcc]
            L0074: cx = PopStack(player);
            L0075: TeleportParty(player, 0x0C, 0x02, GetCurrentTile(player), 0x02, isForwardMove);
            L0094: XCall Fn0C68
            L009F: cx = PopStack(player);
            L00A0: cx = PopStack(player);
            L00A1: return; // RETURN;
        }

        private void FnBATCHECK_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0AA5  0003 C4 5E 06  les bx, [bp+0x6]
0AA8  0006 26 FF 9F E8 00  call far word [es:bx+0xe8]
            L000B: XCall Fn0BB1
            L0016: cx = PopStack(player);
            L0017: cx = PopStack(player);
            L0018: Compare(PartyCount(player), 0x0001);
            L0023: if (JumpNotEqual) goto L0076;
            L0025: RefreshCompareFlags(GetFlag(player, 0x02, 0xBE));
            L0038: if (JumpNotEqual) goto L0065;
            L003A: ShowMessage(player, String0ED5); // Those who hath not faced the mad Queen must lead, lest your efforts are futile. You are one that may lead!
            L0047: SetFlag(player, 0x03, 0x05, 0x01);
            L005C: PushStack(player, 0x02);
0B02  0060 B8 68 00  mov ax, 0x68
            L0063: goto L008A;
            L0065: ShowMessage(player, String0F40); // You have already defeated the Queen, you cannot face that which is no more.
0B14  0072 33 C0  xor ax, ax
            L0074: goto L004A;
            L0076: ShowMessage(player, String0F8C); // Step forth ALONE!
            L0083: TeleportParty(player, 0x0C, 0x02, 0x77, 0x03, isForwardMove);
            L009E: return; // RETURN;
        }

        private void FnKEEPER_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x04));
            L0016: if (JumpNotEqual) goto L0078;
            L0018: ShowMessage(player, String0F9E); // The statue of an ancient guardian greets you here. It writhes to life as you approach: 'Hail to thee! I am Chrysagorn, Keeper of the Portal and Servant to the Fates.
            L0025: ShowMessage(player, String1044); // I have been imprisoned here in granite by the mad Queen! Her powers are farther reaching than you dare imagine. With the five rings, she is now trying to gain control of the Gateway.
            L0032: ShowMessage(player, String10FB); // I cannot defend the Gate from her powers, you must destroy her or all of time shall fold in upon itself. Our fate will be sealed in oblivion's tomb.'
            L003F: ShowMessage(player, String1191); // The statue begins to crumble as you watch, 'Go! defeat her! I can no longer protect...' but its too late, the statue explodes into dust flying across the room and damaging you.
            L004C: ax = GetCurrentHits(player);
            L0053: bx = 0x0005;
            L0056: dx = ax % bx; ax = ax / bx;
            L0059: DamagePlayer(player, ax);
            L0063: SetFlag(player, 0x03, 0x04, 0x01);
            L0078: return; // RETURN;
        }

        private void FnBLOCKFLR_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFloorPassable(player, 0x00, GetCurrentTile(player));
            L0017: return; // RETURN;
        }

        private void FnEOSBAT_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String1242); // Eos' servants form from the morning mists which permeate this place.
            L0011: si = 0x0001;
            L0014: goto L0026;
            L0016: AddEncounter(player, si, 0x1A);
            L0025: si = si + 1;
            L0026: Compare(si, 0x02);
            L0029: if (JumpLessOrEqual) goto L0016;
            L002B: return; // RETURN (restoring si);
        }

        private void FnGAESBAT_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String1287); // Descendents of Gaea rise from the earthen floor to challenge you!
            L0011: si = 0x0001;
            L0014: goto L0026;
            L0016: AddEncounter(player, si, 0x1D);
            L0025: si = si + 1;
            L0026: Compare(si, 0x02);
            L0029: if (JumpLessOrEqual) goto L0016;
            L002B: return; // RETURN (restoring si);
        }

        private void FnNEPTSBAT_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String12C9); // Ancient servants of Neptune rise from the waters and bar your way!
            L0011: si = 0x0001;
            L0014: goto L0026;
            L0016: AddEncounter(player, si, 0x1B);
            L0025: si = si + 1;
            L0026: Compare(si, 0x02);
            L0029: if (JumpLessOrEqual) goto L0016;
            L002B: return; // RETURN (restoring si);
        }

        private void FnARESBAT_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String130C); // Masters of Warfare, students of Ares, ambush you!
            L0011: si = 0x0001;
            L0014: goto L0026;
            L0016: AddEncounter(player, si, 0x1C);
            L0025: si = si + 1;
            L0026: Compare(si, 0x02);
            L0029: if (JumpLessOrEqual) goto L0016;
            L002B: return; // RETURN (restoring si);
        }

        private void FnSTATESET_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x00);
0CAC  0006 C4 5E 06  les bx, [bp+0x6]
0CAF  0009 26 FF 5F 1C  call far word [es:bx+0x1c]
            L000D: cx = PopStack(player);
            L000E: return; // RETURN;
        }

        private void FnGURDONE_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
0CBA  0004 C4 5E 06  les bx, [bp+0x6]
0CBD  0007 26 FF 5F 10  call far word [es:bx+0x10]
            L000B: PushStack(player, ax);
            L000C: ax = GetCurrentTile(player);
            L0013: dx = PopStack(player);
0CCA  0014 3B D0  cmp dx, ax
            L0016: if (JumpNotEqual) goto L001B;
            L0018: goto L009B;
            L001B: PushStack(player, GetCurrentTile(player));
0CD9  0023 C4 5E 06  les bx, [bp+0x6]
0CDC  0026 26 FF 5F 1C  call far word [es:bx+0x1c]
            L002A: cx = PopStack(player);
            L002B: Compare(PartyCount(player), 0x0001);
            L0036: if (JumpEqual) goto L003F;
            L0038: Compare(ax, 0x0002);
            L003B: if (JumpEqual) goto L0065;
            L003D: goto L0081;
            L003F: AddEncounter(player, 0x01, 0x22);
            L0051: AddEncounter(player, 0x02, 0x22);
            L0063: goto L009B;
            L0065: si = 0x0001;
            L0068: goto L007A;
            L006A: AddEncounter(player, si, 0x22);
            L0079: si = si + 1;
            L007A: Compare(si, 0x03);
            L007D: if (JumpLessOrEqual) goto L006A;
            L007F: goto L009B;
            L0081: si = 0x0001;
            L0084: goto L0096;
            L0086: AddEncounter(player, si, 0x22);
            L0095: si = si + 1;
            L0096: Compare(si, 0x05);
            L0099: if (JumpLessOrEqual) goto L0086;
            L009B: return; // RETURN (restoring si);
        }

        private void FnLOOKOUT_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0xD8));
            L0016: if (JumpNotEqual) goto L002D;
            L0018: SetFlag(player, 0x02, 0xD8, 0x01);
            L002D: ShowMessage(player, String133E); // This enormous hallway is adorned with precious jewels and artworks in every crevice. Golden statues in the images of greater deities and gods who hath passed this way line either side of the hall.
            L003A: ShowMessage(player, String1403); // A challenge of outrageous proportions guards this passageway before you. Northward, two rows of beasts and man stand as guardians to the ultimate Gateway.
            L0047: return; // RETURN;
        }

        private void FnGURDTWO_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
0DA1  0004 C4 5E 06  les bx, [bp+0x6]
0DA4  0007 26 FF 5F 10  call far word [es:bx+0x10]
            L000B: PushStack(player, ax);
            L000C: ax = GetCurrentTile(player);
            L0013: dx = PopStack(player);
0DB1  0014 3B D0  cmp dx, ax
            L0016: if (JumpNotEqual) goto L001B;
            L0018: goto L009B;
            L001B: PushStack(player, GetCurrentTile(player));
0DC0  0023 C4 5E 06  les bx, [bp+0x6]
0DC3  0026 26 FF 5F 1C  call far word [es:bx+0x1c]
            L002A: cx = PopStack(player);
            L002B: Compare(PartyCount(player), 0x0001);
            L0036: if (JumpEqual) goto L003F;
            L0038: Compare(ax, 0x0002);
            L003B: if (JumpEqual) goto L0065;
            L003D: goto L0081;
            L003F: AddEncounter(player, 0x01, 0x23);
            L0051: AddEncounter(player, 0x02, 0x23);
            L0063: goto L009B;
            L0065: si = 0x0001;
            L0068: goto L007A;
            L006A: AddEncounter(player, si, 0x23);
            L0079: si = si + 1;
            L007A: Compare(si, 0x03);
            L007D: if (JumpLessOrEqual) goto L006A;
            L007F: goto L009B;
            L0081: si = 0x0001;
            L0084: goto L0096;
            L0086: AddEncounter(player, si, 0x23);
            L0095: si = si + 1;
            L0096: Compare(si, 0x05);
            L0099: if (JumpLessOrEqual) goto L0086;
            L009B: return; // RETURN (restoring si);
        }

        private void FnUSETRIDN_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0xF5);
            L0007: PushStack(player, ax);
0E43  0008 C4 5E 06  les bx, [bp+0x6]
0E46  000B 26 FF 5F 54  call far word [es:bx+0x54]
            L000F: cx = PopStack(player);
            L0010: cx = PopStack(player);
            L0011: RefreshCompareFlags(ax);
            L0013: if (JumpEqual) goto L0032;
            L0015: ShowMessage(player, String149E); // The lava before you swirls into a wading pool! Neptune himself has used such power to bypass these foul snares.
            L0022: XCall Fn00BE
            L002D: cx = PopStack(player);
            L002E: cx = PopStack(player);
            L002F: goto L00BC;
            L0032: PushStack(player, 0xF4);
            L0036: PushStack(player, ax);
0E72  0037 C4 5E 06  les bx, [bp+0x6]
0E75  003A 26 FF 5F 54  call far word [es:bx+0x54]
            L003E: cx = PopStack(player);
            L003F: cx = PopStack(player);
            L0040: RefreshCompareFlags(ax);
            L0042: if (JumpEqual) goto L0049;
0E7F  0044 B8 0E 15  mov ax, 0x150e
            L0047: goto L0018;
            L0049: PushStack(player, 0xF6);
            L004D: PushStack(player, ax);
0E89  004E C4 5E 06  les bx, [bp+0x6]
0E8C  0051 26 FF 5F 54  call far word [es:bx+0x54]
            L0055: cx = PopStack(player);
            L0056: cx = PopStack(player);
            L0057: RefreshCompareFlags(ax);
            L0059: if (JumpEqual) goto L0060;
0E96  005B B8 70 15  mov ax, 0x1570
            L005E: goto L0018;
            L0060: PushStack(player, 0xF3);
            L0064: PushStack(player, ax);
0EA0  0065 C4 5E 06  les bx, [bp+0x6]
0EA3  0068 26 FF 5F 54  call far word [es:bx+0x54]
            L006C: cx = PopStack(player);
            L006D: cx = PopStack(player);
            L006E: RefreshCompareFlags(ax);
            L0070: if (JumpEqual) goto L0077;
0EAD  0072 B8 BF 15  mov ax, 0x15bf
            L0075: goto L0018;
            L0077: ax = HasUsedItem(player, 0x01, 0xFE);
            L008A: if (JumpEqual) goto L00AF;
            L008C: ShowMessage(player, String163D); // The lava resumes its form.
            L0099: SetFlag(player, 0x03, 0x06, 0x00);
            L00AD: goto L00BC;
            L00AF: ShowMessage(player, String1658); // A vile pool of molten lava bubbles violently before you. You must find a way to alter this pool of sure death.
            L00BC: return; // RETURN;
            // Extra data: 55 8B EC B8 01 00 50 B8 06 00 50 B8 03 00 50 C4 5E 06 26 FF 1F 83 C4 06 C4 5E 06 26 FF 5F 20 3D A0 00 74 07 3D C0 00 74 02 EB 16 B8 01 00 50 B8 B0 00 50 C4 5E 06 26 FF 5F 34 59 59 B8 B0 00 EB 14 B8 01 00 50 B8 55 00 50 C4 5E 06 26 FF 5F 34 59 59 B8 55 00 50 B8 03 00 50 C4 5E 06 26 FF 5F 38 59 59 5D CB 
        }

        private void FnUSETRIDN_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x06), 0x0001);
            L0017: if (JumpNotEqual) goto L0028;
            L0019: ShowMessage(player, String16C7); // The magic sustains the pool, allowing you to safely pass.
            L0026: goto L0064;
            L0028: ShowMessage(player, String1701); // The lava scorches and torments your body. The magical fluids then hurl you across the maze...
            L0035: DamagePlayer(player, GetCurrentHits(player) + 0xFF9C);
            L0049: TeleportParty(player, 0x0C, 0x02, 0xBF, 0x01, isForwardMove);
            L0064: return; // RETURN;
        }

        private void FnGURDTHRE_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
0FC8  0004 C4 5E 06  les bx, [bp+0x6]
0FCB  0007 26 FF 5F 10  call far word [es:bx+0x10]
            L000B: PushStack(player, ax);
            L000C: ax = GetCurrentTile(player);
            L0013: dx = PopStack(player);
0FD8  0014 3B D0  cmp dx, ax
            L0016: if (JumpNotEqual) goto L001B;
            L0018: goto L009B;
            L001B: PushStack(player, GetCurrentTile(player));
0FE7  0023 C4 5E 06  les bx, [bp+0x6]
0FEA  0026 26 FF 5F 1C  call far word [es:bx+0x1c]
            L002A: cx = PopStack(player);
            L002B: Compare(PartyCount(player), 0x0001);
            L0036: if (JumpEqual) goto L003F;
            L0038: Compare(ax, 0x0002);
            L003B: if (JumpEqual) goto L0065;
            L003D: goto L0081;
            L003F: AddEncounter(player, 0x01, 0x24);
            L0051: AddEncounter(player, 0x02, 0x24);
            L0063: goto L009B;
            L0065: si = 0x0001;
            L0068: goto L007A;
            L006A: AddEncounter(player, si, 0x24);
            L0079: si = si + 1;
            L007A: Compare(si, 0x03);
            L007D: if (JumpLessOrEqual) goto L006A;
            L007F: goto L009B;
            L0081: si = 0x0001;
            L0084: goto L0096;
            L0086: AddEncounter(player, si, 0x24);
            L0095: si = si + 1;
            L0096: Compare(si, 0x05);
            L0099: if (JumpLessOrEqual) goto L0086;
            L009B: return; // RETURN (restoring si);
        }

        private void FnGURDFOUR_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
1066  0004 C4 5E 06  les bx, [bp+0x6]
1069  0007 26 FF 5F 10  call far word [es:bx+0x10]
            L000B: PushStack(player, ax);
            L000C: ax = GetCurrentTile(player);
            L0013: dx = PopStack(player);
1076  0014 3B D0  cmp dx, ax
            L0016: if (JumpNotEqual) goto L001B;
            L0018: goto L009B;
            L001B: PushStack(player, GetCurrentTile(player));
1085  0023 C4 5E 06  les bx, [bp+0x6]
1088  0026 26 FF 5F 1C  call far word [es:bx+0x1c]
            L002A: cx = PopStack(player);
            L002B: Compare(PartyCount(player), 0x0001);
            L0036: if (JumpEqual) goto L003F;
            L0038: Compare(ax, 0x0002);
            L003B: if (JumpEqual) goto L0065;
            L003D: goto L0081;
            L003F: AddEncounter(player, 0x01, 0x25);
            L0051: AddEncounter(player, 0x02, 0x25);
            L0063: goto L009B;
            L0065: si = 0x0001;
            L0068: goto L007A;
            L006A: AddEncounter(player, si, 0x25);
            L0079: si = si + 1;
            L007A: Compare(si, 0x03);
            L007D: if (JumpLessOrEqual) goto L006A;
            L007F: goto L009B;
            L0081: si = 0x0001;
            L0084: goto L0096;
            L0086: AddEncounter(player, si, 0x25);
            L0095: si = si + 1;
            L0096: Compare(si, 0x05);
            L0099: if (JumpLessOrEqual) goto L0086;
            L009B: return; // RETURN (restoring si);
        }

        private void FnGRDFIVE_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
1104  0004 C4 5E 06  les bx, [bp+0x6]
1107  0007 26 FF 5F 10  call far word [es:bx+0x10]
            L000B: PushStack(player, ax);
            L000C: ax = GetCurrentTile(player);
            L0013: dx = PopStack(player);
1114  0014 3B D0  cmp dx, ax
            L0016: if (JumpNotEqual) goto L001B;
            L0018: goto L009B;
            L001B: PushStack(player, GetCurrentTile(player));
1123  0023 C4 5E 06  les bx, [bp+0x6]
1126  0026 26 FF 5F 1C  call far word [es:bx+0x1c]
            L002A: cx = PopStack(player);
            L002B: Compare(PartyCount(player), 0x0001);
            L0036: if (JumpEqual) goto L003F;
            L0038: Compare(ax, 0x0002);
            L003B: if (JumpEqual) goto L0065;
            L003D: goto L0081;
            L003F: AddEncounter(player, 0x01, 0x26);
            L0051: AddEncounter(player, 0x02, 0x26);
            L0063: goto L009B;
            L0065: si = 0x0001;
            L0068: goto L007A;
            L006A: AddEncounter(player, si, 0x26);
            L0079: si = si + 1;
            L007A: Compare(si, 0x03);
            L007D: if (JumpLessOrEqual) goto L006A;
            L007F: goto L009B;
            L0081: si = 0x0001;
            L0084: goto L0096;
            L0086: AddEncounter(player, si, 0x26);
            L0095: si = si + 1;
            L0096: Compare(si, 0x05);
            L0099: if (JumpLessOrEqual) goto L0086;
            L009B: return; // RETURN (restoring si);
        }

        private void FnUSEDFLAL_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x08));
            L0016: if (JumpEqual) goto L001B;
            L0018: goto L00CA;
            L001B: PushStack(player, 0xF4);
            L001F: PushStack(player, ax);
11BE  0020 C4 5E 06  les bx, [bp+0x6]
11C1  0023 26 FF 5F 54  call far word [es:bx+0x54]
            L0027: cx = PopStack(player);
            L0028: cx = PopStack(player);
            L0029: RefreshCompareFlags(ax);
            L002B: if (JumpEqual) goto L0085;
            L002D: ShowMessage(player, String175F); // The pit before you congeals into a solid earthen floor! Gaea's power is obvious concerning the nature of things.
            L003A: SetFlag(player, 0x03, 0x07, 0x01);
            L004F: Compare(GetCurrentTile(player), 0x0017);
            L0059: if (JumpEqual) goto L0062;
            L005B: Compare(ax, 0x0037);
            L005E: if (JumpEqual) goto L0062;
            L0060: goto L00CA;
            L0062: SetFloorPassable(player, 0x27, 0x01);
            L0073: SetFloorObject(player, 0x00, 0x27);
            L0083: goto L00CA;
            L0085: ax = HasUsedItem(player, 0x01, 0xFE);
            L0098: if (JumpEqual) goto L00BD;
            L009A: ShowMessage(player, String17D0); // The pit remains open.
            L00A7: SetFlag(player, 0x03, 0x07, 0x00);
            L00BB: goto L00CA;
            L00BD: ShowMessage(player, String17E6); // An eerie black pit stretches deep into the earth here. Echoes of your every sound are barely audible whispers by the time they return.
            L00CA: return; // RETURN;
        }

        private void FnFLALPIT_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x08));
            L0016: if (JumpNotEqual) goto L0079;
            L0018: Compare(GetFlag(player, 0x03, 0x07), 0x0001);
            L002C: if (JumpNotEqual) goto L003D;
            L002E: ShowMessage(player, String186D); // The flail keeps the earth intact, allowing you to safely pass.
            L003B: goto L0079;
            L003D: ShowMessage(player, String18AC); // The pit swallows you whole, this magical snare does not kill you, however, but you are swept away through the maze.
            L004A: DamagePlayer(player, GetCurrentHits(player) + 0xFF9C);
            L005E: TeleportParty(player, 0x0C, 0x02, 0xDE, 0x02, isForwardMove);
            L0079: return; // RETURN;
        }

        private void Fn_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xF4);
            L0011: if (JumpNotEqual) goto L0028;
            L0013: SetFlag(player, 0x03, 0x08, 0x01);
            L0028: return; // RETURN;
        }

        private void FnSTARTPRT_32(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1920); // An ancient portal carved of pure magic and wrought with precious gemstones stands guard here.
            L0010: Compare(PartyCount(player), 0x0001);
            L001B: if (JumpEqual) goto L0020;
            L001D: goto L00B6;
            L0020: Compare(GetFlag(player, 0x02, 0xD8), 0x0001);
            L0034: if (JumpNotEqual) goto L00A0;
            L0036: ax = HasItem(player, 0xF3);
            L0044: if (JumpNotEqual) goto L0076;
            L0046: ax = HasItem(player, 0xF6);
            L0054: if (JumpNotEqual) goto L0076;
            L0056: ax = HasItem(player, 0xF4);
            L0064: if (JumpNotEqual) goto L0076;
            L0066: ax = HasItem(player, 0xF5);
            L0074: if (JumpEqual) goto L00A0;
            L0076: ShowMessage(player, String197E); // The ancient crystals merge into a teleport, allowing you to gain quick access to the Gateway's heart.
            L0083: TeleportParty(player, 0x0C, 0x02, 0xCD, 0x03, isForwardMove);
            L009E: goto L00D0;
            L00A0: ShowMessage(player, String19E4); // Here you will enter the ancient Gods' treasure room.
            L00AD: PushStack(player, 0x01);
13CF  00B1 B8 DB 00  mov ax, 0xdb
            L00B4: goto L008A;
            L00B6: ShowMessage(player, String056C); // Be off!! Only one Hero may enter here at a time!
            L00C3: PushStack(player, 0x02);
13E5  00C7 C4 5E 06  les bx, [bp+0x6]
13E8  00CA 26 FF 9F CC 00  call far word [es:bx+0xcc]
            L00CF: cx = PopStack(player);
            L00D0: return; // RETURN;
        }

        private void FnTOCNTER_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, 0x02, 0xC0, 0x00);
            L0017: ShowMessage(player, String1A19); // From here you enter the heart of The Gateway.
            L0024: TeleportParty(player, 0x0C, 0x02, 0xF6, 0x02, isForwardMove);
            L003F: return; // RETURN;
        }

        private void FnCRYSINFO_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: ax = HasItem(player, 0xF9);
            L0013: if (JumpNotEqual) goto L002E;
            L0015: GiveItem(player, 0xF9);
            L0021: ShowMessage(player, String1A47); // You pick up an odd statue. Perhaps it will protect you when you are alone.
            L002E: ax = GetCurrentTile(player);
1466  0035 89 46 FE  mov [bp-0x2], ax
1469  0038 B9 04 00  mov cx, 0x4
            L003B: bx = 0x14BB;
146F  003E 2E 8B 07  mov ax, [cs:bx]
1472  0041 3B 46 FE  cmp ax, [bp-0x2]
            L0044: if (JumpEqual) goto L004C;
1477  0046 43     inc bx
1478  0047 43     inc bx
1479  0048 E2 F4  loop 0x3e
            L004A: goto L0086;
147D  004C 2E FF 67 08  jmp word [cs:bx+0x8]
1481  0050 B8 92 1A  mov ax, 0x1a92
            L0053: goto L007C;
1486  0055 B8 08 1B  mov ax, 0x1b08
            L0058: goto L007C;
148B  005A B8 8E 1B  mov ax, 0x1b8e
            L005D: goto L007C;
            L005F: ax = IsFlagOn(player, 0x02, 0xBE);
            L0072: if (JumpEqual) goto L0079;
14A5  0074 B8 1D 1C  mov ax, 0x1c1d
            L0077: goto L007C;
            L0079: ShowMessage(player, String1CA0); // Shadowy, incoherent images flash across the stones as though some part of future history is yet to be completed.
            L0086: // restore stack ptr: sp = bp;
            L0088: return; // RETURN;
            // Extra data: BE 00 CE 00 DE 00 EE 00 90 14 8B 14 86 14 81 14 
        }

        private void FnTOSWOFCN_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: TeleportParty(player, 0x0C, 0x02, 0x96, 0x00, isForwardMove);
            L001D: ShowMessage(player, String1D11); // To the last pathway of challenge. From there you will ultimately meet your Fate.
            L002A: return; // RETURN;
        }

        private void FnNOMAPS_36(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
14FA  0003 C4 5E 06  les bx, [bp+0x6]
14FD  0006 26 FF 9F E8 00  call far word [es:bx+0xe8]
            L000B: return; // RETURN;
        }

        private void FnENDTELE_37(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x20));
            L0016: if (JumpNotEqual) goto L0059;
            L0018: SetFlag(player, 0x02, 0x20, 0x01);
            L002D: ShowMessage(player, String1D62); // An eerie, shimmering portal hangs before you. This is the Gateway...the ingress into new adventures and future history.
            L003A: ShowMessage(player, String1DDA); // You will come back here in time, when you feel you are ready for new challenges and greater travels. Until then, you must rest and restore your drained powers for that day.
            L0047: ShowMessage(player, String1E87); // There is a place, guarded by Shaddax, the Keeper, you must journey there and unravel the riddles placed in your path by some vile deity that inhabits another dimension.
1558  0054 B8 30 1F  mov ax, 0x1f30
            L0057: goto L005C;
            L0059: ShowMessage(player, String1FCE); // The portal is here; but the future is not yours to see...yet.
            L0066: PushStack(player, 0x01);
            L006A: PushStack(player, 0x03);
            L006E: PushStack(player, 0x01);
            L0072: PushStack(player, ax);
1577  0073 C4 5E 06  les bx, [bp+0x6]
157A  0076 26 FF 9F BC 00  call far word [es:bx+0xbc]
157F  007B 83 C4 08  add sp, 0x8
            L007E: return; // RETURN;
        }

        private void Fn_3C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: return; // RETURN;
            // Extra data: 55 8B EC B8 0C 20 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC B8 53 20 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC B8 01 00 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 55 8B EC B8 7D 20 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC B8 25 21 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC B8 EB 21 50 C4 5E 06 26 FF 9F F8 00 59 B8 9E 22 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC B8 F8 22 50 C4 5E 06 26 FF 9F F8 00 59 B8 78 23 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC C4 5E 06 26 FF 9F E8 00 5D CB 55 8B EC C4 5E 06 26 FF 5F 40 5D CB 55 8B EC B8 01 00 50 50 33 C0 50 C4 5E 06 26 FF 1F 83 C4 06 5D CB 
        }

    }
}
