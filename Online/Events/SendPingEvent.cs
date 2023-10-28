using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartetPlayer.Online.Events
{
    public class SendPingEvent : BaseEvent
    {
        public int ClientID { get; set; }
        public int NewPing { get; set; }

        public SendPingEvent(int id, int newPing)
        {
            ClientID = id;
            NewPing = newPing;
        }
    }
}
