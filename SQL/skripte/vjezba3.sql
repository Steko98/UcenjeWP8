use master;
go
drop database if exists vjezba3;
go
create database vjezba3 collate Croatian_CI_AS;
go
use vjezba3;

--0. Kreirajte tablice (16) i veze između tablica. (6) 

create table cura(
sifra int not null primary key identity(1,1),
dukserica varchar(49),
maraka decimal(13,7),
drugiputa datetime,
majica varchar(49),
novcica decimal(15,8),
ogrlica int not null
);

create table svekar(
sifra int not null primary key identity(1,1),
novcica decimal(16,8) not null,
suknja varchar(44) not null,
bojakose varchar(36),
prstena int,
narukvica int not null,
cura int not null references cura(sifra)
);

create table brat(
sifra int not null primary key identity(1,1),
jmbag char(11),
ogrlica int not null,
ekstrovertno bit not null
);
create table prijatelj(
sifra int not null primary key identity(1,1),
kuna decimal(16,10),
haljina varchar(37),
lipa decimal(13,10),
dukserica varchar(31),
indiferentno bit not null
);

create table prijatelj_brat(
sifra int not null primary key identity(1,1),
prijatelj int not null references prijatelj(sifra),
brat int not null references brat(sifra)
);

create table ostavljena(
sifra int not null primary key identity(1,1),
kuna decimal (17,5),
lipa decimal(15,6),
majica varchar(36),
modelnaocala varchar(31) not null,
prijatelj int not null references prijatelj(sifra)
);

create table snasa(
sifra int not null primary key identity(1,1),
introvertno bit,
kuna decimal(15,6) not null,
eura decimal(12,9) not null,
treciputa datetime,
ostavljena int not null references ostavljena(sifra)
);

create table punica(
sifra int not null primary key identity(1,1),
asocijalno bit,
kratkamajica varchar(44),
kuna decimal(13,8) not null,
vesta varchar(32) not null,
snasa int references snasa(sifra)
);




--1. U tablice snasa, ostavljena i prijatelj_brat unesite po 3 retka. (7) 

INSERT INTO cura (dukserica, maraka, drugiputa, majica, novcica, ogrlica) VALUES
('Plava s kapuljačom', 123.4567890, '2024-05-10 14:30:00', 'Bijela pamučna', 500.12345678, 1),
('Crna sportska', NULL, '2023-11-22 09:00:00', 'Prugasta', 1200.56789012, 2),
('Siva s natpisom', 78.9012345, NULL, 'Zelena polo', 75.01010101, 3),
(NULL, 15.0000000, '2025-01-01 08:00:00', 'Crvena kratkih rukava', 2500.00000000, 4),
('Zelena vintage', 200.2000000, '2024-07-18 17:45:00', 'Žuta majica', 10.99999999, 5);

INSERT INTO svekar (novcica, suknja, bojakose, prstena, narukvica, cura) VALUES
(1000.50000000, 'Duga cvjetna', 'Sijeda', 1, 10, 1),
(50.75000000, 'Traper mini', 'Smeđa', 0, 5, 2),
(3200.10000000, 'Kožna pencil', 'Plava', 2, 8, 3),
(1.99000000, 'Pletena duga', NULL, 1, 3, 4),
(450.00000000, 'Šarena ljetna', 'Crna', 3, 12, 5);

INSERT INTO brat (jmbag, ogrlica, ekstrovertno) VALUES
('12345678901', 1, 1),
('98765432109', 2, 0),
('11223344556', 3, 1),
('65432109876', 4, 0),
('01234567890', 5, 1);

INSERT INTO prijatelj (kuna, haljina, lipa, dukserica, indiferentno) VALUES
(1234.5678901234, 'Crna koktel', 789.0123456789, 'Siva hoodie', 0),
(50.1234567890, 'Ljetna prugbasta', 12.3456789012, 'Plava sportska', 1),
(750.0000000000, 'Večernja svilena', 25.0000000000, NULL, 0),
(NULL, 'Casual trbaper', 5.5555555555, 'Crvena s printom', 1),
(200.2000000000, 'Elegantna čipkbasta', 0.9999999999, 'Zelena s patentom', 0);

INSERT INTO prijatelj_brat (prijatelj, brat) VALUES
(1, 1),
(2, 3),
(3, 2),
(4, 5),
(5, 4);

INSERT INTO ostavljena (kuna, lipa, majica, modelnaocala, prijatelj) VALUES
(1500.75000, 200.123456, 'Crna s natpisom', 'Ray-Ban Wayfarer', 1),
(300.00000, 15.789012, 'Bijela V-izrez', 'Aviator', 2),
(NULL, 35.000000, 'Prugasta košulja', 'Cat-eye', 3),
(800.25000, 20.000000, 'Siva hoodie', 'Okrugle', 4),
(10.10000, 91.000000, 'Zelena polo', 'Sportski wrap', 5);

INSERT INTO snasa (introvertno, kuna, eura, treciputa, ostavljena) VALUES
(0, 10000.500000, 123.567890123, '2024-03-01 10:00:00', 1),
(1, 500.123456, 50.000000000, '2023-09-15 18:30:00', 2),
(0, 75.000000, 5.000000000, NULL, 3),
(1, 2500.999999, 200.750000000, '2025-01-20 11:15:00', 4),
(0, 1.000000, 0.100000000, '2024-06-01 14:00:00', 5);

INSERT INTO punica (asocijalno, kratkamajica, kuna, vesta, snasa) VALUES
(0, 'Bijela pamučna', 1000.00000000, 'Crna vunena', 1),
(1, 'Crna sportska', 50.50000000, 'Plava pletena', 2),
(0, 'ab', 200.75000000, 'Siva hoodie', 3),
(1, NULL, 10.00000000, 'Bež kardigan', 4),
(0, 'Zelena s printom', 5000.00000000, 'Zimska debela', 5);

--2. U tablici svekar postavite svim zapisima kolonu suknja na vrijednost Osijek. (4) 

update svekar set suknja='Osijek';

--3. U tablici punica obrišite sve zapise čija je vrijednost kolone kratkamajica jednako AB. (4)

delete punica where kratkamajica='ab';

--4. Izlistajte majica iz tablice ostavljena uz uvjet da vrijednost kolone lipa nije 9,10,20,30 ili 35. (6) 

select majica, lipa from ostavljena
where lipa!=9 and lipa!=10 and lipa!=20 and lipa!=30 and lipa!=35;

--5. Prikažite ekstroventno iz tablice brat, vesta iz tablice punica te kuna iz tablice snasa
-- uz uvjet da su vrijednosti kolone lipa iz tablice ostavljena različito od 91
-- te da su vrijednosti kolone haljina iz tablice prijatelj sadrže niz znakova ba.
-- Podatke posložite po kuna iz tablice snasa silazno. (10) 

select a.ekstrovertno, f.vesta, e.kuna
from brat a
inner join prijatelj_brat b on a.sifra=b.brat
inner join prijatelj c on c.sifra=b.prijatelj
inner join ostavljena d on d.prijatelj=c.sifra
inner join snasa e on e.ostavljena=d.sifra
inner join punica f on f.snasa=e.sifra
where d.lipa!=91 and c.haljina like '%ba%'
order by e.kuna desc;

--6. Prikažite kolone haljina i lipa iz tablice prijatelj čiji se primarni ključ ne nalaze u tablici prijatelj_brat. (5)

select a.haljina, a.lipa
from prijatelj a
left join prijatelj_brat b on a.sifra=b.prijatelj
where b.prijatelj is null;