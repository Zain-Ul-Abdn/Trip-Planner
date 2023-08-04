create database CustomerInfo

use CustomerInfo

create table customerData(
stID int Not null  identity(1,1),
First_Name varchar(50),
Last_Name varchar(50),
Email varchar(50),
Password_ varchar(50)
);

select * from customerData

insert  into customerData(First_Name,Last_Name,Email,Password_) 
values ('Zain','Khan','zainMeh321@gmail.com','ZainK321,');

Delete from customerData
where stID = 4