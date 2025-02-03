---
title: Εξαγωγή σχεδίου DWG/DXF και διατάξεων σε καθορισμένο μέγεθος
type: docs
weight: 40
url: /el/net/export-into-size/
---

## **Εξαγωγή μοντέλου και όλων των διατάξεων σε μέγεθος PDF A4**

Η API Aspose.CAD σας επιτρέπει να εξάγετε όλα τα φύλλα του αρχείου DWG/DXF σε καθορισμένο φυσικό μέγεθος PDF.

Ο παρακάτω δείγμα κώδικα ρυθμίζει το μέγεθος του αντικειμένου [**CadRasterizationOptions**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/cadrasterizationoptions/) για να επιτευχθεί το επιθυμητό μέγεθος PDF. 
Το μέγεθος του φύλλου A4 είναι 210x297 χιλιοστά ή 8.27x11.69 ίντσες και αυτές οι τιμές χρησιμοποιούνται στον κώδικα.

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Calculate sizes for A4.cs">}}

## **Εξαγωγή διατάξεων CAD σε PDF σε διαφορετικό μέγεθος**

Κάποιες φορές απαιτείται η εξαγωγή της διάταξης στο φυσικό της μέγεθος. Το παρακάτω παράδειγμα δείχνει την εξαγωγή του σχεδίου σε πολυσέλιδο PDF όπου κάθε σελίδα με το περιεχόμενο της διάταξης
έχει το δικό της φυσικό μέγεθος PDF. Αυτό το παράδειγμα χρησιμοποιεί την ιδιότητα [**LayoutPageSizes**](https://reference.aspose.com/cad/net/aspose.cad.imageoptions/vectorrasterizationoptions/layoutpagesizes/).

{{< gist aspose-com-gists 88cdd0899132edaf0afff77d33d11ae5 "Export to multipage with different pages sizes.cs">}}
