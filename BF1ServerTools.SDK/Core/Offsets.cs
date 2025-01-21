namespace BF1ServerTools.SDK.Core;

public static class Offsets
{
    public const long OFFSET_CLIENTGAMECONTEXT = 0x1437F7758 + 0x1000;
    public const long OFFSET_GAMERENDERER = 0x1439E6D08 + 0x1000;
    public const long OFFSET_OBFUSCATIONMGR = 0x14351D058 + 0x1000;
    public const long OFFSET_DXRENDERER = 0x1439E75F8 + 0x1000;

    ////////////////////////////////////////////////////////////////////

    public const int Offset_ServerName = 0x35146F0;
    public const int Offset_ServerId = 0x37FF1A0;

    public const int Offset_ServerTime = 0x3A31138;
    public const int Offset_ServerScore = 0x3A0FC40;
}
