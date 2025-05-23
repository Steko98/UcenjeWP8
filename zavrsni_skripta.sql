use master;
go
drop database if exists catan;
go
create database catan collate Croatian_CI_AS;
go
use catan;

create  table turniri(
sifra int not null primary key identity(1,1),
ime varchar(50),
datumpocetka datetime,
datumzavrsetka datetime
);

create table igre(
sifra int not null primary key identity(1,1),
datum datetime,
turnir int not null references turniri(sifra)
);

create table igraci(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
brojodigranih int,
brojpobjeda int
);

create table clanovi(
igra int not null references igre(sifra),
igrac int not null references igraci(sifra),
brojbodova int,
pobjeda bit not null
);

create table rekordi(
sifra int not null primary key identity(1,1),
igrac int references igraci(sifra),
naziv varchar(100)
);