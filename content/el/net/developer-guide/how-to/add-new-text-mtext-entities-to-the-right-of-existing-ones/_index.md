---
title: Προσθήκη νέων οντοτήτων TEXT/MTEXT στα δεξιά των υπαρχουσών 
type: docs
weight: 17
url: /el/net/developer-guide/how-to/add-new-text-mtext-entities-to-the-right-of-existing-ones/
---

## **Πώς να προσθέσετε νέες οντότητες TEXT/MTEXT στα δεξιά των υπαρχουσών**

**Θέμα:** Πώς να προσθέσετε νέες οντότητες TEXT/MTEXT στα δεξιά των υπαρχουσών (CADNET-8172).

**Συμβουλές:** Για να το κάνετε αυτό, δημιουργήστε ένα αντικείμενο CadBaseEntity, δημιουργήστε ένα CadMText ή CadText με κείμενο, στο νέο αντικείμενο προσθέστε στην ιδιότητα SoftOwner το cadImage.Layouts["Model"].BlockTableRecordHandle από το σχέδιο και προσθέστε το στο μπλοκ cadImage.BlockEntities[" *MODEL_SPACE"] και προσθέστε το νέο αντικείμενο στις οντότητες του σχεδίου.

**Παράδειγμα:**

{{< gist "aspose-com-gists" "9a239eab0b9dda0e1c54be533ea399bb" "add-new-text-mtext-entities-to-the-right-of-existing-ones.cs" >}}
