---
title: Робота з текстом
type: docs
weight: 40
url: /uk/python-net/developer-guide/drawing-api/work-with-text/
---

## **Робота з текстом**

Майже всі малюнки містять текстові об'єкти, і ці приклади показують, як виконувати операції з ними. 
Існують різні типи сутностей для DWG/DXF, які можуть зберігати текст, це **CadText**, **CadMText**, CadAttDef, CadAttrib. Два останні типи зазвичай пов'язані 
з **CadInsertObject** і зберігаються всередині нього або в відповідному блоці.

Ось кілька прикладів, що описують операції з текстом.

### **Пошук тексту**

Цей приклад показує, як знайти текстові значення у файлі DWG/DXF та може також використовуватися для заміни текстових значень.

{{< gist "aspose-com-gists" "511bcfad674670f7484dcd1c47480b11" "Search-for-text.py">}}
