Create table tbl_Workers 
(
IdWorkers int primary key identity(1,1) not null,
Nazwisko nvarchar(250) not null,
Imiê nvarchar(250) not null,
LoginStoart nvarchar(250) not null
)

Create table tbl_TaskCategories
(
IdCategory int primary key identity(1,1) not null,
CategoryName nvarchar(250) not null,
)

Create table tbl_TaskStatus (
IdTaskStatus int primary key identity(1,1) not null,
StatusName nvarchar(50) not null,
)

insert into tbl_TaskStatus Values
('Przyjête'),('W trakcie prac'),('Gotowe do testów'),('Wdro¿one');

Create Table tbl_Tasks (
IdTask int primary key identity(1,1) not null,
IdCategory int foreign key references tbl_TaskCategories(IdCategory) not null,
TaskName nvarchar(1000) not null,
IdWorkers int foreign key references tbl_Workers(IdWorkers) not null,
EndTime datetime,
StartTime datetime,
IdStatus int foreign key references tbl_TaskStatus(IdTaskStatus)
)

update tbl_Tasks
set IdTaskPriority = 1

Alter table tbl_Tasks
Add IdTaskPriority int foreign key references tbl_TaskPriority(IdTaskPriority)

create table tbl_TaskPriority
(
IdTaskPriority int primary key identity(1,1) not null,
PriorityName nvarchar(100) not null,
)

insert into tbl_TaskPriority Values
('Niski'),('Normalny'),('Wysoki');

 insert into tbl_Tasks values
 (1,'Zamkniêcie wykazu',2,null,getdate(),1);


insert into tbl_Workers values
('Zwi¹zek', 'Marcin', 'mzwiazek');



 select * from tbl_Workers
  select * from tbl_Tasks
   select * from tbl_TaskCategories

 insert into tbl_TaskCategories values
 ('Akord'),('Baza danych'), ('eAkord'),('eLicencja');

 insert into tbl_Tasks values
 (1,'Zamkniêcie wykazu',2,null,getdate(),0);

 Create view kwe_Tasks 
 as
 Select IdTask, tbl_TaskCategories.IdCategory, CategoryName, TaskName, tbl_Workers.IdWorkers ,LoginStoart, StartTime, EndTime, 
 StatusName, tbl_TaskStatus.IdTaskStatus, PriorityName, tbl_TaskPriority.IdTaskPriority
 from tbl_Tasks
 inner join tbl_Workers on tbl_Workers.IdWorkers = tbl_Tasks.IdWorkers
 inner join tbl_TaskCategories on tbl_TaskCategories.IdCategory = tbl_Tasks.IdCategory
 inner join tbl_TaskStatus on tbl_TaskStatus.IdTaskStatus = tbl_Tasks.IdStatus
 inner join tbl_TaskPriority on tbl_TaskPriority.IdTaskPriority = tbl_Tasks.idtaskpriority
 order by IdTask desc OFFSET 0 ROWS
 Go

 select * from kwe_Tasks

 select IdTask,CategoryName,TaskName,LoginStoart,StartTime,EndTime,StatusName,priorityName from kwe_Tasks
