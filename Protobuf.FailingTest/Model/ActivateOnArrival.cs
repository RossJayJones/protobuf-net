using System;
using ProtoBuf;

namespace Protobuf.FailingTest.Model
{
    [Serializable]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class ActivateOnArrival
        : ActivationStrategy
    {
        public override bool Activates(ActivationData data)
        {
            return false;
        }
    }
}
