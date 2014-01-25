create database PoolCarManager
GO

use PoolCarManager
GO

create table Vehicle
(
	Id int not null identity(1,1),
	Registration varchar(16) not null,
	Description varchar(128) not null,
	constraint PK_Vehicle primary key (Id)
)

create table Driver
(
	Id int not null identity(1,1),
	Name varchar(64) not null,
	constraint PK_Driver primary key (Id)
)

create table Journey
(
	Id int not null identity(1,1),
	VehicleId int not null,
	DriverId int not null,
	FromLocation varchar(512) not null,
	ToLocation varchar(512) not null,
	Reason varchar(512) not null,
	StartMileage int not null,
	EndMileage int not null,
	constraint PK_Journey primary key (Id),
	constraint FK_Vehicle__Journey foreign key (VehicleId) references Vehicle (Id),
	constraint FK_Driver__Journey foreign key (DriverId) references Driver (Id)
)

insert into Driver (Name) values ('Neil')
insert into Driver (Name) values ('Nick')

insert into Vehicle (Registration, Description) values ('V123 YTE', 'Red Nissan Almera')
insert into Vehicle (Registration, Description) values ('X654 GFD', 'Green Ford Mondeo')
insert into Vehicle (Registration, Description) values ('VB02 DGF', 'Blue VW Passat')
insert into Vehicle (Registration, Description) values ('CS60 VTR', 'Black VW Passat')
