create table CarImages
(
Id int primary key not null identity(1,1),
CarId int foreign key references Cars(Id),
ImagePath nvarchar(250),
Date datetime default(getdate())

)