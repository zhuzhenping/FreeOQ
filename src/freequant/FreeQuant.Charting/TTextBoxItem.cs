using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Charting
{
  public class TTextBoxItem
  {
    private string aGsoVk3Bc;
    private Color kP83TXqlQ;
    private Font jLCCwmdU2;

    public string Text
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.aGsoVk3Bc;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.aGsoVk3Bc = value;
      }
    }

    public Color Color
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.kP83TXqlQ;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.kP83TXqlQ = value;
      }
    }

    public Font Font
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.jLCCwmdU2;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.jLCCwmdU2 = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TTextBoxItem(string Text, Color Color, Font Font)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.aGsoVk3Bc = Text;
      this.kP83TXqlQ = Color;
      this.jLCCwmdU2 = Font;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TTextBoxItem(string Text, Color Color)
    {
      Apmqf3XByShSL8cPCS.GHkILmVzKt7va();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.aGsoVk3Bc = Text;
      this.kP83TXqlQ = Color;
      this.jLCCwmdU2 = new Font(RA7k7APgXK5aSsnmA9.qBCYFXVOKp(0), 8f);
    }
  }
}
