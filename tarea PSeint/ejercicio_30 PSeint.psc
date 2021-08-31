Proceso ejercicio_30
	//Definir
	Definir num_1,num_2 Como Entero;
	Definir resultado Como Real;
	//entrada
	Escribir "porfavor digite numerador";
	Leer num_1;
	Escribir "porfavor digite el denominador";
	Leer num_2;
	//operacion
	si num_2==0 Entonces
		Escribir "esta operacion no es valida";
	SiNo
		resultado= num_1/num_2;
		Escribir "la division da: ", resultado;
	FinSi
	
FinProceso
