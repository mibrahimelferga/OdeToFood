﻿using System.Collections.Generic;
using System.Text;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public interface IResturantData
    {
        IEnumerable<Resturant> GetResturantsByName(string name);
        Resturant GetById( int id);
        Resturant Update(Resturant updateResturant);
        Resturant Add(Resturant newResturant);
        Resturant Delete(int id);
        int GetCountOfResturants();
        int Commit();
    }
}
