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
        public FormClient()
        {
            InitializeComponent();
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
                default:
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
            comboBox.SelectedIndex = 0;
        }

        private void Employees()
        {
            throw new NotImplementedException();
        }

        private void Relatives()
        {
            throw new NotImplementedException();
        }

        private void Sick2004()
        {
            throw new NotImplementedException();
        }

        private void MostAbscence()
        {
            throw new NotImplementedException();
        }

        private void AllKeys()
        {
            throw new NotImplementedException();
        }

        private void Indexes()
        {
            throw new NotImplementedException();
        }

        private void Constraints()
        {
            throw new NotImplementedException();
        }

        private void TableNames1()
        {
            throw new NotImplementedException();
        }

        private void TableNames2()
        {
            throw new NotImplementedException();
        }

        private void ColNames1()
        {
            throw new NotImplementedException();
        }

        private void ColNames2()
        {
            throw new NotImplementedException();
        }
    }
}
