##  Escribiendo letras y palabras en C# con POO

Los temas de aprendizaje con el curso 20483 ponen a la POO (Programación Orientada a Objetos) como el principal paradigma para el uso de C#.

Ampliando la tarea de la escritura de letras en c#, donde cada uno realizó una escritura de las dos letras para poder luego pasarla a una funcionalidad donde se incluyo la escritura de palabras.

Ahora realizaremos una mejora (versión 2.0) a esta tarea.

### Objetivo

Reehacer el programa de letras utilizando POO.

### Asignacion de Letras

Nueva asignación de letras realizadas por persona

| Nombre                               | Letra | Letra | Letra |
| ------------------------------------ | ----- | ----- | ----- |
| Alcaide  Fernández, Inocente         | U     | X     |       |
| Cabrero Luengo, Miguel Ángel         | D     | N     | M     |
| Casais Recondo, Carola               | G     | F     | H     |
| Castillo Villarino, José Carlos      | I     | R     | Y     |
| De Vega Ampudia, Sergio              | C     | O     |       |
| Diaz Fernandez, Juan Ramon (*)       |       |       |       |
| Fuentes, José                        | K     | W     |       |
| Garcia Elez, Daniel                  | J     | A     |       |
| Garrido Herrador, Justo Antonio (**) |       |       |       |
| Moreno Quevedo, Francisco Javier     | V     | Z     | Ñ     |
| Rodríguez Cruz, Luis Miguel          | E     | P     | Q     |
| Salvador Román, Juan José            | S     | B     |       |
| Tejero Calderera, José Vicente       | T     | L     |       |

(*) Implementará la clase abstracta

(**) Implementará la clase abstracta de Gestion Letras 

### Requerimientos

1 - Creación de clase abstracta para la definicion del comportamiento de las clases derivadas de letras, que representarán cada letra del albafeto español. Estas clases herededas de la clase abstracta, deberán ser realizadas por cada uno según la asignación de la tabla anterior. Una clase por letra.

Cada clase de letra heredada, de la clase abstracta, deberá sobre escribir los métodos marcados como abstracts para su especialización y desarrollo.

Deberá utilizar un enum para identificar por cada clase el nombre de la letra.

Podrán utilizarse extensiones de la clase si se desea.

2 - Creación de clase abstracta para la definición del comportamiento de la clase derivada de gestión letras, cuya funcionalidad incluirá las clases letras y implementará el leer las palabras del teclado (o consola). Según cada palabra deberá imprimir en un método las letras que encuentre en el diccionario o equivalente, las letras que no encuentre deberán aparecer en blanco.

Deberán utilizar listas genericas en lugar de arreglos de string para la carga de todas las letras. Recomendado el uso de Dictionary<T,T>

Solo mostrará por consola las palabras en mayusculas aunque se entren en minusculas.

## Instrucciones generales

Todos los participantes deberán recibir la clase abstracta y la clase base de Gestión palabras, deberán tener una version funcional que imprima sus letras.



![](D:\BMV\20483C\Ejercicios\LetrasPOO\img\clases.png)

### Fecha de revision y entrega

El resultado de este ejercicio lo discutiremos el dia miercoles 4 de noviembre.



