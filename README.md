# Práctica 1 - Introducción a Unity
## Ejecución
!gif/ejecucion.gif
## Descripción del trabajo
Como objetos 3D básicos, se han añadido un cubo y una esfera, a los que además de asignarles un material, se les ha agregado la componente de *Rigidbody* para que caigan y comprobar así su desplazamiento durante la ejecución.

Para el objeto libre de la *Asset Store*, se ha descargado un paquete con varios elementos (*Fantasy Landscape*). De este paquete se han añadido los prefabs: una roca, una carreta y varias setas. Como se han añadido varias setas, se han metido dentro de un objeto vacío que facilita el trabajo de cualquier modificación.

Se ha creado el terreno y probado algunas herramientas como extenderlo, modificarlo con distintas brochas y asignarle textura. Para estas texturas y añadirle un par de herramientas más, se ha incluido un paquete de terrenos (*Terrain Sample Asset Pack*).

Se añade el paquete de *Starter Assets* de Third Person y se incluye uno de los prefabs, una armadura del personaje, y se le asigna un material.

Para lograr el objetivo de las posiciones, se crea un script en el que dentro de la función de actualización se obtiene la etiqueta asignada a cada objeto y su posición en cada 'escena', y se muestra por consola ambas cosas. El script ha sido asignado a cada objeto como un nuevo componente.
