using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL
{
    public class Helper
    {
        private static Helper instance;
        public static Helper Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Helper();
                }
                return instance;
            }
            private set { }
        }
        private Helper()
        {

        }
        public void ExportDataToExcel<T>(List<T> result)
        {
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workBook = excel.Workbooks.Add();
            Microsoft.Office.Interop.Excel.Worksheet sheet = (Worksheet)workBook.ActiveSheet;
            sheet.Name = "DataSheet";
            // excel.Visible = true;   
            try
            {
                //create the column(s) header(s)
                int col = 1;

                foreach (var propInfo in result[0].GetType().GetProperties())
                {
                    sheet.Cells[1, col] = propInfo.Name;
                    sheet.Cells[1, col].Font.Bold = true;
                    col++;
                }
                //put the actual data
                int k = 0;
                foreach (var item in result)
                {
                    int j = 1;
                    foreach (var propInfo in item.GetType().GetProperties())
                    {
                        try
                        {
                            sheet.Cells[k + 2, j].Value = propInfo.GetValue(item);
                            j++;
                        }
                        catch (System.Runtime.InteropServices.COMException comex)
                        {
                            Console.WriteLine(string.Format("{0}, caused for exporting value - {1}",
                                    comex.Message, propInfo.GetValue(item)));
                            sheet.Cells[k + 2, j].Value = $"'{propInfo.GetValue(item)}'";
                            j++;
                            continue;
                        }
                    }
                    k++;
                }
                string filePath = "";
                // tạo SaveFileDialog để lưu file excel
                SaveFileDialog dialog = new SaveFileDialog();
                // chỉ lọc ra các file có định dạng Excel
                dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";
                // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = dialog.FileName;
                }
                // nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
                if (string.IsNullOrEmpty(filePath))
                {
                    MessageBox.Show("Đường dẫn báo cáo không hợp lệ");

                }
                workBook.Close(true, filePath);
            }
            catch (Exception ex)
            {
                workBook.Close(false);
                MessageBox.Show(ex.Message);
            }
        }
    }
}
