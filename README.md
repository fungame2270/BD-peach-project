# BD-peach-project

**Grupo**: P5G7
- Gabriel Teixeira, MEC: 107876
- Tomás Victal, MEC: 109018

## Introdução / Introduction
 
O objetivo da base de dados é gerir o fornecimento de pessegos para revenda em lojas locais. Isto inclui um regsito das lojas, as vendas e reservas associadas as lojas e possibilidade de gerir a disponibilidade da fruta. 

## ​Análise de Requisitos / Requirements

O sistema tem de gerir vendas e reservas para as lojas locais e o estado do produto.
A loja é defenida pelo o seu ID, e contem Nome, Telefone, Email e Local.
A loja pode fazer Reservas dos tipos de caixa que deseja comprar.
Esta reserva terá uma data e identifacador unico.
Será registado as vendas feitas a todas as lojas cada venda tem o seu identiacador unico, Estado (pago ou credito), valor, as Caixas vendidas, o valor total e a data da venda.

É necessario gerir as variadades de pessegos existentes, para cada variadade existem 3 tipos de caixas (em que os tamnhos dos pessegos difere), pequenos,medios,grandes.
As variadades serao defenidas por Codigo, Nome, Epoca,Nº arvores.
O tipo de caixa tera uma variedade, tamanho (pessego), uma aproximaçao da quantidade de caixas disponiveis e preço por Kg

Nas vendas cada caixa terá um tipo de caixa Codigo e o Peso.


## DER


![DER Diagram!](der.png "AnImage")

## ER

![ER Diagram!](er.png "AnImage")
