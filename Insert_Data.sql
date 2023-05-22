USE peachProject
GO

INSERT INTO LOJA (id, email, [name], [address], phone, nif) VALUES
	(1,'AdegaDoAvo@gmail.com','Adega Casal do Av�','R. Direita 55, 2080-329','918393469',753876209),
	(2,'AguiarMer@gmail.com','Mercado Aguiar','R. 16 de Abril 74, 2005-337 Santar�m','918772704',193526987),
	(3,NULL,'Minimercado Cabacinha','R. Antonio Sergio 4, 2080 Almeirim','961882046',294862916),
	(4,'CantinhoDaTradicao@gmail.com','Cantinho Da Tradi�ao','Avenida Dom Jo�o I II n� 24, 2080-014 Almeirim','939306744',245098367),
	(5,'FrutariaDaClara@gmail.com','Frutaria Da Clara','N3 37, 2005-464 Santar�m','918902720',NULL),
	(6,'Disfruta@gmail.com','Frutaria Disfruta','R. Pedro de Santar�m 35, 2000-241 Santar�m','916369107',284738593),
	(7,NULL,'Frutaria De Santar�m','R. Soeiro Pereira Gomes 9, 2000-209 Santar�m','962104093',329537685),
	(8,'LojaGirassol@gmail.com','Girassol','Avenida D. Jo�o l ,lote17, R/C esq, 2080-014 Almeirim','910003492',58360283),
	(9,NULL,'Isabel Barraca Carmo','N118, Alpiar�a wood','964408634',285925643),
	(10,'c.lusitana@gmail.com','Casa Lusitana','Av. Dom Afonso Henriques n.�71, 2000-231 Santar�m','914842816',375839273),
	(11,'m.albertino@gmail.com','Maria Do Albertino','R. Dr. Jo�o C�sar Henriques 6, Almeirim','243592179',384756836),
	(12,'marecos@gmail.com','Mini Mercado Marecos','Rua Condessa da Junqueira 20, 2080-069 Almeirim','962552755',NULL),
	(13,NULL,'Merciaria Da Joaquina Fernandes Marques','Largo Manuel Rodrigues Pisco 26A, 2080-041 Almeirim','926771238',235837294),
	(14,'mtAna@gmail.com','Merciaria Tia Ana','R. Guerra Junqueiro 73 75, 2080-103 Almeirim','917677993',395867502),
	(15,'Mostra.requinte@gmail.com','Mostra Requinte','Praceta Cap. Varela Santos 4, 2000-016 Santar�m','969278993',904727648),
	(16,'p.almeirim@gmail.com','Pomar De Almeirim','Edif�cio Sintra d Inverno, Av. 25 de Abril, 2080-012 Almeirim','915310809',147678938),
	(17,'gertrudes.amanhecer@gmail.com','Gertrudes - Amanhecer','R. Arco Moniz 22, 2000-564 Santar�m','929184848',NULL),
	(18,NULL,'Sabor Das Marias','R. de Oliven�a 17 A, 2000-222 Santar�m','918724001',109375836),
	(19,NULL,'Sabores Da Terra','R. de Alpiar�a n77, 2080-091 Almeirim','962893715',589480328),
	(20,'merciaria.sacapeito@gmail.com','Merciaria Do Sacapeito','Av. Me. Andaluz n�14a, 2000-212 Santar�m','917757051',873962478),
	(21,'m.tapada@gmail.com','Mini Tapada','R. da Escola Prim�ria 2, Almeirim','915628308',298476784),
	(22,NULL,'Mini Teresa Rego','R. Vale de Salmeirim 27, Santar�m','914802278',987786371);

INSERT INTO [LOGIN] (username,[password],store) VALUES
	('adega_Casal','teste123',1),
	('Girassol','teste123',8),
	('adm','adm123',NULL);

INSERT INTO VARIEDADE (code,[name],season,trees) VALUES
	(1,'Latas Parta Caro�o','2023/8/15',43),
	(2,'Brancos Amarelos','2023/7/11',60),
	(3,'Maracotao Amarelo','2023/7/11',5),
	(4,'Parta Caro�o','2023/7/11',38),
	(5,'Royal Gloria','2023/7/11',70),
	(6,'SpringCrest','2023/6/25',17),
	(7,'Maracotao Amarelo Bico','2023/8/15',24),
	(8,'Merril','2023/6/15',32),
	(9,'Nectarinas','2023/6/30',5);

INSERT INTO TIPODECAIXA(code,size,[availability],pricekg) VALUES
	(1,'SMALL',0,2.99),
	(1,'MEDIUM',0,3.99),
	(1,'BIG',0,4.99),
	(2,'SMALL',0,2.99),
	(2,'MEDIUM',0,3.99),
	(2,'BIG',0,4.99),
	(3,'SMALL',0,2.99),
	(3,'MEDIUM',0,3.99),
	(3,'BIG',0,4.99),
	(4,'SMALL',0,2.99),
	(4,'MEDIUM',0,3.99),
	(4,'BIG',0,4.99),
	(5,'SMALL',0,2.99),
	(5,'MEDIUM',0,3.99),
	(5,'BIG',0,4.99),
	(6,'SMALL',0,2.99),
	(6,'MEDIUM',0,3.99),
	(6,'BIG',0,4.99),
	(7,'SMALL',0,2.99),
	(7,'MEDIUM',0,3.99),
	(7,'BIG',0,4.99),
	(8,'SMALL',0,2.99),
	(8,'MEDIUM',0,3.99),
	(8,'BIG',0,4.99),
	(9,'SMALL',0,2.99),
	(9,'MEDIUM',0,3.99),
	(9,'BIG',0,4.99);

INSERT INTO FITOFARMACEUTICOS(id,[name],interval_days) VALUES
	(1,'Frutop 25 EW',20),
	(2,'Glifotop Ultra',20),
	(3,'Cobre',5),
	(4,'Glifosato',0),
	(5,'Mancozebe',3);

INSERT INTO CURAS(fitofarmaceutic,variety,[dateH]) VALUES
	(1,5,'2023/05/16 16:30:00'),
	(3,7,'2023/04/10 15:31:00'),
	(5,4,'2023/04/06 09:15:00');

INSERT INTO RESERVA(id,[date],store) VALUES 
	(1,'2023/05/20',19),
	(2,'2023/05/18',15);

INSERT INTO TIPOCAIXARESERVA(reservation,code,size,quantity) VALUES
	(1,7,'BIG',2),
	(1,5,'BIG',1),
	(1,8,'MEDIUM',1),
	(1,9,'SMALL',1),
	(2,2,'MEDIUM',2),
	(2,7,'BIG',1),
	(2,5,'BIG',1),
	(2,8,'MEDIUM',2);

INSERT INTO VENDA(id,[state],[date],store) VALUES
	(1,'CREDITO','2023/04/30',10),
	(2,'PAGO','2023/04/30',18),
	(3,'CREDITO','2023/04/30',2),
	(4,'PAGO','2023/04/30',3);

INSERT INTO CAIXA(sale,[id],[weight],[code],[size]) VALUES
	(1, 1, 7.2, 8, 'BIG'),
	(1, 2, 9.8, 7, 'SMALL'),
	(2, 1, 7.5, 8, 'MEDIUM'),
	(2, 2, 9.7, 7, 'SMALL'),
	(3, 1, 8.5, 3, 'MEDIUM'),
	(3, 2, 7.7, 2, 'SMALL'),
	(4, 1, 6.2, 6, 'MEDIUM'),
	(4, 2, 7.1, 4, 'SMALL');