-----------------------------------------------
--Creating Jobseeker Table

create table JobSeeker_180623
	 (
	
	 Name varchar(50) not null primary key,
	 Password varchar(25),  	 
	 Emailid nvarchar(50),
	 MobileNo varchar(20),	 	
	 Location nvarchar(50),
	 photo varbinary(max) ,
	 Position nvarchar(50) ,
	 Experience nvarchar(50) ,
	 PreferredJobLocation varchar(20),
	 Skills nvarchar(50) ,
	 Dateofapplication date ,
	 Resume varbinary(max) ,
	 Status varchar(50)

	 )

	 -----------------------------------------------
--Creating Employer Table

create table Employer_180623
	  (
	 Name varchar(50) primary key ,
	 Password varchar(25),  	 
	 Emailid nvarchar(50),
	 MobileNo varchar(20),	 	
	 Designation nvarchar(50) ,
	 Experience nvarchar(50) ,
	 EmployerClients varchar(100)
	 )

	  -----------------------------------------------
--Creating Job Table

create table Job_180623
	 (
	 Jobid int primary key, 	
	 Designation varchar(50) ,
	 Company varchar(50),
	 ComapnyName varchar(50),
	 Salary nvarchar(50)

	 )

	 -----------------------------------------------
--Creating Approved Table
create table Approved_180623
	 (
	  Name varchar(50)  not null foreign key references JobSeeker_180623(Name),
	  status varchar(50)
	  )

	  -----------------------------------------------
	  
create table Resume_180623
(
Id int not null identity primary key,
Name varchar(50) not null foreign key references JobSeeker_180623(Name),
Resumepath varchar(max)
)