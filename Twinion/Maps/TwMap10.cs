using XPT.Generic.Maps;
using XPT.Twinion.Entities;

namespace XPT.Twinion.Maps {
    class TwMap10 : TwMap {
        protected override int MapIndex => 10;
        protected override int MapID => 0x0403;
        protected override int RandomEncounterChance => 12;
        protected override int RandomEncounterExtraCount => 2;

        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short flags;
            flags = GET_FLAG(player, type, doMsgs, DUNGEON, ARMORY_ITEM);
             + GET_FLAG(player, type, doMsgs, DUNGEON, JACKET);
            if (GUILD() == WIZARD) {
                FoundRoom(player, type, doMsgs);
                switch (flags) {
                    case 1:
                        GiveExp(player, type, doMsgs);
                        GIVE_ITEM(player, type, doMsgs, WIZARDSSASH);
                        break;
                    case 2:
                        if (HAS_ITEM(player, type, doMsgs, WIZARDSSASH)) {
                            EmptyRoom(player, type, doMsgs);
                        }
                        else {
                            GIVE_ITEM(player, type, doMsgs, WIZARDSSASH);
                            ArmReplace(player, type, doMsgs);
                        }
                        break;
                    case 3:
                        EmptyRoom(player, type, doMsgs);
                        break;
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Only Wizards gain their reward here.");
            }
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short flags;
            flags = GET_FLAG(player, type, doMsgs, DUNGEON, ARMORY_ITEM);
             + GET_FLAG(player, type, doMsgs, DUNGEON, JACKET);
            if (GUILD() == CLERIC) {
                FoundRoom(player, type, doMsgs);
                switch (flags) {
                    case 1:
                        GiveExp(player, type, doMsgs);
                        GIVE_ITEM(player, type, doMsgs, CLERICSCHAINMAIL);
                        break;
                    case 2:
                        if (HAS_ITEM(player, type, doMsgs, CLERICSCHAINMAIL)) {
                            EmptyRoom(player, type, doMsgs);
                        }
                        else {
                            GIVE_ITEM(player, type, doMsgs, CLERICSCHAINMAIL);
                            ArmReplace(player, type, doMsgs);
                        }
                        break;
                    case 3:
                        EmptyRoom(player, type, doMsgs);
                        break;
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Only Clerics gain their reward here.");
            }
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 4, 3, 201, NORTH);
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_HEAL_ZONE();
            if (!GET_FLAG(player, type, doMsgs, ROOM, SHIELD_ZAP)) {
                if (GET_FLAG(player, type, doMsgs, PARTY, ARMORY_ZAP_ONE) == 1) {
                    SHOW_TEXT(player, type, doMsgs, "The trap is disarmed.");
                }
                else {
                    DAMAGE(player, type, doMsgs, MAX_HEALTH() / 2);
                    SHOW_TEXT(player, type, doMsgs, "A trap unleashes a shower of arrows at you.");
                    SET_FLAG(player, type, doMsgs, ROOM, SHIELD_ZAP, 1);
                }
            }
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short flags;
            flags = GET_FLAG(player, type, doMsgs, DUNGEON, ARMORY_ITEM);
             + GET_FLAG(player, type, doMsgs, DUNGEON, JACKET);
            if (GUILD() == THIEF) {
                FoundRoom(player, type, doMsgs);
                switch (flags) {
                    case 1:
                        GiveExp(player, type, doMsgs);
                        GIVE_ITEM(player, type, doMsgs, THIEFSJACKET);
                        break;
                    case 2:
                        if (HAS_ITEM(player, type, doMsgs, THIEFSJACKET)) {
                            EmptyRoom(player, type, doMsgs);
                        }
                        else {
                            GIVE_ITEM(player, type, doMsgs, THIEFSJACKET);
                            ArmReplace(player, type, doMsgs);
                        }
                        break;
                    case 3:
                        EmptyRoom(player, type, doMsgs);
                        break;
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Only Thieves gain their reward here.");
            }
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A message on the wall - 'One of your party members must stay in the Armory until light is shed on your purpose. He who remains must at least lead once upon your return. Then, you may alter your formation.'");
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Do not proceed north unless you have disarmed the traps.");
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, GRIMOIRE) == 1) {
                SHOW_TEXT(player, type, doMsgs, "The waters of Grimoire Fountain have no affect.");
            }
            else {
                if (GUILD() == KNIGHT) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, GRIMOIRE, 1);
                    GIVE_SPELL(player, type, doMsgs, HEAL_SPELL, 1);
                    SHOW_TEXT(player, type, doMsgs, "The magical waters of Grimoire Fountain enlighten you in the art of healing.");
                }
                else if (GUILD() == THIEF) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, GRIMOIRE, 1);
                    GIVE_SPELL(player, type, doMsgs, HAIL_SPELL, 1);
                    SHOW_TEXT(player, type, doMsgs, "The magical waters of Grimoire Fountain turn cold as you acquire the Hail spell.");
                }
                else if (GUILD() == WIZARD) {
                    SET_FLAG(player, type, doMsgs, DUNGEON, GRIMOIRE, 1);
                    GIVE_SPELL(player, type, doMsgs, AURA_SPELL, 1);
                    SHOW_TEXT(player, type, doMsgs, "The magical waters of Grimoire Fountain envelop you in a mystic aura which whispers its secrets in your ear.");
                }
                else {
                    SET_FLAG(player, type, doMsgs, DUNGEON, GRIMOIRE, 1);
                    GIVE_SPELL(player, type, doMsgs, SHROUD_OF_LIGHT_SPELL, 1);
                    SHOW_TEXT(player, type, doMsgs, "The magical waters of Grimoire Fountain envelop you in a shroud of light.");
                }
            }
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, PARTY, ARMORY_ZAP_ONE) == 1) {
                WallClear(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The door swings open.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The door to the south is locked.");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 4, 3, 113, EAST);
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
            HEAL(player, type, doMsgs, MAX_HEALTH());
            SHOW_TEXT(player, type, doMsgs, "The piercing waters of Saber Fountain restore you to full health.");
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Debris litters the floor, a result of the prodding and poking of the walls by adventurers searching for secret doors.");
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 4, 3, 245, WEST);
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_SKILL(player, type, doMsgs, DETECT_SKILL) >= 5 || USED_SPELL(player, type, doMsgs, TRUE_SEEING_SPELL) || USED_ITEM(player, type, doMsgs, HELMOFWISDOM, HELMOFWISDOM) || USED_ITEM(player, type, doMsgs, VALKYRIESHELM, VALKYRIESHELM) || USED_ITEM(player, type, doMsgs, RINGOFTHIEVES, RINGOFTHIEVES) || USED_ITEM(player, type, doMsgs, CRYSTALBALL, CRYSTALBALL)) {
                switch (HERE()) {
                    case 54:
                    case 77:
                    case 87:
                    case 226:
                        SHOW_TEXT(player, type, doMsgs, "A hidden door appears.");
                        WallClear(player, type, doMsgs);
                        break;
                    default:
                        SHOW_TEXT(player, type, doMsgs, "You detect a secret door.");
                        WallClear(player, type, doMsgs);
                        break;
                }
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 4, 3, 199, SOUTH);
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            MOD_MANA(player, type, doMsgs,  - 200);
            SHOW_TEXT(player, type, doMsgs, "Miasmal gases seep up through the floor, sapping your mana.");
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_FLAG(player, type, doMsgs, PARTY, ARMORY_ZAP_ONE, 1);
            SHOW_TEXT(player, type, doMsgs, "You bump into a shield in the center of the room.");
            SHOW_TEXT(player, type, doMsgs, "It falls and hits a switch which unlocks a door and disarms traps.");
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, ARMORY_ITEM) == 1) {
                SHOW_TEXT(player, type, doMsgs, "The armorer has taken your key and forged you another. It can be found from whence the original came. This key will enable you to access new doors.");
            }
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_ITEM(player, type, doMsgs, FELLOWSHIPKEY, FELLOWSHIPKEY)) {
                WallClear(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The Fellowship Key unlocks the door.");
            }
            else {
                WallBlock(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The door is locked. On the door is a plaque, showing two arms clasped in friendship.");
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, SPIDERSILKHELM)) {
                SHOW_TEXT(player, type, doMsgs, "Your helm protects you from the poisonous darts.");
            }
            else {
                SET_PM(player, type, doMsgs, POISON, 5, MAX_HEALTH() / 2);
                NO_SKILL();
                NO_SPELL();
                SHOW_TEXT(player, type, doMsgs, "Your helm is no protection from the poisonous darts that hit you.");
            }
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, ROOM, SHIELD_ZAP) == 0) {
                DAMAGE(player, type, doMsgs, MAX_HEALTH() / 10);
                SHOW_TEXT(player, type, doMsgs, "A loose shield that is mounted on the wall falls and smacks you on the head.");
                SET_FLAG(player, type, doMsgs, ROOM, SHIELD_ZAP, 1);
            }
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_FLAG(player, type, doMsgs, PARTY, ARMORY_ZAP_THREE, 1);
            SHOW_TEXT(player, type, doMsgs, "Your foot brushes a stick, which you see is actually a wand.");
            SHOW_TEXT(player, type, doMsgs, "As it begins to glow, you hear the unlocking of a door.");
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 4, 3, 200, EAST);
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD() == WIZARD) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 4, 3, 16, EAST);
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, TRIDENT) == 1) {
                MOD_MANA(player, type, doMsgs, 10000);
                SHOW_TEXT(player, type, doMsgs, "The silvery waters of Trident Fountain replenish your mana.");
            }
            else {
                SET_FLAG(player, type, doMsgs, DUNGEON, TRIDENT, 1);
                MOD_MANA(player, type, doMsgs, 10000);
                if (GUILD() == THIEF) {
                    GIVE_SPELL(player, type, doMsgs, RESIST_SPELL, 1);
                    SHOW_TEXT(player, type, doMsgs, "The silvery waters of Trident Fountain replenish your mana and empower you with the Resist spell.");
                }
                else {
                    GIVE_SPELL(player, type, doMsgs, SHIELD_SPELL, 1);
                    SHOW_TEXT(player, type, doMsgs, "The silvery waters of Trident Fountain replenish your mana and empower you with the Shield spell.");
                }
            }
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD() == CLERIC) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 4, 3, 24, WEST);
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, PARTY, ARMORY_ZAP_THREE) == 1) {
                WallClear(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The door is open.");
                SHOW_TEXT(player, type, doMsgs, "The magic wand sign on the door has been zapped.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The door is locked.");
                SHOW_TEXT(player, type, doMsgs, "Upon the door is the sign of a magic wand. If the wand is zapped, the door will open.");
                SHOW_TEXT(player, type, doMsgs, "Someone has scrawled under the sign - 'When the wand is zapped, stay in the area until you open the door.'");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, SPIDERSILKHELM)) {
                WallClear(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The guard sees your Spidersilk Helm and lets you enter.");
            }
            else {
                WallBlock(player, type, doMsgs);
                SHOW_PICTURE(player, type, doMsgs, HUMANBARBARIAN);
                SHOW_TEXT(player, type, doMsgs, "You see a guard at the door wiping tiny spiders from his helmet:");
                SHOW_TEXT(player, type, doMsgs, "'My hat's off to you,' he says, barking a shrill laugh.");
                SHOW_TEXT(player, type, doMsgs, "'The right helm lets you pass. The wrong helm won't.'");
            }
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD() == THIEF) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 4, 3, 30, NORTH);
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 4, 1, 58, SOUTH);
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_ITEM(player, type, doMsgs, BLUELOCKPICK, BLUELOCKPICK) || USED_ITEM(player, type, doMsgs, HELMOFGUILE, HELMOFGUILE) || USED_SKILL(player, type, doMsgs, LOCKPICK_SKILL) >= 6) {
                SHOW_TEXT(player, type, doMsgs, "You skillfully unlock the door.");
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The door is locked.");
            }
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD() == BARBARIAN || GUILD() == KNIGHT) {
                if (GET_STAT(player, type, doMsgs, STRENGTH) >= 24) {
                    WallClear(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "After considerable effort, you manage to force open the door.");
                }
                else {
                    WallBlock(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "You are not strong enough to open the door.");
                }
            }
            else if (GUILD() == CLERIC || GUILD() == RANGER) {
                if (GET_STAT(player, type, doMsgs, STRENGTH) >= 20) {
                    WallClear(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "After considerable effort, you manage to force open the door.");
                }
                else {
                    WallBlock(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "You are not strong enough to open the door.");
                }
            }
            else {
                if (GET_STAT(player, type, doMsgs, STRENGTH) >= 15) {
                    WallClear(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "After considerable effort, you manage to force open the door.");
                }
                else {
                    WallBlock(player, type, doMsgs);
                    SHOW_TEXT(player, type, doMsgs, "You cannot find the strength to push open the door.");
                }
            }
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, DWARFKNIGHT);
            SHOW_TEXT(player, type, doMsgs, "A knight mumbles to himself -");
            SHOW_TEXT(player, type, doMsgs, "'Confusing li'l thief. He's obviously been in the lower depths of this bizarre Night Elf kingdom.'");
            SHOW_TEXT(player, type, doMsgs, "The knight notices you and turns to you.");
            SHOW_TEXT(player, type, doMsgs, "'The dralks...or some such thing, they are what these Elves worship.'");
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD() == RANGER) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 4, 3, 225, SOUTH);
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "To The Vault.");
            TELEPORT(player, type, doMsgs, 5, 1, 70, EAST);
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD() == KNIGHT) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 4, 3, 248, NORTH);
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SET_FLAG(player, type, doMsgs, PARTY, ARMORY_ZAP_ONE, 0);
            SET_FLAG(player, type, doMsgs, PARTY, ARMORY_ZAP_THREE, 0);
            if (HAS_ITEM(player, type, doMsgs, LUMINOUSLANTERN)) {
                EmptyRoom(player, type, doMsgs);
            }
            else {
                GIVE_ITEM(player, type, doMsgs, LUMINOUSLANTERN);
                SHOW_TEXT(player, type, doMsgs, "A Lantern lies on the floor. It will help during your future explorations. Mark well that it was here when you needed it!");
            }
        }
        protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, TROLLCLERIC);
            if (HAS_ITEM(player, type, doMsgs, SPIDERSILKHELM)) {
                SHOW_TEXT(player, type, doMsgs, "The Troll Cleric, seeing you are well protected, decides to leave.");
            }
            else {
                GIVE_ITEM(player, type, doMsgs, SPIDERSILKHELM);
                MOD_GOLD(player, type, doMsgs,  - 5000);
                SHOW_TEXT(player, type, doMsgs, "A Troll Cleric grabs your arm -");
                SHOW_TEXT(player, type, doMsgs, "'You will want this helm of protection to safeguard you on your journey.");
                SHOW_TEXT(player, type, doMsgs, "It's sure to impress some of the guards you'll meet in your journeys.");
                SHOW_TEXT(player, type, doMsgs, "No need to thank me. I've taken..er..accepted your generous donation already.'");
            }
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A band of Night Elves tries to steal your armor.");
            if (HAS_ITEM(player, type, doMsgs, AMULETOFPROTECTION) || HAS_ITEM(player, type, doMsgs, BASALTSCROLL)) {
                SET_BOOTY(player, type, doMsgs, ELIXIROFHEALTH, CRYSTALSCROLL, 0, 0, 0, 1500);
            }
            else {
                SET_BOOTY(player, type, doMsgs, AMULETOFPROTECTION, BASALTSCROLL, 0, 0, 0, 3000);
            }
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 3);
                GET_MONSTER(player, type, doMsgs, 02, 4);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 3);
                GET_MONSTER(player, type, doMsgs, 02, 3);
                GET_MONSTER(player, type, doMsgs, 03, 5);
                GET_MONSTER(player, type, doMsgs, 04, 4);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 3);
                GET_MONSTER(player, type, doMsgs, 02, 3);
                GET_MONSTER(player, type, doMsgs, 03, 5);
                GET_MONSTER(player, type, doMsgs, 05, 4);
                GET_MONSTER(player, type, doMsgs, 06, 4);
            }
        }
        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 5, 1, 238, WEST);
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD() == BARBARIAN) {
                GuildDoor(player, type, doMsgs);
            }
        }
        protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 4, 3, 238, SOUTH);
        }
        protected override void FnEvent3B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Fellowship Meeting Hall");
        }
        protected override void FnEvent3D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short flags;
            flags = GET_FLAG(player, type, doMsgs, DUNGEON, ARMORY_ITEM);
             + GET_FLAG(player, type, doMsgs, DUNGEON, JACKET);
            if (GUILD() == KNIGHT) {
                FoundRoom(player, type, doMsgs);
                switch (flags) {
                    case 1:
                        GiveExp(player, type, doMsgs);
                        GIVE_ITEM(player, type, doMsgs, KNIGHTSBREASTPLATE);
                        break;
                    case 2:
                        if (HAS_ITEM(player, type, doMsgs, KNIGHTSBREASTPLATE)) {
                            EmptyRoom(player, type, doMsgs);
                        }
                        else {
                            GIVE_ITEM(player, type, doMsgs, KNIGHTSBREASTPLATE);
                            ArmReplace(player, type, doMsgs);
                        }
                        break;
                    case 3:
                        EmptyRoom(player, type, doMsgs);
                        break;
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Only Knights gain their reward here.");
            }
        }
        protected override void FnEvent3F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 4, 3, 206, NORTH);
        }
        protected override void FnEvent41(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short flags;
            flags = GET_FLAG(player, type, doMsgs, DUNGEON, ARMORY_ITEM);
             + GET_FLAG(player, type, doMsgs, DUNGEON, JACKET);
            if (GUILD() == RANGER) {
                FoundRoom(player, type, doMsgs);
                switch (flags) {
                    case 1:
                        GiveExp(player, type, doMsgs);
                        GIVE_ITEM(player, type, doMsgs, RANGERSCHAINMAIL);
                        break;
                    case 2:
                        if (HAS_ITEM(player, type, doMsgs, RANGERSCHAINMAIL)) {
                            EmptyRoom(player, type, doMsgs);
                        }
                        else {
                            GIVE_ITEM(player, type, doMsgs, RANGERSCHAINMAIL);
                            ArmReplace(player, type, doMsgs);
                        }
                        break;
                    case 3:
                        EmptyRoom(player, type, doMsgs);
                        break;
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Only Rangers gain their reward here.");
            }
        }
        protected override void FnEvent43(TwPlayerServer player, MapEventType type, bool doMsgs) {
            short flags;
            flags = GET_FLAG(player, type, doMsgs, DUNGEON, ARMORY_ITEM);
             + GET_FLAG(player, type, doMsgs, DUNGEON, JACKET);
            if (GUILD() == BARBARIAN) {
                FoundRoom(player, type, doMsgs);
                switch (flags) {
                    case 1:
                        GiveExp(player, type, doMsgs);
                        GIVE_ITEM(player, type, doMsgs, BARBARIANSPLATE);
                        break;
                    case 2:
                        if (HAS_ITEM(player, type, doMsgs, BARBARIANSPLATE)) {
                            EmptyRoom(player, type, doMsgs);
                        }
                        else {
                            GIVE_ITEM(player, type, doMsgs, BARBARIANSPLATE);
                            ArmReplace(player, type, doMsgs);
                        }
                        break;
                    case 3:
                        EmptyRoom(player, type, doMsgs);
                        break;
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Only Barbarians gain their reward here.");
            }
        }
        protected override void FnEvent44(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 7);
                GET_MONSTER(player, type, doMsgs, 02, 7);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 9);
                GET_MONSTER(player, type, doMsgs, 02, 9);
                GET_MONSTER(player, type, doMsgs, 03, 11);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 10);
                GET_MONSTER(player, type, doMsgs, 02, 10);
                GET_MONSTER(player, type, doMsgs, 03, 7);
                GET_MONSTER(player, type, doMsgs, 05, 11);
                GET_MONSTER(player, type, doMsgs, 06, 11);
            }
        }
        protected override void FnEvent45(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 31);
                GET_MONSTER(player, type, doMsgs, 02, 32);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 31);
                GET_MONSTER(player, type, doMsgs, 02, 32);
                GET_MONSTER(player, type, doMsgs, 06, 33);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 31);
                GET_MONSTER(player, type, doMsgs, 02, 31);
                GET_MONSTER(player, type, doMsgs, 03, 32);
                GET_MONSTER(player, type, doMsgs, 04, 32);
                GET_MONSTER(player, type, doMsgs, 06, 33);
            }
        }
        protected override void FnEvent46(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 1);
                GET_MONSTER(player, type, doMsgs, 02, 4);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 36);
                GET_MONSTER(player, type, doMsgs, 02, 3);
                GET_MONSTER(player, type, doMsgs, 06, 39);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 36);
                GET_MONSTER(player, type, doMsgs, 02, 37);
                GET_MONSTER(player, type, doMsgs, 03, 38);
                GET_MONSTER(player, type, doMsgs, 04, 39);
                GET_MONSTER(player, type, doMsgs, 05, 40);
            }
        }
        protected override void FnEvent47(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 15);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 12);
                GET_MONSTER(player, type, doMsgs, 02, 12);
                GET_MONSTER(player, type, doMsgs, 03, 13);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 12);
                GET_MONSTER(player, type, doMsgs, 02, 12);
                GET_MONSTER(player, type, doMsgs, 03, 15);
                GET_MONSTER(player, type, doMsgs, 05, 13);
                GET_MONSTER(player, type, doMsgs, 06, 13);
            }
        }
        protected override void FnEvent49(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 1);
                GET_MONSTER(player, type, doMsgs, 02, 6);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 1);
                GET_MONSTER(player, type, doMsgs, 02, 6);
                GET_MONSTER(player, type, doMsgs, 05, 2);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 1);
                GET_MONSTER(player, type, doMsgs, 02, 6);
                GET_MONSTER(player, type, doMsgs, 03, 6);
                GET_MONSTER(player, type, doMsgs, 05, 3);
                GET_MONSTER(player, type, doMsgs, 06, 4);
            }
        }
        protected override void FnEvent4A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 29);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 20);
                GET_MONSTER(player, type, doMsgs, 02, 20);
                GET_MONSTER(player, type, doMsgs, 06, 21);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 20);
                GET_MONSTER(player, type, doMsgs, 02, 20);
                GET_MONSTER(player, type, doMsgs, 03, 24);
                GET_MONSTER(player, type, doMsgs, 04, 24);
                GET_MONSTER(player, type, doMsgs, 06, 38);
            }
        }
        protected override void FnEvent4B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT() == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 28);
            }
            else if (PARTY_COUNT() == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 28);
                GET_MONSTER(player, type, doMsgs, 02, 28);
                GET_MONSTER(player, type, doMsgs, 06, 35);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 28);
                GET_MONSTER(player, type, doMsgs, 02, 28);
                GET_MONSTER(player, type, doMsgs, 04, 34);
                GET_MONSTER(player, type, doMsgs, 05, 35);
                GET_MONSTER(player, type, doMsgs, 06, 35);
            }
        }
        private void FoundRoom(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TAKE_ITEM(player, type, doMsgs, FELLOWSHIPKEY);
            TAKE_ITEM(player, type, doMsgs, SKELETONKEY);
            SHOW_TEXT(player, type, doMsgs, "Congratulations, you have found a secret armory room.");
            SHOW_TEXT(player, type, doMsgs, "In exchange, you must sacrifice the bone and your Fellowship!");
        }
        private void GiveExp(TwPlayerServer player, MapEventType type, bool doMsgs) {
            MOD_EXP(player, type, doMsgs, 50000);
            SET_FLAG(player, type, doMsgs, DUNGEON, ARMORY_ITEM, 1);
            SHOW_TEXT(player, type, doMsgs, "This Guild armor and experience will help you on your journey.");
        }
        private void EmptyRoom(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The room appears to have been looted.");
        }
        private void ArmReplace(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Here's a replacement for your lost armor.");
            SET_FLAG(player, type, doMsgs, DUNGEON, ARMORY_ITEM, 2);
        }
        private void WallClear(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
            PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(), FACING());
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
        }
        private void GuildDoor(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_ITEM(player, type, doMsgs, SKELETONKEY, SKELETONKEY)) {
                CLEAR_WALL(player, type, doMsgs, HERE(), FACING());
                PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(), FACING());
                SHOW_TEXT(player, type, doMsgs, "Your Skeleton Key unlocks the door.");
            }
            else {
                BLOCK_WALL(player, type, doMsgs, HERE(), FACING());
                SHOW_TEXT(player, type, doMsgs, "The door is locked. Someone has painted a skull and crossed arm bones on the door.");
            }
        }
    }
}
