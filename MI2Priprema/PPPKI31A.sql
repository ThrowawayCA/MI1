create database PPPKI31A
go

use PPPKI31A
go

create table Izvodjac
(
	IDIzvodjac int not null primary key identity,
	Ime nvarchar(50) not null
)
go

create table Album
(
	IDAlbum int not null primary key identity,
	IzvodjacID int not null references Izvodjac(IDIzvodjac),
	NaslovAlbuma nvarchar(50) not null
)
go

create table Pjesma
(
	IDPjesma int not null primary key identity,
	AlbumID int not null references Album(IDAlbum),
	NaslovPjesme nvarchar(50) not null
)
go

insert into Izvodjac values ('Edo Maajka')
insert into Izvodjac values ('Yammat')
insert into Izvodjac values ('TBF')

insert into Album values ('1','No Sikiriki');
insert into Album values ('1','Slušaj mater');
insert into Album values ('1','Balkansko a Naše');

insert into Album values ('2','Kompilacija');
insert into Album values ('2','Plan B');

insert into Album values ('3','Maxon Universal');
insert into Album values ('3','PingPong');
insert into Album values ('3','Uskladimo toplomjere');
insert into Album values ('3','Pistaccio Metallic');


insert into Pjesma values ('1','To sam ja');
insert into Pjesma values ('1','Pržžžži');
insert into Pjesma values ('1','Dragi moj Vlado');
insert into Pjesma values ('1','No Sikiriki');
insert into Pjesma values ('1','Ne-Mo-Žeš');
insert into Pjesma values ('1','Samo Za Raju');

insert into Pjesma values ('2','Intro');
insert into Pjesma values ('2','Minimalni Rizik');
insert into Pjesma values ('2','Rado viðen');
insert into Pjesma values ('2','Jesmo li Sami?');
insert into Pjesma values ('2','Prikaze');
insert into Pjesma values ('2','Faca');
insert into Pjesma values ('2','Znaš me');
insert into Pjesma values ('2','Šverc Komerc');
insert into Pjesma values ('2','Pare Pare');
insert into Pjesma values ('2','Za i Protiv');
insert into Pjesma values ('2','Molitva');
insert into Pjesma values ('2','Nemoj se Bojat');
insert into Pjesma values ('2','Outro');

insert into Pjesma values ('3','Intro');
insert into Pjesma values ('3','Daj Mi Ljubav');
insert into Pjesma values ('3','Klimaj Glavom');
insert into Pjesma values ('3','Ove Godine Slavim');
insert into Pjesma values ('3','Gansi');
insert into Pjesma values ('3','Pokradi Lovu');
insert into Pjesma values ('3','Sve Prolazi');
insert into Pjesma values ('3','Ovaj Ritam Volim');
insert into Pjesma values ('3','Veliki Medo');
insert into Pjesma values ('3','Hag');
insert into Pjesma values ('3','I Dalje Slušam');
insert into Pjesma values ('3','Svi Su Otišli Na More');
insert into Pjesma values ('3','Voli Vas Maajka');

insert into Pjesma values ('4','Svijet u meni');
insert into Pjesma values ('4','Nikoga ja ne krivim');
insert into Pjesma values ('4','Broj');
insert into Pjesma values ('4','Probudi se');
insert into Pjesma values ('4','Bezimena');
insert into Pjesma values ('4','Sutra');
insert into Pjesma values ('4','Plašiš me');

insert into Pjesma values ('5','U bojama');
insert into Pjesma values ('5','Putujem');
insert into Pjesma values ('5','O nama');
insert into Pjesma values ('5','Visoko');
insert into Pjesma values ('5','Vidim sami');
insert into Pjesma values ('5','Tvoje lice se promijenilo');
insert into Pjesma values ('5','Nada');
insert into Pjesma values ('5','Montreal');
insert into Pjesma values ('5','Nestajem');
insert into Pjesma values ('5','Ti i ja');
insert into Pjesma values ('5','Da li je stvarno');

insert into Pjesma values ('6','UV zrake');
insert into Pjesma values ('6','Papilova');
insert into Pjesma values ('6','Guzice i sise');
insert into Pjesma values ('6','Nostalgièna');
insert into Pjesma values ('6','Tobogan');
insert into Pjesma values ('6','Bog i Zemljani');
insert into Pjesma values ('6','Esej');
insert into Pjesma values ('6','Alles Gut');
insert into Pjesma values ('6','Masovna hipnoza');

insert into Pjesma values ('7','Slobodni stil');
insert into Pjesma values ('7','Malo san maka');
insert into Pjesma values ('7','Mali');
insert into Pjesma values ('7','Nedodirljivi');
insert into Pjesma values ('7','Moj um pali');
insert into Pjesma values ('7','Vuk');
insert into Pjesma values ('7','Adam');
insert into Pjesma values ('7','Don Prle');
insert into Pjesma values ('7','Stanje uma');

insert into Pjesma values ('8','Genije');
insert into Pjesma values ('8','Psihijatrija');
insert into Pjesma values ('8','Stari');
insert into Pjesma values ('8','Manipulacije');
insert into Pjesma values ('8','Skener');
insert into Pjesma values ('8','Obraèun kod Hakikija');
insert into Pjesma values ('8','Sve se vraæa sve se plaæa');
insert into Pjesma values ('8','Život je lijep');
insert into Pjesma values ('8','Prava ljubav');

insert into Pjesma values ('9','Tragièni junak');
insert into Pjesma values ('9','San');
insert into Pjesma values ('9','Spin doktor');
insert into Pjesma values ('9','Uvik kontra');
insert into Pjesma values ('9','Mater');
insert into Pjesma values ('9','Grad spava');
insert into Pjesma values ('9','Vrag');
insert into Pjesma values ('9','Dalmatino');
insert into Pjesma values ('9','Veseljko');
insert into Pjesma values ('9','Pozitivan stav');
insert into Pjesma values ('9','Uspavanka');
