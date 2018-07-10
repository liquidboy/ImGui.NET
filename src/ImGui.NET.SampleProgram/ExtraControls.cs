using System;
using System.Collections.Generic;
using System.Text;

namespace JF.UI
{
  public static partial class Controls
  {
    public static int IM_COL32_R_SHIFT = 0;
    public static int IM_COL32_G_SHIFT = 8;
    public static int IM_COL32_B_SHIFT = 16;
    public static int IM_COL32_A_SHIFT = 24;
    public static uint IM_COL32_A_MASK = 0xFF000000;

    //public static uint IM_COL32(byte R, byte G, byte B, byte A) {
    //  return (((uint)(A) << IM_COL32_A_SHIFT) | ((uint)(B) << IM_COL32_B_SHIFT) | ((uint)(G) << IM_COL32_G_SHIFT) | ((uint)(R) << IM_COL32_R_SHIFT));
    //}
    public static uint IM_COL32(int R, int G, int B, int A) => (uint)(((A) << IM_COL32_A_SHIFT) | ((B) << IM_COL32_B_SHIFT) | ((G) << IM_COL32_G_SHIFT) | ((R) << IM_COL32_R_SHIFT));
    public static uint IM_COL32_WHITE = IM_COL32(255,255,255,255);    // Opaque white = 0xFFFFFFFF
    public static uint IM_COL32_BLACK = IM_COL32(0, 0, 0, 255);       // Opaque black
    public static uint IM_COL32_BLACK_TRANS = IM_COL32(0, 0, 0, 0);   // Transparent black = 0x00000000
  }
}
