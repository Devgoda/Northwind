## Setup
To run this project: 
- Open the solution in Visual Studio (recommended 2022, Community edition should suffice)
- Publish the SQL project to your local SQL Server
  - Pre-requisite: [SQL Server 2022](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (if unsure which version, simply install Express)
  - Right-click the database project and click "Publish"
    - ![image](https://github.com/user-attachments/assets/a182a2c0-8a7c-45a8-91d3-f8f4f8c3fc47)
  - Click the "Edit" button in the top, and select your local server and connect to it (testing the connection is recommended)
    - ![image](https://github.com/user-attachments/assets/e7b55eb7-d0b3-4bf4-b335-00fe9946e4ba)
  - Fill out the Database name (1), SQLCMD variable (2), and click "Publish" (3) 
    - ![image](https://github.com/user-attachments/assets/5407d742-fced-4b0f-9eba-ef1f5db97676)
    1. The Database name will have disappeared, re-populated it (recommended is "Northwind" to match the connection string in the API project)
    2. The "SeedDummyData" SQLCMD variable will populate dummy data if "Yes" is entered. Note this is **not idempotent**; any subsequent releases against the same database need to contain any value other than "Yes" (e.g. "No")
    3. Click the Publish button (it might be greyed out if you have not exited your cursor out of the SQLCMD variables "Value" box, simploy press the Tab key to fix this)
  - You should see a successful deployment in the "Data Tools Operations" window:
    - ![image](https://github.com/user-attachments/assets/48cc2a45-4fd2-4369-b120-b4144d466d94)

- Set the Northwind.API as the startup project if it isn't already
  - Right-click the Northwind.API project and click "Set as Startup Project"
  - ![image](https://github.com/user-attachments/assets/92ca6601-e149-46ca-b6eb-55991740cef9)
- Run the project using http
  - ![image](https://github.com/user-attachments/assets/ecbc5ffe-de04-4637-adfc-3049d7d20c54)
