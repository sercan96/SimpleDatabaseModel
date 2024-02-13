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

![LazyLoadng](https://github.com/sercan96/SimpleDatabaseModel/assets/38535473/dd7fc284-53ab-4755-956b-bb855e7de00c)

* In this example, when accessing <b>'product.Category.Name'</b>, relational data is automatically loaded via Lazy Loading. The <b>'Category'</b> property is marked with the <b>'virtual'</b> keyword, allowing relational data to be loaded only when needed
   
 <h2> EAGER LOADING </h2>
 
![EagerLoading](https://github.com/sercan96/SimpleDatabaseModel/assets/38535473/502c35e8-8c72-4bc6-91ca-e4fbfac9a8dc)

 In this example, the <b>'Include'</b> method is used to request the loading of the <b>'Category'</b> relational data for the <b>'Products'</b> query. This allows Eager Loading to be used, ensuring that relational data is loaded immediately. As a result, each product and its category are loaded in a single query, eliminating the need for separate queries to access each product's category. This can improve performance.
