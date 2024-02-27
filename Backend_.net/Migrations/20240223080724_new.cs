using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace VehicleConfigurator.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "alternate_component_master",
                columns: table => new
                {
                    altid = table.Column<int>(name: "alt_id", type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    altcompid = table.Column<int>(name: "alt_comp_id", type: "int", nullable: false),
                    compid = table.Column<int>(name: "comp_id", type: "int", nullable: false),
                    deltaprice = table.Column<double>(name: "delta_price", type: "double", nullable: false),
                    mdlid = table.Column<int>(name: "mdl_id", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.altid);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "component_master",
                columns: table => new
                {
                    compid = table.Column<int>(name: "comp_id", type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    compname = table.Column<string>(name: "comp_name", type: "varchar(255)", maxLength: 255, nullable: true),
                    subtype = table.Column<string>(name: "sub_type", type: "varchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.compid);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "invoice",
                columns: table => new
                {
                    invid = table.Column<int>(name: "inv_id", type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    date = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    mdlid = table.Column<int>(name: "mdl_id", type: "int", nullable: false),
                    quantity = table.Column<int>(type: "int", nullable: false),
                    totalprice = table.Column<int>(name: "total_price", type: "int", nullable: false),
                    username = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.invid);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "segment_master",
                columns: table => new
                {
                    segid = table.Column<int>(name: "seg_id", type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    segname = table.Column<string>(name: "seg_name", type: "varchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.segid);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "user",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    address = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    authcell = table.Column<string>(name: "auth_cell", type: "varchar(255)", maxLength: 255, nullable: true),
                    authtel = table.Column<string>(name: "auth_tel", type: "varchar(255)", maxLength: 255, nullable: true),
                    compname = table.Column<string>(name: "comp_name", type: "varchar(255)", maxLength: 255, nullable: true),
                    compstno = table.Column<string>(name: "comp_st_no", type: "varchar(255)", maxLength: 255, nullable: true),
                    designation = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    emailid = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    holding = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    nameauthperson = table.Column<string>(name: "name_auth_person", type: "varchar(255)", maxLength: 255, nullable: true),
                    pan = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    password = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    telephone = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    username = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: true),
                    vatno = table.Column<string>(name: "vat_no", type: "varchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "mfg_master",
                columns: table => new
                {
                    mfgid = table.Column<int>(name: "mfg_id", type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    mfgname = table.Column<string>(name: "mfg_name", type: "varchar(255)", maxLength: 255, nullable: true),
                    segid = table.Column<int>(name: "seg_id", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.mfgid);
                    table.ForeignKey(
                        name: "FKok5qd64lq1asv75hpfgpwhdyq",
                        column: x => x.segid,
                        principalTable: "segment_master",
                        principalColumn: "seg_id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "model_master",
                columns: table => new
                {
                    mdlid = table.Column<int>(name: "mdl_id", type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    imagepath = table.Column<string>(name: "image_path", type: "varchar(255)", maxLength: 255, nullable: true),
                    mdlname = table.Column<string>(name: "mdl_name", type: "varchar(255)", maxLength: 255, nullable: true),
                    price = table.Column<double>(type: "double", nullable: false),
                    mfgid = table.Column<int>(name: "mfg_id", type: "int", nullable: true),
                    segid = table.Column<int>(name: "seg_id", type: "int", nullable: true),
                    quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.mdlid);
                    table.ForeignKey(
                        name: "FKacbx0rmpiqwgiisi06lsfcw6f",
                        column: x => x.mfgid,
                        principalTable: "mfg_master",
                        principalColumn: "mfg_id");
                    table.ForeignKey(
                        name: "FKtpmev85psi1n73w058nmykixb",
                        column: x => x.segid,
                        principalTable: "segment_master",
                        principalColumn: "seg_id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "vehicle_detail",
                columns: table => new
                {
                    confiid = table.Column<int>(name: "confi_id", type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    comptype = table.Column<string>(name: "comp_type", type: "varchar(255)", maxLength: 255, nullable: true),
                    isconfigurable = table.Column<string>(name: "is_configurable", type: "varchar(255)", maxLength: 255, nullable: true),
                    compid = table.Column<int>(name: "comp_id", type: "int", nullable: true),
                    mdlid = table.Column<int>(name: "mdl_id", type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.confiid);
                    table.ForeignKey(
                        name: "FK7ef69m6cku8vfvvmxuvu4nys3",
                        column: x => x.mdlid,
                        principalTable: "model_master",
                        principalColumn: "mdl_id");
                    table.ForeignKey(
                        name: "FKhih0q8yg3skwicdw9e0kigiti",
                        column: x => x.compid,
                        principalTable: "component_master",
                        principalColumn: "comp_id");
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "FKok5qd64lq1asv75hpfgpwhdyq",
                table: "mfg_master",
                column: "seg_id");

            migrationBuilder.CreateIndex(
                name: "FKacbx0rmpiqwgiisi06lsfcw6f",
                table: "model_master",
                column: "mfg_id");

            migrationBuilder.CreateIndex(
                name: "FKtpmev85psi1n73w058nmykixb",
                table: "model_master",
                column: "seg_id");

            migrationBuilder.CreateIndex(
                name: "FK7ef69m6cku8vfvvmxuvu4nys3",
                table: "vehicle_detail",
                column: "mdl_id");

            migrationBuilder.CreateIndex(
                name: "FKhih0q8yg3skwicdw9e0kigiti",
                table: "vehicle_detail",
                column: "comp_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "alternate_component_master");

            migrationBuilder.DropTable(
                name: "invoice");

            migrationBuilder.DropTable(
                name: "user");

            migrationBuilder.DropTable(
                name: "vehicle_detail");

            migrationBuilder.DropTable(
                name: "model_master");

            migrationBuilder.DropTable(
                name: "component_master");

            migrationBuilder.DropTable(
                name: "mfg_master");

            migrationBuilder.DropTable(
                name: "segment_master");
        }
    }
}
