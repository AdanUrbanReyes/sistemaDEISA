DESCRIBE usuario;
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
CALL menusSinAcceso('Alizita');

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
CALL menusAcceso('Alexa');