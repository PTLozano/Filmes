using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Filmes.Data.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TAB_FILME",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(maxLength: 150, nullable: false),
                    Sinopse = table.Column<string>(maxLength: 5000, nullable: true),
                    Classificacao = table.Column<int>(nullable: false),
                    DataLancamento = table.Column<DateTime>(type: "DATE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAB_FILME", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TAB_GENERO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAB_GENERO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TAB_USUARIO",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Login = table.Column<string>(maxLength: 150, nullable: false),
                    Hash = table.Column<string>(nullable: false),
                    Nome = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAB_USUARIO", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TAB_FILME_GENERO",
                columns: table => new
                {
                    FilmeId = table.Column<int>(nullable: false),
                    GeneroId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TAB_FILME_GENERO", x => new { x.FilmeId, x.GeneroId });
                    table.ForeignKey(
                        name: "FK_TAB_FILME_GENERO_TAB_FILME_FilmeId",
                        column: x => x.FilmeId,
                        principalTable: "TAB_FILME",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TAB_FILME_GENERO_TAB_GENERO_GeneroId",
                        column: x => x.GeneroId,
                        principalTable: "TAB_GENERO",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TAB_FILME_GENERO_FilmeId",
                table: "TAB_FILME_GENERO",
                column: "FilmeId");

            migrationBuilder.CreateIndex(
                name: "IX_TAB_FILME_GENERO_GeneroId",
                table: "TAB_FILME_GENERO",
                column: "GeneroId");

            migrationBuilder.Sql(@"USE [Filmes]
GO
SET IDENTITY_INSERT [dbo].[TAB_FILME] ON 
GO
INSERT [dbo].[TAB_FILME] ([Id], [Nome], [Sinopse], [Classificacao], [DataLancamento]) VALUES (1, N'Matrix', N'Em um futuro próximo, Thomas Anderson (Keanu Reeves), um jovem programador de computador que mora em um cubículo escuro, é atormentado por estranhos pesadelos nos quais encontra-se conectado por cabos e contra sua vontade, em um imenso sistema de computadores do futuro. Em todas essas ocasiões, acorda gritando no exato momento em que os eletrodos estão para penetrar em seu cérebro. À medida que o sonho se repete, Anderson começa a ter dúvidas sobre a realidade. Por meio do encontro com os misteriosos Morpheus (Laurence Fishburne) e Trinity (Carrie-Anne Moss), Thomas descobre que é, assim como outras pessoas, vítima do Matrix, um sistema inteligente e artificial que manipula a mente das pessoas, criando a ilusão de um mundo real enquanto usa os cérebros e corpos dos indivíduos para produzir energia. Morpheus, entretanto, está convencido de que Thomas é Neo, o aguardado messias capaz de enfrentar o Matrix e conduzir as pessoas de volta à realidade e à liberdade.', 14, '1999-05-21')
GO
INSERT [dbo].[TAB_FILME] ([Id], [Nome], [Sinopse], [Classificacao], [DataLancamento]) VALUES (2, N'Matrix Reloaded', N'Após derrotar as máquinas em seu combate inicial, Neo (Keanu Reeves) ainda vive na Nabuconodosor ao lado de Morpheus (Laurence Fishburne), Trinity (Carrie-Anne Moss) e Link (Harold Perrineau Jr.), o novo tripulante da nave. As máquinas estão realizando uma grande ofensiva contra Zion, onde 250 mil máquinas estão escavando rumo à cidade e podem alcançá-la em poucos dias. A Nabucodonosor é convocada para retornar a Zion, para participar da reunião que definirá o contra-ataque humano às máquinas. Entretanto, um recado enviado pelo Oráculo (Gloria Foster) faz com que a nave parta novamente, levando Neo de volta à matrix. Lá ele descobre que precisa encontrar o Chaveiro (Randall Duk Kim), um ser que possui a chave para todos os caminhos da matrix e que é mantido como prisioneiro por Merovingian (Lambert Wilson) e sua esposa, Persephone (Monica Bellucci).', 14,  '2003-05-16')
GO
INSERT [dbo].[TAB_FILME] ([Id], [Nome], [Sinopse], [Classificacao], [DataLancamento]) VALUES (3, N'Matrix Revolutions', N'Após enfrentar os sentinelas no mundo real, Neo (Keanu Reeves) tem sua mente presa em um local que fica entre a Matrix e a realidade, do qual apenas poderá sair com a ajuda de Trainman (Bruce Spence). Após perceberem que as ondas cerebrais de Neo são idênticas as de uma pessoa conectada à Matrix, Trinity (Carrie-Anne Moss) e Morpheus (Laurence Fishburne) buscam a ajuda da Oráculo (Mary Alice) e Seraph (Sing Ngai). Trinity, Morpheus e Seraph vão em busca de Merovingian (Lambert Wilson), que possui controle sobre Trainman e pode libertar Neo. Após obterem sucesso no resgate, o trio se divide em duas missões: enquanto Morpheus e a tripulação de duas naves parte rumo a Zion, na tentativa de ajudar no combate contra as máquinas, Neo e Trinity se dirigem à cidadela das máquinas.', 14,  '2003-11-05')
GO
INSERT [dbo].[TAB_FILME] ([Id], [Nome], [Sinopse], [Classificacao], [DataLancamento]) VALUES (4, N'O Poderoso Chefão', N'Don Vito Corleone (Marlon Brando) é o chefe de uma ""família"" de Nova York que está feliz, pois Connie (Talia Shire), sua filha, se casou com Carlo (Gianni Russo). Porém, durante a festa, Bonasera (Salvatore Corsitto) é visto no escritório de Don Corleone pedindo ""justiça"", vingança na verdade contra membros de uma quadrilha, que espancaram barbaramente sua filha por ela ter se recusado a fazer sexo para preservar a honra. Vito discute, mas os argumentos de Bonasera o sensibilizam e ele promete que os homens, que maltrataram a filha de Bonasera não serão mortos, pois ela também não foi, mas serão severamente castigados. Vito porém deixa claro que ele pode chamar Bonasera algum dia para devolver o ""favor"". Do lado de fora, no meio da festa, está o terceiro filho de Vito, Michael (Al Pacino), um capitão da marinha muito decorado que há pouco voltou da 2ª Guerra Mundial. Universitário educado, sensível e perceptivo, ele quase não é notado pela maioria dos presentes, com exceção de uma namorada da faculdade, Kay Adams (Diane Keaton), que não tem descendência italiana mas que ele ama. Em contrapartida há alguém que é bem notado, Johnny Fontane (Al Martino), um cantor de baladas românticas que provoca gritos entre as jovens que beiram a histeria. Don Corleone já o tinha ajudado, quando Johnny ainda estava em começo de carreira e estava preso por um contrato com o líder de uma grande banda, mas a carreira de Johnny deslanchou e ele queria fazer uma carreira solo. Por ser seu padrinho Vito foi procurar o líder da banda e ofereceu 10 mil dólares para deixar Johnny sair, mas teve o pedido recusado. Assim, no dia seguinte Vito voltou acompanhado por Luca Brasi (Lenny Montana), um capanga, e após uma hora ele assinou a liberação por apenas mil dólares, mas havia um detalhe: nas ""negociações"" Luca colocou uma arma na cabeça do líder da banda. Agora, no meio da alegria da festa, Johnny quer falar algo sério com Vito, pois precisa conseguir o principal papel em um filme para levantar sua carreira, mas o chefe do estúdio, Jack Woltz (John Marley), nem pensa em contratá-lo. Nervoso, Johnny começa a chorar e Vito, irritado, o esbofeteia, mas promete que ele conseguirá o almejado papel. Enquanto a festa continua acontecendo, Don Corleone comunica a Tom Hagen (Robert Duvall), seu filho adotivo que atua como conselheiro, que Carlo terá um emprego mas nada muito importante, e que os ""negócios"" não devem ser discutidos na sua frente. Os verdadeiros problemas começam para Vito quando Sollozzo (Al Lettieri), um gângster que tem apoio de uma família rival, encabeçada por Phillip Tattaglia (Victor Rendina) e seu filho Bruno (Tony Giorgio). Sollozzo, em uma reunião com Vito, Sonny e outros, conta para a família que ele pretende estabelecer um grande esquema de vendas de narcóticos em Nova York, mas exige permissão e proteção política de Vito para agir. Don Corleone odeia esta idéia, pois está satisfeito em operar com jogo, mulheres e proteção, mas isto será apenas a ponta do iceberg de uma mortal luta entre as ""famílias"".', 16,  '1972-07-07')
GO
INSERT [dbo].[TAB_FILME] ([Id], [Nome], [Sinopse], [Classificacao], [DataLancamento]) VALUES (5, N'O Poderoso Chefão Parte II', N'Início do século XX. Após a máfia local matar sua família, o jovem Vito (Robert De Niro) foge da sua cidade na Sicília e vai para a América. Já adulto em Little Italy, Vito luta para ganhar a vida (legal ou ilegalmente) e manter sua esposa e filhos. Ele mata Black Hand Fanucci (Gastone Moschin), que exigia dos comerciantes uma parte dos seus ganhos. Com a morte de Fanucci, o poderio de Vito cresce muito, mas sua família é o que mais importa para ele. Um legado de família que vai até os enormes negócios que nos anos 50 são controlados pelo caçula, Michael Corleone (Al Pacino). Agora baseado em Lago Tahoe, Michael planeja fazer incursões em Las Vegas e Havana instalando negócios ligados ao lazer, mas descobre que aliados como Hyman Roth (Lee Strasberg) estão tentando matá-lo. Crescentemente paranoico, Michael também descobre que sua ambição acabou com seu casamento com Kay (Diane Keaton) e até mesmo seu irmão Fredo (John Cazale) o traiu. Escapando de uma acusação federal, Michael concentra sua atenção para lidar com os seus inimigos.', 16,  '1975-02-14')
GO
INSERT [dbo].[TAB_FILME] ([Id], [Nome], [Sinopse], [Classificacao], [DataLancamento]) VALUES (6, N'O Poderoso Chefão Parte III', N'Nova York, 1979. A Ordem de San Sebastian, um dos maiores títulos dados pela Igreja, é dada para Michael Corleone (Al Pacino), após fazer uma doação à Igreja de US$ 100 milhões, em nome da fundação Vito Corleone, da qual Mary (Sophia Coppola), sua filha, é presidenta honorária. Michael está velho, doente e divorciado, mas faz atos de redenção para tornar aceitável o nome da família Corleone. Na comemoração pelo título recebido, após 8 anos de afastamento, Michael recebe ""Vinnie"" Mancini (Andy Garcia), seu sobrinho, que a pedido de Connie (Talia Shire) é apresentado a Michael manifestando vontade de trabalhar com o tio. Nesta tentativa de diálogo a conversa toma um rumo hostil, pois participava também da reunião Joey Zasa (Joe Mantegna), que agora mantém o domínio de uma área outrora mantida por Don Vito Corleone, o pai de Michael. Vinnie é chefiado por Zasa, mas fala que não quer continuar, principalmente pela traição de Zasa de não reconhecer o poder de Michael. Vinnie é quase morto pelos capangas de Zasa e uma guerra pelo poder tem início. Um arcebispo da Igreja solicita a Michael US$ 600 milhões, pois resolveria o déficit da Igreja, oferecendo em troca que Michael ganhe o controle majoritário da Immobiliare, antiga e respeitável empresa européia de propriedade da Igreja. Michael concorda, mas isto deixa vários membros do clero contrariados, que não o aceitam por sua vida duvidosa.', 16,  '1991-03-15')
GO
INSERT [dbo].[TAB_FILME] ([Id], [Nome], [Sinopse], [Classificacao], [DataLancamento]) VALUES (7, N'Shrek', N'Em um pântano distante vive Shrek (Mike Myers), um ogro solitário que vê, sem mais nem menos, sua vida ser invadida por uma série de personagens de contos de fada, como três ratos cegos, um grande e malvado lobo e ainda três porcos que não têm um lugar onde morar. Todos eles foram expulsos de seus lares pelo maligno Lorde Farquaad (John Lithgow). Determinado a recuperar a tranquilidade de antes, Shrek resolve encontrar Farquaad e com ele faz um acordo: todos os personagens poderão retornar aos seus lares se ele e seu amigo Burro (Eddie Murphy) resgatarem uma bela princesa (Cameron Diaz), que é prisioneira de um dragão. Porém, quando Shrek e o Burro enfim conseguem resgatar a princesa logo eles descobrem que seus problemas estão apenas começando.', 0,  '2001-06-22')
GO
SET IDENTITY_INSERT [dbo].[TAB_FILME] OFF
GO
SET IDENTITY_INSERT [dbo].[TAB_GENERO] ON 
GO
INSERT [dbo].[TAB_GENERO] ([Id], [Descricao]) VALUES (1, N'Ação')
GO
INSERT [dbo].[TAB_GENERO] ([Id], [Descricao]) VALUES (2, N'Ficção')
GO
INSERT [dbo].[TAB_GENERO] ([Id], [Descricao]) VALUES (3, N'Animação')
GO
INSERT [dbo].[TAB_GENERO] ([Id], [Descricao]) VALUES (4, N'Drama')
GO
SET IDENTITY_INSERT [dbo].[TAB_GENERO] OFF
GO
INSERT [dbo].[TAB_FILME_GENERO] ([FilmeId], [GeneroId]) VALUES (1, 1)
GO
INSERT [dbo].[TAB_FILME_GENERO] ([FilmeId], [GeneroId]) VALUES (2, 1)
GO
INSERT [dbo].[TAB_FILME_GENERO] ([FilmeId], [GeneroId]) VALUES (3, 1)
GO
INSERT [dbo].[TAB_FILME_GENERO] ([FilmeId], [GeneroId]) VALUES (4, 1)
GO
INSERT [dbo].[TAB_FILME_GENERO] ([FilmeId], [GeneroId]) VALUES (5, 1)
GO
INSERT [dbo].[TAB_FILME_GENERO] ([FilmeId], [GeneroId]) VALUES (6, 1)
GO
INSERT [dbo].[TAB_FILME_GENERO] ([FilmeId], [GeneroId]) VALUES (1, 2)
GO
INSERT [dbo].[TAB_FILME_GENERO] ([FilmeId], [GeneroId]) VALUES (2, 2)
GO
INSERT [dbo].[TAB_FILME_GENERO] ([FilmeId], [GeneroId]) VALUES (3, 2)
GO
INSERT [dbo].[TAB_FILME_GENERO] ([FilmeId], [GeneroId]) VALUES (7, 3)
GO
");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TAB_FILME_GENERO");

            migrationBuilder.DropTable(
                name: "TAB_USUARIO");

            migrationBuilder.DropTable(
                name: "TAB_FILME");

            migrationBuilder.DropTable(
                name: "TAB_GENERO");
        }
    }
}
