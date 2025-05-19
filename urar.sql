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

insert into urari (ime,prezime)
values ('Ivan','Horvat');

insert into korisnici (ime,prezime) values
('Ilija','Sivonjiæ'),
('Niko','Nikiæ'),
('Beno','Nelan');

insert into satovi (proizvodac, model, korisnik) values
('Timex', 'Weekender',3),
('Casio', 'F-91W',3),
('Swatch', 'Gent',3),
('Citizen', 'Entry Eco-Drive',1),
('Seiko', 'Seiko 5',1),
('Skagen', 'Basic Mesh',2);

insert into segrti (ime,prezime,urar) values
('Ivica','Hlapiæ',1);

insert into popravci (usluga, cijena, sat, urar) values
('Zamjena baterije', 15.67, 5, 1),
('Zamjena stakla', 20.00, 1, 1),
('Zamjena pogonske opruge', 90.45, 3, 1),
('Novi remen', 10.00, 2, 1),
('Èišæenje', 16.60, 4, 1),
('Dijagnoza', 00.00, 6, 1);

select * from urari;
select * from korisnici;
select * from satovi;
select * from segrti;
select * from popravci;

delete from popravci where sat in (select sifra from satovi where korisnik=3);
delete from satovi where korisnik in (select sifra from korisnici where sifra=3);
delete korisnici where sifra=3;