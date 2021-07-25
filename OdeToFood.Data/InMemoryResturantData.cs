
using System;
using System.Collections.Generic;
using System.Linq;
using OdeToFood.Core;

namespace OdeToFood.Data
{
    public class InMemoryResturantData : IResturantData
    {
        readonly List<Resturant> resturants;
        public  InMemoryResturantData()
        {
            resturants = new List<Resturant>()
            {
                new Resturant {Id = 1, Name = "Scott's Pizza", Location = "MaryLand", Cuisine = CuisineType.Italian },
                new Resturant {Id = 2, Name = "Cinamon Club", Location = "London", Cuisine = CuisineType.Indian },
                new Resturant {Id = 3, Name = "La Costa", Location = "Calafornia", Cuisine = CuisineType.Mexicab }
            };
        }
        public Resturant GetById(int id)
        {
            return resturants.SingleOrDefault(r => r.Id == id);
        }
        public Resturant Add(Resturant newResturant)
        {
            resturants.Add(newResturant);
            newResturant.Id = resturants.Max(r => r.Id) + 1;
            return newResturant;
        }
        public Resturant Update(Resturant updateResturant)
        {
            var resturant = resturants.SingleOrDefault(r => r.Id == updateResturant.Id);
            if(resturant != null)
            {
                resturant.Name = updateResturant.Name;
                resturant.Location = updateResturant.Location;
                resturant.Cuisine = updateResturant.Cuisine;
            }
            return resturant;
        }
        public int Commit()
        {
            return 0;
        }
        public IEnumerable<Resturant> GetResturantsByName(string name = null)
        {
            return from r in resturants 
                   where string.IsNullOrEmpty(name) || r.Name.StartsWith(name) 
                   orderby r.Name select r ;
                   
                   
        }

        public Resturant Delete(int id)
        {
            var resturant = resturants.FirstOrDefault(r => r.Id == id);
            if (resturant != null)
            {
                resturants.Remove(resturant);
            }
            return resturant;
        }

        public int GetCountOfResturants()
        {
            return resturants.Count();
                
        }
    }
}
