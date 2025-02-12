---
title: Изчисляване на лице и обиколка на окръжностите
type: docs
weight: 18
url: /bg/net/developer-guide/how-to/calculation-of-area-and-circumference-of-the-circles/
---

## **Как да изчислите лице и обиколка на окръжностите**

**Проблем:** Как да изчислите лице и обиколка на окръжностите (CADNET-1153).

**Съвети:** За да направите това, вземете радиуса от CadEntityTypeName.CIRCLE от същностите и използвайте формулата **"2 * Math.PI * радиус"**.

**Пример:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "изчисляване-на-лице-и-обиколка-на-окръжностите.cs" >}}
