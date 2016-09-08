DELIMITER $
CREATE PROCEDURE llave_primaria_de_una_tabla(in nombre_basedatos varchar(64),in nombre_tabla varchar(64))
begin 
	SELECT  COLUMN_NAME 
	FROM information_schema.COLUMNS 
	WHERE TABLE_NAME = nombre_tabla AND -- name of table
   	table_schema = nombre_basedatos AND -- name of schema
	   column_key = "PRI";-- for get attributes PRIMARY KEY
END $
DELIMITER ;
-- CALL llave_primaria_de_una_tabla("DEISA","usuario");

DELIMITER $
CREATE PROCEDURE menusSinAcceso(IN cuenta VARCHAR(45))
BEGIN
	-- todos los menus a los que no tiene acceso el usuario
	SELECT *
	FROM menu
	WHERE es_submenu_de = 'NINGUNO'AND 
	nombre NOT IN 
		(SELECT m.nombre
		FROM 
			usuario_accesa_menu uam,
			menu m
		WHERE uam.usuario = cuenta AND
			m.nombre=uam.menu
		);
END $
DELIMITER ;
-- CALL menusSinAcceso('Alizita');

DELIMITER $
CREATE PROCEDURE menusAcceso(IN cuenta VARCHAR(45))
BEGIN
	-- obtiene los menus a los que tiene acceso un usuario
	SELECT m.* 
	FROM 
		usuario_accesa_menu uam,
		menu m
	WHERE uam.usuario = cuenta AND
		m.nombre=uam.menu;
END $
DELIMITER ;
-- CALL menusAcceso('Alexa');