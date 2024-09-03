using System;
using System.Runtime.InteropServices;

internal static class Form2Helpers
{

    [DllImport("Winmm.dll")]
    public static extern int waveSetVolume(IntPtr hwo, uint dwVolume);

    [DllImport("Winmm.dll")]
    private static extern int waveGetVolume(IntPtr hwo, out uint dwVolume);
}