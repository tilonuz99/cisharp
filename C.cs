using System;

namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
       var inputFile = new MediaFile {Filename = @"https://getmyfile.xyz/dl_2460314/Dildora_Niyozova_ft_Mirjalol_Yondi_dil_Egoist_soudtrack_dodasi_com.mp3"};
var outputFile = new MediaFile {Filename = @"C:\out.mp3"};

using (var engine = new Engine())
{
    engine.GetMetadata(inputFile);

    var options = new ConversionOptions();
    options.CutMedia(TimeSpan.FromSeconds(30), TimeSpan.FromSeconds(25));

    engine.Convert(inputFile, outputFile, options);
}
    }
  }
}
