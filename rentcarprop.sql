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

CREATE TABLE Customers (
Id int,
UserId int,
CompanyName varchar(255)
);

CREATE TABLE Rentals (
Id int,
CarId int,
CustomerId int,
RentDate date,
ReturnDate date
);

CREATE TABLE Users(
Id int,
FirstName varchar(255),
LastName varchar(255),
Email varchar(255),
Password varchar(21)
);