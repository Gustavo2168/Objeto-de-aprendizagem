create database giv;

use giv;


create table produtos
(
id int unsigned auto_increment not null primary key,
descricao varchar(50),
valor double,
quantidade int
);

