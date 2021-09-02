create table Medicine(Medicine_Code numeric(10,0) primary key, Available_Medicine varchar(30) not null,
Quantity int, Expire_Date date not null)


create table Donator(Donator_Id int primary key,
Name_of_Donator varchar(30),Contact_number numeric(10,0) not null )


create table NGO( NGO_Id int primary key, Medicine_Code numeric(10,0) foreign key references Medicine(Medicine_Code),
Organization_Name varchar(30) not null, Mail_Id varchar(30) not null, Location varchar(20), 
Contact_Number numeric(10,0) not null,Feedback varchar(50))

create table Ship_Details(Ship_Id int primary key, NGO_Id int foreign key references NGO(NGO_Id),
Medicine_Code numeric(10,0) foreign key references Medicine(Medicine_Code), Date_of_Arrival date not null)