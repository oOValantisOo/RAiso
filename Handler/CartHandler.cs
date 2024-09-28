using RAisoLab.Models;
using RAisoLab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Management;

namespace RAisoLab.Handler
{
    public class CartHandler
    {
        CartRepository repository = new CartRepository();
        public void updateCart(int UserId, int stationeryId, int quantity)
        {
            repository.updateCart(UserId, stationeryId, quantity);
        }

        public Cart GetCart(int UserId, int stationeryId)
        {
            Cart temp = repository.getCart(UserId, stationeryId);
            return temp;
        }

        public List<Cart> getShoppingCart(int id)
        {
            List<Cart> temp = repository.getUserCarts(id);
            return temp;
        }

        public String addToCart(int userId, int stationeryId, int quantity) {
            Cart temp = repository.getStationeryCart(userId, stationeryId);
            if(temp == null)
            {
                repository.addCart(userId, stationeryId, quantity);
                return "Success";
            }
            else
            {
                return "You already have a cart with that stationery already exists!";
            }
        }

        public String removeCart(int userId, int stationeryId)
        {
            Cart temp = repository.getStationeryCart(userId, stationeryId);
            if (temp != null)
            {
                repository.removeCart(userId, stationeryId);
                return "Success";
            }
            else
            {
                return "You already have a cart with that stationery already exists!";
            }
        }

    }
}