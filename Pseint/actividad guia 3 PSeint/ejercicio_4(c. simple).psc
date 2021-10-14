Proceso ejercicio_2
	//definir las variables
	Definir clave,precio_orig,precio_desc,descuento Como Real;
	Definir nombre_art como cadena;
	//entrada de datos
	Escribir "digite la clave:";
	Leer clave;
	nombre_art= "carne";
	precio_orig= 14000;
	descuento=0;
	//operacion
	si (clave==1) Entonces
		descuento=precio_orig*0.1;
	FinSi
	si (clave==2) Entonces
		descuento=precio_orig*0.2;
	FinSi
	si (clave<>1 y clave <>2) Entonces
		Escribir "la clave es incorrecta";
	FinSi
	precio_desc=precio_orig-descuento;
	//salida
	Escribir "su producto es: ",nombre_art;
	Escribir "el precio del articulo: ",precio_orig;
	Escribir "el descuento es de: ",descuento;
	Escribir "el precio a pagar es: ",precio_desc;
	
FinProceso
