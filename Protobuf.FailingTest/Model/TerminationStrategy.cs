using System;
using ProtoBuf;

namespace Protobuf.FailingTest.Model
{
    [Serializable]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    [ProtoInclude(100, typeof(TerminateOnArrival))]
    [ProtoInclude(200, typeof(TerminateOnDeparture))]
    [ProtoInclude(300, typeof(ManualTermination))]
    public class TerminationStrategy
    {
        public TerminationStrategy()
        {
            Threshold = new Threshold();
        }

        public bool OnlyWhenAllStopsVisisted { get; set; }

        public Threshold Threshold { get; set; }

        public virtual bool Terminates(TerminationData data)
        {
            return false;
        }
    }
}
