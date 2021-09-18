using System;

namespace WcfCurrentTimeService
{
    public class CurrentTimeService : ICurrentTimeContract
    {
        public string GetData() => DateTime.Now.ToString("hh:mm:ss");
    }
}
