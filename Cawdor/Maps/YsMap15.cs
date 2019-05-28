#pragma warning disable
using System.Collections.Generic;
using XPT.WorldData;
using XPT.WorldData.Yserbius;

namespace XPT.Scripts.Yserbius.Maps {
    class YserMap15 : AMapScripted {
        protected override int MapIndex => 15;
        protected override int RandomEncounterChance => 10;
        protected override int RandomEncounterExtraCount => 0;

        public YserMap15() {
            MapEvent01 = Fn_01;
            MapEvent02 = Fn_02;
            MapEvent03 = Fn_03;
            MapEvent07 = Fn_07;
            MapEvent08 = Fn_08;
            MapEvent09 = Fn_09;
            MapEvent0B = Fn_0B;
            MapEvent0C = Fn_0C;
            MapEvent0D = Fn_0D;
            MapEvent0E = Fn_0E;
            MapEvent0F = Fn_0F;
            MapEvent10 = Fn_10;
            MapEvent11 = Fn_11;
            MapEvent12 = Fn_12;
            MapEvent13 = Fn_13;
            MapEvent14 = Fn_14;
            MapEvent15 = Fn_15;
            MapEvent16 = Fn_16;
            MapEvent17 = Fn_17;
            MapEvent18 = Fn_18;
            MapEvent19 = Fn_19;
            MapEvent1A = Fn_1A;
            MapEvent1C = Fn_1C;
            MapEvent1D = Fn_1D;
            MapEvent1E = Fn_1E;
            MapEvent20 = Fn_20;
            MapEvent21 = Fn_21;
            MapEvent22 = Fn_22;
            MapEvent24 = Fn_24;
            MapEvent25 = Fn_25;
            MapEvent27 = Fn_27;
            MapEvent28 = Fn_28;
            MapEvent29 = Fn_29;
            MapEvent2A = Fn_2A;
            MapEvent2B = Fn_2B;
            MapEvent2C = Fn_2C;
            MapEvent2D = Fn_2D;
            MapEvent2E = Fn_2E;
            MapEvent30 = Fn_30;
            MapEvent31 = Fn_31;
            MapEvent33 = Fn_33;
            MapEvent34 = Fn_34;
            MapEvent35 = Fn_35;
            MapEvent36 = Fn_36;
            MapEvent37 = Fn_37;
            MapEvent38 = Fn_38;
            MapEvent39 = Fn_39;
            MapEvent3A = Fn_3A;
            MapEvent3B = Fn_3B;
            MapEvent3C = Fn_3C;
            MapEvent3D = Fn_3D;
            MapEvent3E = Fn_3E;
            MapEvent3F = Fn_3F;
            MapEvent40 = Fn_40;
            MapEvent41 = Fn_41;
            MapEvent42 = Fn_42;
            MapEvent43 = Fn_43;
            MapEvent44 = Fn_44;
            MapEvent45 = Fn_45;
            MapEvent46 = Fn_46;
            MapEvent47 = Fn_47;
            MapEvent48 = Fn_48;
            MapEvent49 = Fn_49;
            MapEvent4A = Fn_4A;
            MapEvent4B = Fn_4B;
            MapEvent4C = Fn_4C;
        }
        
        // === Strings ================================================
        private const string String0140 = "You cannot decipher these books.";
        private const string String0161 = "These books contain nothing of interest to you.";
        private const string String0191 = "This area has been badly damaged in some battle.  Scorch marks abound, and the thick magical chains that normally bind the books to the walls end in empty links.";
        private const string String0233 = "'Two trolls, a knight and a cleric by their garb, courteously hold open a secret door for you.  'Watch your back in here,' they caution you.  'There is many a dagger in amongst the cloaks.'";
        private const string String02F1 = "The door to the Cloak Room refuses to budge.";
        private const string String031E = "This door leads to the Ballroom.";
        private const string String033F = "'Carry on, carry on.  And do try to refrain from using fire spells.'";
        private const string String0384 = "'Welcome to the Tomes of Cawdor.  I do not recall seeing thee before, so I shall give thee our rules.";
        private const string String03EA = "Please try not to use fireballs and other fire spells.  The books all have magical protections upon them, but they are not perfect.";
        private const string String046E = "Attempting to steal a book is usually fatal.  Magical protections, eh?";
        private const string String04B5 = "Finally, they are referenced by row and column.  Each room's books have a common theme.  Happy reading.'";
        private const string String051E = "'Welcome back!  Remember, no fire, no theft, and nobody gets hurt.'";
        private const string String0562 = "The Plaque on the door reads 'O'";
        private const string String0583 = "The Plaque on the door reads 'C'";
        private const string String05A4 = "The Plaque on the door reads 'N'";
        private const string String05C5 = "The Plaque on the door reads 'W'";
        private const string String05E6 = "Spears, sticks, staves, and monsters.";
        private const string String060C = "Armor, shields, helms, swords, and mythology.";
        private const string String063A = "Gloves, history, poisons, axes, and mana.";
        private const string String0664 = "Defense, bows, initiative, curing, and jewelry.";
        private const string String0694 = "Stoning, attack, hammers, healing, and paralysis.";
        private const string String06C6 = "Axes, spears, hammers, swords, and jewelry.";
        private const string String06F2 = "Paralysis, helms, monsters, mana, and bows.";
        private const string String071E = "Defense, monsters, attack, history, and mythology.";
        private const string String0751 = "Shields, initiative, poison, healing, and sticks.";
        private const string String0783 = "Staves, armor, stonings, curing, and gloves.";
        private const string String07B0 = "After searching through many books, this is the information you find that interests you:";
        private const string String0809 = "In this corner of the room a few books are somewhat intact.";
        private const string String0845 = "These are the spell levels of swords: ";
        private const string String086C = " Martel's, Storm Wind, six; Hengist's, Fireball, five; Talorcan's, Petrify, three; Edwin's, Hail, six; Oswald's Bane, Dissipate, six.";
        private const string String08F2 = "Ecgfrith's, Blast, eight; Athelstan's, Poison Cloud, two; Scramasax, Poison Cloud, seven.";
        private const string String094C = "These swords have special powers against certain foes:  ";
        private const string String0985 = "Martel's, Mammals, Defense; Lowland Stabber, NPC's, Attack; Oswald's Bane, Undead, Damage; Ecgfrith's, Mammals, Damage; Athelstan's, Hybrids, Damage.";
        private const string String0A1B = "Claymore, Winged Creatures, Damage; Lodbrok's, Macbeth's Ilk, Damage.";
        private const string String0A61 = "These swords absorb damage: ";
        private const string String0A7E = "Seax and Claymore.";
        private const string String0A91 = "These are the spell levels of axes: ";
        private const string String0AB6 = "Duncan's, Heal, three; Donalbain's, Poison Cloud, three; Banquo's, Backfire, six; The Axe of Angus, Dissipate, twelve.";
        private const string String0B2D = "These axes have special powers against certain foes:";
        private const string String0B62 = "Malcolm's Chopper, Undead, Damage; Banquo's, Demi-humanoids, Damage.";
        private const string String0BA7 = "The only axe that absorbs damage is Banquo's, and that is not much.";
        private const string String0BEB = "These are the spell levels of clubs and hammers: ";
        private const string String0C1D = "Cathness's, Petrify, three; Strathclyde's, Heal, six; Hecate's, Backfire, ten; Fleance's, Cure, ten; Horsa's, Fireball, six; Macduff's Maul, Blast, ten.";
        private const string String0CB6 = "These clubs and hammers have special powers against certain foes:";
        private const string String0CF8 = "Cathness's, Winged Creatures, Damage; Hilda's, Ghosts, Attack; Horsa's, Hybrids, Damage; Macduff's Maul, Giants, Lots of damage.";
        private const string String0D79 = "These are the spell levels of spears: ";
        private const string String0DA0 = "Ascomanni, Poison Cloud, five; Tapering, Lightning, nine; Bayonet, Resuscitate, eight; Leaf, Backfire, six; Oswy's Javelin, Control, eight; Lugh's, Death Darts, six.";
        private const string String0E46 = "These spears do extra damage against certain foes:";
        private const string String0E79 = "Lozenge, Giants, (lots); Leaf, Demi-humanoids; Lance, Hybrids.";
        private const string String0EB8 = "All spears and staves take away from the force of your enemy's blows in combat.";
        private const string String0F08 = "These are the spell levels of staves: ";
        private const string String0F2F = "Elchere's, Fireball, nine; Coerl's, Dissipate, seven; Osric's, Blast, eleven; Swithun's, Petrify, ten; Aldhelm's, Death Darts, twelve.";
        private const string String0FB6 = "These staves do extra damage against certain foes:";
        private const string String0FE9 = "Wulfherd's, Wizards and Clerics, (lots); Swithun's, Giants.";
        private const string String1025 = "These are the spell levels of bows: ";
        private const string String104A = "Hunting, Dissipate, seven; Welsh Longbow, Storm Wind, five; Bernician, Blast, eight; Deiran, Fireball, four; Bow of Badonicus, Backfire, six.";
        private const string String10D8 = "Yew Bow of York, Lightning, four; Dalriadan, Death Darts, six.";
        private const string String1117 = "These bows do extra damage against certain foes:";
        private const string String1148 = "Hunting, Undead; Composite, Mammals; Welsh Longbow, Hybrids; Bow of Badonicus, Magi; Yew Bow of York, Macbeth's Ilk; Brunanburh, Dragons; Dalriadan, Undead.";
        private const string String11E5 = "No bows absorb any extra damage.";
        private const string String1206 = "These are the spell levels of shields: ";
        private const string String122E = "Linden, Heal, four; Iron Bossed, Hail, two; Shield Wall, Fireball, five; Guardian of Wessex, Backfire, six; ";
        private const string String129B = "Ethelbald's, Energy Field, six; Ealstan's Absorber, Shroud of Light, seven; My Lady's Favor, Control, six.";
        private const string String1306 = "Spiked, Death Darts, ten; Hadrian's Wall, Shield, twelve.  The Pointed Shield can Deflect Magic and Edwin's Defender Channels.";
        private const string String1385 = "These shields have extra defenses against certain foes:";
        private const string String13BD = "Flat, Macbeth's Ilk; Shield Wall, Dragons; Guardian of Wessex and Ethelbald's Buckler, Magi; Wulfherd's, Ghosts; My Lady's Favor, Undead; Edwin's Defender, Ghosts.";
        private const string String1461 = "These are the spell levels of headgear: ";
        private const string String148A = "Turkish Hat, Lightning, five; Huda's Headgear, Control, eleven; Antlered Helm, True Seeing, nine; Unicorn Horn Helm, Blast, nine.";
        private const string String150C = "Rhino Horn Helm, Death Darts, seven; Ironside's Headgear, Backfire, four; Ealstan's Cap can perform Deep Trance, Wulfherd's Helm can Read Runes.";
        private const string String159D = "Deer Horned Helm Pursues, Spiked Helm Binds, Reindeer Horn Helm Tracks, Ivar's Helm Detects, and Alfred's Hat Picks Locks.";
        private const string String1618 = "These helms give extra physical or magical defense against certain foes:";
        private const string String1661 = "Ealstan's Cap, Magi; Antlered Helm, Giants; Unicorn Horn Helm, Magi; Phrygian Cap, Demi-humanoids; Alfred's Hat, Dragons; Ironside's Headgear, Giants.";
        private const string String16F8 = "No known armor casts spells.  Holy Vestments: Furtiveness; Wizard's Tabard Deflects Magic; Thief's Tabard: Deep Trance; Ranger's Tabard: Medic; Mendicant's Tunic: Berserker.";
        private const string String17A6 = "These armors have extra defenses against certain foes: ";
        private const string String17DE = "Adamantine Plate, Magi; Holy Vestments, Non-Magi; Thief's Tabard, Undead; Ranger's Tabard, Magi; Barbarian's Tabard, Macbeth's Ilk; Disbelieving Tunic, Demi-humanoids.";
        private const string String1886 = "What an incredible stroke of luck!  Despite all the unfriendly things you did last time, you have stumbled upon Manannan Mac Lir's Ring!";
        private const string String190F = "If you really believe it was just luck, I have some swampland in the Shetlands I want to sell you.";
        private const string String1972 = "Succubus Pipes cast Control at level eight.";
        private const string String199E = "Alcuin's Ring and the Holy Relic absorb more damage than any other pieces of jewelry.";
        private const string String19F4 = "Finally, Ohthere's Dagger has a power over water, but the book is charred before it says what.";
        private const string String1A53 = "These are the powers of gloves:  ";
        private const string String1A75 = "Aldhelm's, Heal, three; Alcuin's, Energy Field, eight; ";
        private const string String1AAD = "The Gorgon's Gauntlets are tremendously powerful weapons if wielded by one with the Martial Arts skill.  They also cast Petrify at eight and do extra damage to giants.";
        private const string String1B55 = "The Adamantine Gloves absorb the most damage, add to Martial Arts attacks, cast Resist at eight, and provide extra defense against dragons.";
        private const string String1BE1 = "Evidently, sticks are the preferred weapons of clerics, as gloves are their preferred shields.";
        private const string String1C40 = "Alcuin's Sticks See Truly at twelve and do extra damage against Non-Magi.  Menteth's Maul casts Death Darts at ten and does huge amounts of damage, while exposing the user to many counterattacks.";
        private const string String1D04 = "Woe betide us, for no longer do items prevent paralysis!";
        private const string String1D3D = "These items are the best weapons of each class:  ";
        private const string String1D6F = "Claymore, Lodbrok's Blade, Banquo's Axe, Menteth's or MacDuff's Maul, Horsa's or Hilda's Hammer, Swithun's Staff, Brunanburh or Dalriadan Bow, Gorgon's Gauntlets, or Thor's Bane.";
        private const string String1E22 = "Alcuin's Cap makes a lowly wizard as powerful as a mighty barbarian.";
        private const string String1E67 = "The items listed as powerful against Macbeth's Ilk for their spells have a second power: if equipped, they make a warrior fight as many against Macbeth's Ilk!  This last is very useful.";
        private const string String1F21 = "Magi are wizards and clerics; non-magi are thieves, barbarians, knights, and rangers; mammals are boars, panthers, and hounds; winged creatures are harpies and bats; hybrids are medusae and minotaurs.";
        private const string String1FEA = "Undead are vampires, skeletons, wraiths, and zombies; demi-humanoids are imps and picts; giants and golems are giants.  All for purposes of items having special effects.";
        private const string String2094 = "You learn that ghosts are ghosts, slimes are slimes, and dragons are dragons.  Hey!  Did I promise that you'd be excited by everything you'd learn here?";
        private const string String212D = "Something shimmers into visibility in the northwest corner of this room.";
        private const string String2176 = "*";
        private const string String2178 = "You see an image coalesce in the middle of the room.  Standing amidst a storm-tossed sea, you again see Mannanan Mac Lir.";
        private const string String21F2 = "'Hah!  I knew you were of sterner stuff than the last batch of bacon-brains Galatea sent.  I bring you greetings, and rewards.'";
        private const string String2272 = "'My cousin Mider has long been denied many of the spirits those witches have had bound to this place these many decades, so we approve of her quest, and yours.'";
        private const string String2313 = "'You may or may not find the weapon and shield useful.  They are but trinkets.  The dagger, however, is essential.'";
        private const string String2387 = "'You will need it in the Kitchen, in an area where spells will fail you and skill not avail you.'";
        private const string String23E9 = "Mannanan tosses the dagger, which lands at your feet and slides behind you.";
        private const string String2435 = "'I do not choose this enforced indirection, but as your life has rules and obligations, so does even the Sea God's.  My blessing upon you, child....'";
        private const string String24CB = "The image fades, although the floor looks rather damper than it was.";
        private const string String2510 = "Mannanan Mac Lir is the son of the god of the sea.  He controls the waters, and grants favors concerning water to those he would aid.  ";
        private const string String2598 = "His spears are Yellow Shaft and Red Javelin.  His sword, The Retaliator, never fails to slay.";
        private const string String25F6 = "Lugh of the Long Spear is a god of the sun.  In battle he shines so brightly that none may look upon him, and his living spear fights by itself.  He is a master of all skills.";
        private const string String26A6 = "Nuada Silverhand is a god of war and, until he lost his hand in battle, the king of the Celtic gods.  ";
        private const string String270D = "Diancecht made his silver hand, and Miach, Diancecht's son, healed the severed hand, allowing Nuada to again become king of the gods.";
        private const string String2793 = "Cuchulain, son of Lugh, also is a god of the sun.  He is so hot that he melts snow for thirty feet around him.  When he baths, in the sea, it boils.  His spear, the Gae Bolg, never fails to pierce its target.";
        private const string String2864 = "Diancecht is a god of healing.  So long as the head is not severed or the brain or spine broken he can restore any wound.  He is the grandfather of Lugh.";
        private const string String28FE = "Brigit, daughter of The Dagda, is a goddess of fire, the hearth, and poetry.  When she was born, the house burst into flames.  When her son, Ruadan, was killed, she invented 'keening.'";
        private const string String29B7 = "Alcuin was an English scholar from York.  He served Charlemagne in France.  Alcuin was perhaps the greatest mind of his time, and items bearing his name can be assumed to be particularly useful.";
        private const string String2A7A = "Oswald, Oswy, and Ecgfrith were early kings of newly united Northumbria.  At the battle of Nechtanemsmere, the Scottish Picts defeated Ecgfrith and ended Northumbria's eminence.";
        private const string String2B2C = "Streoneshalh was a holy place of old, though we now know it as Whitby Abbey.  Hilda was Streoneshalh's first Abbess.";
        private const string String2BA1 = "Aldhelm was the Bishop of Sherbourne and a great musician.  He installed the first organ in England.  While in his seventies he travelled carrying a staff and a harp.";
        private const string String2C48 = "Ohthere was a Norse sea captain.  A fearless sailor, he was the first civilised man recorded to have found the White Sea, as documented by King Alfred the Great.";
        private const string String2CEA = "Eadburga was Queen of Wessex.  Her husband, Beorhtric, ruled with great wisdom for sixteen years, until she realized that he favored the advice of an alderman named Warr over hers.  ";
        private const string String2DA1 = "She poisoned Warr, not knowing that Beorhtric too would sip of Warr's drink, and thus killed her husband as well.";
        private const string String2E13 = "Alfred the Great was the finest Saxon king of England.  Outnumbered, with most of his kingdom conquered, he subdued or drove off the Danes, and eventually unified all of England.  ";
        private const string String2EC8 = "He built England's first navy, ending at last the waves of invaders from the continent.";
        private const string String2F20 = "Alfred codified the laws, encouraged the arts, and was a heck of a nice guy.  Magic items bearing his name can be assumed to be fairly powerful.";
        private const string String2FB1 = "The Dagda is the god of the earth.  His cauldron, the Undry, feeds all according to their merits, and none leave it unsatisfied.  When he plays his living harp, the seasons change.";
        private const string String3066 = "Ogma Honeymouthed is one of the sons of Dagda.  He is the god of literature and eloquence.  He is the champion of the Tuatha De' Dannan and inventor of the Ogam alphabet.";
        
        // === Functions ================================================
        private void Fn_01(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0140); // You cannot decipher these books.
            L0010: return; // RETURN;
        }

        private void Fn_02(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0161); // These books contain nothing of interest to you.
            L0010: return; // RETURN;
        }

        private void Fn_03(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0191); // This area has been badly damaged in some battle.  Scorch marks abound, and the thick magical chains that normally bind the books to the walls end in empty links.
            L0010: return; // RETURN;
        }

        private void Fn_07(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: PushStack(player, 0x04);
004D  0007 C4 5E 06  les bx, [bp+0x6]
0050  000A 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L000F: cx = PopStack(player);
            L0010: RefreshCompareFlags(ax);
            L0012: if (JumpEqual) goto L0025;
            L0014: PushStack(player, 0x01);
005E  0018 C4 5E 06  les bx, [bp+0x6]
0061  001B 26 FF 9F B0 00  call far word [es:bx+0xb0]
            L0020: cx = PopStack(player);
            L0021: RefreshCompareFlags(ax);
            L0023: if (JumpNotEqual) goto L0051;
            L0025: Compare(GetFlag(player, 0x02, 0x14), 0x0001);
            L0039: if (JumpEqual) goto L0051;
            L003B: Compare(GetFlag(player, 0x02, 0x1B), 0x0001);
            L004F: if (JumpNotEqual) goto L00C3;
            L0051: ShowPortrait(player, 0x001B);
            L005E: ShowMessage(player, String0233); // 'Two trolls, a knight and a cleric by their garb, courteously hold open a secret door for you.  'Watch your back in here,' they caution you.  'There is many a dagger in amongst the cloaks.'
            L006B: SetWallPassable(player, GetCurrentTile(player), GetFacing(player), 0x01);
            L0089: SetWallObject(player, 0x01, GetCurrentTile(player), GetFacing(player));
            L00A7: TeleportParty(player, 0x06, 0x01, 0x9F, 0x00, isForwardMove);
            L00C1: goto L00D0;
            L00C3: ShowMessage(player, String02F1); // The door to the Cloak Room refuses to budge.
            L00D0: return; // RETURN;
        }

        private void Fn_08(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String031E); // This door leads to the Ballroom.
            L0010: TeleportParty(player, 0x05, 0x02, 0x0C, 0x01, isForwardMove);
            L002B: return; // RETURN;
        }

        private void Fn_09(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowPortrait(player, 0x002B);
            L0010: SetFlag(player, 0x02, 0x1C, 0x01);
            L0025: Compare(GetFlag(player, 0x03, 0x01), 0x0001);
            L0039: if (JumpNotEqual) goto L0040;
0180  003B B8 3F 03  mov ax, 0x33f
            L003E: goto L00AB;
            L0040: PushStack(player, 0x01);
            L0044: PushStack(player, ax);
            L0045: PushStack(player, 0x03);
018E  0049 C4 5E 06  les bx, [bp+0x6]
0191  004C 26 FF 1F  call far word [es:bx]
0194  004F 83 C4 06  add sp, 0x6
            L0052: RefreshCompareFlags(GetFlag(player, 0x02, 0x33));
            L0065: if (JumpNotEqual) goto L00A8;
            L0067: SetFlag(player, 0x02, 0x33, 0x01);
            L007C: ShowMessage(player, String0384); // 'Welcome to the Tomes of Cawdor.  I do not recall seeing thee before, so I shall give thee our rules.
            L0089: ShowMessage(player, String03EA); // Please try not to use fireballs and other fire spells.  The books all have magical protections upon them, but they are not perfect.
            L0096: ShowMessage(player, String046E); // Attempting to steal a book is usually fatal.  Magical protections, eh?
01E8  00A3 B8 B5 04  mov ax, 0x4b5
            L00A6: goto L00AB;
            L00A8: ShowMessage(player, String051E); // 'Welcome back!  Remember, no fire, no theft, and nobody gets hurt.'
            L00B5: return; // RETURN;
        }

        private void Fn_0B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0562); // The Plaque on the door reads 'O'
            L0010: return; // RETURN;
        }

        private void Fn_0C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowMessage(player, String0583); // The Plaque on the door reads 'C'
            L0010: return; // RETURN;
        }

        private void Fn_0D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L0017: if (JumpNotEqual) goto L008A;
            L0019: ax = HasItem(player, 0xD8);
            L0027: if (JumpNotEqual) goto L008A;
            L0029: Compare(GetCurrentTile(player), 0x002E);
            L0033: if (JumpNotEqual) goto L008A;
            L0035: SetFlag(player, 0x03, 0x09, 0x00);
            L0049: GiveItem(player, 0xD8);
            L0055: GiveItem(player, 0x2F);
            L0061: GiveItem(player, 0x52);
            L006D: ax = HasItem(player, 0xD9);
            L007B: if (JumpEqual) goto L0097;
            L007D: PushStack(player, 0xD9);
02A6  0081 C4 5E 06  les bx, [bp+0x6]
02A9  0084 26 FF 5F 4C  call far word [es:bx+0x4c]
            L0088: goto L0096;
            L008A: ShowMessage(player, String05A4); // The Plaque on the door reads 'N'
            L0097: return; // RETURN;
        }

        private void Fn_0E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: Compare(GetFlag(player, 0x03, 0x09), 0x0001);
            L0017: if (JumpNotEqual) goto L008A;
            L0019: ax = HasItem(player, 0xD8);
            L0027: if (JumpNotEqual) goto L008A;
            L0029: Compare(GetCurrentTile(player), 0x001D);
            L0033: if (JumpNotEqual) goto L008A;
            L0035: SetFlag(player, 0x03, 0x09, 0x00);
            L0049: GiveItem(player, 0xD8);
            L0055: GiveItem(player, 0x2F);
            L0061: GiveItem(player, 0x52);
            L006D: ax = HasItem(player, 0xD9);
            L007B: if (JumpEqual) goto L0097;
            L007D: PushStack(player, 0xD9);
033F  0081 C4 5E 06  les bx, [bp+0x6]
0342  0084 26 FF 5F 4C  call far word [es:bx+0x4c]
            L0088: goto L0096;
            L008A: ShowMessage(player, String05C5); // The Plaque on the door reads 'W'
            L0097: return; // RETURN;
        }

        private void Fn_0F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String05E6); // Spears, sticks, staves, and monsters.
            L0010: return; // RETURN;
        }

        private void Fn_10(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String060C); // Armor, shields, helms, swords, and mythology.
            L0010: return; // RETURN;
        }

        private void Fn_11(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String063A); // Gloves, history, poisons, axes, and mana.
            L0010: return; // RETURN;
        }

        private void Fn_12(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0664); // Defense, bows, initiative, curing, and jewelry.
            L0010: return; // RETURN;
        }

        private void Fn_13(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0694); // Stoning, attack, hammers, healing, and paralysis.
            L0010: return; // RETURN;
        }

        private void Fn_14(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String06C6); // Axes, spears, hammers, swords, and jewelry.
            L0010: return; // RETURN;
        }

        private void Fn_15(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String06F2); // Paralysis, helms, monsters, mana, and bows.
            L0010: return; // RETURN;
        }

        private void Fn_16(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String071E); // Defense, monsters, attack, history, and mythology.
            L0010: return; // RETURN;
        }

        private void Fn_17(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0751); // Shields, initiative, poison, healing, and sticks.
            L0010: return; // RETURN;
        }

        private void Fn_18(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ShowRunes(player, String0783); // Staves, armor, stonings, curing, and gloves.
            L0010: return; // RETURN;
            // Extra data: 55 8B EC B8 B0 07 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 55 8B EC B8 09 08 50 C4 5E 06 26 FF 9F F8 00 59 5D CB 
        }

        private void Fn_19(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0432  0003 FF 76 08  push word [bp+0x8]
0435  0006 FF 76 06  push word [bp+0x6]
0438  0009 0E     push cs
0439  000A E8 CF FF  call 0xffdc
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String0845); // These are the spell levels of swords: 
            L001C: ShowRunes(player, String086C); //  Martel's, Storm Wind, six; Hengist's, Fireball, five; Talorcan's, Petrify, three; Edwin's, Hail, six; Oswald's Bane, Dissipate, six.
            L0029: ShowRunes(player, String08F2); // Ecgfrith's, Blast, eight; Athelstan's, Poison Cloud, two; Scramasax, Poison Cloud, seven.
            L0036: return; // RETURN;
        }

        private void Fn_1A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
046A  0003 FF 76 08  push word [bp+0x8]
046D  0006 FF 76 06  push word [bp+0x6]
0470  0009 0E     push cs
0471  000A E8 97 FF  call 0xffa4
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String094C); // These swords have special powers against certain foes:  
            L001C: ShowRunes(player, String0985); // Martel's, Mammals, Defense; Lowland Stabber, NPC's, Attack; Oswald's Bane, Undead, Damage; Ecgfrith's, Mammals, Damage; Athelstan's, Hybrids, Damage.
            L0029: ShowRunes(player, String0A1B); // Claymore, Winged Creatures, Damage; Lodbrok's, Macbeth's Ilk, Damage.
            L0036: return; // RETURN;
        }

        private void Fn_1C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
04A7  0003 FF 76 08  push word [bp+0x8]
04AA  0006 FF 76 06  push word [bp+0x6]
04AD  0009 0E     push cs
04AE  000A E8 5A FF  call 0xff67
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String0A61); // These swords absorb damage: 
            L001C: ShowRunes(player, String0A7E); // Seax and Claymore.
            L0029: return; // RETURN;
        }

        private void Fn_1D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
04D2  0003 FF 76 08  push word [bp+0x8]
04D5  0006 FF 76 06  push word [bp+0x6]
04D8  0009 0E     push cs
04D9  000A E8 2F FF  call 0xff3c
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String0A91); // These are the spell levels of axes: 
            L001C: ShowRunes(player, String0AB6); // Duncan's, Heal, three; Donalbain's, Poison Cloud, three; Banquo's, Backfire, six; The Axe of Angus, Dissipate, twelve.
            L0029: return; // RETURN;
        }

        private void Fn_1E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
04FD  0003 FF 76 08  push word [bp+0x8]
0500  0006 FF 76 06  push word [bp+0x6]
0503  0009 0E     push cs
0504  000A E8 04 FF  call 0xff11
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String0B2D); // These axes have special powers against certain foes:
            L001C: ShowRunes(player, String0B62); // Malcolm's Chopper, Undead, Damage; Banquo's, Demi-humanoids, Damage.
            L0029: return; // RETURN;
        }

        private void Fn_20(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
052D  0003 FF 76 08  push word [bp+0x8]
0530  0006 FF 76 06  push word [bp+0x6]
0533  0009 0E     push cs
0534  000A E8 D4 FE  call 0xfee1
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String0BA7); // The only axe that absorbs damage is Banquo's, and that is not much.
            L001C: return; // RETURN;
        }

        private void Fn_21(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
054B  0003 FF 76 08  push word [bp+0x8]
054E  0006 FF 76 06  push word [bp+0x6]
0551  0009 0E     push cs
0552  000A E8 B6 FE  call 0xfec3
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String0BEB); // These are the spell levels of clubs and hammers: 
            L001C: ShowRunes(player, String0C1D); // Cathness's, Petrify, three; Strathclyde's, Heal, six; Hecate's, Backfire, ten; Fleance's, Cure, ten; Horsa's, Fireball, six; Macduff's Maul, Blast, ten.
            L0029: return; // RETURN;
        }

        private void Fn_22(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0576  0003 FF 76 08  push word [bp+0x8]
0579  0006 FF 76 06  push word [bp+0x6]
057C  0009 0E     push cs
057D  000A E8 8B FE  call 0xfe98
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String0CB6); // These clubs and hammers have special powers against certain foes:
            L001C: ShowRunes(player, String0CF8); // Cathness's, Winged Creatures, Damage; Hilda's, Ghosts, Attack; Horsa's, Hybrids, Damage; Macduff's Maul, Giants, Lots of damage.
            L0029: return; // RETURN;
        }

        private void Fn_24(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
05A6  0003 FF 76 08  push word [bp+0x8]
05A9  0006 FF 76 06  push word [bp+0x6]
05AC  0009 0E     push cs
05AD  000A E8 5B FE  call 0xfe68
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String0D79); // These are the spell levels of spears: 
            L001C: ShowRunes(player, String0DA0); // Ascomanni, Poison Cloud, five; Tapering, Lightning, nine; Bayonet, Resuscitate, eight; Leaf, Backfire, six; Oswy's Javelin, Control, eight; Lugh's, Death Darts, six.
            L0029: return; // RETURN;
        }

        private void Fn_25(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
05D1  0003 FF 76 08  push word [bp+0x8]
05D4  0006 FF 76 06  push word [bp+0x6]
05D7  0009 0E     push cs
05D8  000A E8 30 FE  call 0xfe3d
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String0E46); // These spears do extra damage against certain foes:
            L001C: ShowRunes(player, String0E79); // Lozenge, Giants, (lots); Leaf, Demi-humanoids; Lance, Hybrids.
            L0029: return; // RETURN;
        }

        private void Fn_27(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0601  0003 FF 76 08  push word [bp+0x8]
0604  0006 FF 76 06  push word [bp+0x6]
0607  0009 0E     push cs
0608  000A E8 00 FE  call 0xfe0d
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String0EB8); // All spears and staves take away from the force of your enemy's blows in combat.
            L001C: return; // RETURN;
        }

        private void Fn_28(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
061F  0003 FF 76 08  push word [bp+0x8]
0622  0006 FF 76 06  push word [bp+0x6]
0625  0009 0E     push cs
0626  000A E8 E2 FD  call 0xfdef
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String0F08); // These are the spell levels of staves: 
            L001C: ShowRunes(player, String0F2F); // Elchere's, Fireball, nine; Coerl's, Dissipate, seven; Osric's, Blast, eleven; Swithun's, Petrify, ten; Aldhelm's, Death Darts, twelve.
            L0029: return; // RETURN;
        }

        private void Fn_29(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
064A  0003 FF 76 08  push word [bp+0x8]
064D  0006 FF 76 06  push word [bp+0x6]
0650  0009 0E     push cs
0651  000A E8 B7 FD  call 0xfdc4
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String0FB6); // These staves do extra damage against certain foes:
            L001C: ShowRunes(player, String0FE9); // Wulfherd's, Wizards and Clerics, (lots); Swithun's, Giants.
            L0029: return; // RETURN;
        }

        private void Fn_2A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0675  0003 FF 76 08  push word [bp+0x8]
0678  0006 FF 76 06  push word [bp+0x6]
067B  0009 0E     push cs
067C  000A E8 8C FD  call 0xfd99
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String1025); // These are the spell levels of bows: 
            L001C: ShowRunes(player, String104A); // Hunting, Dissipate, seven; Welsh Longbow, Storm Wind, five; Bernician, Blast, eight; Deiran, Fireball, four; Bow of Badonicus, Backfire, six.
            L0029: ShowRunes(player, String10D8); // Yew Bow of York, Lightning, four; Dalriadan, Death Darts, six.
            L0036: return; // RETURN;
        }

        private void Fn_2B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
06AD  0003 FF 76 08  push word [bp+0x8]
06B0  0006 FF 76 06  push word [bp+0x6]
06B3  0009 0E     push cs
06B4  000A E8 54 FD  call 0xfd61
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String1117); // These bows do extra damage against certain foes:
            L001C: ShowRunes(player, String1148); // Hunting, Undead; Composite, Mammals; Welsh Longbow, Hybrids; Bow of Badonicus, Magi; Yew Bow of York, Macbeth's Ilk; Brunanburh, Dragons; Dalriadan, Undead.
            L0029: return; // RETURN;
        }

        private void Fn_2C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
06D8  0003 FF 76 08  push word [bp+0x8]
06DB  0006 FF 76 06  push word [bp+0x6]
06DE  0009 0E     push cs
06DF  000A E8 29 FD  call 0xfd36
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String11E5); // No bows absorb any extra damage.
            L001C: return; // RETURN;
        }

        private void Fn_2D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
06F6  0003 FF 76 08  push word [bp+0x8]
06F9  0006 FF 76 06  push word [bp+0x6]
06FC  0009 0E     push cs
06FD  000A E8 0B FD  call 0xfd18
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String1206); // These are the spell levels of shields: 
            L001C: ShowRunes(player, String122E); // Linden, Heal, four; Iron Bossed, Hail, two; Shield Wall, Fireball, five; Guardian of Wessex, Backfire, six; 
            L0029: ShowRunes(player, String129B); // Ethelbald's, Energy Field, six; Ealstan's Absorber, Shroud of Light, seven; My Lady's Favor, Control, six.
            L0036: ShowRunes(player, String1306); // Spiked, Death Darts, ten; Hadrian's Wall, Shield, twelve.  The Pointed Shield can Deflect Magic and Edwin's Defender Channels.
            L0043: return; // RETURN;
        }

        private void Fn_2E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
073B  0003 FF 76 08  push word [bp+0x8]
073E  0006 FF 76 06  push word [bp+0x6]
0741  0009 0E     push cs
0742  000A E8 C6 FC  call 0xfcd3
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String1385); // These shields have extra defenses against certain foes:
            L001C: ShowRunes(player, String13BD); // Flat, Macbeth's Ilk; Shield Wall, Dragons; Guardian of Wessex and Ethelbald's Buckler, Magi; Wulfherd's, Ghosts; My Lady's Favor, Undead; Edwin's Defender, Ghosts.
            L0029: return; // RETURN;
        }

        private void Fn_30(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
076B  0003 FF 76 08  push word [bp+0x8]
076E  0006 FF 76 06  push word [bp+0x6]
0771  0009 0E     push cs
0772  000A E8 96 FC  call 0xfca3
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String1461); // These are the spell levels of headgear: 
            L001C: ShowRunes(player, String148A); // Turkish Hat, Lightning, five; Huda's Headgear, Control, eleven; Antlered Helm, True Seeing, nine; Unicorn Horn Helm, Blast, nine.
            L0029: ShowRunes(player, String150C); // Rhino Horn Helm, Death Darts, seven; Ironside's Headgear, Backfire, four; Ealstan's Cap can perform Deep Trance, Wulfherd's Helm can Read Runes.
            L0036: ShowRunes(player, String159D); // Deer Horned Helm Pursues, Spiked Helm Binds, Reindeer Horn Helm Tracks, Ivar's Helm Detects, and Alfred's Hat Picks Locks.
            L0043: return; // RETURN;
        }

        private void Fn_31(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
07B0  0003 FF 76 08  push word [bp+0x8]
07B3  0006 FF 76 06  push word [bp+0x6]
07B6  0009 0E     push cs
07B7  000A E8 51 FC  call 0xfc5e
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String1618); // These helms give extra physical or magical defense against certain foes:
            L001C: ShowRunes(player, String1661); // Ealstan's Cap, Magi; Antlered Helm, Giants; Unicorn Horn Helm, Magi; Phrygian Cap, Demi-humanoids; Alfred's Hat, Dragons; Ironside's Headgear, Giants.
            L0029: return; // RETURN;
        }

        private void Fn_33(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
07E0  0003 FF 76 08  push word [bp+0x8]
07E3  0006 FF 76 06  push word [bp+0x6]
07E6  0009 0E     push cs
07E7  000A E8 21 FC  call 0xfc2e
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String16F8); // No known armor casts spells.  Holy Vestments: Furtiveness; Wizard's Tabard Deflects Magic; Thief's Tabard: Deep Trance; Ranger's Tabard: Medic; Mendicant's Tunic: Berserker.
            L001C: return; // RETURN;
        }

        private void Fn_34(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
07FE  0003 FF 76 08  push word [bp+0x8]
0801  0006 FF 76 06  push word [bp+0x6]
0804  0009 0E     push cs
0805  000A E8 03 FC  call 0xfc10
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String17A6); // These armors have extra defenses against certain foes: 
            L001C: ShowRunes(player, String17DE); // Adamantine Plate, Magi; Holy Vestments, Non-Magi; Thief's Tabard, Undead; Ranger's Tabard, Magi; Barbarian's Tabard, Macbeth's Ilk; Disbelieving Tunic, Demi-humanoids.
            L0029: return; // RETURN;
        }

        private void Fn_35(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xD9);
            L0011: if (JumpNotEqual) goto L0076;
            L0013: ax = HasItem(player, 0xD8);
            L0021: if (JumpNotEqual) goto L0076;
            L0023: Compare(GetFlag(player, 0x03, 0x0A), 0x0001);
            L0037: if (JumpNotEqual) goto L0076;
            L0039: ShowMessage(player, String1886); // What an incredible stroke of luck!  Despite all the unfriendly things you did last time, you have stumbled upon Manannan Mac Lir's Ring!
            L0046: ShowMessage(player, String190F); // If you really believe it was just luck, I have some swampland in the Shetlands I want to sell you.
            L0053: GiveItem(player, 0xD9);
            L005F: SetFlag(player, 0x03, 0x0A, 0x02);
            L0074: goto L008F;
            L0076: Compare(GetFacing(player), 0x0003);
            L0080: if (JumpNotEqual) goto L008F;
            L0082: ShowMessage(player, String0161); // These books contain nothing of interest to you.
            L008F: return; // RETURN;
        }

        private void Fn_36(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
08BA  0003 FF 76 08  push word [bp+0x8]
08BD  0006 FF 76 06  push word [bp+0x6]
08C0  0009 0E     push cs
08C1  000A E8 59 FB  call 0xfb66
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String1972); // Succubus Pipes cast Control at level eight.
            L001C: ShowRunes(player, String199E); // Alcuin's Ring and the Holy Relic absorb more damage than any other pieces of jewelry.
            L0029: ShowRunes(player, String19F4); // Finally, Ohthere's Dagger has a power over water, but the book is charred before it says what.
            L0036: return; // RETURN;
        }

        private void Fn_37(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
08F2  0003 FF 76 08  push word [bp+0x8]
08F5  0006 FF 76 06  push word [bp+0x6]
08F8  0009 0E     push cs
08F9  000A E8 21 FB  call 0xfb2e
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String1A53); // These are the powers of gloves:  
            L001C: ShowRunes(player, String1A75); // Aldhelm's, Heal, three; Alcuin's, Energy Field, eight; 
            L0029: ShowRunes(player, String1AAD); // The Gorgon's Gauntlets are tremendously powerful weapons if wielded by one with the Martial Arts skill.  They also cast Petrify at eight and do extra damage to giants.
            L0036: ShowRunes(player, String1B55); // The Adamantine Gloves absorb the most damage, add to Martial Arts attacks, cast Resist at eight, and provide extra defense against dragons.
            L0043: return; // RETURN;
        }

        private void Fn_38(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0937  0003 FF 76 08  push word [bp+0x8]
093A  0006 FF 76 06  push word [bp+0x6]
093D  0009 0E     push cs
093E  000A E8 DC FA  call 0xfae9
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String1BE1); // Evidently, sticks are the preferred weapons of clerics, as gloves are their preferred shields.
            L001C: ShowRunes(player, String1C40); // Alcuin's Sticks See Truly at twelve and do extra damage against Non-Magi.  Menteth's Maul casts Death Darts at ten and does huge amounts of damage, while exposing the user to many counterattacks.
            L0029: return; // RETURN;
        }

        private void Fn_39(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0962  0003 FF 76 08  push word [bp+0x8]
0965  0006 FF 76 06  push word [bp+0x6]
0968  0009 0E     push cs
0969  000A E8 B1 FA  call 0xfabe
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String1D04); // Woe betide us, for no longer do items prevent paralysis!
            L001C: return; // RETURN;
        }

        private void Fn_3A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0980  0003 FF 76 08  push word [bp+0x8]
0983  0006 FF 76 06  push word [bp+0x6]
0986  0009 0E     push cs
0987  000A E8 93 FA  call 0xfaa0
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String1D3D); // These items are the best weapons of each class:  
            L001C: ShowRunes(player, String1D6F); // Claymore, Lodbrok's Blade, Banquo's Axe, Menteth's or MacDuff's Maul, Horsa's or Hilda's Hammer, Swithun's Staff, Brunanburh or Dalriadan Bow, Gorgon's Gauntlets, or Thor's Bane.
            L0029: ShowRunes(player, String1E22); // Alcuin's Cap makes a lowly wizard as powerful as a mighty barbarian.
            L0036: ShowRunes(player, String1E67); // The items listed as powerful against Macbeth's Ilk for their spells have a second power: if equipped, they make a warrior fight as many against Macbeth's Ilk!  This last is very useful.
            L0043: return; // RETURN;
        }

        private void Fn_3B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
09C5  0003 FF 76 08  push word [bp+0x8]
09C8  0006 FF 76 06  push word [bp+0x6]
09CB  0009 0E     push cs
09CC  000A E8 4E FA  call 0xfa5b
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String1F21); // Magi are wizards and clerics; non-magi are thieves, barbarians, knights, and rangers; mammals are boars, panthers, and hounds; winged creatures are harpies and bats; hybrids are medusae and minotaurs.
            L001C: ShowRunes(player, String1FEA); // Undead are vampires, skeletons, wraiths, and zombies; demi-humanoids are imps and picts; giants and golems are giants.  All for purposes of items having special effects.
            L0029: return; // RETURN;
        }

        private void Fn_3C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
09F0  0003 FF 76 08  push word [bp+0x8]
09F3  0006 FF 76 06  push word [bp+0x6]
09F6  0009 0E     push cs
09F7  000A E8 23 FA  call 0xfa30
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String2094); // You learn that ghosts are ghosts, slimes are slimes, and dragons are dragons.  Hey!  Did I promise that you'd be excited by everything you'd learn here?
            L001C: return; // RETURN;
        }

        private void Fn_3D(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
            L0003: ax = HasItem(player, 0xD9);
            L0011: if (JumpNotEqual) goto L0072;
            L0013: ax = HasItem(player, 0xD8);
            L0021: if (JumpNotEqual) goto L0072;
            L0023: RefreshCompareFlags(GetFlag(player, 0x03, 0x0A));
            L0036: if (JumpNotEqual) goto L0072;
            L0038: Compare(GetFlag(player, 0x02, 0x2F), 0x0001);
            L004C: if (JumpNotEqual) goto L0072;
            L004E: SetFlag(player, 0x03, 0x0A, 0x01);
0A6E  0063 B8 2D 21  mov ax, 0x212d
            L0066: PushStack(player, ax);
0A72  0067 C4 5E 06  les bx, [bp+0x6]
0A75  006A 26 FF 9F F8 00  call far word [es:bx+0xf8]
            L006F: goto L0182;
            L0072: PushStack(player, 0xD9);
            L0076: PushStack(player, ax);
0A82  0077 C4 5E 06  les bx, [bp+0x6]
0A85  007A 26 FF 5F 54  call far word [es:bx+0x54]
            L007E: cx = PopStack(player);
            L007F: cx = PopStack(player);
            L0080: RefreshCompareFlags(ax);
            L0082: if (JumpNotEqual) goto L0087;
            L0084: goto L0183;
            L0087: RefreshCompareFlags(GetFlag(player, 0x03, 0x0B));
            L009A: if (JumpEqual) goto L009F;
            L009C: goto L0183;
            L009F: ShowPortrait(player, 0x0016);
            L00AC: SetFlag(player, 0x03, 0x0B, 0x01);
            L00C1: SetFlag(player, 0x03, 0x09, 0x01);
            L00D6: ShowMessage(player, String2176); // *
            L00E3: ShowMessage(player, String2176); // *
            L00F0: ShowMessage(player, String2176); // *
            L00FD: ShowMessage(player, String2178); // You see an image coalesce in the middle of the room.  Standing amidst a storm-tossed sea, you again see Mannanan Mac Lir.
            L010A: ShowMessage(player, String21F2); // 'Hah!  I knew you were of sterner stuff than the last batch of bacon-brains Galatea sent.  I bring you greetings, and rewards.'
            L0117: ShowMessage(player, String2272); // 'My cousin Mider has long been denied many of the spirits those witches have had bound to this place these many decades, so we approve of her quest, and yours.'
            L0124: AddExperience(player, 0x000F4240);
            L0136: ShowMessage(player, String2313); // 'You may or may not find the weapon and shield useful.  They are but trinkets.  The dagger, however, is essential.'
            L0143: ShowMessage(player, String2387); // 'You will need it in the Kitchen, in an area where spells will fail you and skill not avail you.'
            L0150: ShowMessage(player, String23E9); // Mannanan tosses the dagger, which lands at your feet and slides behind you.
            L015D: ShowMessage(player, String2435); // 'I do not choose this enforced indirection, but as your life has rules and obligations, so does even the Sea God's.  My blessing upon you, child....'
            L016A: ShowMessage(player, String24CB); // The image fades, although the floor looks rather damper than it was.
            L0177: RemoveItem(player, 0xD9);
            L0183: return; // RETURN;
        }

        private void Fn_3E(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0B93  0003 FF 76 08  push word [bp+0x8]
0B96  0006 FF 76 06  push word [bp+0x6]
0B99  0009 0E     push cs
0B9A  000A E8 6E F8  call 0xf87b
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String2510); // Mannanan Mac Lir is the son of the god of the sea.  He controls the waters, and grants favors concerning water to those he would aid.  
            L001C: ShowRunes(player, String2598); // His spears are Yellow Shaft and Red Javelin.  His sword, The Retaliator, never fails to slay.
            L0029: return; // RETURN;
        }

        private void Fn_3F(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0BBE  0003 FF 76 08  push word [bp+0x8]
0BC1  0006 FF 76 06  push word [bp+0x6]
0BC4  0009 0E     push cs
0BC5  000A E8 43 F8  call 0xf850
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String25F6); // Lugh of the Long Spear is a god of the sun.  In battle he shines so brightly that none may look upon him, and his living spear fights by itself.  He is a master of all skills.
            L001C: return; // RETURN;
        }

        private void Fn_40(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0BDC  0003 FF 76 08  push word [bp+0x8]
0BDF  0006 FF 76 06  push word [bp+0x6]
0BE2  0009 0E     push cs
0BE3  000A E8 25 F8  call 0xf832
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String26A6); // Nuada Silverhand is a god of war and, until he lost his hand in battle, the king of the Celtic gods.  
            L001C: ShowRunes(player, String270D); // Diancecht made his silver hand, and Miach, Diancecht's son, healed the severed hand, allowing Nuada to again become king of the gods.
            L0029: return; // RETURN;
        }

        private void Fn_41(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0C07  0003 FF 76 08  push word [bp+0x8]
0C0A  0006 FF 76 06  push word [bp+0x6]
0C0D  0009 0E     push cs
0C0E  000A E8 FA F7  call 0xf807
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String2793); // Cuchulain, son of Lugh, also is a god of the sun.  He is so hot that he melts snow for thirty feet around him.  When he baths, in the sea, it boils.  His spear, the Gae Bolg, never fails to pierce its target.
            L001C: return; // RETURN;
        }

        private void Fn_42(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0C25  0003 FF 76 08  push word [bp+0x8]
0C28  0006 FF 76 06  push word [bp+0x6]
0C2B  0009 0E     push cs
0C2C  000A E8 DC F7  call 0xf7e9
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String2864); // Diancecht is a god of healing.  So long as the head is not severed or the brain or spine broken he can restore any wound.  He is the grandfather of Lugh.
            L001C: return; // RETURN;
        }

        private void Fn_43(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0C43  0003 FF 76 08  push word [bp+0x8]
0C46  0006 FF 76 06  push word [bp+0x6]
0C49  0009 0E     push cs
0C4A  000A E8 BE F7  call 0xf7cb
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String28FE); // Brigit, daughter of The Dagda, is a goddess of fire, the hearth, and poetry.  When she was born, the house burst into flames.  When her son, Ruadan, was killed, she invented 'keening.'
            L001C: return; // RETURN;
        }

        private void Fn_44(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0C61  0003 FF 76 08  push word [bp+0x8]
0C64  0006 FF 76 06  push word [bp+0x6]
0C67  0009 0E     push cs
0C68  000A E8 A0 F7  call 0xf7ad
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String29B7); // Alcuin was an English scholar from York.  He served Charlemagne in France.  Alcuin was perhaps the greatest mind of his time, and items bearing his name can be assumed to be particularly useful.
            L001C: return; // RETURN;
        }

        private void Fn_45(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0C7F  0003 FF 76 08  push word [bp+0x8]
0C82  0006 FF 76 06  push word [bp+0x6]
0C85  0009 0E     push cs
0C86  000A E8 82 F7  call 0xf78f
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String2A7A); // Oswald, Oswy, and Ecgfrith were early kings of newly united Northumbria.  At the battle of Nechtanemsmere, the Scottish Picts defeated Ecgfrith and ended Northumbria's eminence.
            L001C: return; // RETURN;
        }

        private void Fn_46(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0C9D  0003 FF 76 08  push word [bp+0x8]
0CA0  0006 FF 76 06  push word [bp+0x6]
0CA3  0009 0E     push cs
0CA4  000A E8 64 F7  call 0xf771
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String2B2C); // Streoneshalh was a holy place of old, though we now know it as Whitby Abbey.  Hilda was Streoneshalh's first Abbess.
            L001C: return; // RETURN;
        }

        private void Fn_47(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0CBB  0003 FF 76 08  push word [bp+0x8]
0CBE  0006 FF 76 06  push word [bp+0x6]
0CC1  0009 0E     push cs
0CC2  000A E8 46 F7  call 0xf753
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String2BA1); // Aldhelm was the Bishop of Sherbourne and a great musician.  He installed the first organ in England.  While in his seventies he travelled carrying a staff and a harp.
            L001C: return; // RETURN;
        }

        private void Fn_48(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0CD9  0003 FF 76 08  push word [bp+0x8]
0CDC  0006 FF 76 06  push word [bp+0x6]
0CDF  0009 0E     push cs
0CE0  000A E8 28 F7  call 0xf735
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String2C48); // Ohthere was a Norse sea captain.  A fearless sailor, he was the first civilised man recorded to have found the White Sea, as documented by King Alfred the Great.
            L001C: return; // RETURN;
        }

        private void Fn_49(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0CF7  0003 FF 76 08  push word [bp+0x8]
0CFA  0006 FF 76 06  push word [bp+0x6]
0CFD  0009 0E     push cs
0CFE  000A E8 0A F7  call 0xf717
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String2CEA); // Eadburga was Queen of Wessex.  Her husband, Beorhtric, ruled with great wisdom for sixteen years, until she realized that he favored the advice of an alderman named Warr over hers.  
            L001C: ShowRunes(player, String2DA1); // She poisoned Warr, not knowing that Beorhtric too would sip of Warr's drink, and thus killed her husband as well.
            L0029: return; // RETURN;
        }

        private void Fn_4A(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0D22  0003 FF 76 08  push word [bp+0x8]
0D25  0006 FF 76 06  push word [bp+0x6]
0D28  0009 0E     push cs
0D29  000A E8 DF F6  call 0xf6ec
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String2E13); // Alfred the Great was the finest Saxon king of England.  Outnumbered, with most of his kingdom conquered, he subdued or drove off the Danes, and eventually unified all of England.  
            L001C: ShowRunes(player, String2EC8); // He built England's first navy, ending at last the waves of invaders from the continent.
            L0029: ShowRunes(player, String2F20); // Alfred codified the laws, encouraged the arts, and was a heck of a nice guy.  Magic items bearing his name can be assumed to be fairly powerful.
            L0036: return; // RETURN;
        }

        private void Fn_4B(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0D5A  0003 FF 76 08  push word [bp+0x8]
0D5D  0006 FF 76 06  push word [bp+0x6]
0D60  0009 0E     push cs
0D61  000A E8 A7 F6  call 0xf6b4
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String2FB1); // The Dagda is the god of the earth.  His cauldron, the Undry, feeds all according to their merits, and none leave it unsatisfied.  When he plays his living harp, the seasons change.
            L001C: return; // RETURN;
        }

        private void Fn_4C(ServerPlayer player, bool isForwardMove) {
            int ax = 0, bx = 0, cx = 0, dx = 0, si = 0, di = 0, tmp = 0;
            L0000: // BEGIN;
0D78  0003 FF 76 08  push word [bp+0x8]
0D7B  0006 FF 76 06  push word [bp+0x6]
0D7E  0009 0E     push cs
0D7F  000A E8 89 F6  call 0xf696
            L000D: cx = PopStack(player);
            L000E: cx = PopStack(player);
            L000F: ShowRunes(player, String3066); // Ogma Honeymouthed is one of the sons of Dagda.  He is the god of literature and eloquence.  He is the champion of the Tuatha De' Dannan and inventor of the Ogam alphabet.
            L001C: return; // RETURN;
        }

    }
}
