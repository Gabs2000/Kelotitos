CREATE DATABASE IF NOT EXISTS snack_db;

USE snack_db;

DROP TABLE IF EXISTS cat_productos;
CREATE TABLE cat_productos (
  id_producto int NOT NULL AUTO_INCREMENT,
  nombre varchar(255) DEFAULT NULL,
  id_tipo_producto int DEFAULT NULL,
  id_tamanio int DEFAULT NULL,
  precio int DEFAULT NULL,
  estatus int DEFAULT NULL,
  fecha_creacion datetime DEFAULT NULL,
  PRIMARY KEY (id_producto)
);

DROP TABLE IF EXISTS cat_tamanios;
CREATE TABLE cat_tamanios (
  id_tamanio int NOT NULL AUTO_INCREMENT,
  tamanio varchar(100) DEFAULT NULL,
  estatus int DEFAULT NULL,
  fecha_creacion datetime DEFAULT NULL,
  PRIMARY KEY (id_tamanio)
);

DROP TABLE IF EXISTS cat_tipos_productos;
CREATE TABLE cat_tipos_productos (
  id_tipo_producto int NOT NULL AUTO_INCREMENT,
  tipo_producto varchar(100) DEFAULT NULL,
  si_tamanio int DEFAULT NULL,
  estatus int DEFAULT NULL,
  fecha_creacion datetime DEFAULT NULL,
  PRIMARY KEY (id_tipo_producto)
);

DROP TABLE IF EXISTS compras_proveedor;
CREATE TABLE compras_proveedor (
  id_compra_proveedor int NOT NULL AUTO_INCREMENT,
  id_inventario int DEFAULT NULL,
  id_proveedor int DEFAULT NULL,
  cantidad int DEFAULT NULL,
  estatus int DEFAULT NULL,
  fecha_creacion datetime DEFAULT NULL,
  PRIMARY KEY (id_compra_proveedor)
);

DROP TABLE IF EXISTS detalles_ventas;
CREATE TABLE detalles_ventas (
  id_detalle_venta int NOT NULL AUTO_INCREMENT,
  id_venta int DEFAULT NULL,
  id_producto int DEFAULT NULL,
  cantidad int DEFAULT NULL,
  estatus int DEFAULT NULL,
  fecha_creacion datetime DEFAULT NULL,
  PRIMARY KEY (id_detalle_venta)
);

DROP TABLE IF EXISTS inventario;
CREATE TABLE inventario (
  id_inventario int NOT NULL AUTO_INCREMENT,
  nombre varchar(100) DEFAULT NULL,
  descripcion varchar(255) DEFAULT NULL,
  id_proveedor int DEFAULT NULL,
  cantidad int DEFAULT NULL,
  unidad_medida varchar(100) DEFAULT NULL,
  precio_compra int DEFAULT NULL,
  estatus int DEFAULT NULL,
  fecha_creacion datetime DEFAULT NULL,
  PRIMARY KEY (id_inventario)
);

DROP TABLE IF EXISTS proveedores;
CREATE TABLE proveedores (
  id_proveedor int NOT NULL AUTO_INCREMENT,
  proveedor varchar(255) DEFAULT NULL,
  encargado varchar(255) DEFAULT NULL,
  calle varchar(100) DEFAULT NULL,
  colonia varchar(100) DEFAULT NULL,
  municipio varchar(100) DEFAULT NULL,
  estado varchar(100) DEFAULT NULL,
  codigo_postal int DEFAULT NULL,
  telefono varchar(20) DEFAULT NULL,
  correo varchar(100) DEFAULT NULL,
  estatus int DEFAULT NULL,
  fecha_creacion datetime DEFAULT NULL,
  PRIMARY KEY (id_proveedor)
);

DROP TABLE IF EXISTS usuarios;
CREATE TABLE usuarios (
  id_usuario int NOT NULL AUTO_INCREMENT,
  nombre varchar(150) DEFAULT NULL,
  usuario varchar(50) DEFAULT NULL,
  contrasena varchar(30) DEFAULT NULL,
  administrador int DEFAULT NULL,
  salarioXdia int DEFAULT NULL,
  diasSemanas int DEFAULT NULL,
  estatus int DEFAULT NULL,
  fecha_creacion datetime DEFAULT NULL,
  PRIMARY KEY (id_usuario)
);

DROP TABLE IF EXISTS ventas;
CREATE TABLE ventas (
  id_venta int NOT NULL AUTO_INCREMENT,
  folio varchar(50) DEFAULT NULL,
  id_usuario int DEFAULT NULL,
  fecha_venta datetime DEFAULT NULL,
  total int DEFAULT NULL,
  estatus int DEFAULT NULL,
  fecha_creacion datetime DEFAULT NULL,
  PRIMARY KEY (id_venta)
);




ALTER TABLE cat_productos
ADD CONSTRAINT fk_tamanio FOREIGN KEY (id_tamanio) REFERENCES cat_tamanios(id_tamanio);

ALTER TABLE cat_productos
ADD CONSTRAINT fk_tipo FOREIGN KEY (id_tipo_producto) REFERENCES cat_tipos_productos(id_tipo_producto);

ALTER TABLE compras_proveedor
ADD CONSTRAINT fk_proveedor FOREIGN KEY (id_proveedor) REFERENCES proveedores(id_proveedor);

ALTER TABLE compras_proveedor
ADD CONSTRAINT fk_inventario FOREIGN KEY (id_inventario) REFERENCES inventario(id_inventario);

ALTER TABLE detalles_ventas
ADD CONSTRAINT fk_venta FOREIGN KEY (id_venta) REFERENCES ventas(id_venta);

ALTER TABLE detalles_ventas
ADD CONSTRAINT fk_producto FOREIGN KEY (id_producto) REFERENCES cat_productos(id_producto);

ALTER TABLE inventario
ADD CONSTRAINT fk_proveedor_inv FOREIGN KEY (id_proveedor) REFERENCES proveedores(id_proveedor);

ALTER TABLE ventas
ADD CONSTRAINT fk_usuario FOREIGN KEY (id_usuario) REFERENCES usuarios(id_usuario);
