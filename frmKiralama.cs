using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;



namespace AracKiralamaOtomasyonu1
{
    public partial class frmKiralama : Form
    {
        public frmKiralama()
        {
            InitializeComponent();
        }
        FormOperations formO = new FormOperations();
        private void btnBilgiGetir_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTC.Text))
            {
                formO.TxtMusteriDoldur("SP_MusteriGetir", lblAd, lblSoyad, lblCinsiyet, lblDogumT, lblTelefon, lblEmail, lblEhliyetSinifi, lblEhliyetNo, lblEhliyetTarihi,lblAdres, txtTC.Text);
            }
        }

      
    }
}
