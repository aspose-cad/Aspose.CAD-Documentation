---
title: Добавяне на нови същества за ТЕКСТ/МТЕКСТ отдясно на съществуващите
type: документация
weight: 17
url: /bg/how-to/add-new-text-mtext-entities-to-the-right-of-existing-ones/
---

## **Как да добавите нови същества за ТЕКСТ/МТЕКСТ отдясно на съществуващите**

**Проблем:** Как да добавите нови същества за ТЕКСТ/МТЕКСТ отдясно на съществуващите (CADNET-8172).

**Съвети:** За да постигнете това, създайте обект CadBaseEntity, създайте CadMText или CadText с текст, в новия обект добавете cadImage.Layouts["Model"].BlockTableRecordHandle от чертежа към полето SoftOwner и добавете го към блока cadImage.BlockEntities[" *MODEL_SPACE"] и добавете новия обект към съществата на чертежа.

**Пример:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "add-new-text-mtext-entities-to-the-right-of-existing-ones.cs" >}}
