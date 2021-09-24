using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaDeCalor
{
    class FormController
    {
        private FormMapaDeCalor formMapaDeCalor;

        public FormController(FormMapaDeCalor form1)
        {
            this.formMapaDeCalor = form1;
            this.formMapaDeCalor.btnCalcular.Click += new EventHandler(Prueba);
        }

        private void Prueba(object sender, EventArgs args)
        {
            int CoordX = this.formMapaDeCalor.pnlExterno.Location.X;
            int CoordY = this.formMapaDeCalor.pnlExterno.Location.Y + this.formMapaDeCalor.pnlExterno.Height;

            int anchoCuadro = this.formMapaDeCalor.pnlReferencia.Width;
            int altoCuadro = this.formMapaDeCalor.pnlReferencia.Height;

            int anchoIndicador = this.formMapaDeCalor.pbxIndicador.Width;
            int altoIndicador = this.formMapaDeCalor.pbxIndicador.Height;

            this.formMapaDeCalor.indicador.Location = new System.Drawing.Point((Convert.ToInt32(this.formMapaDeCalor.cbxX.SelectedItem) - 1) * (anchoCuadro) + CoordX + anchoCuadro/2 - anchoIndicador/2 , (Convert.ToInt32(this.formMapaDeCalor.cbxY.SelectedItem)-1) * (-altoCuadro) + CoordY - altoCuadro / 2 - altoIndicador / 2);
            //this.formMapaDeCalor.pbxIndicador.BringToFront();
            //this.formMapaDeCalor.pbxIndicador.BackColor = Color.Transparent;
            this.formMapaDeCalor.indicador.Visible = true;
        }
    }
}
