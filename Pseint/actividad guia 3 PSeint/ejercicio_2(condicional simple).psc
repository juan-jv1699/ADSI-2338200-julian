Proceso ejercicio_1
	//se definen las variables
	Definir largo,ancho,precio_metro,descuento,area,precio Como Real;
	//se solicitan los datos
	Escribir "porfavor ingrese el largo del terreno: ";
	Leer largo;
	Escribir "porfavor ingrese el ancho del terreno: ";
	Leer ancho;
	Escribir "digite el precio por metro cuadrado: ";
	Leer precio_metro;
	area=largo*ancho;
	precio=area*precio_metro;
	descuento= precio*0.1;
	si (area>=400) Entonces
		precio=precio-descuento;
	FinSi
	Escribir "el area en m2 de ese terreno es: ",area;
	Escribir "este es el valor de ese terreno: ",precio;
FinProceso
