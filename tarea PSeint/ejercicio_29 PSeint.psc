Proceso ejercicio_29
	//Definir
	Definir monto_1,monto_01 Como Real;
	//entrada
	Escribir "digite el monto";
	Leer monto_1;
	//Proceso 
	si (monto_1<100) Entonces
		monto_01=monto_1*2/100;
	SiNo
		si (monto_1>99) Entonces
			monto_01=monto_1*10/100;
		FinSi
	FinSi
	//salida
	Escribir "su monto es: ",monto_1;
	Escribir "su descuento es: ", monto_01;
FinProceso
