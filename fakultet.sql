use master;
go
drop database if exists fakultet;
go
create database fakultet collate Croatian_CI_AS;
go
use fakultet;

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

insert into studenti (ime,prezime,smjer,godina) values
('Ana','Horvat','Povijest','3. preddiplomski'),
('Ivan','Kovačević','Povijest','3. preddiplomski'),
('Marija','Babić','Povijest','3. preddiplomski'),
('Josip','Marić','Povijest','3. preddiplomski'),
('Marko','Jurić','Povijest','3. preddiplomski'),
('Ivana','Novak','Povijest','3. preddiplomski'),
('Stjepan','Kovačić','Povijest','3. preddiplomski'),
('Tomislav','Knežević','Povijest','3. preddiplomski'),
('Željka','Vuković','Povijest','3. preddiplomski'),
('Mario','Matić','Povijest','3. preddiplomski'),
('Petra','Marković','Povijest','3. preddiplomski'),
('Luka','Petrović','Povijest','3. preddiplomski'),
('Matea','Tomić','Povijest','3. preddiplomski'),
('Filip','Pavlović','Povijest','3. preddiplomski'),
('Sara','Kovač','Povijest','3. preddiplomski'),
('David','Božić','Povijest','3. preddiplomski'),
('Helena','Grgić','Povijest','3. preddiplomski'),
('Martin','Blažević','Povijest','3. preddiplomski'),
('Ena','Perić','Povijest','3. preddiplomski'),
('Ante','Pavić','Povijest','3. preddiplomski');

insert into kolegiji (naziv, ectsbodovi) values
('Hrvatske zemlje u razvijenom srednjem vijeku',3),
('Povijesna geografija i kartografija',2);

insert into rokovi (datum, ucionica, kolegij) values
('2025-06-09',32,1),
('2025-07-04',84,2);

insert into prijave (student,rok) values
(1, 1),
(2, 2),
(3, 1),
(4, 2),
(5, 1),
(6, 2),
(7, 1),
(8, 2),
(9, 1),
(10, 2),
(11, 1),
(12, 2),
(13, 1),
(14, 2),
(15, 1),
(16, 2),
(17, 1),
(18, 2),
(19, 1),
(20, 2);

select * from studenti;
select * from kolegiji;
select * from rokovi;
select * from prijave;

update rokovi set datum='2025-06-09 09:00:00' where sifra=1;
update rokovi set datum='2025-07-04 17:30:00' where sifra=2;