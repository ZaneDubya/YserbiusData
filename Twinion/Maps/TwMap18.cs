using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    class TwMap18 : TwMap {
        public override int MapIndex => 18;
        public override int MapID => 0x0702;
        protected override int RandomEncounterChance => 0;
        protected override int RandomEncounterExtraCount => 0;

        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 25);
                AddEncounter(player, type, doMsgs, 02, 25);
                AddEncounter(player, type, doMsgs, 03, 25);
                AddEncounter(player, type, doMsgs, 04, 25);
                AddEncounter(player, type, doMsgs, 05, 1);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 25);
                AddEncounter(player, type, doMsgs, 02, 25);
                AddEncounter(player, type, doMsgs, 03, 25);
                AddEncounter(player, type, doMsgs, 05, 5);
                AddEncounter(player, type, doMsgs, 06, 7);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 25);
                AddEncounter(player, type, doMsgs, 02, 25);
                AddEncounter(player, type, doMsgs, 03, 4);
                AddEncounter(player, type, doMsgs, 04, 7);
                AddEncounter(player, type, doMsgs, 05, 8);
                AddEncounter(player, type, doMsgs, 06, 9);
            }
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 2);
                AddEncounter(player, type, doMsgs, 02, 14);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 3);
                AddEncounter(player, type, doMsgs, 02, 5);
                AddEncounter(player, type, doMsgs, 03, 14);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 4);
                AddEncounter(player, type, doMsgs, 02, 7);
                AddEncounter(player, type, doMsgs, 03, 8);
                AddEncounter(player, type, doMsgs, 04, 13);
                AddEncounter(player, type, doMsgs, 05, 17);
                AddEncounter(player, type, doMsgs, 06, 19);
            }
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The Snake Charm rattles at the Giant Asp as you approach.");
            ShowText(player, type, doMsgs, "'Kill me if you can, foolish mortals-s-s.'");
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 05, 24);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 3);
                AddEncounter(player, type, doMsgs, 02, 6);
                AddEncounter(player, type, doMsgs, 06, 24);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 3);
                AddEncounter(player, type, doMsgs, 02, 4);
                AddEncounter(player, type, doMsgs, 04, 8);
                AddEncounter(player, type, doMsgs, 05, 10);
                AddEncounter(player, type, doMsgs, 06, 24);
            }
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 14);
                AddEncounter(player, type, doMsgs, 02, 19);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 14);
                AddEncounter(player, type, doMsgs, 02, 17);
                AddEncounter(player, type, doMsgs, 03, 21);
                AddEncounter(player, type, doMsgs, 05, 23);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 13);
                AddEncounter(player, type, doMsgs, 02, 14);
                AddEncounter(player, type, doMsgs, 03, 19);
                AddEncounter(player, type, doMsgs, 05, 20);
                AddEncounter(player, type, doMsgs, 06, 22);
            }
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 11);
                AddEncounter(player, type, doMsgs, 02, 16);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 11);
                AddEncounter(player, type, doMsgs, 02, 12);
                AddEncounter(player, type, doMsgs, 04, 16);
                AddEncounter(player, type, doMsgs, 06, 21);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 10);
                AddEncounter(player, type, doMsgs, 02, 13);
                AddEncounter(player, type, doMsgs, 04, 16);
                AddEncounter(player, type, doMsgs, 05, 20);
                AddEncounter(player, type, doMsgs, 06, 22);
            }
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 23);
                AddEncounter(player, type, doMsgs, 02, 11);
                AddEncounter(player, type, doMsgs, 05, 25);
                AddEncounter(player, type, doMsgs, 06, 25);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 7);
                AddEncounter(player, type, doMsgs, 02, 22);
                AddEncounter(player, type, doMsgs, 03, 25);
                AddEncounter(player, type, doMsgs, 05, 15);
                AddEncounter(player, type, doMsgs, 06, 12);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 8);
                AddEncounter(player, type, doMsgs, 02, 10);
                AddEncounter(player, type, doMsgs, 03, 12);
                AddEncounter(player, type, doMsgs, 04, 15);
                AddEncounter(player, type, doMsgs, 05, 20);
                AddEncounter(player, type, doMsgs, 06, 21);
            }
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 18);
                AddEncounter(player, type, doMsgs, 02, 17);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 8);
                AddEncounter(player, type, doMsgs, 02, 8);
                AddEncounter(player, type, doMsgs, 04, 17);
                AddEncounter(player, type, doMsgs, 06, 19);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 8);
                AddEncounter(player, type, doMsgs, 02, 8);
                AddEncounter(player, type, doMsgs, 04, 18);
                AddEncounter(player, type, doMsgs, 05, 19);
                AddEncounter(player, type, doMsgs, 06, 19);
            }
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, SNAKECHARM)) {
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.RUBY) == 1) {
                    if (HasItem(player, type, doMsgs, RUBYLOCKPICK)) {
                        ShowText(player, type, doMsgs, "You find nothing of interest.");
                        RemoveItem(player, type, doMsgs, SNAKECHARM);
                    }
                    else {
                        ShowText(player, type, doMsgs, "You find a brilliant, red Ruby Lockpick.");
                        ShowText(player, type, doMsgs, "Your Snake Charm falls to the ground and shatters.");
                        GiveItem(player, type, doMsgs, RUBYLOCKPICK);
                        RemoveItem(player, type, doMsgs, SNAKECHARM);
                    }
                }
                else {
                    ShowText(player, type, doMsgs, "You discover the treasure trove of the Giant Asp and what it fought so hard to protect.");
                    ShowText(player, type, doMsgs, "As you lean forward to grab a glowing red Ruby Lockpick, the 25,000 in gold and the other assorted treasures, your Snake Charm falls to the ground and shatters.");
                    GiveItem(player, type, doMsgs, RUBYLOCKPICK);
                    GiveItem(player, type, doMsgs, HEALAMPHORA);
                    GiveItem(player, type, doMsgs, THIEVESFLUTE);
                    GiveItem(player, type, doMsgs, SYMBOLOFDEATH);
                    ModifyExperience(player, type, doMsgs, 50000);
                    ModifyGold(player, type, doMsgs, 25000);
                    RemoveItem(player, type, doMsgs, SNAKECHARM);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.RUBY, 01);
                }
            }
            else {
                ShowText(player, type, doMsgs, "You find nothing of interest.");
            }
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 17);
                AddEncounter(player, type, doMsgs, 02, 18);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 17);
                AddEncounter(player, type, doMsgs, 02, 19);
                AddEncounter(player, type, doMsgs, 03, 19);
                AddEncounter(player, type, doMsgs, 04, 20);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 19);
                AddEncounter(player, type, doMsgs, 02, 19);
                AddEncounter(player, type, doMsgs, 03, 20);
                AddEncounter(player, type, doMsgs, 05, 21);
                AddEncounter(player, type, doMsgs, 06, 23);
            }
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 4, 1, 241, Direction.East);
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Opening the door to the south reveals a shaft lined with rough walls. You use the notches as footholds to climb to the top.");
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 2);
                AddEncounter(player, type, doMsgs, 02, 6);
                AddEncounter(player, type, doMsgs, 03, 13);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 02, 4);
                AddEncounter(player, type, doMsgs, 03, 6);
                AddEncounter(player, type, doMsgs, 04, 14);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 4);
                AddEncounter(player, type, doMsgs, 02, 7);
                AddEncounter(player, type, doMsgs, 03, 8);
                AddEncounter(player, type, doMsgs, 04, 14);
                AddEncounter(player, type, doMsgs, 05, 19);
                AddEncounter(player, type, doMsgs, 06, 19);
            }
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 14);
                AddEncounter(player, type, doMsgs, 02, 19);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 23);
                AddEncounter(player, type, doMsgs, 02, 22);
                AddEncounter(player, type, doMsgs, 04, 21);
                AddEncounter(player, type, doMsgs, 06, 14);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 20);
                AddEncounter(player, type, doMsgs, 02, 19);
                AddEncounter(player, type, doMsgs, 03, 19);
                AddEncounter(player, type, doMsgs, 04, 20);
                AddEncounter(player, type, doMsgs, 05, 14);
            }
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 12);
                AddEncounter(player, type, doMsgs, 02, 16);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 16);
                AddEncounter(player, type, doMsgs, 02, 15);
                AddEncounter(player, type, doMsgs, 03, 12);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 12);
                AddEncounter(player, type, doMsgs, 02, 15);
                AddEncounter(player, type, doMsgs, 03, 15);
                AddEncounter(player, type, doMsgs, 04, 16);
            }
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You see a warning sign -");
            ShowText(player, type, doMsgs, "'Proceed at your own risk!!!'");
            ShowText(player, type, doMsgs, "'If you don't have THE powerful talisman - you'll know what it is when it saves your worthless lives - go no further!'");
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 5, 3, 17, Direction.South);
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, GNOMEBARBARIAN);
            ShowText(player, type, doMsgs, "An exhausted Barbarian sighs, 'This place isn't the Rat Race Track, is it?");
            ShowText(player, type, doMsgs, "I got a great tip from an Elf Thief about a special weapon to be found in a Rat Race or Race Track or Tracking Race Rats or something like that.");
            ShowText(player, type, doMsgs, "Just my luck! All I found while I was searching was a curious piece of leather.'");
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, MEDUSA);
            ShowText(player, type, doMsgs, "A medusa studies you with icy eyes.");
            ShowText(player, type, doMsgs, "'If I had more time I'd kill you, but I seek greater reward.");
            ShowText(player, type, doMsgs, "Rumor of a dragon feud has reached me, and I must be off.");
            ShowText(player, type, doMsgs, "I will leave you as food for my pets.'");
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ShowText(player, type, doMsgs, "Wicked hisses issue forth from the other side.");
            }
            else {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ShowText(player, type, doMsgs, "You must squeeze through this narrow opening one at a time.");
            }
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisablePartyJoining(player, type, doMsgs);
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!HasItem(player, type, doMsgs, SNAKECHARM)) {
                ShowText(player, type, doMsgs, "The Giant Asp laughs at your feeble attempts to kill him.");
                ShowText(player, type, doMsgs, "'You are not protected by that curs-s-sed S-s-snake Charm!'");
                ShowText(player, type, doMsgs, "The Giant Asp slays you with one mighty blow.");
                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
            }
            else {
                ShowText(player, type, doMsgs, "The Giant Asp sees your Snake Charm and shrinks back.");
                ShowText(player, type, doMsgs, "'Curs-s-se you and that curs-s-sed S-s-snake Charm!");
                ShowText(player, type, doMsgs, "Follow me if you dare, mortals-s-s.'");
            }
        }
    }
}
