---
title: Работа с текст
type: docs
weight: 40
url: /bg/net/developer-guide/drawing-api/work-with-text/
---

## **Работа с текст**

Почти всички чертежи съдържат текстови обекти и тези примери показват как да извършвате операции с тях.
Съществуват различни типове ентитети за DWG/DXF, които могат да съхраняват текст, те са [**CadText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadtext/), 
[**CadMText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadmtext/),
CadAttDef, CadAttrib. Двете последни типове са обикновено свързани 
с [**CadInsertObject**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadinsertobject/)
и се съхраняват в него или в съответния блок.

Ето някои примери, описващи операциите с текст.

### **Търсене на текста**

Този пример показва как да намерите стойности на текст във файл DWG/DXF и може да се използва също за заместване на стойности на текст.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Search for text.cs">}}

### **Добавяне на нови текстове и MText елементи**

Ето примера как да добавите нови текстови/Mtext обекти към чертежа. Добавянето на нови ентитети може да промени размера на чертежа, затова се препоръчва
да се извика UpdateSize() след тези операции.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Adding text_mtext.cs">}}
