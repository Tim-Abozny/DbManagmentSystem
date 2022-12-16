use [C:\AMYFILES\GIT\LABS\5 SEM\DBMANAGMENTSYSTEM\PROJECTFILES\WPFAPP1\DBMANAGMENTSYSTEM.MDF]

insert into ClientCards (cName, cPhone, cAddress, cBirthday, UserID, StorageID)
values
(
	'Tim Abozny',
	'+375294759255',
	'28 Yakuba St.',
	'2002-12-08',
	(select UserAccounts.ID from UserAccounts where UserAccounts.ID = 9),
	(select CardsStorage.ID from CardsStorage where CardsStorage.Section = 'firstSection')
)