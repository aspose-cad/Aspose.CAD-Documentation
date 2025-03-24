---
title: Installation d'Aspose.CAD pour Python
type: docs
weight: 20
url: /fr/python-net/installation/installing-aspose-cad-for-python/
---

## **Installation du paquet aspose-cad**

### Utilisation de pip pour installer un paquet

1. Pour installer le paquet [aspose.cad](https://pypi.org/project/aspose-cad/), les sites avec le paquet ont une description supplémentaire de la commande à exécuter dans le terminal :<br/>
![pypi-install](/cad/_assets/python-net/install/pypi-aspose-cad.png)
1. Un exemple de commande pour installer un paquet via le terminal :
{{< highlight plain >}}
pip install aspose-cad
{{< /highlight >}}
![pip-install-aspose-cad](/cad/_assets/python-net/install/pip-install-aspose.png)

### Utilisation d'un fichier WHL pour installer un paquet

1. Pour télécharger le fichier whl, rendez-vous sur la page pypi du paquet [aspose.cad](https://pypi.org/project/aspose-cad/#files) et téléchargez le fichier<br/>
![whl-download](/cad/_assets/python-net/install/download-whl-file.png)<br/>
1. Pour installer le paquet [aspose.cad](https://pypi.org/project/aspose-cad/), vous devez utiliser la commande pip avec le chemin complet vers le fichier whl :
{{< highlight plain >}}
pip install C:\Users\User\Desktop\aspose_cad-23.6-py3-none-win_amd64.whl
{{< /highlight >}}
![install-whl-file](/cad/_assets/python-net/install/install-whl-file-terminal.png)

1. Après l'installation, nous verrons le paquet dans le dossier site-package<br/>
![site-package-aspose-cad](/cad/_assets/python-net/install/site-package-aspose.png)

## Exemple de code
Exemple de code pour convertir un fichier

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
