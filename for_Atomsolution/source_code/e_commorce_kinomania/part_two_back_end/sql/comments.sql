-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 12, 2018 at 09:35 AM
-- Server version: 10.1.24-MariaDB
-- PHP Version: 7.1.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `cms_carlovers`
--

-- --------------------------------------------------------

--
-- Table structure for table `comments`
--

CREATE TABLE `comments` (
  `comment_id` int(100) NOT NULL,
  `comment_post_id` int(100) NOT NULL,
  `comment_author` varchar(244) NOT NULL,
  `comment_email` varchar(244) NOT NULL,
  `comment_content` text NOT NULL,
  `comment_status` varchar(244) NOT NULL,
  `comment_date` date NOT NULL,
  `comment_post_title` varchar(244) NOT NULL,
  `comment_tag` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `comments`
--

INSERT INTO `comments` (`comment_id`, `comment_post_id`, `comment_author`, `comment_email`, `comment_content`, `comment_status`, `comment_date`, `comment_post_title`, `comment_tag`) VALUES
(1, 0, 'sofia', '', 'I Love Mercedes', '', '2018-10-02', '2019 Mercedes-Benz A 220', 'racing'),
(2, 0, 'sofia', '', 'Too expensive unfortunately !', '', '2018-10-02', '2019 Lincoln Nautilus First Drive Review', 'jeep'),
(4, 0, 'sofia', '', 'Too big for our roads', '', '2018-10-02', '2019 Ram Rebel 12 is luxurious off-road truck', 'jeep'),
(5, 0, 'sofia', '', 'The German engineering ', '', '2018-10-02', '2019 BMW X5 First Drive Review', 'jeep'),
(6, 0, 'nicedog', '', 'i want it ', '', '2018-10-02', '2019 Mercedes-Benz A 220', 'racing');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `comments`
--
ALTER TABLE `comments`
  ADD PRIMARY KEY (`comment_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `comments`
--
ALTER TABLE `comments`
  MODIFY `comment_id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
