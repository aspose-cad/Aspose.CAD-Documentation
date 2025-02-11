---
title: Cómo ejecutar los ejemplos
type: docs
weight: 70
url: /es/net/showcases/how-to-run-the-examples/
---

## **Requisitos de Software**

Por favor, asegúrate de cumplir con los siguientes requisitos antes de descargar y ejecutar los ejemplos.

1. Visual Studio 2010 o superior
1. NuGet Package Manager instalado en Visual Studio. Asegúrate de que la última versión de la API de NuGet está instalada en Visual Studio. Para obtener detalles sobre cómo instalar el administrador de paquetes NuGet, consulta https://docs.microsoft.com/en-gb/nuget/install-nuget-client-tools
1. Ve a Herramientas->Opciones->NuGet Package Manager->Fuentes de Paquete y asegúrate de que la opción **nuget.org** esté seleccionada
1. El proyecto de ejemplo utiliza la función de restauración automática de paquetes de NuGet, por lo tanto, debes tener una conexión a internet activa. Si no tienes una conexión a internet activa en la máquina donde se van a ejecutar los ejemplos, por favor consulta [Instalación](/es/cad/net/installation/) para agregar una referencia a Aspose.CAD.dll en el proyecto de ejemplo.

## **Descargar de GitHub**

Todos los ejemplos de Aspose.CAD para .NET están alojados en [GitHub](https://github.com/aspose-cad/Aspose.CAD-for-.NET).

- Puedes clonar el repositorio usando tu cliente de GitHub favorito o descargar el archivo ZIP desde [aquí](https://github.com/aspose-cad/Aspose.CAD-for-.NET/archive/master.zip).
- Extrae el contenido del archivo ZIP en cualquier carpeta de tu computadora. Todos los ejemplos están ubicados en la carpeta **Examples**.
- Hay un archivo de solución de Visual Studio para C#.
- Los proyectos están creados en Visual Studio 2013, pero los archivos de solución son compatibles con Visual Studio 2010 SP1 y superior.
- Abre el archivo de solución en Visual Studio y compila el proyecto.
- En la primera ejecución, las dependencias se descargarán automáticamente a través de NuGet.
- La carpeta **Data** en la carpeta raíz de **Examples** contiene los archivos de entrada que utilizan los ejemplos de CSharp. Es obligatorio que descargues la carpeta **Data** junto con el proyecto de ejemplos.
- Abre el archivo RunExamples.cs, todos los ejemplos se llaman desde aquí.
- Descomenta los ejemplos que quieres ejecutar desde el proyecto.

No dudes en ponerte en contacto con nosotros a través de nuestros foros si tienes algún problema configurando o ejecutando los ejemplos.

## **Contribuir**

Si te gusta agregar o mejorar un ejemplo, te animamos a contribuir al proyecto. Todos los ejemplos y proyectos de exhibición en este repositorio son de código abierto y se pueden utilizar libremente en tus propias aplicaciones.

Para contribuir, puedes bifurcar el repositorio, editar el código fuente y crear una solicitud de extracción. Revisaremos los cambios e incorporaremos a repositorio si se considera útil.
