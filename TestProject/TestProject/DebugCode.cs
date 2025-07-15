using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    class DebugCode
    {
        public int Power(int baseNum, int exponent)
        {
            int result = 1;
            for (int i = 0; i < exponent; i++)
            {
                result *= baseNum;
            }
            return result;
        }
        /* ตอบคำถาม
         * ข้อที่ 1 โค้ดผิดพลาดในวงเล็ก for ลูป i <= exponent ควรเป็น i < exponent 
         * ข้อที่ 2 โค้ดที่ถูกต้อง คือ for (int i = 0; i < exponent; i++)
         * ข้อที่ 3 เพราะ ถ้าใช้ i <= exponent จะทำให้ลูปทำงานมากกว่าจำนวนที่ต้องการ ทำให้ผลลัพธ์ผิดพลาด
         */
    }
}
