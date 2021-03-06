using FreeQuant.Data;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class K_Slow : Indicator
  {
    protected int fLength;
    protected int fOrder;
    protected K_Fast fK;

    [IndicatorParameter(0)]
    [Category("Parameters")]
    [Description("")]
    public int Length
    {
       get
      {
        return this.fLength;
      }
       set
      {
        this.fLength = value;
        this.Init();
      }
    }

    [IndicatorParameter(1)]
    [Category("Parameters")]
    [Description("")]
    public int Order
    {
       get
      {
        return this.fOrder;
      }
       set
      {
        this.fOrder = value;
        this.Init();
      }
    }

    
		public K_Slow(): base()
    {
      this.fLength = 14;
      this.fOrder = 10;
      this.Init();
    }

    
		public K_Slow(TimeSeries input, int length, int order)	: base(input) 
    {
      this.fLength = 14;
      this.fOrder = 10;
      this.fLength = length;
      this.fOrder = order;
      this.Init();
    }

    
		public K_Slow(TimeSeries input, int length, int order, Color color)	: base(input) 
    {
      this.fLength = 14;
      this.fOrder = 10;
      this.fLength = length;
      this.fOrder = order;
      this.Init();
      this.Color = color;
    }

    
    public K_Slow(TimeSeries input, int length, int order, Color color, EDrawStyle drawStyle)
			: base(input)   {
      this.fLength = 14;
      this.fOrder = 10;
      this.fLength = length;
      this.fOrder = order;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    
    protected override void Init()
    {
			this.Name = "KSlow"+ (object) this.fLength + (string) (object) this.fOrder;
			this.Title = "KSlow";
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null)
        return;
			if (TimeSeries.fNameOption == ENameOption.Long)
        this.Name = this.fInput.Name  + this.Name;
      this.Disconnect();
      if (this.fK != null)
        this.fK.Detach();
      this.fK = new K_Fast(this.fInput, this.fLength);
      this.fK.DrawEnabled = false;
      this.Connect();
    }

    
    protected override void Calculate(int index)
    {
      double Data = K_Slow.Value(this.fInput, index, this.fLength, this.fOrder);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    
    public static double Value(TimeSeries input, int index, int length, int order)
    {
      if (index < length + order - 1 + input.FirstIndex)
        return double.NaN;
      double num1 = 0.0;
      for (int index2 = index; index2 > index - order; --index2)
      {
        double min = input.GetMin(index2 - length + 1, index2, BarData.Low);
        double max = input.GetMax(index2 - length + 1, index2, BarData.High);
        double num2 = input[index2, BarData.Close];
        double num3 = max - min;
        double num4 = num2 - min;
        num1 += 100.0 * num4 / num3;
      }
      return num1 / (double) order;
    }

    
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      if (!this.Monitored)
        return;
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      for (int Index = index; Index <= Math.Min(this.fInput.Count - 1, index + this.fLength + this.fOrder - 1); ++Index)
        this.Calculate(Index);
    }

    
    public override void Detach()
    {
      this.fK.Detach();
      base.Detach();
    }
  }
}
