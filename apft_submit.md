# BD: Trabalho Prático APF-T

**Grupo**: PXGY
- Tómas Victal, MEC: 109018 
- Gabriel Teixeira , MEC: 107876

## Introdução / Introduction
<!--  
Escreva uma pequena introdução sobre o trabalho.
Write a simple introduction about your project. -->

    A base de dados tem como finalidade gerenciar o fornecimento de pêssegos para revenda em lojas locais, oferecendo um registro completo das lojas, vendas e reservas associadas, além da possibilidade de gerir a disponibilidade da fruta. Com isso, a empresa poderá controlar de forma eficiente as vendas, reservas e estoques, bem como planejar a produção e a distribuição dos pêssegos de forma estratégica, garantindo a satisfação dos clientes e a maximização dos lucros. A base de dados permitirá ainda a geração de relatórios e estatísticas precisas, auxiliando na tomada de decisões fundamentais para o sucesso do negócio.

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

### Versão final/Final version

![DER Diagram!](./Fotos/diagrama_DER.png)

## APFE 

<!-- Descreva sumariamente as melhorias sobre a primeira entrega.
Describe briefly the improvements made since the first delivery. -->

Foi implementado na entidade Loja um atributo Disabel que consisti-te em que a Loja pode estar disponievel ou não para cada Loja. 
E no diagrama de ER decisomos inpllmentar a entidade Login que consistia 

## ER - Esquema Relacional/Relational Schema

### Versão final/Final Version

![ER Diagram!](./Fotos/ER_atualizad.png)

### APFE


<!-- Descreva sumariamente as melhorias sobre a primeira entrega.
Describe briefly the improvements made since the first delivery. -->
Foi implementado a Entidade Login com as informacoes de usermane, password, ,store em que pelo menos o nome do user tem que ser difierente para realizar o seu login.

## ​SQL DDL - Data Definition Language

[SQL DDL File](./Create_DataBase.sql)

## SQL DML - Data Manipulation Language

<!-- Uma secção por formulário.
A section for each form. -->

### Formulario exemplo/Example Form
### Criação de uma loja 
![Exemplo Screenshot!](./Fotos/Create_loja.png )

```sql
-- Show data on the form
-- SELECT * FROM MY_TABLE ....;
-- Insert new element
-- INSERT INTO MY_TABLE ....;

CREATE PROC addStore (@email VARCHAR(64) = NULL,@name VARCHAR(64),@address VARCHAR(64),@phone VARCHAR(9),@nif INT = NULL)
AS
INSERT INTO LOJA (email, [name], [address], phone, nif) VALUES
(@email,@name,@address,@phone,@nif)
go


```
## Comfirmar venda
![Exemplo Screenshot1!](./Fotos/Confrim_btn.png )
```sql
CREATE PROC addToVenda(@sale INT,@weigth DECIMAL(4,2),@code INT,@size VARCHAR(6))
AS
INSERT INTO CAIXA(sale,[weight],code,size) VALUES
	(@sale,@weigth,@code,@size);
go
```



...

## Normalização/Normalization

<!-- Descreva os passos utilizados para minimizar a duplicação de dados / redução de espaço.
Justifique as opções tomadas.
Describe the steps used to minimize data duplication / space reduction.
Justify the choices made. -->
Os passos que usamos para minimizar a duplicação de dados e a sua redução de espaço:
- a ulizadarvaas de vairas tableas isto é a interligacao dessa, como por exmeplos a ligacoa das entidaddes loja caixa , tipo de caixa e varidade
- a utilização de algumas funções como por exemplo a GetSGBDConnection() que conceta a base de dados 

## Índices/Indexes

<!-- Descreva os indices criados. Junte uma cópia do SQL de criação do indice.
Describe the indexes created. Attach a copy of the SQL to create the index. -->

```sql
-- Create an index to speed
-- CREATE INDEX index_name ON table_name (column1, column2, ...);

CREATE PROC addToVenda(@sale INT,@weigth DECIMAL(4,2),@code INT,@size VARCHAR(6))
AS
INSERT INTO CAIXA(sale,[weight],code,size) VALUES
	(@sale,@weigth,@code,@size);
go


```
A Stored Procedure "addToVenda" serve para adicionar um novo registro à tabela "CAIXA" em um sistema de vendas, especificos para "sale", "weight", "code" e "size". Essa Stored Procedure é usada quando há a necessidade de registrar informações sobre vendas em caixas.

## SQL Programming: Stored Procedures, Triggers, UDF

[SQL SPs and Functions File](sql/02_sp_functions.sql "SQLFileQuestion")

[SQL Triggers File](sql/03_triggers.sql "SQLFileQuestion")

## Outras notas/Other notes

### Dados iniciais da dabase de dados/Database init data

[Indexes File](sql/01_ddl.sql "SQLFileQuestion")



 