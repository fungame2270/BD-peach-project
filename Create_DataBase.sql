USE [master];
DROP DATABASE IF EXISTS peachProject
CREATE DATABASE peachProject
go

USE peachProject;
go

CREATE TABLE LOJA (
	id				INT,
	email			VARCHAR(64),
	[name]          VARCHAR(64)		NOT NULL,
	[address]		VARCHAR(64),
	phone			VARCHAR(9)		NOT NULL,
	nif				INT,
	PRIMARY KEY (id)
	);

CREATE TABLE VENDA (
	id				INT,
	[state]			VARCHAR(7)		NOT NULL	CHECK([state] IN('PAGO','CREDITO'))	DEFAULT 'CREDITO',
	[date]			DATE			NOT NULL,
	store			INT				NOT NULL,
	PRIMARY KEY (id),
	FOREIGN KEY (store) REFERENCES LOJA(id),
	);

CREATE TABLE RESERVA (
	id				INT,
	[date]			DATE			NOT NULL,
	store			INT				NOT NULL,
	PRIMARY KEY (id),
	FOREIGN KEY (store) REFERENCES LOJA(id),
	);

CREATE TABLE FITOFARMACEUTICOS (
	id				INT,
	[name]			VARCHAR(64)		NOT NULL,
	interval_days	INT,
	PRIMARY KEY (id),
	);

CREATE TABLE VARIEDADE (
	code			INT,
	[name]			VARCHAR(64)		NOT NULL,
	season			DATE			NOT NULL,
	trees			INT				NOT NULL,
	PRIMARY KEY (code),
	);

CREATE TABLE CURAS (
	fitofarmaceutic	INT,
	variety			INT,
	[dateH]			SMALLDATETIME	NOT NULL,
	FOREIGN KEY (fitofarmaceutic) REFERENCES FITOFARMACEUTICOS(id),
	FOREIGN KEY (variety) REFERENCES VARIEDADE(code),
	PRIMARY KEY (fitofarmaceutic,variety),
	);

CREATE TABLE TIPODECAIXA (
	code			INT,
	size			VARCHAR(6)    	NOT NULL    CHECK(size IN('SMALL','MEDIUM','BIG'))	DEFAULT 'MEDIUM',
	[availability]	INT				NOT NULL	CHECK([availability] >= 0),
	pricekg			DECIMAL(4,2)	NOT NULL	CHECK(pricekg >= 0),
	FOREIGN KEY (code) REFERENCES VARIEDADE(code),
	PRIMARY KEY (code,size),
	);

CREATE TABLE TIPOCAIXARESERVA (
	reservation		INT,
	code			INT,
	size			VARCHAR(6),
	quantity		INT				NOT NULL,
	FOREIGN KEY (code,size) REFERENCES TIPODECAIXA(code,size),
	PRIMARY KEY (reservation,code,size),
	);

CREATE TABLE CAIXA (
	sale			INT,
	[id]			INT,
	[weight]		DECIMAL(4,2)	NOT NULL	CHECK([weight] > 0),
	code			INT				NOT NULL,
	size			VARCHAR(6)		NOT NULL,
	FOREIGN KEY (sale) REFERENCES VENDA([id]),
	FOREIGN KEY (code,size) REFERENCES TIPODECAIXA(code,size),
	PRIMARY KEY (sale,[id]),
	);





