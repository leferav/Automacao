
CREATE TABLE [dbo].[TB_CLIENTES](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](100) NULL,
	[Observacao] [nvarchar](1000) NULL,
	[Codigo] [nvarchar](20) NULL,
	[CEP] [nvarchar](9) NULL,
	[Endereco] [nvarchar](200) NULL,
	[Bairro] [nvarchar](100) NULL,
	[Numero] [nvarchar](50) NULL,
	[Telefone] [nvarchar](20) NULL,
	[Cidade] [nvarchar](100) NULL,
	[Email] [nvarchar](300) NULL,
    [codCidade] [int] NULL,
    [codEstado] [int] NULL,
	[Celular] [nvarchar](20) NULL,
	[Imagem] [image] NULL,
	
 CONSTRAINT [PK_TB_PESSOA] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, FILLFACTOR = 90) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO


alter table TB_CLIENTES add Ativo bit 
go 

alter table TB_CLIENTES add Telefone2 nvarchar (20)
go

alter table TB_CLIENTES add DataCadastro datetime
go

