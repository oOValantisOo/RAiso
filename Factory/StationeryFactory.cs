using RAisoLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RAisoLab.Factory
{
    public class StationeryFactory
    {
        public static MsStationery Create(String StationeryName, int StationeryPrice)
        {
            MsStationery stationery = new MsStationery();

            stationery.StationeryName = StationeryName;
            stationery.StationeryPrice = StationeryPrice;
            stationery.isDeleted = 1;

            return stationery;
        }
    }
}