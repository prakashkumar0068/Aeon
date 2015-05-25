using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AeonNew
{
    public partial class Installement : Form
    {
        OracleConnection conn;
        OracleCommand cmd;
        int org_id, total_amount, installement_interval, decided_installement, total_install;
        String next_installment_date, serial_no;
        string machine_id = "";
        public Installement(int org_id, int total_amount, String serial_no)
        {
            this.serial_no = serial_no;
            this.org_id = org_id;
            this.total_amount = total_amount;
            InitializeComponent();
        }

        public Installement()
        {
            InitializeComponent();
        }

        public void clientlist(String query)
        {
            orgNameListbox.Items.Clear();
            //orgname.Clear();
            OracleDataReader dr;
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        //  orgname.Add(dr["ORG_NAME"].ToString());
                        orgNameListbox.Items.Add(dr["ORG_NAME"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Data not found.");
                }

                dr.Close();
            }
        }

        private void Installement_Load(object sender, EventArgs e)
        {
            txt_amount.Enabled = false;
            txt_amount.Text = total_amount.ToString();
            cmb_installement_type.Text = "Select Installements Type";
            clientlist("select ORG_NAME from CLIENT_DETAILS order by ORG_NAME asc");
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleTransaction tranObj;
                tranObj = con.BeginTransaction();
                OracleCommand _cmdObjj = con.CreateCommand();
                   next_installment_date = dateTimePicker_installement.Value.Day.ToString() + "/" + dateTimePicker_installement.Value.Month.ToString() + "/" + dateTimePicker_installement.Value.Year.ToString();
                try
                {
                   
                        if (orgNameListbox.SelectedIndex < 0)
                        {
                            MessageBox.Show("Select Organization Name");
                            return;
                        }

                        if (serialNumber.SelectedIndex < 0)
                        {
                            MessageBox.Show("Select Serial Number");
                            return;
                        }
                        if (cmb_installement_type.SelectedIndex < 0)
                        {
                            MessageBox.Show("Select Installment Type");
                            return;
                        }
                        else
                        {

                            string fromdate1 = dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Month.ToString() + "/" + dateTimePicker1.Value.Year.ToString();
                            string todate1 = dateTimePicker2.Value.Day.ToString() + "/" + dateTimePicker2.Value.Month.ToString() + "/" + dateTimePicker2.Value.Year.ToString();
                            _cmdObjj.CommandText = "insert into CLIENT_INSTALLEMENTS_DETAILS values(" + org_id + "," + Convert.ToInt32(txt_amount.Text) + ",0," + decided_installement + "," + installement_interval + ",'" + next_installment_date + "',0," + total_install + "," + decided_installement + ",0,0,'" + serial_no + "'," + machine_id + ")";

                            _cmdObjj.CommandType = CommandType.Text;
                            _cmdObjj.Parameters.Clear();
                            _cmdObjj.ExecuteNonQuery();

                            _cmdObjj.CommandText = "update EQUIPMENTT_DETAILS set IS_ACTIVE = 1 Where ORGANISATION_ID=" + org_id + " and AMC_END_DATE >= to_date('" + fromdate1 + "','DD/MM/YYYY') and AMC_END_DATE <= to_date('" + todate1 + "','DD/MM/YYYY') and SERIAL_NUMBER='" + serialNumber.SelectedItem.ToString() + "'";
                            _cmdObjj.CommandType = CommandType.Text;
                            _cmdObjj.Parameters.Clear();
                            _cmdObjj.ExecuteNonQuery();
                            tranObj.Commit();
                            MessageBox.Show("Data Saved");
                        }
                }
                catch(Exception ex)
                {
                    tranObj.Rollback();
                }
            }
         
           
        }

        private void cmb_installement_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_installement_type.SelectedIndex == 0)
            {
                installement_interval = 1;
                total_install = 12;
            }
            if (cmb_installement_type.SelectedIndex == 1)
            {
                installement_interval = 3;
                total_install = 12 / 3;
            }
            if (cmb_installement_type.SelectedIndex == 2)
            {
                installement_interval = 6;
                total_install = 12 / 6;
            }
            if (cmb_installement_type.SelectedIndex == 3)
            {
                installement_interval = 12;
                total_install = 12 / 12;
            }
            decided_installement = (Convert.ToInt32(txt_amount.Text) / total_install);
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string fromdate1 = dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Month.ToString() + "/" + dateTimePicker1.Value.Year.ToString();
            string todate1 = dateTimePicker2.Value.Day.ToString() + "/" + dateTimePicker2.Value.Month.ToString() + "/" + dateTimePicker2.Value.Year.ToString();
            getserial("Select SERIAL_NUMBER from EQUIPMENTT_DETAILS Where ORGANISATION_ID=" + org_id + " and AMC_END_DATE >= to_date('" + fromdate1 + "','DD/MM/YYYY') and AMC_END_DATE <= to_date('" + todate1 + "','DD/MM/YYYY')  and IS_ACTIVE=0");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string fromdate1 = dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Month.ToString() + "/" + dateTimePicker1.Value.Year.ToString();
            string todate1 = dateTimePicker2.Value.Day.ToString() + "/" + dateTimePicker2.Value.Month.ToString() + "/" + dateTimePicker2.Value.Year.ToString();
            getserial("Select SERIAL_NUMBER from EQUIPMENTT_DETAILS Where ORGANISATION_ID=" + org_id + " and AMC_END_DATE >= to_date('" + fromdate1 + "','DD/MM/YYYY') and AMC_END_DATE <= to_date('" + todate1 + "','DD/MM/YYYY') and IS_ACTIVE=0");
        }
        public void getserial(string query)
        {
            OracleDataReader dr;

            serialNumber.Items.Clear();
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {

                        serialNumber.Items.Add(dr["SERIAL_NUMBER"].ToString());
                    }
                }
                else
                {
                    MessageBox.Show("Data not found.");
                }

                dr.Close();
            }
        }

        private void orgNameListbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleDataReader dr;
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select ORGANISATION_ID from CLIENT_DETAILS where ORG_NAME='" + orgNameListbox.SelectedItem.ToString() + "' ";
                dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        //id.Text = dr[0].ToString();
                        org_id = Convert.ToInt32(dr[0].ToString());
                        // UpdateBasic.id = id.Text;

                    }

                }


                dr.Close();
            }

        }

        private void serialNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            OracleDataReader dr;
             string fromdate1 = dateTimePicker1.Value.Day.ToString() + "/" + dateTimePicker1.Value.Month.ToString() + "/" + dateTimePicker1.Value.Year.ToString();
            string todate1 = dateTimePicker2.Value.Day.ToString() + "/" + dateTimePicker2.Value.Month.ToString() + "/" + dateTimePicker2.Value.Year.ToString();
            using (OracleConnection con = ConnectionManager.getDatabaseConnection())
            {

                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select ID ,AMC_UNIT_PRICE from EQUIPMENTT_DETAILS where SERIAL_NUMBER='" + serialNumber.SelectedItem.ToString() + "' and  ORGANISATION_ID=" + org_id + " and AMC_END_DATE >= to_date('" + fromdate1 + "','DD/MM/YYYY') and AMC_END_DATE <= to_date('" + todate1 + "','DD/MM/YYYY') ";
                dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    if (dr.Read())
                    {
                        total_amount = Convert.ToInt32(dr[1].ToString());
                        machine_id = dr[0].ToString();
                        txt_amount.Text = total_amount.ToString();
                        serial_no = serialNumber.SelectedItem.ToString();
                    }

                }


                dr.Close();
            }
        }

        private void serialNumber_MouseClick(object sender, MouseEventArgs e)
        {
            if(serialNumber.Items.Count == 0)
            {
                MessageBox.Show("Change Date AMC Start and End Date");
                return;
            }
        }
    }
}