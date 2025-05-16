use master;
go
drop database if exists edunovawp8;
go
create database edunovawp8 collate Croatian_SI_AS;
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

insert into smjerovi (naziv,cijena,datumpokretanja,aktivan)
values ('Web programiranje',1200.54,'2025-05-16 17:00:01',1);

insert into smjerovi (naziv) values
('Serviser'),('Web dizajn'),('Marketing');

insert into grupe (naziv,smjer)
values('WP8',1),('WP7',1),('S1',2);

insert into polaznici (prezime, ime, email) values
('Gavran','Barbara','barbaragavran67@gmail.com'),
('Šteko','Ivan','ivan.steko5@gmail.com'),
('Jaklić','Bruno','bruno.jaklic.2005@gmail.com'),
('Sarkić','Hristina','Hristinasarkic@gmail.com'),
('Petrač','Darijan','darijan.petrac@gmail.com'),
('Abramić','Barbara','abramic7barbara7@gmail.com'),
('Dujak','Dražen','dujak.drazen@gmail.com'),
('Arambašić','Dario','DarioArambasic@outlook.com'),
('Vučić','Zlata','zltvvu7@gmail.com'),
('Hadžić','Ivan','ivan.hadzic07@gmail.com'),
('Živković','Katarina','kzivkovic230@gmail.com'),
('Klajić','Nataša','nateabach@gmx.net'),
('Matijević','David','matijevicdavid4@gmail.com'),
('Nemet Borić','Biljana','biljananemetos@gmail.com'),
('Somborac','Lara','larasomborac5@gmail.com'),
('Smrček','Tomislav','tomislavsmrk2@gmail.com'),
('Hepp','Barbara','barbara-hepp@hotmail.com'),
('Knežević','Ante','knezevicantisa@gmail.com'),
('Stošić','Zlatko','stosic.zlatko@gmail.com'),
('Darojković','Elizabeta','darojkovicelizabeta@gmail.com'),
('Dadić','Mateja','mateja.dadic@gmail.com'),
('Božić','Matej','matejbozic57@gmail.com'),
('Knežević','Drago','knezevicdrago3@gmail.com'),
('Milić','Lana','lana.milic15@gmail.com'),
('Ninčević','Domagoj','nincevicdomagoj@gmail.com'),
('Bašić','Asmir','asmir.basic@zeljko.hr'),
('Mandić','Andrea','andrea.mandic.anela@gmail.com'),
('Mirković','Milivoje','daky696@gmail.com'),
('Andraković','Nenad','nenad.andrak@gmail.com');

insert into clanovi (grupa,polaznik) values
(1,1),(1,2),(1,3),(1,4),(1,5),(1,6),(1,7),(1,8),(1,9),(1,10),
(1,11),(1,12),(1,13),(1,14),(1,15),(1,16),(1,17),(1,18),(1,19),(1,20),
(1,21),(1,22),(1,23),(1,24),(1,25),(1,26),(1,27),(1,28),(1,29);

insert into clanovi (grupa,polaznik) values
(3,6),(3,19),(3,27);