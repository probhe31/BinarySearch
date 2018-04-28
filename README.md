# BinarySearch

Binary Search es de complejidad Logarítmica O(log n). Este tipo en general se asocia con algoritmos que aplican "divide and conquer approach" para poder abordarlo.

    Tamaño de la lista 						Tiempo para encontrar uno
(Número de los elementos)			(Cuántos elementos se necesitan revisar)
			1											1
			3											2
			7											3
			10											4
		  2^t - 1										t

2^t - 1 = n
Resolviendo t en términos de n
2^t = n+1
log2(2^t) = log2(n+1) 
t = log2(n+1) 

El tiempo es logarítmico en el número de elementos. El tiempo es proporcial al logaritmo del número de elementos.




