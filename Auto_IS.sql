-- phpMyAdmin SQL Dump
-- version 4.7.3
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Май 14 2020 г., 01:40
-- Версия сервера: 5.6.37
-- Версия PHP: 5.5.38

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `Auto IS`
--

-- --------------------------------------------------------

--
-- Структура таблицы `audit`
--

CREATE TABLE `audit` (
  `idaudit` int(200) NOT NULL,
  `num` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `audit`
--

INSERT INTO `audit` (`idaudit`, `num`) VALUES
(1, '123'),
(2, '124');

-- --------------------------------------------------------

--
-- Структура таблицы `date`
--

CREATE TABLE `date` (
  `id date` int(200) NOT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `date`
--

INSERT INTO `date` (`id date`, `date`) VALUES
(1, '2020-05-07'),
(2, '2020-05-08');

-- --------------------------------------------------------

--
-- Структура таблицы `disciplina`
--

CREATE TABLE `disciplina` (
  `iddisc` int(200) NOT NULL,
  `idprepod` int(200) DEFAULT NULL,
  `name` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `disciplina`
--

INSERT INTO `disciplina` (`iddisc`, `idprepod`, `name`) VALUES
(1, 1, 'Английский'),
(2, 1, 'МДК');

-- --------------------------------------------------------

--
-- Структура таблицы `grup`
--

CREATE TABLE `grup` (
  `idgrup` int(200) NOT NULL,
  `id` int(200) DEFAULT NULL,
  `iddisc` int(200) DEFAULT NULL,
  `kod` varchar(200) NOT NULL,
  `num` varchar(200) NOT NULL,
  `kolvo` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `grup`
--

INSERT INTO `grup` (`idgrup`, `id`, `iddisc`, `kod`, `num`, `kolvo`) VALUES
(1, NULL, 2, '231', '3241', '26'),
(4, NULL, NULL, '13', '421', '4321');

-- --------------------------------------------------------

--
-- Структура таблицы `kurs`
--

CREATE TABLE `kurs` (
  `id kurs` int(200) NOT NULL,
  `number` int(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `kurs`
--

INSERT INTO `kurs` (`id kurs`, `number`) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4);

-- --------------------------------------------------------

--
-- Структура таблицы `otdelenie`
--

CREATE TABLE `otdelenie` (
  `Idotdel` int(200) NOT NULL,
  `nameotdel` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `otdelenie`
--

INSERT INTO `otdelenie` (`Idotdel`, `nameotdel`) VALUES
(1, 'ОСП 1'),
(2, 'ОСП 2'),
(3, 'ОСП 3');

-- --------------------------------------------------------

--
-- Структура таблицы `prepod`
--

CREATE TABLE `prepod` (
  `idprepod` int(200) NOT NULL,
  `fio` varchar(200) NOT NULL,
  `doljnost` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `prepod`
--

INSERT INTO `prepod` (`idprepod`, `fio`, `doljnost`) VALUES
(1, 'Кафка Алексей Андреевич ', 'Астрономия'),
(11, 'Лютиков Владимир Сергеевич', 'Информатика');

-- --------------------------------------------------------

--
-- Структура таблицы `raspisanie`
--

CREATE TABLE `raspisanie` (
  `rasp` int(11) NOT NULL,
  `idotdel` int(200) NOT NULL,
  `iddate` date NOT NULL,
  `idkurs` int(200) NOT NULL,
  `idgrup` int(200) NOT NULL,
  `idpara` int(6) NOT NULL,
  `iddisc` int(200) NOT NULL,
  `idprepod` int(200) NOT NULL,
  `idaudit` int(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `tablica`
--

CREATE TABLE `tablica` (
  `id` int(200) NOT NULL,
  `otdel` varchar(200) NOT NULL,
  `begin` varchar(200) NOT NULL,
  `end` varchar(200) NOT NULL,
  `kurs` varchar(200) NOT NULL,
  `grup` varchar(200) NOT NULL,
  `discip` varchar(200) NOT NULL,
  `prepod` varchar(200) NOT NULL,
  `audit` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `tablica`
--

INSERT INTO `tablica` (`id`, `otdel`, `begin`, `end`, `kurs`, `grup`, `discip`, `prepod`, `audit`) VALUES
(1, 'ОСП 3', '13 мая 2020 11:37', '13 мая 2020 11:39', '4', '3241', 'Английский', 'Кафка Алексей Андреевич ', '124');

-- --------------------------------------------------------

--
-- Структура таблицы `time`
--

CREATE TABLE `time` (
  `idtime` int(200) NOT NULL,
  `begin` varchar(200) NOT NULL,
  `end` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `time`
--

INSERT INTO `time` (`idtime`, `begin`, `end`) VALUES
(10, '13 мая 2020 11:37', '13 мая 2020 11:37'),
(11, '13 мая 2020 11:39', '13 мая 2020 11:39');

-- --------------------------------------------------------

--
-- Структура таблицы `vid zanyatiy`
--

CREATE TABLE `vid zanyatiy` (
  `Id vida` int(200) NOT NULL,
  `id disciplina` int(200) NOT NULL,
  `vid zanyatiy` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `audit`
--
ALTER TABLE `audit`
  ADD PRIMARY KEY (`idaudit`);

--
-- Индексы таблицы `date`
--
ALTER TABLE `date`
  ADD PRIMARY KEY (`id date`) USING BTREE,
  ADD KEY `date` (`date`);

--
-- Индексы таблицы `disciplina`
--
ALTER TABLE `disciplina`
  ADD PRIMARY KEY (`iddisc`),
  ADD KEY `id prepod` (`idprepod`);

--
-- Индексы таблицы `grup`
--
ALTER TABLE `grup`
  ADD PRIMARY KEY (`idgrup`),
  ADD KEY `id disciplina` (`iddisc`);

--
-- Индексы таблицы `kurs`
--
ALTER TABLE `kurs`
  ADD PRIMARY KEY (`id kurs`);

--
-- Индексы таблицы `otdelenie`
--
ALTER TABLE `otdelenie`
  ADD PRIMARY KEY (`Idotdel`) USING BTREE;

--
-- Индексы таблицы `prepod`
--
ALTER TABLE `prepod`
  ADD PRIMARY KEY (`idprepod`);

--
-- Индексы таблицы `raspisanie`
--
ALTER TABLE `raspisanie`
  ADD PRIMARY KEY (`rasp`),
  ADD KEY `id otdel` (`idotdel`) USING BTREE,
  ADD KEY `id date` (`iddate`),
  ADD KEY `id kurs` (`idkurs`,`idgrup`,`idpara`,`iddisc`,`idprepod`,`idaudit`),
  ADD KEY `id disciplina` (`iddisc`),
  ADD KEY `id group` (`idgrup`),
  ADD KEY `id para` (`idpara`),
  ADD KEY `id prepod` (`idprepod`),
  ADD KEY `id auditoriya` (`idaudit`);

--
-- Индексы таблицы `tablica`
--
ALTER TABLE `tablica`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `time`
--
ALTER TABLE `time`
  ADD PRIMARY KEY (`idtime`);

--
-- Индексы таблицы `vid zanyatiy`
--
ALTER TABLE `vid zanyatiy`
  ADD PRIMARY KEY (`Id vida`),
  ADD KEY `id disciplina` (`id disciplina`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `audit`
--
ALTER TABLE `audit`
  MODIFY `idaudit` int(200) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT для таблицы `date`
--
ALTER TABLE `date`
  MODIFY `id date` int(200) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT для таблицы `disciplina`
--
ALTER TABLE `disciplina`
  MODIFY `iddisc` int(200) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;
--
-- AUTO_INCREMENT для таблицы `grup`
--
ALTER TABLE `grup`
  MODIFY `idgrup` int(200) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
--
-- AUTO_INCREMENT для таблицы `kurs`
--
ALTER TABLE `kurs`
  MODIFY `id kurs` int(200) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT для таблицы `otdelenie`
--
ALTER TABLE `otdelenie`
  MODIFY `Idotdel` int(200) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT для таблицы `prepod`
--
ALTER TABLE `prepod`
  MODIFY `idprepod` int(200) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=15;
--
-- AUTO_INCREMENT для таблицы `raspisanie`
--
ALTER TABLE `raspisanie`
  MODIFY `rasp` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT для таблицы `tablica`
--
ALTER TABLE `tablica`
  MODIFY `id` int(200) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT для таблицы `time`
--
ALTER TABLE `time`
  MODIFY `idtime` int(200) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT для таблицы `vid zanyatiy`
--
ALTER TABLE `vid zanyatiy`
  MODIFY `Id vida` int(200) NOT NULL AUTO_INCREMENT;
--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `disciplina`
--
ALTER TABLE `disciplina`
  ADD CONSTRAINT `disciplina_ibfk_1` FOREIGN KEY (`idprepod`) REFERENCES `prepod` (`idprepod`);

--
-- Ограничения внешнего ключа таблицы `grup`
--
ALTER TABLE `grup`
  ADD CONSTRAINT `grup_ibfk_1` FOREIGN KEY (`iddisc`) REFERENCES `disciplina` (`iddisc`);

--
-- Ограничения внешнего ключа таблицы `raspisanie`
--
ALTER TABLE `raspisanie`
  ADD CONSTRAINT `raspisanie_ibfk_1` FOREIGN KEY (`idotdel`) REFERENCES `otdelenie` (`Idotdel`),
  ADD CONSTRAINT `raspisanie_ibfk_3` FOREIGN KEY (`iddisc`) REFERENCES `disciplina` (`iddisc`),
  ADD CONSTRAINT `raspisanie_ibfk_4` FOREIGN KEY (`idgrup`) REFERENCES `grup` (`idgrup`),
  ADD CONSTRAINT `raspisanie_ibfk_5` FOREIGN KEY (`idkurs`) REFERENCES `kurs` (`id kurs`),
  ADD CONSTRAINT `raspisanie_ibfk_6` FOREIGN KEY (`idpara`) REFERENCES `time` (`idtime`),
  ADD CONSTRAINT `raspisanie_ibfk_7` FOREIGN KEY (`idprepod`) REFERENCES `prepod` (`idprepod`),
  ADD CONSTRAINT `raspisanie_ibfk_8` FOREIGN KEY (`idaudit`) REFERENCES `audit` (`idaudit`),
  ADD CONSTRAINT `raspisanie_ibfk_9` FOREIGN KEY (`iddate`) REFERENCES `date` (`date`);

--
-- Ограничения внешнего ключа таблицы `vid zanyatiy`
--
ALTER TABLE `vid zanyatiy`
  ADD CONSTRAINT `vid zanyatiy_ibfk_1` FOREIGN KEY (`id disciplina`) REFERENCES `disciplina` (`iddisc`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
