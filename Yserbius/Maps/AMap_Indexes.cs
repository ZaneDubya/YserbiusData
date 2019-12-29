namespace XPT.Legacy.Maps {
    public abstract partial class AMap {

        // === Items =================================================================================================
        // ===========================================================================================================

        public const byte ItemKingCleowynsLockpick = 0xD2;
        public const byte ItemKingCleowynsKey = 0xD3;
        public const byte ItemSunbeamKey = 0xD4;
        public const byte ItemDwarfMineKey = 0xD5;
        public const byte ItemCyclopsMineKey = 0xD6;
        public const byte ItemHiddenMineKey = 0xD7;
        public const byte ItemElfinCaveKey = 0xD8;
        public const byte ItemKeyToCleowynsPalace = 0xD9;
        public const byte ItemRuneVowelKeyO = 0xDA;
        public const byte ItemRuneVowelKeyE = 0xDB;
        public const byte ItemRuneVowelKeyI = 0xDC;
        public const byte ItemWindKnightsKey = 0xDD;
        public const byte ItemThiefsLabyrinthKey = 0xDE; // never used???
        public const byte ItemVorantisKey = 0xDF;
        public const byte ItemKeyToBackAlley = 0xE0;
        public const byte ItemKingsDomicileKey = 0xE1;
        public const byte ItemLavaKey = 0xE2;
        public const byte ItemCleowynsSceptre = 0xE3;
        public const byte ItemAutumnSeeds = 0xE4;
        public const byte ItemWinterWaters = 0xE5;
        public const byte ItemHarvestHorn = 0xE6;
        public const byte ItemSpringRenewal = 0xE7;
        public const byte ItemSummerRadiance = 0xE8;
        public const byte ItemNaturesRobe = 0xE9;
        public const byte ItemJackOfSpades = 0xEA;
        public const byte ItemQueenOfSpades = 0xEB;
        public const byte ItemKingOfSpades = 0xEC;
        public const byte ItemAceOfSpades = 0xED;
        public const byte ItemChessPiece = 0xEE;
        public const byte ItemBlueMetal = 0xEF;
        public const byte ItemFlexMetal = 0xF0;
        public const byte ItemCyclopsHead = 0xF1;
        public const byte ItemMoonPrism = 0xF2;
        public const byte ItemGoldenBoat = 0xF3;
        public const byte ItemRanbowGemRed = 0xF4;
        public const byte ItemRanbowGemYellow = 0xF5;
        public const byte ItemRanbowGemGreen = 0xF6;
        public const byte ItemRanbowGemBlue = 0xF7;
        public const byte ItemKingsRing = 0xF8;
        public const byte ItemKingsPass = 0xF9;
        public const byte ItemCleowynsBones = 0xFA;
        public const byte ItemThievesKey = 0xFB;
        public const byte ItemLavaGlove = 0xFC; // never used???

        // === Map Flags =============================================================================================
        // ===========================================================================================================
        public const byte FlagVestibuleUnlockType = 0x00;
        // unused flag 0x01
        public const byte FlagMinesFound100Gold = 0x02;
        public const byte FlagMinesFoundRoguesGold = 0x03;
        public const byte FlagMinesFoundAxe = 0x04;
        public const byte FlagVestibuleFoundCoins = 0x05;
        public const byte FlagHallOfDoorsFoundSwords = 0x06;
        public const byte FlagHallOfDoorsFoundGold = 0x07;
        public const byte FlagHallOfDoorsFoundOgreItems = 0x08;
        public const byte FlagTreasuryKingsGold = 0x09;
        public const byte FlagTreasuryKingsGold2 = 0x0A;
        public const byte FlagTreasuryKingsGold3 = 0x0B;
        public const byte FlagSoldiersQuartersOgreGold = 0x0C;
        public const byte FlagSoldiersQuartersLionGold = 0x0D;
        public const byte FlagSoldiersQuartersScorpionGold = 0x0E;
        public const byte FlagSoldiersQuartersImpGold = 0x0F;
        public const byte FlagSoldiersQuartersSkeletonGold = 0x10;
        public const byte FlagSoldiersQuartersSnakeGold = 0x11;
        public const byte FlagTreasuryWeapons = 0x12;
        public const byte FlagTreasuryWeapons2 = 0x13;
        public const byte FlagTreasuryKingsGold4 = 0x14;
        public const byte FlagTreasuryKingsGold5 = 0x15;
        public const byte FlagBasementGold = 0x16;
        public const byte FlagBasementGold1 = 0x17;
        public const byte FlagSecretRoom1Gold = 0x18;
        public const byte FlagSecretRoom2Gold = 0x19;
        public const byte FlagSecretRoom2Gold1 = 0x1A;
        public const byte FlagSecretRoom2Gold2 = 0x1B;
        public const byte FlagSecretRoom3Gold = 0x1C;
        public const byte FlagSecretRoom3Gold2 = 0x1D;
        public const byte FlagBasementFountain = 0x1E;
        public const byte FlagRuneRoomGold = 0x1F;
        public const byte FlagRuneRoomGold1 = 0x20;
        public const byte FlagRuneRoomGold2 = 0x21;
        public const byte FlagGreatCorridorHarmony = 0x22;
        public const byte FlagGreatCorridorChaos = 0x23;
        public const byte FlagGreatCorridorGold = 0x24;
        public const byte FlagGreatCorridorWeapon = 0x25;
        public const byte FlagGreatCorridorWeapon2 = 0x26;
        // unused flag 0x27
        public const byte FlagGreatCorridorItem = 0x28;
        public const byte FlagGreatCorridorGold1 = 0x29;
        public const byte FlagGreatCorridorItem1 = 0x2A;
        public const byte FlagGreatCorridorGold2 = 0x2B;
        public const byte FlagMausoleumGold = 0x2C;
        public const byte FlagMausoleumGold1 = 0x2D;
        public const byte FlagGreatCorridorGaveKingsPassToGuard = 0x2E;
        public const byte FlagModAttr_HumanThief = 0x2f;
        public const byte FlagModAttr_OrcCleric = 0x30;
        public const byte FlagModAttr_ElfBarb = 0x31;
        public const byte FlagModAttr_TrollRanger = 0x32;
        public const byte FlagModAttr_DwarfKnight = 0x33;
        public const byte FlagModAttr_GnomeWizard = 0x34;
        public const byte FlagModAttr_HalflingKeyCleo = 0x35;
        public const byte FlagModAttr_GremlinPickCleo = 0x36;
        public const byte FlagMausoleumCryptState = 0x37; // 0 = never opened, 1 = opened, 2 = opened and placed bones within
        public const byte FlagKingsDomicileGold = 0x38;
        public const byte FlagKingsDomicileGold1 = 0x39;
        // unused flag 0x3A
        public const byte FlagLavaCellarGold = 0x3B;
        public const byte FlagLavaCellarGold1 = 0x3C;
        public const byte FlagPitBottomFountainRestoration = 0x3D;
        public const byte FlagThievesDenTreasure = 0x3E;
        public const byte FlagThievesDenTreasure1 = 0x3F;
        // unused flag 0x40
        public const byte FlagThievesDenTreasure2 = 0x41;
        public const byte FlagThievesDenTreasure3 = 0x42;
        public const byte FlagThievesDenTreasure4 = 0x43;
        public const byte FlagThievesDenExperience = 0x44;
        public const byte FlagThievesDenTeachBarding = 0x45;
        public const byte FlagLabyrinthIIMoonPrism = 0x46;
        public const byte FlagLabyrinthIIRangerSpear = 0x47;
        public const byte FlagLabyrinthIIHolyHalberd = 0x48;
        public const byte FlagSpellingChallengeProgress = 0x49;
        public const byte FlagModAttr_TrollFountain = 0x4A;
        public const byte FlagLabryinthIIIMyMyFountain = 0x4B;
        // unused flag 0x4C
        // unused flag 0x4D
        // unused flag 0x4E
        // unused flag 0x4F
        // unused flag 0x50
        public const byte FlagLabyrinthISiroccoDoorUnlocked = 0x51;
        public const byte FlagWizardRoomArnakkian = 0x52;
        public const byte FlagWizardRoomEnLiKil = 0x53;
        // unused flag 0x54
        // unused flag 0x55
        public const byte FlagModAttr_FountainOfAttr = 0x56;
        public const byte FlagLabyrinthICastleGateTeleport = 0x57;
        public const byte FlagModAttr_WynFountain = 0x58;
        public const byte FlagLabryinthITeachSkill = 0x59;
        public const byte FlagModAttr_Map24Ini = 0x5A;
        public const byte FlagModAttr_Map24Agi = 0x5B;
        public const byte FlagModAttr_Map24Str = 0x5C;
        public const byte FlagModAttr_Map24Def = 0x5D;
        public const byte FlagModAttr_Map26Dex = 0x5E;
        public const byte FlagLabryinthIVTeachSkill = 0x5F;
        public const byte FlagLabryinthIVTeachSkill1 = 0x60;
        public const byte FlagLabryinthIIITeachSkill = 0x61;
        public const byte FlagLabryinthIIITeachSkill1 = 0x62;
        public const byte FlagLabryinthITeachSkill1 = 0x63;
        public const byte FlagThievesDenTeachDetect = 0x64;
        public const byte FlagThievesDenTeachLockpick = 0x65;
        // unused flag 0x66
        public const byte FlagMausoleumItems = 0x67;
        public const byte FlagThievesDenSinestraFountain = 0x68;
        public const byte FlagReceivedEnLiKilExperience = 0x69;
        public const byte FlagDefeatedEnLiKil = 0x6A;
        public const byte FlagMinerReward = 0x6B;
        public const byte FlagUsedItemD4ToOpenDwarfDoor = 0x6C;
        public const byte FlagUsedDwarfMineKey = 0x6D;
        public const byte FlagUsedCyclopsMineKey = 0x6E;
        public const byte FlagUsedHiddenMineKey = 0x6F;
        // unused flag 0x70
        // unused flag 0x71
        // unused flag 0x72
        // unused flag 0x73
        // unused flag 0x74
        // unused flag 0x75
        // unused flag 0x76
        public const byte FlagKilledEnLiKilThisTime = 0x77;
        public const byte FlagUnlockedLabyrinthDoor = 0x78;
        public const byte FlagGaveHarvestHorn = 0x79;
        public const byte FlagTreeSkills = 0x7A;
        public const byte FlagUnknownSwitch1 = 0x7B;
        public const byte FlagUnknownSwitch2 = 0x7C;
        public const byte FlagUnknownSwitch3 = 0x7D;
        public const byte FlagModAttr_BlackjackFountain = 0x7E;
        public const byte FlagModAttr_CribbageFountain = 0x7F;
        public const byte FlagRiversEndRainbowRed = 0x80;
        public const byte FlagRiversEndRainbowYellow = 0x81;
        public const byte FlagRiversEndRainbowGreen = 0x82;
        public const byte FlagRiversEndRainbowBlue = 0x83;
        public const byte FlagModAttr_DragonBreathFountain = 0x84;
        public const byte FlagLabryinthIVPhoenixReborn1 = 0x85;
        public const byte FlagLabryinthIVPhoenixReborn = 0x86;
        public const byte FlagMedievaLandsCastleParapetsBridge = 0x87;
        public const byte FlagCastleParapetsGuardiansExperience = 0x88;
        public const byte FlagWizardRoomArnikkanExperience = 0x89;
        public const byte FlagCastleParapetsAndreasExperience = 0x8A;
        public const byte FlagWizardRoomTreasure3 = 0x8B;
        public const byte FlagWizardRoomTreasure2 = 0x8C;
        public const byte FlagWizardRoomTreasure1 = 0x8D;
        public const byte FlagWizardRoomTreasure = 0x8E;
        public const byte FlagKingCleown25kExp = 0x8F;

        static readonly ushort[] _Indexes = {
            0x0101, 0000, // L1: Dungeon Entrance - names are from Strings.DarkSTRT.EXE.csv, starting with index 445
            0x0102, 0001, // L1: The Mines
            0x0103, 0002, // L1: Vestibule
            0x0104, 0003, // L1: Hall Of Doors
            0x0105, 0004, // L1: Treasury
            0x0106, 0005, // L1: Soldier's Quarters
            0x0201, 0006, // L2: Basement
            0x0202, 0007, // L2: Palace Corridor
            0x0203, 0008, // L2: Secret Room (1)
            0x0204, 0009, // L2: Secret Room (2)
            0x0205, 0010, // L2: Secret Room (3)
            0x0206, 0011, // L2: Cleowyn's Palace 
            0x0301, 0012, // L3: Rune Room
            0x0302, 0013, // L3: Prison
            0x0303, 0014, // L3: Great Corridor
            0x0304, 0015, // L3: Mausoleum
            0x0401, 0016, // L4: King's Domicile
            0x0501, 0017, // L5: Thieves' Den
            0x0502, 0018, // L5: Lava Cellar
            0x0503, 0019, // L5: Pit Bottom
            0x3301, 0020, // L6: Labyrinth I
            0x3302, 0021, // L6: Castle Parapets
            0x3401, 0022, // L7: Labyrinth II
            0x3402, 0023, // L7: Castle Wizard Room
            0x3501, 0024, // L8: Labyrinth III
            0x3502, 0025, // L8: Castle Great Hall
            0x3601, 0026, // L9: Labyrinth IV
            0x3602, 0027, // L9: Arnakkian's Arena
            0x3701, 0028, // L10: Elf Villages
            0x3801, 0029, // L11: Dwarf Kingdom
            0x3802, 0030, // L11: Land Of Giants
            0x3803, 0031, // L11: River's End
            0x3804, 0032, // L11: Island Of Eternity
            0x3901, 0033, // L12: The Unknown
        };

        protected int MapIndexFromGroupAndId(int grp, int id) {
            ushort mapid = (ushort)(((grp & 0xff) << 8) + (id & 0xff));
            int count = _Indexes.Length / 2;
            for (int i = 0; i < count; i++) {
                if (mapid == _Indexes[i * 2]) {
                    return _Indexes[i * 2 + 1];
                }
            }
            return 0; // dungeon entrance
        }
    }
}
