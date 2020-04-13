using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    /// <summary>
    /// L1: Gauntlet Droit
    /// </summary>
    class TwMap02 : TwMap {
        public override int MapIndex => 2;
        public override int MapID => 0x0103;
        protected override int RandomEncounterChance => 15;
        protected override int RandomEncounterExtraCount => 0;

        private const int BEENHERE = 1;
        private const int GOTFLAG = 1;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Through here is the Main Entrance.");
            TeleportParty(player, type, doMsgs, 1, 1, 140, Direction.West);
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 1, 3, 159, Direction.South);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Now, enter the Coil Maze, and retrieve the Gauntlet.");
            TeleportParty(player, type, doMsgs, 1, 3, 247, Direction.West);
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "To the North side....");
            TeleportParty(player, type, doMsgs, 1, 3, 155, Direction.North);
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The sign here reads: The gauntlet has been thrown down in the Coil Maze.");
            ShowText(player, type, doMsgs, "Now you must return it to its birth place, to solve this quest and complete this most simple phase.");
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Depart not from the path which Fate has assigned you! You shall come full circle in time. And begin here what ends asunder.");
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "This way to the Great Egress.");
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The Great Egress...");
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "As you see, not all teleports lead to a different dungeon.");
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                if (HasItem(player, type, doMsgs, LAVAGLOVE) || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LAVAQUEST) == 2) {
                    int teleportroom = 0;
                    RemoveItem(player, type, doMsgs, LAVAGLOVE);
                    ShowText(player, type, doMsgs, "You've won the challenge of the Gauntlet. I shall send you to its end.");
                    switch (GetGuild(player, type, doMsgs)) {
                        case BARBARIAN:
                            teleportroom = 31;
                            break;
                        case KNIGHT:
                            teleportroom = 47;
                            break;
                        case RANGER:
                            teleportroom = 63;
                            break;
                        case THIEF:
                            teleportroom = 79;
                            break;
                        case WIZARD:
                            teleportroom = 95;
                            break;
                        case CLERIC:
                            teleportroom = 111;
                            break;
                    }
                    TeleportParty(player, type, doMsgs, 1, 3, teleportroom, Direction.East);
                }
                else {
                    ShowText(player, type, doMsgs, "A wind whistles, 'Bring me the gauntlet from the maze south of here....'");
                    TeleportParty(player, type, doMsgs, 1, 3, 120, Direction.East);
                }
            }
            else {
                ShowText(player, type, doMsgs, "A forceful wind pushes your party back from the ancient forge. It howls, 'You must each step forth alone!'");
                TeleportParty(player, type, doMsgs, 1, 3, 120, Direction.East);
            }
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Here you enter the Coils of the Maze...");
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
            if (GetPartyLevel(player, type, doMsgs, 10)) {
                Nothing(player, type, doMsgs);
            }
            else if (GetHealthCurrent(player, type, doMsgs) < GetHealthMax(player, type, doMsgs)) {
                ShowText(player, type, doMsgs, "The refreshing waters heal your wounds.");
                ModifyHealth(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
            }
            else {
                Nothing(player, type, doMsgs);
            }
        }
        private void Nothing(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The fountain does nothing for you.");
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.FIRSTQUEST) == 0)) {
                int skill = 0;
                int spell = 0;
                int itemA = 0;
                switch (GetTile(player, type, doMsgs)) {
                    case 31:
                        ShowText(player, type, doMsgs, "Well done, great Barbarian!");
                        skill = ARCHERY_SKILL;
                        spell = STORM_WIND_SPELL;
                        itemA = GREENLOCKPICK;
                        break;
                    case 47:
                        ShowText(player, type, doMsgs, "Well done, noble Knight!");
                        skill = CHANNEL_SKILL;
                        spell = CURSE_SPELL;
                        itemA = CRYSTALBALL;
                        break;
                    case 63:
                        ShowText(player, type, doMsgs, "Well done, loyal Ranger!");
                        skill = INTIMIDATE_SKILL;
                        spell = PETRIFY_SPELL;
                        itemA = CROSSBOW;
                        break;
                    case 79:
                        ShowText(player, type, doMsgs, "Well done, master Thief!");
                        skill = ARCHERY_SKILL;
                        spell = BACKFIRE_SPELL;
                        itemA = LEATHERJACKET;
                        break;
                    case 95:
                        ShowText(player, type, doMsgs, "Well done, master Wizard!");
                        skill = DEFLECT_MAGIC_SKILL;
                        spell = HEAL_SPELL;
                        itemA = QUARTERSTAFF;
                        break;
                    case 111:
                        ShowText(player, type, doMsgs, "Well done, devout Cleric!");
                        skill = RUNE_READING_SKILL;
                        spell = LIGHTNING_SPELL;
                        itemA = QUARTERSTAFF;
                        break;
                }
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.FIRSTQUEST, 1);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LAVAQUEST, 2);
                ShowText(player, type, doMsgs, "Take this spell and this skill as rewards for your questing; and gain experience from your actions.");
                ModifyExperience(player, type, doMsgs, 1000);
                SetSkill(player, type, doMsgs, skill, 1);
                GiveSpell(player, type, doMsgs, spell, 1);
                GiveItem(player, type, doMsgs, itemA);
            }
            else {
                ShowText(player, type, doMsgs, "You've already received your rewards.");
            }
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            if (HasItem(player, type, doMsgs, READTRACKSTALISMAN)) {
                ShowText(player, type, doMsgs, "Mages hurl magic at you!");
            }
            else {
                SetTreasure(player, type, doMsgs, READTRACKSTALISMAN, 0, 0, 0, 0, 35);
                ShowText(player, type, doMsgs, "You come across some ancient Wizards!");
            }
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    AddEncounter(player, type, doMsgs, 01, 27);
                    break;
                case 2:
                    for (i = 1; i <= 3; i++) {
                        AddEncounter(player, type, doMsgs, i, 27);
                    }
                    break;
                default:
                    ShowText(player, type, doMsgs, "And their familiars!");
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 34);
                    }
                    for (i = 3; i <= 4; i++) {
                        AddEncounter(player, type, doMsgs, i, 27);
                    }
                    break;
            }
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            if (HasItem(player, type, doMsgs, CRYSTALBALL)) {
                ShowText(player, type, doMsgs, "Some Berserkers turn to attack!");
            }
            else {
                SetTreasure(player, type, doMsgs, CRYSTALBALL, 0, 0, 0, 0, 100);
                ShowText(player, type, doMsgs, "Berserkers fighting over a spherical crystal draw you into the fray!");
            }
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    AddEncounter(player, type, doMsgs, 01, 31);
                    break;
                case 2:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 32);
                    }
                    break;
                default:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 32);
                    }
                    for (i = 3; i <= 4; i++) {
                        AddEncounter(player, type, doMsgs, i, 33);
                    }
                    break;
            }
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            if (HasItem(player, type, doMsgs, HEALPOTION)) {
                ShowText(player, type, doMsgs, "You encounter some novice adventurers.");
            }
            else {
                ShowText(player, type, doMsgs, "Wizards and Brigands traveling together challenge you to combat!  The wager is your life for their potion!");
                SetTreasure(player, type, doMsgs, HEALPOTION, 0, 0, 0, 0, 100);
            }
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    AddEncounter(player, type, doMsgs, 01, 25);
                    break;
                case 2:
                    AddEncounter(player, type, doMsgs, 1, 25);
                    AddEncounter(player, type, doMsgs, 2, 26);
                    break;
                default:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 26);
                    }
                    for (i = 5; i <= 6; i++) {
                        AddEncounter(player, type, doMsgs, i, 25);
                    }
                    break;
            }
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    AddEncounter(player, type, doMsgs, 01, 35);
                    break;
                case 2:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 35);
                    }
                    break;
                default:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 25);
                    }
                    for (i = 3; i <= 5; i++) {
                        AddEncounter(player, type, doMsgs, i, 35);
                    }
                    break;
            }
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, TELEPORTPASS)) {
                ShowText(player, type, doMsgs, "Young thieves jump you!");
            }
            else {
                SetTreasure(player, type, doMsgs, TELEPORTPASS, 0, 0, 0, 0, 100);
                ShowText(player, type, doMsgs, "A thief tucks a sheet of paper under his jacket as he and his colleagues hear you approach.");
            }
            if (GetPartyCount(player, type, doMsgs) == 1 || GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 35);
                AddEncounter(player, type, doMsgs, 02, 34);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 34);
                AddEncounter(player, type, doMsgs, 02, 35);
                AddEncounter(player, type, doMsgs, 03, 36);
                AddEncounter(player, type, doMsgs, 04, 37);
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Small pinholes of light seep through the cracks in the wall here.");
            if ((HasUsedSkill(player, type, ref doMsgs, DETECT_SKILL) >= 3) || (HasUsedSpell(player, type, ref doMsgs, TRUE_SEEING_SPELL) >= 1) || UsedItem(player, type, ref doMsgs, CRYSTALBALL, CRYSTALBALL) || UsedItem(player, type, ref doMsgs, VALKYRIESHELM, VALKYRIESHELM) || UsedItem(player, type, ref doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || UsedItem(player, type, ref doMsgs, HELMOFWISDOM, HELMOFWISDOM)) {
                SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ShowText(player, type, doMsgs, "You've uncovered a hidden door!");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
            else {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ClearWallItem(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            if (HasItem(player, type, doMsgs, LAVAGLOVE)) {
                ShowText(player, type, doMsgs, "Rogues rush out at you from the shadows.");
                SetTreasure(player, type, doMsgs, LONGSWORD, HEALPOTION, 0, 0, 0, 250);
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LAVAQUEST) == 2 || (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LAVAQUEST) == 0)) {
                ShowText(player, type, doMsgs, "You spot the Lava Glove on the rogue leader's hand, as he signals his henchmen to attack!");
                SetTreasure(player, type, doMsgs, LAVAGLOVE, MANAELIXIR, ELIXIROFHEALTH, 0, 0, 1000);
            }
            else if (!HasItem(player, type, doMsgs, LAVAGLOVE)) {
                ShowText(player, type, doMsgs, "You spot the Lava Glove on the rogue leader's hand, as he signals his henchmen to attack!");
                SetTreasure(player, type, doMsgs, LAVAGLOVE, HEALPOTION, 0, 0, 0, 250);
            }
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    AddEncounter(player, type, doMsgs, 01, 26);
                    AddEncounter(player, type, doMsgs, 05, 37);
                    break;
                case 2:
                    AddEncounter(player, type, doMsgs, 01, 26);
                    AddEncounter(player, type, doMsgs, 02, 28);
                    AddEncounter(player, type, doMsgs, 06, 37);
                    break;
                default:
                    for (i = 1; i <= 4; i++) {
                        AddEncounter(player, type, doMsgs, i, 26);
                    }
                    AddEncounter(player, type, doMsgs, 5, 29);
                    AddEncounter(player, type, doMsgs, 6, 37);
                    break;
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ENDGAMETELE) == 1) {
                ShowText(player, type, doMsgs, "This is the nexus point from where you start your final journey...");
                TeleportParty(player, type, doMsgs, 2, 3, 255, Direction.North);
            }
            else {
                ShowText(player, type, doMsgs, "What a magnificent carving, you must come back and examine it more closely when you have time.");
                ShowText(player, type, doMsgs, "But right now there's too much to do.");
            }
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallItem(player, type, doMsgs, 157, Direction.West);
            ClearWallItem(player, type, doMsgs, 124, Direction.West);
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeParty, BEENHERE) == 0)) {
                ShowText(player, type, doMsgs, "Swords and sorcery come rushing at you!");
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeParty, BEENHERE) == 1) {
                ShowText(player, type, doMsgs, "Duelists and Wizards attack as you approach.");
                SetTreasure(player, type, doMsgs, BROADSWORD, QUARTERSTAFF, 0, 0, 0, 200);
            }
            if (GetPartyCount(player, type, doMsgs) == 1 || GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 38);
                AddEncounter(player, type, doMsgs, 05, 39);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 39);
                AddEncounter(player, type, doMsgs, 02, 40);
                AddEncounter(player, type, doMsgs, 03, 38);
                AddEncounter(player, type, doMsgs, 04, 39);
            }
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, GOTFLAG) == 0)) {
                int i = 0;
                i = GetFlag(player, type, doMsgs, FlagTypeParty, BEENHERE);
                if (i <= 1) {
                    i++;
                    SetFlag(player, type, doMsgs, FlagTypeParty, BEENHERE, i);
                }
                SetFlag(player, type, doMsgs, FlagTypeTile, GOTFLAG, 1);
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "This seems an odd place for a teleport.");
            TeleportParty(player, type, doMsgs, 1, 3, 123, Direction.South);
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 1, 3, 152, Direction.West);
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Into the corner with you.");
            TeleportParty(player, type, doMsgs, 1, 3, 240, Direction.East);
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 1, 3, 250, Direction.North);
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowRunes(player, type, ref doMsgs, "The Gauntlet is a useful item. But first you must enter the coils to retrieve it.");
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The rewards are worthwhile, if you are careful and search all the corners.");
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Welcome to the southern half of The Gauntlet.");
            ShowText(player, type, doMsgs, "Feel free to explore the coils while you are here.");
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowRunes(player, type, ref doMsgs, "They can be found to the north by going east and south of where you are.");
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "There must be a portal tucked away in some distant corner.");
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowRunes(player, type, ref doMsgs, "To the northeast, there lies such a portal.");
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Westward, an ancient foundry, now extinct, lies at the bottom of a shaft. It was here that the Lava Glove was born...and here it must return once you've retrieved it.");
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (UsedItem(player, type, ref doMsgs, GREENLOCKPICK, BLUELOCKPICK) || HasUsedSkill(player, type, ref doMsgs, LOCKPICK_SKILL) > 1) {
                ShowText(player, type, doMsgs, "You've picked the lock. Proceed.");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
            else {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ShowText(player, type, doMsgs, "A locked door impedes your progress here.");
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, LAVAGLOVE) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LAVAQUEST) == 0)) {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LAVAQUEST, 1);
                ShowText(player, type, doMsgs, "Well done! Now, to the ancient foundry near the heart of this level. You must step onto the foundry in the center to return the Gauntlet!");
                ShowText(player, type, doMsgs, "Hurry, your rewards await!");
            }
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Magical waters spill out of the southern portal here; culminating in a small puddle on the floor.");
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                ShowText(player, type, doMsgs, "To the Snake River.");
                TeleportParty(player, type, doMsgs, 1, 2, 223, Direction.West);
            }
            else {
                TeleportParty(player, type, doMsgs, 1, 3, GetTile(player, type, doMsgs), Direction.North);
                ShowText(player, type, doMsgs, "Your party must split and enter this narrow portal one by one to proceed.");
            }
        }
    }
}
