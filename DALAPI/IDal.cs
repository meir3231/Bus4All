﻿using DO;
using System.Collections.Generic;

namespace DALAPI
{
    public interface IDal
    {
        string SayHello();
        void SetHello(string message);
        // TODO comment
        bool addBus(BusDAO bus);
        bool update(BusDAO bus);
        BusDAO read(int license);
        List<BusDAO> getBusses();
        //TODO for you
        bool addBusInTravel(BusInTravelDAO bus);
        List<BusInTravelDAO> getBusesTravel();
    }
}