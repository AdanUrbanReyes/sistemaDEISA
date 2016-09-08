CREATE SCHEMA deisa;
USE deisa;
CREATE TABLE departamento(
	abreviatura VARCHAR(10) NOT NULL,
	significado VARCHAR(30) NOT NULL,
	encargado VARCHAR(45) NOT NULL,
	PRIMARY KEY(abreviatura)
);
-- abreviatura : alguna abreviatura para el nombre del departamento
-- significado : el nombre del departamento (significado de la abreviatura)
-- encargado : el jefe del departamento el cual debe existir en la tabla usuario
-- OBSERBACIONES : se puede ingresar un departamento con distinta abreviatura pero igual significado y encargado,
-- un usuario puede ser jefe en mas de un departamento, para insertar un nuevo departamento quisas debas anular el
-- FOREIGN KEY si es que debes agregar un nuevo usuario que va ser jefe del departamento

CREATE TABLE usuario(
	cuenta VARCHAR(45) NOT NULL,
	clave VARCHAR(45) NOT NULL,
	nombres varchar(30) NOT NULL,
	primer_apellido VARCHAR(30) NOT NULL,
	segundo_apellido VARCHAR(30) NOT NULL,
    estatus CHAR NOT NULL,
    inicio DATE NOT NULL,
	departamento VARCHAR(10) NOT NULL,
    foto VARCHAR(100) NOT NULL,
	puesto VARCHAR(30) NOT NULL,
    PRIMARY KEY(cuenta),
	FOREIGN KEY(departamento) REFERENCES departamento(abreviatura) ON UPDATE CASCADE ON DELETE CASCADE
);
ALTER TABLE departamento ADD FOREIGN KEY (encargado) REFERENCES usuario(cuenta);
-- estatus :  caracter que representa el estatus del usuario por ejemplo se podrian utilizar los siguientes estatus
-- A : activo
-- I : inactivo
-- V : vacaciones ...
-- inicio : fecha en cuanto inicio a trabajar el usuario
-- departamento : departamento al cual esta abscrito el usuario debe existir en la tabla departamento
-- puesto : puesto que ocupa en el departamento la persona algunos ejemplos
-- Jefe
-- Supervisor de area
-- Axuiliar
-- OBSERVACIONES : un usuario solo puede estar abscrito en un departamento, por lo cual no puede tener mas de un puesto,
-- para agregar un usuario nuevo quisas debas anular el
-- FOREIGN KEY si es que debes agregar un nuevo usuario que va ser jefe del departamento que no existe.
-- si se borra el usuario eliminara todos los registros en las tablas:
-- departamento si es que es jefe
-- usuario_accesa_menu si es que tenia accesos a menus

CREATE TABLE menu(
	nombre VARCHAR(50) NOT NULL,
    texto VARCHAR(30) NOT NULL,
    imagen VARCHAR(30) NOT NULL,
    es_submenu_de VARCHAR(30) NOT NULL,
    descripcion VARCHAR(100) NOT NULL,
    PRIMARY KEY(nombre)
);
ALTER TABLE menu ADD FOREIGN KEY(es_submenu_de) REFERENCES menu(nombre) ON UPDATE CASCADE ON DELETE CASCADE;
-- nombre : nombre de la variable toolStripMenuItem que se le quiere dar (pensando en C#) esta talves pueda ser util en otros lenjuajes
-- texto : texto que aparece debajo del menu (del toolStripMenuItem) (pensando en C#) esta talves pueda ser util en otros lenjuajes
-- imagen : nombre de la imagen; la cual debe tener C# como recurso
-- es_submenu_de : si este menu es submenu de otro deberia tener el nombre del menu padre, y este debe existir en esta tabla; en caso de no ser submenu de nadie el valor deveria ser 'NINGUNO'
-- descripcion : una descripcion de lo que se puede hacer con este menu
-- OBSERVACIONES : esta tabla esta pensada para el lenguaje de programacion C#; por lo cual toda la programacion es la que le da 
-- sentido a esta tabla; el nombre del menu se uso para el nombre de la variable en C# tener cuidado porque puede existir
-- una variable dentro del codigo con el mismo nombre :S y ara tronar el codigo; para agregar un menu nuevo quisas debas anular el
-- FOREIGN KEY si es que debes agregar un nuevo menu que es la raiz es decir no tiene submenus.
-- si se borra el menu eliminara todos los registros en las tablas:
-- menu si este menu tiene submensu es decir es raiz de algun sumenu (de forma recursiva)
-- modulo si este modulo tenia asociado el menu eliminado; tener en cuenta que si el menu tenia submenus y estos van aser eliminados entonces tambien serian eliminados sus modulos y sus hijos de cada submenu
-- usuario_accesa_menu algun usuario tiene acceso a este menu.
-- entonces es muy peligrrozo eliminar un menu padre de otro submenu :S

CREATE TABLE modulo(
	clase VARCHAR(50) NOT NULL,
    espacio_nombres VARCHAR(100) NOT NULL,
    menu VARCHAR(50) NOT NULL,
    PRIMARY KEY(clase,espacio_nombres),
    FOREIGN KEY(menu) REFERENCES menu(nombre) ON UPDATE CASCADE ON DELETE CASCADE
);
-- clase : nombre de la clase sin extencion que se encargara de manejar los eventos del toolStripMenuItem (del menu)
-- espacio_nombres : espacio de nombres donde se encuentra ubicada la clase
-- menu : menu que hace uso de este modulo
-- OBSERVACIONES : esta tabla esta pensada para el lenguaje de programacion C#; por lo cual toda la programacion es la que le da 
-- sentido a esta tabla; el menu debe existir en la tabla menu; un menu podria tener osiada mas de una clase (en el codigo actual esto no se ocupa)

CREATE TABLE usuario_accesa_menu(
	usuario VARCHAR(45) NOT NULL,
	menu VARCHAR(50) NOT NULL,
    PRIMARY KEY(usuario,menu),
    FOREIGN KEY (usuario) REFERENCES usuario(cuenta) ON UPDATE CASCADE ON DELETE CASCADE,
    FOREIGN KEY (menu) REFERENCES menu(nombre) ON UPDATE CASCADE ON DELETE CASCADE
);
-- usuario : cuenta del usuario (debe existir en la tabla usuarios)
-- menu : nombre del menu (debe existir en la tabla menu)
-- OBSERVACIONES : La tabla esta pensada para guradar los menus a los que tendra acceso un usuario; desgraciadamente si no se le puede
-- dar acceso a subpartes del menu, es decir si le das acceso a un menu algun usuario se lo das completo
CREATE TABLE codigo_postal(
	id INT NOT NULL AUTO_INCREMENT,
	codigo_postal INT NOT NULL,
    estado VARCHAR(100) NOT NULL,
    municipio VARCHAR(100) NOT NULL,
    asentamiento VARCHAR(100) NOT NULL,
    PRIMARY KEY (id)
);
CREATE TABLE direccion(
	id INT NOT NULL AUTO_INCREMENT,
	calle VARCHAR(100) NOT NULL,
    numero_exterior INT NOT NULL,
    numero_interior INT NULL,
	codigo_postal INT NOT NULL,
	PRIMARY KEY(id),
	FOREIGN KEY(codigo_postal) REFERENCES codigo_postal(id)
);
CREATE TABLE cliente(
	razon_social VARCHAR(300) NOT NULL,
	planta VARCHAR(300) NOT NULL,
	empresa VARCHAR(300) NULL,
    giro VARCHAR(100) NOT NULL,
    direccion INT NOT NULL,
    rfc VARCHAR(13) NULL,
    proveedor INT NULL,
    sae INT NULL,
    PRIMARY KEY(razon_social, planta),
    FOREIGN KEY (direccion) REFERENCES direccion(id) ON UPDATE CASCADE ON DELETE CASCADE
);
CREATE TABLE celular_cliente(
	razon_social VARCHAR(300) NOT NULL,
    planta VARCHAR(300) NOT NULL,
    celular VARCHAR(10) NOT NULL,
    tipo VARCHAR(30) NOT NULL,
    PRIMARY KEY(razon_social, planta, celular)
    -- FOREIGN KEY (razon_social, planta) REFERENCES cliente(razon_social, planta) ON UPDATE CASCADE ON DELETE CASCADE
);
CREATE TABLE correo_electronico_cliente(
	razon_social VARCHAR(300) NOT NULL,
    planta VARCHAR(300) NOT NULL,
    correo_electronico VARCHAR(100) NOT NULL,
    tipo VARCHAR(30) NOT NULL,
    PRIMARY KEY(razon_social, planta, correo_electronico)
    -- FOREIGN KEY (razon_social, planta) REFERENCES cliente(razon_social, planta) ON UPDATE CASCADE ON DELETE CASCADE
);
CREATE TABLE telefono_cliente(
	razon_social VARCHAR(300) NOT NULL,
    planta VARCHAR(300) NOT NULL,
    telefono VARCHAR(8) NOT NULL,
    tipo VARCHAR(30) NOT NULL,
    PRIMARY KEY(razon_social, planta, telefono)
    -- FOREIGN KEY (razon_social, planta) REFERENCES cliente(razon_social, planta) ON UPDATE CASCADE ON DELETE CASCADE
);

CREATE TABLE matriz(
	abreviatura varchar(10) not null,
	significado varchar(30) not null,
	PRIMARY KEY(abreviatura)
);
CREATE TABLE parametro(
	abreviatura varchar(10) not null,
	matriz varchar(10) not null,
	unidad varchar(30) not null,
	PRIMARY KEY (abreviatura,matriz),
	FOREIGN KEY (matriz) REFERENCES matriz(abreviatura) ON UPDATE CASCADE ON DELETE CASCADE
);
CREATE TABLE parametro_abreviatura_significado(
	abreviatura varchar(10) not null,
	significado varchar(30) not null,
	PRIMARY KEY(abreviatura),
	FOREIGN KEY (abreviatura) REFERENCES parametro(abreviatura) ON UPDATE CASCADE ON DELETE CASCADE
);
CREATE TABLE area(
	abreviatura varchar(10) not null,
	significado varchar(30) not null,
	supervisor varchar(45) not null,
	PRIMARY KEY(abreviatura),
	FOREIGN KEY (supervisor) REFERENCES usuario(cuenta)
);
CREATE TABLE norma(
	nombre varchar(50) not null,
	PRIMARY KEY(nombre)
);
CREATE TABLE metodologia(
	nombre varchar(50) not null,
	norma varchar(50) not null,
	PRIMARY KEY (nombre),
	FOREIGN KEY (norma) REFERENCES norma(nombre)
);
CREATE TABLE parametro_aplica_metodologia(
	parametro varchar(10) not null,
	matriz varchar(10) not null,
	metodologia varchar(50) not null,
	PRIMARY KEY (parametro,matriz,metodologia),
	FOREIGN KEY (parametro,matriz) REFERENCES parametro(abreviatura,matriz) ON UPDATE CASCADE ON DELETE CASCADE,
	FOREIGN KEY (metodologia) REFERENCES metodologia(nombre) ON UPDATE CASCADE ON DELETE CASCADE
);


-- Inserciones para poder iniciar el sistema deisa
-- primero se tendra que agregar el departamento y jefe pero anulando los FOREIGN KEYs porque si no no los dejara
SET foreign_key_checks = 0;
	INSERT INTO departamento (abreviatura,significado,encargado) VALUES ('SS','Sistemas','Ayan');
SET foreign_key_checks = 1;
INSERT INTO usuario (cuenta,clave,nombres,primer_apellido,segundo_apellido,estatus,inicio,departamento,foto,puesto)
VALUES ('Ayan','A1y3a1n7?','Adan','Urban','Reyes', 'A','2016-08-19','SS','C:\Users\Ayan\Pictures\edc2.jpg','Jefe');

SET foreign_key_checks = 0;
INSERT INTO menu VALUES ('usuarios_toolStripMenuItem','Usuarios','usuarios','NINGUNO','Alta, Baja, Modificacion de usuarios'),
    ('usuarioAccesaMenu_toolStripMenuItem','Accesos','usuarioAccesaMenu','NINGUNO','Modificacion de los menus a los que tiene acceso un usuario'),
    ('direcciones_toolStripMenuItem','Direcciones','direcciones','NINGUNO','Alta, Baja, Modificacion de direcciones'),
    ('clientes_toolStripMenuItem','Clientes','clientes','NINGUNO','Alta, Baja, Modificacion de clientes'),
    ('cotizaciones_toolStripMenuItem','Cotizaciones','cotizaciones','NINGUNO','Alta, Baja, Modificacion Cotizaciones');
    
SET foreign_key_checks = 1;
INSERT INTO modulo VALUES ('AdministracionUsuarios_modulo','SistemaDEISA.modelo.modulos','usuarios_toolStripMenuItem'),
	('UsuarioAccesaMenu_modulo','SistemaDEISA.modelo.modulos','usuarioAccesaMenu_toolStripMenuItem'),
    ('AdministracionDirecciones_modulo','SistemaDEISA.modelo.modulos','direcciones_toolStripMenuItem'),
    ('AdministracionClientes_modulo','SistemaDEISA.modelo.modulos','clientes_toolStripMenuItem'),
    ('Cotizaciones_modulo','SistemaDEISA.modelo.modulos','cotizaciones_toolStripMenuItem');
    
INSERT INTO usuario_accesa_menu VALUES ('Ayan','usuarioAccesaMenu_toolStripMenuItem');
