---
title: Instalación
type: docs
weight: 30
url: /es/net/getting-started/installation/
---

## **Instalación de Aspose.CAD para .NET a través de NuGet**

NuGet es la forma más fácil de descargar e instalar las API de Aspose para .NET. Abra Microsoft Visual Studio y el administrador de paquetes de NuGet. Busque "aspose" para encontrar la API de Aspose deseada. Haga clic en "Instalar", la API seleccionada se descargará y se referenciará en su proyecto.

![todo:image_alt_text](/cad/_assets/install/installation_1.png)

## **Referenciando Aspose.CAD desde un Proyecto .NET**

Siga estos pasos (suponiendo que utiliza Microsoft Visual Studio):

1. En **Explorador de soluciones**, expanda el nodo del proyecto al que desea agregar una referencia.
1. Haga clic derecho en el nodo **Referencias** para el proyecto y seleccione **Agregar referencia** en el menú contextual.
1. En el cuadro de diálogo **Agregar referencia**, busque la ubicación del archivo DLL.
1. Seleccione el archivo DLL de *Aspose.CAD* y haga clic en el botón **Aceptar**.
1. La referencia de *Aspose.CAD* aparecerá bajo el nodo **Referencias** de su proyecto.

![todo:image_alt_text](/cad/_assets/install/installation_2.png)

### **Instalar o Actualizar Aspose.CAD usando la Consola del Administrador de Paquetes**

Puede seguir los pasos a continuación para referenciar la [API de Aspose.CAD](https://www.nuget.org/packages/Aspose.CAD/) usando la consola del administrador de paquetes:

1. Abra su solución/proyecto en Visual Studio.
1. Seleccione Herramientas -> Administrador de paquetes de biblioteca -> Consola del administrador de paquetes desde el menú para abrir la consola del administrador de paquetes.

![todo:image_alt_text](/cad/_assets/install/installation_3.png)

Escriba el comando “**Install-Package Aspose.CAD**” y presione enter para instalar la última versión completa en su aplicación. Alternativamente, puede agregar el sufijo "**-prerelease**" al comando para especificar que también se instalará la última versión que incluye correcciones rápidas.

![todo:image_alt_text](/cad/_assets/install/installation_4.png)

Verá que el aviso "Descargando Aspose.CAD..." aparece en la parte inferior izquierda de la ventana, indicando que la descarga está en proceso. 

![todo:image_alt_text](/cad/_assets/install/installation_5.png)

Una vez descargado, verá los siguientes mensajes de confirmación. Si no está familiarizado con el [EULA de Aspose](https://about.aspose.com/legal/eula), entonces es una buena idea leer la licencia referenciada en la URL.

![todo:image_alt_text](/cad/_assets/install/installation_6.png)

Ahora debería encontrar que Aspose.CAD se ha agregado y referenciado correctamente en su aplicación.

![todo:image_alt_text](/cad/_assets/install/installation_7.png)

En la consola del administrador de paquetes, también puede usar el comando “**Update-Package Aspose.CAD**” y presionar enter para buscar actualizaciones del paquete Aspose.CAD e instalarlas si están presentes. También puede agregar el sufijo "-prerelease" para actualizar a la última versión.

## **Consideraciones al Ejecutar en un Entorno de Servidor Compartido**

Se recomienda que todos los componentes Aspose .NET se ejecuten con un conjunto de permisos de Confianza Total. Esto se debe a que los componentes de Aspose .NET a veces necesitan acceder a configuraciones del registro y archivos ubicados en lugares distintos al directorio virtual, por ejemplo, para leer fuentes, etc. Además, los componentes de Aspose.NET se basan en clases principales del sistema .NET, algunas de las cuales también requieren permisos de Confianza Total para ejecutarse en algunos casos.

Los proveedores de servicios de Internet que hospedan múltiples aplicaciones de diferentes empresas generalmente imponen un nivel de seguridad de Confianza Media. En el caso de .NET 2.0, un nivel de seguridad así puede establecer las siguientes restricciones que podrían afectar la capacidad de Aspose.CAD para funcionar correctamente.

- **RegistryPermission** no está disponible. Esto significa que no puede acceder al registro, que es necesario para enumerar las fuentes instaladas al renderizar documentos.
- **FileIOPermission** está restringido. Esto significa que solo puede acceder a archivos en la jerarquía del directorio virtual de su aplicación. Esto potencialmente significa que las fuentes no pueden ser leídas durante la exportación.

Por estas razones especificadas anteriormente, se recomienda que Aspose.CAD se ejecute con permisos de Confianza Total. Puede encontrar que algunas características de la biblioteca funcionarán al realizar diferentes tareas en Confianza Media, mientras que algunas no lo harán (renderizado, por ejemplo), lo que puede deberse a llamadas a GDI+ para el procesamiento de imágenes.

## **Requisitos del Sistema**

### **Sistemas Operativos**

Aspose.CAD para .NET admite cualquier sistema operativo de 32 bits o 64 bits donde esté instalado .NET o el marco Mono, incluyendo, pero no limitado a:

- Escritorio de Microsoft Windows (XP, Vista, 7, 8, 10) y sistemas operativos de servidor (2003, 2008, 2012)
- Windows Azure
- Linux (Ubuntu, openSUSE, CentOS y otros)
- Mac OS X

### **Marcos**

Aspose.CAD para .NET admite:

- Versiones del .NET Framework desde 2.0 hasta 4.5, incluyendo versiones del Client Profile
- .NET Core
- Mono 2.6.7 o superior

### **Entornos de Desarrollo**

Puede usar Aspose.CAD para .NET para desarrollar aplicaciones en cualquier entorno de desarrollo que apunte a la plataforma .NET, pero los siguientes entornos son explícitamente compatibles:

- Microsoft Visual Studio 2010 o superior
- MonoDevelop 2.4 y superior
