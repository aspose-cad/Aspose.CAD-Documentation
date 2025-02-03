---
title: Εγκατάσταση του Aspose.CAD για Python
type: docs
weight: 20
url: /el/python-net/installing-aspose-cad-for-python/
---

## **Εγκατάσταση του πακέτου aspose-cad**

### Χρήση του pip για την εγκατάσταση ενός πακέτου

1. Για να εγκαταστήσετε το πακέτο [aspose.cad](https://pypi.org/project/aspose-cad/), οι ιστότοποι με το πακέτο έχουν μια επιπλέον περιγραφή της εντολής που πρέπει να εκτελεστεί στην κονσόλα:<br/>
![pypi-install](pypi-aspose-cad.png)
1. Ένα παράδειγμα εντολής για την εγκατάσταση ενός πακέτου μέσω της κονσόλας:
{{< highlight plain >}}
pip install aspose-cad
{{< /highlight >}}
![pip-install-aspose-cad](pip-install-aspose.png)

### Χρήση αρχείου WHL για την εγκατάσταση ενός πακέτου

1. Για να κατεβάσετε το αρχείο whl, μεταβείτε στη σελίδα pypi του πακέτου [aspose.cad](https://pypi.org/project/aspose-cad/#files) και κατεβάστε το αρχείο<br/>
![whl-download](download-whl-file.png)<br/>
1. Για να εγκαταστήσετε το πακέτο [aspose.cad](https://pypi.org/project/aspose-cad/), πρέπει να χρησιμοποιήσετε την εντολή pip με την πλήρη διαδρομή προς το αρχείο whl:
{{< highlight plain >}}
pip install C:\Users\User\Desktop\aspose_cad-23.6-py3-none-win_amd64.whl
{{< /highlight >}}
![install-whl-file](install-whl-file-terminal.png)

1. Μετά την εγκατάσταση, θα δούμε το πακέτο στον φάκελο site-package<br/>
![site-package-aspose-cad](site-package-aspose.png)

## Παράδειγμα κώδικα
Παράδειγμα κώδικα για την μετατροπή ενός αρχείου

{{< highlight plain >}}
import aspose.cad as cad

if __name__ == '__main__':
    
    image = cad.Image.load("drawing.dxf")

    rasterizationOptions = cad.imageoptions.CadRasterizationOptions()
    rasterizationOptions.page_height = 1200.0
    rasterizationOptions.page_width = 1200.0
    
    pdfOptions = cad.imageoptions.PdfOptions()
    pdfOptions.vector_rasterization_options = rasterizationOptions
    image.save("output.pdf", pdfOptions)
{{< /highlight >}}
