using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.FIX
{
  public class FIXPosReqResult : FIXIntField
  {
    public const int ValidRequest = 0;
    public const int InvalidOrUnsupportedRequest = 1;
    public const int NoPositionsFound = 2;
    public const int NotAuthorized = 3;
    public const int RequestForPositionNotSupported = 4;
    public const int Other = 99;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXPosReqResult(int value)
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector(728, value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int ToFIX(PosReqResult value)
    {
      switch (value)
      {
        case PosReqResult.ValidRequest:
          return 0;
        case PosReqResult.InvalidOrUnsupportedRequest:
          return 1;
        case PosReqResult.NoPositionsFound:
          return 2;
        case PosReqResult.NotAuthorized:
          return 3;
        case PosReqResult.RequestForPositionNotSupported:
          return 4;
        case PosReqResult.Other:
          return 99;
        default:
          throw new ArgumentException(string.Format(Ugjylcah9mCMM4kO7N.tLah92SpBQ(38914), (object) value));
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static PosReqResult FromFIX(int value)
    {
      switch (value)
      {
        case 0:
          return PosReqResult.ValidRequest;
        case 1:
          return PosReqResult.InvalidOrUnsupportedRequest;
        case 2:
          return PosReqResult.NoPositionsFound;
        case 3:
          return PosReqResult.NotAuthorized;
        case 4:
          return PosReqResult.RequestForPositionNotSupported;
        case 99:
          return PosReqResult.Other;
        default:
          throw new ArgumentException(string.Format(Ugjylcah9mCMM4kO7N.tLah92SpBQ(38992), (object) value));
      }
    }
  }
}
