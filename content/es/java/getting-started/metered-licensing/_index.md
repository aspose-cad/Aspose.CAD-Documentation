---
title: Licenciamiento Medido
type: docs
weight: 60
url: /es/java/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD permite a los desarrolladores aplicar una clave medida. Es un nuevo mecanismo de licenciamiento. El nuevo mecanismo de licenciamiento se utilizará junto con el método de licenciamiento existente. Aquellos clientes que deseen ser facturados en función del uso de las características de la API pueden utilizar el licenciamiento medido. Para más detalles, consulte la sección de [Preguntas Frecuentes sobre el Licenciamiento Medido](https://purchase.aspose.com/faqs/licensing/metered).

{{% /alert %}} 
## **Licenciamiento Medido**
Aquí están los pasos sencillos para usar la clase Metered.

1. Cree una instancia de la clase Metered.
1. Pase las claves pública y privada al método setMeteredKey.
1. Realice el procesamiento (ejecute la tarea).
1. Llame al método getConsumptionQuantity de la clase Metered.
1. Devolverá la cantidad de solicitudes de API que ha consumido hasta ahora.

A continuación se muestra un código de muestra que demuestra cómo establecer la clave pública y privada medida:

{{< gist "aspose-cad" "9c5a3f5ddf329a1362916037ccd8c6e0" "Examples-src-main-java-com-aspose-cad-examples-ApplyLicense-MeteredLicensing.java" >}}
