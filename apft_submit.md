# BD: Trabalho Prático APF-T

**Grupo**: P5G7
- Tómas Victal, MEC: 109018 
- Gabriel Teixeira , MEC: 107876

## Introdução / Introduction

    A base de dados tem como finalidade gerenciar o fornecimento de pêssegos para revenda em lojas locais, oferecendo um registro completo das lojas, vendas e reservas associadas, além da possibilidade de gerir a disponibilidade da fruta. Com isso, a empresa poderá controlar de forma eficiente as vendas, reservas e estoques, bem como planejar a produção e a distribuição dos pêssegos de forma estratégica, garantindo a satisfação dos clientes e a maximização dos lucros.

## ​Análise de Requisitos / Requirements

    O sistema tem de gerir vendas e reservas para as lojas locais e o estado do produto. A loja é defenida pelo o seu ID, e contem Nome, Telefone, Email e Local. A loja pode fazer Reservas dos tipos de caixa que deseja comprar. Esta reserva terá uma data e identifacador unico. Será registado as vendas feitas a todas as lojas cada venda tem o seu identiacador unico, Estado (pago ou credito), valor, as Caixas vendidas, o valor total e a data da venda.

    É necessario gerir as variadades de pessegos existentes, para cada variadade existem 3 tipos de caixas (em que os tamnhos dos pessegos difere), pequenos,medios,grandes. As variadades serao defenidas por Codigo, Nome, Epoca,Nº arvores. O tipo de caixa tera uma variedade, tamanho (pessego), uma aproximaçao da quantidade de caixas disponiveis e preço por Kg

    Nas vendas cada caixa terá um tipo de caixa Codigo e o Peso.

# Entidades

## Loja

- A loja pode fazer Reservas dos tipos de caixa que deseja comprar.
- A loja é definida pelo o seu ID, e contém Nome, Telefone, Email e Local.

## Reserva

- Esta reserva terá uma data e identificador único.Será registado as vendas feitas a todas as lojas cada venda tem o seu identificador único, Estado (pago ou crédito), valor, as Caixas vendidas, o valor total e a data da venda.

## Venda

- Nas vendas de cada caixa.

## Caixa 

- Cada caixa terá um tipo de caixa Código e o Peso.

## Tipo de Caixa 
- O tipo de caixa terá uma variedade, tamanho (pêssego), uma aproximação da quantidade de caixas disponíveis e preço por Kg.

## Variedade
- É necessário gerir as variedades de pêssegos existentes, para cada variedade existem 3 tipos de caixas (em que os tamanhos dos pêssegos difere), pequenos,médios,grandes.As variedades serão definidas por Código, Nome, Epoca,Nº árvores.

## Fitofarmacêuticos 
- substâncias químicas utilizadas na agricultura para controlar pragas, doenças e ervas daninhas, visando proteger as plantas e garantir a produção agrícola. 

# DER - Diagrama Entidade Relacionamento/Entity Relationship Diagram

## Versão final/Final version

![DER Diagram!](./Fotos/diagrama_DER.png)

## APFE 

Adicionamentos de atributos e entidades ao DER inicial:

Foi implementado na entidade Loja um atributo Disabled que consisti-te em que a Loja pode estar desabilitada nao aparecendo na interface no entanto ficamos com os dados da mesma. 
E no diagrama de ER decisomos inplementar a entidade Login que consistia 

# ER - Esquema Relacional/Relational Schema

## Versão final/Final Version

![ER Diagram!](./Fotos/ER_atualizad.png)

## APFE

Adicionamentos de atributos e entidades ao ER inicial:

Foi implementado a Entidade Login com as informacoes de usermane, password ,store em que pelo menos o nome do user tem que ser difierente para realizar o seu login.

## ​SQL DDL - Data Definition Language

[SQL DDL File](./Create_DataBase.sql)

# SQL DML - Data Manipulation Language


### Formulario exemplo/Example Form
### Criação de uma loja 
![Exemplo Screenshot!](./Fotos/Create_loja.png )

```sql

CREATE PROC addStore (@email VARCHAR(64) = NULL,@name VARCHAR(64),@address VARCHAR(64),@phone VARCHAR(9),@nif INT = NULL)
AS
INSERT INTO LOJA (email, [name], [address], phone, nif) VALUES
(@email,@name,@address,@phone,@nif)
go


```

## Criar venda
![Exemplo Screenshot1!](./Fotos/Confrim_btn.png )
```sql
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
```

## Normalização/Normalization



### 1NF (Primeira Forma Normal)

- Verificamos que todas as tabelas que implementamos estão na Primeira Forma Normal(1NF), pois todos os atributos são atômicos, ou seja, não são multivalorados. Por exemplo, na tabela LOJA, que tem como chave primária o ID da loja, os atributos nome, email, telefone e localidade são atômicos, pois não são multivalorados.

### 2NF (Segunda Forma Normal)

- Verificamos que todas as tabelas que implementamos estão na Segunda Forma Normal(2NF), pois todos os atributos não chave dependem da chave primária. Por exemplo, na tabela LOJA, que tem como chave primária o ID da loja, os atributos nome, email, telefone e localidade dependem apenas dessa chave primária.

### 3NF (Terceira Forma Normal)

- Verificamos que todas as tabelas que implementamos estão na Terceira Forma Normal(3NF), pois não existem dependências transitivas e não existem atributos que não dependem da chave primária nelas.



### ex:
 Por exemplo, na tabela LOJA, que tem como chave primária o ID da loja, os atributos nome, email, telefone e localidade dependem apenas dessa chave primária. Isso significa que não há dependências transitivas, em que um atributo depende de outro atributo que, por sua vez, depende da chave primária. Além disso, não existem atributos na tabela que não dependem da chave primária.

 



## Índices/Indexes

```sql
CREATE INDEX ixStoreInVenda ON VENDA (store);
CREATE INDEX ixStoreInReserva ON RESERVA (store);
CREATE INDEX ixNameInLoja on LOJA([name]);
CREATE INDEX ixNifInLoja on LOJA(nif);
```
Os 2 primeiros indices apresentados sao uteis pois usamos muito a pesquisa por loja para a interface do cliente
Os dois segundos sao uteis num caso em que se implemente sistemas de busca por nif ou nome.
## Seguranca/Security

De modo a tentar minimizar possíveis vulnerabilidades da base de dados a ataques
de SQL Injection. De modo a prevenir estes problemas, na implementação da base de dados
foram tidos em conta os seguintes pontos:
- Tentamos ao máximo utilizar SQL Parametrizado ou Stored Procedures , em
vez de recorrermos ao SQL Dinâmico.

O que nao foi feito:
- Na tabela de LOGIN deviamos usar uma funcao hash para guardar a password.
- Em termos de utilizadores da base de dados deviamos criar um que nao tivesse todas as permissoes para os clientes pudessem usar a base dados (escritas e leituras).


# SQL Programming: Stored Procedures, Triggers, UDF
## Stored Procedures
Usados como camada de abstracao para base de dados.
Duas SP sao com trasacao 'newVenda' e 'newReserva' pois estam fazem bastantes insertes e a venda/reseva so e feita se todos funcionarem.

[SQL SP File](./SP.sql )
## Triggers
Temos um trigger que nao permite lojas seram apagadas estas entao sao desabilitadas.

Seria ainda interessante a criacao de um trigger para quando fosse intrudosido uma reserva as caixas dessa reserva fossem descontabilizadas das disponiveis na tabela TIPODECAIXA.

[SQL Triggers File](./triggers.sql )


## UDFs
Criamos uma UDF com o objetivo de ela ser reutilizavel em varios SELECTS que estao nos SP
[SQL Functions File](./UDF.sql )
```sql
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

```
A UDF "getVariedadesComCuraAplicada" serve para obter as variedades que têm cura aplicada. Essa Stored Procedure é usada quando há a necessidade de obter as variedades que têm cura aplicada.

## Conclusão/Conclusion
Sendo neste ponto notório que a base de dados se encontra em funcionamento,
podemos considerar que a mesma foi implementada.
Com a implementação da interface gráfica, conseguimos de uma maneira visual e
apelativa ver toda a estrutura a funcionar corretamente, sendo então concretizado o
objetivo inicial de uma implementação correta de um sistema de gestão de pêssegos.

## Outras notas/Other notes

### Dados iniciais da dabase de dados/Database init data

[Indexes File](sql/01_ddl.sql "SQLFileQuestion")

LOGINS PARA TESTE:
```
ADM:
user:adm
pass:adm123

Clientes:
user:Girassol
pass:teste123
user:adega_Casal
pass:teste123
```

Divisao de esforcos:
```
- Tómas Victal, MEC: 109018      		60%
- Gabriel Teixeira , MEC: 107876		40%
```

Video Demonstrativo: https://youtu.be/i2tp3VgKfew .


 