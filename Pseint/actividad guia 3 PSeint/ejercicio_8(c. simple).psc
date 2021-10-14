Proceso ejercicio_4
	Definir time_call,costo_minuto,costo_llamada,minutos_extra Como Real;
	Escribir "cuanto duro la llamada: ";
	Leer time_call;
	costo_minuto=200;
	costo_llamada=costo_minuto*time_call;
	si (time_call>3) Entonces
		minutos_extra=(time_call-3)*150;
		costo_llamada=costo_llamada+minutos_extra;
		Escribir "el costo de los minutos extra fueron ",minutos_extra;
	FinSi
	Escribir "su llamada duro: ",time_call," minutos","|"," el costo de esta llamada es: ",costo_llamada;
FinProceso
