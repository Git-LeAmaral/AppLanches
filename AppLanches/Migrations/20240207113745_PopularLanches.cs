using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppLanches.Migrations;

public partial class PopularLanches : Migration
{
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.Sql("INSERT INTO Lanches(CategoriaId, " +
                                "DescricaoCurta, DescricaoDetalhada, EmEstoque," +
                                "ImagemThumbnailUrl, ImagemUrl, IsLanchePreferido, Nome, Preco)" +
                                "VALUES(1, 'Pão Integral, Apresuntado, Queijo, Alface, Tomate', 'Um Delecioso lanche leve " +
                                "para comer a qualquer momento e ingredientes que vão te ajudar na sua dieta', 1,'https://i.pinimg.com/736x/45/f1/d9/45f1d9dc2b8da66345954d4f0c86db9c.jpg', " +
                                "'https://i.pinimg.com/736x/45/f1/d9/45f1d9dc2b8da66345954d4f0c86db9c.jpg', 0 , 'Lanche Natural', 15.00)");
    }

    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.Sql("DELERE FROM Lanches");
    }
}
