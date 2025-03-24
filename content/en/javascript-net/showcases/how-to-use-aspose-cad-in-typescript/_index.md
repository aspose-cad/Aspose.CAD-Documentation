---
title: How to use Aspose.CAD in TypeScript
type: docs
description: "Use Aspose.CAD in TypeScript."
weight: 74
url: /javascript-net/showcases/how-to-use-aspose-cad-in-typescript/
---


## Prerequisites
- Visual Code + Live Server
- Node.js

## Convert dgn image to png and display in browser

In this example, you create a simple conversion program that converts a drawing and saves it as an image.

## Creating the JavaScript

1. Create package.json in project folder
{{< highlight plain >}}
npm init -y
{{< /highlight >}}
1. Modify package.json, add aspose-cad dependencies
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
1. Create index.ts
{{< highlight plain >}}
import { PngOptions, Image } from './node_modules/aspose-cad/es2015/index.js';

declare let window: any;
window.processDrawing = async function processDrawing(array: Uint8Array): Promise<any> {

    //GET_FILE_FORMAT
    var fileFormat = Image.getFileFormat(array);
    console.log(fileFormat);
    
    // LOAD
    var file = Image.load(array);
    console.log(file);
    
    // SAVE
    var exportedFilePromise = Image.save(array, new PngOptions());
    return await exportedFilePromise.then(exportedFile => {
      console.log(exportedFile);
      
      return exportedFile;
    });
}
{{< /highlight >}}
1. Use the npm command to create index.js
{{< highlight plain >}}
tsc
{{< /highlight >}}
1. Create index.html
{{< highlight plain >}}
<!DOCTYPE html>
Open console (Ctrl+Shift+I) to see the output.

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

1. Install the packages using the npm command
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. Start application with [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) or yarn
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## Execution example

1. Choose file.<br>
![Choose file](/cad/_assets/javascript-net/typescript/choose-file.png)<br>
1. Select any DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG file.
1. If the answer is successful, the file will be displayed on the screen and will offer to download it.<br>
![Convert image](/cad/_assets/javascript-net/typescript/convert-image.png)<br>
## See Also

- [Install Visual Code](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [Install Node.js](https://nodejs.org/en/)