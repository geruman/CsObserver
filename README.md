# Observer

Es un patron de comportamiento. [Link descripci�n](https://sourcemaking.com/design_patterns/observer)

El patr�n observer permite a los implementadores de la interfaz observer suscribirse a sujetos y recibir notificaciones de actualizaci�n en el sujeto

## Diagrama uml
![UML](observer.jpg)
## SOLID

* Single responsibility

Un sujeto observador bien modelado tiene solo una responsabilidad, generalmente la de representar una entidad del modelo.

* Open/Closed principle

Este principio cierra bastante con el patr�n aunque en general un observador debe conocer la implementaci�n del sujeto observado o el observado debe devolver (como en este ejemplo) un StateObject con los datos modificados.

* Liskov substitution

Toda implementaci�n de la interfaz observada u observer puede ser intercambiado cualquiera de la jerarquia y deber�a funcionar como si fuera el padre, no hay conflico con este principio.

* Interface segregation

Un buen modelado del patr�n permite segregaci�n de interfaces ya que solo estamos dependiendo de la interfaz observed/observer.

* Dependency inversion

El �nico problema que encuentro con este principio es que el observer debe recibir o un objeto estado (puede ser una interfaz, por supuesto.) o bien conocer la implementaci�n del objeto observado para poder realizar las acciones pertinentes cuando se llame al m�todo update.
