namespace XPT.Twinion.Maps {
    class TwMap19 : TwMap {
        protected override int MapIndex => 19;
        protected override int MapID => 0x0801;
        protected override int RandomEncounterChance => 15;
        protected override int RandomEncounterExtraCount => 2;

        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The molten lava incinerates you!");
            DamageMax(player, type, doMsgs);
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You fall helplessly into oblivion.");
            DamageMax(player, type, doMsgs);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                SHOW_TEXT(player, type, doMsgs, "The unusual force within this green blue fluid saps your magic powers.");
                MOD_MANA(player, type, doMsgs,  - , 100);
                DamageBy6(player, type, doMsgs);
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You bravely step onto this illusionary pit!");
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, LAVAGLOVE)) {
                SHOW_TEXT(player, type, doMsgs, "The Lava Glove has led you to an illusionary lava pit!");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The lava here is an illusion!");
            }
            REMOVE_WALL_ITEM(player, type, doMsgs, 180, EAST);
            REMOVE_WALL_ITEM(player, type, doMsgs, 182, WEST);
            REMOVE_WALL_ITEM(player, type, doMsgs, 181, EAST);
            REMOVE_WALL_ITEM(player, type, doMsgs, 181, WEST);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "To the Main Entrance.");
            TELEPORT(player, type, doMsgs, 1, 1, 174, SOUTH);
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_FLAG(player, type, doMsgs, DUNGEON, WHICHPIECE, 0);
            if (!GET_FLAG(player, type, doMsgs, PARTY, GOTTEXT)) {
                SHOW_TEXT(player, type, doMsgs, "You enter an enormous chessboard arena. It differs greatly from the one built by Arnakkian so many moons ago.");
                SHOW_TEXT(player, type, doMsgs, "The red marble and onyx floor are truly beautiful.");
                SHOW_TEXT(player, type, doMsgs, "You notice, however, that the pieces are not mere toys. They are real creatures. A black dragon, a white knight, and many others are present.");
                SHOW_TEXT(player, type, doMsgs, "An ominous Erebus is seated against the southern wall. Next to him stands a magnificent Praxis.");
                SHOW_TEXT(player, type, doMsgs, "They appear to be controlling the pieces, one of which you have now become.");
                SET_FLAG(player, type, doMsgs, PARTY, GOTTEXT, 1);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Once again you enter the board.");
            }
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short flag;
            short mn;
            short pflag;
            switch (HERE()) {
                case 119:
                    flag = KILLEDEREBUS;
                    pflag = FIGHTEREBUS;
                    mn = 36;
                    break;
                case 120:
                    flag = KILLEDPRAXIS;
                    pflag = FIGHTPRAXIS;
                    mn = 37;
                    break;
            }
            if (GET_FLAG(player, type, doMsgs, DUNGEON, flag) == 1) {
                if (flag == KILLEDEREBUS) {
                    SET_FLAG(player, type, doMsgs, PARTY, FIGHTEREBUS, 1);
                }
                else {
                    SET_FLAG(player, type, doMsgs, PARTY, FIGHTPRAXIS, 1);
                }
            }
            else {
                DeadText(player, type, doMsgs);
            }
            if (GET_FLAG(player, type, doMsgs, PARTY, FIGHTEREBUS) == 1 || GET_FLAG(player, type, doMsgs, PARTY, FIGHTPRAXIS) == 1) {
                if (pflag == FIGHTEREBUS) {
                    ErebusText2(player, type, doMsgs);
                }
                else {
                    PraxisText2(player, type, doMsgs);
                }
                GET_MONSTER(player, type, doMsgs, 01, mn);
            }
        }
        private void ErebusText1(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The Erebus laughs at you.");
            SHOW_TEXT(player, type, doMsgs, "'Away with you! You have not earned the right to challenge me!'");
        }
        private void ErebusText2(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The Erebus' laugh is loud and obnoxious. 'You puny mortals have no faith in games. Let us play another one, to the death!'");
        }
        private void PraxisText1(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The Praxis flaps his wings.");
            SHOW_TEXT(player, type, doMsgs, "'Come, my friends, let us not be hasty.");
            SHOW_TEXT(player, type, doMsgs, "I shall give you one chance to flee. Then you shall suffer my wrath.'");
        }
        private void PraxisText2(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The Praxis' wings flap powerful bursts of magical winds at you.");
            SHOW_TEXT(player, type, doMsgs, "'Enough! You have earned my rage!'");
        }
        private void DeadText(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This chess master now lays dead upon his throne.");
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT() == 1) {
                SHOW_TEXT(player, type, doMsgs, "An eerie blue light sifts through a fissure in the wall.");
                SHOW_TEXT(player, type, doMsgs, "I wouldn't venture here until you've completed the tasks Aeowyn has enjoined you with - namely, destroying the Dralkarians!");
                TELEPORT(player, type, doMsgs, 13, 1, 252, NORTH);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "You must enter here alone!");
                ROTATE(player, type, doMsgs, EAST);
            }
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD() == THIEF || GUILD() == WIZARD) {
                if (USED_SKILL(player, type, doMsgs, DETECT_SKILL) >= 12 || USED_SPELL(player, type, doMsgs, TRUE_SEEING_SPELL) || USED_ITEM(player, type, doMsgs, HELMOFWISDOM, HELMOFWISDOM) || USED_ITEM(player, type, doMsgs, VALKYRIESHELM, VALKYRIESHELM) || USED_ITEM(player, type, doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || USED_ITEM(player, type, doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                    SHOW_TEXT(player, type, doMsgs, "The ancient stones become a portal.");
                    special10(player, type, doMsgs);
                }
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, REDDRAGON);
            if (!GET_FLAG(player, type, doMsgs, PARTY, METQAO)) {
                SHOW_TEXT(player, type, doMsgs, "Qao Tsur slowly opens his eyes, now thin slits of black in green-gold spheres. He sniffs at you.");
                SHOW_TEXT(player, type, doMsgs, "His booming voice shakes the walls.");
                SHOW_TEXT(player, type, doMsgs, "'So, mere mortals have at last appeared to seek the Dralkarians.");
                SHOW_TEXT(player, type, doMsgs, "Your puny magics will not save you. I once stood at claw's length with the mighty beasts. You are no match for them in your weakling state.");
                SHOW_TEXT(player, type, doMsgs, "Go, seek my feuding children below. They will offer you a task more suited to your abilities.");
                SHOW_TEXT(player, type, doMsgs, "The Dralkarians will require special means before YOU can even dream of defeating them.");
                SHOW_TEXT(player, type, doMsgs, "The chessmasters await you, you must outwit them...");
                SHOW_TEXT(player, type, doMsgs, "...or out-fight them.");
                SHOW_TEXT(player, type, doMsgs, "I offer you this advice, listen not to vain words of empty tongue.'");
                SHOW_TEXT(player, type, doMsgs, "Qao then recedes into his slumber, ignoring you.");
                SET_FLAG(player, type, doMsgs, PARTY, METQAO, 1);
                SET_FLAG(player, type, doMsgs, DUNGEON, LAVAQUEST, 2);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Qao ignores you in his uneasy sleep.");
            }
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                SHOW_TEXT(player, type, doMsgs, "The tremendous heat is devastating here.");
                DamageBy6(player, type, doMsgs);
                SET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP, 1);
            }
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                SHOW_TEXT(player, type, doMsgs, "As you round the corner of this Dragon's Lair, a series of fire-bursts fly from the shadows, scorching you.");
                DamageBy2(player, type, doMsgs);
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_SPELL();
            if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                SHOW_TEXT(player, type, doMsgs, "Poisonous gases seep into this area.");
                PoisonMe(player, type, doMsgs);
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "An ancient Red Dragon lies on his mountain of gold and other booty. As you enter his lair, you are weakened by the tremendous heat.");
            if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                DamageBy6(player, type, doMsgs);
                PoisonMe(player, type, doMsgs);
                SET_PM(player, type, doMsgs, PARALYSIS, 50, 0);
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            GET_MONSTER(player, type, doMsgs, 01, 32);
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short teleportRoom;
            short chesspiece;
            chesspiece = GET_FLAG(player, type, doMsgs, DUNGEON, WHICHPIECE);
            if (chesspiece == 2 && (HERE() == 70 &  & FACING() == WEST) |  | (HERE() == 73 &  & FACING() == EAST) |  | (HERE() == 86 &  & FACING() == WEST) |  | (HERE() == 89 &  & FACING() == EAST)) {
                SHOW_TEXT(player, type, doMsgs, "You may leave the board through here.");
            }
            else {
                WallBlock(player, type, doMsgs);
                switch (chesspiece) {
                    case 1:
                        if (FACING() == NORTH) {
                            teleportRoom = HERE();
                        }
                         - 15;
                        if (FACING() == EAST) {
                            teleportRoom = HERE();
                        }
                         + 17;
                        if (FACING() == SOUTH) {
                            teleportRoom = HERE();
                        }
                         + 15;
                        if (FACING() == WEST) {
                            teleportRoom = HERE();
                        }
                         - 17;
                        break;
                    case 2:
                        if (FACING() == NORTH) {
                            teleportRoom = HERE();
                        }
                         - 33;
                        if (FACING() == EAST) {
                            teleportRoom = HERE();
                        }
                         - 14;
                        if (FACING() == SOUTH) {
                            teleportRoom = HERE();
                        }
                         + 33;
                        if (FACING() == WEST) {
                            teleportRoom = HERE();
                        }
                         + 14;
                        break;
                    case 3:
                        if (FACING() == NORTH) {
                            teleportRoom = HERE();
                        }
                         - 16;
                        if (FACING() == EAST) {
                            teleportRoom = HERE();
                        }
                         + 1;
                        if (FACING() == SOUTH) {
                            teleportRoom = HERE();
                        }
                         + 16;
                        if (FACING() == WEST) {
                            teleportRoom = HERE();
                        }
                         - 1;
                        break;
                }
                if ((teleportRoom >= 37 &  & teleportRoom <= 42) |  | (teleportRoom >= 53 &  & teleportRoom <= 58) |  | (teleportRoom >= 68 &  & teleportRoom <= 75) |  | (teleportRoom >= 84 &  & teleportRoom <= 91) |  | (teleportRoom >= 101 &  & teleportRoom <= 106) |  | (teleportRoom >= 117 &  & teleportRoom <= 122)) {
                    TELEPORT(player, type, doMsgs, 8, 1, teleportRoom, FACING());
                }
                else {
                    CantMove(player, type, doMsgs);
                }
            }
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short mn;
            switch (HERE()) {
                case 102:
                    mn = 39;
                    break;
                case 105:
                    mn = 38;
                    break;
            }
            GET_MONSTER(player, type, doMsgs, 01, mn);
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short teleportRoom;
            short chesspiece;
            chesspiece = GET_FLAG(player, type, doMsgs, DUNGEON, WHICHPIECE);
            if (chesspiece == 2 && (HERE() == 70 &  & FACING() == WEST) |  | (HERE() == 73 &  & FACING() == EAST) |  | (HERE() == 86 &  & FACING() == WEST) |  | (HERE() == 89 &  & FACING() == EAST)) {
                SHOW_TEXT(player, type, doMsgs, "You may leave the board through here.");
            }
            else {
                WallBlock(player, type, doMsgs);
                switch (chesspiece) {
                    case 1:
                        if (FACING() == NORTH) {
                            teleportRoom = HERE();
                        }
                         - 15;
                        if (FACING() == EAST) {
                            teleportRoom = HERE();
                        }
                         + 17;
                        if (FACING() == SOUTH) {
                            teleportRoom = HERE();
                        }
                         + 15;
                        if (FACING() == WEST) {
                            teleportRoom = HERE();
                        }
                         - 17;
                        break;
                    case 2:
                        if (FACING() == NORTH) {
                            teleportRoom = HERE();
                        }
                         - 31;
                        if (FACING() == EAST) {
                            teleportRoom = HERE();
                        }
                         + 18;
                        if (FACING() == SOUTH) {
                            teleportRoom = HERE();
                        }
                         + 31;
                        if (FACING() == WEST) {
                            teleportRoom = HERE();
                        }
                         - 18;
                        break;
                    case 3:
                        if (FACING() == NORTH) {
                            teleportRoom = HERE();
                        }
                         - 16;
                        if (FACING() == EAST) {
                            teleportRoom = HERE();
                        }
                         + 1;
                        if (FACING() == SOUTH) {
                            teleportRoom = HERE();
                        }
                         + 16;
                        if (FACING() == WEST) {
                            teleportRoom = HERE();
                        }
                         - 1;
                        break;
                }
                if ((teleportRoom >= 37 &  & teleportRoom <= 42) |  | (teleportRoom >= 53 &  & teleportRoom <= 58) |  | (teleportRoom >= 68 &  & teleportRoom <= 75) |  | (teleportRoom >= 84 &  & teleportRoom <= 91) |  | (teleportRoom >= 101 &  & teleportRoom <= 106) |  | (teleportRoom >= 117 &  & teleportRoom <= 122)) {
                    TELEPORT(player, type, doMsgs, 8, 1, teleportRoom, FACING());
                }
                else {
                    CantMove(player, type, doMsgs);
                }
            }
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short teleportRoom;
            WallBlock(player, type, doMsgs);
            SET_FLAG(player, type, doMsgs, DUNGEON, WHICHPIECE, 2);
            if (FACING() == NORTH) {
                teleportRoom = HERE();
            }
             - 33;
            if (FACING() == EAST) {
                teleportRoom = HERE();
            }
             - 14;
            if (FACING() == SOUTH) {
                teleportRoom = HERE();
            }
             + 33;
            if (FACING() == WEST) {
                teleportRoom = HERE();
            }
             + 14;
            switch (HERE()) {
                case 103:
                    if ((teleportRoom >= 37 &  & teleportRoom <= 42) |  | (teleportRoom >= 53 &  & teleportRoom <= 58) |  | (teleportRoom >= 68 &  & teleportRoom <= 75) |  | (teleportRoom >= 84 &  & teleportRoom <= 91) |  | (teleportRoom >= 101 &  & teleportRoom <= 106) |  | (teleportRoom >= 117 &  & teleportRoom <= 122)) {
                        TELEPORT(player, type, doMsgs, 8, 1, teleportRoom, FACING());
                    }
                    else {
                        CantMove(player, type, doMsgs);
                    }
                    break;
            }
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short teleportRoom;
            WallBlock(player, type, doMsgs);
            SET_FLAG(player, type, doMsgs, DUNGEON, WHICHPIECE, 3);
            if (FACING() == NORTH) {
                teleportRoom = HERE();
            }
             - 16;
            if (FACING() == EAST) {
                teleportRoom = HERE();
            }
             + 1;
            if (FACING() == SOUTH) {
                teleportRoom = HERE();
            }
             + 16;
            if (FACING() == WEST) {
                teleportRoom = HERE();
            }
             - 1;
            if ((teleportRoom >= 37 &  & teleportRoom <= 42) |  | (teleportRoom >= 53 &  & teleportRoom <= 58) |  | (teleportRoom >= 68 &  & teleportRoom <= 75) |  | (teleportRoom >= 84 &  & teleportRoom <= 91) |  | (teleportRoom >= 101 &  & teleportRoom <= 106) |  | (teleportRoom >= 117 &  & teleportRoom <= 122)) {
                TELEPORT(player, type, doMsgs, 8, 1, teleportRoom, FACING());
            }
            else {
                CantMove(player, type, doMsgs);
            }
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short teleportRoom;
            WallBlock(player, type, doMsgs);
            SET_FLAG(player, type, doMsgs, DUNGEON, WHICHPIECE, 2);
            if (FACING() == NORTH) {
                teleportRoom = HERE();
            }
             - 31;
            if (FACING() == EAST) {
                teleportRoom = HERE();
            }
             + 18;
            if (FACING() == SOUTH) {
                teleportRoom = HERE();
            }
             + 31;
            if (FACING() == WEST) {
                teleportRoom = HERE();
            }
             - 18;
            if ((teleportRoom >= 37 &  & teleportRoom <= 42) |  | (teleportRoom >= 53 &  & teleportRoom <= 58) |  | (teleportRoom >= 68 &  & teleportRoom <= 75) |  | (teleportRoom >= 84 &  & teleportRoom <= 91) |  | (teleportRoom >= 101 &  & teleportRoom <= 106) |  | (teleportRoom >= 117 &  & teleportRoom <= 122)) {
                TELEPORT(player, type, doMsgs, 8, 1, teleportRoom, FACING());
            }
            else {
                CantMove(player, type, doMsgs);
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                SHOW_TEXT(player, type, doMsgs, "The lair is filled with lava pools and noxious odors.");
                PoisonMe(player, type, doMsgs);
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            GET_MONSTER(player, type, doMsgs, 01, 33);
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A group of young Erebus move towards you, mumbling in their guttural tongue.");
            OfferBooty(player, type, doMsgs);
            switch (PARTY_COUNT()) {
                case 1:
                    GET_MONSTER(player, type, doMsgs, 01, 31);
                    break;
                default:
                    GET_MONSTER(player, type, doMsgs, 01, 31);
                    GET_MONSTER(player, type, doMsgs, 02, 31);
                    GET_MONSTER(player, type, doMsgs, 05, 31);
                    break;
            }
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_SPELL();
            if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                ShowFntn(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The sweet waters feel refreshing at first, but soon make you feel nauseated.");
                PoisonMe(player, type, doMsgs);
                DamageBy6(player, type, doMsgs);
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowFntn(player, type, doMsgs);
            SHOW_TEXT(player, type, doMsgs, "The fountain's sickening waters churn in your stomach, but slowly you begin feeling revived and healthy!");
            HEAL(player, type, doMsgs, MAX_HEALTH());
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowFntn(player, type, doMsgs);
            if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                SHOW_TEXT(player, type, doMsgs, "These sparkling waters are magical in nature and instantly restore your mana level.");
                MOD_MANA(player, type, doMsgs, 5000);
                SET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP, 1);
            }
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                SHOW_TEXT(player, type, doMsgs, "Fetid fumes reek of evil magic.");
                if (GUILD() == WIZARD) {
                    MOD_MANA(player, type, doMsgs,  - , 250);
                }
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, PRAXISPRIEST);
            SHOW_TEXT(player, type, doMsgs, "A young Praxis is donning his armor.");
            SHOW_TEXT(player, type, doMsgs, "'Hail, young warriors!'");
            SHOW_TEXT(player, type, doMsgs, "'Many secrets are hidden about that will aid you in solving the enigma of the Master's Arena. Be aware of whose square you are fighting for!'");
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, HUMANWIZARD);
            SHOW_TEXT(player, type, doMsgs, "A portly wizard fumbles with some magical tomes.");
            SHOW_TEXT(player, type, doMsgs, "'What, what, what...? Who are you? Hmm, don't know the name.'");
            SHOW_TEXT(player, type, doMsgs, "'Yes, yes, I know the Arena area. Have a look at those books over there on the wall. They should help you with your problem.'");
            SHOW_TEXT(player, type, doMsgs, "He mumbles something about being bothered and returns to his reading.");
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, ELFBARBARIAN);
            SHOW_TEXT(player, type, doMsgs, "'So, you're after the Dralkarians, eh? Well, good luck! The Night Elves worship those powerful deities.");
            SHOW_TEXT(player, type, doMsgs, "If I were you - and I'm NOT, thank the heavens! - I'd be on the lookout for some peculiar items.");
            SHOW_TEXT(player, type, doMsgs, "After all, the Dralks are not of this earth. Seek them in their unique homes. You will know what I mean in time.'");
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Archaic runes in some forgotten tongue cover this gateway.");
            if (HAS_ITEM(player, type, doMsgs, LAVAGLOVE)) {
                if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                    SHOW_TEXT(player, type, doMsgs, "The lava glove allows you to open the portal.");
                    SprungTrap(player, type, doMsgs);
                    special10(player, type, doMsgs);
                }
            }
            else {
                SHOW_RUNES(player, type, doMsgs, "'This portal may be opened by the owner of the Lava Glove.'");
                SET_FLAG(player, type, doMsgs, DUNGEON, LAVAQUEST, 2);
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Praxis thaumaturges hurl magical bolts at you.");
            OfferBooty(player, type, doMsgs);
            switch (PARTY_COUNT()) {
                case 1:
                    GET_MONSTER(player, type, doMsgs, 01, 27);
                    GET_MONSTER(player, type, doMsgs, 02, 28);
                    break;
                case 2:
                    GET_MONSTER(player, type, doMsgs, 01, 27);
                    GET_MONSTER(player, type, doMsgs, 02, 28);
                    GET_MONSTER(player, type, doMsgs, 03, 28);
                    break;
                default:
                    GET_MONSTER(player, type, doMsgs, 01, 27);
                    GET_MONSTER(player, type, doMsgs, 02, 28);
                    GET_MONSTER(player, type, doMsgs, 05, 29);
                    GET_MONSTER(player, type, doMsgs, 06, 29);
                    break;
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, EREBUSFIEND);
            SHOW_TEXT(player, type, doMsgs, "A wounded Erebus grabs your ankle.");
            SHOW_TEXT(player, type, doMsgs, "'Kill me...kill me! If the Praxis discover me here, the war will be imminent.'");
            SHOW_TEXT(player, type, doMsgs, "He then collapses...");
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, DWARFKNIGHT);
            SHOW_TEXT(player, type, doMsgs, "'These feuding creatures are enough to drive me insane! I must defeat one of the Masters in the Arena.");
            SHOW_TEXT(player, type, doMsgs, "Go see the scholar just south of here before you test your luck in the Arena. He has some books that will help you!'");
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "War-hardened guildsmen attack!");
            OfferBooty(player, type, doMsgs);
            switch (PARTY_COUNT()) {
                case 1:
                    GET_MONSTER(player, type, doMsgs, 01, 25);
                    GET_MONSTER(player, type, doMsgs, 02, 30);
                    break;
                case 2:
                    GET_MONSTER(player, type, doMsgs, 01, 25);
                    GET_MONSTER(player, type, doMsgs, 02, 30);
                    GET_MONSTER(player, type, doMsgs, 03, 30);
                    break;
                default:
                    GET_MONSTER(player, type, doMsgs, 01, 25);
                    GET_MONSTER(player, type, doMsgs, 02, 30);
                    GET_MONSTER(player, type, doMsgs, 03, 30);
                    GET_MONSTER(player, type, doMsgs, 04, 35);
                    GET_MONSTER(player, type, doMsgs, 05, 26);
                    break;
            }
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A dusty collection of books, similar to those you can find in the Queen's Palace, offers you hints on the Masters' Arena.");
            SHOW_TEXT(player, type, doMsgs, "'When you take over a square, you acquire the piece's abilities you just defeated!");
            SHOW_TEXT(player, type, doMsgs, "Bishops move to corners, as north is to northeast.");
            SHOW_TEXT(player, type, doMsgs, "Knights attack in leaps in bounds. From here to there, by an L of renown.");
            SHOW_TEXT(player, type, doMsgs, "Rooks connect onto that which is directly in front of them. Remember, you become that which you destroy.'");
            SHOW_TEXT(player, type, doMsgs, "      ==============");
            SHOW_TEXT(player, type, doMsgs, "      =0 0 0 0 0 0 =");
            SHOW_TEXT(player, type, doMsgs, "      =0 0 0 0 0 0 =");
            SHOW_TEXT(player, type, doMsgs, "      =  0 0 0 B 0 =");
            SHOW_TEXT(player, type, doMsgs, "      =  B>0 K R 0 =");
            SHOW_TEXT(player, type, doMsgs, "      =0 0 K 0 0 0 =");
            SHOW_TEXT(player, type, doMsgs, "      =0 0 E P 0 0 =");
            SHOW_TEXT(player, type, doMsgs, "      ==============");
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A long tunnel twists downward to Dragon's Flame.");
            TELEPORT(player, type, doMsgs, 8, 2, 38, WEST);
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A flickering torch in the distance breaks the blackness around you. It marks the entrance to Dragon's Flame.");
            TELEPORT(player, type, doMsgs, 8, 2, 156, EAST);
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short value;
            short chesspiece;
            short mn;
            chesspiece = GET_FLAG(player, type, doMsgs, DUNGEON, WHICHPIECE);
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
            GET_MONSTER(player, type, doMsgs, 01, mn);
            SET_FLAG(player, type, doMsgs, DUNGEON, WHICHPIECE, value);
        }
        private void MasterTxt(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A hidden portal opens, allowing those who have defeated the Master an ingress.");
            special10(player, type, doMsgs);
        }
        private void SoloTxt(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "There's something strange about the wall here. Only alone, and once you've defeated a Master of the Arena, will you be able to see it!");
            WallBlock(player, type, doMsgs);
        }
        private void OfferBooty(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short itemA = 0;;
            short itemB = 0;;
            short itemC = 0;;
            switch (HERE()) {
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
            if (STATE() != HERE() && !HAS_ITEM(player, type, doMsgs, itemA)) {
                SET_BOOTY(player, type, doMsgs, itemA, itemB, itemC, 0, 0, 2000);
                SET_STATE(player, type, doMsgs, HERE());
            }
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
        }
        private void DamageMax(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DAMAGE(player, type, doMsgs, MAX_HEALTH());
        }
        private void DamageBy2(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DAMAGE(player, type, doMsgs, HEALTH(),  / , 2);
        }
        private void DamageBy6(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DAMAGE(player, type, doMsgs, HEALTH(),  / , 6);
        }
        private void SprungTrap(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP, 1);
        }
        private void ShowFntn(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
        }
        private void CantMove(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A move here would place you off the chessboard!");
        }
        private void PoisonMe(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_PM(player, type, doMsgs, POISON, 10, 150);
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, JESTERSCAP) && !GET_FLAG(player, type, doMsgs, DUNGEON, CHOR_NPC_KILLED) & CHORONZAR_KILLED_BIT) {
                SHOW_TEXT(player, type, doMsgs, "A maniacal fiend appears; removes an item you stole from him; and kills you outright.");
                while HAS_ITEM(player, type, doMsgs, JESTERSCAP)TAKE_ITEM(player, type, doMsgs, JESTERSCAP);
                MOD_GOLD(player, type, doMsgs,  - , 10000);
                MOD_EXP(player, type, doMsgs,  - , 200000);
                DAMAGE(player, type, doMsgs, MAX_HEALTH());
            }
            SHOW_TEXT(player, type, doMsgs, "This area is certainly not the grand entrance to the Dralkarian kingdom you had envisioned.");
            SHOW_TEXT(player, type, doMsgs, "The walls and floors are in decay, all covered with lichens and scorch marks. Pools of lava and shadow litter the floor.");
            SHOW_TEXT(player, type, doMsgs, "The crumbling stones and cracked granite act as testimony to the war brewing between the Praxis and Erebus armies that dominate this domain.");
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short flag;
            short portroom;
            switch (HERE()) {
                case 119:
                    flag = KILLEDEREBUS;
                    portroom = 54;
                    break;
                case 120:
                    flag = KILLEDPRAXIS;
                    portroom = 57;
                    break;
            }
            if (!GET_FLAG(player, type, doMsgs, DUNGEON, flag)) {
                if (flag == KILLEDEREBUS) {
                    ErebusText1(player, type, doMsgs);
                }
                else {
                    PraxisText1(player, type, doMsgs);
                }
                SET_FLAG(player, type, doMsgs, DUNGEON, flag, 1);
                SET_FLAG(player, type, doMsgs, DUNGEON, WHICHPIECE, 2);
                TELEPORT(player, type, doMsgs, 8, 1, portroom, NORTH);
            }
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                SHOW_TEXT(player, type, doMsgs, "Ancient carvings of living chess pieces decorate this mysterious portal. Heavy fumes of evil seep upwards from this portal to Dragon's Flame.");
                SprungTrap(player, type, doMsgs);
            }
            TELEPORT(player, type, doMsgs, 8, 2, 38, WEST);
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, LAVAGLOVE)) {
                SHOW_TEXT(player, type, doMsgs, "Your Lava Glove begins to glow with white-hot intensity...tugging you in this direction.");
            }
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT() == 1) {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, KILLEDPRAXIS) == 2) {
                    MasterTxt(player, type, doMsgs);
                }
            }
            else {
                SoloTxt(player, type, doMsgs);
            }
        }
        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short flag = 222;;
            switch (HERE()) {
                case 135:
                    flag = KILLEDEREBUS;
                    break;
                case 136:
                    flag = KILLEDPRAXIS;
                    break;
            }
            if (GET_FLAG(player, type, doMsgs, DUNGEON, flag) != 2 && GET_FLAG(player, type, doMsgs, DUNGEON, flag) == 1) {
                SET_FLAG(player, type, doMsgs, DUNGEON, flag, 2);
                MOD_EXP(player, type, doMsgs, 350000);
                SHOW_TEXT(player, type, doMsgs, "Your prowess is acknowledged. Gain wisdom from your actions.");
            }
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT() == 1) {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, KILLEDEREBUS) == 2) {
                    MasterTxt(player, type, doMsgs);
                }
            }
            else {
                SoloTxt(player, type, doMsgs);
            }
        }
        protected override void FnEvent3B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_JOIN();
        }
        protected override void FnEvent3C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A dark portal offers you descent into untamed depths of this dark underworld.");
            TELEPORT(player, type, doMsgs, 9, 2, 119, EAST);
        }
        protected override void FnEvent3D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            SHOW_TEXT(player, type, doMsgs, "Servants of Qao rise from the lava to repel encroaching invaders!");
            if (!HAS_ITEM(player, type, doMsgs, HEALAMPHORA) && !GET_FLAG(player, type, doMsgs, PARTY, SERVANTS)) {
                SET_BOOTY(player, type, doMsgs, HEALAMPHORA, LIFEGIVER, SCORCHEDSCROLL, 0, 0, 2000);
                SET_FLAG(player, type, doMsgs, PARTY, SERVANTS, 1);
            }
            switch (PARTY_COUNT()) {
                case 1:
                    case 2:
                        for (i = 1; i <= 2; i++) {
                            GET_MONSTER(player, type, doMsgs, i, 24);
                        }
                        default:
                            for (i = 1; i <= 4; i++) {
                                GET_MONSTER(player, type, doMsgs, i, 24);
                            }
                        }
                    }
                }
            }
