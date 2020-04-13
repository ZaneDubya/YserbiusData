using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    class TwMap20 : TwMap {
        public override int MapIndex => 20;
        public override int MapID => 0x0802;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 1;

        private const int WIZCHOICE = 1;
        private const int DRAGON_B = 9;
        private const int DRAGON_A = 10;
        private const int ONE_NORTH = 14;
        private const int ONE_CENTER = 15;
        private const int ONE_SOUTH = 16;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetFlag(player, type, doMsgs, FlagTypeParty, WIZCHOICE, 1);
            TeleportParty(player, type, doMsgs, 8, 2, 124, Direction.South);
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == GNOME || GetRace(player, type, doMsgs) == TROLL) {
                TeleportParty(player, type, doMsgs, 8, 2, 251, Direction.North);
            }
            else if (GetRace(player, type, doMsgs) == ELF || GetRace(player, type, doMsgs) == GREMLIN) {
                TeleportParty(player, type, doMsgs, 8, 2, 96, Direction.East);
            }
            else if (GetRace(player, type, doMsgs) == DWARF || GetRace(player, type, doMsgs) == ORC) {
                TeleportParty(player, type, doMsgs, 8, 2, 77, Direction.East);
            }
            else {
                TeleportParty(player, type, doMsgs, 8, 2, 145, Direction.West);
            }
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetFlag(player, type, doMsgs, FlagTypeParty, WIZCHOICE, 2);
            TeleportParty(player, type, doMsgs, 8, 2, 124, Direction.East);
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == GNOME || GetRace(player, type, doMsgs) == ELF) {
                TeleportParty(player, type, doMsgs, 8, 2, 81, Direction.East);
            }
            else if (GetRace(player, type, doMsgs) == TROLL || GetRace(player, type, doMsgs) == GREMLIN) {
                TeleportParty(player, type, doMsgs, 8, 2, 163, Direction.North);
            }
            else if (GetRace(player, type, doMsgs) == DWARF || GetRace(player, type, doMsgs) == HALFLING) {
                TeleportParty(player, type, doMsgs, 8, 2, 204, Direction.West);
            }
            else {
                TeleportParty(player, type, doMsgs, 8, 2, 44, Direction.West);
            }
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == GNOME || GetRace(player, type, doMsgs) == ELF) {
                TeleportParty(player, type, doMsgs, 8, 2, 204, Direction.West);
            }
            else if (GetRace(player, type, doMsgs) == TROLL || GetRace(player, type, doMsgs) == GREMLIN) {
                TeleportParty(player, type, doMsgs, 8, 2, 44, Direction.West);
            }
            else if (GetRace(player, type, doMsgs) == DWARF || GetRace(player, type, doMsgs) == HALFLING) {
                TeleportParty(player, type, doMsgs, 8, 2, 81, Direction.East);
            }
            else {
                TeleportParty(player, type, doMsgs, 8, 2, 163, Direction.North);
            }
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == GNOME || GetRace(player, type, doMsgs) == ELF) {
                TeleportParty(player, type, doMsgs, 8, 2, 44, Direction.West);
            }
            else if (GetRace(player, type, doMsgs) == TROLL || GetRace(player, type, doMsgs) == GREMLIN) {
                TeleportParty(player, type, doMsgs, 8, 2, 204, Direction.West);
            }
            else if (GetRace(player, type, doMsgs) == DWARF || GetRace(player, type, doMsgs) == HALFLING) {
                TeleportParty(player, type, doMsgs, 8, 2, 163, Direction.North);
            }
            else {
                TeleportParty(player, type, doMsgs, 8, 2, 81, Direction.East);
            }
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == GNOME || GetRace(player, type, doMsgs) == ELF) {
                TeleportParty(player, type, doMsgs, 8, 2, 163, Direction.North);
            }
            else if (GetRace(player, type, doMsgs) == TROLL || GetRace(player, type, doMsgs) == GREMLIN) {
                TeleportParty(player, type, doMsgs, 8, 2, 81, Direction.East);
            }
            else if (GetRace(player, type, doMsgs) == DWARF || GetRace(player, type, doMsgs) == HALFLING) {
                TeleportParty(player, type, doMsgs, 8, 2, 44, Direction.West);
            }
            else {
                TeleportParty(player, type, doMsgs, 8, 2, 204, Direction.West);
            }
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetRace(player, type, doMsgs) == GNOME || GetRace(player, type, doMsgs) == TROLL) {
                TeleportParty(player, type, doMsgs, 8, 2, 255, Direction.West);
            }
            else if (GetRace(player, type, doMsgs) == ELF || GetRace(player, type, doMsgs) == GREMLIN) {
                TeleportParty(player, type, doMsgs, 8, 2, 240, Direction.East);
            }
            else if (GetRace(player, type, doMsgs) == DWARF || GetRace(player, type, doMsgs) == ORC) {
                TeleportParty(player, type, doMsgs, 8, 2, 10, Direction.South);
            }
            else {
                TeleportParty(player, type, doMsgs, 8, 2, 4, Direction.South);
            }
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetFlag(player, type, doMsgs, FlagTypeParty, WIZCHOICE, 4);
            TeleportParty(player, type, doMsgs, 8, 2, 124, Direction.West);
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetFlag(player, type, doMsgs, FlagTypeParty, WIZCHOICE, 3);
            TeleportParty(player, type, doMsgs, 8, 2, 124, Direction.North);
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Beyond this portal lies the wizard village Hocus Pocus.");
            TeleportParty(player, type, doMsgs, 9, 1, 247, Direction.North);
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, GREMLINWIZARD);
            ModifyGold(player, type, doMsgs,  - 1000);
            ShowText(player, type, doMsgs, "'I am the wizard Majikyl. For a mere pittance I shall envelop you in a Vapor Cloud. This cloud will allow you to approach the dragon unseen.");
            ShowText(player, type, doMsgs, "If you wish to continue, step through the door to the east.'");
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You find a page from MyMy's and Sinestra's journal with a faded map of many doors.");
            ShowText(player, type, doMsgs, "Across the top you can barely make out the words 'Hocus Pocus' and across the bottom you see four words but can only decipher S   h W   S    We  .");
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HUMANWIZARD);
            ModifyGold(player, type, doMsgs,  - 1000);
            ShowText(player, type, doMsgs, "'I am the wizard Artsenis. For this fee I will aid your quest. I shall place upon you a Chameleon Shroud spell. So disguised, you should be successful in approaching the dragon.");
            ShowText(player, type, doMsgs, "If you choose to continue, step through the door to the south.'");
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, ELFBARBARIAN);
            ShowText(player, type, doMsgs, "'I was told that you have to search every nook and cranny in the tunnels to find access to the dragons.'");
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A bloody hand print marks the wall.");
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, TROLLCLERIC);
            ShowText(player, type, doMsgs, "You cross paths with a Troll Cleric, who whispers to you,");
            ShowText(player, type, doMsgs, "'After searching all over, I retraced my steps and found an opening where none appeared before. This dungeon is a strange place.'");
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, DWARFWIZARD);
            ModifyGold(player, type, doMsgs,  - 1000);
            ShowText(player, type, doMsgs, "'I am the wizard Aillacsar. I shall take my fee for the Invisibility I cast upon you. It will get you close to your prey.");
            ShowText(player, type, doMsgs, "If you choose to continue, walk east through the teleport.'");
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            AddEncounter(player, type, doMsgs, 01, 16);
            AddEncounter(player, type, doMsgs, 02, 28);
            AddEncounter(player, type, doMsgs, 03, 37);
            AddEncounter(player, type, doMsgs, 04, 36);
            AddEncounter(player, type, doMsgs, 05, 38);
            AddEncounter(player, type, doMsgs, 06, 29);
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, GNOMEWIZARD);
            ModifyGold(player, type, doMsgs,  - 1000);
            ShowText(player, type, doMsgs, "'I am the wizard Mirloch. Accept my magic for a small fee. I have cast upon you a Charismatic Aura. The enemy will look upon you as a friend.");
            ShowText(player, type, doMsgs, "If you wish to continue, walk to the west through the teleport.");
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You step into a deep crevice and fall to your death.");
            DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The searing heat of the lava engulfs you in flames.");
            DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasUsedSkill(player, type, ref doMsgs, DETECT_SKILL) >= 10 || HasUsedSpell(player, type, ref doMsgs, TRUE_SEEING_SPELL) >= 1 || UsedItem(player, type, ref doMsgs, HELMOFWISDOM, HELMOFWISDOM) || UsedItem(player, type, ref doMsgs, VALKYRIESHELM, VALKYRIESHELM) || UsedItem(player, type, ref doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || UsedItem(player, type, ref doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                ShowText(player, type, doMsgs, "You discover an opening.");
                SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
            else {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasUsedSkill(player, type, ref doMsgs, DETECT_SKILL) >= 10 || HasUsedSpell(player, type, ref doMsgs, TRUE_SEEING_SPELL) >= 1 || UsedItem(player, type, ref doMsgs, HELMOFWISDOM, HELMOFWISDOM) || UsedItem(player, type, ref doMsgs, VALKYRIESHELM, VALKYRIESHELM) || UsedItem(player, type, ref doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || UsedItem(player, type, ref doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                ShowText(player, type, doMsgs, "You push aside a pile of rubble and find a clear path ahead.");
                SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
            else {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasUsedSkill(player, type, ref doMsgs, DETECT_SKILL) >= 10 || HasUsedSpell(player, type, ref doMsgs, TRUE_SEEING_SPELL) >= 1 || UsedItem(player, type, ref doMsgs, HELMOFWISDOM, HELMOFWISDOM) || UsedItem(player, type, ref doMsgs, VALKYRIESHELM, VALKYRIESHELM) || UsedItem(player, type, ref doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || UsedItem(player, type, ref doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                ShowText(player, type, doMsgs, "Your keen senses detect a hidden door.");
                SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
            else {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You are teleported to a series of long, dark tunnels. Here is where the dragons continue their feud.");
            if (GetFlag(player, type, doMsgs, FlagTypeParty, WIZCHOICE) == 1) {
                SetFlag(player, type, doMsgs, FlagTypeParty, WIZCHOICE, 5);
            }
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You are teleported to a series of long, dark tunnels. Here is where the dragons continue their feud.");
            if (GetFlag(player, type, doMsgs, FlagTypeParty, WIZCHOICE) == 2) {
                SetFlag(player, type, doMsgs, FlagTypeParty, WIZCHOICE, 5);
            }
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You are teleported to a series of long, dark tunnels. Here is where the dragons continue their feud.");
            if (GetFlag(player, type, doMsgs, FlagTypeParty, WIZCHOICE) == 3) {
                SetFlag(player, type, doMsgs, FlagTypeParty, WIZCHOICE, 5);
            }
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You are teleported to a series of long, dark tunnels. Here is where the dragons continue their feud.");
            if (GetFlag(player, type, doMsgs, FlagTypeParty, WIZCHOICE) == 4) {
                SetFlag(player, type, doMsgs, FlagTypeParty, WIZCHOICE, 5);
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeParty, DRAGON_B) == 1 && HasItem(player, type, doMsgs, DRAGONSSKIN)) {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
            else {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeParty, DRAGON_A) == 1 && GetFlag(player, type, doMsgs, FlagTypeParty, ONE_NORTH) == 1 && GetFlag(player, type, doMsgs, FlagTypeParty, ONE_CENTER) == 1 && GetFlag(player, type, doMsgs, FlagTypeParty, ONE_SOUTH) == 1) {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
            else {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeParty, DRAGON_A) == 1 && HasItem(player, type, doMsgs, DRAGONSSKIN)) {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
            else {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeParty, DRAGON_B) == 1 && GetFlag(player, type, doMsgs, FlagTypeParty, ONE_NORTH) == 1 && GetFlag(player, type, doMsgs, FlagTypeParty, ONE_CENTER) == 1 && GetFlag(player, type, doMsgs, FlagTypeParty, ONE_SOUTH) == 1) {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
            else {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, GREMLINTHIEF);
            ShowText(player, type, doMsgs, "'Greetings! Have you seen my two companions? We were separated when we walked alone through a teleport.'");
            SetFlag(player, type, doMsgs, FlagTypeParty, ONE_NORTH, 1);
            if (GetFlag(player, type, doMsgs, FlagTypeParty, WIZCHOICE) != 5) {
                ShowText(player, type, doMsgs, "'You say you have visited a wizard for magic? Hmmm, I see no signs of that.  Well, good journeys!'");
            }
            else {
                ShowText(player, type, doMsgs, "'If you see them, please tell them I'm still searching. Good journeys to you!'");
            }
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, ELFCLERIC);
            ShowText(player, type, doMsgs, "You encounter a tired elf leaning on a wall.");
            SetFlag(player, type, doMsgs, FlagTypeParty, ONE_SOUTH, 1);
            if (GetFlag(player, type, doMsgs, FlagTypeParty, WIZCHOICE) != 5) {
                ShowText(player, type, doMsgs, "'Have you had the same problem as us? Either the magic was weak or something stripped it from us in our wanderings.'");
            }
            else {
                ShowText(player, type, doMsgs, "'Well met! I am searching for my lost companions. I must hurry on, safe paths!'");
            }
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You notice a sign in pieces on the ground and barely make out the wording 'WARNING!!! These teleports are condemned by order of Queen Aeowyn!!!'");
            ShowText(player, type, doMsgs, "Attached to the sign is a hand written note, 'Olyces, some thief told me my magic protection was gone! Something odd about these teleports or where they take me.");
            ShowText(player, type, doMsgs, "I'm off to the wizards again and will meet you inside. I hope to use the correct teleport this time.' The note is signed, Bawcrs.");
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, TROLLKNIGHT);
            ShowText(player, type, doMsgs, "You stumble upon an injured troll and administer aid.");
            SetFlag(player, type, doMsgs, FlagTypeParty, ONE_CENTER, 1);
            if (GetFlag(player, type, doMsgs, FlagTypeParty, WIZCHOICE) != 5) {
                ShowText(player, type, doMsgs, "'A dangerous place indeed. I see no signs of magic about you. If you have visited the wizards, I suggest you try again. Sometimes shifting clouds of old magic strip the defenses. My thanks to you.'");
            }
            else {
                ShowText(player, type, doMsgs, "'My thanks to you for much needed aid. You appear to be well protected. I shall remember your kindness; fare well my friends.'");
            }
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SCALE) == 1) {
                ShowText(player, type, doMsgs, "Gambril lumbers away.");
                SetFlag(player, type, doMsgs, FlagTypeParty, DRAGON_B, 1);
            }
            else {
                if (HasItem(player, type, doMsgs, DRAGONSSKIN)) {
                    ShowPortrait(player, type, doMsgs, WHITEDRAGON);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SCALE, 1);
                    ModifyExperience(player, type, doMsgs, 500000);
                    ModifyGold(player, type, doMsgs, 25000);
                    GiveItem(player, type, doMsgs, STONEGIANTSHAMMER);
                    GiveItem(player, type, doMsgs, MIDNIGHTAEGIS);
                    GiveItem(player, type, doMsgs, FLAMETONGUE);
                    GiveItem(player, type, doMsgs, HEALAMPHORA);
                    GiveItem(player, type, doMsgs, ZEUSSCROLL);
                    ShowText(player, type, doMsgs, "Gambril is obviously relieved that his nemesis is finally dead.");
                    ShowText(player, type, doMsgs, "He gives you a reward and says, 'It would be wise to take your trophy to Hocus Pocus. The wizards there oftentimes need unique items.'");
                }
                else {
                    ShowPortrait(player, type, doMsgs, WHITEDRAGON);
                    SetFlag(player, type, doMsgs, FlagTypeParty, DRAGON_B, 1);
                    ShowText(player, type, doMsgs, "You meet Gambril, the Frost Dragon.");
                    ShowText(player, type, doMsgs, "'For longer than I care to remember, I have feuded with my nemesis Osterog, the Ice Dragon.");
                    ShowText(player, type, doMsgs, "Our continued battles have formed tunnels within the land, and we can no longer maneuver ourselves through them.");
                    ShowText(player, type, doMsgs, "I beseech you to help me. I will reward you generously if you bring me proof of your kill.");
                    ShowText(player, type, doMsgs, "To be successful, you may need greater magic than you now possess.'");
                }
            }
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeParty, WIZCHOICE) == 5) {
                ShowText(player, type, doMsgs, "With the help of the proper magic, you find the dragon Gambril.");
                if (HasItem(player, type, doMsgs, DRAGONSSKIN)) {
                    SetTreasure(player, type, doMsgs, ELIXIROFHEALTH, 0, 0, 0, 0, 2000);
                }
                else {
                    SetTreasure(player, type, doMsgs, DRAGONSSKIN, HEALALLPOTION, 0, 0, 0, 5000);
                }
                if (GetPartyCount(player, type, doMsgs) == 1) {
                    AddEncounter(player, type, doMsgs, 01, 39);
                }
                else if (GetPartyCount(player, type, doMsgs) == 2) {
                    AddEncounter(player, type, doMsgs, 01, 11);
                    AddEncounter(player, type, doMsgs, 02, 38);
                    AddEncounter(player, type, doMsgs, 06, 39);
                }
                else {
                    AddEncounter(player, type, doMsgs, 01, 11);
                    AddEncounter(player, type, doMsgs, 02, 11);
                    AddEncounter(player, type, doMsgs, 03, 12);
                    AddEncounter(player, type, doMsgs, 06, 39);
                }
            }
            else {
                ShowText(player, type, doMsgs, "The magic protection you try to weave around yourself is not enough to protect you from Gambril's keen vision.");
                ShowText(player, type, doMsgs, "Scoffing that Osterog has selected a particularly pitiful party to kill him, the dragon toasts you with his flame-breath.");
                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SCALE) == 1) {
                ShowText(player, type, doMsgs, "Osterog lumbers away.");
                SetFlag(player, type, doMsgs, FlagTypeParty, DRAGON_A, 1);
            }
            else {
                if (HasItem(player, type, doMsgs, DRAGONSSKIN)) {
                    ShowPortrait(player, type, doMsgs, WHITEDRAGON);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.SCALE, 1);
                    ModifyExperience(player, type, doMsgs, 500000);
                    ModifyGold(player, type, doMsgs, 25000);
                    GiveItem(player, type, doMsgs, STONEGIANTSHAMMER);
                    GiveItem(player, type, doMsgs, MIDNIGHTAEGIS);
                    GiveItem(player, type, doMsgs, FLAMETONGUE);
                    GiveItem(player, type, doMsgs, HEALAMPHORA);
                    GiveItem(player, type, doMsgs, ZEUSSCROLL);
                    ShowText(player, type, doMsgs, "Osterog smiles broadly, gloating that his nemesis is finally dead.");
                    ShowText(player, type, doMsgs, "As he doles out his reward, he says, 'I understand that the wizards of Hocus Pocus are much interested in unusual items. You may wish to show them your trophies.'");
                }
                else {
                    ShowPortrait(player, type, doMsgs, WHITEDRAGON);
                    SetFlag(player, type, doMsgs, FlagTypeParty, DRAGON_A, 1);
                    ShowText(player, type, doMsgs, "You encounter Osterog, the Ice Dragon.");
                    ShowText(player, type, doMsgs, "'Long have I feuded with Gambril, the Frost Dragon.");
                    ShowText(player, type, doMsgs, "Our endless battles have weakened the tunnels hereabout, and we no longer dare tread them.");
                    ShowText(player, type, doMsgs, "If you can help me destroy my sworn enemy, I will reward you most generously. Bring me proof of your kill.");
                    ShowText(player, type, doMsgs, "Your success may depend on greater magic than you now know.'");
                }
            }
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeParty, WIZCHOICE) == 5) {
                ShowText(player, type, doMsgs, "The proper magic has led you to the dragon Osterog.");
                if (HasItem(player, type, doMsgs, DRAGONSSKIN)) {
                    SetTreasure(player, type, doMsgs, ELIXIROFHEALTH, 0, 0, 0, 0, 2000);
                }
                else {
                    SetTreasure(player, type, doMsgs, DRAGONSSKIN, HEALALLPOTION, 0, 0, 0, 5000);
                }
                if (GetPartyCount(player, type, doMsgs) == 1) {
                    AddEncounter(player, type, doMsgs, 01, 40);
                }
                else if (GetPartyCount(player, type, doMsgs) == 2) {
                    AddEncounter(player, type, doMsgs, 01, 11);
                    AddEncounter(player, type, doMsgs, 02, 38);
                    AddEncounter(player, type, doMsgs, 06, 40);
                }
                else {
                    AddEncounter(player, type, doMsgs, 01, 11);
                    AddEncounter(player, type, doMsgs, 02, 11);
                    AddEncounter(player, type, doMsgs, 04, 29);
                    AddEncounter(player, type, doMsgs, 06, 40);
                }
            }
            else {
                ShowText(player, type, doMsgs, "As you tiptoe towards the great beast, Osterog sniffs once and smiles a saurian smile.");
                ShowText(player, type, doMsgs, "'Gambril has sent fools to kill me.'");
                ShowText(player, type, doMsgs, "He turns toward you and roasts you with his flame-breath.");
                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
            }
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You encounter other adventurers who seek the dragon's reward.");
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 20);
                AddEncounter(player, type, doMsgs, 02, 36);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 20);
                AddEncounter(player, type, doMsgs, 02, 28);
                AddEncounter(player, type, doMsgs, 05, 36);
                AddEncounter(player, type, doMsgs, 06, 33);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 20);
                AddEncounter(player, type, doMsgs, 02, 20);
                AddEncounter(player, type, doMsgs, 03, 24);
                AddEncounter(player, type, doMsgs, 04, 24);
                AddEncounter(player, type, doMsgs, 05, 36);
                AddEncounter(player, type, doMsgs, 06, 37);
            }
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 17);
                AddEncounter(player, type, doMsgs, 02, 28);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 28);
                AddEncounter(player, type, doMsgs, 02, 15);
                AddEncounter(player, type, doMsgs, 05, 12);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 14);
                AddEncounter(player, type, doMsgs, 02, 14);
                AddEncounter(player, type, doMsgs, 03, 29);
                AddEncounter(player, type, doMsgs, 05, 32);
                AddEncounter(player, type, doMsgs, 06, 32);
            }
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 2);
                AddEncounter(player, type, doMsgs, 02, 31);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 31);
                AddEncounter(player, type, doMsgs, 02, 1);
                AddEncounter(player, type, doMsgs, 05, 25);
                AddEncounter(player, type, doMsgs, 06, 26);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 5);
                AddEncounter(player, type, doMsgs, 02, 5);
                AddEncounter(player, type, doMsgs, 03, 27);
                AddEncounter(player, type, doMsgs, 04, 30);
                AddEncounter(player, type, doMsgs, 05, 29);
            }
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DRAGSTR) == 1) {
                ShowText(player, type, doMsgs, "You push open the broken door with ease.");
            }
            else {
                ShowText(player, type, doMsgs, "As you push against the stubborn door, debris falls and injures you.");
                if (GetAttribute(player, type, doMsgs, STRENGTH) >= 23) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DRAGSTR, 1);
                    DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 3);
                }
                else {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DRAGSTR, 1);
                    DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 4);
                }
            }
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DRAGDEF) == 1) {
                ShowText(player, type, doMsgs, "The walls around you have been fortified.");
            }
            else {
                ShowText(player, type, doMsgs, "The walls collapse upon you! Amnesia causes you to forget your more recent experiences.");
                if (GetAttribute(player, type, doMsgs, DEFENSE) >= 18) {
                    ModifyExperience(player, type, doMsgs,  - 10000);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DRAGDEF, 1);
                }
                else {
                    ModifyExperience(player, type, doMsgs,  - 20000);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DRAGDEF, 1);
                }
            }
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DRAGINI) == 1) {
                ShowText(player, type, doMsgs, "You elude a thief hiding in the shadows.");
            }
            else {
                ShowText(player, type, doMsgs, "A thief runs by you and picks your pocket.");
                if (GetAttribute(player, type, doMsgs, INITIATIVE) >= 13) {
                    ModifyGold(player, type, doMsgs,  - 25000);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DRAGINI, 1);
                }
                else {
                    ModifyGold(player, type, doMsgs,  - 50000);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DRAGINI, 1);
                }
            }
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DRAGAGI) == 1) {
                ShowText(player, type, doMsgs, "You resist the magical forces emanating from the chamber.");
            }
            else {
                ShowText(player, type, doMsgs, "You feel magical forces drain your mana.");
                if (GetAttribute(player, type, doMsgs, AGILITY) >= 11) {
                    ModifyMana(player, type, doMsgs,  - 200);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DRAGAGI, 1);
                }
                else {
                    ModifyMana(player, type, doMsgs,  - 400);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DRAGAGI, 1);
                }
            }
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, WRAITH);
            ShowText(player, type, doMsgs, "The ghost of an adventurer appears before you.");
            ShowText(player, type, doMsgs, "'Seek out the wizards in Dragon's Flame for help. Each, for a fee, will aid you with his or her unusual magic.");
            ShowText(player, type, doMsgs, "BUT, all spells are not successful for all.");
            ShowText(player, type, doMsgs, "I wish you better luck than I had. And remember, it is imperative that you stay in the area until you successfully complete your quest.'");
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 8, 2, 69, Direction.East);
        }
        protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 8, 2, 185, Direction.North);
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetFlag(player, type, doMsgs, FlagTypeParty, WIZCHOICE, 0);
            SetFlag(player, type, doMsgs, FlagTypeParty, ONE_NORTH, 0);
            SetFlag(player, type, doMsgs, FlagTypeParty, ONE_CENTER, 0);
            SetFlag(player, type, doMsgs, FlagTypeParty, ONE_SOUTH, 0);
        }
    }
}
