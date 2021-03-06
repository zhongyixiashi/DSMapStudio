using SoulsFormats;
using System.Collections.Generic;
using System.Numerics;

namespace HKX2
{
    public partial class CustomTimeActGenerator : hkbGenerator
    {
        public override uint Signature { get => 1941718415; }
        
        public enum OffsetType
        {
            WeaponCategory = 10,
            IdleCategory = 11,
            Variable = 200,
            Float2Step = 201,
            Float3Step = 202,
            OffsetNone = 0,
        }
        
        public hkbGenerator m_generator;
        public OffsetType m_offsetType;
        public int m_taeId;
        public int m_valIndex;
        public float m_valRate;
        
        public override void Read(PackFileDeserializer des, BinaryReaderEx br)
        {
            base.Read(des, br);
            m_generator = des.ReadClassPointer<hkbGenerator>(br);
            m_offsetType = (OffsetType)br.ReadInt32();
            m_taeId = br.ReadInt32();
            m_valIndex = br.ReadInt32();
            m_valRate = br.ReadSingle();
            br.ReadUInt64();
            br.ReadUInt64();
        }
        
        public override void Write(PackFileSerializer s, BinaryWriterEx bw)
        {
            base.Write(s, bw);
            s.WriteClassPointer<hkbGenerator>(bw, m_generator);
            bw.WriteInt32((int)m_offsetType);
            bw.WriteInt32(m_taeId);
            bw.WriteInt32(m_valIndex);
            bw.WriteSingle(m_valRate);
            bw.WriteUInt64(0);
            bw.WriteUInt64(0);
        }
    }
}
