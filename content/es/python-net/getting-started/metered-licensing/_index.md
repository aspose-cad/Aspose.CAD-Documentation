---
title: Licenciamiento Medido
type: docs
weight: 40
url: /es/python-net/getting-started/metered-licensing/
---

{{% alert color="primary" %}} 

Aspose.CAD permite a los desarrolladores aplicar una clave medida. Es un nuevo mecanismo de licenciamiento. El nuevo mecanismo de licenciamiento se utilizará junto con el método de licenciamiento existente. Aquellos clientes que deseen ser facturados según el uso de las características de la API pueden utilizar el licenciamiento medido. Para más detalles, consulte la sección de [Preguntas Frecuentes sobre Licenciamiento Medido](https://purchase.aspose.com/faqs/licensing/metered).

{{% /alert %}} 
## **Licenciamiento Medido**
Aquí están los pasos simples para usar la clase Metered.

1. Cree una instancia de la clase Metered.
1. Pase las claves pública y privada al método SetMeteredKey.
1. Realice el procesamiento (ejecute la tarea).
1. Llame al método GetConsumptionQuantity de la clase Metered.
1. Este devolverá la cantidad/cantidad de solicitudes de API que ha consumido hasta ahora.

A continuación se muestra un código de muestra que demuestra cómo establecer la clave pública y privada medida.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "MeteredLicensing.py" >}}
