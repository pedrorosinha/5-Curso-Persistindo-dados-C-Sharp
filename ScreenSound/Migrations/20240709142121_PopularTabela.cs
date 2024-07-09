using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class PopularTabela : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Slipknot", "Slipknot é uma banda de metal americana formada em 1995 em Des Moines, Iowa, conhecida por suas apresentações enérgicas e uso de máscaras.", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Foo Fighters", "Foo Fighters é uma banda de rock alternativo americana formada por Dave Grohl em 1995.", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Metallica", "Metallica é uma banda de heavy metal americana formada em 1981 em Los Angeles, Califórnia, por James Hetfield e Lars Ulrich, conhecida por popularizar o thrash metal.", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "AC/DC", "AC/DC é uma banda de rock australiana formada em 1973 por Malcolm e Angus Young, conhecida por seu som de hard rock e apresentações eletrizantes.", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Guns N' Roses", "Guns N' Roses é uma banda de rock americana formada em 1985 em Los Angeles, Califórnia, por Axl Rose e Izzy Stradlin, famosa por seu estilo rebelde e sucessos como Sweet Child o' Mine.", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Queen", "Queen é uma banda de rock britânica formada em 1970 em Londres por Freddie Mercury, Brian May, Roger Taylor e John Deacon, conhecida por suas composições inovadoras e performances teatrais.", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png" });

            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Roque Abílio", "Recriando músicas famosas com uma reviravolta rockabilly, a Roque Abílio cativa o público com uma explosão autêntica do passado que ainda faz todo mundo dançar no presente.", "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Artistas");
        }
    }
}
