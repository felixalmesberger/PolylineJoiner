// (C) 2020 Infomatik - Felix Almesberger

using System.Drawing;

namespace Infomatik.Kml.LineAggregator
{
  public interface ILineJoinerView
  {
    string Source { get; set; }
    string Destination { get; set; }
    Color LineColor { get; set; }
    double LineWidth { get; set; }
    bool UseElevation { get; set; }
    bool IsBusy { get; set; }
    void ShowMessage(string message);
    void ShowError(string message);
  }
}