--create database fakultet;
--go
--use fakultet;

create table studenti(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
smjer varchar(100) not null,
godina varchar(50) not null,
email varchar(100)
);

create table kolegiji(
sifra int not null primary key identity(1,1),
naziv varchar(100) not null,
nositelj varchar(100),
ectsbodovi int not null
);

create table rokovi(
sifra int not null primary key identity(1,1),
datum datetime not null,
ucionica int,
polozeno bit,
ocjena decimal(3,2),
kolegij int not null references kolegiji(sifra)
);

create table prijave(
student int not null references studenti(sifra),
rok int not null references rokovi(sifra)
);