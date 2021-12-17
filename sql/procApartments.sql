use HotelsBase

--получение всех номеров
go
create procedure AllApartments
	As select *from Apartments

--получение номеров для юзера 

go
create procedure AllUserApartments
As
begin 
	select ApartmentId, Room, HotelName, Booked from Apartments
	where Booked = 2
end
--получение номера
go
create procedure getApartment
	@userId int
as
begin
	Select ApartmentId, Room, HotelName from Apartments where UserId = @userId		
end


--создание номера
go
create procedure addApartment
(
	@room int,
	@hotelName nvarchar(64)
)
as
begin
	insert into Apartments(Room, HotelName)
    values(@room, @hotelName)
end

--удаление номера
go
create procedure delApartment
	@room int
AS
begin
	delete from Apartments where Room = @room
end

--бронирование
go
create procedure resApartment
	@userId int,
	@apartmentId int
AS
begin
	update Apartments set UserId = @userId, Booked = 1 
	where ApartmentId = @apartmentId
end

--разбронирование
go
create procedure resetApartment
	@apartmentId int
AS
begin
	update Apartments set UserId = NULL, Booked = 2 
	where ApartmentId = @apartmentId
end
 