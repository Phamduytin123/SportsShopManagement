use ShopSp
go

create table UserAccount(
	ID int primary key,
	UserName varchar(50),
	UserPassword varchar(30),
	UserRole tinyint
)
go

create table Products(
	ID int primary key,
	NameProduct nvarchar(70),
	Cost int,
	Quantity int
)
go

create table OrderDetail(
	ID int primary key,
	UserID int,
	ProductID int,
	OrderQuantity int,	
	DayTime date
	foreign key (ProductID) references Products(ID) on delete cascade on update cascade,
	foreign key (UserID) references UserAccount(ID) on delete cascade on update cascade
)
go
