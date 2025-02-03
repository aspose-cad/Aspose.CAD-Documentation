---
title: Εξαγωγή σχεδίου DWG/DXF και διατάξεων σε καθορισμένο μέγεθος
type: docs
weight: 40
url: /el/java/export-into-size/
---

## **Εξαγωγή Μοντέλου και όλων των διατάξεων σε μέγεθος PDF A4**

Η API Aspose.CAD σας επιτρέπει να εξάγετε όλα τα φύλλα του αρχείου DWG/DXF σε καθορισμένο φυσικό μέγεθος PDF. 
Ο παρακάτω δείγμα κώδικα ρυθμίζει το μέγεθος του αντικειμένου [**CadRasterizationOptions**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/CadRasterizationOptions/) για να επιτύχει το επιθυμητό μέγεθος PDF. 
Το μέγεθος του φύλλου χαρτιού A4 είναι 210x297 χιλιοστά ή 8.27x11.69 ίντσες και αυτές οι τιμές χρησιμοποιούνται στον κώδικα.

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "set-page-size.java">}}

## **Εξαγωγή Διατάξεων CAD σε PDF σε διαφορετικό μέγεθος**

Μερικές φορές είναι απαραίτητο να εξάγετε τη διάταξη στο φυσικό της μέγεθος. Το παρακάτω παράδειγμα δείχνει την εξαγωγή του σχεδίου σε πολυσελίδα PDF όπου κάθε σελίδα με περιεχόμενο διάταξης έχει το δικό της φυσικό μέγεθος PDF. Αυτό το παράδειγμα χρησιμοποιεί την ιδιότητα [**getLayoutPageSizes**](https://reference.aspose.com/cad/java/com.aspose.cad.imageoptions/VectorRasterizationOptions#getLayoutPageSizes--).

{{< gist aspose-com-gists 49c1b75d9a84e149ecf374ece2c2597d "export-different-pages-sizes.java">}}
