using XPT.Generic.Maps;
using XPT.Twinion.Entities;

namespace XPT.Twinion.Maps {
    class TwMap24 : TwMap {
        protected override int MapIndex => 24;
        protected override int MapID => 0x0A02;
        protected override int RandomEncounterChance => 5;
        protected override int RandomEncounterExtraCount => 2;

        private const int RINGA = 1;
        private const int RINGB = 2;
        private const int RINGC = 3;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 9, 2, 120, WEST);
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 10, 2, 225, EAST);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((FLAG_ON(player, type, doMsgs, DUNGEON, UNITYRINGTHREE)) && (PARTY_COUNT(player, type, doMsgs) == 1)) {
                SHOW_TEXT(player, type, doMsgs, "Pandemonium ahead!");
                TELEPORT(player, type, doMsgs, 10, 3, 159, SOUTH);
            }
            else {
                TELEPORT(player, type, doMsgs, 10, 2, 225, EAST);
            }
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 10, 2, 225, EAST);
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 10, 2, 225, EAST);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 9, 1, 247, NORTH);
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 8, 1, 225, WEST);
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This will take you into sheer Pandemonium!");
            TELEPORT(player, type, doMsgs, 10, 3, 159, SOUTH);
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 10, 2, 225, EAST);
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (FLAG_ON(player, type, doMsgs, DUNGEON, EASTQUESTDONE)) {
                SHOW_TEXT(player, type, doMsgs, "The door opens as you step forward.");
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "A sign on the door -");
                SHOW_TEXT(player, type, doMsgs, "'Those blessed by the Fountain of the Better End may pass.'");
            }
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, FIRST_DOOR_OPEN) == 1) {
                SHOW_TEXT(player, type, doMsgs, "The door opens at your touch.");
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The door does not budge.");
            }
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, SECOND_DOOR_OPEN) == 1) {
                SHOW_TEXT(player, type, doMsgs, "The door is ajar.");
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The door will not open.");
            }
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, THIRD_DOOR_OPEN) == 1) {
                SHOW_TEXT(player, type, doMsgs, "The door is already open.");
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            }
            else if (USED_ITEM(player, type, doMsgs, UNITYRING, UNITYRING)) {
                SHOW_TEXT(player, type, doMsgs, "Touching the Unity Ring unlocks the door.");
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
                SET_FLAG(player, type, doMsgs, DUNGEON, THIRD_DOOR_OPEN, 1);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The door is locked.");
            }
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_ITEM(player, type, doMsgs, BLUELOCKPICK, BLUELOCKPICK) || USED_SKILL(player, type, doMsgs, LOCKPICK_SKILL) >= 12) {
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                SHOW_TEXT(player, type, doMsgs, "The door lock springs open.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The door does not open.");
            }
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_SKILL(player, type, doMsgs, DETECT_SKILL) >= 12 || USED_SPELL(player, type, doMsgs, TRUE_SEEING_SPELL) >= 1 || USED_ITEM(player, type, doMsgs, HELMOFWISDOM, HELMOFWISDOM) || USED_ITEM(player, type, doMsgs, VALKYRIESHELM, VALKYRIESHELM) || USED_ITEM(player, type, doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || USED_ITEM(player, type, doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                SHOW_TEXT(player, type, doMsgs, "You find a secret door in the wall.");
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            }
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (FLAG_ON(player, type, doMsgs, DUNGEON, UNITYRINGTHREE)) {
                SHOW_TEXT(player, type, doMsgs, "The door swings open.");
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            }
            else if (USED_ITEM(player, type, doMsgs, UNITYRING, UNITYRING)) {
                if (FLAG_ON(player, type, doMsgs, DUNGEON, UNITYRINGTWO)) {
                    if (FLAG_ON(player, type, doMsgs, DUNGEON, UNITYRINGDAMAGE)) {
                        SHOW_TEXT(player, type, doMsgs, "Your burned hand swells in pain as you approach the open door.");
                        CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                    }
                    else {
                        SHOW_TEXT(player, type, doMsgs, "The Unity Ring burns the word 'Chaos' into your hand.");
                        SHOW_TEXT(player, type, doMsgs, "You are weakened by the agony of being branded.");
                        SHOW_TEXT(player, type, doMsgs, "Despite the pain, you manage to unlock the door.");
                        SET_FLAG(player, type, doMsgs, DUNGEON, UNITYRINGDAMAGE, 1);
                        MOD_EXP(player, type, doMsgs, 150000);
                        MOD_STAT(player, type, doMsgs, STRENGTH,  - 2);
                        MOD_STAT(player, type, doMsgs, DEFENSE,  - 2);
                        CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                    }
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The heavy door does not budge.");
            }
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (FLAG_ON(player, type, doMsgs, DUNGEON, UNITYRINGTHREE)) {
                SHOW_TEXT(player, type, doMsgs, "The door ahead is open.");
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            }
            else if (USED_ITEM(player, type, doMsgs, UNITYRING, UNITYRING)) {
                if (FLAG_ON(player, type, doMsgs, DUNGEON, UNITYRINGONE)) {
                    if (FLAG_ON(player, type, doMsgs, DUNGEON, UNITYRINGDAMAGE)) {
                        SHOW_TEXT(player, type, doMsgs, "Your charred hand throbs painfully as you open the door.");
                        CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                    }
                    else {
                        SHOW_TEXT(player, type, doMsgs, "The Unity Ring burns the word 'Harmony' into your hand.");
                        SHOW_TEXT(player, type, doMsgs, "You almost faint at the pain.");
                        SHOW_TEXT(player, type, doMsgs, "Still, you manage to open the lock.");
                        SET_FLAG(player, type, doMsgs, DUNGEON, UNITYRINGDAMAGE, 1);
                        MOD_EXP(player, type, doMsgs, 150000);
                        MOD_STAT(player, type, doMsgs, STRENGTH,  - 2);
                        MOD_STAT(player, type, doMsgs, DEFENSE,  - 2);
                        CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                    }
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The door is locked.");
            }
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            SET_FLAG(player, type, doMsgs, DUNGEON, DOOR_FLAG_B, 1);
            SET_FLAG(player, type, doMsgs, DUNGEON, DOOR_FLAG_C, 0);
            SET_FLAG(player, type, doMsgs, DUNGEON, DOOR_FLAG_D, 0);
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            SET_FLAG(player, type, doMsgs, DUNGEON, DOOR_FLAG_C, 1);
            SET_FLAG(player, type, doMsgs, DUNGEON, DOOR_FLAG_B, 0);
            SET_FLAG(player, type, doMsgs, DUNGEON, DOOR_FLAG_D, 0);
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            SET_FLAG(player, type, doMsgs, DUNGEON, DOOR_FLAG_D, 1);
            SET_FLAG(player, type, doMsgs, DUNGEON, DOOR_FLAG_B, 0);
            SET_FLAG(player, type, doMsgs, DUNGEON, DOOR_FLAG_C, 0);
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (FLAG_ON(player, type, doMsgs, DUNGEON, DOOR_FLAG_C)) {
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            }
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (FLAG_ON(player, type, doMsgs, DUNGEON, DOOR_FLAG_D)) {
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
            }
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (ALIGN(player, type, doMsgs) == CHAOS && FLAG_ON(player, type, doMsgs, DUNGEON, DOOR_FLAG_D)) {
                SHOW_TEXT(player, type, doMsgs, "A voice whispers -");
                SHOW_TEXT(player, type, doMsgs, "'Onward, champion of Chaos! The next door will open safely for you.'");
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            }
            else if ((FLAG_ON(player, type, doMsgs, DUNGEON, UNITYRINGTHREE)) && (PARTY_COUNT(player, type, doMsgs) == 1)) {
                SHOW_TEXT(player, type, doMsgs, "A kind voice whispers -");
                SHOW_TEXT(player, type, doMsgs, "'Enter alone, you who have Unity in your heart.'");
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            }
            else if (ALIGN(player, type, doMsgs) == HARMONY && FLAG_ON(player, type, doMsgs, DUNGEON, DOOR_FLAG_D)) {
                SHOW_TEXT(player, type, doMsgs, "A voice croaks -");
                SHOW_TEXT(player, type, doMsgs, "'Be careful, vile toady to Harmony, for without Unity you will suffer.'");
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The door refuses to open.");
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (FLAG_ON(player, type, doMsgs, DUNGEON, DOOR_FLAG_B) || FLAG_ON(player, type, doMsgs, DUNGEON, DOOR_FLAG_D)) {
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
            }
            else if (FLAG_ON(player, type, doMsgs, DUNGEON, DOOR_FLAG_C)) {
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (ALIGN(player, type, doMsgs) == HARMONY && FLAG_ON(player, type, doMsgs, DUNGEON, DOOR_FLAG_D)) {
                SHOW_TEXT(player, type, doMsgs, "A voice whispers -");
                SHOW_TEXT(player, type, doMsgs, "'Forward, champion of Harmony! The next door will open safely for you.'");
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            }
            else if ((FLAG_ON(player, type, doMsgs, DUNGEON, UNITYRINGTHREE)) && (PARTY_COUNT(player, type, doMsgs) == 1)) {
                SHOW_TEXT(player, type, doMsgs, "A kind voice whispers -");
                SHOW_TEXT(player, type, doMsgs, "'Enter alone, you with Unity in your heart.'");
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            }
            else if (ALIGN(player, type, doMsgs) == CHAOS && FLAG_ON(player, type, doMsgs, DUNGEON, DOOR_FLAG_D)) {
                SHOW_TEXT(player, type, doMsgs, "A voice croaks -");
                SHOW_TEXT(player, type, doMsgs, "'Tread carefully, Chaotic bootlick, for without Unity you will suffer.'");
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The door knob will not move.");
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (FLAG_ON(player, type, doMsgs, DUNGEON, DOOR_FLAG_C) || FLAG_ON(player, type, doMsgs, DUNGEON, DOOR_FLAG_D)) {
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
            }
            else if (FLAG_ON(player, type, doMsgs, DUNGEON, DOOR_FLAG_B)) {
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
            }
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (FLAG_ON(player, type, doMsgs, DUNGEON, DOOR_FLAG_B)) {
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
            }
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (FLAG_ON(player, type, doMsgs, DUNGEON, DOOR_FLAG_C)) {
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
            }
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (FLAG_ON(player, type, doMsgs, DUNGEON, FIRST_DOOR_OPEN) || FLAG_ON(player, type, doMsgs, DUNGEON, SECOND_DOOR_OPEN) || FLAG_ON(player, type, doMsgs, DUNGEON, THIRD_DOOR_OPEN)) {
                SHOW_RUNES(player, type, doMsgs, "The way is already open for you.");
            }
            else {
                SET_FLAG(player, type, doMsgs, DUNGEON, FIRST_DOOR_OPEN, 1);
                SHOW_TEXT(player, type, doMsgs, "You have taken the first step toward Unity!");
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, UNITYRING)) {
                SHOW_TEXT(player, type, doMsgs, "You have the Ring that Unifies Chaos and Harmony.");
                SHOW_TEXT(player, type, doMsgs, "Use it when you reach the last door.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "'To complete your quest, you must have the Unity Ring.");
                SHOW_TEXT(player, type, doMsgs, "The ring lies where the Clerics hold sway.");
                SHOW_TEXT(player, type, doMsgs, "The way is now open to the inner path of the Clerics' way. Return to the Hopeless Hallways and seek the hidden door.");
                SHOW_TEXT(player, type, doMsgs, "A lamp will light your way...if you look carefully.'");
                SET_FLAG(player, type, doMsgs, DUNGEON, GETUNITYRING, 1);
                SET_FLAG(player, type, doMsgs, DUNGEON, DOOR_FLAG_C, 0);
            }
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (FLAG_ON(player, type, doMsgs, DUNGEON, SECOND_DOOR_OPEN)) {
                SHOW_RUNES(player, type, doMsgs, "Continue, adventurer.");
            }
            else {
                SET_FLAG(player, type, doMsgs, DUNGEON, SECOND_DOOR_OPEN, 1);
                SET_FLAG(player, type, doMsgs, DUNGEON, FIRST_DOOR_OPEN, 0);
                SET_FLAG(player, type, doMsgs, DUNGEON, THIRD_DOOR_OPEN, 0);
                SHOW_TEXT(player, type, doMsgs, "The second step toward Unity is complete. The third step can be found three rooms to the west. Retrace your path.");
            }
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_FLAG(player, type, doMsgs, DUNGEON, DOOR_FLAG_D, 0);
            if (ALIGN(player, type, doMsgs) == CHAOS && HAS_ITEM(player, type, doMsgs, UNITYRING) && FLAG_ON(player, type, doMsgs, DUNGEON, UNITYRINGTWO)) {
                if (PARTY_COUNT(player, type, doMsgs) == 1) {
                    ClearWall(player, type, doMsgs);
                }
                else {
                    WallText(player, type, doMsgs);
                }
            }
            else if (ALIGN(player, type, doMsgs) == CHAOS && HAS_ITEM(player, type, doMsgs, UNITYRING) && !FLAG_ON(player, type, doMsgs, DUNGEON, UNITYRINGTWO)) {
                SHOW_TEXT(player, type, doMsgs, "A heavenly voice proclaims -");
                SHOW_TEXT(player, type, doMsgs, "'This is the Door of Chaos.");
                SHOW_TEXT(player, type, doMsgs, "You must suffer much along the way, Beloved of Chaos, before the diverse ways are united.");
                SHOW_TEXT(player, type, doMsgs, "Do not take the lowly spawn of Harmony with you, or they will die.'");
                SET_FLAG(player, type, doMsgs, DUNGEON, UNITYRINGTWO, 1);
                SET_FLAG(player, type, doMsgs, PARTY, RINGB, 1);
                if (PARTY_COUNT(player, type, doMsgs) == 1) {
                    ClearWall(player, type, doMsgs);
                }
                else {
                    WallText(player, type, doMsgs);
                }
            }
            else if (FLAG_ON(player, type, doMsgs, DUNGEON, UNITYRINGTHREE)) {
                SHOW_TEXT(player, type, doMsgs, "A majestic voice announces -");
                SHOW_TEXT(player, type, doMsgs, "'The way is clear for wedded Harmony and Chaos to proceed.'");
                if (PARTY_COUNT(player, type, doMsgs) == 1) {
                    ClearWall(player, type, doMsgs);
                }
                else {
                    WallText(player, type, doMsgs);
                }
            }
            else if (ALIGN(player, type, doMsgs) == HARMONY && HAS_ITEM(player, type, doMsgs, UNITYRING) && FLAG_ON(player, type, doMsgs, DUNGEON, UNITYRINGONE)) {
                SHOW_TEXT(player, type, doMsgs, "A celestial voice chimes out -");
                SHOW_TEXT(player, type, doMsgs, "'This is the Door of Chaos. The child of Harmony should not yet pass this door.");
                SHOW_TEXT(player, type, doMsgs, "Great woe awaits the child of Harmony who does not obey!'");
                if (PARTY_COUNT(player, type, doMsgs) == 1) {
                    ClearWall(player, type, doMsgs);
                }
                else {
                    WallText(player, type, doMsgs);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "You see a door upon which 'Chaos' is carved.");
            }
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (ALIGN(player, type, doMsgs) == HARMONY && HAS_ITEM(player, type, doMsgs, UNITYRING) && FLAG_ON(player, type, doMsgs, DUNGEON, UNITYRINGONE)) {
                if (PARTY_COUNT(player, type, doMsgs) == 1) {
                    ClearWall(player, type, doMsgs);
                }
                else {
                    WallText(player, type, doMsgs);
                }
            }
            else if (ALIGN(player, type, doMsgs) == HARMONY && HAS_ITEM(player, type, doMsgs, UNITYRING) && !FLAG_ON(player, type, doMsgs, DUNGEON, UNITYRINGONE)) {
                SHOW_TEXT(player, type, doMsgs, "A heavenly voice proclaims -");
                SHOW_TEXT(player, type, doMsgs, "'This is the Door of Harmony.");
                SHOW_TEXT(player, type, doMsgs, "You must suffer much along the way, Beloved of Harmony, before the diverse ways are united.");
                SHOW_TEXT(player, type, doMsgs, "Do not yet take the lowly spawn of Chaos with you, or they will die.'");
                SET_FLAG(player, type, doMsgs, DUNGEON, UNITYRINGONE, 1);
                SET_FLAG(player, type, doMsgs, PARTY, RINGA, 1);
                if (PARTY_COUNT(player, type, doMsgs) == 1) {
                    ClearWall(player, type, doMsgs);
                }
                else {
                    WallText(player, type, doMsgs);
                }
            }
            else if (FLAG_ON(player, type, doMsgs, DUNGEON, UNITYRINGTHREE)) {
                SHOW_TEXT(player, type, doMsgs, "A majestic voice announces -");
                SHOW_TEXT(player, type, doMsgs, "'The way is clear for wedded Harmony and Chaos to proceed together.'");
                if (PARTY_COUNT(player, type, doMsgs) == 1) {
                    ClearWall(player, type, doMsgs);
                }
                else {
                    WallText(player, type, doMsgs);
                }
            }
            else if (ALIGN(player, type, doMsgs) == CHAOS && HAS_ITEM(player, type, doMsgs, UNITYRING) && FLAG_ON(player, type, doMsgs, DUNGEON, UNITYRINGTWO)) {
                SHOW_TEXT(player, type, doMsgs, "A celestial voice chimes out -");
                SHOW_TEXT(player, type, doMsgs, "'This is the Door of Harmony. The child of Chaos should not yet pass this door.");
                SHOW_TEXT(player, type, doMsgs, "Great woe awaits the child of Chaos who will not obey!'");
                if (PARTY_COUNT(player, type, doMsgs) == 1) {
                    ClearWall(player, type, doMsgs);
                }
                else {
                    WallText(player, type, doMsgs);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "You see a door upon which 'Harmony' is carved.");
            }
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Beyond the door you hear a low rumbling.");
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, UNITYRINGTHREE) == 1) {
                SHOW_TEXT(player, type, doMsgs, "The room is empty.");
            }
            else if ((HAS_ITEM(player, type, doMsgs, UNITYRING)) && ((GET_FLAG(player, type, doMsgs, DUNGEON, UNITYRINGONE) == 1) || (GET_FLAG(player, type, doMsgs, DUNGEON, UNITYRINGTWO) == 1))) {
                SHOW_TEXT(player, type, doMsgs, "Your burned hand is instantly healed.");
                SHOW_TEXT(player, type, doMsgs, "Your body tingles with new power.");
                SHOW_TEXT(player, type, doMsgs, "A voice whispers -");
                SHOW_TEXT(player, type, doMsgs, "'United in your heart are the powers of Chaos and Harmony!");
                SHOW_TEXT(player, type, doMsgs, "Find the Dralkarians and use your unified skills against them!'");
                TAKE_ITEM(player, type, doMsgs, UNITYRING);
                MOD_EXP(player, type, doMsgs, 750000);
                MOD_STAT(player, type, doMsgs, STRENGTH, 4);
                MOD_STAT(player, type, doMsgs, DEFENSE, 3);
                MOD_STAT(player, type, doMsgs, INITIATIVE, 1);
                SET_FLAG(player, type, doMsgs, DUNGEON, UNITYRINGTHREE, 1);
                SET_FLAG(player, type, doMsgs, DUNGEON, GETUNITYRING, 0);
                SET_FLAG(player, type, doMsgs, PARTY, RINGC, 1);
            }
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (ALIGN(player, type, doMsgs) == HARMONY && (GET_FLAG(player, type, doMsgs, DUNGEON, UNITYRINGTHREE) == 0) && (GET_FLAG(player, type, doMsgs, DUNGEON, HARMONYPUNISH) == 0)) {
                SHOW_TEXT(player, type, doMsgs, "An angry voice fills your head -");
                SHOW_TEXT(player, type, doMsgs, "'Hated Harmonic! Die for disobeying the elders who created these caverns!");
                SHOW_TEXT(player, type, doMsgs, "We strip from you more strength than you can bear to lose!'");
                SET_FLAG(player, type, doMsgs, DUNGEON, HARMONYPUNISH, 1);
                MOD_STAT(player, type, doMsgs, STRENGTH,  - 2);
                DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
            }
            else if (ALIGN(player, type, doMsgs) == HARMONY && (GET_FLAG(player, type, doMsgs, DUNGEON, UNITYRINGTHREE) == 0) && (GET_FLAG(player, type, doMsgs, DUNGEON, HARMONYPUNISH) != 0)) {
                SHOW_TEXT(player, type, doMsgs, "A booming voice surrounds you -");
                SHOW_TEXT(player, type, doMsgs, "'Die, thou miscreant spawn of Harmony! You may not traverse the way of Chaos yet!'");
                DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
            }
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (ALIGN(player, type, doMsgs) == CHAOS && (GET_FLAG(player, type, doMsgs, DUNGEON, UNITYRINGTHREE) == 0) && (GET_FLAG(player, type, doMsgs, DUNGEON, CHAOSPUNISH) == 0)) {
                SHOW_TEXT(player, type, doMsgs, "An angry voice fills your head -");
                SHOW_TEXT(player, type, doMsgs, "'Hated Chaotic! Die for disobeying the elders who created these caverns!");
                SHOW_TEXT(player, type, doMsgs, "We strip from you more strength than you can bear to lose!'");
                SET_FLAG(player, type, doMsgs, DUNGEON, CHAOSPUNISH, 1);
                MOD_STAT(player, type, doMsgs, STRENGTH,  - 2);
                DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
            }
            else if ((ALIGN(player, type, doMsgs) == CHAOS) && (GET_FLAG(player, type, doMsgs, DUNGEON, UNITYRINGTHREE) == 0) && (GET_FLAG(player, type, doMsgs, DUNGEON, CHAOSPUNISH) != 0)) {
                SHOW_TEXT(player, type, doMsgs, "A booming voice surrounds you -");
                SHOW_TEXT(player, type, doMsgs, "'Die, thou miscreant spawn of Chaos! You may not traverse the way of Harmony yet!'");
                DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
            }
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!FLAG_ON(player, type, doMsgs, DUNGEON, UNITYRINGTHREE)) {
                SHOW_PICTURE(player, type, doMsgs, HALFLINGCLERIC);
                SHOW_TEXT(player, type, doMsgs, "'To finish this quest, you will have to visit places in the Hopeless Hallways you have not been able to enter.'");
            }
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!HAS_ITEM(player, type, doMsgs, UNITYRING)) {
                SHOW_PICTURE(player, type, doMsgs, DWARFKNIGHT);
                SHOW_TEXT(player, type, doMsgs, "'You will have to detect the opening to the first secret room in Hopeless Hallways. It leads to the ring.'");
            }
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, ORCBARBARIAN);
            SHOW_TEXT(player, type, doMsgs, "'There is a place where what you walk on makes no difference...at times! I enjoyed my lava stroll.'");
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, ELFRANGER);
            SHOW_TEXT(player, type, doMsgs, "'Do NOT enter a place antithetical to your affiliation until you are told to do so.'");
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, HUMANTHIEF);
            SHOW_TEXT(player, type, doMsgs, "'Once you get to the end of Concordia, you can use a shortcut teleport in the Hopeless Hallways.'");
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, ORCKNIGHT);
            SHOW_TEXT(player, type, doMsgs, "'Beyond the realm of Pandemonium are the pathways to the Dralkarians.'");
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, GREMLINWIZARD);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, UNITYRINGONE) == 1) {
                SHOW_TEXT(player, type, doMsgs, "'You believer in Harmony, do not enter the Chaos Door until the path is cleared.'");
            }
            else if (GET_FLAG(player, type, doMsgs, DUNGEON, UNITYRINGTWO) == 1) {
                SHOW_TEXT(player, type, doMsgs, "'You follower of Chaos, do not enter the Harmony Door until the path is cleared.'");
            }
            else if (GET_FLAG(player, type, doMsgs, DUNGEON, UNITYRINGTHREE) == 1) {
                SHOW_TEXT(player, type, doMsgs, "'The way is clear for one who has united Harmony and Chaos. Find the Dralkarians and defeat them, as you have been bid.'");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "'To find the Doors of Harmony and Chaos requires patience.");
                SHOW_TEXT(player, type, doMsgs, "The walls around you lead one way and many ways.");
                SHOW_TEXT(player, type, doMsgs, "May you be wise enough to find the true way.'");
            }
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, HALFLINGTHIEF);
            SHOW_TEXT(player, type, doMsgs, "'You have started along the right path leading to the Doors of Chaos and Harmony.");
            SHOW_TEXT(player, type, doMsgs, "Much you must suffer before you reach the final exit!'");
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 3);
                GET_MONSTER(player, type, doMsgs, 02, 11);
                GET_MONSTER(player, type, doMsgs, 05, 26);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 4);
                GET_MONSTER(player, type, doMsgs, 02, 7);
                GET_MONSTER(player, type, doMsgs, 05, 1);
                GET_MONSTER(player, type, doMsgs, 06, 5);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 3);
                GET_MONSTER(player, type, doMsgs, 02, 4);
                GET_MONSTER(player, type, doMsgs, 03, 9);
                GET_MONSTER(player, type, doMsgs, 04, 8);
                GET_MONSTER(player, type, doMsgs, 05, 25);
                GET_MONSTER(player, type, doMsgs, 06, 2);
            }
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 13);
                GET_MONSTER(player, type, doMsgs, 02, 13);
                GET_MONSTER(player, type, doMsgs, 05, 27);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 29);
                GET_MONSTER(player, type, doMsgs, 02, 29);
                GET_MONSTER(player, type, doMsgs, 05, 30);
                GET_MONSTER(player, type, doMsgs, 06, 30);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 31);
                GET_MONSTER(player, type, doMsgs, 02, 31);
                GET_MONSTER(player, type, doMsgs, 03, 31);
                GET_MONSTER(player, type, doMsgs, 05, 34);
                GET_MONSTER(player, type, doMsgs, 06, 34);
            }
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 13);
                GET_MONSTER(player, type, doMsgs, 02, 17);
                GET_MONSTER(player, type, doMsgs, 06, 18);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 33);
                GET_MONSTER(player, type, doMsgs, 02, 33);
                GET_MONSTER(player, type, doMsgs, 05, 34);
                GET_MONSTER(player, type, doMsgs, 06, 34);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 34);
                GET_MONSTER(player, type, doMsgs, 02, 34);
                GET_MONSTER(player, type, doMsgs, 03, 33);
                GET_MONSTER(player, type, doMsgs, 04, 33);
                GET_MONSTER(player, type, doMsgs, 05, 35);
            }
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 21);
                GET_MONSTER(player, type, doMsgs, 02, 23);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 27);
                GET_MONSTER(player, type, doMsgs, 02, 27);
                GET_MONSTER(player, type, doMsgs, 03, 33);
                GET_MONSTER(player, type, doMsgs, 04, 33);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 13);
                GET_MONSTER(player, type, doMsgs, 02, 14);
                GET_MONSTER(player, type, doMsgs, 03, 32);
                GET_MONSTER(player, type, doMsgs, 04, 32);
                GET_MONSTER(player, type, doMsgs, 05, 30);
                GET_MONSTER(player, type, doMsgs, 06, 30);
            }
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 32);
                GET_MONSTER(player, type, doMsgs, 02, 32);
                GET_MONSTER(player, type, doMsgs, 04, 33);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 29);
                GET_MONSTER(player, type, doMsgs, 02, 29);
                GET_MONSTER(player, type, doMsgs, 05, 34);
                GET_MONSTER(player, type, doMsgs, 06, 34);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 21);
                GET_MONSTER(player, type, doMsgs, 02, 21);
                GET_MONSTER(player, type, doMsgs, 03, 28);
                GET_MONSTER(player, type, doMsgs, 04, 28);
                GET_MONSTER(player, type, doMsgs, 05, 23);
                GET_MONSTER(player, type, doMsgs, 06, 24);
            }
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, JEWELEDBREASTPLATE) || HAS_ITEM(player, type, doMsgs, DAWNSHEADPIECE)) {
                SET_BOOTY(player, type, doMsgs, MANAAMPHORA, 0, 0, 0, 0, 0);
            }
            else {
                SET_BOOTY(player, type, doMsgs, JEWELEDBREASTPLATE, DAWNSHEADPIECE, 0, 0, 0, 0);
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 40);
                GET_MONSTER(player, type, doMsgs, 05, 36);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 39);
                GET_MONSTER(player, type, doMsgs, 02, 40);
                GET_MONSTER(player, type, doMsgs, 06, 37);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 39);
                GET_MONSTER(player, type, doMsgs, 02, 40);
                GET_MONSTER(player, type, doMsgs, 03, 38);
                GET_MONSTER(player, type, doMsgs, 05, 36);
                GET_MONSTER(player, type, doMsgs, 06, 37);
            }
        }
        protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, WRATHOFFAITH) || HAS_ITEM(player, type, doMsgs, TWINBOLTS)) {
                SET_BOOTY(player, type, doMsgs, HEALAMPHORA, 0, 0, 0, 0, 0);
            }
            else {
                SET_BOOTY(player, type, doMsgs, WRATHOFFAITH, TWINBOLTS, 0, 0, 0, 0);
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 40);
                GET_MONSTER(player, type, doMsgs, 05, 36);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 39);
                GET_MONSTER(player, type, doMsgs, 02, 40);
                GET_MONSTER(player, type, doMsgs, 06, 37);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 39);
                GET_MONSTER(player, type, doMsgs, 02, 40);
                GET_MONSTER(player, type, doMsgs, 03, 38);
                GET_MONSTER(player, type, doMsgs, 05, 36);
                GET_MONSTER(player, type, doMsgs, 06, 37);
            }
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, KILLMONSTERF) == 1) || HAS_ITEM(player, type, doMsgs, PEACEMAKER) || HAS_ITEM(player, type, doMsgs, SPIRITUALARMOR)) {
                SHOW_TEXT(player, type, doMsgs, "The room has been looted.");
            }
            else if (ALIGN(player, type, doMsgs) == HARMONY) {
                SHOW_TEXT(player, type, doMsgs, "A soft voice whispers -");
                SHOW_TEXT(player, type, doMsgs, "'Well done, child of Harmony. Behold your reward!'");
                GIVE_ITEM(player, type, doMsgs, PEACEMAKER);
                GIVE_ITEM(player, type, doMsgs, SPIRITUALARMOR);
                GIVE_ITEM(player, type, doMsgs, GLASSBOW);
                SET_FLAG(player, type, doMsgs, DUNGEON, KILLMONSTERF, 1);
            }
        }
        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GET_FLAG(player, type, doMsgs, DUNGEON, KILLMONSTERG) == 1) || HAS_ITEM(player, type, doMsgs, ARNAKKIANSSTAFF) || HAS_ITEM(player, type, doMsgs, BLACKBLADE)) {
                SHOW_TEXT(player, type, doMsgs, "The room is empty.");
            }
            else if (ALIGN(player, type, doMsgs) == CHAOS) {
                SHOW_TEXT(player, type, doMsgs, "A soft voice whispers -");
                SHOW_TEXT(player, type, doMsgs, "'Well done, child of Chaos. Behold your reward!'");
                GIVE_ITEM(player, type, doMsgs, ARNAKKIANSSTAFF);
                GIVE_ITEM(player, type, doMsgs, BLACKBLADE);
                GIVE_ITEM(player, type, doMsgs, RODOFRESONANCE);
                SET_FLAG(player, type, doMsgs, DUNGEON, KILLMONSTERG, 1);
            }
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (FLAG_ON(player, type, doMsgs, DUNGEON, UNITYRINGTHREE) && PARTY_COUNT(player, type, doMsgs) == 1) {
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            }
        }
        protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_JOIN(player, type, doMsgs);
        }
        private void ClearWall(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
        }
        private void WallText(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Enter one at a time.");
        }
    }
}
