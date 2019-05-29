#pragma warning disable
using System.Collections.Generic;
using XPT.Legacy;
using XPT.Legacy.Entities;

namespace XPT.Legacy.Maps {
    class YserMap24 : AMapScripted {
        protected override int MapIndex => 24;
        protected override int RandomEncounterChance => 15;
        protected override int RandomEncounterExtraCount => 2;

        public YserMap24() {
            MapEvent01 = FnDROP_01;
            MapEvent02 = FnXOVER_02;
            MapEvent03 = FnXOVERON_03;
            MapEvent04 = FnXOVEROFF_04;
            MapEvent05 = FnVORANTI_05;
            MapEvent06 = FnMAGEOVRL_06;
            MapEvent07 = FnDRAWBRDG_07;
            MapEvent08 = FnCSTLGATE_08;
            MapEvent09 = FnVORANTI_09;
            MapEvent0A = FnZZYZX_0A;
            MapEvent0B = FnGRHALL_0B;
            MapEvent0D = FnZEPHYR_0D;
            MapEvent0E = FnLAVA_0E;
            MapEvent0F = FnTROLS_0F;
            MapEvent10 = FnDRTOVORA_10;
            MapEvent14 = FnHEAVFOUN_14;
            MapEvent15 = FnHEAVENCB_15;
            MapEvent16 = FnHEAVENCC_16;
            MapEvent18 = FnHEAVENCE_18;
            MapEvent1A = FnHEAVWIND_1A;
            MapEvent1B = FnTXTHEAV_1B;
            MapEvent1C = FnBDRHEAVA_1C;
            MapEvent1D = FnSDRHEAVE_1D;
            MapEvent1E = FnTEMPENCA_1E;
            MapEvent1F = FnTEMPENCB_1F;
            MapEvent20 = FnTEMPENCC_20;
            MapEvent21 = FnTEMPENCD_21;
            MapEvent22 = FnTEMPMAIN_22;
            MapEvent23 = FnTEMPWIND_23;
            MapEvent24 = FnFNTNHEAL_24;
            MapEvent25 = FnFNTNMANA_25;
            MapEvent26 = FnFNTNHEAL_26;
            MapEvent27 = FnEXODENCA_27;
            MapEvent28 = FnWINDENC_28;
            MapEvent29 = FnTXTEXOD_29;
            MapEvent2A = FnWINDENCA_2A;
            MapEvent2B = FnWINDENCB_2B;
            MapEvent2C = FnWINDENCC_2C;
            MapEvent2D = FnWINDENCD_2D;
            MapEvent2E = FnBDRWINDA_2E;
            MapEvent2F = FnBDRWINDB_2F;
            MapEvent30 = FnBDRWINDC_30;
            MapEvent31 = FnBDRWINDD_31;
            MapEvent32 = FnTXTWINDH_32;
            MapEvent33 = FnTROLENCA_33;
            MapEvent34 = FnTROLENCB_34;
            MapEvent36 = FnTXTTROLA_36;
            MapEvent37 = FnTXTTROLB_37;
            MapEvent38 = FnFNTNSTRN_38;
            MapEvent39 = FnBACKENCA_39;
            MapEvent3A = FnBACKENCB_3A;
            MapEvent3B = FnBACKENCC_3B;
            MapEvent3C = FnBACKENCD_3C;
            MapEvent3D = FnBACKENCE_3D;
            MapEvent48 = FnFNTNTROL_48;
            MapEvent49 = FnHELLWIND_49;
        }
        
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
        private void FnDROP_01(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String03FC); // You fall through the abyss and land in the lava below.
            L0010: DamagePlayer(player, GetMaxHits(player));
            L0021: return; // RETURN;
        }

        private void FnXOVER_02(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetCurrentTile(player), 0x0039);
            L000D: if (JumpNotEqual) goto L0063;
            L000F: RefreshCompareFlags(GetFlag(player, FlagTypeMap, 0x01));
            L0022: if (JumpEqual) goto L0043;
            L0024: SetFloorItem(player, 0x00, 0x39);
            L0034: ShowMessage(player, doMsgs, String0433); // A magical platform forms a bridge across the abyss.
            L0041: goto L0061;
            L0043: ShowMessage(player, doMsgs, String0467); // You will need help to cross the abyss.  This time you die.
            L0050: DamagePlayer(player, GetMaxHits(player));
            L0061: goto L009B;
            L0063: RefreshCompareFlags(GetFlag(player, FlagTypeMap, 0x01));
            L0076: if (JumpEqual) goto L008A;
            L0078: SetFloorItem(player, 0x00, 0x39);
            L0088: goto L009B;
            L008A: SetFloorItem(player, 0x01, 0x39);
            L009B: return; // RETURN;
        }

        private void FnXOVERON_03(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, FlagTypeMap, 0x01, 0x01);
            L0018: SetFloorItem(player, 0x00, 0x39);
            L0028: ShowMessage(player, doMsgs, String04A2); // Something strange happens!
            L0035: ShowMessage(player, doMsgs, String04BD); // When you step onto the stone, a magical platform appears nearby.
            L0042: return; // RETURN;
        }

        private void FnXOVEROFF_04(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetFlag(player, FlagTypeMap, 0x01, 0x00);
            L0017: SetFloorItem(player, 0x01, 0x39);
            L0028: ShowMessage(player, doMsgs, String04FE); // A magical platform nearby seems to disappear.
            L0035: return; // RETURN;
        }

        private void FnVORANTI_05(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String052C); // Many adventurers have been ambushed in VORANTI'S PASSAGE.
            L0010: TeleportParty(player, 0x34, 0x01, 0x4D, 0x01, type);
            L002B: return; // RETURN;
        }

        private void FnMAGEOVRL_06(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0566); // The passage leads to MAGE'S OVERLOOK.
            L0010: TeleportParty(player, 0x34, 0x01, 0x3D, 0x00, type);
            L002A: return; // RETURN;
        }

        private void FnDRAWBRDG_07(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String058C); // Iron rungs line an access shaft leading down to DRAWBRIDGE.
            L0010: TeleportParty(player, 0x36, 0x01, 0x6E, 0x02, type);
            L002B: return; // RETURN;
        }

        private void FnCSTLGATE_08(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String05C8); // The tunnels ahead leading to CASTLEGATE are well marked.
            L0010: TeleportParty(player, 0x36, 0x01, 0x4F, 0x00, type);
            L002A: return; // RETURN;
        }

        private void FnVORANTI_09(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0601); // VORANTI'S PASSAGE is home to Voranti, the Dark Dwarf Thief.
            L0010: TeleportParty(player, 0x34, 0x01, GetCurrentTile(player), 0x02, type);
            L002F: return; // RETURN;
        }

        private void FnZZYZX_0A(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String063D); // Dry desert winds parch your throat as you peer down the winding passages leading to ZZYZX.
            L0010: TeleportParty(player, 0x34, 0x01, 0xBC, 0x03, type);
            L002B: return; // RETURN;
        }

        private void FnGRHALL_0B(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0698); // In the days of Arnakkian Slowfoot, the citizens of the Kingdom gathered in festive celebrations.  The GREAT HALL welcomed them with magical games conjured by Arnakkian.
            L0010: TeleportParty(player, 0x35, 0x02, 0x40, 0x02, type);
            L002B: return; // RETURN;
        }

        private void FnZEPHYR_0D(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0741); // The ZEPHYR winds are known to be the swiftest of all the winds.
            L0010: TeleportParty(player, 0x34, 0x01, 0xC8, 0x01, type);
            L002B: return; // RETURN;
        }

        private void FnLAVA_0E(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0781); // You stumble into the lava pools.  You die.
            L0010: DamagePlayer(player, GetMaxHits(player));
            L0021: return; // RETURN;
        }

        private void FnTROLS_0F(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String07AC); // Past this doorway are the corridors known as TROLLS END.
            L0010: return; // RETURN;
        }

        private void FnDRTOVORA_10(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String07E5); // To enter VORANTI'S PASSAGE, you must use his key!
            L0010: ax = HasUsedItem(player, type, ref doMsgs, ItemVorantisKey, ItemVorantisKey);
            L0023: if (JumpEqual) goto L006E;
            L0025: ShowMessage(player, doMsgs, String0817); // You unlock the door.
            L0032: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0050: SetWallItem(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L006E: return; // RETURN;
        }

        private void FnHEAVFOUN_14(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: ShowMessage(player, doMsgs, String082C); // Clerical symbols decorate the marblework of Morgard's Fountain.
            L001D: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagLabryinthIIITeachSkill));
            L0030: if (JumpEqual) goto L0035;
            L0032: goto L011A;
            L0035: SetFlag(player, FlagTypeDungeon, FlagLabryinthIIITeachSkill, 0x01);
            L004A: RefreshCompareFlags(GetSkillLevel(player, 0x13));
            L0058: if (JumpNotEqual) goto L007B;
            L005A: SetSkillLevel(player, 0x13, 0x02);
            L006B: ShowMessage(player, doMsgs, String086C); // You gain the Reverie skill!
            L0078: goto L0118;
            L007B: RefreshCompareFlags(GetSkillLevel(player, 0x11));
            L0089: if (JumpNotEqual) goto L00AB;
            L008B: SetSkillLevel(player, 0x11, 0x02);
            L009C: ShowMessage(player, doMsgs, String0888); // You gain the Deflect Magic skill!
            L00A9: goto L0118;
            L00AB: RefreshCompareFlags(GetSkillLevel(player, 0x12));
            L00B9: if (JumpNotEqual) goto L00DB;
            L00BB: SetSkillLevel(player, 0x12, 0x02);
            L00CC: ShowMessage(player, doMsgs, String08AA); // You gain the Medic skill!
            L00D9: goto L0118;
            L00DB: RefreshCompareFlags(GetSkillLevel(player, 0x10));
            L00E9: if (JumpNotEqual) goto L010B;
            L00EB: SetSkillLevel(player, 0x10, 0x02);
            L00FC: ShowMessage(player, doMsgs, String08C4); // You gain the skill of Martial Arts!
            L0109: goto L0118;
            L010B: ShowMessage(player, doMsgs, String08E8); // The waters have no effect.
            L0118: goto L0127;
            L011A: ShowMessage(player, doMsgs, String0903); // The fountain appears to be dry.
            L0127: return; // RETURN;
        }

        private void FnHEAVENCB_15(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x20);
            L0015: AddEncounter(player, 0x02, 0x20);
            L0027: AddEncounter(player, 0x03, 0x1F);
            L0039: AddEncounter(player, 0x04, 0x1F);
            L004B: AddEncounter(player, 0x05, 0x21);
            L005D: AddEncounter(player, 0x06, 0x21);
            L006F: AddTreasure(player, 0x03E8, 0x00, 0x00, 0x00, 0x32, 0x49);
            L008F: return; // RETURN;
        }

        private void FnHEAVENCC_16(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x20);
            L0015: AddEncounter(player, 0x02, 0x20);
            L0027: AddEncounter(player, 0x03, 0x26);
            L0039: return; // RETURN;
        }

        private void FnHEAVENCE_18(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x1F);
            L0015: AddEncounter(player, 0x02, 0x1F);
            L0027: AddEncounter(player, 0x03, 0x27);
            L0039: AddEncounter(player, 0x04, 0x28);
            L004B: return; // RETURN;
        }

        private void FnHEAVWIND_1A(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetAlignment(player), 0x0001);
            L000E: if (JumpNotEqual) goto L004E;
            L0010: ShowMessage(player, doMsgs, String0923); // The fury of Heaven's Wind ripping through the corridor inflicts considerable damage.
            L001D: ax = GetCurrentHits(player);
            L0024: bx = 0x0005;
            L0027: dx = ax % bx; ax = ax / bx;
            L002A: DamagePlayer(player, ax);
            L004C: goto L005B;
            L004E: ShowMessage(player, doMsgs, String0987); // A peaceful breeze cools your soul
            L005B: return; // RETURN;
        }

        private void FnTXTHEAV_1B(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String09A9); // The forces of Chaos and Harmony compete in the cyclone known as HEAVENS FURY.
            L0010: return; // RETURN;
        }

        private void FnBDRHEAVA_1C(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(CheckStrength(player), 0x0014);
            L0012: if (JumpBelow) goto L0041;
            L0014: ShowMessage(player, doMsgs, String09F7); // You force the massive door open by sheer muscle power.
            L0021: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L003F: goto L004E;
            L0041: ShowMessage(player, doMsgs, String0A2E); // The door is stuck. You cannot force it open.
            L004E: return; // RETURN;
        }

        private void FnSDRHEAVE_1D(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(player, type, ref doMsgs, 0x0D), 0x000C);
            L0012: if (JumpNotBelow) goto L0039;
            L0014: RefreshCompareFlags(HasUsedSpell(player, type, ref doMsgs, 0x17));
            L0022: if (JumpNotEqual) goto L0039;
            L0024: ax = HasUsedItem(player, type, ref doMsgs, 0xBE, 0xBE);
            L0037: if (JumpEqual) goto L0064;
            L0039: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0057: ShowMessage(player, doMsgs, String0A5B); // You discover a secret door!
            L0064: return; // RETURN;
        }

        private void FnTEMPENCA_1E(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x17);
            L0015: AddEncounter(player, 0x02, 0x17);
            L0027: AddEncounter(player, 0x03, 0x17);
            L0039: AddEncounter(player, 0x04, 0x17);
            L004B: return; // RETURN;
        }

        private void FnTEMPENCB_1F(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x17);
            L0015: AddEncounter(player, 0x02, 0x17);
            L0027: AddEncounter(player, 0x04, 0x17);
            L0039: AddEncounter(player, 0x05, 0x18);
            L004B: AddEncounter(player, 0x06, 0x18);
            L005D: return; // RETURN;
        }

        private void FnTEMPENCC_20(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x18);
            L0015: AddEncounter(player, 0x02, 0x18);
            L0027: AddEncounter(player, 0x03, 0x24);
            L0039: AddEncounter(player, 0x04, 0x24);
            L004B: return; // RETURN;
        }

        private void FnTEMPENCD_21(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x17);
            L0015: AddEncounter(player, 0x02, 0x18);
            L0027: AddEncounter(player, 0x03, 0x1A);
            L0039: AddEncounter(player, 0x04, 0x16);
            L004B: return; // RETURN;
        }

        private void FnTEMPMAIN_22(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0A77); // Tempest unleashes its full torrent of wind as you approach!
            L0010: ShowMessage(player, doMsgs, String0AB3); // Then it reveals itself in material form.
            L001D: AddEncounter(player, 0x01, 0x08);
            L002F: AddEncounter(player, 0x02, 0x08);
            L0041: AddEncounter(player, 0x04, 0x25);
            L0053: AddEncounter(player, 0x05, 0x18);
            L0065: AddEncounter(player, 0x06, 0x18);
            L0077: ax = HasItem(player, ItemHarvestHorn);
            L0085: if (JumpEqual) goto L00A7;
            L0087: AddTreasure(player, 0x0000, 0x00, 0x00, 0x00, 0x00, 0x96);
            L00A5: goto L00C5;
            L00A7: AddTreasure(player, 0x0000, 0x00, 0x00, 0x00, 0x00, ItemHarvestHorn);
            L00C5: return; // RETURN;
        }

        private void FnTEMPWIND_23(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, ItemHarvestHorn);
            L0011: if (JumpEqual) goto L0022;
            L0013: ShowMessage(player, doMsgs, String0ADC); // The Harvest Horn protects you from the dangerous winds!
            L0020: goto L0054;
            L0022: ShowMessage(player, doMsgs, String0B14); // The Tempest Winds rip through your armor, causing many wounds!
            L002F: DamagePlayer(player, 0x0064);
            L0054: return; // RETURN;
        }

        private void FnFNTNHEAL_24(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: HealPlayer(player, (ushort)GetMaxHits(player));
            L0021: ShowMessage(player, doMsgs, String0B62); // The mystic waters of the Charter Fountain restore all your Health.
            L002E: return; // RETURN;
        }

        private void FnFNTNMANA_25(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: AddMana(player, 0x2710);
            L001D: ShowMessage(player, doMsgs, String0BA5); // The mystic waters of the Infinity Fountain restore your Mana.
            L002A: return; // RETURN;
        }

        private void FnFNTNHEAL_26(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: HealPlayer(player, (ushort)GetMaxHits(player));
            L0021: ShowMessage(player, doMsgs, String0BE3); // The sparkling waters of the Ariel Fountain heal your many wounds.
            L002E: return; // RETURN;
        }

        private void FnEXODENCA_27(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x03);
            L0015: AddEncounter(player, 0x02, 0x03);
            L0027: AddEncounter(player, 0x03, 0x03);
            L0039: AddEncounter(player, 0x04, 0x03);
            L004B: ax = HasItem(player, ItemKeyToBackAlley);
            L0059: if (JumpEqual) goto L007C;
            L005B: AddTreasure(player, 0x0000, 0x00, 0x00, 0x00, 0xB6, 0xD0);
            L007A: goto L009B;
            L007C: AddTreasure(player, 0x07D0, 0x00, 0x00, 0x00, 0x00, ItemKeyToBackAlley);
            L009B: return; // RETURN;
        }

        private void FnWINDENC_28(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x17);
            L0015: AddEncounter(player, 0x02, 0x17);
            L0027: AddEncounter(player, 0x03, 0x18);
            L0039: AddEncounter(player, 0x04, 0x18);
            L004B: return; // RETURN;
        }

        private void FnTXTEXOD_29(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x001E);
            L0010: ShowMessage(player, doMsgs, String0C25); // You encounter an Orc Ranger.
            L001D: ShowMessage(player, doMsgs, String0C42); // 'There is a great river in the dwarven lands below.  It seems to lead to a great chasm I could not cross.  A mage told me the chasm was called the Ageless Void.
            L002A: ShowMessage(player, doMsgs, String0CE3); // Be careful in the great river.  It drains your health for every step you take.'
            L0037: return; // RETURN;
        }

        private void FnWINDENCA_2A(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetRace(player));
            L000C: if (JumpEqual) goto L001A;
            L000E: Compare(GetRace(player), 0x0006);
            L0018: if (JumpNotEqual) goto L0072;
            L001A: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagModAttr_Map24Ini));
            L002D: if (JumpNotEqual) goto L0072;
            L002F: SetFlag(player, FlagTypeDungeon, FlagModAttr_Map24Ini, 0x01);
            L0044: ShowMessage(player, doMsgs, String0D33); // Your initiative in combat improves.
            L0051: ModifyAttribute(player, 0x03, 0x0003);
            L0072: return; // RETURN;
        }

        private void FnWINDENCB_2B(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0002);
            L000D: if (JumpEqual) goto L001B;
            L000F: Compare(GetRace(player), 0x0005);
            L0019: if (JumpNotEqual) goto L0066;
            L001B: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagModAttr_Map24Agi));
            L002E: if (JumpNotEqual) goto L0066;
            L0030: SetFlag(player, FlagTypeDungeon, FlagModAttr_Map24Agi, 0x01);
            L0045: ShowMessage(player, doMsgs, String0D68); // Your agility improves.
            L0052: ModifyAttribute(player, 0x02, 0x0003);
            L0066: return; // RETURN;
        }

        private void FnWINDENCC_2C(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0001);
            L000D: if (JumpEqual) goto L001B;
            L000F: Compare(GetRace(player), 0x0003);
            L0019: if (JumpNotEqual) goto L0072;
            L001B: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagModAttr_Map24Str));
            L002E: if (JumpNotEqual) goto L0072;
            L0030: SetFlag(player, FlagTypeDungeon, FlagModAttr_Map24Str, 0x01);
            L0045: ShowMessage(player, doMsgs, String0D90); // You feel much stronger.
            L0052: ModifyAttribute(player, 0x00, 0x0003);
            L0072: return; // RETURN;
        }

        private void FnWINDENCD_2D(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(player), 0x0007);
            L000D: if (JumpEqual) goto L001B;
            L000F: Compare(GetRace(player), 0x0004);
            L0019: if (JumpNotEqual) goto L0073;
            L001B: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagModAttr_Map24Def));
            L002E: if (JumpNotEqual) goto L0073;
            L0030: SetFlag(player, FlagTypeDungeon, FlagModAttr_Map24Def, 0x01);
            L0045: ShowMessage(player, doMsgs, String0DB9); // Your ability to defend yourself in combat improves.
            L0052: ModifyAttribute(player, 0x01, 0x0003);
            L0073: return; // RETURN;
        }

        private void FnBDRWINDA_2E(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0DFE); // The door is barred to all but Humans and Halflings.
            L0010: RefreshCompareFlags(GetRace(player));
            L0019: if (JumpEqual) goto L0027;
            L001B: Compare(GetRace(player), 0x0006);
            L0025: if (JumpNotEqual) goto L0052;
            L0027: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0045: ShowMessage(player, doMsgs, String0E32); // The enormous door opens for you.
            L0052: return; // RETURN;
        }

        private void FnBDRWINDB_2F(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0E53); // The door is barred to all but Elves and Gnomes.
            L0010: Compare(GetRace(player), 0x0002);
            L001A: if (JumpEqual) goto L0028;
            L001C: Compare(GetRace(player), 0x0005);
            L0026: if (JumpNotEqual) goto L0053;
            L0028: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0046: ShowMessage(player, doMsgs, String0E83); // The tremendous door swings open as you approach.
            L0053: return; // RETURN;
        }

        private void FnBDRWINDC_30(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0EB4); // The door is barred to all but Orcs and Trolls.
            L0010: Compare(GetRace(player), 0x0001);
            L001A: if (JumpEqual) goto L0028;
            L001C: Compare(GetRace(player), 0x0003);
            L0026: if (JumpNotEqual) goto L0053;
            L0028: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0046: ShowMessage(player, doMsgs, String0EE3); // The heavy door creaks open as you draw near.
            L0053: return; // RETURN;
        }

        private void FnBDRWINDD_31(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String0F10); // The door is barred to all but Gremlins and Dwarves.
            L0010: Compare(GetRace(player), 0x0004);
            L001A: if (JumpEqual) goto L0028;
            L001C: Compare(GetRace(player), 0x0007);
            L0026: if (JumpNotEqual) goto L0053;
            L0028: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0046: ShowMessage(player, doMsgs, String0F44); // The sealed door opens at your command.
            L0053: return; // RETURN;
        }

        private void FnTXTWINDH_32(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0028);
            L0010: ShowMessage(player, doMsgs, String0F6B); // A Troll Cleric comes hobbling by.
            L001D: ShowMessage(player, doMsgs, String0F8D); // 'I found an interesting tapestry past one of the dwarven teleports.  It had a picture of a great moon, just like the one in the sky, but different.'
            L002A: return; // RETURN;
        }

        private void FnTROLENCA_33(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x21);
            L0015: AddEncounter(player, 0x02, 0x21);
            L0027: AddEncounter(player, 0x03, 0x1D);
            L0039: AddEncounter(player, 0x04, 0x1E);
            L004B: return; // RETURN;
        }

        private void FnTROLENCB_34(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x1D);
            L0015: AddEncounter(player, 0x02, 0x1D);
            L0027: AddEncounter(player, 0x03, 0x1C);
            L0039: AddEncounter(player, 0x04, 0x26);
            L004B: AddEncounter(player, 0x05, 0x1C);
            L005D: AddEncounter(player, 0x06, 0x1E);
            L006F: AddTreasure(player, 0x03E8, 0x00, 0x00, 0x2B, 0x5D, 0x87);
            L0090: return; // RETURN;
        }

        private void FnTXTTROLA_36(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String1022); // Next to bones is a message scratched on stone -- 
            L0010: ShowMessage(player, doMsgs, String1054); // 'Mortal wounds I have suffered.  But I shall pass on a gem of knowledge before I die.
            L001D: ShowMessage(player, doMsgs, String10AA); // To cross the void and challenge En-Li-Kil, you must see the rainbow.'
            L002A: return; // RETURN;
        }

        private void FnTXTTROLB_37(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, doMsgs, String10F0); // Behind a loose stone is a note.  You can barely read -- 
            L0010: ShowMessage(player, doMsgs, String1129); // 'Death to those who help the Snow Elves.' -- Nasranti, Mage Dwarf.
            L001D: return; // RETURN;
        }

        private void FnFNTNSTRN_38(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagModAttr_TrollFountain));
            L0023: if (JumpNotEqual) goto L006C;
            L0025: SetFlag(player, FlagTypeDungeon, FlagModAttr_TrollFountain, 0x01);
            L003A: ModifyAttribute(player, 0x00, 0x0002);
            L004B: ModifyAttribute(player, 0x01, 0x0002);
            L005D: ShowMessage(player, doMsgs, String116C); // The turgid water of the Troll Fountain tastes terrible, but it makes you feel stronger.
            L006A: goto L0079;
            L006C: ShowMessage(player, doMsgs, String11C4); // The fountain waters taste awful and make you nauseated.
            L0079: return; // RETURN;
        }

        private void FnBACKENCA_39(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x16);
            L0015: AddEncounter(player, 0x02, 0x16);
            L0027: AddEncounter(player, 0x03, 0x21);
            L0039: AddEncounter(player, 0x04, 0x22);
            L004B: return; // RETURN;
        }

        private void FnBACKENCB_3A(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x21);
            L0015: AddEncounter(player, 0x02, 0x21);
            L0027: AddEncounter(player, 0x03, 0x24);
            L0039: AddEncounter(player, 0x04, 0x24);
            L004B: AddEncounter(player, 0x05, 0x24);
            L005D: return; // RETURN;
        }

        private void FnBACKENCC_3B(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: ShowMessage(player, doMsgs, String11FC); // Pictograms of Hunting Expeditions have been carved into the loose rock above StoneGiant Fountain. 
            L001D: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagLabryinthIIITeachSkill1));
            L0030: if (JumpEqual) goto L0035;
            L0032: goto L0118;
            L0035: SetFlag(player, FlagTypeDungeon, FlagLabryinthIIITeachSkill1, 0x01);
            L004A: RefreshCompareFlags(GetSkillLevel(player, 0x00));
            L0057: if (JumpNotEqual) goto L0079;
            L0059: SetSkillLevel(player, 0x00, 0x02);
            L0069: ShowMessage(player, doMsgs, String125F); // You gain the skill of Athletics!
            L0076: goto L0116;
            L0079: RefreshCompareFlags(GetSkillLevel(player, 0x02));
            L0087: if (JumpNotEqual) goto L00A9;
            L0089: SetSkillLevel(player, 0x02, 0x02);
            L009A: ShowMessage(player, doMsgs, String1280); // You gain the Berserker skill!
            L00A7: goto L0116;
            L00A9: RefreshCompareFlags(GetSkillLevel(player, 0x03));
            L00B7: if (JumpNotEqual) goto L00D9;
            L00B9: SetSkillLevel(player, 0x03, 0x02);
            L00CA: ShowMessage(player, doMsgs, String129E); // You gain the skill of Pursuit!
            L00D7: goto L0116;
            L00D9: RefreshCompareFlags(GetSkillLevel(player, 0x01));
            L00E7: if (JumpNotEqual) goto L0109;
            L00E9: SetSkillLevel(player, 0x01, 0x02);
            L00FA: ShowMessage(player, doMsgs, String12BD); // You gain the skill of Clubs and Axes!
            L0107: goto L0116;
            L0109: ShowMessage(player, doMsgs, String12E3); // The waters have no effect.
            L0116: goto L0125;
            L0118: ShowMessage(player, doMsgs, String12FE); // Dry rocks and stones fill the fountain basin.
            L0125: return; // RETURN;
        }

        private void FnBACKENCD_3C(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x21);
            L0015: AddEncounter(player, 0x02, 0x21);
            L0027: AddEncounter(player, 0x03, 0x21);
            L0039: AddEncounter(player, 0x04, 0x26);
            L004B: AddEncounter(player, 0x05, 0x23);
            L005D: AddEncounter(player, 0x06, 0x23);
            L006F: AddTreasure(player, 0x03E8, 0x00, 0xD0, 0xD1, 0x15, 0x70);
            L0091: return; // RETURN;
        }

        private void FnBACKENCE_3D(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x26);
            L0015: AddEncounter(player, 0x02, 0x26);
            L0027: AddEncounter(player, 0x03, 0x27);
            L0039: AddEncounter(player, 0x04, 0x27);
            L004B: AddEncounter(player, 0x05, 0x23);
            L005D: AddEncounter(player, 0x06, 0x23);
            L006F: AddTreasure(player, 0x05DC, 0x00, 0x00, 0x00, 0xCD, 0x45);
            L008F: return; // RETURN;
        }

        private void FnFNTNTROL_48(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0042);
            L0010: ShowMessage(player, doMsgs, String132C); // You drink from the crystal waters of My My Fountain.
            L001D: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagLabryinthIIIMyMyFountain));
            L0030: if (JumpEqual) goto L0035;
            L0032: goto L0240;
            L0035: SetFlag(player, FlagTypeDungeon, FlagLabryinthIIIMyMyFountain, 0x01);
            L004A: RefreshCompareFlags(GetSkillLevel(player, 0x04));
            L0058: if (JumpNotEqual) goto L007B;
            L005A: SetSkillLevel(player, 0x04, 0x02);
            L006B: ShowMessage(player, doMsgs, String1361); // You gain the skill of Leadership!
            L0078: goto L023E;
            L007B: RefreshCompareFlags(GetSkillLevel(player, 0x06));
            L0089: if (JumpNotEqual) goto L00AC;
            L008B: SetSkillLevel(player, 0x06, 0x02);
            L009C: ShowMessage(player, doMsgs, String1383); // You gain the skill of Binding!
            L00A9: goto L023E;
            L00AC: RefreshCompareFlags(GetSkillLevel(player, 0x05));
            L00BA: if (JumpNotEqual) goto L00DD;
            L00BC: SetSkillLevel(player, 0x05, 0x02);
            L00CD: ShowMessage(player, doMsgs, String13A2); // You gain the skill of Fencing!
            L00DA: goto L023E;
            L00DD: RefreshCompareFlags(GetSkillLevel(player, 0x07));
            L00EB: if (JumpNotEqual) goto L010E;
            L00ED: SetSkillLevel(player, 0x07, 0x02);
            L00FE: ShowMessage(player, doMsgs, String13C1); // You gain the skill of Intimidation!
            L010B: goto L023E;
            L010E: RefreshCompareFlags(GetSkillLevel(player, 0x02));
            L011C: if (JumpNotEqual) goto L013F;
            L011E: SetSkillLevel(player, 0x02, 0x02);
            L012F: ShowMessage(player, doMsgs, String13E5); // You gain the Berserker skill!
            L013C: goto L023E;
            L013F: RefreshCompareFlags(GetSkillLevel(player, 0x0A));
            L014D: if (JumpNotEqual) goto L0170;
            L014F: SetSkillLevel(player, 0x0A, 0x02);
            L0160: ShowMessage(player, doMsgs, String1403); // You gain the skill of Furtiveness!
            L016D: goto L023E;
            L0170: RefreshCompareFlags(GetSkillLevel(player, 0x0E));
            L017E: if (JumpNotEqual) goto L01A1;
            L0180: SetSkillLevel(player, 0x0E, 0x02);
            L0191: ShowMessage(player, doMsgs, String1426); // You gain the skill of Lockpicking!
            L019E: goto L023E;
            L01A1: RefreshCompareFlags(GetSkillLevel(player, 0x0F));
            L01AF: if (JumpNotEqual) goto L01D1;
            L01B1: SetSkillLevel(player, 0x0F, 0x02);
            L01C2: ShowMessage(player, doMsgs, String1449); // You gain the Pickpocket skill!
            L01CF: goto L023E;
            L01D1: RefreshCompareFlags(GetSkillLevel(player, 0x13));
            L01DF: if (JumpNotEqual) goto L0201;
            L01E1: SetSkillLevel(player, 0x13, 0x02);
            L01F2: ShowMessage(player, doMsgs, String1468); // You gain the Reverie skill!
            L01FF: goto L023E;
            L0201: RefreshCompareFlags(GetSkillLevel(player, 0x17));
            L020F: if (JumpNotEqual) goto L0231;
            L0211: SetSkillLevel(player, 0x17, 0x02);
            L0222: ShowMessage(player, doMsgs, String1484); // You gain the Deep Trance skill!
            L022F: goto L023E;
            L0231: ShowMessage(player, doMsgs, String14A4); // Nothing happens.
            L023E: goto L0262;
            L0240: SetFlag(player, FlagTypeDungeon, FlagLabryinthIIIMyMyFountain, 0x01);
            L0255: ShowMessage(player, doMsgs, String14B5); // The waters are refreshing, but not enlightening!
            L0262: return; // RETURN;
        }

        private void FnHELLWIND_49(ServerPlayer player, MapEventType type, bool doMsgs) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetAlignment(player));
            L000D: if (JumpNotEqual) goto L004D;
            L000F: ShowMessage(player, doMsgs, String14E6); // The full fury of Hell's Wind rips through the corridor, causing considerable damage.
            L001C: ax = GetMaxHits(player);
            L0023: bx = 0x0005;
            L0026: dx = ax % bx; ax = ax / bx;
            L0029: DamagePlayer(player, ax);
            L004B: goto L005A;
            L004D: ShowMessage(player, doMsgs, String154A); // A strengthening, benevolent breeze warms your blood!
            L005A: return; // RETURN;
        }

    }
}
