using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Mod7Overloadingdemo
{
    internal class Service
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; } 
        public bool IsRunning { get; set; }
        public Service () // constructor
        {
            ServiceId = 100;
            ServiceName = string.Empty;
            IsRunning = false;
        }
        // overloaded constructor
        public Service(int serviceId)
        {
            ServiceId = serviceId;
        }
        // method overloading 
        public void StartService (int serviceId)
        {
            //logic to start
            IsRunning = true;
        }
        public void StartService(string serviceName)
        {
            IsRunning = true;
        }
        public void StartService(int serviceId, string serviceName)
        {
            IsRunning = true;
        }
    }
}
