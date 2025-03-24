---
title: Aspose.CAD को Python के लिए स्थापित करना
type: docs
weight: 20
url: /hi/python-net/installation/installing-aspose-cad-for-python/
---

## **Aspose-cad पैकेज की स्थापना**

### पैकेज स्थापित करने के लिए pip का उपयोग करना

1. [aspose.cad](https://pypi.org/project/aspose-cad/) पैकेज स्थापित करने के लिए, पैकेज वाले साइटों में टर्मिनल में निष्पादित किए जाने वाले कमांड का एक अतिरिक्त विवरण होता है:<br/>
![pypi-install](/cad/_assets/python-net/install/pypi-aspose-cad.png)
1. टर्मिनल के माध्यम से पैकेज स्थापित करने के लिए एक कमांड का उदाहरण:
{{< highlight plain >}}
pip install aspose-cad
{{< /highlight >}}
![pip-install-aspose-cad](/cad/_assets/python-net/install/pip-install-aspose.png)

### पैकेज स्थापित करने के लिए WHL फ़ाइल का उपयोग करना

1. whl फ़ाइल डाउनलोड करने के लिए, [aspose.cad](https://pypi.org/project/aspose-cad/#files) पैकेज के pypi पृष्ठ पर जाएं और फ़ाइल डाउनलोड करें<br/>
![whl-download](/cad/_assets/python-net/install/download-whl-file.png)<br/>
1. [aspose.cad](https://pypi.org/project/aspose-cad/) पैकेज स्थापित करने के लिए, आपको whl फ़ाइल के पूर्ण पथ के साथ pip कमांड का उपयोग करना होगा:
{{< highlight plain >}}
pip install C:\Users\User\Desktop\aspose_cad-23.6-py3-none-win_amd64.whl
{{< /highlight >}}
![install-whl-file](/cad/_assets/python-net/install/install-whl-file-terminal.png)

1. स्थापना के बाद, हम साइट-पैकेज फ़ोल्डर में पैकेज देखेंगे<br/>
![site-package-aspose-cad](/cad/_assets/python-net/install/site-package-aspose.png)

## उदाहरण कोड
एक फ़ाइल को परिवर्तित करने के लिए उदाहरण कोड

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
