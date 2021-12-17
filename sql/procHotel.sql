use HotelsBase;

--Получение таблицы отелей
go
create procedure selectHotels
As
SELECT * FROM Hotels

--добавление отеля
go
Create procedure addHotel
	@name nvarchar(64),
	@rooms int,
	@capacity int,
	@hotelId int out
AS
begin
    insert into Hotels(Name, Rooms, Capacity)
    values(@name, @rooms, @capacity)

	SET @hotelId=SCOPE_IDENTITY()
end


--удаление отеля
go
Create procedure delHotel
	@hotelId int
AS
begin
	delete from Hotels where HotelId = @hotelId
end

--обновление отеля по нулям
go
create procedure updHotel
	@hotelId int,
	@name nvarchar(64),
	@rooms int,
	@capacity int
as
begin
	update Hotels set Name = isNull(@name, Name), 
	Rooms = isNull(@rooms,Rooms), Capacity = isNull(@capacity,Capacity)
	where HotelId = @hotelId
end

