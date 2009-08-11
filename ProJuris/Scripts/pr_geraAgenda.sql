create procedure  dbo.pr_geraAgenda
  @id int = null
	,@denominacao varchar(50)=  null
	,@telefone varchar(15)= null
	,@cep varchar(7) = null
	,@rua varchar(50)= null
	,@bairro varchar(50)= null
	--colocar FK depois
	,@cidade varchar(50)= null
	,@uf varchar(2)= null	 
  ,@operacao varchar(1) = 'i'
as
if @operacao = 'i' begin
  insert  dbo.Agenda(denominacao,telefone,cep,rua,bairro,cidade,uf)
	values (@denominacao,@telefone,@cep,@rua,@bairro,@cidade,@uf)
  select id = scope_identity()
end
else begin
  if @operacao = 'd' begin
    delete  dbo.Agenda
      where  id = @id
  end
  else begin
    update  dbo.Agenda  set
      denominacao = @denominacao
      ,telefone = @telefone
			,cep = @cep 
			,rua = @rua 
			,bairro = @bairro 
			--colocar FK depois
			,cidade = @cidade 
			,uf = @uf 
      where  id = @id 
  end
end

