using ROOTNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileAndHistogramTest
{
    class Program
    {
        /// <summary>
        /// Simple test to use the MSBuild guys in a special targets file.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var vs = Environment.GetEnvironmentVariables();
            foreach (var v in vs.Keys.Cast<string>().OrderBy(s => s))
            {
                Console.WriteLine(v);
            }

            var f = NTFile.Open("junk.root", "RECREATE");
            var h = new NTH1F("hi", "there", 10, 0.0, 1.0);
            h.Fill(0.5);
            f.Write();
            f.Close();
        }
    }
}
