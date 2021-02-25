CREATE TABLE Cars (
Id int null,
BrandId int null,
ColorId int null,
ModelName varchar(255) null,
ModalYear varchar(255) null,
DailyPrice decimal null,
Description varchar(255) null,
);

CREATE TABLE Brands (
Id int null,
Name varchar(255) null,
);

CREATE TABLE Colors(
Id int null,
Name varchar(255) null,
);

CREATE TABLE Customers (
Id int null,
UserId int null,
CompanyName varchar(255) null
);

CREATE TABLE Rentals (
Id int null,
CarId int null,
CustomerId int null,
RentDate date null,
ReturnDate date null
);

CREATE TABLE Users(
Id int null,
FirstName varchar(255) null,
LastName varchar(255) null,
Email varchar(255) null,
Password varchar(21) null
);