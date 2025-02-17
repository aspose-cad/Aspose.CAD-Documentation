---
title: Aspose.CAD का TypeScript में उपयोग कैसे करें
type: docs
description: "TypeScript में Aspose.CAD का उपयोग करें।"
weight: 74
url: /hi/javascript-net/showcases/how-to-use-aspose-cad-in-typescript/
---


## पूर्व शर्तें
- विज़ुअल कोड + लाइव सर्वर
- नोड.जेएस

## dgn छवि को png में परिवर्तित करें और ब्राउज़र में प्रदर्शित करें

इस उदाहरण में, आप एक सरल रूपांतरण कार्यक्रम बनाते हैं जो एक चित्र को परिवर्तित करता है और उसे छवि के रूप में सहेजता है।

## जावास्क्रिप्ट बनाना

1. प्रोजेक्ट फ़ोल्डर में package.json बनाएं
{{< highlight plain >}}
npm init -y
{{< /highlight >}}
1. package.json को संशोधित करें, aspose-cad निर्भरता जोड़ें
{{< highlight plain >}}
"dependencies": {
    "aspose-cad": "^23.1.0"
  },
 "devDependencies": {
    "live-server": "^1.2.1",
    "typescript": "^3.3.3333",
    "yarn": "^1.22.19"
  }
{{< /highlight >}}
1. index.ts बनाएं
{{< highlight plain >}}
import { PngOptions, Image } from './node_modules/aspose-cad/es2015/index.js';

declare let window: any;
window.processDrawing = async function processDrawing(array: Uint8Array): Promise<any> {

    //फाइल प्रारूप प्राप्त करें
    var fileFormat = Image.getFileFormat(array);
    console.log(fileFormat);
    
    // लोड करें
    var file = Image.load(array);
    console.log(file);
    
    // सहेजें
    var exportedFilePromise = Image.save(array, new PngOptions());
    return await exportedFilePromise.then(exportedFile => {
      console.log(exportedFile);
      
      return exportedFile;
    });
}
{{< /highlight >}}
1. npm कमांड का उपयोग करके index.js बनाएं
{{< highlight plain >}}
tsc
{{< /highlight >}}
1. index.html बनाएं
{{< highlight plain >}}
<!DOCTYPE html>
कंसोल खोलें (Ctrl+Shift+I) आउटपुट देखने के लिए।

<script src="./node_modules/aspose-cad/dotnet.js"></script>
<script type="module" src="./node_modules/aspose-cad/es2015/index-js.js"></script>

<body>
	<input id="file" type="file">
	<img id="image" />
</body>

<script>
window.onload = async function () {
	document.querySelector('input').addEventListener('change', function() {
      var reader = new FileReader();
      reader.onload = function() {
      
          var arrayBuffer = this.result;
          var array = new Uint8Array(arrayBuffer);
          
		  //फाइल प्रारूप प्राप्त करें
		  fileFormat = Aspose.CAD.Image.getFileFormat(array);
          console.log(fileFormat);
		  
		  // लोड करें
		  file = Aspose.CAD.Image.load(array);
          console.log(file);
		  
		  // सहेजें
		  exportedFilePromise = Aspose.CAD.Image.save(array, new Aspose.CAD.PngOptions());
		  exportedFilePromise.then(exportedFile => {
			console.log(exportedFile);
			
			var urlCreator = window.URL || window.webkitURL;
			var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
            var imageUrl = urlCreator.createObjectURL(blob);
            document.querySelector("#image").src = imageUrl;
		  });
      }
	  
      reader.readAsArrayBuffer(this.files[0]);
    }, 
	false);
};
</script>
{{< /highlight >}}

1. npm कमांड का उपयोग करके पैकेज स्थापित करें
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. [लाइव सर्वर](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) या यार्न के साथ एप्लिकेशन प्रारंभ करें
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## कार्यान्वयन उदाहरण

1. फ़ाइल चुनें।<br>
![Choose file](/_assets/javascript-net/typescript/choose-file.png)<br>
1. कोई भी DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG फ़ाइल चुनें।
1. यदि उत्तर सफल है, तो फ़ाइल स्क्रीन पर प्रदर्शित होगी और इसे डाउनलोड करने की पेशकश की जाएगी।<br>
![Convert image](/_assets/javascript-net/typescript/convert-image.png)<br>
## अन्य देखें

- [विजुअल कोड स्थापित करें](https://code.visualstudio.com/)
- [लाइव सर्वर](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [नोड.जेएस स्थापित करें](https://nodejs.org/en/)
