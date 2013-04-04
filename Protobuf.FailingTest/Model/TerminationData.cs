using System;
using ProtoBuf;

namespace Protobuf.FailingTest.Model
{
    [Serializable]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public struct TerminationData
    {
        public TerminationData(RouteInstance routeInstance)
        {
            RouteInstance = routeInstance;
        }

        public readonly RouteInstance RouteInstance;
    }
}
