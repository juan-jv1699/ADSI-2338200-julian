Proceso ejercicio_5
	Definir pago_hora,pago_hora_ext,horas_trabajadas,horas_extra,pago,pago_total Como real;
	Escribir "digite las horas que trabajo";
	Leer horas_trabajadas;
	pago_hora=16;
	pago_hora_ext=20;
	pago=pago_hora*horas_trabajadas;
	si (horas_trabajadas<=40) Entonces
		pago_total=pago;
		horas_extra=0;
	SiNo
		horas_extra=horas_trabajadas-40;
		pago=pago-(pago_hora*horas_extra);
		pago_total=pago+(horas_extra*pago_hora_ext);
	FinSi
	Escribir "usted trabajo: ",horas_trabajadas," horas esta semana";
	Escribir "sus horas extra fueron: ",horas_extra;
	Escribir "valor hora: ",pago_hora;
	Escribir "valor hora extra: ",pago_hora_ext;
	Escribir "su pago es: ",pago_total;
	
FinProceso
