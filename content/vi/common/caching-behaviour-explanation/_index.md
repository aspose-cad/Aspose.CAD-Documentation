---
title: Giải thích hành vi bộ nhớ đệm của Aspose.CAD
type: docs
weight: 20
url: /vi/common/caching-behaviour-explanation/
---

## **Cách Aspose.CAD lưu trữ dữ liệu bộ nhớ đệm**

Tất cả bộ nhớ đệm do Aspose.CAD thực hiện hoàn toàn tự động, không cần hoặc có thể có bất kỳ sự nhập liệu nào từ người dùng. Về cơ bản có ba loại bộ nhớ đệm, tất cả đều liên quan đến phông chữ.

### **Bộ nhớ đệm tên phông chữ**

Bộ nhớ đệm tên phông chữ được sử dụng để tạo điều kiện khởi động nhanh hơn bằng cách tiền xử lý tất cả các tệp phông chữ đã tìm thấy và biên soạn danh sách các tên phông chữ có trong các tệp này, vì một tệp phông chữ có thể chứa nhiều hơn một phông chữ. Nó được lưu trữ như một tệp tạm thời và có kích thước tối đa là hàng chục kilobyte trong hầu hết các hệ thống.

### **Bộ nhớ đệm dữ liệu glyph phông chữ**

Một bộ nhớ đệm trong bộ nhớ của tất cả các glyph đã được sử dụng trong suốt thời gian ứng dụng tồn tại để giảm việc đọc lại các tệp phông chữ trên đĩa trong các xuất bản tiếp theo. Vì vậy, nó sẽ dẫn đến tiêu thụ bộ nhớ tăng dần nếu các xuất bản tiếp theo có các tệp tham chiếu đến các phông chữ mới và/hoặc chứa các ký tự chưa gặp trước đó. Tuy nhiên, trên thực tế, ngay cả trong toàn bộ 
bộ kiểm thử của Aspose.CAD, với hàng nghìn tệp bao gồm các tệp bằng nhiều ngôn ngữ khác nhau, tiêu thụ bộ nhớ của nó khoảng 200 megabyte, điều này không phải là quá đáng kể cho một hệ thống hiện đại.

### **Bộ nhớ đệm phông chữ dự phòng theo ký tự**

Một bộ nhớ đệm trong bộ nhớ lưu trữ các phông chữ chứa một ký tự nhất định cho tất cả các ký tự Unicode nhằm tạo điều kiện thuận lợi cho việc chọn phông chữ thay thế trong trường hợp một phông chữ do một thực thể văn bản trong bản vẽ cung cấp không chứa ký tự trong nội dung văn bản của thực thể đó. Nó được xây dựng trong hoạt động xuất đầu tiên trong suốt thời gian ứng dụng tồn tại và vẫn tồn tại cho đến khi ứng dụng bị kết thúc. Trên các máy thử nghiệm tương đối khiêm tốn của chúng tôi với các bộ sưu tập phông chữ khổng lồ được sử dụng trong các bộ kiểm thử, bộ nhớ đệm mất khoảng 30 giây để xây dựng và chiếm 70 megabyte. Khi đã được xây dựng, nó không còn mất thêm thời gian và không phát triển nữa.
