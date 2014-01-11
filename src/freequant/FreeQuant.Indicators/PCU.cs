﻿// Type: SmartQuant.Indicators.PCU
// Assembly: SmartQuant.Indicators, Version=1.0.5036.28340, Culture=neutral, PublicKeyToken=null
// MVID: 31E147DE-EF63-4F0C-B049-23C3662CE212
// Assembly location: E:\OpenQuant\Framework\bin\SmartQuant.Indicators.dll

using JgR8Nw4Dcm7J7u8IfB;
using ko1tl8f5ZvqOYr69tl;
using SmartQuant.Data;
using SmartQuant.Series;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace SmartQuant.Indicators
{
  [Serializable]
  public class PCU : Indicator
  {
    protected int fLength;

    [Description("")]
    [IndicatorParameter(0)]
    [Category("Parameters")]
    public int Length
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.fLength;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.fLength = value;
        this.Init();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PCU()
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PCU(TimeSeries input, int length)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.Init();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PCU(TimeSeries input, int length, Color color)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.Init();
      this.Color = color;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PCU(TimeSeries input, int length, Color color, EDrawStyle drawStyle)
    {
      RMXbNVLKIIh1UeJavt.ngyLmRPzO9SGQ();
      this.fLength = 14;
      // ISSUE: explicit constructor call
      base.\u002Ector(input);
      this.fLength = length;
      this.Init();
      this.Color = color;
      this.DrawStyle = drawStyle;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Init()
    {
      this.fName = GXPBSPblRhtUOANrS4.LSuAVoYjy(4588) + (object) this.fLength + GXPBSPblRhtUOANrS4.LSuAVoYjy(4602);
      this.fTitle = GXPBSPblRhtUOANrS4.LSuAVoYjy(4608);
      this.fType = EIndicatorType.Price;
      this.Clear();
      this.fCalculate = true;
      if (this.fInput == null || TimeSeries.fNameOption != ENameOption.Long)
        return;
      this.fName = this.fInput.Name + GXPBSPblRhtUOANrS4.LSuAVoYjy(4650) + this.fName;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Calculate(int index)
    {
      double Data = PCU.Value(this.fInput, index, this.fLength);
      this.Add(this.fInput.GetDateTime(index), Data);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static double Value(TimeSeries input, int index, int length)
    {
      if (index >= length + input.FirstIndex)
        return input.GetMax(index - length, index - 1, BarData.High);
      else
        return double.NaN;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void OnInputItemAdded(object sender, DateTimeEventArgs EventArgs)
    {
      if (!this.fMonitored)
        return;
      int index = this.fInput.GetIndex(EventArgs.DateTime);
      if (index == -1)
        return;
      for (int Index = index; Index <= Math.Min(this.fInput.Count - 1, index + this.fLength); ++Index)
        this.Calculate(Index);
    }
  }
}
