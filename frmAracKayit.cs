using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace AracKiralamaOtomasyonu1
{
    public partial class frmAracKayit : Form
    {
        SqlConnection con = SQLConnection.ConnectionControl();
        FormOperations formOperations = new FormOperations();
        int ModelID;
        public frmAracKayit()
        {
            InitializeComponent();
        }

       

        private void frmAracKayit_Load(object sender, EventArgs e)
        {

        }
          
        private void brnResimSec_Click(object sender, EventArgs e)
        {
            formOperations.ImageSelect(openFileDialog1, picArac);        
        }

        private void btnAracKaydet_Click(object sender, EventArgs e)
        {
            formOperations.AracAdd(openFileDialog1, picArac, "SP_AracEkle", txtPlaka, cmbMarka, cmbAracTip, cmbModel, cmbRenk,
            cmbYakitTur, cmbEhliyet, cmbVites, cmbYil, txtAracRuhsat, txtKm, txtSGunluk, txtSHaftalik, txtSAylik, txtSYillik, txtDGunluk,
            txtDHaftalik, txtDAylik, txtDYillik);
            MessageBox.Show("Kayıt Eklendi","Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
 
        private void cmbMarka_Click(object sender, EventArgs e)
        {
            cmbMarka.Items.Clear();
            ModelID = formOperations.Comboboxİndex(cmbMarka);
            formOperations.ComboboxFill("SP_MarkaListele", cmbMarka, "MarkaAdi");
        }

        private void cmbAracTip_Click(object sender, EventArgs e)
        {
            cmbAracTip.Items.Clear();
            formOperations.ComboboxFill("SP_AracTipiListele", cmbAracTip,"AracTipi");
        }

        private void cmbVites_Click(object sender, EventArgs e)
        {
            cmbVites.Items.Clear();
            formOperations.ComboboxFill("SP_VitesListele", cmbVites, "VitesTuru");
        }

        private void cmbRenk_Click(object sender, EventArgs e)
        {
            cmbRenk.Items.Clear();
            formOperations.ComboboxFill("SP_RenkListele", cmbRenk, "Renk");
        }

        private void cmbYakitTur_Click(object sender, EventArgs e)
        {
            cmbYakitTur.Items.Clear();
            formOperations.ComboboxFill("SP_YakitTuruListele", cmbYakitTur, "YakitTuru");
        }

        private void cmbEhliyet_Click(object sender, EventArgs e)
        {
            cmbEhliyet.Items.Clear();
            formOperations.ComboboxFill("SP_EhliyetSinifiListele", cmbEhliyet, "EhliyetSinifi");
        }

        private void cmbYil_Click(object sender, EventArgs e)
        {
            cmbYil.Items.Clear();
            formOperations.ComboboxFill("SP_YilListele", cmbYil, "Yil");
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbModel_Click(object sender, EventArgs e)
        {
            cmbModel.Items.Clear();
            formOperations.ComboboxFill2("SP_ModelListele",cmbModel,cmbMarka,"@MarkaID");
        }
    }
}
