# Gmail Checker

## Overview
Gmail Checker is a Windows Forms application written in C# that allows users to check if email domains are associated with Gmail. The application reads a list of domains provided by the user, checks each domain, and categorizes them into Gmail or non-Gmail domains.

## Features
- User-friendly interface to input domains.
- Asynchronous checking of domains to determine if they are Gmail.
- Results are saved to `gmail.txt` and `not_gmail.txt` files.
- Error handling to manage exceptions gracefully.

## Prerequisites
- .NET Framework
- Visual Studio or any compatible C# development environment

## How to Use
1. **Clone the repository** (if applicable) or download the source code.
2. **Open the project** in Visual Studio.
3. **Build and run the application**:
   - Press `F5` or click on the `Start` button to run the application.

4. **Input the domains**:
   - Enter the domains you want to check, one per line, in the provided text area.

5. **Click the "Check" button**:
   - The application will disable the check button to prevent multiple clicks and begin checking the domains asynchronously.

6. **Wait for the process to complete**:
   - Once the checking process is complete, a message box will inform you that the check is completed.

7. **Check the results**:
   - The results will be saved in two separate text files:
     - `gmail.txt`: Contains domains associated with Gmail.
     - `not_gmail.txt`: Contains domains not associated with Gmail.

## Exception Handling
- If an error occurs during the domain checking process, an error message will be displayed to the user.

## Dependencies
- [DnsClient.NET](https://github.com/MichaCo/DnsClient.NET): A .NET library to perform DNS lookups.

## Future Improvements
- Add input validation for domain format.
- Implement a progress bar to show the checking progress.
- Enhance the user interface for better user experience.
- Include more comprehensive logging and error handling.
