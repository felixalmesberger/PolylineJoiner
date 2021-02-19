// (C) 2020 Infomatik - Felix Almesberger

using System.Collections.Generic;
using System.Runtime.InteropServices;
using Xunit;

namespace Infomatik.Kml.LineAggregator.Tests
{
  public class Polyline3dTests
  {
    [Fact]
    public void Joining_Touching_Polylines_Is_Working()
    {
      // Arrange
      var line1_point1 = new Point3d(1, 2, 3);
      var line1_point2 = new Point3d(2, 3, 4);

      var polyline1 = new Polyline3d(new[] { line1_point1, line1_point2 });

      var line2_point1 = new Point3d(2, 3, 4);
      var line2_point2 = new Point3d(3, 4, 5);

      var polyline2 = new Polyline3d(new[] { line2_point1, line2_point2 });

      // Act
      var joined = polyline1.Concat(polyline2);

      // Assert
      Assert.True(joined[0] == line1_point1);
      Assert.True(joined[1] == line2_point1);
      Assert.True(joined[2] == line2_point2);
    }

    [Fact]
    public void Touching_Polylines_Are_Recognized()
    {
      // Arrange
      var line1_point1 = new Point3d(1, 2, 3);
      var line1_point2 = new Point3d(2, 3, 4);

      var polyline1 = new Polyline3d(new[] { line1_point1, line1_point2 });

      var line2_point1 = new Point3d(2, 3, 4);
      var line2_point2 = new Point3d(3, 4, 5);

      var polyline2 = new Polyline3d(new[] { line2_point1, line2_point2 });

      // Act
      var isTouching = polyline1.IsTouching(polyline2);

      // Assert
      Assert.True(isTouching);
    }
  }
}