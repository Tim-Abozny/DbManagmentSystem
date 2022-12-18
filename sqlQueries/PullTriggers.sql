use [C:\AMYFILES\GIT\LABS\5 SEM\DBMANAGMENTSYSTEM\PROJECTFILES\WPFAPP1\DBMANAGMENTSYSTEM.MDF]


go
create or alter TRIGGER Services_Update
on Services
after UPDATE
as
BEGIN
	insert into Logs (userID,LogType, Representation)
	select userID, 'UPDATE_SERVICE', sCost
	from inserted
END

go
create or alter TRIGGER Services_INSERT
on Services
after INSERT
as
BEGIN
	insert into Logs (userID,LogType, Representation)
	select userID, 'ADD_SERVICE', concat(sName, ',', sCost, ',', doctorID, '.')
	from inserted
END

go
create or alter TRIGGER Services_DELETE
on Services
after DELETE
as
BEGIN
	insert into Logs (userID,LogType, Representation)
	select userID, 'REMOVE_SERVICE', concat(sName, ',', doctorID, '.', sCost, '.')
	from deleted
END

go
create or alter TRIGGER ClientCards_INSERT
on ClientCards
after INSERT
as
BEGIN
	select * from inserted
	insert into Logs (userID, LogType, Representation)
	select UserID, 'ADD_CARD', concat(cName, '.', StorageID, '.')
	from inserted
END

go
create or alter TRIGGER ClientCards_DELETE
on ClientCards
after DELETE
as
BEGIN
	insert into Logs (userID,LogType, Representation)
	select UserID, 'REMOVE_CARD', concat(cName, '.', StorageID, '.')
	from deleted
END

go
create or alter TRIGGER Doctors_INSERT
on Doctors
after INSERT
as
BEGIN
	insert into Logs (userID,LogType, Representation)
	select ID, 'ADD_DOCTOR', concat(dName, '.', dPost, '.')
	from inserted
END

go
create or alter TRIGGER Doctors_DELETE
on Doctors
after DELETE
as
BEGIN
	insert into Logs (userID,LogType, Representation)
	select ID, 'REMOVE_DOCTOR', concat(dName, '.', dPost, '.')
	from deleted
END

go
create or alter TRIGGER UserAccounts_INSERT
on UserAccounts
after INSERT
as
BEGIN
	insert into UsersRoles (userID, roleID)
	select ID, (select Roles.ID from Roles where Roles.rName = 'visitor')
	from inserted
END
