CREATE TABLE Street (
    ID int IDENTITY(1,1) PRIMARY KEY,
    NameStreet nvarchar(50) NOT NULL,
    CityID int FOREIGN KEY REFERENCES City(ID)
);


