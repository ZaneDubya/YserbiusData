using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    /// <summary>
    /// L9: Hopeless Falls
    /// </summary>
    class TwMap22 : TwMap {
        public override int MapIndex => 22;
        public override int MapID => 0x0902;
        protected override int RandomEncounterChance => 0;
        protected override int RandomEncounterExtraCount => 2;

        private const int DOORA = 1;
        private const int DOORB = 2;
        private const int DOORC = 3;
        private const int DOORD = 4;
        private const int CLERICDOORA = 5;
        private const int CLERICDOORB = 6;
        private const int CLERICDOORC = 7;
        private const int CLERICDOORD = 8;
        private const int PITTWO = 9;
        private const int PITTHREE = 10;
        private const int PITFOUR = 11;
        private const int PITFIVE = 12;
        private const int PITSIX = 13;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 8, 1, 160, Direction.East);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 9, 2, 0, Direction.East);
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowRunes(player, type, ref doMsgs, "The path to glory lies eastward.");
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 9, 2, 4, Direction.East);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowRunes(player, type, ref doMsgs, "The second path points east.");
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 9, 2, 8, Direction.East);
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowRunes(player, type, ref doMsgs, "A third path is to the east.");
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 9, 2, 12, Direction.East);
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowRunes(player, type, ref doMsgs, "Behold, the last path awaits you.");
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 9, 2, 233, Direction.East);
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "This pit is particularly fatal.");
            DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The pit you step on is an illusion.");
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 9, 2, 121, Direction.North);
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GETUNITYRING) == 1) {
                ShowText(player, type, doMsgs, "I am the lamp.");
                if (HasUsedSkill(player, type, ref doMsgs, DETECT_SKILL) >= 12 || HasUsedSpell(player, type, ref doMsgs, TRUE_SEEING_SPELL) >= 1 || UsedItem(player, type, ref doMsgs, HELMOFWISDOM, HELMOFWISDOM) || UsedItem(player, type, ref doMsgs, VALKYRIESHELM, VALKYRIESHELM) || UsedItem(player, type, ref doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || UsedItem(player, type, ref doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                    ShowText(player, type, doMsgs, "Throwing a trip mechanism opens a secret entrance.");
                    ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
                    SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), Direction.South);
                }
            }
            else {
                ShowText(player, type, doMsgs, "I am the lamp.");
            }
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 9, 2, 50, Direction.North);
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Walk to the next door southeast of here.");
            ShowText(player, type, doMsgs, "Do not leave the map until you have the ring.");
            SetFlag(player, type, doMsgs, FlagTypeParty, CLERICDOORA, 1);
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 9, 2, 100, Direction.East);
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The next door is to the southeast.");
            SetFlag(player, type, doMsgs, FlagTypeParty, CLERICDOORB, 1);
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The next door is west northwest.");
            SetFlag(player, type, doMsgs, FlagTypeParty, CLERICDOORC, 1);
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You must find the last door on your own!");
            SetFlag(player, type, doMsgs, FlagTypeParty, CLERICDOORD, 1);
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 9, 2, 180, Direction.South);
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.NPCENDCHAT) == 1) {
                ShowText(player, type, doMsgs, "The door unlocks as you approach.");
                SetFlag(player, type, doMsgs, FlagTypeParty, DOORA, 1);
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            }
            else {
                ShowText(player, type, doMsgs, "Nothing you try opens the door.");
            }
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.OPENDOORB) == 1) || (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.OPENDOORC) == 1) || (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.OPENDOORD) == 1)) {
                ShowText(player, type, doMsgs, "The door swings open.");
                SetFlag(player, type, doMsgs, FlagTypeParty, DOORB, 1);
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.West);
            }
            else {
                ShowText(player, type, doMsgs, "The door does not budge.");
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.OPENDOORC) == 1) {
                ShowText(player, type, doMsgs, "The lock on the door clicks open.");
                SetFlag(player, type, doMsgs, FlagTypeParty, DOORC, 1);
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.East);
            }
            else {
                ShowText(player, type, doMsgs, "You push against the door, but nothing happens.");
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.OPENDOORD) == 1) {
                ShowText(player, type, doMsgs, "The doorknob twists easily at your touch.");
                SetFlag(player, type, doMsgs, FlagTypeParty, DOORD, 1);
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.West);
            }
            else {
                ShowText(player, type, doMsgs, "The heavy door will not move.");
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGTHREE)) {
                if (UsedItem(player, type, ref doMsgs, REDLOCKPICK, BLUELOCKPICK) || UsedItem(player, type, ref doMsgs, HELMOFGUILE, HELMOFGUILE) || HasUsedSkill(player, type, ref doMsgs, LOCKPICK_SKILL) >= 10) {
                    ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                    ShowText(player, type, doMsgs, "The lock pops open at your deft touch.");
                }
                else {
                    SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                    ShowText(player, type, doMsgs, "The door lock looks particularly nasty.");
                }
            }
            else {
                ShowText(player, type, doMsgs, "Finish Concordia and you may pass.");
            }
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.NPCKEYCLUE) == 1) {
                ShowText(player, type, doMsgs, "The words of the Elf Cleric come to mind as you stare at the star-shaped keyhole in the door.");
                ShowText(player, type, doMsgs, "A brilliant glow effuses from the keyhole.");
                ShowText(player, type, doMsgs, "Then there is a click, and the door opens.");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGTHREE) == 1) {
                ShowText(player, type, doMsgs, "The star-shaped keyhole glows and the lock clicks open.");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
            }
            else {
                ShowText(player, type, doMsgs, "The keyhole in the door is shaped like a radiant star.");
            }
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.EASTQUESTDONE)) {
                ShowText(player, type, doMsgs, "The room is empty.");
            }
            else {
                ShowPortrait(player, type, doMsgs, HALFLINGCLERIC);
                ShowText(player, type, doMsgs, "A Halfling Cleric bows politely.");
                ShowText(player, type, doMsgs, "'From south to north four times the pathway eastward lies.");
                ShowText(player, type, doMsgs, "Farthest east and north is your reward.");
                ShowText(player, type, doMsgs, "But once may the brave heart succeed and then the way is forever closed.'");
            }
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.EASTQUESTDONE)) {
                ShowText(player, type, doMsgs, "You see a torn robe on the floor.");
            }
            else {
                ShowPortrait(player, type, doMsgs, TROLLCLERIC);
                ShowText(player, type, doMsgs, "A Troll Cleric approaches.");
                ShowText(player, type, doMsgs, "'Beyond the many doors is a quest that will test the bravest of heroes.");
                ShowText(player, type, doMsgs, "Find my fellow clerics to start the quest.");
                ShowText(player, type, doMsgs, "Also, know that the nature of pits may change as you succeed.'");
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.EASTQUESTDONE)) {
                ShowText(player, type, doMsgs, "The room is bare.");
            }
            else {
                ShowPortrait(player, type, doMsgs, ELFCLERIC);
                ShowText(player, type, doMsgs, "An Elf Cleric steps out of the shadows.");
                if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.NPCKEYCLUE)) {
                    ShowText(player, type, doMsgs, "'Back again? I said to look for the star-hole door.'");
                }
                else {
                    ShowText(player, type, doMsgs, "'I give you the key to the star-hole door. Think of the shining sun and the way to the quest will be open.'");
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.NPCKEYCLUE, 1);
                }
            }
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.EASTQUESTDONE)) {
                ShowText(player, type, doMsgs, "In the distance you hear the growl of monsters.");
            }
            else {
                ShowPortrait(player, type, doMsgs, ELFCLERIC);
                if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.NPCENDCHAT)) {
                    ShowText(player, type, doMsgs, "'As I said earlier, the first door will now open for you.'");
                }
                else {
                    ShowText(player, type, doMsgs, "You interrupt the meditations of an Elf Cleric.");
                    ShowText(player, type, doMsgs, "'The first door will now open for you.'");
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.NPCENDCHAT, 1);
                }
            }
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Know that the next door is now open.");
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.OPENDOORB, 1);
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Know that the next door is now open.");
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.OPENDOORC, 1);
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.OPENDOORB, 0);
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Know that the next door is now open.");
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.OPENDOORD, 1);
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.OPENDOORC, 0);
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.EASTQUESTDONE) == 0)) {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.EASTQUESTDONE, 1);
                ShowPortrait(player, type, doMsgs, FOUNTAIN);
                ShowText(player, type, doMsgs, "The acid waters of the Fountain of the Bitter End at first burn your mouth.");
                ShowText(player, type, doMsgs, "After a moment the acid taste changes to sweet water.");
                ShowText(player, type, doMsgs, "You have transformed the Fountain of the Bitter End into the Fountain of the Better End.");
                ShowText(player, type, doMsgs, "You feel ready to take on whole armies.");
                ModAttribute(player, type, doMsgs, INITIATIVE, 3);
                ModAttribute(player, type, doMsgs, AGILITY, 2);
                ModifyExperience(player, type, doMsgs, 750000);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.OPENDOORB, 2);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.OPENDOORC, 2);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.OPENDOORD, 2);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.NPCKEYCLUE, 2);
            }
            else {
                ShowText(player, type, doMsgs, "The Fountain of the Better End is dry.");
            }
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 22);
                AddEncounter(player, type, doMsgs, 02, 21);
                AddEncounter(player, type, doMsgs, 06, 27);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 30);
                AddEncounter(player, type, doMsgs, 02, 31);
                AddEncounter(player, type, doMsgs, 03, 29);
                AddEncounter(player, type, doMsgs, 06, 26);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 3);
                AddEncounter(player, type, doMsgs, 02, 3);
                AddEncounter(player, type, doMsgs, 03, 36);
                AddEncounter(player, type, doMsgs, 04, 37);
                AddEncounter(player, type, doMsgs, 05, 24);
                AddEncounter(player, type, doMsgs, 06, 24);
            }
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 27);
                AddEncounter(player, type, doMsgs, 02, 28);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 35);
                AddEncounter(player, type, doMsgs, 02, 36);
                AddEncounter(player, type, doMsgs, 06, 12);
            }
            else if (GetPartyCount(player, type, doMsgs) == 3) {
                AddEncounter(player, type, doMsgs, 01, 32);
                AddEncounter(player, type, doMsgs, 02, 34);
                AddEncounter(player, type, doMsgs, 03, 34);
                AddEncounter(player, type, doMsgs, 04, 32);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 32);
                AddEncounter(player, type, doMsgs, 02, 34);
                AddEncounter(player, type, doMsgs, 03, 34);
                AddEncounter(player, type, doMsgs, 04, 32);
                AddEncounter(player, type, doMsgs, 05, 40);
            }
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1 || GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 31);
                AddEncounter(player, type, doMsgs, 02, 29);
                AddEncounter(player, type, doMsgs, 05, 13);
            }
            else if (GetPartyCount(player, type, doMsgs) == 3) {
                AddEncounter(player, type, doMsgs, 01, 18);
                AddEncounter(player, type, doMsgs, 02, 19);
                AddEncounter(player, type, doMsgs, 03, 19);
                AddEncounter(player, type, doMsgs, 05, 26);
                AddEncounter(player, type, doMsgs, 06, 28);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 23);
                AddEncounter(player, type, doMsgs, 02, 23);
                AddEncounter(player, type, doMsgs, 03, 31);
                AddEncounter(player, type, doMsgs, 04, 30);
                AddEncounter(player, type, doMsgs, 05, 26);
                AddEncounter(player, type, doMsgs, 06, 26);
            }
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 29);
                AddEncounter(player, type, doMsgs, 02, 26);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 29);
                AddEncounter(player, type, doMsgs, 02, 29);
                AddEncounter(player, type, doMsgs, 05, 26);
                AddEncounter(player, type, doMsgs, 06, 26);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 29);
                AddEncounter(player, type, doMsgs, 02, 29);
                AddEncounter(player, type, doMsgs, 03, 29);
                AddEncounter(player, type, doMsgs, 04, 29);
                AddEncounter(player, type, doMsgs, 05, 26);
                AddEncounter(player, type, doMsgs, 06, 26);
            }
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 32);
                AddEncounter(player, type, doMsgs, 02, 32);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 32);
                AddEncounter(player, type, doMsgs, 02, 32);
                AddEncounter(player, type, doMsgs, 05, 34);
                AddEncounter(player, type, doMsgs, 06, 34);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 32);
                AddEncounter(player, type, doMsgs, 02, 32);
                AddEncounter(player, type, doMsgs, 03, 33);
                AddEncounter(player, type, doMsgs, 04, 34);
                AddEncounter(player, type, doMsgs, 06, 34);
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 32);
                AddEncounter(player, type, doMsgs, 02, 4);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 32);
                AddEncounter(player, type, doMsgs, 02, 32);
                AddEncounter(player, type, doMsgs, 04, 37);
            }
            else if (GetPartyCount(player, type, doMsgs) == 3) {
                AddEncounter(player, type, doMsgs, 01, 32);
                AddEncounter(player, type, doMsgs, 02, 32);
                AddEncounter(player, type, doMsgs, 03, 37);
                AddEncounter(player, type, doMsgs, 04, 37);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 34);
                AddEncounter(player, type, doMsgs, 02, 34);
                AddEncounter(player, type, doMsgs, 03, 36);
                AddEncounter(player, type, doMsgs, 04, 36);
                AddEncounter(player, type, doMsgs, 05, 38);
                AddEncounter(player, type, doMsgs, 06, 38);
            }
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 32);
                AddEncounter(player, type, doMsgs, 02, 33);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 34);
                AddEncounter(player, type, doMsgs, 02, 34);
                AddEncounter(player, type, doMsgs, 05, 35);
                AddEncounter(player, type, doMsgs, 06, 9);
            }
            else if (GetPartyCount(player, type, doMsgs) == 3) {
                AddEncounter(player, type, doMsgs, 01, 33);
                AddEncounter(player, type, doMsgs, 02, 33);
                AddEncounter(player, type, doMsgs, 03, 35);
                AddEncounter(player, type, doMsgs, 04, 35);
                AddEncounter(player, type, doMsgs, 05, 34);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 38);
                AddEncounter(player, type, doMsgs, 02, 38);
                AddEncounter(player, type, doMsgs, 03, 38);
                AddEncounter(player, type, doMsgs, 04, 38);
                AddEncounter(player, type, doMsgs, 05, 24);
                AddEncounter(player, type, doMsgs, 06, 24);
            }
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 35);
                AddEncounter(player, type, doMsgs, 02, 9);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 35);
                AddEncounter(player, type, doMsgs, 02, 3);
                AddEncounter(player, type, doMsgs, 05, 7);
                AddEncounter(player, type, doMsgs, 06, 9);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 4);
                AddEncounter(player, type, doMsgs, 02, 4);
                AddEncounter(player, type, doMsgs, 03, 5);
                AddEncounter(player, type, doMsgs, 04, 5);
                AddEncounter(player, type, doMsgs, 05, 24);
                AddEncounter(player, type, doMsgs, 06, 24);
            }
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 38);
                AddEncounter(player, type, doMsgs, 02, 38);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 38);
                AddEncounter(player, type, doMsgs, 02, 38);
                AddEncounter(player, type, doMsgs, 05, 39);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 02, 5);
                AddEncounter(player, type, doMsgs, 03, 38);
                AddEncounter(player, type, doMsgs, 04, 38);
                AddEncounter(player, type, doMsgs, 05, 39);
                AddEncounter(player, type, doMsgs, 06, 40);
            }
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 32);
                AddEncounter(player, type, doMsgs, 02, 33);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 33);
                AddEncounter(player, type, doMsgs, 02, 34);
                AddEncounter(player, type, doMsgs, 05, 33);
                AddEncounter(player, type, doMsgs, 06, 34);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 34);
                AddEncounter(player, type, doMsgs, 02, 34);
                AddEncounter(player, type, doMsgs, 03, 33);
                AddEncounter(player, type, doMsgs, 04, 33);
                AddEncounter(player, type, doMsgs, 05, 35);
                AddEncounter(player, type, doMsgs, 06, 35);
            }
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (IsTrue(GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGTHREE)) || HasItem(player, type, doMsgs, UNITYRING)) {
                ShowText(player, type, doMsgs, "The floor of the room is bare.");
            }
            else {
                GiveItem(player, type, doMsgs, UNITYRING);
                GiveItem(player, type, doMsgs, TWINBOLTS);
                ModifyExperience(player, type, doMsgs, 350000);
                ShowText(player, type, doMsgs, "On the floor is a ring bearing the ");
                ShowText(player, type, doMsgs, "linked symbols of Chaos and Harmony.");
                ShowText(player, type, doMsgs, "You place the Unity Ring on your finger.");
            }
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableAutomaps(player, type, doMsgs);
            if (GetTile(player, type, doMsgs) == 224) {
                DisablePartyJoining(player, type, doMsgs);
            }
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (IsPartyLeader(player, type, doMsgs)) {
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.OPENDOORD) == 1) {
                    ShowText(player, type, doMsgs, "The pit swallows you up and spits you out at...");
                    TeleportParty(player, type, doMsgs, 7, 1, 32, Direction.East);
                }
                else {
                    ShowText(player, type, doMsgs, "The pit is only a painted illusion.");
                }
            }
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.OPENDOORC) == 1) {
                ShowText(player, type, doMsgs, "An endless pit to death...");
                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
            }
            else {
                ShowText(player, type, doMsgs, "The pit you step on is a simple illusion.");
            }
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (IsPartyLeader(player, type, doMsgs)) {
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.OPENDOORB) == 1) {
                    ShowText(player, type, doMsgs, "This pit leads to...");
                    TeleportParty(player, type, doMsgs, 9, 2, 120, Direction.West);
                }
                else {
                    ShowText(player, type, doMsgs, "The pit is a simple illusion.");
                }
            }
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (IsPartyLeader(player, type, doMsgs)) {
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.OPENDOORD) == 1) {
                    ShowText(player, type, doMsgs, "The pit is just an illusion.");
                }
                else {
                    ShowText(player, type, doMsgs, "The pit drops you off at...");
                    TeleportParty(player, type, doMsgs, 6, 2, 48, Direction.East);
                }
            }
        }
        protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (IsPartyLeader(player, type, doMsgs)) {
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.OPENDOORC) == 1) {
                    ShowText(player, type, doMsgs, "You step on an illusionary pit.");
                }
                else {
                    ShowText(player, type, doMsgs, "The pit is a far step to...");
                    TeleportParty(player, type, doMsgs, 5, 2, 247, Direction.North);
                }
            }
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (IsPartyLeader(player, type, doMsgs)) {
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.OPENDOORC) == 1) || (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.OPENDOORD) == 1)) {
                    ShowText(player, type, doMsgs, "The pit is a clever illusion.");
                }
                else {
                    ShowText(player, type, doMsgs, "You step into an endless pit to...");
                    TeleportParty(player, type, doMsgs, 1, 1, 204, Direction.East);
                }
            }
        }
        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (IsPartyLeader(player, type, doMsgs)) {
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.OPENDOORB) == 1) || (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.OPENDOORD) == 1)) {
                    ShowText(player, type, doMsgs, "The pit is an illusion.");
                }
                else {
                    ShowText(player, type, doMsgs, "The pit you step into leads...");
                    TeleportParty(player, type, doMsgs, 3, 2, 82, Direction.East);
                }
            }
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A return to Dragon's Ire.");
            TeleportParty(player, type, doMsgs, 8, 1, 160, Direction.East);
        }
        protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Hocus Pocus is just ahead.");
            TeleportParty(player, type, doMsgs, 9, 1, 167, Direction.South);
        }
        protected override void FnEvent3B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "In the distance you hear babbling.");
            TeleportParty(player, type, doMsgs, 10, 1, 88, Direction.North);
        }
        protected override void FnEvent3C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Step through to Concordia.");
            TeleportParty(player, type, doMsgs, 10, 2, 225, Direction.North);
        }
        protected override void FnEvent3D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Pandemonium awaits!");
            TeleportParty(player, type, doMsgs, 10, 3, 159, Direction.West);
        }
        protected override void FnEvent3E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.EASTQUESTDONE) == 1) {
                ShowText(player, type, doMsgs, "Who hath tasted of the Fountain of the Better End may no longer pass.");
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.East);
            }
            else {
                if (GetPartyCount(player, type, doMsgs) == 1) {
                    ShowText(player, type, doMsgs, "Pass through the door.");
                    ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.East);
                }
                else {
                    ShowText(player, type, doMsgs, "One adventurer at a time may pass through this door.");
                }
            }
        }
        protected override void FnEvent3F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The pit drops you into darkness.");
            TeleportParty(player, type, doMsgs, 5, 3, 103, Direction.North);
        }
        protected override void FnEvent40(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "This pit leads to...");
            TeleportParty(player, type, doMsgs, 9, 2, 41, Direction.West);
        }
        protected override void FnEvent41(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The pit is an endless abyss to...");
            TeleportParty(player, type, doMsgs, 5, 2, 189, Direction.North);
        }
        protected override void FnEvent42(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeParty, CLERICDOORA) == 1) {
                ShowText(player, type, doMsgs, "On the door is a picture of a Cleric.");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.West);
            }
        }
        protected override void FnEvent43(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeParty, CLERICDOORB) == 1) {
                ShowText(player, type, doMsgs, "On the door is a picture of a Cleric.");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
            }
        }
        protected override void FnEvent44(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeParty, CLERICDOORC) == 1) {
                ShowText(player, type, doMsgs, "On the door is a picture of a Cleric.");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.East);
            }
        }
        protected override void FnEvent45(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeParty, CLERICDOORD) == 1) {
                ShowText(player, type, doMsgs, "On the door is a picture of a Cleric.");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
            }
        }
        protected override void FnEvent46(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.OPENDOORB) == 1) {
                ShowText(player, type, doMsgs, "Proceed.");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.West);
            }
        }
    }
}
