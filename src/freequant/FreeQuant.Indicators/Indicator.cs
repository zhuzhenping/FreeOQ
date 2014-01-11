using FreeQuant.Charting;
using FreeQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace FreeQuant.Indicators
{
  [Serializable]
  public class Indicator : DoubleSeries, IDisposable
  {
    protected TimeSeries fInput;
    protected EIndicatorType fType;
    protected bool fCalculate;
    protected bool fDrawEnabled;
    protected int fFirstIndex;
    protected int fLastIndex;
    protected static bool fSyncIndex;
    private bool rbmJhWudB;

    protected int fRealCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fLastIndex - this.fFirstIndex + 1;
      }
    }

    [Browsable(false)]
    public override DateTime FirstDateTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        this.Calculate();
        if (this.fRealCount <= 0)
          throw new ApplicationException(GXPBSPblRhtUOANrS4.LSuAVoYjy(0));
        else
          return this.GetDateTime(this.fFirstIndex);
      }
    }

    [Browsable(false)]
    public override DateTime LastDateTime
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        this.Calculate();
        if (this.fRealCount <= 0)
          throw new ApplicationException(GXPBSPblRhtUOANrS4.LSuAVoYjy(46));
        else
          return this.GetDateTime(this.fLastIndex);
      }
    }

    [Category("Description")]
    [Description("")]
    public EIndicatorType Type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fType;
      }
    }

    [Browsable(false)]
    public override int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        this.Calculate();
        return base.Count;
      }
    }

    [Browsable(false)]
    public TimeSeries Input
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fInput;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        if (this.fInput != null)
          this.fInput.Children.Remove((object) this);
        this.fInput = value;
        this.fInput.Children.Add((object) this);
        this.fCalculate = true;
        this.Init();
        this.Connect();
      }
    }

    [Browsable(false)]
    public bool Monitored
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fMonitored;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fMonitored = value;
        if (this.fMonitored)
          this.fInput.ItemAdded += new ItemAddedEventHandler(this.OnInputItemAdded2);
        else
          this.fInput.ItemAdded -= new ItemAddedEventHandler(this.OnInputItemAdded2);
      }
    }

    [Browsable(false)]
    public override int FirstIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fFirstIndex;
      }
    }

    [Browsable(false)]
    public override int LastIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fLastIndex;
      }
    }

    [Browsable(false)]
    public override int RealCount
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fRealCount;
      }
    }

    [Browsable(false)]
    public bool DrawEnabled
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fDrawEnabled;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fDrawEnabled = value;
      }
    }

    public static bool SyncIndex
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return Indicator.fSyncIndex;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        Indicator.fSyncIndex = value;
      }
    }

    public new double this[int Index]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        this.Calculate();
        return base[Index];
      }
    }

    public new double this[DateTime DateTime]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        this.Calculate();
        return base[DateTime];
      }
    }

    public new double this[DateTime DateTime, EIndexOption Option]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        this.Calculate();
        return base[DateTime, Option];
      }
    }

    public override double this[int Col, int Row]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        this.Calculate();
        return base[Col, Row];
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Indicator()
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Indicator()
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fCalculate = true;
      this.fDrawEnabled = true;
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public Indicator(TimeSeries Input)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fCalculate = true;
      this.fDrawEnabled = true;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.fInput = Input;
      this.fInput.Children.Add((object) this);
      this.Connect();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Connect()
    {
      if (this.fInput == null)
        return;
      this.fInput.ItemAdded += new ItemAddedEventHandler(this.OnInputItemAdded2);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void Disconnect()
    {
      this.fInput.ItemAdded -= new ItemAddedEventHandler(this.OnInputItemAdded2);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Detach()
    {
      this.Disconnect();
      this.fInput.Children.Remove((object) this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Init()
    {
      this.fFirstIndex = 1073741823;
      this.fLastIndex = -1073741824;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnInputItemAdded2(object sender, DateTimeEventArgs EventArgs)
    {
      if (this.rbmJhWudB)
        return;
      if (this.fCalculate)
        this.Calculate();
      this.OnInputItemAdded(sender, EventArgs);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      if (!this.fMonitored)
        return;
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      this.Calculate(index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Calculate()
    {
      if (!this.fCalculate)
        return;
      this.fCalculate = false;
      this.rbmJhWudB = true;
      if (this.fInput is Indicator)
        (this.fInput as Indicator).Calculate();
      this.rbmJhWudB = false;
      for (int Index = 0; Index < this.fInput.Count; ++Index)
        this.Calculate(Index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void Calculate(bool Force)
    {
      if (Force)
        this.fCalculate = true;
      this.Calculate();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void Calculate(int Index)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Add(DateTime DateTime, double Data)
    {
      if (!Indicator.fSyncIndex && double.IsNaN(Data))
        return;
      this.fArray.Remove(DateTime);
      this.fArray.Add(DateTime, (object) Data);
      int num = this.fArray.IndexOf(DateTime);
      if (num < this.fFirstIndex)
      {
        if (!double.IsNaN(Data))
          this.fFirstIndex = num;
        else
          ++this.fFirstIndex;
      }
      if (num > this.fLastIndex)
      {
        if (!double.IsNaN(Data))
          this.fLastIndex = num;
        else
          --this.fLastIndex;
      }
      this.fChanged = true;
      this.EmitItemAdded(DateTime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Remove(int Index)
    {
      if (Index < this.fFirstIndex)
        --this.fFirstIndex;
      if (Index <= this.fLastIndex)
        --this.fLastIndex;
      this.fArray.RemoveAt(Index);
      this.fChanged = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Clear()
    {
      this.fArray.Clear();
      this.fFirstIndex = 1073741823;
      this.fLastIndex = -1073741824;
      this.fChanged = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Contains(DateTime dateTime)
    {
      this.Calculate();
      return base.Contains(dateTime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override bool Contains(int index)
    {
      this.Calculate();
      return base.Contains(index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DateTime GetDateTime(int Index)
    {
      this.Calculate();
      return base.GetDateTime(Index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetIndex(DateTime DateTime)
    {
      this.Calculate();
      return base.GetIndex(DateTime);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override int GetIndex(DateTime DateTime, EIndexOption Option)
    {
      this.Calculate();
      return base.GetIndex(DateTime, Option);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Paint(Pad pad, double XMin, double XMax, double YMin, double YMax)
    {
      Pen pen = new Pen(this.fColor, (float) this.fDrawWidth);
      Brush brush = (Brush) new SolidBrush(this.fColor);
      int num1 = 0;
      double num2 = 0.0;
      double num3 = 0.0;
      int x1 = 0;
      int x2 = 0;
      int y1 = 0;
      int y2 = 0;
      int num4 = 0;
      int num5 = 0;
      int num6 = 0;
      int num7 = 0;
      DateTime dateTime1 = new DateTime((long) XMin);
      DateTime dateTime2 = new DateTime((long) XMax);
      int num8 = !(dateTime1 < this.FirstDateTime) ? this.GetIndex(dateTime1, EIndexOption.Next) : this.fFirstIndex;
      int num9 = !(dateTime2 > this.LastDateTime) ? this.GetIndex(dateTime2, EIndexOption.Prev) : this.fLastIndex;
      if (num8 == -1 || num9 == -1)
        return;
      switch (this.fDrawStyle)
      {
        case EDrawStyle.Line:
          for (int index = num8; index <= num9; ++index)
          {
            double num10 = (double) this.GetDateTime(index).Ticks;
            double num11 = ((TimeSeries) this)[index, 0];
            if (num1 != 0)
            {
              x1 = pad.ClientX(num2);
              y1 = pad.ClientY(num3);
              x2 = pad.ClientX(num10);
              y2 = pad.ClientY(num11);
              if ((pad.IsInRange(num10, num11) || pad.IsInRange(num2, num3)) && (x1 != num4 || x2 != num5 || (y1 != num6 || y2 != num7)))
                pad.Graphics.DrawLine(pen, x1, y1, x2, y2);
            }
            num4 = x1;
            num6 = y1;
            num5 = x2;
            num7 = y2;
            num2 = num10;
            num3 = num11;
            ++num1;
          }
          break;
        case EDrawStyle.Bar:
          for (int index = num8; index <= num9; ++index)
          {
            double WorldX = (double) this.GetDateTime(index).Ticks;
            double WorldY = ((TimeSeries) this)[index, 0];
            if (WorldY > 0.0)
              pad.Graphics.FillRectangle((Brush) new SolidBrush(this.fColor), pad.ClientX(WorldX) - this.fDrawWidth / 2, pad.ClientY(WorldY), this.fDrawWidth, pad.ClientY(0.0) - pad.ClientY(WorldY));
            else
              pad.Graphics.FillRectangle((Brush) new SolidBrush(this.fColor), pad.ClientX(WorldX) - this.fDrawWidth / 2, pad.ClientY(0.0), this.fDrawWidth, pad.ClientY(WorldY) - pad.ClientY(0.0));
          }
          break;
        case EDrawStyle.Circle:
          for (int index = num8; index <= num9; ++index)
          {
            double WorldX = (double) this.GetDateTime(index).Ticks;
            double WorldY = ((TimeSeries) this)[index, 0];
            pad.Graphics.FillEllipse(brush, pad.ClientX(WorldX) - this.fDrawWidth / 2, pad.ClientY(WorldY) - this.fDrawWidth / 2, this.fDrawWidth, this.fDrawWidth);
          }
          break;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetSum()
    {
      if (this.fChanged)
      {
        this.fSum = 0.0;
        for (int index = this.fFirstIndex; index < this.fLastIndex; ++index)
        {
          Indicator indicator = this;
          double num = indicator.fSum + ((TimeSeries) this)[index, 0];
          indicator.fSum = num;
        }
      }
      return this.fSum;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetSum(int Row)
    {
      return this.GetSum(this.fFirstIndex, this.fLastIndex, Row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetMean()
    {
      if (this.Count <= 0)
        throw new ApplicationException(GXPBSPblRhtUOANrS4.LSuAVoYjy(92));
      if (this.fChanged)
        this.fMean = this.GetMean(this.fFirstIndex, this.fLastIndex);
      return this.fMean;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetMean(int Row)
    {
      return this.GetMean(this.fFirstIndex, this.fLastIndex, Row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetMedian()
    {
      if (this.Count <= 0)
        throw new ApplicationException(GXPBSPblRhtUOANrS4.LSuAVoYjy(174));
      if (this.fChanged)
        this.fMedian = this.GetMedian(this.fFirstIndex, this.fLastIndex);
      return this.fMedian;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetMedian(int Row)
    {
      return this.GetMedian(this.fFirstIndex, this.fLastIndex, Row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetVariance()
    {
      if (this.fRealCount <= 1)
        throw new ApplicationException(GXPBSPblRhtUOANrS4.LSuAVoYjy(260));
      if (this.fChanged)
      {
        double mean = this.GetMean();
        this.fVariance = 0.0;
        for (int index = this.fFirstIndex; index < this.fLastIndex; ++index)
        {
          Indicator indicator = this;
          double num = indicator.fVariance + (mean - ((TimeSeries) this)[index, 0]) * (mean - ((TimeSeries) this)[index, 0]);
          indicator.fVariance = num;
        }
        Indicator indicator1 = this;
        double num1 = indicator1.fVariance / (double) (this.fRealCount - 1);
        indicator1.fVariance = num1;
      }
      return this.fVariance;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetVariance(int Row)
    {
      return this.GetVariance(this.fFirstIndex, this.fLastIndex, Row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetPositiveVariance(int Row)
    {
      return this.GetPositiveVariance(this.fFirstIndex, this.fLastIndex, Row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetNegativeVariance(int Row)
    {
      return this.GetNegativeVariance(this.fFirstIndex, this.fLastIndex, Row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetMoment(int k, int Row)
    {
      return this.GetMoment(k, this.fFirstIndex, this.fLastIndex, Row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetAsymmetry(int Row)
    {
      return this.GetAsymmetry(this.fFirstIndex, this.fLastIndex, Row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetExcess(int Row)
    {
      return this.GetExcess(this.fFirstIndex, this.fLastIndex, Row);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override double GetAutoCovariance(int Lag)
    {
      if (Lag >= this.fRealCount)
        throw new ApplicationException(GXPBSPblRhtUOANrS4.LSuAVoYjy(410));
      double mean = this.GetMean();
      double num = 0.0;
      for (int index = Lag + this.fFirstIndex; index < this.fLastIndex; ++index)
        num += (((TimeSeries) this)[index, 0] - mean) * (((TimeSeries) this)[index - Lag, 0] - mean);
      return num / (double) (this.fLastIndex - Lag);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DoubleSeries GetReturnSeries()
    {
      DoubleSeries doubleSeries = new DoubleSeries(this.fName, this.fTitle + GXPBSPblRhtUOANrS4.LSuAVoYjy(540));
      if (this.Count > 1)
      {
        double num1 = this[0];
        for (int index = this.fFirstIndex; index < this.fLastIndex; ++index)
        {
          DateTime dateTime = this.GetDateTime(index);
          double num2 = this[index];
          if (num1 != 0.0)
            doubleSeries.Add(dateTime, num2 / num1);
          else
            doubleSeries.Add(dateTime, 0.0);
          num1 = num2;
        }
      }
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DoubleSeries GetPercentReturnSeries()
    {
      DoubleSeries doubleSeries = new DoubleSeries(this.fName, this.fTitle + GXPBSPblRhtUOANrS4.LSuAVoYjy(562));
      if (this.fRealCount > 1)
      {
        double num1 = this[0];
        for (int index = this.fFirstIndex; index < this.fLastIndex; ++index)
        {
          DateTime dateTime = this.GetDateTime(index);
          double num2 = this[index];
          if (num1 != 0.0)
            doubleSeries.Add(dateTime, (num2 / num1 - 1.0) * 100.0);
          else
            doubleSeries.Add(dateTime, 0.0);
          num1 = num2;
        }
      }
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DoubleSeries GetPositiveSeries()
    {
      DoubleSeries doubleSeries = new DoubleSeries();
      for (int index = this.fFirstIndex; index < this.fLastIndex; ++index)
      {
        if (this[index] > 0.0)
          doubleSeries.Add(this.GetDateTime(index), this[index]);
      }
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override DoubleSeries GetNegativeSeries()
    {
      DoubleSeries doubleSeries = new DoubleSeries();
      for (int index = this.fFirstIndex; index < this.fLastIndex; ++index)
      {
        if (this[index] < 0.0)
          doubleSeries.Add(this.GetDateTime(index), this[index]);
      }
      return doubleSeries;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Dispose()
    {
      this.Detach();
    }
  }
}