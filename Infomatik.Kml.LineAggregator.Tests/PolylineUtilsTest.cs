// (C) 2020 Infomatik - Felix Almesberger

using System.Collections.Generic;
using Xunit;

namespace Infomatik.Kml.LineAggregator.Tests
{
  public class PolylineUtilsTest
  {
    [Fact]
    public void Join_All_Is_Working()
    {
      //// Arrange
      var p1 = new Point3d(0, 1, 2);
      var p2 = new Point3d(3, 4, 5);
      var p3 = new Point3d(6, 7, 8);

      var p4 = new Point3d(7, 8, 9);
      var p5 = new Point3d(9, 10, 11);
      var p6 = new Point3d(11, 12, 13);

      var polyline1 = new Polyline3d(new[] { p1, p2 });
      var polyline2 = new Polyline3d(new[] { p2, p3 });

      var polyline3 = new Polyline3d(new[] { p4, p5 });
      var polyline4 = new Polyline3d(new[] { p5, p6 });

      // Act
      var polylines = new[] { polyline1, polyline2, polyline3, polyline4 };

      var actual = new PolylineJoiner(polylines).Execute();

      // Assert
      Assert.True(actual.Count == 2);

      this.AssertPolylineIsMatching(actual[0], p1, p2, p3);
      this.AssertPolylineIsMatching(actual[1], p4, p5, p6);
    }

    private void AssertPolylineIsMatching(Polyline3d polyline, params Point3d[] expected)
    {
      for (var i = 0; i < expected.Length; i++)
        Assert.Equal(polyline[i], expected[i]);
    }
  }
}