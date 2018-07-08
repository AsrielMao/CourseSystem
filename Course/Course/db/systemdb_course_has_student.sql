CREATE DATABASE  IF NOT EXISTS `systemdb` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `systemdb`;
-- MySQL dump 10.13  Distrib 5.7.17, for Win64 (x86_64)
--
-- Host: 192.168.151.61    Database: systemdb
-- ------------------------------------------------------
-- Server version	5.7.21-log

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
-- Table structure for table `course_has_student`
--

DROP TABLE IF EXISTS `course_has_student`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `course_has_student` (
  `course_id` varchar(100) NOT NULL,
  `student_id` varchar(100) NOT NULL,
  KEY `fk_student_idx` (`student_id`),
  KEY `fk_course_idx` (`course_id`),
  CONSTRAINT `fk_course` FOREIGN KEY (`course_id`) REFERENCES `course` (`course_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `fk_student` FOREIGN KEY (`student_id`) REFERENCES `student` (`student_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `course_has_student`
--

LOCK TABLES `course_has_student` WRITE;
/*!40000 ALTER TABLE `course_has_student` DISABLE KEYS */;
INSERT INTO `course_has_student` VALUES ('eee976af-8bba-4d38-9ae8-aa06a234e936','233'),('0013eec8-cf36-4281-bc85-7d88c4938920','233'),('44c123e2-14e1-4546-a341-f77aacd37a88','233'),('04795a33-49b3-4686-b456-83470c3a4cd5','233'),('40aed928-809f-46a3-a302-f8ed7db89706','233'),('0ac78081-ad8a-49e6-87d4-d295a29358e9','233'),('ce250f80-ee42-4306-badf-62f405e7089c','233'),('bc0cd434-17c3-4aea-bef3-9799368ec2a9','233'),('3efd96b0-e681-4f24-875e-ba23a82ed64a','233'),('3efd96b0-e681-4f24-875e-ba23a82ed64a','9a43593d-37ec-4b67-87be-9d6c64ec4eda'),('c9b2ad37-3094-4505-a8ff-ca043cb510f3','9a43593d-37ec-4b67-87be-9d6c64ec4eda'),('02522f13-0edd-451c-b366-938f93ac99cd','8a04cce1-6972-41c6-8ec2-c71d62a0f1e3'),('ce250f80-ee42-4306-badf-62f405e7089c','1adc84c1-e867-413f-8dd3-adaf1c3b1406'),('19b62e53-5f1a-4dce-9f4c-38dfb1917e34','1adc84c1-e867-413f-8dd3-adaf1c3b1406');
/*!40000 ALTER TABLE `course_has_student` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2018-06-04 14:57:14
