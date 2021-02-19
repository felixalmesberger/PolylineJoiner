// (C) 2020 Infomatik - Felix Almesberger

using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Xunit;

namespace Infomatik.Kml.LineAggregator.Tests
{
  public class ColorUtilTests
  {
    [Theory]
    [ClassData(typeof(ColorUtilTestData))]
    public void Color_To_Hex_Works(Color color, string expected)
    {
      Assert.True(string.Equals(expected, ColorUtil.ColorToHex(color), StringComparison.CurrentCultureIgnoreCase));
    }

    private class ColorUtilTestData : IEnumerable<object[]>
    {
      public IEnumerator<object[]> GetEnumerator()
      {
        yield return new object[] { Color.Black, "#000000" };
        yield return new object[] { Color.White, "#ffffff" };
        yield return new object[] { Color.Red, "#ff0000" };
        yield return new object[] { Color.FromArgb(00,255,00), "#00ff00" };
        yield return new object[] { Color.Blue, "#0000ff" };

      }

      IEnumerator IEnumerable.GetEnumerator()
      {
        return this.GetEnumerator();
      }
    }
  }
}