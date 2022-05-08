--
-- Файл сгенерирован с помощью SQLiteStudio v3.3.3 в Вс май 8 18:37:06 2022
--
-- Использованная кодировка текста: System
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Таблица: car
DROP TABLE IF EXISTS car;
CREATE TABLE car (id INTEGER PRIMARY KEY, Engine STRING, Driver STRING REFERENCES driver (id), chassis_id REFERENCES chassis (id));
INSERT INTO car (id, Engine, Driver, chassis_id) VALUES (1, 'Chevrolet', 1, 3);
INSERT INTO car (id, Engine, Driver, chassis_id) VALUES (2, 'Ford', 2, 2);
INSERT INTO car (id, Engine, Driver, chassis_id) VALUES (3, 'Toyota', 3, 1);

-- Таблица: chassis
DROP TABLE IF EXISTS chassis;
CREATE TABLE chassis (id PRIMARY KEY, name STRING);
INSERT INTO chassis (id, name) VALUES (1, 'Toyota Camry');
INSERT INTO chassis (id, name) VALUES (2, 'Ford Mustang');
INSERT INTO chassis (id, name) VALUES (3, 'Chevrolet Comaro');

-- Таблица: country
DROP TABLE IF EXISTS country;
CREATE TABLE country (id PRIMARY KEY, name STRING);
INSERT INTO country (id, name) VALUES (1, 'Russia');
INSERT INTO country (id, name) VALUES (2, 'USA');
INSERT INTO country (id, name) VALUES (3, 'Italy');
INSERT INTO country (id, name) VALUES (4, 'Germany');
INSERT INTO country (id, name) VALUES (5, 'Spane');
INSERT INTO country (id, name) VALUES (6, 'Algeria');
INSERT INTO country (id, name) VALUES (7, 'Bulgaria');
INSERT INTO country (id, name) VALUES (8, 'Canada');
INSERT INTO country (id, name) VALUES (9, 'Comoros');
INSERT INTO country (id, name) VALUES (10, 'Croatia');
INSERT INTO country (id, name) VALUES (11, 'Djibouti');
INSERT INTO country (id, name) VALUES (12, 'Egypt');
INSERT INTO country (id, name) VALUES (13, 'Estonia');
INSERT INTO country (id, name) VALUES (14, 'Finland');
INSERT INTO country (id, name) VALUES (15, 'Haiti');
INSERT INTO country (id, name) VALUES (16, 'Hungary');
INSERT INTO country (id, name) VALUES (17, 'Iceland');
INSERT INTO country (id, name) VALUES (18, 'Iran');
INSERT INTO country (id, name) VALUES (19, 'Kazakhstan');
INSERT INTO country (id, name) VALUES (20, 'Kyrgyzstan');
INSERT INTO country (id, name) VALUES (21, 'Lithuania');
INSERT INTO country (id, name) VALUES (22, 'Mali');
INSERT INTO country (id, name) VALUES (23, 'Monaco');
INSERT INTO country (id, name) VALUES (24, 'Nauru');
INSERT INTO country (id, name) VALUES (25, 'Netherlands');

-- Таблица: driver
DROP TABLE IF EXISTS driver;
CREATE TABLE driver (id PRIMARY KEY, name STRING, gender_id REFERENCES gender (id), age INTEGER, country_id REFERENCES country (id));
INSERT INTO driver (id, name, gender_id, age, country_id) VALUES (1, 'DARRELL BUBBA WALLACE', 1, 28, 2);
INSERT INTO driver (id, name, gender_id, age, country_id) VALUES (2, 'KURT BUSCH', 1, 43, 2);
INSERT INTO driver (id, name, gender_id, age, country_id) VALUES (3, 'CHASE ELLIOTT', 1, 26, 2);

-- Таблица: gender
DROP TABLE IF EXISTS gender;
CREATE TABLE gender (id PRIMARY KEY, name STRING);
INSERT INTO gender (id, name) VALUES (1, 'male');
INSERT INTO gender (id, name) VALUES (2, 'famale');

-- Таблица: team
DROP TABLE IF EXISTS team;
CREATE TABLE team (id PRIMARY KEY, car REFERENCES car (id), name STRING, tournament REFERENCES tournament (id), place INTEGER);
INSERT INTO team (id, car, name, tournament, place) VALUES (1, 1, '23XI RACING', 1, 12);
INSERT INTO team (id, car, name, tournament, place) VALUES (2, 3, 'BEARD MOTORSPORTS', 1, 4);

-- Таблица: tournament
DROP TABLE IF EXISTS tournament;
CREATE TABLE tournament (id PRIMARY KEY, event_name STRING, date DATE);
INSERT INTO tournament (id, event_name, date) VALUES (1, 'DAYTONA 500', '15.02.2022');
INSERT INTO tournament (id, event_name, date) VALUES (2, 'WISE POWER 400', '27.02.2022');

COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
