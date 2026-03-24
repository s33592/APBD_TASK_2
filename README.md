# APBD_TASK_2

# Project Organization
The project is organized into the following folders:  
Entities - this folder contains all of the classes regarding the domain model.
Services - this folder contains all of the classes/interfaces regarding the business logic
Exceptions - this folder contains all of the custom exceptions
RentalSystem - this folder contains the class representing the final system

# Design decisions 
The University Rental Service system is represented by the Singleton class Database.
The Database class internally utilizes 4 different Services:  
IUserService - responsible for the addition and retrieval of users in the system  
IEquipmentService - responsible for the addition and management of different types of Equipments  
IRentalService - responsible for the management of rentals  
IPenaltyService - responsible for the assignment of penalties to rentals that were returned late

Using this design our system avoids tight-coupling as the System only has a reference to the classes 
that implement the services interfaces which are needed by the system to function as expected. 

All of the Services have a high cohesion as they are only responsible for 1 business functionality
and do not contain or expose a method/data not related to their purpouse
