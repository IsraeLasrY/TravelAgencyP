drop table CreditCard;

USE tempdb
GO

create table CreditCard
(

NameOnCard VARCHAR(50),
CardNumber VARCHAR(50) PRIMARY KEY ,
ExpirationDate VARCHAR(50),
ID VARCHAR (50),
FOREIGN KEY (ID) REFERENCES UserInfo(ID)
);




