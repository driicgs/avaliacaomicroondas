using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MicroOndasModel;

namespace TesteMicroOndasAdriane
{

    public partial class Form1 : Form
    {
        Programas prog = new Programas();
        ListaProgramasModel listprog = new ListaProgramasModel();
        public List<ListaProgramasModel> ListaProgramas = new List<ListaProgramasModel>();
 
        /**
         * Propriedades
         * 
         **/
        public int cont { get; set; }
        public string contagem { get; set; }
        public string caracter { get; set; }


        /**
         * Método de inicialização de programas pré definidos
         * 
         **/
        public void CarregaProgramas()
        {

            ListaProgramas.Add(new ListaProgramasModel
            {
                Nome = "MACARRAO",
                Instrucoes = "Atenção: Não colocar nenhum tipo de aluminio, pode causar acidentes." +
                "Para efetuar o aquecimento programado do Macarrão, aperte o botão Inicializar",
                Tempo = "55",
                Potencia = "6",
                Caracter = "_-_"
            });

            ListaProgramas.Add(new ListaProgramasModel
            {
                Nome = "ARROZ",
                Instrucoes = "Atenção: Não colocar nenhum tipo de aluminio, pode causar acidentes." +
                "Para efetuar o aquecimento programado do Macarrão, aperte o botão Inicializar",
                Tempo = "45",
                Potencia = "5",
                Caracter = "!"
            });

            ListaProgramas.Add(new ListaProgramasModel
            {
                Nome = "PIPOCA",
                Instrucoes = "Atenção: Não colocar nenhum tipo de aluminio, pode causar acidentes." +
                    "Para efetuar o aquecimento programado da Pipoca, aperte o botão Inicializar",
                Tempo = "60",
                Potencia = "4",
                Caracter = "@"
            });
            ListaProgramas.Add(new ListaProgramasModel
            {
                Nome = "BATATA",
                Instrucoes = "Atenção: Não colocar nenhum tipo de aluminio, pode causar acidentes." +
                    "Para efetuar o aquecimento programado do Batata, aperte o botão Inicializar",
                Tempo = "25",
                Potencia = "3",
                Caracter = "O"
            });
            ListaProgramas.Add(new ListaProgramasModel
            {
                Nome = "PUDIM",
                Instrucoes = "Atenção: Não colocar nenhum tipo de aluminio, pode causar acidentes." +
                "Para efetuar o aquecimento programado do Pudim, aperte o botão Inicializar",
                Tempo = "120",
                Potencia = "10",
                Caracter = "<3"
            });
            return;
        }

        public Form1()
        {
            InitializeComponent();
            CarregaProgramas();


            for (int i = 0; i < ListaProgramas.Count; i++)
            {
                cblistaprogramas.Items.Add(ListaProgramas[i].Nome);
            }
            gpprogramas.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                
        }

        private void btniniciar_Click(object sender, EventArgs e)
        {
            txtdisplay.Text = "";
            Programas prog = new Programas();
            string ret;
            prog.tempo = int.Parse(txtempo.Text);
            prog.potencia = int.Parse(txtpotencia.Text);
            

            /**
             * verifica o retorno das validações, e exibe mensagem de erro
             * 
             **/
            ret = prog.validaPotencia();

            if(ret ==" ")
            { 
                ret = prog.validaTempo();
                if (ret == " ")
                    Aquecer(prog.potencia,prog.tempo);
                else
                    MessageBox.Show(ret);
            }
            else
                MessageBox.Show(ret);
         }

        private void btnrapido_Click(object sender, EventArgs e)
        {
            Programas prog = new Programas();
            prog.InicioRapido();
           Aquecer(prog.potencia,prog.tempo);
           
        }

/**
* 
* Métodos
* 
* 
 * **/

        /**
         * 
         * Método de aquecimento
         * onde é iniciado o aquecimento.
         * 
         **/
        public void Aquecer(int potencia, int tempo)
        {
            int i;
            for (i = 0; i <= potencia; i++)
            {
                txtdisplay.Text += this.caracter;
            }
            MessageBox.Show("Aquecido");
            txtdisplay.Text = "Aquecido";

            txtempo.Text = " ";
            txtnome.Text = "";
            txtinstrucoes.Text = "";
            txtprogtempo.Text = "";
            txtprogpotencia.Text = "";
            txtcaracter.Text = "";
            gpprogramas.Visible = false;
            txtpotencia.Text = " ";

        }


        private void cblistaprogramas_SelectedIndexChanged(object sender, EventArgs e)
        {
            gpprogramas.Visible = true;
            txtinstrucoes.Enabled = false;
            txtnome.Enabled = false;
            txtprogpotencia.Enabled = false;
            txtprogtempo.Enabled = false;
            txtcaracter.Enabled = false;
            btnsalvar.Visible = false;

            var selecionado = cblistaprogramas.SelectedItem;

            var ret = ListaProgramas.Find(x => x.Nome == selecionado);

            txtnome.Text = ret.Nome;
            txtinstrucoes.Text = ret.Instrucoes;
            txtprogpotencia.Text = ret.Potencia;
            txtprogtempo.Text = ret.Tempo;
            txtpotencia.Text = ret.Potencia;
            txtempo.Text = ret.Tempo;
            txtcaracter.Text = ret.Caracter;
            this.caracter = ret.Caracter;
        }

        private void btnpesquisa_Click(object sender, EventArgs e)
        {
            var programa = txtnomeprograma.Text;
            var ret = ListaProgramas.Find(x => x.Nome.ToUpper() == programa.ToUpper());
            if (ret == null)
                ret = ListaProgramas.Find(x => x.Instrucoes.ToUpper() == programa.ToUpper());
            if (ret == null)
                ret = ListaProgramas.Find(x => x.Tempo.ToUpper() == programa.ToUpper());
            if (ret == null) 
                ret = ListaProgramas.Find(x => x.Potencia.ToUpper() == programa.ToUpper());
            if (ret == null)
                MessageBox.Show("Este programa não existe!");
            else{
                txtpotencia.Text = ret.Potencia;
                txtempo.Text = ret.Tempo;
                caracter = ret.Caracter;
            }
            
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            gpprogramas.Visible = true;
            txtnome.Text = "";
            txtinstrucoes.Text = "";
            txtprogtempo.Text = "";
            txtprogpotencia.Text = "";
            txtcaracter.Text = "";
            txtpotencia.Text = "";
            txtempo.Text = "";
            txtinstrucoes.Enabled = true;
            txtnome.Enabled = true;
            txtprogpotencia.Enabled = true;
            txtprogtempo.Enabled = true;
            txtcaracter.Enabled = true;
            btnsalvar.Visible = true;

        }

        private void btnsalvar_Click(object sender, EventArgs e)
        {
            //verifica se nenhum dos campos estão vazios.
            if (txtnome.Text != "" | txtinstrucoes.Text != "" | txtcaracter.Text != "")
            {

             prog.potencia = int.Parse(txtprogpotencia.Text);
             var ret1 = prog.validaPotencia();

            prog.tempo = int.Parse(txtprogtempo.Text);
            var ret2 = prog.validaTempo();
                
            if (ret1 != " " | ret2 != " ")
            {
                MessageBox.Show(ret1);
                MessageBox.Show(ret2);
            }
            else{
                ListaProgramas.Add(new ListaProgramasModel
                {
                    Nome = txtnome.Text,
                    Instrucoes = txtinstrucoes.Text,
                    Tempo = prog.tempo.ToString(),
                    Potencia = prog.potencia.ToString(),
                    Caracter = txtcaracter.Text
                });

                cblistaprogramas.Items.Clear();
                for (int i = 0; i < ListaProgramas.Count; i++)
                {
                    cblistaprogramas.Items.Add(ListaProgramas[i].Nome);
                }

                txtnome.Text = "";
                txtinstrucoes.Text = "";
                txtprogtempo.Text = "";
                txtprogpotencia.Text = "";
                txtcaracter.Text = "";
                gpprogramas.Visible = false;
            }
            }
            else
                MessageBox.Show("Por favor preencher todos os campos.");
            
        }

        
    }
}
