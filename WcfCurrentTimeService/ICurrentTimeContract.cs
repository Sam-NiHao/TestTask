using System.ServiceModel;

namespace WcfCurrentTimeService
{
    [ServiceContract]
    public interface ICurrentTimeContract
    {
        [OperationContract]
        string GetData();
    }
}
