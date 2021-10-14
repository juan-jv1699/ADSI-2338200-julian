Proceso ejercicio_7
	Definir superficie,metros_bosque,pino_metros,roble_metros,cedro_metros,pino,roble,cedro Como real;
	Escribir "digite la cantidad de hectareas a reforestar:";
	Leer superficie;
	metros_bosque=superficie*10000;
	si (metros_bosque>1000000) Entonces
		pino_metros=metros_bosque*0.7;
		roble_metros=metros_bosque*0.2;
		cedro_metros=metros_bosque*0.1;
	SiNo
		pino_metros=metros_bosque*0.5;
		roble_metros=metros_bosque*0.3;
		cedro_metros=metros_bosque*0.2;
	FinSi
	pino=trunc(pino_metros*0.8);
	roble=trunc(roble_metros*1);
	cedro=trunc(cedro_metros*0.5);
	Escribir "la cantidad de metros cuadrados en ese terreno son: ",metros_bosque;
	Escribir "se sembraran ",pino," estos pinos";
	Escribir "se sembraran ",roble," estos robles";
	Escribir "se sembraran ",cedro," estos cedros";
FinProceso
