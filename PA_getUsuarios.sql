CREATE PROCEDURE getUsuarios
	@num int
AS
	SELECT email,nombre,pregunta,respuesta,dni,confirmado,grupo,tipo From Usuarios
