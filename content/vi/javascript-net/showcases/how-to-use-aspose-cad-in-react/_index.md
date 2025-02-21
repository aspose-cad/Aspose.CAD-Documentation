---
title: Cách sử dụng Aspose.CAD trong React
type: docs
description: "Sử dụng Aspose.CAD trong React"
weight: 75
url: /vi/javascript-net/showcases/how-to-use-aspose-cad-in-react/
---

## Các yêu cầu trước
- Visual Code
- Node.js

## Chuyển đổi hình ảnh dgn sang png và hiển thị trong trình duyệt

Trong ví dụ này, bạn tạo một chương trình chuyển đổi đơn giản chuyển đổi một bản vẽ và lưu nó dưới dạng hình ảnh.

## Tạo dự án React

1. Đảm bảo rằng bạn không nằm trong thư mục workspace của React.
1. Khởi động một thư mục mới và đặt tên cho chương trình hoặc sử dụng các chương trình khác để tạo dự án như Visual Code hoặc WebStorm:
{{< highlight plain >}}
npx create-react-app react-example
{{< /highlight >}}
1. Cài đặt Aspose.CAD từ gói npm
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. Tạo một thẻ input kiểu file và thẻ img để tải lên và hiển thị bản vẽ
{{< highlight plain >}}
<span style="background-color: red">
  <input id="file" type="file"/>
  <img alt="đã chuyển đổi" id="image" />
</span>
{{< /highlight >}}
1. Trong App.tsx, chúng ta mô tả quá trình khởi động các quy trình trợ giúp, xử lý và lưu hình ảnh
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
          <img alt="đã chuyển đổi" id="image" />
      </header>
    </div>
  );
}

window.onload = async function () {
  console.log("loading WASM...");
  await boot();
  console.log("loaded WASM");

  // @ts-ignore
    document.querySelector('input').addEventListener('change', function() {
        var reader = new FileReader();
        reader.onload = function() {

          var arrayBuffer = this.result;
          // @ts-ignore
          var array = new Uint8Array(arrayBuffer);

          // TẢI
          var file = Image.load(array);

          // LƯU
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
1. Khởi động ứng dụng
{{< highlight plain >}}
npm start
{{< /highlight >}}

## Ví dụ thực hiện

1. Chọn tệp.<br>
![Chọn tệp](/_assets/javascript-net/react/choose-file.png)<br>
1. Chọn bất kỳ tệp DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG nào.
1. Nếu câu trả lời thành công, tệp sẽ được hiển thị trên màn hình và sẽ đề nghị tải xuống.<br>
![Chuyển đổi hình ảnh](/_assets/javascript-net/react/convert-image.png)<br>

## Xem thêm

- [Cài đặt Visual Code](https://code.visualstudio.com/)
- [Cài đặt Node.js](https://nodejs.org/en/)
