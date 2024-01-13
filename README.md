# Library Management System

## Overview

This project is a Library Management System designed to streamline the management of books and readers. It includes an authentication screen to access the library management system, where users are required to enter their login credentials.

## Application Interface

The main application window consists of several components:

### Authentication Screen

- The initial screen prompts users to enter their login credentials (username and password) for accessing the library management system.
  
![image_2024-01-13_21-50-45](https://github.com/BalginB/Library-Management/assets/121958042/0e6e810f-c2f9-472d-91fb-bae7a94f59c2)
### Main Window
![libraryGit](https://github.com/BalginB/Library-Management/assets/121958042/a230a2ce-ea3e-433d-a57b-068b1e60a31b)

- Upon successful authentication, users are presented with the main window, which includes the following components:

#### Reader Management

- **New Reader:** Allows users to add a new reader to the system. Opens a dialog to input the reader's information such as name, address, and age.
  
![readerGit](https://github.com/BalginB/Library-Management/assets/121958042/8a20d6d6-c51c-41e3-a2d7-454d338951d7)

- **Edit Reader:** Opens a dialog to modify details of an existing reader. Users can edit the reader's information.

- **Delete Reader:** Enables users to remove a selected reader from the system. A confirmation dialog is displayed before deletion.

#### Book Management

- **New Book:** Opens a dialog for adding a new book to the library. Users need to input information such as title, author, genre, and price.
  
![bookGit](https://github.com/BalginB/Library-Management/assets/121958042/7cc49586-a164-484a-82b2-cdb0f4f910ee)

- **Edit Book:** Opens a dialog to modify details of an existing book. Users can edit the book's information.

- **Delete Book:** Allows users to remove a selected book from the library. A confirmation dialog is displayed before deletion.

#### Borrowing and Returning Books

- **Borrow:** Enables users to borrow a book for the selected reader. Users can choose a book from the available storage.

- **Return:** Allows users to return a borrowed book. The system updates the borrowed books list accordingly.

### Data Display

- **Readers Table:** Displays information about readers, including their names and other relevant details.

- **Storage Table:** Shows the available books in the library, including details like title, author, genre, and price.

- **Borrowed Books Table:** Presents a list of books borrowed by the selected reader.

### Additional Functionality

- **Populate Borrowed Books:** Updates the borrowed books list based on the selected reader.

- **SetButtons:** Enables or disables buttons based on the availability of books and borrowed books.

## Getting Started

1. Clone the repository.
2. Set up the necessary dependencies.
3. Run the application.
4. If there is an error with web marks, you need to delete all images from the project and install your own.

