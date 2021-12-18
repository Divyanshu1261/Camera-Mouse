// Decompiled with JetBrains decompiler
// Type: a
// Assembly: Camera Mouse 2018, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 51111F1A-BEB1-4B59-82BC-FB935BB3EA9E
// Assembly location: C:\Program Files (x86)\Camera Mouse\Camera Mouse 2018\Camera Mouse 2018.exe

using System.Runtime.InteropServices;

internal class a
{
  private const uint a = 1;
  private const uint b = 2;

  [DllImport("user32.dll")]
  private static extern short GetKeyState(int A_0);

  [DllImport("user32.dll")]
  private static extern void keybd_event(byte A_0, byte A_1, uint A_2, uint A_3);

  public static bool a(global::a.a A_0) => global::a.GetKeyState((int) A_0) < (short) 0;

  public static void a(global::a.a A_0, bool A_1)
  {
    if (A_1 == global::a.a(A_0))
      return;
    global::a.keybd_event((byte) A_0, (byte) 69, 1U, 0U);
    global::a.keybd_event((byte) A_0, (byte) 69, 3U, 0U);
  }

  public enum a : byte
  {
    c = 17, // 0x11
    d = 18, // 0x12
    b = 20, // 0x14
    e = 112, // 0x70
    i = 113, // 0x71
    j = 114, // 0x72
    k = 115, // 0x73
    l = 116, // 0x74
    m = 117, // 0x75
    n = 118, // 0x76
    o = 119, // 0x77
    p = 120, // 0x78
    f = 121, // 0x79
    g = 122, // 0x7A
    h = 123, // 0x7B
    a = 144, // 0x90
  }
}
