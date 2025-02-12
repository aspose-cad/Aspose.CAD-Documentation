---
title: Configuración de Demos
type: docs
weight: 40
url: /es/jasperreports/demos-setup/
---

{{% alert color="primary" %}}

Aspose.CAD para JasperReports incluye una serie de proyectos de demostración para ayudarte a comenzar.

Las demostraciones proporcionadas con Aspose.CAD para JasperReports son demostraciones estándar de JasperReports modificadas para demostrar el uso de los nuevos exportadores.

{{% /alert %}}

Para ejecutar las demos de Aspose.CAD para JasperReports, realiza los siguientes pasos:

1. Descarga JasperReports (por ejemplo, https://sourceforge.net/projects/jasperreports/files/archive/). Asegúrate de descargar todo el proyecto archivado con el código fuente y las demos, no solo un solo JAR.
1. Descomprime el proyecto archivado en alguna ubicación de tu disco duro, por ejemplo C:\.
1. Copia todas las carpetas de demostración de la carpeta \samples de **aspose-cad-xx.x.zip** a **\InstallDir\demo\samples**, donde "\InstallDir" es la ubicación en la que has descomprimido JasperReports. Este paso es necesario porque los scripts de construcción de demostración dependen de la estructura de carpetas de JasperReports, de lo contrario, tendrás que modificar los scripts de construcción.
1. Copia **aspose-cad-jasperreports-xx.x.jar** de la carpeta \lib de **aspose-cad-jasperreports-xx.x.zip** a **\InstallDir\lib**.
1. Prepara la Herramienta de Construcción Ant y el Gestor de Dependencias Ivy, consulta **\InstallDir\readme.txt**.
1. Modifica el **build.xml** en **\InstallDir\demo\samples**, agrega el aspose-cad-jasperreports-xx.x.jar al classpath:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-jasperreports-xx.xx.jar"/> </path>**.
1. Cambia el directorio actual a **\InstallDir\demo\hsqldb** y ejecuta la siguiente línea de comando:
   **Ant runServer**
1. Cambia el directorio actual a una de las demos de Aspose.CAD para JasperReports, por ejemplo, **\InstallDir\demo\samples\charts.ai** y ejecuta los siguientes comandos en la línea de comando:
   **ant test** - para producir archivos de informe.
1. Abre uno de los documentos resultantes para ver, por ejemplo, **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
