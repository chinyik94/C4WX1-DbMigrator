# C4WX1-DbMigrator

DB Migrator App for C4WX1 to copy schemas from MSSQL DB to PostgreSQL DB

## Technologies used:

- EF Core 8
- EF Core Power Tools
 
## Operational Usage

1. Make sure C4WX1 MSSQL server DB is up to date by running latest DB scripts.
2. Create a new database for C4WX1 in PostgreSQL server
3. Run C4WXX1-DbMigrator App
    a. Specify a valid PostgreSQL connection string
    b. Wait for migration to complete.