use master;
go
drop database if exists edunovawp8;
go
create database edunovawp8;
go
use edunovawp8;

create table smjerovi(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
cijena decimal(18,2) null, -- null se ne mora pisati
datumpokretanja datetime, -- isto null, nije napisano
aktivan bit not null default 0 -- default 0 znaci false ako se ne naznaci drugacije
);

create table grupe(
sifra int not null primary key identity(1,1),
naziv varchar(20),
smjer int,
predavac varchar(50)
);

create table polaznici(
sifra int,
ime varchar(50),
prezime varchar(50),
email varchar(100)
);

create table clanovi(
grupa int,
polaznik int
);