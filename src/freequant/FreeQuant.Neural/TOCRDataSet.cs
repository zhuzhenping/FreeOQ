using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Neural
{
  [Serializable]
  public class TOCRDataSet : TNeuralDataSet
  {
    private double[,] nuSLdi5R1;
    private double[,] ky40Od4hB;

    public TOCRDataSet()
    {
      this.nuSLdi5R1 = new double[10, 35]
      {
        {
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          0.0,
          0.0,
          0.0,
          1.0,
          1.0,
          0.0,
          0.0,
          0.0,
          1.0,
          1.0,
          0.0,
          0.0,
          0.0,
          1.0,
          1.0,
          0.0,
          0.0,
          0.0,
          1.0,
          1.0,
          0.0,
          0.0,
          0.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0
        },
        {
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0
        },
        {
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          0.0,
          0.0,
          0.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0
        },
        {
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0
        },
        {
          1.0,
          0.0,
          0.0,
          0.0,
          1.0,
          1.0,
          0.0,
          0.0,
          0.0,
          1.0,
          1.0,
          0.0,
          0.0,
          0.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0
        },
        {
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0
        },
        {
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          0.0,
          0.0,
          0.0,
          1.0,
          1.0,
          0.0,
          0.0,
          0.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0
        },
        {
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0
        },
        {
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          0.0,
          0.0,
          0.0,
          1.0,
          1.0,
          0.0,
          0.0,
          0.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          0.0,
          0.0,
          0.0,
          1.0,
          1.0,
          0.0,
          0.0,
          0.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0
        },
        {
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          0.0,
          0.0,
          0.0,
          1.0,
          1.0,
          0.0,
          0.0,
          0.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0,
          1.0
        }
      };
      this.ky40Od4hB = new double[10, 10]
      {
        {
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          0.0,
          0.0,
          0.0,
          0.0,
          0.0
        },
        {
          0.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          0.0,
          0.0,
          0.0,
          0.0
        },
        {
          0.0,
          0.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          0.0,
          0.0,
          0.0
        },
        {
          0.0,
          0.0,
          0.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          0.0,
          0.0
        },
        {
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0,
          0.0
        },
        {
          0.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          0.0,
          0.0,
          0.0,
          0.0
        },
        {
          0.0,
          0.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          0.0,
          0.0,
          0.0
        },
        {
          0.0,
          0.0,
          0.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          0.0,
          0.0
        },
        {
          0.0,
          0.0,
          0.0,
          0.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0,
          0.0
        },
        {
          0.0,
          0.0,
          0.0,
          0.0,
          0.0,
          0.0,
          0.0,
          0.0,
          0.0,
          1.0
        }
      };
      // ISSUE: explicit constructor call
      base.\u002Ector(35, 10);
      this.PrepareData();
    }

    public override void PrepareData()
    {
      double[] Input = new double[35];
      double[] Output = new double[10];
      for (int index1 = 0; index1 < 10; ++index1)
      {
        for (int index2 = 0; index2 < 35; ++index2)
          Input[index2] = this.nuSLdi5R1[index1, index2];
        for (int index2 = 0; index2 < 10; ++index2)
          Output[index2] = this.ky40Od4hB[index1, index2];
        this.AddData(this.fNInput, this.fNOutput, Input, Output);
      }
      this.fIsChanged = false;
    }
  }
}
