using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental,RecapDbContext>,IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails()
        {
            using (RecapDbContext context = new RecapDbContext())
            {
                var result = from r in context.Rentals
                             join c in context.Customers
                             on r.CustomerId equals c.CustomerId
                             join a in context.Cars
                             on r.CarId equals a.Id
                             join b in context.Brands
                             on a.BrandId equals b.BrandId
                             select new RentalDetailDto
                             {
                                 RentId = r.Id,
                                 BrandId = b.BrandId,
                                 BrandName = b.BrandName,
                                 CarId = a.Id,
                                 CompanyName = c.CompanyName,
                                 CustomerId = c.CustomerId,
                                 Description = a.Description,
                                 RentDate = r.RentDate,
                                 

                             };
                return result.ToList();
            }
        }
    }
}
