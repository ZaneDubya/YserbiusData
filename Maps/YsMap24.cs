namespace ZCF.Scripts.Maps {
    class YserMap24 : ACanoMapScript {
        // === Strings ================================================
        private const string String03FC = "You fall through the abyss and land in the lava below.";
        private const string String0433 = "A magical platform forms a bridge across the abyss.";
        private const string String0467 = "You will need help to cross the abyss.  This time you die.";
        private const string String04A2 = "Something strange happens!";
        private const string String04BD = "When you step onto the stone, a magical platform appears nearby.";
        private const string String04FE = "A magical platform nearby seems to disappear.";
        private const string String052C = "Many adventurers have been ambushed in VORANTI'S PASSAGE.";
        private const string String0566 = "The passage leads to MAGE'S OVERLOOK.";
        private const string String058C = "Iron rungs line an access shaft leading down to DRAWBRIDGE.";
        private const string String05C8 = "The tunnels ahead leading to CASTLEGATE are well marked.";
        private const string String0601 = "VORANTI'S PASSAGE is home to Voranti, the Dark Dwarf Thief.";
        private const string String063D = "Dry desert winds parch your throat as you peer down the winding passages leading to ZZYZX.";
        private const string String0698 = "In the days of Arnakkian Slowfoot, the citizens of the Kingdom gathered in festive celebrations.  The GREAT HALL welcomed them with magical games conjured by Arnakkian.";
        private const string String0741 = "The ZEPHYR winds are known to be the swiftest of all the winds.";
        private const string String0781 = "You stumble into the lava pools.  You die.";
        private const string String07AC = "Past this doorway are the corridors known as TROLLS END.";
        private const string String07E5 = "To enter VORANTI'S PASSAGE, you must use his key!";
        private const string String0817 = "You unlock the door.";
        private const string String082C = "Clerical symbols decorate the marblework of Morgard's Fountain.";
        private const string String086C = "You gain the Reverie skill!";
        private const string String0888 = "You gain the Deflect Magic skill!";
        private const string String08AA = "You gain the Medic skill!";
        private const string String08C4 = "You gain the skill of Martial Arts!";
        private const string String08E8 = "The waters have no effect.";
        private const string String0903 = "The fountain appears to be dry.";
        private const string String0923 = "The fury of Heaven's Wind ripping through the corridor inflicts considerable damage.";
        private const string String0978 = "You have died.";
        private const string String0987 = "A peaceful breeze cools your soul";
        private const string String09A9 = "The forces of Chaos and Harmony compete in the cyclone known as HEAVENS FURY.";
        private const string String09F7 = "You force the massive door open by sheer muscle power.";
        private const string String0A2E = "The door is stuck. You cannot force it open.";
        private const string String0A5B = "You discover a secret door!";
        private const string String0A77 = "Tempest unleashes its full torrent of wind as you approach!";
        private const string String0AB3 = "Then it reveals itself in material form.";
        private const string String0ADC = "The Harvest Horn protects you from the dangerous winds!";
        private const string String0B14 = "The Tempest Winds rip through your armor, causing many wounds!";
        private const string String0B53 = "You have died.";
        private const string String0B62 = "The mystic waters of the Charter Fountain restore all your Health.";
        private const string String0BA5 = "The mystic waters of the Infinity Fountain restore your Mana.";
        private const string String0BE3 = "The sparkling waters of the Ariel Fountain heal your many wounds.";
        private const string String0C25 = "You encounter an Orc Ranger.";
        private const string String0C42 = "'There is a great river in the dwarven lands below.  It seems to lead to a great chasm I could not cross.  A mage told me the chasm was called the Ageless Void.";
        private const string String0CE3 = "Be careful in the great river.  It drains your health for every step you take.'";
        private const string String0D33 = "Your initiative in combat improves.";
        private const string String0D57 = "Nothing happens.";
        private const string String0D68 = "Your agility improves.";
        private const string String0D7F = "Nothing happens.";
        private const string String0D90 = "You feel much stronger.";
        private const string String0DA8 = "Nothing happens.";
        private const string String0DB9 = "Your ability to defend yourself in combat improves.";
        private const string String0DED = "Nothing happens.";
        private const string String0DFE = "The door is barred to all but Humans and Halflings.";
        private const string String0E32 = "The enormous door opens for you.";
        private const string String0E53 = "The door is barred to all but Elves and Gnomes.";
        private const string String0E83 = "The tremendous door swings open as you approach.";
        private const string String0EB4 = "The door is barred to all but Orcs and Trolls.";
        private const string String0EE3 = "The heavy door creaks open as you draw near.";
        private const string String0F10 = "The door is barred to all but Gremlins and Dwarves.";
        private const string String0F44 = "The sealed door opens at your command.";
        private const string String0F6B = "A Troll Cleric comes hobbling by.";
        private const string String0F8D = "'I found an interesting tapestry past one of the dwarven teleports.  It had a picture of a great moon, just like the one in the sky, but different.'";
        private const string String1022 = "Next to bones is a message scratched on stone -- ";
        private const string String1054 = "'Mortal wounds I have suffered.  But I shall pass on a gem of knowledge before I die.";
        private const string String10AA = "To cross the void and challenge En-Li-Kil, you must see the rainbow.'";
        private const string String10F0 = "Behind a loose stone is a note.  You can barely read -- ";
        private const string String1129 = "'Death to those who help the Snow Elves.' -- Nasranti, Mage Dwarf.";
        private const string String116C = "The turgid water of the Troll Fountain tastes terrible, but it makes you feel stronger.";
        private const string String11C4 = "The fountain waters taste awful and make you nauseated.";
        private const string String11FC = "Pictograms of Hunting Expeditions have been carved into the loose rock above StoneGiant Fountain. ";
        private const string String125F = "You gain the skill of Athletics!";
        private const string String1280 = "You gain the Berserker skill!";
        private const string String129E = "You gain the skill of Pursuit!";
        private const string String12BD = "You gain the skill of Clubs and Axes!";
        private const string String12E3 = "The waters have no effect.";
        private const string String12FE = "Dry rocks and stones fill the fountain basin.";
        private const string String132C = "You drink from the crystal waters of My My Fountain.";
        private const string String1361 = "You gain the skill of Leadership!";
        private const string String1383 = "You gain the skill of Binding!";
        private const string String13A2 = "You gain the skill of Fencing!";
        private const string String13C1 = "You gain the skill of Intimidation!";
        private const string String13E5 = "You gain the Berserker skill!";
        private const string String1403 = "You gain the skill of Furtiveness!";
        private const string String1426 = "You gain the skill of Lockpicking!";
        private const string String1449 = "You gain the Pickpocket skill!";
        private const string String1468 = "You gain the Reverie skill!";
        private const string String1484 = "You gain the Deep Trance skill!";
        private const string String14A4 = "Nothing happens.";
        private const string String14B5 = "The waters are refreshing, but not enlightening!";
        private const string String14E6 = "The full fury of Hell's Wind rips through the corridor, causing considerable damage.";
        private const string String153B = "You have died.";
        private const string String154A = "A strengthening, benevolent breeze warms your blood!";
        
        // === Functions ================================================
        private override MapEventHandler MapEvent01 => DROP_01;
        private void DROP_01(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String03FC); // You fall through the abyss and land in the lava below.
            L0010: ax = GetMaxHits74(party);
            L0017: DoDamage90(party, ax);
            L0021: // RETURN;
        }

        private override MapEventHandler MapEvent02 => XOVER_02;
        private void XOVER_02(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetNextTile20(party);
            L000A: compare(ax, 0x0039);
            L000D: if (result.notequal) goto L0063;
            L000F: ax = CheckState04(party, 0x01, 0x01);
            L0020: RefreshCompareFlags(ax);
            L0022: if (result.equal) goto L0043;
            L0024: SetMove38(party, 0x39, 0x00);
            L0034: ShowMessage(party, String0433); // A magical platform forms a bridge across the abyss.
            L0041: goto L0061;
            L0043: ShowMessage(party, String0467); // You will need help to cross the abyss.  This time you die.
            L0050: ax = GetMaxHits74(party);
            L0057: DoDamage90(party, ax);
            L0061: goto L009B;
            L0063: ax = CheckState04(party, 0x01, 0x01);
            L0074: RefreshCompareFlags(ax);
            L0076: if (result.equal) goto L008A;
            L0078: SetMove38(party, 0x39, 0x00);
            L0088: goto L009B;
            L008A: SetMove38(party, 0x39, 0x01);
            L009B: // RETURN;
        }

        private override MapEventHandler MapEvent03 => XOVERON_03;
        private void XOVERON_03(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetState00(party, 0x01, 0x01, 0x01);
            L0018: SetMove38(party, 0x39, 0x00);
            L0028: ShowMessage(party, String04A2); // Something strange happens!
            L0035: ShowMessage(party, String04BD); // When you step onto the stone, a magical platform appears nearby.
            L0042: // RETURN;
        }

        private override MapEventHandler MapEvent04 => XOVEROFF_04;
        private void XOVEROFF_04(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetState00(party, 0x01, 0x01, 0x00);
            L0017: SetMove38(party, 0x39, 0x01);
            L0028: ShowMessage(party, String04FE); // A magical platform nearby seems to disappear.
            L0035: // RETURN;
        }

        private override MapEventHandler MapEvent05 => VORANTI_05;
        private void VORANTI_05(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String052C); // Many adventurers have been ambushed in VORANTI'S PASSAGE.
            L0010: SetMoveMap(party, 0x01, 0x4D, 0x01, 0x34);
            L002B: // RETURN;
        }

        private override MapEventHandler MapEvent06 => MAGEOVRL_06;
        private void MAGEOVRL_06(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0566); // The passage leads to MAGE'S OVERLOOK.
            L0010: SetMoveMap(party, 0x00, 0x3D, 0x01, 0x34);
            L002A: // RETURN;
        }

        private override MapEventHandler MapEvent07 => DRAWBRDG_07;
        private void DRAWBRDG_07(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String058C); // Iron rungs line an access shaft leading down to DRAWBRIDGE.
            L0010: SetMoveMap(party, 0x02, 0x6E, 0x01, 0x36);
            L002B: // RETURN;
        }

        private override MapEventHandler MapEvent08 => CSTLGATE_08;
        private void CSTLGATE_08(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String05C8); // The tunnels ahead leading to CASTLEGATE are well marked.
            L0010: SetMoveMap(party, 0x00, 0x4F, 0x01, 0x36);
            L002A: // RETURN;
        }

        private override MapEventHandler MapEvent09 => VORANTI_09;
        private void VORANTI_09(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0601); // VORANTI'S PASSAGE is home to Voranti, the Dark Dwarf Thief.
            L0010: Push(02);
            L0014: ax = GetNextTile20(party);
            L001B: SetMoveMap(party, PopStack(), ax, 0x01, 0x34);
            L002F: // RETURN;
        }

        private override MapEventHandler MapEvent0A => ZZYZX_0A;
        private void ZZYZX_0A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String063D); // Dry desert winds parch your throat as you peer down the winding passages leading to ZZYZX.
            L0010: SetMoveMap(party, 0x03, 0xBC, 0x01, 0x34);
            L002B: // RETURN;
        }

        private override MapEventHandler MapEvent0B => GRHALL_0B;
        private void GRHALL_0B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0698); // In the days of Arnakkian Slowfoot, the citizens of the Kingdom gathered in festive celebrations.  The GREAT HALL welcomed them with magical games conjured by Arnakkian.
            L0010: SetMoveMap(party, 0x02, 0x40, 0x02, 0x35);
            L002B: // RETURN;
        }

        private override MapEventHandler MapEvent0D => ZEPHYR_0D;
        private void ZEPHYR_0D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0741); // The ZEPHYR winds are known to be the swiftest of all the winds.
            L0010: SetMoveMap(party, 0x01, 0xC8, 0x01, 0x34);
            L002B: // RETURN;
        }

        private override MapEventHandler MapEvent0E => LAVA_0E;
        private void LAVA_0E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0781); // You stumble into the lava pools.  You die.
            L0010: ax = GetMaxHits74(party);
            L0017: DoDamage90(party, ax);
            L0021: // RETURN;
        }

        private override MapEventHandler MapEvent0F => TROLS_0F;
        private void TROLS_0F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String07AC); // Past this doorway are the corridors known as TROLLS END.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent10 => DRTOVORA_10;
        private void DRTOVORA_10(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String07E5); // To enter VORANTI'S PASSAGE, you must use his key!
            L0010: ax = UsedItem54(party, 0xDF, 0xDF);
            L0023: if (result.equal) goto L006E;
            L0025: ShowMessage(party, String0817); // You unlock the door.
            L0032: Push(01);
            L0036: ax = GetFacing24(party);
            L003D: PushStack(ax);
            L003E: ax = GetNextTile20(party);
            L0045: PushStack(ax);
            L0046: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0050: ax = GetFacing24(party);
            L0057: PushStack(ax);
            L0058: ax = GetNextTile20(party);
            L005F: PushStack(ax);
            L0060: Push(01);
            L0064: SetUnblocked30(party);
            L006E: // RETURN;
        }

        private override MapEventHandler MapEvent14 => HEAVFOUN_14;
        private void HEAVFOUN_14(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0042);
            L0010: ShowMessage(party, String082C); // Clerical symbols decorate the marblework of Morgard's Fountain.
            L001D: ax = CheckState04(party, 0x02, 0x61);
            L002E: RefreshCompareFlags(ax);
            L0030: if (result.equal) goto L0035;
            L0032: goto L011A;
            L0035: SetState00(party, 0x02, 0x61, 0x01);
            L004A: ax = GetSkillLevel5C(party, 0x13);
            L0056: RefreshCompareFlags(ax);
            L0058: if (result.notequal) goto L007B;
            L005A: SetSkillLevel60(party, 0x13, 0x02);
            L006B: ShowMessage(party, String086C); // You gain the Reverie skill!
            L0078: goto L0118;
            L007B: ax = GetSkillLevel5C(party, 0x11);
            L0087: RefreshCompareFlags(ax);
            L0089: if (result.notequal) goto L00AB;
            L008B: SetSkillLevel60(party, 0x11, 0x02);
            L009C: ShowMessage(party, String0888); // You gain the Deflect Magic skill!
            L00A9: goto L0118;
            L00AB: ax = GetSkillLevel5C(party, 0x12);
            L00B7: RefreshCompareFlags(ax);
            L00B9: if (result.notequal) goto L00DB;
            L00BB: SetSkillLevel60(party, 0x12, 0x02);
            L00CC: ShowMessage(party, String08AA); // You gain the Medic skill!
            L00D9: goto L0118;
            L00DB: ax = GetSkillLevel5C(party, 0x10);
            L00E7: RefreshCompareFlags(ax);
            L00E9: if (result.notequal) goto L010B;
            L00EB: SetSkillLevel60(party, 0x10, 0x02);
            L00FC: ShowMessage(party, String08C4); // You gain the skill of Martial Arts!
            L0109: goto L0118;
            L010B: ShowMessage(party, String08E8); // The waters have no effect.
            L0118: goto L0127;
            L011A: ShowMessage(party, String0903); // The fountain appears to be dry.
            L0127: // RETURN;
        }

        private override MapEventHandler MapEvent15 => HEAVENCB_15;
        private void HEAVENCB_15(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x20, 0x01);
            L0015: AddEncounter(party, 0x20, 0x02);
            L0027: AddEncounter(party, 0x1F, 0x03);
            L0039: AddEncounter(party, 0x1F, 0x04);
            L004B: AddEncounter(party, 0x21, 0x05);
            L005D: AddEncounter(party, 0x21, 0x06);
            L006F: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x32, 0x49);
            L008F: // RETURN;
        }

        private override MapEventHandler MapEvent16 => HEAVENCC_16;
        private void HEAVENCC_16(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x20, 0x01);
            L0015: AddEncounter(party, 0x20, 0x02);
            L0027: AddEncounter(party, 0x26, 0x03);
            L0039: // RETURN;
        }

        private override MapEventHandler MapEvent18 => HEAVENCE_18;
        private void HEAVENCE_18(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x1F, 0x01);
            L0015: AddEncounter(party, 0x1F, 0x02);
            L0027: AddEncounter(party, 0x27, 0x03);
            L0039: AddEncounter(party, 0x28, 0x04);
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent1A => HEAVWIND_1A;
        private void HEAVWIND_1A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetAlignment80(party);
            L000B: compare(ax, 0x0001);
            L000E: if (result.notequal) goto L004E;
            L0010: ShowMessage(party, String0923); // The fury of Heaven's Wind ripping through the corridor inflicts considerable damage.
            L001D: ax = GetCurrentHits70(party);
            L0024: bx = 0x0005;
            L0027: dx = ax % bx; ax = ax / bx; // (signed, dx = quotient)
            L002A: DoDamage90(party, ax);
            L0034: ax = GetCurrentHits70(party);
            L003B: RefreshCompareFlags(ax);
            L003D: if (result.unsigned_greater_than) goto L004C;
            L003F: ShowMessage(party, String0978); // You have died.
            L004C: goto L005B;
            L004E: ShowMessage(party, String0987); // A peaceful breeze cools your soul
            L005B: // RETURN;
        }

        private override MapEventHandler MapEvent1B => TXTHEAV_1B;
        private void TXTHEAV_1B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String09A9); // The forces of Chaos and Harmony compete in the cyclone known as HEAVENS FURY.
            L0010: // RETURN;
        }

        private override MapEventHandler MapEvent1C => BDRHEAVA_1C;
        private void BDRHEAVA_1C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = CheckStrengthA4(party);
            L000F: compare(ax, 0x0014);
            L0012: if (result.below) goto L0041;
            L0014: ShowMessage(party, String09F7); // You force the massive door open by sheer muscle power.
            L0021: Push(01);
            L0025: ax = GetFacing24(party);
            L002C: PushStack(ax);
            L002D: ax = GetNextTile20(party);
            L0034: PushStack(ax);
            L0035: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L003F: goto L004E;
            L0041: ShowMessage(party, String0A2E); // The door is stuck. You cannot force it open.
            L004E: // RETURN;
        }

        private override MapEventHandler MapEvent1D => SDRHEAVE_1D;
        private void SDRHEAVE_1D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = UsedSkill58(party, 0x0D) // returns 0 if did not use, compares to 2nd op if did use;
            L000F: compare(ax, 0x000C);
            L0012: if (result.above or result.equal) goto L0039;
            L0014: ax = UsedSpell64(party, 0x17); // returns 0 if did not use on map, level if used
            L0020: RefreshCompareFlags(ax);
            L0022: if (result.notequal) goto L0039;
            L0024: ax = UsedItem54(party, 0xBE, 0xBE);
            L0037: if (result.equal) goto L0064;
            L0039: Push(01);
            L003D: ax = GetFacing24(party);
            L0044: PushStack(ax);
            L0045: ax = GetNextTile20(party);
            L004C: PushStack(ax);
            L004D: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0057: ShowMessage(party, String0A5B); // You discover a secret door!
            L0064: // RETURN;
        }

        private override MapEventHandler MapEvent1E => TEMPENCA_1E;
        private void TEMPENCA_1E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x17, 0x01);
            L0015: AddEncounter(party, 0x17, 0x02);
            L0027: AddEncounter(party, 0x17, 0x03);
            L0039: AddEncounter(party, 0x17, 0x04);
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent1F => TEMPENCB_1F;
        private void TEMPENCB_1F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x17, 0x01);
            L0015: AddEncounter(party, 0x17, 0x02);
            L0027: AddEncounter(party, 0x17, 0x04);
            L0039: AddEncounter(party, 0x18, 0x05);
            L004B: AddEncounter(party, 0x18, 0x06);
            L005D: // RETURN;
        }

        private override MapEventHandler MapEvent20 => TEMPENCC_20;
        private void TEMPENCC_20(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x18, 0x01);
            L0015: AddEncounter(party, 0x18, 0x02);
            L0027: AddEncounter(party, 0x24, 0x03);
            L0039: AddEncounter(party, 0x24, 0x04);
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent21 => TEMPENCD_21;
        private void TEMPENCD_21(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x17, 0x01);
            L0015: AddEncounter(party, 0x18, 0x02);
            L0027: AddEncounter(party, 0x1A, 0x03);
            L0039: AddEncounter(party, 0x16, 0x04);
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent22 => TEMPMAIN_22;
        private void TEMPMAIN_22(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0A77); // Tempest unleashes its full torrent of wind as you approach!
            L0010: ShowMessage(party, String0AB3); // Then it reveals itself in material form.
            L001D: AddEncounter(party, 0x08, 0x01);
            L002F: AddEncounter(party, 0x08, 0x02);
            L0041: AddEncounter(party, 0x25, 0x04);
            L0053: AddEncounter(party, 0x18, 0x05);
            L0065: AddEncounter(party, 0x18, 0x06);
            L0077: ax = HasItem50(party, 0xE6);
            L0085: if (result.equal) goto L00A7;
            L0087: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0x00, 0x96);
            L00A5: goto L00C5;
            L00A7: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0x00, 0xE6);
            L00C5: // RETURN;
        }

        private override MapEventHandler MapEvent23 => TEMPWIND_23;
        private void TEMPWIND_23(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem50(party, 0xE6);
            L0011: if (result.equal) goto L0022;
            L0013: ShowMessage(party, String0ADC); // The Harvest Horn protects you from the dangerous winds!
            L0020: goto L0054;
            L0022: ShowMessage(party, String0B14); // The Tempest Winds rip through your armor, causing many wounds!
            L002F: DoDamage90(party, 0x0064);
            L003C: ax = GetCurrentHits70(party);
            L0043: RefreshCompareFlags(ax);
            L0045: if (result.unsigned_greater_than) goto L0054;
            L0047: ShowMessage(party, String0B53); // You have died.
            L0054: // RETURN;
        }

        private override MapEventHandler MapEvent24 => FNTNHEAL_24;
        private void FNTNHEAL_24(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0042);
            L0010: ax = GetMaxHits74(party);
            L0017: AddHealth94(party, ax);
            L0021: ShowMessage(party, String0B62); // The mystic waters of the Charter Fountain restore all your Health.
            L002E: // RETURN;
        }

        private override MapEventHandler MapEvent25 => FNTNMANA_25;
        private void FNTNMANA_25(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0042);
            L0010: AddMana(party, 0x2710);
            L001D: ShowMessage(party, String0BA5); // The mystic waters of the Infinity Fountain restore your Mana.
            L002A: // RETURN;
        }

        private override MapEventHandler MapEvent26 => FNTNHEAL_26;
        private void FNTNHEAL_26(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0042);
            L0010: ax = GetMaxHits74(party);
            L0017: AddHealth94(party, ax);
            L0021: ShowMessage(party, String0BE3); // The sparkling waters of the Ariel Fountain heal your many wounds.
            L002E: // RETURN;
        }

        private override MapEventHandler MapEvent27 => EXODENCA_27;
        private void EXODENCA_27(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x03, 0x01);
            L0015: AddEncounter(party, 0x03, 0x02);
            L0027: AddEncounter(party, 0x03, 0x03);
            L0039: AddEncounter(party, 0x03, 0x04);
            L004B: ax = HasItem50(party, 0xE0);
            L0059: if (result.equal) goto L007C;
            L005B: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0xB6, 0xD0);
            L007A: goto L009B;
            L007C: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0xE0);
            L009B: // RETURN;
        }

        private override MapEventHandler MapEvent28 => WINDENC_28;
        private void WINDENC_28(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x17, 0x01);
            L0015: AddEncounter(party, 0x17, 0x02);
            L0027: AddEncounter(party, 0x18, 0x03);
            L0039: AddEncounter(party, 0x18, 0x04);
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent29 => TXTEXOD_29;
        private void TXTEXOD_29(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x001E);
            L0010: ShowMessage(party, String0C25); // You encounter an Orc Ranger.
            L001D: ShowMessage(party, String0C42); // 'There is a great river in the dwarven lands below.  It seems to lead to a great chasm I could not cross.  A mage told me the chasm was called the Ageless Void.
            L002A: ShowMessage(party, String0CE3); // Be careful in the great river.  It drains your health for every step you take.'
            L0037: // RETURN;
        }

        private override MapEventHandler MapEvent2A => WINDENCA_2A;
        private void WINDENCA_2A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetRace78(party);
            L000A: RefreshCompareFlags(ax);
            L000C: if (result.equal) goto L001A;
            L000E: ax = GetRace78(party);
            L0015: compare(ax, 0x0006);
            L0018: if (result.notequal) goto L0072;
            L001A: ax = CheckState04(party, 0x02, 0x5A);
            L002B: RefreshCompareFlags(ax);
            L002D: if (result.notequal) goto L0065;
            L002F: SetState00(party, 0x02, 0x5A, 0x01);
            L0044: ShowMessage(party, String0D33); // Your initiative in combat improves.
            L0051: ModifyAttributeA8(party, 0x03, 0x0003);
            L0063: goto L0072;
            L0065: ShowMessage(party, String0D57); // Nothing happens.
            L0072: // RETURN;
        }

        private override MapEventHandler MapEvent2B => WINDENCB_2B;
        private void WINDENCB_2B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetRace78(party);
            L000A: compare(ax, 0x0002);
            L000D: if (result.equal) goto L001B;
            L000F: ax = GetRace78(party);
            L0016: compare(ax, 0x0005);
            L0019: if (result.notequal) goto L0073;
            L001B: ax = CheckState04(party, 0x02, 0x5B);
            L002C: RefreshCompareFlags(ax);
            L002E: if (result.notequal) goto L0066;
            L0030: SetState00(party, 0x02, 0x5B, 0x01);
            L0045: ShowMessage(party, String0D68); // Your agility improves.
            L0052: ModifyAttributeA8(party, 0x02, 0x0003);
            L0064: goto L0073;
            L0066: ShowMessage(party, String0D7F); // Nothing happens.
            L0073: // RETURN;
        }

        private override MapEventHandler MapEvent2C => WINDENCC_2C;
        private void WINDENCC_2C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetRace78(party);
            L000A: compare(ax, 0x0001);
            L000D: if (result.equal) goto L001B;
            L000F: ax = GetRace78(party);
            L0016: compare(ax, 0x0003);
            L0019: if (result.notequal) goto L0072;
            L001B: ax = CheckState04(party, 0x02, 0x5C);
            L002C: RefreshCompareFlags(ax);
            L002E: if (result.notequal) goto L0065;
            L0030: SetState00(party, 0x02, 0x5C, 0x01);
            L0045: ShowMessage(party, String0D90); // You feel much stronger.
            L0052: ModifyAttributeA8(party, 0x00, 0x0003);
            L0063: goto L0072;
            L0065: ShowMessage(party, String0DA8); // Nothing happens.
            L0072: // RETURN;
        }

        private override MapEventHandler MapEvent2D => WINDENCD_2D;
        private void WINDENCD_2D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetRace78(party);
            L000A: compare(ax, 0x0007);
            L000D: if (result.equal) goto L001B;
            L000F: ax = GetRace78(party);
            L0016: compare(ax, 0x0004);
            L0019: if (result.notequal) goto L0073;
            L001B: ax = CheckState04(party, 0x02, 0x5D);
            L002C: RefreshCompareFlags(ax);
            L002E: if (result.notequal) goto L0066;
            L0030: SetState00(party, 0x02, 0x5D, 0x01);
            L0045: ShowMessage(party, String0DB9); // Your ability to defend yourself in combat improves.
            L0052: ModifyAttributeA8(party, 0x01, 0x0003);
            L0064: goto L0073;
            L0066: ShowMessage(party, String0DED); // Nothing happens.
            L0073: // RETURN;
        }

        private override MapEventHandler MapEvent2E => BDRWINDA_2E;
        private void BDRWINDA_2E(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0DFE); // The door is barred to all but Humans and Halflings.
            L0010: ax = GetRace78(party);
            L0017: RefreshCompareFlags(ax);
            L0019: if (result.equal) goto L0027;
            L001B: ax = GetRace78(party);
            L0022: compare(ax, 0x0006);
            L0025: if (result.notequal) goto L0052;
            L0027: Push(01);
            L002B: ax = GetFacing24(party);
            L0032: PushStack(ax);
            L0033: ax = GetNextTile20(party);
            L003A: PushStack(ax);
            L003B: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0045: ShowMessage(party, String0E32); // The enormous door opens for you.
            L0052: // RETURN;
        }

        private override MapEventHandler MapEvent2F => BDRWINDB_2F;
        private void BDRWINDB_2F(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0E53); // The door is barred to all but Elves and Gnomes.
            L0010: ax = GetRace78(party);
            L0017: compare(ax, 0x0002);
            L001A: if (result.equal) goto L0028;
            L001C: ax = GetRace78(party);
            L0023: compare(ax, 0x0005);
            L0026: if (result.notequal) goto L0053;
            L0028: Push(01);
            L002C: ax = GetFacing24(party);
            L0033: PushStack(ax);
            L0034: ax = GetNextTile20(party);
            L003B: PushStack(ax);
            L003C: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0046: ShowMessage(party, String0E83); // The tremendous door swings open as you approach.
            L0053: // RETURN;
        }

        private override MapEventHandler MapEvent30 => BDRWINDC_30;
        private void BDRWINDC_30(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0EB4); // The door is barred to all but Orcs and Trolls.
            L0010: ax = GetRace78(party);
            L0017: compare(ax, 0x0001);
            L001A: if (result.equal) goto L0028;
            L001C: ax = GetRace78(party);
            L0023: compare(ax, 0x0003);
            L0026: if (result.notequal) goto L0053;
            L0028: Push(01);
            L002C: ax = GetFacing24(party);
            L0033: PushStack(ax);
            L0034: ax = GetNextTile20(party);
            L003B: PushStack(ax);
            L003C: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0046: ShowMessage(party, String0EE3); // The heavy door creaks open as you draw near.
            L0053: // RETURN;
        }

        private override MapEventHandler MapEvent31 => BDRWINDD_31;
        private void BDRWINDD_31(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0F10); // The door is barred to all but Gremlins and Dwarves.
            L0010: ax = GetRace78(party);
            L0017: compare(ax, 0x0004);
            L001A: if (result.equal) goto L0028;
            L001C: ax = GetRace78(party);
            L0023: compare(ax, 0x0007);
            L0026: if (result.notequal) goto L0053;
            L0028: Push(01);
            L002C: ax = GetFacing24(party);
            L0033: PushStack(ax);
            L0034: ax = GetNextTile20(party);
            L003B: PushStack(ax);
            L003C: SetMove2C(party, PopStack(), PopStack(), PopStack());
            L0046: ShowMessage(party, String0F44); // The sealed door opens at your command.
            L0053: // RETURN;
        }

        private override MapEventHandler MapEvent32 => TXTWINDH_32;
        private void TXTWINDH_32(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0028);
            L0010: ShowMessage(party, String0F6B); // A Troll Cleric comes hobbling by.
            L001D: ShowMessage(party, String0F8D); // 'I found an interesting tapestry past one of the dwarven teleports.  It had a picture of a great moon, just like the one in the sky, but different.'
            L002A: // RETURN;
        }

        private override MapEventHandler MapEvent33 => TROLENCA_33;
        private void TROLENCA_33(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x21, 0x01);
            L0015: AddEncounter(party, 0x21, 0x02);
            L0027: AddEncounter(party, 0x1D, 0x03);
            L0039: AddEncounter(party, 0x1E, 0x04);
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent34 => TROLENCB_34;
        private void TROLENCB_34(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x1D, 0x01);
            L0015: AddEncounter(party, 0x1D, 0x02);
            L0027: AddEncounter(party, 0x1C, 0x03);
            L0039: AddEncounter(party, 0x26, 0x04);
            L004B: AddEncounter(party, 0x1C, 0x05);
            L005D: AddEncounter(party, 0x1E, 0x06);
            L006F: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x2B, 0x5D, 0x87);
            L0090: // RETURN;
        }

        private override MapEventHandler MapEvent36 => TXTTROLA_36;
        private void TXTTROLA_36(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1022); // Next to bones is a message scratched on stone -- 
            L0010: ShowMessage(party, String1054); // 'Mortal wounds I have suffered.  But I shall pass on a gem of knowledge before I die.
            L001D: ShowMessage(party, String10AA); // To cross the void and challenge En-Li-Kil, you must see the rainbow.'
            L002A: // RETURN;
        }

        private override MapEventHandler MapEvent37 => TXTTROLB_37;
        private void TXTTROLB_37(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String10F0); // Behind a loose stone is a note.  You can barely read -- 
            L0010: ShowMessage(party, String1129); // 'Death to those who help the Snow Elves.' -- Nasranti, Mage Dwarf.
            L001D: // RETURN;
        }

        private override MapEventHandler MapEvent38 => FNTNSTRN_38;
        private void FNTNSTRN_38(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0042);
            L0010: ax = CheckState04(party, 0x02, 0x4A);
            L0021: RefreshCompareFlags(ax);
            L0023: if (result.notequal) goto L006C;
            L0025: SetState00(party, 0x02, 0x4A, 0x01);
            L003A: ModifyAttributeA8(party, 0x00, 0x0002);
            L004B: ModifyAttributeA8(party, 0x01, 0x0002);
            L005D: ShowMessage(party, String116C); // The turgid water of the Troll Fountain tastes terrible, but it makes you feel stronger.
            L006A: goto L0079;
            L006C: ShowMessage(party, String11C4); // The fountain waters taste awful and make you nauseated.
            L0079: // RETURN;
        }

        private override MapEventHandler MapEvent39 => BACKENCA_39;
        private void BACKENCA_39(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x16, 0x01);
            L0015: AddEncounter(party, 0x16, 0x02);
            L0027: AddEncounter(party, 0x21, 0x03);
            L0039: AddEncounter(party, 0x22, 0x04);
            L004B: // RETURN;
        }

        private override MapEventHandler MapEvent3A => BACKENCB_3A;
        private void BACKENCB_3A(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x21, 0x01);
            L0015: AddEncounter(party, 0x21, 0x02);
            L0027: AddEncounter(party, 0x24, 0x03);
            L0039: AddEncounter(party, 0x24, 0x04);
            L004B: AddEncounter(party, 0x24, 0x05);
            L005D: // RETURN;
        }

        private override MapEventHandler MapEvent3B => BACKENCC_3B;
        private void BACKENCC_3B(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0042);
            L0010: ShowMessage(party, String11FC); // Pictograms of Hunting Expeditions have been carved into the loose rock above StoneGiant Fountain. 
            L001D: ax = CheckState04(party, 0x02, 0x62);
            L002E: RefreshCompareFlags(ax);
            L0030: if (result.equal) goto L0035;
            L0032: goto L0118;
            L0035: SetState00(party, 0x02, 0x62, 0x01);
            L004A: ax = GetSkillLevel5C(party, 0x00);
            L0055: RefreshCompareFlags(ax);
            L0057: if (result.notequal) goto L0079;
            L0059: SetSkillLevel60(party, 0x00, 0x02);
            L0069: ShowMessage(party, String125F); // You gain the skill of Athletics!
            L0076: goto L0116;
            L0079: ax = GetSkillLevel5C(party, 0x02);
            L0085: RefreshCompareFlags(ax);
            L0087: if (result.notequal) goto L00A9;
            L0089: SetSkillLevel60(party, 0x02, 0x02);
            L009A: ShowMessage(party, String1280); // You gain the Berserker skill!
            L00A7: goto L0116;
            L00A9: ax = GetSkillLevel5C(party, 0x03);
            L00B5: RefreshCompareFlags(ax);
            L00B7: if (result.notequal) goto L00D9;
            L00B9: SetSkillLevel60(party, 0x03, 0x02);
            L00CA: ShowMessage(party, String129E); // You gain the skill of Pursuit!
            L00D7: goto L0116;
            L00D9: ax = GetSkillLevel5C(party, 0x01);
            L00E5: RefreshCompareFlags(ax);
            L00E7: if (result.notequal) goto L0109;
            L00E9: SetSkillLevel60(party, 0x01, 0x02);
            L00FA: ShowMessage(party, String12BD); // You gain the skill of Clubs and Axes!
            L0107: goto L0116;
            L0109: ShowMessage(party, String12E3); // The waters have no effect.
            L0116: goto L0125;
            L0118: ShowMessage(party, String12FE); // Dry rocks and stones fill the fountain basin.
            L0125: // RETURN;
        }

        private override MapEventHandler MapEvent3C => BACKENCD_3C;
        private void BACKENCD_3C(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x21, 0x01);
            L0015: AddEncounter(party, 0x21, 0x02);
            L0027: AddEncounter(party, 0x21, 0x03);
            L0039: AddEncounter(party, 0x26, 0x04);
            L004B: AddEncounter(party, 0x23, 0x05);
            L005D: AddEncounter(party, 0x23, 0x06);
            L006F: AddTreasure(party, 0x03E8, 0x00, 0xD0, 0xD1, 0x15, 0x70);
            L0091: // RETURN;
        }

        private override MapEventHandler MapEvent3D => BACKENCE_3D;
        private void BACKENCE_3D(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x26, 0x01);
            L0015: AddEncounter(party, 0x26, 0x02);
            L0027: AddEncounter(party, 0x27, 0x03);
            L0039: AddEncounter(party, 0x27, 0x04);
            L004B: AddEncounter(party, 0x23, 0x05);
            L005D: AddEncounter(party, 0x23, 0x06);
            L006F: AddTreasure(party, 0x05DC, 0x00, 0x00, 0x00, 0xCD, 0x45);
            L008F: // RETURN;
        }

        private override MapEventHandler MapEvent48 => FNTNTROL_48;
        private void FNTNTROL_48(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0042);
            L0010: ShowMessage(party, String132C); // You drink from the crystal waters of My My Fountain.
            L001D: ax = CheckState04(party, 0x02, 0x4B);
            L002E: RefreshCompareFlags(ax);
            L0030: if (result.equal) goto L0035;
            L0032: goto L0240;
            L0035: SetState00(party, 0x02, 0x4B, 0x01);
            L004A: ax = GetSkillLevel5C(party, 0x04);
            L0056: RefreshCompareFlags(ax);
            L0058: if (result.notequal) goto L007B;
            L005A: SetSkillLevel60(party, 0x04, 0x02);
            L006B: ShowMessage(party, String1361); // You gain the skill of Leadership!
            L0078: goto L023E;
            L007B: ax = GetSkillLevel5C(party, 0x06);
            L0087: RefreshCompareFlags(ax);
            L0089: if (result.notequal) goto L00AC;
            L008B: SetSkillLevel60(party, 0x06, 0x02);
            L009C: ShowMessage(party, String1383); // You gain the skill of Binding!
            L00A9: goto L023E;
            L00AC: ax = GetSkillLevel5C(party, 0x05);
            L00B8: RefreshCompareFlags(ax);
            L00BA: if (result.notequal) goto L00DD;
            L00BC: SetSkillLevel60(party, 0x05, 0x02);
            L00CD: ShowMessage(party, String13A2); // You gain the skill of Fencing!
            L00DA: goto L023E;
            L00DD: ax = GetSkillLevel5C(party, 0x07);
            L00E9: RefreshCompareFlags(ax);
            L00EB: if (result.notequal) goto L010E;
            L00ED: SetSkillLevel60(party, 0x07, 0x02);
            L00FE: ShowMessage(party, String13C1); // You gain the skill of Intimidation!
            L010B: goto L023E;
            L010E: ax = GetSkillLevel5C(party, 0x02);
            L011A: RefreshCompareFlags(ax);
            L011C: if (result.notequal) goto L013F;
            L011E: SetSkillLevel60(party, 0x02, 0x02);
            L012F: ShowMessage(party, String13E5); // You gain the Berserker skill!
            L013C: goto L023E;
            L013F: ax = GetSkillLevel5C(party, 0x0A);
            L014B: RefreshCompareFlags(ax);
            L014D: if (result.notequal) goto L0170;
            L014F: SetSkillLevel60(party, 0x0A, 0x02);
            L0160: ShowMessage(party, String1403); // You gain the skill of Furtiveness!
            L016D: goto L023E;
            L0170: ax = GetSkillLevel5C(party, 0x0E);
            L017C: RefreshCompareFlags(ax);
            L017E: if (result.notequal) goto L01A1;
            L0180: SetSkillLevel60(party, 0x0E, 0x02);
            L0191: ShowMessage(party, String1426); // You gain the skill of Lockpicking!
            L019E: goto L023E;
            L01A1: ax = GetSkillLevel5C(party, 0x0F);
            L01AD: RefreshCompareFlags(ax);
            L01AF: if (result.notequal) goto L01D1;
            L01B1: SetSkillLevel60(party, 0x0F, 0x02);
            L01C2: ShowMessage(party, String1449); // You gain the Pickpocket skill!
            L01CF: goto L023E;
            L01D1: ax = GetSkillLevel5C(party, 0x13);
            L01DD: RefreshCompareFlags(ax);
            L01DF: if (result.notequal) goto L0201;
            L01E1: SetSkillLevel60(party, 0x13, 0x02);
            L01F2: ShowMessage(party, String1468); // You gain the Reverie skill!
            L01FF: goto L023E;
            L0201: ax = GetSkillLevel5C(party, 0x17);
            L020D: RefreshCompareFlags(ax);
            L020F: if (result.notequal) goto L0231;
            L0211: SetSkillLevel60(party, 0x17, 0x02);
            L0222: ShowMessage(party, String1484); // You gain the Deep Trance skill!
            L022F: goto L023E;
            L0231: ShowMessage(party, String14A4); // Nothing happens.
            L023E: goto L0262;
            L0240: SetState00(party, 0x02, 0x4B, 0x01);
            L0255: ShowMessage(party, String14B5); // The waters are refreshing, but not enlightening!
            L0262: // RETURN;
        }

        private override MapEventHandler MapEvent49 => HELLWIND_49;
        private void HELLWIND_49(Party party) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = GetAlignment80(party);
            L000B: RefreshCompareFlags(ax);
            L000D: if (result.notequal) goto L004D;
            L000F: ShowMessage(party, String14E6); // The full fury of Hell's Wind rips through the corridor, causing considerable damage.
            L001C: ax = GetMaxHits74(party);
            L0023: bx = 0x0005;
            L0026: dx = ax % bx; ax = ax / bx; // (signed, dx = quotient)
            L0029: DoDamage90(party, ax);
            L0033: ax = GetCurrentHits70(party);
            L003A: RefreshCompareFlags(ax);
            L003C: if (result.unsigned_greater_than) goto L004B;
            L003E: ShowMessage(party, String153B); // You have died.
            L004B: goto L005A;
            L004D: ShowMessage(party, String154A); // A strengthening, benevolent breeze warms your blood!
            L005A: // RETURN;
        }

    }
}
