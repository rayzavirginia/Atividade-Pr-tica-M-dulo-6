using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Destinos.Migrations
{
    /// <inheritdoc />
    public partial class sevenmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id",
                keyValue: 6,
                column: "destino_url",
                value: "https://uploads.metropoles.com/wp-content/uploads/2021/07/15133517/Gramado_Rio_Grande_do_Sul_RS.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id",
                keyValue: 6,
                column: "destino_url",
                value: "https://lh3.googleusercontent.com/proxy/rWcyPYjGYCSgc0cijgw7Sl4EKNWG3GbSvOEpbQfdM70AZf6A_DHLOiqjFh7SOVk0DWgqWt7IZPslgnd8x-AiTAUJvWHqLcbxr7KFzF9_mKleaYU8ia-H0at9hS0DYr2Hmqae10FwUlM5d2vd6rCL1T0ZEbG8EyAhCEIzD_tfQcfoRKDp87mVpO8u5a2d1A");
        }
    }
}
