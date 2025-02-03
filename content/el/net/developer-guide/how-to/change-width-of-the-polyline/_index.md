---
title: Αλλαγή πλάτους της πολυγραμμής
type: docs
weight: 20
url: /el/net/how-to/change-width-of-the-polyline/
---

## **Πώς να αλλάξετε το πλάτος της πολυγραμμής**

**Ζήτημα:** Πώς να αλλάξετε το πλάτος της πολυγραμμής (CADNET-459-460).

**Συμβουλές:** Για να αλλάξετε το πλάτος στο CadBaseEntity (αν τύπος CadEntityTypeName.LWPOLYLINE) χρησιμοποιήστε (entity as CadLwPolyline).ConstantWidth = 2 ή για κανονικές οντότητες LineWeight.

**Παράδειγμα:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "change-width-of-the-polyline.cs" >}}
