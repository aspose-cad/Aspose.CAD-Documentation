---
title: Προσθήκη εικόνας ως φόντο στο DWG
type: docs
weight: 15
url: /el/net/developer-guide/how-to/addition-of-image-as-background-into-dwg/
---

## **Πώς να προσθέσετε μια εικόνα ως φόντο στο DWG**

**Θέμα:** Πώς να προσθέσετε μια εικόνα ως φόντο στο DWG.

**Συμβουλές:** Για να το κάνετε αυτό, δημιουργήστε ένα αντικείμενο CadRasterImageDef για την εικόνα φόντου, δημιουργήστε ένα αντικείμενο CadRasterImage για να εισάγετε το φόντο για το σχέδιο, προσθέστε ένα αντικείμενο CadRasterImage στα αντικείμενα σχεδίασης, δημιουργήστε ένα αντικείμενο CadBaseObject και προσθέστε το στα cadImage.Objects, επεξεργαστείτε τα πάντα μέσω του CadBlockTableObject.

**Παράδειγμα:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "addition-of-image-as-background-into-dwg.cs" >}}
