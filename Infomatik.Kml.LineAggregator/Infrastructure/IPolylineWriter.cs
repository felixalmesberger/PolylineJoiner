using System.Collections.Generic;
using System.Drawing;

namespace Infomatik.Kml.LineAggregator
{
  public interface IPolylineWriter
  {
    void Write(IList<Polyline3d> polylines, string filename);
    bool UseElevation { get; set; }

  }

  public interface IStylablePolylineWriter : IPolylineWriter
  {
    double PolylineWidth { get; set; }
    Color PolylineColor { get; set; }
  }
}