Proceso ejercicio_28
	//Definir 
	Definir pago,horas_trabajo, valor_hora Como Real;
	valor_hora=3875;
	//entrada
	Escribir "digite la cantidad de horas que trabajo";
	leer horas_trabajo;
	//Proceso 
	pago=horas_trabajo*valor_hora;
	//salida
	si (horas_trabajo>40) Entonces
		pago=horas_trabajo*valor_hora+(10000*(horas_trabajo-40));
	FinSi
	Escribir "su pago es: ", pago;
FinProceso
