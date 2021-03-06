using FreeQuant.Testing.TesterItems;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing
{
  public class TesterSettings
  {
    private LiveTester fNyFvVvOo;
    private TesterItemList U8g72RfTo;
    private TesterItemList SZctPlnKv;

    
		public TesterSettings(LiveTester tester):base()
    {
      this.fNyFvVvOo = tester;
      this.FXUR2afwm();
    }

    
    private void FXUR2afwm()
    {
      this.U8g72RfTo = new TesterItemList();
      this.SZctPlnKv = new TesterItemList();
      foreach (TesterItem testerItem in this.fNyFvVvOo.Components)
      {
        SeriesTesterItem seriesTesterItem = testerItem as SeriesTesterItem;
        if (seriesTesterItem != null)
        {
          if (seriesTesterItem.Enabled)
            this.U8g72RfTo.f9Ww98OVG((TesterItem) seriesTesterItem);
          if (seriesTesterItem.FillSeries)
            this.SZctPlnKv.f9Ww98OVG((TesterItem) seriesTesterItem);
        }
      }
    }

    
    public void LoadState()
    {
      foreach (TesterItem testerItem in this.fNyFvVvOo.Components)
      {
        SeriesTesterItem seriesTesterItem = testerItem as SeriesTesterItem;
        if (seriesTesterItem != null)
        {
          if (this.U8g72RfTo.Contains(seriesTesterItem.Name))
            seriesTesterItem.Enabled = true;
          if (this.SZctPlnKv.Contains(seriesTesterItem.Name))
            seriesTesterItem.FillSeries = true;
        }
      }
    }
  }
}
