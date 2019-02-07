using System;

namespace TrafficAgencyApp
{
    partial class Program
    {
        class PoliceReport : IPoliceReport
        {
            public void DBWrite()
            {
                Console.WriteLine(getPoliceReport()+" , "+getWitnessReport()+"Veritabanına Yazıldı.");
            }

            public string getPoliceReport()
            {
                return "Polis Raporu";
            }

            public string getWitnessReport()
            {
                return "Tanık Raporu";
            }
        }
    }
}
