using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    /// <summary>
    /// L3: Queen's Palace
    /// </summary>
    class TwMap07 : TwMap {
        public override int MapIndex => 7;
        public override int MapID => 0x0302;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        private const int MONSTERA = 1;
        private const int MONSTERB = 2;
        private const int HEALFOUNTAIN = 3;
        private const int MANAFOUNTAIN = 4;
        private const int QUEENGUARD = 5;
        private const int SPRUNGTRAP = 1;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.FINISHEDGAME) == 1) {
                ShowText(player, type, doMsgs, "You see an empty, cracked throne.");
                ShowText(player, type, doMsgs, "The Queen is no more.");
            }
            else {
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DONEPROVING) == 1) {
                    ShowPortrait(player, type, doMsgs, QUEENAEOWYN);
                    ShowText(player, type, doMsgs, "A magnificent queen stands before you.");
                    ShowText(player, type, doMsgs, "Her beauty and strength awe all who see her, woman and man alike. This is Queen Aeowyn.");
                    ShowText(player, type, doMsgs, "'My champions, a key awaits you at the palace exit. Use it at the ancient gateway east of the main entrance.");
                    ShowText(player, type, doMsgs, "Another portal will lead you to the depths of this volcano, where none has dared yet visit.");
                    ShowText(player, type, doMsgs, "I require four pieces of an ancient map! I enjoin you with this task as a test of your loyalty.");
                    ShowText(player, type, doMsgs, "Reveal your purpose to no one! Go now! Seek the Kingdom of the Night Elves.");
                    ShowText(player, type, doMsgs, "I will meet you at your quest's end, that we may piece together the maps' meaning.'");
                    ShowText(player, type, doMsgs, "With a royal wave of dismissal, Aeowyn weaves a spell of parting and vanishes.");
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DONEPROVING, 2);
                }
                else {
                    ShowText(player, type, doMsgs, "Queen Aeowyn must be off looking for clues.");
                }
            }
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "This leads back to the Coliseum.");
            TeleportParty(player, type, doMsgs, 3, 1, 127, Direction.North);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetTileBlock(player, type, doMsgs, GetTile(player, type, doMsgs));
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The warm waters soothe your pains.");
            ModifyHealth(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
            ShowText(player, type, doMsgs, "Elaborate fountains mark the entryway to Queen Aeowyn's throne room.");
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You fall into a pit and are impaled on razor sharp spears.");
            DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (UsedItem(player, type, ref doMsgs, CROSSKEY, CROSSKEY)) {
                ShowText(player, type, doMsgs, "The Cross Key unlocks the door!");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
            else {
                ShowText(player, type, doMsgs, "The door's lock is marked with an X.");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HINTEDATDOOR) == 1) {
                if (HasUsedSkill(player, type, ref doMsgs, DETECT_SKILL) >= 9 || HasUsedSpell(player, type, ref doMsgs, TRUE_SEEING_SPELL) >= 1 || UsedItem(player, type, ref doMsgs, HELMOFWISDOM, HELMOFWISDOM) || UsedItem(player, type, ref doMsgs, VALKYRIESHELM, VALKYRIESHELM) || UsedItem(player, type, ref doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || UsedItem(player, type, ref doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                    ShowText(player, type, doMsgs, "You manage to find the marked stone the old thief mentioned. The door is now open.");
                    ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                    SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                }
                else {
                    ShowText(player, type, doMsgs, "The stone must be here somewhere.");
                    ShowText(player, type, doMsgs, "Perhaps you are not skilled enough.");
                    WallBlock(player, type, doMsgs);
                }
            }
            else {
                ShowText(player, type, doMsgs, "Something seems out of place here, but you can't tell what.");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HINTEDATDOOR) == 1) {
                ShowText(player, type, doMsgs, "The old thief has slipped away into the shadows.");
            }
            else {
                ShowPortrait(player, type, doMsgs, HUMANTHIEF);
                ShowText(player, type, doMsgs, "An old thief stands to greet you.");
                ShowText(player, type, doMsgs, "'Hail! You seem a bit puzzled and a lot lost.");
                ShowText(player, type, doMsgs, "There's a wall to the southeast of here.");
                ShowText(player, type, doMsgs, "There you'll find a stone that is marked with an ancient rune. Try detecting it to continue your way.'");
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HINTEDATDOOR, 1);
            }
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The final problem!");
            ShowText(player, type, doMsgs, "There are short and long pathways to the Queen's chambers.");
            ShowText(player, type, doMsgs, "Each has its own reward. Only one need be solved to continue, but the more explored, the greater the rewards.");
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowRunes(player, type, ref doMsgs, "The Queen's Hall of Records.");
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowRunes(player, type, ref doMsgs, "Studies on Nature and Science.");
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowRunes(player, type, ref doMsgs, "Classical.");
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowRunes(player, type, ref doMsgs, "Irrelevant.");
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            switch (GetTile(player, type, doMsgs)) {
                case 49:
                    if (GetFacing(player, type, doMsgs) == Direction.North) {
                        FlipStr(player, type, doMsgs);
                    }
                    break;
                case 50:
                    if (GetFacing(player, type, doMsgs) == Direction.South) {
                        ShowRunes(player, type, ref doMsgs, "This book is entitled -CHESS-. It mentions how one space on a board belongs to whatever piece lands on it and captures it.");
                    }
                    break;
                case 34:
                    if (GetFacing(player, type, doMsgs) == Direction.South) {
                        ShowRunes(player, type, ref doMsgs, "Another CHESS book- Bishop then Knight then Rook is how you march to face the King.");
                    }
                    break;
                case 33:
                    if (GetFacing(player, type, doMsgs) == Direction.North) {
                        FlipStr(player, type, doMsgs);
                    }
                    break;
                case 17:
                    if (GetFacing(player, type, doMsgs) == Direction.South) {
                        ShowRunes(player, type, ref doMsgs, "CHESS III- Changing from one piece to the next is the key to understanding the mastery of any arena.");
                    }
                    break;
                case 18:
                    if (GetFacing(player, type, doMsgs) == Direction.North) {
                        FlipStr(player, type, doMsgs);
                    }
                    break;
            }
        }
        private void FlipStr(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You pull a large volume from the shelf and flip randomly through the pages.");
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Guttural curses and howls of agony from a battlefield to the east chill your bones.");
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DIDFIREBALL) == 0)) {
                if (UsedItem(player, type, ref doMsgs, FLAMETONGUE, FLAMETONGUE) || UsedItem(player, type, ref doMsgs, FLAMEBLADE, FLAMEBLADE) || UsedItem(player, type, ref doMsgs, WRATHOFFAITH, WRATHOFFAITH) || UsedItem(player, type, ref doMsgs, STAFFOFJUSTICE, STAFFOFJUSTICE) || UsedItem(player, type, ref doMsgs, BOWOFFLAMES, BOWOFFLAMES) || UsedItem(player, type, ref doMsgs, AEGISDDRACO, AEGISDDRACO) || UsedItem(player, type, ref doMsgs, NEROSLYRE, NEROSLYRE) || UsedItem(player, type, ref doMsgs, SCROLLOFTHESUN, SCROLLOFTHESUN) || UsedItem(player, type, ref doMsgs, SCORCHEDSCROLL, SCORCHEDSCROLL)) {
                    switch (GetTile(player, type, doMsgs)) {
                        case 9:
                            ShowText(player, type, doMsgs, "The fireball travels down the corridor and fizzles.");
                            break;
                        case 24:
                            ShowText(player, type, doMsgs, "You launch a fireball across the chasm.");
                            ShowText(player, type, doMsgs, "In seconds it turns back upon you!");
                            DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 6);
                            break;
                        case 25:
                            ShowText(player, type, doMsgs, "The fireball flies over the chasm into darkness.");
                            ShowText(player, type, doMsgs, "It then comes hurtling back at you, exploding before you can escape its wrath.");
                            DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 8);
                            break;
                        case 41:
                            ShowText(player, type, doMsgs, "You send a fireball hurtling across the chasm.");
                            ShowText(player, type, doMsgs, "The booming report of an explosion alerts you that some trigger has been switched.");
                            ShowText(player, type, doMsgs, "A bridge extends out from this edge of the chasm, allowing you to proceed.");
                            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DIDFIREBALL, 1);
                            ClearTileBlock(player, type, doMsgs, 42);
                            SetFloorItem(player, type, doMsgs, 0, 42);
                            break;
                    }
                }
                else {
                    ShowText(player, type, doMsgs, "The walls and floors here are scorched and charred with magical fire.");
                    ShowText(player, type, doMsgs, "Perhaps you can send some light across the chasm to see if any burning clues are visible.");
                }
            }
            else {
                ShowText(player, type, doMsgs, "The bridge you triggered earlier has now vanished.");
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DIDFIREBALL, 0);
                SetFloorItem(player, type, doMsgs, 1, 42);
            }
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "'Travel through here at your own risk!' Signed-Lord Gnog.");
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                ShowText(player, type, doMsgs, "You set off a poisonous gas trap!");
                SetDebuff(player, type, doMsgs, POISON, 8, 70);
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                ShowText(player, type, doMsgs, "Another trap is triggered, sending death darts tipped with poison showering down upon you.");
                SetDebuff(player, type, doMsgs, POISON, 5, 60);
                DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 6);
                SprungTrap(player, type, doMsgs);
            }
        }
        private void SprungTrap(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP, 1);
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableAutomaps(player, type, doMsgs);
            ShowText(player, type, doMsgs, "You are unable to map this area.");
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You could have sworn there was a door here a second ago.");
            WallBlock(player, type, doMsgs);
            ClearWallItem(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                switch (GetFacing(player, type, doMsgs)) {
                    case Direction.North:
                        SetFacing(player, type, doMsgs, Direction.West);
                        SprungTrap(player, type, doMsgs);
                        break;
                    case Direction.South:
                        SetFacing(player, type, doMsgs, Direction.East);
                        SprungTrap(player, type, doMsgs);
                        break;
                    case Direction.East:
                        SetFacing(player, type, doMsgs, Direction.South);
                        SprungTrap(player, type, doMsgs);
                        break;
                    case Direction.West:
                        SetFacing(player, type, doMsgs, Direction.East);
                        SprungTrap(player, type, doMsgs);
                        break;
                }
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                switch (GetFacing(player, type, doMsgs)) {
                    case Direction.North:
                        SetFacing(player, type, doMsgs, Direction.South);
                        SprungTrap(player, type, doMsgs);
                        break;
                    case Direction.South:
                        SetFacing(player, type, doMsgs, Direction.West);
                        SprungTrap(player, type, doMsgs);
                        break;
                    case Direction.East:
                        SetFacing(player, type, doMsgs, Direction.North);
                        SprungTrap(player, type, doMsgs);
                        break;
                    case Direction.West:
                        SetFacing(player, type, doMsgs, Direction.East);
                        SprungTrap(player, type, doMsgs);
                        break;
                }
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "'Hail, Queen Aeowyn! All would-be champions, approach and report.'");
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The air is thick with the stench of battle and death. This Arena overflows with those who would be the Queen's champions.");
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "An enormous Barbarian stands over his most recent kill. He turns and charges at you!");
            AddEncounter(player, type, doMsgs, 01, 35);
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "An ominous Wizard admires the fallen hero he just incinerated. He then fires a barrage of fireballs at you!");
            DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 6);
            AddEncounter(player, type, doMsgs, 01, 36);
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            if ((GetFlag(player, type, doMsgs, FlagTypeParty, QUEENGUARD) == 0)) {
                ShowPortrait(player, type, doMsgs, DWARFKNIGHT);
                ShowText(player, type, doMsgs, "One of the Queen's Guards is here. 'No stealing!'");
                ShowText(player, type, doMsgs, "I'm sure you'll obey his wish!!");
                SetFlag(player, type, doMsgs, FlagTypeParty, QUEENGUARD, 1);
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeParty, QUEENGUARD) == 1) {
                ShowPortrait(player, type, doMsgs, DWARFKNIGHT);
                ShowText(player, type, doMsgs, "The Guard is much more agitated. 'Be off with you! I've no kindness towards loitering fools.'");
                SetFlag(player, type, doMsgs, FlagTypeParty, QUEENGUARD, 2);
            }
            else {
                ShowText(player, type, doMsgs, "'ENOUGH! I have had enough of you!'");
                ShowText(player, type, doMsgs, "'GUARDS!!!!!'");
                SetTreasure(player, type, doMsgs, LONGSWORD, CROSSBOW, ELIXIROFHEALTH, 0, 0, 0);
                for (i = 1; i <= 6; i++) {
                    AddEncounter(player, type, doMsgs, i, 40);
                }
                SetFlag(player, type, doMsgs, FlagTypeParty, QUEENGUARD, 0);
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A mob prepares to attack!");
            AddEncounter(player, type, doMsgs, 01, 10);
            AddEncounter(player, type, doMsgs, 02, 11);
            AddEncounter(player, type, doMsgs, 03, 20);
            AddEncounter(player, type, doMsgs, 04, 17);
            AddEncounter(player, type, doMsgs, 05, 33);
            AddEncounter(player, type, doMsgs, 06, 33);
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Young warriors leap at you!");
            AddEncounter(player, type, doMsgs, 01, 31);
            AddEncounter(player, type, doMsgs, 02, 32);
            AddEncounter(player, type, doMsgs, 03, 31);
            AddEncounter(player, type, doMsgs, 04, 32);
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A seasoned party launches an offensive!");
            AddEncounter(player, type, doMsgs, 01, 25);
            AddEncounter(player, type, doMsgs, 02, 26);
            AddEncounter(player, type, doMsgs, 03, 27);
            AddEncounter(player, type, doMsgs, 04, 28);
            AddEncounter(player, type, doMsgs, 05, 29);
            AddEncounter(player, type, doMsgs, 06, 30);
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, DWARFKNIGHT);
            ShowText(player, type, doMsgs, "This place offers a vantage point of the entire combat field.");
            ShowText(player, type, doMsgs, "The Master of Arms grins broadly as you enter.");
            ShowText(player, type, doMsgs, "'Here, look, see that? A wizard taking on a warrior!");
            ShowText(player, type, doMsgs, "If that knight were better trained, he'd have known not to challenge while his sword was in its sheath!'");
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableAutomaps(player, type, doMsgs);
            ShowText(player, type, doMsgs, "The thieves who inhabit this area spring upon you!");
            AddEncounter(player, type, doMsgs, 01, 32);
            AddEncounter(player, type, doMsgs, 02, 32);
            AddEncounter(player, type, doMsgs, 03, 28);
            AddEncounter(player, type, doMsgs, 04, 28);
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            if (GetFlag(player, type, doMsgs, FlagTypeParty, MONSTERA) == 0) {
                ShowText(player, type, doMsgs, "Vicious beasts snarl at you.");
                if (GetPartyCount(player, type, doMsgs) < 3) {
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 39);
                    }
                }
                else {
                    for (i = 1; i <= 5; i++) {
                        AddEncounter(player, type, doMsgs, i, 39);
                    }
                }
                SetFlag(player, type, doMsgs, FlagTypeParty, MONSTERA, 1);
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeParty, MONSTERA) == 1) {
                ShowText(player, type, doMsgs, "Some passing adventurers notice the slain beasts here. They then challenge you to combat.");
                SetTreasure(player, type, doMsgs, IRONCUTLASS, HEALPOTION, 0, 0, 0, 250);
                for (i = 1; i <= 4; i++) {
                    AddEncounter(player, type, doMsgs, i, 36);
                }
                SetFlag(player, type, doMsgs, FlagTypeParty, MONSTERA, 2);
            }
            else {
                ShowText(player, type, doMsgs, "Corpses stripped of all possessions litter this area.");
                SetFlag(player, type, doMsgs, FlagTypeParty, MONSTERA, 0);
            }
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            if (GetFlag(player, type, doMsgs, FlagTypeParty, MONSTERB) == 0) {
                ShowText(player, type, doMsgs, "Vicious panthers growl as you approach.");
                for (i = 1; i <= 4; i++) {
                    AddEncounter(player, type, doMsgs, i, 38);
                }
                SetFlag(player, type, doMsgs, FlagTypeParty, MONSTERB, 1);
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeParty, MONSTERB) == 1) {
                ShowText(player, type, doMsgs, "Oozing slime coats the carcasses on the floor. The slime rears up as you approach!");
                for (i = 1; i <= 4; i++) {
                    AddEncounter(player, type, doMsgs, i, 37);
                }
                SetFlag(player, type, doMsgs, FlagTypeParty, MONSTERB, 2);
            }
            else {
                ShowText(player, type, doMsgs, "A slick, viscous fluid covers the area.");
                SetFlag(player, type, doMsgs, FlagTypeParty, MONSTERB, 0);
            }
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, TROLLCLERIC);
            ShowText(player, type, doMsgs, "'These walls are trickery. You need advice from one wiser than I. Beware of the dark dungeon rooms, for they are impossible to map!!'");
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
            int timesused = 0;
            timesused = 0;
            if (GetFlag(player, type, doMsgs, FlagTypeParty, HEALFOUNTAIN) < 3) {
                timesused = GetFlag(player, type, doMsgs, FlagTypeParty, MANAFOUNTAIN);
                ShowText(player, type, doMsgs, "The magic of the cool waters heals your wounds.");
                ModifyHealth(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
                timesused++;
                SetFlag(player, type, doMsgs, FlagTypeParty, HEALFOUNTAIN, timesused);
            }
            else {
                ShowText(player, type, doMsgs, "The waters offer no refreshment.");
            }
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
            int timesused = 0;
            timesused = 0;
            if (GetFlag(player, type, doMsgs, FlagTypeParty, MANAFOUNTAIN) < 3) {
                timesused = GetFlag(player, type, doMsgs, FlagTypeParty, MANAFOUNTAIN);
                ShowText(player, type, doMsgs, "The magic of the cool waters restores your mana.");
                ModifyMana(player, type, doMsgs, 1000);
                timesused++;
                SetFlag(player, type, doMsgs, FlagTypeParty, MANAFOUNTAIN, timesused);
            }
            else {
                ShowText(player, type, doMsgs, "The waters offer no refreshment.");
            }
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, GNOMEBARBARIAN);
            ShowText(player, type, doMsgs, "--Lord Galabryan III--");
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, DWARFKNIGHT);
            ShowText(player, type, doMsgs, "--King Leowyn--");
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HUMANBARBARIAN);
            ShowText(player, type, doMsgs, "--King Theowayen--");
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, DWARFKNIGHT);
            ShowText(player, type, doMsgs, "--King Cleowyn--");
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HUMANWIZARD);
            ShowText(player, type, doMsgs, "--Arnakkian Slowfoot--");
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.FINISHEDGAME) == 1) {
                ShowPortrait(player, type, doMsgs, QUEENAEOWYN);
                ShowText(player, type, doMsgs, "  --Queen Aeowyn--");
                ShowText(player, type, doMsgs, "--recently deceased--");
            }
            else {
                ShowText(player, type, doMsgs, "  Reserved for:");
                ShowText(player, type, doMsgs, "--Queen Aeowyn--");
            }
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Through here is the Corridor of Ancestry.");
            ShowText(player, type, doMsgs, "The Queen's heritage shall not be forgotten.");
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DONEPROVING) == 2) {
                ShowText(player, type, doMsgs, "The waters become calm, allowing you to pass.");
            }
            else {
                ShowText(player, type, doMsgs, "A mystical force prevents you from moving freely, and sends you back to the floor.");
                TeleportParty(player, type, doMsgs, 3, 2, 142, Direction.East);
            }
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You are confused and disoriented in this pitch black room.  The torchlight is diffused by some murky smoke.");
            ShowText(player, type, doMsgs, "You are unable to map this area.");
            DisableAutomaps(player, type, doMsgs);
        }
        protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DONEPROVING) == 2) {
                ShowText(player, type, doMsgs, "This portal will take you to the main entrance.");
                if (HasItem(player, type, doMsgs, QUEENSKEY) || IsTrue(GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DEEPPORTALS))) {
                    TeleportParty(player, type, doMsgs, 1, 1, 204, Direction.East);
                }
                else {
                    ShowText(player, type, doMsgs, "In a glass case by the door is the key promised you by the Queen.");
                    GiveItem(player, type, doMsgs, QUEENSKEY);
                    TeleportParty(player, type, doMsgs, 1, 1, 204, Direction.East);
                }
            }
            else {
                ShowText(player, type, doMsgs, "Away! You cannot use this teleport!");
            }
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ENDGAMETELE) == 1) {
                if (GetPartyCount(player, type, doMsgs) == 1) {
                    ShowText(player, type, doMsgs, "You may proceed.");
                    TeleportParty(player, type, doMsgs, 3, 2, 189, Direction.East);
                }
            }
        }
        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                ShowText(player, type, doMsgs, "Onward you go to the next teleport.");
                TeleportParty(player, type, doMsgs, 4, 3, 0, Direction.South);
            }
            else {
                ShowText(player, type, doMsgs, "ALONE! ONLY ALONE MAY YOU PROCEED!!!");
                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 2);
                TeleportParty(player, type, doMsgs, 3, 2, 142, Direction.West);
            }
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DIDFIREBALL) == 1) {
                ShowText(player, type, doMsgs, "The trigger has released a drawbridge of sorts, allowing you to pass over the chasm.");
                ClearTileBlock(player, type, doMsgs, 42);
                SetFloorItem(player, type, doMsgs, 0, 42);
            }
            else {
                ShowText(player, type, doMsgs, "You plummet to your death in the deep chasm.");
                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
            }
        }
        protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasUsedSkill(player, type, ref doMsgs, DETECT_SKILL) >= 9 || HasUsedSpell(player, type, ref doMsgs, TRUE_SEEING_SPELL) >= 1 || UsedItem(player, type, ref doMsgs, HELMOFWISDOM, HELMOFWISDOM) || UsedItem(player, type, ref doMsgs, VALKYRIESHELM, VALKYRIESHELM) || UsedItem(player, type, ref doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || UsedItem(player, type, ref doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                ShowText(player, type, doMsgs, "You discern light seeping through the crack of a secret door!");
                SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
        }
        protected override void FnEvent3B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int flag = 0;
            int exps = 0;
            switch (GetTile(player, type, doMsgs)) {
                case 94:
                    flag = TwIndexes.DIDUPPERRIGHT;
                    exps = 25000;
                    break;
                case 57:
                    flag = TwIndexes.DIDMIDDLEUP;
                    exps = 15000;
                    break;
                case 217:
                    flag = TwIndexes.DIDMIDDLELOW;
                    exps = 20000;
                    break;
                case 234:
                    flag = TwIndexes.DIDLOWERRIGHT;
                    exps = 25000;
                    break;
            }
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, flag) == 0)) {
                ShowPortrait(player, type, doMsgs, QUEENAEOWYN);
                TextStr(player, type, doMsgs);
                Queen(player, type, doMsgs);
                // GiveWeapon(player, type, doMsgs);
                DoneProving(player, type, doMsgs);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, flag, 1);
                ModifyExperience(player, type, doMsgs, exps);
            }
        }

        private void TextStr(TwPlayerServer player, MapEventType type, bool doMsgs) {
            switch (GetTile(player, type, doMsgs)) {
                case 94:
                    ShowText(player, type, doMsgs, "You've conquered the chasm, I grant you your reward!");
                    break;
                case 57:
                    ShowText(player, type, doMsgs, "Well done! Did you enjoy the Hall of Ancestry!?!");
                    break;
                case 217:
                    ShowText(player, type, doMsgs, "Impressive, how you managed to pass through the arena!");
                    break;
                case 234:
                    ShowText(player, type, doMsgs, "The Gauntlet you ran was not as hard as some others!");
                    break;
            }
        }
        private void DoneProving(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DONEPROVING) == 0)) {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DONEPROVING, 1);
            }
        }
        private void Queen(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Now, to my throne room, I will wait for you there!");
        }
        protected override void FnEvent3C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.WIZSPELL) == 0)) {
                if (GetGuild(player, type, doMsgs) == WIZARD || GetGuild(player, type, doMsgs) == THIEF) {
                    GiveSpell(player, type, doMsgs, FIREBALL_SPELL, 1);
                    ShowPortrait(player, type, doMsgs, FOUNTAIN);
                    ShowText(player, type, doMsgs, "The steaming fountain's waters offer a powerful source of energy.");
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.WIZSPELL, 1);
                }
                else {
                    ShowPortrait(player, type, doMsgs, FOUNTAIN);
                    ShowText(player, type, doMsgs, "You are scalded by the burning waters.");
                    DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 6);
                }
            }
        }
        protected override void FnEvent3D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LORDGNOG) == 0)) {
                ShowText(player, type, doMsgs, "An elderly wizard sits here, poring over books.");
                ShowText(player, type, doMsgs, "'We meet at last. My envoys have told me so much about you.");
                ShowText(player, type, doMsgs, "They've helped me keep track of your achievements and failures.");
                ShowText(player, type, doMsgs, "Have you enjoyed my traps? Ah, well, some do, some don't.");
                ShowText(player, type, doMsgs, "Since you've found me, perhaps you'd like to try for a little revenge.");
                ShowText(player, type, doMsgs, "Come! Let's get on with it.'");
                SetTreasure(player, type, doMsgs, MANDRAKESTAFF, TRANCETALISMAN, SLIVERBAR, 0, 0, 2000);
            }
            AddEncounter(player, type, doMsgs, 01, 34);
        }
        protected override void FnEvent3E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LORDGNOG) == 0)) {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LORDGNOG, 1);
            }
        }
        protected override void FnEvent3F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "To the entrance of the palace.");
            TeleportParty(player, type, doMsgs, 3, 2, 128, Direction.East);
        }
    }
}
