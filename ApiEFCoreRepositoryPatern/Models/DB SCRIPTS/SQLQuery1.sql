use DBLibrary
CREATE TABLE Category(
CategoryId int identity primary key,
Description varchar(50),
)

CREATE TABLE Authors(
AuthorId int identity primary key,
AuthorName varchar(50),
)

CREATE TABLE Books(
BookId int identity primary key,
Description varchar(50),
CategoryId int references Category(CategoryId),
AuthorId int references Authors(AuthorId)
)

ALTER TABLE Books ADD BookName varchar(50)

ALTER TABLE Books ALTER Column Description varchar(200)

INSERT INTO Category (Description) VALUES ('Terror'), ('Romance'), ('Comedia'),('Drama')

INSERT INTO Authors (AuthorName) VALUES ('Gabriel Garcia Marquez'),('Juan Bosch'),('Stephen King')

INSERT INTO Books (BookName,Description,CategoryId,AuthorId) VALUES
('Love in the times of Cholera', 'historia sentimental sobre el poder perdurable del amor verdadero', 2,1),
('La Mujer','es una tragedia rural dominicana y muestra claramente el abuso de Chepe hacia su mujer',4,3),
('The Stand','La mortal súper gripe Captain Trips ha devastado el país y ahora los pocos sobrevivientes deben recoger los pedazos y continuar.',3,3)


SELECT * FROM Books

SELECT * FROM Authors

SELECT * FROM Category