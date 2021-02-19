using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Infomatik.Kml.LineAggregator.Tests
{
  public class Point3dTests
  {
    [Fact]
    public void Points_With_Same_Coordinates_Are_Equal()
    {
      // Arrange
      var p1 = new Point3d(1, 2, 3);
      var p2 = new Point3d(1,2,3);

      // Act
      var isEqual = p1 == p2;

      // Assert
      Assert.True(isEqual);
    }

    [Fact]
    public void Points_With_Different_Coordinates_Are_Not_Equal()
    {
      // Arrange
      var p1 = new Point3d(1, 2, 3);
      var p2 = new Point3d(0,0,0);

      // Act
      var isEqual = p1 == p2;

      // Assert
      Assert.False(isEqual);
    }
  }
}
