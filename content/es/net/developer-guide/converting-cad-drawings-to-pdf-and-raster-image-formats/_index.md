---
title: DWG DXF a PDF C# | Convertir archivos de Auto CAD a PDF JPEG PNG en C# .NET
type: docs
weight: 30
url: /es/net/converting-cad-drawings-to-pdf-and-raster-image-formats/
keywords: "DWG a PDF C#, DXF a PDF C#, DWF DWT a PDF C#, convertir AutoCAD, convertir DWG, convertir DWF, convertir DWT, convertir DXF, convertir autocad a pdf, convertir DWG a PDF, convertir DWG a PNG, convertir DWG a TIFF, convertir DWG a JPG"
description: Use el convertidor de AutoCAD a PDF de C# .NET para convertir DWG o DXF a PDF en C#. Puede convertir DWG, DWF, DWT y DXF a PDF, JPEG, PNG, BMP, GIF y TIFF en C# .NET también.
---

## **Convertir DWG o DXF a PNG JPEG BMP GIF o TIFF en C#**

Aspose.CAD para .NET puede convertir formatos de dibujo de AutoCAD como [DXF](https://docs.fileformat.com/cad/dxf/) y [DWG](https://docs.fileformat.com/cad/dwg/) a [PNG](https://docs.fileformat.com/image/png/), [BMP](https://docs.fileformat.com/image/bmp/), [TIFF](https://docs.fileformat.com/image/tiff/), [JPEG](https://docs.fileformat.com/image/jpeg/) y [GIF](https://docs.fileformat.com/image/gif/). Ha expuesto una API eficiente y fácil de usar para lograr este objetivo.

Puede convertir cualquier formato de dibujo de AutoCAD soportado a formatos de imagen raster utilizando los simples pasos que se detallan a continuación.

1. Cargue el archivo DWG o DXF de AutoCAD en la clase [**Image**](https://reference.aspose.com/cad/net/aspose.cad/image).
1. Cree una instancia de [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions).
1. Establezca/cambie el tamaño de la imagen utilizando [**PageWidth**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pagewidth) y [**PageHeight**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/properties/pageheight).
1. Cree una instancia de [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase).
1. Establezca la propiedad [**VectorRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions) a las [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) creadas en el paso anterior.
1. Guarde el dibujo de AutoCAD como PDF con [**Image.Save**](https://reference.aspose.com/cad/net/aspose.cad/image/methods/save) pasando la ruta del archivo (o un objeto de MemoryStream) así como la instancia de [**ImageOptionsBase**](https://reference.aspose.com/cad/net/aspose.cad/imageoptionsbase) creada en el paso anterior.

Aquí está el código fuente completo.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertDrawingToRasterImage-ConvertDrawingToRasterImage.cs" >}}

Por defecto, la API renderiza solo el diseño "Modelo". Sin embargo, también puede especificar los diseños de su elección al convertir dibujos CAD a formatos de imagen.

## **Personalizando la conversión CAD**

Los procedimientos de conversión CAD a [PDF](https://docs.fileformat.com/pdf/) y CAD a imagen raster son altamente configurables porque la clase [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions) se ha implementado de tal manera que proporciona muchas características opcionales que al configurarlas pueden anular el proceso de renderizado de acuerdo con las necesidades de la aplicación.

### **Clase CadRasterizationOptions**

La clase **CadRasterizationOptions** es común para todos los formatos CAD soportados como DWG y DXF, por lo tanto, la información compartida en este artículo es válida para ambos formatos CAD mencionados.

Las propiedades más útiles de la clase **CadRasterizationOptions** son:

|**Propiedad**|**Valor por Defecto**|**Requerido**|**Descripción**|
| :- | :- | :- | :- |
|**PageWidth**|**0**|Sí|Especifica el ancho de la página.|
|**PageHeight**|**0**|Sí|Especifica la altura de la página.|
|**ScaleMethod**|**ScaleType.ShrinkToFit**|No|Especifica si el dibujo debe escalarse automáticamente. El valor por defecto reduce automáticamente la imagen para que se ajuste al tamaño del lienzo. Cambie a modo **GrowToFit**, o use la opción **None** para desactivar el escalado automático.|
|**BackgroundColor**|**Color.White**|No|Especifica el color de fondo de la imagen de salida.|
|**DrawType**|**CadDrawTypeMode.UseDrawColor**|No|Especifica el modo de colorización de la entidad. Especifique la opción **UseObjectColor** para dibujar entidades usando su color nativo, o la opción **UseDrawColor** para sobrescribir colores nativos.|
|**DrawColor**|**Color.Black**|No|Especifica el color de la entidad sobrescrita (solo si **DrawType** está configurado al valor de propiedad **UseDrawColor**).|
|**AutomaticLayoutsScaling**|False|No|Especifica si se debe realizar un escalado automático del diseño para que coincida con el diseño del Modelo.|

### **Configurando el tamaño y modo del lienzo**

Exportar de CAD a PDF o CAD a formatos de imagen raster no es una tarea trivial. Dado que el PDF o la imagen resultante requiere que se defina el tamaño del lienzo, necesitamos especificar las dimensiones de salida para que la página PDF renderice correctamente el dibujo. Establezca las propiedades **CadRasterizationOptions.PageWidth** y **CadRasterizationOptions.PageHeight** de manera explícita, o puede obtener una **ImageSaveException**.

Además, puede especificar opciones de escala de dimensiones. Las opciones de escalado se configuran mediante la propiedad **CadRasterizationOptions.ScaleMethod**. Utilice esta opción para ajustar automáticamente las dimensiones de la imagen de acuerdo con los valores de **CadRasterizationOptions.PageWidth** y **CadRasterizationOptions.PageHeight**. Por defecto, **CadRasterizationOptions.ScaleMethod** se configura en modo **ScaleType.ShrinkToFit**. Esta propiedad define el siguiente comportamiento:

- Si las dimensiones del dibujo CAD son mayores que el tamaño del lienzo resultante, entonces las dimensiones del dibujo se reducen para ajustarse al lienzo resultante mientras se preserva la relación de aspecto.
- Si las dimensiones del dibujo CAD son menores que el tamaño del lienzo resultante, establezca la propiedad **CadRasterizationOptions.ScaleMethod** en **ScaleType.GrowToFit** para aumentar el tamaño del dibujo para que se ajuste al lienzo PDF mientras se preserva la relación de aspecto.
- O desactive el escalado automático con la opción **ScaleType.None**.

El siguiente ejemplo de código muestra la opción de escalado automático en uso.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingCanvasSizeAndMode-SettingCanvasSizeAndMode.cs" >}}

### **Configurando los colores de fondo y de dibujo**

Por defecto, la paleta de colores para el lienzo resultante se establece en el esquema de documento común. Eso significa que todas las entidades dentro del dibujo CAD se dibujan con un bolígrafo de color negro sobre un fondo blanco sólido. Estos ajustes se pueden cambiar con las propiedades **CadRasterizationOptions.BackgroundColor** y **CadRasterizationOptions.DrawColor**. Cambiar la propiedad **CadRasterizationOptions.DrawColor** también requiere establecer la propiedad **CadRasterizationOptions.DrawType** para utilizar el color de dibujo. La propiedad **CadRasterizationOptions.DrawType** controla si las entidades CAD preservan sus colores o se convierten a colores personalizados. Para preservar los colores de la entidad, especifique **CadRasterizationOptions.DrawType** como **CadDrawTypeMode.UseObjectColor**, de lo contrario especifique el valor **CadDrawTypeMode.UseDrawColor**.

El siguiente ejemplo de código muestra cómo utilizar diferentes propiedades de color.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingBackgroundAndDrawingColors-SettingBackgroundAndDrawingColors.cs" >}}

### **Configurando el escalado automático del diseño**

La mayoría de los dibujos CAD tienen más de un diseño almacenado en un solo archivo, y cada diseño podría tener diferentes dimensiones. Al renderizar dichos dibujos CAD a PDF, cada página del PDF podría tener un escalado diferente según el tamaño del diseño. Para hacer que el renderizado sea homogéneo, las API de Aspose.CAD han expuesto la propiedad **CadRasterizationOptions.AutomaticLayoutsScaling**. Su valor por defecto es **false**, pero cuando es verdadero, la API intentará buscar una escala correspondiente para cada diseño separado y dibujarlos de manera correspondiente realizando una operación de redimensionamiento automática de acuerdo con el tamaño de la página.

Aquí se muestra cómo funciona la propiedad **CadRasterizationOptions.AutomaticLayoutsScaling** en colaboración con la propiedad **CadRasterizationOptions.ScaleMethod**.

1. Si **ScaleMethod** está configurado en **ScaleType.ShrinkToFit** o **ScaleType.GrowToFit** con **AutomaticLayoutsScaling** configurado en false, entonces todos los diseños (incluyendo el Modelo) se procesarán de acuerdo con la primera opción.
1. Si **ScaleMethod** está configurado en **ScaleType.ShrinkToFit** o **ScaleType.GrowToFit** con **AutomaticLayoutsScaling** configurado en true, entonces todos los diseños (excepto el Modelo) se procesarán de acuerdo con su tamaño mientras que el Modelo se procesará de acuerdo con la primera opción.
1. Si **ScaleMethod** está configurado en **ScaleType.None** con **AutomaticLayoutsScaling** configurado en true o false, entonces no se realizará ningún escalado.

El siguiente ejemplo de código muestra cómo configurar el escalado automático del diseño para la conversión de CAD a PDF.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SettingAutoLayoutScaling-SettingAutoLayoutScaling.cs" >}}

## **Convertir los diseños DXF o DWG de AutoCAD a PNG o otros formatos de imagen en C#**

La API Aspose.CAD para .NET puede convertir los diseños CAD de formatos soportados como DXF y DWG a PNG BMP TIFF JPEG y GIF. La API también proporciona soporte para renderizar los diseños específicos de un dibujo CAD en diferentes capas PSD.

Aquí se muestra cómo puede lograr lo mismo en los siguientes simples pasos.

- Cargue el archivo DWG o DXF de AutoCAD usando la clase **Image**.
- Establezca/cambie el ancho y la altura de la imagen.
- Establezca el/los nombre(s) de diseño deseado(s) utilizando la propiedad CadRasterizationOptions.Layouts.
- Cree una instancia de **ImageOptionsBase** y configure su propiedad **VectorRasterizationOptions** a la instancia de **CadRasterizationOptions** creada en el paso anterior.
- Guarde el diseño CAD como TIFF o imagen.

Aquí está el código fuente completo.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-ConvertLayoutsToRasterImage-ConvertLayoutsToRasterImage.cs" >}}

{{% alert color="primary" %}} 

La propiedad **CadRasterizationOptions.Layouts** es de tipo arreglo de cadenas, por lo que puede especificar más de un diseño a la vez para posible conversión a formatos de imagen. Al especificar múltiples diseños para la propiedad **CadRasterizationOptions.Layouts**, la imagen TIFF resultante tendría múltiples páginas, la imagen GIF tendría múltiples fotogramas y el formato [PSD](https://docs.fileformat.com/image/psd/) tendría múltiples capas, donde cada página/fotograma/capa representa un diseño individual de AutoCAD. En caso de que se seleccione cualquier otro formato de imagen como PNG, BMP, JPEG para almacenar el resultado, entonces la API renderizará solo el diseño por defecto; es decir, "Modelo".

{{% /alert %}}

## **Activando el seguimiento para el proceso de renderizado CAD**

Aspose.CAD ha introducido una serie de clases y campos de enumeración de soporte para ayudar con el seguimiento del proceso de renderizado CAD. Con estos cambios en su lugar, la conversión de CAD a PDF ahora se puede lograr de la siguiente manera habilitando el seguimiento.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-EnableTrackingForCADRendering-EnableTrackingForCADRendering.cs" >}}

El seguimiento del proceso de renderizado CAD puede detectar los siguientes problemas posibles.

1. Información de encabezado faltante o corrupta.
1. Información de diseño faltante.
1. Entidades de bloque faltantes.
1. Estilos de dimensión faltantes.
1. Estilos faltantes.

## **Sustitución de fuentes al convertir dibujos CAD**

Es bastante posible que un dibujo CAD particular use alguna fuente específica que no está disponible en la máquina donde se está llevando a cabo la conversión de CAD a PDF o CAD a imagen raster. En tales situaciones, la API Aspose.CAD generará una excepción apropiada para destacar la(s) fuente(s) faltante(s) y detener el proceso de conversión porque la API requiere estas fuentes para renderizar correctamente los contenidos en el PDF o imágenes resultantes.

La API Aspose.CAD proporciona una manera fácil de utilizar el mecanismo para sustituir la(s) fuente(s) requerida(s) con la(s) fuente(s) disponibles. La propiedad **CadImage.Styles** devuelve una instancia de **CadStylesDictionary** que a su vez contiene el **CadStyleTableObject** para cada estilo en el dibujo CAD, mientras que **CadStyleTableObject.PrimaryFontName** puede ser utilizada para especificar el nombre de la fuente disponible.

El siguiente fragmento de código demuestra el uso de la API Aspose.CAD para .NET para cambiar la fuente de todos los estilos en un dibujo CAD.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-SubstitutingFonts-SubstitutingFonts.cs" >}}

También es posible cambiar la fuente de un solo estilo particular accediendo a él a través del nombre del estilo. El siguiente fragmento de código demuestra el uso de este enfoque.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-SubstitutingFonts-SubstitutingFontByName.cs" >}}

## **Convertir capas CAD a formatos de imagen raster**

La API Aspose.CAD para .NET ha expuesto un medio eficiente y fácil de usar para especificar el nombre de la capa CAD requerida y renderizarla a formatos de imagen raster. Aquí se muestra cómo puede lograr lo mismo en 5 simples pasos como se enumera a continuación.

1. Cargue el archivo CAD en una instancia de **Image** utilizando el método de fábrica **Load**.
1. Cree una instancia de **CadRasterizationOptions** y establezca sus propiedades obligatorias como **PageWidth** y **PageHeight**.
1. Agregue el nombre de la capa deseada utilizando el método **CadRasterizationOptions.Layers.Add**.
1. Cree una instancia de **ImageOptionsBase** y establezca su propiedad **VectorRasterizationOptions** a la instancia de **CadRasterizationOptions** creada en el paso anterior.
1. Llame al método **Image.Save** pasando la ruta del archivo (o un objeto de MemoryStream) así como la instancia de **ImageOptionsBase** creada en el paso anterior.

Aquí está el código fuente completo.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-ConvertingCAD-CADLayersToRasterImageFormats-CADLayersToRasterImageFormats.cs" >}}

### **Convertir todas las capas CAD a imágenes separadas**

Puede obtener todas las capas de un dibujo CAD utilizando **CadImage.Layers** y renderizar cada capa en una imagen separada como se demuestra a continuación.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Examples-CSharp-ConvertingCAD-CADLayersToRasterImageFormats-ConvertAllLayersToRasterImageFormats.cs" >}}

## **Convertir capas CAD DWF a formatos de imagen raster**

La API Aspose.CAD para .NET ha expuesto un medio eficiente y fácil de usar para especificar el nombre de la capa CAD requerida y renderizarla a formatos de imagen raster. Aquí se muestra cómo puede lograr lo mismo en 5 simples pasos como se enumera a continuación.

1. Cargue el archivo CAD DWF en una instancia de **Image** utilizando el método de fábrica **Load**.
1. Cree una instancia de **CadRasterizationOptions** y establezca sus propiedades obligatorias como **PageWidth** y **PageHeight**.
1. Agregue el nombre de la capa deseada utilizando el método **CadRasterizationOptions.Layers.Add**.
1. Cree una instancia de **ImageOptionsBase** y establezca su propiedad **VectorRasterizationOptions** a la instancia de **CadRasterizationOptions** creada en el paso anterior.
1. Llame al método **Image.Save** pasando la ruta del archivo (o un objeto de MemoryStream) así como la instancia de **ImageOptionsBase** creada en el paso anterior.

Aquí está el código fuente completo.

{{< gist "aspose-com-gists" "88cdd0899132edaf0afff77d33d11ae5" "Src-Export-ExportToBMP-ExportToBMP.cs" >}}

Aspose.CAD para .NET escribe directamente la información sobre la API y el número de versión en los documentos de salida. Por ejemplo, al renderizar un documento a PDF, Aspose.CAD para .NET poblará el campo de Aplicación con el valor 'Aspose.CAD' y el campo de Productor de PDF con un valor, por ejemplo, 'Aspose.CAD v 17.10'.

Tenga en cuenta que no puede instruir a Aspose.CAD para .NET que cambie o elimine esta información de los documentos de salida.
