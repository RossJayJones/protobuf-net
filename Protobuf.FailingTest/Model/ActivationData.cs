using System;
using ProtoBuf;

namespace Protobuf.FailingTest.Model
{
    [Serializable]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class ActivationData
    {
        public ActivationData(RouteInstance routeInstance)
        {
            RouteInstance = routeInstance;
        }

        public readonly RouteInstance RouteInstance;
    }
}
