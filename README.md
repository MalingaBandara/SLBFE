# SLBFE - Sri Lanka Bureau of Foreign Employment System

## Project Overview

The SLBFE (Sri Lanka Bureau of Foreign Employment) project is a web-based system designed to manage interactions between registered citizens, bureaus, and foreign companies in Sri Lanka. This application streamlines employment-related processes, such as profile management, qualification assessments, and communication between stakeholders. The primary objective of this project was to gain practical experience in building a full-stack web application with complex modules and multiple user roles.

## Key Features

- **User and Profile Management**: Handles the registration and management of citizens, bureaus, and foreign companies.
- **Qualification Assessments**: Allows citizens to submit and update their qualifications, which are assessed by the bureaus.
- **Communication Module**: Facilitates interaction between registered users and foreign companies.
- **Learning-Focused**: Developed as part of an educational journey to understand the design and implementation of complex web systems.

## Technologies Used

- **HTML, CSS, JavaScript**
- **C# .NET Framework**
- **ASP.NET Web API**
- **Microsoft SQL Server**
- **Entity Framework**
- **Bootstrap for UI Design**

## Project Structure and Code Explanation

1. **Backend API**:
   - The ASP.NET Web API handles the business logic and serves as the backend for the system.
   ```csharp
   [ApiController]
   [Route("api/[controller]")]
   public class CitizenController : ControllerBase {
       // API endpoints for managing citizens
   }
   ```

2. **Frontend UI**:
   - HTML, CSS, and JavaScript power the user interface, while Bootstrap is used for styling.
   ```html
   <div class="container">
       <h2>Citizen Registration</h2>
       <!-- Registration form -->
   </div>
   ```

3. **Database Layer**:
   - Utilizes Microsoft SQL Server and Entity Framework for data persistence.
   ```csharp
   public class Citizen {
       public int Id { get; set; }
       public string Name { get; set; }
       // Other properties
   }
   ```

## Committing Strategy and Learning Insights

The repository follows a structured commit strategy focused on collaboration and learning:
- **Initial Setup Commits**: Includes setting up the project structure, configuring the database, and establishing the backend API.
- **Feature-Specific Commits**: Each commit corresponds to the addition of key features like profile management, qualification assessment, and communication modules.
- **Team Collaboration Commits**: Multiple commits involve resolving conflicts, integrating modules, and ensuring smooth collaboration across the team.
- **Documentation and Commenting**: Includes commits that enhance code clarity and provide detailed comments for better understanding.

These commit strategies highlight both the technical progress and collaborative efforts involved in building the system.

## How to Run the Project

1. Clone the repository:
   ```bash
   git clone https://github.com/MalingaBandara/SLBFE.git
   ```
2. Set up the SQL Server database and update the connection strings in the configuration files.
3. Open the solution in Visual Studio, restore NuGet packages, and build the project.
4. Run the application using IIS Express or your preferred method.

## Purpose and Future Enhancements

The SLBFE project was developed as a group project to gain practical experience in building large-scale web applications. Future enhancements could include adding advanced reporting features, expanding user roles, and integrating external APIs for job postings.
****
