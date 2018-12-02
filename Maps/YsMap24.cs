#pragma warning disable
using XPT.WorldData;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap24 : AMapScripted {
        protected override int MapIndex => 24;
        protected override int RandomEncounterChance => 5;
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
        private void FnDROP_01(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String03FC); // You fall through the abyss and land in the lava below.
            L0010: DamagePlayer(party, GetMaxHits(party));
            L0021: return; // RETURN;
        }

        private void FnXOVER_02(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetCurrentTile(party), 0x0039);
            L000D: if (JumpNotEqual) goto L0063;
            L000F: RefreshCompareFlags(GetState(party, 0x01, 0x01));
            L0022: if (JumpEqual) goto L0043;
            L0024: SetFloorObject(party, 0x00, 0x39);
            L0034: ShowMessage(party, String0433); // A magical platform forms a bridge across the abyss.
            L0041: goto L0061;
            L0043: ShowMessage(party, String0467); // You will need help to cross the abyss.  This time you die.
            L0050: DamagePlayer(party, GetMaxHits(party));
            L0061: goto L009B;
            L0063: RefreshCompareFlags(GetState(party, 0x01, 0x01));
            L0076: if (JumpEqual) goto L008A;
            L0078: SetFloorObject(party, 0x00, 0x39);
            L0088: goto L009B;
            L008A: SetFloorObject(party, 0x01, 0x39);
            L009B: return; // RETURN;
        }

        private void FnXOVERON_03(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetState(party, 0x01, 0x01, 0x01);
            L0018: SetFloorObject(party, 0x00, 0x39);
            L0028: ShowMessage(party, String04A2); // Something strange happens!
            L0035: ShowMessage(party, String04BD); // When you step onto the stone, a magical platform appears nearby.
            L0042: return; // RETURN;
        }

        private void FnXOVEROFF_04(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: SetState(party, 0x01, 0x01, 0x00);
            L0017: SetFloorObject(party, 0x01, 0x39);
            L0028: ShowMessage(party, String04FE); // A magical platform nearby seems to disappear.
            L0035: return; // RETURN;
        }

        private void FnVORANTI_05(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String052C); // Many adventurers have been ambushed in VORANTI'S PASSAGE.
            L0010: TeleportParty(party, 0x34, 0x01, 0x4D, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnMAGEOVRL_06(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0566); // The passage leads to MAGE'S OVERLOOK.
            L0010: TeleportParty(party, 0x34, 0x01, 0x3D, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void FnDRAWBRDG_07(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String058C); // Iron rungs line an access shaft leading down to DRAWBRIDGE.
            L0010: TeleportParty(party, 0x36, 0x01, 0x6E, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnCSTLGATE_08(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String05C8); // The tunnels ahead leading to CASTLEGATE are well marked.
            L0010: TeleportParty(party, 0x36, 0x01, 0x4F, 0x00, isForwardMove);
            L002A: return; // RETURN;
        }

        private void FnVORANTI_09(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0601); // VORANTI'S PASSAGE is home to Voranti, the Dark Dwarf Thief.
            L0010: TeleportParty(party, 0x34, 0x01, GetCurrentTile(party), 0x02, isForwardMove);
            L002F: return; // RETURN;
        }

        private void FnZZYZX_0A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String063D); // Dry desert winds parch your throat as you peer down the winding passages leading to ZZYZX.
            L0010: TeleportParty(party, 0x34, 0x01, 0xBC, 0x03, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnGRHALL_0B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0698); // In the days of Arnakkian Slowfoot, the citizens of the Kingdom gathered in festive celebrations.  The GREAT HALL welcomed them with magical games conjured by Arnakkian.
            L0010: TeleportParty(party, 0x35, 0x02, 0x40, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnZEPHYR_0D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0741); // The ZEPHYR winds are known to be the swiftest of all the winds.
            L0010: TeleportParty(party, 0x34, 0x01, 0xC8, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void FnLAVA_0E(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0781); // You stumble into the lava pools.  You die.
            L0010: DamagePlayer(party, GetMaxHits(party));
            L0021: return; // RETURN;
        }

        private void FnTROLS_0F(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String07AC); // Past this doorway are the corridors known as TROLLS END.
            L0010: return; // RETURN;
        }

        private void FnDRTOVORA_10(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String07E5); // To enter VORANTI'S PASSAGE, you must use his key!
            L0010: ax = HasUsedItem(party, 0xDF, 0xDF);
            L0023: if (JumpEqual) goto L006E;
            L0025: ShowMessage(party, String0817); // You unlock the door.
            L0032: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L0050: SetWallObject(party, 0x01, GetCurrentTile(party), GetFacing(party));
            L006E: return; // RETURN;
        }

        private void FnHEAVFOUN_14(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0042);
            L0010: ShowMessage(party, String082C); // Clerical symbols decorate the marblework of Morgard's Fountain.
            L001D: RefreshCompareFlags(GetState(party, 0x02, 0x61));
            L0030: if (JumpEqual) goto L0035;
            L0032: goto L011A;
            L0035: SetState(party, 0x02, 0x61, 0x01);
            L004A: RefreshCompareFlags(GetSkillLevel(party, 0x13));
            L0058: if (JumpNotEqual) goto L007B;
            L005A: SetSkillLevel(party, 0x13, 0x02);
            L006B: ShowMessage(party, String086C); // You gain the Reverie skill!
            L0078: goto L0118;
            L007B: RefreshCompareFlags(GetSkillLevel(party, 0x11));
            L0089: if (JumpNotEqual) goto L00AB;
            L008B: SetSkillLevel(party, 0x11, 0x02);
            L009C: ShowMessage(party, String0888); // You gain the Deflect Magic skill!
            L00A9: goto L0118;
            L00AB: RefreshCompareFlags(GetSkillLevel(party, 0x12));
            L00B9: if (JumpNotEqual) goto L00DB;
            L00BB: SetSkillLevel(party, 0x12, 0x02);
            L00CC: ShowMessage(party, String08AA); // You gain the Medic skill!
            L00D9: goto L0118;
            L00DB: RefreshCompareFlags(GetSkillLevel(party, 0x10));
            L00E9: if (JumpNotEqual) goto L010B;
            L00EB: SetSkillLevel(party, 0x10, 0x02);
            L00FC: ShowMessage(party, String08C4); // You gain the skill of Martial Arts!
            L0109: goto L0118;
            L010B: ShowMessage(party, String08E8); // The waters have no effect.
            L0118: goto L0127;
            L011A: ShowMessage(party, String0903); // The fountain appears to be dry.
            L0127: return; // RETURN;
        }

        private void FnHEAVENCB_15(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x20);
            L0015: AddEncounter(party, 0x02, 0x20);
            L0027: AddEncounter(party, 0x03, 0x1F);
            L0039: AddEncounter(party, 0x04, 0x1F);
            L004B: AddEncounter(party, 0x05, 0x21);
            L005D: AddEncounter(party, 0x06, 0x21);
            L006F: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x00, 0x32, 0x49);
            L008F: return; // RETURN;
        }

        private void FnHEAVENCC_16(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x20);
            L0015: AddEncounter(party, 0x02, 0x20);
            L0027: AddEncounter(party, 0x03, 0x26);
            L0039: return; // RETURN;
        }

        private void FnHEAVENCE_18(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x1F);
            L0015: AddEncounter(party, 0x02, 0x1F);
            L0027: AddEncounter(party, 0x03, 0x27);
            L0039: AddEncounter(party, 0x04, 0x28);
            L004B: return; // RETURN;
        }

        private void FnHEAVWIND_1A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetAlignment(party), 0x0001);
            L000E: if (JumpNotEqual) goto L004E;
            L0010: ShowMessage(party, String0923); // The fury of Heaven's Wind ripping through the corridor inflicts considerable damage.
            L001D: ax = GetCurrentHits(party);
            L0024: bx = 0x0005;
            L0027: dx = ax % bx; ax = ax / bx;
            L002A: DamagePlayer(party, ax);
            L0034: RefreshCompareFlags(GetCurrentHits(party));
            L003D: if (JumpAbove) goto L004C;
            L003F: ShowMessage(party, String0978); // You have died.
            L004C: goto L005B;
            L004E: ShowMessage(party, String0987); // A peaceful breeze cools your soul
            L005B: return; // RETURN;
        }

        private void FnTXTHEAV_1B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String09A9); // The forces of Chaos and Harmony compete in the cyclone known as HEAVENS FURY.
            L0010: return; // RETURN;
        }

        private void FnBDRHEAVA_1C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(CheckStrength(party), 0x0014);
            L0012: if (JumpBelow) goto L0041;
            L0014: ShowMessage(party, String09F7); // You force the massive door open by sheer muscle power.
            L0021: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L003F: goto L004E;
            L0041: ShowMessage(party, String0A2E); // The door is stuck. You cannot force it open.
            L004E: return; // RETURN;
        }

        private void FnSDRHEAVE_1D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(HasUsedSkill(party, 0x0D), 0x000C);
            L0012: if (JumpNotBelow) goto L0039;
            L0014: RefreshCompareFlags(HasUsedSpell(party, 0x17));
            L0022: if (JumpNotEqual) goto L0039;
            L0024: ax = HasUsedItem(party, 0xBE, 0xBE);
            L0037: if (JumpEqual) goto L0064;
            L0039: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L0057: ShowMessage(party, String0A5B); // You discover a secret door!
            L0064: return; // RETURN;
        }

        private void FnTEMPENCA_1E(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x17);
            L0015: AddEncounter(party, 0x02, 0x17);
            L0027: AddEncounter(party, 0x03, 0x17);
            L0039: AddEncounter(party, 0x04, 0x17);
            L004B: return; // RETURN;
        }

        private void FnTEMPENCB_1F(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x17);
            L0015: AddEncounter(party, 0x02, 0x17);
            L0027: AddEncounter(party, 0x04, 0x17);
            L0039: AddEncounter(party, 0x05, 0x18);
            L004B: AddEncounter(party, 0x06, 0x18);
            L005D: return; // RETURN;
        }

        private void FnTEMPENCC_20(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x18);
            L0015: AddEncounter(party, 0x02, 0x18);
            L0027: AddEncounter(party, 0x03, 0x24);
            L0039: AddEncounter(party, 0x04, 0x24);
            L004B: return; // RETURN;
        }

        private void FnTEMPENCD_21(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x17);
            L0015: AddEncounter(party, 0x02, 0x18);
            L0027: AddEncounter(party, 0x03, 0x1A);
            L0039: AddEncounter(party, 0x04, 0x16);
            L004B: return; // RETURN;
        }

        private void FnTEMPMAIN_22(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0A77); // Tempest unleashes its full torrent of wind as you approach!
            L0010: ShowMessage(party, String0AB3); // Then it reveals itself in material form.
            L001D: AddEncounter(party, 0x01, 0x08);
            L002F: AddEncounter(party, 0x02, 0x08);
            L0041: AddEncounter(party, 0x04, 0x25);
            L0053: AddEncounter(party, 0x05, 0x18);
            L0065: AddEncounter(party, 0x06, 0x18);
            L0077: ax = HasItem(party, 0xE6);
            L0085: if (JumpEqual) goto L00A7;
            L0087: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0x00, 0x96);
            L00A5: goto L00C5;
            L00A7: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0x00, 0xE6);
            L00C5: return; // RETURN;
        }

        private void FnTEMPWIND_23(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(party, 0xE6);
            L0011: if (JumpEqual) goto L0022;
            L0013: ShowMessage(party, String0ADC); // The Harvest Horn protects you from the dangerous winds!
            L0020: goto L0054;
            L0022: ShowMessage(party, String0B14); // The Tempest Winds rip through your armor, causing many wounds!
            L002F: DamagePlayer(party, 0x0064);
            L003C: RefreshCompareFlags(GetCurrentHits(party));
            L0045: if (JumpAbove) goto L0054;
            L0047: ShowMessage(party, String0B53); // You have died.
            L0054: return; // RETURN;
        }

        private void FnFNTNHEAL_24(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0042);
            L0010: HealPlayer(party, GetMaxHits(party));
            L0021: ShowMessage(party, String0B62); // The mystic waters of the Charter Fountain restore all your Health.
            L002E: return; // RETURN;
        }

        private void FnFNTNMANA_25(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0042);
            L0010: AddMana(party, 0x2710);
            L001D: ShowMessage(party, String0BA5); // The mystic waters of the Infinity Fountain restore your Mana.
            L002A: return; // RETURN;
        }

        private void FnFNTNHEAL_26(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0042);
            L0010: HealPlayer(party, GetMaxHits(party));
            L0021: ShowMessage(party, String0BE3); // The sparkling waters of the Ariel Fountain heal your many wounds.
            L002E: return; // RETURN;
        }

        private void FnEXODENCA_27(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x03);
            L0015: AddEncounter(party, 0x02, 0x03);
            L0027: AddEncounter(party, 0x03, 0x03);
            L0039: AddEncounter(party, 0x04, 0x03);
            L004B: ax = HasItem(party, 0xE0);
            L0059: if (JumpEqual) goto L007C;
            L005B: AddTreasure(party, 0x0000, 0x00, 0x00, 0x00, 0xB6, 0xD0);
            L007A: goto L009B;
            L007C: AddTreasure(party, 0x07D0, 0x00, 0x00, 0x00, 0x00, 0xE0);
            L009B: return; // RETURN;
        }

        private void FnWINDENC_28(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x17);
            L0015: AddEncounter(party, 0x02, 0x17);
            L0027: AddEncounter(party, 0x03, 0x18);
            L0039: AddEncounter(party, 0x04, 0x18);
            L004B: return; // RETURN;
        }

        private void FnTXTEXOD_29(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x001E);
            L0010: ShowMessage(party, String0C25); // You encounter an Orc Ranger.
            L001D: ShowMessage(party, String0C42); // 'There is a great river in the dwarven lands below.  It seems to lead to a great chasm I could not cross.  A mage told me the chasm was called the Ageless Void.
            L002A: ShowMessage(party, String0CE3); // Be careful in the great river.  It drains your health for every step you take.'
            L0037: return; // RETURN;
        }

        private void FnWINDENCA_2A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetRace(party));
            L000C: if (JumpEqual) goto L001A;
            L000E: Compare(GetRace(party), 0x0006);
            L0018: if (JumpNotEqual) goto L0072;
            L001A: RefreshCompareFlags(GetState(party, 0x02, 0x5A));
            L002D: if (JumpNotEqual) goto L0065;
            L002F: SetState(party, 0x02, 0x5A, 0x01);
            L0044: ShowMessage(party, String0D33); // Your initiative in combat improves.
            L0051: ModifyAttribute(party, 0x03, 0x0003);
            L0063: goto L0072;
            L0065: ShowMessage(party, String0D57); // Nothing happens.
            L0072: return; // RETURN;
        }

        private void FnWINDENCB_2B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(party), 0x0002);
            L000D: if (JumpEqual) goto L001B;
            L000F: Compare(GetRace(party), 0x0005);
            L0019: if (JumpNotEqual) goto L0073;
            L001B: RefreshCompareFlags(GetState(party, 0x02, 0x5B));
            L002E: if (JumpNotEqual) goto L0066;
            L0030: SetState(party, 0x02, 0x5B, 0x01);
            L0045: ShowMessage(party, String0D68); // Your agility improves.
            L0052: ModifyAttribute(party, 0x02, 0x0003);
            L0064: goto L0073;
            L0066: ShowMessage(party, String0D7F); // Nothing happens.
            L0073: return; // RETURN;
        }

        private void FnWINDENCC_2C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(party), 0x0001);
            L000D: if (JumpEqual) goto L001B;
            L000F: Compare(GetRace(party), 0x0003);
            L0019: if (JumpNotEqual) goto L0072;
            L001B: RefreshCompareFlags(GetState(party, 0x02, 0x5C));
            L002E: if (JumpNotEqual) goto L0065;
            L0030: SetState(party, 0x02, 0x5C, 0x01);
            L0045: ShowMessage(party, String0D90); // You feel much stronger.
            L0052: ModifyAttribute(party, 0x00, 0x0003);
            L0063: goto L0072;
            L0065: ShowMessage(party, String0DA8); // Nothing happens.
            L0072: return; // RETURN;
        }

        private void FnWINDENCD_2D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetRace(party), 0x0007);
            L000D: if (JumpEqual) goto L001B;
            L000F: Compare(GetRace(party), 0x0004);
            L0019: if (JumpNotEqual) goto L0073;
            L001B: RefreshCompareFlags(GetState(party, 0x02, 0x5D));
            L002E: if (JumpNotEqual) goto L0066;
            L0030: SetState(party, 0x02, 0x5D, 0x01);
            L0045: ShowMessage(party, String0DB9); // Your ability to defend yourself in combat improves.
            L0052: ModifyAttribute(party, 0x01, 0x0003);
            L0064: goto L0073;
            L0066: ShowMessage(party, String0DED); // Nothing happens.
            L0073: return; // RETURN;
        }

        private void FnBDRWINDA_2E(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0DFE); // The door is barred to all but Humans and Halflings.
            L0010: RefreshCompareFlags(GetRace(party));
            L0019: if (JumpEqual) goto L0027;
            L001B: Compare(GetRace(party), 0x0006);
            L0025: if (JumpNotEqual) goto L0052;
            L0027: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L0045: ShowMessage(party, String0E32); // The enormous door opens for you.
            L0052: return; // RETURN;
        }

        private void FnBDRWINDB_2F(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0E53); // The door is barred to all but Elves and Gnomes.
            L0010: Compare(GetRace(party), 0x0002);
            L001A: if (JumpEqual) goto L0028;
            L001C: Compare(GetRace(party), 0x0005);
            L0026: if (JumpNotEqual) goto L0053;
            L0028: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L0046: ShowMessage(party, String0E83); // The tremendous door swings open as you approach.
            L0053: return; // RETURN;
        }

        private void FnBDRWINDC_30(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0EB4); // The door is barred to all but Orcs and Trolls.
            L0010: Compare(GetRace(party), 0x0001);
            L001A: if (JumpEqual) goto L0028;
            L001C: Compare(GetRace(party), 0x0003);
            L0026: if (JumpNotEqual) goto L0053;
            L0028: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L0046: ShowMessage(party, String0EE3); // The heavy door creaks open as you draw near.
            L0053: return; // RETURN;
        }

        private void FnBDRWINDD_31(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String0F10); // The door is barred to all but Gremlins and Dwarves.
            L0010: Compare(GetRace(party), 0x0004);
            L001A: if (JumpEqual) goto L0028;
            L001C: Compare(GetRace(party), 0x0007);
            L0026: if (JumpNotEqual) goto L0053;
            L0028: SetWallPassable(party, GetCurrentTile(party), GetFacing(party), 0x01);
            L0046: ShowMessage(party, String0F44); // The sealed door opens at your command.
            L0053: return; // RETURN;
        }

        private void FnTXTWINDH_32(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0028);
            L0010: ShowMessage(party, String0F6B); // A Troll Cleric comes hobbling by.
            L001D: ShowMessage(party, String0F8D); // 'I found an interesting tapestry past one of the dwarven teleports.  It had a picture of a great moon, just like the one in the sky, but different.'
            L002A: return; // RETURN;
        }

        private void FnTROLENCA_33(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x21);
            L0015: AddEncounter(party, 0x02, 0x21);
            L0027: AddEncounter(party, 0x03, 0x1D);
            L0039: AddEncounter(party, 0x04, 0x1E);
            L004B: return; // RETURN;
        }

        private void FnTROLENCB_34(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x1D);
            L0015: AddEncounter(party, 0x02, 0x1D);
            L0027: AddEncounter(party, 0x03, 0x1C);
            L0039: AddEncounter(party, 0x04, 0x26);
            L004B: AddEncounter(party, 0x05, 0x1C);
            L005D: AddEncounter(party, 0x06, 0x1E);
            L006F: AddTreasure(party, 0x03E8, 0x00, 0x00, 0x2B, 0x5D, 0x87);
            L0090: return; // RETURN;
        }

        private void FnTXTTROLA_36(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String1022); // Next to bones is a message scratched on stone -- 
            L0010: ShowMessage(party, String1054); // 'Mortal wounds I have suffered.  But I shall pass on a gem of knowledge before I die.
            L001D: ShowMessage(party, String10AA); // To cross the void and challenge En-Li-Kil, you must see the rainbow.'
            L002A: return; // RETURN;
        }

        private void FnTXTTROLB_37(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(party, String10F0); // Behind a loose stone is a note.  You can barely read -- 
            L0010: ShowMessage(party, String1129); // 'Death to those who help the Snow Elves.' -- Nasranti, Mage Dwarf.
            L001D: return; // RETURN;
        }

        private void FnFNTNSTRN_38(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0042);
            L0010: RefreshCompareFlags(GetState(party, 0x02, 0x4A));
            L0023: if (JumpNotEqual) goto L006C;
            L0025: SetState(party, 0x02, 0x4A, 0x01);
            L003A: ModifyAttribute(party, 0x00, 0x0002);
            L004B: ModifyAttribute(party, 0x01, 0x0002);
            L005D: ShowMessage(party, String116C); // The turgid water of the Troll Fountain tastes terrible, but it makes you feel stronger.
            L006A: goto L0079;
            L006C: ShowMessage(party, String11C4); // The fountain waters taste awful and make you nauseated.
            L0079: return; // RETURN;
        }

        private void FnBACKENCA_39(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x16);
            L0015: AddEncounter(party, 0x02, 0x16);
            L0027: AddEncounter(party, 0x03, 0x21);
            L0039: AddEncounter(party, 0x04, 0x22);
            L004B: return; // RETURN;
        }

        private void FnBACKENCB_3A(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x21);
            L0015: AddEncounter(party, 0x02, 0x21);
            L0027: AddEncounter(party, 0x03, 0x24);
            L0039: AddEncounter(party, 0x04, 0x24);
            L004B: AddEncounter(party, 0x05, 0x24);
            L005D: return; // RETURN;
        }

        private void FnBACKENCC_3B(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0042);
            L0010: ShowMessage(party, String11FC); // Pictograms of Hunting Expeditions have been carved into the loose rock above StoneGiant Fountain. 
            L001D: RefreshCompareFlags(GetState(party, 0x02, 0x62));
            L0030: if (JumpEqual) goto L0035;
            L0032: goto L0118;
            L0035: SetState(party, 0x02, 0x62, 0x01);
            L004A: RefreshCompareFlags(GetSkillLevel(party, 0x00));
            L0057: if (JumpNotEqual) goto L0079;
            L0059: SetSkillLevel(party, 0x00, 0x02);
            L0069: ShowMessage(party, String125F); // You gain the skill of Athletics!
            L0076: goto L0116;
            L0079: RefreshCompareFlags(GetSkillLevel(party, 0x02));
            L0087: if (JumpNotEqual) goto L00A9;
            L0089: SetSkillLevel(party, 0x02, 0x02);
            L009A: ShowMessage(party, String1280); // You gain the Berserker skill!
            L00A7: goto L0116;
            L00A9: RefreshCompareFlags(GetSkillLevel(party, 0x03));
            L00B7: if (JumpNotEqual) goto L00D9;
            L00B9: SetSkillLevel(party, 0x03, 0x02);
            L00CA: ShowMessage(party, String129E); // You gain the skill of Pursuit!
            L00D7: goto L0116;
            L00D9: RefreshCompareFlags(GetSkillLevel(party, 0x01));
            L00E7: if (JumpNotEqual) goto L0109;
            L00E9: SetSkillLevel(party, 0x01, 0x02);
            L00FA: ShowMessage(party, String12BD); // You gain the skill of Clubs and Axes!
            L0107: goto L0116;
            L0109: ShowMessage(party, String12E3); // The waters have no effect.
            L0116: goto L0125;
            L0118: ShowMessage(party, String12FE); // Dry rocks and stones fill the fountain basin.
            L0125: return; // RETURN;
        }

        private void FnBACKENCD_3C(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x21);
            L0015: AddEncounter(party, 0x02, 0x21);
            L0027: AddEncounter(party, 0x03, 0x21);
            L0039: AddEncounter(party, 0x04, 0x26);
            L004B: AddEncounter(party, 0x05, 0x23);
            L005D: AddEncounter(party, 0x06, 0x23);
            L006F: AddTreasure(party, 0x03E8, 0x00, 0xD0, 0xD1, 0x15, 0x70);
            L0091: return; // RETURN;
        }

        private void FnBACKENCE_3D(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(party, 0x01, 0x26);
            L0015: AddEncounter(party, 0x02, 0x26);
            L0027: AddEncounter(party, 0x03, 0x27);
            L0039: AddEncounter(party, 0x04, 0x27);
            L004B: AddEncounter(party, 0x05, 0x23);
            L005D: AddEncounter(party, 0x06, 0x23);
            L006F: AddTreasure(party, 0x05DC, 0x00, 0x00, 0x00, 0xCD, 0x45);
            L008F: return; // RETURN;
        }

        private void FnFNTNTROL_48(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(party, 0x0042);
            L0010: ShowMessage(party, String132C); // You drink from the crystal waters of My My Fountain.
            L001D: RefreshCompareFlags(GetState(party, 0x02, 0x4B));
            L0030: if (JumpEqual) goto L0035;
            L0032: goto L0240;
            L0035: SetState(party, 0x02, 0x4B, 0x01);
            L004A: RefreshCompareFlags(GetSkillLevel(party, 0x04));
            L0058: if (JumpNotEqual) goto L007B;
            L005A: SetSkillLevel(party, 0x04, 0x02);
            L006B: ShowMessage(party, String1361); // You gain the skill of Leadership!
            L0078: goto L023E;
            L007B: RefreshCompareFlags(GetSkillLevel(party, 0x06));
            L0089: if (JumpNotEqual) goto L00AC;
            L008B: SetSkillLevel(party, 0x06, 0x02);
            L009C: ShowMessage(party, String1383); // You gain the skill of Binding!
            L00A9: goto L023E;
            L00AC: RefreshCompareFlags(GetSkillLevel(party, 0x05));
            L00BA: if (JumpNotEqual) goto L00DD;
            L00BC: SetSkillLevel(party, 0x05, 0x02);
            L00CD: ShowMessage(party, String13A2); // You gain the skill of Fencing!
            L00DA: goto L023E;
            L00DD: RefreshCompareFlags(GetSkillLevel(party, 0x07));
            L00EB: if (JumpNotEqual) goto L010E;
            L00ED: SetSkillLevel(party, 0x07, 0x02);
            L00FE: ShowMessage(party, String13C1); // You gain the skill of Intimidation!
            L010B: goto L023E;
            L010E: RefreshCompareFlags(GetSkillLevel(party, 0x02));
            L011C: if (JumpNotEqual) goto L013F;
            L011E: SetSkillLevel(party, 0x02, 0x02);
            L012F: ShowMessage(party, String13E5); // You gain the Berserker skill!
            L013C: goto L023E;
            L013F: RefreshCompareFlags(GetSkillLevel(party, 0x0A));
            L014D: if (JumpNotEqual) goto L0170;
            L014F: SetSkillLevel(party, 0x0A, 0x02);
            L0160: ShowMessage(party, String1403); // You gain the skill of Furtiveness!
            L016D: goto L023E;
            L0170: RefreshCompareFlags(GetSkillLevel(party, 0x0E));
            L017E: if (JumpNotEqual) goto L01A1;
            L0180: SetSkillLevel(party, 0x0E, 0x02);
            L0191: ShowMessage(party, String1426); // You gain the skill of Lockpicking!
            L019E: goto L023E;
            L01A1: RefreshCompareFlags(GetSkillLevel(party, 0x0F));
            L01AF: if (JumpNotEqual) goto L01D1;
            L01B1: SetSkillLevel(party, 0x0F, 0x02);
            L01C2: ShowMessage(party, String1449); // You gain the Pickpocket skill!
            L01CF: goto L023E;
            L01D1: RefreshCompareFlags(GetSkillLevel(party, 0x13));
            L01DF: if (JumpNotEqual) goto L0201;
            L01E1: SetSkillLevel(party, 0x13, 0x02);
            L01F2: ShowMessage(party, String1468); // You gain the Reverie skill!
            L01FF: goto L023E;
            L0201: RefreshCompareFlags(GetSkillLevel(party, 0x17));
            L020F: if (JumpNotEqual) goto L0231;
            L0211: SetSkillLevel(party, 0x17, 0x02);
            L0222: ShowMessage(party, String1484); // You gain the Deep Trance skill!
            L022F: goto L023E;
            L0231: ShowMessage(party, String14A4); // Nothing happens.
            L023E: goto L0262;
            L0240: SetState(party, 0x02, 0x4B, 0x01);
            L0255: ShowMessage(party, String14B5); // The waters are refreshing, but not enlightening!
            L0262: return; // RETURN;
        }

        private void FnHELLWIND_49(ServerMobile party, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetAlignment(party));
            L000D: if (JumpNotEqual) goto L004D;
            L000F: ShowMessage(party, String14E6); // The full fury of Hell's Wind rips through the corridor, causing considerable damage.
            L001C: ax = GetMaxHits(party);
            L0023: bx = 0x0005;
            L0026: dx = ax % bx; ax = ax / bx;
            L0029: DamagePlayer(party, ax);
            L0033: RefreshCompareFlags(GetCurrentHits(party));
            L003C: if (JumpAbove) goto L004B;
            L003E: ShowMessage(party, String153B); // You have died.
            L004B: goto L005A;
            L004D: ShowMessage(party, String154A); // A strengthening, benevolent breeze warms your blood!
            L005A: return; // RETURN;
        }

    }
}
