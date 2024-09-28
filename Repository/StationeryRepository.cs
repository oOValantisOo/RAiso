using RAisoLab.Factory;
using RAisoLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;

namespace RAisoLab.Repository
{
    public class StationeryRepository
    {
        RAisoDatabaseEntities1 db = Singleton.Singleton.getInstance();

        public List<MsStationery> getAllStationery()
        {
            return (from x in db.MsStationeries where x.isDeleted == 1 select x).ToList();
        }

        public MsStationery getStationery(int id)
        {
            return (from x in db.MsStationeries where x.StationeryID == id select x).FirstOrDefault();
        }

        public void addStationery(String stationeryName, int stationeryPrice)
        {
            MsStationery stationery = StationeryFactory.Create(stationeryName, stationeryPrice);

            db.MsStationeries.Add(stationery);
            db.SaveChanges();
        }

        public void removeStationery(int id)
        {
            MsStationery temp = getStationery(id);
            temp.isDeleted = 0;

            db.SaveChanges();
        }

        public void updateStationery(int id, String stationeryName, int stationeryPrice)
        {
            MsStationery temp = getStationery(id);

            temp.StationeryPrice = stationeryPrice;
            temp.StationeryName = stationeryName;

            db.SaveChanges();
        }

        public MsStationery getStationeryByName(String name)
        {
            return (from x in db.MsStationeries where x.StationeryName == name select x).FirstOrDefault();
        }

        public String uniqueName(String name)
        {
            MsStationery stationery = getStationeryByName(name);
            if(stationery == null)
            {
                return "True";
            } else
            {
                return "False";
            }
        }
    }
}
