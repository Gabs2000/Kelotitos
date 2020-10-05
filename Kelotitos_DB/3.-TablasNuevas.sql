USE snack_db;

DROP TABLE IF EXISTS compras_proveedor;
CREATE TABLE compras_proveedor (
	id_compra_proveedor INT NOT NULL auto_increment,
	id_inventario INT,
	cantidad INT,
	estatus INT,
	fecha_creacion DATETIME,
    CONSTRAINT id_compra_proveedor_pk primary key (id_compra_proveedor)
);