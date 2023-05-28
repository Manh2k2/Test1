using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class SinhVien
    {
        private string masv;
        private string tensv;
        private string sdt;
        private string hocluc;

        public string Masv { get => masv; set => masv = value; }

        public string Tensv { get => tensv; set => tensv = value; }

        public string Sdt { get => sdt; set => sdt = value; }

        public string Hocluc { get =>hocluc; set => hocluc = value; }

        public SinhVien(string masv,string tensv,string sdt,string hocluc)
        {
            Masv = masv;
            Tensv = tensv;
            Sdt = sdt;
            Hocluc = hocluc;
        }
    }
}
