---
title: Licenciamiento
type: docs
weight: 50
url: /es/java/getting-started/licensing/
---

{{% alert color="primary" %}}

Puede descargar una versión de evaluación de **Aspose.CAD** para Java desde [su página de descarga](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/). La versión de evaluación proporciona exactamente las mismas capacidades que la versión licenciada del producto. Además, la versión de evaluación simplemente se convierte en licenciada cuando usted compra una licencia y agrega un par de líneas de código para aplicar la licencia.

Una vez que esté satisfecho con su evaluación de **Aspose.CAD**, puede [comprar una licencia](https://purchase.aspose.com/buy) en el sitio web de Aspose. Familiarícese con los diferentes tipos de suscripción que se ofrecen. Si tiene alguna pregunta, no dude en contactar al equipo de ventas de Aspose.

Cada licencia de Aspose incluye una suscripción de un año para actualizaciones gratuitas a cualquier nueva versión o arreglos que salgan durante este tiempo. El soporte técnico es gratuito e ilimitado y se proporciona tanto a usuarios con licencia como a usuarios de evaluación.

{{% /alert %}}

Si desea probar **Aspose.CAD** sin las limitaciones de la versión de evaluación, solicite una licencia temporal de 30 días. Consulte [¿Cómo obtener una Licencia Temporal?](https://purchase.aspose.com/temporary-license) para más información.

## **Configuración de una Licencia**

La licencia es un archivo XML de texto plano que contiene detalles como el nombre del producto, el número de desarrolladores a los que está licenciada, la fecha de caducidad de la suscripción, etc. El archivo está digitalmente firmado, por lo que no lo modifique; incluso la adición inadvertida de un salto de línea adicional en el archivo lo invalidará.

Necesita establecer una licencia antes de realizar cualquier operación con archivos de AutoCAD. Solo se requiere establecer una licencia una vez por aplicación o proceso.

La licencia se puede cargar desde un flujo o archivo en las siguientes ubicaciones:

1. Ruta explícita.
1. La carpeta que contiene el Aspose.CAD.jar.

Utilice el método License.setLicense() para licenciar el componente. A menudo, la forma más sencilla de establecer una licencia es colocar el archivo de licencia en la misma carpeta que Aspose.CAD.jar y especificar solo el nombre del archivo sin ruta, como se muestra en el siguiente ejemplo:

### **Ejemplo 1**

En este ejemplo, **Aspose.CAD** intentará encontrar el archivo de licencia en la carpeta que contiene los JARs de su aplicación.

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense("Aspose.CAD.Java.lic");

{{< /highlight >}}

### **Ejemplo 2**

Inicializa una licencia desde un flujo.

{{< highlight java >}}

com.aspose.cad.License license = new com.aspose.cad.License();

license.setLicense(new java.io.FileInputStream("Aspose.CAD.Java.lic"));

{{< /highlight >}}

## **Validar la Licencia**

Es posible validar si la licencia se ha establecido correctamente o no. La clase License tiene el campo isLicensed que devolverá verdadero si la licencia se ha establecido correctamente.

{{< highlight java >}}

License license = new License();

license.setLicense("Aspose.CAD.Java.lic");

if (License.isLicensed()) {

    System.out.println("¡Licencia Establecida!");

}

{{< /highlight >}}
