create database Person;

use [aspnet-Person];

create table People (
id INT PRIMARY KEY IDENTITY (1, 1) NOT NULL,
dui INT UNIQUE NOT NULL,
name VARCHAR(60) NOT NULL,
surname VARCHAR(60) NOT NULL,
dateBirthday DATETIME NOT NULL,
address VARCHAR(150) NULL,
email VARCHAR(100) NOT NULL
);

insert into People (dui, name, surname, dateBirthday, address, email) 
values 
(343454353, 'Kevin Edgardo', 'Calles Johl', '2000-01-24 00:00:00', 'Ilopango, San Salvador, El Salvador', 'kcedgardo12@gmail.com'),
(542325123, 'Maria Yamileth', 'Gonzalez Garcia', '1987-10-04 00:00:00', 'Soyapango, San Salvador, El Salvador', 'marya67@yahoo.com'),
(978984753, 'Gerardo Amilcar', 'Romel Quijano', '1989-11-21 00:00:00', 'Santa Tecla, La Libertad, El Salvador', 'gerara34@outlook.com');