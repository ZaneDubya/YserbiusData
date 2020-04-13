using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    class TwMap25 : TwMap {
        public override int MapIndex => 25;
        public override int MapID => 0x0A03;
        protected override int RandomEncounterChance => 15;
        protected override int RandomEncounterExtraCount => 2;

        private const int PANSTAR = 1;
        private const int PORT = 2;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 10, 3, 159, Direction.South);
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 11, 1, 175, Direction.North);
            RemoveItem(player, type, doMsgs, HOPESFURY);
            RemoveItem(player, type, doMsgs, FLASKOFSHADOWFALL);
            RemoveItem(player, type, doMsgs, NIMBUSOFTHEFATES);
            RemoveItem(player, type, doMsgs, REALITYSRAMPART);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 10, 3, 46, Direction.North);
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 10, 3, 176, Direction.South);
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 11, 3, 16, Direction.North);
            RemoveItem(player, type, doMsgs, ICEFLAME);
            RemoveItem(player, type, doMsgs, HOPESFURY);
            RemoveItem(player, type, doMsgs, FLASKOFSHADOWFALL);
            RemoveItem(player, type, doMsgs, NIMBUSOFTHEFATES);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 10, 3, 172, Direction.North);
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 11, 1, 241, Direction.North);
            RemoveItem(player, type, doMsgs, ICEFLAME);
            RemoveItem(player, type, doMsgs, HOPESFURY);
            RemoveItem(player, type, doMsgs, NIMBUSOFTHEFATES);
            RemoveItem(player, type, doMsgs, REALITYSRAMPART);
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 10, 3, 110, Direction.West);
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 11, 1, 40, Direction.South);
            RemoveItem(player, type, doMsgs, ICEFLAME);
            RemoveItem(player, type, doMsgs, FLASKOFSHADOWFALL);
            RemoveItem(player, type, doMsgs, NIMBUSOFTHEFATES);
            RemoveItem(player, type, doMsgs, REALITYSRAMPART);
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 11, 3, 240, Direction.East);
            RemoveItem(player, type, doMsgs, FLASKOFSHADOWFALL);
            RemoveItem(player, type, doMsgs, ICEFLAME);
            RemoveItem(player, type, doMsgs, HOPESFURY);
            RemoveItem(player, type, doMsgs, REALITYSRAMPART);
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You quickly jump out of the way of a falling boulder.");
            TeleportParty(player, type, doMsgs, 10, 3, 233, Direction.North);
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 10, 3, 19, Direction.East);
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeTile, PORT) == 0) {
                if (GetFlag(player, type, doMsgs, FlagTypeParty, PANSTAR) == 1) {
                    TeleportParty(player, type, doMsgs, 10, 3, 35, Direction.West);
                    SetFlag(player, type, doMsgs, FlagTypeTile, PORT, 1);
                }
            }
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 10, 3, 83, Direction.South);
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PANHEAL) == 1) {
                ShowText(player, type, doMsgs, "The alcove is empty.");
            }
            else {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PANHEAL, 1);
                GiveItem(player, type, doMsgs, HEALAMPHORA);
                GiveItem(player, type, doMsgs, HEALAMPHORA);
                GiveItem(player, type, doMsgs, SCORCHEDSCROLL);
                ShowText(player, type, doMsgs, "Next to the obvious remains of a long time dead adventurer you are surprised to find some items intact.");
            }
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ModifyMana(player, type, doMsgs,  - 200);
            ShowText(player, type, doMsgs, "Your constant running into invisible walls has taken a toll on your mana.");
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableSkills(player, type, doMsgs);
            DisableSpells(player, type, doMsgs);
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PANSCROLL) == 1) {
                ShowText(player, type, doMsgs, "You see nothing of interest here.");
            }
            else {
                ShowPortrait(player, type, doMsgs, DWARFWIZARD);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PANSCROLL, 1);
                GiveItem(player, type, doMsgs, ZEUSSCROLL);
                GiveItem(player, type, doMsgs, PUMMELSCROLL);
                GiveItem(player, type, doMsgs, SHIELDINGSCROLL);
                ModifyGold(player, type, doMsgs,  - 10000);
                ShowText(player, type, doMsgs, "You encounter a wizard selling scrolls.");
                ShowText(player, type, doMsgs, "'I see that you will be in need of magic as you travel through this area.  I accept your payment for these scrolls. May they aid you in your journey.'");
            }
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
            DisableHealing(player, type, doMsgs);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, PORT) == 0)) {
                ShowText(player, type, doMsgs, "The water drains your energy as you wade through it.");
                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 4);
                SetFlag(player, type, doMsgs, FlagTypeTile, PORT, 1);
            }
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.East);
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.West);
            DisableHealing(player, type, doMsgs);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, PORT) == 0)) {
                if (GetGuild(player, type, doMsgs) == RANGER || GetGuild(player, type, doMsgs) == CLERIC || GetGuild(player, type, doMsgs) == WIZARD) {
                    ShowText(player, type, doMsgs, "A water monster attacks you, but you manage to get away with minimal damage.");
                    DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 4);
                    SetFlag(player, type, doMsgs, FlagTypeTile, PORT, 1);
                }
            }
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You fall into a bottomless pit.");
            DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.West);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PANMANA) == 1) {
                ShowText(player, type, doMsgs, "The water flows briskly around you.");
            }
            else {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PANMANA, 1);
                GiveItem(player, type, doMsgs, MANAAMPHORA);
                ShowText(player, type, doMsgs, "You see something bobbing in the water and grab it.");
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
            DisableHealing(player, type, doMsgs);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, PORT) == 0)) {
                if (GetGuild(player, type, doMsgs) == THIEF || GetGuild(player, type, doMsgs) == BARBARIAN || GetGuild(player, type, doMsgs) == KNIGHT) {
                    ShowText(player, type, doMsgs, "A water monster attacks you, but you manage to get away with minimal damage.");
                    DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 4);
                    SetFlag(player, type, doMsgs, FlagTypeTile, PORT, 1);
                }
            }
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, STARBURST)) {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            }
            else {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            }
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
            DisableHealing(player, type, doMsgs);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, PORT) == 0)) {
                ShowText(player, type, doMsgs, "The heat of the surrounding lava makes you weak.");
                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 4);
                SetFlag(player, type, doMsgs, FlagTypeTile, PORT, 1);
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.East);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PANMONEY) == 1) {
                ShowText(player, type, doMsgs, "You find nothing.");
            }
            else {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PANMONEY, 1);
                GiveItem(player, type, doMsgs, THIEFSSTILETTO);
                GiveItem(player, type, doMsgs, DRAGONSSTONE);
                GiveItem(player, type, doMsgs, PLATINUMBAR);
                GiveItem(player, type, doMsgs, RINGOFTHIEVES);
                ShowText(player, type, doMsgs, "Protruding from the hardened lava you find a bag.  You free it and pocket the contents.");
            }
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, STARBURST)) {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
            }
            else {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
            }
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You see a sign on the door. 'Adventurers!  Proceed through this door individually if you possess the magical Starburst.'");
            if (GetPartyCount(player, type, doMsgs) == 1) {
                if (HasItem(player, type, doMsgs, STARBURST)) {
                    ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                }
                else {
                    SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                    ShowText(player, type, doMsgs, "You must find the magical Starburst to gain entry.");
                }
            }
            else {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.West);
            DisableHealing(player, type, doMsgs);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, PORT) == 0)) {
                if (GetGuild(player, type, doMsgs) == THIEF || GetGuild(player, type, doMsgs) == BARBARIAN || GetGuild(player, type, doMsgs) == KNIGHT) {
                    ShowText(player, type, doMsgs, "Your heavy step causes a crack in the hardened lava and the still molten lava below splashes up and injures you.");
                    DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 4);
                    SetFlag(player, type, doMsgs, FlagTypeTile, PORT, 1);
                }
            }
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            DisableHealing(player, type, doMsgs);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, PORT) == 0)) {
                if (GetGuild(player, type, doMsgs) == RANGER || GetGuild(player, type, doMsgs) == CLERIC || GetGuild(player, type, doMsgs) == WIZARD) {
                    ShowText(player, type, doMsgs, "Your heavy step causes a crack in the hardened lava and the still molten lava below splashes up and injures you.");
                    DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 4);
                    SetFlag(player, type, doMsgs, FlagTypeTile, PORT, 1);
                }
            }
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The swirling waters of Bedlam Whirlpool heal your wounds.");
            ModifyHealth(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, STARBURST)) {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.East);
            }
            else {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.East);
            }
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, STARBURST)) {
                ShowText(player, type, doMsgs, "The crusted lava allows for easy passage.");
            }
            else {
                ShowPortrait(player, type, doMsgs, ELFCLERIC);
                ShowText(player, type, doMsgs, "You help a Cleric free his trapped foot from a crack in the lava. 'Thank you for helping me. Please accept this talisman with my gratitude. May it aid you in your travels.");
                ShowText(player, type, doMsgs, "It has gotten me out of a few rocky situations.'");
                GiveItem(player, type, doMsgs, STARBURST);
            }
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.East);
            DisableHealing(player, type, doMsgs);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, PORT) == 0)) {
                ShowText(player, type, doMsgs, "You cut yourself on the jagged rock wall.");
                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 3);
                SetFlag(player, type, doMsgs, FlagTypeTile, PORT, 1);
            }
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.West);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PANLIFE) == 1) {
                ShowText(player, type, doMsgs, "You see a hole in the wall.");
            }
            else {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PANLIFE, 1);
                ShowText(player, type, doMsgs, "You see forgotten items resting on a ledge in the wall.");
                GiveItem(player, type, doMsgs, SYMBOLOFDEATH);
                GiveItem(player, type, doMsgs, SPIKEDSHIELD);
                GiveItem(player, type, doMsgs, LIFEGIVER);
                GiveItem(player, type, doMsgs, CUREALLPOTION);
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.East);
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
            ShowText(player, type, doMsgs, "The Lava Pool of Confusion restores your mana.");
            ModifyMana(player, type, doMsgs, 10000);
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, STARBURST)) {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ShowText(player, type, doMsgs, "You find that a boulder has blocked your path.");
                if ((UsedItem(player, type, ref doMsgs, STARBURST, STARBURST)) && (GetGuild(player, type, doMsgs) == GNOME || GetGuild(player, type, doMsgs) == ELF)) {
                    SetFlag(player, type, doMsgs, FlagTypeParty, PANSTAR, 1);
                    ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                    ShowText(player, type, doMsgs, "The magical Starburst shatters the boulder.");
                }
                else {
                    ShowText(player, type, doMsgs, "You cannot budge the boulder.");
                }
            }
            else {
                ShowText(player, type, doMsgs, "The ground shows signs of damage from heavy boulders falling.");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, STARBURST)) {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ShowText(player, type, doMsgs, "You find that a boulder has blocked your path.");
                if ((UsedItem(player, type, ref doMsgs, STARBURST, STARBURST)) && (GetGuild(player, type, doMsgs) == ORC || GetGuild(player, type, doMsgs) == GREMLIN)) {
                    SetFlag(player, type, doMsgs, FlagTypeParty, PANSTAR, 1);
                    ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                    ShowText(player, type, doMsgs, "The magical Starburst shatters the boulder.");
                }
                else {
                    ShowText(player, type, doMsgs, "You cannot budge the boulder.");
                }
            }
            else {
                ShowText(player, type, doMsgs, "The ground shows signs of damage from heavy boulders falling.");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, STARBURST)) {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ShowText(player, type, doMsgs, "You find that a boulder has blocked your path.");
                if ((UsedItem(player, type, ref doMsgs, STARBURST, STARBURST)) && (GetGuild(player, type, doMsgs) == DWARF || GetGuild(player, type, doMsgs) == TROLL)) {
                    SetFlag(player, type, doMsgs, FlagTypeParty, PANSTAR, 1);
                    ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                    ShowText(player, type, doMsgs, "The magical Starburst shatters the boulder.");
                }
                else {
                    ShowText(player, type, doMsgs, "You cannot budge the boulder.");
                }
            }
            else {
                ShowText(player, type, doMsgs, "The ground shows signs of damage from heavy boulders falling.");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, STARBURST)) {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ShowText(player, type, doMsgs, "You find that a boulder has blocked your path.");
                if ((UsedItem(player, type, ref doMsgs, STARBURST, STARBURST)) && (GetGuild(player, type, doMsgs) == HALFLING || GetGuild(player, type, doMsgs) == HUMAN)) {
                    SetFlag(player, type, doMsgs, FlagTypeParty, PANSTAR, 1);
                    ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                    ShowText(player, type, doMsgs, "The magical Starburst shatters the boulder.");
                }
                else {
                    ShowText(player, type, doMsgs, "You cannot budge the boulder.");
                }
            }
            else {
                ShowText(player, type, doMsgs, "The ground shows signs of damage from heavy boulders falling.");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.West);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PANBUCKS) == 1) {
                ShowText(player, type, doMsgs, "There is nothing but rubble on the ground.");
            }
            else {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.PANBUCKS, 1);
                ShowText(player, type, doMsgs, "Upon searching the alcove you move a rock and discover treasure.");
                GiveItem(player, type, doMsgs, TEMPEREDADAMANTINE);
                GiveItem(player, type, doMsgs, PLATINUMBAR);
                GiveItem(player, type, doMsgs, PRIESTSAMULET);
                GiveItem(player, type, doMsgs, CRYSTALBALL);
            }
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, GNOMEWIZARD);
            ShowText(player, type, doMsgs, "You encounter a Gnome Wizard who stops you in your path. ");
            ShowText(player, type, doMsgs, "'This place is pandemonium.  My skills and spells are useless in places.'");
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, STORMGIANT);
            ShowText(player, type, doMsgs, "'You have come to the area where you must decide which path to follow in your search for each of the Dralkarians.  Guard well your magical Starburst for it will grant you passage to the portals.'");
            ShowText(player, type, doMsgs, "'May your choices be wise and your journeys successful.'");
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, GREMLINTHIEF);
            ShowText(player, type, doMsgs, "A thief pulls you aside. 'Pssst....I found a way to walk over the lava.  Just be sure it's crusted over.  Shhhhh, don't tell a soul.'");
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.West);
            ShowText(player, type, doMsgs, "You see a hand written note on the back of a scroll.  It warns that what may harm one, may not harm another.");
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, COMMONNIGHTELF);
            ShowText(player, type, doMsgs, "'The time has come for you to begin your journey to meet the Dralkarians. You must travel through Pandemonium in order to seek the portals to the final paths. Of the 5 portals you shall make your choice.'");
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 05, 2);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 02, 2);
                AddEncounter(player, type, doMsgs, 05, 3);
                AddEncounter(player, type, doMsgs, 06, 3);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 02, 1);
                AddEncounter(player, type, doMsgs, 03, 2);
                AddEncounter(player, type, doMsgs, 04, 2);
                AddEncounter(player, type, doMsgs, 05, 3);
            }
        }
        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 32);
                AddEncounter(player, type, doMsgs, 02, 33);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 31);
                AddEncounter(player, type, doMsgs, 02, 31);
                AddEncounter(player, type, doMsgs, 03, 32);
                AddEncounter(player, type, doMsgs, 04, 33);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 31);
                AddEncounter(player, type, doMsgs, 02, 31);
                AddEncounter(player, type, doMsgs, 03, 33);
                AddEncounter(player, type, doMsgs, 04, 33);
                AddEncounter(player, type, doMsgs, 06, 34);
            }
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 17);
                AddEncounter(player, type, doMsgs, 02, 19);
                AddEncounter(player, type, doMsgs, 06, 30);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 19);
                AddEncounter(player, type, doMsgs, 02, 20);
                AddEncounter(player, type, doMsgs, 05, 30);
                AddEncounter(player, type, doMsgs, 06, 28);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 17);
                AddEncounter(player, type, doMsgs, 02, 17);
                AddEncounter(player, type, doMsgs, 04, 30);
                AddEncounter(player, type, doMsgs, 05, 28);
                AddEncounter(player, type, doMsgs, 06, 29);
            }
        }
        protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 26);
                AddEncounter(player, type, doMsgs, 05, 38);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 26);
                AddEncounter(player, type, doMsgs, 02, 27);
                AddEncounter(player, type, doMsgs, 03, 28);
                AddEncounter(player, type, doMsgs, 04, 38);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 26);
                AddEncounter(player, type, doMsgs, 02, 26);
                AddEncounter(player, type, doMsgs, 04, 27);
                AddEncounter(player, type, doMsgs, 05, 37);
                AddEncounter(player, type, doMsgs, 06, 38);
            }
        }
        protected override void FnEvent3B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 39);
                AddEncounter(player, type, doMsgs, 05, 40);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 39);
                AddEncounter(player, type, doMsgs, 02, 39);
                AddEncounter(player, type, doMsgs, 03, 40);
                AddEncounter(player, type, doMsgs, 06, 25);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 40);
                AddEncounter(player, type, doMsgs, 02, 40);
                AddEncounter(player, type, doMsgs, 03, 39);
                AddEncounter(player, type, doMsgs, 05, 25);
                AddEncounter(player, type, doMsgs, 06, 25);
            }
        }
        protected override void FnEvent3C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.East);
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 1);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 02, 3);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 02, 4);
                AddEncounter(player, type, doMsgs, 05, 33);
                AddEncounter(player, type, doMsgs, 06, 33);
            }
        }
        protected override void FnEvent3D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 13);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 12);
                AddEncounter(player, type, doMsgs, 02, 13);
                AddEncounter(player, type, doMsgs, 03, 36);
                AddEncounter(player, type, doMsgs, 04, 36);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 12);
                AddEncounter(player, type, doMsgs, 02, 12);
                AddEncounter(player, type, doMsgs, 03, 13);
                AddEncounter(player, type, doMsgs, 04, 13);
                AddEncounter(player, type, doMsgs, 05, 36);
            }
        }
        protected override void FnEvent3E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                ShowText(player, type, doMsgs, "Now you may proceed to pick the path of your choice.");
            }
            else {
                TeleportParty(player, type, doMsgs, 10, 3, 34, Direction.East);
            }
        }
        protected override void FnEvent3F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
        }
        protected override void FnEvent40(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.East);
        }
        protected override void FnEvent41(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.West);
        }
        protected override void FnEvent42(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
        }
        protected override void FnEvent43(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.West);
        }
        protected override void FnEvent44(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.East);
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.West);
        }
        protected override void FnEvent45(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.West);
        }
        protected override void FnEvent46(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
        }
        protected override void FnEvent47(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.East);
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
        }
        protected override void FnEvent48(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.East);
        }
        protected override void FnEvent49(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.East);
        }
        protected override void FnEvent4A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.East);
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.West);
        }
        protected override void FnEvent4B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.East);
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.West);
        }
        protected override void FnEvent4C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.West);
        }
        protected override void FnEvent4D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, STARBURST)) {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.West);
            }
            else {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.West);
            }
        }
        protected override void FnEvent4E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, STARBURST)) {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
            }
            else {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
            }
        }
        protected override void FnEvent4F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, STARBURST)) {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.West);
            }
            else {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.West);
            }
        }
        protected override void FnEvent50(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, STARBURST)) {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
            }
            else {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
            }
        }
        protected override void FnEvent51(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, STARBURST)) {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.East);
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
            }
            else {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.East);
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
            }
        }
        protected override void FnEvent52(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, STARBURST)) {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
            }
            else {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.South);
            }
        }
        protected override void FnEvent53(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, STARBURST)) {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            }
            else {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.North);
            }
        }
        protected override void FnEvent54(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Proceed through this door and accept the challenge of the elements in order to gain access to Malos, the Dralkarian who controls the elements. Be aware that all Quest items gained from other paths will be taken from you.");
        }
        protected override void FnEvent55(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Step through this door to overcome physical obstacles on your path to Corpeus, the Dralkarian who guards the gate. Be aware that all Quest items gained from other paths will be taken from you.");
        }
        protected override void FnEvent56(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "This door will lead you to the path through Enakkar in your search for the Dralkarian Juvalad. Be aware that all Quest items from other paths will be taken from you.");
        }
        protected override void FnEvent57(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Through this door is Ashakkar. Succeed in your quest and you will find the Dralkarian Pluthros.  Be aware that all Quest items from other paths will be taken from you.");
        }
        protected override void FnEvent58(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Inside, a portal will teleport you to the astral path in order to find the Dralkarian guard Astelligus. Be aware that all Quest items from other paths will be taken from you.");
        }
    }
}
