DROP INDEX IF EXISTS ixStoreInVenda ON VENDA
DROP INDEX IF EXISTS ixStoreInReserva ON RESERVA
DROP INDEX IF EXISTS ixNameInLoja ON LOJA
DROP INDEX IF EXISTS ixNifInLoja ON LOJA
go
CREATE INDEX ixStoreInVenda ON VENDA (store);
CREATE INDEX ixStoreInReserva ON RESERVA (store);
CREATE INDEX ixNameInLoja on LOJA([name]);
CREATE INDEX ixNifInLoja on LOJA(nif);