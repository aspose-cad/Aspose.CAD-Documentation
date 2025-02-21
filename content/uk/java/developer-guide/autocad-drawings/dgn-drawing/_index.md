---
title: DGN Малюнок
type: docs
weight: 10
url: /uk/java/developer-guide/autocad-drawings/dgn-drawing/
---

## **Малювання формату DGN як частини DWG**

Aspose.CAD для Java дозволяє розробникам експортувати файл DWG з вбудованим DGN підкладкою. Нижче наведено код, що демонструє, як отримати доступ до DGN підкладки всередині файлу DWG під час експорту файлу DWG.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-ExportDGNAsPartofDWG-ExportDGNAsPartofDWG.java" >}}

## **Підтримка 3D об'єктів для DGN v7**

Aspose.CAD для Java API впровадив функціональність для завантаження файлу DGN AutoCAD і підтримує 3D об'єкти для DGN v7. Клас [**CadImage**](https://reference.aspose.com/cad/java/com.aspose.cad.fileformats.cad/CadImage) виконує цю мету. Кожен DGN малюнок підтримує 9 заздалегідь визначених виглядів. Вони перераховані від 1 до 9. Якщо вид не визначений під час експорту, для формату виходу з кількома сторінками (наприклад, PDF) всі вигляди будуть експортовані, кожен на окремій сторінці. 3D об'єкти підтримуються у форматі файлу DGN, так само як і 2D.
VectorRasterizationOptions.TypeOfEntities більше не використовується для формату DGN (обидва 2D і 3D підтримуються одночасно).

Приклад коду, щоб переглянути підтримувані елементи DGN.

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportForDGNV7-SupportForDGNV7.java" >}}

{{< gist "aspose-com-gists" "49c1b75d9a84e149ecf374ece2c2597d" "Examples-src-main-java-com-aspose-cad-examples-ExportingDGN-SupportedDGNElements-SupportedDGNElements.java" >}}
