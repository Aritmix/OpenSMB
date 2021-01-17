using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Smb.Core.Shared
{
    public static class BitConverterExtension
    {
        public static Byte[] GetLittleEndianBytes(this String str)
        {
            Byte[] bytes = null;
            if (BitConverter.IsLittleEndian)
            {
                bytes = Encoding.Unicode.GetBytes(str);
            }
            else
            {
                bytes = Encoding.BigEndianUnicode.GetBytes(str);
            }
            return bytes;
        }

        public static Byte[] GetLittleEndianBytes(this UInt32 number)
        {
            Byte[] bytes = BitConverter.GetBytes(number);
            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }
            return bytes;
        }

        public static Byte[] GetLittleEndianBytes(this Int32 number)
        {
            Byte[] bytes = BitConverter.GetBytes(number);
            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }
            return bytes;
        }

        public static Byte[] GetLittleEndianBytes(this UInt64 number)
        {
            Byte[] bytes = BitConverter.GetBytes(number);
            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }
            return bytes;
        }
        public static Byte[] GetLittleEndianBytes(this Int64 number)
        {
            Byte[] bytes = BitConverter.GetBytes(number);
            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(bytes);
            }
            return bytes;
        }
        public static Byte[] GetBytes<T>(T obj) where T : struct
        {
            int size = Marshal.SizeOf(obj);
            byte[] arr = new byte[size];
            IntPtr ptr = Marshal.AllocHGlobal(size);
            Marshal.StructureToPtr(obj, ptr, true);
            Marshal.Copy(ptr, arr, 0, size);
            Marshal.FreeHGlobal(ptr);
            return arr;
        }

        public static T FromBytes<T>(byte[] byteArr) where T : struct
        {
            T obj = default;
            int size = Marshal.SizeOf(obj);
            IntPtr ptr = Marshal.AllocHGlobal(size);
            Marshal.Copy(byteArr, 0, ptr, size);
            obj = (T)Marshal.PtrToStructure(ptr, obj.GetType());
            Marshal.FreeHGlobal(ptr);
            return obj;
        }
    }
}
