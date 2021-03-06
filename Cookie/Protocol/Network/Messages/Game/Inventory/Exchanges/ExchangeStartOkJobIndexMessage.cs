//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Inventory.Exchanges
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class ExchangeStartOkJobIndexMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 5819;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private List<System.UInt32> m_jobs;
        
        public virtual List<System.UInt32> Jobs
        {
            get
            {
                return m_jobs;
            }
            set
            {
                m_jobs = value;
            }
        }
        
        public ExchangeStartOkJobIndexMessage(List<System.UInt32> jobs)
        {
            m_jobs = jobs;
        }
        
        public ExchangeStartOkJobIndexMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteShort(((short)(m_jobs.Count)));
            int jobsIndex;
            for (jobsIndex = 0; (jobsIndex < m_jobs.Count); jobsIndex = (jobsIndex + 1))
            {
                writer.WriteVarUhInt(m_jobs[jobsIndex]);
            }
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            int jobsCount = reader.ReadUShort();
            int jobsIndex;
            m_jobs = new System.Collections.Generic.List<uint>();
            for (jobsIndex = 0; (jobsIndex < jobsCount); jobsIndex = (jobsIndex + 1))
            {
                m_jobs.Add(reader.ReadVarUhInt());
            }
        }
    }
}
