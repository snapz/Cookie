//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Types.Game.Interactive.Skill
{
    using Cookie.IO;


    public class SkillActionDescriptionCraft : SkillActionDescription
    {
        
        public new const short ProtocolId = 100;
        
        public override short TypeID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private byte m_probability;
        
        public virtual byte Probability
        {
            get
            {
                return m_probability;
            }
            set
            {
                m_probability = value;
            }
        }
        
        public SkillActionDescriptionCraft(byte probability)
        {
            m_probability = probability;
        }
        
        public SkillActionDescriptionCraft()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            base.Serialize(writer);
            writer.WriteByte(m_probability);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            base.Deserialize(reader);
            m_probability = reader.ReadByte();
        }
    }
}