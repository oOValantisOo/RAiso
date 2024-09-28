using RAisoLab.Factory;
using RAisoLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAisoLab.Repository
{
    public class TransactionHeaderRepository
    {
        RAisoDatabaseEntities1 db = Singleton.Singleton.getInstance();
        public List<TransactionHeader> getAllTransactionHeader()
        {
            return (from x in db.TransactionHeaders select x).ToList();
        }

        public List<TransactionHeader> getUserTransactions(int userid)
        {
            return (from x in db.TransactionHeaders where x.UserID == userid select x).ToList();
        }

        public TransactionHeader addTransactionHeader(int userId, DateTime transactionDate)
        {
            TransactionHeader temp = TransactionHeaderFactory.Create(userId, transactionDate);
            int detailId = temp.TransactionID;

            db.TransactionHeaders.Add(temp);
            db.SaveChanges();

            return temp;
        }
    }
}