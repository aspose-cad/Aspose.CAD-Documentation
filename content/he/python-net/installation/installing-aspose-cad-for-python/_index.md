---
title: התקנת Aspose.CAD עבור Python
type: docs
weight: 20
url: /he/python-net/installation/installing-aspose-cad-for-python/
---

## **התקנה של חבילת aspose-cad**

### שימוש ב-pip כדי להתקין חבילה

1. כדי להתקין את חבילת [aspose.cad](https://pypi.org/project/aspose-cad/), האתרים עם החבילה מכילים תיאור נוסף של הפקודה שתתבצע בטרמינל:<br/>
![pypi-install](/_assets/python-net/install/pypi-aspose-cad.png)
1. דוגמה לפקודה להתקנת חבילה דרך הטרמינל:
{{< highlight plain >}}
pip install aspose-cad
{{< /highlight >}}
![pip-install-aspose-cad](/_assets/python-net/install/pip-install-aspose.png)

### שימוש בקובץ WHL כדי להתקין חבילה

1. כדי להוריד את קובץ ה-whl, גשו לדף pypi של חבילת [aspose.cad](https://pypi.org/project/aspose-cad/#files) והורידו את הקובץ<br/>
![whl-download](/_assets/python-net/install/download-whl-file.png)<br/>
1. כדי להתקין את חבילת [aspose.cad](https://pypi.org/project/aspose-cad/), יש להשתמש בפקודת pip עם הנתיב המלא לקובץ ה-whl:
{{< highlight plain >}}
pip install C:\Users\User\Desktop\aspose_cad-23.6-py3-none-win_amd64.whl
{{< /highlight >}}
![install-whl-file](/_assets/python-net/install/install-whl-file-terminal.png)

1. לאחר ההתקנה, נוכל לראות את החבילה בתיקיית site-package<br/>
![site-package-aspose-cad](/_assets/python-net/install/site-package-aspose.png)

## קוד דוגמה
קוד דוגמה להמרת קובץ

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
