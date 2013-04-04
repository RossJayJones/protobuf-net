using System.Diagnostics;
using ProtoBuf.Meta;
using Protobuf.FailingTest.Aritfacts;
using Protobuf.FailingTest.Model;

namespace Protobuf.FailingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Works();

            ThrowsStackOverflowException();
        }

        private static void Works()
        {
            var original = new RouteInstance
            {
                Termination = new TerminateOnArrival
                {
                    Threshold = new Threshold()
                }
            };

            var serializer = new ProtoSerializer(RuntimeTypeModel.Default);

            var serialzed = serializer.Serialize(original);

            Debug.Assert(serialzed != null);

            var deserialized = serializer.Deserialize<RouteInstance>(serialzed);

            Debug.Assert(deserialized.Termination.GetType() == typeof(TerminateOnArrival));
        }

        private static void ThrowsStackOverflowException()
        {
            var original = new RouteInstance
            {
                Termination = new TerminateOnArrival
                {
                    Threshold = new Outside()
                }
            };

            var serializer = new ProtoSerializer(RuntimeTypeModel.Default);

            var serialzed = serializer.Serialize(original);

            Debug.Assert(serialzed != null);

            var deserialized = serializer.Deserialize<RouteInstance>(serialzed);

            Debug.Assert(deserialized.Termination.GetType() == typeof(TerminateOnArrival));
        }
    }
}
