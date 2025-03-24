---
title: כיצד להשתמש בAspose.CAD בTypeScript
type: docs
description: "שימוש בAspose.CAD בTypeScript."
weight: 74
url: /he/javascript-net/showcases/how-to-use-aspose-cad-in-typescript/
---

## דרישות מקדימות
- Visual Code + Live Server
- Node.js

## המרת תמונת dgn לpng והצגתה בדפדפן

בדוגמה זו, תיצור תוכנית המרה פשוטה שממירה ציור ושומרת אותו כתמונה.

## יצירת הJavaScript

1. צור package.json בתיקיית הפרויקט
{{< highlight plain >}}
npm init -y
{{< /highlight >}}
1. שנה את package.json, הוסף תלותים של aspose-cad
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
1. צור index.ts
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
1. השתמש בפקודת npm כדי ליצור index.js
{{< highlight plain >}}
tsc
{{< /highlight >}}
1. צור index.html
{{< highlight plain >}}
<!DOCTYPE html>
פתח את הקונסולה (Ctrl+Shift+I) כדי לראות את הפלט.

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

1. התקן את החבילות באמצעות פקודת npm
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. הפעל את היישום עם [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) או yarn
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## דוגמת ביצוע

1. בחר קובץ.<br>
![בחר קובץ](/cad/_assets/javascript-net/typescript/choose-file.png)<br>
1. בחר כל קובץ DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. אם התשובה היא מוצלחת, הקובץ יופיע על המסך ויוצע להוריד אותו.<br>
![המרת תמונה](/cad/_assets/javascript-net/typescript/convert-image.png)<br>
## ראו גם

- [התקן את Visual Code](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [התקן את Node.js](https://nodejs.org/en/)
