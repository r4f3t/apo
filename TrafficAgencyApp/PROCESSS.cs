namespace TrafficAgencyApp
{
    partial class Program
    {
        class PROCESSS
        {
            IProcessWork processWork;
            public PROCESSS(IProcessWork _processWork) {
                this.processWork = _processWork;
            }
            public void AttachCase() {
                processWork.DBWrite();
            }
        }
    }
}
