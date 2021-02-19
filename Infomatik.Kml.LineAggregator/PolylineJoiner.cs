using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infomatik.Kml.LineAggregator
{
  public class PolylineJoiner
  {

    #region fields

    private IList<Polyline3d> polylines;

    #endregion

    public PolylineJoiner(IList<Polyline3d> polylines)
    {
      this.polylines = polylines?.ToList() ?? throw new ArgumentNullException(nameof(polylines));
    }

    public IList<Polyline3d> Execute()
    {
      for (var i = 0; i < polylines.Count(); i++)
        while (this.TryJoin(i)) ;

      return this.polylines;
    }

    private bool TryJoin(int index)
    {
      var current = this.polylines[index];

      var candidate = this.EnumerateFromIndex(index)
                                   .FirstOrDefault(x => current.IsTouching(x));

      if (candidate is null)
        return false;

      var joined = current.Concat(candidate);
      this.polylines[index] = joined;
      this.polylines.Remove(candidate);

      return true;
    }

    private IEnumerable<Polyline3d> EnumerateFromIndex(int index)
    {
      foreach (var item in this.polylines.Skip(index + 1))
        yield return item;

      foreach (var item in this.polylines.Take(index - 1))
        yield return item;
    }

    public Task<IList<Polyline3d>> ExecuteAsync()
      => Task.Run(this.Execute);
  }
}