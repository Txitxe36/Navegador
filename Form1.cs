using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com/search?q="+ tBuscar.Text +"&sxsrf=ALeKk01gkfucGs2eRQKVLBhgrlNaeBKG3A%3A1619181677288&source=hp&ei=bcCCYOKSD6zR5OUP0KeQ6Ac&iflsig=AINFCbYAAAAAYILOfX9knirkriZgm-eRElg6zpwZjwdg&oq="+ tBuscar.Text +"&gs_lcp=Cgdnd3Mtd2l6EAMyBAgjECcyBAgjECcyBQguELEDMgUIABCxAzIFCAAQsQMyBQguELEDMgUILhCxAzIFCAAQsQMyBQguELEDMgUILhCxAzoHCCMQ6gIQJzoICAAQsQMQgwE6CwgAELEDEMcBEKMCOgIIADoLCAAQsQMQxwEQrwFQ0h5Y6ilg1TNoAXAAeACAAVSIAf8CkgEBNZgBAKABAaoBB2d3cy13aXqwAQo&sclient=gws-wiz&ved=0ahUKEwii_cvlsZTwAhWsKLkGHdATBH0Q4dUDCAk&uact=5");
        }

        private void bRojo_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void bVerde_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void bAzul_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightSteelBlue;
        }

        private void bVer_Click(object sender, EventArgs e)
        {
            bVer.Visible = !bVer.Visible;
        }

        private void bIr_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tBuscar.Text)) return;
            if (tBuscar.Equals("about:blank")) return;
            if (!tBuscar.Text.StartsWith("http://") &&
            !tBuscar.Text.StartsWith("https://") && !tBuscar.Text.EndsWith(".com") && !tBuscar.Text.EndsWith(".com.ar"));
            {
                tBuscar.Text = "http://" + tBuscar.Text ;
            }
            try
            {
                webBrowser1.Navigate(new Uri(tBuscar.Text));
            }
            catch
            {
                MessageBox.Show("Se produjo un error.");
            }
        }
    }
}
