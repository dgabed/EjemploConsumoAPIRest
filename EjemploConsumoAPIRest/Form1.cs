using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace EjemploConsumoAPIRest
{
    public partial class Form1 : Form
    {
        String ServicioRest;
        String URL;
        public Form1()
        {
            InitializeComponent();

            URL = "http://api.openweathermap.org/data/2.5/weather?id=6559994&appid=2535fbd1758d2ba73655d6b6dd5ad383";
            var json = new WebClient().DownloadString(URL);
           

        }
    }
}
