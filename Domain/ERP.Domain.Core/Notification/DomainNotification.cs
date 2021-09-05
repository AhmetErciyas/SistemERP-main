using System;
using System.Collections.Generic;
using System.Linq;

namespace ERP.Domain.Core
{
    public class DomainNotification : BaseEvent
    {
        public Guid DomainNotificationId { get; private set; }
        public string Key { get; private set; }
        public List<string> Values { get; private set; }

        public DomainNotification(string key, string value)
        {
            DomainNotificationId = Guid.NewGuid();
            Key = key;
            Values = new List<string>()
            {
                value
            };
        }

        public DomainNotification(string key, string[] values)
        {
            DomainNotificationId = Guid.NewGuid();
            Key = key;
            Values = values.ToList();
        }

        public DomainNotification(string key, Exception exception)
        {
            DomainNotificationId = Guid.NewGuid();
            Key = key;
            //mongodb log olarak kaydetdebilirliz
            Values = new List<string>()
            {
                exception.Message,
            };
            if (exception.InnerException != null)
            {
                Values.Add(exception.InnerException.Message);
            }
        }
    }
}