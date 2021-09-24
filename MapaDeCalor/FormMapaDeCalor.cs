using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapaDeCalor
{
    public partial class FormMapaDeCalor : Form
    {
        public FormMapaDeCalor()
        {
            InitializeComponent();
            FormController formController = new FormController(this);
        }

    }
}
