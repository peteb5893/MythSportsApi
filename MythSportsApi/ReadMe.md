Setup
1. In SQL Server Manager Studio, open a query window and run the contents of the MythSportsDb_Setup_Script.sql
2. Verify the MythSportsDb and SportsEvent table have been created.
3. In appsettings.json, ensure the connection string has the correct server configured.
4. Build the solution, restoring necessary nuget packages.
5. Run the solution.
6. The solution should launch at the url https://localhost:44307/api/sportsevent which returns a list of all SportsEvents in the database. This should be zero at before running the import.
7. Navigate to https://localhost:44307/api/sportsevent/import.
8. This should call out to the dataSourceUrl https://myth.fra1.digitaloceanspaces.com/misc/528%20%281%29.json and retrieve the data, storing it in the database.
9. Navigate back to https://localhost:44307/api/sportsevent and you should now see a list of 200 SportsEvents, with an Id and JsonData property.
10. Copy one of the Ids and append it to the url, for example https://localhost:44307/api/sportsevent/GN09X0E1W3HSJD7 and navigate to it.
11. The individual SportsEvent record with that Id will be loaded from the database.
12. If an ID is not found in the database, for example https://localhost:44307/api/sportsevent/test then a 404 should be returned.

My Approach
1. Examine the dataset
2. Identify the different tables
3. Write SQL script to create tables with appropriate types, relationships and constraints
4. Create a new .Net Core Web API project in VS
5. Add the required Nuget packages
6. Use the command line tool to scaffold the entity framework classes and db context from the database structure
7. Configure the database connectionstring in appsettings.json
8. Configure the database setup in Startup.cs
9. Add a new controller for SportsEvent and use dependency injection to retrieve the database context.
10. Add methods to GetSportsEvents, GetSportsEventById and Import data from the provided data source URL.
