---
title: Licenciamiento
type: docs
weight: 50
url: /es/net/licensing/
---

{{% alert color="primary" %}}

Una vez que esté satisfecho con su evaluación de Aspose.CAD para .NET, compre una licencia en el sitio web de Aspose: [Portal de Compra](https://purchase.aspose.com/buy). Familiarícese con los diferentes tipos de licencia disponibles. Si tiene alguna pregunta, [contacte al equipo de ventas de Aspose](https://about.aspose.com/contact) y estarán encantados de ayudarle.

Cada licencia de Aspose incluye una suscripción de un año para actualizaciones gratuitas a cualquier nueva versión o correcciones que se lancen durante este tiempo. Proporcionamos soporte técnico gratuito e ilimitado tanto a usuarios licenciados como a usuarios de evaluación.

La licencia es un archivo XML de texto plano que contiene detalles como el nombre del producto, el número de desarrolladores licenciados, la fecha de vencimiento de la suscripción, entre otros. El archivo está firmado digitalmente, así que no modifique el archivo: incluso agregar un salto de línea adicional al archivo lo invalida.

{{% /alert %}}

## **Cuándo Aplicar una Licencia**

Siga estas simples reglas:

- La licencia solo necesita establecerse una vez por dominio de aplicación.
- Necesita establecer la licencia antes de usar cualquier otra clase de Aspose.CAD.
- Llamar a SetLicense múltiples veces no es perjudicial, pero desperdicia tiempo del procesador.
- Si está desarrollando una aplicación de Windows Forms o consola, llame a SetLicense en el código de inicio, antes de usar las clases de Aspose.CAD.
- Al desarrollar una aplicación ASP.NET, llame a SetLicense desde el archivo Global.asax.cs (Global.asax.vb), en el método protegido Application_Start. Se llama una vez cuando la aplicación se inicia.
- No llame a SetLicense desde dentro de los métodos Page_Load, ya que significa que la licencia se cargará cada vez que se cargue una página web.
- Si está desarrollando una biblioteca de clases, llame a SetLicense desde un constructor estático de la clase que usa Aspose.CAD. El constructor estático se ejecuta antes de que se cree una instancia de su clase, asegurando que la licencia de Aspose.CAD esté correctamente establecida.

## **Aplicar Licencia usando Archivo u Objeto Stream**

Use el **[License.SetLicense](https://reference.aspose.com/cad/net/aspose.cad.license/setlicense/methods/1)** método para licenciar el componente. La forma más fácil de establecer una licencia es colocar el archivo de licencia en la misma carpeta que Aspose.CAD.dll y especificar el nombre del archivo, sin una ruta, como se muestra a continuación.

### **Cargando una Licencia desde un Archivo**

Este fragmento de código inicializa una licencia almacenada en un archivo o en un recurso incrustado.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseByPath-ApplyLicenseByPath.cs" >}}

### **Cargando una Licencia desde un Objeto Stream**

Este fragmento de código inicializa la licencia desde un stream.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-ApplyLicenseUsingFileStream-ApplyLicenseUsingFileStream.cs" >}}
