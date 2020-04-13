using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    class TwMap14 : TwMap {
        public override int MapIndex => 14;
        public override int MapID => 0x0601;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 2;

        private const int DETECTED_DOOR = 1;
        private const int KEEPPIT = 2;
        private const int TROUGH = 3;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A voice from the shadows whispers, 'Ah, another adventurer seeking to be the Queen's Champion, no doubt.");
            ShowText(player, type, doMsgs, "One tip, youngling, there's a magical force that returns most Quest items back to where they came should you accidentally drop them.'");
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 6, 1, 40, Direction.West);
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You step into the hot lava.");
            DamXit(player, type, doMsgs);
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            ShowText(player, type, doMsgs, "The sweet waters of the Fountain of Nectar restore your mana.");
            ModifyMana(player, type, doMsgs, 10000);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Pass through this portal to Tipekans.");
            TeleportParty(player, type, doMsgs, 7, 1, 32, Direction.East);
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeTile, KEEPPIT) == 0) {
                ShowText(player, type, doMsgs, "The pit isn't as deep as you feared, but you injure your ankle.");
                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 10);
                SetFlag(player, type, doMsgs, FlagTypeTile, KEEPPIT, 1);
            }
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, DWARFWIZARD);
            ShowText(player, type, doMsgs, "You see a dwarf shaking her head. She turns to you and says, 'The graveyard is very dark. You must rely upon your wits and skills to get you through.");
            ShowText(player, type, doMsgs, "Having something that sheds a little light for you wouldn't hurt, either.'");
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((HasUsedSkill(player, type, ref doMsgs, DETECT_SKILL) >= 6 || HasUsedSpell(player, type, ref doMsgs, TRUE_SEEING_SPELL) >= 1 || UsedItem(player, type, ref doMsgs, HELMOFWISDOM, HELMOFWISDOM) || UsedItem(player, type, ref doMsgs, VALKYRIESHELM, VALKYRIESHELM) || UsedItem(player, type, ref doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || UsedItem(player, type, ref doMsgs, CRYSTALBALL, CRYSTALBALL)) || (IsFlagOn(player, type, doMsgs, FlagTypeTile, DETECTED_DOOR))) {
                SetFlag(player, type, doMsgs, FlagTypeTile, DETECTED_DOOR, 1);
                if (UsedItem(player, type, ref doMsgs, BLUELOCKPICK, BLUELOCKPICK) || UsedItem(player, type, ref doMsgs, HELMOFGUILE, HELMOFGUILE) || HasUsedSkill(player, type, ref doMsgs, LOCKPICK_SKILL) >= 6) {
                    DoorHere(player, type, doMsgs);
                    WallClear(player, type, doMsgs);
                    ShowText(player, type, doMsgs, "You successfully pick the lock.");
                }
                else {
                    WallBlock(player, type, doMsgs);
                    DoorHere(player, type, doMsgs);
                    ShowText(player, type, doMsgs, "A locked door appears in the wall.");
                }
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 6, 1, 13, Direction.East);
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 6, 1, 210, Direction.South);
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 5, 1, 70, Direction.East);
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 6, 1, 72, Direction.North);
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == BARBARIAN) {
                if (HasItem(player, type, doMsgs, SKELETONKEY)) {
                    ShowText(player, type, doMsgs, "The room is empty.");
                }
                else if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARMORY_ITEM) == 1) {
                    GiveItem(player, type, doMsgs, SKELETONKEY);
                    ShowText(player, type, doMsgs, "You find a key which may open seemingly impassable doors in your race to finish Queen Aeowyn's Map Quest.");
                    ShowText(player, type, doMsgs, "The key is made of bone and features a skull and crossed arm bones.");
                }
                else {
                    GiveItem(player, type, doMsgs, SKELETONKEY);
                    ShowText(player, type, doMsgs, "Your Guildmaster left you a special key that will give you access to magical armor.");
                    ShowText(player, type, doMsgs, "The key is made of bone. The grasp is shaped like a skull and the shaft like two crossed, bony arms.");
                }
            }
            else {
                ShowText(player, type, doMsgs, "The room is bare.");
            }
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You walk into a lair.");
            if (HasItem(player, type, doMsgs, SCROLLOFDEATH)) {
                SetTreasure(player, type, doMsgs, BLUELOCKPICK, SCROLLOFTHESUN, 0, 0, 0, 1000);
            }
            else {
                SetTreasure(player, type, doMsgs, BLUELOCKPICK, SCROLLOFDEATH, CURATIVEELIXIR, 0, 0, 3000);
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 02, 25);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 2);
                AddEncounter(player, type, doMsgs, 02, 3);
                AddEncounter(player, type, doMsgs, 06, 1);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 2);
                AddEncounter(player, type, doMsgs, 02, 2);
                AddEncounter(player, type, doMsgs, 03, 3);
                AddEncounter(player, type, doMsgs, 04, 4);
                AddEncounter(player, type, doMsgs, 05, 27);
            }
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HALFLINGCLERIC);
            ShowText(player, type, doMsgs, "A cleric pulls you aside and whispers, 'It is rumored that there are areas in the dungeon that can be accessed only by certain races or guilds.'");
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == BARBARIAN) {
                ShowText(player, type, doMsgs, "A sign on the door says, 'BARBARIANS ONLY.'");
                DoorHere(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A sign reads 'This path leads to Lake Despair.'");
            TeleportParty(player, type, doMsgs, 5, 1, 16, Direction.North);
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The opening of the ground may have affected the stability of the walls.");
            WallClear(player, type, doMsgs);
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "While admiring the plaques you are attacked.");
            if (HasItem(player, type, doMsgs, MANARESTORE)) {
                SetTreasure(player, type, doMsgs, MANAELIXIR, SHAMANSCROLL, 0, 0, 0, 1500);
            }
            else {
                SetTreasure(player, type, doMsgs, MANARESTORE, SCROLLOFTHESUN, 0, 0, 0, 3000);
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 8);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 5);
                AddEncounter(player, type, doMsgs, 02, 7);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 5);
                AddEncounter(player, type, doMsgs, 02, 6);
                AddEncounter(player, type, doMsgs, 04, 7);
                AddEncounter(player, type, doMsgs, 05, 9);
                AddEncounter(player, type, doMsgs, 06, 9);
            }
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You see a plaque on the wall. 'Welcome to the Gallery. Our ancient plaques are informative as well as decorative.'");
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You fall into the Snake Pit and to your death.");
            DamXit(player, type, doMsgs);
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You have entered the Cloister. Enjoy your respite on your way to the Gallery.");
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You are attacked by raptors!");
            if (HasItem(player, type, doMsgs, HEALALLPOTION)) {
                SetTreasure(player, type, doMsgs, ELIXIROFHEALTH, SCROLLOFPROTECTION, RINGOFTHIEVES, 0, 0, 1500);
            }
            else {
                SetTreasure(player, type, doMsgs, HEALALLPOTION, CURSEDSCROLL, HALOSCROLL, RINGOFTHIEVES, 0, 3000);
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 15);
                AddEncounter(player, type, doMsgs, 05, 32);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 15);
                AddEncounter(player, type, doMsgs, 02, 17);
                AddEncounter(player, type, doMsgs, 06, 32);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 16);
                AddEncounter(player, type, doMsgs, 02, 16);
                AddEncounter(player, type, doMsgs, 03, 17);
                AddEncounter(player, type, doMsgs, 04, 17);
                AddEncounter(player, type, doMsgs, 06, 32);
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Dark Alley awaits the unwary traveler. Step cautiously as you wander through the darkness.");
            TeleportParty(player, type, doMsgs, 5, 1, 182, Direction.South);
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "To the Vineyard.");
            TeleportParty(player, type, doMsgs, 4, 1, 57, Direction.South);
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You find a scrap of paper on the floor with a lost and found message: 'Reward offered for the return of a jeweled lockpick to Tipekans.'");
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "To the Statuary");
            TeleportParty(player, type, doMsgs, 5, 1, 199, Direction.East);
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasUsedSkill(player, type, ref doMsgs, DETECT_SKILL) >= 6 || HasUsedSpell(player, type, ref doMsgs, TRUE_SEEING_SPELL) >= 1 || UsedItem(player, type, ref doMsgs, HELMOFWISDOM, HELMOFWISDOM) || UsedItem(player, type, ref doMsgs, VALKYRIESHELM, VALKYRIESHELM) || UsedItem(player, type, ref doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || UsedItem(player, type, ref doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                ShowText(player, type, doMsgs, "A door appears in the wall.");
                DoorHere(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 5, 1, 8, Direction.South);
            ShowText(player, type, doMsgs, "To the Vault");
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Some of the walls appear to have been reconstructed.");
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == HUMAN) {
                ShowText(player, type, doMsgs, "The message on the plaque says, 'Use Tyndil's payment first.'");
            }
            else {
                ShowText(player, type, doMsgs, "The plaque is worn and unreadable.");
            }
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == DWARF) {
                ShowText(player, type, doMsgs, "The message on the plaque says, 'Save your Coral for last.'");
            }
            else {
                ShowText(player, type, doMsgs, "The plaque is cracked down the center.");
            }
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == HALFLING) {
                ShowText(player, type, doMsgs, "The message on the plaque says, 'Use your Ebony before your Opal.'");
            }
            else {
                ShowText(player, type, doMsgs, "You cannot read the plaque.");
            }
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The eerie sounds coming from the Graveyard make you wonder if you should step through this teleport.");
            TeleportParty(player, type, doMsgs, 5, 3, 15, Direction.West);
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Through this teleport you will find the Breezeway.");
            TeleportParty(player, type, doMsgs, 4, 1, 128, Direction.North);
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, RUBYLOCKPICK)) {
                if (GetPartyCount(player, type, doMsgs) == 1) {
                    ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                }
                else {
                    SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                    ShowText(player, type, doMsgs, "'Alone I said! It took me a long time to tunnel through this wall and it's only large enough for one!'");
                }
            }
            else {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ShowText(player, type, doMsgs, "Smirk grabs you by the collar before you can sneak through the door. 'Have you no sense? Return when you have the item I desire!'");
            }
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == TROLL) {
                ShowText(player, type, doMsgs, "The message on the plaque says, 'Don't give up your Pearl until last.'");
            }
            else {
                ShowText(player, type, doMsgs, "This plaque appears chipped.");
            }
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == RANGER) {
                if (HasItem(player, type, doMsgs, SKELETONKEY)) {
                    ShowText(player, type, doMsgs, "The room is empty.");
                }
                else if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARMORY_ITEM) == 1) {
                    GiveItem(player, type, doMsgs, SKELETONKEY);
                    ShowText(player, type, doMsgs, "You find a key which may open seemingly impassable doors in your race to finish Queen Aeowyn's Map Quest.");
                    ShowText(player, type, doMsgs, "The key is made of bone and features a skull and crossed arm bones.");
                }
                else {
                    GiveItem(player, type, doMsgs, SKELETONKEY);
                    ShowText(player, type, doMsgs, "Your Guildmaster left you a special key that will give you access to magical armor.");
                    ShowText(player, type, doMsgs, "The key is made of bone. The grasp is shaped like a skull and the shaft like two crossed, bony arms.");
                }
            }
            else {
                ShowText(player, type, doMsgs, "The room is bare.");
            }
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == RANGER) {
                ShowText(player, type, doMsgs, "A sign on the door says, 'RANGERS ONLY.'");
                DoorHere(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            if (GetGuild(player, type, doMsgs) == WIZARD) {
                if (GetSkill(player, type, doMsgs, ARCHERY_SKILL) == 0) {
                    SetSkill(player, type, doMsgs, ARCHERY_SKILL, 1);
                    ShowText(player, type, doMsgs, "Journey's End Fountain endows you with the Archery skill.");
                }
                else {
                    Jtxt(player, type, doMsgs);
                }
            }
            else if (GetGuild(player, type, doMsgs) == KNIGHT || GetGuild(player, type, doMsgs) == THIEF || GetGuild(player, type, doMsgs) == RANGER) {
                if (GetSkill(player, type, doMsgs, ATHLETICS_SKILL) == 0) {
                    SetSkill(player, type, doMsgs, ATHLETICS_SKILL, 1);
                    ShowText(player, type, doMsgs, "Journey's End Fountain endows you with the Athletics skill.");
                }
                else {
                    Jtxt(player, type, doMsgs);
                }
            }
            else if (GetGuild(player, type, doMsgs) == CLERIC) {
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.BLESSCLERIC) == 0)) {
                    GiveSpell(player, type, doMsgs, BLESS_SPELL, 1);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.BLESSCLERIC, 1);
                    ShowText(player, type, doMsgs, "Journey's End Fountain endows you with the Bless spell.");
                }
                else {
                    Jtxt(player, type, doMsgs);
                }
            }
            else {
                ShowText(player, type, doMsgs, "Journey's End Fountain is dry.");
            }
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, TROLLKNIGHT);
            ShowText(player, type, doMsgs, "You meet a Cavalier who says, 'I've heard tell of a special lantern that has proven very helpful in opening a certain door.");
            ShowText(player, type, doMsgs, "The door is somewhere in the dark, or so I'm told.'");
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (UsedItem(player, type, ref doMsgs, RUBYLOCKPICK, RUBYLOCKPICK)) {
                WallClear(player, type, doMsgs);
                DoorHere(player, type, doMsgs);
                ShowText(player, type, doMsgs, "Smirk waves you inside.");
            }
            else {
                WallBlock(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The entrance to Smirk's Emporium is locked.");
            }
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 7, 1, 218, Direction.North);
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == GNOME) {
                ShowText(player, type, doMsgs, "The message on the plaque says, 'Use Syrene's payment as your last choice.'");
            }
            else {
                ShowText(player, type, doMsgs, "The plaque is worn and unreadable.");
            }
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeTile, TROUGH) == 0) {
                FntnPic(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The stagnant waters of the Trough are poisonous!");
                SetDebuff(player, type, doMsgs, POISON, 10, GetHealthMax(player, type, doMsgs) / 10);
                SetFlag(player, type, doMsgs, FlagTypeTile, TROUGH, 1);
            }
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HALFLINGCLERIC);
            ShowText(player, type, doMsgs, "A monk breaks his silence and whispers, 'Search well, for there are places in the dungeon where your attributes can be enhanced.'");
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, LUMINOUSLANTERN)) {
                RemoveItem(player, type, doMsgs, LUMINOUSLANTERN);
                GiveItem(player, type, doMsgs, SNAKECHARM);
                ShowText(player, type, doMsgs, "The Luminous Lantern fades and disappears as you catch a glimpse of a magical talisman.");
            }
            else {
                ShowText(player, type, doMsgs, "The room is too dark for you to see. A portable light would prove most useful here,");
            }
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisablePartyJoining(player, type, doMsgs);
            ShowPortrait(player, type, doMsgs, HALFLINGTHIEF);
            if (HasItem(player, type, doMsgs, RUBYLOCKPICK)) {
                ShowText(player, type, doMsgs, "I see you have brought the lockpick.  Continue through the door to the east alone and you will find your promised reward.");
            }
            else {
                ShowText(player, type, doMsgs, "Smirk cautions you not to go beyond this point without the lockpick.");
            }
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == ORC) {
                ShowText(player, type, doMsgs, "The message on the plaque says, 'If given a choice, use the Opal second.'");
            }
            else {
                ShowText(player, type, doMsgs, "The plaque is cracked down the center.");
            }
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == ELF) {
                ShowText(player, type, doMsgs, "The message on the plaque says, 'Use your Opal before your Coral.'");
            }
            else {
                ShowText(player, type, doMsgs, "The etchings on the plaque are unintelligible.");
            }
        }
        protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == GREMLIN) {
                ShowText(player, type, doMsgs, "The message on the plaque says, 'Use Tyndil's payment third.'");
            }
            else {
                ShowText(player, type, doMsgs, "You see nothing of interest on the plaque.");
            }
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 6, 1, 161, Direction.West);
        }
        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            FntnPic(player, type, doMsgs);
            ShowText(player, type, doMsgs, "Equestrian Fountain rejuvenates your health and mana.");
            HealFtn(player, type, doMsgs);
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, TROLLKNIGHT);
            ShowText(player, type, doMsgs, "'Once you have the four map pieces the Queen seeks, make sure you know the order of the jewels before you seek your reward.");
            ShowText(player, type, doMsgs, "Three clues are available for each race. I have found two and am now after the third. You must read all three clues, or you will not be rewarded.'");
        }
        protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (UsedItem(player, type, ref doMsgs, RUBYLOCKPICK, RUBYLOCKPICK)) {
                ShowText(player, type, doMsgs, "You are killed by Smirk who mistakes you for a robber.");
                DamXit(player, type, doMsgs);
            }
            else {
                ShowText(player, type, doMsgs, "Back door to Smirk's Emporium.");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent3B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HALFLINGKNIGHT);
            ShowText(player, type, doMsgs, "'I was told that in this area there are hidden rooms. A few rooms are available only to specific guilds.");
            ShowText(player, type, doMsgs, "Beyond one hidden door is a second secretive door. That door leads to... Well, I think you should discover where that door leads.'");
        }
        protected override void FnEvent3C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, LIFEJACKET)) {
                SetTreasure(player, type, doMsgs, BERSERKERTALISMAN, CHAINMAIL, 0, 0, 0, 1000);
            }
            else {
                SetTreasure(player, type, doMsgs, LIFEJACKET, 0, 0, 0, 0, 3000);
                ShowText(player, type, doMsgs, "You see a group of monsters tearing at a life jacket.");
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 2);
                AddEncounter(player, type, doMsgs, 02, 7);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 02, 3);
                AddEncounter(player, type, doMsgs, 05, 7);
                AddEncounter(player, type, doMsgs, 06, 8);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 3);
                AddEncounter(player, type, doMsgs, 02, 3);
                AddEncounter(player, type, doMsgs, 03, 1);
                AddEncounter(player, type, doMsgs, 04, 1);
                AddEncounter(player, type, doMsgs, 05, 8);
                AddEncounter(player, type, doMsgs, 06, 9);
            }
        }
        protected override void FnEvent3D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You can see it's a long, hard climb up to Cliffhanger.");
            TeleportParty(player, type, doMsgs, 4, 1, 127, Direction.West);
        }
        protected override void FnEvent40(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The Wine Cellar is dark and damp.");
        }
        protected override void FnEvent41(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 20);
                AddEncounter(player, type, doMsgs, 02, 26);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 26);
                AddEncounter(player, type, doMsgs, 02, 26);
                AddEncounter(player, type, doMsgs, 03, 39);
                AddEncounter(player, type, doMsgs, 04, 40);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 21);
                AddEncounter(player, type, doMsgs, 02, 38);
                AddEncounter(player, type, doMsgs, 04, 38);
                AddEncounter(player, type, doMsgs, 05, 39);
                AddEncounter(player, type, doMsgs, 06, 40);
            }
        }
        protected override void FnEvent42(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 15);
                AddEncounter(player, type, doMsgs, 02, 32);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 16);
                AddEncounter(player, type, doMsgs, 02, 17);
                AddEncounter(player, type, doMsgs, 06, 11);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 16);
                AddEncounter(player, type, doMsgs, 02, 16);
                AddEncounter(player, type, doMsgs, 03, 17);
                AddEncounter(player, type, doMsgs, 05, 14);
                AddEncounter(player, type, doMsgs, 06, 10);
            }
        }
        protected override void FnEvent43(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 14);
                AddEncounter(player, type, doMsgs, 02, 28);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 13);
                AddEncounter(player, type, doMsgs, 02, 14);
                AddEncounter(player, type, doMsgs, 04, 31);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 13);
                AddEncounter(player, type, doMsgs, 02, 13);
                AddEncounter(player, type, doMsgs, 03, 14);
                AddEncounter(player, type, doMsgs, 04, 14);
                AddEncounter(player, type, doMsgs, 06, 33);
            }
        }
        protected override void FnEvent44(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 29);
                AddEncounter(player, type, doMsgs, 02, 29);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 1, 6);
                AddEncounter(player, type, doMsgs, 2, 7);
                AddEncounter(player, type, doMsgs, 6, 36);
            }
            else if (GetPartyCount(player, type, doMsgs) == 3) {
                AddEncounter(player, type, doMsgs, 1, 5);
                AddEncounter(player, type, doMsgs, 2, 6);
                AddEncounter(player, type, doMsgs, 3, 21);
                AddEncounter(player, type, doMsgs, 4, 19);
                AddEncounter(player, type, doMsgs, 5, 20);
            }
            else {
                AddEncounter(player, type, doMsgs, 1, 5);
                AddEncounter(player, type, doMsgs, 2, 6);
                AddEncounter(player, type, doMsgs, 3, 37);
                AddEncounter(player, type, doMsgs, 4, 38);
                AddEncounter(player, type, doMsgs, 5, 40);
                AddEncounter(player, type, doMsgs, 6, 40);
            }
        }
        protected override void FnEvent45(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 02, 1);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 2);
                AddEncounter(player, type, doMsgs, 02, 2);
                AddEncounter(player, type, doMsgs, 06, 15);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 2);
                AddEncounter(player, type, doMsgs, 02, 3);
                AddEncounter(player, type, doMsgs, 03, 16);
                AddEncounter(player, type, doMsgs, 04, 17);
            }
        }
        protected override void FnEvent46(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 1, 20);
                AddEncounter(player, type, doMsgs, 2, 40);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 1, 21);
                AddEncounter(player, type, doMsgs, 2, 21);
                AddEncounter(player, type, doMsgs, 3, 23);
                AddEncounter(player, type, doMsgs, 6, 40);
            }
            else if (GetPartyCount(player, type, doMsgs) == 3) {
                AddEncounter(player, type, doMsgs, 1, 35);
                AddEncounter(player, type, doMsgs, 2, 38);
                AddEncounter(player, type, doMsgs, 3, 37);
                AddEncounter(player, type, doMsgs, 5, 22);
                AddEncounter(player, type, doMsgs, 6, 24);
            }
            else {
                AddEncounter(player, type, doMsgs, 1, 23);
                AddEncounter(player, type, doMsgs, 2, 39);
                AddEncounter(player, type, doMsgs, 3, 36);
                AddEncounter(player, type, doMsgs, 4, 36);
                AddEncounter(player, type, doMsgs, 5, 34);
                AddEncounter(player, type, doMsgs, 6, 34);
            }
        }
        private void Jtxt(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The waters of Journey's End Fountain are refreshing.");
        }
        private void WallClear(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void FntnPic(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
        }
        private void DamXit(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
            // EXIT_DUNGEON(player, type, doMsgs);
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void DoorHere(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void HealFtn(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ModifyHealth(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
            ModifyMana(player, type, doMsgs, 10000);
        }
    }
}
