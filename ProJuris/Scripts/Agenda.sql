create table dbo.Agenda
(
	id int identity(1,1) not null
	,denominacao varchar(50) not null
	,telefone varchar(15) null
	,cep varchar(7) null
	,rua varchar(50) null
	,bairro varchar(50) null
	--colocar FK depois
	,cidade varchar(50) null
	,UF varchar(2) null	 
	,constraint pk_Agenda primary key (id) 
)