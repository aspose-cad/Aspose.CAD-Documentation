---
title: Експорт лише деяких шарів із зміною масштабу
type: docs
weight: 31
url: /uk/net/developer-guide/how-to/export-of-only-some-layers-with-rescaling/
---

## **Експорт лише деяких шарів із зміною масштабу (CADNET-559)**

**Проблема:** Як експортувати лише деякі шари із зміною масштабу (CADNET-559).

**Поради:** Для цього виберіть необхідні шари, додайте їх до масиву CadBaseEntity, потім призначте їх до об'єктів креслення та виконайте UpdateSize.

**Приклад:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "export-of-only-some-layers-with-rescaling.cs" >}}
