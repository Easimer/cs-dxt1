using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXT1Decompressor
{
    class Program
    {
        static void Main(string[] args)
        {
            var tex = LRFReader.LoadTexture("uv_grid.lrf");
            var d = new DXT1Decompressor((int)tex.width, (int)tex.height, tex.data);
            var bitmap = d.ToBitmap();
            bitmap.Save("uv_grid.bmp");
        }
    }
}
