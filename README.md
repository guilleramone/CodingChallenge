
# InvertirOnline.com Coding Challenge

Bienvenido!

Nos encontramos en la búsqueda de desarrolladores .NET para que se incorporen a nuestro equipo. Después de múltiples procesos de selección, llegamos a la conclusión de que el código habla por si mismo. Con lo cual si te sentís dispuesto a afrontar el desafío, por favor tomate un rato para jugar con el problema y resolverlo.

### Cómo participar del proceso?

Abajo detallamos el problema a resolver, cuando consideres que está resuelto, **no** envíes pull request. Envía un mail a busquedas.it@invertironline.com con el link a tu fork, y si tenés algún comentario sobre tu implementación, también podés agregarlo ahí.

### Comenzando

El repositorio en el cual te encontrás tiene sólo un par de cosas. Para resolver el problema y levantar la app necesitás:
  
  * .NET Framework 4.6.2
  * Visual Studio 2015 en adelante
  * Forkear este repositorio y armar un nuevo branch.

### El problema

La idea sería poder desarrollar un formulario en donde el usuario pueda ingresar distintas formas geométricas, junto con la longitud del lado (o los lados), y que una vez que haya finalizado de ingresar datos el sistema prepare un reporte con el resumen de lo ingresado (en un idioma a seleccionar por el usuario), sumándole unos cálculos sobre las áreas y perímetros de estas formas. Este reporte ya está codificado en el método Imprimir(), con esta firma:

```csharp
public static string Imprimir(List<FormaGeometrica> formas, int idioma)
```

Al mismo tiempo, encontramos muy díficil el poder agregar o bien una nueva forma geométrica, o imprimir el reporte en otro idioma. Nos gustaría poder dar soporte para que el usuario pueda agregar otros tipos de formas (trapecios o rectángulos por ejemplo), u obtener el reporte en otros idiomas, pero escalar es muy dificultoso. ¿Nos podrías dar una mano a refactorear la clase FormaGeometrica?

Acompañando al proyecto encontrarás una serie de tests unitarios que describen el comportamiento del método Imprimir. **Se puede modificar cualquier cosa del código y de los tests, con la única condición que los tests deben pasar correctamente al entregar la solución.**

### Cómo funciona

Lo que te encontrás al levantar la .sln es un proyecto Web de .NET, con todas las referencias y packages básicos para arrancar. Tiene las referencias tanto para MVC como para WebApi, de manera que la implementación es libre. Además, tenemos una librería con el objeto de negocio FormaGeometrica, y un pequeño proyecto con test unitarios sobre el método de impresión de reporte.

La forma de resolver el problema es toda tuya! Crear nuevos proyectos para separar responsabilidades, instalar frameworks de JS para trabajar client-side, usar sintaxis simple de Razor y el paradigma de MVC, las decisiones son múltiples. 

**¡¡Buena suerte!!**
