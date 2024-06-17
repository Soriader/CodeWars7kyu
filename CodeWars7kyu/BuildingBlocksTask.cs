using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars7kyu
{
    public class BuildingBlocksTask
    {
        public int Width { get; private set; }
        public int Length { get; private set; }
        public int Height { get; private set; }

        public BuildingBlocksTask(int[] properties)
        {
            this.Width = properties[0];
            this.Length = properties[1];
            this.Height = properties[2];
        }

        public int GetWidth() { return Width; }

        public int GetLength() { return Length; }

        public int GetHeight() { return Height; }

        public int GetVolume() { return GetWidth() * GetHeight() * GetLength(); }

        public int GetSurfaceArea()
        {
            return (2 * GetLength() * GetWidth())
                   + (2 * GetLength() * GetHeight())
                   + (2 * GetWidth() * GetHeight());
        }
    }
}
//https://www.codewars.com/kata/55b75fcf67e558d3750000a3/train/csharp