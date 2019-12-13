#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Twinion.Maps {
    class TwMap05 : AMapScripted {
        protected override int MapIndex => 5;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public TwMap05() {
            MapEvent01 = FnRIVERREG_01;
            MapEvent02 = FnTOMAPONE_02;
            MapEvent03 = FnMAGICCOL_03;
            MapEvent04 = FnBUBLEPIT_04;
            MapEvent05 = FnDEATHWTR_05;
            MapEvent06 = FnWHIRLONE_06;
            MapEvent07 = FnTELEA_07;
            MapEvent08 = FnTELEB_08;
            MapEvent09 = FnTELEC_09;
            MapEvent0A = FnTOINGRES_0A;
            MapEvent0B = FnSECRETDR_0B;
            MapEvent0C = FnENTRYMES_0C;
            MapEvent0D = FnTELEMESS_0D;
            MapEvent0E = FnQSTCMESS_0E;
            MapEvent0F = FnLOCKDOOR_0F;
            MapEvent10 = FnFLAGDOOR_10;
            MapEvent11 = FnDESCRIP_11;
            MapEvent12 = FnLAKEMESS_12;
            MapEvent13 = FnPMPMESA_13;
            MapEvent14 = FnOTHERMES_14;
            MapEvent15 = FnTOEOGTEL_15;
            MapEvent16 = FnPARTYCNT_16;
            MapEvent17 = FnEOGTELE_17;
            MapEvent18 = FnBOGUSMES_18;
            MapEvent19 = FnREWARD_19;
            MapEvent1A = FnOLDGIANT_1A;
            MapEvent1B = FnWARYPRTY_1B;
            MapEvent1C = FnBATONE_1C;
            MapEvent1D = FnBATTWO_1D;
            MapEvent1E = FnBATTHREE_1E;
            MapEvent1F = FnNPCONEA_1F;
            MapEvent20 = FnBATLB_20;
            MapEvent21 = FnBATLC_21;
            MapEvent22 = FnBATLA_22;
            MapEvent23 = FnNPCTWOC_23;
            MapEvent24 = FnNPCTHREE_24;
            MapEvent25 = FnDONEFLAG_25;
            MapEvent26 = FnKILAM_26;
            MapEvent27 = FnTESTSTAT_27;
            MapEvent28 = FnRIVRWARN_28;
            MapEvent29 = FnPARTTWO_29;
            MapEvent2A = FnWIZFNTN_2A;
            MapEvent2B = FnCLERICFN_2B;
            MapEvent2C = FnKNIGHTFN_2C;
            MapEvent2D = FnPRIEST_2D;
            MapEvent2E = FnBLCKWALL_2E;
            MapEvent2F = FnPICKTHIS_2F;
            MapEvent30 = FnWTRFLOOR_30;
        }
        
        // === Strings ================================================
        private const string String03FC = "The strong currents twist and pound your body.";
        private const string String042B = "You have been drowned by the force.";
        private const string String044F = "You've defeated Aqueus! You may travel safely through these waters.";
        private const string String0493 = "The central Aqueduct lies through the east door.";
        private const string String04C4 = "You have moved the column enough to squeeze by...but now you're not sure that was so wise.";
        private const string String051F = "Churning magic pulls water from below and dumps it here. The thundering noise is painful.";
        private const string String0579 = "You feel you have acted unwisely...and you are proven correct as the force slams you against a very hard southern wall...";
        private const string String05F3 = "And kills you.";
        private const string String0602 = "And wounds you severely.";
        private const string String061B = "Reciting the chant the old giant taught you causes the waters to part and allows you to proceed.";
        private const string String067C = "The powerful currents here dash you repeatedly against the rocky shore...";
        private const string String06C6 = "...and kill you.";
        private const string String06D7 = "The narrows here must be passed by only one of you at a time.";
        private const string String0715 = "The violent currents of a whirlpool drag you under the water, carrying you helplessly eastward.";
        private const string String0775 = "To one of three.";
        private const string String0786 = "To two of three.";
        private const string String0797 = "To three of three.";
        private const string String07AA = "Gateway back to this level's entrance.";
        private const string String07D1 = "Aha! A secret door!";
        private const string String07E5 = "There are scratches in the stones here.";
        private const string String080D = "'WARNING: Area under construction. Caution must be observed when exploring the reservoir.'";
        private const string String0868 = " - Aeowyn, Queen of Twinion.";
        private const string String0885 = "Three teleports, three choices.";
        private const string String08A5 = "I'm not telling you which ONE to choose.";
        private const string String08CE = "'Will you never listen?'";
        private const string String08E7 = "'Perhaps an old friend can help you cross the perilous waters to the northeast.'";
        private const string String0938 = "This is a very stubborn door. You rap your fists on it, but to no avail.";
        private const string String0981 = "You again knock on the door in the hopes that something will open it.";
        private const string String09C7 = "As you knock a third time, the door opens just as Kilam said it would!";
        private const string String0A0E = "The door seems to be locked, but there's no lock to pick.";
        private const string String0A48 = "The magic that bars the gate dissipates, allowing you access.";
        private const string String0A86 = "The Giant's chant doesn't work here. Perhaps you must learn a new chant from him.";
        private const string String0AD8 = "A high-vaulted ceiling stretches into darkness while the deafening roar of the water fills this chasm of a reservoir.";
        private const string String0B4E = "To the northeast a spot of land is barely visible. To the northwest stretch the many pools of this eternal reservoir.";
        private const string String0BC4 = "A magical force pumps the river into the reservoir. The noise is overpowering.";
        private const string String0C13 = "You can barely make out four large columns in the center of the reservoir; they surround what seems to be the origin of the deafening noise.";
        private const string String0CA0 = "You've reached the other side of the reservoir.";
        private const string String0CD0 = "Peering back towards the distant shore, you see a small party struggling near the pump in the center.";
        private const string String0D36 = "Perhaps you could go help them.";
        private const string String0D56 = "Enter now. Your destiny awaits.";
        private const string String0D76 = "You must be alone.";
        private const string String0D89 = "Now, through the north gateway! Be quick!";
        private const string String0DB3 = "I warned you to come alone!";
        private const string String0DCF = "To the next nexus point.";
        private const string String0DE8 = "Treacherous fool...die in vain!";
        private const string String0E08 = "You see another dazzling carving, similar to the one in some maze above.";
        private const string String0E51 = "A gold throne sits to the north; to reach it you need only defeat he who guards it!";
        private const string String0EA5 = "Lord Aqueus, an enormous giant, rises from his throne bellowing, 'You are no match for me, the Aqueduct's guardian.";
        private const string String0F19 = "Come, let me teach you the price of ignorance!'";
        private const string String0F49 = "Aqueus' successor rises to the challenge!";
        private const string String0F73 = "Servants rush to his aide!";
        private const string String0F8E = "Sartiq speaks again, 'Now you must learn the Rhyme. With it you may enter his throne room.'";
        private const string String0FEA = "Again the giant probes your mind, depositing a ritual chant to be used later.";
        private const string String1038 = "'FACE HIM! DEFEAT HIM! AVENGE ME!!'";
        private const string String105C = "With that outburst, the last bit of life seeps from Sartiq's body.";
        private const string String109F = "'Leave me for now. Search for Malik south of here!'";
        private const string String10D3 = "An ancient, dying giant motions you to move closer.";
        private const string String1107 = "'Hear me, whoever you are.  Aqueus is across the reservoir, to the northeast.";
        private const string String1155 = "Listen to my chant, it will be useful!'";
        private const string String117D = "Sartiq uses his magic to burn the chant into your mind.";
        private const string String11B5 = "'The waters which guard his throne room will part with this ritual chant! All you need do is approach them!'";
        private const string String1222 = "A weary party fights the torrential waters nearby.";
        private const string String1255 = "'You! Yes, you! Come, help us. Help!!!'";
        private const string String127D = "There must be something you can use to help them.";
        private const string String12AF = "By repeatedly tossing one end of the rope to the party, you manage to pull them one by one to safety.";
        private const string String1315 = "When the last one is rescued, you fall back, exhausted.";
        private const string String134D = "The leader approaches: 'Hail, friend! We would surely have drowned in these torrents had it not been for your timely arrival.";
        private const string String13CB = "Sorry you lost your rope in the waters.";
        private const string String13F3 = "Take these gifts as our gratitude. Hail`'";
        private const string String141D = "You feel wiser and wealthier.";
        private const string String143B = "Your efforts are valiant but futile!";
        private const string String1460 = "The party is swept away by the flood and vanishes into the murky depths.";
        private const string String14A9 = "The party is no longer here.";
        private const string String14C6 = "These torrential waters must be entered alone.";
        private const string String14F5 = "Young giants rush at you.";
        private const string String150F = "Frustrated adventurers, unable to find a secret passage here, turn to attack you!";
        private const string String1561 = "'These cursed walls keep sealing me in!";
        private const string String1589 = "Oh, I do wish there was a faster way through this maze of horrors and giants!'";
        private const string String15D8 = "Agents of Lord Aqueus charge you!";
        private const string String15FA = "A mad adventurer attacks you in a berserker's rage.";
        private const string String162E = "You find the thief Malik and recite the chant, hoping he will understand.";
        private const string String1678 = "'Ah, you've found Sartiq! You must return, for your chant is not complete. He will teach you the rest when you return.'";
        private const string String16F0 = "'Forgive me.' So saying, Malik draws his stiletto and quickly carves a curious mark in your arm.";
        private const string String1751 = "'Sartiq will trust you with the rest of the chant now. This mark will prove to him that you are an ally.'";
        private const string String17BB = "'The agents of Aqueus would have attacked rather than bear such a scar. Farewell!'";
        private const string String180E = "'Go, seek Sartiq again.'";
        private const string String1827 = "A strong thief stands here, as if waiting for a message.";
        private const string String1860 = "'Come again to me once you've found my friend.'";
        private const string String1890 = "'Away! Seek Sartiq to the north. Then, perchance, I will speak to you.'";
        private const string String18D8 = "'There are many slippery traps and hidden doors here. If only I had a thief or a thief's toys.'";
        private const string String1938 = "The throne room is decorated with marvelous carvings of precious jewels. No doubt the late Aqueus stole them from the river.";
        private const string String19B5 = "'Good journeys to you. I wish you luck with these awful puzzles. What I know I shall share with you, for...say...these gold pieces?";
        private const string String1A39 = "Excellent! In the northwest corner, a door there is very stubborn. Merely approach and knock three times, and it will open!";
        private const string String1AB5 = "Be on the lookout for a stern thief and an ancient giant. Together they will help you across the waters.'";
        private const string String1B1F = "Kilam has left this area.";
        private const string String1B39 = "A magical pillar stands guard against curious intruders.";
        private const string String1B72 = "You manage to nudge the column enough to move forward.";
        private const string String1BA9 = "You are unable to move the pillar's massive bulk.";
        private const string String1BDB = "Violent swirls of water crash against the northeastern shore.";
        private const string String1C19 = "The party you thought you saw drown is here.";
        private const string String1C46 = "They are badly hurt and huddled over one of their friends who appears to be dead.";
        private const string String1C98 = "'YOU!! YOU!! You are responsible for Shalana's death because you didn't rescue us! I should slice you in half!'";
        private const string String1D08 = "'You must try to do something to bring her back.'";
        private const string String1D3A = "Your skills and knowledge revive the half-drowned Shalana.";
        private const string String1D75 = "The leader clasps your hand in thanks.";
        private const string String1D9C = "'Ah, friend, forgive my angry words.'";
        private const string String1DC2 = "'Thank you for returning Shalana to me.'";
        private const string String1DEB = "'Take these gifts with my gratitude. Hail`'";
        private const string String1E17 = "You fail to save the life of the girl.";
        private const string String1E3E = "The party leader wheels on you!";
        private const string String1E5E = "'NO! Damn you to Hades! Die now, you ignorant toad!!'";
        private const string String1E94 = "Though exhausted from their ordeal, the weary party has the strength to pummel you ferociously.";
        private const string String1EF4 = "Abandoning you to the ghosts, they march off with their dead.";
        private const string String1F32 = "The warm waters satisfy your thirst for knowledge with a new spell!";
        private const string String1F76 = "The warm waters satisfy your thirst for knowledge with a new skill!";
        private const string String1FBA = "The fierce torrents bar your way. You must find an alternate way across.";
        private const string String2003 = "You've managed to unlock the gate.";
        private const string String2026 = "One well skilled with lockpicks may be able to open this magnificent gate.";
        private const string String2071 = "The cool waters enlighten you with a new spell!";
        private const string String20A1 = "The waters are refreshing!";
        
        // === Functions ================================================
        private void FnRIVERREG_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetNoHealZone(player);
            L000B: PushStack(player, 0x01);
            L000F: PushStack(player, 0x00);
001E  0012 C4 5E 06  les bx, [bp+0x6]
0021  0015 26 FF 5F 04  call far word [es:bx+0x4]
            L0019: cx = PopStack(player);
            L001A: cx = PopStack(player);
            L001B: RefreshCompareFlags(ax);
            L001D: if (JumpNotEqual) goto L0087;
            L001F: RefreshCompareFlags(GetFlag(player, 0x02, 0x0A));
            L0032: if (JumpNotEqual) goto L0069;
            L0034: ShowMessage(player, String03FC); // The strong currents twist and pound your body.
            L0041: ax = GetMaxHits(player);
            L0048: bx = 0x0008;
            L004B: dx = ax % bx; ax = ax / bx;
005A  004E 40     inc ax
            L004F: DamagePlayer(player, ax);
            L0059: RefreshCompareFlags(GetCurrentHits(player));
            L0062: if (JumpAbove) goto L0076;
0070  0064 B8 2B 04  mov ax, 0x42b
            L0067: goto L006C;
            L0069: ShowMessage(player, String044F); // You've defeated Aqueus! You may travel safely through these waters.
            L0076: PushStack(player, 0x01);
            L007A: PushStack(player, ax);
            L007B: PushStack(player, 0x00);
008A  007E C4 5E 06  les bx, [bp+0x6]
008D  0081 26 FF 1F  call far word [es:bx]
0090  0084 83 C4 06  add sp, 0x6
            L0087: return; // RETURN;
        }

        private void FnTOMAPONE_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0493); // The central Aqueduct lies through the east door.
            L0010: TeleportParty(player, 0x02, 0x01, 0xA0, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnMAGICCOL_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String04C4); // You have moved the column enough to squeeze by...but now you're not sure that was so wise.
            L0010: SetFloorPassable(player, 0x01, GetCurrentTile(player));
            L0025: return; // RETURN;
        }

        private void FnBUBLEPIT_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String051F); // Churning magic pulls water from below and dumps it here. The thundering noise is painful.
            L0010: ShowMessage(player, String0579); // You feel you have acted unwisely...and you are proven correct as the force slams you against a very hard southern wall...
            L001D: ax = GetMaxHits(player);
            L0024: bx = 0x0002;
            L0027: dx = ax % bx; ax = ax / bx;
            L002A: DamagePlayer(player, ax);
            L0034: RefreshCompareFlags(GetCurrentHits(player));
            L003D: if (JumpAbove) goto L0056;
            L003F: ShowMessage(player, String05F3); // And kills you.
            L004C: ExitDungeon(player, isForwardMove);
            L0054: goto L007E;
            L0056: ShowMessage(player, String0602); // And wounds you severely.
            L0063: TeleportParty(player, 0x02, 0x03, 0xC9, 0x01, isForwardMove);
            L007E: return; // RETURN;
        }

        private void FnDEATHWTR_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x01);
            L0007: PushStack(player, 0x00);
0173  000A C4 5E 06  les bx, [bp+0x6]
0176  000D 26 FF 5F 04  call far word [es:bx+0x4]
            L0011: cx = PopStack(player);
            L0012: cx = PopStack(player);
            L0013: RefreshCompareFlags(ax);
            L0015: if (JumpEqual) goto L001A;
            L0017: goto L00E6;
            L001A: Compare(PartyCount(player), 0x0001);
            L0025: if (JumpEqual) goto L002A;
            L0027: goto L00AD;
            L002A: Compare(GetFlag(player, 0x02, 0x0B), 0x0001);
            L003E: if (JumpNotEqual) goto L0078;
            L0040: ShowMessage(player, String061B); // Reciting the chant the old giant taught you causes the waters to part and allows you to proceed.
            L004D: SetFloorPassable(player, 0x01, GetCurrentTile(player));
            L0062: PushStack(player, GetCurrentTile(player));
            L006A: PushStack(player, 0x00);
01D6  006D C4 5E 06  les bx, [bp+0x6]
01D9  0070 26 FF 5F 38  call far word [es:bx+0x38]
            L0074: cx = PopStack(player);
            L0075: cx = PopStack(player);
            L0076: goto L00D5;
            L0078: ShowMessage(player, String067C); // The powerful currents here dash you repeatedly against the rocky shore...
            L0085: ShowMessage(player, String06C6); // ...and kill you.
            L0092: DamagePlayer(player, GetMaxHits(player));
            L00A3: ExitDungeon(player, isForwardMove);
            L00AB: goto L00D5;
            L00AD: ShowMessage(player, String06D7); // The narrows here must be passed by only one of you at a time.
            L00BA: TeleportParty(player, 0x02, 0x03, 0x49, 0x03, isForwardMove);
            L00D5: PushStack(player, 0x01);
            L00D9: PushStack(player, ax);
            L00DA: PushStack(player, 0x00);
0246  00DD C4 5E 06  les bx, [bp+0x6]
0249  00E0 26 FF 1F  call far word [es:bx]
024C  00E3 83 C4 06  add sp, 0x6
            L00E6: return; // RETURN;
        }

        private void FnWHIRLONE_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0715); // The violent currents of a whirlpool drag you under the water, carrying you helplessly eastward.
            L0010: TeleportParty(player, 0x02, 0x03, 0x8F, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnTELEA_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0775); // To one of three.
            L0010: TeleportParty(player, 0x02, 0x03, 0xE2, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnTELEB_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0786); // To two of three.
            L0010: TeleportParty(player, 0x02, 0x03, 0x82, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnTELEC_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0797); // To three of three.
            L0010: TeleportParty(player, 0x02, 0x03, 0x22, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnTOINGRES_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String07AA); // Gateway back to this level's entrance.
            L0010: TeleportParty(player, 0x02, 0x03, 0xAF, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnSECRETDR_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, 0x0D), 0x0006);
            L0012: if (JumpNotBelow) goto L006C;
            L0014: RefreshCompareFlags(HasUsedSpell(player, 0x17));
            L0022: if (JumpNotEqual) goto L006C;
            L0024: PushStack(player, 0x68);
            L0028: PushStack(player, ax);
035B  0029 C4 5E 06  les bx, [bp+0x6]
035E  002C 26 FF 5F 54  call far word [es:bx+0x54]
            L0030: cx = PopStack(player);
            L0031: cx = PopStack(player);
            L0032: RefreshCompareFlags(ax);
            L0034: if (JumpNotEqual) goto L006C;
            L0036: PushStack(player, 0x6E);
            L003A: PushStack(player, ax);
036D  003B C4 5E 06  les bx, [bp+0x6]
0370  003E 26 FF 5F 54  call far word [es:bx+0x54]
            L0042: cx = PopStack(player);
            L0043: cx = PopStack(player);
            L0044: RefreshCompareFlags(ax);
            L0046: if (JumpNotEqual) goto L006C;
            L0048: PushStack(player, 0x90);
            L004C: PushStack(player, ax);
037F  004D C4 5E 06  les bx, [bp+0x6]
0382  0050 26 FF 5F 54  call far word [es:bx+0x54]
            L0054: cx = PopStack(player);
            L0055: cx = PopStack(player);
            L0056: RefreshCompareFlags(ax);
            L0058: if (JumpNotEqual) goto L006C;
            L005A: PushStack(player, 0xA4);
            L005E: PushStack(player, ax);
0391  005F C4 5E 06  les bx, [bp+0x6]
0394  0062 26 FF 5F 54  call far word [es:bx+0x54]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
            L0068: RefreshCompareFlags(ax);
            L006A: if (JumpEqual) goto L0093;
            L006C: ShowMessage(player, String07D1); // Aha! A secret door!
03AB  0079 FF 76 08  push word [bp+0x8]
03AE  007C FF 76 06  push word [bp+0x6]
03B1  007F 0E     push cs
03B2  0080 E8 F7 13  call 0x147a
            L0083: // NOP
            L0084: cx = PopStack(player);
            L0085: cx = PopStack(player);
03B8  0086 FF 76 08  push word [bp+0x8]
03BB  0089 FF 76 06  push word [bp+0x6]
03BE  008C 0E     push cs
03BF  008D E8 C7 13  call 0x1457
            L0090: // NOP
            L0091: goto L00AB;
            L0093: ShowMessage(player, String07E5); // There are scratches in the stones here.
03D2  00A0 FF 76 08  push word [bp+0x8]
03D5  00A3 FF 76 06  push word [bp+0x6]
03D8  00A6 0E     push cs
03D9  00A7 E8 2D 13  call 0x13d7
            L00AA: // NOP
            L00AB: cx = PopStack(player);
            L00AC: cx = PopStack(player);
            L00AD: return; // RETURN;
        }

        private void FnENTRYMES_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String080D); // 'WARNING: Area under construction. Caution must be observed when exploring the reservoir.'
            L0010: ShowMessage(player, String0868); //  - Aeowyn, Queen of Twinion.
            L001D: return; // RETURN;
        }

        private void FnTELEMESS_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0885); // Three teleports, three choices.
            L0010: ShowRunes(player, String08A5); // I'm not telling you which ONE to choose.
            L001D: return; // RETURN;
        }

        private void FnQSTCMESS_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String08CE); // 'Will you never listen?'
            L0010: ShowMessage(player, String08E7); // 'Perhaps an old friend can help you cross the perilous waters to the northeast.'
            L001D: return; // RETURN;
        }

        private void FnLOCKDOOR_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x0E), 0x0001);
            L0017: if (JumpNotEqual) goto L003E;
            L0019: ShowMessage(player, String0938); // This is a very stubborn door. You rap your fists on it, but to no avail.
            L0026: SetFlag(player, 0x02, 0x0E, 0x02);
            L003B: goto L00CC;
            L003E: Compare(GetFlag(player, 0x02, 0x0E), 0x0002);
            L0052: if (JumpNotEqual) goto L0066;
            L0054: ShowMessage(player, String0981); // You again knock on the door in the hopes that something will open it.
049F  0061 B8 03 00  mov ax, 0x3
            L0064: goto L0029;
            L0066: Compare(GetFlag(player, 0x02, 0x0E), 0x0003);
            L007A: if (JumpNotEqual) goto L00A5;
            L007C: ShowMessage(player, String09C7); // As you knock a third time, the door opens just as Kilam said it would!
04C7  0089 FF 76 08  push word [bp+0x8]
04CA  008C FF 76 06  push word [bp+0x6]
04CD  008F 0E     push cs
04CE  0090 E8 DB 12  call 0x136e
            L0093: // NOP
            L0094: cx = PopStack(player);
            L0095: cx = PopStack(player);
04D4  0096 FF 76 08  push word [bp+0x8]
04D7  0099 FF 76 06  push word [bp+0x6]
04DA  009C 0E     push cs
04DB  009D E8 AB 12  call 0x134b
            L00A0: // NOP
            L00A1: cx = PopStack(player);
            L00A2: cx = PopStack(player);
            L00A3: goto L00CC;
04E3  00A5 FF 76 08  push word [bp+0x8]
04E6  00A8 FF 76 06  push word [bp+0x6]
04E9  00AB 0E     push cs
04EA  00AC E8 1C 12  call 0x12cb
            L00AF: // NOP
            L00B0: cx = PopStack(player);
            L00B1: cx = PopStack(player);
04F0  00B2 FF 76 08  push word [bp+0x8]
04F3  00B5 FF 76 06  push word [bp+0x6]
04F6  00B8 0E     push cs
04F7  00B9 E8 B2 12  call 0x136e
            L00BC: // NOP
            L00BD: cx = PopStack(player);
            L00BE: cx = PopStack(player);
            L00BF: ShowMessage(player, String0A0E); // The door seems to be locked, but there's no lock to pick.
            L00CC: return; // RETURN;
        }

        private void FnFLAGDOOR_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x0C), 0x0001);
            L0017: if (JumpNotEqual) goto L0033;
            L0019: ShowMessage(player, String0A48); // The magic that bars the gate dissipates, allowing you access.
0532  0026 FF 76 08  push word [bp+0x8]
0535  0029 FF 76 06  push word [bp+0x6]
0538  002C 0E     push cs
0539  002D E8 4D 12  call 0x127d
            L0030: // NOP
            L0031: goto L004B;
            L0033: ShowMessage(player, String0A86); // The Giant's chant doesn't work here. Perhaps you must learn a new chant from him.
054C  0040 FF 76 08  push word [bp+0x8]
054F  0043 FF 76 06  push word [bp+0x6]
0552  0046 0E     push cs
0553  0047 E8 B3 11  call 0x11fd
            L004A: // NOP
            L004B: cx = PopStack(player);
            L004C: cx = PopStack(player);
            L004D: return; // RETURN;
        }

        private void FnDESCRIP_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0AD8); // A high-vaulted ceiling stretches into darkness while the deafening roar of the water fills this chasm of a reservoir.
            L0010: ShowMessage(player, String0B4E); // To the northeast a spot of land is barely visible. To the northwest stretch the many pools of this eternal reservoir.
            L001D: return; // RETURN;
        }

        private void FnLAKEMESS_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0BC4); // A magical force pumps the river into the reservoir. The noise is overpowering.
            L0010: return; // RETURN;
        }

        private void FnPMPMESA_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0C13); // You can barely make out four large columns in the center of the reservoir; they surround what seems to be the origin of the deafening noise.
            L0010: return; // RETURN;
        }

        private void FnOTHERMES_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFloorObject(player, 0x03, 0x4B);
            L0014: RefreshCompareFlags(GetFlag(player, 0x02, 0x01));
            L0027: if (JumpNotEqual) goto L0077;
            L0029: ShowMessage(player, String0CA0); // You've reached the other side of the reservoir.
            L0036: RefreshCompareFlags(GetFlag(player, 0x02, 0x30));
            L0049: if (JumpNotEqual) goto L0077;
            L004B: ShowMessage(player, String0CD0); // Peering back towards the distant shore, you see a small party struggling near the pump in the center.
            L0058: ShowMessage(player, String0D36); // Perhaps you could go help them.
            L0065: PushStack(player, 0x01);
            L0069: PushStack(player, ax);
            L006A: PushStack(player, 0x03);
060C  006E C4 5E 06  les bx, [bp+0x6]
060F  0071 26 FF 1F  call far word [es:bx]
0612  0074 83 C4 06  add sp, 0x6
            L0077: return; // RETURN;
        }

        private void FnTOEOGTEL_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0xDF), 0x0001);
            L0017: if (JumpNotEqual) goto L008B;
            L0019: Compare(PartyCount(player), 0x0001);
            L0024: if (JumpNotEqual) goto L0050;
            L0026: ShowMessage(player, String0D56); // Enter now. Your destiny awaits.
            L0033: TeleportParty(player, 0x02, 0x03, 0xD2, 0x03, isForwardMove);
            L004E: goto L00A5;
            L0050: ShowMessage(player, String0D76); // You must be alone.
            L005D: PushStack(player, 0x01);
            L0061: PushStack(player, 0x00);
067B  0064 C4 5E 06  les bx, [bp+0x6]
067E  0067 26 FF 5F 04  call far word [es:bx+0x4]
            L006B: cx = PopStack(player);
            L006C: cx = PopStack(player);
            L006D: RefreshCompareFlags(ax);
            L006F: if (JumpNotEqual) goto L00A5;
            L0071: PushStack(player, 0x02);
068C  0075 C4 5E 06  les bx, [bp+0x6]
068F  0078 26 FF 9F CC 00  call far word [es:bx+0xcc]
            L007D: cx = PopStack(player);
0695  007E FF 76 08  push word [bp+0x8]
0698  0081 FF 76 06  push word [bp+0x6]
069B  0084 0E     push cs
069C  0085 E8 54 10  call 0x10dc
            L0088: // NOP
            L0089: goto L00A3;
06A2  008B FF 76 08  push word [bp+0x8]
06A5  008E FF 76 06  push word [bp+0x6]
06A8  0091 0E     push cs
06A9  0092 E8 E9 00  call 0x17e
            L0095: // NOP
            L0096: cx = PopStack(player);
            L0097: cx = PopStack(player);
06AF  0098 FF 76 08  push word [bp+0x8]
06B2  009B FF 76 06  push word [bp+0x6]
06B5  009E 0E     push cs
06B6  009F E8 50 10  call 0x10f2
            L00A2: // NOP
            L00A3: cx = PopStack(player);
            L00A4: cx = PopStack(player);
            L00A5: return; // RETURN;
        }

        private void FnPARTYCNT_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(PartyCount(player), 0x0001);
            L000E: if (JumpNotEqual) goto L001F;
            L0010: ShowMessage(player, String0D89); // Now, through the north gateway! Be quick!
            L001D: goto L005E;
            L001F: ShowMessage(player, String0DB3); // I warned you to come alone!
            L002C: ax = GetMaxHits(player);
            L0033: bx = 0x0003;
            L0036: dx = ax % bx; ax = ax / bx;
            L0039: DamagePlayer(player, ax);
            L0043: TeleportParty(player, 0x02, 0x03, 0x2C, 0x02, isForwardMove);
            L005E: return; // RETURN;
        }

        private void FnEOGTELE_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0xDF), 0x0001);
            L0017: if (JumpNotEqual) goto L0042;
            L0019: ShowMessage(player, String0DCF); // To the next nexus point.
            L0026: TeleportParty(player, 0x03, 0x02, 0x00, 0x33, isForwardMove);
            L0040: goto L0075;
            L0042: ShowMessage(player, String0DE8); // Treacherous fool...die in vain!
076D  004F FF 76 08  push word [bp+0x8]
0770  0052 FF 76 06  push word [bp+0x6]
0773  0055 0E     push cs
0774  0056 E8 92 0F  call 0xfeb
            L0059: // NOP
            L005A: cx = PopStack(player);
            L005B: cx = PopStack(player);
            L005C: DamagePlayer(player, GetMaxHits(player));
            L006D: ExitDungeon(player, isForwardMove);
            L0075: return; // RETURN;
        }

        private void FnBOGUSMES_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0E08); // You see another dazzling carving, similar to the one in some maze above.
            L0010: return; // RETURN;
        }

        private void FnREWARD_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
07AA  0003 83 EC 04  sub sp, 0x4
07AD  0006 56     push si
07AE  0007 57     push di
            L0008: di = 0;
07B1  000A C7 46 FE 00 00  mov word [bp-0x2], 0x0
07B6  000F C7 46 FC 00 00  mov word [bp-0x4], 0x0
            L0014: RefreshCompareFlags(GetFlag(player, 0x02, 0x0A));
            L0027: if (JumpEqual) goto L002C;
            L0029: goto L00CC;
            L002C: ShowMessage(player, String0E51); // A gold throne sits to the north; to reach it you need only defeat he who guards it!
            L0039: ShowMessage(player, String0EA5); // Lord Aqueus, an enormous giant, rises from his throne bellowing, 'You are no match for me, the Aqueduct's guardian.
            L0046: ShowMessage(player, String0F19); // Come, let me teach you the price of ignorance!'
            L0053: bx = GetGuild(player);
            L005C: Compare(bx, 0x05);
            L005F: if (JumpAbove) goto L00BB;
            L0061: switch (bx) {
                case 0:
                    goto L0068;
                case 1:
                    goto L0077;
                case 2:
                    goto L0081;
                case 3:
                    goto L0090;
                case 4:
                    goto L009F;
                case 5:
                    goto L00AE;
            }
            L0068: di = 0x0013;
0812  006B C7 46 FE BA 00  mov word [bp-0x2], 0xba
0817  0070 C7 46 FC 76 00  mov word [bp-0x4], 0x76
            L0075: goto L00BB;
            L0077: di = 0x001D;
0821  007A C7 46 FE 50 00  mov word [bp-0x2], 0x50
            L007F: goto L00A7;
            L0081: di = 0x0042;
082B  0084 C7 46 FE 8A 00  mov word [bp-0x2], 0x8a
0830  0089 C7 46 FC 4F 00  mov word [bp-0x4], 0x4f
            L008E: goto L00BB;
            L0090: di = 0x003F;
083A  0093 C7 46 FE 62 00  mov word [bp-0x2], 0x62
083F  0098 C7 46 FC 75 00  mov word [bp-0x4], 0x75
            L009D: goto L00BB;
            L009F: di = 0x001F;
0849  00A2 C7 46 FE 4F 00  mov word [bp-0x2], 0x4f
084E  00A7 C7 46 FC BA 00  mov word [bp-0x4], 0xba
            L00AC: goto L00BB;
            L00AE: di = 0x00FC;
0858  00B1 C7 46 FE 75 00  mov word [bp-0x2], 0x75
085D  00B6 C7 46 FC 8F 00  mov word [bp-0x4], 0x8f
0862  00BB B8 C4 09  mov ax, 0x9c4
            L00BE: PushStack(player, ax);
            L00BF: PushStack(player, 0x00);
            L00C2: PushStack(player, ax);
086A  00C3 FF 76 FC  push word [bp-0x4]
086D  00C6 FF 76 FE  push word [bp-0x2]
0870  00C9 57     push di
            L00CA: goto L00EA;
            L00CC: ShowMessage(player, String0F49); // Aqueus' successor rises to the challenge!
0880  00D9 B8 2C 01  mov ax, 0x12c
            L00DC: PushStack(player, ax);
            L00DD: PushStack(player, 0x00);
            L00E0: PushStack(player, ax);
            L00E1: PushStack(player, ax);
            L00E2: PushStack(player, 0xA3);
            L00E6: PushStack(player, 0xB5);
0891  00EA C4 5E 06  les bx, [bp+0x6]
0894  00ED 26 FF 9F D8 00  call far word [es:bx+0xd8]
0899  00F2 83 C4 0C  add sp, 0xc
            L00F5: Compare(PartyCount(player), 0x0001);
            L0100: if (JumpEqual) goto L0109;
            L0102: Compare(ax, 0x0002);
            L0105: if (JumpEqual) goto L0112;
            L0107: goto L014C;
            L0109: PushStack(player, 0x28);
08B4  010D B8 01 00  mov ax, 0x1
            L0110: goto L017A;
            L0112: ShowMessage(player, String0F73); // Servants rush to his aide!
            L011F: AddEncounter(player, 0x01, 0x1D);
            L0131: AddEncounter(player, 0x02, 0x1C);
            L0143: PushStack(player, 0x28);
08EE  0147 B8 06 00  mov ax, 0x6
            L014A: goto L017A;
            L014C: ShowMessage(player, String0F73); // Servants rush to his aide!
            L0159: si = 0x0001;
            L015C: goto L016E;
            L015E: AddEncounter(player, si, 0x1D);
            L016D: si = si + 1;
            L016E: Compare(si, 0x04);
            L0171: if (JumpLessOrEqual) goto L015E;
            L0173: AddEncounter(player, 0x05, 0x28);
092C  0185 5F     pop di
092D  0186 5E     pop si
            L0187: // restore stack ptr: sp = bp;
            L0189: return; // RETURN;
        }

        private void FnOLDGIANT_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0012);
            L0010: Compare(GetFlag(player, 0x02, 0x0B), 0x0001);
            L0024: if (JumpNotEqual) goto L009D;
            L0026: Compare(GetFlag(player, 0x02, 0x0D), 0x0001);
            L003A: if (JumpNotEqual) goto L008E;
            L003C: ShowMessage(player, String0F8E); // Sartiq speaks again, 'Now you must learn the Rhyme. With it you may enter his throne room.'
            L0049: ShowMessage(player, String0FEA); // Again the giant probes your mind, depositing a ritual chant to be used later.
            L0056: ShowMessage(player, String1038); // 'FACE HIM! DEFEAT HIM! AVENGE ME!!'
            L0063: ShowMessage(player, String105C); // With that outburst, the last bit of life seeps from Sartiq's body.
            L0070: SetFlag(player, 0x02, 0x0C, 0x01);
            L0085: PushStack(player, 0x02);
09C7  0089 B8 0D 00  mov ax, 0xd
            L008C: goto L00E5;
            L008E: ShowMessage(player, String109F); // 'Leave me for now. Search for Malik south of here!'
            L009B: goto L00F3;
            L009D: ShowMessage(player, String10D3); // An ancient, dying giant motions you to move closer.
            L00AA: ShowMessage(player, String1107); // 'Hear me, whoever you are.  Aqueus is across the reservoir, to the northeast.
            L00B7: ShowMessage(player, String1155); // Listen to my chant, it will be useful!'
            L00C4: ShowMessage(player, String117D); // Sartiq uses his magic to burn the chant into your mind.
            L00D1: ShowMessage(player, String11B5); // 'The waters which guard his throne room will part with this ritual chant! All you need do is approach them!'
            L00DE: SetFlag(player, 0x02, 0x0B, 0x01);
            L00F3: return; // RETURN;
        }

        private void FnWARYPRTY_1B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: si = 0;
            L0006: Compare(PartyCount(player), 0x0001);
            L0011: if (JumpEqual) goto L0016;
            L0013: goto L017B;
            L0016: RefreshCompareFlags(GetFlag(player, 0x02, 0x30));
            L0029: if (JumpEqual) goto L002E;
            L002B: goto L016C;
            L002E: ShowPortrait(player, 0x001C);
            L003B: ShowMessage(player, String1222); // A weary party fights the torrential waters nearby.
            L0048: ShowMessage(player, String1255); // 'You! Yes, you! Come, help us. Help!!!'
            L0055: ShowMessage(player, String127D); // There must be something you can use to help them.
            L0062: PushStack(player, 0xE0);
            L0066: PushStack(player, ax);
0A9A  0067 C4 5E 06  les bx, [bp+0x6]
0A9D  006A 26 FF 5F 54  call far word [es:bx+0x54]
            L006E: cx = PopStack(player);
            L006F: cx = PopStack(player);
            L0070: RefreshCompareFlags(ax);
            L0072: if (JumpNotEqual) goto L0077;
            L0074: goto L0123;
            L0077: ShowMessage(player, String12AF); // By repeatedly tossing one end of the rope to the party, you manage to pull them one by one to safety.
            L0084: ShowMessage(player, String1315); // When the last one is rescued, you fall back, exhausted.
            L0091: ShowMessage(player, String134D); // The leader approaches: 'Hail, friend! We would surely have drowned in these torrents had it not been for your timely arrival.
            L009E: ShowMessage(player, String13CB); // Sorry you lost your rope in the waters.
            L00AB: ShowMessage(player, String13F3); // Take these gifts as our gratitude. Hail`'
            L00B8: ShowMessage(player, String141D); // You feel wiser and wealthier.
            L00C5: GiveItem(player, 0x03);
            L00D1: GiveItem(player, 0xBA);
            L00DD: RemoveItem(player, 0xE0);
            L00E9: ModifyGold(player, 0x07D0);
            L00FA: AddExperience(player, 0x000007D0);
            L010B: SetFlag(player, 0x02, 0x30, 0x01);
            L0120: goto L01A9;
            L0123: ax = HasUsedItem(player, 0x01, 0xDF);
            L0136: if (JumpNotEqual) goto L014D;
            L0138: ax = HasUsedItem(player, 0xE1, 0xFE);
            L014B: if (JumpEqual) goto L01A9;
            L014D: ShowMessage(player, String143B); // Your efforts are valiant but futile!
            L015A: ShowMessage(player, String1460); // The party is swept away by the flood and vanishes into the murky depths.
0B9A  0167 B8 02 00  mov ax, 0x2
            L016A: goto L010E;
            L016C: ShowMessage(player, String14A9); // The party is no longer here.
            L0179: goto L01A9;
            L017B: ShowMessage(player, String14C6); // These torrential waters must be entered alone.
            L0188: ax = GetCurrentTile(player);
0BC2  018F 48     dec ax
            L0190: si = ax;
            L0192: PushStack(player, 0x00);
0BC8  0195 56     push si
            L0196: PushStack(player, 0x03);
            L019A: PushStack(player, 0x02);
0BD1  019E C4 5E 06  les bx, [bp+0x6]
0BD4  01A1 26 FF 9F BC 00  call far word [es:bx+0xbc]
0BD9  01A6 83 C4 08  add sp, 0x8
            L01A9: return; // RETURN (restoring si);
        }

        private void FnBATONE_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0BE2  0003 83 EC 06  sub sp, 0x6
0BE5  0006 56     push si
0BE6  0007 57     push di
            L0008: di = 0;
0BE9  000A C7 46 FE 00 00  mov word [bp-0x2], 0x0
0BEE  000F C7 46 FC 00 00  mov word [bp-0x4], 0x0
            L0014: si = 0;
0BF5  0016 C7 46 FA 00 00  mov word [bp-0x6], 0x0
            L001B: ShowMessage(player, String14F5); // Young giants rush at you.
            L0028: Compare(PartyCount(player), 0x0001);
            L0033: if (JumpEqual) goto L0037;
            L0035: goto L0044;
            L0037: di = 0x0020;
0C19  003A C7 46 FE 20 00  mov word [bp-0x2], 0x20
            L003F: si = 0x0002;
            L0042: goto L0059;
            L0044: di = 0x0020;
0C26  0047 C7 46 FE 20 00  mov word [bp-0x2], 0x20
0C2B  004C C7 46 FC 1F 00  mov word [bp-0x4], 0x1f
            L0051: si = 0x0002;
0C33  0054 C7 46 FA 06 00  mov word [bp-0x6], 0x6
0C38  0059 57     push di
            L005A: PushStack(player, 0x01);
0C3D  005E C4 5E 06  les bx, [bp+0x6]
0C40  0061 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0066: cx = PopStack(player);
            L0067: cx = PopStack(player);
0C47  0068 0B F6  or si, si
            L006A: if (JumpEqual) goto L0090;
0C4B  006C FF 76 FE  push word [bp-0x2]
0C4E  006F 56     push si
0C4F  0070 C4 5E 06  les bx, [bp+0x6]
0C52  0073 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0078: cx = PopStack(player);
            L0079: cx = PopStack(player);
0C59  007A 83 7E FA 00  cmp word [bp-0x6], 0x0
            L007E: if (JumpEqual) goto L0090;
0C5F  0080 FF 76 FC  push word [bp-0x4]
0C62  0083 FF 76 FA  push word [bp-0x6]
0C65  0086 C4 5E 06  les bx, [bp+0x6]
0C68  0089 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L008E: cx = PopStack(player);
            L008F: cx = PopStack(player);
0C6F  0090 5F     pop di
0C70  0091 5E     pop si
            L0092: // restore stack ptr: sp = bp;
            L0094: return; // RETURN;
        }

        private void FnBATTWO_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0C78  0003 83 EC 0A  sub sp, 0xa
0C7B  0006 56     push si
0C7C  0007 57     push di
            L0008: di = 0;
0C7F  000A C7 46 FE 00 00  mov word [bp-0x2], 0x0
0C84  000F C7 46 FC 00 00  mov word [bp-0x4], 0x0
0C89  0014 C7 46 FA 00 00  mov word [bp-0x6], 0x0
            L0019: si = 0;
0C90  001B C7 46 F8 00 00  mov word [bp-0x8], 0x0
0C95  0020 C7 46 F6 00 00  mov word [bp-0xa], 0x0
            L0025: ShowMessage(player, String150F); // Frustrated adventurers, unable to find a secret passage here, turn to attack you!
            L0032: Compare(PartyCount(player), 0x0001);
            L003D: if (JumpEqual) goto L0046;
            L003F: Compare(ax, 0x0002);
            L0042: if (JumpEqual) goto L0053;
            L0044: goto L006A;
            L0046: di = 0x0019;
0CBE  0049 C7 46 FE 1A 00  mov word [bp-0x2], 0x1a
            L004E: si = 0x0005;
            L0051: goto L0089;
            L0053: di = 0x0019;
0CCB  0056 C7 46 FE 19 00  mov word [bp-0x2], 0x19
0CD0  005B C7 46 FC 1E 00  mov word [bp-0x4], 0x1e
            L0060: si = 0x0002;
0CD8  0063 C7 46 F8 04 00  mov word [bp-0x8], 0x4
            L0068: goto L0089;
            L006A: di = 0x001E;
0CE2  006D C7 46 FE 19 00  mov word [bp-0x2], 0x19
0CE7  0072 C7 46 FC 1B 00  mov word [bp-0x4], 0x1b
0CEC  0077 C7 46 FA 21 00  mov word [bp-0x6], 0x21
            L007C: si = 0x0002;
0CF4  007F C7 46 F8 03 00  mov word [bp-0x8], 0x3
0CF9  0084 C7 46 F6 04 00  mov word [bp-0xa], 0x4
0CFE  0089 57     push di
            L008A: PushStack(player, 0x01);
0D03  008E C4 5E 06  les bx, [bp+0x6]
0D06  0091 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L0096: cx = PopStack(player);
            L0097: cx = PopStack(player);
0D0D  0098 0B F6  or si, si
            L009A: if (JumpEqual) goto L00D6;
0D11  009C FF 76 FE  push word [bp-0x2]
0D14  009F 56     push si
0D15  00A0 C4 5E 06  les bx, [bp+0x6]
0D18  00A3 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L00A8: cx = PopStack(player);
            L00A9: cx = PopStack(player);
0D1F  00AA 83 7E F8 00  cmp word [bp-0x8], 0x0
            L00AE: if (JumpEqual) goto L00D6;
0D25  00B0 FF 76 FC  push word [bp-0x4]
0D28  00B3 FF 76 F8  push word [bp-0x8]
0D2B  00B6 C4 5E 06  les bx, [bp+0x6]
0D2E  00B9 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L00BE: cx = PopStack(player);
            L00BF: cx = PopStack(player);
0D35  00C0 83 7E F6 00  cmp word [bp-0xa], 0x0
            L00C4: if (JumpEqual) goto L00D6;
0D3B  00C6 FF 76 FA  push word [bp-0x6]
0D3E  00C9 FF 76 F6  push word [bp-0xa]
0D41  00CC C4 5E 06  les bx, [bp+0x6]
0D44  00CF 26 FF 9F D4 00  call far word [es:bx+0xd4]
            L00D4: cx = PopStack(player);
            L00D5: cx = PopStack(player);
0D4B  00D6 5F     pop di
0D4C  00D7 5E     pop si
            L00D8: // restore stack ptr: sp = bp;
            L00DA: return; // RETURN;
        }

        private void FnBATTHREE_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: Compare(PartyCount(player), 0x0001);
            L000F: if (JumpEqual) goto L0018;
            L0011: Compare(ax, 0x0002);
            L0014: if (JumpEqual) goto L0034;
            L0016: goto L0050;
            L0018: si = 0x0001;
            L001B: goto L002D;
            L001D: AddEncounter(player, si, 0x20);
            L002C: si = si + 1;
            L002D: Compare(si, 0x02);
            L0030: if (JumpLessOrEqual) goto L001D;
            L0032: goto L0084;
            L0034: si = 0x0001;
            L0037: goto L0049;
            L0039: AddEncounter(player, si, 0x20);
            L0048: si = si + 1;
            L0049: Compare(si, 0x04);
            L004C: if (JumpLessOrEqual) goto L0039;
            L004E: goto L0084;
            L0050: si = 0x0001;
            L0053: goto L0065;
            L0055: AddEncounter(player, si, 0x20);
            L0064: si = si + 1;
            L0065: Compare(si, 0x02);
            L0068: if (JumpLessOrEqual) goto L0055;
            L006A: si = 0x0003;
            L006D: goto L007F;
            L006F: AddEncounter(player, si, 0x1E);
            L007E: si = si + 1;
            L007F: Compare(si, 0x06);
            L0082: if (JumpLessOrEqual) goto L006F;
            L0084: return; // RETURN (restoring si);
        }

        private void FnNPCONEA_1F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002D);
            L0010: ShowMessage(player, String1561); // 'These cursed walls keep sealing me in!
            L001D: ShowMessage(player, String1589); // Oh, I do wish there was a faster way through this maze of horrors and giants!'
            L002A: return; // RETURN;
        }

        private void FnBATLB_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si);
            L0004: ShowMessage(player, String15D8); // Agents of Lord Aqueus charge you!
            L0011: Compare(PartyCount(player), 0x0001);
            L001C: if (JumpEqual) goto L0020;
            L001E: goto L003C;
            L0020: si = 0x0001;
            L0023: goto L0035;
            L0025: AddEncounter(player, si, 0x1C);
            L0034: si = si + 1;
            L0035: Compare(si, 0x02);
            L0038: if (JumpLessOrEqual) goto L0025;
            L003A: goto L0070;
            L003C: si = 0x0001;
            L003F: goto L0051;
            L0041: AddEncounter(player, si, 0x1C);
            L0050: si = si + 1;
            L0051: Compare(si, 0x02);
            L0054: if (JumpLessOrEqual) goto L0041;
            L0056: si = 0x0003;
            L0059: goto L006B;
            L005B: AddEncounter(player, si, 0x1D);
            L006A: si = si + 1;
            L006B: Compare(si, 0x05);
            L006E: if (JumpLessOrEqual) goto L005B;
            L0070: return; // RETURN (restoring si);
        }

        private void FnBATLC_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN (saving si, di);
            L0005: di = 0x0002;
            L0008: SetFloorObject(player, 0x03, 0x7F);
            L0019: ax = CheckLevel(player, 0x000C);
            L0027: if (JumpEqual) goto L002C;
            L0029: di = 0x0001;
0EA3  002C 8B C7  mov ax, di
            L002E: Compare(ax, 0x0001);
            L0031: if (JumpEqual) goto L0035;
            L0033: goto L006A;
0EAC  0035 B8 F4 01  mov ax, 0x1f4
            L0038: PushStack(player, ax);
            L0039: PushStack(player, 0x00);
            L003C: PushStack(player, ax);
            L003D: PushStack(player, ax);
            L003E: PushStack(player, ax);
            L003F: PushStack(player, 0xB6);
0EBA  0043 C4 5E 06  les bx, [bp+0x6]
0EBD  0046 26 FF 9F D8 00  call far word [es:bx+0xd8]
0EC2  004B 83 C4 0C  add sp, 0xc
            L004E: si = 0x0001;
            L0051: goto L0063;
            L0053: AddEncounter(player, si, 0x23);
            L0062: si = si + 1;
            L0063: Compare(si, 0x06);
            L0066: if (JumpLessOrEqual) goto L0053;
            L0068: goto L0084;
            L006A: si = 0x0001;
            L006D: goto L007F;
            L006F: AddEncounter(player, si, 0x25);
            L007E: si = si + 1;
            L007F: Compare(si, 0x03);
            L0082: if (JumpLessOrEqual) goto L006F;
            L0084: return; // RETURN (restoring si, di);
        }

        private void FnBATLA_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x03, 0x02));
            L0016: if (JumpNotEqual) goto L004C;
            L0018: ShowMessage(player, String15FA); // A mad adventurer attacks you in a berserker's rage.
            L0025: AddEncounter(player, 0x01, 0x27);
            L0037: SetFlag(player, 0x03, 0x02, 0x01);
            L004C: return; // RETURN;
        }

        private void FnNPCTWOC_23(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0025);
            L0010: RefreshCompareFlags(GetFlag(player, 0x02, 0x0D));
            L0023: if (JumpEqual) goto L0028;
            L0025: goto L00BD;
            L0028: Compare(GetFlag(player, 0x02, 0x0B), 0x0001);
            L003C: if (JumpEqual) goto L0041;
            L003E: goto L00BD;
            L0040: // NOP
            L0041: ShowMessage(player, String162E); // You find the thief Malik and recite the chant, hoping he will understand.
            L004E: ShowMessage(player, String1678); // 'Ah, you've found Sartiq! You must return, for your chant is not complete. He will teach you the rest when you return.'
            L005B: ShowMessage(player, String16F0); // 'Forgive me.' So saying, Malik draws his stiletto and quickly carves a curious mark in your arm.
            L0068: ShowMessage(player, String1751); // 'Sartiq will trust you with the rest of the chant now. This mark will prove to him that you are an ally.'
            L0075: ShowMessage(player, String17BB); // 'The agents of Aqueus would have attacked rather than bear such a scar. Farewell!'
            L0082: ax = GetCurrentHits(player);
            L0089: bx = 0x0005;
            L008C: dx = ax % bx; ax = ax / bx;
            L008F: DamagePlayer(player, ax);
            L0099: ShowMessage(player, String180E); // 'Go, seek Sartiq again.'
            L00A6: SetFlag(player, 0x02, 0x0D, 0x01);
            L00BB: goto L00E4;
            L00BD: ShowMessage(player, String1827); // A strong thief stands here, as if waiting for a message.
            L00CA: ShowMessage(player, String1860); // 'Come again to me once you've found my friend.'
            L00D7: ShowMessage(player, String1890); // 'Away! Seek Sartiq to the north. Then, perchance, I will speak to you.'
            L00E4: return; // RETURN;
        }

        private void FnNPCTHREE_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001B);
            L0010: ShowMessage(player, String18D8); // 'There are many slippery traps and hidden doors here. If only I had a thief or a thief's toys.'
            L001D: return; // RETURN;
        }

        private void FnDONEFLAG_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x0A));
            L0016: if (JumpNotEqual) goto L002D;
            L0018: SetFlag(player, 0x02, 0x0A, 0x01);
            L002D: ShowMessage(player, String1938); // The throne room is decorated with marvelous carvings of precious jewels. No doubt the late Aqueus stole them from the river.
            L003A: return; // RETURN;
        }

        private void FnKILAM_26(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, 0x02, 0x0E));
            L0016: if (JumpNotEqual) goto L0075;
            L0018: ShowPortrait(player, 0x001F);
            L0025: ShowMessage(player, String19B5); // 'Good journeys to you. I wish you luck with these awful puzzles. What I know I shall share with you, for...say...these gold pieces?
            L0032: ShowMessage(player, String1A39); // Excellent! In the northwest corner, a door there is very stubborn. Merely approach and knock three times, and it will open!
            L003F: ShowMessage(player, String1AB5); // Be on the lookout for a stern thief and an ancient giant. Together they will help you across the waters.'
            L004C: ModifyGold(player, 0xFFFF18BA);
            L005E: SetFlag(player, 0x02, 0x0E, 0x01);
            L0073: goto L0082;
            L0075: ShowMessage(player, String1B1F); // Kilam has left this area.
            L0082: return; // RETURN;
        }

        private void FnTESTSTAT_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1B39); // A magical pillar stands guard against curious intruders.
            L0010: Compare(CheckStrength(player), 0x0010);
            L001F: if (JumpBelow) goto L007F;
            L0021: ShowMessage(player, String1B72); // You manage to nudge the column enough to move forward.
1140  002E FF 76 08  push word [bp+0x8]
1143  0031 FF 76 06  push word [bp+0x6]
1146  0034 0E     push cs
1147  0035 E8 3F 06  call 0x677
            L0038: // NOP
            L0039: cx = PopStack(player);
            L003A: cx = PopStack(player);
            L003B: SetFloorPassable(player, 0x78, 0x01);
            L004C: SetFloorPassable(player, 0x89, 0x01);
            L005D: SetFloorPassable(player, 0x98, 0x01);
            L006E: PushStack(player, 0x01);
            L0072: PushStack(player, 0x87);
1188  0076 C4 5E 06  les bx, [bp+0x6]
118B  0079 26 FF 5F 34  call far word [es:bx+0x34]
            L007D: goto L0097;
            L007F: ShowMessage(player, String1BA9); // You are unable to move the pillar's massive bulk.
119E  008C FF 76 08  push word [bp+0x8]
11A1  008F FF 76 06  push word [bp+0x6]
11A4  0092 0E     push cs
11A5  0093 E8 61 05  call 0x5f7
            L0096: // NOP
            L0097: cx = PopStack(player);
            L0098: cx = PopStack(player);
            L0099: return; // RETURN;
        }

        private void FnRIVRWARN_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String1BDB); // Violent swirls of water crash against the northeastern shore.
            L0010: return; // RETURN;
        }

        private void FnPARTTWO_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x02, 0x30), 0x0002);
            L0017: if (JumpEqual) goto L001C;
            L0019: goto L0216;
            L001C: ShowPortrait(player, 0x001C);
            L0029: ShowMessage(player, String1C19); // The party you thought you saw drown is here.
            L0036: ShowMessage(player, String1C46); // They are badly hurt and huddled over one of their friends who appears to be dead.
            L0043: ShowMessage(player, String1C98); // 'YOU!! YOU!! You are responsible for Shalana's death because you didn't rescue us! I should slice you in half!'
            L0050: ShowMessage(player, String1D08); // 'You must try to do something to bring her back.'
            L005D: PushStack(player, 0xC5);
            L0061: PushStack(player, ax);
1221  0062 C4 5E 06  les bx, [bp+0x6]
1224  0065 26 FF 5F 54  call far word [es:bx+0x54]
            L0069: cx = PopStack(player);
            L006A: cx = PopStack(player);
            L006B: RefreshCompareFlags(ax);
            L006D: if (JumpNotEqual) goto L00A6;
            L006F: PushStack(player, 0xA7);
            L0073: PushStack(player, ax);
1233  0074 C4 5E 06  les bx, [bp+0x6]
1236  0077 26 FF 5F 54  call far word [es:bx+0x54]
            L007B: cx = PopStack(player);
            L007C: cx = PopStack(player);
            L007D: RefreshCompareFlags(ax);
            L007F: if (JumpNotEqual) goto L00A6;
            L0081: PushStack(player, 0x1E);
            L0085: PushStack(player, ax);
1245  0086 C4 5E 06  les bx, [bp+0x6]
1248  0089 26 FF 5F 54  call far word [es:bx+0x54]
            L008D: cx = PopStack(player);
            L008E: cx = PopStack(player);
            L008F: RefreshCompareFlags(ax);
            L0091: if (JumpNotEqual) goto L00A6;
            L0093: RefreshCompareFlags(HasUsedSpell(player, 0x16));
            L00A1: if (JumpNotEqual) goto L00A6;
            L00A3: goto L0152;
            L00A6: ShowMessage(player, String1D3A); // Your skills and knowledge revive the half-drowned Shalana.
            L00B3: ShowMessage(player, String1D75); // The leader clasps your hand in thanks.
            L00C0: ShowMessage(player, String1D9C); // 'Ah, friend, forgive my angry words.'
            L00CD: ShowMessage(player, String1DC2); // 'Thank you for returning Shalana to me.'
            L00DA: ShowMessage(player, String1DEB); // 'Take these gifts with my gratitude. Hail`'
            L00E7: ShowMessage(player, String141D); // You feel wiser and wealthier.
            L00F4: GiveItem(player, 0x43);
            L0100: GiveItem(player, 0xBA);
            L010C: RemoveItem(player, 0xE0);
            L0118: ModifyGold(player, 0x07D0);
            L0129: AddExperience(player, 0x000007D0);
            L013A: SetFlag(player, 0x02, 0x30, 0x02);
            L014F: goto L0216;
            L0152: ax = HasUsedItem(player, 0x01, 0x1D);
            L0165: if (JumpNotEqual) goto L01A6;
            L0167: ax = HasUsedItem(player, 0x1F, 0xA6);
            L017A: if (JumpNotEqual) goto L01A6;
            L017C: ax = HasUsedItem(player, 0xA8, 0xC4);
            L018F: if (JumpNotEqual) goto L01A6;
            L0191: ax = HasUsedItem(player, 0xC6, 0xFE);
            L01A4: if (JumpEqual) goto L0216;
            L01A6: ShowMessage(player, String143B); // Your efforts are valiant but futile!
            L01B3: ShowMessage(player, String1E17); // You fail to save the life of the girl.
            L01C0: ShowMessage(player, String1E3E); // The party leader wheels on you!
            L01CD: ShowMessage(player, String1E5E); // 'NO! Damn you to Hades! Die now, you ignorant toad!!'
            L01DA: ShowMessage(player, String1E94); // Though exhausted from their ordeal, the weary party has the strength to pummel you ferociously.
            L01E7: ShowMessage(player, String1EF4); // Abandoning you to the ghosts, they march off with their dead.
            L01F4: SetFlag(player, 0x02, 0x30, 0x03);
13C8  0209 FF 76 08  push word [bp+0x8]
13CB  020C FF 76 06  push word [bp+0x6]
13CE  020F 0E     push cs
13CF  0210 E8 59 03  call 0x56c
            L0213: // NOP
            L0214: cx = PopStack(player);
            L0215: cx = PopStack(player);
            L0216: return; // RETURN;
        }

        private void FnWIZFNTN_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
13DA  0003 FF 76 08  push word [bp+0x8]
13DD  0006 FF 76 06  push word [bp+0x6]
13E0  0009 0E     push cs
13E1  000A E8 FD 02  call 0x30a
            L000D: // NOP
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
            L0010: Compare(GetGuild(player), 0x0004);
            L001A: if (JumpEqual) goto L0023;
            L001C: Compare(ax, 0x0005);
            L001F: if (JumpEqual) goto L0023;
            L0021: goto L006D;
            L0023: RefreshCompareFlags(GetFlag(player, 0x02, 0xBD));
            L0036: if (JumpNotEqual) goto L006B;
            L0038: SetSpellLevel(player, 0x0B, 0x01);
            L0049: SetFlag(player, 0x02, 0xBD, 0x01);
1435  005E FF 76 08  push word [bp+0x8]
1438  0061 FF 76 06  push word [bp+0x6]
143B  0064 0E     push cs
143C  0065 E8 08 03  call 0x370
            L0068: // NOP
            L0069: goto L0078;
            L006B: goto L006D;
1444  006D FF 76 08  push word [bp+0x8]
1447  0070 FF 76 06  push word [bp+0x6]
144A  0073 0E     push cs
144B  0074 E8 0B 03  call 0x382
            L0077: // NOP
            L0078: cx = PopStack(player);
            L0079: cx = PopStack(player);
            L007A: return; // RETURN;
        }

        private void FnCLERICFN_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
1456  0003 FF 76 08  push word [bp+0x8]
1459  0006 FF 76 06  push word [bp+0x6]
145C  0009 0E     push cs
145D  000A E8 81 02  call 0x28e
            L000D: // NOP
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
            L0010: Compare(GetGuild(player), 0x0004);
            L001A: if (JumpEqual) goto L0023;
            L001C: Compare(ax, 0x0005);
            L001F: if (JumpEqual) goto L0023;
            L0021: goto L006D;
            L0023: RefreshCompareFlags(GetFlag(player, 0x02, 0x88));
            L0036: if (JumpNotEqual) goto L006B;
            L0038: SetSpellLevel(player, 0x03, 0x01);
            L0049: SetFlag(player, 0x02, 0x88, 0x01);
14B1  005E FF 76 08  push word [bp+0x8]
14B4  0061 FF 76 06  push word [bp+0x6]
14B7  0064 0E     push cs
14B8  0065 E8 8C 02  call 0x2f4
            L0068: // NOP
            L0069: goto L0078;
            L006B: goto L006D;
14C0  006D FF 76 08  push word [bp+0x8]
14C3  0070 FF 76 06  push word [bp+0x6]
14C6  0073 0E     push cs
14C7  0074 E8 8F 02  call 0x306
            L0077: // NOP
            L0078: cx = PopStack(player);
            L0079: cx = PopStack(player);
            L007A: return; // RETURN;
        }

        private void FnKNIGHTFN_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
14D2  0003 FF 76 08  push word [bp+0x8]
14D5  0006 FF 76 06  push word [bp+0x6]
14D8  0009 0E     push cs
14D9  000A E8 05 02  call 0x212
            L000D: // NOP
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
            L0010: Compare(GetGuild(player), 0x0001);
            L001A: if (JumpEqual) goto L0023;
            L001C: Compare(ax, 0x0005);
            L001F: if (JumpEqual) goto L0023;
            L0021: goto L006D;
            L0023: RefreshCompareFlags(GetFlag(player, 0x02, 0x86));
            L0036: if (JumpNotEqual) goto L006B;
            L0038: SetSpellLevel(player, 0x0E, 0x01);
            L0049: SetFlag(player, 0x02, 0x86, 0x01);
152D  005E FF 76 08  push word [bp+0x8]
1530  0061 FF 76 06  push word [bp+0x6]
1533  0064 0E     push cs
1534  0065 E8 10 02  call 0x278
            L0068: // NOP
            L0069: goto L0078;
            L006B: goto L006D;
153C  006D FF 76 08  push word [bp+0x8]
153F  0070 FF 76 06  push word [bp+0x6]
1542  0073 0E     push cs
1543  0074 E8 13 02  call 0x28a
            L0077: // NOP
            L0078: cx = PopStack(player);
            L0079: cx = PopStack(player);
            L007A: return; // RETURN;
        }

        private void FnPRIEST_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
154E  0003 FF 76 08  push word [bp+0x8]
1551  0006 FF 76 06  push word [bp+0x6]
1554  0009 0E     push cs
1555  000A E8 89 01  call 0x196
            L000D: // NOP
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
            L0010: Compare(GetGuild(player), 0x0001);
            L001A: if (JumpEqual) goto L0023;
            L001C: Compare(ax, 0x0004);
            L001F: if (JumpEqual) goto L006F;
            L0021: goto L0097;
            L0023: RefreshCompareFlags(GetFlag(player, 0x02, 0xD3));
            L0036: if (JumpNotEqual) goto L006D;
            L0038: SetSpellLevel(player, 0x17, 0x01);
            L0049: SetFlag(player, 0x02, 0xD3, 0x01);
            L005E: ShowMessage(player, String1F32); // The warm waters satisfy your thirst for knowledge with a new spell!
            L006B: goto L00A4;
            L006D: goto L0097;
            L006F: RefreshCompareFlags(GetSkillLevel(player, 0x16));
            L007D: if (JumpNotEqual) goto L0095;
            L007F: SetSkillLevel(player, 0x16, 0x01);
15DB  0090 B8 76 1F  mov ax, 0x1f76
            L0093: goto L0061;
            L0095: goto L0097;
15E2  0097 FF 76 08  push word [bp+0x8]
15E5  009A FF 76 06  push word [bp+0x6]
15E8  009D 0E     push cs
15E9  009E E8 6D 01  call 0x20e
            L00A1: // NOP
            L00A2: cx = PopStack(player);
            L00A3: cx = PopStack(player);
15EF  00A4 FF 76 08  push word [bp+0x8]
15F2  00A7 FF 76 06  push word [bp+0x6]
15F5  00AA 0E     push cs
15F6  00AB E8 E8 00  call 0x196
            L00AE: // NOP
            L00AF: cx = PopStack(player);
            L00B0: cx = PopStack(player);
            L00B1: Compare(GetGuild(player), 0x0001);
            L00BB: if (JumpEqual) goto L00C4;
            L00BD: Compare(ax, 0x0004);
            L00C0: if (JumpEqual) goto L00C4;
            L00C2: goto L00F6;
            L00C4: RefreshCompareFlags(GetSkillLevel(player, 0x16));
            L00D2: if (JumpNotEqual) goto L00F4;
            L00D4: SetSkillLevel(player, 0x16, 0x01);
            L00E5: ShowMessage(player, String1F76); // The warm waters satisfy your thirst for knowledge with a new skill!
            L00F2: goto L0103;
            L00F4: goto L00F6;
1641  00F6 FF 76 08  push word [bp+0x8]
1644  00F9 FF 76 06  push word [bp+0x6]
1647  00FC 0E     push cs
1648  00FD E8 0E 01  call 0x20e
            L0100: // NOP
            L0101: cx = PopStack(player);
            L0102: cx = PopStack(player);
            L0103: return; // RETURN;
        }

        private void FnBLCKWALL_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
1653  0003 FF 76 08  push word [bp+0x8]
1656  0006 FF 76 06  push word [bp+0x6]
1659  0009 0E     push cs
165A  000A E8 AC 00  call 0xb9
            L000D: // NOP
            L000E: cx = PopStack(player);
            L000F: cx = PopStack(player);
            L0010: ShowMessage(player, String1FBA); // The fierce torrents bar your way. You must find an alternate way across.
            L001D: return; // RETURN;
        }

        private void FnPICKTHIS_2F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasUsedItem(player, 0xBE, 0xC0);
            L0016: if (JumpNotEqual) goto L003A;
            L0018: RefreshCompareFlags(HasUsedSkill(player, 0x0E));
            L0026: if (JumpNotEqual) goto L003A;
            L0028: PushStack(player, 0x6F);
            L002C: PushStack(player, ax);
169C  002D C4 5E 06  les bx, [bp+0x6]
169F  0030 26 FF 5F 54  call far word [es:bx+0x54]
            L0034: cx = PopStack(player);
            L0035: cx = PopStack(player);
            L0036: RefreshCompareFlags(ax);
            L0038: if (JumpEqual) goto L0056;
            L003A: ShowMessage(player, String2003); // You've managed to unlock the gate.
16B6  0047 FF 76 08  push word [bp+0x8]
16B9  004A FF 76 06  push word [bp+0x6]
16BC  004D 0E     push cs
16BD  004E E8 C9 00  call 0x11a
            L0051: // NOP
            L0052: cx = PopStack(player);
            L0053: cx = PopStack(player);
            L0054: goto L0070;
16C5  0056 FF 76 08  push word [bp+0x8]
16C8  0059 FF 76 06  push word [bp+0x6]
16CB  005C 0E     push cs
16CC  005D E8 3A 00  call 0x9a
            L0060: // NOP
            L0061: cx = PopStack(player);
            L0062: cx = PopStack(player);
            L0063: ShowMessage(player, String2026); // One well skilled with lockpicks may be able to open this magnificent gate.
            L0070: return; // RETURN;
            // Extra data: 55 8B EC B8 42 00 50 C4 5E 06 26 FF 9F FC 00 59 5D CB 55 8B EC B8 01 00 50 50 33 C0 50 C4 5E 06 26 FF 1F 83 C4 06 5D CB 55 8B EC 33 C0 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 55 8B EC C4 5E 06 26 FF 5F 74 BB 04 00 99 F7 FB 50 C4 5E 06 26 FF 9F 90 00 59 5D CB 55 8B EC B8 71 20 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC C4 5E 06 26 FF 5F 74 50 C4 5E 06 26 FF 9F 94 00 59 B8 D0 07 50 C4 5E 06 26 FF 9F B4 00 59 B8 A1 20 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC B8 01 00 50 C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 C4 5E 06 26 FF 5F 2C 83 C4 06 5D CB 55 8B EC C4 5E 06 26 FF 5F 24 50 C4 5E 06 26 FF 5F 20 50 B8 01 00 50 C4 5E 06 26 FF 5F 30 83 C4 06 5D CB 
        }

        private void FnWTRFLOOR_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFloorObject(player, 0x03, 0x4B);
            L0014: SetFloorObject(player, 0x03, 0x5B);
            L0025: SetFloorObject(player, 0x03, 0x6B);
            L0036: SetFloorObject(player, 0x03, 0x7C);
            L0047: SetFloorObject(player, 0x03, 0x8C);
            L0058: SetFloorObject(player, 0x03, 0x8D);
            L0069: SetFloorObject(player, 0x03, 0x7E);
            L007A: SetFloorObject(player, 0x03, 0x7F);
            L008B: return; // RETURN;
        }

    }
}
