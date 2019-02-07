namespace TrafficAgencyApp
{
    partial class Program
    {
        interface IPoliceReport : IProcessWork
        {
            string getPoliceReport();
            string getWitnessReport();
        }
    }
}
