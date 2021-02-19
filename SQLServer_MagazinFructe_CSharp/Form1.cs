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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            using (MagazinFructeEntities modelEntity = new MagazinFructeEntities())
            {
                var query = from admin in modelEntity.Table_Users
                            where admin.Username == txtUsername.Text && admin.Password == txtPassword.Text
                            select admin;

                if (query.SingleOrDefault() != null)
                {
                    MessageBox.Show("ADMIN is logged.");
                }
                else
                {
                    MessageBox.Show("error");
                }

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

                //save the information
                modelEntity.SaveChanges();
            }
        }
    }
}
