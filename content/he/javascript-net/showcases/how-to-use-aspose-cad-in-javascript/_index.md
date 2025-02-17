---
title: איך להשתמש ב-Aspose.CAD ב-JavaScript
type: docs
description: "להשתמש ב-Aspose.CAD ב-JavaScript."
weight: 73
url: /he/javascript-net/showcases/how-to-use-aspose-cad-in-javascript/
---

## דרישות מוקדמות
- Visual Code + Live Server
- Node.js

## המרת תמונת dgn ל-png והצגתה בדפדפן

בדוגמה זו, אתה יוצר תוכנית המרה פשוטה הממירה ציור ושומרת אותו כתמונה.

## יצירת ה-JavaScript

1. צור package.json עם תלותי aspose-cad
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

1. התקן את החבילות בעזרת פקודת npm
{{< highlight plain >}}
npm install
{{< /highlight >}}
1. הפעל את היישום בעזרת [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/) או yarn
{{< highlight plain >}}
npm run serve
{{< /highlight >}}

## דוגמת ביצוע

1. בחר קובץ.<br>
![בחר קובץ](/_assets/javascript-net/javascript-net/choose-file.png)<br>
1. בחר כל קובץ DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. אם התשובה מוצלחת, הקובץ יוצג על המסך ויוצע להוריד אותו.<br>
![המרת תמונה](/_assets/javascript-net/javascript-net/convert-image.png)<br>
## עיין גם

- [התקן את Visual Code](https://code.visualstudio.com/)
- [Live Server](https://marketplace.visualstudio.com/items?itemName=ritwickdey.LiveServer/)
- [התקן את Node.js](https://nodejs.org/en/)
