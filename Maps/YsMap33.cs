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
        private void FnVOID_01(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String03FC); // The Ageless Void swallows you whole.
            ShowMessage(player, doMsgs, String0421); // Time freezes forever in your mind.  To the rest of the world, you are dead.
            DamagePlayer(player, GetMaxHits(player));
        }

        private void FnLIFE_02(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String046D); // You are dragged into the Waters of Death. Your death agonies are mercifully short.
            DamagePlayer(player, GetMaxHits(player));
        }

        private void DoTimeSwitch(ServerPlayer player, bool doMsgs, int switchIndex) {
            SetFlag(player, FlagTypeDungeon, FlagKilledEnLiKilThisTime, 0);
            SetFlag(player, FlagTypeDungeon, switchIndex, 1);
            ShowMessage(player, doMsgs, String04C0); // The wall sparkles with phantasmal light.
            int setSwitchCount = player.MapData.GetFlag(FlagTypeDungeon, FlagUnknownSwitch1) + player.MapData.GetFlag(FlagTypeDungeon, FlagUnknownSwitch2) + player.MapData.GetFlag(FlagTypeDungeon, FlagUnknownSwitch3);
            if (setSwitchCount == 1) {
                ShowMessage(player, doMsgs, String04E9); // A Timeswitch has been set.
                ShowMessage(player, doMsgs, String0504); // Two other Timeswitches must be set to reveal the platform.
            }
            else if (setSwitchCount == 2) {
                ShowMessage(player, doMsgs, String053F); // The second Timeswitch has been set.
            }
            else if (setSwitchCount == 3) {
                ShowMessage(player, doMsgs, String0563); // The third and final Timeswitch has been set.
            }
            else {
                ShowMessage(player, doMsgs, String0590); // All is deathly quiet near the Fountain of Life.
            }
        }

        private void FnTIMEA_03(ServerPlayer player, MapEventType type, bool doMsgs) {
            DoTimeSwitch(player, doMsgs, FlagUnknownSwitch1);
        }

        private void FnTIMEB_04(ServerPlayer player, MapEventType type, bool doMsgs) {
            DoTimeSwitch(player, doMsgs, FlagUnknownSwitch2);
        }

        private void FnTIMEC_05(ServerPlayer player, MapEventType type, bool doMsgs) {
            DoTimeSwitch(player, doMsgs, FlagUnknownSwitch3);
        }

        private void FnTIMEELEM_06(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, 0x0011);
            ShowMessage(player, doMsgs, String07C0); // I am the Time Elemental, En-Li-Kil.
            ShowMessage(player, doMsgs, String07E4); // You have traveled far...only to die!
            ShowMessage(player, doMsgs, String0809); // Your arrival frees me from my long imprisonment here -- halfway between two worlds.
            ShowMessage(player, doMsgs, String085D); // I destroyed that fool Arnakkian Slowfoot, and I shall destroy you as easily.
            ShowMessage(player, doMsgs, String08AA); // Then I shall search out all mortals in your world and destroy them!
            ShowMessage(player, doMsgs, String08EE); // I am En-Li-Kil!  The immortal!!!
            SetFlag(player, FlagTypeDungeon, FlagUnknownSwitch1, 0x00);
            SetFlag(player, FlagTypeDungeon, FlagUnknownSwitch2, 0x00);
            SetFlag(player, FlagTypeDungeon, FlagUnknownSwitch3, 0x00);
            AddEncounter(player, 0x01, 0x21);
            AddEncounter(player, 0x02, 0x23);
            AddEncounter(player, 0x03, 0x10);
            AddEncounter(player, 0x04, 0x19);
            AddEncounter(player, 0x06, 0x28);
        }

        private void FnTIMEPLAT_07(ServerPlayer player, MapEventType type, bool doMsgs) {
            // the water tile between the final platform and en-li-kil.
            int countSwitchesSet = 
                GetFlag(player, FlagTypeDungeon, FlagUnknownSwitch1) + 
                GetFlag(player, FlagTypeDungeon, FlagUnknownSwitch2) + 
                GetFlag(player, FlagTypeDungeon, FlagUnknownSwitch3);
            if (countSwitchesSet == 3 || (IsFlagOn(player, FlagTypeMap, 1) == 1)) {
                SetFloorItem(player, 0x00, 0xA8);
                ShowMessage(player, doMsgs, String090F); // You cross the Waters of Death safely.
                ShowMessage(player, doMsgs, String0935); // En-Li-Kil stands guard at the other side, protecting the Fountain of Life. This was the goal Arnakkian Slowfoot sought.
                ShowPortrait(player, 0x0042);
            }
            else {
                SetFloorItem(player, 0x03, 0xA8);
                ShowMessage(player, doMsgs, String09AD); // You are dragged into the Waters of Death. Your death agonies are mercifully short.
                DamagePlayer(player, GetMaxHits(player));
            }
        }

        private void FnGOAL_08(ServerPlayer player, MapEventType type, bool doMsgs) {
            RemoveItem(player, 0xF4);
            RemoveItem(player, 0xF5);
            RemoveItem(player, 0xF6);
            RemoveItem(player, 0xF7);
            RemoveItem(player, 0xF3);
            if (GetFlag(player, FlagTypeDungeon, FlagKilledEnLiKilThisTime) == 1) {
                ShowMessage(player, doMsgs, "You stand amidst the Waters of Death, surrounded on all sides by the Ageless Void. All is peace here.");
                return;
            }
            SetFlag(player, FlagTypeDungeon, FlagKilledEnLiKilThisTime, 1);
            if (IsFlagOn(player, FlagTypeDungeon, FlagDefeatedEnLiKil) == 1) {
                ShowMessage(player, doMsgs, String0A00); // You have found the Fountain of Life, but the waters are drained.
                ShowMessage(player, doMsgs, String0A41); // The Rainbow Gems and Golden Boat dissolve into dust.
                ShowMessage(player, doMsgs, String0A76); // Humiliating En-Li-Kil a second time is reward enough.
                return;
            }
            ShowMessage(player, doMsgs, String0AAC); // You stand on the Fountain of Life.
            ShowMessage(player, doMsgs, String0ACF); // The Rainbow Gems and Golden Boat dissolve in the golden water.
            ShowMessage(player, doMsgs, String0B0E); // You have defeated the Time Elemental En-Li-Kil.
            ShowMessage(player, doMsgs, String0B3E); // You have won the game of life and death.  You are now a HERO OF YSERBIUS.
            ShowMessage(player, doMsgs, String0B88); // Return to your home safely now.
            ShowMessage(player, doMsgs, String0BA8); // Soon you will be able to leave the volcano Yserbius and begin a new life of adventure!
            ShowMessage(player, doMsgs, String0BFF); // Farewell...this ending is just the beginning!!!
            if (GetFlag(player, FlagTypeDungeon, FlagReceivedEnLiKilExperience) == 0) {
                SetFlag(player, FlagTypeDungeon, FlagReceivedEnLiKilExperience, 0x01);
                SetFlag(player, FlagTypeDungeon, FlagDefeatedEnLiKil, 0x01);
                AddExperience(player, 0x004C4B40);
            }
        }

        private void FnENCA_09(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String0C2F); // Across the Waters of Death at the center of this finite square is the Fountain of Life.
            ShowMessage(player, doMsgs, String0C87); // The Fountain is well guarded.
            AddEncounter(player, 0x01, 0x19);
            AddEncounter(player, 0x02, 0x1B);
            AddEncounter(player, 0x03, 0x19);
            AddEncounter(player, 0x04, 0x1B);
            AddEncounter(player, 0x05, 0x23);
            AddEncounter(player, 0x06, 0x1D);
        }

        private void FnENCB_0A(ServerPlayer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, 0x01, 0x08);
            AddEncounter(player, 0x02, 0x08);
            AddEncounter(player, 0x03, 0x24);
            AddEncounter(player, 0x04, 0x25);
            AddEncounter(player, 0x05, 0x26);
            AddEncounter(player, 0x06, 0x27);
        }

        private void FnENCC_0B(ServerPlayer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, 0x01, 0x1B);
            AddEncounter(player, 0x02, 0x1B);
            AddEncounter(player, 0x03, 0x1C);
            AddEncounter(player, 0x04, 0x1C);
            AddEncounter(player, 0x05, 0x1F);
            AddEncounter(player, 0x06, 0x1F);
        }

        private void FnENCD_0C(ServerPlayer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, 0x01, 0x19);
            AddEncounter(player, 0x02, 0x19);
            AddEncounter(player, 0x03, 0x1C);
            AddEncounter(player, 0x04, 0x1C);
            AddEncounter(player, 0x05, 0x1D);
            AddEncounter(player, 0x06, 0x1D);
        }

        private void FnENCE_0D(ServerPlayer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, 0x01, 0x1E);
            AddEncounter(player, 0x02, 0x1E);
            AddEncounter(player, 0x03, 0x20);
            AddEncounter(player, 0x04, 0x20);
            AddEncounter(player, 0x05, 0x18);
            AddEncounter(player, 0x06, 0x21);
        }

        private void FnENCF_0E(ServerPlayer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, 0x01, 0x22);
            AddEncounter(player, 0x02, 0x22);
            AddEncounter(player, 0x03, 0x1F);
            AddEncounter(player, 0x04, 0x1F);
            AddEncounter(player, 0x05, 0x23);
            AddEncounter(player, 0x06, 0x23);
        }

        private void FnCROSSOVR_0F(ServerPlayer player, MapEventType type, bool doMsgs) {
            // the final platform, standing next to the bridged water tile to en-li-kil.
            int countSwitchesSet =
                GetFlag(player, FlagTypeDungeon, FlagUnknownSwitch1) +
                GetFlag(player, FlagTypeDungeon, FlagUnknownSwitch2) +
                GetFlag(player, FlagTypeDungeon, FlagUnknownSwitch3);
            if (countSwitchesSet == 3) {
                SetFloorItem(player, 0x00, 0xA8);
                SetFlag(player, FlagTypeMap, 1, 1); // set a map flag allowing party members to not die even if they did not set the switches.
            }
            else {
                SetFloorItem(player, 0x03, 0xA8);
            }
        }

        private void FnMAPCONV_10(ServerPlayer player, MapEventType type, bool doMsgs) {
            // beginning of the final platform, walking to the bridge to en-li-kil.
            int countSwitchesSet =
                GetFlag(player, FlagTypeDungeon, FlagUnknownSwitch1) +
                GetFlag(player, FlagTypeDungeon, FlagUnknownSwitch2) +
                GetFlag(player, FlagTypeDungeon, FlagUnknownSwitch3);
            if (countSwitchesSet == 3 || (IsFlagOn(player, FlagTypeMap, 1) == 1)) {
                SetFloorItem(player, 0x00, 0xA8);
            }
            else {
                SetFloorItem(player, 0x03, 0xA8);
            }
        }

        private void FnTELEBACK_12(ServerPlayer player, MapEventType type, bool doMsgs) {
            ShowMessage(player, doMsgs, String0CA5); // You leave this dimension and re-enter your world.
            TeleportParty(player, 0x38, 0x04, 0x88, 0x02, type);
        }

    }
}
