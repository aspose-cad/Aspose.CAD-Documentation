---
title: Angular में Aspose.CAD का उपयोग कैसे करें
type: docs
description: "Angular में Aspose.CAD का उपयोग करें।"
weight: 71
url: /hi/javascript-net/showcases/how-to-use-aspose-cad-in-angular/
---

## पूर्वापेक्षाएँ
- Angular CLI
- Visual Code
- Node.js

## dgn छवि को png में परिवर्तित करें और ब्राउज़र में प्रदर्शित करें

इस उदाहरण में, आप एक साधारण रूपांतरण कार्यक्रम बनाते हैं जो एक चित्रण को परिवर्तित करता है और इसे एक छवि के रूप में सहेजता है।

## Angular प्रोजेक्ट बनाना

1. सुनिश्चित करें कि आप पहले से ही Angular कार्यक्षेत्र निर्देशिका में नहीं हैं।
1. एक नया शुरू करें और फिर कार्यक्रम का नाम बताएं या Visual Code या WebStorm जैसी अन्य कार्यक्रमों का उपयोग करके एक प्रोजेक्ट बनाएं:
{{< highlight plain >}}
ng new angular-example
{{< /highlight >}}
1. npm पैकेज से Aspose.CAD स्थापित करें
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. angular.json फ़ाइल खोलें और स्क्रिप्ट फ़ील्ड में एक प्रविष्टि जोड़ें, यह स्क्रिप्ट प्रोजेक्ट के साथ लोड होना शुरू करती है, यह फ़ाइलों को संसाधित करना शुरू करने के लिए आवश्यक है
{{< highlight plain >}}
"scripts": [
  "node_modules/aspose-cad/dotnet.js"
]
{{< /highlight >}}
1. app.component.html में, चित्रण को लोड और प्रदर्शित करने के लिए फ़ाइल और img टैग बनाएं
{{< highlight plain >}}
<span style="background-color: red">
    <input type="file" class="file-upload" (change)="onFileSelected($event)" />
    <img alt="" id="image" [src]="imageUrl" />
</span>
{{< /highlight >}}
1. app.component.ts में, हम सहायक प्रक्रियाओं को शुरू करने, संसाधित करने और छवि को सहेजने की प्रक्रिया का वर्णन करते हैं
{{< highlight plain >}}
import {Component} from '@angular/core';
import {DomSanitizer} from '@angular/platform-browser';
import {Image} from "aspose-cad/commonjs/Core/Image";
import {PngOptions} from "aspose-cad/commonjs/Options/PngOptions";

//dotnet प्रक्रिया को बूट करने की आवश्यकता है
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
    console.log("aspose-cad WASM लोड हो रहा है...");
    await dotnet.boot().then((ex: any) => {
      console.log("aspose-cad WASM लोड हो गया है");
    });
  }

  // @ts-ignore
  async onFileSelected(event) {

    const file: File = event.target.files[0];
    file.arrayBuffer().then(async buff => {
      let x = new Uint8Array(buff);
      
      this.imgFile = await Image.Load(x); //छवि लोड करें
      console.log(this.imgFile);
      var exportedFile = await Image.Save(this.imgFile, new PngOptions()); //png में छवि सहेजें

      var urlCreator = window.URL || window.webkitURL;
      var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
      
      //परिवर्तित छवि के लिए src बनाएँ
      this.imageUrl = this.sanitizer.bypassSecurityTrustUrl(urlCreator.createObjectURL(blob));

      //png छवि डाउनलोड करें
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
1. एप्लिकेशन शुरू करें
{{< highlight plain >}}
npm start
//या
ng serve
{{< /highlight >}}
{{% alert color="primary" %}} 
ng serve कमांड:

- एप्लिकेशन का निर्माण करता है
- विकास सर्वर चालू करता है
- स्रोत फ़ाइलों पर नजर रखता है
- जब आप परिवर्तन करते हैं तो एप्लिकेशन को फिर से बनाता है

--open ध्वज http://localhost:4200 पर एक ब्राउज़र खोलता है।
{{% /alert %}}

## कार्यान्वयन उदाहरण

1. फ़ाइल चुनें।<br>
![Choose file](/cad/_assets/javascript-net/angular/choose-file.png)<br>
1. कोई भी DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG फ़ाइल चुनें।
1. यदि उत्तर सफल है, तो फ़ाइल स्क्रीन पर प्रदर्शित होगी और इसे डाउनलोड करने की पेशकश करेगी।<br>
![Convert image](/cad/_assets/javascript-net/angular/convert-image.png)<br>

## अन्य देखें

- [Angular CLI स्थापित करें](https://angular.io/guide/setup-local/)
- [Visual Code स्थापित करें](https://code.visualstudio.com/)
- [Node.js स्थापित करें](https://nodejs.org/en/)
