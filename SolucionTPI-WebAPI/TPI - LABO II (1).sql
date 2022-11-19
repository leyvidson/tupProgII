CREATE DATABASE CINE10
USE CINE10

/****** Object:  Table butacas   Script Date: 06/10/2022 12:45:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE butacas(
	id_butaca int IDENTITY (1,1),
	id_sala int NULL,
 CONSTRAINT pk_id_butaca PRIMARY KEY CLUSTERED 
(
	id_butaca ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table calificaciones    Script Date: 06/10/2022 12:45:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE calificaciones(
	id_calificacion int IDENTITY (1,1),
	descripcion varchar(30) NULL,
 CONSTRAINT pk_id_calificacion PRIMARY KEY CLUSTERED 
(
	id_calificacion ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table clientes    Script Date: 06/10/2022 12:45:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE clientes(
	id_cliente int IDENTITY (1,1),
	nombre varchar(30) NULL,
	apellido varchar(30) NULL,
	fec_nac datetime NULL
 CONSTRAINT pk_id_cliente PRIMARY KEY CLUSTERED 
(
	id_cliente ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table detalles_reservas    Script Date: 06/10/2022 12:45:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE detalles_reservas(
	id_detalle_reserva int IDENTITY (1,1),
	id_ticket int NULL,
	id_pelicula int NULL,
	id_promocion int NULL,
	id_funcion int NULL,
	id_reserva int NULL,
 CONSTRAINT pk_id_detalle_reserva PRIMARY KEY CLUSTERED 
(
	id_detalle_reserva ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table actor_principal    Script Date: 06/10/2022 12:45:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE actor_principal(
	id_actor_principal int IDENTITY (1,1),
	nombre varchar(30) NULL,
	apellido varchar(30) NULL,
 CONSTRAINT pk_id_actor_principal PRIMARY KEY CLUSTERED 
(
	id_actor_principal ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO


/****** Object:  Table formas_de_pago    Script Date: 06/10/2022 12:45:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE formas_de_pago(
	id_forma_de_pago int IDENTITY (1,1),
	tipo varchar(30) NULL,
 CONSTRAINT [pk_id_formas_de_pago] PRIMARY KEY CLUSTERED 
(
	[id_forma_de_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table funciones    Script Date: 06/10/2022 12:45:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE funciones(
	id_funcion int IDENTITY (1,1),
	id_pelicula int NULL,
	horario datetime NULL,
	precio decimal(10, 2) NULL,
	id_lenguaje int NULL,
	id_sala int NULL,
 CONSTRAINT pk_id_funcion PRIMARY KEY CLUSTERED 
(
	[id_funcion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table generos    Script Date: 06/10/2022 12:45:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE generos(
	id_genero int IDENTITY (1,1),
	descripcion varchar(30) NULL,
 CONSTRAINT pk_id_genero PRIMARY KEY CLUSTERED 
(
	id_genero ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table lenguajes    Script Date: 06/10/2022 12:45:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE lenguajes(
	id_lenguaje int IDENTITY (1,1),
	descripcion varchar(30) NULL,
 CONSTRAINT pk_id_lenguaje PRIMARY KEY CLUSTERED 
(
	id_lenguaje ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table origenes    Script Date: 06/10/2022 12:45:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE origenes(
	id_origen int IDENTITY (1,1),
	descripcion varchar(30) NULL,
 CONSTRAINT pk_id_pais PRIMARY KEY CLUSTERED 
(
	id_origen ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table peliculas    Script Date: 06/10/2022 12:45:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE peliculas(
	id_pelicula int IDENTITY (1,1),
	id_genero int NULL,
	id_calificacion int NULL,
	duracion decimal(5, 2) NULL,
	subtitulos bit NULL,
	fecha_de_estreno datetime NULL,
	apto_para_todo_publico bit NULL,
	id_actor_principal int NULL,
	id_origen int NULL,
	sinopsis varchar(150) NULL,
	titulo varchar(30) NULL,
 CONSTRAINT pk_id_pelicula PRIMARY KEY CLUSTERED 
(
	id_pelicula ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table promociones    Script Date: 06/10/2022 12:45:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE promociones(
	id_promocion int IDENTITY (1,1),
	descuento float NULL,
	descripcion varchar(50) NULL,
 CONSTRAINT pk_id_promocion PRIMARY KEY CLUSTERED 
(
	id_promocion ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table reservas    Script Date: 06/10/2022 12:45:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE reservas(
	id_reserva int IDENTITY (1,1),
	id_funcion int NULL,
	id_cliente int NULL,
	id_pelicula int NULL,
	fecha datetime NULL,
	cantidad int NULL,
 CONSTRAINT pk_id_reserva PRIMARY KEY CLUSTERED 
(
	id_reserva ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table salas    Script Date: 06/10/2022 12:45:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE salas(
	id_sala int IDENTITY (1,1),
	tipo_sala varchar(20) NULL,
 CONSTRAINT pk_id_sala PRIMARY KEY CLUSTERED 
(
	id_sala ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table tickets    Script Date: 06/10/2022 12:45:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE tickets(
	id_ticket int IDENTITY (1,1),
	id_reserva int NULL,
	id_pelicula int NULL,
	id_forma_de_pago int NULL,
	fecha datetime NULL,
 CONSTRAINT pk_id_ticket PRIMARY KEY CLUSTERED 
(
	id_ticket ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE butacas  WITH CHECK ADD  CONSTRAINT fk_id_sala FOREIGN KEY(id_sala)
REFERENCES salas (id_sala)
GO
ALTER TABLE butacas CHECK CONSTRAINT fk_id_sala
GO
ALTER TABLE detalles_reservas  WITH CHECK ADD  CONSTRAINT fk_id_detalle_reserva FOREIGN KEY(id_reserva)
REFERENCES reservas (id_reserva)
GO
ALTER TABLE detalles_reservas CHECK CONSTRAINT fk_id_detalle_reserva
GO
ALTER TABLE detalles_reservas  WITH CHECK ADD  CONSTRAINT fk_id_funcion_detalle FOREIGN KEY(id_funcion)
REFERENCES funciones (id_funcion)
GO
ALTER TABLE detalles_reservas CHECK CONSTRAINT fk_id_funcion_detalle
GO
ALTER TABLE detalles_reservas  WITH CHECK ADD  CONSTRAINT fk_id_pelicula_detalle FOREIGN KEY(id_pelicula)
REFERENCES peliculas (id_pelicula)
GO
ALTER TABLE detalles_reservas CHECK CONSTRAINT fk_id_pelicula_detalle
GO
ALTER TABLE detalles_reservas  WITH CHECK ADD  CONSTRAINT fk_id_promocion FOREIGN KEY(id_promocion)
REFERENCES promociones (id_promocion)
GO
ALTER TABLE detalles_reservas CHECK CONSTRAINT fk_id_promocion
GO
ALTER TABLE detalles_reservas WITH CHECK ADD  CONSTRAINT fk_id_ticket FOREIGN KEY(id_ticket)
REFERENCES tickets (id_ticket)
GO
ALTER TABLE detalles_reservas CHECK CONSTRAINT fk_id_ticket
GO
ALTER TABLE funciones WITH CHECK ADD  CONSTRAINT fk_id_lenguaje FOREIGN KEY(id_lenguaje)
REFERENCES lenguajes (id_lenguaje)
GO
ALTER TABLE funciones CHECK CONSTRAINT fk_id_lenguaje
GO
ALTER TABLE funciones  WITH CHECK ADD  CONSTRAINT fk_id_pelicula FOREIGN KEY(id_pelicula)
REFERENCES peliculas (id_pelicula)
GO
ALTER TABLE funciones CHECK CONSTRAINT fk_id_pelicula
GO
ALTER TABLE funciones WITH CHECK ADD  CONSTRAINT fk_id_sala_funcion FOREIGN KEY(id_sala)
REFERENCES salas (id_sala)
GO
ALTER TABLE funciones CHECK CONSTRAINT fk_id_sala_funcion
GO
ALTER TABLE peliculas  WITH CHECK ADD  CONSTRAINT fk_id_calificacion FOREIGN KEY(id_calificacion)
REFERENCES calificaciones (id_calificacion)
GO
ALTER TABLE peliculas CHECK CONSTRAINT fk_id_calificacion
GO
ALTER TABLE peliculas  WITH CHECK ADD  CONSTRAINT fk_id_actor_principal FOREIGN KEY(id_actor_principal)
REFERENCES actor_principal (id_actor_principal)
GO
ALTER TABLE peliculas CHECK CONSTRAINT fk_id_actor_principal
GO
ALTER TABLE peliculas  WITH CHECK ADD  CONSTRAINT fk_id_genero FOREIGN KEY(id_genero)
REFERENCES generos (id_genero)
GO
ALTER TABLE peliculas CHECK CONSTRAINT fk_id_genero
GO
ALTER TABLE peliculas WITH CHECK ADD  CONSTRAINT fk_id_origen FOREIGN KEY(id_origen)
REFERENCES origenes (id_origen)
GO
ALTER TABLE peliculas CHECK CONSTRAINT fk_id_origen
GO
ALTER TABLE reservas WITH CHECK ADD  CONSTRAINT fk_id_cliente FOREIGN KEY(id_cliente)
REFERENCES clientes (id_cliente)
GO
ALTER TABLE reservas CHECK CONSTRAINT fk_id_cliente
GO
ALTER TABLE reservas WITH CHECK ADD  CONSTRAINT fk_id_funcion FOREIGN KEY(id_funcion)
REFERENCES funciones (id_funcion)
GO
ALTER TABLE reservas CHECK CONSTRAINT fk_id_funcion
GO
ALTER TABLE reservas  WITH CHECK ADD  CONSTRAINT fk_id_pelicula_reserva FOREIGN KEY(id_pelicula)
REFERENCES peliculas (id_pelicula)
GO
ALTER TABLE reservas CHECK CONSTRAINT fk_id_pelicula_reserva
GO
ALTER TABLE tickets WITH CHECK ADD  CONSTRAINT fk_id_forma_de_pago FOREIGN KEY(id_forma_de_pago)
REFERENCES formas_de_pago (id_forma_de_pago)
GO
ALTER TABLE tickets CHECK CONSTRAINT fk_id_forma_de_pago
GO
ALTER TABLE tickets  WITH CHECK ADD  CONSTRAINT fk_id_pelicula_ticket FOREIGN KEY(id_pelicula)
REFERENCES peliculas (id_pelicula)
GO
ALTER TABLE tickets CHECK CONSTRAINT fk_id_pelicula_ticket
GO
ALTER TABLE tickets  WITH CHECK ADD  CONSTRAINT fk_id_reserva FOREIGN KEY(id_reserva)
REFERENCES reservas (id_reserva)
GO
ALTER TABLE tickets CHECK CONSTRAINT fk_id_reserva
GO



--INSERTS

INSERT Salas (tipo_sala) VALUES (1)
INSERT Salas (tipo_sala) VALUES (2)
INSERT Salas (tipo_sala) VALUES (3)


INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (1)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] (id_sala) VALUES (2)
INSERT [dbo].[Butacas] (id_sala) VALUES (2)
INSERT [dbo].[Butacas] (id_sala) VALUES (2)
INSERT [dbo].[Butacas] (id_sala) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (2)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
GO
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)
INSERT [dbo].[Butacas] ([id_sala]) VALUES (3)



INSERT [dbo].[Generos] (descripcion) VALUES (N'DRAMA')
INSERT [dbo].[Generos] (descripcion) VALUES (N'AVENTURA')
INSERT [dbo].[Generos] (descripcion) VALUES (N'ACCION')
INSERT [dbo].[Generos] (descripcion) VALUES (N'COMIC')
INSERT [dbo].[Generos] (descripcion) VALUES (N'INFANTILES')
INSERT [dbo].[Generos] (descripcion) VALUES (N'SUSPENSO')

INSERT Formas_de_pago (tipo) VALUES (N'EECTIVO')
INSERT Formas_de_pago (tipo) VALUES (N'TARJETA CREDITO')
INSERT Formas_de_pago (tipo) VALUES (N'TARJETA DEBITO')

insert into calificaciones (descripcion) values ('1 Estrella')
insert into calificaciones (descripcion) values ('2 Estrellas')
insert into calificaciones (descripcion) values ('3 Estrellas')
insert into calificaciones (descripcion) values ('4 Estrellas')
insert into calificaciones (descripcion) values ('5 Estrellas')

insert into origenes(descripcion) values ('Nacional')
insert into origenes(descripcion) values ('Europea')
insert into origenes(descripcion) values ('Asiatica')
insert into origenes(descripcion) values ('Sud Africana')
insert into origenes(descripcion) values ('America del Norte')
insert into origenes(descripcion) values ('America Central')
insert into origenes(descripcion) values ('America del Sur')

set Dateformat ymd

INSERT Clientes (nombre, apellido, fec_nac) VALUES(N'JOSE', N'GANORA', CAST(N'1980-10-25 00:00:00.000' AS DateTime))
INSERT Clientes (nombre, apellido, fec_nac) VALUES ('Leonel', 'Lopez', CAST(N'1986-08-28 00:00:00.000' AS DateTime))
INSERT Clientes (nombre, apellido, fec_nac) VALUES ('Agustin', 'Espeche', CAST(N'1983-03-09 00:00:00.000' AS DateTime))
INSERT Clientes (nombre, apellido, fec_nac) VALUES ('Leandro', 'Gomez', CAST(N'1985-07-14 00:00:00.000' AS DateTime))
INSERT Clientes (nombre, apellido, fec_nac) VALUES ('Juan', 'Castro', CAST(N'2016-02-28 00:00:00.000' AS DateTime))
INSERT Clientes (nombre, apellido, fec_nac) VALUES ('Valentin', 'Rizzi', CAST(N'1983-01-25 00:00:00.000' AS DateTime))
INSERT Clientes (nombre, apellido, fec_nac) VALUES ('Rocio', 'Perez', CAST(N'2015-12-12 00:00:00.000' AS DateTime))
INSERT Clientes (nombre, apellido, fec_nac) VALUES ('Paula', 'Ciel', CAST(N'1987-01-12 00:00:00.000' AS DateTime))
INSERT Clientes (nombre, apellido, fec_nac) VALUES ('Romina', 'Malaspina', CAST(N'1874-10-15 00:00:00.000' AS DateTime))
INSERT Clientes (nombre, apellido, fec_nac) VALUES ('Sol', 'Perez', CAST(N'1986-11-18 00:00:00.000' AS DateTime))
INSERT Clientes (nombre, apellido, fec_nac) VALUES(N'Pedro', N'Lopez', CAST(N'1986-08-28 00:00:00.000' AS DateTime))


INSERT lenguajes(descripcion) VALUES ('Inglés')
INSERT lenguajes(descripcion) VALUES ('Castellano')
INSERT lenguajes(descripcion) VALUES ('Francés')
INSERT lenguajes(descripcion) VALUES ('Italiano')
INSERT lenguajes(descripcion) VALUES ('Ruso')

insert into promociones(descuento,descripcion) values(10,'Menores')
insert into promociones(descuento,descripcion) values(20,'Jubilados')
insert into promociones(descuento,descripcion) values(35,'Cumpleaños')
insert into promociones(descuento,descripcion) values(50,'2 X 1')

insert into actor_principal (nombre,apellido) values ('Brad','Pitt')
insert into actor_principal (nombre,apellido) values ('Leonardo','Dicaprio')
insert into actor_principal (nombre,apellido) values ('Johnny','Depp')
insert into actor_principal (nombre,apellido) values ('Denzel','Washington')
insert into actor_principal (nombre,apellido) values ('Clint','Eastwood')
insert into actor_principal (nombre,apellido) values ('Harrison','Ford')
insert into actor_principal (nombre,apellido) values ('Angelina','Jolie')
insert into actor_principal (nombre,apellido) values ('Megan','Fox')
insert into actor_principal (nombre,apellido) values ('Jennifer','Aniston')
insert into actor_principal (nombre,apellido) values ('Natalia','Oreiro')
insert into actor_principal (nombre,apellido) values ('Guillermo','Francella')




--                1             2          3               4         5                6                 7                  8          9          10         11
INSERT peliculas (id_genero, id_calificacion, duracion, subtitulos, fecha_de_estreno, apto_para_todo_publico, id_actor_principal, id_origen,sinopsis,titulo)
VALUES (1,2 ,120.3,1,'1999-08-25',1,1,1,'Cuidado con el iseberg!','Titanic')
--
INSERT peliculas (id_genero, id_calificacion, duracion, subtitulos, fecha_de_estreno, apto_para_todo_publico, id_actor_principal, id_origen,sinopsis,titulo)
VALUES (2 ,3,115.3,0, '1984-05-14',0,2,4,'PAREJA SE SEPARA PERO VIVEN JUNTOS','VIVIENDO CON MI EX')
--
INSERT peliculas (id_genero, id_calificacion, duracion, subtitulos, fecha_de_estreno, apto_para_todo_publico, id_actor_principal, id_origen,sinopsis,titulo)
VALUES (3 ,2,205.1,0, '2017-01-14',1,5,5,'PIRATAS','PIRATAS DEL CARIBE')
--
INSERT peliculas (id_genero, id_calificacion, duracion, subtitulos, fecha_de_estreno, apto_para_todo_publico, id_actor_principal, id_origen,sinopsis,titulo)
VALUES (1 ,4,200.1,0, '2016-07-14',1,8,2,'PICADAS DE AUTOS','RAPIDO Y FURIOSO')
---
INSERT peliculas (id_genero, id_calificacion, duracion, subtitulos, fecha_de_estreno, apto_para_todo_publico, id_actor_principal, id_origen,sinopsis,titulo)
VALUES (4 ,5,175.4,0, '2015-08-25',1,6,1,'VAMPIROS VS LOBOS','CREPUSCULO')
--
INSERT peliculas (id_genero, id_calificacion, duracion, subtitulos, fecha_de_estreno, apto_para_todo_publico, id_actor_principal, id_origen,sinopsis,titulo)
VALUES (3 ,2,123.2,0, '2014-06-30',0,7,7,'SUPERHEROES','BATMAN VS SUPERMAN')
--                1             2          3               4         5                6                 7                  8          9          10         11
INSERT peliculas (id_genero, id_calificacion, duracion, subtitulos, fecha_de_estreno, apto_para_todo_publico, id_actor_principal, id_origen,sinopsis,titulo)
VALUES (4 ,5,122,0, '2016-10-25',1,5,1,'MUJER OLVIDA COSAS','PREMONICION')

INSERT peliculas (id_genero, id_calificacion, duracion, subtitulos, fecha_de_estreno, apto_para_todo_publico, id_actor_principal, id_origen,sinopsis,titulo) 
VALUES (5 ,4,133.59,0, '2016-03-11',1,4,6,'PERSONAS DEL ESPACIO','GUARDIANES DE LA GALAXYA')
--                1             2          3               4         5                6                 7                  8          9          10         11
INSERT peliculas (id_genero, id_calificacion, duracion, subtitulos, fecha_de_estreno, apto_para_todo_publico, id_actor_principal, id_origen,sinopsis,titulo) 
VALUES (2 ,5,199,0, '2017-04-06',1,2,3,'HISTORIA DE WOLVERINE','WOLVERINE')

INSERT peliculas (id_genero, id_calificacion, duracion, subtitulos, fecha_de_estreno, apto_para_todo_publico, id_actor_principal, id_origen,sinopsis,titulo)
VALUES (3 ,1,165.4,0, '2016-04-14',1,2,4,'HISTORIA DE LA BELLA Y LA BESTIA','LA BELLA Y LA BESTIA')
--                1             2          3               4         5                6                 7                  8          9          10         11
INSERT peliculas (id_genero, id_calificacion, duracion, subtitulos, fecha_de_estreno, apto_para_todo_publico, id_actor_principal, id_origen,sinopsis,titulo)
VALUES (1,4,133.89,0, '2016-06-28',1,10,7,'GUERRA','THE ADVENGERS')
--                1             2          3               4         5                6                 7                  8          9          10         11
INSERT peliculas (id_genero, id_calificacion, duracion, subtitulos, fecha_de_estreno, apto_para_todo_publico, id_actor_principal, id_origen,sinopsis,titulo)
VALUES (3 ,2,120.2,0, '2017-07-14',1,11,6,'PERDIDO EN LA ISLA','NAUFRAGO')
--                1             2          3               4         5                6                 7                  8          9          10         11
INSERT peliculas (id_genero, id_calificacion, duracion, subtitulos, fecha_de_estreno, apto_para_todo_publico, id_actor_principal, id_origen,sinopsis,titulo)
VALUES (3 ,2,138.1,0, '2016-12-14',1,9,5,'BAILARINA','EL CISNE NEGRO')


INSERT Funciones (id_pelicula, precio, id_lenguaje, id_sala, horario) VALUES (5, 250, 2, 3,CAST(N'15:00:00.000' AS Time))
INSERT Funciones (id_pelicula, precio, id_lenguaje, id_sala, horario) VALUES (1, 300, 2, 3,CAST(N'22:50:00.000' AS Time))
INSERT Funciones (id_pelicula, precio, id_lenguaje, id_sala, horario) VALUES (10, 500, 2, 1,CAST(N'18:05:00.000' AS Time))
INSERT Funciones (id_pelicula, precio, id_lenguaje, id_sala, horario) VALUES (9, 180.50, 2, 2,CAST(N'23:00:00.000' AS Time))
INSERT Funciones (id_pelicula, precio, id_lenguaje, id_sala, horario) VALUES (3, 600, 2, 2,CAST(N'16:10:00.000' AS Time))
INSERT Funciones (id_pelicula, precio, id_lenguaje, id_sala, horario) VALUES (11, 450, 2, 1,CAST(N'20:40:00.000' AS Time))
INSERT Funciones (id_pelicula, precio, id_lenguaje, id_sala, horario) VALUES (13, 380, 3, 3,CAST(N'21:50:00.000' AS Time))
INSERT Funciones (id_pelicula, precio, id_lenguaje, id_sala, horario) VALUES (1, 620, 1, 2,CAST(N'12:10:00.000' AS Time))
INSERT Funciones (id_pelicula, precio, id_lenguaje, id_sala, horario) VALUES (2, 710.50, 2, 1,CAST(N'14:30:00.000' AS Time))
INSERT Funciones (id_pelicula, precio, id_lenguaje, id_sala, horario) VALUES (4, 290, 2, 3,CAST(N'22:55:00.000' AS Time))
INSERT Funciones (id_pelicula, precio, id_lenguaje, id_sala, horario) VALUES (8, 410, 2, 1,CAST(N'21:00:00.000' AS Time))
INSERT Funciones (id_pelicula, precio, id_lenguaje, id_sala, horario) VALUES (7, 520, 2, 1,CAST(N'19:00:00.000' AS Time))
INSERT Funciones (id_pelicula, precio, id_lenguaje, id_sala, horario) VALUES (12, 500, 2, 2,CAST(N'18:00:00.000' AS Time))
INSERT Funciones (id_pelicula, precio, id_lenguaje, id_sala, horario) VALUES (6, 300, 2, 3,CAST(N'21:45:00.000' AS Time))
INSERT Funciones (id_pelicula, precio, id_lenguaje, id_sala, horario) VALUES (10, 450, 1, 3,CAST(N'15:30:00.000' AS Time))


insert into reservas(id_funcion,id_cliente,id_pelicula,fecha,cantidad) values (1,1,1,'2022-10-15',4)
insert into reservas(id_funcion,id_cliente,id_pelicula,fecha,cantidad) values (1,2,1,'2022-09-15',5)
insert into reservas(id_funcion,id_cliente,id_pelicula,fecha,cantidad) values (2,3,3,'2022-08-10',6)
insert into reservas(id_funcion,id_cliente,id_pelicula,fecha,cantidad) values (2,4,4,'2022-07-20',2)
insert into reservas(id_funcion,id_cliente,id_pelicula,fecha,cantidad) values (3,5,5,'2022-06-10',1)
insert into reservas(id_funcion,id_cliente,id_pelicula,fecha,cantidad) values (3,6,6,'2022-05-17',7)
insert into reservas(id_funcion,id_cliente,id_pelicula,fecha,cantidad) values (4,7,7,'2022-04-13',5)
insert into reservas(id_funcion,id_cliente,id_pelicula,fecha,cantidad) values (4,8,8,'2022-03-01',6)
insert into reservas(id_funcion,id_cliente,id_pelicula,fecha,cantidad) values (5,9,9,'2022-02-02',4)
insert into reservas(id_funcion,id_cliente,id_pelicula,fecha,cantidad) values (5,10,11,'2022-01-15',12)
insert into reservas(id_funcion,id_cliente,id_pelicula,fecha,cantidad) values (6,11,5,'2022-02-04',5)


insert into tickets(id_reserva,id_pelicula, id_forma_de_pago, fecha) values (1,1,1,'2022-10-15')
insert into tickets(id_reserva,id_pelicula, id_forma_de_pago, fecha) values (2,1,3,'2022-09-15')
insert into tickets(id_reserva,id_pelicula, id_forma_de_pago, fecha) values (3,3,2,'2022-08-10')
insert into tickets(id_reserva,id_pelicula, id_forma_de_pago, fecha) values (4,4,3,'2022-07-20')
insert into tickets(id_reserva,id_pelicula, id_forma_de_pago, fecha) values (5,5,3,'2022-06-10')
insert into tickets(id_reserva,id_pelicula, id_forma_de_pago, fecha) values (6,6,2,'2022-05-17')
insert into tickets(id_reserva,id_pelicula, id_forma_de_pago, fecha) values (7,7,1,'2022-04-13')
insert into tickets(id_reserva,id_pelicula, id_forma_de_pago, fecha) values (8,8,1,'2022-03-01')
insert into tickets(id_reserva,id_pelicula, id_forma_de_pago, fecha) values (9,9,1,'2022-02-02')
insert into tickets(id_reserva,id_pelicula, id_forma_de_pago, fecha) values (10,11,1,'2022-01-15')


insert into detalles_reservas (id_ticket,id_pelicula,id_promocion,id_funcion,id_reserva) values(1,1,1,1,1)
insert into detalles_reservas (id_ticket,id_pelicula,id_promocion,id_funcion,id_reserva) values(2,2,4,2,2)
insert into detalles_reservas (id_ticket,id_pelicula,id_promocion,id_funcion,id_reserva) values(3,3,3,3,3)
insert into detalles_reservas (id_ticket,id_pelicula,id_promocion,id_funcion,id_reserva) values(4,12,4,4,4)
insert into detalles_reservas (id_ticket,id_pelicula,id_promocion,id_funcion,id_reserva) values(5,5,4,5,5)
insert into detalles_reservas (id_ticket,id_pelicula,id_promocion,id_funcion,id_reserva) values(6,6,2,5,6)
insert into detalles_reservas (id_ticket,id_pelicula,id_promocion,id_funcion,id_reserva) values(7,7,2,6,7)
insert into detalles_reservas (id_ticket,id_pelicula,id_promocion,id_funcion,id_reserva) values(8,8,1,7,8)
insert into detalles_reservas (id_ticket,id_pelicula,id_promocion,id_funcion,id_reserva) values(9,8,1,8,9)
insert into detalles_reservas (id_ticket,id_pelicula,id_promocion,id_funcion,id_reserva) values(10,13,1,7,10)



--1
--se solicita un listado de peliculas cuyo promedio de recaudacion de este mes fue 
--menor a la del mes anterior.


SELECT MONTH(t.fecha) FECHA, 
       p.titulo PELICULA
FROM peliculas p	
JOIN funciones f 
ON p.id_pelicula = f.id_pelicula 
JOIN tickets t ON p.id_pelicula = t.id_pelicula			
WHERE MONTH(t.fecha) = MONTH(GETDATE()) AND YEAR(t.fecha) = YEAR(GETDATE())
GROUP BY MONTH(t.fecha), p.titulo
HAVING AVG(f.precio) > (SELECT AVG(precio)
						FROM peliculas p1 JOIN funciones f1 
						ON p1.id_pelicula = f1.id_pelicula 
						JOIN tickets t1 ON p1.id_pelicula = t1.id_pelicula						
						WHERE DATEDIFF(MONTH, t1.fecha, GETDATE())=1)
							
--2
--se solicita un listado con los clientes que hayan asistido mas de 10 en veces lo 
--que va del año, q peliculas vio y que la forma de pago haya sido efectivo 

SELECT c.nombre +' '+ c.apellido CLIENTE,
       MONTH(t.fecha)FECHA,
	   p.titulo PELICULA,
	   fp.tipo 'FORMA DE PAGO'
FROM tickets t JOIN peliculas p 
ON t.id_pelicula = p.id_pelicula
JOIN reservas r ON t.id_reserva = r.id_reserva
JOIN clientes c ON r.id_cliente = c.id_cliente
JOIN formas_de_pago fp ON t.id_forma_de_pago = fp.id_forma_de_pago
WHERE YEAR(t.fecha) = YEAR(GETDATE()) 
AND fp.tipo = 'efectivo'
GROUP BY c.nombre +' '+ c.apellido, MONTH(t.fecha),p.titulo,fp.tipo
HAVING COUNT(t.id_ticket) > 10


--3
-- Mostrar ingresos totales mensuales por dia de proyección de este año, siempre 
--que el promedio sea mayor al promedio mensual del año pasado.

SELECT MONTH(t.fecha) 'Mes fecha', 
       SUM(precio) Total, 
	   AVG(precio) Promedio
FROM tickets t JOIN reservas r 
ON r.id_reserva = t.id_reserva 
JOIN funciones f ON f.id_funcion = r.id_funcion
WHERE DATEDIFF(YEAR, t.fecha, GETDATE())=0
GROUP BY MONTH(t.fecha)
HAVING AVG(precio) > (SELECT AVG(precio) 
                      FROM tickets
					  WHERE DATEDIFF(YEAR, fecha, GETDATE())=1
					  GROUP BY MONTH(fecha))

--4
--Mostrar en una misma tabla de resultados nombre, genero y año de actividad de las 
--peliculas de accion donde no asistio publico este año (en primer lugar) y las que 
--se vieron más de 3 veces este año en segundo lugar. ordenar de forma Asc por 
--titulo de pelicula.

SELECT titulo 'Titulo Pelicula', 
       g.descripcion Genero, 
	   YEAR(t.fecha) 'Año de actividad', 'No asis. publico' Observacion
FROM reservas r JOIN tickets t 
ON t.id_reserva = r.id_reserva 
JOIN peliculas p ON p.id_pelicula = t.id_pelicula
JOIN generos g ON g.id_genero=p.id_genero
WHERE DATEDIFF(YEAR,t.fecha,GETDATE())=0 and g.descripcion = 'Accion'
AND	NOT EXISTS (SELECT id_reserva 
                FROM tickets
				WHERE id_reserva = r.id_reserva)					
UNION
SELECT titulo, 
       g.descripcion Genero, 
	   YEAR(t.fecha), 'Vista mas de 3 vec.'
FROM reservas r JOIN tickets t 
ON t.id_reserva = r.id_reserva 
JOIN peliculas p ON p.id_pelicula = t.id_pelicula
JOIN generos g ON g.id_genero=p.id_genero
WHERE DATEDIFF(YEAR,t.fecha,GETDATE())=0 
AND g.descripcion = 'Accion'
AND 3 <	(SELECT COUNT(id_reserva) 
         FROM tickets
		WHERE id_reserva = r.id_reserva)
ORDER BY 1 ASC


--5
--Se crea la vista que liste los clientes que vieron una pelicula de origen
-- nacional este año y que pagaron en efectivo

CREATE VIEW vista_clientes_nacional_efectivo (cliente, origen_pelicula)
AS
SELECT DISTINCT(nombre + ' ' + apellido),
       id_origen
FROM clientes c JOIN reservas r
ON c.id_cliente = r.id_cliente
JOIN peliculas p ON r.id_pelicula = p.id_pelicula
JOIN tickets t ON r.id_reserva = t.id_reserva
WHERE YEAR(t.fecha) = YEAR(GETDATE())
AND id_origen LIKE '%Nacional%'
AND id_forma_de_pago LIKE '%EFECTIVO%'

SELECT * FROM vista_clientes_nacional_efectivo


--Se quiere eliminar la vista anterior
DROP VIEW vista_clientes_nacional_efectivo


DECLARE @retorno INT
EXEC @retorno=pa_peliculas_alta'El Señor de los Anillos', 2, 10, 80, 6
SELECT 'Ingreso realizado=1' = @retorno
EXEC @retorno=pa_peliculas_alta
SELECT 'Ingreso realizado=1' = @retorno;

--7
--Se crea una función de origenes con valores de tabla en línea que recibe un valor
--como parámetro:

CREATE FUNCTION f_origenes
(@descripcion VARCHAR(30)='Europea')
RETURNS TABLE
AS
RETURN (
SELECT descripcion
FROM origenes
WHERE descripcion like '%'+@descripcion+'%'
);


SELECT * FROM f_origenes('Europea');

--8
--se quiere aumentar un 25% los precios de las funciones cuyos precios son 
--inferiores al promedio general

UPDATE funciones
SET precio = precio*1.25
WHERE precio < (SELECT AVG(precio)
                FROM funciones)


----------------------------

CREATE PROCEDURE SP_InsertACTOR
@nombre VARCHAR(30),
@apellido VARCHAR(30)
AS
INSERT INTO actor_principal (nombre, apellido)
VALUES (@nombre, @apellido);

----------------------------

CREATE PROCEDURE SP_NUEVA_PELICULA
@id_genero INT,
@id_calificacion INT,
@duracion DECIMAL(10,2),
@subtitulos INT,
@fecha_de_estreno DATETIME,
@apto_para_todo_publico INT,
@id_actor INT,
@id_origen INT,
@sinopsis VARCHAR(300),
@titulo VARCHAR(100)
AS
INSERT INTO peliculas (id_genero,id_calificacion,duracion,subtitulos,
fecha_de_estreno,apto_para_todo_publico,id_actor_principal,id_origen,sinopsis,titulo) 
VALUES (@id_genero,@id_calificacion,@duracion,@subtitulos,@fecha_de_estreno,
@apto_para_todo_publico,@id_actor,@id_origen,@sinopsis,@titulo);

-------------------

CREATE PROCEDURE SP_NUEVA_PROMOCION
@descuento FLOAT,
@descripcion VARCHAR(30)
AS
INSERT INTO promociones (descuento,descripcion) 
VALUES (@descuento,@descripcion)

---------------------------------

CREATE PROCEDURE SP_NUEVA_RESERVA
@id_funcion INT,
@id_cliente INT,
@id_pelicula INT,
@fecha DATETIME,
@idOut INT OUTPUT
AS
INSERT INTO reservas(id_funcion,id_cliente,id_pelicula,fecha)
VALUES (@id_funcion,@id_cliente,@id_pelicula,@fecha)
SET @idOut = @@Identity;

------------------------

CREATE PROCEDURE SP_DETALLE_RESERVA
@id_ticket INT,
@id_pelicula INT,
@id_promocion INT,
@id_funcion INT,
@id_reserva INT
AS
INSERT INTO detalles_reservas(id_ticket,id_pelicula,id_promocion,id_funcion,id_reserva)
VALUES (@id_ticket,@id_pelicula,@id_promocion,@id_funcion,@id_reserva)




CREATE FUNCTION f_imprimir_ticket
(@id_ticket VARCHAR(5))
RETURNS VARCHAR(1000)
AS
BEGIN
DECLARE @resultado VARCHAR(100)
SET @resultado = (SELECT id_ticket 'Ticket N.', 
                         id_reserva 'N. Reserva', 
						 p.titulo 'Pelicula', 
						 f.tipo'Forma de Pago', 
						 t.fecha 'Fecha'
				  FROM tickets t JOIN peliculas p 
				  ON t.id_pelicula = p.id_pelicula 
				  JOIN formas_de_pago f ON t.id_forma_de_pago = f.id_forma_de_pago
				  WHERE id_ticket = @id_ticket)
RETURN @resultado
END

ALTER procedure [dbo].[p_imprimir_ticket]
@id_ticket int
AS
begin
SELECT top  1 t.id_ticket 'Ticket', 
                         r.id_reserva 'Reserva', 
						 p.titulo 'Pelicula',
						 t.fecha 'Fecha',
						 s.tipo_sala 'Sala',
						 b.id_butaca'Butaca',
						 fu.precio'Importe',
						 pr.descripcion'Promocion'
				  FROM tickets t JOIN peliculas p 
				  ON t.id_pelicula = p.id_pelicula 
				  JOIN reservas r on r.id_reserva = t.id_reserva
				  join funciones fu on fu.id_funcion = r.id_funcion
				  join detalles_reservas det on det.id_ticket = t.id_ticket
				  join promociones pr on pr.id_promocion = det.id_promocion				  
				  join salas s on s.id_sala = fu.id_sala
				  join butacas b on b.id_sala = s.id_sala
				  WHERE t.id_ticket = @id_ticket
end

exec p_imprimir_ticket 5

GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_ACTORES]    Script Date: 05/11/2022 14:09:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_CONSULTAR_ACTORES]
as
select id_actor_principal, nombre+', '+apellido from actor_principal
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_CALIFICACIONES]    Script Date: 05/11/2022 14:09:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[SP_CONSULTAR_CALIFICACIONES]
as
select * from calificaciones
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_CLIENTES]    Script Date: 05/11/2022 14:09:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_CONSULTAR_CLIENTES]
as
select id_cliente, nombre, apellido, format(fec_nac, 'dd/MM/yyyy') fec_nac from clientes
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_GENEROS]    Script Date: 05/11/2022 14:09:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_CONSULTAR_GENEROS]
as
select * from generos
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_ORIGENES]    Script Date: 05/11/2022 14:09:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[SP_CONSULTAR_ORIGENES]
as
select * from origenes
GO
/****** Object:  StoredProcedure [dbo].[SP_CONSULTAR_PELICULA]    Script Date: 05/11/2022 14:09:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[SP_CONSULTAR_PELICULA]
as
Select id_pelicula, p.titulo, p.duracion, c.descripcion calificacion , p.apto_para_todo_publico, p.subtitulos, p.fecha_de_estreno, g.descripcion genero
from peliculas p join calificaciones c on c.id_calificacion= p.id_calificacion join generos g on g.id_genero=p.id_genero
GO
/****** Object:  StoredProcedure [dbo].[SP_NUEVA_PROMOCION]    Script Date: 05/11/2022 14:09:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SP_NUEVA_PROMOCION]
@descuento FLOAT,
@descripcion VARCHAR(30)
AS
INSERT INTO promociones (descuento,descripcion)  
VALUES (@descuento,@descripcion)
GO
/****** Object:  StoredProcedure [dbo].[sp_peliculas_alta]    Script Date: 05/11/2022 14:09:44 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROCEDURE [dbo].[sp_peliculas_alta]
 @titulo VARCHAR(30)=NULL,
 @id_genero INT=NULL,
 @id_calificacion INT=NULL,
 @id_actor_principal INT=NULL,
 @id_origen INT=NULL
AS
IF (@titulo IS NULL) OR (@id_genero IS NULL) OR (@id_calificacion IS NULL)
OR (@id_actor_principal IS NULL) OR (@id_origen IS NULL)
RETURN 0
ELSE
BEGIN
INSERT INTO PELICULAS(titulo, id_genero, id_calificacion, id_actor_principal, id_origen)
VALUES (@titulo, @id_genero, @id_calificacion, @id_actor_principal, @id_origen)
RETURN 1
END;
GO

alter PROCEDURE SP_CONSULTAR_RESERVA
as
Select id_reserva, f.id_funcion, c.nombre+', '+c.apellido Cliente, p.titulo, r.fecha, cantidad
from reservas r JOIN funciones f ON r.id_funcion = f.id_funcion
JOIN clientes c ON c.id_cliente = r.id_cliente
JOIN peliculas p ON p.id_pelicula = r.id_pelicula

alter PROCEDURE SP_CONSULTAR_FUNCION
AS
SELECT f.id_funcion, p.titulo, f.horario, f.precio, l.descripcion lenguaje, s.id_sala
FROM funciones f JOIN peliculas p
ON f.id_pelicula = p.id_pelicula
JOIN lenguajes l ON f.id_lenguaje = l.id_lenguaje
JOIN salas s ON s.id_sala = f.id_sala

CREATE proc sp_peli_prom_mes_actual_mayor_mes_anterior
AS
SELECT MONTH(t.fecha) FECHA, 
       p.titulo PELICULA
FROM peliculas p	
JOIN funciones f 
ON p.id_pelicula = f.id_pelicula 
JOIN tickets t ON p.id_pelicula = t.id_pelicula			
WHERE MONTH(t.fecha) = MONTH(GETDATE()) AND YEAR(t.fecha) = YEAR(GETDATE())
GROUP BY MONTH(t.fecha), p.titulo
HAVING AVG(f.precio) > (SELECT AVG(precio)
						FROM peliculas p1 JOIN funciones f1 
						ON p1.id_pelicula = f1.id_pelicula 
						JOIN tickets t1 ON p1.id_pelicula = t1.id_pelicula						
						WHERE DATEDIFF(MONTH, t1.fecha, GETDATE())=1)

						exec sp_peli_prom_mes_actual_mayor_mes_anterior
-----------------------------------------------
insert into reservas(id_funcion,id_cliente,id_pelicula,fecha,cantidad) values (3,6,6,'2022-10-17',7)
insert into reservas(id_funcion,id_cliente,id_pelicula,fecha,cantidad) values (4,7,7,'2022-11-09',5)
insert into reservas(id_funcion,id_cliente,id_pelicula,fecha,cantidad) values (4,8,6,'2022-11-01',6)
insert into reservas(id_funcion,id_cliente,id_pelicula,fecha,cantidad) values (5,9,6,'2022-11-02',4)
insert into reservas(id_funcion,id_cliente,id_pelicula,fecha,cantidad) values (5,10,7,'2022-10-15',12)
insert into reservas(id_funcion,id_cliente,id_pelicula,fecha,cantidad) values (6,11,7,'2022-11-04',5)
insert into tickets(id_reserva,id_pelicula, id_forma_de_pago, fecha) values (13,6,1,'2022-11-05')
insert into tickets(id_reserva,id_pelicula, id_forma_de_pago, fecha) values (14,6,1,'2022-11-04')
insert into tickets(id_reserva,id_pelicula, id_forma_de_pago, fecha) values (13,6,1,'2022-10-05')
insert into tickets(id_reserva,id_pelicula, id_forma_de_pago, fecha) values (14,7,1,'2022-11-05')
insert into tickets(id_reserva,id_pelicula, id_forma_de_pago, fecha) values (15,7,1,'2022-11-01')
insert into tickets(id_reserva,id_pelicula, id_forma_de_pago, fecha) values (16,7,1,'2022-10-05')

------------------------------------------------



CREATE proc sp_cli_mas_dos_veces_anio_actual
AS
SELECT c.nombre +' '+ c.apellido CLIENTE,
       MONTH(t.fecha)FECHA,
	   p.titulo PELICULA
FROM tickets t JOIN peliculas p 
ON t.id_pelicula = p.id_pelicula
JOIN reservas r ON t.id_reserva = r.id_reserva
JOIN clientes c ON r.id_cliente = c.id_cliente
JOIN formas_de_pago fp ON t.id_forma_de_pago = fp.id_forma_de_pago
WHERE YEAR(t.fecha) = YEAR(GETDATE()) 
GROUP BY c.nombre +' '+ c.apellido, MONTH(t.fecha),p.titulo,fp.tipo
HAVING COUNT(t.id_ticket) > 1

CREATE proc sp_ingresos_mensuales_mayor_anio_pasado
AS
SELECT MONTH(t.fecha) 'Mes fecha', 
       SUM(precio) Total, 
	   AVG(precio) Promedio
FROM tickets t JOIN reservas r 
ON r.id_reserva = t.id_reserva 
JOIN funciones f ON f.id_funcion = r.id_funcion
WHERE DATEDIFF(YEAR, t.fecha, GETDATE())=0
GROUP BY MONTH(t.fecha)
HAVING AVG(precio) > (SELECT AVG(precio) 
                      FROM tickets
					  WHERE DATEDIFF(YEAR, fecha, GETDATE())=1
					  GROUP BY MONTH(fecha))
 
 exec sp_ingresos_mensuales_mayor_anio_pasado
 use CINE10
  
 exec SP_CONSULTAR_RESERVA

create proc SP_OCULTAR_CLIENTE  --ESTE LE DA UNA BAJA LOGICA
@id int
as
UPDATE Clientes
SET activo = 1
WHERE id_cliente = @id

create proc SP_ACTUALIZAR_CLIENTE -- ESTE ES NUEVO PARA ACTUALIZAR
@id_cliente int ,
@nombre varchar(30)=null,
@apellido varchar (30)=null,
@fec_nac datetime =null
as
if (@id_cliente is null) 
begin 
	raiserror ('Falta id', 15,2)
end
begin
if (@nombre is not null)	
	update clientes set nombre = @nombre
	where id_cliente = @id_cliente 
end
begin 
	if (@apellido is not null)	
	update clientes set apellido = @apellido
	where id_cliente = @id_cliente 
end
begin 
	if (@fec_nac is not null)	
	update clientes set fec_nac = @fec_nac
	where id_cliente = @id_cliente 
end

select * from clientes

ALTER PROCEDURE [dbo].[SP_NUEVA_RESERVA]  --EJECUTARLO ASI SE PRODUCE EL CAMBIO
@id_funcion INT,
@id_cliente INT,
@id_pelicula INT,
@fecha DATETIME,
@cantidad int,    --AGREGRE ESTE CAMPO AL SP, 
@idOut INT OUTPUT
AS
INSERT INTO reservas(id_funcion,id_cliente,id_pelicula,fecha,cantidad) 
VALUES (@id_funcion,@id_cliente,@id_pelicula,@fecha,@cantidad) 
SET @idOut = @@Identity;		


alter Proc SP_FUNCIONxRESERVA --Agregado nuevooo (para llenar la gdvFuncionReserva en nueva reserva)
as
select id_funcion, f.id_pelicula, titulo, precio, id_sala
from funciones f join peliculas p on f.id_pelicula = p.id_pelicula

select * from clientes

alter proc SP_NUEVO_CLIENTE  --Deberan ejecutar de nuevo este SP
 @nombre varchar (30),       --Hace que los clientes se creen con activo en 0 cuando se cargan nuevos.
 @apellido varchar(30),   
 @fec_nac datetime 
 as
 begin
 insert into clientes(nombre,apellido,fec_nac,activo) 
 values (@nombre,@apellido,@fec_nac,0)
 end

create Proc SP_CLIENTE_COMPLETO  --Se agrega este sp para los clientes que quieran reservar.
as
select id_cliente, apellido+', '+nombre cliente
from clientes
where activo = 0