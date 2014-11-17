CREATE TABLE user 
(
	userId int(11) AUTO_INCREMENT not null,
	email varchar(50),
	username varchar(25),
	password varchar(100),
	xp int,
	wins int,
	losses int,
	lastContacted ?,
	name varchar(25),
	PRIMARY KEY (userid)
);


CREATE TABLE Game
(
	gameid INT(11)  AUTO_INCREMENT NOT NULL,
	satarted TIMESTAMP,
	started TIMESTAMP,
	ended TIMESTAMP,
	state int,
	name varchar(25),
	gamepassword int,
	PRIMARY KEY (gameId) 
);


CREATE TABLE hand 
(
	handId INT(11)  AUTO_INCREMENT NOT NULL,
	pawn1 VARCHAR(3),
	pawn2 VARCHAR(3),
	pawn3 VARCHAR(3),
	pawn4 VARCHAR(3),
	pawn5 VARCHAR(3),
	pawn6 VARCHAR(3),
	pawn7 VARCHAR(3),
	rook1 VARCHAR(3),
	rook2 VARCHAR(3),
	queen VARCHAR(3),
	bishop1 VARCHAR(3),
	bishop2 VARCHAR(3),
	knight1 VARCHAR(3),
	knight2 VARCHAR(3),
	king VARCHAR(3),
	king VARCHAR(3),
	gameId INT(11) NOT NULL,
	PRIMARY KEY (handId) 
	FOREIGN KEY (gameId) REFERENCES Game (gameId)
);


CREATE TABLE Plays 
(	
	userId INT(11)  AUTO_INCREMENT NOT NULL,
	gameId INT(11) NOT NULL,
	PRIMARY KEY (userId,  gameId)  ,
	FOREIGN KEY (userId) REFERENCES user (userId),
	FOREIGN KEY (gameId) REFERENCES Game (gameId)
);
