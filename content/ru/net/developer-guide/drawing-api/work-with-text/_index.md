---
title: Работа с текстом
type: docs
weight: 40
url: /ru/net/developer-guide/drawing-api/work-with-text/
---

## **Работа с текстом**

Практически все рисунки содержат текстовые объекты, и эти примеры показывают, как выполнять операции с ними. 
Существует несколько типов сущностей для DWG/DXF, которые могут хранить текст, это [**CadText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadtext/), 
[**CadMText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadmtext/),
CadAttDef, CadAttrib. Два последних типа обычно связаны 
с [**CadInsertObject**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadinsertobject/)
и хранятся внутри него или в соответствующем блоке.

Вот несколько примеров, описывающих операции с текстом.

### **Поиск текста**

Этот пример показывает, как найти значения текста в файле DWG/DXF и может также использоваться для замены текстовых значений.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Search for text.cs">}}

### **Добавление новых элементов Text и MText**

Вот пример того, как добавить новые объекты Text/Mtext в рисунок. Добавление новых сущностей может изменить размер рисунка, поэтому рекомендуется
вызывать UpdateSize() после этих операций.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Adding text_mtext.cs">}}
