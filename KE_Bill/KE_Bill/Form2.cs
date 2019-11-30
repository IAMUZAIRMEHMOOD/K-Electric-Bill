using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KE_Bill
{
    public partial class Form2 : Form
    {
        public static string name, address, bill_s_no, contract_no, consumer_no, GSTN_NTN_CNIC,
        bill_id, meter_no, acc_no, billing_month, tariff, reading_date, due_date,
        c_load,s_load,type;
        public static int no_of_month,present_rdg,previous_rdg,units_adj,units_billed,amount_adj;
        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            name = textBox1.Text;
            bill_s_no = textBox2.Text;
            consumer_no = textBox3.Text;
            bill_id = textBox4.Text;
            acc_no = textBox5.Text;
            no_of_month = Convert.ToInt32(textBox6.Text);
            c_load = textBox7.Text;
            present_rdg = Convert.ToInt32(textBox8.Text);
            units_adj = Convert.ToInt32(textBox9.Text);
            amount_adj = Convert.ToInt32(textBox10.Text);
            previous_rdg = Convert.ToInt32(textBox11.Text);
            s_load = textBox12.Text;
            tariff = textBox13.Text;
            billing_month = textBox14.Text;
            GSTN_NTN_CNIC = textBox15.Text;
            meter_no = textBox16.Text;
            contract_no = textBox17.Text;
            address = textBox18.Text;
            units_billed = present_rdg - previous_rdg;
            if (radioButton1.Checked)
            {
                type = "DOMESTIC";
            }
            else if (radioButton2.Checked)
            {
                type = "COMMERCIAL"; 
            }
            else
            {
               
            }
            Form1 f1 = new Form1();
            f1.Show();


        }
    }
}
