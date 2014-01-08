using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXTrdRegTimestamps : FIXMessage
  {
    private ArrayList nl7tuH2vqb;

    [FIXField("768", EFieldOption.Optional)]
    public int NoTrdRegTimestamps
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(768).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(768, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXTrdRegTimestamps()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      this.nl7tuH2vqb = new ArrayList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXTrdRegTimestampsGroup GetTrdRegTimestampsGroup(int i)
    {
      if (i < this.NoTrdRegTimestamps)
        return (FIXTrdRegTimestampsGroup) this.nl7tuH2vqb[i];
      else
        return (FIXTrdRegTimestampsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXTrdRegTimestampsGroup group)
    {
      this.nl7tuH2vqb.Add((object) group);
      ++this.NoTrdRegTimestamps;
    }
  }
}
