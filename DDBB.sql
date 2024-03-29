USE [master]
GO
/****** Object:  Database [Municipio]    Script Date: 12/16/2019 21:42:40 ******/
CREATE DATABASE [Municipio] ON  PRIMARY 
( NAME = N'Municipio', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Municipio.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Municipio_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Municipio_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Municipio] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Municipio].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Municipio] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Municipio] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Municipio] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Municipio] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Municipio] SET ARITHABORT OFF
GO
ALTER DATABASE [Municipio] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Municipio] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Municipio] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Municipio] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Municipio] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Municipio] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Municipio] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Municipio] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Municipio] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Municipio] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Municipio] SET  DISABLE_BROKER
GO
ALTER DATABASE [Municipio] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Municipio] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Municipio] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Municipio] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Municipio] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Municipio] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Municipio] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Municipio] SET  READ_WRITE
GO
ALTER DATABASE [Municipio] SET RECOVERY SIMPLE
GO
ALTER DATABASE [Municipio] SET  MULTI_USER
GO
ALTER DATABASE [Municipio] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Municipio] SET DB_CHAINING OFF
GO
USE [Municipio]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 12/16/2019 21:42:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[cliente](
	[idCliente] [int] NOT NULL,
	[dni] [varchar](11) NULL,
	[nombre] [nchar](50) NULL,
	[direccion] [nchar](50) NULL,
	[email] [nchar](30) NULL,
	[telefono] [nchar](15) NULL,
 CONSTRAINT [PK_cliente] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[caja]    Script Date: 12/16/2019 21:42:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[caja](
	[idCaja] [int] NOT NULL,
	[desCaja] [varchar](15) NOT NULL,
 CONSTRAINT [PK_caja] PRIMARY KEY CLUSTERED 
(
	[idCaja] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[modulo]    Script Date: 12/16/2019 21:42:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[modulo](
	[idModulo] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](25) NULL,
 CONSTRAINT [PK_modulo] PRIMARY KEY CLUSTERED 
(
	[idModulo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[tipodocumento]    Script Date: 12/16/2019 21:42:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[tipodocumento](
	[idDoc] [int] NOT NULL,
	[descDoc] [varchar](20) NULL,
 CONSTRAINT [PK_tipodocumento] PRIMARY KEY CLUSTERED 
(
	[idDoc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 12/16/2019 21:42:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[usuario](
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[nom_usuario] [varchar](50) NULL,
	[contraseña] [varchar](50) NULL,
	[fkmodulo] [int] NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[recibo]    Script Date: 12/16/2019 21:42:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[recibo](
	[idRecibo] [int] NOT NULL,
	[fecha] [date] NULL,
	[tipoOrigen] [nchar](20) NULL,
	[mes] [varchar](15) NULL,
	[valorTotal] [float] NULL,
	[nExpedientes] [int] NULL,
	[motivo] [varchar](50) NULL,
	[cajafk] [int] NOT NULL,
	[clientefk] [int] NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[documento]    Script Date: 12/16/2019 21:42:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[documento](
	[numero] [int] NOT NULL,
	[fecha] [date] NULL,
	[tipo] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_usuario_modulo]    Script Date: 12/16/2019 21:42:41 ******/
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [FK_usuario_modulo] FOREIGN KEY([fkmodulo])
REFERENCES [dbo].[modulo] ([idModulo])
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [FK_usuario_modulo]
GO
/****** Object:  ForeignKey [FK_recibo_caja]    Script Date: 12/16/2019 21:42:41 ******/
ALTER TABLE [dbo].[recibo]  WITH CHECK ADD  CONSTRAINT [FK_recibo_caja] FOREIGN KEY([cajafk])
REFERENCES [dbo].[caja] ([idCaja])
GO
ALTER TABLE [dbo].[recibo] CHECK CONSTRAINT [FK_recibo_caja]
GO
/****** Object:  ForeignKey [FK_recibo_cliente]    Script Date: 12/16/2019 21:42:41 ******/
ALTER TABLE [dbo].[recibo]  WITH CHECK ADD  CONSTRAINT [FK_recibo_cliente] FOREIGN KEY([clientefk])
REFERENCES [dbo].[cliente] ([idCliente])
GO
ALTER TABLE [dbo].[recibo] CHECK CONSTRAINT [FK_recibo_cliente]
GO
/****** Object:  ForeignKey [FK_documento_tipodocumento]    Script Date: 12/16/2019 21:42:41 ******/
ALTER TABLE [dbo].[documento]  WITH CHECK ADD  CONSTRAINT [FK_documento_tipodocumento] FOREIGN KEY([tipo])
REFERENCES [dbo].[tipodocumento] ([idDoc])
GO
ALTER TABLE [dbo].[documento] CHECK CONSTRAINT [FK_documento_tipodocumento]
GO
