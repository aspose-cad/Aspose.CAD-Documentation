---
title: Conversión de dibujos CAD a formatos PDF e imagen de ráster
type: docs
weight: 30
url: /es/java/developer-guide/converting-cad-drawings-to-pdf-and-raster-image-formats/
---

{{% alert color="primary" %}} 

Aspose.CAD para Java escribe directamente la información sobre la API y el número de versión en los documentos de salida. Por ejemplo, al renderizar el documento a PDF, Aspose.CAD para Java completa el campo de Aplicación con el valor 'Aspose.CAD' y el campo PDF Producer con un valor, por ejemplo 'Aspose.CAD v 17.9'.

Tenga en cuenta que no puede instruir a Aspose.CAD para Java para que cambie o elimine esta información de los documentos de salida.

{{% /alert %}} 
## **Conversión de dibujos CAD a formatos de imagen de ráster**
Aspose.CAD para Java es capaz de convertir formatos de dibujo CAD como [**DXF**](https://docs.fileformat.com/cad/dxf/) y [**DWG**](https://docs.fileformat.com/cad/dwg/) a los formatos de imagen de ráster soportados como [**PNG**](https://docs.fileformat.com/image/png/), [**BMP**](https://docs.fileformat.com/image/bmp/), [**TIFF**](https://docs.fileformat.com/image/tiff/), [**JPEG**](https://docs.fileformat.com/image/jpeg/) y [**GIF**](https://docs.fileformat.com/image/gif/). La API de Aspose.CAD para Java ha expuesto medios eficientes y fáciles de usar para lograr este objetivo.
Puede convertir cualquier formato de dibujo CAD soportado a formatos de imagen de ráster utilizando los simples pasos que se detallan a continuación.

1. Cargue el archivo CAD en una instancia de [**Image**](https://reference.aspose.com/cad/java/com.aspose.cad/Image).
1. Cree una instancia de [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) y configure sus propiedades obligatorias como [**PageWidth**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageWidth-float-) y [**PageHeight**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#setPageHeight-float-).
1. Cree una instancia de **ImageOptionsBase** y configure su propiedad [**VectorRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions) a la instancia de **CadRasterizationOptions** creada en el paso anterior.
1. Llame a **Image.save** pasando la ruta del archivo (o un objeto de MemoryStream) así como la instancia de [**ImageOptionsBase**](https://reference.aspose.com/cad/java/com.aspose.cad.class-use/ImageOptionsBase) creada en el paso anterior.

Aquí está el código fuente completo.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADDrawingToRasterImageFormat-ConvertCADDrawingToRasterImageFormat.java" >}}



Por defecto, la API renderiza solo el diseño "Modelo". Sin embargo, también puede especificar los diseños de su elección al convertir dibujos CAD a formatos de imagen.
## **Personalizando la conversión de CAD**
Los procedimientos de conversión de CAD a [PDF](https://docs.fileformat.com/pdf/) y de CAD a imagen de ráster son altamente configurables porque la clase [**CadRasterizationOptions**](https://reference.aspose.com/java/cad/com.aspose.cad.imageoptions/CadRasterizationOptions) ha sido implementada de tal manera que proporciona muchas características opcionales que, al ser configuradas, pueden anular el proceso de renderización según las necesidades de la aplicación.
### **Clase CadRasterizationOptions**
La clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions) es común para todos los formatos CAD soportados como [**DWG**](https://docs.fileformat.com/cad/dwg/) y [DXF](https://docs.fileformat.com/cad/dxf/), por lo tanto, la información compartida en este artículo es válida para ambos formatos CAD mencionados.

Las propiedades más útiles de la clase **CadRasterizationOptions** son:

|**Propiedad**|**Valor por defecto**|**Requerido**|**Descripción**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Sí|Especifica el ancho de la página.|
|**PageHeight**|**0**|Sí|Especifica la altura de la página.|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|No|Especifica si el dibujo debe ser escalado automáticamente. El valor por defecto reduce automáticamente la imagen para ajustarla al tamaño del lienzo. Cambie al modo **GrowToFit**, o use la configuración **None** para desactivar el escalado automático.|
|**BackgroundColor**|**Color.White**|No|Especifica el color de fondo de la imagen de salida.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|No|Especifica el modo de coloración de las entidades. Especifique la opción **UseObjectColor** para dibujar entidades utilizando su color nativo, o la opción **UseDrawColor** para anular los colores nativos.|
|**DrawColor**|**Color.Black**|No|Especifica el color anulado de la entidad (solo si **DrawType** está configurado al valor de propiedad **UseDrawColor**).|
|**AutomaticLayoutsScaling**|Falso|No|Especifica si se debe realizar un escalado automático del diseño para coincidir con el diseño Modelo.|
### **Estableciendo el tamaño y modo del lienzo**
Exportar de CAD a PDF o de CAD a formatos de imagen de ráster no es una tarea trivial. Dado que el PDF o imagen resultante requiere que se defina el tamaño del lienzo, necesitamos especificar las dimensiones de salida para que la página PDF renderice el dibujo correctamente. Establezca explícitamente las propiedades **CadRasterizationOptions.PageWidth** y **CadRasterizationOptions.PageHeight**, o puede obtener una **ImageSaveException**.

Además, puede especificar opciones de escala de dimensión. Las opciones de escalado se establecen mediante la propiedad **CadRasterizationOptions.ScaleMethod**. Use esta opción para ajustar automáticamente las dimensiones de la imagen de acuerdo con los valores de **CadRasterizationOptions.PageWidth** y **CadRasterizationOptions.PageHeight**. Por defecto, **CadRasterizationOptions.ScaleMethod** está configurado en modo **ScaleType.ShrinkToFit**. Esta propiedad define el siguiente comportamiento:

- Si las dimensiones del dibujo CAD son mayores que el tamaño del lienzo resultante, entonces las dimensiones del dibujo se reducen para ajustarse al lienzo resultante mientras se preserva la relación de aspecto.
- Si las dimensiones del dibujo CAD son menores que el tamaño del lienzo resultante, establezca la propiedad **CadRasterizationOptions.ScaleMethod** como **ScaleType.GrowToFit** para aumentar el tamaño del dibujo y ajustarlo al lienzo PDF manteniendo la relación de aspecto.
- O desactive el escalado automático con la opción **ScaleType.None**.

El siguiente fragmento de código muestra la opción de escalado automático en uso.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetCanvasSizeAndMode-SetCanvasSizeAndMode.java" >}}




### **Estableciendo los colores de fondo y de dibujo**
Por defecto, la paleta de colores para el lienzo resultante está configurada al esquema común del documento. Eso significa que todas las entidades dentro del dibujo CAD se dibujan con un bolígrafo de color negro sobre un fondo blanco sólido. Estos ajustes pueden cambiarse con las propiedades **CadRasterizationOptions.BackgroundColor** y **CadRasterizationOptions.DrawColor**. Cambiar la propiedad **CadRasterizationOptions.DrawColor** también requiere establecer la propiedad **CadRasterizationOptions.DrawType** para hacer uso del color de dibujo que se utilizará. La propiedad **CadRasterizationOptions.DrawType** controla si las entidades CAD preservan sus colores o se convierten a colores personalizados. Para preservar los colores de entidad, especifique **CadRasterizationOptions.DrawType** como **CadDrawTypeMode.UseObjectColor**, de lo contrario, especifique el valor **CadDrawTypeMode.UseDrawColor**.

El siguiente fragmento de código muestra cómo usar diferentes propiedades de color.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SetBackgroundAndDrawingColor-SetBackgroundAndDrawingColor.java" >}}




### **Estableciendo el escalado automático del diseño**
La mayoría de los dibujos CAD tienen más de un diseño almacenado en un solo archivo, y cada diseño podría tener dimensiones diferentes. Al renderizar dicho dibujos CAD a PDF, cada página del PDF podría tener diferentes escalados de acuerdo con el tamaño del diseño. Para hacer que el renderizado sea homogéneo, las API de Aspose.CAD han expuesto la propiedad **CadRasterizationOptions.AutomaticLayoutsScaling**. Su valor por defecto es **falso**, pero cuando es verdadero, la API intentará buscar una escala correspondiente para cada diseño separado y dibujarlos de manera correspondiente realizando una operación de redimensionamiento automático de acuerdo con el tamaño de la página.

Así funciona la propiedad **CadRasterizationOptions.AutomaticLayoutsScaling** en colaboración con la propiedad **CadRasterizationOptions.ScaleMethod**.

1. Si **ScaleMethod** está configurado como **ScaleType.ShrinkToFit** o **ScaleType.GrowToFit** con **AutomaticLayoutsScaling** configurado como falso, entonces todos los diseños (incluido el Modelo) se procesarán de acuerdo con la primera opción.
1. Si **ScaleMethod** está configurado como **ScaleType.ShrinkToFit** o **ScaleType.GrowToFit** con **AutomaticLayoutsScaling** configurado como verdadero, entonces todos los diseños (excepto el Modelo) se procesarán de acuerdo con su tamaño, mientras que el Modelo se procesará de acuerdo con la primera opción.
1. Si **ScaleMethod** está configurado como **ScaleType.None** con **AutomaticLayoutsScaling** configurado como verdadero o falso, entonces no se realizará ningún escalado.

El siguiente fragmento de código muestra cómo establecer el escalado automático del diseño para la conversión de CAD a PDF.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SettingAutoLayoutScaling-SettingAutoLayoutScaling.java" >}}




## **Conversión de diseños CAD a formatos de imagen de ráster**
Aspose.CAD para Java API es capaz de convertir los diseños CAD de formatos soportados como DXF y DWG a las imágenes de ráster como PNG, BMP, TIFF, JPEG y GIF. La API también proporciona soporte para renderizar los diseños específicos de un dibujo CAD a diferentes capas PSD. 
Aspose.CAD para Java API ha expuesto medios eficientes y fáciles de usar para especificar la lista de diseños CAD requeridos y renderizarlos a formatos de imagen de ráster. Aquí está cómo puede lograr el mismo en 5 simples pasos como se detalla a continuación.

1. Cargue el archivo CAD en una instancia de **Image** usando el método de fábrica **load**.
1. Cree una instancia de **CadRasterizationOptions** y establezca sus propiedades obligatorias como **PageWidth** y **PageHeight**.
1. Especifique el/los nombre/s de diseño deseado/s utilizando la propiedad CadRasterizationOptions.Layouts.
1. Cree una instancia de **ImageOptionsBase** y establezca su propiedad **VectorRasterizationOptions** a la instancia de **CadRasterizationOptions** creada en el paso anterior.
1. Llame a **Image.Save** pasando la ruta del archivo (o un objeto de MemoryStream) así como la instancia de **ImageOptionsBase** creada en el paso anterior.

Aquí está el código fuente completo.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayoutToRasterImageFormat-ConvertCADLayoutToRasterImageFormat.java" >}}

`  `{{% alert color="primary" %}} 

La propiedad **CadRasterizationOptions.Layouts** es de tipo array de cadena, por lo que puede especificar más de un diseño a la vez para la posible conversión a formatos de imagen. Al especificar múltiples diseños para la propiedad **CadRasterizationOptions.Layouts**, la imagen TIFF resultante tendría múltiples páginas, la imagen GIF tendría múltiples cuadros y el formato PSD tendría múltiples capas, donde cada página/cuadro/capa representa un diseño de AutoCAD individual. En caso de que se seleccione cualquier otro formato de imagen como PNG, BMP, JPEG para almacenar el resultado, entonces la API renderizará solo el diseño por defecto; es decir, "Modelo".

{{% /alert %}} 
## **Habilitando el seguimiento del proceso de renderización CAD**
Aspose.CAD ha introducido una serie de clases y campos de enumeración de soporte para ayudar con el seguimiento del proceso de renderización CAD. Con estos cambios en su lugar, la conversión de CAD a PDF ahora se puede lograr de la siguiente manera habilitando el seguimiento.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-EnableTracking.java" >}}



{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-DXFDrawings-EnableTracking-CadRenderHandler.java" >}}



El seguimiento del proceso de renderización CAD puede detectar los siguientes problemas posibles.

1. Información de encabezado faltante o dañada.
1. Información de diseño faltante.
1. Entidades de bloque faltantes.
1. Estilos de dimensión faltantes.
1. Estilos faltantes.
## **Sustitución de fuentes al convertir dibujos CAD**
Es bastante posible que un dibujo CAD particular use alguna fuente específica que no esté disponible en la máquina donde se está realizando la conversión de CAD a PDF o CAD a imagen de ráster. En tales situaciones, la API de Aspose.CAD generará una excepción apropiada para resaltar la falta de fuente(s) y detener el proceso de conversión porque la API requiere estas fuentes para renderizar correctamente el contenido en el PDF y/o imágenes resultantes.
La API de Aspose.CAD proporciona una manera fácil de usar el mecanismo para sustituir la(s) fuente(s) requeridas con la(s) fuente(s) disponible(s). La propiedad **CadImage.Styles** devuelve una instancia de **CadStylesDictionary** que a su vez contiene el **CadStyleTableObject** para cada estilo en el dibujo CAD, mientras que el **CadStyleTableObject.PrimaryFontName** puede ser utilizado para especificar el nombre de la fuente disponible.

El siguiente fragmento de código demuestra el uso de Aspose.CAD para Java API para cambiar la fuente de todos los estilos en un dibujo CAD.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFont-SubstituteFont.java" >}}




También es posible cambiar la fuente de solo un estilo particular accediendo a él a través del nombre del estilo. El siguiente fragmento de código demuestra el uso de este enfoque.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-SubstituteFontOfAParticularStyle-SubstituteFontOfAParticularStyle.java" >}}




## **Conversión de capas CAD a formatos de imagen de ráster**
Aspose.CAD para Java API ha expuesto un medio eficiente y fácil de usar para especificar el nombre de la capa CAD requerida y renderizarla a formatos de imagen de ráster. Aquí está cómo puede lograr lo mismo en 5 simples pasos como se detalla a continuación.

1. Cargue el archivo CAD en una instancia de **Image** usando el método de fábrica **load**.
1. Cree una instancia de **CadRasterizationOptions** y establezca sus propiedades obligatorias como **PageWidth** y **PageHeight**.
1. Agregue el nombre de capa deseado utilizando el método **CadRasterizationOptions.Layers.add**.
1. Cree una instancia de **ImageOptionsBase** y establezca su propiedad **VectorRasterizationOptions** a la instancia de **CadRasterizationOptions** creada en el paso anterior.
1. Llame al método **Image.save** pasando la ruta del archivo (o un objeto de MemoryStream) así como la instancia de **ImageOptionsBase** creada en el paso anterior.

Aquí está el código fuente completo.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertCADLayerToRasterImageFormat-ConvertCADLayerToRasterImageFormat.java" >}}




### **Conversión de todas las capas CAD a imágenes separadas**
Puede obtener todas las capas de un dibujo CAD utilizando **CadImage.Layers** y renderizar cada capa a una imagen separada como se demuestra a continuación.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-CADConversion-ConvertAllCADLayersToSeparateImages-ConvertAllCADLayersToSeparateImages.java" >}}


## **Conversión de capas CAD DWF a formatos de imagen de ráster**
Aspose.CAD para Java API ha expuesto un medio eficiente y fácil de usar para especificar el nombre de la capa CAD requerida y renderizarla a formatos de imagen de ráster. Aquí está cómo puede lograr lo mismo en 5 simples pasos como se detalla a continuación.

1. Cargue el archivo DWF CAD en una instancia de **Image** usando el método de fábrica **Load**.
1. Cree una instancia de **CadRasterizationOptions** y establezca sus propiedades obligatorias como **PageWidth** y **PageHeight**.
1. Agregue el nombre de capa deseado utilizando el método **CadRasterizationOptions.Layers.Add**.
1. Cree una instancia de **ImageOptionsBase** y establezca su propiedad **VectorRasterizationOptions** a la instancia de **CadRasterizationOptions** creada en el paso anterior.
1. Llame al método **Image.Save** pasando la ruta del archivo (o un objeto de MemoryStream) así como la instancia de **ImageOptionsBase** creada en el paso anterior.

Aquí está el código fuente completo.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingCAD-ExportToBMP-ExportToBMP.java" >}}
