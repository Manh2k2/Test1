using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class ListSinhVien
    {
        private static ListSinhVien instance;
        List<SinhVien> listMaSV;
        public List<SinhVien> ListMaSV { get => listMaSV ; set => listMaSV = value; }

        public static ListSinhVien Instance
        {
            get
            {
                if (instance == null)
                    instance = new ListSinhVien();
                return instance;
            }
            set => instance = value;
        }
        private ListSinhVien()
        {
            listMaSV = new List<SinhVien>();
            listMaSV.Add(new SinhVien("k123", "Nguyễn Đức Mạnh", "06422", "Trung Binh"));
            listMaSV.Add(new SinhVien("k124", "Nguyen Duc Anh", "02322", "Khá"));
            listMaSV.Add(new SinhVien("k345", "Hoàng Đức Chung", "08722", "Giỏi"));
            listMaSV.Add(new SinhVien("k3456", "Nguyen Duc Dung", "08722", "Trung Binh"));
            listMaSV.Add(new SinhVien("k125", "Đỗ Tuấn Anh ", "08722", "Trung Binh"));
            listMaSV.Add(new SinhVien("k1256", "Hà Văn Khánh", "08722", "Trung Binh"));
            listMaSV.Add(new SinhVien("k1257", "Nguyễn Văn Nam", "08722", "Kém"));
            listMaSV.Add(new SinhVien("k678", "Lê Anh Tuấn ", "08722", "Khá"));
            listMaSV.Add(new SinhVien("k6785", "Trần Thị Mai", "08722", "Khá"));

        }
    }
}
