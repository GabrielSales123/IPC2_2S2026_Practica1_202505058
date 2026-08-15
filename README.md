## 🐾 Sistema de Veterinaria

Sistema de gestión de mascotas desarrollado en **C#** como aplicación de consola. El proyecto aplica los principales conceptos de **Programación Orientada a Objetos (POO)**: abstracción, encapsulamiento, herencia y polimorfismo.

El sistema permite registrar mascotas, consultar información de pacientes, cambiar su estado de salud, calcular dosis de medicamento y mostrar las mascotas registradas.

## 📋 Descripción

La aplicación representa un sistema básico para la administración de pacientes de una veterinaria.

Se utiliza una clase base `Mascota` para representar las características comunes de los animales y diferentes clases derivadas para representar los tipos específicos de mascotas:

- 🐶 `Perro`

- 🐱 `Gato`

- 🐦 `Ave`

- 🐢 `Tortuga`

La práctica solicita que estos tipos de mascotas hereden de una clase base y que cada uno pueda tener características y comportamientos específicos.

## ⚙️ Funcionalidades

El programa cuenta con un menú interactivo en consola con las siguientes opciones:

1. **Registrar mascota**
   
   - Permite registrar un nuevo paciente.
   
   - Solicita información general como:
     
     - Nombre
     
     - Peso
     
     - Edad
     
     - Sexo
     
     - Propietario
     
     - Estado de salud
     
     - Tipo de mascota
   
   - Dependiendo del tipo de animal, solicita información adicional.

2. **Consultar mascota**
   
   - Permite buscar una mascota utilizando su código.
   
   - Muestra la información correspondiente al paciente.

3. **Cambiar estado de paciente**
   
   - Permite cambiar el estado de salud de una mascota.
   
   - El estado puede cambiar entre enfermo y sano.

4. **Calcular dosis de medicamento**
   
   - Busca una mascota mediante su código.
   
   - Muestra su peso.
   
   - Calcula la dosis correspondiente utilizando el método `CalcularDosis()`.

5. **Mostrar información de las mascotas**
   
   - Muestra las mascotas que se encuentran registradas en el sistema.

6. **Salir**
   
   - Finaliza la ejecución del programa.

El menú permanece activo hasta que el usuario selecciona la opción de salir, cumpliendo con el funcionamiento solicitado para la aplicación.

## 🧱 Estructura del proyecto

El proyecto está compuesto por diferentes clases que representan los elementos principales del sistema.

### `Mascota`

Es la clase base que representa a un paciente de la veterinaria.

Contiene los datos comunes de las mascotas, como:

- Nombre

- Peso

- Edad

- Sexo

- Propietario

- Código

- Estado de salud

También contiene métodos generales que pueden ser utilizados o sobrescritos por las clases derivadas.

### `Perro`

Hereda de `Mascota` y agrega información específica de los perros:

- Raza

- Tamaño

### `Gato`

Hereda de `Mascota` y agrega información específica de los gatos:

- Raza

- Estado de esterilización

### `Ave`

Hereda de `Mascota` y agrega información específica de las aves:

- Envergadura

- Capacidad de volar

### `Tortuga`

Hereda de `Mascota` y agrega información específica de las tortugas:

- Tipo de caparazón

- Si es acuática

### `ListaMascotas`

Se encarga de administrar las mascotas registradas en el sistema.

Entre sus funciones se encuentran:

- Agregar mascotas.

- Consultar mascotas.

- Buscar mascotas.

- Mostrar las mascotas registradas.

- Contabilizar mascotas.

### `Program`

Contiene el método `Main()` y funciona como punto de entrada de la aplicación.

También contiene el menú principal y controla la interacción entre el usuario y el sistema.

## 🧠 Conceptos de Programación Orientada a Objetos

El proyecto fue desarrollado aplicando los cuatro pilares principales de la Programación Orientada a Objetos.

### Abstracción

Se utiliza una clase base `Mascota` para representar las características y comportamientos comunes de los pacientes de la veterinaria.

Esto permite trabajar con un concepto general de mascota sin depender inicialmente de un tipo específico de animal.

La práctica solicita explícitamente la creación de una clase base y la aplicación del concepto de abstracción.

### Herencia

Las clases:

```text
Perro
Gato
Ave
Tortuga
```

heredan de:

```text
Mascota
```

De esta manera reutilizan los atributos y métodos comunes de la clase base y agregan sus propias características.

La rúbrica de la práctica evalúa específicamente la correcta implementación de herencia en atributos y métodos.

### Encapsulamiento

Los datos de las mascotas se manejan mediante atributos privados y métodos de acceso como getters y setters.

Por ejemplo, en `Program` se utilizan métodos como:

```csharp
tempMascota.GetNombre();
tempMascota.GetPeso();
tempMascota.GetEnfermo();
tempMascota.SetEnfermo(...);
```

Esto permite controlar el acceso y modificación de la información de los objetos.

### Polimorfismo

El método:

```csharp
CalcularDosis()
```

puede presentar un comportamiento diferente dependiendo del tipo de mascota.

De esta manera, una mascota puede calcular su dosis de acuerdo con las características de su especie.

La práctica establece que el polimorfismo debe implementarse mediante la sobrescritura de métodos para representar diferentes comportamientos.

## 💊 Cálculo de dosis

Cada tipo de mascota utiliza un comportamiento diferente para calcular la dosis.

Según el enunciado de la práctica:

| Mascota    | Ajuste de dosis |
| ---------- | --------------- |
| 🐶 Perro   | 100 %           |
| 🐱 Gato    | 90 %            |
| 🐦 Ave     | 50 %            |
| 🐢 Tortuga | 80 %            |

Los factores permiten que el cálculo pueda variar dependiendo de la clase de mascota.

## 🖥️ Requisitos

Para ejecutar el programa se necesita:

- **Sistema operativo:** Windows, Linux o macOS.

- **.NET SDK** compatible con el proyecto.

- Un editor o IDE compatible con C#, por ejemplo:
  
  - Visual Studio
  
  - Visual Studio Code
  
  - JetBrains Rider

- Terminal o consola.

El programa **no necesita conexión a Internet para funcionar** una vez que el proyecto y el SDK estén instalados.

## 🚀 Ejecución

### 1. Instalar .NET SDK

Instalar el **.NET SDK** correspondiente a la versión utilizada por el proyecto.

Para comprobar que .NET está instalado, abrir una terminal y ejecutar:

```bash
dotnet --version
```

Si se muestra un número de versión, el SDK está instalado correctamente.

### 2. Clonar el repositorio

Desde una terminal:

```bash
git clone URL_DEL_REPOSITORIO
```

Después entrar a la carpeta del proyecto:

```bash
cd NOMBRE_DEL_PROYECTO
```

### 3. Restaurar las dependencias

Ejecutar:

```bash
dotnet restore
```

### 4. Compilar el proyecto

Ejecutar:

```bash
dotnet build
```

Si no aparecen errores, el proyecto fue compilado correctamente.

### 5. Ejecutar

Finalmente:

```bash
dotnet run
```

Se mostrará el menú principal de la veterinaria:

```text
============Veterinaria============
Bienvenido a la Veterinaria
Seleccione una opción:
1. Registrar mascota
2. Consultar mascota
3. Cambiar estado de paciente
4. Calcular dosis de medicamento
5. Mostrar información de las mascotas
6. Salir
====================================
```

## 🐾 Ejemplo de mascotas iniciales

El programa inicia con algunas mascotas de prueba:

- **Firulais** — Perro Labrador

- **Rex** — Perro Boxer

- **Luna** — Gato Siamés

También existen ejemplos preparados para agregar aves y tortugas.

## 📁 Tecnologías utilizadas

- **Lenguaje:** C#

- **Framework:** .NET

- **Tipo de aplicación:** Consola

- **Paradigma:** Programación Orientada a Objetos

- **Control de versiones:** Git / GitHub

La práctica establece que la aplicación debe ejecutarse en consola y utilizar C#.

## 🎯 Objetivo académico

El objetivo del proyecto es aplicar los fundamentos de Programación Orientada a Objetos mediante el desarrollo de un sistema de veterinaria que permita administrar diferentes tipos de mascotas.

El proyecto busca demostrar el uso de:

- Abstracción

- Encapsulamiento

- Herencia

- Polimorfismo

Estos conceptos forman parte de los criterios de evaluación de la práctica.

## 👨‍💻 Autor

Gabriel Sales

Carné: 202505058

**Proyecto académico — Sistema de Veterinaria en C#**

Desarrollado como parte de la práctica de Programación Orientada a Objetos.