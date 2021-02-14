CREATE TABLE Cars (
Id int,
BrandId int,
ColorId int,
ModelName varchar(255),
ModalYear varchar(255),
DailyPrice decimal,
Description varchar(255),
);

CREATE TABLE Brands (
Id int,
Name varchar(255),
);

CREATE TABLE Colors(
Id int,
Name varchar(255),
);