
# InvertirOnline.com Coding Challenge

Bienvenido!

Nos encontramos en la búsqueda de desarrolladores .NET para que se incorporen a nuestro equipo. Después de múltiples procesos de selección, llegamos a la conclusión de que el código habla por si mismo. Con lo cual si te sentís dispuesto a afrontar el desafío, por favor tomate un par de horas para jugar con el problema y resolverlo.

### Cómo participar del proceso?

Abajo detallamos el problema a resolver, cuando consideres que está resuelto, **no** envíes pull request. Envía un mail a busquedas.it@invertironline.com con el link a tu fork, y si tenés algún comentario sobre tu implementación, también podés agregarlo ahí.


### Comenzando

El repo en el cual te encontrás tiene sólo un par de cosas. Para resolver el problema y levantar la app necesitás:
  
  * .NET Framework 4.5.2
  * Visual Studio 2013 en adelante
  * Forkear este repositorio y armar un nuevo branch.

### El problema

La idea es poder levantar una aplicación web, donde el punto de entrada sea un resumen de los datos a trabajar (la impresión de este resumen ya viene codificada en el método estático `public static string ImprimirResumen(IList<Titulo> titulos, Idioma idioma)`) y exista un link a un buscador de títulos de la bolsa. Este buscador debe tener autocompletado, y al seleccionar un título, me debe mostrar un detalle del mismo con sus propiedades.

Al mismo tiempo, encontramos que este método es muy dependiente de las condiciones existentes, y encontramos muy díficil el poder agregar o bien un nuevo tipo de título, o imprimir el resumen en otro idioma. ¿Podrías ayudarnos a refactorear la clase Título para que sea escalable y respete el paradigma de programación orientada a objetos?

### Como funciona

Lo que te encontrás al levantar la .sln es un proyecto Web de .NET, con todas las referencias y packages básicos para arrancar. Tiene las referencias tanto para MVC como para WebApi, de manera que la implementación es libre. Además, tenemos una librería con la capa de acceso a datos de títulos de la bolsa, y un pequeño proyecto con test unitarios sobre el método de impresión de resumen.

El listado de títulos se obtiene de la siguiente manera:

  ```c#
  var repositorio = new MockRepository().TituloRepository;
  var titulos = repositorio.GetTitulos();
  ```
Una vez obtenido el listado, ¡la forma de resolver el problema es toda tuya! Crear nuevos proyectos para separar responsabilidades, instalar frameworks de JS para trabajar desde el lado de un cliente más robusto, usar sintaxis simple de Razor y el paradigma de MVC, las decisiones son múltiples. Se puede modificar cualquier cosa tanto sobre los objetos como los tests, la única condición es que los tests pasen y la app web cumpla con los objetivos mencionados más arriba.

**¡¡Buena suerte!!**
