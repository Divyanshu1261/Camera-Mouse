// Decompiled with JetBrains decompiler
// Type: DotfuscatorAttribute
// Assembly: Camera Mouse 2018, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 51111F1A-BEB1-4B59-82BC-FB935BB3EA9E
// Assembly location: C:\Program Files (x86)\Camera Mouse\Camera Mouse 2018\Camera Mouse 2018.exe

using System;
using System.Runtime.InteropServices;

[ComVisible(false)]
[AttributeUsage(AttributeTargets.Assembly)]
public sealed class DotfuscatorAttribute : Attribute
{
  private string a;
  private int c;

  public DotfuscatorAttribute(string a, int c)
  {
    DotfuscatorAttribute dotfuscatorAttribute = this;
    // ISSUE: explicit constructor call
    dotfuscatorAttribute.\u002Ector();
    dotfuscatorAttribute.a = a;
    this.c = c;
  }

  public string A => this.a;

  public string a() => this.a;

  public int C => this.c;

  public int c() => this.c;
}
