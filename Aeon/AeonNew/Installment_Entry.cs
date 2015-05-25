using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace AeonNew
{
    public partial class Installment_Entry : Form
    {
        public static string _startDate = "";
        public static string _endDate = "";
        public static string _name = "";
        public static string _capacity = "";
        public static int _number = 0;
        public static int _unitPrice = 0;

        public static int _orgId = 0;
        public static int _groupId = 0;
        public int exeFlag;

        public Installment_Entry()
        {
            InitializeComponent();
        }

        private void Installment_Entry_Load(object sender, EventArgs e)
        {
            exeFlag = 0;
            string startend = _startDate + " To " + _endDate;
            start_end_lable.Text = startend;
            equipment_name_label.Text = _name;
            capacity_label.Text = _capacity;
            number_label.Text = _number.ToString();
            unit_price_label.Text = _unitPrice.ToString();
            total_cost_label.Text = (_unitPrice * _number).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int totalAmount = _number * _unitPrice;
            int totalAmountReceived = Convert.ToInt32(Total_Amount_Rec_textBox.Text);
            int instInterval = FindInterval(Inst_Pay_Mode_comboBox.Text);
            int prevInstAdjAmount = Convert.ToInt32(UnpaidAmountTextBox.Text);
            int totalNoInst = Convert.ToInt32(Num_Of_Inst_TextBox.Text);

            double decidedInst = ((double)totalAmount - totalAmountReceived - prevInstAdjAmount) / totalNoInst;
            double roundedDecidedInst = Math.Truncate(decidedInst);
            if (roundedDecidedInst < decidedInst)
            {
                roundedDecidedInst = roundedDecidedInst + 1;
            }

            int nextInstAmount = (int)roundedDecidedInst + prevInstAdjAmount;

            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = con.CreateCommand();
                cmd.CommandText = "insert into TEMP_INSTALLEMENTS_DETAILS VALUES (" + _orgId + ", " + totalAmount + ", " + totalAmountReceived + ", " + roundedDecidedInst + ", " + instInterval + ", '" + Next_Inst_Date_dateTimePicker.Text + "', " + Convert.ToInt32(UnpaidAmountTextBox.Text) + ", " + Convert.ToInt32(Num_Of_Inst_TextBox.Text) + ", " + nextInstAmount + ", " + totalAmountReceived + ", 0, " + _groupId + ")";
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
                exeFlag = 1;
            }
            this.Close();
        }

        public int FindInterval(string installmentMode)
        {
            int interval = 0;

            if (installmentMode == "Monthly")
                interval = 1;
            else if (installmentMode == "Quarterly")
                interval = 3;
            else if (installmentMode == "Halfyearly")
                interval = 6;
            else if (installmentMode == "Anually")
                interval = 12;

            return interval;
        }
    }
}
