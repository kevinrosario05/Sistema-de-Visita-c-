USE [master]
GO
/****** Object:  Database [visitas]    Script Date: 8/8/2020 11:10:01 PM ******/
CREATE DATABASE [visitas]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'visitas', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\visitas.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'visitas_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\visitas_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [visitas] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [visitas].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [visitas] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [visitas] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [visitas] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [visitas] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [visitas] SET ARITHABORT OFF 
GO
ALTER DATABASE [visitas] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [visitas] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [visitas] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [visitas] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [visitas] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [visitas] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [visitas] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [visitas] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [visitas] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [visitas] SET  DISABLE_BROKER 
GO
ALTER DATABASE [visitas] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [visitas] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [visitas] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [visitas] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [visitas] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [visitas] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [visitas] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [visitas] SET RECOVERY FULL 
GO
ALTER DATABASE [visitas] SET  MULTI_USER 
GO
ALTER DATABASE [visitas] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [visitas] SET DB_CHAINING OFF 
GO
ALTER DATABASE [visitas] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [visitas] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [visitas] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'visitas', N'ON'
GO
ALTER DATABASE [visitas] SET QUERY_STORE = OFF
GO
USE [visitas]
GO
/****** Object:  Table [dbo].[Aula]    Script Date: 8/8/2020 11:10:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Aula](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Aula] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Edificios]    Script Date: 8/8/2020 11:10:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Edificios](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Edificio] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[emple_user]    Script Date: 8/8/2020 11:10:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[emple_user](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[contrasena] [varchar](50) NOT NULL,
	[Tipo_Usuario] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[FechaNacimiento] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Visitantes]    Script Date: 8/8/2020 11:10:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Visitantes](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Apellido] [varchar](50) NOT NULL,
	[Carrera] [varchar](50) NOT NULL,
	[Correro] [varchar](50) NOT NULL,
	[Hora] [varchar](50) NOT NULL,
	[Edificio] [varchar](50) NOT NULL,
	[Aula] [varchar](50) NOT NULL,
	[Descripcion_Motivo] [varchar](200) NOT NULL,
	[Matricula] [varchar](50) NOT NULL,
	[Fecha] [varchar](50) NOT NULL,
	[tipo_visitante] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Aula] ON 

INSERT [dbo].[Aula] ([id], [Aula]) VALUES (59, N'Aula 1a')
INSERT [dbo].[Aula] ([id], [Aula]) VALUES (60, N'Aula 1B')
INSERT [dbo].[Aula] ([id], [Aula]) VALUES (61, N'Aula 1C')
INSERT [dbo].[Aula] ([id], [Aula]) VALUES (62, N'Aula 1D')
INSERT [dbo].[Aula] ([id], [Aula]) VALUES (63, N'Aula 2A')
INSERT [dbo].[Aula] ([id], [Aula]) VALUES (64, N'Oficina Admisiones ')
SET IDENTITY_INSERT [dbo].[Aula] OFF
GO
SET IDENTITY_INSERT [dbo].[Edificios] ON 

INSERT [dbo].[Edificios] ([id], [Edificio]) VALUES (60, N'Edificio Software')
INSERT [dbo].[Edificios] ([id], [Edificio]) VALUES (61, N'Edificio 2')
INSERT [dbo].[Edificios] ([id], [Edificio]) VALUES (62, N'Edificio 3')
INSERT [dbo].[Edificios] ([id], [Edificio]) VALUES (63, N'Biblioteca')
INSERT [dbo].[Edificios] ([id], [Edificio]) VALUES (64, N'Edificio Redes')
SET IDENTITY_INSERT [dbo].[Edificios] OFF
GO
SET IDENTITY_INSERT [dbo].[emple_user] ON 

INSERT [dbo].[emple_user] ([id], [Usuario], [contrasena], [Tipo_Usuario], [Nombre], [Apellido], [FechaNacimiento]) VALUES (1, N'kevin', N'123', N'admin', NULL, NULL, NULL)
INSERT [dbo].[emple_user] ([id], [Usuario], [contrasena], [Tipo_Usuario], [Nombre], [Apellido], [FechaNacimiento]) VALUES (2, N'ciprian', N'321', N'usuario', NULL, NULL, NULL)
INSERT [dbo].[emple_user] ([id], [Usuario], [contrasena], [Tipo_Usuario], [Nombre], [Apellido], [FechaNacimiento]) VALUES (3, N'reynaldo', N'456', N'admin', N'reynaldo', N'cruz', N'8/7/2020')
INSERT [dbo].[emple_user] ([id], [Usuario], [contrasena], [Tipo_Usuario], [Nombre], [Apellido], [FechaNacimiento]) VALUES (4, N'laura', N'222', N'usuario', N'laura', N'quinones', N'8/5/2020')
INSERT [dbo].[emple_user] ([id], [Usuario], [contrasena], [Tipo_Usuario], [Nombre], [Apellido], [FechaNacimiento]) VALUES (6, N'aylin', N'9995', N'usuario', N'aylin', N'ferrera', N'8/7/2020')
INSERT [dbo].[emple_user] ([id], [Usuario], [contrasena], [Tipo_Usuario], [Nombre], [Apellido], [FechaNacimiento]) VALUES (9, N'bis', N'12345', N'admin', N'bismark', N'montero', N'2/8/1990')
INSERT [dbo].[emple_user] ([id], [Usuario], [contrasena], [Tipo_Usuario], [Nombre], [Apellido], [FechaNacimiento]) VALUES (10, N'juancito', N'54321', N'usuario', N'jaun', N'rosario', N'7/18/1991')
SET IDENTITY_INSERT [dbo].[emple_user] OFF
GO
SET IDENTITY_INSERT [dbo].[Visitantes] ON 

INSERT [dbo].[Visitantes] ([id], [Nombre], [Apellido], [Carrera], [Correro], [Hora], [Edificio], [Aula], [Descripcion_Motivo], [Matricula], [Fecha], [tipo_visitante]) VALUES (1, N'esteban', N'hernandez', N'Software', N'esteban@gmail.com', N'7:30:29 AM', N'Edificio 1', N'Aula', N'por que si y por que puedo', N'20186722', N'8/7/2020', N'Estudiante')
INSERT [dbo].[Visitantes] ([id], [Nombre], [Apellido], [Carrera], [Correro], [Hora], [Edificio], [Aula], [Descripcion_Motivo], [Matricula], [Fecha], [tipo_visitante]) VALUES (2, N'pablo', N'mario', N'Software', N'pablotupeque@gmail.com', N'7:30:29 AM', N'Edifico 2:', N'1B', N'por que si y por que puedo', N'20186722', N'8/7/2020', N'Visitante')
INSERT [dbo].[Visitantes] ([id], [Nombre], [Apellido], [Carrera], [Correro], [Hora], [Edificio], [Aula], [Descripcion_Motivo], [Matricula], [Fecha], [tipo_visitante]) VALUES (3, N'kevin', N'rosario', N'', N'kevinrosario@gmail,com', N'4:13:29 AM', N'Edificio 3', N'Aula 3A', N'a tomar clases', N'', N'8/7/2020', N'Visitante')
INSERT [dbo].[Visitantes] ([id], [Nombre], [Apellido], [Carrera], [Correro], [Hora], [Edificio], [Aula], [Descripcion_Motivo], [Matricula], [Fecha], [tipo_visitante]) VALUES (4, N'bismark', N'montero', N'Multimedia', N'bmontero@gmail.com', N'10:50:00 PM', N'Edificio Software', N'Aula 1a', N'A Tomar Clases', N'20186722', N'8/7/2020', N'Estudiante')
INSERT [dbo].[Visitantes] ([id], [Nombre], [Apellido], [Carrera], [Correro], [Hora], [Edificio], [Aula], [Descripcion_Motivo], [Matricula], [Fecha], [tipo_visitante]) VALUES (5, N'JUAN', N'Rosario', N'', N'juan@gmail.com', N'10:50:00 PM', N'Biblioteca', N'Aula', N'a conocer el ITLA', N'', N'8/7/2020', N'Visitante')
SET IDENTITY_INSERT [dbo].[Visitantes] OFF
GO
/****** Object:  StoredProcedure [dbo].[buscarUsuario]    Script Date: 8/8/2020 11:10:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[buscarUsuario]
@Usuario varchar(50)
as
begin
select * from emple_user where Usuario = @Usuario
end;
GO
/****** Object:  StoredProcedure [dbo].[dondeAula]    Script Date: 8/8/2020 11:10:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[dondeAula]
@aula varchar(50)
as
begin
select * from Aula where Aula = @aula
end;
GO
/****** Object:  StoredProcedure [dbo].[dondeEdificio]    Script Date: 8/8/2020 11:10:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[dondeEdificio]
@edificio varchar(50)
as
begin
select * from Edificios where Edificio = @edificio
end;
GO
/****** Object:  StoredProcedure [dbo].[editarUsiario]    Script Date: 8/8/2020 11:10:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[editarUsiario]
@id int,
@usuario varchar(50),
@contrasena varchar(50),
@tipo_usuario varchar(50),
@nombre varchar(50),
@apellido varchar(50),
@fechaNacimiento varchar(50)
 as
 begin
 update emple_user set Usuario=@usuario,contrasena=@contrasena,Tipo_Usuario=@tipo_usuario,Nombre=@nombre,Apellido=@apellido,FechaNacimiento=@fechaNacimiento where id = @id
 end;
GO
/****** Object:  StoredProcedure [dbo].[EliminarUsuario]    Script Date: 8/8/2020 11:10:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[EliminarUsuario]
@Usuario varchar(50)
as
begin
delete  from  emple_user where Usuario = @Usuario
end;
GO
/****** Object:  StoredProcedure [dbo].[insertarAulas]    Script Date: 8/8/2020 11:10:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[insertarAulas]
@aula varchar(50)
as
begin
insert into Aula values(@aula)
end;
GO
/****** Object:  StoredProcedure [dbo].[insertarEdificios]    Script Date: 8/8/2020 11:10:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[insertarEdificios]
@edificio varchar(50)
as
begin
insert into edificios values(@edificio)
end;
GO
/****** Object:  StoredProcedure [dbo].[loguear]    Script Date: 8/8/2020 11:10:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[loguear]
@usuario varchar(50),
@contrasena varchar(50)
as
select Tipo_Usuario,Nombre,Usuario,Contrasena from control where Usuario=@usuario and Contrasena = @contrasena
GO
/****** Object:  StoredProcedure [dbo].[loguear1]    Script Date: 8/8/2020 11:10:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[loguear1]
@usuario varchar(50),
@contrasena varchar(50)
as
select * from control where Usuario=@usuario and Contrasena = @contrasena
GO
/****** Object:  StoredProcedure [dbo].[ModificarAula]    Script Date: 8/8/2020 11:10:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ModificarAula]
@aula varchar(50),
@id int
as
begin
update Aula set Aula=@aula where id = @id
 end;
GO
/****** Object:  StoredProcedure [dbo].[ModificarEdificio]    Script Date: 8/8/2020 11:10:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[ModificarEdificio]
@edificio varchar(50),
@id int
as
begin
update Edificios set Edificio=@edificio where id = @id
 end;
GO
/****** Object:  StoredProcedure [dbo].[sp_Aula]    Script Date: 8/8/2020 11:10:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_Aula]
as
begin
select * from Aula
end;
GO
/****** Object:  StoredProcedure [dbo].[SP_BuscarEdificio]    Script Date: 8/8/2020 11:10:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[SP_BuscarEdificio]
 @edificio varchar(50)
as
select Edificio, Aula from Aula
inner join Edificios on Aula.id=Edificios.id where Edificio = @edificio
GO
/****** Object:  StoredProcedure [dbo].[SP_ConsultarAulas]    Script Date: 8/8/2020 11:10:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 create proc [dbo].[SP_ConsultarAulas]
as
select Edificio, Aula from Aula
inner join Edificios on Aula.id=Edificios.id
GO
/****** Object:  StoredProcedure [dbo].[sp_edificios]    Script Date: 8/8/2020 11:10:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_edificios]
as
begin
select * from edificios
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_insert]    Script Date: 8/8/2020 11:10:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_insert]
@usuario varchar(50),
@contrasena varchar(50),
@tipo_usuario varchar(50),
@nombre varchar(50),
@apellido varchar(50),
@fecha varchar(50)
as
begin
insert into emple_user values(@usuario,@contrasena,@tipo_usuario,@nombre,@apellido,@fecha)
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_login]    Script Date: 8/8/2020 11:10:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_login]
as
select * from emple_user
GO
/****** Object:  StoredProcedure [dbo].[sp_loguear]    Script Date: 8/8/2020 11:10:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_loguear]
@usuario varchar(50),
@contrasena varchar(50)
as
begin
select * from emple_user where Usuario=@usuario and Contrasena = @contrasena 
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_visitantes]    Script Date: 8/8/2020 11:10:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_visitantes]
@nombre varchar(50),
@apellido varchar(50),
@carrera varchar(50),
@correo varchar(50),
@fecha varchar(50),
@edifico varchar(50),
@aula varchar(50),
@motivo varchar(50),
@matricula varchar(50),
@hora varchar(50),
@tipo varchar(50)
as
begin
insert into visitantes values(@nombre,@apellido,@carrera,@correo,@fecha,@edifico,@aula,@motivo,@matricula,@hora,@tipo)
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_Visitas]    Script Date: 8/8/2020 11:10:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_Visitas]
@edificio varchar(50)
as
begin
select * from visitantes where Edificio = @edificio
end;
GO
/****** Object:  StoredProcedure [dbo].[Visitas]    Script Date: 8/8/2020 11:10:02 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Visitas]
as
begin
select * from visitantes
end;
GO
USE [master]
GO
ALTER DATABASE [visitas] SET  READ_WRITE 
GO
