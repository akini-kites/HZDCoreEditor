using System;
using System.IO;
using Utility;

namespace Decima.DS
{
    using uint8 = System.Byte;

    [RTTI.Serializable(0x211FDC8FD3395464, GameType.DS)]
    public class GGUUID
    {
        [RTTI.Member(0, 0x0)] public uint8 Data0;
        [RTTI.Member(1, 0x1)] public uint8 Data1;
        [RTTI.Member(2, 0x2)] public uint8 Data2;
        [RTTI.Member(3, 0x3)] public uint8 Data3;
        [RTTI.Member(4, 0x4)] public uint8 Data4;
        [RTTI.Member(5, 0x5)] public uint8 Data5;
        [RTTI.Member(6, 0x6)] public uint8 Data6;
        [RTTI.Member(7, 0x7)] public uint8 Data7;
        [RTTI.Member(8, 0x8)] public uint8 Data8;
        [RTTI.Member(9, 0x9)] public uint8 Data9;
        [RTTI.Member(10, 0xA)] public uint8 Data10;
        [RTTI.Member(11, 0xB)] public uint8 Data11;
        [RTTI.Member(12, 0xC)] public uint8 Data12;
        [RTTI.Member(13, 0xD)] public uint8 Data13;
        [RTTI.Member(14, 0xE)] public uint8 Data14;
        [RTTI.Member(15, 0xF)] public uint8 Data15;

        public void ToData(BinaryWriter writer)
        {
            writer.Write(Data0);
            writer.Write(Data1);
            writer.Write(Data2);
            writer.Write(Data3);
            writer.Write(Data4);
            writer.Write(Data5);
            writer.Write(Data6);
            writer.Write(Data7);
            writer.Write(Data8);
            writer.Write(Data9);
            writer.Write(Data10);
            writer.Write(Data11);
            writer.Write(Data12);
            writer.Write(Data13);
            writer.Write(Data14);
            writer.Write(Data15);
        }

        public static GGUUID FromData(BinaryReader reader)
        {
            return FromData(reader.ReadBytesStrict(16));
        }

        public static GGUUID FromData(ReadOnlySpan<byte> data)
        {
            var x = new GGUUID();
            x.AssignFromData(data);

            return x;
        }

        private void AssignFromOther(GGUUID other)
        {
            // No unions. No marshalling. Assign each manually...
            Data0 = other.Data0;
            Data1 = other.Data1;
            Data2 = other.Data2;
            Data3 = other.Data3;
            Data4 = other.Data4;
            Data5 = other.Data5;
            Data6 = other.Data6;
            Data7 = other.Data7;
            Data8 = other.Data8;
            Data9 = other.Data9;
            Data10 = other.Data10;
            Data11 = other.Data11;
            Data12 = other.Data12;
            Data13 = other.Data13;
            Data14 = other.Data14;
            Data15 = other.Data15;
        }

        private void AssignFromData(ReadOnlySpan<byte> data)
        {
            Data0 = data[0];
            Data1 = data[1];
            Data2 = data[2];
            Data3 = data[3];
            Data4 = data[4];
            Data5 = data[5];
            Data6 = data[6];
            Data7 = data[7];
            Data8 = data[8];
            Data9 = data[9];
            Data10 = data[10];
            Data11 = data[11];
            Data12 = data[12];
            Data13 = data[13];
            Data14 = data[14];
            Data15 = data[15];
        }
    }
}
