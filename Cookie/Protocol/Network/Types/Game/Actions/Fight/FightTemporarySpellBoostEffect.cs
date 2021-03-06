//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Types.Game.Actions.Fight
{
    using Cookie.IO;


    public class FightTemporarySpellBoostEffect : FightTemporaryBoostEffect
    {
        
        public new const short ProtocolId = 207;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_boostedSpellId;
        
        public virtual ushort BoostedSpellId
        {
            get
            {
                return m_boostedSpellId;
            }
            set
            {
                m_boostedSpellId = value;
            }
        }
        
        public FightTemporarySpellBoostEffect(ushort boostedSpellId)
        {
            m_boostedSpellId = boostedSpellId;
        }
        
        public FightTemporarySpellBoostEffect()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteVarUhShort(m_boostedSpellId);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_boostedSpellId = reader.ReadVarUhShort();
        }
    }
}
