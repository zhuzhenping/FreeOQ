using FreeQuant.QuantRouterLib.Data;
using System.IO;
using System.Runtime.CompilerServices;

namespace FreeQuant.QuantRouterLib.Messages
{
  public class MsgLogon : Message
  {
    public Logon Data { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

	public MsgLogon() : base(1)
    {

      this.Data = new Logon();
    }

    protected override void OnGetData(BinaryWriter writer)
    {
      writer.Write(this.Data.Username);
      writer.Write(this.Data.Password);
    }

    protected override void OnSetData(BinaryReader reader)
    {
      this.Data.Username = reader.ReadString();
      this.Data.Password = reader.ReadString();
    }
  }
}
