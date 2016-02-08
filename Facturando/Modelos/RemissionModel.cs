using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facturando.Modelos
{
    public class RemissionModel
    {
        public Guid Id { get; set; }
        public Guid? IdClient { get; set; }
        public long RemissionNumber { get; set; }
        public decimal Total { get; set; }
        public string Name { get; set; }
        public string IdentificationNumber { get; set; }
        public DateTime DateEvent { get; set; }
        public string TotalInLetters { get; set; }
        public string WatchRemission { get; set; }
    }

    public class RemissionDetailModel {
        public Guid Id { get; set; }
        public Guid IdRemission { get; set; }
        public Guid IdProduct { get; set; }
        public string Product { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }        
        public decimal Discount { get; set; }
        public decimal Total { get; set; }

    }

    public class RemissionSaveModel
    {
        public ClientModel Client { get; set; }
        public RemissionModel Remission { get; set; }
        public List<RemissionDetailModel> RemissionDetail { get; set; }        
    }

    public class RemissionPrintModel
    {
        public List<ClientModel> Client { get; set; }
        public List<RemissionModel> Remission { get; set; }
        public List<RemissionDetailModel> RemissionDetail { get; set; }
    }

    interface IFormRemission {
        void NewRemission();
    }
}
