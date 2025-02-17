---
title: איך להשתמש ב-Aspose.CAD באנגולר
type: docs
description: "השתמשו ב-Aspose.CAD באנגולר."
weight: 71
url: /he/javascript-net/showcases/how-to-use-aspose-cad-in-angular/
---

## דרישות מוקדמות
- Angular CLI
- Visual Code
- Node.js

## המרת תמונת dgn לפורמט png והצגתה בדפדפן

בדוגמה זו, אתם יוצרים תוכנית המרה פשוטה הממירה שרטוט ושומרת אותו כתמונה.

## יצירת פרויקט אנגולר

1. ודאו שאינכם נמצאים כבר בתיקיית עבודה של אנגולר.
1. התחילו חדשה ואז הקשו את שם התוכנית או השתמשו בתוכניות אחרות כדי ליצור פרויקט כגון Visual Code או WebStorm:
{{< highlight plain >}}
ng new angular-example
{{< /highlight >}}
1. התקינו את Aspose.CAD מחבילת npm
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. פתחו את הקובץ angular.json והוסיפו רשומה בשדה הסקריפט, סקריפט זה מתחיל לטעון עם הפרויקט, ויש צורך להתחיל לעבד את הקבצים
{{< highlight plain >}}
"scripts": [
  "node_modules/aspose-cad/dotnet.js"
]
{{< /highlight >}}
1. ב-app.component.html, צרו תגי input מסוג file ו-img כדי לטעון ולהציג את השרטוט
{{< highlight plain >}}
<span style="background-color: red">
    <input type="file" class="file-upload" (change)="onFileSelected($event)" />
    <img alt="" id="image" [src]="imageUrl" />
</span>
{{< /highlight >}}
1. ב-app.component.ts, אנו מתארים את תהליך התחלת העזר, עיבוד ושמירת התמונה
{{< highlight plain >}}
import {Component} from '@angular/core';
import {DomSanitizer} from '@angular/platform-browser';
import {Image} from "aspose-cad/commonjs/Core/Image";
import {PngOptions} from "aspose-cad/commonjs/Options/PngOptions";

//צריך להפעיל את תהליך dotnet
declare let dotnet: any;
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'angular-example';

  imageUrl: any;
  imgFile: Uint8Array | null | undefined;

  constructor(private sanitizer: DomSanitizer) {
  }

  // @ts-ignore
  async ngOnInit() {
    console.log("הטעינה של aspose-cad WASM...");
    await dotnet.boot().then((ex: any) => {
      console.log("aspose-cad WASM הוטע");
    });
  }

  // @ts-ignore
  async onFileSelected(event) {

    const file: File = event.target.files[0];
    file.arrayBuffer().then(async buff => {
      let x = new Uint8Array(buff);
      
      this.imgFile = await Image.Load(x); //לטעון תמונה
      console.log(this.imgFile);
      var exportedFile = await Image.Save(this.imgFile, new PngOptions()); //שמור תמונה כ-png

      var urlCreator = window.URL || window.webkitURL;
      var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
      
      //צור src עבור התמונה המומרת
      this.imageUrl = this.sanitizer.bypassSecurityTrustUrl(urlCreator.createObjectURL(blob));

      // הורד את התמונה בפורמט png
      let url = window.URL.createObjectURL(blob);
      let a = document.createElement('a');
      document.body.appendChild(a);
      a.setAttribute('style', 'display: none');
      a.href = url;
      a.download = "file.png";
      a.click();
      window.URL.revokeObjectURL(url);
      a.remove();

    });
  }
}
{{< /highlight >}}
1. הפעל את היישום
{{< highlight plain >}}
npm start
//או
ng serve
{{< /highlight >}}
{{% alert color="primary" %}} 
הפקודה ng serve:

- בונה את היישום
- מפעילה את השרת לפיתוח
- עוקבת אחרי קבצי המקור
- בונה מחדש את היישום כשהכניסו שינויים

הדגל --open פותח דפדפן אל http://localhost:4200.
{{% /alert %}}

## דוגמת ביצוע

1. בחרו קובץ.<br>
![בחר קובץ](/_assets/javascript-net/angular/choose-file.png)<br>
1. בחרו כל קובץ DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG.
1. אם התשובה מצליחה, הקובץ יוצג על המסך ויוצע להוריד אותו.<br>
![המרת תמונה](/_assets/javascript-net/angular/convert-image.png)<br>

## ראו גם

- [התקנת Angular CLI](https://angular.io/guide/setup-local/)
- [התקנת Visual Code](https://code.visualstudio.com/)
- [התקנת Node.js](https://nodejs.org/en/)
