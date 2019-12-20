namespace XPT.Twinion.Maps {
    class TwMap30 : TwMap {
        protected override int MapIndex => 30;
        protected override int MapID => 0x0C01;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 1;

        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This teleport will only take you to the main entrance.");
            TELEPORT(player, type, doMsgs, 1, 1, 19, SOUTH);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short charges;
            charges = GET_FLAG(player, type, doMsgs, DUNGEON, ITEMUSES);
            if (!GET_FLAG(player, type, doMsgs, ROOM, TOSOURCE)) {
                if (FLAG_ON(player, type, doMsgs, DUNGEON, ITEMUSES)) {
                    if (USED_ITEM(player, type, doMsgs, RODOFDISSEMINATION, RODOFDISSEMINATION)) {
                        if (charges < 12) {
                            SHOW_TEXT(player, type, doMsgs, "You dispel the wall!");
                            charges++;
                            SET_FLAG(player, type, doMsgs, DUNGEON, ITEMUSES, charges);
                            CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
                            HIDE_WALL(player, type, doMsgs, HERE(), FACING());
                        }
                        else {
                            SHOW_TEXT(player, type, doMsgs, "The item's powers have faded!");
                            SHOW_TEXT(player, type, doMsgs, "Now, take this portal back to the rod's source; and try to find a pathway...again.");
                            SET_FLAG(player, type, doMsgs, ROOM, TOSOURCE, 1);
                            PLACE_WALL_ITEM(player, type, doMsgs, GATEWAY, HERE(), FACING());
                            BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
                            SHOW_WALL(player, type, doMsgs, HERE(), FACING());
                        }
                    }
                    else {
                        SHOW_TEXT(player, type, doMsgs, "This wall seems to shimmer, yet it is solid.");
                    }
                }
            }
            else if (GET_FLAG(player, type, doMsgs, ROOM, TOSOURCE) == 1) {
                PLACE_WALL_ITEM(player, type, doMsgs, GATEWAY, HERE(), FACING());
                TELEPORT(player, type, doMsgs, 12, 1, 72, NORTH);
            }
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The tedious journey to this place has made you tired.");
            SHOW_TEXT(player, type, doMsgs, "Even so, some walls here seem to fade and shimmer as being pulled upon by unseen forces.");
            SHOW_TEXT(player, type, doMsgs, "Grinding sounds of stone echo through these odd shadowy halls. The scent of powerful magics fills your nostrils and fires your mind.");
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, TALKED_TO_NPC1) == 1 && GET_FLAG(player, type, doMsgs, DUNGEON, TALKED_TO_NPC2) == 1) {
                SHOW_TEXT(player, type, doMsgs, "The messages of the two old men prove to be the key to opening this secret wall!");
                CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
                PLACE_WALL_ITEM(player, type, doMsgs, PORTAL, HERE(), FACING());
            }
            else if (GET_FLAG(player, type, doMsgs, DUNGEON, TALKED_TO_NPC1) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, TALKED_TO_NPC2) == 1) {
                SHOW_TEXT(player, type, doMsgs, "Hmmm...seems like you're missing part of the ritual.  Another may know the second half; then you may find a way through here!");
                BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
            }
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This enormous hallway seems to be devoid of any useful purpose. It's as though the walls here are only boundaries of internally hidden rooms.");
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_MAPS();
            SET_FLAG(player, type, doMsgs, DUNGEON, ITEMUSES, 1);
            SHOW_TEXT(player, type, doMsgs, "Magical energy radiates from all around you.");
            SHOW_TEXT(player, type, doMsgs, "These mystical teleports project dazzling colors of light that refract and reflect off of each other with blinding beauty.");
            SHOW_TEXT(player, type, doMsgs, "Three shafts of pure light pour down from above onto the Rod of Dissemination, restoring its magical properties.");
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Two small dwellings stand opposite each other in this small room. Strange mumblings are coming from the southern one.");
            SHOW_TEXT(player, type, doMsgs, "Northward, however, you can just make out low hissing sounds and snarls.");
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Deep sorrowful moans surround you in this dingy place.");
            SHOW_TEXT(player, type, doMsgs, "Odd shadows flicker and fold in on one another against the walls.  The shadows themselves seem alive.");
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            if (HAS_ITEM(player, type, doMsgs, RODOFDISSEMINATION)) {
                SHOW_TEXT(player, type, doMsgs, "Stains of combat cover the floor, but there is nothing of interest here... except a few Erebus fiends!");
            }
            else if (!GET_FLAG(player, type, doMsgs, DUNGEON, NICEBOOTY)) {
                SET_BOOTY(player, type, doMsgs, RODOFDISSEMINATION, MANAAMPHORA, ZEUSSCROLL, 0, 0, 10000);
                SET_FLAG(player, type, doMsgs, DUNGEON, NICEBOOTY, 1);
                ErebusTxt(player, type, doMsgs);
            }
            else {
                SET_BOOTY(player, type, doMsgs, RODOFDISSEMINATION, 0, 0, 0, 0, 5000);
                ErebusTxt(player, type, doMsgs);
            }
            switch (PARTY_COUNT()) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 25);
                    }
                    GET_MONSTER(player, type, doMsgs, 5, 26);
                    break;
                case 2:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 25);
                    }
                    GET_MONSTER(player, type, doMsgs, 6, 26);
                    break;
                default:
                    for (i = 1; i <= 4; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 25);
                    }
                    GET_MONSTER(player, type, doMsgs, 6, 26);
                    break;
            }
        }
        private void ErebusTxt(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A large Erebus Fiend orders his minions to attack you, as he waves a mystical staff about and sends magical flames at you from his fingertips!");
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short charges;
            short tilenumber;
            charges = GET_FLAG(player, type, doMsgs, DUNGEON, ITEMUSES);
            SHOW_TEXT(player, type, doMsgs, "The statue seems to shimmer, yet it is apparently solid.");
            if (FLAG_ON(player, type, doMsgs, DUNGEON, ITEMUSES)) {
                if (USED_ITEM(player, type, doMsgs, RODOFDISSEMINATION, RODOFDISSEMINATION)) {
                    if (charges < 12) {
                        SHOW_TEXT(player, type, doMsgs, "You dispel the statue!");
                        charges++;
                        SET_FLAG(player, type, doMsgs, DUNGEON, ITEMUSES, charges);
                        if (FACING() == NORTH) {
                            tilenumber = HERE();
                        }
                         - 16;
                        if (FACING() == EAST) {
                            tilenumber = HERE();
                        }
                         + 1;
                        if (FACING() == SOUTH) {
                            tilenumber = HERE();
                        }
                         + 16;
                        if (FACING() == WEST) {
                            tilenumber = HERE();
                        }
                         - 1;
                        CLEAR_FLOOR(player, type, doMsgs, tilenumber);
                        PLACE_FLOOR_ITEM(player, type, doMsgs, 0, tilenumber);
                    }
                    else {
                        SHOW_TEXT(player, type, doMsgs, "The item's powers have faded and pull you back to their source.");
                        TELEPORT(player, type, doMsgs, 12, 1, 72, NORTH);
                        BLOCK_FLOOR(player, type, doMsgs, tilenumber);
                    }
                }
            }
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "By dispelling this statue you've released the imprisoned creature! It intends to reward you with death!");
            GET_MONSTER(player, type, doMsgs, 01, 27);
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, DUNGEON, TALKED_TO_NPC1)) {
                if (!GET_FLAG(player, type, doMsgs, PARTY, NPCONE)) {
                    SHOW_PICTURE(player, type, doMsgs, KAALROTH);
                    SHOW_TEXT(player, type, doMsgs, "A sinewy beast stares angrily at you for your intrusion into his home.");
                    SHOW_TEXT(player, type, doMsgs, "'You have no business here. Leave before I become enraged and destroy you!'");
                    SET_FLAG(player, type, doMsgs, PARTY, NPCONE, 2);
                }
                else if (GET_FLAG(player, type, doMsgs, PARTY, NPCTWO) == 1 || FLAG_ON(player, type, doMsgs, DUNGEON, TALKED_TO_NPC2)) {
                    SHOW_PICTURE(player, type, doMsgs, KAALROTH);
                    SHOW_TEXT(player, type, doMsgs, "'Ahh, you've met my twin, I see.");
                    SHOW_TEXT(player, type, doMsgs, "Say his chant in time with mine, and at the wall, the ingress shall be thine.'");
                    SHOW_TEXT(player, type, doMsgs, "Ieoa then turns away pleased with his 'creativity'%.");
                    SET_FLAG(player, type, doMsgs, DUNGEON, TALKED_TO_NPC1, 1);
                    SET_FLAG(player, type, doMsgs, PARTY, NPCONE, 2);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Ieoa has left the dungeon.");
            }
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, KAALROTH);
            if (!GET_FLAG(player, type, doMsgs, DUNGEON, TALKED_TO_NPC2)) {
                if (!GET_FLAG(player, type, doMsgs, PARTY, NPCTWO)) {
                    SHOW_TEXT(player, type, doMsgs, "A sinewy beast stares angrily at you for your intrusion into his home.");
                    SHOW_TEXT(player, type, doMsgs, "'Away with you, go bother my brother to the west.'");
                    SET_FLAG(player, type, doMsgs, PARTY, NPCTWO, 1);
                    if (!GET_FLAG(player, type, doMsgs, PARTY, NPCONE)) {
                        SET_FLAG(player, type, doMsgs, PARTY, NPCONE, 1);
                    }
                }
                else if (GET_FLAG(player, type, doMsgs, PARTY, NPCONE) == 2) {
                    SHOW_TEXT(player, type, doMsgs, "'Did you enjoy your talk with Ieoa?");
                    SHOW_TEXT(player, type, doMsgs, "My verse shan't be before if you wish to find the door. Seek Ieoa, the twin; with his rhyme you begin.'");
                    SHOW_TEXT(player, type, doMsgs, "Aoei then turns away pleased with his 'creativity'%.");
                    SET_FLAG(player, type, doMsgs, PARTY, NPCTWO, 1);
                    SET_FLAG(player, type, doMsgs, DUNGEON, TALKED_TO_NPC2, 1);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Aoei has left the dungeon.");
            }
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            SHOW_TEXT(player, type, doMsgs, "You happen across some feuding Kaalroths that dismiss their argument for some tasty combat.");
            switch (PARTY_COUNT()) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 28);
                    }
                    break;
                case 2:
                    for (i = 1; i <= 3; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 28);
                    }
                    break;
                default:
                    for (i = 1; i <= 5; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 28);
                    }
                    break;
            }
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            SHOW_TEXT(player, type, doMsgs, "A warring party of Night Elf Pilgrims drags you into the fray.");
            switch (PARTY_COUNT()) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 29);
                    }
                    break;
                case 2:
                    for (i = 1; i <= 3; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 29);
                    }
                    break;
                default:
                    for (i = 1; i <= 5; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 29);
                    }
                    break;
            }
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            SHOW_TEXT(player, type, doMsgs, "You suddenly feel out matched as a small nest of dragons charges at you!");
            switch (PARTY_COUNT()) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 30);
                    }
                    break;
                case 2:
                    for (i = 1; i <= 3; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 30);
                    }
                    break;
                default:
                    for (i = 1; i <= 5; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 30);
                    }
                    break;
            }
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            SHOW_TEXT(player, type, doMsgs, "Shimmering moans and shadowy figures surround you!");
            switch (PARTY_COUNT()) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 31);
                    }
                    break;
                case 2:
                    for (i = 1; i <= 3; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 31);
                    }
                    break;
                default:
                    for (i = 1; i <= 5; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 31);
                    }
                    break;
            }
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A huge Red Dragon sends a barrage of flames towards you!");
            if (PARTY_LEVEL(player, type, doMsgs, 48)) {
                GET_MONSTER(player, type, doMsgs, 1, 32);
            }
            else if (PARTY_LEVEL(player, type, doMsgs, 36)) {
                GET_MONSTER(player, type, doMsgs, 1, 24);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 1, 23);
            }
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This jeweled teleport will send you to the final confrontation. The Queen awaits.");
            SET_FLAG(player, type, doMsgs, DUNGEON, TOTHEQUEEN, 1);
            TELEPORT(player, type, doMsgs, 12, 2, 255, WEST);
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Perhaps the way out is near!!!");
            TELEPORT(player, type, doMsgs, 12, 1, 193, NORTH);
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            SHOW_TEXT(player, type, doMsgs, "An arsenal of creatures bars your way here.");
            switch (PARTY_COUNT()) {
                case 1:
                    GET_MONSTER(player, type, doMsgs, 1, 25);
                    GET_MONSTER(player, type, doMsgs, 5, 33);
                    break;
                case 2:
                    for (i = 1; i <= 3; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 25);
                    }
                    GET_MONSTER(player, type, doMsgs, 6, 33);
                    break;
                default:
                    for (i = 1; i <= 4; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 28);
                    }
                    GET_MONSTER(player, type, doMsgs, 6, 33);
                    break;
            }
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            SHOW_TEXT(player, type, doMsgs, "Servants of Dissemination attack!");
            switch (PARTY_COUNT()) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 34);
                    }
                    break;
                case 2:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 34);
                    }
                    for (i = 5; i <= 6; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 34);
                    }
                    break;
                default:
                    for (i = 1; i <= 4; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 34);
                    }
                    break;
            }
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The marble statue crumbles away, releasing an ominous beast of power.");
            GET_MONSTER(player, type, doMsgs, 01, 35);
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, WRAITH);
            SHOW_TEXT(player, type, doMsgs, "'I am frozen in time here! I tried to use the Portal without the proper knowledge!");
            SHOW_TEXT(player, type, doMsgs, "Learn from me! Do not use the Portal below!'");
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                SHOW_TEXT(player, type, doMsgs, "You've sprung an ancient trap that seems not to have harmed you...much.");
                DAMAGE(player, type, doMsgs, HEALTH(),  / , 4);
                SET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP, 1);
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                if (!GET_FLAG(player, type, doMsgs, PARTY, TORCHSWITCH)) {
                    SHOW_TEXT(player, type, doMsgs, "A dragon's face is carved on the wall where the torch here hangs. As you walk by the wall it comes to life and spews waves of fire over you!");
                    DAMAGE(player, type, doMsgs, HEALTH(),  / , 5);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "The carved dragon on the wall remains silent.");
                }
                SET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP, 1);
            }
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            SHOW_TEXT(player, type, doMsgs, "'You must defeat us to proceed! We are everlasting forces here!'");
            switch (PARTY_COUNT()) {
                case 1:
                    for (i = 1; i <= 3; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 36);
                    }
                    break;
                case 2:
                    for (i = 1; i <= 4; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 36);
                    }
                    break;
                default:
                    for (i = 1; i <= 6; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 36);
                    }
                    break;
            }
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This MUST lead out of this level.");
            TELEPORT(player, type, doMsgs, 12, 1, 152, EAST);
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The end must be near; you can see huge forces of creatures moving about nearby.");
            SHOW_TEXT(player, type, doMsgs, "Waste not your charges on futile walls!");
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The Guardians here launch a spread of evil magic towards you. The mysterious vapors envelop your body as a ring of opaque fog.");
            SET_PM(player, type, doMsgs, POISON, 10, 700);
            MOD_STAT(player, type, doMsgs, DEFENSE,  - , 1);
            MOD_STAT(player, type, doMsgs, AGILITY,  - , 1);
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            SHOW_TEXT(player, type, doMsgs, "Creatures surprise you!");
            if (!GET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP)) {
                DAMAGE(player, type, doMsgs, HEALTH(),  / , 6);
                MOD_GOLD(player, type, doMsgs,  - , 2500);
                SET_FLAG(player, type, doMsgs, ROOM, SPRUNGTRAP, 1);
            }
            switch (PARTY_COUNT()) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 22);
                    }
                    break;
                case 2:
                    for (i = 1; i <= 4; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 22);
                    }
                    break;
                default:
                    for (i = 1; i <= 6; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 22);
                    }
                    break;
            }
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            SHOW_TEXT(player, type, doMsgs, "You surprise some beasts examining an interesting sword.");
            if (!GET_FLAG(player, type, doMsgs, DUNGEON, GREATBOOTY)) {
                SET_BOOTY(player, type, doMsgs, PHOSPHORESCENTBLADE, HEALAMPHORA, HEALAMPHORA, BARBARIANAXE, ETHERICVESTMENT, 25000);
                SET_FLAG(player, type, doMsgs, DUNGEON, GREATBOOTY, 1);
            }
            switch (PARTY_COUNT()) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 25);
                    }
                    break;
                case 2:
                    for (i = 1; i <= 3; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 22);
                    }
                    break;
                default:
                    for (i = 1; i <= 3; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 24);
                    }
                    break;
            }
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, GNOMEWIZARD);
            SHOW_TEXT(player, type, doMsgs, "An old hermit squints at you, 'The Portal you seek cannot be entered yet.  Your task will end in futility!");
            SHOW_TEXT(player, type, doMsgs, "You must gain in ways before you gain the wisdom.'");
            SHOW_TEXT(player, type, doMsgs, "The rantings of a fool, eh?");
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This portal, however, you can enter.");
            TELEPORT(player, type, doMsgs, 12, 1, 136, NORTH);
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            SHOW_TEXT(player, type, doMsgs, "Some young dragons are scrounging for food, they notice you and attempt to make you their meal.");
            switch (PARTY_COUNT()) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 30);
                    }
                    break;
                case 2:
                    for (i = 1; i <= 3; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 30);
                    }
                    break;
                default:
                    for (i = 1; i <= 5; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 30);
                    }
                    break;
            }
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            SHOW_TEXT(player, type, doMsgs, "You've happened upon some very unpleasant sorts!");
            switch (PARTY_COUNT()) {
                case 1:
                    for (i = 1; i <= 3; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 3);
                    }
                    break;
                case 2:
                    for (i = 1; i <= 4; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 4);
                    }
                    break;
                default:
                    for (i = 1; i <= 6; i++) {
                        GET_MONSTER(player, type, doMsgs, i, 6);
                    }
                    break;
            }
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (FLAG_OFF(player, type, doMsgs, PARTY, TORCHSWITCH)) {
                SHOW_TEXT(player, type, doMsgs, "A lever here is marked DO NOT TOUCH!");
                SHOW_TEXT(player, type, doMsgs, "Using your better judgement, you move the lever.");
                SHOW_TEXT(player, type, doMsgs, "You hear clicks and sliding noises of stone on stone echo through nearby corridors.");
                SET_FLAG(player, type, doMsgs, PARTY, TORCHSWITCH, 1);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "You decidedly move the switch again, thinking it best not to fiddle with things so well marked.");
                SET_FLAG(player, type, doMsgs, PARTY, TORCHSWITCH, 0);
            }
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A glowing teleport stands ready.");
            TELEPORT(player, type, doMsgs, 12, 1, 237, SOUTH);
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A glowing teleport stands ready.");
            TELEPORT(player, type, doMsgs, 12, 1, 0, WEST);
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A glowing teleport stands ready.");
            TELEPORT(player, type, doMsgs, 12, 1, 144, NORTH);
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short i;
            SHOW_TEXT(player, type, doMsgs, "A war party of adventurers prepare an offensive.");
            switch (PARTY_COUNT()) {
                case 1:
                    GET_MONSTER(player, type, doMsgs, 01, 15);
                    GET_MONSTER(player, type, doMsgs, 02, 17);
                    GET_MONSTER(player, type, doMsgs, 06, 16);
                    break;
                case 2:
                    GET_MONSTER(player, type, doMsgs, 01, 20);
                    GET_MONSTER(player, type, doMsgs, 02, 18);
                    GET_MONSTER(player, type, doMsgs, 03, 19);
                    GET_MONSTER(player, type, doMsgs, 04, 16);
                    break;
                default:
                    GET_MONSTER(player, type, doMsgs, 01, 15);
                    GET_MONSTER(player, type, doMsgs, 02, 20);
                    GET_MONSTER(player, type, doMsgs, 03, 17);
                    GET_MONSTER(player, type, doMsgs, 04, 18);
                    GET_MONSTER(player, type, doMsgs, 05, 19);
                    GET_MONSTER(player, type, doMsgs, 06, 16);
                    break;
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "It's unusually dim in this room.  It appears as though a violent battle has recently taken place;");
            SHOW_TEXT(player, type, doMsgs, "seeing that charred remains litter the floor and scorch marked stone decorates the walls!");
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_MAPS();
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, RODOFDISSEMINATION) && !GET_FLAG(player, type, doMsgs, DUNGEON, ITEMUSES)) {
                SET_FLAG(player, type, doMsgs, DUNGEON, ITEMUSES, 1);
                SHOW_TEXT(player, type, doMsgs, "The Rod of Dissemination ignites with magical fury! Use it to blaze your own pathway through these magical walls.");
            }
        }
    }
}
