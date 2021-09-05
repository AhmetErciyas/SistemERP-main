using ERP.Data.Entities;
using ERP.Data.Interfaces;
using ERP.Domain.Core;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ERP.Domain.Commands.IzinGrup
{
    public class IzinGrupListeleQueryQueryHandler : BaseQueryHandler, IRequestHandler<IzinGrupListeleQuery, List<izinGrubu>>
    {
        private readonly IIzinGrubuRepository _izinGrupRepository;

        public IzinGrupListeleQueryQueryHandler(
            IMediatorHandler mediator,
            INotificationHandler<DomainNotification> notifications,
            IIzinGrubuRepository izinGrupRepository) : base(mediator, notifications)
        {
            _izinGrupRepository = izinGrupRepository;
        }

        public async Task<List<Data.Entities.izinGrubu>> Handle(IzinGrupListeleQuery request, CancellationToken cancellationToken)
        {
            return await _izinGrupRepository.GetAsync();
        }

        
    }
}

