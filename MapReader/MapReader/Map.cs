using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MapReader {
    internal class Map {
        public readonly Tile[] Tiles;
        public readonly List<Tuple<int, string>> Labels;

        public Map(BinaryReader reader) {
            // Create tiles
            Tiles = new Tile[256];
            for (int i = 0; i < 256; i++)
                Tiles[i] = new Tile();
            long position = reader.BaseStream.Position;
            // header: 3b + 13b padding; data is always 0x01 followed by two identical values, 0x01-0x05.
            byte[] header = reader.ReadBytes(16);
            // planes: 13 16x16 arrays; 0 == walls, 1 = n doors, 2 = e doors, 3 = s doors, 4 = w doors, possibly decos and event indexes?
            byte[] plane = new byte[256];
            for (int i = 0; i < 13; i++) {
                reader.Read(plane, 0, 256);
                for (int j = 0; j < 256; j++)
                    Tiles[j].Data[i] = plane[j];
            }
            // labels: not sure how these are used. could be map editor debris, could be used for events.
            Labels = new List<Tuple<int, string>>();
            for (int i = 0; i < 256; i++) {
                byte labelLength = reader.ReadByte();
                if (labelLength == 0)
                    reader.BaseStream.Position += 11;
                else {
                    byte[] data = reader.ReadBytes(labelLength);
                    string str = Encoding.ASCII.GetString(data);
                    Labels.Add(new Tuple<int, string>(i, str));
                    reader.BaseStream.Position += 12 - labelLength - 1;
                }
            }
            reader.BaseStream.Position = position + 6416;
        }

        public void OutputAsPng(string path) {
            int tilesize = 32;
            
            // draw doors and (I assume) exit events.
            using (Bitmap bmp = new Bitmap(16 * tilesize + 196, 16 * tilesize)) {
                DrawMap(bmp, tilesize, DrawExitEvents);
                bmp.Save(path + "-exits.png", ImageFormat.Png);
            }
            // draw extra codes
            using (Bitmap bmp = new Bitmap(16 * tilesize + 196, 16 * tilesize))
            {
                DrawMap(bmp, tilesize, DrawExtraCodes);
                bmp.Save(path + "-events.png", ImageFormat.Png);
            }
        }

        private void DrawMap(Bitmap bmp, int tilesize, Action<Graphics, Font, Brush, int, int, int, int, int> drawMethod) {
            int doorSize = tilesize / 8;
            Font fontEvents = new Font(FontFamily.GenericMonospace, 6);
            Font fontLabels = new Font(FontFamily.GenericSansSerif, 7);
            Brush brush = new SolidBrush(Color.Black);
            Pen wallPen0 = new Pen(Color.Black);
            Pen wallPen1 = new Pen(Color.White);
            Brush checkerBrush = new SolidBrush(Color.FromArgb(0xa0, 0xa0, 0xa0));
            Brush[] floorBrushes = {
                new SolidBrush(Color.FromArgb(0x50, 0x50, 0x50)), new SolidBrush(Color.FromArgb(0xC0, 0x20, 0x20)),
                new SolidBrush(Color.DodgerBlue), new SolidBrush(Color.Green)
            };
            byte[] doorValues = {1, 2, 3, 4};
            Pen[] doorPens = {new Pen(Color.BurlyWood), new Pen(Color.Orange), new Pen(Color.MediumPurple), new Pen(Color.SaddleBrown)};
            using (Graphics graphics = Graphics.FromImage(bmp)) {
                graphics.Clear(Color.DarkGray);
                for (int i = 0; i < 256; i++) {
                    int x0 = (i % 16) * tilesize;
                    int x1 = x0 + tilesize - 1;
                    int y0 = (i / 16) * tilesize;
                    int y1 = y0 + tilesize - 1;
                    if ((i + i / 16) % 2 == 1)
                        graphics.FillRectangle(checkerBrush, x0, y0, x1 - x0, y1 - y0);
                    if (Tiles[i].Data[11] != 0) {
                        byte floor = Tiles[i].Data[11];
                        if (floor == 1) {
                            // pit 
                            graphics.FillRectangle(floorBrushes[0], x0, y0, x1 - x0 + 1, y1 - y0 + 1);
                        }
                        else if (floor == 2) {
                            // lava!
                            graphics.FillRectangle(floorBrushes[1], x0, y0, x1 - x0 + 1, y1 - y0 + 1);
                        }
                        else if (floor == 3) {
                            // water...
                            graphics.FillRectangle(floorBrushes[2], x0, y0, x1 - x0 + 1, y1 - y0 + 1);
                        }
                        else if (floor == 4)
                        {
                            // fountain!
                            graphics.FillEllipse(floorBrushes[2], x0 + doorSize * 1.5f, y0 + doorSize * 1.5f, x1 - x0 - doorSize * 2 * 1.5f, y1 - y0 - doorSize * 2 * 1.5f);
                        }
                        else if (floor == 6) {
                            // column!
                            graphics.FillEllipse(floorBrushes[0], x0 + doorSize * 1.5f, y0 + doorSize * 1.5f, x1 - x0 - doorSize * 2 * 1.5f, y1 - y0 - doorSize * 2 * 1.5f);
                        }
                        else {
                            // ???
                            graphics.FillRectangle(floorBrushes[3], x0, y0, x1 - x0 + 1, y1 - y0 + 1);
                        }
                    }
                    byte walls = Tiles[i].Data[0];
                    DrawWall(graphics, x0, y0, x0, y1, walls, 0x01, 0x02, wallPen0, wallPen1);
                    DrawWall(graphics, x0, y1, x1, y1, walls, 0x04, 0x08, wallPen0, wallPen1);
                    DrawWall(graphics, x1, y0, x1, y1, walls, 0x10, 0x20, wallPen0, wallPen1);
                    DrawWall(graphics, x0, y0, x1, y0, walls, 0x40, 0x80, wallPen0, wallPen1);
                    DrawDoor(graphics, x0 + doorSize, y0, x1 - doorSize, y0, Tiles[i].Data[1], doorValues, doorPens); // n doors
                    DrawDoor(graphics, x1, y0 + doorSize, x1, y1 - doorSize, Tiles[i].Data[2], doorValues, doorPens); // e doors
                    DrawDoor(graphics, x0 + doorSize, y1, x1 - doorSize, y1, Tiles[i].Data[3], doorValues, doorPens); // s doors
                    DrawDoor(graphics, x0, y0 + doorSize, x0, y1 - doorSize, Tiles[i].Data[4], doorValues, doorPens); // w doors
                    drawMethod(graphics, fontEvents, brush, i, x0, x1, y0, y1);
                }
                for (int i = 0; i < Labels.Count; i++) {
                    int x = tilesize * 16 + 8 + (i / 42) * 96;
                    int y = (i % 42) * 12 + 4;
                    graphics.DrawString($"{Labels[i].Item1:X2} {Labels[i].Item2}", fontLabels, brush, new PointF(x, y));
                }
            }
        }

        private void DrawExitEvents(Graphics graphics, Font font, Brush brush, int i, int x0, int x1, int y0, int y1)
        {
            if (Tiles[i].Data[5] != 0)
                graphics.DrawString($"{Tiles[i].Data[5]:X2}", font, brush, new PointF(x0 + 10, y0 + 1));
            if (Tiles[i].Data[6] != 0)
                graphics.DrawString($"{Tiles[i].Data[6]:X2}", font, brush, new PointF(x1 - 14, y0 + 10));
            if (Tiles[i].Data[7] != 0)
                graphics.DrawString($"{Tiles[i].Data[7]:X2}", font, brush, new PointF(x0 + 10, y1 - 9));
            if (Tiles[i].Data[8] != 0)
                graphics.DrawString($"{Tiles[i].Data[8]:X2}", font, brush, new PointF(x0 + 1, y0 + 10));
        }

        private void DrawExtraCodes(Graphics graphics, Font font, Brush brush, int i, int x0, int x1, int y0, int y1)
        {
            // event scripts
            if (Tiles[i].Data[9] != 0)
                graphics.DrawString($"{Tiles[i].Data[9]:X2}", font, brush, new PointF(x0 + 2, y0 + 2));
            // encounter scripts
            if (Tiles[i].Data[10] != 0)
                graphics.DrawString($"{Tiles[i].Data[10]:X2}", font, brush, new PointF(x0 + 17, y0 + 2));
            // floors
            /*if (Tiles[i].Data[11] != 0)
                graphics.DrawString($"{Tiles[i].Data[11]:X2}", font, brush, new PointF(x0 + 2, y0 + 19));*/
            // ??????
            if (Tiles[i].Data[12] != 0x10)
                graphics.DrawString($"{Tiles[i].Data[12]:X2}", font, brush, new PointF(x0 + 17, y0 + 19));

            if (Program.ValueCount.ContainsKey(Tiles[i].Data[12]))
                Program.ValueCount[Tiles[i].Data[12]] = Program.ValueCount[Tiles[i].Data[12]] + 1;
            else
                Program.ValueCount[Tiles[i].Data[12]] = 1;
        }

        private void DrawDoor(Graphics graphics, int x0, int y0, int x1, int y1, byte value, byte[] draws, Pen[] pens) {
            for (int i = 0; i < draws.Length; i++)
                if (value == draws[i])
                    graphics.DrawLine(pens[i], x0, y0, x1, y1);
        }

        private void DrawWall(Graphics graphics, int x0, int y0, int x1, int y1, byte value, byte flag0, byte flag1, Pen pen0, Pen pen1) {
            if ((value & (flag0 | flag1)) == (flag0 | flag1)) {
                int xoffset = (x1 - x0) / 2;
                int yoffset = (y1 - y0) / 2;
                graphics.DrawLine(pen0, x0, y0, x0 + xoffset, y0 + yoffset);
                graphics.DrawLine(pen1, x0 + xoffset, y0 + yoffset, x1, y1);
            }
            else if ((value & flag0) == flag0) {
                graphics.DrawLine(pen0, x0, y0, x1, y1);
            }
            else if ((value & flag1) == flag1) {
                graphics.DrawLine(pen1, x0, y0, x1, y1);
            }
        }
    }
}
