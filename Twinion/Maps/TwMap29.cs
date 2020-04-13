using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    class TwMap29 : TwMap {
        public override int MapIndex => 29;
        public override int MapID => 0x0B04;
        protected override int RandomEncounterChance => 0;
        protected override int RandomEncounterExtraCount => 0;

        private const int GOTTEXT = 1;
        private const int DRAKFIGHT = 2;
        private const int SPRUNGTRAP = 1;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You manage to move through the astral material.");
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableSpells(player, type, doMsgs);
            DisableSkills(player, type, doMsgs);
            DisableMana(player, type, doMsgs);
            ModifyMana(player, type, doMsgs,  - 200);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                if (GetAlignment(player, type, doMsgs) == HARMONY) {
                    DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 8);
                    ShowText(player, type, doMsgs, "The vile evil that sustains this pocket of Ashakkar here drains life from you!");
                }
                else {
                    ShowText(player, type, doMsgs, "You thrive on the vicious forces that exist here.");
                    ModifyHealth(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 3);
                    ModifyMana(player, type, doMsgs, 200);
                }
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableSpells(player, type, doMsgs);
            DisableSkills(player, type, doMsgs);
            DisableMana(player, type, doMsgs);
            ModifyMana(player, type, doMsgs,  - 200);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                if (GetAlignment(player, type, doMsgs) == CHAOS) {
                    DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 8);
                    ShowText(player, type, doMsgs, "Your struggle against the forces in this piece of Enakkar twists and drains your energy.");
                }
                else {
                    ShowText(player, type, doMsgs, "You feel revived and refreshed as you travel through this segment of Enakkar.");
                    ModifyHealth(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 3);
                    ModifyMana(player, type, doMsgs, 200);
                }
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 3);
                ShowText(player, type, doMsgs, "The forces of Fire sear and singe you as you travel through some small part of the Elemental plane.");
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 3);
                ShowText(player, type, doMsgs, "The Waters here drench you with ominous force.");
                SprungTrap(player, type, doMsgs);
            }
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            ShowText(player, type, doMsgs, "Violent forces whip into a fury of vorticies; forming an arsenal of Planar Guardians who prevent transgressions!!");
            for (i = 1; i <= 4; i++) {
                AddEncounter(player, type, doMsgs, i, 39);
            }
            for (i = 5; i <= 6; i++) {
                AddEncounter(player, type, doMsgs, i, 40);
            }
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeParty, GOTTEXT) == 0)) {
                ShowText(player, type, doMsgs, "A splendor of sculptures and jewels decorate this elaborate setting.  For you have come into Corpeus' re-creation of his home.");
                ShowText(player, type, doMsgs, "This is a semblance of the Physical Plane.");
                SetFlag(player, type, doMsgs, FlagTypeParty, GOTTEXT, 1);
            }
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeParty, GOTTEXT) == 0)) {
                ShowText(player, type, doMsgs, "Pillars of pure light shoot upwards into oblivion, setting this space ablaze with Juvalad magic.");
                ShowText(player, type, doMsgs, "This is a semblance of the plane Enakkar!");
                SetFlag(player, type, doMsgs, FlagTypeParty, GOTTEXT, 1);
            }
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeParty, GOTTEXT) == 0)) {
                ShowText(player, type, doMsgs, "Violent waves of lava cascade against the astral shores as fire and brimstone fly in Pluthros' throne room.");
                ShowText(player, type, doMsgs, "This is a semblance of the plane Ashakkar!");
                SetFlag(player, type, doMsgs, FlagTypeParty, GOTTEXT, 1);
            }
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeParty, GOTTEXT) == 0)) {
                ShowText(player, type, doMsgs, "The four corners of creation scorn at each other in Malos' domain.");
                ShowText(player, type, doMsgs, "This is a semblance of the Elemental Plane.");
                SetFlag(player, type, doMsgs, FlagTypeParty, GOTTEXT, 1);
            }
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            ShowText(player, type, doMsgs, "Turbulent forces impede you from going any further in this direction.");
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You can just make out a distant plane ahead of you...perhaps you can reach it through here.");
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A maginficent likeness of some powerful demigod stands here as guardian to this chamber.");
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableMana(player, type, doMsgs);
            if (GetFlag(player, type, doMsgs, FlagTypeParty, DRAKFIGHT) == 1) {
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILLEDMALOS) == 0)) {
                    ShowText(player, type, doMsgs, "Malos weaves magical mists as he speaks at you, 'You dare to challenge the Guardian of the Elements! I shall not be so easy to defeat!");
                    ShowText(player, type, doMsgs, "My ring shall be yours if you can conquer the Elements!'");
                    BootySet(player, type, doMsgs);
                    TextAtThrone(player, type, doMsgs);
                }
                switch (GetPartyCount(player, type, doMsgs)) {
                    case 1:
                        AddEncounter(player, type, doMsgs, 01, 35);
                        break;
                    case 2:
                        AddEncounter(player, type, doMsgs, 01, 38);
                        AddEncounter(player, type, doMsgs, 05, 35);
                        break;
                    default:
                        AddEncounter(player, type, doMsgs, 01, 38);
                        AddEncounter(player, type, doMsgs, 02, 6);
                        AddEncounter(player, type, doMsgs, 06, 35);
                        break;
                }
            }
            else {
                ShowText(player, type, doMsgs, "The Dralkarian Lord of the Elements is not here.");
            }
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetAlignment(player, type, doMsgs) == CHAOS) {
                if (GetGuild(player, type, doMsgs) != WIZARD || GetGuild(player, type, doMsgs) != CLERIC) {
                    DisableSpells(player, type, doMsgs);
                    DisableMana(player, type, doMsgs);
                    ShowText(player, type, doMsgs, "Juvalad strips you of the ability to use magic! Your alignment opposes his own!");
                }
                else {
                    ShowText(player, type, doMsgs, "Your alignment has weakened your magic; but your devotion lets you retain your spells, your skills though are useless!");
                    DisableMana(player, type, doMsgs);
                    DisableSkills(player, type, doMsgs);
                }
            }
            if (GetFlag(player, type, doMsgs, FlagTypeParty, DRAKFIGHT) == 1) {
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILLEDJUVALAD) == 0)) {
                    ShowText(player, type, doMsgs, "Juvalad rises before you, 'Foul fool! Do you not know death, when you see it? Die now and curse in vain!'");
                    TextAtThrone(player, type, doMsgs);
                    BootySet(player, type, doMsgs);
                }
                switch (GetPartyCount(player, type, doMsgs)) {
                    case 1:
                        AddEncounter(player, type, doMsgs, 01, 36);
                        break;
                    case 2:
                        AddEncounter(player, type, doMsgs, 01, 38);
                        AddEncounter(player, type, doMsgs, 05, 36);
                        break;
                    default:
                        AddEncounter(player, type, doMsgs, 01, 38);
                        AddEncounter(player, type, doMsgs, 02, 6);
                        AddEncounter(player, type, doMsgs, 06, 36);
                        break;
                }
            }
            else {
                ShowText(player, type, doMsgs, "The Dralkarian Lord of Enakkar is not here.");
            }
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetAlignment(player, type, doMsgs) == HARMONY) {
                ShowText(player, type, doMsgs, "Your alignment opposes Pluthros'!");
                if (GetGuild(player, type, doMsgs) != WIZARD || GetGuild(player, type, doMsgs) != CLERIC) {
                    DisableSpells(player, type, doMsgs);
                    DisableMana(player, type, doMsgs);
                    ShowText(player, type, doMsgs, "For that, he strips your ability to use magic! ");
                }
                else {
                    ShowText(player, type, doMsgs, "For that, he has weakened your magic; but your devotion let's you retain your spells! Your skills, however, are useless!");
                    DisableMana(player, type, doMsgs);
                    DisableSkills(player, type, doMsgs);
                }
            }
            if (GetFlag(player, type, doMsgs, FlagTypeParty, DRAKFIGHT) == 1) {
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILLEDPLUTHROS) == 0)) {
                    ShowText(player, type, doMsgs, "Pluthros offers a resonating cry as you approach, 'You do not know of the prophecies! You are not one of the followers!");
                    ShowText(player, type, doMsgs, "Now I shall teach you the price of incredulity!'");
                    BootySet(player, type, doMsgs);
                    TextAtThrone(player, type, doMsgs);
                }
                switch (GetPartyCount(player, type, doMsgs)) {
                    case 1:
                        AddEncounter(player, type, doMsgs, 01, 34);
                        break;
                    case 2:
                        AddEncounter(player, type, doMsgs, 01, 38);
                        AddEncounter(player, type, doMsgs, 05, 34);
                        break;
                    default:
                        AddEncounter(player, type, doMsgs, 01, 38);
                        AddEncounter(player, type, doMsgs, 02, 6);
                        AddEncounter(player, type, doMsgs, 06, 34);
                        break;
                }
            }
            else {
                ShowText(player, type, doMsgs, "The Dralkarian Lord of Ashakkar is not here.");
            }
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeParty, DRAKFIGHT) == 1) {
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILLEDASTELLIGUS) == 0)) {
                    ShowText(player, type, doMsgs, "Astelligus roars as you near his throne room, 'Damn you to Ashakkar! Your intrusion shall be short lived! I shall send you on your way to the next life!'");
                    TextAtThrone(player, type, doMsgs);
                    BootySet(player, type, doMsgs);
                }
                switch (GetPartyCount(player, type, doMsgs)) {
                    case 1:
                        AddEncounter(player, type, doMsgs, 01, 33);
                        break;
                    case 2:
                        AddEncounter(player, type, doMsgs, 01, 38);
                        AddEncounter(player, type, doMsgs, 05, 33);
                        break;
                    default:
                        AddEncounter(player, type, doMsgs, 01, 38);
                        AddEncounter(player, type, doMsgs, 02, 6);
                        AddEncounter(player, type, doMsgs, 06, 33);
                        break;
                }
            }
            else {
                ShowText(player, type, doMsgs, "The Dralkarian Lord of the Astral plane is not here.");
            }
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A glowing portal here will send you back to the Main Entrance. You will not be able to return lest you traverse the pathway here again!");
            TeleportParty(player, type, doMsgs, 1, 1, 14, Direction.North);
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int flag = 0;
            int portroom1 = 0;
            int portroom2 = 0;
            Direction f1 = 0;
            Direction f2 = 0;
            switch (GetTile(player, type, doMsgs)) {
                case 30:
                    flag = TwIndexes.KILLEDCORPEUS;
                    portroom1 = 14;
                    portroom2 = 46;
                    f1 = Direction.North;
                    f2 = Direction.South;
                    break;
                case 168:
                    flag = TwIndexes.KILLEDASTELLIGUS;
                    portroom1 = 152;
                    portroom2 = 184;
                    f1 = Direction.North;
                    f2 = Direction.South;
                    break;
                case 17:
                    flag = TwIndexes.KILLEDJUVALAD;
                    portroom1 = 1;
                    portroom2 = 2;
                    f1 = Direction.North;
                    f2 = Direction.South;
                    break;
                case 255:
                    flag = TwIndexes.KILLEDPLUTHROS;
                    portroom1 = 254;
                    portroom2 = 239;
                    f1 = Direction.South;
                    f2 = Direction.North;
                    break;
                case 225:
                    flag = TwIndexes.KILLEDMALOS;
                    portroom1 = 160;
                    portroom2 = 210;
                    f1 = Direction.West;
                    f2 = Direction.North;
                    break;
            }
            if ((GetPartyCount(player, type, doMsgs) == 1) && ((GetFlag(player, type, doMsgs, FlagTypeDungeon, flag) == 0) || GetFlag(player, type, doMsgs, FlagTypeDungeon, flag) == 2)) {
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, flag) == 0)) {
                    SetFlag(player, type, doMsgs, FlagTypeParty, DRAKFIGHT, 1);
                }
                TeleportParty(player, type, doMsgs, 11, 4, portroom1, f1);
                ShowText(player, type, doMsgs, "You are pulled into the antechamber of the throne room. You must not leave this realm, lest your efforts are wasted!");
            }
            else if (GetPartyCount(player, type, doMsgs) > 1) {
                TeleportParty(player, type, doMsgs, 11, 4, portroom2, f2);
                ShowText(player, type, doMsgs, "You cannot step here together. Disband and return.");
            }
            else {
                ShowText(player, type, doMsgs, "Nothing happens.");
            }
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int item = 0;
            int portlvl = 0;
            int portroom = 0;
            Direction f1 = 0;
            switch (GetTile(player, type, doMsgs)) {
                case 14:
                    item = REALITYSRAMPART;
                    portlvl = 3;
                    portroom = 16;
                    f1 = Direction.East;
                    break;
                case 254:
                    item = HOPESFURY;
                    portlvl = 2;
                    portroom = 241;
                    f1 = Direction.North;
                    break;
                case 160:
                    item = ICEFLAME;
                    portlvl = 2;
                    portroom = 175;
                    f1 = Direction.North;
                    break;
                case 1:
                    item = FLASKOFSHADOWFALL;
                    portlvl = 2;
                    portroom = 40;
                    f1 = Direction.North;
                    break;
                case 120:
                    item = NIMBUSOFTHEFATES;
                    portlvl = 3;
                    portroom = 240;
                    f1 = Direction.East;
                    break;
            }
            if (GetFlag(player, type, doMsgs, FlagTypeParty, DRAKFIGHT) == 1) {
                if (HasItem(player, type, doMsgs, item)) {
                    ShowText(player, type, doMsgs, "In front of you sits an enormous throne, where one of the Dralkarians ponders Fate.");
                    ShowText(player, type, doMsgs, "As he notices you, he spots something you're carrying and beckons you forth with an evil grin.");
                }
                else {
                    switch (GetTile(player, type, doMsgs)) {
                        case 14:
                            ShowText(player, type, doMsgs, "Corpeus bellows at you, 'Without the Rampart, you have no defense. Away, come again once you've found my Reality!'");
                            break;
                        case 254:
                            ShowText(player, type, doMsgs, "Pluthros scorns you, 'Hath you no Hope? No Fury? Do not trouble me again without some sign of these!'");
                            break;
                        case 160:
                            ShowText(player, type, doMsgs, "Malos screeches at you, 'Have you no wisdom? Dost thou truly believe your puny weapons could defeat the elements? Another, will surely offer me challenge.'");
                            break;
                        case 1:
                            ShowText(player, type, doMsgs, "Juvalad sighs in disgust, 'Your efforts are wasted here! Back to Tribulations with you! You can not survive without the Flask.");
                            break;
                        case 120:
                            ShowText(player, type, doMsgs, "Astelligus' voice echoes across the great void:");
                            ShowText(player, type, doMsgs, "'Puny mortal...you fail to honor me with the proper artifact. Seek the Nimbus, and return, you will make for interesting prey!'");
                            break;
                    }
                    ShowText(player, type, doMsgs, "His magics swirl around you and hurl you through a vortex, back to the pathway.");
                    DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) - 10);
                    TeleportParty(player, type, doMsgs, 11, portlvl, portroom, f1);
                }
            }
            else {
                ShowText(player, type, doMsgs, "Away! You've left this domain and re-entered. You must remain here once you've started until you've killed the Dralk or died trying!");
                ShowText(player, type, doMsgs, "The Dralk sends you to the entrance of His home!");
                switch (GetTile(player, type, doMsgs)) {
                    case 160:
                        TeleportParty(player, type, doMsgs, 11, 4, 181, Direction.West);
                        break;
                    case 14:
                        TeleportParty(player, type, doMsgs, 11, 4, 75, Direction.East);
                        break;
                    case 1:
                        TeleportParty(player, type, doMsgs, 11, 4, 69, Direction.West);
                        break;
                    case 254:
                        TeleportParty(player, type, doMsgs, 11, 4, 187, Direction.East);
                        break;
                    case 120:
                        TeleportParty(player, type, doMsgs, 11, 4, 125, Direction.West);
                        break;
                }
            }
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetTileBlock(player, type, doMsgs, GetTile(player, type, doMsgs));
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeParty, GOTTEXT) == 0)) {
                ShowText(player, type, doMsgs, "An enormous void of darkness and surreal images haunts your vision now that you've stepped into a piece of Astelligus' home.");
                ShowText(player, type, doMsgs, "This is a semblance of the Astral plane.");
                SetFlag(player, type, doMsgs, FlagTypeParty, GOTTEXT, 1);
            }
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == WIZARD || GetGuild(player, type, doMsgs) == CLERIC || GetGuild(player, type, doMsgs) == RANGER || GetGuild(player, type, doMsgs) == THIEF) {
                ShowText(player, type, doMsgs, "Your prowess with magic allows you to retain your abilities; but not to restore your mana!!!");
                DisableMana(player, type, doMsgs);
            }
            else {
                ShowText(player, type, doMsgs, "Your magical powers are feeble and lack the discipline of a Wizard or Cleric. Your magics are useless here!");
                DisableSpells(player, type, doMsgs);
                DisableMana(player, type, doMsgs);
            }
            if (GetFlag(player, type, doMsgs, FlagTypeParty, DRAKFIGHT) == 1) {
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILLEDCORPEUS) == 0)) {
                    ShowText(player, type, doMsgs, "Corpeus is here. His voice shakes the great hall: 'Puny mortal. You dare come to challenge me? For my ring, you must take my life. For your attempt, I will take yours!'");
                    BootySet(player, type, doMsgs);
                    TextAtThrone(player, type, doMsgs);
                }
                switch (GetPartyCount(player, type, doMsgs)) {
                    case 1:
                        AddEncounter(player, type, doMsgs, 01, 37);
                        break;
                    case 2:
                        AddEncounter(player, type, doMsgs, 01, 38);
                        AddEncounter(player, type, doMsgs, 05, 37);
                        break;
                    default:
                        AddEncounter(player, type, doMsgs, 01, 38);
                        AddEncounter(player, type, doMsgs, 02, 6);
                        AddEncounter(player, type, doMsgs, 06, 37);
                        break;
                }
            }
            else {
                ShowText(player, type, doMsgs, "The Dralkarian Lord of the Physical plane is not here.");
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int flag = 0;
            int itemA = 0;
            switch (GetTile(player, type, doMsgs)) {
                case 104:
                    flag = TwIndexes.KILLEDASTELLIGUS;
                    itemA = NIMBUSOFTHEFATES;
                    break;
                case 15:
                    flag = TwIndexes.KILLEDCORPEUS;
                    itemA = REALITYSRAMPART;
                    break;
                case 0:
                    flag = TwIndexes.KILLEDJUVALAD;
                    itemA = FLASKOFSHADOWFALL;
                    break;
                case 161:
                    flag = TwIndexes.KILLEDMALOS;
                    itemA = ICEFLAME;
                    break;
                case 238:
                    flag = TwIndexes.KILLEDPLUTHROS;
                    itemA = HOPESFURY;
                    break;
            }
            if (HasItem(player, type, doMsgs, DRALKARIANRING) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, flag) == 0)) {
                RemoveItem(player, type, doMsgs, itemA);
                ModifyExperience(player, type, doMsgs, 1250000);
                ShowText(player, type, doMsgs, "The mystical device that aided you in the demise of this Dralk has also vanished!");
                SetFlag(player, type, doMsgs, FlagTypeDungeon, flag, 1);
                TpSpecial(player, type, doMsgs);
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeDungeon, flag) == 2) {
                ShowText(player, type, doMsgs, "You've passed here before! Live on and remember the Dralk as he was!");
                TpSpecial(player, type, doMsgs);
            }
            else {
                ShowText(player, type, doMsgs, "You must continue, for the Dralk's ring and his embodiment are gone from here.");
                TpSpecial(player, type, doMsgs);
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableSpells(player, type, doMsgs);
            int flagtotal = 0;
            flagtotal = GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILLEDASTELLIGUS) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILLEDPLUTHROS) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILLEDMALOS) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILLEDJUVALAD) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.KILLEDCORPEUS);
            if (HasItem(player, type, doMsgs, DRALKARIANRING)) {
                RemoveItem(player, type, doMsgs, DRALKARIANRING);
                ModifyExperience(player, type, doMsgs, 1000000);
                if (flagtotal <= 4) {
                    ShowPortrait(player, type, doMsgs, QUEENAEOWYN);
                    ShowText(player, type, doMsgs, "'My Great Champion! You've returned one of the Dralk's Rings! This will ensure us the power to enter the final phase of this most grand design!");
                    ShowText(player, type, doMsgs, "With each ring, I can use its power to increase your wisdom. Reap the benefits of the services you have sewn!");
                    ShowText(player, type, doMsgs, "Quickly now, with each passing Dralk we step closer to finding the nexus of immortality. Onward, return once you've conquered the next Dralk!'");
                }
                else {
                    ShowPortrait(player, type, doMsgs, QUEENAEOWYN);
                    ShowText(player, type, doMsgs, "As the Queen takes the fifth ring from your grasp, the forces here explode in a violent shockwave, throwing you to the ground.");
                    ShowText(player, type, doMsgs, "Aeowyn is absorbed in a fiery light of pure magic, she hovers and offers an evil laugh!");
                    ShowText(player, type, doMsgs, "'Did you truly believe I would share the greatest triumph with you! Your powers are no match for mine now! Away with you! Your faith in my friendship was your weakness! I alone shall breach The Gateway; I alone shall enter the next phase!'");
                    ShowText(player, type, doMsgs, "Driven mad with power, Aeowyn hurls untamed forces upon you, stripping away parts of your attributes! A blast explodes on the southern wall, where a teleport will allow you escape.");
                    ShowText(player, type, doMsgs, "The mad Queen, then dissipates into nothingness, only her evil laughter echoing as she heads off to The Gateway.");
                    DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 2);
                    RemoveItem(player, type, doMsgs, STARBURST);
                    if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ENDGAMETELE) == 0)) {
                        ModAttribute(player, type, doMsgs, STRENGTH,  - 1);
                        ModAttribute(player, type, doMsgs, AGILITY,  - 2);
                        ModAttribute(player, type, doMsgs, INITIATIVE,  - 2);
                        SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ENDGAMETELE, 1);
                    }
                }
            }
            else {
                ShowText(player, type, doMsgs, "'My Champion, you must return the Dralks' rings to me! Without them we will never be able to enter the ultimate goal of our Quest!'");
                ShowText(player, type, doMsgs, "The Queen conjurs a gateway behind you. 'Take this to the entrance, and try again! I will be here as long as possible...' She then returns to her magics and dismisses you.");
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Her Majesty hovers before you in a misty hue of grey-blue smoke. She is conjuring powerful forces to hold her presence here!");
            ShowText(player, type, doMsgs, "Approach her to the north, and report!");
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "This shall lead you out.");
            TeleportParty(player, type, doMsgs, 1, 1, 3, Direction.South);
        }
        private void BootySet(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetTreasure(player, type, doMsgs, DRALKARIANRING, 0, 0, 0, 0, 200000);
        }
        private void SprungTrap(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP, 1);
        }
        private void TpSpecial(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 11, 4, 56, Direction.North);
        }
        private void TextAtThrone(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A wall slides silently shut behind you, trapping you in the Dralk's throne room.");
            ShowText(player, type, doMsgs, "Brilliant crystals offset a stunning portal on the now closed egress!");
        }
    }
}
