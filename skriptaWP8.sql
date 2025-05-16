use master;
go
drop database if exists edunovawp8;
go
create database edunovawp8;
go
use edunovawp8;

create table smjerovi(
sifra int not null primary key identity(1,1), -- oznaceno kao primary key (id), (1,1) znaci da krece od 1 i povecava se za 1 za svaki entitet (smjer)
naziv varchar(50) not null, -- not null znaci da je obvezno
cijena decimal(18,2) null, -- null se ne mora pisati
datumpokretanja datetime, -- isto null, nije napisano
aktivan bit not null default 0 -- default 0 znaci false ako se ne naznaci drugacije (1 true, 0 false)
);

create table grupe(
sifra int not null primary key identity(1,1),
naziv varchar(20) not null,
smjer int not null references smjerovi(sifra), -- references se odnosi na foreign key(pk iz druge tablice)
predavac varchar(50)
);

create table polaznici(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
email varchar(100)
);

create table clanovi(
-- tablica ne mora uvijek imati primary key
grupa int not null references grupe(sifra),
polaznik int not null references polaznici(sifra)
);