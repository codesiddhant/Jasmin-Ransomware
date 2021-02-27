-- phpMyAdmin SQL Dump
-- version 4.9.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 02, 2020 at 11:01 PM
-- Server version: 10.4.10-MariaDB
-- PHP Version: 7.3.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `jasmin_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `master`
--

CREATE TABLE `master` (
  `id` int(11) NOT NULL,
  `admin` varchar(1000) NOT NULL,
  `creds` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `master`
--

INSERT INTO `master` (`id`, `admin`, `creds`) VALUES
(1, 'siddhant', '123456');

-- --------------------------------------------------------

--
-- Table structure for table `victims`
--

CREATE TABLE `victims` (
  `id` int(11) NOT NULL,
  `machine_name` varchar(1000) NOT NULL,
  `computer_user` varchar(1000) NOT NULL,
  `os` varchar(1000) NOT NULL,
  `date` varchar(1000) NOT NULL,
  `time` time NOT NULL,
  `ip` varchar(1000) NOT NULL,
  `location` text NOT NULL,
  `systemid` varchar(1000) NOT NULL,
  `password` varchar(1000) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `victims`
--

INSERT INTO `victims` (`id`, `machine_name`, `computer_user`, `os`, `date`, `time`, `ip`, `location`, `systemid`, `password`) VALUES
(304, 'DESKTOP-37Q74QH', 'cyberstair', 'Windows 10', '03-01-2020, Friday', '03:24:33', '47.247.223.177', 'Raipur', '96457DF79A87C7C0008A7BE7', 'xAS4NinH/HQKNJwsNtTWN5yD'),
(306, 'Bollywood', 'Salman Khan', 'Windows 10', '03-01-2020, Friday', '03:26:10', '47.247.223.177', 'Mumbai', 'df545f454f5d4f5d4af5', 'M9M99EvNpZVOWpy9Q8sZLHEP'),
(307, 'Indian Cricket', 'Virat Kohli', 'Mac Os 11', '03-01-2020, Friday', '03:27:03', '47.247.223.177', 'Delhi', 'SDGFs4F4S4FD4F4545fs', '3tIHrYJqqTSBpw4lgMMck1GD'),
(308, 'White House', 'Donald Trump', 'Windows 10', '03-01-2020, Friday', '03:28:32', '47.247.223.177', 'Washington Dc', 'fgighefesdgvrd5g45rd4h', 'RJtCd9QqiCfBaSU0zQf84dvd'),
(309, 'FiFa', 'Leone Messi', 'Mac Os 11', '03-01-2020, Friday', '03:29:59', '47.247.223.177', 'Argentina', 'gfhsfkdjkfvdd454s5g4', 'JDNAaz6e3oyM8cN+AGFdMl/5');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `master`
--
ALTER TABLE `master`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `victims`
--
ALTER TABLE `victims`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `master`
--
ALTER TABLE `master`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `victims`
--
ALTER TABLE `victims`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=310;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
