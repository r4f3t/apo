using Interfaces;
using OrderModule.Models;
using OrderModule.OrderClasses;
using OrderModule.TenderClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderModule
{
    class Program
    {
        static void Main(string[] args)
        {
            //ürünler gelecek 
            //sipariş ise sipariş olarak
            //teklif ise teklif olarak kayıt edilecek
            TenderModel _tenderModel= new TenderModel();
            _tenderModel.sipId = 10001;
            _tenderModel.itemRef = 5;
            _tenderModel.itemPrice = 25.45;
            _tenderModel.amount = 10;
            _tenderModel.clientref = 1881;
            _tenderModel.mailAdress = "rafet@parlak.com.tr";
            WriteToDb _writeToDb = new WriteToDb(new TenderType(_tenderModel));
            _writeToDb.InsertToDb();

            OrderModel _orderModel = new OrderModel();
            _orderModel.sipId = 10001;
            _orderModel.itemRef = 5;
            _orderModel.itemPrice = 25.45;
            _orderModel.amount = 10;
            _orderModel.clientref = 1881;
            _writeToDb = new WriteToDb(new OrderType(_orderModel));
            _writeToDb.InsertToDb();

            Console.ReadKey();
        }

       

  


      
    }
}
