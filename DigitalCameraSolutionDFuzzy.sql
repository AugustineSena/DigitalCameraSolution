/*
SQLyog Enterprise - MySQL GUI v8.05 
Author : Augustine Sena aka Sena | Malang, East Java, Indonesia © 2017 Ma Chung University
MySQL - 5.5.5-10.1.21-MariaDB : Database - digital_camera_solution
*********************************************************************
*/


/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

CREATE DATABASE /*!32312 IF NOT EXISTS*/`digital_camera_solution` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `digital_camera_solution`;

/*Table structure for table `main_data` */

DROP TABLE IF EXISTS `main_data`;

CREATE TABLE `main_data` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Prod_name` varchar(100) NOT NULL,
  `price` int(11) DEFAULT NULL,
  `brand` varchar(100) DEFAULT NULL,
  `type` text,
  `colour` text,
  `release_date` date DEFAULT NULL,
  `dimension_width` double DEFAULT NULL,
  `dimension_height` double DEFAULT NULL,
  `dimension_dept` double DEFAULT NULL,
  `dimension_weight` double DEFAULT NULL,
  `screen_dots` int(11) DEFAULT NULL,
  `max_res_width` int(11) DEFAULT NULL,
  `max_res_height` int(11) DEFAULT NULL,
  `image_ratio_min_w` int(11) DEFAULT NULL,
  `image_ratio_min_h` int(11) DEFAULT NULL,
  `image_ratio_max_w` int(11) DEFAULT NULL,
  `image_ratio_max_h` int(11) DEFAULT NULL,
  `effective_pixel` double DEFAULT NULL,
  `photo_detectors` double DEFAULT NULL,
  `sensor_size_width` double DEFAULT NULL,
  `sensor_size_height` double DEFAULT NULL,
  `ISO_min` int(11) DEFAULT NULL,
  `ISO_max` int(11) DEFAULT NULL,
  `White_Blnc_presets` int(11) DEFAULT NULL,
  `coverage` double DEFAULT NULL,
  `magnification` double DEFAULT NULL,
  `shutter_speed_min` double DEFAULT NULL,
  `shutter_speed_max` double DEFAULT NULL,
  `flash_range` double DEFAULT NULL,
  `continuos_drivemax` double DEFAULT NULL,
  `self_timermax` int(11) DEFAULT NULL,
  `exposure_comp` double DEFAULT NULL,
  `ae_bracketing` double DEFAULT NULL,
  `wb_bracketing` double DEFAULT NULL,
  `resolution_min_w` int(11) DEFAULT NULL,
  `resolution_min_h` int(11) DEFAULT NULL,
  `resolution_max_w` int(11) DEFAULT NULL,
  `resolution_max_h` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID`,`Prod_name`),
  UNIQUE KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=latin1;

/*Data for the table `main_data` */

insert  into `main_data`(`ID`,`Prod_name`,`price`,`brand`,`type`,`colour`,`release_date`,`dimension_width`,`dimension_height`,`dimension_dept`,`dimension_weight`,`screen_dots`,`max_res_width`,`max_res_height`,`image_ratio_min_w`,`image_ratio_min_h`,`image_ratio_max_w`,`image_ratio_max_h`,`effective_pixel`,`photo_detectors`,`sensor_size_width`,`sensor_size_height`,`ISO_min`,`ISO_max`,`White_Blnc_presets`,`coverage`,`magnification`,`shutter_speed_min`,`shutter_speed_max`,`flash_range`,`continuos_drivemax`,`self_timermax`,`exposure_comp`,`ae_bracketing`,`wb_bracketing`,`resolution_min_w`,`resolution_min_h`,`resolution_max_w`,`resolution_max_h`) values (1,'Panasonic Lumix DMC-G3',7360000,'Panasonic','SD, SDHC, SDXC','Black','2011-01-01',115,84,47,336,460000,4592,3448,1,1,16,9,15.8,16.6,17.3,13,100,6400,5,1,1.4,60,0.00025,11,10,10,5,2,3,640,480,1280,720),(2,'Nikon 1 AW1',9300000,'Nikon','SD, SDHC, SDXC','Black, Silver','2013-09-01',114,72,37,201,920000,4608,3072,3,2,16,9,14,15,13.2,8.8,160,6400,7,0,0,30,0.0000625,5,0,10,1,0,0,320,120,1920,1080),(3,'Olympus PEN E-PL5',9650000,'Olympus','SD, SDHC, SDXC','Black, White','2012-01-01',111,64,38,325,460000,4608,3456,0,0,4,3,16.1,17.2,17.3,13,100,25600,8,0,0,60,0.00025,7,8,12,3,4,3,640,480,1920,1080),(4,'Sony Alpha NEX-5R',3700000,'Sony','SD, SDHC, SDXC, Memory Stick Pro Duo, Memory Stick Pro-HG Duo','Black','2012-01-01',111,59,39,276,920000,4912,3264,3,2,16,9,16.1,16.7,23.5,15.7,100,25600,6,0,0,30,0.00025,12,10,10,3,0,0,640,480,1920,1080),(5,'Panasonic Lumix DMC-GF6',7000000,'Panasonic','SD, SDHC, SDXC','Black','2013-01-01',111,65,38,323,1040000,4592,3448,1,1,16,9,16,16.7,17.3,13,160,25600,5,0,0,60,0.00025,6.3,4.2,10,3,2,3,640,480,1920,1080),(6,'Nikon D300S',8000000,'Nikon','SD, SDHC, SDXC, Compact Flash Type I','Black, Dark Maroon','2009-01-01',147,114,74,938,920000,4288,2848,0,0,3,2,12.3,13.1,23.6,15.8,100,6400,12,1,0.94,30,0.000125,12,7,20,5,5,9,320,240,1280,720),(7,'Panasonic Lumix DMC-GX7',8999000,'Panasonic','Mirrorless','Black, Silver','2013-08-01',123,71,55,402,1040000,4592,3448,1,1,16,9,16,0,17.3,13,125,25600,6,1,1.39,60,0.000125,7,5,10,5,3,0,640,480,1920,1080),(8,'Samsung NX3000',5980000,'Samsung','Mirrorless','Black, White, Brown, Pink','2014-05-01',117,66,39,0,460800,5472,3648,1,1,16,9,20,0,23.5,15.7,100,25600,7,0,0,30,0.00025,0,5,0,3,3,0,320,240,1920,1080),(9,'Samsung NX1000',4800000,'Samsung','Mirrorless','','2012-01-01',114,63,37,222,921000,5472,3648,1,1,16,9,20.3,21.6,23.4,15.6,100,12800,8,0,0,30,0.00025,0,0,0,3,3,3,320,240,1920,1080),(10,'Panasonic Lumix DMC-G5',6500000,'Panasonic','SD, SDHC, SDXC','','2012-01-01',120,83,71,396,920000,4608,3456,1,1,16,9,16.1,18.3,17.3,13,160,12800,5,1,1.4,60,0.00025,10.5,20,10,5,3,3,640,480,1920,1080),(11,'Sony Alpha NEX-3N',4500000,'Sony','SD, SDHC, SDXC, Memory Stick Pro Duo, Memory Stick Pro-HG Duo','Black','2013-01-01',110,62,35,269,460000,4912,3264,3,2,16,9,16.1,16.5,23.5,15.7,200,16000,6,0,0,0,0,0,4,0,0,0,0,0,0,1920,1080),(12,'Olympus OM-D E-M5',10499000,'Olympus','SLR-style Mirrorless','Black, Silver','2012-02-01',122,89,43,425,610000,4608,3456,1,1,16,9,16,0,17.3,13,200,25600,12,1,1.15,60,0.00025,0,9,0,3,4,0,640,480,1920,1080),(13,'Samsung NX300',5300000,'Samsung','SD, SDHC, SDXC','Black','2013-01-01',122,64,41,280,768000,5472,3648,1,1,16,9,20.3,21.6,23.4,15.6,100,25600,0,0,0,30,0.000166667,0,9,30,3,0,0,320,240,1920,1080),(14,'Nikon D200',4000000,'Nikon','Compact Flash (Type I or II)','Black','2005-11-01',147,113,74,920,230000,3872,2592,0,0,3,2,10.2,10.9,23.6,15.8,100,3200,6,0.95,0.94,30,0.000125,12,5,20,5,0,0,0,0,0,0),(15,'Nikon D700',12000000,'Nikon','Compact Flash (Type I)','Black','2008-01-01',147,123,77,1074,922000,4256,2832,0,0,3,2,12.1,12.9,36,24,100,25600,12,0.95,0.72,30,0.000125,0,8,20,5,4,0,0,0,0,0),(16,'Panasonic Lumix DMC-GF2',2750000,'Panasonic','SD, SDHC, SDXC','Red','2011-01-01',113,68,33,310,460000,4000,3000,1,1,16,9,12.1,13.1,17.3,13,100,6400,5,0,0,60,0.00025,6,3.2,10,3,1.3,3,320,240,1920,1080),(17,'Sony Alpha NEX-5',3500000,'Sony','SD, SDHC, SDXC, Memory Stick Pro Duo, Memory Stick Pro-HG Duo','Black','2010-01-01',111,59,38,287,920000,4592,3056,3,2,16,9,14.2,14.6,23.5,15.7,200,12800,6,0,0,30,0.00025,12,7,10,2,0,0,640,480,1920,1080),(18,'Nikon D750',24400000,'Nikon','Mid-size SLR','Black','2014-09-01',141,113,78,750,1229000,6016,4016,0,0,3,2,24,0,35.9,24,50,512000,12,1,0.7,30,0.00025,12,6.5,20,5,4,0,1280,720,1920,1080),(19,'Nikon D600',12000000,'Nikon','SD x2 slots,SDHC x2 slots, SDXC x2 slots','Black','2012-01-01',141,113,82,850,921000,6016,4016,0,0,3,2,24.3,24.7,35.9,24,50,25600,12,1,0.7,30,0.00025,12,5.5,0,5,3,3,1280,720,1920,1080),(20,'Nikon D800E',22000000,'Nikon','SD, SDHC, SDXC, Compact Flash (Type I), UHS-I compliant','Black','2012-01-01',146,123,82,900,921000,7360,4912,3,2,5,4,36.3,36.8,35.9,24,50,25600,12,1,0.7,30,0.000125,12,6,20,5,4,9,640,424,1920,1080),(21,'Nikon 1 J3',3500000,'Nikon','SD, SDHC, SDXC','White','2013-01-01',101,61,29,201,921000,4608,3072,3,2,16,9,14.2,0,13.2,8.8,0,0,6,0,0,30,0.0000625,5,15,0,0,0,0,320,120,1920,1080),(22,'Nikon D500',26000000,'Nikon','Mid-size SLR','Black','2016-01-01',147,115,81,860,2359000,5568,3712,0,0,3,2,21,0,23.5,15.7,50,1640000,12,1,1,30,0.000125,0,10,20,5,0,0,720,640,4096,3840),(23,'Sony Alpha NEX-6',4800000,'Sony','SD, SDHC, SDXC, Memory Stick Pro Duo, Memory Stick Pro-HG Duo','Black','2012-01-01',120,67,43,345,921000,4912,3264,3,2,16,9,16.1,16.7,23.5,15.7,100,25600,6,0,0,30,0.00025,0,10,10,5,3,0,640,480,1920,1080),(24,'Canon EOS 400D ',4000000,'Canon',' Compact Flash (Type I or II)','Black','2006-01-01',127,94,65,556,230000,3888,2592,0,0,3,2,10.1,10.5,22.7,15.1,100,1600,6,0.95,0.8,30,0.00025,12,3,10,2,0,0,0,0,0,0),(25,'Nikon D5300',5200000,'Nikon','SD, SDHC, SDXC','Black','2013-10-01',125,98,76,480,1037000,6000,4000,0,0,3,2,24,25,23.5,15.6,100,25600,12,0.95,0.82,30,0.00025,12,5,20,5,2,3,640,424,1920,1080),(26,'Nikon D5600',10900000,'Nikon','DSLR','Black','2016-10-01',124,97,70,465,1037000,6000,4000,0,0,3,2,24,0,23.5,15.6,100,25600,12,0.95,0.82,30,0.00025,12,3,0,5,0,0,1280,720,1920,1080),(27,'Nikon D3200',4450000,'Nikon','SD, SDHC, SDXC, UHS-I compliant','Black','2012-01-01',125,96,77,505,921000,6016,4000,0,0,3,2,24.2,24.7,23.2,15.4,100,12800,12,0.95,0.8,30,0.00025,12,4,0,5,0,0,640,424,1920,1080),(28,'Nikon D5200',5799000,'Nikon','SD, SDHC, SDXC','Black','2012-01-02',129,98,78,555,921000,0,0,0,0,3,2,24.1,24.7,23.5,15.6,0,0,12,0.95,0.78,30,0.00025,12,5,20,5,2,3,640,424,1920,1080),(29,'Canon EOS 5DS R',48760000,'Canon','DSLR, SD, SDHC, SDXC  (UHS-I compatible), CompactFlash','Black','2015-02-01',152,116,76,930,1040000,8688,5792,3,2,16,9,51,0,36,24,50,12800,8,1,0.71,30,0.000125,0,5,0,5,3,0,640,480,1920,1080),(30,'Canon EOS M',4800000,'Canon','SD, SDHC, SDXC, Rangefinder-style mirrorless','Black, White','2012-01-01',109,66,32,298,1040000,5184,3456,0,0,0,0,18,18.5,22.3,14.9,100,25600,6,0,0,60,0.00025,0,4.3,10,3,2,3,640,480,1920,1080),(31,'Nikon D3400',5199000,'Nikon','SD, SDHC, SDXC, DSLR','Black','2016-08-01',124,98,76,395,921000,6000,4000,0,0,3,2,24,0,23.5,15.6,100,256000,12,0.95,0.85,30,0.00025,12,5,0,5,0,0,640,424,1920,1080),(32,'Canon EOS 1300D',4599000,'Canon','SD, SDHC, SDXC, DSLR','Black','2016-03-01',129,101,78,485,920000,5184,3456,1,1,16,9,18,0,22.3,14.9,100,12800,6,0.95,0.8,30,0.00025,9.2,3,0,5,2,0,640,480,1920,1080),(33,'Canon EOS 1100D',4000000,'Canon','SD, SDHC, SDXC, Compact SLR','Black','2011-01-01',130,100,78,495,230000,4272,2848,0,0,3,2,12.2,12.6,22.2,14.7,100,6400,6,0.95,0.8,30,0.00025,9.2,3,10,5,2,3,0,0,1280,720),(34,'Canon EOS 600D',5799000,'Canon','SD, SDHC, SDXC, Compact SLR','Black','2011-01-01',133,100,80,570,1040000,5184,3456,1,1,16,9,18,18.7,22.3,14.9,100,12800,6,0.95,0.85,30,0.00025,13,3.7,10,5,2,3,640,480,1920,1080),(35,'Samsung NX300',5300000,'Samsung','SD, SDHC, SDXC, Rangefinder-style mirrorless','Black','2013-01-01',122,64,41,280,768000,5472,3648,1,1,16,9,20.3,21.6,23.4,15.6,100,25600,0,0,0,30,0.000166667,0,9,30,3,0,0,320,240,1920,1080),(36,'Samsung NX210',4700000,'Samsung','SD, SDHC, SDXC, Rangefinder-style mirrorless','Black','2012-01-01',117,63,37,222,614000,5472,3648,1,1,16,9,20.3,21.6,23.4,15.6,100,12800,8,0,0,30,0.00025,0,8,30,3,3,3,320,240,1920,1080),(37,'Samsung NX20',5800000,'Samsung','SD, SDHC, SDXC, Rangefinder-style mirrorless','Black','2012-01-01',122,90,40,341,614000,5472,3648,1,1,16,9,20.3,21.6,23.4,15.6,100,12800,8,1,1.04,30,0.000125,11,8,30,3,3,3,320,240,1920,1080),(38,'Olympus PEN E-PM2',3500000,'Olympus','SD, SDHC, SDXC, Rangefinder-style mirrorless','Silver, Magenta','2012-01-01',110,64,34,269,460000,4608,3456,0,0,4,3,16.1,17.2,17.3,13,200,25600,8,0,0,60,0.00025,7,8,12,3,4,3,640,480,1920,1080),(39,'Olympus PEN E-PL3',4900000,'Olympus','SD, SDHC, SDXC, Rangefinder-style mirrorless','Red','2010-12-31',110,64,37,313,460000,4032,3024,0,0,4,3,12.3,13.1,17.3,13,100,12800,8,0,0,60,0.00025,0,5.5,12,3,4,3,640,480,1280,720),(40,'Nikon 1 V2',6500000,'Nikon','SD, SDHC, SDXC, Rangefinder-style mirrorless','Black','2012-01-01',109,82,46,278,921000,4608,3072,3,2,16,9,14.2,0,13.2,8.8,0,0,6,1,0,0,0,0,15,0,0,0,0,320,120,1920,1080),(41,'Nikon 1 V1',3500000,'Nikon','SD, SDHC, SDXC, Rangefinder-style mirrorless','White','2011-01-01',113,76,44,383,921000,3872,2592,3,2,16,9,10.1,12,13.2,8.8,0,0,6,1,0,30,0.0000625,0,10,0,0,0,0,320,120,1920,1080),(42,'Sony Alpha NEX-3',4000000,'Sony','SD, SDHC, SDXC, Memory Stick Pro Duo, Memory Stick Pro-HG Duo, Rangefinder-style mirrorless','Black, Magenta','2010-01-01',117,62,33,297,920000,4592,3056,3,2,16,9,14.2,14.6,23.5,15.7,200,12800,6,0,0,30,0.00025,0,7,10,2,0,0,640,480,1280,720),(43,'Sony Alpha NEX-7',14000000,'Sony','SD, SDHC, SDXC, Memory Stick Pro Duo, Memory Stick Pro-HG Duo, Rangefinder-style mirrorless','Black','2011-01-01',120,67,43,400,921000,6000,4000,3,2,16,9,24.3,24.7,23.5,15.7,100,16000,6,1,1.09,30,0.00025,6,10,10,5,3,0,640,480,1920,1080),(44,'Panasonic Lumix DMC-GH3',17000000,'Panasonic','SD, SDHC, SDXC, SLR-style mirrorless','Black','2012-01-01',133,93,82,550,614000,4608,3456,1,1,16,9,16.1,17.2,17.3,13,160,12800,5,1,1.34,60,0.00025,12,20,10,5,1,3,640,480,1920,1080),(45,'Sony SLT-A99',15499000,'Sony','SD, SDHC, SDXC, Memory Stick Pro Duo, Memory Stick Pro-HG Duo, Mid-size SLR','Black','2012-01-01',147,111,78,812,1229000,6000,4000,3,2,16,9,24.3,24.7,35.9,24,100,25600,8,0,0,30,0.000125,0,6,10,5,2,3,640,424,1920,1080),(46,'Samsung NX2000',3700000,'Samsung','SD, SDHC, SDXC, Rangefinder-style mirrorless','Black, White','2013-01-01',119,65,36,228,1152000,5472,3648,1,1,16,9,20,0,23.5,15.7,100,25600,8,1,1,30,0.00025,0,8,0,0,0,3,320,240,1920,1080),(47,'Pentax Q10',3200000,'Pentax','SD, SDHC, SDXC, Rangefinder-style mirrorless','Silver, Red','2012-01-01',102,58,34,200,460000,4000,3000,1,1,16,9,12.4,12.7,6.17,4.55,100,6400,9,0,0,30,0.000125,7,5,12,3,3,0,320,240,1920,1080),(48,'Sony Alpha DSLR-A330',1500000,'Sony','SD, SDHC, Memory Stick Pro Duo, Compact SLR','Black, Dark Brown','2009-01-01',128,97,71,529,230400,3872,2592,3,2,16,9,10.2,10.8,23.5,15.7,100,3200,6,0.95,0.74,30,0.00025,10,2.5,10,2,0,0,0,0,0,0),(49,'Panasonic Lumix DMC-GF3',3000000,'Panasonic','SD, SDHC, SDXC, Rangefinder-style mirrorless','Black','2011-01-01',108,67,32,264,460000,4000,3000,1,1,16,9,12.1,13.1,17.3,13,160,6400,5,0,0,60,0.00025,6.3,3.2,10,3,2,3,320,240,1920,1080),(50,'Canon EOS 5D',7000000,'Canon','Compact Flash (Type I or II), Mid-size SLR','Black','2005-01-01',152,113,75,895,230000,4368,2912,0,0,3,2,12.7,13.3,36,24,50,3200,6,0.96,0.71,30,0.000125,0,3,10,2,2,3,0,0,0,0);

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
