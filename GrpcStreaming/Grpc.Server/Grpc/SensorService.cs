using Grpc.Core;
using Grpc.Server.Grpc.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Grpc.Server.Grpc
{
    public class SensorService : Sensor.SensorBase
    {
        public override Task<SensorResponse> GetSignal(SensorRequest request, ServerCallContext context)
        {
            return Task.FromResult(new SensorResponse() { Name = "MySensor From Server" });
        }
    }

}
