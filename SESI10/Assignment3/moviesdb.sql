CREATE DATABASE MoviesDb;

use database MoviesDb;

CREATE TABLE Movie(`id` INT NOT NULL AUTO_INCREMENT,
`Name` VARCHAR(50) NOT NULL,
`Genre` VARCHAR(50) NOT NULL,
`Duration`  VARCHAR(50) NOT NULL,
`ReleaseDate` TIMESTAMP NOT NULL DEFAULT CURRENT_TIMESTAMP,
PRIMARY KEY (`id`));

INSERT INTO items(Name, Genre, Duration, ReleaseDate)
VALUES('Bad Boys for Life', 'Action/Comedy', '2h 5mins', '2020-01-23 00:00:00'),
('John Wick', 'Action/Thriller', '1h 41mins', '2014-10-24 00:00:00'),
('The Martian', 'Sci-fi/Drama', '2h 31mins', '2015-10-02 00:00:00'),
('How to Train Your Dragon: The Hidden World', 'Animation/Family', '1h 45mins', '2019-02-22 00:00:00');