-- MySQL dump 10.13  Distrib 5.6.24, for Win64 (x86_64)
--
-- Host: localhost    Database: clinica_sanpablo
-- ------------------------------------------------------
-- Server version	5.6.26-log

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
-- Table structure for table `consulta`
--

DROP TABLE IF EXISTS `consulta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `consulta` (
  `Cod_Consulta` int(11) NOT NULL AUTO_INCREMENT,
  `Diagnostico` varchar(80) DEFAULT NULL,
  PRIMARY KEY (`Cod_Consulta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `consulta`
--

LOCK TABLES `consulta` WRITE;
/*!40000 ALTER TABLE `consulta` DISABLE KEYS */;
/*!40000 ALTER TABLE `consulta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_consulta`
--

DROP TABLE IF EXISTS `detalle_consulta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_consulta` (
  `Num_Expediente` int(11) NOT NULL,
  `Cod_Consulta` int(11) NOT NULL,
  `Fecha_Consulta` date DEFAULT NULL,
  PRIMARY KEY (`Num_Expediente`,`Cod_Consulta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_consulta`
--

LOCK TABLES `detalle_consulta` WRITE;
/*!40000 ALTER TABLE `detalle_consulta` DISABLE KEYS */;
/*!40000 ALTER TABLE `detalle_consulta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medicamentos`
--

DROP TABLE IF EXISTS `medicamentos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `medicamentos` (
  `Cod_Medicamento` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre_Medicamento` varchar(45) NOT NULL,
  `Descripcion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`Cod_Medicamento`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medicamentos`
--

LOCK TABLES `medicamentos` WRITE;
/*!40000 ALTER TABLE `medicamentos` DISABLE KEYS */;
INSERT INTO `medicamentos` VALUES (1,'Systane Ultra','Lubricante para ojos');
/*!40000 ALTER TABLE `medicamentos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paciente`
--

DROP TABLE IF EXISTS `paciente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `paciente` (
  `Num_Expediente` int(11) NOT NULL,
  `Nombres` varchar(30) NOT NULL,
  `Apellido_Paterno` varchar(15) DEFAULT NULL,
  `Apellido_Materno` varchar(15) DEFAULT NULL,
  `Sexo` char(1) NOT NULL,
  `Telefono` int(11) DEFAULT NULL,
  `Fecha_Nac` date DEFAULT NULL,
  PRIMARY KEY (`Num_Expediente`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COMMENT='Tabla de Paciente los VARCHAR contienen tamaños especificos';
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paciente`
--

LOCK TABLES `paciente` WRITE;
/*!40000 ALTER TABLE `paciente` DISABLE KEYS */;
INSERT INTO `paciente` VALUES (2,'Federman ','Rivera','Lanuza','M',27131145,'2003-11-06'),(3,'Lizet','Lanuza','Castillo','F',86597412,'1972-12-15'),(4,'Greyner','Caceres','Blandon','M',57894650,'1995-05-07'),(5,'Ruben','Perez','Gonzales','M',57894556,'2016-05-07'),(6,'Federico','Rivera','Castro','M',56789512,'1970-07-09');
/*!40000 ALTER TABLE `paciente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proxima_consulta`
--

DROP TABLE IF EXISTS `proxima_consulta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proxima_consulta` (
  `Cod_ProxConsulta` int(11) NOT NULL AUTO_INCREMENT,
  `Fecha_ProxConsulta` date DEFAULT NULL,
  `Hora_ProxConsulta` time DEFAULT NULL,
  `Estado` varchar(15) DEFAULT NULL,
  `Cod_Consulta` int(11) DEFAULT NULL,
  PRIMARY KEY (`Cod_ProxConsulta`),
  KEY `Cod_Consulta_idx` (`Cod_Consulta`),
  CONSTRAINT `Cod_Consulta` FOREIGN KEY (`Cod_Consulta`) REFERENCES `consulta` (`Cod_Consulta`) ON DELETE CASCADE ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proxima_consulta`
--

LOCK TABLES `proxima_consulta` WRITE;
/*!40000 ALTER TABLE `proxima_consulta` DISABLE KEYS */;
/*!40000 ALTER TABLE `proxima_consulta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `receta`
--

DROP TABLE IF EXISTS `receta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `receta` (
  `Cod_Receta` int(11) NOT NULL AUTO_INCREMENT,
  `Medicamento` varchar(45) DEFAULT NULL,
  `Dosis` varchar(45) DEFAULT NULL,
  `Duracion` varchar(45) DEFAULT NULL,
  `Observacion` varchar(45) DEFAULT NULL,
  `Cod_Consulta` int(11) DEFAULT NULL,
  PRIMARY KEY (`Cod_Receta`),
  KEY `Cod_Consulta_idx` (`Cod_Consulta`),
  KEY `Cod_Consultax_idx` (`Cod_Consulta`),
  CONSTRAINT `Cod_Consultax` FOREIGN KEY (`Cod_Consulta`) REFERENCES `consulta` (`Cod_Consulta`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `receta`
--

LOCK TABLES `receta` WRITE;
/*!40000 ALTER TABLE `receta` DISABLE KEYS */;
/*!40000 ALTER TABLE `receta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `receta_medicamentos`
--

DROP TABLE IF EXISTS `receta_medicamentos`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `receta_medicamentos` (
  `Cod_Receta` int(11) NOT NULL,
  `Cod_Medicamento` int(11) NOT NULL,
  `Cantidad` int(11) DEFAULT NULL,
  PRIMARY KEY (`Cod_Receta`,`Cod_Medicamento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `receta_medicamentos`
--

LOCK TABLES `receta_medicamentos` WRITE;
/*!40000 ALTER TABLE `receta_medicamentos` DISABLE KEYS */;
/*!40000 ALTER TABLE `receta_medicamentos` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `usuarios` (
  `ID_Usuario` int(11) NOT NULL AUTO_INCREMENT,
  `Usuario` varchar(45) NOT NULL,
  `Contraseña` varchar(10) NOT NULL,
  `Privilegio` varchar(45) NOT NULL,
  PRIMARY KEY (`ID_Usuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2016-05-10 23:37:55
