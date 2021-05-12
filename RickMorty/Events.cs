using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickMorty
{
    public enum EventType { Get,Use}
    public class Event
    {
        public EventType Type;
        public string TriggerPhrase;
        public Result EventResult;
        
        public Event(string triggerPhrase, EventType type,Result eventResult)
        {
            this.TriggerPhrase = triggerPhrase;
            this.Type = type;
            this.EventResult = eventResult;
        }
    }
}
