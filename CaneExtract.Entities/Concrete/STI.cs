﻿using CaneExtract.Core.Entities;

namespace CaneExtract.Entities.Concrete
{
    public class STI : IEntity
    {
        public int SequenceNo { get; set; }//Sıra No
        public int TransactionType { get; set; }//İşlem türü
        public string? DocumentNo { get; set; }//EvrakNo
        public int Quantity { get; set; }//miktar
        public DateTime Date { get; set; }//Tarih
        public int InputQuantity { get; set; }//giriş miktarı
        public int OutputQuantity { get; set; }//çıkış miktarı
        public int Stock { get; set; }//Stok
    }
}
