---
title: Cómo ejecutar los ejemplos
type: docs
weight: 70
url: /es/java/getting-started/how-to-run-the-examples/
---

## **Descargar de GitHub**

Todos los ejemplos de Aspose.CAD para Java están alojados en [Github](https://github.com/aspose-cad/Aspose.CAD-for-Java). Puedes clonar el repositorio usando tu cliente de Github favorito o descargar el archivo ZIP desde [aquí](https://github.com/aspose-cad/Aspose.CAD-for-Java/archive/master.zip).

Extrae el contenido del archivo ZIP en cualquier carpeta de tu computadora. Todos los ejemplos se encuentran en la carpeta **Ejemplos**.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Figura: Directorio de Ejemplos de Aspose.CAD**|

## **Importar ejemplos en el IDE**

El proyecto utiliza el sistema de construcción Maven. Cualquier IDE moderno puede abrir o importar fácilmente el proyecto y sus dependencias. A continuación, te mostramos cómo usar IDE populares para construir y ejecutar los ejemplos.

### **IntelliJ IDEA**

Haz clic en el menú **Archivo** y selecciona **Abrir**. Busca la carpeta del proyecto y selecciona el archivo **pom.xml**.

|![todo:image_alt_text](https://i.imgur.com/nPfCrsR.png)|
| :- |
|**Figura: Seleccionar Archivo o Directorio para Importar**|

Se abrirá el proyecto y descargará las dependencias automáticamente. Desde la pestaña del Proyecto, explora los ejemplos en la carpeta **src/main/java**. Para ejecutar un ejemplo, simplemente haz clic derecho en el archivo y selecciona "Ejecutar ..", el ejemplo se ejecutará y la salida se mostrará en la ventana de salida de consola incorporada.

|![todo:image_alt_text](https://i.imgur.com/nMaSTiG.png)|
| :- |
|**Figura: Ejecutar Ejemplo**|

### **Eclipse**

Haz clic en el menú **Archivo** y selecciona **Importar**. Selecciona **Maven** - Proyectos Maven Existentes.

|![todo:image_alt_text](https://i.imgur.com/Ca0cHFr.png)|
| :- |
|**Figura: Importar**|

Busca la carpeta que clonaste o descargaste de GitHub y selecciona el archivo **pom.xml**. Se abrirá el proyecto y descargará las dependencias automáticamente. Desde la pestaña del Explorador de Paquetes, explora los ejemplos en la carpeta **src/main/java**. Para ejecutar un ejemplo, simplemente haz clic derecho en el archivo y selecciona **Ejecutar Como** - **Aplicación Java**, el ejemplo se ejecutará y la salida se mostrará en la ventana de salida de consola incorporada.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Figura: Ejecutar Ejemplo**|

### **NetBeans**

Haz clic en el menú **Archivo** y selecciona **Abrir Proyecto**. Busca la carpeta que clonaste o descargaste de GitHub. El icono de la carpeta **Ejemplos** mostrará que es un proyecto Maven. Selecciona Ejemplos y ábrelo.

|![todo:image_alt_text](https://i.imgur.com/KOcP5Z2.png)|
| :- |
|**Figura: Abrir Proyecto**|

Se abrirá el proyecto y descargará las dependencias automáticamente. Desde la pestaña de Proyectos, explora los ejemplos en los **paquetes de origen**. Para ejecutar un ejemplo, simplemente haz clic derecho en el archivo y selecciona **Ejecutar Archivo**, el ejemplo se ejecutará y la salida se mostrará en la ventana de salida de consola incorporada.

|![todo:image_alt_text](https://i.imgur.com/VUUU4BD.png)|
| :- |
|**Figura: Ejecutar Ejemplo**|

## **Agregar la biblioteca Aspose.CAD en el repositorio local de Maven**

Cuando importas el proyecto **Ejemplos de Aspose.CAD** en el IDE, Maven descarga automáticamente el archivo JAR de aspose.cad desde [Aspose Maven Repository](https://releases.aspose.com/java/repo/). En caso de que no tengas acceso a Internet, puedes agregar manualmente el JAR en tu repositorio local.

### **mvn install**

Descarga el [aspose.cad](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/), extráelo y copia el aspose.cad-version.jar a otro lugar, por ejemplo, unidad C. Emite el siguiente comando:

{{< highlight java >}}

 mvn install:install-file

    -Dfile=c:\aspose.cad-version.jar

    -DgroupId=com.aspose

    -DartifactId=aspose-cad

    -Dversion={version}

    -Dpackaging=jar

{{< /highlight >}}

Ahora, el JAR de **aspose.cad** se ha copiado a tu repositorio local de Maven.

### **pom.xml**

Después de instalar, solo declara la coordenada de **aspose.cad** en pom.xml.

{{< highlight java >}}

 <dependency>

    <groupId>com.aspose</groupId>

    <artifactId>aspose-cad</artifactId>

    <version>17.11</version>

    <classifier>jdk16</classifier>

 </dependency>

{{< /highlight >}}

### **Listo**

Compílalo, ahora el JAR de **aspose.cad** se puede recuperar de tu repositorio local de Maven.

## **Contribuir**

Si te gustaría agregar o mejorar un ejemplo, te animamos a contribuir al proyecto. Todos los ejemplos y proyectos de exhibición en este repositorio son de código abierto y se pueden usar libremente en tus propias aplicaciones.

Para contribuir, puedes bifurcar el repositorio, editar el código fuente y enviar una Pull Request. Revisaremos los cambios y los incluiremos en el repositorio si se consideran útiles.
