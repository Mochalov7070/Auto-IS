-- phpMyAdmin SQL Dump
-- version 4.7.3
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Май 06 2020 г., 20:21
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
-- Структура таблицы `auditoriya`
--

CREATE TABLE `auditoriya` (
  `id auditoriya` int(200) NOT NULL,
  `number` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `date`
--

CREATE TABLE `date` (
  `id date` int(200) NOT NULL,
  `date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `disciplina`
--

CREATE TABLE `disciplina` (
  `id disciplina` int(200) NOT NULL,
  `id prepod` int(200) NOT NULL,
  `name` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `group`
--

CREATE TABLE `group` (
  `id group` int(200) NOT NULL,
  `id` int(200) NOT NULL,
  `id disciplina` int(200) NOT NULL,
  `kod group` varchar(200) NOT NULL,
  `nomer group` varchar(200) NOT NULL,
  `kolichestvo students` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `kurs`
--

CREATE TABLE `kurs` (
  `id kurs` int(200) NOT NULL,
  `number` int(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `otdelenie`
--

CREATE TABLE `otdelenie` (
  `Id otdel` int(200) NOT NULL,
  `name otdel` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `prepod`
--

CREATE TABLE `prepod` (
  `id prepod` int(200) NOT NULL,
  `fio` varchar(200) NOT NULL,
  `doljnost` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `raspisanie`
--

CREATE TABLE `raspisanie` (
  `rasp` int(11) NOT NULL,
  `id otdel` int(200) NOT NULL,
  `id date` date NOT NULL,
  `id kurs` int(200) NOT NULL,
  `id group` int(200) NOT NULL,
  `id para` int(6) NOT NULL,
  `id disciplina` int(200) NOT NULL,
  `id prepod` int(200) NOT NULL,
  `id auditoriya` int(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Структура таблицы `time`
--

CREATE TABLE `time` (
  `id para` int(200) NOT NULL,
  `begin zan` time(6) NOT NULL,
  `end zan` time(6) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

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
-- Индексы таблицы `auditoriya`
--
ALTER TABLE `auditoriya`
  ADD PRIMARY KEY (`id auditoriya`);

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
  ADD PRIMARY KEY (`id disciplina`),
  ADD KEY `id prepod` (`id prepod`);

--
-- Индексы таблицы `group`
--
ALTER TABLE `group`
  ADD PRIMARY KEY (`id group`),
  ADD KEY `id disciplina` (`id disciplina`);

--
-- Индексы таблицы `kurs`
--
ALTER TABLE `kurs`
  ADD PRIMARY KEY (`id kurs`);

--
-- Индексы таблицы `otdelenie`
--
ALTER TABLE `otdelenie`
  ADD PRIMARY KEY (`Id otdel`) USING BTREE;

--
-- Индексы таблицы `prepod`
--
ALTER TABLE `prepod`
  ADD PRIMARY KEY (`id prepod`);

--
-- Индексы таблицы `raspisanie`
--
ALTER TABLE `raspisanie`
  ADD PRIMARY KEY (`rasp`),
  ADD KEY `id otdel` (`id otdel`) USING BTREE,
  ADD KEY `id date` (`id date`),
  ADD KEY `id kurs` (`id kurs`,`id group`,`id para`,`id disciplina`,`id prepod`,`id auditoriya`),
  ADD KEY `id disciplina` (`id disciplina`),
  ADD KEY `id group` (`id group`),
  ADD KEY `id para` (`id para`),
  ADD KEY `id prepod` (`id prepod`),
  ADD KEY `id auditoriya` (`id auditoriya`);

--
-- Индексы таблицы `time`
--
ALTER TABLE `time`
  ADD PRIMARY KEY (`id para`);

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
-- AUTO_INCREMENT для таблицы `auditoriya`
--
ALTER TABLE `auditoriya`
  MODIFY `id auditoriya` int(200) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT для таблицы `date`
--
ALTER TABLE `date`
  MODIFY `id date` int(200) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
--
-- AUTO_INCREMENT для таблицы `disciplina`
--
ALTER TABLE `disciplina`
  MODIFY `id disciplina` int(200) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT для таблицы `group`
--
ALTER TABLE `group`
  MODIFY `id group` int(200) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT для таблицы `kurs`
--
ALTER TABLE `kurs`
  MODIFY `id kurs` int(200) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT для таблицы `otdelenie`
--
ALTER TABLE `otdelenie`
  MODIFY `Id otdel` int(200) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT для таблицы `prepod`
--
ALTER TABLE `prepod`
  MODIFY `id prepod` int(200) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT для таблицы `raspisanie`
--
ALTER TABLE `raspisanie`
  MODIFY `rasp` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- AUTO_INCREMENT для таблицы `time`
--
ALTER TABLE `time`
  MODIFY `id para` int(200) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
--
-- AUTO_INCREMENT для таблицы `vid zanyatiy`
--
ALTER TABLE `vid zanyatiy`
  MODIFY `Id vida` int(200) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `disciplina`
--
ALTER TABLE `disciplina`
  ADD CONSTRAINT `disciplina_ibfk_1` FOREIGN KEY (`id prepod`) REFERENCES `prepod` (`id prepod`);

--
-- Ограничения внешнего ключа таблицы `group`
--
ALTER TABLE `group`
  ADD CONSTRAINT `group_ibfk_1` FOREIGN KEY (`id disciplina`) REFERENCES `disciplina` (`id disciplina`);

--
-- Ограничения внешнего ключа таблицы `raspisanie`
--
ALTER TABLE `raspisanie`
  ADD CONSTRAINT `raspisanie_ibfk_1` FOREIGN KEY (`id otdel`) REFERENCES `otdelenie` (`Id otdel`),
  ADD CONSTRAINT `raspisanie_ibfk_3` FOREIGN KEY (`id disciplina`) REFERENCES `disciplina` (`id disciplina`),
  ADD CONSTRAINT `raspisanie_ibfk_4` FOREIGN KEY (`id group`) REFERENCES `group` (`id group`),
  ADD CONSTRAINT `raspisanie_ibfk_5` FOREIGN KEY (`id kurs`) REFERENCES `kurs` (`id kurs`),
  ADD CONSTRAINT `raspisanie_ibfk_6` FOREIGN KEY (`id para`) REFERENCES `time` (`id para`),
  ADD CONSTRAINT `raspisanie_ibfk_7` FOREIGN KEY (`id prepod`) REFERENCES `prepod` (`id prepod`),
  ADD CONSTRAINT `raspisanie_ibfk_8` FOREIGN KEY (`id auditoriya`) REFERENCES `auditoriya` (`id auditoriya`),
  ADD CONSTRAINT `raspisanie_ibfk_9` FOREIGN KEY (`id date`) REFERENCES `date` (`date`);

--
-- Ограничения внешнего ключа таблицы `vid zanyatiy`
--
ALTER TABLE `vid zanyatiy`
  ADD CONSTRAINT `vid zanyatiy_ibfk_1` FOREIGN KEY (`id disciplina`) REFERENCES `disciplina` (`id disciplina`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
