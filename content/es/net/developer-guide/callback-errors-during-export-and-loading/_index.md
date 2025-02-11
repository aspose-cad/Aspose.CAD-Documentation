---
title: Errores de callback durante la exportación y carga
type: docs
weight: 40
url: /es/net/callback-errors-during-export-and-loading/
---

## **Revisión de errores de callback durante la exportación y carga**

Es posible que durante la exportación o carga del dibujo enfrentemos errores relacionados con la estructura del archivo 
(p.ej. se requieren secciones en el archivo ahora, pero no antes). 
Algunos de ellos son críticos y en tales casos se lanza la excepción, pero también podemos ignorar algunos de ellos internamente y notificar sobre ello utilizando mensajes de callback.
De todos modos, todos estos mensajes requieren atención porque pueden explicar, por ejemplo, entidades faltantes en los resultados de la exportación u otros efectos.

### **Errores durante la exportación**

Hay un campo RenderResult en [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/),
que incluye IsRenderComplete para obtener si hubo errores durante la exportación e imprimir información sobre ellos:

{{< gist aspose-com-gists 90b8a0a5ce7d0fc5d8d9a8c5bf4b816d "Render-result-error-messages.cs">}}

### **Errores durante la carga**

Algunos problemas con los dibujos pueden observarse antes de que comience el proceso de exportación. 
La propiedad [**Errors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/errors/) en
 el objeto [**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/) se utiliza para almacenar mensajes sobre ellos.
La propiedad [**IgnoreErrors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/ignoreerrors/) es útil para decidir si 
se requiere lanzar una excepción sobre los errores de carga o no. 

Aquí hay un ejemplo del uso de la propiedad Errors:

{{< gist aspose-com-gists b4f8af514a57a37e260cf1128011d34d "Errors-in-load-options.cs">}}
