---
title: Aspose.CAD를 React에서 사용하는 방법
type: docs
description: "React에서 Aspose.CAD 사용하기"
weight: 75
url: /ko/javascript-net/showcases/how-to-use-aspose-cad-in-react/
---

## 전제 조건
- 비주얼 코드
- Node.js

## dgn 이미지를 png로 변환하고 브라우저에 표시하기

이 예제에서는 도면을 변환하고 이미지를 저장하는 간단한 변환 프로그램을 만듭니다.

## React 프로젝트 만들기

1. 이미 React 작업 공간 디렉토리에 있지 않은지 확인하세요.
1. 새 작업 공간을 시작하고 프로그램의 이름을 정하거나 Visual Code 또는 WebStorm과 같은 다른 프로그램을 사용하여 프로젝트를 만드세요:
{{< highlight plain >}}
npx create-react-app react-example
{{< /highlight >}}
1. npm 패키지에서 Aspose.CAD 설치
{{< highlight plain >}}
npm install aspose-cad
{{< /highlight >}}
1. 도면을 로드하고 표시할 입력 유형 파일 및 img 태그 만들기
{{< highlight plain >}}
<span style="background-color: red">
  <input id="file" type="file"/>
  <img alt="converted" id="image" />
</span>
{{< /highlight >}}
1. App.tsx에서 도우미 프로세스를 시작하고 이미지 처리를 설명합니다.
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
          <img alt="converted" id="image" />
      </header>
    </div>
  );
}

window.onload = async function () {
  console.log("WASM 로드 중...");
  await boot();
  console.log("WASM 로드됨");

  // @ts-ignore
    document.querySelector('input').addEventListener('change', function() {
        var reader = new FileReader();
        reader.onload = function() {

          var arrayBuffer = this.result;
          // @ts-ignore
          var array = new Uint8Array(arrayBuffer);

          // 로드
          var file = Image.load(array);

          // 저장
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
1. 애플리케이션 시작
{{< highlight plain >}}
npm start
{{< /highlight >}}

## 실행 예

1. 파일을 선택하세요.<br>
![파일 선택](/cad/_assets/javascript-net/react/choose-file.png)<br>
1. DXF, DWG, DGN, DWF, DWFX, IFC, STL, DWT, IGES, PLT, CF2, OBJ, HPGL, IGS, PCL, FBX, PDF, SVG 파일 중 하나를 선택하세요.
1. 응답이 성공적이면 파일이 화면에 표시되고 다운로드할 것을 제안합니다.<br>
![이미지 변환](/cad/_assets/javascript-net/react/convert-image.png)<br>

## 추가 정보

- [비주얼 코드 설치](https://code.visualstudio.com/)
- [Node.js 설치](https://nodejs.org/en/)
