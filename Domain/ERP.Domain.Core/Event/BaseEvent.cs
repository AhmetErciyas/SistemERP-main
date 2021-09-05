using MediatR;
using System;

namespace ERP.Domain.Core
{
    public abstract class BaseEvent : INotification
    {
        public DateTime Timestamp { get; private set; }
        //mongoya event atmak için kullanıyor log tutmak için
        protected BaseEvent()
        {
            Timestamp = DateTime.Now;
        }
    }
}
