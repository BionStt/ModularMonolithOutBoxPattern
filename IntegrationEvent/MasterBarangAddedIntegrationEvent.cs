using DDD.Event;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegrationEvent
{
    public class MasterBarangAddedIntegrationEvent: INotification, IIntegrationEvent
    {
        public string NamaBarang { get; set; }
        public string NomorRangka { get; set; }
        public string NomorMesin { get; set; }
        public string Merek { get; set; }
        public string KapasitasMesin { get; set; }
        public decimal? HargaOffTheRoad { get; set; }
        public decimal? BBN { get; set; }
        public string TahunPerakitan { get; set; }
        public string TypeKendaraan { get; set; }

        public MasterBarangAddedIntegrationEvent(string namaBarang, string nomorRangka, string nomorMesin, string merek, string kapasitasMesin, decimal? hargaOffTheRoad, decimal? bBN, string tahunPerakitan, string typeKendaraan) 
        {
            NamaBarang=namaBarang;
            NomorRangka=nomorRangka;
            NomorMesin=nomorMesin;
            Merek=merek;
            KapasitasMesin=kapasitasMesin;
            HargaOffTheRoad=hargaOffTheRoad;
            BBN=bBN;
            TahunPerakitan=tahunPerakitan;
            TypeKendaraan=typeKendaraan;
        }
        //protected MasterBarangAddedIntegrationEvent(Guid id, DateTime occurredOn) : base(id, occurredOn)
        //{

        //}

    }
}
