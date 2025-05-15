create database osnovnaskola;
go
use osnovnaskola;

create table uciteljice(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
email varchar(100)
);

create table radionice(
sifra int not null primary key identity(1,1),
naziv varchar(100) not null,
datum datetime not null,
uciteljica int not null references uciteljice(sifra)
);

create table djeca(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
razred varchar(20)
);

create table clanovi(
dijete int not null references djeca(sifra),
radionica int not null references radionice(sifra)
);