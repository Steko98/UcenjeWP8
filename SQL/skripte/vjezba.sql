select b.naziv as smjer, a.naziv as grupa, b.cijena, a.predavac
from grupe a inner join smjerovi b
on a.smjer=b.sifra;

select * from grupe;

select a.naziv as smjer, b.naziv as grupa
from smjerovi a left join grupe b
on a.sifra=b.smjer;

select
b.naziv as smjer, a.naziv as grupa, a.predavac, d.ime, d.prezime
from grupe a
inner join smjerovi b on a.smjer=b.sifra
inner join clanovi as c on a.sifra=c.grupa
inner join polaznici as d on c.polaznik=d.sifra
where b.sifra=1;

select c.ime, c.prezime
from grupe a
inner join clanovi b on a.sifra=b.grupa
inner join polaznici c on c.sifra=b.polaznik
where a.naziv='WP8';

use knjiznica;

select a.naslov, b.ime, b.prezime, b.datumrodenja
from katalog a
inner join autor b on b.sifra=a.autor
where b.datumrodenja between '1980-01-01' and '1980-12-31'
order by 4;

select * from izdavac
where naziv like '%d.o.o%' and aktivan=1 and naziv like '%os%';

insert into autor(sifra,ime,prezime,datumrodenja)
values (4,'Ivan','Šteko','1998-07-11');

select ime, prezime from autor where ime like '%Ivan%';

update katalog set autor=4 where naslov='Luna je okrutna ljubavnica';
update katalog set naslov='Lana je okrutna ljubavnica' where sifra=2938;

delete katalog where sifra=2938;

use svastara;

select a.rednibroj, c.naziv, sum(b.cijena*b.kolicina) as ukupno
from primke a inner join ArtikliNaPrimci b
on a.sifra=b.primka
inner join dobavljaci c on a.dobavljac=c.sifra
--where a.rednibroj='1/2008'
group by a.rednibroj, c.naziv
having sum(b.cijena*b.kolicina)>15000000;