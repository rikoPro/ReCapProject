using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "New car successfully added";
        public static string ColorAdded = "New color successfully added";
        public static string BrandAdded = "New brand successfully added";
        public static string SystemClosed = "The system is temporarily closed";

        public static string BrandDeleted = "Brand successfully deleted";
        public static string BrandsListed = "Brands successfully listed";
        public static string BrandUpdated = "Brand successfully updated";
        public static string CarCannotAdded = "Car adding failed";
        public static string CarDeleted = "Car successfully deleted.";
        public static string CarListed = "Cars successfully listed";
        public static string CarDetailsListed = "Car details successfully listed";
        public static string CarUpdated = "Car successfully updated";
        public static string ColorDeleted = "Colorsuccessfully deleted.";
        public static string ColorListed = "Colors successfully listed";
        public static string ColorUpdated = "Color successfully updated";

        public static string UserAdded { get; internal set; }
        public static string UserDeleted { get; internal set; }
        public static string UserUpdated { get; internal set; }
        public static string CustomerAdded { get; internal set; }
        public static string CustomerDeleted { get; internal set; }
        public static string CustomerUpdated { get; internal set; }
        public static string Rented { get; internal set; }
        public static string CarIsNotInStock = "The car is not in our stock";
        public static string RentDeleted { get; internal set; }
        public static string RentUpdated { get; internal set; }
        public static string CarHandedIn { get; internal set; }
        public static string AccessTokenCreated { get; internal set; }
        public static string RegisteredSuccessfully { get; internal set; }
        public static string LoginSuccessful = "Successful Login";

        public static string PasswordError = "Wrong password";

        public static string UserNotFound = "User not found";

        public static string UserAlreadyExists = "User already exists";

        public static string ImageLimitExceeded = " There can be 5 image for a car";

        public static string NoRentalToShow = "There is no any rentals to show";

        public static string InvalidCarId = "The car is not in our stock";

        public static string CarIsSuitable = "The car is suitable for rent";
    }
}
