using RAisoLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAisoLab.Factory
{
    public class TransactionDetailFactory
    {
        public static TransactionDetail Create(int TransactionId, int StationeryId, int quantity)
        {
            TransactionDetail transactionDetail = new TransactionDetail();

            transactionDetail.TransactionID = TransactionId;
            transactionDetail.StationeryID = StationeryId;
            transactionDetail.Quantity = quantity;

            return transactionDetail;
        }
    }
}