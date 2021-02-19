using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Infomatik.Kml.LineAggregator
{
  public class Polyline3d : IEnumerable<Point3d>
  {
    public Polyline3d(IEnumerable<Point3d> points = null)
    {
      this.Vertices = points?.ToList() ?? new List<Point3d>();
    }

    public IList<Point3d> Vertices { get; set; }

    public Point3d Start => this.Vertices.First();
    public Point3d End => this.Vertices.Last();

    public Polyline3d Concat(Polyline3d other)
    {
      if (this.End == other.Start)
      {
        return new Polyline3d()
        {
          Vertices = this.Vertices
                         .Except(new[] { this.End })
                         .Concat(other.Vertices)
                         .ToList()
        };
      }
      else if (this.Start == other.End)
      {
        return new Polyline3d()
        {
          Vertices = other.Vertices
                          .Except(new[] { other.End })
                          .Concat(this.Vertices)
                          .ToList()
        };
      }
      else
      {
        return new Polyline3d()
        {
          Vertices = this.Vertices
                         .Concat(other.Vertices)
                         .ToList()
                         .ToList()
        };
      }
    }

    public void Add(Point3d point)
    {
      this.Vertices.Add(point);
    }

    public bool IsTouching(Polyline3d other)
    {
      if (this.IsTouchingStart(other))
        return true;

      if (this.IsTouchingEnd(other))
        return true;
  
      return false;
    }

    public bool IsTouchingStart(Polyline3d other)
    {
      if (this.Start == other.End)
        return true;

      if (this.Start == other.Start)
        return true;

      return false;
    }

    public bool IsTouchingEnd(Polyline3d other)
    {
      if (this.End == other.Start)
        return true;

      if (this.End == other.End)
        return true;

      return false;
    }

    public IEnumerator<Point3d> GetEnumerator()
    {
      return this.Vertices.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return this.GetEnumerator();
    }

    public Point3d this[int index] => this.Vertices[index];

    public override string ToString()
    {
      if (this.Vertices.Any())
        return $"Start: {this.Start}, End: {this.End}";
      else
        return "No Vertices";
    } 
  }
}