using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    class TwMap17 : TwMap {
        public override int MapIndex => 17;
        public override int MapID => 0x0701;
        protected override int RandomEncounterChance => 12;
        protected override int RandomEncounterExtraCount => 0;

        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TNEPRES) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TNEPRES) == 2) {
                RemoveItem(player, type, doMsgs, TNEPRESKEY);
            }
            else {
                if (HasItem(player, type, doMsgs, TNEPRESKEY)) {
                    ShowPortrait(player, type, doMsgs, DWARFTHIEF);
                    GiveItem(player, type, doMsgs, PUMMELSCROLL);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TNEPRES, 1);
                    ShowText(player, type, doMsgs, "You meet a watchman.");
                    ShowText(player, type, doMsgs, "'Greetings, adventurers! You've found your way to Tipekans.");
                    ShowText(player, type, doMsgs, "Our laws require me to take your Tnepres Key. In exchange, however, I will register you for unlimited passage to our town.");
                    ShowText(player, type, doMsgs, "As a first time visitor, please accept this welcome scroll.");
                    ShowText(player, type, doMsgs, "May your journey be safe and profitable.'");
                    RemoveItem(player, type, doMsgs, TNEPRESKEY);
                }
                else {
                    ShowPortrait(player, type, doMsgs, DWARFTHIEF);
                    switch (GetTile(player, type, doMsgs)) {
                        case 6:
                            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.East);
                            break;
                        case 49:
                            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.West);
                            break;
                    }
                    ShowText(player, type, doMsgs, "The thief says, 'You have no key for passage. Return when you have the proper item.");
                    ShowText(player, type, doMsgs, "It would certainly be amazing if such as you could find the right item.'");
                }
            }
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, GNOMETHIEF);
            ShowText(player, type, doMsgs, "You bump into a young thief.");
            ShowText(player, type, doMsgs, "'Tis a far better thing to be understood than to be heard!");
            ShowText(player, type, doMsgs, "Confused?  Confounded?  Is there no one who knows a good clue when he hears it?'");
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 7, 1, 212, Direction.North);
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Vile creatures rise from the Snake Pit to attack you.");
            if (HasItem(player, type, doMsgs, HOLLOWEDNUNCHUKAS)) {
                SetTreasure(player, type, doMsgs, CUREALLPOTION, SILVERBAR, 0, 0, 0, 2000);
            }
            else {
                SetTreasure(player, type, doMsgs, HOLLOWEDNUNCHUKAS, HARMSWAY, 0, 0, 0, 2000);
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 39);
                AddEncounter(player, type, doMsgs, 02, 5);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 39);
                AddEncounter(player, type, doMsgs, 02, 39);
                AddEncounter(player, type, doMsgs, 03, 25);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 39);
                AddEncounter(player, type, doMsgs, 02, 39);
                AddEncounter(player, type, doMsgs, 03, 25);
                AddEncounter(player, type, doMsgs, 04, 25);
                AddEncounter(player, type, doMsgs, 05, 5);
                AddEncounter(player, type, doMsgs, 06, 5);
            }
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasUsedSkill(player, type, ref doMsgs, DETECT_SKILL) >= 6 || HasUsedSpell(player, type, ref doMsgs, TRUE_SEEING_SPELL) >= 1 || UsedItem(player, type, ref doMsgs, HELMOFWISDOM, HELMOFWISDOM) || UsedItem(player, type, ref doMsgs, VALKYRIESHELM, VALKYRIESHELM) || UsedItem(player, type, ref doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || UsedItem(player, type, ref doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                ShowText(player, type, doMsgs, "You discover a door in the wall.");
                PlaceDoor(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                ShowText(player, type, doMsgs, "You notice strange markings resembling a code on the wall.");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            ShowText(player, type, doMsgs, "You step into a dark alley.");
            ShowText(player, type, doMsgs, "The cold steel of a thief's stiletto in your back cuts your odds of surviving this ambush!");
            DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 3);
            for (i = 1; i <= 2; i++) {
                AddEncounter(player, type, doMsgs, i, 40);
            }
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "To the Ballroom");
            TeleportParty(player, type, doMsgs, 4, 1, 172, Direction.South);
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                ShowText(player, type, doMsgs, "You may rejoin your party.");
            }
            else {
                TeleportParty(player, type, doMsgs, 7, 1, 59, Direction.East);
            }
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetAttribute(player, type, doMsgs, STRENGTH) >= 19) {
                WallClear(player, type, doMsgs);
                PlaceDoor(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The stubborn door finally yields, and you push it open.");
            }
            else {
                WallBlock(player, type, doMsgs);
                ShowText(player, type, doMsgs, "You lack the strength to push open the door.");
            }
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "To the Cellar");
            TeleportParty(player, type, doMsgs, 6, 1, 21, Direction.North);
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ROPE_FLAG) == 1) {
                if (GetPartyCount(player, type, doMsgs) == 1) {
                    WallClear(player, type, doMsgs);
                    PlaceDoor(player, type, doMsgs);
                    ShowText(player, type, doMsgs, "Your clever exchange of lockpicks now offers you a secret entrance into the Ballroom.");
                }
                else {
                    WallBlock(player, type, doMsgs);
                    ShowText(player, type, doMsgs, "You must proceed alone through this door.");
                }
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Fumes momentarily overcome you, leeching away your spellcasting ability.");
            ModifyMana(player, type, doMsgs,  - 300);
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 7, 1, 245, Direction.West);
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 7, 1, 113, Direction.North);
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 7, 1, 53, Direction.North);
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You disturb a sleeping thief.");
            ShowText(player, type, doMsgs, "He gets revenge by deftly picking your pocket and fleeing.");
            ModifyGold(player, type, doMsgs,  - 1000);
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, GNOMEWIZARD);
            ShowText(player, type, doMsgs, "An angry wizard grabs you by the lapel.");
            ShowText(player, type, doMsgs, "'I was turned away from the Cartography Shop because I only had three pieces of a map. I must keep searching!'");
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, SAPPHIRELOCKPICK)) {
                WallClear(player, type, doMsgs);
                PlaceDoor(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The glow from the Sapphire Lockpick reveals a door.");
            }
            else {
                WallBlock(player, type, doMsgs);
                ShowText(player, type, doMsgs, "You see footprints leading to the wall and disappearing, but you have no way through the obviously solid wall.");
            }
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You find a note from a fellow adventurer -");
            ShowText(player, type, doMsgs, "'My journey was fruitless because I lacked an Emerald Lockpick.'");
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 7, 1, 234, Direction.West);
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisablePartyJoining(player, type, doMsgs);
            ShowText(player, type, doMsgs, "You walk through the passage and step confidently onto Tipekans' Bridge.");
            if (GetPartyCount(player, type, doMsgs) > 1) {
                ShowText(player, type, doMsgs, "The bridge collapses under the weight of your party and you plunge to your death.");
                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
            }
            else {
                ShowText(player, type, doMsgs, "You manage to grab hold of an extending beam as the bridge collapses beneath you. The door here, unfortunately, is sealed forever shut.");
                ShowText(player, type, doMsgs, "As you try to swing back across, you lose your grip and hurl downwards into darkness!");
                ShowText(player, type, doMsgs, "Some mystical winds grab your body and pull you off into the Cloister!");
                TeleportParty(player, type, doMsgs, 6, 1, 89, Direction.South);
            }
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (UsedItem(player, type, ref doMsgs, DIAMONDLOCKPICK, DIAMONDLOCKPICK)) {
                WallClear(player, type, doMsgs);
                PlaceDoor(player, type, doMsgs);
                ShowText(player, type, doMsgs, "You open the door with your Diamond Lockpick.");
            }
            else {
                WallBlock(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The locked door has a diamond-shaped keyhole.");
            }
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 7, 1, 57, Direction.North);
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SNAKESKIN_MAP) == 1) {
                if (HasItem(player, type, doMsgs, SNAKESKINMAP)) {
                    ShowText(player, type, doMsgs, "You find nothing of interest. Your Ruby Lockpick suddenly crumbles into dust.");
                    RemoveItem(player, type, doMsgs, RUBYLOCKPICK);
                }
                else {
                    GiveItem(player, type, doMsgs, SNAKESKINMAP);
                    ShowText(player, type, doMsgs, "You find a map hastily drawn on a piece of snakeskin.");
                    ShowText(player, type, doMsgs, "The Snakeskin Map must be one of the four the Queen sent you to find.");
                    ShowText(player, type, doMsgs, "Your Ruby Lockpick mysteriously crumbles into dust.");
                    RemoveItem(player, type, doMsgs, RUBYLOCKPICK);
                }
            }
            else {
                GiveItem(player, type, doMsgs, SNAKESKINMAP);
                GiveItem(player, type, doMsgs, BARBARIANSHELM);
                GiveItem(player, type, doMsgs, HELMOFWISDOM);
                GiveItem(player, type, doMsgs, ZEUSSCROLL);
                ModifyExperience(player, type, doMsgs, 200000);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SNAKESKIN_MAP, 1);
                ShowText(player, type, doMsgs, "You find a map hastily drawn on a piece of snakeskin.");
                ShowText(player, type, doMsgs, "The Snakeskin Map must be one of the four Queen Aeowyn has sent you to find.");
                ShowText(player, type, doMsgs, "Your Ruby Lockpick mysteriously crumbles into dust.");
                RemoveItem(player, type, doMsgs, RUBYLOCKPICK);
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "On the floor you find a page from an old journal.");
            ShowText(player, type, doMsgs, "It recounts the story of an adventurer who gained great wisdom by discovering a map piece.");
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ROPE_FLAG) == 1) {
                if (HasItem(player, type, doMsgs, ROPE)) {
                    ShowText(player, type, doMsgs, "A wandering band of thieves overcomes you. They steal your lockpick.");
                    RemoveItem(player, type, doMsgs, SAPPHIRELOCKPICK);
                }
                else if (HasItem(player, type, doMsgs, SAPPHIRELOCKPICK)) {
                    GiveItem(player, type, doMsgs, ROPE);
                    ShowText(player, type, doMsgs, "You are attacked by thieves who bind you with rope.");
                    ShowText(player, type, doMsgs, "The leader pilfers your lockpick.");
                    ShowText(player, type, doMsgs, "You eventually manage to free yourself, and you tuck the rope away.");
                    RemoveItem(player, type, doMsgs, SAPPHIRELOCKPICK);
                }
            }
            else {
                if (HasItem(player, type, doMsgs, SAPPHIRELOCKPICK)) {
                    RemoveItem(player, type, doMsgs, SAPPHIRELOCKPICK);
                    ModifyExperience(player, type, doMsgs, 50000);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ROPE_FLAG, 1);
                    ShowText(player, type, doMsgs, "You are attacked by thieves who bind you with rope.");
                    ShowText(player, type, doMsgs, "The leader pilfers your lockpick.");
                    ShowText(player, type, doMsgs, "You eventually manage to free yourself, and you tuck the rope away.");
                    GiveItem(player, type, doMsgs, ROPE);
                }
                else {
                    ShowText(player, type, doMsgs, "A wandering band of thieves ignores you since you have nothing of value.");
                }
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 7, 1, 199, Direction.East);
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, TROLLRANGER);
            if (HasItem(player, type, doMsgs, DIAMONDLOCKPICK)) {
                GiveItem(player, type, doMsgs, SAPPHIRELOCKPICK);
                ShowText(player, type, doMsgs, "A Troll Ranger drags you into the shadows.");
                ShowText(player, type, doMsgs, "'I assume you found the note about the Emerald Lockpick I left by the entrance.");
                ShowText(player, type, doMsgs, "Congratulations on your success so far!");
                ShowText(player, type, doMsgs, "My reward for helping you is the Diamond Lockpick you possess - or used to possess, anyway.");
                ShowText(player, type, doMsgs, "Take this Sapphire Lockpick in exchange. Though less valuable, it has the magical property to help you see things not readily apparent to the eye.'");
                RemoveItem(player, type, doMsgs, DIAMONDLOCKPICK);
            }
            else {
                ShowText(player, type, doMsgs, "A Troll Ranger twirls a sparkling blue lockpick.");
                ShowText(player, type, doMsgs, "'I left a note by the entrance. It concerns an Emerald Lockpick.");
                ShowText(player, type, doMsgs, "Heed its warning well, and you will be well rewarded.'");
            }
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "In the distance you hear the wail of a madman -");
            ShowText(player, type, doMsgs, "'Hither and yonder I have searched! Nowhere, nowhere could I find that lovely little map writ large upon a parchment!'");
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 7, 1, 28, Direction.North);
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 7, 1, 151, Direction.East);
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, GREMLINCLERIC);
            if ((HasItem(player, type, doMsgs, EMERALDLOCKPICK)) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TNEPRES) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TNEPRES) == 2)) {
                GiveItem(player, type, doMsgs, DIAMONDLOCKPICK);
                ShowText(player, type, doMsgs, "A Gremlin Cleric slaps you resoundingly on the back.");
                ShowText(player, type, doMsgs, "'Well done! You've found my lost Emerald Lockpick.");
                ShowText(player, type, doMsgs, "I can't thank you enough for helping me!");
                ShowText(player, type, doMsgs, "Please accept this Diamond Lockpick for your troubles.'");
                RemoveItem(player, type, doMsgs, EMERALDLOCKPICK);
            }
            else {
                ShowText(player, type, doMsgs, "A Gremlin Cleric is searching in the dust.");
                ShowText(player, type, doMsgs, "'I lost my beautiful Emerald Lockpick.");
                ShowText(player, type, doMsgs, "If you retrieve it, I will reward you most handsomely.");
                ShowText(player, type, doMsgs, "Remember, however, that you must be a registered visitor to Tipekans.'");
            }
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HALFLINGKNIGHT);
            ShowText(player, type, doMsgs, "An exasperated Halfling waves a piece of leather.");
            ShowText(player, type, doMsgs, "'The Races! What an aptly named place it was, since only certain races can enter certain rooms.");
            ShowText(player, type, doMsgs, "I wish I had discovered that fact sooner. But, eventually, I did find the two doors for my race.'");
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TNEPRES) == 0) {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You overhear two thieves talking about how clever Sneer, Smug and Smirk are in preventing bothersome adventurers from gaining access into the center of Tipekans.");
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, DWARFKNIGHT);
            ShowText(player, type, doMsgs, "A Dwarf Knight walks up to you. He rubs his head.");
            ShowText(player, type, doMsgs, "'I'm looking for a temple to take care of this wound!");
            ShowText(player, type, doMsgs, "My journey has taken me to a strange place. Not one wall did I see, yet I could not advance. It was pure pandemonium.'");
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TNEPRES) == 1) {
                GiveItem(player, type, doMsgs, PLATINUMBAR);
                GiveItem(player, type, doMsgs, THIEVESFLUTE);
                GiveItem(player, type, doMsgs, HEALAMPHORA);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TNEPRES, 2);
                ShowText(player, type, doMsgs, "You find a secret hiding place in which the thieves of Tipekans store their ill-gotten goods.");
            }
            else {
                ShowText(player, type, doMsgs, "What used to be a hiding place for stolen loot is now empty.");
            }
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 7, 1, 125, Direction.North);
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
            ModifyHealth(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
            ModifyMana(player, type, doMsgs, 10000);
            ShowText(player, type, doMsgs, "The cascading waters of Viper Fountain heal your wounds and restore your mana.");
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You stumble upon a weird assortment of scavengers.");
            if (HasItem(player, type, doMsgs, SCROLLOFDEATH)) {
                SetTreasure(player, type, doMsgs, CRYSTALSCROLL, LEATHERJACKET, 0, 0, 0, 1000);
            }
            else {
                SetTreasure(player, type, doMsgs, SCROLLOFDEATH, LEATHERJACKET, 0, 0, 0, 2500);
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 33);
                AddEncounter(player, type, doMsgs, 02, 34);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 33);
                AddEncounter(player, type, doMsgs, 02, 34);
                AddEncounter(player, type, doMsgs, 03, 5);
                AddEncounter(player, type, doMsgs, 04, 24);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 33);
                AddEncounter(player, type, doMsgs, 02, 33);
                AddEncounter(player, type, doMsgs, 03, 4);
                AddEncounter(player, type, doMsgs, 04, 39);
                AddEncounter(player, type, doMsgs, 05, 30);
                AddEncounter(player, type, doMsgs, 06, 31);
            }
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, WRAITH);
            ShowText(player, type, doMsgs, "You surprise a wraith who seems to be dancing.");
            ShowText(player, type, doMsgs, "'Oh! You startled me. I was just recalling the wondrous sounds of music that used to fill these corridors.");
            ShowText(player, type, doMsgs, "I was sure there was a door somewhere along here to the Ballroom.'");
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A flash of steel is quickly doused as you near a shadowy alley.");
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 16);
                AddEncounter(player, type, doMsgs, 02, 18);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 16);
                AddEncounter(player, type, doMsgs, 02, 15);
                AddEncounter(player, type, doMsgs, 03, 19);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 16);
                AddEncounter(player, type, doMsgs, 02, 16);
                AddEncounter(player, type, doMsgs, 03, 19);
                AddEncounter(player, type, doMsgs, 04, 35);
                AddEncounter(player, type, doMsgs, 05, 37);
            }
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 9);
                AddEncounter(player, type, doMsgs, 02, 7);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 7);
                AddEncounter(player, type, doMsgs, 02, 23);
                AddEncounter(player, type, doMsgs, 05, 9);
                AddEncounter(player, type, doMsgs, 06, 11);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 29);
                AddEncounter(player, type, doMsgs, 02, 29);
                AddEncounter(player, type, doMsgs, 04, 32);
                AddEncounter(player, type, doMsgs, 06, 32);
            }
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 26);
                AddEncounter(player, type, doMsgs, 02, 28);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 28);
                AddEncounter(player, type, doMsgs, 02, 28);
                AddEncounter(player, type, doMsgs, 05, 26);
                AddEncounter(player, type, doMsgs, 06, 26);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 28);
                AddEncounter(player, type, doMsgs, 02, 28);
                AddEncounter(player, type, doMsgs, 03, 5);
                AddEncounter(player, type, doMsgs, 04, 5);
                AddEncounter(player, type, doMsgs, 06, 26);
            }
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 13);
                AddEncounter(player, type, doMsgs, 02, 33);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 12);
                AddEncounter(player, type, doMsgs, 02, 13);
                AddEncounter(player, type, doMsgs, 03, 14);
                AddEncounter(player, type, doMsgs, 04, 14);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 12);
                AddEncounter(player, type, doMsgs, 02, 13);
                AddEncounter(player, type, doMsgs, 03, 33);
                AddEncounter(player, type, doMsgs, 05, 34);
                AddEncounter(player, type, doMsgs, 06, 34);
            }
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 19);
                AddEncounter(player, type, doMsgs, 02, 37);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 18);
                AddEncounter(player, type, doMsgs, 02, 16);
                AddEncounter(player, type, doMsgs, 03, 19);
                AddEncounter(player, type, doMsgs, 04, 37);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 19);
                AddEncounter(player, type, doMsgs, 02, 19);
                AddEncounter(player, type, doMsgs, 04, 38);
                AddEncounter(player, type, doMsgs, 05, 17);
                AddEncounter(player, type, doMsgs, 06, 15);
            }
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 6);
                AddEncounter(player, type, doMsgs, 02, 9);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 6);
                AddEncounter(player, type, doMsgs, 02, 8);
                AddEncounter(player, type, doMsgs, 04, 28);
                AddEncounter(player, type, doMsgs, 05, 11);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 28);
                AddEncounter(player, type, doMsgs, 02, 29);
                AddEncounter(player, type, doMsgs, 04, 8);
                AddEncounter(player, type, doMsgs, 05, 32);
                AddEncounter(player, type, doMsgs, 06, 32);
            }
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 28);
                AddEncounter(player, type, doMsgs, 02, 37);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 28);
                AddEncounter(player, type, doMsgs, 02, 28);
                AddEncounter(player, type, doMsgs, 03, 26);
                AddEncounter(player, type, doMsgs, 04, 37);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 28);
                AddEncounter(player, type, doMsgs, 02, 28);
                AddEncounter(player, type, doMsgs, 03, 38);
                AddEncounter(player, type, doMsgs, 05, 26);
                AddEncounter(player, type, doMsgs, 06, 26);
            }
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    AddEncounter(player, type, doMsgs, 01, 27);
                    AddEncounter(player, type, doMsgs, 02, 35);
                    break;
                case 2:
                    AddEncounter(player, type, doMsgs, 01, 35);
                    AddEncounter(player, type, doMsgs, 02, 36);
                    AddEncounter(player, type, doMsgs, 05, 27);
                    AddEncounter(player, type, doMsgs, 06, 27);
                    break;
                default:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 36);
                    }
                    for (i = 3; i <= 4; i++) {
                        AddEncounter(player, type, doMsgs, i, 35);
                    }
                    for (i = 5; i <= 6; i++) {
                        AddEncounter(player, type, doMsgs, i, 27);
                    }
                    break;
            }
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "An unsturdy bridge leads eastward towards an ancient door covered in lichens. The fragile bridge creaks warningly as you approach.");
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void WallClear(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void PlaceDoor(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
    }
}
