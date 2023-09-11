# Labb4MVC
Book Library

# About the task:

In this exercise, you will build an application that works with a book database for a library. An MVC application will be responsible for handling and delivering data from the database.

- [ ] Create a new project.
- [ ] You need a table to work with customers, and it should be the Customer model.
    - [ ] You should have at least four or more fields in the Customer class.
    - [ ] Format the columns in the models, for example, Customer.name can be marked as Required, StringLength, Min=16, and Max=50.
    - [ ] A Customer can borrow one or more books. A book can be borrowed by many Customers.
    - [ ] It should be possible to determine if a book has been returned regardless of the loan period.
    - [ ] You should build the tables using EF.
    - [ ] You can create sample data when creating the table.
- [ ] You should retrieve all Customers in the database.
- [ ] You should be able to retrieve a specific Customer, using their Id if necessary.
- [ ] We should be able to edit, create, and delete a Customer.
- [ ] We want to see all the books that a Customer has borrowed.

**Extra Challenge:** Make it possible for a *Customer* to borrow a book.
