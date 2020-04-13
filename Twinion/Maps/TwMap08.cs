using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    /// <summary>
    /// L3: Queen's Palace
    /// </summary>
    class TwMap08 : TwMap {
        public override int MapIndex => 8;
        public override int MapID => 0x0401;
        protected override int RandomEncounterChance => 5;
        protected override int RandomEncounterExtraCount => 1;

        private const int DETECTED_DOOR = 6;
        private const int SUNSET = 7;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SNOWY) == 1) {
                RemoveItem(player, type, doMsgs, ROPE);
                ShowText(player, type, doMsgs, "The chill waters of Snowy Fountain are refreshing.");
                ShowText(player, type, doMsgs, "Your rope falls into the water.");
            }
            else if (HasItem(player, type, doMsgs, ROPE)) {
                RemoveItem(player, type, doMsgs, ROPE);
                ShowText(player, type, doMsgs, "Your rope falls into the water.");
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SNOWY, 1);
                if (GetGuild(player, type, doMsgs) == BARBARIAN || GetGuild(player, type, doMsgs) == RANGER || GetGuild(player, type, doMsgs) == THIEF || GetGuild(player, type, doMsgs) == WIZARD) {
                    if ((GetSkill(player, type, doMsgs, SWORDSMANSHIP_SKILL) == 0)) {
                        SetSkill(player, type, doMsgs, SWORDSMANSHIP_SKILL, 1);
                    }
                    ShowText(player, type, doMsgs, "The chill waters of Snowy Fountain enrich you with the Fencing skill.");
                }
                else if (GetGuild(player, type, doMsgs) == CLERIC || GetGuild(player, type, doMsgs) == KNIGHT) {
                    if ((GetSkill(player, type, doMsgs, CLUBS_AND_AXES_SKILL) == 0)) {
                        SetSkill(player, type, doMsgs, CLUBS_AND_AXES_SKILL, 1);
                    }
                    ShowText(player, type, doMsgs, "The chill waters of Snowy Fountain enrich you with the Clubs and Axes skill.");
                }
            }
            else {
                ShowText(player, type, doMsgs, "You must prove you have completed the Rope Quest to gain your skill.");
            }
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 6, 1, 89, Direction.South);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You step into a stream of lava.");
            DamXit(player, type, doMsgs);
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasUsedSkill(player, type, ref doMsgs, DETECT_SKILL) >= 5 || HasUsedSpell(player, type, ref doMsgs, TRUE_SEEING_SPELL) >= 1 || UsedItem(player, type, ref doMsgs, HELMOFWISDOM, HELMOFWISDOM) || UsedItem(player, type, ref doMsgs, VALKYRIESHELM, VALKYRIESHELM) || UsedItem(player, type, ref doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || UsedItem(player, type, ref doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                ShowText(player, type, doMsgs, "You discover a hidden door.");
                DoorHere(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You lose your footing and tumble down a slope, landing safely in the Infirmary.");
            TeleportParty(player, type, doMsgs, 5, 1, 61, Direction.West);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You step into a pit and fall to your death.");
            DamXit(player, type, doMsgs);
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int teleportRoom = 0;
            if (HasItem(player, type, doMsgs, ROPE)) {
                if (GetFacing(player, type, doMsgs) == Direction.West) {
                    teleportRoom = GetTile(player, type, doMsgs) - 2;
                    WallBlock(player, type, doMsgs);
                    ShowText(player, type, doMsgs, "By throwing the Rope over a protruding rock, you manage to swing across the pit.");
                    TeleportParty(player, type, doMsgs, 4, 1, teleportRoom, Direction.East);
                }
            }
            else if (UsedItem(player, type, ref doMsgs, SHORTSWORD, KEYOFC) || UsedItem(player, type, ref doMsgs, LIFEJACKET, UNITYRING)) {
                WallClear(player, type, doMsgs);
                ShowText(player, type, doMsgs, "Nothing extraordinary happens.");
            }
            else {
                WallClear(player, type, doMsgs);
                ShowText(player, type, doMsgs, "A pit blocks your passage to the west.");
                ShowText(player, type, doMsgs, "You notice a protruding rock above the pit.");
            }
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasUsedSkill(player, type, ref doMsgs, DETECT_SKILL) >= 5 || HasUsedSpell(player, type, ref doMsgs, TRUE_SEEING_SPELL) >= 1 || UsedItem(player, type, ref doMsgs, HELMOFWISDOM, HELMOFWISDOM) || UsedItem(player, type, ref doMsgs, VALKYRIESHELM, VALKYRIESHELM) || UsedItem(player, type, ref doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || UsedItem(player, type, ref doMsgs, CRYSTALBALL, CRYSTALBALL) || IsFlagOn(player, type, doMsgs, FlagTypeTile, DETECTED_DOOR)) {
                SetFlag(player, type, doMsgs, FlagTypeTile, DETECTED_DOOR, 1);
                if (UsedItem(player, type, ref doMsgs, REDLOCKPICK, BLUELOCKPICK) || UsedItem(player, type, ref doMsgs, HELMOFGUILE, HELMOFGUILE) || HasUsedSkill(player, type, ref doMsgs, LOCKPICK_SKILL) >= 6) {
                    ShowText(player, type, doMsgs, "You successfully unlock the door.");
                    DoorHere(player, type, doMsgs);
                    WallClear(player, type, doMsgs);
                }
                else {
                    WallBlock(player, type, doMsgs);
                    DoorHere(player, type, doMsgs);
                    ShowText(player, type, doMsgs, "You detect a hidden door, but it is locked.");
                }
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You see a warning sign on the cliff.");
            ShowText(player, type, doMsgs, "'DANGER! Loose rocks. Proceed at your own risk.'");
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The door to the Armory has seen many a traveler pass, each in search of the secret rooms inside.");
            TeleportParty(player, type, doMsgs, 4, 3, 64, Direction.South);
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The gateway leads to the Statuary.");
            TeleportParty(player, type, doMsgs, 5, 1, 238, Direction.West);
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A few walls in this area seem to have been altered by some construction.");
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 6, 1, 72, Direction.North);
            ShowText(player, type, doMsgs, "To the Cellar");
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "As you search the cave, you are startled by bats.");
            if (HasItem(player, type, doMsgs, PIPESOFENCHANTMENT)) {
                SetTreasure(player, type, doMsgs, READTRACKSTALISMAN, SCROLLOFPROTECTION, HALOSCROLL, 0, 0, 1000);
            }
            else {
                SetTreasure(player, type, doMsgs, PIPESOFENCHANTMENT, CRYSTALSCROLL, REFRESHALLSCROLL, 0, 0, 1500);
            }
            if (GetPartyCount(player, type, doMsgs) == 1 || GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 11);
                AddEncounter(player, type, doMsgs, 02, 11);
                AddEncounter(player, type, doMsgs, 05, 12);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 11);
                AddEncounter(player, type, doMsgs, 02, 12);
                AddEncounter(player, type, doMsgs, 03, 32);
                AddEncounter(player, type, doMsgs, 06, 33);
            }
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
             {
                if (HasItem(player, type, doMsgs, FRONTDOORKEY)) {
                    SetTreasure(player, type, doMsgs, BERSERKERTALISMAN, ELIXIROFHEALTH, 0, 0, 0, 1000);
                    ShowText(player, type, doMsgs, "You enter a cave crammed with hostile monsters.");
                }
                else {
                    SetTreasure(player, type, doMsgs, FRONTDOORKEY, HAWKSEYE, ELIXIROFHEALTH, 0, 0, 3000);
                    ShowText(player, type, doMsgs, "You inadvertantly join a battle over a key.");
                }
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 40);
                AddEncounter(player, type, doMsgs, 02, 22);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 40);
                AddEncounter(player, type, doMsgs, 02, 40);
                AddEncounter(player, type, doMsgs, 03, 22);
                AddEncounter(player, type, doMsgs, 04, 22);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 40);
                AddEncounter(player, type, doMsgs, 02, 40);
                AddEncounter(player, type, doMsgs, 03, 38);
                AddEncounter(player, type, doMsgs, 04, 38);
                AddEncounter(player, type, doMsgs, 05, 22);
                AddEncounter(player, type, doMsgs, 06, 22);
            }
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == THIEF) {
                ShowText(player, type, doMsgs, "As you turn to leave, Snicker slips you a note saying - ");
                ShowText(player, type, doMsgs, "'A dark and dangerous place hides your key to rewards.'");
            }
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Path to Tipekans' Bridge.");
            TeleportParty(player, type, doMsgs, 7, 1, 161, Direction.East);
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "On the the plaque you see OT.");
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, MAZEKEY)) {
                EmptyRoom(player, type, doMsgs);
            }
            else {
                GiveItem(player, type, doMsgs, MAZEKEY);
                ShowText(player, type, doMsgs, "In a corner of this otherwise empty room you find a key.");
                ShowText(player, type, doMsgs, "The key bears the initials M.A.Z.E.");
            }
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LABY_ONE_GOLD) == 0) {
                ModifyGold(player, type, doMsgs, 5000);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LABY_ONE_GOLD, 1);
                ShowText(player, type, doMsgs, "You find 5,000 gold pieces behind a wooden vat, which was used to store the Vineyard grapes.");
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LABY_ONE_GOLD) == 1 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SLATE_MAP) == 1) {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.LABY_ONE_GOLD, 2);
                GiveItem(player, type, doMsgs, NIGHTELFHELM);
                GiveItem(player, type, doMsgs, MIRROREDGEMSTONE);
                ShowText(player, type, doMsgs, "You see a reflection in the light and pick up items an unlucky adventurer must have dropped.");
                ShowText(player, type, doMsgs, "The items are useful, but are not particularly important to your quest.");
            }
            else {
                ShowText(player, type, doMsgs, "The room is empty except for some wooden vats.");
            }
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == KNIGHT) {
                if (HasItem(player, type, doMsgs, SKELETONKEY)) {
                    EmptyRoom(player, type, doMsgs);
                }
                else if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARMORY_ITEM) == 1) {
                    GiveItem(player, type, doMsgs, SKELETONKEY);
                    ShowText(player, type, doMsgs, "You find a key which may open seemingly impassable doors in your race to finish Queen Aeowyn's Map Quest.");
                    Skey(player, type, doMsgs);
                }
                else {
                    GiveItem(player, type, doMsgs, SKELETONKEY);
                    ShowText(player, type, doMsgs, "Your Guildmaster left you a special key that will give you access to magical armor.");
                    Skey(player, type, doMsgs);
                }
            }
            else {
                EmptyRoom(player, type, doMsgs);
            }
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasUsedSkill(player, type, ref doMsgs, DETECT_SKILL) >= 5 || HasUsedSpell(player, type, ref doMsgs, TRUE_SEEING_SPELL) >= 1 || UsedItem(player, type, ref doMsgs, HELMOFWISDOM, HELMOFWISDOM) || UsedItem(player, type, ref doMsgs, VALKYRIESHELM, VALKYRIESHELM) || UsedItem(player, type, ref doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || UsedItem(player, type, ref doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                ShowText(player, type, doMsgs, "A hidden door is revealed.");
                DoorHere(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (UsedItem(player, type, ref doMsgs, RUBYLOCKPICK, RUBYLOCKPICK)) {
                ShowText(player, type, doMsgs, "Sneer's guard hears you attempting to get in the back door and kills you.");
                DamXit(player, type, doMsgs);
            }
            else {
                ShowText(player, type, doMsgs, "You see the back door to Sneer's Pawn Shop.");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HALFLINGTHIEF);
            ShowText(player, type, doMsgs, "Sneer looks you over and notices your Ruby Lockpick. He motions you to continue to the north.");
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "On the plaque you see LALF.");
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, KEYOFC)) {
                ShowText(player, type, doMsgs, "The bard has already sung his tale.");
            }
            else {
                ShowPortrait(player, type, doMsgs, ELFCLERIC);
                GiveItem(player, type, doMsgs, KEYOFC);
                ShowText(player, type, doMsgs, "You meet a bard who is grateful for your attentiveness as he sings his tale. He expresses his gratitude with a gift of a special key.");
                ShowText(player, type, doMsgs, "'Music will open new doors for you,' the bard says.");
            }
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You disturb the spirits of long dead vintners.");
            if (HasItem(player, type, doMsgs, SCROLLOFSAFETY)) {
                SetTreasure(player, type, doMsgs, SCROLLOFTHESUN, BASALTSCROLL, 0, 0, 0, 1000);
            }
            else {
                SetTreasure(player, type, doMsgs, CURSEDSCROLL, SCROLLOFSAFETY, BLUELOCKPICK, 0, 0, 2000);
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 02, 5);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 5);
                AddEncounter(player, type, doMsgs, 02, 29);
                AddEncounter(player, type, doMsgs, 05, 30);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 28);
                AddEncounter(player, type, doMsgs, 02, 27);
                AddEncounter(player, type, doMsgs, 04, 9);
                AddEncounter(player, type, doMsgs, 05, 30);
                AddEncounter(player, type, doMsgs, 06, 31);
            }
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == KNIGHT) {
                ShowText(player, type, doMsgs, "A sign on the door says KNIGHTS ONLY.");
                DoorHere(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (UsedItem(player, type, ref doMsgs, RUBYLOCKPICK, RUBYLOCKPICK)) {
                WallClear(player, type, doMsgs);
                DoorHere(player, type, doMsgs);
                ShowText(player, type, doMsgs, "Sneer's is now open for business.");
            }
            else {
                WallBlock(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The entrance to Sneer's Pawn Shop is locked.");
            }
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "On the plaque you see SRAHMC.");
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You plunge into the pit and find yourself at the bottom of a secret shaft to the Vault.");
            TeleportParty(player, type, doMsgs, 5, 1, 135, Direction.South);
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You congratulate yourself on your choice. But your confidence turns to alarm as you feel yourself approaching the Fringe of Madness.");
            TeleportParty(player, type, doMsgs, 5, 1, 139, Direction.East);
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HUMANBARBARIAN);
            ShowText(player, type, doMsgs, "You meet an old seafarer.");
            ShowText(player, type, doMsgs, "'Beware of Lake Despair, matey. Many a foolhardy adventurer has sunk into its treacherous depths.");
            ShowText(player, type, doMsgs, "A special jacket helped me cross the lake once, but I lost it somewhere in the dungeon. Pity.'");
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, TROLLRANGER);
            ShowText(player, type, doMsgs, "You meet a friendly but puzzled ranger, 'This MUST be Clueless! Hmmm...I suspect a wizard has tampered with the clues in this area.' He shows you a parchment on which he has written SPAS.");
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, WRAITH);
            ShowText(player, type, doMsgs, "An apparition appears before you, 'I almost met my death while trying to squeeze past my stony friend who was concealing a shortcut to this place.");
            ShowText(player, type, doMsgs, "However, my statuesque form encountered its demise elsewhere.'");
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == WIZARD) {
                if (HasItem(player, type, doMsgs, SKELETONKEY)) {
                    EmptyRoom(player, type, doMsgs);
                }
                else if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARMORY_ITEM) == 1) {
                    GiveItem(player, type, doMsgs, SKELETONKEY);
                    ShowText(player, type, doMsgs, "You find a key which may open seemingly impassable doors in your race to finish Queen Aeowyn's Map Quest.");
                    Skey(player, type, doMsgs);
                }
                else {
                    GiveItem(player, type, doMsgs, SKELETONKEY);
                    ShowText(player, type, doMsgs, "Your Guildmaster left you a special key that will give you access to magical armor.");
                    Skey(player, type, doMsgs);
                }
            }
            else {
                EmptyRoom(player, type, doMsgs);
            }
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == WIZARD) {
                ShowText(player, type, doMsgs, "A sign on the door reads WIZARDS ONLY.");
                DoorHere(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HALFLINGTHIEF);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SNICKER) == 0) {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SNICKER, 1);
                ModifyGold(player, type, doMsgs,  - 1000);
                ShowText(player, type, doMsgs, "You meet a thief named Snicker, 'Three brothers have I, and courtesy is very important to all of them. One will show you the true path to what you seek. But all are fond of red gems.");
                ShowText(player, type, doMsgs, "In exchange for this information, you find your purse a little lighter.'");
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SNICKER) == 1) {
                GiveItem(player, type, doMsgs, RINGOFTHIEVES);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SNICKER, 2);
                ModifyGold(player, type, doMsgs,  - 5000);
                ShowText(player, type, doMsgs, "'Ah, my informants said you might return! You must learn to guard your pockets better. Since I've relieved you of your gold again, take this ring. It's magic will lead you to paths you might have missed without its magic.'");
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SNICKER) == 2 && HasItem(player, type, doMsgs, KEYOFC)) {
                GiveItem(player, type, doMsgs, IRONCROWN);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SNICKER, 3);
                ModifyGold(player, type, doMsgs,  - 5000);
                ShowText(player, type, doMsgs, "'Greetings! I have pil...acquired this from an adventurer who bragged about the protective properties of the crown. I've taken your gold, you might as well have it. I'm sure I'll happen upon another.'");
            }
            else {
                ShowText(player, type, doMsgs, "Snicker is busy helping himself to the goods of others.");
            }
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You can hear the rushing waters of Lake Despair.");
            TeleportParty(player, type, doMsgs, 5, 1, 147, Direction.North);
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A sign on the portal says, 'Entrance to the Gallery'.");
            TeleportParty(player, type, doMsgs, 6, 1, 195, Direction.West);
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You lose your footing on a loose rock and your bag of gold falls to the ground.");
            ShowText(player, type, doMsgs, "You manage to gather all but 1000 pieces, which fall through cracks in the floor.");
            ModifyGold(player, type, doMsgs,  - 1000);
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeTile, SUNSET) == 0) {
                FntnPic(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The dark waters of Sunset Fountain poison you when you attempt to refresh yourself.");
                SetDebuff(player, type, doMsgs, POISON, 5, GetHealthMax(player, type, doMsgs) / 10);
                SetFlag(player, type, doMsgs, FlagTypeTile, SUNSET, 1);
            }
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "On the plaque you see EPRY.");
        }
        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.WINDY) == 1) {
                ShowText(player, type, doMsgs, "The waters of Windy Fountain have no effect.");
                ShowText(player, type, doMsgs, "The Key of C falls into the fountain.");
                RemoveItem(player, type, doMsgs, KEYOFC);
            }
            else if (HasItem(player, type, doMsgs, KEYOFC)) {
                if (GetGuild(player, type, doMsgs) == THIEF) {
                    RemoveItem(player, type, doMsgs, KEYOFC);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.WINDY, 1);
                    SetSkill(player, type, doMsgs, MARTIAL_ARTS_SKILL, 1);
                    ShowText(player, type, doMsgs, "The waters of Windy Fountain endow you with the Martial Arts skill.");
                }
                else if (GetGuild(player, type, doMsgs) == BARBARIAN || GetGuild(player, type, doMsgs) == WIZARD) {
                    RemoveItem(player, type, doMsgs, KEYOFC);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.WINDY, 1);
                    SetSkill(player, type, doMsgs, INTIMIDATE_SKILL, 1);
                    ShowText(player, type, doMsgs, "The waters of Windy Fountain give you the powers to intimidate your enemies.");
                }
                else if (GetGuild(player, type, doMsgs) == RANGER || GetGuild(player, type, doMsgs) == CLERIC) {
                    RemoveItem(player, type, doMsgs, KEYOFC);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.WINDY, 1);
                    SetSkill(player, type, doMsgs, BARD_SKILL, 1);
                    ShowText(player, type, doMsgs, "The waters of Windy Fountain endow you with the Bard skill.");
                }
                else {
                    RemoveItem(player, type, doMsgs, KEYOFC);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.WINDY, 1);
                    SetSkill(player, type, doMsgs, ARCHERY_SKILL, 1);
                    ShowText(player, type, doMsgs, "The waters of Windy Fountain aid in your proficiency with a bow.");
                }
            }
            else {
                ShowText(player, type, doMsgs, "A gift from a bard makes these waters magical.");
            }
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (UsedItem(player, type, ref doMsgs, KEYOFC, KEYOFC)) {
                WallClear(player, type, doMsgs);
                DoorHere(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The Key of C unlocks this Ballroom door.");
            }
            else {
                WallBlock(player, type, doMsgs);
                ShowText(player, type, doMsgs, "You see a musical note on the locked door.");
            }
        }
        protected override void FnEvent3B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            ShowText(player, type, doMsgs, "The fresh waters of Sunrise Fountain restore your mana.");
            ModifyMana(player, type, doMsgs, 5000);
        }
        protected override void FnEvent3C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Enter the Rat Race.");
            TeleportParty(player, type, doMsgs, 6, 3, 241, Direction.West);
        }
        protected override void FnEvent3D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.MISTY) == 1) {
                RemoveItem(player, type, doMsgs, FRONTDOORKEY);
                ShowText(player, type, doMsgs, "The haze surrounding Misty Fountain has no further effect.");
                ShowText(player, type, doMsgs, "The Front Door Key disappears.");
            }
            else if (HasItem(player, type, doMsgs, FRONTDOORKEY)) {
                RemoveItem(player, type, doMsgs, FRONTDOORKEY);
                ShowText(player, type, doMsgs, "The Front Door Key disappears.");
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.MISTY, 1);
                if (GetGuild(player, type, doMsgs) == BARBARIAN || GetGuild(player, type, doMsgs) == CLERIC || GetGuild(player, type, doMsgs) == RANGER || GetGuild(player, type, doMsgs) == WIZARD) {
                    GiveSpell(player, type, doMsgs, TRUE_SEEING_SPELL, 1);
                    ShowText(player, type, doMsgs, "The haze surrounding Misty Fountain empowers you with the True Seeing spell.");
                }
                else if (GetGuild(player, type, doMsgs) == KNIGHT || GetGuild(player, type, doMsgs) == THIEF) {
                    GiveSpell(player, type, doMsgs, LIGHTNING_SPELL, 1);
                    ShowText(player, type, doMsgs, "The haze surrounding Misty Fountain empowers you with the Lightning spell.");
                }
            }
            else {
                ShowText(player, type, doMsgs, "A door key will channel the powers in the haze.");
            }
        }
        protected override void FnEvent3E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Where music once played, battle sounds now rage.");
            if (HasItem(player, type, doMsgs, IRONRING)) {
                SetTreasure(player, type, doMsgs, SCROLLOFPROTECTION, HALOSCROLL, 0, 0, 0, 1000);
            }
            else {
                SetTreasure(player, type, doMsgs, IRONRING, AURASCROLL, SCROLLOFTHESUN, 0, 0, 3000);
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 15);
                AddEncounter(player, type, doMsgs, 02, 21);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 15);
                AddEncounter(player, type, doMsgs, 02, 15);
                AddEncounter(player, type, doMsgs, 05, 21);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 15);
                AddEncounter(player, type, doMsgs, 02, 15);
                AddEncounter(player, type, doMsgs, 03, 19);
                AddEncounter(player, type, doMsgs, 05, 20);
                AddEncounter(player, type, doMsgs, 06, 22);
            }
        }
        protected override void FnEvent3F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "This is the Ingress to the Night Elves' Domain. The southern gateway will take you back to the Main Entrance.");
        }
        protected override void FnEvent40(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 1, 1, 222, Direction.North);
        }
        protected override void FnEvent41(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (UsedItem(player, type, ref doMsgs, FRONTDOORKEY, FRONTDOORKEY)) {
                WallClear(player, type, doMsgs);
                DoorHere(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The Front Door Key opens the door.");
            }
            else {
                WallBlock(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The front door is locked.");
            }
        }
        protected override void FnEvent44(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You find a sheet of music with a song written in the key of C. The lyrics tell of two areas where race is the key to discovering treasure.");
        }
        protected override void FnEvent47(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 28);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 5);
                AddEncounter(player, type, doMsgs, 02, 29);
                AddEncounter(player, type, doMsgs, 03, 27);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 28);
                AddEncounter(player, type, doMsgs, 02, 29);
                AddEncounter(player, type, doMsgs, 03, 29);
                AddEncounter(player, type, doMsgs, 04, 30);
                AddEncounter(player, type, doMsgs, 06, 31);
            }
        }
        protected override void FnEvent48(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 11);
                AddEncounter(player, type, doMsgs, 02, 16);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 12);
                AddEncounter(player, type, doMsgs, 02, 17);
                AddEncounter(player, type, doMsgs, 06, 18);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 13);
                AddEncounter(player, type, doMsgs, 02, 14);
                AddEncounter(player, type, doMsgs, 03, 32);
                AddEncounter(player, type, doMsgs, 05, 15);
                AddEncounter(player, type, doMsgs, 06, 18);
            }
        }
        protected override void FnEvent49(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 25);
                AddEncounter(player, type, doMsgs, 02, 26);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 25);
                AddEncounter(player, type, doMsgs, 02, 25);
                AddEncounter(player, type, doMsgs, 05, 35);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 25);
                AddEncounter(player, type, doMsgs, 02, 25);
                AddEncounter(player, type, doMsgs, 03, 34);
                AddEncounter(player, type, doMsgs, 04, 34);
                AddEncounter(player, type, doMsgs, 06, 37);
            }
        }
        protected override void FnEvent4A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 02, 11);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 3);
                AddEncounter(player, type, doMsgs, 02, 1);
                AddEncounter(player, type, doMsgs, 06, 12);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 3);
                AddEncounter(player, type, doMsgs, 02, 1);
                AddEncounter(player, type, doMsgs, 03, 1);
                AddEncounter(player, type, doMsgs, 05, 12);
                AddEncounter(player, type, doMsgs, 06, 13);
            }
        }
        protected override void FnEvent4B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 36);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 34);
                AddEncounter(player, type, doMsgs, 02, 37);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 36);
                AddEncounter(player, type, doMsgs, 02, 36);
                AddEncounter(player, type, doMsgs, 03, 37);
                AddEncounter(player, type, doMsgs, 04, 37);
                AddEncounter(player, type, doMsgs, 05, 22);
            }
        }
        protected override void FnEvent4C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 20);
                AddEncounter(player, type, doMsgs, 05, 21);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 20);
                AddEncounter(player, type, doMsgs, 02, 22);
                AddEncounter(player, type, doMsgs, 03, 21);
                AddEncounter(player, type, doMsgs, 06, 40);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 20);
                AddEncounter(player, type, doMsgs, 02, 22);
                AddEncounter(player, type, doMsgs, 03, 22);
                AddEncounter(player, type, doMsgs, 05, 40);
                AddEncounter(player, type, doMsgs, 06, 40);
            }
        }
        private void Skey(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The key is made of bone. The grasp is shaped like a skull and the shaft like two crossed, bony arms.");
        }
        private void EmptyRoom(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The room is empty.");
        }
        private void DoorHere(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void WallClear(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void DamXit(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void FntnPic(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
        }
    }
}
