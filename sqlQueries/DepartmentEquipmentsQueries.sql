use [C:\AMYFILES\GIT\LABS\5 SEM\DBMANAGMENTSYSTEM\PROJECTFILES\WPFAPP1\DBMANAGMENTSYSTEM.MDF]
INSERT INTO DepartmentEquipments(departmentID, equipmentID)
SELECT d.ID, e.ID from Departments d
CROSS JOIN Equipment e
WHERE d.dName = 'Cardiology' AND e.eName = 'Electrocardiograph'

INSERT INTO DepartmentEquipments(departmentID, equipmentID)
SELECT d.ID, e.ID from Departments d
CROSS JOIN Equipment e
WHERE d.dName = 'Therapy' AND e.eName = 'Phonendoscope'

INSERT INTO DepartmentEquipments(departmentID, equipmentID)
SELECT d.ID, e.ID from Departments d
CROSS JOIN Equipment e
WHERE d.dName = 'Ophthalmology' AND e.eName = 'Autorefkeratotonometer'

INSERT INTO DepartmentEquipments(departmentID, equipmentID)
SELECT d.ID, e.ID from Departments d
CROSS JOIN Equipment e
WHERE d.dName = 'Ultrasound' AND e.eName = 'Ultrasound machine'