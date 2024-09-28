using RAisoLab.Factory;
using RAisoLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAisoLab.Repository
{
    public class CartRepository
    {
        RAisoDatabaseEntities1 db = Singleton.Singleton.getInstance();

        public Cart getCart(int id, int stationeryId)
        {
            return (from x in db.Carts where x.UserID == id && x.StationeryID == stationeryId select x).FirstOrDefault();
        }
        public void updateCart(int id, int stationeryId, int quantity)
        {
            Cart cart = getCart(id, stationeryId);
            cart.Quantity = quantity;

            db.SaveChanges();
        }

        public void removeCart(int id, int stationeryId)
        {
            Cart temp = getCart(id, stationeryId);

            db.Carts.Remove(temp);
            db.SaveChanges();
        }

        public List<Cart> getUserCarts(int id)
        {
            return (from x in db.Carts where x.UserID == id select x).ToList();
        }

        public void addCart(int userId, int stationeryId, int quantity)
        {
            Cart cart = CartFactory.Create(quantity, userId, stationeryId);
            db.Carts.Add(cart);
            db.SaveChanges();
        }

        public Cart getStationeryCart(int userId, int stationeryId)
        {
            return (from x in db.Carts where (x.UserID == userId && x.StationeryID == stationeryId) select x).FirstOrDefault();  
        }

    }
}