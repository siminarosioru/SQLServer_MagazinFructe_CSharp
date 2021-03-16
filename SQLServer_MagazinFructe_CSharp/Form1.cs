using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLServer_MagazinFructe_CSharp
{
    public partial class Form1 : Form
    {
        //add variables
        Form2 form2Admin;
        Form3 form3Employee;

        public Form1()
        {
            InitializeComponent();

            form2Admin = new Form2();
            form3Employee = new Form3();
            form2Admin.Visible = false;
            form3Employee.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (MagazinFructeEntities modelEntity = new MagazinFructeEntities())
            {
                int LoginMember = 0;

                foreach (var logare in modelEntity.Table_Users)
                {
                    if((logare.Username == txtUsername.Text) && (logare.Password == txtPassword.Text))
                    {
                        LoginMember = logare.Type;
                    }
                }

                if (LoginMember == 1)
                    form2Admin.Visible = true;
                if (LoginMember == 2 || form3Employee.IsDisposed)
                {
                    form3Employee = new Form3();

                    form3Employee.Visible = true;
                }
                if (LoginMember == 0)
                    MessageBox.Show("User was not found.");


                var queryUser = new Table_Users()
                {
                    //old userID
                    /*userID = 17,
                    Username = "GrelusD",
                    Password = "didi12",
                    Type = 2, */

                    //new userID
                    userID = 18,
                    Username = "IliesiO",
                    Password = "oana1239",
                    Type = 2,
                };

                //add persons
                modelEntity.Table_Users.Add(queryUser);

            }
        }
    }
}

