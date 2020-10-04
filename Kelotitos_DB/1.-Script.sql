CREATE DATABASE IF NOT EXISTS snack_db;

USE snack_db;

DROP TABLE IF EXISTS cat_productos;
CREATE TABLE cat_productos (
	id_producto INT NOT NULL auto_increment,
	nombre VARCHAR(255),
	id_tipo_producto INT,
	id_tamanio INT,
	precio INT,
	estatus INT,
	fecha_creacion DATETIME,
    CONSTRAINT id_producto_pk primary key (id_producto)
);

DROP TABLE IF EXISTS usuarios;
CREATE TABLE usuarios (
	id_usuario INT NOT NULL auto_increment,
	nombre VARCHAR(150),
	usuario VARCHAR(50),
	contrasena VARCHAR(30),
	administrador INT,
	estatus INT,
	fecha_creacion DATETIME,
    CONSTRAINT id_usuario_pk primary key (id_usuario)
);

DROP TABLE IF EXISTS ventas;
CREATE TABLE ventas (
	id_venta INT NOT NULL auto_increment,
	folio VARCHAR(50),
	id_usuario INT,
	fecha_venta DATETIME,
	total INT,
	estatus INT,
	fecha_creacion DATETIME,
    CONSTRAINT id_venta_Pk primary key (id_venta)
);

DROP TABLE IF EXISTS detalles_ventas;
CREATE TABLE detalles_ventas (
	id_detalle_venta INT NOT NULL auto_increment,
	id_venta INT,
	id_producto INT,
	cantidad INT,
	estatus INT,
	fecha_creacion DATETIME,
    CONSTRAINT id_detalle_venta_pk primary key (id_detalle_venta)
);

DROP TABLE IF EXISTS cat_tipos_productos;
CREATE TABLE cat_tipos_productos (
	id_tipo_producto INT NOT NULL auto_increment,
	tipo_producto VARCHAR(100),
    si_tamanio INT,
	estatus INT,
	fecha_creacion DATETIME,
    CONSTRAINT id_tipo_producto_Pk primary key (id_tipo_producto)
);

DROP TABLE IF EXISTS cat_tamanios;
CREATE TABLE cat_tamanios (
	id_tamanio INT NOT NULL auto_increment,
	tamanio VARCHAR(100),
	estatus INT,
	fecha_creacion DATETIME,
    CONSTRAINT id_tamanio_pk primary key (id_tamanio)
);

DROP TABLE IF EXISTS inventario;
CREATE TABLE inventario (
	id_inventario INT NOT NULL auto_increment,
	nombre VARCHAR(100),
    descripcion VARCHAR(255),
	id_proveedor INT,
	cantidad INT,
	unidad_medida VARCHAR(100),
	precio_compra INT,
	estatus INT,
	fecha_creacion DATETIME,
    CONSTRAINT id_inventario_pk primary key (id_inventario)
);

DROP TABLE IF EXISTS proveedores;
CREATE TABLE proveedores (
	id_proveedor INT NOT NULL auto_increment,
	proveedor VARCHAR(255),
    encargado VARCHAR(255),
	calle VARCHAR(100),
	colonia VARCHAR(100),
	municipio VARCHAR(100),
	estado VARCHAR(100),
	codigo_postal INT,
	telefono VARCHAR(20),
	correo VARCHAR(100),
	estatus INT,
	fecha_creacion DATETIME,
    CONSTRAINT id_proveedor_pk primary key (id_proveedor)
);