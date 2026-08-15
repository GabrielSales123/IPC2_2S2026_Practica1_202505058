# Manual Técnico - Sistema de Gestión Veterinaria

## 1. Introducción

El presente manual técnico describe la estructura, funcionamiento e implementación del sistema de gestión veterinaria desarrollado en C#.

El sistema permite registrar y administrar diferentes tipos de mascotas mediante programación orientada a objetos. Para representar los animales se utiliza una clase base llamada `Mascota`, de la cual heredan las clases `Perro`, `Gato`, `Ave` y `Tortuga`.

La información de las mascotas se almacena mediante una estructura de lista enlazada utilizando las clases `Nodo` y `Lista`.

El proyecto aplica los principales conceptos de programación orientada a objetos:

- Abstracción.

- Herencia.

- Encapsulamiento.

- Polimorfismo.

Además, se utilizan constructores, métodos, propiedades, sobrescritura de métodos y estructuras de datos enlazadas.

---

# 2. Estructura general del proyecto

El sistema está organizado mediante diferentes clases que tienen responsabilidades específicas.

La relación principal entre las clases es:

```text
                         Mascota
                            |
          +-----------------+------------------+
          |          |             |            |
        Perro       Gato          Ave        Tortuga
                            |
                          Lista
                            |
                           Nodo
```

La clase `Mascota` contiene las características generales que comparten todos los animales.

Las clases `Perro`, `Gato`, `Ave` y `Tortuga` heredan de `Mascota` y agregan características específicas de cada tipo.

La clase `Nodo` permite almacenar una mascota dentro de una estructura enlazada.

La clase `Lista` administra los diferentes nodos y permite realizar operaciones sobre las mascotas registradas.

---

# 3. Clase Mascota

`Mascota` es la clase base del sistema.

Su función principal es representar las características que tienen en común todos los animales registrados en la veterinaria.

Entre los datos generales se encuentran:

- Nombre.

- Peso.

- Edad.

- Sexo.

- Propietario.

- Código.

- Estado de enfermedad.

La clase también proporciona métodos para modificar y consultar estos datos.

Una de las funciones principales de la clase es definir el comportamiento común para calcular la dosis.

```csharp
public abstract double CalcularDosis();
```

Al ser un método abstracto, las clases derivadas están obligadas a proporcionar su propia implementación.

---

# 4. Abstracción

La abstracción consiste en representar solamente las características y comportamientos esenciales de un objeto.

En el sistema, la abstracción se implementa mediante `Mascota`.

No todos los animales calculan su dosis de la misma manera, por lo que la clase base solamente establece que debe existir el método:

```csharp
public abstract double CalcularDosis();
```

La clase no necesita conocer la fórmula específica utilizada por cada animal.

Cada clase derivada determina su propio cálculo.

Por ejemplo:

```text
Perro    → peso × 30
Gato     → peso × 30 × 0.9
Ave      → peso × 30 × 0.5
Tortuga  → peso × 30 × 0.8
```

Esto permite definir una estructura general y dejar los detalles específicos a las clases derivadas.

---

# 5. Clase Perro

La clase `Perro` representa a las mascotas de tipo perro.

Hereda de `Mascota` mediante:

```csharp
public class Perro : Mascota
```

Por lo tanto, un perro posee todos los atributos generales de una mascota y además cuenta con información específica.

## 5.1 Atributos

Los atributos específicos de `Perro` son:

```csharp
private string raza { get; set; }
private string tamaño { get; set; }
```

Estos representan:

- `raza`: raza del perro.

- `tamaño`: tamaño del perro.

## 5.2 Métodos de acceso

Para consultar la información se utilizan métodos como:

```csharp
public string GetRaza()
{
    return raza;
}

public string GetTamaño()
{
    return tamaño;
}
```

Esto permite acceder a los datos sin exponer directamente la implementación interna.

## 5.3 Constructor

El constructor recibe los datos generales y específicos del perro.

```csharp
public Perro(
    String nombre,
    int peso,
    int edad,
    string sexo,
    string propietario,
    string codigo,
    bool enfermo,
    string raza,
    string tamaño)
```

Los datos generales son establecidos utilizando los métodos heredados de `Mascota`.

```csharp
this.SetNombre(nombre);
this.SetPeso(peso);
this.SetEdad(edad);
this.SetSexo(sexo);
this.SetPropietario(propietario);
this.SetCodigo(codigo);
this.SetEnfermo(enfermo);
```

Los datos específicos se almacenan mediante:

```csharp
this.raza = raza;
this.tamaño = tamaño;
```

---

# 6. Cálculo de dosis del Perro

La clase `Perro` sobrescribe el método `CalcularDosis()`:

```csharp
public override double CalcularDosis()
{
    return peso * 30;
}
```

La fórmula utilizada es:

```text
Dosis = peso × 30
```

Por ejemplo, si el perro pesa 20 kg:

```text
20 × 30 = 600
```

La dosis calculada será de 600 unidades según la unidad establecida por el sistema.

---

# 7. Clase Gato

La clase `Gato` representa a las mascotas de tipo gato.

Esta clase hereda de `Mascota`:

```csharp
public class Gato : Mascota
```

Por medio de la herencia, `Gato` recibe los atributos y métodos generales de `Mascota`.

Además, contiene los atributos particulares necesarios para representar las características propias de un gato.

Al igual que las demás clases derivadas, posee su propio constructor y sobrescribe el método `CalcularDosis()`.

---

# 8. Cálculo de dosis del Gato

El cálculo de dosis para un gato utiliza el 90 % de la dosis base.

La fórmula es:

```text
Dosis = peso × 30 × 0.9
```

La implementación mediante polimorfismo permite que `Gato` proporcione su propia versión de:

```csharp
public override double CalcularDosis()
```

Por ejemplo, para un gato de 10 kg:

```text
10 × 30 × 0.9 = 270
```

El resultado sería 270 unidades.

---

# 9. Clase Ave

La clase `Ave` representa las mascotas de tipo ave.

Hereda de la clase `Mascota`:

```csharp
public class Ave : Mascota
```

La clase contiene las características generales heredadas de `Mascota` y las características particulares necesarias para representar un ave.

El constructor permite inicializar la información correspondiente al animal.

La clase también sobrescribe el método:

```csharp
CalcularDosis()
```

para aplicar la fórmula correspondiente a este tipo de mascota.

---

# 10. Cálculo de dosis del Ave

Para las aves se utiliza el 50 % de la dosis base.

La fórmula es:

```text
Dosis = peso × 30 × 0.5
```

Por ejemplo, para un ave de 4 kg:

```text
4 × 30 × 0.5 = 60
```

La dosis calculada sería de 60 unidades.

---

# 11. Clase Tortuga

La clase `Tortuga` representa las mascotas de tipo tortuga.

Hereda de `Mascota`:

```csharp
public class Tortuga : Mascota
```

## 11.1 Atributos

La clase contiene:

```csharp
private string tipoCaparazon { get; set; }
private bool esAcuatica { get; set; }
```

Estos atributos representan:

- `tipoCaparazon`: tipo de caparazón de la tortuga.

- `esAcuatica`: indica si la tortuga es acuática.

## 11.2 Métodos de acceso

Para consultar el tipo de caparazón se utiliza:

```csharp
public string GetTipoCaparazon()
{
    return tipoCaparazon;
}
```

También existe un método para modificarlo:

```csharp
public void SetTipoCaparazon(string valor)
{
    tipoCaparazon = valor;
}
```

Para consultar si es acuática:

```csharp
public string GetEsAcuatica()
{
    if (esAcuatica == true)
    {
        return "✓";
    }
    else
    {
        return "X";
    }
}
```

Este método transforma el valor booleano en una representación visual.

---

# 12. Constructor de Tortuga

El constructor recibe la información general y específica:

```csharp
public Tortuga(
    String nombre,
    int peso,
    int edad,
    string sexo,
    string propietario,
    string codigo,
    bool enfermo,
    String tipoCaparazon,
    bool esAcuatica)
```

Los datos generales se establecen mediante los métodos de `Mascota`:

```csharp
this.SetNombre(nombre);
this.SetPeso(peso);
this.SetEdad(edad);
this.SetSexo(sexo);
this.SetPropietario(propietario);
this.SetCodigo(codigo);
this.SetEnfermo(enfermo);
```

Los atributos propios de la tortuga se establecen mediante:

```csharp
this.tipoCaparazon = tipoCaparazon;
this.esAcuatica = esAcuatica;
```

---

# 13. Cálculo de dosis de la Tortuga

La clase `Tortuga` sobrescribe `CalcularDosis()`:

```csharp
public override double CalcularDosis()
{
    return peso * 30 * 0.8;
}
```

La fórmula utilizada es:

```text
Dosis = peso × 30 × 0.8
```

Por ejemplo, para una tortuga de 5 kg:

```text
5 × 30 × 0.8 = 120
```

La dosis calculada sería de 120 unidades.

---

# 14. Tabla de cálculo de dosis

| Tipo de mascota | Fórmula           |
| --------------- | ----------------- |
| Perro           | `peso × 30`       |
| Gato            | `peso × 30 × 0.9` |
| Ave             | `peso × 30 × 0.5` |
| Tortuga         | `peso × 30 × 0.8` |

Cada clase implementa la fórmula correspondiente mediante la sobrescritura de `CalcularDosis()`.

---

# 15. Herencia

La herencia permite que una clase reutilice atributos y métodos de otra clase.

En el sistema se utiliza una relación de herencia entre `Mascota` y las clases:

```text
Mascota
├── Perro
├── Gato
├── Ave
└── Tortuga
```

Por ejemplo:

```csharp
public class Perro : Mascota
```

indica que `Perro` hereda de `Mascota`.

Esto evita tener que volver a declarar en cada clase atributos como:

- Nombre.

- Peso.

- Edad.

- Sexo.

- Propietario.

- Código.

- Estado de enfermedad.

La información común se mantiene en la clase base.

---

# 16. Encapsulamiento

El encapsulamiento consiste en proteger los datos internos de las clases.

En el proyecto se utilizan atributos privados y métodos para acceder o modificar la información.

Por ejemplo:

```csharp
private string raza { get; set; }
```

El atributo `raza` se encuentra encapsulado dentro de `Perro`.

Para obtener su valor:

```csharp
public string GetRaza()
{
    return raza;
}
```

La clase `Mascota` también utiliza métodos como:

```csharp
SetNombre()
SetPeso()
SetEdad()
SetSexo()
SetPropietario()
SetCodigo()
SetEnfermo()
```

Estos métodos permiten controlar la modificación de los datos.

---

# 17. Polimorfismo

El polimorfismo permite que un mismo método tenga diferentes comportamientos dependiendo del objeto que lo utilice.

En el proyecto se implementa mediante:

```csharp
public override double CalcularDosis()
```

Cada clase derivada proporciona una implementación diferente.

```text
Perro:
peso × 30

Gato:
peso × 30 × 0.9

Ave:
peso × 30 × 0.5

Tortuga:
peso × 30 × 0.8
```

Por ejemplo:

```csharp
Mascota mascota1 = new Perro(...);
Mascota mascota2 = new Gato(...);
Mascota mascota3 = new Ave(...);
Mascota mascota4 = new Tortuga(...);
```

Aunque todas las variables son de tipo `Mascota`, cada objeto conserva su comportamiento específico.

Al ejecutar:

```csharp
mascota1.CalcularDosis();
mascota2.CalcularDosis();
mascota3.CalcularDosis();
mascota4.CalcularDosis();
```

se ejecuta automáticamente la versión correspondiente a cada clase.

---

# 18. Clase Nodo

La clase `Nodo` representa un elemento individual dentro de la lista enlazada.

La implementación contiene:

```csharp
public class Nodo
{
    public Mascota mascota { get; set; }
    public Nodo? siguiente { get; set; }
    public Nodo? anterior { get; set; }

    public Nodo(Mascota mascota)
    {
        this.mascota = mascota;
        this.siguiente = null;
        this.anterior = null;
    }
}
```

---

# 19. Componentes de Nodo

La clase contiene tres propiedades principales.

## 19.1 Mascota

```csharp
public Mascota mascota { get; set; }
```

Almacena la mascota correspondiente al nodo.

Debido al polimorfismo, puede almacenar objetos de tipo:

- `Perro`.

- `Gato`.

- `Ave`.

- `Tortuga`.

Esto es posible porque todas estas clases heredan de `Mascota`.

## 19.2 Siguiente

```csharp
public Nodo? siguiente { get; set; }
```

Contiene una referencia al siguiente nodo.

## 19.3 Anterior

```csharp
public Nodo? anterior { get; set; }
```

Contiene una referencia al nodo anterior.

Al utilizar ambas referencias, se puede construir una lista doblemente enlazada.

---

# 20. Funcionamiento de la lista doblemente enlazada

La estructura puede representarse como:

```text
NULL
  |
  v
[Nodo 1] <-> [Nodo 2] <-> [Nodo 3]
  |             |             |
Mascota       Mascota       Mascota
  |
  +------------------------------> NULL
```

Cada nodo conoce al nodo siguiente y al anterior.

Esto permite recorrer la estructura en ambas direcciones.

El primer nodo normalmente tiene:

```csharp
anterior = null;
```

Mientras que el último nodo tiene:

```csharp
siguiente = null;
```

---

# 21. Clase Lista

La clase `Lista` es la encargada de administrar los nodos que contienen las mascotas.

Su función es proporcionar las operaciones necesarias para trabajar con la colección de animales.

Entre las operaciones principales se encuentran:

- Agregar mascotas.

- Recorrer la lista.

- Mostrar mascotas.

- Buscar mascotas.

- Eliminar mascotas, si está implementado.

- Consultar información.

- Modificar información.

- Manejar el primer y último nodo.

La clase `Lista` trabaja directamente con objetos `Nodo`.

---

# 22. Relación entre Lista y Nodo

La relación entre las dos clases puede representarse de la siguiente forma:

```text
Lista
  |
  v
Nodo <-> Nodo <-> Nodo <-> Nodo
 |       |       |       |
Mascota Mascota Mascota Mascota
 |       |       |       |
Perro   Gato    Ave   Tortuga
```

La clase `Lista` administra la estructura.

Los `Nodo` almacenan los objetos.

Las clases derivadas de `Mascota` representan los animales.

---

# 23. Agregar una mascota a la lista

Cuando se registra una nueva mascota, se crea un nodo que contiene el objeto.

Conceptualmente:

```csharp
Mascota mascota = new Perro(...);

Nodo nuevo = new Nodo(mascota);
```

Posteriormente, el nodo se conecta con la estructura existente.

Si la lista está vacía, el nuevo nodo se convierte en el primer elemento.

Si la lista ya contiene elementos, se conecta después del último nodo.

---

# 24. Recorrido de la lista

Para mostrar las mascotas registradas, la lista puede recorrer los nodos desde el primero hasta llegar a `null`.

El proceso conceptual es:

```text
Inicio
  |
  v
Nodo 1
  |
  v
Nodo 2
  |
  v
Nodo 3
  |
  v
NULL
```

En cada nodo se puede acceder a:

```csharp
nodo.mascota
```

y obtener la información correspondiente.

Debido al polimorfismo, la mascota puede ser un perro, gato, ave o tortuga.

---

# 25. Búsqueda de mascotas

La búsqueda permite localizar una mascota utilizando un dato identificador, como su código.

El procedimiento general consiste en:

1. Comenzar desde el primer nodo.

2. Obtener la mascota almacenada.

3. Comparar el código.

4. Si coincide, se devuelve o muestra la mascota.

5. Si no coincide, se pasa al siguiente nodo.

6. El proceso continúa hasta encontrar el registro o llegar a `null`.

Representación:

```text
[Nodo 1] -> [Nodo 2] -> [Nodo 3] -> NULL
    |           |           |
   P001        P002        P003
                            ^
                            |
                       Buscar P003
```

---

# 26. Cambio del estado de salud

El sistema utiliza el atributo que representa si la mascota se encuentra enferma.

El estado puede ser modificado utilizando el método correspondiente de `Mascota`.

Por ejemplo:

```csharp
SetEnfermo(true);
```

indica que la mascota está enferma.

Mientras:

```csharp
SetEnfermo(false);
```

indica que la mascota no está enferma.

Esto permite actualizar el estado de salud de los animales registrados.

---

# 27. Constructores

Cada clase de mascota utiliza un constructor para inicializar sus datos.

El constructor recibe los parámetros necesarios y asigna los valores correspondientes.

Por ejemplo, `Perro` recibe:

```text
Nombre
Peso
Edad
Sexo
Propietario
Código
Estado de enfermedad
Raza
Tamaño
```

Mientras que `Tortuga` recibe:

```text
Nombre
Peso
Edad
Sexo
Propietario
Código
Estado de enfermedad
Tipo de caparazón
Si es acuática
```

Los constructores permiten crear objetos completamente inicializados desde el momento de su creación.

---

# 28. Ejemplo de creación de una mascota

Un perro puede crearse mediante:

```csharp
Perro perro = new Perro(
    "Max",
    20,
    5,
    "M",
    "Juan",
    "P001",
    false,
    "Labrador",
    "Grande"
);
```

Posteriormente puede almacenarse en un nodo:

```csharp
Nodo nodo = new Nodo(perro);
```

Y finalmente el nodo puede agregarse a la lista.

---

# 29. Uso del polimorfismo con la lista

Una de las ventajas de utilizar `Mascota` como tipo base es que la lista no necesita tener una estructura diferente para cada animal.

Por ejemplo:

```text
Lista
 |
 +-- Nodo -> Perro
 |
 +-- Nodo -> Gato
 |
 +-- Nodo -> Ave
 |
 +-- Nodo -> Tortuga
```

Todos los nodos almacenan:

```csharp
Mascota mascota
```

pero el objeto real puede pertenecer a cualquiera de las clases derivadas.

Esto simplifica considerablemente la administración de los registros.

---

# 30. Flujo general del sistema

El funcionamiento general del programa puede resumirse de la siguiente manera:

```text
Inicio
  |
  v
Menú principal
  |
  +--> Registrar mascota
  |       |
  |       v
  |   Seleccionar tipo
  |       |
  |   +---+---+---+
  |   |   |   |   |
  |  Perro Gato Ave Tortuga
  |       |
  |       v
  |     Nodo
  |       |
  |       v
  |      Lista
  |
  +--> Mostrar mascotas
  |
  +--> Buscar mascota
  |
  +--> Modificar estado
  |
  +--> Calcular dosis
  |
  +--> Salir
```

---

# 31. Responsabilidad de cada clase

| Clase     | Responsabilidad                                                |
| --------- | -------------------------------------------------------------- |
| `Mascota` | Contener la información y comportamiento común de las mascotas |
| `Perro`   | Representar perros y calcular su dosis específica              |
| `Gato`    | Representar gatos y calcular su dosis específica               |
| `Ave`     | Representar aves y calcular su dosis específica                |
| `Tortuga` | Representar tortugas y calcular su dosis específica            |
| `Nodo`    | Almacenar una mascota y enlazarla con otros nodos              |
| `Lista`   | Administrar los nodos y las mascotas registradas               |
| `Program` | Ejecutar el programa y controlar el flujo principal            |

---

# 32. Conceptos de programación orientada a objetos utilizados

## Abstracción

Se utiliza mediante `Mascota` y el método abstracto `CalcularDosis()`.

```csharp
public abstract double CalcularDosis();
```

Permite definir un comportamiento común sin especificar la implementación de cada especie.

## Herencia

Se utiliza mediante:

```csharp
Perro : Mascota
Gato : Mascota
Ave : Mascota
Tortuga : Mascota
```

Permite reutilizar atributos y métodos de la clase base.

## Encapsulamiento

Se implementa mediante atributos privados y métodos de acceso.

```csharp
private string raza { get; set; }
```

y:

```csharp
public string GetRaza()
{
    return raza;
}
```

## Polimorfismo

Se implementa mediante `override`:

```csharp
public override double CalcularDosis()
```

Cada clase derivada proporciona su propio comportamiento.

---

# 33. Ventajas de la implementación

La estructura utilizada presenta varias ventajas.

### Reutilización

Los atributos comunes se implementan una sola vez en `Mascota`.

### Organización

Cada clase tiene una responsabilidad específica.

### Extensibilidad

Es posible agregar nuevas especies creando nuevas clases que hereden de `Mascota`.

Por ejemplo:

```csharp
public class Conejo : Mascota
{
    // Implementación específica
}
```

### Mantenimiento

Las modificaciones específicas de un tipo de mascota pueden realizarse en su propia clase sin afectar necesariamente a las demás.

### Polimorfismo

La lista puede trabajar con diferentes tipos de animales utilizando la referencia común `Mascota`.

---

# 34. Ejemplo de funcionamiento completo

Un flujo completo sería:

```text
1. El usuario selecciona registrar mascota.

2. Selecciona el tipo de animal.

3. Se solicitan los datos generales.

4. Se solicitan los datos específicos del animal.

5. Se crea el objeto correspondiente.

6. El objeto se almacena dentro de un Nodo.

7. El Nodo se agrega a la Lista.

8. La mascota queda registrada.

9. El usuario puede consultar la lista.

10. El sistema puede buscar la mascota por código.

11. El sistema puede consultar su estado.

12. El sistema puede calcular la dosis utilizando
    el método correspondiente al tipo de mascota.
```

---

# 35. Conclusión

El sistema de gestión veterinaria utiliza una arquitectura basada en programación orientada a objetos para representar y administrar diferentes tipos de mascotas.

La clase `Mascota` funciona como clase base y contiene las características comunes. Las clases `Perro`, `Gato`, `Ave` y `Tortuga` utilizan herencia para reutilizar dichas características y agregan comportamientos específicos.

El encapsulamiento permite proteger los datos internos mediante atributos privados y métodos de acceso. La abstracción permite establecer comportamientos generales como `CalcularDosis()`, mientras que el polimorfismo permite que cada tipo de mascota implemente su propio cálculo.

Las clases `Nodo` y `Lista` permiten almacenar y administrar las mascotas mediante una estructura enlazada. Gracias a que los nodos almacenan objetos de tipo `Mascota`, es posible administrar perros, gatos, aves y tortugas dentro de la misma estructura.

De esta manera, el proyecto integra programación orientada a objetos y estructuras de datos en un sistema que permite registrar, almacenar, consultar y administrar información de mascotas de una veterinaria.
