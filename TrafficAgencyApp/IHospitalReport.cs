namespace TrafficAgencyApp
{
    partial class Program
    {
        interface IHospitalReport :IProcessWork
        {
            string getCouncilReport();
            string getDoctorReport();
        }
    }
}
