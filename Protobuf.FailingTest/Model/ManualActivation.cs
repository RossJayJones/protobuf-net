using System;
using ProtoBuf;

namespace Protobuf.FailingTest.Model
{
    [Serializable]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class ManualActivation
        : ActivationStrategy
    {
        public override bool Activates(ActivationData data)
        {
            return false;
        }
    }
}