using System.IO;

namespace Calcolo_Codice_Fiscale
{
    public partial class Form1 : Form
    {
   
        // NON TOCCARE 
        public Form1()
        {
            InitializeComponent();
        }

        //creo una lista dati di tipo persona
        List<Persona> Dati { get; set; } = new List<Persona>();

        private const string path = "C:\\Users\\michela.loi\\Desktop\\Esempio file\\esempioFile.csv";


        private void CaricaFile()
        {
            using (var sr = new StreamReader(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] persona = sr.ReadLine().Split(';');
                    Dati.Add(new Persona(persona[0], persona[1], (persona[2])));

                }
            }
        }




        private void tex_box_nome_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void text_box_cognome_TextChanged(object sender, EventArgs e)
        {

        }

        private void rad_bot_mx_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rad_bot_sx_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void combo_box_comune_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bot_CDF_Click(object sender, EventArgs e)
        {

        }
    }
}