using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Core.Migrations
{
    public partial class addColumnToTimesheet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Amount",
                table: "TimeSheet",
                type: "money",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "PaymentId",
                table: "TimeSheet",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04d94d89-fe74-43ba-b052-90d5f3dea95f",
                column: "ConcurrencyStamp",
                value: "211aa09d-41e4-44a3-a797-87019e245d5e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72f2ff00-761f-4727-b07c-5381992b5e0a",
                column: "ConcurrencyStamp",
                value: "50bff2c8-0cdd-4607-b993-63f43578192d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1eeb9bd-5412-495a-8abf-a4157f1b546d",
                column: "ConcurrencyStamp",
                value: "671dfeec-bbdf-4c82-9045-988a94174807");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00221f79-bc71-4186-9e5d-bfd57a80a43f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2818c3fc-d718-442f-8dfd-2824f6fd1f57", "AQAAAAEAACcQAAAAEGiFAgQCWFnJezeZl8QQTQytkI6KXQYfV87D0SpUe39TOHzFYOA/pXVXCoJx46llwQ==", "c4eb2233-7848-4eaa-8cd3-7b614d6d36bd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26dfb75e-5f31-4a54-9844-f019998a61d1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "acf857ce-42bd-4e7f-bcec-5ecdd14d54da", "AQAAAAEAACcQAAAAEJ+ulWBvBCeZZ+3aC9IikY2s5eW4nE3S7VIYj2HvUrkXq4+LB3kPfeRzoBGcuQ03qg==", "8b22fff2-f4c9-4b99-b0ce-b41c57af1af0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32923230-6c8c-4510-b73e-d9bcf2484879",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7a46a5b-7118-4867-816b-0ba7f5e8ba4f", "AQAAAAEAACcQAAAAEGRPSXvbz+UAD0MgPwrOBb2CXrA9h31f4+VjPxgmd6kv5wFFyN6P6JA4A1K1Q2AxGA==", "ab8c7785-a340-4c4e-826c-7af6c958f50b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "452db704-3650-457a-a7da-ca545a521776",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea25b1f7-d06e-415b-8294-1be5ec0c9f52", "AQAAAAEAACcQAAAAEGsKV6YM2gp0qBILTiKurl68wG/RwH1x+gI2AnoMS6GuIQ8IzJrQlThkTiUEKoosLA==", "86855b48-27f3-4dda-b445-d5334f94e016" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64791af4-436d-4419-b3e1-14641bdb2493",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6362a5f-eaa2-4b5d-95d8-3c43c0d95b8a", "AQAAAAEAACcQAAAAEBhezcipmSw53mtp74QjvRooh+WzXBXtKzCuklZF9TASPdkYasZzbnoyewCwkPDEGQ==", "81c69545-d2c9-4376-9caf-e3e3fbb1e2fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66126f74-f32b-435d-9e24-b3ed8b3d6011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c24b91ca-f6c2-4ad0-b22b-f0c8f5fdbff2", "AQAAAAEAACcQAAAAEDco95GocJKJQnWtl6uxaD/VPVw5TfQnagtJL5Zb36homrX5SJKgp2wNcpNNy1SG1w==", "0ab370c5-6890-4443-843d-06042bb72373" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "785a5776-fbba-4021-a263-4b9daade6ac8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eadcb9e5-fe90-42cf-b4da-2267db55dfcb", "AQAAAAEAACcQAAAAEH7PwKd8x0sFfTbFWVzlL0V9XaAmFVOp3VRbb5DVZXI66o3W6xSFtW34TK/ld4JNaw==", "e4c89a0f-92cc-47b5-8df7-8a6ff5ba7450" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fe50ba2-def6-4ac0-8b3e-87d3b4ce693f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b269c10-cdfa-42f2-a312-c8d72b5b2e58", "AQAAAAEAACcQAAAAEA6MWEGm+kwFwFsN9D4gKzAUMPOt+TXMW+bsuWThVyGvNMwyfKeTrG/tsALnsDP+7Q==", "9278726e-bad2-4340-80af-30725769a8cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2ebef8b-eee6-4328-ba4d-f01a04fe4f83",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8bc3bf91-6b1e-45e2-9831-a0b7b2877487", "AQAAAAEAACcQAAAAENe+gRNxRjPRV6RO8lcb7PHAw5z5gnynBMB7Zd0LJdlmD/VRcGtIqvhwJiaOXAeEQw==", "c47b8c9d-163c-44aa-bdcc-6a40e16aff5f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cef7f7aa-d198-4373-b441-926d8e52dbb1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14ba9cf0-709f-45f7-8f50-1f7b07b71a8f", "AQAAAAEAACcQAAAAEPmQL5zeQ7cjZpIorL2/qXQ9x5Jjn/l/ItLd5FtbqpPiXNdTIZJxd2IOLQ7FrVXFeQ==", "3be959ed-db65-4f62-a190-15ab0550a33e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed216c2a-3e1c-486f-b8ca-5f13bd8baee8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9d37c51b-6860-4c92-bfe6-97b3628d1392", "AQAAAAEAACcQAAAAEIfp77CEIaJP+yja9cF8X53mFhoZdcuio2O+YdoqMMUpvy+4GN5jbgGc9/cJy0yWpw==", "07508eb4-84bc-4dba-8a57-819226744d28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef9632fc-d406-412f-9b7a-09b902db6dfa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3c63d0e-9375-4480-99e6-95a9f6ef4f13", "AQAAAAEAACcQAAAAEFd1fmMwnkVwpe4GizokyEyJEmCC8wZTshJcwmHe2id2IM0BKn0vUsMJFLtIhG8pbg==", "c2b0ecbd-a7ea-4a7d-b3ff-184c5e5d5ec7" });

            migrationBuilder.UpdateData(
                table: "TimeSheet",
                keyColumn: "Id",
                keyValue: "06223eb9-588c-4b2d-a0ab-c3c5ad65ae78",
                column: "Amount",
                value: 25m);

            migrationBuilder.UpdateData(
                table: "TimeSheet",
                keyColumn: "Id",
                keyValue: "56932a73-5813-4215-bc39-686b11a12afc",
                column: "Amount",
                value: 25m);

            migrationBuilder.UpdateData(
                table: "TimeSheet",
                keyColumn: "Id",
                keyValue: "64060098-a52b-4e91-b5b6-63d292cea083",
                column: "Amount",
                value: 25m);

            migrationBuilder.UpdateData(
                table: "TimeSheet",
                keyColumn: "Id",
                keyValue: "7fd77adc-02e5-444e-9b7e-feb2113ac22f",
                column: "Amount",
                value: 25m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Amount",
                table: "TimeSheet");

            migrationBuilder.DropColumn(
                name: "PaymentId",
                table: "TimeSheet");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04d94d89-fe74-43ba-b052-90d5f3dea95f",
                column: "ConcurrencyStamp",
                value: "17d20a8c-e9ee-4b48-9d60-4bcc2d173810");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72f2ff00-761f-4727-b07c-5381992b5e0a",
                column: "ConcurrencyStamp",
                value: "1614ce87-2fdd-4a6e-bba4-eb0b7b520ea8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1eeb9bd-5412-495a-8abf-a4157f1b546d",
                column: "ConcurrencyStamp",
                value: "3ae41ab9-20ad-4435-ab5c-5fec1d571ec9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00221f79-bc71-4186-9e5d-bfd57a80a43f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c381246-2762-4d4c-ada6-258255990b86", "AQAAAAEAACcQAAAAEO6CE6+bBwSGmitxNTeCqXlI91lhoGyNmnYo+tx6Cjc1PF+Oycq1Nhdnjh693kM8kQ==", "9d5c64cb-cd4b-4cc2-ab85-500f3176a4fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26dfb75e-5f31-4a54-9844-f019998a61d1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31f9a593-ca44-4c50-a89d-049c0d945509", "AQAAAAEAACcQAAAAEG7DCQJp7lIQ0oLzIhoY12wcid0FRn8a31TiKBypasgVgaFYqGVvLe0W+purH45qKw==", "68c471b4-2940-402f-a6c7-2018cd176d9b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32923230-6c8c-4510-b73e-d9bcf2484879",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df4203ec-16f6-4a94-9ff2-435899424eb3", "AQAAAAEAACcQAAAAEB1YXgBBRDvtxBC0ycZNjFIxTH7VQesMXrNBeQXtvtZLdcOwwkFvtWCl9vNlDGka6g==", "e2380a45-e1ab-4ab2-811f-aad5c6b95c55" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "452db704-3650-457a-a7da-ca545a521776",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f19e045f-b5a7-41a4-95ee-1aa17088780e", "AQAAAAEAACcQAAAAEHgoj1yZ2yf86JFjAGddXPazj/a7BvcPb3KdLbDz9vF4/j0K+ju5WShpX3CYe+8bRw==", "bd8cee6c-e43d-4c11-8199-bbe179f2710c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64791af4-436d-4419-b3e1-14641bdb2493",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "835b2652-5e42-4446-bb71-fe6408c098ca", "AQAAAAEAACcQAAAAEN9qHbzZMnA4lnZ2YNIx3Mc2atPRU9bH3gnu6ENkhojqBReupp9IbZ4b3sVuQLZfcQ==", "801beca2-efce-45c3-90e4-3b47acaad1ac" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "66126f74-f32b-435d-9e24-b3ed8b3d6011",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4364b001-b418-4e71-81e9-a5dc24497a89", "AQAAAAEAACcQAAAAEFNr+2wDA2EJ7Rf79wh0MqOz9RlaOh+oJfUbbL0bO/hHfxVU1yUcBRonsr0YyDcsSw==", "41ea6093-e789-4efc-afde-93f1cdbb6acd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "785a5776-fbba-4021-a263-4b9daade6ac8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86dda2be-212f-4837-be92-102d0755626b", "AQAAAAEAACcQAAAAEC2/R3VepDDFSM5+7ZYcBAmciTwOLxrK7jSJefISNsA9cm3spDtvnXd4N/WhOJi0Ew==", "3e97e162-6004-4245-8601-3a54639e1a5c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7fe50ba2-def6-4ac0-8b3e-87d3b4ce693f",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c2b9105-ed36-431e-84dc-6389cc7f94ff", "AQAAAAEAACcQAAAAEAepMVtyrS74NysYm81778pvg+rI7kgvqlwLfxOvi7PsJ4tePnTO1PINswHivKVqSQ==", "bc9af265-3095-41f0-b846-f7b7f718744d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2ebef8b-eee6-4328-ba4d-f01a04fe4f83",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a8c4035-b9a9-498b-94ab-8a6df1ca4aec", "AQAAAAEAACcQAAAAENbyyHtMS7QpbdSMYM2ebZVCwczWckoI0KBY4jLa9UD+mLkXoGf6I3V8d28wEE6FYg==", "ea8874e9-ddb6-49e7-8f38-9ed69d0aee99" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cef7f7aa-d198-4373-b441-926d8e52dbb1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d8921eb-ba62-4c36-ab12-dbd64546a4fa", "AQAAAAEAACcQAAAAEGEzLYUrsx/7TMaq+4Q/G6wW/B+7K4KfQwoik5CS1jmaPBO5b0mGoA+TvBS9VlywAg==", "33de4122-a2e4-4de7-9925-ea8e33a0b534" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed216c2a-3e1c-486f-b8ca-5f13bd8baee8",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f935b2b-73fd-48ba-8cb8-58b7c6d5c84d", "AQAAAAEAACcQAAAAEPBTGQEy6KraYKFz5fRo+2F3hGVyi55aDemPHFIXzA09wnfMBH3HX+hSpFKxc+dRow==", "c33239a7-c0e2-46c7-a700-6398626004fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ef9632fc-d406-412f-9b7a-09b902db6dfa",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39166dae-f6ad-405c-80f9-1afdcf4077a3", "AQAAAAEAACcQAAAAENNBb7rgNYbLHY84XpiLsj+EPr81bsaXA3Ule9LxpQ2ImW1P3cY2GTOHhv9jdzHcdg==", "2af7d475-7d7c-455d-a36c-7268b43423c2" });
        }
    }
}
