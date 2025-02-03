---
title: Εισαγωγή σχεδίου DXF/DWG μέσα σε DXF
type: docs
weight: 39
url: /el/net/how-to/insert-dxf-dwg-drawing-inside-dxf/
---

## **Πώς να εισάγετε σχέδιο DXF/DWG μέσα σε DXF**

**Ζήτημα:** Πώς να εισάγετε σχέδιο DXF/DWG μέσα σε DXF.

**Συμβουλές:** Για να το κάνετε αυτό, πρέπει πρώτα να δημιουργήσετε ένα CadInsertObject με τις απαραίτητες τιμές, στη συνέχεια να λάβετε όλα τα μπλοκ στο CadBlockDictionary, να δημιουργήσετε ένα νέο μπλοκ CadBlockEntity και να το προσθέσετε στο CadBlockDictionary, να προσθέσετε το CadBlockDictionary στις BlockEntities του σχεδίου, να προσθέσετε ένα CadInsertObject στις οντότητες του σχεδίου για τον πίνακα.

**Παράδειγμα:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "insert-dxf-dwg-drawing-inside-dxf.cs" >}}
