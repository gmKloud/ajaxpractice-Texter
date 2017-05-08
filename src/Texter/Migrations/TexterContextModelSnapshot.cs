using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Texter.Models;

namespace Texter.Migrations
{
    [DbContext(typeof(TexterContext))]
    partial class TexterContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Texter.Models.Contact", b =>
                {
                    b.Property<string>("Name");

                    b.Property<string>("Number");

                    b.HasKey("Name");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Texter.Models.Message", b =>
                {
                    b.Property<string>("To");

                    b.Property<string>("Body");

                    b.Property<string>("ContactName");

                    b.Property<string>("From");

                    b.Property<string>("Status");

                    b.HasKey("To");

                    b.HasIndex("ContactName");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Texter.Models.Message", b =>
                {
                    b.HasOne("Texter.Models.Contact", "Contact")
                        .WithMany("Messages")
                        .HasForeignKey("ContactName");
                });
        }
    }
}
