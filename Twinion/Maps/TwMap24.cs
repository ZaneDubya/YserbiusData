using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    class TwMap24 : TwMap {
        public override int MapIndex => 24;
        public override int MapID => 0x0A02;
        protected override int RandomEncounterChance => 5;
        protected override int RandomEncounterExtraCount => 2;

        private const int RINGA = 1;
        private const int RINGB = 2;
        private const int RINGC = 3;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 9, 2, 120, Direction.West);
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 10, 2, 225, Direction.East);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGTHREE)) && (GetPartyCount(player, type, doMsgs) == 1)) {
                ShowText(player, type, doMsgs, "Pandemonium ahead!");
                TeleportParty(player, type, doMsgs, 10, 3, 159, Direction.South);
            }
            else {
                TeleportParty(player, type, doMsgs, 10, 2, 225, Direction.East);
            }
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 10, 2, 225, Direction.East);
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 10, 2, 225, Direction.East);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 9, 1, 247, Direction.North);
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 8, 1, 225, Direction.West);
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "This will take you into sheer Pandemonium!");
            TeleportParty(player, type, doMsgs, 10, 3, 159, Direction.South);
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 10, 2, 225, Direction.East);
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.EASTQUESTDONE)) {
                ShowText(player, type, doMsgs, "The door opens as you step forward.");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
            }
            else {
                ShowText(player, type, doMsgs, "A sign on the door -");
                ShowText(player, type, doMsgs, "'Those blessed by the Fountain of the Better End may pass.'");
            }
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.FIRST_DOOR_OPEN) == 1) {
                ShowText(player, type, doMsgs, "The door opens at your touch.");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            }
            else {
                ShowText(player, type, doMsgs, "The door does not budge.");
            }
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SECOND_DOOR_OPEN) == 1) {
                ShowText(player, type, doMsgs, "The door is ajar.");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            }
            else {
                ShowText(player, type, doMsgs, "The door will not open.");
            }
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.THIRD_DOOR_OPEN) == 1) {
                ShowText(player, type, doMsgs, "The door is already open.");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            }
            else if (UsedItem(player, type, ref doMsgs, UNITYRING, UNITYRING)) {
                ShowText(player, type, doMsgs, "Touching the Unity Ring unlocks the door.");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.THIRD_DOOR_OPEN, 1);
            }
            else {
                ShowText(player, type, doMsgs, "The door is locked.");
            }
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (UsedItem(player, type, ref doMsgs, BLUELOCKPICK, BLUELOCKPICK) || HasUsedSkill(player, type, ref doMsgs, LOCKPICK_SKILL) >= 12) {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ShowText(player, type, doMsgs, "The door lock springs open.");
            }
            else {
                ShowText(player, type, doMsgs, "The door does not open.");
            }
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasUsedSkill(player, type, ref doMsgs, DETECT_SKILL) >= 12 || HasUsedSpell(player, type, ref doMsgs, TRUE_SEEING_SPELL) >= 1 || UsedItem(player, type, ref doMsgs, HELMOFWISDOM, HELMOFWISDOM) || UsedItem(player, type, ref doMsgs, VALKYRIESHELM, VALKYRIESHELM) || UsedItem(player, type, ref doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || UsedItem(player, type, ref doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                ShowText(player, type, doMsgs, "You find a secret door in the wall.");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGTHREE)) {
                ShowText(player, type, doMsgs, "The door swings open.");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
            else if (UsedItem(player, type, ref doMsgs, UNITYRING, UNITYRING)) {
                if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGTWO)) {
                    if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGDAMAGE)) {
                        ShowText(player, type, doMsgs, "Your burned hand swells in pain as you approach the open door.");
                        ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                    }
                    else {
                        ShowText(player, type, doMsgs, "The Unity Ring burns the word 'Chaos' into your hand.");
                        ShowText(player, type, doMsgs, "You are weakened by the agony of being branded.");
                        ShowText(player, type, doMsgs, "Despite the pain, you manage to unlock the door.");
                        SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGDAMAGE, 1);
                        ModifyExperience(player, type, doMsgs, 150000);
                        ModAttribute(player, type, doMsgs, STRENGTH,  - 2);
                        ModAttribute(player, type, doMsgs, DEFENSE,  - 2);
                        ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                    }
                }
            }
            else {
                ShowText(player, type, doMsgs, "The heavy door does not budge.");
            }
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGTHREE)) {
                ShowText(player, type, doMsgs, "The door ahead is open.");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
            else if (UsedItem(player, type, ref doMsgs, UNITYRING, UNITYRING)) {
                if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGONE)) {
                    if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGDAMAGE)) {
                        ShowText(player, type, doMsgs, "Your charred hand throbs painfully as you open the door.");
                        ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                    }
                    else {
                        ShowText(player, type, doMsgs, "The Unity Ring burns the word 'Harmony' into your hand.");
                        ShowText(player, type, doMsgs, "You almost faint at the pain.");
                        ShowText(player, type, doMsgs, "Still, you manage to open the lock.");
                        SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGDAMAGE, 1);
                        ModifyExperience(player, type, doMsgs, 150000);
                        ModAttribute(player, type, doMsgs, STRENGTH,  - 2);
                        ModAttribute(player, type, doMsgs, DEFENSE,  - 2);
                        ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                    }
                }
            }
            else {
                ShowText(player, type, doMsgs, "The door is locked.");
            }
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DOOR_FLAG_B, 1);
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DOOR_FLAG_C, 0);
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DOOR_FLAG_D, 0);
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DOOR_FLAG_C, 1);
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DOOR_FLAG_B, 0);
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DOOR_FLAG_D, 0);
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DOOR_FLAG_D, 1);
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DOOR_FLAG_B, 0);
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DOOR_FLAG_C, 0);
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DOOR_FLAG_C)) {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            }
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DOOR_FLAG_D)) {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.East);
            }
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetAlignment(player, type, doMsgs) == CHAOS && IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DOOR_FLAG_D)) {
                ShowText(player, type, doMsgs, "A voice whispers -");
                ShowText(player, type, doMsgs, "'Onward, champion of Chaos! The next door will open safely for you.'");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            }
            else if ((IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGTHREE)) && (GetPartyCount(player, type, doMsgs) == 1)) {
                ShowText(player, type, doMsgs, "A kind voice whispers -");
                ShowText(player, type, doMsgs, "'Enter alone, you who have Unity in your heart.'");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            }
            else if (GetAlignment(player, type, doMsgs) == HARMONY && IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DOOR_FLAG_D)) {
                ShowText(player, type, doMsgs, "A voice croaks -");
                ShowText(player, type, doMsgs, "'Be careful, vile toady to Harmony, for without Unity you will suffer.'");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            }
            else {
                ShowText(player, type, doMsgs, "The door refuses to open.");
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DOOR_FLAG_B) || IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DOOR_FLAG_D)) {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.East);
            }
            else if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DOOR_FLAG_C)) {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.West);
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetAlignment(player, type, doMsgs) == HARMONY && IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DOOR_FLAG_D)) {
                ShowText(player, type, doMsgs, "A voice whispers -");
                ShowText(player, type, doMsgs, "'Forward, champion of Harmony! The next door will open safely for you.'");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            }
            else if ((IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGTHREE)) && (GetPartyCount(player, type, doMsgs) == 1)) {
                ShowText(player, type, doMsgs, "A kind voice whispers -");
                ShowText(player, type, doMsgs, "'Enter alone, you with Unity in your heart.'");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            }
            else if (GetAlignment(player, type, doMsgs) == CHAOS && IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DOOR_FLAG_D)) {
                ShowText(player, type, doMsgs, "A voice croaks -");
                ShowText(player, type, doMsgs, "'Tread carefully, Chaotic bootlick, for without Unity you will suffer.'");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            }
            else {
                ShowText(player, type, doMsgs, "The door knob will not move.");
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DOOR_FLAG_C) || IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DOOR_FLAG_D)) {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.West);
            }
            else if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DOOR_FLAG_B)) {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.East);
            }
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DOOR_FLAG_B)) {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            }
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DOOR_FLAG_C)) {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.West);
            }
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.FIRST_DOOR_OPEN) || IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SECOND_DOOR_OPEN) || IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.THIRD_DOOR_OPEN)) {
                ShowRunes(player, type, ref doMsgs, "The way is already open for you.");
            }
            else {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.FIRST_DOOR_OPEN, 1);
                ShowText(player, type, doMsgs, "You have taken the first step toward Unity!");
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, UNITYRING)) {
                ShowText(player, type, doMsgs, "You have the Ring that Unifies Chaos and Harmony.");
                ShowText(player, type, doMsgs, "Use it when you reach the last door.");
            }
            else {
                ShowText(player, type, doMsgs, "'To complete your quest, you must have the Unity Ring.");
                ShowText(player, type, doMsgs, "The ring lies where the Clerics hold sway.");
                ShowText(player, type, doMsgs, "The way is now open to the inner path of the Clerics' way. Return to the Hopeless Hallways and seek the hidden door.");
                ShowText(player, type, doMsgs, "A lamp will light your way...if you look carefully.'");
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GETUNITYRING, 1);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DOOR_FLAG_C, 0);
            }
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SECOND_DOOR_OPEN)) {
                ShowRunes(player, type, ref doMsgs, "Continue, adventurer.");
            }
            else {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SECOND_DOOR_OPEN, 1);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.FIRST_DOOR_OPEN, 0);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.THIRD_DOOR_OPEN, 0);
                ShowText(player, type, doMsgs, "The second step toward Unity is complete. The third step can be found three rooms to the west. Retrace your path.");
            }
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DOOR_FLAG_D, 0);
            if (GetAlignment(player, type, doMsgs) == CHAOS && HasItem(player, type, doMsgs, UNITYRING) && IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGTWO)) {
                if (GetPartyCount(player, type, doMsgs) == 1) {
                    ClearWall(player, type, doMsgs);
                }
                else {
                    WallText(player, type, doMsgs);
                }
            }
            else if (GetAlignment(player, type, doMsgs) == CHAOS && HasItem(player, type, doMsgs, UNITYRING) && !IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGTWO)) {
                ShowText(player, type, doMsgs, "A heavenly voice proclaims -");
                ShowText(player, type, doMsgs, "'This is the Door of Chaos.");
                ShowText(player, type, doMsgs, "You must suffer much along the way, Beloved of Chaos, before the diverse ways are united.");
                ShowText(player, type, doMsgs, "Do not take the lowly spawn of Harmony with you, or they will die.'");
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGTWO, 1);
                SetFlag(player, type, doMsgs, FlagTypeParty, RINGB, 1);
                if (GetPartyCount(player, type, doMsgs) == 1) {
                    ClearWall(player, type, doMsgs);
                }
                else {
                    WallText(player, type, doMsgs);
                }
            }
            else if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGTHREE)) {
                ShowText(player, type, doMsgs, "A majestic voice announces -");
                ShowText(player, type, doMsgs, "'The way is clear for wedded Harmony and Chaos to proceed.'");
                if (GetPartyCount(player, type, doMsgs) == 1) {
                    ClearWall(player, type, doMsgs);
                }
                else {
                    WallText(player, type, doMsgs);
                }
            }
            else if (GetAlignment(player, type, doMsgs) == HARMONY && HasItem(player, type, doMsgs, UNITYRING) && IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGONE)) {
                ShowText(player, type, doMsgs, "A celestial voice chimes out -");
                ShowText(player, type, doMsgs, "'This is the Door of Chaos. The child of Harmony should not yet pass this door.");
                ShowText(player, type, doMsgs, "Great woe awaits the child of Harmony who does not obey!'");
                if (GetPartyCount(player, type, doMsgs) == 1) {
                    ClearWall(player, type, doMsgs);
                }
                else {
                    WallText(player, type, doMsgs);
                }
            }
            else {
                ShowText(player, type, doMsgs, "You see a door upon which 'Chaos' is carved.");
            }
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetAlignment(player, type, doMsgs) == HARMONY && HasItem(player, type, doMsgs, UNITYRING) && IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGONE)) {
                if (GetPartyCount(player, type, doMsgs) == 1) {
                    ClearWall(player, type, doMsgs);
                }
                else {
                    WallText(player, type, doMsgs);
                }
            }
            else if (GetAlignment(player, type, doMsgs) == HARMONY && HasItem(player, type, doMsgs, UNITYRING) && !IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGONE)) {
                ShowText(player, type, doMsgs, "A heavenly voice proclaims -");
                ShowText(player, type, doMsgs, "'This is the Door of Harmony.");
                ShowText(player, type, doMsgs, "You must suffer much along the way, Beloved of Harmony, before the diverse ways are united.");
                ShowText(player, type, doMsgs, "Do not yet take the lowly spawn of Chaos with you, or they will die.'");
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGONE, 1);
                SetFlag(player, type, doMsgs, FlagTypeParty, RINGA, 1);
                if (GetPartyCount(player, type, doMsgs) == 1) {
                    ClearWall(player, type, doMsgs);
                }
                else {
                    WallText(player, type, doMsgs);
                }
            }
            else if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGTHREE)) {
                ShowText(player, type, doMsgs, "A majestic voice announces -");
                ShowText(player, type, doMsgs, "'The way is clear for wedded Harmony and Chaos to proceed together.'");
                if (GetPartyCount(player, type, doMsgs) == 1) {
                    ClearWall(player, type, doMsgs);
                }
                else {
                    WallText(player, type, doMsgs);
                }
            }
            else if (GetAlignment(player, type, doMsgs) == CHAOS && HasItem(player, type, doMsgs, UNITYRING) && IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGTWO)) {
                ShowText(player, type, doMsgs, "A celestial voice chimes out -");
                ShowText(player, type, doMsgs, "'This is the Door of Harmony. The child of Chaos should not yet pass this door.");
                ShowText(player, type, doMsgs, "Great woe awaits the child of Chaos who will not obey!'");
                if (GetPartyCount(player, type, doMsgs) == 1) {
                    ClearWall(player, type, doMsgs);
                }
                else {
                    WallText(player, type, doMsgs);
                }
            }
            else {
                ShowText(player, type, doMsgs, "You see a door upon which 'Harmony' is carved.");
            }
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Beyond the door you hear a low rumbling.");
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGTHREE) == 1) {
                ShowText(player, type, doMsgs, "The room is empty.");
            }
            else if ((HasItem(player, type, doMsgs, UNITYRING)) && ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGONE) == 1) || (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGTWO) == 1))) {
                ShowText(player, type, doMsgs, "Your burned hand is instantly healed.");
                ShowText(player, type, doMsgs, "Your body tingles with new power.");
                ShowText(player, type, doMsgs, "A voice whispers -");
                ShowText(player, type, doMsgs, "'United in your heart are the powers of Chaos and Harmony!");
                ShowText(player, type, doMsgs, "Find the Dralkarians and use your unified skills against them!'");
                RemoveItem(player, type, doMsgs, UNITYRING);
                ModifyExperience(player, type, doMsgs, 750000);
                ModAttribute(player, type, doMsgs, STRENGTH, 4);
                ModAttribute(player, type, doMsgs, DEFENSE, 3);
                ModAttribute(player, type, doMsgs, INITIATIVE, 1);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGTHREE, 1);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GETUNITYRING, 0);
                SetFlag(player, type, doMsgs, FlagTypeParty, RINGC, 1);
            }
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetAlignment(player, type, doMsgs) == HARMONY && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGTHREE) == 0) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HARMONYPUNISH) == 0)) {
                ShowText(player, type, doMsgs, "An angry voice fills your head -");
                ShowText(player, type, doMsgs, "'Hated Harmonic! Die for disobeying the elders who created these caverns!");
                ShowText(player, type, doMsgs, "We strip from you more strength than you can bear to lose!'");
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HARMONYPUNISH, 1);
                ModAttribute(player, type, doMsgs, STRENGTH,  - 2);
                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
            }
            else if (GetAlignment(player, type, doMsgs) == HARMONY && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGTHREE) == 0) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HARMONYPUNISH) != 0)) {
                ShowText(player, type, doMsgs, "A booming voice surrounds you -");
                ShowText(player, type, doMsgs, "'Die, thou miscreant spawn of Harmony! You may not traverse the way of Chaos yet!'");
                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
            }
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetAlignment(player, type, doMsgs) == CHAOS && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGTHREE) == 0) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.CHAOSPUNISH) == 0)) {
                ShowText(player, type, doMsgs, "An angry voice fills your head -");
                ShowText(player, type, doMsgs, "'Hated Chaotic! Die for disobeying the elders who created these caverns!");
                ShowText(player, type, doMsgs, "We strip from you more strength than you can bear to lose!'");
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.CHAOSPUNISH, 1);
                ModAttribute(player, type, doMsgs, STRENGTH,  - 2);
                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
            }
            else if ((GetAlignment(player, type, doMsgs) == CHAOS) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGTHREE) == 0) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.CHAOSPUNISH) != 0)) {
                ShowText(player, type, doMsgs, "A booming voice surrounds you -");
                ShowText(player, type, doMsgs, "'Die, thou miscreant spawn of Chaos! You may not traverse the way of Harmony yet!'");
                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
            }
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGTHREE)) {
                ShowPortrait(player, type, doMsgs, HALFLINGCLERIC);
                ShowText(player, type, doMsgs, "'To finish this quest, you will have to visit places in the Hopeless Hallways you have not been able to enter.'");
            }
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!HasItem(player, type, doMsgs, UNITYRING)) {
                ShowPortrait(player, type, doMsgs, DWARFKNIGHT);
                ShowText(player, type, doMsgs, "'You will have to detect the opening to the first secret room in Hopeless Hallways. It leads to the ring.'");
            }
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, ORCBARBARIAN);
            ShowText(player, type, doMsgs, "'There is a place where what you walk on makes no difference...at times! I enjoyed my lava stroll.'");
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, ELFRANGER);
            ShowText(player, type, doMsgs, "'Do NOT enter a place antithetical to your affiliation until you are told to do so.'");
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HUMANTHIEF);
            ShowText(player, type, doMsgs, "'Once you get to the end of Concordia, you can use a shortcut teleport in the Hopeless Hallways.'");
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, ORCKNIGHT);
            ShowText(player, type, doMsgs, "'Beyond the realm of Pandemonium are the pathways to the Dralkarians.'");
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, GREMLINWIZARD);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGONE) == 1) {
                ShowText(player, type, doMsgs, "'You believer in Harmony, do not enter the Chaos Door until the path is cleared.'");
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGTWO) == 1) {
                ShowText(player, type, doMsgs, "'You follower of Chaos, do not enter the Harmony Door until the path is cleared.'");
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGTHREE) == 1) {
                ShowText(player, type, doMsgs, "'The way is clear for one who has united Harmony and Chaos. Find the Dralkarians and defeat them, as you have been bid.'");
            }
            else {
                ShowText(player, type, doMsgs, "'To find the Doors of Harmony and Chaos requires patience.");
                ShowText(player, type, doMsgs, "The walls around you lead one way and many ways.");
                ShowText(player, type, doMsgs, "May you be wise enough to find the true way.'");
            }
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HALFLINGTHIEF);
            ShowText(player, type, doMsgs, "'You have started along the right path leading to the Doors of Chaos and Harmony.");
            ShowText(player, type, doMsgs, "Much you must suffer before you reach the final exit!'");
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 3);
                AddEncounter(player, type, doMsgs, 02, 11);
                AddEncounter(player, type, doMsgs, 05, 26);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 4);
                AddEncounter(player, type, doMsgs, 02, 7);
                AddEncounter(player, type, doMsgs, 05, 1);
                AddEncounter(player, type, doMsgs, 06, 5);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 3);
                AddEncounter(player, type, doMsgs, 02, 4);
                AddEncounter(player, type, doMsgs, 03, 9);
                AddEncounter(player, type, doMsgs, 04, 8);
                AddEncounter(player, type, doMsgs, 05, 25);
                AddEncounter(player, type, doMsgs, 06, 2);
            }
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 13);
                AddEncounter(player, type, doMsgs, 02, 13);
                AddEncounter(player, type, doMsgs, 05, 27);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 29);
                AddEncounter(player, type, doMsgs, 02, 29);
                AddEncounter(player, type, doMsgs, 05, 30);
                AddEncounter(player, type, doMsgs, 06, 30);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 31);
                AddEncounter(player, type, doMsgs, 02, 31);
                AddEncounter(player, type, doMsgs, 03, 31);
                AddEncounter(player, type, doMsgs, 05, 34);
                AddEncounter(player, type, doMsgs, 06, 34);
            }
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 13);
                AddEncounter(player, type, doMsgs, 02, 17);
                AddEncounter(player, type, doMsgs, 06, 18);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 33);
                AddEncounter(player, type, doMsgs, 02, 33);
                AddEncounter(player, type, doMsgs, 05, 34);
                AddEncounter(player, type, doMsgs, 06, 34);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 34);
                AddEncounter(player, type, doMsgs, 02, 34);
                AddEncounter(player, type, doMsgs, 03, 33);
                AddEncounter(player, type, doMsgs, 04, 33);
                AddEncounter(player, type, doMsgs, 05, 35);
            }
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 21);
                AddEncounter(player, type, doMsgs, 02, 23);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 27);
                AddEncounter(player, type, doMsgs, 02, 27);
                AddEncounter(player, type, doMsgs, 03, 33);
                AddEncounter(player, type, doMsgs, 04, 33);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 13);
                AddEncounter(player, type, doMsgs, 02, 14);
                AddEncounter(player, type, doMsgs, 03, 32);
                AddEncounter(player, type, doMsgs, 04, 32);
                AddEncounter(player, type, doMsgs, 05, 30);
                AddEncounter(player, type, doMsgs, 06, 30);
            }
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 32);
                AddEncounter(player, type, doMsgs, 02, 32);
                AddEncounter(player, type, doMsgs, 04, 33);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 29);
                AddEncounter(player, type, doMsgs, 02, 29);
                AddEncounter(player, type, doMsgs, 05, 34);
                AddEncounter(player, type, doMsgs, 06, 34);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 21);
                AddEncounter(player, type, doMsgs, 02, 21);
                AddEncounter(player, type, doMsgs, 03, 28);
                AddEncounter(player, type, doMsgs, 04, 28);
                AddEncounter(player, type, doMsgs, 05, 23);
                AddEncounter(player, type, doMsgs, 06, 24);
            }
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, JEWELEDBREASTPLATE) || HasItem(player, type, doMsgs, DAWNSHEADPIECE)) {
                SetTreasure(player, type, doMsgs, MANAAMPHORA, 0, 0, 0, 0, 0);
            }
            else {
                SetTreasure(player, type, doMsgs, JEWELEDBREASTPLATE, DAWNSHEADPIECE, 0, 0, 0, 0);
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 40);
                AddEncounter(player, type, doMsgs, 05, 36);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 39);
                AddEncounter(player, type, doMsgs, 02, 40);
                AddEncounter(player, type, doMsgs, 06, 37);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 39);
                AddEncounter(player, type, doMsgs, 02, 40);
                AddEncounter(player, type, doMsgs, 03, 38);
                AddEncounter(player, type, doMsgs, 05, 36);
                AddEncounter(player, type, doMsgs, 06, 37);
            }
        }
        protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, WRATHOFFAITH) || HasItem(player, type, doMsgs, TWINBOLTS)) {
                SetTreasure(player, type, doMsgs, HEALAMPHORA, 0, 0, 0, 0, 0);
            }
            else {
                SetTreasure(player, type, doMsgs, WRATHOFFAITH, TWINBOLTS, 0, 0, 0, 0);
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 40);
                AddEncounter(player, type, doMsgs, 05, 36);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 39);
                AddEncounter(player, type, doMsgs, 02, 40);
                AddEncounter(player, type, doMsgs, 06, 37);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 39);
                AddEncounter(player, type, doMsgs, 02, 40);
                AddEncounter(player, type, doMsgs, 03, 38);
                AddEncounter(player, type, doMsgs, 05, 36);
                AddEncounter(player, type, doMsgs, 06, 37);
            }
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILLMONSTERF) == 1) || HasItem(player, type, doMsgs, PEACEMAKER) || HasItem(player, type, doMsgs, SPIRITUALARMOR)) {
                ShowText(player, type, doMsgs, "The room has been looted.");
            }
            else if (GetAlignment(player, type, doMsgs) == HARMONY) {
                ShowText(player, type, doMsgs, "A soft voice whispers -");
                ShowText(player, type, doMsgs, "'Well done, child of Harmony. Behold your reward!'");
                GiveItem(player, type, doMsgs, PEACEMAKER);
                GiveItem(player, type, doMsgs, SPIRITUALARMOR);
                GiveItem(player, type, doMsgs, GLASSBOW);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILLMONSTERF, 1);
            }
        }
        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILLMONSTERG) == 1) || HasItem(player, type, doMsgs, ARNAKKIANSSTAFF) || HasItem(player, type, doMsgs, BLACKBLADE)) {
                ShowText(player, type, doMsgs, "The room is empty.");
            }
            else if (GetAlignment(player, type, doMsgs) == CHAOS) {
                ShowText(player, type, doMsgs, "A soft voice whispers -");
                ShowText(player, type, doMsgs, "'Well done, child of Chaos. Behold your reward!'");
                GiveItem(player, type, doMsgs, ARNAKKIANSSTAFF);
                GiveItem(player, type, doMsgs, BLACKBLADE);
                GiveItem(player, type, doMsgs, RODOFRESONANCE);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILLMONSTERG, 1);
            }
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.UNITYRINGTHREE) && GetPartyCount(player, type, doMsgs) == 1) {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
        }
        protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisablePartyJoining(player, type, doMsgs);
        }
        private void ClearWall(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
        }
        private void WallText(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Enter one at a time.");
        }
    }
}
