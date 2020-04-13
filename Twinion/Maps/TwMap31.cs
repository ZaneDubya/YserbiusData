using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    class TwMap31 : TwMap {
        public override int MapIndex => 31;
        public override int MapID => 0x0C02;
        protected override int RandomEncounterChance => 0;
        protected override int RandomEncounterExtraCount => 0;

        private const int CASETRAP2 = 1;
        private const int FIGHT_ME = 2;
        private const int IMHERE = 3;
        private const int KEEPER = 4;
        private const int LASTBATTLE = 5;
        private const int USEDNEPTRI = 6;
        private const int USEDGAEAFLAIL = 7;
        private const int IHAVETHEFLAIL = 8;
        private const int SPRUNGTRAP = 1;
        private const int STORMGIANTS = 25;
        private const int EOSBATTLE = 26;
        private const int NEPTUNEBATTLE = 27;
        private const int ARESBATTLE = 28;
        private const int GAEABATTLE = 29;
        private const int QUEENSGUARDONE = 30;
        private const int QUEENSGUARDTWO = 31;
        private const int QUEENSGUARDTHREE = 32;
        private const int QUEENSGUARDFOUR = 33;
        private const int HALLGUARD1 = 34;
        private const int HALLGUARD2 = 35;
        private const int HALLGUARD3 = 36;
        private const int HALLGUARD4 = 37;
        private const int HALLGUARD5 = 38;
        private const int DRAKSNUMBER = 39;
        private const int QUEENSNUMBER = 40;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Each of these four portals offers the passer-by an exotic weapon from a past visitor to this domain.");
            if (GetPartyCount(player, type, doMsgs) == 1) {
                if (HasItem(player, type, doMsgs, SWORDOFARES) || HasItem(player, type, doMsgs, BOWOFEOS) || HasItem(player, type, doMsgs, GAEASFLAIL) || HasItem(player, type, doMsgs, NEPTUNESTRIDENT)) {
                    ShowText(player, type, doMsgs, "You cannot enter here, you already have one of the weapons of the Gods.");
                    SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                }
                else {
                    ShowText(player, type, doMsgs, "Enter, and claim one of the four artifacts for your reward. You may only have one!");
                    ShowText(player, type, doMsgs, "Arm yourself with whichever artifact you choose before you challenge she who threatens the Gateway's existence.");
                    WallClear(player, type, doMsgs);
                }
            }
            else {
                ShowText(player, type, doMsgs, "Be off!! Only one Hero may enter here at a time!");
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, SWORDOFARES)) {
                AssaultTxt(player, type, doMsgs);
                TeleportParty(player, type, doMsgs, 12, 2, 68, Direction.North);
            }
            else {
                AdvTxt(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, BOWOFEOS)) {
                AssaultTxt(player, type, doMsgs);
                TeleportParty(player, type, doMsgs, 12, 2, 64, Direction.North);
            }
            else {
                AdvTxt(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, NEPTUNESTRIDENT)) {
                AssaultTxt(player, type, doMsgs);
                TeleportParty(player, type, doMsgs, 12, 2, 67, Direction.North);
            }
            else {
                AdvTxt(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallItem(player, type, doMsgs, PORTAL, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            WallClear(player, type, doMsgs);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, GAEASFLAIL)) {
                AssaultTxt(player, type, doMsgs);
                TeleportParty(player, type, doMsgs, 12, 2, 65, Direction.North);
            }
            else {
                AdvTxt(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int itemA = 0;
            switch (GetTile(player, type, doMsgs)) {
                case 252:
                    itemA = GAEASFLAIL;
                    GaeasText(player, type, doMsgs);
                    break;
                case 234:
                    itemA = SWORDOFARES;
                    AresText(player, type, doMsgs);
                    break;
                case 203:
                    itemA = BOWOFEOS;
                    EosText(player, type, doMsgs);
                    break;
                case 221:
                    itemA = NEPTUNESTRIDENT;
                    NeptunesTxt(player, type, doMsgs);
                    break;
            }
            if ((!HasItem(player, type, doMsgs, itemA))) {
                GiveItem(player, type, doMsgs, itemA);
            }
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "WARNING: This will only take you back to the Keepers room. You must retrace your steps or take a different path to proceed from there.");
            TeleportParty(player, type, doMsgs, 12, 2, 0, Direction.East);
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Pure Dissemination lies through this portal.");
            TeleportParty(player, type, doMsgs, 12, 1, 255, Direction.West);
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeParty, LASTBATTLE) == 1) {
                ShowText(player, type, doMsgs, "Before you, now mad with power and muttering spells upon spells, hovers Aeowyn. Using the Rings of Fate, she is trying to manipulate the Gateway of Immortality. Shaping its destination and purpose.");
                ShowText(player, type, doMsgs, "She scorns you as you approach, 'FOOL! MORTAL! You were so easily subdued; so quick to crave the power I offered; you lost sight of yourself and succumbed to my desires.");
                ShowText(player, type, doMsgs, "You shall learn the price of your ignorance! For only now, at the end do you understand. Had you kept the rings, had you breached the seal alone, then you may have had this power. But now, I WILL DESTROY YOU!'");
                ShowText(player, type, doMsgs, "Aeowyn conjures four guardsmen to her aid, as well as summoning from their entombment, the five Dralkarians...");
                AddEncounter(player, type, doMsgs, 01, QUEENSGUARDONE);
                AddEncounter(player, type, doMsgs, 02, QUEENSGUARDTWO);
                AddEncounter(player, type, doMsgs, 03, QUEENSGUARDTHREE);
                AddEncounter(player, type, doMsgs, 04, QUEENSGUARDFOUR);
                AddEncounter(player, type, doMsgs, 05, DRAKSNUMBER);
                AddEncounter(player, type, doMsgs, 06, QUEENSNUMBER);
            }
            else {
                ShowText(player, type, doMsgs, "Guardians of the Gateway are summoned to its defense as you attempt to gain access to its secrets.");
                AddEncounter(player, type, doMsgs, 01, QUEENSGUARDONE);
                AddEncounter(player, type, doMsgs, 02, QUEENSGUARDTWO);
                AddEncounter(player, type, doMsgs, 03, QUEENSGUARDTHREE);
                AddEncounter(player, type, doMsgs, 04, QUEENSGUARDFOUR);
                AddEncounter(player, type, doMsgs, 05, DRAKSNUMBER);
            }
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "An illusionary door fades away as you approach.");
            ClearWallItem(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int trap = 0;
            trap = GetFlag(player, type, doMsgs, FlagTypeParty, CASETRAP2);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                switch (trap) {
                    case 1:
                        DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 3);
                        NoMapsZone(player, type, doMsgs);
                        NoSpellZone(player, type, doMsgs);
                        ShowText(player, type, doMsgs, "Evil winds rip through you, mauling you horribly.");
                        trap++;
                        break;
                    case 2:
                        DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) - 2000);
                        SetDebuff(player, type, doMsgs, POISON, 15, 100);
                        ShowText(player, type, doMsgs, "Poisoned gas strangles you as it dissipates.");
                        trap++;
                        break;
                    case 3:
                        DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 4);
                        ShowText(player, type, doMsgs, "A flash of magical light blinds you temporarily; causing you damage.");
                        trap++;
                        break;
                    case 4:
                        ModifyMana(player, type, doMsgs,  - 2000);
                        while (HasItem(player, type, doMsgs, ZEUSSCROLL))
                            RemoveItem(player, type, doMsgs, ZEUSSCROLL);
                            while (HasItem(player, type, doMsgs, SOVEREIGNSCROLL))
                                RemoveItem(player, type, doMsgs, SOVEREIGNSCROLL);
                                ShowText(player, type, doMsgs, "Mystical currents from an ancient snare steal from and damage you.");
                                trap++;
                                break;
                            case 5:
                                ShowText(player, type, doMsgs, "A blast of fire greets you at this next snare.");
                                ModifyMana(player, type, doMsgs,  - 200);
                                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 4);
                                trap++;
                                break;
                            default:
                                DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 3);
                                DisableHealing(player, type, doMsgs);
                                trap = 1;
                                NoSpellZone(player, type, doMsgs);
                                ShowText(player, type, doMsgs, "Evil laughter echoes off the walls as yet another snare harms you.");
                                break;
                        }
                        SetFlag(player, type, doMsgs, FlagTypeParty, CASETRAP2, trap);
                        SprungTrap(player, type, doMsgs);
                    }
                }
                protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.WONTHISGAME) == 0)) {
                        SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ENDGAMETELE, 2);
                        ShowText(player, type, doMsgs, "You've defeated the Queen; preventing the her from threatening all the Portals that interconnect throughout this world and others.");
                        ShowText(player, type, doMsgs, "Now, take these boosts to your attributes and to your wealths of knowledge and gold. You have restored the system to its rightful balance.");
                        ShowText(player, type, doMsgs, "In time, when you are ready, the portal will grant you access to new planes of existence! But that, is another story...");
                        SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.WONTHISGAME, 1);
                        SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.WINNER, 1);
                        ModifyExperience(player, type, doMsgs, 7500000);
                        ModifyGold(player, type, doMsgs, 2000000);
                        ModAttribute(player, type, doMsgs, STRENGTH, 3);
                        ModAttribute(player, type, doMsgs, AGILITY, 3);
                        ModAttribute(player, type, doMsgs, DEFENSE, 3);
                        ModAttribute(player, type, doMsgs, INITIATIVE, 3);
                        if (GetGuild(player, type, doMsgs) != WIZARD) {
                            ShowText(player, type, doMsgs, "You are bestowed with a new spell!");
                            GiveSpell(player, type, doMsgs, DEATH_DARTS_SPELL, 6);
                        }
                        else {
                            ShowText(player, type, doMsgs, "Mighty sorcerer, gain knowledge to control life from death.");
                            GiveSpell(player, type, doMsgs, RESUSCITATE_SPELL, 6);
                        }
                    }
                    else {
                        ShowText(player, type, doMsgs, "The portal glows with power. You may enter it now, but it will not take you to your true destination yet.");
                        ShowText(player, type, doMsgs, "The future has taken root in the present. All will be explained... with Yserbius III!!%%");
                    }
                }
                protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    ShowText(player, type, doMsgs, "Here you must go, but only after you've retrieved one of the mystic artifacts that travelers of this portal have left as gifts.");
                    TeleportParty(player, type, doMsgs, 12, 2, 232, Direction.South);
                }
                protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    DisablePartyJoining(player, type, doMsgs);
                }
                protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    int i = 0;
                    FnEvent15(player, type, doMsgs);
                    if (GetFlag(player, type, doMsgs, FlagTypeParty, STORMGIANT) != GetTile(player, type, doMsgs)) {
                        if (GetPartyCount(player, type, doMsgs) == 1) {
                            ShowText(player, type, doMsgs, "An ominous force stands before you!");
                            if (HasItem(player, type, doMsgs, STATUEOFSTORMGIANT) && GetFlag(player, type, doMsgs, FlagTypeParty, IMHERE) != GetTile(player, type, doMsgs) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ONLYONCE) == 0)) {
                                WallClear(player, type, doMsgs);
                                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ONLYONCE, 1);
                                ShowText(player, type, doMsgs, "Using one of the mystical statues, you turn into a Storm Giant and kill them all!");
                                ModifyGold(player, type, doMsgs, 10000);
                                GiveItem(player, type, doMsgs, PHOSPHORESCENTBLADE);
                                GiveItem(player, type, doMsgs, HEALAMPHORA);
                                GiveItem(player, type, doMsgs, ZEUSSCROLL);
                                SetFlag(player, type, doMsgs, FlagTypeParty, IMHERE, GetTile(player, type, doMsgs));
                            }
                        }
                        else if (GetFlag(player, type, doMsgs, FlagTypeParty, IMHERE) != GetTile(player, type, doMsgs)) {
                            ShowText(player, type, doMsgs, "Had you been alone and with their talisman, you may have stood a chance!");
                            for (i = 1; i <= 4; i++) {
                                AddEncounter(player, type, doMsgs, i, STORMGIANTS);
                            }
                            SetFlag(player, type, doMsgs, FlagTypeParty, IMHERE, GetTile(player, type, doMsgs));
                        }
                        SetFlag(player, type, doMsgs, FlagTypeParty, STORMGIANT, GetTile(player, type, doMsgs));
                    }
                }
                protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    DisableAutomaps(player, type, doMsgs);
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
                protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    DisableAutomaps(player, type, doMsgs);
                    if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                        switch (GetFacing(player, type, doMsgs)) {
                            case Direction.North:
                                SetFacing(player, type, doMsgs, Direction.South);
                                SetFacing(player, type, doMsgs, Direction.West);
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
                                TeleportParty(player, type, doMsgs, 12, 2, GetTile(player, type, doMsgs), Direction.East);
                                SprungTrap(player, type, doMsgs);
                                break;
                        }
                    }
                }
                protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    DisableAutomaps(player, type, doMsgs);
                    NoSpellZone(player, type, doMsgs);
                    DisablePartyJoining(player, type, doMsgs);
                    if (GetPartyCount(player, type, doMsgs) == 1) {
                        if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILLEDQUEEN) == 0)) {
                            ShowText(player, type, doMsgs, "Those who hath not faced the mad Queen must lead, lest your efforts are futile. You are one that may lead!");
                            SetFlag(player, type, doMsgs, FlagTypeParty, LASTBATTLE, 1);
                            TeleportParty(player, type, doMsgs, 12, 2, 104, Direction.East);
                        }
                        else {
                            ShowText(player, type, doMsgs, "You have already defeated the Queen, you cannot face that which is no more.");
                            SetFlag(player, type, doMsgs, FlagTypeParty, LASTBATTLE, 0);
                            TeleportParty(player, type, doMsgs, 12, 2, 104, Direction.East);
                        }
                    }
                    else {
                        ShowText(player, type, doMsgs, "Step forth ALONE!");
                        TeleportParty(player, type, doMsgs, 12, 2, 119, Direction.North);
                    }
                }
                protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    if ((GetFlag(player, type, doMsgs, FlagTypeParty, KEEPER) == 0)) {
                        ShowText(player, type, doMsgs, "The statue of an ancient guardian greets you here. It writhes to life as you approach: 'Hail to thee! I am Chrysagorn, Keeper of the Portal and Servant to the Fates.");
                        ShowText(player, type, doMsgs, "I have been imprisoned here in granite by the mad Queen! Her powers are farther reaching than you dare imagine. With the five rings, she is now trying to gain control of the Gateway.");
                        ShowText(player, type, doMsgs, "I cannot defend the Gate from her powers, you must destroy her or all of time shall fold in upon itself. Our fate will be sealed in oblivion's tomb.'");
                        ShowText(player, type, doMsgs, "The statue begins to crumble as you watch, 'Go! defeat her! I can no longer protect...' but its too late, the statue explodes into dust flying across the room and damaging you.");
                        DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 5);
                        SetFlag(player, type, doMsgs, FlagTypeParty, KEEPER, 1);
                    }
                }
                protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    SetTileBlock(player, type, doMsgs, GetTile(player, type, doMsgs));
                }
                protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    int i = 0;
                    ShowText(player, type, doMsgs, "Eos' servants form from the morning mists which permeate this place.");
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, EOSBATTLE);
                    }
                }
                protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    int i = 0;
                    ShowText(player, type, doMsgs, "Descendents of Gaea rise from the earthen floor to challenge you!");
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, GAEABATTLE);
                    }
                }
                protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    int i = 0;
                    ShowText(player, type, doMsgs, "Ancient servants of Neptune rise from the waters and bar your way!");
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, NEPTUNEBATTLE);
                    }
                }
                protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    int i = 0;
                    ShowText(player, type, doMsgs, "Masters of Warfare, students of Ares, ambush you!");
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, ARESBATTLE);
                    }
                }
                protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    SetTileState(player, type, doMsgs, 0);
                }
                protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    int i = 0;
                    if (GetTileState(player, type, doMsgs) != GetTile(player, type, doMsgs)) {
                        SetTileState(player, type, doMsgs, GetTile(player, type, doMsgs));
                        switch (GetPartyCount(player, type, doMsgs)) {
                            case 1:
                                AddEncounter(player, type, doMsgs, 01, HALLGUARD1);
                                AddEncounter(player, type, doMsgs, 02, HALLGUARD1);
                                break;
                            case 2:
                                for (i = 1; i <= 3; i++) {
                                    AddEncounter(player, type, doMsgs, i, HALLGUARD1);
                                }
                                break;
                            default:
                                for (i = 1; i <= 5; i++) {
                                    AddEncounter(player, type, doMsgs, i, HALLGUARD1);
                                }
                                break;
                        }
                    }
                }
                protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HALLOFDOOM) == 0)) {
                        SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HALLOFDOOM, 1);
                    }
                    ShowText(player, type, doMsgs, "This enormous hallway is adorned with precious jewels and artworks in every crevice. Golden statues in the images of greater deities and gods who hath passed this way line either side of the hall.");
                    ShowText(player, type, doMsgs, "A challenge of outrageous proportions guards this passageway before you. Northward, two rows of beasts and man stand as guardians to the ultimate Gateway.");
                }
                protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    int i = 0;
                    if (GetTileState(player, type, doMsgs) != GetTile(player, type, doMsgs)) {
                        SetTileState(player, type, doMsgs, GetTile(player, type, doMsgs));
                        switch (GetPartyCount(player, type, doMsgs)) {
                            case 1:
                                AddEncounter(player, type, doMsgs, 01, HALLGUARD2);
                                AddEncounter(player, type, doMsgs, 02, HALLGUARD2);
                                break;
                            case 2:
                                for (i = 1; i <= 3; i++) {
                                    AddEncounter(player, type, doMsgs, i, HALLGUARD2);
                                }
                                break;
                            default:
                                for (i = 1; i <= 5; i++) {
                                    AddEncounter(player, type, doMsgs, i, HALLGUARD2);
                                }
                                break;
                        }
                    }
                }
                protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    if (UsedItem(player, type, ref doMsgs, NEPTUNESTRIDENT, NEPTUNESTRIDENT)) {
                        ShowText(player, type, doMsgs, "The lava before you swirls into a wading pool! Neptune himself has used such power to bypass these foul snares.");
                        ClearMe(player, type, doMsgs);
                    }
                    else if (UsedItem(player, type, ref doMsgs, GAEASFLAIL, GAEASFLAIL)) {
                        ShowText(player, type, doMsgs, "The lava hardens into solid rock! Gaea herself has used such powers to pass safely by such traps!");
                        ClearMe(player, type, doMsgs);
                    }
                    else if (UsedItem(player, type, ref doMsgs, BOWOFEOS, BOWOFEOS)) {
                        ShowText(player, type, doMsgs, "Dawn's light shines bright upon the bow forming a golden arch across the lava!");
                        ClearMe(player, type, doMsgs);
                    }
                    else if (UsedItem(player, type, ref doMsgs, SWORDOFARES, SWORDOFARES)) {
                        ShowText(player, type, doMsgs, "The sword summons a powerful Ice Elemental! The elemental sinks into the lava, quenching the raging war between fire and ice!");
                        ClearMe(player, type, doMsgs);
                    }
                    else if (UsedItem(player, type, ref doMsgs, SHORTSWORD, UNITYRING)) {
                        ShowText(player, type, doMsgs, "The lava resumes its form.");
                        SetFlag(player, type, doMsgs, FlagTypeParty, USEDNEPTRI, 0);
                    }
                    else {
                        ShowText(player, type, doMsgs, "A vile pool of molten lava bubbles violently before you. You must find a way to alter this pool of sure death.");
                    }
                }
                private void ClearMe(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    SetFlag(player, type, doMsgs, FlagTypeParty, USEDNEPTRI, 1);
                    switch (GetTile(player, type, doMsgs)) {
                        case 160:
                        case 192:
                            ClearTileBlock(player, type, doMsgs, 176);
                            SetFloorItem(player, type, doMsgs, WATER, 176);
                            break;
                        default:
                            ClearTileBlock(player, type, doMsgs, 85);
                            SetFloorItem(player, type, doMsgs, WATER, 85);
                            break;
                    }
                }
                protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    if (GetFlag(player, type, doMsgs, FlagTypeParty, USEDNEPTRI) == 1) {
                        ShowText(player, type, doMsgs, "The magic sustains the pool, allowing you to safely pass.");
                    }
                    else {
                        ShowText(player, type, doMsgs, "The lava scorches and torments your body. The magical fluids then hurl you across the maze...");
                        DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) - 100);
                        TeleportParty(player, type, doMsgs, 12, 2, 191, Direction.South);
                    }
                }
                protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    int i = 0;
                    if (GetTileState(player, type, doMsgs) != GetTile(player, type, doMsgs)) {
                        SetTileState(player, type, doMsgs, GetTile(player, type, doMsgs));
                        switch (GetPartyCount(player, type, doMsgs)) {
                            case 1:
                                AddEncounter(player, type, doMsgs, 01, HALLGUARD3);
                                AddEncounter(player, type, doMsgs, 02, HALLGUARD3);
                                break;
                            case 2:
                                for (i = 1; i <= 3; i++) {
                                    AddEncounter(player, type, doMsgs, i, HALLGUARD3);
                                }
                                break;
                            default:
                                for (i = 1; i <= 5; i++) {
                                    AddEncounter(player, type, doMsgs, i, HALLGUARD3);
                                }
                                break;
                        }
                    }
                }
                protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    int i = 0;
                    if (GetTileState(player, type, doMsgs) != GetTile(player, type, doMsgs)) {
                        SetTileState(player, type, doMsgs, GetTile(player, type, doMsgs));
                        switch (GetPartyCount(player, type, doMsgs)) {
                            case 1:
                                AddEncounter(player, type, doMsgs, 01, HALLGUARD4);
                                AddEncounter(player, type, doMsgs, 02, HALLGUARD4);
                                break;
                            case 2:
                                for (i = 1; i <= 3; i++) {
                                    AddEncounter(player, type, doMsgs, i, HALLGUARD4);
                                }
                                break;
                            default:
                                for (i = 1; i <= 5; i++) {
                                    AddEncounter(player, type, doMsgs, i, HALLGUARD4);
                                }
                                break;
                        }
                    }
                }
                protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    int i = 0;
                    if (GetTileState(player, type, doMsgs) != GetTile(player, type, doMsgs)) {
                        SetTileState(player, type, doMsgs, GetTile(player, type, doMsgs));
                        switch (GetPartyCount(player, type, doMsgs)) {
                            case 1:
                                AddEncounter(player, type, doMsgs, 01, HALLGUARD5);
                                AddEncounter(player, type, doMsgs, 02, HALLGUARD5);
                                break;
                            case 2:
                                for (i = 1; i <= 3; i++) {
                                    AddEncounter(player, type, doMsgs, i, HALLGUARD5);
                                }
                                break;
                            default:
                                for (i = 1; i <= 5; i++) {
                                    AddEncounter(player, type, doMsgs, i, HALLGUARD5);
                                }
                                break;
                        }
                    }
                }
                protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    if ((GetFlag(player, type, doMsgs, FlagTypeParty, IHAVETHEFLAIL) == 0)) {
                        if (UsedItem(player, type, ref doMsgs, GAEASFLAIL, GAEASFLAIL)) {
                            ShowText(player, type, doMsgs, "The pit before you congeals into a solid earthen floor! Gaea's power is obvious concerning the nature of things.");
                            SetFlag(player, type, doMsgs, FlagTypeParty, USEDGAEAFLAIL, 1);
                            switch (GetTile(player, type, doMsgs)) {
                                case 23:
                                case 55:
                                    ClearTileBlock(player, type, doMsgs, 39);
                                    SetFloorItem(player, type, doMsgs, NO_OBJECT, 39);
                                    break;
                            }
                        }
                        else if (UsedItem(player, type, ref doMsgs, SHORTSWORD, UNITYRING)) {
                            ShowText(player, type, doMsgs, "The pit remains open.");
                            SetFlag(player, type, doMsgs, FlagTypeParty, USEDGAEAFLAIL, 0);
                        }
                        else {
                            ShowText(player, type, doMsgs, "An eerie black pit stretches deep into the earth here. Echoes of your every sound are barely audible whispers by the time they return.");
                        }
                    }
                }
                protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    if ((GetFlag(player, type, doMsgs, FlagTypeParty, IHAVETHEFLAIL) == 0)) {
                        if (GetFlag(player, type, doMsgs, FlagTypeParty, USEDGAEAFLAIL) == 1) {
                            ShowText(player, type, doMsgs, "The flail keeps the earth intact, allowing you to safely pass.");
                        }
                        else {
                            ShowText(player, type, doMsgs, "The pit swallows you whole, this magical snare does not kill you, however, but you are swept away through the maze.");
                            DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) - 100);
                            TeleportParty(player, type, doMsgs, 12, 2, 222, Direction.East);
                        }
                    }
                }
                protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    if ((!HasItem(player, type, doMsgs, GAEASFLAIL))) {
                        SetFlag(player, type, doMsgs, FlagTypeParty, IHAVETHEFLAIL, 1);
                    }
                }
                protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    ShowText(player, type, doMsgs, "An ancient portal carved of pure magic and wrought with precious gemstones stands guard here.");
                    if (GetPartyCount(player, type, doMsgs) == 1) {
                        if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HALLOFDOOM) == 1) && (HasItem(player, type, doMsgs, SWORDOFARES) || HasItem(player, type, doMsgs, BOWOFEOS) || HasItem(player, type, doMsgs, GAEASFLAIL) || HasItem(player, type, doMsgs, NEPTUNESTRIDENT))) {
                            ShowText(player, type, doMsgs, "The ancient crystals merge into a teleport, allowing you to gain quick access to the Gateway's heart.");
                            TeleportParty(player, type, doMsgs, 12, 2, 205, Direction.North);
                        }
                        else {
                            ShowText(player, type, doMsgs, "Here you will enter the ancient Gods' treasure room.");
                            TeleportParty(player, type, doMsgs, 12, 2, 219, Direction.South);
                        }
                    }
                    else {
                        ShowText(player, type, doMsgs, "Be off!! Only one Hero may enter here at a time!");
                        SetFacing(player, type, doMsgs, Direction.East);
                    }
                }
                protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ONLYONCE, 0);
                    ShowText(player, type, doMsgs, "From here you enter the heart of The Gateway.");
                    TeleportParty(player, type, doMsgs, 12, 2, 246, Direction.East);
                }
                protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    if ((!HasItem(player, type, doMsgs, STATUEOFSTORMGIANT))) {
                        GiveItem(player, type, doMsgs, STATUEOFSTORMGIANT);
                        ShowText(player, type, doMsgs, "You pick up an odd statue. Perhaps it will protect you when you are alone.");
                    }
                    switch (GetTile(player, type, doMsgs)) {
                        case 238:
                            ShowText(player, type, doMsgs, "A jeweled carving depicts a band of travelers journeying through an ancient dungeon in search of some great treasure.");
                            break;
                        case 222:
                            ShowText(player, type, doMsgs, "This carving shows four ancient fragments brought unto themselves, forming some magical piece that allows access into a dark kingdom.");
                            break;
                        case 206:
                            ShowText(player, type, doMsgs, "Here you see a myriad of images strewn across various puzzles and hordes of vile creatures that scorn the travelers as they seek the treasure.");
                            break;
                        case 190:
                            if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILLEDQUEEN)) {
                                ShowText(player, type, doMsgs, "Emblazoned in the stones you see your own image slaying the mad Queen and eventually entering the mystical Gateway of Immortality.");
                            }
                            else {
                                ShowText(player, type, doMsgs, "Shadowy, incoherent images flash across the stones as though some part of future history is yet to be completed.");
                            }
                            break;
                    }
                }
                protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    TeleportParty(player, type, doMsgs, 12, 2, 150, Direction.West);
                    ShowText(player, type, doMsgs, "To the last pathway of challenge. From there you will ultimately meet your Fate.");
                }
                protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    DisableAutomaps(player, type, doMsgs);
                }
                protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.FINISHEDGAME) == 0)) {
                        SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.FINISHEDGAME, 1);
                        ShowText(player, type, doMsgs, "An eerie, shimmering portal hangs before you. This is the Gateway...the ingress into new adventures and future history.");
                        ShowText(player, type, doMsgs, "You will come back here in time, when you feel you are ready for new challenges and greater travels. Until then, you must rest and restore your drained powers for that day.");
                        ShowText(player, type, doMsgs, "There is a place, guarded by Shaddax, the Keeper, you must journey there and unravel the riddles placed in your path by some vile deity that inhabits another dimension.");
                        ShowText(player, type, doMsgs, "That is your task for now, you may return here when time dictates! Go now, seek Shaddax...you may find the entrance through Dragon's Ire! Go, brave champion!");
                        TeleportParty(player, type, doMsgs, 1, 1, 3, Direction.South);
                    }
                    else {
                        ShowText(player, type, doMsgs, "The portal is here; but the future is not yours to see...yet.");
                        TeleportParty(player, type, doMsgs, 1, 1, 3, Direction.South);
                    }
                }
                private void AdvTxt(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    ShowText(player, type, doMsgs, "This portal will offer you no advancement without the proper artifact.");
                }
                private void AssaultTxt(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    ShowText(player, type, doMsgs, "Through here you begin the final assault.");
                }
                private void WallClear(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                }
                private void AresText(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    ShowText(player, type, doMsgs, "Ares had visited this place many moons ago. As his mark, he left behind a legend that clever Night Elf craftsmen emblazoned with ancient runes upon this jeweled blade.");
                }
                private void NeptunesTxt(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    ShowText(player, type, doMsgs, "Lord Neptune, Master of the Wind and the Sea, used this Trident to command the waters that now surround Twinion to swirl into fury; crashing down upon his enemies. Its power is now yours to borrow.");
                }
                private void GaeasText(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    ShowText(player, type, doMsgs, "Gaea had exhausted herself in many travels, but her pleasures here have always been her favorite. She filled herself with energies and moved on to a new adventure via the Portal.");
                    ShowText(player, type, doMsgs, "Her flail now remains as her mark, and is offered to you to defend the Portal from abuse.");
                }
                private void EosText(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    ShowText(player, type, doMsgs, "Dawn shall come! Eos brings the sun, and the first arch of gold was wrought into this magnificent bow in honor of this goddess.");
                    ShowText(player, type, doMsgs, "Now the Bow of Eos, shall be your light and guide past the snares that await you along the paths to the Portal.");
                }
                private void NoMapsZone(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    DisableAutomaps(player, type, doMsgs);
                }
                private void NoSpellZone(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    DisableSpells(player, type, doMsgs);
                }
                private void SprungTrap(TwPlayerServer player, MapEventType type, bool doMsgs) {
                    SetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP, 1);
                }
            }
        }
