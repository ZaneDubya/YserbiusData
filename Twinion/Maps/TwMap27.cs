using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    class TwMap27 : TwMap {
        public override int MapIndex => 27;
        public override int MapID => 0x0B02;
        protected override int RandomEncounterChance => 15;
        protected override int RandomEncounterExtraCount => 1;

        private const int POISON_ME = 1;
        private const int TELE = 2;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 11, 1, 57, Direction.North);
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.FTNONOFF, 0);
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNC, 0);
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNE, 0);
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTND, 0);
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNSIX, 0);
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNONE, 0);
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNTWO, 0);
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNTHREE, 0);
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNFOUR, 0);
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNFIVE, 0);
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.THORZIL, 0);
            TeleportParty(player, type, doMsgs, 11, 4, 69, Direction.West);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 11, 1, 108, Direction.West);
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 11, 2, 175, Direction.West);
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, TELE) == 0)) {
                if (GetGuild(player, type, doMsgs) == CLERIC || GetGuild(player, type, doMsgs) == THIEF || GetGuild(player, type, doMsgs) == KNIGHT) {
                    switch (GetTile(player, type, doMsgs)) {
                        case 65:
                        case 225:
                            TeleportParty(player, type, doMsgs, 11, 1, 127, Direction.West);
                            break;
                        case 247:
                            TeleportParty(player, type, doMsgs, 11, 1, 154, Direction.South);
                            break;
                    }
                }
                SetFlag(player, type, doMsgs, FlagTypeTile, TELE, 1);
            }
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, TELE) == 0)) {
                if (GetGuild(player, type, doMsgs) == RANGER || GetGuild(player, type, doMsgs) == WIZARD || GetGuild(player, type, doMsgs) == BARBARIAN) {
                    switch (GetTile(player, type, doMsgs)) {
                        case 67:
                        case 195:
                            TeleportParty(player, type, doMsgs, 11, 1, 127, Direction.West);
                            break;
                        case 204:
                            TeleportParty(player, type, doMsgs, 11, 1, 154, Direction.South);
                            break;
                    }
                }
                SetFlag(player, type, doMsgs, FlagTypeTile, TELE, 1);
            }
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The ebb tide drags you downstream.");
            TeleportParty(player, type, doMsgs, 11, 1, 244, Direction.North);
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 11, 1, 77, Direction.North);
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A huge sea bird picks you up.");
            TeleportParty(player, type, doMsgs, 11, 1, 37, Direction.East);
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 11, 2, 234, Direction.East);
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 11, 1, 204, Direction.South);
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 11, 1, 241, Direction.North);
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == WIZARD || GetGuild(player, type, doMsgs) == BARBARIAN) {
                Entmsg(player, type, doMsgs);
                TeleportParty(player, type, doMsgs, 11, 4, 181, Direction.East);
            }
            else {
                ShowText(player, type, doMsgs, "The portal to your fate lies elsewhere.");
            }
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 11, 1, 230, Direction.East);
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 11, 2, 59, Direction.East);
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The walls along this corridor seem weakened by the lava.");
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A cyclone races across the water lifting you.");
            TeleportParty(player, type, doMsgs, 11, 1, 127, Direction.West);
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The lava erupts and uproots you.");
            TeleportParty(player, type, doMsgs, 11, 1, 244, Direction.North);
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Malos senses your presence and throws you off track.");
            TeleportParty(player, type, doMsgs, 11, 1, 127, Direction.West);
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 11, 4, 187, Direction.East);
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == RANGER || GetGuild(player, type, doMsgs) == WIZARD || GetGuild(player, type, doMsgs) == BARBARIAN) {
                DisableHealing(player, type, doMsgs);
                if ((GetFlag(player, type, doMsgs, FlagTypeTile, TELE) == 0)) {
                    ShowText(player, type, doMsgs, "The hot lava sears you.");
                    DamQuarter(player, type, doMsgs);
                    SetFlag(player, type, doMsgs, FlagTypeTile, TELE, 1);
                }
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == CLERIC || GetGuild(player, type, doMsgs) == THIEF || GetGuild(player, type, doMsgs) == KNIGHT) {
                DisableHealing(player, type, doMsgs);
                if ((GetFlag(player, type, doMsgs, FlagTypeTile, TELE) == 0)) {
                    ShowText(player, type, doMsgs, "The hot lava sears you.");
                    DamQuarter(player, type, doMsgs);
                    SetFlag(player, type, doMsgs, FlagTypeTile, TELE, 1);
                }
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableHealing(player, type, doMsgs);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, TELE) == 0)) {
                ShowText(player, type, doMsgs, "The lava crust breaks under your weight and you are injured.");
                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 2);
                SetFlag(player, type, doMsgs, FlagTypeTile, TELE, 1);
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A fountain of lava engulfs you.");
            DamXit(player, type, doMsgs);
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You step into a bottomless pit and fall to your death.");
            DamXit(player, type, doMsgs);
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableHealing(player, type, doMsgs);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, TELE) == 0)) {
                ShowText(player, type, doMsgs, "You are able to kill a creature that attacks you, but you are injured.");
                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 2);
                SetFlag(player, type, doMsgs, FlagTypeTile, TELE, 1);
            }
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == RANGER || GetGuild(player, type, doMsgs) == WIZARD || GetGuild(player, type, doMsgs) == BARBARIAN) {
                DisableHealing(player, type, doMsgs);
                if ((GetFlag(player, type, doMsgs, FlagTypeTile, TELE) == 0)) {
                    ShowText(player, type, doMsgs, "A whirlpool dashes you against some rocks.");
                    DamQuarter(player, type, doMsgs);
                    SetFlag(player, type, doMsgs, FlagTypeTile, TELE, 1);
                }
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == CLERIC || GetGuild(player, type, doMsgs) == THIEF || GetGuild(player, type, doMsgs) == KNIGHT) {
                DisableHealing(player, type, doMsgs);
                if ((GetFlag(player, type, doMsgs, FlagTypeTile, TELE) == 0)) {
                    ShowText(player, type, doMsgs, "A whirlpool dashes you against some rocks.");
                    DamQuarter(player, type, doMsgs);
                    SetFlag(player, type, doMsgs, FlagTypeTile, TELE, 1);
                }
            }
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A water creature drags you to your death.");
            DamXit(player, type, doMsgs);
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            WallClear(player, type, doMsgs);
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A water creature emerges from the depths and destroys the party ahead.");
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The undertow prevents you from crossing the water.");
            WallBlock(player, type, doMsgs);
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HALFLINGCLERIC);
            ShowText(player, type, doMsgs, "I must find Thorzil!  His poison stash must be close to the way out.");
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.IFLAME) == 0)) {
                ShowPortrait(player, type, doMsgs, HUMANBARBARIAN);
                ShowText(player, type, doMsgs, "'The elemental path is ever changing. Trust not the discoveries of your brethren for yours may differ in location and occurence.'");
            }
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.FTNONOFF) == 1) {
                ShowPortrait(player, type, doMsgs, COMMONNIGHTELF);
                ShowText(player, type, doMsgs, "A warrior barges past 'The fountains must hold a secret.'");
            }
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You see runes on the wall.");
            ShowRunes(player, type, ref doMsgs, "Pluthros sees all and may deviously change the order of the switches every time you return to Ashakkar.");
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.FTNONOFF) == 1) {
                FntnPic(player, type, doMsgs);
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNC) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNE) == 1) {
                    ShowText(player, type, doMsgs, "The crystal blue waters of the fountain heal and restore you.");
                    HealFtn(player, type, doMsgs);
                }
                else {
                    ShowText(player, type, doMsgs, "Juvalad senses your presence and throws you off course.");
                    TeleportParty(player, type, doMsgs, 10, 3, 159, Direction.South);
                }
            }
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, TELE) == 0)) {
                FntnPic(player, type, doMsgs);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNSIX, 1);
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNTWO) == 1 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNTHREE) == 1 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNFOUR) == 1 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNFIVE) == 1 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTND) == 1) {
                    ShowText(player, type, doMsgs, "You find Thorzil hiding in the fountain and nab him. In order to spare his life, he offers to activate the previously disguised portal to his poison stash and promises you a sure fire method of defeating Juvalad.");
                    ShowText(player, type, doMsgs, "You secure him to the fountain and begin your search for the portal.");
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.THORZIL, 1);
                }
                else {
                    ShowText(player, type, doMsgs, "The waters have already been poisoned by Thorzil. You feel your health diminish before you can cure.");
                    DamQuarter(player, type, doMsgs);
                    SetFlag(player, type, doMsgs, FlagTypeTile, TELE, 1);
                }
            }
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTND) == 1) {
                ShowText(player, type, doMsgs, "The crystal blue waters of the fountain heal and restore you.");
                HealFtn(player, type, doMsgs);
            }
            else {
                ShowText(player, type, doMsgs, "Juvalad senses your presence and throws you off course.");
                TeleportParty(player, type, doMsgs, 10, 3, 159, Direction.South);
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeTile, POISON_ME) == 0) {
                FntnPic(player, type, doMsgs);
                ShowText(player, type, doMsgs, "Thorzil has poisoned the waters of Avalonian Fountain.  You become gravely weak.");
                OuchFtn(player, type, doMsgs);
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNSIX) == 1 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNTHREE) == 1 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNFOUR) == 1) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.FTNONOFF, 1);
                    ShowText(player, type, doMsgs, "You hear the sound of flowing water where none was before.");
                }
            }
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNTHREE, 1);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNTWO) == 1 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNSIX) == 1 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNFOUR) == 1 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNFIVE) == 1 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNE) == 1) {
                FntnPic(player, type, doMsgs);
                ShowText(player, type, doMsgs, "You find Thorzil hiding in what was a fountain and nab him. In order to spare his life, he offers to activate the previously disguised portal to his poison stash and promises you a sure fire method of defeating Juvalad.");
                ShowText(player, type, doMsgs, "You secure him to the fountain and begin your search for the portal.");
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.THORZIL, 1);
            }
            else {
                ShowText(player, type, doMsgs, "What was once a fountain is now dry.");
            }
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, TELE) == 0)) {
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.FTNONOFF) == 1) {
                    FntnPic(player, type, doMsgs);
                    ShowText(player, type, doMsgs, "The waters of Tribute Fountain have a tart taste and you become ill.");
                    DamQuarter(player, type, doMsgs);
                    SetFlag(player, type, doMsgs, FlagTypeTile, TELE, 1);
                }
            }
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.FTNONOFF, 0);
            ShowText(player, type, doMsgs, "You see the rubble of what was once a fountain.");
            ShowText(player, type, doMsgs, "Some fountains seem unnaturally quiet all of a sudden.");
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.FTNONOFF) == 1) {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNTWO, 1);
                ShowText(player, type, doMsgs, "What used to be a fountain is now a dry basin.");
            }
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The soothing waters swirl around you as you feel your health and mana increase.");
            HealFtn(player, type, doMsgs);
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetAlignment(player, type, doMsgs) == HARMONY) {
                ShowPortrait(player, type, doMsgs, STORMGIANT);
                ModifyGold(player, type, doMsgs,  - 5000);
                ShowText(player, type, doMsgs, "The guard notices your full purse and helps himself to your gold. As he fumbles with your money, you lean over and throw the switch on the wall.");
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GUARD) == 2) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TD) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TA) == 1)) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GUARD, 3);
                }
                else if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GUARD) == 1) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TB) == 1)) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GUARD, 2);
                }
                else if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GUARD) == 0) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TC) == 1)) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GUARD, 1);
                }
                else {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GUARD, 5);
                }
            }
            else {
                ShowText(player, type, doMsgs, "The vacant room was once a guard shack.");
            }
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetAlignment(player, type, doMsgs) == HARMONY) {
                ShowPortrait(player, type, doMsgs, KAALROTHLORD);
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DEMONIA) == 1) {
                    ShowText(player, type, doMsgs, "The kaalroth guard watches in amazement as your weapon glows with the colors of the rainbow.");
                    ShowText(player, type, doMsgs, "While his eyes are fixated, you lean over and throw the switch, hoping that it unlocks Celestia's cell.");
                }
                else {
                    ShowText(player, type, doMsgs, "With nothing to distract the kaalroth guard, he immediately attacks and kills you for your intrusion.");
                    DamXit(player, type, doMsgs);
                }
            }
            else {
                ShowText(player, type, doMsgs, "The guard room is now an abandoned storage area.");
            }
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HFURY) == 1) {
                if (HasItem(player, type, doMsgs, HOPESFURY)) {
                    ShowText(player, type, doMsgs, "The room shows signs of someone leaving in a hurry.");
                }
                else {
                    GiveItem(player, type, doMsgs, HOPESFURY);
                    ShowText(player, type, doMsgs, "You have thrown the correct switches to unlock the cell, but it appears that Celestia is gone.  Your eyes fall upon the medallion which she coveted.");
                }
            }
            else {
                ShowPortrait(player, type, doMsgs, TROLLCLERIC);
                if (GetAlignment(player, type, doMsgs) == HARMONY) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HFURY, 1);
                    ModifyExperience(player, type, doMsgs, 750000);
                    GiveItem(player, type, doMsgs, HOPESFURY);
                    ShowText(player, type, doMsgs, "Your cunning tactics have freed Celestia from her prison.");
                    ShowText(player, type, doMsgs, "As a reward she gives you Hope's Fury which she explains is a medallion that will help protect you in your fight against the Dralkarian Pluthros.");
                }
                else {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HFURY, 1);
                    ModifyExperience(player, type, doMsgs, 750000);
                    GiveItem(player, type, doMsgs, HOPESFURY);
                    ShowText(player, type, doMsgs, "Your treachery has lead you to Celestia's cell.  You have successfully thrown the switches to lock her in.");
                    ShowText(player, type, doMsgs, "You reach and grab the medallion from around her neck.  You now possess Hope's Fury and move on to meet the Dralkarian Pluthros.");
                }
            }
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == KNIGHT || GetGuild(player, type, doMsgs) == THIEF) {
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.IFLAME) == 1) {
                    if (HasItem(player, type, doMsgs, ICEFLAME)) {
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
            if (GetGuild(player, type, doMsgs) == CLERIC || GetGuild(player, type, doMsgs) == BARBARIAN) {
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.IFLAME) == 1) {
                    if (HasItem(player, type, doMsgs, ICEFLAME)) {
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
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SHADOWFALL) == 1) {
                if (HasItem(player, type, doMsgs, FLASKOFSHADOWFALL)) {
                    ShowText(player, type, doMsgs, "Nasty monsters still roam the empty corridor.");
                }
                else {
                    ShowText(player, type, doMsgs, "You see monsters guarding another flask and realize that Thorzil must have had more poison hidden.");
                    SetTreasure(player, type, doMsgs, FLASKOFSHADOWFALL, HEALALLPOTION, AURASCROLL, 0, 0, 5000);
                }
            }
            else {
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.THORZIL) == 1 && GetAlignment(player, type, doMsgs) == HARMONY) {
                    ShowText(player, type, doMsgs, "Thorzil leads you to where he has hidden the poison. The monsters guarding the stash immediately attack in order to prevent you from taking their keep.");
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SHADOWFALL, 1);
                    ModifyExperience(player, type, doMsgs, 750000);
                    SetTreasure(player, type, doMsgs, FLASKOFSHADOWFALL, 0, 0, 0, 0, 10000);
                }
                else if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.THORZIL) == 1 && GetAlignment(player, type, doMsgs) == CHAOS) {
                    ShowText(player, type, doMsgs, "Thorzil leads you to where he has hidden the poison. He bids you to kill the guards in order to gain the possession which will aid you in killing Juvalad.");
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SHADOWFALL, 1);
                    ModifyExperience(player, type, doMsgs, 750000);
                    SetTreasure(player, type, doMsgs, FLASKOFSHADOWFALL, 0, 0, 0, 0, 10000);
                }
                else {
                    ShowText(player, type, doMsgs, "Thorzil has moved his poison stash.");
                }
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 7);
                AddEncounter(player, type, doMsgs, 02, 8);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 12);
                AddEncounter(player, type, doMsgs, 02, 12);
                AddEncounter(player, type, doMsgs, 05, 28);
                AddEncounter(player, type, doMsgs, 06, 29);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 12);
                AddEncounter(player, type, doMsgs, 02, 12);
                AddEncounter(player, type, doMsgs, 03, 28);
                AddEncounter(player, type, doMsgs, 04, 28);
                AddEncounter(player, type, doMsgs, 05, 29);
                AddEncounter(player, type, doMsgs, 06, 29);
            }
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 40);
                AddEncounter(player, type, doMsgs, 02, 32);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 32);
                AddEncounter(player, type, doMsgs, 02, 32);
                AddEncounter(player, type, doMsgs, 05, 33);
                AddEncounter(player, type, doMsgs, 06, 34);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 32);
                AddEncounter(player, type, doMsgs, 02, 32);
                AddEncounter(player, type, doMsgs, 03, 33);
                AddEncounter(player, type, doMsgs, 04, 33);
                AddEncounter(player, type, doMsgs, 05, 34);
            }
        }
        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 29);
                AddEncounter(player, type, doMsgs, 02, 30);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 30);
                AddEncounter(player, type, doMsgs, 02, 31);
                AddEncounter(player, type, doMsgs, 03, 8);
                AddEncounter(player, type, doMsgs, 04, 8);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 30);
                AddEncounter(player, type, doMsgs, 02, 30);
                AddEncounter(player, type, doMsgs, 03, 31);
                AddEncounter(player, type, doMsgs, 04, 31);
                AddEncounter(player, type, doMsgs, 05, 9);
                AddEncounter(player, type, doMsgs, 06, 9);
            }
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetAlignment(player, type, doMsgs) == CHAOS) {
                ShowText(player, type, doMsgs, "You are ambushed by the guards protecting the lock switch on the wall.  You must successfully destroy them in order to throw the switch.");
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HELLBATTLE) == 1) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TC) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TA) == 1)) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HELLBATTLE, 2);
                }
                else if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HELLBATTLE) == 0) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TD) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TB) == 1)) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HELLBATTLE, 1);
                }
                else {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HELLBATTLE, 5);
                }
            }
            else {
                ShowText(player, type, doMsgs, "You have no chance to get near the switch in the guardhouse.");
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 02, 6);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 3);
                AddEncounter(player, type, doMsgs, 02, 3);
                AddEncounter(player, type, doMsgs, 06, 2);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 02, 1);
                AddEncounter(player, type, doMsgs, 05, 2);
                AddEncounter(player, type, doMsgs, 06, 2);
            }
        }
        protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1 || GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 25);
                AddEncounter(player, type, doMsgs, 02, 25);
                AddEncounter(player, type, doMsgs, 05, 26);
                AddEncounter(player, type, doMsgs, 06, 27);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 26);
                AddEncounter(player, type, doMsgs, 02, 26);
                AddEncounter(player, type, doMsgs, 03, 27);
                AddEncounter(player, type, doMsgs, 04, 27);
            }
        }
        protected override void FnEvent3B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetAlignment(player, type, doMsgs) == CHAOS) {
                ShowText(player, type, doMsgs, "You are ambushed by the guards protecting the lock switch on the wall. You must successfully destroy them in order to throw the switch.");
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HELLBATTLE) == 2) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TD) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TA) == 1)) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HELLBATTLE, 3);
                }
                else if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HELLBATTLE) == 1) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TB) == 1)) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HELLBATTLE, 2);
                }
                else if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HELLBATTLE) == 0) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TC) == 1)) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HELLBATTLE, 1);
                }
                else {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HELLBATTLE, 5);
                }
            }
            else {
                ShowText(player, type, doMsgs, "You have no chance to get near the switch in the guardhouse.");
            }
            if (GetPartyCount(player, type, doMsgs) == 1 || GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 5);
                AddEncounter(player, type, doMsgs, 02, 6);
                AddEncounter(player, type, doMsgs, 05, 7);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 6);
                AddEncounter(player, type, doMsgs, 02, 6);
                AddEncounter(player, type, doMsgs, 03, 7);
                AddEncounter(player, type, doMsgs, 04, 7);
            }
        }
        protected override void FnEvent3C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1 || GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 16);
                AddEncounter(player, type, doMsgs, 02, 16);
                AddEncounter(player, type, doMsgs, 05, 17);
                AddEncounter(player, type, doMsgs, 06, 17);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 17);
                AddEncounter(player, type, doMsgs, 02, 17);
                AddEncounter(player, type, doMsgs, 05, 17);
                AddEncounter(player, type, doMsgs, 06, 17);
            }
        }
        protected override void FnEvent3D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, type, doMsgs, 01, 23);
            AddEncounter(player, type, doMsgs, 02, 24);
            AddEncounter(player, type, doMsgs, 03, 35);
            AddEncounter(player, type, doMsgs, 04, 35);
            AddEncounter(player, type, doMsgs, 05, 36);
            AddEncounter(player, type, doMsgs, 06, 36);
        }
        protected override void FnEvent3E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 21);
                AddEncounter(player, type, doMsgs, 02, 35);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 35);
                AddEncounter(player, type, doMsgs, 02, 35);
                AddEncounter(player, type, doMsgs, 05, 37);
                AddEncounter(player, type, doMsgs, 06, 35);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 37);
                AddEncounter(player, type, doMsgs, 02, 37);
                AddEncounter(player, type, doMsgs, 04, 20);
                AddEncounter(player, type, doMsgs, 05, 36);
                AddEncounter(player, type, doMsgs, 06, 36);
            }
        }
        protected override void FnEvent3F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1 || GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 35);
                AddEncounter(player, type, doMsgs, 02, 37);
                AddEncounter(player, type, doMsgs, 05, 17);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 36);
                AddEncounter(player, type, doMsgs, 02, 36);
                AddEncounter(player, type, doMsgs, 03, 18);
                AddEncounter(player, type, doMsgs, 04, 18);
                AddEncounter(player, type, doMsgs, 05, 37);
            }
        }
        protected override void FnEvent40(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1 || GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 5);
                AddEncounter(player, type, doMsgs, 02, 7);
                AddEncounter(player, type, doMsgs, 04, 35);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 6);
                AddEncounter(player, type, doMsgs, 02, 6);
                AddEncounter(player, type, doMsgs, 03, 7);
                AddEncounter(player, type, doMsgs, 04, 7);
                AddEncounter(player, type, doMsgs, 05, 36);
            }
        }
        protected override void FnEvent41(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                ShowText(player, type, doMsgs, "You may continue your quest.");
            }
            else {
                TeleportParty(player, type, doMsgs, 11, 1, 57, Direction.North);
            }
        }
        protected override void FnEvent42(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 11, 1, 244, Direction.North);
        }
        protected override void FnEvent43(TwPlayerServer player, MapEventType type, bool doMsgs) {
            Entmsg(player, type, doMsgs);
        }
        protected override void FnEvent44(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                WallClear(player, type, doMsgs);
            }
            else {
                ShowText(player, type, doMsgs, "Proceed single file to sneak past Juvalad's gate guards.");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent45(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.THORZIL) == 1) {
                ShowText(player, type, doMsgs, "Proceed south to meet your fate.");
            }
            else {
                TeleportParty(player, type, doMsgs, 11, 1, 241, Direction.North);
            }
        }
        protected override void FnEvent46(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNONE) == 1) {
                ShowPortrait(player, type, doMsgs, HUMANBARBARIAN);
                ShowText(player, type, doMsgs, "Thorzil appears before you.");
                ShowText(player, type, doMsgs, "'You have done well so far weaklings! But I shall finish my work without your interference!'");
                ShowText(player, type, doMsgs, "Thorzil manages to get away, but not without leaving his mark.");
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HEAVENFTNONE, 2);
                DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 10);
            }
        }
        private void Entmsg(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Enter to meet your Fate!");
        }
        private void DamXit(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
        }
        private void FntnPic(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
        }
        private void WallClear(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void DamQuarter(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 4);
            DisableHealing(player, type, doMsgs);
        }
        private void HealFtn(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ModifyHealth(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
            ModifyMana(player, type, doMsgs, 10000);
        }
        private void OuchFtn(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetDebuff(player, type, doMsgs, POISON, 8, GetHealthMax(player, type, doMsgs) / 10);
            SetFlag(player, type, doMsgs, FlagTypeTile, POISON_ME, 1);
        }
        private void WeaponFind(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.IFLAME, 1);
            ModifyExperience(player, type, doMsgs, 750000);
            GiveItem(player, type, doMsgs, ICEFLAME);
            ShowText(player, type, doMsgs, "You see the sparkle of a weapon embedded in the crusted lava. It surprises you how easily the weapon comes free and you recall a rumor about a special weapon that might aid you in defeating Malos.");
        }
        private void NoWeapon(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You find nothing unusual in the alcove.");
        }
        private void MalosWeapon(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Malos has again attempted to hide the Ice Flame.");
            GiveItem(player, type, doMsgs, ICEFLAME);
        }
        protected override void FnEvent47(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HELLBATTLE) == 5 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GUARD) == 5) {
                ShowText(player, type, doMsgs, "As you turn to leave your hear the hideous laughter of Pluthros.");
                ShowText(player, type, doMsgs, "'Fools! You will never complete your task! I have again foiled your attempt at the correct switches!'");
            }
        }
    }
}
