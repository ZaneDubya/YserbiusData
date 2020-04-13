using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    class TwMap19 : TwMap {
        public override int MapIndex => 19;
        public override int MapID => 0x0801;
        protected override int RandomEncounterChance => 15;
        protected override int RandomEncounterExtraCount => 2;

        private const int GOTTEXT = 1;
        private const int METQAO = 2;
        private const int FIGHTEREBUS = 3;
        private const int FIGHTPRAXIS = 4;
        private const int SERVANTS = 5;
        private const int SPRUNGTRAP = 1;
        private const int CHORONZAR_KILLED_BIT = 4;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The molten lava incinerates you!");
            DamageMax(player, type, doMsgs);
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You fall helplessly into oblivion.");
            DamageMax(player, type, doMsgs);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                ShowText(player, type, doMsgs, "The unusual force within this green blue fluid saps your magic powers.");
                ModifyMana(player, type, doMsgs,  - 100);
                DamageBy6(player, type, doMsgs);
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You bravely step onto this illusionary pit!");
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, LAVAGLOVE)) {
                ShowText(player, type, doMsgs, "The Lava Glove has led you to an illusionary lava pit!");
            }
            else {
                ShowText(player, type, doMsgs, "The lava here is an illusion!");
            }
            ClearWallItem(player, type, doMsgs, 180, Direction.East);
            ClearWallItem(player, type, doMsgs, 182, Direction.West);
            ClearWallItem(player, type, doMsgs, 181, Direction.East);
            ClearWallItem(player, type, doMsgs, 181, Direction.West);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "To the Main Entrance.");
            TeleportParty(player, type, doMsgs, 1, 1, 174, Direction.South);
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.WHICHPIECE, 0);
            if ((GetFlag(player, type, doMsgs, FlagTypeParty, GOTTEXT) == 0)) {
                ShowText(player, type, doMsgs, "You enter an enormous chessboard arena. It differs greatly from the one built by Arnakkian so many moons ago.");
                ShowText(player, type, doMsgs, "The red marble and onyx floor are truly beautiful.");
                ShowText(player, type, doMsgs, "You notice, however, that the pieces are not mere toys. They are real creatures. A black dragon, a white knight, and many others are present.");
                ShowText(player, type, doMsgs, "An ominous Erebus is seated against the southern wall. Next to him stands a magnificent Praxis.");
                ShowText(player, type, doMsgs, "They appear to be controlling the pieces, one of which you have now become.");
                SetFlag(player, type, doMsgs, FlagTypeParty, GOTTEXT, 1);
            }
            else {
                ShowText(player, type, doMsgs, "Once again you enter the board.");
            }
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int flag = 0;
            int mn = 0;
            int pflag = 0;
            switch (GetTile(player, type, doMsgs)) {
                case 119:
                    flag = TwIndexes.KILLEDEREBUS;
                    pflag = FIGHTEREBUS;
                    mn = 36;
                    break;
                case 120:
                    flag = TwIndexes.KILLEDPRAXIS;
                    pflag = FIGHTPRAXIS;
                    mn = 37;
                    break;
            }
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, flag) == 1) {
                if (flag == TwIndexes.KILLEDEREBUS) {
                    SetFlag(player, type, doMsgs, FlagTypeParty, FIGHTEREBUS, 1);
                }
                else {
                    SetFlag(player, type, doMsgs, FlagTypeParty, FIGHTPRAXIS, 1);
                }
            }
            else {
                DeadText(player, type, doMsgs);
            }
            if (GetFlag(player, type, doMsgs, FlagTypeParty, FIGHTEREBUS) == 1 || GetFlag(player, type, doMsgs, FlagTypeParty, FIGHTPRAXIS) == 1) {
                if (pflag == FIGHTEREBUS) {
                    ErebusText2(player, type, doMsgs);
                }
                else {
                    PraxisText2(player, type, doMsgs);
                }
                AddEncounter(player, type, doMsgs, 01, mn);
            }
        }
        private void ErebusText1(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The Erebus laughs at you.");
            ShowText(player, type, doMsgs, "'Away with you! You have not earned the right to challenge me!'");
        }
        private void ErebusText2(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The Erebus' laugh is loud and obnoxious. 'You puny mortals have no faith in games. Let us play another one, to the death!'");
        }
        private void PraxisText1(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The Praxis flaps his wings.");
            ShowText(player, type, doMsgs, "'Come, my friends, let us not be hasty.");
            ShowText(player, type, doMsgs, "I shall give you one chance to flee. Then you shall suffer my wrath.'");
        }
        private void PraxisText2(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The Praxis' wings flap powerful bursts of magical winds at you.");
            ShowText(player, type, doMsgs, "'Enough! You have earned my rage!'");
        }
        private void DeadText(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "This chess master now lays dead upon his throne.");
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                ShowText(player, type, doMsgs, "An eerie blue light sifts through a fissure in the wall.");
                ShowText(player, type, doMsgs, "I wouldn't venture here until you've completed the tasks Aeowyn has enjoined you with - namely, destroying the Dralkarians!");
                TeleportParty(player, type, doMsgs, 13, 1, 252, Direction.North);
            }
            else {
                ShowText(player, type, doMsgs, "You must enter here alone!");
                SetFacing(player, type, doMsgs, Direction.East);
            }
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == THIEF || GetGuild(player, type, doMsgs) == WIZARD) {
                if (HasUsedSkill(player, type, ref doMsgs, DETECT_SKILL) >= 12 || HasUsedSpell(player, type, ref doMsgs, TRUE_SEEING_SPELL) >= 1 || UsedItem(player, type, ref doMsgs, HELMOFWISDOM, HELMOFWISDOM) || UsedItem(player, type, ref doMsgs, VALKYRIESHELM, VALKYRIESHELM) || UsedItem(player, type, ref doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || UsedItem(player, type, ref doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                    ShowText(player, type, doMsgs, "The ancient stones become a portal.");
                    FnEvent0A(player, type, doMsgs);
                }
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, REDDRAGON);
            if ((GetFlag(player, type, doMsgs, FlagTypeParty, METQAO) == 0)) {
                ShowText(player, type, doMsgs, "Qao Tsur slowly opens his eyes, now thin slits of black in green-gold spheres. He sniffs at you.");
                ShowText(player, type, doMsgs, "His booming voice shakes the walls.");
                ShowText(player, type, doMsgs, "'So, mere mortals have at last appeared to seek the Dralkarians.");
                ShowText(player, type, doMsgs, "Your puny magics will not save you. I once stood at claw's length with the mighty beasts. You are no match for them in your weakling state.");
                ShowText(player, type, doMsgs, "Go, seek my feuding children below. They will offer you a task more suited to your abilities.");
                ShowText(player, type, doMsgs, "The Dralkarians will require special means before YOU can even dream of defeating them.");
                ShowText(player, type, doMsgs, "The chessmasters await you, you must outwit them...");
                ShowText(player, type, doMsgs, "...or out-fight them.");
                ShowText(player, type, doMsgs, "I offer you this advice, listen not to vain words of empty tongue.'");
                ShowText(player, type, doMsgs, "Qao then recedes into his slumber, ignoring you.");
                SetFlag(player, type, doMsgs, FlagTypeParty, METQAO, 1);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LAVAQUEST, 2);
            }
            else {
                ShowText(player, type, doMsgs, "Qao ignores you in his uneasy sleep.");
            }
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                ShowText(player, type, doMsgs, "The tremendous heat is devastating here.");
                DamageBy6(player, type, doMsgs);
                SetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP, 1);
            }
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                ShowText(player, type, doMsgs, "As you round the corner of this Dragon's Lair, a series of fire-bursts fly from the shadows, scorching you.");
                DamageBy2(player, type, doMsgs);
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableSpells(player, type, doMsgs);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                ShowText(player, type, doMsgs, "Poisonous gases seep into this area.");
                PoisonMe(player, type, doMsgs);
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "An ancient Red Dragon lies on his mountain of gold and other booty. As you enter his lair, you are weakened by the tremendous heat.");
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                DamageBy6(player, type, doMsgs);
                PoisonMe(player, type, doMsgs);
                SetDebuff(player, type, doMsgs, PARALYSIS, 50, 0);
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, type, doMsgs, 01, 32);
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int teleportRoom = 0;
            int chesspiece = 0;
            chesspiece = GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.WHICHPIECE);
            if (chesspiece == 2 && (GetTile(player, type, doMsgs) == 70 && GetFacing(player, type, doMsgs) == Direction.West) || (GetTile(player, type, doMsgs) == 73 && GetFacing(player, type, doMsgs) == Direction.East) || (GetTile(player, type, doMsgs) == 86 && GetFacing(player, type, doMsgs) == Direction.West) || (GetTile(player, type, doMsgs) == 89 && GetFacing(player, type, doMsgs) == Direction.East)) {
                ShowText(player, type, doMsgs, "You may leave the board through here.");
            }
            else {
                WallBlock(player, type, doMsgs);
                switch (chesspiece) {
                    case 1:
                        if (GetFacing(player, type, doMsgs) == Direction.North) {
                            teleportRoom = GetTile(player, type, doMsgs) - 15;
                        }
                        if (GetFacing(player, type, doMsgs) == Direction.East) {
                            teleportRoom = GetTile(player, type, doMsgs) + 17;
                        }
                        if (GetFacing(player, type, doMsgs) == Direction.South) {
                            teleportRoom = GetTile(player, type, doMsgs) + 15;
                        }
                        if (GetFacing(player, type, doMsgs) == Direction.West) {
                            teleportRoom = GetTile(player, type, doMsgs) - 17;
                        }
                        break;
                    case 2:
                        if (GetFacing(player, type, doMsgs) == Direction.North) {
                            teleportRoom = GetTile(player, type, doMsgs) - 33;
                        }
                        if (GetFacing(player, type, doMsgs) == Direction.East) {
                            teleportRoom = GetTile(player, type, doMsgs) - 14;
                        }
                        if (GetFacing(player, type, doMsgs) == Direction.South) {
                            teleportRoom = GetTile(player, type, doMsgs) + 33;
                        }
                        if (GetFacing(player, type, doMsgs) == Direction.West) {
                            teleportRoom = GetTile(player, type, doMsgs) + 14;
                        }
                        break;
                    case 3:
                        if (GetFacing(player, type, doMsgs) == Direction.North) {
                            teleportRoom = GetTile(player, type, doMsgs) - 16;
                        }
                        if (GetFacing(player, type, doMsgs) == Direction.East) {
                            teleportRoom = GetTile(player, type, doMsgs) + 1;
                        }
                        if (GetFacing(player, type, doMsgs) == Direction.South) {
                            teleportRoom = GetTile(player, type, doMsgs) + 16;
                        }
                        if (GetFacing(player, type, doMsgs) == Direction.West) {
                            teleportRoom = GetTile(player, type, doMsgs) - 1;
                        }
                        break;
                }
                if ((teleportRoom >= 37 && teleportRoom <= 42) || (teleportRoom >= 53 && teleportRoom <= 58) || (teleportRoom >= 68 && teleportRoom <= 75) || (teleportRoom >= 84 && teleportRoom <= 91) || (teleportRoom >= 101 && teleportRoom <= 106) || (teleportRoom >= 117 && teleportRoom <= 122)) {
                    TeleportParty(player, type, doMsgs, 8, 1, teleportRoom, GetFacing(player, type, doMsgs));
                }
                else {
                    CantMove(player, type, doMsgs);
                }
            }
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int mn = 0;
            switch (GetTile(player, type, doMsgs)) {
                case 102:
                    mn = 39;
                    break;
                case 105:
                    mn = 38;
                    break;
            }
            AddEncounter(player, type, doMsgs, 01, mn);
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int teleportRoom = 0;
            int chesspiece = 0;
            chesspiece = GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.WHICHPIECE);
            if (chesspiece == 2 && (GetTile(player, type, doMsgs) == 70 && GetFacing(player, type, doMsgs) == Direction.West) || (GetTile(player, type, doMsgs) == 73 && GetFacing(player, type, doMsgs) == Direction.East) || (GetTile(player, type, doMsgs) == 86 && GetFacing(player, type, doMsgs) == Direction.West) || (GetTile(player, type, doMsgs) == 89 && GetFacing(player, type, doMsgs) == Direction.East)) {
                ShowText(player, type, doMsgs, "You may leave the board through here.");
            }
            else {
                WallBlock(player, type, doMsgs);
                switch (chesspiece) {
                    case 1:
                        if (GetFacing(player, type, doMsgs) == Direction.North) {
                            teleportRoom = GetTile(player, type, doMsgs) - 15;
                        }
                        if (GetFacing(player, type, doMsgs) == Direction.East) {
                            teleportRoom = GetTile(player, type, doMsgs) + 17;
                        }
                        if (GetFacing(player, type, doMsgs) == Direction.South) {
                            teleportRoom = GetTile(player, type, doMsgs) + 15;
                        }
                        if (GetFacing(player, type, doMsgs) == Direction.West) {
                            teleportRoom = GetTile(player, type, doMsgs) - 17;
                        }
                        break;
                    case 2:
                        if (GetFacing(player, type, doMsgs) == Direction.North) {
                            teleportRoom = GetTile(player, type, doMsgs) - 31;
                        }
                        if (GetFacing(player, type, doMsgs) == Direction.East) {
                            teleportRoom = GetTile(player, type, doMsgs) + 18;
                        }
                        if (GetFacing(player, type, doMsgs) == Direction.South) {
                            teleportRoom = GetTile(player, type, doMsgs) + 31;
                        }
                        if (GetFacing(player, type, doMsgs) == Direction.West) {
                            teleportRoom = GetTile(player, type, doMsgs) - 18;
                        }
                        break;
                    case 3:
                        if (GetFacing(player, type, doMsgs) == Direction.North) {
                            teleportRoom = GetTile(player, type, doMsgs) - 16;
                        }
                        if (GetFacing(player, type, doMsgs) == Direction.East) {
                            teleportRoom = GetTile(player, type, doMsgs) + 1;
                        }
                        if (GetFacing(player, type, doMsgs) == Direction.South) {
                            teleportRoom = GetTile(player, type, doMsgs) + 16;
                        }
                        if (GetFacing(player, type, doMsgs) == Direction.West) {
                            teleportRoom = GetTile(player, type, doMsgs) - 1;
                        }
                        break;
                }
                if ((teleportRoom >= 37 && teleportRoom <= 42) || (teleportRoom >= 53 && teleportRoom <= 58) || (teleportRoom >= 68 && teleportRoom <= 75) || (teleportRoom >= 84 && teleportRoom <= 91) || (teleportRoom >= 101 && teleportRoom <= 106) || (teleportRoom >= 117 && teleportRoom <= 122)) {
                    TeleportParty(player, type, doMsgs, 8, 1, teleportRoom, GetFacing(player, type, doMsgs));
                }
                else {
                    CantMove(player, type, doMsgs);
                }
            }
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int teleportRoom = 0;
            WallBlock(player, type, doMsgs);
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.WHICHPIECE, 2);
            if (GetFacing(player, type, doMsgs) == Direction.North) {
                teleportRoom = GetTile(player, type, doMsgs) - 33;
            }
            if (GetFacing(player, type, doMsgs) == Direction.East) {
                teleportRoom = GetTile(player, type, doMsgs) - 14;
            }
            if (GetFacing(player, type, doMsgs) == Direction.South) {
                teleportRoom = GetTile(player, type, doMsgs) + 33;
            }
            if (GetFacing(player, type, doMsgs) == Direction.West) {
                teleportRoom = GetTile(player, type, doMsgs) + 14;
            }
            switch (GetTile(player, type, doMsgs)) {
                case 103:
                    if ((teleportRoom >= 37 && teleportRoom <= 42) || (teleportRoom >= 53 && teleportRoom <= 58) || (teleportRoom >= 68 && teleportRoom <= 75) || (teleportRoom >= 84 && teleportRoom <= 91) || (teleportRoom >= 101 && teleportRoom <= 106) || (teleportRoom >= 117 && teleportRoom <= 122)) {
                        TeleportParty(player, type, doMsgs, 8, 1, teleportRoom, GetFacing(player, type, doMsgs));
                    }
                    else {
                        CantMove(player, type, doMsgs);
                    }
                    break;
            }
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int teleportRoom = 0;
            WallBlock(player, type, doMsgs);
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.WHICHPIECE, 3);
            if (GetFacing(player, type, doMsgs) == Direction.North) {
                teleportRoom = GetTile(player, type, doMsgs) - 16;
            }
            if (GetFacing(player, type, doMsgs) == Direction.East) {
                teleportRoom = GetTile(player, type, doMsgs) + 1;
            }
            if (GetFacing(player, type, doMsgs) == Direction.South) {
                teleportRoom = GetTile(player, type, doMsgs) + 16;
            }
            if (GetFacing(player, type, doMsgs) == Direction.West) {
                teleportRoom = GetTile(player, type, doMsgs) - 1;
            }
            if ((teleportRoom >= 37 && teleportRoom <= 42) || (teleportRoom >= 53 && teleportRoom <= 58) || (teleportRoom >= 68 && teleportRoom <= 75) || (teleportRoom >= 84 && teleportRoom <= 91) || (teleportRoom >= 101 && teleportRoom <= 106) || (teleportRoom >= 117 && teleportRoom <= 122)) {
                TeleportParty(player, type, doMsgs, 8, 1, teleportRoom, GetFacing(player, type, doMsgs));
            }
            else {
                CantMove(player, type, doMsgs);
            }
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int teleportRoom = 0;
            WallBlock(player, type, doMsgs);
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.WHICHPIECE, 2);
            if (GetFacing(player, type, doMsgs) == Direction.North) {
                teleportRoom = GetTile(player, type, doMsgs) - 31;
            }
            if (GetFacing(player, type, doMsgs) == Direction.East) {
                teleportRoom = GetTile(player, type, doMsgs) + 18;
            }
            if (GetFacing(player, type, doMsgs) == Direction.South) {
                teleportRoom = GetTile(player, type, doMsgs) + 31;
            }
            if (GetFacing(player, type, doMsgs) == Direction.West) {
                teleportRoom = GetTile(player, type, doMsgs) - 18;
            }
            if ((teleportRoom >= 37 && teleportRoom <= 42) || (teleportRoom >= 53 && teleportRoom <= 58) || (teleportRoom >= 68 && teleportRoom <= 75) || (teleportRoom >= 84 && teleportRoom <= 91) || (teleportRoom >= 101 && teleportRoom <= 106) || (teleportRoom >= 117 && teleportRoom <= 122)) {
                TeleportParty(player, type, doMsgs, 8, 1, teleportRoom, GetFacing(player, type, doMsgs));
            }
            else {
                CantMove(player, type, doMsgs);
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                ShowText(player, type, doMsgs, "The lair is filled with lava pools and noxious odors.");
                PoisonMe(player, type, doMsgs);
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, type, doMsgs, 01, 33);
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A group of young Erebus move towards you, mumbling in their guttural tongue.");
            OfferBooty(player, type, doMsgs);
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    AddEncounter(player, type, doMsgs, 01, 31);
                    break;
                default:
                    AddEncounter(player, type, doMsgs, 01, 31);
                    AddEncounter(player, type, doMsgs, 02, 31);
                    AddEncounter(player, type, doMsgs, 05, 31);
                    break;
            }
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableSpells(player, type, doMsgs);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                ShowFntn(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The sweet waters feel refreshing at first, but soon make you feel nauseated.");
                PoisonMe(player, type, doMsgs);
                DamageBy6(player, type, doMsgs);
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowFntn(player, type, doMsgs);
            ShowText(player, type, doMsgs, "The fountain's sickening waters churn in your stomach, but slowly you begin feeling revived and healthy!");
            ModifyHealth(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowFntn(player, type, doMsgs);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                ShowText(player, type, doMsgs, "These sparkling waters are magical in nature and instantly restore your mana level.");
                ModifyMana(player, type, doMsgs, 5000);
                SetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP, 1);
            }
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                ShowText(player, type, doMsgs, "Fetid fumes reek of evil magic.");
                if (GetGuild(player, type, doMsgs) == WIZARD) {
                    ModifyMana(player, type, doMsgs,  - 250);
                }
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, PRAXISPRIEST);
            ShowText(player, type, doMsgs, "A young Praxis is donning his armor.");
            ShowText(player, type, doMsgs, "'Hail, young warriors!'");
            ShowText(player, type, doMsgs, "'Many secrets are hidden about that will aid you in solving the enigma of the Master's Arena. Be aware of whose square you are fighting for!'");
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HUMANWIZARD);
            ShowText(player, type, doMsgs, "A portly wizard fumbles with some magical tomes.");
            ShowText(player, type, doMsgs, "'What, what, what...? Who are you? Hmm, don't know the name.'");
            ShowText(player, type, doMsgs, "'Yes, yes, I know the Arena area. Have a look at those books over there on the wall. They should help you with your problem.'");
            ShowText(player, type, doMsgs, "He mumbles something about being bothered and returns to his reading.");
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, ELFBARBARIAN);
            ShowText(player, type, doMsgs, "'So, you're after the Dralkarians, eh? Well, good luck! The Night Elves worship those powerful deities.");
            ShowText(player, type, doMsgs, "If I were you - and I'm NOT, thank the heavens! - I'd be on the lookout for some peculiar items.");
            ShowText(player, type, doMsgs, "After all, the Dralks are not of this earth. Seek them in their unique homes. You will know what I mean in time.'");
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Archaic runes in some forgotten tongue cover this gateway.");
            if (HasItem(player, type, doMsgs, LAVAGLOVE)) {
                if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                    ShowText(player, type, doMsgs, "The lava glove allows you to open the portal.");
                    SprungTrap(player, type, doMsgs);
                    FnEvent0A(player, type, doMsgs);
                }
            }
            else {
                ShowRunes(player, type, ref doMsgs, "'This portal may be opened by the owner of the Lava Glove.'");
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LAVAQUEST, 2);
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Praxis thaumaturges hurl magical bolts at you.");
            OfferBooty(player, type, doMsgs);
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    AddEncounter(player, type, doMsgs, 01, 27);
                    AddEncounter(player, type, doMsgs, 02, 28);
                    break;
                case 2:
                    AddEncounter(player, type, doMsgs, 01, 27);
                    AddEncounter(player, type, doMsgs, 02, 28);
                    AddEncounter(player, type, doMsgs, 03, 28);
                    break;
                default:
                    AddEncounter(player, type, doMsgs, 01, 27);
                    AddEncounter(player, type, doMsgs, 02, 28);
                    AddEncounter(player, type, doMsgs, 05, 29);
                    AddEncounter(player, type, doMsgs, 06, 29);
                    break;
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, EREBUSFIEND);
            ShowText(player, type, doMsgs, "A wounded Erebus grabs your ankle.");
            ShowText(player, type, doMsgs, "'Kill me...kill me! If the Praxis discover me here, the war will be imminent.'");
            ShowText(player, type, doMsgs, "He then collapses...");
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, DWARFKNIGHT);
            ShowText(player, type, doMsgs, "'These feuding creatures are enough to drive me insane! I must defeat one of the Masters in the Arena.");
            ShowText(player, type, doMsgs, "Go see the scholar just south of here before you test your luck in the Arena. He has some books that will help you!'");
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "War-hardened guildsmen attack!");
            OfferBooty(player, type, doMsgs);
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    AddEncounter(player, type, doMsgs, 01, 25);
                    AddEncounter(player, type, doMsgs, 02, 30);
                    break;
                case 2:
                    AddEncounter(player, type, doMsgs, 01, 25);
                    AddEncounter(player, type, doMsgs, 02, 30);
                    AddEncounter(player, type, doMsgs, 03, 30);
                    break;
                default:
                    AddEncounter(player, type, doMsgs, 01, 25);
                    AddEncounter(player, type, doMsgs, 02, 30);
                    AddEncounter(player, type, doMsgs, 03, 30);
                    AddEncounter(player, type, doMsgs, 04, 35);
                    AddEncounter(player, type, doMsgs, 05, 26);
                    break;
            }
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A dusty collection of books, similar to those you can find in the Queen's Palace, offers you hints on the Masters' Arena.");
            ShowText(player, type, doMsgs, "'When you take over a square, you acquire the piece's abilities you just defeated!");
            ShowText(player, type, doMsgs, "Bishops move to corners, as north is to northeast.");
            ShowText(player, type, doMsgs, "Knights attack in leaps in bounds. From here to there, by an L of renown.");
            ShowText(player, type, doMsgs, "Rooks connect onto that which is directly in front of them. Remember, you become that which you destroy.'");
            ShowText(player, type, doMsgs, "      ==============");
            ShowText(player, type, doMsgs, "      =0 0 0 0 0 0 =");
            ShowText(player, type, doMsgs, "      =0 0 0 0 0 0 =");
            ShowText(player, type, doMsgs, "      =  0 0 0 B 0 =");
            ShowText(player, type, doMsgs, "      =  B>0 K R 0 =");
            ShowText(player, type, doMsgs, "      =0 0 K 0 0 0 =");
            ShowText(player, type, doMsgs, "      =0 0 E P 0 0 =");
            ShowText(player, type, doMsgs, "      ==============");
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A long tunnel twists downward to Dragon's Flame.");
            TeleportParty(player, type, doMsgs, 8, 2, 38, Direction.West);
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A flickering torch in the distance breaks the blackness around you. It marks the entrance to Dragon's Flame.");
            TeleportParty(player, type, doMsgs, 8, 2, 156, Direction.East);
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int value = 0;
            int chesspiece = 0;
            int mn = 0;
            chesspiece = GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.WHICHPIECE);
            chesspiece++;
            switch (chesspiece) {
                case 1:
                    mn = 34;
                    value = chesspiece;
                    break;
                case 2:
                    mn = 35;
                    value = chesspiece;
                    break;
                case 3:
                    mn = 38;
                    value = chesspiece;
                    break;
                case 4:
                    mn = 34;
                    value = 1;
                    break;
            }
            AddEncounter(player, type, doMsgs, 01, mn);
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.WHICHPIECE, value);
        }
        private void MasterTxt(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A hidden portal opens, allowing those who have defeated the Master an ingress.");
            FnEvent0A(player, type, doMsgs);
        }
        private void SoloTxt(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "There's something strange about the wall here. Only alone, and once you've defeated a Master of the Arena, will you be able to see it!");
            WallBlock(player, type, doMsgs);
        }
        private void OfferBooty(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int itemA = 0;
            int itemB = 0;
            int itemC = 0;
            switch (GetTile(player, type, doMsgs)) {
                case 178:
                    itemA = MANAAMPHORA;
                    itemB = BLACKBLADE;
                    break;
                case 62:
                    itemA = HEALAMPHORA;
                    itemB = PLATEOFIRON;
                    itemC = JADEDRING;
                    break;
                case 186:
                    itemA = HEALAMPHORA;
                    itemB = RODOFRESONANCE;
                    itemC = STONEOFTHEMAGI;
                    break;
                case 247:
                    itemA = SKULLAEGIS;
                    itemB = MANAAMPHORA;
                    itemC = SNAKESKINJACKET;
                    break;
            }
            if (GetTileState(player, type, doMsgs) != GetTile(player, type, doMsgs) && !HasItem(player, type, doMsgs, itemA)) {
                SetTreasure(player, type, doMsgs, itemA, itemB, itemC, 0, 0, 2000);
                SetTileState(player, type, doMsgs, GetTile(player, type, doMsgs));
            }
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void DamageMax(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
        }
        private void DamageBy2(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 2);
        }
        private void DamageBy6(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 6);
        }
        private void SprungTrap(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP, 1);
        }
        private void ShowFntn(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
        }
        private void CantMove(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A move here would place you off the chessboard!");
        }
        private void PoisonMe(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetDebuff(player, type, doMsgs, POISON, 10, 150);
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, JESTERSCAP) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.CHOR_NPC_KILLED) & CHORONZAR_KILLED_BIT) == 0) {
                ShowText(player, type, doMsgs, "A maniacal fiend appears; removes an item you stole from him; and kills you outright.");
                while (HasItem(player, type, doMsgs, JESTERSCAP))
                    RemoveItem(player, type, doMsgs, JESTERSCAP);
                    ModifyGold(player, type, doMsgs,  - 10000);
                    ModifyExperience(player, type, doMsgs,  - 200000);
                    DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
                }
                ShowText(player, type, doMsgs, "This area is certainly not the grand entrance to the Dralkarian kingdom you had envisioned.");
                ShowText(player, type, doMsgs, "The walls and floors are in decay, all covered with lichens and scorch marks. Pools of lava and shadow litter the floor.");
                ShowText(player, type, doMsgs, "The crumbling stones and cracked granite act as testimony to the war brewing between the Praxis and Erebus armies that dominate this domain.");
            }
            protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
                int flag = 0;
                int portroom = 0;
                switch (GetTile(player, type, doMsgs)) {
                    case 119:
                        flag = TwIndexes.KILLEDEREBUS;
                        portroom = 54;
                        break;
                    case 120:
                        flag = TwIndexes.KILLEDPRAXIS;
                        portroom = 57;
                        break;
                }
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, flag) == 0)) {
                    if (flag == TwIndexes.KILLEDEREBUS) {
                        ErebusText1(player, type, doMsgs);
                    }
                    else {
                        PraxisText1(player, type, doMsgs);
                    }
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, flag, 1);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.WHICHPIECE, 2);
                    TeleportParty(player, type, doMsgs, 8, 1, portroom, Direction.North);
                }
            }
            protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                    ShowText(player, type, doMsgs, "Ancient carvings of living chess pieces decorate this mysterious portal. Heavy fumes of evil seep upwards from this portal to Dragon's Flame.");
                    SprungTrap(player, type, doMsgs);
                }
                TeleportParty(player, type, doMsgs, 8, 2, 38, Direction.West);
            }
            protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (HasItem(player, type, doMsgs, LAVAGLOVE)) {
                    ShowText(player, type, doMsgs, "Your Lava Glove begins to glow with white-hot intensity...tugging you in this direction.");
                }
            }
            protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GetPartyCount(player, type, doMsgs) == 1) {
                    if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILLEDPRAXIS) == 2) {
                        MasterTxt(player, type, doMsgs);
                    }
                }
                else {
                    SoloTxt(player, type, doMsgs);
                }
            }
            protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
                int flag = 222;
                switch (GetTile(player, type, doMsgs)) {
                    case 135:
                        flag = TwIndexes.KILLEDEREBUS;
                        break;
                    case 136:
                        flag = TwIndexes.KILLEDPRAXIS;
                        break;
                }
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, flag) != 2 && GetFlag(player, type, doMsgs, FlagTypeDungeon, flag) == 1) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, flag, 2);
                    ModifyExperience(player, type, doMsgs, 350000);
                    ShowText(player, type, doMsgs, "Your prowess is acknowledged. Gain wisdom from your actions.");
                }
            }
            protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GetPartyCount(player, type, doMsgs) == 1) {
                    if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILLEDEREBUS) == 2) {
                        MasterTxt(player, type, doMsgs);
                    }
                }
                else {
                    SoloTxt(player, type, doMsgs);
                }
            }
            protected override void FnEvent3B(TwPlayerServer player, MapEventType type, bool doMsgs) {
                DisablePartyJoining(player, type, doMsgs);
            }
            protected override void FnEvent3C(TwPlayerServer player, MapEventType type, bool doMsgs) {
                ShowText(player, type, doMsgs, "A dark portal offers you descent into untamed depths of this dark underworld.");
                TeleportParty(player, type, doMsgs, 9, 2, 119, Direction.East);
            }
            protected override void FnEvent3D(TwPlayerServer player, MapEventType type, bool doMsgs) {
                int i = 0;
                ShowText(player, type, doMsgs, "Servants of Qao rise from the lava to repel encroaching invaders!");
                if (!HasItem(player, type, doMsgs, HEALAMPHORA) && (GetFlag(player, type, doMsgs, FlagTypeParty, SERVANTS) == 0)) {
                    SetTreasure(player, type, doMsgs, HEALAMPHORA, LIFEGIVER, SCORCHEDSCROLL, 0, 0, 2000);
                    SetFlag(player, type, doMsgs, FlagTypeParty, SERVANTS, 1);
                }
                switch (GetPartyCount(player, type, doMsgs)) {
                    case 1:
                    case 2:
                        for (i = 1; i <= 2; i++) {
                            AddEncounter(player, type, doMsgs, i, 24);
                        }
                    break;
                        default:
                            for (i = 1; i <= 4; i++) {
                                AddEncounter(player, type, doMsgs, i, 24);
                            }
                            break;
                        }
                    }
                }
            }
