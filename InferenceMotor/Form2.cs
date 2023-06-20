using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InferenceMotor
{   
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            /**
             * El truco esta en definir explicitamente un set de reglas y un set de posibles respuestas
             * Tipo SI A y B ENTONCES C
             * Y se puede reusar C como entrada despues. Toda entrada nueva que se descubra, debe de ser preguntada al usuario. De ahi la inferencia. 
             * Los datos que se van calculando no se preguntan. Por ejemplo si se pregunta si A = true y B = true, no se pregunta si C = true ya que ya se sabe
             * En su lugar se pregunta si D = true en caso de que SI C y D ENTONCES E. 
             * Repetir con todas las reglas hasta terminar
             * Se debe de contar con una pregunta visible al usuario, un set de posibles valores, 
             * y el valor que corresponda en el bloque de inferencia para considerarse verdadero
             */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 volver = new Form1();
            volver.Show(); 
            this.Hide();
        }
    }

    public class InferenceRule
    {
        private string question;
        public InferenceRule()
        {
            this.question = string.Empty;
        }

        public string GetQuestion()
        {
            return this.question;
        }

        public ArrayList PossibleResults()
        {
            return new ArrayList();
        }
    }
}
