using XPT.Generic.Maps;
using XPT.Twinion.Entities;

namespace XPT.Twinion.Maps {
    class TwMap11 : TwMap {
        protected override int MapIndex => 11;
        protected override int MapID => 0x0501;
        protected override int RandomEncounterChance => 5;
        protected override int RandomEncounterExtraCount => 1;

        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_HEAL_ZONE(player, type, doMsgs);
            if (!GET_FLAG(player, type, doMsgs, ROOM, LAKE)) {
                DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs) / 4);
                SHOW_TEXT(player, type, doMsgs, "The waters drain your life energy.");
                SET_FLAG(player, type, doMsgs, ROOM, LAKE, 1);
            }
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, LIFEJACKET)) {
                SHOW_TEXT(player, type, doMsgs, "The Life Jacket keeps you from drowning.");
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The platform buckles under your weight.");
                SHOW_TEXT(player, type, doMsgs, "Your foot is snared by the sinking platform and you are dragged to the bottom of the lake.");
                DamXit(player, type, doMsgs);
            }
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "What appeared to be a platform is actually the back of a giant underwater creature.");
            if (HAS_ITEM(player, type, doMsgs, LIFEJACKET)) {
                SHOW_TEXT(player, type, doMsgs, "He is awakened by your weight on his back and plunges deep into the lake, taking you to the bottom with him.");
                SHOW_TEXT(player, type, doMsgs, "You have drowned!");
                DamXit(player, type, doMsgs);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "However, he remains asleep and offers you a stable stepping stone.");
            }
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Beyond the door are stairs leading down to the Cellar.");
            TELEPORT(player, type, doMsgs, 6, 1, 8, SOUTH);
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You step into a stream of lava.");
            DamXit(player, type, doMsgs);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 6, 1, 89, SOUTH);
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
            if (GET_FLAG(player, type, doMsgs, DUNGEON, HERBAL) == 1) {
                HealFtn(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The medicinal waters of Herbal Fountain heal you and renew your spell casting powers.");
            }
            else {
                SET_FLAG(player, type, doMsgs, DUNGEON, HERBAL, 1);
                HealFtn(player, type, doMsgs);
                if (GUILD(player, type, doMsgs) == RANGER) {
                    GIVE_SPELL(player, type, doMsgs, LIGHTNING_SPELL, 1);
                    SHOW_TEXT(player, type, doMsgs, "The medicinal waters of Herbal Fountain heal you, renew your spell casting powers and endow you with the Lightning spell.");
                }
                else {
                    GIVE_SPELL(player, type, doMsgs, CURE_SPELL, 1);
                    SHOW_TEXT(player, type, doMsgs, "The medicinal waters of Herbal Fountain heal you, renew your spell casting powers and endow you with the Cure spell.");
                }
            }
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, PARCHMENT_MAP) == 1) {
                if (HAS_ITEM(player, type, doMsgs, PARCHMENTMAP)) {
                    SHOW_TEXT(player, type, doMsgs, "The heat from the lava is almost unbearable.");
                }
                else {
                    GIVE_ITEM(player, type, doMsgs, PARCHMENTMAP);
                    SHOW_TEXT(player, type, doMsgs, "You detect signs of a struggle on the ground near a torn parchment.");
                    SHOW_TEXT(player, type, doMsgs, "It is one of the four maps the Queen asked you to find.");
                }
            }
            else {
                GIVE_ITEM(player, type, doMsgs, PARCHMENTMAP);
                MOD_EXP(player, type, doMsgs, 200000);
                SET_FLAG(player, type, doMsgs, DUNGEON, PARCHMENT_MAP, 1);
                SHOW_TEXT(player, type, doMsgs, "You approach two men fighting over a piece of parchment.");
                SHOW_TEXT(player, type, doMsgs, "Before you can intervene, they topple into the lava. The parchment flutters gracefully to the ground.");
                SHOW_TEXT(player, type, doMsgs, "A glance at the Parchment Map proves it is one of the four maps Queen Aeowyn asked you to find.");
            }
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The teleport will lead you to the Carriage House.");
            TELEPORT(player, type, doMsgs, 6, 1, 68, NORTH);
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_MAPS(player, type, doMsgs);
            SHOW_TEXT(player, type, doMsgs, "You fall into a pit.");
            DamXit(player, type, doMsgs);
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GET_FLAG(player, type, doMsgs, DUNGEON, JACKET) == 1) {
                TAKE_ITEM(player, type, doMsgs, LIFEJACKET);
                if (HAS_ITEM(player, type, doMsgs, FELLOWSHIPKEY)) {
                    SHOW_TEXT(player, type, doMsgs, "The room is empty.");
                }
                else {
                    GIVE_ITEM(player, type, doMsgs, FELLOWSHIPKEY);
                    SHOW_TEXT(player, type, doMsgs, "While stooping down to pick up a key, your Life Jacket falls into the water and floats away.");
                    SHOW_TEXT(player, type, doMsgs, "The grasp of the key is engraved with two arms clasped in fellowship.");
                }
            }
            else {
                if (HAS_ITEM(player, type, doMsgs, LIFEJACKET)) {
                    GIVE_ITEM(player, type, doMsgs, FELLOWSHIPKEY);
                    GIVE_ITEM(player, type, doMsgs, STORMSBOW);
                    GIVE_ITEM(player, type, doMsgs, FREEDOMRING);
                    MOD_EXP(player, type, doMsgs, 50000);
                    SET_FLAG(player, type, doMsgs, DUNGEON, JACKET, 1);
                    SHOW_TEXT(player, type, doMsgs, "While stooping down to pick up some items, your Life Jacket falls into the water and floats away.");
                    SHOW_TEXT(player, type, doMsgs, "The grasp of the key is engraved with two arms clasped in fellowship.");
                    TAKE_ITEM(player, type, doMsgs, LIFEJACKET);
                }
                else {
                    SHOW_TEXT(player, type, doMsgs, "You stoop down to pick up a key but accidentally knock it into the water.");
                    SHOW_TEXT(player, type, doMsgs, "Unfortunately, you lack what you need to retrieve it.");
                }
            }
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_MAPS(player, type, doMsgs);
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Posted on the door you see: 'DANGER! Unstable ground.'");
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You overhear passers-by discussing the fact that not all pits lead to death; some have been transformed into passages.");
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A jump into the pit lands you in the Library.");
            TELEPORT(player, type, doMsgs, 6, 1, 90, NORTH);
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, GNOMEWIZARD);
            SHOW_TEXT(player, type, doMsgs, "A half-crazed Gnome Wizard looks in the direction of the Cartography Shop.");
            SHOW_TEXT(player, type, doMsgs, "'Riddles, riddles,' he says mysteriously and wanders off.");
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            TELEPORT(player, type, doMsgs, 5, 1, 64, SOUTH);
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Through this teleport you will find the Stables.");
            TELEPORT(player, type, doMsgs, 6, 1, 164, SOUTH);
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You fall into the Carriage House.");
            TELEPORT(player, type, doMsgs, 6, 1, 118, EAST);
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, DIAMONDLOCKPICK)) {
                if (GET_FLAG(player, type, doMsgs, DUNGEON, VAULT) == 1) {
                    SHOW_TEXT(player, type, doMsgs, "You see an empty safe.");
                }
                else {
                    MOD_GOLD(player, type, doMsgs, 100000);
                    GIVE_ITEM(player, type, doMsgs, NEROSLYRE);
                    GIVE_ITEM(player, type, doMsgs, CRESCENTMOON);
                    GIVE_ITEM(player, type, doMsgs, STAFFOFJUSTICE);
                    SET_FLAG(player, type, doMsgs, DUNGEON, VAULT, 1);
                    SHOW_TEXT(player, type, doMsgs, "The safe opens easily with the Diamond Lockpick.");
                    SHOW_TEXT(player, type, doMsgs, "Inside are 100,000 gold pieces, which somehow find their way into your pocket, and a few items which were tucked away for safekeeping.");
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "Deep within the Vault you find a safe; unfortunately, it is secured shut with a diamond shaped lock.");
            }
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_MAPS(player, type, doMsgs);
            if (!GET_FLAG(player, type, doMsgs, ROOM, LAKE)) {
                ROTATE(player, type, doMsgs, WEST);
                SET_FLAG(player, type, doMsgs, ROOM, LAKE, 1);
            }
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_MAPS(player, type, doMsgs);
            if (!GET_FLAG(player, type, doMsgs, ROOM, LAKE)) {
                ROTATE(player, type, doMsgs, SOUTH);
                SET_FLAG(player, type, doMsgs, ROOM, LAKE, 1);
            }
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You discover a short cut to the Stables.");
            TELEPORT(player, type, doMsgs, 6, 1, 134, SOUTH);
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "You can barely read the water-stained sign. It says, 'To Clueless.'");
            TELEPORT(player, type, doMsgs, 4, 1, 69, SOUTH);
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "This way leads to Tipekans' Bridge.");
            TELEPORT(player, type, doMsgs, 7, 1, 161, EAST);
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_MAPS(player, type, doMsgs);
            SHOW_PICTURE(player, type, doMsgs, HALFLINGTHIEF);
            SHOW_TEXT(player, type, doMsgs, "Smug grins at the sight of your Ruby Lockpick.");
            SHOW_TEXT(player, type, doMsgs, "He crooks a thumb towards the door to the west.");
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The ground gives way beneath you.");
            DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_ITEM(player, type, doMsgs, RUBYLOCKPICK, RUBYLOCKPICK)) {
                SHOW_TEXT(player, type, doMsgs, "As you try to open the door, you spring a trap set by Smug.");
                DamXit(player, type, doMsgs);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "This is the back door to Smug's Jewelry Shop.");
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A message is scrawled on the wall -");
            SHOW_TEXT(player, type, doMsgs, "'Inventory items have been known to change hazardous steps into safe steps.'");
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, ROPE)) {
                SHOW_TEXT(player, type, doMsgs, "The ground gives way and you slide down a tunnel.");
                SHOW_TEXT(player, type, doMsgs, "You quickly throw your rope over a rock and lower yourself into the Library.");
                TELEPORT(player, type, doMsgs, 6, 1, 73, EAST);
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The ground gives way and you slide down a forked tunnel.");
                SHOW_TEXT(player, type, doMsgs, "This time, you tumble down the left tube.");
                TELEPORT(player, type, doMsgs, 6, 1, 70, WEST);
            }
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD(player, type, doMsgs) == THIEF) {
                SHOW_TEXT(player, type, doMsgs, "A sign on the door - 'THIEVES ONLY.'");
                DoorHere(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (USED_ITEM(player, type, doMsgs, RUBYLOCKPICK, RUBYLOCKPICK)) {
                WallClear(player, type, doMsgs);
                DoorHere(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "You successfully unlock the door.");
            }
            else {
                WallBlock(player, type, doMsgs);
                SHOW_TEXT(player, type, doMsgs, "The entrance to Smug's Jewelry Shop is locked.");
            }
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "The Rich Waters of Sterling Fountain heal and restore you.");
            FntnPic(player, type, doMsgs);
            HealFtn(player, type, doMsgs);
        }
        protected override void FnEvent2C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "A ghostly voice cackles in glee, 'Cursed you are, cursed to go where I wish! Muhahahaha!'");
            if (HAS_ITEM(player, type, doMsgs, SKELETONKEY)) {
                TELEPORT(player, type, doMsgs, 5, 3, 15, SOUTH);
            }
            else if (HAS_ITEM(player, type, doMsgs, SCROLLOFTHESUN)) {
                TELEPORT(player, type, doMsgs, 5, 1, 61, WEST);
            }
            else if (HAS_ITEM(player, type, doMsgs, BLESSPOTION)) {
                TELEPORT(player, type, doMsgs, 5, 1, 182, SOUTH);
            }
            else if (HAS_ITEM(player, type, doMsgs, HALOSCROLL)) {
                TELEPORT(player, type, doMsgs, 4, 3, 64, SOUTH);
            }
            else {
                TELEPORT(player, type, doMsgs, 4, 1, 241, EAST);
            }
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "It looks like you're not the only one to discover the thieves' hiding place.");
            if (HAS_ITEM(player, type, doMsgs, STAFFOFGIANTS)) {
                SET_BOOTY(player, type, doMsgs, CURSEDSCROLL, SCROLLOFPROTECTION, 0, 0, 0, 1000);
            }
            else {
                SET_BOOTY(player, type, doMsgs, STAFFOFGIANTS, MANAELIXIR, SCROLLOFTHESUN, 0, 0, 3000);
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 6);
                GET_MONSTER(player, type, doMsgs, 02, 7);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 4);
                GET_MONSTER(player, type, doMsgs, 02, 5);
                GET_MONSTER(player, type, doMsgs, 03, 13);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 27);
                GET_MONSTER(player, type, doMsgs, 02, 28);
                GET_MONSTER(player, type, doMsgs, 03, 28);
                GET_MONSTER(player, type, doMsgs, 05, 35);
                GET_MONSTER(player, type, doMsgs, 06, 36);
            }
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_MAPS(player, type, doMsgs);
            if (GUILD(player, type, doMsgs) == THIEF) {
                if (HAS_ITEM(player, type, doMsgs, SKELETONKEY)) {
                    SHOW_TEXT(player, type, doMsgs, "The room is empty.");
                }
                else if (GET_FLAG(player, type, doMsgs, DUNGEON, ARMORY_ITEM) == 1) {
                    GIVE_ITEM(player, type, doMsgs, SKELETONKEY);
                    SHOW_TEXT(player, type, doMsgs, "You find a key which may open seemingly impassable doors in your race to finish Queen Aeowyn's Map Quest.");
                    SHOW_TEXT(player, type, doMsgs, "The key is made of bone and features a skull and crossed arm bones.");
                }
                else {
                    GIVE_ITEM(player, type, doMsgs, SKELETONKEY);
                    SHOW_TEXT(player, type, doMsgs, "Your Guildmaster left you a special key that will give you access to magical armor.");
                    SHOW_TEXT(player, type, doMsgs, "The key is made of bone. The grasp is shaped like a skull and the shaft like two crossed, bony arms.");
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The room is bare.");
            }
        }
        protected override void FnEvent2F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Beyond the door lies a twisted maze. To find your way through would be aMAZEing.");
            TELEPORT(player, type, doMsgs, 4, 2, 240, NORTH);
        }
        protected override void FnEvent30(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "`Pluthros`");
            SHOW_TEXT(player, type, doMsgs, "Ashakkar is where all who oppose Chaos shall find this Fate.");
        }
        protected override void FnEvent31(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            BLOCK_FLOOR(player, type, doMsgs, 191);
            SHOW_TEXT(player, type, doMsgs, "Carved in the base you see the name `Lord Zzuf`");
            SHOW_TEXT(player, type, doMsgs, "This work of art, however is unfinished; perhaps later you can come back and see it completed.");
            if (GET_FLAG(player, type, doMsgs, DUNGEON, ROPE_FLAG) == 1) {
                CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
                CLEAR_FLOOR(player, type, doMsgs, 191);
                PLACE_WALL_ITEM(player, type, doMsgs, GATEWAY, 191, EAST);
                SHOW_TEXT(player, type, doMsgs, "Your quest bag shifts and hits the statue of Lord Zzuf, causing the great explorer's icon to move slightly.");
                SHOW_TEXT(player, type, doMsgs, "You push the statue's base and find enough room for a person to squeeze through.");
            }
        }
        protected override void FnEvent32(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "`Juvalad`");
            SHOW_TEXT(player, type, doMsgs, "Enakkar is where all who oppose Harmony shall find this Fate.");
        }
        protected override void FnEvent33(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "`Malos`");
            SHOW_TEXT(player, type, doMsgs, "En-Li-Kil's master, and guardian to the Elementals.");
        }
        protected override void FnEvent34(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "`Crysillus Draco and Sayvut d'Oi Vey`");
            SHOW_TEXT(player, type, doMsgs, "These were the great engineers who built the shrines to the Fates those many moons ago.");
        }
        protected override void FnEvent35(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "'Enter at your own risk!'");
        }
        protected override void FnEvent36(TwPlayerServer player, MapEventType type, bool doMsgs) {
             {
                if (HAS_ITEM(player, type, doMsgs, EMERALDLOCKPICK)) {
                    SET_BOOTY(player, type, doMsgs, CURATIVEELIXIR, 0, 0, 0, 0, 1000);
                }
                else {
                    SET_BOOTY(player, type, doMsgs, EMERALDLOCKPICK, CURATIVEELIXIR, ELIXIROFHEALTH, 0, 0, 3000);
                    SHOW_TEXT(player, type, doMsgs, "You see something green on the ground - and something nasty charging at you.");
                }
            }
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 22);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 20);
                GET_MONSTER(player, type, doMsgs, 02, 20);
                GET_MONSTER(player, type, doMsgs, 05, 23);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 20);
                GET_MONSTER(player, type, doMsgs, 02, 20);
                GET_MONSTER(player, type, doMsgs, 03, 22);
                GET_MONSTER(player, type, doMsgs, 05, 23);
                GET_MONSTER(player, type, doMsgs, 06, 34);
            }
        }
        protected override void FnEvent37(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD(player, type, doMsgs) == CLERIC) {
                SHOW_TEXT(player, type, doMsgs, "A sign on the door - 'CLERICS ONLY.'");
                DoorHere(player, type, doMsgs);
                WallClear(player, type, doMsgs);
            }
            else {
                WallBlock(player, type, doMsgs);
            }
        }
        protected override void FnEvent38(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GUILD(player, type, doMsgs) == CLERIC) {
                if (HAS_ITEM(player, type, doMsgs, SKELETONKEY)) {
                    SHOW_TEXT(player, type, doMsgs, "The room is empty.");
                }
                else if (GET_FLAG(player, type, doMsgs, DUNGEON, ARMORY_ITEM) == 1) {
                    GIVE_ITEM(player, type, doMsgs, SKELETONKEY);
                    SHOW_TEXT(player, type, doMsgs, "You find a key which may open seemingly impassable doors in your race to finish Queen Aeowyn's Map Quest.");
                    SHOW_TEXT(player, type, doMsgs, "The key is made of bone and features a skull and crossed arm bones.");
                }
                else {
                    GIVE_ITEM(player, type, doMsgs, SKELETONKEY);
                    SHOW_TEXT(player, type, doMsgs, "Your Guildmaster left you a special key that will give you access to magical armor.");
                    SHOW_TEXT(player, type, doMsgs, "The key is made of bone. The grasp is shaped like a skull and the shaft like two crossed, bony arms.");
                }
            }
            else {
                SHOW_TEXT(player, type, doMsgs, "The room is bare.");
            }
        }
        protected override void FnEvent39(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "`Astelligus`");
            SHOW_TEXT(player, type, doMsgs, "The blackest pitch cannot compare to this Fate's home.");
        }
        protected override void FnEvent3A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (!GET_FLAG(player, type, doMsgs, DUNGEON, ARMORY_ITEM)) {
                SHOW_PICTURE(player, type, doMsgs, ORCKNIGHT);
                SHOW_TEXT(player, type, doMsgs, "An Orc Knight is frantically searching the ground.");
                SHOW_TEXT(player, type, doMsgs, "'All I need to get into the secret armory rooms is that blasted Skeleton Key I dropped somewhere back here!");
                SHOW_TEXT(player, type, doMsgs, "Of course, one needs more than that, as you well know!'");
                SHOW_TEXT(player, type, doMsgs, "The Knight dashes off before you can say anything.");
            }
        }
        protected override void FnEvent3B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "Be sure of your footing when you scale the heights of Cliffhanger.");
            TELEPORT(player, type, doMsgs, 4, 1, 34, EAST);
        }
        protected override void FnEvent3C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            NO_MAPS(player, type, doMsgs);
            SHOW_TEXT(player, type, doMsgs, "Magical forces swirl about you, where you might end up you have no clue.");
            if (HAS_ITEM(player, type, doMsgs, SLATEMAP)) {
                TELEPORT(player, type, doMsgs, 6, 1, 0, SOUTH);
            }
            else if (HAS_ITEM(player, type, doMsgs, FRONTDOORKEY)) {
                TELEPORT(player, type, doMsgs, 4, 2, 228, SOUTH);
            }
            else if (HAS_ITEM(player, type, doMsgs, CRYSTALSCROLL)) {
                TELEPORT(player, type, doMsgs, 4, 1, 58, SOUTH);
            }
            else if (HAS_ITEM(player, type, doMsgs, IRONCROWN)) {
                TELEPORT(player, type, doMsgs, 5, 1, 203, SOUTH);
            }
            else {
                TELEPORT(player, type, doMsgs, 5, 1, 0, EAST);
            }
        }
        protected override void FnEvent3D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                PLACE_WALL_ITEM(player, type, doMsgs, GATEWAY, HERE(player, type, doMsgs), EAST);
                SHOW_TEXT(player, type, doMsgs, "You have discovered the secret portal to the Ballroom.");
            }
            else {
                TELEPORT(player, type, doMsgs, 5, 1, 207, WEST);
                SHOW_TEXT(player, type, doMsgs, "The space is too narrow for more than one person to squeeze through.");
            }
        }
        protected override void FnEvent3E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_TEXT(player, type, doMsgs, "`Corpeus`");
            SHOW_TEXT(player, type, doMsgs, "This Fate welcomes all to sample his wisdom; or die from his wrath.");
        }
        protected override void FnEvent3F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 1);
                GET_MONSTER(player, type, doMsgs, 02, 3);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 1);
                GET_MONSTER(player, type, doMsgs, 02, 3);
                GET_MONSTER(player, type, doMsgs, 05, 25);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 3);
                GET_MONSTER(player, type, doMsgs, 02, 3);
                GET_MONSTER(player, type, doMsgs, 03, 1);
                GET_MONSTER(player, type, doMsgs, 05, 26);
                GET_MONSTER(player, type, doMsgs, 06, 26);
            }
        }
        protected override void FnEvent40(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 6);
                GET_MONSTER(player, type, doMsgs, 02, 5);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 28);
                GET_MONSTER(player, type, doMsgs, 02, 29);
                GET_MONSTER(player, type, doMsgs, 06, 9);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 10);
                GET_MONSTER(player, type, doMsgs, 02, 10);
                GET_MONSTER(player, type, doMsgs, 03, 11);
                GET_MONSTER(player, type, doMsgs, 05, 28);
                GET_MONSTER(player, type, doMsgs, 06, 29);
            }
        }
        protected override void FnEvent41(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 17);
                GET_MONSTER(player, type, doMsgs, 02, 38);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 17);
                GET_MONSTER(player, type, doMsgs, 02, 17);
                GET_MONSTER(player, type, doMsgs, 03, 18);
                GET_MONSTER(player, type, doMsgs, 04, 39);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 17);
                GET_MONSTER(player, type, doMsgs, 02, 17);
                GET_MONSTER(player, type, doMsgs, 03, 19);
                GET_MONSTER(player, type, doMsgs, 04, 19);
                GET_MONSTER(player, type, doMsgs, 06, 39);
            }
        }
        protected override void FnEvent42(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 39);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 17);
                GET_MONSTER(player, type, doMsgs, 02, 18);
                GET_MONSTER(player, type, doMsgs, 05, 35);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 37);
                GET_MONSTER(player, type, doMsgs, 02, 37);
                GET_MONSTER(player, type, doMsgs, 03, 39);
                GET_MONSTER(player, type, doMsgs, 04, 39);
                GET_MONSTER(player, type, doMsgs, 06, 38);
            }
        }
        protected override void FnEvent43(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 14);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 13);
                GET_MONSTER(player, type, doMsgs, 02, 15);
                GET_MONSTER(player, type, doMsgs, 06, 17);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 33);
                GET_MONSTER(player, type, doMsgs, 02, 33);
                GET_MONSTER(player, type, doMsgs, 04, 35);
                GET_MONSTER(player, type, doMsgs, 05, 36);
                GET_MONSTER(player, type, doMsgs, 06, 40);
            }
        }
        protected override void FnEvent44(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 10);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 9);
                GET_MONSTER(player, type, doMsgs, 02, 10);
                GET_MONSTER(player, type, doMsgs, 04, 31);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 10);
                GET_MONSTER(player, type, doMsgs, 02, 10);
                GET_MONSTER(player, type, doMsgs, 04, 11);
                GET_MONSTER(player, type, doMsgs, 05, 30);
                GET_MONSTER(player, type, doMsgs, 06, 32);
            }
        }
        protected override void FnEvent45(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (PARTY_COUNT(player, type, doMsgs) == 1) {
                GET_MONSTER(player, type, doMsgs, 01, 5);
                GET_MONSTER(player, type, doMsgs, 05, 6);
            }
            else if (PARTY_COUNT(player, type, doMsgs) == 2) {
                GET_MONSTER(player, type, doMsgs, 01, 6);
                GET_MONSTER(player, type, doMsgs, 02, 6);
                GET_MONSTER(player, type, doMsgs, 05, 19);
            }
            else {
                GET_MONSTER(player, type, doMsgs, 01, 6);
                GET_MONSTER(player, type, doMsgs, 02, 6);
                GET_MONSTER(player, type, doMsgs, 03, 8);
                GET_MONSTER(player, type, doMsgs, 05, 19);
                GET_MONSTER(player, type, doMsgs, 06, 19);
            }
        }
        protected override void FnEvent46(TwPlayerServer player, MapEventType type, bool doMsgs) {
            PLACE_WALL_ITEM(player, type, doMsgs, GATEWAY, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
            TELEPORT(player, type, doMsgs, 4, 1, 185, SOUTH);
        }
        private void DamXit(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DAMAGE(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
        }
        private void HealFtn(TwPlayerServer player, MapEventType type, bool doMsgs) {
            HEAL(player, type, doMsgs, MAX_HEALTH(player, type, doMsgs));
            MOD_MANA(player, type, doMsgs, 10000);
        }
        private void WallClear(TwPlayerServer player, MapEventType type, bool doMsgs) {
            CLEAR_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        private void WallBlock(TwPlayerServer player, MapEventType type, bool doMsgs) {
            BLOCK_WALL(player, type, doMsgs, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        private void DoorHere(TwPlayerServer player, MapEventType type, bool doMsgs) {
            PLACE_WALL_ITEM(player, type, doMsgs, DOOR, HERE(player, type, doMsgs), FACING(player, type, doMsgs));
        }
        private void FntnPic(TwPlayerServer player, MapEventType type, bool doMsgs) {
            SHOW_PICTURE(player, type, doMsgs, FOUNTAIN);
        }
        protected override void FnEvent47(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HAS_ITEM(player, type, doMsgs, EMERALDLOCKPICK)) {
                SHOW_PICTURE(player, type, doMsgs, GNOMETHIEF);
                SHOW_TEXT(player, type, doMsgs, "'Lockpicks for sale!! Lockpicks for sale!!");
                SHOW_TEXT(player, type, doMsgs, "Can I sell you a lockpick, brave champion? I see you have one, beautiful too. Care to sell it?");
                SHOW_TEXT(player, type, doMsgs, "You must know that the brothers seek red, only red! No? Drat! Then be off with you and let me sell my wares!'");
            }
            else {
                SHOW_PICTURE(player, type, doMsgs, GNOMETHIEF);
                SHOW_TEXT(player, type, doMsgs, "'Brave Warrior! Are you in search of the Emerald Lockpick, too? I must find it and get to Tipekans!'");
            }
        }
    }
}
