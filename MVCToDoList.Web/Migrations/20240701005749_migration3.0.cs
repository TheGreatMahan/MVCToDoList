﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVCToDoList.Web.Migrations
{
    /// <inheritdoc />
    public partial class migration30 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DueDate",
                table: "TaskItems",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DueDate",
                table: "TaskItems");
        }
    }
}
