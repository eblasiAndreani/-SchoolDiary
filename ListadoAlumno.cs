using School_V_1.Persistance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School_V_1
{
    public partial class ListadoAlumno : Form
    {
        public ListadoAlumno()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Alumno_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void Refrescar()
        {
            using (Context db = new())
            {
                var lst = from d in db.Alumno select d;
                dataGridView1.DataSource = lst.ToList();
            }
        }

        private void NuevoBtn_Click(object sender, EventArgs e)
        {
            Presentacion.FrmTabla frmTabla = new Presentacion.FrmTabla();

            frmTabla.ShowDialog();

            Refrescar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if(id!= null)
            {
                Presentacion.FrmTabla frmTabla = new(id);
                frmTabla.ShowDialog();
                Refrescar();
            }
        }

        

        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int? id = GetId();
            if (id != null)
            {
                using (Context db = new())
                {
                    var alumno = db.Alumno.Find(id); 
                    db.Alumno.Remove(alumno);
                    db.SaveChanges();
                }
                Refrescar();
            }
        }
    }
}
