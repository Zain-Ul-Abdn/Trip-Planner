use CustomerInfo

create table tripData(
EmailID varchar(30),
City1 varchar(30) Null,
City2 varchar(30) Null,
City3 varchar(30) Null,
City4 varchar(30) Null,
City5 varchar(30) Null
);
select * from customerData
select * from tripData

Insert into tripData(EmailID,City1,City2,City3) values ('zainMeh321@gmail.com','Karachi','Hyderabad City','Lahore');
Insert into tripData(EmailID,City1,City2,City3,City4,City5) values ('zainMeh321@gmail.com','Karachi','Hyderabad City','Lahore','Multan','Peshawar');