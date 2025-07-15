ตอบคำถาม
- ข้อ 2 อยู่ในไฟล์ชื่อ DebugCode.cs ครับ
- ข้อ 3 
SELECT u.name, o.total_price
FROM Users u
JOIN Orders o ON u.user_id = o.user_id
WHERE o.total_price > 400
ORDER BY o.order_date DESC;
- ข้อ 4
  - ออกแบบสถาปัตยกรรมแบบ Layered Architecture แยกแยะแต่ละส่วน เพื่อสามารถขยายได้และง่ายต่อการบำรุงรักษา
  - เลือกใช้ SQL Server (Microsoft SQL Server Management Studio)
