CREATE DATABASE  IF NOT EXISTS `aquiver` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `aquiver`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: aquiver
-- ------------------------------------------------------
-- Server version	5.7.17-log

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `days`
--

DROP TABLE IF EXISTS `days`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `days` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `full_date` date DEFAULT NULL,
  `worker_id` int(11) DEFAULT NULL,
  `arrival_time` time DEFAULT NULL,
  `departure_time` time DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_days-workers_idx` (`worker_id`),
  CONSTRAINT `fk_days-workers` FOREIGN KEY (`worker_id`) REFERENCES `workers` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `days`
--

LOCK TABLES `days` WRITE;
/*!40000 ALTER TABLE `days` DISABLE KEYS */;
INSERT INTO `days` VALUES (8,'2017-04-19',30,'14:27:40','15:18:10'),(9,'2017-04-19',32,'15:18:37','15:27:07'),(10,'2017-04-20',30,'20:48:38','20:48:46'),(11,'2017-05-01',32,'12:32:11','12:33:18'),(12,'2017-05-03',32,'07:32:49','07:46:14'),(13,'2017-05-04',32,'12:05:07','15:32:11'),(14,'2017-05-04',30,'12:05:32','12:05:39'),(15,'2017-05-05',32,'12:08:46','14:46:22'),(16,'2017-05-06',32,'12:30:33','21:04:35'),(17,'2017-05-06',43,'16:47:15','16:47:20'),(18,'2017-05-06',42,'16:50:10','16:50:14'),(20,'2017-05-07',42,'09:32:14','19:13:21'),(21,'2017-05-08',32,'10:08:30','10:10:22'),(22,'2017-05-08',42,'10:51:31','10:51:39'),(23,'2017-05-10',30,'17:11:52','17:12:01'),(24,'2017-05-13',32,'19:10:51','21:13:13'),(25,'2017-05-15',46,'13:29:12','19:29:12'),(26,'2017-05-16',42,'07:00:00','14:43:45'),(27,'2017-05-16',46,'09:20:00','22:20:58'),(28,'2017-05-16',45,'08:15:01','16:00:51'),(29,'2017-05-18',45,'08:00:00','15:22:25'),(30,'2017-05-19',46,'13:44:16','13:44:43'),(31,'2017-05-20',46,'16:09:10','19:49:17'),(32,'2017-05-20',32,'17:17:32','17:17:40'),(33,'2017-05-22',46,'15:12:43','15:12:48'),(34,'2017-05-22',32,'15:12:58','15:13:24'),(35,'2017-05-22',43,'15:13:52','15:48:29'),(36,'2017-05-26',42,'18:34:48','18:35:04');
/*!40000 ALTER TABLE `days` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `storage`
--

DROP TABLE IF EXISTS `storage`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `storage` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `worker_name` varchar(100) DEFAULT NULL,
  `worker_experience` varchar(10) DEFAULT NULL,
  `worker_mobile_number` varchar(45) DEFAULT NULL,
  `task_title` varchar(5000) DEFAULT NULL,
  `done_in` datetime DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=11 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `storage`
--

LOCK TABLES `storage` WRITE;
/*!40000 ALTER TABLE `storage` DISABLE KEYS */;
INSERT INTO `storage` VALUES (1,'Austin Ellington','51','+375(33)5757035','Call mr.Tyron','0001-01-01 01:01:01'),(2,'Ariaolla Alsopp','8','+375(33)8593369','Fill in the documents','2017-05-07 19:13:17'),(3,'Ariaolla Alsopp','8','+375(33)8593369','Dont do that','0001-01-01 01:01:01'),(5,'Layla Aldridge','6','+375(33)7388258','Refresh deals','2017-05-16 22:28:28'),(6,'Alexis Charlson','29','+375(44)7786953','Identify key opportunities for delegation','0001-01-01 01:01:01'),(7,'Audrey Barnes','14','+375(29)6659325','As hell','2017-05-08 10:51:35'),(8,'Blake Palmer','90','+375(44)9317374','Play to your coworkers strengths','0001-01-01 01:01:01'),(9,'Carter Dickinson','37','+375(33)7667812','Guideline','0001-01-01 01:01:01'),(10,'Nolan Nathan','87','+375(44)3225081','Assign','0001-01-01 01:01:01');
/*!40000 ALTER TABLE `storage` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tasks`
--

DROP TABLE IF EXISTS `tasks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `tasks` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `title` varchar(1000) DEFAULT NULL,
  `note` varchar(15000) DEFAULT NULL,
  `issued_in` datetime DEFAULT NULL,
  `accepted_in` datetime DEFAULT NULL,
  `lead_time` int(11) DEFAULT NULL,
  `done_in` datetime DEFAULT NULL,
  `difficulity` tinyint(5) DEFAULT NULL,
  `worker_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_tasks-workers_idx` (`worker_id`),
  CONSTRAINT `fk_tasks-workers` FOREIGN KEY (`worker_id`) REFERENCES `workers` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=58 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tasks`
--

LOCK TABLES `tasks` WRITE;
/*!40000 ALTER TABLE `tasks` DISABLE KEYS */;
INSERT INTO `tasks` VALUES (6,'Do that','Hello moto','2017-04-14 13:30:23','0001-01-01 01:01:01',7,'0001-01-01 01:01:01',9,16),(18,'Git','asd','2017-04-15 19:21:56','0001-01-01 01:01:01',2,'0001-01-01 01:01:01',6,17),(19,'Make branches','sadqweqwe','2017-04-15 19:22:18','0001-01-01 01:01:01',4,'0001-01-01 01:01:01',6,16),(26,'ertert','ertertert','2017-04-17 14:29:00','0001-01-01 01:01:01',4,'0001-01-01 01:01:01',7,36),(27,'ertyery','eryeryeryery','2017-04-17 14:29:12','0001-01-01 01:01:01',8,'0001-01-01 01:01:01',7,37),(39,'Meeting. 8.00AM. Gibson','','2017-05-05 12:18:00','2017-05-05 12:55:00',48,'2017-05-22 15:13:05',2,32),(40,'Back-end for wieseknows.com','Faster boy. Alll you need to do is back-end. Its not a rocket technology','2017-05-05 12:19:00','2017-05-05 12:55:00',2,'0001-01-01 01:01:01',3,32),(43,'Something to fear','Gibson is getting sick about it','2017-05-07 19:10:40','2017-05-26 18:34:00',168,'0001-01-01 01:01:01',3,42),(45,'Do some things','','2017-05-10 12:11:31','2017-05-16 12:00:00',3,'2017-05-16 12:00:34',4,42),(46,'Carl','','2017-05-12 18:41:37','2017-05-22 15:13:00',24,'2017-05-22 15:14:00',3,43),(47,'Buy a DVD','Dont do that alone','2017-05-15 15:21:48','2017-05-19 13:44:00',4,'2017-05-19 13:44:27',4,46),(48,'Talk with your chief','As fast as you can','2017-05-15 15:22:32','2017-05-15 15:23:00',72,'2017-05-17 19:00:56',5,46),(49,'Find lost documents','Documents which were written by Gibson','2017-05-15 15:23:35','2017-05-15 16:09:00',9,'2017-05-16 22:20:40',5,46),(50,'Dont be shy','So doge wow','2017-05-16 12:00:05','2017-05-26 18:34:00',3,'0001-01-01 01:01:01',8,42),(54,'Convert money','','2017-05-16 22:19:57','2017-05-16 22:20:00',5,'2017-05-19 13:44:30',2,46),(57,'Get documents','You don\'t even realize how hard is this','2017-05-20 19:42:49','2017-05-20 19:49:00',5,'0001-01-01 01:01:01',10,46);
/*!40000 ALTER TABLE `tasks` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `users`
--

DROP TABLE IF EXISTS `users`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `users` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `fname` varchar(45) DEFAULT NULL,
  `lname` varchar(45) DEFAULT NULL,
  `login` varchar(9000) DEFAULT NULL,
  `password` varchar(9000) DEFAULT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `id_UNIQUE` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=23 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `users`
--

LOCK TABLES `users` WRITE;
/*!40000 ALTER TABLE `users` DISABLE KEYS */;
INSERT INTO `users` VALUES (14,'Night','Lovell','admin','admin'),(15,'Mel','Gibson','gibson','gibson'),(16,'John','Snow','johnatan','johnSnowForever88'),(17,'John','Sierra','johnatan_jr','somethingToKnow98'),(18,'Anatoly','Suka','johnatanblyad','helqweEWq'),(19,'Anatoly)','Kirill','mailru','sdasddas'),(20,'.KeyPress += Globals.Common.LettersOnly;','.KeyPress += Globals.Common.LettersOnly;','.KeyPress += Globals.Common.LettersOnly;','.KeyPress += Globals.Common.LettersOnly;'),(21,'adidas','adidas','MySql.Data.MySqlClient.MySqlHelper.EscapeString(','MySql.Data.MySqlClient.MySqlHelper.EscapeString('),(22,'@\"[0-9]+(\\.[0-9][0-9]?)?\"','@\"[0-9]+(\\.[0-9][0-9]?)?\"','@\"[0-9]+(\\.[0-9][0-9]?)?\"','@\"[0-9]+(\\.[0-9][0-9]?)?\"');
/*!40000 ALTER TABLE `users` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `workers`
--

DROP TABLE IF EXISTS `workers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `workers` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `fname` varchar(45) DEFAULT NULL,
  `lname` varchar(45) DEFAULT NULL,
  `mobile_number` varchar(15) DEFAULT NULL,
  `chief_id` int(11) DEFAULT NULL,
  `tasks_completed` int(11) DEFAULT NULL,
  `arrival_time` time DEFAULT NULL,
  `departure_time` time DEFAULT NULL,
  `rating` int(11) DEFAULT NULL,
  `experience` int(11) DEFAULT NULL,
  `login` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  PRIMARY KEY (`id`),
  KEY `fk_workers-users_idx` (`chief_id`),
  CONSTRAINT `fk_workers-users` FOREIGN KEY (`chief_id`) REFERENCES `users` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=48 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `workers`
--

LOCK TABLES `workers` WRITE;
/*!40000 ALTER TABLE `workers` DISABLE KEYS */;
INSERT INTO `workers` VALUES (16,'Bill','Gates','+375(44)9769535',14,0,'08:00:00','16:00:00',0,36,'gates','gates'),(17,'Erlich','Bachmann','+375(44)5999935',14,0,'14:00:00','21:00:01',0,5,'erlich','erlich'),(19,'Hudson','Gardner','+375(33)5775235',14,9,'08:00:00','16:00:00',0,38,'hudson','hudson'),(23,'Sean','Hancock','+375(25)5775835',14,0,'08:00:00','16:00:00',0,63,'sean','sean'),(28,'Xavier','Gibbs','+375(33)5857035',14,0,'08:00:00','16:00:00',0,58,'xavier','xavier'),(29,'Elizabeth','Barrington','+375(44)1257035',15,8,'08:00:00','16:00:00',0,15,'elizabeth','elizabeth'),(30,'Jacob','Davidson','+375(33)5766035',15,0,'08:00:00','17:00:00',0,32,'jacob','jacob'),(32,'Benjamin','Jeff','+375(25)5797035',15,1,'08:00:00','19:00:00',0,69,'benjamin','benjamin'),(35,'Noah','Harrison','+375(29)5558993',17,0,'08:00:00','16:00:00',0,65,'noah','noah'),(36,'Lucas','Chesterton','+375(33)9585569',17,0,'08:00:00','16:00:00',0,31,'lucas','lucas'),(37,'Alice','Chandter','+375(33)6239588',17,0,'08:00:00','16:00:00',0,28,'alice','alice'),(42,'Skyler','Bishop','+375(25)1988699',15,1,'08:00:00','16:00:00',0,21,'skyler','skyler'),(43,'James','Jeff','+375(25)5871589',15,1,'08:00:00','16:00:00',0,69,'james','james'),(44,'John','Flannagan','+375(33)8956985',15,0,'08:00:00','16:00:00',0,48,'johnatan_flannagan','johnatan'),(45,'Layla','Aldridge','+375(33)7388258',15,1,'08:00:00','16:00:00',0,6,'layla','layla'),(46,'Caroline','Calhoun','+375(25)2658963',15,3,'08:00:00','16:00:00',0,22,'caroline','caroline'),(47,'Isabella','Adamson','+375(25)1135354',15,0,'08:00:00','16:00:00',0,1,'isabella','isabella');
/*!40000 ALTER TABLE `workers` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2017-05-29 15:19:12
