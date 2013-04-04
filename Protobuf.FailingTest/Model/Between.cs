using System;
using ProtoBuf;

namespace Protobuf.FailingTest.Model
{
    [Serializable]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    public class Between
        : Threshold
    {
        public override bool IsValidFor(DateTime now, DateTime date)
        {
            if (Duration == TimeSpan.FromMilliseconds(-1) || Duration == TimeSpan.FromSeconds(0)) return true;
            return date >= now.Subtract(Duration) && date <= now
                || date >= now && date <= now.Add(Duration);
        }
    }
}
