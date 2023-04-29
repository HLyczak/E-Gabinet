using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.Migrations
{
    public partial class addtables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Nurse",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PermissionNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nurse", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Nurse_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pesel = table.Column<long>(type: "bigint", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patient_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Room",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Number = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Room", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specialization",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specialization", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doctor",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SpecializationId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PermissionNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctor_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Doctor_Specialization_SpecializationId",
                        column: x => x.SpecializationId,
                        principalTable: "Specialization",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TimeSheet",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PatientId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    DoctorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoomId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeSheet", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimeSheet_Doctor_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "Doctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TimeSheet_Patient_PatientId",
                        column: x => x.PatientId,
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TimeSheet_Room_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Room",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "04d94d89-fe74-43ba-b052-90d5f3dea95f", "17d20a8c-e9ee-4b48-9d60-4bcc2d173810", "Writer", "WRITER" },
                    { "72f2ff00-761f-4727-b07c-5381992b5e0a", "1614ce87-2fdd-4a6e-bba4-eb0b7b520ea8", "Administrator", "ADMINISTRATOR" },
                    { "c1eeb9bd-5412-495a-8abf-a4157f1b546d", "3ae41ab9-20ad-4435-ab5c-5fec1d571ec9", "Reader", "READER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "00221f79-bc71-4186-9e5d-bfd57a80a43f", 0, "9c381246-2762-4d4c-ada6-258255990b86", "user5@op.pl", true, false, null, "USER5@OP.PL", "USER5@OP.PL", "AQAAAAEAACcQAAAAEO6CE6+bBwSGmitxNTeCqXlI91lhoGyNmnYo+tx6Cjc1PF+Oycq1Nhdnjh693kM8kQ==", null, false, "9d5c64cb-cd4b-4cc2-ab85-500f3176a4fb", false, "user5@op.pl" },
                    { "26dfb75e-5f31-4a54-9844-f019998a61d1", 0, "31f9a593-ca44-4c50-a89d-049c0d945509", "user2@op.pl", true, false, null, "USER2@OP.PL", "USER2@OP.PL", "AQAAAAEAACcQAAAAEG7DCQJp7lIQ0oLzIhoY12wcid0FRn8a31TiKBypasgVgaFYqGVvLe0W+purH45qKw==", null, false, "68c471b4-2940-402f-a6c7-2018cd176d9b", false, "user2@op.pl" },
                    { "32923230-6c8c-4510-b73e-d9bcf2484879", 0, "df4203ec-16f6-4a94-9ff2-435899424eb3", "user6@op.pl", true, false, null, "USER6@OP.PL", "USER6@OP.PL", "AQAAAAEAACcQAAAAEB1YXgBBRDvtxBC0ycZNjFIxTH7VQesMXrNBeQXtvtZLdcOwwkFvtWCl9vNlDGka6g==", null, false, "e2380a45-e1ab-4ab2-811f-aad5c6b95c55", false, "user6@op.pl" },
                    { "452db704-3650-457a-a7da-ca545a521776", 0, "f19e045f-b5a7-41a4-95ee-1aa17088780e", "user11@op.pl", true, false, null, "USER11@OP.PL", "USER11@OP.PL", "AQAAAAEAACcQAAAAEHgoj1yZ2yf86JFjAGddXPazj/a7BvcPb3KdLbDz9vF4/j0K+ju5WShpX3CYe+8bRw==", null, false, "bd8cee6c-e43d-4c11-8199-bbe179f2710c", false, "user11@op.pl" },
                    { "64791af4-436d-4419-b3e1-14641bdb2493", 0, "835b2652-5e42-4446-bb71-fe6408c098ca", "user3@op.pl", true, false, null, "USER3@OP.PL", "USER3@OP.PL", "AQAAAAEAACcQAAAAEN9qHbzZMnA4lnZ2YNIx3Mc2atPRU9bH3gnu6ENkhojqBReupp9IbZ4b3sVuQLZfcQ==", null, false, "801beca2-efce-45c3-90e4-3b47acaad1ac", false, "user3@op.pl" },
                    { "66126f74-f32b-435d-9e24-b3ed8b3d6011", 0, "4364b001-b418-4e71-81e9-a5dc24497a89", "user1@op.pl", true, false, null, "USER1@OP.PL", "USER1@OP.PL", "AQAAAAEAACcQAAAAEFNr+2wDA2EJ7Rf79wh0MqOz9RlaOh+oJfUbbL0bO/hHfxVU1yUcBRonsr0YyDcsSw==", null, false, "41ea6093-e789-4efc-afde-93f1cdbb6acd", false, "user1@op.pl" },
                    { "785a5776-fbba-4021-a263-4b9daade6ac8", 0, "86dda2be-212f-4837-be92-102d0755626b", "user10@op.pl", true, false, null, "USER10@OP.PL", "USER10@OP.PL", "AQAAAAEAACcQAAAAEC2/R3VepDDFSM5+7ZYcBAmciTwOLxrK7jSJefISNsA9cm3spDtvnXd4N/WhOJi0Ew==", null, false, "3e97e162-6004-4245-8601-3a54639e1a5c", false, "user10@op.pl" },
                    { "7fe50ba2-def6-4ac0-8b3e-87d3b4ce693f", 0, "4c2b9105-ed36-431e-84dc-6389cc7f94ff", "user12@op.pl", true, false, null, "USER12@OP.PL", "USER12@OP.PL", "AQAAAAEAACcQAAAAEAepMVtyrS74NysYm81778pvg+rI7kgvqlwLfxOvi7PsJ4tePnTO1PINswHivKVqSQ==", null, false, "bc9af265-3095-41f0-b846-f7b7f718744d", false, "user12@op.pl" },
                    { "c2ebef8b-eee6-4328-ba4d-f01a04fe4f83", 0, "3a8c4035-b9a9-498b-94ab-8a6df1ca4aec", "user8@op.pl", true, false, null, "USER8@OP.PL", "USER8@OP.PL", "AQAAAAEAACcQAAAAENbyyHtMS7QpbdSMYM2ebZVCwczWckoI0KBY4jLa9UD+mLkXoGf6I3V8d28wEE6FYg==", null, false, "ea8874e9-ddb6-49e7-8f38-9ed69d0aee99", false, "user8@op.pl" },
                    { "cef7f7aa-d198-4373-b441-926d8e52dbb1", 0, "8d8921eb-ba62-4c36-ab12-dbd64546a4fa", "user4@op.pl", true, false, null, "USER4@OP.PL", "USER4@OP.PL", "AQAAAAEAACcQAAAAEGEzLYUrsx/7TMaq+4Q/G6wW/B+7K4KfQwoik5CS1jmaPBO5b0mGoA+TvBS9VlywAg==", null, false, "33de4122-a2e4-4de7-9925-ea8e33a0b534", false, "user4@op.pl" },
                    { "ed216c2a-3e1c-486f-b8ca-5f13bd8baee8", 0, "4f935b2b-73fd-48ba-8cb8-58b7c6d5c84d", "user7@op.pl", true, false, null, "USER7@OP.PL", "USER7@OP.PL", "AQAAAAEAACcQAAAAEPBTGQEy6KraYKFz5fRo+2F3hGVyi55aDemPHFIXzA09wnfMBH3HX+hSpFKxc+dRow==", null, false, "c33239a7-c0e2-46c7-a700-6398626004fb", false, "user7@op.pl" },
                    { "ef9632fc-d406-412f-9b7a-09b902db6dfa", 0, "39166dae-f6ad-405c-80f9-1afdcf4077a3", "user9@op.pl", true, false, null, "USER9@OP.PL", "USER9@OP.PL", "AQAAAAEAACcQAAAAENNBb7rgNYbLHY84XpiLsj+EPr81bsaXA3Ule9LxpQ2ImW1P3cY2GTOHhv9jdzHcdg==", null, false, "2af7d475-7d7c-455d-a36c-7268b43423c2", false, "user9@op.pl" }
                });

            migrationBuilder.InsertData(
                table: "Room",
                columns: new[] { "Id", "Number" },
                values: new object[,]
                {
                    { "4b4e2a8f-ab04-40ab-827d-3c7789208e4c", 2L },
                    { "525e8058-b3a1-4a9f-83e5-355848d1e6c5", 4L },
                    { "c5f12060-322b-42be-bba6-689e2e0c5721", 3L },
                    { "d36af7ac-73cb-459e-847f-0abea3581814", 1L }
                });

            migrationBuilder.InsertData(
                table: "Specialization",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { "4e8effeb-0a99-4038-9420-0c543a3a28ac", "Endokrynolog" },
                    { "690e47d4-996b-43b7-a23b-d9693cf5962c", "Stomatolog" },
                    { "6a3d526e-1fb6-4de7-bde5-e0754fc58aec", "Lekarz rodzinny" },
                    { "e86959d5-6eed-45f7-b5cb-6b8f68a4d085", "Laryngolog" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "72f2ff00-761f-4727-b07c-5381992b5e0a", "00221f79-bc71-4186-9e5d-bfd57a80a43f" },
                    { "c1eeb9bd-5412-495a-8abf-a4157f1b546d", "26dfb75e-5f31-4a54-9844-f019998a61d1" },
                    { "04d94d89-fe74-43ba-b052-90d5f3dea95f", "32923230-6c8c-4510-b73e-d9bcf2484879" },
                    { "04d94d89-fe74-43ba-b052-90d5f3dea95f", "452db704-3650-457a-a7da-ca545a521776" },
                    { "c1eeb9bd-5412-495a-8abf-a4157f1b546d", "64791af4-436d-4419-b3e1-14641bdb2493" },
                    { "04d94d89-fe74-43ba-b052-90d5f3dea95f", "66126f74-f32b-435d-9e24-b3ed8b3d6011" },
                    { "04d94d89-fe74-43ba-b052-90d5f3dea95f", "785a5776-fbba-4021-a263-4b9daade6ac8" },
                    { "04d94d89-fe74-43ba-b052-90d5f3dea95f", "7fe50ba2-def6-4ac0-8b3e-87d3b4ce693f" },
                    { "04d94d89-fe74-43ba-b052-90d5f3dea95f", "c2ebef8b-eee6-4328-ba4d-f01a04fe4f83" },
                    { "c1eeb9bd-5412-495a-8abf-a4157f1b546d", "cef7f7aa-d198-4373-b441-926d8e52dbb1" },
                    { "04d94d89-fe74-43ba-b052-90d5f3dea95f", "ed216c2a-3e1c-486f-b8ca-5f13bd8baee8" },
                    { "04d94d89-fe74-43ba-b052-90d5f3dea95f", "ef9632fc-d406-412f-9b7a-09b902db6dfa" }
                });

            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "Id", "Adress", "Name", "PermissionNumber", "SpecializationId", "Surname", "UserId" },
                values: new object[,]
                {
                    { "1769f6fc-fb40-44ed-bb10-70c0c13a97e3", " Zielona 5", "Zofia", " 560053", "4e8effeb-0a99-4038-9420-0c543a3a28ac", "Kowalski", "785a5776-fbba-4021-a263-4b9daade6ac8" },
                    { "3e01671b-18fc-4f8c-bfd8-fa12666a99b6", " Kolorowa 5", "Adam", " 569853", "6a3d526e-1fb6-4de7-bde5-e0754fc58aec", "Kowalski", "ef9632fc-d406-412f-9b7a-09b902db6dfa" },
                    { "519e3b1c-8357-470d-9643-9be49bd669a3", " Obozowa 8", "Grzegorz", " 560053", "690e47d4-996b-43b7-a23b-d9693cf5962c", "Lem", "7fe50ba2-def6-4ac0-8b3e-87d3b4ce693f" },
                    { "ba61c248-a31d-4c10-9e7c-9d8d32defeea", " Adama Mickiewicza 8", "Todor", " 160053", "e86959d5-6eed-45f7-b5cb-6b8f68a4d085", " Nowaki", "452db704-3650-457a-a7da-ca545a521776" }
                });

            migrationBuilder.InsertData(
                table: "Nurse",
                columns: new[] { "Id", "Address", "Name", "PermissionNumber", "Surname", "UserId" },
                values: new object[,]
                {
                    { "68041977-3f99-4e4f-ac71-0b03a3606750", " os. Kolorowe 8", "Anna ", " 169053", " Austen", "ed216c2a-3e1c-486f-b8ca-5f13bd8baee8" },
                    { "965e09d6-0ed5-4e7a-8950-e252b1ae5380", " Obozowa 14", "Glżbieta Lem", " 567053", " Lockman", "c2ebef8b-eee6-4328-ba4d-f01a04fe4f83" },
                    { "9ae453af-8db3-440c-b8d0-1c55299ce188", " Różana 5", "AZofia", " 509853", "Stanecka", "00221f79-bc71-4186-9e5d-bfd57a80a43f" },
                    { "e40f8b49-f885-48c0-bb64-21c0d0813e88", " Topografów 5", "Hanna", " 510053", " Oklejka", "32923230-6c8c-4510-b73e-d9bcf2484879" }
                });

            migrationBuilder.InsertData(
                table: "Patient",
                columns: new[] { "Id", "Address", "Name", "Pesel", "Surname", "UserId" },
                values: new object[,]
                {
                    { "23159457-b301-4839-932a-3fd939f8b6c4", " Ostoja 5", "Zofia", 78020607221L, "Stanecka", "26dfb75e-5f31-4a54-9844-f019998a61d1" },
                    { "816c62f5-2b08-4042-8008-07a46b920921", " Obozowa 15", "Grzegorz", 65011259884L, "Fus", "cef7f7aa-d198-4373-b441-926d8e52dbb1" },
                    { "9262b74c-f7b4-47ba-8fcf-087241096f34", " Magnoliowa 5", "Adam", 85011259884L, "Nowak", "66126f74-f32b-435d-9e24-b3ed8b3d6011" },
                    { "9de0d585-60a6-445c-910c-e26ccaf46274", " Żeromskiego 4", "Austen", 95011259884L, "Nowaki", "64791af4-436d-4419-b3e1-14641bdb2493" }
                });

            migrationBuilder.InsertData(
                table: "TimeSheet",
                columns: new[] { "Id", "Data", "DoctorId", "PatientId", "RoomId" },
                values: new object[,]
                {
                    { "06223eb9-588c-4b2d-a0ab-c3c5ad65ae78", new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "3e01671b-18fc-4f8c-bfd8-fa12666a99b6", "9262b74c-f7b4-47ba-8fcf-087241096f34", "d36af7ac-73cb-459e-847f-0abea3581814" },
                    { "56932a73-5813-4215-bc39-686b11a12afc", new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "1769f6fc-fb40-44ed-bb10-70c0c13a97e3", "23159457-b301-4839-932a-3fd939f8b6c4", "4b4e2a8f-ab04-40ab-827d-3c7789208e4c" },
                    { "64060098-a52b-4e91-b5b6-63d292cea083", new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "ba61c248-a31d-4c10-9e7c-9d8d32defeea", "9de0d585-60a6-445c-910c-e26ccaf46274", "c5f12060-322b-42be-bba6-689e2e0c5721" },
                    { "7fd77adc-02e5-444e-9b7e-feb2113ac22f", new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "519e3b1c-8357-470d-9643-9be49bd669a3", "816c62f5-2b08-4042-8008-07a46b920921", "525e8058-b3a1-4a9f-83e5-355848d1e6c5" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_SpecializationId",
                table: "Doctor",
                column: "SpecializationId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_UserId",
                table: "Doctor",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Nurse_UserId",
                table: "Nurse",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_UserId",
                table: "Patient",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeSheet_DoctorId",
                table: "TimeSheet",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeSheet_PatientId",
                table: "TimeSheet",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeSheet_RoomId",
                table: "TimeSheet",
                column: "RoomId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Nurse");

            migrationBuilder.DropTable(
                name: "TimeSheet");

            migrationBuilder.DropTable(
                name: "Doctor");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "Room");

            migrationBuilder.DropTable(
                name: "Specialization");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "72f2ff00-761f-4727-b07c-5381992b5e0a", "00221f79-bc71-4186-9e5d-bfd57a80a43f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c1eeb9bd-5412-495a-8abf-a4157f1b546d", "26dfb75e-5f31-4a54-9844-f019998a61d1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "04d94d89-fe74-43ba-b052-90d5f3dea95f", "32923230-6c8c-4510-b73e-d9bcf2484879" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "04d94d89-fe74-43ba-b052-90d5f3dea95f", "452db704-3650-457a-a7da-ca545a521776" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c1eeb9bd-5412-495a-8abf-a4157f1b546d", "64791af4-436d-4419-b3e1-14641bdb2493" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "04d94d89-fe74-43ba-b052-90d5f3dea95f", "66126f74-f32b-435d-9e24-b3ed8b3d6011" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "04d94d89-fe74-43ba-b052-90d5f3dea95f", "785a5776-fbba-4021-a263-4b9daade6ac8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "04d94d89-fe74-43ba-b052-90d5f3dea95f", "7fe50ba2-def6-4ac0-8b3e-87d3b4ce693f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "04d94d89-fe74-43ba-b052-90d5f3dea95f", "c2ebef8b-eee6-4328-ba4d-f01a04fe4f83" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c1eeb9bd-5412-495a-8abf-a4157f1b546d", "cef7f7aa-d198-4373-b441-926d8e52dbb1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "04d94d89-fe74-43ba-b052-90d5f3dea95f", "ed216c2a-3e1c-486f-b8ca-5f13bd8baee8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "04d94d89-fe74-43ba-b052-90d5f3dea95f", "ef9632fc-d406-412f-9b7a-09b902db6dfa" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04d94d89-fe74-43ba-b052-90d5f3dea95f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72f2ff00-761f-4727-b07c-5381992b5e0a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1eeb9bd-5412-495a-8abf-a4157f1b546d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00221f79-bc71-4186-9e5d-bfd57a80a43f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32923230-6c8c-4510-b73e-d9bcf2484879");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2ebef8b-eee6-4328-ba4d-f01a04fe4f83");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed216c2a-3e1c-486f-b8ca-5f13bd8baee8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26dfb75e-5f31-4a54-9844-f019998a61d1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "452db704-3650-457a-a7da-ca545a521776");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64791af4-436d-4419-b3e1-14641bdb2493");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66126f74-f32b-435d-9e24-b3ed8b3d6011");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "785a5776-fbba-4021-a263-4b9daade6ac8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fe50ba2-def6-4ac0-8b3e-87d3b4ce693f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cef7f7aa-d198-4373-b441-926d8e52dbb1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef9632fc-d406-412f-9b7a-09b902db6dfa");
        }
    }
}
