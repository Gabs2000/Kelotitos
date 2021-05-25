INSERT INTO `snack_db`.`cat_tamanios`
(`tamanio`,`estatus`,`fecha_creacion`)
VALUES
("Chico",1,NOW()),
("Mediano",1,NOW()),
("Grande",1,NOW());

INSERT INTO `snack_db`.`cat_tipos_productos`
(`tipo_producto`,`si_Tamanio`,`estatus`,`fecha_creacion`)
VALUES
("En vaso",1,1,NOW()),
("Entero",0,1,NOW()),
("Sencillo",0,1,NOW()),
("Preparado",0,1,NOW()),
("Bebida",1,1,NOW());

INSERT INTO `snack_db`.`cat_productos`
(`nombre`,`id_tipo_producto`,`id_tamanio`,`precio`,`estatus`,`fecha_creacion`)
VALUES
("Elote",1,1,15,1,NOW()),
("Elote",1,2,25,1,NOW()),
("Elote",1,3,35,1,NOW()),
("Elote",2,NULL,30,1,NOW()),
("Papitas",3,NULL,15,1,NOW()),
("Papitas",4,NULL,25,1,NOW()),
("Bebida",5,1,10,1,NOW()),
("Bebida",5,3,15,1,NOW()),
("Bebida",6,1,15,1,NOW()),
("Bebida",6,3,20,1,NOW());
