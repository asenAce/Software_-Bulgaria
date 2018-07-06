-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 06, 2018 at 08:54 PM
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
-- Database: `cms`
--
CREATE DATABASE IF NOT EXISTS `cms` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `cms`;

-- --------------------------------------------------------

--
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `admin_id` int(10) NOT NULL,
  `admin_username` varchar(244) NOT NULL,
  `admin_password` varchar(244) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`admin_id`, `admin_username`, `admin_password`) VALUES
(3, 'yambol', 'taskforce'),
(6, 'london', 'case'),
(7, 'bulg80', 'calistra90');

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `cat_id` int(12) NOT NULL,
  `cat_title` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`cat_id`, `cat_title`) VALUES
(2, 'PHP'),
(19, 'Cabrio'),
(22, 'Racing Cars'),
(23, 'Limozine');

-- --------------------------------------------------------

--
-- Table structure for table `comments`
--

CREATE TABLE `comments` (
  `comment_id` int(3) NOT NULL,
  `comment_post_id` int(3) NOT NULL,
  `comment_author` varchar(255) NOT NULL,
  `comment_email` varchar(255) NOT NULL,
  `comment_content` text NOT NULL,
  `comment_status` varchar(266) NOT NULL,
  `comment_date` date NOT NULL,
  `comment_post_title` varchar(244) NOT NULL,
  `comment_tag` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `comments`
--

INSERT INTO `comments` (`comment_id`, `comment_post_id`, `comment_author`, `comment_email`, `comment_content`, `comment_status`, `comment_date`, `comment_post_title`, `comment_tag`) VALUES
(21, 0, 'rico', '', 'sport cars are good', '', '2018-07-05', 'Luizi from Brooklyng pkEdit2', 'sport car'),
(24, 0, 'rico', '', 'comment with Kiril', '', '2018-07-05', 'Luizi from Brooklyng pkEdit2', 'sport car');

-- --------------------------------------------------------

--
-- Table structure for table `photoalbum`
--

CREATE TABLE `photoalbum` (
  `photo_id` int(100) NOT NULL,
  `photo_title` varchar(244) NOT NULL,
  `photo_image` text NOT NULL,
  `photo_post_category` varchar(244) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `photoalbum`
--

INSERT INTO `photoalbum` (`photo_id`, `photo_title`, `photo_image`, `photo_post_category`) VALUES
(2, 'chraysler', 'Chrysler-ME412-002.jpg', 'Racing Cars'),
(3, 'Kawasaki', 'Honda-S2000-014.jpg', 'Racing Cars'),
(5, 'Austin-martin', 'Aston-Martin-DBR9-001.jpg', 'Racing Cars'),
(6, 'Audi', 'Audi-PikesPeak-001.jpg', 'Racing Cars'),
(7, 'Audi RSK', 'Audi-RSQ-Concept-002.jpg', 'Racing Cars'),
(8, 'Audi RSK', 'Audi-RSQ-Concept-004.jpg', 'Racing Cars'),
(9, 'Audi RSK', 'Audi-RSQ-Concept-007.jpg', 'Racing Cars'),
(10, 'Audi RSK', 'Audi-RSQ-Concept-008.jpg', 'Racing Cars'),
(11, 'Audi RSK', 'Audi-RSQ-Concept-010.jpg', 'Racing Cars');

-- --------------------------------------------------------

--
-- Table structure for table `posts`
--

CREATE TABLE `posts` (
  `post_id` int(3) NOT NULL,
  `post_tags` varchar(255) NOT NULL,
  `post_comment_count` int(255) NOT NULL,
  `post_status` varchar(255) NOT NULL DEFAULT 'draft',
  `post_category_id` int(3) NOT NULL,
  `post_title` varchar(255) NOT NULL,
  `post_author` varchar(255) NOT NULL,
  `post_date` date NOT NULL,
  `post_image` text NOT NULL,
  `post_content` text NOT NULL,
  `post_category` varchar(244) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `posts`
--

INSERT INTO `posts` (`post_id`, `post_tags`, `post_comment_count`, `post_status`, `post_category_id`, `post_title`, `post_author`, `post_date`, `post_image`, `post_content`, `post_category`) VALUES
(4, 'ferrary2', 4, 'cabrio', 6, 'Luizi from Brooklyng pkEdit2', 'Edwin Diaz and Ganesh pkEdit2', '2004-07-18', 'Audi-RSQ-Concept-001.jpg', 'hdashdhasd hdashdbhashdas hdashdhas  pkEdit2', ''),
(8, 'heavyin', 4, 'draft and published', 6, 'War Industry ', 'Lazoooko Vido', '2018-07-02', 'Audi-PikesPeak-011.jpg', 'dasdsd  fsdfdfdfdfdfdf', 'cars'),
(9, 'heavyin', 4, 'underre', 6, 'Cars and girls', 'Sammm', '2018-07-02', 'Chrysler-ME412-001.jpg', 'test mest barabest', 'Plovdiv'),
(10, 'heavyin', 4, 'publish', 6, 'Angi from UK', 'Asen Lozanov', '2018-07-02', 'Audi-RSQ-Concept-003.jpg', 'This is a blog ', 'Jeep'),
(11, 'cabrio', 4, 'publish', 6, 'Pernik ', 'Adam Smith', '2018-07-04', 'Audi-PikesPeak-010.jpg', 'sdfsdfsdfsdfsdf', 'Cabrio');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(10) NOT NULL,
  `username` varchar(255) NOT NULL,
  `user_password` varchar(255) NOT NULL,
  `user_firstname` varchar(255) NOT NULL,
  `user_lastname` varchar(255) NOT NULL,
  `email` varchar(255) NOT NULL,
  `user_image` text NOT NULL,
  `role` varchar(255) NOT NULL,
  `randSalt` varchar(255) NOT NULL,
  `user_registered_on` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `username`, `user_password`, `user_firstname`, `user_lastname`, `email`, `user_image`, `role`, `randSalt`, `user_registered_on`) VALUES
(1, 'rico', '123', 'rico', 'slave', 'slave@mail.bg', '', 'admin', '', '0000-00-00'),
(4, 'aser', 'calistra', 'Asen', 'Lozanov', 'asen@mail.bg', '65bd6a86fe2d4e3691231cc1e87d4ac1.jpg', 'an user', '', '2018-07-04'),
(7, 'kIm', 'kim', 'Kim', 'UmJong', 'kim@mail.bg', '', 'an user', '', '2018-07-04'),
(8, 'user1', 'calistra', 'Asen', 'Yordanov', 'yor@mail.bg', '', 'an user', '', '2018-07-05');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`admin_id`);

--
-- Indexes for table `categories`
--
ALTER TABLE `categories`
  ADD PRIMARY KEY (`cat_id`);

--
-- Indexes for table `comments`
--
ALTER TABLE `comments`
  ADD PRIMARY KEY (`comment_id`);

--
-- Indexes for table `photoalbum`
--
ALTER TABLE `photoalbum`
  ADD PRIMARY KEY (`photo_id`);

--
-- Indexes for table `posts`
--
ALTER TABLE `posts`
  ADD PRIMARY KEY (`post_id`);

--
-- Indexes for table `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `admin`
--
ALTER TABLE `admin`
  MODIFY `admin_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `categories`
--
ALTER TABLE `categories`
  MODIFY `cat_id` int(12) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;
--
-- AUTO_INCREMENT for table `comments`
--
ALTER TABLE `comments`
  MODIFY `comment_id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=25;
--
-- AUTO_INCREMENT for table `photoalbum`
--
ALTER TABLE `photoalbum`
  MODIFY `photo_id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT for table `posts`
--
ALTER TABLE `posts`
  MODIFY `post_id` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=12;
--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
