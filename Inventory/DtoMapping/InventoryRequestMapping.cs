using Inventory.Dto;
using Inventory.ServiceApplication.MasterBarang.Commands.CreateMasterBarang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.DtoMapping
{
    public static class InventoryRequestMapping
    {
        public static CreateMasterBarangCommand ToCommand(this CreateMasterBarangRequest model)
        {
            return new CreateMasterBarangCommand
            {
                NamaBarang = model.NamaBarang,
                NomorRangka = model.NomorRangka,
                NomorMesin =model.NomorMesin,
                Merek = model.Merek,
                KapasitasMesin = model.KapasitasMesin,
                HargaOff = model.HargaOff,
                BBn = model.BBn,
                TahunPerakitan = model.TahunPerakitan,
                TypeKendaraan  = model.TypeKendaraan,
                UserName = model.UserNameInput,
                USerNameId = model.UserNameId

            };
        }

    }
}
