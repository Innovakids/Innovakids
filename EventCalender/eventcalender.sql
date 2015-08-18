-- phpMyAdmin SQL Dump
-- version 2.11.9.2
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: May 05, 2011 at 06:20 AM
-- Server version: 5.0.67
-- PHP Version: 5.2.6

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `demo`
--

-- --------------------------------------------------------

--
-- Table structure for table `eventcalender`
--

DROP TABLE IF EXISTS `eventcalender`;
CREATE TABLE IF NOT EXISTS `eventcalender` (
  `evt_id` bigint(20) NOT NULL auto_increment,
  `evt_title` varchar(255) NOT NULL,
  `evt_date` date NOT NULL,
  `evt_stime` date NOT NULL,
  `evt_etime` varchar(255) NOT NULL,
  `evt_ticket` double NOT NULL,
  `evt_person` varchar(255) NOT NULL,
  `evt_phone` varchar(255) NOT NULL,
  `evt_place` varchar(255) NOT NULL,
  `evt_contact` varchar(255) NOT NULL,
  `evt_desc` text NOT NULL,
  PRIMARY KEY  (`evt_id`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

--
-- Dumping data for table `eventcalender`
--

