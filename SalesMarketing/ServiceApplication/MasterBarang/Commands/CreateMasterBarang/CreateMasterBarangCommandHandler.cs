using MediatR;
using SalesMarketing.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesMarketing.ServiceApplication.MasterBarang.Commands.CreateMasterBarang
{
    public class CreateMasterBarangCommandHandler : IRequestHandler<CreateMasterBarangCommand>
    {
        private readonly SalesMarketingContext _dbContext;

        public CreateMasterBarangCommandHandler(SalesMarketingContext dbContext)
        {
            _dbContext=dbContext;
        }

        public async Task<Unit> Handle(CreateMasterBarangCommand request, CancellationToken cancellationToken)
        {
            var mstBarang = Domain.MasterBarang.Create(request.NamaBarang, request.NomorRangka, request.NomorMesin, request.Merek
                 , request.KapasitasMesin, request.HargaOff, request.BBn, request.TahunPerakitan, request.TypeKendaraan);

            await _dbContext.MasterBarang.AddAsync(mstBarang);
            await _dbContext.SaveChangesAsync();

            return Unit.Value;

        }
    }
}
