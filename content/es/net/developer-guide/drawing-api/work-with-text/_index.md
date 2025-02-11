---
title: Trabajar con texto
type: docs
weight: 40
url: /es/net/work-with-text/
---

## **Trabajar con texto**

Casi todos los dibujos contienen objetos de texto y estos ejemplos muestran cómo realizar operaciones con ellos. 
Existen diferentes tipos de entidades para DWG/DXF que pueden almacenar texto, son [**CadText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadtext/), 
[**CadMText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadmtext/),
CadAttDef, CadAttrib. Los dos últimos tipos están típicamente relacionados 
con [**CadInsertObject**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadinsertobject/)
y se almacenan dentro de él o en el bloque correspondiente.

Aquí hay algunos ejemplos que describen operaciones con texto.

### **Buscar el texto**

Este ejemplo muestra cómo encontrar valores de texto en el archivo DWG/DXF y también se puede utilizar para reemplazar valores de texto.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Search for text.cs">}}

### **Agregar nuevos elementos de Texto y MText**

Aquí está el ejemplo de cómo agregar nuevos objetos de Texto/Mtext al dibujo. La adición de nuevas entidades puede cambiar el tamaño del dibujo, por lo que se recomienda
llamar a UpdateSize() después de estas operaciones.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Adding text_mtext.cs">}}
