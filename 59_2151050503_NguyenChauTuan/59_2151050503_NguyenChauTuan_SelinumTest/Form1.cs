using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace _59_2151050503_NguyenChauTuan_SelinumTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            for (int i = 0; i < 2; i++)
            {
                if(i==1)
                {
                    cmbchucnang.Items.Add("Thong Tin Lien He");
                    break;
                }
                cmbchucnang.Items.Add("Dang Ki");

            }
        }
       
        private void cmbchucnang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbchucnang.Text.Equals("Dang Ki"))
            {
             
                grb2_59_Tuan.Visible = true;
                grB1_59_Tuan.Visible = false;
            }
            if (cmbchucnang.Text.Equals("Thong Tin Lien He"))
            {
                grB1_59_Tuan.Visible = true;
                grb2_59_Tuan.Visible = false;
            }
        }

        private void cmBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnTTLH_59_Tuan(object sender, EventArgs e)
        {
            Button clickedButton_59_Tuan = (Button)sender;
            _59_NguyenChauTuan_Selinum_ThongTinLienHe _59_NguyenChauTuan_Selinum_ThongTinLienHe= new _59_NguyenChauTuan_Selinum_ThongTinLienHe();
            switch(clickedButton_59_Tuan.Text)
            {
                case "TestCase 1":
                    _59_NguyenChauTuan_Selinum_ThongTinLienHe.selinum_ThongTinLienHe_TC1_59_Tuan();
                    break;
                case "TestCase 2":
                    _59_NguyenChauTuan_Selinum_ThongTinLienHe.selinum_ThongTinLienHe_TC2_59_Tuan();
                    break;
                case "TestCase 3":
                    _59_NguyenChauTuan_Selinum_ThongTinLienHe.selinum_ThongTinLienHe_TC3_59_Tuan();
                    break;
                case "TestCase 4":
                    _59_NguyenChauTuan_Selinum_ThongTinLienHe.selinum_ThongTinLienHe_TC4_59_Tuan();
                    break;
                case "TestCase 5":
                    _59_NguyenChauTuan_Selinum_ThongTinLienHe.selinum_ThongTinLienHe_TC5_59_Tuan();
                    break;
                case "TestCase 6":
                    _59_NguyenChauTuan_Selinum_ThongTinLienHe.selinum_ThongTinLienHe_TC6_59_Tuan();
                    break;
            }
       }

        private void btnDangKi_59_Tuan(object sender, EventArgs e)
        {
            Button clickedButton_59_Tuan = (Button)sender;
            _59_NguyenChauTuan_Selinum_DangKy _59_NguyenChauTuan_Selinum_DangKy = new _59_NguyenChauTuan_Selinum_DangKy();
            switch (clickedButton_59_Tuan.Text)
            {
                case "TestCase 1":
                   _59_NguyenChauTuan_Selinum_DangKy.selinum_DangKy_TC1_59_Tuan();
                    break;
                case "TestCase 2":
                _59_NguyenChauTuan_Selinum_DangKy.selinum_DangKy_TC2_59_Tuan();
                    break;
                case "TestCase 3":
                _59_NguyenChauTuan_Selinum_DangKy.selinum_DangKy_TC3_59_Tuan();
                    break;
                case "TestCase 4":
                _59_NguyenChauTuan_Selinum_DangKy.selinum_DangKy_TC4_59_Tuan();
                    break;
                case "TestCase 5":
                _59_NguyenChauTuan_Selinum_DangKy.selinum_DangKy_TC5_59_Tuan();
                    break;
                case "TestCase 6":
                _59_NguyenChauTuan_Selinum_DangKy.selinum_DangKy_TC6_59_Tuan();
                    break;
                case "TestCase 7":
                    _59_NguyenChauTuan_Selinum_DangKy.selinum_DangKy_TC7_59_Tuan();
                    break;
                case "TestCase 8":
                    _59_NguyenChauTuan_Selinum_DangKy.selinum_DangKy_TC8_59_Tuan();
                    break;
            }
        }
    }
   
}
