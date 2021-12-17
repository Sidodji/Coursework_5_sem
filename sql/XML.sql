use HotelsBase
--Export XML
go
create or alter procedure ExportUsersXML
AS
begin
	Select *from Users
	for xml path('User'), root('Users')

	EXEC sp_configure 'show advanced options', 1
	-- To update the currently configured value for advanced options.
	RECONFIGURE WITH OVERRIDE
	-- To enable the feature.
	EXEC sp_configure 'xp_cmdshell', 1
	RECONFIGURE WITH OVERRIDE

	--save created XML to file
	DECLARE @fileName varchar(100)
	DECLARE @sqlStr varchar(1000)
	DECLARE @sqlCmd varchar(1000)

	SET @fileName = 'D:\Laboratory\CourseWork\HotelsBase\XML\ExportUsers.xml'
	SET @sqlStr = 'USE HotelsBase; select * from Users for xml path(''User''), root(''Users'') '
	SET @sqlCmd = 'bcp "' + @sqlStr + '" queryout ' + @fileName + ' -w -T'
	EXEC xp_cmdshell @sqlCmd;
end


--Import XML
go
create procedure ImportUsersXML
AS
begin
	insert into Users (Username, FirstName, LastName,Password, Role)
	select
	   usXML.[User].query('Username').value('.', 'nvarchar(64)'),
	   usXML.[User].query('FirstName').value('.', 'nvarchar(64)'),
	   usXML.[User].query('LastName').value('.', 'nvarchar(64)'),
	   usXML.[User].query('Password').value('.', 'nvarchar(128)'),
	   usXML.[User].query('Role').value('.', 'int')
	   
	from (select cast(usXML as xml)
		  from openrowset(bulk 'D:\Laboratory\CourseWork\HotelsBase\XML\ImportUser.xml', single_blob) as T(usXML)) as T(usXML)
		  cross apply usXML.nodes('Users/User') as usXML ([User]);
end

drop procedure ImportUsersXML
exec ExportUsersXML




