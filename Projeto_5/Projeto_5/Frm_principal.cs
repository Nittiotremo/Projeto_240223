using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_5
{
    public partial class Form1 : Form
    {
        //Declaração de atributo público global
       public double Total;



        public Form1()
        {
            InitializeComponent();
        }

        private void Rdb_Masculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Rdb_Masculino_Click(object sender, EventArgs e)
        {
            Chb_Prostata.Enabled = true; //ativar a opção prostata

            //desativar exames para o sexo feminino
            if(Chb_Gravidez.Checked)
            {
                Total = Double.Parse(Lbl_Total.Text) - 100.89;
            }
            Lbl_Total.Text = Total.ToString();

            if(Chb_Mamografia.Checked)
            {
                Total = Double.Parse(Lbl_Total.Text) - 712.00;
            }
            Lbl_Total.Text = Total.ToString();



            Chb_Gravidez.Enabled = false;
            Chb_Mamografia.Enabled = false;
            Chb_Gravidez.Checked = false;
            Chb_Mamografia.Checked = false;
        }

        private void Rdb_feminino_Click(object sender, EventArgs e)
        {
            Chb_Gravidez.Enabled = true;
            Chb_Mamografia.Enabled = true;

            //desativar exames do sexo masculino
            if(Chb_Prostata.Checked)
            {
                Total = Double.Parse(Lbl_Total.Text) - 85.25;

            }
            Lbl_Total.Text = Total.ToString();

            Chb_Prostata.Enabled = false;
            Chb_Prostata.Checked = false;

        }

        private void Chb_Coracao_Click(object sender, EventArgs e)
        {
            if(Chb_Coracao.Checked)
            {
                Total = Double.Parse(Lbl_Total.Text) + 500.25;
            }
            else
            {
                Total = Double.Parse(Lbl_Total.Text) - 500.25;
            }

            Lbl_Total.Text = Total.ToString();
        }

        private void Chb_Gravidez_Click(object sender, EventArgs e)
        {
            if (Chb_Gravidez.Checked)
            {
                Total = Double.Parse(Lbl_Total.Text) + 100.89;
            }
            else
            {
                Total = Double.Parse(Lbl_Total.Text) - 100.89;
            }

            Lbl_Total.Text = Total.ToString();
        }

        private void Chb_Prostata_Click(object sender, EventArgs e)
        {
            if (Chb_Prostata.Checked)
            {
                Total = Double.Parse(Lbl_Total.Text) + 80.25;
            }
            else
            {
                Total = Double.Parse(Lbl_Total.Text) - 80.25;
            }

            Lbl_Total.Text = Total.ToString();
        }

        private void Chb_Sangue_Click(object sender, EventArgs e)
        {
            if (Chb_Sangue.Checked)
            {
                Total = Double.Parse(Lbl_Total.Text) + 15.00;
            }
            else
            {
                Total = Double.Parse(Lbl_Total.Text) - 15.00;
            }

            Lbl_Total.Text = Total.ToString();
        }

        private void Chb_Mamografia_Click(object sender, EventArgs e)
        {
            if (Chb_Mamografia.Checked)
            {
                Total = Double.Parse(Lbl_Total.Text) + 712.00;
            }
            else
            {
                Total = Double.Parse(Lbl_Total.Text) - 712.00;
            }

            Lbl_Total.Text = Total.ToString();
        }

        private void Chb_Ortopedico_Click(object sender, EventArgs e)
        {
            if (Chb_Ortopedico.Checked)
            {
                Total = Double.Parse(Lbl_Total.Text) + 87.00;
            }
            else
            {
                Total = Double.Parse(Lbl_Total.Text) - 87.00;
            }

            Lbl_Total.Text = Total.ToString();
        }

        private void Chb_Prostata_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
