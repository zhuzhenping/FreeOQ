﻿// Type: SmartQuant.FinChart.PropertyForm
// Assembly: SmartQuant.FinChart, Version=1.0.5036.28359, Culture=neutral, PublicKeyToken=null
// MVID: B0E28D96-7193-4746-A2CB-1ADD555CD2CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FinChart.dll

using cY9o6QKnveiK0L5ffy;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using yHueqhRH1sS5jNKgDq;

namespace SmartQuant.FinChart
{
  public class PropertyForm : Form
  {
    private PropertyGrid OCRJhaKNQA;
    private Button pqrJbPSFp1;
    private Container DNPJesGe4X;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PropertyForm(object properties)
    {
      xlHX4q73elwpX9fKZc.pdv4sYgzFgCoc();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.edmJDBj1tJ();
      this.OCRJhaKNQA.SelectedObject = properties;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.DNPJesGe4X != null)
        this.DNPJesGe4X.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void edmJDBj1tJ()
    {
      this.OCRJhaKNQA = new PropertyGrid();
      this.pqrJbPSFp1 = new Button();
      this.SuspendLayout();
      this.OCRJhaKNQA.CommandsVisibleIfAvailable = true;
      this.OCRJhaKNQA.Dock = DockStyle.Fill;
      this.OCRJhaKNQA.LargeButtons = false;
      this.OCRJhaKNQA.LineColor = SystemColors.ScrollBar;
      this.OCRJhaKNQA.Location = new Point(0, 0);
      this.OCRJhaKNQA.Name = FJDHryrxb1WIq5jBAt.mT707pbkgT(2446);
      this.OCRJhaKNQA.Size = new Size(232, 310);
      this.OCRJhaKNQA.TabIndex = 2;
      this.OCRJhaKNQA.Text = FJDHryrxb1WIq5jBAt.mT707pbkgT(2474);
      this.OCRJhaKNQA.ViewBackColor = SystemColors.Window;
      this.OCRJhaKNQA.ViewForeColor = SystemColors.WindowText;
      this.pqrJbPSFp1.DialogResult = DialogResult.Cancel;
      this.pqrJbPSFp1.Location = new Point(168, 280);
      this.pqrJbPSFp1.Name = FJDHryrxb1WIq5jBAt.mT707pbkgT(2504);
      this.pqrJbPSFp1.Size = new Size(56, 24);
      this.pqrJbPSFp1.TabIndex = 3;
      this.pqrJbPSFp1.Text = FJDHryrxb1WIq5jBAt.mT707pbkgT(2524);
      this.AutoScaleBaseSize = new Size(5, 13);
      this.ClientSize = new Size(232, 310);
      this.ControlBox = false;
      this.Controls.Add((Control) this.pqrJbPSFp1);
      this.Controls.Add((Control) this.OCRJhaKNQA);
      this.Name = FJDHryrxb1WIq5jBAt.mT707pbkgT(2538);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = FJDHryrxb1WIq5jBAt.mT707pbkgT(2566);
      this.ResumeLayout(false);
    }
  }
}