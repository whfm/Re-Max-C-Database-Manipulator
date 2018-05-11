# Re/Max Database Manipulator C#

Hello! This is my solution for a school project for Advanced C# class. This project attends the requirements of the teacher with an extra plus. I've put a great effort to make it look useful for a real company as well as for an user looking for buying/selling/renting a house.


# Requirements

Students must analyse, conceive and build a window based application that will allow the real estate broker REMAX to manage its employees (agents), clients (buyers and sellers) and products (houses).


## The User Functionality Requirements

These are the functionalities of the Remax application :

 - F1 : The Admin (with full access) manages Employees (admin et
   agents), Houses, Clients (Buyers and Sellers) and Sales (Bonus +5).
 - F2 : The Agent manages ONLY his own Clients (Buyers and Sellers) and
   Houses (And Sales Bonus +5).
 - F3 : Any User can search for a one particular or all the Houses (by
   reference number) and for a particular or all Agents (by employee
   number).

## The Analysis Functionality Requirements

This program should be a multi-tiers application (Gui, Business and Datasource Layers).

- GUI Layer :
Window C# Application with MDI (multiple documents interface) based on the user functionality requirements.
- BUSINESS Layer :
Library of classes for the entities : Company, Employees(User, Admin or Agent), Clients(Buyer or Seller) and Houses.
- DATASOURCE Layer :
Class that encapsulates the database (access) and provides public interfaces for feeding data to the business layer and writing data back to the database.
Microsoft Access database that will contains all the needed data for Remax (Sales bonus +5).

## The Technical Functionality Requirements
-	For the GUI Layer : Use friendly and thematic (Remax related colors and images) windows forms interfaces.
-	For the Business Layer : Apply Object Oriented Concepts like classification (inheritance, composition and aggregate), encapsulation (dotNet’s objects).
-	For the Datasource Layer : Use Ado.net.

## Files
-	Passwords.png : A list of the users with their passwords which grants you access to functionalities of the program.
- View me.pdf : PDF with some screenshots of the system functionality.
