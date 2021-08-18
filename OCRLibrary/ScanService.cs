using System.Collections.Generic;
using System.IO;
using Tesseract;

namespace OCRLibrary
{
    public class ScanService
    {
        private List<string> texte;

        public void MachScan()
        {
            texte = new List<string>();

            GibCardText("name.tiff");
            GibCardText("text.tiff");
        }

        private void GibCardText(string fileName)
        {
            var imagepath = Directory.GetCurrentDirectory() + $@"\Assets\{fileName}";

            using var engine = new TesseractEngine(@"./Tessdata", "eng", EngineMode.Default);
            using var image  = Pix.LoadFromFile(imagepath);
            using var page = engine.Process(image);

            texte.Add(page.GetText());
        }
    }
}