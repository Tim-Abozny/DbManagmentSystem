set ansi_warnings off
use [C:\AMYFILES\GIT\LABS\5 SEM\DBMANAGMENTSYSTEM\PROJECTFILES\WPFAPP1\DBMANAGMENTSYSTEM.MDF]

DECLARE 
@name varchar(128),
@address varchar (50),
@phone varchar (13),
@birthday date,
@userID INT,
@storageID INT

SET @name = 'Robert Pavlovich'
SET @address = '12 PolskiyDom St.'
SET @phone = '+375336830803'
SET @birthday = '1976-10-07'
SET @userID = (select UserAccounts.ID from UserAccounts where UserAccounts.ID = 29)
SET @storageID = (select CardsStorage.ID from CardsStorage where CardsStorage.Section = 'firstSection')
EXEC NewCard @name, @address, @phone, @birthday, @userID, @storageID