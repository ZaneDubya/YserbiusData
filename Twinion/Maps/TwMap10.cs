using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    class TwMap10 : TwMap {
        public override int MapIndex => 10;
        public override int MapID => 0x0403;
        protected override int RandomEncounterChance => 12;
        protected override int RandomEncounterExtraCount => 2;

        private const int ARMORY_ZAP_ONE = 2;
        private const int ARMORY_ZAP_THREE = 3;
        private const int SHIELD_ZAP = 4;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int flags = 0;
            flags = GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARMORY_ITEM) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.JACKET);
            if (GetGuild(player, type, doMsgs) == WIZARD) {
                FoundRoom(player, type, doMsgs);
                switch (flags) {
                    case 1:
                        GiveExp(player, type, doMsgs);
                        GiveItem(player, type, doMsgs, WIZARDSSASH);
                        break;
                    case 2:
                        if (HasItem(player, type, doMsgs, WIZARDSSASH)) {
                            EmptyRoom(player, type, doMsgs);
                        }
                        else {
                            GiveItem(player, type, doMsgs, WIZARDSSASH);
                            ArmReplace(player, type, doMsgs);
                        }
                        break;
                    case 3:
                        EmptyRoom(player, type, doMsgs);
                        break;
                }
            }
            else {
                ShowText(player, type, doMsgs, "Only Wizards gain their reward here.");
            }
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int flags = 0;
            flags = GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARMORY_ITEM) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.JACKET);
            if (GetGuild(player, type, doMsgs) == CLERIC) {
                FoundRoom(player, type, doMsgs);
                switch (flags) {
                    case 1:
                        GiveExp(player, type, doMsgs);
                        GiveItem(player, type, doMsgs, CLERICSCHAINMAIL);
                        break;
                    case 2:
                        if (HasItem(player, type, doMsgs, CLERICSCHAINMAIL)) {
                            EmptyRoom(player, type, doMsgs);
                        }
                        else {
                            GiveItem(player, type, doMsgs, CLERICSCHAINMAIL);
                            ArmReplace(player, type, doMsgs);
                        }
                        break;
                    case 3:
                        EmptyRoom(player, type, doMsgs);
                        break;
                }
            }
            else {
                ShowText(player, type, doMsgs, "Only Clerics gain their reward here.");
            }
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 4, 3, 201, Direction.North);
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableHealing(player, type, doMsgs);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SHIELD_ZAP) == 0)) {
                if (GetFlag(player, type, doMsgs, FlagTypeParty, ARMORY_ZAP_ONE) == 1) {
                    ShowText(player, type, doMsgs, "The trap is disarmed.");
                }
                else {
                    DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 2);
                    ShowText(player, type, doMsgs, "A trap unleashes a shower of arrows at you.");
                    SetFlag(player, type, doMsgs, FlagTypeTile, SHIELD_ZAP, 1);
                }
            }
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int flags = 0;
            flags = GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARMORY_ITEM) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.JACKET);
            if (GetGuild(player, type, doMsgs) == THIEF) {
                FoundRoom(player, type, doMsgs);
                switch (flags) {
                    case 1:
                        GiveExp(player, type, doMsgs);
                        GiveItem(player, type, doMsgs, THIEFSJACKET);
                        break;
                    case 2:
                        if (HasItem(player, type, doMsgs, THIEFSJACKET)) {
                            EmptyRoom(player, type, doMsgs);
                        }
                        else {
                            GiveItem(player, type, doMsgs, THIEFSJACKET);
                            ArmReplace(player, type, doMsgs);
                        }
                        break;
                    case 3:
                        EmptyRoom(player, type, doMsgs);
                        break;
                }
            }
            else {
                ShowText(player, type, doMsgs, "Only Thieves gain their reward here.");
            }
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A message on the wall - 'One of your party members must stay in the Armory until light is shed on your purpose. He who remains must at least lead once upon your return. Then, you may alter your formation.'");
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Do not proceed north unless you have disarmed the traps.");
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GRIMOIRE) == 1) {
                ShowText(player, type, doMsgs, "The waters of Grimoire Fountain have no affect.");
            }
            else {
                if (GetGuild(player, type, doMsgs) == KNIGHT) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GRIMOIRE, 1);
                    GiveSpell(player, type, doMsgs, HEAL_SPELL, 1);
                    ShowText(player, type, doMsgs, "The magical waters of Grimoire Fountain enlighten you in the art of healing.");
                }
                else if (GetGuild(player, type, doMsgs) == THIEF) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GRIMOIRE, 1);
                    GiveSpell(player, type, doMsgs, HAIL_SPELL, 1);
                    ShowText(player, type, doMsgs, "The magical waters of Grimoire Fountain turn cold as you acquire the Hail spell.");
                }
                else if (GetGuild(player, type, doMsgs) == WIZARD) {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GRIMOIRE, 1);
                    GiveSpell(player, type, doMsgs, AURA_SPELL, 1);
                    ShowText(player, type, doMsgs, "The magical waters of Grimoire Fountain envelop you in a mystic aura which whispers its secrets in your ear.");
                }
                else {
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GRIMOIRE, 1);
                    GiveSpell(player, type, doMsgs, SHROUD_OF_LIGHT_SPELL, 1);
                    ShowText(player, type, doMsgs, "The magical waters of Grimoire Fountain envelop you in a shroud of light.");
                }
            }
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeParty, ARMORY_ZAP_ONE) == 1) {
                WallClear(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The door swings open.");
            }
            else {
                ShowText(player, type, doMsgs, "The door to the south is locked.");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 4, 3, 113, Direction.East);
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
            ModifyHealth(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
            ShowText(player, type, doMsgs, "The piercing waters of Saber Fountain restore you to full health.");
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Debris litters the floor, a result of the prodding and poking of the walls by adventurers searching for secret doors.");
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 4, 3, 245, Direction.West);
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasUsedSkill(player, type, ref doMsgs, DETECT_SKILL) >= 5 || HasUsedSpell(player, type, ref doMsgs, TRUE_SEEING_SPELL) >= 1 || UsedItem(player, type, ref doMsgs, HELMOFWISDOM, HELMOFWISDOM) || UsedItem(player, type, ref doMsgs, VALKYRIESHELM, VALKYRIESHELM) || UsedItem(player, type, ref doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || UsedItem(player, type, ref doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                switch (GetTile(player, type, doMsgs)) {
                    case 54:
                    case 77:
                    case 87:
                    case 226:
                        ShowText(player, type, doMsgs, "A hidden door appears.");
                        WallClear(player, type, doMsgs);
                        break;
                    default:
                        ShowText(player, type, doMsgs, "You detect a secret door.");
                        WallClear(player, type, doMsgs);
                        break;
                }
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 4, 3, 199, Direction.South);
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ModifyMana(player, type, doMsgs,  - 200);
            ShowText(player, type, doMsgs, "Miasmal gases seep up through the floor, sapping your mana.");
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetFlag(player, type, doMsgs, FlagTypeParty, ARMORY_ZAP_ONE, 1);
            ShowText(player, type, doMsgs, "You bump into a shield in the center of the room.");
            ShowText(player, type, doMsgs, "It falls and hits a switch which unlocks a door and disarms traps.");
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARMORY_ITEM) == 1) {
                ShowText(player, type, doMsgs, "The armorer has taken your key and forged you another. It can be found from whence the original came. This key will enable you to access new doors.");
            }
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (UsedItem(player, type, ref doMsgs, FELLOWSHIPKEY, FELLOWSHIPKEY)) {
                WallClear(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The Fellowship Key unlocks the door.");
            }
            else {
                WallBlock(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The door is locked. On the door is a plaque, showing two arms clasped in friendship.");
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, SPIDERSILKHELM)) {
                ShowText(player, type, doMsgs, "Your helm protects you from the poisonous darts.");
            }
            else {
                SetDebuff(player, type, doMsgs, POISON, 5, GetHealthMax(player, type, doMsgs) / 2);
                DisableSkills(player, type, doMsgs);
                DisableSpells(player, type, doMsgs);
                ShowText(player, type, doMsgs, "Your helm is no protection from the poisonous darts that hit you.");
            }
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeTile, SHIELD_ZAP) == 0) {
                DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs) / 10);
                ShowText(player, type, doMsgs, "A loose shield that is mounted on the wall falls and smacks you on the head.");
                SetFlag(player, type, doMsgs, FlagTypeTile, SHIELD_ZAP, 1);
            }
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetFlag(player, type, doMsgs, FlagTypeParty, ARMORY_ZAP_THREE, 1);
            ShowText(player, type, doMsgs, "Your foot brushes a stick, which you see is actually a wand.");
            ShowText(player, type, doMsgs, "As it begins to glow, you hear the unlocking of a door.");
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 4, 3, 200, Direction.East);
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == WIZARD) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 4, 3, 16, Direction.East);
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, FOUNTAIN);
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TRIDENT) == 1) {
                ModifyMana(player, type, doMsgs, 10000);
                ShowText(player, type, doMsgs, "The silvery waters of Trident Fountain replenish your mana.");
            }
            else {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TRIDENT, 1);
                ModifyMana(player, type, doMsgs, 10000);
                if (GetGuild(player, type, doMsgs) == THIEF) {
                    GiveSpell(player, type, doMsgs, RESIST_SPELL, 1);
                    ShowText(player, type, doMsgs, "The silvery waters of Trident Fountain replenish your mana and empower you with the Resist spell.");
                }
                else {
                    GiveSpell(player, type, doMsgs, SHIELD_SPELL, 1);
                    ShowText(player, type, doMsgs, "The silvery waters of Trident Fountain replenish your mana and empower you with the Shield spell.");
                }
            }
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == CLERIC) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 4, 3, 24, Direction.West);
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeParty, ARMORY_ZAP_THREE) == 1) {
                WallClear(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The door is open.");
                ShowText(player, type, doMsgs, "The magic wand sign on the door has been zapped.");
            }
            else {
                ShowText(player, type, doMsgs, "The door is locked.");
                ShowText(player, type, doMsgs, "Upon the door is the sign of a magic wand. If the wand is zapped, the door will open.");
                ShowText(player, type, doMsgs, "Someone has scrawled under the sign - 'When the wand is zapped, stay in the area until you open the door.'");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, SPIDERSILKHELM)) {
                WallClear(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The guard sees your Spidersilk Helm and lets you enter.");
            }
            else {
                WallBlock(player, type, doMsgs);
                ShowPortrait(player, type, doMsgs, HUMANBARBARIAN);
                ShowText(player, type, doMsgs, "You see a guard at the door wiping tiny spiders from his helmet:");
                ShowText(player, type, doMsgs, "'My hat's off to you,' he says, barking a shrill laugh.");
                ShowText(player, type, doMsgs, "'The right helm lets you pass. The wrong helm won't.'");
            }
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == THIEF) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 4, 3, 30, Direction.North);
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 4, 1, 58, Direction.South);
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (UsedItem(player, type, ref doMsgs, BLUELOCKPICK, BLUELOCKPICK) || UsedItem(player, type, ref doMsgs, HELMOFGUILE, HELMOFGUILE) || HasUsedSkill(player, type, ref doMsgs, LOCKPICK_SKILL) >= 6) {
                ShowText(player, type, doMsgs, "You skillfully unlock the door.");
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
                ShowText(player, type, doMsgs, "The door is locked.");
            }
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == BARBARIAN || GetGuild(player, type, doMsgs) == KNIGHT) {
                if (GetAttribute(player, type, doMsgs, STRENGTH) >= 24) {
                    WallClear(player, type, doMsgs);
                    ShowText(player, type, doMsgs, "After considerable effort, you manage to force open the door.");
                }
                else {
                    WallBlock(player, type, doMsgs);
                    ShowText(player, type, doMsgs, "You are not strong enough to open the door.");
                }
            }
            else if (GetGuild(player, type, doMsgs) == CLERIC || GetGuild(player, type, doMsgs) == RANGER) {
                if (GetAttribute(player, type, doMsgs, STRENGTH) >= 20) {
                    WallClear(player, type, doMsgs);
                    ShowText(player, type, doMsgs, "After considerable effort, you manage to force open the door.");
                }
                else {
                    WallBlock(player, type, doMsgs);
                    ShowText(player, type, doMsgs, "You are not strong enough to open the door.");
                }
            }
            else {
                if (GetAttribute(player, type, doMsgs, STRENGTH) >= 15) {
                    WallClear(player, type, doMsgs);
                    ShowText(player, type, doMsgs, "After considerable effort, you manage to force open the door.");
                }
                else {
                    WallBlock(player, type, doMsgs);
                    ShowText(player, type, doMsgs, "You cannot find the strength to push open the door.");
                }
            }
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, DWARFKNIGHT);
            ShowText(player, type, doMsgs, "A knight mumbles to himself -");
            ShowText(player, type, doMsgs, "'Confusing li'l thief. He's obviously been in the lower depths of this bizarre Night Elf kingdom.'");
            ShowText(player, type, doMsgs, "The knight notices you and turns to you.");
            ShowText(player, type, doMsgs, "'The dralks...or some such thing, they are what these Elves worship.'");
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == RANGER) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 4, 3, 225, Direction.South);
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "To The Vault.");
            TeleportParty(player, type, doMsgs, 5, 1, 70, Direction.East);
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == KNIGHT) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 4, 3, 248, Direction.North);
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetFlag(player, type, doMsgs, FlagTypeParty, ARMORY_ZAP_ONE, 0);
            SetFlag(player, type, doMsgs, FlagTypeParty, ARMORY_ZAP_THREE, 0);
            if (HasItem(player, type, doMsgs, LUMINOUSLANTERN)) {
                EmptyRoom(player, type, doMsgs);
            }
            else {
                GiveItem(player, type, doMsgs, LUMINOUSLANTERN);
                ShowText(player, type, doMsgs, "A Lantern lies on the floor. It will help during your future explorations. Mark well that it was here when you needed it!");
            }
        }
        protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, TROLLCLERIC);
            if (HasItem(player, type, doMsgs, SPIDERSILKHELM)) {
                ShowText(player, type, doMsgs, "The Troll Cleric, seeing you are well protected, decides to leave.");
            }
            else {
                GiveItem(player, type, doMsgs, SPIDERSILKHELM);
                ModifyGold(player, type, doMsgs,  - 5000);
                ShowText(player, type, doMsgs, "A Troll Cleric grabs your arm -");
                ShowText(player, type, doMsgs, "'You will want this helm of protection to safeguard you on your journey.");
                ShowText(player, type, doMsgs, "It's sure to impress some of the guards you'll meet in your journeys.");
                ShowText(player, type, doMsgs, "No need to thank me. I've taken..er..accepted your generous donation already.'");
            }
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A band of Night Elves tries to steal your armor.");
            if (HasItem(player, type, doMsgs, AMULETOFPROTECTION) || HasItem(player, type, doMsgs, BASALTSCROLL)) {
                SetTreasure(player, type, doMsgs, ELIXIROFHEALTH, CRYSTALSCROLL, 0, 0, 0, 1500);
            }
            else {
                SetTreasure(player, type, doMsgs, AMULETOFPROTECTION, BASALTSCROLL, 0, 0, 0, 3000);
            }
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 3);
                AddEncounter(player, type, doMsgs, 02, 4);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 3);
                AddEncounter(player, type, doMsgs, 02, 3);
                AddEncounter(player, type, doMsgs, 03, 5);
                AddEncounter(player, type, doMsgs, 04, 4);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 3);
                AddEncounter(player, type, doMsgs, 02, 3);
                AddEncounter(player, type, doMsgs, 03, 5);
                AddEncounter(player, type, doMsgs, 05, 4);
                AddEncounter(player, type, doMsgs, 06, 4);
            }
        }
        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 5, 1, 238, Direction.West);
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetGuild(player, type, doMsgs) == BARBARIAN) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 4, 3, 238, Direction.South);
        }
        protected override void FnEvent3B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Fellowship Meeting Hall");
        }
        protected override void FnEvent3D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int flags = 0;
            flags = GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARMORY_ITEM) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.JACKET);
            if (GetGuild(player, type, doMsgs) == KNIGHT) {
                FoundRoom(player, type, doMsgs);
                switch (flags) {
                    case 1:
                        GiveExp(player, type, doMsgs);
                        GiveItem(player, type, doMsgs, KNIGHTSBREASTPLATE);
                        break;
                    case 2:
                        if (HasItem(player, type, doMsgs, KNIGHTSBREASTPLATE)) {
                            EmptyRoom(player, type, doMsgs);
                        }
                        else {
                            GiveItem(player, type, doMsgs, KNIGHTSBREASTPLATE);
                            ArmReplace(player, type, doMsgs);
                        }
                        break;
                    case 3:
                        EmptyRoom(player, type, doMsgs);
                        break;
                }
            }
            else {
                ShowText(player, type, doMsgs, "Only Knights gain their reward here.");
            }
        }
        protected override void FnEvent3F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TeleportParty(player, type, doMsgs, 4, 3, 206, Direction.North);
        }
        protected override void FnEvent41(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int flags = 0;
            flags = GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARMORY_ITEM) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.JACKET);
            if (GetGuild(player, type, doMsgs) == RANGER) {
                FoundRoom(player, type, doMsgs);
                switch (flags) {
                    case 1:
                        GiveExp(player, type, doMsgs);
                        GiveItem(player, type, doMsgs, RANGERSCHAINMAIL);
                        break;
                    case 2:
                        if (HasItem(player, type, doMsgs, RANGERSCHAINMAIL)) {
                            EmptyRoom(player, type, doMsgs);
                        }
                        else {
                            GiveItem(player, type, doMsgs, RANGERSCHAINMAIL);
                            ArmReplace(player, type, doMsgs);
                        }
                        break;
                    case 3:
                        EmptyRoom(player, type, doMsgs);
                        break;
                }
            }
            else {
                ShowText(player, type, doMsgs, "Only Rangers gain their reward here.");
            }
        }
        protected override void FnEvent43(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int flags = 0;
            flags = GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARMORY_ITEM) + GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.JACKET);
            if (GetGuild(player, type, doMsgs) == BARBARIAN) {
                FoundRoom(player, type, doMsgs);
                switch (flags) {
                    case 1:
                        GiveExp(player, type, doMsgs);
                        GiveItem(player, type, doMsgs, BARBARIANSPLATE);
                        break;
                    case 2:
                        if (HasItem(player, type, doMsgs, BARBARIANSPLATE)) {
                            EmptyRoom(player, type, doMsgs);
                        }
                        else {
                            GiveItem(player, type, doMsgs, BARBARIANSPLATE);
                            ArmReplace(player, type, doMsgs);
                        }
                        break;
                    case 3:
                        EmptyRoom(player, type, doMsgs);
                        break;
                }
            }
            else {
                ShowText(player, type, doMsgs, "Only Barbarians gain their reward here.");
            }
        }
        protected override void FnEvent44(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 7);
                AddEncounter(player, type, doMsgs, 02, 7);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 9);
                AddEncounter(player, type, doMsgs, 02, 9);
                AddEncounter(player, type, doMsgs, 03, 11);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 10);
                AddEncounter(player, type, doMsgs, 02, 10);
                AddEncounter(player, type, doMsgs, 03, 7);
                AddEncounter(player, type, doMsgs, 05, 11);
                AddEncounter(player, type, doMsgs, 06, 11);
            }
        }
        protected override void FnEvent45(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 31);
                AddEncounter(player, type, doMsgs, 02, 32);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 31);
                AddEncounter(player, type, doMsgs, 02, 32);
                AddEncounter(player, type, doMsgs, 06, 33);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 31);
                AddEncounter(player, type, doMsgs, 02, 31);
                AddEncounter(player, type, doMsgs, 03, 32);
                AddEncounter(player, type, doMsgs, 04, 32);
                AddEncounter(player, type, doMsgs, 06, 33);
            }
        }
        protected override void FnEvent46(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 02, 4);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 36);
                AddEncounter(player, type, doMsgs, 02, 3);
                AddEncounter(player, type, doMsgs, 06, 39);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 36);
                AddEncounter(player, type, doMsgs, 02, 37);
                AddEncounter(player, type, doMsgs, 03, 38);
                AddEncounter(player, type, doMsgs, 04, 39);
                AddEncounter(player, type, doMsgs, 05, 40);
            }
        }
        protected override void FnEvent47(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 15);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 12);
                AddEncounter(player, type, doMsgs, 02, 12);
                AddEncounter(player, type, doMsgs, 03, 13);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 12);
                AddEncounter(player, type, doMsgs, 02, 12);
                AddEncounter(player, type, doMsgs, 03, 15);
                AddEncounter(player, type, doMsgs, 05, 13);
                AddEncounter(player, type, doMsgs, 06, 13);
            }
        }
        protected override void FnEvent49(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 02, 6);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 02, 6);
                AddEncounter(player, type, doMsgs, 05, 2);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 1);
                AddEncounter(player, type, doMsgs, 02, 6);
                AddEncounter(player, type, doMsgs, 03, 6);
                AddEncounter(player, type, doMsgs, 05, 3);
                AddEncounter(player, type, doMsgs, 06, 4);
            }
        }
        protected override void FnEvent4A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 29);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 20);
                AddEncounter(player, type, doMsgs, 02, 20);
                AddEncounter(player, type, doMsgs, 06, 21);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 20);
                AddEncounter(player, type, doMsgs, 02, 20);
                AddEncounter(player, type, doMsgs, 03, 24);
                AddEncounter(player, type, doMsgs, 04, 24);
                AddEncounter(player, type, doMsgs, 06, 38);
            }
        }
        protected override void FnEvent4B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyCount(player, type, doMsgs) == 1) {
                AddEncounter(player, type, doMsgs, 01, 28);
            }
            else if (GetPartyCount(player, type, doMsgs) == 2) {
                AddEncounter(player, type, doMsgs, 01, 28);
                AddEncounter(player, type, doMsgs, 02, 28);
                AddEncounter(player, type, doMsgs, 06, 35);
            }
            else {
                AddEncounter(player, type, doMsgs, 01, 28);
                AddEncounter(player, type, doMsgs, 02, 28);
                AddEncounter(player, type, doMsgs, 04, 34);
                AddEncounter(player, type, doMsgs, 05, 35);
                AddEncounter(player, type, doMsgs, 06, 35);
            }
        }
        private void FoundRoom(TwPlayerServer player, MapEventType type, bool doMsgs) {
            RemoveItem(player, type, doMsgs, FELLOWSHIPKEY);
            RemoveItem(player, type, doMsgs, SKELETONKEY);
            ShowText(player, type, doMsgs, "Congratulations, you have found a secret armory room.");
            ShowText(player, type, doMsgs, "In exchange, you must sacrifice the bone and your Fellowship!");
        }
        private void GiveExp(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ModifyExperience(player, type, doMsgs, 50000);
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARMORY_ITEM, 1);
            ShowText(player, type, doMsgs, "This Guild armor and experience will help you on your journey.");
        }
        private void EmptyRoom(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The room appears to have been looted.");
        }
        private void ArmReplace(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Here's a replacement for your lost armor.");
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ARMORY_ITEM, 2);
        }
        private void WallClear(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void GuildDoor(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (UsedItem(player, type, ref doMsgs, SKELETONKEY, SKELETONKEY)) {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ShowText(player, type, doMsgs, "Your Skeleton Key unlocks the door.");
            }
            else {
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ShowText(player, type, doMsgs, "The door is locked. Someone has painted a skull and crossed arm bones on the door.");
            }
        }
    }
}
