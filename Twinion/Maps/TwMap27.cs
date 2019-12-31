using XPT.Generic.Maps;
using XPT.Twinion.Entities;

namespace XPT.Twinion.Maps {
    class TwMap27 : TwMap {
        protected override int MapIndex => 27;
        protected override int MapID => 0x0B02;
        protected override int RandomEncounterChance => 15;
        protected override int RandomEncounterExtraCount => 1;

        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 11, 1, 57, NORTH);
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_FLAG(player, type, doMsgs, DUNGEON, FTNONOFF, 0);
            SET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNC, 0);
            SET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNE, 0);
            SET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTND, 0);
            SET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNSIX, 0);
            SET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNONE, 0);
            SET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNTWO, 0);
            SET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNTHREE, 0);
            SET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNFOUR, 0);
            SET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNFIVE, 0);
            SET_FLAG(player, type, doMsgs, DUNGEON, THORZIL, 0);
            TELEPORT(player, type, doMsgs, 11, 4, 69, WEST);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 11, 1, 108, WEST);
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 11, 2, 175, WEST);
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, ROOM, TELE)) {
                if (GUILD(player, type, doMsgs) == CLERIC || GUILD(player, type, doMsgs) == THIEF || GUILD(player, type, doMsgs) == KNIGHT) {
                    switch (HERE(player, type, doMsgs)) {
                        case 65:
                        case 225:
                            TELEPORT(player, type, doMsgs, 11, 1, 127, WEST);
                            break;
                        case 247:
                            TELEPORT(player, type, doMsgs, 11, 1, 154, SOUTH);
                            break;
                    }
                }
                SET_FLAG(player, type, doMsgs, ROOM, TELE, 1);
            }
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, ROOM, TELE)) {
                if (GUILD(player, type, doMsgs) == RANGER || GUILD(player, type, doMsgs) == WIZARD || GUILD(player, type, doMsgs) == BARBARIAN) {
                    switch (HERE(player, type, doMsgs)) {
                        case 67:
                        case 195:
                            TELEPORT(player, type, doMsgs, 11, 1, 127, WEST);
                            break;
                        case 204:
                            TELEPORT(player, type, doMsgs, 11, 1, 154, SOUTH);
                            break;
                    }
                }
                SET_FLAG(player, type, doMsgs, ROOM, TELE, 1);
            }
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The ebb tide drags you downstream.");
            TELEPORT(player, type, doMsgs, 11, 1, 244, NORTH);
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 11, 1, 77, NORTH);
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A huge sea bird picks you up.");
            TELEPORT(player, type, doMsgs, 11, 1, 37, EAST);
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 11, 2, 234, EAST);
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 11, 1, 204, SOUTH);
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 11, 1, 241, NORTH);
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD(player, type, doMsgs) == WIZARD || GUILD(player, type, doMsgs) == BARBARIAN) {
                Entmsg(player, type, doMsgs);
                TELEPORT(player, type, doMsgs, 11, 4, 181, EAST);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The portal to your fate lies elsewhere.");
            }
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 11, 1, 230, EAST);
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 11, 2, 59, EAST);
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The walls along this corridor seem weakened by the lava.");
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A cyclone races across the water lifting you.");
            TELEPORT(player, type, doMsgs, 11, 1, 127, WEST);
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The lava erupts and uproots you.");
            TELEPORT(player, type, doMsgs, 11, 1, 244, NORTH);
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Malos senses your presence and throws you off track.");
            TELEPORT(player, type, doMsgs, 11, 1, 127, WEST);
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 11, 4, 187, EAST);
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD(player, type, doMsgs) == RANGER || GUILD(player, type, doMsgs) == WIZARD || GUILD(player, type, doMsgs) == BARBARIAN) {
                NO_HEAL_ZONE(player, type, doMsgs);
                if (!GET_FLAG(player, type, doMsgs, ROOM, TELE)) {
                    SHOW_TEXT(player, type, doMsgs, "The hot lava sears you.");
                    DamQuarter(player, type, doMsgs);
                    SET_FLAG(player, type, doMsgs, ROOM, TELE, 1);
                }
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD(player, type, doMsgs) == CLERIC || GUILD(player, type, doMsgs) == THIEF || GUILD(player, type, doMsgs) == KNIGHT) {
                NO_HEAL_ZONE(player, type, doMsgs);
                if (!GET_FLAG(player, type, doMsgs, ROOM, TELE)) {
                    SHOW_TEXT(player, type, doMsgs, "The hot lava sears you.");
                    DamQuarter(player, type, doMsgs);
                    SET_FLAG(player, type, doMsgs, ROOM, TELE, 1);
                }
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_HEAL_ZONE(player, type, doMsgs);
            if (!GET_FLAG(player, type, doMsgs, ROOM, TELE)) {
                SHOW_TEXT(player, type, doMsgs, "The lava crust breaks under your weight and you are injured.");
                DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 2);
                SET_FLAG(player, type, doMsgs, ROOM, TELE, 1);
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A fountain of lava engulfs you.");
            DamXit(player, type, doMsgs);
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You step into a bottomless pit and fall to your death.");
            DamXit(player, type, doMsgs);
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_HEAL_ZONE(player, type, doMsgs);
            if (!GET_FLAG(player, type, doMsgs, ROOM, TELE)) {
                SHOW_TEXT(player, type, doMsgs, "You are able to kill a creature that attacks you, but you are injured.");
                DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 2);
                SET_FLAG(player, type, doMsgs, ROOM, TELE, 1);
            }
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD(player, type, doMsgs) == RANGER || GUILD(player, type, doMsgs) == WIZARD || GUILD(player, type, doMsgs) == BARBARIAN) {
                NO_HEAL_ZONE(player, type, doMsgs);
                if (!GET_FLAG(player, type, doMsgs, ROOM, TELE)) {
                    SHOW_TEXT(player, type, doMsgs, "A whirlpool dashes you against some rocks.");
                    DamQuarter(player, type, doMsgs);
                    SET_FLAG(player, type, doMsgs, ROOM, TELE, 1);
                }
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD(player, type, doMsgs) == CLERIC || GUILD(player, type, doMsgs) == THIEF || GUILD(player, type, doMsgs) == KNIGHT) {
                NO_HEAL_ZONE(player, type, doMsgs);
                if (!GET_FLAG(player, type, doMsgs, ROOM, TELE)) {
                    SHOW_TEXT(player, type, doMsgs, "A whirlpool dashes you against some rocks.");
                    DamQuarter(player, type, doMsgs);
                    SET_FLAG(player, type, doMsgs, ROOM, TELE, 1);
                }
            }
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A water creature drags you to your death.");
            DamXit(player, type, doMsgs);
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            WallClear(player, type, doMsgs);
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A water creature emerges from the depths and destroys the party ahead.");
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The undertow prevents you from crossing the water.");
            WallBlock(player, type, doMsgs);
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, HALFLINGCLERIC);
            SHOW_TEXT(player, type, doMsgs, "I must find Thorzil!  His poison stash must be close to the way out.");
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, DUNGEON, IFLAME)) {
                SHOW_PICTURE(player, type, doMsgs, HUMANBARBARIAN);
                SHOW_TEXT(player, type, doMsgs, "'The elemental path is ever changing. Trust not the discoveries of your brethren for yours may differ in location and occurence.'");
            }
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, FTNONOFF) == 1) {
                SHOW_PICTURE(player, type, doMsgs, COMMONNIGHTELF);
                SHOW_TEXT(player, type, doMsgs, "A warrior barges past 'The fountains must hold a secret.'");
            }
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You see runes on the wall.");
            SHOW_RUNES(player, type, doMsgs, "Pluthros sees all and may deviously change the order of the switches every time you return to Ashakkar.");
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, FTNONOFF) == 1) {
                FntnPic(player, type, doMsgs);
                if (GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNC) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNE) == 1) {
                    SHOW_TEXT(player, type, doMsgs, "The crystal blue waters of the fountain heal and restore you.");
                    HealFtn(player, type, doMsgs);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "Juvalad senses your presence and throws you off course.");
                    TELEPORT(player, type, doMsgs, 10, 3, 159, SOUTH);
                }
            }
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, ROOM, TELE)) {
                FntnPic(player, type, doMsgs);
                SET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNSIX, 1);
                if (GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNTWO) == 1 && GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNTHREE) == 1 && GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNFOUR) == 1 && GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNFIVE) == 1 && GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTND) == 1) {
                    SHOW_TEXT(player, type, doMsgs, "You find Thorzil hiding in the fountain and nab him. In order to spare his life, he offers to activate the previously disguised portal to his poison stash and promises you a sure fire method of defeating Juvalad.");
                    SHOW_TEXT(player, type, doMsgs, "You secure him to the fountain and begin your search for the portal.");
                    SET_FLAG(player, type, doMsgs, DUNGEON, THORZIL, 1);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "The waters have already been poisoned by Thorzil. You feel your health diminish before you can cure.");
                    DamQuarter(player, type, doMsgs);
                    SET_FLAG(player, type, doMsgs, ROOM, TELE, 1);
                }
            }
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTND) == 1) {
                SHOW_TEXT(player, type, doMsgs, "The crystal blue waters of the fountain heal and restore you.");
                HealFtn(player, type, doMsgs);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Juvalad senses your presence and throws you off course.");
                TELEPORT(player, type, doMsgs, 10, 3, 159, SOUTH);
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, ROOM, POISON_ME) == 0) {
                FntnPic(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "Thorzil has poisoned the waters of Avalonian Fountain.  You become gravely weak.");
                OuchFtn(player, type, doMsgs);
                if (GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNSIX) == 1 && GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNTHREE) == 1 && GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNFOUR) == 1) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, FTNONOFF, 1);
                    SHOW_TEXT(player, type, doMsgs, "You hear the sound of flowing water where none was before.");
                }
            }
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNTHREE, 1);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNTWO) == 1 && GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNSIX) == 1 && GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNFOUR) == 1 && GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNFIVE) == 1 && GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNE) == 1) {
                FntnPic(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "You find Thorzil hiding in what was a fountain and nab him. In order to spare his life, he offers to activate the previously disguised portal to his poison stash and promises you a sure fire method of defeating Juvalad.");
                SHOW_TEXT(player, type, doMsgs, "You secure him to the fountain and begin your search for the portal.");
                SET_FLAG(player, type, doMsgs, DUNGEON, THORZIL, 1);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "What was once a fountain is now dry.");
            }
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, ROOM, TELE)) {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, FTNONOFF) == 1) {
                    FntnPic(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "The waters of Tribute Fountain have a tart taste and you become ill.");
                    DamQuarter(player, type, doMsgs);
                    SET_FLAG(player, type, doMsgs, ROOM, TELE, 1);
                }
            }
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_FLAG(player, type, doMsgs, DUNGEON, FTNONOFF, 0);
            SHOW_TEXT(player, type, doMsgs, "You see the rubble of what was once a fountain.");
            SHOW_TEXT(player, type, doMsgs, "Some fountains seem unnaturally quiet all of a sudden.");
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, FTNONOFF) == 1) {
                SET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNTWO, 1);
                SHOW_TEXT(player, type, doMsgs, "What used to be a fountain is now a dry basin.");
            }
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The soothing waters swirl around you as you feel your health and mana increase.");
            HealFtn(player, type, doMsgs);
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (ALIGN(player, type, doMsgs) == HARMONY) {
                SHOW_PICTURE(player, type, doMsgs, STORMGIANT);
                MOD_GOLD(player, type, doMsgs,  - 5000);
                SHOW_TEXT(player, type, doMsgs, "The guard notices your full purse and helps himself to your gold. As he fumbles with your money, you lean over and throw the switch on the wall.");
                if ((GET_FLAG(player, type, doMsgs, DUNGEON, GUARD) == 2) && (GET_FLAG(player, type, doMsgs, DUNGEON, TD) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, TA) == 1)) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, GUARD, 3);
                }
                else if ((GET_FLAG(player, type, doMsgs, DUNGEON, GUARD) == 1) && (GET_FLAG(player, type, doMsgs, DUNGEON, TB) == 1)) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, GUARD, 2);
                }
                else if ((GET_FLAG(player, type, doMsgs, DUNGEON, GUARD) == 0) && (GET_FLAG(player, type, doMsgs, DUNGEON, TC) == 1)) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, GUARD, 1);
                }
                else {
                    SET_FLAG(player, type, doMsgs, DUNGEON, GUARD, 5);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The vacant room was once a guard shack.");
            }
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (ALIGN(player, type, doMsgs) == HARMONY) {
                SHOW_PICTURE(player, type, doMsgs, KAALROTHLORD);
                if (GET_FLAG(player, type, doMsgs, DUNGEON, DEMONIA) == 1) {
                    SHOW_TEXT(player, type, doMsgs, "The kaalroth guard watches in amazement as your weapon glows with the colors of the rainbow.");
                    SHOW_TEXT(player, type, doMsgs, "While his eyes are fixated, you lean over and throw the switch, hoping that it unlocks Celestia's cell.");
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "With nothing to distract the kaalroth guard, he immediately attacks and kills you for your intrusion.");
                    DamXit(player, type, doMsgs);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The guard room is now an abandoned storage area.");
            }
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, HFURY) == 1) {
                if (HAS_ITEM(player, type, doMsgs, HOPESFURY)) {
                    SHOW_TEXT(player, type, doMsgs, "The room shows signs of someone leaving in a hurry.");
                }
                else {
                    GIVE_ITEM(player, type, doMsgs, HOPESFURY);
                    SHOW_TEXT(player, type, doMsgs, "You have thrown the correct switches to unlock the cell, but it appears that Celestia is gone.  Your eyes fall upon the medallion which she coveted.");
                }
            }
            else {
                SHOW_PICTURE(player, type, doMsgs, TROLLCLERIC);
                if (ALIGN(player, type, doMsgs) == HARMONY) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, HFURY, 1);
                    MOD_EXP(player, type, doMsgs, 750000);
                    GIVE_ITEM(player, type, doMsgs, HOPESFURY);
                    SHOW_TEXT(player, type, doMsgs, "Your cunning tactics have freed Celestia from her prison.");
                    SHOW_TEXT(player, type, doMsgs, "As a reward she gives you Hope's Fury which she explains is a medallion that will help protect you in your fight against the Dralkarian Pluthros.");
                }
                else {
                    SET_FLAG(player, type, doMsgs, DUNGEON, HFURY, 1);
                    MOD_EXP(player, type, doMsgs, 750000);
                    GIVE_ITEM(player, type, doMsgs, HOPESFURY);
                    SHOW_TEXT(player, type, doMsgs, "Your treachery has lead you to Celestia's cell.  You have successfully thrown the switches to lock her in.");
                    SHOW_TEXT(player, type, doMsgs, "You reach and grab the medallion from around her neck.  You now possess Hope's Fury and move on to meet the Dralkarian Pluthros.");
                }
            }
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD(player, type, doMsgs) == KNIGHT || GUILD(player, type, doMsgs) == THIEF) {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, IFLAME) == 1) {
                    if (HAS_ITEM(player, type, doMsgs, ICEFLAME)) {
                        NoWeapon(player, type, doMsgs);
                    }
                    else {
                        MalosWeapon(player, type, doMsgs);
                    }
                }
                else {
                    WeaponFind(player, type, doMsgs);
                }
            }
            else {
                NoWeapon(player, type, doMsgs);
            }
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD(player, type, doMsgs) == CLERIC || GUILD(player, type, doMsgs) == BARBARIAN) {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, IFLAME) == 1) {
                    if (HAS_ITEM(player, type, doMsgs, ICEFLAME)) {
                        NoWeapon(player, type, doMsgs);
                    }
                    else {
                        MalosWeapon(player, type, doMsgs);
                    }
                }
                else {
                    WeaponFind(player, type, doMsgs);
                }
            }
            else {
                NoWeapon(player, type, doMsgs);
            }
        }
        protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, SHADOWFALL) == 1) {
                if (HAS_ITEM(player, type, doMsgs, FLASKOFSHADOWFALL)) {
                    SHOW_TEXT(player, type, doMsgs, "Nasty monsters still roam the empty corridor.");
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "You see monsters guarding another flask and realize that Thorzil must have had more poison hidden.");
                    SET_BOOTY(player, type, doMsgs, FLASKOFSHADOWFALL, HEALALLPOTION, AURASCROLL, 0, 0, 5000);
                }
            }
            else {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, THORZIL) == 1 && ALIGN(player, type, doMsgs) == HARMONY) {
                    SHOW_TEXT(player, type, doMsgs, "Thorzil leads you to where he has hidden the poison. The monsters guarding the stash immediately attack in order to prevent you from taking their keep.");
                    SET_FLAG(player, type, doMsgs, DUNGEON, SHADOWFALL, 1);
                    MOD_EXP(player, type, doMsgs, 750000);
                    SET_BOOTY(player, type, doMsgs, FLASKOFSHADOWFALL, 0, 0, 0, 0, 10000);
                }
                else if (GET_FLAG(player, type, doMsgs, DUNGEON, THORZIL) == 1 && ALIGN(player, type, doMsgs) == CHAOS) {
                    SHOW_TEXT(player, type, doMsgs, "Thorzil leads you to where he has hidden the poison. He bids you to kill the guards in order to gain the possession which will aid you in killing Juvalad.");
                    SET_FLAG(player, type, doMsgs, DUNGEON, SHADOWFALL, 1);
                    MOD_EXP(player, type, doMsgs, 750000);
                    SET_BOOTY(player, type, doMsgs, FLASKOFSHADOWFALL, 0, 0, 0, 0, 10000);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "Thorzil has moved his poison stash.");
                }
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 7);
                GET_MONSTER(player, type, doMsgs, 02, 8);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 12);
                GET_MONSTER(player, type, doMsgs, 02, 12);
                GET_MONSTER(player, type, doMsgs, 05, 28);
                GET_MONSTER(player, type, doMsgs, 06, 29);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 12);
                GET_MONSTER(player, type, doMsgs, 02, 12);
                GET_MONSTER(player, type, doMsgs, 03, 28);
                GET_MONSTER(player, type, doMsgs, 04, 28);
                GET_MONSTER(player, type, doMsgs, 05, 29);
                GET_MONSTER(player, type, doMsgs, 06, 29);
            }
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 40);
                GET_MONSTER(player, type, doMsgs, 02, 32);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 32);
                GET_MONSTER(player, type, doMsgs, 02, 32);
                GET_MONSTER(player, type, doMsgs, 05, 33);
                GET_MONSTER(player, type, doMsgs, 06, 34);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 32);
                GET_MONSTER(player, type, doMsgs, 02, 32);
                GET_MONSTER(player, type, doMsgs, 03, 33);
                GET_MONSTER(player, type, doMsgs, 04, 33);
                GET_MONSTER(player, type, doMsgs, 05, 34);
            }
        }
        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 29);
                GET_MONSTER(player, type, doMsgs, 02, 30);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 30);
                GET_MONSTER(player, type, doMsgs, 02, 31);
                GET_MONSTER(player, type, doMsgs, 03, 8);
                GET_MONSTER(player, type, doMsgs, 04, 8);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 30);
                GET_MONSTER(player, type, doMsgs, 02, 30);
                GET_MONSTER(player, type, doMsgs, 03, 31);
                GET_MONSTER(player, type, doMsgs, 04, 31);
                GET_MONSTER(player, type, doMsgs, 05, 9);
                GET_MONSTER(player, type, doMsgs, 06, 9);
            }
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (ALIGN(player, type, doMsgs) == CHAOS) {
                SHOW_TEXT(player, type, doMsgs, "You are ambushed by the guards protecting the lock switch on the wall.  You must successfully destroy them in order to throw the switch.");
                if ((GET_FLAG(player, type, doMsgs, DUNGEON, HELLBATTLE) == 1) && (GET_FLAG(player, type, doMsgs, DUNGEON, TC) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, TA) == 1)) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, HELLBATTLE, 2);
                }
                else if ((GET_FLAG(player, type, doMsgs, DUNGEON, HELLBATTLE) == 0) && (GET_FLAG(player, type, doMsgs, DUNGEON, TD) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, TB) == 1)) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, HELLBATTLE, 1);
                }
                else {
                    SET_FLAG(player, type, doMsgs, DUNGEON, HELLBATTLE, 5);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "You have no chance to get near the switch in the guardhouse.");
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 1);
                GET_MONSTER(player, type, doMsgs, 02, 6);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 3);
                GET_MONSTER(player, type, doMsgs, 02, 3);
                GET_MONSTER(player, type, doMsgs, 06, 2);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 1);
                GET_MONSTER(player, type, doMsgs, 02, 1);
                GET_MONSTER(player, type, doMsgs, 05, 2);
                GET_MONSTER(player, type, doMsgs, 06, 2);
            }
        }
        protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1 || PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 25);
                GET_MONSTER(player, type, doMsgs, 02, 25);
                GET_MONSTER(player, type, doMsgs, 05, 26);
                GET_MONSTER(player, type, doMsgs, 06, 27);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 26);
                GET_MONSTER(player, type, doMsgs, 02, 26);
                GET_MONSTER(player, type, doMsgs, 03, 27);
                GET_MONSTER(player, type, doMsgs, 04, 27);
            }
        }
        protected override void FnEvent3B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (ALIGN(player, type, doMsgs) == CHAOS) {
                SHOW_TEXT(player, type, doMsgs, "You are ambushed by the guards protecting the lock switch on the wall. You must successfully destroy them in order to throw the switch.");
                if ((GET_FLAG(player, type, doMsgs, DUNGEON, HELLBATTLE) == 2) && (GET_FLAG(player, type, doMsgs, DUNGEON, TD) == 1 || GET_FLAG(player, type, doMsgs, DUNGEON, TA) == 1)) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, HELLBATTLE, 3);
                }
                else if ((GET_FLAG(player, type, doMsgs, DUNGEON, HELLBATTLE) == 1) && (GET_FLAG(player, type, doMsgs, DUNGEON, TB) == 1)) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, HELLBATTLE, 2);
                }
                else if ((GET_FLAG(player, type, doMsgs, DUNGEON, HELLBATTLE) == 0) && (GET_FLAG(player, type, doMsgs, DUNGEON, TC) == 1)) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, HELLBATTLE, 1);
                }
                else {
                    SET_FLAG(player, type, doMsgs, DUNGEON, HELLBATTLE, 5);
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "You have no chance to get near the switch in the guardhouse.");
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1 || PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 5);
                GET_MONSTER(player, type, doMsgs, 02, 6);
                GET_MONSTER(player, type, doMsgs, 05, 7);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 6);
                GET_MONSTER(player, type, doMsgs, 02, 6);
                GET_MONSTER(player, type, doMsgs, 03, 7);
                GET_MONSTER(player, type, doMsgs, 04, 7);
            }
        }
        protected override void FnEvent3C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1 || PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 16);
                GET_MONSTER(player, type, doMsgs, 02, 16);
                GET_MONSTER(player, type, doMsgs, 05, 17);
                GET_MONSTER(player, type, doMsgs, 06, 17);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 17);
                GET_MONSTER(player, type, doMsgs, 02, 17);
                GET_MONSTER(player, type, doMsgs, 05, 17);
                GET_MONSTER(player, type, doMsgs, 06, 17);
            }
        }
        protected override void FnEvent3D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            GET_MONSTER(player, type, doMsgs, 01, 23);
            GET_MONSTER(player, type, doMsgs, 02, 24);
            GET_MONSTER(player, type, doMsgs, 03, 35);
            GET_MONSTER(player, type, doMsgs, 04, 35);
            GET_MONSTER(player, type, doMsgs, 05, 36);
            GET_MONSTER(player, type, doMsgs, 06, 36);
        }
        protected override void FnEvent3E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 21);
                GET_MONSTER(player, type, doMsgs, 02, 35);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 35);
                GET_MONSTER(player, type, doMsgs, 02, 35);
                GET_MONSTER(player, type, doMsgs, 05, 37);
                GET_MONSTER(player, type, doMsgs, 06, 35);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 37);
                GET_MONSTER(player, type, doMsgs, 02, 37);
                GET_MONSTER(player, type, doMsgs, 04, 20);
                GET_MONSTER(player, type, doMsgs, 05, 36);
                GET_MONSTER(player, type, doMsgs, 06, 36);
            }
        }
        protected override void FnEvent3F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1 || PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 35);
                GET_MONSTER(player, type, doMsgs, 02, 37);
                GET_MONSTER(player, type, doMsgs, 05, 17);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 36);
                GET_MONSTER(player, type, doMsgs, 02, 36);
                GET_MONSTER(player, type, doMsgs, 03, 18);
                GET_MONSTER(player, type, doMsgs, 04, 18);
                GET_MONSTER(player, type, doMsgs, 05, 37);
            }
        }
        protected override void FnEvent40(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1 || PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 5);
                GET_MONSTER(player, type, doMsgs, 02, 7);
                GET_MONSTER(player, type, doMsgs, 04, 35);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 6);
                GET_MONSTER(player, type, doMsgs, 02, 6);
                GET_MONSTER(player, type, doMsgs, 03, 7);
                GET_MONSTER(player, type, doMsgs, 04, 7);
                GET_MONSTER(player, type, doMsgs, 05, 36);
            }
        }
        protected override void FnEvent41(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                SHOW_TEXT(player, type, doMsgs, "You may continue your quest.");
            }
            else {
                TELEPORT(player, type, doMsgs, 11, 1, 57, NORTH);
            }
        }
        protected override void FnEvent42(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 11, 1, 244, NORTH);
        }
        protected override void FnEvent43(TwPlayerServer player, MapEventType type, bool doMsgs) {
            Entmsg(player, type, doMsgs);
        }
        protected override void FnEvent44(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                WallClear(player, type, doMsgs);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Proceed single file to sneak past Juvalad's gate guards.");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent45(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1 && GET_FLAG(player, type, doMsgs, DUNGEON, THORZIL) == 1) {
                SHOW_TEXT(player, type, doMsgs, "Proceed south to meet your fate.");
            }
            else {
                TELEPORT(player, type, doMsgs, 11, 1, 241, NORTH);
            }
        }
        protected override void FnEvent46(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNONE) == 1) {
                SHOW_PICTURE(player, type, doMsgs, HUMANBARBARIAN);
                SHOW_TEXT(player, type, doMsgs, "Thorzil appears before you.");
                SHOW_TEXT(player, type, doMsgs, "'You have done well so far weaklings! But I shall finish my work without your interference!'");
                SHOW_TEXT(player, type, doMsgs, "Thorzil manages to get away, but not without leaving his mark.");
                SET_FLAG(player, type, doMsgs, DUNGEON, HEAVENFTNONE, 2);
                DAMAGE(player, type, doMsgs, HEALTH(player, type, doMsgs) / 10);
            }
        }
        private void Entmsg(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Enter to meet your Fate!");
        }
        private void DamXit(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
        }
        private void FntnPic(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
        }
        private void WallClear(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        private void DamQuarter(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 4);
            NO_HEAL_ZONE(player, type, doMsgs);
        }
        private void HealFtn(TwPlayerServer player, MapEventType type, bool doMsgs) {
            HEAL(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
            MOD_MANA(player, type, doMsgs, 10000);
        }
        private void OuchFtn(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_PM(player, type, doMsgs, POISON, 8, MAX_HEALTH(player, type, doMsgs) / 10);
            SET_FLAG(player, type, doMsgs, ROOM, POISON_ME, 1);
        }
        private void WeaponFind(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_FLAG(player, type, doMsgs, DUNGEON, IFLAME, 1);
            MOD_EXP(player, type, doMsgs, 750000);
            GIVE_ITEM(player, type, doMsgs, ICEFLAME);
            SHOW_TEXT(player, type, doMsgs, "You see the sparkle of a weapon embedded in the crusted lava. It surprises you how easily the weapon comes free and you recall a rumor about a special weapon that might aid you in defeating Malos.");
        }
        private void NoWeapon(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You find nothing unusual in the alcove.");
        }
        private void MalosWeapon(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Malos has again attempted to hide the Ice Flame.");
            GIVE_ITEM(player, type, doMsgs, ICEFLAME);
        }
        protected override void FnEvent47(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, HELLBATTLE) == 5 || GET_FLAG(player, type, doMsgs, DUNGEON, GUARD) == 5) {
                SHOW_TEXT(player, type, doMsgs, "As you turn to leave your hear the hideous laughter of Pluthros.");
                SHOW_TEXT(player, type, doMsgs, "'Fools! You will never complete your task! I have again foiled your attempt at the correct switches!'");
            }
        }
    }
}
