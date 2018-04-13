using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearningInterfaceAndAbstractClassV0._3b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Worker[] Bees = new Worker[3];
            Bees[0] = new NectarCollector();
            Bees[1] = new StingPatrol();
            Bees[2] = new NectarStinger();
            for (int i = 0; i < Bees.Length; i++)
            {
                if (Bees[i] is INectarCollector) //By using loop for and adding word "is" we can check if this type of bee implement interface that we wanna use. If yes, we can assign new work to her.
                {
                Bees[i].DoThisJob("Zbieranie nektaru", 3);
                }
            }
        }
    }
}
