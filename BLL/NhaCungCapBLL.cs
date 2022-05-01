using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Windows.Forms;
using System.Data;
using Microsoft.Office.Interop.Excel;
using NsExcel = Microsoft.Office.Interop.Excel;

using System.IO;

namespace BLL
{
    public class NhaCungCapBLL
    {
        private static NhaCungCapBLL instance;
        public static NhaCungCapBLL Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NhaCungCapBLL();
                }
                return instance;
            }
            private set { }
        }
        private NhaCungCapBLL()
        {

        }
        public List<NhaCungCapDTO> GetNCCByMaLoaiNCC(string maLoaiNCC , string txt)
        {
            List<NhaCungCapDTO> data = new List<NhaCungCapDTO>();
            if (maLoaiNCC == "0")
            {
                foreach (NhaCungCapDTO i in NhaCungCapDAL.Instance.GetAllNhaCungCap())
                {
                    if (i.TenNhaCungCap.Contains(txt))
                        data.Add(i);
                }
            }
            else
            {
                foreach (NhaCungCapDTO i in NhaCungCapDAL.Instance.GetAllNhaCungCap())
                {
                    if (i.MaLoaiNhaCungCap == maLoaiNCC && i.TenNhaCungCap.Contains(txt))
                        data.Add(i);
                }
            }

            return data;
        }
        public NhaCungCapDTO GetNCCByMaNCC(string MaNCC)
        {
            NhaCungCapDTO nhaCungCap = null;
            foreach (NhaCungCapDTO i in NhaCungCapDAL.Instance.GetAllNhaCungCap())
            {
                if (i.MaNhaCungCap == MaNCC)
                {
                    nhaCungCap = i;
                    break;
                }
            }
            return nhaCungCap;
        }
        public List<NhaCungCapViewDTO> GetNCCViewMaLoaiNCC(string maLoaiNCC, string txt)
        {
            List<NhaCungCapViewDTO> data = new List<NhaCungCapViewDTO>();
            foreach(NhaCungCapDTO i in GetNCCByMaLoaiNCC(maLoaiNCC, txt))
            {
                data.Add(GetNhaCungCapViewByNhaCungCapDTO(i));
            }
            return data;
        }

       
        public NhaCungCapViewDTO GetNhaCungCapViewByNhaCungCapDTO(NhaCungCapDTO ncc)
        {
            string tenLoaiNCC = "";
            foreach (LoaiNhaCungCapDTO i in LoaiNhaCungCapDAL.Instance.GetAllLoaiNhaCungCap())
            {
                if (i.MaLoaiNhaCungCap == ncc.MaLoaiNhaCungCap)
                    tenLoaiNCC = i.TenLoaiNhaCungCap;
            }
            return new NhaCungCapViewDTO
            {
                MaNhaCungCap = ncc.MaNhaCungCap,
                TenNhaCungCap = ncc.TenNhaCungCap,
                MaSoThue = ncc.MaSoThue,
                SoDienThoai = ncc.SoDienThoai,
                TenLoaiNhaCungCap = tenLoaiNCC
            };
        }
        public List<NhaCungCapViewDTO> GetNhaCungCapViewDGV(List<string> maNhaCungCap)
        {
            List<NhaCungCapViewDTO> data = new List<NhaCungCapViewDTO>();
            foreach (string i in maNhaCungCap)
            {
                data.Add(GetNhaCungCapViewByNhaCungCapDTO(GetNCCByMaNCC(i)));
            }
            return data;
        }
        public bool CheckAddUpdateNhaCungCap(NhaCungCapDTO nhaCungCap)
        {
            bool add = true;
            foreach (NhaCungCapDTO i in NhaCungCapDAL.Instance.GetAllNhaCungCap())
            {
                if (i.MaNhaCungCap == nhaCungCap.MaNhaCungCap)
                {
                    add = false;
                    break;
                }
            }
            return add;

        }
        public void AddUpdateNhaCungCap(NhaCungCapDTO nhaCungCap)
        {
            if (CheckAddUpdateNhaCungCap(nhaCungCap))
            {
                NhaCungCapDAL.Instance.ThemNhaCungCap(nhaCungCap);
            }
            else
            {
                NhaCungCapDAL.Instance.CapNhatNhaCungCap(nhaCungCap);
            }
        }

        public string KiemTraDuLieu(NhaCungCapDTO nhaCungCap)
        {
           
            if (nhaCungCap.MaNhaCungCap == "" &&
                nhaCungCap.TenNhaCungCap == "" &&
                nhaCungCap.MaLoaiNhaCungCap == "" &&
                nhaCungCap.MaSoThue == "" &&
                nhaCungCap.Email == "" &&
                nhaCungCap.SoDienThoai == "" &&
                nhaCungCap.DiaChi == "")
            {
                return "Dữ liệu còn trống !";
            }
            if (!CheckAddUpdateNhaCungCap(nhaCungCap))
            {
                if ((int)NhaCungCapDAL.Instance.KiemTraMaSoThue(nhaCungCap) >= 2)
                {
                    return "Mã số thuế đã tồn tại!";
                }
                if ((int)NhaCungCapDAL.Instance.KiemTraSoDienThoai(nhaCungCap) >= 2)
                {
                    return "Số điện thoại đã tồn tại!";
                }
                if ((int)NhaCungCapDAL.Instance.KiemTraEmail(nhaCungCap) >= 2)
                {
                    return "Email đã tồn tại!";
                }
            }
            else
            {
                if ((int)NhaCungCapDAL.Instance.KiemTraMaSoThue(nhaCungCap) >= 1)
                {
                    return "Mã số thuế đã tồn tại!";
                }
                if ((int)NhaCungCapDAL.Instance.KiemTraSoDienThoai(nhaCungCap) >= 1)
                {
                    return "Số điện thoại đã tồn tại!";
                }
                if ((int)NhaCungCapDAL.Instance.KiemTraEmail(nhaCungCap) >= 1)
                {
                    return "Email đã tồn tại!";
                }
            }
            return null;
        }
        public void GetDSSanPhamByNhaCungCap(string maNhaCungCap)
        {
            // chi tiet cung cap
        }

        public List<PhimDTO> GetDSPhimByNhaCungCap(string maNhaCungCap)
        {
            foreach(PhimDTO i in PhimDAL.Instance.GetALLPhim())
            {
                //chi tiet cung cap
            }
            return null;
        }





        public delegate bool CompareObj(object o1, object o2);
        public List<NhaCungCapViewDTO> SortNhaCungCap(List<NhaCungCapViewDTO> now, string dkSort)
        {
            if (dkSort == "Tên A->Z")
                return Sort(now, CompareTenNhaCungCapTang );
            if (dkSort == "Tên Z->A")
                return Sort(now, CompareTenNhaCungCapGiam);
            return null;
        }
        public static bool CompareTenNhaCungCapTang(object o1, object o2)
        {
            return String.Compare(((NhaCungCapViewDTO)o1).TenNhaCungCap, ((NhaCungCapViewDTO)o2).TenNhaCungCap) > 0;
        }
        public static bool CompareTenNhaCungCapGiam(object o1, object o2)
        {
            return String.Compare(((NhaCungCapViewDTO)o2).TenNhaCungCap, ((NhaCungCapViewDTO)o1).TenNhaCungCap) > 0;
        }

       
        public List<NhaCungCapViewDTO> Sort(List<NhaCungCapViewDTO> now, CompareObj cmp)
        {
            List<NhaCungCapViewDTO> data = now;
            for (int i = 0; i < data.Count - 1; i++)
                for (int j = i + 1; j < data.Count; j++)
                {
                    if (cmp(data[i], data[j]))
                    {
                        NhaCungCapViewDTO temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
                }
            return data;
        }

        public void ToExcel(List<NhaCungCapViewDTO> list)
        {
            //    var excel = new Microsoft.Office.Interop.Excel.Application();
            //    var excelworkBook = excel.Workbooks.Add();
            //    var excelSheet = (Worksheet)excelworkBook.ActiveSheet;
            //    excelSheet.Name = "DataSheet";

            //    try
            //    {
            //        //create the column(s) header(s)
            //        int col = 1;

            //        foreach (var propInfo in result[0].GetType().GetProperties())
            //        {
            //            excelSheet.Cells[1, col] = propInfo.Name;
            //            excelSheet.Cells[1, col].Font.Bold = true;
            //            col++;
            //        }

            //        //put the actual data
            //        int k = 0;

            //        foreach (var item in result)
            //        {
            //            int j = 1;
            //            foreach (var propInfo in item.GetType().GetProperties())
            //            {
            //                try
            //                {
            //                    excelSheet.Cells[k + 2, j].Value = propInfo.GetValue(item);
            //                    j++;
            //                }
            //                catch (System.Runtime.InteropServices.COMException comex)
            //                {
            //                    Console.WriteLine(string.Format("{0},  caused for exporting value - { 1}",comex.Message, propInfo.GetValue(item)));
            //                    excelSheet.Cells[k + 2, j].Value = $"'{propInfo.GetValue(item)}'";
            //                    j++;
            //                    continue;
            //                }
            //            }
            //            k++;
            //        }
            //        var folderPath = "<YourFolderPath>";
            //        if (!Directory.Exists(folderPath))
            //            Directory.CreateDirectory(folderPath);
            //        var filePath = $"{folderPath}\\<YourFileName>.xlsx";
            //        excelworkBook.Close(true, filePath);
            //        Console.WriteLine($"Exported Successfully to {filePath}");
            //    }
            //    catch (Exception ex)
            //    {
            //        excelworkBook.Close(false);
            //        Console.WriteLine(ex.Message);
            //        Console.WriteLine("Export Failed.");
            //    }
            //
            //
            // }

          
                //start excel
                NsExcel.Application excapp = new Microsoft.Office.Interop.Excel.Application();

            //if you want to make excel visible           
            excapp.Visible = true;

                //create a blank workbook
                var workbook = excapp.Workbooks.Add(NsExcel.XlWBATemplate.xlWBATWorksheet);

                //or open one - this is no pleasant, but yue're probably interested in the first parameter
                string workbookPath = @"D:\test";
                 workbook = excapp.Workbooks.Open(workbookPath,0, false, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "",true, false, 0, true, false, false);

                //Not done yet. You have to work on a specific sheet - note the cast
                //You may not have any sheets at all. Then you have to add one with NsExcel.Worksheet.Add()
                var sheet = (NsExcel.Worksheet)workbook.Sheets[1]; //indexing starts from 1

                //do something usefull: you select now an individual cell
                var range = sheet.get_Range("A1", "A1");
                range.Value2 = "test"; //Value2 is not a typo

                //now the list
                string cellName;
                int counter = 1;
                foreach (var item in list)
                {
                    cellName = "A" + counter.ToString();
                     range = sheet.get_Range(cellName, cellName);
                    range.Value2 = item.ToString();
                    ++counter;
                }

                //you've probably got the point by now, so a detailed explanation about workbook.SaveAs and workbook.Close is not necessary
                //important: if you did not make excel visible terminating your application will terminate excel as well - I tested it
                //but if you did it - to be honest - I don't know how to close the main excel window - maybee somewhere around excapp.Windows or excapp.ActiveWindow
            
        }
    }
}
