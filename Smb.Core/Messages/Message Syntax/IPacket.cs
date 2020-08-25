namespace Smb.Core.Messages.Message.Packet
{
    public interface IPacket
    {
        byte[] ToBytes();
        void FromBytes(byte[] bytes);
    }
}