use [C:\AMYFILES\GIT\LABS\5 SEM\DBMANAGMENTSYSTEM\PROJECTFILES\WPFAPP1\DBMANAGMENTSYSTEM.MDF]

insert into Services (sName, sCost, userID, doctorID, statusCode) 
values (
	'Urinotherapy',
	900,
	(select UserAccounts.ID from UserAccounts where UserAccounts.ID = 1),
	(select Doctors.ID from Doctors where Doctors.dName = 'Polina Aboznaya'),
	'unregistered'
)

insert into Services (sName, sCost, userID, doctorID, statusCode) 
values (
	'Holter',
	300,
	(select UserAccounts.ID from UserAccounts where UserAccounts.ID = 2),
	(select Doctors.ID from Doctors where Doctors.dName = 'Anna Staromodova'),
	'unregistered'
)

insert into Services (sName, sCost, userID, doctorID, statusCode) 
values (
	'FamilyTherapy',
	2000,
	(select UserAccounts.ID from UserAccounts where UserAccounts.ID = 3),
	(select Doctors.ID from Doctors where Doctors.dName = 'Elithaveta Zayceva'),
	'unregistered'
)

insert into Services (sName, sCost, userID, doctorID, statusCode) 
values (
	'FamilyTherapy',
	2000,
	(select UserAccounts.ID from UserAccounts where UserAccounts.ID = 4),
	(select Doctors.ID from Doctors where Doctors.dName = 'Leonard Zeus'),
	'unregistered'
)

insert into Services (sName, sCost, userID, doctorID, statusCode) 
values (
	'FamilyTherapy',
	2000,
	(select UserAccounts.ID from UserAccounts where UserAccounts.ID = 5),
	(select Doctors.ID from Doctors where Doctors.dName = 'Anna Staromodova'),
	'unregistered'
)

insert into Services (sName, sCost, userID, doctorID, statusCode) 
values (
	'SMAD',
	150,
	(select UserAccounts.ID from UserAccounts where UserAccounts.ID = 6),
	(select Doctors.ID from Doctors where Doctors.dName = 'Anna Staromodova'),
	'unregistered'
)

insert into Services (sName, sCost, userID, doctorID, statusCode) 
values (
	'HeartBreaking',
	290,
	(select UserAccounts.ID from UserAccounts where UserAccounts.ID = 7),
	(select Doctors.ID from Doctors where Doctors.dName = 'Elithaveta Zayceva'),
	'unregistered'
)

insert into Services (sName, sCost, userID, doctorID, statusCode) 
values (
	'Urinotherapy',
	900,
	(select UserAccounts.ID from UserAccounts where UserAccounts.ID = 8),
	(select Doctors.ID from Doctors where Doctors.dName = 'Elithaveta Zayceva'),
	'unregistered'
)