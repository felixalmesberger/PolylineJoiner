using System;
using System.Drawing;
using System.Windows.Forms;

namespace Infomatik.Kml.LineAggregator
{
  public partial class MainForm : Form, ILineJoinerView
  {

    #region fields

    private readonly LineJoinerPresenter presenter;
    private bool isBusy;

    #endregion

    #region properties

    public string Source
    {
      get => this.txtSource.Text;
      set => this.txtSource.Text = value;
    }

    public string Destination
    {
      get => this.txtDestination.Text;
      set => this.txtDestination.Text = value;
    }

    public Color LineColor
    {
      get => this.picColor.BackColor;
      set => this.picColor.BackColor = value;
    }

    public double LineWidth
    {
      get => (double)this.numWidth.Value;
      set => this.numWidth.Value = (decimal)value;
    }


    public bool IsBusy
    {
      get => this.isBusy;
      set { this.isBusy = value; this.ApplyIsBusy(); }
    }

    public bool UseElevation
    {
      get => this.rad3D.Checked;
      set => this.rad3D.Checked = value;
    }

    private void ApplyIsBusy()
    {
      this.Invoke(new MethodInvoker(() =>
      {
        this.progressBar.Style = this.IsBusy
                                 ? ProgressBarStyle.Marquee
                                 : ProgressBarStyle.Continuous;

        this.btnExecute.Enabled = !this.IsBusy;
      }));
    }

    public void ShowMessage(string message)
    {
      this.Invoke(new MethodInvoker(() =>
      {
        MessageBox.Show(message, "Infomatik", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }));

    }

    public void ShowError(string message)
    {
      this.Invoke(new MethodInvoker(() =>
      {
        MessageBox.Show(message, "Infomatik", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }));
    }

    #endregion

    public MainForm()
    {
      this.InitializeComponent();
      this.presenter = new LineJoinerPresenter(new KmlPolylineReader(), new KmlPolylineWriter())
      {
        View = this
      };
    }

    private void btnSelectSource_Click(object sender, EventArgs e)
    {
      var fileDialog = new OpenFileDialog()
      {
        Filter = SR.KmlFilter
      };

      using (fileDialog)
        if (fileDialog.ShowDialog(this) == DialogResult.OK)
          this.Source = fileDialog.FileName;
    }
    private void btnSelectDestination_Click(object sender, EventArgs e)
    {
      var fileDialog = new SaveFileDialog()
      {
        Filter = SR.KmlFilter
      };

      using (fileDialog)
        if (fileDialog.ShowDialog(this) == DialogResult.OK)
          this.Destination = fileDialog.FileName;
    }

    private void picColor_Click(object sender, EventArgs e)
    {
      var colorDialog = new ColorDialog();
      using (colorDialog)
        if (colorDialog.ShowDialog(this) == DialogResult.OK)
          this.LineColor = colorDialog.Color;
    }

    private async void btnExecute_Click(object sender, EventArgs e)
     => await this.presenter.ExecuteAsync();
    public static class SR
    {
      public static readonly string KmlFilter = "Kml Dateien (*.kml)|*.kml";
    }

  }
}