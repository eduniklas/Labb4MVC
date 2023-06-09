﻿// <auto-generated />
using System;
using BookLibrary.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookLibrary.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230527102944_FirstTable")]
    partial class FirstTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BookLibrary.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<string>("Author")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("Published")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("BookId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            Author = "George Orwell",
                            Description = "This is a dystopian novel set in a totalitarian society ruled by a party that exercises absolute control over its citizens. The story follows Winston Smith, a low-ranking member of the ruling party, as he becomes disillusioned with the oppressive regime and begins to rebel",
                            Published = new DateTime(1949, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "1984"
                        },
                        new
                        {
                            BookId = 2,
                            Author = "J.R.R. Tolkien",
                            Description = "Tolkien’s fantasy epic is one of the top must-read books out there. Set in Middle Earth – a world full of hobbits, elves, orcs, goblins, and wizards – The Lord of the Rings will take you on an unbelievable adventure",
                            Published = new DateTime(1954, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Lord of the Rings"
                        },
                        new
                        {
                            BookId = 3,
                            Author = "J.K. Rowling",
                            Description = "This global bestseller took the world by storm. So, if you haven’t read J.K. Rowling’s Harry Potter, now may be the time. Join Harry Potter and his schoolmates as this must-read book transports you deep into a world of magic and monsters",
                            Published = new DateTime(1997, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Harry Potter and the Philosopher’s Stone"
                        },
                        new
                        {
                            BookId = 4,
                            Author = "C.S. Lewis",
                            Description = "The Lion, The Witch, and the Wardrobe is undoubtedly one of the great books of all time. This renowned fantasy novel is set in Narnia, home to mythical beasts, talking animals, and warring kingdoms. The story follows a group of school children as they become entangled in this incredible world’s fate",
                            Published = new DateTime(1950, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Lion, the Witch, and the Wardrobe"
                        },
                        new
                        {
                            BookId = 5,
                            Author = "George Orwell",
                            Description = "Orwell tells a fairy tale of a revolution against tyranny that ends in even more unjust totalitarianism. The animals on the farm are rife with idealism and desire to create a world of justice, equality, and progress. However, the new regimen attempts to control every aspect of the animals’ lives",
                            Published = new DateTime(1945, 8, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Animal Farm"
                        },
                        new
                        {
                            BookId = 6,
                            Author = "Douglas Adams",
                            Description = "Arthur Dent sets off on a hilarious and fantastic adventure across the stars. He learns not to take the universe seriously as he meets all kinds of interesting characters.",
                            Published = new DateTime(1979, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "The Hitchhiker’s Guide to the Galaxy"
                        });
                });

            modelBuilder.Entity("BookLibrary.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("RegisteredDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            FirstName = "Vincent",
                            LastName = "Chase",
                            RegisteredDate = new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 2,
                            FirstName = "Eric",
                            LastName = "Murphy",
                            RegisteredDate = new DateTime(2022, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 3,
                            FirstName = "Johnny",
                            LastName = "Drama",
                            RegisteredDate = new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 4,
                            FirstName = "Turtle",
                            LastName = "Assante",
                            RegisteredDate = new DateTime(2022, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 5,
                            FirstName = "Ari",
                            LastName = "Gold",
                            RegisteredDate = new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("BookLibrary.Models.LoanList", b =>
                {
                    b.Property<int>("LoanListId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoanListId"));

                    b.Property<DateTime>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("FK_BookId")
                        .HasColumnType("int");

                    b.Property<int>("FK_CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("LoanDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Returned")
                        .HasColumnType("bit");

                    b.HasKey("LoanListId");

                    b.HasIndex("FK_BookId");

                    b.HasIndex("FK_CustomerId");

                    b.ToTable("Loans");
                });

            modelBuilder.Entity("BookLibrary.Models.LoanList", b =>
                {
                    b.HasOne("BookLibrary.Models.Book", "Books")
                        .WithMany("Loans")
                        .HasForeignKey("FK_BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookLibrary.Models.Customer", "Customers")
                        .WithMany("Loans")
                        .HasForeignKey("FK_CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Books");

                    b.Navigation("Customers");
                });

            modelBuilder.Entity("BookLibrary.Models.Book", b =>
                {
                    b.Navigation("Loans");
                });

            modelBuilder.Entity("BookLibrary.Models.Customer", b =>
                {
                    b.Navigation("Loans");
                });
#pragma warning restore 612, 618
        }
    }
}
