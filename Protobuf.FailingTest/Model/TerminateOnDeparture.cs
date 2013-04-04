using System;
using ProtoBuf;

namespace Protobuf.FailingTest.Model
{
    [Serializable]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class TerminateOnDeparture
        : TerminationStrategy
    {
        public TerminateOnDeparture()
        {
            Threshold = new NoThreshold();
        }

        public override bool Terminates(TerminationData data)
        {
            return false;
        }
    }
}
