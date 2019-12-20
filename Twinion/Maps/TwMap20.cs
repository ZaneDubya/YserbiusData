namespace XPT.Twinion.Maps {
    class TwMap20 : TwMap {
        protected override int MapIndex => 20;
        protected override int MapID => 0x0802;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 1;

        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_FLAG(player, type, doMsgs, PARTY, WIZCHOICE, 1);
            TELEPORT(player, type, doMsgs, 8, 2, 124, SOUTH);
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE() == GNOME || RACE() == TROLL) {
                TELEPORT(player, type, doMsgs, 8, 2, 251, NORTH);
            }
            else if (RACE() == ELF || RACE() == GREMLIN) {
                TELEPORT(player, type, doMsgs, 8, 2, 96, EAST);
            }
            else if (RACE() == DWARF || RACE() == ORC) {
                TELEPORT(player, type, doMsgs, 8, 2, 77, EAST);
            }
            else {
                TELEPORT(player, type, doMsgs, 8, 2, 145, WEST);
            }
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_FLAG(player, type, doMsgs, PARTY, WIZCHOICE, 2);
            TELEPORT(player, type, doMsgs, 8, 2, 124, EAST);
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE() == GNOME || RACE() == ELF) {
                TELEPORT(player, type, doMsgs, 8, 2, 81, EAST);
            }
            else if (RACE() == TROLL || RACE() == GREMLIN) {
                TELEPORT(player, type, doMsgs, 8, 2, 163, NORTH);
            }
            else if (RACE() == DWARF || RACE() == HALFLING) {
                TELEPORT(player, type, doMsgs, 8, 2, 204, WEST);
            }
            else {
                TELEPORT(player, type, doMsgs, 8, 2, 44, WEST);
            }
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE() == GNOME || RACE() == ELF) {
                TELEPORT(player, type, doMsgs, 8, 2, 204, WEST);
            }
            else if (RACE() == TROLL || RACE() == GREMLIN) {
                TELEPORT(player, type, doMsgs, 8, 2, 44, WEST);
            }
            else if (RACE() == DWARF || RACE() == HALFLING) {
                TELEPORT(player, type, doMsgs, 8, 2, 81, EAST);
            }
            else {
                TELEPORT(player, type, doMsgs, 8, 2, 163, NORTH);
            }
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE() == GNOME || RACE() == ELF) {
                TELEPORT(player, type, doMsgs, 8, 2, 44, WEST);
            }
            else if (RACE() == TROLL || RACE() == GREMLIN) {
                TELEPORT(player, type, doMsgs, 8, 2, 204, WEST);
            }
            else if (RACE() == DWARF || RACE() == HALFLING) {
                TELEPORT(player, type, doMsgs, 8, 2, 163, NORTH);
            }
            else {
                TELEPORT(player, type, doMsgs, 8, 2, 81, EAST);
            }
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE() == GNOME || RACE() == ELF) {
                TELEPORT(player, type, doMsgs, 8, 2, 163, NORTH);
            }
            else if (RACE() == TROLL || RACE() == GREMLIN) {
                TELEPORT(player, type, doMsgs, 8, 2, 81, EAST);
            }
            else if (RACE() == DWARF || RACE() == HALFLING) {
                TELEPORT(player, type, doMsgs, 8, 2, 44, WEST);
            }
            else {
                TELEPORT(player, type, doMsgs, 8, 2, 204, WEST);
            }
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (RACE() == GNOME || RACE() == TROLL) {
                TELEPORT(player, type, doMsgs, 8, 2, 255, WEST);
            }
            else if (RACE() == ELF || RACE() == GREMLIN) {
                TELEPORT(player, type, doMsgs, 8, 2, 240, EAST);
            }
            else if (RACE() == DWARF || RACE() == ORC) {
                TELEPORT(player, type, doMsgs, 8, 2, 10, SOUTH);
            }
            else {
                TELEPORT(player, type, doMsgs, 8, 2, 4, SOUTH);
            }
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_FLAG(player, type, doMsgs, PARTY, WIZCHOICE, 4);
            TELEPORT(player, type, doMsgs, 8, 2, 124, WEST);
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_FLAG(player, type, doMsgs, PARTY, WIZCHOICE, 3);
            TELEPORT(player, type, doMsgs, 8, 2, 124, NORTH);
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Beyond this portal lies the wizard village Hocus Pocus.");
            TELEPORT(player, type, doMsgs, 9, 1, 247, NORTH);
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, GREMLINWIZARD);
            MOD_GOLD(player, type, doMsgs,  - , 1000);
            SHOW_TEXT(player, type, doMsgs, "'I am the wizard Majikyl. For a mere pittance I shall envelop you in a Vapor Cloud. This cloud will allow you to approach the dragon unseen.");
            SHOW_TEXT(player, type, doMsgs, "If you wish to continue, step through the door to the east.'");
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You find a page from MyMy's and Sinestra's journal with a faded map of many doors.");
            SHOW_TEXT(player, type, doMsgs, "Across the top you can barely make out the words 'Hocus Pocus' and across the bottom you see four words but can only decipher S   h W   S    We  .");
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, HUMANWIZARD);
            MOD_GOLD(player, type, doMsgs,  - , 1000);
            SHOW_TEXT(player, type, doMsgs, "'I am the wizard Artsenis. For this fee I will aid your quest. I shall place upon you a Chameleon Shroud spell. So disguised, you should be successful in approaching the dragon.");
            SHOW_TEXT(player, type, doMsgs, "If you choose to continue, step through the door to the south.'");
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, ELFBARBARIAN);
            SHOW_TEXT(player, type, doMsgs, "'I was told that you have to search every nook and cranny in the tunnels to find access to the dragons.'");
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A bloody hand print marks the wall.");
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, TROLLCLERIC);
            SHOW_TEXT(player, type, doMsgs, "You cross paths with a Troll Cleric, who whispers to you,");
            SHOW_TEXT(player, type, doMsgs, "'After searching all over, I retraced my steps and found an opening where none appeared before. This dungeon is a strange place.'");
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, DWARFWIZARD);
            MOD_GOLD(player, type, doMsgs,  - , 1000);
            SHOW_TEXT(player, type, doMsgs, "'I am the wizard Aillacsar. I shall take my fee for the Invisibility I cast upon you. It will get you close to your prey.");
            SHOW_TEXT(player, type, doMsgs, "If you choose to continue, walk east through the teleport.'");
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            GET_MONSTER(player, type, doMsgs, 01, 16);
            GET_MONSTER(player, type, doMsgs, 02, 28);
            GET_MONSTER(player, type, doMsgs, 03, 37);
            GET_MONSTER(player, type, doMsgs, 04, 36);
            GET_MONSTER(player, type, doMsgs, 05, 38);
            GET_MONSTER(player, type, doMsgs, 06, 29);
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, GNOMEWIZARD);
            MOD_GOLD(player, type, doMsgs,  - , 1000);
            SHOW_TEXT(player, type, doMsgs, "'I am the wizard Mirloch. Accept my magic for a small fee. I have cast upon you a Charismatic Aura. The enemy will look upon you as a friend.");
            SHOW_TEXT(player, type, doMsgs, "If you wish to continue, walk to the west through the teleport.");
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You step into a deep crevice and fall to your death.");
            DAMAGE(player, type, doMsgs, MAX_HEALTH());
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The searing heat of the lava engulfs you in flames.");
            DAMAGE(player, type, doMsgs, MAX_HEALTH());
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_SKILL(player, type, doMsgs, DETECT_SKILL) >= 10 || USED_SPELL(player, type, doMsgs, TRUE_SEEING_SPELL) || USED_ITEM(player, type, doMsgs, HELMOFWISDOM, HELMOFWISDOM) || USED_ITEM(player, type, doMsgs, VALKYRIESHELM, VALKYRIESHELM) || USED_ITEM(player, type, doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || USED_ITEM(player, type, doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                SHOW_TEXT(player, type, doMsgs, "You discover an opening.");
                PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(), FACING());
                CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
            }
            else {
                BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
            }
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_SKILL(player, type, doMsgs, DETECT_SKILL) >= 10 || USED_SPELL(player, type, doMsgs, TRUE_SEEING_SPELL) || USED_ITEM(player, type, doMsgs, HELMOFWISDOM, HELMOFWISDOM) || USED_ITEM(player, type, doMsgs, VALKYRIESHELM, VALKYRIESHELM) || USED_ITEM(player, type, doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || USED_ITEM(player, type, doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                SHOW_TEXT(player, type, doMsgs, "You push aside a pile of rubble and find a clear path ahead.");
                PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(), FACING());
                CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
            }
            else {
                BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_SKILL(player, type, doMsgs, DETECT_SKILL) >= 10 || USED_SPELL(player, type, doMsgs, TRUE_SEEING_SPELL) || USED_ITEM(player, type, doMsgs, HELMOFWISDOM, HELMOFWISDOM) || USED_ITEM(player, type, doMsgs, VALKYRIESHELM, VALKYRIESHELM) || USED_ITEM(player, type, doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || USED_ITEM(player, type, doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                SHOW_TEXT(player, type, doMsgs, "Your keen senses detect a hidden door.");
                PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(), FACING());
                CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
            }
            else {
                BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You are teleported to a series of long, dark tunnels. Here is where the dragons continue their feud.");
            if (GET_FLAG(player, type, doMsgs, PARTY, WIZCHOICE) == 1) {
                SET_FLAG(player, type, doMsgs, PARTY, WIZCHOICE, 5);
            }
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You are teleported to a series of long, dark tunnels. Here is where the dragons continue their feud.");
            if (GET_FLAG(player, type, doMsgs, PARTY, WIZCHOICE) == 2) {
                SET_FLAG(player, type, doMsgs, PARTY, WIZCHOICE, 5);
            }
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You are teleported to a series of long, dark tunnels. Here is where the dragons continue their feud.");
            if (GET_FLAG(player, type, doMsgs, PARTY, WIZCHOICE) == 3) {
                SET_FLAG(player, type, doMsgs, PARTY, WIZCHOICE, 5);
            }
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You are teleported to a series of long, dark tunnels. Here is where the dragons continue their feud.");
            if (GET_FLAG(player, type, doMsgs, PARTY, WIZCHOICE) == 4) {
                SET_FLAG(player, type, doMsgs, PARTY, WIZCHOICE, 5);
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, PARTY, DRAGON_B) == 1 && HAS_ITEM(player, type, doMsgs, DRAGONSSKIN)) {
                CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
                PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(), FACING());
            }
            else {
                BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
            }
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, PARTY, DRAGON_A) == 1 && GET_FLAG(player, type, doMsgs, PARTY, ONE_NORTH) == 1 && GET_FLAG(player, type, doMsgs, PARTY, ONE_CENTER) == 1 && GET_FLAG(player, type, doMsgs, PARTY, ONE_SOUTH) == 1) {
                CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
                PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(), FACING());
            }
            else {
                BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
            }
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, PARTY, DRAGON_A) == 1 && HAS_ITEM(player, type, doMsgs, DRAGONSSKIN)) {
                CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
                PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(), FACING());
            }
            else {
                BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
            }
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, PARTY, DRAGON_B) == 1 && GET_FLAG(player, type, doMsgs, PARTY, ONE_NORTH) == 1 && GET_FLAG(player, type, doMsgs, PARTY, ONE_CENTER) == 1 && GET_FLAG(player, type, doMsgs, PARTY, ONE_SOUTH) == 1) {
                CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
                PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(), FACING());
            }
            else {
                BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
            }
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, GREMLINTHIEF);
            SHOW_TEXT(player, type, doMsgs, "'Greetings! Have you seen my two companions? We were separated when we walked alone through a teleport.'");
            SET_FLAG(player, type, doMsgs, PARTY, ONE_NORTH, 1);
            if (GET_FLAG(player, type, doMsgs, PARTY, WIZCHOICE) != 5) {
                SHOW_TEXT(player, type, doMsgs, "'You say you have visited a wizard for magic? Hmmm, I see no signs of that.  Well, good journeys!'");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "'If you see them, please tell them I'm still searching. Good journeys to you!'");
            }
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, ELFCLERIC);
            SHOW_TEXT(player, type, doMsgs, "You encounter a tired elf leaning on a wall.");
            SET_FLAG(player, type, doMsgs, PARTY, ONE_SOUTH, 1);
            if (GET_FLAG(player, type, doMsgs, PARTY, WIZCHOICE) != 5) {
                SHOW_TEXT(player, type, doMsgs, "'Have you had the same problem as us? Either the magic was weak or something stripped it from us in our wanderings.'");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "'Well met! I am searching for my lost companions. I must hurry on, safe paths!'");
            }
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You notice a sign in pieces on the ground and barely make out the wording 'WARNING!!! These teleports are condemned by order of Queen Aeowyn!!!'");
            SHOW_TEXT(player, type, doMsgs, "Attached to the sign is a hand written note, 'Olyces, some thief told me my magic protection was gone! Something odd about these teleports or where they take me.");
            SHOW_TEXT(player, type, doMsgs, "I'm off to the wizards again and will meet you inside. I hope to use the correct teleport this time.' The note is signed, Bawcrs.");
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, TROLLKNIGHT);
            SHOW_TEXT(player, type, doMsgs, "You stumble upon an injured troll and administer aid.");
            SET_FLAG(player, type, doMsgs, PARTY, ONE_CENTER, 1);
            if (GET_FLAG(player, type, doMsgs, PARTY, WIZCHOICE) != 5) {
                SHOW_TEXT(player, type, doMsgs, "'A dangerous place indeed. I see no signs of magic about you. If you have visited the wizards, I suggest you try again. Sometimes shifting clouds of old magic strip the defenses. My thanks to you.'");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "'My thanks to you for much needed aid. You appear to be well protected. I shall remember your kindness; fare well my friends.'");
            }
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, SCALE) == 1) {
                SHOW_TEXT(player, type, doMsgs, "Gambril lumbers away.");
                SET_FLAG(player, type, doMsgs, PARTY, DRAGON_B, 1);
            }
            else {
                if (HAS_ITEM(player, type, doMsgs, DRAGONSSKIN)) {
                    SHOW_PICTURE(player, type, doMsgs, WHITEDRAGON);
                    SET_FLAG(player, type, doMsgs, DUNGEON, SCALE, 1);
                    MOD_EXP(player, type, doMsgs, 500000);
                    MOD_GOLD(player, type, doMsgs, 25000);
                    GIVE_ITEM(player, type, doMsgs, STONEGIANTSHAMMER);
                    GIVE_ITEM(player, type, doMsgs, MIDNIGHTAEGIS);
                    GIVE_ITEM(player, type, doMsgs, FLAMETONGUE);
                    GIVE_ITEM(player, type, doMsgs, HEALAMPHORA);
                    GIVE_ITEM(player, type, doMsgs, ZEUSSCROLL);
                    SHOW_TEXT(player, type, doMsgs, "Gambril is obviously relieved that his nemesis is finally dead.");
                    SHOW_TEXT(player, type, doMsgs, "He gives you a reward and says, 'It would be wise to take your trophy to Hocus Pocus. The wizards there oftentimes need unique items.'");
                }
                else {
                    SHOW_PICTURE(player, type, doMsgs, WHITEDRAGON);
                    SET_FLAG(player, type, doMsgs, PARTY, DRAGON_B, 1);
                    SHOW_TEXT(player, type, doMsgs, "You meet Gambril, the Frost Dragon.");
                    SHOW_TEXT(player, type, doMsgs, "'For longer than I care to remember, I have feuded with my nemesis Osterog, the Ice Dragon.");
                    SHOW_TEXT(player, type, doMsgs, "Our continued battles have formed tunnels within the land, and we can no longer maneuver ourselves through them.");
                    SHOW_TEXT(player, type, doMsgs, "I beseech you to help me. I will reward you generously if you bring me proof of your kill.");
                    SHOW_TEXT(player, type, doMsgs, "To be successful, you may need greater magic than you now possess.'");
                }
            }
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, PARTY, WIZCHOICE) == 5) {
                SHOW_TEXT(player, type, doMsgs, "With the help of the proper magic, you find the dragon Gambril.");
                if (HAS_ITEM(player, type, doMsgs, DRAGONSSKIN)) {
                    SET_BOOTY(player, type, doMsgs, ELIXIROFHEALTH, 0, 0, 0, 0, 2000);
                }
                else {
                    SET_BOOTY(player, type, doMsgs, DRAGONSSKIN, HEALALLPOTION, 0, 0, 0, 5000);
                }
                if (PARTY_COUNT() == 1) {
                    GET_MONSTER(player, type, doMsgs, 01, 39);
                }
                else if (PARTY_COUNT() == 2) {
                    GET_MONSTER(player, type, doMsgs, 01, 11);
                    GET_MONSTER(player, type, doMsgs, 02, 38);
                    GET_MONSTER(player, type, doMsgs, 06, 39);
                }
                else {
                    GET_MONSTER(player, type, doMsgs, 01, 11);
                    GET_MONSTER(player, type, doMsgs, 02, 11);
                    GET_MONSTER(player, type, doMsgs, 03, 12);
                    GET_MONSTER(player, type, doMsgs, 06, 39);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The magic protection you try to weave around yourself is not enough to protect you from Gambril's keen vision.");
                SHOW_TEXT(player, type, doMsgs, "Scoffing that Osterog has selected a particularly pitiful party to kill him, the dragon toasts you with his flame-breath.");
                DAMAGE(player, type, doMsgs, MAX_HEALTH());
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, SCALE) == 1) {
                SHOW_TEXT(player, type, doMsgs, "Osterog lumbers away.");
                SET_FLAG(player, type, doMsgs, PARTY, DRAGON_A, 1);
            }
            else {
                if (HAS_ITEM(player, type, doMsgs, DRAGONSSKIN)) {
                    SHOW_PICTURE(player, type, doMsgs, WHITEDRAGON);
                    SET_FLAG(player, type, doMsgs, DUNGEON, SCALE, 1);
                    MOD_EXP(player, type, doMsgs, 500000);
                    MOD_GOLD(player, type, doMsgs, 25000);
                    GIVE_ITEM(player, type, doMsgs, STONEGIANTSHAMMER);
                    GIVE_ITEM(player, type, doMsgs, MIDNIGHTAEGIS);
                    GIVE_ITEM(player, type, doMsgs, FLAMETONGUE);
                    GIVE_ITEM(player, type, doMsgs, HEALAMPHORA);
                    GIVE_ITEM(player, type, doMsgs, ZEUSSCROLL);
                    SHOW_TEXT(player, type, doMsgs, "Osterog smiles broadly, gloating that his nemesis is finally dead.");
                    SHOW_TEXT(player, type, doMsgs, "As he doles out his reward, he says, 'I understand that the wizards of Hocus Pocus are much interested in unusual items. You may wish to show them your trophies.'");
                }
                else {
                    SHOW_PICTURE(player, type, doMsgs, WHITEDRAGON);
                    SET_FLAG(player, type, doMsgs, PARTY, DRAGON_A, 1);
                    SHOW_TEXT(player, type, doMsgs, "You encounter Osterog, the Ice Dragon.");
                    SHOW_TEXT(player, type, doMsgs, "'Long have I feuded with Gambril, the Frost Dragon.");
                    SHOW_TEXT(player, type, doMsgs, "Our endless battles have weakened the tunnels hereabout, and we no longer dare tread them.");
                    SHOW_TEXT(player, type, doMsgs, "If you can help me destroy my sworn enemy, I will reward you most generously. Bring me proof of your kill.");
                    SHOW_TEXT(player, type, doMsgs, "Your success may depend on greater magic than you now know.'");
                }
            }
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, PARTY, WIZCHOICE) == 5) {
                SHOW_TEXT(player, type, doMsgs, "The proper magic has led you to the dragon Osterog.");
                if (HAS_ITEM(player, type, doMsgs, DRAGONSSKIN)) {
                    SET_BOOTY(player, type, doMsgs, ELIXIROFHEALTH, 0, 0, 0, 0, 2000);
                }
                else {
                    SET_BOOTY(player, type, doMsgs, DRAGONSSKIN, HEALALLPOTION, 0, 0, 0, 5000);
                }
                if (PARTY_COUNT() == 1) {
                    GET_MONSTER(player, type, doMsgs, 01, 40);
                }
                else if (PARTY_COUNT() == 2) {
                    GET_MONSTER(player, type, doMsgs, 01, 11);
                    GET_MONSTER(player, type, doMsgs, 02, 38);
                    GET_MONSTER(player, type, doMsgs, 06, 40);
                }
                else {
                    GET_MONSTER(player, type, doMsgs, 01, 11);
                    GET_MONSTER(player, type, doMsgs, 02, 11);
                    GET_MONSTER(player, type, doMsgs, 04, 29);
                    GET_MONSTER(player, type, doMsgs, 06, 40);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "As you tiptoe towards the great beast, Osterog sniffs once and smiles a saurian smile.");
                SHOW_TEXT(player, type, doMsgs, "'Gambril has sent fools to kill me.'");
                SHOW_TEXT(player, type, doMsgs, "He turns toward you and roasts you with his flame-breath.");
                DAMAGE(player, type, doMsgs, MAX_HEALTH());
            }
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You encounter other adventurers who seek the dragon's reward.");
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 20);
                GET_MONSTER(player, type, doMsgs, 02, 36);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 20);
                GET_MONSTER(player, type, doMsgs, 02, 28);
                GET_MONSTER(player, type, doMsgs, 05, 36);
                GET_MONSTER(player, type, doMsgs, 06, 33);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 20);
                GET_MONSTER(player, type, doMsgs, 02, 20);
                GET_MONSTER(player, type, doMsgs, 03, 24);
                GET_MONSTER(player, type, doMsgs, 04, 24);
                GET_MONSTER(player, type, doMsgs, 05, 36);
                GET_MONSTER(player, type, doMsgs, 06, 37);
            }
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 17);
                GET_MONSTER(player, type, doMsgs, 02, 28);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 28);
                GET_MONSTER(player, type, doMsgs, 02, 15);
                GET_MONSTER(player, type, doMsgs, 05, 12);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 14);
                GET_MONSTER(player, type, doMsgs, 02, 14);
                GET_MONSTER(player, type, doMsgs, 03, 29);
                GET_MONSTER(player, type, doMsgs, 05, 32);
                GET_MONSTER(player, type, doMsgs, 06, 32);
            }
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 2);
                GET_MONSTER(player, type, doMsgs, 02, 31);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 31);
                GET_MONSTER(player, type, doMsgs, 02, 1);
                GET_MONSTER(player, type, doMsgs, 05, 25);
                GET_MONSTER(player, type, doMsgs, 06, 26);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 5);
                GET_MONSTER(player, type, doMsgs, 02, 5);
                GET_MONSTER(player, type, doMsgs, 03, 27);
                GET_MONSTER(player, type, doMsgs, 04, 30);
                GET_MONSTER(player, type, doMsgs, 05, 29);
            }
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, DRAGSTR) == 1) {
                SHOW_TEXT(player, type, doMsgs, "You push open the broken door with ease.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "As you push against the stubborn door, debris falls and injures you.");
                if (GET_STAT(player, type, doMsgs, STRENGTH) >= 23) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, DRAGSTR, 1);
                    DAMAGE(player, type, doMsgs, MAX_HEALTH(),  / , 3);
                }
                else {
                    SET_FLAG(player, type, doMsgs, DUNGEON, DRAGSTR, 1);
                    DAMAGE(player, type, doMsgs, MAX_HEALTH(),  / , 4);
                }
            }
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, DRAGDEF) == 1) {
                SHOW_TEXT(player, type, doMsgs, "The walls around you have been fortified.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The walls collapse upon you! Amnesia causes you to forget your more recent experiences.");
                if (GET_STAT(player, type, doMsgs, DEFENSE) >= 18) {
                    MOD_EXP(player, type, doMsgs,  - , 10000);
                    SET_FLAG(player, type, doMsgs, DUNGEON, DRAGDEF, 1);
                }
                else {
                    MOD_EXP(player, type, doMsgs,  - , 20000);
                    SET_FLAG(player, type, doMsgs, DUNGEON, DRAGDEF, 1);
                }
            }
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, DRAGINI) == 1) {
                SHOW_TEXT(player, type, doMsgs, "You elude a thief hiding in the shadows.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "A thief runs by you and picks your pocket.");
                if (GET_STAT(player, type, doMsgs, INITIATIVE) >= 13) {
                    MOD_GOLD(player, type, doMsgs,  - , 25000);
                    SET_FLAG(player, type, doMsgs, DUNGEON, DRAGINI, 1);
                }
                else {
                    MOD_GOLD(player, type, doMsgs,  - , 50000);
                    SET_FLAG(player, type, doMsgs, DUNGEON, DRAGINI, 1);
                }
            }
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, DRAGAGI) == 1) {
                SHOW_TEXT(player, type, doMsgs, "You resist the magical forces emanating from the chamber.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "You feel magical forces drain your mana.");
                if (GET_STAT(player, type, doMsgs, AGILITY) >= 11) {
                    MOD_MANA(player, type, doMsgs,  - , 200);
                    SET_FLAG(player, type, doMsgs, DUNGEON, DRAGAGI, 1);
                }
                else {
                    MOD_MANA(player, type, doMsgs,  - , 400);
                    SET_FLAG(player, type, doMsgs, DUNGEON, DRAGAGI, 1);
                }
            }
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, WRAITH);
            SHOW_TEXT(player, type, doMsgs, "The ghost of an adventurer appears before you.");
            SHOW_TEXT(player, type, doMsgs, "'Seek out the wizards in Dragon's Flame for help. Each, for a fee, will aid you with his or her unusual magic.");
            SHOW_TEXT(player, type, doMsgs, "BUT, all spells are not successful for all.");
            SHOW_TEXT(player, type, doMsgs, "I wish you better luck than I had. And remember, it is imperative that you stay in the area until you successfully complete your quest.'");
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 8, 2, 69, EAST);
        }
        protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 8, 2, 185, NORTH);
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_FLAG(player, type, doMsgs, PARTY, WIZCHOICE, 0);
            SET_FLAG(player, type, doMsgs, PARTY, ONE_NORTH, 0);
            SET_FLAG(player, type, doMsgs, PARTY, ONE_CENTER, 0);
            SET_FLAG(player, type, doMsgs, PARTY, ONE_SOUTH, 0);
        }
    }
}
