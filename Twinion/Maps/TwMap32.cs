using XPT.Generic.Maps;
using XPT.Twinion.Entities;

namespace XPT.Twinion.Maps {
    class TwMap32 : TwMap {
        protected override int MapIndex => 32;
        protected override int MapID => 0x0D01;
        protected override int RandomEncounterChance => 5;
        protected override int RandomEncounterExtraCount => 2;

        private const int MONST_PRAETORIAN_A = 25;
        private const int MONST_PRAETORIAN_B = 26;
        private const int MONST_SHADAX = 27;
        private const int MONST_GUARDA_POST = 4;
        private const int MONST_GUARDA_WANDER = 11;
        private const int MONST_GUARDA_RELAX = 3;
        private const int MONST_GUARDB_POST = 24;
        private const int MONST_GUARDB_WANDER = 22;
        private const int MONST_HALL_DEATH_1 = 28;
        private const int MONST_HALL_DEATH_2 = 29;
        private const int MONST_HALL_DEATH_3 = 30;
        private const int MONST_HALL_DEATH_4 = 31;
        private const int MONST_HALL_DEATH_5 = 32;
        private const int MONST_HALL_DEATH_6 = 33;
        private const int MONST_HALL_DEATH_7 = 34;
        private const int MONST_KEKEKETL = 35;
        private const int MONST_GUARDD_POST = 16;
        private const int MONST_GUARDD_WANDER = 17;
        private const int MONST_GAOLER = 36;
        private const int MONST_CHORONZAR_TOUGH = 38;
        private const int MONST_CHORONZAR_WIMPY = 37;
        private const int MONST_CHISS = 39;
        private const int BIG_BOOTY_1 = 14;
        private const int BIG_BOOTY_2 = 39;
        private const int BIG_BOOTY_3 = 76;
        private const int BIG_BOOTY_4 = 134;
        private const int BIG_BOOTY_5 = 171;
        private const int BIG_BOOTY_6 = 40;
        private const int BIG_BOOTY_7 = 92;
        private const int BIG_BOOTY_8 = 171;
        private const int BIG_BOOTY_9 = 61;
        private const int BIG_BOOTY_10 = 16;
        private const int BIG_BOOTY_11 = 166;
        private const int BIG_BOOTY_12 = 24;
        private const int BIG_BOOTY_13 = 171;
        private const int BIG_BOOTY_14 = 136;
        private const int BIG_BOOTY_15 = 59;
        private const int BIG_BOOTY_16 = 90;
        private const int BIG_BOOTY_17 = 171;
        private const int BIG_BOOTY_18 = 17;
        private static int NAOMI_PIC = (23 + HUMANBARBARIAN - 1);
        private static int CONCIERGE_PIC = (24 + HUMANBARBARIAN - 1);
        private const int SHADAX_KILLED_BIT = 1;
        private const int CHISS_KILLED_BIT = 2;
        private const int CHORONZAR_KILLED_BIT = 4;
        private const int GAOLER_KILLED_BIT = 8;
        private const int CHORONZAR_KNOWN_BIT = 8;
        private const int NAOMI_KNOWN_BIT = 40;
        private const int ALCHEMY_KNOWN_BIT = 2;
        private const int GOT_CHOR_EXP_BIT = 1;
        private const int ANOINTED_BIT = 2;
        private const int SECRET_PASSAGE_BIT = 10;
        private const int LEVER_PUZZLE = 0;
        private const int CONTROL_1 = 1;
        private const int COASTER_STOPPING = 2;
        private const int STEAK_COUNT = 3;
        private const int DEATH_LEVEL = 4;
        private const int FISH_FEEDING_CNT = 5;
        private const int ALCHEMY_LEVEL = 6;
        private const int SIGNED_IN_BIT = 1;
        private const int POND_DESC_BIT = 2;
        private const int PASSWORD_FOUND_BIT = 4;
        private const int KEKEKETL_KILLED_BIT = 8;
        private const int FED_FISH_RIGHT_BIT = 10;
        private const int FED_FISH_LEFT_BIT = 20;
        private const int SEEN_IT = 0;
        private const int SEEN_IT2 = 1;
        private const int DONE_IT = 1;
        string alchemyStr = "Choronzar hopes to advance his position among the gods by magical means. To this end he is attempting an alchemical Binding Ritual on the mortal spirits his minions kidnap. Thus far success -- in the form of the correct formula -- has eluded him.";
        string choronzarStr = "Choronzar is a trickster deity. Although he is a lesser light among the evil pantheon, his cunning and ambition far exceed the comprehension of his more powerful brethren, many of whom consider him insane and hence relatively harmless.";
        string naomiStr = "Princess Naomi was abducted from her world by Shadax, who was attracted by the purity of her spirit. Choronzar fell in love with her and spared her from his experiments in the hope that she would return his affections. She has not.";
        string dissStr = "The cauldron boils up as the bar dissolves.";
        string brackStr = "The liquid in the cauldron turns a brackish gray-brown and stops bubbling.";
        string anointStr = "'You have saved us from eternal torment. Our strength is now yours in the battle to come.'";
        string piranhaDeathStr = "You are swarmed by a school of vicious piranhas and torn to shreds.";
        string jostleStr = "You jostle each other and tumble into the water.";
        void SixMonst(int *macros, byte monster) {
            byte i = 0;
            byte num = 0;
            switch (PARTY_COUNT(player, type, doMsgs)) {
                case 1:
                    num = 2;
                    break;
                case 2:
                    num = 3;
                    break;
                case 3:
                    num = 5;
                    break;
                case 4:
                default:
                    num = 6;
                    break;
            }
            for (i = 1; i <= num; i++) {
                GET_MONSTER(player, type, doMsgs, i, monster);
            }
        }
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ushort i = 0;
            SHOW_TEXT(player, type, doMsgs, "The boiling lava scorches you terribly.");
            i = HEALTH(player, type, doMsgs);
             - 1;
            DAMAGE(player, type, doMsgs, i);
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You writhe in agony as the poisonous waters close over you");
            DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            switch (HERE(player, type, doMsgs)) {
                case 4:
                case 6:
                case 8:
                case 10:
                case 68:
                case 70:
                case 72:
                default:
                    TELEPORT(player, type, doMsgs, 8, 1, 0, EAST);
                    break;
            }
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, CHOR_NPC_KILLED) & CHORONZAR_KILLED_BIT) {
                TELEPORT(player, type, doMsgs, 13, 1, 74, EAST);
            }
            else {
                TELEPORT(player, type, doMsgs, 8, 1, 0, EAST);
            }
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_FLOOR(player, type, doMsgs, HERE(player, type, doMsgs));
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 13, 1, 56, NORTH);
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            byte fishFlag = 0byte fishFlag;byte mapSquare = 0;
            fishFlag = GET_FLAG(player, type, doMsgs, PARTY, FISH_FEEDING_CNT);
            mapSquare = HERE(player, type, doMsgs);
            if ((mapSquare <= 148) || (fishFlag == 0)) {
                SHOW_TEXT(player, type, doMsgs, piranhaDeathStr);
                DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
                return;
                ;
            }
            switch (fishFlag) {
                case 0:
                    SHOW_TEXT(player, type, doMsgs, piranhaDeathStr);
                    DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
                    break;
                case 1:
                    SHOW_TEXT(player, type, doMsgs, "The piranhas have returned! They begin to snap and bite, mauling you horribly.");
                    DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 2);
                    break;
                case 2:
                    SHOW_TEXT(player, type, doMsgs, "The water to the north is less agitated than before.");
                    break;
                case 3:
                default:
                    SHOW_TEXT(player, type, doMsgs, "Gingerly you wade through the pond. North of you the water continues to seethe where the piranhas are feeding.");
                    break;
            }
            fishFlag--;
            SET_FLAG(player, type, doMsgs, PARTY, FISH_FEEDING_CNT, fishFlag);
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_JOIN(player, type, doMsgs);
            if (PARTY_COUNT(player, type, doMsgs) > 1) {
                SHOW_TEXT(player, type, doMsgs, "The coaster cars are only big enough for one of you at a time.");
                SET_FLAG(player, type, doMsgs, PARTY, COASTER_STOPPING, 0);
                TELEPORT(player, type, doMsgs, 13, 1, 103, WEST);
            }
            switch (HERE(player, type, doMsgs)) {
                case 86:
                    SHOW_TEXT(player, type, doMsgs, "The coaster gains speed as it dips giddily into the darkness.");
                    TELEPORT(player, type, doMsgs, 13, 2, 255, WEST);
                    break;
                case 102:
                    BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
                    BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), SOUTH);
                    if (FLAG_ON(player, type, doMsgs, PARTY, COASTER_STOPPING)) {
                        SHOW_TEXT(player, type, doMsgs, "The coaster stops.");
                        SET_FLAG(player, type, doMsgs, PARTY, COASTER_STOPPING, 0);
                        TELEPORT(player, type, doMsgs, 13, 1, 103, EAST);
                    }
                    else if (HAS_ITEM(player, type, doMsgs, FUNHOUSEKEY)) {
                        SHOW_TEXT(player, type, doMsgs, "You twist the Funhouse Key in the keyhole. With a lurch the car begins to rumble forward along the rails.");
                        TELEPORT(player, type, doMsgs, 13, 1, 86, NORTH);
                    }
                    break;
                case 118:
                default:
                    SET_FLAG(player, type, doMsgs, PARTY, COASTER_STOPPING, 1);
                    TELEPORT(player, type, doMsgs, 13, 1, 102, NORTH);
                    break;
            }
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            byte flag = 0;
            byte square = 0;
            byte naomiFlag = 0;
            flag = GET_FLAG(player, type, doMsgs, PARTY, CONTROL_1);
            square = HERE(player, type, doMsgs);
            switch (square) {
                case 132:
                    if (((flag & POND_DESC_BIT) == 0)) {
                        SHOW_TEXT(player, type, doMsgs, "You are standing on a small jetty above a fish pond. Before you a raised, earthen pathway snakes out across the water.");
                        if (PARTY_COUNT(player, type, doMsgs) > 1) {
                            SHOW_TEXT(player, type, doMsgs, "The path is narrow and slippery. You had better proceed alone.");
                        }
                        flag |= POND_DESC_BIT;
                        SET_FLAG(player, type, doMsgs, PARTY, CONTROL_1, flag);
                    }
                    break;
                case 177:
                    if (PARTY_COUNT(player, type, doMsgs) > 1) {
                        SHOW_TEXT(player, type, doMsgs, jostleStr);
                        TELEPORT(player, type, doMsgs, 13, 1, square + 1, EAST);
                    }
                    if (FACING(player, type, doMsgs) == SOUTH) {
                        naomiFlag = GET_FLAG(player, type, doMsgs, DUNGEON, CHOR_NAOMI_MET);
                        if ((naomiFlag == 1) || (naomiFlag == 2)) {
                            SHOW_TEXT(player, type, doMsgs, "To the south and east you can dimly make out the silhouette of a woman standing on a small island.");
                        }
                    }
                    break;
                default:
                    if (PARTY_COUNT(player, type, doMsgs) > 1) {
                        SHOW_TEXT(player, type, doMsgs, jostleStr);
                        if ((square == 161) || (square == 146)) {
                            TELEPORT(player, type, doMsgs, 13, 1, square + 1, EAST);
                        }
                        else {
                            TELEPORT(player, type, doMsgs, 13, 1, square - 16, EAST);
                        }
                    }
                    break;
            }
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            byte ctrlFlags = 0byte ctrlFlags;byte cntFlag = 0;
            if (USED_ITEM(player, type, doMsgs, JUICYDRAGONSTEAK, JUICYDRAGONSTEAK)) {
                TAKE_ITEM(player, type, doMsgs, JUICYDRAGONSTEAK);
                ctrlFlags = GET_FLAG(player, type, doMsgs, PARTY, CONTROL_1);
                cntFlag = GET_FLAG(player, type, doMsgs, PARTY, FISH_FEEDING_CNT);
                if (cntFlag == 0) {
                    if (HERE(player, type, doMsgs) == 132) {
                        ctrlFlags |= FED_FISH_RIGHT_BIT;
                    }
                    else {
                        ctrlFlags |= FED_FISH_LEFT_BIT;
                    }
                    if ((ctrlFlags & FED_FISH_RIGHT_BIT) && (ctrlFlags & FED_FISH_LEFT_BIT)) {
                        ctrlFlags &= ~(FED_FISH_RIGHT_BIT | FED_FISH_LEFT_BIT);
                        cntFlag = 6;
                        SHOW_TEXT(player, type, doMsgs, "A swarm of fish churns the water in a mad feeding frenzy.");
                    }
                    else {
                        SHOW_TEXT(player, type, doMsgs, "The nearby fish quickly gather and begin tearing at the steak.");
                    }
                }
                else {
                    cntFlag = 6;
                }
                SET_FLAG(player, type, doMsgs, PARTY, CONTROL_1, ctrlFlags);
                SET_FLAG(player, type, doMsgs, PARTY, FISH_FEEDING_CNT, cntFlag);
            }
            else if (FLAG_OFF(player, type, doMsgs, PARTY, FISH_FEEDING_CNT)) {
                SHOW_TEXT(player, type, doMsgs, "As you approach the water's edge you see the fish gathering expectantly.");
            }
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (FLAG_OFF(player, type, doMsgs, PARTY, FISH_FEEDING_CNT)) {
                SHOW_TEXT(player, type, doMsgs, "Nasty-looking fish dart through the dark water below.");
            }
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, PARTY, CONTROL_1) & SIGNED_IN_BIT) {
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
            }
            else {
                BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
            }
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Beneath some debris you find a water-damaged book entitled Journal of Bragadan the Brave. The only legible entry reads '...believe I have found a way through the accursed lever maze.");
            SHOW_TEXT(player, type, doMsgs, "Though I have struggled lifelong to uphold the right and good, now I must follow the sinister path...'");
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ushort switchCode = 0;
            char *strPtr1 = NULL;
            byte knownFlags = 0;
            switchCode = HERE(player, type, doMsgs);
            switchCode = switchCode << 8;
            switchCode +  = FACING(player, type, doMsgs);
            knownFlags = GET_FLAG(player, type, doMsgs, DUNGEON, CHOR_KNOWN);
            switch (switchCode) {
                case ((94 << 8) | NORTH):
                    if (knownFlags & ALCHEMY_KNOWN_BIT) {
                        strPtr1 = alchemyStr;
                    }
                    break;
                case ((94 << 8) | EAST):
                    strPtr1 = choronzarStr;
                    break;
                case ((108 << 8) | WEST):
                    if (knownFlags & NAOMI_KNOWN_BIT) {
                        strPtr1 = naomiStr;
                    }
                    break;
                default:
                    break;
            }
            if (strPtr1 != null) {
                SHOW_TEXT(player, type, doMsgs, "Poring over the dusty tomes you learn the following:");
                SHOW_TEXT(player, type, doMsgs, strPtr1);
            }
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            byte expFlag = 0;
            byte killedFlag = 0;
            SHOW_TEXT(player, type, doMsgs, "This is a massive throne carved from a single block of polished obsidian.  It is inlaid with strange, beautiful sigils in a delicate silver filigree.");
            expFlag = GET_FLAG(player, type, doMsgs, DUNGEON, CHOR_CONTROL_1);
            killedFlag = GET_FLAG(player, type, doMsgs, DUNGEON, CHOR_NPC_KILLED);
            if ((killedFlag & CHORONZAR_KILLED_BIT) && (((expFlag & GOT_CHOR_EXP_BIT) == 0))) {
                SHOW_TEXT(player, type, doMsgs, "You thrill to the surge of life force coursing into you from the throne.");
                MOD_EXP(player, type, doMsgs, 10000000);
                expFlag |= GOT_CHOR_EXP_BIT;
                SET_FLAG(player, type, doMsgs, DUNGEON, CHOR_CONTROL_1, expFlag);
            }
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Embedded in the front panel of the car is a keyhole.");
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The glowing rift is the only way back to your world.");
            TELEPORT(player, type, doMsgs, 8, 1, 0, EAST);
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, CHOR_NAOMI_MET) >= 3) {
                SHOW_TEXT(player, type, doMsgs, "You discover a narrow secret passageway.");
                if (PARTY_COUNT(player, type, doMsgs) > 1) {
                    SHOW_TEXT(player, type, doMsgs, "You will have to squeeze through one at a time.");
                }
                SET_FLAG(player, type, doMsgs, DUNGEON, CHOR_CONTROL_1, GET_FLAG(player, type, doMsgs, DUNGEON, CHOR_CONTROL_1) | SECRET_PASSAGE_BIT);
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
            }
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ushort switchFlag = 0;
            byte alchFlag = 0;
            byte takeItem = 0;
            char *strPtr = NULL;
            BLOCK_FLOOR(player, type, doMsgs, 13);
            BLOCK_FLOOR(player, type, doMsgs, 14);
            BLOCK_FLOOR(player, type, doMsgs, 15);
            BLOCK_FLOOR(player, type, doMsgs, 31);
            BLOCK_FLOOR(player, type, doMsgs, 57);
            alchFlag = GET_FLAG(player, type, doMsgs, PARTY, ALCHEMY_LEVEL);
            SHOW_TEXT(player, type, doMsgs, "Alchemical implements of all descriptions clutter this workbench, including four large black kettles full of bubbling liquid.");
            SET_FLAG(player, type, doMsgs, DUNGEON, CHOR_KNOWN, GET_FLAG(player, type, doMsgs, DUNGEON, CHOR_KNOWN) | ALCHEMY_KNOWN_BIT);
            if (USED_ITEM(player, type, doMsgs, SILVERBAR, SILVERBAR)) {
                takeItem = SILVERBAR;
                if (alchFlag == 0) {
                    alchFlag = 1;
                    strPtr = dissStr;
                }
                else {
                    strPtr = brackStr;
                    alchFlag = 0;
                }
            }
            else if (USED_ITEM(player, type, doMsgs, GOLDBAR, GOLDBAR)) {
                takeItem = GOLDBAR;
                if (alchFlag == 1) {
                    alchFlag = 2;
                    strPtr = dissStr;
                }
                else {
                    strPtr = brackStr;
                    alchFlag = 0;
                }
            }
            else if (USED_ITEM(player, type, doMsgs, PLATINUMBAR, PLATINUMBAR)) {
                takeItem = PLATINUMBAR;
                if (alchFlag == 2) {
                    alchFlag = 3;
                    strPtr = dissStr;
                }
                else {
                    strPtr = brackStr;
                    alchFlag = 0;
                }
            }
            else if (USED_ITEM(player, type, doMsgs, PRICELESSBAR, PRICELESSBAR)) {
                takeItem = PRICELESSBAR;
                if (alchFlag == 3) {
                    alchFlag = 4;
                    SHOW_TEXT(player, type, doMsgs, "Eerie green light floods the room as all of the cauldrons begin to boil violently. With an unearthly moan the spirits trapped within begin to stream forth in twisting, vaporous tendrils.");
                    strPtr = anointStr;
                }
                else {
                    strPtr = brackStr;
                    alchFlag = 0;
                }
            }
            if (takeItem != 0) {
                TAKE_ITEM(player, type, doMsgs, takeItem);
            }
            if (strPtr != null) {
                SHOW_TEXT(player, type, doMsgs, strPtr);
            }
            SET_FLAG(player, type, doMsgs, PARTY, ALCHEMY_LEVEL, alchFlag);
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ushort monster = 0;
            ushort i = 0;
            if (((GET_FLAG(player, type, doMsgs, DUNGEON, CHOR_NPC_KILLED) & CHORONZAR_KILLED_BIT) == 0)) {
                switch (HERE(player, type, doMsgs)) {
                    case 35:
                        SHOW_TEXT(player, type, doMsgs, "Dazzled, you step into a brightly-lit, vaulted chamber. The musky smell of incense hangs in the air and the delicate music of chimes is audible in the distance.");
                        monster = MONST_PRAETORIAN_A;
                        CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
                        break;
                    case 36:
                        if (FACING(player, type, doMsgs) == EAST) {
                            SHOW_TEXT(player, type, doMsgs, "Ahead of you through the layers of smoke you see a massive golden throne.");
                        }
                        monster = MONST_PRAETORIAN_A;
                        break;
                    case 37:
                        if (FACING(player, type, doMsgs) == EAST) {
                            SHOW_TEXT(player, type, doMsgs, "As you draw closer you make out an insoucient figure lounging on the throne, dressed in jester's motley.");
                        }
                        monster = MONST_PRAETORIAN_B;
                        break;
                    case 38:
                    default:
                        if (FACING(player, type, doMsgs) == EAST) {
                            SHOW_TEXT(player, type, doMsgs, "The crazed figure on the throne stands, stares at you briefly, then prances off to the southeast, cackling like a lunatic. He dives into a pit and vanishes.");
                        }
                        monster = MONST_PRAETORIAN_B;
                        break;
                }
                SixMonst(player, type, doMsgs, monster);
            }
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            byte bootyFlag = 0;
            byte booty1 = 0byte booty1;byte booty2 = 0byte booty2;byte booty3 = 0;
            bootyFlag = GET_FLAG(player, type, doMsgs, DUNGEON, CHOR_BOOTY);
            switch (HERE(player, type, doMsgs)) {
                case 57:
                    if (((bootyFlag & 0x01) == 0)) {
                        booty1 = BIG_BOOTY_1;
                        booty2 = BIG_BOOTY_2;
                        booty3 = BIG_BOOTY_3;
                        bootyFlag |= 0;
                        x01;
                    }
                    break;
                case 58:
                    if (((bootyFlag & 0x02) == 0)) {
                        booty1 = BIG_BOOTY_4;
                        booty2 = BIG_BOOTY_5;
                        booty3 = BIG_BOOTY_6;
                        bootyFlag |= 0;
                        x02;
                    }
                    break;
                case 59:
                    if (((bootyFlag & 0x04) == 0)) {
                        booty1 = BIG_BOOTY_7;
                        booty2 = BIG_BOOTY_8;
                        booty3 = BIG_BOOTY_9;
                        bootyFlag |= 0;
                        x04;
                    }
                    break;
                case 91:
                    if (((bootyFlag & 0x10) == 0)) {
                        booty1 = BIG_BOOTY_10;
                        booty2 = BIG_BOOTY_11;
                        booty3 = BIG_BOOTY_12;
                        bootyFlag |= 0;
                        x10;
                    }
                    break;
                case 90:
                    if (((bootyFlag & 0x20) == 0)) {
                        booty1 = BIG_BOOTY_13;
                        booty2 = BIG_BOOTY_14;
                        booty3 = BIG_BOOTY_15;
                        bootyFlag |= 0;
                        x20;
                    }
                    break;
                case 89:
                default:
                    if (((bootyFlag & 0x040) == 0)) {
                        booty1 = BIG_BOOTY_16;
                        booty2 = BIG_BOOTY_17;
                        booty3 = BIG_BOOTY_18;
                        bootyFlag |= 0;
                        x40;
                    }
                    break;
            }
            if (booty1 != 0) {
                SHOW_TEXT(player, type, doMsgs, "There is a pile of treasure here!");
                GIVE_ITEM(player, type, doMsgs, booty1);
                GIVE_ITEM(player, type, doMsgs, booty2);
                GIVE_ITEM(player, type, doMsgs, booty3);
            }
            SET_FLAG(player, type, doMsgs, DUNGEON, CHOR_BOOTY, bootyFlag);
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_ITEM(player, type, doMsgs, WEAPON_IN_HAND(player, type, doMsgs), WEAPON_IN_HAND(player, type, doMsgs))) {
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), NORTH);
                SHOW_TEXT(player, type, doMsgs, "You bash the lock off the door.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The door is held shut by a hefty padlock which does not appear to have a keyhole.");
            }
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ushort steakCnt = 0;
            steakCnt = GET_FLAG(player, type, doMsgs, PARTY, STEAK_COUNT);
            if (((HAS_ITEM(player, type, doMsgs, JUICYDRAGONSTEAK) == 0)) && (steakCnt < 6)) {
                SHOW_TEXT(player, type, doMsgs, "You find a package of juicy dragon steaks!");
                steakCnt +  = 2;
                GIVE_ITEM(player, type, doMsgs, JUICYDRAGONSTEAK);
                GIVE_ITEM(player, type, doMsgs, JUICYDRAGONSTEAK);
            }
            SET_FLAG(player, type, doMsgs, PARTY, STEAK_COUNT, steakCnt);
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A small brass sign on the door reads 'Madcap Labs. Absolutely NO solicitors!'");
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_JOIN(player, type, doMsgs);
            if (PARTY_COUNT(player, type, doMsgs) > 1) {
                SHOW_TEXT(player, type, doMsgs, "The passage is too narrow.");
                TELEPORT(player, type, doMsgs, 13, 1, 12, WEST);
            }
            else if (GET_FLAG(player, type, doMsgs, DUNGEON, CHOR_NAOMI_MET) < 3) {
                SHOW_TEXT(player, type, doMsgs, "You are not worthy.");
                TELEPORT(player, type, doMsgs, 13, 1, 12, WEST);
            }
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Above the door is a wooden sign: 'Library. SHHHH!!!!'");
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_SKILL(player, type, doMsgs, DETECT_SKILL) >= 12) {
                SHOW_TEXT(player, type, doMsgs, "You discover a secret compartment in the floor of the closet. A scroll reads 'Commander Shadax, You are to step up the acquisition of mortals for my experiments immediately. Signed, Choronzar'");
                SET_FLAG(player, type, doMsgs, DUNGEON, CHOR_KNOWN, GET_FLAG(player, type, doMsgs, DUNGEON, CHOR_KNOWN) | ALCHEMY_KNOWN_BIT);
            }
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            byte killedFlag = 0;
            killedFlag = GET_FLAG(player, type, doMsgs, DUNGEON, CHOR_NPC_KILLED);
            if (HAS_ITEM(player, type, doMsgs, JESTERSCAP) && ((killedFlag & CHORONZAR_KILLED_BIT) == 0)) {
                killedFlag |= CHORONZAR_KILLED_BIT;
                SET_FLAG(player, type, doMsgs, DUNGEON, CHOR_NPC_KILLED, killedFlag);
                SHOW_TEXT(player, type, doMsgs, "Choronzar's body begins to deliquesce as hissing smoke pours from his bloodied clothes. The room bucks and lurches as shockwaves roll through, knocking you to your knees.");
                SHOW_TEXT(player, type, doMsgs, "Over the din of the reverberations you hear a British voice asking 'what was that about HATS?' There is a sickening peal of hysterical, eldritch laughter. Then silence.");
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This is a freezer-locker.  Oversized blocks of ice stacked half-way to the ceiling keep it very cold in here.");
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, PARTY, ALCHEMY_LEVEL) == 4) {
                SET_FLAG(player, type, doMsgs, DUNGEON, CHOR_CONTROL_1, GET_FLAG(player, type, doMsgs, DUNGEON, CHOR_CONTROL_1) | ANOINTED_BIT);
            }
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            byte flag = 0;
            SHOW_TEXT(player, type, doMsgs, "On the south wall is a poster depicting a scantily-clad Kaalroth posing beside an enormous tankard of mead. Tearing it aside you discover the word 'SMILE' scrawled on the wall in charcoal.");
            flag = GET_FLAG(player, type, doMsgs, PARTY, CONTROL_1);
            flag |= PASSWORD_FOUND_BIT;
            SET_FLAG(player, type, doMsgs, PARTY, CONTROL_1, flag);
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            byte passFlag = 0;
            if (GET_FLAG(player, type, doMsgs, DUNGEON, CHOR_NPC_KILLED) & GAOLER_KILLED_BIT) {
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "A slit in the door shoots open and a gutteral voice demands, 'Wot's th' password?'");
                passFlag = GET_FLAG(player, type, doMsgs, PARTY, CONTROL_1);
                if (passFlag & PASSWORD_FOUND_BIT) {
                    SHOW_TEXT(player, type, doMsgs, "You reply 'the password is 'SMILE',' and the door creaks open. The gaoler growls, 'Come on in so's I can look at ye. One at a time!'");
                    CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "You stammer helplessly, not knowing the password. 'Come back when ye've remembered it!' The slit slams shut.");
                }
            }
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            byte flag = 0;
            flag = GET_FLAG(player, type, doMsgs, DUNGEON, CHOR_NAOMI_MET);
            if (flag == 0) {
                flag++;
                SET_FLAG(player, type, doMsgs, DUNGEON, CHOR_NAOMI_MET, flag);
                SHOW_PICTURE(player, type, doMsgs, NAOMI_PIC);
                SHOW_TEXT(player, type, doMsgs, "You step into the dismal little cell and draw up short. Before you stands a radiant woman in a flowing, violet gown. She is slender and graceful but her eyes bore into you with unnerving intensity.");
                SHOW_TEXT(player, type, doMsgs, "'Enough!' she cries. 'I grow tired of these pathetic ruses. Tell your master my answer is 'NO!'' Before you can respond she stalks past you and is gone.");
                flag = GET_FLAG(player, type, doMsgs, DUNGEON, CHOR_KNOWN);
                flag |= NAOMI_KNOWN_BIT;
                SET_FLAG(player, type, doMsgs, DUNGEON, CHOR_KNOWN, flag);
            }
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Charts and war-trophies decorate the walls of this military command center. Several crude desks are strewn with scrolls and parchments.");
        }
        protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This room, though spartan, appears to be the personal quarters of a high-ranking officer.");
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A portrait on the north wall depicts Shadax and a snake-woman posing in their wedding clothes. 'Shadax and Chiss, 8743 A.C.'");
        }
        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Before you gleams a wondrous, cunningly crafted chariot. Fashioned of hardwood and steel, it has been gaudily painted in glossy red and green lacquers. In front of the first car two shiny rails extend into the darkness to the north.");
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            byte puzzFlag = 0;
            SHOW_TEXT(player, type, doMsgs, "You pull the lever.");
            puzzFlag = GET_FLAG(player, type, doMsgs, PARTY, LEVER_PUZZLE);
            switch (HERE(player, type, doMsgs)) {
                case 87:
                    if (puzzFlag == 0) {
                        puzzFlag = 1;
                    }
                    else {
                        puzzFlag = 0;
                    }
                    break;
                case 107:
                    if (puzzFlag == 1) {
                        puzzFlag = 2;
                    }
                    else {
                        puzzFlag = 0;
                    }
                    break;
                case 153:
                    if (puzzFlag == 2) {
                        puzzFlag = 3;
                    }
                    else {
                        puzzFlag = 0;
                    }
                    break;
                case 121:
                    if (puzzFlag == 3) {
                        PLACE_WALL_ITEM(player, type, doMsgs, DOOR, 127, NORTH);
                        CLEAR_WALL(player, type, doMsgs, 127, NORTH);
                        puzzFlag = 4;
                    }
                    break;
                default:
                    puzzFlag = 0;
                    break;
            }
            if (puzzFlag == 0) {
                SHOW_TEXT(player, type, doMsgs, "Mocking laughter echoes from far away.");
            }
            else if (puzzFlag == 4) {
                puzzFlag = 0;
                SHOW_TEXT(player, type, doMsgs, "You hear a rumbling sound to the east.");
            }
            SET_FLAG(player, type, doMsgs, PARTY, LEVER_PUZZLE, puzzFlag);
        }
        protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This is a storage room. Barrels and crates are stacked haphazardly.");
        }
        protected override void FnEvent3B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            byte flagBits = 0;
            SHOW_TEXT(player, type, doMsgs, "Buried beneath a stack of papers you find a scroll: 'Commander Shadax, It seems the princess prefers a gaol cell to the comforts of her chambers. Advise the Gaoler that she may come and go as she pleases. Signed, Choronzar'");
            flagBits = GET_FLAG(player, type, doMsgs, DUNGEON, CHOR_KNOWN);
            flagBits |= NAOMI_KNOWN_BIT;
            SET_FLAG(player, type, doMsgs, DUNGEON, CHOR_KNOWN, flagBits);
        }
        protected override void FnEvent64(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((HAS_ITEM(player, type, doMsgs, FUNHOUSEKEY) == 0)) {
                SHOW_TEXT(player, type, doMsgs, "A gigantic snake-woman looms over you, swaying hypnotically. 'Yessss,' she hisses, 'it will be sweet revenge to taste the mortal blood that stole my husband Shadax!'");
                SET_BOOTY(player, type, doMsgs, FUNHOUSEKEY, 0, 0, 0, 0, 0);
                GET_MONSTER(player, type, doMsgs, 1, MONST_CHISS);
            }
        }
        protected override void FnEvent65(TwPlayerServer player, MapEventType type, bool doMsgs) {
            byte flagBits = 0;
            flagBits = GET_FLAG(player, type, doMsgs, DUNGEON, CHOR_NPC_KILLED);
            if (((flagBits & SHADAX_KILLED_BIT) == 0)) {
                SHOW_TEXT(player, type, doMsgs, "You feel a rush of vertigo as you pass through the rift.");
                SHOW_TEXT(player, type, doMsgs, "Before you towers an enormous Kaalroth in full battle dress. 'Who dares to invade the realm of Choronzar?', he roars. 'I, Shadax, shall see that you never return!'");
                flagBits = GET_FLAG(player, type, doMsgs, DUNGEON, CHOR_KNOWN);
                flagBits |= CHORONZAR_KNOWN_BIT;
                SET_FLAG(player, type, doMsgs, DUNGEON, CHOR_KNOWN, flagBits);
                GET_MONSTER(player, type, doMsgs, 01, MONST_SHADAX);
            }
        }
        protected override void FnEvent67(TwPlayerServer player, MapEventType type, bool doMsgs) {
            byte flag = 0;
            flag = GET_FLAG(player, type, doMsgs, DUNGEON, CHOR_NAOMI_MET);
            if ((flag > 0) && (flag < 3) && FLAG_OFF(player, type, doMsgs, ROOM, SEEN_IT)) {
                SHOW_PICTURE(player, type, doMsgs, NAOMI_PIC);
                SHOW_TEXT(player, type, doMsgs, "You clamber from the muddy water onto the island. Naomi is here.");
                SET_FLAG(player, type, doMsgs, ROOM, SEEN_IT, 1);
            }
            switch (flag) {
                case 1:
                    SHOW_TEXT(player, type, doMsgs, "'Well,' she says icily, 'you are persistent in your mendacity, I grant you that.' She smiles slyly. 'If you really want me to believe you were not sent by Choronzar then find and return my Spirit Bottle!'");
                    GIVE_ITEM(player, type, doMsgs, NAOMISKEY);
                    flag++;
                    break;
                case 2:
                    if (USED_ITEM(player, type, doMsgs, SPIRITBOTTLE, SPIRITBOTTLE)) {
                        TAKE_ITEM(player, type, doMsgs, SPIRITBOTTLE);
                        SHOW_TEXT(player, type, doMsgs, "You offer the Spirit Bottle to Naomi. She snatches it from your hand and squints at it suspiciously. Then her eyes widen and her expression softens.");
                        SHOW_TEXT(player, type, doMsgs, "'I have misjudged you,' she says quietly. 'My debt to you is so great that I can never hope to repay it. Still, I will do what I can.");
                        SHOW_TEXT(player, type, doMsgs, "I once saw Choronzar slip through a secret passageway in the back of his laboratory. I believe it leads to his throne room!  Perhaps you can use it to circumvent his many guards.");
                        SHOW_TEXT(player, type, doMsgs, "Now I must go. Farewell, and may Fortune smile upon you always!' She uncorks the bottle and a cloud of coruscating crimson fog quickly envelops her.  'I no longer exist here!'");
                        SHOW_TEXT(player, type, doMsgs, "When the fog clears Naomi is gone.");
                        flag++;
                    }
                    else {
                        SHOW_TEXT(player, type, doMsgs, "Naomi snaps, 'Have you brought my Spirit Bottle, or is this another feeble attempt to deceive me?'");
                        if ((HAS_ITEM(player, type, doMsgs, NAOMISKEY) == 0)) {
                            GIVE_ITEM(player, type, doMsgs, NAOMISKEY);
                        }
                    }
                    break;
                default:
                    break;
            }
            SET_FLAG(player, type, doMsgs, DUNGEON, CHOR_NAOMI_MET, flag);
        }
        protected override void FnEvent68(TwPlayerServer player, MapEventType type, bool doMsgs) {
            byte flag = 0;
            flag = GET_FLAG(player, type, doMsgs, PARTY, CONTROL_1);
            if (((flag & SIGNED_IN_BIT) == 0)) {
                SHOW_PICTURE(player, type, doMsgs, CONCIERGE_PIC);
                SHOW_TEXT(player, type, doMsgs, "An owlish man sits poring over some documents behind an imposing, oaken desk. Without glancing up he gestures toward a ledger-book. 'Sign in please.'");
                flag |= SIGNED_IN_BIT;
                SET_FLAG(player, type, doMsgs, PARTY, CONTROL_1, flag);
                SET_FLAG(player, type, doMsgs, PARTY, DEATH_LEVEL, 0);
            }
        }
        protected override void FnEvent69(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SixMonst(player, type, doMsgs, MONST_GUARDA_POST);
        }
        protected override void FnEvent6A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SixMonst(player, type, doMsgs, MONST_GUARDA_WANDER);
        }
        protected override void FnEvent6B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SixMonst(player, type, doMsgs, MONST_GUARDA_RELAX);
        }
        protected override void FnEvent6C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SixMonst(player, type, doMsgs, MONST_GUARDB_POST);
        }
        protected override void FnEvent6D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SixMonst(player, type, doMsgs, MONST_GUARDB_WANDER);
        }
        protected override void FnEvent6E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            byte ctrlFlag = 0;
            byte deathFlag = 0;
            ushort i = 0;
            ushort monster = 0;
            ctrlFlag = GET_FLAG(player, type, doMsgs, PARTY, CONTROL_1);
            deathFlag = GET_FLAG(player, type, doMsgs, PARTY, DEATH_LEVEL);
            if (FLAG_OFF(player, type, doMsgs, ROOM, SEEN_IT) && (ctrlFlag & SIGNED_IN_BIT)) {
                SHOW_TEXT(player, type, doMsgs, "You trudge forward down the Hall of Death.");
                deathFlag++;
                SET_FLAG(player, type, doMsgs, ROOM, SEEN_IT, 1);
            }
            if (ctrlFlag & SIGNED_IN_BIT) {
                monster = (deathFlag / 3);
                if (monster > 6) {
                    monster = 6;
                }
                monster +  = MONST_HALL_DEATH_1;
                SixMonst(player, type, doMsgs, monster);
            }
            SET_FLAG(player, type, doMsgs, PARTY, DEATH_LEVEL, deathFlag);
        }
        protected override void FnEvent6F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            byte flag = 0;
            ushort i = 0;
            ushort monster = MONST_HALL_DEATH_7;
            if (GET_FLAG(player, type, doMsgs, PARTY, CONTROL_1) & SIGNED_IN_BIT) {
                flag = GET_FLAG(player, type, doMsgs, PARTY, CONTROL_1);
                if (((flag & KEKEKETL_KILLED_BIT) == 0)) {
                    SHOW_TEXT(player, type, doMsgs, "This antechamber is littered with bones. As you step forward some of the grisly debris flies up and forms itself into a horrific, skeletal figure. 'I am Kekeketl,' it rasps. 'I am sworn to defend this place.'");
                    flag |= KEKEKETL_KILLED_BIT;
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "You advance, and once more Kekeketl rises from the carnage. 'I have told thee, I am sworn to defend this place.'");
                }
                SET_FLAG(player, type, doMsgs, PARTY, CONTROL_1, flag);
                GET_MONSTER(player, type, doMsgs, 01, MONST_KEKEKETL);
                for (i = 2; i <= PARTY_COUNT(player, type, doMsgs) + 1; i++) {
                    GET_MONSTER(player, type, doMsgs, i, monster);
                }
            }
        }
        protected override void FnEvent70(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (((GET_FLAG(player, type, doMsgs, DUNGEON, CHOR_NPC_KILLED) & GAOLER_KILLED_BIT) == 0)) {
                if (PARTY_COUNT(player, type, doMsgs) > 1) {
                    SHOW_TEXT(player, type, doMsgs, "As you step through the door the Gaoler pushes you back roughly. 'One at a time!' he growls.");
                    TELEPORT(player, type, doMsgs, 13, 1, 249, WEST);
                }
                SHOW_TEXT(player, type, doMsgs, "As you step into the light the Gaoler flies into a rage. 'Wot's this then?' he cries. 'Oi've been tricked!'");
                GET_MONSTER(player, type, doMsgs, 01, MONST_GAOLER);
            }
            CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), EAST);
        }
        protected override void FnEvent71(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SixMonst(player, type, doMsgs, MONST_GUARDD_POST);
        }
        protected override void FnEvent72(TwPlayerServer player, MapEventType type, bool doMsgs) {
            byte secretFlag = 0byte secretFlag;byte killedFlag = 0;
            ushort monster = 0;
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), WEST);
            secretFlag = GET_FLAG(player, type, doMsgs, DUNGEON, CHOR_CONTROL_1);
            killedFlag = GET_FLAG(player, type, doMsgs, DUNGEON, CHOR_NPC_KILLED);
            if ((secretFlag & SECRET_PASSAGE_BIT) && ((killedFlag & CHORONZAR_KILLED_BIT) == 0)) {
                SHOW_TEXT(player, type, doMsgs, "You rush through the wall and surprise Choronzar pacing behind his throne!");
                if (secretFlag & ANOINTED_BIT) {
                    SHOW_TEXT(player, type, doMsgs, "He shrieks and turns to flee, but you are upon him in an instant.");
                    monster = MONST_CHORONZAR_WIMPY;
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "He smiles grimly. 'So it comes to this? % I hope you know what you're doing.'");
                    monster = MONST_CHORONZAR_TOUGH;
                }
                SET_BOOTY(player, type, doMsgs, JESTERSCAP, 0, 0, 0, 0, 0);
                GET_MONSTER(player, type, doMsgs, 1, monster);
            }
        }
        protected override void FnEvent73(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SixMonst(player, type, doMsgs, MONST_GUARDD_WANDER);
        }
        protected override void FnEvent74(TwPlayerServer player, MapEventType type, bool doMsgs) {
            byte flagBits = 0;
            flagBits = GET_FLAG(player, type, doMsgs, DUNGEON, CHOR_NPC_KILLED);
            flagBits |= SHADAX_KILLED_BIT;
            SET_FLAG(player, type, doMsgs, DUNGEON, CHOR_NPC_KILLED, flagBits);
        }
        protected override void FnEvent75(TwPlayerServer player, MapEventType type, bool doMsgs) {
            byte flag = 0;
            flag = GET_FLAG(player, type, doMsgs, DUNGEON, CHOR_NPC_KILLED);
            flag |= GAOLER_KILLED_BIT;
            SET_FLAG(player, type, doMsgs, DUNGEON, CHOR_NPC_KILLED, flag);
        }
    }
}
