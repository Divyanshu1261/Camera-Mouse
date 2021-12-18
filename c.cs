// Decompiled with JetBrains decompiler
// Type: c
// Assembly: Camera Mouse 2018, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 51111F1A-BEB1-4B59-82BC-FB935BB3EA9E
// Assembly location: C:\Program Files (x86)\Camera Mouse\Camera Mouse 2018\Camera Mouse 2018.exe

using CameraMouse.UserInterface;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;

internal class c
{
  private static global::c.a a = new global::c.a(global::c.a);
  private static IntPtr b = IntPtr.Zero;
  private static CameraMouseConfig c;
  private static MainForm d;
  private static Mutex e;
  private static bool f;
  private const int g = 14;

  [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
  private static extern IntPtr SetWindowsHookEx(int A_0, global::c.a A_1, IntPtr A_2, uint A_3);

  [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
  [return: MarshalAs(UnmanagedType.Bool)]
  private static extern bool UnhookWindowsHookEx(IntPtr A_0);

  [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
  private static extern IntPtr CallNextHookEx(IntPtr A_0, int A_1, IntPtr A_2, IntPtr A_3);

  [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
  private static extern IntPtr GetModuleHandle(string A_0);

  public static void a(MainForm A_0, CameraMouseConfig A_1)
  {
    global::c.b = global::c.a(global::c.a);
    global::c.d = A_0;
    global::c.c = A_1;
    global::c.e = new Mutex();
    global::c.f = false;
  }

  [SpecialName]
  public static bool a()
  {
    global::c.e.WaitOne();
    int num = global::c.f ? 1 : 0;
    global::c.e.ReleaseMutex();
    return num != 0;
  }

  [SpecialName]
  public static void a(bool A_0)
  {
    global::c.e.WaitOne();
    global::c.f = A_0;
    global::c.e.ReleaseMutex();
  }

  private static IntPtr a(global::c.a A_0)
  {
    using (Process currentProcess = Process.GetCurrentProcess())
    {
      using (currentProcess.MainModule)
      {
        IntPtr num = global::c.SetWindowsHookEx(14, A_0, global::c.GetModuleHandle("user32"), 0U);
        return !(num == IntPtr.Zero) ? num : throw new Win32Exception();
      }
    }
  }

  private static IntPtr a(int A_0, IntPtr A_1, IntPtr A_2)
  {
    int num = (int) A_1;
    global::c.d structure = (global::c.d) Marshal.PtrToStructure(A_2, typeof (global::c.d));
    if (A_0 >= 0 && 513 == (int) A_1 && !global::c.a() && global::c.c.ClickStop && global::c.d.ControlCursor)
      global::c.d.ControlCursor = false;
    return global::c.CallNextHookEx(global::c.b, A_0, A_1, A_2);
  }

  private delegate IntPtr a(int A_0, IntPtr A_1, IntPtr A_2);

  private enum b
  {
    c = 512, // 0x00000200
    a = 513, // 0x00000201
    b = 514, // 0x00000202
    e = 516, // 0x00000204
    f = 517, // 0x00000205
    d = 522, // 0x0000020A
  }

  private struct c
  {
    public int a;
    public int b;
  }

  private struct d
  {
    public global::c.c a;
    public uint b;
    public uint c;
    public uint d;
    public IntPtr e;
  }
}
