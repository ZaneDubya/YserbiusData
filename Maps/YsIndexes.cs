namespace XPT.Scripts.Yserbius.Maps {
    static class YsIndexes {
        static ushort[] _Indexes = {
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

        public static int MapIndexFromGroupAndId(int grp, int id) {
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
