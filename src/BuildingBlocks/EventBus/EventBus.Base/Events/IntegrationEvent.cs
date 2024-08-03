using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBus.Base.Events
{
    public class IntegrationEvent
    {
        [JsonProperty]
        public Guid Id { get; private set; }

        [JsonProperty]
        public DateTime CreatedDate { get; private set; }


        public IntegrationEvent()
        {
            Id = Guid.NewGuid();
            CreatedDate = DateTime.Now;
        }

        [JsonConstructor]
        public IntegrationEvent(Guid ıd, DateTime createdDate)
        {
            Id = ıd;
            CreatedDate = createdDate;
        }
    }
}
// Jsondan set edildiği zaman dışardan gelen serilization ve desirlezition id ve createddate parametlerini buradan alıp set edildiği zaman dışardan gelen id ve created değeri alıp set edelim diye yaptık
