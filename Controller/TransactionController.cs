using RAisoLab.Handler;
using RAisoLab.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace RAisoLab.Controller
{
    public class TransactionController
    {
        TransactionsHandler transactionHandler = new TransactionsHandler();
        public List<TransactionHeader> getAllTransactions()
        {
            return transactionHandler.getAllTransactions();
        }

        public List<TransactionHeader> getUserTransactions(int id)
        {
            return transactionHandler.getUserTransactions(id);
        }

        public List <TransactionDetail> GetTransactionDetail(int id) { 
            List <TransactionDetail> temp = transactionHandler.GetTransactionDetail(id);
            return temp;
        }

        public TransactionHeader CreateTransactionHeader(int UserId, DateTime transactionDate)
        {
            TransactionHeader temp = transactionHandler.createTransactionHeader(UserId, transactionDate);
            return temp;
        }

        public TransactionDetail CreateTransactionDetail(int transactionId, int stationeryId, int quantity)
        {
            TransactionDetail detail = transactionHandler.createTransactionDetail(transactionId, stationeryId, quantity);
            return detail;
        }
    }
}