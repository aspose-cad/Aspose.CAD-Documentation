---
title: Configuración de Demos
type: docs
weight: 40
url: /es/python-net/installation/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD para Python incluye una serie de proyectos de demostración para ayudarte a empezar.

Las demostraciones proporcionadas con Aspose.CAD para Python son demostraciones estándar de Python modificadas para demostrar el uso de los nuevos exportadores.

{{% /alert %}}

Para ejecutar las demostraciones de Aspose.CAD para Python, realiza los siguientes pasos:

1. Descarga Pythons (por ejemplo, https://sourceforge.net/projects/python-net/files/archive/). Asegúrate de descargar el proyecto archivado completo con el código fuente y las demostraciones, no solo un solo JAR.
1. Descomprime el proyecto archivado en alguna ubicación en tu disco duro, por ejemplo C:\.
1. Copia todas las carpetas de demostración de la carpeta \samples de **aspose-cad-xx.x.zip** a **\InstallDir\demo\samples**, donde "\InstallDir" es la ubicación donde has descomprimido Pythons. Este paso es necesario porque los scripts de construcción de las demostraciones dependen de la estructura de carpetas de Pythons, de lo contrario, necesitarás modificar los scripts de construcción.
1. Copia **aspose-cad-pythons-xx.x.jar** de la carpeta \lib de **aspose-cad-pythons-xx.x.zip** a **\InstallDir\lib**.
1. Prepara Ant Build Tool y Ivy Dependency Manager, consulta **\InstallDir\readme.txt**.
1. Modifica el **build.xml** en **\InstallDir\demo\samples**, agrega el aspose-cad-pythons-xx.x.jar al classpath:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-pythons-xx.xx.jar"/> </path>**.
1. Cambia el directorio actual a **\InstallDir\demo\hsqldb** y ejecuta la siguiente línea de comandos:
   **ant runServer**
1. Cambia el directorio actual a una de las demostraciones de Aspose.CAD para Python, por ejemplo **\InstallDir\demo\samples\charts.ai** y ejecuta los siguientes comandos en la línea de comandos:
   **ant test** - para producir archivos de informe.
1. Abre uno de los documentos resultantes para ver, por ejemplo **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
