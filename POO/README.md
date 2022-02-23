# Programaci�n Orientada a Objetos

�En que consiste?
- Trasladar la naturaleza de un objeto de la vida real al c�digo de programaci�n.

�Cual es esa naturaleza?
- Estado
- Comportamiento
- Propiedades

Ejemplo: El objeto coche
- Estado.- Parado, andando, aparcado etc.
- Comportamiento.- Arrancar, frenar, acelerar, girar, etc.
- Propiedades.- Color, peso, tama�o, etc.

Ventajas
- Programas divido en trozos, partes, m�dulos o clases.(Modularization)
- C�digo reutilizable. Herencias
- Si existe fallo en alguna l�nea de c�digo el programa continua
- Encapsulamiento.

## Vocabulario de la POO

- clases
- objeto
- Ejemplar de clase, Instancia de clase, Ejemplarizar una clase, Instancia una clase
- Modularizaci�n
- Encapsulamiento / encapsulaci�n
- Herencia
- Polimorfismo

## Clase
Es el modelo donde se redactan las caracter�sticas comunes de un grupo de objetos.

Podr�amos considerar que es una plantilla de la cual se derivaran o crearan objetos

Por ejemplo la clase coche tiene caracter�sticas comunes que se comparten entre diferentes fabricante.

De ah� se crean nuevos coches (objeto)con propiedades diferentes o comportamientos

## Objeto
Tiene propiedades (atributos, caracter�sticas)
- color
- peso
- alto
- largo
Tiene un comportamiento (�Que es capaz de hacer)
- Arrancar
- Acelerar
- Girar
- Frenar

Accediendo a propiedades de un objeto desde c�digo
- Renualt.color = "rojo"

Accediendo a comportamientos de un objeto desde c�digo
- Renual.arranca();


## Encapsulamiento
Por convenci�n todos las propiedades y m�todos deber�an estar encapsulados con el modificador de acceso private a menos que se necesite estar publico. y solo sera modificado con un m�todo de acceso.

## Convenciones a la hora de programar
Los identificadores "public" deben comenzar con la letra may�scula.
- Notaci�n "PascalCase".
public double CalculoArea();
 y los que no con la letra min�scula.
 - Notaci�n "CamelCase"
 private double longitudRadio();

