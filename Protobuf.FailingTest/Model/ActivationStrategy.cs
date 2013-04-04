using System;
using ProtoBuf;

namespace Protobuf.FailingTest.Model
{
    [Serializable]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    [ProtoInclude(100, typeof(ActivateOnArrival))]
    [ProtoInclude(200, typeof(ActivateOnDeparture))]
    [ProtoInclude(300, typeof(ManualActivation))]
    public abstract class ActivationStrategy
    {
        protected ActivationStrategy()
        {
            Threshold = new NoThreshold();
        }

        public Threshold Threshold { get; set; }

        public virtual bool Activates(ActivationData data)
        {
            return false;
        }
    }
}
