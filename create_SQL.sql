CREATE DATABASE `bhuvani` /*!40100 DEFAULT CHARACTER SET utf8 */;
CREATE TABLE `admin` (
  `admin_id` int(11) NOT NULL AUTO_INCREMENT,
  `email` varchar(45) NOT NULL,
  `emp_no` varchar(10) NOT NULL,
  `password` varchar(45) NOT NULL,
  `type` int(11) DEFAULT NULL,
  PRIMARY KEY (`admin_id`),
  UNIQUE KEY `admin_id_UNIQUE` (`admin_id`),
  UNIQUE KEY `email_UNIQUE` (`email`),
  UNIQUE KEY `emp_no_UNIQUE` (`emp_no`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

CREATE TABLE `cart` (
  `cart_id` int(11) NOT NULL AUTO_INCREMENT,
  `customer_id` int(11) NOT NULL,
  `product_id` int(11) NOT NULL,
  `carted_date` datetime DEFAULT NULL,
  PRIMARY KEY (`cart_id`),
  KEY `product_id_idx` (`product_id`),
  KEY `customer_id_idx` (`customer_id`),
  KEY `cart_customer_idx` (`customer_id`),
  KEY `cart_product_idx` (`product_id`),
  CONSTRAINT `cart_customer` FOREIGN KEY (`customer_id`) REFERENCES `customer` (`customer_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `cart_product` FOREIGN KEY (`product_id`) REFERENCES `product` (`product_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `catagory` (
  `id_catagory` int(11) NOT NULL AUTO_INCREMENT,
  `catagory_name` varchar(45) NOT NULL,
  `users_id` int(11) NOT NULL,
  PRIMARY KEY (`id_catagory`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8;
CREATE TABLE `customer` (
  `customer_id` int(11) NOT NULL AUTO_INCREMENT,
  `customer_name` varchar(45) NOT NULL,
  `address` longtext NOT NULL,
  `mobile1` varchar(12) NOT NULL,
  `mobile2` varchar(12) DEFAULT NULL,
  `distric_id` int(11) NOT NULL,
  `join_date` datetime NOT NULL,
  `email` varchar(45) NOT NULL,
  `password` longtext NOT NULL,
  PRIMARY KEY (`customer_id`),
  KEY `dist_id_idx` (`distric_id`),
  CONSTRAINT `dist_id` FOREIGN KEY (`distric_id`) REFERENCES `district` (`distric_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `district` (
  `distric_id` int(11) NOT NULL AUTO_INCREMENT,
  `dis_name` varchar(45) DEFAULT NULL,
  `dilivery_charge` double NOT NULL,
  PRIMARY KEY (`distric_id`,`dilivery_charge`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `item` (
  `item_id` int(11) NOT NULL AUTO_INCREMENT,
  `product_id` int(11) NOT NULL,
  `order_id` int(11) DEFAULT NULL,
  `stock_id` int(11) NOT NULL,
  `availability` int(1) DEFAULT NULL,
  PRIMARY KEY (`item_id`),
  KEY `product_id_idx` (`product_id`),
  KEY `order_id_for_item_idx` (`order_id`),
  KEY `stocks_id_idx` (`stock_id`),
  CONSTRAINT `product_id` FOREIGN KEY (`product_id`) REFERENCES `product` (`product_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `stocks_id` FOREIGN KEY (`stock_id`) REFERENCES `stocks` (`stock_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `orders` (
  `id_orders` int(11) NOT NULL AUTO_INCREMENT,
  `customer_id` int(11) NOT NULL,
  `distric_id` int(11) NOT NULL,
  `order_recive_date` date NOT NULL,
  `product_id` int(11) NOT NULL,
  `qunity` int(11) NOT NULL,
  `deliver_trace` int(1) NOT NULL COMMENT 'tracing delivery: if deliver_trace=0 is processing deliver_trace=1 deliverd\n',
  `handover_date` date DEFAULT NULL,
  `delived_date` datetime DEFAULT NULL,
  `reciver_address` longtext NOT NULL,
  `delivery_charge` double NOT NULL,
  `total` double NOT NULL,
  PRIMARY KEY (`id_orders`),
  KEY `order_customer_idx` (`customer_id`),
  KEY `order_product_idx` (`product_id`),
  KEY `order_dist_id_idx` (`distric_id`),
  CONSTRAINT `order_customer` FOREIGN KEY (`customer_id`) REFERENCES `customer` (`customer_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `order_dist_id` FOREIGN KEY (`distric_id`) REFERENCES `district` (`distric_id`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `order_product` FOREIGN KEY (`product_id`) REFERENCES `product` (`product_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `product` (
  `product_id` int(11) NOT NULL AUTO_INCREMENT,
  `product_name` varchar(45) NOT NULL,
  `user_type_id` int(11) NOT NULL,
  `cat_id` int(11) NOT NULL,
  `image_path` longtext NOT NULL,
  `about` longtext NOT NULL,
  `size` varchar(2) NOT NULL,
  `price` double NOT NULL,
  PRIMARY KEY (`product_id`),
  KEY `gender_id_idx` (`user_type_id`),
  KEY `cat_ids_idx` (`cat_id`),
  CONSTRAINT `cat_ids` FOREIGN KEY (`cat_id`) REFERENCES `catagory` (`id_catagory`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `gender_id` FOREIGN KEY (`user_type_id`) REFERENCES `users_gender` (`gender_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `stocks` (
  `stock_id` int(11) NOT NULL AUTO_INCREMENT,
  `qunity` int(11) NOT NULL,
  `recived_date` date NOT NULL,
  `product_id` int(11) NOT NULL,
  PRIMARY KEY (`stock_id`),
  KEY `product_id_stock_idx` (`product_id`),
  CONSTRAINT `product_id_stock` FOREIGN KEY (`product_id`) REFERENCES `product` (`product_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
CREATE TABLE `users_gender` (
  `gender_id` int(11) NOT NULL AUTO_INCREMENT,
  `gender_name` varchar(45) NOT NULL,
  PRIMARY KEY (`gender_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;
