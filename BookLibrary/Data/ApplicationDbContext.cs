using BookLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<LoanList> Loans { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    BookId = 1,
                    Title = "1984",
                    Description = "This is a dystopian novel set in a totalitarian society ruled by a party that exercises absolute control over its citizens. The story follows Winston Smith, a low-ranking member of the ruling party, as he becomes disillusioned with the oppressive regime and begins to rebel",
                    Author = "George Orwell",
                    Published = new DateTime(1949, 06, 08)
                },
                new Book
                {
                    BookId = 2,
                    Title = "The Lord of the Rings",
                    Description = "Tolkien’s fantasy epic is one of the top must-read books out there. Set in Middle Earth – a world full of hobbits, elves, orcs, goblins, and wizards – The Lord of the Rings will take you on an unbelievable adventure",
                    Author = "J.R.R. Tolkien",
                    Published = new DateTime(1954, 07, 29)
                },
                new Book
                {
                    BookId = 3,
                    Title = "Harry Potter and the Philosopher’s Stone",
                    Description = "This global bestseller took the world by storm. So, if you haven’t read J.K. Rowling’s Harry Potter, now may be the time. Join Harry Potter and his schoolmates as this must-read book transports you deep into a world of magic and monsters",
                    Author = "J.K. Rowling",
                    Published = new DateTime(1997, 06, 26)
                },
                new Book
                {
                    BookId = 4,
                    Title = "The Lion, the Witch, and the Wardrobe",
                    Description = "The Lion, The Witch, and the Wardrobe is undoubtedly one of the great books of all time. This renowned fantasy novel is set in Narnia, home to mythical beasts, talking animals, and warring kingdoms. The story follows a group of school children as they become entangled in this incredible world’s fate",
                    Author = "C.S. Lewis",
                    Published = new DateTime(1950, 09, 16)
                },
                new Book
                {
                    BookId = 5,
                    Title = "Animal Farm",
                    Description = "Orwell tells a fairy tale of a revolution against tyranny that ends in even more unjust totalitarianism. The animals on the farm are rife with idealism and desire to create a world of justice, equality, and progress. However, the new regimen attempts to control every aspect of the animals’ lives",
                    Author = "George Orwell",
                    Published = new DateTime(1945, 08, 17)
                },
                new Book
                {
                    BookId = 6,
                    Title = "The Hitchhiker’s Guide to the Galaxy",
                    Description = "Arthur Dent sets off on a hilarious and fantastic adventure across the stars. He learns not to take the universe seriously as he meets all kinds of interesting characters.",
                    Author = "Douglas Adams",
                    Published = new DateTime(1979, 09, 12)
                });

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = 1,
                    FirstName = "Vincent",
                    LastName = "Chase",
                    RegisteredDate = new DateTime(2022, 3, 15),
                },
                new Customer
                {
                    CustomerId = 2,
                    FirstName = "Eric",
                    LastName = "Murphy",
                    RegisteredDate = new DateTime(2022, 5, 27),
                },
                new Customer
                {
                    CustomerId = 3,
                    FirstName = "Johnny",
                    LastName = "Drama",
                    RegisteredDate = new DateTime(2022, 8, 10),
                },
                new Customer
                {
                    CustomerId = 4,
                    FirstName = "Turtle",
                    LastName = "Assante",
                    RegisteredDate = new DateTime(2022, 10, 2),
                },
                new Customer
                {
                    CustomerId = 5,
                    FirstName = "Ari",
                    LastName = "Gold",
                    RegisteredDate = new DateTime(2022, 12, 20),
                });
        }
    }
}
