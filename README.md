# InvertirOnline.com Coding Challenge

Bienvenido!

Nos encontramos en la búsqueda de desarrolladores .NET para que se incorporen a nuestro equipo. Después de múltiples procesos de selección, llegamos a la conclusión de que el código habla por si mismo. Con lo cual si te sentís dispuesto a afrontar el desafío, por favor tomate un par de horas para jugar con el problema y resolverlo.

### Cómo participar del proceso?

Abajo detallamos el problema a resolver, cuando consideres que está resuelto, **no** envíes pull request. Envía un mail a busquedas.it@invertironline.com con el link a tu fork, y si tenés algún comentario sobre tu implementación, también podés agregarlo ahí.


### Comenzando

El repo en el cual te encontrás tiene sólo un par de cosas. Para resolver el problema y levantar la app necesitás:
  
  * .NET Framework 4.5
  * Visual Studio 2013-2015
  * Forkear este repositorio y armar un nuevo branch. 

Una vez hecho esto, en la carpeta `/lib` del repositorio vas a encontrar las referencias necesarias para obtener la Data con la cual vas a trabajar.

### El problema

La idea es poder levantar una aplicación web donde el punto de entrada sea un buscador de títulos de la bolsa (acciones y bonos). Este buscador debe tener autocompletado, y al seleccionar un título, me debe mostrar un detalle del mismo con sus propiedades. Con estas dos funcionalidades básicas el problema se considera solucionado (cualquier extra es bienvenido :-) ). 

Para esto se provee una capa de acceso a datos mockeada con un sólo método: `GetTitulos()`.

### Como funciona

Lo que te encontrás al levantar la .sln es un proyecto Web de .NET, con todas las referencias y packages básicos para arrancar. Tiene las referencias tanto para MVC como para WebApi, de manera que la implementación es libre. La referencia más importante de `/lib` es `CodingChallenge.Data`, y un ejemplo para obtener el listado de títulos sería:

  ```c#
  var repositorio = new MockRepository().TituloRepository;
  var titulos = repositorio.GetTitulos();
  ```
Una vez obtenido el listado, ¡la forma de resolver el problema es toda tuya! Crear nuevos proyectos para separar responsabilidades, instalar frameworks de JS para trabajar desde el lado de un cliente más robusto, usar sintaxis simple de Razor y el paradigma de MVC, las decisiones son múltiples.

**¡¡Buena suerte!!**
