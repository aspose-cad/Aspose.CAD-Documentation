---
title: Trabajar con texto
type: docs
weight: 40
url: /es/python-net/work-with-text/
---

## **Trabajar con texto**

Casi todos los dibujos contienen objetos de texto y estos ejemplos muestran cómo realizar operaciones con ellos. 
Existen diferentes tipos de entidades para DWG/DXF que pueden almacenar texto, son **CadText**, **CadMText**, CadAttDef, CadAttrib. Los dos últimos tipos están típicamente relacionados 
con **CadInsertObject** y se almacenan dentro de él o en el bloque correspondiente.

Aquí hay algunos ejemplos que describen operaciones con texto.

### **Buscar el texto**

Este ejemplo muestra cómo encontrar valores de texto en el archivo DWG/DXF y también puede ser utilizado para reemplazar los valores de texto.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Search-for-text.py">}}
