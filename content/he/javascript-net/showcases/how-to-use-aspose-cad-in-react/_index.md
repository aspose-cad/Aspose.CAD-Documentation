---
title: איך להשתמש ב-Aspose.CAD ב-React
type: docs
description: "השתמש ב-Aspose.CAD ב-React"
weight: 75
url: /he/javascript-net/showcases/how-to-use-aspose-cad-in-react/
---

## דרישות מוקדמות
- Visual Code
- Node.js

## המרת תמונת dgn ל-png והצגתה בדפדפן

בדוגמה זו, תיצור תוכנית המרה פשוטה שממירה ציור ושומרת אותו כתמונה.

## יצירת פרויקט React

1. ודא שאתה לא כבר בתיקיית עבודה של React.
1. התחל אחת חדשה ולאחר מכן את שם התוכנית או השתמש בתוכניות אחרות ליצירת פרויקט כמו Visual Code או WebStorm:
{{< highlight plain >}}
npx create-react-app react-example
{{< /highlight >}}
1. התקן את Aspose.CAD מחבילת npm
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. צור תגי קובץ קלט ותמונה כדי לטעון ולהציג את הציור
{{< highlight plain >}}
<span style="background-color: red">
  <input id="file" type="file"/>
  <img alt="המומר" id="image" />
</span>
{{< /highlight >}}
1. ב-App.tsx, אנו מתארים את תהליך התחלת תהליכי עזר, עיבוד ושמירת התמונה
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
          <img alt="המומר" id="image" />
      </header>
    </div>
  );
}

window.onload = async function () {
  console.log("טוען WASM...");
  await boot();
  console.log("נשאר WASM");

  // @ts-ignore
    document.querySelector('input').addEventListener('change', function() {
        var reader = new FileReader();
        reader.onload = function() {

          var arrayBuffer = this.result;
          // @ts-ignore
          var array = new Uint8Array(arrayBuffer);

          // טען
          var file = Image.load(array);

          // שמור
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
1. הפעל את היישום
{{< highlight plain >}}
npm start
{{< /highlight >}}

## דוגמת ביצוע

1. בחר קובץ.<br>
![בחר קובץ](/cad/_assets/javascript-net/react/choose-file.png)<br>
1. בחר כל קובץ DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. אם התשובה מצליחה, הקובץ יוצג על המסך ויוצע להוריד אותו.<br>
![המרת תמונה](/cad/_assets/javascript-net/react/convert-image.png)<br>

## ראה גם

- [התקן את Visual Code](https://code.visualstudio.com/)
- [התקן את Node.js](https://nodejs.org/en/)
