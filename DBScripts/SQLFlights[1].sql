drop table FlightsInfo;

USE tempdb
GO

create table FlightsInfo
(

FlightNumber varchar(50) primary key,
AirLine varchar(50),
Terminal varchar(2),
DestinationF varchar(50),
OriginF varchar(50),
DepDateF date,
LandDateF date,
DepT time,
LandT time,
Seats int,
PriceTicket int,
RoundTrip varchar(50)
);

INSERT INTO FlightsInfo VALUES ('AA-4579','EL-AL','3','Netherlands','Israel','2023/01/15','2023/01/16','23:00','3:00',305,250,'AB-4579');
INSERT INTO FlightsInfo VALUES ('AB-4579','EL-AL','3','Israel','Netherlands','2023/01/20','2023/01/20','14:00','18:00',305,250,'AA-4579');

INSERT INTO FlightsInfo VALUES ('AB-8857','EL-AL','1','France','Israel','2023/01/20','2023/01/21','23:00','5:00',250,200,''); 
INSERT INTO FlightsInfo VALUES ('LH-686','El Al','3','Spain','Israel','2023/01/15','2023/01/15','13:00','20:00',260,300,'LH-687');
INSERT INTO FlightsInfo VALUES ('LH-687','El Al','3','Israel','Spain','2023/01/25','2023/01/25','20:00','23:50',260,300,'LH-686');

INSERT INTO FlightsInfo VALUES ('AC-9020','AERO MEXICO','3','Colombia','Mexico','2023/01/15','2023/01/15','12:00','15:00',350,750,'');  
INSERT INTO FlightsInfo VALUES ('NH-5459','ALL NIPPON AIRWAYS','3','Russia','Ukraine','2023/01/15','2023/01/16','23:00','00:30',200,150,'');  
INSERT INTO FlightsInfo VALUES ('SN-7173','El Al','3','Portugal','Israel','2023/01/15','2023/01/15','10:00','13:00',321,300,'');  
INSERT INTO FlightsInfo VALUES ('UA-9120','ISRAIR AIRLINES','3','Israel','Brazil','2023/01/19','2023/01/20','22:00','10:00',500,799,'UA-9121');
INSERT INTO FlightsInfo VALUES ('UA-9121','ISRAIR AIRLINES','3','Brazil','Israel','2023/01/25','2023/01/26','18:00','3:00',500,799,'UA-9120');  

INSERT INTO FlightsInfo VALUES ('IZ-816','AMERICAN AIRLINES','3','United-States','Israel','2023/01/25','2023/01/27','23:00','3:00',550,999,'IZ-817');  
INSERT INTO FlightsInfo VALUES ('IZ-817','AMERICAN AIRLINES','3','United-States','Israel','2023/02/01','2023/02/02','21:00','6:00',550,999,'IZ-816');  

INSERT INTO FlightsInfo VALUES ('6H-726','El Al','3','Spain','Israel','2023/01/25','2023/01/26','20:00','1:00',195,600,'');  
INSERT INTO FlightsInfo VALUES ('LY-2372','El Al','3','Marocco','Israel','2023/02/01','2023/02/01','14:00','20:00',300,450,'');  
INSERT INTO FlightsInfo VALUES ('AA-8386','LUFTHANSA','3','Switzerland','Norway','2023/02/10','2023/02/10','10:00','13:00',150,156,'');  
INSERT INTO FlightsInfo VALUES ('UA-9471','EMIRATES','3','Israel','Qatar','2023/02/11','2023/02/11','9:00','15:00',250,450,'');  
INSERT INTO FlightsInfo VALUES ('LY-382','EMIRATES','3','United-Arab-mirates','Qatar','2023/02/19','2023/02/19','18:00','23:00',150,299,'');  
INSERT INTO FlightsInfo VALUES ('LH-680','El Al','3','Turkey','Israel','2023/03/01','2023/03/01','12:30','16:00',123,350,'');  
INSERT INTO FlightsInfo VALUES ('AM-6847','UNITED AIRLINES','3','United-States','Bolivia','2023/03/04','2023/03/04','15:00','18:00',256,500,'');  
INSERT INTO FlightsInfo VALUES ('AA-8390','AIR CANADA','3','Canada','United-States','2023/03/10','2023/03/11','20:00','6:00',100,90,'');  

INSERT INTO FlightsInfo VALUES ('IB-2393','BRUSSELS AIRLINES','3','Thailand','Netherlands','2023/04/06','2023/04/06','2:00','20:00',300,500,'IC-2393');
INSERT INTO FlightsInfo VALUES ('IC-2393','BRUSSELS AIRLINES','3','Netherlands','Thailand','2023/04/10','2023/04/11','20:00','10:00',300,500,'IB-2393'); 


INSERT INTO FlightsInfo VALUES ('UA-9470','EMIRATES','A','Thailand','Qatar','2023/02/11','2023/02/11','17:00','22:00',250,950,'UA-9484');
INSERT INTO FlightsInfo VALUES ('UA-9484','EMIRATES','A','Thailand','Qatar','2023/02/25','2023/02/25','14:00','22:50',250,950,'UA-9470');

INSERT INTO FlightsInfo VALUES ('UA-9472','EMIRATES','B','United-States','Qatar','2023/02/13','2023/02/14','23:00','3:00',260,850,'');
INSERT INTO FlightsInfo VALUES ('UA-9473','EMIRATES','C','United-Kingdom','Qatar','2023/02/13','2023/02/14','22:00','2:00',270,750,'');
INSERT INTO FlightsInfo VALUES ('UA-9474','EMIRATES','D','Togo','Qatar','2023/02/14','2023/02/14','13:00','16:00',280,650,'');
INSERT INTO FlightsInfo VALUES ('UA-9475','EMIRATES','E','South-Africa','Qatar','2023/02/15','2023/02/15','10:00','22:00',290,550,'');
INSERT INTO FlightsInfo VALUES ('UA-9476','EMIRATES','F','Peru','Qatar','2023/02/16','2023/02/16','2:00','20:00',300,450,'');
INSERT INTO FlightsInfo VALUES ('UA-9477','EMIRATES','G','Pakistan','Qatar','2023/02/17','2023/02/17','3:00','10:00',310,350,'');
INSERT INTO FlightsInfo VALUES ('UA-9478','EMIRATES','H','Italy','Qatar','2023/02/18','2023/02/18','12:00','23:00',330,250,'');
INSERT INTO FlightsInfo VALUES ('UA-9479','EMIRATES','I','Japan','Qatar','2023/02/19','2023/02/19','3:00','15:00',220,200,'');

INSERT INTO FlightsInfo VALUES ('UA-9480','EMIRATES','J','China','Qatar','2023/02/20','2023/02/21','19:00','1:00',200,150,'UA-9485');
INSERT INTO FlightsInfo VALUES ('UA-9485','EMIRATES','J','Qatar','China','2023/02/28','2023/02/28','14:00','21:00',200,150,'UA-9480');

INSERT INTO FlightsInfo VALUES ('AA-8391','UNITED AIRLINES','1','Qatar','United-States','2023/03/10','2023/03/11','13:00','2:00',100,200,'AB-8491'); 
INSERT INTO FlightsInfo VALUES ('AB-8491','UNITED AIRLINES','1','United-States','Qatar','2023/03/20','2023/03/21','2:00','13:00',100,200,'AA-8391'); 

INSERT INTO FlightsInfo VALUES ('AA-8392','UNITED AIRLINES','2','Thailand','United-States','2023/03/11','2023/03/12','14:00','13:00',120,250,'');

INSERT INTO FlightsInfo VALUES ('AA-8393','UNITED AIRLINES','3','United-Kingdom','United-States','2023/03/13','2023/03/13','12:00','17:00',150,300,'AB-8493');
INSERT INTO FlightsInfo VALUES ('AB-8493','UNITED AIRLINES','3','United-States','United-Kingdom','2023/03/20','2023/03/20','15:00','22:00',150,300,'AC-8493');
INSERT INTO FlightsInfo VALUES ('AC-8493','UNITED AIRLINES','3','United-Kingdom','United-States','2023/04/01','2023/04/01','8:00','13:00',150,300,'AB-8493'); 


INSERT INTO FlightsInfo VALUES ('AA-8394','UNITED AIRLINES','4','Jordan','United-States','2023/03/16','2023/03/16','8:00','22:00',200,350,''); 
INSERT INTO FlightsInfo VALUES ('AA-8395','UNITED AIRLINES','5','India','United-States','2023/03/19','2023/03/20','12:00','3:00',250,400,''); 
INSERT INTO FlightsInfo VALUES ('AA-8396','UNITED AIRLINES','6','Hungary','United-States','2023/03/24','2023/03/25','13:00','2:00',280,450,'');

INSERT INTO FlightsInfo VALUES ('AA-8397','UNITED AIRLINES','7','Germany','United-States','2023/03/26','2023/03/26','6:00','16:00',310,500,'AC-8397');
INSERT INTO FlightsInfo VALUES ('AC-8397','UNITED AIRLINES','7','United-States','Germany','2023/04/05','2023/04/05','11:00','16:00',310,500,'AA-8397'); 

INSERT INTO FlightsInfo VALUES ('AA-8398','UNITED AIRLINES','8','Greece','United-States','2023/03/30','2023/03/30','15:00','23:00',315,550,''); 
INSERT INTO FlightsInfo VALUES ('AA-8399','UNITED AIRLINES','9','Ecuador','United-States','2023/04/10','2023/04/10','19:00','23:50',330,600,''); 

INSERT INTO FlightsInfo VALUES ('AA-8400','UNITED AIRLINES','3','Costa-Rica','United-States','2023/03/31','2023/04/01','10:00','14:00',345,650,'AC-8400');
INSERT INTO FlightsInfo VALUES ('AC-8400','UNITED AIRLINES','3','United-States','Costa-Rica','2023/04/10','2023/04/11','22:00','3:00',345,650,'AA-8400');

INSERT INTO FlightsInfo VALUES ('AB-8957','EL-AL','3','Sweden','Israel','2023/05/20','2023/05/21','23:00','3:00',250,300,'AB-8057'); 
INSERT INTO FlightsInfo VALUES ('AB-8057','EL-AL','3','Israel','Sweden','2023/05/26','2023/05/26','10:00','13:00',250,200,'AB-8957');

INSERT INTO FlightsInfo VALUES ('AB-9857','EL-AL','3','Morocco','Israel','2023/02/20','2023/02/20','12:00','15:00',300,350,'AB-5857'); 
INSERT INTO FlightsInfo VALUES ('AB-5857','EL-AL','3','Israel','Morocco','2023/02/27','2023/02/27','16:00','20:00',225,220,'AB-9857'); 

INSERT INTO FlightsInfo VALUES ('AL-8807','EL-AL','3','South-Korea','Israel','2023/02/15','2023/02/16','19:00','3:00',250,450,'AL-8847'); 
INSERT INTO FlightsInfo VALUES ('AL-8847','EL-AL','3','Israel','South-Korea','2023/02/20','2023/02/21','20:00','5:00',250,400,'AL-8807'); 

INSERT INTO FlightsInfo VALUES ('AL-8957','EL-AL','3','Georgia','Israel','2023/01/18','2023/01/18','11:00','16:00',260,325,'AL-9857'); 
INSERT INTO FlightsInfo VALUES ('AL-9857','EL-AL','3','Israel','Georgia','2023/01/27','2023/01/27','15:00','22:00',270,300,'AL-8957'); 



delete from FlightsInfo;