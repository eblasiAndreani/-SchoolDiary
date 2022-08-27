using School_V_1.Entities;
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

namespace School_V_1.Presentacion
{
    public partial class FrmTabla : Form
    {
        public int? id;
        Alumno alumno = null;
        public FrmTabla(int? id=null)
        {
            InitializeComponent();
            this.id = id;
            if (id != null)
                CargaDatos();
        }

        private void CargaDatos()
        {
            using (Context db = new())
            {
                alumno = db.Alumno.Find(id);
            };
            textApellidoNombre.Text = alumno.ApellidoNombres.ToString();
            dateNacimiento.Value = alumno.FechaNacimiento.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Context db = new())
            {
                if(id is null)
                    alumno = new Alumno();

                alumno.ApellidoNombres = textApellidoNombre.Text;
                alumno.FechaNacimiento = dateNacimiento.Value;

                if(id is null)
                    db.Add(alumno);
                else
                    db.Update(alumno);
                db.SaveChanges();
                this.Close();
            }
        }

        private void FrmTabla_Load(object sender, EventArgs e)
        {

        }
    }
}
