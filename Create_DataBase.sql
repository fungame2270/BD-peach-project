USE [master];
DROP DATABASE IF EXISTS peachProject
CREATE DATABASE peachProject
go

USE peachProject;
go
CREATE SCHEMA PEACHS;
go

CREATE TABLE PEACHS.LOJA (
	id				INT,
	email			VARCHAR(64)		NOT NULL,
	[name]          VARCHAR(64)		NOT NULL,
	[address]		VARCHAR(64),
	phone			VARCHAR(9)		NOT NULL,
	PRIMARY KEY (id)
	);

CREATE TABLE PEACHS.VENDA (
	id				INT,
	[state]			VARCHAR(20)		NOT NULL,
	[date]			DATE			NOT NULL,
	store			INT				NOT NULL,
	PRIMARY KEY (id),
	FOREIGN KEY (store) REFERENCES PEACHS.LOJA(id),
	);

CREATE TABLE PEACHS.RESERVA (
	id				INT,
	[date]			DATE			NOT NULL,
	store			INT				NOT NULL,
	PRIMARY KEY (id),
	FOREIGN KEY (store) REFERENCES PEACHS.LOJA(id),
	);

CREATE TABLE PEACHS.FITOFARMACEUTICOS (
	id				INT,
	[name]			VARCHAR(64)		NOT NULL,
	interval_time	TIME,
	PRIMARY KEY (id),
	);

CREATE TABLE PEACHS.VARIEDADE (
	code			VARCHAR(4),
	[name]			VARCHAR(64)		NOT NULL,
	season			DATE			NOT NULL,
	trees			INT				NOT NULL,
	[type]			VARCHAR(64),
	PRIMARY KEY (code),
	);

CREATE TABLE PEACHS.CURAS (
	fitofarmaceutic	INT,
	variety			VARCHAR(4),
	[dateh]			SMALLDATETIME	NOT NULL,
	FOREIGN KEY (fitofarmaceutic) REFERENCES PEACHS.FITOFARMACEUTICOS(id),
	FOREIGN KEY (variety) REFERENCES PEACHS.VARIEDADE(code),
	PRIMARY KEY (fitofarmaceutic,variety),
	);

CREATE TABLE PEACHS.TIPODECAIXA (
	code			VARCHAR(4),
	size			VARCHAR(6)     NOT NULL    CHECK(size IN('SMALL','MEDIUM','BIG')) DEFAULT 'MEDIUM',
	[availability]	INT				NOT NULL	CHECK([availability] >= 0),
	pricekg			DECIMAL(4,2)	NOT NULL	CHECK(pricekg >= 0),
	FOREIGN KEY (code) REFERENCES PEACHS.VARIEDADE(code),
	PRIMARY KEY (code,size),
	);

CREATE TABLE PEACHS.TIPOCAIXARESERVA (
	reservation		INT,
	code			VARCHAR(4),
	size			VARCHAR(10),
	FOREIGN KEY (code,size) REFERENCES PEACHS.TIPODECAIXA(code,size),
	PRIMARY KEY (reservation,code,size),
	);

CREATE TABLE PEACHS.CAIXA (
	sale			INT,
	id				INT,
	[weight]		DECIMAL(4,2)	NOT NULL	CHECK([weight] > 0),
	code			VARCHAR(4)		NOT NULL,
	size			VARCHAR(10)		NOT NULL,
	FOREIGN KEY (sale) REFERENCES PEACHS.VENDA(id),
	FOREIGN KEY (code,size) REFERENCES PEACHS.TIPODECAIXA(code,size),
	PRIMARY KEY (sale,id),
	);





