// Decompiled with JetBrains decompiler
// Type: f
// Assembly: Camera Mouse 2018, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 51111F1A-BEB1-4B59-82BC-FB935BB3EA9E
// Assembly location: C:\Program Files (x86)\Camera Mouse\Camera Mouse 2018\Camera Mouse 2018.exe

using System.Runtime.CompilerServices;

[CompilerGenerated]
internal sealed class f
{
  internal static uint a(string A_0)
  {
    uint num;
    if (A_0 != null)
    {
      num = 2166136261U;
      for (int index = 0; index < A_0.Length; ++index)
        num = (uint) (((int) A_0[index] ^ (int) num) * 16777619);
    }
    return num;
  }
}
