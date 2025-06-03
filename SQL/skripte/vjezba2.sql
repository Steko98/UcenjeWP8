use master;
go
drop database if exists vjezba2;
go
create database vjezba2;
go
use vjezba2;

--0. Kreirajte tablice (16) i veze između tablica. (6) 

create table svekar(
sifra int not null primary key identity(1,1),
stilfrizura varchar(48),
ogrlica bit not null,
asocijalno bit not null
);

create table prijatelj(
sifra int not null primary key identity(1,1),
modelnaocala varchar(37),
treciputa datetime not null,
ekstrovertno bit not null,
prviputa datetime,
svekar int not null references svekar(sifra)
);

create table zarucnica(
sifra int not null primary key identity(1,1),
narukvica int,
bojakose varchar(37) not null,
novcica decimal(15,9),
lipa decimal(15,8) not null,
indiferentno bit not null
);

create table decko(
sifra int not null primary key identity(1,1),
indiferentno bit,
vesta varchar(34),
asocijalno bit not null
);

create table decko_zarucnica(
sifra int not null primary key identity(1,1),
decko int not null references decko(sifra),
zarucnica int not null references zarucnica(sifra)
);

create table cura(
sifra int not null primary key identity(1,1),
haljina varchar(33) not null,
drugiputa datetime not null,
suknja varchar(38),
narukvica bit,
introvertno bit,
majica varchar(40) not null,
decko int references decko(sifra)
);

create table neprijatelj(
sifra int not null primary key identity(1,1),
majica varchar(32),
haljina varchar(43) not null,
lipa decimal(16,8),
modelnaocala varchar(49) not null,
kuna decimal(12,6) not null,
jmbag char(11),
cura int
);

create table brat(
sifra int not null primary key identity(1,1),
suknja varchar(47),
ogrlica int not null,
asocijalno bit not null,
neprijatelj int not null references neprijatelj(sifra)
);


--1. U tablice neprijatelj, cura i decko_zarucnica unesite po 3 retka. (7) 

INSERT INTO svekar (stilfrizura, ogrlica, asocijalno) VALUES
('Klasična', 1, 0),
('Moderna', 0, 1),
('Retro', 1, 0),
('Kratka kosa', 0, 0),
('Duga kosa', 1, 1);

INSERT INTO prijatelj (modelnaocala, treciputa, ekstrovertno, prviputa, svekar) VALUES
('Ray-Ban Wayfarer', '2024-01-15 10:00:00', 1, '2023-05-20 14:30:00', 1),
('Oakley Frogskins', '2023-11-22 18:45:00', 0, '2022-03-10 09:15:00', 2),
('Persol 649', '2025-02-01 11:20:00', 1, '2024-08-01 16:00:00', 3),
('Gucci GG0011S', '2024-07-07 08:00:00', 0, '2023-01-01 12:00:00', 4),
('Police SPL352', '2023-09-30 20:00:00', 1, '2022-11-15 10:00:00', 5);

INSERT INTO zarucnica (narukvica, bojakose, novcica, lipa, indiferentno) VALUES
(101, 'Plava', 1500.75, 50.12345678, 0),
(NULL, 'Smeđa', 3200.50, 120.98765432, 1),
(203, 'Crvena', 750.25, 25.01010101, 0),
(405, 'Crna', 5000.00, 200.00000000, 1),
(NULL, 'Blonde', 100.99, 5.55555555, 0);

INSERT INTO decko (indiferentno, vesta, asocijalno) VALUES
(0, 'Siva vunena', 0),
(1, 'Crna bakožna', 1),
(0, 'Plava sportskaba', 0),
(1, 'Bež pletena', 0),
(0, 'Zelena bahoodie', 1);

-- Pretpostavljam da su id-jevi za decko i zarucnica već kreirani od prethodnih INSERT-a
-- Ovdje ću koristiti primjere id-jeva 1 do 5
INSERT INTO decko_zarucnica (decko, zarucnica) VALUES
(1, 1),
(2, 3),
(3, 2),
(4, 5),
(5, 4);

INSERT INTO cura (haljina, drugiputa, suknja, narukvica, introvertno, majica, decko) VALUES
('Ljetna cvjetna', '2024-03-01 10:30:00', 'Traper mini', 1, 0, 'Bijela pamučna', 1),
('Večernja crna', '2023-10-15 19:00:00', 'Duga svilena', 0, 1, 'Prugasta kratkih rukava', 2),
('Casual denim', '2025-01-20 14:00:00', 'Pencil suknja', 1, 0, 'Logo majica', 3),
('Koktel haljina', '2024-06-05 21:00:00', NULL, 0, 1, 'Jednobojna polo', 4),
('Maksi haljina', '2023-08-12 11:00:00', 'A-kroja', 1, 0, 'Šarena top', 5),
('Mini haljina', '2024-04-22 17:00:00', NULL, 0, 1, 'Crna dolčevita', NULL); -- Cura bez dečka

INSERT INTO neprijatelj (majica, haljina, lipa, modelnaocala, kuna, jmbag, cura) VALUES
('Crna band majica', 'Kožna haljina', 75.12345678, 'Aviator', 123.456789, '12345678901', 1),
('Bijela košulja', 'Elegantna koktel', 12.98765432, 'Cat-eye', 50.123456, '98765432109', 2),
('Siva polo', 'Sportski dres', 200.00000000, 'Sportski wrap', 300.000000, '11223344556', 3),
('Prazna majica', 'Jednostavna pamučna', 1.00000000, 'Okrugle', 10.000000, '65432109876', 4),
('Majica s natpisom', 'Duga ljetna', 50.50505050, 'Wayfarer Classic', 250.750000, '01234567890', 5),
('Bez majice', 'Kratka haljina', 10.10101010, 'Retro naočale', 5.500000, '54321098765', 6);

INSERT INTO brat (suknja, ogrlica, asocijalno, neprijatelj) VALUES
('Karirana suknja', 14, 0, 1),
('Traper suknja', 14, 1, 2),
('Sportska suknja', 1, 0, 3),
(NULL, 0, 0, 4),
('Kožna suknja', 14, 1, 5);

--2. U tablici prijatelj postavite svim zapisima kolonu treciputa na vrijednost 30. travnja 2020. (4) 

update prijatelj set treciputa='2020-04-30';

--3. U tablici brat obrišite sve zapise čija je vrijednost kolone ogrlica različito od 14. (4) 

delete brat where ogrlica!=14;

--4. Izlistajte suknja iz tablice cura uz uvjet da vrijednost kolone drugiputa nepoznate. (6) 

select suknja
from cura
where drugiputa is null;

--5. Prikažite novcica iz tablice zarucnica, neprijatelj iz tablice brat te haljina iz tablice neprijatelj uz uvjet da su vrijednosti kolone 
--drugiputa iz tablice cura poznate te da su vrijednosti kolone vesta iz tablice decko sadrže niz znakova ba. Podatke posložite po haljina iz 
--tablice neprijatelj silazno. (10) 

select a.novcica, f.neprijatelj, e.haljina
from zarucnica a 
inner join decko_zarucnica b on a.sifra=b.zarucnica
inner join decko c on c.sifra=b.decko
inner join cura d on c.sifra=d.decko
inner join neprijatelj e on e.cura=d.sifra
inner join brat f on f.neprijatelj=e.sifra
where d.drugiputa is not null and c.vesta like '%ba%'
order by e.haljina desc;

--6. Prikažite kolone vesta i asocijalno iz tablice decko čiji se primarni ključ ne nalaze u tablici decko_zarucnica. (5)

select a.vesta, a.asocijalno
from decko a
left join decko_zarucnica b on a.sifra=b.decko
where b.decko is null;