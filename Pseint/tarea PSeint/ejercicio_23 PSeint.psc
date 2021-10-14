Proceso ejercicio_23
	//Definir 
	Definir num_1,num_2,num_3 Como Entero;
	//operacion de entrada
	Escribir "digite el primer numero";
	Leer num_1;
	Escribir "digite el segundo numero";
	Leer num_2;
	Escribir "digite el tercer numero";
	Leer num_3;
	//Proceso 
	si (num_1>num_2 y num_1>num_3 y num_2>num_3) Entonces
		Escribir num_1,"-",num_2,"-",num_3;
	FinSi
	si (num_1>num_2 y num_1>num_3 y num_3>num_2) Entonces
		Escribir num_1,"-",num_3,"-",num_2;
	FinSi
	si (num_2>num_1 y num_1>num_3 y num_2>num_3) Entonces
		Escribir num_2,"-",num_1,"-",num_3;
	FinSi
	si (num_2>num_1 y num_3>num_1 y num_2>num_3) Entonces
		Escribir num_2,"-",num_3,"-",num_1;
	FinSi
	si (num_3>num_1 y num_3>num_2 y num_2>num_1) Entonces
		Escribir num_3,"-",num_2,"-",num_1;
	FinSi
	si (num_3>num_1 y num_3>num_2 y num_1>num_2) Entonces
		Escribir num_3,"-",num_1,"-",num_2;
	FinSi
	
FinProceso
