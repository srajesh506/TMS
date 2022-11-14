using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMS.Home
{
    public partial class frmteamregister : Form
    {
        private Random random;
        private int tempindex;
        public frmteamregister()
        {
           
            InitializeComponent();
            random = new Random();
            LoadTheme();
        }

        private void LoadTheme()
        {
           
                foreach (Control btns in this.Controls)
                {
                    if (btns.GetType() == typeof(Button))
                    {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                    }
                }
            btnadd.ForeColor = ThemeColor.PrimaryColor;
            btnsave.ForeColor = ThemeColor.PrimaryColor;
            btnmodify.ForeColor = ThemeColor.PrimaryColor;
            btncancel.ForeColor = ThemeColor.PrimaryColor;
            btnexit.ForeColor = ThemeColor.PrimaryColor;
            lblreg.BackColor = ThemeColor.SecondaryColor;
            lblempid.ForeColor = ThemeColor.SecondaryColor;
            lblname.ForeColor = ThemeColor.SecondaryColor;
            lblrole.ForeColor = ThemeColor.SecondaryColor;
            lblemail.ForeColor = ThemeColor.SecondaryColor;
            lblremark.ForeColor = ThemeColor.SecondaryColor;
            groupBoxforregistration.ForeColor= ThemeColor.PrimaryColor;
            groupBoxforbutton.ForeColor = ThemeColor.PrimaryColor;
            groupBoxforexistingemployee.ForeColor = ThemeColor.PrimaryColor;
            chkactive.ForeColor = ThemeColor.SecondaryColor;
            txtempid.ForeColor= ThemeColor.SecondaryColor;
            txtname.ForeColor = ThemeColor.SecondaryColor;
            txtrole.ForeColor = ThemeColor.SecondaryColor;
            txtemail.ForeColor = ThemeColor.SecondaryColor;
            rtxtremark.ForeColor = ThemeColor.SecondaryColor;
            txtpwd.ForeColor = ThemeColor.SecondaryColor;
            btnupload.BackColor = ThemeColor.PrimaryColor;
            btnupload.ForeColor = ThemeColor.SecondaryColor;
            
        }

      

        private Form activeForm;

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dview_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnadd_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            string imagelocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if(dialog.ShowDialog()==DialogResult.OK)
                {
                    imagelocation = dialog.FileName;
                    pictureBox1.ImageLocation = imagelocation;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("An error occured!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void OpenChildForm(Form childform, Object btnsender)
        //{
        //    if (activeForm != null)
        //    {
        //        activeForm.Close();
        //    }
        //    ActiveButton(btnsender);
        //    activeForm = childform;
        //    childform.TopLevel = false;
        //    childform.FormBorderStyle = FormBorderStyle.None;
        //    childform.Dock = DockStyle.Fill;
        //    this.panel2.Controls.Add(childform);
        //    this.panel2.Tag = childform;
        //    childform.BringToFront();
        //    childform.Show();
        //    //labeltitle.Text = childform.Text;
        //}
        //private Button currentButton;
        //private void ActiveButton(object btnsender)
        //{
        //    if (btnsender != null)
        //    {
        //        if (currentButton != (Button)btnsender)
        //        {
        //            DisableButton();
        //            Color color = SelectThemeColor();
        //            currentButton = (Button)btnsender;
        //            currentButton.BackColor = color;
        //            currentButton.ForeColor = Color.White;
        //            currentButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            //paneltitlebar.BackColor = color;
        //            //panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, 0.3);
        //            ThemeColor.PrimaryColor = color;
        //            ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, 0.3);
        //            //btnclosechildform.Visible = true;
        //        }
        //    }
        //}

        //private Color SelectThemeColor()
        //{
        //    int index = random.Next(ThemeColor.ColorList.Count);
        //    while (tempindex == index)
        //    {
        //        index = random.Next(ThemeColor.ColorList.Count);
        //    }
        //    tempindex = index;
        //    string color = ThemeColor.ColorList[index];
        //    return ColorTranslator.FromHtml(color);
        //}
        //private void DisableButton()
        //{
        //    foreach (Control previousbtn in panel2.Controls)
        //    {
        //        foreach (Control btn in previousbtn.Controls)
        //        {
        //            if (btn.GetType() == typeof(Button))
        //            {
        //                btn.BackColor = Color.FromArgb(35, 40, 45);
        //                btn.ForeColor = Color.Gainsboro;
        //                btn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //            }

        //        }
        //    }
        //}
    }
}
