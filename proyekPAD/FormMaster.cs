using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyekPAD
{
    public partial class FormMaster : Form
    {
        public FormMaster()
        {
            InitializeComponent();
        }

        private void FormMaster_Load(object sender, EventArgs e)
        {
            loadDGV();
        }

        public void loadDGV()
        {
            db_uniqloEntities context = new db_uniqloEntities();

            var barang = from b in context.barangs
                         join d in context.diskons on b.id_diskon equals d.id_diskon
                         join v in context.vouchers on b.id_voucher equals v.kode_voucher
                         select new
                         {
                             ID_Barang = b.id_barang,
                             Nama_Barang = b.nama_barang,
                             Harga_Beli = b.harga_beli,
                             Harga_Jual = b.harga_jual,
                             Stok_Barang = b.stok_barang,
                             Diskon = d.jenis_diskon,
                             Voucher = v.kode_voucher
                         };

            dgvMaster.DataSource = barang.ToList();
        }
    }
}
