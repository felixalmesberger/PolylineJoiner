using System.Collections.Generic;

namespace Infomatik.Kml.LineAggregator
{
  public interface IPolylineReader
  {
    IList<Polyline3d> Read(string path);
  }
}