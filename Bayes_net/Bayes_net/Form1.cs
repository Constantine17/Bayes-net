using System;                                                                                                                                                                                                           ///////////////////////////////////
using System.Collections.Generic;                                                                                                                                                                                       ////С17С17С17///С17///С17С17С17////
using System.ComponentModel;                                                                                                                                                                                            ////С17///С17///С17/////////С17////                        
using System.Data;                                                                                                                                                                                                      ////С17/////////С17//////С17///////                        
using System.Drawing;                                                                                                                                                                                                   ////С17///С17///С17/////С17////////                            
using System.Linq;                                                                                                                                                                                                      ////С17С17С17///С17/////С17////////                            
using System.Text;                                                                                                                                                                                                      ///////////////////////////////////
using System.Threading.Tasks;                                                                                                                                                                                           //////Constantine Seventeen////////
using System.Windows.Forms;                                                                                                                                                                                             ///////////////////////////////////


namespace Bayes_net
{
    public partial class Form1 : Form
    {
        /// <summary>
        TextBox[,] tb = new TextBox[30, 30];

        /// </summary>



        public Form1()
        {
            InitializeComponent();

            int x = 7, y = 20;
            for (int j = 0; j < 30; j++)
            {
                for (int i = 0; i < 30; i++)
                {
                    tb[i, j] = new TextBox() //свойства текстбоксов
                    {
                        Location = new Point(x, y),
                        Text = "0.0",
                        Size = new Size(24, 20)
                    };
                    this.Save.Controls.Add(tb[i, j]);
                    x += 25;
                }
                x = 7; y += 20;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
