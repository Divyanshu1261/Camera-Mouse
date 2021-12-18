// Decompiled with JetBrains decompiler
// Type: e
// Assembly: Camera Mouse 2018, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 51111F1A-BEB1-4B59-82BC-FB935BB3EA9E
// Assembly location: C:\Program Files (x86)\Camera Mouse\Camera Mouse 2018\Camera Mouse 2018.exe

using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
internal class e
{
  private static ResourceManager a;
  private static CultureInfo b;

  internal e()
  {
  }

  [SpecialName]
  internal static ResourceManager f()
  {
    // ISSUE: reference to a compiler-generated field
    if (global::e.a == null)
    {
      // ISSUE: reference to a compiler-generated field
      global::e.a = new ResourceManager(nameof (e), typeof (global::e).Assembly);
    }
    // ISSUE: reference to a compiler-generated field
    return global::e.a;
  }

  [SpecialName]
  internal static CultureInfo e() => global::e.b;

  [SpecialName]
  internal static void a(CultureInfo A_0) => global::e.b = A_0;

  [SpecialName]
  internal static string d() => global::e.f().GetString("ManualFileName", global::e.b);

  [SpecialName]
  internal static string c() => global::e.f().GetString("MessageLostTrackpoint", global::e.b);

  [SpecialName]
  internal static string b() => global::e.f().GetString("ProductName", global::e.b);

  [SpecialName]
  internal static string a() => global::e.f().GetString("ProductVersion", global::e.b);
}
