use master;
go
drop database if exists osnovnaskola;
go
create database osnovnaskola collate Croatian_CI_AS;
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

insert into uciteljice (ime, prezime, email) values
('Ana', 'Horvat', 'ana.horvat@skola.hr'),
('Iva', 'Petrovic', 'iva.petrovic@skola.hr'),
('Marija', 'Juric', null),
('Marko', 'Klasic', 'marko.klasic@skola.hr');

insert into radionice (naziv, datum, uciteljica) values
('Kreativno pisanje', '2025-06-15 10:00:00', 1),
('Mala znanost', '2025-06-20 11:30:00', 2),
('Likovna radionica', '2025-06-22 09:00:00', 1),
('Robotika', '2025-06-25 13:00:00', 3),
('Glazbena igraonica', '2025-06-28 10:30:00', 4);

insert into djeca (ime, prezime, razred) values
('Luka', 'Kovacevic', '3.a'),
('Sara', 'Matic', '4.b'),
('Marko', 'Pavlovic', '3.a'),
('Ema', 'Novak', '5.c'),
('Filip', 'aric', '4.b'),
('Mia', 'Knez', '3.b'),
('Ivan', 'Horvat', '5.c');

insert into clanovi (dijete, radionica) values
(1, 1),
(2, 1),
(1, 2),
(3, 2),
(4, 3),
(5, 4),
(2, 4),
(6, 5),
(7, 5),
(3, 3);

select * from uciteljice;
select * from radionice;
select * from djeca;
select * from clanovi;

update uciteljice set prezime='Petrović' where sifra=2;
update uciteljice set prezime='Jurić' where sifra=3;
update uciteljice set prezime='Klasić' where sifra=4;

update djeca set prezime='Kovačević' where sifra=1;
update djeca set prezime='Matić' where sifra=2;
update djeca set prezime='Pavlović' where sifra=3;
update djeca set prezime='Arić' where sifra=5;

--drop table clanovi;
--drop table radionice;
--drop table uciteljice;
--drop table djeca;

delete uciteljice where email is null;
delete radionice where uciteljica in (select sifra from uciteljice where email is null);
delete clanovi where radionica in (select sifra from radionice where uciteljica=3);
delete djeca where sifra=5;

delete uciteljice where sifra=4;
delete radionice where uciteljica in (select sifra from uciteljice where sifra=4);
delete clanovi where radionica in (select sifra from radionice where uciteljica=4);
delete djeca where sifra not in (select dijete from clanovi);

delete uciteljice where sifra=2;
delete radionice where uciteljica in (select sifra from uciteljice where sifra=2);
delete clanovi where radionica in (select sifra from radionice where uciteljica=2);

delete uciteljice where sifra=1;
delete radionice where uciteljica in (select sifra from uciteljice where sifra=1);
delete clanovi where radionica in (select sifra from radionice where uciteljica=1);
delete djeca where sifra not in (select dijete from clanovi);