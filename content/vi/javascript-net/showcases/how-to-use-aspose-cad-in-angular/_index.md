---
title: Cách sử dụng Aspose.CAD trong Angular
type: docs
description: "Sử dụng Aspose.CAD trong Angular."
weight: 71
url: /vi/javascript-net/showcases/how-to-use-aspose-cad-in-angular/
---

## Các yêu cầu tiên quyết
- Angular CLI
- Visual Code
- Node.js

## Chuyển đổi hình ảnh dgn sang png và hiển thị trong trình duyệt

Trong ví dụ này, bạn sẽ tạo một chương trình chuyển đổi đơn giản để chuyển đổi một bản vẽ và lưu nó dưới dạng hình ảnh.

## Tạo dự án Angular

1. Đảm bảo rằng bạn không ở trong thư mục không gian làm việc Angular.
1. Bắt đầu một cái mới và sau đó đặt tên cho chương trình hoặc sử dụng các chương trình khác để tạo dự án như Visual Code hoặc WebStorm:
{{< highlight plain >}}
ng new angular-example
{{< /highlight >}}
1. Cài đặt Aspose.CAD từ gói npm
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Mở tập tin angular.json và thêm một mục vào trường script, script này sẽ bắt đầu tải khi dự án chạy, nó là cần thiết để bắt đầu xử lý các tập tin
{{< highlight plain >}}
"scripts": [
  "node_modules/aspose-cad/dotnet.js"
]
{{< /highlight >}}
1. Trong app.component.html, tạo một trường nhập liệu kiểu file và thẻ img để tải và hiển thị bản vẽ
{{< highlight plain >}}
<span style="background-color: red">
    <input type="file" class="file-upload" (change)="onFileSelected($event)" />
    <img alt="" id="image" [src]="imageUrl" />
</span>
{{< /highlight >}}
1. Trong app.component.ts, chúng ta mô tả quá trình khởi động các quy trình trợ giúp, xử lý và lưu hình ảnh
{{< highlight plain >}}
import {Component} from '@angular/core';
import {DomSanitizer} from '@angular/platform-browser';
import {Image} from "aspose-cad/commonjs/Core/Image";
import {PngOptions} from "aspose-cad/commonjs/Options/PngOptions";

//cần khởi động quy trình dotnet
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
    console.log("aspose-cad WASM loading...");
    await dotnet.boot().then((ex: any) => {
      console.log("aspose-cad WASM đã được tải");
    });
  }

  // @ts-ignore
  async onFileSelected(event) {

    const file: File = event.target.files[0];
    file.arrayBuffer().then(async buff => {
      let x = new Uint8Array(buff);
      
      this.imgFile = await Image.Load(x); //Tải hình ảnh
      console.log(this.imgFile);
      var exportedFile = await Image.Save(this.imgFile, new PngOptions()); //lưu hình ảnh dưới dạng png

      var urlCreator = window.URL || window.webkitURL;
      var blob = new Blob([exportedFile], { type: 'application/octet-stream' });
      
      //tạo src cho hình ảnh đã chuyển đổi
      this.imageUrl = this.sanitizer.bypassSecurityTrustUrl(urlCreator.createObjectURL(blob));

      //tải hình ảnh png
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
1. Khởi động ứng dụng
{{< highlight plain >}}
npm start
//hoặc
ng serve
{{< /highlight >}}
{{% alert color="primary" %}} 
Lệnh ng serve:

- Xây dựng ứng dụng
- Khởi động máy chủ phát triển
- Theo dõi các tập tin nguồn
- Xây dựng lại ứng dụng khi bạn thực hiện thay đổi

Cờ --open mở một trình duyệt đến http://localhost:4200.
{{% /alert %}}

## Ví dụ thực thi

1. Chọn tệp.<br>
![Chọn tệp](/_assets/javascript-net/angular/choose-file.png)<br>
1. Chọn bất kỳ tệp DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG nào.
1. Nếu câu trả lời thành công, tệp sẽ được hiển thị trên màn hình và sẽ đề nghị tải xuống.<br>
![Chuyển đổi hình ảnh](/_assets/javascript-net/angular/convert-image.png)<br>

## Xem thêm

- [Cài đặt Angular CLI](https://angular.io/guide/setup-local/)
- [Cài đặt Visual Code](https://code.visualstudio.com/)
- [Cài đặt Node.js](https://nodejs.org/en/)
