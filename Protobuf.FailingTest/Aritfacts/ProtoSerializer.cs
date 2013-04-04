using System;
using System.IO;
using ProtoBuf.Meta;

namespace Protobuf.FailingTest.Aritfacts
{
    public class ProtoSerializer
    {
        private readonly TypeModel _model;

        public ProtoSerializer(TypeModel model)
        {
            _model = model;
        }

        public byte[] Serialize(object instance)
        {
            using (var stream = new MemoryStream())
            {
                _model.Serialize(stream, instance);
                return stream.ToArray();
            }
        }

        public T Deserialize<T>(byte[] data)
        {
            return (T) Deserialize(data, typeof (T));
        }

        public object Deserialize(byte[] data, Type type)
        {
            using (var stream = new MemoryStream(data))
            {
                var result = _model.Deserialize(stream, null, type);
                return result;
            }
        }
    }
}