---
title: Licenciamiento Medido
type: docs
weight: 60
url: /es/net/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD permite a los desarrolladores aplicar una clave medida. Es un nuevo mecanismo de licenciamiento. El nuevo mecanismo de licenciamiento se utilizará junto con el método de licenciamiento existente. Aquellos clientes que deseen ser facturados según el uso de las características de la API pueden utilizar el licenciamiento medido. Para obtener más detalles, consulte la sección [Preguntas Frecuentes sobre Licenciamiento Medido](https://purchase.aspose.com/faqs/licensing/metered).

{{% /alert %}} 
## **Licenciamiento Medido**
Aquí están los pasos simples para usar la clase Metered.

1. Cree una instancia de la clase Metered.
1. Pase las claves pública y privada al método SetMeteredKey.
1. Realice el procesamiento (ejecute la tarea).
1. Llame al método GetConsumptionQuantity de la clase Metered.
1. Este devolverá la cantidad de solicitudes a la API que ha consumido hasta ahora.

A continuación se muestra un código de muestra que demuestra cómo establecer la clave pública y la clave privada medidas.

{{< gist "aspose-cad" "518d2e9e6e58a76f102d72f629f3e693" "Examples-CSharp-ApplyLicense-MeteredLicensing-MeteredLicensing.cs" >}}
