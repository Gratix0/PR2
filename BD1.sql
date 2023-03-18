CREATE DATABASE PostOffice

CREATE TABLE Office (
id_office int identity (1,1) primary key,
adress varchar (255) not null,
room varchar (255) not null,
);

CREATE TABLE produkt (
id_produkt int identity (1,1) primary key,
name_of_adress varchar (255) not null,
id_officeFK int,
FOREIGN KEY (id_officeFK)
	references Office (id_office),
);