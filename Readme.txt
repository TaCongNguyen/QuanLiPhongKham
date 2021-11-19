Kết nối SQL server, tạo db QLKB trong máy
Thêm connectstring mới vào app.config để kết nối với csdl của máy mình ( ko xoá connect string của máy ng khác, có thể cmt lại)
Nếu có lỗi báo thiếu file dll, copy và replace SqlServerTypes ở ngoài thay thế SqlServerTypes trong project
Thay đổi chuỗi connect trong file setting đuôi cs thành máy của mình
