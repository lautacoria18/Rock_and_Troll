# Rock-and-Troll

Link de descarga: https://drive.google.com/file/d/1G72v6FpbzVbFW1nkuWyfDYfxyCgwFL--/view?usp=sharing

*Héroe*

-Se mueve horizontalmente con las flechas Izquierda-Derecha o con las teclas A-D.

-La velocidad de movimiento se puede modificar.

-Al desplazarse lanza un pequeño humo.
#
*Lanzador*

-Cada X tiempo lanza una roca con diferentes parámetros seteados dentro de un rango.

-Al arrojar la roca ejecuta un sónido avisándole al jugador que hay una nueva roca en el aire.

-Dependiendo de la fuerza que se le setee, la pidera ira mas cerca o mas lejos desde su salida.

-Los valores de tiempo, fuerza, velocidad y ángulo son aleatorios dentro de un rango establecido.

-Los rangos de la velocidad, el tiempo y el ángulo se pueden modificar.
#
*Rocas*

-Las rocas se desplazan de forma parabólica durante un rango.

-Mientras venga con mayor fuerza, mas lejos caéra.

-Si estas caen al piso, primero emiten un sonido y luego desapareceran en 2 segundos.

-Para generar el efecto rebote, cada vez que una roca colisiona con la caja resorte, se elimina y se instancia una en la misma posición. Los parametros físicos de la nueva roca dependerán de los factores de rebote actuales.
#
*Camara*

-La cámara sigue al *Heroe* horizontalmente.
#
*Monedas*

-Una moneda aparece cuando el heroe emboca una cantidad de rocas necesarias dentro de la meta.

-Aparecen en una posición aleatoria dentro de un rango establecido.

-La moneda nunca puede aparecer en la misma área que el *Heroe*.

-Cuando el heroe agarra una moneda, se le suma a su puntuación de monedas.

-Cada X tiempo desaparece.

-La duración de la moneda se puede modificar.
#
*Meta de roca*

-Cuando el *Heroe* esta en una posición cerca de la meta, y estas rebotan las rocas van directamente hacia la meta.

-Si lo de arriba sucede, la roca se torna color amarilla indicándole al jugador que esa roca va a caer dentro de la meta.

-Al embocar la roca en la meta, se ejecuta un sónido avisandole al jugador que la roca esta en la meta. 

-La cantidad de rocas que deben embocarse para que aparezca una moneda se pueden modificar.
#
*Caja-Resorte*

-Tiene un factor de rebote vertical; aquí se pueden asignar valores del 0 al 2. 

-> En el caso de ser 0, en cada rebote se pierde altura.

-> En el caso de ser 1, sigue con la misma altura que antes.

-> En el caso de ser 2, en cada rebote gana altura.

-Tiene un factor de rebote horizontal; aquí se pueden asignar valores del 0 al 2. 

-> En el caso de ser 0, en cada rebote se pierde velocidad.

-> En el caso de ser 1, sigue con la misma velocidad que antes.

-> En el caso de ser 2, en cada rebote gana velocidad.

-Los valores de los factores de rebote se pueden modificar.
#
*Guia*

-La guía aparece cuando el lanzador arroja la roca.

-Aparecerá en la posición donde caerá a la roca, esto le ayudará al jugador a saber donde va a tener que pararse para que rebote.

-La guía tiene una duración de 2 segundos, luego de ese tiempo, se eliminará.
#
*Niveles de dificultad*

-Dispone de 2 dificultades, fácil y difícil.

-Fácil: 

-> Las monedas tienen más duración.

-> Guía de donde van a caer las rocas.

-> Rocas menos veloces.

-Difícil: 

-> Las monedas tienen menos duración.

-> No hay guía de donde caerán las rocas.

-> Rocas mas veloces.
#
*Duración del nivel*

-Cuando el contador llega a 0, por mas que haya rocas en juego, se termina la partida.

-La duración del nivel se puede modificar.
#
*HUD*

-En la esquina superior izquierda se encuentra la cantidad de rocas obtenidas, estas aumentan cuando el heroe emboca una en la meta.

-En la esquina superior derecha se encuentra la cantidad de monedas obtenidas, estas aumentan cuando el heroe agarra una moneda.

-En la parte superior del medio se encuentra el tiempo restante del nivel.

-Cuando el nivel se reinicia, estos valores vuelven a su predeterminado.
#
*Música*

-Para el menú principal se utilizó el track *Guardia Millennial* del OST del Chrono Trigger [Snes].

-Para el nivel se utilizó el track *Tengu Man Stage* del OST del Megaman & Bass [Snes].

#
*Sonidos*

-Todos los sonidos son del *Sonic the Hedgehog 2* [Megadrive].

![image](https://user-images.githubusercontent.com/42523128/161629667-c85894ed-6ab6-4ae4-9dbc-8d39650944ee.png)

![image](https://user-images.githubusercontent.com/42523128/161629738-61863f9e-0cf0-4195-a0bf-2b792511484a.png)

![image](https://user-images.githubusercontent.com/42523128/161629796-418854ec-312c-4274-8fac-43c14ec672d6.png)

![image](https://user-images.githubusercontent.com/42523128/161630095-8a857344-41d0-4b05-a204-e68eeca7dd6b.png)

![image](https://user-images.githubusercontent.com/42523128/161630140-624ace72-2a55-4820-b632-565183ab15ce.png)


