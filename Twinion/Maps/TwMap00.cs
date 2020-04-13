using XPT.Games.Generic.Constants;
using XPT.Games.Generic.Maps;
using XPT.Games.Twinion.Entities;

namespace XPT.Games.Twinion.Maps {
    /// <summary>
    /// L1: Main Entrance
    /// </summary>
    class TwMap00 : TwMap {
        public override int MapIndex => 0;
        public override int MapID => 0x0101;
        protected override int RandomEncounterChance => 0;
        protected override int RandomEncounterExtraCount => 0;

        private const int CHORONZAR_KILLED_BIT = 4;
        protected override void FnEvent01(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "This Gateway leads out of the Dungeon.");
            ExitDungeon(player, type, doMsgs);
        }
        protected override void FnEvent02(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "The door is marked: 'To Gauntlet Gauche.'");
            TeleportParty(player, type, doMsgs, 1, 2, 127, Direction.West);
        }
        protected override void FnEvent03(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Herein lies Gauntlet Droit.");
            TeleportParty(player, type, doMsgs, 1, 3, 80, Direction.East);
        }
        protected override void FnEvent04(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "To the first level of Her Majesty's proving grounds...The Queen's Aqueduct.");
            TeleportParty(player, type, doMsgs, 2, 1, 248, Direction.North);
        }
        protected override void FnEvent05(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Enter the Kingdom of the Night Elves... ");
            ShowText(player, type, doMsgs, "               ....and beware.");
            TeleportParty(player, type, doMsgs, 4, 1, 240, Direction.North);
        }
        protected override void FnEvent06(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Here you enter the Dralkarians' Lair.");
            TeleportParty(player, type, doMsgs, 8, 1, 112, Direction.East);
        }
        protected override void FnEvent07(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if ((GetPartyLevel(player, type, doMsgs, 12)) && (GetPartyCount(player, type, doMsgs) == 1)) {
                if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DEEPPORTALS) == 1) {
                    FindStr(player, type, doMsgs);
                }
                else if (UsedItem(player, type, ref doMsgs, QUEENSKEY, QUEENSKEY)) {
                    ShowText(player, type, doMsgs, "As you unlock the door with Her Majesty's key, the lock on the door as well as the key vanish!");
                    ShowText(player, type, doMsgs, "Now the door will remain unlocked.");
                    SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DEEPPORTALS, 1);
                    RemoveItem(player, type, doMsgs, QUEENSKEY);
                    RemoveItem(player, type, doMsgs, ROPE);
                    FindStr(player, type, doMsgs);
                }
                else {
                    ShowText(player, type, doMsgs, "The Queen's key is needed to unlock this door.");
                    SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                }
            }
            else {
                ShowText(player, type, doMsgs, "Only more experienced heroes may venture beyond this gateway. And even then, you must enter alone!");
                SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            }
        }
        private void FindStr(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Find your fate in the portal east of here.");
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), Direction.East);
        }
        protected override void FnEvent08(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (GetPartyLevel(player, type, doMsgs, 23)) {
                if (GetPartyCount(player, type, doMsgs) == 1) {
                    if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DRAKSPORT) == 1 || GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DRAKSPORT) == 2) {
                        NorthStr(player, type, doMsgs);
                    }
                    else if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DRAKSPORT) == 0) && HasItem(player, type, doMsgs, WHOLEMAP)) {
                        ShowText(player, type, doMsgs, "Your map begins to glow with an eerie green light. The light then fades to red followed by blue and finally brilliant yellow.");
                        ShowText(player, type, doMsgs, "The magical light of this most curious map dispels the door's magic!");
                        ShowText(player, type, doMsgs, "The map, drained of its powers, crumbles into the nothingness from which it came.");
                        SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DRAKSPORT, 1);
                        RemoveItem(player, type, doMsgs, WHOLEMAP);
                        NorthStr(player, type, doMsgs);
                    }
                    else {
                        GenericStr(player, type, doMsgs);
                    }
                }
                else {
                    ShowText(player, type, doMsgs, "You must journey northward alone!");
                    SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                }
            }
            else {
                GenericStr(player, type, doMsgs);
            }
        }
        private void GenericStr(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Destiny awaits. It will be here for you when you are ready.");
            SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        private void NorthStr(TwPlayerServer player, MapEventType type, bool doMsgs) {
            ShowText(player, type, doMsgs, "Northward lies the passage of Fate.");
            ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
            SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
        }
        protected override void FnEvent09(TwPlayerServer player, MapEventType type, bool doMsgs) {
            if (HasItem(player, type, doMsgs, JESTERSCAP) && (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.CHOR_NPC_KILLED) & CHORONZAR_KILLED_BIT) == 0) {
                ShowText(player, type, doMsgs, "A maniacal fiend appears; removes an item you stole from him; and kills you outright.");
                while (HasItem(player, type, doMsgs, JESTERSCAP))
                    RemoveItem(player, type, doMsgs, JESTERSCAP);
                    ModifyGold(player, type, doMsgs,  - 10000);
                    DoDamage(player, type, doMsgs, GetHealthMax(player, type, doMsgs));
                    // EXIT_DUNGEON(player, type, doMsgs);
                }
            }
            protected override void FnEvent0A(TwPlayerServer player, MapEventType type, bool doMsgs) {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ShowText(player, type, doMsgs, "Welcome, brave Champions. To the west lies Gauntlet Gauche: one of the two maps that interweave a simple quest.");
                ShowText(player, type, doMsgs, "Eastward lies Gauntlet Droit. There you will find challenges and helpful friends to start you on your way.");
                ShowText(player, type, doMsgs, "These two maps comprise the Gauntlet... A simple quest that you'd be wise to undertake before all else.");
            }
            protected override void FnEvent0B(TwPlayerServer player, MapEventType type, bool doMsgs) {
                ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                ShowText(player, type, doMsgs, "Northward is the entrance to the Queen's Proving Grounds. You begin there in Her Majesty's Aqueduct.");
                ShowText(player, type, doMsgs, "That will start your ascent to greater challenges. Fare well wherever you fare.");
            }
            protected override void FnEvent0C(TwPlayerServer player, MapEventType type, bool doMsgs) {
                DisablePartyJoining(player, type, doMsgs);
            }
            protected override void FnEvent0D(TwPlayerServer player, MapEventType type, bool doMsgs) {
                DisableSpells(player, type, doMsgs);
                if (GetPartyLevel(player, type, doMsgs, 23)) {
                    if (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DRAKSPORT) == 1) {
                        ShowPortrait(player, type, doMsgs, QUEENAEOWYN);
                        ShowText(player, type, doMsgs, "The Queen is here:");
                        ShowText(player, type, doMsgs, "'Loyal Champions! A magnificent achievement!");
                        ShowText(player, type, doMsgs, "Now, as to the markings here at this secret entrance...");
                        ShowText(player, type, doMsgs, "This will take you into the lowest depths!");
                        ShowText(player, type, doMsgs, "Together, we will breach the gates of time and march into a new world of wonders! But only together.");
                        ShowText(player, type, doMsgs, "Each of the vile deities whom the Night Elves worship wears a magical ring. You must get each ring from its owner!");
                        ShowText(player, type, doMsgs, "Together, the rings are the keys that will allow us to enter the Portal of Time. And then, loyal Champions, I know not where we shall step through into Immortality.");
                        ShowText(player, type, doMsgs, "Go, now! I shall be with thee! I will come to thee when I can. Fare thee well!'");
                        SetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DRAKSPORT, 2);
                    }
                    else if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.FINISHEDGAME) == 0)) {
                        ShowText(player, type, doMsgs, "Let us not dally...northward, onward to destiny.");
                    }
                }
                else {
                    ShowText(player, type, doMsgs, "Your experience is not suited for the horrors through here. Seek thee more knowledge then return.");
                    TeleportParty(player, type, doMsgs, 1, 1, 206, Direction.South);
                }
            }
            protected override void FnEvent0E(TwPlayerServer player, MapEventType type, bool doMsgs) {
                DisableAutomaps(player, type, doMsgs);
            }
            protected override void FnEvent0F(TwPlayerServer player, MapEventType type, bool doMsgs) {
                DisablePartyJoining(player, type, doMsgs);
                if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.DEEPPORTALS) == 0)) {
                    ShowText(player, type, doMsgs, "Only more experienced heroes may venture beyond this gateway. And even then, you must have completed the Queen's proving grounds and acquired Her key!");
                    TeleportParty(player, type, doMsgs, 1, 1, 200, Direction.East);
                }
            }
            protected override void FnEvent11(TwPlayerServer player, MapEventType type, bool doMsgs) {
                TeleportParty(player, type, doMsgs, 1, 1, 88, Direction.North);
            }
            protected override void FnEvent12(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if ((GetPartyCount(player, type, doMsgs) == 1) && (GetPartyLevel(player, type, doMsgs, 35))) {
                    if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ENDGAMETELE) == 1) || (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ENDGAMETELE) == 2)) {
                        SetWallItem(player, type, doMsgs, DOOR, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                        ShowText(player, type, doMsgs, "A mystic portal appears, granting you an ingress to the chambers of time.");
                        ClearWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                    }
                    else {
                        ClearWallItem(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                        SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                    }
                }
                else {
                    ClearWallItem(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                    SetWallBlock(player, type, doMsgs, GetTile(player, type, doMsgs), GetFacing(player, type, doMsgs));
                }
            }
            protected override void FnEvent13(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GetPartyCount(player, type, doMsgs) == 1) {
                    if ((GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ENDGAMETELE) == 1) || (GetFlag(player, type, doMsgs, FlagTypeDungeon, TwIndexes.ENDGAMETELE) == 2)) {
                        ShowText(player, type, doMsgs, "Go from here to the depths of time! Enter into the deepest wells of your destiny! This will take you to the start of Dissemination.");
                        TeleportParty(player, type, doMsgs, 12, 1, 255, Direction.West);
                    }
                }
                else {
                    ShowText(player, type, doMsgs, "You must enter alone!");
                    TeleportParty(player, type, doMsgs, 1, 1, 19, Direction.North);
                }
            }
            protected override void FnEvent14(TwPlayerServer player, MapEventType type, bool doMsgs) {
                if (GetPartyCount(player, type, doMsgs) == 1) {
                    if (IsFlagOn(player, type, doMsgs, FlagTypeDungeon, TwIndexes.TOTHEQUEEN)) {
                        ShowText(player, type, doMsgs, "A portal forms in the wall before you! Iridescent light filters into the room, surrounding you with a vapor of magic.");
                        ShowText(player, type, doMsgs, "THIS portal will take you into the final challenge...your Fate is at hand.");
                        TeleportParty(player, type, doMsgs, 12, 2, 255, Direction.West);
                    }
                }
                else {
                    ShowText(player, type, doMsgs, "In time, this ingress shall grant you passage; but only alone and after you've earned the right, may you proceed.");
                    TeleportParty(player, type, doMsgs, 1, 1, 19, Direction.North);
                }
            }
        }
    }
