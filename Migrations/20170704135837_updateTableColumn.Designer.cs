using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using MiniBlog2.Infrastructure;

namespace MiniBlog2.Migrations
{
    [DbContext(typeof(SimpleBlogContext))]
    [Migration("20170704135837_updateTableColumn")]
    partial class updateTableColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MiniBlog2.Entities.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ArticleContent");

                    b.Property<string>("ArticleTitle");

                    b.Property<int>("CategoryId");

                    b.Property<DateTime>("CreateDate");

                    b.HasKey("Id");

                    b.ToTable("Article");
                });

            modelBuilder.Entity("MiniBlog2.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName");

                    b.Property<bool>("IsActive");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("MiniBlog2.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<bool>("IsActive");

                    b.Property<string>("Password");

                    b.Property<byte[]>("Photo");

                    b.Property<DateTime>("RegisterDate");

                    b.Property<string>("Surname");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("MiniBlog2.Entities.UserArticle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Article");

                    b.Property<int?>("User");

                    b.HasKey("Id");

                    b.HasIndex("Article");

                    b.HasIndex("User");

                    b.ToTable("UserArticle");
                });

            modelBuilder.Entity("MiniBlog2.Entities.UserArticle", b =>
                {
                    b.HasOne("MiniBlog2.Entities.Article", "ArticleId")
                        .WithMany()
                        .HasForeignKey("Article");

                    b.HasOne("MiniBlog2.Entities.User", "UserId")
                        .WithMany()
                        .HasForeignKey("User");
                });
        }
    }
}
