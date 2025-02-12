---
title: Εισαγωγή σχεδίου DXF/DWG μέσα σε DWG
type: docs
weight: 38
url: /el/net/developer-guide/how-to/insert-dxf-dwg-drawing-inside-dwg/
---

## **Πώς να εισαγάγετε σχέδιο DXF/DWG μέσα σε DWG**

**Ζήτημα:** Πώς να εισαγάγετε σχέδιο DXF/DWG μέσα σε DWG.

**Συμβουλές:** Για να το κάνετε αυτό, πρώτα δημιουργήστε ένα CadInsertObject με τις απαιτούμενες τιμές, στη συνέχεια αποκτήστε όλα τα μπλοκ σε ένα CadBlockDictionary, δημιουργήστε μια νέα οντότητα CadBlockEntity μπλοκ και προσθέστε την στο CadBlockDictionary, προσθέστε ένα CadBlockDictionary στις BlockEntities του σχεδίου, προσθέστε ένα CadInsertObject στην οντότητα σχεδίου για τον πίνακα, δημιουργήστε ένα CadBlockTableObject με αναφορά, στη συνέχεια προσθέστε ένα μπλοκ στο σχέδιο.

**Παράδειγμα:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dwg.cs" >}}
