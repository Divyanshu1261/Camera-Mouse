// Decompiled with JetBrains decompiler
// Type: d
// Assembly: Camera Mouse 2018, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 51111F1A-BEB1-4B59-82BC-FB935BB3EA9E
// Assembly location: C:\Program Files (x86)\Camera Mouse\Camera Mouse 2018\Camera Mouse 2018.exe

using CameraMouse.UserInterface;
using CameraMouse.UserInterface.Properties;
using CameraMouse.VideoCapture;
using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Security.AccessControl;
using System.Threading;
using System.Windows.Forms;

internal static class d
{
  [STAThread]
  private static void a()
  {
    Mutex mutex = (Mutex) null;
    try
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      d.a A_0 = new d.a();
      d.b(A_0);
      int num1;
      if ((num1 = d.a(A_0)) != 0)
      {
        if (num1 != 1)
          return;
        Process.Start(Assembly.GetExecutingAssembly().Location);
        return;
      }
      bool createdNew;
      mutex = new Mutex(true, "CameraMouse2Lock", out createdNew);
      if (!createdNew)
        return;
      if (!Settings.Default.IntroShown)
      {
        int num2 = (int) new StartupMsg(USBCam.FindCameraNames().Count == 0).ShowDialog();
      }
      Application.Run((Form) new MainForm());
    }
    catch (Exception ex)
    {
      // ISSUE: reference to a compiler-generated method
      int num = (int) MessageBox.Show("Fatal exception caught, quitting. " + ex.Message + "." + ex.StackTrace, e.b());
    }
    mutex?.ReleaseMutex();
  }

  public static void b(d.a A_0)
  {
    A_0.a = d.a.a.a;
    A_0.b = d.a.b.a;
    string environmentVariable = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE");
    A_0.b = string.IsNullOrEmpty(environmentVariable) || string.Compare(environmentVariable, 0, "x86", 0, 3, true) == 0 ? d.a.b.b : d.a.b.c;
    OperatingSystem osVersion = Environment.OSVersion;
    Version version = osVersion.Version;
    if (osVersion.Platform == PlatformID.Win32Windows)
    {
      switch (version.Minor)
      {
        case 0:
          A_0.a = d.a.a.b;
          break;
        case 10:
          if (version.Revision.ToString() == "2222A")
          {
            A_0.a = d.a.a.c;
            break;
          }
          A_0.a = d.a.a.d;
          break;
        case 90:
          A_0.a = d.a.a.e;
          break;
      }
    }
    else
    {
      if (osVersion.Platform != PlatformID.Win32NT)
        return;
      switch (version.Major)
      {
        case 3:
          A_0.a = d.a.a.f;
          break;
        case 4:
          A_0.a = d.a.a.g;
          break;
        case 5:
          if (version.Minor == 0)
          {
            A_0.a = d.a.a.h;
            break;
          }
          A_0.a = d.a.a.i;
          break;
        case 6:
          if (version.Minor == 0)
          {
            A_0.a = d.a.a.j;
            break;
          }
          if (version.Minor == 1)
          {
            A_0.a = d.a.a.k;
            break;
          }
          if (version.Minor == 2)
          {
            A_0.a = d.a.a.l;
            break;
          }
          if (version.Minor != 3)
            break;
          A_0.a = d.a.a.l;
          break;
        case 10:
          A_0.a = d.a.a.m;
          break;
      }
    }
  }

  public static int a(d.a A_0)
  {
    int num1 = 0;
    Graphics graphics = new Form().CreateGraphics();
    float dpiX = graphics.DpiX;
    double dpiY = (double) graphics.DpiY;
    graphics.Dispose();
    if (A_0.a == d.a.a.k || A_0.a == d.a.a.j)
    {
      string location = Assembly.GetExecutingAssembly().Location;
      string str1 = "Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Layers";
      RegistryKey currentUser = Registry.CurrentUser;
      RegistryKey registryKey = currentUser.OpenSubKey(str1, RegistryKeyPermissionCheck.ReadWriteSubTree, RegistryRights.FullControl) ?? currentUser.CreateSubKey(str1);
      if (registryKey != null)
      {
        string str2 = (string) registryKey.GetValue(location);
        string str3 = "HIGHDPIAWARE";
        if (str2 == null)
        {
          registryKey.SetValue(location, (object) str3);
          num1 = 1;
        }
        else if (!str2.Equals(str3))
        {
          registryKey.SetValue(location, (object) str3);
          num1 = 1;
        }
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        int num2 = (int) MessageBox.Show("Can't find registry key " + str1, e.b());
        num1 = 2;
      }
    }
    if ((double) dpiX > 192.0)
    {
      // ISSUE: reference to a compiler-generated method
      int num3 = (int) MessageBox.Show("The Text Size on this computer is set something other than 100% or 125%. Unfortunately Camera Mouse does not work with Text Size set to greater than 200%. To run Camera Mouse you will need to first reset the Text Size in the Control Panel to 100%,125%,150%, or 200% through Control Panel  >  Appearance and Personalization  >  Display.", e.b());
      num1 = 2;
    }
    return num1;
  }

  public class a
  {
    public d.a.a a;
    public d.a.b b;

    public enum a
    {
      a,
      b,
      c,
      d,
      e,
      f,
      g,
      h,
      i,
      j,
      k,
      l,
      m,
    }

    public enum b
    {
      a,
      b,
      c,
    }
  }
}
