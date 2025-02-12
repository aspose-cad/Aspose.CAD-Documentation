---
title: Ρύθμιση Δειγμάτων
type: docs
weight: 40
url: /el/jasperreports/installation/demos-setup/
---

{{% alert color="primary" %}}

Το Aspose.CAD για JasperReports περιλαμβάνει αρκετά έργα δειγμάτων για να σας βοηθήσει να ξεκινήσετε.

Τα δείγματα που παρέχονται με το Aspose.CAD για JasperReports είναι πρότυπα δείγματα JasperReports που έχουν τροποποιηθεί για να δείξουν τη χρήση των νέων εξαγωγέων.

{{% /alert %}}

Για να εκτελέσετε τα δείγματα του Aspose.CAD για JasperReports, εκτελέστε τα εξής βήματα:

1. Κατεβάστε το JasperReports (π.χ. https://sourceforge.net/projects/jasperreports/files/archive/). Βεβαιωθείτε ότι έχετε κατεβάσει ολόκληρο το αρχειοθετημένο έργο με τον πηγαίο κώδικα και τα δείγματα, όχι απλώς ένα μόνο JAR.
1. Αποσυμπιέστε το αρχειοθετημένο έργο σε μια τοποθεσία στον σκληρό σας δίσκο, για παράδειγμα C:\.
1. Αντιγράψτε όλους τους φακέλους δειγμάτων από τον φάκελο \samples του **aspose-cad-xx.x.zip** στο **\InstallDir\demo\samples**, όπου το "\InstallDir" είναι η τοποθεσία στην οποία έχετε αποσυμπιέσει το JasperReports. Αυτό το βήμα είναι απαραίτητο γιατί τα scripts κατασκευής δειγμάτων στηρίζονται στη δομή φακέλων του JasperReports, διαφορετικά θα χρειαστεί να τροποποιήσετε τα scripts κατασκευής.
1. Αντιγράψτε το **aspose-cad-jasperreports-xx.x.jar** από το φάκελο \lib του **aspose-cad-jasperreports-xx.x.zip** στο **\InstallDir\lib**.
1. Ετοιμάστε το Ant Build Tool και τον Ivy Dependency Manager, δείτε το **\InstallDir\readme.txt**.
1. Τροποποιήστε το **build.xml** στο **\InstallDir\demo\samples**, προσθέστε το aspose-cad-jasperreports-xx.x.jar στο classpath:
   **\<path id="project-classpath"> ... \<pathelement location="../../lib/aspose-cad-jasperreports-xx.xx.jar"/> </path>**.
1. Αλλάξτε τον τρέχοντα φάκελο σε **\InstallDir\demo\hsqldb** και εκτελέστε την παρακάτω γραμμή εντολών:
   **Ant runServer**
1. Αλλάξτε τον τρέχοντα φάκελο σε ένα από τα δείγματα του Aspose.CAD για JasperReports, για παράδειγμα **\InstallDir\demo\samples\charts.ai** και εκτελέστε τις παρακάτω εντολές στη γραμμή εντολών:
   **ant test** - για να παραγάγετε αρχεία αναφοράς.
1. Ανοίξτε ένα από τα παραγόμενα έγγραφα για να δείτε, για παράδειγμα **\InstallDir\demo\samples\charts.ai\build\reports\AreaChartReport.jpg**.
