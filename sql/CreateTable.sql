USE [HotelsBase]
GO

Drop table if exists Users
Drop table if exists Role 
Drop table if exists Comments
Drop table if exists Hotels

--Создание Таблиц

Create table Hotels
(
	HotelId int IDENTITY(1,1) not null Constraint PK_HotelId primary key,
	Name nvarchar(64) unique not null,
	Rooms int,
	Capacity int,
)

Create Table Users
(
  UserId int IDENTITY(1,1) not null Constraint PK_UserId primary key,
  Username nvarchar(64) unique not null,
  FirstName nvarchar(64) not null,
  LastName nvarchar(64) not null,
  Password nvarchar(128) not null,
  Role int not null DEFAULT (2) 
)

create table Role
(
	RoleId int not null Constraint PK_RoleId primary key ,
	RoleName nvarchar(64) unique not null 
)

Create Table Comments
(
	CommentId int IDENTITY(1,1) not null Constraint PK_CommentId primary key,
	UserId int not null,
	Comment nvarchar(300) not null
)

Create table Apartments
(
	ApartmentId int IDENTITY(1,1) not null Constraint PK_apartmentId primary key,
	Room int not null,
	UserId int,
	HotelName nvarchar(64) not null,
	Booked int not null DEFAULT (2),
)



--Добавление внешних ключей

Alter table Users ADD Constraint FK_Role
Foreign Key (Role)
	references Role (RoleId)

Alter table Comments Add constraint FK_UserId
Foreign Key (UserId)
	references Users (UserId)



Alter table Apartments Add Constraint FK_apartmentId
Foreign key (UserId)
	references Users (UserId) 

/*Alter table Apartments Add Constraint FK_hotelId
Foreign key (HotelId)
	references Hotels (HotelId) ON DELETE CASCADE*/

Alter table  Apartments Add Constraint FK_hotelName
Foreign key (HotelName)
	references Hotels (Name) ON DELETE CASCADE 

--Удаление таблиц
drop table Apartments;
drop table Role;
drop table Hotels;
drop table Users;
drop table Comments


