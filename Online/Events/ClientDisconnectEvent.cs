using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartetPlayer.Online.Events
{
    public class ClientDisconnectEvent : BaseEvent
    {
        public int ClientID { get; set; }

        public ClientDisconnectEvent(int id) { 
            ClientID = id;
        }

        public ClientDisconnectEvent() { }
    }
}
