---
title: Trabajando con el Formato de Archivo OBJ
type: docs
weight: 120
url: /es/javascript-net/working-with-obj-file-format/
---

{{% alert color="primary" %}}

Aspose.CAD ahora soporta el formato de archivo OBJ. El formato de archivo OBJ es una geometría 3D que contiene mapas de textura, coordenadas 3D, caras poligonales y otra información del objeto.

{{% /alert %}}

## **Exportando el Formato OBJ a PNG**

Aspose.CAD para Javascript en Angular permite a los desarrolladores exportar un [OBJ](https://docs.fileformat.com/3d/obj/) archivo al formato [PNG](https://docs.fileformat.com/image/png/).
El enfoque de conversión de [OBJ](https://docs.fileformat.com/3d/obj/) a [PNG](https://docs.fileformat.com/image/png/) funciona de la siguiente manera:

1. Cargar el archivo de dibujo [OBJ](https://docs.fileformat.com/3d/obj/) utilizando el método **Image.load**.
1. Llamar a **Image.save** pasando un objeto de **PngOptions** como segundo parámetro.

## Código de Ejemplo

El código a continuación muestra cómo lograr el mismo objetivo utilizando Aspose.CAD para JavaScript

{{< gist "aspose-com-gists" "b5a4510e5fa49082bb585a12d753de8d" "Convert-OBJ-to-PNG-Export.js" >}}
