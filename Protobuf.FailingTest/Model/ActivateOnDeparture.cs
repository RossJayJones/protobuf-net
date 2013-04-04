using System;
using ProtoBuf;

namespace Protobuf.FailingTest.Model
{
    [Serializable]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class ActivateOnDeparture 
        : ActivationStrategy
    {
        public ActivateOnDeparture()
        {
            Threshold = new NoThreshold();
        }
        
        public override bool Activates(ActivationData data)
        {
            return false;
        }
    }
}
