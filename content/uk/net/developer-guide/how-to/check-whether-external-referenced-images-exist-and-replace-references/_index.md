---
title: Перевірка наявності зовнішніх посилань на зображення та заміна посилань
type: docs
weight: 22
url: /uk/net/developer-guide/how-to/check-whether-external-referenced-images-exist-and-replace-references/
---

## **Як редагувати гіперпосилання на об'єктах**

**Проблема:** Як перевірити, чи існують зовнішні посилання на зображення, і замінити посилання (CADNET-8088).

**Поради:** Для цього отримайте сутність типу CadObjectTypeName.IMAGEDEF з графічних сутностей та використовуйте CadRasterImageDef для перевірки.

**Приклад:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "check-whether-external-referenced-images-exist-and-replace-references.cs" >}}
