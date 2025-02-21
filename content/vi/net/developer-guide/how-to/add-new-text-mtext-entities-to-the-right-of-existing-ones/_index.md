---
title: Thêm các thực thể TEXT/MTEXT mới ở bên phải các thực thể hiện có
type: docs
weight: 17
url: /vi/net/developer-guide/how-to/add-new-text-mtext-entities-to-the-right-of-existing-ones/
---

## **Cách thêm các thực thể TEXT/MTEXT mới ở bên phải các thực thể hiện có**

**Vấn đề:** Cách thêm các thực thể TEXT/MTEXT mới ở bên phải các thực thể hiện có (CADNET-8172).

**Mẹo:** Để thực hiện điều này, tạo một đối tượng CadBaseEntity, tạo một CadMText hoặc CadText với văn bản, trong đối tượng mới thêm cadImage.Layouts["Model"].BlockTableRecordHandle từ bản vẽ vào trường SoftOwner và thêm nó vào khối cadImage.BlockEntities[" *MODEL_SPACE"] và thêm đối tượng mới vào các thực thể bản vẽ.

**Ví dụ:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "add-new-text-mtext-entities-to-the-right-of-existing-ones.cs" >}}
