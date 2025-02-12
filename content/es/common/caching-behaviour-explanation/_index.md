---
title: Explicando el comportamiento de caché de Aspose.CAD
type: docs
weight: 20
url: /es/common/caching-behaviour-explanation
---


## **Cómo Aspose.CAD almacena en caché los datos**

Todo el almacenamiento en caché realizado por Aspose.CAD es completamente automático, sin necesidad de entrada o intervención del usuario. Esencialmente, hay tres tipos de almacenamiento en caché, todos ellos relacionados con fuentes.

### **Caché de nombres de fuentes**

La caché de nombres de fuentes se utiliza para facilitar un inicio más rápido al preprocesar todos los archivos de fuente encontrados y compilar una lista de nombres de fuentes presentes en estos archivos, ya que un archivo de fuente puede contener más de una fuente. Se almacena como un archivo temporal y tiene un tamaño máximo de decenas de kilobytes en la mayoría de los sistemas.

### **Caché de datos de glifos de fuentes**

Una caché en memoria de todos los glifos que se han utilizado durante la vida de la aplicación para reducir la lectura repetida de los archivos de fuente en disco durante las exportaciones subsiguientes. Como tal, resultaría en un consumo de memoria en aumento constante si las exportaciones posteriores tuvieran archivos que hacen referencia a nuevas fuentes y/o contienen caracteres no encontrados anteriormente. Sin embargo, en la práctica, incluso en toda la
suite de pruebas de Aspose.CAD, con miles de archivos, incluidos archivos en diferentes idiomas, su consumo de memoria es de aproximadamente 200 megabytes, lo cual no es muy significativo para un sistema moderno.

### **Caché de respaldo de fuentes por carácter**

Una caché en memoria que almacena fuentes que contienen un carácter dado para todos los caracteres Unicode con el fin de facilitar la selección de una fuente de reemplazo en caso de que una fuente proporcionada por una entidad de texto en un dibujo no contenga un carácter en el contenido del texto de esa entidad. Se construye en la primera operación de exportación durante la vida de la aplicación y reside hasta la terminación de la aplicación. En nuestras máquinas de prueba relativamente modestas con colecciones masivas de fuentes utilizadas en las suites de prueba, la caché tarda aproximadamente 30 segundos en construirse y ocupa 70 megabytes. Una vez construida, ya no requiere tiempo y no crece.
