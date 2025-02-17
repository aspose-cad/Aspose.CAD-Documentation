---
title: Aspose.CAD का उपयोग कैसे करें JavaScript में
type: docs
description: "JavaScript में Aspose.CAD का उपयोग करें।"
weight: 73
url: /hi/javascript-net/showcases/how-to-use-aspose-cad-in-javascript/
---

## आवश्यकताएँ
- विज़ुअल कोड + लाइव सर्वर
- Node.js

## dgn चित्र को png में परिवर्तित करना और ब्राउज़र में दिखाना

इस उदाहरण में, आप एक सरल रूपांतरण कार्यक्रम बनाते हैं जो एक डिज़ाइन को परिवर्तित करता है और उसे एक चित्र के रूप में सहेजता है।

## JavaScript बनाना

1. aspose-cad निर्भरताओं के साथ package.json बनाएं
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
1. index.html बनाएं
{{< highlight plain >}}
<!DOCTYPE html>
कॉन्सोल खोलें (Ctrl+Shift+I) आउटपुट देखने के लिए।

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
          
		  //GET_FILE_FORMAT
		  fileFormat = Aspose.CAD.Image.getFileFormat(array);
          console.log(fileFormat);
		  
		  // LOAD
		  file = Aspose.CAD.Image.load(array);
          console.log(file);
		  
		  // SAVE
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
1. [लाइव सर्वर](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) या yarn के साथ एप्लिकेशन शुरू करें
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## निष्पादन उदाहरण

1. फ़ाइल चुनें।<br>
![Choose file](/_assets/javascript-net/javascript-net/choose-file.png)<br>
1. कोई भी DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG फ़ाइल चुनें।
1. यदि उत्तर सफल होता है, तो फ़ाइल स्क्रीन पर प्रदर्शित होगी और इसे डाउनलोड करने का प्रस्ताव देगी।<br>
![Convert image](/_assets/javascript-net/javascript-net/convert-image.png)<br>
## इसके अलावा देखें

- [Visual Code स्थापित करें](https://code.visualstudio.com/)
- [लाइव सर्वर](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [Node.js स्थापित करें](https://nodejs.org/en/)
