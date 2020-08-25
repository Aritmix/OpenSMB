using System;
using System.Collections.Generic;
using System.Text;

namespace Smb.Core.Messages
{
    public class SMB2Message
    {

    }

    public abstract class Message<T> //: Smb2SinglePacket where T : struct
    {
        public byte[] Buffer = new byte[0];

        public T PayLoad;

        //public override byte[] ToBytes()
        //{
        //    return ArrayUtility.ConcatenateArrays(
        //        TypeMarshal.ToBytes(this.Header),
        //        TypeMarshal.ToBytes(this.PayLoad),
        //        Buffer != null ? Buffer : new byte[0],
        //        Padding);
        //}

        //internal override void FromBytes(byte[] data, out int consumedLen, out int expectedLen)
        //{
        //    consumedLen = 0;
        //    this.Header = TypeMarshal.ToStruct<Packet_Header>(data, ref consumedLen);
        //    this.PayLoad = TypeMarshal.ToStruct<T>(data, ref consumedLen);

        //    var packetBuffer = this as IPacketBuffer;
        //    if (packetBuffer != null)
        //    {
        //        int bufferLength = (int)packetBuffer.BufferLength;
        //        this.Buffer = data.Skip(consumedLen).Take(bufferLength).ToArray();
        //        consumedLen += bufferLength;
        //    }
        //    // The remained bytes are padding.
        //    this.Padding = new byte[data.Length - consumedLen];
        //    expectedLen = 0;
        //}

    }
}
