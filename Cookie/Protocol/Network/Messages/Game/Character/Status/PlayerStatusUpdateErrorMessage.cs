//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cookie.Protocol.Network.Messages.Game.Character.Status
{
    using System.Collections.Generic;
    using Cookie.Protocol.Network.Messages;
    using Cookie.Protocol.Network.Types;
    using Cookie.IO;
    
    
    public class PlayerStatusUpdateErrorMessage : NetworkMessage
    {
        
        public const uint ProtocolId = 6385;
        
        public override uint MessageID
        {
            get
            {
                return ProtocolId;
            }
        }
        
        public PlayerStatusUpdateErrorMessage()
        {
        }
        
        public override void Serialize(ICustomDataOutput writer)
        {
        }
        
        public override void Deserialize(ICustomDataInput reader)
        {
        }
    }
}
