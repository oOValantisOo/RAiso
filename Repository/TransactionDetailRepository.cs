using RAisoLab.Factory;
using RAisoLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAisoLab.Repository
{
    public class TransactionDetailRepository
    {
        RAisoDatabaseEntities1 db = Singleton.Singleton.getInstance();

        public List <TransactionDetail> getDetailById(int id)
        {
            return (from x in db.TransactionDetails where x.TransactionID == id select x).ToList();
        }

        public TransactionDetail addTransactionDetail(int transactionId, int stationeryId, int quantity)
        {
            TransactionDetail temp = TransactionDetailFactory.Create(transactionId, stationeryId, quantity);

            db.TransactionDetails.Add(temp);
            db.SaveChanges();

            return temp;
        }
    }
}