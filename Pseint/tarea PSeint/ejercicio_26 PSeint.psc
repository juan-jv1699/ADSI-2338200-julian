Proceso ejercicio_26
	//Definir
	definir num_1 Como Entero;
	//entrada
	Escribir "digite un numero entero entre 0 y 10";
	Leer num_1;
	//Proceso 
	si (num_1>10) Entonces
		Escribir "numero no valido";
	SiNo
		si (num_1<0) Entonces
			Escribir "numero no valido";
		FinSi
	FinSi
	si (num_1==0) Entonces
		Escribir num_1,"= cero";
	SiNo
		si (num_1==1) Entonces
			Escribir num_1,"= uno";
		SiNo
			si (num_1==2) Entonces
				Escribir num_1,"= dos";
			SiNo
				si (num_1==3) Entonces
					Escribir num_1,"= tres";
				SiNo
					si (num_1==4) Entonces
						Escribir num_1,"= cuatro";
					SiNo
						si (num_1==5) Entonces
							Escribir num_1,"= cinco";
						SiNo
							si (num_1==6) Entonces
								Escribir num_1,"= seis";
							SiNo
								si (num_1==7) Entonces
									Escribir num_1,"= siete";
								SiNo
									si (num_1==8) Entonces
										Escribir num_1,"= ocho";
									SiNo
										si (num_1==9) Entonces
											Escribir num_1,"= nueve";
										SiNo
											si (num_1==10) Entonces
												Escribir num_1,"= diez";
											FinSi
										FinSi
									FinSi
								FinSi
							FinSi
						FinSi
					FinSi
				FinSi
			FinSi
		FinSi
	FinSi
	
FinProceso
