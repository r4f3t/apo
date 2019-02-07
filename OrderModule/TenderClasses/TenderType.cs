using Interfaces;
using OrderModule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule.TenderClasses
{
    class TenderType : IMoveType
    {
        TenderModel _tenderModel;
        public TenderType(TenderModel tenderModel)
        {
            _tenderModel = tenderModel;
        }
        public void MakeInsert()
        {
            Console.WriteLine("Teklif Verilen ÜrünId:" + _tenderModel.itemRef);
            Console.WriteLine("Teklif Verilen ClientId:" + _tenderModel.clientref);
            Console.WriteLine("Teklif Gönderilen Mail Adresi:" + _tenderModel.mailAdress);
        }
    }
}
