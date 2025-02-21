---
title: Помилки зворотного виклику під час експорту та завантаження
type: docs
weight: 40
url: /uk/net/developer-guide/callback-errors-during-export-and-loading/
---

## **Огляд помилок зворотного виклику під час експорту та завантаження**

Можливо, що під час експорту або завантаження креслення ми зіштовхнемося з помилками, пов'язаними зі структурою файлу
(наприклад, у файлі тепер потрібні секції, які раніше не були необхідні).
Деякі з них є критичними, і в таких випадках викидається виключення, але ми також можемо ігнорувати деякі з них внутрішньо та повідомляти про це за допомогою повідомлень зворотного виклику.
В будь-якому випадку, всі ці повідомлення вимагають уваги, оскільки вони можуть пояснити, наприклад, відсутні сутності у результатах експорту або інші ефекти.


### **Помилки під час експорту**

Є поле RenderResult в [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/),
яке містить IsRenderComplete, щоб дізнатися, чи були помилки під час експорту та надрукувати інформацію про них:

{{< gist aspose-com-gists 90b8a0a5ce7d0fc5d8d9a8c5bf4b816d "Render-result-error-messages.cs">}}

### **Помилки під час завантаження**

Деякі проблеми з кресленнями можуть бути виявлені ще до початку процесу експорту.
Властивість [**Errors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/errors/) в
[**LoadOptions**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/) об'єкті використовується для зберігання повідомлень про них.
Властивість [**IgnoreErrors**](https://reference.aspose.com/cad/net/aspose.cad/loadoptions/ignoreerrors/) корисна для вирішення питання,
чи потрібно викидати виключення при помилках завантаження, чи ні.

Ось приклад використання властивості Errors:

{{< gist aspose-com-gists b4f8af514a57a37e260cf1128011d34d "Errors-in-load-options.cs">}}
