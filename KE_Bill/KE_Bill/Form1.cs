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
    public partial class Form1 : Form
    {
      static int due_amount, gross_amount,bank_charges=8,tvl_fee,rate,rate_ans,var_chrg=0,sur_chrg = 0,net_amount=0,meter_rent=0; 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {//1330 1102
            vScrollBar1.Visible = true;
            vScrollBar1.Minimum = 1000;
            vScrollBar1.Maximum = 1330;
            textBox34.Text = "0";
            Calculation();
            textBox1.Text = Form2.name.ToString();
            textBox2.Text = Form2.address.ToString();
            textBox3.Text = Form2.bill_s_no.ToString();
            textBox54.Text = Form2.consumer_no.ToString();
            textBox4.Text = Form2.consumer_no.ToString();
            textBox5.Text = Form2.bill_id.ToString();
            textBox6.Text = Form2.contract_no.ToString();
            textBox7.Text = Form2.meter_no.ToString();
            textBox8.Text = Form2.GSTN_NTN_CNIC.ToString();
            textBox9.Text = Form2.no_of_month.ToString();
            textBox10.Text = "NORM";
            textBox11.Text = Form2.tariff.ToString();
            textBox12.Text = Form2.c_load.ToString();
            textBox13.Text = Form2.s_load.ToString();
            textBox14.Text = "0";
            textBox15.Text = DateTime.Now.ToString();
            textBox16.Text = DateTime.Now.ToString();
            textBox17.Text = Form2.present_rdg.ToString();
            textBox18.Text = Form2.previous_rdg.ToString();
            textBox19.Text = Form2.units_adj.ToString();
            textBox20.Text = "";
            textBox22.Text = "";
            textBox44.Text = Form2.amount_adj.ToString();
            textBox51.Text = Form2.acc_no.ToString();
            textBox23.Text = Form2.acc_no.ToString();
            textBox25.Text = DateTime.Now.ToString();
            textBox26.Text = Form2.billing_month.ToString();
            textBox41.Text = tvl_fee.ToString();
            textBox29.Text = var_chrg.ToString();
            textBox30.Text = sur_chrg.ToString();
            textBox53.Text = gross_amount.ToString();
            textBox27.Text = gross_amount.ToString();
            textBox52.Text = due_amount.ToString();
            textBox24.Text = due_amount.ToString();
            textBox39.Text = "0";
            textBox36.Text = "0";
            textBox73.Text = "0";
            textBox48.Text = "0";
            textBox35.Text = "0";
            textBox40.Text = bank_charges.ToString();
            textBox31.Text = meter_rent.ToString();
        }
        private int Calculation()
        {
            tvl_fee = 35;
           
            if (Form2.type == "DOMESTIC")
            {
                if (Form2.units_billed<=0)
                {
                    textBox21.Text = "0";
                    textBox27.Text = "0";
                    textBox28.Text = "0";
                    textBox29.Text = "0";
                    textBox20.Text = "0";
                    textBox30.Text = "0";
                    textBox31.Text = "0";
                    textBox32.Text = "0";
                    textBox33.Text = "0";
                    textBox34.Text = "0";
                    textBox35.Text = "0";
                    textBox36.Text = "0";
                    textBox37.Text = "0";
                    textBox38.Text = "0";
                    textBox40.Text = "0";
                    textBox41.Text = "0";
                    textBox42.Text = "0";
                    textBox43.Text = "0";
                    textBox45.Text = "0";
                    textBox46.Text = "0";
                    textBox47.Text = "0";
                    textBox42.Text = "0";
                    due_amount = 0;
                    gross_amount = 0;
                    bank_charges = 0;
                    tvl_fee = 0;
                    rate = 0;
                    rate_ans = 0;
                    Form2.units_billed = 0;
                   
                }
                else if (Form2.units_billed < 50 && Form2.units_billed > 0)
                {
                    textBox21.Text = Form2.units_billed.ToString();
                    textBox55.Text = Form2.units_billed.ToString();
                    rate = 2;
                    rate_ans = rate*Form2.units_billed;
                    textBox28.Text = "0";
                    textBox57.Text = rate_ans.ToString();
                    textBox56.Text = rate.ToString();
                    rate_ans = var_chrg; 
                    textBox32.Text = "8";
                    textBox33.Text = "50";
                    textBox35.Text = "0";
                    textBox36.Text = "0";
                    textBox37.Text = "0";
                    textBox38.Text = "0";
                    textBox44.Text = "0";
                    textBox45.Text = "0";
                    textBox46.Text = "0";
                    textBox47.Text = "0";
                    net_amount =(sur_chrg)+(var_chrg)+meter_rent+8+50+bank_charges+tvl_fee;
                    due_amount = net_amount;
                    gross_amount = (Form2.units_billed * 2) + net_amount;
                 
                }
                else if (Form2.units_billed  < 100 && Form2.units_billed > 50 )
                {
                    textBox21.Text = Form2.units_billed.ToString();
                    textBox55.Text = Form2.units_billed.ToString();
                    rate = 6;
                    rate_ans = rate * Form2.units_billed;
                    textBox28.Text = "0";
                    textBox57.Text = rate_ans.ToString();
                    textBox56.Text = rate.ToString();
                    rate_ans = var_chrg;  
                    textBox32.Text = "15";
                    textBox33.Text = "70";
                    textBox35.Text = "0";
                    textBox36.Text = "0";
                    textBox37.Text = "0";
                    textBox38.Text = "0";
                    textBox44.Text = "0";
                    textBox45.Text = "0";
                    textBox46.Text = "0";
                    textBox47.Text = "0";
                    net_amount = (sur_chrg) + (var_chrg) + meter_rent + 15 + 70 + bank_charges + tvl_fee;
                    due_amount = net_amount;
                    gross_amount = (Form2.units_billed * 2) + net_amount;
                   
                }
                else if (Form2.units_billed  < 200 && Form2.units_billed > 100 )
                {
                       textBox21.Text = Form2.units_billed.ToString();
                    textBox55.Text = Form2.units_billed.ToString();
                    rate = 8;
                    rate_ans = rate * Form2.units_billed;
                    textBox28.Text = "0";
                    textBox57.Text = rate_ans.ToString();
                    textBox56.Text = rate.ToString();
                    rate_ans = var_chrg; 
                    textBox32.Text = "10";
                    textBox33.Text = "100";
                    textBox35.Text = "0";
                    textBox36.Text = "0";
                    textBox37.Text = "0";
                    textBox38.Text = "0";
                    textBox44.Text = "0";
                    textBox45.Text = "0";
                    textBox46.Text = "0";
                    textBox47.Text = "0";
                    net_amount = (sur_chrg) + (var_chrg) + meter_rent + 10 + 100 + bank_charges + tvl_fee;
                    due_amount = net_amount;
                    gross_amount = (Form2.units_billed * 2) + net_amount;
                    
                }
                else if (Form2.units_billed  < 300 && Form2.units_billed > 200)
                {
                    
                       textBox21.Text = Form2.units_billed.ToString();
                    textBox55.Text = Form2.units_billed.ToString();
                    rate = 10;
                    rate_ans = rate * Form2.units_billed;
                    textBox28.Text = "0";
                    textBox57.Text = rate_ans.ToString();
                    textBox56.Text = rate.ToString();
                    rate_ans = var_chrg;
                    textBox32.Text = "15";
                    textBox33.Text = "137";
                    textBox35.Text = "0";
                    textBox36.Text = "0";
                    textBox37.Text = "0";
                    textBox38.Text = "0";
                    textBox44.Text = "0";
                    textBox45.Text = "0";
                    textBox46.Text = "0";
                    textBox47.Text = "0";
                    net_amount = (sur_chrg) + (var_chrg) + meter_rent + 15 + 137 + bank_charges + tvl_fee;
                    due_amount = net_amount;
                    gross_amount = (Form2.units_billed * 2) + net_amount;
                       
                }
                else if (Form2.units_billed < 700 && Form2.units_billed > 300)
                {
                    textBox21.Text = Form2.units_billed.ToString();
                    textBox55.Text = Form2.units_billed.ToString();
                    rate = 16;
                    rate_ans = rate * Form2.units_billed;
                    textBox28.Text = "0";
                    textBox57.Text = rate_ans.ToString();
                    textBox56.Text = rate.ToString();
                    rate_ans = var_chrg;
                    textBox58.Text = Form2.units_billed.ToString();
                    sur_chrg = 1 * Form2.units_billed;
                    textBox59.Text = "1";
                    textBox60.Text = sur_chrg.ToString();
                    textBox32.Text = "15";
                    textBox33.Text = "277";
                    textBox35.Text = "0";
                    textBox36.Text = "0";
                    textBox37.Text = "0";
                    textBox38.Text = "0";
                    textBox44.Text = "0";
                    textBox45.Text = "0";
                    textBox46.Text = "0";
                    textBox47.Text = "0";
                    net_amount = (sur_chrg) + (var_chrg) + meter_rent + 15 + 277 + bank_charges + tvl_fee;
                    due_amount = net_amount;
                    gross_amount = (Form2.units_billed * 2) + net_amount;
                    
                    

                }
                else if (Form2.units_billed > 700)
                {
                    
                    textBox21.Text = Form2.units_billed.ToString();
                    textBox55.Text = Form2.units_billed.ToString();
                    rate = 17;
                    rate_ans = rate * Form2.units_billed;
                    textBox28.Text = "0";
                    textBox57.Text = rate_ans.ToString();
                    textBox56.Text = rate.ToString();
                    rate_ans = var_chrg;
                    textBox58.Text = Form2.units_billed.ToString();
                    sur_chrg = 2 * Form2.units_billed;
                    textBox59.Text = "2";
                    textBox60.Text = sur_chrg.ToString(); ;
                    textBox32.Text = "15";
                    textBox33.Text = Form2.units_billed.ToString();
                    textBox35.Text = "0";
                    textBox36.Text = "0";
                    textBox37.Text = "0";
                    textBox38.Text = "0";
                    textBox44.Text = "0";
                    textBox45.Text = "0";
                    textBox46.Text = "0";
                    textBox47.Text = "0";
                    net_amount = (sur_chrg) + (var_chrg) + meter_rent + 15 + Form2.units_billed + bank_charges + tvl_fee;
                    due_amount = net_amount;
                    gross_amount = (Form2.units_billed * 2) + net_amount;
                    
                }
             
            textBox43.Text =net_amount.ToString();
            
            }
            else if (Form2.type == "COMMERCIAL")
            {
                tvl_fee = 60;
                if (Form2.units_billed<=0)
                {
                    textBox21.Text = "0";
                    textBox27.Text = "0";
                    textBox28.Text = "0";
                    textBox29.Text = "0";
                    textBox20.Text = "0";
                    textBox30.Text = "0";
                    textBox31.Text = "0";
                    textBox32.Text = "0";
                    textBox33.Text = "0";
                    textBox34.Text = "0";
                    textBox35.Text = "0";
                    textBox36.Text = "0";
                    textBox37.Text = "0";
                    textBox38.Text = "0";
                    textBox40.Text = "0";
                    textBox41.Text = "0";
                    textBox42.Text = "0";
                    textBox43.Text = "0";
                    textBox45.Text = "0";
                    textBox46.Text = "0";
                    textBox47.Text = "0";
                    textBox42.Text = "0";
                    due_amount = 0;
                    gross_amount = 0;
                    bank_charges = 0;
                    tvl_fee = 0;
                    rate = 0;
                    rate_ans = 0;
                    Form2.units_billed = 0;
                    
                }
              
                
                else  
            {
                textBox21.Text = Form2.units_billed.ToString();
                    textBox55.Text = Form2.units_billed.ToString();
                    rate = 15;
                    rate_ans = rate * Form2.units_billed;
                    textBox28.Text = "0";
                    textBox57.Text = rate_ans.ToString();
                    textBox56.Text = rate.ToString();
                    rate_ans = var_chrg;
                    textBox58.Text = Form2.units_billed.ToString();
                    sur_chrg = 2 * Form2.units_billed;
                    textBox59.Text = "";
                    textBox60.Text = sur_chrg.ToString(); ;
                    textBox32.Text = "135";
                    int saletax = Form2.units_billed * 2;
                    textBox33.Text = saletax.ToString();
                    int gst = Form2.units_billed * 3;
                    textBox34.Text = gst.ToString();
                    textBox36.Text = "0";
                    textBox37.Text = "0";
                    textBox38.Text = "0";
                    textBox44.Text = "0";
                    textBox45.Text = "0";
                    textBox46.Text = "0";
                    textBox47.Text = "0";
                    net_amount = (sur_chrg) + (var_chrg) + meter_rent + 130 + saletax+gst + bank_charges + tvl_fee;
                    due_amount = net_amount;
                    gross_amount = (Form2.units_billed * 2) + net_amount;
                   
            }


           
            }
            return 0;
        }

        private void Name_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Payable_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label39_Click(object sender, EventArgs e)
        {

        }

        private void label38_Click(object sender, EventArgs e)
        {

        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
