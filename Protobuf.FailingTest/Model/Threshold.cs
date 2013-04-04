using System;
using ProtoBuf;

namespace Protobuf.FailingTest.Model
{
    [Serializable]
    [ProtoContract(ImplicitFields = ImplicitFields.AllPublic)]
    [ProtoInclude(1000, typeof(Outside))]
    [ProtoInclude(2000, typeof(Between))]
    [ProtoInclude(3000, typeof(NoThreshold))]
    public class Threshold
    {
        public TimeSpan Duration { get; set; }
       
        public virtual bool IsValidFor(DateTime now, 
            DateTime date)
        {
            return true;
        }
    }
}
