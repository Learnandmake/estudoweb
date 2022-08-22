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

namespace freitrabalho2._0.telas.mapa
{
    public partial class mapa : Form
    {
        public mapa()
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
        private void picbarra_MouseMove_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            lbltitulo.Text = "Rondônia";
            lblsinopse.Text = "Rondônia é um estado na região oeste do Brasil, na fronteira boliviana, conhecida pelas vastas extensões de floresta amazónica. No centro, fica o montanhoso Parque Nacional de Pacaás Novos. A oeste, as áreas florestais adicionais estão protegidas pelo Parque Nacional da Serra da Cutia e o Parque Estadual Guajará-Mirim. A norte, a capital do estado, Porto Velho, situa-se nas margens do rio Madeira.";
            lblcapital.Text = "Porto Velho";
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            lbltitulo.Text = "Amazonas";
            lblsinopse.Text = "Amazonas é um enorme estado no noroeste do Brasil, coberto quase na sua totalidade pela floresta tropical da Amazónia. A capital, Manaus, é um porto fluvial com pontos de referência que datam do ciclo da borracha de finais do século XIX, incluindo o Teatro Amazonas, uma grande casa de ópera. A cidade marca o Encontro das Águas, onde o rio Negro, de água negra, e o rio Solimões se juntam para formar o rio Amazonas.";
            lblcapital.Text = "Manaus";
        }

        private void label14_MouseEnter(object sender, EventArgs e)
        {
            lbltitulo.Text = "Acre";
            lblsinopse.Text = "Acre é um estado no noroeste do Brasil, na Floresta Amazónica. É conhecido pela quantidade de árvores-da-borracha e castanhas-do-brasil. Na fronteira peruana, a oeste, o Parque Nacional da Serra do Divisor possui montanhas elevadas e várias quedas de água, além de diversas espécies animais, como tatus-gigantes, tapires e aves raras. A sudeste, encontra-se Rio Branco, a capital do estado, nas margens do rio Acre.";
            lblcapital.Text = "Rio Branco";
        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
            lbltitulo.Text = "Pará";
            lblsinopse.Text = "Pará, um estado no norte do Brasil, é onde se encontra o Parque Nacional da Amazônia. Protegendo uma extensa faixa da exuberante e densa Floresta Amazônica, o parque é lar de milhares de espécies da vida selvagem. Boa parte dela é alagada todos os anos, tornando o acesso a áreas distantes somente por barco. Próxima da desembocadura do Rio Amazonas está Belém, a capital do Pará. Ela é conhecida pela arquitetura colonial e pelo mercado Ver-o-Peso às margens do rio.";
            lblcapital.Text = "Belém";
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            lbltitulo.Text = "Amapá";
            lblsinopse.Text = "Amapá é um estado no norte do Brasil que faz fronteira com o Suriname, a Guiana Francesa e o Oceano Atlântico. A floresta amazónica abrange uma grande parte da sua área e o rio Oiapoque faz parte da sua fronteira a norte. No sul, a capital, Macapá, é conhecida pela Fortaleza de São José de Macapá, situada à beira-mar, um forte português do século XVIII, e pelo Monumento do Marco Zero, um obelisco que marca o equador.";
            lblcapital.Text = "Macapá";
        }

        private void label15_MouseEnter(object sender, EventArgs e)
        {
            lbltitulo.Text = "Roraima";
            lblsinopse.Text = "Roraima, o estado mais a norte do Brasil, é conhecido pela Floresta Amazónica. A capital, Boa Vista, na margem oeste de Rio Branco, fica próxima dos parques nacionais da Serra da Mocidade, a sudoeste, e do Monte Roraima, a norte. Com penhascos íngremes e um misterioso cume plano, o Monte Roraima, partilhado com a Venezuela e a Guiana, foi, presumivelmente, a inspiração de Sir Arthur Conan Doyle para O Mundo Perdido";
            lblcapital.Text = "Macapá";
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            lbltitulo.Text = "Tocantins";
            lblsinopse.Text = "Tocantins é um estado no centro do Brasil. Caracteriza-se pelo cerrado (prado seco e matagais), rios vastos e plantações de soja. A capital moderna, Palmas, foi construída propositadamente no centro geográfico do estado e está rodeada de colinas arborizadas. Ligeiramente a sudeste de Palmas, Taquaruçu do Porto é um destino de ecoturismo conhecido pelos trilhos de caminhada e pelas quedas de água.";
            lblcapital.Text = "Palmas";
        }

        private void label16_MouseEnter(object sender, EventArgs e)
        {
            lbltitulo.Text = "Bahia";
            lblsinopse.Text = "A Bahia é um estado do nordeste brasileiro com paisagens que variam da costa tropical até a aridez do Sertão. A capital, Salvador, é conhecida por seu centro histórico, o Pelourinho, com uma rica arquitetura colonial do século XVII e assentado sobre a Baía de Todos-os-Santos. O Carnaval da cidade reúne foliões fantasiados que dançam ao som do samba e do axé em uma enorme festa de rua.";
            lblcapital.Text = "Salvador";
        }

        private void label22_MouseEnter(object sender, EventArgs e)
        {
            lbltitulo.Text = "Maranhão";
            lblsinopse.Text = "Maranhão, estado no nordeste brasileiro, é formado em parte pela Floresta Amazônica e pelas praias ao longo do Oceano Atlântico. Próximo à cidade de Barreirinhas, grandes dunas de areia branca criam paisagens que lembram um deserto no Parque Nacional Lençóis Maranhenses, onde lagoas de água fresca nas quais se pode nadar se formam durante a temporada de chuvas. É na capital, São Luís, que se encontra o agitado bairro histórico conhecido como Reviver.";
            lblcapital.Text = "São Luís";
        }



        private void label20_MouseEnter(object sender, EventArgs e)
        {
            lbltitulo.Text = "Piauí";
            lblsinopse.Text = "Piauí é um estado no nordeste do Brasil conhecido pelos parques nacionais. O Parque Nacional Serra da Capivara, no sudeste, possui sítios arqueológicos com pinturas rupestres pré-históricas. Nas proximidades, o Parque Nacional Serra das Confusões tem gigantescas formações rochosas e grandes áreas de caatinga (vegetação semiárida), onde vivem aves em risco de extinção. As mangueiras ladeiam as ruas da capital à beira-rio, Teresina.";
            lblcapital.Text = "Teresina";
        }

        private void label25_MouseEnter(object sender, EventArgs e)
        {
            lbltitulo.Text = "Ceará";
            lblsinopse.Text = "O Ceará, um estado do nordeste brasileiro, tem um interior montanhoso e um litoral atlântico com impressionantes falésias vermelhas. O balneário de Canoa Quebrada tem enormes dunas de areia rosadas e a Rua Dragão do Mar, muito movimentada e também conhecida como Broadway. A cidade isolada de Jericoacoara, cercada pelo Parque Nacional de Jericoacoara, repleto de dunas, é famosa por suas ruas de areia, pela prática de windsurfe e pelo pôr do sol incomum em tons de verde.";
            lblcapital.Text = "Fortaleza";
        }

        private void label26_MouseEnter(object sender, EventArgs e)
        {
            lbltitulo.Text = "Rio Grande do Norte";
            lblsinopse.Text = "Rio Grande do Norte é um estado na extremidade nordeste do Brasil. A capital, Natal, fica numa costa repleta de praias onde se encontra o Forte dos Reis Magos, em forma de estrela, um forte português do século XVI. Ponta Negra é uma praia enquadrada pela enorme duna, Morro do Careca, um símbolo da cidade. A sul, a Praia de Pipa é uma estância célebre pelo surf e pelos golfinhos.";
            lblcapital.Text = "Natal";
        }

        private void label27_MouseEnter(object sender, EventArgs e)
        {
            lbltitulo.Text = "Paraíba";
            lblsinopse.Text = "Paraíba, um estado no nordeste do Brasil, é conhecido pela linha da costa tropical e pela arquitetura colonial portuguesa. A capital, João Pessoa, possui praias como a Manaíra e Tambaú, além de locais de mergulho repletos de corais ao largo da costa. Junto ao rio Paraíba, o centro histórico da cidade possui casas coloridas e a igreja de São Francisco, com uma arquitetura barroca. A Ponta do Seixas, com o farol Cabo Branco nas proximidades, marca o ponto mais a leste das Américas";
            lblcapital.Text = "João Pessoa";
        }

        private void label21_MouseEnter(object sender, EventArgs e)
        {
            lbltitulo.Text = "Pernambuco";
            lblsinopse.Text = "Pernambuco é um estado no nordeste do Brasil, no Oceano Atlântico. A sua capital moderna, o Recife, inclui um porto, a cidade velha e a popular área balnear de Boa Viagem. Ao largo da costa, o arquipélago vulcânico de Fernando de Noronha possui uma linha costeira dentada, praias poucos urbanizadas e um parque marítimo. A sul do Recife, a praia de Porto de Galinhas, protegida por um recife, oferece piscinas naturais. A norte encontra-se Olinda, uma cidade colonial situada entre uma vegetação exuberante.";
            lblcapital.Text = "Recife";
        }

        private void label24_MouseEnter(object sender, EventArgs e)
        {
            lbltitulo.Text = "Alagoas";
            lblsinopse.Text = "Alagoas é um pequeno estado do nordeste brasileiro cujo litoral tropical é marcado por praias de areia branca repletas de palmeiras, lagoas cristalinas e recifes de corais. Em Maceió, sua capital, estão localizadas as famosas praias Pajuçara e Ponta Verde, com hotéis, bares e restaurantes. Os recifes de corais decoram o litoral ao norte de Maceió que, por isso, tem o apelido de Costa dos Corais.";
            lblcapital.Text = "Maceió";
        }

        private void label23_MouseEnter(object sender, EventArgs e)
        {
            lbltitulo.Text = "Sergipe";
            lblsinopse.Text = "Sergipe, o estado mais pequeno do Brasil, situa-se na costa atlântica da região do nordeste. A capital, Aracaju, é conhecida pelas praias, tal como a Praia da Atalaia, com o seu longo passeio. Fundada em 1590, a antiga capital, São Cristóvão, alberga edifícios da era colonial, incluindo o convento e a Igreja de São Francisco, do século XVII. O Cânion do Xingó, no rio de São Francisco, ladeia um popular lago para passeios de barco.";
            lblcapital.Text = "Aracaju";
        }

        private void picclose_Click_1(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void picclose_MouseEnter_1(object sender, EventArgs e)
        {
            picclose.BackColor = Color.Maroon;
        }

        private void picclose_MouseLeave_1(object sender, EventArgs e)
        {
            picclose.BackColor = Color.Teal;
        }
    }
}
