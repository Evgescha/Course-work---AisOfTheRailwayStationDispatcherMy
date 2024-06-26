DROP DATABASE IF EXISTS `AisOfTheRailwayStationDispatcher`;
CREATE DATABASE IF NOT EXISTS `AisOfTheRailwayStationDispatcher`;
USE `AisOfTheRailwayStationDispatcher`;

#
# Table structure for table 'Должности'
#

DROP TABLE IF EXISTS `Должности`;

CREATE TABLE `Должности` (
  `Код` INTEGER NOT NULL AUTO_INCREMENT, 
  `Название` VARCHAR(30), 
  `Описание` VARCHAR(255), 
  PRIMARY KEY (`Код`)
) ENGINE=innodb DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Должности'
#
INSERT INTO `Должности` (`Код`, `Название`, `Описание`) VALUES (1, 'Диспетчер', 'В основном назначет билеты');
INSERT INTO `Должности` (`Код`, `Название`, `Описание`) VALUES (2, 'Проводник', 'Иногда назначает билеты, а так разносит напитки');
INSERT INTO `Должности` (`Код`, `Название`, `Описание`) VALUES (3, 'Работник', NULL);
# 3 records
#
# Table structure for table 'Сотрудник'
#

DROP TABLE IF EXISTS `Сотрудник`;

CREATE TABLE `Сотрудник` (
  `Код` INTEGER NOT NULL AUTO_INCREMENT, 
  `Фамилия` VARCHAR(30), 
  `Имя` VARCHAR(30), 
  `Отчество` VARCHAR(30), 
  `Телефон` VARCHAR(20), 
  `Адрес` VARCHAR(255), 
  `Должность` INTEGER, 
  PRIMARY KEY (`Код`),
  FOREIGN KEY(`Должность`) REFERENCES `Должности`(`Код`)
) ENGINE=innodb DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Сотрудник'
#

INSERT INTO `Сотрудник` (`Код`, `Фамилия`, `Имя`, `Отчество`, `Телефон`, `Адрес`, `Должность`) VALUES (1, 'Круглова', 'Екатерина', 'Юрьевна', '093-22-69', '123458, Москва, ул.3-я Лыковская, 62, кв.52', 1);
INSERT INTO `Сотрудник` (`Код`, `Фамилия`, `Имя`, `Отчество`, `Телефон`, `Адрес`, `Должность`) VALUES (2, 'Гордеева', 'Арина', 'Егоровна', '759-96-55', '111625, Москва, ул.Розы Люксембург, 58, кв.72', 2);
INSERT INTO `Сотрудник` (`Код`, `Фамилия`, `Имя`, `Отчество`, `Телефон`, `Адрес`, `Должность`) VALUES (3, 'Гончаров', 'Роман', 'Тимофеевич', '983-82-91', '117292, Москва, ул.Львова, 56, кв.63', 3);
INSERT INTO `Сотрудник` (`Код`, `Фамилия`, `Имя`, `Отчество`, `Телефон`, `Адрес`, `Должность`) VALUES (4, 'Журавлева', 'Сафия', 'Александровна', '601-68-19', '105118, Москва, ул.10-я Соколиной Горы, 81, кв.87', 2);
INSERT INTO `Сотрудник` (`Код`, `Фамилия`, `Имя`, `Отчество`, `Телефон`, `Адрес`, `Должность`) VALUES (5, 'Плотников', 'Лука', 'Даниилович', '021-29-16', '125080, Москва, ул.Дубосековская, 96, кв.89', 1);
INSERT INTO `Сотрудник` (`Код`, `Фамилия`, `Имя`, `Отчество`, `Телефон`, `Адрес`, `Должность`) VALUES (6, 'Тарасов', 'Арсений', 'Максимович', '756-41-11', '119332, Москва, ул.Московская, 57, кв.73', 3);
INSERT INTO `Сотрудник` (`Код`, `Фамилия`, `Имя`, `Отчество`, `Телефон`, `Адрес`, `Должность`) VALUES (7, 'Макарова', 'Полина', 'Савельевна', '049-24-06', '119620, Москва, ул.6-я Прудная, 92, кв.68', 1);
INSERT INTO `Сотрудник` (`Код`, `Фамилия`, `Имя`, `Отчество`, `Телефон`, `Адрес`, `Должность`) VALUES (8, 'Безруков', 'Артём', 'Всеволодович', '076-88-57', '111621, Москва, ул.Оренбургская, 64, кв.31', 1);
INSERT INTO `Сотрудник` (`Код`, `Фамилия`, `Имя`, `Отчество`, `Телефон`, `Адрес`, `Должность`) VALUES (9, 'Фролова', 'Мелания', 'Алексеевна', '891-70-74', '123060, Москва, ул.Маршала Конева, 63, кв.36', 3);
INSERT INTO `Сотрудник` (`Код`, `Фамилия`, `Имя`, `Отчество`, `Телефон`, `Адрес`, `Должность`) VALUES (10, 'Лукьянова', 'Мария', 'Елисеевна', '311-42-35', '127411, Москва, ул.Яхромская, 21, кв.25', 2);
# 10 records



#
# Table structure for table 'Области'
#

DROP TABLE IF EXISTS `Области`;

CREATE TABLE `Области` (
  `Название области` VARCHAR(255) NOT NULL, 
  PRIMARY KEY (`Название области`)
) ENGINE=innodb DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Области'
#

INSERT INTO `Области` (`Название области`) VALUES ('Минская');
INSERT INTO `Области` (`Название области`) VALUES ('Могилевкая');
INSERT INTO `Области` (`Название области`) VALUES ('Гродненская');
INSERT INTO `Области` (`Название области`) VALUES ('Гомельская');
INSERT INTO `Области` (`Название области`) VALUES ('Брестская');
INSERT INTO `Области` (`Название области`) VALUES ('Витебская');
# 6 records


#
# Table structure for table 'Районы'
#

DROP TABLE IF EXISTS `Районы`;

CREATE TABLE `Районы` (
  `Название района` VARCHAR(255) NOT NULL, 
  `Область` VARCHAR(255), 
  PRIMARY KEY (`Название района`),
  FOREIGN KEY(`Область`) REFERENCES `Области`(`Название области`)
) ENGINE=innodb DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Районы'
#

INSERT INTO `Районы` (`Название района`, `Область`) VALUES ('Минский', 'Минская');
INSERT INTO `Районы` (`Название района`, `Область`) VALUES ('Молодечно', 'Витебская');
INSERT INTO `Районы` (`Название района`, `Область`) VALUES ('Столбческий', 'Минская');
INSERT INTO `Районы` (`Название района`, `Область`) VALUES ('Тракторский', 'Могилевкая');
# 4 records


#
# Table structure for table 'Пункт назначения'
#

DROP TABLE IF EXISTS `Пункт назначения`;

CREATE TABLE `Пункт назначения` (
  `Код` INTEGER NOT NULL AUTO_INCREMENT, 
  `Название` VARCHAR(30), 
  `Адрес` VARCHAR(255), 
  `Район` VARCHAR(255), 
  PRIMARY KEY (`Код`),
  FOREIGN KEY(`Район`) REFERENCES `Районы`(`Название района`)
) ENGINE=innodb DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Пункт назначения'
#

INSERT INTO `Пункт назначения` (`Код`, `Название`, `Адрес`, `Район`) VALUES (1, 'Азино', NULL, 'Минский');
INSERT INTO `Пункт назначения` (`Код`, `Название`, `Адрес`, `Район`) VALUES (2, 'Молодечно', NULL, 'Молодечно');
INSERT INTO `Пункт назначения` (`Код`, `Название`, `Адрес`, `Район`) VALUES (3, 'Вототище', NULL, 'Минский');
INSERT INTO `Пункт назначения` (`Код`, `Название`, `Адрес`, `Район`) VALUES (4, 'Столбцы', NULL, 'Столбческий');
INSERT INTO `Пункт назначения` (`Код`, `Название`, `Адрес`, `Район`) VALUES (5, 'Хвоево', NULL, 'Столбческий');
INSERT INTO `Пункт назначения` (`Код`, `Название`, `Адрес`, `Район`) VALUES (6, 'Турбен', NULL, 'Тракторский');
# 6 records

#
# Table structure for table 'Поезд'
#

DROP TABLE IF EXISTS `Поезд`;

CREATE TABLE `Поезд` (
  `Код` INTEGER NOT NULL AUTO_INCREMENT, 
  `Модель` VARCHAR(20), 
  `Вместимость` INTEGER, 
  `Дата ввода` DATETIME, 
  PRIMARY KEY (`Код`)
) ENGINE=innodb DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Поезд'
#

INSERT INTO `Поезд` (`Код`, `Модель`, `Вместимость`, `Дата ввода`) VALUES (1, '84', 720, '2000-02-05 00:00:00');
INSERT INTO `Поезд` (`Код`, `Модель`, `Вместимость`, `Дата ввода`) VALUES (2, '984', 800, '2000-02-05 00:00:00');
INSERT INTO `Поезд` (`Код`, `Модель`, `Вместимость`, `Дата ввода`) VALUES (3, '648', 720, '2000-02-05 00:00:00');
# 3 records



#
# Table structure for table 'Пассажир'
#

DROP TABLE IF EXISTS `Пассажир`;

CREATE TABLE `Пассажир` (
  `Код` INTEGER NOT NULL AUTO_INCREMENT, 
  `Фамилия` VARCHAR(30), 
  `Имя` VARCHAR(30), 
  `Отчество` VARCHAR(30), 
  `Телефон` VARCHAR(20), 
  `Адрес` VARCHAR(255), 
  `Паспорт` VARCHAR(20), 
  PRIMARY KEY (`Код`)
) ENGINE=innodb DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Пассажир'
#

INSERT INTO `Пассажир` (`Код`, `Фамилия`, `Имя`, `Отчество`, `Телефон`, `Адрес`, `Паспорт`) VALUES (1, 'Кондрашова', 'София', 'Владиславовна', '800-85-23', '107014, г.Москва, ул.Б.Тихоновская, д.33, кв.58', '4025 177240');
INSERT INTO `Пассажир` (`Код`, `Фамилия`, `Имя`, `Отчество`, `Телефон`, `Адрес`, `Паспорт`) VALUES (2, 'Голубев', 'Артём', 'Макарович', '521-37-33', '107014, г.Москва, ул.5-я Сокольническая, д.32, кв.88', '4831 276205');
INSERT INTO `Пассажир` (`Код`, `Фамилия`, `Имя`, `Отчество`, `Телефон`, `Адрес`, `Паспорт`) VALUES (3, 'Киселева', 'Елизавета', 'Марковна', '168-73-55', '119332, г.Москва, ул.Матросова, д.2, кв.98', '4832 261927');
INSERT INTO `Пассажир` (`Код`, `Фамилия`, `Имя`, `Отчество`, `Телефон`, `Адрес`, `Паспорт`) VALUES (4, 'Смирнова', 'Валерия', 'Константиновна', '950-75-43', '121293, г.Москва, ул.Дениса Давыдова, д.87, кв.25', '4959 566217');
INSERT INTO `Пассажир` (`Код`, `Фамилия`, `Имя`, `Отчество`, `Телефон`, `Адрес`, `Паспорт`) VALUES (5, 'Кравцова', 'Екатерина', 'Александровна', '442-06-55', '119634, г.Москва, ул.Приречная, д.88, кв.40', '4198 725508');
INSERT INTO `Пассажир` (`Код`, `Фамилия`, `Имя`, `Отчество`, `Телефон`, `Адрес`, `Паспорт`) VALUES (6, 'Никитина', 'Лейла', 'Сергеевна', '875-50-92', '123060, г.Москва, ул.Маршала Соколовского, д.65, кв.60', '4748 392631');
INSERT INTO `Пассажир` (`Код`, `Фамилия`, `Имя`, `Отчество`, `Телефон`, `Адрес`, `Паспорт`) VALUES (7, 'Сизов', 'Владимир', 'Сергеевич', '619-07-47', '143350, г.Москва, ул.Майская, д.69, кв.14', '4229 159229');
INSERT INTO `Пассажир` (`Код`, `Фамилия`, `Имя`, `Отчество`, `Телефон`, `Адрес`, `Паспорт`) VALUES (8, 'Белова', 'Анна', 'Борисовна', '083-52-79', '119361, г.Москва, ул.Наташи Ковшовой, д.98, кв.42', '4650 768608');
INSERT INTO `Пассажир` (`Код`, `Фамилия`, `Имя`, `Отчество`, `Телефон`, `Адрес`, `Паспорт`) VALUES (9, 'Макаров', 'Николай', 'Мирославович', '217-97-31', '109235, г.Москва, ул.Батюнинская, д.68, кв.18', '4791 800548');
INSERT INTO `Пассажир` (`Код`, `Фамилия`, `Имя`, `Отчество`, `Телефон`, `Адрес`, `Паспорт`) VALUES (10, 'Баранов', 'Артемий', 'Матвеевич', '654-15-18', '113054, г.Москва, ул.Зацепский Вал, д.29, кв.70', '4467 670030');
# 10 records


#
# Table structure for table 'Маршрут'
#

DROP TABLE IF EXISTS `Маршрут`;

CREATE TABLE `Маршрут` (
  `Код` INTEGER NOT NULL AUTO_INCREMENT, 
  `Название рейса` VARCHAR(60), 
  `Дата начала` DATETIME, 
  `Дата конца` DATETIME, 
  `Поезд` INTEGER, 
  PRIMARY KEY (`Код`),
  FOREIGN KEY(`Поезд`) REFERENCES `Поезд`(`Код`)
) ENGINE=innodb DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Маршрут'
#

INSERT INTO `Маршрут` (`Код`, `Название рейса`, `Дата начала`, `Дата конца`, `Поезд`) VALUES (1, 'Минск-Могилев', '2021-02-26 00:00:00', '2021-02-27 00:00:00', 1);
INSERT INTO `Маршрут` (`Код`, `Название рейса`, `Дата начала`, `Дата конца`, `Поезд`) VALUES (2, 'Могилев-Минск', '2021-02-27 00:00:00', '2021-02-27 00:00:00', 2);
# 2 records


#
# Table structure for table 'Пункты маршрута'
#

DROP TABLE IF EXISTS `Пункты маршрута`;

CREATE TABLE `Пункты маршрута` (
  `Код` INTEGER NOT NULL AUTO_INCREMENT, 
  `Маршрут` INTEGER, 
  `Пункт` INTEGER, 
  `Цена билета` FLOAT NULL, 
  PRIMARY KEY (`Код`),
  FOREIGN KEY(`Маршрут`) REFERENCES `Маршрут`(`Код`),
  FOREIGN KEY(`Пункт`) REFERENCES `Пункт назначения`(`Код`)
) ENGINE=innodb DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Пункты маршрута'
#

INSERT INTO `Пункты маршрута` (`Код`, `Маршрут`, `Пункт`, `Цена билета`) VALUES (1, 1, 2, 10);
INSERT INTO `Пункты маршрута` (`Код`, `Маршрут`, `Пункт`, `Цена билета`) VALUES (2, 1, 4, 20);
INSERT INTO `Пункты маршрута` (`Код`, `Маршрут`, `Пункт`, `Цена билета`) VALUES (3, 1, 5, 30);
INSERT INTO `Пункты маршрута` (`Код`, `Маршрут`, `Пункт`, `Цена билета`) VALUES (4, 2, 5, 10);
INSERT INTO `Пункты маршрута` (`Код`, `Маршрут`, `Пункт`, `Цена билета`) VALUES (5, 2, 4, 20);
INSERT INTO `Пункты маршрута` (`Код`, `Маршрут`, `Пункт`, `Цена билета`) VALUES (6, 2, 2, 30);
# 6 records



#
# Table structure for table 'Билет'
#

DROP TABLE IF EXISTS `Билет`;

CREATE TABLE `Билет` (
  `Код` INTEGER NOT NULL AUTO_INCREMENT, 
  `Маршрут` INTEGER, 
  `Пассажир` INTEGER, 
  `Сотрудник` INTEGER, 
  `Номер` VARCHAR(10), 
  PRIMARY KEY (`Код`),
  FOREIGN KEY(`Маршрут`) REFERENCES `Маршрут`(`Код`),
  FOREIGN KEY(`Пассажир`) REFERENCES `Пассажир`(`Код`),
  FOREIGN KEY(`Сотрудник`) REFERENCES `Сотрудник`(`Код`)
) ENGINE=innodb DEFAULT CHARSET=utf8;

SET autocommit=1;

#
# Dumping data for table 'Билет'
#

INSERT INTO `Билет` (`Код`, `Маршрут`, `Пассажир`, `Сотрудник`, `Номер`) VALUES (1, 1, 1, 1, '1а12');
INSERT INTO `Билет` (`Код`, `Маршрут`, `Пассажир`, `Сотрудник`, `Номер`) VALUES (2, 1, 2, 4, '1а13');
INSERT INTO `Билет` (`Код`, `Маршрут`, `Пассажир`, `Сотрудник`, `Номер`) VALUES (3, 1, 4, 5, '1а43');
INSERT INTO `Билет` (`Код`, `Маршрут`, `Пассажир`, `Сотрудник`, `Номер`) VALUES (4, 1, 8, 7, 'и22');
INSERT INTO `Билет` (`Код`, `Маршрут`, `Пассажир`, `Сотрудник`, `Номер`) VALUES (5, 2, 2, 2, 'и24');
INSERT INTO `Билет` (`Код`, `Маршрут`, `Пассажир`, `Сотрудник`, `Номер`) VALUES (6, 2, 3, 6, 'и206');
INSERT INTO `Билет` (`Код`, `Маршрут`, `Пассажир`, `Сотрудник`, `Номер`) VALUES (7, 2, 10, 6, 'и800');
# 7 records



