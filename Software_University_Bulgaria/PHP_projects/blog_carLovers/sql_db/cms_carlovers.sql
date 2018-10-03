-- phpMyAdmin SQL Dump
-- version 4.7.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 03, 2018 at 03:35 PM
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
-- Table structure for table `admin`
--

CREATE TABLE `admin` (
  `admin_id` int(100) NOT NULL,
  `admin_username` varchar(244) NOT NULL,
  `admin_password` varchar(244) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `admin`
--

INSERT INTO `admin` (`admin_id`, `admin_username`, `admin_password`) VALUES
(1, 'rico', 'pazar'),
(3, 'house', 'music');

-- --------------------------------------------------------

--
-- Table structure for table `categories`
--

CREATE TABLE `categories` (
  `cat_id` int(100) NOT NULL,
  `cat_title` varchar(244) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `categories`
--

INSERT INTO `categories` (`cat_id`, `cat_title`) VALUES
(5, 'Racing'),
(6, 'Luxury'),
(7, 'Jeep');

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

-- --------------------------------------------------------

--
-- Table structure for table `posts`
--

CREATE TABLE `posts` (
  `post_id` int(100) NOT NULL,
  `post_tags` varchar(244) NOT NULL,
  `post_comment_count` int(100) NOT NULL,
  `post_status` varchar(244) NOT NULL,
  `post_category_id` int(100) NOT NULL,
  `post_title` varchar(244) NOT NULL,
  `post_author` varchar(244) NOT NULL,
  `post_date` date NOT NULL,
  `post_image` varchar(244) NOT NULL,
  `post_content` text NOT NULL,
  `post_category` varchar(244) NOT NULL,
  `post_link` varchar(244) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `posts`
--

INSERT INTO `posts` (`post_id`, `post_tags`, `post_comment_count`, `post_status`, `post_category_id`, `post_title`, `post_author`, `post_date`, `post_image`, `post_content`, `post_category`, `post_link`) VALUES
(9, 'luxur', 0, 'published', 6, '2019 Mercedes-Benz A 220', 'Adam Smith', '2024-09-18', '01-2019-mercedes-benz-a-220-fd.jpg', '                    	Mercedes-Benz has repeatedly had to relearn a simple lesson: An air of European sophistication doesnt make a car sold overseas play in America. The circa 2001 C-Class hatchback was a poor fit, but the GLA and CLA have since then come closer to the right formula for both sides of the Atlantic. The new A-Class, coming to our shores as an A 220 sedan, is even better suited to our tastes.\r\n\r\nNote that this isnt a CLA replacement. The CLA is a \"four-door coupe\", and the A is a proper sedan. Theyre certainly similar â€“ two front-drive-based four-doors below the C-Class â€“ but the CLA will soldier along for a bit, analogous to the CLS and E-Class situation. So Mercedes says. The new, sharp lines of the A-Class and the age of the CLA, which debuted in 2013, cant be discounted.\r\n\r\nActually, the styling is smooth and clean; a couple of character creases, but everything else is an exercise in reduction. Theres a more conventional pertness to the rear, a short overhang without the droop present in the bigger C-Class. Contrast the more unusual proportions of the CLA with the As smaller, more angular headlights set more flushly into a handsomely upright fascia. Less is more, we think.\r\n                    ', 'Luxury', 'https://www.youtube.com/watch?v=7xtm9FXmEoY'),
(10, 'racing', 0, 'published', 6, 'John Cena Ford GT', 'SVEN GUSTAFSON', '2018-09-24', '2017-ford-gt-john-cena-2-1.jpg', 'The saga of the 2017 Ford GT that was famously and briefly owned by John Cena and subject to a lawsuit from Ford over flipping the car for a profit has become the automotive equivalent of a hot potato, heading once again to the auction block, this time in Dallas at Mecum in October.\r\n\r\nWe last heard about this GT, which is stamped with the VIN number 77 for the year of Cenas birth, last month when the wealthy California farmer who had bought it from Cena put it up for auction. Auctioneer Russo and Steele confirmed the supercar sold for $1.4 million during its Monterey Car Week auction on Aug. 25. Since then, if records are accurate, its third owner has put exactly 1 mile on the odometer, which now reads 626 miles.\r\n\r\nIts not clear what the minimum bid is for the upcoming Dallas auction, which takes place Oct. 3-6. Autoblog left a message Friday with a Mecum spokeswoman.\r\n\r\nFord sued Cena late last year for flipping the car for a profit shortly after he bought it for $466,376.50, citing its clause barring any sale of the first 500 models for two years. The two sides later settled the case for an undisclosed amount.\r\n\r\nThe infamous Liquid Blue GT comes with a mid-mounted twin-turbocharged 3.5-liter EcoBoost V6 rated at 647 horsepower and 550 pound-feet of torque, with a top speed of 216 mph. It has a carbon fiber monocoque with an integrated steel roll cage and an aluminum substructure.\r\n\r\nA Russo and Steele spokesman said the firm had to ensure it was free and clear of any litigation prior to its sale at Monterey last month, so the latest seller might be eager to flip it before that 2-year window expires and the other Ford GTs begin hitting the market.\r\n', 'Racing', 'https://www.youtube.com/watch?v=wJhEK0E8E4Q'),
(12, 'jeep', 0, 'published', 6, '2019 Ram Rebel 12 is luxurious off-road truck', 'ZAC PALMER', '2018-09-24', 'rebel-12-front-three-quarter-2.jpg', 'When Ram came out with the totally redone 1500 pickup this year, the off-road-leaning Rebel didnt have Rams giant 12-inch touchscreen as an option. Ram is remedying that omission with a new model called the Rebel 12. Yeah, its pretty weird to name the car after the size of the infotainment screen, but thats what Ram came up with.\r\n\r\nThe new model is more than just a screen, though. Ram is using it to throw in a few different tech and luxury options that we dont see in the more barebones Rebel. For one, it gets a 19-speaker, 900-watt Harman Kardon sound system with metal speaker grilles. Youll also get leather seats all around, and theyre heated up front. So what will all this cost you? The Rebel 12 starts at $48,685, including destination charges â€” about $3,000 more than the base Rebel.\r\n\r\nThat price gets you everything mentioned above and all the cool Rebel stuff including a lift kit, locking rear differential, Bilstein shocks, 33-inch tires and the tough-looking appearance features. Keep in mind that this base price is still only the V6 with rear-wheel drive. You can send it far higher when you start tacking on desirable options like the Hemi V8 and four-wheel drive. Ram says the luxurious Rebel 12 will be available in the fourth quarter of 2018.\r\n', 'Jeep', 'https://www.youtube.com/watch?v=xVffiXtXNzI'),
(13, 'racing', 0, 'published', 6, '2020 Lamborghini Huracan Spyder getting Performante looks', 'JOEL STOCKSDALE', '2018-09-24', 'stolen-lamborghini-huracan-spyder-switzerland-0.jpg', 'The Lamborghini HuracÃ¡n has been around since the 2015 model year, and has been pretty much unchanged with the exception of a slightly restyled rear-drive variant. Lamborghini seems to think its about time the HuracÃ¡n was updated, since one of our spy photographers caught a new version in light camouflage out testing. It appears the new model borrows heavily from the HuracÃ¡n Performante.\r\n\r\nUp front, the main grille has pretty much the same set of fins and gills as the ultra-fast HuracÃ¡n. There does appear to be an extra pair of horizontal slats on either side of the middle trapezoidal shape in the grille. Along the side, things are pretty much the same as on any current HuracÃ¡n, but the lower intakes now have little winglets in the middle of the air inlets.\r\n\r\nThe rear of the car is the most noticeably changed. It features two large exhaust tips in the middle of the rear fascia Ã  la the Performante. Theyre also housed in another trapezoidal structure, again like on the top-dog HuracÃ¡n. The rear diffuser is more aggressive than the current model, but not as much as the Performante. There arent any openings behind the rear tires, either, and the air outlets on either side of the exhaust area are new. Theres also a more pronounced duck tail spoiler than on previous models.\r\n\r\nWe arent expecting any earth-shattering changes for this updated HuracÃ¡n. For one thing, the visual changes show that this is mostly the same car underneath. We could see it taking advantage of the stiffer suspension and some the light, molded carbon fiber parts of the Performante to help improve the performance a bit more. The Performantes active aerodynamics will probably stay exclusive to that high-performance model, though. Theres also the fact that completely new versions of the HuracÃ¡n and Aventador are on the horizon, and may pack some huge changes such as hybrid powertrains. As such, Lamborghini is probably just going to try and stretch this model until its time for the new one.\r\n', 'Racing', 'https://www.youtube.com/watch?v=A3cVZZBNV48'),
(14, 'jeep', 0, 'published', 6, '2019 Lincoln Nautilus First Drive Review', 'SCOTT OLDHAM', '2018-09-24', '01-2019-lincoln-nautilus-fd-1.jpg', 'SANTA BARBARA, Calif. â€” Its name is new, but the 2019 Lincoln Nautilus is really a rebranded, restyled and updated version of the second-generation Lincoln MKX, which has been on sale since 2016. Renaming your bestselling vehicle is risky, but Lincoln has been struggling, and it feels the names of its vehicles are partly to blame.\r\n\r\nRecall that since 2007, Fords luxury brand has used letters to name some models, including MKZ and MKX, and traditional names on others like Navigator and Continental. Well, now its ditching the letters and renaming those vehicles. The MKX is now the Nautilus. The smaller MKC is rumored to become the Corsair, which was a name used by Edsel back in the 1950s. The seven-passenger Aviator will go on sale in 2019, and the MKZs new name is anybodys guess. Zephyr again, maybe? NordicTrack is already taken.\r\n\r\nLincoln has also been rolling out a new grille design, which debuted on the Continental in 2017 and replaces the unloved winged look that was supposed to remind luxury buyers of the elegance of the 1939 Lincoln Continental â€” but didnt. Fitting the new grille to the 2019 Nautilus completes that rollout, and the five-passenger SUV is certainly more handsome than before. Its mesh is a repetition of the Lincoln Star logo, and it works. The SUVs front fascia, headlamps and hood are new as well, and the hood has grown a sizable and attractive center peak.\r\n', 'Jeep', '2019 Lincoln Nautilus First Drive Review'),
(15, 'jeep', 0, 'published', 6, '2019 BMW X5 First Drive Review', ' JOHN BELTZ ', '2018-09-27', '01-2019-bmw-x5-fd-1.jpg', 'ATLANTA â€” In the woods outside of Atlanta, we leaned forward in our seat to peer over the nose of a 2019 BMW X5 xDrive40i at a stout German at the bottom of muddy hill. We were waiting for the signal to aim the SUV at him and take our foot off the pedals. This isnt the sort of situation wed imagine many BMW owners to find themselves in. Who cares though? We were having fun.\r\n\r\nAt the Germans beckoning, we eased the front wheels onto the incline, and took our foot completely off the brake as gravity began to do what it always does. We could feel the various systems firing off the brakes in pulses as the all-season Pirelli tires repeatedly lost and regained grip on the muddy slope below.\r\n\r\nAfterward â€” spoiler alert â€” there was no human smear on the X5, but the dirt, dust and grass looked out of place on this shiny luxury crossover. Its clean surfaces are accentuated by a few simple, straight lines. Our tester looked imposing standing on its 21-inch wheels, and 22-inchers are available for the first time. The front fascia is more interesting to look at, with the double kidney grille even more visually dominant than before. In back, the lights are slimmer and the exhaust tips are larger and better visually integrated into the bumper.\r\n', 'Jeep', 'https://www.youtube.com/watch?v=weJs8CsPL_8'),
(16, 'jeep', 0, 'published', 6, 'Jeep Wrangler JK', 'Blog Admin', '2018-09-28', '0002.jpg', 'The new Jeep Wrangler is the compact SUV that is once again turning heads. These are a few exterior features helping the Jeep Wrangler JK stand out.\r\nCheck out the all-terrain tires that comes standard on the Jeep Wrangler JK. These tires are designed to be in a better position to handle any surface in all types of weather conditions. These tires allow the Jeep to power through the snow, ice, or the mud while driving off-road.\r\nThe Jeep Wrangler JK has those classic round headlamps that identify with this brand. These lights do more than look good, they light up the road far ahead with LED technology that is designed to not only keep you safe, but to help other motorists to stay safe.\r\nThe Jeep Wrangler JK is on the lot and you can test drive one today at Merrick Dodge Chrysler Jeep of Wantagh to get a better look at these exterior features.\r\n', 'Jeep', 'https://www.youtube.com/watch?v=51OcTndmNA0'),
(17, 'jeep', 0, 'publish', 6, '2018 Dodge Durango', 'Support Admin', '2018-09-28', '6a58c2995781fb9657c4d047c3cf9762.jpg', 'The 2018 Dodge Durango is the latest incarnation of Dodges powerful, spacious, mid-size SUV. Lets look at what this new vehicle offers consumers, whats new in 2018, and why its a great choice for both hauling (and with the new Durango SRT, real performance driving).\r\n\r\nPowerful engine choices\r\nThree powerful, peppy engines are available to move the 2018 Dodge Durango: a 3.6 liter, 293 HP Pentastar V6, a 5.7 liter 360 HP HEMI V8, and a 6.4 liter 475 HP HEMI V8. Each is mated to an 8-speed automatic transmission; a very large 24.5 gallon fuel tank provides the Durango with extended range between fueling stops. Dodge notes that while there are many SUVs on the road, only the Durango is a true sport utility vehicle. Given its powerful trio of available engines, its hard to argue with that assertion.\r\n\r\nThe Durango comes with 9 available trim options ranging from the base-level SXT (MSRP starting at $29,995) to the performance-optimized SRT (MSRP starting at $62,995). Standard features include 18-inch alloy wheels, electronic stability control, and 4-channel anti-lock brakes.\r\n', 'Jeep', 'https://www.youtube.com/watch?v=NVCkZq5CqdU'),
(18, 'jeep', 0, 'published', 6, 'Diesel Wrangler Confirmed for 2019', 'Nina Ronald', '2018-09-28', 'Wrangler-Diesel-2019-1024x576.jpg', 'Serious Jeepers will be interested to read the latest news: a Jeep Wrangler powered by a diesel-fueled engine is in the works! The current generation Jeep Wrangler is offered in the U.S. with two engine choices â€“ the classic 3.6-liter Pentastar V6 engine or a turbocharged four-pot 2.0-liter engine. Both of these engines are powered by gasoline themselves and sometimes result in the disappointment of consumers who seek a diesel-powered engine instead, especially with the amount of torque that serious off-road Jeepers are looking for. It seems that not all hope is lost â€“ new codes for the 2019 model year are starting to show up in the ordering system for Jeep dealerships. According to many prominent JL Wrangler forums, one of the codes, code 26 to be exact, was confirmed to be the code for a 3.0-liter V6 diesel engine complete with the engine start-stop system (ESS).', 'Jeep', 'https://www.youtube.com/watch?v=dtb_vNpnY28');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE `users` (
  `user_id` int(10) NOT NULL,
  `user_name` varchar(244) NOT NULL,
  `user_password` varchar(244) NOT NULL,
  `users_firstname` varchar(244) NOT NULL,
  `user_lastname` varchar(244) NOT NULL,
  `email` varchar(244) NOT NULL,
  `user_image` text NOT NULL,
  `role` varchar(244) NOT NULL,
  `rand_salt` varchar(244) NOT NULL,
  `user_registered_on` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`user_id`, `user_name`, `user_password`, `users_firstname`, `user_lastname`, `email`, `user_image`, `role`, `rand_salt`, `user_registered_on`) VALUES
(4, 'nicedog', 'dog', 'Thedoggy', 'Pit', 'pitdog@mail.bg', '', 'an user', '', '2018-10-01');

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
  MODIFY `admin_id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
--
-- AUTO_INCREMENT for table `categories`
--
ALTER TABLE `categories`
  MODIFY `cat_id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `comments`
--
ALTER TABLE `comments`
  MODIFY `comment_id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
--
-- AUTO_INCREMENT for table `posts`
--
ALTER TABLE `posts`
  MODIFY `post_id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=19;
--
-- AUTO_INCREMENT for table `users`
--
ALTER TABLE `users`
  MODIFY `user_id` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
