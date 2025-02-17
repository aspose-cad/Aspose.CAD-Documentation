---
title: Aspose.CAD का उपयोग कैसे करें React में
type: docs
description: "React में Aspose.CAD का उपयोग करें"
weight: 75
url: /hi/javascript-net/showcases/how-to-use-aspose-cad-in-react/
---

## पूर्वापेक्षाएँ
- विजुअल कोड
- Node.js

## dgn छवि को png में रूपांतरित करें और ब्राउज़र में प्रदर्शित करें

इस उदाहरण में, आप एक सरल रूपांतरण कार्यक्रम बनाते हैं जो एक डिज़ाइन को रूपांतरित करता है और इसे एक छवि के रूप में सहेजता है।

## React प्रोजेक्ट बनाना

1. सुनिश्चित करें कि आप पहले से किसी React कार्यक्षेत्र निर्देशिका में नहीं हैं।
1. एक नया प्रारंभ करें और फिर कार्यक्रम का नाम दें या विजुअल कोड या वेबस्टॉर्म जैसे अन्य कार्यक्रमों का उपयोग करके एक प्रोजेक्ट बनाएं:
{{< highlight plain >}}
npx create-react-app react-example
{{< /highlight >}}
1. npm पैकेज से Aspose.CAD स्थापित करें
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. डिज़ाइन को लोड और प्रदर्शित करने के लिए एक इनपुट प्रकार फ़ाइल और img टैग बनाएं
{{< highlight plain >}}
<span style="background-color: red">
  <input id="file" type="file"/>
  <img alt="converted" id="image" />
</span>
{{< /highlight >}}
1. App.tsx में, हम सहायक प्रक्रियाओं को प्रारंभ करने, संसाधित करने और छवि को सहेजने की प्रक्रिया का वर्णन करते हैं
{{< highlight plain >}}
import React from 'react';
import './App.css';
import {boot} from "aspose-cad/dotnet";
import {Image, PngOptions} from "aspose-cad";
function App() {
  return (
    <div className="App">
      <header className="App-header">
          <input id="file" type="file"/>
          <img alt="converted" id="image" />
      </header>
    </div>
  );
}

window.onload = async function () {
  console.log("WASM लोड हो रहा है...");
  await boot();
  console.log("WASM लोड हो गया");

  // @ts-ignore
    document.querySelector('input').addEventListener('change', function() {
        var reader = new FileReader();
        reader.onload = function() {

          var arrayBuffer = this.result;
          // @ts-ignore
          var array = new Uint8Array(arrayBuffer);

          // लोड
          var file = Image.load(array);

          // सहेजें
          var exportedFilePromise = Image.save(array, new PngOptions());
          exportedFilePromise.then((exportedFile: BlobPart) => {
            console.log(exportedFile);

            var urlCreator = window.URL || window.webkitURL;
            var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
            var imageUrl = urlCreator.createObjectURL(blob);
            // @ts-ignore
            document.querySelector("#image").src = imageUrl;
          });
        }
        // @ts-ignore
        reader.readAsArrayBuffer(this.files[0]);
      },
      false);
};
export default App;

{{< /highlight >}}
1. एप्लिकेशन शुरू करें
{{< highlight plain >}}
npm start
{{< /highlight >}}

## निष्पादन उदाहरण

1. फ़ाइल चुनें।<br>
![Choose file](/_assets/javascript-net/react/choose-file.png)<br>
1. कोई भी DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG फ़ाइल चुनें।
1. यदि उत्तर सफल है, तो फ़ाइल स्क्रीन पर प्रदर्शित होगी और इसे डाउनलोड करने का विकल्प प्रदान करेगी।<br>
![Convert image](/_assets/javascript-net/react/convert-image.png)<br>

## अन्य देखें

- [Visual Code स्थापित करें](https://code.visualstudio.com/)
- [Node.js स्थापित करें](https://nodejs.org/en/)
