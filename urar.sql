use master;
go
drop database if exists urar;
go
create database urar;
go
use urar;

create table urari(
sifra int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
email varchar(100),
adresa varchar(100),
);

create table korisnici(
sifra int not null primary key identity(1,1),
ime varchar(30) not null,
prezime varchar(30) not null,
email varchar(100)
);

create table satovi(
sifra int not null primary key identity(1,1),
proizvodac varchar(100),
model varchar(50),
korisnik int not null references korisnici(sifra)
);

create table segrti(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
urar int not null references urari(sifra)
);

create table popravci(
sifra int not null primary key identity(1,1),
usluga varchar(150) not null,
cijena decimal(18,2) not null,
pocetak datetime,
kraj datetime,
sat int not null references satovi(sifra),
urar int not null references urari(sifra)
);