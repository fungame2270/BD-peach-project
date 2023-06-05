DROP FUNCTION IF EXISTS getVariedadesComCuraAplicada
go
CREATE FUNCTION getVariedadesComCuraAplicada() RETURNS @table TABLE (variedades INT)
AS
BEGIN
DECLARE @now  DATETIME = GETDATE();
INSERT @table
	SELECT V.code
	FROM VARIEDADE AS V JOIN CURAS AS C on V.code  = C.variety JOIN FITOFARMACEUTICOS on FITOFARMACEUTICOS.id = C.fitofarmaceutic
	WHERE DATEDIFF(HOUR,C.dateH,@now) < FITOFARMACEUTICOS.interval_days*24
RETURN;
END
