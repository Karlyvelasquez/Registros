using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Registros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Stream myStream;
        int counter  = 0;
        string line;

        private void btnPorLinea_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "Archivos (+.txt) | +.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    if ((myStream = openFileDialog.OpenFile()) != null) 
                    {
                        using (myStream) 
                        {
                            System.IO.StreamReader file = new System.IO.StreamReader(openFileDialog.FileName);  
                            
                            while ((line = file.ReadLine()) != null) 
                            {
                                txtLinea.Text = txtLinea.Text + line;
                                counter++;

                            }
                            file.Close();
                        }                   
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void btnCSV_Click(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "ID";
            col1.Width = 200;
            col1.ReadOnly = true;
            dtgDatos.Columns.Add(col1);

            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Nombre";
            col2.Width = 200;
            col2.ReadOnly = true;
            dtgDatos.Columns.Add(col2);

            DataGridViewTextBoxColumn col3 = new DataGridViewTextBoxColumn();
            col3.HeaderText = "Apellido";
            col3.Width = 200;
            col3.ReadOnly = true;
            dtgDatos.Columns.Add(col3);

            char delimitador = ';';
            string[] valores;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Application.StartupPath;
            openFileDialog.Filter = "Archivos (*.csv) | *.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    if ((myStream = openFileDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            System.IO.StreamReader file = new StreamReader(openFileDialog.FileName);

                            while ((line = file.ReadLine ()) != null) 
                            {

                                if (counter >= 1)
                                {
                                    valores = line.Split(delimitador);
                                    dtgDatos.Rows.Add(valores.ToArray());
                                    counter++;
                                }
                                else
                                {
                                    counter++;

                                }
                                
                                }  
                            file.Close();


                            }
                        

                        }
                    }

                
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }

        }
    }
}
