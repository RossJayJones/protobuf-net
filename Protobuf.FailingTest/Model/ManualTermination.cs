using System;
using ProtoBuf;

namespace Protobuf.FailingTest.Model
{
    [Serializable]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class ManualTermination
        : TerminationStrategy
    {
        public override bool Terminates(TerminationData data)
        {
            return false;
        }
    }
}
