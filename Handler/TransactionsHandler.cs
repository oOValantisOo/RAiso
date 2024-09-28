using RAisoLab.Models;
using RAisoLab.Repository;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace RAisoLab.Handler
{
    public class TransactionsHandler
    {
        TransactionHeaderRepository transactionHeaderRepository = new TransactionHeaderRepository();    
        TransactionDetailRepository transactionDetailRepository = new TransactionDetailRepository();
        public List<TransactionHeader> getAllTransactions()
        {
            return transactionHeaderRepository.getAllTransactionHeader();
        }

        public List<TransactionHeader> getUserTransactions(int id)
        {
            return transactionHeaderRepository.getUserTransactions(id);
        }

        public List<TransactionDetail> GetTransactionDetail(int id)
        {
            List<TransactionDetail> temp = transactionDetailRepository.getDetailById(id);
            return temp;
        }

        public TransactionHeader createTransactionHeader(int UserId, DateTime transactionDate)
        {
            TransactionHeader temp = transactionHeaderRepository.addTransactionHeader(UserId, transactionDate);
            return temp;
        }

        public TransactionDetail createTransactionDetail(int transactionId, int stationeryId, int quantity)
        {
            TransactionDetail temp = transactionDetailRepository.addTransactionDetail(transactionId, stationeryId, quantity);
            return temp;
        }
    }
}