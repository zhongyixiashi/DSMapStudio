using SoulsFormats;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public class hkbGeneratorSyncInfoSyncPoint : IHavokObject
    {
        public int m_id;
        public float m_time;
        
        public virtual void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            m_id = br.ReadInt32();
            m_time = br.ReadSingle();
        }
        
        public virtual void Write(BinaryWriterEx bw)
        {
            bw.WriteInt32(m_id);
            bw.WriteSingle(m_time);
        }
    }
}