

create table clients (
id integer not null primary key,
first_name	TEXT NOT NULL,
	last_name	TEXT NOT NULL,
	phone	INTEGER,
	email	TEXT,
	date_creation	INTEGER	
);

create table rims_dict (
id integer not null primary key ,
name varchar(50) not null,
abbr varchar(50) not null
);

insert into rims_dict (name,abbr) values('Tak','YES');
insert into rims_dict (name,abbr) values('Nie','NO');

create table season_dict(
id integer not null primary key,
name varchar(50) not null,
abbr varchar(50) not null
);

insert into season_dict(name,abbr) values('Letnie','SUMMER');
insert into season_dict(name,abbr) values ('Zimowe','WINTER');
insert into season_dict(name,abbr) values ('Wielosezonowe','MULTIGRADE');

create table tires (
id integer not null primary key,
manufacturer	TEXT NOT NULL,
size varchar(255) not null,
season_id integer not null  references season_dict (id),
rims_id integer not null  references rims_dict (id),
quantity INTEGER not null,
client_id INTEGER null  references clients (id),
comments text null,
date_creation varchar(255) null,
date_release varchar(255) null
);