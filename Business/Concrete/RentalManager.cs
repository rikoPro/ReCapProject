using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }
        public IResult Add(Rental rental)
        {
            var result = _rentalDal.GetAll(c => c.CarId == rental.CarId);
            bool isSuitable = false;
            foreach (var item in result)
            {
                if (result != null)
                {
                    if (item.ReturnDate != null)
                    {
                        isSuitable = true;
                    }
                    else
                    {
                        isSuitable = false;
                    }
                }

                else
                {
                    isSuitable = true;
                }
                
            }
            if (isSuitable)
            {
                _rentalDal.Add(rental);
                return new SuccessResult(Messages.Rented);
            }
            return new ErrorResult(Messages.CarIsNotInStock);
        }

        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentDeleted);
        }

        public IDataResult<List<Rental>> GetAll()
        {
            var result = _rentalDal.GetAll();
            if (result==null)
            {
                return new ErrorDataResult<List<Rental>>(Messages.NoRentalToShow);
            }
            return new SuccessDataResult<List<Rental>>(result);
        }

        public IDataResult<List<Rental>> GetByCarId(int carId)
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll(r => r.CarId == carId));
        }

        public IDataResult<List<RentalDetailDto>> GetRentalDetails()
        {
            return new SuccessDataResult<List<RentalDetailDto>>(_rentalDal.GetRentalDetails());
        }

        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentUpdated);
        }
    }
}
