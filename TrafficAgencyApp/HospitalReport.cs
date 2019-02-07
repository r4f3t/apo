using System;

namespace TrafficAgencyApp
{
    partial class Program
    {
        class HospitalReport : IHospitalReport
        {
            public void DBWrite()
            {
                Console.WriteLine(getCouncilReport()+" "+getDoctorReport()+"Veri Tabanına Yazıldı");
            }

            public string getCouncilReport()
            {
                return "Heyet Raporu";
            }

            public string getDoctorReport()
            {
                return "Doktor Raporu";
            }
        }
    }
}
