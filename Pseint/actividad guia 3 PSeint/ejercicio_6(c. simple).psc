Proceso ejercicio_3
	definir valor_compra,descuento1,promocion,total Como Real;
	Escribir "digite el valor de su compra: ";
	Leer valor_compra;
	promocion=azar(100);
	descuento1=valor_compra*0.15;
	si (promocion>=74) Entonces
		descuento1=valor_compra*0.2;
	FinSi
	total=valor_compra-descuento1;
	Escribir "el valor de su compra es: ", valor_compra;
	Escribir "su numero es: ",promocion;
	Escribir "su desceunto es: ",descuento1,"%";
	Escribir "total a pagar: ",total;
	
FinProceso