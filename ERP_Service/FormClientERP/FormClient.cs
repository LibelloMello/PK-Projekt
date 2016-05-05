using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormClientERP
{
    public partial class FormClient : Form
    {
        Controller c = new Controller();
        public FormClient()
        {
            InitializeComponent();
            FillComboBox();
            FillComboBoxMod();
        }

        private void comboBoxOptions(object sender, EventArgs e)
        {
            Choice();
        }
        private void Choice()
        {
            switch (comboBox.SelectedIndex)
            {
                case 0: Employees();
                    break;
                case 1: Relatives();
                    break;
                case 2: Sick2004();
                    break;
                case 3: MostAbscence();
                    break;
                case 4: AllKeys();
                    break;
                case 5: Indexes();
                    break;
                case 6: Constraints();
                    break;
                case 7: TableNames1();
                    break;
                case 8: TableNames2();
                    break;
                case 9: ColNames1();
                    break;
                case 10: ColNames2();
                    break;
                case 11: MetaKeys();
                    break;
                case 12: MetaConstraints();
                    break;
                case 13: MetaIndexes();
                    break;
                default:
                    break;
            }
        }
        private void ModChoice()
        {
            switch (comboBoxMod.SelectedIndex)
            {
                case 0:
                    textBoxId.Visible = false;
                    textBoxName.Visible = false;
                    labelID.Visible = false;
                    labelName.Visible = false;
                    executeModButton.Visible = false;      
                    break;
                case 1:
                    textBoxId.Visible = true;
                    textBoxName.Visible = true;
                    labelID.Visible = true;
                    labelName.Visible = true;
                    executeModButton.Visible = true;
                    break;
                case 2:
                    textBoxId.Visible = true;
                    textBoxName.Visible = false;
                    labelID.Visible = true;
                    labelName.Visible = false;
                    executeModButton.Visible = true;
                    break;
                case 3:
                    textBoxId.Visible = true;
                    textBoxName.Visible = true;
                    labelID.Visible = true;
                    labelName.Visible = true;
                    executeModButton.Visible = true;
                    break;
            }

        } 
        private void FillComboBox()
        {
            comboBox.Items.Add("All Employees");
            comboBox.Items.Add("All Employees Relatives");
            comboBox.Items.Add("Sick Employees 2004");
            comboBox.Items.Add("Employee With Most Absence");
            comboBox.Items.Add("All Keys");
            comboBox.Items.Add("All Indexes");
            comboBox.Items.Add("All Table Constraints");
            comboBox.Items.Add("All Table Names 1");
            comboBox.Items.Add("All Table Names 2");
            comboBox.Items.Add("All Column Names In Employee 1");
            comboBox.Items.Add("All Column Names In Employee 2");
            comboBox.Items.Add("Keys of Employee And Related Tables");
            comboBox.Items.Add("Constraints of Employee And Related Tables");
            comboBox.Items.Add("Indexes of Employee And Related Tables");
            comboBox.SelectedIndex = 0;
        }
        private void FillComboBoxMod()
        {
            comboBoxMod.Items.Add("Add, Remove or update Employee");
            comboBoxMod.Items.Add("Add a new Employee");
            comboBoxMod.Items.Add("Remove an existing Employee");
            comboBoxMod.Items.Add("Update an existing Employee");
            comboBoxMod.SelectedIndex = 0;

        }

        // A
        private void Employees()
        {
            FillView(c.AllEmployees());
        }

        private void Relatives()
        {
            FillView(c.Relatives());
        }

        private void Sick2004()
        {
            FillView(c.Sick2004());
        }

        private void MostAbscence()
        {
            FillView(c.MostAbscence());
        }

        //B
        private void AllKeys()
        {
            FillView(c.Keys());
        }

        private void Indexes()
        {
            FillView(c.Indexes());
        }

        private void Constraints()
        {
            FillView(c.TableConstraints());
        }

        private void TableNames1()
        {
            FillView(c.Tables1());
        }

        private void TableNames2()
        {
            FillView(c.Tables2());
        }

        private void ColNames1()
        {
            FillView(c.EmployeeColumns1());
        }

        private void ColNames2()
        {
            FillView(c.EmployeeColumns2());
        }
        private void MetaKeys() 
        {
            FillView();
        }
        private void AddEmployee(string id, string name)
        {
                    c.AddEmployee(id, name);
                    Employees();
        }
        private void RemoveEmployee(string id)
        {
            c.DeleteEmployee(id);
            Employees();
        }
        private void UpdateEmployee(string id, string name)
        {
            c.UpdateEmployee(id, name);
            Employees();
        }

        private void FillView(string[][] input)
        {
            DataTable dt = new DataTable();
            dt.Clear();

            for (int i = 0; i < input[0].Length; i++)
            {
                dt.Columns.Add(input[0][i].ToString());
            }
            foreach (string[] outerList in input.Skip(1))
            {
                int i = 0;
                DataRow row = dt.NewRow();
                foreach (string item in outerList)
                {
                    row[i] = item;
                    i++;
                }
                dt.Rows.Add(row);
            }
            mainDataGrid.DataSource = dt;
        }

        private void executeModButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxId.Text) || !string.Equals(textBoxId.Text, "THIS FIELD ID REQUIRED", StringComparison.OrdinalIgnoreCase) || !string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                switch (comboBoxMod.SelectedIndex)
                {
                    case 0:
                        break;
                    case 1:
                        AddEmployee(textBoxId.Text, textBoxName.Text);
                        break;
                    case 2:
                        RemoveEmployee(textBoxId.Text);
                        break;
                    case 3:
                        UpdateEmployee(textBoxId.Text, textBoxName.Text);
                        break;
                }
            }
            else
            {
                textBoxId.Text = "THIS FIELD ID REQUIRED";
            }
        }
        

        private void comboBoxMod_SelectedIndexChanged(object sender, EventArgs e)
        {
            ModChoice();
        }
    }
}
