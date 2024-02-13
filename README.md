# SimpleDatabaseModel
 It is a project that includes a basic database model.

<h2> Explanation: </h2>

LibraryManagementSystem is a project containing a basic database model for a library management system. In this project, a database model of basic entities such as shelves, books, rooms, authors and categories was created in accordance with the requirements of the library management system.

<h2> Features: </h2>

* Many relationship models have been established between shelves and books.
* Relationships between books, authors and categories are defined.
* Rooms represent the physical locations where shelves are located.
* The database model provides the basic data structure required for the library management system.

<h2> Technologies: </h2>

* The project was developed using technologies such as C# programming language and Entity Framework.
* The database model is designed in a structure suitable for relational database management systems.

<h2> Use: </h2>

* The project can be used as a starting point for those who want to start working on library management system development.
* The database model provides a reference for creating the database structure of library management systems.
* This project aims to create a resource for those who want to contribute to library management system development projects.

<p align="center">
  <img src="https://github.com/sercan96/SimpleDatabaseModel/assets/38535473/849f7ef7-7774-4467-b562-90fc535cdfbe" alt="Diagram">
</p>

* This diagram shows the database model of a particular project. The diagram shows the different entities of the project and the relationships between these entities. For example, it might be a library management system diagram that shows relationships between entities such as books, authors, categories, and shelves.


<p align="center">
  <img src="https://github.com/sercan96/SimpleDatabaseModel/assets/38535473/ae86509e-80a5-449c-972d-e6b325d11b28" alt="Diagram">
</p>


* The BaseConfiguration class is a configuration class used to enable the configuration of a database model with Entity Framework. This class derives from the EntityTypeConfiguration<T> class and specifies the configuration of a specific entity type. The where T : BaseEntity part specifies that this configuration applies to entity types derived from the BaseEntity class.

* The constructor of the BaseConfiguration class is used to configure the database columns of the properties (ModifiedDate, CreatedDate, DeletedDate) in the BaseEntity class. The Property method allows configuring a specific property. The HasColumnName method specifies the name of the column in the database.

* This configuration ensures that the public properties in the BaseEntity class are correctly reflected in the database. For example, the ModifiedDate property is called the "Updated Date" column. This configuration is used to configure the database model with the Entity Framework Code First approach.

 Here I would like to briefly talk about data loading strategies.

 <h2> LAZY LOADING </h2>
 
