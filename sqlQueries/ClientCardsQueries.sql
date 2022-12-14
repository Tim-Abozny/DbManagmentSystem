use [C:\AMYFILES\GIT\LABS\5 SEM\DBMANAGMENTSYSTEM\PROJECTFILES\WPFAPP1\DBMANAGMENTSYSTEM.MDF]

insert into ClientCards (cName, cPhone, cAddress, cBirthday, UserID, StorageID)
values
(
	'Berg Downtown',
	'+375293347751',
	'69 Kupalovich St.',
	'1997-07-10',
	(select UserAccounts.ID from UserAccounts where UserAccounts.ID = 1),
	(select CardsStorage.ID from CardsStorage where CardsStorage.Section = 'firstSection')

)

insert into ClientCards (cName, cPhone, cAddress, cBirthday, UserID, StorageID)
values
(
	'Nick Koznev',
	'+375293456725',
	'38 Spanickroon St.',
	'1999-02-12',
	(select UserAccounts.ID from UserAccounts where UserAccounts.ID = 2),
	(select CardsStorage.ID from CardsStorage where CardsStorage.Section = 'firstSection')

)

insert into ClientCards (cName, cPhone, cAddress, cBirthday, UserID, StorageID)
values
(
	'Love Fedorovna',
	'+375296969699',
	'18 Plushistory St.',
	'1999-06-09',
	(select UserAccounts.ID from UserAccounts where UserAccounts.ID = 3),
	(select CardsStorage.ID from CardsStorage where CardsStorage.Section = 'firstSection')

)

insert into ClientCards (cName, cPhone, cAddress, cBirthday, UserID, StorageID)
values
(
	'Steve Rodgers',
	'+375291234365',
	'14 Mstitely St.',
	'1977-02-02',
	(select UserAccounts.ID from UserAccounts where UserAccounts.ID = 4),
	(select CardsStorage.ID from CardsStorage where CardsStorage.Section = 'firstSection')

)

insert into ClientCards (cName, cPhone, cAddress, cBirthday, UserID, StorageID)
values
(
	'Arkadz Sokol',
	'+375296854737',
	'69 Poletnaya St.',
	'2003-02-12',
	(select UserAccounts.ID from UserAccounts where UserAccounts.ID = 5),
	(select CardsStorage.ID from CardsStorage where CardsStorage.Section = 'firstSection')

)

insert into ClientCards (cName, cPhone, cAddress, cBirthday, UserID, StorageID)
values
(
	'Uri Noterapia',
	'+375298876455',
	'66 Adskaya St.',
	'1966-06-06',
	(select UserAccounts.ID from UserAccounts where UserAccounts.ID = 6),
	(select CardsStorage.ID from CardsStorage where CardsStorage.Section = 'firstSection')

)

insert into ClientCards (cName, cPhone, cAddress, cBirthday, UserID, StorageID)
values
(
	'Alina Kuplinova',
	'+375295647878',
	'112 Bogataya St.',
	'1989-02-24',
	(select UserAccounts.ID from UserAccounts where UserAccounts.ID = 7),
	(select CardsStorage.ID from CardsStorage where CardsStorage.Section = 'firstSection')

)

insert into ClientCards (cName, cPhone, cAddress, cBirthday, UserID, StorageID)
values
(
	'Max Painlove',
	'+375294758362',
	'11 Putinskaya St.',
	'1972-03-13',
	(select UserAccounts.ID from UserAccounts where UserAccounts.ID = 8),
	(select CardsStorage.ID from CardsStorage where CardsStorage.Section = 'firstSection')

)