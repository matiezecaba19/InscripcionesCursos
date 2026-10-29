-- crea el usuario que usa el programa para conectarse a la base
-- se corre con root, despues de base.sql
-- cambiar TU_CLAVE por la contraseña que quieras y poner la misma en conexion\conexion.ini

CREATE USER IF NOT EXISTS 'gestion_app'@'localhost' IDENTIFIED BY 'TU_CLAVE';

-- solo puede leer y cambiar datos de la base proyecto, no puede borrar ni cambiar tablas
GRANT SELECT, INSERT, UPDATE, DELETE, EXECUTE, SHOW VIEW ON proyecto.* TO 'gestion_app'@'localhost';

FLUSH PRIVILEGES;
