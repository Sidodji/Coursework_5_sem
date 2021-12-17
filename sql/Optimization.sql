set statistics io on
set statistics time on 

Exec Ins100000rows

select ApartmentId, Room from Apartments where HotelName = 'Moscow'

select Count(*) from  Apartments where HotelName = 'Moscow'
/*
create index IX_Apartments_HotelName on Apartments(
	HotelName
) include (Room)

*/
drop index IX_Apartments_HotelName on Apartments