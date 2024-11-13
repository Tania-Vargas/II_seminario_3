# Seminario 3: Mundos virtuales. Introducción a la programación de gráficos 3D.
## Pregunta 1. Qué funciones se pueden usar en los scripts de Unity para llevar a cabo traslaciones, rotaciones y escalados.
En Unity, para manejar las transformaciones básicas como traslación, rotación y escalado de objetos en un script de C#, se utilizan principalmente los métodos de la clase `Transform`, asociada a cada GameObject en la escena. A continuación se detallan las funciones más comunes:
#### Traslación (Movimiento)
* `transform.Translate(Vector3 translation)`: Mueve el objeto en la dirección y magnitud especificadas por el vector translation.
* `transform.position`: Ajustando esta propiedad, se cambia directamente la posición global del objeto en el espacio 3D.
* `transform.localPosition`: Permite modificar la posición en relación con su padre.
#### Rotación
* `transform.Rotate(Vector3 eulerAngles)`: Rota el objeto basado en los ángulos de Euler especificados.
* `transform.rotation`: Permite establecer la rotación absoluta en términos de Quaternion, útil para rotaciones suaves y precisas.
* `transform.RotateAround(Vector3 point, Vector3 axis, float angle)`: Rota el objeto alrededor de un punto específico (point) sobre un eje dado (axis) a un ángulo determinado.
#### Escalado
* `transform.localScale`: Modifica el tamaño del objeto en el espacio local ajustando esta propiedad de escala.
## Pregunta 2. Cómo trasladarías la cámara 2 metros en cada uno de los ejes y luego la rotas 30º alrededor del eje Y?. Rota la cámara alrededor del eje Y 30ª y desplázala 2 metros en cada uno de los ejes. ¿Obtendrías el mismo resultado en ambos casos?. Justifica el resultado.
## Pregunta 3. Sitúa la esfera de radio 1 en el campo de visión de la cámara y configura un volumen de vista que la recorte parcialmente.
## Pregunta 4. Sitúa la esfera de radio 1 en el campo de visión de la cámara y configura el volumen de vista para que la deje fuera de la vista.
## Pregunta 5. Cómo puedes aumentar el ángulo de la cámara. Qué efecto tiene disminuir el ángulo de la cámara
## Pregunta 6. Es correcta la siguiente afirmación: Para realizar la proyección al espacio 2D, en el inspector de la cámara, cambiaremos el valor de projection, asignándole el valor de orthographic
## Pregunta 7. Especifica las rotaciones que se han indicado en los ejercicios previos con la utilidad quaternion
## Pregunta 8. ¿Cómo puedes averiguar la matriz de proyección en perspectiva que se ha usado para proyectar la escena al último frame renderizado?
## Pregunta 9. ¿Cómo puedes averiguar la matriz de proyección en perspectiva ortográfica que se ha usado para proyectar la escena al último frame renderizado?
## Pregunta 10. ¿Cómo puedes obtener la matriz de transformación entre el sistema de coordenadas local y el mundial?
## Pregunta 11. ¿Cómo puedes obtener la matriz para cambiar al sistema de referencia de vista?
## Pregunta 12. Especifica la matriz de la proyección usado en un instante de la ejecución del ejercicio 1 de la práctica 1.
## Pregunta 13. Especifica la matriz de modelo y vista de la escena del ejercicio 1 de la práctica 1.
## Pregunta 14. Aplica una rotación en el start de uno de los objetos de la escena y muestra la matriz de cambio al sistema de referencias mundial
## Pregunta 15. ¿Cómo puedes calcular las coordenadas del sistema de referencia de un objeto con las siguientes propiedades del Transform? Position (3, 1, 1), Rotation (45, 0, 45)
## Pregunta 16. Investiga sobre los modelo de iluminación que aplica Unity y resume las relaciones existentes con el modelo explicado en clase.
## Pregunta 17. Indica las funciones de la API de Unity más importantes respecto a la iluminación
