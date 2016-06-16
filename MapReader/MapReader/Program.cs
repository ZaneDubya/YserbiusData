using System.Collections.Generic;
using System.IO;

namespace MapReader {
    internal class Program {
        const string pathToResourceFile = @"..\..\..\..\Data\Resource.035";
        const string pathForMaps = @"..\..\..\..\Maps\";

        public static Dictionary<int, int> ValueCount = new Dictionary<int, int>();

        private static void Main(string[] args) {
            Directory.CreateDirectory(pathForMaps);
            BinaryReader reader = new BinaryReader(new FileStream(pathToResourceFile, FileMode.Open, FileAccess.Read));
            for (int i = 0; i < 34; i++) {
                Map map = new Map(reader);
                map.OutputAsPng($"{pathForMaps}{i:D2}");
            }
        }
    }
}
