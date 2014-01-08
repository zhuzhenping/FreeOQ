using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXNestedParties2 : FIXMessage
  {
    private ArrayList JVFQxr9KJq;

    [FIXField("756", EFieldOption.Optional)]
    public int NoNested2PartyIDs
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.GetIntField(756).Value;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.AddIntField(756, value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXNestedParties2()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      this.JVFQxr9KJq = new ArrayList();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXNested2PartyIDsGroup GetNested2PartyIDsGroup(int i)
    {
      if (i < this.NoNested2PartyIDs)
        return (FIXNested2PartyIDsGroup) this.JVFQxr9KJq[i];
      else
        return (FIXNested2PartyIDsGroup) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddGroup(FIXNested2PartyIDsGroup group)
    {
      this.JVFQxr9KJq.Add((object) group);
      ++this.NoNested2PartyIDs;
    }
  }
}
