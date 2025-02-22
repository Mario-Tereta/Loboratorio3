# Laboratorio 3 - Programación 1

## Facultad de Ingeniería en Sistemas de Información y Ciencias de la Computación
**Universidad Mariano Gálvez de Guatemala**  
**Fecha:** 21 de febrero de 2025  

### Estudiantes:
- **Mario David Tereta Sapalun** - Carné: 0905-15-14297
- **Lester David Payes Méndez** - Carné: 0905-24-22750

---

## Debate y Análisis del Programa

### **Tareas Repetitivas y Uso de Funciones**
Se decidió utilizar una función llamada `linea1()`, ya que es una acción que se repite muchas veces en el programa. Esta función permite leer un dato numérico de tipo `double`, validando que la entrada sea correcta. Para datos enteros, simplemente se convierte el resultado en `int`. Esto evita la redundancia de código y mejora la legibilidad.

### **Variables Globales vs Locales**
En el programa, las listas `estudiantes` y `calificaciones` son variables globales dentro de la clase `Program`, lo que permite su acceso desde cualquier función estática dentro de la clase, como el método `Main()`. Las funciones `AddStudent()`, `ListStudent()`, entre otras, manejan variables locales dentro de su ámbito, lo que evita modificaciones no deseadas de variables globales y mejora la organización.

### **Modularización del Código**
Para mejorar la claridad del código, se dividió en funciones específicas para cada operación:
- `AddStudent()`
- `ListStudent()`
- `PromCal()`
- `MaxCal()`

Esta modularización facilita la comprensión y mantenimiento del código, reduciendo la redundancia.

### **Uso de `switch` en lugar de `if` en el Menú**
Se optó por usar una estructura `switch` en lugar de `if`, ya que mejora la organización del flujo de ejecución y facilita la adición de nuevas opciones en el futuro.

### **Uso de `Console.Clear()` y `Console.ReadKey();`**
- `Console.Clear();` mejora la estética del programa limpiando la consola entre ejecuciones de funciones.
- `Console.ReadKey();` evita que la salida desaparezca inmediatamente, permitiendo al usuario revisar la información antes de continuar.

### **Optimización de `WriteLine()` en el Menú**
Se usó una sola llamada a `Console.WriteLine()` con caracteres especiales (`\n`) para mejorar la estética del menú, en lugar de múltiples llamadas.

---

## **Definiciones y Preguntas**

1. **Variables Globales vs Locales**  
   - **Globales:** `estudiantes` y `calificaciones`, porque se usan en varias funciones.
   - **Locales:** Variables dentro de `AddStudent()` y `ListStudent()`, ya que solo son relevantes dentro de esas funciones.

2. **Datos que deben ser compartidos entre funciones**  
   - Las listas `estudiantes` y `calificaciones`, ya que contienen la información principal del programa.

3. **Datos relevantes solo dentro de una función**  
   - Variables locales en funciones como `AddStudent()`, que no afectan otras partes del programa.

4. **Ventajas de dividir el código en funciones**  
   - Mejora la organización.
   - Facilita la comprensión y mantenimiento.
   - Evita redundancias.
   - Facilita el trabajo colaborativo.

5. **Importancia de limitar variables globales**  
   - Evita modificaciones accidentales.
   - Reduce errores imprevistos.
   - Mejora el control y organización del código.

6. **Mejorar la legibilidad del código**  
   - Seguir un estilo de escritura uniforme (CamelCase o snake_case).
   - Usar nombres de variables claros.
   - Incluir comentarios explicativos.
   - Mantener el código organizado y sencillo.

---

## **Conclusión**
El programa se organizó de manera modular para mejorar su comprensión y mantenimiento. La correcta implementación de funciones y variables locales redujo la redundancia y facilitó el control del flujo del programa. Además, el uso de `switch` optimizó la gestión del menú y se implementaron mejoras estéticas en la salida de la consola. Gracias a esto, el código es más profesional, claro y preparado para futuras ampliaciones.

