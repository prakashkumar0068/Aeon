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
    public partial class Complaintdetails_Report : Form
    {
        AutoCompleteStringCollection nameCollection = new AutoCompleteStringCollection();
        AutoCompleteStringCollection engeen = new AutoCompleteStringCollection();
        String command="select C.ORGANISATION_ID, D.ORG_NAME, DATE_OF_COMPLAINT, TIME_OF_COMPLAINT, PERSON_LOG_COMPLAINT, EQUIP_NAME, MACHINE_UNDER, ENGINEER_SCHEDULED, STATUS FROM COMPLAINT_TABLE C, CLIENT_DETAILS D WHERE C.ORGANISATION_ID=D.ORGANISATION_ID ORDER BY ORGANISATION_ID";
        public Complaintdetails_Report()
        {
            InitializeComponent();
        }

        private void Complaintdetails_Load(object sender, EventArgs e)
        {
            //payment.Columns.Add("PartyName", typeof(string));
            comboBox1.Text = "All";
            OracleDataReader dr;

            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select ORG_NAME from CLIENT_DETAILS order by ORG_NAME asc";
                dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                        nameCollection.Add(dr["ORG_NAME"].ToString());
                }
                else
                {
                    MessageBox.Show("Data not found.");
                }

                dr.Close();
                textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
                textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textBox1.AutoCompleteCustomSource = nameCollection;

            }
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select Distinct(ENGINEER_SCHEDULED) from COMPLAINT_TABLE";
                dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                        engeen.Add(dr[0].ToString());
                }
                else
                {
                    MessageBox.Show("Data not found.");
                }

                dr.Close();
                textBox2.AutoCompleteMode = AutoCompleteMode.Suggest;
                textBox2.AutoCompleteSource = AutoCompleteSource.CustomSource;
                textBox2.AutoCompleteCustomSource = engeen;

            }
        }
        public void report()
        {

            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
             //try
                {
                    OracleCommand com = new OracleCommand(command);
                    com.Connection = con;
                    com.CommandType = CommandType.Text;
                    OracleDataAdapter sdt = new OracleDataAdapter(com);
                    DataTable ds = new DataTable();
                   // ds.Columns.Add("EQUIP_CAPACITY", typeof(string));
                    
                    sdt.Fill(ds);
                    for (int i = 0; i < ds.Rows.Count; i++)
                    {
                        //if (ds.Rows[i][8].ToString().Equals("0"))
                        {
                           // ds.Rows[i]["EQUIP_CAPACITY"] = (ds.Rows[i]["CAPASITY"].ToString());
                        }
                       // else
                        {
                            //ds.Rows[i][8] = (ds.Rows[i][8].ToString()).Replace("1", "Resolved");
                        }

                    }
                    ComplaintReport crp = new ComplaintReport();
                    crp.SetDataSource(ds);
                    crystalReportViewer1.ReportSource = crp;
                }
                

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Select Type of Complaint (ALL/Resolved/UnResolved)");
                return;
            }
            if (comboBox1.SelectedItem.ToString().Equals("All"))
            {
                command = "select C.ORGANISATION_ID, D.ORG_NAME, DATE_OF_COMPLAINT, TIME_OF_COMPLAINT, PERSON_LOG_COMPLAINT, EQUIP_NAME, EQUIP_CAPACITY, MACHINE_UNDER, ENGINEER_SCHEDULED, STATUS FROM COMPLAINT_TABLE C, CLIENT_DETAILS D WHERE C.ORGANISATION_ID = D.ORGANISATION_ID  ORDER BY ORGANISATION_ID";
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Resoveled"))
            {
                command = "select C.ORGANISATION_ID, D.ORG_NAME, DATE_OF_COMPLAINT, TIME_OF_COMPLAINT, PERSON_LOG_COMPLAINT, EQUIP_NAME, EQUIP_CAPACITY, MACHINE_UNDER, ENGINEER_SCHEDULED, STATUS FROM COMPLAINT_TABLE C, CLIENT_DETAILS D WHERE C.ORGANISATION_ID = D.ORGANISATION_ID  and STATUS='Resolved' ORDER BY ORGANISATION_ID";
            }
            else
            {
                command = "select C.ORGANISATION_ID, D.ORG_NAME, DATE_OF_COMPLAINT, TIME_OF_COMPLAINT, PERSON_LOG_COMPLAINT, EQUIP_NAME, EQUIP_CAPACITY, MACHINE_UNDER, ENGINEER_SCHEDULED, STATUS FROM COMPLAINT_TABLE C, CLIENT_DETAILS D WHERE C.ORGANISATION_ID = D.ORGANISATION_ID and  STATUS='Unresolved' ORDER BY ORGANISATION_ID";
            }
            report();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please Select one Client");
                return;
            }
            if (comboBox1.SelectedItem.ToString().Equals("All"))
            {
                command = "select C.ORGANISATION_ID, D.ORG_NAME, DATE_OF_COMPLAINT, TIME_OF_COMPLAINT, PERSON_LOG_COMPLAINT, EQUIP_NAME, EQUIP_CAPACITY, MACHINE_UNDER, ENGINEER_SCHEDULED, STATUS FROM COMPLAINT_TABLE C, CLIENT_DETAILS D WHERE C.ORGANISATION_ID = D.ORGANISATION_ID and D.ORG_NAME='" + textBox1.Text + "' ORDER BY ORGANISATION_ID";
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Resoveled"))
            {
                command = "select C.ORGANISATION_ID, D.ORG_NAME, DATE_OF_COMPLAINT, TIME_OF_COMPLAINT, PERSON_LOG_COMPLAINT, EQUIP_NAME, EQUIP_CAPACITY, MACHINE_UNDER, ENGINEER_SCHEDULED, STATUS FROM COMPLAINT_TABLE C, CLIENT_DETAILS D WHERE C.ORGANISATION_ID = D.ORGANISATION_ID and D.ORG_NAME='" + textBox1.Text + "' and STATUS='Resolved' ORDER BY ORGANISATION_ID";
            }
            else
            {
                command = "select C.ORGANISATION_ID, D.ORG_NAME, DATE_OF_COMPLAINT, TIME_OF_COMPLAINT, PERSON_LOG_COMPLAINT, EQUIP_NAME, EQUIP_CAPACITY, MACHINE_UNDER, ENGINEER_SCHEDULED, STATUS FROM COMPLAINT_TABLE C, CLIENT_DETAILS D WHERE C.ORGANISATION_ID = D.ORGANISATION_ID and D.ORG_NAME='" + textBox1.Text + "' and STATUS='Unresolved' ORDER BY ORGANISATION_ID";
            }
            report();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            groupBox2.Visible = false;
            groupBox5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("Select Type of Complaint (ALL/Resolved/UnResolved)");
                return;
            }
            if (comboBox1.SelectedItem.ToString().Equals("All"))
            {
                command = "select C.ORGANISATION_ID, D.ORG_NAME, DATE_OF_COMPLAINT, TIME_OF_COMPLAINT, PERSON_LOG_COMPLAINT, EQUIP_NAME, EQUIP_CAPACITY, MACHINE_UNDER, ENGINEER_SCHEDULED, STATUS FROM COMPLAINT_TABLE C, CLIENT_DETAILS D WHERE C.ORGANISATION_ID = D.ORGANISATION_ID and DATE_OF_COMPLAINT >= to_date('" + dateTimePicker1.Text + "') and DATE_OF_COMPLAINT <= to_date('" + dateTimePicker2.Text + "')  ORDER BY ORGANISATION_ID";
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Resoveled"))
            {
                command = "select C.ORGANISATION_ID, D.ORG_NAME, DATE_OF_COMPLAINT, TIME_OF_COMPLAINT, PERSON_LOG_COMPLAINT, EQUIP_NAME, EQUIP_CAPACITY, MACHINE_UNDER, ENGINEER_SCHEDULED, STATUS FROM COMPLAINT_TABLE C, CLIENT_DETAILS D WHERE C.ORGANISATION_ID = D.ORGANISATION_ID and DATE_OF_COMPLAINT >= to_date('" + dateTimePicker1.Text + "') and DATE_OF_COMPLAINT <= to_date('" + dateTimePicker2.Text + "') and STATUS='Resolved' ORDER BY ORGANISATION_ID";
            }
            else
            {
                command = "select C.ORGANISATION_ID, D.ORG_NAME, DATE_OF_COMPLAINT, TIME_OF_COMPLAINT, PERSON_LOG_COMPLAINT, EQUIP_NAME, EQUIP_CAPACITY, MACHINE_UNDER, ENGINEER_SCHEDULED, STATUS FROM COMPLAINT_TABLE C, CLIENT_DETAILS D WHERE C.ORGANISATION_ID = D.ORGANISATION_ID and DATE_OF_COMPLAINT >= to_date('" + dateTimePicker1.Text + "') and DATE_OF_COMPLAINT <= to_date('" + dateTimePicker2.Text + "') and STATUS='Unresolved' ORDER BY ORGANISATION_ID";
            }
            report();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox2.Visible = true;
            groupBox5.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = false;
            groupBox2.Visible = false;
            groupBox5.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Please Select one Client");
                return;
            }
            if (comboBox1.SelectedItem.ToString().Equals("All"))
            {
                command = "select C.ORGANISATION_ID, D.ORG_NAME, DATE_OF_COMPLAINT, TIME_OF_COMPLAINT, PERSON_LOG_COMPLAINT, EQUIP_NAME, EQUIP_CAPACITY, MACHINE_UNDER, ENGINEER_SCHEDULED, STATUS FROM COMPLAINT_TABLE C, CLIENT_DETAILS D WHERE C.ORGANISATION_ID = D.ORGANISATION_ID and C.ENGINEER_SCHEDULED='" + textBox2.Text + "' ORDER BY ORGANISATION_ID";
            }
            else if (comboBox1.SelectedItem.ToString().Equals("Resoveled"))
            {
                command = "select C.ORGANISATION_ID, D.ORG_NAME, DATE_OF_COMPLAINT, TIME_OF_COMPLAINT, PERSON_LOG_COMPLAINT, EQUIP_NAME, EQUIP_CAPACITY, MACHINE_UNDER, ENGINEER_SCHEDULED, STATUS FROM COMPLAINT_TABLE C, CLIENT_DETAILS D WHERE C.ORGANISATION_ID = D.ORGANISATION_ID andC.ENGINEER_SCHEDULED='" + textBox2.Text + "' and STATUS='Resolved' ORDER BY ORGANISATION_ID";
            }
            else
            {
                command = "select C.ORGANISATION_ID, D.ORG_NAME, DATE_OF_COMPLAINT, TIME_OF_COMPLAINT, PERSON_LOG_COMPLAINT, EQUIP_NAME, EQUIP_CAPACITY, MACHINE_UNDER, ENGINEER_SCHEDULED, STATUS FROM COMPLAINT_TABLE C, CLIENT_DETAILS D WHERE C.ORGANISATION_ID = D.ORGANISATION_ID and C.ENGINEER_SCHEDULED='" + textBox2.Text + "' and STATUS='Unresolved' ORDER BY ORGANISATION_ID";
            }
            report();
        }      
        
    }
}
