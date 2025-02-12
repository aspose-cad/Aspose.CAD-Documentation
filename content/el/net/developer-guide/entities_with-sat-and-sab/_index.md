---
title: Οντότητες με δομή SAT/SAB
type: docs
weight: 40
url: /el/net/support-sat-sab/
---

## **Οντότητες με δομή SAT/SAB**

Ορισμένες οντότητες αποθηκεύουν τα δομικά τους δεδομένα στη μορφή ACIS SAT/SAB. Αυτές οι οντότητες μπορούν να εξαχθούν μερικώς σε λειτουργία 2D wireframe. Οι υποστηριζόμενες οντότητες περιλαμβάνουν:

*	Αντικείμενα 3DSOLID: κουτί, σφαίρα, πυραμίδα, κώνος, κύλινδρος, τορικός, πολυσωματικός
*	ΕΠΙΦΑΝΕΙΑ: επίπεδη, εξωθημένη, περιστρεφόμενη, σαρωνική
*	ΠΕΡΙΟΧΗ

Παρακάτω είναι το παράδειγμα του αποτελέσματος εξαγωγής (αρχείο DWG στην αριστερή πλευρά, αποτέλεσμα PDF στη δεξιά).

![Εξαγωγή κώνου και σφαιρών](/_assets/guide/coneAndSpheres.png)

Η εξαγωγή οντοτήτων ACIS δεν απαιτεί ειδικές επιλογές. Για να βελτιστοποιήσετε το μέγεθος σχεδίασης, ιδιαίτερα όταν η σχεδίαση περιλαμβάνει αποκλειστικά οντότητες ACIS, σκεφτείτε να χρησιμοποιήσετε τη λειτουργία cadImage.UpdateSize() για να ρυθμίσετε με ακρίβεια τις αρχικές διαστάσεις σχεδίασης.

```csharp
using (CadImage cadImage = (CadImage)Image.Load(sourceFilePath))
{
	cadImage.UpdateSize();
	
	CadRasterizationOptions rasterizationOptions = new CadRasterizationOptions();
	rasterizationOptions.Layouts = new string[] { "Model" };

	PdfOptions pdfOptions = new PdfOptions
	{
		VectorRasterizationOptions = rasterizationOptions
	};
	cadImage.Save("output.pdf", pdfOptions);
}
```
