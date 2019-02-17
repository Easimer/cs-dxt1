## cs-dxt1

cs-dxt1 is a DXT1 CPU decompressor for C#. This was made for texture preview thumbnail generation and artifacts may appear in the output image. Blocks are decompressed in parallel. There is built-in support for conversion to Bitmap type for convenience. This requires a reference to System.Drawing; undefine `DXT1_BITMAP` in DXT1Decompressor.cs to disable this feature.

### Usage
```cs
using DXT1Decompressor;

namespace Program
{
	class Program
	{
		static void Main(string[] args)
		{
			int width, height; // Dimensions of the input texture
			byte[] dxt1_data; // DXT1 blocks
			...
			var d = new DXT1Decompressor(width, height, dxt1_data);
			// Only available if DXT1_BITMAP is defined
			var bitmap = d.ToBitmap();
			// Raw RGB888 data
			byte[] raw_rgb888_data = d.Data;
		}
	}
}
```

### API
```cs
DXT1Decompressor.ctor(int width, int height, byte[] blob);
System.Drawing.Bitmap DXT1Decompressor.ToBitmap();
byte[] DXT1Decompressor.Data;
```

### Example
A working example can be found in Program.cs. It loads DXT1 data from uv_grid.lrf (a custom format used by the codebase this class was extracted from; a loader is provided) and converts it to BMP format.