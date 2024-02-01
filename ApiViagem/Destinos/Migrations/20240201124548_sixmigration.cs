using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Destinos.Migrations
{
    /// <inheritdoc />
    public partial class sixmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id",
                keyValue: 1,
                column: "destino_estado",
                value: "CE");

            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "destino_estado", "destino_nome", "destino_pais", "destino_valor", "destino_url" },
                values: new object[] { "MS", "Bonito", "Brasil", "R$ 599,00", "https://images.squarespace-cdn.com/content/v1/5ca69b78ebfc7fa935a56f7e/1654792443846-D6TF30JB7D8G1GYE6FN9/IMG_0808%2BRIO.jpg?format=2500w" });

            migrationBuilder.InsertData(
                table: "destinos",
                columns: new[] { "id", "destino_estado", "destino_nome", "destino_pais", "destino_valor", "destino_url" },
                values: new object[,]
                {
                    { 3, "MA", "Lençóis Maranhenses", "Brasil", "R$ 679,00", "https://portaledicase.com/wp-content/uploads/2023/11/lencois-maranhenses.jpg" },
                    { 4, "PA", "Alter do Chão", "Brasil", "R$ 899,00", "https://www.escolhaviajar.com/wp-content/uploads/2018/11/Praias-de-Alter-do-Ch%C3%A3o.jpg" },
                    { 5, "PE", "Fernando de Noronha", "Brasil", "R$ 1.200,00", "https://teatur.com.br/wp-content/uploads/2018/09/Noronha_1.jpg" },
                    { 6, "RS", "Gramado", "Brasil", "R$ 998,00", "https://lh3.googleusercontent.com/proxy/rWcyPYjGYCSgc0cijgw7Sl4EKNWG3GbSvOEpbQfdM70AZf6A_DHLOiqjFh7SOVk0DWgqWt7IZPslgnd8x-AiTAUJvWHqLcbxr7KFzF9_mKleaYU8ia-H0at9hS0DYr2Hmqae10FwUlM5d2vd6rCL1T0ZEbG8EyAhCEIzD_tfQcfoRKDp87mVpO8u5a2d1A" },
                    { 7, "Cusco", "Machu Picchu", "Perú", "R$ 559,00", "https://www.adventureclub.com.br/wp-content/uploads/2014/08/1-MachuPicchu-1.jpg" },
                    { 8, "RR", "Monte Roraima", "Venezuela", "R$ 799,00", "https://www.infoescola.com/wp-content/uploads/2012/12/monte-roraima_747945205.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "destinos",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "destinos",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "destinos",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "destinos",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "destinos",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "destinos",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id",
                keyValue: 1,
                column: "destino_estado",
                value: "Ceará");

            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id",
                keyValue: 2,
                columns: new[] { "destino_estado", "destino_nome", "destino_pais", "destino_valor", "destino_url" },
                values: new object[] { "----", "Cancún", "México", "R$ 2.000,00", "https://content.r9cdn.net/rimg/dimg/f2/b1/89e06bf7-city-34713-16ed2f2c7f1.jpg?width=1366&height=768&xhint=1735&yhint=2084&crop=true" });
        }
    }
}
