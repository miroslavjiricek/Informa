--Script Miroslav Jiricek, Test for Informa
--Creating View for all students which is used as a dataset for grid

CREATE VIEW V_Students AS
SELECT  dbo.Student.IdentityCard as 'Student ID card', dbo.Student.Name + ', ' + dbo.Student.Surname as 'Name and Surname'
      , dbo.School.Name as 'School name', dbo.Country.Name as 'Country of School'
  FROM  dbo.Student 
  LEFT JOIN dbo.School ON dbo.Student.IdSchool = dbo.School.Id 
  LEFT JOIN dbo.Country ON dbo.School.IdCountry = dbo.Country.Id