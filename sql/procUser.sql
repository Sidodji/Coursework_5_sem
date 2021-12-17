use HotelsBase;
--�������� ��������

--��������� ������� Users
go
Create procedure selectUsers
As
Select *from Users;
--����������� 
GO
Create procedure loginUser
	@userLogin nvarchar(64),
	@userPass nvarchar(64)
AS
	begin
		Select * FROM Users WHERE Username = @userLogin AND Password = @userPass
	end
--��������� ������ � ������������ �� �����
GO
Create procedure selectUser
(
	@username nvarchar(64)
)
As
begin
	 Select *from Users Where Username = @username
end	

--��������� ������ � ������������ �� Id
GO
Create procedure selectUserId
(
	@userId int
)
As
begin
	 Select UserId from Users Where UserId = @userId
end	


--���������� ������������
go
Create procedure addUser
	
	@username nvarchar(64),
	@firstName nvarchar(64),
	@lastName nvarchar(64),
	@password nvarchar(64),
	@role int = 2 
AS
begin
    insert into Users(Username, FirstName, LastName, Password, Role)
    values(@username, @firstName, @lastName, @password, @role)
end


--�������� ������������
go
Create procedure deleteUser
	@userId int
AS
Begin
	delete Users where UserId = @userId
end

--��������� ����
go
Create procedure adminRole
	@userId int
AS
Begin
	Update Users Set Role = 1 Where UserId = @userId
end

--��������� ������ ������������
go
Create procedure updateUser
	@userId int,
	@username nvarchar(64),
	@firstName nvarchar(64),
	@lastName nvarchar(64),
	@password nvarchar(64)
As
begin
	Update Users set Username = @username, FirstName = @firstName, LastName = @lastName, Password = @password
	Where UserId = @userId
end
--��������� ������ ������ ������������
go
Create procedure updateUserPass
	@userId int, 
	@userPass nvarchar(128)
as
begin
	Update Users set Password = @userPass where UserId = @userId
end

--�������� ������������
go
create procedure CanCreateUser @username nvarchar(30), @resultCode int output
as
begin
	declare @AccountWithData int;
	select @AccountWithData = count(*) from Users
		where Users.Username = @username
	if (@AccountWithData > 0)
begin
	select @resultCode = 1;
end
	else
begin
	select @resultCode = 0;
end
end;







	
