using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPZ_2
{
    public partial class Form1 : Form
    {
        CarShop current_shop;

        public Form1()
        {
            InitializeComponent();
            this.current_shop = null;
            this.ClientSize = new Size(290, 290);
        }

        private void InitLables()
        {
            this.Tax.Text = Convert.ToString(this.current_shop.annual_tax());
            this.MonthProfit.Text = Convert.ToString(this.current_shop.profit(1));
            this.YearProfit.Text = Convert.ToString(this.current_shop.profit());

        }

        private void InitListBox()
        {
            this.EmployeeList.Items.Clear();
            foreach (var i in current_shop.Employees)
            {
                this.EmployeeList.Items.Add(i);
            }
        }

        private void ShopCreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                CarShop item = new CarShop(this.ShopName.Text,
                    this.ShopAddress.Text,
                    Convert.ToInt32(this.ShopDepAmount.Value),
                    Convert.ToInt32(this.ShopAmountItems.Value)
                    );
                this.ShopList.Items.Add(item);
                this.ShopHide_Click(sender, e);
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowCreateShop_Click(object sender, EventArgs e)
        {
            this.EmployeePanel.Visible = false;
            this.ShopCreatePanel.Visible = true;
            this.ShopCreatePanel.Location = new Point(290, 35);
            this.ClientSize = new Size(500, 290);
        }

        private void ShopHide_Click(object sender, EventArgs e)
        {
            this.ShopCreatePanel.Visible = false;
            this.ClientSize = new Size(290, 290);
        }

        private void EmployeeShow_Click(object sender, EventArgs e)
        {
            this.EmployeePanel.Visible = true;
            this.ShopCreatePanel.Visible = false;
            this.ShopCreatePanel.Location = new Point(290, 35);
            this.ClientSize = new Size(500, 290);

        }

        private void EmployeeHide_Click(object sender, EventArgs e)
        {
            this.EmployeePanel.Visible = false;
            this.ClientSize = new Size(290, 290);
        }

        private void ShopList_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.current_shop = this.ShopList.SelectedItem as CarShop;
            this.CurrentShop.Text = this.current_shop.ToString();
            this.EmployeeShow.Enabled = true;
            this.InitLables();
            this.InitListBox();
        }

        private void EmployeeCreate_Click(object sender, EventArgs e)
        {
            this.current_shop.add_empolee(
                this.EmployeeName.Text, 
                Convert.ToInt32(this.EmployeeSalary.Value)
                );
            this.InitLables();
            this.InitListBox();
        }
    }
}
