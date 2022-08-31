﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }
        public IResult Add(CarImage carImage)
        {
            var result = BusinessRules.Run(CheckImageLimitForCar(carImage.CarId));
            if (result != null)
            {
                return result;
            }
            carImage.CreatedDate = DateTime.Now;
            _carImageDal.Add(carImage);
            return new SuccessResult();
            }

        public IResult Delete(CarImage carImage)
        {
            _carImageDal.Delete(carImage);
            return new SuccessResult();
        }

        public IDataResult<List<CarImage>> GetByCarId(int carId)
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(ci => ci.CarId == carId));
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IResult Update(CarImage carImage)
        {
            _carImageDal.Update(carImage);
            return new SuccessResult();
        }

        private IResult CheckImageLimitForCar(int carId)
        {
            if (_carImageDal.GetAll(ci=>ci.CarId==carId).Count>=5)
            {
                return new ErrorResult(Messages.ImageLimitExceeded);
            }
            return new SuccessResult();
        }
    }
}
