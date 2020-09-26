using SoulsFormats;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hknpShapeTagCodec : hkReferencedObject
    {
        public enum Type
        {
            TYPE_NULL = 0,
            TYPE_MATERIAL_PALETTE = 1,
            TYPE_UFM = 2,
            TYPE_USER = 3,
        }
        
        public Type m_type;
        
        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_type = (Type)br.ReadByte();
            br.ReadUInt32();
            br.ReadUInt16();
            br.ReadByte();
        }
        
        public override void Write(BinaryWriterEx bw)
        {
            base.Write(bw);
            bw.WriteUInt32(0);
            bw.WriteUInt16(0);
            bw.WriteByte(0);
        }
    }
}