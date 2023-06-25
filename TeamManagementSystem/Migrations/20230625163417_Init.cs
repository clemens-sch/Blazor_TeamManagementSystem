using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TeamManagementSystem.Migrations
{
	/// <inheritdoc />
	public partial class Init : Migration
	{
		/// <inheritdoc />
		protected override void Up(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.CreateTable(
				name: "Team",
				columns: table => new
				{
					TeamId = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					TeamName = table.Column<string>(type: "nvarchar(max)", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Team", x => x.TeamId);
				});

			migrationBuilder.CreateTable(
				name: "Player",
				columns: table => new
				{
					PlayerId = table.Column<int>(type: "int", nullable: false)
						.Annotation("SqlServer:Identity", "1, 1"),
					FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
					LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
					EPosition = table.Column<string>(type: "nvarchar(max)", nullable: false),
					TeamId = table.Column<int>(type: "int", nullable: false)
				},
				constraints: table =>
				{
					table.PrimaryKey("PK_Player", x => x.PlayerId);
					table.ForeignKey(
						name: "FK_Player_Team_TeamId",
						column: x => x.TeamId,
						principalTable: "Team",
						principalColumn: "TeamId",
						onDelete: ReferentialAction.Cascade);
				});

			migrationBuilder.CreateIndex(
				name: "IX_Player_TeamId",
				table: "Player",
				column: "TeamId");
		}

		/// <inheritdoc />
		protected override void Down(MigrationBuilder migrationBuilder)
		{
			migrationBuilder.DropTable(
				name: "Player");

			migrationBuilder.DropTable(
				name: "Team");
		}
	}
}
