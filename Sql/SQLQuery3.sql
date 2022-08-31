drop table CarImages

create table CarImages
(
Id int primary key not null identity(1,1),
CarId int foreign key references Cars(Id) not null,
Path nvarchar(300),
CreatedDate DateTime 
)