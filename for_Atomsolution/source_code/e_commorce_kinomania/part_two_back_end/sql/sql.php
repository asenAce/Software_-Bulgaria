


ALTER TABLE `new_movies` ADD `movie_dvd_img` VARCHAR(244) NOT NULL AFTER `movie_post_img`, ADD `movie_trailer` VARCHAR(244) NOT NULL AFTER `movie_dvd_img`, ADD `movie_year` INT(100) NOT NULL AFTER `movie_trailer`, ADD `movie_rating` INT(100) NOT NULL AFTER `movie_year`, ADD `movie_director` VARCHAR(244) NOT NULL AFTER `movie_rating`, ADD `movie_price` INT(100) NOT NULL AFTER `movie_director`;