
using SanatOkulu.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SanatOkulu
{
    public partial class Form1 : Form
    {
        SanatOkuluContext db = new SanatOkuluContext();

        public Form1()
        {
            InitializeComponent();
            SanatcileriYukle();
            EserleriListele();

            string benzersiz = Guid.NewGuid().ToString();
        }
        void SanatciFormuAc()
        {
            var frm = new SanatciForm(db);
            frm.SanatcilarDegisti += Frm_SanatcilarDegisti;
            frm.ShowDialog();
        }

        private void Frm_SanatcilarDegisti(object sender, EventArgs e)
        {
            EserleriListele();
            SanatcileriYukle();
        }

        private void SanatcileriYukle()
        {
            cboSanatci.DataSource = db.Sanatcilar.OrderBy(x => x.Ad).ToList();
            cboSanatci.ValueMember = "Id";
            cboSanatci.DisplayMember = "Ad";
            cboSanatci.SelectedIndex = -1;
        }

        private void pboYeniSanatci_Click(object sender, EventArgs e)
        {
            SanatciFormuAc();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();

            if (ad == "")
            {
                MessageBox.Show("Lütfen eserini adını belirtiniz.");
                return;
            }

            if (cboSanatci.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen bir sanatçı seçiniz.");
                return;
            }
            if (duzenlenen == null)
            {
                var eser = new Eser()
                {
                    Ad = ad,
                    SanatciId = (int)cboSanatci.SelectedValue,
                    Yil = mtbYil.Text == "" ? null as int? : Convert.ToInt32(mtbYil.Text),
                    Resim = Yardimci.DosyaKaydet(ofdResim.FileName)
                };
                db.Eserler.Add(eser);
            }
            else
            {
                duzenlenen.Ad = ad;
                duzenlenen.SanatciId = (int)cboSanatci.SelectedValue;
                duzenlenen.Yil = mtbYil.Text == "" ? null as int? : Convert.ToInt32(mtbYil.Text);
                if (!string.IsNullOrEmpty(ofdResim.FileName))
                {
                    duzenlenen.Resim = Yardimci.DosyaKaydet(ofdResim.FileName);
                }
            }


            db.SaveChanges();
            FormuResetle();
            EserleriListele();

        }

        private void EserleriListele()
        {
            lvwEserler.Items.Clear();
            ImageList largeImageList = new ImageList();
            largeImageList.ImageSize = new Size(128, 128);
            ImageList smallImageList = new ImageList();
            smallImageList.ImageSize = new Size(24, 24);


            foreach (Eser eser in db.Eserler.OrderBy(x => x.Yil))
            {
                ListViewItem lvi = new ListViewItem(eser.Ad);
                lvi.SubItems.Add(eser.Sanatci.Ad);
                lvi.SubItems.Add(eser.Yil.ToString());
                lvi.Tag = eser;
                if (eser.Resim != null)
                {
                    largeImageList.Images.Add(eser.Resim, Yardimci.ResimGetir(eser.Resim));
                    smallImageList.Images.Add(eser.Resim, Yardimci.ResimGetir(eser.Resim));
                }
                lvi.ImageKey = eser.Resim;
                lvwEserler.Items.Add(lvi);
            }
            lvwEserler.LargeImageList = largeImageList;
            lvwEserler.SmallImageList = smallImageList;

        }

        private void FormuResetle()
        {
            txtAd.Clear();
            txtAd.Focus();
            mtbYil.Clear();
            cboSanatci.SelectedIndex = -1;
            duzenlenen = null;
            btnIptal.Hide();
            btnEkle.Text = "EKLE";
            lvwEserler.Enabled = true;
            pboResim.Image = null;
            ofdResim.FileName = null;
        }

        private void tsmiSanatcilar_Click(object sender, EventArgs e)
        {
            SanatciFormuAc();
        }

        private void lvwEserler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && lvwEserler.SelectedItems.Count == 1)
            {
                DialogResult dr = MessageBox.Show("Silmek istediginizden emin misiniz?",
                    "Silme Onayi",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.Yes)
                {
                    Eser eser = (Eser)lvwEserler.SelectedItems[0].Tag;
                    db.Eserler.Remove(eser);
                    db.SaveChanges();
                    EserleriListele();
                }

            }
        }
        Eser duzenlenen;
        private void lvwEserler_DoubleClick(object sender, EventArgs e)
        {
            var lvi = lvwEserler.SelectedItems[0];
            duzenlenen = (Eser)lvi.Tag;
            txtAd.Text = duzenlenen.Ad;
            cboSanatci.SelectedItem = duzenlenen.Sanatci;
            mtbYil.Text = duzenlenen.Yil.ToString();
            btnEkle.Text = "KAYDET";
            lvwEserler.Enabled = false;
            pboResim.Image = Yardimci.ResimGetir(duzenlenen.Resim);
            ofdResim.FileName = null;
            btnIptal.Show();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            FormuResetle();
        }

        private void pboResim_Click(object sender, EventArgs e)
        {
            DialogResult dr = ofdResim.ShowDialog();
            if (dr == DialogResult.OK)
                pboResim.Image = Image.FromFile(ofdResim.FileName);

        }

        private void cboGorunum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboGorunum.SelectedIndex == -1) return;
            switch ((string)cboGorunum.SelectedItem)
            {
                case "Büyük Simgeler":
                    lvwEserler.View = View.LargeIcon;
                    break;
                case "Küçük Simgeler":
                    lvwEserler.View = View.SmallIcon;
                    break;
                case "Listele":
                    lvwEserler.View = View.List;
                    break;
                case "Ayrıntılar":
                    lvwEserler.View = View.Details;
                    break;
                case "Döşemeler":
                    lvwEserler.View = View.Tile;
                    break;
                default:
                    lvwEserler.View = View.Details;
                    break;
            }
        }

        private void lvwEserler_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwEserler.SelectedItems.Count == 0)
                BackgroundImage = null;
            else
            {
                var lvi = lvwEserler.SelectedItems[0];
                Eser eser = (Eser)lvi.Tag;
                BackgroundImage = Yardimci.ResimGetir(eser.Resim);

            }

        }

        private void tsmiResmiYeniPenceredeAc_Click(object sender, EventArgs e)
        {
            if (lvwEserler.SelectedItems.Count != 1) return;

            Eser eser = (Eser)lvwEserler.SelectedItems[0].Tag;

            if (eser.Resim == null) return;

            new ResimForm(eser.Ad, Yardimci.ResimGetir(eser.Resim)).Show();
        }

        private void cmsEserler_Opening(object sender, CancelEventArgs e)
        {
            e.Cancel = lvwEserler.SelectedItems.Count != 1;
        }
    }
}
