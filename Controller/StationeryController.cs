using RAisoLab.Handler;
using RAisoLab.Models;
using RAisoLab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAisoLab.Controller
{
    public class StationeryController
    {
        StationeryHandler stationeryHandler = new StationeryHandler();
        public String insertStationery(String name, int price)
        {
            if (name == "" || price.ToString() == "")
            {
                return "All fields must be filled";
            }
            else if (name.Length < 3 || name.Length > 50)
            {
                return "Stationery name must be between 3 and 50 characters long";
            }
            else if (price < 2000)
            {
                return "Stationery price must be at least 2000";
            }
            else
            {
                stationeryHandler.insertStationery(name, price);
                return "Success";
            }
        }

        public String updateStationery(int id, String name, int price)
        {
            if (name == "" || price.ToString() == "")
            {
                return "All fields must be filled";
            }
            else if (name.Length < 3 || name.Length > 50)
            {
                return "Stationery name must be between 3 and 50 characters long";
            }
            else if (price < 2000)
            {
                return "Stationery price must be at least 2000";
            }
            else
            {
                stationeryHandler.updateStationery(id, name, price);
                return "Success";
            }
        }

        public String deleteStationery(int id) {
            if (id!=0)
            {
                stationeryHandler.deleteStationery(id);
                return "Success";
            } else
            {
                return "Failed";
            }
        }

        public MsStationery getStationeryById(int id)
        {
            if(id!=0)
            {
                MsStationery stationery = stationeryHandler.getStationeryById(id);
                return stationery;
            } else
            {
                return null;
            }
        }

        public List<MsStationery> getAllStationery()
        {
            return stationeryHandler.getAllStationery();
        }

        public String uniqueCheck(String name)
        {
            String response = stationeryHandler.uniqueCheck(name);
            if(response == "Success")
            {
                return "Success";
            } else
            {
                return "Fail";
            }
        }

        public MsStationery getStationeryByName(String name)
        {
            MsStationery stationery = stationeryHandler.getStationeryByName(name);
            return stationery;
        }
    }
}