namespace Infomatik.Kml.LineAggregator
{
  public enum Dimensions
  {
    TwoD,
    ThreeD
  }

  public struct Point3d
  {

    public Point3d(double x, double y, double z)
    {
      this.X = x;
      this.Y = y;
      this.Z = z;
    }

    public double X { get; set; }
    public double Y { get; set; }
    public double Z { get; set; }

    public bool Equals(object obj)
    {
      if (!(obj is Point3d other))
        return false;

      if (this.X != other.X)
        return false;

      if (this.Y != other.Y)
        return false;

      if (this.Z != other.Z)
        return false;

      return true;
    }

    public override int GetHashCode()
    {
      return 397 ^ this.X.GetHashCode()
                 ^ this.Y.GetHashCode()
                 ^ this.Z.GetHashCode();
    }

    public static bool operator ==(Point3d a, Point3d b)
    {
      return a.Equals(b);
    }

    public static bool operator !=(Point3d a, Point3d b)
    {
      return !(a == b);
    }

    public override string ToString()
      => $"X: {this.X}, Y: {this.Y}, Z: {this.Z}";
  }
}