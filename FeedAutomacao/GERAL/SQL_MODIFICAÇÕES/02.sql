

CREATE TABLE [dbo].[TB_CLIENTES_RESPONSAVEIS](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](100) NULL,
	[Cargo] [nvarchar](100) NULL,
	[Telefone] [nvarchar](20) NULL,
	[Whatssap] [nvarchar](20) NULL,
	[Cidade] [nvarchar](100) NULL,
	[Email] [nvarchar](300) NULL,
	[Celular] [nvarchar](20) NULL,
	[Skype] [nvarchar](100) NULL,
	[Imagem] [image] NULL,
	[IDCliente] [int] NULL,
 CONSTRAINT [PK_TB_CLIENTES_RESPONSAVEIS] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO



CREATE TABLE [dbo].[TB_TIPO_ACESSO](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [nvarchar](100) NULL,
	[Observacao] [nvarchar](900) NULL

 )
