using System;
using RevStackCore.Pattern;

namespace RevStackCore.Identity.Mvc
{
    public class KeyValueItem
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public class NotifyMessage : KeyValueItem, IEntity<string>
    {
        public string Id { get; set; }
        public string KeyId { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public NotifyMessage()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}
