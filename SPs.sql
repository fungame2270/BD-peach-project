DROP PROCEDURE IF EXISTS [loginP]
DROP PROCEDURE IF EXISTS getStores
DROP PROCEDURE IF EXISTS getVendas
DROP PROCEDURE IF EXISTS getCaixasOfSale
DROP PROCEDURE IF EXISTS addStore
DROP PROCEDURE IF EXISTS newVenda
DROP PROCEDURE IF EXISTS getReservas
DROP PROCEDURE IF EXISTS getTipoCaixasRes
DROP PROCEDURE IF EXISTS getVariedadesCuraState
DROP PROCEDURE IF EXISTS updateVendaState
DROP PROCEDURE IF EXISTS curasNaVariedade
DROP PROCEDURE IF EXISTS getFito
DROP PROCEDURE IF EXISTS GetStoreNames
DROP PROCEDURE IF EXISTS DeleteReserva
DROP PROCEDURE IF EXISTS getStoreRes
DROP PROCEDURE IF EXISTS GetVariatyNames
DROP PROCEDURE IF EXISTS deleteStore
DROP PROCEDURE IF EXISTS aplicarCura
DROP PROCEDURE IF EXISTS seeAvailability
DROP PROCEDURE IF EXISTS getAvailabilityOf
DROP PROCEDURE IF EXISTS updateAvailabilityOf
DROP PROCEDURE IF EXISTS newReserva
DROP TYPE IF EXISTS dbo.CaixaParamaterSp
DROP TYPE IF EXISTS dbo.TipoCaixaParamaterSp







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
WHERE [disabled] = 0
go


CREATE PROC getVendas (@state VARCHAR(7) = NULL ,@store INT = NULL)
AS
IF @state IS NULL AND @store IS NULL
	BEGIN
	SELECT LOJA.[name],VENDA.store,Venda.id, [state],[date],SUM(pricekg*Caixa.[weight]) as price
	FROM VENDA JOIN LOJA ON VENDA.store = LOJA.id 
	JOIN CAIXA on CAIXA.sale = VENDA.id
	JOIN TIPODECAIXA on CAIXA.code = TIPODECAIXA.code AND CAIXA.size = TIPODECAIXA.size
	WHERE LOJA.[disabled] = 0
	GROUP BY LOJA.[name],VENDA.store,Venda.id, [state],[date]
	RETURN
	END
IF @store IS NULL
	BEGIN
	SELECT LOJA.[name],VENDA.store,Venda.id, [state],[date],SUM(pricekg*Caixa.[weight]) as price
	FROM VENDA JOIN LOJA ON VENDA.store = LOJA.id 
	JOIN CAIXA on CAIXA.sale = VENDA.id
	JOIN TIPODECAIXA on CAIXA.code = TIPODECAIXA.code AND CAIXA.size = TIPODECAIXA.size
	WHERE VENDA.[state] = @state AND LOJA.[disabled] = 0
	GROUP BY LOJA.[name],VENDA.store,Venda.id, [state],[date]
	RETURN
	END
IF @state IS NULL
	BEGIN
	SELECT LOJA.[name],VENDA.store,Venda.id, [state],[date],SUM(pricekg*Caixa.[weight]) as price
	FROM VENDA JOIN LOJA ON VENDA.store = LOJA.id 
	JOIN CAIXA on CAIXA.sale = VENDA.id
	JOIN TIPODECAIXA on CAIXA.code = TIPODECAIXA.code AND CAIXA.size = TIPODECAIXA.size
	WHERE VENDA.store = @store AND LOJA.[disabled] = 0
	GROUP BY LOJA.[name],VENDA.store,Venda.id, [state],[date]
	RETURN
	END
SELECT LOJA.[name],VENDA.store,Venda.id, [state],[date],SUM(pricekg*Caixa.[weight]) as price
	FROM VENDA JOIN LOJA ON VENDA.store = LOJA.id 
	JOIN CAIXA on CAIXA.sale = VENDA.id
	JOIN TIPODECAIXA on CAIXA.code = TIPODECAIXA.code AND CAIXA.size = TIPODECAIXA.size
	WHERE VENDA.store = @store AND VENDA.[state] = @state AND LOJA.[disabled] = 0
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


CREATE TYPE CaixaParamaterSp AS TABLE(
[weight]	DECIMAL(4,2),
code		INT,
size		VARCHAR(6)
);
go
CREATE PROC newVenda(@state VARCHAR(7),@date DATE,@store INT,@caixas dbo.CaixaParamaterSp READONLY)
AS
BEGIN
	BEGIN TRANSACTION
	SAVE TRANSACTION SavePoint;
	BEGIN TRY
		INSERT INTO VENDA ([state],[date],[store]) VALUES
		(@state,@date,@store);

		declare @venda INT = SCOPE_IDENTITY()

		INSERT INTO CAIXA(sale,[weight],code,size)
		SELECT @venda,* FROM @caixas
		COMMIT TRANSACTION 
	END TRY
	BEGIN CATCH
        IF @@TRANCOUNT > 0
        BEGIN
            ROLLBACK TRANSACTION SavePoint;
        END
    END CATCH
END
go

CREATE TYPE TipoCaixaParamaterSp AS TABLE(
code		INT,
size		VARCHAR(6),
qty			INT
);
go

CREATE PROC newReserva(@date DATE,@store INT,@caixas dbo.TipoCaixaParamaterSp READONLY)
AS
BEGIN
	BEGIN TRANSACTION
	SAVE TRANSACTION SavePoint;
	BEGIN TRY
		INSERT INTO RESERVA([date],[store]) VALUES
		(@date,@store);

		declare @res INT = SCOPE_IDENTITY()

		INSERT INTO TIPOCAIXARESERVA(reservation,code,size,quantity)
		SELECT @res,* FROM @caixas
		COMMIT TRANSACTION 
	END TRY
	BEGIN CATCH
        IF @@TRANCOUNT > 0
        BEGIN
            ROLLBACK TRANSACTION SavePoint;
        END
    END CATCH
END



go
CREATE PROC getReservas(@store INT = NULL)
AS
IF @store IS NULL
BEGIN
SELECT R.id,R.[date],R.store,LOJA.[name],sum(T.quantity) as quantity
FROM RESERVA AS R JOIN LOJA on R.store = LOJA.id JOIN TIPOCAIXARESERVA as T on T.reservation = R.id
WHERE LOJA.[disabled] = 0
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
go

CREATE PROCEDURE getStoreRes @store INT
AS
BEGIN
    IF @store IS NULL
    BEGIN
        PRINT 'Store ID not provided';
        RETURN;
    END
    BEGIN
        SELECT R.id, R.[date], R.store,TR.code, TR.size, TR.quantity
		FROM RESERVA AS R JOIN TIPOCAIXARESERVA AS TR ON R.store = TR.code
		WHERE R.store = @store;
    END
    
    
END
go

CREATE PROCEDURE GetStoreNames
AS
BEGIN
    SELECT [name],id 
	FROM LOJA
	WHERE LOJA.[disabled] = 0
END
go

CREATE PROCEDURE GetVariatyNames
AS
BEGIN
    SELECT [name],code FROM VARIEDADE;
END
go

CREATE PROCEDURE DeleteReserva
    @ReservaId INT
AS
BEGIN
    DELETE FROM RESERVA WHERE id = @ReservaId;
	DELETE FROM TIPOCAIXARESERVA WHERE reservation = @ReservaId;
END
go

CREATE PROC deleteStore(@id INT)
AS
BEGIN
	DELETE FROM LOJA WHERE id = @id;
END
go
CREATE PROC aplicarCura(@fito INT,@var INT,@date SMALLDATETIME)
AS
INSERT INTO CURAS VALUES
	(@fito,@var,@date)
go

CREATE PROC seeAvailability
AS
SELECT [name],size,[availability],pricekg 
FROM TIPODECAIXA JOIN VARIEDADE on TIPODECAIXA.code = VARIEDADE.code
WHERE [availability] !=0
go

CREATE PROC getAvailabilityOf(@code INT,@SIZE VARCHAR(6),@disp INT OUTPUT)
AS
SELECT @disp = [availability] 
FROM TIPODECAIXA JOIN VARIEDADE on TIPODECAIXA.code = VARIEDADE.code
WHERE TIPODECAIXA.code = @code AND TIPODECAIXA.size = @SIZE
go
CREATE PROC updateAvailabilityOf(@code INT,@SIZE VARCHAR(6),@disp INT)
AS
UPDATE TIPODECAIXA
SET [availability] = @disp
WHERE code = @code AND size = @SIZE