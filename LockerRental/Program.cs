// Locker Rental


// Please write an application allowing users to manage airport locker rentals.
// The application should provide users with five menu options to
// view, rent, or end a locker rental, list all locker contents, or quit the application.


// Use a string array of length 100 to store your locker data.
// Locker numbers should be in the range of 1 to 100. Do not allow out-of-range exceptions to crash the application!
// Remember that array indexes start from zero, but humans are comfortable counting from 1. So, when prompting or displaying locker numbers, adjust the input and output accordingly.
// An application loop should keep users in the program until they choose to quit.
// Users should never be able to crash the program with bad input. Use TryParse() and loops to prevent this. 


// DTO class - LockerContents
// Action class - Prompter
// Action Class - LockerManager
// Workflow Class - App

using LockerRental.Workflow;

App.Run();