using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficAgencyApp
{
    partial class Program
    {
        static void Main(string[] args)
        {
            HospitalReport hospitalReport = new HospitalReport();
            PROCESSS process = new PROCESSS(hospitalReport);
            process.AttachCase();

            PoliceReport policeReport = new PoliceReport();
            process = new PROCESSS(policeReport);
            process.AttachCase();

            Console.ReadKey();
        }
    }
}
