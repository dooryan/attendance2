/*
SQLyog Community v13.1.6 (64 bit)
MySQL - 5.0.67-community-nt : Database - db_attendance
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;
CREATE DATABASE /*!32312 IF NOT EXISTS*/`db_attendance` /*!40100 DEFAULT CHARACTER SET latin1 */;

USE `db_attendance`;

/*Table structure for table `tbl_department` */

DROP TABLE IF EXISTS `tbl_department`;

CREATE TABLE `tbl_department` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `name` varchar(45) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_department` */

insert  into `tbl_department`(`id`,`name`) values 
(1,'Plantation'),
(2,'Harvesting'),
(3,'Fertilizer'),
(4,'Office'),
(5,'Bagging'),
(6,'Bunch Spraying'),
(7,'Bud Removal/Debudding'),
(8,'Pests and Disease Management');

/*Table structure for table `tbl_emp_user` */

DROP TABLE IF EXISTS `tbl_emp_user`;

CREATE TABLE `tbl_emp_user` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `emp_id` int(10) default NULL,
  `user_id` int(10) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_emp_user` */

insert  into `tbl_emp_user`(`id`,`emp_id`,`user_id`) values 
(1,1,1),
(2,2,2),
(3,3,3);

/*Table structure for table `tbl_employee` */

DROP TABLE IF EXISTS `tbl_employee`;

CREATE TABLE `tbl_employee` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `f_name` varchar(100) NOT NULL,
  `l_name` varchar(100) NOT NULL,
  `address` varchar(150) NOT NULL,
  `birthdate` date NOT NULL,
  `date_hired` date NOT NULL,
  `gender` varchar(45) NOT NULL,
  `dept_id` int(10) unsigned NOT NULL,
  `contactno` varchar(45) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=1010 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_employee` */

insert  into `tbl_employee`(`id`,`f_name`,`l_name`,`address`,`birthdate`,`date_hired`,`gender`,`dept_id`,`contactno`) values 
(1000,'Taylor ','Swift','USA','2022-03-05','2022-02-04','Female',2,'039875412'),
(1001,'Selena','Gomez','USA','2022-01-12','2022-03-05','Female',1,'098745123'),
(1002,'Pink ','Sweats','USA','1989-07-13','2021-03-01','Male	',3,'0985212'),
(1003,'Dianne','Esperanza','NB','1988-09-09','2021-01-07','Female',4,'888'),
(1004,'Kezze Krisna','Rulida','Tagum City','1999-12-21','2021-03-01','Female',1,'767767'),
(1005,'Jenny Mie','Butlig','Mabini','1998-08-09','2021-03-02','Female',1,'454545'),
(1006,'Faith Myril','Esperanza','New Bataan','1998-03-26','2021-03-09','Female',2,'09477416123'),
(1008,'Kim','Hyejin','Seoul, South Korea','1995-07-20','2021-03-09','Female',4,'098745135989'),
(1009,'Wheein','Jung','Seoul, South Korea','1995-04-17','2021-03-08','Female',4,'09874512325');

/*Table structure for table `tbl_jobtitle` */

DROP TABLE IF EXISTS `tbl_jobtitle`;

CREATE TABLE `tbl_jobtitle` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `job_title` varchar(100) NOT NULL,
  `dept_id` int(10) unsigned NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_jobtitle` */

insert  into `tbl_jobtitle`(`id`,`job_title`,`dept_id`) values 
(1,'TigHUGAS',1);

/*Table structure for table `tbl_leave` */

DROP TABLE IF EXISTS `tbl_leave`;

CREATE TABLE `tbl_leave` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `emp_id` int(10) unsigned NOT NULL,
  `date_leave` date NOT NULL,
  `type` varchar(100) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_leave` */

/*Table structure for table `tbl_ontime_today` */

DROP TABLE IF EXISTS `tbl_ontime_today`;

CREATE TABLE `tbl_ontime_today` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `emp_id` varchar(45) NOT NULL,
  `timesheet_id` varchar(45) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_ontime_today` */

/*Table structure for table `tbl_pay_details` */

DROP TABLE IF EXISTS `tbl_pay_details`;

CREATE TABLE `tbl_pay_details` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `emp_id` int(45) NOT NULL,
  `rate_hour` varchar(100) NOT NULL,
  `rate_day` varchar(100) NOT NULL,
  `rate_month` varchar(100) NOT NULL,
  `philhealth` varchar(100) NOT NULL,
  `sss` varchar(100) NOT NULL,
  `pagibig` varchar(100) NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_pay_details` */

insert  into `tbl_pay_details`(`id`,`emp_id`,`rate_hour`,`rate_day`,`rate_month`,`philhealth`,`sss`,`pagibig`) values 
(1,1000,'44','350','3500','550','200','300'),
(2,1001,'41','326','6520','550','200','300'),
(3,1002,'44','350','3500','550','200','300'),
(4,1003,'41','26','6520','550','200','300');

/*Table structure for table `tbl_pay_history` */

DROP TABLE IF EXISTS `tbl_pay_history`;

CREATE TABLE `tbl_pay_history` (
  `id` int(10) NOT NULL auto_increment,
  `emp_id` int(10) default NULL,
  `date` date default NULL,
  `gross_pay` decimal(10,0) default NULL,
  `total_deduction` decimal(10,0) default NULL,
  `total_pay` decimal(10,0) default NULL,
  `day_period` int(11) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=104 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_pay_history` */

insert  into `tbl_pay_history`(`id`,`emp_id`,`date`,`gross_pay`,`total_deduction`,`total_pay`,`day_period`) values 
(103,1001,'2022-03-09',0,388,-388,16);

/*Table structure for table `tbl_report` */

DROP TABLE IF EXISTS `tbl_report`;

CREATE TABLE `tbl_report` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `emp_id` int(10) unsigned NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_report` */

/*Table structure for table `tbl_summaryhours` */

DROP TABLE IF EXISTS `tbl_summaryhours`;

CREATE TABLE `tbl_summaryhours` (
  `id` int(10) NOT NULL auto_increment,
  `date` date default NULL,
  `time_in` time default NULL,
  `time_out` time default NULL,
  `emp_id` int(10) unsigned NOT NULL,
  `total_hours` int(45) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=53 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_summaryhours` */

insert  into `tbl_summaryhours`(`id`,`date`,`time_in`,`time_out`,`emp_id`,`total_hours`) values 
(50,'2022-03-07','16:40:58','16:40:58',1001,9),
(51,'2022-03-08','14:10:11','15:33:49',1001,9),
(52,'2022-03-09','01:02:38',NULL,1004,NULL);

/*Table structure for table `tbl_timeout` */

DROP TABLE IF EXISTS `tbl_timeout`;

CREATE TABLE `tbl_timeout` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `emp_id` varchar(45) NOT NULL,
  `date` date NOT NULL,
  `time` timestamp NOT NULL default CURRENT_TIMESTAMP on update CURRENT_TIMESTAMP,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

/*Data for the table `tbl_timeout` */

/*Table structure for table `tbl_timesheet` */

DROP TABLE IF EXISTS `tbl_timesheet`;

CREATE TABLE `tbl_timesheet` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `user_id` int(45) NOT NULL,
  `status` varchar(45) NOT NULL,
  `ttime` time NOT NULL,
  `tdate` date NOT NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=130 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_timesheet` */

insert  into `tbl_timesheet`(`id`,`user_id`,`status`,`ttime`,`tdate`) values 
(124,51,'IN','16:40:58','2022-03-07'),
(125,51,'OUT','16:40:58','2022-03-07'),
(126,51,'IN','14:10:11','2022-03-08'),
(128,51,'OUT','15:33:49','2022-03-08'),
(129,72,'IN','01:02:38','2022-03-09');

/*Table structure for table `tbl_user` */

DROP TABLE IF EXISTS `tbl_user`;

CREATE TABLE `tbl_user` (
  `id` int(10) unsigned NOT NULL auto_increment,
  `username` varchar(45) NOT NULL,
  `password` varchar(45) NOT NULL,
  `date_created` datetime default NULL,
  `user_type` varchar(50) default NULL,
  `emp_id` int(10) default NULL,
  PRIMARY KEY  (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=73 DEFAULT CHARSET=latin1;

/*Data for the table `tbl_user` */

insert  into `tbl_user`(`id`,`username`,`password`,`date_created`,`user_type`,`emp_id`) values 
(1,'faith','faith','2021-03-08 19:57:55','user',1003),
(51,'atingskie','pzDHxpIxCv','2022-03-06 07:40:33','user',1001),
(67,'selena234','wtAADefg','2022-03-07 01:04:50','user',1002),
(68,'jennymie','ytCCNefg','2022-03-07 11:02:26','user',1005),
(69,'admin','psBxC','2022-03-07 12:09:31','admin',1000),
(71,'ating','dianne','2021-03-08 19:57:55','user',1006),
(72,'sistar19','HJBBtGFJttCH','2022-03-09 01:01:59','user',1004);

/* Function  structure for function  `fncLogin` */

/*!50003 DROP FUNCTION IF EXISTS `fncLogin` */;
DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` FUNCTION `fncLogin`(uname varchar(50),
                                           pass varchar(50),
                                                result integer) RETURNS int(11)
BEGIN


	IF EXISTS
        (SELECT * FROM tbl_user WHERE username=uname AND PASSWORD=pass)
	THEN 
	SET result = 1;
	
	ELSE 
	
	SET result = 0;
	END IF;
	
	
	RETURN(result);

END */$$
DELIMITER ;

/* Procedure structure for procedure `prcAddEmployee` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcAddEmployee` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcAddEmployee`(
                                                  fname varchar(45),
                                                  lname varchar(45),
                                                  bdate varchar(100),
                                                  address varchar(100),
                                                  gender varchar(50),
                                                  dept varchar(100),
                                                  datehired varchar(100),
                                                  contact varchar(50))
BEGIN

 DECLARE q INTEGER;
 SET q = (Select id from tbl_department where name=dept);

        insert into tbl_employee(id, f_name, l_name, address, birthdate,
                                        date_hired, gender, dept_id,
                                         contactno)
	values(default, fname, lname, address, bdate, datehired, gender, q, contact );




END */$$
DELIMITER ;

/* Procedure structure for procedure `prcAddUser` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcAddUser` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcAddUser`(IN eID int, IN uname varchar(50),
                                        IN pass varchar(50), In d varchar(50),
                                        IN utype varchar(50), INOUT ifExist Boolean)
BEGIN
     SET ifExist = TRUE;
     IF EXISTS
     (SELECT id FROM tbl_employee WHERE id=eID)
     THEN   
     INSERT INTO tbl_user (username, PASSWORD, date_created, user_type, emp_id)
     SELECT * FROM (SELECT uname, pass, d, utype, eID) AS tmp
     WHERE NOT EXISTS (SELECT username FROM tbl_user WHERE username = uname AND emp_id=eID) LIMIT 1;

     ELSE
     SET ifExist = FALSE;
     END IF;




END */$$
DELIMITER ;

/* Procedure structure for procedure `prcCheckUname` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcCheckUname` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcCheckUname`(IN uname varchar(50), INOUT exist boolean)
BEGIN

     SET exist = FALSE;
     IF EXISTS
     (SELECT username FROM tbl_user WHERE username=uname)
     THEN
     SET exist = TRUE;
     END IF;
END */$$
DELIMITER ;

/* Procedure structure for procedure `prcDecrypt` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcDecrypt` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcDecrypt`(IN uname varchar(50), OUT pwd varchar(50), OUT uType varchar(50))
BEGIN

SET pwd = (SELECT password FROM tbl_user WHERE username = uname);
SET uType = (SELECT user_type FROM tbl_user WHERE username = uname);
END */$$
DELIMITER ;

/* Procedure structure for procedure `prcDeleteEmployee` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcDeleteEmployee` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcDeleteEmployee`(emp_id integer)
BEGIN
       delete from tbl_employee where id=emp_id;

END */$$
DELIMITER ;

/* Procedure structure for procedure `prcDisplayAllPayHistory` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcDisplayAllPayHistory` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcDisplayAllPayHistory`()
BEGIN
   select a.l_name, a.f_name, b.date, b.emp_id, b.gross_pay, b.total_deduction, b.total_pay, b.day_period
   from tbl_pay_history b
   JOIN tbl_employee a
   WHERE  b.emp_id=a.id;
END */$$
DELIMITER ;

/* Procedure structure for procedure `prcDisplayAllTimesheet` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcDisplayAllTimesheet` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcDisplayAllTimesheet`()
BEGIN



     SELECT a.id,  a.f_name, a.l_name , b.tdate, b.ttime, b.status FROM tbl_employee a, tbl_timesheet b
JOIN tbl_user c
WHERE a.id=c.emp_id AND b.user_id=c.id;


END */$$
DELIMITER ;

/* Procedure structure for procedure `prcDisplayAllUsers` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcDisplayAllUsers` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcDisplayAllUsers`()
BEGIN
  select a.emp_id, a.username, b.f_name, b.l_name , a.date_created
  from tbl_user a, tbl_employee b
  where a.emp_id=b.id;
END */$$
DELIMITER ;

/* Procedure structure for procedure `prcDisplayEmployee` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcDisplayEmployee` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcDisplayEmployee`()
BEGIN
  select * from tbl_user where user_type="user";
END */$$
DELIMITER ;

/* Procedure structure for procedure `prcDisplayEmployeeID` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcDisplayEmployeeID` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcDisplayEmployeeID`()
BEGIN
select id from tbl_employee;

END */$$
DELIMITER ;

/* Procedure structure for procedure `prcDisplayEmployees` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcDisplayEmployees` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcDisplayEmployees`()
BEGIN

SELECT a.id, a.dept_id, b.name,  a.f_name, a.l_name, a.address, a.birthdate,  a.gender, a.date_hired, a.contactno
FROM tbl_employee a
JOIN tbl_department b
WHERE a.dept_id=b.id;




END */$$
DELIMITER ;

/* Procedure structure for procedure `prcDisplayEmployeeTimeIn` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcDisplayEmployeeTimeIn` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcDisplayEmployeeTimeIn`()
BEGIN
  
END */$$
DELIMITER ;

/* Procedure structure for procedure `prcDisplayEmployeeTimeRecord` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcDisplayEmployeeTimeRecord` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcDisplayEmployeeTimeRecord`(emp_id integer)
BEGIN
           select *  from tbl_employee where id=emp_id;
END */$$
DELIMITER ;

/* Procedure structure for procedure `prcDisplayEmpTimesheet` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcDisplayEmpTimesheet` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcDisplayEmpTimesheet`(uname varchar(50))
BEGIN

declare i integer;
set i = (select id from tbl_user where username=uname);

select tdate, ttime, status from tbl_timesheet where user_id=i;

END */$$
DELIMITER ;

/* Procedure structure for procedure `prcDisplayPayDetails` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcDisplayPayDetails` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcDisplayPayDetails`(i integer)
BEGIN

select emp_id, rate_hour, rate_day, rate_month, philhealth, sss, pagibig
from tbl_pay_details
where emp_id=i;

END */$$
DELIMITER ;

/* Procedure structure for procedure `prcDisplayPayHistorybyEmp` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcDisplayPayHistorybyEmp` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcDisplayPayHistorybyEmp`(id varchar(50))
BEGIN
SELECT b.l_name, b.f_name, a.emp_id, a.date, a.day_period, a.gross_pay, a.total_deduction, a.total_pay
FROM tbl_pay_history a
JOIN tbl_employee b
WHERE id=a.emp_id and b.id=a.emp_id;

END */$$
DELIMITER ;

/* Procedure structure for procedure `prcDisplayTotalHours` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcDisplayTotalHours` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcDisplayTotalHours`()
BEGIN

SELECT a.id,  a.f_name, a.l_name , b.date, b.time_in, b.time_out, b.total_hours 
FROM tbl_employee a, tbl_summaryhours b

WHERE a.id=b.emp_id;

END */$$
DELIMITER ;

/* Procedure structure for procedure `prcEditEmployee` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcEditEmployee` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcEditEmployee`(id1 integer(10),
                                                                        fname varchar(50),
                                                                        lname varchar (50),
                                                                        address varchar (100),
                                                                        bdate varchar(50),
                                                                        datehired varchar(50),
                                                                        gender varchar(50),
                                                                        dept varchar(100),
                                                                        contact varchar(50))
BEGIN

DECLARE d INTEGER;


 SET d = (Select id from tbl_department where name=dept);

UPDATE tbl_employee SET 
                                   f_name=fname,
                                   l_name=lname,
                                   address=address,
                                   birthdate=bdate,
                                   date_hired=datehired,
                                   gender=gender,
                                   dept_id=d,
                                   contactno=contact
                                   where id=id1;


END */$$
DELIMITER ;

/* Procedure structure for procedure `prcEntryTimeout` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcEntryTimeout` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcEntryTimeout`(uname varchar(100),
                                                            currDate varchar(100),
                                                            currTime varchar(100))
BEGIN
declare i integer;

SET i=(SELECT id FROM tbl_user WHERE username=uname);

UPDATE tbl_timesheet

        SET timeout= currDate
         WHERE user_id=i AND tdate=currDate;

END */$$
DELIMITER ;

/* Procedure structure for procedure `prcEntryTimesheet` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcEntryTimesheet` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcEntryTimesheet`(uname varchar(50),
                                                            stat varchar(50) ,
                                                      currTime varchar(100),
                                                      currDate varchar(50),
                                                      flag integer)
BEGIN


        declare i integer;
        declare taym integer;
        declare timein time;
        declare aydi integer;

     set aydi = (select emp_id from tbl_user where username=uname);



        set i=(select id from tbl_user where username=uname);

        insert into tbl_timesheet(id, user_id, status,ttime,tdate)
        values(DEFAULT, i, stat, currTime, currDate);

if flag=0     then
        insert into tbl_summaryhours(id, date ,time_in,time_out, emp_id)
        values(default, currDate, currTime, null, aydi);




   elseif flag=1    then

        set aydi = (select emp_id from tbl_user where username=uname);


        set timein=(select time_in from tbl_summaryhours where
                        date=currDate and emp_id=aydi);
        set taym =(SELECT
                       HOUR(TIMEDIFF(MIN(currTime), MAX(timein)))
                       FROM tbl_summaryhours
                       WHERE emp_id=aydi ORDER BY DATE=currDate);




        update tbl_summaryhours
        set time_out=currTime,
            total_hours=taym
        where emp_id=aydi and date=currDate;

    END IF;

END */$$
DELIMITER ;

/* Procedure structure for procedure `prcFilterSummaryHours` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcFilterSummaryHours` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcFilterSummaryHours`(date1 varchar(200),
                                                      date2 varchar(200),
                                                       i varchar(10))
BEGIN




SELECT a.id,  a.f_name, a.l_name , b.date, b.time_in, b.time_out, b.total_hours
FROM tbl_employee a
JOIN tbl_summaryhours b
WHERE a.id=b.emp_id AND b.emp_id=i AND b.DATE >= date1  AND b.DATE <= date2;



END */$$
DELIMITER ;

/* Procedure structure for procedure `prcFilterTimesheet` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcFilterTimesheet` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcFilterTimesheet`(date1 varchar(200),
                                                      date2 varchar(200),
                                                       id varchar(10))
BEGIN



declare i integer;
set i = (select id from tbl_user where emp_id=id);

SELECT a.id,  a.f_name, a.l_name , b.tdate, b.ttime, b.status FROM tbl_employee a, tbl_timesheet b
JOIN tbl_user c
WHERE a.id=c.emp_id AND b.user_id=c.id AND b.user_id=i AND tdate >= date1  AND tdate <= date2;

END */$$
DELIMITER ;

/* Procedure structure for procedure `prcInsertPay` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcInsertPay` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcInsertPay`(i integer,

                                                date varchar(100),
                                                gpay decimal,
                                                ttldeduction decimal,
                                                ttlpay decimal,
                                                days integer)
BEGIN

         insert into tbl_pay_history(emp_id,date,gross_pay, total_deduction,total_pay, day_period)
         SELECT * FROM (SELECT i, date, gpay,ttldeduction, ttlpay,days) AS tmp
         WHERE NOT EXISTS (SELECT DATE,emp_id,total_pay FROM `tbl_pay_history` WHERE DATE = date AND emp_id=i) LIMIT 1;
END */$$
DELIMITER ;

/* Procedure structure for procedure `prcSearchEmpAuto` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcSearchEmpAuto` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcSearchEmpAuto`(p_value varchar(50))
BEGIN


	SELECT a.id, a.dept_id, b.name,  a.f_name, a.l_name, a.address, a.birthdate,  a.gender, a.date_hired, a.contactno
        FROM tbl_employee a
        JOIN tbl_department b
        WHERE a.dept_id=b.id and
        a.f_name LIKE CONCAT(p_value,'%')  OR  a.l_name LIKE CONCAT(p_value,'%')
        OR b.name LIKE CONCAT(p_value,'%') OR a.id LIKE CONCAT(p_value, '%');


END */$$
DELIMITER ;

/* Procedure structure for procedure `prcSearchPayHistoryAuto` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcSearchPayHistoryAuto` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcSearchPayHistoryAuto`(p_value varchar(200))
BEGIN


        select *
        FROM tbl_pay_history

        where emp_id like concat(p_value,'%');


END */$$
DELIMITER ;

/* Procedure structure for procedure `prcSelAllEmployeeByAutoComplete` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcSelAllEmployeeByAutoComplete` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcSelAllEmployeeByAutoComplete`(p_value varchar(200))
BEGIN

	SELECT a.id, a.dept_id, b.name,  a.f_name, a.l_name, a.address, a.birthdate,  a.gender, a.date_hired, a.contactno
        FROM tbl_employee a
        JOIN tbl_department b
        WHERE a.dept_id=b.id and
        a.f_name LIKE CONCAT(p_value,'%')  OR  a.l_name LIKE CONCAT(p_value,'%')
        OR b.name LIKE CONCAT(p_value,'%') OR a.id LIKE CONCAT(p_value, '%');







END */$$
DELIMITER ;

/* Procedure structure for procedure `prcSelcEmpbyID` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcSelcEmpbyID` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcSelcEmpbyID`(empID integer)
BEGIN
      SELECT id, dept_id,  f_name, l_name, address, birthdate,  gender, date_hired, contactno
      FROM tbl_employee where id=empID;
END */$$
DELIMITER ;

/* Procedure structure for procedure `prcSelcEmpbyName` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcSelcEmpbyName` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcSelcEmpbyName`(empName varchar(100))
BEGIN
   SELECT id, dept_id,  f_name, l_name, address, birthdate,  gender, date_hired, contactno
      FROM tbl_employee WHERE f_name=empName or l_name=empName;
END */$$
DELIMITER ;

/* Procedure structure for procedure `prcSelectEmpName` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcSelectEmpName` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcSelectEmpName`(aydi varchar(10))
BEGIN
select l_name, f_name from tbl_employee
where id=aydi;


END */$$
DELIMITER ;

/* Procedure structure for procedure `prcSelectUsers` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcSelectUsers` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcSelectUsers`()
BEGIN

select * from tbl_user;

END */$$
DELIMITER ;

/* Procedure structure for procedure `prcTotalEmployees` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcTotalEmployees` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcTotalEmployees`(out total int)
BEGIN

  
  set total = (select count(*) from tbl_employee);


     select @total;

END */$$
DELIMITER ;

/* Procedure structure for procedure `prcValidateTimeEntry` */

/*!50003 DROP PROCEDURE IF EXISTS  `prcValidateTimeEntry` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prcValidateTimeEntry`(uname varchar(100),stat varchar(50), d varchar(100))
BEGIN
declare i INTEGER;
set i = (select id from tbl_user where username=uname);

select * from tbl_timesheet where user_id=i and status=stat and tdate=d;

END */$$
DELIMITER ;

/* Procedure structure for procedure `prc_late` */

/*!50003 DROP PROCEDURE IF EXISTS  `prc_late` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prc_late`(datenow varchar(100)
                                            )
BEGIN
     Select a.id, a.l_name, b.time_in
     from tbl_employee     a
     join tbl_summaryhours  b
     ON a.id=b.emp_id
     where b.date=datenow and b.time_in != "08:00:00"  ;

     END */$$
DELIMITER ;

/* Procedure structure for procedure `prc_ontime` */

/*!50003 DROP PROCEDURE IF EXISTS  `prc_ontime` */;

DELIMITER $$

/*!50003 CREATE DEFINER=`root`@`localhost` PROCEDURE `prc_ontime`(datenow varchar(100))
BEGIN

SELECT a.id, a.l_name, b.time_in
     FROM tbl_employee a
     JOIN tbl_summaryhours b
     ON a.id=b.emp_id
     WHERE b.date=datenow AND b.time_in <= "08:00:00"  ;
END */$$
DELIMITER ;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;
