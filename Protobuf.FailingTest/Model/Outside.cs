using System;
using ProtoBuf;

namespace Protobuf.FailingTest.Model
{
    [Serializable]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class Outside
        : Threshold
    {        
        public override bool IsValidFor(DateTime now, DateTime date)
        {
            if (Duration == TimeSpan.FromMilliseconds(-1)) return true;
            return date >= now.Subtract(Duration) || date <= now.Add(Duration);
        }
    }
}
