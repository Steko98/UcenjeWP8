--Zadaci za kolokvij_vjezba_4 (u zagradi je maksimalan broj bodova) 
use master;
go
drop database if exists vjezba4;
go
create database vjezba4 collate Croatian_CI_AS;
go
use vjezba4;

--0. Kreirajte tablice (16) i veze između tablica. (6) 

create table ostavljen(
sifra int not null primary key identity(1,1),
modelnaocala varchar(43),
introvertno bit,
kuna decimal(14,10)
);

create table punac(
sifra int not null primary key identity(1,1),
treciputa datetime,
majica varchar(46),
jmbag char(11) not null,
novcica decimal(18,7) not null,
maraka decimal(12,6) not null,
ostavljen int not null references ostavljen(sifra)
);

create table mladic(
sifra int not null primary key identity(1,1),
kuna decimal(15,9),
lipa decimal(18,5),
nausnica int,
stilfrizura varchar(49),
vesta varchar(34) not null,
);

create table zena(
sifra int not null primary key identity(1,1),
suknja varchar(39) not null,
lipa decimal(18,7),
prstena int not null
);

create table zena_mladic(
sifra int not null primary key identity(1,1),
zena int not null references zena(sifra),
mladic int not null references mladic(sifra)
);

create table snasa(
sifra int not null primary key identity(1,1),
introvertno bit,
treciputa datetime,
haljina varchar(44) not null,
zena int not null references zena(sifra)
);

create table becar(
sifra int not null primary key identity(1,1),
novcica decimal(14,8),
kratkamajica varchar(48) not null,
bojaociju varchar(36) not null,
snasa int not null references snasa(sifra)
);

create table prijatelj(
sifra int not null primary key identity(1,1),
eura decimal(16,9),
prstena int not null,
gustoca decimal(15,6),
jmbag char(11) not null,
suknja varchar(47) not null,
becar int not null references becar(sifra),
);

--1. U tablice becar, snasa i zena_mladic unesite po 3 retka. (7)

INSERT INTO ostavljen (modelnaocala, introvertno, kuna) VALUES
('Ray-Ban Wayfarer', 1, 1200.55),
('Oakley Frogskins', 0, 850.20),
('Prada Cat Eye', 1, 2100.99),
('Gucci Aviator', 0, 1500.00),
('Police Square', 1, 900.75);

INSERT INTO punac (treciputa, majica, jmbag, novcica, maraka, ostavljen) VALUES
('2023-01-15 10:30:00', 'Karirana košulja', '12345678901', 5000.75, 1000.50, 1),
('2022-11-22 14:00:00', 'Polo majica', '10987654321', 3200.20, 650.30, 2),
('2024-03-01 09:15:00', 'Sportska majica', '11223344556', 7800.90, 1500.80, 3),
('2023-07-07 18:45:00', 'Radna odjeća', '65432109876', 2100.10, 400.15, 4),
('2022-09-05 11:00:00', 'Elegantna majica', '98765432109', 6000.00, 1200.00, 5);

INSERT INTO mladic (kuna, lipa, nausnica, stilfrizura, vesta) VALUES
(750.25, 150.30, 2, 'Kratka i razbarušena', 'Crna kožna vesta'),
(1200.00, 250.70, 1, 'Duga i valovita', 'Siva pletena vesta'),
(300.50, 50.10, 0, 'Klasični fade', 'Plava traper vesta'),
(900.10, 180.20, 3, 'Punđa', 'Zelena vunena vesta'),
(550.80, 100.50, 1, 'Jež', 'Bijela sportska vesta');

INSERT INTO zena (suknja, lipa, prstena) VALUES
('Duga cvjetna suknja', 200.50, 3),
('Kratka traper suknja', 100.20, 1),
('Poslovna pencil suknja', 29.00, 2),
('Ljetna lanena suknja', 150.00, 0),
('Svečana satenska suknja', 400.90, 4);

INSERT INTO zena_mladic (zena, mladic) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5),
(1, 3),
(2, 5);

INSERT INTO snasa (introvertno, treciputa, haljina, zena) VALUES
(0, null, 'Elegantna večernja haljina', 1),
(1, '2022-08-20 12:00:00', 'Ležerna ljetna haljina', 2),
(0, '2024-02-01 09:00:00', 'Poslovna haljina', 3),
(1, null, 'Boho haljina', 4),
(0, '2022-06-01 10:00:00', 'Svečana koktel haljina', 5);

INSERT INTO becar (novcica, kratkamajica, bojaociju, snasa) VALUES
(1500.25, 'Bijela majica s natpisom', 'Plave', 1),
(800.70, 'Crna sportska majica', 'Smeđe', 2),
(2200.10, 'Siva polo majica', 'Zelene', 3),
(500.00, 'Žuta majica bez rukava', 'Sive', 4),
(1800.99, 'Plava prugasta majica', 'Plave', 5);

INSERT INTO prijatelj (eura, prstena, gustoca, jmbag, suknja, becar) VALUES
(500.50, 1, 1.25, '11223344550', 'Crna mini suknja', 1),
(1000.00, 2, 1.30, '00112233445', 'Bež platnena suknja', 2),
(250.75, 18, 1.15, '55667788990', 'Crvena karirana suknja', 3),
(700.20, 3, 1.40, '99887766554', 'Jeans suknja', 4),
(1200.80, 17, 1.20, '44332211009', 'Lila duga suknja', 5);

--2. U tablici punac postavite svim zapisima kolonu majica na vrijednost Osijek. (4)

update punac set majica='Osijek';

--3. U tablici prijatelj obrišite sve zapise čija je vrijednost kolone prstena veće od 17. (4) 

delete from prijatelj
where prstena>17;

select * from prijatelj;

--4. Izlistajte haljina iz tablice snasa uz uvjet da vrijednost kolone treciputa nepoznate. (6) 

select haljina
from snasa
where treciputa is null;

--5. Prikažite nausnica iz tablice mladic, jmbag iz tablice prijatelj te kratkamajica iz tablice becar
-- uz uvjet da su vrijednosti kolone treciputa iz tablice snasa poznate te da su vrijednosti kolone lipa iz tablice zena različite od 29.
-- Podatke posložite po kratkamajica iz tablice becar silazno. (10) 

select a.nausnica, f.jmbag, e.kratkamajica
from mladic a
inner join zena_mladic b on a.sifra=b.mladic
inner join zena c on c.sifra=b.zena
inner join snasa d on d.zena=c.sifra
inner join becar e on e.snasa=d.sifra
inner join prijatelj f on f.becar=e.sifra
where d.treciputa is null and c.lipa !=29
order by e.kratkamajica desc;

--6. Prikažite kolone lipa i prstena iz tablice zena čiji se primarni ključ ne nalaze u tablici zena_mladic. (5)

select a.lipa, a.prstena
from zena a
left join zena_mladic b on a.sifra=b.zena
where b.zena is null;
