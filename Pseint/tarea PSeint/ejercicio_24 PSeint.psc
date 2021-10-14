Proceso ejercicio_24
	//Definir 
	Definir num_1 Como Real;
	//operacion de entrada
	Escribir "digite un numero entre 1 y 9.999";
	Leer num_1;
	//Proceso 
	si (num_1<10) Entonces
		Escribir "ese numero tiene una cifra";
	SiNo
		si (num_1<100) Entonces
			Escribir "ese numero tiene dos cifras";
		SiNo
			si (num_1<1000) Entonces
				Escribir "ese numero tiene tres cifras";
			SiNo
				si (num_1<10000) Entonces
					Escribir "ese numero tiene cuatro cifras";
				FinSi
			FinSi
		FinSi
	FinSi
	
	
FinProceso
