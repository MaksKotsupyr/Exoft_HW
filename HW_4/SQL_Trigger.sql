create trigger UpdateUsersCount
on Users
after insert, update, delete
as
    declare @variable_Count table (newCount int, SchoolId int);
	insert into @variable_Count (newCount, SchoolId)
    select count(SchoolId), SchoolId
    from Users
    group by SchoolId;

	update Schools
	set Schools.Count = 
		(select newCount
		from @variable_Count as variable_Count
		where Schools.Id = variable_Count.SchoolId)