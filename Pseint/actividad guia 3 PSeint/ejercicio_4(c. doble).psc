Proceso ejercicio_6
	Definir ingresos, cuota_inicial, pago_mensual, lapso_pago,valor_casa Como Real;
	Escribir "digite sus ingresos";
	Leer ingresos;
	Escribir "digite el valor de la propiedad";
	Leer valor_casa;
	si (ingresos>=800000) Entonces
		cuota_inicial=valor_casa*0.15;
		lapso_pago=10*12;
		pago_mensual=(valor_casa-cuota_inicial)/lapso_pago;
	SiNo
		cuota_inicial=valor_casa*0.3;
		lapso_pago=7*12;
		pago_mensual=(valor_casa-cuota_inicial)/lapso_pago;
	FinSi
	Escribir "el valor de la propiedad es: ",valor_casa;
	Escribir "la primera cuota es de: ",cuota_inicial;
	Escribir "el plazo se divide a ",lapso_pago, " meses";
	Escribir "el pago mensual es de: ",pago_mensual;
	
FinProceso
