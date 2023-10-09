insert into ROL (descripcion) values('ADMINISTRADOR');
insert into ROL (descripcion) values('EMPLEADO');
insert into USUARIO(documento,	nombreCompleto, correo, clave, idRol) values('101010', 'ADMIN', '@GMAIL.COM', '123', 1);
insert into USUARIO(documento,	nombreCompleto, correo, clave, idRol) values('202020', 'EMPLEADO', '@GMAIL.COM', '456', 2);

go

insert into PERMISO(idRol, nombreMenu) values 
	(1, 'menuUsuarios'),
	(1, 'menuMantenedor'),
	(1, 'menuVentas'),
	(1, 'menuCompras'),
	(1, 'menuClientes'),
	(1, 'menuProveedores'),
	(1, 'menuReportes'),
	(1, 'menuAcercaDe');

go

insert into PERMISO(idRol, nombreMenu) values 
	(2, 'menuVentas'),
	(2, 'menuCompras'),
	(2, 'menuClientes'),
	(2, 'menuProveedores'),
	(2, 'menuAcercaDe');

go

CREATE PROC SP_REGISTRARUSUARIO (
	@Documento nvarchar(50),
	@NombreCompleto nvarchar(100),
	@Correo nvarchar(100),
	@Clave nvarchar(100),
	@IdRol int,
	@Estado bit,
	@IdUsuarioResultado int output,
	@Mensaje nvarchar(500) output
)
as
begin
	set @IdUsuarioResultado = 0
	set @Mensaje = ''

	if not exists(select * from USUARIO where Documento = @Documento)
	begin
		insert into USUARIO(Documento, NombreCompleto, Correo, Clave, IdRol, Estado) values
			(@Documento, @NombreCompleto, @Correo, @Clave, @IdRol, @Estado)

			set @IdUsuarioResultado = SCOPE_IDENTITY()

	end
	else 
		set @Mensaje = 'No se puede repetir el documento para m�s de un usuario'
end

go

CREATE PROC SP_EDITARUSUARIO (
	@IdUsuario int,
	@Documento nvarchar(50),
	@NombreCompleto nvarchar(100),
	@Correo nvarchar(100),
	@Clave nvarchar(100),
	@IdRol int,
	@Estado bit,
	@Respuesta bit output,
	@Mensaje nvarchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''

	if not exists(select * from USUARIO where Documento = @Documento and IdUsuario != @IdUsuario)
	begin
		update USUARIO set
			Documento = @Documento,
			NombreCompleto = @NombreCompleto,
			Correo = @Correo, 
			Clave = @Clave, 
			IdRol = @IdRol, 
			Estado = @Estado
			where IdUsuario = @IdUsuario

			set @Respuesta = 1
	end
	else 
		set @Mensaje = 'No se puede repetir el documento para m�s de un usuario'
end

go

CREATE PROC SP_ELIMINARUSUARIO (
	@IdUsuario int,
	@Respuesta bit output,
	@Mensaje nvarchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''
	declare @pasoreglas bit = 1

	--Si el usuario esta involucrado en una compra no se puede eliminar
	if exists (select * from COMPRA c
	inner join USUARIO u on u.IdUsuario = c.IdUsuario
	where u.IdUsuario = @IdUsuario)
	begin
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porue el usuario se encuentra relacionado a una COMPRA\n'
	end

	--Si el usuario esta involucrado en una venta no se puede eliminar
	if exists (select * from VENTA v
	inner join USUARIO u on u.IdUsuario = v.IdUsuario
	where u.IdUsuario = @IdUsuario)
	begin
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porue el usuario se encuentra relacionado a una VENTA\n'
	end

	if (@pasoreglas = 1)
	begin
		delete from USUARIO where IdUsuario = @IdUsuario
		set @Respuesta = 1
	end
end

go

create proc SP_REGISTRARCATEGORIA (
	@Descripcion nvarchar(50),
	@Estado bit,
	@Resultado int output,
	@Mensaje nvarchar(500) output
)
as
begin
	set @Resultado = 0
	--set @Mensaje = ''
	if not exists (select * from CATEGORIA where Descripcion = @Descripcion)
	begin
		insert into CATEGORIA(Descripcion, Estado) values (@Descripcion, @Estado)
		set @Resultado = SCOPE_IDENTITY()
	end
	else
		set	@Mensaje = 'No se puede repetir la descripcion de una caterogria'
end

go

create procedure SP_EDITARCATEGORIA (
	@IdCategoria int,
	@Descripcion nvarchar(50),
	@Estado bit,
	@Resultado bit output,
	@Mensaje nvarchar(500) output
)
as
begin
	set @Resultado = 1
	--set @Mensaje = ''
	if not exists (select * from CATEGORIA where Descripcion = @Descripcion and IdCategoria != @IdCategoria)
		update CATEGORIA set
		Descripcion = @Descripcion,
		Estado = @Estado
		where IdCategoria = @IdCategoria
	else
	begin
		set @Resultado = 0
		set	@Mensaje = 'No se puede repetir la descripcion de una caterogria'
	end
end

go

create procedure SP_ELIMINARCATEGORIA (
	@IdCategoria int,
	@Resultado bit output,
	@Mensaje nvarchar(500) output
)
as
begin
	set @Resultado = 1
	if not exists (
		select * from CATEGORIA c
		inner join PRODUCTO p on p.IdCategoria = c.IdCategoria
		where c.IdCategoria = @IdCategoria
	)
	begin
		delete top(1) from CATEGORIA where IdCategoria = @IdCategoria
	end
	else
	begin
		set @Resultado = 0
		set @Mensaje = 'La categoria se encuentra relacionada a un producto'
	end
end

go

insert into CATEGORIA (Descripcion, Estado) values ('Colores', 1);
insert into CATEGORIA (Descripcion, Estado) values ('Masillas', 1);
insert into CATEGORIA (Descripcion, Estado) values ('Colores', 1);

go

create proc SP_REGISTRARPRODUCTO (
@Codigo nvarchar(20),
@Nombre nvarchar(30),
@Descripcion nvarchar(30),
@IdCategoria int,
@Estado bit,
@Resultado int output,
@Mensaje nvarchar(500) output
)
as
begin
	set @Resultado = 0
	if not exists (select * from PRODUCTO where Codigo = @Codigo)
	begin
		insert into PRODUCTO(Codigo, Nombre, Descripcion, IdCategoria, Estado) values (@Codigo, @Nombre, @Descripcion, @IdCategoria, @Estado)
		set @Resultado = SCOPE_IDENTITY()
	end
	else
		set @Mensaje = 'Ya existe un producto con el mismo codigo'
end

go

create procedure SP_MODIFICARPRODUCTO (
	@IdProducto int,
	@Codigo nvarchar(20),
	@Nombre nvarchar(30),
	@Descripcion nvarchar(30),
	@IdCategoria int,
	@Estado bit,
	@Resultado bit output,
	@Mensaje nvarchar(500) output
)
as
begin
	set @Resultado = 1
	if not exists (select * from PRODUCTO where Codigo = @Codigo and IdProducto != @IdProducto)
		update PRODUCTO set
		Codigo = @Codigo,
		Nombre = @Nombre,
		Descripcion = @Descripcion,
		IdCategoria = @IdCategoria,
		Estado = @Estado
		where IdProducto = @IdProducto
	else
	begin
		set @Resultado = 0
		set @Mensaje = 'Ya existe un producto con el mismo codigo'
	end
end

go

create proc SP_ELIMINARPRODUCTO (
@IdProducto int,
@Respuesta bit output,
@Mensaje nvarchar(500) output
)
as
begin
	set @Respuesta = 0
	set @Mensaje = ''
	declare @pasoreglas bit = 1

	if exists (select * from DETALLE_COMPRA dc
	inner join PRODUCTO p on p.IdProducto = dc.IdProducto
	where p.IdProducto = @IdProducto
	)
	begin
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacionado a una COMPRA\n'
	end

	if exists (select * from DETALLE_VENTA dv
	inner join PRODUCTO p on p.IdProducto = dv.IdProducto
	where p.IdProducto = @IdProducto
	)
	begin
		set @pasoreglas = 0
		set @Respuesta = 0
		set @Mensaje = @Mensaje + 'No se puede eliminar porque se encuentra relacioado a una VENTA\n'
	end

	if (@pasoreglas = 1)
	begin
		delete from PRODUCTO where IdProducto = @IdProducto
		set @Respuesta = 1
	end
end

Select * from USUARIO;
Select * from PERMISO;
Select * from ROL;
Select * from CATEGORIA;
