//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Connection
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class SelectedServerRefusedMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 41;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        private ushort m_serverId;
        
        public virtual ushort ServerId
        {
            get
            {
                return m_serverId;
            }
            set
            {
                m_serverId = value;
            }
        }
        
        private byte m_error;
        
        public virtual byte Error
        {
            get
            {
                return m_error;
            }
            set
            {
                m_error = value;
            }
        }
        
        private byte m_serverStatus;
        
        public virtual byte ServerStatus
        {
            get
            {
                return m_serverStatus;
            }
            set
            {
                m_serverStatus = value;
            }
        }
        
        public SelectedServerRefusedMessage(ushort serverId, byte error, byte serverStatus)
        {
            m_serverId = serverId;
            m_error = error;
            m_serverStatus = serverStatus;
        }
        
        public SelectedServerRefusedMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
            writer.WriteVarUhShort(m_serverId);
            writer.WriteByte(m_error);
            writer.WriteByte(m_serverStatus);
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
            m_serverId = reader.ReadVarUhShort();
            m_error = reader.ReadByte();
            m_serverStatus = reader.ReadByte();
        }
    }
}
