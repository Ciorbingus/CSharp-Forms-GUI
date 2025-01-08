
CREATE TABLE users
(
    user_id INT NOT NULL PRIMARY KEY IDENTITY,
    user_name NCHAR(50) NOT NULL,
    user_pass NCHAR(30) NOT NULL,
    user_register_date DATE NOT NULL,
    user_country_code NCHAR(2) NOT NULL
);

CREATE TABLE files 
(
    file_id INT IDENTITY (1, 1) NOT NULL PRIMARY KEY CLUSTERED,
    file_name NCHAR(50) NOT NULL,
    file_size INT NOT NULL,
    file_type NCHAR(50) NOT NULL,
    uploader_id INT NOT NULL,
    CONSTRAINT FK_Files_Users FOREIGN KEY (uploader_id) REFERENCES users(user_id)
);

CREATE TABLE movies
(
    movie_id INT NOT NULL PRIMARY KEY IDENTITY,
    movie_title NCHAR(75) NOT NULL,
    movie_genre NCHAR(50) NOT NULL,
    release_year INT NOT NULL,
    duration INT NOT NULL
);

CREATE TABLE actors
(
    actor_id INT NOT NULL PRIMARY KEY IDENTITY,
    actor_name NCHAR(75) NOT NULL,
    movie_id INT NOT NULL,
    played_role NCHAR(75) NOT NULL,       
    role_type NCHAR(75) NOT NULL,
    CONSTRAINT FK_Actors_Movies FOREIGN KEY (movie_id) REFERENCES movies(movie_id)
);

INSERT INTO Users (user_name, user_pass, user_register_date, user_country_code)
VALUES ('admin', '1234', GETDATE(), 'ro');

INSERT INTO Users (user_name, user_pass, user_register_date, user_country_code)
VALUES ('test1', 'parola', GETDATE(), 'us');

INSERT INTO Users (user_name, user_pass, user_register_date, user_country_code)
VALUES ('test2', 'parola2', GETDATE(), 'fr');


INSERT INTO movies (movie_title, movie_genre, release_year, duration)
VALUES ('Garcea si Oltenii', 'Comedie', 2001, 86);

INSERT INTO movies (movie_title, movie_genre, release_year, duration)
VALUES ('Brigada Diverse intra în actiune', 'Comedie', 1970, 100);

INSERT INTO movies (movie_title, movie_genre, release_year, duration)
VALUES ('Filantropica', 'Comedie, Drama', 2002, 111);

INSERT INTO actors (actor_name, movie_id, played_role, role_type)
VALUES ('Mugur Mihaiescu', 1, 'Garcea', 'principal');

INSERT INTO actors (actor_name, movie_id, played_role, role_type)
VALUES ('Mugur Mihaiescu', 1, 'Leana', 'principal');


INSERT INTO actors (actor_name, movie_id, played_role, role_type)
VALUES ('Gheorghe Dinica', 3, 'Pavel Puiut', 'principal');

INSERT INTO actors (actor_name, movie_id, played_role, role_type)
VALUES ('Mircea Diaconu', 3, 'Ovidiu Gorea', 'principal');

INSERT INTO actors (actor_name, movie_id, played_role, role_type)
VALUES ('Marius Rizea', 3, 'Bucescu', 'secundar');

INSERT INTO actors (actor_name, movie_id, played_role, role_type)
VALUES ('Marius Florea Vizante', 3, 'Simpaticul', 'secundar');



