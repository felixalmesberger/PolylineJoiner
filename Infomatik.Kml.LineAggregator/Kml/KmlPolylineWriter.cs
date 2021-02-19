using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace Infomatik.Kml.LineAggregator
{
  public class KmlPolylineWriter : IPolylineWriter
  {

    #region properties

    public bool UseElevation { get; set; }
    public string LineStringStyleId { get; set; } = "LineStringStyle";

    public double PolylineWidth { get; set; } = 2;
    public Color PolylineColor { get; set; } = Color.Black;

    #endregion

    public void Write(IList<Polyline3d> polylines, string filename)
    {
      var name = Path.GetFileNameWithoutExtension(filename);
      var declaration = new XDeclaration("1.0", "UTF-8", "");
      var lineStyle = this.CreateLineStringStyle(this.LineStringStyleId, this.PolylineColor, this.PolylineWidth);

      var placemarks = polylines.Select(x => this.CreatePolylinePlacemark(x, "Polyline", this.LineStringStyleId)).ToList();

      var doc = new XDocument(declaration,
                              new XElement("kml",
                                new XElement("Document",
                                new XElement("name", name),
                                  lineStyle,
                                  placemarks)));

      doc.Save(filename);
    }

    private XElement CreatePolylinePlacemark(Polyline3d polyline, string name, string styleId)
    {
      return new XElement("Placemark",
                          new XElement("name", name),
                          new XElement("styleUrl", $"#{styleId}"),
                          this.CreateLineString(polyline));
    }

    private XElement CreateLineStringStyle(string id, Color color, double width)
    {
      var hexColor = ColorTranslator.ToHtml(color);

      var idAttribute = new XAttribute("id", id);

      return new XElement("Style", idAttribute,
                          new XElement("LineStyle",
                                       new XElement("color", hexColor),
                                       new XElement("width", width)));
    }

    private XElement CreateLineString(Polyline3d polyline)
    {
      var coordinatesString = this.PolylineToString(polyline);

      return new XElement("LineString",
                          new XElement("tessellate", 1),
                          new XElement("coordinates", coordinatesString));
    }

    private string PolylineToString(Polyline3d polyline)
    {
      if (!polyline.Any())
        return "";

      var pointToStringMethod = this.UseElevation
                                  ? new Func<Point3d, string>(this.PointToStringWithElevation)
                                  : new Func<Point3d, string>(this.PointToStringWithoutElevation);

      return polyline.Select(pointToStringMethod)
                     .Aggregate((a, b) => $"{a} {b}");
    }

    private string PointToStringWithoutElevation(Point3d point)
    {
      var x = point.X.ToString(CultureInfo.InvariantCulture);
      var y = point.Y.ToString(CultureInfo.InvariantCulture);
      return $"{x},{y}";
    }

    private string PointToStringWithElevation(Point3d point)
    {
      var x = point.X.ToString(CultureInfo.InvariantCulture);
      var y = point.Y.ToString(CultureInfo.InvariantCulture);
      var z = point.Z.ToString(CultureInfo.InvariantCulture);
      return $"{x},{y},{z}";
    }
  }

  public static class ColorUtil
  {
    public static string ColorToHex(Color color)
    {
      var r = color.R.ToString("X2");
      var g = color.G.ToString("X2");
      var b = color.B.ToString("X2");

      return $"#{r}{g}{b}";
    }
  }
}