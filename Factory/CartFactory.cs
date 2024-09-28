using RAisoLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAisoLab.Factory
{
    public class CartFactory
    {
        public static Cart Create(int Quantity, int UserID, int StationeryID)
        {
            Cart cart = new Cart();

            cart.UserID = UserID;
            cart.StationeryID = StationeryID;
            cart.Quantity = Quantity;

            return cart;
        }
    }
}