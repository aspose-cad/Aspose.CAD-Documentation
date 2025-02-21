---
title: Cách Chạy Các Ví Dụ
type: docs
weight: 70
url: /vi/java/getting-started/how-to-run-the-examples/
---

## **Tải Xuống Từ GitHub**

Tất cả các ví dụ của Aspose.CAD cho Java được lưu trữ trên [Github](https://github.com/aspose-cad/Aspose.CAD-for-Java). Bạn có thể sao chép kho lưu trữ bằng cách sử dụng khách hàng Github yêu thích của bạn hoặc tải xuống tệp ZIP từ [đây](https://github.com/aspose-cad/Aspose.CAD-for-Java/archive/master.zip).

Giải nén nội dung của tệp ZIP vào bất kỳ thư mục nào trên máy tính của bạn. Tất cả các ví dụ nằm trong thư mục **Examples**.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Hình: Thư Mục Ví Dụ Aspose.CAD**|

## **Nhập các ví dụ vào IDE**

Dự án sử dụng hệ thống biên dịch Maven. Bất kỳ IDE hiện đại nào cũng có thể dễ dàng mở hoặc nhập dự án và các phụ thuộc của nó. Dưới đây chúng tôi sẽ chỉ cho bạn cách sử dụng các IDE phổ biến để xây dựng và chạy các ví dụ.

### **IntelliJ IDEA**

Nhấp vào menu **File** và chọn **Open**. Duyệt đến thư mục dự án và chọn tệp **pom.xml**.

|![todo:image_alt_text](https://i.imgur.com/nPfCrsR.png)|
| :- |
|**Hình: Chọn Tệp hoặc Thư mục Để Nhập**|
Nó sẽ mở dự án và tự động tải xuống các phụ thuộc. Từ tab Dự án, duyệt các ví dụ trong thư mục **src/main/java**. Để chạy một ví dụ, chỉ cần nhấp chuột phải vào tệp và chọn "Run ..", ví dụ sẽ được thực thi và đầu ra sẽ được hiển thị trong cửa sổ đầu ra của console tích hợp.

|![todo:image_alt_text](https://i.imgur.com/nMaSTiG.png)|
| :- |
|**Hình: Chạy Ví Dụ**|

### **Eclipse**

Nhấp vào menu **File** và chọn **Import**. Chọn **Maven** - Dự án Maven hiện có.

|![todo:image_alt_text](https://i.imgur.com/Ca0cHFr.png)|
| :- |
|**Hình: Nhập**|
Duyệt đến thư mục mà bạn đã sao chép hoặc tải xuống từ GitHub và chọn tệp **pom.xml**. Nó sẽ mở dự án và tự động tải xuống các phụ thuộc. Từ tab Package Explorer, duyệt các ví dụ trong thư mục **src/main/java**. Để chạy một ví dụ, chỉ cần nhấp chuột phải vào tệp và chọn **Run As** - **Java Application**, ví dụ sẽ được thực thi và đầu ra sẽ được hiển thị trong cửa sổ đầu ra của console tích hợp.

|![todo:image_alt_text](https://i.imgur.com/7WsFK0M.png)|
| :- |
|**Hình: Chạy Ví Dụ**|

### **NetBeans**

Nhấp vào menu **File** và chọn **Open Project**. Duyệt đến thư mục mà bạn đã sao chép hoặc tải xuống từ GitHub. Biểu tượng của thư mục **Examples** sẽ cho thấy rằng đây là một dự án Maven. Chọn Examples và mở nó.

|![todo:image_alt_text](https://i.imgur.com/KOcP5Z2.png)|
| :- |
|**Hình: Mở Dự Án**|
Nó sẽ mở dự án và tự động tải xuống các phụ thuộc. Từ tab Projects, duyệt các ví dụ trong **source packages**. Để chạy một ví dụ, chỉ cần nhấp chuột phải vào tệp và chọn **Run File**, ví dụ sẽ được thực thi và đầu ra sẽ được hiển thị trong cửa sổ đầu ra của console tích hợp.

|![todo:image_alt_text](https://i.imgur.com/VUUU4BD.png)|
| :- |
|**Hình: Chạy Ví Dụ**|

## **Thêm Thư Viện Aspose.CAD Vào Kho Lưu Trữ Maven Địa Phương**

Khi bạn nhập dự án **Aspose.CAD Examples** vào IDE, Maven tự động tải xuống tệp JAR aspose.cad từ [Aspose Maven Repository](https://releases.aspose.com/java/repo/). Trong trường hợp bạn không có kết nối internet, bạn có thể thêm JAR bằng tay vào kho lưu trữ địa phương của mình.

### **mvn install**

Tải xuống [aspose.cad](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/), giải nén và sao chép aspose.cad-version.jar đến một nơi khác, ví dụ, ổ c: . Thực hiện lệnh sau:

{{< highlight java >}}

 mvn install:install-file

    -Dfile=c:\aspose.cad-version.jar

    -DgroupId=com.aspose

    -DartifactId=aspose-cad

    -Dversion={version}

    -Dpackaging=jar

{{< /highlight >}}

Bây giờ, tệp JAR **aspose.cad** đã được sao chép vào kho lưu trữ địa phương của bạn.

### **pom.xml**

Sau khi cài đặt, chỉ cần khai báo tọa độ **aspose.cad** trong pom.xml.

{{< highlight java >}}

 <dependency>

    <groupId>com.aspose</groupId>

    <artifactId>aspose-cad</artifactId>

    <version>17.11</version>

    <classifier>jdk16</classifier>

 </dependency>

{{< /highlight >}}

### **Hoàn Thành**

Xây dựng nó, bây giờ tệp JAR **aspose.cad** có thể được lấy từ kho lưu trữ địa phương của bạn.

## **Đóng Góp**

Nếu bạn thích thêm hoặc cải thiện một ví dụ, chúng tôi khuyến khích bạn đóng góp cho dự án. Tất cả các ví dụ và dự án trình diễn trong kho lưu trữ này đều là mã nguồn mở và có thể được sử dụng tự do trong các ứng dụng của riêng bạn.

Để đóng góp, bạn có thể fork kho lưu trữ, chỉnh sửa mã nguồn và gửi một Pull Request. Chúng tôi sẽ xem xét các thay đổi và bao gồm nó vào kho lưu trữ nếu được xem là hữu ích.
