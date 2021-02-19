// (C) 2020 Infomatik - Felix Almesberger

using System.CodeDom;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Infomatik.Kml.LineAggregator
{
  public class KmlPolylineReader : IPolylineReader
  {
    public IList<Polyline3d> Read(string path)
    {
      using (var stream = File.OpenRead(path))
      {
        var doc = XDocument.Load(stream);

        return doc.Root
                  .Descendants()
                  .Where(x => x.Name.LocalName == "LineString")
                  .Select(this.ParseLineString)
                  .ToList();
      }
    }

    private Polyline3d ParseLineString(XElement lineString)
    {
      var coordinatesString = lineString.Descendants()
                                  .FirstOrDefault(x => x.Name.LocalName == "coordinates")
                                 ?.Value ?? "";

      var points = this.ParseCoordinatesString(coordinatesString);

      return new Polyline3d(points);
    }

    private IList<Point3d> ParseCoordinatesString(string value)
    {
      var points = value.Split(' ');

      return points.Select(this.ParsePoint)
                   .Where(x => x.HasValue)
                   .Select(x => x.Value)
                   .ToList();

    }

    private Point3d? ParsePoint(string value)
    {
      var elements = value.Trim().Split(',');

      if (elements.Length < 2)
        return null;

      var hasZ = elements.Length == 3;

      var z = 0.0;

      double.TryParse(elements[0], NumberStyles.Any, CultureInfo.InvariantCulture, out var x);
      double.TryParse(elements[1], NumberStyles.Any, CultureInfo.InvariantCulture, out var y);

      if (hasZ)
        double.TryParse(elements[2], NumberStyles.Any, CultureInfo.InvariantCulture, out z);

      return new Point3d(x, y, z);
    }
  }
}