create database core_MVC

use core_MVC

create table Trainees
(
TID int Primary Key,
TName varchar(25),
TAge int check(TAge>=22)
)
