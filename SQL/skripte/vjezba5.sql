use master;
go
drop database if exists vjezba5;
go
create database vjezba5 collate Croatian_CI_AS;
go
use vjezba5;

--0. Kreirajte tablice (16) i veze između tablica. (6) 

create table zarucnik(
sifra int not null primary key identity(1,1),
jmbag char(11),
lipa decimal(12,8),
indiferentno bit not null
);

create table mladic(
sifra int not null primary key identity(1,1),
kratkamajica varchar(48) not null,
haljina varchar(30) not null,
asocijalno bit,
zarucnik int
);

create table cura(
sifra int not null primary key identity(1,1),
carape varchar(41) not null,
maraka decimal(17,10) not null,
asocijalno bit,
vesta varchar(47) not null
);

create table svekar(
sifra int not null primary key identity(1,1),
bojakose varchar(33),
majica varchar(31),
carape varchar(43) not null,
haljina varchar(43),
narukvica int,
eura decimal(14,5) not null
);

create table svekar_cura(
sifra int not null primary key identity(1,1),
svekar int references svekar(sifra),
cura int references cura(sifra)
);

create table punac(
sifra int not null primary key identity(1,1),
dukserica varchar(33),
prviputa datetime,
majica varchar(36),
svekar int not null references svekar(sifra)
);

create table punica(
sifra int not null primary key identity(1,1),
hlace varchar(43) not null,
nausnica int not null,
ogrlica int,
vesta varchar(49) not null,
modelnaocala varchar(31) not null,
treciputa datetime not null,
punac int not null references punac(sifra)
);

create table ostavljena(
sifra int not null primary key identity(1,1),
majica varchar(33),
ogrlica int not null,
carape varchar(44),
stilfrizura varchar(42),
punica int not null references punica(sifra)
);

--1. U tablice punica, punac i svekar_cura unesite po 3 retka. (7) 

-- Inserta za tablicu 'zarucnik'
INSERT INTO zarucnik (jmbag, lipa, indiferentno) VALUES
('12345678901', 2345.67890123, 0),
('98765432109', 8765.43210987, 1),
('11223344556', 1223.34455667, 0),
('66554433221', 6554.43322112, 1),
('00112233445', 112.23344556, 0);

-- Inserta za tablicu 'cura'
INSERT INTO cura (carape, maraka, asocijalno, vesta) VALUES
('Bijele pamučne čarape', 1234567.8901234567, 0, 'Plava vunena vesta'),
('Crne najlon čarape', 9876543.2109876543, 1, 'Zelena pletena vesta'),
('Šarene sportske čarape', 1122334.4556677889, 0, 'Siva hoodica vesta'),
('Sive termo čarape', 6655443.3221122334, 1, 'Crvena vesta na kopčanje'),
('Debele zimske čarape', 0011223.3445566778, 0, 'Bež prevelika vesta');

-- Inserta za tablicu 'svekar'
INSERT INTO svekar (bojakose, majica, carape, haljina, narukvica, eura) VALUES
('Smeđa', 'Pamučna majica ba', 'Sportske čarape', 'Ljetna haljina', 1, 1000.50),
('Plava', 'Lanena majica', 'Poslovne čarape', 'Večernja haljina', 2, 2500.75),
('Crna', 'T-shirt ba', 'Bijele čarape', 'Dnevna haljina', 3, 500.25),
('Riđa', 'Polo majica', 'Debele čarape', 'Koktel haljina', 4, 1500.00),
('Sijeda', 'Košulja ba', 'Tanko čarape', 'Vjenčanica', 5, 3000.99);

-- Inserta za tablicu 'mladic'
INSERT INTO mladic (kratkamajica, haljina, asocijalno, zarucnik) VALUES
('Crna kratka majica', 'Svečana haljina', 0, 1),
('Bijela kratka majica', 'Ležerna haljina', 1, 2),
('Siva kratka majica', 'Mala crna haljina', 0, 3),
('Plava kratka majica', 'Duga ljetna haljina', 1, 4),
('Zelena kratka majica', 'Koktel haljina', 0, 5);

-- Inserta za tablicu 'svekar_cura'
INSERT INTO svekar_cura (svekar, cura) VALUES
(1, 1),
(null, 2),
(3, 3),
(null, 4),
(null, 5);

-- Inserta za tablicu 'punac'
INSERT INTO punac (dukserica, prviputa, majica, svekar) VALUES
('Siva dukserica', null, 'Crna majica', 1),
('Crna dukserica', '2019-05-20 14:30:00', 'Bijela majica', 2),
('Plava dukserica', '2021-11-01 08:45:00', 'Siva majica', 3),
('Zelena dukserica', null, 'Plava majica', 4),
('Bijela dukserica', '2022-09-10 11:00:00', 'Zelena majica', 5);

-- Inserta za tablicu 'punica'
INSERT INTO punica (hlace, nausnica, ogrlica, vesta, modelnaocala, treciputa, punac) VALUES
('Crne hlače', 1, 1, 'Crvena vesta', 'Ray-Ban Wayfarer', '2023-01-20 09:00:00', 1),
('Plave traperice', 2, 2, 'Žuta vesta', 'Oakley Frogskins', '2024-02-25 13:00:00', 2),
('Bež hlače', 3, 3, 'Zelena vesta', 'Persol 649', '2023-03-10 16:00:00', 3),
('Sive hlače', 4, 4, 'Plava vesta', 'Gucci Aviator', '2024-04-05 10:00:00', 4),
('Bijele hlače', 5, 5, 'Crna vesta', 'Dior So Real', '2023-05-15 14:00:00', 5);

-- Inserta za tablicu 'ostavljena'
INSERT INTO ostavljena (majica, ogrlica, carape, stilfrizura, punica) VALUES
('Majica na pruge', 17, 'Bijele čarape', 'Bob frizura', 1),
('Cvjetna majica', 2, 'Crne čarape', 'Duga kosa', 2),
('Jednobojna majica', 3, 'Šarene čarape', 'Kratka frizura', 3),
('Majica s natpisom', 17, 'Sive čarape', 'Punđa', 4),
('Sportka majica', 5, 'Debele čarape', 'Rep', 5);

--2. U tablici mladic postavite svim zapisima kolonu haljina na vrijednost Osijek. (4) 



--3. U tablici ostavljena obrišite sve zapise čija je vrijednost kolone ogrlica jednako 17. (4) 



--4. Izlistajte majica iz tablice punac uz uvjet da vrijednost kolone prviputa nepoznate. (6) 



--5. Prikažite asocijalno iz tablice cura, stilfrizura iz tablice ostavljena te nausnica iz tablice punica
--uz uvjet da su vrijednosti kolone prviputa iz tablice punac poznate te da su vrijednosti kolone majica iz tablice svekar sadrže niz znakova ba. 
--Podatke posložite po nausnica iz tablice punica silazno. (10) 



--6. Prikažite kolone majica i carape iz tablice svekar čiji se primarni ključ ne nalaze u tablici svekar_cura. (5)