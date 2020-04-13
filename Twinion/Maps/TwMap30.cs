using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    class TwMap30 : TwMap {
        public override int MapIndex => 30;
        public override int MapID => 0x0C01;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 1;

        private const int NPCONE = 1;
        private const int NPCTWO = 2;
        private const int TORCHSWITCH = 3;
        private const int SPRUNGTRAP = 1;
        private const int TOSOURCE = 2;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "This teleport will only take you to the main entrance.");
            TeleportParty(player, type, doMsgs, 1, 1, 19, Direction.South);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int charges = 0;
            charges = GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ITEMUSES);
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, TOSOURCE) == 0)) {
                if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ITEMUSES)) {
                    if (UsedItem(player, type, ref doMsgs, RODOFDISSEMINATION, RODOFDISSEMINATION)) {
                        if (charges < 12) {
                            ShowText(player, type, doMsgs, "You dispel the wall!");
                            charges++;
                            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ITEMUSES, charges);
                            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                            SetWallInvisible(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                        }
                        else {
                            ShowText(player, type, doMsgs, "The item's powers have faded!");
                            ShowText(player, type, doMsgs, "Now, take this portal back to the rod's source; and try to find a pathway...again.");
                            SetFlag(player, type, doMsgs, FlagTypeTile, TOSOURCE, 1);
                            SetWallItem(player, type, doMsgs, GATEWAY, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                            ClearWallInvisible(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                        }
                    }
                    else {
                        ShowText(player, type, doMsgs, "This wall seems to shimmer, yet it is solid.");
                    }
                }
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeTile, TOSOURCE) == 1) {
                SetWallItem(player, type, doMsgs, GATEWAY, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                TeleportParty(player, type, doMsgs, 12, 1, 72, Direction.North);
            }
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The tedious journey to this place has made you tired.");
            ShowText(player, type, doMsgs, "Even so, some walls here seem to fade and shimmer as being pulled upon by unseen forces.");
            ShowText(player, type, doMsgs, "Grinding sounds of stone echo through these odd shadowy halls. The scent of powerful magics fills your nostrils and fires your mind.");
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TALKED_TO_NPC1) == 1 && GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TALKED_TO_NPC2) == 1) {
                ShowText(player, type, doMsgs, "The messages of the two old men prove to be the key to opening this secret wall!");
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                SetWallItem(player, type, doMsgs, PORTAL, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
            else if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TALKED_TO_NPC1) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TALKED_TO_NPC2) == 1) {
                ShowText(player, type, doMsgs, "Hmmm...seems like you're missing part of the ritual.  Another may know the second half; then you may find a way through here!");
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "This enormous hallway seems to be devoid of any useful purpose. It's as though the walls here are only boundaries of internally hidden rooms.");
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableAutomaps(player, type, doMsgs);
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ITEMUSES, 1);
            ShowText(player, type, doMsgs, "Magical energy radiates from all around you.");
            ShowText(player, type, doMsgs, "These mystical teleports project dazzling colors of light that refract and reflect off of each other with blinding beauty.");
            ShowText(player, type, doMsgs, "Three shafts of pure light pour down from above onto the Rod of Dissemination, restoring its magical properties.");
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Two small dwellings stand opposite each other in this small room. Strange mumblings are coming from the southern one.");
            ShowText(player, type, doMsgs, "Northward, however, you can just make out low hissing sounds and snarls.");
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Deep sorrowful moans surround you in this dingy place.");
            ShowText(player, type, doMsgs, "Odd shadows flicker and fold in on one another against the walls.  The shadows themselves seem alive.");
        }
        protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            if (HasItem(player, type, doMsgs, RODOFDISSEMINATION)) {
                ShowText(player, type, doMsgs, "Stains of combat cover the floor, but there is nothing of interest here... except a few Erebus fiends!");
            }
            else if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.NICEBOOTY) == 0)) {
                SetTreasure(player, type, doMsgs, RODOFDISSEMINATION, MANAAMPHORA, ZEUSSCROLL, 0, 0, 10000);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.NICEBOOTY, 1);
                ErebusTxt(player, type, doMsgs);
            }
            else {
                SetTreasure(player, type, doMsgs, RODOFDISSEMINATION, 0, 0, 0, 0, 5000);
                ErebusTxt(player, type, doMsgs);
            }
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 25);
                    }
                    AddEncounter(player, type, doMsgs, 5, 26);
                    break;
                case 2:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 25);
                    }
                    AddEncounter(player, type, doMsgs, 6, 26);
                    break;
                default:
                    for (i = 1; i <= 4; i++) {
                        AddEncounter(player, type, doMsgs, i, 25);
                    }
                    AddEncounter(player, type, doMsgs, 6, 26);
                    break;
            }
        }
        private void ErebusTxt(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A large Erebus Fiend orders his minions to attack you, as he waves a mystical staff about and sends magical flames at you from his fingertips!");
        }
        protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int charges = 0;
            int tilenumber = 0;
            charges = GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ITEMUSES);
            ShowText(player, type, doMsgs, "The statue seems to shimmer, yet it is apparently solid.");
            if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ITEMUSES)) {
                if (UsedItem(player, type, ref doMsgs, RODOFDISSEMINATION, RODOFDISSEMINATION)) {
                    if (charges < 12) {
                        ShowText(player, type, doMsgs, "You dispel the statue!");
                        charges++;
                        SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ITEMUSES, charges);
                        if (GetFacing(player, type, doMsgs) == Direction.North) {
                            tilenumber = GetTile(player, type, doMsgs) - 16;
                        }
                        if (GetFacing(player, type, doMsgs) == Direction.East) {
                            tilenumber = GetTile(player, type, doMsgs) + 1;
                        }
                        if (GetFacing(player, type, doMsgs) == Direction.South) {
                            tilenumber = GetTile(player, type, doMsgs) + 16;
                        }
                        if (GetFacing(player, type, doMsgs) == Direction.West) {
                            tilenumber = GetTile(player, type, doMsgs) - 1;
                        }
                        ClearTileBlock(player, type, doMsgs, tilenumber);
                        SetFloorItem(player, type, doMsgs, 0, tilenumber);
                    }
                    else {
                        ShowText(player, type, doMsgs, "The item's powers have faded and pull you back to their source.");
                        TeleportParty(player, type, doMsgs, 12, 1, 72, Direction.North);
                        SetTileBlock(player, type, doMsgs, tilenumber);
                    }
                }
            }
        }
        protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "By dispelling this statue you've released the imprisoned creature! It intends to reward you with death!");
            AddEncounter(player, type, doMsgs, 01, 27);
        }
        protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TALKED_TO_NPC1) == 0)) {
                if ((GetFlag(player, type, doMsgs, FlagTypeParty, NPCONE) == 0)) {
                    ShowPortrait(player, type, doMsgs, KAALROTH);
                    ShowText(player, type, doMsgs, "A sinewy beast stares angrily at you for your intrusion into his home.");
                    ShowText(player, type, doMsgs, "'You have no business here. Leave before I become enraged and destroy you!'");
                    SetFlag(player, type, doMsgs, FlagTypeParty, NPCONE, 2);
                }
                else if (GetFlag(player, type, doMsgs, FlagTypeParty, NPCTWO) == 1 || IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TALKED_TO_NPC2)) {
                    ShowPortrait(player, type, doMsgs, KAALROTH);
                    ShowText(player, type, doMsgs, "'Ahh, you've met my twin, I see.");
                    ShowText(player, type, doMsgs, "Say his chant in time with mine, and at the wall, the ingress shall be thine.'");
                    ShowText(player, type, doMsgs, "Ieoa then turns away pleased with his 'creativity'%.");
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TALKED_TO_NPC1, 1);
                    SetFlag(player, type, doMsgs, FlagTypeParty, NPCONE, 2);
                }
            }
            else {
                ShowText(player, type, doMsgs, "Ieoa has left the dungeon.");
            }
        }
        protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, KAALROTH);
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TALKED_TO_NPC2) == 0)) {
                if ((GetFlag(player, type, doMsgs, FlagTypeParty, NPCTWO) == 0)) {
                    ShowText(player, type, doMsgs, "A sinewy beast stares angrily at you for your intrusion into his home.");
                    ShowText(player, type, doMsgs, "'Away with you, go bother my brother to the west.'");
                    SetFlag(player, type, doMsgs, FlagTypeParty, NPCTWO, 1);
                    if ((GetFlag(player, type, doMsgs, FlagTypeParty, NPCONE) == 0)) {
                        SetFlag(player, type, doMsgs, FlagTypeParty, NPCONE, 1);
                    }
                }
                else if (GetFlag(player, type, doMsgs, FlagTypeParty, NPCONE) == 2) {
                    ShowText(player, type, doMsgs, "'Did you enjoy your talk with Ieoa?");
                    ShowText(player, type, doMsgs, "My verse shan't be before if you wish to find the door. Seek Ieoa, the twin; with his rhyme you begin.'");
                    ShowText(player, type, doMsgs, "Aoei then turns away pleased with his 'creativity'%.");
                    SetFlag(player, type, doMsgs, FlagTypeParty, NPCTWO, 1);
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TALKED_TO_NPC2, 1);
                }
            }
            else {
                ShowText(player, type, doMsgs, "Aoei has left the dungeon.");
            }
        }
        protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            ShowText(player, type, doMsgs, "You happen across some feuding Kaalroths that dismiss their argument for some tasty combat.");
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 28);
                    }
                    break;
                case 2:
                    for (i = 1; i <= 3; i++) {
                        AddEncounter(player, type, doMsgs, i, 28);
                    }
                    break;
                default:
                    for (i = 1; i <= 5; i++) {
                        AddEncounter(player, type, doMsgs, i, 28);
                    }
                    break;
            }
        }
        protected override void FnEvent10(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            ShowText(player, type, doMsgs, "A warring party of Night Elf Pilgrims drags you into the fray.");
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 29);
                    }
                    break;
                case 2:
                    for (i = 1; i <= 3; i++) {
                        AddEncounter(player, type, doMsgs, i, 29);
                    }
                    break;
                default:
                    for (i = 1; i <= 5; i++) {
                        AddEncounter(player, type, doMsgs, i, 29);
                    }
                    break;
            }
        }
        protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            ShowText(player, type, doMsgs, "You suddenly feel out matched as a small nest of dragons charges at you!");
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 30);
                    }
                    break;
                case 2:
                    for (i = 1; i <= 3; i++) {
                        AddEncounter(player, type, doMsgs, i, 30);
                    }
                    break;
                default:
                    for (i = 1; i <= 5; i++) {
                        AddEncounter(player, type, doMsgs, i, 30);
                    }
                    break;
            }
        }
        protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            ShowText(player, type, doMsgs, "Shimmering moans and shadowy figures surround you!");
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 31);
                    }
                    break;
                case 2:
                    for (i = 1; i <= 3; i++) {
                        AddEncounter(player, type, doMsgs, i, 31);
                    }
                    break;
                default:
                    for (i = 1; i <= 5; i++) {
                        AddEncounter(player, type, doMsgs, i, 31);
                    }
                    break;
            }
        }
        protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A huge Red Dragon sends a barrage of flames towards you!");
            if (GetPartyLevel(player, type, doMsgs, 48)) {
                AddEncounter(player, type, doMsgs, 1, 32);
            }
            else if (GetPartyLevel(player, type, doMsgs, 36)) {
                AddEncounter(player, type, doMsgs, 1, 24);
            }
            else {
                AddEncounter(player, type, doMsgs, 1, 23);
            }
        }
        protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "This jeweled teleport will send you to the final confrontation. The Queen awaits.");
            SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TOTHEQUEEN, 1);
            TeleportParty(player, type, doMsgs, 12, 2, 255, Direction.West);
        }
        protected override void FnEvent15(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Perhaps the way out is near!!!");
            TeleportParty(player, type, doMsgs, 12, 1, 193, Direction.North);
        }
        protected override void FnEvent16(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            ShowText(player, type, doMsgs, "An arsenal of creatures bars your way here.");
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    AddEncounter(player, type, doMsgs, 1, 25);
                    AddEncounter(player, type, doMsgs, 5, 33);
                    break;
                case 2:
                    for (i = 1; i <= 3; i++) {
                        AddEncounter(player, type, doMsgs, i, 25);
                    }
                    AddEncounter(player, type, doMsgs, 6, 33);
                    break;
                default:
                    for (i = 1; i <= 4; i++) {
                        AddEncounter(player, type, doMsgs, i, 28);
                    }
                    AddEncounter(player, type, doMsgs, 6, 33);
                    break;
            }
        }
        protected override void FnEvent17(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            ShowText(player, type, doMsgs, "Servants of Dissemination attack!");
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 34);
                    }
                    break;
                case 2:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 34);
                    }
                    for (i = 5; i <= 6; i++) {
                        AddEncounter(player, type, doMsgs, i, 34);
                    }
                    break;
                default:
                    for (i = 1; i <= 4; i++) {
                        AddEncounter(player, type, doMsgs, i, 34);
                    }
                    break;
            }
        }
        protected override void FnEvent18(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The marble statue crumbles away, releasing an ominous beast of power.");
            AddEncounter(player, type, doMsgs, 01, 35);
        }
        protected override void FnEvent19(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, WRAITH);
            ShowText(player, type, doMsgs, "'I am frozen in time here! I tried to use the Portal without the proper knowledge!");
            ShowText(player, type, doMsgs, "Learn from me! Do not use the Portal below!'");
        }
        protected override void FnEvent1A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                ShowText(player, type, doMsgs, "You've sprung an ancient trap that seems not to have harmed you...much.");
                DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 4);
                SetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP, 1);
            }
        }
        protected override void FnEvent1B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                if ((GetFlag(player, type, doMsgs, FlagTypeParty, TORCHSWITCH) == 0)) {
                    ShowText(player, type, doMsgs, "A dragon's face is carved on the wall where the torch here hangs. As you walk by the wall it comes to life and spews waves of fire over you!");
                    DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 5);
                }
                else {
                    ShowText(player, type, doMsgs, "The carved dragon on the wall remains silent.");
                }
                SetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP, 1);
            }
        }
        protected override void FnEvent1C(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            ShowText(player, type, doMsgs, "'You must defeat us to proceed! We are everlasting forces here!'");
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    for (i = 1; i <= 3; i++) {
                        AddEncounter(player, type, doMsgs, i, 36);
                    }
                    break;
                case 2:
                    for (i = 1; i <= 4; i++) {
                        AddEncounter(player, type, doMsgs, i, 36);
                    }
                    break;
                default:
                    for (i = 1; i <= 6; i++) {
                        AddEncounter(player, type, doMsgs, i, 36);
                    }
                    break;
            }
        }
        protected override void FnEvent1D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "This MUST lead out of this level.");
            TeleportParty(player, type, doMsgs, 12, 1, 152, Direction.East);
        }
        protected override void FnEvent1E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The end must be near; you can see huge forces of creatures moving about nearby.");
            ShowText(player, type, doMsgs, "Waste not your charges on futile walls!");
        }
        protected override void FnEvent1F(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The Guardians here launch a spread of evil magic towards you. The mysterious vapors envelop your body as a ring of opaque fog.");
            SetDebuff(player, type, doMsgs, POISON, 10, 700);
            ModAttribute(player, type, doMsgs, DEFENSE,  - 1);
            ModAttribute(player, type, doMsgs, AGILITY,  - 1);
        }
        protected override void FnEvent20(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            ShowText(player, type, doMsgs, "Creatures surprise you!");
            if ((GetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP) == 0)) {
                DoDamage(player, type, doMsgs, GetHealthCurrent(player, type, doMsgs) / 6);
                ModifyGold(player, type, doMsgs,  - 2500);
                SetFlag(player, type, doMsgs, FlagTypeTile, SPRUNGTRAP, 1);
            }
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 22);
                    }
                    break;
                case 2:
                    for (i = 1; i <= 4; i++) {
                        AddEncounter(player, type, doMsgs, i, 22);
                    }
                    break;
                default:
                    for (i = 1; i <= 6; i++) {
                        AddEncounter(player, type, doMsgs, i, 22);
                    }
                    break;
            }
        }
        protected override void FnEvent21(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            ShowText(player, type, doMsgs, "You surprise some beasts examining an interesting sword.");
            if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GREATBOOTY) == 0)) {
                SetTreasure(player, type, doMsgs, PHOSPHORESCENTBLADE, HEALAMPHORA, HEALAMPHORA, BARBARIANAXE, ETHERICVESTMENT, 25000);
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.GREATBOOTY, 1);
            }
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 25);
                    }
                    break;
                case 2:
                    for (i = 1; i <= 3; i++) {
                        AddEncounter(player, type, doMsgs, i, 22);
                    }
                    break;
                default:
                    for (i = 1; i <= 3; i++) {
                        AddEncounter(player, type, doMsgs, i, 24);
                    }
                    break;
            }
        }
        protected override void FnEvent22(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowPortrait(player, type, doMsgs, GNOMEWIZARD);
            ShowText(player, type, doMsgs, "An old hermit squints at you, 'The Portal you seek cannot be entered yet.  Your task will end in futility!");
            ShowText(player, type, doMsgs, "You must gain in ways before you gain the wisdom.'");
            ShowText(player, type, doMsgs, "The rantings of a fool, eh?");
        }
        protected override void FnEvent23(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "This portal, however, you can enter.");
            TeleportParty(player, type, doMsgs, 12, 1, 136, Direction.North);
        }
        protected override void FnEvent24(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            ShowText(player, type, doMsgs, "Some young dragons are scrounging for food, they notice you and attempt to make you their meal.");
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    for (i = 1; i <= 2; i++) {
                        AddEncounter(player, type, doMsgs, i, 30);
                    }
                    break;
                case 2:
                    for (i = 1; i <= 3; i++) {
                        AddEncounter(player, type, doMsgs, i, 30);
                    }
                    break;
                default:
                    for (i = 1; i <= 5; i++) {
                        AddEncounter(player, type, doMsgs, i, 30);
                    }
                    break;
            }
        }
        protected override void FnEvent25(TwPlayerServer player, MapEventType type, bool doMsgs) {
            int i = 0;
            ShowText(player, type, doMsgs, "You've happened upon some very unpleasant sorts!");
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    for (i = 1; i <= 3; i++) {
                        AddEncounter(player, type, doMsgs, i, 3);
                    }
                    break;
                case 2:
                    for (i = 1; i <= 4; i++) {
                        AddEncounter(player, type, doMsgs, i, 4);
                    }
                    break;
                default:
                    for (i = 1; i <= 6; i++) {
                        AddEncounter(player, type, doMsgs, i, 6);
                    }
                    break;
            }
        }
        protected override void FnEvent26(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (IsFlagOff(player, type, doMsgs, FlagTypeParty, TORCHSWITCH)) {
                ShowText(player, type, doMsgs, "A lever here is marked DO NOT TOUCH!");
                ShowText(player, type, doMsgs, "Using your better judgement, you move the lever.");
                ShowText(player, type, doMsgs, "You hear clicks and sliding noises of stone on stone echo through nearby corridors.");
                SetFlag(player, type, doMsgs, FlagTypeParty, TORCHSWITCH, 1);
            }
            else {
                ShowText(player, type, doMsgs, "You decidedly move the switch again, thinking it best not to fiddle with things so well marked.");
                SetFlag(player, type, doMsgs, FlagTypeParty, TORCHSWITCH, 0);
            }
        }
        protected override void FnEvent27(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A glowing teleport stands ready.");
            TeleportParty(player, type, doMsgs, 12, 1, 237, Direction.South);
        }
        protected override void FnEvent28(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A glowing teleport stands ready.");
            TeleportParty(player, type, doMsgs, 12, 1, 0, Direction.West);
        }
        protected override void FnEvent29(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A glowing teleport stands ready.");
            TeleportParty(player, type, doMsgs, 12, 1, 144, Direction.North);
        }
        protected override void FnEvent2A(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "A war party of adventurers prepare an offensive.");
            switch (GetPartyCount(player, type, doMsgs)) {
                case 1:
                    AddEncounter(player, type, doMsgs, 01, 15);
                    AddEncounter(player, type, doMsgs, 02, 17);
                    AddEncounter(player, type, doMsgs, 06, 16);
                    break;
                case 2:
                    AddEncounter(player, type, doMsgs, 01, 20);
                    AddEncounter(player, type, doMsgs, 02, 18);
                    AddEncounter(player, type, doMsgs, 03, 19);
                    AddEncounter(player, type, doMsgs, 04, 16);
                    break;
                default:
                    AddEncounter(player, type, doMsgs, 01, 15);
                    AddEncounter(player, type, doMsgs, 02, 20);
                    AddEncounter(player, type, doMsgs, 03, 17);
                    AddEncounter(player, type, doMsgs, 04, 18);
                    AddEncounter(player, type, doMsgs, 05, 19);
                    AddEncounter(player, type, doMsgs, 06, 16);
                    break;
            }
        }
        protected override void FnEvent2B(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "It's unusually dim in this room.  It appears as though a violent battle has recently taken place;");
            ShowText(player, type, doMsgs, "seeing that charred remains litter the floor and scorch marked stone decorates the walls!");
        }
        protected override void FnEvent2D(TwPlayerServer player, MapEventType type, bool doMsgs) {
            DisableAutomaps(player, type, doMsgs);
        }
        protected override void FnEvent2E(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, RODOFDISSEMINATION) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ITEMUSES) == 0)) {
                SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ITEMUSES, 1);
                ShowText(player, type, doMsgs, "The Rod of Dissemination ignites with magical fury! Use it to blaze your own pathway through these magical walls.");
            }
        }
    }
}
