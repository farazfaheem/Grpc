using Grpc.Net.Client;
using Grpc.Server.Grpc.Contracts;
using System;

namespace Grpc.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Sensor.SensorClient(channel);
            var response = client.GetSignal(new SensorRequest());
            Console.WriteLine($"Response:{response.Name}");
            Console.ReadKey();

        }
    }
}
