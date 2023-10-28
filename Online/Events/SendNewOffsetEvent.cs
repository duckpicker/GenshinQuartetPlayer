using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuartetPlayer.Online.Events
{
    public class SendNewOffsetEvent : BaseEvent
    {
        public int ID { get; set; }
        public int Offset { get; set; }
        public SendNewOffsetEvent(int iD, int offset)
        {
            ID = iD;
            Offset = offset;
        }
    }
}
