﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralamaOtomasyonu1
{
    public partial class frmAracListele_Kayit : Form
    {
        FormOperations formO = new FormOperations();
        SqlOperation sqlO = new SqlOperation();
        
        public frmAracListele_Kayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAracKayit AK = new frmAracKayit();
            AK.Show();
        }

        private void frmAracListele_Kayit_Load(object sender, EventArgs e)
        {
            formO.DatagridDoldur(dataGridView1, "SP_AracListesi");
            this.dataGridView1.Columns[0].Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(textBox1.Text)))
            {
                formO.Arama("SP_AracListesi", dataGridView1, "@Plaka", textBox1.Text);
            }
            else
            {
                formO.Arama("SP_AracListesi", dataGridView1, "@Plaka","0000");
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            frmAracKayit AK = new frmAracKayit();
            AK.txtPlaka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            AK.cmbMarka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            AK.cmbModel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            AK.txtAracRuhsat.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();            
            AK.cmbRenk.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            AK.txtKm.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[7].Value.ToString()=="False")
            {
                AK.cmbKiraD.Text="Kiralanmamış";
            }
            else
            {
                AK.cmbKiraD.Text = "Kiralanmış";
            }
            AK.cmbAracTip.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            AK.txtDGunluk.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            AK.txtDHaftalik.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            AK.txtDAylik.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();
            AK.txtDYillik.Text = dataGridView1.CurrentRow.Cells[12].Value.ToString();
            AK.txtSGunluk.Text = dataGridView1.CurrentRow.Cells[13].Value.ToString();
            AK.txtSHaftalik.Text = dataGridView1.CurrentRow.Cells[14].Value.ToString();
            AK.txtSAylik.Text = dataGridView1.CurrentRow.Cells[15].Value.ToString();
            AK.txtSYillik.Text = dataGridView1.CurrentRow.Cells[16].Value.ToString();
            AK.cmbYil.Text = dataGridView1.CurrentRow.Cells[17].Value.ToString();
            AK.cmbYakitTur.Text = dataGridView1.CurrentRow.Cells[18].Value.ToString();
            AK.cmbEhliyet.Text = dataGridView1.CurrentRow.Cells[19].Value.ToString();
            AK.cmbVites.Text = dataGridView1.CurrentRow.Cells[20].Value.ToString();
            AK.ShowDialog();
        }
    }
}
