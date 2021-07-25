using Microsoft.EntityFrameworkCore;
using OdeToFood.Core;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data
{
    public class sqlResturantData : IResturantData
    {
        private readonly OdeToFoodDbContxet db;

        public sqlResturantData(OdeToFoodDbContxet db)
        {
            this.db = db;
        }
        public Resturant Add(Resturant newResturant)
        {
            db.Add(newResturant);
            return newResturant;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public Resturant Delete(int id)
        {
            var resturant = GetById(id);
            if(resturant != null)
            {
                db.Resturants.Remove(resturant);
            }
            return resturant; 
        }

        public Resturant GetById(int id)
        {
            return db.Resturants.Find(id);
        }

        public int GetCountOfResturants()
        {
            return db.Resturants.Count();
        }

        public IEnumerable<Resturant> GetResturantsByName(string name)
        {
            var query = from r in db.Resturants
                        where r.Name.StartsWith(name) || string.IsNullOrEmpty(name)
                        orderby r.Name
                        select r;
            return query;
        }

        public Resturant Update(Resturant updateResturant)
        {
            var entity = db.Resturants.Attach(updateResturant);
            entity.State = EntityState.Modified;
            return updateResturant;
        }
    }
}
