using System.Collections.Generic;
using System.IO;
using System.Linq;
using Repository.Entities;

namespace Repository.Repository
{
    public class TravelerRepository : IGenericRepository<Traveler>
    {
        private readonly DatabaseContext _databaseContext;

        public TravelerRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public Traveler Add(Traveler traveler)
        {
            using var dbContext = _databaseContext;
            var travelerEntity = dbContext.Travelers.Add(traveler);

            return travelerEntity.Entity;
        }

        public Traveler Update(Traveler traveler)
        {
            using var dbContext = _databaseContext;
            var entityEntry = dbContext.Update(traveler);

            return entityEntry.Entity;
        }

        public void Remove(int id)
        {
            var traveler = Get(id);
            Remove(traveler);
        }

        public void Remove(Traveler traveler)
        {
            using var dbContext = _databaseContext;

            dbContext.Travelers.Remove(traveler);
            dbContext.SaveChanges();
        }
        
        public Traveler Get(int id)
        {
            using var dbContext = _databaseContext;
            var isAny = dbContext.Travelers.Any(x => x.Id == id);
            if (isAny == false)
            {
                throw new InvalidDataException($"No Traveler found with given ID : {id}");
            }
            var result = dbContext.Travelers.FirstOrDefault(x => x.Id == id);
            return result;
        }

        public IList<Traveler> GetAll()
        {
            using var dbContext = _databaseContext;

            var matches = dbContext.Travelers.Cast<Traveler>().ToList();

            return matches;
        }

        public void SaveChanges()
        {
            _databaseContext.SaveChanges();
        }
    }
}