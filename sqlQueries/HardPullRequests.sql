use [C:\AMYFILES\GIT\LABS\5 SEM\DBMANAGMENTSYSTEM\PROJECTFILES\WPFAPP1\DBMANAGMENTSYSTEM.MDF]

select ClientCards.cName as ClientName, Services.sName as ServiceName,
Services.sCost as Cost, Services.statusCode
from Services
left join ClientCards on ClientCards.ID = Services.userID

select ClientCards.cName as ClientName, Doctors.dPost as DocPost,
Services.sName as ServiceName, Doctors.dName as Doctor, Services.sCost as Cost
from ClientCards
join Services on Services.userID = ClientCards.UserID
join Doctors on Doctors.ID = Services.doctorID
order by ClientCards.cName

select Services.sName as ServiceName, Services.sCost as Cost, COUNT(Services.sName) as servCount
from Services
join ClientCards on Services.userID = ClientCards.UserID
group by Services.sName, Services.sCost
having COUNT(Services.sName) >= 2
order by Services.sCost

select Doctors.dName as Humans
from Doctors
union all
select ClientCards.cName 
from ClientCards
join Services on Services.userID = ClientCards.UserID
order by Humans

select Roles.rName from Roles
where Roles.rName NOT IN ('admin')
union all
select Departments.dName from Departments
union all
select Services.sName from Services
