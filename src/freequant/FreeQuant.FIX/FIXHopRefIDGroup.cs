﻿using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXHopRefIDGroup : FIXGroup
  {
    [FIXField("630", EFieldOption.Optional)]
    public int HopRefID
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(630).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(630, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXHopRefIDGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }
  }
}
