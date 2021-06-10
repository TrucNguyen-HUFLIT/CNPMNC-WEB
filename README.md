# CNPMNC-WEB
<h2>Website Bán xe mô tô: H2T Moto</h2>

Để đáp ứng nhu cầu người dùng mua bán trao đổi xe moto hiện nay. Trang web này được tạo ra để các cửa hàng có thể dễ dàng trao đổi và buôn bán các loại xe moto(PKL-PKN) <br/>
Trang web thiết kế với mục đích cho người dùng dễ dàng sử dụng, quản lý, và trao đổi với khách hàng, bên cạnh đó còn đáp ứng đầy đủ các tính năng cần thiết như là lập hóa đơn, xem sản phẩm, thêm xóa sửa tài khoản, thay đổi thông tin cá nhân, xem lịch sử đơn hàng... 
Và ngoài ra không thể thiếu đó là những thiết kế bắt mắt, hiện đại, dễ nhìn phù hợp với mọi người.

## 🏍 Người đóng góp
- Ngọc Trúc
- Gia Huy
- Minh Tâm

## 🏍 Bắt đầu
- Tải và thực thi file 'datacnpmnc.sql' trên SSMS của bạn.
- Thay đổi đường dẫn Server=[local của bạn] trong file 'Starup.cs' và file 'QLMTContext.cs'.
- Dùng VS để build Web.

## 🏍 Công nghệ và kỹ thuật
- C# .Net 5.0, Html, CSS, Bootstap, Javascript, Jquery, Ajax.
- ASP.NET Core MVC.
- EF Core (Database first).
- Authorize(Roles).
- SandBox PayPal.
- Send mail (MailKit).
- Hash Password (MD5).

## 🏍 Thiết kế Figma với Prototype
https://www.figma.com/proto/RCpclkHSvQwI5mWgqu6sj3/CNPMNC_WEB_BANXEMOTO?page-id=0%3A1&node-id=0%3A1&viewport=178%2C140%2C0.03578898310661316&scaling=min-zoom

## 🏍 ERD và thiết kế dữ liệu

## ERD
<img src="https://res.cloudinary.com/web-banxemoto/image/upload/v1623306039/CNPMNC_WEB/erd_web_banxemoto.jpg" />

## Thiết kế dữ liệu
**NhanVien(_IDNV_, IDType, Email ,Pass TenNV, DienThoai, DiaChi, Cmnd, Avatar)**
- Quản lý tạo tài khoản và thông tin cho nhân viên.
- Mỗi nhân viên sẽ thuộc 1 loại tài khoản nhất định và xác định qua IDType.
- Mỗi nhân viên sẽ được phân biêt với nhau qua IDNV.

**TypeAcc(_IDType_, Name)**
- Môt loại tài khoản sẽ thuộc nhiều nhân viên hoặc nhiều khách hàng.

**KhachHang(_IDKH_, IDtype, Email, Pass, TenKH, DiaChi, DienThoai, Avatar)**
- Hệ thống sẽ lưu trữ thông tin khách hàng khi khách hàng đăng kí tài khoản.
- Mỗi khách hầng sẽ có 1 loại tài khoản nhất định và xác định qua IDType.
- Mỗi khách hàng sẽ được phân biệt với nhau qua IDKH.

**MauXe(_IDMau_, IDKM, IDHang, TenXe, GiaBan, HinhAnh1, HinhAnh2, HinhAnh3, BaoHanh, Mota, TrangThai)**
- Hệ thống lưu trữ thông tin của mẫu xe khi quản lý thêm hoặc cập nhật mẫu xe.
- Một mẫu xe sẽ có duy nhất 1 hãng xe và 1 hãng xe thì có nhiều mẫu xe.
- Một mẫu xe sẽ có duy nhất 1 khuyến mãi và 1 khuyến mãi có thể dành cho nhiều mẫu xe.
- Mỗi mẫu xe sẽ được phân biêt với nhau qua IDMau.

**HoaDon (_IDHD_, IDKH, NgayDat, TrangThai)**
- Hệ thống sẽ lưu trữ thông tin đặt hàng và nhân viên sẽ tạo hóa đơn khi khách hàng đặt mua sản phẩm.
- Một khách hàng có thể có 1 hoặc nhiều hóa đơn và 1 hóa đơn chỉ dành cho 1 khách hàng.
- Khách hàng muốn mua sản phẩm (tạo hóa đơn) phải Login.
- Mỗi hóa đơn sẽ được phân biệt với nhau qua IDHD và IDKH.
- Một hóa đơn sẽ có 1 hoặc nhiều chi tiết hóa đơn và chi tiết hóa đơn chỉ dành cho 1 hóa đơn.

**ChiTietHoaDon(_IDHD_, _IDXe_, KhuyenMai, GiaBan)**
- Một hóa đơn có thể có 1 hoặc nhiều xe thông qua chi tiết hóa đơn.
- Chi tiết hóa đơn lưu trữ thông tin về khuyến mãi và giá bán của xe, đề phòng sau này có thể có thay đổi giá bán và khuyến mãi của chiếc xe đó thì hóa đơn sẽ không bị thay đổi.

**Xe(_IDXe_, IDMau, TrangThai, TenXe)**
- Lưu trữ thông tin của xe khi quản lý thêm hoặc cập nhật xe.
- Một xe sẽ thuộc một mẫu xe và mẫu xe có một hoặc nhiều xe.
- Mỗi xe sẽ được phân biệt với nhau qua IDXe.

**Hang(_IDHang_, TenHang, TrangThai)**
- Quản lý lưu trữ thông tin của hãng xe khi quản lý thêm hoặc cập nhật hãng xe.
- Mỗi hãng xe sẽ được phân biệt với nhau qua IDHang.
- Một hãng xe có thể thuộc 1 hoặc nhiều mẫu xe và 1 mẫu xe chỉ thuộc 1 hãng xe.

**KhuyenMai(_IDKM_, Gia Tri)**
- Quản lý lưu trữ thông tin của khuyến mãi khi quản lý thêm hoặc cập nhật khuyến mãi.
- Mỗi khuyễn mãi sẽ được phân biệt với nhau qua IDKM.
- Một khuyến mãi có thể thuộc 1 hoặc nhiều mẫu xe và 1 mẫu xe chỉ có 1 khuyễn mãi.

**LoaiXe(_IDLoaiXe_, TenLoaiXe)**
- Quản lý lưu trữ thông tin của loại xe khi quản lý thêm hoặc cập nhật loại xe.
- Mỗi loại xe sẽ được phân biệt với nhau qua IDLoaiXe.
- Một loại xe có thể thuộc 1 hoặc nhiều mẫu xe và 1 mẫu xe chỉ thuộc 1 loại xe.

## 🏍 Tính năng
- Đăng nhập, đăng ký, cấp lại mật khẩu (gửi mail), đổi mật khẩu và chỉnh sửa thông tin cá nhân.
- Khách hàng:
  - Xem và tìm kiếm sản phẩm theo tên, hãng, loại xe.
  - Xem chi tiết sản phẩm (hình ảnh, mô tả, giá tiền).
  - Đặt hàng, thanh toán thông qua Paypal.
  - Xem lịch sử đơn hàng.
- Quản lý:
  - CRU + tìm kiếm: Mẫu xe, Hãng xe, Nhân viên.
  - Xem danh sách hóa đơn, thống kê doanh số (theo tháng).
  - Xem danh sách xe + thêm xe.
- Nhân viên:
  - Xem danh sách hóa đơn, danh sách khách hàng (tìm kiếm theo tên).
  - Quản lý bán hàng: Tạo hóa đơn, xác nhận đơn hàng + gửi mail thông báo, thanh toán đơn hàng + gửi mail thông báo.
  - Xem danh sách xe + thêm xe.
