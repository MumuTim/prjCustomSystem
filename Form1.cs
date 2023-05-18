using prjCustomSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace prjCustomSystem
{
    public partial class Form1 : Form
    {
        //string[] ids = new string[3];
        //string[] names = new string[3];
        //string[] phones = new string[3];
        //string[] emails = new string[3];
        //string[] addresses = new string[3];

        CCustmerManager _manager = new CCustmerManager();

        public Form1()
        {        
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //_manager.loadData(); 已有建構子不須再呼叫
            _manager.Datamoved += this.displayCustumer;
        }
        public void displayCustumer()
        {
            CCustumer x = _manager.current;
            txtid.Text = x.id;
            txtName.Text = x.name;
            txtPhone.Text = x.phone;
            txtEmail.Text = x.email;
            txtAdresses.Text = x.address;
            txtmoney.Text = x.消費金額累積.ToString();
        }
        private void btnTop_Click(object sender, EventArgs e)
        {
            _manager.moveFirst();
            

        }

 
        private void btnBot_Click(object sender, EventArgs e)
        {
             _manager.moveLast();
            
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            _manager.movePre();
            

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _manager.moveNext();
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            _manager.search(txtsearch.Text);
            
        }

        private void btnMoveTo_Click(object sender, EventArgs e)
        {
            _manager.moveTo(Int32.Parse(txtMoveTo.Text));
            
        }
    }
}
