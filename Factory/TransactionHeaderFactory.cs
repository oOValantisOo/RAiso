using RAisoLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAisoLab.Factory
{
    public class TransactionHeaderFactory
    {
        public static TransactionHeader Create(int UserId, DateTime TransactionDate)
        {
            TransactionHeader header = new TransactionHeader();

            header.UserID = UserId;
            header.TransactionDate = TransactionDate;

            return header;
        }
    }
}