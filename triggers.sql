CREATE TRIGGER disableNoDelete ON LOJA
INSTEAD OF DELETE
AS
UPDATE LOJA
SET [disabled] = 1
WHERE id IN (SELECT id FROM deleted)