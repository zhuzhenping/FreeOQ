using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace FreeQuant.Instruments
{
  public class AccountTransactionList : ICollection, IEnumerable
  {
    private ArrayList Jprdm2XcHq;

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Jprdm2XcHq.IsSynchronized;
      }
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Jprdm2XcHq.Count;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Jprdm2XcHq.SyncRoot;
      }
    }

    public AccountTransaction this[int index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.Jprdm2XcHq[index] as AccountTransaction;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public AccountTransactionList()
    {
      Px7gU0q9iICvf09Y91.kdkL0sczOKVVS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Jprdm2XcHq = new ArrayList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.Jprdm2XcHq.CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.Jprdm2XcHq.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      this.Jprdm2XcHq.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(AccountTransaction transaction)
    {
      int count;
      for (count = this.Jprdm2XcHq.Count; count > 0; --count)
      {
        AccountTransaction accountTransaction = this[count - 1];
        if (transaction.DateTime >= accountTransaction.DateTime)
          break;
      }
      this.Jprdm2XcHq.Insert(count, (object) transaction);
    }
  }
}
