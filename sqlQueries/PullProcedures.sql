use [C:\AMYFILES\GIT\LABS\5 SEM\DBMANAGMENTSYSTEM\PROJECTFILES\WPFAPP1\DBMANAGMENTSYSTEM.MDF]

GO
create procedure HeartHilling 
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
create procedure EmotionalDamage 
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
create procedure PulseCheck 
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
create procedure TeethCheck 
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
create procedure EarsCheck 
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
create procedure FamilyTherapy 
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
create procedure BreathCheck 
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
create procedure ArmHilling 
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
create procedure BrainDamaging
@userID INT,
@doctorID INT
as 

BEGIN
insert into Services (sName, sCost, userID, doctorID, statusCode) 
values (
	'BrainDamaging',
	400,
	'unregistered'
)
END


GO
create procedure Urinotherapy 
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
create procedure HeartBreaking 
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
create procedure SMAD 
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
create procedure EyesCheck 
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
