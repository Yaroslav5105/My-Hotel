use hotel ;
create table tablebooking(
id_name int(10) not null ,
id_room int(10) not null,
price int(15) not null,
data_of_arrival int(20) not null ,
data_of_departure int(20) not null ,
primary key(id_name));

create table tablestatus(
id_status int(10) not null ,
name_status varchar(50) not null ,
primary key(id_status));

create table tablesertvis(
id_servisa int(10) not null ,
tip_servese varchar(30) not null ,
primary key(id_servisa));

create table tablework(
id_work int(10) not null ,
name_worker varchar(30) not null ,
surname_worker varchar(30) not null ,
id_servis int(10) not null ,
primary key(id_work));

create table tablemenu(
price int(10) not null ,
id_dishes int(10) not null ,
information varchar(100) not null ,
primary key(id_dishes));

create table tableroom(
id int(10) not null ,
id_statusa int(10) not null ,
number_of_seats int (10) not null ,
information varchar(100) not null ,
price int(10) not null ,
primary key(id));

create table tablename(
id int(10) not null ,
name varchar (30) not null ,
surname varchar (30) not null ,
number int(12) not null ,
primary key(id));

create table tableservice(
id_room int (10) not null ,
time int(15) not null ,
id_service int(10) not null ,
comment varchar(100) not null ,
price int(10) not null ,
id_work int(10) not null ,
id_status int(10) not null,
primary key(id_room));
