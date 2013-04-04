using System;
using ProtoBuf;

namespace Protobuf.FailingTest.Model
{
    [Serializable]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class RouteInstance
    {
        public ActivationStrategy Activation { get; set; }

        public TerminationStrategy Termination { get; set; }
    }
}