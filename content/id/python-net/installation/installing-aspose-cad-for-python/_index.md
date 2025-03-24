---
title: Menginstal Aspose.CAD untuk Python
type: docs
weight: 20
url: /id/python-net/installation/installing-aspose-cad-for-python/
---

## **Instalasi paket aspose-cad**

### Menggunakan pip untuk menginstal paket

1. Untuk menginstal paket [aspose.cad](https://pypi.org/project/aspose-cad/), situs dengan paket tersebut memiliki deskripsi tambahan tentang perintah yang harus dieksekusi di terminal:<br/>
![pypi-install](/cad/_assets/python-net/install/pypi-aspose-cad.png)
1. Contoh perintah untuk menginstal paket melalui terminal:
{{< highlight plain >}}
pip install aspose-cad
{{< /highlight >}}
![pip-install-aspose-cad](/cad/_assets/python-net/install/pip-install-aspose.png)

### Menggunakan file WHL untuk menginstal paket

1. Untuk mengunduh file whl, pergi ke halaman pypi dari paket [aspose.cad](https://pypi.org/project/aspose-cad/#files) dan unduh file tersebut<br/>
![whl-download](/cad/_assets/python-net/install/download-whl-file.png)<br/>
1. Untuk menginstal paket [aspose.cad](https://pypi.org/project/aspose-cad/), Anda perlu menggunakan perintah pip dengan jalur lengkap ke file whl:
{{< highlight plain >}}
pip install C:\Users\User\Desktop\aspose_cad-23.6-py3-none-win_amd64.whl
{{< /highlight >}}
![install-whl-file](/cad/_assets/python-net/install/install-whl-file-terminal.png)

1. Setelah instalasi, kita akan melihat paket di folder site-package<br/>
![site-package-aspose-cad](/cad/_assets/python-net/install/site-package-aspose.png)

## Contoh kode
Contoh kode untuk mengonversi sebuah file

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
