using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileTypeConverter
{
    public class MapReader
    {
        private ushort[] m_Tiles;
        public ushort[] Tiles { get { return m_Tiles; } }

        public MapReader(string filename, int width, int height)
        {
            int blocksX = width / 8;
            int blocksY = height / 8;

            m_Tiles = new ushort[width * height];

            BinaryReader reader = new BinaryReader(new FileStream(filename, FileMode.Open));

            for (int i = 0; i < blocksX * blocksY; i++)
            {
                reader.ReadInt32(); // get rid of header

                for (int j = 0; j < 64; j++)
                {
                    ushort tile = reader.ReadUInt16(); // read the tile
                    reader.ReadByte(); // to hell with the height!

                    int imageX = 8 * (i / blocksY) + j % 8;
                    int imageY = 8 * (i % blocksY) + j / 8;

                    m_Tiles[imageX + imageY * width] = tile; // insert the tile at its right place
                }
            }

            reader.Close();
        }
    }

    public class MapDifReader
    {
    }

    public class StaticsReader
    {
    }

    public class StaticsDifReader
    {
    }

    public class RadarColReader
    {
        private ushort[] m_Colors;
        public ushort[] Colors { get { return m_Colors; } }

        public RadarColReader(string filename)
        {
            m_Colors = new ushort[0x8000];
            BinaryReader reader = new BinaryReader(new FileStream(filename, FileMode.Open));

            for (int i = 0; i < 0x8000; i++)
                m_Colors[i] = reader.ReadUInt16();

            reader.Close();
        }
    }
}