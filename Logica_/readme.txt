create database reservasAntioquia;

use reservasAntioquia;

create table Reservas(
Id int primary key auto_increment,
Nombre varchar(100) not null,
Apellido varchar(100) not null,
Email varchar(100) not null,
Telefono varchar(100) not null,
Tipo_De_Evento varchar(100) not null,
Fecha varchar(20)not null,
Hora varchar(20)
);

insert into Reservas(Nombre,Apellido,Email,Telefono,Tipo_De_Evento,Fecha,Hora)
values ('matias','vera','gastonsl87@yahoo.com.ar','1152298736','cumpleaños','10/11/2024','21:00');
insert into Reservas(Nombre,Apellido,Email,Telefono,Tipo_De_Evento,Fecha,Hora)
values ('edinson','machado','edinson@yahoo.com.ar','19778929','fiesta de 15','12/12/2024','20:00');
insert into Reservas(Nombre,Apellido,Email,Telefono,Tipo_De_Evento,Fecha,Hora)
values ('jose','espinola','jose@yahoo.com.ar','11568936','cumpleaños','16/12/2024','23:00');
insert into Reservas(Nombre,Apellido,Email,Telefono,Tipo_De_Evento,Fecha,Hora)
values ('diego','gonzalez','diego@yahoo.com.ar','115264529','evento','15/11/2024','22:00');

select * from Reservas;