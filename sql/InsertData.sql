use HotelsBase
--Добавление ролей
insert into dbo.Role(RoleId, RoleName) values(1, 'admin')
insert into dbo.Role(RoleId, RoleName) values(2, 'user')
--Добавление пользователя
insert into dbo.Users(Username, FirstName, LastName, Password, Role) values ('Makavka', 'Kosty','Tumak', '1111',1 ) 
--Добавление коментариев
insert into dbo.Comments(UserId,  Comment ) values ('1', 'Hello')
--добавление отелей
insert into dbo.Hotels(Name, Rooms, Capacity) values 
('Mr.President', 100, 300),
('Opium', 150, 150),
('Moscow', 300, 200),
('White House', 400, 100)
--Добавление номеров
insert into dbo.Apartments(Room, HotelName) values
(1,'Mr.President'),(2,'Mr.President'),(3,'Mr.President'),(4,'Mr.President'),(5,'Mr.President'),
(1,'Opium'),(2,'Opium'),(3,'Opium'),(4,'Opium'),(5,'Opium')

--Добавление 100000 строк
go
Create procedure Ins100000rows
as
begin
declare @i int = 1
while @i < 100001
begin
	set @i = @i+1
	insert into dbo.Apartments(Room, HotelName) values
	(@i, 'Moscow');
end
end;

Exec Ins100000rows

delete Apartments where HotelName = 'Moscow'


