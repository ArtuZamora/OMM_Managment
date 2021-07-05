--Creacion de Base de Datos
USE MASTER;
GO
CREATE DATABASE GestionOMM
ON
( NAME = GestionOMM_dat,
	FILENAME = 'C:\OMM\GestionOMM_dat.mdf',
	SIZE = 15,
	MAXSIZE = 35,
	FILEGROWTH = 5 )
LOG ON
( NAME = GestionOMM_log,
	FILENAME = 'C:\OMM\GestionOMM_log.ldf',
	SIZE = 5,
	MAXSIZE = 10,
	FILEGROWTH = 3 );
GO

--Creacion de tablas
USE GestionOMM
GO
CREATE TABLE Usuarios
(
	Carnet char(8) NOT NULL,
	Nombre varchar(25) NOT NULL,
	Apellido varchar(25) NOT NULL,
	Usuario varchar(15) NOT NULL,
	Contraseña varchar(50) NOT NULL,
	Email varchar(70),
	Telefono char(9),
	Cod_tipo char(4) NOT NULL,
	Fecha_inscrito date CONSTRAINT DF_fechainscrito DEFAULT getdate()
	CONSTRAINT PK_usuario PRIMARY KEY (Carnet),
	CONSTRAINT U_nombre_usuario UNIQUE (Usuario)
)
CREATE TABLE Tipo_Usuarios
(
	Cod_tipo char(4) NOT NULL,
	Tipo varchar(20) NOT NULL
	CONSTRAINT PK_tipo_usuario PRIMARY KEY (Cod_tipo),
	CONSTRAINT U_tipo_usuario UNIQUE (Tipo),
	CONSTRAINT CK_formato_cod_tipo_u CHECK(Cod_tipo LIKE 'TU[0-9][0-9]')
)
CREATE TABLE Investigaciones
(
	Cod_investigacion char(6) NOT NULL,
	Titulo varchar(70) NOT NULL,
	Detalle varchar(MAX) NOT NULL,
	Fecha_Inicio date NOT NULL CONSTRAINT DF_fechaInicio DEFAULT getdate(),
	Cod_estado int NOT NULL,
	Fecha_Finalizacion date
	CONSTRAINT PK_investigacion PRIMARY KEY (Cod_Investigacion),
	CONSTRAINT U_titulo_investigacion UNIQUE (Titulo),
	CONSTRAINT CK_formato_cod_invest CHECK(Cod_investigacion LIKE 'IV[0-9][0-9][0-9][0-9]')
)
CREATE TABLE Estado_investigaciones
(
	Cod_estado int NOT NULL IDENTITY(1,1),
	Estado varchar(20) NOT NULL
	CONSTRAINT PK_estado PRIMARY KEY (Cod_estado),
	CONSTRAINT U_estado UNIQUE (Estado)
)
CREATE TABLE Instituciones
(
	Cod_institucion char(6) NOT NULL,
	Nombre varchar(150) NOT NULL
	CONSTRAINT PK_institucion PRIMARY KEY (Cod_institucion),
	CONSTRAINT U_nombre UNIQUE (Nombre),
	CONSTRAINT CK_formato_cod_instit CHECK(Cod_institucion LIKE 'I[0-9][0-9][0-9][0-9][0-9]')
)
CREATE TABLE Personas
(
	Cod_persona int NOT NULL IDENTITY (1,1),
	NombreCompleto varchar(60) NOT NULL,
	Email varchar(70) NOT NULL,
	Cod_actividad char(6) NOT NULL
	CONSTRAINT PK_persona PRIMARY KEY (Cod_persona),
	CONSTRAINT U_persona UNIQUE (NombreCompleto, Email)
)
CREATE TABLE Actividades
(
	Cod_actividad char(6) NOT NULL,
	Cod_tipo char(4) NOT NULL,
	Nombre varchar(40) NOT NULL,
	Cupos int NOT NULL,
	Hora time NOT NULL,
	Cod_institucion char(6) NOT NULL,
	Fecha_realizacion date NOT NULL
	CONSTRAINT PK_actividad PRIMARY KEY (Cod_actividad),
	CONSTRAINT CK_cupos CHECK (Cupos > 0),
	CONSTRAINT CK_formato_cod_activ CHECK(Cod_actividad LIKE 'A[0-9][0-9][0-9][0-9][0-9]')
)
CREATE TABLE Tipo_actividades
(
	Cod_tipo char(4) NOT NULL,
	Tipo varchar(50) NOT NULL
	CONSTRAINT PK_tipo_actividad PRIMARY KEY (Cod_tipo),
	CONSTRAINT U_tipo_actividad UNIQUE (Tipo),
	CONSTRAINT CK_formato_cod_tipo_a CHECK(Cod_tipo LIKE 'TA[0-9][0-9]')
)
CREATE TABLE Involucrados_actividades
(
	Carnet char(8) NOT NULL,
	Cod_actividad char(6) NOT NULL
)
CREATE TABLE Registro_investigaciones
(
	Carnet char(8) NOT NULL,
	Cod_investigacion char(6) NOT NULL
)

--Creacion de relaciones
USE GestionOMM
GO
--Relacion Usuario-TipoUsuario
ALTER TABLE Usuarios
ADD CONSTRAINT FK_Usuario_TipoUsuario
FOREIGN KEY (Cod_tipo) REFERENCES Tipo_Usuarios(Cod_tipo)

--Relacion Investigacion-EstadoInvestigacion
ALTER TABLE Investigaciones
ADD CONSTRAINT FK_Investigacion_EstadoInvestigacion
FOREIGN KEY (Cod_estado) REFERENCES Estado_investigaciones(Cod_estado)

--Relacion Actividad-TipoActividad
ALTER TABLE Actividades
ADD CONSTRAINT FK_Actividad_TipoActividad
FOREIGN KEY (Cod_tipo) REFERENCES Tipo_actividades(Cod_tipo)

--Relacion Actividad-Institucion
ALTER TABLE Actividades
ADD CONSTRAINT FK_Actividad_Institucion
FOREIGN KEY (Cod_institucion) REFERENCES Instituciones(Cod_institucion)

--Relacion Persona-Actividad
ALTER TABLE Personas
ADD CONSTRAINT FK_Persona_Actividad
FOREIGN KEY (Cod_actividad) REFERENCES Actividades(Cod_actividad)

--Relacion Registro_investigaciones-Usuario
ALTER TABLE Registro_investigaciones
ADD CONSTRAINT FK_Registro_Usuario
FOREIGN KEY (Carnet) REFERENCES Usuarios(Carnet)

--Relacion Registro_investigaciones-Investigaciones
ALTER TABLE Registro_investigaciones
ADD CONSTRAINT FK_Registro_Investigacion
FOREIGN KEY (Cod_investigacion) REFERENCES Investigaciones(Cod_investigacion)

--Relacion Involucrados_actividades-Usuario
ALTER TABLE Involucrados_actividades
ADD CONSTRAINT FK_Involucrados_Usuario
FOREIGN KEY (Carnet) REFERENCES Usuarios(Carnet)

--Relacion Involucrados_actividades-Actividades
ALTER TABLE Involucrados_actividades
ADD CONSTRAINT FK_Involucrados_Actividad
FOREIGN KEY (Cod_actividad) REFERENCES Actividades(Cod_actividad)

--Creacion de triggers
--Codigo primario tabla Tipo de usuario
GO
CREATE TRIGGER TG_PK_Tipo_Usuario
ON Tipo_Usuarios
FOR INSERT
AS
	DECLARE @identity int
	SET @identity = 0
	SELECT @identity = (COUNT(*) - 1) FROM Tipo_Usuarios;
	SET @identity = @identity + 1;
	UPDATE Tipo_Usuarios 
	SET Cod_tipo = CONCAT('TU', REPLICATE('0',2 - LEN(RTRIM(@identity))) + RTRIM(@identity))
	WHERE Cod_tipo = 'TU00'
GO
--Codigo primario tabla INSTIT
CREATE TRIGGER TG_PK_Investigaciones
ON Investigaciones
FOR INSERT
AS
	DECLARE @identity int
	SET @identity = 0
	SELECT @identity = (COUNT(*) - 1) FROM Investigaciones;
	SET @identity = @identity + 1;
	UPDATE Investigaciones 
	SET Cod_investigacion = CONCAT('IV', REPLICATE('0',4 - LEN(RTRIM(@identity))) + RTRIM(@identity))
	WHERE Cod_investigacion = 'IV0000'
GO
--Codigo primario tabla Instituciones
CREATE TRIGGER TG_PK_Instituciones
ON Instituciones
FOR INSERT
AS
	DECLARE @identity int
	SET @identity = 0
	SELECT @identity = (COUNT(*) - 1) FROM Instituciones;
	SET @identity = @identity + 1;
	UPDATE Instituciones 
	SET Cod_institucion = CONCAT('I', REPLICATE('0',5 - LEN(RTRIM(@identity))) + RTRIM(@identity))
	WHERE Cod_institucion = 'I00000'
GO
--Codigo primario tabla Actividades
CREATE TRIGGER TG_PK_Actividades
ON Actividades
FOR INSERT
AS
	DECLARE @identity int
	SET @identity = 0
	SELECT @identity = (COUNT(*) - 1) FROM Actividades;
	SET @identity = @identity + 1;
	UPDATE Actividades 
	SET Cod_actividad = CONCAT('A', REPLICATE('0',5 - LEN(RTRIM(@identity))) + RTRIM(@identity))
	WHERE Cod_actividad = 'A00000'
GO
--Codigo primario tabla Tipo Actividades
CREATE TRIGGER TG_PK_Tipo_actividades
ON Tipo_actividades
FOR INSERT
AS
	DECLARE @identity int
	SET @identity = 0
	SELECT @identity = (COUNT(*) - 1) FROM Tipo_actividades;
	SET @identity = @identity + 1;
	UPDATE Tipo_actividades 
	SET Cod_tipo = CONCAT('TA', REPLICATE('0',2 - LEN(RTRIM(@identity))) + RTRIM(@identity))
	WHERE Cod_tipo = 'TA00'
GO

--Creacion de la Vista
--Ver las actividades mas recientes
CREATE VIEW Actividades_Recientes
AS
SELECT Nombre 'Actividad',(SELECT tipo FROM Tipo_actividades
WHERE Tipo_actividades.Cod_tipo = Actividades.Cod_tipo) AS 'Tipo',
	Fecha_realizacion 'Fecha',Hora,Cupos,
		(SELECT Instituciones.Nombre FROM Instituciones WHERE Instituciones.Cod_institucion = Actividades.Cod_institucion)
		'Institución'
FROM Actividades
GO

--Creacion del procedimiento almacenado
--Calcular la cantidad de horas sociales de un alumno (2 horas por dia)
CREATE PROCEDURE Proce_HorasSociales
@carnet char(8)
AS
SET DATEFIRST 1
declare @FechaIni date;
SELECT @FechaIni = Fecha_inscrito FROM Usuarios WHERE Carnet = @carnet;
declare @FechaFin date = GETDATE();
declare @dias int=0;
WHILE @FechaIni <= @FechaFin
BEGIN  
   if  datepart(dw, @FechaIni) not in (6,7) SET @dias=@dias+1
   set @FechaIni=dateadd(dd,1,@FechaIni)
END  
SELECT @dias * 2 AS [Horas Acumuladas]
GO

--Inserción de los primeros datos
--Solo existen tres tipos de usuarios en la base de datos, ya predefinidos
INSERT INTO Tipo_Usuarios VALUES
	('TU00','Administrador')
INSERT INTO Tipo_Usuarios VALUES
	('TU00','Colaborador')
INSERT INTO Tipo_Usuarios VALUES
	('TU00','Guía')

--Usuario super-admin de prueba
INSERT INTO Usuarios VALUES
	('XXXXXXXX','sa','sa','sa','12345','sa@OMM.com','1234-5678','TU01', GETDATE())

--Estado de investigaciones
INSERT INTO Estado_investigaciones(Estado) VALUES
	('Aprobado')
INSERT INTO Estado_investigaciones(Estado) VALUES
	('Denegado')
INSERT INTO Estado_investigaciones(Estado) VALUES
	('En proceso')
INSERT INTO Estado_investigaciones(Estado) VALUES
	('Terminado')
INSERT INTO Estado_investigaciones(Estado) VALUES
	('Publicado')

--Instituciones
INSERT INTO Instituciones VALUES
	('I00000', 'Universidad Don Bosco')
INSERT INTO Instituciones VALUES
	('I00000', 'Universidad Nacional de El Salvador')
INSERT INTO Instituciones VALUES
	('I00000', 'Colegio Español Padre Arrupe')
INSERT INTO Instituciones VALUES
	('I00000', 'Colegio Don Bosco')
INSERT INTO Instituciones VALUES
	('I00000', 'Centro Escolar Jorge Lardé')

--Tipo de actividades
INSERT INTO Tipo_actividades VALUES
	('TA00', 'Recorrido')
INSERT INTO Tipo_actividades VALUES
	('TA00', 'Observación Astronómica')
INSERT INTO Tipo_actividades VALUES
	('TA00', 'Taller')
INSERT INTO Tipo_actividades VALUES
	('TA00', 'Ponencia')
INSERT INTO Tipo_actividades VALUES
	('TA00', 'Investigación Científica')