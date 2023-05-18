USE peachProject
GO

INSERT INTO LOJA (id, email, [name], [address], phone, nif) VALUES
	(1,NULL,'Adega Casal do Av�','R. Direita 55, 2080-329','918393469',NULL),
	(2,NULL,'Mercado Aguiar','R. 16 de Abril 74, 2005-337 Santar�m','918772704',NULL),
	(3,NULL,'Minimercado Cabacinha','R. Antonio Sergio 4, 2080 Almeirim','961882046',NULL),
	(4,NULL,'Cantinho Da Tradi�ao','Avenida Dom Jo�o I II n� 24, 2080-014 Almeirim','939306744',NULL),
	(5,NULL,'Frutaria Da Clara','N3 37, 2005-464 Santar�m','918902720',NULL),
	(6,NULL,'Frutaria Disfruta','R. Pedro de Santar�m 35, 2000-241 Santar�m','916369107',NULL),
	(7,NULL,'Frutaria De Santar�m','R. Soeiro Pereira Gomes 9, 2000-209 Santar�m','962104093',NULL),
	(8,NULL,'Girassol','Avenida D. Jo�o l ,lote17, R/C esq, 2080-014 Almeirim','910003492',NULL),
	(9,NULL,'Isabel Barraca Carmo','N118, Alpiar�a wood','964408634',NULL),
	(10,NULL,'Casa Lusitana','Av. Dom Afonso Henriques n.�71, 2000-231 Santar�m','914842816',NULL),
	(11,NULL,'Maria Do Albertino','R. Dr. Jo�o C�sar Henriques 6, Almeirim','243592179',NULL),
	(12,NULL,'Mini Mercado Marecos','Rua Condessa da Junqueira 20, 2080-069 Almeirim','962552755',NULL),
	(13,NULL,'Merciaria Da Joaquina Fernandes Marques','Largo Manuel Rodrigues Pisco 26A, 2080-041 Almeirim','926771238',NULL),
	(14,NULL,'Merciaria Tia Ana','R. Guerra Junqueiro 73 75, 2080-103 Almeirim','917677993',NULL),
	(15,NULL,'Mostra Requinte','Praceta Cap. Varela Santos 4, 2000-016 Santar�m','969278993',NULL),
	(16,NULL,'Pomar De Almeirim','Edif�cio Sintra d Inverno, Av. 25 de Abril, 2080-012 Almeirim','915310809',NULL),
	(17,NULL,'Gertrudes - Amanhecer','R. Arco Moniz 22, 2000-564 Santar�m','929184848',NULL),
	(18,NULL,'Sabor Das Marias','R. de Oliven�a 17 A, 2000-222 Santar�m','918724001',NULL),
	(19,NULL,'Sabores Da Terra','R. de Alpiar�a n77, 2080-091 Almeirim','962893715',NULL),
	(20,NULL,'Merciaria Do Sacapeito','Av. Me. Andaluz n�14a, 2000-212 Santar�m','917757051',NULL),
	(21,NULL,'Mini Tapada','R. da Escola Prim�ria 2, Almeirim','915628308',NULL),
	(22,NULL,'Mini Teresa Rego','R. Vale de Salmeirim 27, Santar�m','914802278',NULL);

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


