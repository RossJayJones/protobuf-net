using System;
using ProtoBuf;

namespace Protobuf.FailingTest.Model
{
    [Serializable]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class NoThreshold
        : Threshold
    {
        public override bool IsValidFor(DateTime now, DateTime date)
        {
            return true;
        }
    }
}
