using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Oracle.DataAccess.Client;

namespace AeonNew
{
    public partial class Form3 : Form

    {
        public string Oraganization_Name;
        public string DeviceName;
        public string AMC_Expiry_Date;
        public string EXpriy_End_Date;
        public string CAPACITY;
        public string brand;
        string QUANTITY;
        string serial_number1="";
        string serial_number2="";
        string serial_number3="";
        string serial_number4="";
        string serial_number5="";
        string group;
        public Form3(string Oraganization_Name, string DeviceName, string AMC_Expiry_Date, string EXpriy_End_Date, string CAPACITY, string brand, string QUANTITY, string group)
        {
            InitializeComponent();
            this.Oraganization_Name = Oraganization_Name;
            this.DeviceName = DeviceName;
            this.AMC_Expiry_Date = AMC_Expiry_Date;
            this.EXpriy_End_Date = EXpriy_End_Date;
            this.CAPACITY = CAPACITY;
            this.brand = brand;
            this.QUANTITY = QUANTITY;
            this.group = group;
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           getSerial_number();
            Amc_ExpirySerial crp = new Amc_ExpirySerial();
        
            crp.SetParameterValue("Oraganization_Name", Oraganization_Name);
            crp.SetParameterValue("AMC_Expiry_Date", AMC_Expiry_Date);
            crp.SetParameterValue("EXpriy_End_Date", EXpriy_End_Date);
            crp.SetParameterValue("DeviceName", DeviceName);
            crp.SetParameterValue("CAPACITY", CAPACITY);
            crp.SetParameterValue("Brand", brand);
            crp.SetParameterValue("QUANTITY", QUANTITY);
            crp.SetParameterValue("Serial Number", serial_number1);
         
            crp.SetParameterValue("Serial_number2", serial_number2);
            crp.SetParameterValue("Serial_number3", serial_number3);
            crp.SetParameterValue("Serila_number4", serial_number4);
            crp.SetParameterValue("Serial_number5", serial_number5);
           
             crystalReportViewer1.ReportSource = crp;
        }

        public void getSerial_number()
        {
            int i = 0;
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                string command = "select * from EQP_SERIAL_LOCATION where GROUP_ID="+group+"";
                OracleCommand com = new OracleCommand(command);
                com.Connection = con;
                com.CommandType = CommandType.Text;
                OracleDataReader dr =com.ExecuteReader();
                while (dr.Read())
                {
                    if (i <= 6)
                    {
                        serial_number1 = serial_number1 + "  " + (dr["SERIAL_NO"].ToString());
                    }
                    else if (i <= 12)
                    {
                        serial_number2 = serial_number2 + "  " + (dr["SERIAL_NO"].ToString());
                    }
                    else if (i <= 18)
                    {
                        serial_number3 = serial_number3 + "  " + (dr["SERIAL_NO"].ToString());
                    }
                    else if (i <= 24)
                    {
                        serial_number4 = serial_number4 + "  " + (dr["SERIAL_NO"].ToString());
                    }
                        else if (i <= 30)
                    {
                        serial_number5 = serial_number5+"  "+ (dr["SERIAL_NO"].ToString());
                    }
                    
                }
                dr.Close();

            }
        }
    }
}
