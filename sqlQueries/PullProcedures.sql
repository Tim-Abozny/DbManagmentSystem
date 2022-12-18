use [C:\AMYFILES\GIT\LABS\5 SEM\DBMANAGMENTSYSTEM\PROJECTFILES\WPFAPP1\DBMANAGMENTSYSTEM.MDF]

GO
create or alter procedure HeartHilling 
@userID INT,
@doctorID INT
as 

BEGIN
insert into Services (sName, sCost, userID, doctorID, statusCode) 
values (
	'HeartHilling',
	500,
	@userID,
	@doctorID,
	'unregistered'
)
END


GO
create or alter procedure EmotionalDamage 
@userID INT,
@doctorID INT
as 

BEGIN
insert into Services (sName, sCost, userID, doctorID, statusCode) 
values (
	'EmotionalDamage',
	670,
	@userID,
	@doctorID,
	'unregistered'
)
END


GO
create or alter procedure PulseCheck 
@userID INT,
@doctorID INT
as 

BEGIN
insert into Services (sName, sCost, userID, doctorID, statusCode) 
values (
	'PulseCheck',
	100,
	@userID,
	@doctorID,
	'unregistered'
)
END


GO
create or alter procedure TeethCheck 
@userID INT,
@doctorID INT
as 

BEGIN
insert into Services (sName, sCost, userID, doctorID, statusCode) 
values (
	'TeethCheck',
	250,
	@userID,
	@doctorID,
	'unregistered'
)
END


GO
create or alter procedure EarsCheck 
@userID INT,
@doctorID INT
as 

BEGIN
insert into Services (sName, sCost, userID, doctorID, statusCode) 
values (
	'EarsCheck',
	140,
    @userID,
	@doctorID,
	'unregistered'
)
END


GO
create or alter procedure FamilyTherapy 
@userID INT,
@doctorID INT
as 

BEGIN
insert into Services (sName, sCost, userID, doctorID, statusCode) 
values (
	'FamilyTherapy',
	2000,
    @userID,
	@doctorID,
	'unregistered'
)
END


GO
create or alter procedure BreathCheck 
@userID INT,
@doctorID INT
as 

BEGIN
insert into Services (sName, sCost, userID, doctorID, statusCode) 
values (
	'BreathCheck',
	220,
    @userID,
	@doctorID,
	'unregistered'
)
END


GO
create or alter procedure ArmHilling 
@userID INT,
@doctorID INT
as 

BEGIN
insert into Services (sName, sCost, userID, doctorID, statusCode) 
values (
	'ArmHilling',
	400,
    @userID,
	@doctorID,
	'unregistered'
)
END


GO
create or alter procedure BrainDamaging
@userID INT,
@doctorID INT
as 

BEGIN
insert into Services (sName, sCost, userID, doctorID, statusCode) 
values (
	'BrainDamaging',
	400,
	@userID,
	@doctorID,
	'unregistered'
)
END


GO
create or alter procedure Urinotherapy 
    @userID INT,
    @doctorID INT
as 

BEGIN
insert into Services (sName, sCost, userID, doctorID, statusCode) 
values (
	'Urinotherapy',
	900,
	@userID,
	@doctorID,
	'unregistered'
)
END


GO
create or alter procedure HeartBreaking 
    @userID INT,
    @doctorID INT
as 

BEGIN
insert into Services (sName, sCost, userID, doctorID, statusCode) 
values (
	'HeartBreaking',
	290,
    @userID,
	@doctorID,
	'unregistered'
)
END


GO
create or alter procedure SMAD 
    @userID INT,
    @doctorID INT
as 

BEGIN
insert into Services (sName, sCost, userID, doctorID, statusCode) 
values (
	'SMAD',
	150,
    @userID,
	@doctorID,
	'unregistered'
)
END


GO
create or alter procedure EyesCheck 
    @userID INT,
    @doctorID INT
as 

BEGIN
insert into Services (sName, sCost, userID, doctorID, statusCode) 
values (
	'EyesCheck',
	200,
	@userID,
	@doctorID,
	'unregistered'
)
END


GO
create or alter procedure NewCard 
@name varchar(128),
@address varchar (50),
@phone varchar (13),
@birthday date,
@userID INT,
@storageID INT
as 

BEGIN
insert into ClientCards (cName, cAddress, cPhone, cBirthday, UserID, StorageID)
values
(
	@name,
	@address,
	@phone,
	@birthday,
	@userID,
	@storageID
)
END


GO
create or alter procedure RegisterService
@serviceID INT
as

BEGIN
	update Services
	set statusCode = 'registered'
	where ID = @serviceID
END


GO
create or alter procedure DoctorService
@doctorID INT
as

BEGIN
	select Services.ID, Services.sName, ClientCards.cName, Services.sCost
	from Services
	left join ClientCards on ClientCards.UserID = Services.userID
	where Services.doctorID = @doctorID and Services.statusCode = 'registered'
	order by ClientCards.cName
	
END


GO
create or alter procedure RegtorServList
as

BEGIN
	select Services.ID, Services.sName, ClientCards.cName, Services.sCost
	from Services
	left join ClientCards on ClientCards.UserID = Services.userID
	where Services.statusCode = 'unregistered'
	order by ClientCards.cName
END


GO
create or alter procedure NewUser
@email varchar(50),
@password varchar (255)
as 

BEGIN
insert into UserAccounts(uEmail, uPassword)
values
(
	@email,
	@password
)
END


GO
create or alter procedure CheckUserData
@email varchar(50),
@password varchar (255),
@roleID INT
as 

BEGIN
	select count(*) from
	(
		select UserAccounts.ID
		from UserAccounts
		where uEmail = @email and uPassword = @password
		intersect
		select UsersRoles.userID
		from UsersRoles
		where UsersRoles.roleID = @roleID
	) I
END


GO
create or alter procedure AccountantResult
@userID INT
as 

BEGIN
	insert into Logs (userID, LogType, Representation)
values 
(
	@userID,
	'ACCOUNTANT',
	(select SUM(cast(Logs.Representation as INT )) from Logs where LogType = 'UPDATE_SERVICE')
)
END
