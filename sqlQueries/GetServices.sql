select information_schema.routines.SPECIFIC_NAME as Services
  from information_schema.routines 
 where routine_type = 'PROCEDURE' 
 and information_schema.routines.SPECIFIC_NAME not in ('NewCard')
 and information_schema.routines.SPECIFIC_NAME not in ('RegisterService')
 and information_schema.routines.SPECIFIC_NAME not in ('DoctorService')
 and information_schema.routines.SPECIFIC_NAME not in ('RegtorServList')
 and information_schema.routines.SPECIFIC_NAME not in ('NewUser')
 and information_schema.routines.SPECIFIC_NAME not in ('CheckUserData')
 and information_schema.routines.SPECIFIC_NAME not in ('GetServices')
 group by information_schema.routines.SPECIFIC_NAME