using System;
using System.Windows.Media;
using System.Collections.Generic;

namespace LED_Control.Services
{
    internal static class ColorService
    {
        private static readonly Dictionary<byte, byte> ColorByte = new()
        {
            { 0, 0 },
            { 80, 1 },
            { 160, 2 },
            { 255, 3 },
        };

        public static byte ConvertColorToByte(this Color color)
        {
            try
            {
                ColorByte.TryGetValue(color.R, out byte redIndex);
                ColorByte.TryGetValue(color.G, out byte greenIndex);
                ColorByte.TryGetValue(color.B, out byte blueIndex);

                var result = (redIndex & 3) + ((greenIndex & 3) << 2) + ((blueIndex & 3) << 4);

                return (byte)(128 + result);
            }
            catch
            {
                throw new ArgumentOutOfRangeException("Error. Check the selected color.");
            }
        }
    }
}
