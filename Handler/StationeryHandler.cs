using RAisoLab.Models;
using RAisoLab.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAisoLab.Handler
{
    public class StationeryHandler
    {
        StationeryRepository stationeryRepository = new StationeryRepository();
        public void insertStationery(String name, int price)
        {
            stationeryRepository.addStationery(name, price);
        }

        public void deleteStationery(int id)
        {
            stationeryRepository.removeStationery(id);
        }

        public void updateStationery(int id, String name, int price)
        {
            stationeryRepository.updateStationery(id, name, price);
        }

        public MsStationery getStationeryById(int id)
        {
            MsStationery temp = stationeryRepository.getStationery(id);
            return temp;
        }

        public List<MsStationery> getAllStationery()
        {
            return stationeryRepository.getAllStationery(); 
        }

        public String uniqueCheck(String name)
        {
            String response = stationeryRepository.uniqueName(name);
            if(response == "True")
            {
                return "Success";
            } else
            {
                return "Fail";
            }
        }

        public MsStationery getStationeryByName(String name)
        {
            MsStationery stationery = stationeryRepository.getStationeryByName(name);
            return stationery;
        }
    }
}