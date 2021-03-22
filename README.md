# Salon Client Tracker
#### Created By: Connor Burgess 
* * *

## Description  
Project creates a client tracking solution for salon businesses to keep track of separate stylist-client relationships. Utilizes .Net v5.0 and follows RESTful practices. Relational data is manipulated using ORM through Entity Framework Core in order to abstract and simplify SQL interaction. 

* * *

## Technologies used
* C#
* .Net v5.0
* ASP.NET Core
* Entity Framework Core
* RESTful Routing
* HTML
* CSS
* * *

## User Stories
* As the salon owner, I need to be able to see a list of all stylists.
* As the salon owner, I need to be able to select a stylist, see their details, and see a list of all clients that belong to that stylist.
* As the salon owner, I need to add new stylists to our system when they are hired.
* As the salon owner, I need to be able to add new clients to a specific stylist. I should not be able to add a client if no stylists have been added.

* * *
## Setup 1) Initial Setup
* Ensure .Net v5.0 Core is installed: [download here](https://dotnet.microsoft.com/download/dotnet/5.0)
* Ensure dotnet script is installed: [instructions here](https://github.com/filipw/dotnet-script)
* Clone Repo from GitHub (Link: https://github.com/ConnorBurgess/Salon-Client-Tracker.git)

## Setup 2) Database Setup
* Ensure MySQL is installed [download here](https://www.mysql.com/)
* Ensure MySQL Workbench is installed [download here](https://www.mysql.com/products/workbench/)
* Open MySqlWorkBench and click administration tab
* Click data Import/Restore and check the "Import from Self-Contained File" tab
* Select the included .sql file from top level of cloned project directory and import

## Setup 3) Create appsettings.json
* In root directory of project create a file called "appsettings.json"
* Copy and paste the following into the file:
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=connor_burgess;uid={YOUR UID};pwd={YOUR PWD;"
  }
}
* Input your UID and password from MYSQL database setup and remove curly braces from around pwd/UID. Please note your port may be different.
* If planning to push a project to GitHub, it is advised to avoid revealing sensitive details by [setting up a .gitignore](https://docs.github.com/en/github/using-git/ignoring-files) and ignoring this file.

## Setup 3) Dotnet Setup & Running Program
* Navigate to ./SalonTracker/HairSalon inside of the cloned repo and type $"dotnet restore" (no bling / quotes) in terminal
* In order to run program input $"dotnet run" (no bling / quotes) in terminal

* * *

## To Do:

## Resources Used:

## Additional comments:
* Created on 3/5/21  
* * *

## License:
> *&copy; Connor Burgess, 2021*

Licensed under [MIT license](https://mit-license.org/)

* * *

## Contact Information
_Connor Burgess: [Email](connorburgesscodes@gmail.com)_