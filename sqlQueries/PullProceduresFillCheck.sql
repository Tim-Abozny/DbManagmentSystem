DECLARE @userID INT, @doctorID INT

SET @userID = (select UserAccounts.ID from UserAccounts where UserAccounts.ID = 3)
SET @doctorID = (select Doctors.ID from Doctors where Doctors.dName = 'Elithaveta Zayceva')
EXEC EmotionalDamage @userID, @doctorID
 
SET @userID = (select UserAccounts.ID from UserAccounts where UserAccounts.ID = 4)
SET @doctorID = (select Doctors.ID from Doctors where Doctors.dName = 'Leonard Zeus')
EXEC SMAD @userID, @doctorID

SET @userID = (select UserAccounts.ID from UserAccounts where UserAccounts.ID = 2)
SET @doctorID = (select Doctors.ID from Doctors where Doctors.dName = 'Polina Aboznaya')
EXEC HeartBreaking @userID, @doctorID

SET @userID = (select UserAccounts.ID from UserAccounts where UserAccounts.ID = 8)
SET @doctorID = (select Doctors.ID from Doctors where Doctors.dName = 'Elithaveta Zayceva')
EXEC Urinotherapy @userID, @doctorID

SET @userID = (select UserAccounts.ID from UserAccounts where UserAccounts.ID = 1)
SET @doctorID = (select Doctors.ID from Doctors where Doctors.dName = 'Polina Aboznaya')
EXEC PulseCheck @userID, @doctorID

SET @userID = (select UserAccounts.ID from UserAccounts where UserAccounts.ID = 2)
SET @doctorID =(select Doctors.ID from Doctors where Doctors.dName = 'Anna Staromodova')
EXEC TeethCheck @userID, @doctorID

SET @userID = (select UserAccounts.ID from UserAccounts where UserAccounts.ID = 3)
SET @doctorID = (select Doctors.ID from Doctors where Doctors.dName = 'Elithaveta Zayceva')
EXEC EarsCheck @userID, @doctorID

SET @userID = (select UserAccounts.ID from UserAccounts where UserAccounts.ID = 4)
SET @doctorID = (select Doctors.ID from Doctors where Doctors.dName = 'Leonard Zeus')
EXEC FamilyTherapy @userID, @doctorID

SET @userID = (select UserAccounts.ID from UserAccounts where UserAccounts.ID = 5)
SET @doctorID = (select Doctors.ID from Doctors where Doctors.dName = 'Anna Staromodova')
EXEC EyesCheck @userID, @doctorID

SET @userID = (select UserAccounts.ID from UserAccounts where UserAccounts.ID = 6)
SET @doctorID = (select Doctors.ID from Doctors where Doctors.dName = 'Anna Staromodova')
EXEC ArmHilling @userID, @doctorID

SET @userID = (select UserAccounts.ID from UserAccounts where UserAccounts.ID = 7)
SET @doctorID = (select Doctors.ID from Doctors where Doctors.dName = 'Elithaveta Zayceva')
EXEC BrainDamaging @userID, @doctorID

SET @userID = (select UserAccounts.ID from UserAccounts where UserAccounts.ID = 2)
SET @doctorID = (select Doctors.ID from Doctors where Doctors.dName = 'Polina Aboznaya')
EXEC HeartHilling @userID, @doctorID

SELECT * FROM Services