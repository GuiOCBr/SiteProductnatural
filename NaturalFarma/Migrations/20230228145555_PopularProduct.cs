using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NaturalFarma.Migrations
{
    /// <inheritdoc />
    public partial class PopularProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Product(CategoryId, Name, ShortDescription, DetailedDescription, Price, ImageUrl, ImageSmall, ProductFavorite, Stock)" + "VALUES(2,'omega3','óleo de peixe','Esse nootrópico popular no mundo todo, auxilia no desenvolvimento cerebral, especialmente nas crianças, bem como na preservação da função cerebral normal em adultos.',50.00,'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSfYerBgYVBORxDQl0okNwy6hBOB3A35E2gyw&usqp=CAU','https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSfYerBgYVBORxDQl0okNwy6hBOB3A35E2gyw&usqp=CAU',1,1)");

            migrationBuilder.Sql("INSERT INTO Product(CategoryId, Name, ShortDescription, DetailedDescription, Price, ImageUrl, ImageSmall, ProductFavorite, Stock)" + "VALUES(2,'bacopa-monieri','pequena planta que cresce em regiões pantanosas por toda a Ásia','Essa planta é muito utilizada pela medicina ayurvédica e sua função principal é melhorar o desempenho cerebral, aumentando a capacidade de aprendizagem.',80.00,'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTZ5VoiS67bZJk44ikwKN-1Ew8vJxY38OeZzA&usqp=CAU','https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTZ5VoiS67bZJk44ikwKN-1Ew8vJxY38OeZzA&usqp=CAU',0,1)");

            migrationBuilder.Sql("INSERT INTO Product(CategoryId, Name, ShortDescription, DetailedDescription, Price, ImageUrl, ImageSmall, ProductFavorite, Stock)" + "VALUES(3,'Teanina','presente no chá-verde','Aminoácido encontrado nas folhas de chá verde que estimula a produção de serotonina, dopamina e GABA, neurotransmissores que influenciam diretamente no humor, memória e aprendizagem.',40.00,'https://unicpharma.vteximg.com.br/arquivos/ids/162841-1000-1000/L-teanina-200mg-60-caps.jpg?v=636990553154670000','https://unicpharma.vteximg.com.br/arquivos/ids/162841-1000-1000/L-teanina-200mg-60-caps.jpg?v=636990553154670000',0,1)");

            migrationBuilder.Sql("INSERT INTO Product(CategoryId, Name, ShortDescription, DetailedDescription, Price, ImageUrl, ImageSmall, ProductFavorite, Stock)" + "VALUES(2,'magnesio-treonato','mais novo suplemento','Suplemento capaz melhorar a função do Cérebro, contribuindo para o aumento das funções cognitivas como a memória, concentração e aprendizagem.',70.00,'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSZU_5MQ7uVxc8ZDF5pCHrHJsqCLkSIbFc7Sa9LgWNobnM8IFCd4aS6wRJwMlQFk2ygq_w&usqp=CAU','https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSZU_5MQ7uVxc8ZDF5pCHrHJsqCLkSIbFc7Sa9LgWNobnM8IFCd4aS6wRJwMlQFk2ygq_w&usqp=CAU',0,1)");

            migrationBuilder.Sql("INSERT INTO Product(CategoryId, Name, ShortDescription, DetailedDescription, Price, ImageUrl, ImageSmall, ProductFavorite, Stock)" + "VALUES(3,'CoezimaQ10',' melhorar a saúde do coração','Nutriente encontrado naturalmente nas células do corpo humano. Poderosa aliada na reparação celular e na produção de energia, ela também tem ação antioxidante.',30.00,'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR36gM3B-S7XnteuUiAgizL-kMi85u34qBX3xy-YygZ6XepW4jwaCOslPYCKbBvJL4Jv9E&usqp=CAU', 'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR36gM3B-S7XnteuUiAgizL-kMi85u34qBX3xy-YygZ6XepW4jwaCOslPYCKbBvJL4Jv9E&usqp=CAU'0,1)");
        }
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Product");
        }
    }
}
