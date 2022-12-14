using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation.FluentValidation;
using Core.CrossCuttingConcerns.Validation.FluentValidation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        [ValidationAspects(typeof(CarValidator))]
        [CacheRemoveAspect("IProductService.Get")]
        public IResult Add(Car car)
        {
            
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);

        }
        [TransactionScopeAspect]
        public IResult AddTransactionalTest(Car car)
        {
            if (car.DailyPrice<301000)
            {
                throw new Exception("Fiyat çok az");
            }
            _carDal.Add(car);
            return null;
        }

        public IResult Delete(Car car)
        {

            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }
        [CacheAspect]
        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.CarListed);
        }
        [CacheAspect]
        public IDataResult<Car> GetById(int carId)
        {
            var result = _carDal.Get(c => c.Id == carId);
            if (result != null)
            {
                return new SuccessDataResult<Car>(result, Messages.CarListed);
            }
            return new ErrorDataResult<Car>(Messages.InvalidCarId);
        }

        public IDataResult<List<Car>> GetCarByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id).ToList(), Messages.CarListed);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails(), Messages.CarDetailsListed);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id).ToList(), Messages.CarListed);
        }
        [CacheRemoveAspect("IProductService.Get")]
        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);

        }


    }
}
