using IntegrationEvent;
using Inventory.EventBus;
using Inventory.Infrastructure.Context;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.ServiceApplication.MasterBarang.Commands.CreateMasterBarang
{
    public class CreateMasterBarangCommandHandler : IRequestHandler<CreateMasterBarangCommand, Guid>
    {
        private readonly IInventoryEventBus _eventBus;
        private readonly InventoryContext _context;

        public CreateMasterBarangCommandHandler(IInventoryEventBus eventBus, InventoryContext context)
        {
            _eventBus=eventBus;
            _context=context;
        }

        public async Task<Guid> Handle(CreateMasterBarangCommand request, CancellationToken cancellationToken)
        {
            var mstBarang = Domain.MasterBarang.Create(request.NamaBarang, request.NomorRangka, request.NomorMesin, request.Merek
                , request.KapasitasMesin, request.HargaOff, request.BBn, request.TahunPerakitan, request.TypeKendaraan, request.UserName, request.USerNameId);

            await _context.MasterBarang.AddAsync(mstBarang);


            await _eventBus.Publish(new MasterBarangAddedIntegrationEvent(
                    request.NamaBarang,
                  request.NomorRangka,
                  request.NomorMesin,
                  request.Merek,
                  request.KapasitasMesin,
                  request.HargaOff,
                  request.BBn,
                  request.TahunPerakitan,
                  request.TypeKendaraan
                  ) );

            await _context.SaveChangesAsync();

            //await _mediator.Publish(new CreateMasterBarangCreatedNotification {
            //    BBN = request.BBn,
            //    HargaOffTheRoad = request.HargaOff,
            //    KapasitasMesin = request.KapasitasMesin,
            //    Merek = request.Merek,
            //    NamaBarang = request.NamaBarang,
            //    NomorMesin = request.NomorMesin,
            //    NomorRangka = request.NomorRangka,
            //    TahunPerakitan = request.TahunPerakitan,
            //    TypeKendaraan = request.TypeKendaraan
            //}, cancellationToken);


            //await _eventsBus.Publish(new MasterBarangAddedIntegrationEvent(
            //     Guid.NewGuid(),
            //     DateTime.Now,
            //     request.NamaBarang,
            //     request.NomorRangka,
            //     request.NomorMesin,
            //     request.Merek,
            //     request.KapasitasMesin,
            //     request.HargaOff,
            //     request.BBn,
            //     request.TahunPerakitan,
            //     request.TypeKendaraan

            //   ));
            //await _mediator.Publish(new CreateMasterBarangCreated
            //{
            //    BBN = request.BBn,
            //    HargaOffTheRoad = request.HargaOff,
            //    KapasitasMesin = request.KapasitasMesin,
            //    Merek = request.Merek,
            //    NamaBarang = request.NamaBarang,
            //    NomorMesin = request.NomorMesin,
            //    NomorRangka = request.NomorRangka,
            //    TahunPerakitan = request.TahunPerakitan,
            //    TypeKendaraan = request.TypeKendaraan
            //}, cancellationToken);

            return mstBarang.MasterBarangId;
        }
    }
}
