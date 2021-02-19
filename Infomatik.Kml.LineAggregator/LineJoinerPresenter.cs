// (C) 2020 Infomatik - Felix Almesberger

using System;
using System.IO;
using System.Threading.Tasks;

namespace Infomatik.Kml.LineAggregator
{
  public class LineJoinerPresenter
  {
    private readonly IPolylineWriter writer;
    private readonly IPolylineReader reader;

    public ILineJoinerView View { get; set; }

    public LineJoinerPresenter(IPolylineReader reader, IPolylineWriter writer)
    {
      this.reader = reader ?? throw new ArgumentNullException(nameof(reader));
      this.writer = writer ?? throw new ArgumentNullException(nameof(writer));
    }

    public void Execute()
    {
      
      if(this.View is null)
        throw new ArgumentNullException(nameof(this.View));

      try
      {
        this.ValidateView();
        this.View.IsBusy = true;

        var polylines = this.reader.Read(this.View.Source);

        var joined = new PolylineJoiner(polylines).Execute();

        this.writer.UseElevation = this.View.UseElevation;

        if (this.writer is IStylablePolylineWriter stylable)
        {
          stylable.PolylineColor = this.View.LineColor;
          stylable.PolylineWidth = this.View.LineWidth;
        }

        this.writer.Write(joined, this.View.Destination);

        this.View.ShowMessage("Fertig!");
      }
      catch (Exception ex)
      {
        this.View.ShowError(ex.Message);
      }
      finally
      {
        this.View.IsBusy = false;
      }
    }

    public Task ExecuteAsync()
      => Task.Run(this.Execute);

    private void ValidateView()
    {
      if(!File.Exists(this.View.Source))
        throw new Exception("Es muss eine Quelle gewählt sein");

      if(string.IsNullOrWhiteSpace(this.View.Destination))
        throw new Exception("Es muss ein Ziel gewählt sein");
    }
  }
}