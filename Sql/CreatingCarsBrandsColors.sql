use ReCap
go

create table Brands
(
BrandId int not null primary key,
BrandName nvarchar(50) not null
)

create table Colors
(
ColorId int not null primary key,
ColorName nvarchar(50) not null
)

create table Cars
(
Id int not null primary key,
BrandId int not null foreign key references Brands(BrandId),
ColorId int not null foreign key references Colors(ColorId),
ModelYear int not null,
DailyPrice decimal(18,2) not null,
Description nvarchar(150) not null
)