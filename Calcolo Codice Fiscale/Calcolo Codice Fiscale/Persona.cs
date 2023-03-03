using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcolo_Codice_Fiscale
{
    internal class Persona
    {
        public string Nome { get; set; }    
        public string Cognome { get; set; }    
        public string Comune { get; set; }  
        public DateTimePicker DataNascita { get; set; } 
        public string Sesso { get; set; }   

        public Persona (string nome, string cognome,string comune, DateTimePicker dataNascita,string sesso) 
        {
            Nome = nome;
            Cognome = cognome;  
            Comune = comune;    
            DataNascita = dataNascita;  
            Sesso = sesso;
        
        }   



    }
}
