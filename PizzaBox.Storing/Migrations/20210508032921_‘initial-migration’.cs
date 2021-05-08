using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace PizzaBox.Storing.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AStore",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Discriminator = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AStore", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "Crust",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Crust", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "Size",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Size", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CustomerEntityId = table.Column<long>(type: "bigint", nullable: false),
                    StoreEntityId = table.Column<long>(type: "bigint", nullable: false),
                    PizzaEntityId = table.Column<long>(type: "bigint", nullable: true),
                    TimeOfPurchase = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.EntityId);
                    table.ForeignKey(
                        name: "FK_Order_AStore_StoreEntityId",
                        column: x => x.StoreEntityId,
                        principalTable: "AStore",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_Customer_CustomerEntityId",
                        column: x => x.CustomerEntityId,
                        principalTable: "Customer",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "APizza",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CrustEntityId = table.Column<long>(type: "bigint", nullable: false),
                    SizeEntityId = table.Column<long>(type: "bigint", nullable: false),
                    Discriminator = table.Column<string>(type: "text", nullable: false),
                    OrderEntityId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_APizza", x => x.EntityId);
                    table.ForeignKey(
                        name: "FK_APizza_Crust_CrustEntityId",
                        column: x => x.CrustEntityId,
                        principalTable: "Crust",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_APizza_Order_OrderEntityId",
                        column: x => x.OrderEntityId,
                        principalTable: "Order",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_APizza_Size_SizeEntityId",
                        column: x => x.SizeEntityId,
                        principalTable: "Size",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Topping",
                columns: table => new
                {
                    EntityId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    APizzaEntityId = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<decimal>(type: "numeric", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topping", x => x.EntityId);
                    table.ForeignKey(
                        name: "FK_Topping_APizza_APizzaEntityId",
                        column: x => x.APizzaEntityId,
                        principalTable: "APizza",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_APizza_CrustEntityId",
                table: "APizza",
                column: "CrustEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_APizza_OrderEntityId",
                table: "APizza",
                column: "OrderEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_APizza_SizeEntityId",
                table: "APizza",
                column: "SizeEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerEntityId",
                table: "Order",
                column: "CustomerEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_PizzaEntityId",
                table: "Order",
                column: "PizzaEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_StoreEntityId",
                table: "Order",
                column: "StoreEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Topping_APizzaEntityId",
                table: "Topping",
                column: "APizzaEntityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_APizza_PizzaEntityId",
                table: "Order",
                column: "PizzaEntityId",
                principalTable: "APizza",
                principalColumn: "EntityId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_APizza_Crust_CrustEntityId",
                table: "APizza");

            migrationBuilder.DropForeignKey(
                name: "FK_APizza_Order_OrderEntityId",
                table: "APizza");

            migrationBuilder.DropTable(
                name: "Topping");

            migrationBuilder.DropTable(
                name: "Crust");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "APizza");

            migrationBuilder.DropTable(
                name: "AStore");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Size");
        }
    }
}
