USE [CalculoMate]
GO
/****** Object:  Table [dbo].[CalculoMateri]    Script Date: 19/10/2021 10:42:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CalculoMateri](
	[idCalMateri] [int] IDENTITY(1,1) NOT NULL,
	[idMaterial] [int] NOT NULL,
	[idCalculo] [int] NOT NULL,
	[idMedParedes] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCalMateri] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Canton]    Script Date: 19/10/2021 10:42:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Canton](
	[codigo_canton] [smallint] IDENTITY(1,1) NOT NULL,
	[codigo_provincia] [smallint] NOT NULL,
	[nombre_canton] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_canton] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 19/10/2021 10:42:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[IdClie] [int] NOT NULL,
	[Nombre] [varchar](40) NOT NULL,
	[priApellido] [varchar](40) NOT NULL,
	[seguApellido] [varchar](40) NOT NULL,
	[correo] [varchar](40) NOT NULL,
	[direccion] [varchar](40) NOT NULL,
	[codigo_canton] [smallint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdClie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ListCal]    Script Date: 19/10/2021 10:42:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ListCal](
	[idCalculo] [int] IDENTITY(1,1) NOT NULL,
	[nombre_Calculo] [varchar](45) NOT NULL,
	[IdPer] [int] NOT NULL,
	[IdClie] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idCalculo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materiales]    Script Date: 19/10/2021 10:42:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materiales](
	[idMaterial] [int] IDENTITY(1,1) NOT NULL,
	[nombre_Material] [varchar](45) NOT NULL,
	[CantiMetro] [decimal](18, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idMaterial] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MediPared]    Script Date: 19/10/2021 10:42:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MediPared](
	[idMedPared] [int] IDENTITY(1,1) NOT NULL,
	[Alto] [decimal](18, 0) NOT NULL,
	[Ancho] [decimal](18, 0) NOT NULL,
	[MetroCuadrado] [decimal](18, 0) NOT NULL,
	[idMedParedes] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idMedPared] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MediParedes]    Script Date: 19/10/2021 10:42:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MediParedes](
	[idMedParedes] [int] IDENTITY(1,1) NOT NULL,
	[totalAlto] [decimal](18, 0) NOT NULL,
	[totalAncho] [decimal](18, 0) NOT NULL,
	[totalMetroCuadrado] [decimal](18, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[idMedParedes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persona]    Script Date: 19/10/2021 10:42:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persona](
	[IdPer] [int] NOT NULL,
	[Nombre] [varchar](40) NOT NULL,
	[priApellido] [varchar](40) NOT NULL,
	[seguApellido] [varchar](40) NOT NULL,
	[correo] [varchar](40) NOT NULL,
	[clave] [varchar](40) NOT NULL,
	[usuario] [varchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdPer] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provincia]    Script Date: 19/10/2021 10:42:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provincia](
	[codigo_provincia] [smallint] IDENTITY(1,1) NOT NULL,
	[nombre_provincia] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[codigo_provincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CalculoMateri]  WITH CHECK ADD  CONSTRAINT [FK_idCalculo] FOREIGN KEY([idCalculo])
REFERENCES [dbo].[ListCal] ([idCalculo])
GO
ALTER TABLE [dbo].[CalculoMateri] CHECK CONSTRAINT [FK_idCalculo]
GO
ALTER TABLE [dbo].[CalculoMateri]  WITH CHECK ADD  CONSTRAINT [FK_idMaterial] FOREIGN KEY([idMaterial])
REFERENCES [dbo].[Materiales] ([idMaterial])
GO
ALTER TABLE [dbo].[CalculoMateri] CHECK CONSTRAINT [FK_idMaterial]
GO
ALTER TABLE [dbo].[CalculoMateri]  WITH CHECK ADD  CONSTRAINT [FK_idMedParedess] FOREIGN KEY([idMedParedes])
REFERENCES [dbo].[MediParedes] ([idMedParedes])
GO
ALTER TABLE [dbo].[CalculoMateri] CHECK CONSTRAINT [FK_idMedParedess]
GO
ALTER TABLE [dbo].[Canton]  WITH CHECK ADD  CONSTRAINT [FK_CANTON_PROVINCIA] FOREIGN KEY([codigo_provincia])
REFERENCES [dbo].[Provincia] ([codigo_provincia])
GO
ALTER TABLE [dbo].[Canton] CHECK CONSTRAINT [FK_CANTON_PROVINCIA]
GO
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_cant] FOREIGN KEY([codigo_canton])
REFERENCES [dbo].[Canton] ([codigo_canton])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_cant]
GO
ALTER TABLE [dbo].[ListCal]  WITH CHECK ADD  CONSTRAINT [FK_IdClie] FOREIGN KEY([IdClie])
REFERENCES [dbo].[Cliente] ([IdClie])
GO
ALTER TABLE [dbo].[ListCal] CHECK CONSTRAINT [FK_IdClie]
GO
ALTER TABLE [dbo].[ListCal]  WITH CHECK ADD  CONSTRAINT [FK_Idper] FOREIGN KEY([IdPer])
REFERENCES [dbo].[Persona] ([IdPer])
GO
ALTER TABLE [dbo].[ListCal] CHECK CONSTRAINT [FK_Idper]
GO
ALTER TABLE [dbo].[MediPared]  WITH CHECK ADD  CONSTRAINT [FK_idMedParedes] FOREIGN KEY([idMedParedes])
REFERENCES [dbo].[MediParedes] ([idMedParedes])
GO
ALTER TABLE [dbo].[MediPared] CHECK CONSTRAINT [FK_idMedParedes]
GO
