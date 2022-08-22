create table Users
(
UserId int not null identity(1,1),
FirstName nvarchar(50) not null,
LastName nvarchar(50) not null,
Email nvarchar(150) not null,
Password nvarchar(250) not null
primary key(UserId)
)


create table Customers
(
CustomerId int not null identity(1,1) primary key,
UserId int foreign key references Users(UserId),
CompanyName nvarchar(250)
)

create table Rentals
(
RentId int not null identity(1,1) primary key,
CarId int not null foreign key references Cars(Id),
CustomerId int not null foreign key references Customers(CustomerId),
RentDate DateTime not null,
ReturnDate DateTime
)