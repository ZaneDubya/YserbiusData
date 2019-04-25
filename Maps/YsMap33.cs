#pragma warning disable
using System.Collections.Generic;
using XPT.Legacy;
using XPT.Legacy.Entities;

namespace XPT.Legacy.Maps {
    class YserMap33 : AMapScripted {
        protected override int MapIndex => 33;
        protected override int RandomEncounterChance => 0;
        protected override int RandomEncounterExtraCount => 2;

        public YserMap33() {
            MapEvent01 = FnVOID_01;
            MapEvent02 = FnLIFE_02;
            MapEvent03 = FnTIMEA_03;
            MapEvent04 = FnTIMEB_04;
            MapEvent05 = FnTIMEC_05;
            MapEvent06 = FnTIMEELEM_06;
            MapEvent07 = FnTIMEPLAT_07;
            MapEvent08 = FnGOAL_08;
            MapEvent09 = FnENCA_09;
            MapEvent0A = FnENCB_0A;
            MapEvent0B = FnENCC_0B;
            MapEvent0C = FnENCD_0C;
            MapEvent0D = FnENCE_0D;
            MapEvent0E = FnENCF_0E;
            MapEvent0F = FnCROSSOVR_0F;
            MapEvent10 = FnMAPCONV_10;
            MapEvent12 = FnTELEBACK_12;
        }
        
        // === Strings ================================================
        private const string String03FC = "The Ageless Void swallows you whole.";
        private const string String0421 = "Time freezes forever in your mind.  To the rest of the world, you are dead.";
        private const string String046D = "You are dragged into the Waters of Death. Your death agonies are mercifully short.";
        private const string String04C0 = "The wall sparkles with phantasmal light.";
        private const string String04E9 = "A Timeswitch has been set.";
        private const string String0504 = "Two other Timeswitches must be set to reveal the platform.";
        private const string String053F = "The second Timeswitch has been set.";
        private const string String0563 = "The third and final Timeswitch has been set.";
        private const string String0590 = "All is deathly quiet near the Fountain of Life.";
        private const string String05C0 = "The wall sparkles with phantasmal light.";
        private const string String05E9 = "A Timeswitch has been set.";
        private const string String0604 = "Two other Timeswitches must be set to reveal the platform.";
        private const string String063F = "The second Timeswitch has been set.";
        private const string String0663 = "The third and final Timeswitch has been set.";
        private const string String0690 = "All is deathly quiet near the Fountain of Life.";
        private const string String06C0 = "The wall sparkles with phantasmal light.";
        private const string String06E9 = "A Timeswitch has been set.";
        private const string String0704 = "Two other Timeswitches must be set to reveal the platform.";
        private const string String073F = "The second Timeswitch has been set.";
        private const string String0763 = "The third and final Timeswitch has been set.";
        private const string String0790 = "All is deathly quiet near the Fountain of Life.";
        private const string String07C0 = "I am the Time Elemental, En-Li-Kil.";
        private const string String07E4 = "You have traveled far...only to die!";
        private const string String0809 = "Your arrival frees me from my long imprisonment here -- halfway between two worlds.";
        private const string String085D = "I destroyed that fool Arnakkian Slowfoot, and I shall destroy you as easily.";
        private const string String08AA = "Then I shall search out all mortals in your world and destroy them!";
        private const string String08EE = "I am En-Li-Kil!  The immortal!!!";
        private const string String090F = "You cross the Waters of Death safely.";
        private const string String0935 = "En-Li-Kil stands guard at the other side, protecting the Fountain of Life. This was the goal Arnakkian Slowfoot sought.";
        private const string String09AD = "You are dragged into the Waters of Death. Your death agonies are mercifully short.";
        private const string String0A00 = "You have found the Fountain of Life, but the waters are drained.";
        private const string String0A41 = "The Rainbow Gems and Golden Boat dissolve into dust.";
        private const string String0A76 = "Humiliating En-Li-Kil a second time is reward enough.";
        private const string String0AAC = "You stand on the Fountain of Life.";
        private const string String0ACF = "The Rainbow Gems and Golden Boat dissolve in the golden water.";
        private const string String0B0E = "You have defeated the Time Elemental En-Li-Kil.";
        private const string String0B3E = "You have won the game of life and death.  You are now a HERO OF YSERBIUS.";
        private const string String0B88 = "Return to your home safely now.";
        private const string String0BA8 = "Soon you will be able to leave the volcano Yserbius and begin a new life of adventure!";
        private const string String0BFF = "Farewell...this ending is just the beginning!!!";
        private const string String0C2F = "Across the Waters of Death at the center of this finite square is the Fountain of Life.";
        private const string String0C87 = "The Fountain is well guarded.";
        private const string String0CA5 = "You leave this dimension and re-enter your world.";
        
        // === Functions ================================================
        private void FnVOID_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String03FC); // The Ageless Void swallows you whole.
            L0010: ShowMessage(player, String0421); // Time freezes forever in your mind.  To the rest of the world, you are dead.
            L001D: DamagePlayer(player, GetMaxHits(player));
            L002E: return; // RETURN;
        }

        private void FnLIFE_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String046D); // You are dragged into the Waters of Death. Your death agonies are mercifully short.
            L0010: DamagePlayer(player, GetMaxHits(player));
            L0021: return; // RETURN;
        }

        private void FnTIMEA_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: SetFlag(player, FlagTypeDungeon, FlagUnknownSwitch1, 0x01);
            L001A: ShowMessage(player, String04C0); // The wall sparkles with phantasmal light.
            L0027: dx = GetFlag(player, FlagTypeDungeon, FlagUnknownSwitch1) + GetFlag(player, FlagTypeDungeon, FlagUnknownSwitch2) + GetFlag(player, FlagTypeDungeon, FlagUnknownSwitch3);
            L0062: tmp = dx;
            L0065: Compare(tmp, 0x0001);
            L006B: if (JumpEqual) goto L0079;
            L006D: Compare(ax, 0x0002);
            L0070: if (JumpEqual) goto L00A6;
            L0072: Compare(ax, 0x0003);
            L0075: if (JumpEqual) goto L00C6;
            L0077: goto L00E5;
            L0079: ShowMessage(player, String04E9); // A Timeswitch has been set.
            L0086: ShowMessage(player, String0504); // Two other Timeswitches must be set to reveal the platform.
            L0093: SetFloorItem(player, 0x03, 0xA8);
            L00A4: goto L00E5;
            L00A6: ShowMessage(player, String053F); // The second Timeswitch has been set.
            L00B3: SetFloorItem(player, 0x03, 0xA8);
            L00C4: goto L00E5;
            L00C6: ShowMessage(player, String0563); // The third and final Timeswitch has been set.
            L00D3: SetFloorItem(player, 0x00, 0xA8);
            L00E3: goto L00E5;
            L00E5: ShowMessage(player, String0590); // All is deathly quiet near the Fountain of Life.
            L00F2: // restore stack ptr: sp = bp;
            L00F4: return; // RETURN;
        }

        private void FnTIMEB_04(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: SetFlag(player, FlagTypeDungeon, FlagUnknownSwitch2, 0x01);
            L001A: ShowMessage(player, String05C0); // The wall sparkles with phantasmal light.
            L0027: dx = GetFlag(player, FlagTypeDungeon, FlagUnknownSwitch1) + GetFlag(player, FlagTypeDungeon, FlagUnknownSwitch2) + GetFlag(player, FlagTypeDungeon, FlagUnknownSwitch3);
            L0062: tmp = dx;
            L0065: Compare(tmp, 0x0001);
            L006B: if (JumpEqual) goto L0079;
            L006D: Compare(ax, 0x0002);
            L0070: if (JumpEqual) goto L00A6;
            L0072: Compare(ax, 0x0003);
            L0075: if (JumpEqual) goto L00C6;
            L0077: goto L00E5;
            L0079: ShowMessage(player, String05E9); // A Timeswitch has been set.
            L0086: ShowMessage(player, String0604); // Two other Timeswitches must be set to reveal the platform.
            L0093: SetFloorItem(player, 0x03, 0xA8);
            L00A4: goto L00E5;
            L00A6: ShowMessage(player, String063F); // The second Timeswitch has been set.
            L00B3: SetFloorItem(player, 0x03, 0xA8);
            L00C4: goto L00E5;
            L00C6: ShowMessage(player, String0663); // The third and final Timeswitch has been set.
            L00D3: SetFloorItem(player, 0x00, 0xA8);
            L00E3: goto L00E5;
            L00E5: ShowMessage(player, String0690); // All is deathly quiet near the Fountain of Life.
            L00F2: // restore stack ptr: sp = bp;
            L00F4: return; // RETURN;
        }

        private void FnTIMEC_05(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: SetFlag(player, FlagTypeDungeon, FlagUnknownSwitch3, 0x01);
            L001A: ShowMessage(player, String06C0); // The wall sparkles with phantasmal light.
            L0027: dx = GetFlag(player, FlagTypeDungeon, FlagUnknownSwitch1) + GetFlag(player, FlagTypeDungeon, FlagUnknownSwitch2);
            L004D: dx = dx + GetFlag(player, FlagTypeDungeon, FlagUnknownSwitch3);
            L0062: tmp = dx;
            L0065: Compare(tmp, 0x0001);
            L006B: if (JumpEqual) goto L0079;
            L006D: Compare(ax, 0x0002);
            L0070: if (JumpEqual) goto L00A6;
            L0072: Compare(ax, 0x0003);
            L0075: if (JumpEqual) goto L00C6;
            L0077: goto L00E5;
            L0079: ShowMessage(player, String06E9); // A Timeswitch has been set.
            L0086: ShowMessage(player, String0704); // Two other Timeswitches must be set to reveal the platform.
            L0093: SetFloorItem(player, 0x03, 0xA8);
            L00A4: goto L00E5;
            L00A6: ShowMessage(player, String073F); // The second Timeswitch has been set.
            L00B3: SetFloorItem(player, 0x03, 0xA8);
            L00C4: goto L00E5;
            L00C6: ShowMessage(player, String0763); // The third and final Timeswitch has been set.
            L00D3: SetFloorItem(player, 0x00, 0xA8);
            L00E3: goto L00E5;
            L00E5: ShowMessage(player, String0790); // All is deathly quiet near the Fountain of Life.
            L00F2: // restore stack ptr: sp = bp;
            L00F4: return; // RETURN;
        }

        private void FnTIMEELEM_06(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x0011);
            L0010: ShowMessage(player, String07C0); // I am the Time Elemental, En-Li-Kil.
            L001D: ShowMessage(player, String07E4); // You have traveled far...only to die!
            L002A: ShowMessage(player, String0809); // Your arrival frees me from my long imprisonment here -- halfway between two worlds.
            L0037: ShowMessage(player, String085D); // I destroyed that fool Arnakkian Slowfoot, and I shall destroy you as easily.
            L0044: ShowMessage(player, String08AA); // Then I shall search out all mortals in your world and destroy them!
            L0051: ShowMessage(player, String08EE); // I am En-Li-Kil!  The immortal!!!
            L005E: SetFlag(player, FlagTypeDungeon, FlagUnknownSwitch1, 0x00);
            L0072: SetFlag(player, FlagTypeDungeon, FlagUnknownSwitch2, 0x00);
            L0086: SetFlag(player, FlagTypeDungeon, FlagUnknownSwitch3, 0x00);
            L009A: AddEncounter(player, 0x01, 0x21);
            L00AC: AddEncounter(player, 0x02, 0x23);
            L00BE: AddEncounter(player, 0x03, 0x10);
            L00D0: AddEncounter(player, 0x04, 0x19);
            L00E2: AddEncounter(player, 0x06, 0x28);
            L00F4: return; // RETURN;
        }

        private void FnTIMEPLAT_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, FlagTypeMap, 0x00));
            L0015: if (JumpEqual) goto L007A;
            L0017: RefreshCompareFlags(GetFlag(player, FlagTypeMap, 0x01));
            L002A: if (JumpEqual) goto L007A;
            L002C: RefreshCompareFlags(GetFlag(player, FlagTypeMap, 0x02));
            L003F: if (JumpEqual) goto L007A;
            L0041: SetFloorItem(player, 0x00, 0xA8);
            L0051: ShowMessage(player, String090F); // You cross the Waters of Death safely.
            L005E: ShowMessage(player, String0935); // En-Li-Kil stands guard at the other side, protecting the Fountain of Life. This was the goal Arnakkian Slowfoot sought.
            L006B: ShowPortrait(player, 0x0042);
            L0078: goto L00A9;
            L007A: SetFloorItem(player, 0x03, 0xA8);
            L008B: ShowMessage(player, String09AD); // You are dragged into the Waters of Death. Your death agonies are mercifully short.
            L0098: DamagePlayer(player, GetMaxHits(player));
            L00A9: return; // RETURN;
        }

        private void FnGOAL_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RemoveItem(player, 0xF4);
            L000F: RemoveItem(player, 0xF5);
            L001B: RemoveItem(player, 0xF6);
            L0027: RemoveItem(player, 0xF7);
            L0033: RemoveItem(player, 0xF3);
            L003F: ax = IsFlagOn(player, FlagTypeDungeon, FlagDefeatedEnLiKil);
            L0052: if (JumpEqual) goto L007E;
            L0054: ShowMessage(player, String0A00); // You have found the Fountain of Life, but the waters are drained.
            L0061: ShowMessage(player, String0A41); // The Rainbow Gems and Golden Boat dissolve into dust.
            L006E: ShowMessage(player, String0A76); // Humiliating En-Li-Kil a second time is reward enough.
            L007B: goto L012A;
            L007E: ShowMessage(player, String0AAC); // You stand on the Fountain of Life.
            L008B: ShowMessage(player, String0ACF); // The Rainbow Gems and Golden Boat dissolve in the golden water.
            L0098: ShowMessage(player, String0B0E); // You have defeated the Time Elemental En-Li-Kil.
            L00A5: ShowMessage(player, String0B3E); // You have won the game of life and death.  You are now a HERO OF YSERBIUS.
            L00B2: ShowMessage(player, String0B88); // Return to your home safely now.
            L00BF: ShowMessage(player, String0BA8); // Soon you will be able to leave the volcano Yserbius and begin a new life of adventure!
            L00CC: ShowMessage(player, String0BFF); // Farewell...this ending is just the beginning!!!
            L00D9: RefreshCompareFlags(GetFlag(player, FlagTypeDungeon, FlagReceivedEnLiKilExperience));
            L00EC: if (JumpNotEqual) goto L012A;
            L00EE: SetFlag(player, FlagTypeDungeon, FlagReceivedEnLiKilExperience, 0x01);
            L0103: SetFlag(player, FlagTypeDungeon, FlagDefeatedEnLiKil, 0x01);
            L0118: AddExperience(player, 0x004C4B40);
            L012A: return; // RETURN;
        }

        private void FnENCA_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0C2F); // Across the Waters of Death at the center of this finite square is the Fountain of Life.
            L0010: ShowMessage(player, String0C87); // The Fountain is well guarded.
            L001D: AddEncounter(player, 0x01, 0x19);
            L002F: AddEncounter(player, 0x02, 0x1B);
            L0041: AddEncounter(player, 0x03, 0x19);
            L0053: AddEncounter(player, 0x04, 0x1B);
            L0065: AddEncounter(player, 0x05, 0x23);
            L0077: AddEncounter(player, 0x06, 0x1D);
            L0089: return; // RETURN;
        }

        private void FnENCB_0A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x08);
            L0015: AddEncounter(player, 0x02, 0x08);
            L0027: AddEncounter(player, 0x03, 0x24);
            L0039: AddEncounter(player, 0x04, 0x25);
            L004B: AddEncounter(player, 0x05, 0x26);
            L005D: AddEncounter(player, 0x06, 0x27);
            L006F: return; // RETURN;
        }

        private void FnENCC_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x1B);
            L0015: AddEncounter(player, 0x02, 0x1B);
            L0027: AddEncounter(player, 0x03, 0x1C);
            L0039: AddEncounter(player, 0x04, 0x1C);
            L004B: AddEncounter(player, 0x05, 0x1F);
            L005D: AddEncounter(player, 0x06, 0x1F);
            L006F: return; // RETURN;
        }

        private void FnENCD_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, FlagTypeMap, 0x7B));
            L0016: if (JumpEqual) goto L0052;
            L0018: RefreshCompareFlags(GetFlag(player, FlagTypeMap, 0x7C));
            L002B: if (JumpEqual) goto L0052;
            L002D: RefreshCompareFlags(GetFlag(player, FlagTypeMap, 0x7D));
            L0040: if (JumpEqual) goto L0052;
            L0042: SetFloorItem(player, 0x00, 0xA8);
            L0052: AddEncounter(player, 0x01, 0x19);
            L0064: AddEncounter(player, 0x02, 0x19);
            L0076: AddEncounter(player, 0x03, 0x1C);
            L0088: AddEncounter(player, 0x04, 0x1C);
            L009A: AddEncounter(player, 0x05, 0x1D);
            L00AC: AddEncounter(player, 0x06, 0x1D);
            L00BE: return; // RETURN;
        }

        private void FnENCE_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x1E);
            L0015: AddEncounter(player, 0x02, 0x1E);
            L0027: AddEncounter(player, 0x03, 0x20);
            L0039: AddEncounter(player, 0x04, 0x20);
            L004B: AddEncounter(player, 0x05, 0x18);
            L005D: AddEncounter(player, 0x06, 0x21);
            L006F: return; // RETURN;
        }

        private void FnENCF_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: AddEncounter(player, 0x01, 0x22);
            L0015: AddEncounter(player, 0x02, 0x22);
            L0027: AddEncounter(player, 0x03, 0x1F);
            L0039: AddEncounter(player, 0x04, 0x1F);
            L004B: AddEncounter(player, 0x05, 0x23);
            L005D: AddEncounter(player, 0x06, 0x23);
            L006F: return; // RETURN;
        }

        private void FnCROSSOVR_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: RefreshCompareFlags(GetFlag(player, FlagTypeMap, 0x00));
            L0015: if (JumpEqual) goto L0053;
            L0017: RefreshCompareFlags(GetFlag(player, FlagTypeMap, 0x01));
            L002A: if (JumpEqual) goto L0053;
            L002C: RefreshCompareFlags(GetFlag(player, FlagTypeMap, 0x02));
            L003F: if (JumpEqual) goto L0053;
            L0041: SetFloorItem(player, 0x00, 0xA8);
            L0051: goto L0064;
            L0053: SetFloorItem(player, 0x03, 0xA8);
            L0064: return; // RETURN;
        }

        private void FnMAPCONV_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: // make space for tmp on stack: sp -= 2
            L0005: ax = IsFlagOn(player, FlagTypeDungeon, FlagUnknownSwitch1);
            L0018: if (JumpEqual) goto L002E;
            L001A: SetFlag(player, FlagTypeMap, 0x00, 0x01);
            L002E: ax = IsFlagOn(player, FlagTypeDungeon, FlagUnknownSwitch2);
            L0041: if (JumpEqual) goto L0058;
            L0043: SetFlag(player, FlagTypeMap, 0x01, 0x01);
            L0058: ax = IsFlagOn(player, FlagTypeDungeon, FlagUnknownSwitch3);
            L006B: if (JumpEqual) goto L0082;
            L006D: SetFlag(player, FlagTypeMap, 0x02, 0x01);
            L0082: dx = GetFlag(player, FlagTypeMap, 0x00) + GetFlag(player, FlagTypeMap, 0x01);
            L00A7: dx = dx + GetFlag(player, FlagTypeMap, 0x02);
            L00BC: tmp = dx;
            L00BF: Compare(tmp, 0xFE);
            L00C3: if (JumpNotEqual) goto L00D7;
            L00C5: SetFloorItem(player, 0x00, 0xA8);
            L00D5: goto L00E8;
            L00D7: SetFloorItem(player, 0x03, 0xA8);
            L00E8: // restore stack ptr: sp = bp;
            L00EA: return; // RETURN;
        }

        private void FnTELEBACK_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0CA5); // You leave this dimension and re-enter your world.
            L0010: TeleportParty(player, 0x38, 0x04, 0x88, 0x02, isForwardMove);
            L002B: return; // RETURN;
        }

    }
}
