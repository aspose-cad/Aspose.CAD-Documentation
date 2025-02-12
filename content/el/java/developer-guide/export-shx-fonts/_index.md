---
title: Εξαγωγή γραμματοσειρών SHX
type: docs
weight: 40
url: /el/java/developer-guide/export-shx-fonts/
---

## **Εξαγωγή γραμματοσειρών SHX για σχέδια DXF/DWG**

Ορισμένα σχέδια μπορεί να περιέχουν γραμματοσειρές σε ειδική μορφή SHX, η οποία αποθηκεύει τα σύμβολα της γραμματοσειράς με τη μορφή σχημάτων. Αυτή η μορφή απαιτεί πρόσθετη διαδικασία φόρτωσης για κάθε γραμματοσειρά που χρησιμοποιείται στο σχέδιο. Η Apose.CAD μπορεί να εξάγει σχέδια με κείμενο γραμμένο σε SHX και έχει διαφορετικές επιλογές για να το κάνει αυτό. Ο πιο απλός τρόπος για να το κάνετε είναι απλά να χρησιμοποιήσετε την ιδιότητα [**setShxFonts**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions#setShxFonts-java.lang.String:A-) της αντικειμένου [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions).

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxFonts-example.java">}}

Κάθε γραμματοσειρά SHX συνοδεύεται από τον κατάλληλο κωδικοποιητή που σχετίζεται με αυτήν. Αυτές οι συσχετίσεις είναι γνωστές και μερικώς ενσωματωμένες στο Aspose.CAD για γνωστές γραμματοσειρές SHX. Σε περίπτωση που χρησιμοποιείται κάποια προσαρμοσμένη γραμματοσειρά SHX, είναι δυνατή η εφαρμογή της ιδιότητας **setShxCodePages** και η ρύθμιση διαδρομής στο αρχείο SHX και την αντίστοιχη σελίδα κωδικών.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "setShxCodePages-example.java">}}
