---
title: Cài đặt
type: docs
weight: 30
url: /vi/java/getting-started/installation/
---

## **Cài đặt Aspose.CAD cho Java từ kho Maven**

Aspose lưu trữ tất cả các API Java trên [kho Maven](https://releases.aspose.com/java/repo/com/aspose/). Bạn có thể dễ dàng sử dụng API [Aspose.CAD cho Java](https://releases.aspose.com/java/repo/com/aspose/aspose-cad/) trực tiếp trong các dự án Maven của bạn với các cấu hình đơn giản.

### **Xác định Cấu hình Kho Maven**

Đầu tiên, bạn cần xác định cấu hình/vị trí kho Maven Aspose trong tệp pom.xml của bạn như sau:

{{< highlight java >}}

<repositories>
    <repository>
        <id>asposeJavaAPI</id>
        <name>API Java Aspose</name>
        <url>https://releases.aspose.cloud/java/repo/</url>
        <snapshots>
            <enabled>false</enabled>
        </snapshots>
        <releases>
            <enabled>true</enabled>
        </releases>
    </repository>
</repositories>

{{< /highlight >}}

### **Định nghĩa Phụ thuộc API Aspose.CAD cho Java**

Sau đó, định nghĩa phụ thuộc API Aspose.CAD cho Java trong tệp pom.xml của bạn như sau:

{{< highlight java >}}

 <dependencies>

    <dependency>

        <groupId>com.aspose</groupId>

        <artifactId>aspose-cad</artifactId>

        <version>24.3</version>        

   </dependency>

</dependencies>

{{< /highlight >}}

Sau khi thực hiện các bước trên, phụ thuộc Aspose.CAD cho Java cuối cùng sẽ được định nghĩa trong dự án Maven của bạn.

## **Nền tảng Hỗ trợ**

Aspose.CAD cho Java hỗ trợ các nền tảng phát triển và triển khai phổ biến nhất.

|**Tính năng**|**Mô tả**|
| :- | :- |
|Ứng dụng Máy tính để bàn|Aspose.CAD cho Java có thể được sử dụng để phát triển ứng dụng Máy tính để bàn trên MS Windows.|
|Ứng dụng Web Doanh nghiệp|Aspose.CAD cho Java hoàn toàn hỗ trợ các ứng dụng Web.|
|Linux/Unix|Aspose.CAD cho Java là một API độc lập về nền tảng và có thể hoạt động trong môi trường Linux và Unix.|

## **Các Phiên bản Java Hỗ trợ**

- J2SE 6.0 (1.6)
- J2SE 7.0 (1.7)
- J2SE 8.0 (1.8)
