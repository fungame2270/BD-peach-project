USE peachProject
GO


-- lista de vendas
SELECT * FROM VENDA;

-- lista de vendas que ainda nao foram pagas e preco
SELECT VENDA.id, SUM(CAIXA.[weight]*TIPODECAIXA.pricekg)
FROM VENDA JOIN CAIXA on VENDA.id = CAIXA.sale
		   JOIN TIPODECAIXA on TIPODECAIXA.code = CAIXA.code AND TIPODECAIXA.size = CAIXA.size
GROUP by VENDA.id

-- obter o nome da loja e os tipos de caixas reservados e sua quantidade de uma reserva
SELECT L.name AS nome_loja,V.[name], TD.size, TR.quantity
FROM RESERVA AS R
JOIN LOJA AS L ON R.store = L.id
JOIN TIPOCAIXARESERVA AS TR ON R.id = TR.reservation
JOIN TIPODECAIXA AS TD ON TR.code = TD.code AND TR.size = TD.size
JOIN VARIEDADE AS V ON TD.code = V.code

-- as caixas de uma venda de uma loja bem como a sua variedade e tamanho e preco

SELECT L.[name],VR.[name],C.size, C.[weight], V.[state], (C.[weight]*TP.pricekg) AS price
FROM CAIXA AS C
JOIN VENDA AS V ON C.sale = V.id
JOIN LOJA  AS L ON L.id = V.store
JOIN TIPODECAIXA AS TP ON C.code = TP.code AND C.size = TP.size
JOIN VARIEDADE AS VR ON C.code = VR.code

-- lista das lojas na base de dados
SELECT [name],phone  FROM LOJA;


-- obter reservas e o nome das lojas que fizeram para uma data
SELECT R.*, L.name AS nome_loja
FROM RESERVA AS R
JOIN LOJA AS L ON R.store = L.id
WHERE R.date = '2023-8-15';

-----------------------------------------------------------------

--obter TIPOcaixas que nao estao sobre regime de espera devido ao uso de fitofarmaceuticos
SELECT C.* FROM CAIXA AS C
LEFT JOIN CURAS AS CU ON C.code = CU.variety
WHERE CU.fitofarmaceutic IS NULL;

-- obter tipo caixas que estao sobre regime de espera devido ao uso de fitofarmaceuticos
SELECT C.*
FROM TIPODECAIXA AS TC
JOIN CURAS AS CU ON C.code = CU.variety
WHERE CU.fitofarmaceutic IS NOT NULL;

-- obter curas aplicadas numa data, numa variedade
SELECT F.name AS nome_fitofarmaceutico, V.name AS nome_variedade, C.dateH
FROM CURAS AS C
JOIN FITOFARMACEUTICOS AS F ON C.fitofarmaceutic = F.id
JOIN VARIEDADE AS V ON C.variety = V.code
WHERE C.dateH = '2023-6-15' AND V.name = 'nome_variedade';

-- obeter epoca dos tipos de caixa
SELECT TD.code, TD.size, V.season
FROM TIPODECAIXA AS TD
JOIN VARIEDADE AS V ON TD.code = V.code;

-- obter os fitofarmaceutiocos usados nos tipos de caixa
SELECT FF.name AS nome_fitofarmaceutico, TD.code, TD.size
FROM FITOFARMACEUTICOS AS FF
JOIN TIPODECAIXA AS TD ON FF.id = TD.fitofarmaceutic;

-- obter fitofarmaceuticos ainda nao usados
SELECT FF.*
FROM FITOFARMACEUTICOS AS FF
LEFT JOIN TIPODECAIXA AS TD ON FF.id = TD.fitofarmaceutic
WHERE TD.fitofarmaceutic IS NULL;


-- obeter quatidade vendidada de cada tipo de caixa
SELECT code, size, COUNT(*) AS quantidade_vendida
FROM CAIXA
GROUP BY code, size;


-- obeter n de vendas para cada loja
SELECT L.name AS nome_loja, COUNT(*) AS numero_vendas
FROM VENDA AS V
JOIN LOJA AS L ON V.store = L.id
GROUP BY L.name;

-- obeter n de reservas de cada loja
SELECT L.name AS nome_loja, COUNT(*) AS numero_reservas
FROM RESERVA AS R
JOIN LOJA AS L ON R.store = L.id
GROUP BY L.name;













