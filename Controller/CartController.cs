using RAisoLab.Handler;
using RAisoLab.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;

namespace RAisoLab.Controller
{
    public class CartController
    {
        CartHandler cartHandler = new CartHandler();
        public String updateCart(int UserId, int stationeryId, int quantity)
        {
            if(quantity < 1)
            {
                return "Quantity must be at least 1";
            } else
            {
                cartHandler.updateCart(UserId, stationeryId, quantity);
                return "Success";
            }
        }

        public Cart getCart(int UserId, int stationeryId)
        {
            if(UserId <= 0 || stationeryId <= 0)
            {
                return null;
            } else
            {
                Cart temp = cartHandler.GetCart(UserId, stationeryId);
                return temp;
            }
        }

        public List<Cart> getCarts(int id) {
            if(id <= 0)
            {
                return null;
            } else
            {
                List<Cart> shoppingCart = cartHandler.getShoppingCart(id);
                return shoppingCart;
            }
        }

        public String addToCart(int UserId, int stationeryId, int quantity)
        {
            if (quantity < 1) 
            {
                return "Quantity must be more than 0!";
            } else if(UserId <=0 || stationeryId <= 0)
            {
                return "Error, synchronization invalid";
            }
            String response = cartHandler.addToCart(UserId, stationeryId, quantity);
            if(response == "Success")
            {
                return "Success";
            } else
            {
                return "Failed";
            }
        }

        public String removeCart(int UserId, int stationeryId)
        {
            String response = cartHandler.removeCart(UserId, stationeryId);
            return response;
        }
    }
}