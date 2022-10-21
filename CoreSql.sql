create database Evryindia

use Evryindia;

create table Trainees
(
TID int Primary Key Identity(1,1),
TName varchar(25),
TAge int check(TAge>=22)
);

select * from Trainees

