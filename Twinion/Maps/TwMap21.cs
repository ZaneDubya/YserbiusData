using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    class TwMap21 : TwMap {
        public override int MapIndex => 21;
        public override int MapID => 0x0901;
        protected override int RandomEncounterChance => 9;
        protected override int RandomEncounterExtraCount => 1;

        private const int HURT = 1;
        private const int HOCUS_PASS = 1;
        private const int FAERLUN = 2;
        private const int HOCUS_BAT = 3;
        private const int HOCUS_NEWT = 4;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 9, 1, 113, Direction.East);
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 9, 1, 22, Direction.West);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "All ye who enter here, abandon hope.");
            TeleportParty(player, type, doMsgs, 9, 2, 119, Direction.North);
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 9, 1, 240, Direction.East);
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "This portal has markings similar to the great dragon's lair above.");
            TeleportParty(player, type, doMsgs, 8, 1, 239, Direction.West);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 9, 1, 15, Direction.North);
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You enter the Cup and Sorcerer banquet hall. Students and instructors dine here.");
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.INSTRUCTOR) == 1) {
                ShowText(player, type, doMsgs, "The classroom is empty.");
            }
            else {
                ModifyExperience(player, type, doMsgs, 20000);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.INSTRUCTOR, 1);
                ShowText(player, type, doMsgs, "You observe a wise old mage teaching his craft. His lessons are very helpful.");
            }
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The guard nods and goes back to his work.");
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The library is silent as students concentrate on their tomes.");
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The administrative clerks are hard at work.");
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeParty, FAERLUN) == 1) {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ShowText(player, type, doMsgs, "The door swings open.");
            }
            else {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ShowText(player, type, doMsgs, "A note on the door from the town clerk reads:");
                ShowText(player, type, doMsgs, "'Faerlun, I'll be back after lunch.'");
            }
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You throw a few coins into the well for luck.");
            ModifyGold(player, type, doMsgs,  - 100);
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You marvel at the splendor of this wizard's home.");
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "To the west is the Alchemy Shop; to the east, the Armory.");
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You enter a modest home.");
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, ELFRANGER);
            ShowText(player, type, doMsgs, "You pass a resident tending the garden where the wizards grow ingredients for their spells.");
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "To the west you see the General Store; to the east, the Magic Shop.");
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A sign reads -");
            ShowText(player, type, doMsgs, "'See the town clerk for information on training.'");
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Hocus Pocus Stables");
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A plaque reads -");
            ShowText(player, type, doMsgs, "'Items at the shops are not free.'");
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You step into a pool of lava.");
            DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The pit is bottomless.");
            DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableHealing(player, type, doMsgs);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, HURT) == 0)) {
                ShowText(player, type, doMsgs, "The mystical waters weaken you.");
                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 4);
                SetFlag(player, type, doMsgs, FlagTypeTile, HURT, 1);
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Hocus Pocus Herb Garden");
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasUsedSkill(player, type, ref doMsgs, DETECT_SKILL) >= 10 || HasUsedSpell(player, type, ref doMsgs, TRUE_SEEING_SPELL) >= 1 || UsedItem(player, type, ref doMsgs, HELMOFWISDOM, HELMOFWISDOM) || UsedItem(player, type, ref doMsgs, VALKYRIESHELM, VALKYRIESHELM) || UsedItem(player, type, ref doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || UsedItem(player, type, ref doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                ShowText(player, type, doMsgs, "A passageway appears.");
                SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
            else {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HUMANTHIEF);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ALCHEMY) == 1) {
                ShowText(player, type, doMsgs, "You find nothing you need.");
            }
            else {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ALCHEMY, 1);
                ModifyGold(player, type, doMsgs,  - 20000);
                GiveItem(player, type, doMsgs, MANAAMPHORA);
                GiveItem(player, type, doMsgs, HEALAMPHORA);
                ShowText(player, type, doMsgs, "The shopkeeper is happy to take your gold.");
            }
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, ORCKNIGHT);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARMORY) == 1) {
                ShowText(player, type, doMsgs, "The armorer is busy forging new weapons.");
            }
            else {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARMORY, 1);
                ModifyGold(player, type, doMsgs,  - 5000);
                GiveItem(player, type, doMsgs, ARCHEDDEATH);
                GiveItem(player, type, doMsgs, STAFFOFTHEMAGUS);
                GiveItem(player, type, doMsgs, BOWOFFLAMES);
                ShowText(player, type, doMsgs, "You exchange your gold for weapons.");
            }
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, TROLLCLERIC);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GENERAL) == 1) {
                ShowText(player, type, doMsgs, "The shopkeeper is too busy to help you.");
            }
            else {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GENERAL, 1);
                ModifyGold(player, type, doMsgs,  - 10000);
                GiveItem(player, type, doMsgs, AMULETOFPROTECTION);
                GiveItem(player, type, doMsgs, PIPESOFENCHANTMENT);
                GiveItem(player, type, doMsgs, FREEDOMRING);
                ShowText(player, type, doMsgs, "You decide on some helpful items.");
            }
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HALFLINGCLERIC);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.MAGIC_SHOP) == 1) {
                ShowText(player, type, doMsgs, "You have already made your purchase.");
            }
            else {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.MAGIC_SHOP, 1);
                ModifyGold(player, type, doMsgs,  - 25000);
                GiveItem(player, type, doMsgs, SYMBOLOFDEATH);
                GiveItem(player, type, doMsgs, PUMMELSCROLL);
                ShowText(player, type, doMsgs, "You purchase scrolls.");
            }
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HOCUS_GOLD) == 1) {
                ShowText(player, type, doMsgs, "The building is empty.");
            }
            else {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HOCUS_GOLD, 1);
                ModifyGold(player, type, doMsgs, 25000);
                ShowText(player, type, doMsgs, "You discover a lost quest bag filled with gold.");
            }
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HOCUS_SCROLL) == 1) {
                ShowText(player, type, doMsgs, "The room is empty.");
            }
            else {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HOCUS_SCROLL, 1);
                GiveItem(player, type, doMsgs, BLOODSCROLL);
                GiveItem(player, type, doMsgs, SCORCHEDSCROLL);
                GiveItem(player, type, doMsgs, SOVEREIGNSCROLL);
                ShowText(player, type, doMsgs, "A search yields scrolls.");
            }
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A strange magical aura drains your mana.");
            ModifyMana(player, type, doMsgs,  - 300);
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The acolytes of Nisym Temple restore your mana free of charge.");
            ModifyMana(player, type, doMsgs, 10000);
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HALFLINGRANGER);
            ShowText(player, type, doMsgs, "'Welcome to the Talisman Inn. I have taken payment for your accommodations. You will find your health improved after your brief rest.'");
            ModifyHealth(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
            ModifyGold(player, type, doMsgs,  - 1000);
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, DWARFKNIGHT);
            SetFlag(player, type, doMsgs, FlagTypeParty, HOCUS_PASS, 1);
            ShowText(player, type, doMsgs, "The clerk greets you.");
            ShowText(player, type, doMsgs, "'Hail! I've been expecting you.");
            ShowText(player, type, doMsgs, "Word has been sent to the training area guard. You will now be granted access.'");
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HUMANWIZARD);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HOCUS_DONE) == 1) {
                SetFlag(player, type, doMsgs, FlagTypeParty, FAERLUN, 1);
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ShowText(player, type, doMsgs, "Ah! You have found my items! Now walk alone through the door to the east for your promised reward.");
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HOCUS_DONE) == 2) {
                SetFlag(player, type, doMsgs, FlagTypeParty, FAERLUN, 1);
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ShowText(player, type, doMsgs, "Try again, my friend. The path is tricky, but very rewarding.");
            }
            else {
                if (HasItem(player, type, doMsgs, DRAGONSSKIN)) {
                    SetFlag(player, type, doMsgs, FlagTypeParty, FAERLUN, 1);
                    SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                    RemoveItem(player, type, doMsgs, DRAGONSSKIN);
                    ModifyGold(player, type, doMsgs, 10000);
                    ShowText(player, type, doMsgs, "'Hail, brave adventurers!  My name is Faerlun.");
                    ShowText(player, type, doMsgs, "What an interesting dragon skin you've found! Let's do a little swap, shall we?");
                    ShowText(player, type, doMsgs, "I'll take the skin. You take this gold.");
                    ShowText(player, type, doMsgs, "Now that you are here, maybe you can help me find the wing of a bat and eye of a newt.");
                    ShowText(player, type, doMsgs, "These items you will find in Hocus Pocus.");
                    ShowText(player, type, doMsgs, "By the way, do NOT leave the village until you find them.");
                    ShowText(player, type, doMsgs, "Bring them to me and I will show you the way to a challenge of great reward.'");
                }
                else {
                    SetFlag(player, type, doMsgs, FlagTypeParty, FAERLUN, 1);
                    SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                    ShowText(player, type, doMsgs, "'Hail, adventurers. My name is Faerlun and I could use some assistance.");
                    ShowText(player, type, doMsgs, "For an experiment I am doing, I seek the wing of a bat and the eye of a newt.");
                    ShowText(player, type, doMsgs, "Do NOT leave Hocus Pocus until you find these items.");
                    ShowText(player, type, doMsgs, "In exchange for your help, I will show you the way to a challenge of great reward.'");
                }
            }
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeParty, HOCUS_PASS) == 1 && GetFlag(player, type, doMsgs, FlagTypeParty, FAERLUN) == 1) {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ShowText(player, type, doMsgs, "The guard notes your name on the list and allows you access.");
            }
            else {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, DWARFWIZARD);
            if (GetFlag(player, type, doMsgs, FlagTypeParty, FAERLUN) == 1 && GetFlag(player, type, doMsgs, FlagTypeParty, HOCUS_PASS) == 1 && GetFlag(player, type, doMsgs, FlagTypeParty, HOCUS_BAT) == 1) {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HOCUS_DONE, 1);
                SetFlag(player, type, doMsgs, FlagTypeParty, FAERLUN, 0);
                SetFlag(player, type, doMsgs, FlagTypeParty, HOCUS_PASS, 0);
                SetFlag(player, type, doMsgs, FlagTypeParty, HOCUS_BAT, 0);
                ShowText(player, type, doMsgs, "You meet Morai, who hands you a vial.");
                ShowText(player, type, doMsgs, "She explains 'I see that you have found the bat wings. Now, this eye of newt will complete Faerlun's needs.'");
                ShowText(player, type, doMsgs, "You pocket the vial and leave.");
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeParty, FAERLUN) == 1 && GetFlag(player, type, doMsgs, FlagTypeParty, HOCUS_PASS) == 1) {
                SetFlag(player, type, doMsgs, FlagTypeParty, HOCUS_NEWT, 1);
                ShowText(player, type, doMsgs, "You meet Morai, who hands you a vial.");
                ShowText(player, type, doMsgs, "'Take this eye of newt back to Faerlun. It is part of what he needs for his studies.'");
                ShowText(player, type, doMsgs, "You pocket the vial and leave.");
            }
            else {
                ShowText(player, type, doMsgs, "Morai is concentrating on her studies.");
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, GREMLINWIZARD);
            if (GetFlag(player, type, doMsgs, FlagTypeParty, FAERLUN) == 1 && GetFlag(player, type, doMsgs, FlagTypeParty, HOCUS_PASS) == 1 && GetFlag(player, type, doMsgs, FlagTypeParty, HOCUS_NEWT) == 1) {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HOCUS_DONE, 1);
                SetFlag(player, type, doMsgs, FlagTypeParty, FAERLUN, 0);
                SetFlag(player, type, doMsgs, FlagTypeParty, HOCUS_PASS, 0);
                SetFlag(player, type, doMsgs, FlagTypeParty, HOCUS_NEWT, 0);
                ShowText(player, type, doMsgs, "Keoana greets you. Noticing the eye of newt you carry, she hands you a vial of bat wings.");
                ShowText(player, type, doMsgs, "She says, 'Faerlun will be pleased that you have found his ingredients.'");
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeParty, FAERLUN) == 1 && GetFlag(player, type, doMsgs, FlagTypeParty, HOCUS_PASS) == 1) {
                SetFlag(player, type, doMsgs, FlagTypeParty, HOCUS_BAT, 1);
                ShowText(player, type, doMsgs, "Keoana smiles as you enter.");
                ShowText(player, type, doMsgs, "'Faerlun is in need of these bat wings. Please take them to him so that he may complete his studies.'");
                ShowText(player, type, doMsgs, "You nod and pocket the vial.");
            }
            else {
                ShowText(player, type, doMsgs, "Keoana ignores you.");
            }
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, GNOMEWIZARD);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HOCUS_SPELL) == 1) {
                ShowText(player, type, doMsgs, "Taemen nods as you pass.");
            }
            else {
                if (GetGuild(player, type, doMsgs) == KNIGHT) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HOCUS_SPELL, 1);
                    GiveSpell(player, type, doMsgs, REFRESH_SPELL, 1);
                    ShowText(player, type, doMsgs, "Taemen teaches you the Refresh spell.");
                }
                else if (GetGuild(player, type, doMsgs) == RANGER) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HOCUS_SPELL, 1);
                    GiveSpell(player, type, doMsgs, HAIL_SPELL, 1);
                    ShowText(player, type, doMsgs, "Taemen teaches you how to cast the Hail spell.");
                }
                else {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HOCUS_SPELL, 1);
                    GiveSpell(player, type, doMsgs, DISSIPATE_SPELL, 1);
                    ShowText(player, type, doMsgs, "Taemen teaches you the Dissipate spell.");
                }
            }
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, HUMANWIZARD);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HOCUS_SKILL) == 1) {
                ShowText(player, type, doMsgs, "Saronel nods as you pass through.");
            }
            else {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HOCUS_SKILL, 1);
                ModAttribute(player, type, doMsgs, AGILITY, 2);
                ModAttribute(player, type, doMsgs, DEFENSE, 1);
                ShowText(player, type, doMsgs, "'Greetings my friends. I am Saronel. I've gotten word that you are doing fine in your studies of the ways of a mage.'");
                ShowText(player, type, doMsgs, "With that he raises his arms and in a flash you sense your defenses improve.");
                ShowText(player, type, doMsgs, "'Continue your journey. Hopefully my gift will aid you on your way.'");
            }
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, NIGHTELFWARRIOR);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HOCUS_MAZE) == 1) {
                ShowText(player, type, doMsgs, "Geadiax nods as you pass.");
            }
            else {
                if (GetGuild(player, type, doMsgs) == CLERIC || GetGuild(player, type, doMsgs) == WIZARD) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HOCUS_MAZE, 1);
                    GiveSpell(player, type, doMsgs, BLAST_SPELL, 1);
                    GiveItem(player, type, doMsgs, JEWELEDBREASTPLATE);
                    GiveItem(player, type, doMsgs, PRIESTLYGARB);
                    ModifyExperience(player, type, doMsgs, 700000);
                    ShowText(player, type, doMsgs, "Geadiax congratulates you on successfully completing your challenge.");
                    ShowText(player, type, doMsgs, "He raises his arms and magically endows you with the Blast spell and presents you with fine gifts.");
                    ShowText(player, type, doMsgs, "You find the experience most rewarding.");
                }
                else if (GetGuild(player, type, doMsgs) == BARBARIAN) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HOCUS_MAZE, 1);
                    GiveItem(player, type, doMsgs, SPIKEDSHIELD);
                    SetSkill(player, type, doMsgs, MARTIAL_ARTS_SKILL, 1);
                    ModifyExperience(player, type, doMsgs, 700000);
                    ShowText(player, type, doMsgs, "Geadiax congratulates you on successfully completing your challenge.");
                    ShowText(player, type, doMsgs, "He raises his arms and magically endows you with the Martial Arts skill and presents you with a fine gift.");
                    ShowText(player, type, doMsgs, "You find the experience most rewarding.");
                }
                else {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HOCUS_MAZE, 1);
                    GiveItem(player, type, doMsgs, TWOHANDEDSWORD);
                    GiveItem(player, type, doMsgs, DEGREEOFVENGEANCE);
                    SetSkill(player, type, doMsgs, DEFLECT_MAGIC_SKILL, 1);
                    ModifyExperience(player, type, doMsgs, 700000);
                    ShowText(player, type, doMsgs, "Geadiax congratulates you on successfully completing your challenge.");
                    ShowText(player, type, doMsgs, "He raises his arms and magically endows you with a skill to deflect magic and presents you with fine gifts.");
                    ShowText(player, type, doMsgs, "You find the experience most rewarding.");
                }
            }
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You open a book which you find on one of the tables.");
            ShowText(player, type, doMsgs, "'Harken, ye, to the report of a great door maze in Hocus Pocus. Yet unto this day, no one has discovered the hiding place of Geadiax, verily I say unto ye.");
            ShowText(player, type, doMsgs, "Tis rumored that he has imprisoned powerful monsters within, to keep the likes such as ye from discovering his whereabouts.'");
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The wizards test what you have learned.");
            if (HasItem(player, type, doMsgs, HEALAMPHORA)) {
                SetTreasure(player, type, doMsgs, SCROLLOFSAFETY, 0, 0, 0, 0, 2000);
            }
            else {
                SetTreasure(player, type, doMsgs, HEALAMPHORA, MANARESTORE, SHAMANSCROLL, 0, 0, 5000);
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 19);
                AddEncounter(player, type, doMsgs, 02, 28);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 8);
                AddEncounter(player, type, doMsgs, 02, 11);
                AddEncounter(player, type, doMsgs, 05, 36);
                AddEncounter(player, type, doMsgs, 06, 37);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 10);
                AddEncounter(player, type, doMsgs, 02, 11);
                AddEncounter(player, type, doMsgs, 03, 8);
                AddEncounter(player, type, doMsgs, 04, 9);
                AddEncounter(player, type, doMsgs, 05, 38);
                AddEncounter(player, type, doMsgs, 06, 28);
            }
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The instructors decide to evaluate your spellcasting abilities.");
            if (HasItem(player, type, doMsgs, ZEUSSCROLL)) {
                SetTreasure(player, type, doMsgs, BOOMERANGSCROLL, AURASCROLL, BASALTSCROLL, 0, 0, 2000);
            }
            else {
                SetTreasure(player, type, doMsgs, ZEUSSCROLL, AURASCROLL, BLOODSCROLL, 0, 0, 3000);
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 25);
                AddEncounter(player, type, doMsgs, 02, 33);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 25);
                AddEncounter(player, type, doMsgs, 02, 25);
                AddEncounter(player, type, doMsgs, 03, 32);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 25);
                AddEncounter(player, type, doMsgs, 02, 25);
                AddEncounter(player, type, doMsgs, 03, 26);
                AddEncounter(player, type, doMsgs, 04, 26);
                AddEncounter(player, type, doMsgs, 05, 27);
            }
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You prepare to show your instructors what you have learned.");
            if (HasItem(player, type, doMsgs, SYMBOLOFDEATH)) {
                SetTreasure(player, type, doMsgs, REFRESHALLSCROLL, CRYSTALSCROLL, 0, 0, 0, 2000);
            }
            else {
                SetTreasure(player, type, doMsgs, SYMBOLOFDEATH, SCROLLOFWIND, HEALALLPOTION, 0, 0, 3000);
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 28);
                AddEncounter(player, type, doMsgs, 02, 35);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 21);
                AddEncounter(player, type, doMsgs, 02, 22);
                AddEncounter(player, type, doMsgs, 05, 28);
                AddEncounter(player, type, doMsgs, 06, 19);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 36);
                AddEncounter(player, type, doMsgs, 02, 37);
                AddEncounter(player, type, doMsgs, 03, 38);
                AddEncounter(player, type, doMsgs, 04, 39);
                AddEncounter(player, type, doMsgs, 05, 17);
                AddEncounter(player, type, doMsgs, 06, 28);
            }
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You are given the chance to practice your spellcasting.");
            SetTreasure(player, type, doMsgs, MANDRAKESTAFF, CURATIVEELIXIR, RUNECHART, 0, 0, 2000);
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 3);
                AddEncounter(player, type, doMsgs, 02, 5);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 02, 2);
                AddEncounter(player, type, doMsgs, 05, 3);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 3);
                AddEncounter(player, type, doMsgs, 02, 4);
                AddEncounter(player, type, doMsgs, 03, 2);
                AddEncounter(player, type, doMsgs, 05, 30);
                AddEncounter(player, type, doMsgs, 06, 30);
            }
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The training hall provides you with battles to test your abilities.");
            if (HasItem(player, type, doMsgs, LIFEGIVER)) {
                SetTreasure(player, type, doMsgs, BINDINGTALISMAN, JADEDRING, 0, 0, 0, 2000);
            }
            else if (!HasItem(player, type, doMsgs, MANARESTORE)) {
                SetTreasure(player, type, doMsgs, LIFEGIVER, MANARESTORE, HEALALLPOTION, 0, 0, 2000);
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 12);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 12);
                AddEncounter(player, type, doMsgs, 02, 13);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 15);
                AddEncounter(player, type, doMsgs, 02, 15);
                AddEncounter(player, type, doMsgs, 03, 16);
                AddEncounter(player, type, doMsgs, 04, 34);
            }
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A stranded Erebus Fiend pounces on you!");
            SetTreasure(player, type, doMsgs, PLATINUMBAR, RINGOFTHIEVES, 0, 0, 0, 10000);
            AddEncounter(player, type, doMsgs, 01, 40);
        }
        protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You disturb a secret meeting.");
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 28);
                AddEncounter(player, type, doMsgs, 05, 6);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 21);
                AddEncounter(player, type, doMsgs, 02, 23);
                AddEncounter(player, type, doMsgs, 05, 30);
                AddEncounter(player, type, doMsgs, 06, 6);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 36);
                AddEncounter(player, type, doMsgs, 02, 37);
                AddEncounter(player, type, doMsgs, 03, 6);
                AddEncounter(player, type, doMsgs, 04, 6);
                AddEncounter(player, type, doMsgs, 05, 32);
                AddEncounter(player, type, doMsgs, 06, 33);
            }
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 8);
                AddEncounter(player, type, doMsgs, 02, 11);
                AddEncounter(player, type, doMsgs, 06, 35);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 9);
                AddEncounter(player, type, doMsgs, 02, 9);
                AddEncounter(player, type, doMsgs, 05, 11);
                AddEncounter(player, type, doMsgs, 06, 11);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 9);
                AddEncounter(player, type, doMsgs, 02, 9);
                AddEncounter(player, type, doMsgs, 03, 10);
                AddEncounter(player, type, doMsgs, 04, 10);
                AddEncounter(player, type, doMsgs, 05, 35);
                AddEncounter(player, type, doMsgs, 06, 35);
            }
        }
        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                ShowText(player, type, doMsgs, "Proceed through the portal for your final test.");
            }
            else {
                ShowText(player, type, doMsgs, "You must proceed through the door in single file.");
                TeleportParty(player, type, doMsgs, 9, 1, 254, Direction.East);
            }
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.HOCUS_DONE, 2);
            SetFlag(player, type, doMsgs, FlagTypeParty, FAERLUN, 0);
            SetFlag(player, type, doMsgs, FlagTypeParty, HOCUS_PASS, 0);
        }
        protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "You see a sign on the door reading, 'DO NOT ENTER'.");
        }
    }
}
