---
title: Робота з текстом
type: docs
weight: 40
url: /uk/net/developer-guide/drawing-api/work-with-text/
---

## **Робота з текстом**

Практично всі малюнки містять текстові об'єкти, і ці приклади демонструють, як виконувати операції з ними. 
Існують різні типи сутностей для DWG/DXF, які можуть зберігати текст, це [**CadText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadtext/), 
[**CadMText**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadmtext/),
CadAttDef, CadAttrib. Два останні типи зазвичай пов'язані 
з [**CadInsertObject**](https://reference.aspose.com/cad/net/aspose.cad.fileformats.cad.cadobjects/cadinsertobject/)
і зберігаються всередині нього або в відповідному блоці.

Ось кілька прикладів, що описують операції з текстом.

### **Пошук тексту**

Цей приклад показує, як знайти текстові значення в файлі DWG/DXF і може використовуватися також для заміни текстових значень.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Search for text.cs">}}

### **Додавання нових елементів Text та MText**

Ось приклад того, як додати нові об'єкти Text/MText до малюнка. Додавання нових сутностей може змінити розмір малюнка, тому рекомендується
викликати UpdateSize() після цих операцій.

{{< gist aspose-com-gists acb77f1d4bcc8c121978050f5ab2eb6e "Adding text_mtext.cs">}}
