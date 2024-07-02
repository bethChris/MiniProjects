# Bug Manager
This is the start of a small bug managing application. The goal of this is to refresh myself on a variety of concepts but focus on SQL basics, API creation, and Java applications.


The outline of the project is as follows:
We'll have a basic database that contains simulated data of users, the bugs they've reported, and various other meta data about the reports
This database will then be accessed via a small API system that will just be able to retrieve the reports and send them to our application.
Then we'll have a java application that will interact with the API and retrieve the information, displaying it to the user.


DATABASE SCHEMA IS AS FOLLOWS:
Users:
    - UserId : int
    - FirstName : char
    - LastName : char

Reports:
    - ReportId : int
    - BugId : int
    - UserId : int
    - ReportDescr : text
    - ReportDate : date
    - ResolvedDate : date

Bugs:
    - BugId : int
    - TextDescr : text
    - Severity : int

*more documentation to follow here shortly*