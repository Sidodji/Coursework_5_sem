use HotelsBase

--��������� ���� �������
go
create procedure AllApartments
	As select *from Apartments

--��������� ������� ��� ����� 

go
create procedure AllUserApartments
As
begin 
	select ApartmentId, Room, HotelName, Booked from Apartments
	where Booked = 2
end
--��������� ������
go
create procedure getApartment
	@userId int
as
begin
	Select ApartmentId, Room, HotelName from Apartments where UserId = @userId		
end


--�������� ������
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

--�������� ������
go
create procedure delApartment
	@room int
AS
begin
	delete from Apartments where Room = @room
end

--������������
go
create procedure resApartment
	@userId int,
	@apartmentId int
AS
begin
	update Apartments set UserId = @userId, Booked = 1 
	where ApartmentId = @apartmentId
end

--���������������
go
create procedure resetApartment
	@apartmentId int
AS
begin
	update Apartments set UserId = NULL, Booked = 2 
	where ApartmentId = @apartmentId
end
 