using System;
using ProtoBuf;

namespace Protobuf.FailingTest.Model
{
    [Serializable]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class TerminateOnArrival
        : TerminationStrategy
    {
        public TerminateOnArrival()
        {
            Threshold = new NoThreshold();
        }
        
        public override bool Terminates(TerminationData data)
        {
            return false;
        }
    }
}
