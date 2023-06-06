DROP PROCEDURE IF EXISTS [loginP]
DROP PROCEDURE IF EXISTS getStores
DROP PROCEDURE IF EXISTS getVendas
DROP PROCEDURE IF EXISTS getCaixasOfSale
DROP PROCEDURE IF EXISTS addStore
DROP PROCEDURE IF EXISTS newVenda
DROP PROCEDURE IF EXISTS addToVenda
DROP PROCEDURE IF EXISTS getReservas
DROP PROCEDURE IF EXISTS getTipoCaixasRes
DROP PROCEDURE IF EXISTS getVariedadesCuraState
DROP PROCEDURE IF EXISTS updateVendaState
DROP PROCEDURE IF EXISTS curasNaVariedade
DROP PROCEDURE IF EXISTS getFito




go
CREATE PROCEDURE [loginP] (@username VARCHAR(20),@password VARCHAR(64),@store INT OUTPUT,@IsAdm BIT OUTPUT)
AS
	SELECT @store = store
	FROM [LOGIN]
	WHERE username = @username AND [password] = @password

	IF @store IS NULL
		SET @IsAdm = 1
	ELSE
		SET @IsAdm = 0
go


CREATE PROC getStores
AS
Select * from LOJA
go


CREATE PROC getVendas (@state VARCHAR(7) = NULL ,@store INT = NULL)
AS
IF @state IS NULL AND @store IS NULL
	BEGIN
	SELECT LOJA.[name],VENDA.store,Venda.id, [state],[date],SUM(pricekg*Caixa.[weight]) as price
	FROM VENDA JOIN LOJA ON VENDA.store = LOJA.id 
	JOIN CAIXA on CAIXA.sale = VENDA.id
	JOIN TIPODECAIXA on CAIXA.code = TIPODECAIXA.code AND CAIXA.size = TIPODECAIXA.size
	GROUP BY LOJA.[name],VENDA.store,Venda.id, [state],[date]
	RETURN
	END
IF @store IS NULL
	BEGIN
	SELECT LOJA.[name],VENDA.store,Venda.id, [state],[date],SUM(pricekg*Caixa.[weight]) as price
	FROM VENDA JOIN LOJA ON VENDA.store = LOJA.id 
	JOIN CAIXA on CAIXA.sale = VENDA.id
	JOIN TIPODECAIXA on CAIXA.code = TIPODECAIXA.code AND CAIXA.size = TIPODECAIXA.size
	WHERE VENDA.[state] = @state
	GROUP BY LOJA.[name],VENDA.store,Venda.id, [state],[date]
	RETURN
	END
IF @state IS NULL
	BEGIN
	SELECT LOJA.[name],VENDA.store,Venda.id, [state],[date],SUM(pricekg*Caixa.[weight]) as price
	FROM VENDA JOIN LOJA ON VENDA.store = LOJA.id 
	JOIN CAIXA on CAIXA.sale = VENDA.id
	JOIN TIPODECAIXA on CAIXA.code = TIPODECAIXA.code AND CAIXA.size = TIPODECAIXA.size
	WHERE VENDA.store = @store
	GROUP BY LOJA.[name],VENDA.store,Venda.id, [state],[date]
	RETURN
	END
SELECT LOJA.[name],VENDA.store,Venda.id, [state],[date],SUM(pricekg*Caixa.[weight]) as price
	FROM VENDA JOIN LOJA ON VENDA.store = LOJA.id 
	JOIN CAIXA on CAIXA.sale = VENDA.id
	JOIN TIPODECAIXA on CAIXA.code = TIPODECAIXA.code AND CAIXA.size = TIPODECAIXA.size
	WHERE VENDA.store = @store AND VENDA.[state] = @state 
	GROUP BY LOJA.[name],VENDA.store,Venda.id, [state],[date]

go


CREATE PROC getCaixasOfSale (@venda INT)
AS
SELECT V.id as venda,C.id, VR.[name],C.size, C.[weight], (C.[weight]*TP.pricekg) AS price
FROM CAIXA AS C
JOIN VENDA AS V ON C.sale = V.id
JOIN TIPODECAIXA AS TP ON C.code = TP.code AND C.size = TP.size
JOIN VARIEDADE AS VR ON C.code = VR.code
WHERE V.id = @venda
go


CREATE PROC addStore (@email VARCHAR(64) = NULL,@name VARCHAR(64),@address VARCHAR(64),@phone VARCHAR(9),@nif INT = NULL)
AS
INSERT INTO LOJA (email, [name], [address], phone, nif) VALUES
(@email,@name,@address,@phone,@nif)
go


CREATE PROC newVenda (@state VARCHAR(7),@date DATE,@store INT,@venda INT OUTPUT)
AS
BEGIN
INSERT INTO VENDA ([state],[date],[store]) VALUES
	(@state,@date,@store);

set @venda = SCOPE_IDENTITY()
END
go


CREATE PROC addToVenda(@sale INT,@weigth DECIMAL(4,2),@code INT,@size VARCHAR(6))
AS
INSERT INTO CAIXA(sale,[weight],code,size) VALUES
	(@sale,@weigth,@code,@size);
go


CREATE PROC getReservas(@store INT = NULL)
AS
IF @store IS NULL
BEGIN
SELECT R.id,R.[date],R.store,LOJA.[name],sum(T.quantity) as quantity
FROM RESERVA AS R JOIN LOJA on R.store = LOJA.id JOIN TIPOCAIXARESERVA as T on T.reservation = R.id
Group by  R.id,R.[date],R.store,LOJA.[name]
END
ELSE
BEGIN
SELECT R.id,R.[date],R.store,LOJA.[name],sum(T.quantity) as quantity
FROM RESERVA AS R JOIN LOJA on R.store = LOJA.id JOIN TIPOCAIXARESERVA as T on T.reservation = R.id
WHERE R.store = @store
Group by  R.id,R.[date],R.store,LOJA.[name]
END
go

CREATE PROC getTipoCaixasRes(@reserva INT)
AS
SELECT TCR.reservation, V.code, V.[name] ,TCR.size, TCR.quantity ,TP.pricekg 
FROM TIPOCAIXARESERVA AS TCR JOIN TIPODECAIXA AS TP on TCR.code = TP.code AND TP.size = TCR.size
							 JOIN VARIEDADE AS V on V.code = TCR.code
WHERE TCR.reservation = @reserva 
go


CREATE PROC getVariedadesCuraState
AS
DECLARE @table TABLE (code INT,[name] VARCHAR(64),season DATE,trees INT,disponibilidade VARCHAR(10))
INSERT INTO @table 
SELECT *,''as disponibilidade FROM VARIEDADE
UPDATE @table
SET disponibilidade = 'curado'
WHERE code in (SELECT * FROM getVariedadesComCuraAplicada())
SELECT * from @table
go


CREATE PROC updateVendaState(@id INT,@state VARCHAR(6))
AS
UPDATE VENDA
SET [state] = @state
WHERE id = @id

go
CREATE PROC curasNaVariedade(@id INT)
AS
SELECT fitofarmaceutic,dateH
FROM VARIEDADE JOIN CURAS on VARIEDADE.code = CURAS.variety
WHERE variety = @id
go
CREATE PROC getFito
AS
SELECT * FROM FITOFARMACEUTICOS


---------------------

ALTER PROCEDURE InsertIntoTabela
    @id INT,
    @size VARCHAR(50),
    @quantidade INT,
    @storeName VARCHAR(50)
AS
BEGIN
    INSERT INTO TIPOCAIXARESERVA (id, size, quantidade, storeName)
    VALUES (@id, @size, @quantidade, @storeName)
END

ALTER PROCEDURE help_me
    @store INT
AS
BEGIN
    BEGIN
         SELECT R.id, R.[date],TR.code, TR.size, TR.quantity --TR.code, R.store
		FROM RESERVA AS R
		JOIN TIPOCAIXARESERVA AS TR ON R.store = TR.code
		--WHERE R.store = @store;
    END
END
exec help_me @store=8
exec help_mes @store=8



CREATE TRIGGER VerificarForData
ON TIPOCAIXARESERVA -- Substitua "NomeDaTabela" pelo nome da tabela que deseja verificar
AFTER INSERT, UPDATE
AS
BEGIN
    -- Verificar a coluna de data na tabela inserida
    IF EXISTS (
        SELECT 1
        FROM inserted
        WHERE TBoxData IS NULL OR NOT TBoxData LIKE '[0-9][0-9] / [0-9][0-9] / [0-9][0-9][0-9][0-9]'
    )
    BEGIN
        -- Lançar um erro se a data não estiver no formato desejado
        RAISERROR ('A data deve estar no formato "número número / número número / número número número número".', 16, 1)
        ROLLBACK TRANSACTION
        RETURN
    END
END



Alter PROCEDURE GetStoreNames
AS
BEGIN
    SELECT [name],id FROM LOJA;
END

CREATE PROCEDURE DeleteReserva
    @ReservaId INT
AS
BEGIN
    DELETE FROM RESERVA WHERE id = @ReservaId;
END

CREATE PROCEDURE InsertReservation
    @reservationDate DATE,
    @storeId INT,
    @code INT,
    @size VARCHAR(6),
    @quantity INT
AS
BEGIN
    SET NOCOUNT ON;

    -- Inserir na tabela RESERVA
    INSERT INTO RESERVA ([date], store)
    VALUES (@reservationDate, @storeId);

    -- Inserir na tabela TIPOCAIXARESERVA
    INSERT INTO TIPOCAIXARESERVA (code, size, quantity)
    VALUES (@code, @size, @quantity);
END

exec InsertReservation;

---
CREATE PROCEDURE help_mes
    @store INT
AS
BEGIN
    SELECT DISTINCT R.id, R.[date], TR.code, TR.size, TR.quantity
    FROM RESERVA AS R
    JOIN TIPOCAIXARESERVA AS TR ON R.store = TR.code
    WHERE R.store = @store;
END
exec help_mes @store=8

DROP PROCEDURE IF EXISTS GetStoreHistory;

