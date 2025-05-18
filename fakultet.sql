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
kolegij int not null references kolegiji(sifra)
);

create table prijave(
student int not null references studenti(sifra),
rok int not null references rokovi(sifra),
ocjena int,
polozeno bit
);

insert into studenti (ime,prezime,smjer,godina) values
('Ana','Horvat','Povijest','3. preddiplomski'),
('Ivan','Kovačević','Povijest','3. preddiplomski'),
('Marija','Babić','Povijest','3. preddiplomski'),
('Josip','Marić','Povijest','3. preddiplomski'),
('Marko','Jurić','Povijest','3. preddiplomski');

insert into kolegiji (naziv, ectsbodovi) values
('Hrvatske zemlje u razvijenom srednjem vijeku',3),
('Povijesna geografija i kartografija',2);

insert into rokovi (datum, ucionica, kolegij) values
('2024-06-09 09:00:00',32,1),
('2024-07-04 09:30:00',84,1),
('2024-06-28 17:45:00',45,2),
('2024-07-05 16:00:00',73,2);

insert into prijave (student,rok,ocjena,polozeno) values
(1, 1, 1, 0),
(1, 1, 3, 1),
(2, 1, 5, 1),
(3, 1, 2, 1),
(3, 2, 4, 1),
(4, 3, 5, 1),
(5, 3, 1, 0),
(5, 4, 3, 1);

select * from studenti;
select * from kolegiji;
select * from rokovi;
select * from prijave;

select * from prijave where rok=1;

update prijave set rok=2 where student=1 AND ocjena=3;