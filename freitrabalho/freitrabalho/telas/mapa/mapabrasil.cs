using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace freitrabalho.telas.mapa
{
    public partial class mapabrasil : Form
    {
        public mapabrasil()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        private void picclose_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void picclose_MouseEnter(object sender, EventArgs e)
        {
            picclose.BackColor = Color.Maroon;
        }

        private void picclose_MouseLeave(object sender, EventArgs e)
        {
            picclose.BackColor = Color.Teal;
        }

        private void picbarra_MouseMove(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void mapabrasil_MouseMove(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //sp
        private void label1_MouseEnter(object sender, EventArgs e)
        {
            lbltitulo.Text = "São Paulo";
            lblsinopse.Text = "São Paulo, centro financeiro do Brasil, está entre as cidades mais populosas do mundo, com diversas instituições culturais e uma rica tradição arquitetônica. Há prédios simbólicos como a catedral neogótica, o Edifício Martinelli, um arranha-céu inaugurado em 1929, e o Edifício Copan, com suas linhas curvas projetadas pelo arquiteto modernista Oscar Niemeyer. A igreja em estilo colonial do Pátio do Colégio marca o local onde os padres jesuítas fundaram a cidade em 1554.";
            lblcapital.Text = "São Paulo";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lbltitulo.Text = "São Paulo";
            lblsinopse.Text = "São Paulo, centro financeiro do Brasil, está entre as cidades mais populosas do mundo, com diversas instituições culturais e uma rica tradição arquitetônica. Há prédios simbólicos como a catedral neogótica, o Edifício Martinelli, um arranha-céu inaugurado em 1929, e o Edifício Copan, com suas linhas curvas projetadas pelo arquiteto modernista Oscar Niemeyer. A igreja em estilo colonial do Pátio do Colégio marca o local onde os padres jesuítas fundaram a cidade em 1554.";
            lblcapital.Text = "São Paulo";
        }
        //rj
        private void label4_Click(object sender, EventArgs e)
        {
            lbltitulo.Text = "Rio de Janeiro";
            lblsinopse.Text = "O Rio de Janeiro é uma grande cidade brasileira à beira-mar, famosa pelas praias de Copacabana e Ipanema, pela estátua de 38 metros de altura do Cristo Redentor, no topo do Corcovado, e pelo Pão de Açúcar, um pico de granito com teleféricos até seu cume. A cidade também é conhecida pelas grandes favelas. O empolgante Carnaval, com carros alegóricos, fantasias extravagantes e sambistas, é considerado o maior do mundo.";
            lblcapital.Text = "Rio de Janeiro";
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            lbltitulo.Text = "Rio de Janeiro";
            lblsinopse.Text = "O Rio de Janeiro é uma grande cidade brasileira à beira-mar, famosa pelas praias de Copacabana e Ipanema, pela estátua de 38 metros de altura do Cristo Redentor, no topo do Corcovado, e pelo Pão de Açúcar, um pico de granito com teleféricos até seu cume. A cidade também é conhecida pelas grandes favelas. O empolgante Carnaval, com carros alegóricos, fantasias extravagantes e sambistas, é considerado o maior do mundo.";
            lblcapital.Text = "Rio de Janeiro";
        }
        //mg
        private void label3_Click(object sender, EventArgs e)
        {
            lbltitulo.Text = "Minas Gerais";
            lblsinopse.Text = "Minas Gerais, um grande estado continental no sudeste do Brasil, é conhecido por cidades da era colonial que remetem à corrida do ouro no país no século 18. Entre elas estão São João del Rei, Tiradentes e Ouro Preto, a antiga capital, todas com ruas de paralelepípedo, mansões ornamentadas e igrejas barrocas decoradas pelo escultor Aleijadinho.O famoso trem a vapor Maria Fumaça liga Tiradentes a São João del Rei.";
            lblcapital.Text = "Belo Horizonte";
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            lbltitulo.Text = "Minas Gerais";
            lblsinopse.Text = "Minas Gerais, um grande estado continental no sudeste do Brasil, é conhecido por cidades da era colonial que remetem à corrida do ouro no país no século 18. Entre elas estão São João del Rei, Tiradentes e Ouro Preto, a antiga capital, todas com ruas de paralelepípedo, mansões ornamentadas e igrejas barrocas decoradas pelo escultor Aleijadinho.O famoso trem a vapor Maria Fumaça liga Tiradentes a São João del Rei.";
            lblcapital.Text = "Belo Horizonte";
        }
        //es
        private void label5_Click(object sender, EventArgs e)
        {
            lbltitulo.Text = "Espírito Santo";
            lblsinopse.Text = "O Espírito Santo, estado da região Sudeste do Brasil, é conhecido por suas praias tropicais e áreas naturais montanhosas preservadas. Fundada em 1551, Vitória, capital e cidade portuária, tem um pequeno centro da era colonial. Do outro lado da estreita baía de Vitória, fica Vila Velha, com a movimentada Praia da Costa e o Convento da Penha, construção do século XVI que fica no alto de um penhasco e oferece uma vista panorâmica";
            lblcapital.Text = "Vitória";
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            lbltitulo.Text = "Espírito Santo";
            lblsinopse.Text = "O Espírito Santo, estado da região Sudeste do Brasil, é conhecido por suas praias tropicais e áreas naturais montanhosas preservadas. Fundada em 1551, Vitória, capital e cidade portuária, tem um pequeno centro da era colonial. Do outro lado da estreita baía de Vitória, fica Vila Velha, com a movimentada Praia da Costa e o Convento da Penha, construção do século XVI que fica no alto de um penhasco e oferece uma vista panorâmica";
            lblcapital.Text = "Vitória";
        }

        private void label17_Click(object sender, EventArgs e)
        {
            lbltitulo.Text = "Paraná";
            lblsinopse.Text = "Paraná é um estado no sul do Brasil que alberga as Cataratas do Iguaçu, com centenas de cascatas que se estendem ao longo da fronteira com a Argentina. Em torno das cataratas encontra-se o Parque Nacional do Iguaçu, uma floresta subtropical com diversas espécies selvagens, enquanto no norte se encontra a enorme barragem de Itaipu. Centenas de quilómetros a este, perto das praias atlânticas de Guaratuba e do grande porto de Paranaguá, fica a frondosa capital do estado, Curitiba.";
            lblcapital.Text = "Curitiba";
        }
        //parana
        private void label17_MouseEnter(object sender, EventArgs e)
        {
            lbltitulo.Text = "Paraná";
            lblsinopse.Text = "Paraná é um estado no sul do Brasil que alberga as Cataratas do Iguaçu, com centenas de cascatas que se estendem ao longo da fronteira com a Argentina. Em torno das cataratas encontra-se o Parque Nacional do Iguaçu, uma floresta subtropical com diversas espécies selvagens, enquanto no norte se encontra a enorme barragem de Itaipu. Centenas de quilómetros a este, perto das praias atlânticas de Guaratuba e do grande porto de Paranaguá, fica a frondosa capital do estado, Curitiba.";
            lblcapital.Text = "Curitiba";
        }
        //sc
        private void label18_MouseEnter(object sender, EventArgs e)
        {
            lbltitulo.Text = "Santa Catarina";
            lblsinopse.Text = "Santa Catarina é um estado na região sul do Brasil. Com uma longa costa com o Atlântico e muitas ilhas, ela é conhecida por suas praias e montanhas. Florianópolis, a capital, tem um mercado público tradicional com bares, restaurantes e barracas de comida, além de um museu histórico instalado em um palácio do governo colonial do século 19. Florianópolis está basicamente na ilha de Santa Catarina, que conta com resorts de praia na extremidade norte.";
            lblcapital.Text = "Florianópolis";
        }

        private void label19_MouseEnter(object sender, EventArgs e)
        {
            lbltitulo.Text = "Rio Grande do Sul";
            lblsinopse.Text = "Rio Grande do Sul é o estado mais a sul do Brasil e faz fronteira com a Argentina e o Uruguai. A nordeste, a montanhosa Serra Gaúcha alberga a região vinícola do Vale dos Vinhedos e inclui cidades turísticas de estilo alemão como Gramado e Canela, famosas pelas paisagens naturais pitorescas. Porto Alegre, a capital, é um grande porto com estruturas clássicas como o Mercado Público e a Catedral Metropolitana, no centro histórico.";
            lblcapital.Text = "Porto Alegre";
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            lbltitulo.Text = "Mato Grosso do Sul";
            lblsinopse.Text = "Mato Grosso do Sul é uma das 27 unidades federativas do Brasil. Localiza-se no sul da Região Centro-Oeste. Limita-se com cinco estados brasileiros: Mato Grosso, Goiás e Minas Gerais, São Paulo e Paraná; e dois países sul-americanos: Paraguai e Bolívia.";
            lblcapital.Text = "Campo Grande";
        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            lbltitulo.Text = "Goiás";
            lblsinopse.Text = "Goiás, um estado no centro do Brasil, alberga a savana acidentada, cidades da era colonial e uma agricultura de grande escala. O Parque Nacional da Chapada dos Veadeiros é uma reserva de montanhas paisagísticas com trilhos, rios, desfiladeiros e quedas de água. Fundadas durante o século XVIII, as cidades do ciclo de ouro de Pirenópolis e Goiás Velho (antiga capital do estado) distinguem-se pela arquitetura colonial portuguesa e pelas vibrantes festas cristãs.";
            lblcapital.Text = "Goiânia";
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            lbltitulo.Text = "Distrito Federal";
            lblsinopse.Text = "O Distrito Federal situa-se nas montanhas centrais do Brasil e alberga a capital da nação, Brasília, cidade moderna e planeada para o efeito. A cidade tem edifícios futuristas concebidos pelo célebre arquiteto brasileiro, Oscar Niemeyer. Estes incluem a Catedral de Brasília, que é curva e tem telhados de vidro. O Palácio Itamaraty de Niemeyer é conhecido pelos arcos, o espelho de água e os jardins tropicais.";
            lblcapital.Text = "Brasília";
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            lbltitulo.Text = "Mato Grosso";
            lblsinopse.Text = "Mato Grosso, um grande estado no centro-oeste brasileiro, é coberto na maioria pela floresta tropical amazónica, as zonas húmidas e as planícies da savana. A capital, Cuiabá, é um centro de viagens que remonta à corrida ao ouro do século XVIII. Nas proximidades, o Parque Nacional da Chapada dos Guimarães possui áreas de caminhada com penhascos em arenito, quedas de água e cavernas. As extensas zonas húmidas do Pantanal albergam diversas espécies selvagens, incluindo araras, caimões e jaguares.";
            lblcapital.Text = "Cuiabá";
        }
    }
}
