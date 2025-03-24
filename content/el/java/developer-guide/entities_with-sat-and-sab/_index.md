---
title: Οντότητες με δομή SAT/SAB
type: docs
weight: 40
url: /el/java/developer-guide/entities_with-sat-and-sab/
---

## **Οντότητες με δομή SAT/SAB**

Ορισμένες οντότητες αποθηκεύουν τα δομικά τους δεδομένα σε μορφή ACIS SAT/SAB. Αυτές οι οντότητες μπορούν να εξαχθούν μερικώς σε λειτουργία 2D wireframe. Οι υποστηριζόμενες οντότητες περιλαμβάνουν:

*	3DSOLID αντικείμενα: κουτί, σφαίρα, πυραμίδα, πριόνι, κώνος, κύλινδρος, τορπίλη, πολυσωλήνας
*	EΠΙΦΑΝΕΙΑ: επίπεδη, εξωθημένη, επαναστατική, πλυμένη
*	ΠΕΡΙΦΕΡΕΙΑ

Παρακάτω είναι το παράδειγμα του αποτελέσματος εξαγωγής (αρχείο DWG στην αριστερή πλευρά, αποτέλεσμα PDF στη δεξιά).

![Εξαγωγή κώνου και σφαιρών](/cad/_assets/guide/coneAndSpheres.png)

Η εξαγωγή οντοτήτων ACIS δεν απαιτεί καμία ειδική επιλογή. Για να βελτιστοποιήσετε το μέγεθος του σχεδίου, ειδικά όταν το σχέδιο περιέχει αποκλειστικά οντότητες ACIS, συνιστάται να χρησιμοποιήσετε τη λειτουργία cadImage.updateSize() για να προσαρμόσετε τις αρχικές διαστάσεις του σχεδίου με ακρίβεια.

```java
CadImage cadImage = (CadImage)Image.load(sourceFilePath);

// Ενημερώστε το μέγεθος του σχεδίου
cadImage.updateSize();
	
CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
rasterizationOptions.setLayouts(new String[]{"Model"});

PdfOptions pdfOptions = new PdfOptions();
pdfOptions.setVectorRasterizationOptions(rasterizationOptions);

cadImage.save("output.pdf", pdfOptions);
```
