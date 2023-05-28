using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {
        string status = "";
        int Index = -1;
        public Form1()
        {
            InitializeComponent();
        }
        #region Method
        void CreateColumnForDataGridView()
        {
            var colMasv = new DataGridViewTextBoxColumn();
            var colTensv = new DataGridViewTextBoxColumn();
            var colSdt = new DataGridViewTextBoxColumn();
            var colHocluc = new DataGridViewTextBoxColumn();

            colMasv.HeaderText = "Mã sinh viên";
            colTensv.HeaderText = "Tên sinh viên";
            colSdt.HeaderText = "Số điện thoại";
            colHocluc.HeaderText = "Học lực";

            colMasv.DataPropertyName = "Masv";
            colTensv.DataPropertyName = "Tensv";
            colSdt.DataPropertyName = "Sdt";
            colHocluc.DataPropertyName = "Hocluc";

            Bang.Columns.AddRange(new DataGridViewColumn[] { colMasv, colTensv, colSdt, colHocluc });
        }

        void LoadListSinhVien()
        {
            Bang.DataSource = null;
            CreateColumnForDataGridView();
            Bang.DataSource = ListSinhVien.Instance.ListMaSV;
            Bang.Refresh();
        }

        void EnableControls(bool isEnableTextBox,bool isEnableDataGridView)
        {
            textMaSV.Enabled = textTenSV.Enabled = textSDT.Enabled = textHocLuc.Enabled = isEnableTextBox;
            Bang.Enabled = isEnableDataGridView;
        }
        #endregion
        void ClerTextBox()
        {
            foreach(var item in this.Controls)
            {
                TextBox item1 = item as TextBox;
                if(item1 != null)
                {
                    item1.Clear();
                }
            }
        }


        /*bool CheckIput()
        {
            long result;
            if(textMaSV.Text=="" || textTenSV.Text=="" || textSDT.Text=="")
            {
                MessageBox.Show("Hay nhap day du thong tin", "yeu cau");
                return false;
            }
            if(!(long.TryParse(textTenSV.Text,out result)))
            {
                MessageBox.Show("Hay nhap lai dung ", "yeu cau");
                return false;
            }
            if(result <= 0)
            {

                MessageBox.Show("Hay Kiem tra lai ", "yeu cau");
                return false;
            }
            return true;
        }*/

        #region Event

        private void Form1_Load(object sender, EventArgs e)
        {
            EnableControls(false, true);
           // CreateColumnForDataGridView();
            LoadListSinhVien();

            btnLuu.Enabled = btnHuy.Enabled = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            EnableControls(true, false);
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;
            status = "Add";

        }

       

        private void btnLuu_Click(object sender, EventArgs e)
        {
           
            string masv = textMaSV.Text;
            string tensv = textTenSV.Text;
            string sdt = textSDT.Text;
            string hocluc = textHocLuc.Text;

            if(status == "Add")
            {
                ListSinhVien.Instance.ListMaSV.Add(new SinhVien(masv, tensv, sdt, hocluc));
            }
            if (status == "Edit")
            {
                ListSinhVien.Instance.ListMaSV[Index].Masv = textMaSV.Text;
                ListSinhVien.Instance.ListMaSV[Index].Tensv = textTenSV.Text;
                ListSinhVien.Instance.ListMaSV[Index].Sdt = textSDT.Text;
                ListSinhVien.Instance.ListMaSV[Index].Hocluc = textHocLuc.Text;
            }

            
            EnableControls(false, true);
            LoadListSinhVien();
            ClerTextBox();
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            

        if(Index < 0)
            {
                MessageBox.Show("Hay chon mot ban ghi", "Canh bao");
                return;
            }
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;

            EnableControls(true, false);
            textMaSV.Text = ListSinhVien.Instance.ListMaSV[Index].Masv;
            textTenSV.Text = ListSinhVien.Instance.ListMaSV[Index].Tensv;
            textSDT.Text = ListSinhVien.Instance.ListMaSV[Index].Sdt;
            textHocLuc.Text = ListSinhVien.Instance.ListMaSV[Index].Hocluc;

            status = "Edit";
        }
       

        private void Bang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Index = e.RowIndex;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClerTextBox();
            EnableControls(true, false);
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = false;
        }


        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (Index < 0)
            {
                MessageBox.Show("Hay chon mot ban ghi", "Canh bao");
                return;
            }
            ListSinhVien.Instance.ListMaSV.RemoveAt(Index);
            LoadListSinhVien();
        }

       

        private void btnTimKiiem_Click(object sender, EventArgs e)
        {
            textMaSV.Enabled = true;
           
            btnThem.Enabled = false;
        }
       

        private void textMaSV_TextChanged(object sender, EventArgs e)
        {
            string search = textMaSV.Text;
            List<SinhVien> listSearch = new List<SinhVien>();
            foreach(var item in ListSinhVien.Instance.ListMaSV)
            {
                if (item.Masv.ToLower().Contains(search.ToLower()))
                {
                    listSearch.Add(item);
                }
            }
            Bang.DataSource = null;
            CreateColumnForDataGridView();
            Bang.DataSource = listSearch;
        }
        #endregion
    }
}
